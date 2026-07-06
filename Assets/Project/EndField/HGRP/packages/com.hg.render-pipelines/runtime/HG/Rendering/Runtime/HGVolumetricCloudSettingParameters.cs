using System;

namespace HG.Rendering.Runtime
{
	public class HGVolumetricCloudSettingParameters
	{
		public HGVolumetricCloudSettingParameters()
		{
			// // HGVolumetricCloudSettingParameters()
			// void HG::Rendering::Runtime::HGVolumetricCloudSettingParameters::HGVolumetricCloudSettingParameters(
			//         HGVolumetricCloudSettingParameters *this,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v3; // rdx
			//   PassConstructorID__Enum__Array *v4; // r8
			//   HGCamera *v5; // r9
			//   HGRenderPathBase_HGRenderPathResources *v6; // rdx
			//   PassConstructorID__Enum__Array *v7; // r8
			//   HGCamera *v8; // r9
			//   HGRenderPathBase_HGRenderPathResources *v9; // rdx
			//   PassConstructorID__Enum__Array *v10; // r8
			//   HGCamera *v11; // r9
			//   HGRenderPathBase_HGRenderPathResources *v12; // rdx
			//   PassConstructorID__Enum__Array *v13; // r8
			//   HGCamera *v14; // r9
			//   HGRenderPathBase_HGRenderPathResources *v15; // rdx
			//   PassConstructorID__Enum__Array *v16; // r8
			//   HGCamera *v17; // r9
			//   HGRenderPathBase_HGRenderPathResources *v18; // rdx
			//   PassConstructorID__Enum__Array *v19; // r8
			//   HGCamera *v20; // r9
			//   HGRenderPathBase_HGRenderPathResources *v21; // rdx
			//   PassConstructorID__Enum__Array *v22; // r8
			//   HGCamera *v23; // r9
			//   HGRenderPathBase_HGRenderPathResources *v24; // rdx
			//   PassConstructorID__Enum__Array *v25; // r8
			//   HGCamera *v26; // r9
			//   HGRenderPathBase_HGRenderPathResources *v27; // rdx
			//   PassConstructorID__Enum__Array *v28; // r8
			//   HGCamera *v29; // r9
			//   HGRenderPathBase_HGRenderPathResources *v30; // rdx
			//   PassConstructorID__Enum__Array *v31; // r8
			//   HGCamera *v32; // r9
			//   HGRenderPathBase_HGRenderPathResources *v33; // rdx
			//   PassConstructorID__Enum__Array *v34; // r8
			//   HGCamera *v35; // r9
			//   HGRenderPathBase_HGRenderPathResources *v36; // rdx
			//   PassConstructorID__Enum__Array *v37; // r8
			//   HGCamera *v38; // r9
			//   HGRenderPathBase_HGRenderPathResources *v39; // rdx
			//   PassConstructorID__Enum__Array *v40; // r8
			//   HGCamera *v41; // r9
			//   HGRenderPathBase_HGRenderPathResources *v42; // rdx
			//   PassConstructorID__Enum__Array *v43; // r8
			//   HGCamera *v44; // r9
			//   HGRenderPathBase_HGRenderPathResources *v45; // rdx
			//   PassConstructorID__Enum__Array *v46; // r8
			//   HGCamera *v47; // r9
			//   HGRenderPathBase_HGRenderPathResources *v48; // rdx
			//   PassConstructorID__Enum__Array *v49; // r8
			//   HGCamera *v50; // r9
			//   HGRenderPathBase_HGRenderPathResources *v51; // rdx
			//   PassConstructorID__Enum__Array *v52; // r8
			//   HGCamera *v53; // r9
			//   HGRenderPathBase_HGRenderPathResources *v54; // rdx
			//   PassConstructorID__Enum__Array *v55; // r8
			//   HGCamera *v56; // r9
			//   HGRenderPathBase_HGRenderPathResources *v57; // rdx
			//   PassConstructorID__Enum__Array *v58; // r8
			//   HGCamera *v59; // r9
			//   HGRenderPathBase_HGRenderPathResources *v60; // rdx
			//   PassConstructorID__Enum__Array *v61; // r8
			//   HGCamera *v62; // r9
			//   HGRenderPathBase_HGRenderPathResources *v63; // rdx
			//   PassConstructorID__Enum__Array *v64; // r8
			//   HGCamera *v65; // r9
			//   HGRenderPathBase_HGRenderPathResources *v66; // rdx
			//   PassConstructorID__Enum__Array *v67; // r8
			//   HGCamera *v68; // r9
			//   HGRenderPathBase_HGRenderPathResources *v69; // rdx
			//   PassConstructorID__Enum__Array *v70; // r8
			//   HGCamera *v71; // r9
			//   HGRenderPathBase_HGRenderPathResources *v72; // rdx
			//   PassConstructorID__Enum__Array *v73; // r8
			//   HGCamera *v74; // r9
			//   HGRenderPathBase_HGRenderPathResources *v75; // rdx
			//   PassConstructorID__Enum__Array *v76; // r8
			//   HGCamera *v77; // r9
			//   HGRenderPathBase_HGRenderPathResources *v78; // rdx
			//   PassConstructorID__Enum__Array *v79; // r8
			//   HGCamera *v80; // r9
			//   HGRenderPathBase_HGRenderPathResources *v81; // rdx
			//   PassConstructorID__Enum__Array *v82; // r8
			//   HGCamera *v83; // r9
			//   HGRenderPathBase_HGRenderPathResources *v84; // rdx
			//   PassConstructorID__Enum__Array *v85; // r8
			//   HGCamera *v86; // r9
			//   HGRenderPathBase_HGRenderPathResources *v87; // rdx
			//   PassConstructorID__Enum__Array *v88; // r8
			//   HGCamera *v89; // r9
			//   HGRenderPathBase_HGRenderPathResources *v90; // rdx
			//   PassConstructorID__Enum__Array *v91; // r8
			//   HGCamera *v92; // r9
			//   HGRenderPathBase_HGRenderPathResources *v93; // rdx
			//   PassConstructorID__Enum__Array *v94; // r8
			//   HGCamera *v95; // r9
			//   HGRenderPathBase_HGRenderPathResources *v96; // rdx
			//   PassConstructorID__Enum__Array *v97; // r8
			//   HGCamera *v98; // r9
			//   HGRenderPathBase_HGRenderPathResources *v99; // rdx
			//   PassConstructorID__Enum__Array *v100; // r8
			//   HGCamera *v101; // r9
			//   HGRenderPathBase_HGRenderPathResources *v102; // rdx
			//   PassConstructorID__Enum__Array *v103; // r8
			//   HGCamera *v104; // r9
			//   HGRenderPathBase_HGRenderPathResources *v105; // rdx
			//   PassConstructorID__Enum__Array *v106; // r8
			//   HGCamera *v107; // r9
			//   HGRenderPathBase_HGRenderPathResources *v108; // rdx
			//   PassConstructorID__Enum__Array *v109; // r8
			//   HGCamera *v110; // r9
			//   HGRenderPathBase_HGRenderPathResources *v111; // rdx
			//   PassConstructorID__Enum__Array *v112; // r8
			//   HGCamera *v113; // r9
			//   HGRenderPathBase_HGRenderPathResources *v114; // rdx
			//   PassConstructorID__Enum__Array *v115; // r8
			//   HGCamera *v116; // r9
			//   HGRenderPathBase_HGRenderPathResources *v117; // rdx
			//   PassConstructorID__Enum__Array *v118; // r8
			//   HGCamera *v119; // r9
			//   HGRenderPathBase_HGRenderPathResources *v120; // rdx
			//   PassConstructorID__Enum__Array *v121; // r8
			//   HGCamera *v122; // r9
			//   HGRenderPathBase_HGRenderPathResources *v123; // rdx
			//   PassConstructorID__Enum__Array *v124; // r8
			//   HGCamera *v125; // r9
			//   MethodInfo *v126; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v127; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v128; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v129; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v130; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v131; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v132; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v133; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v134; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v135; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v136; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v137; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v138; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v139; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v140; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v141; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v142; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v143; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v144; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v145; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v146; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v147; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v148; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v149; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v150; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v151; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v152; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v153; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v154; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v155; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v156; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v157; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v158; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v159; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v160; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v161; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v162; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v163; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v164; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v165; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v166; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v167; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v168; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v169; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v170; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v171; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v172; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v173; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v174; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v175; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v176; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v177; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v178; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v179; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v180; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v181; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v182; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v183; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v184; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v185; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v186; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v187; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v188; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v189; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v190; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v191; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v192; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v193; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v194; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v195; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v196; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v197; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v198; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v199; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v200; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v201; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v202; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v203; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v204; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v205; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v206; // [rsp+60h] [rbp+28h]
			//   MethodInfo *v207; // [rsp+68h] [rbp+30h]
			// 
			//   if ( !byte_18D8EDB63 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<HG::Rendering::Runtime::EDownResFilter>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<HG::Rendering::Runtime::EFarCloudFramingQuality>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<HG::Rendering::Runtime::EFramingQuality>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
			//     sub_18003C530(&off_18C908F58);
			//     sub_18003C530(&off_18C908F20);
			//     sub_18003C530(&off_18C908F28);
			//     sub_18003C530(&off_18C908F30);
			//     sub_18003C530(&off_18C908F38);
			//     sub_18003C530(&off_18C908DA8);
			//     sub_18003C530(&off_18C908DB0);
			//     sub_18003C530(&off_18C908DB8);
			//     sub_18003C530(&off_18C908DC0);
			//     sub_18003C530(&off_18C908D88);
			//     sub_18003C530(&off_18C908D90);
			//     sub_18003C530(&off_18C908D98);
			//     sub_18003C530(&off_18C908DA0);
			//     sub_18003C530(&off_18C908DE8);
			//     sub_18003C530(&off_18C908DF0);
			//     sub_18003C530(&off_18C908DF8);
			//     sub_18003C530(&off_18C908E00);
			//     sub_18003C530(&off_18C908DC8);
			//     sub_18003C530(&off_18C908DD0);
			//     sub_18003C530(&off_18C908DD8);
			//     sub_18003C530(&off_18C908DE0);
			//     sub_18003C530(&off_18C908E30);
			//     sub_18003C530(&off_18C908E38);
			//     sub_18003C530(&off_18C908E40);
			//     sub_18003C530(&off_18C908E48);
			//     sub_18003C530(&off_18C908E08);
			//     sub_18003C530(&off_18C908E18);
			//     sub_18003C530(&off_18C908E20);
			//     sub_18003C530(&off_18C908E28);
			//     sub_18003C530(&off_18C908E70);
			//     sub_18003C530(&off_18C908E78);
			//     sub_18003C530(&off_18C908E80);
			//     sub_18003C530(&off_18C908E90);
			//     sub_18003C530(&off_18C908E50);
			//     sub_18003C530(&off_18C908E58);
			//     sub_18003C530(&off_18C908E60);
			//     sub_18003C530(&off_18C908E68);
			//     sub_18003C530(&off_18C908958);
			//     sub_18003C530(&off_18C908960);
			//     sub_18003C530(&off_18C908968);
			//     sub_18003C530(&off_18C908970);
			//     sub_18003C530(&off_18C908948);
			//     byte_18D8EDB63 = 1;
			//   }
			//   this.fields.enableDownRes = HG::Rendering::Runtime::SettingParameter::Create<bool>(
			//                                  0,
			//                                  (String *)"VolumetricCloud",
			//                                  (String *)"enableDownRes",
			//                                  MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields, v3, v4, v5, v126, v166);
			//   this.fields.downResRatio = HG::Rendering::Runtime::SettingParameter::Create<float>(
			//                                 1.0,
			//                                 (String *)"VolumetricCloud",
			//                                 (String *)"downResRatio",
			//                                 MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.downResRatio, v6, v7, v8, v127, v167);
			//   this.fields.downResFilter = (SettingParameter_1_EDownResFilter_ *)HG::Rendering::Runtime::SettingParameter::Create<System::Int32Enum>(
			//                                                                        (Int32Enum__Enum)1u,
			//                                                                        (String *)"VolumetricCloud",
			//                                                                        (String *)"downResFilter",
			//                                                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<HG::Rendering::Runtime::EDownResFilter>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.downResFilter, v9, v10, v11, v128, v168);
			//   this.fields.enableFraming = HG::Rendering::Runtime::SettingParameter::Create<bool>(
			//                                  0,
			//                                  (String *)"VolumetricCloud",
			//                                  (String *)"enableFraming",
			//                                  MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.enableFraming, v12, v13, v14, v129, v169);
			//   this.fields.framingLevel = (SettingParameter_1_EFramingQuality_ *)HG::Rendering::Runtime::SettingParameter::Create<System::Int32Enum>(
			//                                                                        (Int32Enum__Enum)0,
			//                                                                        (String *)"VolumetricCloud",
			//                                                                        (String *)"framingLevel",
			//                                                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<HG::Rendering::Runtime::EFramingQuality>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.framingLevel, v15, v16, v17, v130, v170);
			//   this.fields.framingComposeRatio = HG::Rendering::Runtime::SettingParameter::Create<float>(
			//                                        0.25,
			//                                        (String *)"VolumetricCloud",
			//                                        (String *)"framingComposeRatio",
			//                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.framingComposeRatio, v18, v19, v20, v131, v171);
			//   this.fields.enableFramingCubicSample = HG::Rendering::Runtime::SettingParameter::Create<bool>(
			//                                             1,
			//                                             (String *)"VolumetricCloud",
			//                                             (String *)"enableFramingCubicSample",
			//                                             MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.enableFramingCubicSample, v21, v22, v23, v132, v172);
			//   this.fields.enableFramingMotionVector = HG::Rendering::Runtime::SettingParameter::Create<bool>(
			//                                              1,
			//                                              (String *)"VolumetricCloud",
			//                                              (String *)"enableFramingMotionVector",
			//                                              MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.enableFramingMotionVector, v24, v25, v26, v133, v173);
			//   this.fields.enableFramingDepthOpt = HG::Rendering::Runtime::SettingParameter::Create<bool>(
			//                                          1,
			//                                          (String *)"VolumetricCloud",
			//                                          (String *)"enableFramingDepthOpt",
			//                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.enableFramingDepthOpt, v27, v28, v29, v134, v174);
			//   this.fields.enableFramingColorAABB = HG::Rendering::Runtime::SettingParameter::Create<bool>(
			//                                           1,
			//                                           (String *)"VolumetricCloud",
			//                                           (String *)"enableFramingColorAABB",
			//                                           MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.enableFramingColorAABB, v30, v31, v32, v135, v175);
			//   this.fields.enableFramingNeighborAvg = HG::Rendering::Runtime::SettingParameter::Create<bool>(
			//                                             1,
			//                                             (String *)"VolumetricCloud",
			//                                             (String *)"enableFramingNeighborAvg",
			//                                             MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.enableFramingNeighborAvg, v33, v34, v35, v136, v176);
			//   this.fields.enableTAA = HG::Rendering::Runtime::SettingParameter::Create<bool>(
			//                              1,
			//                              (String *)"VolumetricCloud",
			//                              (String *)"enableTAA",
			//                              MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.enableTAA, v36, v37, v38, v137, v177);
			//   this.fields.enableTAACubicSample = HG::Rendering::Runtime::SettingParameter::Create<bool>(
			//                                         1,
			//                                         (String *)"VolumetricCloud",
			//                                         (String *)"enableTAACubicSample",
			//                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.enableTAACubicSample, v39, v40, v41, v138, v178);
			//   this.fields.enableTAAMotionVector = HG::Rendering::Runtime::SettingParameter::Create<bool>(
			//                                          1,
			//                                          (String *)"VolumetricCloud",
			//                                          (String *)"enableTAAMotionVector",
			//                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.enableTAAMotionVector, v42, v43, v44, v139, v179);
			//   this.fields.enableTAADepthOpt = HG::Rendering::Runtime::SettingParameter::Create<bool>(
			//                                      1,
			//                                      (String *)"VolumetricCloud",
			//                                      (String *)"enableTAADepthOpt",
			//                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.enableTAADepthOpt, v45, v46, v47, v140, v180);
			//   this.fields.enableTAAColorAABB = HG::Rendering::Runtime::SettingParameter::Create<bool>(
			//                                       1,
			//                                       (String *)"VolumetricCloud",
			//                                       (String *)"enableTAAColorAABB",
			//                                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.enableTAAColorAABB, v48, v49, v50, v141, v181);
			//   this.fields.enableTAANeighborAvg = HG::Rendering::Runtime::SettingParameter::Create<bool>(
			//                                         1,
			//                                         (String *)"VolumetricCloud",
			//                                         (String *)"enableTAANeighborAvg",
			//                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.enableTAANeighborAvg, v51, v52, v53, v142, v182);
			//   this.fields.invalidDepthBlendRatio = HG::Rendering::Runtime::SettingParameter::Create<float>(
			//                                           1.0,
			//                                           (String *)"VolumetricCloud",
			//                                           (String *)"invalidDepthBlendRatio",
			//                                           MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.invalidDepthBlendRatio, v54, v55, v56, v143, v183);
			//   this.fields.marchStepScale = HG::Rendering::Runtime::SettingParameter::Create<float>(
			//                                   3.0,
			//                                   (String *)"VolumetricCloud",
			//                                   (String *)"marchStepScale",
			//                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.marchStepScale, v57, v58, v59, v144, v184);
			//   this.fields.godRayStepScale = HG::Rendering::Runtime::SettingParameter::Create<float>(
			//                                    2.0,
			//                                    (String *)"VolumetricCloud",
			//                                    (String *)"godRayStepScale",
			//                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.godRayStepScale, v60, v61, v62, v145, v185);
			//   this.fields.emptySkipSizeScale = HG::Rendering::Runtime::SettingParameter::Create<float>(
			//                                       1.0,
			//                                       (String *)"VolumetricCloud",
			//                                       (String *)"emptySkipSizeScale",
			//                                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.emptySkipSizeScale, v63, v64, v65, v146, v186);
			//   this.fields.dynamicStepRange = HG::Rendering::Runtime::SettingParameter::Create<float>(
			//                                     0.02,
			//                                     (String *)"VolumetricCloud",
			//                                     (String *)"dynamicStepRange",
			//                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.dynamicStepRange, v66, v67, v68, v147, v187);
			//   this.fields.dynamicStepScale = HG::Rendering::Runtime::SettingParameter::Create<float>(
			//                                     0.0,
			//                                     (String *)"VolumetricCloud",
			//                                     (String *)"dynamicStepScale",
			//                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.dynamicStepScale, v69, v70, v71, v148, v188);
			//   this.fields.enableFarCloud = HG::Rendering::Runtime::SettingParameter::Create<bool>(
			//                                   0,
			//                                   (String *)"VolumetricCloud",
			//                                   (String *)"enableFarCloud",
			//                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.enableFarCloud, v72, v73, v74, v149, v189);
			//   this.fields.panoramicSizeX = HG::Rendering::Runtime::SettingParameter::Create<int>(
			//                                   2048,
			//                                   (String *)"VolumetricCloud",
			//                                   (String *)"panoramicSizeX",
			//                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.panoramicSizeX, v75, v76, v77, v150, v190);
			//   this.fields.panoramicSizeY = HG::Rendering::Runtime::SettingParameter::Create<int>(
			//                                   512,
			//                                   (String *)"VolumetricCloud",
			//                                   (String *)"panoramicSizeY",
			//                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.panoramicSizeY, v78, v79, v80, v151, v191);
			//   this.fields.octahedronSize = HG::Rendering::Runtime::SettingParameter::Create<int>(
			//                                   1536,
			//                                   (String *)"VolumetricCloud",
			//                                   (String *)"octahedronSize",
			//                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.octahedronSize, v81, v82, v83, v152, v192);
			//   this.fields.octahedronHeightScale = HG::Rendering::Runtime::SettingParameter::Create<float>(
			//                                          1.0,
			//                                          (String *)"VolumetricCloud",
			//                                          (String *)"octahedronHeightScale",
			//                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.octahedronHeightScale, v84, v85, v86, v153, v193);
			//   this.fields.octahedronEnableSlicing = HG::Rendering::Runtime::SettingParameter::Create<bool>(
			//                                            0,
			//                                            (String *)"VolumetricCloud",
			//                                            (String *)"octahedronEnableSlicing",
			//                                            MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.octahedronEnableSlicing, v87, v88, v89, v154, v194);
			//   this.fields.octahedronSlicingCountX = HG::Rendering::Runtime::SettingParameter::Create<int>(
			//                                            1,
			//                                            (String *)"VolumetricCloud",
			//                                            (String *)"octahedronSlicingCountX",
			//                                            MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.octahedronSlicingCountX, v90, v91, v92, v155, v195);
			//   this.fields.octahedronSlicingCountY = HG::Rendering::Runtime::SettingParameter::Create<int>(
			//                                            1,
			//                                            (String *)"VolumetricCloud",
			//                                            (String *)"octahedronSlicingCountY",
			//                                            MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.octahedronSlicingCountY, v93, v94, v95, v156, v196);
			//   this.fields.semicircularSize = HG::Rendering::Runtime::SettingParameter::Create<int>(
			//                                     1024,
			//                                     (String *)"VolumetricCloud",
			//                                     (String *)"semicircularSize",
			//                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.semicircularSize, v96, v97, v98, v157, v197);
			//   this.fields.semicircularZScale = HG::Rendering::Runtime::SettingParameter::Create<float>(
			//                                       1.0,
			//                                       (String *)"VolumetricCloud",
			//                                       (String *)"semicircularZScale",
			//                                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.semicircularZScale, v99, v100, v101, v158, v198);
			//   this.fields.farCloudFramingLevel = (SettingParameter_1_EFarCloudFramingQuality_ *)HG::Rendering::Runtime::SettingParameter::Create<System::Int32Enum>(
			//                                                                                        (Int32Enum__Enum)0,
			//                                                                                        (String *)"VolumetricCloud",
			//                                                                                        (String *)"farCloudFramingLevel",
			//                                                                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<HG::Rendering::Runtime::EFarCloudFramingQuality>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.farCloudFramingLevel, v102, v103, v104, v159, v199);
			//   this.fields.farCloudFramingComposeRatio = HG::Rendering::Runtime::SettingParameter::Create<float>(
			//                                                0.2,
			//                                                (String *)"VolumetricCloud",
			//                                                (String *)"farCloudFramingComposeRatio",
			//                                                MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.farCloudFramingComposeRatio, v105, v106, v107, v160, v200);
			//   this.fields.farCloudFramingCubicSample = HG::Rendering::Runtime::SettingParameter::Create<bool>(
			//                                               0,
			//                                               (String *)"VolumetricCloud",
			//                                               (String *)"farCloudFramingCubicSample",
			//                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.farCloudFramingCubicSample, v108, v109, v110, v161, v201);
			//   this.fields.farCloudEnableTAA = HG::Rendering::Runtime::SettingParameter::Create<bool>(
			//                                      0,
			//                                      (String *)"VolumetricCloud",
			//                                      (String *)"farCloudEnableTAA",
			//                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.farCloudEnableTAA, v111, v112, v113, v162, v202);
			//   this.fields.farCloudTAABlendRatio = HG::Rendering::Runtime::SettingParameter::Create<float>(
			//                                          0.050000001,
			//                                          (String *)"VolumetricCloud",
			//                                          (String *)"farCloudTAABlendRatio",
			//                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.farCloudTAABlendRatio, v114, v115, v116, v163, v203);
			//   this.fields.farCloudTAACubicSample = HG::Rendering::Runtime::SettingParameter::Create<bool>(
			//                                           0,
			//                                           (String *)"VolumetricCloud",
			//                                           (String *)"farCloudTAACubicSample",
			//                                           MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.farCloudTAACubicSample, v117, v118, v119, v164, v204);
			//   this.fields.farCloudMarchStepScale = HG::Rendering::Runtime::SettingParameter::Create<float>(
			//                                           1.0,
			//                                           (String *)"VolumetricCloud",
			//                                           (String *)"farCloudMarchStepScale",
			//                                           MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.farCloudMarchStepScale, v120, v121, v122, v165, v205);
			//   this.fields.farCloudEmptySkipSizeScale = HG::Rendering::Runtime::SettingParameter::Create<float>(
			//                                               1.0,
			//                                               (String *)"VolumetricCloud",
			//                                               (String *)"farCloudEmptySkipSizeScale",
			//                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.farCloudEmptySkipSizeScale, v123, v124, v125, v206, v207);
			// }
			// 
		}

		public const string FEATURE_NAME = "VolumetricCloud";

		public readonly SettingParameter<bool> enableDownRes;

		public readonly SettingParameter<float> downResRatio;

		public readonly SettingParameter<EDownResFilter> downResFilter;

		public readonly SettingParameter<bool> enableFraming;

		public readonly SettingParameter<EFramingQuality> framingLevel;

		public readonly SettingParameter<float> framingComposeRatio;

		public readonly SettingParameter<bool> enableFramingCubicSample;

		public readonly SettingParameter<bool> enableFramingMotionVector;

		public readonly SettingParameter<bool> enableFramingDepthOpt;

		public readonly SettingParameter<bool> enableFramingColorAABB;

		public readonly SettingParameter<bool> enableFramingNeighborAvg;

		public readonly SettingParameter<bool> enableTAA;

		public readonly SettingParameter<bool> enableTAACubicSample;

		public readonly SettingParameter<bool> enableTAAMotionVector;

		public readonly SettingParameter<bool> enableTAADepthOpt;

		public readonly SettingParameter<bool> enableTAAColorAABB;

		public readonly SettingParameter<bool> enableTAANeighborAvg;

		public readonly SettingParameter<float> invalidDepthBlendRatio;

		public readonly SettingParameter<float> marchStepScale;

		public readonly SettingParameter<float> godRayStepScale;

		public readonly SettingParameter<float> emptySkipSizeScale;

		public readonly SettingParameter<float> dynamicStepRange;

		public readonly SettingParameter<float> dynamicStepScale;

		public readonly SettingParameter<bool> enableFarCloud;

		public readonly SettingParameter<int> panoramicSizeX;

		public readonly SettingParameter<int> panoramicSizeY;

		public readonly SettingParameter<int> octahedronSize;

		public readonly SettingParameter<float> octahedronHeightScale;

		public readonly SettingParameter<bool> octahedronEnableSlicing;

		public readonly SettingParameter<int> octahedronSlicingCountX;

		public readonly SettingParameter<int> octahedronSlicingCountY;

		public readonly SettingParameter<int> semicircularSize;

		public readonly SettingParameter<float> semicircularZScale;

		public readonly SettingParameter<EFarCloudFramingQuality> farCloudFramingLevel;

		public readonly SettingParameter<float> farCloudFramingComposeRatio;

		public readonly SettingParameter<bool> farCloudFramingCubicSample;

		public readonly SettingParameter<bool> farCloudEnableTAA;

		public readonly SettingParameter<float> farCloudTAABlendRatio;

		public readonly SettingParameter<bool> farCloudTAACubicSample;

		public readonly SettingParameter<float> farCloudMarchStepScale;

		public readonly SettingParameter<float> farCloudEmptySkipSizeScale;
	}
}
