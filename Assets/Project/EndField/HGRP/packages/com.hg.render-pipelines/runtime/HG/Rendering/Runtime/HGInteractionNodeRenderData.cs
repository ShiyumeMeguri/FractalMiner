using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct HGInteractionNodeRenderData
	{
		public static int Sorter(HGInteractionNodeRenderData a, HGInteractionNodeRenderData b)
		{
			// // Int32 Sorter(HGInteractionNodeRenderData, HGInteractionNodeRenderData)
			// int32_t HG::Rendering::Runtime::HGInteractionNodeRenderData::Sorter(
			//         HGInteractionNodeRenderData *a,
			//         HGInteractionNodeRenderData *b,
			//         MethodInfo *method)
			// {
			//   __int128 v5; // xmm1
			//   __int128 v6; // xmm0
			//   __int128 v7; // xmm1
			//   __int128 v8; // xmm0
			//   __int128 v9; // xmm1
			//   __int128 v10; // xmm0
			//   __int128 v11; // xmm1
			//   __int128 v12; // xmm0
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   __int128 v15; // xmm1
			//   __int128 v16; // xmm0
			//   __int128 v17; // xmm1
			//   __int128 v18; // xmm0
			//   __int128 v19; // xmm1
			//   __int128 v20; // xmm0
			//   __int128 v21; // xmm1
			//   __int128 v22; // xmm0
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   __int128 v29; // xmm1
			//   __int128 v30; // xmm0
			//   __int128 v31; // xmm1
			//   __int128 v32; // xmm0
			//   __int64 v33; // rdx
			//   __int128 v34; // xmm1
			//   __int128 v35; // xmm0
			//   __int128 v36; // xmm1
			//   __int128 v37; // xmm0
			//   __int128 v38; // xmm1
			//   __int128 v39; // xmm0
			//   __int128 v40; // xmm1
			//   __int128 v41; // xmm0
			//   __int128 v42; // xmm1
			//   __int128 v43; // xmm0
			//   __int128 v44; // xmm1
			//   __int128 v45; // xmm0
			//   __int128 v46; // xmm1
			//   __int128 v47; // xmm0
			//   __int128 v48; // xmm1
			//   __int128 v49; // xmm0
			//   __int128 v50; // xmm1
			//   __int128 v51; // xmm0
			//   __int128 v52; // xmm1
			//   __int128 v53; // xmm0
			//   __int128 v54; // xmm1
			//   __int128 v55; // xmm0
			//   __int128 v56; // xmm1
			//   __int128 v57; // xmm0
			//   __int128 v58; // xmm1
			//   __int128 v59; // xmm0
			//   __int128 v60; // xmm1
			//   __int128 v61; // xmm0
			//   __int128 v62; // xmm1
			//   __int128 v63; // xmm0
			//   __int128 v64; // xmm1
			//   __int128 v65; // xmm0
			//   __int128 v66; // xmm1
			//   __int128 v67; // xmm0
			//   __int128 v68; // xmm1
			//   __int128 v69; // xmm0
			//   __int128 v70; // xmm1
			//   __int128 v71; // xmm0
			//   __int128 v72; // xmm1
			//   __int128 v73; // xmm0
			//   __int128 v74; // xmm1
			//   __int128 v75; // xmm0
			//   __int128 v76; // xmm1
			//   __int128 v77; // xmm0
			//   __int128 v78; // xmm1
			//   __int128 v79; // xmm0
			//   __int128 v80; // xmm1
			//   __int128 v81; // xmm0
			//   __int128 v82; // xmm1
			//   __int128 v83; // xmm0
			//   __int128 v84; // xmm1
			//   __int128 v85; // xmm0
			//   __int128 v86; // xmm1
			//   __int128 v87; // xmm0
			//   __int128 v88; // xmm1
			//   __int128 v89; // xmm0
			//   __int128 v91; // xmm1
			//   __int128 v92; // xmm0
			//   __int128 v93; // xmm1
			//   __int128 v94; // xmm0
			//   __int128 v95; // xmm1
			//   __int128 v96; // xmm0
			//   __int128 v97; // xmm1
			//   Matrix4x4 *v98; // rbx
			//   __int128 v99; // xmm0
			//   __int128 v100; // xmm1
			//   __int128 v101; // xmm0
			//   __int128 v102; // xmm1
			//   __int128 v103; // xmm0
			//   __int128 v104; // xmm1
			//   __int128 v105; // xmm0
			//   __int128 v106; // xmm1
			//   __int128 v107; // xmm0
			//   __int128 v108; // xmm1
			//   __int128 v109; // xmm0
			//   __int128 v110; // xmm1
			//   __int128 v111; // xmm0
			//   __int128 v112; // xmm1
			//   Matrix4x4 *v113; // rdi
			//   __int128 v114; // xmm0
			//   __int128 v115; // xmm1
			//   __int128 v116; // xmm0
			//   __int128 v117; // xmm1
			//   __int128 v118; // xmm0
			//   __int128 v119; // xmm1
			//   __int128 v120; // xmm0
			//   __int128 v121; // xmm1
			//   __int128 v122; // xmm0
			//   __int128 v123; // xmm1
			//   __int128 v124; // xmm0
			//   __int128 v125; // xmm1
			//   __int128 v126; // xmm0
			//   __int128 v127; // xmm1
			//   Matrix4x4 *v128; // rbx
			//   __int128 v129; // xmm0
			//   __int128 v130; // xmm1
			//   __int128 v131; // xmm0
			//   __int128 v132; // xmm1
			//   __int128 v133; // xmm0
			//   __int128 v134; // xmm1
			//   __int128 v135; // xmm0
			//   __int128 v136; // xmm1
			//   __int128 v137; // xmm0
			//   __int128 v138; // xmm1
			//   __int128 v139; // xmm0
			//   __int128 v140; // xmm1
			//   __int128 v141; // xmm0
			//   __int128 v142; // xmm1
			//   Matrix4x4 *v143; // rbx
			//   __int128 v144; // xmm0
			//   __int128 v145; // xmm1
			//   __int128 v146; // xmm0
			//   __int128 v147; // xmm1
			//   __int128 v148; // xmm0
			//   __int128 v149; // xmm1
			//   __int128 v150; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   int32_t InstanceID; // ebx
			//   __int128 v153; // xmm1
			//   __int128 v154; // xmm0
			//   __int128 v155; // xmm1
			//   __int128 v156; // xmm0
			//   __int128 v157; // xmm1
			//   __int128 v158; // xmm0
			//   __int128 v159; // xmm1
			//   Matrix4x4 *v160; // rdi
			//   __int128 v161; // xmm0
			//   __int128 v162; // xmm1
			//   __int128 v163; // xmm0
			//   __int128 v164; // xmm1
			//   __int128 v165; // xmm0
			//   __int128 v166; // xmm1
			//   __int128 v167; // xmm0
			//   __int128 v168; // xmm1
			//   __int128 v169; // xmm0
			//   __int128 v170; // xmm1
			//   __int128 v171; // xmm0
			//   __int128 v172; // xmm1
			//   __int128 v173; // xmm0
			//   __int128 v174; // xmm0
			//   Matrix4x4 *p_prevLocalToWorld; // rbx
			//   __int128 v176; // xmm0
			//   __int128 v177; // xmm1
			//   __int128 v178; // xmm0
			//   __int128 v179; // xmm1
			//   __int128 v180; // xmm0
			//   __int128 v181; // xmm1
			//   __int128 v182; // xmm0
			//   __int128 v183; // xmm1
			//   __int128 v184; // xmm0
			//   __int128 v185; // xmm1
			//   __int128 v186; // xmm0
			//   __int128 v187; // xmm1
			//   __int128 v188; // xmm0
			//   __int128 v189; // xmm1
			//   Matrix4x4 *v190; // rdi
			//   __int128 v191; // xmm0
			//   __int128 v192; // xmm1
			//   __int128 v193; // xmm0
			//   __int128 v194; // xmm1
			//   __int128 v195; // xmm0
			//   __int128 v196; // xmm1
			//   __int128 v197; // xmm0
			//   HGInteractionNodeRenderData v198; // [rsp+28h] [rbp-E0h] BYREF
			//   HGInteractionNodeRenderData v199; // [rsp+118h] [rbp+10h] BYREF
			// 
			//   if ( !byte_18D919E0C )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919E0C = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1522, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1522, 0LL);
			//     if ( Patch )
			//     {
			//       v168 = *(_OWORD *)&b.instanceData.localToWorld.m01;
			//       *(_OWORD *)&v198.instanceData.localToWorld.m00 = *(_OWORD *)&b.instanceData.localToWorld.m00;
			//       v169 = *(_OWORD *)&b.instanceData.localToWorld.m02;
			//       *(_OWORD *)&v198.instanceData.localToWorld.m01 = v168;
			//       v170 = *(_OWORD *)&b.instanceData.localToWorld.m03;
			//       *(_OWORD *)&v198.instanceData.localToWorld.m02 = v169;
			//       v171 = *(_OWORD *)&b.instanceData.worldToLocal.m00;
			//       *(_OWORD *)&v198.instanceData.localToWorld.m03 = v170;
			//       v172 = *(_OWORD *)&b.instanceData.worldToLocal.m01;
			//       *(_OWORD *)&v198.instanceData.worldToLocal.m00 = v171;
			//       v173 = *(_OWORD *)&b.instanceData.worldToLocal.m02;
			//       *(_OWORD *)&v198.instanceData.worldToLocal.m01 = v172;
			//       *(_OWORD *)&v198.instanceData.worldToLocal.m02 = v173;
			//       v174 = *(_OWORD *)&b.instanceData.worldToLocal.m03;
			//       p_prevLocalToWorld = &b.instanceData.prevLocalToWorld;
			//       *(_OWORD *)&v198.instanceData.worldToLocal.m03 = v174;
			//       v176 = *(_OWORD *)&p_prevLocalToWorld.m01;
			//       *(_OWORD *)&v198.instanceData.prevLocalToWorld.m00 = *(_OWORD *)&p_prevLocalToWorld.m00;
			//       v177 = *(_OWORD *)&p_prevLocalToWorld.m02;
			//       *(_OWORD *)&v198.instanceData.prevLocalToWorld.m01 = v176;
			//       v178 = *(_OWORD *)&p_prevLocalToWorld.m03;
			//       *(_OWORD *)&v198.instanceData.prevLocalToWorld.m02 = v177;
			//       v179 = *(_OWORD *)&p_prevLocalToWorld[1].m00;
			//       *(_OWORD *)&v198.instanceData.prevLocalToWorld.m03 = v178;
			//       v180 = *(_OWORD *)&p_prevLocalToWorld[1].m01;
			//       *(_OWORD *)&v198.instanceData.radius = v179;
			//       v181 = *(_OWORD *)&p_prevLocalToWorld[1].m02;
			//       *(_OWORD *)&v198.instanceData.groundHeight = v180;
			//       v182 = *(_OWORD *)&a.instanceData.localToWorld.m00;
			//       *(_OWORD *)&v198.mesh = v181;
			//       v183 = *(_OWORD *)&a.instanceData.localToWorld.m01;
			//       *(_OWORD *)&v199.instanceData.localToWorld.m00 = v182;
			//       v184 = *(_OWORD *)&a.instanceData.localToWorld.m02;
			//       *(_OWORD *)&v199.instanceData.localToWorld.m01 = v183;
			//       v185 = *(_OWORD *)&a.instanceData.localToWorld.m03;
			//       *(_OWORD *)&v199.instanceData.localToWorld.m02 = v184;
			//       v186 = *(_OWORD *)&a.instanceData.worldToLocal.m00;
			//       *(_OWORD *)&v199.instanceData.localToWorld.m03 = v185;
			//       v187 = *(_OWORD *)&a.instanceData.worldToLocal.m01;
			//       *(_OWORD *)&v199.instanceData.worldToLocal.m00 = v186;
			//       v188 = *(_OWORD *)&a.instanceData.worldToLocal.m02;
			//       *(_OWORD *)&v199.instanceData.worldToLocal.m01 = v187;
			//       v189 = *(_OWORD *)&a.instanceData.worldToLocal.m03;
			//       v190 = &a.instanceData.prevLocalToWorld;
			//       *(_OWORD *)&v199.instanceData.worldToLocal.m02 = v188;
			//       v191 = *(_OWORD *)&v190.m00;
			//       *(_OWORD *)&v199.instanceData.worldToLocal.m03 = v189;
			//       v192 = *(_OWORD *)&v190.m01;
			//       *(_OWORD *)&v199.instanceData.prevLocalToWorld.m00 = v191;
			//       v193 = *(_OWORD *)&v190.m02;
			//       *(_OWORD *)&v199.instanceData.prevLocalToWorld.m01 = v192;
			//       v194 = *(_OWORD *)&v190.m03;
			//       *(_OWORD *)&v199.instanceData.prevLocalToWorld.m02 = v193;
			//       v195 = *(_OWORD *)&v190[1].m00;
			//       *(_OWORD *)&v199.instanceData.prevLocalToWorld.m03 = v194;
			//       v196 = *(_OWORD *)&v190[1].m01;
			//       *(_OWORD *)&v199.instanceData.radius = v195;
			//       v197 = *(_OWORD *)&v190[1].m02;
			//       *(_OWORD *)&v199.instanceData.groundHeight = v196;
			//       *(_OWORD *)&v199.mesh = v197;
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_582(Patch, &v199, &v198, 0LL);
			//     }
			// LABEL_14:
			//     sub_180B536AC(Patch, v33);
			//   }
			//   v5 = *(_OWORD *)&a.instanceData.localToWorld.m01;
			//   *(_OWORD *)&v198.instanceData.localToWorld.m00 = *(_OWORD *)&a.instanceData.localToWorld.m00;
			//   v6 = *(_OWORD *)&a.instanceData.localToWorld.m02;
			//   *(_OWORD *)&v198.instanceData.localToWorld.m01 = v5;
			//   v7 = *(_OWORD *)&a.instanceData.localToWorld.m03;
			//   *(_OWORD *)&v198.instanceData.localToWorld.m02 = v6;
			//   v8 = *(_OWORD *)&a.instanceData.worldToLocal.m00;
			//   *(_OWORD *)&v198.instanceData.localToWorld.m03 = v7;
			//   v9 = *(_OWORD *)&a.instanceData.worldToLocal.m01;
			//   *(_OWORD *)&v198.instanceData.worldToLocal.m00 = v8;
			//   v10 = *(_OWORD *)&a.instanceData.worldToLocal.m02;
			//   *(_OWORD *)&v198.instanceData.worldToLocal.m01 = v9;
			//   v11 = *(_OWORD *)&a.instanceData.prevLocalToWorld.m00;
			//   *(_OWORD *)&v198.instanceData.worldToLocal.m02 = v10;
			//   *(_OWORD *)&v198.instanceData.worldToLocal.m03 = *(_OWORD *)&a.instanceData.worldToLocal.m03;
			//   v12 = *(_OWORD *)&a.instanceData.prevLocalToWorld.m01;
			//   *(_OWORD *)&v198.instanceData.prevLocalToWorld.m00 = v11;
			//   v13 = *(_OWORD *)&a.instanceData.prevLocalToWorld.m02;
			//   *(_OWORD *)&v198.instanceData.prevLocalToWorld.m01 = v12;
			//   v14 = *(_OWORD *)&a.instanceData.prevLocalToWorld.m03;
			//   *(_OWORD *)&v198.instanceData.prevLocalToWorld.m02 = v13;
			//   v15 = *(_OWORD *)&a.instanceData.radius;
			//   *(_OWORD *)&v198.instanceData.prevLocalToWorld.m03 = v14;
			//   v16 = *(_OWORD *)&a.instanceData.groundHeight;
			//   *(_OWORD *)&v198.instanceData.radius = v15;
			//   v17 = *(_OWORD *)&a.mesh;
			//   *(_OWORD *)&v198.instanceData.groundHeight = v16;
			//   v18 = *(_OWORD *)&b.instanceData.localToWorld.m00;
			//   *(_OWORD *)&v198.mesh = v17;
			//   v19 = *(_OWORD *)&b.instanceData.localToWorld.m01;
			//   *(_OWORD *)&v199.instanceData.localToWorld.m00 = v18;
			//   v20 = *(_OWORD *)&b.instanceData.localToWorld.m02;
			//   *(_OWORD *)&v199.instanceData.localToWorld.m01 = v19;
			//   v21 = *(_OWORD *)&b.instanceData.localToWorld.m03;
			//   *(_OWORD *)&v199.instanceData.localToWorld.m02 = v20;
			//   v22 = *(_OWORD *)&b.instanceData.worldToLocal.m00;
			//   *(_OWORD *)&v199.instanceData.localToWorld.m03 = v21;
			//   v23 = *(_OWORD *)&b.instanceData.worldToLocal.m01;
			//   *(_OWORD *)&v199.instanceData.worldToLocal.m00 = v22;
			//   v24 = *(_OWORD *)&b.instanceData.worldToLocal.m02;
			//   *(_OWORD *)&v199.instanceData.worldToLocal.m01 = v23;
			//   v25 = *(_OWORD *)&b.instanceData.worldToLocal.m03;
			//   *(_OWORD *)&v199.instanceData.worldToLocal.m02 = v24;
			//   v26 = *(_OWORD *)&b.instanceData.prevLocalToWorld.m00;
			//   *(_OWORD *)&v199.instanceData.worldToLocal.m03 = v25;
			//   v27 = *(_OWORD *)&b.instanceData.prevLocalToWorld.m01;
			//   *(_OWORD *)&v199.instanceData.prevLocalToWorld.m00 = v26;
			//   v28 = *(_OWORD *)&b.instanceData.prevLocalToWorld.m02;
			//   *(_OWORD *)&v199.instanceData.prevLocalToWorld.m01 = v27;
			//   v29 = *(_OWORD *)&b.instanceData.prevLocalToWorld.m03;
			//   *(_OWORD *)&v199.instanceData.prevLocalToWorld.m02 = v28;
			//   v30 = *(_OWORD *)&b.instanceData.radius;
			//   *(_OWORD *)&v199.instanceData.prevLocalToWorld.m03 = v29;
			//   v31 = *(_OWORD *)&b.instanceData.groundHeight;
			//   *(_OWORD *)&v199.instanceData.radius = v30;
			//   v32 = *(_OWORD *)&b.mesh;
			//   *(_OWORD *)&v199.instanceData.groundHeight = v31;
			//   *(_OWORD *)&v199.mesh = v32;
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( UnityEngine::Object::op_Inequality((Object_1 *)v198.mesh, (Object_1 *)v199.mesh, 0LL) )
			//   {
			//     v136 = *(_OWORD *)&b.instanceData.localToWorld.m01;
			//     *(_OWORD *)&v198.instanceData.localToWorld.m00 = *(_OWORD *)&b.instanceData.localToWorld.m00;
			//     v137 = *(_OWORD *)&b.instanceData.localToWorld.m02;
			//     *(_OWORD *)&v198.instanceData.localToWorld.m01 = v136;
			//     v138 = *(_OWORD *)&b.instanceData.localToWorld.m03;
			//     *(_OWORD *)&v198.instanceData.localToWorld.m02 = v137;
			//     v139 = *(_OWORD *)&b.instanceData.worldToLocal.m00;
			//     *(_OWORD *)&v198.instanceData.localToWorld.m03 = v138;
			//     v140 = *(_OWORD *)&b.instanceData.worldToLocal.m01;
			//     *(_OWORD *)&v198.instanceData.worldToLocal.m00 = v139;
			//     v141 = *(_OWORD *)&b.instanceData.worldToLocal.m02;
			//     *(_OWORD *)&v198.instanceData.worldToLocal.m01 = v140;
			//     v142 = *(_OWORD *)&b.instanceData.worldToLocal.m03;
			//     v143 = &b.instanceData.prevLocalToWorld;
			//     *(_OWORD *)&v198.instanceData.worldToLocal.m02 = v141;
			//     v144 = *(_OWORD *)&v143.m00;
			//     *(_OWORD *)&v198.instanceData.worldToLocal.m03 = v142;
			//     v145 = *(_OWORD *)&v143.m01;
			//     *(_OWORD *)&v198.instanceData.prevLocalToWorld.m00 = v144;
			//     v146 = *(_OWORD *)&v143.m02;
			//     *(_OWORD *)&v198.instanceData.prevLocalToWorld.m01 = v145;
			//     v147 = *(_OWORD *)&v143.m03;
			//     *(_OWORD *)&v198.instanceData.prevLocalToWorld.m02 = v146;
			//     v148 = *(_OWORD *)&v143[1].m00;
			//     *(_OWORD *)&v198.instanceData.prevLocalToWorld.m03 = v147;
			//     v149 = *(_OWORD *)&v143[1].m01;
			//     *(_OWORD *)&v198.instanceData.radius = v148;
			//     v150 = *(_OWORD *)&v143[1].m02;
			//     *(_OWORD *)&v198.instanceData.groundHeight = v149;
			//     *(_OWORD *)&v198.mesh = v150;
			//     Patch = (ILFixDynamicMethodWrapper_2 *)v150;
			//     if ( (_QWORD)v150 )
			//     {
			//       InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)v150, 0LL);
			//       v153 = *(_OWORD *)&a.instanceData.localToWorld.m01;
			//       *(_OWORD *)&v198.instanceData.localToWorld.m00 = *(_OWORD *)&a.instanceData.localToWorld.m00;
			//       v154 = *(_OWORD *)&a.instanceData.localToWorld.m02;
			//       *(_OWORD *)&v198.instanceData.localToWorld.m01 = v153;
			//       v155 = *(_OWORD *)&a.instanceData.localToWorld.m03;
			//       *(_OWORD *)&v198.instanceData.localToWorld.m02 = v154;
			//       v156 = *(_OWORD *)&a.instanceData.worldToLocal.m00;
			//       *(_OWORD *)&v198.instanceData.localToWorld.m03 = v155;
			//       v157 = *(_OWORD *)&a.instanceData.worldToLocal.m01;
			//       *(_OWORD *)&v198.instanceData.worldToLocal.m00 = v156;
			//       v158 = *(_OWORD *)&a.instanceData.worldToLocal.m02;
			//       *(_OWORD *)&v198.instanceData.worldToLocal.m01 = v157;
			//       v159 = *(_OWORD *)&a.instanceData.worldToLocal.m03;
			//       v160 = &a.instanceData.prevLocalToWorld;
			//       *(_OWORD *)&v198.instanceData.worldToLocal.m02 = v158;
			//       v161 = *(_OWORD *)&v160.m00;
			//       *(_OWORD *)&v198.instanceData.worldToLocal.m03 = v159;
			//       v162 = *(_OWORD *)&v160.m01;
			//       *(_OWORD *)&v198.instanceData.prevLocalToWorld.m00 = v161;
			//       v163 = *(_OWORD *)&v160.m02;
			//       *(_OWORD *)&v198.instanceData.prevLocalToWorld.m01 = v162;
			//       v164 = *(_OWORD *)&v160.m03;
			//       *(_OWORD *)&v198.instanceData.prevLocalToWorld.m02 = v163;
			//       v165 = *(_OWORD *)&v160[1].m00;
			//       *(_OWORD *)&v198.instanceData.prevLocalToWorld.m03 = v164;
			//       v166 = *(_OWORD *)&v160[1].m01;
			//       *(_OWORD *)&v198.instanceData.radius = v165;
			//       v167 = *(_OWORD *)&v160[1].m02;
			//       *(_OWORD *)&v198.instanceData.groundHeight = v166;
			//       *(_OWORD *)&v198.mesh = v167;
			//       Patch = (ILFixDynamicMethodWrapper_2 *)v167;
			//       if ( (_QWORD)v167 )
			//         return InstanceID - UnityEngine::Object::GetInstanceID((Object_1 *)v167, 0LL);
			//     }
			//     goto LABEL_14;
			//   }
			//   v34 = *(_OWORD *)&a.instanceData.localToWorld.m01;
			//   *(_OWORD *)&v199.instanceData.localToWorld.m00 = *(_OWORD *)&a.instanceData.localToWorld.m00;
			//   v35 = *(_OWORD *)&a.instanceData.localToWorld.m02;
			//   *(_OWORD *)&v199.instanceData.localToWorld.m01 = v34;
			//   v36 = *(_OWORD *)&a.instanceData.localToWorld.m03;
			//   *(_OWORD *)&v199.instanceData.localToWorld.m02 = v35;
			//   v37 = *(_OWORD *)&a.instanceData.worldToLocal.m00;
			//   *(_OWORD *)&v199.instanceData.localToWorld.m03 = v36;
			//   v38 = *(_OWORD *)&a.instanceData.worldToLocal.m01;
			//   *(_OWORD *)&v199.instanceData.worldToLocal.m00 = v37;
			//   v39 = *(_OWORD *)&a.instanceData.worldToLocal.m02;
			//   *(_OWORD *)&v199.instanceData.worldToLocal.m01 = v38;
			//   v40 = *(_OWORD *)&a.instanceData.worldToLocal.m03;
			//   *(_OWORD *)&v199.instanceData.worldToLocal.m02 = v39;
			//   v41 = *(_OWORD *)&a.instanceData.prevLocalToWorld.m00;
			//   *(_OWORD *)&v199.instanceData.worldToLocal.m03 = v40;
			//   v42 = *(_OWORD *)&a.instanceData.prevLocalToWorld.m01;
			//   *(_OWORD *)&v199.instanceData.prevLocalToWorld.m00 = v41;
			//   v43 = *(_OWORD *)&a.instanceData.prevLocalToWorld.m02;
			//   *(_OWORD *)&v199.instanceData.prevLocalToWorld.m01 = v42;
			//   v44 = *(_OWORD *)&a.instanceData.prevLocalToWorld.m03;
			//   *(_OWORD *)&v199.instanceData.prevLocalToWorld.m02 = v43;
			//   v45 = *(_OWORD *)&a.instanceData.radius;
			//   *(_OWORD *)&v199.instanceData.prevLocalToWorld.m03 = v44;
			//   v46 = *(_OWORD *)&a.instanceData.groundHeight;
			//   *(_OWORD *)&v199.instanceData.radius = v45;
			//   v47 = *(_OWORD *)&a.mesh;
			//   *(_OWORD *)&v199.instanceData.groundHeight = v46;
			//   v48 = *(_OWORD *)&b.instanceData.localToWorld.m01;
			//   *(_OWORD *)&v199.mesh = v47;
			//   *(_OWORD *)&v198.instanceData.localToWorld.m00 = *(_OWORD *)&b.instanceData.localToWorld.m00;
			//   v49 = *(_OWORD *)&b.instanceData.localToWorld.m02;
			//   *(_OWORD *)&v198.instanceData.localToWorld.m01 = v48;
			//   v50 = *(_OWORD *)&b.instanceData.localToWorld.m03;
			//   *(_OWORD *)&v198.instanceData.localToWorld.m02 = v49;
			//   v51 = *(_OWORD *)&b.instanceData.worldToLocal.m00;
			//   *(_OWORD *)&v198.instanceData.localToWorld.m03 = v50;
			//   v52 = *(_OWORD *)&b.instanceData.worldToLocal.m01;
			//   *(_OWORD *)&v198.instanceData.worldToLocal.m00 = v51;
			//   v53 = *(_OWORD *)&b.instanceData.worldToLocal.m02;
			//   *(_OWORD *)&v198.instanceData.worldToLocal.m01 = v52;
			//   v54 = *(_OWORD *)&b.instanceData.worldToLocal.m03;
			//   *(_OWORD *)&v198.instanceData.worldToLocal.m02 = v53;
			//   v55 = *(_OWORD *)&b.instanceData.prevLocalToWorld.m00;
			//   *(_OWORD *)&v198.instanceData.worldToLocal.m03 = v54;
			//   v56 = *(_OWORD *)&b.instanceData.prevLocalToWorld.m01;
			//   *(_OWORD *)&v198.instanceData.prevLocalToWorld.m00 = v55;
			//   v57 = *(_OWORD *)&b.instanceData.prevLocalToWorld.m02;
			//   *(_OWORD *)&v198.instanceData.prevLocalToWorld.m01 = v56;
			//   v58 = *(_OWORD *)&b.instanceData.prevLocalToWorld.m03;
			//   *(_OWORD *)&v198.instanceData.prevLocalToWorld.m02 = v57;
			//   v59 = *(_OWORD *)&b.instanceData.radius;
			//   *(_OWORD *)&v198.instanceData.prevLocalToWorld.m03 = v58;
			//   v60 = *(_OWORD *)&b.instanceData.groundHeight;
			//   *(_OWORD *)&v198.instanceData.radius = v59;
			//   v61 = *(_OWORD *)&b.mesh;
			//   *(_OWORD *)&v198.instanceData.groundHeight = v60;
			//   *(_OWORD *)&v198.mesh = v61;
			//   if ( v199.ccdKeyword == BYTE12(v61) )
			//   {
			//     v62 = *(_OWORD *)&a.instanceData.localToWorld.m01;
			//     *(_OWORD *)&v199.instanceData.localToWorld.m00 = *(_OWORD *)&a.instanceData.localToWorld.m00;
			//     v63 = *(_OWORD *)&a.instanceData.localToWorld.m02;
			//     *(_OWORD *)&v199.instanceData.localToWorld.m01 = v62;
			//     v64 = *(_OWORD *)&a.instanceData.localToWorld.m03;
			//     *(_OWORD *)&v199.instanceData.localToWorld.m02 = v63;
			//     v65 = *(_OWORD *)&a.instanceData.worldToLocal.m00;
			//     *(_OWORD *)&v199.instanceData.localToWorld.m03 = v64;
			//     v66 = *(_OWORD *)&a.instanceData.worldToLocal.m01;
			//     *(_OWORD *)&v199.instanceData.worldToLocal.m00 = v65;
			//     v67 = *(_OWORD *)&a.instanceData.worldToLocal.m02;
			//     *(_OWORD *)&v199.instanceData.worldToLocal.m01 = v66;
			//     v68 = *(_OWORD *)&a.instanceData.worldToLocal.m03;
			//     *(_OWORD *)&v199.instanceData.worldToLocal.m02 = v67;
			//     v69 = *(_OWORD *)&a.instanceData.prevLocalToWorld.m00;
			//     *(_OWORD *)&v199.instanceData.worldToLocal.m03 = v68;
			//     v70 = *(_OWORD *)&a.instanceData.prevLocalToWorld.m01;
			//     *(_OWORD *)&v199.instanceData.prevLocalToWorld.m00 = v69;
			//     v71 = *(_OWORD *)&a.instanceData.prevLocalToWorld.m02;
			//     *(_OWORD *)&v199.instanceData.prevLocalToWorld.m01 = v70;
			//     v72 = *(_OWORD *)&a.instanceData.prevLocalToWorld.m03;
			//     *(_OWORD *)&v199.instanceData.prevLocalToWorld.m02 = v71;
			//     v73 = *(_OWORD *)&a.instanceData.radius;
			//     *(_OWORD *)&v199.instanceData.prevLocalToWorld.m03 = v72;
			//     v74 = *(_OWORD *)&a.instanceData.groundHeight;
			//     *(_OWORD *)&v199.instanceData.radius = v73;
			//     v75 = *(_OWORD *)&a.mesh;
			//     *(_OWORD *)&v199.instanceData.groundHeight = v74;
			//     v76 = *(_OWORD *)&b.instanceData.localToWorld.m01;
			//     *(_OWORD *)&v199.mesh = v75;
			//     *(_OWORD *)&v198.instanceData.localToWorld.m00 = *(_OWORD *)&b.instanceData.localToWorld.m00;
			//     v77 = *(_OWORD *)&b.instanceData.localToWorld.m02;
			//     *(_OWORD *)&v198.instanceData.localToWorld.m01 = v76;
			//     v78 = *(_OWORD *)&b.instanceData.localToWorld.m03;
			//     *(_OWORD *)&v198.instanceData.localToWorld.m02 = v77;
			//     v79 = *(_OWORD *)&b.instanceData.worldToLocal.m00;
			//     *(_OWORD *)&v198.instanceData.localToWorld.m03 = v78;
			//     v80 = *(_OWORD *)&b.instanceData.worldToLocal.m01;
			//     *(_OWORD *)&v198.instanceData.worldToLocal.m00 = v79;
			//     v81 = *(_OWORD *)&b.instanceData.worldToLocal.m02;
			//     *(_OWORD *)&v198.instanceData.worldToLocal.m01 = v80;
			//     v82 = *(_OWORD *)&b.instanceData.worldToLocal.m03;
			//     *(_OWORD *)&v198.instanceData.worldToLocal.m02 = v81;
			//     v83 = *(_OWORD *)&b.instanceData.prevLocalToWorld.m00;
			//     *(_OWORD *)&v198.instanceData.worldToLocal.m03 = v82;
			//     v84 = *(_OWORD *)&b.instanceData.prevLocalToWorld.m01;
			//     *(_OWORD *)&v198.instanceData.prevLocalToWorld.m00 = v83;
			//     v85 = *(_OWORD *)&b.instanceData.prevLocalToWorld.m02;
			//     *(_OWORD *)&v198.instanceData.prevLocalToWorld.m01 = v84;
			//     v86 = *(_OWORD *)&b.instanceData.prevLocalToWorld.m03;
			//     *(_OWORD *)&v198.instanceData.prevLocalToWorld.m02 = v85;
			//     v87 = *(_OWORD *)&b.instanceData.radius;
			//     *(_OWORD *)&v198.instanceData.prevLocalToWorld.m03 = v86;
			//     v88 = *(_OWORD *)&b.instanceData.groundHeight;
			//     *(_OWORD *)&v198.instanceData.radius = v87;
			//     v89 = *(_OWORD *)&b.mesh;
			//     *(_OWORD *)&v198.instanceData.groundHeight = v88;
			//     *(_OWORD *)&v198.mesh = v89;
			//     if ( v199.passIndex == DWORD2(v89) )
			//     {
			//       return 0;
			//     }
			//     else
			//     {
			//       v91 = *(_OWORD *)&b.instanceData.localToWorld.m01;
			//       *(_OWORD *)&v198.instanceData.localToWorld.m00 = *(_OWORD *)&b.instanceData.localToWorld.m00;
			//       v92 = *(_OWORD *)&b.instanceData.localToWorld.m02;
			//       *(_OWORD *)&v198.instanceData.localToWorld.m01 = v91;
			//       v93 = *(_OWORD *)&b.instanceData.localToWorld.m03;
			//       *(_OWORD *)&v198.instanceData.localToWorld.m02 = v92;
			//       v94 = *(_OWORD *)&b.instanceData.worldToLocal.m00;
			//       *(_OWORD *)&v198.instanceData.localToWorld.m03 = v93;
			//       v95 = *(_OWORD *)&b.instanceData.worldToLocal.m01;
			//       *(_OWORD *)&v198.instanceData.worldToLocal.m00 = v94;
			//       v96 = *(_OWORD *)&b.instanceData.worldToLocal.m02;
			//       *(_OWORD *)&v198.instanceData.worldToLocal.m01 = v95;
			//       v97 = *(_OWORD *)&b.instanceData.worldToLocal.m03;
			//       v98 = &b.instanceData.prevLocalToWorld;
			//       *(_OWORD *)&v198.instanceData.worldToLocal.m02 = v96;
			//       v99 = *(_OWORD *)&v98.m00;
			//       *(_OWORD *)&v198.instanceData.worldToLocal.m03 = v97;
			//       v100 = *(_OWORD *)&v98.m01;
			//       *(_OWORD *)&v198.instanceData.prevLocalToWorld.m00 = v99;
			//       v101 = *(_OWORD *)&v98.m02;
			//       *(_OWORD *)&v198.instanceData.prevLocalToWorld.m01 = v100;
			//       v102 = *(_OWORD *)&v98.m03;
			//       *(_OWORD *)&v198.instanceData.prevLocalToWorld.m02 = v101;
			//       v103 = *(_OWORD *)&v98[1].m00;
			//       *(_OWORD *)&v198.instanceData.prevLocalToWorld.m03 = v102;
			//       v104 = *(_OWORD *)&v98[1].m01;
			//       *(_OWORD *)&v198.instanceData.radius = v103;
			//       v105 = *(_OWORD *)&v98[1].m02;
			//       *(_OWORD *)&v198.instanceData.groundHeight = v104;
			//       v106 = *(_OWORD *)&a.instanceData.localToWorld.m01;
			//       *(_OWORD *)&v198.mesh = v105;
			//       *(_OWORD *)&v199.instanceData.localToWorld.m00 = *(_OWORD *)&a.instanceData.localToWorld.m00;
			//       v107 = *(_OWORD *)&a.instanceData.localToWorld.m02;
			//       *(_OWORD *)&v199.instanceData.localToWorld.m01 = v106;
			//       v108 = *(_OWORD *)&a.instanceData.localToWorld.m03;
			//       *(_OWORD *)&v199.instanceData.localToWorld.m02 = v107;
			//       v109 = *(_OWORD *)&a.instanceData.worldToLocal.m00;
			//       *(_OWORD *)&v199.instanceData.localToWorld.m03 = v108;
			//       v110 = *(_OWORD *)&a.instanceData.worldToLocal.m01;
			//       *(_OWORD *)&v199.instanceData.worldToLocal.m00 = v109;
			//       v111 = *(_OWORD *)&a.instanceData.worldToLocal.m02;
			//       *(_OWORD *)&v199.instanceData.worldToLocal.m01 = v110;
			//       v112 = *(_OWORD *)&a.instanceData.worldToLocal.m03;
			//       v113 = &a.instanceData.prevLocalToWorld;
			//       *(_OWORD *)&v199.instanceData.worldToLocal.m02 = v111;
			//       v114 = *(_OWORD *)&v113.m00;
			//       *(_OWORD *)&v199.instanceData.worldToLocal.m03 = v112;
			//       v115 = *(_OWORD *)&v113.m01;
			//       *(_OWORD *)&v199.instanceData.prevLocalToWorld.m00 = v114;
			//       v116 = *(_OWORD *)&v113.m02;
			//       *(_OWORD *)&v199.instanceData.prevLocalToWorld.m01 = v115;
			//       v117 = *(_OWORD *)&v113.m03;
			//       *(_OWORD *)&v199.instanceData.prevLocalToWorld.m02 = v116;
			//       v118 = *(_OWORD *)&v113[1].m00;
			//       *(_OWORD *)&v199.instanceData.prevLocalToWorld.m03 = v117;
			//       v119 = *(_OWORD *)&v113[1].m01;
			//       *(_OWORD *)&v199.instanceData.radius = v118;
			//       v120 = *(_OWORD *)&v113[1].m02;
			//       *(_OWORD *)&v199.instanceData.groundHeight = v119;
			//       *(_OWORD *)&v199.mesh = v120;
			//       return v198.passIndex - DWORD2(v120);
			//     }
			//   }
			//   else
			//   {
			//     v121 = *(_OWORD *)&b.instanceData.localToWorld.m01;
			//     *(_OWORD *)&v198.instanceData.localToWorld.m00 = *(_OWORD *)&b.instanceData.localToWorld.m00;
			//     v122 = *(_OWORD *)&b.instanceData.localToWorld.m02;
			//     *(_OWORD *)&v198.instanceData.localToWorld.m01 = v121;
			//     v123 = *(_OWORD *)&b.instanceData.localToWorld.m03;
			//     *(_OWORD *)&v198.instanceData.localToWorld.m02 = v122;
			//     v124 = *(_OWORD *)&b.instanceData.worldToLocal.m00;
			//     *(_OWORD *)&v198.instanceData.localToWorld.m03 = v123;
			//     v125 = *(_OWORD *)&b.instanceData.worldToLocal.m01;
			//     *(_OWORD *)&v198.instanceData.worldToLocal.m00 = v124;
			//     v126 = *(_OWORD *)&b.instanceData.worldToLocal.m02;
			//     *(_OWORD *)&v198.instanceData.worldToLocal.m01 = v125;
			//     v127 = *(_OWORD *)&b.instanceData.worldToLocal.m03;
			//     v128 = &b.instanceData.prevLocalToWorld;
			//     *(_OWORD *)&v198.instanceData.worldToLocal.m02 = v126;
			//     v129 = *(_OWORD *)&v128.m00;
			//     *(_OWORD *)&v198.instanceData.worldToLocal.m03 = v127;
			//     v130 = *(_OWORD *)&v128.m01;
			//     *(_OWORD *)&v198.instanceData.prevLocalToWorld.m00 = v129;
			//     v131 = *(_OWORD *)&v128.m02;
			//     *(_OWORD *)&v198.instanceData.prevLocalToWorld.m01 = v130;
			//     v132 = *(_OWORD *)&v128.m03;
			//     *(_OWORD *)&v198.instanceData.prevLocalToWorld.m02 = v131;
			//     v133 = *(_OWORD *)&v128[1].m00;
			//     *(_OWORD *)&v198.instanceData.prevLocalToWorld.m03 = v132;
			//     v134 = *(_OWORD *)&v128[1].m01;
			//     *(_OWORD *)&v198.instanceData.radius = v133;
			//     v135 = *(_OWORD *)&v128[1].m02;
			//     *(_OWORD *)&v198.instanceData.groundHeight = v134;
			//     return BYTE12(v135) != 0 ? 1 : -1;
			//   }
			// }
			// 
			return 0;
		}

		public bool Match(HGInteractionNodeRenderData other)
		{
			// // Boolean Match(HGInteractionNodeRenderData)
			// bool HG::Rendering::Runtime::HGInteractionNodeRenderData::Match(
			//         HGInteractionNodeRenderData *this,
			//         HGInteractionNodeRenderData *other,
			//         MethodInfo *method)
			// {
			//   __int128 v5; // xmm1
			//   Object_1 *mesh; // rbx
			//   __int128 v7; // xmm0
			//   __int128 v8; // xmm1
			//   __int128 v9; // xmm0
			//   __int128 v10; // xmm1
			//   __int128 v11; // xmm0
			//   __int128 v12; // xmm1
			//   __int128 v13; // xmm0
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm0
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm1
			//   __int128 v20; // xmm0
			//   __int128 v21; // xmm1
			//   __int128 v22; // xmm0
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   __int128 v29; // xmm1
			//   __int128 v30; // xmm0
			//   __int128 v31; // xmm1
			//   __int128 v32; // xmm0
			//   __int128 v33; // xmm1
			//   __int128 v34; // xmm0
			//   __int128 v35; // xmm1
			//   __int128 v36; // xmm0
			//   __int128 v37; // xmm1
			//   __int128 v38; // xmm0
			//   __int128 v39; // xmm1
			//   Matrix4x4 *v40; // rdi
			//   __int128 v41; // xmm0
			//   __int128 v42; // xmm1
			//   __int128 v43; // xmm0
			//   __int128 v44; // xmm1
			//   __int128 v45; // xmm0
			//   __int128 v46; // xmm1
			//   __int128 v47; // xmm0
			//   __int64 v49; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int128 v51; // xmm1
			//   __int128 v52; // xmm0
			//   __int128 v53; // xmm1
			//   __int128 v54; // xmm0
			//   __int128 v55; // xmm1
			//   __int128 v56; // xmm0
			//   __int128 v57; // xmm0
			//   Matrix4x4 *p_prevLocalToWorld; // rdi
			//   __int128 v59; // xmm0
			//   __int128 v60; // xmm1
			//   __int128 v61; // xmm0
			//   __int128 v62; // xmm1
			//   __int128 v63; // xmm0
			//   __int128 v64; // xmm1
			//   HGInteractionNodeRenderData v65; // [rsp+20h] [rbp-F8h] BYREF
			// 
			//   if ( !byte_18D919E0D )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919E0D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1523, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1523, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v49);
			//     v51 = *(_OWORD *)&other.instanceData.localToWorld.m01;
			//     *(_OWORD *)&v65.instanceData.localToWorld.m00 = *(_OWORD *)&other.instanceData.localToWorld.m00;
			//     v52 = *(_OWORD *)&other.instanceData.localToWorld.m02;
			//     *(_OWORD *)&v65.instanceData.localToWorld.m01 = v51;
			//     v53 = *(_OWORD *)&other.instanceData.localToWorld.m03;
			//     *(_OWORD *)&v65.instanceData.localToWorld.m02 = v52;
			//     v54 = *(_OWORD *)&other.instanceData.worldToLocal.m00;
			//     *(_OWORD *)&v65.instanceData.localToWorld.m03 = v53;
			//     v55 = *(_OWORD *)&other.instanceData.worldToLocal.m01;
			//     *(_OWORD *)&v65.instanceData.worldToLocal.m00 = v54;
			//     v56 = *(_OWORD *)&other.instanceData.worldToLocal.m02;
			//     *(_OWORD *)&v65.instanceData.worldToLocal.m01 = v55;
			//     *(_OWORD *)&v65.instanceData.worldToLocal.m02 = v56;
			//     v57 = *(_OWORD *)&other.instanceData.worldToLocal.m03;
			//     p_prevLocalToWorld = &other.instanceData.prevLocalToWorld;
			//     *(_OWORD *)&v65.instanceData.worldToLocal.m03 = v57;
			//     v59 = *(_OWORD *)&p_prevLocalToWorld.m01;
			//     *(_OWORD *)&v65.instanceData.prevLocalToWorld.m00 = *(_OWORD *)&p_prevLocalToWorld.m00;
			//     v60 = *(_OWORD *)&p_prevLocalToWorld.m02;
			//     *(_OWORD *)&v65.instanceData.prevLocalToWorld.m01 = v59;
			//     v61 = *(_OWORD *)&p_prevLocalToWorld.m03;
			//     *(_OWORD *)&v65.instanceData.prevLocalToWorld.m02 = v60;
			//     v62 = *(_OWORD *)&p_prevLocalToWorld[1].m00;
			//     *(_OWORD *)&v65.instanceData.prevLocalToWorld.m03 = v61;
			//     v63 = *(_OWORD *)&p_prevLocalToWorld[1].m01;
			//     *(_OWORD *)&v65.instanceData.radius = v62;
			//     v64 = *(_OWORD *)&p_prevLocalToWorld[1].m02;
			//     *(_OWORD *)&v65.instanceData.groundHeight = v63;
			//     *(_OWORD *)&v65.mesh = v64;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_583(Patch, this, &v65, 0LL);
			//   }
			//   else
			//   {
			//     v5 = *(_OWORD *)&other.instanceData.localToWorld.m01;
			//     mesh = (Object_1 *)this.mesh;
			//     *(_OWORD *)&v65.instanceData.localToWorld.m00 = *(_OWORD *)&other.instanceData.localToWorld.m00;
			//     v7 = *(_OWORD *)&other.instanceData.localToWorld.m02;
			//     *(_OWORD *)&v65.instanceData.localToWorld.m01 = v5;
			//     v8 = *(_OWORD *)&other.instanceData.localToWorld.m03;
			//     *(_OWORD *)&v65.instanceData.localToWorld.m02 = v7;
			//     v9 = *(_OWORD *)&other.instanceData.worldToLocal.m00;
			//     *(_OWORD *)&v65.instanceData.localToWorld.m03 = v8;
			//     v10 = *(_OWORD *)&other.instanceData.worldToLocal.m01;
			//     *(_OWORD *)&v65.instanceData.worldToLocal.m00 = v9;
			//     v11 = *(_OWORD *)&other.instanceData.worldToLocal.m02;
			//     *(_OWORD *)&v65.instanceData.worldToLocal.m01 = v10;
			//     v12 = *(_OWORD *)&other.instanceData.prevLocalToWorld.m00;
			//     *(_OWORD *)&v65.instanceData.worldToLocal.m02 = v11;
			//     *(_OWORD *)&v65.instanceData.worldToLocal.m03 = *(_OWORD *)&other.instanceData.worldToLocal.m03;
			//     v13 = *(_OWORD *)&other.instanceData.prevLocalToWorld.m01;
			//     *(_OWORD *)&v65.instanceData.prevLocalToWorld.m00 = v12;
			//     v14 = *(_OWORD *)&other.instanceData.prevLocalToWorld.m02;
			//     *(_OWORD *)&v65.instanceData.prevLocalToWorld.m01 = v13;
			//     v15 = *(_OWORD *)&other.instanceData.prevLocalToWorld.m03;
			//     *(_OWORD *)&v65.instanceData.prevLocalToWorld.m02 = v14;
			//     v16 = *(_OWORD *)&other.instanceData.radius;
			//     *(_OWORD *)&v65.instanceData.prevLocalToWorld.m03 = v15;
			//     v17 = *(_OWORD *)&other.instanceData.groundHeight;
			//     *(_OWORD *)&v65.instanceData.radius = v16;
			//     v18 = *(_OWORD *)&other.mesh;
			//     *(_OWORD *)&v65.instanceData.groundHeight = v17;
			//     *(_OWORD *)&v65.mesh = v18;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( !UnityEngine::Object::op_Equality(mesh, (Object_1 *)v18, 0LL) )
			//       return 0;
			//     v19 = *(_OWORD *)&other.instanceData.localToWorld.m01;
			//     *(_OWORD *)&v65.instanceData.localToWorld.m00 = *(_OWORD *)&other.instanceData.localToWorld.m00;
			//     v20 = *(_OWORD *)&other.instanceData.localToWorld.m02;
			//     *(_OWORD *)&v65.instanceData.localToWorld.m01 = v19;
			//     v21 = *(_OWORD *)&other.instanceData.localToWorld.m03;
			//     *(_OWORD *)&v65.instanceData.localToWorld.m02 = v20;
			//     v22 = *(_OWORD *)&other.instanceData.worldToLocal.m00;
			//     *(_OWORD *)&v65.instanceData.localToWorld.m03 = v21;
			//     v23 = *(_OWORD *)&other.instanceData.worldToLocal.m01;
			//     *(_OWORD *)&v65.instanceData.worldToLocal.m00 = v22;
			//     v24 = *(_OWORD *)&other.instanceData.worldToLocal.m02;
			//     *(_OWORD *)&v65.instanceData.worldToLocal.m01 = v23;
			//     v25 = *(_OWORD *)&other.instanceData.worldToLocal.m03;
			//     *(_OWORD *)&v65.instanceData.worldToLocal.m02 = v24;
			//     v26 = *(_OWORD *)&other.instanceData.prevLocalToWorld.m00;
			//     *(_OWORD *)&v65.instanceData.worldToLocal.m03 = v25;
			//     v27 = *(_OWORD *)&other.instanceData.prevLocalToWorld.m01;
			//     *(_OWORD *)&v65.instanceData.prevLocalToWorld.m00 = v26;
			//     v28 = *(_OWORD *)&other.instanceData.prevLocalToWorld.m02;
			//     *(_OWORD *)&v65.instanceData.prevLocalToWorld.m01 = v27;
			//     v29 = *(_OWORD *)&other.instanceData.prevLocalToWorld.m03;
			//     *(_OWORD *)&v65.instanceData.prevLocalToWorld.m02 = v28;
			//     v30 = *(_OWORD *)&other.instanceData.radius;
			//     *(_OWORD *)&v65.instanceData.prevLocalToWorld.m03 = v29;
			//     v31 = *(_OWORD *)&other.instanceData.groundHeight;
			//     *(_OWORD *)&v65.instanceData.radius = v30;
			//     v32 = *(_OWORD *)&other.mesh;
			//     *(_OWORD *)&v65.instanceData.groundHeight = v31;
			//     *(_OWORD *)&v65.mesh = v32;
			//     if ( this.passIndex == DWORD2(v32) )
			//     {
			//       v33 = *(_OWORD *)&other.instanceData.localToWorld.m01;
			//       *(_OWORD *)&v65.instanceData.localToWorld.m00 = *(_OWORD *)&other.instanceData.localToWorld.m00;
			//       v34 = *(_OWORD *)&other.instanceData.localToWorld.m02;
			//       *(_OWORD *)&v65.instanceData.localToWorld.m01 = v33;
			//       v35 = *(_OWORD *)&other.instanceData.localToWorld.m03;
			//       *(_OWORD *)&v65.instanceData.localToWorld.m02 = v34;
			//       v36 = *(_OWORD *)&other.instanceData.worldToLocal.m00;
			//       *(_OWORD *)&v65.instanceData.localToWorld.m03 = v35;
			//       v37 = *(_OWORD *)&other.instanceData.worldToLocal.m01;
			//       *(_OWORD *)&v65.instanceData.worldToLocal.m00 = v36;
			//       v38 = *(_OWORD *)&other.instanceData.worldToLocal.m02;
			//       *(_OWORD *)&v65.instanceData.worldToLocal.m01 = v37;
			//       v39 = *(_OWORD *)&other.instanceData.worldToLocal.m03;
			//       v40 = &other.instanceData.prevLocalToWorld;
			//       *(_OWORD *)&v65.instanceData.worldToLocal.m02 = v38;
			//       v41 = *(_OWORD *)&v40.m00;
			//       *(_OWORD *)&v65.instanceData.worldToLocal.m03 = v39;
			//       v42 = *(_OWORD *)&v40.m01;
			//       *(_OWORD *)&v65.instanceData.prevLocalToWorld.m00 = v41;
			//       v43 = *(_OWORD *)&v40.m02;
			//       *(_OWORD *)&v65.instanceData.prevLocalToWorld.m01 = v42;
			//       v44 = *(_OWORD *)&v40.m03;
			//       *(_OWORD *)&v65.instanceData.prevLocalToWorld.m02 = v43;
			//       v45 = *(_OWORD *)&v40[1].m00;
			//       *(_OWORD *)&v65.instanceData.prevLocalToWorld.m03 = v44;
			//       v46 = *(_OWORD *)&v40[1].m01;
			//       *(_OWORD *)&v65.instanceData.radius = v45;
			//       v47 = *(_OWORD *)&v40[1].m02;
			//       *(_OWORD *)&v65.instanceData.groundHeight = v46;
			//       *(_OWORD *)&v65.mesh = v47;
			//       return this.ccdKeyword == BYTE12(v47);
			//     }
			//     else
			//     {
			//       return 0;
			//     }
			//   }
			// }
			// 
			return default(bool);
		}

		public HGInteractionNodeInstanceData instanceData;

		public Mesh mesh;

		public int passIndex;

		public bool ccdKeyword;
	}
}
