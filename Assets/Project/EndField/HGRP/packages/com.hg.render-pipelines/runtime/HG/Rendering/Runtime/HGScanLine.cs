using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("HG/ScanLine", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public sealed class HGScanLine : VolumeComponent
	{
		public HGScanLine()
		{
			// // HGScanLine()
			// void HG::Rendering::Runtime::HGScanLine::HGScanLine(HGScanLine *this, MethodInfo *method)
			// {
			//   BoolParameter *v3; // rax
			//   HGRenderPathBase_HGRenderPathResources *v4; // rdx
			//   __int64 v5; // rcx
			//   BoolParameter *v6; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v7; // rdx
			//   PassConstructorID__Enum__Array *v8; // r8
			//   HGCamera *v9; // r9
			//   __int64 v10; // rdi
			//   PassConstructorID__Enum__Array *v11; // r8
			//   HGCamera *v12; // r9
			//   ClampedFloatParameter *v13; // rax
			//   ClampedFloatParameter *v14; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v15; // rdx
			//   PassConstructorID__Enum__Array *v16; // r8
			//   HGCamera *v17; // r9
			//   MethodInfo *v18; // rdx
			//   Quaternion v19; // xmm6
			//   __int64 v20; // rdi
			//   PassConstructorID__Enum__Array *v21; // r8
			//   HGCamera *v22; // r9
			//   ClampedFloatParameter *v23; // rax
			//   ClampedFloatParameter *v24; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v25; // rdx
			//   PassConstructorID__Enum__Array *v26; // r8
			//   HGCamera *v27; // r9
			//   BoolParameter *v28; // rax
			//   BoolParameter *v29; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v30; // rdx
			//   PassConstructorID__Enum__Array *v31; // r8
			//   HGCamera *v32; // r9
			//   Texture2DParameter *v33; // rax
			//   Texture2DParameter *v34; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v35; // rdx
			//   PassConstructorID__Enum__Array *v36; // r8
			//   HGCamera *v37; // r9
			//   Vector2Parameter *v38; // rax
			//   Vector2Parameter *v39; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v40; // rdx
			//   PassConstructorID__Enum__Array *v41; // r8
			//   HGCamera *v42; // r9
			//   Vector2Parameter *v43; // rax
			//   Vector2Parameter *v44; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v45; // rdx
			//   PassConstructorID__Enum__Array *v46; // r8
			//   HGCamera *v47; // r9
			//   ClampedFloatParameter *v48; // rax
			//   ClampedFloatParameter *v49; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v50; // rdx
			//   PassConstructorID__Enum__Array *v51; // r8
			//   HGCamera *v52; // r9
			//   ClampedFloatParameter *v53; // rax
			//   ClampedFloatParameter *v54; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v55; // rdx
			//   PassConstructorID__Enum__Array *v56; // r8
			//   HGCamera *v57; // r9
			//   ClampedFloatParameter *v58; // rax
			//   ClampedFloatParameter *v59; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v60; // rdx
			//   PassConstructorID__Enum__Array *v61; // r8
			//   HGCamera *v62; // r9
			//   ClampedFloatParameter *v63; // rax
			//   ClampedFloatParameter *v64; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v65; // rdx
			//   PassConstructorID__Enum__Array *v66; // r8
			//   HGCamera *v67; // r9
			//   ClampedFloatParameter *v68; // rax
			//   ClampedFloatParameter *v69; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v70; // rdx
			//   PassConstructorID__Enum__Array *v71; // r8
			//   HGCamera *v72; // r9
			//   ClampedFloatParameter *v73; // rax
			//   ClampedFloatParameter *v74; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v75; // rdx
			//   PassConstructorID__Enum__Array *v76; // r8
			//   HGCamera *v77; // r9
			//   ClampedFloatParameter *v78; // rax
			//   ClampedFloatParameter *v79; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v80; // rdx
			//   PassConstructorID__Enum__Array *v81; // r8
			//   HGCamera *v82; // r9
			//   ClampedFloatParameter *v83; // rax
			//   ClampedFloatParameter *v84; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v85; // rdx
			//   PassConstructorID__Enum__Array *v86; // r8
			//   HGCamera *v87; // r9
			//   ClampedFloatParameter *v88; // rax
			//   ClampedFloatParameter *v89; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v90; // rdx
			//   PassConstructorID__Enum__Array *v91; // r8
			//   HGCamera *v92; // r9
			//   ClampedFloatParameter *v93; // rax
			//   ClampedFloatParameter *v94; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v95; // rdx
			//   PassConstructorID__Enum__Array *v96; // r8
			//   HGCamera *v97; // r9
			//   ClampedFloatParameter *v98; // rax
			//   ClampedFloatParameter *v99; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v100; // rdx
			//   PassConstructorID__Enum__Array *v101; // r8
			//   HGCamera *v102; // r9
			//   ClampedFloatParameter *v103; // rax
			//   ClampedFloatParameter *v104; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v105; // rdx
			//   PassConstructorID__Enum__Array *v106; // r8
			//   HGCamera *v107; // r9
			//   ClampedFloatParameter *v108; // rax
			//   ClampedFloatParameter *v109; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v110; // rdx
			//   PassConstructorID__Enum__Array *v111; // r8
			//   HGCamera *v112; // r9
			//   ClampedFloatParameter *v113; // rax
			//   ClampedFloatParameter *v114; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v115; // rdx
			//   PassConstructorID__Enum__Array *v116; // r8
			//   HGCamera *v117; // r9
			//   ClampedFloatParameter *v118; // rax
			//   ClampedFloatParameter *v119; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v120; // rdx
			//   PassConstructorID__Enum__Array *v121; // r8
			//   HGCamera *v122; // r9
			//   ClampedFloatParameter *v123; // rax
			//   ClampedFloatParameter *v124; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v125; // rdx
			//   PassConstructorID__Enum__Array *v126; // r8
			//   HGCamera *v127; // r9
			//   ClampedFloatParameter *v128; // rax
			//   ClampedFloatParameter *v129; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v130; // rdx
			//   PassConstructorID__Enum__Array *v131; // r8
			//   HGCamera *v132; // r9
			//   ClampedFloatParameter *v133; // rax
			//   ClampedFloatParameter *v134; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v135; // rdx
			//   PassConstructorID__Enum__Array *v136; // r8
			//   HGCamera *v137; // r9
			//   ClampedFloatParameter *v138; // rax
			//   ClampedFloatParameter *v139; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v140; // rdx
			//   PassConstructorID__Enum__Array *v141; // r8
			//   HGCamera *v142; // r9
			//   ClampedFloatParameter *v143; // rax
			//   ClampedFloatParameter *v144; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v145; // rdx
			//   PassConstructorID__Enum__Array *v146; // r8
			//   HGCamera *v147; // r9
			//   ClampedFloatParameter *v148; // rax
			//   ClampedFloatParameter *v149; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v150; // rdx
			//   PassConstructorID__Enum__Array *v151; // r8
			//   HGCamera *v152; // r9
			//   ClampedFloatParameter *v153; // rax
			//   ClampedFloatParameter *v154; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v155; // rdx
			//   PassConstructorID__Enum__Array *v156; // r8
			//   HGCamera *v157; // r9
			//   ClampedFloatParameter *v158; // rax
			//   ClampedFloatParameter *v159; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v160; // rdx
			//   PassConstructorID__Enum__Array *v161; // r8
			//   HGCamera *v162; // r9
			//   ClampedFloatParameter *v163; // rax
			//   ClampedFloatParameter *v164; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v165; // rdx
			//   PassConstructorID__Enum__Array *v166; // r8
			//   HGCamera *v167; // r9
			//   ClampedFloatParameter *v168; // rax
			//   ClampedFloatParameter *v169; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v170; // rdx
			//   PassConstructorID__Enum__Array *v171; // r8
			//   HGCamera *v172; // r9
			//   ClampedFloatParameter *v173; // rax
			//   ClampedFloatParameter *v174; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v175; // rdx
			//   PassConstructorID__Enum__Array *v176; // r8
			//   HGCamera *v177; // r9
			//   ClampedFloatParameter *v178; // rax
			//   ClampedFloatParameter *v179; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v180; // rdx
			//   PassConstructorID__Enum__Array *v181; // r8
			//   HGCamera *v182; // r9
			//   ClampedFloatParameter *v183; // rax
			//   ClampedFloatParameter *v184; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v185; // rdx
			//   PassConstructorID__Enum__Array *v186; // r8
			//   HGCamera *v187; // r9
			//   ClampedFloatParameter *v188; // rax
			//   ClampedFloatParameter *v189; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v190; // rdx
			//   PassConstructorID__Enum__Array *v191; // r8
			//   HGCamera *v192; // r9
			//   ClampedFloatParameter *v193; // rax
			//   ClampedFloatParameter *v194; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v195; // rdx
			//   PassConstructorID__Enum__Array *v196; // r8
			//   HGCamera *v197; // r9
			//   ClampedFloatParameter *v198; // rax
			//   ClampedFloatParameter *v199; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v200; // rdx
			//   PassConstructorID__Enum__Array *v201; // r8
			//   HGCamera *v202; // r9
			//   ClampedFloatParameter *v203; // rax
			//   ClampedFloatParameter *v204; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v205; // rdx
			//   PassConstructorID__Enum__Array *v206; // r8
			//   HGCamera *v207; // r9
			//   ClampedFloatParameter *v208; // rax
			//   ClampedFloatParameter *v209; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v210; // rdx
			//   PassConstructorID__Enum__Array *v211; // r8
			//   HGCamera *v212; // r9
			//   ClampedFloatParameter *v213; // rax
			//   ClampedFloatParameter *v214; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v215; // rdx
			//   PassConstructorID__Enum__Array *v216; // r8
			//   HGCamera *v217; // r9
			//   ClampedFloatParameter *v218; // rax
			//   ClampedFloatParameter *v219; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v220; // rdx
			//   PassConstructorID__Enum__Array *v221; // r8
			//   HGCamera *v222; // r9
			//   ClampedFloatParameter *v223; // rax
			//   ClampedFloatParameter *v224; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v225; // rdx
			//   PassConstructorID__Enum__Array *v226; // r8
			//   HGCamera *v227; // r9
			//   ClampedFloatParameter *v228; // rax
			//   ClampedFloatParameter *v229; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v230; // rdx
			//   PassConstructorID__Enum__Array *v231; // r8
			//   HGCamera *v232; // r9
			//   MethodInfo *v233; // rdx
			//   Vector4 v234; // xmm8
			//   __int64 v235; // rdi
			//   PassConstructorID__Enum__Array *v236; // r8
			//   HGCamera *v237; // r9
			//   MethodInfo *v238; // rdx
			//   Vector4 v239; // xmm8
			//   __int64 v240; // rdi
			//   PassConstructorID__Enum__Array *v241; // r8
			//   HGCamera *v242; // r9
			//   __int64 v243; // rdi
			//   PassConstructorID__Enum__Array *v244; // r8
			//   HGCamera *v245; // r9
			//   __int64 v246; // rdi
			//   PassConstructorID__Enum__Array *v247; // r8
			//   HGCamera *v248; // r9
			//   __int64 v249; // rdi
			//   PassConstructorID__Enum__Array *v250; // r8
			//   HGCamera *v251; // r9
			//   ClampedFloatParameter *v252; // rax
			//   ClampedFloatParameter *v253; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v254; // rdx
			//   PassConstructorID__Enum__Array *v255; // r8
			//   HGCamera *v256; // r9
			//   MethodInfo *overrideState; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatea; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatel; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStateb; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatem; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatec; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStated; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatee; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatef; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStaten; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStateo; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatep; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStateq; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStater; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStates; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatet; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStateu; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatev; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatew; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatex; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatey; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatez; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStateba; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatebb; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatebc; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatebd; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatebe; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatebf; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatebg; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatebh; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatebi; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatebj; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatebk; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatebl; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatebm; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatebn; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatebo; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatebp; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatebq; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatebr; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatebs; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatebt; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatebu; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatebv; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatebw; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatebx; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStateg; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStateh; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatei; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatej; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStatek; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *overrideStateby; // [rsp+20h] [rbp-C8h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodm; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodn; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methode; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodf; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodg; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodo; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodp; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodq; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodr; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methods; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodt; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodu; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodv; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodw; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodx; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methody; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodz; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodba; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodbb; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodbc; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodbd; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodbe; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodbf; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodbg; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodbh; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodbi; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodbj; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodbk; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodbl; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodbm; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodbn; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodbo; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodbp; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodbq; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodbr; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodbs; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodbt; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodbu; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodbv; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodbw; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodbx; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodby; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodh; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodi; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodj; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodk; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodl; // [rsp+28h] [rbp-C0h]
			//   MethodInfo *methodbz; // [rsp+28h] [rbp-C0h]
			//   Quaternion v361; // [rsp+30h] [rbp-B8h] BYREF
			// 
			//   if ( !byte_18D8ED9DD )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::BoolParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ColorParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Texture2DParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Vector4Parameter);
			//     byte_18D8ED9DD = 1;
			//   }
			//   v3 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v6 = v3;
			//   if ( !v3 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v3, 0, 0, 0LL);
			//   this.fields.enabled = v6;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.enabled, v7, v8, v9, overrideState, methoda);
			//   v10 = sub_180004920(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
			//   if ( !v10 )
			//     goto LABEL_70;
			//   if ( !byte_18D8F3664 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector4>::VolumeParameter);
			//     byte_18D8F3664 = 1;
			//   }
			//   *(_OWORD *)(v10 + 24) = 0LL;
			//   *(_BYTE *)(v10 + 16) = 0;
			//   this.fields.centerPos = (Vector4Parameter *)v10;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.centerPos, v4, v11, v12, overrideStatea, methodb);
			//   v13 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v14 = v13;
			//   if ( !v13 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v13, 0.0, 0.0, 50.0, 0, 0LL);
			//   this.fields.progress = v14;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.progress, v15, v16, v17, overrideStatel, methodm);
			//   v19 = *UnityEngine::Quaternion::get_identity(&v361, v18);
			//   v20 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v20 )
			//     goto LABEL_70;
			//   if ( !byte_18D8F3661 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3661 = 1;
			//   }
			//   *(Quaternion *)(v20 + 24) = v19;
			//   *(_WORD *)(v20 + 40) = 0;
			//   *(_BYTE *)(v20 + 42) = 1;
			//   *(_BYTE *)(v20 + 16) = 0;
			//   this.fields.color = (ColorParameter *)v20;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.color, v4, v21, v22, overrideStateb, methodc);
			//   v23 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v24 = v23;
			//   if ( !v23 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v23, 2.5, 0.1, 5.0, 0, 0LL);
			//   this.fields.angleBlendFallOff = v24;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.angleBlendFallOff, v25, v26, v27, overrideStatem, methodn);
			//   v28 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v29 = v28;
			//   if ( !v28 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v28, 0, 0, 0LL);
			//   this.fields.useMaskTex = v29;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.useMaskTex, v30, v31, v32, overrideStatec, methodd);
			//   v33 = (Texture2DParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Texture2DParameter);
			//   v34 = v33;
			//   if ( !v33 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::Texture2DParameter::Texture2DParameter(v33, 0LL, 0, 0LL);
			//   this.fields.maskTex = v34;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.maskTex, v35, v36, v37, overrideStated, methode);
			//   v38 = (Vector2Parameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//   v39 = v38;
			//   if ( !v38 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::Vector2Parameter::Vector2Parameter(
			//     v38,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u),
			//     0,
			//     0LL);
			//   this.fields.maskTexTiling = v39;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.maskTexTiling, v40, v41, v42, overrideStatee, methodf);
			//   v43 = (Vector2Parameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//   v44 = v43;
			//   if ( !v43 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::Vector2Parameter::Vector2Parameter(
			//     v43,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0LL, (__m128)0LL),
			//     0,
			//     0LL);
			//   this.fields.maskTexOffset = v44;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.maskTexOffset, v45, v46, v47, overrideStatef, methodg);
			//   v48 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v49 = v48;
			//   if ( !v48 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v48, 0.1, 0.0, 20.0, 0, 0LL);
			//   this.fields.interval = v49;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.interval, v50, v51, v52, overrideStaten, methodo);
			//   v53 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v54 = v53;
			//   if ( !v53 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v53, 0.1, 0.0, 1.0, 0, 0LL);
			//   this.fields.width = v54;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.width, v55, v56, v57, overrideStateo, methodp);
			//   v58 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v59 = v58;
			//   if ( !v58 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v58, 10.0, 0.0, 100.0, 0, 0LL);
			//   this.fields.maxDistance = v59;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.maxDistance, v60, v61, v62, overrideStatep, methodq);
			//   v63 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v64 = v63;
			//   if ( !v63 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v63, 0.0, 0.0, 20.0, 0, 0LL);
			//   this.fields.minDistance = v64;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.minDistance, v65, v66, v67, overrideStateq, methodr);
			//   v68 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v69 = v68;
			//   if ( !v68 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v68, 10.0, 1.0, 50.0, 0, 0LL);
			//   this.fields.smoothness = v69;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.smoothness, v70, v71, v72, overrideStater, methods);
			//   v73 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v74 = v73;
			//   if ( !v73 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v73, 10.0, 5.0, 200.0, 0, 0LL);
			//   this.fields.maxFade = v74;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.maxFade, v75, v76, v77, overrideStates, methodt);
			//   v78 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v79 = v78;
			//   if ( !v78 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v78, 1.0, 0.0, 5.0, 0, 0LL);
			//   this.fields.distortScale = v79;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.distortScale, v80, v81, v82, overrideStatet, methodu);
			//   v83 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v84 = v83;
			//   if ( !v83 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v83, 1.0, -0.0, 5.0, 0, 0LL);
			//   this.fields.charDistortScale = v84;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.charDistortScale, v85, v86, v87, overrideStateu, methodv);
			//   v88 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v89 = v88;
			//   if ( !v88 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v88, 1.0, -5.0, 5.0, 0, 0LL);
			//   this.fields.distortIntensity = v89;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.distortIntensity, v90, v91, v92, overrideStatev, methodw);
			//   v93 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v94 = v93;
			//   if ( !v93 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v93, 0.0, 0.0, 10.0, 0, 0LL);
			//   this.fields.charBrightIntensity = v94;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.charBrightIntensity, v95, v96, v97, overrideStatew, methodx);
			//   v98 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v99 = v98;
			//   if ( !v98 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v98, 1.0, -5.0, 5.0, 0, 0LL);
			//   this.fields.charDistortIntensity = v99;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.charDistortIntensity, v100, v101, v102, overrideStatex, methody);
			//   v103 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v104 = v103;
			//   if ( !v103 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v103, 1.0, 0.0, 2.0, 0, 0LL);
			//   this.fields.charDistortOnEdge = v104;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.charDistortOnEdge, v105, v106, v107, overrideStatey, methodz);
			//   v108 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v109 = v108;
			//   if ( !v108 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v108, 4.0, 0.0, 10.0, 0, 0LL);
			//   this.fields.charDistortOuter = v109;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.charDistortOuter, v110, v111, v112, overrideStatez, methodba);
			//   v113 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v114 = v113;
			//   if ( !v113 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v113, 0.0, 0.0, 5.0, 0, 0LL);
			//   this.fields.distortSpeed = v114;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.distortSpeed, v115, v116, v117, overrideStateba, methodbb);
			//   v118 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v119 = v118;
			//   if ( !v118 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v118, 0.0, 0.0, 10.0, 0, 0LL);
			//   this.fields.charDistortSpeed = v119;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.charDistortSpeed, v120, v121, v122, overrideStatebb, methodbc);
			//   v123 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v124 = v123;
			//   if ( !v123 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v123, 0.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.highlightFading = v124;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.highlightFading, v125, v126, v127, overrideStatebc, methodbd);
			//   v128 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v129 = v128;
			//   if ( !v128 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v128, 2.5, 0.2, 15.0, 0, 0LL);
			//   this.fields.highlightWidth = v129;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.highlightWidth, v130, v131, v132, overrideStatebd, methodbe);
			//   v133 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v134 = v133;
			//   if ( !v133 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v133, 1.5, 0.0, 4.0, 0, 0LL);
			//   this.fields.highlightThickness = v134;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.highlightThickness, v135, v136, v137, overrideStatebe, methodbf);
			//   v138 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v139 = v138;
			//   if ( !v138 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v138, 12.0, 0.0099999998, 20.0, 0, 0LL);
			//   this.fields.maxDetectionDistance = v139;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.maxDetectionDistance, v140, v141, v142, overrideStatebf, methodbg);
			//   v143 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v144 = v143;
			//   if ( !v143 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v143, 20.0, 1.0, 500.0, 0, 0LL);
			//   this.fields.boxDistMin = v144;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.boxDistMin, v145, v146, v147, overrideStatebg, methodbh);
			//   v148 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v149 = v148;
			//   if ( !v148 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v148, 50.0, 1.0, 500.0, 0, 0LL);
			//   this.fields.boxDistMid = v149;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.boxDistMid, v150, v151, v152, overrideStatebh, methodbi);
			//   v153 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v154 = v153;
			//   if ( !v153 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v153, 80.0, 1.0, 500.0, 0, 0LL);
			//   this.fields.boxDistMax = v154;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.boxDistMax, v155, v156, v157, overrideStatebi, methodbj);
			//   v158 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v159 = v158;
			//   if ( !v158 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v158, 1.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.headHeight = v159;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.headHeight, v160, v161, v162, overrideStatebj, methodbk);
			//   v163 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v164 = v163;
			//   if ( !v163 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v163, 1.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.tailHeight = v164;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.tailHeight, v165, v166, v167, overrideStatebk, methodbl);
			//   v168 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v169 = v168;
			//   if ( !v168 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v168, 1.0, 0.0, 1.5, 0, 0LL);
			//   this.fields.headAlpha = v169;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.headAlpha, v170, v171, v172, overrideStatebl, methodbm);
			//   v173 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v174 = v173;
			//   if ( !v173 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v173, 1.0, 0.0, 1.5, 0, 0LL);
			//   this.fields.tailAlpha = v174;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.tailAlpha, v175, v176, v177, overrideStatebm, methodbn);
			//   v178 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v179 = v178;
			//   if ( !v178 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v178, 0.0, -5.0, 5.0, 0, 0LL);
			//   this.fields.flowingSpeed = v179;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.flowingSpeed, v180, v181, v182, overrideStatebn, methodbo);
			//   v183 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v184 = v183;
			//   if ( !v183 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v183, 0.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.flowingStrength = v184;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.flowingStrength, v185, v186, v187, overrideStatebo, methodbp);
			//   v188 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v189 = v188;
			//   if ( !v188 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v188, 1.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.nearHighlight = v189;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.nearHighlight, v190, v191, v192, overrideStatebp, methodbq);
			//   v193 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v194 = v193;
			//   if ( !v193 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v193, 1.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.farHighlight = v194;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.farHighlight, v195, v196, v197, overrideStatebq, methodbr);
			//   v198 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v199 = v198;
			//   if ( !v198 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v198, 1.0, 1.0, 10.0, 0, 0LL);
			//   this.fields.midBloom = v199;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.midBloom, v200, v201, v202, overrideStatebr, methodbs);
			//   v203 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v204 = v203;
			//   if ( !v203 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v203, 1.0, 1.0, 10.0, 0, 0LL);
			//   this.fields.maxBloom = v204;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.maxBloom, v205, v206, v207, overrideStatebs, methodbt);
			//   v208 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v209 = v208;
			//   if ( !v208 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v208, 12.0, 0.0099999998, 20.0, 0, 0LL);
			//   this.fields.maxDetectionDistanceHL = v209;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.maxDetectionDistanceHL, v210, v211, v212, overrideStatebt, methodbu);
			//   v213 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v214 = v213;
			//   if ( !v213 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v213, 0.44999999, 0.0099999998, 1.0, 0, 0LL);
			//   this.fields.minHeight = v214;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.minHeight, v215, v216, v217, overrideStatebu, methodbv);
			//   v218 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v219 = v218;
			//   if ( !v218 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v218, 0.64999998, 0.0099999998, 1.0, 0, 0LL);
			//   this.fields.midHeight = v219;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.midHeight, v220, v221, v222, overrideStatebv, methodbw);
			//   v223 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v224 = v223;
			//   if ( !v223 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v223, 0.94999999, 0.0099999998, 1.0, 0, 0LL);
			//   this.fields.maxHeight = v224;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.maxHeight, v225, v226, v227, overrideStatebw, methodbx);
			//   v228 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v229 = v228;
			//   if ( !v228 )
			//     goto LABEL_70;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v228, 1.0, 1.0, 5.0, 0, 0LL);
			//   this.fields.meshHeight = v229;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.meshHeight, v230, v231, v232, overrideStatebx, methodby);
			//   v234 = *UnityEngine::Vector4::get_one((Vector4 *)&v361, v233);
			//   v235 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v235 )
			//     goto LABEL_70;
			//   if ( !byte_18D8F3661 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3661 = 1;
			//   }
			//   *(Vector4 *)(v235 + 24) = v234;
			//   *(_WORD *)(v235 + 40) = 0;
			//   *(_BYTE *)(v235 + 42) = 1;
			//   *(_BYTE *)(v235 + 16) = 0;
			//   this.fields.colorHighlight = (ColorParameter *)v235;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.colorHighlight, v4, v236, v237, overrideStateg, methodh);
			//   v239 = *UnityEngine::Vector4::get_one((Vector4 *)&v361, v238);
			//   v240 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v240 )
			//     goto LABEL_70;
			//   if ( !byte_18D8F3661 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3661 = 1;
			//   }
			//   *(Vector4 *)(v240 + 24) = v239;
			//   *(_WORD *)(v240 + 40) = 0;
			//   *(_BYTE *)(v240 + 42) = 1;
			//   *(_BYTE *)(v240 + 16) = 0;
			//   this.fields.colorHighlightBeam = (ColorParameter *)v240;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.colorHighlightBeam, v4, v241, v242, overrideStateh, methodi);
			//   v243 = sub_180004920(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
			//   if ( !v243 )
			//     goto LABEL_70;
			//   if ( !byte_18D8F3664 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector4>::VolumeParameter);
			//     byte_18D8F3664 = 1;
			//   }
			//   *(_OWORD *)(v243 + 24) = 0LL;
			//   *(_BYTE *)(v243 + 16) = 0;
			//   this.fields.boxPosition1 = (Vector4Parameter *)v243;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.boxPosition1, v4, v244, v245, overrideStatei, methodj);
			//   v246 = sub_180004920(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
			//   if ( !v246 )
			//     goto LABEL_70;
			//   if ( !byte_18D8F3664 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector4>::VolumeParameter);
			//     byte_18D8F3664 = 1;
			//   }
			//   *(_OWORD *)(v246 + 24) = 0LL;
			//   *(_BYTE *)(v246 + 16) = 0;
			//   this.fields.boxPosition2 = (Vector4Parameter *)v246;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.boxPosition2, v4, v247, v248, overrideStatej, methodk);
			//   v249 = sub_180004920(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
			//   if ( !v249 )
			//     goto LABEL_70;
			//   if ( !byte_18D8F3664 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector4>::VolumeParameter);
			//     byte_18D8F3664 = 1;
			//   }
			//   *(_OWORD *)(v249 + 24) = 0LL;
			//   *(_BYTE *)(v249 + 16) = 0;
			//   this.fields.boxPosition3 = (Vector4Parameter *)v249;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.boxPosition3, v4, v250, v251, overrideStatek, methodl);
			//   v252 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v253 = v252;
			//   if ( !v252 )
			// LABEL_70:
			//     sub_180B536AC(v5, v4);
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v252, 0.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.ignorePostExposure = v253;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.ignorePostExposure, v254, v255, v256, overrideStateby, methodbz);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::HGScanLine::IsActive(HGScanLine *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   int *wrapperArray; // rdx
			//   bool result; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = (int *)v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_10;
			//   if ( wrapperArray[6] > 2130 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( !v3 )
			//       goto LABEL_10;
			//     if ( LODWORD(v3._0.namespaze) <= 0x852 )
			//       sub_180070270(v3, wrapperArray);
			//     if ( v3[45]._0.methods )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(2130, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//       goto LABEL_10;
			//     }
			//   }
			//   wrapperArray = (int *)this.fields.enabled;
			//   if ( !wrapperArray )
			//     goto LABEL_10;
			//   result = sub_1800023D0(10LL, wrapperArray);
			//   if ( result )
			//   {
			//     wrapperArray = (int *)this.fields.interval;
			//     if ( wrapperArray )
			//       return sub_18003F9B0(10LL, wrapperArray) > 0.0;
			// LABEL_10:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			//   return result;
			// }
			// 
			return default(bool);
		}

		public BoolParameter enabled;

		public Vector4Parameter centerPos;

		public ClampedFloatParameter progress;

		public ColorParameter color;

		public ClampedFloatParameter angleBlendFallOff;

		public BoolParameter useMaskTex;

		public Texture2DParameter maskTex;

		public Vector2Parameter maskTexTiling;

		public Vector2Parameter maskTexOffset;

		public ClampedFloatParameter interval;

		public ClampedFloatParameter width;

		public ClampedFloatParameter maxDistance;

		public ClampedFloatParameter minDistance;

		public ClampedFloatParameter smoothness;

		public ClampedFloatParameter maxFade;

		public ClampedFloatParameter distortScale;

		public ClampedFloatParameter charDistortScale;

		public ClampedFloatParameter distortIntensity;

		public ClampedFloatParameter charBrightIntensity;

		public ClampedFloatParameter charDistortIntensity;

		public ClampedFloatParameter charDistortOnEdge;

		public ClampedFloatParameter charDistortOuter;

		public ClampedFloatParameter distortSpeed;

		public ClampedFloatParameter charDistortSpeed;

		public ClampedFloatParameter highlightFading;

		public ClampedFloatParameter highlightWidth;

		public ClampedFloatParameter highlightThickness;

		public ClampedFloatParameter maxDetectionDistance;

		public ClampedFloatParameter boxDistMin;

		public ClampedFloatParameter boxDistMid;

		public ClampedFloatParameter boxDistMax;

		public ClampedFloatParameter headHeight;

		public ClampedFloatParameter tailHeight;

		public ClampedFloatParameter headAlpha;

		public ClampedFloatParameter tailAlpha;

		public ClampedFloatParameter flowingSpeed;

		public ClampedFloatParameter flowingStrength;

		public ClampedFloatParameter nearHighlight;

		public ClampedFloatParameter farHighlight;

		public ClampedFloatParameter midBloom;

		public ClampedFloatParameter maxBloom;

		public ClampedFloatParameter maxDetectionDistanceHL;

		public ClampedFloatParameter minHeight;

		public ClampedFloatParameter midHeight;

		public ClampedFloatParameter maxHeight;

		public ClampedFloatParameter meshHeight;

		public ColorParameter colorHighlight;

		public ColorParameter colorHighlightBeam;

		public Vector4Parameter boxPosition1;

		public Vector4Parameter boxPosition2;

		public Vector4Parameter boxPosition3;

		public ClampedFloatParameter ignorePostExposure;
	}
}
