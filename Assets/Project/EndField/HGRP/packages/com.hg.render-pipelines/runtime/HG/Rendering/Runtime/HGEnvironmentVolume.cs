using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Beyond;
using UnityEngine;
using UnityEngine.Serialization;

namespace HG.Rendering.Runtime
{
	[DisallowMultipleComponent]
	[AddComponentMenu("Rendering/Environment Volume")]
	[ExecuteAlways]
	public class HGEnvironmentVolume : VFXPlayableMonoBase, IComparable<HGEnvironmentVolume>
	{
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x00002800 File Offset: 0x00000A00
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x000025D0 File Offset: 0x000007D0
		public EnvVolumeType volumeType
		{
			get
			{
				// // Int32 get_count()
				// int32_t Beyond::UnorderedList<System::Object>::get_count(UnorderedList_1_System_Object_ *this, MethodInfo *method)
				// {
				//   return this.fields._count_k__BackingField;
				// }
				// 
				return (EnvVolumeType)EnvVolumeType.Global;
			}
			set
			{
				// // Void set_volumeType(EnvVolumeType)
				// void HG::Rendering::Runtime::HGEnvironmentVolume::set_volumeType(
				//         HGEnvironmentVolume *this,
				//         EnvVolumeType__Enum value,
				//         MethodInfo *method)
				// {
				//   HG::Rendering::Runtime::HGEnvironmentVolume::_UpdateVolumeType(this, value, 0LL);
				// }
				// 
			}
		}

		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00002818 File Offset: 0x00000A18
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x000025D0 File Offset: 0x000007D0
		public EnvBlendMode blendMode
		{
			get
			{
				// // Int32 get_Count()
				// int32_t TMPro::TMP_TextProcessingStack<TMPro::HighlightState>::get_Count(
				//         TMP_TextProcessingStack_1_HighlightState_ *this,
				//         MethodInfo *method)
				// {
				//   return this.m_RolloverSize;
				// }
				// 
				return (EnvBlendMode)EnvBlendMode.None;
			}
			set
			{
				// // Void set_countAll(Int32)
				// void TMPro::TMP_ObjectPool<System::Object>::set_countAll(
				//         TMP_ObjectPool_1_System_Object_ *this,
				//         int32_t value,
				//         MethodInfo *method)
				// {
				//   this.fields._countAll_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00002830 File Offset: 0x00000A30
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x000025D0 File Offset: 0x000007D0
		public EnvPriority priority
		{
			get
			{
				// // Int32Enum get_defaultValue()
				// Int32Enum__Enum HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::get_defaultValue(
				//         SettingParameter_1_System_Int32Enum_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._defaultValue_k__BackingField;
				// }
				// 
				return (EnvPriority)EnvPriority.BlockOut;
			}
			set
			{
				// // Void set_priority(EnvPriority)
				// void HG::Rendering::Runtime::HGEnvironmentVolume::set_priority(
				//         HGEnvironmentVolume *this,
				//         EnvPriority__Enum value,
				//         MethodInfo *method)
				// {
				//   HG::Rendering::Runtime::HGEnvironmentVolume::_UpdatePriority(this, value, 0LL);
				// }
				// 
			}
		}

		// (get) Token: 0x060005FB RID: 1531 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x000025D0 File Offset: 0x000007D0
		public float blendDistance
		{
			get
			{
				// // Single get_hintWeight()
				// float UnityEngine::Animations::Rigging::TwoBoneIKConstraintData::get_hintWeight(
				//         TwoBoneIKConstraintData *this,
				//         MethodInfo *method)
				// {
				//   return this.m_HintWeight;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_meanLine(Single)
				// void UnityEngine::TextCore::FaceInfo::set_meanLine(FaceInfo *this, float value, MethodInfo *method)
				// {
				//   this.m_MeanLine = value;
				// }
				// 
			}
		}

		// (get) Token: 0x060005FD RID: 1533 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x000025D0 File Offset: 0x000007D0
		public float fadeInDuration
		{
			get
			{
				// // Single GetLength()
				// float UnityEngine::Splines::NativeSpline::GetLength(NativeSpline *this, MethodInfo *method)
				// {
				//   return this.m_Length;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_baseline(Single)
				// void UnityEngine::TextCore::FaceInfo::set_baseline(FaceInfo *this, float value, MethodInfo *method)
				// {
				//   this.m_Baseline = value;
				// }
				// 
			}
		}

		// (get) Token: 0x060005FF RID: 1535 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x000025D0 File Offset: 0x000007D0
		public float fadeOutDuration
		{
			get
			{
				// // Single get_Width()
				// float HG::Rendering::HgMath::CellGrid2D<System::Object>::get_Width(
				//         CellGrid2D_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._Width_k__BackingField;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_Width(Single)
				// void HG::Rendering::HgMath::CellGrid2D<System::Object>::set_Width(
				//         CellGrid2D_1_System_Object_ *this,
				//         float value,
				//         MethodInfo *method)
				// {
				//   this.fields._Width_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000601 RID: 1537 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x000025D0 File Offset: 0x000007D0
		public float manualBlendFactor
		{
			get
			{
				// // Single get_Height()
				// float HG::Rendering::HgMath::CellGrid2D<System::Object>::get_Height(
				//         CellGrid2D_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._Height_k__BackingField;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_Height(Single)
				// void HG::Rendering::HgMath::CellGrid2D<System::Object>::set_Height(
				//         CellGrid2D_1_System_Object_ *this,
				//         float value,
				//         MethodInfo *method)
				// {
				//   this.fields._Height_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000603 RID: 1539 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x000025D0 File Offset: 0x000007D0
		public virtual HGEnvironmentPhase envPhase
		{
			get
			{
				// // ValueHandler`1[UnityEngine.Vector4] get_getter()
				// ValueHandler_1_UnityEngine_Vector4_ *FlowCanvas::ValueOutput<UnityEngine::Vector4>::get_getter(
				//         ValueOutput_1_UnityEngine_Vector4_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._getter_k__BackingField;
				// }
				// 
				return null;
			}
			set
			{
				// // Void set_envPhase(HGEnvironmentPhase)
				// void HG::Rendering::Runtime::HGEnvironmentVolume::set_envPhase(
				//         HGEnvironmentVolume *this,
				//         HGEnvironmentPhase *value,
				//         MethodInfo *method)
				// {
				//   MessageDescriptor *v3; // r9
				//   String__Array *v4; // [rsp+28h] [rbp+28h]
				//   String *v5; // [rsp+30h] [rbp+30h]
				//   MethodInfo *v6; // [rsp+38h] [rbp+38h]
				// 
				//   this.fields._envPhase = value;
				//   sub_1800054D0(
				//     (OneofDescriptor *)&this.fields._envPhase,
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

		// (get) Token: 0x06000605 RID: 1541 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x000025D0 File Offset: 0x000007D0
		public BeyondPolyLineShape polyLineShape
		{
			get
			{
				// // String get_propertyPath()
				// String *NodeCanvas::Framework::Variable<UnityEngine::Vector2>::get_propertyPath(
				//         Variable_1_UnityEngine_Vector2_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._propertyPath;
				// }
				// 
				return null;
			}
			set
			{
				// // Void set_propertyPath(String)
				// void NodeCanvas::Framework::Variable<UnityEngine::Vector2>::set_propertyPath(
				//         Variable_1_UnityEngine_Vector2_ *this,
				//         String *value,
				//         MethodInfo *method)
				// {
				//   MessageDescriptor *v3; // r9
				//   String__Array *v4; // [rsp+28h] [rbp+28h]
				//   String *v5; // [rsp+30h] [rbp+30h]
				//   MethodInfo *v6; // [rsp+38h] [rbp+38h]
				// 
				//   this.fields._propertyPath = value;
				//   sub_1800054D0(
				//     (OneofDescriptor *)&this.fields._propertyPath,
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

		// (get) Token: 0x06000607 RID: 1543 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool timeFadingOut
		{
			[CompilerGenerated]
			get
			{
				// // Boolean get_exists()
				// bool FlowCanvas::Nodes::TryGetValue<UnityEngine::Keyframe>::get_exists(
				//         TryGetValue_1_UnityEngine_Keyframe_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._exists_k__BackingField;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
				// // Void set_exists(Boolean)
				// void FlowCanvas::Nodes::TryGetValue<UnityEngine::Keyframe>::set_exists(
				//         TryGetValue_1_UnityEngine_Keyframe_ *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields._exists_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000609 RID: 1545 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x000025D0 File Offset: 0x000007D0
		public float timeFadingFactor
		{
			[CompilerGenerated]
			get
			{
				// // Single get_PeekAmount()
				// float SRDebugger::UI::MobileMenuController::get_PeekAmount(MobileMenuController *this, MethodInfo *method)
				// {
				//   return this.fields._peekAmount;
				// }
				// 
				return 0f;
			}
			[CompilerGenerated]
			set
			{
				// // Void set_strikethroughOffset(Single)
				// void UnityEngine::TextCore::FaceInfo::set_strikethroughOffset(FaceInfo *this, float value, MethodInfo *method)
				// {
				//   this.m_StrikethroughOffset = value;
				// }
				// 
			}
		}

		public HGEnvironmentVolume()
		{
		}

		public virtual bool HasEnvPhase()
		{
			// // Boolean HasEnvPhase()
			// bool HG::Rendering::Runtime::HGEnvironmentVolume::HasEnvPhase(HGEnvironmentVolume *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   struct ILFixDynamicMethodWrapper_2__Class *static_fields; // rcx
			//   int *image; // rdx
			//   HGEnvironmentPhase *(*v6)(HGEnvironmentVolume *, MethodInfo *); // r8
			//   Il2CppMethodPointer methodPtr; // rdx
			//   HGEnvironmentPhase *v8; // rax
			//   HGEnvironmentPhase *envPhase; // rbx
			//   __int64 v11; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ILFixDynamicMethodWrapper_2 *v13; // rax
			// 
			//   if ( !byte_18D8EDC4E )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDC4E = 1;
			//   }
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
			//   static_fields = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields;
			//   image = (int *)static_fields._0.image;
			//   if ( !static_fields._0.image )
			//     goto LABEL_33;
			//   if ( image[6] > 593 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, image);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     image = (int *)v3.static_fields;
			//     v11 = *(_QWORD *)image;
			//     if ( !*(_QWORD *)image )
			//       goto LABEL_33;
			//     if ( *(_DWORD *)(v11 + 24) <= 0x251u )
			//       goto LABEL_48;
			//     if ( *(_QWORD *)(v11 + 4776) )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(593, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//       goto LABEL_33;
			//     }
			//   }
			//   sub_180003EE0(this.klass);
			//   v6 = (HGEnvironmentPhase *(*)(HGEnvironmentVolume *, MethodInfo *))this.klass.vtable.get_envPhase.method;
			//   methodPtr = this.klass.vtable.set_envPhase.methodPtr;
			//   if ( v6 == HG::Rendering::Runtime::HGEnvironmentVolume::GetEnvPhaseForInterpolate )
			//   {
			//     if ( !byte_18D8EDC37 )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       byte_18D8EDC37 = 1;
			//     }
			//     static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, methodPtr);
			//       static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     image = (int *)static_fields.static_fields.wrapperArray;
			//     if ( !image )
			//       goto LABEL_33;
			//     if ( image[6] <= 599 )
			//     {
			// LABEL_31:
			//       envPhase = this.fields._envPhase;
			//       goto LABEL_12;
			//     }
			//     if ( !static_fields._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(static_fields, image);
			//       static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     static_fields = (struct ILFixDynamicMethodWrapper_2__Class *)static_fields.static_fields.wrapperArray;
			//     if ( !static_fields )
			// LABEL_33:
			//       sub_180B536AC(static_fields, image);
			//     if ( LODWORD(static_fields._0.namespaze) > 0x257 )
			//     {
			//       if ( !static_fields[12].vtable.Equals.methodPtr )
			//         goto LABEL_31;
			//       v13 = IFix::WrappersManagerImpl::GetPatch(599, 0LL);
			//       if ( v13 )
			//       {
			//         v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_199(v13, (Object *)this, 0LL);
			//         goto LABEL_11;
			//       }
			//       goto LABEL_33;
			//     }
			// LABEL_48:
			//     sub_180070270(static_fields, image);
			//   }
			//   v8 = (HGEnvironmentPhase *)((__int64 (__fastcall *)(HGEnvironmentVolume *, Il2CppMethodPointer))v6)(this, methodPtr);
			// LABEL_11:
			//   envPhase = v8;
			// LABEL_12:
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, image);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, image);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( !envPhase )
			//     return 0;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, image);
			//   return envPhase.fields._._.m_CachedPtr != 0;
			// }
			// 
			return default(bool);
		}

		public virtual HGEnvironmentPhase GetEnvPhaseForInterpolate()
		{
			// // HGEnvironmentPhase GetEnvPhaseForInterpolate()
			// HGEnvironmentPhase *HG::Rendering::Runtime::HGEnvironmentVolume::GetEnvPhaseForInterpolate(
			//         HGEnvironmentVolume *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2__Array *v7; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
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
			//   static_fields = v3.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 599 )
			//     return this.fields._envPhase;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v3.static_fields;
			//   v7 = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( v7.max_length.size <= 0x257u )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( !v7[16].vector[23] )
			//     return this.fields._envPhase;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(599, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_199(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public bool Contains(Vector3 triggerPos)
		{
			// // Boolean Contains(Vector3)
			// bool HG::Rendering::Runtime::HGEnvironmentVolume::Contains(
			//         HGEnvironmentVolume *this,
			//         Vector3 *triggerPos,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v11[2]; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, triggerPos);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 594 )
			//   {
			// LABEL_7:
			//     z = triggerPos.z;
			//     *(_QWORD *)&v11[0].x = *(_QWORD *)&triggerPos.x;
			//     v11[0].z = z;
			//     return HG::Rendering::Runtime::HGEnvironmentVolume::_DistanceToEdge(this, v11, 0LL) > 0.0;
			//   }
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, wrapperArray);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//   if ( !v5 )
			//     goto LABEL_8;
			//   if ( LODWORD(v5._0.namespaze) <= 0x252 )
			//     sub_180070270(v5, wrapperArray);
			//   if ( !*(_QWORD *)&v5[12]._1.thread_static_fields_offset )
			//     goto LABEL_7;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(594, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(v5, wrapperArray);
			//   v10 = *(_QWORD *)&triggerPos.x;
			//   v11[0].z = triggerPos.z;
			//   *(_QWORD *)&v11[0].x = v10;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_231(Patch, (Object *)this, v11, 0LL);
			// }
			// 
			return default(bool);
		}

		public int CompareTo(HGEnvironmentVolume other)
		{
			// // Int32 CompareTo(HGEnvironmentVolume)
			// int32_t HG::Rendering::Runtime::HGEnvironmentVolume::CompareTo(
			//         HGEnvironmentVolume *this,
			//         HGEnvironmentVolume *other,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   __int64 v7; // r8
			//   int32_t priority; // edi
			//   __int64 v9; // rdx
			//   Object *v10; // rbx
			//   Object *v11; // r8
			//   struct EnvPriority__Enum__Class *v12; // rsi
			//   int32_t result; // eax
			//   int32_t volumeType; // edi
			//   __int64 v15; // rdx
			//   Object *v16; // rbx
			//   Object *v17; // r8
			//   struct EnvVolumeType__Enum__Class *v18; // rsi
			//   String *v19; // rdi
			//   __int64 v20; // rax
			//   SystemException *v21; // rax
			//   __int64 v22; // rdx
			//   __int64 v23; // rcx
			//   SystemException *v24; // rbx
			//   __int64 v25; // rax
			//   __int64 object_0; // rsi
			//   __int64 v27; // rbx
			//   __int64 v28; // rax
			//   __int64 v29; // r8
			//   __int64 v30; // r9
			//   Object__Array *v31; // rdi
			//   __int64 v32; // rax
			//   __int64 v33; // rbx
			//   __int64 v34; // rbx
			//   String *v35; // rax
			//   String *ResourceString; // rdi
			//   __int64 v37; // rax
			//   SystemException *v38; // rax
			//   SystemException *v39; // rbx
			//   __int64 v40; // rax
			//   String *v41; // rdi
			//   __int64 v42; // rax
			//   SystemException *v43; // rax
			//   __int64 v44; // rdx
			//   __int64 v45; // rcx
			//   SystemException *v46; // rbx
			//   __int64 v47; // rax
			//   __int64 v48; // rsi
			//   __int64 v49; // rbx
			//   __int64 v50; // rax
			//   __int64 v51; // r8
			//   __int64 v52; // r9
			//   Object__Array *v53; // rdi
			//   __int64 v54; // rax
			//   __int64 v55; // rbx
			//   __int64 v56; // rbx
			//   String *v57; // rax
			//   String *v58; // rdi
			//   __int64 v59; // rax
			//   SystemException *v60; // rax
			//   SystemException *v61; // rbx
			//   __int64 v62; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   void *v64; // [rsp+20h] [rbp-28h] BYREF
			//   __int64 v65; // [rsp+28h] [rbp-20h]
			//   int32_t v66; // [rsp+30h] [rbp-18h]
			//   __int64 v67; // [rsp+68h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D8EDC4F )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::EnvPriority);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::EnvVolumeType);
			//     byte_18D8EDC4F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(587, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(587, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_99(
			//                (ILFixDynamicMethodWrapper_17 *)Patch,
			//                (Object *)this,
			//                (Object *)other,
			//                0LL);
			// LABEL_18:
			//     sub_180B536AC(v6, v5);
			//   }
			//   if ( !other )
			//     goto LABEL_18;
			//   if ( this.fields._priority == other.fields._priority )
			//   {
			//     volumeType = this.fields._volumeType;
			//     LODWORD(v67) = other.fields._volumeType;
			//     v16 = (Object *)il2cpp_value_box(TypeInfo::HG::Rendering::Runtime::EnvVolumeType, &v67, v7);
			//     v18 = TypeInfo::HG::Rendering::Runtime::EnvVolumeType;
			//     v64 = TypeInfo::HG::Rendering::Runtime::EnvVolumeType;
			//     v65 = -1LL;
			//     v66 = volumeType;
			//     if ( !byte_18D8F238E )
			//     {
			//       sub_18003C530(&TypeInfo::System::Enum);
			//       byte_18D8F238E = 1;
			//     }
			//     if ( !TypeInfo::System::Enum._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::System::Enum, v15);
			//     result = System::Enum::InternalCompareTo((System::Enum *)&v64, v16, v17);
			//     if ( result >= 2 )
			//     {
			//       if ( result == 2 )
			//       {
			//         object_0 = il2cpp_type_get_object_0(&v18._0.byval_arg);
			//         if ( v16 )
			//         {
			//           v27 = il2cpp_type_get_object_0(&v16.klass._0.byval_arg);
			//           v28 = sub_18003C530(&TypeInfo::System::Object);
			//           v31 = (Object__Array *)il2cpp_array_new_specific_0(v28, 2LL, v29, v30);
			//           if ( v27 )
			//           {
			//             v32 = sub_18003F3E0(3LL, v27);
			//             v33 = v32;
			//             if ( v31 )
			//             {
			//               sub_180036D40(v31, v32);
			//               sub_1800046C0(v31, 0LL, v33);
			//               if ( object_0 )
			//               {
			//                 v34 = sub_18003F3E0(3LL, object_0);
			//                 sub_180036D40(v31, v34);
			//                 sub_1800046C0(v31, 1LL, v34);
			//                 v35 = (String *)sub_18003C530(&off_18D5EBF50);
			//                 ResourceString = System::Environment::GetResourceString(v35, v31, 0LL);
			//                 v37 = sub_18003C530(&TypeInfo::System::ArgumentException);
			//                 v38 = (SystemException *)sub_180004920(v37);
			//                 v39 = v38;
			//                 if ( v38 )
			//                 {
			//                   System::SystemException::SystemException(v38, ResourceString, 0LL);
			//                   v39.fields._._HResult = -2147024809;
			//                   v40 = sub_18003C530(&MethodInfo::System::Enum::CompareTo);
			//                   sub_18000F7C0(v39, v40);
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//       else
			//       {
			//         v19 = (String *)sub_18003C530(&off_18D5EBF40);
			//         v20 = sub_18003C530(&TypeInfo::System::InvalidOperationException);
			//         v21 = (SystemException *)sub_180004920(v20);
			//         v24 = v21;
			//         if ( v21 )
			//         {
			//           System::SystemException::SystemException(v21, v19, 0LL);
			//           v24.fields._._HResult = -2146233079;
			//           v25 = sub_18003C530(&MethodInfo::System::Enum::CompareTo);
			//           sub_18000F7C0(v24, v25);
			//         }
			//       }
			//       sub_180B536AC(v23, v22);
			//     }
			//   }
			//   else
			//   {
			//     priority = this.fields._priority;
			//     LODWORD(v67) = other.fields._priority;
			//     v10 = (Object *)il2cpp_value_box(TypeInfo::HG::Rendering::Runtime::EnvPriority, &v67, v7);
			//     v12 = TypeInfo::HG::Rendering::Runtime::EnvPriority;
			//     v64 = TypeInfo::HG::Rendering::Runtime::EnvPriority;
			//     v65 = -1LL;
			//     v66 = priority;
			//     if ( !byte_18D8F238E )
			//     {
			//       sub_18003C530(&TypeInfo::System::Enum);
			//       byte_18D8F238E = 1;
			//     }
			//     if ( !TypeInfo::System::Enum._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::System::Enum, v9);
			//     result = System::Enum::InternalCompareTo((System::Enum *)&v64, v10, v11);
			//     if ( result >= 2 )
			//     {
			//       if ( result == 2 )
			//       {
			//         v48 = il2cpp_type_get_object_0(&v12._0.byval_arg);
			//         if ( v10 )
			//         {
			//           v49 = il2cpp_type_get_object_0(&v10.klass._0.byval_arg);
			//           v50 = sub_18003C530(&TypeInfo::System::Object);
			//           v53 = (Object__Array *)il2cpp_array_new_specific_0(v50, 2LL, v51, v52);
			//           if ( v49 )
			//           {
			//             v54 = sub_18003F3E0(3LL, v49);
			//             v55 = v54;
			//             if ( v53 )
			//             {
			//               sub_180036D40(v53, v54);
			//               sub_1800046C0(v53, 0LL, v55);
			//               if ( v48 )
			//               {
			//                 v56 = sub_18003F3E0(3LL, v48);
			//                 sub_180036D40(v53, v56);
			//                 sub_1800046C0(v53, 1LL, v56);
			//                 v57 = (String *)sub_18003C530(&off_18D5EBF50);
			//                 v58 = System::Environment::GetResourceString(v57, v53, 0LL);
			//                 v59 = sub_18003C530(&TypeInfo::System::ArgumentException);
			//                 v60 = (SystemException *)sub_180004920(v59);
			//                 v61 = v60;
			//                 if ( v60 )
			//                 {
			//                   System::SystemException::SystemException(v60, v58, 0LL);
			//                   v61.fields._._HResult = -2147024809;
			//                   v62 = sub_18003C530(&MethodInfo::System::Enum::CompareTo);
			//                   sub_18000F7C0(v61, v62);
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//       else
			//       {
			//         v41 = (String *)sub_18003C530(&off_18D5EBF40);
			//         v42 = sub_18003C530(&TypeInfo::System::InvalidOperationException);
			//         v43 = (SystemException *)sub_180004920(v42);
			//         v46 = v43;
			//         if ( v43 )
			//         {
			//           System::SystemException::SystemException(v43, v41, 0LL);
			//           v46.fields._._HResult = -2146233079;
			//           v47 = sub_18003C530(&MethodInfo::System::Enum::CompareTo);
			//           sub_18000F7C0(v46, v47);
			//         }
			//       }
			//       sub_180B536AC(v45, v44);
			//     }
			//   }
			//   return result;
			// }
			// 
			return 0;
		}

		public float GetDistanceBlendFactor(Vector3 triggerPos)
		{
			// // Single GetDistanceBlendFactor(Vector3)
			// float HG::Rendering::Runtime::HGEnvironmentVolume::GetDistanceBlendFactor(
			//         HGEnvironmentVolume *this,
			//         Vector3 *triggerPos,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   float z; // eax
			//   float result; // xmm0_4
			//   Beyond::JobMathf *v9; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v12[2]; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, triggerPos);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 600 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//     if ( v5 )
			//     {
			//       if ( LODWORD(v5._0.namespaze) <= 0x258 )
			//         sub_180070270(v5, wrapperArray);
			//       if ( !v5[12].vtable.Equals.method )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(600, 0LL);
			//       if ( Patch )
			//       {
			//         v11 = *(_QWORD *)&triggerPos.x;
			//         v12[0].z = triggerPos.z;
			//         *(_QWORD *)&v12[0].x = v11;
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_230(Patch, (Object *)this, v12, 0LL);
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v5, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( !this.fields._volumeType )
			//     return 1.0;
			//   z = triggerPos.z;
			//   *(_QWORD *)&v12[0].x = *(_QWORD *)&triggerPos.x;
			//   v12[0].z = z;
			//   result = HG::Rendering::Runtime::HGEnvironmentVolume::_DistanceToEdge(this, v12, 0LL)
			//          / (float)(this.fields._blendDistance + COERCE_FLOAT(1));
			//   Beyond::JobMathf::Clamp01(v9);
			//   return result;
			// }
			// 
			return 0f;
		}

		private void Start()
		{
			// // Void Start()
			// void HG::Rendering::Runtime::HGEnvironmentVolume::Start(HGEnvironmentVolume *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1236, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1236, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGEnvironmentVolume::_UpdateEnvPhaseParentId(this, 0LL);
			//   }
			// }
			// 
		}

		protected override void OnPlay()
		{
			// // Void OnPlay()
			// void HG::Rendering::Runtime::HGEnvironmentVolume::OnPlay(HGEnvironmentVolume *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rdx
			//   Dictionary_2_HG_Rendering_Runtime_HGCamera_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *dataPerCameras; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC50 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::Clear);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D8EDC50 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1238, 0LL) )
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v3);
			//     HG::Rendering::Runtime::HGEnvironmentManager::Register(this, 0LL);
			//     dataPerCameras = this.fields.dataPerCameras;
			//     if ( dataPerCameras )
			//     {
			//       System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::Clear(
			//         (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *)dataPerCameras,
			//         MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::Clear);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(dataPerCameras, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1238, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		protected override void OnStop()
		{
			// // Void OnStop()
			// void HG::Rendering::Runtime::HGEnvironmentVolume::OnStop(HGEnvironmentVolume *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D8EDC51 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D8EDC51 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1241, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1241, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v3);
			//     HG::Rendering::Runtime::HGEnvironmentManager::Unregister(this, 0LL);
			//   }
			// }
			// 
		}

		private void _OnEnvPhaseChanged()
		{
			// // Void _OnEnvPhaseChanged()
			// void HG::Rendering::Runtime::HGEnvironmentVolume::_OnEnvPhaseChanged(HGEnvironmentVolume *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1244, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1244, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGEnvironmentVolume::_UpdateEnvPhaseParentId(this, 0LL);
			//   }
			// }
			// 
		}

		private void _UpdateEnvPhaseParentId()
		{
			// // Void _UpdateEnvPhaseParentId()
			// void HG::Rendering::Runtime::HGEnvironmentVolume::_UpdateEnvPhaseParentId(
			//         HGEnvironmentVolume *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1237, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1237, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			// }
			// 
		}

		private void _UpdateVolumeType(EnvVolumeType value)
		{
			// // Void _UpdateVolumeType(EnvVolumeType)
			// void HG::Rendering::Runtime::HGEnvironmentVolume::_UpdateVolumeType(
			//         HGEnvironmentVolume *this,
			//         EnvVolumeType__Enum value,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !byte_18D8EDC52 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D8EDC52 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1245, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1245, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)this, value, 0LL);
			//   }
			//   else if ( this.fields._volumeType != value )
			//   {
			//     if ( UnityEngine::EventSystems::UIBehaviour::IsActive((UIBehaviour *)this, 0LL) )
			//     {
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v5);
			//       HG::Rendering::Runtime::HGEnvironmentManager::set_sortNeeded(1, 0LL);
			//     }
			//     this.fields._volumeType = value;
			//   }
			// }
			// 
		}

		private void _UpdatePriority(EnvPriority value)
		{
			// // Void _UpdatePriority(EnvPriority)
			// void HG::Rendering::Runtime::HGEnvironmentVolume::_UpdatePriority(
			//         HGEnvironmentVolume *this,
			//         EnvPriority__Enum value,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !byte_18D8EDC53 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D8EDC53 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1246, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1246, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)this, value, 0LL);
			//   }
			//   else if ( this.fields._priority != value )
			//   {
			//     if ( UnityEngine::EventSystems::UIBehaviour::IsActive((UIBehaviour *)this, 0LL) )
			//     {
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v5);
			//       HG::Rendering::Runtime::HGEnvironmentManager::set_sortNeeded(1, 0LL);
			//     }
			//     this.fields._priority = value;
			//   }
			// }
			// 
		}

		private float _DistanceToEdge(Vector3 triggerPos)
		{
			// // Single _DistanceToEdge(Vector3)
			// float HG::Rendering::Runtime::HGEnvironmentVolume::_DistanceToEdge(
			//         HGEnvironmentVolume *this,
			//         Vector3 *triggerPos,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   int32_t volumeType; // ecx
			//   BeyondPolyLineShape *polyLineShape; // rcx
			//   float v9; // eax
			//   bool v10; // zf
			//   int v12; // ecx
			//   __int64 (__fastcall *v13)(HGEnvironmentVolume *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *); // rax
			//   __int64 v14; // rsi
			//   void (__fastcall *v15)(__int64, Quaternion *); // rax
			//   void (__fastcall *v16)(Quaternion *, Quaternion *); // rax
			//   __int64 (__fastcall *v17)(HGEnvironmentVolume *); // rax
			//   __int64 v18; // rsi
			//   void (__fastcall *v19)(__int64, Vector3 *); // rax
			//   __int64 v20; // xmm0_8
			//   float v21; // eax
			//   MethodInfo *v22; // r9
			//   Vector3 *v23; // rax
			//   __int64 v24; // xmm3_8
			//   Vector3 *v25; // rax
			//   __int64 v26; // rdx
			//   __int64 v27; // xmm7_8
			//   unsigned int z_low; // edi
			//   __m128 si128; // xmm6
			//   unsigned __int64 v30; // xmm7_8
			//   float v31; // edi
			//   __int64 (__fastcall *v32)(HGEnvironmentVolume *); // rax
			//   __int64 v33; // rbx
			//   void (__fastcall *v34)(__int64, Vector3 *); // rax
			//   struct ILFixDynamicMethodWrapper_2__Class *v35; // r9
			//   int v36; // ecx
			//   unsigned __int64 v37; // xmm0_8
			//   Vector3 *v38; // rax
			//   __int64 v39; // xmm3_8
			//   MethodInfo *v40; // r9
			//   Vector3 *v41; // rax
			//   struct ILFixDynamicMethodWrapper_2__Class *v42; // r9
			//   float v43; // xmm8_4
			//   float v44; // xmm8_4
			//   __m128 v45; // xmm6
			//   __m128 v46; // xmm7
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v49; // xmm0_8
			//   int v50; // ecx
			//   Transform *transform; // rax
			//   Vector3 *lossyScale; // rax
			//   __int64 v53; // rdx
			//   __int64 v54; // xmm6_8
			//   float z; // esi
			//   Vector3 *v56; // rax
			//   float v57; // esi
			//   Transform *v58; // rax
			//   Quaternion v59; // xmm6
			//   Transform *v60; // rax
			//   Vector3 *position; // rax
			//   __int64 v62; // xmm0_8
			//   __int64 v63; // xmm0_8
			//   MethodInfo *v64; // r9
			//   Vector3 *v65; // rax
			//   __int64 v66; // xmm3_8
			//   Vector3 *v67; // rax
			//   __int64 v68; // xmm0_8
			//   Vector3 *v69; // rax
			//   __m128 v70; // xmm8
			//   float v71; // xmm7_4
			//   double v72; // xmm0_8
			//   Transform *v73; // rax
			//   Vector3 *v74; // rax
			//   __int64 v75; // rdx
			//   __int64 v76; // xmm6_8
			//   float v77; // esi
			//   Vector3 *v78; // rax
			//   __int64 v79; // xmm0_8
			//   float v80; // xmm6_4
			//   Transform *v81; // rax
			//   __int64 v82; // xmm1_8
			//   Vector3 *v83; // rax
			//   __int64 v84; // xmm0_8
			//   __int64 v85; // rax
			//   __int64 v86; // rax
			//   __int64 v87; // rax
			//   ILFixDynamicMethodWrapper_2 *v88; // rax
			//   Vector3 *v89; // rax
			//   __int64 v90; // rax
			//   ILFixDynamicMethodWrapper_2 *v91; // rax
			//   Vector3 *v92; // rax
			//   ILFixDynamicMethodWrapper_2 *v93; // rax
			//   Vector3 v94; // [rsp+20h] [rbp-29h] BYREF
			//   Vector3 v95; // [rsp+30h] [rbp-19h] BYREF
			//   Quaternion v96; // [rsp+40h] [rbp-9h] BYREF
			//   Quaternion v97; // [rsp+50h] [rbp+7h] BYREF
			//   Quaternion v98; // [rsp+60h] [rbp+17h] BYREF
			//   Vector2 v99; // [rsp+C8h] [rbp+7Fh] BYREF
			// 
			//   if ( !byte_18D8EDC54 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D8EDC54 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, triggerPos);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_54;
			//   if ( wrapperArray.max_length.size > 595 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v5.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_54;
			//     if ( wrapperArray.max_length.size <= 0x253u )
			//       goto LABEL_108;
			//     if ( wrapperArray[16].vector[19] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(595, 0LL);
			//       if ( Patch )
			//       {
			//         v49 = *(_QWORD *)&triggerPos.x;
			//         v94.z = triggerPos.z;
			//         *(_QWORD *)&v94.x = v49;
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_230(Patch, (Object *)this, &v94, 0LL);
			//       }
			//       goto LABEL_54;
			//     }
			//   }
			//   volumeType = this.fields._volumeType;
			//   if ( volumeType != 3 )
			//   {
			//     if ( !volumeType )
			//       return 3.4028235e38;
			//     v12 = volumeType - 1;
			//     if ( v12 )
			//     {
			//       v50 = v12 - 1;
			//       if ( v50 )
			//       {
			//         if ( v50 != 2 )
			//           return 0.0;
			//         transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//         if ( transform )
			//         {
			//           lossyScale = UnityEngine::Transform::get_lossyScale((Vector3 *)&v96, transform, 0LL);
			//           v54 = *(_QWORD *)&lossyScale.x;
			//           z = lossyScale.z;
			//           if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, v53);
			//           *(_QWORD *)&v94.x = v54;
			//           v94.z = z;
			//           v56 = HG::Rendering::Runtime::HGUtils::Abs(&v95, &v94, 0LL);
			//           v57 = v56.z;
			//           *(_QWORD *)&v96.x = *(_QWORD *)&v56.x;
			//           v58 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//           if ( v58 )
			//           {
			//             v98 = *UnityEngine::Transform::get_rotation(&v98, v58, 0LL);
			//             v59 = *UnityEngine::Quaternion::Inverse(&v97, &v98, 0LL);
			//             v60 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//             if ( v60 )
			//             {
			//               position = UnityEngine::Transform::get_position(&v95, v60, 0LL);
			//               v62 = *(_QWORD *)&position.x;
			//               *(float *)&position = position.z;
			//               *(_QWORD *)&v94.x = v62;
			//               v63 = *(_QWORD *)&triggerPos.x;
			//               LODWORD(v94.z) = (_DWORD)position;
			//               *(float *)&position = triggerPos.z;
			//               *(_QWORD *)&v95.x = v63;
			//               LODWORD(v95.z) = (_DWORD)position;
			//               v65 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v97, &v95, &v94, v64);
			//               v98 = v59;
			//               v66 = *(_QWORD *)&v65.x;
			//               *(float *)&v65 = v65.z;
			//               *(_QWORD *)&v95.x = v66;
			//               LODWORD(v95.z) = (_DWORD)v65;
			//               v67 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v97, &v98, &v95, 0LL);
			//               v68 = *(_QWORD *)&v67.x;
			//               *(float *)&v67 = v67.z;
			//               *(_QWORD *)&v95.x = v68;
			//               LODWORD(v95.z) = (_DWORD)v67;
			//               v69 = HG::Rendering::Runtime::HGUtils::Abs((Vector3 *)&v97, &v95, 0LL);
			//               v70 = (__m128)*(unsigned __int64 *)&v69.x;
			//               v95.z = v69.z;
			//               *(_QWORD *)&v95.x = v70.m128_u64[0];
			//               v99 = HG::Rendering::Runtime::VectorSwizzleUtils::xz(&v95, 0LL);
			//               v71 = fminf(v96.x, v57) * 0.5;
			//               v72 = sub_182413570(&v99);
			//               return fminf(
			//                        fmaxf(v71 - *(float *)&v72, 0.0),
			//                        fmaxf((float)(v96.y * 0.5) - _mm_shuffle_ps(v70, v70, 85).m128_f32[0], 0.0));
			//             }
			//           }
			//         }
			//       }
			//       else
			//       {
			//         v73 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//         if ( v73 )
			//         {
			//           v74 = UnityEngine::Transform::get_lossyScale((Vector3 *)&v97, v73, 0LL);
			//           v76 = *(_QWORD *)&v74.x;
			//           v77 = v74.z;
			//           if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, v75);
			//           *(_QWORD *)&v96.x = v76;
			//           v96.z = v77;
			//           v78 = HG::Rendering::Runtime::HGUtils::Abs((Vector3 *)&v97, (Vector3 *)&v96, 0LL);
			//           v79 = *(_QWORD *)&v78.x;
			//           *(float *)&v78 = v78.z;
			//           *(_QWORD *)&v96.x = v79;
			//           LODWORD(v96.z) = (_DWORD)v78;
			//           v80 = HG::Rendering::Runtime::HGEnvironmentUtils::MinComponent((Vector3 *)&v96, 0LL);
			//           v81 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//           if ( v81 )
			//           {
			//             v82 = *(_QWORD *)&triggerPos.x;
			//             v96.z = triggerPos.z;
			//             *(_QWORD *)&v96.x = v82;
			//             v83 = UnityEngine::Transform::get_position((Vector3 *)&v97, v81, 0LL);
			//             v84 = *(_QWORD *)&v83.x;
			//             *(float *)&v83 = v83.z;
			//             *(_QWORD *)&v95.x = v84;
			//             LODWORD(v95.z) = (_DWORD)v83;
			//             return fmaxf((float)(v80 * 0.5) - sub_1824AD380(&v95, &v96), 0.0);
			//           }
			//         }
			//       }
			//       goto LABEL_54;
			//     }
			//     v13 = (__int64 (__fastcall *)(HGEnvironmentVolume *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))qword_18D8F4D40;
			//     if ( !qword_18D8F4D40 )
			//     {
			//       v13 = (__int64 (__fastcall *)(HGEnvironmentVolume *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))sub_180017470("UnityEngine.Component::get_transform()");
			//       qword_18D8F4D40 = (__int64)v13;
			//     }
			//     v14 = v13(this, wrapperArray, method);
			//     if ( !v14 )
			//       goto LABEL_54;
			//     v15 = (void (__fastcall *)(__int64, Quaternion *))qword_18D8F5300;
			//     v97 = 0LL;
			//     if ( !qword_18D8F5300 )
			//     {
			//       v15 = (void (__fastcall *)(__int64, Quaternion *))il2cpp_resolve_icall_0(
			//                                                           "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
			//       if ( !v15 )
			//       {
			//         v85 = sub_1802DBBE8("UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
			//         sub_18000F750(v85, 0LL);
			//       }
			//       qword_18D8F5300 = (__int64)v15;
			//     }
			//     v15(v14, &v97);
			//     v16 = (void (__fastcall *)(Quaternion *, Quaternion *))qword_18D8F4C20;
			//     v96 = v97;
			//     v98 = 0LL;
			//     if ( !qword_18D8F4C20 )
			//     {
			//       v16 = (void (__fastcall *)(Quaternion *, Quaternion *))il2cpp_resolve_icall_0(
			//                                                                "UnityEngine.Quaternion::Inverse_Injected(UnityEngine.Quat"
			//                                                                "ernion&,UnityEngine.Quaternion&)");
			//       if ( !v16 )
			//       {
			//         v86 = sub_1802DBBE8("UnityEngine.Quaternion::Inverse_Injected(UnityEngine.Quaternion&,UnityEngine.Quaternion&)");
			//         sub_18000F750(v86, 0LL);
			//       }
			//       qword_18D8F4C20 = (__int64)v16;
			//     }
			//     v16(&v96, &v98);
			//     v17 = (__int64 (__fastcall *)(HGEnvironmentVolume *))qword_18D8F4D40;
			//     if ( !qword_18D8F4D40 )
			//     {
			//       v17 = (__int64 (__fastcall *)(HGEnvironmentVolume *))sub_180017470("UnityEngine.Component::get_transform()");
			//       qword_18D8F4D40 = (__int64)v17;
			//     }
			//     v18 = v17(this);
			//     if ( !v18 )
			//       goto LABEL_54;
			//     *(_QWORD *)&v94.x = 0LL;
			//     v94.z = 0.0;
			//     v19 = (void (__fastcall *)(__int64, Vector3 *))qword_18D8F52E0;
			//     if ( !qword_18D8F52E0 )
			//     {
			//       v19 = (void (__fastcall *)(__int64, Vector3 *))il2cpp_resolve_icall_0(
			//                                                        "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//       if ( !v19 )
			//       {
			//         v87 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//         sub_18000F750(v87, 0LL);
			//       }
			//       qword_18D8F52E0 = (__int64)v19;
			//     }
			//     v19(v18, &v94);
			//     *(_QWORD *)&v96.x = *(_QWORD *)&v94.x;
			//     v20 = *(_QWORD *)&triggerPos.x;
			//     v96.z = v94.z;
			//     v21 = triggerPos.z;
			//     *(_QWORD *)&v95.x = v20;
			//     v95.z = v21;
			//     v23 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v97, &v95, (Vector3 *)&v96, v22);
			//     v24 = *(_QWORD *)&v23.x;
			//     *(float *)&v23 = v23.z;
			//     *(_QWORD *)&v96.x = v24;
			//     LODWORD(v96.z) = (_DWORD)v23;
			//     v25 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v97, &v98, (Vector3 *)&v96, 0LL);
			//     v27 = *(_QWORD *)&v25.x;
			//     v10 = TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor == 0;
			//     z_low = LODWORD(v25.z);
			//     *(_QWORD *)&v96.x = *(_QWORD *)&v25.x;
			//     if ( v10 )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, v26);
			//     if ( !byte_18D8EDC37 )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       byte_18D8EDC37 = 1;
			//     }
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v26);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v5.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_54;
			//     si128 = (__m128)_mm_load_si128((const __m128i *)&xmmword_18A357260);
			//     if ( wrapperArray.max_length.size <= 596 )
			//       goto LABEL_33;
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//     if ( !v5 )
			//       goto LABEL_54;
			//     if ( LODWORD(v5._0.namespaze) <= 0x254 )
			//       goto LABEL_108;
			//     if ( *(_QWORD *)&v5[12]._1.field_count )
			//     {
			//       v88 = IFix::WrappersManagerImpl::GetPatch(596, 0LL);
			//       if ( !v88 )
			//         goto LABEL_54;
			//       *(_QWORD *)&v96.x = v27;
			//       LODWORD(v96.z) = z_low;
			//       v89 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(&v95, v88, (Vector3 *)&v96, 0LL);
			//       v30 = *(_QWORD *)&v89.x;
			//       v31 = v89.z;
			//     }
			//     else
			//     {
			// LABEL_33:
			//       v30 = _mm_unpacklo_ps(_mm_and_ps((__m128)LODWORD(v96.x), si128), _mm_and_ps((__m128)LODWORD(v96.y), si128)).m128_u64[0];
			//       v31 = COERCE_FLOAT(_mm_cvtsi128_si32((__m128i)_mm_and_ps((__m128)_mm_cvtsi32_si128(z_low), si128)));
			//     }
			//     v32 = (__int64 (__fastcall *)(HGEnvironmentVolume *))qword_18D8F4D40;
			//     if ( !qword_18D8F4D40 )
			//     {
			//       v32 = (__int64 (__fastcall *)(HGEnvironmentVolume *))sub_180017470("UnityEngine.Component::get_transform()");
			//       qword_18D8F4D40 = (__int64)v32;
			//     }
			//     v33 = v32(this);
			//     if ( !v33 )
			//       goto LABEL_54;
			//     *(_QWORD *)&v94.x = 0LL;
			//     v94.z = 0.0;
			//     v34 = (void (__fastcall *)(__int64, Vector3 *))qword_18D8F5380;
			//     if ( !qword_18D8F5380 )
			//     {
			//       v34 = (void (__fastcall *)(__int64, Vector3 *))il2cpp_resolve_icall_0(
			//                                                        "UnityEngine.Transform::get_lossyScale_Injected(UnityEngine.Vector3&)");
			//       if ( !v34 )
			//       {
			//         v90 = sub_1802DBBE8("UnityEngine.Transform::get_lossyScale_Injected(UnityEngine.Vector3&)");
			//         sub_18000F750(v90, 0LL);
			//       }
			//       qword_18D8F5380 = (__int64)v34;
			//     }
			//     v34(v33, &v94);
			//     if ( !byte_18D8EDC37 )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       byte_18D8EDC37 = 1;
			//     }
			//     v35 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//       v35 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v35.static_fields.wrapperArray;
			//     if ( !v5 )
			//       goto LABEL_54;
			//     if ( SLODWORD(v5._0.namespaze) <= 596 )
			//       goto LABEL_44;
			//     if ( !v35._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v35, wrapperArray);
			//       v35 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v35.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_54;
			//     if ( wrapperArray.max_length.size <= 0x254u )
			//       goto LABEL_108;
			//     if ( wrapperArray[16].vector[20] )
			//     {
			//       v91 = IFix::WrappersManagerImpl::GetPatch(596, 0LL);
			//       if ( !v91 )
			//         goto LABEL_54;
			//       *(Vector3 *)&v96.x = v94;
			//       v92 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227((Vector3 *)&v97, v91, (Vector3 *)&v96, 0LL);
			//       v35 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       v37 = *(_QWORD *)&v92.x;
			//       v36 = LODWORD(v92.z);
			//     }
			//     else
			//     {
			// LABEL_44:
			//       v36 = _mm_cvtsi128_si32((__m128i)_mm_and_ps((__m128)LODWORD(v94.z), si128));
			//       v37 = _mm_unpacklo_ps(_mm_and_ps((__m128)LODWORD(v94.x), si128), _mm_and_ps((__m128)LODWORD(v94.y), si128)).m128_u64[0];
			//     }
			//     LODWORD(v96.z) = v36;
			//     *(_QWORD *)&v96.x = v37;
			//     *(_QWORD *)&v95.x = v30;
			//     v95.z = v31;
			//     v38 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v97, (Vector3 *)&v96, 0.5, (MethodInfo *)v35);
			//     v39 = *(_QWORD *)&v38.x;
			//     *(float *)&v38 = v38.z;
			//     *(_QWORD *)&v96.x = v39;
			//     LODWORD(v96.z) = (_DWORD)v38;
			//     v41 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v97, (Vector3 *)&v96, &v95, v40);
			//     v43 = v41.z;
			//     *(_QWORD *)&v96.x = *(_QWORD *)&v41.x;
			//     v45 = _mm_shuffle_ps((__m128)*(unsigned __int64 *)&v96.x, (__m128)*(unsigned __int64 *)&v96.x, 85);
			//     v44 = fmaxf(v43, 0.0);
			//     v46 = (__m128)*(unsigned __int64 *)&v96.x;
			//     v45.m128_f32[0] = fmaxf(v45.m128_f32[0], 0.0);
			//     v46.m128_f32[0] = fmaxf(v96.x, 0.0);
			//     if ( !byte_18D8EDC37 )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       v42 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       byte_18D8EDC37 = 1;
			//     }
			//     if ( !v42._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v42, wrapperArray);
			//       v42 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v42.static_fields.wrapperArray;
			//     if ( !v5 )
			//       goto LABEL_54;
			//     if ( SLODWORD(v5._0.namespaze) <= 597 )
			//       return fminf(v46.m128_f32[0], fminf(v45.m128_f32[0], v44));
			//     if ( !v42._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v42, wrapperArray);
			//       v42 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v42.static_fields.wrapperArray;
			//     if ( !v5 )
			// LABEL_54:
			//       sub_180B536AC(v5, wrapperArray);
			//     if ( LODWORD(v5._0.namespaze) > 0x255 )
			//     {
			//       if ( !*(_QWORD *)&v5[12]._1.interfaces_count )
			//         return fminf(v46.m128_f32[0], fminf(v45.m128_f32[0], v44));
			//       v93 = IFix::WrappersManagerImpl::GetPatch(597, 0LL);
			//       if ( v93 )
			//       {
			//         v96.z = v44;
			//         *(_QWORD *)&v96.x = _mm_unpacklo_ps(v46, v45).m128_u64[0];
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_228(v93, (Vector3 *)&v96, 0LL);
			//       }
			//       goto LABEL_54;
			//     }
			// LABEL_108:
			//     sub_180070270(v5, wrapperArray);
			//   }
			//   if ( !this.fields._polyLineShape )
			//     return 0.0;
			//   polyLineShape = this.fields._polyLineShape;
			//   v9 = triggerPos.z;
			//   v10 = this.fields._blendMode == 1;
			//   *(_QWORD *)&v96.x = *(_QWORD *)&triggerPos.x;
			//   v96.z = v9;
			//   if ( v10 )
			//     return Beyond::BeyondPolyLineShape::GetDistanceToEdgeInArea(
			//              polyLineShape,
			//              (Vector3 *)&v96,
			//              this.fields._blendDistance,
			//              0LL);
			//   else
			//     return Beyond::BeyondPolyLineShape::GetDistanceToEdgeInArea(polyLineShape, (Vector3 *)&v96, 0.1, 0LL);
			// }
			// 
			return 0f;
		}

		public void <>iFixBaseProxy_OnPlay()
		{
			// // Void <>iFixBaseProxy_OnPlay()
			// void HG::Rendering::Runtime::VFXSceneDark::__iFixBaseProxy_OnPlay(VFXSceneDark *this, MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VFXPlayableMonoBase::OnPlay((VFXPlayableMonoBase *)this, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_OnStop()
		{
			// // Void <>iFixBaseProxy_OnStop()
			// void HG::Rendering::Runtime::VFXSceneDark::__iFixBaseProxy_OnStop(VFXSceneDark *this, MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VFXPlayableMonoBase::OnStop((VFXPlayableMonoBase *)this, 0LL);
			// }
			// 
		}

		[Header("Volume 类型")]
		[SerializeField]
		[FormerlySerializedAs("volumeType")]
		private EnvVolumeType _volumeType;

		private bool _drawGizmos;

		[FormerlySerializedAs("blendMode")]
		[SerializeField]
		[Header("过渡方式")]
		private EnvBlendMode _blendMode;

		[FormerlySerializedAs("priority")]
		[SerializeField]
		[Header("优先级")]
		private EnvPriority _priority;

		[SerializeField]
		[FormerlySerializedAs("blendDistance")]
		[UnclampedRangeExponential(1f, 200f, 2f)]
		[Header("过渡距离")]
		private float _blendDistance;

		[SerializeField]
		[FormerlySerializedAs("fadeInDuration")]
		[UnclampedRange(0f, 20f)]
		[Header("淡入时间 (s)")]
		private float _fadeInDuration;

		[UnclampedRange(0f, 20f)]
		[Header("淡出时间 (s)")]
		[SerializeField]
		[FormerlySerializedAs("fadeOutDuration")]
		private float _fadeOutDuration;

		[Range(0f, 1f)]
		[Header("自定义过渡值")]
		[SerializeField]
		private float _manualBlendFactor;

		[Header("环境配置")]
		[SerializeField]
		[FormerlySerializedAs("envPhase")]
		private HGEnvironmentPhase _envPhase;

		[FormerlySerializedAs("polyLineShape")]
		[SerializeField]
		private BeyondPolyLineShape _polyLineShape;

		[NonSerialized]
		public readonly Dictionary<HGCamera, HGEnvironmentVolume.InterpolateDataPerCamera> dataPerCameras;

		public const string ENV_RP_PREF = "T_EnvRP_";

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 4)]
		public struct InterpolateDataPerCamera
		{
			public float timeFadingFactor;
		}
	}
}
