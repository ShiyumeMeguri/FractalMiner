using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class GPUParticleSystemManager // TypeDefIndex: 37737
	{
		// Fields
		private const int MAX_SYSTEM_COUNT = 128; // Metadata: 0x02303086
		private SystemList m_particleSystems; // 0x10
		private List<int> m_freePool; // 0x18
		private static GPUParticleSystemManager s_instance; // 0x00
	
		// Properties
		internal int maxParticleCount { get; private set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
		// Int32 get_count()
		int32_t Beyond::UnorderedList<System::Object>::get_count(UnorderedList_1_System_Object_ *this, MethodInfo *method)
		{
		  return this->fields._count_k__BackingField;
		}
		

		// Void set_count(Int32)
		void Beyond::UnorderedList<System::Object>::set_count(
		        UnorderedList_1_System_Object_ *this,
		        int32_t value,
		        MethodInfo *method)
		{
		  this->fields._count_k__BackingField = value;
		}
		
		internal int maxGPUInstanceCount { get; private set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040
		// Int32 get_Item4()
		int32_t System::Tuple<System::Object,System::Object,int,int>::get_Item4(
		        Tuple_4_Object_Object_Int32_Int32_ *this,
		        MethodInfo *method)
		{
		  return this->fields.m_Item4;
		}
		

		// Void set_PageId(Int32)
		void System::Data::RBTree_1_K_::TreePage<System::Object>::set_PageId(
		        RBTree_1_K_TreePage_System_Object_ *this,
		        int32_t value,
		        MethodInfo *method)
		{
		  this->fields._pageId = value;
		}
		
		public static GPUParticleSystemManager instance { get => default; } // 0x0000000189CFABF4-0x0000000189CFAC98 
		// GPUParticleSystemManager get_instance()
		GPUParticleSystemManager *HG::Rendering::Runtime::GPUParticleSystemManager::get_instance(MethodInfo *method)
		{
		  struct GPUParticleSystemManager__Class *v1; // rcx
		  GPUParticleSystemManager *v2; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  Type__Class *v5; // rbx
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1743, 0LL) )
		  {
		    v1 = TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager;
		    if ( TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager->static_fields->s_instance )
		      return v1->static_fields->s_instance;
		    v2 = (GPUParticleSystemManager *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager);
		    v5 = (Type__Class *)v2;
		    if ( v2 )
		    {
		      HG::Rendering::Runtime::GPUParticleSystemManager::GPUParticleSystemManager(v2, 0LL);
		      static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager->static_fields;
		      static_fields->klass = v5;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager->static_fields,
		        static_fields,
		        v7,
		        v8,
		        v11);
		      v1 = TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager;
		      return v1->static_fields->s_instance;
		    }
		LABEL_7:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1743, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_700(Patch, 0LL);
		}
		
	
		// Nested types
		internal struct SimulateContext // TypeDefIndex: 37730
		{
			// Fields
			internal ComputeShader emitShader; // 0x00
			internal ComputeShader simulateShader; // 0x08
			internal ComputeBuffer perInstanceBuffer; // 0x10
			internal ComputeBuffer generalSystemAttributeBuffer; // 0x18
			internal ComputeBuffer systemAttributesBuffer; // 0x20
			internal ComputeBuffer particleAttributesBuffer; // 0x28
			internal ComputeBuffer liveListBuffer; // 0x30
			internal ComputeBuffer deadListBuffer; // 0x38
			internal ComputeBuffer deadCountBuffer; // 0x40
			internal ComputeBuffer drawIndirectArgsBuffer; // 0x48
			internal GeneralSystemAttributes generalSystemAttributes; // 0x50
			internal int instanceCount; // 0x60
			internal int maxEmitRate; // 0x64
			internal int[] instancesToClear; // 0x68
		}
	
		internal struct RenderContext // TypeDefIndex: 37731
		{
			// Fields
			internal Mesh mesh; // 0x00
			internal GraphicsBuffer indexBuffer; // 0x08
			internal ComputeBuffer drawIndirectArgsBuffer; // 0x10
			internal Material material; // 0x18
			internal ComputeBuffer particleAttributesBuffer; // 0x20
			internal ComputeBuffer liveListBuffer; // 0x28
			internal ComputeBuffer generalSystemAttributeBuffer; // 0x30
			internal int instanceCount; // 0x38
		}
	
		public struct Handle // TypeDefIndex: 37732
		{
			// Fields
			public readonly int index; // 0x00
	
			// Constructors
			public Handle(int index) {
				this.index = default;
			} // 0x0000000184D86140-0x0000000184D86150
			// Void WriteUnaligned[UInt32](Byte ByRef, UInt32)
			void System::Runtime::CompilerServices::Unsafe::WriteUnaligned<unsigned int>(
			        uint8_t *destination,
			        uint32_t value,
			        MethodInfo *method)
			{
			  *(_DWORD *)destination = value;
			}
			
		}
	
		public struct SystemHandle // TypeDefIndex: 37733
		{
			// Fields
			public readonly int systemID; // 0x00
			public readonly System.Type type; // 0x08
			public static SystemHandle nullHandle; // 0x00
	
			// Constructors
			internal SystemHandle(int systemID, System.Type type) {
				this.systemID = default;
				this.type = default;
			} // 0x0000000186B17430-0x0000000186B17440
			// IndexedDictionary`2[TKey,TValue]+yzhVwnWVXpgEXQufmGiVcJkbjlTI[System.UInt32,System.Object](UInt32, Object)
			// local variable allocation has failed, the output may be wrong!
			void Rewired::Utils::Classes::Data::IndexedDictionary_2_TKey_TValue_::yzhVwnWVXpgEXQufmGiVcJkbjlTI<unsigned int,System::Object>::yzhVwnWVXpgEXQufmGiVcJkbjlTI(
			        IndexedDictionary_2_TKey_TValue_yzhVwnWVXpgEXQufmGiVcJkbjlTI_System_UInt32_System_Object_ *this,
			        uint32_t param_0005b24d,
			        Object *param_0005b24e,
			        MethodInfo *method)
			{
			  MethodInfo *v4; // [rsp+28h] [rbp+28h]
			
			  this->fgQJCyoleogxMFsOUGgTUMofNhGP = param_0005b24d;
			  this->vMmuLUVFGZZNSIceFhSpeBITqghGA = param_0005b24e;
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&this->vMmuLUVFGZZNSIceFhSpeBITqghGA,
			    *(Type **)&param_0005b24d,
			    (PropertyInfo_1 *)param_0005b24e,
			    (Int32__Array **)method,
			    v4);
			}
			
			static SystemHandle() {
				nullHandle = default;
			} // 0x0000000189D04680-0x0000000189D046D4
			// GPUParticleSystemManager+SystemHandle()
			void HG::Rendering::Runtime::GPUParticleSystemManager::SystemHandle::cctor(MethodInfo *method)
			{
			  Type *v1; // rdx
			  PropertyInfo_1 *v2; // r8
			  Int32__Array **v3; // r9
			  Type *v4; // rdx
			  PropertyInfo_1 *v5; // r8
			  Int32__Array **v6; // r9
			  GPUParticleSystemManager_SystemHandle__StaticFields v7; // [rsp+20h] [rbp-18h] BYREF
			
			  v7 = (GPUParticleSystemManager_SystemHandle__StaticFields)0xFFFFFFFFuLL;
			  sub_18002D1B0((SingleFieldAccessor *)&v7.nullHandle.type, v1, v2, v3, *(MethodInfo **)&v7.nullHandle.systemID);
			  *TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager::SystemHandle->static_fields = v7;
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager::SystemHandle->static_fields->nullHandle.type,
			    v4,
			    v5,
			    v6,
			    *(MethodInfo **)&v7.nullHandle.systemID);
			}
			
	
			// Methods
			[IDTag(1)]
			public bool Valid(System.Type type) => default; // 0x0000000189D045A0-0x0000000189D04614
			// Boolean Valid(Type)
			bool HG::Rendering::Runtime::GPUParticleSystemManager::SystemHandle::Valid(
			        GPUParticleSystemManager_SystemHandle *this,
			        Type *type,
			        MethodInfo *method)
			{
			  bool result; // al
			  Type *v6; // rbx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v8; // rdx
			  __int64 v9; // rcx
			
			  result = IFix::WrappersManagerImpl::IsPatched(1761, 0LL);
			  if ( result )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1761, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v9, v8);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_708(Patch, this, (Object *)type, 0LL);
			  }
			  else if ( this->systemID != -1 )
			  {
			    v6 = this->type;
			    sub_1800036A0(TypeInfo::System::Type);
			    return v6 == type;
			  }
			  return result;
			}
			
			[IDTag(0)]
			public bool Valid() => default; // 0x0000000189D04614-0x0000000189D04680
			// Boolean Valid()
			bool HG::Rendering::Runtime::GPUParticleSystemManager::SystemHandle::Valid(
			        GPUParticleSystemManager_SystemHandle *this,
			        MethodInfo *method)
			{
			  bool result; // al
			  Type *type; // rbx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			
			  result = IFix::WrappersManagerImpl::IsPatched(1754, 0LL);
			  if ( result )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1754, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_704(Patch, this, 0LL);
			  }
			  else if ( this->systemID != -1 )
			  {
			    type = this->type;
			    sub_1800036A0(TypeInfo::System::Type);
			    return type != 0LL;
			  }
			  return result;
			}
			
		}
	
		public struct InstanceHandle // TypeDefIndex: 37734
		{
			// Fields
			public readonly int instanceID; // 0x00
			public readonly SystemHandle systemHandle; // 0x08
			public static InstanceHandle nullHandle; // 0x00
	
			// Constructors
			internal InstanceHandle(int instanceID, SystemHandle systemHandle) {
				this.instanceID = default;
				this.systemHandle = default;
			} // 0x00000001886CD94C-0x00000001886CD960
			// ValueTuple`2[Int32,Beyond.Gameplay.Factory.Core.GridPath](Int32, GridPath)
			// local variable allocation has failed, the output may be wrong!
			void System::ValueTuple<int,Beyond::Gameplay::Factory::Core::GridPath>::ValueTuple(
			        ValueTuple_2_Int32_Beyond_Gameplay_Factory_Core_GridPath_ *this,
			        int32_t item1,
			        GridPath *item2,
			        MethodInfo *method)
			{
			  GridPath v4; // xmm0
			  MethodInfo *v5; // [rsp+28h] [rbp+28h]
			
			  v4 = *item2;
			  this->Item1 = item1;
			  this->Item2 = v4;
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&this->Item2.segments,
			    *(Type **)&item1,
			    (PropertyInfo_1 *)item2,
			    (Int32__Array **)method,
			    v5);
			}
			
			static InstanceHandle() {
				nullHandle = default;
			} // 0x0000000189D039B4-0x0000000189D03A2C
			// GPUParticleSystemManager+InstanceHandle()
			void HG::Rendering::Runtime::GPUParticleSystemManager::InstanceHandle::cctor(MethodInfo *method)
			{
			  Type *v1; // rdx
			  PropertyInfo_1 *v2; // r8
			  Int32__Array **v3; // r9
			  Type *v4; // xmm0_8
			  GPUParticleSystemManager_InstanceHandle__StaticFields *static_fields; // rcx
			  Type *v6; // rdx
			  PropertyInfo_1 *v7; // r8
			  Int32__Array **v8; // r9
			  _BYTE v9[24]; // [rsp+20h] [rbp-28h] BYREF
			
			  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager::SystemHandle);
			  *(GPUParticleSystemManager_SystemHandle__StaticFields *)&v9[8] = *TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager::SystemHandle->static_fields;
			  sub_18002D1B0((SingleFieldAccessor *)&v9[16], v1, v2, v3, (MethodInfo *)0xFFFFFFFFLL);
			  v4 = *(Type **)&v9[16];
			  static_fields = TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager::InstanceHandle->static_fields;
			  *(_OWORD *)&static_fields->nullHandle.instanceID = *(_OWORD *)v9;
			  static_fields->nullHandle.systemHandle.type = v4;
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager::InstanceHandle->static_fields->nullHandle.systemHandle.type,
			    v6,
			    v7,
			    v8,
			    *(MethodInfo **)v9);
			}
			
	
			// Methods
			[IDTag(1)]
			public bool Valid(System.Type type) => default; // 0x0000000189D03928-0x0000000189D039B4
			// Boolean Valid(Type)
			bool HG::Rendering::Runtime::GPUParticleSystemManager::InstanceHandle::Valid(
			        GPUParticleSystemManager_InstanceHandle *this,
			        Type *type,
			        MethodInfo *method)
			{
			  bool result; // al
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v7; // rdx
			  __int64 v8; // rcx
			  GPUParticleSystemManager_SystemHandle systemHandle; // [rsp+20h] [rbp-18h] BYREF
			
			  systemHandle = 0LL;
			  result = IFix::WrappersManagerImpl::IsPatched(1762, 0LL);
			  if ( result )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1762, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v8, v7);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_709(Patch, this, (Object *)type, 0LL);
			  }
			  else if ( this->instanceID != -1 )
			  {
			    systemHandle = this->systemHandle;
			    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager::SystemHandle);
			    return HG::Rendering::Runtime::GPUParticleSystemManager::SystemHandle::Valid(&systemHandle, type, 0LL);
			  }
			  return result;
			}
			
			[IDTag(0)]
			public bool Valid() => default; // 0x0000000189D038B0-0x0000000189D03928
			// Boolean Valid()
			bool HG::Rendering::Runtime::GPUParticleSystemManager::InstanceHandle::Valid(
			        GPUParticleSystemManager_InstanceHandle *this,
			        MethodInfo *method)
			{
			  bool result; // al
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  GPUParticleSystemManager_SystemHandle systemHandle; // [rsp+20h] [rbp-18h] BYREF
			
			  systemHandle = 0LL;
			  result = IFix::WrappersManagerImpl::IsPatched(1753, 0LL);
			  if ( result )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1753, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v6, v5);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_705(Patch, this, 0LL);
			  }
			  else if ( this->instanceID != -1 )
			  {
			    systemHandle = this->systemHandle;
			    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager::SystemHandle);
			    return HG::Rendering::Runtime::GPUParticleSystemManager::SystemHandle::Valid(&systemHandle, 0LL);
			  }
			  return result;
			}
			
		}
	
		private class SystemList // TypeDefIndex: 37735
		{
			// Fields
			private GPUParticleSystemBase[] m_systemArray; // 0x10
	
			// Properties
			internal int Count { get; private set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
			// LayerMask get_value()
			LayerMask UnityEngine::Rendering::VolumeParameter<UnityEngine::LayerMask>::get_value(
			        VolumeParameter_1_UnityEngine_LayerMask_ *this,
			        MethodInfo *method)
			{
			  return (LayerMask)this->fields.m_Value.m_Mask;
			}
			

			// Void set_value(LayerMask)
			void UnityEngine::Rendering::VolumeParameter<UnityEngine::LayerMask>::set_value(
			        VolumeParameter_1_UnityEngine_LayerMask_ *this,
			        LayerMask value,
			        MethodInfo *method)
			{
			  this->fields.m_Value = value;
			}
			
			public GPUParticleSystemBase this[int key] { get => default; set {} } // 0x0000000189D048C0-0x0000000189D04930 0x0000000189D04930-0x0000000189D049BC
			// GPUParticleSystemBase get_Item(Int32)
			GPUParticleSystemBase *HG::Rendering::Runtime::GPUParticleSystemManager::SystemList::get_Item(
			        GPUParticleSystemManager_SystemList *this,
			        int32_t key,
			        MethodInfo *method)
			{
			  __int64 v3; // rbx
			  __int64 v5; // rdx
			  GPUParticleSystemBase__Array *m_systemArray; // rcx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  v3 = key;
			  if ( IFix::WrappersManagerImpl::IsPatched(1745, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1745, 0LL);
			    if ( Patch )
			      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_701(Patch, (Object *)this, v3, 0LL);
			LABEL_7:
			    sub_1800D8260(m_systemArray, v5);
			  }
			  m_systemArray = this->fields.m_systemArray;
			  if ( !m_systemArray )
			    goto LABEL_7;
			  if ( (unsigned int)v3 >= m_systemArray->max_length.size )
			    sub_1800D2AB0(m_systemArray, v5);
			  return m_systemArray->vector[v3];
			}
			

			// Void set_Item(Int32, GPUParticleSystemBase)
			void HG::Rendering::Runtime::GPUParticleSystemManager::SystemList::set_Item(
			        GPUParticleSystemManager_SystemList *this,
			        int32_t key,
			        GPUParticleSystemBase *value,
			        MethodInfo *method)
			{
			  __int64 v4; // rsi
			  __int64 v7; // rdx
			  __int64 v8; // rcx
			  GPUParticleSystemBase__Array *m_systemArray; // rbx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  v4 = key;
			  if ( !IFix::WrappersManagerImpl::IsPatched(1746, 0LL) )
			  {
			    m_systemArray = this->fields.m_systemArray;
			    if ( m_systemArray )
			    {
			      sub_180031B10(m_systemArray, value);
			      sub_180378FEC(m_systemArray, v4, value);
			      return;
			    }
			LABEL_5:
			    sub_1800D8260(v8, v7);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(1746, 0LL);
			  if ( !Patch )
			    goto LABEL_5;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_56(
			    (ILFixDynamicMethodWrapper_17 *)Patch,
			    (Object *)this,
			    (AkCallbackType__Enum)v4,
			    (Object *)value,
			    0LL);
			}
			
	
			// Constructors
			public SystemList() {} // Dummy constructor
			internal SystemList(int capacity) {} // 0x0000000189D04894-0x0000000189D048C0
			// GPUParticleSystemManager+SystemList(Int32)
			void HG::Rendering::Runtime::GPUParticleSystemManager::SystemList::SystemList(
			        GPUParticleSystemManager_SystemList *this,
			        int32_t capacity,
			        MethodInfo *method)
			{
			  Type *v4; // rdx
			  PropertyInfo_1 *v5; // r8
			  Int32__Array **v6; // r9
			  MethodInfo *v7; // [rsp+50h] [rbp+28h]
			
			  this->fields.m_systemArray = (GPUParticleSystemBase__Array *)il2cpp_array_new_specific_1(
			                                                                 TypeInfo::HG::Rendering::Runtime::GPUParticleSystemBase,
			                                                                 (unsigned int)capacity);
			  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v4, v5, v6, v7);
			}
			
	
			// Methods
			internal bool Add(GPUParticleSystemBase sys) => default; // 0x0000000189D046D4-0x0000000189D04778
			// Boolean Add(GPUParticleSystemBase)
			bool HG::Rendering::Runtime::GPUParticleSystemManager::SystemList::Add(
			        GPUParticleSystemManager_SystemList *this,
			        GPUParticleSystemBase *sys,
			        MethodInfo *method)
			{
			  __int64 v5; // rdx
			  GPUParticleSystemBase__Array *m_systemArray; // rax
			  __int64 Count_k__BackingField; // rcx
			  __int64 v8; // rbx
			  GPUParticleSystemBase__Array *v9; // rdi
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1763, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1763, 0LL);
			    if ( Patch )
			      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
			               (ILFixDynamicMethodWrapper_33 *)Patch,
			               (Object *)this,
			               (Object *)sys,
			               0LL);
			LABEL_7:
			    sub_1800D8260(Count_k__BackingField, v5);
			  }
			  m_systemArray = this->fields.m_systemArray;
			  Count_k__BackingField = (unsigned int)this->fields._Count_k__BackingField;
			  if ( !m_systemArray )
			    goto LABEL_7;
			  if ( (_DWORD)Count_k__BackingField == m_systemArray->max_length.size )
			    return 0;
			  v8 = (int)Count_k__BackingField;
			  v9 = this->fields.m_systemArray;
			  this->fields._Count_k__BackingField = Count_k__BackingField + 1;
			  sub_180031B10(v9, sys);
			  sub_180378FEC(v9, v8, sys);
			  return 1;
			}
			
			internal ReadOnlySpan<GPUParticleSystemBase> GetSpan() => default; // 0x0000000189D047F8-0x0000000189D04894
			// ReadOnlySpan`1[HG.Rendering.Runtime.GPUParticleSystemBase] GetSpan()
			ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *HG::Rendering::Runtime::GPUParticleSystemManager::SystemList::GetSpan(
			        ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *__return_ptr retstr,
			        GPUParticleSystemManager_SystemList *this,
			        MethodInfo *method)
			{
			  ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ v5; // xmm0
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v7; // rdx
			  __int64 v8; // rcx
			  ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *result; // rax
			  Span_1_Object_ v10; // [rsp+20h] [rbp-28h] BYREF
			  ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ v11; // [rsp+30h] [rbp-18h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1749, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1749, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v8, v7);
			    v5 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_702(&v11, Patch, (Object *)this, 0LL);
			  }
			  else
			  {
			    System::MemoryExtensions::AsSpan<System::Object>(
			      &v10,
			      (Object__Array *)this->fields.m_systemArray,
			      MethodInfo::System::MemoryExtensions::AsSpan<HG::Rendering::Runtime::GPUParticleSystemBase>);
			    System::Span<Beyond::Gameplay::MissionAcceptMode_EnterAreaInfo::MissionArea>::op_Implicit(
			      (ReadOnlySpan_1_Beyond_Gameplay_MissionAcceptMode_EnterAreaInfo_MissionArea_ *)&v11,
			      (Span_1_Beyond_Gameplay_MissionAcceptMode_EnterAreaInfo_MissionArea_ *)&v10,
			      MethodInfo::System::Span<HG::Rendering::Runtime::GPUParticleSystemBase>::op_Implicit);
			    v5 = v11;
			  }
			  result = retstr;
			  *retstr = v5;
			  return result;
			}
			
			internal void Dispose() {} // 0x0000000189D04778-0x0000000189D047F8
			// Void Dispose()
			void HG::Rendering::Runtime::GPUParticleSystemManager::SystemList::Dispose(
			        GPUParticleSystemManager_SystemList *this,
			        MethodInfo *method)
			{
			  GPUParticleSystemBase *v3; // rdx
			  __int64 v4; // rcx
			  GPUParticleSystemBase__Array *m_systemArray; // rdi
			  int32_t v6; // ebx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( IFix::WrappersManagerImpl::IsPatched(558, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(558, 0LL);
			    if ( Patch )
			    {
			      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
			      return;
			    }
			LABEL_10:
			    sub_1800D8260(v4, v3);
			  }
			  m_systemArray = this->fields.m_systemArray;
			  v6 = 0;
			  if ( !m_systemArray )
			    goto LABEL_10;
			  while ( v6 < m_systemArray->max_length.size )
			  {
			    if ( (unsigned int)v6 >= m_systemArray->max_length.size )
			      sub_1800D2AB0(v4, v3);
			    v3 = m_systemArray->vector[v6];
			    if ( v3 )
			      sub_180003290(4LL, v3);
			    ++v6;
			  }
			}
			
		}
	
		private static class IsBlittableCache<T> // TypeDefIndex: 37736
		{
			// Fields
			public static readonly bool VALUE;
	
			// Constructors
			static IsBlittableCache() {}
		}
	
		// Constructors
		private GPUParticleSystemManager() {} // 0x0000000189CFAB74-0x0000000189CFABF4
		// GPUParticleSystemManager()
		void HG::Rendering::Runtime::GPUParticleSystemManager::GPUParticleSystemManager(
		        GPUParticleSystemManager *this,
		        MethodInfo *method)
		{
		  GPUParticleSystemManager_SystemList *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  GPUParticleSystemManager_SystemList *v6; // rdi
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v10; // rax
		  List_1_System_Int32_ *v11; // rdi
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		  MethodInfo *v16; // [rsp+50h] [rbp+28h]
		
		  v3 = (GPUParticleSystemManager_SystemList *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager::SystemList);
		  v6 = v3;
		  if ( !v3
		    || (HG::Rendering::Runtime::GPUParticleSystemManager::SystemList::SystemList(v3, 128, 0LL),
		        this->fields.m_particleSystems = v6,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields, v7, v8, v9, v15),
		        v10 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<int>),
		        (v11 = (List_1_System_Int32_ *)v10) == 0LL) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v10,
		    MethodInfo::System::Collections::Generic::List<int>::List);
		  this->fields.m_freePool = v11;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_freePool, v12, v13, v14, v16);
		}
		
	
		// Methods
		public static void Dispose() {} // 0x0000000183949C90-0x0000000183949CD0
		// Void Dispose()
		void HG::Rendering::Runtime::GPUParticleSystemManager::Dispose(MethodInfo *method)
		{
		  GPUParticleSystemManager__StaticFields *static_fields; // rcx
		  Type *v2; // rdx
		  PropertyInfo_1 *v3; // r8
		  Int32__Array **v4; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  MethodInfo *v8; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(556, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(556, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    static_fields = TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager->static_fields;
		    if ( static_fields->s_instance )
		    {
		      HG::Rendering::Runtime::GPUParticleSystemManager::DisposeInternal(static_fields->s_instance, 0LL);
		      TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager->static_fields->s_instance = 0LL;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager->static_fields,
		        v2,
		        v3,
		        v4,
		        v8);
		    }
		  }
		}
		
		private void DisposeInternal() {} // 0x0000000189CFA490-0x0000000189CFA504
		// Void DisposeInternal()
		void HG::Rendering::Runtime::GPUParticleSystemManager::DisposeInternal(
		        GPUParticleSystemManager *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  GPUParticleSystemManager_SystemList *m_particleSystems; // rcx
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  Type *v8; // rdx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		  MethodInfo *v13; // [rsp+50h] [rbp+28h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(557, 0LL) )
		  {
		    m_particleSystems = this->fields.m_particleSystems;
		    if ( m_particleSystems )
		    {
		      HG::Rendering::Runtime::GPUParticleSystemManager::SystemList::Dispose(m_particleSystems, 0LL);
		      this->fields.m_particleSystems = 0LL;
		      sub_18002D1B0((SingleFieldAccessor *)&this->fields, v5, v6, v7, v12);
		      this->fields.m_freePool = 0LL;
		      sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_freePool, v8, v9, v10, v13);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_particleSystems, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(557, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		internal SystemHandle CreateParticleSystem<SYSTEM_ATTRIB>([IsReadOnly] in GPUParticleShaders shaders, [IsReadOnly] in GeneralSystemAttributes generalSystemAttributes, Material material, [IsReadOnly] in OptionalSystemFeatures? optionalSystemFeatures)
			where SYSTEM_ATTRIB : struct => default;
		internal void RemoveParticleSystem(SystemHandle handle) {} // 0x0000000189CFA9F8-0x0000000189CFAB74
		// Void RemoveParticleSystem(GPUParticleSystemManager+SystemHandle)
		void HG::Rendering::Runtime::GPUParticleSystemManager::RemoveParticleSystem(
		        GPUParticleSystemManager *this,
		        GPUParticleSystemManager_SystemHandle *handle,
		        MethodInfo *method)
		{
		  GPUParticleSystemManager_SystemList *v5; // rdx
		  GPUParticleSystemManager_SystemList *m_particleSystems; // rcx
		  GPUParticleSystemBase *Item; // rax
		  ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *Span; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  int v11; // ebp
		  int length; // r15d
		  GPUParticleSystemBase **value; // r14
		  bool v14; // cf
		  GPUParticleSystemBase *v15; // r12
		  int32_t maxParticleCount_k__BackingField; // edi
		  int32_t maxAvailableParticleCount; // ebx
		  int32_t maxGPUInstanceCount_k__BackingField; // ebx
		  int32_t gpuInstanceCount; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  GPUParticleSystemManager_SystemHandle v21[2]; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1744, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1744, 0LL);
		    if ( Patch )
		    {
		      v21[0] = *handle;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_703(Patch, (Object *)this, v21, 0LL);
		      return;
		    }
		LABEL_20:
		    sub_1800D8260(m_particleSystems, v5);
		  }
		  m_particleSystems = this->fields.m_particleSystems;
		  if ( !m_particleSystems )
		    goto LABEL_20;
		  Item = HG::Rendering::Runtime::GPUParticleSystemManager::SystemList::get_Item(
		           m_particleSystems,
		           handle->systemID,
		           0LL);
		  if ( !Item )
		    return;
		  sub_180003290(4LL, Item);
		  m_particleSystems = this->fields.m_particleSystems;
		  if ( !m_particleSystems )
		    goto LABEL_20;
		  HG::Rendering::Runtime::GPUParticleSystemManager::SystemList::set_Item(m_particleSystems, handle->systemID, 0LL, 0LL);
		  m_particleSystems = (GPUParticleSystemManager_SystemList *)this->fields.m_freePool;
		  if ( !m_particleSystems )
		    goto LABEL_20;
		  sub_183081250(
		    m_particleSystems,
		    (unsigned int)handle->systemID,
		    MethodInfo::System::Collections::Generic::List<int>::Add);
		  v5 = this->fields.m_particleSystems;
		  this->fields._maxParticleCount_k__BackingField = 0;
		  this->fields._maxGPUInstanceCount_k__BackingField = 0;
		  if ( !v5 )
		    goto LABEL_20;
		  Span = HG::Rendering::Runtime::GPUParticleSystemManager::SystemList::GetSpan(
		           (ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *)v21,
		           v5,
		           0LL);
		  v11 = 0;
		  length = Span->_length;
		  if ( length > 0 )
		  {
		    value = (GPUParticleSystemBase **)Span->_pointer._value;
		    v14 = length != 0;
		    do
		    {
		      if ( !v14 )
		        sub_1800D2AB0(v10, v9);
		      v15 = *value;
		      if ( *value )
		      {
		        maxParticleCount_k__BackingField = this->fields._maxParticleCount_k__BackingField;
		        maxAvailableParticleCount = HG::Rendering::Runtime::GPUParticleSystemBase::get_maxAvailableParticleCount(
		                                      *value,
		                                      0LL);
		        sub_1800036A0(TypeInfo::System::Math);
		        if ( maxParticleCount_k__BackingField >= maxAvailableParticleCount )
		          maxAvailableParticleCount = maxParticleCount_k__BackingField;
		        this->fields._maxParticleCount_k__BackingField = maxAvailableParticleCount;
		        maxGPUInstanceCount_k__BackingField = this->fields._maxGPUInstanceCount_k__BackingField;
		        gpuInstanceCount = HG::Rendering::Runtime::GPUParticleSystemBase::get_gpuInstanceCount(v15, 0LL);
		        if ( maxGPUInstanceCount_k__BackingField >= gpuInstanceCount )
		          gpuInstanceCount = maxGPUInstanceCount_k__BackingField;
		        this->fields._maxGPUInstanceCount_k__BackingField = gpuInstanceCount;
		      }
		      ++v11;
		      ++value;
		      v14 = v11 < (unsigned int)length;
		    }
		    while ( v11 < length );
		  }
		}
		
		internal InstanceHandle CreateParticleSystemInstance<SYSTEM_ATTRIB>(SystemHandle handle, [IsReadOnly] in ref SYSTEM_ATTRIB systemAttribDesc, [IsReadOnly] in PerInstanceData perInstanceData)
			where SYSTEM_ATTRIB : struct => default;
		internal void RemoveParticleSystemInstance(InstanceHandle handle) {} // 0x0000000189CFA858-0x0000000189CFA9F8
		// Void RemoveParticleSystemInstance(GPUParticleSystemManager+InstanceHandle)
		void HG::Rendering::Runtime::GPUParticleSystemManager::RemoveParticleSystemInstance(
		        GPUParticleSystemManager *this,
		        GPUParticleSystemManager_InstanceHandle *handle,
		        MethodInfo *method)
		{
		  GPUParticleSystemManager_SystemList *v5; // rdx
		  GPUParticleSystemManager_SystemList *m_particleSystems; // rcx
		  Type *v7; // xmm0_8
		  int32_t systemID; // edx
		  GPUParticleSystemBase *Item; // rax
		  int32_t instanceID; // edx
		  ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *Span; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  int v14; // ebp
		  int length; // r15d
		  GPUParticleSystemBase **value; // r14
		  bool v17; // cf
		  GPUParticleSystemBase *v18; // r12
		  int32_t maxParticleCount_k__BackingField; // edi
		  int32_t maxAvailableParticleCount; // ebx
		  int32_t maxGPUInstanceCount_k__BackingField; // ebx
		  int32_t gpuInstanceCount; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Type *type; // xmm1_8
		  GPUParticleSystemManager_InstanceHandle v25[2]; // [rsp+20h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1752, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1752, 0LL);
		    if ( Patch )
		    {
		      type = handle->systemHandle.type;
		      *(_OWORD *)&v25[0].instanceID = *(_OWORD *)&handle->instanceID;
		      v25[0].systemHandle.type = type;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_706(Patch, (Object *)this, v25, 0LL);
		      return;
		    }
		    goto LABEL_20;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager::InstanceHandle);
		  if ( !HG::Rendering::Runtime::GPUParticleSystemManager::InstanceHandle::Valid(handle, 0LL) )
		    return;
		  m_particleSystems = this->fields.m_particleSystems;
		  v7 = handle->systemHandle.type;
		  v25[0].systemHandle.type = v7;
		  if ( !m_particleSystems )
		    goto LABEL_20;
		  if ( _mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&handle->instanceID, 8)) >= m_particleSystems->fields._Count_k__BackingField )
		    return;
		  systemID = handle->systemHandle.systemID;
		  v25[0].systemHandle.type = v7;
		  Item = HG::Rendering::Runtime::GPUParticleSystemManager::SystemList::get_Item(m_particleSystems, systemID, 0LL);
		  if ( !Item )
		    return;
		  instanceID = handle->instanceID;
		  v25[0].systemHandle.type = handle->systemHandle.type;
		  HG::Rendering::Runtime::GPUParticleSystemBase::RemoveInstance(Item, instanceID, 0LL);
		  v5 = this->fields.m_particleSystems;
		  this->fields._maxParticleCount_k__BackingField = 0;
		  this->fields._maxGPUInstanceCount_k__BackingField = 0;
		  if ( !v5 )
		LABEL_20:
		    sub_1800D8260(m_particleSystems, v5);
		  Span = HG::Rendering::Runtime::GPUParticleSystemManager::SystemList::GetSpan(
		           (ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *)v25,
		           v5,
		           0LL);
		  v14 = 0;
		  length = Span->_length;
		  if ( length > 0 )
		  {
		    value = (GPUParticleSystemBase **)Span->_pointer._value;
		    v17 = length != 0;
		    do
		    {
		      if ( !v17 )
		        sub_1800D2AB0(v13, v12);
		      v18 = *value;
		      if ( *value )
		      {
		        maxParticleCount_k__BackingField = this->fields._maxParticleCount_k__BackingField;
		        maxAvailableParticleCount = HG::Rendering::Runtime::GPUParticleSystemBase::get_maxAvailableParticleCount(
		                                      *value,
		                                      0LL);
		        sub_1800036A0(TypeInfo::System::Math);
		        if ( maxParticleCount_k__BackingField >= maxAvailableParticleCount )
		          maxAvailableParticleCount = maxParticleCount_k__BackingField;
		        this->fields._maxParticleCount_k__BackingField = maxAvailableParticleCount;
		        maxGPUInstanceCount_k__BackingField = this->fields._maxGPUInstanceCount_k__BackingField;
		        gpuInstanceCount = HG::Rendering::Runtime::GPUParticleSystemBase::get_gpuInstanceCount(v18, 0LL);
		        if ( maxGPUInstanceCount_k__BackingField >= gpuInstanceCount )
		          gpuInstanceCount = maxGPUInstanceCount_k__BackingField;
		        this->fields._maxGPUInstanceCount_k__BackingField = gpuInstanceCount;
		      }
		      ++v14;
		      ++value;
		      v17 = v14 < (unsigned int)length;
		    }
		    while ( v14 < length );
		  }
		}
		
		public void Modify([IsReadOnly] in GeneralSystemAttributes generalSystemAttributes, SystemHandle handle) {} // 0x0000000189CFA7A4-0x0000000189CFA858
		// Void Modify(GeneralSystemAttributes ByRef, GPUParticleSystemManager+SystemHandle)
		void HG::Rendering::Runtime::GPUParticleSystemManager::Modify(
		        GPUParticleSystemManager *this,
		        GeneralSystemAttributes *generalSystemAttributes,
		        GPUParticleSystemManager_SystemHandle *handle,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  GPUParticleSystemManager_SystemList *m_particleSystems; // rcx
		  GPUParticleSystemBase *Item; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  GPUParticleSystemManager_SystemHandle v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1756, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1756, 0LL);
		    if ( Patch )
		    {
		      v11 = *handle;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_707(Patch, (Object *)this, generalSystemAttributes, &v11, 0LL);
		      return;
		    }
		LABEL_7:
		    sub_1800D8260(m_particleSystems, v7);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager::SystemHandle);
		  if ( !HG::Rendering::Runtime::GPUParticleSystemManager::SystemHandle::Valid(handle, 0LL) )
		    return;
		  m_particleSystems = this->fields.m_particleSystems;
		  if ( !m_particleSystems )
		    goto LABEL_7;
		  Item = HG::Rendering::Runtime::GPUParticleSystemManager::SystemList::get_Item(
		           m_particleSystems,
		           handle->systemID,
		           0LL);
		  if ( Item )
		    HG::Rendering::Runtime::GPUParticleSystemBase::Modify(Item, generalSystemAttributes, 0LL);
		}
		
		public void Modify<SYSTEM_ATTRIB>([IsReadOnly] in ref SYSTEM_ATTRIB systemAttribDesc, InstanceHandle handle)
			where SYSTEM_ATTRIB : struct {}
		internal ReadOnlySpan<GPUParticleSystemBase> GetSpan() => default; // 0x0000000189CFA5EC-0x0000000189CFA664
		// ReadOnlySpan`1[HG.Rendering.Runtime.GPUParticleSystemBase] GetSpan()
		ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *HG::Rendering::Runtime::GPUParticleSystemManager::GetSpan(
		        ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *__return_ptr retstr,
		        GPUParticleSystemManager *this,
		        MethodInfo *method)
		{
		  __int64 v5; // rcx
		  GPUParticleSystemManager_SystemList *m_particleSystems; // rdx
		  ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *Span; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ v9; // xmm0
		  ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *result; // rax
		  ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ v11; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1757, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1757, 0LL);
		    if ( Patch )
		    {
		      Span = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_702(&v11, Patch, (Object *)this, 0LL);
		      goto LABEL_7;
		    }
		LABEL_5:
		    sub_1800D8260(v5, m_particleSystems);
		  }
		  m_particleSystems = this->fields.m_particleSystems;
		  if ( !m_particleSystems )
		    goto LABEL_5;
		  Span = HG::Rendering::Runtime::GPUParticleSystemManager::SystemList::GetSpan(&v11, m_particleSystems, 0LL);
		LABEL_7:
		  v9 = *Span;
		  result = retstr;
		  *retstr = v9;
		  return result;
		}
		
		internal bool Full() => default; // 0x0000000189CFA578-0x0000000189CFA5EC
		// Boolean Full()
		bool HG::Rendering::Runtime::GPUParticleSystemManager::Full(GPUParticleSystemManager *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  GPUParticleSystemManager_SystemList *m_particleSystems; // rax
		  List_1_System_Int32_ *m_freePool; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1758, 0LL) )
		  {
		    m_particleSystems = this->fields.m_particleSystems;
		    if ( m_particleSystems )
		    {
		      if ( m_particleSystems->fields._Count_k__BackingField != 128 )
		        return 0;
		      m_freePool = this->fields.m_freePool;
		      if ( m_freePool )
		        return m_freePool->fields._size == 0;
		    }
		LABEL_8:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1758, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		internal bool Empty() => default; // 0x0000000189CFA504-0x0000000189CFA578
		// Boolean Empty()
		bool HG::Rendering::Runtime::GPUParticleSystemManager::Empty(GPUParticleSystemManager *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 Count_k__BackingField; // rcx
		  GPUParticleSystemManager_SystemList *m_particleSystems; // rax
		  List_1_System_Int32_ *m_freePool; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1759, 0LL) )
		  {
		    m_particleSystems = this->fields.m_particleSystems;
		    if ( m_particleSystems )
		    {
		      if ( !m_particleSystems->fields._Count_k__BackingField )
		        return 1;
		      Count_k__BackingField = (unsigned int)m_particleSystems->fields._Count_k__BackingField;
		      m_freePool = this->fields.m_freePool;
		      if ( m_freePool )
		        return (_DWORD)Count_k__BackingField == m_freePool->fields._size;
		    }
		LABEL_8:
		    sub_1800D8260(Count_k__BackingField, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1759, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		private static bool IsBlittable<T>() => default;
		private static bool IsBlittable(System.Type type) => default; // 0x0000000189CFA664-0x0000000189CFA7A4
		// Boolean IsBlittable(Type)
		bool HG::Rendering::Runtime::GPUParticleSystemManager::IsBlittable(Type *type, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  Object *UninitializedObject; // rax
		  bool v6; // bl
		  bool result; // al
		  Type *v8; // rax
		  Type *v9; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Il2CppExceptionWrapper *v11; // rdi
		  Il2CppClass *klass; // rbx
		  __int64 v13; // rax
		  Il2CppExceptionWrapper v14; // [rsp+20h] [rbp-18h] BYREF
		  Il2CppExceptionWrapper *v15; // [rsp+28h] [rbp-10h] BYREF
		  GCHandle v16; // [rsp+50h] [rbp+18h] BYREF
		
		  v16.handle = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(1760, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1760, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)type, 0LL);
		    goto LABEL_10;
		  }
		  if ( !type )
		    goto LABEL_10;
		  if ( !System::Type::get_IsArray(type, 0LL) )
		  {
		    try
		    {
		      sub_1800036A0(TypeInfo::System::Runtime::Serialization::FormatterServices);
		      UninitializedObject = System::Runtime::Serialization::FormatterServices::GetUninitializedObject(type, 0LL);
		      v16.handle = System::Runtime::InteropServices::GCHandle::Alloc(
		                     UninitializedObject,
		                     GCHandleType__Enum_Pinned,
		                     0LL).handle;
		      System::Runtime::InteropServices::GCHandle::Free(&v16, 0LL);
		      v6 = 1;
		    }
		    catch ( Il2CppExceptionWrapper *v15 )
		    {
		      v11 = v15;
		      klass = v15->ex->object.klass;
		      v13 = sub_18007E180(&TypeInfo::System::Object);
		      if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v13, klass) )
		      {
		        v14.ex = v11->ex;
		        throw &v14;
		      }
		      return 0;
		    }
		    return v6;
		  }
		  v8 = (Type *)sub_180005400(57LL, type);
		  v9 = v8;
		  if ( !v8 )
		LABEL_10:
		    sub_1800D8260(v4, v3);
		  result = System::Type::get_IsValueType(v8, 0LL);
		  if ( result )
		    return HG::Rendering::Runtime::GPUParticleSystemManager::IsBlittable(v9, 0LL);
		  return result;
		}
		
	}
}
