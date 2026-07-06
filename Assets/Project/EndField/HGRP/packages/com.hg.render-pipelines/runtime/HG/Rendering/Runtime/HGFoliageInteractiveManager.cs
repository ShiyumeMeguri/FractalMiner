using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	public class HGFoliageInteractiveManager
	{
		public HGFoliageInteractiveManager()
		{
			// // HGFoliageInteractiveManager()
			// void HG::Rendering::Runtime::HGFoliageInteractiveManager::HGFoliageInteractiveManager(
			//         HGFoliageInteractiveManager *this,
			//         MethodInfo *method)
			// {
			//   HGFoliageInteractiveConfig *defaultConfig; // rax
			//   int32_t graphicsFormat; // ecx
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v5; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   List_1_HG_Rendering_Runtime_HGFoliageInteract_ *v8; // rdi
			//   OneofDescriptorProto *v9; // rdx
			//   FileDescriptor *v10; // r8
			//   MessageDescriptor *v11; // r9
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v12; // rax
			//   List_1_HG_Rendering_Runtime_HGFoliageInteractRaft_ *v13; // rdi
			//   OneofDescriptorProto *v14; // rdx
			//   FileDescriptor *v15; // r8
			//   MessageDescriptor *v16; // r9
			//   Dictionary_2_System_Int32_Beyond_UI_UIText_RichTextAnalyzer_RichTextTag_ *v17; // rax
			//   Dictionary_2_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ *v18; // rdi
			//   OneofDescriptorProto *v19; // rdx
			//   FileDescriptor *v20; // r8
			//   MessageDescriptor *v21; // r9
			//   LowLevelList_1_System_Object_ *v22; // rax
			//   List_1_UnityEngine_Vector3_ *v23; // rdi
			//   OneofDescriptorProto *v24; // rdx
			//   FileDescriptor *v25; // r8
			//   MessageDescriptor *v26; // r9
			//   __int64 v27; // rax
			//   float v28; // ecx
			//   String__Array *v29; // [rsp+20h] [rbp-28h] BYREF
			//   String *v30; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v31; // [rsp+30h] [rbp-18h]
			// 
			//   if ( !byte_18D8EDCB7 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::Dictionary);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGFoliageInteractiveConfig);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteractRaft>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteract>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<UnityEngine::Vector3>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteractRaft>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteract>);
			//     byte_18D8EDCB7 = 1;
			//   }
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGFoliageInteractiveConfig._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGFoliageInteractiveConfig, method);
			//   defaultConfig = HG::Rendering::Runtime::HGFoliageInteractiveConfig::get_defaultConfig(
			//                     (HGFoliageInteractiveConfig *)&v29,
			//                     0LL);
			//   graphicsFormat = defaultConfig.graphicsFormat;
			//   *(_OWORD *)&this.fields.m_config.textureSize.m_X = *(_OWORD *)&defaultConfig.textureSize.m_X;
			//   this.fields.m_config.graphicsFormat = graphicsFormat;
			//   v5 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteract>);
			//   v8 = (List_1_HG_Rendering_Runtime_HGFoliageInteract_ *)v5;
			//   if ( !v5 )
			//     goto LABEL_6;
			//   System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//     v5,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteract>::List);
			//   this.fields.m_externInteracts = v8;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_externInteracts, v9, v10, v11, v29, v30, v31);
			//   v12 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteractRaft>);
			//   v13 = (List_1_HG_Rendering_Runtime_HGFoliageInteractRaft_ *)v12;
			//   if ( !v12 )
			//     goto LABEL_6;
			//   System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//     v12,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteractRaft>::List);
			//   this.fields.m_interactRaftList = v13;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_interactRaftList, v14, v15, v16, v29, v30, v31);
			//   v17 = (Dictionary_2_System_Int32_Beyond_UI_UIText_RichTextAnalyzer_RichTextTag_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>);
			//   v18 = (Dictionary_2_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ *)v17;
			//   if ( !v17
			//     || (System::Collections::Generic::Dictionary<int,Beyond::UI::UIText_RichTextAnalyzer::RichTextTag>::Dictionary(
			//           v17,
			//           MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::Dictionary),
			//         this.fields.m_interactMeshMatrixDict = v18,
			//         sub_1800054D0((OneofDescriptor *)&this.fields.m_interactMeshMatrixDict, v19, v20, v21, v29, v30, v31),
			//         v22 = (LowLevelList_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector3>),
			//         (v23 = (List_1_UnityEngine_Vector3_ *)v22) == 0LL) )
			//   {
			// LABEL_6:
			//     sub_180B536AC(v7, v6);
			//   }
			//   System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
			//     v22,
			//     MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::List);
			//   this.fields.m_characterPoses = v23;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_characterPoses, v24, v25, v26, v29, v30, v31);
			//   v27 = sub_18281C140(&v29);
			//   v28 = *(float *)(v27 + 8);
			//   *(_QWORD *)&this.fields.m_centerPos.x = *(_QWORD *)v27;
			//   this.fields.m_centerPos.z = v28;
			// }
			// 
		}

		public void Initialize(Mesh characterColliderMesh, HGSettingParameters settingParameters)
		{
			// // Void Initialize(Mesh, HGSettingParameters)
			// void HG::Rendering::Runtime::HGFoliageInteractiveManager::Initialize(
			//         HGFoliageInteractiveManager *this,
			//         Mesh *characterColliderMesh,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v7; // rdx
			//   FileDescriptor *v8; // r8
			//   MessageDescriptor *v9; // r9
			//   __int64 v10; // rdx
			//   Object_1 *m_characterColliderMesh; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *methoda; // [rsp+20h] [rbp-18h]
			//   String *v14; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v15; // [rsp+30h] [rbp-8h]
			// 
			//   if ( !byte_18D8EDCB8 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     byte_18D8EDCB8 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1413, 0LL) )
			//   {
			//     this.fields.m_characterColliderMesh = characterColliderMesh;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.m_characterColliderMesh,
			//       v7,
			//       v8,
			//       v9,
			//       (String__Array *)methoda,
			//       v14,
			//       v15);
			//     m_characterColliderMesh = (Object_1 *)this.fields.m_characterColliderMesh;
			//     if ( m_characterColliderMesh )
			//     {
			//       this.fields.m_characterColliderMeshID = UnityEngine::Object::GetInstanceID(m_characterColliderMesh, 0LL);
			//       if ( settingParameters )
			//       {
			//         this.fields.m_enabled = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                                    settingParameters.fields._foliageInteractiveEnable_k__BackingField,
			//                                    MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//         return;
			//       }
			//     }
			// LABEL_7:
			//     sub_180B536AC(m_characterColliderMesh, v10);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1413, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//     (ILFixDynamicMethodWrapper_28 *)Patch,
			//     (Object *)this,
			//     (Object *)characterColliderMesh,
			//     (Object *)settingParameters,
			//     0LL);
			// }
			// 
		}

		public void RefreshFoliageInteractiveSettingParams(HGSettingParameters settingParameters)
		{
			// // Void RefreshFoliageInteractiveSettingParams(HGSettingParameters)
			// void HG::Rendering::Runtime::HGFoliageInteractiveManager::RefreshFoliageInteractiveSettingParams(
			//         HGFoliageInteractiveManager *this,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDCB9 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     byte_18D8EDCB9 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(422, 0LL) )
			//   {
			//     if ( settingParameters )
			//     {
			//       this.fields.m_enabled = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                                  settingParameters.fields._foliageInteractiveEnable_k__BackingField,
			//                                  MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//       return;
			//     }
			// LABEL_6:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(422, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)settingParameters,
			//     0LL);
			// }
			// 
		}

		public void Dispose()
		{
			// // Void Dispose()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGFoliageInteractiveManager::Dispose(
			//         HGFoliageInteractiveManager *this,
			//         MethodInfo *method)
			// {
			//   Object *v2; // rbx
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   __int64 *v5; // rdx
			//   Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *monitor; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   __int64 v10; // [rsp+0h] [rbp-C8h] BYREF
			//   Il2CppException *ex; // [rsp+20h] [rbp-A8h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ *v12; // [rsp+28h] [rbp-A0h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ v13; // [rsp+30h] [rbp-98h] BYREF
			//   Il2CppExceptionWrapper *v14; // [rsp+68h] [rbp-60h] BYREF
			//   NativeList_1_UnityEngine_Matrix4x4_ v15; // [rsp+70h] [rbp-58h] BYREF
			//   __int64 v16; // [rsp+80h] [rbp-48h]
			//   char v17[64]; // [rsp+88h] [rbp-40h] BYREF
			// 
			//   v2 = (Object *)this;
			//   if ( !byte_18D919DCE )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteract>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteractRaft>::Clear);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::Dispose);
			//     byte_18D919DCE = 1;
			//   }
			//   memset(&v13, 0, sizeof(v13));
			//   if ( IFix::WrappersManagerImpl::IsPatched(1414, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1414, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, v2, 0LL);
			//   }
			//   else
			//   {
			//     if ( !v2[4].monitor )
			//       sub_180B536AC(v4, v3);
			//     v13 = *(Dictionary_2_TKey_TValue_Enumerator_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ *)sub_180318DB4(v17, v2[4].monitor);
			//     ex = 0LL;
			//     v12 = &v13;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::MoveNext(
			//                 &v13,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::MoveNext) )
			//       {
			//         v15 = *(NativeList_1_UnityEngine_Matrix4x4_ *)&v13._current.value.mesh;
			//         v16 = *(_QWORD *)&v13._current.value.matrixs.m_DeprecatedAllocator.Index;
			//         Unity::Collections::NativeList<UnityEngine::Matrix4x4>::Dispose(
			//           (NativeList_1_UnityEngine_Matrix4x4_ *)&v15.m_DeprecatedAllocator,
			//           MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::Dispose);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v14 )
			//     {
			//       v5 = &v10;
			//       ex = v14.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v2 = (Object *)this;
			//     }
			//     monitor = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v2[3].monitor;
			//     if ( !monitor
			//       || (sub_1823B99D0(
			//             monitor,
			//             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteract>::Clear),
			//           (monitor = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v2[4].monitor) == 0LL)
			//       || (System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::Clear(
			//             monitor,
			//             MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::Clear),
			//           (monitor = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v2[3].klass) == 0LL)
			//       || (++HIDWORD(monitor.fields._entries),
			//           LODWORD(monitor.fields._entries) = 0,
			//           (monitor = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v2[4].klass) == 0LL) )
			//     {
			//       sub_1802DC2C8(monitor, v5);
			//     }
			//     sub_1823B99D0(
			//       monitor,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteractRaft>::Clear);
			//   }
			// }
			// 
		}

		public void GetCenter(out Vector3 centerPosition, out Vector3 centerSize)
		{
			// // Void GetCenter(Vector3 ByRef, Vector3 ByRef)
			// void HG::Rendering::Runtime::HGFoliageInteractiveManager::GetCenter(
			//         HGFoliageInteractiveManager *this,
			//         Vector3 *centerPosition,
			//         Vector3 *centerSize,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __m128 centerOffsetHeight_low; // xmm1
			//   Vector3 *v10; // rax
			//   __int64 v11; // rdx
			//   float z; // ecx
			//   struct HGFoliageInteractiveConfig__Class *v13; // rax
			//   HGFoliageInteractiveConfig__StaticFields *static_fields; // rax
			//   System::MathF *z_low; // rcx
			//   __int64 v16; // xmm7_8
			//   float v17; // xmm1_4
			//   float v18; // xmm0_4
			//   float v19; // xmm6_4
			//   float m_Y; // xmm1_4
			//   float v21; // xmm0_4
			//   System::MathF *v22; // rcx
			//   float v23; // xmm2_4
			//   float v24; // xmm1_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v26; // [rsp+30h] [rbp-58h] BYREF
			//   Vector3 v27; // [rsp+40h] [rbp-48h] BYREF
			//   Vector3 v28; // [rsp+50h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D8EDCBA )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGFoliageInteractiveConfig);
			//     byte_18D8EDCBA = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, centerPosition);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_12;
			//   if ( wrapperArray.max_length.size > 1415 )
			//   {
			//     if ( !v7._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v7, wrapperArray);
			//       v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7.static_fields.wrapperArray;
			//     if ( v7 )
			//     {
			//       if ( LODWORD(v7._0.namespaze) <= 0x587 )
			//         sub_180070270(v7, wrapperArray);
			//       if ( !v7[30]._0.castClass )
			//         goto LABEL_9;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1415, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_536(Patch, (Object *)this, centerPosition, centerSize, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(v7, wrapperArray);
			//   }
			// LABEL_9:
			//   centerOffsetHeight_low = (__m128)LODWORD(this.fields.m_config.centerOffsetHeight);
			//   v27.z = this.fields.m_centerPos.z;
			//   *(_QWORD *)&v26.x = _mm_unpacklo_ps((__m128)0LL, centerOffsetHeight_low).m128_u64[0];
			//   *(_QWORD *)&v27.x = *(_QWORD *)&this.fields.m_centerPos.x;
			//   v26.z = 0.0;
			//   v10 = UnityEngine::Vector3::op_Addition(&v28, &v27, &v26, method);
			//   z = v10.z;
			//   *(_QWORD *)&centerPosition.x = *(_QWORD *)&v10.x;
			//   centerPosition.z = z;
			//   v13 = TypeInfo::HG::Rendering::Runtime::HGFoliageInteractiveConfig;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGFoliageInteractiveConfig._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGFoliageInteractiveConfig, v11);
			//     v13 = TypeInfo::HG::Rendering::Runtime::HGFoliageInteractiveConfig;
			//   }
			//   static_fields = v13.static_fields;
			//   z_low = (System::MathF *)LODWORD(static_fields.FOLIAGE_INTERACTIVE_CENTER_SIZE.z);
			//   *(_QWORD *)&centerSize.x = *(_QWORD *)&static_fields.FOLIAGE_INTERACTIVE_CENTER_SIZE.x;
			//   LODWORD(centerSize.z) = (_DWORD)z_low;
			//   v16 = *(_QWORD *)&centerPosition.x;
			//   v17 = centerSize.x / (float)this.fields.m_config.textureSize.m_X;
			//   v18 = centerPosition.x / v17;
			//   System::MathF::Floor(z_low, v17);
			//   v19 = v18 * (float)(centerSize.x / (float)this.fields.m_config.textureSize.m_X);
			//   m_Y = (float)this.fields.m_config.textureSize.m_Y;
			//   v21 = centerPosition.z / (float)(centerSize.z / m_Y);
			//   System::MathF::Floor(v22, m_Y);
			//   *(float *)&v16 = v19;
			//   v23 = centerSize.z;
			//   v24 = (float)this.fields.m_config.textureSize.m_Y;
			//   *(_QWORD *)&centerPosition.x = v16;
			//   centerPosition.z = v21 * (float)(v23 / v24);
			// }
			// 
		}

		public Dictionary<int, HGFoliageInteractiveMeshMatrixes> GetAllColliders()
		{
			// // Dictionary`2[System.Int32,HG.Rendering.Runtime.HGFoliageInteractiveMeshMatrixes] GetAllColliders()
			// Dictionary_2_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ *HG::Rendering::Runtime::HGFoliageInteractiveManager::GetAllColliders(
			//         HGFoliageInteractiveManager *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1416, 0LL) )
			//     return this.fields.m_interactMeshMatrixDict;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1416, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_537(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public void GameplayUpdate()
		{
			// // Void GameplayUpdate()
			// // Hidden C++ exception states: #wind=3
			// void HG::Rendering::Runtime::HGFoliageInteractiveManager::GameplayUpdate(
			//         HGFoliageInteractiveManager *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v5; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   MethodInfo *v9; // rdx
			//   Quaternion *identity; // rax
			//   __m128 Proto_k__BackingField_high; // xmm2
			//   __m128 Proto_k__BackingField_low; // xmm0
			//   void (__fastcall *v13)(Vector3 *, __m256i *, OneofDescriptorProto **, Matrix4x4 *); // rax
			//   void (__fastcall *v14)(Matrix4x4 *, OneofDescriptor *); // rax
			//   OneofDescriptorProto *v15; // rdx
			//   __int64 v16; // rcx
			//   FileDescriptor *v17; // r8
			//   MessageDescriptor *v18; // r9
			//   __int128 v19; // xmm11
			//   __int128 v20; // xmm12
			//   __int128 v21; // xmm13
			//   __int128 v22; // xmm14
			//   Dictionary_2_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ *m_interactMeshMatrixDict; // rbx
			//   signed __int64 v24; // rcx
			//   MessageDescriptor *v25; // r9
			//   unsigned __int64 v26; // rdx
			//   unsigned int v27; // eax
			//   __int64 v28; // r8
			//   FileDescriptor *v29; // r8
			//   __int32 v30; // ebx
			//   __int128 v31; // xmm6
			//   __int64 v32; // xmm7_8
			//   Il2CppClass *klass; // rcx
			//   OneofDescriptorProto *v34; // rdx
			//   FileDescriptor *v35; // r8
			//   MessageDescriptor *v36; // r9
			//   unsigned __int64 v37; // xmm1_8
			//   HGFoliageInteractiveManager *v38; // r13
			//   List_1_HG_Rendering_Runtime_HGFoliageInteract_ *m_externInteracts; // r9
			//   unsigned __int64 v40; // rdx
			//   signed __int64 v41; // rtt
			//   Component *current; // r14
			//   Object_1 *v43; // rbx
			//   int32_t InstanceID; // eax
			//   __int64 v45; // rdx
			//   int32_t v46; // edi
			//   Dictionary_2_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ *v47; // rcx
			//   __int64 v48; // rcx
			//   __int64 v49; // r8
			//   __int64 v50; // r9
			//   Dictionary_2_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ *v51; // rsi
			//   Il2CppClass *v52; // rcx
			//   Il2CppClass *v53; // rax
			//   _QWORD *rgctxDataDummy; // rcx
			//   __int64 v55; // rax
			//   __int64 v56; // rax
			//   __int64 v57; // rbx
			//   __int64 v58; // rdx
			//   __int64 v59; // rcx
			//   Dictionary_2_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ *v60; // rdx
			//   Transform *transform; // rax
			//   __int64 v62; // rdx
			//   __int64 v63; // rcx
			//   Matrix4x4 *localToWorldMatrix; // rax
			//   void (__fastcall *v65)(Matrix4x4 *, Matrix4x4 *, OneofDescriptor *); // rax
			//   UnsafeList_1_UnityEngine_Matrix4x4_ *m_ListData; // rbx
			//   Il2CppClass *v67; // rax
			//   Mesh *m_characterColliderMesh; // r13
			//   unsigned int v69; // r8d
			//   __int64 v70; // rbx
			//   void (__fastcall __noreturn **v71)(); // rax
			//   unsigned int v72; // eax
			//   unsigned int v73; // r8d
			//   __int64 v74; // rax
			//   void (__fastcall __noreturn **v75)(); // rbx
			//   __int64 v76; // r8
			//   signed __int64 v77; // r9
			//   char v78; // r8
			//   signed __int64 v79; // rtt
			//   __int64 v80; // rbx
			//   __int64 v81; // rax
			//   __int64 v82; // rbx
			//   _QWORD **v83; // rcx
			//   __int64 v84; // r8
			//   __int64 v85; // rax
			//   unsigned int v86; // r8d
			//   __int64 v87; // rdi
			//   unsigned int v88; // eax
			//   unsigned int v89; // r8d
			//   __int64 v90; // rax
			//   __int64 v91; // r8
			//   signed __int64 v92; // r9
			//   char v93; // r8
			//   signed __int64 v94; // rtt
			//   __int64 v95; // rbx
			//   __int64 v96; // rax
			//   __int64 v97; // rbx
			//   _QWORD **v98; // rcx
			//   __int64 v99; // r8
			//   __int64 v100; // rax
			//   HGFoliageInteractiveManager *v101; // r15
			//   List_1_UnityEngine_Vector3_ *m_characterPoses; // r9
			//   signed __int64 v103; // rtt
			//   __int64 v104; // rax
			//   __int64 v105; // rdx
			//   __int64 v106; // rdx
			//   __int64 v107; // rcx
			//   Dictionary_2_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ *v108; // rsi
			//   int32_t m_characterColliderMeshID; // r14d
			//   struct MethodInfo *v110; // rbx
			//   unsigned __int64 v111; // rdx
			//   __int64 v112; // rcx
			//   signed __int64 v113; // rtt
			//   Il2CppClass *v114; // rcx
			//   Il2CppClass *v115; // rax
			//   _QWORD *v116; // rcx
			//   __int64 v117; // rax
			//   __int64 v118; // rax
			//   __int64 v119; // rbx
			//   __int64 *v120; // rax
			//   __int64 v121; // r14
			//   signed __int64 v122; // rcx
			//   unsigned int v123; // r8d
			//   __int64 v124; // rax
			//   __int64 v125; // rax
			//   __int64 *v126; // rax
			//   __int64 v127; // rsi
			//   signed __int64 v128; // rcx
			//   unsigned int v129; // r8d
			//   __int64 v130; // rax
			//   __int64 v131; // rax
			//   _QWORD *v132; // rax
			//   __int64 v133; // rax
			//   __int64 v134; // rbx
			//   _QWORD *v135; // rax
			//   __int64 v136; // rcx
			//   Void *v137; // r15
			//   __int64 v138; // rdx
			//   __int64 v139; // rcx
			//   InsertionBehavior__Enum v140; // r9d
			//   __int32 v141; // ebx
			//   __int64 v142; // rax
			//   __int64 v143; // rsi
			//   __int64 v144; // rcx
			//   __int64 *v145; // rax
			//   __int64 v146; // rsi
			//   signed __int64 v147; // rcx
			//   unsigned int v148; // r8d
			//   __int64 v149; // rax
			//   __int64 v150; // rax
			//   __int64 v151; // rax
			//   __int64 v152; // rax
			//   __int64 v153; // rbx
			//   _QWORD *v154; // rax
			//   __int64 v155; // rcx
			//   Void *v156; // rbx
			//   __int64 v157; // rcx
			//   int v158; // eax
			//   OneofDescriptor__Class *v159; // r14
			//   __int64 v160; // rcx
			//   int32_t v161; // r13d
			//   __int64 v162; // rsi
			//   signed __int64 v163; // rcx
			//   unsigned int v164; // r8d
			//   __int64 v165; // rax
			//   __int64 v166; // rax
			//   _QWORD *v167; // rax
			//   __int64 v168; // rax
			//   __int64 v169; // rbx
			//   _QWORD *v170; // rax
			//   __int64 v171; // rcx
			//   __int64 v172; // rbx
			//   signed __int64 v173; // rcx
			//   unsigned int v174; // r8d
			//   __int64 v175; // rax
			//   __int64 v176; // rax
			//   __int64 v177; // rdx
			//   _QWORD *v178; // rax
			//   __int64 v179; // rbx
			//   __int64 v180; // rsi
			//   struct MethodInfo *v181; // rbx
			//   Mesh *mesh; // r13
			//   Dictionary_2_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ *v183; // rsi
			//   int32_t v184; // r14d
			//   struct MethodInfo *v185; // rbx
			//   int32_t Entry; // eax
			//   __int64 v187; // rdx
			//   Dictionary_2_TKey_TValue_Entry_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes___Array *entries; // rcx
			//   double v189; // xmm0_8
			//   int v190; // xmm8_4
			//   __m128 v191; // xmm0
			//   __m128 v192; // xmm7
			//   __m128 v193; // xmm0
			//   UnsafeList_1_UnityEngine_Matrix4x4_ *v194; // rbx
			//   Il2CppClass *v195; // rax
			//   Il2CppClass *v196; // rcx
			//   __int64 v197; // rax
			//   __int64 v198; // rax
			//   __int64 v199; // rax
			//   __int64 v200; // rax
			//   __int64 v201; // r8
			//   Object *v202; // rax
			//   _BYTE v203[32]; // [rsp+0h] [rbp-428h] BYREF
			//   MethodInfo *methoda; // [rsp+20h] [rbp-408h]
			//   MethodInfo *v205; // [rsp+28h] [rbp-400h]
			//   HGFoliageInteractiveMeshMatrixes v206; // [rsp+30h] [rbp-3F8h] BYREF
			//   __m256i v207; // [rsp+50h] [rbp-3D8h] BYREF
			//   __m256i v208; // [rsp+70h] [rbp-3B8h] BYREF
			//   Vector3 centerPosition; // [rsp+90h] [rbp-398h] BYREF
			//   HGFoliageInteractiveMeshMatrixes v210; // [rsp+A0h] [rbp-388h] BYREF
			//   OneofDescriptor block; // [rsp+C0h] [rbp-368h] BYREF
			//   __int64 v212; // [rsp+110h] [rbp-318h]
			//   int32_t v213; // [rsp+120h] [rbp-308h]
			//   __int32 v214; // [rsp+124h] [rbp-304h]
			//   Vector3 v215; // [rsp+130h] [rbp-2F8h] BYREF
			//   __m256i v216; // [rsp+140h] [rbp-2E8h] BYREF
			//   __int128 v217; // [rsp+160h] [rbp-2C8h] BYREF
			//   __m256i v218; // [rsp+170h] [rbp-2B8h] BYREF
			//   IList_1_Google_Protobuf_Reflection_FieldDescriptor_ *fields; // [rsp+190h] [rbp-298h]
			//   Matrix4x4 value; // [rsp+1A0h] [rbp-288h] BYREF
			//   List_1_T_Enumerator_System_Object_ v221; // [rsp+1E0h] [rbp-248h] BYREF
			//   Matrix4x4 v222; // [rsp+200h] [rbp-228h] BYREF
			//   HGFoliageInteractiveManager *v223; // [rsp+240h] [rbp-1E8h]
			//   __int64 v224; // [rsp+248h] [rbp-1E0h]
			//   HGFoliageInteractiveMeshMatrixes v225; // [rsp+260h] [rbp-1C8h] BYREF
			//   Matrix4x4 v226; // [rsp+280h] [rbp-1A8h] BYREF
			//   Matrix4x4 v227; // [rsp+2C0h] [rbp-168h] BYREF
			//   Il2CppExceptionWrapper *v228; // [rsp+300h] [rbp-128h] BYREF
			//   Il2CppExceptionWrapper *v229; // [rsp+308h] [rbp-120h] BYREF
			//   Il2CppExceptionWrapper *v230; // [rsp+310h] [rbp-118h] BYREF
			//   Matrix4x4 v231[3]; // [rsp+318h] [rbp-110h] BYREF
			//   __int64 allocator; // [rsp+440h] [rbp+18h] BYREF
			//   int v234; // [rsp+448h] [rbp+20h]
			// 
			//   v223 = this;
			//   if ( !byte_18D8EDCBB )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGFoliageInteract>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGFoliageInteract>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGFoliageInteract>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteract>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::Add);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::Clear);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::NativeList);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDCBB = 1;
			//   }
			//   *(_QWORD *)&centerPosition.x = 0LL;
			//   centerPosition.z = 0.0;
			//   block.fields._Proto_k__BackingField = 0LL;
			//   *(_DWORD *)&block.fields._IsSynthetic_k__BackingField = 0;
			//   memset(&v206, 0, sizeof(v206));
			//   memset(&v221, 0, sizeof(v221));
			//   memset(&v216, 0, sizeof(v216));
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v3, method);
			//   if ( wrapperArray.max_length.size > 1417 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, method);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = v3.static_fields.wrapperArray;
			//     if ( !v5 )
			//       sub_180B536AC(v3, method);
			//     if ( v5.max_length.size <= 0x589u )
			//       sub_180070270(v3, method);
			//     if ( v5[39].vector[13] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1417, 0LL);
			//       if ( !Patch )
			//         sub_180B536AC(v8, v7);
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			//   }
			//   if ( !this.fields.m_enabled )
			//     return;
			//   HG::Rendering::Runtime::HGFoliageInteractiveManager::GetCenter(
			//     this,
			//     &centerPosition,
			//     (Vector3 *)&block.fields._Proto_k__BackingField,
			//     0LL);
			//   identity = UnityEngine::Quaternion::get_identity((Quaternion *)&v207, v9);
			//   Proto_k__BackingField_high = (__m128)HIDWORD(block.fields._Proto_k__BackingField);
			//   Proto_k__BackingField_high.m128_f32[0] = *((float *)&block.fields._Proto_k__BackingField + 1) * 0.5;
			//   Proto_k__BackingField_low = (__m128)LODWORD(block.fields._Proto_k__BackingField);
			//   Proto_k__BackingField_low.m128_f32[0] = *(float *)&block.fields._Proto_k__BackingField * 0.5;
			//   block.fields._Proto_k__BackingField = (OneofDescriptorProto *)_mm_unpacklo_ps(
			//                                                                   Proto_k__BackingField_low,
			//                                                                   Proto_k__BackingField_high).m128_u64[0];
			//   *(float *)&block.fields._IsSynthetic_k__BackingField = *(float *)&block.fields._IsSynthetic_k__BackingField * 0.5;
			//   *(Quaternion *)v208.m256i_i8 = *identity;
			//   v215 = centerPosition;
			//   memset(&value, 0, sizeof(value));
			//   v13 = (void (__fastcall *)(Vector3 *, __m256i *, OneofDescriptorProto **, Matrix4x4 *))qword_18D8F4BC8;
			//   if ( !qword_18D8F4BC8 )
			//   {
			//     v13 = (void (__fastcall *)(Vector3 *, __m256i *, OneofDescriptorProto **, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                                              "UnityEngine.Matrix4x4::TRS_"
			//                                                                                              "Injected(UnityEngine.Vector"
			//                                                                                              "3&,UnityEngine.Quaternion&,"
			//                                                                                              "UnityEngine.Vector3&,UnityE"
			//                                                                                              "ngine.Matrix4x4&)");
			//     if ( !v13 )
			//     {
			//       v197 = sub_1802DBBE8(
			//                "UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,Uni"
			//                "tyEngine.Matrix4x4&)");
			//       sub_18000F750(v197, 0LL);
			//     }
			//     qword_18D8F4BC8 = (__int64)v13;
			//   }
			//   v13(&v215, &v208, &block.fields._Proto_k__BackingField, &value);
			//   v222 = value;
			//   memset(&block, 0, 64);
			//   v14 = (void (__fastcall *)(Matrix4x4 *, OneofDescriptor *))qword_18D8F4BD0;
			//   if ( !qword_18D8F4BD0 )
			//   {
			//     v14 = (void (__fastcall *)(Matrix4x4 *, OneofDescriptor *))il2cpp_resolve_icall_0(
			//                                                                  "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Mat"
			//                                                                  "rix4x4&,UnityEngine.Matrix4x4&)");
			//     if ( !v14 )
			//     {
			//       v198 = sub_1802DBBE8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
			//       sub_18000F750(v198, 0LL);
			//     }
			//     qword_18D8F4BD0 = (__int64)v14;
			//   }
			//   v14(&v222, &block);
			//   v19 = *(_OWORD *)&block.klass;
			//   *(_OWORD *)&v222.m00 = *(_OWORD *)&block.klass;
			//   v20 = *(_OWORD *)&block.fields._._Index_k__BackingField;
			//   *(_OWORD *)&v222.m01 = *(_OWORD *)&block.fields._._Index_k__BackingField;
			//   v21 = *(_OWORD *)&block.fields._._File_k__BackingField;
			//   *(_OWORD *)&v222.m02 = *(_OWORD *)&block.fields._._File_k__BackingField;
			//   v22 = *(_OWORD *)&block.fields.fields;
			//   *(_OWORD *)&v222.m03 = *(_OWORD *)&block.fields.fields;
			//   m_interactMeshMatrixDict = this.fields.m_interactMeshMatrixDict;
			//   if ( !m_interactMeshMatrixDict )
			//     sub_180B536AC(v16, v15);
			//   memset(&block.monitor, 0, 48);
			//   block.klass = (OneofDescriptor__Class *)m_interactMeshMatrixDict;
			//   sub_1800054D0(&block, v15, v17, v18, (String__Array *)methoda, (String *)v205, (MethodInfo *)v206.mesh);
			//   block.monitor = (MonitorData *)(unsigned int)m_interactMeshMatrixDict.fields._version;
			//   LODWORD(block.fields.fields) = 2;
			//   memset(&block.fields, 0, 32);
			//   v217 = *(_OWORD *)&block.klass;
			//   memset(&v218, 0, sizeof(v218));
			//   fields = block.fields.fields;
			//   v208.m256i_i64[0] = 0LL;
			//   v208.m256i_i64[1] = (__int64)&v217;
			//   try
			//   {
			// LABEL_26:
			//     v26 = v217;
			//     if ( !(_QWORD)v217 )
			//       sub_1802DC2C8(v24, 0LL);
			//     if ( DWORD2(v217) != *(_DWORD *)(v217 + 44) )
			//       System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
			//     v27 = HIDWORD(v217);
			//     while ( v27 < *(_DWORD *)(v217 + 32) )
			//     {
			//       v24 = *(_QWORD *)(v217 + 24);
			//       v28 = (int)v27++;
			//       HIDWORD(v217) = v27;
			//       if ( !v24 )
			//         sub_1802DC2C8(0LL, v217);
			//       if ( (unsigned int)v28 >= *(_DWORD *)(v24 + 24) )
			//         sub_180070260(v24, v217, v28, v25);
			//       v29 = (FileDescriptor *)(5 * v28);
			//       if ( *(int *)(v24 + 8LL * (_QWORD)v29 + 32) >= 0 )
			//       {
			//         v30 = *(_DWORD *)(v24 + 8LL * (_QWORD)v29 + 40);
			//         memset(&v207, 0, sizeof(v207));
			//         v31 = *(_OWORD *)(v24 + 8LL * (_QWORD)v29 + 48);
			//         v32 = *(_QWORD *)(v24 + 8LL * (_QWORD)v29 + 64);
			//         klass = MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::MoveNext.klass;
			//         if ( ((__int64)klass.vtable[0].methodPtr & 1) == 0 )
			//           sub_18003C700(klass);
			//         v207.m256i_i32[0] = v30;
			//         *(_OWORD *)&v207.m256i_u64[1] = v31;
			//         v207.m256i_i64[3] = v32;
			//         sub_1800054D0(
			//           (OneofDescriptor *)&v207.m256i_u64[1],
			//           (OneofDescriptorProto *)v26,
			//           v29,
			//           v25,
			//           (String__Array *)methoda,
			//           (String *)v205,
			//           (MethodInfo *)v206.mesh);
			//         v218 = v207;
			//         sub_1800054D0(
			//           (OneofDescriptor *)&v218.m256i_u64[1],
			//           v34,
			//           v35,
			//           v36,
			//           (String__Array *)methoda,
			//           (String *)v205,
			//           (MethodInfo *)v206.mesh);
			//         v206 = *(HGFoliageInteractiveMeshMatrixes *)&v218.m256i_u64[1];
			//         v37 = _mm_srli_si128(*(__m128i *)&v218.m256i_u64[1], 8).m128i_u64[0];
			//         v24 = (signed __int64)MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::Clear.klass;
			//         if ( (*(_BYTE *)(v24 + 312) & 1) == 0 )
			//           sub_18003C700(v24);
			//         *(_DWORD *)(v37 + 8) = 0;
			//         goto LABEL_26;
			//       }
			//     }
			//     HIDWORD(v217) = *(_DWORD *)(v217 + 32) + 1;
			//     memset(&v218, 0, sizeof(v218));
			//   }
			//   catch ( Il2CppExceptionWrapper *v228 )
			//   {
			//     v26 = (unsigned __int64)v203;
			//     *(Il2CppExceptionWrapper *)v208.m256i_i8 = (Il2CppExceptionWrapper)v228.ex;
			//     v24 = v208.m256i_i64[0];
			//     if ( v208.m256i_i64[0] )
			//       sub_18000F780(v208.m256i_i64[0]);
			//     v22 = *(_OWORD *)&v222.m03;
			//     v21 = *(_OWORD *)&v222.m02;
			//     v20 = *(_OWORD *)&v222.m01;
			//     v19 = *(_OWORD *)&v222.m00;
			//   }
			//   v38 = this;
			//   m_externInteracts = this.fields.m_externInteracts;
			//   if ( !m_externInteracts )
			//     goto LABEL_336;
			//   *(_OWORD *)&v208.m256i_u64[1] = 0LL;
			//   v208.m256i_i64[0] = (__int64)m_externInteracts;
			//   if ( dword_18D8E43F8 )
			//   {
			//     v40 = (((unsigned __int64)&v208 >> 12) & 0x1FFFFF) >> 6;
			//     _m_prefetchw(&qword_18D6870D0[v40]);
			//     do
			//       v41 = qword_18D6870D0[v40];
			//     while ( v41 != _InterlockedCompareExchange64(
			//                      &qword_18D6870D0[v40],
			//                      v41 | (1LL << (((unsigned __int64)&v208 >> 12) & 0x3F)),
			//                      v41) );
			//   }
			//   v208.m256i_i32[2] = 0;
			//   v208.m256i_i32[3] = m_externInteracts.fields._version;
			//   v208.m256i_i64[2] = 0LL;
			//   *(_OWORD *)&v221._list = *(_OWORD *)v208.m256i_i8;
			//   v221._current = 0LL;
			//   v208.m256i_i64[0] = 0LL;
			//   v208.m256i_i64[1] = (__int64)&v221;
			//   try
			//   {
			//     while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//               &v221,
			//               MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGFoliageInteract>::MoveNext) )
			//     {
			//       current = (Component *)v221._current;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v26);
			//       if ( !byte_18D8F4EFB )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EFB = 1;
			//       }
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v26);
			//       if ( !byte_18D8F4EAF )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EAF = 1;
			//       }
			//       if ( current )
			//       {
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v26);
			//         if ( current.fields._.m_CachedPtr )
			//         {
			//           v43 = (Object_1 *)current[1].klass;
			//           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v26);
			//           if ( !byte_18D8F4EFA )
			//           {
			//             sub_18003C530(&TypeInfo::UnityEngine::Object);
			//             byte_18D8F4EFA = 1;
			//           }
			//           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v26);
			//           if ( !byte_18D8F4EAF )
			//           {
			//             sub_18003C530(&TypeInfo::UnityEngine::Object);
			//             byte_18D8F4EAF = 1;
			//           }
			//           if ( v43 )
			//           {
			//             if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v26);
			//             if ( v43.fields.m_CachedPtr )
			//             {
			//               InstanceID = UnityEngine::Object::GetInstanceID(v43, 0LL);
			//               v46 = InstanceID;
			//               v47 = this.fields.m_interactMeshMatrixDict;
			//               if ( !v47 )
			//                 sub_1802DC2C8(0LL, v45);
			//               if ( !System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::ContainsKey(
			//                       v47,
			//                       InstanceID,
			//                       MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::ContainsKey) )
			//               {
			//                 v51 = this.fields.m_interactMeshMatrixDict;
			//                 v206.matrixs.m_ListData = 0LL;
			//                 *(_QWORD *)&v206.matrixs.m_DeprecatedAllocator.Index = 0LL;
			//                 v206.mesh = (Mesh *)v43;
			//                 if ( dword_18D8E43F8 )
			//                   sub_18028AB60(
			//                     0x180000000LL + 8 * ((((unsigned __int64)&v206 >> 12) & 0x1FFFFF) >> 6) + 224948432,
			//                     1LL << (((unsigned __int64)&v206 >> 12) & 0x3F),
			//                     v49,
			//                     v50);
			//                 LODWORD(allocator) = 4;
			//                 v234 = 4;
			//                 v52 = MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::NativeList.klass;
			//                 if ( ((__int64)v52.vtable[0].methodPtr & 1) == 0 )
			//                 {
			//                   sub_18003C700(v52);
			//                   v52 = v53;
			//                 }
			//                 *(_OWORD *)&v210.mesh = 0LL;
			//                 LODWORD(allocator) = v234;
			//                 rgctxDataDummy = v52.rgctx_data.rgctxDataDummy;
			//                 v55 = rgctxDataDummy[4];
			//                 if ( (*(_BYTE *)(v55 + 312) & 1) == 0 )
			//                   sub_18003C700(rgctxDataDummy[4]);
			//                 v56 = *(_QWORD *)(v55 + 192);
			//                 v57 = *(_QWORD *)(v56 + 24);
			//                 if ( !*(_QWORD *)(v57 + 56) )
			//                   sub_180041F40(*(_QWORD *)(v56 + 24));
			//                 v210.mesh = (Mesh *)Unity::Collections::LowLevel::Unsafe::UnsafeList<UnityEngine::Matrix4x4>::Create<Unity::Collections::AllocatorManager::AllocatorHandle>(
			//                                       1,
			//                                       (AllocatorManager_AllocatorHandle *)&allocator,
			//                                       NativeArrayOptions__Enum_UninitializedMemory,
			//                                       **(MethodInfo ***)(v57 + 56));
			//                 LODWORD(v210.matrixs.m_ListData) = allocator;
			//                 v206.matrixs = *(NativeList_1_UnityEngine_Matrix4x4_ *)&v210.mesh;
			//                 if ( !v51 )
			//                   sub_1802DC2C8(v59, v58);
			//                 *(_OWORD *)v207.m256i_i8 = *(_OWORD *)&v206.mesh;
			//                 v207.m256i_i64[2] = *(_QWORD *)&v206.matrixs.m_DeprecatedAllocator.Index;
			//                 v210 = v206;
			//                 System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::Add(
			//                   v51,
			//                   v46,
			//                   &v210,
			//                   MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::Add);
			//               }
			//               v60 = this.fields.m_interactMeshMatrixDict;
			//               if ( !v60 )
			//                 sub_1802DC2C8(v48, 0LL);
			//               System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::get_Item(
			//                 &v225,
			//                 v60,
			//                 v46,
			//                 MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::get_Item);
			//               v206 = v225;
			//               transform = UnityEngine::Component::get_transform(current, 0LL);
			//               if ( !transform )
			//                 sub_1802DC2C8(v63, v62);
			//               localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(v231, transform, 0LL);
			//               *(_OWORD *)&v227.m00 = v19;
			//               *(_OWORD *)&v227.m01 = v20;
			//               *(_OWORD *)&v227.m02 = v21;
			//               *(_OWORD *)&v227.m03 = v22;
			//               v226 = *localToWorldMatrix;
			//               memset(&block, 0, 64);
			//               v65 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, OneofDescriptor *))qword_18D8F4BC0;
			//               if ( !qword_18D8F4BC0 )
			//               {
			//                 v65 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, OneofDescriptor *))il2cpp_resolve_icall_0(
			//                                                                                           "UnityEngine.Matrix4x4::HGMulti"
			//                                                                                           "plyMatrix4x4Fast_Injected(Unit"
			//                                                                                           "yEngine.Matrix4x4&,UnityEngine"
			//                                                                                           ".Matrix4x4&,UnityEngine.Matrix4x4&)");
			//                 if ( !v65 )
			//                 {
			//                   v199 = sub_1802DBBE8(
			//                            "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Ma"
			//                            "trix4x4&,UnityEngine.Matrix4x4&)");
			//                   sub_18000F750(v199, 0LL);
			//                 }
			//                 qword_18D8F4BC0 = (__int64)v65;
			//               }
			//               v65(&v227, &v226, &block);
			//               *(_OWORD *)&value.m00 = *(_OWORD *)&block.klass;
			//               *(_OWORD *)&value.m01 = *(_OWORD *)&block.fields._._Index_k__BackingField;
			//               *(_OWORD *)&value.m02 = *(_OWORD *)&block.fields._._File_k__BackingField;
			//               *(_OWORD *)&value.m03 = *(_OWORD *)&block.fields.fields;
			//               m_ListData = v206.matrixs.m_ListData;
			//               v67 = MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::Add.klass;
			//               if ( ((__int64)v67.vtable[0].methodPtr & 1) == 0 )
			//                 sub_18003C700(MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::Add.klass);
			//               Unity::Collections::LowLevel::Unsafe::UnsafeList<UnityEngine::Matrix4x4>::Add(
			//                 m_ListData,
			//                 &value,
			//                 (MethodInfo *)v67.rgctx_data[12].rgctxDataDummy);
			//             }
			//           }
			//         }
			//       }
			//     }
			//   }
			//   catch ( Il2CppExceptionWrapper *v229 )
			//   {
			//     v26 = (unsigned __int64)v203;
			//     *(Il2CppExceptionWrapper *)v208.m256i_i8 = (Il2CppExceptionWrapper)v229.ex;
			//     if ( v208.m256i_i64[0] )
			//       sub_18000F780(v208.m256i_i64[0]);
			//     v22 = *(_OWORD *)&v222.m03;
			//     v21 = *(_OWORD *)&v222.m02;
			//     v20 = *(_OWORD *)&v222.m01;
			//     v19 = *(_OWORD *)&v222.m00;
			//     v38 = this;
			//   }
			//   m_characterColliderMesh = v38.fields.m_characterColliderMesh;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v26);
			//   if ( byte_18D8F4EFB )
			//   {
			//     v75 = off_18A2C5600;
			//   }
			//   else
			//   {
			//     v69 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Object, 0LL);
			//     if ( (v69 & 1) != 0 )
			//     {
			//       v70 = (v69 >> 1) & 0xFFFFFFF;
			//       switch ( v69 >> 29 )
			//       {
			//         case 1u:
			//           v71 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v70);
			//           goto LABEL_126;
			//         case 2u:
			//           v71 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v70);
			//           goto LABEL_126;
			//         case 3u:
			//         case 6u:
			//           v72 = (v69 >> 1) & 0xFFFFFFF;
			//           v73 = v69 >> 29;
			//           if ( v73 )
			//           {
			//             if ( v73 == 3 )
			//             {
			//               v71 = (void (__fastcall __noreturn **)())sub_180039480(v72);
			//               goto LABEL_108;
			//             }
			//             if ( v73 == 6 )
			//             {
			//               v74 = sub_1802DF9C0(v72);
			//               v71 = (void (__fastcall __noreturn **)())sub_18005F4B0(v74, 0LL);
			//               goto LABEL_108;
			//             }
			//           }
			//           else if ( v72 == 1 )
			//           {
			//             v75 = off_18A2C5600;
			//             v71 = off_18A2C5600;
			//             goto LABEL_127;
			//           }
			//           v71 = 0LL;
			// LABEL_108:
			//           v75 = off_18A2C5600;
			// LABEL_127:
			//           if ( !v71 )
			//             goto LABEL_130;
			//           _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, (__int64)v71);
			//           byte_18D8F4EFB = 1;
			//           break;
			//         case 4u:
			//           v71 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v70);
			//           goto LABEL_126;
			//         case 5u:
			//           v76 = 8 * v70;
			//           if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v70) )
			//           {
			//             v71 = *(void (__fastcall __noreturn ***)())(v76 + qword_18D8F6F98);
			//           }
			//           else
			//           {
			//             v77 = il2cpp_string_new_len(
			//                     qword_18D8E5198
			//                   + *(int *)(v76 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                   + *(int *)(qword_18D8E51A0 + 16),
			//                     *(unsigned int *)(v76 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//             v71 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                        (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v70),
			//                                                        v77,
			//                                                        0LL);
			//             if ( !v71 )
			//             {
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v26 = (((unsigned __int64)(qword_18D8F6F98 + 8 * v70) >> 12) & 0x1FFFFF) >> 6;
			//                 v78 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v70) >> 12) & 0x3F;
			//                 _m_prefetchw(&qword_18D6870D0[v26]);
			//                 do
			//                   v79 = qword_18D6870D0[v26];
			//                 while ( v79 != _InterlockedCompareExchange64(&qword_18D6870D0[v26], v79 | (1LL << v78), v79) );
			//               }
			//               v71 = (void (__fastcall __noreturn **)())v77;
			//             }
			//           }
			//           goto LABEL_126;
			//         case 7u:
			//           v80 = sub_1802DF920((unsigned int)v70);
			//           v81 = *(_QWORD *)(v80 + 16);
			//           v82 = (v80 - *(_QWORD *)(v81 + 128)) >> 5;
			//           if ( *(_BYTE *)(v81 + 42) == 21 )
			//           {
			//             v83 = *(_QWORD ***)(v81 + 96);
			//             if ( *v83 )
			//             {
			//               v84 = **v83 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//               v81 = sub_180039550(v84 / 92 + v84);
			//             }
			//             else
			//             {
			//               v81 = 0LL;
			//             }
			//           }
			//           LODWORD(v210.mesh) = v82 + *(_DWORD *)(*(_QWORD *)(v81 + 104) + 32LL);
			//           v85 = sub_1801B8ECC(
			//                   (unsigned int)&v210,
			//                   (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                   *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                   12,
			//                   (__int64)sub_1802C7760);
			//           if ( !v85 || (v26 = *(unsigned int *)(v85 + 8), (_DWORD)v26 == -1) )
			//             v71 = 0LL;
			//           else
			//             v71 = (void (__fastcall __noreturn **)())(v26 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			// LABEL_126:
			//           v75 = off_18A2C5600;
			//           goto LABEL_127;
			//         default:
			//           goto LABEL_129;
			//       }
			//     }
			//     else
			//     {
			// LABEL_129:
			//       v75 = off_18A2C5600;
			// LABEL_130:
			//       byte_18D8F4EFB = 1;
			//     }
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v26);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     v86 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Object, 0LL);
			//     if ( (v86 & 1) != 0 )
			//     {
			//       v87 = (v86 >> 1) & 0xFFFFFFF;
			//       switch ( v86 >> 29 )
			//       {
			//         case 1u:
			//           v75 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v87);
			//           goto LABEL_162;
			//         case 2u:
			//           v75 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v87);
			//           goto LABEL_162;
			//         case 3u:
			//         case 6u:
			//           v88 = (v86 >> 1) & 0xFFFFFFF;
			//           v89 = v86 >> 29;
			//           if ( v89 )
			//           {
			//             if ( v89 == 3 )
			//             {
			//               v75 = (void (__fastcall __noreturn **)())sub_180039480(v88);
			//               goto LABEL_162;
			//             }
			//             if ( v89 == 6 )
			//             {
			//               v90 = sub_1802DF9C0(v88);
			//               v75 = (void (__fastcall __noreturn **)())sub_18005F4B0(v90, 0LL);
			//               goto LABEL_162;
			//             }
			//           }
			//           else if ( v88 == 1 )
			//           {
			//             goto LABEL_162;
			//           }
			//           v75 = 0LL;
			// LABEL_162:
			//           if ( v75 )
			//             _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, (__int64)v75);
			//           break;
			//         case 4u:
			//           v75 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v87);
			//           goto LABEL_162;
			//         case 5u:
			//           v91 = 8 * v87;
			//           if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v87) )
			//           {
			//             v75 = *(void (__fastcall __noreturn ***)())(v91 + qword_18D8F6F98);
			//           }
			//           else
			//           {
			//             v92 = il2cpp_string_new_len(
			//                     qword_18D8E5198
			//                   + *(int *)(v91 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                   + *(int *)(qword_18D8E51A0 + 16),
			//                     *(unsigned int *)(v91 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//             v75 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                        (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v87),
			//                                                        v92,
			//                                                        0LL);
			//             if ( !v75 )
			//             {
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v26 = (((unsigned __int64)(qword_18D8F6F98 + 8 * v87) >> 12) & 0x1FFFFF) >> 6;
			//                 v93 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v87) >> 12) & 0x3F;
			//                 _m_prefetchw(&qword_18D6870D0[v26]);
			//                 do
			//                   v94 = qword_18D6870D0[v26];
			//                 while ( v94 != _InterlockedCompareExchange64(&qword_18D6870D0[v26], v94 | (1LL << v93), v94) );
			//               }
			//               v75 = (void (__fastcall __noreturn **)())v92;
			//             }
			//           }
			//           goto LABEL_162;
			//         case 7u:
			//           v95 = sub_1802DF920((unsigned int)v87);
			//           v96 = *(_QWORD *)(v95 + 16);
			//           v97 = (v95 - *(_QWORD *)(v96 + 128)) >> 5;
			//           if ( *(_BYTE *)(v96 + 42) == 21 )
			//           {
			//             v98 = *(_QWORD ***)(v96 + 96);
			//             if ( *v98 )
			//             {
			//               v99 = **v98 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//               v96 = sub_180039550(v99 / 92 + v99);
			//             }
			//             else
			//             {
			//               v96 = 0LL;
			//             }
			//           }
			//           LODWORD(v210.mesh) = v97 + *(_DWORD *)(*(_QWORD *)(v96 + 104) + 32LL);
			//           v100 = sub_1801B8ECC(
			//                    (unsigned int)&v210,
			//                    (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                    *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                    12,
			//                    (__int64)sub_1802C7760);
			//           if ( !v100 || (v26 = *(unsigned int *)(v100 + 8), (_DWORD)v26 == -1) )
			//             v75 = 0LL;
			//           else
			//             v75 = (void (__fastcall __noreturn **)())(v26 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			//           goto LABEL_162;
			//         default:
			//           break;
			//       }
			//     }
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( !m_characterColliderMesh )
			//     goto LABEL_333;
			//   v24 = (signed __int64)TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v26);
			//   v101 = this;
			//   if ( !m_characterColliderMesh.fields._.m_CachedPtr )
			//     goto LABEL_334;
			//   m_characterPoses = this.fields.m_characterPoses;
			//   if ( !m_characterPoses )
			// LABEL_336:
			//     sub_1802DC2C8(v24, v26);
			//   memset(&v208.m256i_u64[1], 0, 24);
			//   v208.m256i_i64[0] = (__int64)m_characterPoses;
			//   if ( dword_18D8E43F8 )
			//   {
			//     v26 = (((unsigned __int64)&v208 >> 12) & 0x1FFFFF) >> 6;
			//     _m_prefetchw(&qword_18D6870D0[v26]);
			//     do
			//     {
			//       v24 = qword_18D6870D0[v26] | (1LL << (((unsigned __int64)&v208 >> 12) & 0x3F));
			//       v103 = qword_18D6870D0[v26];
			//     }
			//     while ( v103 != _InterlockedCompareExchange64(&qword_18D6870D0[v26], v24, v103) );
			//   }
			//   v208.m256i_i32[2] = 0;
			//   v208.m256i_i32[3] = m_characterPoses.fields._version;
			//   v208.m256i_i64[2] = 0LL;
			//   v208.m256i_i32[6] = 0;
			//   v216 = v208;
			//   v208.m256i_i64[0] = 0LL;
			//   v208.m256i_i64[1] = (__int64)&v216;
			//   try
			//   {
			//     while ( 1 )
			//     {
			//       v104 = v216.m256i_i64[0];
			//       if ( !v216.m256i_i64[0] )
			//         sub_1802DC2C8(v24, v26);
			//       v105 = v216.m256i_u32[3];
			//       if ( v216.m256i_i32[3] != *(_DWORD *)(v216.m256i_i64[0] + 28)
			//         || v216.m256i_i32[2] >= *(_DWORD *)(v216.m256i_i64[0] + 24) )
			//       {
			//         break;
			//       }
			//       v106 = *(_QWORD *)(v216.m256i_i64[0] + 16);
			//       if ( !v106 )
			//         sub_1802DC2C8(v216.m256i_i32[2], 0LL);
			//       if ( v216.m256i_i32[2] >= *(_DWORD *)(v106 + 24) )
			//         sub_180070260(
			//           v216.m256i_i32[2],
			//           v106,
			//           MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::MoveNext,
			//           m_characterPoses);
			//       v216.m256i_i64[2] = *(_QWORD *)(v106 + 12LL * v216.m256i_i32[2] + 32);
			//       v214 = *(_DWORD *)(v106 + 12LL * v216.m256i_i32[2] + 40);
			//       v216.m256i_i32[6] = v214;
			//       v107 = (unsigned int)++v216.m256i_i32[2];
			//       v224 = v216.m256i_i64[2];
			//       v108 = v101.fields.m_interactMeshMatrixDict;
			//       m_characterColliderMeshID = v101.fields.m_characterColliderMeshID;
			//       if ( !v108 )
			//         sub_1802DC2C8(v107, v106);
			//       v110 = MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::ContainsKey;
			//       if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::ContainsKey.klass.rgctx_data[22].rgctxDataDummy
			//             + 4) )
			//         (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::ContainsKey.klass.rgctx_data[22].rgctxDataDummy)();
			//       if ( System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::FindEntry(
			//              v108,
			//              m_characterColliderMeshID,
			//              (MethodInfo *)v110.klass.rgctx_data[22].rgctxDataDummy) < 0 )
			//       {
			//         *(_QWORD *)&v215.x = v101.fields.m_interactMeshMatrixDict;
			//         v213 = v101.fields.m_characterColliderMeshID;
			//         v206.matrixs.m_ListData = 0LL;
			//         *(_QWORD *)&v206.matrixs.m_DeprecatedAllocator.Index = 0LL;
			//         v206.mesh = v101.fields.m_characterColliderMesh;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v111 = (((unsigned __int64)&v206 >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6870D0[v111]);
			//           do
			//             v113 = qword_18D6870D0[v111];
			//           while ( v113 != _InterlockedCompareExchange64(
			//                             &qword_18D6870D0[v111],
			//                             v113 | (1LL << (((unsigned __int64)&v206 >> 12) & 0x3F)),
			//                             v113) );
			//         }
			//         LODWORD(allocator) = 4;
			//         v234 = 4;
			//         v114 = MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::NativeList.klass;
			//         if ( ((__int64)v114.vtable[0].methodPtr & 1) == 0 )
			//         {
			//           sub_18003C700(v114);
			//           v114 = v115;
			//         }
			//         *(_OWORD *)v207.m256i_i8 = 0LL;
			//         LODWORD(allocator) = v234;
			//         v116 = v114.rgctx_data.rgctxDataDummy;
			//         v117 = v116[4];
			//         if ( (*(_BYTE *)(v117 + 312) & 1) == 0 )
			//           sub_18003C700(v116[4]);
			//         v118 = *(_QWORD *)(v117 + 192);
			//         v119 = *(_QWORD *)(v118 + 24);
			//         if ( !*(_QWORD *)(v119 + 56) )
			//           sub_180041F40(*(_QWORD *)(v118 + 24));
			//         v120 = *(__int64 **)(v119 + 56);
			//         v121 = *v120;
			//         if ( !*(_QWORD *)(*v120 + 56) )
			//         {
			//           v122 = _InterlockedExchangeAdd64(
			//                    (volatile signed __int64 *)&TypeInfo::Unity::Collections::AllocatorManager,
			//                    0LL);
			//           if ( (v122 & 1) != 0 )
			//           {
			//             v123 = ((unsigned int)v122 >> 1) & 0xFFFFFFF;
			//             switch ( (unsigned int)v122 >> 29 )
			//             {
			//               case 1u:
			//                 v124 = sub_18003C670(v123);
			//                 goto LABEL_201;
			//               case 2u:
			//                 v124 = sub_18003C380(v123);
			//                 goto LABEL_201;
			//               case 3u:
			//               case 6u:
			//                 v124 = sub_1802DFAE0(v122);
			//                 goto LABEL_201;
			//               case 4u:
			//                 v124 = sub_1802DF920(v123);
			//                 goto LABEL_201;
			//               case 5u:
			//                 v124 = sub_1802DFBB0(v123);
			//                 goto LABEL_201;
			//               case 7u:
			//                 v125 = sub_1802DF920(v123);
			//                 v124 = sub_18003D1A0(v125, &centerPosition);
			// LABEL_201:
			//                 if ( v124 )
			//                   _InterlockedExchange64((volatile __int64 *)&TypeInfo::Unity::Collections::AllocatorManager, v124);
			//                 break;
			//               default:
			//                 break;
			//             }
			//           }
			//           if ( !*(_QWORD *)(v121 + 56) )
			//             sub_180041F40(v121);
			//         }
			//         if ( !TypeInfo::Unity::Collections::AllocatorManager._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::Unity::Collections::AllocatorManager, v111);
			//         v126 = *(__int64 **)(v121 + 56);
			//         v127 = *v126;
			//         if ( !*(_QWORD *)(*v126 + 56) )
			//         {
			//           v128 = _InterlockedExchangeAdd64(
			//                    (volatile signed __int64 *)&TypeInfo::Unity::Collections::AllocatorManager,
			//                    0LL);
			//           if ( (v128 & 1) != 0 )
			//           {
			//             v129 = ((unsigned int)v128 >> 1) & 0xFFFFFFF;
			//             switch ( (unsigned int)v128 >> 29 )
			//             {
			//               case 1u:
			//                 v130 = sub_18003C670(v129);
			//                 goto LABEL_216;
			//               case 2u:
			//                 v130 = sub_18003C380(v129);
			//                 goto LABEL_216;
			//               case 3u:
			//               case 6u:
			//                 v130 = sub_1802DFAE0(v128);
			//                 goto LABEL_216;
			//               case 4u:
			//                 v130 = sub_1802DF920(v129);
			//                 goto LABEL_216;
			//               case 5u:
			//                 v130 = sub_1802DFBB0(v129);
			//                 goto LABEL_216;
			//               case 7u:
			//                 v131 = sub_1802DF920(v129);
			//                 v130 = sub_18003D1A0(v131, &centerPosition);
			// LABEL_216:
			//                 if ( v130 )
			//                   _InterlockedExchange64((volatile __int64 *)&TypeInfo::Unity::Collections::AllocatorManager, v130);
			//                 break;
			//               default:
			//                 break;
			//             }
			//           }
			//           if ( !*(_QWORD *)(v127 + 56) )
			//             sub_180041F40(v127);
			//         }
			//         v132 = *(_QWORD **)(v127 + 56);
			//         if ( !*(_QWORD *)(*v132 + 56LL) )
			//           sub_180041F40(*v132);
			//         v133 = *(_QWORD *)(v127 + 56);
			//         v134 = *(_QWORD *)(v133 + 8);
			//         if ( !*(_QWORD *)(v134 + 56) )
			//           sub_180041F40(*(_QWORD *)(v133 + 8));
			//         v135 = *(_QWORD **)(v134 + 56);
			//         if ( !*(_QWORD *)(*v135 + 56LL) )
			//           sub_180041F40(*v135);
			//         v136 = *(_QWORD *)(*(_QWORD *)(v134 + 56) + 8LL);
			//         if ( !*(_QWORD *)(v136 + 56) )
			//           sub_180041F40(v136);
			//         if ( !TypeInfo::Unity::Collections::AllocatorManager._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::Unity::Collections::AllocatorManager, v111);
			//         v137 = Unity::Collections::AllocatorManager::Allocate<Unity::Collections::AllocatorManager::AllocatorHandle>(
			//                  (AllocatorManager_AllocatorHandle *)&allocator,
			//                  32,
			//                  8,
			//                  1,
			//                  *(MethodInfo **)(*(_QWORD *)(v127 + 56) + 16LL));
			//         Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemSet(v137, 0, 32LL, 0LL);
			//         if ( !v137 )
			//           sub_1802DC2C8(v139, v138);
			//         v141 = allocator;
			//         *(_DWORD *)&v137[16] = allocator;
			//         v142 = *(_QWORD *)(v121 + 56);
			//         v143 = *(_QWORD *)(v142 + 24);
			//         if ( !*(_QWORD *)(v143 + 56) )
			//           sub_180041F40(*(_QWORD *)(v142 + 24));
			//         v144 = *(_QWORD *)(v143 + 32);
			//         if ( (*(_BYTE *)(v144 + 312) & 1) == 0 )
			//           sub_18003C700(v144);
			//         if ( *(_DWORD *)&v137[12] != 1 )
			//         {
			//           v145 = *(__int64 **)(v143 + 56);
			//           v146 = *v145;
			//           if ( !*(_QWORD *)(*v145 + 56) )
			//           {
			//             v147 = _InterlockedExchangeAdd64(
			//                      (volatile signed __int64 *)&TypeInfo::Unity::Collections::AllocatorManager,
			//                      0LL);
			//             if ( (v147 & 1) != 0 )
			//             {
			//               v148 = ((unsigned int)v147 >> 1) & 0xFFFFFFF;
			//               switch ( (unsigned int)v147 >> 29 )
			//               {
			//                 case 1u:
			//                   v149 = sub_18003C670(v148);
			//                   goto LABEL_245;
			//                 case 2u:
			//                   v149 = sub_18003C380(v148);
			//                   goto LABEL_245;
			//                 case 3u:
			//                 case 6u:
			//                   v149 = sub_1802DFAE0(v147);
			//                   goto LABEL_245;
			//                 case 4u:
			//                   v149 = sub_1802DF920(v148);
			//                   goto LABEL_245;
			//                 case 5u:
			//                   v149 = sub_1802DFBB0(v148);
			//                   goto LABEL_245;
			//                 case 7u:
			//                   v150 = sub_1802DF920(v148);
			//                   v149 = sub_18003D1A0(v150, &centerPosition);
			// LABEL_245:
			//                   if ( v149 )
			//                     _InterlockedExchange64((volatile __int64 *)&TypeInfo::Unity::Collections::AllocatorManager, v149);
			//                   break;
			//                 default:
			//                   break;
			//               }
			//             }
			//             if ( !*(_QWORD *)(v146 + 56) )
			//               sub_180041F40(v146);
			//           }
			//           v151 = *(_QWORD *)(v146 + 32);
			//           if ( (*(_BYTE *)(v151 + 312) & 1) == 0 )
			//             sub_18003C700(*(_QWORD *)(v146 + 32));
			//           v152 = *(_QWORD *)(v151 + 192);
			//           v153 = *(_QWORD *)(v152 + 80);
			//           if ( !*(_QWORD *)(v153 + 56) )
			//             sub_180041F40(*(_QWORD *)(v152 + 80));
			//           v154 = *(_QWORD **)(v153 + 56);
			//           if ( !*(_QWORD *)(*v154 + 56LL) )
			//             sub_180041F40(*v154);
			//           v155 = *(_QWORD *)(*(_QWORD *)(v153 + 56) + 8LL);
			//           if ( !*(_QWORD *)(v155 + 56) )
			//             sub_180041F40(v155);
			//           if ( !TypeInfo::Unity::Collections::AllocatorManager._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::Unity::Collections::AllocatorManager, v138);
			//           v156 = Unity::Collections::AllocatorManager::Allocate<Unity::Collections::AllocatorManager::AllocatorHandle>(
			//                    (AllocatorManager_AllocatorHandle *)&allocator,
			//                    64,
			//                    4,
			//                    1,
			//                    **(MethodInfo ***)(v146 + 56));
			//           *(_QWORD *)&centerPosition.x = v156;
			//           if ( *(int *)&v137[12] > 0 )
			//           {
			//             v157 = *(_QWORD *)(v146 + 32);
			//             if ( (*(_BYTE *)(v157 + 312) & 1) == 0 )
			//               sub_18003C700(v157);
			//             v158 = *(_DWORD *)&v137[12];
			//             if ( v158 > 1 )
			//               v158 = 1;
			//             Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(v156, *(Void **)v137, v158 << 6, 0LL);
			//           }
			//           v159 = *(OneofDescriptor__Class **)v137;
			//           v160 = *(_QWORD *)(v146 + 32);
			//           if ( (*(_BYTE *)(v160 + 312) & 1) == 0 )
			//             sub_18003C700(v160);
			//           v161 = *(_DWORD *)&v137[12];
			//           if ( !TypeInfo::Unity::Collections::AllocatorManager._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::Unity::Collections::AllocatorManager, v138);
			//           v162 = *(_QWORD *)(*(_QWORD *)(v146 + 56) + 8LL);
			//           if ( !*(_QWORD *)(v162 + 56) )
			//           {
			//             v163 = _InterlockedExchangeAdd64(
			//                      (volatile signed __int64 *)&TypeInfo::Unity::Collections::AllocatorManager,
			//                      0LL);
			//             if ( (v163 & 1) != 0 )
			//             {
			//               v164 = ((unsigned int)v163 >> 1) & 0xFFFFFFF;
			//               switch ( (unsigned int)v163 >> 29 )
			//               {
			//                 case 1u:
			//                   v165 = sub_18003C670(v164);
			//                   goto LABEL_278;
			//                 case 2u:
			//                   v165 = sub_18003C380(v164);
			//                   goto LABEL_278;
			//                 case 3u:
			//                 case 6u:
			//                   v165 = sub_1802DFAE0(v163);
			//                   goto LABEL_278;
			//                 case 4u:
			//                   v165 = sub_1802DF920(v164);
			//                   goto LABEL_278;
			//                 case 5u:
			//                   v165 = sub_1802DFBB0(v164);
			//                   goto LABEL_278;
			//                 case 7u:
			//                   v166 = sub_1802DF920(v164);
			//                   v165 = sub_18003D1A0(v166, &block.fields._Proto_k__BackingField);
			// LABEL_278:
			//                   if ( v165 )
			//                     _InterlockedExchange64((volatile __int64 *)&TypeInfo::Unity::Collections::AllocatorManager, v165);
			//                   break;
			//                 default:
			//                   break;
			//               }
			//             }
			//             if ( !*(_QWORD *)(v162 + 56) )
			//               sub_180041F40(v162);
			//           }
			//           v167 = *(_QWORD **)(v162 + 56);
			//           if ( !*(_QWORD *)(*v167 + 56LL) )
			//             sub_180041F40(*v167);
			//           v168 = *(_QWORD *)(v162 + 56);
			//           v169 = *(_QWORD *)(v168 + 8);
			//           if ( !*(_QWORD *)(v169 + 56) )
			//             sub_180041F40(*(_QWORD *)(v168 + 8));
			//           v170 = *(_QWORD **)(v169 + 56);
			//           if ( !*(_QWORD *)(*v170 + 56LL) )
			//             sub_180041F40(*v170);
			//           v171 = *(_QWORD *)(*(_QWORD *)(v169 + 56) + 8LL);
			//           if ( !*(_QWORD *)(v171 + 56) )
			//             sub_180041F40(v171);
			//           if ( !TypeInfo::Unity::Collections::AllocatorManager._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::Unity::Collections::AllocatorManager, v138);
			//           v172 = *(_QWORD *)(*(_QWORD *)(v162 + 56) + 16LL);
			//           if ( !*(_QWORD *)(v172 + 56) )
			//           {
			//             v173 = _InterlockedExchangeAdd64(
			//                      (volatile signed __int64 *)&TypeInfo::Unity::Collections::AllocatorManager,
			//                      0LL);
			//             if ( (v173 & 1) != 0 )
			//             {
			//               v174 = ((unsigned int)v173 >> 1) & 0xFFFFFFF;
			//               switch ( (unsigned int)v173 >> 29 )
			//               {
			//                 case 1u:
			//                   v175 = sub_18003C670(v174);
			//                   goto LABEL_301;
			//                 case 2u:
			//                   v175 = sub_18003C380(v174);
			//                   goto LABEL_301;
			//                 case 3u:
			//                 case 6u:
			//                   v175 = sub_1802DFAE0(v173);
			//                   goto LABEL_301;
			//                 case 4u:
			//                   v175 = sub_1802DF920(v174);
			//                   goto LABEL_301;
			//                 case 5u:
			//                   v175 = sub_1802DFBB0(v174);
			//                   goto LABEL_301;
			//                 case 7u:
			//                   v176 = sub_1802DF920(v174);
			//                   v175 = sub_18003D1A0(v176, &block.fields._Proto_k__BackingField);
			// LABEL_301:
			//                   if ( v175 )
			//                     _InterlockedExchange64((volatile __int64 *)&TypeInfo::Unity::Collections::AllocatorManager, v175);
			//                   break;
			//                 default:
			//                   break;
			//               }
			//             }
			//             if ( !*(_QWORD *)(v172 + 56) )
			//               sub_180041F40(v172);
			//           }
			//           if ( v159 )
			//           {
			//             block.monitor = 0LL;
			//             block.fields._._FullName_k__BackingField = 0LL;
			//             *(&block.fields._._Index_k__BackingField + 1) = v161;
			//             block.klass = v159;
			//             block.fields._._Index_k__BackingField = 64;
			//             LOBYTE(block.fields._._FullName_k__BackingField) = 32
			//                                                              - Unity::Mathematics::math::lzcnt(
			//                                                                  (Unity::Mathematics::math *)3,
			//                                                                  v138);
			//             if ( !TypeInfo::Unity::Collections::AllocatorManager._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::Unity::Collections::AllocatorManager, v177);
			//             v178 = *(_QWORD **)(v172 + 56);
			//             v179 = *v178;
			//             if ( !*(_QWORD *)(*v178 + 56LL) )
			//               sub_180041F40(*v178);
			//             LODWORD(block.monitor) = 0;
			//             Unity::Collections::AllocatorManager::AllocatorHandle::Try(
			//               (AllocatorManager_AllocatorHandle *)&allocator,
			//               (AllocatorManager_Block *)&block,
			//               *(MethodInfo **)(*(_QWORD *)(v179 + 56) + 8LL));
			//           }
			//           *(_QWORD *)v137 = *(_QWORD *)&centerPosition.x;
			//           v144 = 1LL;
			//           *(_DWORD *)&v137[12] = 1;
			//           if ( *(int *)&v137[8] < 1 )
			//             v144 = *(unsigned int *)&v137[8];
			//           *(_DWORD *)&v137[8] = v144;
			//           v141 = allocator;
			//         }
			//         v207.m256i_i64[0] = (__int64)v137;
			//         v207.m256i_i32[2] = v141;
			//         v206.matrixs = *(NativeList_1_UnityEngine_Matrix4x4_ *)v207.m256i_i8;
			//         if ( !*(_QWORD *)&v215.x )
			//           sub_1802DC2C8(v144, v138);
			//         v180 = _mm_srli_si128(*(__m128i *)v207.m256i_i8, 8).m128i_u64[0];
			//         v181 = MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::Add;
			//         mesh = v206.mesh;
			//         allocator = v207.m256i_i64[0];
			//         if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::Add.klass.rgctx_data[24].rgctxDataDummy
			//               + 4) )
			//           (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::Add.klass.rgctx_data[24].rgctxDataDummy)();
			//         v207.m256i_i64[0] = (__int64)mesh;
			//         v207.m256i_i64[1] = allocator;
			//         v207.m256i_i64[2] = v180;
			//         *(_OWORD *)&block.fields._Proto_k__BackingField = *(_OWORD *)v207.m256i_i8;
			//         v212 = v180;
			//         LOBYTE(v140) = 2;
			//         System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::TryInsert(
			//           *(Dictionary_2_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ **)&v215.x,
			//           v213,
			//           (HGFoliageInteractiveMeshMatrixes *)&block.fields._Proto_k__BackingField,
			//           v140,
			//           (MethodInfo *)v181.klass.rgctx_data[24].rgctxDataDummy);
			//         v101 = this;
			//       }
			//       v183 = v101.fields.m_interactMeshMatrixDict;
			//       v184 = v101.fields.m_characterColliderMeshID;
			//       if ( !v183 )
			//         sub_1802DC2C8(v112, v111);
			//       v185 = MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::get_Item;
			//       if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::get_Item.klass.rgctx_data[22].rgctxDataDummy
			//             + 4) )
			//         (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::get_Item.klass.rgctx_data[22].rgctxDataDummy)();
			//       Entry = System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::FindEntry(
			//                 v183,
			//                 v184,
			//                 (MethodInfo *)v185.klass.rgctx_data[22].rgctxDataDummy);
			//       if ( Entry < 0 )
			//       {
			//         LODWORD(allocator) = v184;
			//         v200 = sub_180313188(v185.klass.rgctx_data, 23LL);
			//         v202 = (Object *)il2cpp_value_box(v200, &allocator, v201);
			//         System::ThrowHelper::ThrowKeyNotFoundException(v202, 0LL);
			//       }
			//       entries = v183.fields._entries;
			//       if ( !entries )
			//         sub_1802DC2C8(0LL, v187);
			//       v206 = *(HGFoliageInteractiveMeshMatrixes *)(sub_180056210(entries, Entry) + 16);
			//       v189 = sub_180323B1C();
			//       v190 = LODWORD(v189);
			//       v191 = (__m128)HIDWORD(v224);
			//       *(double *)v191.m128_u64 = sub_180323B1C();
			//       v192 = v191;
			//       v193 = (__m128)(unsigned int)v224;
			//       *(double *)v193.m128_u64 = sub_180323B1C();
			//       *(_OWORD *)v207.m256i_i8 = 0LL;
			//       System::ValueTuple<float,float,float,float>::ValueTuple(
			//         (ValueTuple_4_Single_Single_Single_Single_ *)&v207,
			//         0.0,
			//         0.0,
			//         0.0,
			//         1.0,
			//         0LL);
			//       v225.mesh = (Mesh *)_mm_unpacklo_ps((__m128)0x3F99999Au, (__m128)0x3F800000u).m128_u64[0];
			//       LODWORD(v225.matrixs.m_ListData) = 1067030938;
			//       v210.mesh = (Mesh *)_mm_unpacklo_ps(v193, v192).m128_u64[0];
			//       LODWORD(v210.matrixs.m_ListData) = v190;
			//       v227 = *UnityEngine::Matrix4x4::TRS(v231, (Vector3 *)&v210, (Quaternion *)&v207, (Vector3 *)&v225, 0LL);
			//       *(_OWORD *)&v226.m00 = v19;
			//       *(_OWORD *)&v226.m01 = v20;
			//       *(_OWORD *)&v226.m02 = v21;
			//       *(_OWORD *)&v226.m03 = v22;
			//       value = *UnityEngine::Matrix4x4::op_Multiply(v231, &v226, &v227, 0LL);
			//       v194 = v206.matrixs.m_ListData;
			//       v195 = MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::Add.klass;
			//       if ( ((__int64)v195.vtable[0].methodPtr & 1) == 0 )
			//         sub_18003C700(MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::Add.klass);
			//       Unity::Collections::LowLevel::Unsafe::UnsafeList<UnityEngine::Matrix4x4>::Add(
			//         v194,
			//         &value,
			//         (MethodInfo *)v195.rgctx_data[12].rgctxDataDummy);
			//     }
			//     v196 = MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::MoveNext.klass;
			//     if ( ((__int64)v196.vtable[0].methodPtr & 1) == 0 )
			//     {
			//       sub_18003C700(v196);
			//       v105 = v216.m256i_u32[3];
			//       v104 = v216.m256i_i64[0];
			//     }
			//     if ( !v104 )
			//       sub_1802DC2C8(v196, v105);
			//     if ( (_DWORD)v105 != *(_DWORD *)(v104 + 28) )
			//       System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
			//     v216.m256i_i32[2] = *(_DWORD *)(v104 + 24) + 1;
			//     v216.m256i_i64[2] = 0LL;
			//     v216.m256i_i32[6] = 0;
			//   }
			//   catch ( Il2CppExceptionWrapper *v230 )
			//   {
			//     *(Il2CppExceptionWrapper *)v208.m256i_i8 = (Il2CppExceptionWrapper)v230.ex;
			//     mono_thread_suspend_all_other_threads(
			//       v208.m256i_i64[1],
			//       MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::Dispose);
			//     if ( v208.m256i_i64[0] )
			//       sub_18000F780(v208.m256i_i64[0]);
			// LABEL_333:
			//     v101 = this;
			// LABEL_334:
			//     if ( (float)(UnityEngine::Time::get_realtimeSinceStartup(0LL) - v101.fields.m_lastCleanTime) > 60.0 )
			//     {
			//       HG::Rendering::Runtime::HGFoliageInteractiveManager::CleanUnusedMesh(v101, 0LL);
			//       v101.fields.m_lastCleanTime = UnityEngine::Time::get_realtimeSinceStartup(0LL);
			//     }
			//     return;
			//   }
			//   mono_thread_suspend_all_other_threads(
			//     &v216,
			//     MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::Dispose);
			//   goto LABEL_334;
			// }
			// 
		}

		private void CleanUnusedMesh()
		{
			// // Void CleanUnusedMesh()
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::HGFoliageInteractiveManager::CleanUnusedMesh(
			//         HGFoliageInteractiveManager *this,
			//         MethodInfo *method)
			// {
			//   HGFoliageInteractiveManager *v2; // r15
			//   __int64 v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Dictionary_2_TKey_TValue_Entry_System_UInt32_Beyond_Gameplay_Core_EntityManager_EntityDataStorage_HideByTypeParams___Array__Class **v8; // r9
			//   FileDescriptor *dictionary; // r8
			//   unsigned __int64 index; // rdx
			//   Dictionary_2_TKey_TValue_Entry_System_UInt32_Beyond_Gameplay_Core_EntityManager_EntityDataStorage_HideByTypeParams___Array *entries; // rax
			//   __int64 v12; // rcx
			//   __int32 v13; // ebx
			//   __m128d v14; // xmm0
			//   __int64 v15; // xmm1_8
			//   Il2CppClass *klass; // rcx
			//   OneofDescriptorProto *v17; // rdx
			//   FileDescriptor *v18; // r8
			//   MessageDescriptor *v19; // r9
			//   __m128d v20; // xmm1
			//   HashSet_1_System_UInt64_ *logicIdWhitelist; // rbx
			//   Il2CppClass *v22; // rax
			//   UnsafeList_1_System_Int32_ *m_ListData; // rsi
			//   struct MethodInfo *v24; // rdi
			//   Il2CppClass *v25; // rax
			//   Il2CppRGCTXData v26; // rbx
			//   UnsafeList_1_System_Int32_ *Ptr; // r14
			//   __int64 v28; // rcx
			//   AllocatorManager_AllocatorHandle m_length; // esi
			//   __int64 v30; // rcx
			//   Il2CppClass *v31; // rcx
			//   int v32; // ebx
			//   UnsafeList_1_System_Int32_ *v33; // rdi
			//   Il2CppClass *v34; // rax
			//   const Il2CppRGCTXData *rgctx_data; // rax
			//   __int64 v36; // rdx
			//   Dictionary_2_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ *m_interactMeshMatrixDict; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v39; // rdx
			//   __int64 v40; // rcx
			//   __int64 v41; // [rsp+0h] [rbp-158h] BYREF
			//   MethodInfo *methoda; // [rsp+20h] [rbp-138h]
			//   String *v43; // [rsp+28h] [rbp-130h]
			//   NativeList_1_System_Int32_ v44; // [rsp+30h] [rbp-128h] BYREF
			//   NativeList_1_System_Int32_ v45; // [rsp+40h] [rbp-118h] BYREF
			//   __int64 v46; // [rsp+50h] [rbp-108h]
			//   KeyValuePair_2_System_UInt32_Beyond_Gameplay_Core_EntityManager_EntityDataStorage_HideByTypeParams_ v47; // [rsp+58h] [rbp-100h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_UInt32_Beyond_Gameplay_Core_EntityManager_EntityDataStorage_HideByTypeParams_ v48; // [rsp+78h] [rbp-E0h] BYREF
			//   Il2CppException *ex; // [rsp+B0h] [rbp-A8h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_UInt32_Beyond_Gameplay_Core_EntityManager_EntityDataStorage_HideByTypeParams_ *v50; // [rsp+B8h] [rbp-A0h]
			//   __m128d v51; // [rsp+C0h] [rbp-98h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_UInt32_Beyond_Gameplay_Core_EntityManager_EntityDataStorage_HideByTypeParams_ v52; // [rsp+D0h] [rbp-88h] BYREF
			//   Il2CppExceptionWrapper *v53; // [rsp+108h] [rbp-50h] BYREF
			//   Il2CppExceptionWrapper *v54; // [rsp+110h] [rbp-48h] BYREF
			//   NativeList_1_UnityEngine_Matrix4x4_ v55; // [rsp+118h] [rbp-40h] BYREF
			//   __int64 v56; // [rsp+128h] [rbp-30h]
			//   __int64 value; // [rsp+170h] [rbp+18h] BYREF
			//   AllocatorManager_AllocatorHandle allocator; // [rsp+178h] [rbp+20h]
			// 
			//   v2 = this;
			//   if ( !byte_18D8EDCBC )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::Remove);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::MoveNext);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<int>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::get_Key);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::get_Value);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<int>::Add);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<int>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<int>::NativeList);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::get_IsCreated);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::get_Length);
			//     byte_18D8EDCBC = 1;
			//   }
			//   v44 = 0LL;
			//   v45 = 0LL;
			//   v46 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1418, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1418, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v40, v39);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			//   }
			//   else
			//   {
			//     LODWORD(value) = 2;
			//     allocator.Index = 2;
			//     allocator.Version = 0;
			//     v3 = sub_18010B520(MethodInfo::Unity::Collections::NativeList<int>::NativeList.klass);
			//     Unity::Collections::NativeList<int>::NativeList(&v44, 16, allocator, 2, **(MethodInfo ***)(v3 + 192));
			//     if ( !v2.fields.m_interactMeshMatrixDict )
			//       sub_180B536AC(v5, v4);
			//     System::Collections::Generic::Dictionary<unsigned int,Beyond::Gameplay::Core::EntityManager_EntityDataStorage::HideByTypeParams>::GetEnumerator(
			//       &v52,
			//       (Dictionary_2_System_UInt32_Beyond_Gameplay_Core_EntityManager_EntityDataStorage_HideByTypeParams_ *)v2.fields.m_interactMeshMatrixDict,
			//       MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::GetEnumerator);
			//     v48 = v52;
			//     ex = 0LL;
			//     v50 = &v48;
			//     try
			//     {
			//       m_ListData = v44.m_ListData;
			// LABEL_6:
			//       dictionary = (FileDescriptor *)v48._dictionary;
			//       if ( !v48._dictionary )
			//         sub_1802DC2C8(v7, v6);
			//       if ( v48._version != v48._dictionary.fields._version )
			//         System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
			//       index = (unsigned int)v48._index;
			//       while ( (unsigned int)index < v48._dictionary.fields._count )
			//       {
			//         entries = v48._dictionary.fields._entries;
			//         v12 = (int)index;
			//         index = (unsigned int)(index + 1);
			//         v48._index = index;
			//         if ( !entries )
			//           sub_1802DC2C8(v12, index);
			//         if ( (unsigned int)v12 >= entries.max_length.size )
			//           sub_180070260(v12, index, v48._dictionary, v8);
			//         v7 = 5 * v12;
			//         v8 = &entries.klass + v7;
			//         if ( *((int *)v8 + 8) >= 0 )
			//         {
			//           v13 = *((_DWORD *)v8 + 10);
			//           memset(&v47, 0, sizeof(v47));
			//           v14 = (__m128d)*((_OWORD *)v8 + 3);
			//           v51 = v14;
			//           v15 = (__int64)v8[8];
			//           value = v15;
			//           klass = MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::MoveNext.klass;
			//           if ( ((__int64)klass.vtable[0].methodPtr & 1) == 0 )
			//           {
			//             sub_18003C700(klass);
			//             v14 = v51;
			//             v15 = value;
			//           }
			//           v47.key = v13;
			//           *(__m128d *)&v47.value.entityTypes = v14;
			//           v47.value.identifierWhitelist = (HashSet_1_System_String_ *)v15;
			//           sub_1800054D0(
			//             (OneofDescriptor *)&v47.value,
			//             (OneofDescriptorProto *)index,
			//             dictionary,
			//             (MessageDescriptor *)v8,
			//             (String__Array *)methoda,
			//             v43,
			//             (MethodInfo *)v44.m_ListData);
			//           v48._current = v47;
			//           sub_1800054D0(
			//             (OneofDescriptor *)&v48._current.value,
			//             v17,
			//             v18,
			//             v19,
			//             (String__Array *)methoda,
			//             v43,
			//             (MethodInfo *)v44.m_ListData);
			//           *(_OWORD *)&v47.key = *(_OWORD *)&v48._current.key;
			//           *(_OWORD *)&v52._dictionary = *(_OWORD *)&v48._current.key;
			//           v20 = *(__m128d *)&v48._current.value.logicIdWhitelist;
			//           v51 = *(__m128d *)&v48._current.value.logicIdWhitelist;
			//           *(_OWORD *)&v52._current.key = *(_OWORD *)&v48._current.value.logicIdWhitelist;
			//           logicIdWhitelist = v48._current.value.logicIdWhitelist;
			//           v7 = (__int64)MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::get_Length.klass;
			//           if ( (*(_BYTE *)(v7 + 312) & 1) == 0 )
			//           {
			//             sub_18003C700(v7);
			//             v20 = v51;
			//           }
			//           if ( !LODWORD(logicIdWhitelist.monitor) )
			//           {
			//             if ( *(_QWORD *)&v20.m128d_f64[0] )
			//             {
			//               v55 = *(NativeList_1_UnityEngine_Matrix4x4_ *)&v52._version;
			//               v56 = *(_OWORD *)&_mm_unpackhi_pd(v20, v20);
			//               Unity::Collections::NativeList<UnityEngine::Matrix4x4>::Dispose(
			//                 (NativeList_1_UnityEngine_Matrix4x4_ *)&v55.m_DeprecatedAllocator,
			//                 MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::Dispose);
			//             }
			//             LODWORD(value) = _mm_cvtsi128_si32(*(__m128i *)&v47.key);
			//             v22 = MethodInfo::Unity::Collections::NativeList<int>::Add.klass;
			//             if ( ((__int64)v22.vtable[0].methodPtr & 1) == 0 )
			//               sub_18003C700(MethodInfo::Unity::Collections::NativeList<int>::Add.klass);
			//             Unity::Collections::LowLevel::Unsafe::UnsafeList<int>::Add(
			//               m_ListData,
			//               (int32_t *)&value,
			//               (MethodInfo *)v22.rgctx_data[12].rgctxDataDummy);
			//           }
			//           goto LABEL_6;
			//         }
			//       }
			//       v48._index = v48._dictionary.fields._count + 1;
			//       memset(&v48._current, 0, sizeof(v48._current));
			//     }
			//     catch ( Il2CppExceptionWrapper *v53 )
			//     {
			//       index = (unsigned __int64)&v41;
			//       ex = v53.ex;
			//       v7 = (__int64)ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v2 = this;
			//       m_ListData = v44.m_ListData;
			//     }
			//     v24 = MethodInfo::Unity::Collections::NativeList<int>::GetEnumerator;
			//     v25 = MethodInfo::Unity::Collections::NativeList<int>::GetEnumerator.klass;
			//     if ( ((__int64)v25.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(MethodInfo::Unity::Collections::NativeList<int>::GetEnumerator.klass);
			//     v26.rgctxDataDummy = v25.rgctx_data[24].rgctxDataDummy;
			//     if ( !m_ListData )
			//       sub_1802DC2C8(v7, index);
			//     Ptr = (UnsafeList_1_System_Int32_ *)m_ListData.Ptr;
			//     v28 = *((_QWORD *)v26.rgctxDataDummy + 4);
			//     if ( (*(_BYTE *)(v28 + 312) & 1) == 0 )
			//       sub_18003C700(v28);
			//     m_length = (AllocatorManager_AllocatorHandle)m_ListData.m_length;
			//     v30 = *((_QWORD *)v26.rgctxDataDummy + 4);
			//     if ( (*(_BYTE *)(v30 + 312) & 1) == 0 )
			//       sub_18003C700(v30);
			//     v44.m_ListData = Ptr;
			//     v44.m_DeprecatedAllocator = m_length;
			//     *((_DWORD *)&v44.m_DeprecatedAllocator + 1) = 1;
			//     HIDWORD(v47.value.logicIdWhitelist) = 0;
			//     v31 = v24.klass;
			//     if ( ((__int64)v31.vtable[0].methodPtr & 1) == 0 )
			//       sub_18003C700(v31);
			//     v47.value.logicIdWhitelist = (HashSet_1_System_UInt64_ *)0xFFFFFFFFLL;
			//     v45 = v44;
			//     v46 = 0xFFFFFFFFLL;
			//     v44.m_ListData = 0LL;
			//     *(_QWORD *)&v44.m_DeprecatedAllocator.Index = &v45;
			//     try
			//     {
			//       while ( 1 )
			//       {
			//         v32 = v46 + 1;
			//         LODWORD(v46) = v32;
			//         if ( v32 >= *(_DWORD *)&v45.m_DeprecatedAllocator )
			//           break;
			//         v33 = v45.m_ListData;
			//         v34 = MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<int>::MoveNext.klass;
			//         if ( ((__int64)v34.vtable[0].methodPtr & 1) == 0 )
			//           sub_18003C700(v34);
			//         rgctx_data = v34.rgctx_data;
			//         if ( !*((_QWORD *)rgctx_data.rgctxDataDummy + 7) )
			//           sub_180041F40(rgctx_data.rgctxDataDummy);
			//         v36 = *((unsigned int *)&v33.Ptr + v32);
			//         HIDWORD(v46) = *((_DWORD *)&v33.Ptr + v32);
			//         m_interactMeshMatrixDict = v2.fields.m_interactMeshMatrixDict;
			//         if ( !m_interactMeshMatrixDict )
			//           sub_1802DC2C8(0LL, v36);
			//         System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::Remove(
			//           m_interactMeshMatrixDict,
			//           v36,
			//           MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::Remove);
			//       }
			//       HIDWORD(v46) = 0;
			//     }
			//     catch ( Il2CppExceptionWrapper *v54 )
			//     {
			//       v44.m_ListData = (UnsafeList_1_System_Int32_ *)v54.ex;
			//       if ( v44.m_ListData )
			//         sub_18000F780(v44.m_ListData);
			//     }
			//   }
			// }
			// 
		}

		public HGFoliageInteractiveConfig GetConfig()
		{
			// // HGFoliageInteractiveConfig GetConfig()
			// HGFoliageInteractiveConfig *HG::Rendering::Runtime::HGFoliageInteractiveManager::GetConfig(
			//         HGFoliageInteractiveConfig *__return_ptr retstr,
			//         HGFoliageInteractiveManager *this,
			//         MethodInfo *method)
			// {
			//   __int128 v5; // xmm0
			//   int32_t graphicsFormat; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   HGFoliageInteractiveConfig *v10; // rax
			//   HGFoliageInteractiveConfig v12[2]; // [rsp+20h] [rbp-28h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1419, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1419, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_538(v12, Patch, (Object *)this, 0LL);
			//     v5 = *(_OWORD *)&v10.textureSize.m_X;
			//     graphicsFormat = v10.graphicsFormat;
			//   }
			//   else
			//   {
			//     v5 = *(_OWORD *)&this.fields.m_config.textureSize.m_X;
			//     graphicsFormat = this.fields.m_config.graphicsFormat;
			//   }
			//   *(_OWORD *)&retstr.textureSize.m_X = v5;
			//   retstr.graphicsFormat = graphicsFormat;
			//   return retstr;
			// }
			// 
			return null;
		}

		public void SetCharacterPositions(List<Vector3> characterPositions)
		{
			// // Void SetCharacterPositions(List`1[UnityEngine.Vector3])
			// void HG::Rendering::Runtime::HGFoliageInteractiveManager::SetCharacterPositions(
			//         HGFoliageInteractiveManager *this,
			//         List_1_UnityEngine_Vector3_ *characterPositions,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_UnityEngine_Vector3_ *v6; // rcx
			//   List_1_UnityEngine_Vector3_ *m_characterPoses; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDCBD )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::AddRange);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Clear);
			//     byte_18D8EDCBD = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1420, 0LL) )
			//   {
			//     m_characterPoses = this.fields.m_characterPoses;
			//     if ( m_characterPoses )
			//     {
			//       ++m_characterPoses.fields._version;
			//       m_characterPoses.fields._size = 0;
			//       v6 = this.fields.m_characterPoses;
			//       if ( v6 )
			//       {
			//         System::Collections::Generic::List<UnityEngine::Vector3>::AddRange(
			//           v6,
			//           (IEnumerable_1_UnityEngine_Vector3_ *)characterPositions,
			//           MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::AddRange);
			//         return;
			//       }
			//     }
			// LABEL_7:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1420, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)characterPositions,
			//     0LL);
			// }
			// 
		}

		public void AddInteractToManager(HGFoliageInteract interact)
		{
			// // Void AddInteractToManager(HGFoliageInteract)
			// void HG::Rendering::Runtime::HGFoliageInteractiveManager::AddInteractToManager(
			//         HGFoliageInteractiveManager *this,
			//         HGFoliageInteract *interact,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *m_externInteracts; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919DCF )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteract>::Add);
			//     byte_18D919DCF = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1408, 0LL) )
			//   {
			//     m_externInteracts = (List_1_System_Object_ *)this.fields.m_externInteracts;
			//     if ( m_externInteracts )
			//     {
			//       sub_1822AD140(m_externInteracts, (Object *)interact);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(m_externInteracts, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1408, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)interact,
			//     0LL);
			// }
			// 
		}

		public void AddInteractRaftToManager(HGFoliageInteractRaft raft)
		{
			// // Void AddInteractRaftToManager(HGFoliageInteractRaft)
			// void HG::Rendering::Runtime::HGFoliageInteractiveManager::AddInteractRaftToManager(
			//         HGFoliageInteractiveManager *this,
			//         HGFoliageInteractRaft *raft,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *m_interactRaftList; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919DD0 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteractRaft>::Add);
			//     byte_18D919DD0 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1421, 0LL) )
			//   {
			//     m_interactRaftList = (List_1_System_Object_ *)this.fields.m_interactRaftList;
			//     if ( m_interactRaftList )
			//     {
			//       sub_1822AD140(m_interactRaftList, (Object *)raft);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(m_interactRaftList, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1421, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)raft,
			//     0LL);
			// }
			// 
		}

		public void RemoveInteractFromManager(HGFoliageInteract interact)
		{
			// // Void RemoveInteractFromManager(HGFoliageInteract)
			// void HG::Rendering::Runtime::HGFoliageInteractiveManager::RemoveInteractFromManager(
			//         HGFoliageInteractiveManager *this,
			//         HGFoliageInteract *interact,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *m_externInteracts; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919DD1 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteract>::Remove);
			//     byte_18D919DD1 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1410, 0LL) )
			//   {
			//     m_externInteracts = (List_1_System_Object_ *)this.fields.m_externInteracts;
			//     if ( m_externInteracts )
			//     {
			//       System::Collections::Generic::List<System::Object>::Remove(
			//         m_externInteracts,
			//         (Object *)interact,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteract>::Remove);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(m_externInteracts, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1410, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)interact,
			//     0LL);
			// }
			// 
		}

		public void RemoveInteractRaftFromManager(HGFoliageInteractRaft raft)
		{
			// // Void RemoveInteractRaftFromManager(HGFoliageInteractRaft)
			// void HG::Rendering::Runtime::HGFoliageInteractiveManager::RemoveInteractRaftFromManager(
			//         HGFoliageInteractiveManager *this,
			//         HGFoliageInteractRaft *raft,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *m_interactRaftList; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919DD2 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteractRaft>::Remove);
			//     byte_18D919DD2 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1422, 0LL) )
			//   {
			//     m_interactRaftList = (List_1_System_Object_ *)this.fields.m_interactRaftList;
			//     if ( m_interactRaftList )
			//     {
			//       System::Collections::Generic::List<System::Object>::Remove(
			//         m_interactRaftList,
			//         (Object *)raft,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteractRaft>::Remove);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(m_interactRaftList, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1422, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)raft,
			//     0LL);
			// }
			// 
		}

		public void SetInterctCenterPosition(Vector3 centerPos)
		{
			// // Void SetInterctCenterPosition(Vector3)
			// void HG::Rendering::Runtime::HGFoliageInteractiveManager::SetInterctCenterPosition(
			//         HGFoliageInteractiveManager *this,
			//         Vector3 *centerPos,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 v8; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1423, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1423, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v5);
			//     z = centerPos.z;
			//     *(_QWORD *)&v8.x = *(_QWORD *)&centerPos.x;
			//     v8.z = z;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_330(Patch, (Object *)this, &v8, 0LL);
			//   }
			//   else
			//   {
			//     if ( fabs(this.fields.m_centerPos.y - centerPos.y) > 0.2 )
			//       this.fields.m_centerPos.y = centerPos.y;
			//     this.fields.m_centerPos.x = centerPos.x;
			//     this.fields.m_centerPos.z = centerPos.z;
			//   }
			// }
			// 
		}

		public void SetupShaderVariablesGlobalFoliageInteract(ref ShaderVariablesGlobal cb)
		{
			// // Void SetupShaderVariablesGlobalFoliageInteract(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::HGFoliageInteractiveManager::SetupShaderVariablesGlobalFoliageInteract(
			//         HGFoliageInteractiveManager *this,
			//         ShaderVariablesGlobal *cb,
			//         MethodInfo *method)
			// {
			//   List_1_System_Object_ *m_interactRaftList; // rcx
			//   __int64 v6; // rdx
			//   __m128 x_low; // xmm6
			//   float x; // xmm7_4
			//   float y; // xmm8_4
			//   float CapsuleProxyRadius; // xmm12_4
			//   float z; // xmm9_4
			//   float v12; // xmm10_4
			//   float v13; // xmm11_4
			//   __m128 v14; // xmm6
			//   __m128 v15; // xmm6
			//   __m128 v16; // xmm6
			//   __m128 v17; // xmm6
			//   __m128 v18; // xmm1
			//   __m128 v19; // xmm1
			//   __m128 v20; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v22; // rdx
			//   Object *Item; // rsi
			//   Object *v24; // rax
			//   Vector3 *CapsuleProxyPositionA; // rax
			//   Object *v26; // rax
			//   Vector3 *CapsuleProxyPositionB; // rax
			//   __int64 v28; // xmm0_8
			//   Object *v29; // rax
			//   Vector3 v30; // [rsp+20h] [rbp-A8h]
			//   Vector3 v31; // [rsp+30h] [rbp-98h] BYREF
			//   __m128 v32; // [rsp+40h] [rbp-88h] BYREF
			// 
			//   if ( !byte_18D8EDCBE )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteractRaft>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteractRaft>::get_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDCBE = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   m_interactRaftList = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, cb);
			//     m_interactRaftList = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v6 = **(_QWORD **)&m_interactRaftList[4].fields._size;
			//   if ( !v6 )
			//     goto LABEL_12;
			//   if ( *(int *)(v6 + 24) <= 871 )
			//     goto LABEL_9;
			//   if ( !m_interactRaftList[5].fields._size )
			//   {
			//     il2cpp_runtime_class_init_0(m_interactRaftList, v6);
			//     m_interactRaftList = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   m_interactRaftList = **(List_1_System_Object_ ***)&m_interactRaftList[4].fields._size;
			//   if ( !m_interactRaftList )
			//     goto LABEL_12;
			//   if ( m_interactRaftList.fields._size <= 0x367u )
			//     sub_180070270(m_interactRaftList, v6);
			//   if ( !m_interactRaftList[175].klass )
			//   {
			// LABEL_9:
			//     x_low = (__m128)0x461C4000u;
			//     x = 10001.0;
			//     y = 10000.0;
			//     CapsuleProxyRadius = 0.001;
			//     z = 10000.0;
			//     v12 = 10000.0;
			//     v13 = 10001.0;
			//     if ( !this.fields.m_interactRaftList || this.fields.m_interactRaftList.fields._size <= 0 )
			//       goto LABEL_11;
			//     Item = System::Collections::Generic::List<System::Object>::get_Item(
			//              (List_1_System_Object_ *)this.fields.m_interactRaftList,
			//              0,
			//              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteractRaft>::get_Item);
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v22);
			//     if ( !UnityEngine::Object::op_Inequality((Object_1 *)Item, 0LL, 0LL) )
			//       goto LABEL_11;
			//     m_interactRaftList = (List_1_System_Object_ *)this.fields.m_interactRaftList;
			//     if ( m_interactRaftList )
			//     {
			//       v24 = System::Collections::Generic::List<System::Object>::get_Item(
			//               m_interactRaftList,
			//               0,
			//               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteractRaft>::get_Item);
			//       if ( v24 )
			//       {
			//         CapsuleProxyPositionA = HG::Rendering::Runtime::HGFoliageInteractRaft::GetCapsuleProxyPositionA(
			//                                   &v31,
			//                                   (HGFoliageInteractRaft *)v24,
			//                                   0LL);
			//         m_interactRaftList = (List_1_System_Object_ *)this.fields.m_interactRaftList;
			//         v30 = *CapsuleProxyPositionA;
			//         if ( m_interactRaftList )
			//         {
			//           v26 = System::Collections::Generic::List<System::Object>::get_Item(
			//                   m_interactRaftList,
			//                   0,
			//                   MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteractRaft>::get_Item);
			//           if ( v26 )
			//           {
			//             CapsuleProxyPositionB = HG::Rendering::Runtime::HGFoliageInteractRaft::GetCapsuleProxyPositionB(
			//                                       (Vector3 *)&v32,
			//                                       (HGFoliageInteractRaft *)v26,
			//                                       0LL);
			//             m_interactRaftList = (List_1_System_Object_ *)this.fields.m_interactRaftList;
			//             v28 = *(_QWORD *)&CapsuleProxyPositionB.x;
			//             *(float *)&CapsuleProxyPositionB = CapsuleProxyPositionB.z;
			//             *(_QWORD *)&v31.x = v28;
			//             LODWORD(v31.z) = (_DWORD)CapsuleProxyPositionB;
			//             if ( m_interactRaftList )
			//             {
			//               v29 = System::Collections::Generic::List<System::Object>::get_Item(
			//                       m_interactRaftList,
			//                       0,
			//                       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteractRaft>::get_Item);
			//               if ( v29 )
			//               {
			//                 z = v30.z;
			//                 CapsuleProxyRadius = HG::Rendering::Runtime::HGFoliageInteractRaft::GetCapsuleProxyRadius(
			//                                        (HGFoliageInteractRaft *)v29,
			//                                        0LL);
			//                 y = v30.y;
			//                 x_low = (__m128)LODWORD(v30.x);
			//                 v13 = v31.z;
			//                 v12 = v31.y;
			//                 x = v31.x;
			// LABEL_11:
			//                 v14 = _mm_shuffle_ps(x_low, x_low, 225);
			//                 v14.m128_f32[0] = y;
			//                 v15 = _mm_shuffle_ps(v14, v14, 198);
			//                 v15.m128_f32[0] = z;
			//                 v16 = _mm_shuffle_ps(v15, v15, 39);
			//                 v16.m128_f32[0] = CapsuleProxyRadius;
			//                 v17 = _mm_shuffle_ps(v16, v16, 57);
			//                 v32 = v17;
			//                 v32.m128_i32[3] = 0;
			//                 v18 = v32;
			//                 *(__m128 *)&cb[1]._WiderFoVInvViewProjMatrix.m01 = v17;
			//                 v18.m128_f32[0] = x;
			//                 v19 = _mm_shuffle_ps(v18, v18, 225);
			//                 v19.m128_f32[0] = v12;
			//                 v20 = _mm_shuffle_ps(v19, v19, 198);
			//                 v20.m128_f32[0] = v13;
			//                 *(__m128 *)&cb[1]._WiderFoVInvViewProjMatrix.m02 = _mm_shuffle_ps(v20, v20, 201);
			//                 return;
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(m_interactRaftList, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(871, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_340(Patch, (Object *)this, cb, 0LL);
			// }
			// 
		}

		private HGFoliageInteractiveConfig m_config;

		private Vector3 m_centerPos;

		private List<Vector3> m_characterPoses;

		private List<HGFoliageInteract> m_externInteracts;

		private List<HGFoliageInteractRaft> m_interactRaftList;

		private Dictionary<int, HGFoliageInteractiveMeshMatrixes> m_interactMeshMatrixDict;

		private Mesh m_characterColliderMesh;

		private int m_characterColliderMeshID;

		private const float CLEAN_TIME = 60f;

		private float m_lastCleanTime;

		private bool m_enabled;
	}
}
