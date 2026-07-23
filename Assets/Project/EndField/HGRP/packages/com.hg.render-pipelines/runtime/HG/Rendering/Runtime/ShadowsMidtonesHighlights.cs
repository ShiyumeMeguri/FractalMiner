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
	[VolumeComponentMenuForRenderPipeline("Post-processing/Shadows, Midtones, Highlights", new System.Type[1] {typeof(HGRenderPipeline) })]
	public sealed class ShadowsMidtonesHighlights : VolumeComponent, IPostProcessComponent // TypeDefIndex: 38061
	{
		// Fields
		[Tooltip("Use this to control and apply a hue to the shadows.")]
		public Vector4Parameter shadows; // 0x30
		[Tooltip("Use this to control and apply a hue to the midtones.")]
		public Vector4Parameter midtones; // 0x38
		[Tooltip("Use this to control and apply a hue to the highlights.")]
		public Vector4Parameter highlights; // 0x40
		[Header("Shadow Limits")]
		[Tooltip("Sets the start point of the transition between shadows and midtones.")]
		public MinFloatParameter shadowsStart; // 0x48
		[Tooltip("Sets the end point of the transition between shadows and midtones.")]
		public MinFloatParameter shadowsEnd; // 0x50
		[Header("Highlight Limits")]
		[Tooltip("Sets the start point of the transition between midtones and highlights.")]
		public MinFloatParameter highlightsStart; // 0x58
		[Tooltip("Sets the end point of the transition between midtones and highlights.")]
		public MinFloatParameter highlightsEnd; // 0x60
	
		// Constructors
		private ShadowsMidtonesHighlights() {} // 0x000000018374C390-0x000000018374C520
		// ShadowsMidtonesHighlights()
		void HG::Rendering::Runtime::ShadowsMidtonesHighlights::ShadowsMidtonesHighlights(
		        ShadowsMidtonesHighlights *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rax
		  HGRuntimeGrassQuery_Node *v4; // rdx
		  __int64 v5; // rcx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  __m128i si128; // xmm6
		  __int64 v9; // rax
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  __int64 v12; // rax
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  __int64 v15; // rax
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  __int64 v18; // rax
		  HGRuntimeGrassQuery_Node *v19; // r8
		  Int32__Array **v20; // r9
		  __int64 v21; // rax
		  HGRuntimeGrassQuery_Node *v22; // r8
		  Int32__Array **v23; // r9
		  __int64 v24; // rax
		  HGRuntimeGrassQuery_Node *v25; // r8
		  Int32__Array **v26; // r9
		  HGRuntimeGrassQuery_Node *v27; // rdx
		  HGRuntimeGrassQuery_Node *v28; // r8
		  Int32__Array **v29; // r9
		  MethodInfo *v30; // [rsp+20h] [rbp-18h]
		  MethodInfo *v31; // [rsp+20h] [rbp-18h]
		  MethodInfo *v32; // [rsp+20h] [rbp-18h]
		  MethodInfo *v33; // [rsp+20h] [rbp-18h]
		  MethodInfo *v34; // [rsp+20h] [rbp-18h]
		  MethodInfo *v35; // [rsp+20h] [rbp-18h]
		  MethodInfo *v36; // [rsp+20h] [rbp-18h]
		  MethodInfo *v37; // [rsp+60h] [rbp+28h]
		
		  v3 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
		  if ( !v3 )
		    goto LABEL_9;
		  si128 = _mm_load_si128((const __m128i *)&xmmword_18B959690);
		  *(__m128i *)(v3 + 24) = si128;
		  *(_BYTE *)(v3 + 16) = 0;
		  this->fields.shadows = (Vector4Parameter *)v3;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.shadows, v4, v6, v7, v30);
		  v9 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
		  if ( !v9 )
		    goto LABEL_9;
		  *(__m128i *)(v9 + 24) = si128;
		  *(_BYTE *)(v9 + 16) = 0;
		  this->fields.midtones = (Vector4Parameter *)v9;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.midtones, v4, v10, v11, v31);
		  v12 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
		  if ( !v12 )
		    goto LABEL_9;
		  *(__m128i *)(v12 + 24) = si128;
		  *(_BYTE *)(v12 + 16) = 0;
		  this->fields.highlights = (Vector4Parameter *)v12;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.highlights, v4, v13, v14, v32);
		  v15 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
		  if ( !v15 )
		    goto LABEL_9;
		  *(_DWORD *)(v15 + 24) = 0;
		  *(_BYTE *)(v15 + 16) = 0;
		  *(_DWORD *)(v15 + 32) = 0;
		  this->fields.shadowsStart = (MinFloatParameter *)v15;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.shadowsStart, v4, v16, v17, v33);
		  v18 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
		  if ( !v18 )
		    goto LABEL_9;
		  *(_DWORD *)(v18 + 24) = 1050253722;
		  *(_BYTE *)(v18 + 16) = 0;
		  *(_DWORD *)(v18 + 32) = 0;
		  this->fields.shadowsEnd = (MinFloatParameter *)v18;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.shadowsEnd, v4, v19, v20, v34);
		  v21 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
		  if ( !v21
		    || (*(_DWORD *)(v21 + 24) = 1057803469,
		        *(_BYTE *)(v21 + 16) = 0,
		        *(_DWORD *)(v21 + 32) = 0,
		        this->fields.highlightsStart = (MinFloatParameter *)v21,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.highlightsStart, v4, v22, v23, v35),
		        (v24 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::MinFloatParameter)) == 0) )
		  {
		LABEL_9:
		    sub_1800D8260(v5, v4);
		  }
		  *(_DWORD *)(v24 + 24) = 1065353216;
		  *(_BYTE *)(v24 + 16) = 0;
		  *(_DWORD *)(v24 + 32) = 0;
		  this->fields.highlightsEnd = (MinFloatParameter *)v24;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.highlightsEnd, v4, v25, v26, v36);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		  this->fields._._displayName_k__BackingField = (String *)"Shadows, Midtones, Highlights";
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._._displayName_k__BackingField, v27, v28, v29, v37);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000189B6DD38-0x0000000189B6DDD8
		// Boolean IsActive()
		bool HG::Rendering::Runtime::ShadowsMidtonesHighlights::IsActive(ShadowsMidtonesHighlights *this, MethodInfo *method)
		{
		  __m128i si128; // xmm6
		  Vector4Parameter *shadows; // rcx
		  Vector4Parameter *midtones; // rcx
		  Vector4Parameter *highlights; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  __m128i v11; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2705, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2705, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    si128 = _mm_load_si128((const __m128i *)&xmmword_18B959690);
		    shadows = this->fields.shadows;
		    v11 = si128;
		    if ( (unsigned __int8)sub_1808AEDA8(shadows, &v11) )
		      return 1;
		    midtones = this->fields.midtones;
		    v11 = si128;
		    if ( (unsigned __int8)sub_1808AEDA8(midtones, &v11) )
		    {
		      return 1;
		    }
		    else
		    {
		      highlights = this->fields.highlights;
		      v11 = si128;
		      return sub_1808AEDA8(highlights, &v11);
		    }
		  }
		}
		
	}
}
