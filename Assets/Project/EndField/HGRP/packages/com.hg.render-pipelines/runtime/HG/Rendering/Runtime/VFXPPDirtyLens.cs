using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXPPDirtyLens(镜头脏迹)")]
	[ExecuteInEditMode]
	public class VFXPPDirtyLens : VFXPPComponent
	{
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x00002998 File Offset: 0x00000B98
		protected override VFXPPType m_VFXPPType
		{
			get
			{
				// // Int32 System.Runtime.CompilerServices.ITuple.get_Length()
				// int32_t System::ValueTuple<System::Object,UnityEngine::Vector3Int,int,System::Object,UnityEngine::Vector3Int,System::Object>::System_Runtime_CompilerServices_ITuple_get_Length(
				//         ValueTuple_6_Object_UnityEngine_Vector3Int_Int32_Object_UnityEngine_Vector3Int_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return 6;
				// }
				// 
				return (VFXPPType)VFXPPType.ChromaticAberration;
			}
		}

		public VFXPPDirtyLens()
		{
			// // VFXPPVignette()
			// void HG::Rendering::Runtime::VFXPPVignette::VFXPPVignette(VFXPPVignette *this, MethodInfo *method)
			// {
			//   this.fields._.m_targetEnable = 1;
			//   this.fields._._.m_isPlaying = 1;
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		public override void Apply(VolumeProfile volumeProfile)
		{
		}

		public override void ResetByVolumeProfile(VolumeProfile volumeProfile)
		{
			// // Void ResetByVolumeProfile(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPDirtyLens::ResetByVolumeProfile(
			//         VFXPPDirtyLens *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   void *v6; // rdx
			//   MonitorData *monitor; // rcx
			//   Object__Class *klass; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Object *component; // [rsp+48h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D8ED992 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGDirtyLens>);
			//     byte_18D8ED992 = 1;
			//   }
			//   component = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2091, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2091, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)this,
			//         (Object *)volumeProfile,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_8;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
			//   if ( !UnityEngine::Object::op_Equality((Object_1 *)volumeProfile, 0LL, 0LL) )
			//   {
			//     if ( !volumeProfile )
			//       goto LABEL_8;
			//     if ( UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
			//            volumeProfile,
			//            &component,
			//            MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGDirtyLens>) )
			//     {
			//       if ( component )
			//       {
			//         LOBYTE(component[1].monitor) = 0;
			//         if ( component )
			//         {
			//           monitor = component[3].monitor;
			//           if ( monitor )
			//           {
			//             *((_BYTE *)monitor + 16) = 0;
			//             if ( component )
			//             {
			//               v6 = component[3].monitor;
			//               if ( v6 )
			//               {
			//                 sub_180042C50(11LL, v6);
			//                 if ( component )
			//                 {
			//                   klass = component[3].klass;
			//                   if ( klass )
			//                   {
			//                     LOBYTE(klass._0.name) = 0;
			//                     if ( component )
			//                     {
			//                       v6 = component[3].klass;
			//                       if ( v6 )
			//                       {
			//                         sub_180086B00(monitor, v6, 0LL);
			//                         return;
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			// LABEL_8:
			//       sub_180B536AC(monitor, v6);
			//     }
			//   }
			// }
			// 
		}

		public override bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::VFXPPDirtyLens::IsActive(VFXPPDirtyLens *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
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
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 2092 )
			//     return this.fields._intensity != 0.0;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			//     goto LABEL_8;
			//   if ( LODWORD(v3._0.namespaze) <= 0x82C )
			//     sub_180070270(v3, wrapperArray);
			//   if ( !*(_QWORD *)&v3[44]._1.cctor_finished_or_no_cctor )
			//     return this.fields._intensity != 0.0;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2092, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(v3, wrapperArray);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public void <>iFixBaseProxy_Apply(VolumeProfile P0)
		{
			// // Void <>iFixBaseProxy_Apply(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_Apply(
			//         VFXPPVignette *this,
			//         VolumeProfile *P0,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VFXPPComponent::Apply((VFXPPComponent *)this, P0, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_ResetByVolumeProfile(VolumeProfile P0)
		{
			// // Void <>iFixBaseProxy_ResetByVolumeProfile(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_ResetByVolumeProfile(
			//         VFXPPVignette *this,
			//         VolumeProfile *P0,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VFXPPComponent::ResetByVolumeProfile((VFXPPComponent *)this, P0, 0LL);
			// }
			// 
		}

		public bool <>iFixBaseProxy_IsActive()
		{
			// // Boolean <>iFixBaseProxy_IsActive()
			// bool HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_IsActive(VFXPPVignette *this, MethodInfo *method)
			// {
			//   return HG::Rendering::Runtime::VFXPPComponent::IsActive((VFXPPComponent *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		[SerializeField]
		[Range(0f, 1f)]
		private float _intensity;

		[SerializeField]
		private Texture2D _dirtyTex;
	}
}
