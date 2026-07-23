using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[VolumeComponentMenuForRenderPipeline("HG/SceneColorStylizer", new System.Type[1] {typeof(HGRenderPipeline) })]
	public class HGSceneColorStylizer : VolumeComponent // TypeDefIndex: 37631
	{
		// Fields
		private const string DOC_URL = "https://hypergryph.feishu.cn/wiki/wikcnvHsajmJ6CMUmnMfBzXgoSg"; // Metadata: 0x02302F75
		[InspectorName("\u603B\u5F00\u5173")]
		public ClampedFloatParameter masterIntensity; // 0x30
		[InspectorName("\u5F71\u54CD\u8303\u56F4\u8D77\u59CB / \u7ED3\u675F")]
		public FloatRangeParameter startEndRange; // 0x38
		[InspectorName("\u8FDC\u666F\u95F4\u63A5\u5149\u989C\u8272\u8986\u76D6")]
		[Space(20f)]
		public ColorParameter farIndirectColorOverride; // 0x40
		[InspectorName("\u8FDC\u666F\u95F4\u63A5\u5149\u7EC6\u8282\u6241\u5E73\u5316")]
		public ClampedFloatParameter farRemoveIndirectDetail; // 0x48
		[InspectorName("\u8FDC\u666F\u95F4\u63A5\u5149\u589E\u5F3A")]
		public ClampedFloatParameter farIndirectColorIntensity; // 0x50
		[InspectorName("\u8FDC\u666F\u76F4\u63A5\u5149\u6210\u5206\u5254\u9664\u95F4\u63A5\u5149")]
		public ClampedFloatParameter farIndirectRemove; // 0x58
		[InspectorName("\u8FDC\u666F\u76F4\u63A5\u5149\u989C\u8272\u8986\u76D6")]
		[Space(20f)]
		public ColorParameter farDirectLightingOverride; // 0x60
		[InspectorName("\u8FDC\u666F\u76F4\u63A5\u5149\u589E\u5F3A")]
		public ClampedFloatParameter farDirectColorIntensity; // 0x68
		[InspectorName("\u8FDC\u666F\u6750\u8D28\u56FA\u6709\u8272\u67D3\u8272")]
		[Space(20f)]
		public ColorParameter farAlbedoTint; // 0x70
		[InspectorName("\u8FDC\u666F\u6750\u8D28\u56FA\u6709\u8272\u9971\u548C\u5EA6")]
		public ClampedFloatParameter farAlbedoSaturation; // 0x78
	
		// Constructors
		public HGSceneColorStylizer() {} // 0x000000018374BDA0-0x000000018374C060
		// HGSceneColorStylizer()
		void HG::Rendering::Runtime::HGSceneColorStylizer::HGSceneColorStylizer(HGSceneColorStylizer *this, MethodInfo *method)
		{
		  __int64 v3; // rax
		  HGRuntimeGrassQuery_Node *v4; // rdx
		  __int64 v5; // rcx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  FloatRangeParameter *v8; // rax
		  FloatRangeParameter *v9; // rdi
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  __int64 v13; // rax
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  __int64 v16; // rax
		  HGRuntimeGrassQuery_Node *v17; // r8
		  Int32__Array **v18; // r9
		  __int64 v19; // rax
		  HGRuntimeGrassQuery_Node *v20; // r8
		  Int32__Array **v21; // r9
		  __int64 v22; // rax
		  HGRuntimeGrassQuery_Node *v23; // r8
		  Int32__Array **v24; // r9
		  __int64 v25; // rax
		  HGRuntimeGrassQuery_Node *v26; // r8
		  Int32__Array **v27; // r9
		  __int64 v28; // rax
		  HGRuntimeGrassQuery_Node *v29; // r8
		  Int32__Array **v30; // r9
		  __int64 v31; // rax
		  HGRuntimeGrassQuery_Node *v32; // r8
		  Int32__Array **v33; // r9
		  __int64 v34; // rax
		  HGRuntimeGrassQuery_Node *v35; // r8
		  Int32__Array **v36; // r9
		  MethodInfo *overrideState; // [rsp+20h] [rbp-28h]
		  MethodInfo *overrideStatei; // [rsp+20h] [rbp-28h]
		  MethodInfo *overrideStatea; // [rsp+20h] [rbp-28h]
		  MethodInfo *overrideStateb; // [rsp+20h] [rbp-28h]
		  MethodInfo *overrideStatec; // [rsp+20h] [rbp-28h]
		  MethodInfo *overrideStated; // [rsp+20h] [rbp-28h]
		  MethodInfo *overrideStatee; // [rsp+20h] [rbp-28h]
		  MethodInfo *overrideStatef; // [rsp+20h] [rbp-28h]
		  MethodInfo *overrideStateg; // [rsp+20h] [rbp-28h]
		  MethodInfo *overrideStateh; // [rsp+20h] [rbp-28h]
		
		  v3 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v3 )
		    goto LABEL_12;
		  *(_DWORD *)(v3 + 36) = 1065353216;
		  *(_DWORD *)(v3 + 24) = 0;
		  *(_BYTE *)(v3 + 16) = 0;
		  *(_DWORD *)(v3 + 32) = 0;
		  *(_DWORD *)(v3 + 40) = 1065353216;
		  this->fields.masterIntensity = (ClampedFloatParameter *)v3;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.masterIntensity, v4, v6, v7, overrideState);
		  v8 = (FloatRangeParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::FloatRangeParameter);
		  v9 = v8;
		  if ( !v8 )
		    goto LABEL_12;
		  UnityEngine::Rendering::FloatRangeParameter::FloatRangeParameter(
		    v8,
		    (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x43480000u, (__m128)0x43960000u),
		    0.0,
		    1000.0,
		    0,
		    0LL);
		  this->fields.startEndRange = v9;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.startEndRange, v10, v11, v12, overrideStatei);
		  v13 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v13 )
		    goto LABEL_12;
		  *(__m128i *)(v13 + 24) = _mm_load_si128((const __m128i *)&xmmword_18B959690);
		  *(_WORD *)(v13 + 40) = 256;
		  *(_BYTE *)(v13 + 42) = 1;
		  *(_BYTE *)(v13 + 16) = 0;
		  this->fields.farIndirectColorOverride = (ColorParameter *)v13;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.farIndirectColorOverride, v4, v14, v15, overrideStatea);
		  v16 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v16 )
		    goto LABEL_12;
		  *(_DWORD *)(v16 + 24) = 0;
		  *(_BYTE *)(v16 + 16) = 0;
		  *(_DWORD *)(v16 + 32) = 0;
		  *(_DWORD *)(v16 + 36) = 1065353216;
		  *(_DWORD *)(v16 + 40) = 1065353216;
		  this->fields.farRemoveIndirectDetail = (ClampedFloatParameter *)v16;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.farRemoveIndirectDetail, v4, v17, v18, overrideStateb);
		  v19 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v19 )
		    goto LABEL_12;
		  *(_DWORD *)(v19 + 24) = 1065353216;
		  *(_BYTE *)(v19 + 16) = 0;
		  *(_DWORD *)(v19 + 32) = 1065353216;
		  *(_DWORD *)(v19 + 36) = 1092616192;
		  *(_DWORD *)(v19 + 40) = 1065353216;
		  this->fields.farIndirectColorIntensity = (ClampedFloatParameter *)v19;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.farIndirectColorIntensity, v4, v20, v21, overrideStatec);
		  v22 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v22 )
		    goto LABEL_12;
		  *(_DWORD *)(v22 + 24) = 0;
		  *(_BYTE *)(v22 + 16) = 0;
		  *(_DWORD *)(v22 + 32) = 0;
		  *(_DWORD *)(v22 + 36) = 1065353216;
		  *(_DWORD *)(v22 + 40) = 1065353216;
		  this->fields.farIndirectRemove = (ClampedFloatParameter *)v22;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.farIndirectRemove, v4, v23, v24, overrideStated);
		  v25 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v25 )
		    goto LABEL_12;
		  *(__m128i *)(v25 + 24) = _mm_load_si128((const __m128i *)&xmmword_18B959690);
		  *(_WORD *)(v25 + 40) = 256;
		  *(_BYTE *)(v25 + 42) = 1;
		  *(_BYTE *)(v25 + 16) = 0;
		  this->fields.farDirectLightingOverride = (ColorParameter *)v25;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.farDirectLightingOverride, v4, v26, v27, overrideStatee);
		  v28 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v28 )
		    goto LABEL_12;
		  *(_DWORD *)(v28 + 24) = 1065353216;
		  *(_BYTE *)(v28 + 16) = 0;
		  *(_DWORD *)(v28 + 32) = 1065353216;
		  *(_DWORD *)(v28 + 36) = 1092616192;
		  *(_DWORD *)(v28 + 40) = 1065353216;
		  this->fields.farDirectColorIntensity = (ClampedFloatParameter *)v28;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.farDirectColorIntensity, v4, v29, v30, overrideStatef);
		  v31 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v31
		    || (*(__m128i *)(v31 + 24) = _mm_load_si128((const __m128i *)&xmmword_18B959690),
		        *(_WORD *)(v31 + 40) = 256,
		        *(_BYTE *)(v31 + 42) = 1,
		        *(_BYTE *)(v31 + 16) = 0,
		        this->fields.farAlbedoTint = (ColorParameter *)v31,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.farAlbedoTint, v4, v32, v33, overrideStateg),
		        (v34 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter)) == 0) )
		  {
		LABEL_12:
		    sub_1800D8260(v5, v4);
		  }
		  *(_DWORD *)(v34 + 24) = 1065353216;
		  *(_BYTE *)(v34 + 16) = 1;
		  *(_DWORD *)(v34 + 32) = 0;
		  *(_DWORD *)(v34 + 36) = 1084227584;
		  *(_DWORD *)(v34 + 40) = 1065353216;
		  this->fields.farAlbedoSaturation = (ClampedFloatParameter *)v34;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.farAlbedoSaturation, v4, v35, v36, overrideStateh);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	}
}
