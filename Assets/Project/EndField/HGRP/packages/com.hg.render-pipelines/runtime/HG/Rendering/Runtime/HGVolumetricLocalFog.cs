using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("Rendering/Volumetric Local Fog")]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	public class HGVolumetricLocalFog : MonoBehaviour
	{
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x000025D0 File Offset: 0x000007D0
		public Material material
		{
			get
			{
				// // Object System.Collections.IEnumerator.get_Current()
				// Object *Rewired::Platforms::Custom::HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_::vFJqwhcHvHdpsRAHqwODiJDbwkcr<System::Object>::System_Collections_IEnumerator_get_Current(
				//         HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_vFJqwhcHvHdpsRAHqwODiJDbwkcr_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return (Object *)this.fields.YcoKziTgrGqKCwJTNRuXadHqwkUP;
				// }
				// 
				return null;
			}
			set
			{
				// // Void set_getValueDelegate(Func`1[Boolean])
				// void Rewired::Utils::Classes::Utility::ValueWatcher<bool>::set_getValueDelegate(
				//         ValueWatcher_1_System_Boolean_ *this,
				//         Func_1_Boolean_ *value,
				//         MethodInfo *method)
				// {
				//   MessageDescriptor *v3; // r9
				//   String__Array *v4; // [rsp+28h] [rbp+28h]
				//   String *v5; // [rsp+30h] [rbp+30h]
				//   MethodInfo *v6; // [rsp+38h] [rbp+38h]
				// 
				//   this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA = value;
				//   sub_1800054D0(
				//     (OneofDescriptor *)&this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA,
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

		public HGVolumetricLocalFog()
		{
			// // Singleton`1[System.Object]()
			// void RootMotion::Singleton<System::Object>::Singleton(Singleton_1_System_Object__1 *this, MethodInfo *method)
			// {
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		protected void OnEnable()
		{
			// // Void OnEnable()
			// void HG::Rendering::Runtime::HGVolumetricLocalFog::OnEnable(HGVolumetricLocalFog *this, MethodInfo *method)
			// {
			//   HGVolumetricLocalFogManager *instance; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919DA1 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricLocalFogManager);
			//     byte_18D919DA1 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1307, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricLocalFogManager);
			//     instance = HG::Rendering::Runtime::HGVolumetricLocalFogManager::get_instance(0LL);
			//     if ( instance )
			//     {
			//       HG::Rendering::Runtime::HGVolumetricLocalFogManager::AddVolumetricLocalFog(instance, this, 0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1307, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		protected void OnDisable()
		{
			// // Void OnDisable()
			// void HG::Rendering::Runtime::HGVolumetricLocalFog::OnDisable(HGVolumetricLocalFog *this, MethodInfo *method)
			// {
			//   HGVolumetricLocalFogManager *instance; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919DA2 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricLocalFogManager);
			//     byte_18D919DA2 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1310, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricLocalFogManager);
			//     instance = HG::Rendering::Runtime::HGVolumetricLocalFogManager::get_instance(0LL);
			//     if ( instance )
			//     {
			//       HG::Rendering::Runtime::HGVolumetricLocalFogManager::RemoveVolumetricLocalFog(instance, this, 0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1310, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		protected void Reset()
		{
			// // Void Reset()
			// void HG::Rendering::Runtime::HGVolumetricLocalFog::Reset(HGVolumetricLocalFog *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1314, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1314, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGVolumetricLocalFog::OnValidate(this, 0LL);
			//   }
			// }
			// 
		}

		internal void OnValidate()
		{
		}

		[SerializeField]
		private Material m_material;

		private Material m_previousMaterial;
	}
}
