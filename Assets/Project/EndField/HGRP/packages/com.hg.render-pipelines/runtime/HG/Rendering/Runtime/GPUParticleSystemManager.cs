using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using IFix.Core;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class GPUParticleSystemManager
	{
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x00002608 File Offset: 0x00000808
		// (set) Token: 0x060007B1 RID: 1969 RVA: 0x000025D0 File Offset: 0x000007D0
		internal int maxParticleCount
		{
			[CompilerGenerated]
			get
			{
				// // Int32 get_count()
				// int32_t Beyond::UnorderedList<System::Object>::get_count(UnorderedList_1_System_Object_ *this, MethodInfo *method)
				// {
				//   return this.fields._count_k__BackingField;
				// }
				// 
				return 0;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_count(Int32)
				// void Beyond::UnorderedList<System::Object>::set_count(
				//         UnorderedList_1_System_Object_ *this,
				//         int32_t value,
				//         MethodInfo *method)
				// {
				//   this.fields._count_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x00002608 File Offset: 0x00000808
		// (set) Token: 0x060007B3 RID: 1971 RVA: 0x000025D0 File Offset: 0x000007D0
		internal int maxGPUInstanceCount
		{
			[CompilerGenerated]
			get
			{
				// // Int32 get_Item4()
				// int32_t System::Tuple<System::Object,System::Object,int,int>::get_Item4(
				//         Tuple_4_Object_Object_Int32_Int32_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.m_Item4;
				// }
				// 
				return 0;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_PageId(Int32)
				// void System::Data::RBTree_1_K_::TreePage<System::Object>::set_PageId(
				//         RBTree_1_K_TreePage_System_Object_ *this,
				//         int32_t value,
				//         MethodInfo *method)
				// {
				//   this.fields._pageId = value;
				// }
				// 
			}
		}

		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x000025D2 File Offset: 0x000007D2
		public static GPUParticleSystemManager instance
		{
			get
			{
				return null;
			}
		}

		private GPUParticleSystemManager()
		{
		}

		public static void Dispose()
		{
		}

		private void DisposeInternal()
		{
		}

		internal GPUParticleSystemManager.SystemHandle CreateParticleSystem<SYSTEM_ATTRIB>(in GPUParticleShaders shaders, in GeneralSystemAttributes generalSystemAttributes, Material material, in Nullable<OptionalSystemFeatures> optionalSystemFeatures) where SYSTEM_ATTRIB : struct
		{
			return default(GPUParticleSystemManager.SystemHandle);
		}

		internal void RemoveParticleSystem(GPUParticleSystemManager.SystemHandle handle)
		{
			// // Void RemoveParticleSystem(GPUParticleSystemManager+SystemHandle)
			// void HG::Rendering::Runtime::GPUParticleSystemManager::RemoveParticleSystem(
			//         GPUParticleSystemManager *this,
			//         GPUParticleSystemManager_SystemHandle *handle,
			//         MethodInfo *method)
			// {
			//   GPUParticleSystemManager_SystemList *v5; // rdx
			//   UnorderedArray_1_System_Object_ *m_particleSystems; // rcx
			//   Object *Item; // rax
			//   ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *Span; // rax
			//   __int64 v9; // rdx
			//   __int64 maxGPUInstanceCount_k__BackingField; // rcx
			//   int v11; // ebp
			//   int length; // r15d
			//   __int64 *value; // r14
			//   bool v14; // cf
			//   __int64 v15; // r13
			//   int v16; // ebx
			//   int32_t maxParticleCount_k__BackingField; // edi
			//   int v18; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   GPUParticleSystemManager_SystemHandle v20[2]; // [rsp+20h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D919DEA )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&MethodInfo::System::ReadOnlySpan<HG::Rendering::Runtime::GPUParticleSystemBase>::get_Length);
			//     byte_18D919DEA = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1467, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1467, 0LL);
			//     if ( Patch )
			//     {
			//       v20[0] = *handle;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_558(Patch, (Object *)this, v20, 0LL);
			//       return;
			//     }
			// LABEL_22:
			//     sub_180B536AC(m_particleSystems, v5);
			//   }
			//   m_particleSystems = (UnorderedArray_1_System_Object_ *)this.fields.m_particleSystems;
			//   if ( !m_particleSystems )
			//     goto LABEL_22;
			//   Item = Beyond::UnorderedArray<System::Object>::get_Item(m_particleSystems, handle.systemID, 0LL);
			//   if ( !Item )
			//     return;
			//   sub_180040B30(4LL, Item);
			//   m_particleSystems = (UnorderedArray_1_System_Object_ *)this.fields.m_particleSystems;
			//   if ( !m_particleSystems )
			//     goto LABEL_22;
			//   HG::Rendering::Runtime::GPUParticleSystemManager::SystemList::set_Item(
			//     (GPUParticleSystemManager_SystemList *)m_particleSystems,
			//     handle.systemID,
			//     0LL,
			//     0LL);
			//   m_particleSystems = (UnorderedArray_1_System_Object_ *)this.fields.m_freePool;
			//   if ( !m_particleSystems )
			//     goto LABEL_22;
			//   sub_18231EF50((List_1_System_Int32_ *)m_particleSystems, handle.systemID);
			//   v5 = this.fields.m_particleSystems;
			//   this.fields._maxParticleCount_k__BackingField = 0;
			//   this.fields._maxGPUInstanceCount_k__BackingField = 0;
			//   if ( !v5 )
			//     goto LABEL_22;
			//   Span = HG::Rendering::Runtime::GPUParticleSystemManager::SystemList::GetSpan(
			//            (ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *)v20,
			//            v5,
			//            0LL);
			//   v11 = 0;
			//   length = Span._length;
			//   if ( length > 0 )
			//   {
			//     value = (__int64 *)Span._pointer._value;
			//     v14 = length != 0;
			//     do
			//     {
			//       if ( !v14 )
			//         sub_180070270(maxGPUInstanceCount_k__BackingField, v9);
			//       v15 = *value;
			//       if ( *value )
			//       {
			//         v16 = *(_DWORD *)(v15 + 80) * *(_DWORD *)(v15 + 152);
			//         maxParticleCount_k__BackingField = this.fields._maxParticleCount_k__BackingField;
			//         sub_180002C70(TypeInfo::System::Math);
			//         maxGPUInstanceCount_k__BackingField = (unsigned int)this.fields._maxGPUInstanceCount_k__BackingField;
			//         if ( maxParticleCount_k__BackingField < v16 )
			//           maxParticleCount_k__BackingField = v16;
			//         this.fields._maxParticleCount_k__BackingField = maxParticleCount_k__BackingField;
			//         v18 = *(_DWORD *)(v15 + 152);
			//         if ( (int)maxGPUInstanceCount_k__BackingField < v18 )
			//           maxGPUInstanceCount_k__BackingField = (unsigned int)v18;
			//         this.fields._maxGPUInstanceCount_k__BackingField = maxGPUInstanceCount_k__BackingField;
			//       }
			//       ++v11;
			//       ++value;
			//       v14 = v11 < (unsigned int)length;
			//     }
			//     while ( v11 < length );
			//   }
			// }
			// 
		}

		internal GPUParticleSystemManager.InstanceHandle CreateParticleSystemInstance<SYSTEM_ATTRIB>(GPUParticleSystemManager.SystemHandle handle, in SYSTEM_ATTRIB systemAttribDesc, in PerInstanceData perInstanceData) where SYSTEM_ATTRIB : struct
		{
			return default(GPUParticleSystemManager.InstanceHandle);
		}

		internal void RemoveParticleSystemInstance(GPUParticleSystemManager.InstanceHandle handle)
		{
			// // Void RemoveParticleSystemInstance(GPUParticleSystemManager+InstanceHandle)
			// void HG::Rendering::Runtime::GPUParticleSystemManager::RemoveParticleSystemInstance(
			//         GPUParticleSystemManager *this,
			//         GPUParticleSystemManager_InstanceHandle *handle,
			//         MethodInfo *method)
			// {
			//   GPUParticleSystemManager_SystemList *v5; // rdx
			//   GPUParticleSystemManager_SystemList *m_particleSystems; // rcx
			//   Type *v7; // xmm0_8
			//   int32_t systemID; // edx
			//   Object *Item; // rax
			//   int32_t instanceID; // edx
			//   ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *Span; // rax
			//   __int64 v12; // rdx
			//   __int64 maxGPUInstanceCount_k__BackingField; // rcx
			//   int v14; // ebp
			//   int length; // r15d
			//   __int64 *value; // r14
			//   bool v17; // cf
			//   __int64 v18; // r13
			//   int v19; // ebx
			//   int32_t maxParticleCount_k__BackingField; // edi
			//   int v21; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Type *type; // xmm1_8
			//   GPUParticleSystemManager_InstanceHandle v24[2]; // [rsp+20h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D919DEB )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager::InstanceHandle);
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&MethodInfo::System::ReadOnlySpan<HG::Rendering::Runtime::GPUParticleSystemBase>::get_Length);
			//     byte_18D919DEB = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1473, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1473, 0LL);
			//     if ( Patch )
			//     {
			//       type = handle.systemHandle.type;
			//       *(_OWORD *)&v24[0].instanceID = *(_OWORD *)&handle.instanceID;
			//       v24[0].systemHandle.type = type;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_561(Patch, (Object *)this, v24, 0LL);
			//       return;
			//     }
			//     goto LABEL_22;
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager::InstanceHandle);
			//   if ( !HG::Rendering::Runtime::GPUParticleSystemManager::InstanceHandle::Valid(handle, 0LL) )
			//     return;
			//   m_particleSystems = this.fields.m_particleSystems;
			//   v7 = handle.systemHandle.type;
			//   v24[0].systemHandle.type = v7;
			//   if ( !m_particleSystems )
			//     goto LABEL_22;
			//   if ( _mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&handle.instanceID, 8)) >= m_particleSystems.fields._Count_k__BackingField )
			//     return;
			//   systemID = handle.systemHandle.systemID;
			//   v24[0].systemHandle.type = v7;
			//   Item = Beyond::UnorderedArray<System::Object>::get_Item(
			//            (UnorderedArray_1_System_Object_ *)m_particleSystems,
			//            systemID,
			//            0LL);
			//   if ( !Item )
			//     return;
			//   instanceID = handle.instanceID;
			//   v24[0].systemHandle.type = handle.systemHandle.type;
			//   HG::Rendering::Runtime::GPUParticleSystemBase::RemoveInstance((GPUParticleSystemBase *)Item, instanceID, 0LL);
			//   v5 = this.fields.m_particleSystems;
			//   this.fields._maxParticleCount_k__BackingField = 0;
			//   this.fields._maxGPUInstanceCount_k__BackingField = 0;
			//   if ( !v5 )
			// LABEL_22:
			//     sub_180B536AC(m_particleSystems, v5);
			//   Span = HG::Rendering::Runtime::GPUParticleSystemManager::SystemList::GetSpan(
			//            (ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *)v24,
			//            v5,
			//            0LL);
			//   v14 = 0;
			//   length = Span._length;
			//   if ( length > 0 )
			//   {
			//     value = (__int64 *)Span._pointer._value;
			//     v17 = length != 0;
			//     do
			//     {
			//       if ( !v17 )
			//         sub_180070270(maxGPUInstanceCount_k__BackingField, v12);
			//       v18 = *value;
			//       if ( *value )
			//       {
			//         v19 = *(_DWORD *)(v18 + 80) * *(_DWORD *)(v18 + 152);
			//         maxParticleCount_k__BackingField = this.fields._maxParticleCount_k__BackingField;
			//         sub_180002C70(TypeInfo::System::Math);
			//         maxGPUInstanceCount_k__BackingField = (unsigned int)this.fields._maxGPUInstanceCount_k__BackingField;
			//         if ( maxParticleCount_k__BackingField < v19 )
			//           maxParticleCount_k__BackingField = v19;
			//         this.fields._maxParticleCount_k__BackingField = maxParticleCount_k__BackingField;
			//         v21 = *(_DWORD *)(v18 + 152);
			//         if ( (int)maxGPUInstanceCount_k__BackingField < v21 )
			//           maxGPUInstanceCount_k__BackingField = (unsigned int)v21;
			//         this.fields._maxGPUInstanceCount_k__BackingField = maxGPUInstanceCount_k__BackingField;
			//       }
			//       ++v14;
			//       ++value;
			//       v17 = v14 < (unsigned int)length;
			//     }
			//     while ( v14 < length );
			//   }
			// }
			// 
		}

		public void Modify(in GeneralSystemAttributes generalSystemAttributes, GPUParticleSystemManager.SystemHandle handle)
		{
			// // Void Modify(GeneralSystemAttributes ByRef, GPUParticleSystemManager+SystemHandle)
			// void HG::Rendering::Runtime::GPUParticleSystemManager::Modify(
			//         GPUParticleSystemManager *this,
			//         GeneralSystemAttributes *generalSystemAttributes,
			//         GPUParticleSystemManager_SystemHandle *handle,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   GPUParticleSystemManager_SystemList *m_particleSystems; // rcx
			//   Object *Item; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   GPUParticleSystemManager_SystemHandle v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919DEC )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager::SystemHandle);
			//     byte_18D919DEC = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1477, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1477, 0LL);
			//     if ( Patch )
			//     {
			//       v11 = *handle;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_562(Patch, (Object *)this, generalSystemAttributes, &v11, 0LL);
			//       return;
			//     }
			// LABEL_9:
			//     sub_180B536AC(m_particleSystems, v7);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager::SystemHandle);
			//   if ( !HG::Rendering::Runtime::GPUParticleSystemManager::SystemHandle::Valid(handle, 0LL) )
			//     return;
			//   m_particleSystems = this.fields.m_particleSystems;
			//   if ( !m_particleSystems )
			//     goto LABEL_9;
			//   Item = Beyond::UnorderedArray<System::Object>::get_Item(
			//            (UnorderedArray_1_System_Object_ *)m_particleSystems,
			//            handle.systemID,
			//            0LL);
			//   if ( Item )
			//     HG::Rendering::Runtime::GPUParticleSystemBase::Modify((GPUParticleSystemBase *)Item, generalSystemAttributes, 0LL);
			// }
			// 
		}

		public void Modify<SYSTEM_ATTRIB>(in SYSTEM_ATTRIB systemAttribDesc, GPUParticleSystemManager.InstanceHandle handle) where SYSTEM_ATTRIB : struct
		{
		}

		internal ReadOnlySpan<GPUParticleSystemBase> GetSpan()
		{
			// // ReadOnlySpan`1[HG.Rendering.Runtime.GPUParticleSystemBase] GetSpan()
			// ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *HG::Rendering::Runtime::GPUParticleSystemManager::GetSpan(
			//         ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *__return_ptr retstr,
			//         GPUParticleSystemManager *this,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rcx
			//   GPUParticleSystemManager_SystemList *m_particleSystems; // rdx
			//   ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *Span; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ v9; // xmm0
			//   ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *result; // rax
			//   ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ v11; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1478, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1478, 0LL);
			//     if ( Patch )
			//     {
			//       Span = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_557(&v11, Patch, (Object *)this, 0LL);
			//       goto LABEL_7;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v5, m_particleSystems);
			//   }
			//   m_particleSystems = this.fields.m_particleSystems;
			//   if ( !m_particleSystems )
			//     goto LABEL_5;
			//   Span = HG::Rendering::Runtime::GPUParticleSystemManager::SystemList::GetSpan(&v11, m_particleSystems, 0LL);
			// LABEL_7:
			//   v9 = *Span;
			//   result = retstr;
			//   *retstr = v9;
			//   return result;
			// }
			// 
			return null;
		}

		internal bool Full()
		{
			// // Boolean Full()
			// bool HG::Rendering::Runtime::GPUParticleSystemManager::Full(GPUParticleSystemManager *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   GPUParticleSystemManager_SystemList *m_particleSystems; // rax
			//   List_1_System_Int32_ *m_freePool; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919DED )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Count);
			//     byte_18D919DED = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1479, 0LL) )
			//   {
			//     m_particleSystems = this.fields.m_particleSystems;
			//     if ( m_particleSystems )
			//     {
			//       if ( m_particleSystems.fields._Count_k__BackingField != 128 )
			//         return 0;
			//       m_freePool = this.fields.m_freePool;
			//       if ( m_freePool )
			//         return m_freePool.fields._size == 0;
			//     }
			// LABEL_10:
			//     sub_180B536AC(v4, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1479, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		internal bool Empty()
		{
			// // Boolean Empty()
			// bool HG::Rendering::Runtime::GPUParticleSystemManager::Empty(GPUParticleSystemManager *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   GPUParticleSystemManager_SystemList *m_particleSystems; // rcx
			//   List_1_System_Int32_ *m_freePool; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919DEE )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Count);
			//     byte_18D919DEE = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1480, 0LL) )
			//   {
			//     m_particleSystems = this.fields.m_particleSystems;
			//     if ( m_particleSystems )
			//     {
			//       if ( !m_particleSystems.fields._Count_k__BackingField )
			//         return 1;
			//       m_freePool = this.fields.m_freePool;
			//       m_particleSystems = (GPUParticleSystemManager_SystemList *)(unsigned int)m_particleSystems.fields._Count_k__BackingField;
			//       if ( m_freePool )
			//         return (_DWORD)m_particleSystems == m_freePool.fields._size;
			//     }
			// LABEL_10:
			//     sub_180B536AC(m_particleSystems, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1480, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		private static bool IsBlittable<T>()
		{
			return default(bool);
		}

		private static bool IsBlittable(Type type)
		{
			// // Boolean IsBlittable(Type)
			// bool HG::Rendering::Runtime::GPUParticleSystemManager::IsBlittable(Type *type, MethodInfo *method)
			// {
			//   bool v3; // bl
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   Object *UninitializedObject; // rax
			//   bool result; // al
			//   Type *v8; // rax
			//   Type *v9; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Il2CppExceptionWrapper *v11; // rdi
			//   Il2CppClass *klass; // rbx
			//   __int64 v13; // rax
			//   Il2CppExceptionWrapper v14; // [rsp+20h] [rbp-18h] BYREF
			//   Il2CppExceptionWrapper *v15; // [rsp+28h] [rbp-10h] BYREF
			//   GCHandle v16; // [rsp+50h] [rbp+18h] BYREF
			// 
			//   if ( byte_18D919DEF )
			//   {
			//     v3 = 1;
			//   }
			//   else
			//   {
			//     sub_18003C530(&TypeInfo::System::Runtime::Serialization::FormatterServices);
			//     v3 = 1;
			//     byte_18D919DEF = 1;
			//   }
			//   v16.handle = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1481, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1481, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)type, 0LL);
			//     goto LABEL_13;
			//   }
			//   if ( !type )
			//     goto LABEL_13;
			//   if ( !System::Type::get_IsArray(type, 0LL) )
			//   {
			//     try
			//     {
			//       sub_180002C70(TypeInfo::System::Runtime::Serialization::FormatterServices);
			//       UninitializedObject = System::Runtime::Serialization::FormatterServices::GetUninitializedObject(type, 0LL);
			//       v16.handle = System::Runtime::InteropServices::GCHandle::Alloc(
			//                      UninitializedObject,
			//                      GCHandleType__Enum_Pinned,
			//                      0LL).handle;
			//       System::Runtime::InteropServices::GCHandle::Free(&v16, 0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v15 )
			//     {
			//       v11 = v15;
			//       klass = v15.ex.object.klass;
			//       v13 = sub_18000F7E0(&TypeInfo::System::Object);
			//       if ( !(unsigned __int8)il2cpp_class_is_assignable_from_0(v13, klass) )
			//       {
			//         v14.ex = v11.ex;
			//         throw &v14;
			//       }
			//       return 0;
			//     }
			//     return v3;
			//   }
			//   v8 = (Type *)sub_18003F5D0(55LL, type);
			//   v9 = v8;
			//   if ( !v8 )
			// LABEL_13:
			//     sub_180B536AC(v5, v4);
			//   result = System::Type::get_IsValueType(v8, 0LL);
			//   if ( result )
			//     return HG::Rendering::Runtime::GPUParticleSystemManager::IsBlittable(v9, 0LL);
			//   return result;
			// }
			// 
			return default(bool);
		}

		private const int MAX_SYSTEM_COUNT = 128;

		private GPUParticleSystemManager.SystemList m_particleSystems;

		private List<int> m_freePool;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static GPUParticleSystemManager s_instance;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct SimulateContext
		{
			internal ComputeShader emitShader;

			internal ComputeShader simulateShader;

			internal ComputeBuffer perInstanceBuffer;

			internal ComputeBuffer generalSystemAttributeBuffer;

			internal ComputeBuffer systemAttributesBuffer;

			internal ComputeBuffer particleAttributesBuffer;

			internal ComputeBuffer liveListBuffer;

			internal ComputeBuffer deadListBuffer;

			internal ComputeBuffer deadCountBuffer;

			internal ComputeBuffer drawIndirectArgsBuffer;

			internal GeneralSystemAttributes generalSystemAttributes;

			internal int instanceCount;

			internal int maxEmitRate;

			internal int[] instancesToClear;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct RenderContext
		{
			internal Mesh mesh;

			internal GraphicsBuffer indexBuffer;

			internal ComputeBuffer drawIndirectArgsBuffer;

			internal Material material;

			internal ComputeBuffer particleAttributesBuffer;

			internal ComputeBuffer liveListBuffer;

			internal ComputeBuffer generalSystemAttributeBuffer;

			internal int instanceCount;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 4)]
		public struct Handle
		{
			public Handle(int index)
			{
				// // Void WriteUnaligned[UInt32](Byte ByRef, UInt32)
				// void System::Runtime::CompilerServices::Unsafe::WriteUnaligned<unsigned int>(
				//         uint8_t *destination,
				//         uint32_t value,
				//         MethodInfo *method)
				// {
				//   *(_DWORD *)destination = value;
				// }
				// 
			}

			public readonly int index;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct SystemHandle
		{
			internal SystemHandle(int systemID, Type type)
			{
				// // IndexedDictionary`2[TKey,TValue]+yzhVwnWVXpgEXQufmGiVcJkbjlTI[System.UInt32,System.Object](UInt32, Object)
				// // local variable allocation has failed, the output may be wrong!
				// void Rewired::Utils::Classes::Data::IndexedDictionary_2_TKey_TValue_::yzhVwnWVXpgEXQufmGiVcJkbjlTI<unsigned int,System::Object>::yzhVwnWVXpgEXQufmGiVcJkbjlTI(
				//         IndexedDictionary_2_TKey_TValue_yzhVwnWVXpgEXQufmGiVcJkbjlTI_System_UInt32_System_Object_ *this,
				//         uint32_t param_00052bfb,
				//         Object *param_00052bfc,
				//         MethodInfo *method)
				// {
				//   String__Array *v4; // [rsp+28h] [rbp+28h]
				//   String *v5; // [rsp+30h] [rbp+30h]
				//   MethodInfo *v6; // [rsp+38h] [rbp+38h]
				// 
				//   this.fgQJCyoleogxMFsOUGgTUMofNhGP = param_00052bfb;
				//   this.vMmuLUVFGZZNSIceFhSpeBITqghGA = param_00052bfc;
				//   sub_1800054D0(
				//     (OneofDescriptor *)&this.vMmuLUVFGZZNSIceFhSpeBITqghGA,
				//     *(OneofDescriptorProto **)&param_00052bfb,
				//     (FileDescriptor *)param_00052bfc,
				//     (MessageDescriptor *)method,
				//     v4,
				//     v5,
				//     v6);
				// }
				// 
			}

			[IDTag(1)]
			public bool Valid(Type type)
			{
				// // Boolean Valid(Type)
				// bool HG::Rendering::Runtime::GPUParticleSystemManager::SystemHandle::Valid(
				//         GPUParticleSystemManager_SystemHandle *this,
				//         Type *type,
				//         MethodInfo *method)
				// {
				//   bool result; // al
				//   Type *v6; // rbx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v8; // rdx
				//   __int64 v9; // rcx
				// 
				//   if ( !byte_18D919DF0 )
				//   {
				//     sub_18003C530(&TypeInfo::System::Type);
				//     byte_18D919DF0 = 1;
				//   }
				//   result = IFix::WrappersManagerImpl::IsPatched(1482, 0LL);
				//   if ( result )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1482, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v9, v8);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_563(Patch, this, (Object *)type, 0LL);
				//   }
				//   else if ( this.systemID != -1 )
				//   {
				//     v6 = this.type;
				//     sub_180002C70(TypeInfo::System::Type);
				//     return v6 == type;
				//   }
				//   return result;
				// }
				// 
				return default(bool);
			}

			[IDTag(0)]
			public bool Valid()
			{
				// // Boolean Valid()
				// bool HG::Rendering::Runtime::GPUParticleSystemManager::SystemHandle::Valid(
				//         GPUParticleSystemManager_SystemHandle *this,
				//         MethodInfo *method)
				// {
				//   bool result; // al
				//   Type *type; // rbx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				// 
				//   if ( !byte_18D919DF1 )
				//   {
				//     sub_18003C530(&TypeInfo::System::Type);
				//     byte_18D919DF1 = 1;
				//   }
				//   result = IFix::WrappersManagerImpl::IsPatched(1475, 0LL);
				//   if ( result )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1475, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v7, v6);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_559(Patch, this, 0LL);
				//   }
				//   else if ( this.systemID != -1 )
				//   {
				//     type = this.type;
				//     sub_180002C70(TypeInfo::System::Type);
				//     return type != 0LL;
				//   }
				//   return result;
				// }
				// 
				return default(bool);
			}

			public readonly int systemID;

			public readonly Type type;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
			public static GPUParticleSystemManager.SystemHandle nullHandle;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct InstanceHandle
		{
			internal InstanceHandle(int instanceID, GPUParticleSystemManager.SystemHandle systemHandle)
			{
				// // ValueTuple`2[Int32,Beyond.Gameplay.Factory.Core.GridPath](Int32, GridPath)
				// // local variable allocation has failed, the output may be wrong!
				// void System::ValueTuple<int,Beyond::Gameplay::Factory::Core::GridPath>::ValueTuple(
				//         ValueTuple_2_Int32_Beyond_Gameplay_Factory_Core_GridPath_ *this,
				//         int32_t item1,
				//         GridPath *item2,
				//         MethodInfo *method)
				// {
				//   GridPath v4; // xmm0
				//   String__Array *v5; // [rsp+28h] [rbp+28h]
				//   String *v6; // [rsp+30h] [rbp+30h]
				//   MethodInfo *v7; // [rsp+38h] [rbp+38h]
				// 
				//   v4 = *item2;
				//   this.Item1 = item1;
				//   this.Item2 = v4;
				//   sub_1800054D0(
				//     (OneofDescriptor *)&this.Item2.segments,
				//     *(OneofDescriptorProto **)&item1,
				//     (FileDescriptor *)item2,
				//     (MessageDescriptor *)method,
				//     v5,
				//     v6,
				//     v7);
				// }
				// 
			}

			[IDTag(1)]
			public bool Valid(Type type)
			{
				// // Boolean Valid(Type)
				// bool HG::Rendering::Runtime::GPUParticleSystemManager::InstanceHandle::Valid(
				//         GPUParticleSystemManager_InstanceHandle *this,
				//         Type *type,
				//         MethodInfo *method)
				// {
				//   bool result; // al
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v7; // rdx
				//   __int64 v8; // rcx
				//   GPUParticleSystemManager_SystemHandle systemHandle; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   if ( !byte_18D919DF3 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager::SystemHandle);
				//     byte_18D919DF3 = 1;
				//   }
				//   systemHandle = 0LL;
				//   result = IFix::WrappersManagerImpl::IsPatched(1483, 0LL);
				//   if ( result )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1483, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v8, v7);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_564(Patch, this, (Object *)type, 0LL);
				//   }
				//   else if ( this.instanceID != -1 )
				//   {
				//     systemHandle = this.systemHandle;
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager::SystemHandle);
				//     return HG::Rendering::Runtime::GPUParticleSystemManager::SystemHandle::Valid(&systemHandle, type, 0LL);
				//   }
				//   return result;
				// }
				// 
				return default(bool);
			}

			[IDTag(0)]
			public bool Valid()
			{
				// // Boolean Valid()
				// bool HG::Rendering::Runtime::GPUParticleSystemManager::InstanceHandle::Valid(
				//         GPUParticleSystemManager_InstanceHandle *this,
				//         MethodInfo *method)
				// {
				//   bool result; // al
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				//   GPUParticleSystemManager_SystemHandle systemHandle; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   if ( !byte_18D919DF4 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager::SystemHandle);
				//     byte_18D919DF4 = 1;
				//   }
				//   systemHandle = 0LL;
				//   result = IFix::WrappersManagerImpl::IsPatched(1474, 0LL);
				//   if ( result )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1474, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v6, v5);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_560(Patch, this, 0LL);
				//   }
				//   else if ( this.instanceID != -1 )
				//   {
				//     systemHandle = this.systemHandle;
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::GPUParticleSystemManager::SystemHandle);
				//     return HG::Rendering::Runtime::GPUParticleSystemManager::SystemHandle::Valid(&systemHandle, 0LL);
				//   }
				//   return result;
				// }
				// 
				return default(bool);
			}

			public readonly int instanceID;

			public readonly GPUParticleSystemManager.SystemHandle systemHandle;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
			public static GPUParticleSystemManager.InstanceHandle nullHandle;
		}

		[DefaultMember("Item")]
		private class SystemList
		{
			// (get) Token: 0x060007CC RID: 1996 RVA: 0x00002608 File Offset: 0x00000808
			// (set) Token: 0x060007CD RID: 1997 RVA: 0x000025D0 File Offset: 0x000007D0
			internal int Count
			{
				[CompilerGenerated]
				get
				{
					// // LayerMask get_value()
					// LayerMask UnityEngine::Rendering::VolumeParameter<UnityEngine::LayerMask>::get_value(
					//         VolumeParameter_1_UnityEngine_LayerMask_ *this,
					//         MethodInfo *method)
					// {
					//   return (LayerMask)this.fields.m_Value.m_Mask;
					// }
					// 
					return 0;
				}
				[CompilerGenerated]
				private set
				{
					// // Void set_value(LayerMask)
					// void UnityEngine::Rendering::VolumeParameter<UnityEngine::LayerMask>::set_value(
					//         VolumeParameter_1_UnityEngine_LayerMask_ *this,
					//         LayerMask value,
					//         MethodInfo *method)
					// {
					//   this.fields.m_Value = value;
					// }
					// 
				}
			}

			// (get) Token: 0x060007CE RID: 1998 RVA: 0x000025D2 File Offset: 0x000007D2
			// (set) Token: 0x060007CF RID: 1999 RVA: 0x000025D0 File Offset: 0x000007D0
			public GPUParticleSystemBase Item
			{
				get
				{
					// // Object get_Item(Int32)
					// // local variable allocation has failed, the output may be wrong!
					// Object *Beyond::UnorderedArray<System::Object>::get_Item(
					//         UnorderedArray_1_System_Object_ *this,
					//         int32_t index,
					//         MethodInfo *method)
					// {
					//   Object__Array *m_items; // r8
					// 
					//   m_items = this.fields.m_items;
					//   if ( !m_items )
					//     sub_180B536AC(this, *(_QWORD *)&index);
					//   if ( (unsigned int)index >= m_items.max_length.size )
					//     sub_180070270(this, *(_QWORD *)&index);
					//   return m_items.vector[index];
					// }
					// 
					return null;
				}
				set
				{
					// // Void set_Item(Int32, GPUParticleSystemBase)
					// // local variable allocation has failed, the output may be wrong!
					// void HG::Rendering::Runtime::GPUParticleSystemManager::SystemList::set_Item(
					//         GPUParticleSystemManager_SystemList *this,
					//         int32_t key,
					//         GPUParticleSystemBase *value,
					//         MethodInfo *method)
					// {
					//   GPUParticleSystemBase__Array *m_systemArray; // rbx
					//   __int64 v6; // rsi
					// 
					//   m_systemArray = this.fields.m_systemArray;
					//   v6 = key;
					//   if ( !m_systemArray )
					//     sub_180B536AC(this, *(_QWORD *)&key);
					//   sub_180036D40(this.fields.m_systemArray, value);
					//   sub_180328478(m_systemArray, v6, value);
					// }
					// 
				}
			}

			internal SystemList(int capacity)
			{
				// // GPUParticleSystemManager+SystemList(Int32)
				// void HG::Rendering::Runtime::GPUParticleSystemManager::SystemList::SystemList(
				//         GPUParticleSystemManager_SystemList *this,
				//         int32_t capacity,
				//         MethodInfo *method)
				// {
				//   __int64 v3; // r9
				//   __int64 v5; // rdi
				//   OneofDescriptorProto *v6; // rdx
				//   FileDescriptor *v7; // r8
				//   MessageDescriptor *v8; // r9
				//   String__Array *v9; // [rsp+50h] [rbp+28h]
				//   String *v10; // [rsp+58h] [rbp+30h]
				//   MethodInfo *v11; // [rsp+60h] [rbp+38h]
				// 
				//   v5 = (unsigned int)capacity;
				//   if ( !byte_18D919DF6 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GPUParticleSystemBase);
				//     byte_18D919DF6 = 1;
				//   }
				//   this.fields.m_systemArray = (GPUParticleSystemBase__Array *)il2cpp_array_new_specific_0(
				//                                                                  TypeInfo::HG::Rendering::Runtime::GPUParticleSystemBase,
				//                                                                  v5,
				//                                                                  method,
				//                                                                  v3);
				//   sub_1800054D0((OneofDescriptor *)&this.fields, v6, v7, v8, v9, v10, v11);
				// }
				// 
			}

			internal bool Add(GPUParticleSystemBase sys)
			{
				// // Boolean Add(GPUParticleSystemBase)
				// bool HG::Rendering::Runtime::GPUParticleSystemManager::SystemList::Add(
				//         GPUParticleSystemManager_SystemList *this,
				//         GPUParticleSystemBase *sys,
				//         MethodInfo *method)
				// {
				//   __int64 v5; // rdx
				//   GPUParticleSystemBase__Array *m_systemArray; // rax
				//   __int64 Count_k__BackingField; // rcx
				//   __int64 v8; // rbx
				//   GPUParticleSystemBase__Array *v9; // rdi
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(1484, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1484, 0LL);
				//     if ( Patch )
				//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
				//                (ILFixDynamicMethodWrapper_36 *)Patch,
				//                (Object *)this,
				//                (Object *)sys,
				//                0LL);
				// LABEL_7:
				//     sub_180B536AC(Count_k__BackingField, v5);
				//   }
				//   m_systemArray = this.fields.m_systemArray;
				//   Count_k__BackingField = (unsigned int)this.fields._Count_k__BackingField;
				//   if ( !m_systemArray )
				//     goto LABEL_7;
				//   if ( (_DWORD)Count_k__BackingField == m_systemArray.max_length.size )
				//     return 0;
				//   v8 = (int)Count_k__BackingField;
				//   v9 = this.fields.m_systemArray;
				//   this.fields._Count_k__BackingField = Count_k__BackingField + 1;
				//   sub_180036D40(v9, sys);
				//   sub_180328478(v9, v8, sys);
				//   return 1;
				// }
				// 
				return default(bool);
			}

			internal ReadOnlySpan<GPUParticleSystemBase> GetSpan()
			{
				// // ReadOnlySpan`1[HG.Rendering.Runtime.GPUParticleSystemBase] GetSpan()
				// ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *HG::Rendering::Runtime::GPUParticleSystemManager::SystemList::GetSpan(
				//         ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *__return_ptr retstr,
				//         GPUParticleSystemManager_SystemList *this,
				//         MethodInfo *method)
				// {
				//   ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ v5; // xmm0
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v7; // rdx
				//   __int64 v8; // rcx
				//   ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ *result; // rax
				//   Span_1_Object_ v10; // [rsp+20h] [rbp-28h] BYREF
				//   ReadOnlySpan_1_HG_Rendering_Runtime_GPUParticleSystemBase_ v11; // [rsp+30h] [rbp-18h] BYREF
				// 
				//   if ( !byte_18D919DF7 )
				//   {
				//     sub_18003C530(&MethodInfo::System::MemoryExtensions::AsSpan<HG::Rendering::Runtime::GPUParticleSystemBase>);
				//     sub_18003C530(&MethodInfo::System::Span<HG::Rendering::Runtime::GPUParticleSystemBase>::op_Implicit);
				//     byte_18D919DF7 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(1470, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1470, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v8, v7);
				//     v5 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_557(&v11, Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     System::MemoryExtensions::AsSpan<System::Object>(
				//       &v10,
				//       (Object__Array *)this.fields.m_systemArray,
				//       MethodInfo::System::MemoryExtensions::AsSpan<HG::Rendering::Runtime::GPUParticleSystemBase>);
				//     System::Span<Beyond::Gameplay::MissionAcceptMode_EnterAreaInfo::MissionArea>::op_Implicit(
				//       (ReadOnlySpan_1_Beyond_Gameplay_MissionAcceptMode_EnterAreaInfo_MissionArea_ *)&v11,
				//       (Span_1_Beyond_Gameplay_MissionAcceptMode_EnterAreaInfo_MissionArea_ *)&v10,
				//       MethodInfo::System::Span<HG::Rendering::Runtime::GPUParticleSystemBase>::op_Implicit);
				//     v5 = v11;
				//   }
				//   result = retstr;
				//   *retstr = v5;
				//   return result;
				// }
				// 
				return null;
			}

			internal void Dispose()
			{
				// // Void Dispose()
				// void HG::Rendering::Runtime::GPUParticleSystemManager::SystemList::Dispose(
				//         GPUParticleSystemManager_SystemList *this,
				//         MethodInfo *method)
				// {
				//   GPUParticleSystemBase *v3; // rdx
				//   __int64 v4; // rcx
				//   GPUParticleSystemBase__Array *m_systemArray; // rdi
				//   int32_t v6; // ebx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(532, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(532, 0LL);
				//     if ( Patch )
				//     {
				//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
				//       return;
				//     }
				// LABEL_10:
				//     sub_180B536AC(v4, v3);
				//   }
				//   m_systemArray = this.fields.m_systemArray;
				//   v6 = 0;
				//   if ( !m_systemArray )
				//     goto LABEL_10;
				//   while ( v6 < m_systemArray.max_length.size )
				//   {
				//     if ( (unsigned int)v6 >= m_systemArray.max_length.size )
				//       sub_180070270(v4, v3);
				//     v3 = m_systemArray.vector[v6];
				//     if ( v3 )
				//       sub_180040B30(4LL, v3);
				//     ++v6;
				//   }
				// }
				// 
			}

			private GPUParticleSystemBase[] m_systemArray;
		}

		private static class IsBlittableCache<T>
		{
			[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
			public static readonly bool VALUE;
		}
	}
}
