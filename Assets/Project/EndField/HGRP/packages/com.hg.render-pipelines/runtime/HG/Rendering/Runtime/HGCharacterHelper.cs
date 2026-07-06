using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[ExecuteAlways]
	[DisallowMultipleComponent]
	public class HGCharacterHelper : MonoBehaviour, IComparable
	{
		// (get) Token: 0x060016BF RID: 5823 RVA: 0x00002D58 File Offset: 0x00000F58
		public short id
		{
			get
			{
				// // Int16 get_id()
				// int16_t HG::Rendering::Runtime::HGCharacterHelper::get_id(HGCharacterHelper *this, MethodInfo *method)
				// {
				//   if ( !byte_18D8EDB90 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacters);
				//     byte_18D8EDB90 = 1;
				//   }
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCharacters, method);
				//   return HG::Rendering::Runtime::HGCharacters::QueryID(this, 0LL);
				// }
				// 
				return 0;
			}
		}

		public HGCharacterHelper()
		{
		}

		private void OnEnable()
		{
			// // Void OnEnable()
			// void HG::Rendering::Runtime::HGCharacterHelper::OnEnable(HGCharacterHelper *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v4; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_System_Collections_Generic_List_1_UnityEngine_Camera_ *v7; // rdi
			//   __int64 v8; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDB8D )
			//   {
			//     sub_18003C530(&TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Collections::Generic::List<UnityEngine::Camera>>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGCharacterHelper::OnBeginFrameRendering);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacters);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
			//     byte_18D8EDB8D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3493, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3493, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			// LABEL_10:
			//     sub_180B536AC(v6, v5);
			//   }
			//   HG::Rendering::Runtime::HGCharacterHelper::FindRenderers(this, 0LL, 0LL);
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCharacters, v3);
			//   HG::Rendering::Runtime::HGCharacters::EnqueueCharacter(this, 0LL);
			//   v4 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_180004920(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Collections::Generic::List<UnityEngine::Camera>>);
			//   v7 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_System_Collections_Generic_List_1_UnityEngine_Camera_ *)v4;
			//   if ( !v4 )
			//     goto LABEL_10;
			//   System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
			//     v4,
			//     (Object *)this,
			//     MethodInfo::HG::Rendering::Runtime::HGCharacterHelper::OnBeginFrameRendering,
			//     0LL);
			//   if ( !TypeInfo::UnityEngine::Rendering::RenderPipelineManager._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::RenderPipelineManager, v8);
			//   UnityEngine::Rendering::RenderPipelineManager::add_beginFrameRenderingNoAlloc(v7, 0LL);
			// }
			// 
		}

		public int CompareTo(object obj)
		{
			// // Int32 CompareTo(Object)
			// int32_t HG::Rendering::Runtime::HGCharacterHelper::CompareTo(HGCharacterHelper *this, Object *obj, MethodInfo *method)
			// {
			//   int32_t v5; // ebx
			//   Int32 *v6; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   HGCharacterHelper *v9; // rdi
			//   int id; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDB8E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacterHelper);
			//     byte_18D8EDB8E = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3503, 0LL) )
			//   {
			//     v5 = 1;
			//     if ( !obj || !sub_18003F5A0(obj, TypeInfo::HG::Rendering::Runtime::HGCharacterHelper) )
			//       return v5;
			//     v6 = (Int32 *)sub_18003F550(obj, TypeInfo::HG::Rendering::Runtime::HGCharacterHelper);
			//     v9 = (HGCharacterHelper *)v6;
			//     if ( v6 )
			//     {
			//       v5 = System::Int32::CompareTo(v6 + 12, this.fields.priority, 0LL);
			//       if ( !v5 )
			//       {
			//         id = HG::Rendering::Runtime::HGCharacterHelper::get_id(this, 0LL);
			//         return id - HG::Rendering::Runtime::HGCharacterHelper::get_id(v9, 0LL);
			//       }
			//       return v5;
			//     }
			// LABEL_10:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3503, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_99((ILFixDynamicMethodWrapper_17 *)Patch, (Object *)this, obj, 0LL);
			// }
			// 
			return 0;
		}

		public void SetPriority(int orderPriority)
		{
			// // Void SetPriority(Int32)
			// void HG::Rendering::Runtime::HGCharacterHelper::SetPriority(
			//         HGCharacterHelper *this,
			//         int32_t orderPriority,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( !byte_18D919762 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacters);
			//     byte_18D919762 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3504, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3504, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
			//       (ILFixDynamicMethodWrapper_26 *)Patch,
			//       (Object *)this,
			//       orderPriority,
			//       0LL);
			//   }
			//   else
			//   {
			//     this.fields.priority = orderPriority;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCharacters);
			//     HG::Rendering::Runtime::HGCharacters::SortCharacterHelpers(0LL);
			//   }
			// }
			// 
		}

		[ContextMenu("FindRenderers")]
		public void FindRenderers(LODGroup lodGroup = null)
		{
			// // Void FindRenderers(LODGroup)
			// void HG::Rendering::Runtime::HGCharacterHelper::FindRenderers(
			//         HGCharacterHelper *this,
			//         LODGroup *lodGroup,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v3; // r12
			//   String *v4; // r14
			//   String__Array *v5; // r15
			//   __int64 v8; // rdx
			//   OneofDescriptorProto *v9; // rdx
			//   FileDescriptor *v10; // r8
			//   MessageDescriptor *v11; // r9
			//   Object_1 *m_LodGroup; // rbx
			//   __int64 v13; // rdx
			//   GameObject *gameObject; // rax
			//   OneofDescriptorProto *v15; // rdx
			//   LODGroup *renderers; // rcx
			//   OneofDescriptorProto *v17; // rdx
			//   FileDescriptor *v18; // r8
			//   MessageDescriptor *v19; // r9
			//   LOD__Array *LODs; // rdi
			//   Object_1 *v21; // rbx
			//   GameObject *v22; // rax
			//   Object__Array *v23; // r15
			//   int32_t v24; // ebp
			//   Object *v25; // r14
			//   bool v26; // si
			//   Object_1 *v27; // rbx
			//   int32_t i; // ebx
			//   List_1_System_Tuple_2_UnityEngine_Renderer_Boolean_ *v29; // rbx
			//   __int64 v30; // rax
			//   FileDescriptor *v31; // r8
			//   __int64 v32; // r9
			//   Object *v33; // rdx
			//   int16_t id; // ax
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v35; // rax
			//   List_1_UnityEngine_Renderer_ *v36; // rbx
			//   OneofDescriptorProto *v37; // rdx
			//   FileDescriptor *v38; // r8
			//   MessageDescriptor *v39; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *v41; // [rsp+20h] [rbp-28h]
			//   String *v42; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v43; // [rsp+30h] [rbp-18h]
			// 
			//   if ( !byte_18D8EDB8F )
			//   {
			//     sub_18003C530(&MethodInfo::System::Array::IndexOf<UnityEngine::Renderer>);
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::GetComponent<UnityEngine::LODGroup>);
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::GetComponentsInChildren<UnityEngine::Renderer>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Tuple<UnityEngine::Renderer,bool>>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Renderer>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Renderer>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Tuple<UnityEngine::Renderer,bool>>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Renderer>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<UnityEngine::Renderer>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::ParticleSystemRenderer);
			//     sub_18003C530(&MethodInfo::System::Tuple<UnityEngine::Renderer,bool>::Tuple);
			//     sub_18003C530(&TypeInfo::System::Tuple<UnityEngine::Renderer,bool>);
			//     byte_18D8EDB8F = 1;
			//   }
			//   v43 = v3;
			//   v42 = v4;
			//   v41 = v5;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3494, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3494, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)this,
			//         (Object *)lodGroup,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_53;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//   if ( UnityEngine::Object::op_Inequality((Object_1 *)lodGroup, 0LL, 0LL) )
			//   {
			//     this.fields.m_LodGroup = lodGroup;
			//     sub_1800054D0((OneofDescriptor *)&this.fields.m_LodGroup, v9, v10, v11, v5, v4, v3);
			//   }
			//   m_LodGroup = (Object_1 *)this.fields.m_LodGroup;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v9);
			//   if ( UnityEngine::Object::op_Equality(m_LodGroup, 0LL, 0LL) )
			//   {
			//     gameObject = UnityEngine::Component::get_gameObject((Component *)this, 0LL);
			//     if ( !gameObject )
			//       goto LABEL_53;
			//     this.fields.m_LodGroup = (LODGroup *)UnityEngine::GameObject::GetComponent<System::Object>(
			//                                             gameObject,
			//                                             MethodInfo::UnityEngine::GameObject::GetComponent<UnityEngine::LODGroup>);
			//     sub_1800054D0((OneofDescriptor *)&this.fields.m_LodGroup, v17, v18, v19, v41, v42, v43);
			//   }
			//   LODs = 0LL;
			//   v21 = (Object_1 *)this.fields.m_LodGroup;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v13);
			//   if ( UnityEngine::Object::op_Implicit(v21, 0LL) )
			//   {
			//     renderers = this.fields.m_LodGroup;
			//     if ( !renderers )
			//       goto LABEL_53;
			//     LODs = UnityEngine::LODGroup::GetLODs(renderers, 1, 0LL);
			//   }
			//   renderers = (LODGroup *)this.fields.renderers;
			//   if ( !renderers )
			//     goto LABEL_53;
			//   sub_1823B99D0(
			//     renderers,
			//     MethodInfo::System::Collections::Generic::List<System::Tuple<UnityEngine::Renderer,bool>>::Clear);
			//   if ( this.fields.shadowProxyRenderers )
			//   {
			//     sub_1823B99D0(
			//       this.fields.shadowProxyRenderers,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::Renderer>::Clear);
			//   }
			//   else
			//   {
			//     v35 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<UnityEngine::Renderer>);
			//     v36 = (List_1_UnityEngine_Renderer_ *)v35;
			//     if ( !v35 )
			//       goto LABEL_53;
			//     System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//       v35,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::Renderer>::List);
			//     this.fields.shadowProxyRenderers = v36;
			//     sub_1800054D0((OneofDescriptor *)&this.fields.shadowProxyRenderers, v37, v38, v39, v41, v42, v43);
			//   }
			//   v22 = UnityEngine::Component::get_gameObject((Component *)this, 0LL);
			//   if ( !v22
			//     || (v23 = UnityEngine::GameObject::GetComponentsInChildren<System::Object>(
			//                 v22,
			//                 1,
			//                 MethodInfo::UnityEngine::GameObject::GetComponentsInChildren<UnityEngine::Renderer>),
			//         v24 = 0,
			//         !v23) )
			//   {
			// LABEL_53:
			//     sub_180B536AC(renderers, v15);
			//   }
			//   while ( v24 < v23.max_length.size )
			//   {
			//     if ( (unsigned int)v24 >= v23.max_length.size )
			// LABEL_54:
			//       sub_180070270(renderers, v15);
			//     v25 = v23.vector[v24];
			//     if ( !v25 || (struct ParticleSystemRenderer__Class *)v25.klass != TypeInfo::UnityEngine::ParticleSystemRenderer )
			//     {
			//       v26 = 0;
			//       v27 = (Object_1 *)this.fields.m_LodGroup;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v15);
			//       if ( UnityEngine::Object::op_Implicit(v27, 0LL) && LODs )
			//       {
			//         for ( i = 0; i < LODs.max_length.size; ++i )
			//         {
			//           if ( !v26 )
			//           {
			//             if ( (unsigned int)i >= LODs.max_length.size )
			//               goto LABEL_54;
			//             v26 = System::Array::IndexOf<System::Object>(
			//                     (Object__Array *)LODs.vector[i].renderers,
			//                     v25,
			//                     MethodInfo::System::Array::IndexOf<UnityEngine::Renderer>) >= 0;
			//           }
			//           if ( !TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings, v15);
			//           renderers = (LODGroup *)TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings.static_fields;
			//           if ( i >= SLODWORD(renderers.klass) )
			//           {
			//             if ( (unsigned int)i >= LODs.max_length.size )
			//               goto LABEL_54;
			//             if ( System::Array::IndexOf<System::Object>(
			//                    (Object__Array *)LODs.vector[i].renderers,
			//                    v25,
			//                    MethodInfo::System::Array::IndexOf<UnityEngine::Renderer>) >= 0 )
			//               goto LABEL_27;
			//           }
			//         }
			//       }
			//       if ( !v25 )
			//         goto LABEL_53;
			//       if ( UnityEngine::Renderer::get_shadowCastingMode((Renderer *)v25, 0LL) == ShadowCastingMode__Enum_ShadowsOnly
			//         || UnityEngine::Renderer::get_shadowCastingMode((Renderer *)v25, 0LL) == ShadowCastingMode__Enum_ShadowsOnlyTwoSided )
			//       {
			//         renderers = (LODGroup *)this.fields.shadowProxyRenderers;
			//         if ( !renderers )
			//           goto LABEL_53;
			//         v33 = v25;
			//       }
			//       else
			//       {
			//         v29 = this.fields.renderers;
			//         v30 = sub_180004920(TypeInfo::System::Tuple<UnityEngine::Renderer,bool>);
			//         if ( !v30 )
			//           goto LABEL_53;
			//         *(_QWORD *)(v30 + 16) = v25;
			//         sub_1800054D0((OneofDescriptor *)(v30 + 16), v15, v31, (MessageDescriptor *)v30, v41, v42, v43);
			//         *(_BYTE *)(v32 + 24) = v26;
			//         if ( !v29 )
			//           goto LABEL_53;
			//         v33 = (Object *)v32;
			//         renderers = (LODGroup *)v29;
			//       }
			//       sub_1822AD140((List_1_System_Object_ *)renderers, v33);
			//     }
			// LABEL_27:
			//     ++v24;
			//   }
			//   id = HG::Rendering::Runtime::HGCharacterHelper::get_id(this, 0LL);
			//   HG::Rendering::Runtime::HGCharacterHelper::UpdateShadowRenderingLayer(this, id, 0LL);
			// }
			// 
		}

		private void OnBeginFrameRendering(ScriptableRenderContext context, List<Camera> cameras)
		{
			// // Void OnBeginFrameRendering(ScriptableRenderContext, List`1[UnityEngine.Camera])
			// void HG::Rendering::Runtime::HGCharacterHelper::OnBeginFrameRendering(
			//         HGCharacterHelper *this,
			//         ScriptableRenderContext context,
			//         List_1_UnityEngine_Camera_ *cameras,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, context.m_Ptr);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 3500 )
			//   {
			//     if ( !v7._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v7, wrapperArray);
			//       v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7.static_fields.wrapperArray;
			//     if ( v7 )
			//     {
			//       if ( LODWORD(v7._0.namespaze) <= 0xDAC )
			//         sub_180070270(v7, wrapperArray);
			//       if ( !v7[74]._1.unity_user_data )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(3500, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_216(Patch, (Object *)this, context, (Object *)cameras, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v7, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( this.fields.enableSphereBasedBounds )
			//     HG::Rendering::Runtime::HGCharacterHelper::UpdateBoundsBySphere(this, 0LL);
			//   else
			//     HG::Rendering::Runtime::HGCharacterHelper::UpdateBounds(this, 0LL);
			// }
			// 
		}

		public void UpdateBounds()
		{
			// // Void UpdateBounds()
			// void HG::Rendering::Runtime::HGCharacterHelper::UpdateBounds(HGCharacterHelper *this, MethodInfo *method)
			// {
			//   char v3; // r14
			//   Transform *transform; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Vector3 *position; // rax
			//   int32_t v8; // r8d
			//   MethodInfo *v9; // r9
			//   Vector3 *v10; // rax
			//   __int64 v11; // rdx
			//   float z; // ecx
			//   __int64 v13; // xmm1_8
			//   MethodInfo *v14; // r9
			//   __m128i v15; // xmm6
			//   int32_t i; // esi
			//   List_1_System_Tuple_2_UnityEngine_Renderer_Boolean_ *renderers; // rax
			//   Object *Item; // rax
			//   Renderer *klass; // rbx
			//   Bounds *bounds; // rax
			//   __int64 v21; // xmm0_8
			//   float v22; // ebx
			//   __int64 v23; // xmm6_8
			//   MethodInfo *v24; // rdx
			//   Vector3 *one; // rax
			//   float boundSizeOffset; // xmm2_4
			//   __int64 v27; // xmm1_8
			//   MethodInfo *v28; // r9
			//   Vector3 *v29; // rax
			//   __int64 v30; // xmm3_8
			//   Vector3 *size; // rax
			//   __int64 v32; // xmm0_8
			//   MethodInfo *v33; // r9
			//   Vector3 *v34; // rax
			//   __int64 v35; // xmm3_8
			//   float v36; // eax
			//   Vector3 *v37; // rax
			//   __int64 v38; // xmm3_8
			//   float3 *xyz; // rax
			//   __int64 v40; // xmm0_8
			//   MethodInfo *v41; // r8
			//   float3 *v42; // rdx
			//   float3 *v43; // rcx
			//   float3 *v44; // r8
			//   float3 *v45; // r9
			//   float v46; // xmm7_4
			//   Vector3 *v47; // rax
			//   __int64 v48; // xmm1_8
			//   Vector3 *v49; // rax
			//   __int64 v50; // xmm0_8
			//   MethodInfo *v51; // r9
			//   Vector3 *v52; // rax
			//   __int64 v53; // xmm3_8
			//   float3 *v54; // rax
			//   __int64 v55; // xmm0_8
			//   MethodInfo *v56; // r8
			//   float3 *v57; // rax
			//   float v58; // xmm0_4
			//   __int64 v59; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   float4 value; // [rsp+28h] [rbp-E0h] BYREF
			//   Vector3 vector; // [rsp+38h] [rbp-D0h] BYREF
			//   float3 v63; // [rsp+48h] [rbp-C0h] BYREF
			//   Vector3 v64; // [rsp+58h] [rbp-B0h] BYREF
			//   Vector3 v65; // [rsp+68h] [rbp-A0h] BYREF
			//   Bounds v66; // [rsp+78h] [rbp-90h] BYREF
			//   Bounds v67; // [rsp+90h] [rbp-78h] BYREF
			//   Bounds v68; // [rsp+A8h] [rbp-60h] BYREF
			//   Vector3 v69; // [rsp+C8h] [rbp-40h] BYREF
			//   Vector3 v70; // [rsp+D8h] [rbp-30h] BYREF
			//   Vector3 v71[4]; // [rsp+E8h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D919763 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Tuple<UnityEngine::Renderer,bool>>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Tuple<UnityEngine::Renderer,bool>>::get_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::System::Tuple<UnityEngine::Renderer,bool>::get_Item1);
			//     byte_18D919763 = 1;
			//   }
			//   memset(&v67, 0, sizeof(v67));
			//   if ( IFix::WrappersManagerImpl::IsPatched(3502, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3502, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			// LABEL_24:
			//     sub_180B536AC(v6, v5);
			//   }
			//   if ( !this.fields.renderers )
			//     return;
			//   v3 = 0;
			//   transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//   if ( !transform )
			//     goto LABEL_24;
			//   position = UnityEngine::Transform::get_position((Vector3 *)&value, transform, 0LL);
			//   v10 = UnityEngine::Animator::GetVector(&vector, (Animator *)position, v8, v9);
			//   *(_QWORD *)&v65.x = *(_QWORD *)v11;
			//   z = v10.z;
			//   v13 = *(_QWORD *)&v10.x;
			//   LODWORD(v10) = *(_DWORD *)(v11 + 8);
			//   v64.z = z;
			//   *(_QWORD *)&v64.x = v13;
			//   LODWORD(v65.z) = (_DWORD)v10;
			//   UnityEngine::Bounds::Bounds(&v67, &v65, &v64, 0LL);
			//   v15 = *(__m128i *)&v67.m_Center.x;
			//   for ( i = 0; ; ++i )
			//   {
			//     renderers = this.fields.renderers;
			//     if ( !renderers )
			//       goto LABEL_24;
			//     if ( i >= renderers.fields._size )
			//       break;
			//     Item = System::Collections::Generic::List<System::Object>::get_Item(
			//              (List_1_System_Object_ *)this.fields.renderers,
			//              i,
			//              MethodInfo::System::Collections::Generic::List<System::Tuple<UnityEngine::Renderer,bool>>::get_Item);
			//     if ( !Item )
			//       goto LABEL_24;
			//     klass = (Renderer *)Item[1].klass;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( !UnityEngine::Object::op_Equality((Object_1 *)klass, 0LL, 0LL) )
			//     {
			//       if ( !klass )
			//         goto LABEL_24;
			//       if ( UnityEngine::Renderer::get_isVisible(klass, 0LL)
			//         && UnityEngine::Renderer::GetIsRealtimeShadowCaster(klass, 0LL) )
			//       {
			//         bounds = UnityEngine::Renderer::get_bounds(&v68, klass, 0LL);
			//         v21 = *(_QWORD *)&bounds.m_Extents.y;
			//         *(_OWORD *)&v66.m_Center.x = *(_OWORD *)&bounds.m_Center.x;
			//         *(_QWORD *)&v66.m_Extents.y = v21;
			//         v22 = bounds.m_Center.z;
			//         v23 = *(_QWORD *)&v66.m_Center.x;
			//         one = UnityEngine::Vector3::get_one(&v69, v24);
			//         boundSizeOffset = this.fields.boundSizeOffset;
			//         v27 = *(_QWORD *)&one.x;
			//         *(float *)&one = one.z;
			//         *(_QWORD *)&v65.x = v27;
			//         LODWORD(v65.z) = (_DWORD)one;
			//         v29 = UnityEngine::Vector3::op_Multiply(&v70, &v65, boundSizeOffset, v28);
			//         v30 = *(_QWORD *)&v29.x;
			//         *(float *)&v29 = v29.z;
			//         *(_QWORD *)&v64.x = v30;
			//         LODWORD(v64.z) = (_DWORD)v29;
			//         size = UnityEngine::Bounds::get_size(v71, &v66, 0LL);
			//         v32 = *(_QWORD *)&size.x;
			//         *(float *)&size = size.z;
			//         *(_QWORD *)&vector.x = v32;
			//         LODWORD(vector.z) = (_DWORD)size;
			//         v34 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v63, &vector, &v64, v33);
			//         v35 = *(_QWORD *)&v34.x;
			//         *(float *)&v34 = v34.z;
			//         *(_QWORD *)&value.x = v35;
			//         LODWORD(value.z) = (_DWORD)v34;
			//         UnityEngine::Bounds::set_size(&v66, (Vector3 *)&value, 0LL);
			//         *(_QWORD *)&v66.m_Center.x = v23;
			//         v66.m_Center.z = v22;
			//         if ( v3 )
			//         {
			//           v68 = v66;
			//           UnityEngine::Bounds::Encapsulate(&v67, &v68, 0LL);
			//           v15 = *(__m128i *)&v67.m_Center.x;
			//         }
			//         else
			//         {
			//           v15 = *(__m128i *)&v66.m_Center.x;
			//           v3 = 1;
			//           v67 = v66;
			//         }
			//       }
			//     }
			//   }
			//   v36 = this.fields.bounds.m_Center.z;
			//   *(_QWORD *)&value.x = *(_QWORD *)&this.fields.bounds.m_Center.x;
			//   LODWORD(vector.z) = _mm_cvtsi128_si32(_mm_srli_si128(v15, 8));
			//   value.z = v36;
			//   *(_QWORD *)&vector.x = v15.m128i_i64[0];
			//   v37 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v63, &vector, (Vector3 *)&value, v14);
			//   v38 = *(_QWORD *)&v37.x;
			//   *(float *)&v37 = v37.z;
			//   *(_QWORD *)&value.x = v38;
			//   LODWORD(value.z) = (_DWORD)v37;
			//   xyz = Unity::Mathematics::float4::get_xyz(&v63, &value, 0LL);
			//   v40 = *(_QWORD *)&xyz.x;
			//   value.z = xyz.z;
			//   vector.z = value.z;
			//   *(_QWORD *)&value.x = v40;
			//   *(_QWORD *)&vector.x = v40;
			//   Dest::Math::Vector3ex::Dot(&vector, (Vector3 *)&value, v41);
			//   v46 = sub_1802ECED0(v43, v42, v44, v45);
			//   v47 = UnityEngine::Bounds::get_size((Vector3 *)&v63, &this.fields.bounds, 0LL);
			//   v48 = *(_QWORD *)&v47.x;
			//   *(float *)&v47 = v47.z;
			//   *(_QWORD *)&value.x = v48;
			//   LODWORD(value.z) = (_DWORD)v47;
			//   v49 = UnityEngine::Bounds::get_size((Vector3 *)&v63, &v67, 0LL);
			//   v50 = *(_QWORD *)&v49.x;
			//   *(float *)&v49 = v49.z;
			//   *(_QWORD *)&vector.x = v50;
			//   LODWORD(vector.z) = (_DWORD)v49;
			//   v52 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v63, &vector, (Vector3 *)&value, v51);
			//   v53 = *(_QWORD *)&v52.x;
			//   *(float *)&v52 = v52.z;
			//   *(_QWORD *)&value.x = v53;
			//   LODWORD(value.z) = (_DWORD)v52;
			//   v54 = Unity::Mathematics::float4::get_xyz(&v63, &value, 0LL);
			//   v55 = *(_QWORD *)&v54.x;
			//   *(float *)&v54 = v54.z;
			//   *(_QWORD *)&value.x = v55;
			//   LODWORD(value.z) = (_DWORD)v54;
			//   v57 = Unity::Mathematics::math::abs(&v63, (float3 *)&value, v56);
			//   v58 = v57.z;
			//   *(_QWORD *)&value.x = *(_QWORD *)&v57.x;
			//   if ( value.x > 0.02 || value.y > 0.02 || v58 > 0.02 || v46 > 0.02 )
			//   {
			//     v59 = *(_QWORD *)&v67.m_Extents.y;
			//     *(__m128i *)&this.fields.bounds.m_Center.x = v15;
			//     *(_QWORD *)&this.fields.bounds.m_Extents.y = v59;
			//   }
			// }
			// 
		}

		public void UpdateBoundsBySphere()
		{
			// // Void UpdateBoundsBySphere()
			// void HG::Rendering::Runtime::HGCharacterHelper::UpdateBoundsBySphere(HGCharacterHelper *this, MethodInfo *method)
			// {
			//   MethodInfo *v2; // r9
			//   void *items; // rcx
			//   List_1_HG_Rendering_Runtime_HGCharacterHelper_HGCharacterShadowSphere_ *v5; // rdx
			//   List_1_HG_Rendering_Runtime_HGCharacterHelper_HGCharacterShadowSphere_ *boneSpheres; // rax
			//   __m128 v7; // xmm13
			//   unsigned int v8; // ebx
			//   __m128 v9; // xmm11
			//   __m128 v10; // xmm12
			//   int size; // r15d
			//   float v12; // xmm9_4
			//   __m128 v13; // xmm10
			//   float v14; // xmm8_4
			//   unsigned int v15; // edi
			//   __m128 v16; // xmm6
			//   void (__fastcall *v17)(unsigned __int64, Vector3 *, Vector3 *); // rax
			//   __m128 v18; // xmm5
			//   float v19; // xmm6_4
			//   __m128 x_low; // xmm0
			//   __m128 v21; // xmm3
			//   __m128 v22; // xmm1
			//   Vector3 *v23; // rax
			//   __int64 v24; // xmm3_8
			//   MethodInfo *v25; // r9
			//   Vector3 *v26; // rax
			//   __int64 v27; // xmm8_8
			//   float z; // r12d
			//   MethodInfo *v29; // r9
			//   Vector3 *v30; // rax
			//   MethodInfo *v31; // r9
			//   __int64 v32; // xmm9_8
			//   float v33; // r15d
			//   List_1_System_Tuple_2_UnityEngine_Renderer_Boolean_ *renderers; // rax
			//   HGCharacterHelper_HGCharacterShadowSphere__Array *v35; // rdi
			//   bool m_Item2; // r14
			//   char v37; // al
			//   unsigned __int8 (__fastcall *v38)(HGCharacterHelper_HGCharacterShadowSphere__Array *); // rax
			//   unsigned __int8 (__fastcall *v39)(HGCharacterHelper_HGCharacterShadowSphere__Array *); // rax
			//   void (__fastcall *v40)(HGCharacterHelper_HGCharacterShadowSphere__Array *, _BYTE *); // rax
			//   MethodInfo *v41; // r9
			//   float boundSizeOffset; // xmm2_4
			//   MethodInfo *v43; // r9
			//   Vector3 *v44; // rax
			//   __int64 v45; // r8
			//   __int64 v46; // xmm3_8
			//   MethodInfo *v47; // r9
			//   Vector3 *v48; // rax
			//   __int64 v49; // xmm3_8
			//   MethodInfo *v50; // r9
			//   Vector3 *v51; // rax
			//   __int64 v52; // xmm0_8
			//   __int64 v53; // xmm7_8
			//   float v54; // edi
			//   MethodInfo *v55; // r9
			//   MethodInfo *v56; // rax
			//   MethodInfo *v57; // r9
			//   __m128 v58; // xmm6
			//   Vector3 *v59; // rax
			//   float *v60; // r9
			//   float v61; // xmm4_4
			//   __m128 v62; // xmm5
			//   __m128 v63; // xmm0
			//   __m128 v64; // xmm1
			//   __m128 v65; // xmm3
			//   float v66; // xmm2_4
			//   Vector3 *v67; // rax
			//   __int64 v68; // xmm3_8
			//   MethodInfo *v69; // r9
			//   Vector3 *v70; // rax
			//   float v71; // ecx
			//   __m128 v72; // xmm5
			//   float v73; // xmm4_4
			//   float *v74; // r11
			//   __int64 v75; // xmm0_8
			//   MethodInfo *v76; // r9
			//   float *v77; // r9
			//   __int64 v78; // xmm0_8
			//   float *v79; // r10
			//   float v80; // ecx
			//   __int64 v81; // xmm0_8
			//   __int64 v82; // r9
			//   float *v83; // r10
			//   __m128 v84; // xmm6
			//   unsigned __int64 *v85; // r11
			//   float v86; // eax
			//   __int64 v87; // xmm0_8
			//   float v88; // eax
			//   Vector3 *v89; // rax
			//   MethodInfo *v90; // r9
			//   float *v91; // r11
			//   float v92; // xmm4_4
			//   __m128 v93; // xmm5
			//   __m128 v94; // xmm0
			//   __m128 v95; // xmm1
			//   __m128 y_low; // xmm3
			//   float v97; // xmm2_4
			//   Vector3 *v98; // rax
			//   __int64 v99; // xmm3_8
			//   MethodInfo *v100; // r9
			//   Vector3 *v101; // rax
			//   float v102; // xmm4_4
			//   __m128 v103; // xmm5
			//   MethodInfo *v104; // r9
			//   Vector3 *v105; // rax
			//   float v106; // xmm2_4
			//   float3 *v107; // rax
			//   __int64 v108; // xmm2_8
			//   MethodInfo *v109; // r8
			//   float3 *v110; // rdx
			//   float3 *v111; // rcx
			//   float3 *v112; // r8
			//   float3 *v113; // r9
			//   float v114; // xmm0_4
			//   float v115; // xmm6_4
			//   __m128 v116; // xmm3
			//   float v117; // eax
			//   MethodInfo *v118; // r9
			//   Vector3 *v119; // rax
			//   __m128 v120; // xmm0
			//   __m128 v121; // xmm5
			//   float v122; // xmm4_4
			//   MethodInfo *v123; // r9
			//   float3 *v124; // rax
			//   __int64 v125; // xmm2_8
			//   MethodInfo *v126; // r9
			//   uint3 *v127; // rax
			//   bool v128; // cf
			//   bool v129; // zf
			//   float v130; // xmm0_4
			//   __int64 v131; // xmm1_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v133; // rax
			//   __int64 v134; // rax
			//   __int64 v135; // rax
			//   __int64 v136; // rax
			//   Vector3 value; // [rsp+20h] [rbp-E0h] BYREF
			//   Vector3 v138; // [rsp+30h] [rbp-D0h] BYREF
			//   Vector3 v139; // [rsp+40h] [rbp-C0h] BYREF
			//   Vector3 vector; // [rsp+50h] [rbp-B0h] BYREF
			//   _BYTE v141[40]; // [rsp+60h] [rbp-A0h] BYREF
			//   _BYTE v142[24]; // [rsp+88h] [rbp-78h] BYREF
			//   Vector3 v143; // [rsp+A0h] [rbp-60h] BYREF
			//   Vector3 v144; // [rsp+B0h] [rbp-50h] BYREF
			//   Vector3 v145; // [rsp+C0h] [rbp-40h] BYREF
			//   Vector3 v146; // [rsp+D0h] [rbp-30h] BYREF
			//   Vector3 v147; // [rsp+E0h] [rbp-20h] BYREF
			//   Vector3 v148; // [rsp+F0h] [rbp-10h] BYREF
			//   Vector3 v149; // [rsp+100h] [rbp+0h] BYREF
			//   Vector3 v150; // [rsp+110h] [rbp+10h] BYREF
			//   Vector3 v151; // [rsp+120h] [rbp+20h] BYREF
			//   Vector3 v152; // [rsp+130h] [rbp+30h] BYREF
			//   Vector3 v153; // [rsp+140h] [rbp+40h] BYREF
			//   Vector3 v154; // [rsp+150h] [rbp+50h] BYREF
			//   Vector3 v155; // [rsp+160h] [rbp+60h] BYREF
			//   Vector3 v156; // [rsp+170h] [rbp+70h] BYREF
			//   Vector3 v157; // [rsp+180h] [rbp+80h] BYREF
			//   Vector3 v158; // [rsp+190h] [rbp+90h] BYREF
			//   Vector3 v159; // [rsp+1A0h] [rbp+A0h] BYREF
			//   Vector3 v160; // [rsp+1B0h] [rbp+B0h] BYREF
			//   Vector3 v161; // [rsp+1C0h] [rbp+C0h] BYREF
			//   Vector3 v162; // [rsp+1D0h] [rbp+D0h] BYREF
			//   Vector3 v163; // [rsp+1E0h] [rbp+E0h] BYREF
			//   Vector3 v164; // [rsp+1F0h] [rbp+F0h] BYREF
			//   Vector3 v165; // [rsp+200h] [rbp+100h] BYREF
			//   Vector3 v166; // [rsp+210h] [rbp+110h] BYREF
			//   Vector3 v167; // [rsp+220h] [rbp+120h] BYREF
			//   unsigned __int64 v168; // [rsp+230h] [rbp+130h]
			//   unsigned __int64 v169; // [rsp+240h] [rbp+140h]
			//   Il2CppMethodPointer methodPointer; // [rsp+250h] [rbp+150h]
			//   unsigned __int64 v171; // [rsp+260h] [rbp+160h]
			//   unsigned __int64 v172; // [rsp+270h] [rbp+170h]
			//   unsigned __int64 v173; // [rsp+280h] [rbp+180h]
			//   unsigned __int64 v174; // [rsp+290h] [rbp+190h]
			//   Vector3 v175; // [rsp+2A0h] [rbp+1A0h] BYREF
			//   Vector3 v176; // [rsp+2B0h] [rbp+1B0h] BYREF
			//   Vector3 v177; // [rsp+2C0h] [rbp+1C0h] BYREF
			//   Vector3 v178; // [rsp+2D0h] [rbp+1D0h] BYREF
			//   Vector3 v179; // [rsp+2E0h] [rbp+1E0h] BYREF
			//   Vector3 v180; // [rsp+2F0h] [rbp+1F0h] BYREF
			//   Vector3 v181; // [rsp+300h] [rbp+200h] BYREF
			//   Vector3 v182; // [rsp+310h] [rbp+210h] BYREF
			//   Vector3 v183; // [rsp+320h] [rbp+220h] BYREF
			//   Vector3 v184; // [rsp+330h] [rbp+230h] BYREF
			//   Vector3 v185; // [rsp+340h] [rbp+240h] BYREF
			//   Vector3 v186; // [rsp+350h] [rbp+250h] BYREF
			//   Vector3 v187; // [rsp+360h] [rbp+260h] BYREF
			//   Vector3 v188; // [rsp+370h] [rbp+270h] BYREF
			//   Vector3 v189; // [rsp+380h] [rbp+280h] BYREF
			// 
			//   if ( !byte_18D8EDB91 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Tuple<UnityEngine::Renderer,bool>>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper::HGCharacterShadowSphere>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Tuple<UnityEngine::Renderer,bool>>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper::HGCharacterShadowSphere>::get_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::System::Tuple<UnityEngine::Renderer,bool>::get_Item1);
			//     sub_18003C530(&MethodInfo::System::Tuple<UnityEngine::Renderer,bool>::get_Item2);
			//     byte_18D8EDB91 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v5 = (List_1_HG_Rendering_Runtime_HGCharacterHelper_HGCharacterShadowSphere_ *)**((_QWORD **)items + 23);
			//   if ( !v5 )
			//     goto LABEL_97;
			//   if ( v5.fields._size <= 3501 )
			//     goto LABEL_122;
			//   if ( !*((_DWORD *)items + 56) )
			//   {
			//     il2cpp_runtime_class_init_0(items, v5);
			//     items = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v5 = (List_1_HG_Rendering_Runtime_HGCharacterHelper_HGCharacterShadowSphere_ *)**((_QWORD **)items + 23);
			//   if ( !v5 )
			//     goto LABEL_97;
			//   if ( v5.fields._size <= 0xDADu )
			// LABEL_107:
			//     sub_180070270(items, v5);
			//   if ( !v5[701].klass )
			//   {
			// LABEL_122:
			//     if ( !this.fields.renderers )
			//       return;
			//     if ( !this.fields.boneSpheres )
			//       return;
			//     boneSpheres = this.fields.boneSpheres;
			//     if ( !boneSpheres.fields._size )
			//       return;
			//     v7 = (__m128)0x7F800000u;
			//     v8 = 0;
			//     v9 = (__m128)0xFF800000;
			//     v10 = (__m128)0x7F800000u;
			//     size = boneSpheres.fields._size;
			//     v12 = INFINITY;
			//     v13 = (__m128)0xFF800000;
			//     v14 = -INFINITY;
			//     v15 = 0;
			//     if ( size <= 0 )
			//     {
			// LABEL_43:
			//       memset(&v141[16], 0, 24);
			//       v139.z = v12;
			//       *(_QWORD *)&v139.x = _mm_unpacklo_ps(v7, v10).m128_u64[0];
			//       v138.z = v14;
			//       *(_QWORD *)&v138.x = _mm_unpacklo_ps(v9, v13).m128_u64[0];
			//       v23 = UnityEngine::Vector3::op_Subtraction(&v143, &v138, &v139, v2);
			//       v24 = *(_QWORD *)&v23.x;
			//       *(float *)&v23 = v23.z;
			//       *(_QWORD *)&v139.x = v24;
			//       LODWORD(v139.z) = (_DWORD)v23;
			//       v26 = UnityEngine::Vector3::op_Multiply(&v143, &v139, 0.5, v25);
			//       v27 = *(_QWORD *)&v26.x;
			//       z = v26.z;
			//       *(_QWORD *)&v141[28] = v27;
			//       *(float *)&v141[36] = z;
			//       v138.z = v12;
			//       *(_QWORD *)&v138.x = _mm_unpacklo_ps(v7, v10).m128_u64[0];
			//       *(_QWORD *)&v139.x = v27;
			//       v139.z = z;
			//       v30 = UnityEngine::Vector3::op_Addition(&v177, &v138, &v139, v29);
			//       v32 = *(_QWORD *)&v30.x;
			//       v33 = v30.z;
			//       *(_QWORD *)&v141[16] = *(_QWORD *)&v30.x;
			//       *(float *)&v141[24] = v33;
			//       while ( 1 )
			//       {
			//         renderers = this.fields.renderers;
			//         if ( !renderers )
			//           goto LABEL_97;
			//         if ( (signed int)v8 >= renderers.fields._size )
			//           break;
			//         if ( v8 >= renderers.fields._size )
			//           goto LABEL_119;
			//         items = renderers.fields._items;
			//         if ( !items )
			//           goto LABEL_97;
			//         if ( v8 >= *((_DWORD *)items + 6) )
			//           goto LABEL_107;
			//         v5 = (List_1_HG_Rendering_Runtime_HGCharacterHelper_HGCharacterShadowSphere_ *)*((_QWORD *)items + (int)v8 + 4);
			//         if ( !v5 )
			//           goto LABEL_97;
			//         v35 = v5.fields._items;
			//         m_Item2 = this.fields.renderers.fields._items.vector[v8].fields.m_Item2;
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
			//         if ( !byte_18D8F4EFA )
			//         {
			//           sub_18003C530(&TypeInfo::UnityEngine::Object);
			//           byte_18D8F4EFA = 1;
			//         }
			//         items = TypeInfo::UnityEngine::Object;
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
			//         if ( !byte_18D8F4EAF )
			//         {
			//           sub_18003C530(&TypeInfo::UnityEngine::Object);
			//           byte_18D8F4EAF = 1;
			//         }
			//         if ( !v35 )
			//           goto LABEL_65;
			//         items = TypeInfo::UnityEngine::Object;
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
			//         if ( v35.bounds )
			//           v37 = 0;
			//         else
			// LABEL_65:
			//           v37 = 1;
			//         if ( !(m_Item2 | (unsigned __int8)v37) )
			//         {
			//           if ( !v35 )
			//             goto LABEL_97;
			//           v38 = (unsigned __int8 (__fastcall *)(HGCharacterHelper_HGCharacterShadowSphere__Array *))qword_18D8F45E0;
			//           if ( !qword_18D8F45E0 )
			//           {
			//             v38 = (unsigned __int8 (__fastcall *)(HGCharacterHelper_HGCharacterShadowSphere__Array *))il2cpp_resolve_icall_0("UnityEngine.Renderer::get_isVisible()");
			//             if ( !v38 )
			//             {
			//               v134 = sub_1802DBBE8("UnityEngine.Renderer::get_isVisible()");
			//               sub_18000F750(v134, 0LL);
			//             }
			//             qword_18D8F45E0 = (__int64)v38;
			//           }
			//           if ( v38(v35) )
			//           {
			//             v39 = (unsigned __int8 (__fastcall *)(HGCharacterHelper_HGCharacterShadowSphere__Array *))qword_18D8F45F8;
			//             if ( !qword_18D8F45F8 )
			//             {
			//               v39 = (unsigned __int8 (__fastcall *)(HGCharacterHelper_HGCharacterShadowSphere__Array *))il2cpp_resolve_icall_0("UnityEngine.Renderer::GetIsRealtimeShadowCaster()");
			//               if ( !v39 )
			//               {
			//                 v135 = sub_1802DBBE8("UnityEngine.Renderer::GetIsRealtimeShadowCaster()");
			//                 sub_18000F750(v135, 0LL);
			//               }
			//               qword_18D8F45F8 = (__int64)v39;
			//             }
			//             if ( v39(v35) )
			//             {
			//               v40 = (void (__fastcall *)(HGCharacterHelper_HGCharacterShadowSphere__Array *, _BYTE *))qword_18D8F4660;
			//               memset(v142, 0, sizeof(v142));
			//               if ( !qword_18D8F4660 )
			//               {
			//                 v40 = (void (__fastcall *)(HGCharacterHelper_HGCharacterShadowSphere__Array *, _BYTE *))il2cpp_resolve_icall_0("UnityEngine.Renderer::get_bounds_Injected(UnityEngine.Bounds&)");
			//                 if ( !v40 )
			//                 {
			//                   v136 = sub_1802DBBE8("UnityEngine.Renderer::get_bounds_Injected(UnityEngine.Bounds&)");
			//                   sub_18000F750(v136, 0LL);
			//                 }
			//                 qword_18D8F4660 = (__int64)v40;
			//               }
			//               v40(v35, v142);
			//               v139 = *(Vector3 *)&v142[12];
			//               UnityEngine::Vector3::op_Multiply(&v186, &v139, 2.0, v41);
			//               boundSizeOffset = this.fields.boundSizeOffset;
			//               v138.z = 1.0;
			//               *(_QWORD *)&v138.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
			//               v44 = UnityEngine::Vector3::op_Multiply(&v187, &v138, boundSizeOffset, v43);
			//               *(_QWORD *)&v145.x = *(_QWORD *)v45;
			//               v46 = *(_QWORD *)&v44.x;
			//               v144.z = v44.z;
			//               LODWORD(v44) = *(_DWORD *)(v45 + 8);
			//               *(_QWORD *)&v144.x = v46;
			//               LODWORD(v145.z) = (_DWORD)v44;
			//               v48 = UnityEngine::Vector3::op_Subtraction(&v188, &v145, &v144, v47);
			//               v49 = *(_QWORD *)&v48.x;
			//               *(float *)&v48 = v48.z;
			//               *(_QWORD *)&v146.x = v49;
			//               LODWORD(v146.z) = (_DWORD)v48;
			//               v51 = UnityEngine::Vector3::op_Multiply(&v175, &v146, 0.5, v50);
			//               v52 = *(_QWORD *)&v51.x;
			//               v53 = *(_QWORD *)v142;
			//               v147.z = v51.z;
			//               *(_QWORD *)&v147.x = v52;
			//               *(_QWORD *)&v148.x = *(_QWORD *)v142;
			//               v54 = COERCE_FLOAT(_mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)v142, 8)));
			//               v148.z = v54;
			//               v56 = (MethodInfo *)UnityEngine::Vector3::op_Subtraction(&v176, &v148, &v147, v55);
			//               *(_QWORD *)&v149.x = v27;
			//               v149.z = z;
			//               *(_QWORD *)&v150.x = v32;
			//               v150.z = v33;
			//               v58 = (__m128)*(unsigned __int64 *)&UnityEngine::Vector3::op_Subtraction(&v183, &v150, &v149, v56).x;
			//               methodPointer = v57.methodPointer;
			//               v171 = v58.m128_u64[0];
			//               if ( *(float *)&methodPointer <= v58.m128_f32[0] )
			//                 v58 = (__m128)(unsigned __int64)methodPointer;
			//               *(_QWORD *)&v151.x = v27;
			//               v151.z = z;
			//               *(_QWORD *)&v152.x = v32;
			//               v152.z = v33;
			//               v59 = UnityEngine::Vector3::op_Addition(&v178, &v152, &v151, v57);
			//               v63 = (__m128)*(unsigned __int64 *)v60;
			//               v172 = *(_QWORD *)&v59.x;
			//               v64 = (__m128)v172;
			//               v173 = v63.m128_u64[0];
			//               if ( *(float *)&v172 <= v63.m128_f32[0] )
			//                 v64 = v63;
			//               v65 = (__m128)HIDWORD(v172);
			//               if ( *((float *)&v172 + 1) <= *((float *)&v173 + 1) )
			//                 v65 = (__m128)HIDWORD(v173);
			//               v66 = v59.z;
			//               if ( v66 <= v60[2] )
			//                 v66 = v60[2];
			//               *(_QWORD *)&v153.x = _mm_unpacklo_ps(v58, v62).m128_u64[0];
			//               v153.z = v61;
			//               v154.z = v66;
			//               *(_QWORD *)&v154.x = _mm_unpacklo_ps(v64, v65).m128_u64[0];
			//               v67 = UnityEngine::Vector3::op_Subtraction(&v179, &v154, &v153, (MethodInfo *)v60);
			//               v68 = *(_QWORD *)&v67.x;
			//               *(float *)&v67 = v67.z;
			//               *(_QWORD *)&v155.x = v68;
			//               LODWORD(v155.z) = (_DWORD)v67;
			//               v70 = UnityEngine::Vector3::op_Multiply(&v180, &v155, 0.5, v69);
			//               v71 = v70.z;
			//               *(_QWORD *)&v156.x = *(_QWORD *)&v70.x;
			//               v156.z = v71;
			//               *(_QWORD *)&v157.x = _mm_unpacklo_ps(v58, v72).m128_u64[0];
			//               v157.z = v73;
			//               UnityEngine::Vector3::op_Addition(&v181, &v157, &v156, (MethodInfo *)v70);
			//               v75 = *(_QWORD *)v74;
			//               v158.z = v74[2];
			//               *(_QWORD *)&v158.x = v75;
			//               *(_QWORD *)&v159.x = v53;
			//               v159.z = v54;
			//               UnityEngine::Vector3::op_Addition(&v182, &v159, &v158, v76);
			//               v78 = *(_QWORD *)v77;
			//               v160.z = v77[2];
			//               v80 = v79[2];
			//               *(_QWORD *)&v160.x = v78;
			//               v81 = *(_QWORD *)v79;
			//               v161.z = v80;
			//               *(_QWORD *)&v161.x = v81;
			//               v84 = (__m128)*(unsigned __int64 *)&UnityEngine::Vector3::op_Subtraction(
			//                                                     &v189,
			//                                                     &v161,
			//                                                     &v160,
			//                                                     (MethodInfo *)v77).x;
			//               v174 = *v85;
			//               v168 = v84.m128_u64[0];
			//               if ( *(float *)&v174 <= v84.m128_f32[0] )
			//                 v84 = (__m128)v174;
			//               v86 = *(float *)(v82 + 8);
			//               *(_QWORD *)&v162.x = *(_QWORD *)v82;
			//               v87 = *(_QWORD *)v83;
			//               v162.z = v86;
			//               v88 = v83[2];
			//               *(_QWORD *)&v163.x = v87;
			//               v163.z = v88;
			//               v89 = UnityEngine::Vector3::op_Addition(&v184, &v163, &v162, (MethodInfo *)v82);
			//               v94 = (__m128)*(unsigned __int64 *)v91;
			//               v169 = *(_QWORD *)&v89.x;
			//               v95 = (__m128)v169;
			//               *(_QWORD *)&v143.x = v94.m128_u64[0];
			//               if ( *(float *)&v169 <= v94.m128_f32[0] )
			//                 v95 = v94;
			//               y_low = (__m128)HIDWORD(v169);
			//               if ( *((float *)&v169 + 1) <= v143.y )
			//                 y_low = (__m128)LODWORD(v143.y);
			//               v97 = v89.z;
			//               if ( v97 <= v91[2] )
			//                 v97 = v91[2];
			//               *(_QWORD *)&v164.x = _mm_unpacklo_ps(v84, v93).m128_u64[0];
			//               v164.z = v92;
			//               v165.z = v97;
			//               *(_QWORD *)&v165.x = _mm_unpacklo_ps(v95, y_low).m128_u64[0];
			//               v98 = UnityEngine::Vector3::op_Subtraction(&v185, &v165, &v164, v90);
			//               v99 = *(_QWORD *)&v98.x;
			//               *(float *)&v98 = v98.z;
			//               *(_QWORD *)&v166.x = v99;
			//               LODWORD(v166.z) = (_DWORD)v98;
			//               v101 = UnityEngine::Vector3::op_Multiply(&v167, &v166, 0.5, v100);
			//               v27 = *(_QWORD *)&v101.x;
			//               z = v101.z;
			//               *(_QWORD *)&v141[28] = v27;
			//               *(float *)&v141[36] = z;
			//               value.z = v102;
			//               *(_QWORD *)&value.x = _mm_unpacklo_ps(v84, v103).m128_u64[0];
			//               *(_QWORD *)&vector.x = v27;
			//               vector.z = z;
			//               v105 = UnityEngine::Vector3::op_Addition((Vector3 *)v141, &value, &vector, v104);
			//               v32 = *(_QWORD *)&v105.x;
			//               v33 = v105.z;
			//               *(_QWORD *)&v141[16] = *(_QWORD *)&v105.x;
			//               *(float *)&v141[24] = v33;
			//             }
			//           }
			//         }
			//         ++v8;
			//       }
			//       v106 = this.fields.bounds.m_Center.z;
			//       *(_QWORD *)v141 = *(_QWORD *)&this.fields.bounds.m_Center.x;
			//       *(_QWORD *)&value.x = _mm_unpacklo_ps(
			//                               (__m128)*(unsigned __int64 *)v141,
			//                               _mm_shuffle_ps((__m128)*(unsigned __int64 *)v141, (__m128)*(unsigned __int64 *)v141, 85)).m128_u64[0];
			//       *(_QWORD *)&vector.x = _mm_unpacklo_ps((__m128)*(unsigned int *)&v141[16], (__m128)*(unsigned int *)&v141[20]).m128_u64[0];
			//       value.z = v106;
			//       vector.z = v33;
			//       v107 = Unity::Mathematics::float3::op_Subtraction((float3 *)v141, (float3 *)&vector, (float3 *)&value, v31);
			//       v108 = *(_QWORD *)&v107.x;
			//       value.z = v107.z;
			//       vector.z = value.z;
			//       *(_QWORD *)&value.x = v108;
			//       *(_QWORD *)&vector.x = v108;
			//       v114 = Dest::Math::Vector3ex::Dot(&vector, &value, v109);
			//       if ( v114 < 0.0 )
			//         v115 = sub_1802ECED0(v111, v110, v112, v113);
			//       else
			//         v115 = fsqrt(v114);
			//       *(_QWORD *)&value.x = v27;
			//       value.z = z;
			//       v116 = (__m128)*(unsigned __int64 *)&UnityEngine::Vector3::op_Multiply(
			//                                              (Vector3 *)v141,
			//                                              &value,
			//                                              2.0,
			//                                              (MethodInfo *)v113).x;
			//       v117 = this.fields.bounds.m_Extents.z;
			//       *(_QWORD *)&value.x = *(_QWORD *)&this.fields.bounds.m_Extents.x;
			//       value.z = v117;
			//       v119 = UnityEngine::Vector3::op_Multiply((Vector3 *)v141, &value, 2.0, v118);
			//       v120 = (__m128)*(unsigned __int64 *)&v119.x;
			//       value.z = v119.z;
			//       *(_QWORD *)&value.x = _mm_unpacklo_ps(v120, _mm_shuffle_ps(v120, v120, 85)).m128_u64[0];
			//       *(_QWORD *)&vector.x = _mm_unpacklo_ps(v121, _mm_shuffle_ps(v116, v116, 85)).m128_u64[0];
			//       vector.z = v122;
			//       v124 = Unity::Mathematics::float3::op_Subtraction((float3 *)v141, (float3 *)&vector, (float3 *)&value, v123);
			//       v125 = *(_QWORD *)&v124.x;
			//       *(float *)&v124 = v124.z;
			//       *(_QWORD *)&value.x = v125;
			//       LODWORD(value.z) = (_DWORD)v124;
			//       v127 = Unity::Mathematics::uint3::op_BitwiseAnd((uint3 *)v141, (uint3 *)&value, 0x7FFFFFFFu, v126);
			//       v120.m128_i32[0] = v127.z;
			//       v128 = v120.m128_f32[0] < 0.02;
			//       v129 = v120.m128_f32[0] == 0.02;
			//       v130 = _mm_shuffle_ps((__m128)*(unsigned __int64 *)&v127.x, (__m128)*(unsigned __int64 *)&v127.x, 85).m128_f32[0];
			//       if ( COERCE_FLOAT(*(_QWORD *)&v127.x) > 0.02 || v130 > 0.02 || !v128 && !v129 || v115 > 0.02 )
			//       {
			//         v131 = *(_QWORD *)&v141[32];
			//         *(_OWORD *)&this.fields.bounds.m_Center.x = *(_OWORD *)&v141[16];
			//         *(_QWORD *)&this.fields.bounds.m_Extents.y = v131;
			//       }
			//       return;
			//     }
			//     while ( 1 )
			//     {
			//       v5 = this.fields.boneSpheres;
			//       if ( !v5 )
			//         break;
			//       if ( v15 >= v5.fields._size )
			// LABEL_119:
			//         System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//       v5 = (List_1_HG_Rendering_Runtime_HGCharacterHelper_HGCharacterShadowSphere_ *)v5.fields._items;
			//       if ( !v5 )
			//         break;
			//       if ( v15 >= v5.fields._size )
			//         goto LABEL_107;
			//       v16 = *(__m128 *)(&v5.fields._syncRoot + 3 * (int)v15);
			//       *(_QWORD *)&v142[16] = *((_QWORD *)&v5[1].monitor + 3 * (int)v15);
			//       *(__m128 *)v142 = v16;
			//       *(_QWORD *)&v141[32] = *(_QWORD *)&v142[16];
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
			//       if ( !byte_18D8F4EFA )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EFA = 1;
			//       }
			//       items = TypeInfo::UnityEngine::Object;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
			//       if ( !byte_18D8F4EAF )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EAF = 1;
			//       }
			//       if ( v16.m128_u64[0] )
			//       {
			//         items = TypeInfo::UnityEngine::Object;
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
			//         if ( *(_QWORD *)(v16.m128_u64[0] + 16) )
			//         {
			//           v139 = *(Vector3 *)&v142[12];
			//           *(_QWORD *)&v138.x = 0LL;
			//           v138.z = 0.0;
			//           v17 = (void (__fastcall *)(unsigned __int64, Vector3 *, Vector3 *))qword_18D8F5370;
			//           if ( !qword_18D8F5370 )
			//           {
			//             v17 = (void (__fastcall *)(unsigned __int64, Vector3 *, Vector3 *))il2cpp_resolve_icall_0(
			//                                                                                  "UnityEngine.Transform::TransformPoint_I"
			//                                                                                  "njected(UnityEngine.Vector3&,UnityEngine.Vector3&)");
			//             if ( !v17 )
			//             {
			//               v133 = sub_1802DBBE8("UnityEngine.Transform::TransformPoint_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&)");
			//               sub_18000F750(v133, 0LL);
			//             }
			//             qword_18D8F5370 = (__int64)v17;
			//           }
			//           v17(v16.m128_u64[0], &v139, &v138);
			//           x_low = (__m128)LODWORD(v138.x);
			//           v22 = (__m128)LODWORD(v138.y);
			//           v18 = (__m128)LODWORD(v138.x);
			//           v21 = (__m128)LODWORD(v138.y);
			//           v19 = _mm_shuffle_ps(v16, v16, 170).m128_f32[0];
			//           x_low.m128_f32[0] = v138.x + v19;
			//           v21.m128_f32[0] = v138.y - v19;
			//           v22.m128_f32[0] = v138.y + v19;
			//           if ( v7.m128_f32[0] > (float)(v138.x - v19) )
			//           {
			//             v18.m128_f32[0] = v138.x - v19;
			//             v7 = v18;
			//           }
			//           if ( x_low.m128_f32[0] > v9.m128_f32[0] )
			//             v9 = x_low;
			//           if ( v10.m128_f32[0] > v21.m128_f32[0] )
			//             v10 = v21;
			//           if ( v22.m128_f32[0] > v13.m128_f32[0] )
			//             v13 = v22;
			//           if ( v12 > (float)(v138.z - v19) )
			//             v12 = v138.z - v19;
			//           if ( (float)(v138.z + v19) > v14 )
			//             v14 = v138.z + v19;
			//         }
			//       }
			//       if ( (int)++v15 >= size )
			//         goto LABEL_43;
			//     }
			// LABEL_97:
			//     sub_180B536AC(items, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3501, 0LL);
			//   if ( !Patch )
			//     goto LABEL_97;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public void UpdateShadowRenderingLayer(short index)
		{
			// // Void UpdateShadowRenderingLayer(Int16)
			// void HG::Rendering::Runtime::HGCharacterHelper::UpdateShadowRenderingLayer(
			//         HGCharacterHelper *this,
			//         int16_t index,
			//         MethodInfo *method)
			// {
			//   int v4; // r14d
			//   __int64 v5; // rdx
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   int32_t v8; // ebp
			//   int32_t i; // edi
			//   List_1_System_Tuple_2_UnityEngine_Renderer_Boolean_ *renderers; // rax
			//   Object *Item; // rax
			//   Renderer *klass; // rbx
			//   uint32_t ShadowLayer; // eax
			//   uint16_t v14; // dx
			//   List_1_UnityEngine_Renderer_ *shadowProxyRenderers; // rax
			//   __int64 v16; // rdx
			//   Object *v17; // rbx
			//   List_1_System_Tuple_2_UnityEngine_Renderer_Boolean_ *v18; // rax
			//   Object *v19; // rax
			//   Renderer *v20; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v4 = index;
			//   if ( !byte_18D8EDB92 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacters);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Tuple<UnityEngine::Renderer,bool>>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Renderer>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Renderer>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Tuple<UnityEngine::Renderer,bool>>::get_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::System::Tuple<UnityEngine::Renderer,bool>::get_Item1);
			//     byte_18D8EDB92 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3495, 0LL) )
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCharacters, v5);
			//     v8 = 0;
			//     if ( HG::Rendering::Runtime::HGCharacters::EnableCharacterShadow(this, 0LL) )
			//     {
			//       for ( i = 0; ; ++i )
			//       {
			//         renderers = this.fields.renderers;
			//         if ( !renderers )
			//           goto LABEL_40;
			//         if ( i >= renderers.fields._size )
			//           break;
			//         Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                  (List_1_System_Object_ *)this.fields.renderers,
			//                  i,
			//                  MethodInfo::System::Collections::Generic::List<System::Tuple<UnityEngine::Renderer,bool>>::get_Item);
			//         if ( !Item )
			//           goto LABEL_40;
			//         klass = (Renderer *)Item[1].klass;
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//         if ( !UnityEngine::Object::op_Equality((Object_1 *)klass, 0LL, 0LL) )
			//         {
			//           if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCharacters, v6);
			//           ShadowLayer = HG::Rendering::Runtime::HGCharacters::GetShadowLayer(v4, 0LL);
			//           if ( !klass )
			//             goto LABEL_40;
			//           UnityEngine::Renderer::set_renderingLayerMask(klass, ShadowLayer | 2, 0LL);
			//           if ( UnityEngine::Renderer::GetIsRealtimeShadowCaster(klass, 0LL) )
			//           {
			//             v14 = v4 + 1;
			//             if ( v4 + 1 > 15 )
			//               v14 = 15;
			//             UnityEngine::Renderer::set_characterIndex(klass, v14, 0LL);
			//           }
			//         }
			//       }
			//       while ( 1 )
			//       {
			//         shadowProxyRenderers = this.fields.shadowProxyRenderers;
			//         if ( !shadowProxyRenderers )
			//           break;
			//         if ( v8 >= shadowProxyRenderers.fields._size )
			//           return;
			//         v17 = System::Collections::Generic::List<System::Object>::get_Item(
			//                 (List_1_System_Object_ *)this.fields.shadowProxyRenderers,
			//                 v8,
			//                 MethodInfo::System::Collections::Generic::List<UnityEngine::Renderer>::get_Item);
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v16);
			//         if ( !UnityEngine::Object::op_Equality((Object_1 *)v17, 0LL, 0LL) )
			//         {
			//           if ( !v17 )
			//             break;
			//           UnityEngine::Renderer::set_renderingLayerMask((Renderer *)v17, 2u, 0LL);
			//         }
			//         ++v8;
			//       }
			//     }
			//     else
			//     {
			//       while ( 1 )
			//       {
			//         v18 = this.fields.renderers;
			//         if ( !v18 )
			//           break;
			//         if ( v8 >= v18.fields._size )
			//           return;
			//         v19 = System::Collections::Generic::List<System::Object>::get_Item(
			//                 (List_1_System_Object_ *)this.fields.renderers,
			//                 v8,
			//                 MethodInfo::System::Collections::Generic::List<System::Tuple<UnityEngine::Renderer,bool>>::get_Item);
			//         if ( !v19 )
			//           break;
			//         v20 = (Renderer *)v19[1].klass;
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//         if ( !UnityEngine::Object::op_Equality((Object_1 *)v20, 0LL, 0LL) )
			//         {
			//           if ( !v20 )
			//             break;
			//           UnityEngine::Renderer::set_renderingLayerMask(v20, 2u, 0LL);
			//           UnityEngine::Renderer::set_characterIndex(v20, 0, 0LL);
			//         }
			//         ++v8;
			//       }
			//     }
			// LABEL_40:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3495, 0LL);
			//   if ( !Patch )
			//     goto LABEL_40;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1248(Patch, (Object *)this, v4, 0LL);
			// }
			// 
		}

		public void SetBoundSizeOffset(float offset)
		{
			// // Void SetBoundSizeOffset(Single)
			// void HG::Rendering::Runtime::HGCharacterHelper::SetBoundSizeOffset(
			//         HGCharacterHelper *this,
			//         float offset,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3505, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3505, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, offset, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.boundSizeOffset = offset;
			//   }
			// }
			// 
		}

		private void CleanUp()
		{
			// // Void CleanUp()
			// void HG::Rendering::Runtime::HGCharacterHelper::CleanUp(HGCharacterHelper *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v4; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_System_Collections_Generic_List_1_UnityEngine_Camera_ *v7; // rbx
			//   __int64 v8; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDB93 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Collections::Generic::List<UnityEngine::Camera>>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGCharacterHelper::OnBeginFrameRendering);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacters);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
			//     byte_18D8EDB93 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3506, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3506, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			// LABEL_10:
			//     sub_180B536AC(v6, v5);
			//   }
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCharacters, v3);
			//   HG::Rendering::Runtime::HGCharacters::DequeueCharacter(this, 0LL);
			//   v4 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_180004920(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Collections::Generic::List<UnityEngine::Camera>>);
			//   v7 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_System_Collections_Generic_List_1_UnityEngine_Camera_ *)v4;
			//   if ( !v4 )
			//     goto LABEL_10;
			//   System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
			//     v4,
			//     (Object *)this,
			//     MethodInfo::HG::Rendering::Runtime::HGCharacterHelper::OnBeginFrameRendering,
			//     0LL);
			//   if ( !TypeInfo::UnityEngine::Rendering::RenderPipelineManager._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::RenderPipelineManager, v8);
			//   UnityEngine::Rendering::RenderPipelineManager::remove_beginFrameRenderingNoAlloc(v7, 0LL);
			// }
			// 
		}

		private void OnDisable()
		{
			// // Void OnDisable()
			// void HG::Rendering::Runtime::HGCharacterHelper::OnDisable(HGCharacterHelper *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3508, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3508, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGCharacterHelper::CleanUp(this, 0LL);
			//   }
			// }
			// 
		}

		private void OnDestroy()
		{
			// // Void OnDestroy()
			// void HG::Rendering::Runtime::HGCharacterHelper::OnDestroy(HGCharacterHelper *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3509, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3509, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGCharacterHelper::CleanUp(this, 0LL);
			//   }
			// }
			// 
		}

		private void OnValidate()
		{
			// // Void OnValidate()
			// void HG::Rendering::Runtime::HGCharacterHelper::OnValidate(HGCharacterHelper *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !byte_18D919764 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacters);
			//     byte_18D919764 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3510, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3510, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCharacters);
			//     HG::Rendering::Runtime::HGCharacters::SortCharacterHelpers(0LL);
			//   }
			// }
			// 
		}

		public void UpdateBoneSpheresByBoundingBox()
		{
			// // Void UpdateBoneSpheresByBoundingBox()
			// void HG::Rendering::Runtime::HGCharacterHelper::UpdateBoneSpheresByBoundingBox(
			//         HGCharacterHelper *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *boneSpheres; // rcx
			//   int32_t i; // esi
			//   List_1_System_Tuple_2_UnityEngine_Renderer_Boolean_ *renderers; // rax
			//   Object *Item; // rax
			//   Renderer *klass; // rbx
			//   Transform *transform; // r15
			//   Bounds *localBounds; // rax
			//   __m128i v11; // xmm6
			//   __int64 v12; // xmm0_8
			//   SkinnedMeshRenderer *v13; // rax
			//   SkinnedMeshRenderer *v14; // r14
			//   Object_1 *rootBone; // rbx
			//   Component *v16; // rax
			//   Vector3 *localPosition; // rax
			//   FileDescriptor *v18; // xmm0_8
			//   MethodInfo *v19; // r9
			//   Vector3 *v20; // rax
			//   MonitorData *v21; // xmm6_8
			//   int32_t z_low; // ebx
			//   double v23; // xmm0_8
			//   List_1_HG_Rendering_Runtime_HGCharacterHelper_HGCharacterShadowSphere_ *v24; // r9
			//   OneofDescriptorProto *v25; // rdx
			//   FileDescriptor *v26; // r8
			//   __int64 v27; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   OneofDescriptor v29; // [rsp+28h] [rbp-79h] BYREF
			//   _BYTE v30[24]; // [rsp+78h] [rbp-29h]
			//   Bounds v31; // [rsp+98h] [rbp-9h] BYREF
			//   Vector3 v32; // [rsp+B8h] [rbp+17h] BYREF
			//   Vector3 v33[2]; // [rsp+C8h] [rbp+27h] BYREF
			// 
			//   if ( !byte_18D919765 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper::HGCharacterShadowSphere>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper::HGCharacterShadowSphere>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Tuple<UnityEngine::Renderer,bool>>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Tuple<UnityEngine::Renderer,bool>>::get_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::SkinnedMeshRenderer);
			//     sub_18003C530(&MethodInfo::System::Tuple<UnityEngine::Renderer,bool>::get_Item1);
			//     byte_18D919765 = 1;
			//   }
			//   memset(&v29, 0, 24);
			//   if ( IFix::WrappersManagerImpl::IsPatched(3511, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3511, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			// LABEL_20:
			//     sub_180B536AC(boneSpheres, v3);
			//   }
			//   boneSpheres = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)this.fields.boneSpheres;
			//   if ( !boneSpheres )
			//     goto LABEL_20;
			//   System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
			//     boneSpheres,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper::HGCharacterShadowSphere>::Clear);
			//   if ( this.fields.renderers )
			//   {
			//     for ( i = 0; ; ++i )
			//     {
			//       renderers = this.fields.renderers;
			//       if ( !renderers )
			//         goto LABEL_20;
			//       if ( i >= renderers.fields._size )
			//         break;
			//       Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                (List_1_System_Object_ *)this.fields.renderers,
			//                i,
			//                MethodInfo::System::Collections::Generic::List<System::Tuple<UnityEngine::Renderer,bool>>::get_Item);
			//       if ( !Item )
			//         goto LABEL_20;
			//       klass = (Renderer *)Item[1].klass;
			//       transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//       if ( !klass )
			//         goto LABEL_20;
			//       localBounds = UnityEngine::Renderer::get_localBounds(&v31, klass, 0LL);
			//       v11 = *(__m128i *)&localBounds.m_Center.x;
			//       v12 = *(_QWORD *)&localBounds.m_Extents.y;
			//       *(_OWORD *)v30 = *(_OWORD *)&localBounds.m_Center.x;
			//       *(_QWORD *)&v30[16] = v12;
			//       v13 = (SkinnedMeshRenderer *)sub_18003F5A0(klass, TypeInfo::UnityEngine::SkinnedMeshRenderer);
			//       v14 = v13;
			//       if ( v13 )
			//       {
			//         rootBone = (Object_1 *)UnityEngine::SkinnedMeshRenderer::get_rootBone(v13, 0LL);
			//         sub_180002C70(TypeInfo::UnityEngine::Object);
			//         if ( UnityEngine::Object::op_Inequality(rootBone, 0LL, 0LL) )
			//         {
			//           v16 = (Component *)UnityEngine::SkinnedMeshRenderer::get_rootBone(v14, 0LL);
			//           if ( !v16 )
			//             goto LABEL_20;
			//           transform = UnityEngine::Component::get_transform(v16, 0LL);
			//         }
			//       }
			//       if ( !transform )
			//         goto LABEL_20;
			//       localPosition = UnityEngine::Transform::get_localPosition(&v32, transform, 0LL);
			//       v29.fields.fields = (IList_1_Google_Protobuf_Reflection_FieldDescriptor_ *)v11.m128i_i64[0];
			//       LODWORD(v29.fields.accessor) = _mm_cvtsi128_si32(_mm_srli_si128(v11, 8));
			//       v18 = *(FileDescriptor **)&localPosition.x;
			//       *(float *)&localPosition = localPosition.z;
			//       v29.fields._._File_k__BackingField = v18;
			//       LODWORD(v29.fields.containingType) = (_DWORD)localPosition;
			//       v20 = UnityEngine::Vector3::op_Subtraction(
			//               v33,
			//               (Vector3 *)&v29.fields.fields,
			//               (Vector3 *)&v29.fields._._File_k__BackingField,
			//               v19);
			//       v21 = *(MonitorData **)&v20.x;
			//       z_low = LODWORD(v20.z);
			//       v29.fields._Proto_k__BackingField = *(OneofDescriptorProto **)&v30[12];
			//       *(_DWORD *)&v29.fields._IsSynthetic_k__BackingField = *(_DWORD *)&v30[20];
			//       v23 = sub_18238EFA0(&v29.fields._Proto_k__BackingField);
			//       v24 = this.fields.boneSpheres;
			//       LODWORD(v29.monitor) = LODWORD(v23);
			//       *(MonitorData **)((char *)&v29.monitor + 4) = v21;
			//       *(&v29.fields._._Index_k__BackingField + 1) = z_low;
			//       v29.klass = (OneofDescriptor__Class *)transform;
			//       ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *))sub_1800054D0)(
			//         &v29,
			//         v25,
			//         v26,
			//         (MessageDescriptor *)v24);
			//       if ( !v27 )
			//         goto LABEL_20;
			//       *(_OWORD *)&v31.m_Center.x = *(_OWORD *)&v29.klass;
			//       *(_QWORD *)&v31.m_Extents.y = *(_QWORD *)&v29.fields._._Index_k__BackingField;
			//       sub_180420908(
			//         v27,
			//         &v31,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper::HGCharacterShadowSphere>::Add);
			//     }
			//     this.fields.enableSphereBasedBounds = 1;
			//   }
			// }
			// 
		}

		public List<Tuple<Renderer, bool>> renderers;

		private LODGroup m_LodGroup;

		private List<Renderer> shadowProxyRenderers;

		[SerializeField]
		private int priority;

		[SerializeField]
		private float boundSizeOffset;

		public List<HGCharacterHelper.HGCharacterShadowSphere> boneSpheres;

		public List<HGCharacterHelper.HGCharacterShadowSphere> customBoneSpheres;

		public bool enableSphereBasedBounds;

		[HideInInspector]
		public Bounds bounds;

		private const float BOUND_UPDATE_THRESHOLD = 0.02f;

		[Serializable]
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct HGCharacterShadowSphere
		{
			public Transform rootTransform;

			public float radius;

			public Vector3 localOffset;
		}
	}
}
