using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class SubsurfaceProfileManager // TypeDefIndex: 38616
	{
		// Fields
		public const int NONE_PROFILE_INDEX = 0; // Metadata: 0x02303F48
		public const int MAX_PROFILE_COUNT = 15; // Metadata: 0x02303F49
		private Dictionary<ProfileKey, int> instanceId2Index; // 0x10
		private SubsurfaceProfileNode[] profileList; // 0x18
	
		// Properties
		private SubsurfaceProfileData profileData { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		// Func`1[Single] get_getValueDelegate()
		Func_1_Single_ *Rewired::Utils::Classes::Utility::ValueWatcher<float>::get_getValueDelegate(
		        ValueWatcher_1_System_Single_ *this,
		        MethodInfo *method)
		{
		  return this->fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA;
		}
		

		// Void set_getValueDelegate(Func`1[Single])
		void Rewired::Utils::Classes::Utility::ValueWatcher<float>::set_getValueDelegate(
		        ValueWatcher_1_System_Single_ *this,
		        Func_1_Single_ *value,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  MethodInfo *v4; // [rsp+28h] [rbp+28h]
		
		  this->fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA = value;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA,
		    (HGRuntimeGrassQuery_Node *)value,
		    (HGRuntimeGrassQuery_Node *)method,
		    v3,
		    v4);
		}
		
	
		// Nested types
		private struct ProfileKey : IEquatable<ProfileKey> // TypeDefIndex: 38610
		{
			// Fields
			private int instanceId; // 0x00
			private bool terrain; // 0x04
	
			// Constructors
			public ProfileKey(int instanceId, bool terrain) {
				this.instanceId = default;
				this.terrain = default;
			} // 0x0000000184D8EA90-0x0000000184D8EAA0
			// ValueTuple`2[Int32,Boolean](Int32, Boolean)
			void System::ValueTuple<int,bool>::ValueTuple(
			        ValueTuple_2_Int32_Boolean_ *this,
			        int32_t item1,
			        bool item2,
			        MethodInfo *method)
			{
			  this->Item1 = item1;
			  this->Item2 = item2;
			}
			
	
			// Methods
			public override int GetHashCode() => default; // 0x0000000183EC56E0-0x0000000183EC5730
			// Int32 GetHashCode()
			int32_t HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey::GetHashCode(
			        SubsurfaceProfileManager_ProfileKey *this,
			        MethodInfo *method)
			{
			  int32_t instanceId; // edi
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(3938, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3938, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1384(Patch, this, 0LL);
			  }
			  else
			  {
			    instanceId = this->instanceId;
			    if ( !TypeInfo::System::Boolean->_1.cctor_finished_or_no_cctor )
			      il2cpp_runtime_class_init_1(TypeInfo::System::Boolean);
			    return instanceId ^ this->terrain;
			  }
			}
			
			[IDTag(0)]
			public bool Equals(ProfileKey other) => default; // 0x0000000189C1A770-0x0000000189C1A7DC
			// Boolean Equals(SubsurfaceProfileManager+ProfileKey)
			bool HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey::Equals(
			        SubsurfaceProfileManager_ProfileKey *this,
			        SubsurfaceProfileManager_ProfileKey other,
			        MethodInfo *method)
			{
			  bool result; // al
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v7; // rdx
			  __int64 v8; // rcx
			  bool terrain; // [rsp+3Ch] [rbp+14h]
			
			  terrain = other.terrain;
			  result = IFix::WrappersManagerImpl::IsPatched(3939, 0LL);
			  if ( result )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3939, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v8, v7);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1385(Patch, this, other, 0LL);
			  }
			  else if ( this->instanceId == other.instanceId )
			  {
			    return this->terrain == terrain;
			  }
			  return result;
			}
			
			[IDTag(1)]
			public override bool Equals(object obj) => default; // 0x0000000189C1A7DC-0x0000000189C1A85C
			// Boolean Equals(Object)
			bool HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey::Equals(
			        SubsurfaceProfileManager_ProfileKey *this,
			        Object *obj,
			        MethodInfo *method)
			{
			  SubsurfaceProfileManager_ProfileKey *v5; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v8; // rdx
			  __int64 v9; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(3940, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3940, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v9, v8);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1386(Patch, this, obj, 0LL);
			  }
			  else if ( obj
			         && (struct SubsurfaceProfileManager_ProfileKey__Class *)obj->klass == TypeInfo::HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey )
			  {
			    v5 = (SubsurfaceProfileManager_ProfileKey *)sub_1800422D0(obj);
			    return HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey::Equals(this, *v5, 0LL);
			  }
			  else
			  {
			    return 0;
			  }
			}
			
			public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000189C1A894-0x0000000189C1A8C0
			// Int32 <>iFixBaseProxy_GetHashCode()
			int32_t HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey::__iFixBaseProxy_GetHashCode(
			        SubsurfaceProfileManager_ProfileKey *this,
			        MethodInfo *method)
			{
			  ValueType *v2; // rax
			  SubsurfaceProfileManager_ProfileKey v4; // [rsp+30h] [rbp+8h] BYREF
			
			  v4 = *this;
			  v2 = (ValueType *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey, &v4);
			  return System::ValueType::GetHashCode(v2, 0LL);
			}
			
			public bool __iFixBaseProxy_Equals(object P0) => default; // 0x0000000189C1A85C-0x0000000189C1A894
			// Boolean <>iFixBaseProxy_Equals(Object)
			bool HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey::__iFixBaseProxy_Equals(
			        SubsurfaceProfileManager_ProfileKey *this,
			        Object *P0,
			        MethodInfo *method)
			{
			  Object *v4; // rax
			  SubsurfaceProfileManager_ProfileKey v6; // [rsp+30h] [rbp+8h] BYREF
			
			  v6 = *this;
			  v4 = (Object *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey, &v6);
			  return System::ValueType::DefaultEquals(v4, P0, 0LL);
			}
			
		}
	
		internal struct SubsurfaceProfileConstants // TypeDefIndex: 38613
		{
			// Fields
			[HLSLArray(4, typeof(Vector4))]
			public unsafe fixed /* 0x00000000-0x00000000 */ float _SubsurfaceProfileParams0[0]; // 0x00
			[HLSLArray(4, typeof(Vector4))]
			public unsafe fixed /* 0x00000000-0x00000000 */ float _SubsurfaceProfileParams1[0]; // 0xF0
		}
	
		private struct SubsurfaceProfileNode // TypeDefIndex: 38614
		{
			// Fields
			public int refCount; // 0x00
			public HGSubsurfaceProfile profile; // 0x08
	
			// Methods
			public bool Equals(HGSubsurfaceProfile other) => default; // 0x0000000189C1C3F4-0x0000000189C1C4B4
			// Boolean Equals(HGSubsurfaceProfile)
			bool HG::Rendering::Runtime::SubsurfaceProfileManager::SubsurfaceProfileNode::Equals(
			        SubsurfaceProfileManager_SubsurfaceProfileNode *this,
			        HGSubsurfaceProfile *other,
			        MethodInfo *method)
			{
			  __int64 v5; // rcx
			  HGSubsurfaceProfile *profile; // rdx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(3925, 0LL) )
			  {
			    profile = this->profile;
			    if ( profile )
			      return sub_180034AC0(0LL, profile, other);
			LABEL_5:
			    sub_1800D8260(v5, profile);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(3925, 0LL);
			  if ( !Patch )
			    goto LABEL_5;
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1379(Patch, this, (Object *)other, 0LL);
			}
			
		}
	
		private class SubsurfaceProfileData // TypeDefIndex: 38615
		{
			// Fields
			public Texture2DArray scatterLutArray; // 0x10
			public Texture2DArray penumbraLutArray; // 0x18
			public Texture2DArray indirectLutArray; // 0x20
	
			// Constructors
			public SubsurfaceProfileData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public SubsurfaceProfileManager() {} // 0x0000000182ED8D90-0x0000000182ED8E00
		// SubsurfaceProfileManager()
		void HG::Rendering::Runtime::SubsurfaceProfileManager::SubsurfaceProfileManager(
		        SubsurfaceProfileManager *this,
		        MethodInfo *method)
		{
		  Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  MethodInfo *v13; // [rsp+20h] [rbp-8h]
		  MethodInfo *v14; // [rsp+50h] [rbp+28h]
		
		  v3 = (Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>);
		  v6 = v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::Dictionary(
		    v3,
		    MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::Dictionary);
		  this->fields.instanceId2Index = v6;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v7, v8, v9, v13);
		  this->fields.profileList = (SubsurfaceProfileManager_SubsurfaceProfileNode__Array *)il2cpp_array_new_specific_1(
		                                                                                        TypeInfo::HG::Rendering::Runtime::SubsurfaceProfileManager::SubsurfaceProfileNode,
		                                                                                        15LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.profileList, v10, v11, v12, v14);
		}
		
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void RegisterMaterialCallback() {} // 0x000000018485FA50-0x000000018485FAF0
		// Void RegisterMaterialCallback()
		void HG::Rendering::Runtime::SubsurfaceProfileManager::RegisterMaterialCallback(MethodInfo *method)
		{
		  UnityAction_2_System_Int32_System_Boolean_ *v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  UnityAction_2_System_Int32_System_Boolean_ *v4; // rbx
		  UnityAction_2_System_Int32_System_Boolean_ *v5; // rax
		  UnityAction_2_System_Int32_System_Boolean_ *v6; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3917, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3917, 0LL);
		    if ( !Patch )
		      goto LABEL_4;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    v1 = (UnityAction_2_System_Int32_System_Boolean_ *)sub_1800368D0(TypeInfo::UnityEngine::Events::UnityAction<int,bool>);
		    v4 = v1;
		    if ( !v1
		      || (UnityEngine::Events::UnityAction<int,bool>::UnityAction(
		            v1,
		            0LL,
		            MethodInfo::HG::Rendering::Runtime::SubsurfaceProfileManager::OnShadingStateChanged,
		            0LL),
		          UnityEngine::HyperGryph::HGShadingStateSystem::remove_shadingStateChanged(v4, 0LL),
		          v5 = (UnityAction_2_System_Int32_System_Boolean_ *)sub_1800368D0(TypeInfo::UnityEngine::Events::UnityAction<int,bool>),
		          (v6 = v5) == 0LL) )
		    {
		LABEL_4:
		      sub_1800D8260(v3, v2);
		    }
		    UnityEngine::Events::UnityAction<int,bool>::UnityAction(
		      v5,
		      0LL,
		      MethodInfo::HG::Rendering::Runtime::SubsurfaceProfileManager::OnShadingStateChanged,
		      0LL);
		    UnityEngine::HyperGryph::HGShadingStateSystem::add_shadingStateChanged(v6, 0LL);
		    UnityEngine::HyperGryph::HGShadingStateSystem::FlushAllMaterialCallbacks(0LL);
		  }
		}
		
		private static void OnShadingStateChanged(int instanceId, bool state) {} // 0x0000000189C1BC80-0x0000000189C1BD24
		// Void OnShadingStateChanged(Int32, Boolean)
		void HG::Rendering::Runtime::SubsurfaceProfileManager::OnShadingStateChanged(
		        int32_t instanceId,
		        bool state,
		        MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v6; // rdx
		  SubsurfaceProfileManager *subsurfaceProfileManager_k__BackingField; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3918, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3918, 0LL);
		    if ( !Patch )
		      goto LABEL_11;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_34((ILFixDynamicMethodWrapper_18 *)Patch, instanceId, state, 0LL);
		  }
		  else
		  {
		    if ( !HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
		      return;
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( !state )
		    {
		      if ( currentManagerContext )
		      {
		        subsurfaceProfileManager_k__BackingField = currentManagerContext->fields._subsurfaceProfileManager_k__BackingField;
		        if ( subsurfaceProfileManager_k__BackingField )
		        {
		          HG::Rendering::Runtime::SubsurfaceProfileManager::UnregisterFromMaterial(
		            subsurfaceProfileManager_k__BackingField,
		            instanceId,
		            0LL);
		          return;
		        }
		      }
		LABEL_11:
		      sub_1800D8260(subsurfaceProfileManager_k__BackingField, v6);
		    }
		    if ( !currentManagerContext )
		      goto LABEL_11;
		    subsurfaceProfileManager_k__BackingField = currentManagerContext->fields._subsurfaceProfileManager_k__BackingField;
		    if ( !subsurfaceProfileManager_k__BackingField )
		      goto LABEL_11;
		    HG::Rendering::Runtime::SubsurfaceProfileManager::RegisterFromMaterial(
		      subsurfaceProfileManager_k__BackingField,
		      instanceId,
		      0LL);
		  }
		}
		
		public void RegisterFromMaterial(int instanceId) {} // 0x0000000189C1BD24-0x0000000189C1BE5C
		// Void RegisterFromMaterial(Int32)
		void HG::Rendering::Runtime::SubsurfaceProfileManager::RegisterFromMaterial(
		        SubsurfaceProfileManager *this,
		        int32_t instanceId,
		        MethodInfo *method)
		{
		  uint32_t MaterialHandle; // eax
		  Object_1 *Material; // rsi
		  Object_1 *SubsurfaceProfile; // rbp
		  int32_t v8; // ebx
		  struct HGShaderIDs__Class *v9; // rcx
		  HGShaderIDs__StaticFields *static_fields; // rdx
		  int32_t SubsurfaceProfileInt; // edx
		  int v12; // ecx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  SubsurfaceProfileManager_ProfileKey key; // [rsp+58h] [rbp+20h]
		
		  *(_DWORD *)&key.terrain = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(3920, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3920, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
		        (ILFixDynamicMethodWrapper_29 *)Patch,
		        (Object *)this,
		        instanceId,
		        0LL);
		      return;
		    }
		    goto LABEL_11;
		  }
		  MaterialHandle = UnityEngine::HyperGryph::HGShadingStateSystem::GetMaterialHandle(instanceId, 0LL);
		  if ( !MaterialHandle )
		    return;
		  Material = (Object_1 *)UnityEngine::HyperGryph::HGShadingStateSystem::GetMaterial(MaterialHandle, 0LL);
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Implicit(Material, 0LL) )
		    return;
		  SubsurfaceProfile = (Object_1 *)HG::Rendering::Runtime::MaterialSubsurfaceExtensions::GetSubsurfaceProfile(
		                                    (Material *)Material,
		                                    0LL);
		  key.instanceId = instanceId;
		  key.terrain = 0;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Implicit(SubsurfaceProfile, 0LL) )
		  {
		    HG::Rendering::Runtime::SubsurfaceProfileManager::UnregisterProfileImpl(this, key, 0LL);
		    return;
		  }
		  v8 = HG::Rendering::Runtime::SubsurfaceProfileManager::RegisterProfileImpl(
		         this,
		         key,
		         (HGSubsurfaceProfile *)SubsurfaceProfile,
		         0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  v9 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		  if ( !Material )
		LABEL_11:
		    sub_1800D8260(v9, static_fields);
		  SubsurfaceProfileInt = static_fields->_SubsurfaceProfileInt;
		  v12 = v8 + 1;
		  if ( v8 == -1 )
		    v12 = 0;
		  UnityEngine::Material::SetFloatImpl((Material *)Material, SubsurfaceProfileInt, (float)v12, 0LL);
		}
		
		public void UnregisterFromMaterial(int instanceId) {} // 0x0000000189C1BE5C-0x0000000189C1BED0
		// Void UnregisterFromMaterial(Int32)
		void HG::Rendering::Runtime::SubsurfaceProfileManager::UnregisterFromMaterial(
		        SubsurfaceProfileManager *this,
		        int32_t instanceId,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3930, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3930, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
		      (ILFixDynamicMethodWrapper_29 *)Patch,
		      (Object *)this,
		      instanceId,
		      0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::SubsurfaceProfileManager::UnregisterProfileImpl(
		      this,
		      (SubsurfaceProfileManager_ProfileKey)(unsigned int)instanceId,
		      0LL);
		  }
		}
		
		public void RegisterFromTerrain(HGSubsurfaceProfile profile) {} // 0x00000001837E2C20-0x00000001837E2CE0
		// Void RegisterFromTerrain(HGSubsurfaceProfile)
		void HG::Rendering::Runtime::SubsurfaceProfileManager::RegisterFromTerrain(
		        SubsurfaceProfileManager *this,
		        HGSubsurfaceProfile *profile,
		        MethodInfo *method)
		{
		  int v5; // edi
		  int32_t v6; // eax
		  struct HGShaderIDs__Class *v7; // rcx
		  int32_t v8; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  SubsurfaceProfileManager_ProfileKey key; // [rsp+48h] [rbp+20h]
		
		  v5 = 0;
		  key = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3931, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3931, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)profile,
		      0LL);
		  }
		  else
		  {
		    key.terrain = 1;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Implicit((Object_1 *)profile, 0LL) )
		    {
		      v6 = HG::Rendering::Runtime::SubsurfaceProfileManager::RegisterProfileImpl(this, key, profile, 0LL);
		      v7 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs;
		      v8 = v6;
		      if ( !TypeInfo::HG::Rendering::Runtime::HGShaderIDs->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        v7 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs;
		      }
		      if ( v8 != -1 )
		        v5 = v8 + 1;
		      UnityEngine::Shader::SetGlobalFloatImpl(v7->static_fields->_TerrainSubsurfaceProfileInt, (float)v5, 0LL);
		    }
		    else
		    {
		      HG::Rendering::Runtime::SubsurfaceProfileManager::UnregisterProfileImpl(this, key, 0LL);
		    }
		  }
		}
		
		public void UnregisterFromTerrain() {} // 0x0000000189C1BED0-0x0000000189C1BF34
		// Void UnregisterFromTerrain()
		void HG::Rendering::Runtime::SubsurfaceProfileManager::UnregisterFromTerrain(
		        SubsurfaceProfileManager *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3932, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3932, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::SubsurfaceProfileManager::UnregisterProfileImpl(
		      this,
		      (SubsurfaceProfileManager_ProfileKey)0x100000000LL,
		      0LL);
		  }
		}
		
		public void UpdateMaterialProfile(Material mat, HGSubsurfaceProfile profile, bool force = false /* Metadata: 0x02303F44 */) {} // 0x0000000189C1C050-0x0000000189C1C170
		// Void UpdateMaterialProfile(Material, HGSubsurfaceProfile, Boolean)
		void HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateMaterialProfile(
		        SubsurfaceProfileManager *this,
		        Material *mat,
		        HGSubsurfaceProfile *profile,
		        bool force,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  int32_t updated; // ebx
		  int v12; // ecx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  SubsurfaceProfileManager_ProfileKey key; // [rsp+30h] [rbp-18h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3933, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3933, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_117(
		        (ILFixDynamicMethodWrapper_13 *)Patch,
		        (Object *)this,
		        (Object *)mat,
		        (Object *)profile,
		        force,
		        0LL);
		      return;
		    }
		LABEL_8:
		    sub_1800D8260(v10, v9);
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Implicit((Object_1 *)mat, 0LL) )
		    return;
		  if ( !mat )
		    goto LABEL_8;
		  key = (SubsurfaceProfileManager_ProfileKey)(unsigned int)UnityEngine::Object::GetInstanceID((Object_1 *)mat, 0LL);
		  updated = HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateProfileImpl(this, key, profile, force, 0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  v12 = updated + 1;
		  if ( updated == -1 )
		    v12 = 0;
		  UnityEngine::Material::SetFloatImpl(
		    mat,
		    TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfaceProfileInt,
		    (float)v12,
		    0LL);
		}
		
		public int GetTerrainSubsurfaceProfileInt() => default; // 0x0000000189C1BBF4-0x0000000189C1BC80
		// Int32 GetTerrainSubsurfaceProfileInt()
		int32_t HG::Rendering::Runtime::SubsurfaceProfileManager::GetTerrainSubsurfaceProfileInt(
		        SubsurfaceProfileManager *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *instanceId2Index; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int32_t value; // [rsp+40h] [rbp+18h] BYREF
		  SubsurfaceProfileManager_ProfileKey key; // [rsp+48h] [rbp+20h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3935, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3935, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		LABEL_7:
		    sub_1800D8260(instanceId2Index, v3);
		  }
		  key = 0LL;
		  value = -1;
		  instanceId2Index = this->fields.instanceId2Index;
		  key.terrain = 1;
		  if ( !instanceId2Index )
		    goto LABEL_7;
		  System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::TryGetValue(
		    instanceId2Index,
		    key,
		    &value,
		    MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::TryGetValue);
		  if ( value == -1 )
		    return 0;
		  else
		    return value + 1;
		}
		
		public void UpdateTerrainProfile(HGSubsurfaceProfile profile, bool force = false /* Metadata: 0x02303F45 */) {} // 0x0000000189C1C324-0x0000000189C1C3F4
		// Void UpdateTerrainProfile(HGSubsurfaceProfile, Boolean)
		void HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateTerrainProfile(
		        SubsurfaceProfileManager *this,
		        HGSubsurfaceProfile *profile,
		        bool force,
		        MethodInfo *method)
		{
		  int32_t updated; // ebx
		  int v8; // ecx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3936, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3936, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_18(
		      (ILFixDynamicMethodWrapper_9 *)Patch,
		      (Object *)this,
		      (Object *)profile,
		      force,
		      0LL);
		  }
		  else
		  {
		    updated = HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateProfileImpl(
		                this,
		                (SubsurfaceProfileManager_ProfileKey)0x100000000LL,
		                profile,
		                force,
		                0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    v8 = updated + 1;
		    if ( updated == -1 )
		      v8 = 0;
		    UnityEngine::Shader::SetGlobalFloatImpl(
		      TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainSubsurfaceProfileInt,
		      (float)v8,
		      0LL);
		  }
		}
		
		private int FindAndAddProfileImpl(ProfileKey key, HGSubsurfaceProfile profile, bool force = false /* Metadata: 0x02303F46 */) => default; // 0x0000000182EDE2A0-0x0000000182EDE430
		// Int32 FindAndAddProfileImpl(SubsurfaceProfileManager+ProfileKey, HGSubsurfaceProfile, Boolean)
		int32_t HG::Rendering::Runtime::SubsurfaceProfileManager::FindAndAddProfileImpl(
		        SubsurfaceProfileManager *this,
		        SubsurfaceProfileManager_ProfileKey key,
		        HGSubsurfaceProfile *profile,
		        bool force,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  struct Object_1__Class *v10; // rcx
		  int32_t v11; // esi
		  int32_t v12; // edi
		  Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *profileList; // rcx
		  char v14; // r14
		  _DWORD *v15; // rax
		  SubsurfaceProfileManager_SubsurfaceProfileNode__Array *v16; // rbx
		  __int64 v17; // rax
		  HGRuntimeGrassQuery_Node *v18; // rdx
		  HGRuntimeGrassQuery_Node *v19; // r8
		  Int32__Array **v20; // r9
		  SubsurfaceProfileManager_SubsurfaceProfileNode *v22; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *P3; // [rsp+20h] [rbp-28h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3928, 0LL) )
		  {
		    v10 = TypeInfo::UnityEngine::Object;
		    v11 = -1;
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
		    if ( !profile )
		      return v11;
		    if ( !v10->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v10);
		    if ( !profile->fields._.m_CachedPtr )
		      return v11;
		    v12 = 0;
		    while ( 1 )
		    {
		      profileList = (Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)this->fields.profileList;
		      if ( !profileList )
		        goto LABEL_16;
		      if ( *(int *)sub_180002100(profileList, v12) > 0 )
		      {
		        profileList = (Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)this->fields.profileList;
		        if ( !profileList )
		          goto LABEL_16;
		        v22 = (SubsurfaceProfileManager_SubsurfaceProfileNode *)sub_180002100(profileList, v12);
		        if ( HG::Rendering::Runtime::SubsurfaceProfileManager::SubsurfaceProfileNode::Equals(v22, profile, 0LL) )
		          break;
		      }
		      if ( v11 == -1 )
		      {
		        profileList = (Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)this->fields.profileList;
		        if ( !profileList )
		          goto LABEL_16;
		        if ( !*(_DWORD *)sub_180002100(profileList, v12) )
		          v11 = v12;
		      }
		      if ( ++v12 >= 15 )
		        goto LABEL_14;
		    }
		    if ( v12 == -1 )
		    {
		LABEL_14:
		      v14 = 1;
		      v12 = v11;
		      if ( v11 == -1 )
		      {
		        HG::Rendering::HGRPLogger::LogError((String *)"Subsurface profile exceed max count", 0LL);
		        return v11;
		      }
		    }
		    else
		    {
		      v14 = 0;
		      v11 = v12;
		    }
		    profileList = this->fields.instanceId2Index;
		    if ( profileList )
		    {
		      System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::Add(
		        profileList,
		        key,
		        v12,
		        MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::Add);
		      profileList = (Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)this->fields.profileList;
		      if ( profileList )
		      {
		        v15 = (_DWORD *)sub_180002100(profileList, v12);
		        ++*v15;
		        if ( !v14 )
		          goto LABEL_24;
		        v16 = this->fields.profileList;
		        if ( v16 )
		        {
		          *(_QWORD *)(sub_180002100(this->fields.profileList, v12) + 8) = profile;
		          v17 = sub_180002100(v16, v12);
		          sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v17 + 8), v18, v19, v20, P3);
		LABEL_24:
		          if ( force | (unsigned __int8)v14 )
		            HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateProfileData(this, v12, 0LL);
		          return v11;
		        }
		      }
		    }
		LABEL_16:
		    sub_1800D8260(profileList, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3928, 0LL);
		  if ( !Patch )
		    goto LABEL_16;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1380(Patch, (Object *)this, key, (Object *)profile, force, 0LL);
		}
		
		private int UpdateProfileImpl(ProfileKey key, HGSubsurfaceProfile profile, bool force) => default; // 0x0000000189C1C170-0x0000000189C1C324
		// Int32 UpdateProfileImpl(SubsurfaceProfileManager+ProfileKey, HGSubsurfaceProfile, Boolean)
		int32_t HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateProfileImpl(
		        SubsurfaceProfileManager *this,
		        SubsurfaceProfileManager_ProfileKey key,
		        HGSubsurfaceProfile *profile,
		        bool force,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *instanceId2Index; // rcx
		  __int64 v11; // rsi
		  SubsurfaceProfileManager_SubsurfaceProfileNode *v12; // rax
		  char v13; // r14
		  _DWORD *v14; // rax
		  SubsurfaceProfileManager_SubsurfaceProfileNode__Array *profileList; // r14
		  __int64 v16; // rax
		  HGRuntimeGrassQuery_Node *v17; // rdx
		  HGRuntimeGrassQuery_Node *v18; // r8
		  Int32__Array **v19; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *P3; // [rsp+20h] [rbp-38h]
		  int32_t value[10]; // [rsp+30h] [rbp-28h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3934, 0LL) )
		  {
		    HG::Rendering::Runtime::SubsurfaceProfileManager::TryInitialize(this, 0LL);
		    instanceId2Index = this->fields.instanceId2Index;
		    value[0] = -1;
		    if ( instanceId2Index )
		    {
		      if ( !System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::TryGetValue(
		              instanceId2Index,
		              key,
		              value,
		              MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::TryGetValue) )
		      {
		        LODWORD(v11) = value[0];
		        return v11;
		      }
		      instanceId2Index = (Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)this->fields.profileList;
		      if ( instanceId2Index )
		      {
		        v11 = value[0];
		        v12 = (SubsurfaceProfileManager_SubsurfaceProfileNode *)sub_180002100(instanceId2Index, value[0]);
		        if ( HG::Rendering::Runtime::SubsurfaceProfileManager::SubsurfaceProfileNode::Equals(v12, profile, 0LL) )
		        {
		          if ( force )
		            HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateProfileData(this, v11, 0LL);
		          return v11;
		        }
		        instanceId2Index = this->fields.instanceId2Index;
		        if ( instanceId2Index )
		        {
		          System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::Remove(
		            instanceId2Index,
		            key,
		            MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::Remove);
		          instanceId2Index = (Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)this->fields.profileList;
		          v13 = 0;
		          if ( instanceId2Index )
		          {
		            v14 = (_DWORD *)sub_180002100(instanceId2Index, v11);
		            --*v14;
		            instanceId2Index = (Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)this->fields.profileList;
		            if ( instanceId2Index )
		            {
		              if ( *(_DWORD *)sub_180002100(instanceId2Index, v11) )
		              {
		LABEL_12:
		                if ( force | (unsigned __int8)v13 )
		                  HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateProfileData(this, v11, 0LL);
		                LODWORD(v11) = HG::Rendering::Runtime::SubsurfaceProfileManager::FindAndAddProfileImpl(
		                                 this,
		                                 key,
		                                 profile,
		                                 force,
		                                 0LL);
		                return v11;
		              }
		              profileList = this->fields.profileList;
		              if ( profileList )
		              {
		                *(_QWORD *)(sub_180002100(this->fields.profileList, v11) + 8) = 0LL;
		                v16 = sub_180002100(profileList, v11);
		                sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v16 + 8), v17, v18, v19, P3);
		                v13 = 1;
		                goto LABEL_12;
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_20:
		    sub_1800D8260(instanceId2Index, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3934, 0LL);
		  if ( !Patch )
		    goto LABEL_20;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1380(Patch, (Object *)this, key, (Object *)profile, force, 0LL);
		}
		
		private int RegisterProfileImpl(ProfileKey key, HGSubsurfaceProfile profile) => default; // 0x00000001837E2CE0-0x00000001837E2DC0
		// Int32 RegisterProfileImpl(SubsurfaceProfileManager+ProfileKey, HGSubsurfaceProfile)
		int32_t HG::Rendering::Runtime::SubsurfaceProfileManager::RegisterProfileImpl(
		        SubsurfaceProfileManager *this,
		        SubsurfaceProfileManager_ProfileKey key,
		        HGSubsurfaceProfile *profile,
		        MethodInfo *method)
		{
		  __int64 v7; // rdi
		  __int64 v8; // rdx
		  Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *instanceId2Index; // rcx
		  SubsurfaceProfileManager_SubsurfaceProfileNode *v11; // rax
		  _DWORD *v12; // rax
		  SubsurfaceProfileManager_SubsurfaceProfileNode__Array *profileList; // r14
		  __int64 v14; // rax
		  HGRuntimeGrassQuery_Node *v15; // rdx
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *methoda; // [rsp+20h] [rbp-28h]
		  int32_t value[6]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3921, 0LL) )
		  {
		    HG::Rendering::Runtime::SubsurfaceProfileManager::TryInitialize(this, 0LL);
		    LODWORD(v7) = -1;
		    value[0] = -1;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Implicit((Object_1 *)profile, 0LL) )
		      return v7;
		    instanceId2Index = this->fields.instanceId2Index;
		    if ( instanceId2Index )
		    {
		      if ( !System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::TryGetValue(
		              instanceId2Index,
		              key,
		              value,
		              MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::TryGetValue) )
		      {
		LABEL_7:
		        LODWORD(v7) = HG::Rendering::Runtime::SubsurfaceProfileManager::FindAndAddProfileImpl(
		                        this,
		                        key,
		                        profile,
		                        0,
		                        0LL);
		        return v7;
		      }
		      instanceId2Index = (Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)this->fields.profileList;
		      if ( instanceId2Index )
		      {
		        v7 = value[0];
		        v11 = (SubsurfaceProfileManager_SubsurfaceProfileNode *)sub_180002100(instanceId2Index, value[0]);
		        if ( HG::Rendering::Runtime::SubsurfaceProfileManager::SubsurfaceProfileNode::Equals(v11, profile, 0LL) )
		          return v7;
		        instanceId2Index = this->fields.instanceId2Index;
		        if ( instanceId2Index )
		        {
		          System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::Remove(
		            instanceId2Index,
		            key,
		            MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::Remove);
		          instanceId2Index = (Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)this->fields.profileList;
		          if ( instanceId2Index )
		          {
		            v12 = (_DWORD *)sub_180002100(instanceId2Index, v7);
		            --*v12;
		            instanceId2Index = (Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)this->fields.profileList;
		            if ( instanceId2Index )
		            {
		              if ( *(_DWORD *)sub_180002100(instanceId2Index, v7) )
		                goto LABEL_7;
		              profileList = this->fields.profileList;
		              if ( profileList )
		              {
		                *(_QWORD *)(sub_180002100(this->fields.profileList, v7) + 8) = 0LL;
		                v14 = sub_180002100(profileList, v7);
		                sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v14 + 8), v15, v16, v17, methoda);
		                HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateProfileData(this, v7, 0LL);
		                goto LABEL_7;
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_9:
		    sub_1800D8260(instanceId2Index, v8);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3921, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1381(Patch, (Object *)this, key, (Object *)profile, 0LL);
		}
		
		private void UnregisterProfileImpl(ProfileKey key) {} // 0x0000000189C1BF34-0x0000000189C1C050
		// Void UnregisterProfileImpl(SubsurfaceProfileManager+ProfileKey)
		void HG::Rendering::Runtime::SubsurfaceProfileManager::UnregisterProfileImpl(
		        SubsurfaceProfileManager *this,
		        SubsurfaceProfileManager_ProfileKey key,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *instanceId2Index; // rcx
		  __int64 v7; // rbx
		  _DWORD *v8; // rax
		  SubsurfaceProfileManager_SubsurfaceProfileNode__Array *profileList; // rsi
		  __int64 v10; // rax
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		  int32_t value; // [rsp+48h] [rbp+20h] BYREF
		
		  value = 0;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3929, 0LL) )
		  {
		    HG::Rendering::Runtime::SubsurfaceProfileManager::TryInitialize(this, 0LL);
		    instanceId2Index = this->fields.instanceId2Index;
		    if ( instanceId2Index )
		    {
		      if ( !System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::TryGetValue(
		              instanceId2Index,
		              key,
		              &value,
		              MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::TryGetValue) )
		        return;
		      instanceId2Index = this->fields.instanceId2Index;
		      if ( instanceId2Index )
		      {
		        System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::Remove(
		          instanceId2Index,
		          key,
		          MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::SubsurfaceProfileManager::ProfileKey,int>::Remove);
		        instanceId2Index = (Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)this->fields.profileList;
		        if ( instanceId2Index )
		        {
		          v7 = value;
		          v8 = (_DWORD *)sub_180002100(instanceId2Index, value);
		          --*v8;
		          instanceId2Index = (Dictionary_2_HG_Rendering_Runtime_SubsurfaceProfileManager_ProfileKey_System_Int32_ *)this->fields.profileList;
		          if ( instanceId2Index )
		          {
		            if ( *(_DWORD *)sub_180002100(instanceId2Index, v7) )
		              return;
		            profileList = this->fields.profileList;
		            if ( profileList )
		            {
		              *(_QWORD *)(sub_180002100(this->fields.profileList, v7) + 8) = 0LL;
		              v10 = sub_180002100(profileList, v7);
		              sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v10 + 8), v11, v12, v13, v15);
		              HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateProfileData(this, v7, 0LL);
		              return;
		            }
		          }
		        }
		      }
		    }
		LABEL_11:
		    sub_1800D8260(instanceId2Index, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3929, 0LL);
		  if ( !Patch )
		    goto LABEL_11;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1382(Patch, (Object *)this, key, 0LL);
		}
		
		public void BindProfileData(HGRenderGraphContext context) {} // 0x0000000189C1B80C-0x0000000189C1BBF4
		// Void BindProfileData(HGRenderGraphContext)
		void HG::Rendering::Runtime::SubsurfaceProfileManager::BindProfileData(
		        SubsurfaceProfileManager *this,
		        HGRenderGraphContext *context,
		        MethodInfo *method)
		{
		  HGShaderIDs__StaticFields *static_fields; // rdx
		  _DWORD *p_CB0; // rcx
		  Texture **profileData_k__BackingField; // rsi
		  CommandBuffer *cmd; // r14
		  int32_t v9; // r15d
		  RenderTargetIdentifier *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int128 v13; // xmm1
		  CommandBuffer *v14; // r14
		  int32_t SubsurfacePenumbraLutArray; // r15d
		  RenderTargetIdentifier *v16; // rax
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  __int128 v19; // xmm1
		  CommandBuffer *v20; // r14
		  int32_t SubsurfaceIndirectLutArray; // r15d
		  RenderTargetIdentifier *v22; // rax
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  __int128 v25; // xmm1
		  int v26; // esi
		  float *v27; // r15
		  __int64 v28; // rax
		  HGSubsurfaceProfile *v29; // r14
		  CBHandle *ConstantBuffer; // rax
		  void *ptr; // xmm1_8
		  __int64 v32; // rdx
		  _OWORD *v33; // rax
		  _OWORD *v34; // rcx
		  __int128 v35; // xmm1
		  __int128 v36; // xmm0
		  __int128 v37; // xmm1
		  __int128 v38; // xmm0
		  __int128 v39; // xmm1
		  __int128 v40; // xmm0
		  __int128 v41; // xmm1
		  __int128 v42; // xmm1
		  __int128 v43; // xmm0
		  __int128 v44; // xmm1
		  __int128 v45; // xmm0
		  __int128 v46; // xmm1
		  CommandBuffer *v47; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  RenderTargetIdentifier offset_8; // [rsp+38h] [rbp-D0h] BYREF
		  RenderTargetIdentifier v50; // [rsp+68h] [rbp-A0h] BYREF
		  Vector3 v51; // [rsp+98h] [rbp-70h] BYREF
		  RenderTargetIdentifier v52; // [rsp+A8h] [rbp-60h] BYREF
		  _BYTE v53[4]; // [rsp+D8h] [rbp-30h] BYREF
		  char v54; // [rsp+DCh] [rbp-2Ch] BYREF
		  _BYTE v55[480]; // [rsp+2B8h] [rbp+1B0h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3937, 0LL) )
		  {
		    HG::Rendering::Runtime::SubsurfaceProfileManager::TryInitialize(this, 0LL);
		    profileData_k__BackingField = (Texture **)this->fields._profileData_k__BackingField;
		    if ( context )
		    {
		      cmd = context->fields.cmd;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      p_CB0 = &TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CB0;
		      v9 = p_CB0[862];
		      if ( profileData_k__BackingField )
		      {
		        v10 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v50, profileData_k__BackingField[2], 0LL);
		        if ( !cmd )
		          sub_1800D8260(v12, v11);
		        v13 = *(_OWORD *)&v10->m_BufferPointer;
		        *(_OWORD *)&offset_8.m_Type = *(_OWORD *)&v10->m_Type;
		        *(_QWORD *)&offset_8.m_DepthSlice = *(_QWORD *)&v10->m_DepthSlice;
		        *(_OWORD *)&offset_8.m_BufferPointer = v13;
		        UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, v9, &offset_8, 0LL);
		        v14 = context->fields.cmd;
		        SubsurfacePenumbraLutArray = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfacePenumbraLutArray;
		        v16 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v52, profileData_k__BackingField[3], 0LL);
		        if ( !v14 )
		          sub_1800D8260(v18, v17);
		        v19 = *(_OWORD *)&v16->m_BufferPointer;
		        *(_OWORD *)&v50.m_Type = *(_OWORD *)&v16->m_Type;
		        *(_QWORD *)&v50.m_DepthSlice = *(_QWORD *)&v16->m_DepthSlice;
		        *(_OWORD *)&v50.m_BufferPointer = v19;
		        UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(v14, SubsurfacePenumbraLutArray, &v50, 0LL);
		        v20 = context->fields.cmd;
		        SubsurfaceIndirectLutArray = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfaceIndirectLutArray;
		        v22 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v52, profileData_k__BackingField[4], 0LL);
		        if ( !v20 )
		          sub_1800D8260(v24, v23);
		        v25 = *(_OWORD *)&v22->m_BufferPointer;
		        *(_OWORD *)&offset_8.m_Type = *(_OWORD *)&v22->m_Type;
		        *(_QWORD *)&offset_8.m_DepthSlice = *(_QWORD *)&v22->m_DepthSlice;
		        *(_OWORD *)&offset_8.m_BufferPointer = v25;
		        UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(v20, SubsurfaceIndirectLutArray, &offset_8, 0LL);
		        sub_18033B9D0(v53, 0LL, 480LL);
		        v26 = 0;
		        v27 = (float *)&v54;
		        do
		        {
		          p_CB0 = this->fields.profileList;
		          if ( !p_CB0 )
		            goto LABEL_23;
		          v28 = sub_180002100(p_CB0, v26);
		          p_CB0 = this->fields.profileList;
		          v29 = *(HGSubsurfaceProfile **)(v28 + 8);
		          if ( !p_CB0 )
		            goto LABEL_23;
		          if ( *(int *)sub_180002100(p_CB0, v26) > 0 )
		          {
		            sub_1800036A0(TypeInfo::UnityEngine::Object);
		            if ( UnityEngine::Object::op_Inequality((Object_1 *)v29, 0LL, 0LL) )
		            {
		              if ( !v29 )
		                goto LABEL_23;
		              *(v27 - 1) = UnityEngine::HGSubsurfaceProfile::get_subsurfaceNormalLerp(&v51, v29, 0LL)->x;
		              *v27 = UnityEngine::HGSubsurfaceProfile::get_subsurfaceNormalLerp((Vector3 *)&v50, v29, 0LL)->y;
		              v27[1] = UnityEngine::HGSubsurfaceProfile::get_subsurfaceNormalLerp((Vector3 *)&offset_8, v29, 0LL)->z;
		              v27[2] = UnityEngine::HGSubsurfaceProfile::get_curvatureScale(v29, 0LL);
		              v27[60] = UnityEngine::HGSubsurfaceProfile::get_penumbraScale(v29, 0LL);
		            }
		          }
		          ++v26;
		          v27 += 4;
		        }
		        while ( v26 < 15 );
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		        ConstantBuffer = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		                           (CBHandle *)&v50,
		                           &context->fields.renderContext,
		                           480,
		                           0LL);
		        ptr = ConstantBuffer->ptr;
		        *(_OWORD *)&offset_8.m_Type = *(_OWORD *)&ConstantBuffer->bufferId;
		        offset_8.m_BufferPointer = ptr;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        v32 = 3LL;
		        v33 = v55;
		        v34 = v53;
		        do
		        {
		          v35 = v34[1];
		          *v33 = *v34;
		          v36 = v34[2];
		          v33[1] = v35;
		          v37 = v34[3];
		          v33[2] = v36;
		          v38 = v34[4];
		          v33[3] = v37;
		          v39 = v34[5];
		          v33[4] = v38;
		          v40 = v34[6];
		          v33[5] = v39;
		          v41 = v34[7];
		          v34 += 8;
		          v33[6] = v40;
		          v33 += 8;
		          *(v33 - 1) = v41;
		          --v32;
		        }
		        while ( v32 );
		        v42 = v34[1];
		        *v33 = *v34;
		        v43 = v34[2];
		        v33[1] = v42;
		        v44 = v34[3];
		        v33[2] = v43;
		        v45 = v34[4];
		        v33[3] = v44;
		        v46 = v34[5];
		        v33[4] = v45;
		        v33[5] = v46;
		        sub_1808B0D84(&offset_8, v55, 128LL);
		        v47 = context->fields.cmd;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        if ( v47 )
		        {
		          UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
		            v47,
		            offset_8.m_Type,
		            static_fields->_SubsurfaceProfileConstants,
		            offset_8.m_NameID,
		            480,
		            0LL);
		          return;
		        }
		      }
		    }
		LABEL_23:
		    sub_1800D8260(p_CB0, static_fields);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3937, 0LL);
		  if ( !Patch )
		    goto LABEL_23;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)context,
		    0LL);
		}
		
		private void UpdateProfileDataImpl(int index) {} // 0x0000000182EDE010-0x0000000182EDE2A0
		// Void UpdateProfileDataImpl(Int32)
		void HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateProfileDataImpl(
		        SubsurfaceProfileManager *this,
		        int32_t index,
		        MethodInfo *method)
		{
		  __int64 dstElement; // rsi
		  __int64 v5; // rdx
		  _QWORD *p_klass; // rcx
		  __int64 v7; // rax
		  struct Object_1__Class *v8; // rcx
		  __int64 v9; // rbx
		  __int64 v10; // rax
		  HGSubsurfaceProfile *v11; // rbx
		  Object_1 *scatterLut; // rbp
		  Texture2D *v13; // rax
		  Texture *v14; // r14
		  Texture *v15; // rbp
		  Object_1 *penumbraLut; // rbp
		  Texture2D *v17; // rax
		  Texture *v18; // r14
		  Texture *v19; // rbp
		  Object_1 *indirectLut; // rbp
		  Texture2D *v21; // rax
		  Texture *v22; // rbp
		  Texture *v23; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  dstElement = index;
		  if ( IFix::WrappersManagerImpl::IsPatched(3927, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3927, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
		        (ILFixDynamicMethodWrapper_29 *)Patch,
		        (Object *)this,
		        dstElement,
		        0LL);
		      return;
		    }
		    goto LABEL_4;
		  }
		  if ( (unsigned int)dstElement <= 0xE )
		  {
		    p_klass = &this->fields.profileList->klass;
		    if ( !p_klass )
		      goto LABEL_4;
		    if ( *(_DWORD *)sub_180002100(p_klass, dstElement) )
		    {
		      p_klass = &this->fields.profileList->klass;
		      if ( !p_klass )
		        goto LABEL_4;
		      v7 = sub_180002100(p_klass, dstElement);
		      v8 = TypeInfo::UnityEngine::Object;
		      v9 = *(_QWORD *)(v7 + 8);
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
		      if ( v9 )
		      {
		        if ( !v8->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(v8);
		        if ( *(_QWORD *)(v9 + 16) )
		        {
		          p_klass = &this->fields.profileList->klass;
		          if ( !p_klass )
		            goto LABEL_4;
		          v10 = sub_180002100(p_klass, dstElement);
		          v11 = *(HGSubsurfaceProfile **)(v10 + 8);
		          if ( !v11 )
		            goto LABEL_4;
		          scatterLut = (Object_1 *)UnityEngine::HGSubsurfaceProfile::get_scatterLut(
		                                     *(HGSubsurfaceProfile **)(v10 + 8),
		                                     0LL);
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          if ( UnityEngine::Object::op_Implicit(scatterLut, 0LL) )
		          {
		            v13 = UnityEngine::HGSubsurfaceProfile::get_scatterLut(v11, 0LL);
		            p_klass = &this->fields._profileData_k__BackingField->klass;
		            v14 = (Texture *)v13;
		            if ( !p_klass )
		              goto LABEL_4;
		            v15 = (Texture *)p_klass[2];
		            if ( !TypeInfo::UnityEngine::Graphics->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Graphics);
		            UnityEngine::Graphics::CopyTexture(v14, 0, 0, v15, dstElement, 0, 0LL);
		          }
		          penumbraLut = (Object_1 *)UnityEngine::HGSubsurfaceProfile::get_penumbraLut(v11, 0LL);
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          if ( UnityEngine::Object::op_Implicit(penumbraLut, 0LL) )
		          {
		            v17 = UnityEngine::HGSubsurfaceProfile::get_penumbraLut(v11, 0LL);
		            p_klass = &this->fields._profileData_k__BackingField->klass;
		            v18 = (Texture *)v17;
		            if ( !p_klass )
		              goto LABEL_4;
		            v19 = (Texture *)p_klass[3];
		            if ( !TypeInfo::UnityEngine::Graphics->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Graphics);
		            UnityEngine::Graphics::CopyTexture(v18, 0, 0, v19, dstElement, 0, 0LL);
		          }
		          indirectLut = (Object_1 *)UnityEngine::HGSubsurfaceProfile::get_indirectLut(v11, 0LL);
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          if ( UnityEngine::Object::op_Implicit(indirectLut, 0LL) )
		          {
		            v21 = UnityEngine::HGSubsurfaceProfile::get_indirectLut(v11, 0LL);
		            p_klass = &this->fields._profileData_k__BackingField->klass;
		            v22 = (Texture *)v21;
		            if ( p_klass )
		            {
		              v23 = (Texture *)p_klass[4];
		              if ( !TypeInfo::UnityEngine::Graphics->_1.cctor_finished_or_no_cctor )
		                il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Graphics);
		              UnityEngine::Graphics::CopyTexture(v22, 0, 0, v23, dstElement, 0, 0LL);
		              return;
		            }
		LABEL_4:
		            sub_1800D8260(p_klass, v5);
		          }
		        }
		      }
		    }
		  }
		}
		
		private void TryInitialize() {} // 0x00000001837E1B70-0x00000001837E1D10
		// Void TryInitialize()
		void HG::Rendering::Runtime::SubsurfaceProfileManager::TryInitialize(
		        SubsurfaceProfileManager *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  __int64 v5; // rbx
		  Texture2DArray *v6; // rax
		  Object_1 *v7; // rdi
		  HGRuntimeGrassQuery_Node *v8; // rdx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  Texture2DArray *v11; // rax
		  Object_1 *v12; // rdi
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  Texture2DArray *v16; // rax
		  Object_1 *v17; // rdi
		  HGRuntimeGrassQuery_Node *v18; // rdx
		  HGRuntimeGrassQuery_Node *v19; // r8
		  Int32__Array **v20; // r9
		  HGRuntimeGrassQuery_Node *v21; // rdx
		  HGRuntimeGrassQuery_Node *v22; // r8
		  Int32__Array **v23; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *textureFormat; // [rsp+20h] [rbp-28h]
		  MethodInfo *textureFormata; // [rsp+20h] [rbp-28h]
		  MethodInfo *textureFormatb; // [rsp+20h] [rbp-28h]
		  MethodInfo *textureFormatc; // [rsp+20h] [rbp-28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3922, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3922, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		    goto LABEL_4;
		  }
		  if ( this->fields._profileData_k__BackingField )
		    return;
		  v5 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::SubsurfaceProfileManager::SubsurfaceProfileData);
		  if ( !v5 )
		    goto LABEL_4;
		  v6 = (Texture2DArray *)sub_1800368D0(TypeInfo::UnityEngine::Texture2DArray);
		  v7 = (Object_1 *)v6;
		  if ( !v6 )
		    goto LABEL_4;
		  UnityEngine::Texture2DArray::Texture2DArray(v6, 64, 64, 15, TextureFormat__Enum_RGBA32, 1, 1, 0LL);
		  UnityEngine::Object::set_hideFlags(v7, HideFlags__Enum_HideAndDontSave, 0LL);
		  *(_QWORD *)(v5 + 16) = v7;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v5 + 16), v8, v9, v10, textureFormat);
		  v11 = (Texture2DArray *)sub_1800368D0(TypeInfo::UnityEngine::Texture2DArray);
		  v12 = (Object_1 *)v11;
		  if ( !v11
		    || (UnityEngine::Texture2DArray::Texture2DArray(v11, 64, 64, 15, TextureFormat__Enum_RGBA32, 1, 1, 0LL),
		        UnityEngine::Object::set_hideFlags(v12, HideFlags__Enum_HideAndDontSave, 0LL),
		        *(_QWORD *)(v5 + 24) = v12,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v5 + 24), v13, v14, v15, textureFormata),
		        v16 = (Texture2DArray *)sub_1800368D0(TypeInfo::UnityEngine::Texture2DArray),
		        (v17 = (Object_1 *)v16) == 0LL) )
		  {
		LABEL_4:
		    sub_1800D8260(v4, v3);
		  }
		  UnityEngine::Texture2DArray::Texture2DArray(v16, 64, 1, 15, TextureFormat__Enum_RGBA32, 1, 1, 0LL);
		  UnityEngine::Object::set_hideFlags(v17, HideFlags__Enum_HideAndDontSave, 0LL);
		  *(_QWORD *)(v5 + 32) = v17;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v5 + 32), v18, v19, v20, textureFormatb);
		  this->fields._profileData_k__BackingField = (SubsurfaceProfileManager_SubsurfaceProfileData *)v5;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._profileData_k__BackingField, v21, v22, v23, textureFormatc);
		}
		
		private void UpdateProfileData(int index = -1 /* Metadata: 0x02303F47 */) {} // 0x0000000184D50AC0-0x0000000184D50B10
		// Void UpdateProfileData(Int32)
		void HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateProfileData(
		        SubsurfaceProfileManager *this,
		        int32_t index,
		        MethodInfo *method)
		{
		  int32_t i; // edi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3926, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3926, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, index, 0LL);
		  }
		  else if ( this->fields._profileData_k__BackingField )
		  {
		    if ( index == -1 )
		    {
		      for ( i = 0; i < 15; ++i )
		        HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateProfileDataImpl(this, i, 0LL);
		    }
		    else
		    {
		      HG::Rendering::Runtime::SubsurfaceProfileManager::UpdateProfileDataImpl(this, index, 0LL);
		    }
		  }
		}
		
	}
}
