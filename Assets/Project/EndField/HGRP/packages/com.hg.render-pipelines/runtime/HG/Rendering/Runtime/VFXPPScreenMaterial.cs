using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[RequireComponent(typeof(MeshRenderer))]
	[ExecuteInEditMode]
	[AddComponentMenu("HG/Effect/VFXPPScreenMaterial(全屏特效材质)")]
	public class VFXPPScreenMaterial : VFXPPComponent
	{
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x00002998 File Offset: 0x00000B98
		protected override VFXPPType m_VFXPPType
		{
			get
			{
				// // Int32 System.Runtime.CompilerServices.ITuple.get_Length()
				// int32_t System::ValueTuple<System::Object,System::Object,System::Object,System::Object,System::Object,System::Object,System::Object>::System_Runtime_CompilerServices_ITuple_get_Length(
				//         ValueTuple_7_Object_Object_Object_Object_Object_Object_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return 7;
				// }
				// 
				return (VFXPPType)VFXPPType.ChromaticAberration;
			}
		}

		// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x000025D8 File Offset: 0x000007D8
		public static bool fullScreenMaterialValid
		{
			get
			{
				// // Boolean get_fullScreenMaterialValid()
				// bool HG::Rendering::Runtime::VFXPPScreenMaterial::get_fullScreenMaterialValid(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   Material *fullScreenMaterial; // rbx
				// 
				//   if ( !byte_18D8ED9A4 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial);
				//     byte_18D8ED9A4 = 1;
				//   }
				//   fullScreenMaterial = TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial.static_fields.fullScreenMaterial;
				//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v1);
				//   if ( !byte_18D8F4EFB )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8F4EFB = 1;
				//   }
				//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v1);
				//   if ( !byte_18D8F4EAF )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Object);
				//     byte_18D8F4EAF = 1;
				//   }
				//   if ( !fullScreenMaterial )
				//     return 0;
				//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v1);
				//   return fullScreenMaterial.fields._.m_CachedPtr != 0;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x000025D2 File Offset: 0x000007D2
		public static MaterialPropertyBlock fullScreenMaterialPropertyBlock
		{
			get
			{
				return null;
			}
		}

		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x000025D2 File Offset: 0x000007D2
		internal static FullScreenVFXData fullScreenVFXData
		{
			get
			{
				return null;
			}
		}

		public VFXPPScreenMaterial()
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

		private void Awake()
		{
		}

		public override void Apply(VolumeProfile volumeProfile)
		{
			// // Void Apply(VolumeProfile)
			// void HG::Rendering::Runtime::VFXPPScreenMaterial::Apply(
			//         VFXPPScreenMaterial *this,
			//         VolumeProfile *volumeProfile,
			//         MethodInfo *method)
			// {
			//   Object_1 *transform; // rbx
			//   __int64 v6; // rdx
			//   MaterialPropertyBlock *fullScreenMaterialPropertyBlock; // rax
			//   Renderer *m_renderer; // rcx
			//   HGRenderPathBase_HGRenderPathResources *v9; // rdx
			//   PassConstructorID__Enum__Array *v10; // r8
			//   HGCamera *v11; // r9
			//   Material *SharedMaterial; // rax
			//   HGRenderPathBase_HGRenderPathResources *static_fields; // rdx
			//   PassConstructorID__Enum__Array *v14; // r8
			//   HGCamera *v15; // r9
			//   Renderer *v16; // rbx
			//   MaterialPropertyBlock *v17; // rax
			//   MaterialPropertyBlock *v18; // rax
			//   __m128i si128; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __m128i v21; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919438 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial);
			//     sub_18003C530(&off_18D4E9170);
			//     byte_18D919438 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2136, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2136, 0LL);
			//     if ( !Patch )
			//       goto LABEL_13;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)volumeProfile,
			//       0LL);
			//   }
			//   else
			//   {
			//     transform = (Object_1 *)UnityEngine::Component::get_transform((Component *)this, 0LL);
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality(transform, 0LL, 0LL) )
			//       return;
			//     if ( !this.fields.m_hasValidVFXShader )
			//     {
			//       fullScreenMaterialPropertyBlock = HG::Rendering::Runtime::VFXPPScreenMaterial::get_fullScreenMaterialPropertyBlock(0LL);
			//       if ( fullScreenMaterialPropertyBlock )
			//       {
			//         UnityEngine::MaterialPropertyBlock::Clear(fullScreenMaterialPropertyBlock, 1, 0LL);
			//         TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial.static_fields.fullScreenMaterial = 0LL;
			//         sub_1800054D0(
			//           (HGRenderPathScene *)&TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial.static_fields.fullScreenMaterial,
			//           v9,
			//           v10,
			//           v11,
			//           (MethodInfo *)v21.m128i_i64[0],
			//           (MethodInfo *)v21.m128i_i64[1]);
			//         return;
			//       }
			// LABEL_13:
			//       sub_180B536AC(m_renderer, v6);
			//     }
			//     m_renderer = this.fields.m_renderer;
			//     if ( !m_renderer )
			//       goto LABEL_13;
			//     SharedMaterial = UnityEngine::Renderer::GetSharedMaterial(m_renderer, 0LL);
			//     static_fields = (HGRenderPathBase_HGRenderPathResources *)TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial.static_fields;
			//     static_fields.settingParameters = (HGSettingParameters *)SharedMaterial;
			//     sub_1800054D0(
			//       (HGRenderPathScene *)&TypeInfo::HG::Rendering::Runtime::VFXPPScreenMaterial.static_fields.fullScreenMaterial,
			//       static_fields,
			//       v14,
			//       v15,
			//       (MethodInfo *)v21.m128i_i64[0],
			//       (MethodInfo *)v21.m128i_i64[1]);
			//     v16 = this.fields.m_renderer;
			//     v17 = HG::Rendering::Runtime::VFXPPScreenMaterial::get_fullScreenMaterialPropertyBlock(0LL);
			//     if ( !v16 )
			//       goto LABEL_13;
			//     UnityEngine::Renderer::Internal_GetPropertyBlock(v16, v17, 0LL);
			//     v18 = HG::Rendering::Runtime::VFXPPScreenMaterial::get_fullScreenMaterialPropertyBlock(0LL);
			//     si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576A0);
			//     if ( !v18 )
			//       goto LABEL_13;
			//     v21 = si128;
			//     UnityEngine::MaterialPropertyBlock::SetVector(v18, (String *)"unity_LODFade", (Vector4 *)&v21, 0LL);
			//   }
			// }
			// 
		}

		public override void ResetByVolumeProfile(VolumeProfile volumeProfile)
		{
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

		private Renderer m_renderer;

		private const string SHADER_VFX_BASE = "HGRP/Effect/VFXBaseV2";

		private Material m_baseMaterial;

		private bool m_hasValidVFXShader;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static MaterialPropertyBlock s_materialPropertyBlock;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		public static Material fullScreenMaterial;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static FullScreenVFXData s_fullScreenVFXData;
	}
}
