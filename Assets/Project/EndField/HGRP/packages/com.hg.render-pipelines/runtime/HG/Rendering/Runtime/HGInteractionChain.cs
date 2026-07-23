using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGInteractionChain // TypeDefIndex: 37745
	{
		// Fields
		private const int CHAIN_MAX_NODE_COUNT = 100; // Metadata: 0x02303089
		public bool IsFree; // 0x10
		public int LastAccessFrame; // 0x14
		private TRingBuffer<HGInteractionChainNode> chainNodes; // 0x18
		private TRingBuffer<HGInteractionChainSection> chainSections; // 0x20
		private int activeCount; // 0x28
		private HGDecalInteractionData[] interactionData; // 0x30
		private ComputeBuffer chainBuffer; // 0x38
		private HGDecalInteractionSettingData[] settingData; // 0x40
		private ComputeBuffer settingDataBuffer; // 0x48
		private MaterialPropertyBlock propertyBlock; // 0x50
		private float cachedFadeEnd; // 0x58
		private HGInteractionSettingAsset settingAsset; // 0x60
	
		// Constructors
		public HGInteractionChain() {} // Dummy constructor
		public HGInteractionChain(HGInteractionSettingAsset _settingAsset) {} // 0x0000000189CFE038-0x0000000189CFE248
		// HGInteractionChain(HGInteractionSettingAsset)
		void HG::Rendering::Runtime::HGInteractionChain::HGInteractionChain(
		        HGInteractionChain *this,
		        HGInteractionSettingAsset *_settingAsset,
		        MethodInfo *method)
		{
		  HGInteractionChainNode *DefaultValue; // rax
		  __int128 v6; // xmm1
		  __int128 v7; // xmm0
		  __int128 v8; // xmm1
		  __int128 v9; // xmm0
		  __int128 v10; // xmm1
		  __int128 v11; // xmm0
		  __int128 v12; // xmm0
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  TRingBuffer_1_HGInteractionChainNode_ *v15; // rdi
		  Type *v16; // rdx
		  PropertyInfo_1 *v17; // r8
		  Int32__Array **v18; // r9
		  HGInteractionChainSection v19; // xmm6
		  TRingBuffer_1_HGInteractionChainSection_ *v20; // rax
		  TRingBuffer_1_HGInteractionChainSection_ *v21; // rdi
		  Type *v22; // rdx
		  PropertyInfo_1 *v23; // r8
		  Int32__Array **v24; // r9
		  Type *v25; // rdx
		  PropertyInfo_1 *v26; // r8
		  Int32__Array **v27; // r9
		  Type *v28; // rdx
		  PropertyInfo_1 *v29; // r8
		  Int32__Array **v30; // r9
		  MaterialPropertyBlock *v31; // rdi
		  Type *v32; // rdx
		  PropertyInfo_1 *v33; // r8
		  Int32__Array **v34; // r9
		  Type *v35; // rdx
		  PropertyInfo_1 *v36; // r8
		  Int32__Array **v37; // r9
		  HGInteractionChainSection v38; // [rsp+20h] [rbp-148h] BYREF
		  HGInteractionChainNode v39; // [rsp+30h] [rbp-138h] BYREF
		  HGInteractionChainNode v40; // [rsp+C0h] [rbp-A8h]
		
		  this->fields.LastAccessFrame = -1;
		  this->fields.IsFree = 1;
		  DefaultValue = HG::Rendering::Runtime::HGInteractionChainNode::get_DefaultValue(&v39, 0LL);
		  v6 = *(_OWORD *)&DefaultValue->HeightFade.y;
		  *(_OWORD *)&v40.VRange.x = *(_OWORD *)&DefaultValue->VRange.x;
		  v7 = *(_OWORD *)&DefaultValue->TimeFade.w;
		  *(_OWORD *)&v40.HeightFade.y = v6;
		  v8 = *(_OWORD *)&DefaultValue->Position.y;
		  *(_OWORD *)&v40.TimeFade.w = v7;
		  v9 = *(_OWORD *)&DefaultValue->Rotation.z;
		  *(_OWORD *)&v40.Position.y = v8;
		  v10 = *(_OWORD *)&DefaultValue->Vertex0.x;
		  *(_OWORD *)&v40.Rotation.z = v9;
		  v11 = *(_OWORD *)&DefaultValue->Vertex1.y;
		  *(_OWORD *)&v40.Vertex0.x = v10;
		  *(_OWORD *)&v40.Vertex1.y = v11;
		  v12 = *(_OWORD *)&DefaultValue->Vertex2.z;
		  LODWORD(DefaultValue) = *(_DWORD *)&DefaultValue->Active;
		  *(_OWORD *)&v40.Vertex2.z = v12;
		  *(_DWORD *)&v40.Active = (_DWORD)DefaultValue;
		  v15 = (TRingBuffer_1_HGInteractionChainNode_ *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>);
		  if ( !v15 )
		    goto LABEL_5;
		  v39 = v40;
		  HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::TRingBuffer(
		    v15,
		    100,
		    &v39,
		    MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::TRingBuffer);
		  this->fields.chainNodes = v15;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.chainNodes, v16, v17, v18, *(MethodInfo **)&v38.VRange);
		  v19 = *HG::Rendering::Runtime::HGInteractionChainSection::get_DefaultValue(&v38, 0LL);
		  v20 = (TRingBuffer_1_HGInteractionChainSection_ *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>);
		  v21 = v20;
		  if ( !v20 )
		    goto LABEL_5;
		  v38 = v19;
		  HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::TRingBuffer(
		    v20,
		    100,
		    &v38,
		    MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::TRingBuffer);
		  this->fields.chainSections = v21;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.chainSections, v22, v23, v24, *(MethodInfo **)&v38.VRange);
		  this->fields.interactionData = (HGDecalInteractionData__Array *)il2cpp_array_new_specific_1(
		                                                                    TypeInfo::HG::Rendering::Runtime::HGDecalInteractionData,
		                                                                    100LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.interactionData, v25, v26, v27, *(MethodInfo **)&v38.VRange);
		  this->fields.settingData = (HGDecalInteractionSettingData__Array *)il2cpp_array_new_specific_1(
		                                                                       TypeInfo::HG::Rendering::Runtime::HGDecalInteractionSettingData,
		                                                                       1LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.settingData, v28, v29, v30, *(MethodInfo **)&v38.VRange);
		  v31 = (MaterialPropertyBlock *)sub_18002C620(TypeInfo::UnityEngine::MaterialPropertyBlock);
		  if ( !v31 )
		LABEL_5:
		    sub_1800D8260(v14, v13);
		  v31->fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		  this->fields.propertyBlock = v31;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.propertyBlock, v32, v33, v34, *(MethodInfo **)&v38.VRange);
		  this->fields.settingAsset = _settingAsset;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.settingAsset, v35, v36, v37, *(MethodInfo **)&v38.VRange);
		  HG::Rendering::Runtime::HGInteractionChain::Reset(this, 0LL);
		}
		
	
		// Methods
		public void Reset() {} // 0x0000000189CFD518-0x0000000189CFD5BC
		// Void Reset()
		void HG::Rendering::Runtime::HGInteractionChain::Reset(HGInteractionChain *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  TRingBuffer_1_HGInteractionChainNode_ *chainNodes; // rcx
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v9; // [rsp+50h] [rbp+28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1781, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1781, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		LABEL_7:
		    sub_1800D8260(chainNodes, v3);
		  }
		  this->fields.LastAccessFrame = -1;
		  chainNodes = this->fields.chainNodes;
		  this->fields.IsFree = 1;
		  if ( !chainNodes )
		    goto LABEL_7;
		  HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::Reset(
		    chainNodes,
		    MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::Reset);
		  chainNodes = (TRingBuffer_1_HGInteractionChainNode_ *)this->fields.chainSections;
		  if ( !chainNodes )
		    goto LABEL_7;
		  HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::Reset(
		    (TRingBuffer_1_HGInteractionChainSection_ *)chainNodes,
		    MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::Reset);
		  this->fields.cachedFadeEnd = 0.0;
		  this->fields.activeCount = 0;
		  if ( this->fields.chainBuffer )
		  {
		    UnityEngine::ComputeBuffer::Dispose(this->fields.chainBuffer, 0LL);
		    this->fields.chainBuffer = 0LL;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.chainBuffer, v5, v6, v7, v9);
		  }
		}
		
		public void PushNewNode([IsReadOnly] in HGInteractionNode node) {} // 0x0000000189CFC524-0x0000000189CFD518
		// Void PushNewNode(HGInteractionNode ByRef)
		void HG::Rendering::Runtime::HGInteractionChain::PushNewNode(
		        HGInteractionChain *this,
		        HGInteractionNode *node,
		        MethodInfo *method)
		{
		  float v5; // xmm12_4
		  __int128 v6; // xmm1
		  __int128 v7; // xmm0
		  __int128 v8; // xmm1
		  Quaternion *rotation; // rbx
		  MethodInfo *v10; // rdx
		  Vector3 *fwd; // rax
		  Quaternion v12; // xmm0
		  __int64 v13; // xmm3_8
		  Vector3 *v14; // rax
		  __int64 v15; // xmm9_8
		  float z; // r14d
		  MethodInfo *v17; // rdx
		  Vector3 *right; // rax
		  Quaternion v19; // xmm0
		  Vector3 *v20; // rax
		  TRingBuffer_1_HGInteractionChainSection_ *chainSections; // rdx
		  __int64 p_value; // rcx
		  __int64 v23; // xmm6_8
		  float v24; // ebx
		  HGInteractionSettingAsset *settingAsset; // rax
		  __m128 decalNodeWidth_low; // xmm10
		  float decalNodeLength; // xmm14_4
		  __int128 v28; // xmm1
		  __int128 v29; // xmm0
		  __int128 v30; // xmm1
		  MethodInfo *v31; // r9
		  float v32; // xmm2_4
		  Vector3 *v33; // rax
		  __int64 *v34; // r8
		  __int64 v35; // xmm0_8
		  __int64 v36; // xmm3_8
		  MethodInfo *v37; // r9
		  Vector3 *v38; // rax
		  __int64 v39; // xmm3_8
		  float v40; // r12d
		  HGInteractionSettingAsset *v41; // rax
		  float v42; // xmm1_4
		  float v43; // xmm0_4
		  __m128 x_low; // xmm15
		  float v45; // xmm7_4
		  MethodInfo *v46; // r9
		  Vector3 *v47; // rax
		  __int64 v48; // xmm3_8
		  MethodInfo *v49; // r9
		  Vector3 *v50; // rax
		  MethodInfo *v51; // r9
		  __int64 v52; // xmm3_8
		  Vector3 *v53; // rax
		  float v54; // r13d
		  MethodInfo *v55; // r9
		  Vector3 *v56; // rax
		  __int64 v57; // xmm3_8
		  MethodInfo *v58; // r9
		  Vector3 *v59; // rax
		  MethodInfo *v60; // r9
		  __int64 v61; // xmm3_8
		  Vector3 *v62; // rax
		  MethodInfo *v63; // r9
		  __int64 v64; // xmm0_8
		  HGInteractionSettingAsset *v65; // rax
		  float decalNodeHeadLength; // xmm2_4
		  Vector3 *v67; // rax
		  MethodInfo *v68; // r9
		  __int64 v69; // xmm3_8
		  Vector3 *v70; // rax
		  __int64 v71; // xmm3_8
		  MethodInfo *v72; // r9
		  Vector3 *v73; // rax
		  __int64 v74; // xmm3_8
		  MethodInfo *v75; // r9
		  Vector3 *v76; // rax
		  __int64 v77; // xmm3_8
		  MethodInfo *v78; // r9
		  Vector3 *v79; // rax
		  MethodInfo *v80; // r9
		  __int64 v81; // xmm13_8
		  float v82; // r15d
		  HGInteractionSettingAsset *v83; // rax
		  float v84; // xmm2_4
		  Vector3 *v85; // rax
		  MethodInfo *v86; // r9
		  __int64 v87; // xmm3_8
		  Vector3 *v88; // rax
		  __int64 v89; // xmm3_8
		  MethodInfo *v90; // r9
		  Vector3 *v91; // rax
		  __int64 v92; // xmm3_8
		  MethodInfo *v93; // r9
		  Vector3 *v94; // rax
		  __int64 v95; // xmm3_8
		  MethodInfo *v96; // r9
		  Vector3 *v97; // rax
		  __int64 v98; // xmm0_8
		  MethodInfo *v99; // r9
		  Vector3 *v100; // rax
		  MethodInfo *v101; // r9
		  __int64 v102; // xmm3_8
		  Vector3 *v103; // rax
		  __int64 v104; // xmm3_8
		  MethodInfo *v105; // r9
		  Vector3 *v106; // rax
		  __int64 v107; // xmm3_8
		  MethodInfo *v108; // r9
		  Vector3 *v109; // rax
		  __int64 v110; // xmm3_8
		  MethodInfo *v111; // r9
		  Vector3 *v112; // rax
		  float v113; // r10d
		  MethodInfo *v114; // r9
		  Vector3 *v115; // rax
		  MethodInfo *v116; // r9
		  Il2CppMethodPointer methodPointer; // xmm0_8
		  __int64 v118; // xmm3_8
		  Vector3 *v119; // rax
		  __int64 v120; // xmm3_8
		  MethodInfo *v121; // r9
		  Vector3 *v122; // rax
		  __int64 v123; // xmm3_8
		  MethodInfo *v124; // r9
		  Vector3 *v125; // rax
		  __int64 v126; // xmm3_8
		  MethodInfo *v127; // r9
		  Vector3 *v128; // rax
		  __int64 v129; // xmm4_8
		  float v130; // xmm6_4
		  __int64 v131; // xmm1_8
		  float v132; // r8d
		  TRingBuffer_1_HGInteractionChainNode_ *chainNodes; // rax
		  int v134; // ebx
		  MethodInfo *v135; // r9
		  Vector3 *v136; // rax
		  float v137; // ecx
		  double v138; // xmm0_8
		  __int64 v139; // rax
		  __int64 v140; // xmm1_8
		  MethodInfo *v141; // r8
		  float v142; // xmm8_4
		  MethodInfo *v143; // rdx
		  Vector3 *v144; // rax
		  __int64 v145; // xmm3_8
		  Vector3 *v146; // rax
		  __int64 v147; // xmm0_8
		  MethodInfo *v148; // r8
		  float v149; // xmm0_4
		  HGInteractionSettingAsset *v150; // rax
		  float rotationThreshold; // xmm1_4
		  float v152; // xmm0_4
		  float y; // xmm0_4
		  TRingBuffer_1_HGInteractionChainNode_ *v154; // rax
		  unsigned int PrevIndex; // eax
		  __int128 v156; // xmm1
		  __int128 v157; // xmm0
		  __int128 v158; // xmm1
		  __int128 v159; // xmm0
		  __int128 v160; // xmm1
		  __int128 v161; // xmm0
		  __int128 v162; // xmm1
		  float StartSize; // eax
		  __int128 v164; // xmm0
		  __int64 v165; // xmm9_8
		  float v166; // r14d
		  __int128 v167; // xmm1
		  float v168; // eax
		  __int128 v169; // xmm0
		  __int128 v170; // xmm1
		  __int128 v171; // xmm0
		  __int128 v172; // xmm1
		  __int128 v173; // xmm0
		  __int128 v174; // xmm1
		  __int128 v175; // xmm0
		  __int128 v176; // xmm1
		  __int64 v177; // xmm13_8
		  __int128 v178; // xmm0
		  float v179; // eax
		  __int128 v180; // xmm1
		  __int128 v181; // xmm0
		  __int128 v182; // xmm1
		  __int128 v183; // xmm0
		  __int128 v184; // xmm1
		  __int128 v185; // xmm0
		  __int128 v186; // xmm1
		  __int128 v187; // xmm0
		  __int128 v188; // xmm1
		  __int128 v189; // xmm0
		  float v190; // xmm8_4
		  __int128 v191; // xmm0
		  __int128 v192; // xmm1
		  float v193; // xmm6_4
		  HGInteractionSettingAsset *v194; // rax
		  float v195; // xmm1_4
		  float nodeDistanceThreshold; // xmm0_4
		  TRingBuffer_1_HGInteractionChainSection_ *v197; // rax
		  int32_t ringBufferEnd; // eax
		  unsigned __int64 v199; // xmm3_8
		  Vector2 v200; // rax
		  __int64 v201; // xmm6_8
		  float cachedFadeEnd; // xmm0_4
		  Vector2 v203; // rax
		  __int64 v204; // xmm5_8
		  float v205; // r8d
		  __int64 v206; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v208; // [rsp+28h] [rbp-E0h] BYREF
		  Vector3 Position; // [rsp+38h] [rbp-D0h] BYREF
		  HGInteractionChainSection v210; // [rsp+48h] [rbp-C0h] BYREF
		  Vector3 v211; // [rsp+58h] [rbp-B0h] BYREF
		  Quaternion v212; // [rsp+68h] [rbp-A0h] BYREF
		  Vector3 v213; // [rsp+78h] [rbp-90h] BYREF
		  float v214; // [rsp+88h] [rbp-80h]
		  float v215; // [rsp+8Ch] [rbp-7Ch]
		  float v216; // [rsp+90h] [rbp-78h]
		  Vector3 v217; // [rsp+98h] [rbp-70h] BYREF
		  HGInteractionChainNode nodea; // [rsp+A8h] [rbp-60h] BYREF
		  Quaternion v219; // [rsp+138h] [rbp+30h] BYREF
		  __int64 v220; // [rsp+148h] [rbp+40h]
		  __int64 v221; // [rsp+150h] [rbp+48h]
		  Matrix4x4 v222; // [rsp+158h] [rbp+50h] BYREF
		  Quaternion v223; // [rsp+198h] [rbp+90h]
		  HGInteractionChainNode value; // [rsp+1A8h] [rbp+A0h] BYREF
		  HGInteractionChainNode v225; // [rsp+238h] [rbp+130h] BYREF
		  float v226; // [rsp+3B0h] [rbp+2A8h]
		
		  Position.z = 0.0;
		  v5 = 0.0;
		  sub_18033B9D0(&v222, 0LL, 64LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(1782, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1782, 0LL);
		    if ( !Patch )
		      goto LABEL_49;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_717(Patch, (Object *)this, node, 0LL);
		  }
		  else
		  {
		    this->fields.IsFree = 0;
		    this->fields.LastAccessFrame = UnityEngine::Time::get_frameCount(0LL);
		    v6 = *(_OWORD *)&node->localToWorldMatrix.m01;
		    *(_OWORD *)&v222.m00 = *(_OWORD *)&node->localToWorldMatrix.m00;
		    v7 = *(_OWORD *)&node->localToWorldMatrix.m02;
		    *(_OWORD *)&v222.m01 = v6;
		    v8 = *(_OWORD *)&node->localToWorldMatrix.m03;
		    *(_OWORD *)&v222.m02 = v7;
		    *(_OWORD *)&v222.m03 = v8;
		    rotation = UnityEngine::Matrix4x4::get_rotation(&v212, &v222, 0LL);
		    v223 = (Quaternion)_mm_loadu_si128((const __m128i *)rotation);
		    fwd = UnityEngine::Vector3::get_fwd(&Position, v10);
		    v12 = *rotation;
		    v13 = *(_QWORD *)&fwd->x;
		    v208.z = fwd->z;
		    *(_QWORD *)&v208.x = v13;
		    v210 = (HGInteractionChainSection)v12;
		    v14 = UnityEngine::Quaternion::op_Multiply(&Position, (Quaternion *)&v210, &v208, 0LL);
		    v15 = *(_QWORD *)&v14->x;
		    z = v14->z;
		    right = UnityEngine::Vector3::get_right(&Position, v17);
		    v19 = *rotation;
		    *(_QWORD *)&v8 = *(_QWORD *)&right->x;
		    *(float *)&right = right->z;
		    *(_QWORD *)&v208.x = v8;
		    LODWORD(v208.z) = (_DWORD)right;
		    v210 = (HGInteractionChainSection)v19;
		    v20 = UnityEngine::Quaternion::op_Multiply(&Position, (Quaternion *)&v210, &v208, 0LL);
		    v23 = *(_QWORD *)&v20->x;
		    v24 = v20->z;
		    settingAsset = this->fields.settingAsset;
		    if ( !settingAsset )
		      goto LABEL_49;
		    decalNodeWidth_low = (__m128)LODWORD(settingAsset->fields.decalNodeWidth);
		    decalNodeLength = settingAsset->fields.decalNodeLength;
		    v28 = *(_OWORD *)&node->localToWorldMatrix.m01;
		    *(_OWORD *)&v222.m00 = *(_OWORD *)&node->localToWorldMatrix.m00;
		    v29 = *(_OWORD *)&node->localToWorldMatrix.m02;
		    *(_OWORD *)&v222.m01 = v28;
		    v30 = *(_OWORD *)&node->localToWorldMatrix.m03;
		    *(_OWORD *)&v222.m02 = v29;
		    *(_OWORD *)&v222.m03 = v30;
		    UnityEngine::Matrix4x4::GetPosition(&Position, &v222, 0LL);
		    p_value = (__int64)this->fields.settingAsset;
		    if ( !p_value )
		      goto LABEL_49;
		    v32 = *(float *)(p_value + 44);
		    *(_QWORD *)&v208.x = v15;
		    v208.z = z;
		    v33 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v212, &v208, v32, v31);
		    v35 = *v34;
		    v36 = *(_QWORD *)&v33->x;
		    v208.z = v33->z;
		    LODWORD(v33) = *((_DWORD *)v34 + 2);
		    *(_QWORD *)&v208.x = v36;
		    *(_QWORD *)&v212.x = v35;
		    LODWORD(v212.z) = (_DWORD)v33;
		    v38 = UnityEngine::Vector3::op_Addition((Vector3 *)&v210, (Vector3 *)&v212, &v208, v37);
		    v39 = *(_QWORD *)&v38->x;
		    v40 = v38->z;
		    v41 = this->fields.settingAsset;
		    *(_QWORD *)&v208.x = v39;
		    if ( !v41 )
		      goto LABEL_49;
		    v42 = v41->fields.heightFadeDistanceMax - v41->fields.heightFadeDistanceMin;
		    v43 = (float)((float)(v208.y - node->GroundHeight) - v41->fields.heightFadeDistanceMin) / v42;
		    Beyond::JobMathf::Clamp01((Beyond::JobMathf *)p_value, v42);
		    x_low = (__m128)LODWORD(v208.x);
		    v45 = 1.0 - v43;
		    v219.x = node->GroundHeight;
		    *(_QWORD *)&v208.x = v23;
		    v208.z = v24;
		    v47 = UnityEngine::Vector3::op_Multiply(&Position, &v208, decalNodeWidth_low.m128_f32[0], v46);
		    v48 = *(_QWORD *)&v47->x;
		    *(float *)&v47 = v47->z;
		    *(_QWORD *)&v208.x = v48;
		    LODWORD(v208.z) = (_DWORD)v47;
		    v50 = UnityEngine::Vector3::op_Multiply(&Position, &v208, 0.5, v49);
		    *(_QWORD *)&v212.x = v51->methodPointer;
		    v212.z = v40;
		    v52 = *(_QWORD *)&v50->x;
		    *(float *)&v50 = v50->z;
		    *(_QWORD *)&v208.x = v52;
		    LODWORD(v208.z) = (_DWORD)v50;
		    v53 = UnityEngine::Vector3::op_Subtraction(&Position, (Vector3 *)&v212, &v208, v51);
		    *(_QWORD *)&v208.x = v23;
		    v208.z = v24;
		    v54 = v53->z;
		    v220 = *(_QWORD *)&v53->x;
		    v56 = UnityEngine::Vector3::op_Multiply(&Position, &v208, decalNodeWidth_low.m128_f32[0], v55);
		    v57 = *(_QWORD *)&v56->x;
		    *(float *)&v56 = v56->z;
		    *(_QWORD *)&v208.x = v57;
		    LODWORD(v208.z) = (_DWORD)v56;
		    v59 = UnityEngine::Vector3::op_Multiply(&Position, &v208, 0.5, v58);
		    *(_QWORD *)&v212.x = v60->methodPointer;
		    v212.z = v40;
		    v61 = *(_QWORD *)&v59->x;
		    *(float *)&v59 = v59->z;
		    *(_QWORD *)&v208.x = v61;
		    LODWORD(v208.z) = (_DWORD)v59;
		    v62 = UnityEngine::Vector3::op_Addition(&Position, (Vector3 *)&v212, &v208, v60);
		    v64 = *(_QWORD *)&v62->x;
		    v216 = v62->z;
		    v65 = this->fields.settingAsset;
		    v221 = v64;
		    if ( !v65 )
		      goto LABEL_49;
		    decalNodeHeadLength = v65->fields.decalNodeHeadLength;
		    *(_QWORD *)&v208.x = v15;
		    v208.z = z;
		    v67 = UnityEngine::Vector3::op_Multiply(&Position, &v208, decalNodeHeadLength, v63);
		    *(_QWORD *)&v213.x = v68->methodPointer;
		    v213.z = v40;
		    v69 = *(_QWORD *)&v67->x;
		    *(float *)&v67 = v67->z;
		    *(_QWORD *)&v212.x = v69;
		    LODWORD(v212.z) = (_DWORD)v67;
		    *(_QWORD *)&v208.x = v23;
		    v208.z = v24;
		    v70 = UnityEngine::Vector3::op_Multiply(&Position, &v208, decalNodeWidth_low.m128_f32[0], v68);
		    v71 = *(_QWORD *)&v70->x;
		    *(float *)&v70 = v70->z;
		    *(_QWORD *)&v208.x = v71;
		    LODWORD(v208.z) = (_DWORD)v70;
		    v73 = UnityEngine::Vector3::op_Multiply(&Position, &v208, 0.5, v72);
		    v74 = *(_QWORD *)&v73->x;
		    *(float *)&v73 = v73->z;
		    *(_QWORD *)&v208.x = v74;
		    LODWORD(v208.z) = (_DWORD)v73;
		    v76 = UnityEngine::Vector3::op_Addition(&Position, &v213, (Vector3 *)&v212, v75);
		    v77 = *(_QWORD *)&v76->x;
		    *(float *)&v76 = v76->z;
		    *(_QWORD *)&v212.x = v77;
		    LODWORD(v212.z) = (_DWORD)v76;
		    v79 = UnityEngine::Vector3::op_Subtraction(&Position, (Vector3 *)&v212, &v208, v78);
		    v81 = *(_QWORD *)&v79->x;
		    v82 = v79->z;
		    v83 = this->fields.settingAsset;
		    *(_QWORD *)&v212.x = v81;
		    if ( !v83 )
		      goto LABEL_49;
		    v84 = v83->fields.decalNodeHeadLength;
		    *(_QWORD *)&v208.x = v15;
		    v208.z = z;
		    v85 = UnityEngine::Vector3::op_Multiply(&Position, &v208, v84, v80);
		    *(_QWORD *)&v211.x = v86->methodPointer;
		    v211.z = v40;
		    v87 = *(_QWORD *)&v85->x;
		    *(float *)&v85 = v85->z;
		    *(_QWORD *)&v213.x = v87;
		    LODWORD(v213.z) = (_DWORD)v85;
		    *(_QWORD *)&v208.x = v23;
		    v208.z = v24;
		    v88 = UnityEngine::Vector3::op_Multiply(&Position, &v208, decalNodeWidth_low.m128_f32[0], v86);
		    v89 = *(_QWORD *)&v88->x;
		    *(float *)&v88 = v88->z;
		    *(_QWORD *)&v208.x = v89;
		    LODWORD(v208.z) = (_DWORD)v88;
		    v91 = UnityEngine::Vector3::op_Multiply(&Position, &v208, 0.5, v90);
		    v92 = *(_QWORD *)&v91->x;
		    *(float *)&v91 = v91->z;
		    *(_QWORD *)&v208.x = v92;
		    LODWORD(v208.z) = (_DWORD)v91;
		    v94 = UnityEngine::Vector3::op_Addition(&Position, &v211, &v213, v93);
		    v95 = *(_QWORD *)&v94->x;
		    *(float *)&v94 = v94->z;
		    *(_QWORD *)&v213.x = v95;
		    LODWORD(v213.z) = (_DWORD)v94;
		    v97 = UnityEngine::Vector3::op_Addition(&Position, &v213, &v208, v96);
		    *(_QWORD *)&v208.x = v15;
		    v208.z = z;
		    v98 = *(_QWORD *)&v97->x;
		    *(float *)&v97 = v97->z;
		    *(_QWORD *)&v213.x = v98;
		    v214 = *(float *)&v97;
		    v100 = UnityEngine::Vector3::op_Multiply(&Position, &v208, decalNodeLength, v99);
		    *(_QWORD *)&v217.x = v101->methodPointer;
		    v217.z = v40;
		    v102 = *(_QWORD *)&v100->x;
		    *(float *)&v100 = v100->z;
		    *(_QWORD *)&v211.x = v102;
		    LODWORD(v211.z) = (_DWORD)v100;
		    *(_QWORD *)&v208.x = v23;
		    v208.z = v24;
		    v103 = UnityEngine::Vector3::op_Multiply(&Position, &v208, decalNodeWidth_low.m128_f32[0], v101);
		    v104 = *(_QWORD *)&v103->x;
		    *(float *)&v103 = v103->z;
		    *(_QWORD *)&v208.x = v104;
		    LODWORD(v208.z) = (_DWORD)v103;
		    v106 = UnityEngine::Vector3::op_Multiply(&Position, &v208, 0.5, v105);
		    v107 = *(_QWORD *)&v106->x;
		    *(float *)&v106 = v106->z;
		    *(_QWORD *)&v208.x = v107;
		    LODWORD(v208.z) = (_DWORD)v106;
		    v109 = UnityEngine::Vector3::op_Subtraction(&Position, &v217, &v211, v108);
		    v110 = *(_QWORD *)&v109->x;
		    *(float *)&v109 = v109->z;
		    *(_QWORD *)&v211.x = v110;
		    LODWORD(v211.z) = (_DWORD)v109;
		    v112 = UnityEngine::Vector3::op_Subtraction(&Position, &v211, &v208, v111);
		    *(_QWORD *)&v208.x = v15;
		    v208.z = z;
		    v113 = v112->z;
		    *(_QWORD *)&v217.x = *(_QWORD *)&v112->x;
		    v215 = v113;
		    v115 = UnityEngine::Vector3::op_Multiply(&Position, &v208, decalNodeLength, v114);
		    methodPointer = v116->methodPointer;
		    *(_QWORD *)&v208.x = v23;
		    v208.z = v24;
		    v118 = *(_QWORD *)&v115->x;
		    *(float *)&v115 = v115->z;
		    *(_QWORD *)&v211.x = v118;
		    LODWORD(v211.z) = (_DWORD)v115;
		    *(_QWORD *)&Position.x = methodPointer;
		    Position.z = v40;
		    v119 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v210, &v208, decalNodeWidth_low.m128_f32[0], v116);
		    v120 = *(_QWORD *)&v119->x;
		    *(float *)&v119 = v119->z;
		    *(_QWORD *)&v208.x = v120;
		    LODWORD(v208.z) = (_DWORD)v119;
		    v122 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v210, &v208, 0.5, v121);
		    v123 = *(_QWORD *)&v122->x;
		    *(float *)&v122 = v122->z;
		    *(_QWORD *)&v208.x = v123;
		    LODWORD(v208.z) = (_DWORD)v122;
		    v125 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v210, &Position, &v211, v124);
		    v126 = *(_QWORD *)&v125->x;
		    *(float *)&v125 = v125->z;
		    *(_QWORD *)&Position.x = v126;
		    LODWORD(Position.z) = (_DWORD)v125;
		    v128 = UnityEngine::Vector3::op_Addition((Vector3 *)&v210, &Position, &v208, v127);
		    v130 = -1.0;
		    v131 = *(_QWORD *)&v128->x;
		    v132 = v128->z;
		    chainNodes = this->fields.chainNodes;
		    *(_QWORD *)&v211.x = v131;
		    v226 = v132;
		    if ( !chainNodes )
		      goto LABEL_49;
		    v134 = 0;
		    p_value = 1LL;
		    if ( chainNodes->fields.ringBufferEnd != -1 )
		    {
		      HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetCurrentNode(
		        &value,
		        chainNodes,
		        MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetCurrentNode);
		      v208.z = v40;
		      nodea = value;
		      Position = value.Position;
		      *(_QWORD *)&v208.x = _mm_unpacklo_ps(x_low, (__m128)LODWORD(v219.x)).m128_u64[0];
		      v136 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v210, &v208, &Position, v135);
		      v137 = v136->z;
		      *(_QWORD *)&v208.x = *(_QWORD *)&v136->x;
		      v208.z = v137;
		      *(_QWORD *)&v219.x = _mm_unpacklo_ps((__m128)LODWORD(v208.x), (__m128)_mm_cvtsi32_si128(LODWORD(v137))).m128_u64[0];
		      v138 = sub_182FA2AF0(&v219);
		      *(_QWORD *)&Position.x = v15;
		      Position.z = z;
		      v130 = *(float *)&v138;
		      v139 = sub_182FAE2B0(&v210, &v208);
		      v140 = *(_QWORD *)v139;
		      LODWORD(v139) = *(_DWORD *)(v139 + 8);
		      *(_QWORD *)&v208.x = v140;
		      LODWORD(v208.z) = v139;
		      v142 = UnityEngine::Vector3::Dot(&v208, &Position, v141);
		      v144 = UnityEngine::Vector3::get_fwd((Vector3 *)&v210, v143);
		      *(_QWORD *)&v208.x = v15;
		      v145 = *(_QWORD *)&v144->x;
		      *(float *)&v144 = v144->z;
		      *(_QWORD *)&Position.x = v145;
		      LODWORD(Position.z) = (_DWORD)v144;
		      v219 = value.Rotation;
		      v208.z = z;
		      v146 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v210, &v219, &Position, 0LL);
		      v147 = *(_QWORD *)&v146->x;
		      *(float *)&v146 = v146->z;
		      *(_QWORD *)&Position.x = v147;
		      LODWORD(Position.z) = (_DWORD)v146;
		      v149 = UnityEngine::Vector3::Dot(&Position, &v208, v148);
		      v150 = this->fields.settingAsset;
		      if ( !v150 )
		        goto LABEL_49;
		      rotationThreshold = v150->fields.rotationThreshold;
		      if ( rotationThreshold > v149
		        || v130 >= v150->fields.nodeDistanceThreshold && rotationThreshold > v142
		        || v150->fields.backwardDistanceThreshold > (float)(v142 * v130) )
		      {
		        p_value = 1LL;
		        v134 = 1;
		      }
		      else
		      {
		        if ( v150->fields.nodeDistanceThreshold > v130 )
		        {
		          *(_QWORD *)&nodea.Vertex1.x = *(_QWORD *)&v213.x;
		          v152 = v130 + this->fields.cachedFadeEnd;
		          *(_QWORD *)&nodea.Vertex0.x = v81;
		          nodea.Vertex0.z = v82;
		          nodea.Vertex1.z = v214;
		          nodea.TimeFade = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18B959780);
		          nodea.StartDist.x = -1.0;
		          nodea.VRange.y = v152;
		          y = nodea.HeightFade.y;
		          nodea.StartDist.y = -1.0;
		          if ( nodea.HeightFade.y <= v45 )
		            y = v45;
		          p_value = (__int64)this->fields.chainNodes;
		          nodea.HeightFade.y = y;
		          if ( p_value )
		          {
		            HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::SetCurrentNode(
		              (TRingBuffer_1_HGInteractionChainNode_ *)p_value,
		              &nodea,
		              MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::SetCurrentNode);
		            chainSections = this->fields.chainSections;
		            if ( chainSections )
		            {
		              HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::GetCurrentNode(
		                &v210,
		                chainSections,
		                MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::GetCurrentNode);
		              p_value = (__int64)this->fields.chainSections;
		              v210.VRange.y = v130 + this->fields.cachedFadeEnd;
		              if ( p_value )
		              {
		                HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::SetCurrentNode(
		                  (TRingBuffer_1_HGInteractionChainSection_ *)p_value,
		                  &v210,
		                  MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::SetCurrentNode);
		                return;
		              }
		            }
		          }
		          goto LABEL_49;
		        }
		        p_value = 1LL;
		      }
		      v131 = *(_QWORD *)&v211.x;
		      v129 = *(_QWORD *)&v217.x;
		    }
		    v154 = this->fields.chainNodes;
		    if ( !v154 )
		      goto LABEL_49;
		    if ( v154->fields.ringBufferEnd == -1 )
		      v134 = 1;
		    if ( v134 )
		    {
		      v166 = v215;
		      v165 = v129;
		      v177 = v131;
		      v190 = decalNodeLength;
		      v193 = v45;
		    }
		    else
		    {
		      HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetCurrentNode(
		        &v225,
		        this->fields.chainNodes,
		        MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetCurrentNode);
		      chainSections = (TRingBuffer_1_HGInteractionChainSection_ *)this->fields.chainNodes;
		      if ( !chainSections )
		        goto LABEL_49;
		      PrevIndex = HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetPrevIndex(
		                    this->fields.chainNodes,
		                    chainSections->fields.ringBufferEnd,
		                    MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetPrevIndex);
		      chainSections = (TRingBuffer_1_HGInteractionChainSection_ *)this->fields.chainNodes;
		      if ( !chainSections )
		        goto LABEL_49;
		      chainSections = (TRingBuffer_1_HGInteractionChainSection_ *)sub_1808B50D0(&nodea, chainSections, PrevIndex);
		      v156 = *(_OWORD *)&chainSections->fields.ringBufferStart;
		      *(_OWORD *)&value.VRange.x = *(_OWORD *)&chainSections->klass;
		      v157 = *(_OWORD *)&chainSections->fields.defaultT.StartSize;
		      *(_OWORD *)&value.HeightFade.y = v156;
		      v158 = *(_OWORD *)&chainSections[1].klass;
		      *(_OWORD *)&value.TimeFade.w = v157;
		      v159 = *(_OWORD *)&chainSections[1].fields.ringBufferStart;
		      *(_OWORD *)&value.Position.y = v158;
		      v160 = *(_OWORD *)&chainSections[1].fields.defaultT.StartSize;
		      *(_OWORD *)&value.Rotation.z = v159;
		      v161 = *(_OWORD *)&chainSections[2].klass;
		      *(_OWORD *)&value.Vertex0.x = v160;
		      v162 = *(_OWORD *)&chainSections[2].fields.ringBufferStart;
		      StartSize = chainSections[2].fields.defaultT.StartSize;
		      *(_OWORD *)&value.Vertex1.y = v161;
		      v164 = *(_OWORD *)&chainSections->klass;
		      *(_OWORD *)&value.Vertex2.z = v162;
		      *(float *)&value.Active = StartSize;
		      v165 = *(_QWORD *)&value.Vertex0.x;
		      v166 = value.Vertex0.z;
		      v167 = *(_OWORD *)&chainSections->fields.ringBufferStart;
		      v168 = chainSections[2].fields.defaultT.StartSize;
		      *(_OWORD *)&value.VRange.x = v164;
		      v169 = *(_OWORD *)&chainSections->fields.defaultT.StartSize;
		      *(_OWORD *)&value.HeightFade.y = v167;
		      v170 = *(_OWORD *)&chainSections[1].klass;
		      *(_OWORD *)&value.TimeFade.w = v169;
		      v171 = *(_OWORD *)&chainSections[1].fields.ringBufferStart;
		      *(_OWORD *)&value.Position.y = v170;
		      v172 = *(_OWORD *)&chainSections[1].fields.defaultT.StartSize;
		      *(_OWORD *)&value.Rotation.z = v171;
		      v173 = *(_OWORD *)&chainSections[2].klass;
		      *(_OWORD *)&value.Vertex0.x = v172;
		      v174 = *(_OWORD *)&chainSections[2].fields.ringBufferStart;
		      *(_OWORD *)&value.Vertex1.y = v173;
		      v175 = *(_OWORD *)&chainSections->klass;
		      *(_OWORD *)&value.Vertex2.z = v174;
		      *(float *)&value.Active = v168;
		      v176 = *(_OWORD *)&chainSections->fields.ringBufferStart;
		      v177 = *(_QWORD *)&value.Vertex1.x;
		      *(_OWORD *)&v225.VRange.x = v175;
		      v226 = value.Vertex1.z;
		      v178 = *(_OWORD *)&chainSections->fields.defaultT.StartSize;
		      v179 = chainSections[2].fields.defaultT.StartSize;
		      *(_OWORD *)&v225.HeightFade.y = v176;
		      v180 = *(_OWORD *)&chainSections[1].klass;
		      *(_OWORD *)&v225.TimeFade.w = v178;
		      v181 = *(_OWORD *)&chainSections[1].fields.ringBufferStart;
		      *(_OWORD *)&v225.Position.y = v180;
		      v182 = *(_OWORD *)&chainSections[1].fields.defaultT.StartSize;
		      *(_OWORD *)&v225.Rotation.z = v181;
		      v183 = *(_OWORD *)&chainSections[2].klass;
		      *(_OWORD *)&v225.Vertex0.x = v182;
		      v184 = *(_OWORD *)&chainSections[2].fields.ringBufferStart;
		      *(_OWORD *)&v225.Vertex1.y = v183;
		      v185 = *(_OWORD *)&chainSections->klass;
		      *(_OWORD *)&v225.Vertex2.z = v184;
		      *(float *)&v225.Active = v179;
		      v5 = v225.VRange.y;
		      v186 = *(_OWORD *)&chainSections->fields.ringBufferStart;
		      *(_OWORD *)&v225.VRange.x = v185;
		      v187 = *(_OWORD *)&chainSections->fields.defaultT.StartSize;
		      *(_OWORD *)&v225.HeightFade.y = v186;
		      v188 = *(_OWORD *)&chainSections[1].klass;
		      *(_OWORD *)&v225.TimeFade.w = v187;
		      v189 = *(_OWORD *)&chainSections[1].fields.ringBufferStart;
		      *(_OWORD *)&v225.Position.y = v188;
		      *(_OWORD *)&v225.Rotation.z = v189;
		      v190 = v5 + v130;
		      v191 = *(_OWORD *)&chainSections[2].klass;
		      *(_OWORD *)&v225.Vertex0.x = *(_OWORD *)&chainSections[1].fields.defaultT.StartSize;
		      v192 = *(_OWORD *)&chainSections[2].fields.ringBufferStart;
		      *(_OWORD *)&v225.Vertex1.y = v191;
		      *(_OWORD *)&v225.Vertex2.z = v192;
		      *(float *)&v225.Active = v179;
		      p_value = 1LL;
		      v193 = v225.HeightFade.y;
		    }
		    v194 = this->fields.settingAsset;
		    if ( !v194 )
		      goto LABEL_49;
		    v195 = v190 + v194->fields.decalNodeHeadLength;
		    this->fields.cachedFadeEnd = v195;
		    if ( (_BYTE)v134 )
		    {
		      *(_QWORD *)&v210.StartSize = 0LL;
		      v210.VRange.x = 0.0;
		      v210.VRange.y = v195;
		      nodeDistanceThreshold = v194->fields.nodeDistanceThreshold;
		      v210.Active = 1;
		      p_value = (__int64)this->fields.chainSections;
		      v210.StartSize = (float)(nodeDistanceThreshold * 0.5) + v195;
		      if ( !p_value )
		        goto LABEL_49;
		      HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::AddNewNode(
		        (TRingBuffer_1_HGInteractionChainSection_ *)p_value,
		        &v210,
		        MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::AddNewNode);
		    }
		    else
		    {
		      chainSections = this->fields.chainSections;
		      if ( !chainSections )
		        goto LABEL_49;
		      HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::GetCurrentNode(
		        &v210,
		        chainSections,
		        MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::GetCurrentNode);
		      p_value = (__int64)this->fields.chainSections;
		      v210.VRange.y = this->fields.cachedFadeEnd;
		      if ( !p_value )
		        goto LABEL_49;
		      HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::SetCurrentNode(
		        (TRingBuffer_1_HGInteractionChainSection_ *)p_value,
		        &v210,
		        MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::SetCurrentNode);
		    }
		    nodea.VRange.x = v5;
		    *(_WORD *)(&nodea.Active + 1) = 0;
		    *(&nodea.Active + 3) = 0;
		    v197 = this->fields.chainSections;
		    nodea.VRange.y = v190;
		    if ( !v197 )
		      goto LABEL_49;
		    ringBufferEnd = v197->fields.ringBufferEnd;
		    nodea.Position.y = node->GroundHeight;
		    nodea.SectionIndex = ringBufferEnd;
		    v199 = _mm_unpacklo_ps(decalNodeWidth_low, (__m128)0x3F800000u).m128_u64[0];
		    nodea.Rotation = v223;
		    nodea.TimeFade.x = 1.0;
		    nodea.HeightFade.x = v193;
		    nodea.HeightFade.y = v45;
		    LODWORD(nodea.Position.x) = x_low.m128_i32[0];
		    Position.z = decalNodeLength;
		    nodea.TimeFade.y = 1.0;
		    nodea.TimeFade.z = 1.0;
		    nodea.TimeFade.w = 1.0;
		    nodea.StartDist.x = -1.0;
		    nodea.StartDist.y = -1.0;
		    nodea.Position.z = v40;
		    *(_QWORD *)&Position.x = v199;
		    v200 = UnityEngine::Vector4::op_Implicit((Vector4 *)&Position, (MethodInfo *)chainSections);
		    p_value = (__int64)&value;
		    v201 = v221;
		    *(_QWORD *)&nodea.Vertex0.x = v220;
		    nodea.Vertex0.z = v54;
		    *(_QWORD *)&nodea.Vertex1.x = v221;
		    nodea.Vertex1.z = v216;
		    *(_QWORD *)&nodea.Vertex2.x = v165;
		    nodea.Vertex2.z = v166;
		    *(_QWORD *)&nodea.Vertex3.x = v177;
		    nodea.Active = 1;
		    *(Vector2 *)&v211.x = v200;
		    nodea.Vertex3.z = v226;
		    nodea.Scale = v200;
		    *(_OWORD *)&value.VRange.x = *(_OWORD *)&nodea.VRange.x;
		    *(_OWORD *)&value.HeightFade.y = *(_OWORD *)&nodea.HeightFade.y;
		    *(_OWORD *)&value.TimeFade.w = *(_OWORD *)&nodea.TimeFade.w;
		    *(_OWORD *)&value.Position.y = *(_OWORD *)&nodea.Position.y;
		    *(_OWORD *)&value.Rotation.z = *(_OWORD *)&nodea.Rotation.z;
		    *(_OWORD *)&value.Vertex0.x = *(_OWORD *)&nodea.Vertex0.x;
		    *(_OWORD *)&value.Vertex1.y = *(_OWORD *)&nodea.Vertex1.y;
		    cachedFadeEnd = this->fields.cachedFadeEnd;
		    *(_OWORD *)&value.Vertex2.z = *(_OWORD *)&nodea.Vertex2.z;
		    *(_DWORD *)&value.Active = *(_DWORD *)&nodea.Active;
		    nodea.VRange.x = v190;
		    nodea.VRange.y = cachedFadeEnd;
		    *(_WORD *)(&nodea.Active + 1) = 0;
		    *(&nodea.Active + 3) = 0;
		    if ( !this->fields.chainSections )
		      goto LABEL_49;
		    nodea.HeightFade.x = v45;
		    LODWORD(nodea.Position.x) = x_low.m128_i32[0];
		    Position.z = decalNodeLength;
		    nodea.Position.z = v40;
		    *(_QWORD *)&Position.x = v199;
		    v203 = UnityEngine::Vector4::op_Implicit((Vector4 *)&Position, (MethodInfo *)chainSections);
		    *(_QWORD *)&nodea.Vertex0.x = *(_QWORD *)&v212.x;
		    nodea.Vertex0.z = v82;
		    *(_QWORD *)&nodea.Vertex2.x = v204;
		    nodea.Vertex2.z = v54;
		    *(_QWORD *)&nodea.Vertex3.x = v201;
		    nodea.Vertex3.z = v205;
		    nodea.Vertex1.z = v214;
		    *(_QWORD *)&nodea.Vertex1.x = *(_QWORD *)&v213.x;
		    nodea.Scale = v203;
		    *(_OWORD *)&v225.VRange.x = *(_OWORD *)&nodea.VRange.x;
		    *(_OWORD *)&v225.HeightFade.y = *(_OWORD *)&nodea.HeightFade.y;
		    *(_OWORD *)&v225.TimeFade.w = *(_OWORD *)&nodea.TimeFade.w;
		    *(_OWORD *)&v225.Position.y = *(_OWORD *)&nodea.Position.y;
		    *(_OWORD *)&v225.Rotation.z = *(_OWORD *)&nodea.Rotation.z;
		    *(_OWORD *)&v225.Vertex0.x = *(_OWORD *)&nodea.Vertex0.x;
		    v203.x = *(float *)((char *)&nodea.VRange.x + v206);
		    *(_OWORD *)&v225.Vertex1.y = *(_OWORD *)&nodea.Vertex1.y;
		    *(_OWORD *)(&value.Active + v206) = *(_OWORD *)&nodea.Vertex2.z;
		    *(float *)((char *)&v225.VRange.x + v206) = v203.x;
		    p_value = (__int64)this->fields.chainNodes;
		    if ( (_BYTE)v134 )
		    {
		      if ( !p_value )
		        goto LABEL_49;
		      HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::AddNewNode(
		        (TRingBuffer_1_HGInteractionChainNode_ *)p_value,
		        &value,
		        MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::AddNewNode);
		    }
		    else
		    {
		      if ( !p_value )
		        goto LABEL_49;
		      HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::SetNodeAtIndex(
		        (TRingBuffer_1_HGInteractionChainNode_ *)p_value,
		        *(_DWORD *)(p_value + 20),
		        &value,
		        MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::SetNodeAtIndex);
		    }
		    p_value = (__int64)this->fields.chainNodes;
		    if ( !p_value )
		LABEL_49:
		      sub_1800D8260(p_value, chainSections);
		    HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::AddNewNode(
		      (TRingBuffer_1_HGInteractionChainNode_ *)p_value,
		      &v225,
		      MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::AddNewNode);
		  }
		}
		
		public void DrawChainNodes(CommandBuffer cmd, Material mat) {} // 0x0000000189CFC26C-0x0000000189CFC524
		// Void DrawChainNodes(CommandBuffer, Material)
		void HG::Rendering::Runtime::HGInteractionChain::DrawChainNodes(
		        HGInteractionChain *this,
		        CommandBuffer *cmd,
		        Material *mat,
		        MethodInfo *method)
		{
		  MaterialPropertyBlock *properties; // rdx
		  void *propertyBlock; // rcx
		  ComputeBuffer *v9; // rax
		  ComputeBuffer *v10; // rdi
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  MaterialPropertyBlock *v14; // rdi
		  ComputeBuffer *v15; // rax
		  ComputeBuffer *v16; // rdi
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  HGDecalInteractionSettingData__Array *settingData; // rax
		  MaterialPropertyBlock *v21; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *size; // [rsp+20h] [rbp-48h]
		  MethodInfo *sizea; // [rsp+20h] [rbp-48h]
		  __int128 v25; // [rsp+50h] [rbp-18h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1783, 0LL) )
		  {
		    propertyBlock = this->fields.propertyBlock;
		    if ( !propertyBlock )
		      goto LABEL_20;
		    UnityEngine::MaterialPropertyBlock::Clear((MaterialPropertyBlock *)propertyBlock, 1, 0LL);
		    if ( !this->fields.chainBuffer )
		    {
		      v9 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		      v10 = v9;
		      if ( !v9 )
		        goto LABEL_20;
		      UnityEngine::ComputeBuffer::ComputeBuffer(v9, 100, 144, ComputeBufferType__Enum_Constant, 0LL);
		      this->fields.chainBuffer = v10;
		      sub_18002D1B0((SingleFieldAccessor *)&this->fields.chainBuffer, v11, v12, v13, size);
		    }
		    propertyBlock = this->fields.chainBuffer;
		    if ( propertyBlock )
		    {
		      UnityEngine::ComputeBuffer::SetData((ComputeBuffer *)propertyBlock, (Array *)this->fields.interactionData, 0LL);
		      v14 = this->fields.propertyBlock;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      properties = (MaterialPropertyBlock *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( v14 )
		      {
		        UnityEngine::MaterialPropertyBlock::SetConstantBufferImpl(
		          v14,
		          (int32_t)properties[153].monitor,
		          this->fields.chainBuffer,
		          0,
		          14400,
		          0LL);
		        if ( !this->fields.settingDataBuffer )
		        {
		          v15 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		          v16 = v15;
		          if ( !v15 )
		            goto LABEL_20;
		          UnityEngine::ComputeBuffer::ComputeBuffer(v15, 1, 32, ComputeBufferType__Enum_Constant, 0LL);
		          this->fields.settingDataBuffer = v16;
		          sub_18002D1B0((SingleFieldAccessor *)&this->fields.settingDataBuffer, v17, v18, v19, sizea);
		        }
		        *((_QWORD *)&v25 + 1) = 0LL;
		        propertyBlock = this->fields.settingAsset;
		        settingData = this->fields.settingData;
		        if ( propertyBlock )
		        {
		          LODWORD(v25) = *((_DWORD *)propertyBlock + 12);
		          *((float *)&v25 + 1) = 1.0 / *((float *)propertyBlock + 13);
		          if ( settingData )
		          {
		            if ( !settingData->max_length.size )
		              sub_1800D2AB0(propertyBlock, properties);
		            *(_OWORD *)&settingData->vector[0]._decalNodeWidth = *((_OWORD *)propertyBlock + 2);
		            *(_OWORD *)&settingData->vector[0]._nodeDistanceThreshold = v25;
		            propertyBlock = this->fields.settingDataBuffer;
		            if ( propertyBlock )
		            {
		              UnityEngine::ComputeBuffer::SetData(
		                (ComputeBuffer *)propertyBlock,
		                (Array *)this->fields.settingData,
		                0LL);
		              v21 = this->fields.propertyBlock;
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		              properties = (MaterialPropertyBlock *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		              if ( v21 )
		              {
		                UnityEngine::MaterialPropertyBlock::SetConstantBufferImpl(
		                  v21,
		                  HIDWORD(properties[153].monitor),
		                  this->fields.settingDataBuffer,
		                  0,
		                  32,
		                  0LL);
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGInteractionResources);
		                properties = this->fields.propertyBlock;
		                propertyBlock = TypeInfo::HG::Rendering::Runtime::HGInteractionResources->static_fields;
		                if ( cmd )
		                {
		                  UnityEngine::Rendering::CommandBuffer::HGDrawMeshInstanced(
		                    cmd,
		                    *((Mesh **)propertyBlock + 2),
		                    0,
		                    mat,
		                    3,
		                    this->fields.activeCount,
		                    properties,
		                    0LL);
		                  return;
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_20:
		    sub_1800D8260(propertyBlock, properties);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1783, 0LL);
		  if ( !Patch )
		    goto LABEL_20;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		    (ILFixDynamicMethodWrapper_30 *)Patch,
		    (Object *)this,
		    (Object *)cmd,
		    (Object *)mat,
		    0LL);
		}
		
		public void UpdateChainFade() {} // 0x0000000189CFD5BC-0x0000000189CFDC0C
		// Void UpdateChainFade()
		void HG::Rendering::Runtime::HGInteractionChain::UpdateChainFade(HGInteractionChain *this, MethodInfo *method)
		{
		  _OWORD *chainSections; // rdx
		  TRingBuffer_1_HGInteractionChainSection_ *v4; // rcx
		  float deltaTime; // xmm0_4
		  HGInteractionSettingAsset *settingAsset; // rax
		  TRingBuffer_1_HGInteractionChainNode_ *chainNodes; // rdi
		  float v8; // xmm7_4
		  unsigned int ringBufferStart; // edi
		  unsigned int ringBufferEnd; // esi
		  __int64 v11; // rax
		  __int64 v12; // r8
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  __int128 v15; // xmm1
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  __int128 v18; // xmm0
		  __int128 v19; // xmm1
		  __int128 v20; // xmm0
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  __int128 v23; // xmm0
		  __int128 v24; // xmm1
		  __int128 v25; // xmm0
		  __int128 v26; // xmm1
		  __m128 *v27; // rax
		  float v28; // xmm9_4
		  int v29; // r14d
		  float v30; // xmm8_4
		  __int128 v31; // xmm1
		  __int128 v32; // xmm0
		  __int128 v33; // xmm1
		  __int128 v34; // xmm0
		  __int128 v35; // xmm1
		  __int128 v36; // xmm0
		  __int128 v37; // xmm1
		  int v38; // eax
		  __int128 v39; // xmm0
		  int v40; // eax
		  __int128 v41; // xmm1
		  __int128 v42; // xmm0
		  __int128 v43; // xmm1
		  __int128 v44; // xmm0
		  __int128 v45; // xmm1
		  __int128 v46; // xmm0
		  __int128 v47; // xmm1
		  __int128 v48; // xmm0
		  __int128 v49; // xmm1
		  __int128 v50; // xmm0
		  __int128 v51; // xmm1
		  __int128 v52; // xmm0
		  __int128 v53; // xmm1
		  __int128 v54; // xmm0
		  __int128 v55; // xmm1
		  __int128 v56; // xmm0
		  __int128 v57; // xmm1
		  __int128 v58; // xmm0
		  __int128 v59; // xmm1
		  __int128 v60; // xmm0
		  __int128 v61; // xmm1
		  __int128 v62; // xmm0
		  __int128 v63; // xmm1
		  __int128 v64; // xmm1
		  __int128 v65; // xmm0
		  __int128 v66; // xmm1
		  __int128 v67; // xmm0
		  __int128 v68; // xmm1
		  __int128 v69; // xmm0
		  __int128 v70; // xmm1
		  __int128 v71; // xmm1
		  __int128 v72; // xmm0
		  __int128 v73; // xmm1
		  __int128 v74; // xmm0
		  __int128 v75; // xmm1
		  __int128 v76; // xmm0
		  __int128 v77; // xmm1
		  int v78; // eax
		  __int128 v79; // xmm1
		  __int128 v80; // xmm0
		  __int128 v81; // xmm1
		  __int128 v82; // xmm0
		  __int128 v83; // xmm1
		  __int128 v84; // xmm0
		  __int128 v85; // xmm1
		  HGInteractionSettingAsset *v86; // rax
		  float v87; // xmm0_4
		  float v88; // xmm0_4
		  Vector4 v89; // xmm2
		  float v90; // xmm1_4
		  float v91; // xmm0_4
		  float v92; // xmm3_4
		  float v93; // xmm1_4
		  float v94; // xmm0_4
		  HGInteractionChainSection *v95; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v97; // [rsp+28h] [rbp-E0h]
		  Vector4 v98; // [rsp+38h] [rbp-D0h]
		  Vector4 v99; // [rsp+48h] [rbp-C0h]
		  HGInteractionChainSection value_8; // [rsp+58h] [rbp-B0h] BYREF
		  HGInteractionChainNode v101; // [rsp+68h] [rbp-A0h] BYREF
		  __int128 v102; // [rsp+F8h] [rbp-10h]
		  __int128 v103; // [rsp+108h] [rbp+0h]
		  __int128 v104; // [rsp+118h] [rbp+10h]
		  __int128 v105; // [rsp+128h] [rbp+20h]
		  __int128 v106; // [rsp+138h] [rbp+30h]
		  __int128 v107; // [rsp+148h] [rbp+40h]
		  __int128 v108; // [rsp+158h] [rbp+50h]
		  __int128 v109; // [rsp+168h] [rbp+60h]
		  int v110; // [rsp+178h] [rbp+70h]
		  __int128 v111; // [rsp+188h] [rbp+80h] BYREF
		  __int128 v112; // [rsp+198h] [rbp+90h]
		  __int128 v113; // [rsp+1A8h] [rbp+A0h]
		  __int128 v114; // [rsp+1B8h] [rbp+B0h]
		  __int128 v115; // [rsp+1C8h] [rbp+C0h]
		  __int128 v116; // [rsp+1D8h] [rbp+D0h]
		  __int128 v117; // [rsp+1E8h] [rbp+E0h]
		  __int128 v118; // [rsp+1F8h] [rbp+F0h]
		  int v119; // [rsp+208h] [rbp+100h]
		  _BYTE v120[16]; // [rsp+218h] [rbp+110h] BYREF
		  __int128 v121; // [rsp+228h] [rbp+120h] BYREF
		  __int128 v122; // [rsp+238h] [rbp+130h]
		  __int128 v123; // [rsp+248h] [rbp+140h]
		  __int128 v124; // [rsp+258h] [rbp+150h]
		  __int128 v125; // [rsp+268h] [rbp+160h]
		  __int128 v126; // [rsp+278h] [rbp+170h]
		  __int128 v127; // [rsp+288h] [rbp+180h]
		  __int128 v128; // [rsp+298h] [rbp+190h]
		  int v129; // [rsp+2A8h] [rbp+1A0h]
		  _BYTE v130[208]; // [rsp+2B8h] [rbp+1B0h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1784, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1784, 0LL);
		    if ( !Patch )
		      goto LABEL_47;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    deltaTime = UnityEngine::Time::get_deltaTime(0LL);
		    settingAsset = this->fields.settingAsset;
		    if ( !settingAsset )
		      goto LABEL_47;
		    chainNodes = this->fields.chainNodes;
		    v8 = deltaTime * settingAsset->fields.timeFadeSpeed;
		    if ( !chainNodes )
		      goto LABEL_47;
		    ringBufferStart = chainNodes->fields.ringBufferStart;
		    ringBufferEnd = this->fields.chainNodes->fields.ringBufferEnd;
		    if ( ringBufferEnd != -1 && ringBufferEnd != ringBufferStart )
		    {
		      v11 = sub_1808B50D0(&v111, this->fields.chainNodes, ringBufferEnd);
		      chainSections = this->fields.chainSections;
		      v12 = v11;
		      v13 = *(_OWORD *)(v11 + 16);
		      v102 = *(_OWORD *)v11;
		      v14 = *(_OWORD *)(v11 + 32);
		      v103 = v13;
		      v15 = *(_OWORD *)(v11 + 48);
		      v104 = v14;
		      v16 = *(_OWORD *)(v11 + 64);
		      v105 = v15;
		      v17 = *(_OWORD *)(v11 + 80);
		      v106 = v16;
		      v18 = *(_OWORD *)(v11 + 96);
		      v107 = v17;
		      v19 = *(_OWORD *)(v11 + 16);
		      v108 = v18;
		      v20 = *(_OWORD *)(v11 + 112);
		      LODWORD(v11) = *(_DWORD *)(v11 + 128);
		      v109 = v20;
		      v110 = v11;
		      v4 = (TRingBuffer_1_HGInteractionChainSection_ *)&v121;
		      LODWORD(v11) = *(_DWORD *)(v12 + 128);
		      v121 = *(_OWORD *)v12;
		      v21 = *(_OWORD *)(v12 + 32);
		      v122 = v19;
		      v22 = *(_OWORD *)(v12 + 48);
		      v123 = v21;
		      v23 = *(_OWORD *)(v12 + 64);
		      v124 = v22;
		      v24 = *(_OWORD *)(v12 + 80);
		      v125 = v23;
		      v25 = *(_OWORD *)(v12 + 96);
		      v126 = v24;
		      v26 = *(_OWORD *)(v12 + 112);
		      v127 = v25;
		      v128 = v26;
		      v129 = v11;
		      if ( chainSections )
		      {
		        v27 = (__m128 *)sub_1808B50B0(&value_8, chainSections, DWORD2(v121));
		        v28 = -1.0;
		        v29 = DWORD2(v102);
		        v30 = _mm_shuffle_ps(*v27, *v27, 85).m128_f32[0] - _mm_shuffle_ps(*v27, *v27, 170).m128_f32[0];
		        while ( 1 )
		        {
		          chainSections = this->fields.chainNodes;
		          if ( !chainSections )
		            break;
		          chainSections = (_OWORD *)sub_1808B50D0(v130, chainSections, ringBufferStart);
		          v31 = chainSections[1];
		          *(_OWORD *)&v101.VRange.x = *chainSections;
		          v32 = chainSections[2];
		          *(_OWORD *)&v101.HeightFade.y = v31;
		          v33 = chainSections[3];
		          *(_OWORD *)&v101.TimeFade.w = v32;
		          v34 = chainSections[4];
		          *(_OWORD *)&v101.Position.y = v33;
		          v35 = chainSections[5];
		          *(_OWORD *)&v101.Rotation.z = v34;
		          v36 = chainSections[6];
		          *(_OWORD *)&v101.Vertex0.x = v35;
		          v37 = chainSections[7];
		          v38 = *((_DWORD *)chainSections + 32);
		          *(_OWORD *)&v101.Vertex1.y = v36;
		          v39 = *chainSections;
		          *(_OWORD *)&v101.Vertex2.z = v37;
		          *(_DWORD *)&v101.Active = v38;
		          v40 = *((_DWORD *)chainSections + 32);
		          v41 = chainSections[1];
		          v102 = v39;
		          v42 = chainSections[2];
		          v103 = v41;
		          v43 = chainSections[3];
		          v104 = v42;
		          v44 = chainSections[4];
		          v105 = v43;
		          v45 = chainSections[5];
		          v106 = v44;
		          v46 = chainSections[6];
		          v107 = v45;
		          v47 = chainSections[7];
		          v108 = v46;
		          v48 = *chainSections;
		          v109 = v47;
		          v110 = v40;
		          v49 = chainSections[1];
		          v121 = v48;
		          v50 = chainSections[2];
		          v122 = v49;
		          v51 = chainSections[3];
		          v123 = v50;
		          v52 = chainSections[4];
		          v124 = v51;
		          v53 = chainSections[5];
		          v125 = v52;
		          v54 = chainSections[6];
		          v126 = v53;
		          v55 = chainSections[7];
		          v127 = v54;
		          v56 = *chainSections;
		          v128 = v55;
		          v129 = v40;
		          v4 = (TRingBuffer_1_HGInteractionChainSection_ *)&v111;
		          v57 = chainSections[1];
		          v111 = v56;
		          v58 = chainSections[2];
		          v112 = v57;
		          v59 = chainSections[3];
		          v113 = v58;
		          v60 = chainSections[4];
		          v114 = v59;
		          v61 = chainSections[5];
		          v115 = v60;
		          v62 = chainSections[6];
		          v116 = v61;
		          v63 = chainSections[7];
		          v117 = v62;
		          v118 = v63;
		          v119 = v40;
		          if ( DWORD2(v111) == v29 )
		          {
		            v4 = (TRingBuffer_1_HGInteractionChainSection_ *)&v111;
		            v64 = chainSections[1];
		            v111 = *chainSections;
		            v65 = chainSections[2];
		            v112 = v64;
		            v66 = chainSections[3];
		            v113 = v65;
		            v67 = chainSections[4];
		            v114 = v66;
		            v68 = chainSections[5];
		            v115 = v67;
		            v69 = chainSections[6];
		            v116 = v68;
		            v70 = chainSections[7];
		            v117 = v69;
		            v118 = v70;
		            v119 = v40;
		            if ( v30 < *((float *)&v111 + 1) )
		            {
		              if ( v28 < 0.0 )
		              {
		                v71 = chainSections[1];
		                v111 = *chainSections;
		                v72 = chainSections[2];
		                v112 = v71;
		                v73 = chainSections[3];
		                v113 = v72;
		                v74 = chainSections[4];
		                v114 = v73;
		                v75 = chainSections[5];
		                v115 = v74;
		                v76 = chainSections[6];
		                v116 = v75;
		                v77 = chainSections[7];
		                v117 = v76;
		                v118 = v77;
		                v119 = v40;
		                v28 = *(float *)&v111;
		              }
		              v78 = *((_DWORD *)chainSections + 32);
		              v4 = (TRingBuffer_1_HGInteractionChainSection_ *)&v111;
		              v79 = chainSections[1];
		              v111 = *chainSections;
		              v80 = chainSections[2];
		              v112 = v79;
		              v81 = chainSections[3];
		              v113 = v80;
		              v82 = chainSections[4];
		              v114 = v81;
		              v83 = chainSections[5];
		              v115 = v82;
		              v84 = chainSections[6];
		              v116 = v83;
		              v85 = chainSections[7];
		              v117 = v84;
		              v118 = v85;
		              v119 = v78;
		              v86 = this->fields.settingAsset;
		              if ( !v86 )
		                break;
		              if ( v86->fields.edgeFadeDistance <= (float)(*(float *)&v111 - v28) )
		              {
		                v87 = 1.0;
		              }
		              else
		              {
		                v87 = *((float *)&v103 + 2) - v8;
		                if ( (float)(*((float *)&v103 + 2) - v8) <= 0.0 )
		                  v87 = 0.0;
		              }
		              v97.y = v87;
		              v88 = *((float *)&v123 + 2);
		              v97.x = 1.0;
		              *(_QWORD *)&v97.z = 0x3F8000003F800000LL;
		              v89.x = 1.0;
		              v101.TimeFade = v97;
		              if ( *((float *)&v123 + 2) < 0.0 )
		                v88 = v30;
		              if ( v28 > v88 )
		                v88 = v28;
		              v101.StartDist.x = v30;
		              v101.StartDist.y = v88;
		              goto LABEL_36;
		            }
		            v90 = *((float *)&v103 + 1) - v8;
		            if ( (float)(*((float *)&v103 + 1) - v8) <= 0.0 )
		              v90 = 0.0;
		            v91 = *((float *)&v103 + 2) - v8;
		            if ( (float)(*((float *)&v103 + 2) - v8) <= 0.0 )
		              v91 = 0.0;
		            *(_QWORD *)&v98.x = __PAIR64__(LODWORD(v91), LODWORD(v90));
		            *(_QWORD *)&v98.z = 0x3F8000003F800000LL;
		            v89 = v98;
		            v101.StartDist.y = *((float *)&v123 + 2);
		            v101.StartDist.x = v30;
		          }
		          else
		          {
		            v92 = *((float *)&v103 + 1) - v8;
		            if ( (float)(*((float *)&v103 + 1) - v8) <= 0.0 )
		              v92 = 0.0;
		            v93 = *((float *)&v103 + 2) - v8;
		            if ( (float)(*((float *)&v103 + 2) - v8) <= 0.0 )
		              v93 = 0.0;
		            v94 = *((float *)&v103 + 3) - v8;
		            if ( (float)(*((float *)&v103 + 3) - v8) <= 0.0 )
		              v94 = 0.0;
		            *(_QWORD *)&v99.z = LODWORD(v94) | 0x3F80000000000000LL;
		            *(_QWORD *)&v99.x = __PAIR64__(LODWORD(v93), LODWORD(v92));
		            v89 = v99;
		            v101.StartDist = *(Vector2 *)((char *)&v123 + 4);
		          }
		          v101.TimeFade = v89;
		LABEL_36:
		          if ( v89.x == 0.0 )
		          {
		            chainSections = this->fields.chainSections;
		            if ( !chainSections )
		              break;
		            v95 = (HGInteractionChainSection *)sub_1808B50B0(v120, chainSections, (unsigned int)v101.SectionIndex);
		            v4 = this->fields.chainSections;
		            value_8 = *v95;
		            value_8.VRange.x = v101.VRange.y;
		            if ( !v4 )
		              break;
		            HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::SetNodeAtIndex(
		              v4,
		              v101.SectionIndex,
		              &value_8,
		              MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainSection>::SetNodeAtIndex);
		            v4 = (TRingBuffer_1_HGInteractionChainSection_ *)this->fields.chainNodes;
		            if ( !v4 )
		              break;
		            HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::DeleteTailNodes(
		              (TRingBuffer_1_HGInteractionChainNode_ *)v4,
		              1,
		              MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::DeleteTailNodes);
		          }
		          else
		          {
		            v4 = (TRingBuffer_1_HGInteractionChainSection_ *)this->fields.chainNodes;
		            if ( !v4 )
		              break;
		            HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::SetNodeAtIndex(
		              (TRingBuffer_1_HGInteractionChainNode_ *)v4,
		              ringBufferStart,
		              &v101,
		              MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::SetNodeAtIndex);
		          }
		          v4 = (TRingBuffer_1_HGInteractionChainSection_ *)this->fields.chainNodes;
		          if ( !v4 )
		            break;
		          ringBufferStart = HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetNextIndex(
		                              (TRingBuffer_1_HGInteractionChainNode_ *)v4,
		                              ringBufferStart,
		                              MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetNextIndex);
		          if ( ringBufferStart == ringBufferEnd )
		            return;
		        }
		      }
		LABEL_47:
		      sub_1800D8260(v4, chainSections);
		    }
		  }
		}
		
		public void UpdateRenderData() {} // 0x0000000189CFDC0C-0x0000000189CFE038
		// Void UpdateRenderData()
		void HG::Rendering::Runtime::HGInteractionChain::UpdateRenderData(HGInteractionChain *this, MethodInfo *method)
		{
		  TileBase *chainSections; // rdx
		  TRingBuffer_1_HGInteractionChainNode_ *chainNodes; // rcx
		  int32_t NodeCount; // eax
		  int32_t v6; // edi
		  unsigned int ringBufferStart; // r14d
		  int32_t v8; // esi
		  __int64 v9; // r8
		  ITilemap *v10; // r9
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  __int128 v15; // xmm1
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  int v18; // eax
		  __int128 v19; // xmm0
		  __int128 v20; // xmm1
		  int v21; // eax
		  __int128 v22; // xmm0
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  __int128 v26; // xmm0
		  __int128 v27; // xmm1
		  TileAnimationData *TileAnimationDataNoRef; // rax
		  __int128 *v29; // r8
		  __int128 v30; // xmm1
		  __m128i v31; // xmm6
		  int v32; // eax
		  __int128 v33; // xmm0
		  __int128 v34; // xmm1
		  __int128 v35; // xmm0
		  __int128 v36; // xmm1
		  __int128 v37; // xmm0
		  __int128 v38; // xmm1
		  __int128 v39; // xmm1
		  __int128 v40; // xmm0
		  __int128 v41; // xmm1
		  __int128 v42; // xmm0
		  __int128 v43; // xmm1
		  __int128 v44; // xmm0
		  __int128 v45; // xmm1
		  __m128 *v46; // rax
		  Matrix4x4 *Matrix; // rax
		  __m128i v48; // xmm1
		  __m128i v49; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __m128i v51; // [rsp+28h] [rbp-E0h]
		  __m128i v52; // [rsp+38h] [rbp-D0h] BYREF
		  __m128i v53; // [rsp+48h] [rbp-C0h]
		  __m128i v54; // [rsp+58h] [rbp-B0h]
		  __m128i v55; // [rsp+68h] [rbp-A0h]
		  __m128i v56; // [rsp+78h] [rbp-90h]
		  __m128i v57; // [rsp+88h] [rbp-80h]
		  __m128i v58; // [rsp+98h] [rbp-70h]
		  __m128i v59; // [rsp+A8h] [rbp-60h]
		  Vector4 TimeFade; // [rsp+B8h] [rbp-50h]
		  HGInteractionChainNode v61; // [rsp+C8h] [rbp-40h] BYREF
		  TileAnimationData v62; // [rsp+158h] [rbp+50h] BYREF
		  char v63[16]; // [rsp+168h] [rbp+60h] BYREF
		  __int128 v64; // [rsp+178h] [rbp+70h] BYREF
		  __int128 v65; // [rsp+188h] [rbp+80h]
		  __int128 v66; // [rsp+198h] [rbp+90h]
		  __int128 v67; // [rsp+1A8h] [rbp+A0h]
		  __int128 v68; // [rsp+1B8h] [rbp+B0h]
		  __int128 v69; // [rsp+1C8h] [rbp+C0h]
		  __int128 v70; // [rsp+1D8h] [rbp+D0h]
		  __int128 v71; // [rsp+1E8h] [rbp+E0h]
		  int v72; // [rsp+1F8h] [rbp+F0h]
		  __m128i v73[9]; // [rsp+208h] [rbp+100h] BYREF
		  Matrix4x4 v74; // [rsp+298h] [rbp+190h] BYREF
		
		  sub_18033B9D0(&v52, 0LL, 144LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(1785, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1785, 0LL);
		    if ( !Patch )
		      goto LABEL_17;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    this->fields.activeCount = 0;
		    chainNodes = this->fields.chainNodes;
		    if ( !chainNodes )
		      goto LABEL_17;
		    NodeCount = HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetNodeCount(
		                  chainNodes,
		                  MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetNodeCount);
		    v6 = NodeCount;
		    if ( NodeCount )
		    {
		      chainNodes = this->fields.chainNodes;
		      if ( !chainNodes )
		        goto LABEL_17;
		      ringBufferStart = chainNodes->fields.ringBufferStart;
		      v8 = 0;
		      if ( NodeCount > 0 )
		      {
		        while ( 1 )
		        {
		          chainSections = (TileBase *)this->fields.chainNodes;
		          if ( !chainSections )
		            break;
		          v9 = sub_1808B50D0(v73, chainSections, ringBufferStart);
		          v11 = *(_OWORD *)(v9 + 16);
		          *(_OWORD *)&v61.VRange.x = *(_OWORD *)v9;
		          v12 = *(_OWORD *)(v9 + 32);
		          *(_OWORD *)&v61.HeightFade.y = v11;
		          v13 = *(_OWORD *)(v9 + 48);
		          *(_OWORD *)&v61.TimeFade.w = v12;
		          v14 = *(_OWORD *)(v9 + 64);
		          *(_OWORD *)&v61.Position.y = v13;
		          v15 = *(_OWORD *)(v9 + 80);
		          *(_OWORD *)&v61.Rotation.z = v14;
		          v16 = *(_OWORD *)(v9 + 96);
		          *(_OWORD *)&v61.Vertex0.x = v15;
		          v17 = *(_OWORD *)(v9 + 112);
		          v18 = *(_DWORD *)(v9 + 128);
		          *(_OWORD *)&v61.Vertex1.y = v16;
		          v19 = *(_OWORD *)v9;
		          *(_OWORD *)&v61.Vertex2.z = v17;
		          *(_DWORD *)&v61.Active = v18;
		          v20 = *(_OWORD *)(v9 + 16);
		          v21 = *(_DWORD *)(v9 + 128);
		          v64 = v19;
		          v22 = *(_OWORD *)(v9 + 32);
		          v65 = v20;
		          v23 = *(_OWORD *)(v9 + 48);
		          v66 = v22;
		          v24 = *(_OWORD *)(v9 + 64);
		          v67 = v23;
		          v25 = *(_OWORD *)(v9 + 80);
		          v68 = v24;
		          v26 = *(_OWORD *)(v9 + 96);
		          v69 = v25;
		          v27 = *(_OWORD *)(v9 + 112);
		          v70 = v26;
		          v71 = v27;
		          v72 = v21;
		          if ( (_BYTE)v21 )
		          {
		            TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                       &v62,
		                                       chainSections,
		                                       (Vector3Int *)v9,
		                                       v10,
		                                       (MethodInfo *)v51.m128i_i64[0]);
		            v30 = v29[1];
		            v31 = _mm_loadu_si128((const __m128i *)TileAnimationDataNoRef);
		            v32 = *((_DWORD *)v29 + 32);
		            v64 = *v29;
		            v33 = v29[2];
		            v65 = v30;
		            v34 = v29[3];
		            v66 = v33;
		            v35 = v29[4];
		            v67 = v34;
		            v36 = v29[5];
		            v68 = v35;
		            v37 = v29[6];
		            v69 = v36;
		            v38 = v29[7];
		            v70 = v37;
		            v71 = v38;
		            v72 = v32;
		            v51.m128i_i64[0] = v31.m128i_i64[0];
		            if ( (SDWORD2(v64) & 0x80000000) == 0 )
		            {
		              chainSections = (TileBase *)this->fields.chainSections;
		              chainNodes = (TRingBuffer_1_HGInteractionChainNode_ *)&v64;
		              v39 = v29[1];
		              v64 = *v29;
		              v40 = v29[2];
		              v65 = v39;
		              v41 = v29[3];
		              v66 = v40;
		              v42 = v29[4];
		              v67 = v41;
		              v43 = v29[5];
		              v68 = v42;
		              v44 = v29[6];
		              v69 = v43;
		              v45 = v29[7];
		              v70 = v44;
		              v71 = v45;
		              v72 = v32;
		              if ( !chainSections )
		                break;
		              v46 = (__m128 *)sub_1808B50B0(v63, chainSections, DWORD2(v64));
		              v51.m128i_i32[0] = (__int32)*v46;
		              v51.m128i_i32[1] = _mm_shuffle_ps(*v46, *v46, 85).m128_u32[0];
		              v51.m128i_i64[1] = (__int64)v61.StartDist;
		              v31 = v51;
		            }
		            sub_18033B9D0(&v52, 0LL, 144LL);
		            Matrix = HG::Rendering::Runtime::HGInteractionChainNode::GetMatrix(&v74, &v61, 0LL);
		            chainSections = (TileBase *)this->fields.activeCount;
		            chainNodes = (TRingBuffer_1_HGInteractionChainNode_ *)this->fields.interactionData;
		            v59 = v31;
		            v48 = *(__m128i *)&Matrix->m01;
		            v52 = *(__m128i *)&Matrix->m00;
		            v53 = v48;
		            v49 = *(__m128i *)&Matrix->m03;
		            v54 = *(__m128i *)&Matrix->m02;
		            v56.m128i_i32[0] = LODWORD(v61.Vertex0.x);
		            v55 = v49;
		            *(__int64 *)((char *)v56.m128i_i64 + 4) = *(_QWORD *)&v61.Vertex0.z;
		            v57.m128i_i32[0] = LODWORD(v61.Vertex2.x);
		            v56.m128i_i32[3] = LODWORD(v61.Vertex1.z);
		            *(__int64 *)((char *)v57.m128i_i64 + 4) = *(_QWORD *)&v61.Vertex2.z;
		            v58.m128i_i32[0] = LODWORD(v61.VRange.x);
		            v57.m128i_i32[3] = LODWORD(v61.Vertex3.z);
		            *(__int64 *)((char *)v58.m128i_i64 + 4) = __PAIR64__(LODWORD(v61.HeightFade.x), LODWORD(v61.VRange.y));
		            v58.m128i_i32[3] = LODWORD(v61.HeightFade.y);
		            this->fields.activeCount = (_DWORD)chainSections + 1;
		            TimeFade = v61.TimeFade;
		            if ( !chainNodes )
		              break;
		            v73[0] = v52;
		            v73[1] = v53;
		            v73[2] = v54;
		            v73[3] = v55;
		            v73[4] = v56;
		            v73[5] = v57;
		            v73[6] = v58;
		            v73[7] = v59;
		            v73[8] = (__m128i)TimeFade;
		            sub_1808B5034(chainNodes, chainSections, v73);
		          }
		          chainNodes = this->fields.chainNodes;
		          ++v8;
		          if ( !chainNodes )
		            break;
		          ringBufferStart = HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetNextIndex(
		                              chainNodes,
		                              ringBufferStart,
		                              MethodInfo::HG::Rendering::Runtime::TRingBuffer<HG::Rendering::Runtime::HGInteractionChainNode>::GetNextIndex);
		          if ( v8 >= v6 )
		            return;
		        }
		LABEL_17:
		        sub_1800D8260(chainNodes, chainSections);
		      }
		    }
		  }
		}
		
	}
}
