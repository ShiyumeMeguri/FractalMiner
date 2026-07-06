using System;
using System.Collections.Generic;
using UnityEngine;

namespace HG.Rendering.RenderGraphModule
{
	public sealed class HGRenderGraphObjectPool
	{
		internal HGRenderGraphObjectPool()
		{
		}

		public T[] GetTempArray<T>(int size)
		{
			return null;
		}

		public MaterialPropertyBlock GetTempMaterialPropertyBlock()
		{
			// // MaterialPropertyBlock GetTempMaterialPropertyBlock()
			// MaterialPropertyBlock *HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::GetTempMaterialPropertyBlock(
			//         HGRenderGraphObjectPool *this,
			//         MethodInfo *method)
			// {
			//   HGRenderGraphObjectPool_SharedObjectPool_1_System_Object_ *sharedPool; // rax
			//   __int64 v4; // rdx
			//   List_1_System_Object_ *m_AllocatedMaterialPropertyBlocks; // rcx
			//   Object *v6; // rax
			//   Object *v7; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91935A )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::MaterialPropertyBlock>::Add);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::SharedObjectPool<UnityEngine::MaterialPropertyBlock>::Get);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::SharedObjectPool<UnityEngine::MaterialPropertyBlock>::get_sharedPool);
			//     sub_18003C530(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::SharedObjectPool<UnityEngine::MaterialPropertyBlock>);
			//     byte_18D91935A = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(269, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::SharedObjectPool<UnityEngine::MaterialPropertyBlock>[0]);
			//     sharedPool = HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::SharedObjectPool<System::Object>::get_sharedPool(MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::SharedObjectPool<UnityEngine::MaterialPropertyBlock>::get_sharedPool);
			//     if ( sharedPool )
			//     {
			//       v6 = UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphObjectPool::SharedObjectPool<System::Object>::Get(
			//              (RenderGraphObjectPool_SharedObjectPool_1_System_Object_ *)sharedPool,
			//              MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::SharedObjectPool<UnityEngine::MaterialPropertyBlock>::Get);
			//       v7 = v6;
			//       if ( v6 )
			//       {
			//         UnityEngine::MaterialPropertyBlock::Clear((MaterialPropertyBlock *)v6, 1, 0LL);
			//         m_AllocatedMaterialPropertyBlocks = (List_1_System_Object_ *)this.fields.m_AllocatedMaterialPropertyBlocks;
			//         if ( m_AllocatedMaterialPropertyBlocks )
			//         {
			//           sub_1822AD140(m_AllocatedMaterialPropertyBlocks, v7);
			//           return (MaterialPropertyBlock *)v7;
			//         }
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(m_AllocatedMaterialPropertyBlocks, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(269, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_129(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		internal void ReleaseAllTempAlloc()
		{
			// // Void ReleaseAllTempAlloc()
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::ReleaseAllTempAlloc(
			//         HGRenderGraphObjectPool *this,
			//         MethodInfo *method)
			// {
			//   HGRenderGraphObjectPool *v2; // rbx
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   List_1_System_Object_ *m_AllocatedMaterialPropertyBlocks; // rdx
			//   Object *buildingId; // xmm6_8
			//   Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *m_ArrayPool; // rcx
			//   __int64 v8; // rdx
			//   List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *m_AllocatedArrays; // rcx
			//   Object *current; // rdi
			//   HGRenderGraphObjectPool_SharedObjectPool_1_System_Object_ *sharedPool; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   _BYTE v17[32]; // [rsp+0h] [rbp-D8h] BYREF
			//   Il2CppException *ex; // [rsp+20h] [rbp-B8h]
			//   void *v19; // [rsp+28h] [rbp-B0h]
			//   List_1_T_Enumerator_System_Object_ v20; // [rsp+30h] [rbp-A8h] BYREF
			//   ValueTuple_2_Object_Int32_ v21; // [rsp+50h] [rbp-88h] BYREF
			//   RemoteFactoryUtil_FillBuildingCheckResultIterationContext_BuildingDataEntry v22; // [rsp+60h] [rbp-78h]
			//   List_1_T_Enumerator_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_BuildingDataEntry_ v23; // [rsp+80h] [rbp-58h] BYREF
			//   Il2CppExceptionWrapper *v24; // [rsp+A8h] [rbp-30h] BYREF
			//   Il2CppExceptionWrapper *v25; // [rsp+B0h] [rbp-28h] BYREF
			//   Stack_1_System_Object_ *v27; // [rsp+F0h] [rbp+18h] BYREF
			// 
			//   v2 = this;
			//   if ( !byte_18D91935B )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<System::Type,int>,System::Collections::Generic::Stack<System::Object>>::TryGetValue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<System::Object,System::ValueTuple<System::Type,int>>>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::MaterialPropertyBlock>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::MaterialPropertyBlock>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<System::Object,System::ValueTuple<System::Type,int>>>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<System::Object,System::ValueTuple<System::Type,int>>>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::MaterialPropertyBlock>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::ValueTuple<System::Object,System::ValueTuple<System::Type,int>>>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::MaterialPropertyBlock>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::ValueTuple<System::Object,System::ValueTuple<System::Type,int>>>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::MaterialPropertyBlock>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::SharedObjectPool<UnityEngine::MaterialPropertyBlock>::Release);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::SharedObjectPool<UnityEngine::MaterialPropertyBlock>::get_sharedPool);
			//     sub_18003C530(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::SharedObjectPool<UnityEngine::MaterialPropertyBlock>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Stack<System::Object>::Push);
			//     byte_18D91935B = 1;
			//   }
			//   v27 = 0LL;
			//   memset(&v20, 0, sizeof(v20));
			//   if ( IFix::WrappersManagerImpl::IsPatched(86, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(86, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v16, v15);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			//   }
			//   else
			//   {
			//     if ( !v2.fields.m_AllocatedArrays )
			//       sub_180B536AC(v4, v3);
			//     System::Collections::Generic::List<Beyond::UI::UIText_RichTextAnalyzer::RichTextParam>::GetEnumerator(
			//       (List_1_T_Enumerator_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ *)&v21,
			//       (List_1_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ *)v2.fields.m_AllocatedArrays,
			//       MethodInfo::System::Collections::Generic::List<System::ValueTuple<System::Object,System::ValueTuple<System::Type,int>>>::GetEnumerator);
			//     *(ValueTuple_2_Object_Int32_ *)&v23._list = v21;
			//     v23._current = v22;
			//     ex = 0LL;
			//     v19 = &v23;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::BuildingDataEntry>::MoveNext(
			//                 &v23,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::ValueTuple<System::Object,System::ValueTuple<System::Type,int>>>::MoveNext) )
			//       {
			//         buildingId = (Object *)v23._current.buildingId;
			//         v22.buildingId = *(String **)&v23._current.chapterLimitedCount;
			//         m_ArrayPool = (Dictionary_2_System_ValueTuple_2_Object_Int32_System_Object_ *)v2.fields.m_ArrayPool;
			//         if ( !m_ArrayPool )
			//           sub_1802DC2C8(0LL, m_AllocatedMaterialPropertyBlocks);
			//         v21 = *(ValueTuple_2_Object_Int32_ *)&v23._current.chapterBuildable;
			//         System::Collections::Generic::Dictionary<System::ValueTuple<System::Object,int>,System::Object>::TryGetValue(
			//           m_ArrayPool,
			//           &v21,
			//           (Object **)&v27,
			//           MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<System::Type,int>,System::Collections::Generic::Stack<System::Object>>::TryGetValue);
			//         if ( !v27 )
			//           sub_1802DC2C8(0LL, v8);
			//         System::Collections::Generic::Stack<System::Object>::Push(
			//           v27,
			//           buildingId,
			//           MethodInfo::System::Collections::Generic::Stack<System::Object>::Push);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v24 )
			//     {
			//       m_AllocatedMaterialPropertyBlocks = (List_1_System_Object_ *)v17;
			//       ex = v24.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v2 = this;
			//     }
			//     m_AllocatedArrays = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)v2.fields.m_AllocatedArrays;
			//     if ( !m_AllocatedArrays )
			//       goto LABEL_30;
			//     System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
			//       m_AllocatedArrays,
			//       MethodInfo::System::Collections::Generic::List<System::ValueTuple<System::Object,System::ValueTuple<System::Type,int>>>::Clear);
			//     m_AllocatedMaterialPropertyBlocks = (List_1_System_Object_ *)v2.fields.m_AllocatedMaterialPropertyBlocks;
			//     if ( !m_AllocatedMaterialPropertyBlocks )
			//       goto LABEL_30;
			//     System::Collections::Generic::List<System::Object>::GetEnumerator(
			//       (List_1_T_Enumerator_System_Object_ *)&v21,
			//       m_AllocatedMaterialPropertyBlocks,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::MaterialPropertyBlock>::GetEnumerator);
			//     *(ValueTuple_2_Object_Int32_ *)&v20._list = v21;
			//     v20._current = (Object *)v22.buildingId;
			//     ex = 0LL;
			//     v19 = &v20;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v20,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::MaterialPropertyBlock>::MoveNext) )
			//       {
			//         current = v20._current;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::SharedObjectPool<UnityEngine::MaterialPropertyBlock>[0]);
			//         sharedPool = HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::SharedObjectPool<System::Object>::get_sharedPool(MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::SharedObjectPool<UnityEngine::MaterialPropertyBlock>::get_sharedPool);
			//         if ( !sharedPool )
			//           sub_1802DC2C8(v13, v12);
			//         UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphObjectPool::SharedObjectPool<System::Object>::Release(
			//           (RenderGraphObjectPool_SharedObjectPool_1_System_Object_ *)sharedPool,
			//           current,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphObjectPool::SharedObjectPool<UnityEngine::MaterialPropertyBlock>::Release);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v25 )
			//     {
			//       m_AllocatedMaterialPropertyBlocks = (List_1_System_Object_ *)v17;
			//       ex = v25.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v2 = this;
			//     }
			//     m_AllocatedArrays = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)v2.fields.m_AllocatedMaterialPropertyBlocks;
			//     if ( !m_AllocatedArrays )
			// LABEL_30:
			//       sub_1802DC2C8(m_AllocatedArrays, m_AllocatedMaterialPropertyBlocks);
			//     sub_1823B99D0(
			//       m_AllocatedArrays,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::MaterialPropertyBlock>::Clear);
			//   }
			// }
			// 
		}

		internal T Get<T>() where T : new()
		{
			return null;
		}

		internal void Release<T>(T value) where T : new()
		{
		}

		private Dictionary<ValueTuple<Type, int>, Stack<object>> m_ArrayPool;

		private List<ValueTuple<object, ValueTuple<Type, int>>> m_AllocatedArrays;

		private List<MaterialPropertyBlock> m_AllocatedMaterialPropertyBlocks;

		private class SharedObjectPool<T> where T : new()
		{
			// (get) Token: 0x0600020B RID: 523 RVA: 0x000025D2 File Offset: 0x000007D2
			public static HGRenderGraphObjectPool.SharedObjectPool<T> sharedPool
			{
				get
				{
					return null;
				}
			}

			public SharedObjectPool()
			{
			}

			public T Get()
			{
				return null;
			}

			public void Release(T value)
			{
			}

			private Stack<T> m_Pool;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
			private static readonly Lazy<HGRenderGraphObjectPool.SharedObjectPool<T>> s_Instance;
		}
	}
}
