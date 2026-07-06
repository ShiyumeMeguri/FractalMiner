using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class HGInteractionChain
	{
		public HGInteractionChain(HGInteractionSettingAsset _settingAsset)
		{
			// // HGInteractionChain(HGInteractionSettingAsset)
			// void HG::Rendering::Runtime::HGInteractionChain::HGInteractionChain(
			//         HGInteractionChain *this,
			//         HGInteractionSettingAsset *_settingAsset,
			//         MethodInfo *method)
			// {
			//   HGInteractionChainNode *DefaultValue; // rax
			//   __int128 v6; // xmm1
			//   __int128 v7; // xmm0
			//   __int128 v8; // xmm1
			//   __int128 v9; // xmm0
			//   __int128 v10; // xmm1
			//   __int128 v11; // xmm0
			//   __int128 v12; // xmm0
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   TRingBuffer_1_HGInteractionChainNode_ *v15; // rdi
			//   OneofDescriptorProto *v16; // rdx
			//   FileDescriptor *v17; // r8
			//   MessageDescriptor *v18; // r9
			//   HGInteractionChainSection v19; // xmm6
			//   TRingBuffer_1_HGInteractionChainSection_ *v20; // rax
			//   TRingBuffer_1_HGInteractionChainSection_ *v21; // rdi
			//   OneofDescriptorProto *v22; // rdx
			//   FileDescriptor *v23; // r8
			//   MessageDescriptor *v24; // r9
			//   __int64 v25; // r8
			//   __int64 v26; // r9
			//   OneofDescriptorProto *v27; // rdx
			//   FileDescriptor *v28; // r8
			//   MessageDescriptor *v29; // r9
			//   __int64 v30; // r8
			//   __int64 v31; // r9
			//   OneofDescriptorProto *v32; // rdx
			//   FileDescriptor *v33; // r8
			//   MessageDescriptor *v34; // r9
			//   MaterialPropertyBlock *v35; // rdi
			//   OneofDescriptorProto *v36; // rdx
			//   FileDescriptor *v37; // r8
			//   MessageDescriptor *v38; // r9
			//   OneofDescriptorProto *v39; // rdx
			//   FileDescriptor *v40; // r8
			//   MessageDescriptor *v41; // r9
			//   HGInteractionChainSection v42; // [rsp+20h] [rbp-148h] BYREF
			//   HGInteractionChainNode v43; // [rsp+30h] [rbp-138h] BYREF
			//   HGInteractionChainNode v44; // [rsp+C0h] [rbp-A8h]
			// 
			//   if ( !byte_18D919DFE )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGDecalInteractionData);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGDecalInteractionSettingData);
			//     sub_18003C530(&TypeInfo::UnityEngine::MaterialPropertyBlock);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::TRingBuffer);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::TRingBuffer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>);
			//     byte_18D919DFE = 1;
			//   }
			//   this.fields.LastAccessFrame = -1;
			//   this.fields.IsFree = 1;
			//   DefaultValue = HG::Rendering::Runtime::HGInteractionChainNode::get_DefaultValue(&v43, 0LL);
			//   v6 = *(_OWORD *)&DefaultValue.HeightFade.y;
			//   *(_OWORD *)&v44.VRange.x = *(_OWORD *)&DefaultValue.VRange.x;
			//   v7 = *(_OWORD *)&DefaultValue.TimeFade.w;
			//   *(_OWORD *)&v44.HeightFade.y = v6;
			//   v8 = *(_OWORD *)&DefaultValue.Position.y;
			//   *(_OWORD *)&v44.TimeFade.w = v7;
			//   v9 = *(_OWORD *)&DefaultValue.Rotation.z;
			//   *(_OWORD *)&v44.Position.y = v8;
			//   v10 = *(_OWORD *)&DefaultValue.Vertex0.x;
			//   *(_OWORD *)&v44.Rotation.z = v9;
			//   v11 = *(_OWORD *)&DefaultValue.Vertex1.y;
			//   *(_OWORD *)&v44.Vertex0.x = v10;
			//   *(_OWORD *)&v44.Vertex1.y = v11;
			//   v12 = *(_OWORD *)&DefaultValue.Vertex2.z;
			//   LODWORD(DefaultValue) = *(_DWORD *)&DefaultValue.Active;
			//   *(_OWORD *)&v44.Vertex2.z = v12;
			//   *(_DWORD *)&v44.Active = (_DWORD)DefaultValue;
			//   v15 = (TRingBuffer_1_HGInteractionChainNode_ *)sub_180004920(TypeInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>);
			//   if ( !v15 )
			//     goto LABEL_7;
			//   v43 = v44;
			//   HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::TRingBuffer(
			//     v15,
			//     100,
			//     &v43,
			//     MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::TRingBuffer);
			//   this.fields.chainNodes = v15;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.chainNodes,
			//     v16,
			//     v17,
			//     v18,
			//     *(String__Array **)&v42.VRange,
			//     *(String **)&v42.StartSize,
			//     *(MethodInfo **)&v43.VRange);
			//   v19 = *HG::Rendering::Runtime::HGInteractionChainSection::get_DefaultValue(&v42, 0LL);
			//   v20 = (TRingBuffer_1_HGInteractionChainSection_ *)sub_180004920(TypeInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>);
			//   v21 = v20;
			//   if ( !v20 )
			//     goto LABEL_7;
			//   v42 = v19;
			//   HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::TRingBuffer(
			//     v20,
			//     100,
			//     &v42,
			//     MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::TRingBuffer);
			//   this.fields.chainSections = v21;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.chainSections,
			//     v22,
			//     v23,
			//     v24,
			//     *(String__Array **)&v42.VRange,
			//     *(String **)&v42.StartSize,
			//     *(MethodInfo **)&v43.VRange);
			//   this.fields.interactionData = (HGDecalInteractionData__Array *)il2cpp_array_new_specific_0(
			//                                                                     TypeInfo::HG::Rendering::Runtime::HGDecalInteractionData,
			//                                                                     100LL,
			//                                                                     v25,
			//                                                                     v26);
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.interactionData,
			//     v27,
			//     v28,
			//     v29,
			//     *(String__Array **)&v42.VRange,
			//     *(String **)&v42.StartSize,
			//     *(MethodInfo **)&v43.VRange);
			//   this.fields.settingData = (HGDecalInteractionSettingData__Array *)il2cpp_array_new_specific_0(
			//                                                                        TypeInfo::HG::Rendering::Runtime::HGDecalInteractionSettingData,
			//                                                                        1LL,
			//                                                                        v30,
			//                                                                        v31);
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.settingData,
			//     v32,
			//     v33,
			//     v34,
			//     *(String__Array **)&v42.VRange,
			//     *(String **)&v42.StartSize,
			//     *(MethodInfo **)&v43.VRange);
			//   v35 = (MaterialPropertyBlock *)sub_180004920(TypeInfo::UnityEngine::MaterialPropertyBlock);
			//   if ( !v35 )
			// LABEL_7:
			//     sub_180B536AC(v14, v13);
			//   v35.fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
			//   this.fields.propertyBlock = v35;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.propertyBlock,
			//     v36,
			//     v37,
			//     v38,
			//     *(String__Array **)&v42.VRange,
			//     *(String **)&v42.StartSize,
			//     *(MethodInfo **)&v43.VRange);
			//   this.fields.settingAsset = _settingAsset;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.settingAsset,
			//     v39,
			//     v40,
			//     v41,
			//     *(String__Array **)&v42.VRange,
			//     *(String **)&v42.StartSize,
			//     *(MethodInfo **)&v43.VRange);
			//   HG::Rendering::Runtime::HGInteractionChain::Reset(this, 0LL);
			// }
			// 
		}

		public void Reset()
		{
			// // Void Reset()
			// void HG::Rendering::Runtime::HGInteractionChain::Reset(HGInteractionChain *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   TRingBuffer_1_HGInteractionChainNode_ *chainNodes; // rcx
			//   OneofDescriptorProto *v5; // rdx
			//   FileDescriptor *v6; // r8
			//   MessageDescriptor *v7; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *v9; // [rsp+50h] [rbp+28h]
			//   String *v10; // [rsp+58h] [rbp+30h]
			//   MethodInfo *v11; // [rsp+60h] [rbp+38h]
			// 
			//   if ( !byte_18D919DFF )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::Reset);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::Reset);
			//     byte_18D919DFF = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1494, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1494, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			// LABEL_9:
			//     sub_180B536AC(chainNodes, v3);
			//   }
			//   this.fields.LastAccessFrame = -1;
			//   chainNodes = this.fields.chainNodes;
			//   this.fields.IsFree = 1;
			//   if ( !chainNodes )
			//     goto LABEL_9;
			//   HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::Reset(
			//     chainNodes,
			//     MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::Reset);
			//   chainNodes = (TRingBuffer_1_HGInteractionChainNode_ *)this.fields.chainSections;
			//   if ( !chainNodes )
			//     goto LABEL_9;
			//   HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::Reset(
			//     (TRingBuffer_1_HGInteractionChainSection_ *)chainNodes,
			//     MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::Reset);
			//   this.fields.cachedFadeEnd = 0.0;
			//   this.fields.activeCount = 0;
			//   if ( this.fields.chainBuffer )
			//   {
			//     UnityEngine::ComputeBuffer::Dispose(this.fields.chainBuffer, 0LL);
			//     this.fields.chainBuffer = 0LL;
			//     sub_1800054D0((OneofDescriptor *)&this.fields.chainBuffer, v5, v6, v7, v9, v10, v11);
			//   }
			// }
			// 
		}

		public void PushNewNode(in HGInteractionNode node)
		{
			// // Void PushNewNode(HGInteractionNode ByRef)
			// void HG::Rendering::Runtime::HGInteractionChain::PushNewNode(
			//         HGInteractionChain *this,
			//         HGInteractionNode *node,
			//         MethodInfo *method)
			// {
			//   float v5; // xmm12_4
			//   __int128 v6; // xmm1
			//   __int128 v7; // xmm0
			//   __int128 v8; // xmm1
			//   Quaternion *rotation; // rbx
			//   MethodInfo *v10; // rdx
			//   Vector3 *fwd; // rax
			//   Quaternion v12; // xmm0
			//   __int64 v13; // xmm3_8
			//   Vector3 *v14; // rax
			//   __int64 v15; // xmm9_8
			//   float z; // r14d
			//   MethodInfo *v17; // rdx
			//   Vector3 *right; // rax
			//   Quaternion v19; // xmm0
			//   Vector3 *v20; // rax
			//   TRingBuffer_1_HGInteractionChainSection_ *chainSections; // rdx
			//   __int64 p_value; // rcx
			//   __int64 v23; // xmm6_8
			//   float v24; // ebx
			//   HGInteractionSettingAsset *settingAsset; // rax
			//   __m128 decalNodeWidth_low; // xmm10
			//   float decalNodeLength; // xmm14_4
			//   __int128 v28; // xmm1
			//   __int128 v29; // xmm0
			//   __int128 v30; // xmm1
			//   MethodInfo *v31; // r9
			//   float v32; // xmm2_4
			//   Vector3 *v33; // rax
			//   __int64 *v34; // r8
			//   __int64 v35; // xmm0_8
			//   __int64 v36; // xmm3_8
			//   MethodInfo *v37; // r9
			//   Vector3 *v38; // rax
			//   __int64 v39; // xmm3_8
			//   float v40; // r12d
			//   HGInteractionSettingAsset *v41; // rax
			//   float v42; // xmm0_4
			//   __m128 x_low; // xmm15
			//   float v44; // xmm7_4
			//   MethodInfo *v45; // r9
			//   Vector3 *v46; // rax
			//   __int64 v47; // xmm3_8
			//   MethodInfo *v48; // r9
			//   Vector3 *v49; // rax
			//   MethodInfo *v50; // r9
			//   __int64 v51; // xmm3_8
			//   Vector3 *v52; // rax
			//   float v53; // r13d
			//   MethodInfo *v54; // r9
			//   Vector3 *v55; // rax
			//   __int64 v56; // xmm3_8
			//   MethodInfo *v57; // r9
			//   Vector3 *v58; // rax
			//   MethodInfo *v59; // r9
			//   __int64 v60; // xmm3_8
			//   Vector3 *v61; // rax
			//   MethodInfo *v62; // r9
			//   __int64 v63; // xmm0_8
			//   HGInteractionSettingAsset *v64; // rax
			//   float decalNodeHeadLength; // xmm2_4
			//   Vector3 *v66; // rax
			//   MethodInfo *v67; // r9
			//   __int64 v68; // xmm3_8
			//   Vector3 *v69; // rax
			//   __int64 v70; // xmm3_8
			//   MethodInfo *v71; // r9
			//   Vector3 *v72; // rax
			//   __int64 v73; // xmm3_8
			//   MethodInfo *v74; // r9
			//   Vector3 *v75; // rax
			//   __int64 v76; // xmm3_8
			//   MethodInfo *v77; // r9
			//   Vector3 *v78; // rax
			//   MethodInfo *v79; // r9
			//   __int64 v80; // xmm13_8
			//   float v81; // r15d
			//   HGInteractionSettingAsset *v82; // rax
			//   float v83; // xmm2_4
			//   Vector3 *v84; // rax
			//   MethodInfo *v85; // r9
			//   __int64 v86; // xmm3_8
			//   Vector3 *v87; // rax
			//   __int64 v88; // xmm3_8
			//   MethodInfo *v89; // r9
			//   Vector3 *v90; // rax
			//   __int64 v91; // xmm3_8
			//   MethodInfo *v92; // r9
			//   Vector3 *v93; // rax
			//   __int64 v94; // xmm3_8
			//   MethodInfo *v95; // r9
			//   Vector3 *v96; // rax
			//   __int64 v97; // xmm0_8
			//   MethodInfo *v98; // r9
			//   Vector3 *v99; // rax
			//   MethodInfo *v100; // r9
			//   __int64 v101; // xmm3_8
			//   Vector3 *v102; // rax
			//   __int64 v103; // xmm3_8
			//   MethodInfo *v104; // r9
			//   Vector3 *v105; // rax
			//   __int64 v106; // xmm3_8
			//   MethodInfo *v107; // r9
			//   Vector3 *v108; // rax
			//   __int64 v109; // xmm3_8
			//   MethodInfo *v110; // r9
			//   Vector3 *v111; // rax
			//   float v112; // r10d
			//   MethodInfo *v113; // r9
			//   Vector3 *v114; // rax
			//   MethodInfo *v115; // r9
			//   Il2CppMethodPointer methodPointer; // xmm0_8
			//   __int64 v117; // xmm3_8
			//   Vector3 *v118; // rax
			//   __int64 v119; // xmm3_8
			//   MethodInfo *v120; // r9
			//   Vector3 *v121; // rax
			//   __int64 v122; // xmm3_8
			//   MethodInfo *v123; // r9
			//   Vector3 *v124; // rax
			//   __int64 v125; // xmm3_8
			//   MethodInfo *v126; // r9
			//   Vector3 *v127; // rax
			//   __int64 v128; // xmm4_8
			//   float v129; // xmm6_4
			//   __int64 v130; // xmm1_8
			//   float v131; // r8d
			//   TRingBuffer_1_HGInteractionChainNode_ *chainNodes; // rax
			//   int v133; // ebx
			//   MethodInfo *v134; // r9
			//   Vector3 *v135; // rax
			//   float v136; // ecx
			//   double v137; // xmm0_8
			//   __int64 v138; // rax
			//   __int64 v139; // xmm1_8
			//   MethodInfo *v140; // r8
			//   float v141; // xmm8_4
			//   MethodInfo *v142; // rdx
			//   Vector3 *v143; // rax
			//   __int64 v144; // xmm3_8
			//   Vector3 *v145; // rax
			//   __int64 v146; // xmm0_8
			//   MethodInfo *v147; // r8
			//   float v148; // xmm0_4
			//   HGInteractionSettingAsset *v149; // rax
			//   float rotationThreshold; // xmm1_4
			//   float v151; // xmm0_4
			//   float y; // xmm0_4
			//   TRingBuffer_1_HGInteractionChainNode_ *v153; // rax
			//   unsigned int PrevIndex; // eax
			//   __int128 v155; // xmm1
			//   __int128 v156; // xmm0
			//   __int128 v157; // xmm1
			//   __int128 v158; // xmm0
			//   __int128 v159; // xmm1
			//   __int128 v160; // xmm0
			//   __int128 v161; // xmm1
			//   float StartSize; // eax
			//   __int128 v163; // xmm0
			//   __int64 v164; // xmm9_8
			//   float v165; // r14d
			//   __int128 v166; // xmm1
			//   float v167; // eax
			//   __int128 v168; // xmm0
			//   __int128 v169; // xmm1
			//   __int128 v170; // xmm0
			//   __int128 v171; // xmm1
			//   __int128 v172; // xmm0
			//   __int128 v173; // xmm1
			//   __int128 v174; // xmm0
			//   __int128 v175; // xmm1
			//   __int64 v176; // xmm13_8
			//   __int128 v177; // xmm0
			//   float v178; // eax
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
			//   float v189; // xmm8_4
			//   __int128 v190; // xmm0
			//   __int128 v191; // xmm1
			//   float v192; // xmm6_4
			//   HGInteractionSettingAsset *v193; // rax
			//   float v194; // xmm1_4
			//   float nodeDistanceThreshold; // xmm0_4
			//   TRingBuffer_1_HGInteractionChainSection_ *v196; // rax
			//   int32_t ringBufferEnd; // eax
			//   unsigned __int64 v198; // xmm3_8
			//   Vector2 v199; // rax
			//   __int64 v200; // xmm6_8
			//   float cachedFadeEnd; // xmm0_4
			//   Vector2 v202; // rax
			//   __int64 v203; // xmm5_8
			//   float v204; // r8d
			//   __int64 v205; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v207; // [rsp+28h] [rbp-E0h] BYREF
			//   Vector3 Position; // [rsp+38h] [rbp-D0h] BYREF
			//   HGInteractionChainSection v209; // [rsp+48h] [rbp-C0h] BYREF
			//   Vector3 v210; // [rsp+58h] [rbp-B0h] BYREF
			//   Quaternion v211; // [rsp+68h] [rbp-A0h] BYREF
			//   Vector3 v212; // [rsp+78h] [rbp-90h] BYREF
			//   float v213; // [rsp+88h] [rbp-80h]
			//   float v214; // [rsp+8Ch] [rbp-7Ch]
			//   float v215; // [rsp+90h] [rbp-78h]
			//   Vector3 v216; // [rsp+98h] [rbp-70h] BYREF
			//   HGInteractionChainNode nodea; // [rsp+A8h] [rbp-60h] BYREF
			//   Quaternion v218; // [rsp+138h] [rbp+30h] BYREF
			//   __int64 v219; // [rsp+148h] [rbp+40h]
			//   __int64 v220; // [rsp+150h] [rbp+48h]
			//   Matrix4x4 v221; // [rsp+158h] [rbp+50h] BYREF
			//   Quaternion v222; // [rsp+198h] [rbp+90h]
			//   HGInteractionChainNode value; // [rsp+1A8h] [rbp+A0h] BYREF
			//   HGInteractionChainNode v224; // [rsp+238h] [rbp+130h] BYREF
			//   float v225; // [rsp+3B0h] [rbp+2A8h]
			// 
			//   if ( !byte_18D919E00 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::AddNewNode);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::AddNewNode);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetCurrentNode);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::GetCurrentNode);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetNodeAtIndex);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetPrevIndex);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::SetCurrentNode);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::SetCurrentNode);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::SetNodeAtIndex);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::get_EndIndex);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::get_EndIndex);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::get_IsEmpty);
			//     byte_18D919E00 = 1;
			//   }
			//   Position.z = 0.0;
			//   v5 = 0.0;
			//   sub_1802F01E0(&v221, 0LL, 64LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(1495, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1495, 0LL);
			//     if ( !Patch )
			//       goto LABEL_51;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_570(Patch, (Object *)this, node, 0LL);
			//     return;
			//   }
			//   this.fields.IsFree = 0;
			//   this.fields.LastAccessFrame = UnityEngine::Time::get_frameCount(0LL);
			//   v6 = *(_OWORD *)&node.localToWorldMatrix.m01;
			//   *(_OWORD *)&v221.m00 = *(_OWORD *)&node.localToWorldMatrix.m00;
			//   v7 = *(_OWORD *)&node.localToWorldMatrix.m02;
			//   *(_OWORD *)&v221.m01 = v6;
			//   v8 = *(_OWORD *)&node.localToWorldMatrix.m03;
			//   *(_OWORD *)&v221.m02 = v7;
			//   *(_OWORD *)&v221.m03 = v8;
			//   rotation = UnityEngine::Matrix4x4::get_rotation(&v211, &v221, 0LL);
			//   v222 = (Quaternion)_mm_loadu_si128((const __m128i *)rotation);
			//   fwd = UnityEngine::Vector3::get_fwd(&Position, v10);
			//   v12 = *rotation;
			//   v13 = *(_QWORD *)&fwd.x;
			//   v207.z = fwd.z;
			//   *(_QWORD *)&v207.x = v13;
			//   v209 = (HGInteractionChainSection)v12;
			//   v14 = UnityEngine::Quaternion::op_Multiply(&Position, (Quaternion *)&v209, &v207, 0LL);
			//   v15 = *(_QWORD *)&v14.x;
			//   z = v14.z;
			//   right = UnityEngine::Vector3::get_right(&Position, v17);
			//   v19 = *rotation;
			//   *(_QWORD *)&v8 = *(_QWORD *)&right.x;
			//   *(float *)&right = right.z;
			//   *(_QWORD *)&v207.x = v8;
			//   LODWORD(v207.z) = (_DWORD)right;
			//   v209 = (HGInteractionChainSection)v19;
			//   v20 = UnityEngine::Quaternion::op_Multiply(&Position, (Quaternion *)&v209, &v207, 0LL);
			//   v23 = *(_QWORD *)&v20.x;
			//   v24 = v20.z;
			//   settingAsset = this.fields.settingAsset;
			//   if ( !settingAsset )
			//     goto LABEL_51;
			//   decalNodeWidth_low = (__m128)LODWORD(settingAsset.fields.decalNodeWidth);
			//   decalNodeLength = settingAsset.fields.decalNodeLength;
			//   v28 = *(_OWORD *)&node.localToWorldMatrix.m01;
			//   *(_OWORD *)&v221.m00 = *(_OWORD *)&node.localToWorldMatrix.m00;
			//   v29 = *(_OWORD *)&node.localToWorldMatrix.m02;
			//   *(_OWORD *)&v221.m01 = v28;
			//   v30 = *(_OWORD *)&node.localToWorldMatrix.m03;
			//   *(_OWORD *)&v221.m02 = v29;
			//   *(_OWORD *)&v221.m03 = v30;
			//   UnityEngine::Matrix4x4::GetPosition(&Position, &v221, 0LL);
			//   p_value = (__int64)this.fields.settingAsset;
			//   if ( !p_value )
			//     goto LABEL_51;
			//   v32 = *(float *)(p_value + 44);
			//   *(_QWORD *)&v207.x = v15;
			//   v207.z = z;
			//   v33 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v211, &v207, v32, v31);
			//   v35 = *v34;
			//   v36 = *(_QWORD *)&v33.x;
			//   v207.z = v33.z;
			//   LODWORD(v33) = *((_DWORD *)v34 + 2);
			//   *(_QWORD *)&v207.x = v36;
			//   *(_QWORD *)&v211.x = v35;
			//   LODWORD(v211.z) = (_DWORD)v33;
			//   v38 = UnityEngine::Vector3::op_Addition((Vector3 *)&v209, (Vector3 *)&v211, &v207, v37);
			//   v39 = *(_QWORD *)&v38.x;
			//   v40 = v38.z;
			//   v41 = this.fields.settingAsset;
			//   *(_QWORD *)&v207.x = v39;
			//   if ( !v41 )
			//     goto LABEL_51;
			//   v42 = (float)((float)(v207.y - node.GroundHeight) - v41.fields.heightFadeDistanceMin)
			//       / (float)(v41.fields.heightFadeDistanceMax - v41.fields.heightFadeDistanceMin);
			//   Beyond::JobMathf::Clamp01((Beyond::JobMathf *)p_value);
			//   x_low = (__m128)LODWORD(v207.x);
			//   v44 = 1.0 - v42;
			//   v218.x = node.GroundHeight;
			//   *(_QWORD *)&v207.x = v23;
			//   v207.z = v24;
			//   v46 = UnityEngine::Vector3::op_Multiply(&Position, &v207, decalNodeWidth_low.m128_f32[0], v45);
			//   v47 = *(_QWORD *)&v46.x;
			//   *(float *)&v46 = v46.z;
			//   *(_QWORD *)&v207.x = v47;
			//   LODWORD(v207.z) = (_DWORD)v46;
			//   v49 = UnityEngine::Vector3::op_Multiply(&Position, &v207, 0.5, v48);
			//   *(_QWORD *)&v211.x = v50.methodPointer;
			//   v211.z = v40;
			//   v51 = *(_QWORD *)&v49.x;
			//   *(float *)&v49 = v49.z;
			//   *(_QWORD *)&v207.x = v51;
			//   LODWORD(v207.z) = (_DWORD)v49;
			//   v52 = UnityEngine::Vector3::op_Subtraction(&Position, (Vector3 *)&v211, &v207, v50);
			//   *(_QWORD *)&v207.x = v23;
			//   v207.z = v24;
			//   v53 = v52.z;
			//   v219 = *(_QWORD *)&v52.x;
			//   v55 = UnityEngine::Vector3::op_Multiply(&Position, &v207, decalNodeWidth_low.m128_f32[0], v54);
			//   v56 = *(_QWORD *)&v55.x;
			//   *(float *)&v55 = v55.z;
			//   *(_QWORD *)&v207.x = v56;
			//   LODWORD(v207.z) = (_DWORD)v55;
			//   v58 = UnityEngine::Vector3::op_Multiply(&Position, &v207, 0.5, v57);
			//   *(_QWORD *)&v211.x = v59.methodPointer;
			//   v211.z = v40;
			//   v60 = *(_QWORD *)&v58.x;
			//   *(float *)&v58 = v58.z;
			//   *(_QWORD *)&v207.x = v60;
			//   LODWORD(v207.z) = (_DWORD)v58;
			//   v61 = UnityEngine::Vector3::op_Addition(&Position, (Vector3 *)&v211, &v207, v59);
			//   v63 = *(_QWORD *)&v61.x;
			//   v215 = v61.z;
			//   v64 = this.fields.settingAsset;
			//   v220 = v63;
			//   if ( !v64 )
			//     goto LABEL_51;
			//   decalNodeHeadLength = v64.fields.decalNodeHeadLength;
			//   *(_QWORD *)&v207.x = v15;
			//   v207.z = z;
			//   v66 = UnityEngine::Vector3::op_Multiply(&Position, &v207, decalNodeHeadLength, v62);
			//   *(_QWORD *)&v212.x = v67.methodPointer;
			//   v212.z = v40;
			//   v68 = *(_QWORD *)&v66.x;
			//   *(float *)&v66 = v66.z;
			//   *(_QWORD *)&v211.x = v68;
			//   LODWORD(v211.z) = (_DWORD)v66;
			//   *(_QWORD *)&v207.x = v23;
			//   v207.z = v24;
			//   v69 = UnityEngine::Vector3::op_Multiply(&Position, &v207, decalNodeWidth_low.m128_f32[0], v67);
			//   v70 = *(_QWORD *)&v69.x;
			//   *(float *)&v69 = v69.z;
			//   *(_QWORD *)&v207.x = v70;
			//   LODWORD(v207.z) = (_DWORD)v69;
			//   v72 = UnityEngine::Vector3::op_Multiply(&Position, &v207, 0.5, v71);
			//   v73 = *(_QWORD *)&v72.x;
			//   *(float *)&v72 = v72.z;
			//   *(_QWORD *)&v207.x = v73;
			//   LODWORD(v207.z) = (_DWORD)v72;
			//   v75 = UnityEngine::Vector3::op_Addition(&Position, &v212, (Vector3 *)&v211, v74);
			//   v76 = *(_QWORD *)&v75.x;
			//   *(float *)&v75 = v75.z;
			//   *(_QWORD *)&v211.x = v76;
			//   LODWORD(v211.z) = (_DWORD)v75;
			//   v78 = UnityEngine::Vector3::op_Subtraction(&Position, (Vector3 *)&v211, &v207, v77);
			//   v80 = *(_QWORD *)&v78.x;
			//   v81 = v78.z;
			//   v82 = this.fields.settingAsset;
			//   *(_QWORD *)&v211.x = v80;
			//   if ( !v82 )
			//     goto LABEL_51;
			//   v83 = v82.fields.decalNodeHeadLength;
			//   *(_QWORD *)&v207.x = v15;
			//   v207.z = z;
			//   v84 = UnityEngine::Vector3::op_Multiply(&Position, &v207, v83, v79);
			//   *(_QWORD *)&v210.x = v85.methodPointer;
			//   v210.z = v40;
			//   v86 = *(_QWORD *)&v84.x;
			//   *(float *)&v84 = v84.z;
			//   *(_QWORD *)&v212.x = v86;
			//   LODWORD(v212.z) = (_DWORD)v84;
			//   *(_QWORD *)&v207.x = v23;
			//   v207.z = v24;
			//   v87 = UnityEngine::Vector3::op_Multiply(&Position, &v207, decalNodeWidth_low.m128_f32[0], v85);
			//   v88 = *(_QWORD *)&v87.x;
			//   *(float *)&v87 = v87.z;
			//   *(_QWORD *)&v207.x = v88;
			//   LODWORD(v207.z) = (_DWORD)v87;
			//   v90 = UnityEngine::Vector3::op_Multiply(&Position, &v207, 0.5, v89);
			//   v91 = *(_QWORD *)&v90.x;
			//   *(float *)&v90 = v90.z;
			//   *(_QWORD *)&v207.x = v91;
			//   LODWORD(v207.z) = (_DWORD)v90;
			//   v93 = UnityEngine::Vector3::op_Addition(&Position, &v210, &v212, v92);
			//   v94 = *(_QWORD *)&v93.x;
			//   *(float *)&v93 = v93.z;
			//   *(_QWORD *)&v212.x = v94;
			//   LODWORD(v212.z) = (_DWORD)v93;
			//   v96 = UnityEngine::Vector3::op_Addition(&Position, &v212, &v207, v95);
			//   *(_QWORD *)&v207.x = v15;
			//   v207.z = z;
			//   v97 = *(_QWORD *)&v96.x;
			//   *(float *)&v96 = v96.z;
			//   *(_QWORD *)&v212.x = v97;
			//   v213 = *(float *)&v96;
			//   v99 = UnityEngine::Vector3::op_Multiply(&Position, &v207, decalNodeLength, v98);
			//   *(_QWORD *)&v216.x = v100.methodPointer;
			//   v216.z = v40;
			//   v101 = *(_QWORD *)&v99.x;
			//   *(float *)&v99 = v99.z;
			//   *(_QWORD *)&v210.x = v101;
			//   LODWORD(v210.z) = (_DWORD)v99;
			//   *(_QWORD *)&v207.x = v23;
			//   v207.z = v24;
			//   v102 = UnityEngine::Vector3::op_Multiply(&Position, &v207, decalNodeWidth_low.m128_f32[0], v100);
			//   v103 = *(_QWORD *)&v102.x;
			//   *(float *)&v102 = v102.z;
			//   *(_QWORD *)&v207.x = v103;
			//   LODWORD(v207.z) = (_DWORD)v102;
			//   v105 = UnityEngine::Vector3::op_Multiply(&Position, &v207, 0.5, v104);
			//   v106 = *(_QWORD *)&v105.x;
			//   *(float *)&v105 = v105.z;
			//   *(_QWORD *)&v207.x = v106;
			//   LODWORD(v207.z) = (_DWORD)v105;
			//   v108 = UnityEngine::Vector3::op_Subtraction(&Position, &v216, &v210, v107);
			//   v109 = *(_QWORD *)&v108.x;
			//   *(float *)&v108 = v108.z;
			//   *(_QWORD *)&v210.x = v109;
			//   LODWORD(v210.z) = (_DWORD)v108;
			//   v111 = UnityEngine::Vector3::op_Subtraction(&Position, &v210, &v207, v110);
			//   *(_QWORD *)&v207.x = v15;
			//   v207.z = z;
			//   v112 = v111.z;
			//   *(_QWORD *)&v216.x = *(_QWORD *)&v111.x;
			//   v214 = v112;
			//   v114 = UnityEngine::Vector3::op_Multiply(&Position, &v207, decalNodeLength, v113);
			//   methodPointer = v115.methodPointer;
			//   *(_QWORD *)&v207.x = v23;
			//   v207.z = v24;
			//   v117 = *(_QWORD *)&v114.x;
			//   *(float *)&v114 = v114.z;
			//   *(_QWORD *)&v210.x = v117;
			//   LODWORD(v210.z) = (_DWORD)v114;
			//   *(_QWORD *)&Position.x = methodPointer;
			//   Position.z = v40;
			//   v118 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v209, &v207, decalNodeWidth_low.m128_f32[0], v115);
			//   v119 = *(_QWORD *)&v118.x;
			//   *(float *)&v118 = v118.z;
			//   *(_QWORD *)&v207.x = v119;
			//   LODWORD(v207.z) = (_DWORD)v118;
			//   v121 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v209, &v207, 0.5, v120);
			//   v122 = *(_QWORD *)&v121.x;
			//   *(float *)&v121 = v121.z;
			//   *(_QWORD *)&v207.x = v122;
			//   LODWORD(v207.z) = (_DWORD)v121;
			//   v124 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v209, &Position, &v210, v123);
			//   v125 = *(_QWORD *)&v124.x;
			//   *(float *)&v124 = v124.z;
			//   *(_QWORD *)&Position.x = v125;
			//   LODWORD(Position.z) = (_DWORD)v124;
			//   v127 = UnityEngine::Vector3::op_Addition((Vector3 *)&v209, &Position, &v207, v126);
			//   v129 = -1.0;
			//   v130 = *(_QWORD *)&v127.x;
			//   v131 = v127.z;
			//   chainNodes = this.fields.chainNodes;
			//   *(_QWORD *)&v210.x = v130;
			//   v225 = v131;
			//   if ( !chainNodes )
			//     goto LABEL_51;
			//   v133 = 0;
			//   if ( chainNodes.fields.ringBufferEnd == -1 )
			//     goto LABEL_25;
			//   HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetCurrentNode(
			//     &value,
			//     chainNodes,
			//     MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetCurrentNode);
			//   v207.z = v40;
			//   nodea = value;
			//   Position = value.Position;
			//   *(_QWORD *)&v207.x = _mm_unpacklo_ps(x_low, (__m128)LODWORD(v218.x)).m128_u64[0];
			//   v135 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v209, &v207, &Position, v134);
			//   v136 = v135.z;
			//   *(_QWORD *)&v207.x = *(_QWORD *)&v135.x;
			//   v207.z = v136;
			//   *(_QWORD *)&v218.x = _mm_unpacklo_ps((__m128)LODWORD(v207.x), (__m128)_mm_cvtsi32_si128(LODWORD(v136))).m128_u64[0];
			//   v137 = sub_182413570(&v218);
			//   *(_QWORD *)&Position.x = v15;
			//   Position.z = z;
			//   v129 = *(float *)&v137;
			//   v138 = sub_182413270(&v209, &v207);
			//   v139 = *(_QWORD *)v138;
			//   LODWORD(v138) = *(_DWORD *)(v138 + 8);
			//   *(_QWORD *)&v207.x = v139;
			//   LODWORD(v207.z) = v138;
			//   v141 = UnityEngine::Vector3::Dot(&v207, &Position, v140);
			//   v143 = UnityEngine::Vector3::get_fwd((Vector3 *)&v209, v142);
			//   *(_QWORD *)&v207.x = v15;
			//   v144 = *(_QWORD *)&v143.x;
			//   *(float *)&v143 = v143.z;
			//   *(_QWORD *)&Position.x = v144;
			//   LODWORD(Position.z) = (_DWORD)v143;
			//   v218 = value.Rotation;
			//   v207.z = z;
			//   v145 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v209, &v218, &Position, 0LL);
			//   v146 = *(_QWORD *)&v145.x;
			//   *(float *)&v145 = v145.z;
			//   *(_QWORD *)&Position.x = v146;
			//   LODWORD(Position.z) = (_DWORD)v145;
			//   v148 = UnityEngine::Vector3::Dot(&Position, &v207, v147);
			//   v149 = this.fields.settingAsset;
			//   if ( !v149 )
			//     goto LABEL_51;
			//   rotationThreshold = v149.fields.rotationThreshold;
			//   if ( rotationThreshold <= v148
			//     && (v129 < v149.fields.nodeDistanceThreshold || rotationThreshold <= v141)
			//     && v149.fields.backwardDistanceThreshold <= (float)(v141 * v129) )
			//   {
			//     if ( v149.fields.nodeDistanceThreshold > v129 )
			//     {
			//       *(_QWORD *)&nodea.Vertex1.x = *(_QWORD *)&v212.x;
			//       v151 = v129 + this.fields.cachedFadeEnd;
			//       *(_QWORD *)&nodea.Vertex0.x = v80;
			//       nodea.Vertex0.z = v81;
			//       nodea.Vertex1.z = v213;
			//       nodea.TimeFade = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18A357460);
			//       nodea.StartDist.x = -1.0;
			//       nodea.VRange.y = v151;
			//       y = nodea.HeightFade.y;
			//       nodea.StartDist.y = -1.0;
			//       if ( nodea.HeightFade.y <= v44 )
			//         y = v44;
			//       p_value = (__int64)this.fields.chainNodes;
			//       nodea.HeightFade.y = y;
			//       if ( p_value )
			//       {
			//         HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::SetCurrentNode(
			//           (TRingBuffer_1_HGInteractionChainNode_ *)p_value,
			//           &nodea,
			//           MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::SetCurrentNode);
			//         chainSections = this.fields.chainSections;
			//         if ( chainSections )
			//         {
			//           HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::GetCurrentNode(
			//             &v209,
			//             chainSections,
			//             MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::GetCurrentNode);
			//           p_value = (__int64)this.fields.chainSections;
			//           v209.VRange.y = v129 + this.fields.cachedFadeEnd;
			//           if ( p_value )
			//           {
			//             HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::SetCurrentNode(
			//               (TRingBuffer_1_HGInteractionChainSection_ *)p_value,
			//               &v209,
			//               MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::SetCurrentNode);
			//             return;
			//           }
			//         }
			//       }
			//       goto LABEL_51;
			//     }
			//     v128 = *(_QWORD *)&v216.x;
			//     v130 = *(_QWORD *)&v210.x;
			// LABEL_25:
			//     p_value = 1LL;
			//     goto LABEL_26;
			//   }
			//   v128 = *(_QWORD *)&v216.x;
			//   p_value = 1LL;
			//   v130 = *(_QWORD *)&v210.x;
			//   v133 = 1;
			// LABEL_26:
			//   v153 = this.fields.chainNodes;
			//   if ( !v153 )
			//     goto LABEL_51;
			//   if ( v153.fields.ringBufferEnd == -1 )
			//     v133 = 1;
			//   if ( v133 )
			//   {
			//     v165 = v214;
			//     v164 = v128;
			//     v176 = v130;
			//     v189 = decalNodeLength;
			//     v192 = v44;
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetCurrentNode(
			//       &v224,
			//       this.fields.chainNodes,
			//       MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetCurrentNode);
			//     chainSections = (TRingBuffer_1_HGInteractionChainSection_ *)this.fields.chainNodes;
			//     if ( !chainSections )
			//       goto LABEL_51;
			//     PrevIndex = HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetPrevIndex(
			//                   this.fields.chainNodes,
			//                   chainSections.fields.ringBufferEnd,
			//                   MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetPrevIndex);
			//     chainSections = (TRingBuffer_1_HGInteractionChainSection_ *)this.fields.chainNodes;
			//     if ( !chainSections )
			//       goto LABEL_51;
			//     chainSections = (TRingBuffer_1_HGInteractionChainSection_ *)sub_180835FDC(&nodea, chainSections, PrevIndex);
			//     v155 = *(_OWORD *)&chainSections.fields.ringBufferStart;
			//     *(_OWORD *)&value.VRange.x = *(_OWORD *)&chainSections.klass;
			//     v156 = *(_OWORD *)&chainSections.fields.defaultT.StartSize;
			//     *(_OWORD *)&value.HeightFade.y = v155;
			//     v157 = *(_OWORD *)&chainSections[1].klass;
			//     *(_OWORD *)&value.TimeFade.w = v156;
			//     v158 = *(_OWORD *)&chainSections[1].fields.ringBufferStart;
			//     *(_OWORD *)&value.Position.y = v157;
			//     v159 = *(_OWORD *)&chainSections[1].fields.defaultT.StartSize;
			//     *(_OWORD *)&value.Rotation.z = v158;
			//     v160 = *(_OWORD *)&chainSections[2].klass;
			//     *(_OWORD *)&value.Vertex0.x = v159;
			//     v161 = *(_OWORD *)&chainSections[2].fields.ringBufferStart;
			//     StartSize = chainSections[2].fields.defaultT.StartSize;
			//     *(_OWORD *)&value.Vertex1.y = v160;
			//     v163 = *(_OWORD *)&chainSections.klass;
			//     *(_OWORD *)&value.Vertex2.z = v161;
			//     *(float *)&value.Active = StartSize;
			//     v164 = *(_QWORD *)&value.Vertex0.x;
			//     v165 = value.Vertex0.z;
			//     v166 = *(_OWORD *)&chainSections.fields.ringBufferStart;
			//     v167 = chainSections[2].fields.defaultT.StartSize;
			//     *(_OWORD *)&value.VRange.x = v163;
			//     v168 = *(_OWORD *)&chainSections.fields.defaultT.StartSize;
			//     *(_OWORD *)&value.HeightFade.y = v166;
			//     v169 = *(_OWORD *)&chainSections[1].klass;
			//     *(_OWORD *)&value.TimeFade.w = v168;
			//     v170 = *(_OWORD *)&chainSections[1].fields.ringBufferStart;
			//     *(_OWORD *)&value.Position.y = v169;
			//     v171 = *(_OWORD *)&chainSections[1].fields.defaultT.StartSize;
			//     *(_OWORD *)&value.Rotation.z = v170;
			//     v172 = *(_OWORD *)&chainSections[2].klass;
			//     *(_OWORD *)&value.Vertex0.x = v171;
			//     v173 = *(_OWORD *)&chainSections[2].fields.ringBufferStart;
			//     *(_OWORD *)&value.Vertex1.y = v172;
			//     v174 = *(_OWORD *)&chainSections.klass;
			//     *(_OWORD *)&value.Vertex2.z = v173;
			//     *(float *)&value.Active = v167;
			//     v175 = *(_OWORD *)&chainSections.fields.ringBufferStart;
			//     v176 = *(_QWORD *)&value.Vertex1.x;
			//     *(_OWORD *)&v224.VRange.x = v174;
			//     v225 = value.Vertex1.z;
			//     v177 = *(_OWORD *)&chainSections.fields.defaultT.StartSize;
			//     v178 = chainSections[2].fields.defaultT.StartSize;
			//     *(_OWORD *)&v224.HeightFade.y = v175;
			//     v179 = *(_OWORD *)&chainSections[1].klass;
			//     *(_OWORD *)&v224.TimeFade.w = v177;
			//     v180 = *(_OWORD *)&chainSections[1].fields.ringBufferStart;
			//     *(_OWORD *)&v224.Position.y = v179;
			//     v181 = *(_OWORD *)&chainSections[1].fields.defaultT.StartSize;
			//     *(_OWORD *)&v224.Rotation.z = v180;
			//     v182 = *(_OWORD *)&chainSections[2].klass;
			//     *(_OWORD *)&v224.Vertex0.x = v181;
			//     v183 = *(_OWORD *)&chainSections[2].fields.ringBufferStart;
			//     *(_OWORD *)&v224.Vertex1.y = v182;
			//     v184 = *(_OWORD *)&chainSections.klass;
			//     *(_OWORD *)&v224.Vertex2.z = v183;
			//     *(float *)&v224.Active = v178;
			//     v5 = v224.VRange.y;
			//     v185 = *(_OWORD *)&chainSections.fields.ringBufferStart;
			//     *(_OWORD *)&v224.VRange.x = v184;
			//     v186 = *(_OWORD *)&chainSections.fields.defaultT.StartSize;
			//     *(_OWORD *)&v224.HeightFade.y = v185;
			//     v187 = *(_OWORD *)&chainSections[1].klass;
			//     *(_OWORD *)&v224.TimeFade.w = v186;
			//     v188 = *(_OWORD *)&chainSections[1].fields.ringBufferStart;
			//     *(_OWORD *)&v224.Position.y = v187;
			//     *(_OWORD *)&v224.Rotation.z = v188;
			//     v189 = v5 + v129;
			//     v190 = *(_OWORD *)&chainSections[2].klass;
			//     *(_OWORD *)&v224.Vertex0.x = *(_OWORD *)&chainSections[1].fields.defaultT.StartSize;
			//     v191 = *(_OWORD *)&chainSections[2].fields.ringBufferStart;
			//     *(_OWORD *)&v224.Vertex1.y = v190;
			//     *(_OWORD *)&v224.Vertex2.z = v191;
			//     *(float *)&v224.Active = v178;
			//     p_value = 1LL;
			//     v192 = v224.HeightFade.y;
			//   }
			//   v193 = this.fields.settingAsset;
			//   if ( !v193 )
			//     goto LABEL_51;
			//   v194 = v189 + v193.fields.decalNodeHeadLength;
			//   this.fields.cachedFadeEnd = v194;
			//   if ( (_BYTE)v133 )
			//   {
			//     *(_QWORD *)&v209.StartSize = 0LL;
			//     v209.VRange.x = 0.0;
			//     v209.VRange.y = v194;
			//     nodeDistanceThreshold = v193.fields.nodeDistanceThreshold;
			//     v209.Active = 1;
			//     p_value = (__int64)this.fields.chainSections;
			//     v209.StartSize = (float)(nodeDistanceThreshold * 0.5) + v194;
			//     if ( !p_value )
			//       goto LABEL_51;
			//     HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::AddNewNode(
			//       (TRingBuffer_1_HGInteractionChainSection_ *)p_value,
			//       &v209,
			//       MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::AddNewNode);
			//   }
			//   else
			//   {
			//     chainSections = this.fields.chainSections;
			//     if ( !chainSections )
			//       goto LABEL_51;
			//     HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::GetCurrentNode(
			//       &v209,
			//       chainSections,
			//       MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::GetCurrentNode);
			//     p_value = (__int64)this.fields.chainSections;
			//     v209.VRange.y = this.fields.cachedFadeEnd;
			//     if ( !p_value )
			//       goto LABEL_51;
			//     HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::SetCurrentNode(
			//       (TRingBuffer_1_HGInteractionChainSection_ *)p_value,
			//       &v209,
			//       MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::SetCurrentNode);
			//   }
			//   nodea.VRange.x = v5;
			//   *(_WORD *)(&nodea.Active + 1) = 0;
			//   *(&nodea.Active + 3) = 0;
			//   v196 = this.fields.chainSections;
			//   nodea.VRange.y = v189;
			//   if ( !v196 )
			//     goto LABEL_51;
			//   ringBufferEnd = v196.fields.ringBufferEnd;
			//   nodea.Position.y = node.GroundHeight;
			//   nodea.SectionIndex = ringBufferEnd;
			//   v198 = _mm_unpacklo_ps(decalNodeWidth_low, (__m128)0x3F800000u).m128_u64[0];
			//   nodea.Rotation = v222;
			//   nodea.TimeFade.x = 1.0;
			//   nodea.HeightFade.x = v192;
			//   nodea.HeightFade.y = v44;
			//   LODWORD(nodea.Position.x) = x_low.m128_i32[0];
			//   Position.z = decalNodeLength;
			//   nodea.TimeFade.y = 1.0;
			//   nodea.TimeFade.z = 1.0;
			//   nodea.TimeFade.w = 1.0;
			//   nodea.StartDist.x = -1.0;
			//   nodea.StartDist.y = -1.0;
			//   nodea.Position.z = v40;
			//   *(_QWORD *)&Position.x = v198;
			//   v199 = UnityEngine::Vector4::op_Implicit((Vector4 *)&Position, (MethodInfo *)chainSections);
			//   p_value = (__int64)&value;
			//   v200 = v220;
			//   nodea.Vertex2.z = v165;
			//   *(_QWORD *)&nodea.Vertex0.x = v219;
			//   nodea.Vertex0.z = v53;
			//   *(_QWORD *)&nodea.Vertex1.x = v220;
			//   nodea.Vertex1.z = v215;
			//   *(_QWORD *)&nodea.Vertex2.x = v164;
			//   *(_QWORD *)&nodea.Vertex3.x = v176;
			//   nodea.Active = 1;
			//   *(Vector2 *)&v210.x = v199;
			//   nodea.Vertex3.z = v225;
			//   nodea.Scale = v199;
			//   *(_OWORD *)&value.VRange.x = *(_OWORD *)&nodea.VRange.x;
			//   *(_OWORD *)&value.HeightFade.y = *(_OWORD *)&nodea.HeightFade.y;
			//   *(_OWORD *)&value.TimeFade.w = *(_OWORD *)&nodea.TimeFade.w;
			//   *(_OWORD *)&value.Position.y = *(_OWORD *)&nodea.Position.y;
			//   *(_OWORD *)&value.Rotation.z = *(_OWORD *)&nodea.Rotation.z;
			//   *(_OWORD *)&value.Vertex0.x = *(_OWORD *)&nodea.Vertex0.x;
			//   *(_OWORD *)&value.Vertex1.y = *(_OWORD *)&nodea.Vertex1.y;
			//   cachedFadeEnd = this.fields.cachedFadeEnd;
			//   *(_OWORD *)&value.Vertex2.z = *(_OWORD *)&nodea.Vertex2.z;
			//   *(_DWORD *)&value.Active = *(_DWORD *)&nodea.Active;
			//   nodea.VRange.x = v189;
			//   nodea.VRange.y = cachedFadeEnd;
			//   *(_WORD *)(&nodea.Active + 1) = 0;
			//   *(&nodea.Active + 3) = 0;
			//   if ( !this.fields.chainSections )
			//     goto LABEL_51;
			//   nodea.HeightFade.x = v44;
			//   LODWORD(nodea.Position.x) = x_low.m128_i32[0];
			//   Position.z = decalNodeLength;
			//   nodea.Position.z = v40;
			//   *(_QWORD *)&Position.x = v198;
			//   v202 = UnityEngine::Vector4::op_Implicit((Vector4 *)&Position, (MethodInfo *)chainSections);
			//   *(_QWORD *)&nodea.Vertex0.x = *(_QWORD *)&v211.x;
			//   nodea.Vertex0.z = v81;
			//   *(_QWORD *)&nodea.Vertex2.x = v203;
			//   nodea.Vertex2.z = v53;
			//   *(_QWORD *)&nodea.Vertex3.x = v200;
			//   nodea.Vertex3.z = v204;
			//   nodea.Vertex1.z = v213;
			//   *(_QWORD *)&nodea.Vertex1.x = *(_QWORD *)&v212.x;
			//   nodea.Scale = v202;
			//   *(_OWORD *)&v224.VRange.x = *(_OWORD *)&nodea.VRange.x;
			//   *(_OWORD *)&v224.HeightFade.y = *(_OWORD *)&nodea.HeightFade.y;
			//   *(_OWORD *)&v224.TimeFade.w = *(_OWORD *)&nodea.TimeFade.w;
			//   *(_OWORD *)&v224.Position.y = *(_OWORD *)&nodea.Position.y;
			//   *(_OWORD *)&v224.Rotation.z = *(_OWORD *)&nodea.Rotation.z;
			//   *(_OWORD *)&v224.Vertex0.x = *(_OWORD *)&nodea.Vertex0.x;
			//   v202.x = *(float *)((char *)&nodea.VRange.x + v205);
			//   *(_OWORD *)&v224.Vertex1.y = *(_OWORD *)&nodea.Vertex1.y;
			//   *(_OWORD *)(&value.Active + v205) = *(_OWORD *)&nodea.Vertex2.z;
			//   *(float *)((char *)&v224.VRange.x + v205) = v202.x;
			//   p_value = (__int64)this.fields.chainNodes;
			//   if ( (_BYTE)v133 )
			//   {
			//     if ( !p_value )
			//       goto LABEL_51;
			//     HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::AddNewNode(
			//       (TRingBuffer_1_HGInteractionChainNode_ *)p_value,
			//       &value,
			//       MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::AddNewNode);
			//   }
			//   else
			//   {
			//     if ( !p_value )
			//       goto LABEL_51;
			//     HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::SetNodeAtIndex(
			//       (TRingBuffer_1_HGInteractionChainNode_ *)p_value,
			//       *(_DWORD *)(p_value + 20),
			//       &value,
			//       MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::SetNodeAtIndex);
			//   }
			//   p_value = (__int64)this.fields.chainNodes;
			//   if ( !p_value )
			// LABEL_51:
			//     sub_180B536AC(p_value, chainSections);
			//   HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::AddNewNode(
			//     (TRingBuffer_1_HGInteractionChainNode_ *)p_value,
			//     &v224,
			//     MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::AddNewNode);
			// }
			// 
		}

		public void DrawChainNodes(CommandBuffer cmd, Material mat)
		{
			// // Void DrawChainNodes(CommandBuffer, Material)
			// void HG::Rendering::Runtime::HGInteractionChain::DrawChainNodes(
			//         HGInteractionChain *this,
			//         CommandBuffer *cmd,
			//         Material *mat,
			//         MethodInfo *method)
			// {
			//   MaterialPropertyBlock *static_fields; // rdx
			//   void *propertyBlock; // rcx
			//   ComputeBuffer *v9; // rax
			//   ComputeBuffer *v10; // rdi
			//   OneofDescriptorProto *v11; // rdx
			//   FileDescriptor *v12; // r8
			//   MessageDescriptor *v13; // r9
			//   MaterialPropertyBlock *v14; // rdi
			//   ComputeBuffer *v15; // rax
			//   ComputeBuffer *v16; // rdi
			//   OneofDescriptorProto *v17; // rdx
			//   FileDescriptor *v18; // r8
			//   MessageDescriptor *v19; // r9
			//   HGDecalInteractionSettingData__Array *settingData; // rax
			//   MaterialPropertyBlock *v21; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *size; // [rsp+20h] [rbp-48h]
			//   String__Array *sizea; // [rsp+20h] [rbp-48h]
			//   String *count; // [rsp+28h] [rbp-40h]
			//   String *counta; // [rsp+28h] [rbp-40h]
			//   MethodInfo *properties; // [rsp+30h] [rbp-38h]
			//   __int128 v28; // [rsp+50h] [rbp-18h]
			// 
			//   if ( !byte_18D919E01 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::ComputeBuffer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     byte_18D919E01 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1496, 0LL) )
			//   {
			//     propertyBlock = this.fields.propertyBlock;
			//     if ( !propertyBlock )
			//       goto LABEL_22;
			//     UnityEngine::MaterialPropertyBlock::Clear((MaterialPropertyBlock *)propertyBlock, 1, 0LL);
			//     if ( !this.fields.chainBuffer )
			//     {
			//       v9 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//       v10 = v9;
			//       if ( !v9 )
			//         goto LABEL_22;
			//       UnityEngine::ComputeBuffer::ComputeBuffer(v9, 100, 144, ComputeBufferType__Enum_Constant, 0LL);
			//       this.fields.chainBuffer = v10;
			//       sub_1800054D0((OneofDescriptor *)&this.fields.chainBuffer, v11, v12, v13, size, count, properties);
			//     }
			//     propertyBlock = this.fields.chainBuffer;
			//     if ( propertyBlock )
			//     {
			//       UnityEngine::ComputeBuffer::SetData((ComputeBuffer *)propertyBlock, (Array *)this.fields.interactionData, 0LL);
			//       v14 = this.fields.propertyBlock;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//       static_fields = (MaterialPropertyBlock *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( v14 )
			//       {
			//         UnityEngine::MaterialPropertyBlock::SetConstantBufferImpl(
			//           v14,
			//           HIDWORD(static_fields[148].monitor),
			//           this.fields.chainBuffer,
			//           0,
			//           14400,
			//           0LL);
			//         if ( !this.fields.settingDataBuffer )
			//         {
			//           v15 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//           v16 = v15;
			//           if ( !v15 )
			//             goto LABEL_22;
			//           UnityEngine::ComputeBuffer::ComputeBuffer(v15, 1, 32, ComputeBufferType__Enum_Constant, 0LL);
			//           this.fields.settingDataBuffer = v16;
			//           sub_1800054D0((OneofDescriptor *)&this.fields.settingDataBuffer, v17, v18, v19, sizea, counta, properties);
			//         }
			//         *((_QWORD *)&v28 + 1) = 0LL;
			//         propertyBlock = this.fields.settingAsset;
			//         settingData = this.fields.settingData;
			//         if ( propertyBlock )
			//         {
			//           LODWORD(v28) = *((_DWORD *)propertyBlock + 12);
			//           *((float *)&v28 + 1) = 1.0 / *((float *)propertyBlock + 13);
			//           if ( settingData )
			//           {
			//             if ( !settingData.max_length.size )
			//               sub_180070270(propertyBlock, static_fields);
			//             *(_OWORD *)&settingData.vector[0]._decalNodeWidth = *((_OWORD *)propertyBlock + 2);
			//             *(_OWORD *)&settingData.vector[0]._nodeDistanceThreshold = v28;
			//             propertyBlock = this.fields.settingDataBuffer;
			//             if ( propertyBlock )
			//             {
			//               UnityEngine::ComputeBuffer::SetData(
			//                 (ComputeBuffer *)propertyBlock,
			//                 (Array *)this.fields.settingData,
			//                 0LL);
			//               v21 = this.fields.propertyBlock;
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//               static_fields = (MaterialPropertyBlock *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//               if ( v21 )
			//               {
			//                 UnityEngine::MaterialPropertyBlock::SetConstantBufferImpl(
			//                   v21,
			//                   (int32_t)static_fields[148].fields.m_Ptr,
			//                   this.fields.settingDataBuffer,
			//                   0,
			//                   32,
			//                   0LL);
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
			//                 static_fields = this.fields.propertyBlock;
			//                 propertyBlock = TypeInfo::HG::Rendering::Runtime::HGInteractionResources.static_fields;
			//                 if ( cmd )
			//                 {
			//                   UnityEngine::Rendering::CommandBuffer::HGDrawMeshInstanced(
			//                     cmd,
			//                     *((Mesh **)propertyBlock + 2),
			//                     0,
			//                     mat,
			//                     3,
			//                     this.fields.activeCount,
			//                     static_fields,
			//                     0LL);
			//                   return;
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_22:
			//     sub_180B536AC(propertyBlock, static_fields);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1496, 0LL);
			//   if ( !Patch )
			//     goto LABEL_22;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//     (ILFixDynamicMethodWrapper_28 *)Patch,
			//     (Object *)this,
			//     (Object *)cmd,
			//     (Object *)mat,
			//     0LL);
			// }
			// 
		}

		public void UpdateChainFade()
		{
			// // Void UpdateChainFade()
			// void HG::Rendering::Runtime::HGInteractionChain::UpdateChainFade(HGInteractionChain *this, MethodInfo *method)
			// {
			//   _OWORD *chainSections; // rdx
			//   TRingBuffer_1_HGInteractionChainSection_ *v4; // rcx
			//   float deltaTime; // xmm0_4
			//   HGInteractionSettingAsset *settingAsset; // rax
			//   TRingBuffer_1_HGInteractionChainNode_ *chainNodes; // rdi
			//   float v8; // xmm7_4
			//   unsigned int ringBufferStart; // edi
			//   unsigned int ringBufferEnd; // esi
			//   __int64 v11; // rax
			//   __int64 v12; // r8
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   __int128 v15; // xmm1
			//   __int128 v16; // xmm0
			//   __int128 v17; // xmm1
			//   __int128 v18; // xmm0
			//   __int128 v19; // xmm1
			//   __int128 v20; // xmm0
			//   __int128 v21; // xmm0
			//   __int128 v22; // xmm1
			//   __int128 v23; // xmm0
			//   __int128 v24; // xmm1
			//   __int128 v25; // xmm0
			//   __int128 v26; // xmm1
			//   __m128 *v27; // rax
			//   float v28; // xmm9_4
			//   int v29; // r14d
			//   float v30; // xmm8_4
			//   __int128 v31; // xmm1
			//   __int128 v32; // xmm0
			//   __int128 v33; // xmm1
			//   __int128 v34; // xmm0
			//   __int128 v35; // xmm1
			//   __int128 v36; // xmm0
			//   __int128 v37; // xmm1
			//   int v38; // eax
			//   __int128 v39; // xmm0
			//   int v40; // eax
			//   __int128 v41; // xmm1
			//   __int128 v42; // xmm0
			//   __int128 v43; // xmm1
			//   __int128 v44; // xmm0
			//   __int128 v45; // xmm1
			//   __int128 v46; // xmm0
			//   __int128 v47; // xmm1
			//   __int128 v48; // xmm0
			//   __int128 v49; // xmm1
			//   __int128 v50; // xmm0
			//   __int128 v51; // xmm1
			//   __int128 v52; // xmm0
			//   __int128 v53; // xmm1
			//   __int128 v54; // xmm0
			//   __int128 v55; // xmm1
			//   __int128 v56; // xmm0
			//   __int128 v57; // xmm1
			//   __int128 v58; // xmm0
			//   __int128 v59; // xmm1
			//   __int128 v60; // xmm0
			//   __int128 v61; // xmm1
			//   __int128 v62; // xmm0
			//   __int128 v63; // xmm1
			//   __int128 v64; // xmm1
			//   __int128 v65; // xmm0
			//   __int128 v66; // xmm1
			//   __int128 v67; // xmm0
			//   __int128 v68; // xmm1
			//   __int128 v69; // xmm0
			//   __int128 v70; // xmm1
			//   __int128 v71; // xmm1
			//   __int128 v72; // xmm0
			//   __int128 v73; // xmm1
			//   __int128 v74; // xmm0
			//   __int128 v75; // xmm1
			//   __int128 v76; // xmm0
			//   __int128 v77; // xmm1
			//   int v78; // eax
			//   __int128 v79; // xmm1
			//   __int128 v80; // xmm0
			//   __int128 v81; // xmm1
			//   __int128 v82; // xmm0
			//   __int128 v83; // xmm1
			//   __int128 v84; // xmm0
			//   __int128 v85; // xmm1
			//   HGInteractionSettingAsset *v86; // rax
			//   float v87; // xmm0_4
			//   float v88; // xmm0_4
			//   Vector4 v89; // xmm2
			//   float v90; // xmm1_4
			//   float v91; // xmm0_4
			//   float v92; // xmm3_4
			//   float v93; // xmm1_4
			//   float v94; // xmm0_4
			//   HGInteractionChainSection *v95; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v97; // [rsp+28h] [rbp-E0h]
			//   Vector4 v98; // [rsp+38h] [rbp-D0h]
			//   Vector4 v99; // [rsp+48h] [rbp-C0h]
			//   HGInteractionChainSection value_8; // [rsp+58h] [rbp-B0h] BYREF
			//   HGInteractionChainNode v101; // [rsp+68h] [rbp-A0h] BYREF
			//   __int128 v102; // [rsp+F8h] [rbp-10h]
			//   __int128 v103; // [rsp+108h] [rbp+0h]
			//   __int128 v104; // [rsp+118h] [rbp+10h]
			//   __int128 v105; // [rsp+128h] [rbp+20h]
			//   __int128 v106; // [rsp+138h] [rbp+30h]
			//   __int128 v107; // [rsp+148h] [rbp+40h]
			//   __int128 v108; // [rsp+158h] [rbp+50h]
			//   __int128 v109; // [rsp+168h] [rbp+60h]
			//   int v110; // [rsp+178h] [rbp+70h]
			//   __int128 v111; // [rsp+188h] [rbp+80h] BYREF
			//   __int128 v112; // [rsp+198h] [rbp+90h]
			//   __int128 v113; // [rsp+1A8h] [rbp+A0h]
			//   __int128 v114; // [rsp+1B8h] [rbp+B0h]
			//   __int128 v115; // [rsp+1C8h] [rbp+C0h]
			//   __int128 v116; // [rsp+1D8h] [rbp+D0h]
			//   __int128 v117; // [rsp+1E8h] [rbp+E0h]
			//   __int128 v118; // [rsp+1F8h] [rbp+F0h]
			//   int v119; // [rsp+208h] [rbp+100h]
			//   _BYTE v120[16]; // [rsp+218h] [rbp+110h] BYREF
			//   __int128 v121; // [rsp+228h] [rbp+120h] BYREF
			//   __int128 v122; // [rsp+238h] [rbp+130h]
			//   __int128 v123; // [rsp+248h] [rbp+140h]
			//   __int128 v124; // [rsp+258h] [rbp+150h]
			//   __int128 v125; // [rsp+268h] [rbp+160h]
			//   __int128 v126; // [rsp+278h] [rbp+170h]
			//   __int128 v127; // [rsp+288h] [rbp+180h]
			//   __int128 v128; // [rsp+298h] [rbp+190h]
			//   int v129; // [rsp+2A8h] [rbp+1A0h]
			//   _BYTE v130[208]; // [rsp+2B8h] [rbp+1B0h] BYREF
			// 
			//   if ( !byte_18D919E02 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::DeleteTailNodes);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetNextIndex);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::GetNodeAtIndex);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetNodeAtIndex);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::SetNodeAtIndex);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::SetNodeAtIndex);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::get_EndIndex);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::get_StartIndex);
			//     byte_18D919E02 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1497, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1497, 0LL);
			//     if ( !Patch )
			//       goto LABEL_49;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     deltaTime = UnityEngine::Time::get_deltaTime(0LL);
			//     settingAsset = this.fields.settingAsset;
			//     if ( !settingAsset )
			//       goto LABEL_49;
			//     chainNodes = this.fields.chainNodes;
			//     v8 = deltaTime * settingAsset.fields.timeFadeSpeed;
			//     if ( !chainNodes )
			//       goto LABEL_49;
			//     ringBufferStart = chainNodes.fields.ringBufferStart;
			//     ringBufferEnd = this.fields.chainNodes.fields.ringBufferEnd;
			//     if ( ringBufferEnd != -1 && ringBufferEnd != ringBufferStart )
			//     {
			//       v11 = sub_180835FDC(&v111, this.fields.chainNodes, ringBufferEnd);
			//       chainSections = this.fields.chainSections;
			//       v12 = v11;
			//       v13 = *(_OWORD *)(v11 + 16);
			//       v102 = *(_OWORD *)v11;
			//       v14 = *(_OWORD *)(v11 + 32);
			//       v103 = v13;
			//       v15 = *(_OWORD *)(v11 + 48);
			//       v104 = v14;
			//       v16 = *(_OWORD *)(v11 + 64);
			//       v105 = v15;
			//       v17 = *(_OWORD *)(v11 + 80);
			//       v106 = v16;
			//       v18 = *(_OWORD *)(v11 + 96);
			//       v107 = v17;
			//       v19 = *(_OWORD *)(v11 + 16);
			//       v108 = v18;
			//       v20 = *(_OWORD *)(v11 + 112);
			//       LODWORD(v11) = *(_DWORD *)(v11 + 128);
			//       v109 = v20;
			//       v110 = v11;
			//       v4 = (TRingBuffer_1_HGInteractionChainSection_ *)&v121;
			//       LODWORD(v11) = *(_DWORD *)(v12 + 128);
			//       v121 = *(_OWORD *)v12;
			//       v21 = *(_OWORD *)(v12 + 32);
			//       v122 = v19;
			//       v22 = *(_OWORD *)(v12 + 48);
			//       v123 = v21;
			//       v23 = *(_OWORD *)(v12 + 64);
			//       v124 = v22;
			//       v24 = *(_OWORD *)(v12 + 80);
			//       v125 = v23;
			//       v25 = *(_OWORD *)(v12 + 96);
			//       v126 = v24;
			//       v26 = *(_OWORD *)(v12 + 112);
			//       v127 = v25;
			//       v128 = v26;
			//       v129 = v11;
			//       if ( chainSections )
			//       {
			//         v27 = (__m128 *)sub_180835FBC(&value_8, chainSections, DWORD2(v121));
			//         v28 = -1.0;
			//         v29 = DWORD2(v102);
			//         v30 = _mm_shuffle_ps(*v27, *v27, 85).m128_f32[0] - _mm_shuffle_ps(*v27, *v27, 170).m128_f32[0];
			//         while ( 1 )
			//         {
			//           chainSections = this.fields.chainNodes;
			//           if ( !chainSections )
			//             break;
			//           chainSections = (_OWORD *)sub_180835FDC(v130, chainSections, ringBufferStart);
			//           v31 = chainSections[1];
			//           *(_OWORD *)&v101.VRange.x = *chainSections;
			//           v32 = chainSections[2];
			//           *(_OWORD *)&v101.HeightFade.y = v31;
			//           v33 = chainSections[3];
			//           *(_OWORD *)&v101.TimeFade.w = v32;
			//           v34 = chainSections[4];
			//           *(_OWORD *)&v101.Position.y = v33;
			//           v35 = chainSections[5];
			//           *(_OWORD *)&v101.Rotation.z = v34;
			//           v36 = chainSections[6];
			//           *(_OWORD *)&v101.Vertex0.x = v35;
			//           v37 = chainSections[7];
			//           v38 = *((_DWORD *)chainSections + 32);
			//           *(_OWORD *)&v101.Vertex1.y = v36;
			//           v39 = *chainSections;
			//           *(_OWORD *)&v101.Vertex2.z = v37;
			//           *(_DWORD *)&v101.Active = v38;
			//           v40 = *((_DWORD *)chainSections + 32);
			//           v41 = chainSections[1];
			//           v102 = v39;
			//           v42 = chainSections[2];
			//           v103 = v41;
			//           v43 = chainSections[3];
			//           v104 = v42;
			//           v44 = chainSections[4];
			//           v105 = v43;
			//           v45 = chainSections[5];
			//           v106 = v44;
			//           v46 = chainSections[6];
			//           v107 = v45;
			//           v47 = chainSections[7];
			//           v108 = v46;
			//           v48 = *chainSections;
			//           v109 = v47;
			//           v110 = v40;
			//           v49 = chainSections[1];
			//           v121 = v48;
			//           v50 = chainSections[2];
			//           v122 = v49;
			//           v51 = chainSections[3];
			//           v123 = v50;
			//           v52 = chainSections[4];
			//           v124 = v51;
			//           v53 = chainSections[5];
			//           v125 = v52;
			//           v54 = chainSections[6];
			//           v126 = v53;
			//           v55 = chainSections[7];
			//           v127 = v54;
			//           v56 = *chainSections;
			//           v128 = v55;
			//           v129 = v40;
			//           v4 = (TRingBuffer_1_HGInteractionChainSection_ *)&v111;
			//           v57 = chainSections[1];
			//           v111 = v56;
			//           v58 = chainSections[2];
			//           v112 = v57;
			//           v59 = chainSections[3];
			//           v113 = v58;
			//           v60 = chainSections[4];
			//           v114 = v59;
			//           v61 = chainSections[5];
			//           v115 = v60;
			//           v62 = chainSections[6];
			//           v116 = v61;
			//           v63 = chainSections[7];
			//           v117 = v62;
			//           v118 = v63;
			//           v119 = v40;
			//           if ( DWORD2(v111) == v29 )
			//           {
			//             v4 = (TRingBuffer_1_HGInteractionChainSection_ *)&v111;
			//             v64 = chainSections[1];
			//             v111 = *chainSections;
			//             v65 = chainSections[2];
			//             v112 = v64;
			//             v66 = chainSections[3];
			//             v113 = v65;
			//             v67 = chainSections[4];
			//             v114 = v66;
			//             v68 = chainSections[5];
			//             v115 = v67;
			//             v69 = chainSections[6];
			//             v116 = v68;
			//             v70 = chainSections[7];
			//             v117 = v69;
			//             v118 = v70;
			//             v119 = v40;
			//             if ( v30 < *((float *)&v111 + 1) )
			//             {
			//               if ( v28 < 0.0 )
			//               {
			//                 v71 = chainSections[1];
			//                 v111 = *chainSections;
			//                 v72 = chainSections[2];
			//                 v112 = v71;
			//                 v73 = chainSections[3];
			//                 v113 = v72;
			//                 v74 = chainSections[4];
			//                 v114 = v73;
			//                 v75 = chainSections[5];
			//                 v115 = v74;
			//                 v76 = chainSections[6];
			//                 v116 = v75;
			//                 v77 = chainSections[7];
			//                 v117 = v76;
			//                 v118 = v77;
			//                 v119 = v40;
			//                 v28 = *(float *)&v111;
			//               }
			//               v78 = *((_DWORD *)chainSections + 32);
			//               v4 = (TRingBuffer_1_HGInteractionChainSection_ *)&v111;
			//               v79 = chainSections[1];
			//               v111 = *chainSections;
			//               v80 = chainSections[2];
			//               v112 = v79;
			//               v81 = chainSections[3];
			//               v113 = v80;
			//               v82 = chainSections[4];
			//               v114 = v81;
			//               v83 = chainSections[5];
			//               v115 = v82;
			//               v84 = chainSections[6];
			//               v116 = v83;
			//               v85 = chainSections[7];
			//               v117 = v84;
			//               v118 = v85;
			//               v119 = v78;
			//               v86 = this.fields.settingAsset;
			//               if ( !v86 )
			//                 break;
			//               if ( v86.fields.edgeFadeDistance <= (float)(*(float *)&v111 - v28) )
			//               {
			//                 v87 = 1.0;
			//               }
			//               else
			//               {
			//                 v87 = *((float *)&v103 + 2) - v8;
			//                 if ( (float)(*((float *)&v103 + 2) - v8) <= 0.0 )
			//                   v87 = 0.0;
			//               }
			//               v97.y = v87;
			//               v88 = *((float *)&v123 + 2);
			//               v97.x = 1.0;
			//               *(_QWORD *)&v97.z = 0x3F8000003F800000LL;
			//               v89.x = 1.0;
			//               v101.TimeFade = v97;
			//               if ( *((float *)&v123 + 2) < 0.0 )
			//                 v88 = v30;
			//               if ( v28 > v88 )
			//                 v88 = v28;
			//               v101.StartDist.x = v30;
			//               v101.StartDist.y = v88;
			//               goto LABEL_38;
			//             }
			//             v90 = *((float *)&v103 + 1) - v8;
			//             if ( (float)(*((float *)&v103 + 1) - v8) <= 0.0 )
			//               v90 = 0.0;
			//             v91 = *((float *)&v103 + 2) - v8;
			//             if ( (float)(*((float *)&v103 + 2) - v8) <= 0.0 )
			//               v91 = 0.0;
			//             *(_QWORD *)&v98.x = __PAIR64__(LODWORD(v91), LODWORD(v90));
			//             *(_QWORD *)&v98.z = 0x3F8000003F800000LL;
			//             v89 = v98;
			//             v101.StartDist.y = *((float *)&v123 + 2);
			//             v101.StartDist.x = v30;
			//           }
			//           else
			//           {
			//             v92 = *((float *)&v103 + 1) - v8;
			//             if ( (float)(*((float *)&v103 + 1) - v8) <= 0.0 )
			//               v92 = 0.0;
			//             v93 = *((float *)&v103 + 2) - v8;
			//             if ( (float)(*((float *)&v103 + 2) - v8) <= 0.0 )
			//               v93 = 0.0;
			//             v94 = *((float *)&v103 + 3) - v8;
			//             if ( (float)(*((float *)&v103 + 3) - v8) <= 0.0 )
			//               v94 = 0.0;
			//             *(_QWORD *)&v99.z = LODWORD(v94) | 0x3F80000000000000LL;
			//             *(_QWORD *)&v99.x = __PAIR64__(LODWORD(v93), LODWORD(v92));
			//             v89 = v99;
			//             v101.StartDist = *(Vector2 *)((char *)&v123 + 4);
			//           }
			//           v101.TimeFade = v89;
			// LABEL_38:
			//           if ( v89.x == 0.0 )
			//           {
			//             chainSections = this.fields.chainSections;
			//             if ( !chainSections )
			//               break;
			//             v95 = (HGInteractionChainSection *)sub_180835FBC(v120, chainSections, (unsigned int)v101.SectionIndex);
			//             v4 = this.fields.chainSections;
			//             value_8 = *v95;
			//             value_8.VRange.x = v101.VRange.y;
			//             if ( !v4 )
			//               break;
			//             HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::SetNodeAtIndex(
			//               v4,
			//               v101.SectionIndex,
			//               &value_8,
			//               MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::SetNodeAtIndex);
			//             v4 = (TRingBuffer_1_HGInteractionChainSection_ *)this.fields.chainNodes;
			//             if ( !v4 )
			//               break;
			//             HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::DeleteTailNodes(
			//               (TRingBuffer_1_HGInteractionChainNode_ *)v4,
			//               1,
			//               MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::DeleteTailNodes);
			//           }
			//           else
			//           {
			//             v4 = (TRingBuffer_1_HGInteractionChainSection_ *)this.fields.chainNodes;
			//             if ( !v4 )
			//               break;
			//             HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::SetNodeAtIndex(
			//               (TRingBuffer_1_HGInteractionChainNode_ *)v4,
			//               ringBufferStart,
			//               &v101,
			//               MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::SetNodeAtIndex);
			//           }
			//           v4 = (TRingBuffer_1_HGInteractionChainSection_ *)this.fields.chainNodes;
			//           if ( !v4 )
			//             break;
			//           ringBufferStart = HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetNextIndex(
			//                               (TRingBuffer_1_HGInteractionChainNode_ *)v4,
			//                               ringBufferStart,
			//                               MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetNextIndex);
			//           if ( ringBufferStart == ringBufferEnd )
			//             return;
			//         }
			//       }
			// LABEL_49:
			//       sub_180B536AC(v4, chainSections);
			//     }
			//   }
			// }
			// 
		}

		public void UpdateRenderData()
		{
			// // Void UpdateRenderData()
			// void HG::Rendering::Runtime::HGInteractionChain::UpdateRenderData(HGInteractionChain *this, MethodInfo *method)
			// {
			//   TileBase *chainSections; // rdx
			//   TRingBuffer_1_HGInteractionChainNode_ *chainNodes; // rcx
			//   int32_t NodeCount; // eax
			//   int32_t v6; // esi
			//   unsigned int ringBufferStart; // r14d
			//   int32_t v8; // edi
			//   __int64 v9; // r8
			//   ITilemap *v10; // r9
			//   __int128 v11; // xmm1
			//   __int128 v12; // xmm0
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   __int128 v15; // xmm1
			//   __int128 v16; // xmm0
			//   __int128 v17; // xmm1
			//   int v18; // eax
			//   __int128 v19; // xmm0
			//   __int128 v20; // xmm1
			//   int v21; // eax
			//   __int128 v22; // xmm0
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm1
			//   TileAnimationData *TileAnimationDataNoRef; // rax
			//   __int128 *v29; // r8
			//   __int128 v30; // xmm1
			//   __m128i v31; // xmm6
			//   int v32; // eax
			//   __int128 v33; // xmm0
			//   __int128 v34; // xmm1
			//   __int128 v35; // xmm0
			//   __int128 v36; // xmm1
			//   __int128 v37; // xmm0
			//   __int128 v38; // xmm1
			//   __int128 v39; // xmm1
			//   __int128 v40; // xmm0
			//   __int128 v41; // xmm1
			//   __int128 v42; // xmm0
			//   __int128 v43; // xmm1
			//   __int128 v44; // xmm0
			//   __int128 v45; // xmm1
			//   __m128 *v46; // rax
			//   Matrix4x4 *Matrix; // rax
			//   __m128i v48; // xmm1
			//   __m128i v49; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __m128i v51; // [rsp+28h] [rbp-E0h]
			//   __m128i v52; // [rsp+38h] [rbp-D0h] BYREF
			//   __m128i v53; // [rsp+48h] [rbp-C0h]
			//   __m128i v54; // [rsp+58h] [rbp-B0h]
			//   __m128i v55; // [rsp+68h] [rbp-A0h]
			//   __m128i v56; // [rsp+78h] [rbp-90h]
			//   __m128i v57; // [rsp+88h] [rbp-80h]
			//   __m128i v58; // [rsp+98h] [rbp-70h]
			//   __m128i v59; // [rsp+A8h] [rbp-60h]
			//   Vector4 TimeFade; // [rsp+B8h] [rbp-50h]
			//   HGInteractionChainNode v61; // [rsp+C8h] [rbp-40h] BYREF
			//   TileAnimationData v62; // [rsp+158h] [rbp+50h] BYREF
			//   char v63[16]; // [rsp+168h] [rbp+60h] BYREF
			//   __int128 v64; // [rsp+178h] [rbp+70h] BYREF
			//   __int128 v65; // [rsp+188h] [rbp+80h]
			//   __int128 v66; // [rsp+198h] [rbp+90h]
			//   __int128 v67; // [rsp+1A8h] [rbp+A0h]
			//   __int128 v68; // [rsp+1B8h] [rbp+B0h]
			//   __int128 v69; // [rsp+1C8h] [rbp+C0h]
			//   __int128 v70; // [rsp+1D8h] [rbp+D0h]
			//   __int128 v71; // [rsp+1E8h] [rbp+E0h]
			//   int v72; // [rsp+1F8h] [rbp+F0h]
			//   __m128i v73[9]; // [rsp+208h] [rbp+100h] BYREF
			//   Matrix4x4 v74; // [rsp+298h] [rbp+190h] BYREF
			// 
			//   if ( !byte_18D919E03 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetNextIndex);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::GetNodeAtIndex);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetNodeAtIndex);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetNodeCount);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::get_StartIndex);
			//     byte_18D919E03 = 1;
			//   }
			//   sub_1802F01E0(&v52, 0LL, 144LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(1498, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1498, 0LL);
			//     if ( !Patch )
			//       goto LABEL_19;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.activeCount = 0;
			//     chainNodes = this.fields.chainNodes;
			//     if ( !chainNodes )
			//       goto LABEL_19;
			//     NodeCount = HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetNodeCount(
			//                   chainNodes,
			//                   MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetNodeCount);
			//     v6 = NodeCount;
			//     if ( NodeCount )
			//     {
			//       chainNodes = this.fields.chainNodes;
			//       if ( !chainNodes )
			//         goto LABEL_19;
			//       ringBufferStart = chainNodes.fields.ringBufferStart;
			//       v8 = 0;
			//       if ( NodeCount > 0 )
			//       {
			//         while ( 1 )
			//         {
			//           chainSections = (TileBase *)this.fields.chainNodes;
			//           if ( !chainSections )
			//             break;
			//           v9 = sub_180835FDC(v73, chainSections, ringBufferStart);
			//           v11 = *(_OWORD *)(v9 + 16);
			//           *(_OWORD *)&v61.VRange.x = *(_OWORD *)v9;
			//           v12 = *(_OWORD *)(v9 + 32);
			//           *(_OWORD *)&v61.HeightFade.y = v11;
			//           v13 = *(_OWORD *)(v9 + 48);
			//           *(_OWORD *)&v61.TimeFade.w = v12;
			//           v14 = *(_OWORD *)(v9 + 64);
			//           *(_OWORD *)&v61.Position.y = v13;
			//           v15 = *(_OWORD *)(v9 + 80);
			//           *(_OWORD *)&v61.Rotation.z = v14;
			//           v16 = *(_OWORD *)(v9 + 96);
			//           *(_OWORD *)&v61.Vertex0.x = v15;
			//           v17 = *(_OWORD *)(v9 + 112);
			//           v18 = *(_DWORD *)(v9 + 128);
			//           *(_OWORD *)&v61.Vertex1.y = v16;
			//           v19 = *(_OWORD *)v9;
			//           *(_OWORD *)&v61.Vertex2.z = v17;
			//           *(_DWORD *)&v61.Active = v18;
			//           v20 = *(_OWORD *)(v9 + 16);
			//           v21 = *(_DWORD *)(v9 + 128);
			//           v64 = v19;
			//           v22 = *(_OWORD *)(v9 + 32);
			//           v65 = v20;
			//           v23 = *(_OWORD *)(v9 + 48);
			//           v66 = v22;
			//           v24 = *(_OWORD *)(v9 + 64);
			//           v67 = v23;
			//           v25 = *(_OWORD *)(v9 + 80);
			//           v68 = v24;
			//           v26 = *(_OWORD *)(v9 + 96);
			//           v69 = v25;
			//           v27 = *(_OWORD *)(v9 + 112);
			//           v70 = v26;
			//           v71 = v27;
			//           v72 = v21;
			//           if ( (_BYTE)v21 )
			//           {
			//             TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                                        &v62,
			//                                        chainSections,
			//                                        (Vector3Int *)v9,
			//                                        v10,
			//                                        (MethodInfo *)v51.m128i_i64[0]);
			//             v30 = v29[1];
			//             v31 = _mm_loadu_si128((const __m128i *)TileAnimationDataNoRef);
			//             v32 = *((_DWORD *)v29 + 32);
			//             v64 = *v29;
			//             v33 = v29[2];
			//             v65 = v30;
			//             v34 = v29[3];
			//             v66 = v33;
			//             v35 = v29[4];
			//             v67 = v34;
			//             v36 = v29[5];
			//             v68 = v35;
			//             v37 = v29[6];
			//             v69 = v36;
			//             v38 = v29[7];
			//             v70 = v37;
			//             v71 = v38;
			//             v72 = v32;
			//             v51.m128i_i64[0] = v31.m128i_i64[0];
			//             if ( (SDWORD2(v64) & 0x80000000) == 0 )
			//             {
			//               chainSections = (TileBase *)this.fields.chainSections;
			//               chainNodes = (TRingBuffer_1_HGInteractionChainNode_ *)&v64;
			//               v39 = v29[1];
			//               v64 = *v29;
			//               v40 = v29[2];
			//               v65 = v39;
			//               v41 = v29[3];
			//               v66 = v40;
			//               v42 = v29[4];
			//               v67 = v41;
			//               v43 = v29[5];
			//               v68 = v42;
			//               v44 = v29[6];
			//               v69 = v43;
			//               v45 = v29[7];
			//               v70 = v44;
			//               v71 = v45;
			//               v72 = v32;
			//               if ( !chainSections )
			//                 break;
			//               v46 = (__m128 *)sub_180835FBC(v63, chainSections, DWORD2(v64));
			//               v51.m128i_i32[0] = (__int32)*v46;
			//               v51.m128i_i32[1] = _mm_shuffle_ps(*v46, *v46, 85).m128_u32[0];
			//               v51.m128i_i64[1] = (__int64)v61.StartDist;
			//               v31 = v51;
			//             }
			//             sub_1802F01E0(&v52, 0LL, 144LL);
			//             Matrix = HG::Rendering::Runtime::HGInteractionChainNode::GetMatrix(&v74, &v61, 0LL);
			//             chainSections = (TileBase *)this.fields.activeCount;
			//             chainNodes = (TRingBuffer_1_HGInteractionChainNode_ *)this.fields.interactionData;
			//             v59 = v31;
			//             v48 = *(__m128i *)&Matrix.m01;
			//             v52 = *(__m128i *)&Matrix.m00;
			//             v53 = v48;
			//             v49 = *(__m128i *)&Matrix.m03;
			//             v54 = *(__m128i *)&Matrix.m02;
			//             v56.m128i_i32[0] = LODWORD(v61.Vertex0.x);
			//             v55 = v49;
			//             *(__int64 *)((char *)v56.m128i_i64 + 4) = *(_QWORD *)&v61.Vertex0.z;
			//             v57.m128i_i32[0] = LODWORD(v61.Vertex2.x);
			//             v56.m128i_i32[3] = LODWORD(v61.Vertex1.z);
			//             *(__int64 *)((char *)v57.m128i_i64 + 4) = *(_QWORD *)&v61.Vertex2.z;
			//             v58.m128i_i32[0] = LODWORD(v61.VRange.x);
			//             v57.m128i_i32[3] = LODWORD(v61.Vertex3.z);
			//             *(__int64 *)((char *)v58.m128i_i64 + 4) = __PAIR64__(LODWORD(v61.HeightFade.x), LODWORD(v61.VRange.y));
			//             v58.m128i_i32[3] = LODWORD(v61.HeightFade.y);
			//             this.fields.activeCount = (_DWORD)chainSections + 1;
			//             TimeFade = v61.TimeFade;
			//             if ( !chainNodes )
			//               break;
			//             v73[0] = v52;
			//             v73[1] = v53;
			//             v73[2] = v54;
			//             v73[3] = v55;
			//             v73[4] = v56;
			//             v73[5] = v57;
			//             v73[6] = v58;
			//             v73[7] = v59;
			//             v73[8] = (__m128i)TimeFade;
			//             sub_180835F40(chainNodes, chainSections, v73);
			//           }
			//           chainNodes = this.fields.chainNodes;
			//           ++v8;
			//           if ( !chainNodes )
			//             break;
			//           ringBufferStart = HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetNextIndex(
			//                               chainNodes,
			//                               ringBufferStart,
			//                               MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetNextIndex);
			//           if ( v8 >= v6 )
			//             return;
			//         }
			// LABEL_19:
			//         sub_180B536AC(chainNodes, chainSections);
			//       }
			//     }
			//   }
			// }
			// 
		}

		private const int CHAIN_MAX_NODE_COUNT = 100;

		public bool IsFree;

		public int LastAccessFrame;

		private TRingBuffer<HGInteractionChainNode> chainNodes;

		private TRingBuffer<HGInteractionChainSection> chainSections;

		private int activeCount;

		private HGDecalInteractionData[] interactionData;

		private ComputeBuffer chainBuffer;

		private HGDecalInteractionSettingData[] settingData;

		private ComputeBuffer settingDataBuffer;

		private MaterialPropertyBlock propertyBlock;

		private float cachedFadeEnd;

		private HGInteractionSettingAsset settingAsset;
	}
}
