using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class VolumetricSdfAsset : ScriptableObject
	{
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool IsValid
		{
			get
			{
				return default(bool);
			}
		}

		public VolumetricSdfAsset()
		{
			// // SingletonScriptableObject`1[System.Object]()
			// void Beyond::SingletonScriptableObject<System::Object>::SingletonScriptableObject(
			//         SingletonScriptableObject_1_System_Object_ *this,
			//         MethodInfo *method)
			// {
			//   UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
			// }
			// 
		}

		public void LoadAssets()
		{
			// // Void LoadAssets()
			// void HG::Rendering::Runtime::VolumetricSdfAsset::LoadAssets(VolumetricSdfAsset *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   VolumetricEncodedTexture__Array *SdfTexs; // rdi
			//   int32_t i; // ebx
			//   VolumetricEncodedTexture *v7; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4412, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4412, 0LL);
			//     if ( !Patch )
			// LABEL_10:
			//       sub_180B536AC(v7, v3);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( this.fields.SdfTexs )
			//   {
			//     SdfTexs = this.fields.SdfTexs;
			//     for ( i = 0; i < SdfTexs.max_length.size; ++i )
			//     {
			//       if ( (unsigned int)i >= SdfTexs.max_length.size )
			//         sub_180070270(v4, v3);
			//       v7 = SdfTexs.vector[i];
			//       if ( !v7 )
			//         goto LABEL_10;
			//       HG::Rendering::Runtime::VolumetricEncodedTexture::LoadAsset(v7, 0LL);
			//     }
			//   }
			// }
			// 
		}

		public void LoadAssetsAsync()
		{
			// // Void LoadAssetsAsync()
			// void HG::Rendering::Runtime::VolumetricSdfAsset::LoadAssetsAsync(VolumetricSdfAsset *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   VolumetricEncodedTexture__Array *SdfTexs; // rdi
			//   int32_t i; // ebx
			//   VolumetricEncodedTexture *v7; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4379, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4379, 0LL);
			//     if ( !Patch )
			// LABEL_10:
			//       sub_180B536AC(v7, v3);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( this.fields.SdfTexs )
			//   {
			//     SdfTexs = this.fields.SdfTexs;
			//     for ( i = 0; i < SdfTexs.max_length.size; ++i )
			//     {
			//       if ( (unsigned int)i >= SdfTexs.max_length.size )
			//         sub_180070270(v4, v3);
			//       v7 = SdfTexs.vector[i];
			//       if ( !v7 )
			//         goto LABEL_10;
			//       HG::Rendering::Runtime::VolumetricEncodedTexture::LoadAssetAsync(v7, 0LL);
			//     }
			//   }
			// }
			// 
		}

		public bool UpdateAssetLoading()
		{
			return default(bool);
		}

		public void UnloadAssets()
		{
			// // Void UnloadAssets()
			// void HG::Rendering::Runtime::VolumetricSdfAsset::UnloadAssets(VolumetricSdfAsset *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   VolumetricEncodedTexture__Array *SdfTexs; // rdi
			//   int32_t i; // ebx
			//   VolumetricEncodedTexture *v7; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4383, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4383, 0LL);
			//     if ( !Patch )
			// LABEL_10:
			//       sub_180B536AC(v7, v3);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( this.fields.SdfTexs )
			//   {
			//     SdfTexs = this.fields.SdfTexs;
			//     for ( i = 0; i < SdfTexs.max_length.size; ++i )
			//     {
			//       if ( (unsigned int)i >= SdfTexs.max_length.size )
			//         sub_180070270(v4, v3);
			//       v7 = SdfTexs.vector[i];
			//       if ( !v7 )
			//         goto LABEL_10;
			//       HG::Rendering::Runtime::VolumetricEncodedTexture::UnloadAsset(v7, 0LL);
			//     }
			//   }
			// }
			// 
		}

		public VolumetricEncodedTexture[] SdfTexs;

		public Bounds VolumeBounds;

		public Vector4 Payload;
	}
}
