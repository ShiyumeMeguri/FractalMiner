using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[VolumeComponentMenuForRenderPipeline("HG/ScanLine", new System.Type[1] {typeof(HGRenderPipeline) })]
	public sealed class HGScanLine : VolumeComponent // TypeDefIndex: 38047
	{
		// Fields
		public BoolParameter enabled; // 0x30
		public Vector4Parameter centerPos; // 0x38
		public ClampedFloatParameter progress; // 0x40
		public ColorParameter color; // 0x48
		public ClampedFloatParameter angleBlendFallOff; // 0x50
		public BoolParameter useMaskTex; // 0x58
		public Texture2DParameter maskTex; // 0x60
		public Vector2Parameter maskTexTiling; // 0x68
		public Vector2Parameter maskTexOffset; // 0x70
		public ClampedFloatParameter interval; // 0x78
		public ClampedFloatParameter width; // 0x80
		public ClampedFloatParameter maxDistance; // 0x88
		public ClampedFloatParameter minDistance; // 0x90
		public ClampedFloatParameter smoothness; // 0x98
		public ClampedFloatParameter maxFade; // 0xA0
		public ClampedFloatParameter distortScale; // 0xA8
		public ClampedFloatParameter charDistortScale; // 0xB0
		public ClampedFloatParameter distortIntensity; // 0xB8
		public ClampedFloatParameter charBrightIntensity; // 0xC0
		public ClampedFloatParameter charDistortIntensity; // 0xC8
		public ClampedFloatParameter charDistortOnEdge; // 0xD0
		public ClampedFloatParameter charDistortOuter; // 0xD8
		public ClampedFloatParameter distortSpeed; // 0xE0
		public ClampedFloatParameter charDistortSpeed; // 0xE8
		public ClampedFloatParameter highlightFading; // 0xF0
		public ClampedFloatParameter highlightWidth; // 0xF8
		public ClampedFloatParameter highlightThickness; // 0x100
		public ClampedFloatParameter maxDetectionDistance; // 0x108
		public ClampedFloatParameter boxDistMin; // 0x110
		public ClampedFloatParameter boxDistMid; // 0x118
		public ClampedFloatParameter boxDistMax; // 0x120
		public ClampedFloatParameter headHeight; // 0x128
		public ClampedFloatParameter tailHeight; // 0x130
		public ClampedFloatParameter headAlpha; // 0x138
		public ClampedFloatParameter tailAlpha; // 0x140
		public ClampedFloatParameter flowingSpeed; // 0x148
		public ClampedFloatParameter flowingStrength; // 0x150
		public ClampedFloatParameter nearHighlight; // 0x158
		public ClampedFloatParameter farHighlight; // 0x160
		public ClampedFloatParameter midBloom; // 0x168
		public ClampedFloatParameter maxBloom; // 0x170
		public ClampedFloatParameter maxDetectionDistanceHL; // 0x178
		public ClampedFloatParameter minHeight; // 0x180
		public ClampedFloatParameter midHeight; // 0x188
		public ClampedFloatParameter maxHeight; // 0x190
		public ClampedFloatParameter meshHeight; // 0x198
		public ColorParameter colorHighlight; // 0x1A0
		public ColorParameter colorHighlightBeam; // 0x1A8
		public Vector4Parameter boxPosition1; // 0x1B0
		public Vector4Parameter boxPosition2; // 0x1B8
		public Vector4Parameter boxPosition3; // 0x1C0
		public ClampedFloatParameter ignorePostExposure; // 0x1C8
	
		// Constructors
		public HGScanLine() {} // 0x000000018402DA50-0x000000018402E7C0
		// HGScanLine()
		void HG::Rendering::Runtime::HGScanLine::HGScanLine(HGScanLine *this, MethodInfo *method)
		{
		  BoolParameter *v3; // rax
		  HGRuntimeGrassQuery_Node *v4; // rdx
		  __int64 v5; // rcx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  __int64 v8; // rax
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  __int64 v11; // rax
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  MethodInfo *v14; // rdx
		  Quaternion v15; // xmm6
		  __int64 v16; // rax
		  HGRuntimeGrassQuery_Node *v17; // r8
		  Int32__Array **v18; // r9
		  __int64 v19; // rax
		  HGRuntimeGrassQuery_Node *v20; // r8
		  Int32__Array **v21; // r9
		  BoolParameter *v22; // rax
		  HGRuntimeGrassQuery_Node *v23; // r8
		  Int32__Array **v24; // r9
		  Texture2DParameter *v25; // rax
		  Texture2DParameter *v26; // rdi
		  HGRuntimeGrassQuery_Node *v27; // rdx
		  HGRuntimeGrassQuery_Node *v28; // r8
		  Int32__Array **v29; // r9
		  __int64 v30; // rax
		  HGRuntimeGrassQuery_Node *v31; // r8
		  Int32__Array **v32; // r9
		  __int64 v33; // rax
		  HGRuntimeGrassQuery_Node *v34; // r8
		  Int32__Array **v35; // r9
		  __int64 v36; // rax
		  HGRuntimeGrassQuery_Node *v37; // r8
		  Int32__Array **v38; // r9
		  __int64 v39; // rax
		  HGRuntimeGrassQuery_Node *v40; // r8
		  Int32__Array **v41; // r9
		  __int64 v42; // rax
		  HGRuntimeGrassQuery_Node *v43; // r8
		  Int32__Array **v44; // r9
		  __int64 v45; // rax
		  HGRuntimeGrassQuery_Node *v46; // r8
		  Int32__Array **v47; // r9
		  __int64 v48; // rax
		  HGRuntimeGrassQuery_Node *v49; // r8
		  Int32__Array **v50; // r9
		  __int64 v51; // rax
		  HGRuntimeGrassQuery_Node *v52; // r8
		  Int32__Array **v53; // r9
		  __int64 v54; // rax
		  HGRuntimeGrassQuery_Node *v55; // r8
		  Int32__Array **v56; // r9
		  __int64 v57; // rax
		  HGRuntimeGrassQuery_Node *v58; // r8
		  Int32__Array **v59; // r9
		  __int64 v60; // rax
		  HGRuntimeGrassQuery_Node *v61; // r8
		  Int32__Array **v62; // r9
		  __int64 v63; // rax
		  HGRuntimeGrassQuery_Node *v64; // r8
		  Int32__Array **v65; // r9
		  __int64 v66; // rax
		  HGRuntimeGrassQuery_Node *v67; // r8
		  Int32__Array **v68; // r9
		  __int64 v69; // rax
		  HGRuntimeGrassQuery_Node *v70; // r8
		  Int32__Array **v71; // r9
		  __int64 v72; // rax
		  HGRuntimeGrassQuery_Node *v73; // r8
		  Int32__Array **v74; // r9
		  __int64 v75; // rax
		  HGRuntimeGrassQuery_Node *v76; // r8
		  Int32__Array **v77; // r9
		  __int64 v78; // rax
		  HGRuntimeGrassQuery_Node *v79; // r8
		  Int32__Array **v80; // r9
		  __int64 v81; // rax
		  HGRuntimeGrassQuery_Node *v82; // r8
		  Int32__Array **v83; // r9
		  __int64 v84; // rax
		  HGRuntimeGrassQuery_Node *v85; // r8
		  Int32__Array **v86; // r9
		  __int64 v87; // rax
		  HGRuntimeGrassQuery_Node *v88; // r8
		  Int32__Array **v89; // r9
		  __int64 v90; // rax
		  HGRuntimeGrassQuery_Node *v91; // r8
		  Int32__Array **v92; // r9
		  __int64 v93; // rax
		  HGRuntimeGrassQuery_Node *v94; // r8
		  Int32__Array **v95; // r9
		  __int64 v96; // rax
		  HGRuntimeGrassQuery_Node *v97; // r8
		  Int32__Array **v98; // r9
		  __int64 v99; // rax
		  HGRuntimeGrassQuery_Node *v100; // r8
		  Int32__Array **v101; // r9
		  __int64 v102; // rax
		  HGRuntimeGrassQuery_Node *v103; // r8
		  Int32__Array **v104; // r9
		  __int64 v105; // rax
		  HGRuntimeGrassQuery_Node *v106; // r8
		  Int32__Array **v107; // r9
		  __int64 v108; // rax
		  HGRuntimeGrassQuery_Node *v109; // r8
		  Int32__Array **v110; // r9
		  __int64 v111; // rax
		  HGRuntimeGrassQuery_Node *v112; // r8
		  Int32__Array **v113; // r9
		  __int64 v114; // rax
		  HGRuntimeGrassQuery_Node *v115; // r8
		  Int32__Array **v116; // r9
		  __int64 v117; // rax
		  HGRuntimeGrassQuery_Node *v118; // r8
		  Int32__Array **v119; // r9
		  __int64 v120; // rax
		  HGRuntimeGrassQuery_Node *v121; // r8
		  Int32__Array **v122; // r9
		  __int64 v123; // rax
		  HGRuntimeGrassQuery_Node *v124; // r8
		  Int32__Array **v125; // r9
		  __int64 v126; // rax
		  HGRuntimeGrassQuery_Node *v127; // r8
		  Int32__Array **v128; // r9
		  __int64 v129; // rax
		  HGRuntimeGrassQuery_Node *v130; // r8
		  Int32__Array **v131; // r9
		  __int64 v132; // rax
		  HGRuntimeGrassQuery_Node *v133; // r8
		  Int32__Array **v134; // r9
		  __int64 v135; // rax
		  HGRuntimeGrassQuery_Node *v136; // r8
		  Int32__Array **v137; // r9
		  __int64 v138; // rax
		  HGRuntimeGrassQuery_Node *v139; // r8
		  Int32__Array **v140; // r9
		  __int64 v141; // rax
		  HGRuntimeGrassQuery_Node *v142; // r8
		  Int32__Array **v143; // r9
		  __int64 v144; // rax
		  HGRuntimeGrassQuery_Node *v145; // r8
		  Int32__Array **v146; // r9
		  MethodInfo *v147; // rdx
		  Vector4 v148; // xmm6
		  __int64 v149; // rax
		  HGRuntimeGrassQuery_Node *v150; // r8
		  Int32__Array **v151; // r9
		  MethodInfo *v152; // rdx
		  Vector4 v153; // xmm6
		  __int64 v154; // rax
		  HGRuntimeGrassQuery_Node *v155; // r8
		  Int32__Array **v156; // r9
		  __int64 v157; // rax
		  HGRuntimeGrassQuery_Node *v158; // r8
		  Int32__Array **v159; // r9
		  __int64 v160; // rax
		  HGRuntimeGrassQuery_Node *v161; // r8
		  Int32__Array **v162; // r9
		  __int64 v163; // rax
		  HGRuntimeGrassQuery_Node *v164; // r8
		  Int32__Array **v165; // r9
		  __int64 v166; // rax
		  HGRuntimeGrassQuery_Node *v167; // r8
		  Int32__Array **v168; // r9
		  Quaternion v169; // [rsp+20h] [rbp-28h] BYREF
		
		  v3 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v3 )
		    goto LABEL_54;
		  v3->fields._.m_Value = 0;
		  v3->fields._._.overrideState = 0;
		  this->fields.enabled = v3;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.enabled, v4, v6, v7, *(MethodInfo **)&v169.x);
		  v8 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
		  if ( !v8 )
		    goto LABEL_54;
		  *(_BYTE *)(v8 + 16) = 0;
		  *(_OWORD *)(v8 + 24) = 0LL;
		  this->fields.centerPos = (Vector4Parameter *)v8;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.centerPos, v4, v9, v10, *(MethodInfo **)&v169.x);
		  v11 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v11 )
		    goto LABEL_54;
		  *(_DWORD *)(v11 + 36) = 1112014848;
		  *(_DWORD *)(v11 + 24) = 0;
		  *(_BYTE *)(v11 + 16) = 0;
		  *(_DWORD *)(v11 + 32) = 0;
		  *(_DWORD *)(v11 + 40) = 1065353216;
		  this->fields.progress = (ClampedFloatParameter *)v11;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.progress, v4, v12, v13, *(MethodInfo **)&v169.x);
		  v15 = *UnityEngine::Quaternion::get_identity(&v169, v14);
		  v16 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v16 )
		    goto LABEL_54;
		  *(Quaternion *)(v16 + 24) = v15;
		  *(_WORD *)(v16 + 40) = 0;
		  *(_BYTE *)(v16 + 42) = 1;
		  *(_BYTE *)(v16 + 16) = 0;
		  this->fields.color = (ColorParameter *)v16;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.color, v4, v17, v18, *(MethodInfo **)&v169.x);
		  v19 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v19 )
		    goto LABEL_54;
		  *(_DWORD *)(v19 + 24) = 1075838976;
		  *(_BYTE *)(v19 + 16) = 0;
		  *(_DWORD *)(v19 + 32) = 1036831949;
		  *(_DWORD *)(v19 + 36) = 1084227584;
		  *(_DWORD *)(v19 + 40) = 1065353216;
		  this->fields.angleBlendFallOff = (ClampedFloatParameter *)v19;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.angleBlendFallOff, v4, v20, v21, *(MethodInfo **)&v169.x);
		  v22 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v22 )
		    goto LABEL_54;
		  v22->fields._.m_Value = 0;
		  v22->fields._._.overrideState = 0;
		  this->fields.useMaskTex = v22;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.useMaskTex, v4, v23, v24, *(MethodInfo **)&v169.x);
		  v25 = (Texture2DParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::Texture2DParameter);
		  v26 = v25;
		  if ( !v25 )
		    goto LABEL_54;
		  UnityEngine::Rendering::Texture2DParameter::Texture2DParameter(v25, 0LL, 0, 0LL);
		  this->fields.maskTex = v26;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.maskTex, v27, v28, v29, *(MethodInfo **)&v169.x);
		  v30 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
		  if ( !v30 )
		    goto LABEL_54;
		  *(_DWORD *)(v30 + 24) = 1065353216;
		  *(_DWORD *)(v30 + 28) = 1065353216;
		  *(_BYTE *)(v30 + 16) = 0;
		  this->fields.maskTexTiling = (Vector2Parameter *)v30;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.maskTexTiling, v4, v31, v32, *(MethodInfo **)&v169.x);
		  v33 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
		  if ( !v33 )
		    goto LABEL_54;
		  *(_QWORD *)(v33 + 24) = 0LL;
		  *(_BYTE *)(v33 + 16) = 0;
		  this->fields.maskTexOffset = (Vector2Parameter *)v33;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.maskTexOffset, v4, v34, v35, *(MethodInfo **)&v169.x);
		  v36 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v36 )
		    goto LABEL_54;
		  *(_DWORD *)(v36 + 24) = 1036831949;
		  *(_BYTE *)(v36 + 16) = 0;
		  *(_DWORD *)(v36 + 32) = 0;
		  *(_DWORD *)(v36 + 36) = 1101004800;
		  *(_DWORD *)(v36 + 40) = 1065353216;
		  this->fields.interval = (ClampedFloatParameter *)v36;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.interval, v4, v37, v38, *(MethodInfo **)&v169.x);
		  v39 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v39 )
		    goto LABEL_54;
		  *(_DWORD *)(v39 + 24) = 1036831949;
		  *(_BYTE *)(v39 + 16) = 0;
		  *(_DWORD *)(v39 + 32) = 0;
		  *(_DWORD *)(v39 + 36) = 1065353216;
		  *(_DWORD *)(v39 + 40) = 1065353216;
		  this->fields.width = (ClampedFloatParameter *)v39;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.width, v4, v40, v41, *(MethodInfo **)&v169.x);
		  v42 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v42 )
		    goto LABEL_54;
		  *(_DWORD *)(v42 + 24) = 1092616192;
		  *(_BYTE *)(v42 + 16) = 0;
		  *(_DWORD *)(v42 + 32) = 0;
		  *(_DWORD *)(v42 + 36) = 1120403456;
		  *(_DWORD *)(v42 + 40) = 1065353216;
		  this->fields.maxDistance = (ClampedFloatParameter *)v42;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.maxDistance, v4, v43, v44, *(MethodInfo **)&v169.x);
		  v45 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v45 )
		    goto LABEL_54;
		  *(_DWORD *)(v45 + 24) = 0;
		  *(_BYTE *)(v45 + 16) = 0;
		  *(_DWORD *)(v45 + 32) = 0;
		  *(_DWORD *)(v45 + 36) = 1101004800;
		  *(_DWORD *)(v45 + 40) = 1065353216;
		  this->fields.minDistance = (ClampedFloatParameter *)v45;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.minDistance, v4, v46, v47, *(MethodInfo **)&v169.x);
		  v48 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v48 )
		    goto LABEL_54;
		  *(_DWORD *)(v48 + 24) = 1092616192;
		  *(_BYTE *)(v48 + 16) = 0;
		  *(_DWORD *)(v48 + 32) = 1065353216;
		  *(_DWORD *)(v48 + 36) = 1112014848;
		  *(_DWORD *)(v48 + 40) = 1065353216;
		  this->fields.smoothness = (ClampedFloatParameter *)v48;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.smoothness, v4, v49, v50, *(MethodInfo **)&v169.x);
		  v51 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v51 )
		    goto LABEL_54;
		  *(_DWORD *)(v51 + 24) = 1092616192;
		  *(_BYTE *)(v51 + 16) = 0;
		  *(_DWORD *)(v51 + 32) = 1084227584;
		  *(_DWORD *)(v51 + 36) = 1128792064;
		  *(_DWORD *)(v51 + 40) = 1065353216;
		  this->fields.maxFade = (ClampedFloatParameter *)v51;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.maxFade, v4, v52, v53, *(MethodInfo **)&v169.x);
		  v54 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v54 )
		    goto LABEL_54;
		  *(_DWORD *)(v54 + 24) = 1065353216;
		  *(_BYTE *)(v54 + 16) = 0;
		  *(_DWORD *)(v54 + 32) = 0;
		  *(_DWORD *)(v54 + 36) = 1084227584;
		  *(_DWORD *)(v54 + 40) = 1065353216;
		  this->fields.distortScale = (ClampedFloatParameter *)v54;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.distortScale, v4, v55, v56, *(MethodInfo **)&v169.x);
		  v57 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v57 )
		    goto LABEL_54;
		  *(_DWORD *)(v57 + 24) = 1065353216;
		  *(_BYTE *)(v57 + 16) = 0;
		  *(_DWORD *)(v57 + 32) = 0x80000000;
		  *(_DWORD *)(v57 + 36) = 1084227584;
		  *(_DWORD *)(v57 + 40) = 1065353216;
		  this->fields.charDistortScale = (ClampedFloatParameter *)v57;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.charDistortScale, v4, v58, v59, *(MethodInfo **)&v169.x);
		  v60 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v60 )
		    goto LABEL_54;
		  *(_DWORD *)(v60 + 24) = 1065353216;
		  *(_BYTE *)(v60 + 16) = 0;
		  *(_DWORD *)(v60 + 32) = -1063256064;
		  *(_DWORD *)(v60 + 36) = 1084227584;
		  *(_DWORD *)(v60 + 40) = 1065353216;
		  this->fields.distortIntensity = (ClampedFloatParameter *)v60;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.distortIntensity, v4, v61, v62, *(MethodInfo **)&v169.x);
		  v63 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v63 )
		    goto LABEL_54;
		  *(_DWORD *)(v63 + 24) = 0;
		  *(_BYTE *)(v63 + 16) = 0;
		  *(_DWORD *)(v63 + 32) = 0;
		  *(_DWORD *)(v63 + 36) = 1092616192;
		  *(_DWORD *)(v63 + 40) = 1065353216;
		  this->fields.charBrightIntensity = (ClampedFloatParameter *)v63;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.charBrightIntensity, v4, v64, v65, *(MethodInfo **)&v169.x);
		  v66 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v66 )
		    goto LABEL_54;
		  *(_DWORD *)(v66 + 24) = 1065353216;
		  *(_BYTE *)(v66 + 16) = 0;
		  *(_DWORD *)(v66 + 32) = -1063256064;
		  *(_DWORD *)(v66 + 36) = 1084227584;
		  *(_DWORD *)(v66 + 40) = 1065353216;
		  this->fields.charDistortIntensity = (ClampedFloatParameter *)v66;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.charDistortIntensity, v4, v67, v68, *(MethodInfo **)&v169.x);
		  v69 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v69 )
		    goto LABEL_54;
		  *(_DWORD *)(v69 + 24) = 1065353216;
		  *(_BYTE *)(v69 + 16) = 0;
		  *(_DWORD *)(v69 + 32) = 0;
		  *(_DWORD *)(v69 + 36) = 0x40000000;
		  *(_DWORD *)(v69 + 40) = 1065353216;
		  this->fields.charDistortOnEdge = (ClampedFloatParameter *)v69;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.charDistortOnEdge, v4, v70, v71, *(MethodInfo **)&v169.x);
		  v72 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v72 )
		    goto LABEL_54;
		  *(_DWORD *)(v72 + 24) = 1082130432;
		  *(_BYTE *)(v72 + 16) = 0;
		  *(_DWORD *)(v72 + 32) = 0;
		  *(_DWORD *)(v72 + 36) = 1092616192;
		  *(_DWORD *)(v72 + 40) = 1065353216;
		  this->fields.charDistortOuter = (ClampedFloatParameter *)v72;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.charDistortOuter, v4, v73, v74, *(MethodInfo **)&v169.x);
		  v75 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v75 )
		    goto LABEL_54;
		  *(_DWORD *)(v75 + 24) = 0;
		  *(_BYTE *)(v75 + 16) = 0;
		  *(_DWORD *)(v75 + 32) = 0;
		  *(_DWORD *)(v75 + 36) = 1084227584;
		  *(_DWORD *)(v75 + 40) = 1065353216;
		  this->fields.distortSpeed = (ClampedFloatParameter *)v75;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.distortSpeed, v4, v76, v77, *(MethodInfo **)&v169.x);
		  v78 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v78 )
		    goto LABEL_54;
		  *(_DWORD *)(v78 + 24) = 0;
		  *(_BYTE *)(v78 + 16) = 0;
		  *(_DWORD *)(v78 + 32) = 0;
		  *(_DWORD *)(v78 + 36) = 1092616192;
		  *(_DWORD *)(v78 + 40) = 1065353216;
		  this->fields.charDistortSpeed = (ClampedFloatParameter *)v78;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.charDistortSpeed, v4, v79, v80, *(MethodInfo **)&v169.x);
		  v81 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v81 )
		    goto LABEL_54;
		  *(_DWORD *)(v81 + 24) = 0;
		  *(_BYTE *)(v81 + 16) = 0;
		  *(_DWORD *)(v81 + 32) = 0;
		  *(_DWORD *)(v81 + 36) = 1065353216;
		  *(_DWORD *)(v81 + 40) = 1065353216;
		  this->fields.highlightFading = (ClampedFloatParameter *)v81;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.highlightFading, v4, v82, v83, *(MethodInfo **)&v169.x);
		  v84 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v84 )
		    goto LABEL_54;
		  *(_DWORD *)(v84 + 24) = 1075838976;
		  *(_BYTE *)(v84 + 16) = 0;
		  *(_DWORD *)(v84 + 32) = 1045220557;
		  *(_DWORD *)(v84 + 36) = 1097859072;
		  *(_DWORD *)(v84 + 40) = 1065353216;
		  this->fields.highlightWidth = (ClampedFloatParameter *)v84;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.highlightWidth, v4, v85, v86, *(MethodInfo **)&v169.x);
		  v87 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v87 )
		    goto LABEL_54;
		  *(_DWORD *)(v87 + 24) = 1069547520;
		  *(_BYTE *)(v87 + 16) = 0;
		  *(_DWORD *)(v87 + 32) = 0;
		  *(_DWORD *)(v87 + 36) = 1082130432;
		  *(_DWORD *)(v87 + 40) = 1065353216;
		  this->fields.highlightThickness = (ClampedFloatParameter *)v87;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.highlightThickness, v4, v88, v89, *(MethodInfo **)&v169.x);
		  v90 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v90 )
		    goto LABEL_54;
		  *(_DWORD *)(v90 + 24) = 1094713344;
		  *(_BYTE *)(v90 + 16) = 0;
		  *(_DWORD *)(v90 + 32) = 1008981770;
		  *(_DWORD *)(v90 + 36) = 1101004800;
		  *(_DWORD *)(v90 + 40) = 1065353216;
		  this->fields.maxDetectionDistance = (ClampedFloatParameter *)v90;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.maxDetectionDistance, v4, v91, v92, *(MethodInfo **)&v169.x);
		  v93 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v93 )
		    goto LABEL_54;
		  *(_DWORD *)(v93 + 24) = 1101004800;
		  *(_BYTE *)(v93 + 16) = 0;
		  *(_DWORD *)(v93 + 32) = 1065353216;
		  *(_DWORD *)(v93 + 36) = 1140457472;
		  *(_DWORD *)(v93 + 40) = 1065353216;
		  this->fields.boxDistMin = (ClampedFloatParameter *)v93;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.boxDistMin, v4, v94, v95, *(MethodInfo **)&v169.x);
		  v96 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v96 )
		    goto LABEL_54;
		  *(_DWORD *)(v96 + 24) = 1112014848;
		  *(_BYTE *)(v96 + 16) = 0;
		  *(_DWORD *)(v96 + 32) = 1065353216;
		  *(_DWORD *)(v96 + 36) = 1140457472;
		  *(_DWORD *)(v96 + 40) = 1065353216;
		  this->fields.boxDistMid = (ClampedFloatParameter *)v96;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.boxDistMid, v4, v97, v98, *(MethodInfo **)&v169.x);
		  v99 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v99 )
		    goto LABEL_54;
		  *(_DWORD *)(v99 + 24) = 1117782016;
		  *(_BYTE *)(v99 + 16) = 0;
		  *(_DWORD *)(v99 + 32) = 1065353216;
		  *(_DWORD *)(v99 + 36) = 1140457472;
		  *(_DWORD *)(v99 + 40) = 1065353216;
		  this->fields.boxDistMax = (ClampedFloatParameter *)v99;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.boxDistMax, v4, v100, v101, *(MethodInfo **)&v169.x);
		  v102 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v102 )
		    goto LABEL_54;
		  *(_DWORD *)(v102 + 24) = 1065353216;
		  *(_BYTE *)(v102 + 16) = 0;
		  *(_DWORD *)(v102 + 32) = 0;
		  *(_DWORD *)(v102 + 36) = 1065353216;
		  *(_DWORD *)(v102 + 40) = 1065353216;
		  this->fields.headHeight = (ClampedFloatParameter *)v102;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.headHeight, v4, v103, v104, *(MethodInfo **)&v169.x);
		  v105 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v105 )
		    goto LABEL_54;
		  *(_DWORD *)(v105 + 24) = 1065353216;
		  *(_BYTE *)(v105 + 16) = 0;
		  *(_DWORD *)(v105 + 32) = 0;
		  *(_DWORD *)(v105 + 36) = 1065353216;
		  *(_DWORD *)(v105 + 40) = 1065353216;
		  this->fields.tailHeight = (ClampedFloatParameter *)v105;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.tailHeight, v4, v106, v107, *(MethodInfo **)&v169.x);
		  v108 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v108 )
		    goto LABEL_54;
		  *(_DWORD *)(v108 + 24) = 1065353216;
		  *(_BYTE *)(v108 + 16) = 0;
		  *(_DWORD *)(v108 + 32) = 0;
		  *(_DWORD *)(v108 + 36) = 1069547520;
		  *(_DWORD *)(v108 + 40) = 1065353216;
		  this->fields.headAlpha = (ClampedFloatParameter *)v108;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.headAlpha, v4, v109, v110, *(MethodInfo **)&v169.x);
		  v111 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v111 )
		    goto LABEL_54;
		  *(_DWORD *)(v111 + 24) = 1065353216;
		  *(_BYTE *)(v111 + 16) = 0;
		  *(_DWORD *)(v111 + 32) = 0;
		  *(_DWORD *)(v111 + 36) = 1069547520;
		  *(_DWORD *)(v111 + 40) = 1065353216;
		  this->fields.tailAlpha = (ClampedFloatParameter *)v111;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.tailAlpha, v4, v112, v113, *(MethodInfo **)&v169.x);
		  v114 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v114 )
		    goto LABEL_54;
		  *(_DWORD *)(v114 + 24) = 0;
		  *(_BYTE *)(v114 + 16) = 0;
		  *(_DWORD *)(v114 + 32) = -1063256064;
		  *(_DWORD *)(v114 + 36) = 1084227584;
		  *(_DWORD *)(v114 + 40) = 1065353216;
		  this->fields.flowingSpeed = (ClampedFloatParameter *)v114;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.flowingSpeed, v4, v115, v116, *(MethodInfo **)&v169.x);
		  v117 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v117 )
		    goto LABEL_54;
		  *(_DWORD *)(v117 + 24) = 0;
		  *(_BYTE *)(v117 + 16) = 0;
		  *(_DWORD *)(v117 + 32) = 0;
		  *(_DWORD *)(v117 + 36) = 1065353216;
		  *(_DWORD *)(v117 + 40) = 1065353216;
		  this->fields.flowingStrength = (ClampedFloatParameter *)v117;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.flowingStrength, v4, v118, v119, *(MethodInfo **)&v169.x);
		  v120 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v120 )
		    goto LABEL_54;
		  *(_DWORD *)(v120 + 24) = 1065353216;
		  *(_BYTE *)(v120 + 16) = 0;
		  *(_DWORD *)(v120 + 32) = 0;
		  *(_DWORD *)(v120 + 36) = 1065353216;
		  *(_DWORD *)(v120 + 40) = 1065353216;
		  this->fields.nearHighlight = (ClampedFloatParameter *)v120;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.nearHighlight, v4, v121, v122, *(MethodInfo **)&v169.x);
		  v123 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v123 )
		    goto LABEL_54;
		  *(_DWORD *)(v123 + 24) = 1065353216;
		  *(_BYTE *)(v123 + 16) = 0;
		  *(_DWORD *)(v123 + 32) = 0;
		  *(_DWORD *)(v123 + 36) = 1065353216;
		  *(_DWORD *)(v123 + 40) = 1065353216;
		  this->fields.farHighlight = (ClampedFloatParameter *)v123;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.farHighlight, v4, v124, v125, *(MethodInfo **)&v169.x);
		  v126 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v126 )
		    goto LABEL_54;
		  *(_DWORD *)(v126 + 24) = 1065353216;
		  *(_BYTE *)(v126 + 16) = 0;
		  *(_DWORD *)(v126 + 32) = 1065353216;
		  *(_DWORD *)(v126 + 36) = 1092616192;
		  *(_DWORD *)(v126 + 40) = 1065353216;
		  this->fields.midBloom = (ClampedFloatParameter *)v126;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.midBloom, v4, v127, v128, *(MethodInfo **)&v169.x);
		  v129 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v129 )
		    goto LABEL_54;
		  *(_DWORD *)(v129 + 24) = 1065353216;
		  *(_BYTE *)(v129 + 16) = 0;
		  *(_DWORD *)(v129 + 32) = 1065353216;
		  *(_DWORD *)(v129 + 36) = 1092616192;
		  *(_DWORD *)(v129 + 40) = 1065353216;
		  this->fields.maxBloom = (ClampedFloatParameter *)v129;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.maxBloom, v4, v130, v131, *(MethodInfo **)&v169.x);
		  v132 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v132 )
		    goto LABEL_54;
		  *(_DWORD *)(v132 + 24) = 1094713344;
		  *(_BYTE *)(v132 + 16) = 0;
		  *(_DWORD *)(v132 + 32) = 1008981770;
		  *(_DWORD *)(v132 + 36) = 1101004800;
		  *(_DWORD *)(v132 + 40) = 1065353216;
		  this->fields.maxDetectionDistanceHL = (ClampedFloatParameter *)v132;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields.maxDetectionDistanceHL,
		    v4,
		    v133,
		    v134,
		    *(MethodInfo **)&v169.x);
		  v135 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v135 )
		    goto LABEL_54;
		  *(_DWORD *)(v135 + 24) = 1055286886;
		  *(_BYTE *)(v135 + 16) = 0;
		  *(_DWORD *)(v135 + 32) = 1008981770;
		  *(_DWORD *)(v135 + 36) = 1065353216;
		  *(_DWORD *)(v135 + 40) = 1065353216;
		  this->fields.minHeight = (ClampedFloatParameter *)v135;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.minHeight, v4, v136, v137, *(MethodInfo **)&v169.x);
		  v138 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v138 )
		    goto LABEL_54;
		  *(_DWORD *)(v138 + 24) = 1059481190;
		  *(_BYTE *)(v138 + 16) = 0;
		  *(_DWORD *)(v138 + 32) = 1008981770;
		  *(_DWORD *)(v138 + 36) = 1065353216;
		  *(_DWORD *)(v138 + 40) = 1065353216;
		  this->fields.midHeight = (ClampedFloatParameter *)v138;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.midHeight, v4, v139, v140, *(MethodInfo **)&v169.x);
		  v141 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v141 )
		    goto LABEL_54;
		  *(_DWORD *)(v141 + 24) = 1064514355;
		  *(_BYTE *)(v141 + 16) = 0;
		  *(_DWORD *)(v141 + 32) = 1008981770;
		  *(_DWORD *)(v141 + 36) = 1065353216;
		  *(_DWORD *)(v141 + 40) = 1065353216;
		  this->fields.maxHeight = (ClampedFloatParameter *)v141;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.maxHeight, v4, v142, v143, *(MethodInfo **)&v169.x);
		  v144 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v144 )
		    goto LABEL_54;
		  *(_DWORD *)(v144 + 24) = 1065353216;
		  *(_BYTE *)(v144 + 16) = 0;
		  *(_DWORD *)(v144 + 32) = 1065353216;
		  *(_DWORD *)(v144 + 36) = 1084227584;
		  *(_DWORD *)(v144 + 40) = 1065353216;
		  this->fields.meshHeight = (ClampedFloatParameter *)v144;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.meshHeight, v4, v145, v146, *(MethodInfo **)&v169.x);
		  v148 = *UnityEngine::Vector4::get_one((Vector4 *)&v169, v147);
		  v149 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v149 )
		    goto LABEL_54;
		  *(Vector4 *)(v149 + 24) = v148;
		  *(_WORD *)(v149 + 40) = 0;
		  *(_BYTE *)(v149 + 42) = 1;
		  *(_BYTE *)(v149 + 16) = 0;
		  this->fields.colorHighlight = (ColorParameter *)v149;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.colorHighlight, v4, v150, v151, *(MethodInfo **)&v169.x);
		  v153 = *UnityEngine::Vector4::get_one((Vector4 *)&v169, v152);
		  v154 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v154 )
		    goto LABEL_54;
		  *(Vector4 *)(v154 + 24) = v153;
		  *(_WORD *)(v154 + 40) = 0;
		  *(_BYTE *)(v154 + 42) = 1;
		  *(_BYTE *)(v154 + 16) = 0;
		  this->fields.colorHighlightBeam = (ColorParameter *)v154;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.colorHighlightBeam, v4, v155, v156, *(MethodInfo **)&v169.x);
		  v157 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
		  if ( !v157 )
		    goto LABEL_54;
		  *(_BYTE *)(v157 + 16) = 0;
		  *(_OWORD *)(v157 + 24) = 0LL;
		  this->fields.boxPosition1 = (Vector4Parameter *)v157;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.boxPosition1, v4, v158, v159, *(MethodInfo **)&v169.x);
		  v160 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
		  if ( !v160 )
		    goto LABEL_54;
		  *(_BYTE *)(v160 + 16) = 0;
		  *(_OWORD *)(v160 + 24) = 0LL;
		  this->fields.boxPosition2 = (Vector4Parameter *)v160;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.boxPosition2, v4, v161, v162, *(MethodInfo **)&v169.x);
		  v163 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
		  if ( !v163
		    || (*(_BYTE *)(v163 + 16) = 0,
		        *(_OWORD *)(v163 + 24) = 0LL,
		        this->fields.boxPosition3 = (Vector4Parameter *)v163,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.boxPosition3, v4, v164, v165, *(MethodInfo **)&v169.x),
		        (v166 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter)) == 0) )
		  {
		LABEL_54:
		    sub_1800D8260(v5, v4);
		  }
		  *(_DWORD *)(v166 + 24) = 0;
		  *(_BYTE *)(v166 + 16) = 0;
		  *(_DWORD *)(v166 + 32) = 0;
		  *(_DWORD *)(v166 + 36) = 1065353216;
		  *(_DWORD *)(v166 + 40) = 1065353216;
		  this->fields.ignorePostExposure = (ClampedFloatParameter *)v166;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.ignorePostExposure, v4, v167, v168, *(MethodInfo **)&v169.x);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000183A160A0-0x0000000183A161B0
		// Boolean IsActive()
		bool HG::Rendering::Runtime::HGScanLine::IsActive(HGScanLine *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ClampedFloatParameter *wrapperArray; // rdx
		  BoolParameter *enabled; // rbx
		  bool (*v6)(RuntimeType *, MethodInfo *); // r8
		  Il2CppMethodPointer methodPtr; // rdx
		  bool result; // al
		  VolumeParameter__Fields v9; // rax
		  char v10; // al
		  VolumeParameter__Fields v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  double v13; // xmm0_8
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (ClampedFloatParameter *)v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_23;
		  if ( SLODWORD(wrapperArray->fields._._.m_Value) > 2562 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( !v3 )
		      goto LABEL_23;
		    if ( LODWORD(v3->_0.namespaze) <= 0xA02 )
		      sub_1800D2AB0(v3, wrapperArray);
		    if ( *(_QWORD *)&v3[54]._1.cctor_finished_or_no_cctor )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2562, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                 (ILFixDynamicMethodWrapper_20 *)Patch,
		                 (Object *)this,
		                 0LL);
		      goto LABEL_23;
		    }
		  }
		  enabled = this->fields.enabled;
		  if ( !enabled )
		    goto LABEL_23;
		  sub_1800049A0(enabled->klass);
		  v6 = (bool (*)(RuntimeType *, MethodInfo *))enabled->klass->vtable.get_value.method;
		  methodPtr = enabled->klass->vtable.set_value.methodPtr;
		  if ( v6 == System::RuntimeType::HasElementTypeImpl )
		  {
		    v9 = enabled->fields._._;
		    if ( (*(_DWORD *)(*(_QWORD *)&v9 + 8LL) & 0x20000000) != 0 )
		      goto LABEL_22;
		    v10 = *(_BYTE *)(*(_QWORD *)&v9 + 10LL);
		    if ( v10 == 29 || v10 == 16 || v10 == 20 || v10 == 15 )
		      goto LABEL_22;
		LABEL_17:
		    result = 0;
		    goto LABEL_10;
		  }
		  if ( v6 == System::RuntimeType::get_IsGenericType )
		  {
		    result = System::RuntimeTypeHandle::HasInstantiation(enabled, methodPtr);
		    goto LABEL_10;
		  }
		  if ( v6 != System::RuntimeType::get_IsGenericParameter )
		  {
		    result = ((__int64 (__fastcall *)(BoolParameter *, Il2CppMethodPointer))v6)(enabled, methodPtr);
		    goto LABEL_10;
		  }
		  v11 = enabled->fields._._;
		  if ( (*(_DWORD *)(*(_QWORD *)&v11 + 8LL) & 0x20000000) != 0
		    || *(_BYTE *)(*(_QWORD *)&v11 + 10LL) != 19 && *(_BYTE *)(*(_QWORD *)&v11 + 10LL) != 30 )
		  {
		    goto LABEL_17;
		  }
		LABEL_22:
		  result = 1;
		LABEL_10:
		  if ( result )
		  {
		    wrapperArray = this->fields.interval;
		    if ( wrapperArray )
		    {
		      v13 = sub_1800057D0(10LL, wrapperArray);
		      return *(float *)&v13 > 0.0;
		    }
		LABEL_23:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  return result;
		}
		
	}
}
