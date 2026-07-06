using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Beyond.Resource;

namespace HG.Rendering.Runtime
{
	public class HGTerrainStreamingManager : IDisposable
	{
		public HGTerrainStreamingManager()
		{
		}

		private static ValueTuple<uint, uint, uint> _UnpackTerrainNodeKey(uint nodeKey)
		{
			// // ValueTuple`3[UInt32,UInt32,UInt32] _UnpackTerrainNodeKey(UInt32)
			// ValueTuple_3_UInt32_UInt32_UInt32_ *HG::Rendering::Runtime::HGTerrainStreamingManager::_UnpackTerrainNodeKey(
			//         ValueTuple_3_UInt32_UInt32_UInt32_ *__return_ptr retstr,
			//         uint32_t nodeKey,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   ValueTuple_3_UInt32_UInt32_UInt32_ *v9; // rax
			//   __int64 v10; // xmm0_8
			//   ValueTuple_3_UInt32_UInt32_UInt32_ v11[2]; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDB71 )
			//   {
			//     sub_18003C530(&MethodInfo::System::ValueTuple<unsigned int,unsigned int,unsigned int>::ValueTuple);
			//     byte_18D8EDB71 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1933, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1933, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_754(v11, Patch, nodeKey, 0LL);
			//     v10 = *(_QWORD *)&v9.Item1;
			//     LODWORD(v9) = v9.Item3;
			//     *(_QWORD *)&retstr.Item1 = v10;
			//     retstr.Item3 = (unsigned int)v9;
			//   }
			//   else
			//   {
			//     retstr.Item1 = nodeKey >> 28;
			//     retstr.Item2 = nodeKey & 0x3FFF;
			//     retstr.Item3 = (nodeKey >> 14) & 0x3FFF;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public HGTerrainStreamingState QueryTerrainStreamingState()
		{
			// // HGTerrainStreamingState QueryTerrainStreamingState()
			// HGTerrainStreamingState__Enum HG::Rendering::Runtime::HGTerrainStreamingManager::QueryTerrainStreamingState(
			//         HGTerrainStreamingManager *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   HashSet_1_System_UInt32_ *m_nodeLut; // rax
			//   HashSet_1_System_Int32_ *m_splatLut; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDB72 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<unsigned int>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<int>::get_Count);
			//     byte_18D8EDB72 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3426, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3426, 0LL);
			//     if ( !Patch )
			//       goto LABEL_12;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     if ( this.fields.atlasPageRootPath )
			//     {
			//       if ( !this.fields.m_streamingResult )
			//         return 2;
			//       m_nodeLut = this.fields.m_nodeLut;
			//       if ( m_nodeLut )
			//       {
			//         if ( m_nodeLut.fields._count )
			//           return 1;
			//         m_splatLut = this.fields.m_splatLut;
			//         if ( m_splatLut )
			//         {
			//           if ( m_splatLut.fields._count )
			//             return 1;
			//           return 2;
			//         }
			//       }
			// LABEL_12:
			//       sub_180B536AC(v4, v3);
			//     }
			//     return 0;
			//   }
			// }
			// 
			return (HGTerrainStreamingState)HGTerrainStreamingState.NotInitialized;
		}

		public void EarlyUpdate()
		{
			// // Void EarlyUpdate()
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::HGTerrainStreamingManager::EarlyUpdate(
			//         HGTerrainStreamingManager *this,
			//         MethodInfo *method)
			// {
			//   HGTerrainStreamingManager *v2; // rdi
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v5; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   uint64_t i; // rbx
			//   int32_t v10; // eax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   char v13; // r15
			//   uint64_t j; // rbx
			//   int32_t v15; // eax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   Int32Enum__Enum v18; // r14d
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   __int64 (__fastcall *v21)(int *); // rax
			//   __int64 v22; // r12
			//   unsigned int k; // ebx
			//   uint32_t v24; // eax
			//   __int64 v25; // rdx
			//   __int64 v26; // rcx
			//   __int64 (__fastcall *v27)(int *); // rax
			//   __int64 v28; // r12
			//   unsigned int m; // ebx
			//   uint32_t v30; // eax
			//   __int64 v31; // rdx
			//   __int64 v32; // rcx
			//   uint32_t v33; // r15d
			//   __int64 v34; // rdx
			//   __int64 v35; // rcx
			//   unsigned __int64 v36; // rdx
			//   unsigned __int64 head; // rcx
			//   unsigned __int64 v38; // r8
			//   HGCamera *v39; // r9
			//   int v40; // r15d
			//   Queue_1_System_Int32_ *m_splatsPendingToLoad; // rax
			//   Int32Enum__Enum v42; // eax
			//   __int64 v43; // rdx
			//   __int64 v44; // rcx
			//   int32_t v45; // r14d
			//   __int64 v46; // rdx
			//   Object *v47; // rbx
			//   UnSafeString *v48; // rax
			//   __int64 v49; // rdx
			//   String *v50; // rbx
			//   __int64 v51; // rdx
			//   StringPathHash v52; // rbx
			//   UnSafeString *v53; // rax
			//   String *v54; // rax
			//   StringPathHash v55; // rax
			//   UnSafeString *v56; // rax
			//   String *v57; // rax
			//   StringPathHash v58; // rax
			//   Queue_1_System_UInt32_ *m_nodeAtlasPendingToLoad; // rax
			//   Queue_1_System_UInt32_ *v60; // rbx
			//   UInt32__Array *array; // rax
			//   uint32_t v62; // r13d
			//   int v63; // eax
			//   bool v64; // al
			//   __int64 v65; // rbx
			//   void (__fastcall __noreturn **v66)(); // rax
			//   unsigned int v67; // eax
			//   __int64 v68; // rax
			//   unsigned int *v69; // rdx
			//   unsigned int v70; // r8d
			//   signed __int64 v71; // rtt
			//   __int64 v72; // rbx
			//   __int64 v73; // rax
			//   __int64 v74; // rbx
			//   _QWORD **v75; // rcx
			//   __int64 v76; // r8
			//   __int64 v77; // rax
			//   __int64 v78; // rbx
			//   void (__fastcall __noreturn **v79)(); // rax
			//   unsigned int v80; // eax
			//   __int64 v81; // rax
			//   unsigned int *v82; // rdx
			//   unsigned int v83; // r8d
			//   signed __int64 v84; // rtt
			//   __int64 v85; // rbx
			//   __int64 v86; // rax
			//   __int64 v87; // rbx
			//   _QWORD **v88; // rcx
			//   __int64 v89; // r8
			//   __int64 v90; // rax
			//   __int64 v91; // rbx
			//   void (__fastcall __noreturn **v92)(); // rax
			//   unsigned int v93; // eax
			//   __int64 v94; // rax
			//   unsigned int *v95; // rdx
			//   __int64 v96; // rbx
			//   __int64 v97; // rax
			//   __int64 v98; // rbx
			//   _QWORD **v99; // rcx
			//   __int64 v100; // r8
			//   __int64 v101; // rax
			//   ILFixDynamicMethodWrapper_2__Array *v102; // r14
			//   ILFixDynamicMethodWrapper_2 *v103; // r14
			//   unsigned int v104; // r8d
			//   __int64 v105; // rbx
			//   void (__fastcall __noreturn **v106)(); // rax
			//   unsigned int v107; // eax
			//   unsigned int v108; // r8d
			//   __int64 v109; // rax
			//   unsigned int *v110; // rdx
			//   HGRenderPathBase_HGRenderPathResources *v111; // rdx
			//   PassConstructorID__Enum__Array *v112; // r8
			//   HGCamera *v113; // r9
			//   void (__fastcall __noreturn **v114)(); // r9
			//   __int64 v115; // rbx
			//   __int64 v116; // rax
			//   __int64 v117; // rbx
			//   _QWORD **v118; // rcx
			//   __int64 v119; // r8
			//   __int64 v120; // rax
			//   __int64 v121; // rdx
			//   __int64 v122; // rdx
			//   VirtualMachine *virtualMachine; // rcx
			//   struct MethodInfo *v124; // r14
			//   Object *Object; // rbx
			//   VirtualMachine__Class *klass; // rax
			//   uint32_t monitor; // r14d
			//   uint32_t v128; // r15d
			//   uint32_t v129; // r12d
			//   __int64 v130; // rdx
			//   Object *atlasPageRootPath; // rbx
			//   UnSafeString *v132; // rax
			//   __int64 v133; // rdx
			//   String *v134; // rbx
			//   __int64 v135; // rdx
			//   StringPathHash v136; // rbx
			//   UnSafeString *v137; // rax
			//   String *v138; // rax
			//   StringPathHash v139; // rax
			//   UnSafeString *v140; // rax
			//   String *v141; // rax
			//   StringPathHash v142; // rax
			//   UnSafeString *v143; // rax
			//   String *v144; // rax
			//   StringPathHash v145; // rax
			//   UnSafeString *v146; // rax
			//   String *v147; // rax
			//   StringPathHash v148; // rax
			//   __int64 v149; // r9
			//   __int128 v150; // xmm2
			//   IDisposable *v151; // r8
			//   Queue_1_HG_Rendering_Runtime_HGTerrainStreamingManager_TerrainLoadingNode_ *m_nodeAtlasPendingLoaded; // rbx
			//   struct MethodInfo *v153; // r13
			//   HGTerrainStreamingManager_TerrainLoadingNode__Array *v154; // rax
			//   HGTerrainStreamingManager_TerrainLoadingNode__Array *v155; // rax
			//   int v156; // r14d
			//   __int64 v157; // rcx
			//   __int64 v158; // rax
			//   Array *v159; // r15
			//   HGTerrainStreamingManager_TerrainLoadingNode__Array *v160; // r10
			//   HGTerrainStreamingManager_TerrainLoadingNode__Array *v161; // r9
			//   int32_t v162; // r9d
			//   int32_t size; // eax
			//   int32_t v164; // edx
			//   Array *v165; // rcx
			//   signed __int64 v166; // rtt
			//   int32_t v167; // eax
			//   int v168; // eax
			//   __int64 v169; // rax
			//   __int64 v170; // rax
			//   MethodInfo *refCount; // [rsp+20h] [rbp-268h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-260h]
			//   int v173; // [rsp+30h] [rbp-258h]
			//   unsigned int v174; // [rsp+30h] [rbp-258h]
			//   IDisposable *v175; // [rsp+38h] [rbp-250h] BYREF
			//   Il2CppException *v176; // [rsp+40h] [rbp-248h] BYREF
			//   IDisposable **v177; // [rsp+48h] [rbp-240h] BYREF
			//   HGTerrainStreamingManager_TerrainLoadingSplat v178; // [rsp+50h] [rbp-238h] BYREF
			//   uint32_t arg2[8]; // [rsp+90h] [rbp-1F8h]
			//   HGTerrainStreamingManager_TerrainLoadingSplat call; // [rsp+B0h] [rbp-1D8h] BYREF
			//   __int128 v181; // [rsp+F0h] [rbp-198h]
			//   __int128 v182; // [rsp+100h] [rbp-188h]
			//   __int64 v183; // [rsp+110h] [rbp-178h]
			//   Il2CppException *ex; // [rsp+120h] [rbp-168h]
			//   IDisposable **v185; // [rsp+128h] [rbp-160h] BYREF
			//   HGTerrainStreamingManager_TerrainLoadingSplat v186; // [rsp+130h] [rbp-158h]
			//   __int128 v187; // [rsp+170h] [rbp-118h]
			//   _BYTE v188[24]; // [rsp+180h] [rbp-108h]
			//   int v189; // [rsp+1A0h] [rbp-E8h] BYREF
			//   int v190; // [rsp+1B0h] [rbp-D8h] BYREF
			//   int v191; // [rsp+1C0h] [rbp-C8h] BYREF
			//   _BYTE v192[100]; // [rsp+1D0h] [rbp-B8h] BYREF
			//   int v193; // [rsp+234h] [rbp-54h]
			//   Il2CppExceptionWrapper *v194; // [rsp+240h] [rbp-48h] BYREF
			//   Il2CppExceptionWrapper *v195; // [rsp+248h] [rbp-40h] BYREF
			//   int v197; // [rsp+2A0h] [rbp+18h] BYREF
			//   int v198; // [rsp+2A8h] [rbp+20h] BYREF
			// 
			//   v2 = this;
			//   if ( !byte_18D8EDB73 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<unsigned int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<unsigned int>::Contains);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<int>::Contains);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<unsigned int>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<int>::Remove);
			//     sub_18003C530(&TypeInfo::Beyond::Resource::HashStringPathProcessor);
			//     sub_18003C530(&TypeInfo::System::IDisposable);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<unsigned int>::Dequeue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<int>::Dequeue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode>::Enqueue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<unsigned int>::Enqueue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat>::Enqueue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<int>::Enqueue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<unsigned int>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<int>::get_Count);
			//     sub_18003C530(&MethodInfo::Beyond::Resource::ResourceManager::LoadAsync<UnityEngine::Texture2D>);
			//     sub_18003C530(&TypeInfo::Beyond::Resource::ResourceManager);
			//     sub_18003C530(&MethodInfo::Beyond::UnSafeString::Format<System::String,int>);
			//     sub_18003C530(&MethodInfo::Beyond::UnSafeString::Format<System::String,unsigned int,unsigned int,unsigned int>);
			//     sub_18003C530(&TypeInfo::Beyond::UnSafeString);
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::ReadArrayElement<unsigned int>);
			//     sub_18003C530(&off_18C909F10);
			//     sub_18003C530(&off_18C909F18);
			//     sub_18003C530(&off_18C909F28);
			//     sub_18003C530(&off_18C909F98);
			//     sub_18003C530(&off_18C909FA0);
			//     sub_18003C530(&off_18C909FA8);
			//     sub_18003C530(&off_18C909FB8);
			//     sub_18003C530(&off_18C909F80);
			//     byte_18D8EDB73 = 1;
			//   }
			//   v197 = 0;
			//   v198 = 0;
			//   v175 = 0LL;
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
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v3, method);
			//   if ( wrapperArray.max_length.size <= 1932 )
			//     goto LABEL_17;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v5 = v3.static_fields.wrapperArray;
			//   if ( !v5 )
			//     sub_180B536AC(v3, method);
			//   if ( v5.max_length.size <= 0x78Cu )
			//     sub_180070270(v3, method);
			//   if ( !v5[53].vector[24] )
			//   {
			// LABEL_17:
			//     if ( !v2.fields.atlasPageRootPath )
			//       return;
			//     for ( i = UnityEngine::HyperGryph::HGTerrainManager::GetTerrainSplatsForCanceling(0LL); i; i &= ~(1LL << (v13 & 0x3F)) )
			//     {
			//       v10 = sub_1823DE3A0(i);
			//       v13 = v10;
			//       if ( !v2.fields.m_splatLut )
			//         sub_180B536AC(v12, v11);
			//       System::Collections::Generic::HashSet<int>::Remove(
			//         v2.fields.m_splatLut,
			//         v10,
			//         MethodInfo::System::Collections::Generic::HashSet<int>::Remove);
			//     }
			//     UnityEngine::HyperGryph::HGTerrainManager::ResetTerrainSplatsForCanceling(0LL);
			//     for ( j = UnityEngine::HyperGryph::HGTerrainManager::GetTerrainSplatsForStreaming(0LL); j; j &= ~(1LL << (v18 & 0x3F)) )
			//     {
			//       v15 = sub_1823DE3A0(j);
			//       v18 = v15;
			//       if ( !v2.fields.m_splatLut )
			//         sub_180B536AC(v17, v16);
			//       System::Collections::Generic::HashSet<int>::Add(
			//         v2.fields.m_splatLut,
			//         v15,
			//         MethodInfo::System::Collections::Generic::HashSet<int>::Add);
			//       if ( !v2.fields.m_splatsPendingToLoad )
			//         sub_180B536AC(v20, v19);
			//       System::Collections::Generic::Queue<System::Int32Enum>::Enqueue(
			//         (Queue_1_System_Int32Enum_ *)v2.fields.m_splatsPendingToLoad,
			//         v18,
			//         MethodInfo::System::Collections::Generic::Queue<int>::Enqueue);
			//     }
			//     UnityEngine::HyperGryph::HGTerrainManager::ResetTerrainSplatsForStreaming(0LL);
			//     v21 = (__int64 (__fastcall *)(int *))qword_18D8F5C08;
			//     if ( !qword_18D8F5C08 )
			//     {
			//       v21 = (__int64 (__fastcall *)(int *))il2cpp_resolve_icall_0(
			//                                              "UnityEngine.HyperGryph.HGTerrainManager::GetTerrainNodesForCanceling(System.Int32&)");
			//       if ( !v21 )
			//       {
			//         v169 = sub_1802DBBE8("UnityEngine.HyperGryph.HGTerrainManager::GetTerrainNodesForCanceling(System.Int32&)");
			//         sub_18000F750(v169, 0LL);
			//       }
			//       qword_18D8F5C08 = (__int64)v21;
			//     }
			//     v22 = v21(&v197);
			//     for ( k = 0; (int)k < v197; ++k )
			//     {
			//       v24 = sub_1822A9AF0(
			//               v22,
			//               k,
			//               MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::ReadArrayElement<unsigned int>);
			//       if ( !v2.fields.m_nodeLut )
			//         sub_180B536AC(v26, v25);
			//       System::Collections::Generic::HashSet<unsigned int>::Remove(
			//         v2.fields.m_nodeLut,
			//         v24,
			//         MethodInfo::System::Collections::Generic::HashSet<unsigned int>::Remove);
			//     }
			//     UnityEngine::HyperGryph::HGTerrainManager::ResetTerrainNodesForCanceling(0LL);
			//     v27 = (__int64 (__fastcall *)(int *))qword_18D8F5C10;
			//     if ( !qword_18D8F5C10 )
			//     {
			//       v27 = (__int64 (__fastcall *)(int *))il2cpp_resolve_icall_0(
			//                                              "UnityEngine.HyperGryph.HGTerrainManager::GetTerrainNodesForStreaming(System.Int32&)");
			//       if ( !v27 )
			//       {
			//         v170 = sub_1802DBBE8("UnityEngine.HyperGryph.HGTerrainManager::GetTerrainNodesForStreaming(System.Int32&)");
			//         sub_18000F750(v170, 0LL);
			//       }
			//       qword_18D8F5C10 = (__int64)v27;
			//     }
			//     v28 = v27(&v198);
			//     for ( m = 0; (int)m < v198; ++m )
			//     {
			//       v30 = sub_1822A9AF0(
			//               v28,
			//               m,
			//               MethodInfo::Unity::Collections::LowLevel::Unsafe::UnsafeUtility::ReadArrayElement<unsigned int>);
			//       v33 = v30;
			//       if ( !v2.fields.m_nodeAtlasPendingToLoad )
			//         sub_180B536AC(v32, v31);
			//       System::Collections::Generic::Queue<unsigned int>::Enqueue(
			//         v2.fields.m_nodeAtlasPendingToLoad,
			//         v30,
			//         MethodInfo::System::Collections::Generic::Queue<unsigned int>::Enqueue);
			//       if ( !v2.fields.m_nodeLut )
			//         sub_180B536AC(v35, v34);
			//       System::Collections::Generic::HashSet<unsigned int>::Add(
			//         v2.fields.m_nodeLut,
			//         v33,
			//         MethodInfo::System::Collections::Generic::HashSet<unsigned int>::Add);
			//     }
			//     UnityEngine::HyperGryph::HGTerrainManager::ResetTerrainNodesForStreaming(0LL);
			//     v40 = 0;
			//     v173 = 0;
			//     do
			//     {
			// LABEL_39:
			//       m_splatsPendingToLoad = v2.fields.m_splatsPendingToLoad;
			//       if ( !m_splatsPendingToLoad )
			// LABEL_262:
			//         sub_1802DC2C8(head, v36);
			//       if ( !m_splatsPendingToLoad.fields._size || v40 >= 2 )
			//       {
			//         head = 0LL;
			//         while ( 2 )
			//         {
			//           v174 = head;
			//           do
			//           {
			//             m_nodeAtlasPendingToLoad = v2.fields.m_nodeAtlasPendingToLoad;
			//             if ( !m_nodeAtlasPendingToLoad )
			//               goto LABEL_262;
			//             if ( !m_nodeAtlasPendingToLoad.fields._size || (int)head >= 2 )
			//               return;
			//             v60 = v2.fields.m_nodeAtlasPendingToLoad;
			//             v36 = (unsigned __int64)MethodInfo::System::Collections::Generic::Queue<unsigned int>::Dequeue;
			//             head = m_nodeAtlasPendingToLoad.fields._head;
			//             array = m_nodeAtlasPendingToLoad.fields._array;
			//             if ( !array )
			//               goto LABEL_262;
			//             if ( (unsigned int)head >= array.max_length.size )
			//               goto LABEL_280;
			//             v62 = array.vector[head];
			//             if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Queue<unsigned int>::Dequeue.klass.rgctx_data[4].rgctxDataDummy
			//                   + 4) )
			//               (*(void (**)(void))MethodInfo::System::Collections::Generic::Queue<unsigned int>::Dequeue.klass.rgctx_data[4].rgctxDataDummy)();
			//             v36 = (unsigned int)(v60.fields._head + 1);
			//             head = (unsigned __int64)v60.fields._array;
			//             if ( !head )
			//               goto LABEL_262;
			//             v63 = 0;
			//             if ( (_DWORD)v36 != *(_DWORD *)(head + 24) )
			//               v63 = v60.fields._head + 1;
			//             v60.fields._head = v63;
			//             --v60.fields._size;
			//             ++v60.fields._version;
			//             head = (unsigned __int64)v2.fields.m_nodeLut;
			//             if ( !head )
			//               goto LABEL_262;
			//             v64 = System::Collections::Generic::HashSet<unsigned int>::Contains(
			//                     (HashSet_1_System_UInt32_ *)head,
			//                     v62,
			//                     MethodInfo::System::Collections::Generic::HashSet<unsigned int>::Contains);
			//             head = v174;
			//           }
			//           while ( !v64 );
			//           if ( !byte_18D8EDB71 )
			//           {
			//             v38 = _InterlockedExchangeAdd64(
			//                     (volatile signed __int64 *)&MethodInfo::System::ValueTuple<unsigned int,unsigned int,unsigned int>::ValueTuple,
			//                     0LL);
			//             if ( (v38 & 1) != 0 )
			//             {
			//               v65 = ((unsigned int)v38 >> 1) & 0xFFFFFFF;
			//               switch ( (unsigned int)v38 >> 29 )
			//               {
			//                 case 1u:
			//                   v66 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v65);
			//                   goto LABEL_101;
			//                 case 2u:
			//                   v66 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v65);
			//                   goto LABEL_101;
			//                 case 3u:
			//                 case 6u:
			//                   v67 = ((unsigned int)v38 >> 1) & 0xFFFFFFF;
			//                   v38 = (unsigned int)v38 >> 29;
			//                   if ( (_DWORD)v38 )
			//                   {
			//                     if ( (_DWORD)v38 == 3 )
			//                     {
			//                       v66 = (void (__fastcall __noreturn **)())sub_180039480(v67);
			//                       goto LABEL_101;
			//                     }
			//                     if ( (_DWORD)v38 == 6 )
			//                     {
			//                       v68 = sub_1802DF9C0(v67);
			//                       v66 = (void (__fastcall __noreturn **)())sub_18005F4B0(v68, 0LL);
			//                       goto LABEL_101;
			//                     }
			//                   }
			//                   else if ( v67 == 1 )
			//                   {
			//                     v66 = off_18A2C5600;
			//                     goto LABEL_101;
			//                   }
			// LABEL_100:
			//                   v66 = 0LL;
			// LABEL_101:
			//                   if ( v66 )
			//                     _InterlockedExchange64(
			//                       (volatile __int64 *)&MethodInfo::System::ValueTuple<unsigned int,unsigned int,unsigned int>::ValueTuple,
			//                       (__int64)v66);
			//                   break;
			//                 case 4u:
			//                   v66 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v65);
			//                   goto LABEL_101;
			//                 case 5u:
			//                   if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v65) )
			//                   {
			//                     v66 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v65);
			//                   }
			//                   else
			//                   {
			//                     v69 = (unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v65);
			//                     v39 = (HGCamera *)il2cpp_string_new_len(
			//                                         qword_18D8E5198 + (int)v69[1] + *(int *)(qword_18D8E51A0 + 16),
			//                                         *v69);
			//                     v66 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                                (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v65),
			//                                                                (signed __int64)v39,
			//                                                                0LL);
			//                     if ( !v66 )
			//                     {
			//                       v38 = qword_18D8F6F98 + 8 * v65;
			//                       if ( dword_18D8E43F8 )
			//                       {
			//                         v70 = (v38 >> 12) & 0x1FFFFF;
			//                         v36 = 0x180000000LL + 8 * ((unsigned __int64)v70 >> 6) + 224948432;
			//                         v38 = v70 & 0x3F;
			//                         _m_prefetchw((const void *)v36);
			//                         do
			//                           v71 = *(_QWORD *)v36;
			//                         while ( v71 != _InterlockedCompareExchange64(
			//                                          (volatile signed __int64 *)v36,
			//                                          *(_QWORD *)v36 | (1LL << v38),
			//                                          *(_QWORD *)v36) );
			//                       }
			//                       v66 = (void (__fastcall __noreturn **)())v39;
			//                     }
			//                   }
			//                   goto LABEL_101;
			//                 case 7u:
			//                   v72 = sub_1802DF920((unsigned int)v65);
			//                   v73 = *(_QWORD *)(v72 + 16);
			//                   v74 = (v72 - *(_QWORD *)(v73 + 128)) >> 5;
			//                   if ( *(_BYTE *)(v73 + 42) == 21 )
			//                   {
			//                     v75 = *(_QWORD ***)(v73 + 96);
			//                     if ( *v75 )
			//                     {
			//                       v76 = **v75 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                       v73 = sub_180039550(v76 / 92 + v76);
			//                     }
			//                     else
			//                     {
			//                       v73 = 0LL;
			//                     }
			//                   }
			//                   v189 = v74 + *(_DWORD *)(*(_QWORD *)(v73 + 104) + 32LL);
			//                   v77 = sub_1801B8ECC(
			//                           (unsigned int)&v189,
			//                           (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                           *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                           12,
			//                           (__int64)sub_1802C7760);
			//                   if ( !v77 )
			//                     goto LABEL_100;
			//                   v36 = *(unsigned int *)(v77 + 8);
			//                   if ( (_DWORD)v36 == -1 )
			//                     goto LABEL_100;
			//                   v66 = (void (__fastcall __noreturn **)())(v36 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			//                   goto LABEL_101;
			//                 default:
			//                   break;
			//               }
			//             }
			//             byte_18D8EDB71 = 1;
			//           }
			//           if ( !byte_18D8EDC37 )
			//           {
			//             v38 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, 0LL);
			//             if ( (v38 & 1) != 0 )
			//             {
			//               v78 = ((unsigned int)v38 >> 1) & 0xFFFFFFF;
			//               switch ( (unsigned int)v38 >> 29 )
			//               {
			//                 case 1u:
			//                   v79 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v78);
			//                   goto LABEL_132;
			//                 case 2u:
			//                   v79 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v78);
			//                   goto LABEL_132;
			//                 case 3u:
			//                 case 6u:
			//                   v80 = ((unsigned int)v38 >> 1) & 0xFFFFFFF;
			//                   v38 = (unsigned int)v38 >> 29;
			//                   if ( (_DWORD)v38 )
			//                   {
			//                     if ( (_DWORD)v38 == 3 )
			//                     {
			//                       v79 = (void (__fastcall __noreturn **)())sub_180039480(v80);
			//                       goto LABEL_132;
			//                     }
			//                     if ( (_DWORD)v38 == 6 )
			//                     {
			//                       v81 = sub_1802DF9C0(v80);
			//                       v79 = (void (__fastcall __noreturn **)())sub_18005F4B0(v81, 0LL);
			//                       goto LABEL_132;
			//                     }
			//                   }
			//                   else if ( v80 == 1 )
			//                   {
			//                     v79 = off_18A2C5600;
			//                     goto LABEL_132;
			//                   }
			// LABEL_131:
			//                   v79 = 0LL;
			// LABEL_132:
			//                   if ( v79 )
			//                     _InterlockedExchange64((volatile __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, (__int64)v79);
			//                   break;
			//                 case 4u:
			//                   v79 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v78);
			//                   goto LABEL_132;
			//                 case 5u:
			//                   if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v78) )
			//                   {
			//                     v79 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v78);
			//                   }
			//                   else
			//                   {
			//                     v82 = (unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v78);
			//                     v39 = (HGCamera *)il2cpp_string_new_len(
			//                                         qword_18D8E5198 + (int)v82[1] + *(int *)(qword_18D8E51A0 + 16),
			//                                         *v82);
			//                     v79 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                                (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v78),
			//                                                                (signed __int64)v39,
			//                                                                0LL);
			//                     if ( !v79 )
			//                     {
			//                       v38 = qword_18D8F6F98 + 8 * v78;
			//                       if ( dword_18D8E43F8 )
			//                       {
			//                         v83 = (v38 >> 12) & 0x1FFFFF;
			//                         v36 = 0x180000000LL + 8 * ((unsigned __int64)v83 >> 6) + 224948432;
			//                         v38 = v83 & 0x3F;
			//                         _m_prefetchw((const void *)v36);
			//                         do
			//                           v84 = *(_QWORD *)v36;
			//                         while ( v84 != _InterlockedCompareExchange64(
			//                                          (volatile signed __int64 *)v36,
			//                                          *(_QWORD *)v36 | (1LL << v38),
			//                                          *(_QWORD *)v36) );
			//                       }
			//                       v79 = (void (__fastcall __noreturn **)())v39;
			//                     }
			//                   }
			//                   goto LABEL_132;
			//                 case 7u:
			//                   v85 = sub_1802DF920((unsigned int)v78);
			//                   v86 = *(_QWORD *)(v85 + 16);
			//                   v87 = (v85 - *(_QWORD *)(v86 + 128)) >> 5;
			//                   if ( *(_BYTE *)(v86 + 42) == 21 )
			//                   {
			//                     v88 = *(_QWORD ***)(v86 + 96);
			//                     if ( *v88 )
			//                     {
			//                       v89 = **v88 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                       v86 = sub_180039550(v89 / 92 + v89);
			//                     }
			//                     else
			//                     {
			//                       v86 = 0LL;
			//                     }
			//                   }
			//                   v190 = v87 + *(_DWORD *)(*(_QWORD *)(v86 + 104) + 32LL);
			//                   v90 = sub_1801B8ECC(
			//                           (unsigned int)&v190,
			//                           (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                           *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                           12,
			//                           (__int64)sub_1802C7760);
			//                   if ( !v90 )
			//                     goto LABEL_131;
			//                   v36 = *(unsigned int *)(v90 + 8);
			//                   if ( (_DWORD)v36 == -1 )
			//                     goto LABEL_131;
			//                   v79 = (void (__fastcall __noreturn **)())(v36 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			//                   goto LABEL_132;
			//                 default:
			//                   break;
			//               }
			//             }
			//             byte_18D8EDC37 = 1;
			//           }
			//           head = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v36);
			//             head = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           }
			//           v36 = **(_QWORD **)(head + 184);
			//           if ( !v36 )
			//             goto LABEL_262;
			//           if ( *(int *)(v36 + 24) <= 1933 )
			//             goto LABEL_217;
			//           if ( !*(_DWORD *)(head + 224) )
			//           {
			//             il2cpp_runtime_class_init_0(head, v36);
			//             head = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           }
			//           v36 = **(_QWORD **)(head + 184);
			//           if ( !v36 )
			//             goto LABEL_262;
			//           if ( *(_DWORD *)(v36 + 24) <= 0x78Du )
			//             goto LABEL_280;
			//           if ( *(_QWORD *)(v36 + 15496) )
			//           {
			//             if ( !byte_18D919D50 )
			//             {
			//               v38 = _InterlockedExchangeAdd64(
			//                       (volatile signed __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper,
			//                       0LL);
			//               if ( (v38 & 1) != 0 )
			//               {
			//                 v91 = ((unsigned int)v38 >> 1) & 0xFFFFFFF;
			//                 switch ( (unsigned int)v38 >> 29 )
			//                 {
			//                   case 1u:
			//                     v92 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v91);
			//                     goto LABEL_169;
			//                   case 2u:
			//                     v92 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v91);
			//                     goto LABEL_169;
			//                   case 3u:
			//                   case 6u:
			//                     v93 = ((unsigned int)v38 >> 1) & 0xFFFFFFF;
			//                     v38 = (unsigned int)v38 >> 29;
			//                     if ( (_DWORD)v38 )
			//                     {
			//                       if ( (_DWORD)v38 == 3 )
			//                       {
			//                         v92 = (void (__fastcall __noreturn **)())sub_180039480(v93);
			//                         goto LABEL_169;
			//                       }
			//                       if ( (_DWORD)v38 == 6 )
			//                       {
			//                         v94 = sub_1802DF9C0(v93);
			//                         v92 = (void (__fastcall __noreturn **)())sub_18005F4B0(v94, 0LL);
			//                         goto LABEL_169;
			//                       }
			//                     }
			//                     else if ( v93 == 1 )
			//                     {
			//                       v92 = off_18A2C5600;
			//                       goto LABEL_169;
			//                     }
			// LABEL_168:
			//                     v92 = 0LL;
			// LABEL_169:
			//                     if ( v92 )
			//                       _InterlockedExchange64(
			//                         (volatile __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper,
			//                         (__int64)v92);
			//                     break;
			//                   case 4u:
			//                     v92 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v91);
			//                     goto LABEL_169;
			//                   case 5u:
			//                     if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v91) )
			//                     {
			//                       v92 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v91);
			//                     }
			//                     else
			//                     {
			//                       v95 = (unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v91);
			//                       v39 = (HGCamera *)il2cpp_string_new_len(
			//                                           qword_18D8E5198 + (int)v95[1] + *(int *)(qword_18D8E51A0 + 16),
			//                                           *v95);
			//                       v92 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                                  (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v91),
			//                                                                  (signed __int64)v39,
			//                                                                  0LL);
			//                       if ( !v92 )
			//                       {
			//                         sub_1800054D0(
			//                           (HGRenderPathScene *)(qword_18D8F6F98 + 8 * v91),
			//                           (HGRenderPathBase_HGRenderPathResources *)v36,
			//                           (PassConstructorID__Enum__Array *)v38,
			//                           v39,
			//                           refCount,
			//                           methoda);
			//                         v92 = (void (__fastcall __noreturn **)())v39;
			//                       }
			//                     }
			//                     goto LABEL_169;
			//                   case 7u:
			//                     v96 = sub_1802DF920((unsigned int)v91);
			//                     v97 = *(_QWORD *)(v96 + 16);
			//                     v98 = (v96 - *(_QWORD *)(v97 + 128)) >> 5;
			//                     if ( *(_BYTE *)(v97 + 42) == 21 )
			//                     {
			//                       v99 = *(_QWORD ***)(v97 + 96);
			//                       if ( *v99 )
			//                       {
			//                         v100 = **v99 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                         v97 = sub_180039550(v100 / 92 + v100);
			//                       }
			//                       else
			//                       {
			//                         v97 = 0LL;
			//                       }
			//                     }
			//                     v191 = v98 + *(_DWORD *)(*(_QWORD *)(v97 + 104) + 32LL);
			//                     v101 = sub_1801B8ECC(
			//                              (unsigned int)&v191,
			//                              (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                              *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                              12,
			//                              (__int64)sub_1802C7760);
			//                     if ( !v101 )
			//                       goto LABEL_168;
			//                     v36 = *(unsigned int *)(v101 + 8);
			//                     if ( (_DWORD)v36 == -1 )
			//                       goto LABEL_168;
			//                     v92 = (void (__fastcall __noreturn **)())(v36 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			//                     goto LABEL_169;
			//                   default:
			//                     break;
			//                 }
			//               }
			//               byte_18D919D50 = 1;
			//               head = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//             }
			//             if ( !*(_DWORD *)(head + 224) )
			//             {
			//               il2cpp_runtime_class_init_0(head, v36);
			//               head = (unsigned __int64)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//             }
			//             v102 = **(ILFixDynamicMethodWrapper_2__Array ***)(head + 184);
			//             if ( !v102 )
			//               goto LABEL_262;
			//             if ( v102.max_length.size <= 0x78Du )
			// LABEL_280:
			//               sub_180070260(head, v36, v38, v39);
			//             v103 = v102[53].vector[25];
			//             if ( !v103 )
			//               goto LABEL_262;
			//             if ( !byte_18D919ACA )
			//             {
			//               v104 = _InterlockedExchangeAdd64(
			//                        (volatile signed __int64 *)&MethodInfo::IFix::Core::Call::GetAsType<System::ValueTuple<unsigned int,unsigned int,unsigned int>>,
			//                        0LL);
			//               if ( (v104 & 1) != 0 )
			//               {
			//                 v105 = (v104 >> 1) & 0xFFFFFFF;
			//                 switch ( v104 >> 29 )
			//                 {
			//                   case 1u:
			//                     v106 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v105);
			//                     goto LABEL_202;
			//                   case 2u:
			//                     v106 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v105);
			//                     goto LABEL_202;
			//                   case 3u:
			//                   case 6u:
			//                     v107 = (v104 >> 1) & 0xFFFFFFF;
			//                     v108 = v104 >> 29;
			//                     if ( v108 )
			//                     {
			//                       if ( v108 == 3 )
			//                       {
			//                         v106 = (void (__fastcall __noreturn **)())sub_180039480(v107);
			//                         goto LABEL_202;
			//                       }
			//                       if ( v108 == 6 )
			//                       {
			//                         v109 = sub_1802DF9C0(v107);
			//                         v106 = (void (__fastcall __noreturn **)())sub_18005F4B0(v109, 0LL);
			//                         goto LABEL_202;
			//                       }
			//                     }
			//                     else if ( v107 == 1 )
			//                     {
			//                       v106 = off_18A2C5600;
			//                       goto LABEL_202;
			//                     }
			// LABEL_201:
			//                     v106 = 0LL;
			// LABEL_202:
			//                     if ( v106 )
			//                       _InterlockedExchange64(
			//                         (volatile __int64 *)&MethodInfo::IFix::Core::Call::GetAsType<System::ValueTuple<unsigned int,unsigned int,unsigned int>>,
			//                         (__int64)v106);
			//                     break;
			//                   case 4u:
			//                     v106 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v105);
			//                     goto LABEL_202;
			//                   case 5u:
			//                     if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v105) )
			//                     {
			//                       v106 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v105);
			//                     }
			//                     else
			//                     {
			//                       v110 = (unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v105);
			//                       v113 = (HGCamera *)il2cpp_string_new_len(
			//                                            qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 16) + (int)v110[1],
			//                                            *v110);
			//                       v106 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                                   (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v105),
			//                                                                   (signed __int64)v113,
			//                                                                   0LL);
			//                       if ( !v106 )
			//                       {
			//                         sub_1800054D0(
			//                           (HGRenderPathScene *)(qword_18D8F6F98 + 8 * v105),
			//                           v111,
			//                           v112,
			//                           v113,
			//                           refCount,
			//                           methoda);
			//                         v106 = v114;
			//                       }
			//                     }
			//                     goto LABEL_202;
			//                   case 7u:
			//                     v115 = sub_1802DF920((unsigned int)v105);
			//                     v116 = *(_QWORD *)(v115 + 16);
			//                     v117 = (v115 - *(_QWORD *)(v116 + 128)) >> 5;
			//                     if ( *(_BYTE *)(v116 + 42) == 21 )
			//                     {
			//                       v118 = *(_QWORD ***)(v116 + 96);
			//                       if ( *v118 )
			//                       {
			//                         v119 = **v118 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                         v116 = sub_180039550(v119 / 92 + v119);
			//                       }
			//                       else
			//                       {
			//                         v116 = 0LL;
			//                       }
			//                     }
			//                     LODWORD(v176) = v117 + *(_DWORD *)(*(_QWORD *)(v116 + 104) + 32LL);
			//                     v120 = sub_1801B8ECC(
			//                              (unsigned int)&v176,
			//                              (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                              *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                              12,
			//                              (__int64)sub_1802C7760);
			//                     if ( !v120 )
			//                       goto LABEL_201;
			//                     v121 = *(unsigned int *)(v120 + 8);
			//                     if ( (_DWORD)v121 == -1 )
			//                       goto LABEL_201;
			//                     v106 = (void (__fastcall __noreturn **)())(v121 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			//                     goto LABEL_202;
			//                   default:
			//                     break;
			//                 }
			//               }
			//               byte_18D919ACA = 1;
			//             }
			//             memset(&call, 0, 40);
			//             *(Call *)&call.splatIdx = *IFix::Core::Call::Begin((Call *)&v178, 0LL);
			//             if ( v103.fields.anonObj )
			//               IFix::Core::Call::PushObject((Call *)&call, v103.fields.anonObj, 0LL);
			//             if ( !*(_QWORD *)&call.nro.m_untrackedHandle.m_handleObjectID )
			//               goto LABEL_278;
			//             *(_DWORD *)(*(_QWORD *)&call.nro.m_untrackedHandle.m_handleObjectID + 4LL) = v62;
			//             if ( !*(_QWORD *)&call.nro.m_untrackedHandle.m_handleObjectID )
			//               goto LABEL_278;
			//             **(_DWORD **)&call.nro.m_untrackedHandle.m_handleObjectID = 0;
			//             *(_QWORD *)&call.nro.m_untrackedHandle.m_handleObjectID += 12LL;
			//             virtualMachine = v103.fields.virtualMachine;
			//             if ( !virtualMachine )
			//               goto LABEL_278;
			//             IFix::Core::VirtualMachine::Execute(
			//               virtualMachine,
			//               v103.fields.methodId,
			//               (Call *)&call,
			//               (v103.fields.anonObj != 0LL) + 1,
			//               0,
			//               0LL);
			//             v124 = MethodInfo::IFix::Core::Call::GetAsType<System::ValueTuple<unsigned int,unsigned int,unsigned int>>;
			//             if ( !MethodInfo::IFix::Core::Call::GetAsType<System::ValueTuple<unsigned int,unsigned int,unsigned int>>.rgctx_data )
			//               sub_180041F40(MethodInfo::IFix::Core::Call::GetAsType<System::ValueTuple<unsigned int,unsigned int,unsigned int>>);
			//             Object = IFix::Core::Call::GetObject((Call *)&call, 0, 0LL);
			//             virtualMachine = (VirtualMachine *)v124.rgctx_data;
			//             klass = virtualMachine.klass;
			//             if ( ((__int64)virtualMachine.klass.vtable.Equals.methodPtr & 1) == 0 )
			//               sub_18003C700(virtualMachine.klass);
			//             if ( !Object )
			// LABEL_278:
			//               sub_1802DC2C8(virtualMachine, v122);
			//             v36 = (unsigned __int64)Object.klass;
			//             if ( Object.klass._0.element_class != klass._0.element_class )
			//               sub_1802DC21C(Object, klass);
			//             *(_QWORD *)arg2 = Object[1].klass;
			//             monitor = (uint32_t)Object[1].monitor;
			//             v128 = arg2[0];
			//           }
			//           else
			//           {
			// LABEL_217:
			//             v128 = v62 >> 28;
			//             arg2[0] = v62 >> 28;
			//             arg2[1] = v62 & 0x3FFF;
			//             monitor = (v62 >> 14) & 0x3FFF;
			//           }
			//           v129 = arg2[1];
			//           memset(&v192[4], 0, 96);
			//           v193 = 0;
			//           *(_DWORD *)v192 = v62;
			//           v186 = *(HGTerrainStreamingManager_TerrainLoadingSplat *)v192;
			//           v187 = *(_OWORD *)&v192[64];
			//           *(_OWORD *)v188 = *(_OWORD *)&v192[80];
			//           *(_QWORD *)&v188[16] = 0LL;
			//           if ( !TypeInfo::Beyond::UnSafeString._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::Beyond::UnSafeString, v36);
			//           v175 = Beyond::UnSafeString::Scope(0LL);
			//           ex = 0LL;
			//           v185 = &v175;
			//           try
			//           {
			//             atlasPageRootPath = (Object *)v2.fields.atlasPageRootPath;
			//             if ( !TypeInfo::Beyond::UnSafeString._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::Beyond::UnSafeString, v130);
			//             v132 = (UnSafeString *)sub_1830EBB40(
			//                                      (String *)"{0}/Terrain_{1}_{2}_{3}_H.asset",
			//                                      atlasPageRootPath,
			//                                      v128,
			//                                      v129,
			//                                      monitor,
			//                                      (__int64)MethodInfo::Beyond::UnSafeString::Format<System::String,unsigned int,unsigned int,unsigned int>);
			//             v134 = Beyond::UnSafeString::op_Implicit(v132, 0LL);
			//             if ( !TypeInfo::Beyond::Resource::HashStringPathProcessor._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::Beyond::Resource::HashStringPathProcessor, v133);
			//             v136.hash = sub_1824C2970((Beyond::Resource::HashStringPathProcessor *)v134);
			//             if ( !TypeInfo::Beyond::Resource::ResourceManager._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::Beyond::Resource::ResourceManager, v135);
			//             Beyond::Resource::ResourceManager::LoadAsync<System::Object>(
			//               (FAssetProxyHandle *)&v178,
			//               v136,
			//               RootCategory__Enum_Main,
			//               EResourceRequestPriority__Enum_Default,
			//               MethodInfo::Beyond::Resource::ResourceManager::LoadAsync<UnityEngine::Texture2D>);
			//             *(_OWORD *)&v186.diffuse.m_untrackedHandle.m_handleObjectID = *(_OWORD *)&v178.splatIdx;
			//             v186.diffuse.m_untrackedHandle.m_mainVersion = *(_DWORD *)&v178.diffuse.m_untrackedHandle.m_handleType;
			//             v137 = (UnSafeString *)sub_1830EBB40(
			//                                      (String *)"{0}/Terrain_{1}_{2}_{3}_N.tga",
			//                                      (Object *)v2.fields.atlasPageRootPath,
			//                                      v128,
			//                                      v129,
			//                                      monitor,
			//                                      (__int64)MethodInfo::Beyond::UnSafeString::Format<System::String,unsigned int,unsigned int,unsigned int>);
			//             v138 = Beyond::UnSafeString::op_Implicit(v137, 0LL);
			//             v139.hash = sub_1824C2970((Beyond::Resource::HashStringPathProcessor *)v138);
			//             Beyond::Resource::ResourceManager::LoadAsync<System::Object>(
			//               (FAssetProxyHandle *)&v178,
			//               v139,
			//               RootCategory__Enum_Main,
			//               EResourceRequestPriority__Enum_Default,
			//               MethodInfo::Beyond::Resource::ResourceManager::LoadAsync<UnityEngine::Texture2D>);
			//             *(_OWORD *)&v186.nro.m_untrackedHandle.m_handleObjectID = *(_OWORD *)&v178.splatIdx;
			//             v186.nro.m_untrackedHandle.m_mainVersion = *(_DWORD *)&v178.diffuse.m_untrackedHandle.m_handleType;
			//             v140 = (UnSafeString *)sub_1830EBB40(
			//                                      (String *)"{0}/Terrain_{1}_{2}_{3}_T.tga",
			//                                      (Object *)v2.fields.atlasPageRootPath,
			//                                      v128,
			//                                      v129,
			//                                      monitor,
			//                                      (__int64)MethodInfo::Beyond::UnSafeString::Format<System::String,unsigned int,unsigned int,unsigned int>);
			//             v141 = Beyond::UnSafeString::op_Implicit(v140, 0LL);
			//             v142.hash = sub_1824C2970((Beyond::Resource::HashStringPathProcessor *)v141);
			//             Beyond::Resource::ResourceManager::LoadAsync<System::Object>(
			//               (FAssetProxyHandle *)&v178,
			//               v142,
			//               RootCategory__Enum_Main,
			//               EResourceRequestPriority__Enum_Default,
			//               MethodInfo::Beyond::Resource::ResourceManager::LoadAsync<UnityEngine::Texture2D>);
			//             *(_OWORD *)&v186.cone.m_untrackedHandle.m_handleObjectID = *(_OWORD *)&v178.splatIdx;
			//             v186.cone.m_untrackedHandle.m_mainVersion = *(_DWORD *)&v178.diffuse.m_untrackedHandle.m_handleType;
			//             v143 = (UnSafeString *)sub_1830EBB40(
			//                                      (String *)"{0}/Terrain_{1}_{2}_{3}_S.tga",
			//                                      (Object *)v2.fields.atlasPageRootPath,
			//                                      v128,
			//                                      v129,
			//                                      monitor,
			//                                      (__int64)MethodInfo::Beyond::UnSafeString::Format<System::String,unsigned int,unsigned int,unsigned int>);
			//             v144 = Beyond::UnSafeString::op_Implicit(v143, 0LL);
			//             v145.hash = sub_1824C2970((Beyond::Resource::HashStringPathProcessor *)v144);
			//             Beyond::Resource::ResourceManager::LoadAsync<System::Object>(
			//               (FAssetProxyHandle *)&v178,
			//               v145,
			//               RootCategory__Enum_Main,
			//               EResourceRequestPriority__Enum_Default,
			//               MethodInfo::Beyond::Resource::ResourceManager::LoadAsync<UnityEngine::Texture2D>);
			//             *(_OWORD *)&v188[4] = *(_OWORD *)&v178.splatIdx;
			//             *(_DWORD *)&v188[20] = *(_DWORD *)&v178.diffuse.m_untrackedHandle.m_handleType;
			//             v146 = (UnSafeString *)sub_1830EBB40(
			//                                      (String *)"{0}/Terrain_{1}_{2}_{3}_A.tga",
			//                                      (Object *)v2.fields.atlasPageRootPath,
			//                                      v128,
			//                                      v129,
			//                                      monitor,
			//                                      (__int64)MethodInfo::Beyond::UnSafeString::Format<System::String,unsigned int,unsigned int,unsigned int>);
			//             v147 = Beyond::UnSafeString::op_Implicit(v146, 0LL);
			//             v148.hash = sub_1824C2970((Beyond::Resource::HashStringPathProcessor *)v147);
			//             Beyond::Resource::ResourceManager::LoadAsync<System::Object>(
			//               (FAssetProxyHandle *)&call,
			//               v148,
			//               RootCategory__Enum_Main,
			//               EResourceRequestPriority__Enum_Default,
			//               MethodInfo::Beyond::Resource::ResourceManager::LoadAsync<UnityEngine::Texture2D>);
			//             v150 = *(_OWORD *)&call.splatIdx;
			//             *(_OWORD *)&v178.splatIdx = *(_OWORD *)&call.splatIdx;
			//             v187 = *(_OWORD *)&call.splatIdx;
			//             *(_DWORD *)v188 = *(_DWORD *)&call.diffuse.m_untrackedHandle.m_handleType;
			//           }
			//           catch ( Il2CppExceptionWrapper *v195 )
			//           {
			//             ex = v195.ex;
			//             sub_18289B040(&v185);
			//             head = (unsigned __int64)ex;
			//             if ( ex )
			//               sub_18000F780(ex);
			//             v2 = this;
			//             v150 = v187;
			//             *(_OWORD *)&v178.splatIdx = v187;
			// LABEL_233:
			//             m_nodeAtlasPendingLoaded = v2.fields.m_nodeAtlasPendingLoaded;
			//             if ( !m_nodeAtlasPendingLoaded )
			//               goto LABEL_262;
			//             v153 = MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode>::Enqueue;
			//             v154 = m_nodeAtlasPendingLoaded.fields._array;
			//             if ( !v154 )
			//               goto LABEL_262;
			//             if ( m_nodeAtlasPendingLoaded.fields._size == v154.max_length.size )
			//             {
			//               v155 = m_nodeAtlasPendingLoaded.fields._array;
			//               v156 = 2 * v155.max_length.size;
			//               if ( v156 < v155.max_length.size + 4 )
			//                 v156 = v155.max_length.size + 4;
			//               if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode>::Enqueue.klass.rgctx_data[3].rgctxDataDummy
			//                     + 4) )
			//                 (*(void (**)(void))MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode>::Enqueue.klass.rgctx_data[3].rgctxDataDummy)();
			//               v157 = *((_QWORD *)v153.klass.rgctx_data[3].rgctxDataDummy + 4);
			//               v158 = *(_QWORD *)(*(_QWORD *)(v157 + 192) + 8LL);
			//               if ( (*(_BYTE *)(v158 + 312) & 1) == 0 )
			//                 sub_18003C700(*(_QWORD *)(*(_QWORD *)(v157 + 192) + 8LL));
			//               v159 = (Array *)il2cpp_array_new_specific_0(v158, (unsigned int)v156, v151, v149);
			//               if ( m_nodeAtlasPendingLoaded.fields._size > 0 )
			//               {
			//                 v160 = m_nodeAtlasPendingLoaded.fields._array;
			//                 head = (unsigned int)m_nodeAtlasPendingLoaded.fields._tail;
			//                 if ( m_nodeAtlasPendingLoaded.fields._head < (int)head )
			//                 {
			//                   size = m_nodeAtlasPendingLoaded.fields._size;
			//                   v162 = 0;
			//                   v164 = m_nodeAtlasPendingLoaded.fields._head;
			//                   v165 = (Array *)m_nodeAtlasPendingLoaded.fields._array;
			//                 }
			//                 else
			//                 {
			//                   if ( !v160 )
			//                     goto LABEL_262;
			//                   System::Array::Copy(
			//                     (Array *)v160,
			//                     m_nodeAtlasPendingLoaded.fields._head,
			//                     v159,
			//                     0,
			//                     v160.max_length.size - m_nodeAtlasPendingLoaded.fields._head,
			//                     0LL);
			//                   v161 = m_nodeAtlasPendingLoaded.fields._array;
			//                   if ( !v161 )
			//                     goto LABEL_262;
			//                   v162 = v161.max_length.size - m_nodeAtlasPendingLoaded.fields._head;
			//                   size = m_nodeAtlasPendingLoaded.fields._tail;
			//                   v164 = 0;
			//                   v165 = (Array *)m_nodeAtlasPendingLoaded.fields._array;
			//                 }
			//                 System::Array::Copy(v165, v164, v159, v162, size, 0LL);
			//               }
			//               m_nodeAtlasPendingLoaded.fields._array = (HGTerrainStreamingManager_TerrainLoadingNode__Array *)v159;
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v36 = 0x180000000LL
			//                     + 8 * ((((unsigned __int64)&m_nodeAtlasPendingLoaded.fields >> 12) & 0x1FFFFF) >> 6)
			//                     + 224948432;
			//                 _m_prefetchw((const void *)v36);
			//                 do
			//                   v166 = *(_QWORD *)v36;
			//                 while ( v166 != _InterlockedCompareExchange64(
			//                                   (volatile signed __int64 *)v36,
			//                                   *(_QWORD *)v36 | (1LL << (((unsigned __int64)&m_nodeAtlasPendingLoaded.fields >> 12) & 0x3F)),
			//                                   *(_QWORD *)v36) );
			//               }
			//               m_nodeAtlasPendingLoaded.fields._head = 0;
			//               v167 = 0;
			//               if ( m_nodeAtlasPendingLoaded.fields._size != v156 )
			//                 v167 = m_nodeAtlasPendingLoaded.fields._size;
			//               m_nodeAtlasPendingLoaded.fields._tail = v167;
			//               ++m_nodeAtlasPendingLoaded.fields._version;
			//               v150 = *(_OWORD *)&v178.splatIdx;
			//             }
			//             head = (unsigned __int64)m_nodeAtlasPendingLoaded.fields._array;
			//             if ( !head )
			//               goto LABEL_262;
			//             call = v186;
			//             v181 = v150;
			//             v182 = *(_OWORD *)v188;
			//             v183 = *(_QWORD *)&v188[16];
			//             sub_18008EFB0(head, m_nodeAtlasPendingLoaded.fields._tail, &call);
			//             if ( !*((_QWORD *)v153.klass.rgctx_data[4].rgctxDataDummy + 4) )
			//               (*(void (**)(void))v153.klass.rgctx_data[4].rgctxDataDummy)();
			//             v36 = (unsigned int)(m_nodeAtlasPendingLoaded.fields._tail + 1);
			//             head = (unsigned __int64)m_nodeAtlasPendingLoaded.fields._array;
			//             if ( !head )
			//               goto LABEL_262;
			//             v168 = 0;
			//             if ( (_DWORD)v36 != *(_DWORD *)(head + 24) )
			//               v168 = m_nodeAtlasPendingLoaded.fields._tail + 1;
			//             m_nodeAtlasPendingLoaded.fields._tail = v168;
			//             ++m_nodeAtlasPendingLoaded.fields._size;
			//             ++m_nodeAtlasPendingLoaded.fields._version;
			//             head = v174 + 1;
			//             continue;
			//           }
			//           break;
			//         }
			//         v151 = v175;
			//         if ( v175 )
			//         {
			//           sub_18005CC40(0LL, TypeInfo::System::IDisposable, v175);
			//           v150 = *(_OWORD *)&v178.splatIdx;
			//         }
			//         goto LABEL_233;
			//       }
			//       v42 = System::Collections::Generic::Queue<System::Int32Enum>::Dequeue(
			//               (Queue_1_System_Int32Enum_ *)v2.fields.m_splatsPendingToLoad,
			//               MethodInfo::System::Collections::Generic::Queue<int>::Dequeue);
			//       v45 = v42;
			//       if ( !v2.fields.m_splatLut )
			//         sub_180B536AC(v44, v43);
			//     }
			//     while ( !System::Collections::Generic::HashSet<int>::Contains(
			//                v2.fields.m_splatLut,
			//                v42,
			//                MethodInfo::System::Collections::Generic::HashSet<int>::Contains) );
			//     *(_OWORD *)&v186.splatIdx = 0LL;
			//     v186.splatIdx = v45;
			//     *(_OWORD *)&call.splatIdx = *(_OWORD *)&v186.splatIdx;
			//     memset(&call.diffuse.m_untrackedHandle.m_handleType, 0, 48);
			//     if ( !TypeInfo::Beyond::UnSafeString._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::Beyond::UnSafeString, v36);
			//     v175 = Beyond::UnSafeString::Scope(0LL);
			//     v176 = 0LL;
			//     v177 = &v175;
			//     try
			//     {
			//       v47 = (Object *)v2.fields.atlasPageRootPath;
			//       if ( !TypeInfo::Beyond::UnSafeString._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::Beyond::UnSafeString, v46);
			//       v48 = (UnSafeString *)sub_18868A0F4((String *)"{0}/Layers/LAYER_D_{1}.tga", v47, v45);
			//       v50 = Beyond::UnSafeString::op_Implicit(v48, 0LL);
			//       if ( !TypeInfo::Beyond::Resource::HashStringPathProcessor._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::Beyond::Resource::HashStringPathProcessor, v49);
			//       v52.hash = sub_1824C2970((Beyond::Resource::HashStringPathProcessor *)v50);
			//       if ( !TypeInfo::Beyond::Resource::ResourceManager._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::Beyond::Resource::ResourceManager, v51);
			//       Beyond::Resource::ResourceManager::LoadAsync<System::Object>(
			//         (FAssetProxyHandle *)&v178,
			//         v52,
			//         RootCategory__Enum_Main,
			//         EResourceRequestPriority__Enum_Default,
			//         MethodInfo::Beyond::Resource::ResourceManager::LoadAsync<UnityEngine::Texture2D>);
			//       *(_OWORD *)&call.diffuse.m_untrackedHandle.m_handleObjectID = *(_OWORD *)&v178.splatIdx;
			//       call.diffuse.m_untrackedHandle.m_mainVersion = *(_DWORD *)&v178.diffuse.m_untrackedHandle.m_handleType;
			//       v53 = (UnSafeString *)sub_18868A0F4(
			//                               (String *)"{0}/Layers/LAYER_N_{1}.tga",
			//                               (Object *)v2.fields.atlasPageRootPath,
			//                               v45);
			//       v54 = Beyond::UnSafeString::op_Implicit(v53, 0LL);
			//       v55.hash = sub_1824C2970((Beyond::Resource::HashStringPathProcessor *)v54);
			//       Beyond::Resource::ResourceManager::LoadAsync<System::Object>(
			//         (FAssetProxyHandle *)&v178,
			//         v55,
			//         RootCategory__Enum_Main,
			//         EResourceRequestPriority__Enum_Default,
			//         MethodInfo::Beyond::Resource::ResourceManager::LoadAsync<UnityEngine::Texture2D>);
			//       *(_OWORD *)&call.nro.m_untrackedHandle.m_handleObjectID = *(_OWORD *)&v178.splatIdx;
			//       call.nro.m_untrackedHandle.m_mainVersion = *(_DWORD *)&v178.diffuse.m_untrackedHandle.m_handleType;
			//       v56 = (UnSafeString *)sub_18868A0F4(
			//                               (String *)"{0}/Layers/LAYER_C_{1}.tga",
			//                               (Object *)v2.fields.atlasPageRootPath,
			//                               v45);
			//       v57 = Beyond::UnSafeString::op_Implicit(v56, 0LL);
			//       v58.hash = sub_1824C2970((Beyond::Resource::HashStringPathProcessor *)v57);
			//       Beyond::Resource::ResourceManager::LoadAsync<System::Object>(
			//         (FAssetProxyHandle *)&v178,
			//         v58,
			//         RootCategory__Enum_Main,
			//         EResourceRequestPriority__Enum_Default,
			//         MethodInfo::Beyond::Resource::ResourceManager::LoadAsync<UnityEngine::Texture2D>);
			//       *(_OWORD *)&call.cone.m_untrackedHandle.m_handleObjectID = *(_OWORD *)&v178.splatIdx;
			//       call.cone.m_untrackedHandle.m_mainVersion = *(_DWORD *)&v178.diffuse.m_untrackedHandle.m_handleType;
			//     }
			//     catch ( Il2CppExceptionWrapper *v194 )
			//     {
			//       v176 = v194.ex;
			//       sub_18289B040(&v177);
			//       if ( v176 )
			//         sub_18000F780(v176);
			//       v2 = this;
			//       v40 = v173;
			// LABEL_57:
			//       head = (unsigned __int64)v2.fields.m_splatsPendingLoaded;
			//       if ( !head )
			//         goto LABEL_262;
			//       v178 = call;
			//       System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat>::Enqueue(
			//         (Queue_1_HG_Rendering_Runtime_HGTerrainStreamingManager_TerrainLoadingSplat_ *)head,
			//         &v178,
			//         MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat>::Enqueue);
			//       v173 = ++v40;
			//       goto LABEL_39;
			//     }
			//     sub_18289B040(&v177);
			//     goto LABEL_57;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1932, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v8, v7);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			// }
			// 
		}

		public void GameplayUpdate()
		{
			// // Void GameplayUpdate()
			// void HG::Rendering::Runtime::HGTerrainStreamingManager::GameplayUpdate(
			//         HGTerrainStreamingManager *this,
			//         MethodInfo *method)
			// {
			//   void *m_splatLut; // rcx
			//   Queue_1_HG_Rendering_Runtime_HGTerrainStreamingManager_TerrainLoadingSplat_ *array; // rdx
			//   int v5; // edi
			//   Queue_1_HG_Rendering_Runtime_HGTerrainStreamingManager_TerrainLoadingSplat_ *m_splatsPendingLoaded; // rax
			//   int v7; // esi
			//   char v8; // di
			//   Queue_1_HG_Rendering_Runtime_HGTerrainStreamingManager_TerrainLoadingNode_ *m_nodeAtlasPendingLoaded; // rax
			//   Queue_1_HG_Rendering_Runtime_HGTerrainStreamingManager_TerrainLoadingNode_ *v10; // r14
			//   struct MethodInfo *v11; // r15
			//   __int64 head; // rax
			//   __m128i v13; // xmm6
			//   __int128 v14; // xmm4
			//   __int128 v15; // xmm3
			//   __int128 v16; // xmm2
			//   __int128 v17; // xmm1
			//   uint32_t nodeKey; // edi
			//   HGRenderPathBase_HGRenderPathResources *v19; // rdx
			//   PassConstructorID__Enum__Array *v20; // r8
			//   HGCamera *v21; // r9
			//   Object *v22; // rax
			//   HGRenderPathBase_HGRenderPathResources *v23; // rdx
			//   PassConstructorID__Enum__Array *v24; // r8
			//   HGCamera *v25; // r9
			//   Object *v26; // rax
			//   HGRenderPathBase_HGRenderPathResources *v27; // rdx
			//   PassConstructorID__Enum__Array *v28; // r8
			//   HGCamera *v29; // r9
			//   Object *v30; // rax
			//   HGRenderPathBase_HGRenderPathResources *v31; // rdx
			//   PassConstructorID__Enum__Array *v32; // r8
			//   HGCamera *v33; // r9
			//   Object *v34; // rax
			//   HGRenderPathBase_HGRenderPathResources *v35; // rdx
			//   PassConstructorID__Enum__Array *v36; // r8
			//   HGCamera *v37; // r9
			//   Object *v38; // rax
			//   __int64 (__fastcall *v39)(_QWORD, __int128 *); // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int32_t splatIdx; // esi
			//   HGRenderPathBase_HGRenderPathResources *v42; // rdx
			//   PassConstructorID__Enum__Array *v43; // r8
			//   HGCamera *v44; // r9
			//   Object *v45; // rax
			//   HGRenderPathBase_HGRenderPathResources *v46; // rdx
			//   PassConstructorID__Enum__Array *v47; // r8
			//   HGCamera *v48; // r9
			//   Object *v49; // rax
			//   HGRenderPathBase_HGRenderPathResources *v50; // rdx
			//   PassConstructorID__Enum__Array *v51; // r8
			//   HGCamera *v52; // r9
			//   Object *v53; // rax
			//   HashSet_1_System_Int32_ *v54; // rcx
			//   TerrainSplatPayload v55; // [rsp+20h] [rbp-E0h] BYREF
			//   __int128 v56; // [rsp+38h] [rbp-C8h] BYREF
			//   __int128 v57; // [rsp+48h] [rbp-B8h] BYREF
			//   Object *v58; // [rsp+58h] [rbp-A8h] BYREF
			//   HGTerrainStreamingManager_TerrainLoadingSplat v59; // [rsp+60h] [rbp-A0h] BYREF
			//   HGTerrainStreamingManager_TerrainLoadingNode v60; // [rsp+A0h] [rbp-60h] BYREF
			//   HGTerrainStreamingManager_TerrainLoadingNode item; // [rsp+110h] [rbp+10h] BYREF
			//   TerrainSplatPayload payload; // [rsp+180h] [rbp+80h] BYREF
			// 
			//   if ( !byte_18D8EDB74 )
			//   {
			//     sub_18003C530(&MethodInfo::Beyond::Resource::FAssetProxyHandle::Get<UnityEngine::Texture2D>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<unsigned int>::Contains);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<int>::Contains);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<unsigned int>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<int>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat>::Dequeue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode>::Dequeue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat>::Peek);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode>::Peek);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode>::get_Count);
			//     byte_18D8EDB74 = 1;
			//   }
			//   memset(&v59, 0, sizeof(v59));
			//   v58 = 0LL;
			//   memset(&v55, 0, sizeof(v55));
			//   memset(&v60, 0, sizeof(v60));
			//   v56 = 0LL;
			//   v57 = 0LL;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   m_splatLut = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     m_splatLut = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   array = (Queue_1_HG_Rendering_Runtime_HGTerrainStreamingManager_TerrainLoadingSplat_ *)**((_QWORD **)m_splatLut + 23);
			//   if ( !array )
			//     goto LABEL_39;
			//   if ( array.fields._head <= 1942 )
			//     goto LABEL_9;
			//   if ( !*((_DWORD *)m_splatLut + 56) )
			//   {
			//     il2cpp_runtime_class_init_0(m_splatLut, array);
			//     m_splatLut = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   array = (Queue_1_HG_Rendering_Runtime_HGTerrainStreamingManager_TerrainLoadingSplat_ *)**((_QWORD **)m_splatLut + 23);
			//   if ( !array )
			// LABEL_39:
			//     sub_180B536AC(m_splatLut, array);
			//   if ( array.fields._head <= 0x796u )
			// LABEL_40:
			//     sub_180070270(m_splatLut, array);
			//   if ( array[324].fields._array )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1942, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			//     goto LABEL_39;
			//   }
			// LABEL_9:
			//   v5 = 0;
			//   while ( 1 )
			//   {
			//     m_splatsPendingLoaded = this.fields.m_splatsPendingLoaded;
			//     if ( !m_splatsPendingLoaded )
			//       goto LABEL_39;
			//     if ( !m_splatsPendingLoaded.fields._size || v5 >= 2 )
			//       break;
			//     System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat>::Peek(
			//       (HGTerrainStreamingManager_TerrainLoadingSplat *)&item,
			//       this.fields.m_splatsPendingLoaded,
			//       MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat>::Peek);
			//     m_splatLut = this.fields.m_splatLut;
			//     *(_OWORD *)&v59.diffuse.m_untrackedHandle.m_handleType = *(_OWORD *)&item.heightmap.m_untrackedHandle.m_handleType;
			//     *(_OWORD *)&v59.splatIdx = *(_OWORD *)&item.nodeKey;
			//     *(_OWORD *)&v59.cone.m_untrackedHandle.m_assetProxyID._objectIntID_k__BackingField = *(_OWORD *)&item.tintColor.m_untrackedHandle.m_assetProxyID._objectIntID_k__BackingField;
			//     *(_OWORD *)&v59.nro.m_untrackedHandle.m_assetProxyObj.m_handleID = *(_OWORD *)&item.normalmap.m_untrackedHandle.m_assetProxyObj.m_handleID;
			//     if ( !m_splatLut )
			//       goto LABEL_39;
			//     if ( System::Collections::Generic::HashSet<int>::Contains(
			//            (HashSet_1_System_Int32_ *)m_splatLut,
			//            _mm_cvtsi128_si32(*(__m128i *)&item.nodeKey),
			//            MethodInfo::System::Collections::Generic::HashSet<int>::Contains) )
			//     {
			//       if ( !HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat::AllAssetReady(&v59, 0LL) )
			//         break;
			//       splatIdx = v59.splatIdx;
			//       memset(&v55, 0, sizeof(v55));
			//       if ( Beyond::Resource::FAssetProxyHandle::IsInvalid(&v59.diffuse, 0LL) )
			//         v45 = 0LL;
			//       else
			//         v45 = Beyond::Resource::FAssetProxyHandle::Get<System::Object>(
			//                 &v59.diffuse,
			//                 MethodInfo::Beyond::Resource::FAssetProxyHandle::Get<UnityEngine::Texture2D>);
			//       v55.diffuseTex = (Texture2D *)v45;
			//       ((void (__stdcall *)(HGRenderPathScene *, HGRenderPathBase_HGRenderPathResources *, PassConstructorID__Enum__Array *, HGCamera *))sub_1800054D0)(
			//         (HGRenderPathScene *)&v55,
			//         v42,
			//         v43,
			//         v44);
			//       if ( Beyond::Resource::FAssetProxyHandle::IsInvalid(&v59.nro, 0LL) )
			//         v49 = 0LL;
			//       else
			//         v49 = Beyond::Resource::FAssetProxyHandle::Get<System::Object>(
			//                 &v59.nro,
			//                 MethodInfo::Beyond::Resource::FAssetProxyHandle::Get<UnityEngine::Texture2D>);
			//       v55.normalROTex = (Texture2D *)v49;
			//       ((void (__stdcall *)(HGRenderPathScene *, HGRenderPathBase_HGRenderPathResources *, PassConstructorID__Enum__Array *, HGCamera *, MethodInfo *))sub_1800054D0)(
			//         (HGRenderPathScene *)&v55.normalROTex,
			//         v46,
			//         v47,
			//         v48,
			//         (MethodInfo *)v55.diffuseTex);
			//       if ( Beyond::Resource::FAssetProxyHandle::IsInvalid(&v59.cone, 0LL) )
			//         v53 = 0LL;
			//       else
			//         v53 = Beyond::Resource::FAssetProxyHandle::Get<System::Object>(
			//                 &v59.cone,
			//                 MethodInfo::Beyond::Resource::FAssetProxyHandle::Get<UnityEngine::Texture2D>);
			//       v55.coneMapTex = (Texture2D *)v53;
			//       sub_1800054D0(
			//         (HGRenderPathScene *)&v55.coneMapTex,
			//         v50,
			//         v51,
			//         v52,
			//         (MethodInfo *)v55.diffuseTex,
			//         (MethodInfo *)v55.normalROTex);
			//       payload = v55;
			//       UnityEngine::HyperGryph::HGTerrainManager::StreamingInTerrainSplat_Injected(splatIdx, &payload, 0LL);
			//       ++v5;
			//       HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat::DisposeAllAsset(&v59, 0LL);
			//       v54 = this.fields.m_splatLut;
			//       if ( !v54
			//         || (System::Collections::Generic::HashSet<int>::Remove(
			//               v54,
			//               v59.splatIdx,
			//               MethodInfo::System::Collections::Generic::HashSet<int>::Remove),
			//             (array = this.fields.m_splatsPendingLoaded) == 0LL) )
			//       {
			//         sub_180B536AC(v54, array);
			//       }
			//     }
			//     else
			//     {
			//       HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat::DisposeAllAsset(&v59, 0LL);
			//       array = this.fields.m_splatsPendingLoaded;
			//       if ( !array )
			//         goto LABEL_39;
			//     }
			//     System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat>::Dequeue(
			//       (HGTerrainStreamingManager_TerrainLoadingSplat *)&item,
			//       array,
			//       MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat>::Dequeue);
			//   }
			//   v7 = 0;
			//   v8 = 1;
			//   while ( 1 )
			//   {
			//     m_nodeAtlasPendingLoaded = this.fields.m_nodeAtlasPendingLoaded;
			//     if ( !m_nodeAtlasPendingLoaded )
			//       goto LABEL_39;
			//     if ( !m_nodeAtlasPendingLoaded.fields._size || v7 >= 2 )
			//       break;
			//     v10 = this.fields.m_nodeAtlasPendingLoaded;
			//     v11 = MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode>::Peek;
			//     if ( !m_nodeAtlasPendingLoaded.fields._size )
			//     {
			//       if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode>::Peek.klass.rgctx_data[7].rgctxDataDummy
			//             + 4) )
			//         (*(void (**)(void))MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode>::Peek.klass.rgctx_data[7].rgctxDataDummy)();
			//       System::Collections::Generic::Queue<Rewired::Platforms::XboxOne::XboxOneInputSource::LnyDTHuLkKGdjkrEtCSrpMBFdXrlA>::ThrowForEmptyQueue(
			//         (Queue_1_Rewired_Platforms_XboxOne_XboxOneInputSource_LnyDTHuLkKGdjkrEtCSrpMBFdXrlA_ *)v10,
			//         (MethodInfo *)v11.klass.rgctx_data[7].rgctxDataDummy);
			//     }
			//     array = (Queue_1_HG_Rendering_Runtime_HGTerrainStreamingManager_TerrainLoadingSplat_ *)m_nodeAtlasPendingLoaded.fields._array;
			//     if ( !array )
			//       goto LABEL_39;
			//     head = m_nodeAtlasPendingLoaded.fields._head;
			//     if ( (unsigned int)head >= array.fields._head )
			//       goto LABEL_40;
			//     v13 = *(__m128i *)(&array.fields._size + 26 * head);
			//     *(__m128i *)&v60.nodeKey = v13;
			//     *(_OWORD *)&v60.heightmap.m_untrackedHandle.m_handleType = *(_OWORD *)(&array[1].klass + 13 * head);
			//     v14 = *(_OWORD *)(&array[1].fields._array + 13 * head);
			//     *(_OWORD *)&item.heightmap.m_untrackedHandle.m_handleType = *(_OWORD *)&v60.heightmap.m_untrackedHandle.m_handleType;
			//     *(_OWORD *)&v60.normalmap.m_untrackedHandle.m_assetProxyObj.m_handleID = v14;
			//     v15 = *(_OWORD *)(&array[1].fields._size + 26 * head);
			//     *(_OWORD *)&item.normalmap.m_untrackedHandle.m_assetProxyObj.m_handleID = v14;
			//     *(_OWORD *)&v60.tintColor.m_untrackedHandle.m_assetProxyID._objectIntID_k__BackingField = v15;
			//     v16 = *(_OWORD *)(&array[2].klass + 13 * head);
			//     *(_OWORD *)&item.tintColor.m_untrackedHandle.m_assetProxyID._objectIntID_k__BackingField = v15;
			//     *(_OWORD *)&v60.albedo.m_untrackedHandle.m_handleObjectID = v16;
			//     v17 = *(_OWORD *)(&array[2].fields._array + 13 * head);
			//     *(_OWORD *)&item.albedo.m_untrackedHandle.m_handleObjectID = v16;
			//     *(_OWORD *)&v60.albedo.m_untrackedHandle.m_mainVersion = v17;
			//     m_splatLut = this.fields.m_nodeLut;
			//     *(_QWORD *)&v60.splatCtrl.m_untrackedHandle.m_handleType = *((_QWORD *)&array[2].fields._size + 13 * head);
			//     *(_OWORD *)&item.albedo.m_untrackedHandle.m_mainVersion = v17;
			//     *(_QWORD *)&item.splatCtrl.m_untrackedHandle.m_handleType = *(_QWORD *)&v60.splatCtrl.m_untrackedHandle.m_handleType;
			//     if ( !m_splatLut )
			//       goto LABEL_39;
			//     if ( System::Collections::Generic::HashSet<unsigned int>::Contains(
			//            (HashSet_1_System_UInt32_ *)m_splatLut,
			//            _mm_cvtsi128_si32(v13),
			//            MethodInfo::System::Collections::Generic::HashSet<unsigned int>::Contains) )
			//     {
			//       if ( !HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode::AllAssetReady(&v60, 0LL) )
			//         break;
			//       nodeKey = v60.nodeKey;
			//       v58 = 0LL;
			//       v56 = 0LL;
			//       v57 = 0LL;
			//       if ( Beyond::Resource::FAssetProxyHandle::IsInvalid(&v60.heightmap, 0LL) )
			//         v22 = 0LL;
			//       else
			//         v22 = Beyond::Resource::FAssetProxyHandle::Get<System::Object>(
			//                 &v60.heightmap,
			//                 MethodInfo::Beyond::Resource::FAssetProxyHandle::Get<UnityEngine::Texture2D>);
			//       *(_QWORD *)&v56 = v22;
			//       sub_1800054D0(
			//         (HGRenderPathScene *)&v56,
			//         v19,
			//         v20,
			//         v21,
			//         (MethodInfo *)v55.diffuseTex,
			//         (MethodInfo *)v55.normalROTex);
			//       if ( Beyond::Resource::FAssetProxyHandle::IsInvalid(&v60.normalmap, 0LL) )
			//         v26 = 0LL;
			//       else
			//         v26 = Beyond::Resource::FAssetProxyHandle::Get<System::Object>(
			//                 &v60.normalmap,
			//                 MethodInfo::Beyond::Resource::FAssetProxyHandle::Get<UnityEngine::Texture2D>);
			//       *((_QWORD *)&v56 + 1) = v26;
			//       sub_1800054D0(
			//         (HGRenderPathScene *)((char *)&v56 + 8),
			//         v23,
			//         v24,
			//         v25,
			//         (MethodInfo *)v55.diffuseTex,
			//         (MethodInfo *)v55.normalROTex);
			//       if ( Beyond::Resource::FAssetProxyHandle::IsInvalid(&v60.tintColor, 0LL) )
			//         v30 = 0LL;
			//       else
			//         v30 = Beyond::Resource::FAssetProxyHandle::Get<System::Object>(
			//                 &v60.tintColor,
			//                 MethodInfo::Beyond::Resource::FAssetProxyHandle::Get<UnityEngine::Texture2D>);
			//       *(_QWORD *)&v57 = v30;
			//       sub_1800054D0(
			//         (HGRenderPathScene *)&v57,
			//         v27,
			//         v28,
			//         v29,
			//         (MethodInfo *)v55.diffuseTex,
			//         (MethodInfo *)v55.normalROTex);
			//       if ( Beyond::Resource::FAssetProxyHandle::IsInvalid(&v60.splatCtrl, 0LL) )
			//         v34 = 0LL;
			//       else
			//         v34 = Beyond::Resource::FAssetProxyHandle::Get<System::Object>(
			//                 &v60.splatCtrl,
			//                 MethodInfo::Beyond::Resource::FAssetProxyHandle::Get<UnityEngine::Texture2D>);
			//       *((_QWORD *)&v57 + 1) = v34;
			//       sub_1800054D0(
			//         (HGRenderPathScene *)((char *)&v57 + 8),
			//         v31,
			//         v32,
			//         v33,
			//         (MethodInfo *)v55.diffuseTex,
			//         (MethodInfo *)v55.normalROTex);
			//       if ( Beyond::Resource::FAssetProxyHandle::IsInvalid(&v60.albedo, 0LL) )
			//         v38 = 0LL;
			//       else
			//         v38 = Beyond::Resource::FAssetProxyHandle::Get<System::Object>(
			//                 &v60.albedo,
			//                 MethodInfo::Beyond::Resource::FAssetProxyHandle::Get<UnityEngine::Texture2D>);
			//       v58 = v38;
			//       sub_1800054D0(
			//         (HGRenderPathScene *)&v58,
			//         v35,
			//         v36,
			//         v37,
			//         (MethodInfo *)v55.diffuseTex,
			//         (MethodInfo *)v55.normalROTex);
			//       v39 = (__int64 (__fastcall *)(_QWORD, __int128 *))qword_18D8F5C48;
			//       if ( !qword_18D8F5C48 )
			//       {
			//         v39 = (__int64 (__fastcall *)(_QWORD, __int128 *))sub_180017470(
			//                                                             "UnityEngine.HyperGryph.HGTerrainManager::StreamingInTerrainN"
			//                                                             "odePayload(System.UInt32,UnityEngine.HyperGryph.TerrainNodePayload&)");
			//         qword_18D8F5C48 = (__int64)v39;
			//       }
			//       v8 = v39(nodeKey, &v56);
			//       ++v7;
			//       HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode::DisposeAllAsset(&v60, 0LL);
			//       m_splatLut = this.fields.m_nodeLut;
			//       if ( !m_splatLut )
			//         goto LABEL_39;
			//       System::Collections::Generic::HashSet<unsigned int>::Remove(
			//         (HashSet_1_System_UInt32_ *)m_splatLut,
			//         v60.nodeKey,
			//         MethodInfo::System::Collections::Generic::HashSet<unsigned int>::Remove);
			//       array = (Queue_1_HG_Rendering_Runtime_HGTerrainStreamingManager_TerrainLoadingSplat_ *)this.fields.m_nodeAtlasPendingLoaded;
			//       if ( !array )
			//         goto LABEL_39;
			//     }
			//     else
			//     {
			//       HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode::DisposeAllAsset(&v60, 0LL);
			//       array = (Queue_1_HG_Rendering_Runtime_HGTerrainStreamingManager_TerrainLoadingSplat_ *)this.fields.m_nodeAtlasPendingLoaded;
			//       if ( !array )
			//         goto LABEL_39;
			//     }
			//     System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode>::Dequeue(
			//       &item,
			//       (Queue_1_HG_Rendering_Runtime_HGTerrainStreamingManager_TerrainLoadingNode_ *)array,
			//       MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode>::Dequeue);
			//   }
			//   this.fields.m_streamingResult = v8;
			// }
			// 
		}

		public void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::Runtime::HGTerrainStreamingManager::Dispose(HGTerrainStreamingManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1912, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1912, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGTerrainStreamingManager::CleanupPendingRequests(this, 0LL);
			//   }
			// }
			// 
		}

		public void CleanupPendingRequests()
		{
			// // Void CleanupPendingRequests()
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::HGTerrainStreamingManager::CleanupPendingRequests(
			//         HGTerrainStreamingManager *this,
			//         MethodInfo *method)
			// {
			//   HGTerrainStreamingManager *v2; // rsi
			//   HGRenderPathBase_HGRenderPathResources *v3; // rdx
			//   PassConstructorID__Enum__Array *v4; // r8
			//   HGCamera *v5; // r9
			//   HGRenderPathBase_HGRenderPathResources *v6; // rdx
			//   __int64 v7; // rcx
			//   PassConstructorID__Enum__Array *v8; // r8
			//   HGCamera *v9; // r9
			//   Queue_1_HG_Rendering_Runtime_HGTerrainStreamingManager_TerrainLoadingSplat_ *m_splatsPendingLoaded; // rbx
			//   __int64 *v11; // rdx
			//   struct MethodInfo *v12; // r14
			//   MethodInfo *m_splatsPendingToLoad; // rcx
			//   __int64 v14; // r8
			//   __int64 v15; // r9
			//   __int64 v16; // rdx
			//   int v17; // ecx
			//   signed int v18; // eax
			//   __int64 v19; // rcx
			//   MethodInfo *v20; // rax
			//   HashSet_1_System_Int32_ *m_splatLut; // rbx
			//   Int32__Array *buckets; // r8
			//   void (*v23)(void); // rax
			//   Queue_1_HG_Rendering_Runtime_HGTerrainStreamingManager_TerrainLoadingNode_ *m_nodeAtlasPendingLoaded; // r9
			//   __int64 v25; // rtt
			//   struct MethodInfo *v26; // r14
			//   __int64 v27; // r8
			//   __int64 v28; // r9
			//   __int64 v29; // rdx
			//   int v30; // ecx
			//   signed int v31; // eax
			//   __int64 v32; // rcx
			//   __int64 v33; // rax
			//   MethodInfo *v34; // rax
			//   void (*v35)(void); // rax
			//   HashSet_1_System_UInt32_ *m_nodeLut; // rbx
			//   Int32__Array *v37; // r8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v39; // rdx
			//   __int64 v40; // rcx
			//   __int64 v41; // rax
			//   __int64 v42; // rax
			//   __int64 v43; // rax
			//   ProtocolViolationException *v44; // rbx
			//   String *v45; // rax
			//   __int64 v46; // rax
			//   __int64 v47; // rax
			//   __int64 v48; // rax
			//   __int64 v49; // rax
			//   ProtocolViolationException *v50; // rbx
			//   String *v51; // rax
			//   __int64 v52; // rax
			//   _BYTE v53[32]; // [rsp+0h] [rbp-258h] BYREF
			//   MethodInfo *ex; // [rsp+20h] [rbp-238h]
			//   MethodInfo *v55; // [rsp+28h] [rbp-230h]
			//   __int128 v56; // [rsp+30h] [rbp-228h] BYREF
			//   __int128 v57; // [rsp+40h] [rbp-218h]
			//   __int128 v58; // [rsp+50h] [rbp-208h]
			//   __int128 v59; // [rsp+60h] [rbp-1F8h]
			//   __int128 v60; // [rsp+70h] [rbp-1E8h]
			//   __int128 v61; // [rsp+80h] [rbp-1D8h]
			//   __int128 v62; // [rsp+90h] [rbp-1C8h]
			//   __int64 v63; // [rsp+A0h] [rbp-1B8h]
			//   __int128 v64; // [rsp+B0h] [rbp-1A8h] BYREF
			//   __int128 v65; // [rsp+C0h] [rbp-198h]
			//   __int128 v66; // [rsp+D0h] [rbp-188h]
			//   __int128 v67; // [rsp+E0h] [rbp-178h]
			//   __int128 v68; // [rsp+F0h] [rbp-168h]
			//   _BYTE v69[104]; // [rsp+100h] [rbp-158h] BYREF
			//   __int128 v70; // [rsp+168h] [rbp-F0h]
			//   HGTerrainStreamingManager_TerrainLoadingNode v71; // [rsp+180h] [rbp-D8h] BYREF
			//   HGTerrainStreamingManager_TerrainLoadingSplat v72; // [rsp+1F0h] [rbp-68h] BYREF
			//   Il2CppExceptionWrapper *v73; // [rsp+230h] [rbp-28h] BYREF
			//   Il2CppExceptionWrapper *v74; // [rsp+238h] [rbp-20h] BYREF
			// 
			//   v2 = this;
			//   if ( !byte_18D8EDB75 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue_1_T_::Enumerator<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue_1_T_::Enumerator<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue_1_T_::Enumerator<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue_1_T_::Enumerator<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue_1_T_::Enumerator<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue_1_T_::Enumerator<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<unsigned int>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<int>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<unsigned int>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<int>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Queue<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat>::GetEnumerator);
			//     byte_18D8EDB75 = 1;
			//   }
			//   memset(&v72, 0, sizeof(v72));
			//   v56 = 0LL;
			//   v57 = 0LL;
			//   v58 = 0LL;
			//   v59 = 0LL;
			//   v60 = 0LL;
			//   v61 = 0LL;
			//   v62 = 0LL;
			//   v63 = 0LL;
			//   memset(&v71, 0, sizeof(v71));
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1913, 0LL) )
			//   {
			//     v2.fields.atlasPageRootPath = 0LL;
			//     sub_1800054D0((HGRenderPathScene *)&v2.fields.atlasPageRootPath, v3, v4, v5, ex, v55);
			//     m_splatsPendingLoaded = v2.fields.m_splatsPendingLoaded;
			//     if ( !m_splatsPendingLoaded )
			//       sub_180B536AC(v7, v6);
			//     memset(&v69[8], 0, 72);
			//     *(_QWORD *)v69 = m_splatsPendingLoaded;
			//     sub_1800054D0((HGRenderPathScene *)v69, v6, v8, v9, ex, v55);
			//     *(_DWORD *)&v69[8] = m_splatsPendingLoaded.fields._version;
			//     *(_DWORD *)&v69[12] = -1;
			//     memset(&v69[16], 0, 64);
			//     v64 = *(_OWORD *)v69;
			//     v65 = 0LL;
			//     v66 = 0LL;
			//     v67 = 0LL;
			//     v68 = 0LL;
			//     ex = 0LL;
			//     v55 = (MethodInfo *)&v64;
			//     try
			//     {
			//       while ( 1 )
			//       {
			//         v12 = MethodInfo::System::Collections::Generic::Queue_1_T_::Enumerator<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat>::MoveNext;
			//         m_splatsPendingToLoad = (MethodInfo *)v64;
			//         if ( !(_QWORD)v64 )
			//           sub_1802DC2C8(0LL, v11);
			//         if ( DWORD2(v64) != *(_DWORD *)(v64 + 36) )
			//         {
			//           v43 = sub_18000F7E0(&TypeInfo::System::InvalidOperationException);
			//           v44 = (ProtocolViolationException *)sub_18004C870(v43);
			//           sub_180002BF0(v44);
			//           v45 = (String *)sub_18000F7E0(&off_18D556BA0);
			//           System::Net::ProtocolViolationException::ProtocolViolationException(v44, v45, 0LL);
			//           sub_18000F7C0(v44, v12);
			//         }
			//         if ( HIDWORD(v64) == -2 )
			//           break;
			//         v14 = (unsigned int)(HIDWORD(v64) + 1);
			//         HIDWORD(v64) = v14;
			//         if ( (_DWORD)v14 == *(_DWORD *)(v64 + 32) )
			//         {
			//           HIDWORD(v64) = -2;
			//           v65 = 0LL;
			//           v66 = 0LL;
			//           v67 = 0LL;
			//           v68 = 0LL;
			//           goto LABEL_87;
			//         }
			//         v15 = *(_QWORD *)(v64 + 16);
			//         if ( !v15 )
			//           sub_1802DC2C8(v64, v11);
			//         v16 = *(unsigned int *)(v15 + 24);
			//         v17 = v14 + *(_DWORD *)(v64 + 24);
			//         v18 = v17 - v16;
			//         if ( v17 < (int)v16 )
			//           v18 = v14 + *(_DWORD *)(v64 + 24);
			//         if ( v18 >= (unsigned int)v16 )
			//           sub_180070260(v18, v16, v14, v15);
			//         v19 = (__int64)v18 << 6;
			//         v65 = *(_OWORD *)(v19 + v15 + 32);
			//         v66 = *(_OWORD *)(v19 + v15 + 48);
			//         v67 = *(_OWORD *)(v19 + v15 + 64);
			//         v68 = *(_OWORD *)(v19 + v15 + 80);
			//         if ( (int)v14 < 0 )
			//         {
			//           v41 = sub_18010B520(MethodInfo::System::Collections::Generic::Queue_1_T_::Enumerator<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat>::get_Current.klass);
			//           v42 = sub_180328104(*(_QWORD *)(v41 + 192), 0LL);
			//           sub_18052E9E4(&v64, v42);
			//         }
			//         v72 = *(HGTerrainStreamingManager_TerrainLoadingSplat *)(v19 + v15 + 32);
			//         HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat::DisposeAllAsset(&v72, 0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v73 )
			//     {
			//       v11 = (__int64 *)v53;
			//       ex = (MethodInfo *)v73.ex;
			//       v20 = v55;
			//       HIDWORD(v55.virtualMethodPointer) = -2;
			//       *(_OWORD *)&v20.invoker_method = 0LL;
			//       *(_OWORD *)&v20.klass = 0LL;
			//       *(_OWORD *)&v20.parameters = 0LL;
			//       *(_OWORD *)&v20.genericMethod = 0LL;
			//       m_splatsPendingToLoad = ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v2 = this;
			// LABEL_20:
			//       m_splatLut = v2.fields.m_splatLut;
			//       if ( !m_splatLut )
			//         goto LABEL_83;
			//       if ( m_splatLut.fields._lastIndex > 0 )
			//       {
			//         System::Array::Clear((Array *)m_splatLut.fields._slots, 0, m_splatLut.fields._lastIndex, 0LL);
			//         buckets = m_splatLut.fields._buckets;
			//         if ( !buckets )
			//           goto LABEL_83;
			//         System::Array::Clear((Array *)m_splatLut.fields._buckets, 0, buckets.max_length.size, 0LL);
			//         *(_QWORD *)&m_splatLut.fields._count = 0LL;
			//         m_splatLut.fields._freeList = -1;
			//       }
			//       ++m_splatLut.fields._version;
			//       m_splatsPendingToLoad = (MethodInfo *)v2.fields.m_splatsPendingToLoad;
			//       if ( !m_splatsPendingToLoad )
			//         goto LABEL_83;
			//       if ( LODWORD(m_splatsPendingToLoad.klass) )
			//         LODWORD(m_splatsPendingToLoad.klass) = 0;
			//       m_splatsPendingToLoad.name = 0LL;
			//       ++HIDWORD(m_splatsPendingToLoad.klass);
			//       m_splatsPendingToLoad = (MethodInfo *)v2.fields.m_splatsPendingLoaded;
			//       if ( !m_splatsPendingToLoad )
			//         goto LABEL_83;
			//       if ( LODWORD(m_splatsPendingToLoad.klass) )
			//         LODWORD(m_splatsPendingToLoad.klass) = 0;
			//       m_splatsPendingToLoad.name = 0LL;
			//       ++HIDWORD(m_splatsPendingToLoad.klass);
			//       v23 = (void (*)(void))qword_18D8F5C58;
			//       if ( !qword_18D8F5C58 )
			//       {
			//         v23 = (void (*)(void))il2cpp_resolve_icall_0("UnityEngine.HyperGryph.HGTerrainManager::ResetLoadingStatusForAllSplats()");
			//         if ( !v23 )
			//         {
			//           v46 = sub_1802DBBE8("UnityEngine.HyperGryph.HGTerrainManager::ResetLoadingStatusForAllSplats()");
			//           sub_18000F750(v46, 0LL);
			//         }
			//         qword_18D8F5C58 = (__int64)v23;
			//       }
			//       v23();
			//       m_nodeAtlasPendingLoaded = v2.fields.m_nodeAtlasPendingLoaded;
			//       if ( !m_nodeAtlasPendingLoaded )
			// LABEL_83:
			//         sub_1802DC2C8(m_splatsPendingToLoad, v11);
			//       memset(&v69[8], 0, 96);
			//       v70 = 0LL;
			//       *(_QWORD *)v69 = m_nodeAtlasPendingLoaded;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v11 = &qword_18D6870D0[(((unsigned __int64)v69 >> 12) & 0x1FFFFF) >> 6];
			//         _m_prefetchw(v11);
			//         do
			//           v25 = *v11;
			//         while ( v25 != _InterlockedCompareExchange64(v11, *v11 | (1LL << (((unsigned __int64)v69 >> 12) & 0x3F)), *v11) );
			//       }
			//       *(_DWORD *)&v69[8] = m_nodeAtlasPendingLoaded.fields._version;
			//       *(_DWORD *)&v69[12] = -1;
			//       *((_QWORD *)&v70 + 1) = 0LL;
			//       v56 = *(_OWORD *)v69;
			//       v57 = 0LL;
			//       v58 = 0LL;
			//       v59 = 0LL;
			//       v60 = 0LL;
			//       v61 = 0LL;
			//       v62 = 0LL;
			//       v63 = 0LL;
			//       ex = 0LL;
			//       v55 = (MethodInfo *)&v56;
			//       try
			//       {
			//         while ( 1 )
			//         {
			//           v26 = MethodInfo::System::Collections::Generic::Queue_1_T_::Enumerator<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode>::MoveNext;
			//           if ( !(_QWORD)v56 )
			//             sub_1802DC2C8(0LL, v11);
			//           if ( DWORD2(v56) != *(_DWORD *)(v56 + 36) )
			//           {
			//             v49 = sub_18000F7E0(&TypeInfo::System::InvalidOperationException);
			//             v50 = (ProtocolViolationException *)sub_18004C870(v49);
			//             sub_180002BF0(v50);
			//             v51 = (String *)sub_18000F7E0(&off_18D556BA0);
			//             System::Net::ProtocolViolationException::ProtocolViolationException(v50, v51, 0LL);
			//             sub_18000F7C0(v50, v26);
			//           }
			//           if ( HIDWORD(v56) == -2 )
			//             break;
			//           v27 = (unsigned int)(HIDWORD(v56) + 1);
			//           HIDWORD(v56) = v27;
			//           if ( (_DWORD)v27 == *(_DWORD *)(v56 + 32) )
			//           {
			//             HIDWORD(v56) = -2;
			//             v57 = 0LL;
			//             v58 = 0LL;
			//             v59 = 0LL;
			//             v60 = 0LL;
			//             v61 = 0LL;
			//             v62 = 0LL;
			//             v63 = 0LL;
			//             goto LABEL_92;
			//           }
			//           v28 = *(_QWORD *)(v56 + 16);
			//           if ( !v28 )
			//             sub_1802DC2C8(v56, v11);
			//           v29 = *(unsigned int *)(v28 + 24);
			//           v30 = v27 + *(_DWORD *)(v56 + 24);
			//           v31 = v30 - v29;
			//           if ( v30 < (int)v29 )
			//             v31 = v27 + *(_DWORD *)(v56 + 24);
			//           v32 = v31;
			//           if ( v31 >= (unsigned int)v29 )
			//             sub_180070260(v31, v29, v27, v28);
			//           v33 = 104LL * v31;
			//           v57 = *(_OWORD *)(104 * v32 + v28 + 32);
			//           v58 = *(_OWORD *)(104 * v32 + v28 + 48);
			//           v59 = *(_OWORD *)(104 * v32 + v28 + 64);
			//           v60 = *(_OWORD *)(104 * v32 + v28 + 80);
			//           v61 = *(_OWORD *)(104 * v32 + v28 + 96);
			//           v62 = *(_OWORD *)(104 * v32 + v28 + 112);
			//           v63 = *(_QWORD *)(104 * v32 + v28 + 128);
			//           if ( (int)v27 < 0 )
			//           {
			//             v47 = sub_18010B520(MethodInfo::System::Collections::Generic::Queue_1_T_::Enumerator<HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode>::get_Current.klass);
			//             v48 = sub_180328104(*(_QWORD *)(v47 + 192), 0LL);
			//             sub_18052E9E4(&v56, v48);
			//           }
			//           v71 = *(HGTerrainStreamingManager_TerrainLoadingNode *)(v33 + v28 + 32);
			//           HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode::DisposeAllAsset(&v71, 0LL);
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v74 )
			//       {
			//         v11 = (__int64 *)v53;
			//         ex = (MethodInfo *)v74.ex;
			//         v34 = v55;
			//         HIDWORD(v55.virtualMethodPointer) = -2;
			//         *(_OWORD *)&v34.invoker_method = 0LL;
			//         *(_OWORD *)&v34.klass = 0LL;
			//         *(_OWORD *)&v34.parameters = 0LL;
			//         *(_OWORD *)&v34.genericMethod = 0LL;
			//         *(_OWORD *)&v34.slot = 0LL;
			//         *(_OWORD *)&v34[1].virtualMethodPointer = 0LL;
			//         v34[1].name = 0LL;
			//         if ( ex )
			//           sub_18000F780(ex);
			//         v2 = this;
			// LABEL_52:
			//         m_splatsPendingToLoad = (MethodInfo *)v2.fields.m_nodeAtlasPendingToLoad;
			//         if ( m_splatsPendingToLoad )
			//         {
			//           if ( LODWORD(m_splatsPendingToLoad.klass) )
			//             LODWORD(m_splatsPendingToLoad.klass) = 0;
			//           m_splatsPendingToLoad.name = 0LL;
			//           ++HIDWORD(m_splatsPendingToLoad.klass);
			//           m_splatsPendingToLoad = (MethodInfo *)v2.fields.m_nodeAtlasPendingLoaded;
			//           if ( m_splatsPendingToLoad )
			//           {
			//             if ( LODWORD(m_splatsPendingToLoad.klass) )
			//               LODWORD(m_splatsPendingToLoad.klass) = 0;
			//             m_splatsPendingToLoad.name = 0LL;
			//             ++HIDWORD(m_splatsPendingToLoad.klass);
			//             v35 = (void (*)(void))qword_18D8F5C50;
			//             if ( !qword_18D8F5C50 )
			//             {
			//               v35 = (void (*)(void))il2cpp_resolve_icall_0("UnityEngine.HyperGryph.HGTerrainManager::ResetLoadingStatusForAllNodes()");
			//               if ( !v35 )
			//               {
			//                 v52 = sub_1802DBBE8("UnityEngine.HyperGryph.HGTerrainManager::ResetLoadingStatusForAllNodes()");
			//                 sub_18000F750(v52, 0LL);
			//               }
			//               qword_18D8F5C50 = (__int64)v35;
			//             }
			//             v35();
			//             m_nodeLut = v2.fields.m_nodeLut;
			//             if ( m_nodeLut )
			//             {
			//               if ( m_nodeLut.fields._lastIndex <= 0 )
			//               {
			// LABEL_65:
			//                 ++m_nodeLut.fields._version;
			//                 return;
			//               }
			//               System::Array::Clear((Array *)m_nodeLut.fields._slots, 0, m_nodeLut.fields._lastIndex, 0LL);
			//               v37 = m_nodeLut.fields._buckets;
			//               if ( v37 )
			//               {
			//                 System::Array::Clear((Array *)m_nodeLut.fields._buckets, 0, v37.max_length.size, 0LL);
			//                 *(_QWORD *)&m_nodeLut.fields._count = 0LL;
			//                 m_nodeLut.fields._freeList = -1;
			//                 goto LABEL_65;
			//               }
			//             }
			//           }
			//         }
			//         goto LABEL_83;
			//       }
			// LABEL_92:
			//       HIDWORD(v56) = -2;
			//       v57 = 0LL;
			//       v58 = 0LL;
			//       v59 = 0LL;
			//       v60 = 0LL;
			//       v61 = 0LL;
			//       v62 = 0LL;
			//       v63 = 0LL;
			//       goto LABEL_52;
			//     }
			// LABEL_87:
			//     HIDWORD(v64) = -2;
			//     v65 = 0LL;
			//     v66 = 0LL;
			//     v67 = 0LL;
			//     v68 = 0LL;
			//     goto LABEL_20;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1913, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v40, v39);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			// }
			// 
		}

		private readonly Queue<uint> m_nodeAtlasPendingToLoad;

		private readonly Queue<HGTerrainStreamingManager.TerrainLoadingNode> m_nodeAtlasPendingLoaded;

		private readonly Queue<int> m_splatsPendingToLoad;

		private readonly Queue<HGTerrainStreamingManager.TerrainLoadingSplat> m_splatsPendingLoaded;

		public string atlasPageRootPath;

		private bool m_streamingResult;

		private const string LAYER_DIFFUSE_FORMAT_STR = "{0}/Layers/LAYER_D_{1}.tga";

		private const string LAYER_NRO_FORMAT_STR = "{0}/Layers/LAYER_N_{1}.tga";

		private const string LAYER_CONE_FORMAT_STR = "{0}/Layers/LAYER_C_{1}.tga";

		private const string HEIGHTMAP_FORMAT_STR = "{0}/Terrain_{1}_{2}_{3}_H.asset";

		private const string NORMALMAP_FORMAT_STR = "{0}/Terrain_{1}_{2}_{3}_N.tga";

		private const string TINTCOLOR_FORMAT_STR = "{0}/Terrain_{1}_{2}_{3}_T.tga";

		private const string ALBEDO_FORMAT_STR = "{0}/Terrain_{1}_{2}_{3}_A.tga";

		private const string SPLATCTRL_FORMAT_STR = "{0}/Terrain_{1}_{2}_{3}_S.tga";

		private readonly HashSet<int> m_splatLut;

		private readonly HashSet<uint> m_nodeLut;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
		internal struct TerrainLoadingSplat
		{
			public bool AllAssetReady()
			{
				// // Boolean AllAssetReady()
				// bool HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat::AllAssetReady(
				//         HGTerrainStreamingManager_TerrainLoadingSplat *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(1943, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1943, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v6, v5);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_755(Patch, this, 0LL);
				//   }
				//   else
				//   {
				//     return (Beyond::Resource::FAssetProxyHandle::IsInvalid(&this.diffuse, 0LL)
				//          || Beyond::Resource::FAssetProxyUntrackedHandle::get_isDone(&this.diffuse.m_untrackedHandle, 0LL))
				//         && (Beyond::Resource::FAssetProxyHandle::IsInvalid(&this.nro, 0LL)
				//          || Beyond::Resource::FAssetProxyUntrackedHandle::get_isDone(&this.nro.m_untrackedHandle, 0LL))
				//         && (Beyond::Resource::FAssetProxyHandle::IsInvalid(&this.cone, 0LL)
				//          || Beyond::Resource::FAssetProxyUntrackedHandle::get_isDone(&this.cone.m_untrackedHandle, 0LL));
				//   }
				// }
				// 
				return default(bool);
			}

			public void DisposeAllAsset()
			{
				// // Void DisposeAllAsset()
				// void HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingSplat::DisposeAllAsset(
				//         HGTerrainStreamingManager_TerrainLoadingSplat *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(1914, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1914, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v5, v4);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_752(Patch, this, 0LL);
				//   }
				//   else
				//   {
				//     Beyond::Resource::FAssetProxyHandle::Dispose(&this.diffuse, 0LL);
				//     Beyond::Resource::FAssetProxyHandle::Dispose(&this.nro, 0LL);
				//     Beyond::Resource::FAssetProxyHandle::Dispose(&this.cone, 0LL);
				//   }
				// }
				// 
			}

			public int splatIdx;

			public FAssetProxyHandle diffuse;

			public FAssetProxyHandle nro;

			public FAssetProxyHandle cone;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 104)]
		internal struct TerrainLoadingNode
		{
			public bool AllAssetReady()
			{
				// // Boolean AllAssetReady()
				// bool HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode::AllAssetReady(
				//         HGTerrainStreamingManager_TerrainLoadingNode *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(1944, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1944, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v6, v5);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_756(Patch, this, 0LL);
				//   }
				//   else
				//   {
				//     return (Beyond::Resource::FAssetProxyHandle::IsInvalid(&this.heightmap, 0LL)
				//          || Beyond::Resource::FAssetProxyUntrackedHandle::get_isDone(&this.heightmap.m_untrackedHandle, 0LL))
				//         && (Beyond::Resource::FAssetProxyHandle::IsInvalid(&this.normalmap, 0LL)
				//          || Beyond::Resource::FAssetProxyUntrackedHandle::get_isDone(&this.normalmap.m_untrackedHandle, 0LL))
				//         && (Beyond::Resource::FAssetProxyHandle::IsInvalid(&this.tintColor, 0LL)
				//          || Beyond::Resource::FAssetProxyUntrackedHandle::get_isDone(&this.tintColor.m_untrackedHandle, 0LL))
				//         && (Beyond::Resource::FAssetProxyHandle::IsInvalid(&this.albedo, 0LL)
				//          || Beyond::Resource::FAssetProxyUntrackedHandle::get_isDone(&this.albedo.m_untrackedHandle, 0LL))
				//         && (Beyond::Resource::FAssetProxyHandle::IsInvalid(&this.splatCtrl, 0LL)
				//          || Beyond::Resource::FAssetProxyUntrackedHandle::get_isDone(&this.splatCtrl.m_untrackedHandle, 0LL));
				//   }
				// }
				// 
				return default(bool);
			}

			public void DisposeAllAsset()
			{
				// // Void DisposeAllAsset()
				// void HG::Rendering::Runtime::HGTerrainStreamingManager::TerrainLoadingNode::DisposeAllAsset(
				//         HGTerrainStreamingManager_TerrainLoadingNode *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(1915, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1915, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v5, v4);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_753(Patch, this, 0LL);
				//   }
				//   else
				//   {
				//     Beyond::Resource::FAssetProxyHandle::Dispose(&this.heightmap, 0LL);
				//     Beyond::Resource::FAssetProxyHandle::Dispose(&this.normalmap, 0LL);
				//     Beyond::Resource::FAssetProxyHandle::Dispose(&this.tintColor, 0LL);
				//     Beyond::Resource::FAssetProxyHandle::Dispose(&this.splatCtrl, 0LL);
				//     Beyond::Resource::FAssetProxyHandle::Dispose(&this.albedo, 0LL);
				//   }
				// }
				// 
			}

			public uint nodeKey;

			public FAssetProxyHandle heightmap;

			public FAssetProxyHandle normalmap;

			public FAssetProxyHandle tintColor;

			public FAssetProxyHandle albedo;

			public FAssetProxyHandle splatCtrl;
		}
	}
}
