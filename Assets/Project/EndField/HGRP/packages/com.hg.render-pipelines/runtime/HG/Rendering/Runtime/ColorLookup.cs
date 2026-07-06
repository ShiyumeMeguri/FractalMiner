using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("Post-processing/Color Lookup", new Type[] { typeof(HGRenderPipeline) })]
	[MigratingVolumeComponent]
	[Serializable]
	public sealed class ColorLookup : VolumeComponent, IPostProcessComponent
	{
		public ColorLookup()
		{
			// // ColorLookup()
			// void HG::Rendering::Runtime::ColorLookup::ColorLookup(ColorLookup *this, MethodInfo *method)
			// {
			//   TextureParameter *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   TextureParameter *v6; // rdi
			//   OneofDescriptorProto *v7; // rdx
			//   FileDescriptor *v8; // r8
			//   MessageDescriptor *v9; // r9
			//   ClampedFloatParameter *v10; // rax
			//   ClampedFloatParameter *v11; // rdi
			//   OneofDescriptorProto *v12; // rdx
			//   FileDescriptor *v13; // r8
			//   MessageDescriptor *v14; // r9
			//   MethodInfo *methoda; // [rsp+20h] [rbp-18h]
			//   MethodInfo *methodb; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v17; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v18; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v19; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v20; // [rsp+30h] [rbp-8h]
			// 
			//   if ( !byte_18D8ED9C5 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::TextureParameter);
			//     byte_18D8ED9C5 = 1;
			//   }
			//   v3 = (TextureParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureParameter);
			//   v6 = v3;
			//   if ( !v3
			//     || (UnityEngine::Rendering::TextureParameter::TextureParameter(v3, 0LL, TextureDimension__Enum_Any, 0, 0LL),
			//         this.fields.texture = v6,
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.texture,
			//           v7,
			//           v8,
			//           v9,
			//           (String__Array *)methoda,
			//           (String *)v17,
			//           v19),
			//         v10 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter),
			//         (v11 = v10) == 0LL) )
			//   {
			//     sub_180B536AC(v5, v4);
			//   }
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v10, 1.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.contribution = v11;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.contribution,
			//     v12,
			//     v13,
			//     v14,
			//     (String__Array *)methodb,
			//     (String *)v18,
			//     v20);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::ColorLookup::IsActive(ColorLookup *this, MethodInfo *method)
			// {
			//   __int64 v3; // rcx
			//   ClampedFloatParameter *contribution; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2216, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2216, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// LABEL_7:
			//     sub_180B536AC(v3, contribution);
			//   }
			//   contribution = this.fields.contribution;
			//   if ( !contribution )
			//     goto LABEL_7;
			//   return sub_18003F9B0(10LL, contribution) > 0.0 && HG::Rendering::Runtime::ColorLookup::ValidateLUT(this, 0LL);
			// }
			// 
			return default(bool);
		}

		public bool IsTileCompatible()
		{
			// // Boolean IsTileCompatible()
			// bool HG::Rendering::Runtime::ColorLookup::IsTileCompatible(ColorLookup *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2218, 0LL) )
			//     return 1;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2218, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public bool ValidateLUT()
		{
			// // Boolean ValidateLUT()
			// bool HG::Rendering::Runtime::ColorLookup::ValidateLUT(ColorLookup *this, MethodInfo *method)
			// {
			//   bool v2; // di
			//   Object_1 *currentAsset; // rbx
			//   __int64 v5; // rcx
			//   TextureParameter *texture; // rdx
			//   Object_1 *v7; // rbx
			//   struct Texture2D__Class **v8; // r8
			//   RenderTexture *v9; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v2 = 0;
			//   if ( !byte_18D919453 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::RenderTexture);
			//     sub_18003C530(&TypeInfo::UnityEngine::Texture2D);
			//     byte_18D919453 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2217, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2217, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//     goto LABEL_22;
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//   currentAsset = (Object_1 *)HG::Rendering::Runtime::HGRenderPipeline::get_currentAsset(0LL);
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( UnityEngine::Object::op_Equality(currentAsset, 0LL, 0LL) )
			//     return 0;
			//   texture = this.fields.texture;
			//   if ( !texture )
			//     goto LABEL_22;
			//   v7 = (Object_1 *)sub_18004EF00(10LL, texture);
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( UnityEngine::Object::op_Equality(v7, 0LL, 0LL) )
			//     return 0;
			//   texture = this.fields.texture;
			//   if ( !texture || !sub_18004EF00(10LL, texture) )
			// LABEL_22:
			//     sub_180B536AC(v5, texture);
			//   if ( (unsigned int)sub_18003ED00(7LL) != 32 )
			//     return 0;
			//   texture = this.fields.texture;
			//   if ( !texture )
			//     goto LABEL_22;
			//   v8 = (struct Texture2D__Class **)sub_18004EF00(10LL, texture);
			//   if ( v8 && *v8 == TypeInfo::UnityEngine::Texture2D )
			//     return (unsigned int)sub_18003ED00(5LL) == 1024;
			//   v9 = (RenderTexture *)sub_18003F5A0(v8, TypeInfo::UnityEngine::RenderTexture);
			//   if ( v9
			//     && (unsigned int)sub_18003ED00(9LL) == 2
			//     && (unsigned int)sub_18003ED00(5LL) == 1024
			//     && !UnityEngine::RenderTexture::get_sRGB(v9, 0LL) )
			//   {
			//     return 1;
			//   }
			//   return v2;
			// }
			// 
			return default(bool);
		}

		[Tooltip("A custom 2D texture lookup table to apply.")]
		public TextureParameter texture;

		[Tooltip("How much of the lookup texture will contribute to the color grading effect.")]
		public ClampedFloatParameter contribution;
	}
}
