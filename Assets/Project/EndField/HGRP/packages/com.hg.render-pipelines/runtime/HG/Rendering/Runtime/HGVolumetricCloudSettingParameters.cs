using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGVolumetricCloudSettingParameters // TypeDefIndex: 38602
	{
		// Fields
		public const string FEATURE_NAME = "VolumetricCloud"; // Metadata: 0x02303F32
		public readonly SettingParameter<bool> enableDownRes; // 0x10
		public readonly SettingParameter<float> downResRatio; // 0x18
		public readonly SettingParameter<EDownResFilter> downResFilter; // 0x20
		public readonly SettingParameter<bool> enableFraming; // 0x28
		public readonly SettingParameter<EFramingQuality> framingLevel; // 0x30
		public readonly SettingParameter<float> framingComposeRatio; // 0x38
		public readonly SettingParameter<bool> enableFramingCubicSample; // 0x40
		public readonly SettingParameter<bool> enableFramingMotionVector; // 0x48
		public readonly SettingParameter<bool> enableFramingDepthOpt; // 0x50
		public readonly SettingParameter<bool> enableFramingColorAABB; // 0x58
		public readonly SettingParameter<bool> enableFramingNeighborAvg; // 0x60
		public readonly SettingParameter<bool> enableTAA; // 0x68
		public readonly SettingParameter<bool> enableTAACubicSample; // 0x70
		public readonly SettingParameter<bool> enableTAAMotionVector; // 0x78
		public readonly SettingParameter<bool> enableTAADepthOpt; // 0x80
		public readonly SettingParameter<bool> enableTAAColorAABB; // 0x88
		public readonly SettingParameter<bool> enableTAANeighborAvg; // 0x90
		public readonly SettingParameter<float> invalidDepthBlendRatio; // 0x98
		public readonly SettingParameter<float> marchStepScale; // 0xA0
		public readonly SettingParameter<float> godRayStepScale; // 0xA8
		public readonly SettingParameter<float> emptySkipSizeScale; // 0xB0
		public readonly SettingParameter<float> dynamicStepRange; // 0xB8
		public readonly SettingParameter<float> dynamicStepScale; // 0xC0
		public readonly SettingParameter<bool> enableFarCloud; // 0xC8
		public readonly SettingParameter<int> panoramicSizeX; // 0xD0
		public readonly SettingParameter<int> panoramicSizeY; // 0xD8
		public readonly SettingParameter<int> octahedronSize; // 0xE0
		public readonly SettingParameter<float> octahedronHeightScale; // 0xE8
		public readonly SettingParameter<bool> octahedronEnableSlicing; // 0xF0
		public readonly SettingParameter<int> octahedronSlicingCountX; // 0xF8
		public readonly SettingParameter<int> octahedronSlicingCountY; // 0x100
		public readonly SettingParameter<int> semicircularSize; // 0x108
		public readonly SettingParameter<float> semicircularZScale; // 0x110
		public readonly SettingParameter<EFarCloudFramingQuality> farCloudFramingLevel; // 0x118
		public readonly SettingParameter<float> farCloudFramingComposeRatio; // 0x120
		public readonly SettingParameter<bool> farCloudFramingCubicSample; // 0x128
		public readonly SettingParameter<bool> farCloudEnableTAA; // 0x130
		public readonly SettingParameter<float> farCloudTAABlendRatio; // 0x138
		public readonly SettingParameter<bool> farCloudTAACubicSample; // 0x140
		public readonly SettingParameter<float> farCloudMarchStepScale; // 0x148
		public readonly SettingParameter<float> farCloudFullUpdateMarchStepScale; // 0x150
		public readonly SettingParameter<float> farCloudEmptySkipSizeScale; // 0x158
	
		// Constructors
		public HGVolumetricCloudSettingParameters() {} // 0x00000001836588D0-0x00000001836590A0
		// HGVolumetricCloudSettingParameters()
		void HG::Rendering::Runtime::HGVolumetricCloudSettingParameters::HGVolumetricCloudSettingParameters(
		        HGVolumetricCloudSettingParameters *this,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v3; // rdx
		  HGRuntimeGrassQuery_Node *v4; // r8
		  Int32__Array **v5; // r9
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  HGRuntimeGrassQuery_Node *v9; // rdx
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  HGRuntimeGrassQuery_Node *v12; // rdx
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  HGRuntimeGrassQuery_Node *v15; // rdx
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  HGRuntimeGrassQuery_Node *v18; // rdx
		  HGRuntimeGrassQuery_Node *v19; // r8
		  Int32__Array **v20; // r9
		  HGRuntimeGrassQuery_Node *v21; // rdx
		  HGRuntimeGrassQuery_Node *v22; // r8
		  Int32__Array **v23; // r9
		  HGRuntimeGrassQuery_Node *v24; // rdx
		  HGRuntimeGrassQuery_Node *v25; // r8
		  Int32__Array **v26; // r9
		  HGRuntimeGrassQuery_Node *v27; // rdx
		  HGRuntimeGrassQuery_Node *v28; // r8
		  Int32__Array **v29; // r9
		  HGRuntimeGrassQuery_Node *v30; // rdx
		  HGRuntimeGrassQuery_Node *v31; // r8
		  Int32__Array **v32; // r9
		  HGRuntimeGrassQuery_Node *v33; // rdx
		  HGRuntimeGrassQuery_Node *v34; // r8
		  Int32__Array **v35; // r9
		  HGRuntimeGrassQuery_Node *v36; // rdx
		  HGRuntimeGrassQuery_Node *v37; // r8
		  Int32__Array **v38; // r9
		  HGRuntimeGrassQuery_Node *v39; // rdx
		  HGRuntimeGrassQuery_Node *v40; // r8
		  Int32__Array **v41; // r9
		  HGRuntimeGrassQuery_Node *v42; // rdx
		  HGRuntimeGrassQuery_Node *v43; // r8
		  Int32__Array **v44; // r9
		  HGRuntimeGrassQuery_Node *v45; // rdx
		  HGRuntimeGrassQuery_Node *v46; // r8
		  Int32__Array **v47; // r9
		  HGRuntimeGrassQuery_Node *v48; // rdx
		  HGRuntimeGrassQuery_Node *v49; // r8
		  Int32__Array **v50; // r9
		  HGRuntimeGrassQuery_Node *v51; // rdx
		  HGRuntimeGrassQuery_Node *v52; // r8
		  Int32__Array **v53; // r9
		  HGRuntimeGrassQuery_Node *v54; // rdx
		  HGRuntimeGrassQuery_Node *v55; // r8
		  Int32__Array **v56; // r9
		  HGRuntimeGrassQuery_Node *v57; // rdx
		  HGRuntimeGrassQuery_Node *v58; // r8
		  Int32__Array **v59; // r9
		  HGRuntimeGrassQuery_Node *v60; // rdx
		  HGRuntimeGrassQuery_Node *v61; // r8
		  Int32__Array **v62; // r9
		  HGRuntimeGrassQuery_Node *v63; // rdx
		  HGRuntimeGrassQuery_Node *v64; // r8
		  Int32__Array **v65; // r9
		  HGRuntimeGrassQuery_Node *v66; // rdx
		  HGRuntimeGrassQuery_Node *v67; // r8
		  Int32__Array **v68; // r9
		  HGRuntimeGrassQuery_Node *v69; // rdx
		  HGRuntimeGrassQuery_Node *v70; // r8
		  Int32__Array **v71; // r9
		  HGRuntimeGrassQuery_Node *v72; // rdx
		  HGRuntimeGrassQuery_Node *v73; // r8
		  Int32__Array **v74; // r9
		  HGRuntimeGrassQuery_Node *v75; // rdx
		  HGRuntimeGrassQuery_Node *v76; // r8
		  Int32__Array **v77; // r9
		  HGRuntimeGrassQuery_Node *v78; // rdx
		  HGRuntimeGrassQuery_Node *v79; // r8
		  Int32__Array **v80; // r9
		  HGRuntimeGrassQuery_Node *v81; // rdx
		  HGRuntimeGrassQuery_Node *v82; // r8
		  Int32__Array **v83; // r9
		  HGRuntimeGrassQuery_Node *v84; // rdx
		  HGRuntimeGrassQuery_Node *v85; // r8
		  Int32__Array **v86; // r9
		  HGRuntimeGrassQuery_Node *v87; // rdx
		  HGRuntimeGrassQuery_Node *v88; // r8
		  Int32__Array **v89; // r9
		  HGRuntimeGrassQuery_Node *v90; // rdx
		  HGRuntimeGrassQuery_Node *v91; // r8
		  Int32__Array **v92; // r9
		  HGRuntimeGrassQuery_Node *v93; // rdx
		  HGRuntimeGrassQuery_Node *v94; // r8
		  Int32__Array **v95; // r9
		  HGRuntimeGrassQuery_Node *v96; // rdx
		  HGRuntimeGrassQuery_Node *v97; // r8
		  Int32__Array **v98; // r9
		  HGRuntimeGrassQuery_Node *v99; // rdx
		  HGRuntimeGrassQuery_Node *v100; // r8
		  Int32__Array **v101; // r9
		  HGRuntimeGrassQuery_Node *v102; // rdx
		  HGRuntimeGrassQuery_Node *v103; // r8
		  Int32__Array **v104; // r9
		  HGRuntimeGrassQuery_Node *v105; // rdx
		  HGRuntimeGrassQuery_Node *v106; // r8
		  Int32__Array **v107; // r9
		  HGRuntimeGrassQuery_Node *v108; // rdx
		  HGRuntimeGrassQuery_Node *v109; // r8
		  Int32__Array **v110; // r9
		  HGRuntimeGrassQuery_Node *v111; // rdx
		  HGRuntimeGrassQuery_Node *v112; // r8
		  Int32__Array **v113; // r9
		  HGRuntimeGrassQuery_Node *v114; // rdx
		  HGRuntimeGrassQuery_Node *v115; // r8
		  Int32__Array **v116; // r9
		  HGRuntimeGrassQuery_Node *v117; // rdx
		  HGRuntimeGrassQuery_Node *v118; // r8
		  Int32__Array **v119; // r9
		  HGRuntimeGrassQuery_Node *v120; // rdx
		  HGRuntimeGrassQuery_Node *v121; // r8
		  Int32__Array **v122; // r9
		  HGRuntimeGrassQuery_Node *v123; // rdx
		  HGRuntimeGrassQuery_Node *v124; // r8
		  Int32__Array **v125; // r9
		  HGRuntimeGrassQuery_Node *v126; // rdx
		  HGRuntimeGrassQuery_Node *v127; // r8
		  Int32__Array **v128; // r9
		  MethodInfo *v129; // [rsp+20h] [rbp-18h]
		  MethodInfo *v130; // [rsp+20h] [rbp-18h]
		  MethodInfo *v131; // [rsp+20h] [rbp-18h]
		  MethodInfo *v132; // [rsp+20h] [rbp-18h]
		  MethodInfo *v133; // [rsp+20h] [rbp-18h]
		  MethodInfo *v134; // [rsp+20h] [rbp-18h]
		  MethodInfo *v135; // [rsp+20h] [rbp-18h]
		  MethodInfo *v136; // [rsp+20h] [rbp-18h]
		  MethodInfo *v137; // [rsp+20h] [rbp-18h]
		  MethodInfo *v138; // [rsp+20h] [rbp-18h]
		  MethodInfo *v139; // [rsp+20h] [rbp-18h]
		  MethodInfo *v140; // [rsp+20h] [rbp-18h]
		  MethodInfo *v141; // [rsp+20h] [rbp-18h]
		  MethodInfo *v142; // [rsp+20h] [rbp-18h]
		  MethodInfo *v143; // [rsp+20h] [rbp-18h]
		  MethodInfo *v144; // [rsp+20h] [rbp-18h]
		  MethodInfo *v145; // [rsp+20h] [rbp-18h]
		  MethodInfo *v146; // [rsp+20h] [rbp-18h]
		  MethodInfo *v147; // [rsp+20h] [rbp-18h]
		  MethodInfo *v148; // [rsp+20h] [rbp-18h]
		  MethodInfo *v149; // [rsp+20h] [rbp-18h]
		  MethodInfo *v150; // [rsp+20h] [rbp-18h]
		  MethodInfo *v151; // [rsp+20h] [rbp-18h]
		  MethodInfo *v152; // [rsp+20h] [rbp-18h]
		  MethodInfo *v153; // [rsp+20h] [rbp-18h]
		  MethodInfo *v154; // [rsp+20h] [rbp-18h]
		  MethodInfo *v155; // [rsp+20h] [rbp-18h]
		  MethodInfo *v156; // [rsp+20h] [rbp-18h]
		  MethodInfo *v157; // [rsp+20h] [rbp-18h]
		  MethodInfo *v158; // [rsp+20h] [rbp-18h]
		  MethodInfo *v159; // [rsp+20h] [rbp-18h]
		  MethodInfo *v160; // [rsp+20h] [rbp-18h]
		  MethodInfo *v161; // [rsp+20h] [rbp-18h]
		  MethodInfo *v162; // [rsp+20h] [rbp-18h]
		  MethodInfo *v163; // [rsp+20h] [rbp-18h]
		  MethodInfo *v164; // [rsp+20h] [rbp-18h]
		  MethodInfo *v165; // [rsp+20h] [rbp-18h]
		  MethodInfo *v166; // [rsp+20h] [rbp-18h]
		  MethodInfo *v167; // [rsp+20h] [rbp-18h]
		  MethodInfo *v168; // [rsp+20h] [rbp-18h]
		  MethodInfo *v169; // [rsp+20h] [rbp-18h]
		  MethodInfo *v170; // [rsp+60h] [rbp+28h]
		
		  this->fields.enableDownRes = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                 0,
		                                 (String *)"VolumetricCloud",
		                                 (String *)"enableDownRes",
		                                 MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v3, v4, v5, v129);
		  this->fields.downResRatio = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                1.0,
		                                (String *)"VolumetricCloud",
		                                (String *)"downResRatio",
		                                MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.downResRatio, v6, v7, v8, v130);
		  this->fields.downResFilter = (SettingParameter_1_EDownResFilter_ *)HG::Rendering::Runtime::SettingParameter::Create<System::Int32Enum>(
		                                                                       (Int32Enum__Enum)1u,
		                                                                       (String *)"VolumetricCloud",
		                                                                       (String *)"downResFilter",
		                                                                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<HG::Rendering::Runtime::EDownResFilter>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.downResFilter, v9, v10, v11, v131);
		  this->fields.enableFraming = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                 0,
		                                 (String *)"VolumetricCloud",
		                                 (String *)"enableFraming",
		                                 MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.enableFraming, v12, v13, v14, v132);
		  this->fields.framingLevel = (SettingParameter_1_EFramingQuality_ *)HG::Rendering::Runtime::SettingParameter::Create<System::Int32Enum>(
		                                                                       (Int32Enum__Enum)0,
		                                                                       (String *)"VolumetricCloud",
		                                                                       (String *)"framingLevel",
		                                                                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<HG::Rendering::Runtime::EFramingQuality>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.framingLevel, v15, v16, v17, v133);
		  this->fields.framingComposeRatio = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                       0.25,
		                                       (String *)"VolumetricCloud",
		                                       (String *)"framingComposeRatio",
		                                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.framingComposeRatio, v18, v19, v20, v134);
		  this->fields.enableFramingCubicSample = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                            1,
		                                            (String *)"VolumetricCloud",
		                                            (String *)"enableFramingCubicSample",
		                                            MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.enableFramingCubicSample, v21, v22, v23, v135);
		  this->fields.enableFramingMotionVector = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                             1,
		                                             (String *)"VolumetricCloud",
		                                             (String *)"enableFramingMotionVector",
		                                             MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.enableFramingMotionVector, v24, v25, v26, v136);
		  this->fields.enableFramingDepthOpt = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                         1,
		                                         (String *)"VolumetricCloud",
		                                         (String *)"enableFramingDepthOpt",
		                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.enableFramingDepthOpt, v27, v28, v29, v137);
		  this->fields.enableFramingColorAABB = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                          1,
		                                          (String *)"VolumetricCloud",
		                                          (String *)"enableFramingColorAABB",
		                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.enableFramingColorAABB, v30, v31, v32, v138);
		  this->fields.enableFramingNeighborAvg = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                            1,
		                                            (String *)"VolumetricCloud",
		                                            (String *)"enableFramingNeighborAvg",
		                                            MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.enableFramingNeighborAvg, v33, v34, v35, v139);
		  this->fields.enableTAA = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                             1,
		                             (String *)"VolumetricCloud",
		                             (String *)"enableTAA",
		                             MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.enableTAA, v36, v37, v38, v140);
		  this->fields.enableTAACubicSample = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                        1,
		                                        (String *)"VolumetricCloud",
		                                        (String *)"enableTAACubicSample",
		                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.enableTAACubicSample, v39, v40, v41, v141);
		  this->fields.enableTAAMotionVector = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                         1,
		                                         (String *)"VolumetricCloud",
		                                         (String *)"enableTAAMotionVector",
		                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.enableTAAMotionVector, v42, v43, v44, v142);
		  this->fields.enableTAADepthOpt = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                     1,
		                                     (String *)"VolumetricCloud",
		                                     (String *)"enableTAADepthOpt",
		                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.enableTAADepthOpt, v45, v46, v47, v143);
		  this->fields.enableTAAColorAABB = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                      1,
		                                      (String *)"VolumetricCloud",
		                                      (String *)"enableTAAColorAABB",
		                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.enableTAAColorAABB, v48, v49, v50, v144);
		  this->fields.enableTAANeighborAvg = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                        1,
		                                        (String *)"VolumetricCloud",
		                                        (String *)"enableTAANeighborAvg",
		                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.enableTAANeighborAvg, v51, v52, v53, v145);
		  this->fields.invalidDepthBlendRatio = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                          1.0,
		                                          (String *)"VolumetricCloud",
		                                          (String *)"invalidDepthBlendRatio",
		                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.invalidDepthBlendRatio, v54, v55, v56, v146);
		  this->fields.marchStepScale = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                  3.0,
		                                  (String *)"VolumetricCloud",
		                                  (String *)"marchStepScale",
		                                  MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.marchStepScale, v57, v58, v59, v147);
		  this->fields.godRayStepScale = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                   2.0,
		                                   (String *)"VolumetricCloud",
		                                   (String *)"godRayStepScale",
		                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.godRayStepScale, v60, v61, v62, v148);
		  this->fields.emptySkipSizeScale = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                      1.0,
		                                      (String *)"VolumetricCloud",
		                                      (String *)"emptySkipSizeScale",
		                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.emptySkipSizeScale, v63, v64, v65, v149);
		  this->fields.dynamicStepRange = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                    0.02,
		                                    (String *)"VolumetricCloud",
		                                    (String *)"dynamicStepRange",
		                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.dynamicStepRange, v66, v67, v68, v150);
		  this->fields.dynamicStepScale = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                    0.0,
		                                    (String *)"VolumetricCloud",
		                                    (String *)"dynamicStepScale",
		                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.dynamicStepScale, v69, v70, v71, v151);
		  this->fields.enableFarCloud = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                  0,
		                                  (String *)"VolumetricCloud",
		                                  (String *)"enableFarCloud",
		                                  MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.enableFarCloud, v72, v73, v74, v152);
		  this->fields.panoramicSizeX = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                  2048,
		                                  (String *)"VolumetricCloud",
		                                  (String *)"panoramicSizeX",
		                                  MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.panoramicSizeX, v75, v76, v77, v153);
		  this->fields.panoramicSizeY = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                  512,
		                                  (String *)"VolumetricCloud",
		                                  (String *)"panoramicSizeY",
		                                  MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.panoramicSizeY, v78, v79, v80, v154);
		  this->fields.octahedronSize = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                  1536,
		                                  (String *)"VolumetricCloud",
		                                  (String *)"octahedronSize",
		                                  MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.octahedronSize, v81, v82, v83, v155);
		  this->fields.octahedronHeightScale = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                         1.0,
		                                         (String *)"VolumetricCloud",
		                                         (String *)"octahedronHeightScale",
		                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.octahedronHeightScale, v84, v85, v86, v156);
		  this->fields.octahedronEnableSlicing = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                           0,
		                                           (String *)"VolumetricCloud",
		                                           (String *)"octahedronEnableSlicing",
		                                           MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.octahedronEnableSlicing, v87, v88, v89, v157);
		  this->fields.octahedronSlicingCountX = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                           1,
		                                           (String *)"VolumetricCloud",
		                                           (String *)"octahedronSlicingCountX",
		                                           MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.octahedronSlicingCountX, v90, v91, v92, v158);
		  this->fields.octahedronSlicingCountY = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                           1,
		                                           (String *)"VolumetricCloud",
		                                           (String *)"octahedronSlicingCountY",
		                                           MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.octahedronSlicingCountY, v93, v94, v95, v159);
		  this->fields.semicircularSize = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                    1024,
		                                    (String *)"VolumetricCloud",
		                                    (String *)"semicircularSize",
		                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.semicircularSize, v96, v97, v98, v160);
		  this->fields.semicircularZScale = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                      1.0,
		                                      (String *)"VolumetricCloud",
		                                      (String *)"semicircularZScale",
		                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.semicircularZScale, v99, v100, v101, v161);
		  this->fields.farCloudFramingLevel = (SettingParameter_1_EFarCloudFramingQuality_ *)HG::Rendering::Runtime::SettingParameter::Create<System::Int32Enum>(
		                                                                                       (Int32Enum__Enum)0,
		                                                                                       (String *)"VolumetricCloud",
		                                                                                       (String *)"farCloudFramingLevel",
		                                                                                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<HG::Rendering::Runtime::EFarCloudFramingQuality>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.farCloudFramingLevel, v102, v103, v104, v162);
		  this->fields.farCloudFramingComposeRatio = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                               0.2,
		                                               (String *)"VolumetricCloud",
		                                               (String *)"farCloudFramingComposeRatio",
		                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.farCloudFramingComposeRatio, v105, v106, v107, v163);
		  this->fields.farCloudFramingCubicSample = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                              0,
		                                              (String *)"VolumetricCloud",
		                                              (String *)"farCloudFramingCubicSample",
		                                              MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.farCloudFramingCubicSample, v108, v109, v110, v164);
		  this->fields.farCloudEnableTAA = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                     0,
		                                     (String *)"VolumetricCloud",
		                                     (String *)"farCloudEnableTAA",
		                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.farCloudEnableTAA, v111, v112, v113, v165);
		  this->fields.farCloudTAABlendRatio = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                         0.050000001,
		                                         (String *)"VolumetricCloud",
		                                         (String *)"farCloudTAABlendRatio",
		                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.farCloudTAABlendRatio, v114, v115, v116, v166);
		  this->fields.farCloudTAACubicSample = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                          0,
		                                          (String *)"VolumetricCloud",
		                                          (String *)"farCloudTAACubicSample",
		                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.farCloudTAACubicSample, v117, v118, v119, v167);
		  this->fields.farCloudMarchStepScale = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                          1.0,
		                                          (String *)"VolumetricCloud",
		                                          (String *)"farCloudMarchStepScale",
		                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.farCloudMarchStepScale, v120, v121, v122, v168);
		  this->fields.farCloudFullUpdateMarchStepScale = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                    1.0,
		                                                    (String *)"VolumetricCloud",
		                                                    (String *)"farCloudFullUpdateMarchStepScale",
		                                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.farCloudFullUpdateMarchStepScale, v123, v124, v125, v169);
		  this->fields.farCloudEmptySkipSizeScale = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                              1.0,
		                                              (String *)"VolumetricCloud",
		                                              (String *)"farCloudEmptySkipSizeScale",
		                                              MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.farCloudEmptySkipSizeScale, v126, v127, v128, v170);
		}
		
	}
}
