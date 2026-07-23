using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGBoneCapsuleUtilities // TypeDefIndex: 38679
	{
		// Constructors
		public HGBoneCapsuleUtilities() {} // 0x00000001841E1670-0x00000001841E1680
		// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
		void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
		        HGWindConfig *cSrc,
		        HGWindConfig *cDst,
		        float t,
		        MethodInfo *method)
		{
		  ;
		}
		
	
		// Methods
		public static List<HGBoneCapsuleData> AutomateGenerateCapsuleSkeletonsNonHuman(GameObject root) => default; // 0x0000000189C1E074-0x0000000189C1F354
		// List`1[HG.Rendering.Runtime.HGBoneCapsuleData] AutomateGenerateCapsuleSkeletonsNonHuman(GameObject)
		// Hidden C++ exception states: #wind=1
		List_1_HG_Rendering_Runtime_HGBoneCapsuleData_ *HG::Rendering::Runtime::HGBoneCapsuleUtilities::AutomateGenerateCapsuleSkeletonsNonHuman(
		        GameObject *root,
		        MethodInfo *method)
		{
		  Func_2_Google_Protobuf_IMessage_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  List_1_HG_Rendering_Runtime_HGBoneCapsuleData_ *v6; // r13
		  MethodInfo *v7; // rdx
		  Vector3 *up; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  LOD__Array *LODs; // rax
		  __int64 v14; // rdi
		  Action_2_Google_Protobuf_IMessage_Object_ *v15; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  List_1_System_Object_ *setValueDelegate; // r15
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  unsigned int i; // esi
		  Object *v22; // r14
		  Dictionary_2_System_Object_System_Object_ *v23; // rax
		  __int64 v24; // rdx
		  __int64 v25; // rcx
		  Dictionary_2_System_UInt64_System_Object_ *v26; // rdi
		  HashSet_1_System_Object_ *v27; // rax
		  __int64 v28; // rdx
		  __int64 v29; // rcx
		  SingleFieldAccessor__Class *v30; // rsi
		  Type *v31; // rdx
		  PropertyInfo_1 *v32; // r8
		  Int32__Array **v33; // r9
		  int32_t size; // r14d
		  Dictionary_2_System_Object_System_Object_ *v35; // rax
		  __int64 v36; // rdx
		  __int64 v37; // rcx
		  MonitorData *v38; // rsi
		  Type *v39; // rdx
		  PropertyInfo_1 *v40; // r8
		  Int32__Array **v41; // r9
		  __int64 v42; // rdx
		  __int64 v43; // rcx
		  int32_t j; // eax
		  Object *Item; // rsi
		  Mesh *sharedMesh; // r14
		  __int64 v47; // rdx
		  __int64 v48; // rcx
		  Transform__Array *bones; // r13
		  Matrix4x4__Array *bindposes; // rax
		  Transform *transform; // rax
		  __int64 v52; // rdx
		  __int64 v53; // rcx
		  Matrix4x4 *localToWorldMatrix; // rax
		  __int64 v55; // rdx
		  __int64 v56; // rcx
		  __int128 v57; // xmm6
		  __int128 v58; // xmm7
		  __int128 v59; // xmm8
		  __int128 v60; // xmm9
		  int32_t k; // r12d
		  Matrix4x4 *v62; // rax
		  Matrix4x4 *v63; // rax
		  __int64 v64; // rdx
		  __int64 v65; // rcx
		  __int128 v66; // xmm11
		  __int128 v67; // xmm12
		  __int128 v68; // xmm13
		  BoneWeight__Array *BoneWeightsImpl; // rsi
		  int m; // r14d
		  __int64 v71; // rax
		  float m00; // xmm0_4
		  Object *v73; // r12
		  __int64 v74; // rdx
		  __int64 v75; // rcx
		  List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *v76; // rax
		  __int64 v77; // rdx
		  __int64 v78; // rcx
		  Func_2_Google_Protobuf_IMessage_Boolean_ *v79; // rsi
		  Vector3 *v80; // rax
		  __int64 v81; // rdx
		  __int64 v82; // rcx
		  __int64 v83; // r9
		  float v84; // r12d
		  int32_t count; // eax
		  int32_t v86; // esi
		  List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *v87; // rax
		  __int64 v88; // rdx
		  __int64 v89; // rcx
		  List_1_HG_Rendering_Runtime_HGBoneCapsuleData_ *getValueDelegate; // r13
		  Object *key; // r14
		  List_1_UnityEngine_Vector3_ *v92; // rdi
		  __int64 v93; // rdx
		  __int64 v94; // rcx
		  Vector3 *v95; // rax
		  Vector3 *v96; // r8
		  Vector3 *v97; // rcx
		  Vector3 *v98; // rax
		  Vector3 *v99; // rax
		  __int64 v100; // xmm6_8
		  float v101; // esi
		  Object_1 *BuddyBone_0_0; // r15
		  Vector3 *v103; // rax
		  float v104; // xmm2_4
		  __int64 v105; // xmm7_8
		  float v106; // r13d
		  int32_t v107; // r15d
		  List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *v108; // rax
		  __int64 v109; // rdx
		  __int64 v110; // rcx
		  List_1_System_Single_ *v111; // rsi
		  int32_t v112; // r15d
		  List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *v113; // rax
		  __int64 v114; // rdx
		  __int64 v115; // rcx
		  List_1_System_Single_ *v116; // r12
		  __int64 v117; // rdx
		  __int64 v118; // rcx
		  int32_t v119; // r15d
		  __m128 y_low; // xmm14
		  __m128 v121; // xmm10
		  float v122; // xmm11_4
		  __m128 lodLevel; // xmm9
		  __m128 distance_low; // xmm8
		  float v125; // xmm6_4
		  __int64 v126; // rdx
		  __int64 v127; // rdx
		  float v128; // xmm11_4
		  float v129; // xmm9_4
		  float v130; // xmm6_4
		  __int64 v131; // rdx
		  __int64 v132; // rcx
		  float v133; // xmm8_4
		  float v134; // xmm6_4
		  float v135; // xmm9_4
		  float v136; // xmm15_4
		  Vector3 *position; // rax
		  __int64 v138; // xmm9_8
		  float v139; // edi
		  Quaternion *rotation; // rax
		  Vector3 *v141; // rax
		  __int64 v142; // xmm9_8
		  float v143; // edi
		  __m128i v144; // xmm7
		  Quaternion *v145; // rax
		  MethodInfo *v146; // r9
		  __int64 v147; // rax
		  unsigned __int64 v148; // rdx
		  signed __int64 v149; // rcx
		  __int64 v150; // xmm2_8
		  int v151; // r9d
		  unsigned __int64 v152; // r8
		  signed __int64 v153; // rtt
		  char *v155; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v157; // rdx
		  __int64 v158; // rcx
		  MethodInfo *v159; // [rsp+20h] [rbp-528h]
		  MethodInfo *v160; // [rsp+20h] [rbp-528h]
		  Vector3 v161; // [rsp+30h] [rbp-518h]
		  Dictionary_2_System_Object_System_Object_ *v162; // [rsp+40h] [rbp-508h]
		  Dictionary_2_System_Object_System_Object_ *v163; // [rsp+40h] [rbp-508h]
		  Object *value; // [rsp+50h] [rbp-4F8h]
		  Object *valuea; // [rsp+50h] [rbp-4F8h]
		  Object *valueb; // [rsp+50h] [rbp-4F8h]
		  DynamicStreamingScene_LodRawInfo v167; // [rsp+60h] [rbp-4E8h] BYREF
		  SingleFieldAccessor param_0004f140; // [rsp+70h] [rbp-4D8h] BYREF
		  __int64 v169; // [rsp+A8h] [rbp-4A0h] BYREF
		  float v170; // [rsp+B0h] [rbp-498h]
		  Vector3 v171; // [rsp+C0h] [rbp-488h] BYREF
		  Vector3 v172; // [rsp+D0h] [rbp-478h] BYREF
		  __int64 v173; // [rsp+E0h] [rbp-468h] BYREF
		  float v174; // [rsp+E8h] [rbp-460h]
		  Vector3 v175; // [rsp+F0h] [rbp-458h] BYREF
		  _BYTE v176[40]; // [rsp+100h] [rbp-448h] BYREF
		  Object *component; // [rsp+128h] [rbp-420h] BYREF
		  Quaternion v178; // [rsp+130h] [rbp-418h] BYREF
		  Matrix4x4 v179; // [rsp+140h] [rbp-408h] BYREF
		  __int64 v180; // [rsp+180h] [rbp-3C8h] BYREF
		  float v181; // [rsp+188h] [rbp-3C0h]
		  Vector3 v182; // [rsp+190h] [rbp-3B8h] BYREF
		  unsigned __int64 v183; // [rsp+1A0h] [rbp-3A8h] BYREF
		  float v184; // [rsp+1A8h] [rbp-3A0h]
		  Vector3 v185; // [rsp+1B0h] [rbp-398h] BYREF
		  Vector3 v186; // [rsp+1C0h] [rbp-388h] BYREF
		  Vector3 v187; // [rsp+1D0h] [rbp-378h] BYREF
		  Vector3 v188; // [rsp+1E0h] [rbp-368h] BYREF
		  __m128i v189; // [rsp+1F0h] [rbp-358h] BYREF
		  Il2CppException *ex; // [rsp+200h] [rbp-348h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *v191; // [rsp+208h] [rbp-340h]
		  __int64 v192; // [rsp+210h] [rbp-338h]
		  List_1_HG_Rendering_Runtime_HGBoneCapsuleData_ *v193; // [rsp+218h] [rbp-330h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v194; // [rsp+220h] [rbp-328h] BYREF
		  Matrix4x4 v195; // [rsp+250h] [rbp-2F8h] BYREF
		  Matrix4x4 v196; // [rsp+290h] [rbp-2B8h] BYREF
		  Matrix4x4 bindW; // [rsp+2D0h] [rbp-278h] BYREF
		  Il2CppExceptionWrapper *v198; // [rsp+310h] [rbp-238h] BYREF
		  Vector3 v199; // [rsp+318h] [rbp-230h] BYREF
		  Vector3 v200; // [rsp+328h] [rbp-220h] BYREF
		  Vector3 v201; // [rsp+338h] [rbp-210h] BYREF
		  _BYTE v202[16]; // [rsp+348h] [rbp-200h] BYREF
		  Vector3 v203; // [rsp+358h] [rbp-1F0h] BYREF
		  Vector3 v204; // [rsp+368h] [rbp-1E0h] BYREF
		  Vector3 v205; // [rsp+378h] [rbp-1D0h] BYREF
		  char v206; // [rsp+388h] [rbp-1C0h] BYREF
		  char v207; // [rsp+398h] [rbp-1B0h] BYREF
		  _BYTE v208[16]; // [rsp+3A8h] [rbp-1A0h] BYREF
		  Quaternion v209; // [rsp+3B8h] [rbp-190h] BYREF
		  Quaternion v210; // [rsp+3C8h] [rbp-180h] BYREF
		  Quaternion v211; // [rsp+3D8h] [rbp-170h] BYREF
		  Quaternion v212; // [rsp+3E8h] [rbp-160h] BYREF
		  Matrix4x4 v213; // [rsp+400h] [rbp-148h] BYREF
		  Matrix4x4 v214[3]; // [rsp+440h] [rbp-108h] BYREF
		  int32_t v215; // [rsp+560h] [rbp+18h]
		  bool BoneBindWorldMatrix_0_1; // [rsp+560h] [rbp+18h]
		  float z; // [rsp+568h] [rbp+20h]
		
		  *(_OWORD *)&param_0004f140.klass = 0LL;
		  component = 0LL;
		  param_0004f140.fields.hasDelegate = 0LL;
		  memset(&v194, 0, sizeof(v194));
		  sub_18033B9D0(&bindW, 0LL, 64LL);
		  sub_18033B9D0(&v213, 0LL, 64LL);
		  v169 = 0LL;
		  v170 = 0.0;
		  memset(v176, 0, sizeof(v176));
		  if ( IFix::WrappersManagerImpl::IsPatched(4098, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4098, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v158, v157);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1447(Patch, (Object *)root, 0LL);
		  }
		  v3 = (Func_2_Google_Protobuf_IMessage_Object_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGBoneCapsuleData>);
		  v6 = (List_1_HG_Rendering_Runtime_HGBoneCapsuleData_ *)v3;
		  param_0004f140.fields._.getValueDelegate = v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::List(
		    (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)v3,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGBoneCapsuleData>::List);
		  v193 = v6;
		  up = UnityEngine::Vector3::get_up(&v175, v7);
		  v192 = *(_QWORD *)&up->x;
		  z = up->z;
		  if ( !root )
		    sub_1800D8260(v10, v9);
		  if ( !UnityEngine::GameObject::TryGetComponent<System::Object>(
		          root,
		          &component,
		          MethodInfo::UnityEngine::GameObject::TryGetComponent<UnityEngine::LODGroup>) )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Debug);
		    v155 = "未找到 LODGroup。";
		    goto LABEL_112;
		  }
		  if ( !component )
		    sub_1800D8260(v12, v11);
		  LODs = UnityEngine::LODGroup::GetLODs((LODGroup *)component, 0, 0LL);
		  if ( !LODs || !LODs->max_length.value )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Debug);
		    v155 = "LODGroup 中没有 LOD。";
		    goto LABEL_112;
		  }
		  v14 = *(_QWORD *)(sub_180002100(LODs, 0LL) + 8);
		  if ( !v14 || !*(_QWORD *)(v14 + 24) )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Debug);
		    v155 = "LOD0 中没有 renderer。";
		    goto LABEL_112;
		  }
		  v15 = (Action_2_Google_Protobuf_IMessage_Object_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<UnityEngine::SkinnedMeshRenderer>);
		  setValueDelegate = (List_1_System_Object_ *)v15;
		  param_0004f140.fields.setValueDelegate = v15;
		  if ( !v15 )
		    sub_1800D8260(v17, v16);
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)v15,
		    *(_DWORD *)(v14 + 24),
		    MethodInfo::System::Collections::Generic::List<UnityEngine::SkinnedMeshRenderer>::List);
		  for ( i = 0; (signed int)i < *(_DWORD *)(v14 + 24); ++i )
		  {
		    if ( i >= *(_DWORD *)(v14 + 24) )
		      sub_1800D2AB0(v20, v19);
		    v22 = (Object *)sub_180005050(*(_QWORD *)(v14 + 8LL * (int)i + 32), TypeInfo::UnityEngine::SkinnedMeshRenderer);
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality((Object_1 *)v22, 0LL, 0LL) )
		    {
		      if ( !setValueDelegate )
		        sub_1800D8260(v20, v19);
		      sub_182F01190(setValueDelegate, v22);
		    }
		  }
		  if ( !setValueDelegate )
		    sub_1800D8260(v20, v19);
		  if ( !setValueDelegate->fields._size )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Debug);
		    v155 = "LOD0 中没有 SkinnedMeshRenderer。";
		    goto LABEL_112;
		  }
		  v23 = (Dictionary_2_System_Object_System_Object_ *)sub_18002C620(TypeInfo::System::Collections::Generic::Dictionary<UnityEngine::Transform,System::Collections::Generic::List<UnityEngine::Vector3>>);
		  v26 = (Dictionary_2_System_UInt64_System_Object_ *)v23;
		  v162 = v23;
		  if ( !v23 )
		    sub_1800D8260(v25, v24);
		  System::Collections::Generic::Dictionary<System::Object,System::Object>::Dictionary(
		    v23,
		    256,
		    MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Transform,System::Collections::Generic::List<UnityEngine::Vector3>>::Dictionary);
		  v27 = (HashSet_1_System_Object_ *)sub_18002C620(TypeInfo::System::Collections::Generic::HashSet<UnityEngine::Transform>);
		  v30 = (SingleFieldAccessor__Class *)v27;
		  if ( !v27 )
		    sub_1800D8260(v29, v28);
		  System::Collections::Generic::HashSet<System::Object>::HashSet(
		    v27,
		    512,
		    MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Transform>::HashSet);
		  param_0004f140.klass = v30;
		  sub_18002D1B0(&param_0004f140, v31, v32, v33, v159);
		  size = setValueDelegate->fields._size;
		  v35 = (Dictionary_2_System_Object_System_Object_ *)sub_18002C620(TypeInfo::System::Collections::Generic::Dictionary<UnityEngine::SkinnedMeshRenderer,UnityEngine::Matrix4x4 []>);
		  v38 = (MonitorData *)v35;
		  if ( !v35 )
		    sub_1800D8260(v37, v36);
		  System::Collections::Generic::Dictionary<System::Object,System::Object>::Dictionary(
		    v35,
		    size,
		    MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::SkinnedMeshRenderer,UnityEngine::Matrix4x4 []>::Dictionary);
		  param_0004f140.monitor = v38;
		  sub_18002D1B0((SingleFieldAccessor *)&param_0004f140.monitor, v39, v40, v41, v160);
		  for ( j = 0; ; j = v215 + 1 )
		  {
		    v215 = j;
		    if ( j >= setValueDelegate->fields._size )
		      break;
		    Item = System::Collections::Generic::List<System::Object>::get_Item(
		             setValueDelegate,
		             j,
		             MethodInfo::System::Collections::Generic::List<UnityEngine::SkinnedMeshRenderer>::get_Item);
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Equality((Object_1 *)Item, 0LL, 0LL) )
		    {
		      if ( !Item )
		        sub_1800D8260(v43, v42);
		      sharedMesh = UnityEngine::SkinnedMeshRenderer::get_sharedMesh((SkinnedMeshRenderer *)Item, 0LL);
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( !UnityEngine::Object::op_Equality((Object_1 *)sharedMesh, 0LL, 0LL) )
		      {
		        bones = UnityEngine::SkinnedMeshRenderer::get_bones((SkinnedMeshRenderer *)Item, 0LL);
		        if ( !sharedMesh )
		          sub_1800D8260(v48, v47);
		        bindposes = UnityEngine::Mesh::get_bindposes(sharedMesh, 0LL);
		        *(_QWORD *)&v167.distance = bindposes;
		        if ( bones )
		        {
		          if ( bones->max_length.value )
		          {
		            if ( bindposes )
		            {
		              v43 = (unsigned int)bones->max_length.size;
		              if ( bindposes->max_length.size == (_DWORD)v43 )
		              {
		                value = (Object *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Matrix4x4, (unsigned int)v43);
		                transform = UnityEngine::Component::get_transform((Component *)Item, 0LL);
		                if ( !transform )
		                  sub_1800D8260(v53, v52);
		                localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(&v195, transform, 0LL);
		                v57 = *(_OWORD *)&localToWorldMatrix->m00;
		                *(_OWORD *)&v196.m00 = *(_OWORD *)&localToWorldMatrix->m00;
		                v58 = *(_OWORD *)&localToWorldMatrix->m01;
		                *(_OWORD *)&v196.m01 = v58;
		                v59 = *(_OWORD *)&localToWorldMatrix->m02;
		                *(_OWORD *)&v196.m02 = v59;
		                v60 = *(_OWORD *)&localToWorldMatrix->m03;
		                *(_OWORD *)&v196.m03 = v60;
		                for ( k = 0; k < bones->max_length.size; ++k )
		                {
		                  v62 = (Matrix4x4 *)sub_18049E964(*(_QWORD *)&v167.distance, k);
		                  v195 = *UnityEngine::Matrix4x4::get_inverse(&v179, v62, 0LL);
		                  *(_OWORD *)&v179.m00 = v57;
		                  *(_OWORD *)&v179.m01 = v58;
		                  *(_OWORD *)&v179.m02 = v59;
		                  *(_OWORD *)&v179.m03 = v60;
		                  v63 = UnityEngine::Matrix4x4::op_Multiply(v214, &v179, &v195, 0LL);
		                  v66 = *(_OWORD *)&v63->m01;
		                  v67 = *(_OWORD *)&v63->m02;
		                  v68 = *(_OWORD *)&v63->m03;
		                  if ( !value )
		                    sub_1800D8260(v65, v64);
		                  *(_OWORD *)&v195.m00 = *(_OWORD *)&v63->m00;
		                  *(_OWORD *)&v195.m01 = v66;
		                  *(_OWORD *)&v195.m02 = v67;
		                  *(_OWORD *)&v195.m03 = v68;
		                  sub_180041540(value, k, &v195);
		                }
		                v26 = (Dictionary_2_System_UInt64_System_Object_ *)v162;
		                if ( !param_0004f140.monitor )
		                  sub_1800D8260(v56, v55);
		                System::Collections::Generic::Dictionary<System::Object,System::Object>::set_Item(
		                  (Dictionary_2_System_Object_System_Object_ *)param_0004f140.monitor,
		                  Item,
		                  value,
		                  MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::SkinnedMeshRenderer,UnityEngine::Matrix4x4 []>::set_Item);
		                *(_QWORD *)&v167.distance = UnityEngine::Mesh::get_vertices(sharedMesh, 0LL);
		                BoneWeightsImpl = UnityEngine::Mesh::GetBoneWeightsImpl(sharedMesh, 0LL);
		                valuea = (Object *)BoneWeightsImpl;
		                for ( m = 0; ; ++m )
		                {
		                  if ( !*(_QWORD *)&v167.distance )
		                    sub_1800D8260(v43, v42);
		                  if ( m >= *(_DWORD *)(*(_QWORD *)&v167.distance + 24LL) )
		                    break;
		                  if ( !BoneWeightsImpl )
		                    sub_1800D8260(v43, v42);
		                  sub_18047F234(BoneWeightsImpl, &v179, m);
		                  *(float *)&v71 = v179.m01;
		                  m00 = v179.m00;
		                  if ( v179.m10 > v179.m00 )
		                  {
		                    v71 = HIDWORD(*(_QWORD *)&v179.m01);
		                    m00 = v179.m10;
		                  }
		                  v43 = *(_QWORD *)&v179.m21;
		                  if ( v179.m20 > m00 )
		                  {
		                    *(float *)&v71 = v179.m21;
		                    m00 = v179.m20;
		                  }
		                  if ( v179.m30 > m00 )
		                  {
		                    v43 = HIDWORD(*(_QWORD *)&v179.m21);
		                    *(float *)&v71 = v179.m31;
		                    m00 = v179.m30;
		                  }
		                  if ( (int)v71 >= 0 && (int)v71 < bones->max_length.size && m00 >= 0.5 )
		                  {
		                    if ( (unsigned int)v71 >= bones->max_length.size )
		                      sub_1800D2AB0(v43, v42);
		                    v73 = (Object *)bones->vector[(int)v71];
		                    sub_1800036A0(TypeInfo::UnityEngine::Object);
		                    if ( !UnityEngine::Object::op_Equality((Object_1 *)v73, 0LL, 0LL) )
		                    {
		                      if ( !param_0004f140.klass )
		                        sub_1800D8260(v43, v42);
		                      System::Collections::Generic::HashSet<System::Object>::Add(
		                        (HashSet_1_System_Object_ *)param_0004f140.klass,
		                        v73,
		                        MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Transform>::Add);
		                      if ( !v162 )
		                        sub_1800D8260(v75, v74);
		                      if ( !System::Collections::Generic::Dictionary<System::Object,System::Object>::TryGetValue(
		                              v162,
		                              v73,
		                              (Object **)&param_0004f140.fields.hasDelegate,
		                              MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Transform,System::Collections::Generic::List<UnityEngine::Vector3>>::TryGetValue) )
		                      {
		                        v76 = (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector3>);
		                        v79 = (Func_2_Google_Protobuf_IMessage_Boolean_ *)v76;
		                        if ( !v76 )
		                          sub_1800D8260(v78, v77);
		                        System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::List(
		                          v76,
		                          256,
		                          MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::List);
		                        param_0004f140.fields.hasDelegate = v79;
		                        System::Collections::Generic::Dictionary<System::Object,System::Object>::Add(
		                          v162,
		                          v73,
		                          (Object *)v79,
		                          MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Transform,System::Collections::Generic::List<UnityEngine::Vector3>>::Add);
		                      }
		                      sub_180049C60(*(_QWORD *)&v167.distance, &v171, m);
		                      v172 = v171;
		                      v80 = UnityEngine::Matrix4x4::MultiplyPoint3x4(&v175, &v196, &v172, 0LL);
		                      v84 = v80->z;
		                      if ( !param_0004f140.fields.hasDelegate )
		                        sub_1800D8260(v82, v81);
		                      v173 = *(_QWORD *)&v80->x;
		                      v174 = v84;
		                      sub_18036459C(
		                        param_0004f140.fields.hasDelegate,
		                        &v173,
		                        MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add,
		                        v83);
		                      BoneWeightsImpl = (BoneWeight__Array *)valuea;
		                    }
		                  }
		                }
		                setValueDelegate = (List_1_System_Object_ *)param_0004f140.fields.setValueDelegate;
		              }
		            }
		          }
		        }
		      }
		    }
		  }
		  if ( !v26 )
		    sub_1800D8260(v43, v42);
		  count = v26->fields._count;
		  if ( count == v26->fields._freeCount )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Debug);
		    v155 = "没有满足阈值的主导顶点，检查权重或阈值。";
		LABEL_112:
		    UnityEngine::Debug::LogWarning((Object *)v155, 0LL);
		    return 0LL;
		  }
		  v86 = count - v26->fields._freeCount;
		  v87 = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>);
		  if ( !v87 )
		    sub_1800D8260(v89, v88);
		  System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::List(
		    v87,
		    v86,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::List);
		  System::Collections::Generic::Dictionary<unsigned long,System::Object>::GetEnumerator(
		    (Dictionary_2_TKey_TValue_Enumerator_System_UInt64_System_Object_ *)&v179,
		    v26,
		    MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Transform,System::Collections::Generic::List<UnityEngine::Vector3>>::GetEnumerator);
		  *(_OWORD *)&v194._dictionary = *(_OWORD *)&v179.m00;
		  v194._current = *(KeyValuePair_2_System_Object_System_Object_ *)&v179.m01;
		  *(_QWORD *)&v194._getEnumeratorRetType = *(_QWORD *)&v179.m02;
		  ex = 0LL;
		  v191 = &v194;
		  try
		  {
		LABEL_68:
		    getValueDelegate = (List_1_HG_Rendering_Runtime_HGBoneCapsuleData_ *)param_0004f140.fields._.getValueDelegate;
		    while ( 1 )
		    {
		      do
		      {
		        if ( !System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,System::Object>::MoveNext(
		                &v194,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Transform,System::Collections::Generic::List<UnityEngine::Vector3>>::MoveNext) )
		          return getValueDelegate;
		        key = v194._current.key;
		        v92 = (List_1_UnityEngine_Vector3_ *)v194._current.value;
		      }
		      while ( !v194._current.value || SLODWORD(v194._current.value[1].monitor) < 8 );
		      BoneBindWorldMatrix_0_1 = HG::Rendering::Runtime::HGBoneCapsuleUtilities::_AutomateGenerateCapsuleSkeletonsNonHuman_g__TryGetBoneBindWorldMatrix_0_1(
		                                  (Transform *)v194._current.key,
		                                  &bindW,
		                                  (HGBoneCapsuleUtilities_c_DisplayClass0_0 *)&param_0004f140,
		                                  0LL);
		      if ( !BoneBindWorldMatrix_0_1 )
		        break;
		      *(_QWORD *)&v172.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		      v172.z = 0.0;
		      v99 = UnityEngine::Matrix4x4::MultiplyPoint3x4(&v204, &bindW, &v172, 0LL);
		      v100 = *(_QWORD *)&v99->x;
		      valueb = *(Object **)&v99->x;
		      v101 = v99->z;
		      BuddyBone_0_0 = (Object_1 *)HG::Rendering::Runtime::HGBoneCapsuleUtilities::_AutomateGenerateCapsuleSkeletonsNonHuman_g__FindBuddyBone_0_0(
		                                    (Transform *)key,
		                                    (HGBoneCapsuleUtilities_c_DisplayClass0_0 *)&param_0004f140,
		                                    0LL);
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Inequality(BuddyBone_0_0, 0LL, 0LL)
		        && HG::Rendering::Runtime::HGBoneCapsuleUtilities::_AutomateGenerateCapsuleSkeletonsNonHuman_g__TryGetBoneBindWorldMatrix_0_1(
		             (Transform *)BuddyBone_0_0,
		             &v213,
		             (HGBoneCapsuleUtilities_c_DisplayClass0_0 *)&param_0004f140,
		             0LL) )
		      {
		        *(_QWORD *)&v171.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		        v171.z = 0.0;
		        v103 = UnityEngine::Matrix4x4::MultiplyPoint3x4(&v205, &v213, &v171, 0LL);
		        param_0004f140.fields.setValueDelegate = *(Action_2_Google_Protobuf_IMessage_Object_ **)&v103->x;
		        v104 = v103->z;
		        *(float *)&v169 = *(float *)&param_0004f140.fields.setValueDelegate - *(float *)&valueb;
		        *((float *)&v169 + 1) = *((float *)&param_0004f140.fields.setValueDelegate + 1) - *((float *)&valueb + 1);
		        v170 = v104 - v101;
		        *(_QWORD *)&v161.x = v100;
		        v161.z = v101;
		        if ( (float)((float)(v170 * v170)
		                   + (float)((float)(*((float *)&v169 + 1) * *((float *)&v169 + 1))
		                           + (float)(*(float *)&v169 * *(float *)&v169))) <= 1.0e-10 )
		        {
		          v180 = v100;
		          v181 = v101;
		          v96 = (Vector3 *)&v180;
		          v97 = (Vector3 *)&v206;
		LABEL_75:
		          v98 = HG::Rendering::Runtime::HGBoneCapsuleUtilities::ComputePCAFirstAxis(v97, v92, v96, 0LL);
		          goto LABEL_82;
		        }
		        v98 = (Vector3 *)sub_182FAE2B0(v208, &v169);
		      }
		      else
		      {
		        *(_QWORD *)&v161.x = v100;
		        v161.z = v101;
		        *(_QWORD *)&v182.x = v100;
		        v182.z = v101;
		        v98 = HG::Rendering::Runtime::HGBoneCapsuleUtilities::ComputePCAFirstAxis(&v199, v92, &v182, 0LL);
		      }
		LABEL_82:
		      v105 = *(_QWORD *)&v98->x;
		      v106 = v98->z;
		      v163 = *(Dictionary_2_System_Object_System_Object_ **)&v98->x;
		      v107 = v92->fields._size;
		      v108 = (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<float>);
		      v111 = (List_1_System_Single_ *)v108;
		      if ( !v108 )
		        sub_1800D8250(v110, v109);
		      System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::List(
		        v108,
		        v107,
		        MethodInfo::System::Collections::Generic::List<float>::List);
		      v112 = v92->fields._size;
		      v113 = (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<float>);
		      v116 = (List_1_System_Single_ *)v113;
		      if ( !v113 )
		        sub_1800D8250(v115, v114);
		      System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::List(
		        v113,
		        v112,
		        MethodInfo::System::Collections::Generic::List<float>::List);
		      v119 = 0;
		      if ( !v92 )
		        sub_1800D8250(v118, v117);
		      y_low = (__m128)LODWORD(v161.y);
		      v121 = (__m128)(unsigned int)v163;
		      while ( v119 < v92->fields._size )
		      {
		        System::Collections::Generic::List<Beyond::Gameplay::Core::DynamicScene::DynamicStreamingScene::LodRawInfo>::get_Item(
		          &v167,
		          (List_1_Beyond_Gameplay_Core_DynamicScene_DynamicStreamingScene_LodRawInfo_ *)v92,
		          v119,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Item);
		        v122 = *(float *)&v167.gridId;
		        lodLevel = (__m128)(unsigned int)v167.lodLevel;
		        distance_low = (__m128)LODWORD(v167.distance);
		        v125 = (float)((float)(*(float *)&v167.gridId - v161.z) * v106)
		             + (float)((float)((float)(*(float *)&v167.lodLevel - v161.y) * *((float *)&v163 + 1))
		                     + (float)(*(float *)&v163 * (float)(v167.distance - v161.x)));
		        sub_1830BADF0(v111, v126, MethodInfo::System::Collections::Generic::List<float>::Add);
		        lodLevel.m128_f32[0] = lodLevel.m128_f32[0] - (float)((float)(v125 * *((float *)&v163 + 1)) + v161.y);
		        distance_low.m128_f32[0] = distance_low.m128_f32[0] - (float)((float)(v125 * *(float *)&v163) + v161.x);
		        v183 = _mm_unpacklo_ps(distance_low, lodLevel).m128_u64[0];
		        v184 = v122 - (float)((float)(v125 * v106) + v161.z);
		        sub_182F9FF00(&v183);
		        sub_1830BADF0(v116, v127, MethodInfo::System::Collections::Generic::List<float>::Add);
		        ++v119;
		      }
		      if ( !v111->fields._size )
		        goto LABEL_68;
		      v128 = HG::Rendering::Runtime::HGBoneCapsuleUtilities::Quantile(v111, 0.050000001, 0LL);
		      v129 = HG::Rendering::Runtime::HGBoneCapsuleUtilities::Quantile(v111, 0.94999999, 0LL);
		      v130 = HG::Rendering::Runtime::HGBoneCapsuleUtilities::Quantile(v116, 0.89999998, 0LL);
		      v133 = HG::Rendering::Runtime::HGBoneCapsuleUtilities::GetPaddingByScale((Transform *)key, 0LL) + v130;
		      if ( v133 <= 0.000099999997 )
		        v133 = 0.000099999997;
		      v134 = v129 - v128;
		      if ( (float)(v129 - v128) <= 0.0 )
		        v134 = 0.0;
		      if ( (float)(v133 + v133) > v134 && v134 <= 0.0099999998 )
		        v134 = 0.0099999998;
		      v135 = (float)(v129 + v128) * 0.5;
		      v136 = v161.z + (float)(v106 * v135);
		      y_low.m128_f32[0] = v161.y + (float)(*((float *)&v163 + 1) * v135);
		      v121.m128_f32[0] = (float)(*(float *)&v163 * v135) + v161.x;
		      if ( !BoneBindWorldMatrix_0_1 )
		      {
		        if ( !key )
		          sub_1800D8250(v132, v131);
		        position = UnityEngine::Transform::get_position(&v200, (Transform *)key, 0LL);
		        v138 = *(_QWORD *)&position->x;
		        v139 = position->z;
		        rotation = UnityEngine::Transform::get_rotation(&v209, (Transform *)key, 0LL);
		        *(_QWORD *)&v185.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		        v185.z = 1.0;
		        v178 = *rotation;
		        *(_QWORD *)&v186.x = v138;
		        v186.z = v139;
		        bindW = *UnityEngine::Matrix4x4::TRS(v214, &v186, &v178, &v185, 0LL);
		      }
		      v196 = *UnityEngine::Matrix4x4::get_inverse(v214, &bindW, 0LL);
		      *(_QWORD *)&v187.x = _mm_unpacklo_ps(v121, y_low).m128_u64[0];
		      v187.z = v136;
		      v141 = UnityEngine::Matrix4x4::MultiplyPoint3x4(&v201, &v196, &v187, 0LL);
		      v142 = *(_QWORD *)&v141->x;
		      v143 = v141->z;
		      *(_QWORD *)&v188.x = v105;
		      v188.z = v106;
		      *(_QWORD *)&v175.x = v192;
		      v175.z = z;
		      v144 = _mm_loadu_si128((const __m128i *)UnityEngine::Quaternion::FromToRotation(&v210, &v175, &v188, 0LL));
		      v178 = *UnityEngine::Matrix4x4::get_rotation(&v211, &bindW, 0LL);
		      v145 = UnityEngine::Quaternion::Inverse(&v212, &v178, 0LL);
		      v189 = v144;
		      v178 = *v145;
		      v189 = *(__m128i *)UnityEngine::Quaternion::op_Multiply((Quaternion *)&v179, &v178, (Quaternion *)&v189, v146);
		      v147 = sub_182F3F6C0(v202, &v189);
		      v150 = *(_QWORD *)v147;
		      v151 = *(_DWORD *)(v147 + 8);
		      memset(&v176[8], 0, 32);
		      *(_QWORD *)v176 = key;
		      if ( dword_18F35FD08 )
		      {
		        v152 = (((unsigned __int64)v176 >> 12) & 0x1FFFFF) >> 6;
		        v148 = ((unsigned __int64)v176 >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F103690[v152]);
		        do
		        {
		          v149 = qword_18F103690[v152] | (1LL << v148);
		          v153 = qword_18F103690[v152];
		        }
		        while ( v153 != _InterlockedCompareExchange64(&qword_18F103690[v152], v149, v153) );
		      }
		      *(float *)&v176[8] = v133;
		      *(float *)&v176[12] = v134;
		      *(_QWORD *)&v176[16] = v142;
		      *(float *)&v176[24] = v143;
		      *(_QWORD *)&v176[28] = v150;
		      *(_DWORD *)&v176[36] = v151;
		      getValueDelegate = (List_1_HG_Rendering_Runtime_HGBoneCapsuleData_ *)param_0004f140.fields._.getValueDelegate;
		      if ( !param_0004f140.fields._.getValueDelegate )
		        sub_1800D8250(v149, v148);
		      *(_OWORD *)&v195.m00 = *(_OWORD *)v176;
		      *(_OWORD *)&v195.m01 = *(_OWORD *)&v176[16];
		      *(_QWORD *)&v195.m02 = *(_QWORD *)&v176[32];
		      System::Collections::Generic::List<Beyond::StyledBlackboard::StyledDataPair>::Add(
		        (List_1_Beyond_StyledBlackboard_StyledDataPair_ *)param_0004f140.fields._.getValueDelegate,
		        (StyledBlackboard_StyledDataPair *)&v195,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGBoneCapsuleData>::Add);
		    }
		    if ( !key )
		      sub_1800D8250(v94, v93);
		    v95 = UnityEngine::Transform::get_position(&v203, (Transform *)key, 0LL);
		    v161 = *v95;
		    v173 = *(_QWORD *)&v95->x;
		    v174 = v161.z;
		    v96 = (Vector3 *)&v173;
		    v97 = (Vector3 *)&v207;
		    goto LABEL_75;
		  }
		  catch ( Il2CppExceptionWrapper *v198 )
		  {
		    ex = v198->ex;
		    if ( ex )
		      sub_18007E1E0(ex);
		    return v193;
		  }
		  return getValueDelegate;
		}
		
		private static float Quantile(List<float> data, float q) => default; // 0x0000000189C1FB5C-0x0000000189C1FC0C
		// Single Quantile(List`1[System.Single], Single)
		float HG::Rendering::Runtime::HGBoneCapsuleUtilities::Quantile(
		        List_1_System_Single_ *data,
		        float q,
		        MethodInfo *method)
		{
		  char v4; // dl
		  __int64 v5; // rcx
		  int v6; // r8d
		  int32_t v7; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4099, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4099, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_111((ILFixDynamicMethodWrapper_6 *)Patch, (Object *)data, q, 0LL);
		  }
		  else if ( data && data->fields._size )
		  {
		    System::Collections::Generic::List<float>::Sort(data, MethodInfo::System::Collections::Generic::List<float>::Sort);
		    v7 = sub_1834464B0(v5, v4, v6);
		    if ( v7 < 0 )
		    {
		      v7 = 0;
		    }
		    else if ( v7 > data->fields._size - 1 )
		    {
		      v7 = data->fields._size - 1;
		    }
		    return System::Collections::Generic::List<float>::get_Item(
		             data,
		             v7,
		             MethodInfo::System::Collections::Generic::List<float>::get_Item);
		  }
		  else
		  {
		    return 0.0;
		  }
		}
		
		private static float GetPaddingByScale(Transform bone) => default; // 0x0000000189C1FAB8-0x0000000189C1FB5C
		// Single GetPaddingByScale(Transform)
		float HG::Rendering::Runtime::HGBoneCapsuleUtilities::GetPaddingByScale(Transform *bone, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  Vector3 *lossyScale; // rax
		  __int32 v6; // xmm3_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v9[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4100, 0LL) )
		  {
		    if ( bone )
		    {
		      lossyScale = UnityEngine::Transform::get_lossyScale(v9, bone, 0LL);
		      COERCE_FLOAT(v6 = _mm_load_si128((const __m128i *)&xmmword_18B9592D0).m128i_i32[0]);
		      return (float)((float)((float)(COERCE_FLOAT(HIDWORD(*(_QWORD *)&lossyScale->x) & v6)
		                                   + COERCE_FLOAT(*(_QWORD *)&lossyScale->x & v6))
		                           + COERCE_FLOAT(LODWORD(lossyScale->z) & v6))
		                   * 0.33333334)
		           * 0.0049999999;
		    }
		LABEL_5:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4100, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)bone, 0LL);
		}
		
		private static Vector3 ComputePCAFirstAxis(List<Vector3> vertsWS, Vector3 origin) => default; // 0x0000000189C1F354-0x0000000189C1F7A0
		// Vector3 ComputePCAFirstAxis(List`1[UnityEngine.Vector3], Vector3)
		Vector3 *HG::Rendering::Runtime::HGBoneCapsuleUtilities::ComputePCAFirstAxis(
		        Vector3 *__return_ptr retstr,
		        List_1_UnityEngine_Vector3_ *vertsWS,
		        Vector3 *origin,
		        MethodInfo *method)
		{
		  Animator *v7; // rdx
		  int32_t v8; // r8d
		  MethodInfo *v9; // r9
		  int v10; // ebx
		  Vector3 *Vector; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v13; // rcx
		  MethodInfo *v14; // r9
		  __int64 v15; // xmm6_8
		  float v16; // r15d
		  int32_t v17; // r14d
		  MethodInfo *v18; // r9
		  Vector3 *v19; // rax
		  int32_t size; // eax
		  float v21; // xmm7_4
		  Vector3 *v22; // rax
		  double v23; // xmm8_8
		  double v24; // xmm9_8
		  double v25; // xmm10_8
		  double v26; // xmm12_8
		  double v27; // xmm11_8
		  double v28; // xmm13_8
		  __int64 v29; // xmm6_8
		  int32_t v30; // r14d
		  float v31; // r15d
		  MethodInfo *v32; // r9
		  Vector3 *v33; // rax
		  float v34; // xmm4_4
		  int32_t v35; // eax
		  __m128 v36; // xmm4
		  float v37; // xmm6_4
		  double v38; // xmm1_8
		  double v39; // xmm8_8
		  double v40; // xmm9_8
		  double v41; // xmm10_8
		  double v42; // xmm12_8
		  double v43; // xmm11_8
		  double v44; // xmm13_8
		  float v45; // xmm14_4
		  __m128d v46; // xmm3
		  __m128 v47; // xmm15
		  float v48; // xmm6_4
		  MethodInfo *v49; // rdx
		  float v50; // xmm0_4
		  MethodInfo *v51; // rdx
		  Vector3 *up; // rax
		  __int64 v53; // xmm3_8
		  Vector3 *v54; // rax
		  float z; // eax
		  __int64 v56; // xmm0_8
		  float v57; // eax
		  Vector3 v59; // [rsp+38h] [rbp-D0h] BYREF
		  __int64 v60; // [rsp+48h] [rbp-C0h] BYREF
		  __int64 v61; // [rsp+50h] [rbp-B8h]
		  Vector3 v62; // [rsp+58h] [rbp-B0h] BYREF
		  Vector3 v63; // [rsp+68h] [rbp-A0h] BYREF
		  Vector3 v64; // [rsp+78h] [rbp-90h] BYREF
		  Vector3 v65; // [rsp+88h] [rbp-80h] BYREF
		  Vector3 v66[14]; // [rsp+98h] [rbp-70h] BYREF
		
		  *(_QWORD *)&v59.x = 0LL;
		  v59.z = 0.0;
		  v60 = 0LL;
		  LODWORD(v61) = 0;
		  v10 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(4101, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4101, 0LL);
		    if ( Patch )
		    {
		      z = origin->z;
		      *(_QWORD *)&v65.x = *(_QWORD *)&origin->x;
		      v65.z = z;
		      v54 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1448(v66, Patch, (Object *)vertsWS, &v65, 0LL);
		      goto LABEL_21;
		    }
		LABEL_19:
		    sub_1800D8260(v13, Patch);
		  }
		  Vector = UnityEngine::Animator::GetVector(&v65, v7, v8, v9);
		  v15 = *(_QWORD *)&Vector->x;
		  v16 = Vector->z;
		  v17 = 0;
		  if ( !vertsWS )
		    goto LABEL_19;
		  while ( v17 < vertsWS->fields._size )
		  {
		    System::Collections::Generic::List<Beyond::Gameplay::Core::DynamicScene::DynamicStreamingScene::LodRawInfo>::get_Item(
		      (DynamicStreamingScene_LodRawInfo *)&v62,
		      (List_1_Beyond_Gameplay_Core_DynamicScene_DynamicStreamingScene_LodRawInfo_ *)vertsWS,
		      v17,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Item);
		    v63 = v62;
		    *(_QWORD *)&v64.x = v15;
		    v64.z = v16;
		    v19 = UnityEngine::Vector3::op_Addition(&v65, &v64, &v63, v18);
		    ++v17;
		    v15 = *(_QWORD *)&v19->x;
		    v16 = v19->z;
		  }
		  size = vertsWS->fields._size;
		  if ( size < 1 )
		    size = 1;
		  v21 = 1.0;
		  v64.z = v16;
		  *(_QWORD *)&v64.x = v15;
		  v22 = UnityEngine::Vector3::op_Multiply(&v65, &v64, 1.0 / (float)size, v14);
		  v23 = 0.0;
		  v24 = 0.0;
		  v25 = 0.0;
		  v26 = 0.0;
		  v27 = 0.0;
		  v28 = 0.0;
		  v29 = *(_QWORD *)&v22->x;
		  v30 = 0;
		  v31 = v22->z;
		  while ( v30 < vertsWS->fields._size )
		  {
		    System::Collections::Generic::List<Beyond::Gameplay::Core::DynamicScene::DynamicStreamingScene::LodRawInfo>::get_Item(
		      (DynamicStreamingScene_LodRawInfo *)&v64,
		      (List_1_Beyond_Gameplay_Core_DynamicScene_DynamicStreamingScene_LodRawInfo_ *)vertsWS,
		      v30,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Item);
		    v62 = v64;
		    *(_QWORD *)&v63.x = v29;
		    v63.z = v31;
		    v33 = UnityEngine::Vector3::op_Subtraction(v66, &v62, &v63, v32);
		    ++v30;
		    v34 = v33->z;
		    *(_QWORD *)&v65.x = *(_QWORD *)&v33->x;
		    v23 = v23 + (float)(v65.x * v65.x);
		    v24 = v24 + (float)(v65.y * v65.x);
		    v25 = v25 + (float)(v34 * v65.x);
		    v26 = v26 + (float)(v65.y * v65.y);
		    v27 = v27 + (float)(v34 * v65.y);
		    v28 = v28 + (float)(v34 * v34);
		  }
		  v35 = vertsWS->fields._size;
		  if ( v35 < 1 )
		    v35 = 1;
		  v36 = 0LL;
		  v37 = 0.0;
		  v59.x = 1.0;
		  v38 = 1.0 / (double)v35;
		  v59.y = 0.0;
		  v39 = v23 * v38;
		  v40 = v24 * v38;
		  v41 = v25 * v38;
		  v42 = v26 * v38;
		  v43 = v27 * v38;
		  v44 = v28 * v38;
		  v59.z = 0.0;
		  do
		  {
		    v45 = v36.m128_f32[0] * v40 + v21 * v39 + v37 * v41;
		    v46 = _mm_cvtps_pd(v36);
		    *(float *)&v60 = v45;
		    v46.m128d_f64[0] = v46.m128d_f64[0] * v42 + v21 * v40 + v37 * v43;
		    v47 = _mm_cvtpd_ps(v46);
		    HIDWORD(v60) = v47.m128_i32[0];
		    v48 = v36.m128_f32[0] * v43 + v21 * v41 + v37 * v44;
		    *(float *)&v61 = v48;
		    v50 = sub_182F9FF00(&v60);
		    if ( v50 <= 0.0000000099999999 )
		      break;
		    v36 = v47;
		    v21 = v45 / v50;
		    v36.m128_f32[0] = v47.m128_f32[0] / v50;
		    v37 = v48 / v50;
		    ++v10;
		    v59.x = v45 / v50;
		    v59.y = v47.m128_f32[0] / v50;
		    v59.z = v37;
		  }
		  while ( v10 < 12 );
		  if ( UnityEngine::Vector3::get_sqrMagnitude(&v59, v49) < 1.0e-12 )
		  {
		    up = UnityEngine::Vector3::get_up(v66, v51);
		    v53 = *(_QWORD *)&up->x;
		    *(float *)&up = up->z;
		    *(_QWORD *)&v59.x = v53;
		    LODWORD(v59.z) = (_DWORD)up;
		  }
		  v54 = (Vector3 *)sub_182FAE2B0(v66, &v59);
		LABEL_21:
		  v56 = *(_QWORD *)&v54->x;
		  v57 = v54->z;
		  *(_QWORD *)&retstr->x = v56;
		  retstr->z = v57;
		  return retstr;
		}
		
		public static Matrix4x4 GetLocalMatrix(HGBoneCapsuleData container) => default; // 0x0000000189C1F974-0x0000000189C1FAB8
		// Matrix4x4 GetLocalMatrix(HGBoneCapsuleData)
		Matrix4x4 *HG::Rendering::Runtime::HGBoneCapsuleUtilities::GetLocalMatrix(
		        Matrix4x4 *__return_ptr retstr,
		        HGBoneCapsuleData *container,
		        MethodInfo *method)
		{
		  __int64 v5; // r8
		  __int64 v6; // r9
		  __int128 v7; // xmm6
		  MethodInfo *v8; // rax
		  Vector3 *one; // rax
		  Quaternion *v10; // rdx
		  Quaternion v11; // xmm0
		  float z; // ecx
		  __int64 v13; // xmm1_8
		  __m128i v14; // xmm6
		  Matrix4x4 *v15; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  __int128 v19; // xmm1
		  __int128 v20; // xmm1
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  Matrix4x4 *result; // rax
		  Vector3 v24; // [rsp+38h] [rbp-69h] BYREF
		  Vector3 v25; // [rsp+48h] [rbp-59h] BYREF
		  Quaternion v26; // [rsp+58h] [rbp-49h] BYREF
		  Matrix4x4 v27; // [rsp+68h] [rbp-39h] BYREF
		  Matrix4x4 v28; // [rsp+A8h] [rbp+7h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4102, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4102, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v18, v17);
		    v19 = *(_OWORD *)&container->localOffset.x;
		    *(_OWORD *)&v27.m00 = *(_OWORD *)&container->rootTransform;
		    *(_QWORD *)&v27.m02 = *(_QWORD *)&container->localRotation.y;
		    *(_OWORD *)&v27.m01 = v19;
		    v15 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1449(&v28, Patch, (HGBoneCapsuleData *)&v27, 0LL);
		  }
		  else
		  {
		    v7 = *(_OWORD *)&container->localOffset.x;
		    *(_OWORD *)&v27.m00 = *(_OWORD *)&container->rootTransform;
		    *(_QWORD *)&v27.m02 = *(_QWORD *)&container->localRotation.y;
		    *(_OWORD *)&v27.m01 = v7;
		    v24 = *(Vector3 *)&v27.m31;
		    v8 = (MethodInfo *)sub_182FA5910(&v26, &v24, v5, v6);
		    one = UnityEngine::Vector3::get_one(&v25, v8);
		    v11 = *v10;
		    z = one->z;
		    v13 = *(_QWORD *)&one->x;
		    *(_QWORD *)&v25.x = v7;
		    v14 = _mm_loadl_epi64((const __m128i *)&container->localOffset.z);
		    v24.z = z;
		    LODWORD(v25.z) = _mm_cvtsi128_si32(v14);
		    *(_QWORD *)&v24.x = v13;
		    v26 = v11;
		    v15 = UnityEngine::Matrix4x4::TRS(&v27, &v25, &v26, &v24, 0LL);
		  }
		  v20 = *(_OWORD *)&v15->m01;
		  *(_OWORD *)&retstr->m00 = *(_OWORD *)&v15->m00;
		  v21 = *(_OWORD *)&v15->m02;
		  *(_OWORD *)&retstr->m01 = v20;
		  v22 = *(_OWORD *)&v15->m03;
		  result = retstr;
		  *(_OWORD *)&retstr->m02 = v21;
		  *(_OWORD *)&retstr->m03 = v22;
		  return result;
		}
		
		public static Matrix4x4 GetCapsuleLocalToWorldMatrix(HGBoneCapsuleData container, Transform root) => default; // 0x0000000189C1F7A0-0x0000000189C1F974
		// Matrix4x4 GetCapsuleLocalToWorldMatrix(HGBoneCapsuleData, Transform)
		Matrix4x4 *HG::Rendering::Runtime::HGBoneCapsuleUtilities::GetCapsuleLocalToWorldMatrix(
		        Matrix4x4 *__return_ptr retstr,
		        HGBoneCapsuleData *container,
		        Transform *root,
		        MethodInfo *method)
		{
		  __int64 v7; // xmm1_8
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  __int64 v10; // xmm1_8
		  Matrix4x4 *localToWorldMatrix; // rax
		  __int128 v12; // xmm0
		  Matrix4x4 *LocalMatrix; // rax
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  __int128 v16; // xmm1
		  Matrix4x4 *v17; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v19; // xmm1
		  __int128 v20; // xmm1
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  Matrix4x4 *result; // rax
		  Matrix4x4 v24; // [rsp+38h] [rbp-D0h] BYREF
		  Matrix4x4 v25; // [rsp+78h] [rbp-90h]
		  Matrix4x4 v26; // [rsp+B8h] [rbp-50h] BYREF
		  Matrix4x4 v27; // [rsp+F8h] [rbp-10h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4103, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4103, 0LL);
		    if ( Patch )
		    {
		      v19 = *(_OWORD *)&container->localOffset.x;
		      *(_OWORD *)&v24.m00 = *(_OWORD *)&container->rootTransform;
		      *(_QWORD *)&v24.m02 = *(_QWORD *)&container->localRotation.y;
		      *(_OWORD *)&v24.m01 = v19;
		      v17 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1450(
		              &v27,
		              Patch,
		              (HGBoneCapsuleData *)&v24,
		              (Object *)root,
		              0LL);
		      goto LABEL_9;
		    }
		LABEL_7:
		    sub_1800D8260(v9, v8);
		  }
		  v7 = *(_QWORD *)&container->localRotation.y;
		  *(_OWORD *)&v24.m01 = *(_OWORD *)&container->localOffset.x;
		  *(_QWORD *)&v24.m02 = v7;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Inequality((Object_1 *)container->rootTransform, 0LL, 0LL) )
		  {
		    root = container->rootTransform;
		    v10 = *(_QWORD *)&container->localRotation.y;
		    *(_OWORD *)&v24.m01 = *(_OWORD *)&container->localOffset.x;
		    *(_QWORD *)&v24.m02 = v10;
		  }
		  if ( !root )
		    goto LABEL_7;
		  localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(&v26, root, 0LL);
		  v12 = *(_OWORD *)&localToWorldMatrix->m00;
		  *(_OWORD *)&v24.m01 = *(_OWORD *)&container->localOffset.x;
		  *(_OWORD *)&v25.m00 = v12;
		  *(_OWORD *)&v25.m01 = *(_OWORD *)&localToWorldMatrix->m01;
		  *(_OWORD *)&v25.m02 = *(_OWORD *)&localToWorldMatrix->m02;
		  *(_OWORD *)&v25.m03 = *(_OWORD *)&localToWorldMatrix->m03;
		  *(_OWORD *)&v24.m00 = *(_OWORD *)&container->rootTransform;
		  *(_QWORD *)&v24.m02 = *(_QWORD *)&container->localRotation.y;
		  LocalMatrix = HG::Rendering::Runtime::HGBoneCapsuleUtilities::GetLocalMatrix(&v26, (HGBoneCapsuleData *)&v24, 0LL);
		  v14 = *(_OWORD *)&LocalMatrix->m01;
		  *(_OWORD *)&v24.m00 = *(_OWORD *)&LocalMatrix->m00;
		  v15 = *(_OWORD *)&LocalMatrix->m02;
		  *(_OWORD *)&v24.m01 = v14;
		  v16 = *(_OWORD *)&LocalMatrix->m03;
		  *(_OWORD *)&v24.m02 = v15;
		  *(_OWORD *)&v24.m03 = v16;
		  v26 = v25;
		  v17 = UnityEngine::Matrix4x4::op_Multiply(&v27, &v26, &v24, 0LL);
		LABEL_9:
		  v20 = *(_OWORD *)&v17->m01;
		  *(_OWORD *)&retstr->m00 = *(_OWORD *)&v17->m00;
		  v21 = *(_OWORD *)&v17->m02;
		  *(_OWORD *)&retstr->m01 = v20;
		  v22 = *(_OWORD *)&v17->m03;
		  result = retstr;
		  *(_OWORD *)&retstr->m02 = v21;
		  *(_OWORD *)&retstr->m03 = v22;
		  return result;
		}
		
	}
}
