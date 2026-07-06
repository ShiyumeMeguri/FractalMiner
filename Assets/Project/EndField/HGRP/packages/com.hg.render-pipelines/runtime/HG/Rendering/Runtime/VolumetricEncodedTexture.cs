using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Beyond.Resource;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class VolumetricEncodedTexture
	{
		// (get) Token: 0x06001B45 RID: 6981 RVA: 0x00002710 File Offset: 0x00000910
		// (set) Token: 0x06001B46 RID: 6982 RVA: 0x000025D0 File Offset: 0x000007D0
		public long AssetHash
		{
			get
			{
				// // IUnit get_destinationUnit()
				// IUnit *Unity::VisualScripting::UnitConnection<System::Object,System::Object>::get_destinationUnit(
				//         UnitConnection_2_System_Object_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._destinationUnit_k__BackingField;
				// }
				// 
				return 0L;
			}
			set
			{
				// // BBParameter`1[UnityEngine.Vector2](Vector2)
				// void NodeCanvas::Framework::BBParameter<UnityEngine::Vector2>::BBParameter(
				//         BBParameter_1_UnityEngine_Vector2_ *this,
				//         Vector2 value,
				//         MethodInfo *method)
				// {
				//   this.fields._value = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool IsValid
		{
			get
			{
				// // Boolean get_IsValid()
				// bool HG::Rendering::Runtime::VolumetricEncodedTexture::get_IsValid(VolumetricEncodedTexture *this, MethodInfo *method)
				// {
				//   Object_1 *Tex; // rbx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				// 
				//   if ( !byte_18D9197E8 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D9197E8 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(4354, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(4354, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v7, v6);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     Tex = (Object_1 *)this.fields.Tex;
				//     sub_180002C70(TypeInfo::UnityEngine::Object);
				//     return UnityEngine::Object::op_Inequality(Tex, 0LL, 0LL) || this.fields._assetHash == 0;
				//   }
				// }
				// 
				return default(bool);
			}
		}

		public VolumetricEncodedTexture()
		{
			// // VolumetricEncodedTexture()
			// void HG::Rendering::Runtime::VolumetricEncodedTexture::VolumetricEncodedTexture(
			//         VolumetricEncodedTexture *this,
			//         MethodInfo *method)
			// {
			//   Vector3Int *v2; // r8
			//   ITilemap *v3; // r9
			//   TileAnimationData *TileAnimationDataNoRef; // rax
			//   __int64 v5; // rdx
			//   Vector4 *one; // rax
			//   __int64 v7; // rdx
			//   Vector4 v8; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                              (TileAnimationData *)&v8,
			//                              (TileBase *)this,
			//                              v2,
			//                              v3,
			//                              *(MethodInfo **)&v8.x);
			//   *(TileAnimationData *)(v5 + 24) = *TileAnimationDataNoRef;
			//   one = UnityEngine::Vector4::get_one(&v8, (MethodInfo *)v5);
			//   *(Vector4 *)(v7 + 40) = *one;
			// }
			// 
		}

		public VolumetricEncodedTexture(Texture tex)
		{
			// // VolumetricEncodedTexture(Texture)
			// void HG::Rendering::Runtime::VolumetricEncodedTexture::VolumetricEncodedTexture(
			//         VolumetricEncodedTexture *this,
			//         Texture *tex,
			//         MethodInfo *method)
			// {
			//   ITilemap *v3; // r9
			//   TileAnimationData *TileAnimationDataNoRef; // rax
			//   __int64 v5; // r8
			//   MethodInfo *v6; // rdx
			//   Vector4 v7; // xmm1
			//   HGRenderPathBase_HGRenderPathResources *v8; // rdx
			//   __int64 v9; // r8
			//   HGCamera *v10; // r9
			//   Vector4 v11; // [rsp+20h] [rbp-18h] BYREF
			//   MethodInfo *v12; // [rsp+60h] [rbp+28h]
			//   MethodInfo *v13; // [rsp+68h] [rbp+30h]
			// 
			//   TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                              (TileAnimationData *)&v11,
			//                              (TileBase *)tex,
			//                              (Vector3Int *)this,
			//                              v3,
			//                              *(MethodInfo **)&v11.x);
			//   *(TileAnimationData *)(v5 + 24) = *TileAnimationDataNoRef;
			//   v7 = *UnityEngine::Vector4::get_one(&v11, v6);
			//   *(_QWORD *)(v9 + 16) = v8;
			//   *(Vector4 *)(v9 + 40) = v7;
			//   sub_1800054D0((HGRenderPathScene *)(v9 + 16), v8, (PassConstructorID__Enum__Array *)v9, v10, v12, v13);
			// }
			// 
		}

		public VolumetricEncodedTexture(Texture tex, Vector4 rangeBase, Vector4 rangeScale)
		{
			// // VolumetricEncodedTexture(Texture, Vector4, Vector4)
			// void HG::Rendering::Runtime::VolumetricEncodedTexture::VolumetricEncodedTexture(
			//         VolumetricEncodedTexture *this,
			//         Texture *tex,
			//         Vector4 *rangeBase,
			//         Vector4 *rangeScale,
			//         MethodInfo *method)
			// {
			//   TileAnimationData *TileAnimationDataNoRef; // rax
			//   __int64 v6; // r11
			//   MethodInfo *v7; // rdx
			//   __m128i v8; // xmm1
			//   HGRenderPathBase_HGRenderPathResources *v9; // rdx
			//   __int64 v10; // r11
			//   PassConstructorID__Enum__Array *v11; // r8
			//   HGCamera *v12; // r9
			//   _OWORD *v13; // r10
			//   __int128 *v14; // r9
			//   __int128 v15; // xmm1
			//   __int64 v16; // r11
			//   Vector4 v17; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                              (TileAnimationData *)&v17,
			//                              (TileBase *)tex,
			//                              (Vector3Int *)rangeBase,
			//                              (ITilemap *)rangeScale,
			//                              *(MethodInfo **)&v17.x);
			//   *(__m128i *)(v6 + 24) = _mm_loadu_si128((const __m128i *)TileAnimationDataNoRef);
			//   v8 = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one(&v17, v7));
			//   *(_QWORD *)(v10 + 16) = v9;
			//   *(__m128i *)(v10 + 40) = v8;
			//   sub_1800054D0((HGRenderPathScene *)(v10 + 16), v9, v11, v12, *(MethodInfo **)&v17.x, *(MethodInfo **)&v17.z);
			//   v15 = *v14;
			//   *(_OWORD *)(v16 + 24) = *v13;
			//   *(_OWORD *)(v16 + 40) = v15;
			// }
			// 
		}

		public void LoadAsset()
		{
			// // Void LoadAsset()
			// void HG::Rendering::Runtime::VolumetricEncodedTexture::LoadAsset(VolumetricEncodedTexture *this, MethodInfo *method)
			// {
			//   Object_1 *Tex; // rbx
			//   int64_t assetHash; // rbx
			//   int32_t m_mainVersion; // eax
			//   HGRenderPathBase_HGRenderPathResources *v6; // rdx
			//   PassConstructorID__Enum__Array *v7; // r8
			//   HGCamera *v8; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   MethodInfo *v12; // [rsp+20h] [rbp-38h]
			//   MethodInfo *v13; // [rsp+28h] [rbp-30h]
			//   FAssetProxyHandle v14; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D9197E9 )
			//   {
			//     sub_18003C530(&MethodInfo::Beyond::Resource::FAssetProxyHandle::Get<UnityEngine::Texture3D>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::Beyond::Resource::ResourceManager::Load<UnityEngine::Texture3D>);
			//     sub_18003C530(&TypeInfo::Beyond::Resource::ResourceManager);
			//     byte_18D9197E9 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4413, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4413, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     Tex = (Object_1 *)this.fields.Tex;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality(Tex, 0LL, 0LL)
			//       && this.fields._assetHash
			//       && !Beyond::Resource::FAssetProxyHandle::IsValid(&this.fields._assetHandle, 0LL) )
			//     {
			//       assetHash = this.fields._assetHash;
			//       sub_180002C70(TypeInfo::Beyond::Resource::ResourceManager);
			//       Beyond::Resource::ResourceManager::Load<System::Object>(
			//         &v14,
			//         (StringPathHash)assetHash,
			//         RootCategory__Enum_Main,
			//         EResourceRequestPriority__Enum_Default,
			//         MethodInfo::Beyond::Resource::ResourceManager::Load<UnityEngine::Texture3D>);
			//       m_mainVersion = v14.m_untrackedHandle.m_mainVersion;
			//       *(_OWORD *)&this.fields._assetHandle.m_untrackedHandle.m_handleObjectID = *(_OWORD *)&v14.m_untrackedHandle.m_handleObjectID;
			//       this.fields._assetHandle.m_untrackedHandle.m_mainVersion = m_mainVersion;
			//       this.fields.Tex = (Texture *)Beyond::Resource::FAssetProxyHandle::Get<System::Object>(
			//                                       &this.fields._assetHandle,
			//                                       MethodInfo::Beyond::Resource::FAssetProxyHandle::Get<UnityEngine::Texture3D>);
			//       sub_1800054D0((HGRenderPathScene *)&this.fields, v6, v7, v8, v12, v13);
			//     }
			//   }
			// }
			// 
		}

		public void LoadAssetAsync()
		{
			// // Void LoadAssetAsync()
			// void HG::Rendering::Runtime::VolumetricEncodedTexture::LoadAssetAsync(
			//         VolumetricEncodedTexture *this,
			//         MethodInfo *method)
			// {
			//   Object_1 *Tex; // rbx
			//   int64_t assetHash; // rbx
			//   int32_t m_mainVersion; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   FAssetProxyHandle v9; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D9197EA )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::Beyond::Resource::ResourceManager::LoadAsync<UnityEngine::Texture3D>);
			//     sub_18003C530(&TypeInfo::Beyond::Resource::ResourceManager);
			//     byte_18D9197EA = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4380, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4380, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     Tex = (Object_1 *)this.fields.Tex;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality(Tex, 0LL, 0LL)
			//       && this.fields._assetHash
			//       && !Beyond::Resource::FAssetProxyHandle::IsValid(&this.fields._assetHandle, 0LL) )
			//     {
			//       assetHash = this.fields._assetHash;
			//       sub_180002C70(TypeInfo::Beyond::Resource::ResourceManager);
			//       Beyond::Resource::ResourceManager::LoadAsync<System::Object>(
			//         &v9,
			//         (StringPathHash)assetHash,
			//         RootCategory__Enum_Main,
			//         EResourceRequestPriority__Enum_Default,
			//         MethodInfo::Beyond::Resource::ResourceManager::LoadAsync<UnityEngine::Texture3D>);
			//       m_mainVersion = v9.m_untrackedHandle.m_mainVersion;
			//       *(_OWORD *)&this.fields._assetHandle.m_untrackedHandle.m_handleObjectID = *(_OWORD *)&v9.m_untrackedHandle.m_handleObjectID;
			//       this.fields._assetHandle.m_untrackedHandle.m_mainVersion = m_mainVersion;
			//     }
			//   }
			// }
			// 
		}

		public bool UpdateAssetLoading()
		{
			return default(bool);
		}

		public void UnloadAsset()
		{
			// // Void UnloadAsset()
			// void HG::Rendering::Runtime::VolumetricEncodedTexture::UnloadAsset(VolumetricEncodedTexture *this, MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v3; // rdx
			//   PassConstructorID__Enum__Array *v4; // r8
			//   HGCamera *v5; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   MethodInfo *v9; // [rsp+50h] [rbp+28h]
			//   MethodInfo *v10; // [rsp+58h] [rbp+30h]
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4384, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4384, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( Beyond::Resource::FAssetProxyHandle::IsValid(&this.fields._assetHandle, 0LL) )
			//   {
			//     Beyond::Resource::FAssetProxyHandle::Dispose(&this.fields._assetHandle, 0LL);
			//     *(_OWORD *)&this.fields._assetHandle.m_untrackedHandle.m_handleObjectID = 0LL;
			//     this.fields._assetHandle.m_untrackedHandle.m_mainVersion = 0;
			//     this.fields.Tex = 0LL;
			//     sub_1800054D0((HGRenderPathScene *)&this.fields, v3, v4, v5, v9, v10);
			//   }
			// }
			// 
		}

		public static VolumetricEncodedTexture.PropertyIDPack GetEncodedTexIDPack(string name)
		{
			// // VolumetricEncodedTexture+PropertyIDPack GetEncodedTexIDPack(String)
			// VolumetricEncodedTexture_PropertyIDPack *HG::Rendering::Runtime::VolumetricEncodedTexture::GetEncodedTexIDPack(
			//         VolumetricEncodedTexture_PropertyIDPack *__return_ptr retstr,
			//         String *name,
			//         MethodInfo *method)
			// {
			//   VolumetricEncodedTexture__StaticFields *static_fields; // rdx
			//   Dictionary_2_System_String_HG_Rendering_Runtime_VolumetricEncodedTexture_PropertyIDPack_ *s_EncodedTexIDPackDict; // rcx
			//   String *v7; // rax
			//   String *v8; // rax
			//   int32_t RangeScale; // esi
			//   __int64 v10; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   VolumetricEncodedTexture_PropertyIDPack *v12; // rax
			//   __int64 v13; // xmm0_8
			//   VolumetricEncodedTexture_PropertyIDPack value; // [rsp+20h] [rbp-10h] BYREF
			//   __int64 v16; // [rsp+40h] [rbp+10h]
			// 
			//   if ( !byte_18D9197EC )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::VolumetricEncodedTexture::PropertyIDPack>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::VolumetricEncodedTexture::PropertyIDPack>::TryGetValue);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricEncodedTexture);
			//     sub_18003C530(&off_18D521CE0);
			//     sub_18003C530(&off_18D521CF0);
			//     byte_18D9197EC = 1;
			//   }
			//   *(_QWORD *)&value._Tex = 0LL;
			//   value._RangeScale = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(4451, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4451, 0LL);
			//     if ( Patch )
			//     {
			//       v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1279(&value, Patch, (Object *)name, 0LL);
			//       v13 = *(_QWORD *)&v12._Tex;
			//       LODWORD(v12) = v12._RangeScale;
			//       *(_QWORD *)&retstr._Tex = v13;
			//       retstr._RangeScale = (int)v12;
			//       return retstr;
			//     }
			//     goto LABEL_11;
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricEncodedTexture);
			//   s_EncodedTexIDPackDict = TypeInfo::HG::Rendering::Runtime::VolumetricEncodedTexture.static_fields.s_EncodedTexIDPackDict;
			//   if ( !s_EncodedTexIDPackDict )
			//     goto LABEL_11;
			//   if ( System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::VolumetricEncodedTexture::PropertyIDPack>::TryGetValue(
			//          (Dictionary_2_System_Object_HG_Rendering_Runtime_VolumetricEncodedTexture_PropertyIDPack_ *)s_EncodedTexIDPackDict,
			//          (Object *)name,
			//          &value,
			//          MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::VolumetricEncodedTexture::PropertyIDPack>::TryGetValue) )
			//   {
			//     RangeScale = value._RangeScale;
			//     v10 = *(_QWORD *)&value._Tex;
			//     goto LABEL_9;
			//   }
			//   value._Tex = UnityEngine::Shader::PropertyToID(name, 0LL);
			//   v7 = System::String::Concat(name, (String *)"_RemapRangeBase", 0LL);
			//   value._RangeBase = UnityEngine::Shader::PropertyToID(v7, 0LL);
			//   v8 = System::String::Concat(name, (String *)"_RemapRangeScale", 0LL);
			//   RangeScale = UnityEngine::Shader::PropertyToID(v8, 0LL);
			//   v16 = *(_QWORD *)&value._Tex;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::VolumetricEncodedTexture);
			//   static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricEncodedTexture.static_fields;
			//   s_EncodedTexIDPackDict = static_fields.s_EncodedTexIDPackDict;
			//   if ( !static_fields.s_EncodedTexIDPackDict )
			// LABEL_11:
			//     sub_180B536AC(s_EncodedTexIDPackDict, static_fields);
			//   value._RangeScale = RangeScale;
			//   System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::VolumetricEncodedTexture::PropertyIDPack>::Add(
			//     (Dictionary_2_System_Object_HG_Rendering_Runtime_VolumetricEncodedTexture_PropertyIDPack_ *)s_EncodedTexIDPackDict,
			//     (Object *)name,
			//     &value,
			//     MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::VolumetricEncodedTexture::PropertyIDPack>::Add);
			//   v10 = v16;
			// LABEL_9:
			//   *(_QWORD *)&retstr._Tex = v10;
			//   retstr._RangeScale = RangeScale;
			//   return retstr;
			// }
			// 
			return default(VolumetricEncodedTexture.PropertyIDPack);
		}

		public Texture Tex;

		public Vector4 RangeBase;

		public Vector4 RangeScale;

		private long _assetHash;

		private FAssetProxyHandle _assetHandle;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static Dictionary<string, VolumetricEncodedTexture.PropertyIDPack> s_EncodedTexIDPackDict;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
		public struct PropertyIDPack
		{
			public int _Tex;

			public int _RangeBase;

			public int _RangeScale;
		}
	}
}
