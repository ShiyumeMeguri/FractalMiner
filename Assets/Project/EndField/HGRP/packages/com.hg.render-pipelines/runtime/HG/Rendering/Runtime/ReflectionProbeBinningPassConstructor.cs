using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class ReflectionProbeBinningPassConstructor : IPassConstructor
	{
		internal ReflectionProbeBinningPassConstructor()
		{
			// // ReflectionProbeBinningPassConstructor()
			// void HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::ReflectionProbeBinningPassConstructor(
			//         ReflectionProbeBinningPassConstructor *this,
			//         MethodInfo *method)
			// {
			//   __int128 v3; // xmm1
			//   __int128 v4; // xmm0
			//   __int128 v5; // xmm1
			//   __int64 v6; // r8
			//   __int64 v7; // r9
			//   HGRenderPathBase_HGRenderPathResources *v8; // rdx
			//   PassConstructorID__Enum__Array *v9; // r8
			//   HGCamera *v10; // r9
			//   __int64 v11; // r8
			//   __int64 v12; // r9
			//   HGRenderPathBase_HGRenderPathResources *v13; // rdx
			//   PassConstructorID__Enum__Array *v14; // r8
			//   HGCamera *v15; // r9
			//   LowLevelList_1_System_Object_ *v16; // rax
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   List_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *v19; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v20; // rdx
			//   PassConstructorID__Enum__Array *v21; // r8
			//   HGCamera *v22; // r9
			//   LowLevelList_1_System_Object_ *v23; // rax
			//   List_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *v24; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v25; // rdx
			//   PassConstructorID__Enum__Array *v26; // r8
			//   HGCamera *v27; // r9
			//   MethodInfo *v28; // [rsp+20h] [rbp-98h]
			//   MethodInfo *v29; // [rsp+20h] [rbp-98h]
			//   MethodInfo *v30; // [rsp+20h] [rbp-98h]
			//   MethodInfo *v31; // [rsp+28h] [rbp-90h]
			//   MethodInfo *v32; // [rsp+28h] [rbp-90h]
			//   MethodInfo *v33; // [rsp+28h] [rbp-90h]
			//   __m128i v34; // [rsp+30h] [rbp-88h] BYREF
			//   __m128i si128; // [rsp+40h] [rbp-78h] BYREF
			//   __m128i v36; // [rsp+50h] [rbp-68h] BYREF
			//   __m128i v37; // [rsp+60h] [rbp-58h] BYREF
			//   Matrix4x4 v38; // [rsp+70h] [rbp-48h] BYREF
			//   MethodInfo *v39; // [rsp+E0h] [rbp+28h]
			//   MethodInfo *v40; // [rsp+E8h] [rbp+30h]
			// 
			//   if ( !byte_18D8EDCF3 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Texture);
			//     byte_18D8EDCF3 = 1;
			//   }
			//   si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576E0);
			//   memset(&v38, 0, sizeof(v38));
			//   v34 = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//   v36 = _mm_load_si128((const __m128i *)&xmmword_18A3576B0);
			//   v37 = _mm_load_si128((const __m128i *)&xmmword_18A357BA0);
			//   UnityEngine::Matrix4x4::Matrix4x4(&v38, (Vector4 *)&v37, (Vector4 *)&v36, (Vector4 *)&si128, (Vector4 *)&v34, 0LL);
			//   v3 = *(_OWORD *)&v38.m01;
			//   *(_OWORD *)&this.fields.unitExtents.m00 = *(_OWORD *)&v38.m00;
			//   v4 = *(_OWORD *)&v38.m02;
			//   *(_OWORD *)&this.fields.unitExtents.m01 = v3;
			//   v5 = *(_OWORD *)&v38.m03;
			//   *(_OWORD *)&this.fields.unitExtents.m02 = v4;
			//   *(_OWORD *)&this.fields.unitExtents.m03 = v5;
			//   *(_QWORD *)&this.fields.m_prevCameraPosition.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//   this.fields.m_prevCameraPosition.z = 0.0;
			//   this.fields.m_blitIndices = (Int32__Array *)il2cpp_array_new_specific_0(TypeInfo::System::Int32, 32LL, v6, v7);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_blitIndices, v8, v9, v10, v28, v31);
			//   this.fields.m_blitTextures = (Texture__Array *)il2cpp_array_new_specific_0(
			//                                                     TypeInfo::UnityEngine::Texture,
			//                                                     32LL,
			//                                                     v11,
			//                                                     v12);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_blitTextures, v13, v14, v15, v29, v32);
			//   v16 = (LowLevelList_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>);
			//   v19 = (List_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *)v16;
			//   if ( !v16
			//     || (System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
			//           v16,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::List),
			//         this.fields.m_previousOctNode = v19,
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.m_previousOctNode, v20, v21, v22, v30, v33),
			//         v23 = (LowLevelList_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>),
			//         (v24 = (List_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *)v23) == 0LL) )
			//   {
			//     sub_180B536AC(v18, v17);
			//   }
			//   System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
			//     v23,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::List);
			//   this.fields.m_currrentOctNode = v24;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_currrentOctNode, v25, v26, v27, v39, v40);
			// }
			// 
		}

		private void PrepareGlobalReflectionProbe(ReflectionProbeBinningPassConstructor.PassData passData, HGCamera hgCamera)
		{
			// // Void PrepareGlobalReflectionProbe(ReflectionProbeBinningPassConstructor+PassData, HGCamera)
			// void HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::PrepareGlobalReflectionProbe(
			//         ReflectionProbeBinningPassConstructor *this,
			//         ReflectionProbeBinningPassConstructor_PassData *passData,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolume_ *InterpolatedVolumes; // r15
			//   List_1_System_Single_ *InterpolatedVolumesFactor; // rax
			//   List_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *v9; // rdx
			//   List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *m_currrentOctNode; // rcx
			//   List_1_System_Single_ *v11; // r13
			//   int32_t v12; // r14d
			//   PassConstructorID__Enum__Array *v13; // r8
			//   HGCamera *v14; // r9
			//   Object *Item; // rbx
			//   Object *v16; // rax
			//   Object *v17; // rax
			//   __int64 v18; // rbx
			//   char v19; // bl
			//   Object *v20; // rax
			//   __int64 v21; // rax
			//   Object_1 *v22; // r12
			//   PassConstructorID__Enum__Array *v23; // r8
			//   HGCamera *v24; // r9
			//   List_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *v25; // rax
			//   List_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *v26; // rbx
			//   List_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *m_previousOctNode; // rax
			//   List_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *v28; // rax
			//   int32_t i; // ebx
			//   List_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *v30; // rax
			//   List_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *v31; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v33; // [rsp+20h] [rbp-60h]
			//   MethodInfo *v34; // [rsp+28h] [rbp-58h]
			//   unsigned __int128 v35; // [rsp+30h] [rbp-50h] BYREF
			//   Object_1 *y[2]; // [rsp+40h] [rbp-40h] BYREF
			//   unsigned __int128 v37; // [rsp+50h] [rbp-30h] BYREF
			//   ReflectionProbeBinningPassConstructor_OctNode v38; // [rsp+60h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D919E46 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSkyConfig);
			//     sub_18003C530(&MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::get_Count);
			//     sub_18003C530(&MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::AddRange);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<float>::get_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919E46 = 1;
			//   }
			//   v35 = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1715, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     InterpolatedVolumes = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedVolumes(hgCamera, 0LL);
			//     InterpolatedVolumesFactor = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedVolumesFactor(
			//                                   hgCamera,
			//                                   0LL);
			//     m_currrentOctNode = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)this.fields.m_currrentOctNode;
			//     v11 = InterpolatedVolumesFactor;
			//     if ( !m_currrentOctNode )
			//       goto LABEL_49;
			//     System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
			//       m_currrentOctNode,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::Clear);
			//     v12 = 0;
			//     if ( !InterpolatedVolumes )
			//       goto LABEL_49;
			//     while ( v12 < Beyond::UniqueList<System::Object>::get_length(
			//                     (UniqueList_1_System_Object_ *)InterpolatedVolumes,
			//                     MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::get_Count) )
			//     {
			//       Item = Beyond::IndexedHashSet<System::Object>::get_Item(
			//                (IndexedHashSet_1_System_Object_ *)InterpolatedVolumes,
			//                v12,
			//                MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::get_Item);
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       if ( UnityEngine::Object::op_Inequality((Object_1 *)Item, 0LL, 0LL) )
			//       {
			//         v16 = Beyond::IndexedHashSet<System::Object>::get_Item(
			//                 (IndexedHashSet_1_System_Object_ *)InterpolatedVolumes,
			//                 v12,
			//                 MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::get_Item);
			//         if ( !v16 )
			//           goto LABEL_49;
			//         if ( (unsigned __int8)sub_1800023D0(11LL, v16) )
			//         {
			//           v17 = Beyond::IndexedHashSet<System::Object>::get_Item(
			//                   (IndexedHashSet_1_System_Object_ *)InterpolatedVolumes,
			//                   v12,
			//                   MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::get_Item);
			//           if ( !v17 )
			//             goto LABEL_49;
			//           v18 = sub_18004A6C0(12LL, v17);
			//           if ( !v18 )
			//             goto LABEL_49;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGSkyConfig);
			//           v19 = *(_BYTE *)(v18 + 712);
			//           v20 = Beyond::IndexedHashSet<System::Object>::get_Item(
			//                   (IndexedHashSet_1_System_Object_ *)InterpolatedVolumes,
			//                   v12,
			//                   MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::get_Item);
			//           if ( !v20 )
			//             goto LABEL_49;
			//           v21 = sub_18004A6C0(12LL, v20);
			//           if ( !v21 )
			//             goto LABEL_49;
			//           v22 = *(Object_1 **)(v21 + 584);
			//           if ( v19 )
			//           {
			//             sub_180002C70(TypeInfo::UnityEngine::Object);
			//             if ( UnityEngine::Object::op_Inequality(v22, 0LL, 0LL) )
			//             {
			//               if ( !v11 )
			//                 goto LABEL_49;
			//               if ( System::Collections::Generic::List<float>::get_Item(
			//                      v11,
			//                      v12,
			//                      MethodInfo::System::Collections::Generic::List<float>::get_Item) >= 0.99989998 )
			//               {
			//                 m_currrentOctNode = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)this.fields.m_currrentOctNode;
			//                 if ( !m_currrentOctNode )
			//                   goto LABEL_49;
			//                 System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
			//                   m_currrentOctNode,
			//                   MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::Clear);
			//               }
			//               v25 = this.fields.m_currrentOctNode;
			//               if ( !v25 )
			//                 goto LABEL_49;
			//               if ( !v25.fields._size
			//                 || (System::Collections::Generic::List<Beyond::SparkBuffer::Serialize::ObjectReflector_ReflectType::FieldInfo>::get_Item(
			//                       (ObjectReflector_ReflectType_FieldInfo *)y,
			//                       (List_1_Beyond_SparkBuffer_Serialize_ObjectReflector_ReflectType_FieldInfo_ *)this.fields.m_currrentOctNode,
			//                       v25.fields._size - 1,
			//                       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::get_Item),
			//                     sub_180002C70(TypeInfo::UnityEngine::Object),
			//                     UnityEngine::Object::op_Inequality(v22, y[0], 0LL)) )
			//               {
			//                 v26 = this.fields.m_currrentOctNode;
			//                 v35 = (unsigned __int64)v22;
			//                 sub_1800054D0(
			//                   (HGRenderPathScene *)&v35,
			//                   (HGRenderPathBase_HGRenderPathResources *)v9,
			//                   v23,
			//                   v24,
			//                   v33,
			//                   v34);
			//                 DWORD2(v35) = System::Collections::Generic::List<float>::get_Item(
			//                                 v11,
			//                                 v12,
			//                                 MethodInfo::System::Collections::Generic::List<float>::get_Item);
			//                 if ( !v26 )
			//                   goto LABEL_49;
			//                 v37 = v35;
			//                 System::Collections::Generic::List<Beyond::SparkBuffer::Serialize::ObjectReflector_ReflectType::FieldInfo>::Add(
			//                   (List_1_Beyond_SparkBuffer_Serialize_ObjectReflector_ReflectType_FieldInfo_ *)v26,
			//                   (ObjectReflector_ReflectType_FieldInfo *)&v37,
			//                   MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::Add);
			//               }
			//             }
			//           }
			//         }
			//       }
			//       ++v12;
			//     }
			//     if ( !passData
			//       || (passData.fields.renderBlend = 0, (m_previousOctNode = this.fields.m_previousOctNode) == 0LL)
			//       || (m_currrentOctNode = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)(unsigned int)m_previousOctNode.fields._size,
			//           (v28 = this.fields.m_currrentOctNode) == 0LL) )
			//     {
			// LABEL_49:
			//       sub_180B536AC(m_currrentOctNode, v9);
			//     }
			//     if ( (_DWORD)m_currrentOctNode == v28.fields._size )
			//     {
			//       for ( i = 0; ; ++i )
			//       {
			//         v30 = this.fields.m_currrentOctNode;
			//         if ( !v30 )
			//           break;
			//         if ( i >= v30.fields._size )
			//           goto LABEL_37;
			//         System::Collections::Generic::List<Beyond::SparkBuffer::Serialize::ObjectReflector_ReflectType::FieldInfo>::get_Item(
			//           (ObjectReflector_ReflectType_FieldInfo *)&v37,
			//           (List_1_Beyond_SparkBuffer_Serialize_ObjectReflector_ReflectType_FieldInfo_ *)this.fields.m_currrentOctNode,
			//           i,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::get_Item);
			//         v9 = this.fields.m_previousOctNode;
			//         v35 = v37;
			//         if ( !v9 )
			//           break;
			//         System::Collections::Generic::List<Beyond::SparkBuffer::Serialize::ObjectReflector_ReflectType::FieldInfo>::get_Item(
			//           (ObjectReflector_ReflectType_FieldInfo *)y,
			//           (List_1_Beyond_SparkBuffer_Serialize_ObjectReflector_ReflectType_FieldInfo_ *)v9,
			//           i,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::get_Item);
			//         v38 = *(ReflectionProbeBinningPassConstructor_OctNode *)y;
			//         if ( HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode::diff(
			//                (ReflectionProbeBinningPassConstructor_OctNode *)&v35,
			//                &v38,
			//                0LL) )
			//         {
			//           goto LABEL_36;
			//         }
			//       }
			//       goto LABEL_49;
			//     }
			// LABEL_36:
			//     passData.fields.renderBlend = 1;
			// LABEL_37:
			//     if ( passData.fields.renderBlend )
			//     {
			//       m_currrentOctNode = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)this.fields.m_previousOctNode;
			//       if ( !m_currrentOctNode )
			//         goto LABEL_49;
			//       System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
			//         m_currrentOctNode,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::Clear);
			//       m_currrentOctNode = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)this.fields.m_previousOctNode;
			//       if ( !m_currrentOctNode )
			//         goto LABEL_49;
			//       System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::AddRange(
			//         (List_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *)m_currrentOctNode,
			//         (IEnumerable_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *)this.fields.m_currrentOctNode,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::AddRange);
			//     }
			//     v31 = this.fields.m_currrentOctNode;
			//     if ( !v31 )
			//       goto LABEL_49;
			//     if ( v31.fields._size > 0 )
			//     {
			//       this.fields.m_clearDefault = 0;
			//     }
			//     else if ( !this.fields.m_clearDefault )
			//     {
			//       this.fields.m_clearDefault = 1;
			//       passData.fields.clearDefault = 1;
			// LABEL_47:
			//       passData.fields.currrentOctNode = this.fields.m_currrentOctNode;
			//       sub_1800054D0(
			//         (HGRenderPathScene *)&passData.fields.currrentOctNode,
			//         (HGRenderPathBase_HGRenderPathResources *)v9,
			//         v13,
			//         v14,
			//         v33,
			//         v34);
			//       return;
			//     }
			//     passData.fields.clearDefault = 0;
			//     goto LABEL_47;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1715, 0LL);
			//   if ( !Patch )
			//     goto LABEL_49;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//     (ILFixDynamicMethodWrapper_28 *)Patch,
			//     (Object *)this,
			//     (Object *)passData,
			//     (Object *)hgCamera,
			//     0LL);
			// }
			// 
		}

		private void PrepareLocalReflectionProbe(ReflectionProbeBinningPassConstructor.PassData passData, HGCamera hgCamera, ref ReflectionProbeBinningPassConstructor.PassInput input)
		{
			// // Void PrepareLocalReflectionProbe(ReflectionProbeBinningPassConstructor+PassData, HGCamera, ReflectionProbeBinningPassConstructor+PassInput ByRef)
			// void HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::PrepareLocalReflectionProbe(
			//         ReflectionProbeBinningPassConstructor *this,
			//         ReflectionProbeBinningPassConstructor_PassData *passData,
			//         HGCamera *hgCamera,
			//         ReflectionProbeBinningPassConstructor_PassInput *input,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v9; // rdx
			//   SettingParameter_1_System_Int32Enum_ **settingParameters; // rcx
			//   Int32Enum__Enum v11; // r14d
			//   float deltaTime; // xmm6_4
			//   float fadeTime; // xmm0_4
			//   __int64 v14; // xmm7_8
			//   float z; // r15d
			//   float v16; // xmm6_4
			//   Transform *transform; // rax
			//   Vector3 *position; // rax
			//   __int64 v19; // xmm0_8
			//   MethodInfo *v20; // r9
			//   Vector3 *v21; // rax
			//   __int64 v22; // xmm3_8
			//   double v23; // xmm0_8
			//   float v24; // xmm7_4
			//   float cameraMovementNotFadeness; // xmm8_4
			//   Transform *v26; // rax
			//   Vector3 *v27; // rax
			//   float v28; // ecx
			//   uint64_t *m_Buffer; // r14
			//   PassConstructorID__Enum__Array *v30; // r8
			//   HGCamera *v31; // r9
			//   Texture__Array *m_blitTextures; // r9
			//   HGRenderPathBase_HGRenderPathResources *v33; // rdx
			//   PassConstructorID__Enum__Array *v34; // r8
			//   int32_t v35; // edi
			//   Int32__Array *blitIndices; // r15
			//   int32_t TextureIndex; // eax
			//   Texture__Array *blitTextures; // r15
			//   Texture *Texture; // rax
			//   Texture *v40; // r12
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int32_t maxBlitCounta; // [rsp+28h] [rbp-61h]
			//   MethodInfo *maxBlitCount; // [rsp+28h] [rbp-61h]
			//   MethodInfo *maxBlitCountb; // [rsp+28h] [rbp-61h]
			//   int32_t *blitCount; // [rsp+30h] [rbp-59h]
			//   MethodInfo *blitCounta; // [rsp+30h] [rbp-59h]
			//   int32_t v47[4]; // [rsp+48h] [rbp-41h] BYREF
			//   Vector3 v48; // [rsp+58h] [rbp-31h] BYREF
			//   Vector3 v49; // [rsp+68h] [rbp-21h] BYREF
			//   Vector3 v50; // [rsp+78h] [rbp-11h] BYREF
			//   NativeArray_1_System_UInt64_ v51; // [rsp+88h] [rbp-1h] BYREF
			// 
			//   if ( !byte_18D919E47 )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::GetUnsafePtr<unsigned long>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<unsigned long>::NativeArray);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     byte_18D919E47 = 1;
			//   }
			//   v47[0] = 0;
			//   v51 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1717, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1717, 0LL);
			//     if ( !Patch )
			//       goto LABEL_21;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_658(
			//       Patch,
			//       (Object *)this,
			//       (Object *)passData,
			//       (Object *)hgCamera,
			//       input,
			//       0LL);
			//   }
			//   else
			//   {
			//     settingParameters = (SettingParameter_1_System_Int32Enum_ **)input.settingParameters;
			//     if ( !settingParameters )
			//       goto LABEL_21;
			//     v11 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//             settingParameters[181],
			//             MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     deltaTime = UnityEngine::Time::get_deltaTime(0LL);
			//     fadeTime = UnityEngine::HyperGryph::HGReflectionProbe::get_fadeTime(0LL);
			//     v14 = *(_QWORD *)&this.fields.m_prevCameraPosition.x;
			//     z = this.fields.m_prevCameraPosition.z;
			//     v16 = deltaTime / fadeTime;
			//     if ( !hgCamera )
			//       goto LABEL_21;
			//     settingParameters = (SettingParameter_1_System_Int32Enum_ **)hgCamera.fields.camera;
			//     if ( !settingParameters )
			//       goto LABEL_21;
			//     transform = UnityEngine::Component::get_transform((Component *)settingParameters, 0LL);
			//     if ( !transform )
			//       goto LABEL_21;
			//     position = UnityEngine::Transform::get_position(&v49, transform, 0LL);
			//     v19 = *(_QWORD *)&position.x;
			//     *(float *)&position = position.z;
			//     *(_QWORD *)&v48.x = v19;
			//     LODWORD(v48.z) = (_DWORD)position;
			//     *(_QWORD *)&v49.x = v14;
			//     v49.z = z;
			//     v21 = UnityEngine::Vector3::op_Subtraction(&v50, &v49, &v48, v20);
			//     v22 = *(_QWORD *)&v21.x;
			//     *(float *)&v21 = v21.z;
			//     *(_QWORD *)&v49.x = v22;
			//     LODWORD(v49.z) = (_DWORD)v21;
			//     v23 = sub_18238EFA0(&v49);
			//     v24 = *(float *)&v23;
			//     cameraMovementNotFadeness = UnityEngine::HyperGryph::HGReflectionProbe::get_cameraMovementNotFadeness(0LL);
			//     if ( v24 >= cameraMovementNotFadeness )
			//       v11 = 32;
			//     settingParameters = (SettingParameter_1_System_Int32Enum_ **)hgCamera.fields.camera;
			//     if ( !settingParameters )
			//       goto LABEL_21;
			//     v26 = UnityEngine::Component::get_transform((Component *)settingParameters, 0LL);
			//     if ( !v26 )
			//       goto LABEL_21;
			//     v27 = UnityEngine::Transform::get_position(&v50, v26, 0LL);
			//     v28 = v27.z;
			//     *(_QWORD *)&this.fields.m_prevCameraPosition.x = *(_QWORD *)&v27.x;
			//     this.fields.m_prevCameraPosition.z = v28;
			//     Unity::Collections::NativeArray<unsigned long>::NativeArray(
			//       &v51,
			//       v11,
			//       Allocator__Enum_Temp,
			//       NativeArrayOptions__Enum_ClearMemory,
			//       MethodInfo::Unity::Collections::NativeArray<unsigned long>::NativeArray);
			//     maxBlitCounta = v11;
			//     m_Buffer = (uint64_t *)v51.m_Buffer;
			//     UnityEngine::HyperGryph::HGReflectionProbe::UpdateViewPhase1(
			//       hgCamera.fields.reflectionProbeViewHandle,
			//       v16,
			//       v24 < cameraMovementNotFadeness,
			//       v51.m_Buffer,
			//       maxBlitCounta,
			//       v47,
			//       0LL);
			//     if ( !passData )
			//       goto LABEL_21;
			//     passData.fields.blitCount = v47[0];
			//     passData.fields.blitIndices = this.fields.m_blitIndices;
			//     sub_1800054D0(
			//       (HGRenderPathScene *)&passData.fields.blitIndices,
			//       v9,
			//       v30,
			//       v31,
			//       maxBlitCount,
			//       (MethodInfo *)blitCount);
			//     m_blitTextures = this.fields.m_blitTextures;
			//     passData.fields.blitTextures = m_blitTextures;
			//     sub_1800054D0(
			//       (HGRenderPathScene *)&passData.fields.blitTextures,
			//       v33,
			//       v34,
			//       (HGCamera *)m_blitTextures,
			//       maxBlitCountb,
			//       blitCounta);
			//     v35 = 0;
			//     if ( v47[0] > 0 )
			//     {
			//       while ( 1 )
			//       {
			//         blitIndices = passData.fields.blitIndices;
			//         TextureIndex = UnityEngine::HyperGryph::HGReflectionProbe::GetTextureIndex(
			//                          hgCamera.fields.reflectionProbeViewHandle,
			//                          *m_Buffer,
			//                          0LL);
			//         if ( !blitIndices )
			//           break;
			//         if ( (unsigned int)v35 >= blitIndices.max_length.size )
			//           sub_180070270(settingParameters, v9);
			//         blitIndices.vector[v35] = TextureIndex;
			//         blitTextures = passData.fields.blitTextures;
			//         Texture = UnityEngine::HyperGryph::HGReflectionProbe::GetTexture(
			//                     hgCamera.fields.reflectionProbeViewHandle,
			//                     *m_Buffer,
			//                     0LL);
			//         v40 = Texture;
			//         if ( !blitTextures )
			//           break;
			//         sub_180036D40(blitTextures, Texture);
			//         sub_180328478(blitTextures, v35++, v40);
			//         ++m_Buffer;
			//         if ( v35 >= v47[0] )
			//           return;
			//       }
			// LABEL_21:
			//       sub_180B536AC(settingParameters, v9);
			//     }
			//   }
			// }
			// 
		}

		private void PrepareConstantBuffer(ReflectionProbeBinningPassConstructor.PassData passData, HGCamera hgCamera, ref ReflectionProbeBinningPassConstructor.PassInput input)
		{
			// // Void PrepareConstantBuffer(ReflectionProbeBinningPassConstructor+PassData, HGCamera, ReflectionProbeBinningPassConstructor+PassInput ByRef)
			// void HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::PrepareConstantBuffer(
			//         ReflectionProbeBinningPassConstructor *this,
			//         ReflectionProbeBinningPassConstructor_PassData *passData,
			//         HGCamera *hgCamera,
			//         ReflectionProbeBinningPassConstructor_PassInput *input,
			//         MethodInfo *method)
			// {
			//   Camera *v9; // rdx
			//   Camera *camera; // rcx
			//   int32_t tileSize; // edi
			//   float v12; // xmm0_4
			//   float v13; // xmm8_4
			//   float aspect; // xmm0_4
			//   float v15; // xmm10_4
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   __int64 v18; // r8
			//   __int64 v19; // r9
			//   float v20; // xmm7_4
			//   float v21; // xmm6_4
			//   int32_t octTextureSize; // edi
			//   int v23; // eax
			//   CBHandle *ConstantBuffer; // rax
			//   void *ptr; // xmm0_8
			//   CBHandle *v26; // rax
			//   void *v27; // xmm0_8
			//   __m128i v28; // xmm1
			//   void *v29; // rbx
			//   __int128 v30; // xmm0
			//   __int128 v31; // xmm1
			//   __int128 v32; // xmm1
			//   float3 *v33; // rdx
			//   float3 *v34; // rcx
			//   float3 *v35; // r8
			//   float3 *v36; // r9
			//   __m128i *v37; // rdi
			//   HGEnvironmentPhase *InterpolatedPhase; // rax
			//   __int128 v39; // xmm1
			//   __int128 v40; // xmm0
			//   __int128 v41; // xmm1
			//   __int128 v42; // xmm0
			//   __int128 v43; // xmm1
			//   float shb8; // eax
			//   SHCoefficientsL1 *CoefficientsL1; // rax
			//   __m128 shAr; // xmm7
			//   __m128 shAg; // xmm9
			//   __m128 shAb; // xmm10
			//   __m128 v49; // xmm6
			//   __m128 v50; // xmm5
			//   __m128 v51; // xmm8
			//   __m128 v52; // xmm7
			//   uint32_t reflectionProbeViewHandle; // ebx
			//   Matrix4x4 *worldToCameraMatrix; // rax
			//   __int128 v55; // xmm1
			//   void *v56; // r9
			//   __int128 v57; // xmm0
			//   __int128 v58; // xmm1
			//   __int128 v59; // xmm0
			//   __int128 v60; // xmm1
			//   __int128 v61; // xmm0
			//   __int128 v62; // xmm1
			//   void *v63; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Matrix4x4 v65; // [rsp+38h] [rbp-D0h] BYREF
			//   int32_t tileX; // [rsp+78h] [rbp-90h]
			//   int32_t tileY; // [rsp+7Ch] [rbp-8Ch]
			//   int32_t sliceZ; // [rsp+80h] [rbp-88h]
			//   int32_t v69; // [rsp+84h] [rbp-84h]
			//   int32_t v70; // [rsp+88h] [rbp-80h]
			//   int v71; // [rsp+8Ch] [rbp-7Ch]
			//   __m128i *sceneRTSize_k__BackingField; // [rsp+90h] [rbp-78h]
			//   Matrix4x4 v73; // [rsp+98h] [rbp-70h] BYREF
			//   SphericalHarmonicsL2 v74; // [rsp+D8h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D919E48 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ColorUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D919E48 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1719, 0LL) )
			//   {
			//     if ( hgCamera )
			//     {
			//       camera = hgCamera.fields.camera;
			//       tileSize = input.binningData.tileSize;
			//       sceneRTSize_k__BackingField = (__m128i *)hgCamera.fields._sceneRTSize_k__BackingField;
			//       tileX = input.binningData.tileX;
			//       tileY = input.binningData.tileY;
			//       v70 = input.binningData.tileX;
			//       v69 = input.binningData.tileY;
			//       sliceZ = input.binningData.sliceZ;
			//       v71 = tileSize;
			//       if ( camera )
			//       {
			//         v12 = UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
			//         camera = hgCamera.fields.camera;
			//         v13 = v12;
			//         if ( camera )
			//         {
			//           aspect = UnityEngine::Camera::get_aspect(camera, 0LL);
			//           camera = hgCamera.fields.camera;
			//           v15 = aspect;
			//           if ( camera )
			//           {
			//             UnityEngine::Camera::get_fieldOfView(camera, 0LL);
			//             v20 = sub_1802ED290(v17, v16, v18, v19) * (float)(v13 + v13);
			//             v21 = (float)(v20 / (float)SHIDWORD(sceneRTSize_k__BackingField)) * (float)tileSize;
			//             if ( passData )
			//             {
			//               octTextureSize = passData.fields.octTextureSize;
			//               passData.fields.xyBinningThreadGroupX = (tileX + 7) / 8;
			//               passData.fields.xyBinningThreadGroupY = (tileY + 7) / 8;
			//               v23 = sliceZ + 63;
			//               passData.fields.xyBinningThreadGroupZ = 1;
			//               passData.fields.zBinningThreadGroupY = 1;
			//               passData.fields.zBinningThreadGroupZ = 1;
			//               passData.fields.zBinningThreadGroupX = v23 / 64;
			//               sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//               ConstantBuffer = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                                  (CBHandle *)&v65,
			//                                  &input.srpContext,
			//                                  2112,
			//                                  0LL);
			//               ptr = ConstantBuffer.ptr;
			//               *(_OWORD *)&passData.fields.reflectionProbeBinningInputDatasCB.bufferId = *(_OWORD *)&ConstantBuffer.bufferId;
			//               passData.fields.reflectionProbeBinningInputDatasCB.ptr = ptr;
			//               v26 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                       (CBHandle *)&v65,
			//                       &input.srpContext,
			//                       4160,
			//                       0LL);
			//               v27 = v26.ptr;
			//               *(_OWORD *)&passData.fields.reflectionProbeGlobalDatasCB.bufferId = *(_OWORD *)&v26.bufferId;
			//               v28 = _mm_cvtsi32_si128(tileY);
			//               passData.fields.reflectionProbeGlobalDatasCB.ptr = v27;
			//               v29 = passData.fields.reflectionProbeBinningInputDatasCB.ptr;
			//               sceneRTSize_k__BackingField = (__m128i *)passData.fields.reflectionProbeGlobalDatasCB.ptr;
			//               LODWORD(v65.m10) = _mm_cvtepi32_ps(v28).m128_u32[0];
			//               v65.m00 = (float)tileX;
			//               v65.m30 = 1.0 / (float)v71;
			//               v65.m20 = (float)(v70 * v69);
			//               v30 = *(_OWORD *)&v65.m00;
			//               v65.m10 = 1.0;
			//               v65.m00 = (float)sliceZ;
			//               *(_OWORD *)v29 = v30;
			//               v65.m20 = 1.0;
			//               v65.m30 = (float)octTextureSize / (float)(octTextureSize + 64);
			//               v31 = *(_OWORD *)&v65.m00;
			//               v65.m00 = 0.0;
			//               v65.m10 = v13;
			//               *((_OWORD *)v29 + 1) = v31;
			//               v65.m20 = v13;
			//               v65.m30 = 32.0 / (float)(octTextureSize + 64);
			//               v32 = *(_OWORD *)&v65.m00;
			//               v65.m20 = v21;
			//               v65.m00 = v15 * v20;
			//               v65.m10 = v20;
			//               *((_OWORD *)v29 + 2) = v32;
			//               *(float *)&v30 = sub_1802ECED0(v34, v33, v35, v36);
			//               v37 = sceneRTSize_k__BackingField;
			//               LODWORD(v65.m30) = v30;
			//               *((_OWORD *)v29 + 3) = *(_OWORD *)&v65.m00;
			//               *v37 = _mm_loadu_si128((const __m128i *)v29);
			//               v37[1] = _mm_loadu_si128((const __m128i *)v29 + 1);
			//               v37[2] = _mm_loadu_si128((const __m128i *)v29 + 2);
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//               InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
			//               if ( InterpolatedPhase )
			//               {
			//                 v39 = *(_OWORD *)&InterpolatedPhase.fields.skyConfig.skyAmbientSH.shr4;
			//                 *(_OWORD *)&v74.shr0 = *(_OWORD *)&InterpolatedPhase.fields.skyConfig.skyAmbientSH.shr0;
			//                 v40 = *(_OWORD *)&InterpolatedPhase.fields.skyConfig.skyAmbientSH.shr8;
			//                 *(_OWORD *)&v74.shr4 = v39;
			//                 v41 = *(_OWORD *)&InterpolatedPhase.fields.skyConfig.skyAmbientSH.shg3;
			//                 *(_OWORD *)&v74.shr8 = v40;
			//                 v42 = *(_OWORD *)&InterpolatedPhase.fields.skyConfig.skyAmbientSH.shg7;
			//                 *(_OWORD *)&v74.shg3 = v41;
			//                 v43 = *(_OWORD *)&InterpolatedPhase.fields.skyConfig.skyAmbientSH.shb2;
			//                 *(_OWORD *)&v74.shg7 = v42;
			//                 *(_QWORD *)&v42 = *(_QWORD *)&InterpolatedPhase.fields.skyConfig.skyAmbientSH.shb6;
			//                 shb8 = InterpolatedPhase.fields.skyConfig.skyAmbientSH.shb8;
			//                 *(_QWORD *)&v74.shb6 = v42;
			//                 v74.shb8 = shb8;
			//                 *(_OWORD *)&v74.shb2 = v43;
			//                 CoefficientsL1 = HG::Rendering::Runtime::HGEnvironmentUtils::GetCoefficientsL1(
			//                                    (SHCoefficientsL1 *)&v73,
			//                                    &v74,
			//                                    0LL);
			//                 shAr = (__m128)CoefficientsL1.shAr;
			//                 shAg = (__m128)CoefficientsL1.shAg;
			//                 shAb = (__m128)CoefficientsL1.shAb;
			//                 v65.m30 = 1.0;
			//                 LODWORD(v65.m00) = shAr.m128_i32[0];
			//                 LODWORD(v65.m10) = shAg.m128_i32[0];
			//                 LODWORD(v65.m20) = shAb.m128_i32[0];
			//                 v49 = *(__m128 *)&v65.m00;
			//                 *(__m128 *)&v65.m02 = shAb;
			//                 *(__m128 *)&v65.m01 = shAg;
			//                 sub_180002C70(TypeInfo::UnityEngine::Rendering::ColorUtils);
			//                 LODWORD(v65.m00) = _mm_shuffle_ps(shAr, shAr, 170).m128_u32[0];
			//                 LODWORD(v65.m10) = _mm_shuffle_ps(shAg, shAg, 170).m128_u32[0];
			//                 LODWORD(v65.m20) = _mm_shuffle_ps(shAb, shAb, 170).m128_u32[0];
			//                 v65.m30 = 1.0;
			//                 v50 = *(__m128 *)&v65.m00;
			//                 v65.m30 = 1.0;
			//                 LODWORD(v65.m10) = _mm_shuffle_ps(shAg, shAg, 85).m128_u32[0];
			//                 LODWORD(v65.m00) = _mm_shuffle_ps(shAr, shAr, 85).m128_u32[0];
			//                 LODWORD(v65.m20) = _mm_shuffle_ps(shAb, shAb, 85).m128_u32[0];
			//                 v51 = *(__m128 *)&v65.m00;
			//                 v65.m30 = 1.0;
			//                 LODWORD(v65.m00) = _mm_shuffle_ps(shAr, shAr, 255).m128_u32[0];
			//                 LODWORD(v65.m10) = _mm_shuffle_ps(shAg, shAg, 255).m128_u32[0];
			//                 LODWORD(v65.m20) = _mm_shuffle_ps(shAb, shAb, 255).m128_u32[0];
			//                 v52 = *(__m128 *)&v65.m00;
			//                 v65.m00 = (float)((float)(v49.m128_f32[0] * 0.2126729)
			//                                 + (float)(_mm_shuffle_ps(v49, v49, 85).m128_f32[0] * 0.7151522))
			//                         + (float)(_mm_shuffle_ps(v49, v49, 170).m128_f32[0] * 0.072175004);
			//                 v65.m10 = (float)((float)(v50.m128_f32[0] * 0.2126729)
			//                                 + (float)(_mm_shuffle_ps(v50, v50, 85).m128_f32[0] * 0.7151522))
			//                         + (float)(_mm_shuffle_ps(v50, v50, 170).m128_f32[0] * 0.072175004);
			//                 v65.m20 = (float)((float)(v51.m128_f32[0] * 0.2126729)
			//                                 + (float)(_mm_shuffle_ps(v51, v51, 85).m128_f32[0] * 0.7151522))
			//                         + (float)(_mm_shuffle_ps(v51, v51, 170).m128_f32[0] * 0.072175004);
			//                 v65.m30 = (float)((float)(v52.m128_f32[0] * 0.2126729)
			//                                 + (float)(_mm_shuffle_ps(v52, v52, 85).m128_f32[0] * 0.7151522))
			//                         + (float)(_mm_shuffle_ps(v52, v52, 170).m128_f32[0] * 0.072175004);
			//                 v37[3] = *(__m128i *)&v65.m00;
			//                 v9 = hgCamera.fields.camera;
			//                 reflectionProbeViewHandle = hgCamera.fields.reflectionProbeViewHandle;
			//                 if ( v9 )
			//                 {
			//                   worldToCameraMatrix = UnityEngine::Camera::get_worldToCameraMatrix((Matrix4x4 *)&v74, v9, 0LL);
			//                   v55 = *(_OWORD *)&this.fields.unitExtents.m01;
			//                   v56 = passData.fields.reflectionProbeBinningInputDatasCB.ptr;
			//                   *(_OWORD *)&v73.m00 = *(_OWORD *)&this.fields.unitExtents.m00;
			//                   v57 = *(_OWORD *)&this.fields.unitExtents.m02;
			//                   *(_OWORD *)&v73.m01 = v55;
			//                   v58 = *(_OWORD *)&this.fields.unitExtents.m03;
			//                   *(_OWORD *)&v73.m02 = v57;
			//                   v59 = *(_OWORD *)&worldToCameraMatrix.m00;
			//                   *(_OWORD *)&v73.m03 = v58;
			//                   v60 = *(_OWORD *)&worldToCameraMatrix.m01;
			//                   *(_OWORD *)&v65.m00 = v59;
			//                   v61 = *(_OWORD *)&worldToCameraMatrix.m02;
			//                   *(_OWORD *)&v65.m01 = v60;
			//                   v62 = *(_OWORD *)&worldToCameraMatrix.m03;
			//                   v63 = passData.fields.reflectionProbeGlobalDatasCB.ptr;
			//                   *(_OWORD *)&v65.m02 = v61;
			//                   *(_OWORD *)&v65.m03 = v62;
			//                   UnityEngine::HyperGryph::HGReflectionProbe::UpdateViewCBHandle(
			//                     reflectionProbeViewHandle,
			//                     &v65,
			//                     &v73,
			//                     v56,
			//                     v63,
			//                     0LL);
			//                   return;
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_13:
			//     sub_180B536AC(camera, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1719, 0LL);
			//   if ( !Patch )
			//     goto LABEL_13;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_658(
			//     Patch,
			//     (Object *)this,
			//     (Object *)passData,
			//     (Object *)hgCamera,
			//     input,
			//     0LL);
			// }
			// 
		}

		internal void ConstructPass(ref ReflectionProbeBinningPassConstructor.PassInput input, ref ReflectionProbeBinningPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera)
		{
			// // Void ConstructPass(ReflectionProbeBinningPassConstructor+PassInput ByRef, ReflectionProbeBinningPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::ConstructPass(
			//         ReflectionProbeBinningPassConstructor *this,
			//         ReflectionProbeBinningPassConstructor_PassInput *input,
			//         ReflectionProbeBinningPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int64 v13; // rdx
			//   ReflectionProbeBinningPassConstructor_PassData *v14; // rdi
			//   HGSettingParameters *settingParameters; // rcx
			//   Int32Enum__Enum v16; // eax
			//   unsigned __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   unsigned __int64 v19; // r8
			//   signed __int64 v20; // rtt
			//   HGSettingParameters *v21; // rcx
			//   __int64 v22; // rdx
			//   __int64 v23; // rcx
			//   GraphicsFormat__Enum colorFormat; // r14d
			//   __int64 octTextureSize; // rcx
			//   int32_t reflectionProbeOctTextureArrayCount; // r13d
			//   unsigned __int64 v27; // rdx
			//   unsigned __int64 v28; // r8
			//   signed __int64 v29; // rtt
			//   List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *m_previousOctNode; // rcx
			//   ReflectionProbeBinningPassConstructor_PassData *v31; // r14
			//   ComputeBufferHandle v32; // rax
			//   ComputeBufferHandle v33; // rdx
			//   ComputeBufferHandle v34; // rcx
			//   ReflectionProbeBinningPassConstructor_PassData *v35; // r14
			//   __int64 v36; // rdx
			//   __int64 v37; // rcx
			//   TextureHandle v38; // xmm0
			//   ReflectionProbeBinningPassConstructor_PassData *v39; // r14
			//   HGRenderPipeline *currentPipeline; // rax
			//   __int64 v41; // rdx
			//   __int64 v42; // rcx
			//   HGRenderPipelineRuntimeResources *defaultResources; // rax
			//   __int64 v44; // rdx
			//   __int64 v45; // rcx
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
			//   ComputeShader *reflectionProbeBinningCS; // rcx
			//   unsigned __int64 v48; // r8
			//   signed __int64 v49; // rtt
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v51; // rdx
			//   __int64 v52; // rcx
			//   ReflectionProbeBinningPassConstructor_PassData *passData; // [rsp+A0h] [rbp-98h] BYREF
			//   int v54; // [rsp+A8h] [rbp-90h]
			//   TextureHandle v55; // [rsp+B0h] [rbp-88h] BYREF
			//   _QWORD v56[2]; // [rsp+C0h] [rbp-78h] BYREF
			//   HGRenderGraphBuilder v57; // [rsp+D0h] [rbp-68h] BYREF
			//   Il2CppExceptionWrapper *v58; // [rsp+F0h] [rbp-48h] BYREF
			//   HGRenderGraphBuilder v59; // [rsp+F8h] [rbp-40h] BYREF
			// 
			//   if ( !byte_18D919E49 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::PassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::PassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::Clear);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RTHandles);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&off_18D5F0528);
			//     sub_18003C530(&off_18D5F0520);
			//     byte_18D919E49 = 1;
			//   }
			//   passData = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1720, 0LL) )
			//   {
			//     v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x77u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v12, v11);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v59,
			//       renderGraph,
			//       (String *)"Compute Reflection Probe Binning",
			//       (Object **)&passData,
			//       v10,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::PassData>);
			//     v57 = v59;
			//     v56[0] = 0LL;
			//     v56[1] = &v57;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v57, 0, 0LL);
			//       v14 = passData;
			//       settingParameters = input.settingParameters;
			//       if ( !settingParameters )
			//         sub_1802DC2C8(0LL, v13);
			//       v16 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//               (SettingParameter_1_System_Int32Enum_ *)settingParameters.fields._reflectionProbeOctTextureSize_k__BackingField,
			//               MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//       if ( !v14 )
			//         sub_1802DC2C8(v18, v17);
			//       v14.fields.octTextureSize = v16;
			//       if ( this.fields.m_octTextureArray )
			//       {
			//         if ( !hgCamera )
			//           sub_1802DC2C8(v18, v17);
			//         if ( !hgCamera.fields.reflectionProbeReset )
			//           goto LABEL_23;
			//         if ( this.fields.m_octTextureArray )
			//         {
			//           UnityEngine::Rendering::RTHandle::Release(this.fields.m_octTextureArray, 0LL);
			//           this.fields.m_octTextureArray = 0LL;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v19 = (((unsigned __int64)&this.fields.m_octTextureArray >> 12) & 0x1FFFFF) >> 6;
			//             v17 = ((unsigned __int64)&this.fields.m_octTextureArray >> 12) & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v19 + 36190]);
			//             do
			//               v20 = qword_18D6405E0[v19 + 36190];
			//             while ( v20 != _InterlockedCompareExchange64(&qword_18D6405E0[v19 + 36190], v20 | (1LL << v17), v20) );
			//           }
			//         }
			//       }
			//       v21 = input.settingParameters;
			//       if ( !v21 )
			//         sub_1802DC2C8(0LL, v17);
			//       colorFormat = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                       v21.fields._reflectionProbeUseRGBAHalf_k__BackingField,
			//                       MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit)
			//                   ? GraphicsFormat__Enum_R16G16B16A16_SFloat
			//                   : GraphicsFormat__Enum_B10G11R11_UFloatPack32;
			//       if ( !passData )
			//         sub_1802DC2C8(v23, v22);
			//       octTextureSize = (unsigned int)passData.fields.octTextureSize;
			//       v55.handle.m_Value = octTextureSize;
			//       v54 = octTextureSize;
			//       if ( !hgCamera )
			//         sub_1802DC2C8(octTextureSize, v22);
			//       reflectionProbeOctTextureArrayCount = hgCamera.fields.reflectionProbeOctTextureArrayCount;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::RTHandles);
			//       this.fields.m_octTextureArray = UnityEngine::Rendering::RTHandles::Alloc(
			//                                          v55.handle.m_Value + 64,
			//                                          v54 + 64,
			//                                          reflectionProbeOctTextureArrayCount,
			//                                          DepthBits__Enum_None,
			//                                          colorFormat,
			//                                          FilterMode__Enum_Point,
			//                                          TextureWrapMode__Enum_Repeat,
			//                                          TextureDimension__Enum_Tex2DArray,
			//                                          1,
			//                                          1,
			//                                          0,
			//                                          0,
			//                                          1,
			//                                          0.0,
			//                                          MSAASamples__Enum_None,
			//                                          0,
			//                                          RenderTextureMemoryless__Enum_None,
			//                                          (String *)"(c# renderpipeline) Reflection Probe Oct Texture Array",
			//                                          0LL);
			//       if ( dword_18D8E43F8 )
			//       {
			//         v28 = (((unsigned __int64)&this.fields.m_octTextureArray >> 12) & 0x1FFFFF) >> 6;
			//         v27 = ((unsigned __int64)&this.fields.m_octTextureArray >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v28 + 36190]);
			//         do
			//           v29 = qword_18D6405E0[v28 + 36190];
			//         while ( v29 != _InterlockedCompareExchange64(&qword_18D6405E0[v28 + 36190], v29 | (1LL << v27), v29) );
			//       }
			//       m_previousOctNode = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)this.fields.m_previousOctNode;
			//       if ( !m_previousOctNode )
			//         sub_1802DC2C8(0LL, v27);
			//       System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
			//         m_previousOctNode,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::Clear);
			// LABEL_23:
			//       v31 = passData;
			//       v32 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(&v57, &input.binningBuffer, 0LL);
			//       if ( !v31 )
			//         sub_1802DC2C8(v34, v33);
			//       v31.fields.binningBuffer = v32;
			//       v35 = passData;
			//       v55 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                &v55,
			//                renderGraph,
			//                this.fields.m_octTextureArray,
			//                0LL);
			//       v38 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                (TextureHandle *)&v59,
			//                &v57,
			//                &v55,
			//                0LL);
			//       if ( !v35 )
			//         sub_1802DC2C8(v37, v36);
			//       v35.fields.octTextureArray = v38;
			//       v39 = passData;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//       currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//       if ( !currentPipeline )
			//         sub_1802DC2C8(v42, v41);
			//       defaultResources = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(currentPipeline, 0LL);
			//       if ( !defaultResources )
			//         sub_1802DC2C8(v45, v44);
			//       shaders = defaultResources.fields.shaders;
			//       if ( !shaders )
			//         sub_1802DC2C8(v45, v44);
			//       reflectionProbeBinningCS = shaders.fields.reflectionProbeBinningCS;
			//       if ( !v39 )
			//         sub_1802DC2C8(reflectionProbeBinningCS, v44);
			//       v39.fields.computeShader = reflectionProbeBinningCS;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v48 = (((unsigned __int64)&v39.fields.computeShader >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v48 + 36190]);
			//         do
			//           v49 = qword_18D6405E0[v48 + 36190];
			//         while ( v49 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v48 + 36190],
			//                          v49 | (1LL << (((unsigned __int64)&v39.fields.computeShader >> 12) & 0x3F)),
			//                          v49) );
			//       }
			//       HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::PrepareGlobalReflectionProbe(
			//         this,
			//         passData,
			//         hgCamera,
			//         0LL);
			//       HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::PrepareLocalReflectionProbe(
			//         this,
			//         passData,
			//         hgCamera,
			//         input,
			//         0LL);
			//       HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::PrepareConstantBuffer(
			//         this,
			//         passData,
			//         hgCamera,
			//         input,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v57,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor.static_fields.s_RenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::PassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v58 )
			//     {
			//       v56[0] = v58.ex;
			//     }
			//     sub_180222690(v56);
			//     return;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1720, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v52, v51);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_659(
			//     Patch,
			//     (Object *)this,
			//     input,
			//     output,
			//     (Object *)renderGraph,
			//     (Object *)hgCamera,
			//     0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         ReflectionProbeBinningPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1721, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1721, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_340(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         ReflectionProbeBinningPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1722, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1722, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         ReflectionProbeBinningPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1723, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1723, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
		}

		public const int MAX_VISIBLE_COUNT = 32;

		public const int OCT_TEXTURE_PADDING = 32;

		public const float SLICE_Z_LENGTH = 1f;

		public const int XYPLANE_BINNING_GROUP_SIZE = 8;

		public const int ZPLANE_BINING_GROUP_SIZE = 64;

		public const int NUM_FLOAT4_REFLECTION_PROBE_PARAMS = 4;

		public const int NUM_FLOAT4_REFLECTION_PROBE_BINNING_DATA = 4;

		public const int NUM_FLOAT4_REFLECTION_PROBE_BINNING_BUFFER = 132;

		public const int NUM_BYTES_REFLECTION_PROBE_BINNING_BUFFER = 2112;

		public const int NUM_FLOAT4_REFLECTION_PROBE_GLOBAL_DATA = 8;

		public const int NUM_FLOAT4_REFLECTION_PROBE_GLOBAL_BUFFER = 260;

		public const int NUM_BYTES_REFLECTION_PROBE_GLOBAL_BUFFER = 4160;

		public Matrix4x4 unitExtents;

		private bool m_clearDefault;

		private Vector3 m_prevCameraPosition;

		private RTHandle m_octTextureArray;

		private int[] m_blitIndices;

		private Texture[] m_blitTextures;

		private List<ReflectionProbeBinningPassConstructor.OctNode> m_previousOctNode;

		private List<ReflectionProbeBinningPassConstructor.OctNode> m_currrentOctNode;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<ReflectionProbeBinningPassConstructor.PassData> s_RenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct OctNode
		{
			public bool diff(ReflectionProbeBinningPassConstructor.OctNode other)
			{
				// // Boolean diff(ReflectionProbeBinningPassConstructor+OctNode)
				// bool HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode::diff(
				//         ReflectionProbeBinningPassConstructor_OctNode *this,
				//         ReflectionProbeBinningPassConstructor_OctNode *other,
				//         MethodInfo *method)
				// {
				//   __int64 v5; // rdx
				//   Object_1 *texutre; // rcx
				//   int32_t InstanceID; // eax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   ReflectionProbeBinningPassConstructor_OctNode v10; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(1716, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1716, 0LL);
				//     if ( Patch )
				//     {
				//       v10 = *other;
				//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_657(Patch, this, &v10, 0LL);
				//     }
				// LABEL_8:
				//     sub_180B536AC(texutre, v5);
				//   }
				//   texutre = (Object_1 *)this.texutre;
				//   if ( !this.texutre )
				//     goto LABEL_8;
				//   InstanceID = UnityEngine::Object::GetInstanceID(texutre, 0LL);
				//   texutre = (Object_1 *)other.texutre;
				//   if ( !other.texutre )
				//     goto LABEL_8;
				//   return InstanceID != UnityEngine::Object::GetInstanceID(texutre, 0LL)
				//       || fabs(this.factor - other.factor) >= 0.0099999998;
				// }
				// 
				return default(bool);
			}

			public Cubemap texutre;

			public float factor;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			internal ScriptableRenderContext srpContext;

			internal BinningPass.BinningData binningData;

			internal ComputeBufferHandle binningBuffer;

			internal HGSettingParameters settingParameters;
		}

		internal struct PassOutput
		{
		}

		private class PassData
		{
			public PassData()
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

			public int xyBinningThreadGroupX;

			public int xyBinningThreadGroupY;

			public int xyBinningThreadGroupZ;

			public int zBinningThreadGroupX;

			public int zBinningThreadGroupY;

			public int zBinningThreadGroupZ;

			public CBHandle reflectionProbeBinningInputDatasCB;

			public CBHandle reflectionProbeGlobalDatasCB;

			public ComputeBufferHandle binningBuffer;

			public ComputeShader computeShader;

			public int octTextureSize;

			public bool clearDefault;

			public bool renderBlend;

			public List<ReflectionProbeBinningPassConstructor.OctNode> currrentOctNode;

			public int blitCount;

			public int[] blitIndices;

			public Texture[] blitTextures;

			public TextureHandle octTextureArray;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
		private struct ReflectionProbeBlendData
		{
			public Vector4 param0;

			public Vector4 param1;

			public Vector4 param2;

			public Vector4 param3;
		}
	}
}
