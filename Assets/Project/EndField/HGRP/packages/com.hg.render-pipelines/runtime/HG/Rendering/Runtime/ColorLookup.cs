using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[MigratingVolumeComponent]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Color Lookup", new System.Type[1] {typeof(HGRenderPipeline) })]
	public sealed class ColorLookup : VolumeComponent, IPostProcessComponent // TypeDefIndex: 38009
	{
		// Fields
		[Tooltip("A custom 2D texture lookup table to apply.")]
		public TextureParameter texture; // 0x30
		[Tooltip("How much of the lookup texture will contribute to the color grading effect.")]
		public ClampedFloatParameter contribution; // 0x38
	
		// Constructors
		public ColorLookup() {} // 0x0000000184791450-0x0000000184791500
		// ColorLookup()
		void HG::Rendering::Runtime::ColorLookup::ColorLookup(ColorLookup *this, MethodInfo *method)
		{
		  TextureParameter *v3; // rax
		  Type *v4; // rdx
		  __int64 v5; // rcx
		  TextureParameter *v6; // rbx
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  __int64 v10; // rax
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  MethodInfo *methodb; // [rsp+20h] [rbp-18h]
		  MethodInfo *methoda; // [rsp+20h] [rbp-18h]
		
		  v3 = (TextureParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureParameter);
		  v6 = v3;
		  if ( !v3
		    || (UnityEngine::Rendering::TextureParameter::TextureParameter(v3, 0LL, TextureDimension__Enum_Any, 0, 0LL),
		        this->fields.texture = v6,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.texture, v7, v8, v9, methodb),
		        (v10 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter)) == 0) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  *(_DWORD *)(v10 + 24) = 1065353216;
		  *(_BYTE *)(v10 + 16) = 0;
		  *(_DWORD *)(v10 + 32) = 0;
		  *(_DWORD *)(v10 + 36) = 1065353216;
		  *(_DWORD *)(v10 + 40) = 1065353216;
		  this->fields.contribution = (ClampedFloatParameter *)v10;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.contribution, v4, v11, v12, methoda);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000189B68F68-0x0000000189B68FE0
		// Boolean IsActive()
		bool HG::Rendering::Runtime::ColorLookup::IsActive(ColorLookup *this, MethodInfo *method)
		{
		  __int64 v3; // rcx
		  ClampedFloatParameter *contribution; // rdx
		  double v5; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2673, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2673, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		LABEL_7:
		    sub_1800D8260(v3, contribution);
		  }
		  contribution = this->fields.contribution;
		  if ( !contribution )
		    goto LABEL_7;
		  v5 = sub_1800057D0(10LL, contribution);
		  return *(float *)&v5 > 0.0 && HG::Rendering::Runtime::ColorLookup::ValidateLUT(this, 0LL);
		}
		
		public bool IsTileCompatible() => default; // 0x0000000189B68FE0-0x0000000189B6902C
		// Boolean IsTileCompatible()
		bool HG::Rendering::Runtime::ColorLookup::IsTileCompatible(ColorLookup *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2675, 0LL) )
		    return 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2675, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public bool ValidateLUT() => default; // 0x0000000189B6902C-0x0000000189B691C0
		// Boolean ValidateLUT()
		bool HG::Rendering::Runtime::ColorLookup::ValidateLUT(ColorLookup *this, MethodInfo *method)
		{
		  bool v3; // di
		  Object_1 *currentAsset; // rbx
		  __int64 v5; // rcx
		  TextureParameter *texture; // rdx
		  Object_1 *v7; // rbx
		  __int64 v8; // rax
		  struct Texture2D__Class **v9; // r8
		  __int64 v10; // rax
		  RenderTexture *v11; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(2674, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2674, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		    goto LABEL_20;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		  currentAsset = (Object_1 *)HG::Rendering::Runtime::HGRenderPipeline::get_currentAsset(0LL);
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Equality(currentAsset, 0LL, 0LL) )
		    return 0;
		  texture = this->fields.texture;
		  if ( !texture )
		    goto LABEL_20;
		  v7 = (Object_1 *)sub_1800460A0(10LL, texture);
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Equality(v7, 0LL, 0LL) )
		    return 0;
		  texture = this->fields.texture;
		  if ( !texture || (v8 = sub_1800460A0(10LL, texture)) == 0 )
		LABEL_20:
		    sub_1800D8260(v5, texture);
		  if ( (unsigned int)sub_180002F70(7LL, v8) != 32 )
		    return 0;
		  texture = this->fields.texture;
		  if ( !texture )
		    goto LABEL_20;
		  v9 = (struct Texture2D__Class **)sub_1800460A0(10LL, texture);
		  if ( v9 && *v9 == TypeInfo::UnityEngine::Texture2D )
		    return (unsigned int)sub_180002F70(5LL, v9) == 1024;
		  v10 = sub_180005050(v9, TypeInfo::UnityEngine::RenderTexture);
		  v11 = (RenderTexture *)v10;
		  if ( v10
		    && (unsigned int)sub_180002F70(9LL, v10) == 2
		    && (unsigned int)sub_180002F70(5LL, v11) == 1024
		    && !UnityEngine::RenderTexture::get_sRGB(v11, 0LL) )
		  {
		    return 1;
		  }
		  return v3;
		}
		
	}
}
