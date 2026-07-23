using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class HGShaderPassNames // TypeDefIndex: 38167
	{
		// Fields
		public static readonly string s_EmptyStr; // 0x00
		public static readonly string s_ForwardStr; // 0x08
		public static readonly string s_ForwardLitStr; // 0x10
		public static readonly string s_DepthOnlyStr; // 0x18
		public static readonly string s_DepthForwardOnlyStr; // 0x20
		public static readonly string s_DepthCharacterOnlyStr; // 0x28
		public static readonly string s_ForwardCharacterOnlyStr; // 0x30
		public static readonly string s_CharacterOutlineStr; // 0x38
		public static readonly string s_ForwardOnlyStr; // 0x40
		public static readonly string s_ReflectionForwardOnlyStr; // 0x48
		public static readonly string s_VFXDecalStr; // 0x50
		public static readonly string s_GBufferStr; // 0x58
		public static readonly string s_ErosionStr; // 0x60
		public static readonly string s_ErosionMobileStr; // 0x68
		public static readonly string s_HGBufferStr; // 0x70
		public static readonly string s_TerrainDepthOnly; // 0x78
		public static readonly string s_GBufferWithPrepassStr; // 0x80
		public static readonly string s_SRPDefaultUnlitStr; // 0x88
		public static readonly string s_MotionVectorsStr; // 0x90
		public static readonly string s_DistortionStr; // 0x98
		public static readonly string s_VolumerticFogVoxelizationStr; // 0xA0
		public static readonly string s_TransparentDepthPrepassStr; // 0xA8
		public static readonly string s_TransparentBackfaceStr; // 0xB0
		public static readonly string s_TransparentDepthPostpassStr; // 0xB8
		public static readonly string s_MetaStr; // 0xC0
		public static readonly string s_ShadowCasterStr; // 0xC8
		public static readonly string s_FullScreenDebugStr; // 0xD0
		public static readonly string s_BakeHLODStr; // 0xD8
		public static readonly string s_OccludedDisplayStr; // 0xE0
		public static readonly string s_StencilAlphaBlendStr; // 0xE8
		public static readonly string s_PostProcessMaskStr; // 0xF0
		public static readonly ShaderTagId s_EmptyName; // 0xF8
		public static readonly ShaderTagId s_ForwardName; // 0xFC
		public static readonly ShaderTagId s_DepthOnlyName; // 0x100
		public static readonly ShaderTagId s_DepthForwardOnlyName; // 0x104
		public static readonly ShaderTagId s_DepthCharacterOnlyName; // 0x108
		public static readonly ShaderTagId s_ForwardCharacterOnlyName; // 0x10C
		public static readonly ShaderTagId s_CharacterOutlineName; // 0x110
		public static readonly ShaderTagId s_ForwardOnlyName; // 0x114
		public static readonly ShaderTagId s_ReflectionForwardOnlyName; // 0x118
		public static readonly ShaderTagId s_VFXDecalName; // 0x11C
		public static readonly ShaderTagId s_GBufferName; // 0x120
		public static readonly ShaderTagId s_ErosionName; // 0x124
		public static readonly ShaderTagId s_ErosionMobileName; // 0x128
		public static readonly ShaderTagId s_TerrainDepthOnlyName; // 0x12C
		public static readonly ShaderTagId s_GBufferWithPrepassName; // 0x130
		public static readonly ShaderTagId s_SRPDefaultUnlitName; // 0x134
		public static readonly ShaderTagId s_MotionVectorsName; // 0x138
		public static readonly ShaderTagId s_DistortionName; // 0x13C
		public static readonly ShaderTagId s_VolumerticFogVoxelizationName; // 0x140
		public static readonly ShaderTagId s_TransparentDepthPrepassName; // 0x144
		public static readonly ShaderTagId s_TransparentBackfaceName; // 0x148
		public static readonly ShaderTagId s_TransparentDepthPostpassName; // 0x14C
		public static readonly ShaderTagId s_FullScreenDebugName; // 0x150
		public static readonly ShaderTagId s_StencilAlphaBlendName; // 0x154
		public static readonly ShaderTagId s_PPMaskName; // 0x158
		public static readonly ShaderTagId s_OccludedDisplayName; // 0x15C
		internal static readonly ShaderTagId s_AlwaysName; // 0x160
		internal static readonly ShaderTagId s_ForwardBaseName; // 0x164
		internal static readonly ShaderTagId s_DeferredName; // 0x168
		internal static readonly ShaderTagId s_PrepassBaseName; // 0x16C
		internal static readonly ShaderTagId s_VertexName; // 0x170
		internal static readonly ShaderTagId s_VertexLMRGBMName; // 0x174
		internal static readonly ShaderTagId s_VertexLMName; // 0x178
	
		// Constructors
		static HGShaderPassNames() {} // 0x00000001846429F0-0x00000001846435C0
		// HGShaderPassNames()
		void HG::Rendering::Runtime::HGShaderPassNames::cctor(MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v1; // rdx
		  HGRuntimeGrassQuery_Node *v2; // r8
		  Int32__Array **v3; // r9
		  Int32__Array **v4; // r9
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  HGRuntimeGrassQuery_Node *v8; // rdx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  HGRuntimeGrassQuery_Node *v14; // rdx
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  HGRuntimeGrassQuery_Node *v17; // rdx
		  HGRuntimeGrassQuery_Node *v18; // r8
		  Int32__Array **v19; // r9
		  HGRuntimeGrassQuery_Node *v20; // rdx
		  HGRuntimeGrassQuery_Node *v21; // r8
		  Int32__Array **v22; // r9
		  HGRuntimeGrassQuery_Node *v23; // rdx
		  HGRuntimeGrassQuery_Node *v24; // r8
		  Int32__Array **v25; // r9
		  HGRuntimeGrassQuery_Node *v26; // rdx
		  HGRuntimeGrassQuery_Node *v27; // r8
		  Int32__Array **v28; // r9
		  HGRuntimeGrassQuery_Node *v29; // rdx
		  HGRuntimeGrassQuery_Node *v30; // r8
		  Int32__Array **v31; // r9
		  HGRuntimeGrassQuery_Node *v32; // rdx
		  HGRuntimeGrassQuery_Node *v33; // r8
		  Int32__Array **v34; // r9
		  HGRuntimeGrassQuery_Node *v35; // rdx
		  HGRuntimeGrassQuery_Node *v36; // r8
		  Int32__Array **v37; // r9
		  HGRuntimeGrassQuery_Node *v38; // rdx
		  HGRuntimeGrassQuery_Node *v39; // r8
		  Int32__Array **v40; // r9
		  HGRuntimeGrassQuery_Node *v41; // rdx
		  HGRuntimeGrassQuery_Node *v42; // r8
		  Int32__Array **v43; // r9
		  HGRuntimeGrassQuery_Node *v44; // rdx
		  HGRuntimeGrassQuery_Node *v45; // r8
		  Int32__Array **v46; // r9
		  HGRuntimeGrassQuery_Node *v47; // rdx
		  HGRuntimeGrassQuery_Node *v48; // r8
		  Int32__Array **v49; // r9
		  HGRuntimeGrassQuery_Node *v50; // rdx
		  HGRuntimeGrassQuery_Node *v51; // r8
		  Int32__Array **v52; // r9
		  HGRuntimeGrassQuery_Node *v53; // rdx
		  HGRuntimeGrassQuery_Node *v54; // r8
		  Int32__Array **v55; // r9
		  HGRuntimeGrassQuery_Node *v56; // rdx
		  HGRuntimeGrassQuery_Node *v57; // r8
		  Int32__Array **v58; // r9
		  HGRuntimeGrassQuery_Node *v59; // rdx
		  HGRuntimeGrassQuery_Node *v60; // r8
		  Int32__Array **v61; // r9
		  HGRuntimeGrassQuery_Node *v62; // rdx
		  HGRuntimeGrassQuery_Node *v63; // r8
		  Int32__Array **v64; // r9
		  HGRuntimeGrassQuery_Node *v65; // rdx
		  HGRuntimeGrassQuery_Node *v66; // r8
		  Int32__Array **v67; // r9
		  HGRuntimeGrassQuery_Node *v68; // rdx
		  HGRuntimeGrassQuery_Node *v69; // r8
		  Int32__Array **v70; // r9
		  HGRuntimeGrassQuery_Node *v71; // rdx
		  HGRuntimeGrassQuery_Node *v72; // r8
		  Int32__Array **v73; // r9
		  HGRuntimeGrassQuery_Node *v74; // rdx
		  HGRuntimeGrassQuery_Node *v75; // r8
		  Int32__Array **v76; // r9
		  HGRuntimeGrassQuery_Node *v77; // rdx
		  HGRuntimeGrassQuery_Node *v78; // r8
		  Int32__Array **v79; // r9
		  HGRuntimeGrassQuery_Node *v80; // rdx
		  HGRuntimeGrassQuery_Node *v81; // r8
		  Int32__Array **v82; // r9
		  HGRuntimeGrassQuery_Node *v83; // rdx
		  HGRuntimeGrassQuery_Node *v84; // r8
		  Int32__Array **v85; // r9
		  HGRuntimeGrassQuery_Node *v86; // rdx
		  HGRuntimeGrassQuery_Node *v87; // r8
		  Int32__Array **v88; // r9
		  HGRuntimeGrassQuery_Node *v89; // rdx
		  HGRuntimeGrassQuery_Node *v90; // r8
		  Int32__Array **v91; // r9
		  HGRuntimeGrassQuery_Node *v92; // rdx
		  HGRuntimeGrassQuery_Node *v93; // r8
		  MethodInfo *v94; // [rsp+20h] [rbp-8h]
		  MethodInfo *v95; // [rsp+20h] [rbp-8h]
		  MethodInfo *v96; // [rsp+20h] [rbp-8h]
		  MethodInfo *v97; // [rsp+20h] [rbp-8h]
		  MethodInfo *v98; // [rsp+20h] [rbp-8h]
		  MethodInfo *v99; // [rsp+20h] [rbp-8h]
		  MethodInfo *v100; // [rsp+20h] [rbp-8h]
		  MethodInfo *v101; // [rsp+20h] [rbp-8h]
		  MethodInfo *v102; // [rsp+20h] [rbp-8h]
		  MethodInfo *v103; // [rsp+20h] [rbp-8h]
		  MethodInfo *v104; // [rsp+20h] [rbp-8h]
		  MethodInfo *v105; // [rsp+20h] [rbp-8h]
		  MethodInfo *v106; // [rsp+20h] [rbp-8h]
		  MethodInfo *v107; // [rsp+20h] [rbp-8h]
		  MethodInfo *v108; // [rsp+20h] [rbp-8h]
		  MethodInfo *v109; // [rsp+20h] [rbp-8h]
		  MethodInfo *v110; // [rsp+20h] [rbp-8h]
		  MethodInfo *v111; // [rsp+20h] [rbp-8h]
		  MethodInfo *v112; // [rsp+20h] [rbp-8h]
		  MethodInfo *v113; // [rsp+20h] [rbp-8h]
		  MethodInfo *v114; // [rsp+20h] [rbp-8h]
		  MethodInfo *v115; // [rsp+20h] [rbp-8h]
		  MethodInfo *v116; // [rsp+20h] [rbp-8h]
		  MethodInfo *v117; // [rsp+20h] [rbp-8h]
		  MethodInfo *v118; // [rsp+20h] [rbp-8h]
		  MethodInfo *v119; // [rsp+20h] [rbp-8h]
		  MethodInfo *v120; // [rsp+20h] [rbp-8h]
		  MethodInfo *v121; // [rsp+20h] [rbp-8h]
		  MethodInfo *v122; // [rsp+20h] [rbp-8h]
		  MethodInfo *v123; // [rsp+20h] [rbp-8h]
		  MethodInfo *v124; // [rsp+20h] [rbp-8h]
		
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_EmptyStr = (String *)"";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields,
		    v1,
		    v2,
		    v3,
		    v94);
		  v4 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ForwardStr = (String *)"Forward";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ForwardStr,
		    v5,
		    v6,
		    v4,
		    v95);
		  v7 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ForwardLitStr = (String *)"ForwardLit";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ForwardLitStr,
		    v8,
		    v9,
		    v7,
		    v96);
		  v10 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_DepthOnlyStr = (String *)"DepthOnly";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_DepthOnlyStr,
		    v11,
		    v12,
		    v10,
		    v97);
		  v13 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_DepthForwardOnlyStr = (String *)"DepthForwardOnly";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_DepthForwardOnlyStr,
		    v14,
		    v15,
		    v13,
		    v98);
		  v16 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_DepthCharacterOnlyStr = (String *)"DepthCharacterOnly";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_DepthCharacterOnlyStr,
		    v17,
		    v18,
		    v16,
		    v99);
		  v19 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ForwardCharacterOnlyStr = (String *)"ForwardCharacterOnly";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ForwardCharacterOnlyStr,
		    v20,
		    v21,
		    v19,
		    v100);
		  v22 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_CharacterOutlineStr = (String *)"CharacterOutline";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_CharacterOutlineStr,
		    v23,
		    v24,
		    v22,
		    v101);
		  v25 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ForwardOnlyStr = (String *)"ForwardOnly";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ForwardOnlyStr,
		    v26,
		    v27,
		    v25,
		    v102);
		  v28 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ReflectionForwardOnlyStr = (String *)"ReflectionForwardOnly";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ReflectionForwardOnlyStr,
		    v29,
		    v30,
		    v28,
		    v103);
		  v31 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_VFXDecalStr = (String *)"VFXDecal";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_VFXDecalStr,
		    v32,
		    v33,
		    v31,
		    v104);
		  v34 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_GBufferStr = (String *)"GBuffer";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_GBufferStr,
		    v35,
		    v36,
		    v34,
		    v105);
		  v37 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ErosionStr = (String *)"Erosion";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ErosionStr,
		    v38,
		    v39,
		    v37,
		    v106);
		  v40 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ErosionMobileStr = (String *)"ErosionMobile";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ErosionMobileStr,
		    v41,
		    v42,
		    v40,
		    v107);
		  v43 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_HGBufferStr = (String *)"HGBuffer";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_HGBufferStr,
		    v44,
		    v45,
		    v43,
		    v108);
		  v46 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_TerrainDepthOnly = (String *)"TerrainDepthOnly";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_TerrainDepthOnly,
		    v47,
		    v48,
		    v46,
		    v109);
		  v49 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_GBufferWithPrepassStr = (String *)"GBufferWithPrepass";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_GBufferWithPrepassStr,
		    v50,
		    v51,
		    v49,
		    v110);
		  v52 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_SRPDefaultUnlitStr = (String *)"SRPDefaultUnlit";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_SRPDefaultUnlitStr,
		    v53,
		    v54,
		    v52,
		    v111);
		  v55 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_MotionVectorsStr = (String *)"MotionVectors";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_MotionVectorsStr,
		    v56,
		    v57,
		    v55,
		    v112);
		  v58 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_DistortionStr = (String *)"Distortion";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_DistortionStr,
		    v59,
		    v60,
		    v58,
		    v113);
		  v61 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_VolumerticFogVoxelizationStr = (String *)"VolumerticFogVoxelization";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_VolumerticFogVoxelizationStr,
		    v62,
		    v63,
		    v61,
		    v114);
		  v64 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_TransparentDepthPrepassStr = (String *)"TransparentDepthPrepass";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_TransparentDepthPrepassStr,
		    v65,
		    v66,
		    v64,
		    v115);
		  v67 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_TransparentBackfaceStr = (String *)"TransparentBackface";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_TransparentBackfaceStr,
		    v68,
		    v69,
		    v67,
		    v116);
		  v70 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_TransparentDepthPostpassStr = (String *)"TransparentDepthPostpass";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_TransparentDepthPostpassStr,
		    v71,
		    v72,
		    v70,
		    v117);
		  v73 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_MetaStr = (String *)"META";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_MetaStr,
		    v74,
		    v75,
		    v73,
		    v118);
		  v76 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ShadowCasterStr = (String *)"ShadowCaster";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ShadowCasterStr,
		    v77,
		    v78,
		    v76,
		    v119);
		  v79 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_FullScreenDebugStr = (String *)"FullScreenDebug";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_FullScreenDebugStr,
		    v80,
		    v81,
		    v79,
		    v120);
		  v82 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_BakeHLODStr = (String *)"BakeHLOD";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_BakeHLODStr,
		    v83,
		    v84,
		    v82,
		    v121);
		  v85 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_OccludedDisplayStr = (String *)"OccludedDisplay";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_OccludedDisplayStr,
		    v86,
		    v87,
		    v85,
		    v122);
		  v88 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_StencilAlphaBlendStr = (String *)"StencilAlphaBlend";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_StencilAlphaBlendStr,
		    v89,
		    v90,
		    v88,
		    v123);
		  v91 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGShaderPassNames;
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_PostProcessMaskStr = (String *)"PostProcessMask";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_PostProcessMaskStr,
		    v92,
		    v93,
		    v91,
		    v124);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_EmptyName.m_Id = UnityEngine::Shader::TagToID(
		                                                                                           TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_EmptyStr,
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ForwardName.m_Id = UnityEngine::Shader::TagToID(
		                                                                                             TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ForwardStr,
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_DepthOnlyName.m_Id = UnityEngine::Shader::TagToID(
		                                                                                               TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_DepthOnlyStr,
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_DepthForwardOnlyName.m_Id = UnityEngine::Shader::TagToID(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_DepthForwardOnlyStr, 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_DepthCharacterOnlyName.m_Id = UnityEngine::Shader::TagToID(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_DepthCharacterOnlyStr, 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ForwardCharacterOnlyName.m_Id = UnityEngine::Shader::TagToID(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ForwardCharacterOnlyStr, 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_CharacterOutlineName.m_Id = UnityEngine::Shader::TagToID(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_CharacterOutlineStr, 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ForwardOnlyName.m_Id = UnityEngine::Shader::TagToID(
		                                                                                                 TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ForwardOnlyStr,
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ReflectionForwardOnlyName.m_Id = UnityEngine::Shader::TagToID(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ReflectionForwardOnlyStr, 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_VFXDecalName.m_Id = UnityEngine::Shader::TagToID(
		                                                                                              TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_VFXDecalStr,
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_GBufferName.m_Id = UnityEngine::Shader::TagToID(
		                                                                                             TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_GBufferStr,
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ErosionName.m_Id = UnityEngine::Shader::TagToID(
		                                                                                             TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ErosionStr,
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ErosionMobileName.m_Id = UnityEngine::Shader::TagToID(
		                                                                                                   TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ErosionMobileStr,
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_TerrainDepthOnlyName.m_Id = UnityEngine::Shader::TagToID(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_TerrainDepthOnly, 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_GBufferWithPrepassName.m_Id = UnityEngine::Shader::TagToID(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_GBufferWithPrepassStr, 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_SRPDefaultUnlitName.m_Id = UnityEngine::Shader::TagToID(
		                                                                                                     TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_SRPDefaultUnlitStr,
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_MotionVectorsName.m_Id = UnityEngine::Shader::TagToID(
		                                                                                                   TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_MotionVectorsStr,
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_DistortionName.m_Id = UnityEngine::Shader::TagToID(
		                                                                                                TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_DistortionStr,
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_VolumerticFogVoxelizationName.m_Id = UnityEngine::Shader::TagToID(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_VolumerticFogVoxelizationStr, 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_TransparentDepthPrepassName.m_Id = UnityEngine::Shader::TagToID(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_TransparentDepthPrepassStr, 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_TransparentBackfaceName.m_Id = UnityEngine::Shader::TagToID(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_TransparentBackfaceStr, 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_TransparentDepthPostpassName.m_Id = UnityEngine::Shader::TagToID(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_TransparentDepthPostpassStr, 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_FullScreenDebugName.m_Id = UnityEngine::Shader::TagToID(
		                                                                                                     TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_FullScreenDebugStr,
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_StencilAlphaBlendName.m_Id = UnityEngine::Shader::TagToID(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_StencilAlphaBlendStr, 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_PPMaskName.m_Id = UnityEngine::Shader::TagToID(
		                                                                                            TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_PostProcessMaskStr,
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_OccludedDisplayName.m_Id = UnityEngine::Shader::TagToID(
		                                                                                                     TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_OccludedDisplayStr,
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_AlwaysName.m_Id = UnityEngine::Shader::TagToID(
		                                                                                            (String *)"Always",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ForwardBaseName.m_Id = UnityEngine::Shader::TagToID(
		                                                                                                 (String *)"ForwardBase",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_DeferredName.m_Id = UnityEngine::Shader::TagToID(
		                                                                                              (String *)"Deferred",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_PrepassBaseName.m_Id = UnityEngine::Shader::TagToID(
		                                                                                                 (String *)"PrepassBase",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_VertexName.m_Id = UnityEngine::Shader::TagToID(
		                                                                                            (String *)"Vertex",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_VertexLMRGBMName.m_Id = UnityEngine::Shader::TagToID(
		                                                                                                  (String *)"VertexLMRGBM",
		                                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_VertexLMName.m_Id = UnityEngine::Shader::TagToID(
		                                                                                              (String *)"VertexLM",
		                                                                                              0LL);
		}
		
	}
}
