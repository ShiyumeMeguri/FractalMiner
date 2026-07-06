using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class HGBoneCapsuleUtilities
	{
		public HGBoneCapsuleUtilities()
		{
			// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			//         HGWindConfig *cSrc,
			//         HGWindConfig *cDst,
			//         float t,
			//         MethodInfo *method)
			// {
			//   ;
			// }
			// 
		}

		public static List<HGBoneCapsuleData> AutomateGenerateCapsuleSkeletonsNonHuman(GameObject root)
		{
			// // List`1[HG.Rendering.Runtime.HGBoneCapsuleData] AutomateGenerateCapsuleSkeletonsNonHuman(GameObject)
			// // Hidden C++ exception states: #wind=1
			// List_1_HG_Rendering_Runtime_HGBoneCapsuleData_ *HG::Rendering::Runtime::HGBoneCapsuleUtilities::AutomateGenerateCapsuleSkeletonsNonHuman(
			//         GameObject *root,
			//         MethodInfo *method)
			// {
			//   IList_1_Google_Protobuf_Reflection_FieldDescriptor_ *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   IList_1_Google_Protobuf_Reflection_FieldDescriptor_ *v6; // r13
			//   MethodInfo *v7; // rdx
			//   Vector3 *up; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   LOD__Array *LODs; // rax
			//   __int64 v14; // rdi
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v15; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   List_1_System_Object_ *v18; // r14
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   unsigned int i; // esi
			//   Object *v22; // r15
			//   Dictionary_2_System_Object_System_Object_ *v23; // rax
			//   __int64 v24; // rdx
			//   __int64 v25; // rcx
			//   Dictionary_2_System_Object_System_Object_ *v26; // rdi
			//   HashSet_1_System_Object_ *v27; // rax
			//   __int64 v28; // rdx
			//   __int64 v29; // rcx
			//   OneofDescriptor__Class *v30; // rsi
			//   OneofDescriptorProto *v31; // rdx
			//   FileDescriptor *v32; // r8
			//   MessageDescriptor *v33; // r9
			//   int32_t size; // r15d
			//   Dictionary_2_System_Object_System_Object_ *v35; // rax
			//   __int64 v36; // rdx
			//   __int64 v37; // rcx
			//   MonitorData *v38; // rsi
			//   OneofDescriptorProto *v39; // rdx
			//   FileDescriptor *v40; // r8
			//   MessageDescriptor *v41; // r9
			//   __int64 v42; // rdx
			//   __int64 v43; // rcx
			//   int32_t v44; // eax
			//   Object *Item; // rsi
			//   Mesh *sharedMesh; // r15
			//   __int64 v47; // rdx
			//   __int64 v48; // rcx
			//   Transform__Array *bones; // r13
			//   Matrix4x4__Array *bindposes; // rax
			//   __int64 v51; // r8
			//   __int64 v52; // r9
			//   Transform *transform; // rax
			//   __int64 v54; // rdx
			//   __int64 v55; // rcx
			//   Matrix4x4 *localToWorldMatrix; // rax
			//   __int64 v57; // rdx
			//   __int64 v58; // rcx
			//   __int128 v59; // xmm6
			//   __int128 v60; // xmm7
			//   __int128 v61; // xmm8
			//   __int128 v62; // xmm9
			//   int32_t v63; // r12d
			//   BoneWeight__Array *v64; // r14
			//   Matrix4x4 *v65; // rax
			//   Matrix4x4 *v66; // rax
			//   __int64 v67; // rdx
			//   __int64 v68; // rcx
			//   __int128 v69; // xmm11
			//   __int128 v70; // xmm12
			//   __int128 v71; // xmm13
			//   Vector3__Array *vertices; // r12
			//   BoneWeight__Array *BoneWeightsImpl; // rsi
			//   int32_t v74; // r15d
			//   Object *v75; // r14
			//   __int64 v76; // rax
			//   float m00; // xmm0_4
			//   __int64 v78; // rdx
			//   __int64 v79; // rcx
			//   List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *v80; // rax
			//   __int64 v81; // rdx
			//   __int64 v82; // rcx
			//   MessageDescriptor *v83; // rsi
			//   Vector3 *v84; // rax
			//   __int64 v85; // rdx
			//   __int64 v86; // rcx
			//   __int64 v87; // xmm6_8
			//   float z; // eax
			//   int32_t count; // eax
			//   int32_t v90; // esi
			//   List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *v91; // rax
			//   __int64 v92; // rdx
			//   __int64 v93; // rcx
			//   IList_1_Google_Protobuf_Reflection_FieldDescriptor_ *fields; // r13
			//   Object *key; // r12
			//   List_1_UnityEngine_Vector3_ *v96; // r15
			//   __int64 v97; // rdx
			//   __int64 v98; // rcx
			//   Vector3 *v99; // r8
			//   Vector3 *v100; // rcx
			//   Vector3 *v101; // rax
			//   __int64 v102; // xmm9_8
			//   Vector3 *v103; // rax
			//   __int64 v104; // xmm6_8
			//   float v105; // edi
			//   Object_1 *BuddyBone_0_0; // rsi
			//   Vector3 *v107; // rax
			//   float v108; // xmm2_4
			//   Vector3 *v109; // rax
			//   int32_t v110; // r14d
			//   struct List_1_System_Single___Class *element_class; // rdi
			//   __int64 v112; // rax
			//   __int64 v113; // rdx
			//   __int64 instance_size; // rcx
			//   List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *v115; // rsi
			//   __int64 v116; // rdx
			//   __int64 v117; // rcx
			//   int32_t v118; // r13d
			//   struct List_1_System_Single___Class *v119; // rdi
			//   __int64 v120; // rax
			//   __int64 v121; // rdx
			//   __int64 v122; // rcx
			//   List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *v123; // r14
			//   __int64 v124; // rdx
			//   __int64 v125; // rcx
			//   __int64 v126; // rdx
			//   __int64 v127; // rcx
			//   int32_t v128; // edi
			//   float v129; // xmm7_4
			//   __m128 y_low; // xmm15
			//   __m128 x_low; // xmm14
			//   float x; // r13d
			//   float v133; // xmm11_4
			//   float y; // xmm12_4
			//   float v135; // xmm13_4
			//   float v136; // xmm10_4
			//   float v137; // xmm6_4
			//   __m128 v138; // xmm8
			//   __m128 Index_k__BackingField; // xmm7
			//   float v140; // xmm6_4
			//   float v141; // xmm10_4
			//   float v142; // xmm8_4
			//   float v143; // xmm6_4
			//   __int64 v144; // rdx
			//   __int64 v145; // rcx
			//   float v146; // xmm7_4
			//   float v147; // xmm6_4
			//   float v148; // xmm8_4
			//   float v149; // xmm12_4
			//   float v150; // xmm13_4
			//   float v151; // xmm8_4
			//   Vector3 *position; // rax
			//   __int64 v153; // xmm8_8
			//   float v154; // edi
			//   Quaternion *rotation; // rax
			//   Vector3 *v156; // rax
			//   __int64 v157; // xmm10_8
			//   float v158; // edi
			//   __m128i v159; // xmm8
			//   Quaternion *v160; // rax
			//   MethodInfo *v161; // r9
			//   __int64 v162; // rax
			//   unsigned __int64 v163; // rdx
			//   signed __int64 v164; // rcx
			//   __int64 v165; // xmm2_8
			//   int v166; // r9d
			//   unsigned __int64 v167; // r8
			//   signed __int64 v168; // rtt
			//   char *v170; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v172; // rdx
			//   __int64 v173; // rcx
			//   String__Array *v174; // [rsp+20h] [rbp-538h]
			//   String__Array *v175; // [rsp+20h] [rbp-538h]
			//   String *v176; // [rsp+28h] [rbp-530h]
			//   String *v177; // [rsp+28h] [rbp-530h]
			//   Vector3 v178; // [rsp+30h] [rbp-528h] BYREF
			//   Quaternion v179; // [rsp+40h] [rbp-518h] BYREF
			//   Vector3 v180; // [rsp+50h] [rbp-508h] BYREF
			//   BoneWeight__Array *v181; // [rsp+60h] [rbp-4F8h] BYREF
			//   OneofDescriptor param_000471c7; // [rsp+68h] [rbp-4F0h] BYREF
			//   int File_k__BackingField; // [rsp+B8h] [rbp-4A0h]
			//   _BYTE v184[40]; // [rsp+C0h] [rbp-498h] BYREF
			//   Object *component; // [rsp+E8h] [rbp-470h] BYREF
			//   Object *v186; // [rsp+F0h] [rbp-468h] BYREF
			//   Dictionary_2_System_Object_System_Object_ *v187; // [rsp+F8h] [rbp-460h] BYREF
			//   Matrix4x4 v188; // [rsp+100h] [rbp-458h] BYREF
			//   Vector3 v189; // [rsp+140h] [rbp-418h] BYREF
			//   Vector3 v190; // [rsp+150h] [rbp-408h] BYREF
			//   Vector3 v191; // [rsp+160h] [rbp-3F8h] BYREF
			//   __int64 v192; // [rsp+170h] [rbp-3E8h]
			//   __int64 v193; // [rsp+180h] [rbp-3D8h]
			//   __int64 v194; // [rsp+190h] [rbp-3C8h] BYREF
			//   float v195; // [rsp+198h] [rbp-3C0h]
			//   Vector3 v196; // [rsp+1A0h] [rbp-3B8h] BYREF
			//   unsigned __int64 v197; // [rsp+1B0h] [rbp-3A8h] BYREF
			//   float v198; // [rsp+1B8h] [rbp-3A0h]
			//   Vector3 v199; // [rsp+1C0h] [rbp-398h] BYREF
			//   Vector3 v200; // [rsp+1D0h] [rbp-388h] BYREF
			//   Vector3 v201; // [rsp+1E0h] [rbp-378h] BYREF
			//   Vector3 v202; // [rsp+1F0h] [rbp-368h] BYREF
			//   Il2CppException *ex; // [rsp+200h] [rbp-358h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *v204; // [rsp+208h] [rbp-350h]
			//   __int64 v205; // [rsp+210h] [rbp-348h]
			//   List_1_HG_Rendering_Runtime_HGBoneCapsuleData_ *v206; // [rsp+218h] [rbp-340h]
			//   __m128i v207; // [rsp+220h] [rbp-338h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v208; // [rsp+230h] [rbp-328h] BYREF
			//   Matrix4x4 v209; // [rsp+260h] [rbp-2F8h] BYREF
			//   Matrix4x4 v210; // [rsp+2A0h] [rbp-2B8h] BYREF
			//   Matrix4x4 bindW; // [rsp+2E0h] [rbp-278h] BYREF
			//   char v212; // [rsp+320h] [rbp-238h] BYREF
			//   Il2CppExceptionWrapper *v213; // [rsp+328h] [rbp-230h] BYREF
			//   char v214; // [rsp+330h] [rbp-228h] BYREF
			//   char v215[16]; // [rsp+340h] [rbp-218h] BYREF
			//   Vector3 v216; // [rsp+350h] [rbp-208h] BYREF
			//   Vector3 v217; // [rsp+360h] [rbp-1F8h] BYREF
			//   Vector3 v218; // [rsp+370h] [rbp-1E8h] BYREF
			//   char v219[16]; // [rsp+380h] [rbp-1D8h] BYREF
			//   Vector3 v220; // [rsp+390h] [rbp-1C8h] BYREF
			//   char v221; // [rsp+3A0h] [rbp-1B8h] BYREF
			//   Vector3 v222; // [rsp+3B0h] [rbp-1A8h] BYREF
			//   Vector3 v223; // [rsp+3C0h] [rbp-198h] BYREF
			//   Quaternion v224; // [rsp+3D0h] [rbp-188h] BYREF
			//   Quaternion v225; // [rsp+3E0h] [rbp-178h] BYREF
			//   Quaternion v226; // [rsp+3F0h] [rbp-168h] BYREF
			//   Quaternion v227; // [rsp+400h] [rbp-158h] BYREF
			//   Matrix4x4 v228; // [rsp+410h] [rbp-148h] BYREF
			//   Matrix4x4 v229[3]; // [rsp+450h] [rbp-108h] BYREF
			//   int v230; // [rsp+570h] [rbp+18h]
			//   bool BoneBindWorldMatrix_0_1; // [rsp+570h] [rbp+18h]
			//   Object *value; // [rsp+578h] [rbp+20h]
			//   float valuea; // [rsp+578h] [rbp+20h]
			//   float valueb; // [rsp+578h] [rbp+20h]
			// 
			//   if ( !byte_18D919753 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Debug);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Transform,System::Collections::Generic::List<UnityEngine::Vector3>>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Transform,System::Collections::Generic::List<UnityEngine::Vector3>>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Transform,System::Collections::Generic::List<UnityEngine::Vector3>>::TryGetValue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Transform,System::Collections::Generic::List<UnityEngine::Vector3>>::Dictionary);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::SkinnedMeshRenderer,UnityEngine::Matrix4x4 []>::Dictionary);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Transform,System::Collections::Generic::List<UnityEngine::Vector3>>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::SkinnedMeshRenderer,UnityEngine::Matrix4x4 []>::set_Item);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<UnityEngine::SkinnedMeshRenderer,UnityEngine::Matrix4x4 []>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<UnityEngine::Transform,System::Collections::Generic::List<UnityEngine::Vector3>>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Transform,System::Collections::Generic::List<UnityEngine::Vector3>>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Transform,System::Collections::Generic::List<UnityEngine::Vector3>>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Transform,System::Collections::Generic::List<UnityEngine::Vector3>>::get_Current);
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::TryGetComponent<UnityEngine::LODGroup>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Transform>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Transform>::HashSet);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::HashSet<UnityEngine::Transform>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<UnityEngine::Transform,System::Collections::Generic::List<UnityEngine::Vector3>>::get_Key);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<UnityEngine::Transform,System::Collections::Generic::List<UnityEngine::Vector3>>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::SkinnedMeshRenderer>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<float>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGBoneCapsuleData>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGBoneCapsuleData>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::SkinnedMeshRenderer>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<float>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<float>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::SkinnedMeshRenderer>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::SkinnedMeshRenderer>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Item);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGBoneCapsuleData>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<UnityEngine::SkinnedMeshRenderer>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<float>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<UnityEngine::Vector3>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Matrix4x4);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::SkinnedMeshRenderer);
			//     sub_18003C530(&off_18D517FE8);
			//     sub_18003C530(&off_18D517FF0);
			//     sub_18003C530(&off_18D518000);
			//     sub_18003C530(&off_18D518068);
			//     sub_18003C530(&off_18D518070);
			//     byte_18D919753 = 1;
			//   }
			//   *(_OWORD *)&param_000471c7.klass = 0LL;
			//   component = 0LL;
			//   param_000471c7.fields.containingType = 0LL;
			//   memset(&v208, 0, sizeof(v208));
			//   sub_1802F01E0(&bindW, 0LL, 64LL);
			//   sub_1802F01E0(&v228, 0LL, 64LL);
			//   param_000471c7.fields.accessor = 0LL;
			//   LODWORD(param_000471c7.fields._Proto_k__BackingField) = 0;
			//   memset(v184, 0, sizeof(v184));
			//   if ( IFix::WrappersManagerImpl::IsPatched(3468, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3468, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v173, v172);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1238(Patch, (Object *)root, 0LL);
			//   }
			//   v3 = (IList_1_Google_Protobuf_Reflection_FieldDescriptor_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGBoneCapsuleData>);
			//   v6 = v3;
			//   param_000471c7.fields.fields = v3;
			//   if ( !v3 )
			//     sub_180B536AC(v5, v4);
			//   System::Collections::Generic::List<Cinemachine::TargetPositionCache_CacheEntry::RecordingItem>::List(
			//     (List_1_Cinemachine_TargetPositionCache_CacheEntry_RecordingItem_ *)v3,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGBoneCapsuleData>::List);
			//   v206 = (List_1_HG_Rendering_Runtime_HGBoneCapsuleData_ *)v6;
			//   up = UnityEngine::Vector3::get_up((Vector3 *)&param_000471c7.fields._IsSynthetic_k__BackingField, v7);
			//   v205 = *(_QWORD *)&up.x;
			//   *(float *)&param_000471c7.fields._._File_k__BackingField = up.z;
			//   if ( !root )
			//     sub_180B536AC(v10, v9);
			//   if ( !UnityEngine::GameObject::TryGetComponent<System::Object>(
			//           root,
			//           &component,
			//           MethodInfo::UnityEngine::GameObject::TryGetComponent<UnityEngine::LODGroup>) )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Debug);
			//     v170 = "未找到 LODGroup。";
			//     goto LABEL_141;
			//   }
			//   if ( !component )
			//     sub_180B536AC(v12, v11);
			//   LODs = UnityEngine::LODGroup::GetLODs((LODGroup *)component, 0, 0LL);
			//   if ( !LODs || !LODs.max_length.value )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Debug);
			//     v170 = "LODGroup 中没有 LOD。";
			//     goto LABEL_141;
			//   }
			//   v14 = *(_QWORD *)(sub_18003EB40(LODs, 0LL) + 8);
			//   if ( !v14 || !*(_QWORD *)(v14 + 24) )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Debug);
			//     v170 = "LOD0 中没有 renderer。";
			//     goto LABEL_141;
			//   }
			//   v15 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<UnityEngine::SkinnedMeshRenderer>);
			//   v18 = (List_1_System_Object_ *)v15;
			//   *(_QWORD *)&v179.x = v15;
			//   if ( !v15 )
			//     sub_180B536AC(v17, v16);
			//   System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//     v15,
			//     *(_DWORD *)(v14 + 24),
			//     MethodInfo::System::Collections::Generic::List<UnityEngine::SkinnedMeshRenderer>::List);
			//   for ( i = 0; (signed int)i < *(_DWORD *)(v14 + 24); ++i )
			//   {
			//     if ( i >= *(_DWORD *)(v14 + 24) )
			//       sub_180070270(v20, v19);
			//     v22 = (Object *)sub_18003F5A0(*(_QWORD *)(v14 + 8LL * (int)i + 32), TypeInfo::UnityEngine::SkinnedMeshRenderer);
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Inequality((Object_1 *)v22, 0LL, 0LL) )
			//     {
			//       if ( !v18 )
			//         sub_180B536AC(v20, v19);
			//       sub_1822AD140(v18, v22);
			//     }
			//   }
			//   if ( !v18 )
			//     sub_180B536AC(v20, v19);
			//   if ( !v18.fields._size )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Debug);
			//     v170 = "LOD0 中没有 SkinnedMeshRenderer。";
			//     goto LABEL_141;
			//   }
			//   v23 = (Dictionary_2_System_Object_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<UnityEngine::Transform,System::Collections::Generic::List<UnityEngine::Vector3>>);
			//   v26 = v23;
			//   v187 = v23;
			//   if ( !v23 )
			//     sub_180B536AC(v25, v24);
			//   System::Collections::Generic::Dictionary<System::Object,System::Object>::Dictionary(
			//     v23,
			//     256,
			//     MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Transform,System::Collections::Generic::List<UnityEngine::Vector3>>::Dictionary);
			//   v27 = (HashSet_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::HashSet<UnityEngine::Transform>);
			//   v30 = (OneofDescriptor__Class *)v27;
			//   if ( !v27 )
			//     sub_180B536AC(v29, v28);
			//   System::Collections::Generic::HashSet<System::Object>::HashSet(
			//     v27,
			//     512,
			//     MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Transform>::HashSet);
			//   param_000471c7.klass = v30;
			//   sub_1800054D0(&param_000471c7, v31, v32, v33, v174, v176, *(MethodInfo **)&v178.x);
			//   size = v18.fields._size;
			//   v35 = (Dictionary_2_System_Object_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<UnityEngine::SkinnedMeshRenderer,UnityEngine::Matrix4x4 []>);
			//   v38 = (MonitorData *)v35;
			//   if ( !v35 )
			//     sub_180B536AC(v37, v36);
			//   System::Collections::Generic::Dictionary<System::Object,System::Object>::Dictionary(
			//     v35,
			//     size,
			//     MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::SkinnedMeshRenderer,UnityEngine::Matrix4x4 []>::Dictionary);
			//   param_000471c7.monitor = v38;
			//   sub_1800054D0((OneofDescriptor *)&param_000471c7.monitor, v39, v40, v41, v175, v177, *(MethodInfo **)&v178.x);
			//   v44 = 0;
			//   v230 = 0;
			//   while ( v44 < v18.fields._size )
			//   {
			//     Item = System::Collections::Generic::List<System::Object>::get_Item(
			//              v18,
			//              v44,
			//              MethodInfo::System::Collections::Generic::List<UnityEngine::SkinnedMeshRenderer>::get_Item);
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( !UnityEngine::Object::op_Equality((Object_1 *)Item, 0LL, 0LL) )
			//     {
			//       if ( !Item )
			//         sub_180B536AC(v43, v42);
			//       sharedMesh = UnityEngine::SkinnedMeshRenderer::get_sharedMesh((SkinnedMeshRenderer *)Item, 0LL);
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       if ( !UnityEngine::Object::op_Equality((Object_1 *)sharedMesh, 0LL, 0LL) )
			//       {
			//         bones = UnityEngine::SkinnedMeshRenderer::get_bones((SkinnedMeshRenderer *)Item, 0LL);
			//         if ( !sharedMesh )
			//           sub_180B536AC(v48, v47);
			//         bindposes = UnityEngine::Mesh::get_bindposes(sharedMesh, 0LL);
			//         v181 = (BoneWeight__Array *)bindposes;
			//         if ( bones )
			//         {
			//           if ( bones.max_length.value )
			//           {
			//             if ( bindposes )
			//             {
			//               v43 = (unsigned int)bones.max_length.size;
			//               if ( bindposes.max_length.size == (_DWORD)v43 )
			//               {
			//                 value = (Object *)il2cpp_array_new_specific_0(
			//                                     TypeInfo::UnityEngine::Matrix4x4,
			//                                     (unsigned int)v43,
			//                                     v51,
			//                                     v52);
			//                 transform = UnityEngine::Component::get_transform((Component *)Item, 0LL);
			//                 if ( !transform )
			//                   sub_180B536AC(v55, v54);
			//                 localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(&v209, transform, 0LL);
			//                 v59 = *(_OWORD *)&localToWorldMatrix.m00;
			//                 *(_OWORD *)&v210.m00 = *(_OWORD *)&localToWorldMatrix.m00;
			//                 v60 = *(_OWORD *)&localToWorldMatrix.m01;
			//                 *(_OWORD *)&v210.m01 = v60;
			//                 v61 = *(_OWORD *)&localToWorldMatrix.m02;
			//                 *(_OWORD *)&v210.m02 = v61;
			//                 v62 = *(_OWORD *)&localToWorldMatrix.m03;
			//                 *(_OWORD *)&v210.m03 = v62;
			//                 v63 = 0;
			//                 v64 = v181;
			//                 while ( v63 < bones.max_length.size )
			//                 {
			//                   v65 = (Matrix4x4 *)sub_1804440E4(v64, v63);
			//                   v209 = *UnityEngine::Matrix4x4::get_inverse(&v188, v65, 0LL);
			//                   *(_OWORD *)&v188.m00 = v59;
			//                   *(_OWORD *)&v188.m01 = v60;
			//                   *(_OWORD *)&v188.m02 = v61;
			//                   *(_OWORD *)&v188.m03 = v62;
			//                   v66 = UnityEngine::Matrix4x4::op_Multiply(v229, &v188, &v209, 0LL);
			//                   v69 = *(_OWORD *)&v66.m01;
			//                   v70 = *(_OWORD *)&v66.m02;
			//                   v71 = *(_OWORD *)&v66.m03;
			//                   if ( !value )
			//                     sub_180B536AC(v68, v67);
			//                   *(_OWORD *)&v209.m00 = *(_OWORD *)&v66.m00;
			//                   *(_OWORD *)&v209.m01 = v69;
			//                   *(_OWORD *)&v209.m02 = v70;
			//                   *(_OWORD *)&v209.m03 = v71;
			//                   sub_180077420(value, v63++, &v209);
			//                 }
			//                 v26 = v187;
			//                 if ( !param_000471c7.monitor )
			//                   sub_180B536AC(v58, v57);
			//                 System::Collections::Generic::Dictionary<System::Object,System::Object>::set_Item(
			//                   (Dictionary_2_System_Object_System_Object_ *)param_000471c7.monitor,
			//                   Item,
			//                   value,
			//                   MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::SkinnedMeshRenderer,UnityEngine::Matrix4x4 []>::set_Item);
			//                 vertices = UnityEngine::Mesh::get_vertices(sharedMesh, 0LL);
			//                 BoneWeightsImpl = UnityEngine::Mesh::GetBoneWeightsImpl(sharedMesh, 0LL);
			//                 v181 = BoneWeightsImpl;
			//                 v74 = 0;
			//                 v75 = v186;
			//                 while ( 1 )
			//                 {
			//                   if ( !vertices )
			//                     sub_180B536AC(v43, v42);
			//                   if ( v74 >= vertices.max_length.size )
			//                     break;
			//                   if ( !BoneWeightsImpl )
			//                     sub_180B536AC(v43, v42);
			//                   sub_18041FE3C(BoneWeightsImpl, &v188, v74);
			//                   *(float *)&v76 = v188.m01;
			//                   m00 = v188.m00;
			//                   if ( v188.m10 > v188.m00 )
			//                   {
			//                     v76 = HIDWORD(*(_QWORD *)&v188.m01);
			//                     m00 = v188.m10;
			//                   }
			//                   v43 = *(_QWORD *)&v188.m21;
			//                   if ( v188.m20 > m00 )
			//                   {
			//                     *(float *)&v76 = v188.m21;
			//                     m00 = v188.m20;
			//                   }
			//                   if ( v188.m30 > m00 )
			//                   {
			//                     v43 = HIDWORD(*(_QWORD *)&v188.m21);
			//                     *(float *)&v76 = v188.m31;
			//                     m00 = v188.m30;
			//                   }
			//                   if ( (int)v76 >= 0 && (int)v76 < bones.max_length.size && m00 >= 0.5 )
			//                   {
			//                     if ( (unsigned int)v76 >= bones.max_length.size )
			//                       sub_180070270(v43, v42);
			//                     v75 = (Object *)bones.vector[(int)v76];
			//                     sub_180002C70(TypeInfo::UnityEngine::Object);
			//                     if ( !UnityEngine::Object::op_Equality((Object_1 *)v75, 0LL, 0LL) )
			//                     {
			//                       if ( !param_000471c7.klass )
			//                         sub_180B536AC(v43, v42);
			//                       System::Collections::Generic::HashSet<System::Object>::Add(
			//                         (HashSet_1_System_Object_ *)param_000471c7.klass,
			//                         v75,
			//                         MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Transform>::Add);
			//                       if ( !v26 )
			//                         sub_180B536AC(v79, v78);
			//                       if ( !System::Collections::Generic::Dictionary<System::Object,System::Object>::TryGetValue(
			//                               v26,
			//                               v75,
			//                               (Object **)&param_000471c7.fields.containingType,
			//                               MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Transform,System::Collections::Generic::List<UnityEngine::Vector3>>::TryGetValue) )
			//                       {
			//                         v80 = (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector3>);
			//                         v83 = (MessageDescriptor *)v80;
			//                         if ( !v80 )
			//                           sub_180B536AC(v82, v81);
			//                         System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::List(
			//                           v80,
			//                           256,
			//                           MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::List);
			//                         param_000471c7.fields.containingType = v83;
			//                         System::Collections::Generic::Dictionary<System::Object,System::Object>::Add(
			//                           v26,
			//                           v75,
			//                           (Object *)v83,
			//                           MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Transform,System::Collections::Generic::List<UnityEngine::Vector3>>::Add);
			//                       }
			//                       sub_180040F70(vertices, &param_000471c7.fields, v74);
			//                       *(_QWORD *)&v180.x = *(_QWORD *)&param_000471c7.fields._._Index_k__BackingField;
			//                       v180.z = *(float *)&param_000471c7.fields._._FullName_k__BackingField;
			//                       v84 = UnityEngine::Matrix4x4::MultiplyPoint3x4(
			//                               (Vector3 *)&param_000471c7.fields._IsSynthetic_k__BackingField,
			//                               &v210,
			//                               &v180,
			//                               0LL);
			//                       v87 = *(_QWORD *)&v84.x;
			//                       z = v84.z;
			//                       if ( !param_000471c7.fields.containingType )
			//                         sub_180B536AC(v86, v85);
			//                       *(_QWORD *)&v178.x = v87;
			//                       v178.z = z;
			//                       sub_180315038(
			//                         param_000471c7.fields.containingType,
			//                         &v178,
			//                         MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add);
			//                       BoneWeightsImpl = v181;
			//                     }
			//                   }
			//                   ++v74;
			//                 }
			//                 v186 = v75;
			//                 v18 = *(List_1_System_Object_ **)&v179.x;
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			//     v44 = ++v230;
			//   }
			//   if ( !v26 )
			//     sub_180B536AC(v43, v42);
			//   count = v26.fields._count;
			//   if ( count == v26.fields._freeCount )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Debug);
			//     v170 = "没有满足阈值的主导顶点，检查权重或阈值。";
			// LABEL_141:
			//     UnityEngine::Debug::LogWarning((Object *)v170, 0LL);
			//     return 0LL;
			//   }
			//   v90 = count - v26.fields._freeCount;
			//   v91 = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>);
			//   if ( !v91 )
			//     sub_180B536AC(v93, v92);
			//   System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::List(
			//     v91,
			//     v90,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::List);
			//   System::Collections::Generic::Dictionary<System::Object,System::Object>::GetEnumerator(
			//     (Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *)&v188,
			//     v26,
			//     MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Transform,System::Collections::Generic::List<UnityEngine::Vector3>>::GetEnumerator);
			//   *(_OWORD *)&v208._dictionary = *(_OWORD *)&v188.m00;
			//   v208._current = *(KeyValuePair_2_System_Object_System_Object_ *)&v188.m01;
			//   *(_QWORD *)&v208._getEnumeratorRetType = *(_QWORD *)&v188.m02;
			//   ex = 0LL;
			//   v204 = &v208;
			//   try
			//   {
			// LABEL_70:
			//     fields = param_000471c7.fields.fields;
			//     while ( 1 )
			//     {
			//       do
			//       {
			//         if ( !System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,System::Object>::MoveNext(
			//                 &v208,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Transform,System::Collections::Generic::List<UnityEngine::Vector3>>::MoveNext) )
			//           return (List_1_HG_Rendering_Runtime_HGBoneCapsuleData_ *)fields;
			//         key = v208._current.key;
			//         v96 = (List_1_UnityEngine_Vector3_ *)v208._current.value;
			//       }
			//       while ( !v208._current.value || SLODWORD(v208._current.value[1].monitor) < 8 );
			//       BoneBindWorldMatrix_0_1 = HG::Rendering::Runtime::HGBoneCapsuleUtilities::_AutomateGenerateCapsuleSkeletonsNonHuman_g__TryGetBoneBindWorldMatrix_0_1(
			//                                   (Transform *)v208._current.key,
			//                                   &bindW,
			//                                   (HGBoneCapsuleUtilities_c_DisplayClass0_0 *)&param_000471c7,
			//                                   0LL);
			//       if ( BoneBindWorldMatrix_0_1 )
			//       {
			//         *(_QWORD *)&v190.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//         v190.z = 0.0;
			//         v103 = UnityEngine::Matrix4x4::MultiplyPoint3x4(&v222, &bindW, &v190, 0LL);
			//         v104 = *(_QWORD *)&v103.x;
			//         v193 = *(_QWORD *)&v103.x;
			//         v105 = v103.z;
			//         BuddyBone_0_0 = (Object_1 *)HG::Rendering::Runtime::HGBoneCapsuleUtilities::_AutomateGenerateCapsuleSkeletonsNonHuman_g__FindBuddyBone_0_0(
			//                                       (Transform *)key,
			//                                       (HGBoneCapsuleUtilities_c_DisplayClass0_0 *)&param_000471c7,
			//                                       0LL);
			//         sub_180002C70(TypeInfo::UnityEngine::Object);
			//         if ( !UnityEngine::Object::op_Inequality(BuddyBone_0_0, 0LL, 0LL)
			//           || !HG::Rendering::Runtime::HGBoneCapsuleUtilities::_AutomateGenerateCapsuleSkeletonsNonHuman_g__TryGetBoneBindWorldMatrix_0_1(
			//                 (Transform *)BuddyBone_0_0,
			//                 &v228,
			//                 (HGBoneCapsuleUtilities_c_DisplayClass0_0 *)&param_000471c7,
			//                 0LL) )
			//         {
			//           *(_QWORD *)&v178.x = v104;
			//           v178.z = v105;
			//           *(_QWORD *)&v196.x = v104;
			//           v196.z = v105;
			//           v109 = HG::Rendering::Runtime::HGBoneCapsuleUtilities::ComputePCAFirstAxis(&v216, v96, &v196, 0LL);
			//           v102 = *(_QWORD *)&v109.x;
			//           v179.x = v109.z;
			//           goto LABEL_85;
			//         }
			//         *(_QWORD *)&v191.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//         v191.z = 0.0;
			//         v107 = UnityEngine::Matrix4x4::MultiplyPoint3x4(&v223, &v228, &v191, 0LL);
			//         v192 = *(_QWORD *)&v107.x;
			//         v108 = v107.z;
			//         *(float *)&param_000471c7.fields.accessor = *(float *)&v192 - *(float *)&v193;
			//         *((float *)&param_000471c7.fields.accessor + 1) = *((float *)&v192 + 1) - *((float *)&v193 + 1);
			//         *(float *)&param_000471c7.fields._Proto_k__BackingField = v108 - v105;
			//         *(_QWORD *)&v178.x = v104;
			//         v178.z = v105;
			//         if ( (float)((float)(*(float *)&param_000471c7.fields._Proto_k__BackingField
			//                            * *(float *)&param_000471c7.fields._Proto_k__BackingField)
			//                    + (float)((float)(*((float *)&param_000471c7.fields.accessor + 1)
			//                                    * *((float *)&param_000471c7.fields.accessor + 1))
			//                            + (float)(*(float *)&param_000471c7.fields.accessor
			//                                    * *(float *)&param_000471c7.fields.accessor))) > 1.0e-10 )
			//         {
			//           v101 = (Vector3 *)sub_182413270(v215, &param_000471c7.fields.accessor);
			//           goto LABEL_78;
			//         }
			//         v194 = v104;
			//         v195 = v105;
			//         v99 = (Vector3 *)&v194;
			//         v100 = (Vector3 *)&v214;
			//       }
			//       else
			//       {
			//         if ( !key )
			//           sub_1802DC2C8(v98, v97);
			//         v178 = *UnityEngine::Transform::get_position(&v220, (Transform *)key, 0LL);
			//         v189 = v178;
			//         v99 = &v189;
			//         v100 = (Vector3 *)&v221;
			//       }
			//       v101 = HG::Rendering::Runtime::HGBoneCapsuleUtilities::ComputePCAFirstAxis(v100, v96, v99, 0LL);
			// LABEL_78:
			//       v102 = *(_QWORD *)&v101.x;
			//       v179.x = v101.z;
			// LABEL_85:
			//       *(_QWORD *)&v180.x = v102;
			//       v110 = v96.fields._size;
			//       element_class = TypeInfo::System::Collections::Generic::List<float>;
			//       sub_180004450(TypeInfo::System::Collections::Generic::List<float>);
			//       if ( element_class._0.generic_class && ((__int64)element_class.vtable.Equals.methodPtr & 8) != 0 )
			//         element_class = (struct List_1_System_Single___Class *)element_class._0.element_class;
			//       if ( ((__int64)element_class.vtable.Equals.methodPtr & 0x20) == 0 )
			//       {
			//         v112 = sub_180005FB0(element_class);
			// LABEL_92:
			//         v115 = (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)v112;
			//         goto LABEL_94;
			//       }
			//       instance_size = element_class._1.instance_size;
			//       if ( element_class._0.gc_desc )
			//       {
			//         v112 = sub_180004F80(instance_size, element_class);
			//         goto LABEL_92;
			//       }
			//       v115 = (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)sub_180005D40(instance_size, element_class);
			// LABEL_94:
			//       if ( (BYTE1(element_class.vtable.Equals.methodPtr) & 2) != 0 )
			//         sub_18002E8C0((_DWORD)v115, (unsigned int)sub_18007DC30, 0, (unsigned int)&v187, (__int64)&v186);
			//       if ( (dword_18D8F6F50 & 0x80u) != 0 )
			//         sub_1802DAEC4(v115, element_class);
			//       il2cpp_runtime_class_init_0(element_class, v113);
			//       if ( !v115 )
			//         sub_1802DC2C8(v117, v116);
			//       System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::List(
			//         v115,
			//         v110,
			//         MethodInfo::System::Collections::Generic::List<float>::List);
			//       v118 = v96.fields._size;
			//       v119 = TypeInfo::System::Collections::Generic::List<float>;
			//       sub_180004450(TypeInfo::System::Collections::Generic::List<float>);
			//       if ( v119._0.generic_class && ((__int64)v119.vtable.Equals.methodPtr & 8) != 0 )
			//         v119 = (struct List_1_System_Single___Class *)v119._0.element_class;
			//       if ( ((__int64)v119.vtable.Equals.methodPtr & 0x20) == 0 )
			//       {
			//         v120 = sub_180005FB0(v119);
			// LABEL_106:
			//         v123 = (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)v120;
			//         goto LABEL_108;
			//       }
			//       v122 = v119._1.instance_size;
			//       if ( v119._0.gc_desc )
			//       {
			//         v120 = sub_180004F80(v122, v119);
			//         goto LABEL_106;
			//       }
			//       v123 = (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)sub_180005D40(v122, v119);
			// LABEL_108:
			//       if ( (BYTE1(v119.vtable.Equals.methodPtr) & 2) != 0 )
			//         sub_18002E8C0((_DWORD)v123, (unsigned int)sub_18007DC30, 0, (unsigned int)&v212, (__int64)&v181);
			//       if ( (dword_18D8F6F50 & 0x80u) != 0 )
			//         sub_1802DAEC4(v123, v119);
			//       il2cpp_runtime_class_init_0(v119, v121);
			//       if ( !v123 )
			//         sub_1802DC2C8(v125, v124);
			//       System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::List(
			//         v123,
			//         v118,
			//         MethodInfo::System::Collections::Generic::List<float>::List);
			//       v128 = 0;
			//       if ( !v96 )
			//         sub_1802DC2C8(v127, v126);
			//       v129 = v178.z;
			//       valuea = v178.z;
			//       y_low = (__m128)LODWORD(v178.y);
			//       x_low = (__m128)LODWORD(v178.x);
			//       x = v179.x;
			//       v133 = v179.x;
			//       y = v180.y;
			//       v135 = v180.x;
			//       while ( v128 < v96.fields._size )
			//       {
			//         System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::BuildingTypeEntry>::get_Item(
			//           (RemoteFactoryUtil_FillBuildingCheckResultIterationContext_BuildingTypeEntry *)&param_000471c7.fields,
			//           (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_BuildingTypeEntry_ *)v96,
			//           v128,
			//           MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Item);
			//         v136 = *(float *)&param_000471c7.fields._._FullName_k__BackingField;
			//         v137 = *(float *)&param_000471c7.fields._._FullName_k__BackingField - v129;
			//         v138 = (__m128)*((unsigned int *)&param_000471c7.fields._._Index_k__BackingField + 1);
			//         Index_k__BackingField = (__m128)(unsigned int)param_000471c7.fields._._Index_k__BackingField;
			//         v140 = (float)(v137 * v133)
			//              + (float)((float)((float)(*((float *)&param_000471c7.fields._._Index_k__BackingField + 1)
			//                                      - y_low.m128_f32[0])
			//                              * y)
			//                      + (float)(v135
			//                              * (float)(*(float *)&param_000471c7.fields._._Index_k__BackingField - x_low.m128_f32[0])));
			//         sub_1824B31B0((List_1_System_Single_ *)v115);
			//         v138.m128_f32[0] = v138.m128_f32[0] - (float)(y_low.m128_f32[0] + (float)(y * v140));
			//         Index_k__BackingField.m128_f32[0] = Index_k__BackingField.m128_f32[0]
			//                                           - (float)(x_low.m128_f32[0] + (float)(v135 * v140));
			//         v197 = _mm_unpacklo_ps(Index_k__BackingField, v138).m128_u64[0];
			//         v198 = v136 - (float)(valuea + (float)(v133 * v140));
			//         sub_18238EFA0(&v197);
			//         sub_1824B31B0((List_1_System_Single_ *)v123);
			//         ++v128;
			//         v129 = valuea;
			//       }
			//       if ( !v115.fields._size )
			//         goto LABEL_70;
			//       v141 = HG::Rendering::Runtime::HGBoneCapsuleUtilities::Quantile((List_1_System_Single_ *)v115, 0.050000001, 0LL);
			//       v142 = HG::Rendering::Runtime::HGBoneCapsuleUtilities::Quantile((List_1_System_Single_ *)v115, 0.94999999, 0LL);
			//       v143 = HG::Rendering::Runtime::HGBoneCapsuleUtilities::Quantile((List_1_System_Single_ *)v123, 0.89999998, 0LL);
			//       v146 = HG::Rendering::Runtime::HGBoneCapsuleUtilities::GetPaddingByScale((Transform *)key, 0LL) + v143;
			//       if ( v146 <= 0.000099999997 )
			//         v146 = 0.000099999997;
			//       v147 = v142 - v141;
			//       if ( (float)(v142 - v141) <= 0.0 )
			//         v147 = 0.0;
			//       if ( (float)(v146 + v146) > v147 && v147 <= 0.0099999998 )
			//         v147 = 0.0099999998;
			//       v148 = (float)(v142 + v141) * 0.5;
			//       v149 = y * v148;
			//       v150 = v135 * v148;
			//       v151 = valuea + (float)(v133 * v148);
			//       valueb = v151;
			//       y_low.m128_f32[0] = y_low.m128_f32[0] + v149;
			//       x_low.m128_f32[0] = x_low.m128_f32[0] + v150;
			//       if ( !BoneBindWorldMatrix_0_1 )
			//       {
			//         if ( !key )
			//           sub_1802DC2C8(v145, v144);
			//         position = UnityEngine::Transform::get_position(&v217, (Transform *)key, 0LL);
			//         v153 = *(_QWORD *)&position.x;
			//         v154 = position.z;
			//         rotation = UnityEngine::Transform::get_rotation(&v224, (Transform *)key, 0LL);
			//         *(_QWORD *)&v199.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
			//         v199.z = 1.0;
			//         v179 = *rotation;
			//         *(_QWORD *)&v200.x = v153;
			//         v200.z = v154;
			//         bindW = *UnityEngine::Matrix4x4::TRS(v229, &v200, &v179, &v199, 0LL);
			//         v151 = valueb;
			//       }
			//       v210 = *UnityEngine::Matrix4x4::get_inverse(v229, &bindW, 0LL);
			//       *(_QWORD *)&v201.x = _mm_unpacklo_ps(x_low, y_low).m128_u64[0];
			//       v201.z = v151;
			//       v156 = UnityEngine::Matrix4x4::MultiplyPoint3x4(&v218, &v210, &v201, 0LL);
			//       v157 = *(_QWORD *)&v156.x;
			//       v158 = v156.z;
			//       *(_QWORD *)&v202.x = v102;
			//       v202.z = x;
			//       *(_QWORD *)&param_000471c7.fields._IsSynthetic_k__BackingField = v205;
			//       File_k__BackingField = (int)param_000471c7.fields._._File_k__BackingField;
			//       v159 = _mm_loadu_si128((const __m128i *)UnityEngine::Quaternion::FromToRotation(
			//                                                 &v225,
			//                                                 (Vector3 *)&param_000471c7.fields._IsSynthetic_k__BackingField,
			//                                                 &v202,
			//                                                 0LL));
			//       v179 = *UnityEngine::Matrix4x4::get_rotation(&v226, &bindW, 0LL);
			//       v160 = UnityEngine::Quaternion::Inverse(&v227, &v179, 0LL);
			//       v207 = v159;
			//       v179 = *v160;
			//       v207 = *(__m128i *)UnityEngine::Quaternion::op_Multiply((Quaternion *)&v188, &v179, (Quaternion *)&v207, v161);
			//       v162 = sub_182504AA0(v219, &v207);
			//       v165 = *(_QWORD *)v162;
			//       v166 = *(_DWORD *)(v162 + 8);
			//       memset(&v184[8], 0, 32);
			//       *(_QWORD *)v184 = key;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v167 = (((unsigned __int64)v184 >> 12) & 0x1FFFFF) >> 6;
			//         v163 = ((unsigned __int64)v184 >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6870D0[v167]);
			//         do
			//         {
			//           v164 = qword_18D6870D0[v167] | (1LL << v163);
			//           v168 = qword_18D6870D0[v167];
			//         }
			//         while ( v168 != _InterlockedCompareExchange64(&qword_18D6870D0[v167], v164, v168) );
			//       }
			//       *(float *)&v184[8] = v146;
			//       *(float *)&v184[12] = v147;
			//       *(_QWORD *)&v184[16] = v157;
			//       *(float *)&v184[24] = v158;
			//       *(_QWORD *)&v184[28] = v165;
			//       *(_DWORD *)&v184[36] = v166;
			//       fields = param_000471c7.fields.fields;
			//       if ( !param_000471c7.fields.fields )
			//         sub_1802DC2C8(v164, v163);
			//       *(_OWORD *)&v209.m00 = *(_OWORD *)v184;
			//       *(_OWORD *)&v209.m01 = *(_OWORD *)&v184[16];
			//       *(_QWORD *)&v209.m02 = *(_QWORD *)&v184[32];
			//       System::Collections::Generic::List<Beyond::StyledBlackboard::StyledDataPair>::Add(
			//         (List_1_Beyond_StyledBlackboard_StyledDataPair_ *)param_000471c7.fields.fields,
			//         (StyledBlackboard_StyledDataPair *)&v209,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGBoneCapsuleData>::Add);
			//     }
			//   }
			//   catch ( Il2CppExceptionWrapper *v213 )
			//   {
			//     ex = v213.ex;
			//     if ( ex )
			//       sub_18000F780(ex);
			//     return v206;
			//   }
			//   return (List_1_HG_Rendering_Runtime_HGBoneCapsuleData_ *)fields;
			// }
			// 
			return null;
		}

		private static float Quantile(List<float> data, float q)
		{
			// // Single Quantile(List`1[System.Single], Single)
			// float HG::Rendering::Runtime::HGBoneCapsuleUtilities::Quantile(
			//         List_1_System_Single_ *data,
			//         float q,
			//         MethodInfo *method)
			// {
			//   char v4; // dl
			//   __int64 v5; // rcx
			//   int v6; // r8d
			//   int32_t v7; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			// 
			//   if ( !byte_18D919754 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<float>::Sort);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<float>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<float>::get_Item);
			//     byte_18D919754 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3469, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3469, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_195((ILFixDynamicMethodWrapper_7 *)Patch, (Object *)data, q, 0LL);
			//   }
			//   else if ( data && data.fields._size )
			//   {
			//     System::Collections::Generic::List<float>::Sort(data, MethodInfo::System::Collections::Generic::List<float>::Sort);
			//     v7 = sub_182592070(v5, v4, v6);
			//     if ( v7 < 0 )
			//     {
			//       v7 = 0;
			//     }
			//     else if ( v7 > data.fields._size - 1 )
			//     {
			//       v7 = data.fields._size - 1;
			//     }
			//     return System::Collections::Generic::List<float>::get_Item(
			//              data,
			//              v7,
			//              MethodInfo::System::Collections::Generic::List<float>::get_Item);
			//   }
			//   else
			//   {
			//     return 0.0;
			//   }
			// }
			// 
			return 0f;
		}

		private static float GetPaddingByScale(Transform bone)
		{
			// // Single GetPaddingByScale(Transform)
			// float HG::Rendering::Runtime::HGBoneCapsuleUtilities::GetPaddingByScale(Transform *bone, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   Vector3 *lossyScale; // rax
			//   __int32 v6; // xmm3_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v9[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3470, 0LL) )
			//   {
			//     if ( bone )
			//     {
			//       lossyScale = UnityEngine::Transform::get_lossyScale(v9, bone, 0LL);
			//       COERCE_FLOAT(v6 = _mm_load_si128((const __m128i *)&xmmword_18A357260).m128i_i32[0]);
			//       return (float)((float)((float)(COERCE_FLOAT(HIDWORD(*(_QWORD *)&lossyScale.x) & v6)
			//                                    + COERCE_FLOAT(*(_QWORD *)&lossyScale.x & v6))
			//                            + COERCE_FLOAT(LODWORD(lossyScale.z) & v6))
			//                    * 0.33333334)
			//            * 0.0049999999;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v4, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3470, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43((ILFixDynamicMethodWrapper_16 *)Patch, (Object *)bone, 0LL);
			// }
			// 
			return 0f;
		}

		private static Vector3 ComputePCAFirstAxis(List<Vector3> vertsWS, Vector3 origin)
		{
			// // Vector3 ComputePCAFirstAxis(List`1[UnityEngine.Vector3], Vector3)
			// Vector3 *HG::Rendering::Runtime::HGBoneCapsuleUtilities::ComputePCAFirstAxis(
			//         Vector3 *__return_ptr retstr,
			//         List_1_UnityEngine_Vector3_ *vertsWS,
			//         Vector3 *origin,
			//         MethodInfo *method)
			// {
			//   int v4; // ebx
			//   Animator *v8; // rdx
			//   int32_t v9; // r8d
			//   MethodInfo *v10; // r9
			//   Vector3 *Vector; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v13; // rcx
			//   MethodInfo *v14; // r9
			//   __int64 v15; // xmm6_8
			//   float v16; // r15d
			//   int32_t v17; // r14d
			//   MethodInfo *v18; // r9
			//   Vector3 *v19; // rax
			//   int32_t size; // eax
			//   float v21; // xmm7_4
			//   Vector3 *v22; // rax
			//   double v23; // xmm8_8
			//   double v24; // xmm9_8
			//   double v25; // xmm10_8
			//   double v26; // xmm12_8
			//   double v27; // xmm11_8
			//   double v28; // xmm13_8
			//   __int64 v29; // xmm6_8
			//   int32_t v30; // r14d
			//   float v31; // r15d
			//   MethodInfo *v32; // r9
			//   Vector3 *v33; // rax
			//   float v34; // xmm4_4
			//   int32_t v35; // eax
			//   __m128 v36; // xmm4
			//   float v37; // xmm6_4
			//   double v38; // xmm1_8
			//   double v39; // xmm8_8
			//   double v40; // xmm9_8
			//   double v41; // xmm10_8
			//   double v42; // xmm12_8
			//   double v43; // xmm11_8
			//   double v44; // xmm13_8
			//   float v45; // xmm14_4
			//   __m128d v46; // xmm3
			//   __m128 v47; // xmm15
			//   float v48; // xmm6_4
			//   MethodInfo *v49; // rdx
			//   double v50; // xmm0_8
			//   MethodInfo *v51; // rdx
			//   Vector3 *up; // rax
			//   __int64 v53; // xmm3_8
			//   Vector3 *v54; // rax
			//   float z; // eax
			//   __int64 v56; // xmm0_8
			//   float v57; // eax
			//   Vector3 v59; // [rsp+38h] [rbp-D0h] BYREF
			//   __int64 v60; // [rsp+48h] [rbp-C0h] BYREF
			//   __int64 v61; // [rsp+50h] [rbp-B8h]
			//   Vector3 v62; // [rsp+58h] [rbp-B0h] BYREF
			//   Vector3 v63; // [rsp+68h] [rbp-A0h] BYREF
			//   Vector3 v64; // [rsp+78h] [rbp-90h] BYREF
			//   Vector3 v65; // [rsp+88h] [rbp-80h] BYREF
			//   Vector3 v66[14]; // [rsp+98h] [rbp-70h] BYREF
			// 
			//   v4 = 0;
			//   if ( !byte_18D919755 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Item);
			//     byte_18D919755 = 1;
			//   }
			//   *(_QWORD *)&v59.x = 0LL;
			//   v59.z = 0.0;
			//   v60 = 0LL;
			//   LODWORD(v61) = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3471, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3471, 0LL);
			//     if ( Patch )
			//     {
			//       z = origin.z;
			//       *(_QWORD *)&v65.x = *(_QWORD *)&origin.x;
			//       v65.z = z;
			//       v54 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1239(v66, Patch, (Object *)vertsWS, &v65, 0LL);
			//       goto LABEL_23;
			//     }
			// LABEL_21:
			//     sub_180B536AC(v13, Patch);
			//   }
			//   Vector = UnityEngine::Animator::GetVector(&v65, v8, v9, v10);
			//   v15 = *(_QWORD *)&Vector.x;
			//   v16 = Vector.z;
			//   v17 = 0;
			//   if ( !vertsWS )
			//     goto LABEL_21;
			//   while ( v17 < vertsWS.fields._size )
			//   {
			//     System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::BuildingTypeEntry>::get_Item(
			//       (RemoteFactoryUtil_FillBuildingCheckResultIterationContext_BuildingTypeEntry *)&v62,
			//       (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_BuildingTypeEntry_ *)vertsWS,
			//       v17,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Item);
			//     v63 = v62;
			//     *(_QWORD *)&v64.x = v15;
			//     v64.z = v16;
			//     v19 = UnityEngine::Vector3::op_Addition(&v65, &v64, &v63, v18);
			//     ++v17;
			//     v15 = *(_QWORD *)&v19.x;
			//     v16 = v19.z;
			//   }
			//   size = vertsWS.fields._size;
			//   if ( size < 1 )
			//     size = 1;
			//   v21 = 1.0;
			//   v64.z = v16;
			//   *(_QWORD *)&v64.x = v15;
			//   v22 = UnityEngine::Vector3::op_Multiply(&v65, &v64, 1.0 / (float)size, v14);
			//   v23 = 0.0;
			//   v24 = 0.0;
			//   v25 = 0.0;
			//   v26 = 0.0;
			//   v27 = 0.0;
			//   v28 = 0.0;
			//   v29 = *(_QWORD *)&v22.x;
			//   v30 = 0;
			//   v31 = v22.z;
			//   while ( v30 < vertsWS.fields._size )
			//   {
			//     System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::BuildingTypeEntry>::get_Item(
			//       (RemoteFactoryUtil_FillBuildingCheckResultIterationContext_BuildingTypeEntry *)&v64,
			//       (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_BuildingTypeEntry_ *)vertsWS,
			//       v30,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Item);
			//     v62 = v64;
			//     *(_QWORD *)&v63.x = v29;
			//     v63.z = v31;
			//     v33 = UnityEngine::Vector3::op_Subtraction(v66, &v62, &v63, v32);
			//     ++v30;
			//     v34 = v33.z;
			//     *(_QWORD *)&v65.x = *(_QWORD *)&v33.x;
			//     v23 = v23 + (float)(v65.x * v65.x);
			//     v24 = v24 + (float)(v65.y * v65.x);
			//     v25 = v25 + (float)(v34 * v65.x);
			//     v26 = v26 + (float)(v65.y * v65.y);
			//     v27 = v27 + (float)(v34 * v65.y);
			//     v28 = v28 + (float)(v34 * v34);
			//   }
			//   v35 = vertsWS.fields._size;
			//   if ( v35 < 1 )
			//     v35 = 1;
			//   v36 = 0LL;
			//   v37 = 0.0;
			//   v59.x = 1.0;
			//   v38 = 1.0 / (double)v35;
			//   v59.y = 0.0;
			//   v39 = v23 * v38;
			//   v40 = v24 * v38;
			//   v41 = v25 * v38;
			//   v42 = v26 * v38;
			//   v43 = v27 * v38;
			//   v44 = v28 * v38;
			//   v59.z = 0.0;
			//   do
			//   {
			//     v45 = v36.m128_f32[0] * v40 + v21 * v39 + v37 * v41;
			//     v46 = _mm_cvtps_pd(v36);
			//     *(float *)&v60 = v45;
			//     v46.m128d_f64[0] = v46.m128d_f64[0] * v42 + v21 * v40 + v37 * v43;
			//     v47 = _mm_cvtpd_ps(v46);
			//     HIDWORD(v60) = v47.m128_i32[0];
			//     v48 = v36.m128_f32[0] * v43 + v21 * v41 + v37 * v44;
			//     *(float *)&v61 = v48;
			//     v50 = sub_18238EFA0(&v60);
			//     if ( *(float *)&v50 <= 0.0000000099999999 )
			//       break;
			//     v36 = v47;
			//     v21 = v45 / *(float *)&v50;
			//     v36.m128_f32[0] = v47.m128_f32[0] / *(float *)&v50;
			//     v37 = v48 / *(float *)&v50;
			//     ++v4;
			//     v59.x = v45 / *(float *)&v50;
			//     v59.y = v47.m128_f32[0] / *(float *)&v50;
			//     v59.z = v37;
			//   }
			//   while ( v4 < 12 );
			//   if ( UnityEngine::Vector3::get_sqrMagnitude(&v59, v49) < 1.0e-12 )
			//   {
			//     up = UnityEngine::Vector3::get_up(v66, v51);
			//     v53 = *(_QWORD *)&up.x;
			//     *(float *)&up = up.z;
			//     *(_QWORD *)&v59.x = v53;
			//     LODWORD(v59.z) = (_DWORD)up;
			//   }
			//   v54 = (Vector3 *)sub_182413270(v66, &v59);
			// LABEL_23:
			//   v56 = *(_QWORD *)&v54.x;
			//   v57 = v54.z;
			//   *(_QWORD *)&retstr.x = v56;
			//   retstr.z = v57;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Matrix4x4 GetLocalMatrix(HGBoneCapsuleData container)
		{
			// // Matrix4x4 GetLocalMatrix(HGBoneCapsuleData)
			// Matrix4x4 *HG::Rendering::Runtime::HGBoneCapsuleUtilities::GetLocalMatrix(
			//         Matrix4x4 *__return_ptr retstr,
			//         HGBoneCapsuleData *container,
			//         MethodInfo *method)
			// {
			//   __int128 v5; // xmm6
			//   MethodInfo *v6; // rax
			//   Vector3 *one; // rax
			//   Quaternion *v8; // rdx
			//   Quaternion v9; // xmm0
			//   float z; // ecx
			//   __int64 v11; // xmm1_8
			//   __m128i v12; // xmm6
			//   Matrix4x4 *v13; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   __int128 v17; // xmm1
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm0
			//   __int128 v20; // xmm1
			//   Matrix4x4 *result; // rax
			//   Vector3 v22; // [rsp+38h] [rbp-69h] BYREF
			//   Vector3 v23; // [rsp+48h] [rbp-59h] BYREF
			//   Quaternion v24; // [rsp+58h] [rbp-49h] BYREF
			//   Matrix4x4 v25; // [rsp+68h] [rbp-39h] BYREF
			//   Matrix4x4 v26; // [rsp+A8h] [rbp+7h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3472, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3472, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v16, v15);
			//     v17 = *(_OWORD *)&container.localOffset.x;
			//     *(_OWORD *)&v25.m00 = *(_OWORD *)&container.rootTransform;
			//     *(_QWORD *)&v25.m02 = *(_QWORD *)&container.localRotation.y;
			//     *(_OWORD *)&v25.m01 = v17;
			//     v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1240(&v26, Patch, (HGBoneCapsuleData *)&v25, 0LL);
			//   }
			//   else
			//   {
			//     v5 = *(_OWORD *)&container.localOffset.x;
			//     *(_OWORD *)&v25.m00 = *(_OWORD *)&container.rootTransform;
			//     *(_QWORD *)&v25.m02 = *(_QWORD *)&container.localRotation.y;
			//     *(_OWORD *)&v25.m01 = v5;
			//     v22 = *(Vector3 *)&v25.m31;
			//     v6 = (MethodInfo *)sub_182504CA0(&v24, &v22);
			//     one = UnityEngine::Vector3::get_one(&v23, v6);
			//     v9 = *v8;
			//     z = one.z;
			//     v11 = *(_QWORD *)&one.x;
			//     *(_QWORD *)&v23.x = v5;
			//     v12 = _mm_loadl_epi64((const __m128i *)&container.localOffset.z);
			//     v22.z = z;
			//     LODWORD(v23.z) = _mm_cvtsi128_si32(v12);
			//     *(_QWORD *)&v22.x = v11;
			//     v24 = v9;
			//     v13 = UnityEngine::Matrix4x4::TRS(&v25, &v23, &v24, &v22, 0LL);
			//   }
			//   v18 = *(_OWORD *)&v13.m01;
			//   *(_OWORD *)&retstr.m00 = *(_OWORD *)&v13.m00;
			//   v19 = *(_OWORD *)&v13.m02;
			//   *(_OWORD *)&retstr.m01 = v18;
			//   v20 = *(_OWORD *)&v13.m03;
			//   result = retstr;
			//   *(_OWORD *)&retstr.m02 = v19;
			//   *(_OWORD *)&retstr.m03 = v20;
			//   return result;
			// }
			// 
			return null;
		}

		public static Matrix4x4 GetCapsuleLocalToWorldMatrix(HGBoneCapsuleData container, Transform root)
		{
			// // Matrix4x4 GetCapsuleLocalToWorldMatrix(HGBoneCapsuleData, Transform)
			// Matrix4x4 *HG::Rendering::Runtime::HGBoneCapsuleUtilities::GetCapsuleLocalToWorldMatrix(
			//         Matrix4x4 *__return_ptr retstr,
			//         HGBoneCapsuleData *container,
			//         Transform *root,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // xmm1_8
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   __int64 v10; // xmm1_8
			//   Matrix4x4 *localToWorldMatrix; // rax
			//   __int128 v12; // xmm0
			//   Matrix4x4 *LocalMatrix; // rax
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   __int128 v16; // xmm1
			//   Matrix4x4 *v17; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v19; // xmm1
			//   __int128 v20; // xmm1
			//   __int128 v21; // xmm0
			//   __int128 v22; // xmm1
			//   Matrix4x4 *result; // rax
			//   Matrix4x4 v24; // [rsp+38h] [rbp-D0h] BYREF
			//   Matrix4x4 v25; // [rsp+78h] [rbp-90h]
			//   Matrix4x4 v26; // [rsp+B8h] [rbp-50h] BYREF
			//   Matrix4x4 v27; // [rsp+F8h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D919756 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919756 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3473, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3473, 0LL);
			//     if ( Patch )
			//     {
			//       v19 = *(_OWORD *)&container.localOffset.x;
			//       *(_OWORD *)&v24.m00 = *(_OWORD *)&container.rootTransform;
			//       *(_QWORD *)&v24.m02 = *(_QWORD *)&container.localRotation.y;
			//       *(_OWORD *)&v24.m01 = v19;
			//       v17 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1241(
			//               &v27,
			//               Patch,
			//               (HGBoneCapsuleData *)&v24,
			//               (Object *)root,
			//               0LL);
			//       goto LABEL_11;
			//     }
			// LABEL_9:
			//     sub_180B536AC(v9, v8);
			//   }
			//   v7 = *(_QWORD *)&container.localRotation.y;
			//   *(_OWORD *)&v24.m01 = *(_OWORD *)&container.localOffset.x;
			//   *(_QWORD *)&v24.m02 = v7;
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( UnityEngine::Object::op_Inequality((Object_1 *)container.rootTransform, 0LL, 0LL) )
			//   {
			//     root = container.rootTransform;
			//     v10 = *(_QWORD *)&container.localRotation.y;
			//     *(_OWORD *)&v24.m01 = *(_OWORD *)&container.localOffset.x;
			//     *(_QWORD *)&v24.m02 = v10;
			//   }
			//   if ( !root )
			//     goto LABEL_9;
			//   localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(&v26, root, 0LL);
			//   v12 = *(_OWORD *)&localToWorldMatrix.m00;
			//   *(_OWORD *)&v24.m01 = *(_OWORD *)&container.localOffset.x;
			//   *(_OWORD *)&v25.m00 = v12;
			//   *(_OWORD *)&v25.m01 = *(_OWORD *)&localToWorldMatrix.m01;
			//   *(_OWORD *)&v25.m02 = *(_OWORD *)&localToWorldMatrix.m02;
			//   *(_OWORD *)&v25.m03 = *(_OWORD *)&localToWorldMatrix.m03;
			//   *(_OWORD *)&v24.m00 = *(_OWORD *)&container.rootTransform;
			//   *(_QWORD *)&v24.m02 = *(_QWORD *)&container.localRotation.y;
			//   LocalMatrix = HG::Rendering::Runtime::HGBoneCapsuleUtilities::GetLocalMatrix(&v26, (HGBoneCapsuleData *)&v24, 0LL);
			//   v14 = *(_OWORD *)&LocalMatrix.m01;
			//   *(_OWORD *)&v24.m00 = *(_OWORD *)&LocalMatrix.m00;
			//   v15 = *(_OWORD *)&LocalMatrix.m02;
			//   *(_OWORD *)&v24.m01 = v14;
			//   v16 = *(_OWORD *)&LocalMatrix.m03;
			//   *(_OWORD *)&v24.m02 = v15;
			//   *(_OWORD *)&v24.m03 = v16;
			//   v26 = v25;
			//   v17 = UnityEngine::Matrix4x4::op_Multiply(&v27, &v26, &v24, 0LL);
			// LABEL_11:
			//   v20 = *(_OWORD *)&v17.m01;
			//   *(_OWORD *)&retstr.m00 = *(_OWORD *)&v17.m00;
			//   v21 = *(_OWORD *)&v17.m02;
			//   *(_OWORD *)&retstr.m01 = v20;
			//   v22 = *(_OWORD *)&v17.m03;
			//   result = retstr;
			//   *(_OWORD *)&retstr.m02 = v21;
			//   *(_OWORD *)&retstr.m03 = v22;
			//   return result;
			// }
			// 
			return null;
		}

		[CompilerGenerated]
		internal static Transform <AutomateGenerateCapsuleSkeletonsNonHuman>g__FindBuddyBone|0_0(Transform bone, ref HGBoneCapsuleUtilities.<>c__DisplayClass0_0 param_000471c4)
		{
			// // Transform <AutomateGenerateCapsuleSkeletonsNonHuman>g__FindBuddyBone|0_0(Transform, HGBoneCapsuleUtilities+<>c__DisplayClass0_0 ByRef)
			// Transform *HG::Rendering::Runtime::HGBoneCapsuleUtilities::_AutomateGenerateCapsuleSkeletonsNonHuman_g__FindBuddyBone_0_0(
			//         Transform *bone,
			//         HGBoneCapsuleUtilities_c_DisplayClass0_0 *param_000471c4,
			//         MethodInfo *method)
			// {
			//   Transform *v4; // rdi
			//   int32_t v5; // ebx
			//   Object *Child; // rax
			//   Transform *v7; // rsi
			//   Object_1 *Parent; // rbx
			//   HashSet_1_UnityEngine_Transform_ *allBones; // rbx
			//   Object *v11; // rax
			// 
			//   v4 = bone;
			//   if ( !byte_18D919757 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Transform>::Contains);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919757 = 1;
			//   }
			//   v5 = 0;
			//   if ( !v4 )
			//     goto LABEL_14;
			//   while ( v5 < UnityEngine::Transform::get_childCount(v4, 0LL) )
			//   {
			//     Child = (Object *)UnityEngine::Transform::GetChild(v4, v5, 0LL);
			//     bone = (Transform *)param_000471c4.allBones;
			//     v7 = (Transform *)Child;
			//     if ( !param_000471c4.allBones )
			//       goto LABEL_14;
			//     if ( System::Collections::Generic::HashSet<System::Object>::Contains(
			//            (HashSet_1_System_Object_ *)bone,
			//            Child,
			//            MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Transform>::Contains) )
			//     {
			//       return v7;
			//     }
			//     ++v5;
			//   }
			//   Parent = (Object_1 *)UnityEngine::Transform::GetParent(v4, 0LL);
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Inequality(Parent, 0LL, 0LL) )
			//     return 0LL;
			//   allBones = param_000471c4.allBones;
			//   v11 = (Object *)UnityEngine::Transform::GetParent(v4, 0LL);
			//   if ( !allBones )
			// LABEL_14:
			//     sub_180B536AC(bone, param_000471c4);
			//   if ( System::Collections::Generic::HashSet<System::Object>::Contains(
			//          (HashSet_1_System_Object_ *)allBones,
			//          v11,
			//          MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Transform>::Contains) )
			//   {
			//     return UnityEngine::Transform::GetParent(v4, 0LL);
			//   }
			//   return 0LL;
			// }
			// 
			return null;
		}

		[CompilerGenerated]
		internal static bool <AutomateGenerateCapsuleSkeletonsNonHuman>g__TryGetBoneBindWorldMatrix|0_1(Transform bone, out Matrix4x4 bindW, ref HGBoneCapsuleUtilities.<>c__DisplayClass0_0 param_000471c7)
		{
			// // Boolean <AutomateGenerateCapsuleSkeletonsNonHuman>g__TryGetBoneBindWorldMatrix|0_1(Transform, Matrix4x4 ByRef, HGBoneCapsuleUtilities+<>c__DisplayClass0_0 ByRef)
			// // Hidden C++ exception states: #wind=1 #try_helpers=1
			// bool HG::Rendering::Runtime::HGBoneCapsuleUtilities::_AutomateGenerateCapsuleSkeletonsNonHuman_g__TryGetBoneBindWorldMatrix_0_1(
			//         Transform *bone,
			//         Matrix4x4 *bindW,
			//         HGBoneCapsuleUtilities_c_DisplayClass0_0 *param_000471c7,
			//         MethodInfo *method)
			// {
			//   Dictionary_2_UnityEngine_SkinnedMeshRenderer_UnityEngine_Matrix4x4_ *smrBindBoneWorldMats; // rdi
			//   __int64 v8; // rdx
			//   KeyValuePair_2_System_Object_System_Object_ current; // xmm6
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   Transform__Array *bones; // rsi
			//   __int64 v13; // r8
			//   __int64 v14; // r9
			//   unsigned __int64 v15; // xmm6_8
			//   int32_t i; // edi
			//   Object_1 *v17; // r15
			//   _OWORD *v19; // rax
			//   __int128 v20; // xmm1
			//   __int128 v21; // xmm2
			//   __int128 v22; // xmm3
			//   __int128 v23; // [rsp+30h] [rbp-98h] BYREF
			//   KeyValuePair_2_System_Object_System_Object_ v24; // [rsp+40h] [rbp-88h]
			//   __int128 v25; // [rsp+50h] [rbp-78h]
			//   __int128 v26; // [rsp+60h] [rbp-68h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v27; // [rsp+70h] [rbp-58h] BYREF
			// 
			//   if ( !byte_18D919758 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::SkinnedMeshRenderer,UnityEngine::Matrix4x4 []>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::SkinnedMeshRenderer,UnityEngine::Matrix4x4 []>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::SkinnedMeshRenderer,UnityEngine::Matrix4x4 []>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::SkinnedMeshRenderer,UnityEngine::Matrix4x4 []>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<UnityEngine::SkinnedMeshRenderer,UnityEngine::Matrix4x4 []>::get_Key);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<UnityEngine::SkinnedMeshRenderer,UnityEngine::Matrix4x4 []>::get_Value);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919758 = 1;
			//   }
			//   smrBindBoneWorldMats = param_000471c7.smrBindBoneWorldMats;
			//   if ( !smrBindBoneWorldMats )
			//     sub_180B536AC(bone, bindW);
			//   System::Collections::Generic::Dictionary<System::Object,System::Object>::GetEnumerator(
			//     (Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *)&v23,
			//     (Dictionary_2_System_Object_System_Object_ *)smrBindBoneWorldMats,
			//     MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::SkinnedMeshRenderer,UnityEngine::Matrix4x4 []>::GetEnumerator);
			//   *(_OWORD *)&v27._dictionary = v23;
			//   v27._current = v24;
			//   *(_QWORD *)&v27._getEnumeratorRetType = v25;
			//   while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,System::Object>::MoveNext(
			//             &v27,
			//             MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::SkinnedMeshRenderer,UnityEngine::Matrix4x4 []>::MoveNext) )
			//   {
			//     current = v27._current;
			//     if ( !v27._current.key )
			//       sub_1802DC2C8(0LL, v8);
			//     bones = UnityEngine::SkinnedMeshRenderer::get_bones((SkinnedMeshRenderer *)v27._current.key, 0LL);
			//     if ( bones )
			//     {
			//       v15 = _mm_srli_si128((__m128i)current, 8).m128i_u64[0];
			//       for ( i = 0; i < bones.max_length.size; ++i )
			//       {
			//         if ( (unsigned int)i >= bones.max_length.size )
			//           sub_180070260(v11, v10, v13, v14);
			//         v17 = (Object_1 *)bones.vector[i];
			//         sub_180002C70(TypeInfo::UnityEngine::Object);
			//         if ( UnityEngine::Object::op_Equality(v17, (Object_1 *)bone, 0LL) )
			//         {
			//           if ( !v15 )
			//             sub_1802DC2C8(v11, v10);
			//           sub_18005A9F0(v15, &v23, i);
			//           *(_OWORD *)&bindW.m00 = v23;
			//           *(KeyValuePair_2_System_Object_System_Object_ *)&bindW.m01 = v24;
			//           *(_OWORD *)&bindW.m02 = v25;
			//           *(_OWORD *)&bindW.m03 = v26;
			//           return 1;
			//         }
			//       }
			//     }
			//   }
			//   v19 = (_OWORD *)sub_182805160(&v23);
			//   v20 = v19[1];
			//   v21 = v19[2];
			//   v22 = v19[3];
			//   *(_OWORD *)&bindW.m00 = *v19;
			//   *(_OWORD *)&bindW.m01 = v20;
			//   *(_OWORD *)&bindW.m02 = v21;
			//   *(_OWORD *)&bindW.m03 = v22;
			//   return 0;
			// }
			// 
			return default(bool);
		}
	}
}
