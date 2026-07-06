using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class SubsurfaceProfileManager
	{
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06001595 RID: 5525 RVA: 0x000025D0 File Offset: 0x000007D0
		private SubsurfaceProfileManager.SubsurfaceProfileData profileData
		{
			[CompilerGenerated]
			get
			{
				// // Func`1[Single] get_getValueDelegate()
				// Func_1_Single_ *Rewired::Utils::Classes::Utility::ValueWatcher<float>::get_getValueDelegate(
				//         ValueWatcher_1_System_Single_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			set
			{
				// // Void set_getValueDelegate(Func`1[Single])
				// void Rewired::Utils::Classes::Utility::ValueWatcher<float>::set_getValueDelegate(
				//         ValueWatcher_1_System_Single_ *this,
				//         Func_1_Single_ *value,
				//         MethodInfo *method)
				// {
				//   MessageDescriptor *v3; // r9
				//   String__Array *v4; // [rsp+28h] [rbp+28h]
				//   String *v5; // [rsp+30h] [rbp+30h]
				//   MethodInfo *v6; // [rsp+38h] [rbp+38h]
				// 
				//   this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA = value;
				//   sub_1800054D0(
				//     (OneofDescriptor *)&this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA,
				//     (OneofDescriptorProto *)value,
				//     (FileDescriptor *)method,
				//     v3,
				//     v4,
				//     v5,
				//     v6);
				// }
				// 
			}
		}

		public SubsurfaceProfileManager()
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void RegisterMaterialCallback()
		{
			// // Void RegisterMaterialCallback()
			// void HG::Rendering::Runtime::SubsurfaceProfileManager::RegisterMaterialCallback(MethodInfo *method)
			// {
			//   UnityAction_2_System_Int32_System_Boolean_ *v1; // rax
			//   __int64 v2; // rdx
			//   __int64 v3; // rcx
			//   UnityAction_2_System_Int32_System_Boolean_ *v4; // rbx
			//   UnityAction_2_System_Int32_System_Boolean_ *v5; // rax
			//   UnityAction_2_System_Int32_System_Boolean_ *v6; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDB68 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SubsurfaceProfileManager::OnShadingStateChanged);
			//     sub_18003C530(&TypeInfo::UnityEngine::Events::UnityAction<int,bool>);
			//     byte_18D8EDB68 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3301, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3301, 0LL);
			//     if ( !Patch )
			//       goto LABEL_6;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_28 *)Patch, 0LL);
			//   }
			//   else
			//   {
			//     v1 = (UnityAction_2_System_Int32_System_Boolean_ *)sub_180004920(TypeInfo::UnityEngine::Events::UnityAction<int,bool>);
			//     v4 = v1;
			//     if ( !v1
			//       || (UnityEngine::Events::UnityAction<int,bool>::UnityAction(
			//             v1,
			//             0LL,
			//             MethodInfo::HG::Rendering::Runtime::SubsurfaceProfileManager::OnShadingStateChanged,
			//             0LL),
			//           UnityEngine::HyperGryph::HGShadingStateSystem::remove_shadingStateChanged(v4, 0LL),
			//           v5 = (UnityAction_2_System_Int32_System_Boolean_ *)sub_180004920(TypeInfo::UnityEngine::Events::UnityAction<int,bool>),
			//           (v6 = v5) == 0LL) )
			//     {
			// LABEL_6:
			//       sub_180B536AC(v3, v2);
			//     }
			//     UnityEngine::Events::UnityAction<int,bool>::UnityAction(
			//       v5,
			//       0LL,
			//       MethodInfo::HG::Rendering::Runtime::SubsurfaceProfileManager::OnShadingStateChanged,
			//       0LL);
			//     UnityEngine::HyperGryph::HGShadingStateSystem::add_shadingStateChanged(v6, 0LL);
			//     UnityEngine::HyperGryph::HGShadingStateSystem::FlushAllMaterialCallbacks(0LL);
			//   }
			// }
			// 
		}

		private static void OnShadingStateChanged(int instanceId, bool state)
		{
			// // Void OnShadingStateChanged(Int32, Boolean)
			// void HG::Rendering::Runtime::SubsurfaceProfileManager::OnShadingStateChanged(
			//         int32_t instanceId,
			//         bool state,
			//         MethodInfo *method)
			// {
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v6; // rdx
			//   SubsurfaceProfileManager *subsurfaceProfileManager_k__BackingField; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3302, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3302, 0LL);
			//     if ( !Patch )
			//       goto LABEL_11;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1172(Patch, instanceId, state, 0LL);
			//   }
			//   else
			//   {
			//     if ( !HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
			//       return;
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( !state )
			//     {
			//       if ( currentManagerContext )
			//       {
			//         subsurfaceProfileManager_k__BackingField = currentManagerContext.fields._subsurfaceProfileManager_k__BackingField;
			//         if ( subsurfaceProfileManager_k__BackingField )
			//         {
			//           HG::Rendering::Runtime::SubsurfaceProfileManager::UnregisterFromMaterial(
			//             subsurfaceProfileManager_k__BackingField,
			//             instanceId,
			//             0LL);
			//           return;
			//         }
			//       }
			// LABEL_11:
			//       sub_180B536AC(subsurfaceProfileManager_k__BackingField, v6);
			//     }
			//     if ( !currentManagerContext )
			//       goto LABEL_11;
			//     subsurfaceProfileManager_k__BackingField = currentManagerContext.fields._subsurfaceProfileManager_k__BackingField;
			//     if ( !subsurfaceProfileManager_k__BackingField )
			//       goto LABEL_11;
			//     HG::Rendering::Runtime::SubsurfaceProfileManager::RegisterFromMaterial(
			//       subsurfaceProfileManager_k__BackingField,
			//       instanceId,
			//       0LL);
			//   }
			// }
			// 
		}

		public void RegisterFromMaterial(int instanceId)
		{
			// // Void RegisterFromMaterial(Int32)
			// void HG::Rendering::Runtime::SubsurfaceProfileManager::RegisterFromMaterial(
			//         SubsurfaceProfileManager *this,
			//         int32_t instanceId,
			//         MethodInfo *method)
			// {
			//   uint32_t MaterialHandle; // eax
			//   Object_1 *Material; // rsi
			//   Object_1 *SubsurfaceProfile; // rbp
			//   int32_t v8; // ebx
			//   struct HGShaderIDs__Class *v9; // rcx
			//   HGShaderIDs__StaticFields *static_fields; // rdx
			//   int32_t SubsurfaceProfileInt; // edx
			//   int v12; // ecx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   SubsurfaceProfileManager_ProfileKey key; // [rsp+58h] [rbp+20h]
			// 
			//   if ( !byte_18D9196F6 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D9196F6 = 1;
			//   }
			//   *(_DWORD *)&key.terrain = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3304, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3304, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
			//         (ILFixDynamicMethodWrapper_26 *)Patch,
			//         (Object *)this,
			//         instanceId,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_13;
			//   }
			//   MaterialHandle = UnityEngine::HyperGryph::HGShadingStateSystem::GetMaterialHandle(instanceId, 0LL);
			//   if ( !MaterialHandle )
			//     return;
			//   Material = (Object_1 *)UnityEngine::HyperGryph::HGShadingStateSystem::GetMaterial(MaterialHandle, 0LL);
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Implicit(Material, 0LL) )
			//     return;
			//   SubsurfaceProfile = (Object_1 *)HG::Rendering::Runtime::MaterialSubsurfaceExtensions::GetSubsurfaceProfile(
			//                                     (Material *)Material,
			//                                     0LL);
			//   key.instanceId = instanceId;
			//   key.terrain = 0;
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Implicit(SubsurfaceProfile, 0LL) )
			//   {
			//     HG::Rendering::Runtime::SubsurfaceProfileManager::UnregisterProfileImpl(this, key, 0LL);
			//     return;
			//   }
			//   v8 = HG::Rendering::Runtime::SubsurfaceProfileManager::RegisterProfileImpl(
			//          this,
			//          key,
			//          (HGSubsurfaceProfile *)SubsurfaceProfile,
			//          0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//   v9 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs;
			//   static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//   if ( !Material )
			// LABEL_13:
			//     sub_180B536AC(v9, static_fields);
			//   SubsurfaceProfileInt = static_fields._SubsurfaceProfileInt;
			//   v12 = v8 + 1;
			//   if ( v8 == -1 )
			//     v12 = 0;
			//   UnityEngine::Material::SetFloatImpl((Material *)Material, SubsurfaceProfileInt, (float)v12, 0LL);
			// }
			// 
		}

		public void UnregisterFromMaterial(int instanceId)
		{
			// // Void UnregisterFromMaterial(Int32)
			// void HG::Rendering::Runtime::SubsurfaceProfileManager::UnregisterFromMaterial(
			//         SubsurfaceProfileManager *this,
			//         int32_t instanceId,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3314, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3314, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
			//       (ILFixDynamicMethodWrapper_26 *)Patch,
			//       (Object *)this,
			//       instanceId,
			//       0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::SubsurfaceProfileManager::UnregisterProfileImpl(
			//       this,
			//       (SubsurfaceProfileManager_ProfileKey)(unsigned int)instanceId,
			//       0LL);
			//   }
			// }
			// 
		}

		public void RegisterFromTerrain(HGSubsurfaceProfile profile)
		{
			// // Void RegisterFromTerrain(HGSubsurfaceProfile)
			// void HG::Rendering::Runtime::SubsurfaceProfileManager::RegisterFromTerrain(
			//         SubsurfaceProfileManager *this,
			//         HGSubsurfaceProfile *profile,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   int32_t v6; // eax
			//   struct HGShaderIDs__Class *v7; // rdx
			//   int32_t v8; // ebx
			//   int v9; // ecx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   SubsurfaceProfileManager_ProfileKey key; // [rsp+48h] [rbp+20h]
			// 
			//   if ( !byte_18D8EDB69 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDB69 = 1;
			//   }
			//   key = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3315, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3315, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v12, v11);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)profile,
			//       0LL);
			//   }
			//   else
			//   {
			//     key.terrain = 1;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
			//     if ( UnityEngine::Object::op_Implicit((Object_1 *)profile, 0LL) )
			//     {
			//       v6 = HG::Rendering::Runtime::SubsurfaceProfileManager::RegisterProfileImpl(this, key, profile, 0LL);
			//       v7 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs;
			//       v8 = v6;
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGShaderIDs._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(
			//           TypeInfo::HG::Rendering::Runtime::HGShaderIDs,
			//           TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         v7 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs;
			//       }
			//       v9 = v8 + 1;
			//       if ( v8 == -1 )
			//         v9 = 0;
			//       UnityEngine::Shader::SetGlobalFloatImpl(v7.static_fields._TerrainSubsurfaceProfileInt, (float)v9, 0LL);
			//     }
			//     else
			//     {
			//       HG::Rendering::Runtime::SubsurfaceProfileManager::UnregisterProfileImpl(this, key, 0LL);
			//     }
			//   }
			// }
			// 
		}

		public void UnregisterFromTerrain()
		{
			// // Void UnregisterFromTerrain()
			// void HG::Rendering::Runtime::SubsurfaceProfileManager::UnregisterFromTerrain(
			//         SubsurfaceProfileManager *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3316, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3316, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::SubsurfaceProfileManager::UnregisterProfileImpl(
			//       this,
			//       (SubsurfaceProfileManager_ProfileKey)0x100000000LL,
			//       0LL);
			//   }
			// }
			// 
		}

		public void UpdateMaterialProfile(Material mat, HGSubsurfaceProfile profile, [MetadataOffset(Offset = "0x01F91B0E")] bool force = false)
		{
			// // Void UpdateMaterialProfile(Material, HGSubsurfaceProfile, Boolean)
			// void HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateMaterialProfile(
			//         SubsurfaceProfileManager *this,
			//         Material *mat,
			//         HGSubsurfaceProfile *profile,
			//         bool force,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   int32_t updated; // ebx
			//   int v12; // ecx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   SubsurfaceProfileManager_ProfileKey key; // [rsp+30h] [rbp-18h]
			// 
			//   if ( !byte_18D9196F7 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D9196F7 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3317, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3317, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_102(
			//         (ILFixDynamicMethodWrapper_13 *)Patch,
			//         (Object *)this,
			//         (Object *)mat,
			//         (Object *)profile,
			//         force,
			//         0LL);
			//       return;
			//     }
			// LABEL_10:
			//     sub_180B536AC(v10, v9);
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Implicit((Object_1 *)mat, 0LL) )
			//     return;
			//   if ( !mat )
			//     goto LABEL_10;
			//   key = (SubsurfaceProfileManager_ProfileKey)(unsigned int)UnityEngine::Object::GetInstanceID((Object_1 *)mat, 0LL);
			//   updated = HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateProfileImpl(this, key, profile, force, 0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//   v12 = updated + 1;
			//   if ( updated == -1 )
			//     v12 = 0;
			//   UnityEngine::Material::SetFloatImpl(
			//     mat,
			//     TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._SubsurfaceProfileInt,
			//     (float)v12,
			//     0LL);
			// }
			// 
		}

		public int GetTerrainSubsurfaceProfileInt()
		{
			// // Int32 GetTerrainSubsurfaceProfileInt()
			// int32_t HG::Rendering::Runtime::SubsurfaceProfileManager::GetTerrainSubsurfaceProfileInt(
			//         SubsurfaceProfileManager *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *instanceId2Index; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int32_t value; // [rsp+40h] [rbp+18h] BYREF
			//   SubsurfaceProfileManager_ProfileKey key; // [rsp+48h] [rbp+20h]
			// 
			//   if ( !byte_18D9196F8 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::TryGetValue);
			//     byte_18D9196F8 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3319, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3319, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, 0LL);
			// LABEL_9:
			//     sub_180B536AC(instanceId2Index, v3);
			//   }
			//   key = 0LL;
			//   value = -1;
			//   instanceId2Index = this.fields.instanceId2Index;
			//   key.terrain = 1;
			//   if ( !instanceId2Index )
			//     goto LABEL_9;
			//   System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::TryGetValue(
			//     instanceId2Index,
			//     key,
			//     &value,
			//     MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::TryGetValue);
			//   if ( value == -1 )
			//     return 0;
			//   else
			//     return value + 1;
			// }
			// 
			return 0;
		}

		public void UpdateTerrainProfile(HGSubsurfaceProfile profile, [MetadataOffset(Offset = "0x01F91B0F")] bool force = false)
		{
			// // Void UpdateTerrainProfile(HGSubsurfaceProfile, Boolean)
			// void HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateTerrainProfile(
			//         SubsurfaceProfileManager *this,
			//         HGSubsurfaceProfile *profile,
			//         bool force,
			//         MethodInfo *method)
			// {
			//   int32_t updated; // ebx
			//   int v8; // ecx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			// 
			//   if ( !byte_18D9196F9 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     byte_18D9196F9 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3320, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3320, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_17(
			//       (ILFixDynamicMethodWrapper_9 *)Patch,
			//       (Object *)this,
			//       (Object *)profile,
			//       force,
			//       0LL);
			//   }
			//   else
			//   {
			//     updated = HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateProfileImpl(
			//                 this,
			//                 (SubsurfaceProfileManager_ProfileKey)0x100000000LL,
			//                 profile,
			//                 force,
			//                 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     v8 = updated + 1;
			//     if ( updated == -1 )
			//       v8 = 0;
			//     UnityEngine::Shader::SetGlobalFloatImpl(
			//       TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._TerrainSubsurfaceProfileInt,
			//       (float)v8,
			//       0LL);
			//   }
			// }
			// 
		}

		private int FindAndAddProfileImpl(SubsurfaceProfileManager.ProfileKey key, HGSubsurfaceProfile profile, [MetadataOffset(Offset = "0x01F91B10")] bool force = false)
		{
			// // Int32 FindAndAddProfileImpl(SubsurfaceProfileManager+ProfileKey, HGSubsurfaceProfile, Boolean)
			// int32_t HG::Rendering::Runtime::SubsurfaceProfileManager::FindAndAddProfileImpl(
			//         SubsurfaceProfileManager *this,
			//         SubsurfaceProfileManager_ProfileKey key,
			//         HGSubsurfaceProfile *profile,
			//         bool force,
			//         MethodInfo *method)
			// {
			//   int32_t v9; // esi
			//   int32_t v10; // edi
			//   __int64 v11; // rdx
			//   int32_t v12; // r14d
			//   Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *profileList; // rcx
			//   SubsurfaceProfileManager_SubsurfaceProfileNode *v14; // rax
			//   char v15; // r14
			//   _DWORD *v16; // rax
			//   SubsurfaceProfileManager_SubsurfaceProfileNode__Array *v17; // rbx
			//   __int64 v18; // rax
			//   HGRenderPathBase_HGRenderPathResources *v19; // rdx
			//   PassConstructorID__Enum__Array *v20; // r8
			//   HGCamera *v21; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *P3; // [rsp+20h] [rbp-38h]
			//   MethodInfo *v25; // [rsp+28h] [rbp-30h]
			// 
			//   if ( !byte_18D9196FA )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::Add);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&off_18D5159C0);
			//     byte_18D9196FA = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3312, 0LL) )
			//   {
			//     v9 = -1;
			//     v10 = -1;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( !UnityEngine::Object::op_Inequality((Object_1 *)profile, 0LL, 0LL) )
			//       return v10;
			//     v12 = 0;
			//     while ( 1 )
			//     {
			//       profileList = (Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)this.fields.profileList;
			//       if ( !profileList )
			//         goto LABEL_31;
			//       if ( *(int *)sub_18037A2E0(profileList, v12) > 0 )
			//       {
			//         profileList = (Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)this.fields.profileList;
			//         if ( !profileList )
			//           goto LABEL_31;
			//         v14 = (SubsurfaceProfileManager_SubsurfaceProfileNode *)sub_18037A2E0(profileList, v12);
			//         if ( HG::Rendering::Runtime::SubsurfaceProfileManager::SubsurfaceProfileNode::Equals(v14, profile, 0LL) )
			//           break;
			//       }
			//       if ( v9 == -1 )
			//       {
			//         profileList = (Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)this.fields.profileList;
			//         if ( !profileList )
			//           goto LABEL_31;
			//         if ( !*(_DWORD *)sub_18037A2E0(profileList, v12) )
			//           v9 = v12;
			//       }
			//       if ( ++v12 >= 15 )
			//         goto LABEL_15;
			//     }
			//     v10 = v12;
			//     if ( v12 == -1 )
			// LABEL_15:
			//       v15 = 1;
			//     else
			//       v15 = 0;
			//     if ( !v15 )
			//       v9 = v10;
			//     v10 = v9;
			//     if ( v9 == -1 )
			//     {
			//       HG::Rendering::HGRPLogger::LogError((String *)"Subsurface profile exceed max count", 0LL);
			//       return v10;
			//     }
			//     profileList = this.fields.instanceId2Index;
			//     if ( profileList )
			//     {
			//       System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::Add(
			//         profileList,
			//         key,
			//         v9,
			//         MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::Add);
			//       profileList = (Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)this.fields.profileList;
			//       if ( profileList )
			//       {
			//         v16 = (_DWORD *)sub_18037A2E0(profileList, v9);
			//         ++*v16;
			//         if ( !v15 )
			//           goto LABEL_27;
			//         v17 = this.fields.profileList;
			//         if ( v17 )
			//         {
			//           *(_QWORD *)(sub_18037A2E0(this.fields.profileList, v9) + 8) = profile;
			//           v18 = sub_18037A2E0(v17, v9);
			//           sub_1800054D0((HGRenderPathScene *)(v18 + 8), v19, v20, v21, P3, v25);
			// LABEL_27:
			//           if ( force | (unsigned __int8)v15 )
			//             HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateProfileData(this, v9, 0LL);
			//           return v10;
			//         }
			//       }
			//     }
			// LABEL_31:
			//     sub_180B536AC(profileList, v11);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3312, 0LL);
			//   if ( !Patch )
			//     goto LABEL_31;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1174(Patch, (Object *)this, key, (Object *)profile, force, 0LL);
			// }
			// 
			return 0;
		}

		private int UpdateProfileImpl(SubsurfaceProfileManager.ProfileKey key, HGSubsurfaceProfile profile, bool force)
		{
			// // Int32 UpdateProfileImpl(SubsurfaceProfileManager+ProfileKey, HGSubsurfaceProfile, Boolean)
			// int32_t HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateProfileImpl(
			//         SubsurfaceProfileManager *this,
			//         SubsurfaceProfileManager_ProfileKey key,
			//         HGSubsurfaceProfile *profile,
			//         bool force,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *instanceId2Index; // rcx
			//   __int64 v11; // rsi
			//   SubsurfaceProfileManager_SubsurfaceProfileNode *v12; // rax
			//   char v13; // r14
			//   _DWORD *v14; // rax
			//   SubsurfaceProfileManager_SubsurfaceProfileNode__Array *profileList; // r14
			//   __int64 v16; // rax
			//   HGRenderPathBase_HGRenderPathResources *v17; // rdx
			//   PassConstructorID__Enum__Array *v18; // r8
			//   HGCamera *v19; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *P3; // [rsp+20h] [rbp-38h]
			//   MethodInfo *v23; // [rsp+28h] [rbp-30h]
			//   int32_t value[10]; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D9196FB )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::TryGetValue);
			//     byte_18D9196FB = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3318, 0LL) )
			//   {
			//     HG::Rendering::Runtime::SubsurfaceProfileManager::TryInitialize(this, 0LL);
			//     instanceId2Index = this.fields.instanceId2Index;
			//     value[0] = -1;
			//     if ( instanceId2Index )
			//     {
			//       if ( !System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::TryGetValue(
			//               instanceId2Index,
			//               key,
			//               value,
			//               MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::TryGetValue) )
			//       {
			//         LODWORD(v11) = value[0];
			//         return v11;
			//       }
			//       instanceId2Index = (Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)this.fields.profileList;
			//       if ( instanceId2Index )
			//       {
			//         v11 = value[0];
			//         v12 = (SubsurfaceProfileManager_SubsurfaceProfileNode *)sub_18037A2E0(instanceId2Index, value[0]);
			//         if ( HG::Rendering::Runtime::SubsurfaceProfileManager::SubsurfaceProfileNode::Equals(v12, profile, 0LL) )
			//         {
			//           if ( force )
			//             HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateProfileData(this, v11, 0LL);
			//           return v11;
			//         }
			//         instanceId2Index = this.fields.instanceId2Index;
			//         if ( instanceId2Index )
			//         {
			//           System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::Remove(
			//             instanceId2Index,
			//             key,
			//             MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::Remove);
			//           instanceId2Index = (Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)this.fields.profileList;
			//           v13 = 0;
			//           if ( instanceId2Index )
			//           {
			//             v14 = (_DWORD *)sub_18037A2E0(instanceId2Index, v11);
			//             --*v14;
			//             instanceId2Index = (Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)this.fields.profileList;
			//             if ( instanceId2Index )
			//             {
			//               if ( *(_DWORD *)sub_18037A2E0(instanceId2Index, v11) )
			//               {
			// LABEL_14:
			//                 if ( force | (unsigned __int8)v13 )
			//                   HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateProfileData(this, v11, 0LL);
			//                 LODWORD(v11) = HG::Rendering::Runtime::SubsurfaceProfileManager::FindAndAddProfileImpl(
			//                                  this,
			//                                  key,
			//                                  profile,
			//                                  force,
			//                                  0LL);
			//                 return v11;
			//               }
			//               profileList = this.fields.profileList;
			//               if ( profileList )
			//               {
			//                 *(_QWORD *)(sub_18037A2E0(this.fields.profileList, v11) + 8) = 0LL;
			//                 v16 = sub_18037A2E0(profileList, v11);
			//                 sub_1800054D0((HGRenderPathScene *)(v16 + 8), v17, v18, v19, P3, v23);
			//                 v13 = 1;
			//                 goto LABEL_14;
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_22:
			//     sub_180B536AC(instanceId2Index, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3318, 0LL);
			//   if ( !Patch )
			//     goto LABEL_22;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1174(Patch, (Object *)this, key, (Object *)profile, force, 0LL);
			// }
			// 
			return 0;
		}

		private int RegisterProfileImpl(SubsurfaceProfileManager.ProfileKey key, HGSubsurfaceProfile profile)
		{
			// // Int32 RegisterProfileImpl(SubsurfaceProfileManager+ProfileKey, HGSubsurfaceProfile)
			// int32_t HG::Rendering::Runtime::SubsurfaceProfileManager::RegisterProfileImpl(
			//         SubsurfaceProfileManager *this,
			//         SubsurfaceProfileManager_ProfileKey key,
			//         HGSubsurfaceProfile *profile,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rsi
			//   __int64 v8; // rdx
			//   Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *instanceId2Index; // rcx
			//   SubsurfaceProfileManager_SubsurfaceProfileNode *v10; // rax
			//   _DWORD *v11; // rax
			//   SubsurfaceProfileManager_SubsurfaceProfileNode__Array *profileList; // r14
			//   __int64 v13; // rax
			//   HGRenderPathBase_HGRenderPathResources *v14; // rdx
			//   PassConstructorID__Enum__Array *v15; // r8
			//   HGCamera *v16; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v19; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v20; // [rsp+28h] [rbp-20h]
			//   int32_t value[6]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9196FC )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::TryGetValue);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D9196FC = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3305, 0LL) )
			//   {
			//     HG::Rendering::Runtime::SubsurfaceProfileManager::TryInitialize(this, 0LL);
			//     LODWORD(v7) = -1;
			//     value[0] = -1;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Implicit((Object_1 *)profile, 0LL) )
			//     {
			//       instanceId2Index = this.fields.instanceId2Index;
			//       if ( !instanceId2Index )
			//         goto LABEL_18;
			//       if ( !System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::TryGetValue(
			//               instanceId2Index,
			//               key,
			//               value,
			//               MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::TryGetValue) )
			//         goto LABEL_15;
			//       instanceId2Index = (Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)this.fields.profileList;
			//       if ( !instanceId2Index )
			//         goto LABEL_18;
			//       v7 = value[0];
			//       v10 = (SubsurfaceProfileManager_SubsurfaceProfileNode *)sub_18037A2E0(instanceId2Index, value[0]);
			//       if ( !HG::Rendering::Runtime::SubsurfaceProfileManager::SubsurfaceProfileNode::Equals(v10, profile, 0LL) )
			//       {
			//         instanceId2Index = this.fields.instanceId2Index;
			//         if ( !instanceId2Index )
			//           goto LABEL_18;
			//         System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::Remove(
			//           instanceId2Index,
			//           key,
			//           MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::Remove);
			//         instanceId2Index = (Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)this.fields.profileList;
			//         if ( !instanceId2Index )
			//           goto LABEL_18;
			//         v11 = (_DWORD *)sub_18037A2E0(instanceId2Index, v7);
			//         --*v11;
			//         instanceId2Index = (Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)this.fields.profileList;
			//         if ( !instanceId2Index )
			//           goto LABEL_18;
			//         if ( !*(_DWORD *)sub_18037A2E0(instanceId2Index, v7) )
			//         {
			//           profileList = this.fields.profileList;
			//           if ( profileList )
			//           {
			//             *(_QWORD *)(sub_18037A2E0(this.fields.profileList, v7) + 8) = 0LL;
			//             v13 = sub_18037A2E0(profileList, v7);
			//             sub_1800054D0((HGRenderPathScene *)(v13 + 8), v14, v15, v16, v19, v20);
			//             HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateProfileData(this, v7, 0LL);
			//             goto LABEL_15;
			//           }
			// LABEL_18:
			//           sub_180B536AC(instanceId2Index, v8);
			//         }
			// LABEL_15:
			//         LODWORD(v7) = HG::Rendering::Runtime::SubsurfaceProfileManager::FindAndAddProfileImpl(
			//                         this,
			//                         key,
			//                         profile,
			//                         0,
			//                         0LL);
			//       }
			//     }
			//     return v7;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3305, 0LL);
			//   if ( !Patch )
			//     goto LABEL_18;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1175(Patch, (Object *)this, key, (Object *)profile, 0LL);
			// }
			// 
			return 0;
		}

		private void UnregisterProfileImpl(SubsurfaceProfileManager.ProfileKey key)
		{
		}

		public void BindProfileData(HGRenderGraphContext context)
		{
			// // Void BindProfileData(HGRenderGraphContext)
			// void HG::Rendering::Runtime::SubsurfaceProfileManager::BindProfileData(
			//         SubsurfaceProfileManager *this,
			//         HGRenderGraphContext *context,
			//         MethodInfo *method)
			// {
			//   HGShaderIDs__StaticFields *static_fields; // rdx
			//   _DWORD *p_CB0; // rcx
			//   Texture **profileData_k__BackingField; // rsi
			//   CommandBuffer *cmd; // r14
			//   int32_t v9; // r15d
			//   RenderTargetIdentifier *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int128 v13; // xmm1
			//   CommandBuffer *v14; // r14
			//   int32_t SubsurfacePenumbraLutArray; // r15d
			//   RenderTargetIdentifier *v16; // rax
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   __int128 v19; // xmm1
			//   CommandBuffer *v20; // r14
			//   int32_t SubsurfaceIndirectLutArray; // r15d
			//   RenderTargetIdentifier *v22; // rax
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   __int128 v25; // xmm1
			//   int v26; // esi
			//   float *v27; // r15
			//   __int64 v28; // rax
			//   HGSubsurfaceProfile *v29; // r14
			//   CBHandle *ConstantBuffer; // rax
			//   void *ptr; // xmm1_8
			//   __int64 v32; // rdx
			//   _OWORD *v33; // rax
			//   _OWORD *v34; // rcx
			//   __int128 v35; // xmm1
			//   __int128 v36; // xmm0
			//   __int128 v37; // xmm1
			//   __int128 v38; // xmm0
			//   __int128 v39; // xmm1
			//   __int128 v40; // xmm0
			//   __int128 v41; // xmm1
			//   __int128 v42; // xmm1
			//   __int128 v43; // xmm0
			//   __int128 v44; // xmm1
			//   __int128 v45; // xmm0
			//   __int128 v46; // xmm1
			//   CommandBuffer *v47; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   RenderTargetIdentifier offset_8; // [rsp+38h] [rbp-D0h] BYREF
			//   RenderTargetIdentifier v50; // [rsp+68h] [rbp-A0h] BYREF
			//   Vector3 v51; // [rsp+98h] [rbp-70h] BYREF
			//   RenderTargetIdentifier v52; // [rsp+A8h] [rbp-60h] BYREF
			//   _BYTE v53[4]; // [rsp+D8h] [rbp-30h] BYREF
			//   char v54; // [rsp+DCh] [rbp-2Ch] BYREF
			//   _BYTE v55[480]; // [rsp+2B8h] [rbp+1B0h] BYREF
			// 
			//   if ( !byte_18D9196FD )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<HG::Rendering::Runtime::SubsurfaceProfileManager::SubsurfaceProfileConstants>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D9196FD = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3321, 0LL) )
			//   {
			//     HG::Rendering::Runtime::SubsurfaceProfileManager::TryInitialize(this, 0LL);
			//     profileData_k__BackingField = (Texture **)this.fields._profileData_k__BackingField;
			//     if ( context )
			//     {
			//       cmd = context.fields.cmd;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//       p_CB0 = &TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._CB0;
			//       v9 = p_CB0[833];
			//       if ( profileData_k__BackingField )
			//       {
			//         v10 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v50, profileData_k__BackingField[2], 0LL);
			//         if ( !cmd )
			//           sub_180B536AC(v12, v11);
			//         v13 = *(_OWORD *)&v10.m_BufferPointer;
			//         *(_OWORD *)&offset_8.m_Type = *(_OWORD *)&v10.m_Type;
			//         *(_QWORD *)&offset_8.m_DepthSlice = *(_QWORD *)&v10.m_DepthSlice;
			//         *(_OWORD *)&offset_8.m_BufferPointer = v13;
			//         UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, v9, &offset_8, 0LL);
			//         v14 = context.fields.cmd;
			//         SubsurfacePenumbraLutArray = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._SubsurfacePenumbraLutArray;
			//         v16 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v52, profileData_k__BackingField[3], 0LL);
			//         if ( !v14 )
			//           sub_180B536AC(v18, v17);
			//         v19 = *(_OWORD *)&v16.m_BufferPointer;
			//         *(_OWORD *)&v50.m_Type = *(_OWORD *)&v16.m_Type;
			//         *(_QWORD *)&v50.m_DepthSlice = *(_QWORD *)&v16.m_DepthSlice;
			//         *(_OWORD *)&v50.m_BufferPointer = v19;
			//         UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(v14, SubsurfacePenumbraLutArray, &v50, 0LL);
			//         v20 = context.fields.cmd;
			//         SubsurfaceIndirectLutArray = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._SubsurfaceIndirectLutArray;
			//         v22 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v52, profileData_k__BackingField[4], 0LL);
			//         if ( !v20 )
			//           sub_180B536AC(v24, v23);
			//         v25 = *(_OWORD *)&v22.m_BufferPointer;
			//         *(_OWORD *)&offset_8.m_Type = *(_OWORD *)&v22.m_Type;
			//         *(_QWORD *)&offset_8.m_DepthSlice = *(_QWORD *)&v22.m_DepthSlice;
			//         *(_OWORD *)&offset_8.m_BufferPointer = v25;
			//         UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(v20, SubsurfaceIndirectLutArray, &offset_8, 0LL);
			//         sub_1802F01E0(v53, 0LL, 480LL);
			//         v26 = 0;
			//         v27 = (float *)&v54;
			//         do
			//         {
			//           p_CB0 = this.fields.profileList;
			//           if ( !p_CB0 )
			//             goto LABEL_25;
			//           v28 = sub_18037A2E0(p_CB0, v26);
			//           p_CB0 = this.fields.profileList;
			//           v29 = *(HGSubsurfaceProfile **)(v28 + 8);
			//           if ( !p_CB0 )
			//             goto LABEL_25;
			//           if ( *(int *)sub_18037A2E0(p_CB0, v26) > 0 )
			//           {
			//             sub_180002C70(TypeInfo::UnityEngine::Object);
			//             if ( UnityEngine::Object::op_Inequality((Object_1 *)v29, 0LL, 0LL) )
			//             {
			//               if ( !v29 )
			//                 goto LABEL_25;
			//               *(v27 - 1) = UnityEngine::HGSubsurfaceProfile::get_subsurfaceNormalLerp(&v51, v29, 0LL).x;
			//               *v27 = UnityEngine::HGSubsurfaceProfile::get_subsurfaceNormalLerp((Vector3 *)&v50, v29, 0LL).y;
			//               v27[1] = UnityEngine::HGSubsurfaceProfile::get_subsurfaceNormalLerp((Vector3 *)&offset_8, v29, 0LL).z;
			//               v27[2] = UnityEngine::HGSubsurfaceProfile::get_curvatureScale(v29, 0LL);
			//               v27[60] = UnityEngine::HGSubsurfaceProfile::get_penumbraScale(v29, 0LL);
			//             }
			//           }
			//           ++v26;
			//           v27 += 4;
			//         }
			//         while ( v26 < 15 );
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//         ConstantBuffer = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                            (CBHandle *)&v50,
			//                            &context.fields.renderContext,
			//                            480,
			//                            0LL);
			//         ptr = ConstantBuffer.ptr;
			//         *(_OWORD *)&offset_8.m_Type = *(_OWORD *)&ConstantBuffer.bufferId;
			//         offset_8.m_BufferPointer = ptr;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//         v32 = 3LL;
			//         v33 = v55;
			//         v34 = v53;
			//         do
			//         {
			//           v35 = v34[1];
			//           *v33 = *v34;
			//           v36 = v34[2];
			//           v33[1] = v35;
			//           v37 = v34[3];
			//           v33[2] = v36;
			//           v38 = v34[4];
			//           v33[3] = v37;
			//           v39 = v34[5];
			//           v33[4] = v38;
			//           v40 = v34[6];
			//           v33[5] = v39;
			//           v41 = v34[7];
			//           v34 += 8;
			//           v33[6] = v40;
			//           v33 += 8;
			//           *(v33 - 1) = v41;
			//           --v32;
			//         }
			//         while ( v32 );
			//         v42 = v34[1];
			//         *v33 = *v34;
			//         v43 = v34[2];
			//         v33[1] = v42;
			//         v44 = v34[3];
			//         v33[2] = v43;
			//         v45 = v34[4];
			//         v33[3] = v44;
			//         v46 = v34[5];
			//         v33[4] = v45;
			//         v33[5] = v46;
			//         sub_180831FF4(&offset_8, v55, 128LL);
			//         v47 = context.fields.cmd;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         if ( v47 )
			//         {
			//           UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
			//             v47,
			//             offset_8.m_Type,
			//             static_fields._SubsurfaceProfileConstants,
			//             offset_8.m_NameID,
			//             480,
			//             0LL);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_25:
			//     sub_180B536AC(p_CB0, static_fields);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3321, 0LL);
			//   if ( !Patch )
			//     goto LABEL_25;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)context,
			//     0LL);
			// }
			// 
		}

		private void UpdateProfileDataImpl(int index)
		{
			// // Void UpdateProfileDataImpl(Int32)
			// void HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateProfileDataImpl(
			//         SubsurfaceProfileManager *this,
			//         int32_t index,
			//         MethodInfo *method)
			// {
			//   __int64 dstElement; // rsi
			//   __int64 v5; // rdx
			//   SubsurfaceProfileManager_SubsurfaceProfileNode__Array *profileList; // rcx
			//   Object_1 *v7; // rbx
			//   __int64 v8; // rax
			//   HGSubsurfaceProfile *v9; // rbp
			//   Object_1 *scatterLut; // rbx
			//   Texture2D *v11; // rax
			//   SubsurfaceProfileManager_SubsurfaceProfileData *profileData_k__BackingField; // rbx
			//   Texture *v13; // r14
			//   Texture *scatterLutArray; // rbx
			//   Object_1 *penumbraLut; // rbx
			//   Texture2D *v16; // rax
			//   SubsurfaceProfileManager_SubsurfaceProfileData *v17; // rbx
			//   Texture *v18; // r14
			//   Texture *penumbraLutArray; // rbx
			//   Object_1 *indirectLut; // rbx
			//   Texture2D *v21; // rax
			//   SubsurfaceProfileManager_SubsurfaceProfileData *v22; // rbx
			//   Texture *v23; // rbp
			//   Texture *indirectLutArray; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   dstElement = index;
			//   if ( !byte_18D9196FE )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Graphics);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D9196FE = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3311, 0LL) )
			//   {
			//     if ( (unsigned int)dstElement > 0xE )
			//       return;
			//     profileList = this.fields.profileList;
			//     if ( profileList )
			//     {
			//       if ( !*(_DWORD *)sub_18037A2E0(profileList, dstElement) )
			//         return;
			//       profileList = this.fields.profileList;
			//       if ( profileList )
			//       {
			//         v7 = *(Object_1 **)(sub_18037A2E0(profileList, dstElement) + 8);
			//         sub_180002C70(TypeInfo::UnityEngine::Object);
			//         if ( UnityEngine::Object::op_Equality(v7, 0LL, 0LL) )
			//           return;
			//         profileList = this.fields.profileList;
			//         if ( profileList )
			//         {
			//           v8 = sub_18037A2E0(profileList, dstElement);
			//           v9 = *(HGSubsurfaceProfile **)(v8 + 8);
			//           if ( v9 )
			//           {
			//             scatterLut = (Object_1 *)UnityEngine::HGSubsurfaceProfile::get_scatterLut(
			//                                        *(HGSubsurfaceProfile **)(v8 + 8),
			//                                        0LL);
			//             sub_180002C70(TypeInfo::UnityEngine::Object);
			//             if ( UnityEngine::Object::op_Implicit(scatterLut, 0LL) )
			//             {
			//               v11 = UnityEngine::HGSubsurfaceProfile::get_scatterLut(v9, 0LL);
			//               profileData_k__BackingField = this.fields._profileData_k__BackingField;
			//               v13 = (Texture *)v11;
			//               if ( !profileData_k__BackingField )
			//                 goto LABEL_21;
			//               scatterLutArray = (Texture *)profileData_k__BackingField.fields.scatterLutArray;
			//               sub_180002C70(TypeInfo::UnityEngine::Graphics);
			//               UnityEngine::Graphics::CopyTexture(v13, 0, 0, scatterLutArray, dstElement, 0, 0LL);
			//             }
			//             penumbraLut = (Object_1 *)UnityEngine::HGSubsurfaceProfile::get_penumbraLut(v9, 0LL);
			//             sub_180002C70(TypeInfo::UnityEngine::Object);
			//             if ( UnityEngine::Object::op_Implicit(penumbraLut, 0LL) )
			//             {
			//               v16 = UnityEngine::HGSubsurfaceProfile::get_penumbraLut(v9, 0LL);
			//               v17 = this.fields._profileData_k__BackingField;
			//               v18 = (Texture *)v16;
			//               if ( !v17 )
			//                 goto LABEL_21;
			//               penumbraLutArray = (Texture *)v17.fields.penumbraLutArray;
			//               sub_180002C70(TypeInfo::UnityEngine::Graphics);
			//               UnityEngine::Graphics::CopyTexture(v18, 0, 0, penumbraLutArray, dstElement, 0, 0LL);
			//             }
			//             indirectLut = (Object_1 *)UnityEngine::HGSubsurfaceProfile::get_indirectLut(v9, 0LL);
			//             sub_180002C70(TypeInfo::UnityEngine::Object);
			//             if ( !UnityEngine::Object::op_Implicit(indirectLut, 0LL) )
			//               return;
			//             v21 = UnityEngine::HGSubsurfaceProfile::get_indirectLut(v9, 0LL);
			//             v22 = this.fields._profileData_k__BackingField;
			//             v23 = (Texture *)v21;
			//             if ( v22 )
			//             {
			//               indirectLutArray = (Texture *)v22.fields.indirectLutArray;
			//               sub_180002C70(TypeInfo::UnityEngine::Graphics);
			//               UnityEngine::Graphics::CopyTexture(v23, 0, 0, indirectLutArray, dstElement, 0, 0LL);
			//               return;
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_21:
			//     sub_180B536AC(profileList, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3311, 0LL);
			//   if ( !Patch )
			//     goto LABEL_21;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, dstElement, 0LL);
			// }
			// 
		}

		private void TryInitialize()
		{
			// // Void TryInitialize()
			// void HG::Rendering::Runtime::SubsurfaceProfileManager::TryInitialize(
			//         SubsurfaceProfileManager *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   __int64 v5; // rbx
			//   Texture2DArray *v6; // rax
			//   Object_1 *v7; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v8; // rdx
			//   PassConstructorID__Enum__Array *v9; // r8
			//   HGCamera *v10; // r9
			//   Texture2DArray *v11; // rax
			//   Object_1 *v12; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v13; // rdx
			//   PassConstructorID__Enum__Array *v14; // r8
			//   HGCamera *v15; // r9
			//   Texture2DArray *v16; // rax
			//   Object_1 *v17; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v18; // rdx
			//   PassConstructorID__Enum__Array *v19; // r8
			//   HGCamera *v20; // r9
			//   HGRenderPathBase_HGRenderPathResources *v21; // rdx
			//   PassConstructorID__Enum__Array *v22; // r8
			//   HGCamera *v23; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *textureFormat; // [rsp+20h] [rbp-28h]
			//   MethodInfo *textureFormata; // [rsp+20h] [rbp-28h]
			//   MethodInfo *textureFormatb; // [rsp+20h] [rbp-28h]
			//   MethodInfo *textureFormatc; // [rsp+20h] [rbp-28h]
			//   MethodInfo *mipCount; // [rsp+28h] [rbp-20h]
			//   MethodInfo *mipCounta; // [rsp+28h] [rbp-20h]
			//   MethodInfo *mipCountb; // [rsp+28h] [rbp-20h]
			//   MethodInfo *mipCountc; // [rsp+28h] [rbp-20h]
			// 
			//   if ( !byte_18D8EDB6B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::SubsurfaceProfileManager::SubsurfaceProfileData);
			//     sub_18003C530(&TypeInfo::UnityEngine::Texture2DArray);
			//     byte_18D8EDB6B = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3306, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3306, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			//     goto LABEL_6;
			//   }
			//   if ( this.fields._profileData_k__BackingField )
			//     return;
			//   v5 = sub_180004920(TypeInfo::HG::Rendering::Runtime::SubsurfaceProfileManager::SubsurfaceProfileData);
			//   if ( !v5 )
			//     goto LABEL_6;
			//   v6 = (Texture2DArray *)sub_180004920(TypeInfo::UnityEngine::Texture2DArray);
			//   v7 = (Object_1 *)v6;
			//   if ( !v6 )
			//     goto LABEL_6;
			//   UnityEngine::Texture2DArray::Texture2DArray(v6, 64, 64, 15, TextureFormat__Enum_RGBA32, 1, 1, 0LL);
			//   UnityEngine::Object::set_hideFlags(v7, HideFlags__Enum_HideAndDontSave, 0LL);
			//   *(_QWORD *)(v5 + 16) = v7;
			//   sub_1800054D0((HGRenderPathScene *)(v5 + 16), v8, v9, v10, textureFormat, mipCount);
			//   v11 = (Texture2DArray *)sub_180004920(TypeInfo::UnityEngine::Texture2DArray);
			//   v12 = (Object_1 *)v11;
			//   if ( !v11
			//     || (UnityEngine::Texture2DArray::Texture2DArray(v11, 64, 64, 15, TextureFormat__Enum_RGBA32, 1, 1, 0LL),
			//         UnityEngine::Object::set_hideFlags(v12, HideFlags__Enum_HideAndDontSave, 0LL),
			//         *(_QWORD *)(v5 + 24) = v12,
			//         sub_1800054D0((HGRenderPathScene *)(v5 + 24), v13, v14, v15, textureFormata, mipCounta),
			//         v16 = (Texture2DArray *)sub_180004920(TypeInfo::UnityEngine::Texture2DArray),
			//         (v17 = (Object_1 *)v16) == 0LL) )
			//   {
			// LABEL_6:
			//     sub_180B536AC(v4, v3);
			//   }
			//   UnityEngine::Texture2DArray::Texture2DArray(v16, 64, 1, 15, TextureFormat__Enum_RGBA32, 1, 1, 0LL);
			//   UnityEngine::Object::set_hideFlags(v17, HideFlags__Enum_HideAndDontSave, 0LL);
			//   *(_QWORD *)(v5 + 32) = v17;
			//   sub_1800054D0((HGRenderPathScene *)(v5 + 32), v18, v19, v20, textureFormatb, mipCountb);
			//   this.fields._profileData_k__BackingField = (SubsurfaceProfileManager_SubsurfaceProfileData *)v5;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields._profileData_k__BackingField,
			//     v21,
			//     v22,
			//     v23,
			//     textureFormatc,
			//     mipCountc);
			// }
			// 
		}

		private void UpdateProfileData([MetadataOffset(Offset = "0x01F91B11")] int index = -1)
		{
			// // Void UpdateProfileData(Int32)
			// void HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateProfileData(
			//         SubsurfaceProfileManager *this,
			//         int32_t index,
			//         MethodInfo *method)
			// {
			//   int32_t v5; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   v5 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3310, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3310, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, index, 0LL);
			//   }
			//   else if ( this.fields._profileData_k__BackingField )
			//   {
			//     if ( index == -1 )
			//     {
			//       do
			//         HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateProfileDataImpl(this, v5++, 0LL);
			//       while ( v5 < 15 );
			//     }
			//     else
			//     {
			//       HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateProfileDataImpl(this, index, 0LL);
			//     }
			//   }
			// }
			// 
		}

		public const int NONE_PROFILE_INDEX = 0;

		public const int MAX_PROFILE_COUNT = 15;

		private Dictionary<SubsurfaceProfileManager.ProfileKey, int> instanceId2Index;

		private SubsurfaceProfileManager.SubsurfaceProfileNode[] profileList;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
		private struct ProfileKey : IEquatable<SubsurfaceProfileManager.ProfileKey>
		{
			public ProfileKey(int instanceId, bool terrain)
			{
				// // ValueTuple`2[Int32,Boolean](Int32, Boolean)
				// void System::ValueTuple<int,bool>::ValueTuple(
				//         ValueTuple_2_Int32_Boolean_ *this,
				//         int32_t item1,
				//         bool item2,
				//         MethodInfo *method)
				// {
				//   this.Item1 = item1;
				//   this.Item2 = item2;
				// }
				// 
			}

			public override int GetHashCode()
			{
				// // Int32 GetHashCode()
				// int32_t HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey::GetHashCode(
				//         SubsurfaceProfileManager_ProfileKey *this,
				//         MethodInfo *method)
				// {
				//   int v2; // edi
				//   int32_t instanceId; // ebx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v7; // rdx
				//   __int64 v8; // rcx
				// 
				//   v2 = 0;
				//   if ( !byte_18D9196FF )
				//   {
				//     sub_18003C530(&TypeInfo::System::Boolean);
				//     byte_18D9196FF = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(3322, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3322, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v8, v7);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1178(Patch, this, 0LL);
				//   }
				//   else
				//   {
				//     instanceId = this.instanceId;
				//     sub_180002C70(TypeInfo::System::Boolean);
				//     LOBYTE(v2) = this.terrain;
				//     return instanceId ^ v2;
				//   }
				// }
				// 
				return 0;
			}

			[IDTag(0)]
			public bool Equals(SubsurfaceProfileManager.ProfileKey other)
			{
				// // Boolean Equals(SubsurfaceProfileManager+ProfileKey)
				// bool HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey::Equals(
				//         SubsurfaceProfileManager_ProfileKey *this,
				//         SubsurfaceProfileManager_ProfileKey other,
				//         MethodInfo *method)
				// {
				//   bool result; // al
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v7; // rdx
				//   __int64 v8; // rcx
				//   bool terrain; // [rsp+3Ch] [rbp+14h]
				// 
				//   terrain = other.terrain;
				//   result = IFix::WrappersManagerImpl::IsPatched(3323, 0LL);
				//   if ( result )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3323, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v8, v7);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1179(Patch, this, other, 0LL);
				//   }
				//   else if ( this.instanceId == other.instanceId )
				//   {
				//     return this.terrain == terrain;
				//   }
				//   return result;
				// }
				// 
				return default(bool);
			}

			[IDTag(1)]
			public override bool Equals(object obj)
			{
				// // Boolean Equals(Object)
				// bool HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey::Equals(
				//         SubsurfaceProfileManager_ProfileKey *this,
				//         Object *obj,
				//         MethodInfo *method)
				// {
				//   SubsurfaceProfileManager_ProfileKey *v5; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v8; // rdx
				//   __int64 v9; // rcx
				// 
				//   if ( !byte_18D919700 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey);
				//     byte_18D919700 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(3324, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3324, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v9, v8);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1180(Patch, this, obj, 0LL);
				//   }
				//   else if ( obj
				//          && (struct SubsurfaceProfileManager_ProfileKey__Class *)obj.klass == TypeInfo::HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey )
				//   {
				//     v5 = (SubsurfaceProfileManager_ProfileKey *)sub_18004A160(obj);
				//     return HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey::Equals(this, *v5, 0LL);
				//   }
				//   else
				//   {
				//     return 0;
				//   }
				// }
				// 
				return default(bool);
			}

			public int <>iFixBaseProxy_GetHashCode()
			{
				// // Int32 <>iFixBaseProxy_GetHashCode()
				// int32_t HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey::__iFixBaseProxy_GetHashCode(
				//         SubsurfaceProfileManager_ProfileKey *this,
				//         MethodInfo *method)
				// {
				//   __int64 v2; // r8
				//   ValueType *v4; // rax
				//   SubsurfaceProfileManager_ProfileKey v6; // [rsp+30h] [rbp+8h] BYREF
				// 
				//   if ( !byte_18D919701 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey);
				//     byte_18D919701 = 1;
				//   }
				//   v6 = *this;
				//   v4 = (ValueType *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey, &v6, v2);
				//   return System::ValueType::GetHashCode(v4, 0LL);
				// }
				// 
				return 0;
			}

			public bool <>iFixBaseProxy_Equals(object P0)
			{
				// // Boolean <>iFixBaseProxy_Equals(Object)
				// bool HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey::__iFixBaseProxy_Equals(
				//         SubsurfaceProfileManager_ProfileKey *this,
				//         Object *P0,
				//         MethodInfo *method)
				// {
				//   Object *v5; // rax
				//   SubsurfaceProfileManager_ProfileKey v7; // [rsp+30h] [rbp+8h] BYREF
				// 
				//   if ( !byte_18D919702 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey);
				//     byte_18D919702 = 1;
				//   }
				//   v7 = *this;
				//   v5 = (Object *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey, &v7, method);
				//   return System::ValueType::DefaultEquals(v5, P0, 0LL);
				// }
				// 
				return default(bool);
			}

			private int instanceId;

			private bool terrain;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 480)]
		internal struct SubsurfaceProfileConstants
		{
			[FixedBuffer(typeof(float), 60)]
			[HLSLArray(4, typeof(Vector4))]
			public SubsurfaceProfileManager.SubsurfaceProfileConstants.<_SubsurfaceProfileParams0>e__FixedBuffer _SubsurfaceProfileParams0;

			[HLSLArray(4, typeof(Vector4))]
			[FixedBuffer(typeof(float), 60)]
			public SubsurfaceProfileManager.SubsurfaceProfileConstants.<_SubsurfaceProfileParams1>e__FixedBuffer _SubsurfaceProfileParams1;

			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 240)]
			public struct <_SubsurfaceProfileParams0>e__FixedBuffer
			{
				public float FixedElementField;
			}

			[UnsafeValueType]
			[CompilerGenerated]
			[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 240)]
			public struct <_SubsurfaceProfileParams1>e__FixedBuffer
			{
				public float FixedElementField;
			}
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct SubsurfaceProfileNode
		{
			public bool Equals(HGSubsurfaceProfile other)
			{
				// // Boolean Equals(HGSubsurfaceProfile)
				// bool HG::Rendering::Runtime::SubsurfaceProfileManager::SubsurfaceProfileNode::Equals(
				//         SubsurfaceProfileManager_SubsurfaceProfileNode *this,
				//         HGSubsurfaceProfile *other,
				//         MethodInfo *method)
				// {
				//   __int64 v5; // rcx
				//   HGSubsurfaceProfile *profile; // rdx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !IFix::WrappersManagerImpl::IsPatched(3309, 0LL) )
				//   {
				//     profile = this.profile;
				//     if ( profile )
				//       return sub_1800045E0(0LL, profile, other);
				// LABEL_5:
				//     sub_180B536AC(v5, profile);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(3309, 0LL);
				//   if ( !Patch )
				//     goto LABEL_5;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1173(Patch, this, (Object *)other, 0LL);
				// }
				// 
				return default(bool);
			}

			public int refCount;

			public HGSubsurfaceProfile profile;
		}

		private class SubsurfaceProfileData
		{
			public SubsurfaceProfileData()
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

			public Texture2DArray scatterLutArray;

			public Texture2DArray penumbraLutArray;

			public Texture2DArray indirectLutArray;
		}
	}
}
