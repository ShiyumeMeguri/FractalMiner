using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[CreateAssetMenu(fileName = "HGWaterSectorData", menuName = "HGWater/HGWaterSectorData")]
	public class HGWaterSectorData : ScriptableObject
	{
		public HGWaterSectorData()
		{
		}

		public static Texture2D GetWaterSectorTextureFromScriptableObject(ScriptableObject scriptableObject)
		{
			// // Texture2D GetWaterSectorTextureFromScriptableObject(ScriptableObject)
			// Texture2D *HG::Rendering::Runtime::HGWaterSectorData::GetWaterSectorTextureFromScriptableObject(
			//         ScriptableObject *scriptableObject,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rbx
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919844 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGWaterSectorData);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919844 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1924, 0LL) )
			//   {
			//     v3 = sub_18003F550(scriptableObject, TypeInfo::HG::Rendering::Runtime::HGWaterSectorData);
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( !UnityEngine::Object::op_Inequality(0LL, (Object_1 *)v3, 0LL) )
			//       return 0LL;
			//     if ( v3 )
			//       return *(Texture2D **)(v3 + 24);
			// LABEL_9:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1924, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_352(Patch, (Object *)scriptableObject, 0LL);
			// }
			// 
			return null;
		}

		private void OnEnable()
		{
			// // Void OnEnable()
			// void HG::Rendering::Runtime::HGWaterSectorData::OnEnable(HGWaterSectorData *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   int32_t InstanceID; // edi
			//   Object_1 *waterSectorTexture0; // rsi
			//   __int64 v6; // rdx
			//   Object_1 *v7; // rcx
			//   int32_t v8; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDBEF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDBEF = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4703, 0LL) )
			//   {
			//     InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)this, 0LL);
			//     waterSectorTexture0 = (Object_1 *)this.fields.waterSectorTexture0;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v3);
			//     if ( !UnityEngine::Object::op_Inequality(waterSectorTexture0, 0LL, 0LL) )
			//     {
			//       v8 = 0;
			//       goto LABEL_9;
			//     }
			//     v7 = (Object_1 *)this.fields.waterSectorTexture0;
			//     if ( v7 )
			//     {
			//       v8 = UnityEngine::Object::GetInstanceID(v7, 0LL);
			// LABEL_9:
			//       UnityEngine::HyperGryph::HGWaterRender::AddSectorTexture(InstanceID, v8, 0LL);
			//       return;
			//     }
			// LABEL_11:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4703, 0LL);
			//   if ( !Patch )
			//     goto LABEL_11;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private void OnDisable()
		{
			// // Void OnDisable()
			// void HG::Rendering::Runtime::HGWaterSectorData::OnDisable(HGWaterSectorData *this, MethodInfo *method)
			// {
			//   int32_t InstanceID; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4704, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4704, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)this, 0LL);
			//     UnityEngine::HyperGryph::HGWaterRender::RemoveSectorTexture(InstanceID, 0LL);
			//   }
			// }
			// 
		}

		[Header("Flowmap")]
		public Texture2D waterSectorTexture0;

		public Vector4[] rippleLayerBuffer;
	}
}
