using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.HyperGryph.ECS;

namespace HG.Rendering.Runtime
{
	public class HGEntityRenderHelperECSManager
	{
		public HGEntityRenderHelperECSManager()
		{
		}

		public void Register(Entity rendererEntity, int unitConfigAssetInstanceId, Matrix4x4 matrix)
		{
			// // Void Register(Entity, Int32, Matrix4x4)
			// void HG::Rendering::Runtime::HGEntityRenderHelperECSManager::Register(
			//         HGEntityRenderHelperECSManager *this,
			//         Entity_1 rendererEntity,
			//         int32_t unitConfigAssetInstanceId,
			//         Matrix4x4 *matrix,
			//         MethodInfo *method)
			// {
			//   Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_HG_Rendering_Runtime_EntityRenderHelperECSContext_ *m_contextDict; // rsi
			//   __int128 v10; // xmm0
			//   __int128 v11; // xmm1
			//   __int128 v12; // xmm0
			//   __int128 v13; // xmm1
			//   OneofDescriptorProto *v14; // rdx
			//   FileDescriptor *v15; // r8
			//   MessageDescriptor *v16; // r9
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v20; // xmm1
			//   __int128 v21; // xmm0
			//   __int128 v22; // xmm1
			//   String__Array *v23; // [rsp+28h] [rbp-81h]
			//   String *v24; // [rsp+30h] [rbp-79h]
			//   _BYTE v25[80]; // [rsp+38h] [rbp-71h] BYREF
			//   OneofDescriptor v26; // [rsp+88h] [rbp-21h] BYREF
			//   __int128 v27; // [rsp+D8h] [rbp+2Fh]
			//   OneofDescriptor__Class *klass; // [rsp+E8h] [rbp+3Fh]
			// 
			//   if ( !byte_18D919DD9 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::set_Item);
			//     byte_18D919DD9 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1452, 0LL) )
			//   {
			//     m_contextDict = this.fields.m_contextDict;
			//     sub_1802F01E0(v25, 0LL, 88LL);
			//     v10 = *(_OWORD *)&matrix.m00;
			//     v26.klass = 0LL;
			//     v11 = *(_OWORD *)&matrix.m01;
			//     *(Entity_1 *)&v25[68] = rendererEntity;
			//     *(_OWORD *)&v25[4] = v10;
			//     *(_DWORD *)v25 = unitConfigAssetInstanceId;
			//     v12 = *(_OWORD *)&matrix.m02;
			//     *(_OWORD *)&v25[20] = v11;
			//     v13 = *(_OWORD *)&matrix.m03;
			//     *(_OWORD *)&v25[36] = v12;
			//     *(_OWORD *)&v25[52] = v13;
			//     sub_1800054D0(&v26, v14, v15, v16, v23, v24, *(MethodInfo **)v25);
			//     if ( m_contextDict )
			//     {
			//       v26.fields = *(OneofDescriptor__Fields *)v25;
			//       v27 = *(_OWORD *)&v25[64];
			//       klass = v26.klass;
			//       ((void (__fastcall *)(_QWORD, _QWORD, _QWORD, _QWORD))sub_18082BA08)(
			//         m_contextDict,
			//         rendererEntity,
			//         &v26.fields,
			//         MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::set_Item);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v18, v17);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1452, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   v20 = *(_OWORD *)&matrix.m01;
			//   *(_OWORD *)&v26.fields._._Index_k__BackingField = *(_OWORD *)&matrix.m00;
			//   v21 = *(_OWORD *)&matrix.m02;
			//   *(_OWORD *)&v26.fields._._File_k__BackingField = v20;
			//   v22 = *(_OWORD *)&matrix.m03;
			//   *(_OWORD *)&v26.fields.fields = v21;
			//   *(_OWORD *)&v26.fields._Proto_k__BackingField = v22;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_548(
			//     Patch,
			//     (Object *)this,
			//     rendererEntity,
			//     unitConfigAssetInstanceId,
			//     (Matrix4x4 *)&v26.fields,
			//     0LL);
			// }
			// 
		}

		public void UnRegister(Entity rendererEntity)
		{
			// // Void UnRegister(Entity)
			// void HG::Rendering::Runtime::HGEntityRenderHelperECSManager::UnRegister(
			//         HGEntityRenderHelperECSManager *this,
			//         Entity_1 rendererEntity,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_HG_Rendering_Runtime_EntityRenderHelperECSContext_ *m_contextDict; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   EntityRenderHelperECSContext value; // [rsp+20h] [rbp-68h] BYREF
			// 
			//   if ( !byte_18D919DDA )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::TryGetValue);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::IEntityRenderHelperECS);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::Remove);
			//     byte_18D919DDA = 1;
			//   }
			//   sub_1802F01E0(&value, 0LL, 88LL);
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1453, 0LL) )
			//   {
			//     m_contextDict = this.fields.m_contextDict;
			//     if ( m_contextDict )
			//     {
			//       if ( !System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::TryGetValue(
			//               m_contextDict,
			//               rendererEntity,
			//               &value,
			//               MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::TryGetValue) )
			//         return;
			//       m_contextDict = (Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_HG_Rendering_Runtime_EntityRenderHelperECSContext_ *)this.fields.m_activeHelpers;
			//       if ( m_contextDict )
			//       {
			//         System::Collections::Generic::List<System::Object>::Remove(
			//           (List_1_System_Object_ *)m_contextDict,
			//           (Object *)value.renderHelperInstance,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::Remove);
			//         if ( value.renderHelperInstance )
			//           sub_18005CC40(4LL, TypeInfo::HG::Rendering::Runtime::IEntityRenderHelperECS, value.renderHelperInstance);
			//         m_contextDict = this.fields.m_contextDict;
			//         if ( m_contextDict )
			//         {
			//           System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::Remove(
			//             m_contextDict,
			//             rendererEntity,
			//             MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::Remove);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(m_contextDict, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1453, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_549(Patch, (Object *)this, rendererEntity, 0LL);
			// }
			// 
		}

		public void Play(Entity rendererEntity, ref HGFactoryRendererBinderComponent rendererBinder, string vfxName)
		{
			// // Void Play(Entity, HGFactoryRendererBinderComponent ByRef, String)
			// void HG::Rendering::Runtime::HGEntityRenderHelperECSManager::Play(
			//         HGEntityRenderHelperECSManager *this,
			//         Entity_1 rendererEntity,
			//         HGFactoryRendererBinderComponent *rendererBinder,
			//         String *vfxName,
			//         MethodInfo *method)
			// {
			//   void *helperCreateDelegate; // rcx
			//   Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_HG_Rendering_Runtime_EntityRenderHelperECSContext_ *m_contextDict; // rdx
			//   String *v11; // rax
			//   __int64 (__fastcall *v12)(__int64, Entity_1, HGFactoryRendererBinderComponent *, _QWORD); // r10
			//   __int64 v13; // rcx
			//   OneofDescriptorProto *v14; // rdx
			//   FileDescriptor *v15; // r8
			//   MessageDescriptor *v16; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String *v18; // [rsp+30h] [rbp-D8h]
			//   EntityRenderHelperECSContext v19; // [rsp+38h] [rbp-D0h] BYREF
			//   __int128 v20; // [rsp+98h] [rbp-70h]
			//   __int128 v21; // [rsp+A8h] [rbp-60h]
			//   __int128 v22; // [rsp+B8h] [rbp-50h]
			//   __int128 v23; // [rsp+C8h] [rbp-40h]
			//   __int128 v24; // [rsp+D8h] [rbp-30h]
			//   OneofDescriptor item; // [rsp+E8h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D919DDB )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::set_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::IEntityRenderHelperECS);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::Add);
			//     byte_18D919DDB = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1454, 0LL) )
			//   {
			//     m_contextDict = this.fields.m_contextDict;
			//     if ( !m_contextDict )
			//       goto LABEL_16;
			//     System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::get_Item(
			//       &v19,
			//       m_contextDict,
			//       rendererEntity,
			//       MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::get_Item);
			//     v21 = *(_OWORD *)&v19.matrix.m30;
			//     v22 = *(_OWORD *)&v19.matrix.m31;
			//     v23 = *(_OWORD *)&v19.matrix.m32;
			//     item.klass = (OneofDescriptor__Class *)v19.renderHelperInstance;
			//     v20 = *(_OWORD *)&v19.unitConfigAssetInstanceId;
			//     v24 = *(_OWORD *)&v19.matrix.m33;
			//     if ( !v19.renderHelperInstance )
			//     {
			//       helperCreateDelegate = this.fields.helperCreateDelegate;
			//       if ( !helperCreateDelegate )
			//         goto LABEL_16;
			//       v11 = (String *)*((_QWORD *)helperCreateDelegate + 5);
			//       v12 = (__int64 (__fastcall *)(__int64, Entity_1, HGFactoryRendererBinderComponent *, _QWORD))*((_QWORD *)helperCreateDelegate + 3);
			//       v13 = *((_QWORD *)helperCreateDelegate + 8);
			//       v18 = v11;
			//       item.fields = (OneofDescriptor__Fields)v19.matrix;
			//       item.klass = (OneofDescriptor__Class *)((__int64 (__fastcall *)(_QWORD, _QWORD, _QWORD, _QWORD))v12)(
			//                                                v13,
			//                                                rendererEntity,
			//                                                rendererBinder,
			//                                                (unsigned int)_mm_cvtsi128_si32(*(__m128i *)&v19.unitConfigAssetInstanceId));
			//       sub_1800054D0(
			//         &item,
			//         v14,
			//         v15,
			//         v16,
			//         (String__Array *)&item.fields,
			//         v18,
			//         *(MethodInfo **)&v19.unitConfigAssetInstanceId);
			//       helperCreateDelegate = this.fields.m_contextDict;
			//       if ( !helperCreateDelegate )
			//         goto LABEL_16;
			//       *(_OWORD *)&v19.unitConfigAssetInstanceId = v20;
			//       *(_OWORD *)&v19.matrix.m30 = v21;
			//       *(_OWORD *)&v19.matrix.m31 = v22;
			//       *(_OWORD *)&v19.matrix.m32 = v23;
			//       *(_OWORD *)&v19.matrix.m33 = v24;
			//       v19.renderHelperInstance = (IEntityRenderHelperECS *)item.klass;
			//       ((void (__fastcall *)(_QWORD, _QWORD, _QWORD, _QWORD))sub_18082BA08)(
			//         helperCreateDelegate,
			//         rendererEntity,
			//         &v19,
			//         MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::set_Item);
			//     }
			//     if ( !item.klass )
			//       goto LABEL_16;
			//     if ( !(unsigned __int8)sub_1800518F0(3LL, TypeInfo::HG::Rendering::Runtime::IEntityRenderHelperECS) )
			//     {
			//       helperCreateDelegate = this.fields.m_activeHelpers;
			//       if ( !helperCreateDelegate )
			//         goto LABEL_16;
			//       sub_1822AD140((List_1_System_Object_ *)helperCreateDelegate, (Object *)item.klass);
			//     }
			//     if ( item.klass )
			//     {
			//       sub_18006F260(0LL, TypeInfo::HG::Rendering::Runtime::IEntityRenderHelperECS, item.klass, vfxName);
			//       return;
			//     }
			// LABEL_16:
			//     sub_180B536AC(helperCreateDelegate, m_contextDict);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1454, 0LL);
			//   if ( !Patch )
			//     goto LABEL_16;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_550(
			//     Patch,
			//     (Object *)this,
			//     rendererEntity,
			//     rendererBinder,
			//     (Object *)vfxName,
			//     0LL);
			// }
			// 
		}

		public void Stop(Entity rendererEntity, string vfxName)
		{
			// // Void Stop(Entity, String)
			// void HG::Rendering::Runtime::HGEntityRenderHelperECSManager::Stop(
			//         HGEntityRenderHelperECSManager *this,
			//         Entity_1 rendererEntity,
			//         String *vfxName,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_HG_Rendering_Runtime_EntityRenderHelperECSContext_ *m_contextDict; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   EntityRenderHelperECSContext value; // [rsp+30h] [rbp-68h] BYREF
			// 
			//   if ( !byte_18D919DDC )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::TryGetValue);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::IEntityRenderHelperECS);
			//     byte_18D919DDC = 1;
			//   }
			//   sub_1802F01E0(&value, 0LL, 88LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(1455, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1455, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_551(Patch, (Object *)this, rendererEntity, (Object *)vfxName, 0LL);
			//       return;
			//     }
			// LABEL_9:
			//     sub_180B536AC(m_contextDict, v7);
			//   }
			//   m_contextDict = this.fields.m_contextDict;
			//   if ( !m_contextDict )
			//     goto LABEL_9;
			//   if ( System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::TryGetValue(
			//          m_contextDict,
			//          rendererEntity,
			//          &value,
			//          MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::TryGetValue) )
			//   {
			//     if ( value.renderHelperInstance )
			//       sub_18006F260(2LL, TypeInfo::HG::Rendering::Runtime::IEntityRenderHelperECS, value.renderHelperInstance, vfxName);
			//   }
			// }
			// 
		}

		public void Tick(float deltaTime)
		{
			// // Void Tick(Single)
			// void HG::Rendering::Runtime::HGEntityRenderHelperECSManager::Tick(
			//         HGEntityRenderHelperECSManager *this,
			//         float deltaTime,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   int32_t i; // edi
			//   List_1_HG_Rendering_Runtime_IEntityRenderHelperECS_ *m_activeHelpers; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Object *Item; // rax
			//   __int64 v11; // r9
			// 
			//   if ( !byte_18D8EDCCA )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::IEntityRenderHelperECS);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::get_Item);
			//     byte_18D8EDCCA = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v3);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_13;
			//   if ( wrapperArray.max_length.size <= 1456 )
			//     goto LABEL_9;
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, wrapperArray);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//   if ( !v5 )
			// LABEL_13:
			//     sub_180B536AC(v5, wrapperArray);
			//   if ( LODWORD(v5._0.namespaze) <= 0x5B0 )
			//     sub_180070270(v5, wrapperArray);
			//   if ( v5[31]._0.namespaze )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1456, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27(
			//         (ILFixDynamicMethodWrapper_20 *)Patch,
			//         (Object *)this,
			//         deltaTime,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_13;
			//   }
			// LABEL_9:
			//   for ( i = 0; ; ++i )
			//   {
			//     m_activeHelpers = this.fields.m_activeHelpers;
			//     if ( !m_activeHelpers )
			//       goto LABEL_13;
			//     if ( i >= m_activeHelpers.fields._size )
			//       break;
			//     Item = System::Collections::Generic::List<System::Object>::get_Item(
			//              (List_1_System_Object_ *)this.fields.m_activeHelpers,
			//              i,
			//              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::get_Item);
			//     if ( !Item )
			//       goto LABEL_13;
			//     sub_1801E4BE8(1LL, TypeInfo::HG::Rendering::Runtime::IEntityRenderHelperECS, Item, v11);
			//   }
			//   HG::Rendering::Runtime::HGEntityRenderHelperECSManager::_RemoveInActive(this, 0LL);
			// }
			// 
		}

		private void _RemoveInActive()
		{
			// // Void _RemoveInActive()
			// void HG::Rendering::Runtime::HGEntityRenderHelperECSManager::_RemoveInActive(
			//         HGEntityRenderHelperECSManager *this,
			//         MethodInfo *method)
			// {
			//   List_1_System_Object_ *v3; // rcx
			//   __int64 v4; // rdx
			//   List_1_HG_Rendering_Runtime_IEntityRenderHelperECS_ *m_activeHelpers; // rbx
			//   int32_t v6; // ebp
			//   int32_t v7; // ebx
			//   List_1_HG_Rendering_Runtime_IEntityRenderHelperECS_ *v8; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   char v10; // di
			//   char v11; // r14
			//   List_1_System_Object_ *v12; // r14
			//   Object *Item; // rax
			//   Object *v14; // r12
			//   Object *v15; // rdi
			//   char v16; // al
			//   List_1_HG_Rendering_Runtime_IEntityRenderHelperECS_ *v17; // r8
			// 
			//   if ( !byte_18D8EDCCB )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::IEntityRenderHelperECS);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::RemoveRange);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::set_Item);
			//     byte_18D8EDCCB = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v4 = **(_QWORD **)&v3[4].fields._size;
			//   if ( !v4 )
			//     goto LABEL_14;
			//   if ( *(int *)(v4 + 24) > 1457 )
			//   {
			//     if ( !v3[5].fields._size )
			//     {
			//       il2cpp_runtime_class_init_0(v3, v4);
			//       v3 = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = **(List_1_System_Object_ ***)&v3[4].fields._size;
			//     if ( !v3 )
			//       goto LABEL_14;
			//     if ( v3.fields._size <= 0x5B1u )
			//       sub_180070270(v3, v4);
			//     if ( v3[292].monitor )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1457, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//         return;
			//       }
			//       goto LABEL_14;
			//     }
			//   }
			//   m_activeHelpers = this.fields.m_activeHelpers;
			//   v6 = 0;
			//   if ( !m_activeHelpers )
			//     goto LABEL_14;
			//   v7 = m_activeHelpers.fields._size - 1;
			//   if ( v7 > 0 )
			//   {
			//     do
			//     {
			//       v10 = 0;
			//       v11 = 0;
			//       while ( 1 )
			//       {
			//         v3 = (List_1_System_Object_ *)this.fields.m_activeHelpers;
			//         if ( !v3
			//           || !System::Collections::Generic::List<System::Object>::get_Item(
			//                 v3,
			//                 v6,
			//                 MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::get_Item) )
			//         {
			//           goto LABEL_14;
			//         }
			//         if ( !(unsigned __int8)sub_1800518F0(3LL, TypeInfo::HG::Rendering::Runtime::IEntityRenderHelperECS) )
			//           break;
			//         if ( ++v6 > v7 )
			//           goto LABEL_30;
			//       }
			//       v10 = 1;
			// LABEL_30:
			//       if ( v7 > v6 )
			//       {
			//         while ( 1 )
			//         {
			//           v3 = (List_1_System_Object_ *)this.fields.m_activeHelpers;
			//           if ( !v3
			//             || !System::Collections::Generic::List<System::Object>::get_Item(
			//                   v3,
			//                   v7,
			//                   MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::get_Item) )
			//           {
			//             goto LABEL_14;
			//           }
			//           if ( (unsigned __int8)sub_1800518F0(3LL, TypeInfo::HG::Rendering::Runtime::IEntityRenderHelperECS) )
			//             break;
			//           if ( --v7 <= v6 )
			//             goto LABEL_37;
			//         }
			//         v11 = 1;
			//       }
			// LABEL_37:
			//       if ( ((unsigned __int8)v11 & (unsigned __int8)v10) != 0 )
			//       {
			//         v12 = (List_1_System_Object_ *)this.fields.m_activeHelpers;
			//         v3 = v12;
			//         if ( !v12 )
			//           goto LABEL_14;
			//         Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                  v12,
			//                  v7,
			//                  MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::get_Item);
			//         v3 = (List_1_System_Object_ *)this.fields.m_activeHelpers;
			//         v14 = Item;
			//         if ( !v3 )
			//           goto LABEL_14;
			//         v15 = System::Collections::Generic::List<System::Object>::get_Item(
			//                 v3,
			//                 v6,
			//                 MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::get_Item);
			//         System::Collections::Generic::List<System::Object>::set_Item(
			//           v12,
			//           v6,
			//           v14,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::set_Item);
			//         System::Collections::Generic::List<System::Object>::set_Item(
			//           v12,
			//           v7,
			//           v15,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::set_Item);
			//         ++v6;
			//         --v7;
			//       }
			//     }
			//     while ( v6 < v7 );
			//   }
			//   v8 = this.fields.m_activeHelpers;
			//   if ( !v8 )
			//     goto LABEL_14;
			//   if ( v6 < v8.fields._size )
			//   {
			//     if ( System::Collections::Generic::List<System::Object>::get_Item(
			//            (List_1_System_Object_ *)this.fields.m_activeHelpers,
			//            v6,
			//            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::get_Item) )
			//     {
			//       v16 = sub_1800518F0(3LL, TypeInfo::HG::Rendering::Runtime::IEntityRenderHelperECS);
			//       v17 = this.fields.m_activeHelpers;
			//       v4 = (unsigned int)(v6 + 1);
			//       if ( !v16 )
			//         v4 = (unsigned int)v6;
			//       if ( v17 )
			//       {
			//         System::Collections::Generic::List<System::Object>::RemoveRange(
			//           (List_1_System_Object_ *)this.fields.m_activeHelpers,
			//           v4,
			//           v17.fields._size - v4,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::RemoveRange);
			//         return;
			//       }
			//     }
			// LABEL_14:
			//     sub_180B536AC(v3, v4);
			//   }
			// }
			// 
		}

		public void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::Runtime::HGEntityRenderHelperECSManager::Dispose(
			//         HGEntityRenderHelperECSManager *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *m_activeHelpers; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919DDD )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::Clear);
			//     byte_18D919DDD = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1458, 0LL) )
			//   {
			//     m_activeHelpers = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)this.fields.m_activeHelpers;
			//     if ( m_activeHelpers )
			//     {
			//       sub_1823B99D0(
			//         m_activeHelpers,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IEntityRenderHelperECS>::Clear);
			//       m_activeHelpers = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)this.fields.m_contextDict;
			//       if ( m_activeHelpers )
			//       {
			//         System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::Clear(
			//           m_activeHelpers,
			//           MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,HG::Rendering::Runtime::EntityRenderHelperECSContext>::Clear);
			//         return;
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(m_activeHelpers, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1458, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private Dictionary<Entity, EntityRenderHelperECSContext> m_contextDict;

		private List<IEntityRenderHelperECS> m_activeHelpers;

		public HGEntityRenderHelperECSManager.HelperCreateDelegate helperCreateDelegate;

		// (Invoke) Token: 0x0600078D RID: 1933
		public delegate IEntityRenderHelperECS HelperCreateDelegate(Entity rendererEntity, ref HGFactoryRendererBinderComponent rendererBinder, int unitConfigAssetInstanceId, Matrix4x4 matrix);
	}
}
