using System;
using System.Collections.Generic;
using Beyond;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class HGEnvironmentVolumeCameraComponent
	{
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x000025D2 File Offset: 0x000007D2
		public HGEnvironmentPhase interpolatedPhase
		{
			get
			{
				// // Object get_Current()
				// Object *Rewired::Utils::Classes::Data::RingBuffer_1_T_::VFEweixJrFjiYwjUzBFjtcEMiCZW<System::Object>::get_Current(
				//         RingBuffer_1_T_VFEweixJrFjiYwjUzBFjtcEMiCZW_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.current;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600061C RID: 1564 RVA: 0x000025D2 File Offset: 0x000007D2
		public ref Vector3 lastInterpolateTriggerPosition
		{
			get
			{
				// // Void* get_state()
				// Void *UnityEngine::InputSystem::LowLevel::StateEvent::get_state(StateEvent *this, MethodInfo *method)
				// {
				//   return (Void *)&this.stateFormat;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600061D RID: 1565 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool useEnvVolumeInterpolatedPhase
		{
			get
			{
				// // Boolean get_maintainPositionOffsets()
				// bool UnityEngine::Animations::Rigging::BlendConstraintData::get_maintainPositionOffsets(
				//         BlendConstraintData *this,
				//         MethodInfo *method)
				// {
				//   return this.m_MaintainPositionOffsets;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x0600061E RID: 1566 RVA: 0x000025D2 File Offset: 0x000007D2
		public IndexedHashSet<HGEnvironmentVolume> interpolatedVolumes
		{
			get
			{
				// // IndexedHashSet`1[HG.Rendering.Runtime.HGEnvironmentVolume] get_interpolatedVolumes()
				// IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolume_ *HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedVolumes(
				//         HGEnvironmentVolumeCameraComponent *this,
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
				//   if ( wrapperArray.max_length.size <= 723 )
				//     return this.fields.m_interpolatedVolumes;
				//   if ( !v3._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(v3, wrapperArray);
				//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   static_fields = v3.static_fields;
				//   v7 = static_fields.wrapperArray;
				//   if ( !static_fields.wrapperArray )
				//     goto LABEL_8;
				//   if ( v7.max_length.size <= 0x2D3u )
				//     sub_180070270(static_fields, wrapperArray);
				//   if ( !v7[20].vector[3] )
				//     return this.fields.m_interpolatedVolumes;
				//   Patch = IFix::WrappersManagerImpl::GetPatch(723, 0LL);
				//   if ( !Patch )
				// LABEL_8:
				//     sub_180B536AC(static_fields, wrapperArray);
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_276(Patch, (Object *)this, 0LL);
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600061F RID: 1567 RVA: 0x000025D2 File Offset: 0x000007D2
		public List<float> interpolatedVolumesFactor
		{
			get
			{
				// // List`1[System.Single] get_interpolatedVolumesFactor()
				// List_1_System_Single_ *HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedVolumesFactor(
				//         HGEnvironmentVolumeCameraComponent *this,
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
				//   if ( wrapperArray.max_length.size <= 724 )
				//     return this.fields.m_interpolatedVolumesFactor;
				//   if ( !v3._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(v3, wrapperArray);
				//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   static_fields = v3.static_fields;
				//   v7 = static_fields.wrapperArray;
				//   if ( !static_fields.wrapperArray )
				//     goto LABEL_8;
				//   if ( v7.max_length.size <= 0x2D4u )
				//     sub_180070270(static_fields, wrapperArray);
				//   if ( !v7[20].vector[4] )
				//     return this.fields.m_interpolatedVolumesFactor;
				//   Patch = IFix::WrappersManagerImpl::GetPatch(724, 0LL);
				//   if ( !Patch )
				// LABEL_8:
				//     sub_180B536AC(static_fields, wrapperArray);
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_277(Patch, (Object *)this, 0LL);
				// }
				// 
				return null;
			}
		}

		public HGEnvironmentVolumeCameraComponent()
		{
		}

		public bool UseDirLightDataFromEnvDirectly(Light dirLight)
		{
			// // Boolean UseDirLightDataFromEnvDirectly(Light)
			// bool HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::UseDirLightDataFromEnvDirectly(
			//         HGEnvironmentVolumeCameraComponent *this,
			//         Light *dirLight,
			//         MethodInfo *method)
			// {
			//   Object_1 *SunSourceLight; // rbx
			//   bool result; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( !byte_18D919D72 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919D72 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1247, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1247, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//              (ILFixDynamicMethodWrapper_36 *)Patch,
			//              (Object *)this,
			//              (Object *)dirLight,
			//              0LL);
			//   }
			//   else
			//   {
			//     SunSourceLight = (Object_1 *)UnityEngine::Light::GetSunSourceLight(0LL);
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     result = UnityEngine::Object::op_Equality(SunSourceLight, (Object_1 *)dirLight, 0LL);
			//     if ( result )
			//       return this.fields.m_useEnvVolumeInterpolatedPhase;
			//   }
			//   return result;
			// }
			// 
			return default(bool);
		}

		private HGEnvironmentPhase m_interpolatedPhase;

		private Vector3 m_lastInterpolateTriggerPosition;

		private bool m_useEnvVolumeInterpolatedPhase;

		private readonly IndexedHashSet<HGEnvironmentVolume> m_interpolatedVolumes;

		private readonly List<float> m_interpolatedVolumesFactor;
	}
}
