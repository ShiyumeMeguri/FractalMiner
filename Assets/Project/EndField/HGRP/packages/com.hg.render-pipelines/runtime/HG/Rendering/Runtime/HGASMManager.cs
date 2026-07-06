using System;
using System.Collections.Generic;
using HG.Rendering.RenderGraphModule;
using IFix.Core;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;

namespace HG.Rendering.Runtime
{
	public class HGASMManager
	{
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x000025F0 File Offset: 0x000007F0
		public static float asmCacheRadius
		{
			get
			{
				// // Single get_asmCacheRadius()
				// float HG::Rendering::Runtime::HGASMManager::get_asmCacheRadius(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   struct HGASMManager__Class *v2; // rax
				// 
				//   if ( !byte_18D919E5B )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGASMManager);
				//     byte_18D919E5B = 1;
				//   }
				//   v2 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v1);
				//     v2 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
				//   }
				//   return v2.static_fields.s_asmCacheRadius;
				// }
				// 
				return 0f;
			}
		}

		// (get) Token: 0x0600092F RID: 2351 RVA: 0x000025F0 File Offset: 0x000007F0
		public static float asmGridSize
		{
			get
			{
				// // Single get_asmGridSize()
				// float HG::Rendering::Runtime::HGASMManager::get_asmGridSize(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   struct HGASMManager__Class *v2; // rax
				// 
				//   if ( !byte_18D919E5C )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGASMManager);
				//     byte_18D919E5C = 1;
				//   }
				//   v2 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v1);
				//     v2 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
				//   }
				//   return v2.static_fields.s_asmGridSize;
				// }
				// 
				return 0f;
			}
		}

		// (get) Token: 0x06000930 RID: 2352 RVA: 0x000025D2 File Offset: 0x000007D2
		public RTHandle ASMShadowMapRT
		{
			get
			{
				// // IUnit get_destinationUnit()
				// IUnit *Unity::VisualScripting::UnitConnection<System::Object,System::Object>::get_destinationUnit(
				//         UnitConnection_2_System_Object_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._destinationUnit_k__BackingField;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000931 RID: 2353 RVA: 0x000025D2 File Offset: 0x000007D2
		public ASMTileManager asmTileManager
		{
			get
			{
				// // Func`1[Single] get_getValueDelegate()
				// Func_1_Single_ *Rewired::Utils::Classes::Utility::ValueWatcher<float>::get_getValueDelegate(
				//         ValueWatcher_1_System_Single_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000932 RID: 2354 RVA: 0x000025D2 File Offset: 0x000007D2
		public Vector3[] frustumCornersLightSpace
		{
			get
			{
				// // Object get_currentInstance()
				// Object *NodeCanvas::StateMachines::FSMStateNested<System::Object>::get_currentInstance(
				//         FSMStateNested_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._currentInstance_k__BackingField;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000933 RID: 2355 RVA: 0x000025D2 File Offset: 0x000007D2
		public Vector3 cameraPosLightSpace
		{
			get
			{
				// // Vector3 get_Value()
				// Vector3 *System::Collections::Generic::KeyValuePair<Beyond::ObjectPtr<System::Object>,UnityEngine::Vector3>::get_Value(
				//         Vector3 *__return_ptr retstr,
				//         KeyValuePair_2_Beyond_ObjectPtr_1_System_Object_UnityEngine_Vector3_ *this,
				//         MethodInfo *method)
				// {
				//   float z; // eax
				// 
				//   z = this.value.z;
				//   *(_QWORD *)&retstr.x = *(_QWORD *)&this.value.x;
				//   retstr.z = z;
				//   return retstr;
				// }
				// 
				return null;
			}
		}

		public HGASMManager()
		{
			// // HGASMManager()
			// void HG::Rendering::Runtime::HGASMManager::HGASMManager(HGASMManager *this, MethodInfo *method)
			// {
			//   ASMTileManager *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   ASMTileManager *v6; // rdi
			//   OneofDescriptorProto *v7; // rdx
			//   FileDescriptor *v8; // r8
			//   MessageDescriptor *v9; // r9
			//   HGASMVirtualTextureAllocator *v10; // rax
			//   HGASMVirtualTextureAllocator *v11; // rdi
			//   OneofDescriptorProto *v12; // rdx
			//   FileDescriptor *v13; // r8
			//   MessageDescriptor *v14; // r9
			//   __int64 v15; // r8
			//   __int64 v16; // r9
			//   OneofDescriptorProto *v17; // rdx
			//   FileDescriptor *v18; // r8
			//   MessageDescriptor *v19; // r9
			//   __int64 v20; // r8
			//   __int64 v21; // r9
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
			//   __int64 v35; // r8
			//   __int64 v36; // r9
			//   OneofDescriptorProto *v37; // rdx
			//   FileDescriptor *v38; // r8
			//   MessageDescriptor *v39; // r9
			//   __int64 v40; // r8
			//   __int64 v41; // r9
			//   OneofDescriptorProto *v42; // rdx
			//   FileDescriptor *v43; // r8
			//   MessageDescriptor *v44; // r9
			//   __int64 v45; // r8
			//   __int64 v46; // r9
			//   OneofDescriptorProto *v47; // rdx
			//   FileDescriptor *v48; // r8
			//   MessageDescriptor *v49; // r9
			//   Animator *v50; // rdx
			//   int32_t v51; // r8d
			//   MethodInfo *v52; // r9
			//   Vector3 *Vector; // rax
			//   float z; // ecx
			//   MethodInfo *v55; // r8
			//   void *m_Ptr; // rax
			//   MethodInfo *v57; // r8
			//   void *v58; // rax
			//   MethodInfo *v59; // r8
			//   String__Array *v60; // [rsp+20h] [rbp-18h] BYREF
			//   String *v61; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v62; // [rsp+30h] [rbp-8h]
			//   ProfilerMarker v63; // [rsp+50h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D919E64 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ASMTileManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGASMVirtualTextureAllocator);
			//     sub_18003C530(&TypeInfo::UnityEngine::Matrix4x4);
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector2);
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector3);
			//     sub_18003C530(&off_18D5EFFB8);
			//     sub_18003C530(&off_18D5EFFB0);
			//     sub_18003C530(&off_18D5EFFA8);
			//     byte_18D919E64 = 1;
			//   }
			//   v3 = (ASMTileManager *)sub_180004920(TypeInfo::HG::Rendering::Runtime::ASMTileManager);
			//   v6 = v3;
			//   if ( !v3
			//     || (HG::Rendering::Runtime::ASMTileManager::ASMTileManager(v3, 0LL),
			//         this.fields.m_asmTileManager = v6,
			//         sub_1800054D0((OneofDescriptor *)&this.fields.m_asmTileManager, v7, v8, v9, v60, v61, v62),
			//         v10 = (HGASMVirtualTextureAllocator *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGASMVirtualTextureAllocator),
			//         (v11 = v10) == 0LL) )
			//   {
			//     sub_180B536AC(v5, v4);
			//   }
			//   HG::Rendering::Runtime::HGASMVirtualTextureAllocator::HGASMVirtualTextureAllocator(v10, 0LL);
			//   this.fields.m_vtAllocator = v11;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_vtAllocator, v12, v13, v14, v60, v61, v62);
			//   this.fields.m_worldToShadowMatrices = (Matrix4x4__Array *)il2cpp_array_new_specific_0(
			//                                                                TypeInfo::UnityEngine::Matrix4x4,
			//                                                                256LL,
			//                                                                v15,
			//                                                                v16);
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_worldToShadowMatrices, v17, v18, v19, v60, v61, v62);
			//   this.fields.m_frustumCorners = (Vector3__Array *)il2cpp_array_new_specific_0(
			//                                                       TypeInfo::UnityEngine::Vector3,
			//                                                       4LL,
			//                                                       v20,
			//                                                       v21);
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_frustumCorners, v22, v23, v24, v60, v61, v62);
			//   this.fields.m_frustumCornersLightSpace = (Vector3__Array *)il2cpp_array_new_specific_0(
			//                                                                 TypeInfo::UnityEngine::Vector3,
			//                                                                 4LL,
			//                                                                 v25,
			//                                                                 v26);
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_frustumCornersLightSpace, v27, v28, v29, v60, v61, v62);
			//   this.fields.m_frustumVerts = (Vector2__Array *)il2cpp_array_new_specific_0(
			//                                                     TypeInfo::UnityEngine::Vector2,
			//                                                     5LL,
			//                                                     v30,
			//                                                     v31);
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_frustumVerts, v32, v33, v34, v60, v61, v62);
			//   this.fields.m_frustumCornersForIndirect = (Vector3__Array *)il2cpp_array_new_specific_0(
			//                                                                  TypeInfo::UnityEngine::Vector3,
			//                                                                  4LL,
			//                                                                  v35,
			//                                                                  v36);
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_frustumCornersForIndirect, v37, v38, v39, v60, v61, v62);
			//   this.fields.m_frustumCornersLightSpaceForIndirect = (Vector3__Array *)il2cpp_array_new_specific_0(
			//                                                                            TypeInfo::UnityEngine::Vector3,
			//                                                                            4LL,
			//                                                                            v40,
			//                                                                            v41);
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_frustumCornersLightSpaceForIndirect, v42, v43, v44, v60, v61, v62);
			//   this.fields.m_frustumVertsForIndirect = (Vector2__Array *)il2cpp_array_new_specific_0(
			//                                                                TypeInfo::UnityEngine::Vector2,
			//                                                                5LL,
			//                                                                v45,
			//                                                                v46);
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_frustumVertsForIndirect, v47, v48, v49, v60, v61, v62);
			//   v63.m_Ptr = (void *)sub_182E7A130();
			//   this.fields.m_lastPositionXZ = (Vector2)v63.m_Ptr;
			//   Vector = UnityEngine::Animator::GetVector((Vector3 *)&v60, v50, v51, v52);
			//   v63.m_Ptr = 0LL;
			//   z = Vector.z;
			//   *(_QWORD *)&this.fields.m_lastLightDir.x = *(_QWORD *)&Vector.x;
			//   this.fields.m_lastLightDir.z = z;
			//   this.fields.m_asmUpdateMode = 2;
			//   this.fields.m_asmCasterMinY = -500.0;
			//   this.fields.m_asmCasterMaxY = 500.0;
			//   Unity::Profiling::ProfilerMarker::ProfilerMarker(&v63, (String *)"ShadowMap.ASM.CreateTiles", v55);
			//   m_Ptr = v63.m_Ptr;
			//   v63.m_Ptr = 0LL;
			//   this.fields.m_samplerASMCreateTiles.m_Ptr = m_Ptr;
			//   Unity::Profiling::ProfilerMarker::ProfilerMarker(&v63, (String *)"ShadowMap.ASM.UpdateCachedTiles", v57);
			//   v58 = v63.m_Ptr;
			//   v63.m_Ptr = 0LL;
			//   this.fields.m_samplerASMUpdateCachedTiles.m_Ptr = v58;
			//   Unity::Profiling::ProfilerMarker::ProfilerMarker(&v63, (String *)"ShadowMap.ASM.PreRenderTiles", v59);
			//   this.fields.m_samplerASMPreRenderTiles = v63;
			// }
			// 
		}

		public static HGASMManager GetASMManager(Camera camera)
		{
			// // HGASMManager GetASMManager(Camera)
			// HGASMManager *HG::Rendering::Runtime::HGASMManager::GetASMManager(Camera *camera, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Dictionary_2_System_Object_System_Object_ *s_asmManagers; // rcx
			//   HGASMManager *v5; // rax
			//   HGASMManager *v6; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919E58 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     byte_18D919E58 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1744, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1744, 0LL);
			//     if ( !Patch )
			//       goto LABEL_13;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_674(Patch, (Object *)camera, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     s_asmManagers = (Dictionary_2_System_Object_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmManagers;
			//     if ( !s_asmManagers )
			//       goto LABEL_13;
			//     if ( !System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
			//             s_asmManagers,
			//             (Object *)camera,
			//             MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::ContainsKey) )
			//     {
			//       v5 = (HGASMManager *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//       v6 = v5;
			//       if ( v5 )
			//       {
			//         HG::Rendering::Runtime::HGASMManager::HGASMManager(v5, 0LL);
			//         HG::Rendering::Runtime::HGASMManager::Initialize(v6, camera, 0LL, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//         s_asmManagers = (Dictionary_2_System_Object_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmManagers;
			//         if ( s_asmManagers )
			//         {
			//           System::Collections::Generic::Dictionary<System::Object,System::Object>::Add(
			//             s_asmManagers,
			//             (Object *)camera,
			//             (Object *)v6,
			//             MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::Add);
			//           s_asmManagers = (Dictionary_2_System_Object_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_cameraLifetime;
			//           if ( s_asmManagers )
			//           {
			//             System::Collections::Generic::Dictionary<System::Object,int>::Add(
			//               (Dictionary_2_System_Object_System_Int32_ *)s_asmManagers,
			//               (Object *)camera,
			//               -1,
			//               MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,int>::Add);
			//             return v6;
			//           }
			//         }
			//       }
			// LABEL_13:
			//       sub_180B536AC(s_asmManagers, v3);
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     s_asmManagers = (Dictionary_2_System_Object_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmManagers;
			//     if ( !s_asmManagers )
			//       goto LABEL_13;
			//     return (HGASMManager *)System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
			//                              s_asmManagers,
			//                              (Object *)camera,
			//                              MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
			//   }
			// }
			// 
			return null;
		}

		public static HGASMManager GetCachedASMManager(Camera camera)
		{
			// // HGASMManager GetCachedASMManager(Camera)
			// HGASMManager *HG::Rendering::Runtime::HGASMManager::GetCachedASMManager(Camera *camera, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Dictionary_2_UnityEngine_Camera_HG_Rendering_Runtime_HGASMManager_ *s_cachedASMManagers; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919E59 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     byte_18D919E59 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1745, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     s_cachedASMManagers = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_cachedASMManagers;
			//     if ( s_cachedASMManagers )
			//     {
			//       if ( !System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
			//               (Dictionary_2_System_Object_System_Object_ *)s_cachedASMManagers,
			//               (Object *)camera,
			//               MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::ContainsKey) )
			//         return 0LL;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//       s_cachedASMManagers = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_cachedASMManagers;
			//       if ( s_cachedASMManagers )
			//         return (HGASMManager *)System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
			//                                  (Dictionary_2_System_Object_System_Object_ *)s_cachedASMManagers,
			//                                  (Object *)camera,
			//                                  MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
			//     }
			// LABEL_10:
			//     sub_180B536AC(s_cachedASMManagers, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1745, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_674(Patch, (Object *)camera, 0LL);
			// }
			// 
			return null;
		}

		public static void SwapASMManager(Camera camera)
		{
		}

		public static void UpdateCameraLifetime(List<Camera> cameras, int frameCount)
		{
			// // Void UpdateCameraLifetime(List`1[UnityEngine.Camera], Int32)
			// // local variable allocation has failed, the output may be wrong!
			// // Hidden C++ exception states: #wind=6
			// void HG::Rendering::Runtime::HGASMManager::UpdateCameraLifetime(
			//         List_1_UnityEngine_Camera_ *cameras,
			//         int32_t frameCount,
			//         MethodInfo *method)
			// {
			//   MessageDescriptor *v3; // r9
			//   int32_t v4; // esi
			//   struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
			//   ILFixDynamicMethodWrapper_2__Array *v8; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   String__Array **v12; // rdx
			//   List_1_UnityEngine_Camera_ *v13; // rcx
			//   Object *current; // rbx
			//   struct HGASMManager__Class *v15; // rax
			//   Dictionary_2_System_Object_System_Int32_ *s_cameraLifetime; // rcx
			//   __int64 v17; // rdx
			//   struct HGASMManager__Class *v18; // rax
			//   Dictionary_2_System_Object_System_Int32_ *v19; // rcx
			//   struct HGASMManager__Class *v20; // rax
			//   Dictionary_2_UnityEngine_Camera_HG_Rendering_Runtime_HGASMManager_ *s_asmManagers; // r9
			//   __int64 *v22; // rdx
			//   signed __int64 v23; // rcx
			//   signed __int64 v24; // rtt
			//   Object *key; // rbx
			//   struct HGASMManager__Class *v26; // rax
			//   Dictionary_2_System_Object_System_Int32_ *v27; // rcx
			//   __int64 v28; // rdx
			//   struct HGASMManager__Class *v29; // rax
			//   Dictionary_2_System_Object_System_Int32_ *v30; // rcx
			//   struct HGASMManager__Class *v31; // rax
			//   List_1_System_Object_ *s_toRemoveList; // rcx
			//   struct HGASMManager__Class *v33; // rax
			//   List_1_UnityEngine_Camera_ *v34; // r9
			//   __int64 *v35; // rdx
			//   signed __int64 v36; // rtt
			//   Object *v37; // rbx
			//   struct HGASMManager__Class *v38; // rax
			//   Dictionary_2_System_Object_System_Object_ *s_cachedASMManagers; // rcx
			//   __int64 v40; // rdx
			//   struct HGASMManager__Class *v41; // rax
			//   Dictionary_2_System_Object_System_Object_ *v42; // rcx
			//   Object *Item; // rax
			//   __int64 v44; // rdx
			//   __int64 v45; // rcx
			//   __int64 v46; // rdx
			//   Dictionary_2_UnityEngine_Camera_HG_Rendering_Runtime_HGASMManager_ *v47; // rcx
			//   struct HGASMManager__Class *v48; // rax
			//   Dictionary_2_System_Object_System_Object_ *v49; // rcx
			//   __int64 v50; // rdx
			//   struct HGASMManager__Class *v51; // rax
			//   Dictionary_2_System_Object_System_Object_ *v52; // rcx
			//   Object *v53; // rax
			//   __int64 v54; // rdx
			//   __int64 v55; // rcx
			//   __int64 v56; // rdx
			//   Dictionary_2_UnityEngine_Camera_HG_Rendering_Runtime_HGASMManager_ *v57; // rcx
			//   struct HGASMManager__Class *v58; // rax
			//   Dictionary_2_System_Object_System_Int32_ *v59; // rcx
			//   __int64 v60; // rdx
			//   struct HGASMManager__Class *v61; // rax
			//   Dictionary_2_System_Object_System_Int32_ *v62; // rcx
			//   struct HGASMManager__Class *v63; // rbx
			//   __int64 v64; // rax
			//   __int64 v65; // rax
			//   const char *v66; // r8
			//   __int64 v67; // rdi
			//   __int64 v68; // r9
			//   __int64 v69; // rax
			//   __int64 *v70; // rdx
			//   signed __int64 v71; // rtt
			//   uint32_t v72; // eax
			//   bool v73; // cl
			//   unsigned int v74; // eax
			//   __int64 target_0; // rax
			//   String__Array *v76[6]; // [rsp+0h] [rbp-108h] BYREF
			//   _BYTE v77[24]; // [rsp+30h] [rbp-D8h] BYREF
			//   List_1_T_Enumerator_System_Object_ v78; // [rsp+48h] [rbp-C0h] BYREF
			//   _BYTE v79[40]; // [rsp+60h] [rbp-A8h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v80; // [rsp+88h] [rbp-80h] BYREF
			//   Il2CppExceptionWrapper *v81; // [rsp+B0h] [rbp-58h] BYREF
			//   Il2CppExceptionWrapper *v82; // [rsp+B8h] [rbp-50h] BYREF
			//   Il2CppExceptionWrapper *v83; // [rsp+C0h] [rbp-48h] BYREF
			//   _BYTE v84[40]; // [rsp+C8h] [rbp-40h] BYREF
			//   __int64 v86; // [rsp+128h] [rbp+20h] BYREF
			// 
			//   v4 = frameCount;
			//   if ( !byte_18D8EDCF6 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,int>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,int>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,int>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,int>::set_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Camera>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Camera>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Camera>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Key);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Camera>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Camera>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Camera>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDCF6 = 1;
			//   }
			//   memset(&v80, 0, sizeof(v80));
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, *(_QWORD *)&frameCount);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v6.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v6, *(_QWORD *)&frameCount);
			//   if ( wrapperArray.max_length.size <= 633 )
			//     goto LABEL_16;
			//   if ( !v6._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v6, *(_QWORD *)&frameCount);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v8 = v6.static_fields.wrapperArray;
			//   if ( !v8 )
			//     sub_180B536AC(v6, *(_QWORD *)&frameCount);
			//   if ( v8.max_length.size <= 0x279u )
			//     sub_180070270(v6, *(_QWORD *)&frameCount);
			//   if ( !v8[17].vector[21] )
			//   {
			// LABEL_16:
			//     if ( !cameras )
			//       sub_180B536AC(v6, *(_QWORD *)&frameCount);
			//     *(_OWORD *)&v77[8] = 0LL;
			//     *(_QWORD *)v77 = cameras;
			//     ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *, String *))sub_1800054D0)(
			//       (OneofDescriptor *)v77,
			//       *(OneofDescriptorProto **)&frameCount,
			//       (FileDescriptor *)method,
			//       v3,
			//       v76[4],
			//       (String *)v76[5]);
			//     *(_DWORD *)&v77[8] = 0;
			//     *(_DWORD *)&v77[12] = cameras.fields._version;
			//     *(_QWORD *)&v77[16] = 0LL;
			//     *(_OWORD *)&v78._list = *(_OWORD *)v77;
			//     v78._current = 0LL;
			//     *(_QWORD *)v77 = 0LL;
			//     *(_QWORD *)&v77[8] = &v78;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v78,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Camera>::MoveNext) )
			//       {
			//         current = v78._current;
			//         v15 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//         if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v12);
			//           v15 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//         }
			//         s_cameraLifetime = (Dictionary_2_System_Object_System_Int32_ *)v15.static_fields.s_cameraLifetime;
			//         if ( !s_cameraLifetime )
			//           sub_1802DC2C8(0LL, v12);
			//         if ( System::Collections::Generic::Dictionary<System::Object,int>::ContainsKey(
			//                s_cameraLifetime,
			//                current,
			//                MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,int>::ContainsKey) )
			//         {
			//           v18 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//           if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v17);
			//             v18 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//           }
			//           v19 = (Dictionary_2_System_Object_System_Int32_ *)v18.static_fields.s_cameraLifetime;
			//           if ( !v19 )
			//             sub_1802DC2C8(0LL, v17);
			//           System::Collections::Generic::Dictionary<System::Object,int>::set_Item(
			//             v19,
			//             current,
			//             v4,
			//             MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,int>::set_Item);
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v81 )
			//     {
			//       v12 = v76;
			//       *(Il2CppExceptionWrapper *)v77 = (Il2CppExceptionWrapper)v81.ex;
			//       v13 = *(List_1_UnityEngine_Camera_ **)v77;
			//       if ( *(_QWORD *)v77 )
			//         sub_18000F780(*(_QWORD *)v77);
			//       v4 = frameCount;
			//     }
			//     v20 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v12);
			//       v20 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//     }
			//     s_asmManagers = v20.static_fields.s_asmManagers;
			//     if ( !s_asmManagers )
			//       goto LABEL_125;
			//     memset(&v79[8], 0, 32);
			//     *(_QWORD *)v79 = s_asmManagers;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v22 = &qword_18D6405E0[(((unsigned __int64)v79 >> 12) & 0x1FFFFF) >> 6];
			//       _m_prefetchw(v22 + 36190);
			//       do
			//       {
			//         v23 = v22[36190] | (1LL << (((unsigned __int64)v79 >> 12) & 0x3F));
			//         v24 = v22[36190];
			//       }
			//       while ( v24 != _InterlockedCompareExchange64(v22 + 36190, v23, v24) );
			//     }
			//     *(_QWORD *)&v79[8] = (unsigned int)s_asmManagers.fields._version;
			//     *(_DWORD *)&v79[32] = 2;
			//     *(_OWORD *)&v79[16] = 0LL;
			//     *(_OWORD *)&v80._dictionary = *(_OWORD *)v79;
			//     v80._current = 0LL;
			//     *(_QWORD *)&v80._getEnumeratorRetType = *(_QWORD *)&v79[32];
			//     *(_QWORD *)v77 = 0LL;
			//     *(_QWORD *)&v77[8] = &v80;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,System::Object>::MoveNext(
			//                 &v80,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::MoveNext) )
			//       {
			//         key = v80._current.key;
			//         v26 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//         if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v12);
			//           v26 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//         }
			//         v27 = (Dictionary_2_System_Object_System_Int32_ *)v26.static_fields.s_cameraLifetime;
			//         if ( !v27 )
			//           sub_1802DC2C8(0LL, v12);
			//         if ( System::Collections::Generic::Dictionary<System::Object,int>::get_Item(
			//                v27,
			//                key,
			//                MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,int>::get_Item) == -1 )
			//           goto LABEL_167;
			//         v29 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//         if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v28);
			//           v29 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//         }
			//         v30 = (Dictionary_2_System_Object_System_Int32_ *)v29.static_fields.s_cameraLifetime;
			//         if ( !v30 )
			//           sub_1802DC2C8(0LL, v28);
			//         if ( v4
			//            - System::Collections::Generic::Dictionary<System::Object,int>::get_Item(
			//                v30,
			//                key,
			//                MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,int>::get_Item) <= 16 )
			//         {
			// LABEL_167:
			//           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v28);
			//           if ( !byte_18D8F4EFA )
			//           {
			//             sub_18003C530(&TypeInfo::UnityEngine::Object);
			//             byte_18D8F4EFA = 1;
			//           }
			//           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v28);
			//           if ( !byte_18D8F4EAF )
			//           {
			//             sub_18003C530(&TypeInfo::UnityEngine::Object);
			//             byte_18D8F4EAF = 1;
			//           }
			//           if ( key )
			//           {
			//             if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v28);
			//             if ( key[1].klass )
			//               continue;
			//           }
			//         }
			//         v31 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//         if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v28);
			//           v31 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//         }
			//         s_toRemoveList = (List_1_System_Object_ *)v31.static_fields.s_toRemoveList;
			//         if ( !s_toRemoveList )
			//           sub_1802DC2C8(0LL, v28);
			//         sub_1822AD140(s_toRemoveList, key);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v82 )
			//     {
			//       v12 = v76;
			//       *(Il2CppExceptionWrapper *)v77 = (Il2CppExceptionWrapper)v82.ex;
			//       v13 = *(List_1_UnityEngine_Camera_ **)v77;
			//       if ( *(_QWORD *)v77 )
			//         sub_18000F780(*(_QWORD *)v77);
			//     }
			//     v33 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v12);
			//       v33 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//     }
			//     v34 = v33.static_fields.s_toRemoveList;
			//     if ( !v34 )
			//       goto LABEL_125;
			//     *(_OWORD *)&v77[8] = 0LL;
			//     *(_QWORD *)v77 = v34;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v35 = &qword_18D6405E0[(((unsigned __int64)v77 >> 12) & 0x1FFFFF) >> 6];
			//       _m_prefetchw(v35 + 36190);
			//       do
			//         v36 = v35[36190];
			//       while ( v36 != _InterlockedCompareExchange64(
			//                        v35 + 36190,
			//                        v36 | (1LL << (((unsigned __int64)v77 >> 12) & 0x3F)),
			//                        v36) );
			//     }
			//     *(_DWORD *)&v77[8] = 0;
			//     *(_DWORD *)&v77[12] = v34.fields._version;
			//     *(_QWORD *)&v77[16] = 0LL;
			//     *(_OWORD *)&v78._list = *(_OWORD *)v77;
			//     v78._current = 0LL;
			//     *(_QWORD *)v77 = 0LL;
			//     *(_QWORD *)&v77[8] = &v78;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v78,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Camera>::MoveNext) )
			//       {
			//         v37 = v78._current;
			//         v38 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//         if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v12);
			//           v38 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//         }
			//         s_cachedASMManagers = (Dictionary_2_System_Object_System_Object_ *)v38.static_fields.s_cachedASMManagers;
			//         if ( !s_cachedASMManagers )
			//           sub_1802DC2C8(0LL, v12);
			//         if ( System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
			//                s_cachedASMManagers,
			//                v37,
			//                MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::ContainsKey) )
			//         {
			//           v41 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//           if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v40);
			//             v41 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//           }
			//           v42 = (Dictionary_2_System_Object_System_Object_ *)v41.static_fields.s_cachedASMManagers;
			//           if ( !v42 )
			//             sub_1802DC2C8(0LL, v40);
			//           Item = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
			//                    v42,
			//                    v37,
			//                    MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
			//           if ( !Item )
			//             sub_1802DC2C8(v45, v44);
			//           HG::Rendering::Runtime::HGASMManager::Dispose((HGASMManager *)Item, 0LL);
			//           v47 = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_cachedASMManagers;
			//           if ( !v47 )
			//             sub_1802DC2C8(0LL, v46);
			//           System::Collections::Generic::Dictionary<System::Object,System::Object>::Remove(
			//             (Dictionary_2_System_Object_System_Object_ *)v47,
			//             v37,
			//             MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::Remove);
			//         }
			//         v48 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//         if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v40);
			//           v48 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//         }
			//         v49 = (Dictionary_2_System_Object_System_Object_ *)v48.static_fields.s_asmManagers;
			//         if ( !v49 )
			//           sub_1802DC2C8(0LL, v40);
			//         if ( System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
			//                v49,
			//                v37,
			//                MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::ContainsKey) )
			//         {
			//           v51 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//           if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v50);
			//             v51 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//           }
			//           v52 = (Dictionary_2_System_Object_System_Object_ *)v51.static_fields.s_asmManagers;
			//           if ( !v52 )
			//             sub_1802DC2C8(0LL, v50);
			//           v53 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
			//                   v52,
			//                   v37,
			//                   MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
			//           if ( !v53 )
			//             sub_1802DC2C8(v55, v54);
			//           HG::Rendering::Runtime::HGASMManager::Dispose((HGASMManager *)v53, 0LL);
			//           v57 = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmManagers;
			//           if ( !v57 )
			//             sub_1802DC2C8(0LL, v56);
			//           System::Collections::Generic::Dictionary<System::Object,System::Object>::Remove(
			//             (Dictionary_2_System_Object_System_Object_ *)v57,
			//             v37,
			//             MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::Remove);
			//         }
			//         v58 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//         if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v50);
			//           v58 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//         }
			//         v59 = (Dictionary_2_System_Object_System_Int32_ *)v58.static_fields.s_cameraLifetime;
			//         if ( !v59 )
			//           sub_1802DC2C8(0LL, v50);
			//         if ( System::Collections::Generic::Dictionary<System::Object,int>::ContainsKey(
			//                v59,
			//                v37,
			//                MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,int>::ContainsKey) )
			//         {
			//           v61 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//           if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v60);
			//             v61 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//           }
			//           v62 = (Dictionary_2_System_Object_System_Int32_ *)v61.static_fields.s_cameraLifetime;
			//           if ( !v62 )
			//             sub_1802DC2C8(0LL, v60);
			//           System::Collections::Generic::Dictionary<System::Object,int>::Remove(
			//             v62,
			//             v37,
			//             MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,int>::Remove);
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v83 )
			//     {
			//       v12 = v76;
			//       *(Il2CppExceptionWrapper *)v77 = (Il2CppExceptionWrapper)v83.ex;
			//       if ( *(_QWORD *)v77 )
			//         sub_18000F780(*(_QWORD *)v77);
			//     }
			//     v63 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
			//     {
			//       sub_1802924D0(&qword_18CDBFAA0);
			//       if ( _InterlockedCompareExchange((volatile signed __int32 *)&v63._1.cctor_finished_or_no_cctor, 1, 1) == 1 )
			//       {
			//         sub_180292530(&qword_18CDBFAA0);
			//         goto LABEL_102;
			//       }
			//       if ( _InterlockedCompareExchange((volatile signed __int32 *)&v63._1.cctor_started, 1, 1) == 1 )
			//       {
			//         sub_180292530(&qword_18CDBFAA0);
			//         v74 = ((__int64 (*)(void))GetCurrentThreadId)();
			//         if ( v74 == _InterlockedCompareExchange64((volatile signed __int64 *)&v63._1.cctor_thread, v74, v74) )
			//           goto LABEL_102;
			//         while ( _InterlockedCompareExchange((volatile signed __int32 *)&v63._1.cctor_finished_or_no_cctor, 1, 1) != 1
			//              && !_InterlockedCompareExchange((volatile signed __int32 *)&v63._1.initializationExceptionGCHandle, 0, 0) )
			//           sub_18006E120(1LL, 0LL);
			//       }
			//       else
			//       {
			//         _InterlockedExchange64(
			//           (volatile __int64 *)&v63._1.cctor_thread,
			//           (unsigned int)((__int64 (*)(void))GetCurrentThreadId)());
			//         _InterlockedExchange((volatile __int32 *)&v63._1.cctor_started, 1);
			//         sub_180292530(&qword_18CDBFAA0);
			//         v86 = 0LL;
			//         if ( (BYTE1(v63.vtable.Equals.methodPtr) & 4) != 0 )
			//         {
			//           v64 = sub_180039210((_DWORD)v63, (unsigned int)".cctor", -1, 2048, 0LL);
			//           if ( v64 )
			//             il2cpp_runtime_invoke_0(v64, 0LL, 0LL, &v86);
			//         }
			//         _InterlockedExchange64((volatile __int64 *)&v63._1.cctor_thread, 0LL);
			//         if ( v86 )
			//         {
			//           v65 = sub_180017960(v79, &v63._0.byval_arg, 0LL);
			//           v66 = (const char *)sub_180006C00(v65);
			//           sub_180016840(v84, "The type initializer for '%s' threw an exception.", v66);
			//           sub_180006B90(v79);
			//           v67 = v86;
			//           v68 = sub_180006C00(v84);
			//           v69 = il2cpp_exception_from_name_msg_0(qword_18D8E4510, "System", "TypeInitializationException", v68);
			//           if ( v67 )
			//           {
			//             *(_QWORD *)(v69 + 40) = v67;
			//             if ( dword_18D8E43F8 )
			//             {
			//               v70 = &qword_18D6405E0[(((unsigned __int64)(v69 + 40) >> 12) & 0x1FFFFF) >> 6];
			//               _m_prefetchw(v70 + 36190);
			//               do
			//                 v71 = v70[36190];
			//               while ( v71 != _InterlockedCompareExchange64(
			//                                v70 + 36190,
			//                                v71 | (1LL << (((unsigned __int64)(v69 + 40) >> 12) & 0x3F)),
			//                                v71) );
			//             }
			//           }
			//           v72 = sub_1802DC930(&qword_18CDBF7F0, v69, 0LL);
			//           v63._1.initializationExceptionGCHandle = v72;
			//           v73 = ((__int64)v63.vtable.Equals.methodPtr & 2) != 0 && !v72;
			//           LOBYTE(v63.vtable.Equals.methodPtr) = v73 | (__int64)v63.vtable.Equals.methodPtr & 0xFE;
			//           sub_180006B90(v84);
			//         }
			//         else
			//         {
			//           _InterlockedExchange((volatile __int32 *)&v63._1.cctor_finished_or_no_cctor, 1);
			//         }
			//       }
			//       if ( v63._1.initializationExceptionGCHandle )
			//       {
			//         target_0 = mono_gchandle_get_target_0(v63._1.initializationExceptionGCHandle);
			//         sub_18000F750(target_0, 0LL);
			//       }
			//     }
			// LABEL_102:
			//     v13 = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_toRemoveList;
			//     if ( v13 )
			//     {
			//       sub_1823B99D0(v13, MethodInfo::System::Collections::Generic::List<UnityEngine::Camera>::Clear);
			//       return;
			//     }
			// LABEL_125:
			//     sub_1802DC2C8(v13, v12);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(633, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v11, v10);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)cameras, v4, 0LL);
			// }
			// 
		}

		public static void CleanUpAllCameras()
		{
			// // Void CleanUpAllCameras()
			// void HG::Rendering::Runtime::HGASMManager::CleanUpAllCameras(MethodInfo *method)
			// {
			//   __int64 v1; // rdx
			//   struct HGASMManager__Class *v2; // rax
			//   Dictionary_2_System_UInt64_System_Object_ *s_asmManagers; // rcx
			//   IEnumerable_1_System_Object_ *Keys; // rax
			//   Object__Array *v5; // rbx
			//   int32_t v6; // edi
			//   int32_t v7; // esi
			//   struct HGASMManager__Class *v8; // rax
			//   IEnumerable_1_System_Object_ *v9; // rax
			//   Object__Array *v10; // rbx
			//   Object *v11; // rbp
			//   struct HGASMManager__Class *v12; // rax
			//   Object *Item; // rax
			//   Object *v14; // rsi
			//   struct HGASMManager__Class *v15; // rax
			//   Object *v16; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDCF7 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,int>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Keys);
			//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::ToArray<UnityEngine::Camera>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     byte_18D8EDCF7 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(526, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(526, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_28 *)Patch, 0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(s_asmManagers, v1);
			//   }
			//   v2 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v1);
			//     v2 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//   }
			//   s_asmManagers = (Dictionary_2_System_UInt64_System_Object_ *)v2.static_fields.s_asmManagers;
			//   if ( !s_asmManagers )
			//     goto LABEL_7;
			//   Keys = (IEnumerable_1_System_Object_ *)System::Collections::Generic::Dictionary<unsigned long,System::Object>::get_Keys(
			//                                            s_asmManagers,
			//                                            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Keys);
			//   v5 = System::Linq::Enumerable::ToArray<System::Object>(
			//          Keys,
			//          MethodInfo::System::Linq::Enumerable::ToArray<UnityEngine::Camera>);
			//   v6 = 0;
			//   v7 = 0;
			//   if ( !v5 )
			//     goto LABEL_7;
			//   while ( v7 < v5.max_length.size )
			//   {
			//     if ( (unsigned int)v7 >= v5.max_length.size )
			// LABEL_31:
			//       sub_180070270(s_asmManagers, v1);
			//     v11 = v5.vector[v7];
			//     v12 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v1);
			//       v12 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//     }
			//     s_asmManagers = (Dictionary_2_System_UInt64_System_Object_ *)v12.static_fields.s_asmManagers;
			//     if ( !s_asmManagers )
			//       goto LABEL_7;
			//     Item = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
			//              (Dictionary_2_System_Object_System_Object_ *)s_asmManagers,
			//              v11,
			//              MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
			//     if ( !Item )
			//       goto LABEL_7;
			//     HG::Rendering::Runtime::HGASMManager::Dispose((HGASMManager *)Item, 0LL);
			//     s_asmManagers = (Dictionary_2_System_UInt64_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmManagers;
			//     if ( !s_asmManagers )
			//       goto LABEL_7;
			//     System::Collections::Generic::Dictionary<System::Object,System::Object>::Remove(
			//       (Dictionary_2_System_Object_System_Object_ *)s_asmManagers,
			//       v11,
			//       MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::Remove);
			//     s_asmManagers = (Dictionary_2_System_UInt64_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_cameraLifetime;
			//     if ( !s_asmManagers )
			//       goto LABEL_7;
			//     System::Collections::Generic::Dictionary<System::Object,int>::Remove(
			//       (Dictionary_2_System_Object_System_Int32_ *)s_asmManagers,
			//       v11,
			//       MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,int>::Remove);
			//     ++v7;
			//   }
			//   v8 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v1);
			//     v8 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//   }
			//   s_asmManagers = (Dictionary_2_System_UInt64_System_Object_ *)v8.static_fields.s_cachedASMManagers;
			//   if ( !s_asmManagers )
			//     goto LABEL_7;
			//   v9 = (IEnumerable_1_System_Object_ *)System::Collections::Generic::Dictionary<unsigned long,System::Object>::get_Keys(
			//                                          s_asmManagers,
			//                                          MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Keys);
			//   v10 = System::Linq::Enumerable::ToArray<System::Object>(
			//           v9,
			//           MethodInfo::System::Linq::Enumerable::ToArray<UnityEngine::Camera>);
			//   if ( !v10 )
			//     goto LABEL_7;
			//   while ( v6 < v10.max_length.size )
			//   {
			//     if ( (unsigned int)v6 >= v10.max_length.size )
			//       goto LABEL_31;
			//     v14 = v10.vector[v6];
			//     v15 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v1);
			//       v15 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//     }
			//     s_asmManagers = (Dictionary_2_System_UInt64_System_Object_ *)v15.static_fields.s_cachedASMManagers;
			//     if ( !s_asmManagers )
			//       goto LABEL_7;
			//     v16 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
			//             (Dictionary_2_System_Object_System_Object_ *)s_asmManagers,
			//             v14,
			//             MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Item);
			//     if ( !v16 )
			//       goto LABEL_7;
			//     HG::Rendering::Runtime::HGASMManager::Dispose((HGASMManager *)v16, 0LL);
			//     s_asmManagers = (Dictionary_2_System_UInt64_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_cachedASMManagers;
			//     if ( !s_asmManagers )
			//       goto LABEL_7;
			//     System::Collections::Generic::Dictionary<System::Object,System::Object>::Remove(
			//       (Dictionary_2_System_Object_System_Object_ *)s_asmManagers,
			//       v14,
			//       MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::Remove);
			//     ++v6;
			//   }
			// }
			// 
		}

		public static void InitStaticParams(Shader shadowClearShader, HGSettingParameters settingParameters)
		{
			// // Void InitStaticParams(Shader, HGSettingParameters)
			// void HG::Rendering::Runtime::HGASMManager::InitStaticParams(
			//         Shader *shadowClearShader,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Material *StaticMaterial; // rax
			//   OneofDescriptorProto *v7; // rdx
			//   FileDescriptor *v8; // r8
			//   MessageDescriptor *v9; // r9
			//   struct HGASMManager__Class *v10; // rcx
			//   Material *v11; // rdi
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   __int64 v14; // rdx
			//   Int32Enum__Enum v15; // edi
			//   float v16; // xmm0_4
			//   int v17; // xmm1_4
			//   Int32Enum__Enum v18; // eax
			//   float v19; // xmm0_4
			//   float v20; // xmm0_4
			//   float v21; // xmm6_4
			//   uint32_t s_asmManagerCullingMask; // ebx
			//   uint32_t v23; // ebx
			//   uint32_t v24; // ebx
			//   uint32_t v25; // ebx
			//   struct HGASMManager__Class *v26; // rdx
			//   uint32_t v27; // ebx
			//   struct HGCamera__Class *v28; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *v30; // [rsp+20h] [rbp-18h]
			//   String *v31; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v32; // [rsp+30h] [rbp-8h]
			// 
			//   if ( !byte_18D8EDCF8 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     sub_18003C530(&off_18C926430);
			//     sub_18003C530(&off_18C922B80);
			//     sub_18003C530(&off_18C923620);
			//     sub_18003C530(&off_18C957B58);
			//     byte_18D8EDCF8 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1748, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1748, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)shadowClearShader,
			//         (Object *)settingParameters,
			//         0LL);
			//       return;
			//     }
			// LABEL_25:
			//     sub_180B536AC(v13, v12);
			//   }
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector, v5);
			//   StaticMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
			//                      shadowClearShader,
			//                      0,
			//                      0LL);
			//   v10 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//   v11 = StaticMaterial;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v7);
			//     v10 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//   }
			//   v10.static_fields.s_clearShadowMaterial = v11;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_clearShadowMaterial,
			//     v7,
			//     v8,
			//     v9,
			//     v30,
			//     v31,
			//     v32);
			//   if ( !settingParameters )
			//     goto LABEL_25;
			//   v15 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//           (SettingParameter_1_System_Int32Enum_ *)settingParameters.fields._asmShadowMapTileResolution_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//   if ( !TypeInfo::System::Math._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::System::Math, v14);
			//   TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmTileResolution = sub_182ACC210(v15, 64LL, 512LL);
			//   v16 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParameters.fields._asmMaxDistance_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   v17 = 1106247680;
			//   if ( v16 < 30.0 || (v17 = 1157234688, v16 > 2000.0) )
			//     v16 = *(float *)&v17;
			//   TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmCacheRadius = v16;
			//   TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmGridSize = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmCacheRadius
			//                                                                                * 0.25;
			//   v18 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//           (SettingParameter_1_System_Int32Enum_ *)settingParameters.fields._asmMaxTileRenderCountPerFrame_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//   TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmMaxTileRenderCountPerFrame = sub_182ACC210(
			//                                                                                                      v18,
			//                                                                                                      1LL,
			//                                                                                                      128LL);
			//   v19 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParameters.fields._asmDepthBias_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   if ( v19 < 0.0 )
			//   {
			//     v19 = 0.0;
			//   }
			//   else if ( v19 > 8.0 )
			//   {
			//     v19 = 8.0;
			//   }
			//   TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmDepthBias = v19;
			//   v20 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParameters.fields._asmNormalBias_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   if ( v20 < 0.0 )
			//   {
			//     v20 = 0.0;
			//   }
			//   else if ( v20 > 4.0 )
			//   {
			//     v20 = 4.0;
			//   }
			//   TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmNormalBias = v20;
			//   v21 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParameters.fields._asmScreenSizeMin_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmScreenSizeMinSquared = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                                                                                settingParameters.fields._asmScreenSizeMin_k__BackingField,
			//                                                                                                MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit)
			//                                                                                            * v21;
			//   TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmManagerCullingMask = -1;
			//   s_asmManagerCullingMask = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmManagerCullingMask;
			//   TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmManagerCullingMask = s_asmManagerCullingMask & ~(1 << (UnityEngine::LayerMask::NameToLayer((String *)"UI", 0LL) & 0x1F));
			//   v23 = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmManagerCullingMask;
			//   TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmManagerCullingMask = v23 & ~(1 << (UnityEngine::LayerMask::NameToLayer((String *)"UIModel", 0LL) & 0x1F));
			//   v24 = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmManagerCullingMask;
			//   TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmManagerCullingMask = v24 & ~(1 << (UnityEngine::LayerMask::NameToLayer((String *)"Hide", 0LL) & 0x1F));
			//   v25 = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmManagerCullingMask;
			//   TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmManagerCullingMask = v25 & ~(1 << (UnityEngine::LayerMask::NameToLayer((String *)"Gacha", 0LL) & 0x1F));
			//   v26 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//   v27 = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmManagerCullingMask;
			//   v28 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(
			//       TypeInfo::HG::Rendering::Runtime::HGCamera,
			//       TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     v26 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//     v28 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//   }
			//   v26.static_fields.s_asmManagerCullingMask = v27 & ~v28.static_fields.COMPOUND_CHARACTER_LAYER_MASK;
			// }
			// 
		}

		public static void ReinitializeSettingParams(HGSettingParameters settingParameters)
		{
			// // Void ReinitializeSettingParams(HGSettingParameters)
			// void HG::Rendering::Runtime::HGASMManager::ReinitializeSettingParams(
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   __int64 v5; // rdx
			//   Int32Enum__Enum v6; // edi
			//   int32_t v7; // eax
			//   __int64 v8; // rdx
			//   struct HGASMManager__Class *v9; // rcx
			//   int32_t v10; // edi
			//   float v11; // xmm0_4
			//   int v12; // xmm1_4
			//   Int32Enum__Enum v13; // eax
			//   float v14; // xmm0_4
			//   float v15; // xmm0_4
			//   float v16; // xmm6_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDCF9 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     byte_18D8EDCF9 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(425, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(425, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)settingParameters,
			//         0LL);
			//       return;
			//     }
			// LABEL_21:
			//     sub_180B536AC(v4, v3);
			//   }
			//   if ( !settingParameters )
			//     goto LABEL_21;
			//   v6 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//          (SettingParameter_1_System_Int32Enum_ *)settingParameters.fields._asmShadowMapTileResolution_k__BackingField,
			//          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//   if ( !TypeInfo::System::Math._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::System::Math, v5);
			//   v7 = sub_182ACC210(v6, 64LL, 512LL);
			//   v9 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//   v10 = v7;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v8);
			//     v9 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//   }
			//   v9.static_fields.s_asmTileResolution = v10;
			//   v11 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParameters.fields._asmMaxDistance_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   v12 = 1106247680;
			//   if ( v11 < 30.0 || (v12 = 1157234688, v11 > 2000.0) )
			//     v11 = *(float *)&v12;
			//   TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmCacheRadius = v11;
			//   TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmGridSize = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmCacheRadius
			//                                                                                * 0.25;
			//   v13 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//           (SettingParameter_1_System_Int32Enum_ *)settingParameters.fields._asmMaxTileRenderCountPerFrame_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//   TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmMaxTileRenderCountPerFrame = sub_182ACC210(
			//                                                                                                      v13,
			//                                                                                                      1LL,
			//                                                                                                      128LL);
			//   v14 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParameters.fields._asmDepthBias_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   if ( v14 < 0.0 )
			//   {
			//     v14 = 0.0;
			//   }
			//   else if ( v14 > 8.0 )
			//   {
			//     v14 = 8.0;
			//   }
			//   TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmDepthBias = v14;
			//   v15 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParameters.fields._asmNormalBias_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   if ( v15 < 0.0 )
			//   {
			//     v15 = 0.0;
			//   }
			//   else if ( v15 > 4.0 )
			//   {
			//     v15 = 4.0;
			//   }
			//   TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmNormalBias = v15;
			//   v16 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParameters.fields._asmScreenSizeMin_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmScreenSizeMinSquared = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                                                                                settingParameters.fields._asmScreenSizeMin_k__BackingField,
			//                                                                                                MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit)
			//                                                                                            * v16;
			//   HG::Rendering::Runtime::HGASMManager::ForceRegenerateASM(0LL);
			// }
			// 
		}

		public static void ForceRegenerateASM()
		{
			// // Void ForceRegenerateASM()
			// // Hidden C++ exception states: #wind=3
			// void HG::Rendering::Runtime::HGASMManager::ForceRegenerateASM(MethodInfo *method)
			// {
			//   __int64 v1; // rdx
			//   __int64 v2; // rcx
			//   struct HGCamera__Class *v3; // rax
			//   HGCamera__StaticFields *static_fields; // rax
			//   IEnumerable_1_System_Object_ *Values; // rax
			//   List_1_System_Object_ *v6; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   OneofDescriptorProto *v9; // rdx
			//   __int64 v10; // rcx
			//   struct HGASMManager__Class *v11; // rax
			//   Dictionary_2_UnityEngine_Camera_HG_Rendering_Runtime_HGASMManager_ *s_asmManagers; // r9
			//   unsigned __int64 v13; // rdx
			//   signed __int64 v14; // rcx
			//   signed __int64 v15; // rtt
			//   FileDescriptor *v16; // r8
			//   MessageDescriptor *v17; // r9
			//   Object *key; // xmm6_8
			//   unsigned __int64 v19; // xmm0_8
			//   RTHandle *v20; // rcx
			//   __m128 v21; // xmm7
			//   struct HGASMManager__Class *v22; // rax
			//   Dictionary_2_UnityEngine_Camera_HG_Rendering_Runtime_HGASMManager_ *s_cachedASMManagers; // r9
			//   unsigned __int64 v24; // rdx
			//   signed __int64 v25; // rtt
			//   OneofDescriptorProto *v26; // rdx
			//   __int64 v27; // rcx
			//   FileDescriptor *v28; // r8
			//   MessageDescriptor *v29; // r9
			//   Object *v30; // xmm6_8
			//   unsigned __int64 v31; // xmm0_8
			//   HGASMManager *v32; // rbx
			//   RTHandle *v33; // rcx
			//   __int64 v34; // rdx
			//   struct HGASMManager__Class *v35; // rax
			//   Dictionary_2_System_Object_System_Object_ *v36; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v38; // rdx
			//   __int64 v39; // rcx
			//   _BYTE v40[32]; // [rsp+0h] [rbp-C8h] BYREF
			//   _BYTE v41[40]; // [rsp+20h] [rbp-A8h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v42; // [rsp+48h] [rbp-80h] BYREF
			//   List_1_T_Enumerator_System_Object_ v43; // [rsp+70h] [rbp-58h] BYREF
			//   Il2CppExceptionWrapper *v44; // [rsp+88h] [rbp-40h] BYREF
			//   Il2CppExceptionWrapper *v45; // [rsp+90h] [rbp-38h] BYREF
			//   Il2CppExceptionWrapper *v46; // [rsp+98h] [rbp-30h] BYREF
			//   Object *value; // [rsp+D8h] [rbp+10h] BYREF
			// 
			//   if ( !byte_18D8EDCFA )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::TryGetValue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Values);
			//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::ToList<HG::Rendering::Runtime::HGCamera>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCamera>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCamera>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCamera>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Key);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCamera>::GetEnumerator);
			//     byte_18D8EDCFA = 1;
			//   }
			//   memset(&v42, 0, sizeof(v42));
			//   value = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(432, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(432, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v39, v38);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_28 *)Patch, 0LL);
			//   }
			//   else
			//   {
			//     v3 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v1);
			//       v3 = TypeInfo::HG::Rendering::Runtime::HGCamera;
			//     }
			//     static_fields = v3.static_fields;
			//     if ( !static_fields.s_Cameras )
			//       sub_180B536AC(v2, v1);
			//     Values = (IEnumerable_1_System_Object_ *)System::Collections::Generic::Dictionary<unsigned long,System::Object>::get_Values(
			//                                                (Dictionary_2_System_UInt64_System_Object_ *)static_fields.s_Cameras,
			//                                                MethodInfo::System::Collections::Generic::Dictionary<System::ValueTuple<UnityEngine::Camera,int>,HG::Rendering::Runtime::HGCamera>::get_Values);
			//     v6 = System::Linq::Enumerable::ToList<System::Object>(
			//            Values,
			//            MethodInfo::System::Linq::Enumerable::ToList<HG::Rendering::Runtime::HGCamera>);
			//     if ( !v6 )
			//       sub_180B536AC(v8, v7);
			//     System::Collections::Generic::List<System::Object>::GetEnumerator(
			//       (List_1_T_Enumerator_System_Object_ *)v41,
			//       v6,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCamera>::GetEnumerator);
			//     v43 = *(List_1_T_Enumerator_System_Object_ *)v41;
			//     *(_QWORD *)v41 = 0LL;
			//     *(_QWORD *)&v41[8] = &v43;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v43,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCamera>::MoveNext) )
			//       {
			//         if ( !v43._current )
			//           sub_1802DC2C8(v10, v9);
			//         LOBYTE(v43._current[116].monitor) = 1;
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v44 )
			//     {
			//       v9 = (OneofDescriptorProto *)v40;
			//       *(Il2CppExceptionWrapper *)v41 = (Il2CppExceptionWrapper)v44.ex;
			//       v10 = *(_QWORD *)v41;
			//       if ( *(_QWORD *)v41 )
			//         sub_18000F780(*(_QWORD *)v41);
			//     }
			//     v11 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v9);
			//       v11 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//     }
			//     s_asmManagers = v11.static_fields.s_asmManagers;
			//     if ( !s_asmManagers )
			//       goto LABEL_58;
			//     memset(&v41[8], 0, 32);
			//     *(_QWORD *)v41 = s_asmManagers;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v13 = (((unsigned __int64)v41 >> 12) & 0x1FFFFF) >> 6;
			//       _m_prefetchw(&qword_18D6405E0[v13 + 36190]);
			//       do
			//       {
			//         v14 = qword_18D6405E0[v13 + 36190] | (1LL << (((unsigned __int64)v41 >> 12) & 0x3F));
			//         v15 = qword_18D6405E0[v13 + 36190];
			//       }
			//       while ( v15 != _InterlockedCompareExchange64(&qword_18D6405E0[v13 + 36190], v14, v15) );
			//     }
			//     *(_QWORD *)&v41[8] = (unsigned int)s_asmManagers.fields._version;
			//     *(_DWORD *)&v41[32] = 2;
			//     *(_OWORD *)&v41[16] = 0LL;
			//     *(_OWORD *)&v42._dictionary = *(_OWORD *)v41;
			//     v42._current = 0LL;
			//     *(_QWORD *)&v42._getEnumeratorRetType = *(_QWORD *)&v41[32];
			//     *(_QWORD *)v41 = 0LL;
			//     *(_QWORD *)&v41[8] = &v42;
			//     try
			//     {
			//       v21 = 0LL;
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,System::Object>::MoveNext(
			//                 &v42,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::MoveNext) )
			//       {
			//         key = v42._current.key;
			//         v19 = _mm_srli_si128((__m128i)v42._current, 8).m128i_u64[0];
			//         if ( !v19 )
			//           sub_1802DC2C8(v10, v9);
			//         v20 = *(RTHandle **)(v19 + 56);
			//         if ( v20 )
			//           UnityEngine::Rendering::RTHandle::Release(v20, 0LL);
			//         *(_QWORD *)(v19 + 56) = 0LL;
			//         sub_1800054D0(
			//           (OneofDescriptor *)(v19 + 56),
			//           v9,
			//           v16,
			//           v17,
			//           *(String__Array **)v41,
			//           *(String **)&v41[8],
			//           *(MethodInfo **)&v41[16]);
			//         *(_QWORD *)(v19 + 216) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//         *(_DWORD *)(v19 + 224) = 0;
			//         HG::Rendering::Runtime::HGASMManager::Initialize((HGASMManager *)v19, (Camera *)key, 0LL, 0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v45 )
			//     {
			//       v9 = (OneofDescriptorProto *)v40;
			//       *(Il2CppExceptionWrapper *)v41 = (Il2CppExceptionWrapper)v45.ex;
			//       v10 = *(_QWORD *)v41;
			//       if ( *(_QWORD *)v41 )
			//         sub_18000F780(*(_QWORD *)v41);
			//       v21 = 0LL;
			//     }
			//     v22 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v9);
			//       v22 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//     }
			//     s_cachedASMManagers = v22.static_fields.s_cachedASMManagers;
			//     if ( !s_cachedASMManagers )
			// LABEL_58:
			//       sub_1802DC2C8(v10, v9);
			//     memset(&v41[8], 0, 32);
			//     *(_QWORD *)v41 = s_cachedASMManagers;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v24 = (((unsigned __int64)v41 >> 12) & 0x1FFFFF) >> 6;
			//       _m_prefetchw(&qword_18D6405E0[v24 + 36190]);
			//       do
			//         v25 = qword_18D6405E0[v24 + 36190];
			//       while ( v25 != _InterlockedCompareExchange64(
			//                        &qword_18D6405E0[v24 + 36190],
			//                        v25 | (1LL << (((unsigned __int64)v41 >> 12) & 0x3F)),
			//                        v25) );
			//     }
			//     *(_QWORD *)&v41[8] = (unsigned int)s_cachedASMManagers.fields._version;
			//     *(_DWORD *)&v41[32] = 2;
			//     *(_OWORD *)&v42._dictionary = *(_OWORD *)v41;
			//     v42._current = 0LL;
			//     *(_QWORD *)&v42._getEnumeratorRetType = *(_QWORD *)&v41[32];
			//     *(_QWORD *)v41 = 0LL;
			//     *(_QWORD *)&v41[8] = &v42;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,System::Object>::MoveNext(
			//                 &v42,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::MoveNext) )
			//       {
			//         v30 = v42._current.key;
			//         v31 = _mm_srli_si128((__m128i)v42._current, 8).m128i_u64[0];
			//         v32 = (HGASMManager *)v31;
			//         if ( !v31 )
			//           sub_1802DC2C8(v27, v26);
			//         v33 = *(RTHandle **)(v31 + 56);
			//         if ( v33 )
			//           UnityEngine::Rendering::RTHandle::Release(v33, 0LL);
			//         *(_QWORD *)(v31 + 56) = 0LL;
			//         sub_1800054D0(
			//           (OneofDescriptor *)(v31 + 56),
			//           v26,
			//           v28,
			//           v29,
			//           *(String__Array **)v41,
			//           *(String **)&v41[8],
			//           *(MethodInfo **)&v41[16]);
			//         *(_QWORD *)(v31 + 216) = _mm_unpacklo_ps(v21, v21).m128_u64[0];
			//         *(_DWORD *)(v31 + 224) = v21.m128_i32[0];
			//         v35 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//         if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v34);
			//           v35 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//         }
			//         v36 = (Dictionary_2_System_Object_System_Object_ *)v35.static_fields.s_asmManagers;
			//         if ( !v36 )
			//           sub_1802DC2C8(0LL, v34);
			//         if ( System::Collections::Generic::Dictionary<System::Object,System::Object>::TryGetValue(
			//                v36,
			//                v30,
			//                &value,
			//                MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Camera,HG::Rendering::Runtime::HGASMManager>::TryGetValue)
			//           && value )
			//         {
			//           HG::Rendering::Runtime::HGASMManager::Initialize(v32, (Camera *)v30, (RTHandle *)value[3].monitor, 0LL);
			//         }
			//         else
			//         {
			//           HG::Rendering::Runtime::HGASMManager::Initialize(v32, (Camera *)v30, 0LL, 0LL);
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v46 )
			//     {
			//       *(Il2CppExceptionWrapper *)v41 = (Il2CppExceptionWrapper)v46.ex;
			//       if ( *(_QWORD *)v41 )
			//         sub_18000F780(*(_QWORD *)v41);
			//     }
			//   }
			// }
			// 
		}

		public static void SetForceUpdateAllTilesMode(bool enabled)
		{
			// // Void SetForceUpdateAllTilesMode(Boolean)
			// void HG::Rendering::Runtime::HGASMManager::SetForceUpdateAllTilesMode(bool enabled, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   struct HGASMManager__Class *v4; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( !byte_18D8EDCFB )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     byte_18D8EDCFB = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1749, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1749, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_28 *)Patch, enabled, 0LL);
			//   }
			//   else
			//   {
			//     v4 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGASMManager._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGASMManager, v3);
			//       v4 = TypeInfo::HG::Rendering::Runtime::HGASMManager;
			//     }
			//     v4.static_fields.s_forceUpdateAllTilesMode = enabled;
			//   }
			// }
			// 
		}

		[IDTag(1)]
		private static void GetASMShadowMatrixes(Vector2 lightSpaceMins, Vector2 lightSpaceMaxs, Vector3 lightDir, Quaternion lightRotation, Matrix4x4 oldLightToWorld, float zMin, float zMax, float minY, float maxY, out Matrix4x4 worldToLightMatrix, out Matrix4x4 projectionMatrix)
		{
			// // Void GetASMShadowMatrixes(Vector2, Vector2, Vector3, Quaternion, Matrix4x4, Single, Single, Single, Single, Matrix4x4 ByRef, Matrix4x4 ByRef)
			// void HG::Rendering::Runtime::HGASMManager::GetASMShadowMatrixes(
			//         Vector2 lightSpaceMins,
			//         Vector2 lightSpaceMaxs,
			//         Vector3 *lightDir,
			//         Quaternion *lightRotation,
			//         Matrix4x4 *oldLightToWorld,
			//         float zMin,
			//         float zMax,
			//         float minY,
			//         float maxY,
			//         Matrix4x4 *worldToLightMatrix,
			//         Matrix4x4 *projectionMatrix,
			//         MethodInfo *method)
			// {
			//   Vector2 v16; // r8
			//   Vector2 v17; // r9
			//   Vector2 v18; // rax
			//   __int128 v19; // xmm1
			//   __int128 v20; // xmm0
			//   MethodInfo *v21; // r8
			//   Vector3 *v22; // rax
			//   float z; // ecx
			//   MethodInfo *v24; // r9
			//   Vector3 *v25; // rax
			//   __int64 v26; // rdx
			//   MethodInfo *v27; // r9
			//   Vector3 *v28; // rax
			//   __int64 v29; // xmm10_8
			//   float v30; // ebx
			//   float v31; // xmm9_4
			//   __m128 v32; // xmm7
			//   __m128 v33; // xmm6
			//   __int64 v34; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int128 v36; // xmm1
			//   __int128 v37; // xmm0
			//   __int128 v38; // xmm1
			//   Quaternion v39; // xmm0
			//   Vector3 v40; // [rsp+78h] [rbp-90h] BYREF
			//   Vector4 v41; // [rsp+88h] [rbp-80h] BYREF
			//   Vector4 v42; // [rsp+98h] [rbp-70h] BYREF
			//   unsigned __int128 v43; // [rsp+A8h] [rbp-60h]
			//   Quaternion v44; // [rsp+B8h] [rbp-50h] BYREF
			//   Matrix4x4 v45[2]; // [rsp+C8h] [rbp-40h] BYREF
			// 
			//   v43 = __PAIR128__(*(_QWORD *)&lightSpaceMins, *(_QWORD *)&lightSpaceMaxs);
			//   if ( !byte_18D919E5D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     byte_18D919E5D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1750, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1750, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v34);
			//     v36 = *(_OWORD *)&oldLightToWorld.m01;
			//     *(_OWORD *)&v45[0].m00 = *(_OWORD *)&oldLightToWorld.m00;
			//     v37 = *(_OWORD *)&oldLightToWorld.m02;
			//     *(_OWORD *)&v45[0].m01 = v36;
			//     v38 = *(_OWORD *)&oldLightToWorld.m03;
			//     v41.z = lightDir.z;
			//     *(_OWORD *)&v45[0].m02 = v37;
			//     v39 = *lightRotation;
			//     *(_OWORD *)&v45[0].m03 = v38;
			//     *(_QWORD *)&v38 = *(_QWORD *)&lightDir.x;
			//     v44 = v39;
			//     *(_QWORD *)&v41.x = v38;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_676(
			//       Patch,
			//       lightSpaceMins,
			//       lightSpaceMaxs,
			//       (Vector3 *)&v41,
			//       &v44,
			//       v45,
			//       zMin,
			//       zMax,
			//       minY,
			//       maxY,
			//       worldToLightMatrix,
			//       projectionMatrix,
			//       0LL);
			//   }
			//   else
			//   {
			//     v18 = sub_1842BE4B8(lightSpaceMins, lightSpaceMaxs, v16, v17);
			//     *(_QWORD *)&v41.z = 0x3F80000000000000LL;
			//     *(_QWORD *)&v40.x = ((__int64 (__fastcall *)(_QWORD))sub_182C9F010)(v18);
			//     v19 = *(_OWORD *)&oldLightToWorld.m00;
			//     *(_QWORD *)&v41.x = *(_QWORD *)&v40.x;
			//     *(_OWORD *)&v45[0].m00 = v19;
			//     v20 = *(_OWORD *)&oldLightToWorld.m01;
			//     *(_OWORD *)&v45[0].m02 = *(_OWORD *)&oldLightToWorld.m02;
			//     *(_OWORD *)&v45[0].m01 = v20;
			//     *(_OWORD *)&v45[0].m03 = *(_OWORD *)&oldLightToWorld.m03;
			//     v42 = *UnityEngine::Matrix4x4::op_Multiply((Vector4 *)&v44, v45, &v41, 0LL);
			//     v22 = UnityEngine::Vector4::op_Implicit((Vector3 *)&v41, &v42, v21);
			//     *(_QWORD *)&v42.x = *(_QWORD *)&lightDir.x;
			//     z = v22.z;
			//     *(_QWORD *)&v40.x = *(_QWORD *)&v22.x;
			//     v40.z = z;
			//     v42.z = lightDir.z;
			//     v25 = UnityEngine::Vector3::op_Multiply(&v40, (float)(maxY - v40.y) / lightDir.y, (Vector3 *)&v42, v24);
			//     *(_QWORD *)&v20 = *(_QWORD *)v26;
			//     *(_QWORD *)&v19 = *(_QWORD *)&v25.x;
			//     v42.z = v25.z;
			//     LODWORD(v25) = *(_DWORD *)(v26 + 8);
			//     *(_QWORD *)&v42.x = v19;
			//     *(_QWORD *)&v40.x = v20;
			//     LODWORD(v40.z) = (_DWORD)v25;
			//     v28 = UnityEngine::Vector3::op_Addition((Vector3 *)&v41, &v40, (Vector3 *)&v42, v27);
			//     v29 = *(_QWORD *)&v28.x;
			//     v30 = v28.z;
			//     sub_182504AA0(&v41, lightRotation);
			//     v31 = (float)(maxY - minY) / fabs(COERCE_FLOAT(COERCE_UNSIGNED_INT64(Beyond::DampingMath::sinf())));
			//     if ( v31 < 100.0 )
			//     {
			//       v31 = 100.0;
			//     }
			//     else if ( v31 > 100000.0 )
			//     {
			//       v31 = 100000.0;
			//     }
			//     v32 = (__m128)HIDWORD(v43);
			//     v33 = (__m128)DWORD1(v43);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     v44 = *lightRotation;
			//     *(_QWORD *)&v40.x = _mm_unpacklo_ps((__m128)(unsigned int)v43, v33).m128_u64[0];
			//     *(_QWORD *)&v41.x = _mm_unpacklo_ps((__m128)DWORD2(v43), v32).m128_u64[0];
			//     v40.z = v31;
			//     v41.z = zMin;
			//     *(_QWORD *)&v42.x = v29;
			//     v42.z = v30;
			//     HG::Rendering::Runtime::HGASMManager::GetASMShadowMatrixes(
			//       (Vector3 *)&v41,
			//       &v40,
			//       (Vector3 *)&v42,
			//       &v44,
			//       worldToLightMatrix,
			//       projectionMatrix,
			//       0LL);
			//   }
			// }
			// 
		}

		[IDTag(0)]
		private static void GetASMShadowMatrixes(Vector3 mins, Vector3 maxs, Vector3 lightPos, Quaternion lightRotation, out Matrix4x4 worldToLightMatrix, out Matrix4x4 projectionMatrix)
		{
			// // Void GetASMShadowMatrixes(Vector3, Vector3, Vector3, Quaternion, Matrix4x4 ByRef, Matrix4x4 ByRef)
			// void HG::Rendering::Runtime::HGASMManager::GetASMShadowMatrixes(
			//         Vector3 *mins,
			//         Vector3 *maxs,
			//         Vector3 *lightPos,
			//         Quaternion *lightRotation,
			//         Matrix4x4 *worldToLightMatrix,
			//         Matrix4x4 *projectionMatrix,
			//         MethodInfo *method)
			// {
			//   float z; // eax
			//   float3 *xyz; // rax
			//   __int64 v13; // xmm7_8
			//   float v14; // edi
			//   __int64 v15; // rax
			//   __int64 v16; // xmm0_8
			//   MethodInfo *v17; // r8
			//   float3 *v18; // rax
			//   __int64 v19; // xmm6_8
			//   float v20; // ebx
			//   __int64 v21; // rax
			//   __int64 v22; // xmm0_8
			//   Vector4 *AsVector4; // rax
			//   float4x4 *v24; // rax
			//   float4 c1; // xmm1
			//   float4 c2; // xmm0
			//   float4 c3; // xmm1
			//   Matrix4x4 *v28; // rax
			//   __int128 v29; // xmm1
			//   __int128 v30; // xmm2
			//   __int128 v31; // xmm3
			//   int v32; // edx
			//   int v33; // r8d
			//   int v34; // r9d
			//   __int64 v35; // rax
			//   float4 v36; // xmm1
			//   float4 v37; // xmm0
			//   float4 v38; // xmm1
			//   Matrix4x4 *v39; // rax
			//   __int64 v40; // rcx
			//   __int128 v41; // xmm1
			//   __int128 v42; // xmm2
			//   __int128 v43; // xmm3
			//   float *p_m10; // rax
			//   __int64 v45; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Quaternion v47; // xmm0
			//   __int64 v48; // xmm1_8
			//   float4 v49; // [rsp+48h] [rbp-C0h] BYREF
			//   Vector4 v50; // [rsp+58h] [rbp-B0h] BYREF
			//   Vector4 v51; // [rsp+68h] [rbp-A0h] BYREF
			//   Quaternion v52; // [rsp+78h] [rbp-90h] BYREF
			//   float4x4 v53; // [rsp+88h] [rbp-80h] BYREF
			//   float4x4 v54; // [rsp+C8h] [rbp-40h] BYREF
			// 
			//   sub_1802F01E0(&v54, 0LL, 64LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(1751, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1751, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v45);
			//     v47 = *lightRotation;
			//     v51.z = lightPos.z;
			//     v48 = *(_QWORD *)&lightPos.x;
			//     v49.z = maxs.z;
			//     v50.z = mins.z;
			//     v52 = v47;
			//     *(_QWORD *)&v49.x = *(_QWORD *)&maxs.x;
			//     *(_QWORD *)&v47.x = *(_QWORD *)&mins.x;
			//     *(_QWORD *)&v51.x = v48;
			//     *(_QWORD *)&v50.x = *(_QWORD *)&v47.x;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_675(
			//       Patch,
			//       (Vector3 *)&v50,
			//       (Vector3 *)&v49,
			//       (Vector3 *)&v51,
			//       &v52,
			//       worldToLightMatrix,
			//       projectionMatrix,
			//       0LL);
			//   }
			//   else
			//   {
			//     z = lightPos.z;
			//     *(_QWORD *)&v49.x = *(_QWORD *)&lightPos.x;
			//     v49.z = z;
			//     xyz = Unity::Mathematics::float4::get_xyz((float3 *)&v50, &v49, 0LL);
			//     v13 = *(_QWORD *)&xyz.x;
			//     v14 = xyz.z;
			//     v50 = (Vector4)*lightRotation;
			//     v51 = *Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
			//              (Vector4 *)&v52,
			//              (CinemachineSmoothPath_Waypoint *)&v50,
			//              0LL);
			//     v15 = sub_184D32D74(&v50, &v51);
			//     v16 = *(_QWORD *)v15;
			//     LODWORD(v15) = *(_DWORD *)(v15 + 8);
			//     *(_QWORD *)&v49.x = v16;
			//     LODWORD(v49.z) = v15;
			//     v18 = Unity::Mathematics::float3::op_UnaryNegation((float3 *)&v50, (float3 *)&v49, v17);
			//     v19 = *(_QWORD *)&v18.x;
			//     v20 = v18.z;
			//     v50 = (Vector4)*lightRotation;
			//     v49.z = 0.0;
			//     *(_QWORD *)&v49.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
			//     v51 = *Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
			//              (Vector4 *)&v52,
			//              (CinemachineSmoothPath_Waypoint *)&v50,
			//              0LL);
			//     v21 = sub_182344DC0(&v50, &v51, &v49);
			//     *(_QWORD *)&v51.x = v19;
			//     v51.z = v20;
			//     v22 = *(_QWORD *)v21;
			//     LODWORD(v21) = *(_DWORD *)(v21 + 8);
			//     *(_QWORD *)&v49.x = v22;
			//     LODWORD(v49.z) = v21;
			//     v50 = (Vector4)*Unity::Mathematics::quaternion::LookRotationSafe(
			//                       (quaternion *)&v52,
			//                       (float3 *)&v51,
			//                       (float3 *)&v49,
			//                       0LL);
			//     AsVector4 = Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
			//                   (Vector4 *)&v52,
			//                   (CinemachineSmoothPath_Waypoint *)&v50,
			//                   0LL);
			//     *(_QWORD *)&v51.x = v13;
			//     v51.z = v14;
			//     v50 = *AsVector4;
			//     v50 = *Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
			//              (Vector4 *)&v52,
			//              (CinemachineSmoothPath_Waypoint *)&v50,
			//              0LL);
			//     Unity::Mathematics::float4x4::float4x4(&v54, (quaternion *)&v50, (float3 *)&v51, 0LL);
			//     v53 = v54;
			//     v24 = Unity::Mathematics::math::inverse(&v54, &v53, 0LL);
			//     c1 = v24.c1;
			//     v53.c0 = v24.c0;
			//     c2 = v24.c2;
			//     v53.c1 = c1;
			//     c3 = v24.c3;
			//     v53.c2 = c2;
			//     v53.c3 = c3;
			//     v28 = Unity::Mathematics::float4x4::op_Implicit((Matrix4x4 *)&v54, &v53, 0LL);
			//     v29 = *(_OWORD *)&v28.m01;
			//     v30 = *(_OWORD *)&v28.m02;
			//     v31 = *(_OWORD *)&v28.m03;
			//     *(_OWORD *)&worldToLightMatrix.m00 = *(_OWORD *)&v28.m00;
			//     c2.x = maxs.z;
			//     *(_OWORD *)&worldToLightMatrix.m01 = v29;
			//     *(_OWORD *)&worldToLightMatrix.m02 = v30;
			//     *(_OWORD *)&worldToLightMatrix.m03 = v31;
			//     v35 = sub_182A59E70((unsigned int)&v54, v32, v33, v34, LODWORD(c2.x));
			//     v36 = *(float4 *)(v35 + 16);
			//     v53.c0 = *(float4 *)v35;
			//     v37 = *(float4 *)(v35 + 32);
			//     v53.c1 = v36;
			//     v38 = *(float4 *)(v35 + 48);
			//     v53.c2 = v37;
			//     v53.c3 = v38;
			//     v39 = Unity::Mathematics::float4x4::op_Implicit((Matrix4x4 *)&v54, &v53, 0LL);
			//     v40 = 4LL;
			//     v41 = *(_OWORD *)&v39.m01;
			//     v42 = *(_OWORD *)&v39.m02;
			//     v43 = *(_OWORD *)&v39.m03;
			//     *(_OWORD *)&projectionMatrix.m00 = *(_OWORD *)&v39.m00;
			//     *(_OWORD *)&projectionMatrix.m01 = v41;
			//     *(_OWORD *)&projectionMatrix.m02 = v42;
			//     *(_OWORD *)&projectionMatrix.m03 = v43;
			//     p_m10 = &projectionMatrix.m10;
			//     do
			//     {
			//       *p_m10 = -*p_m10;
			//       p_m10 += 4;
			//       --v40;
			//     }
			//     while ( v40 );
			//   }
			// }
			// 
		}

		public void SetASMUpdateMode(HGASMManager.ASMUpdateMode mode)
		{
			// // Void SetASMUpdateMode(HGASMManager+ASMUpdateMode)
			// void HG::Rendering::Runtime::HGASMManager::SetASMUpdateMode(
			//         HGASMManager *this,
			//         HGASMManager_ASMUpdateMode__Enum mode,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1752, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1752, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)this, mode, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_asmUpdateMode = mode;
			//   }
			// }
			// 
		}

		public HGASMManager.ASMUpdateMode GetASMUpdateMode()
		{
			// // HGASMManager+ASMUpdateMode GetASMUpdateMode()
			// HGASMManager_ASMUpdateMode__Enum HG::Rendering::Runtime::HGASMManager::GetASMUpdateMode(
			//         HGASMManager *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1753, 0LL) )
			//     return this.fields.m_asmUpdateMode;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1753, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return HGASMManager.ASMUpdateMode.Stop;
		}

		public void SetStartVTIndex(int startVTIndex)
		{
			// // Void SetStartVTIndex(Int32)
			// void HG::Rendering::Runtime::HGASMManager::SetStartVTIndex(
			//         HGASMManager *this,
			//         int32_t startVTIndex,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1747, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1747, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
			//       (ILFixDynamicMethodWrapper_26 *)Patch,
			//       (Object *)this,
			//       startVTIndex,
			//       0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_startVTIdx = startVTIndex;
			//   }
			// }
			// 
		}

		public void Initialize(Camera camera, RTHandle existingRT = null)
		{
			// // Void Initialize(Camera, RTHandle)
			// void HG::Rendering::Runtime::HGASMManager::Initialize(
			//         HGASMManager *this,
			//         Camera *camera,
			//         RTHandle *existingRT,
			//         MethodInfo *method)
			// {
			//   HGASMVirtualTextureAllocator *m_vtAllocator; // r14
			//   ASMTileManager *m_asmTileManager; // rcx
			//   HGASMManager__StaticFields *static_fields; // rdx
			//   FileDescriptor *v10; // r8
			//   MessageDescriptor *v11; // r9
			//   HGCamera *v12; // rbx
			//   __m128 *InterpolatedPhase; // rax
			//   float v14; // xmm2_4
			//   int32_t s_asmTileResolution; // edi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *colorFormat; // [rsp+28h] [rbp-100h]
			//   String *v18; // [rsp+30h] [rbp-F8h]
			//   MethodInfo *wrapMode; // [rsp+38h] [rbp-F0h]
			// 
			//   if ( !byte_18D919E5E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RTHandles);
			//     sub_18003C530(&off_18D5EFF48);
			//     byte_18D919E5E = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(433, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(433, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//         (ILFixDynamicMethodWrapper_28 *)Patch,
			//         (Object *)this,
			//         (Object *)camera,
			//         (Object *)existingRT,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_15;
			//   }
			//   m_vtAllocator = this.fields.m_vtAllocator;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//   static_fields = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields;
			//   if ( !m_vtAllocator )
			//     goto LABEL_15;
			//   HG::Rendering::Runtime::HGASMVirtualTextureAllocator::Initialize(
			//     m_vtAllocator,
			//     static_fields.s_asmTileResolution,
			//     0LL);
			//   m_asmTileManager = this.fields.m_asmTileManager;
			//   if ( !m_asmTileManager )
			//     goto LABEL_15;
			//   HG::Rendering::Runtime::ASMTileManager::Initialize(m_asmTileManager, 0LL);
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Inequality((Object_1 *)camera, 0LL, 0LL) )
			//     goto LABEL_9;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCamera);
			//   v12 = HG::Rendering::Runtime::HGCamera::GetOrCreate(camera, 0, 0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//   InterpolatedPhase = (__m128 *)HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(v12, 0LL);
			//   if ( !InterpolatedPhase )
			// LABEL_15:
			//     sub_180B536AC(m_asmTileManager, static_fields);
			//   v14 = InterpolatedPhase[197].m128_f32[1];
			//   LODWORD(this.fields.m_asmCasterMaxY) = _mm_shuffle_ps(InterpolatedPhase[197], InterpolatedPhase[197], 170).m128_u32[0];
			//   this.fields.m_asmCasterMinY = v14;
			// LABEL_9:
			//   if ( !this.fields.m_asmShadowMapRT )
			//   {
			//     if ( existingRT )
			//     {
			//       this.fields.m_asmShadowMapRT = existingRT;
			//     }
			//     else
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//       s_asmTileResolution = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmTileResolution;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::RTHandles);
			//       this.fields.m_asmShadowMapRT = UnityEngine::Rendering::RTHandles::Alloc(
			//                                         16 * s_asmTileResolution,
			//                                         16 * s_asmTileResolution,
			//                                         1,
			//                                         DepthBits__Enum_Depth16,
			//                                         GraphicsFormat__Enum_R8G8B8A8_SRGB,
			//                                         FilterMode__Enum_Point,
			//                                         TextureWrapMode__Enum_Clamp,
			//                                         TextureDimension__Enum_Tex2D,
			//                                         0,
			//                                         0,
			//                                         0,
			//                                         1,
			//                                         1,
			//                                         0.0,
			//                                         MSAASamples__Enum_None,
			//                                         0,
			//                                         RenderTextureMemoryless__Enum_None,
			//                                         (String *)"ASM Shadowmap",
			//                                         0LL);
			//     }
			//     sub_1800054D0(
			//       (OneofDescriptor *)&this.fields.m_asmShadowMapRT,
			//       (OneofDescriptorProto *)static_fields,
			//       v10,
			//       v11,
			//       colorFormat,
			//       v18,
			//       wrapMode);
			//   }
			// }
			// 
		}

		public void UpdateFrustumVerts(Camera camera, Vector3 cameraPos)
		{
			// // Void UpdateFrustumVerts(Camera, Vector3)
			// void HG::Rendering::Runtime::HGASMManager::UpdateFrustumVerts(
			//         HGASMManager *this,
			//         Camera *camera,
			//         Vector3 *cameraPos,
			//         MethodInfo *method)
			// {
			//   Matrix4x4 *inverse; // rax
			//   __int64 v8; // rdx
			//   ASMTileManager *m_asmTileManager; // rcx
			//   __int128 v10; // xmm10
			//   __int128 v11; // xmm11
			//   __int128 v12; // xmm12
			//   __int128 v13; // xmm13
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   __int64 v16; // r8
			//   __int64 v17; // r9
			//   int32_t pixelHeight; // eax
			//   Beyond::DampingMath *v19; // rcx
			//   __m128i si128; // xmm8
			//   HGASMManager__StaticFields *static_fields; // rbx
			//   double v22; // xmm0_8
			//   float v23; // xmm7_4
			//   double v24; // xmm0_8
			//   float v25; // xmm7_4
			//   __m128i v26; // xmm6
			//   float farClipPlane; // xmm0_4
			//   float y; // xmm1_4
			//   MethodInfo *v29; // r8
			//   Vector3 *v30; // rax
			//   float z; // ecx
			//   Transform *transform; // rax
			//   MethodInfo *localRotation; // rax
			//   Vector3 *one; // rax
			//   Vector4 *v35; // rdx
			//   Vector4 v36; // xmm0
			//   __int64 v37; // xmm1_8
			//   float v38; // ecx
			//   __int64 v39; // xmm1_8
			//   Matrix4x4 *v40; // rax
			//   float v41; // xmm1_4
			//   __int128 v42; // xmm7
			//   __int128 v43; // xmm8
			//   __int128 v44; // xmm9
			//   __int128 v45; // xmm14
			//   Vector2__Array *m_frustumVerts; // rax
			//   Vector2__Array *m_frustumVertsForIndirect; // rax
			//   float v48; // xmm1_4
			//   int v49; // ebx
			//   Vector3__Array *v50; // rsi
			//   unsigned int *v51; // rax
			//   unsigned int v52; // xmm6_4
			//   __int64 v53; // rax
			//   __int64 v54; // rax
			//   MethodInfo *v55; // r8
			//   Vector3 *v56; // rax
			//   __int64 v57; // xmm3_8
			//   Vector3__Array *m_frustumCornersLightSpace; // rsi
			//   unsigned int *v59; // rax
			//   unsigned int v60; // xmm6_4
			//   __int64 v61; // rax
			//   __int64 v62; // rax
			//   MethodInfo *v63; // r8
			//   Vector3 *v64; // rax
			//   __int64 v65; // xmm0_8
			//   float v66; // eax
			//   Vector2__Array *v67; // rsi
			//   float *v68; // rax
			//   float v69; // xmm6_4
			//   float v70; // xmm0_4
			//   __int64 v71; // rax
			//   Vector3__Array *v72; // rsi
			//   unsigned int *v73; // rax
			//   unsigned int v74; // xmm6_4
			//   __int64 v75; // rax
			//   __int64 v76; // rax
			//   MethodInfo *v77; // r8
			//   Vector3 *v78; // rax
			//   __int64 v79; // xmm3_8
			//   Vector3__Array *m_frustumCornersLightSpaceForIndirect; // rsi
			//   float *v81; // rax
			//   float v82; // xmm6_4
			//   __int64 v83; // rax
			//   float v84; // xmm0_4
			//   __int64 v85; // rax
			//   MethodInfo *v86; // r8
			//   Vector3 *v87; // rax
			//   __int64 v88; // xmm0_8
			//   float v89; // eax
			//   Vector2__Array *v90; // rsi
			//   float *v91; // rax
			//   float v92; // xmm6_4
			//   float v93; // xmm0_4
			//   __int64 v94; // rax
			//   float v95; // eax
			//   Vector3__Array *m_frustumCorners; // [rsp+28h] [rbp-E0h]
			//   Vector3__Array *m_frustumCornersForIndirect; // [rsp+28h] [rbp-E0h]
			//   Vector4 v98; // [rsp+38h] [rbp-D0h] BYREF
			//   Vector4 v99; // [rsp+48h] [rbp-C0h] BYREF
			//   Vector3 v100; // [rsp+58h] [rbp-B0h] BYREF
			//   Vector3 v101; // [rsp+68h] [rbp-A0h] BYREF
			//   Vector3 v102; // [rsp+78h] [rbp-90h] BYREF
			//   Matrix4x4 v103; // [rsp+88h] [rbp-80h] BYREF
			//   Vector4 v104; // [rsp+C8h] [rbp-40h] BYREF
			//   Vector4 v105; // [rsp+D8h] [rbp-30h]
			//   Vector4 v106; // [rsp+E8h] [rbp-20h]
			//   Vector4 v107; // [rsp+F8h] [rbp-10h]
			//   __int64 v108; // [rsp+108h] [rbp+0h] BYREF
			//   int v109; // [rsp+110h] [rbp+8h]
			//   Vector3 v110; // [rsp+118h] [rbp+10h] BYREF
			//   Vector3 v111; // [rsp+128h] [rbp+20h] BYREF
			//   Vector3 v112; // [rsp+138h] [rbp+30h] BYREF
			//   Vector4 v113; // [rsp+148h] [rbp+40h] BYREF
			//   Vector4 v114; // [rsp+158h] [rbp+50h] BYREF
			//   Vector4 v115; // [rsp+168h] [rbp+60h] BYREF
			//   Vector4 v116; // [rsp+178h] [rbp+70h] BYREF
			// 
			//   if ( !byte_18D919E5F )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     byte_18D919E5F = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1754, 0LL) )
			//   {
			//     inverse = UnityEngine::Matrix4x4::get_inverse(&v103, &this.fields.m_lightToWorld, 0LL);
			//     v10 = *(_OWORD *)&inverse.m00;
			//     v11 = *(_OWORD *)&inverse.m01;
			//     v12 = *(_OWORD *)&inverse.m02;
			//     v13 = *(_OWORD *)&inverse.m03;
			//     if ( camera )
			//     {
			//       UnityEngine::Camera::get_fieldOfView(camera, 0LL);
			//       UnityEngine::Camera::get_fieldOfView(camera, 0LL);
			//       UnityEngine::Camera::get_pixelWidth(camera, 0LL);
			//       sub_1802ED290(v15, v14, v16, v17);
			//       pixelHeight = UnityEngine::Camera::get_pixelHeight(camera, 0LL);
			//       Beyond::DampingMath::fast_atan(v19, (float)pixelHeight);
			//       si128 = _mm_load_si128((const __m128i *)&xmmword_18A357450);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields;
			//       v22 = Beyond::DampingMath::cosf();
			//       v23 = *(float *)&v22;
			//       v24 = Beyond::DampingMath::cosf();
			//       if ( *(float *)&v24 <= v23 )
			//         v23 = *(float *)&v24;
			//       v25 = v23 * static_fields.s_asmCacheRadius;
			//       m_frustumCorners = this.fields.m_frustumCorners;
			//       v99 = (Vector4)si128;
			//       UnityEngine::Camera::CalculateFrustumCorners(
			//         camera,
			//         (Rect *)&v99,
			//         v25,
			//         Camera_MonoOrStereoscopicEye__Enum_Mono,
			//         m_frustumCorners,
			//         0LL);
			//       v26 = _mm_load_si128((const __m128i *)&xmmword_18A357450);
			//       farClipPlane = UnityEngine::Camera::get_farClipPlane(camera, 0LL);
			//       m_frustumCornersForIndirect = this.fields.m_frustumCornersForIndirect;
			//       v99 = (Vector4)v26;
			//       UnityEngine::Camera::CalculateFrustumCorners(
			//         camera,
			//         (Rect *)&v99,
			//         farClipPlane,
			//         Camera_MonoOrStereoscopicEye__Enum_Mono,
			//         m_frustumCornersForIndirect,
			//         0LL);
			//       y = cameraPos.y;
			//       v104.x = cameraPos.x;
			//       v104.z = cameraPos.z;
			//       v104.y = y;
			//       v104.w = 1.0;
			//       *(_OWORD *)&v103.m00 = v10;
			//       v99 = v104;
			//       *(_OWORD *)&v103.m01 = v11;
			//       *(_OWORD *)&v103.m02 = v12;
			//       *(_OWORD *)&v103.m03 = v13;
			//       v99 = *UnityEngine::Matrix4x4::op_Multiply(&v98, &v103, &v99, 0LL);
			//       v30 = UnityEngine::Vector4::op_Implicit(&v100, &v99, v29);
			//       z = v30.z;
			//       *(_QWORD *)&this.fields.m_cameraPosLightSpace.x = *(_QWORD *)&v30.x;
			//       this.fields.m_cameraPosLightSpace.z = z;
			//       transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
			//       if ( transform )
			//       {
			//         localRotation = (MethodInfo *)UnityEngine::Transform::get_localRotation((Quaternion *)&v98, transform, 0LL);
			//         one = UnityEngine::Vector3::get_one(&v100, localRotation);
			//         v36 = *v35;
			//         v37 = *(_QWORD *)&one.x;
			//         v38 = one.z;
			//         *(float *)&one = cameraPos.z;
			//         *(_QWORD *)&v101.x = v37;
			//         v39 = *(_QWORD *)&cameraPos.x;
			//         v101.z = v38;
			//         *(_QWORD *)&v102.x = v39;
			//         v99 = v36;
			//         LODWORD(v102.z) = (_DWORD)one;
			//         v40 = UnityEngine::Matrix4x4::TRS(&v103, &v102, (Quaternion *)&v99, &v101, 0LL);
			//         v41 = this.fields.m_cameraPosLightSpace.y;
			//         v42 = *(_OWORD *)&v40.m00;
			//         v43 = *(_OWORD *)&v40.m01;
			//         v44 = *(_OWORD *)&v40.m02;
			//         v45 = *(_OWORD *)&v40.m03;
			//         m_frustumVerts = this.fields.m_frustumVerts;
			//         if ( m_frustumVerts )
			//         {
			//           if ( !m_frustumVerts.max_length.size )
			//             goto LABEL_38;
			//           m_frustumVerts.vector[0].x = this.fields.m_cameraPosLightSpace.x;
			//           m_frustumVerts.vector[0].y = v41;
			//           m_frustumVertsForIndirect = this.fields.m_frustumVertsForIndirect;
			//           v48 = this.fields.m_cameraPosLightSpace.y;
			//           if ( !m_frustumVertsForIndirect )
			//             goto LABEL_40;
			//           if ( !m_frustumVertsForIndirect.max_length.size )
			// LABEL_38:
			//             sub_180070270(m_asmTileManager, v8);
			//           m_frustumVertsForIndirect.vector[0].x = this.fields.m_cameraPosLightSpace.x;
			//           v49 = 0;
			//           m_frustumVertsForIndirect.vector[0].y = v48;
			//           do
			//           {
			//             v50 = this.fields.m_frustumCorners;
			//             m_asmTileManager = (ASMTileManager *)v50;
			//             if ( !v50 )
			//               goto LABEL_40;
			//             v51 = (unsigned int *)sub_18003EB60(v50, v49);
			//             m_asmTileManager = (ASMTileManager *)this.fields.m_frustumCorners;
			//             v52 = *v51;
			//             if ( !m_asmTileManager )
			//               goto LABEL_40;
			//             v53 = sub_18003EB60(m_asmTileManager, v49);
			//             m_asmTileManager = (ASMTileManager *)this.fields.m_frustumCorners;
			//             if ( !m_asmTileManager )
			//               goto LABEL_40;
			//             *(_QWORD *)&v105.x = __PAIR64__(*(_DWORD *)(v53 + 4), v52);
			//             v54 = sub_18003EB60(m_asmTileManager, v49);
			//             v105.w = 1.0;
			//             *(_OWORD *)&v103.m00 = v42;
			//             *(_OWORD *)&v103.m01 = v43;
			//             v105.z = *(float *)(v54 + 8);
			//             *(_OWORD *)&v103.m02 = v44;
			//             v98 = v105;
			//             *(_OWORD *)&v103.m03 = v45;
			//             v98 = *UnityEngine::Matrix4x4::op_Multiply(&v113, &v103, &v98, 0LL);
			//             v56 = UnityEngine::Vector4::op_Implicit(&v110, &v98, v55);
			//             v57 = *(_QWORD *)&v56.x;
			//             *(float *)&v56 = v56.z;
			//             *(_QWORD *)&v102.x = v57;
			//             LODWORD(v102.z) = (_DWORD)v56;
			//             sub_180040FA0(v50, v49, &v102);
			//             m_asmTileManager = (ASMTileManager *)this.fields.m_frustumCorners;
			//             m_frustumCornersLightSpace = this.fields.m_frustumCornersLightSpace;
			//             if ( !m_asmTileManager )
			//               goto LABEL_40;
			//             v59 = (unsigned int *)sub_18003EB60(m_asmTileManager, v49);
			//             m_asmTileManager = (ASMTileManager *)this.fields.m_frustumCorners;
			//             v60 = *v59;
			//             if ( !m_asmTileManager )
			//               goto LABEL_40;
			//             v61 = sub_18003EB60(m_asmTileManager, v49);
			//             m_asmTileManager = (ASMTileManager *)this.fields.m_frustumCorners;
			//             if ( !m_asmTileManager )
			//               goto LABEL_40;
			//             *(_QWORD *)&v106.x = __PAIR64__(*(_DWORD *)(v61 + 4), v60);
			//             v62 = sub_18003EB60(m_asmTileManager, v49);
			//             v106.w = 1.0;
			//             *(_OWORD *)&v103.m00 = v10;
			//             *(_OWORD *)&v103.m01 = v11;
			//             v106.z = *(float *)(v62 + 8);
			//             *(_OWORD *)&v103.m02 = v12;
			//             v98 = v106;
			//             *(_OWORD *)&v103.m03 = v13;
			//             v98 = *UnityEngine::Matrix4x4::op_Multiply(&v114, &v103, &v98, 0LL);
			//             v64 = UnityEngine::Vector4::op_Implicit(&v111, &v98, v63);
			//             if ( !m_frustumCornersLightSpace )
			//               goto LABEL_40;
			//             v65 = *(_QWORD *)&v64.x;
			//             v66 = v64.z;
			//             *(_QWORD *)&v101.x = v65;
			//             v101.z = v66;
			//             sub_180040FA0(m_frustumCornersLightSpace, v49, &v101);
			//             m_asmTileManager = (ASMTileManager *)this.fields.m_frustumCornersLightSpace;
			//             v67 = this.fields.m_frustumVerts;
			//             if ( !m_asmTileManager )
			//               goto LABEL_40;
			//             v68 = (float *)sub_18003EB60(m_asmTileManager, v49);
			//             m_asmTileManager = (ASMTileManager *)this.fields.m_frustumCornersLightSpace;
			//             v69 = *v68;
			//             if ( !m_asmTileManager )
			//               goto LABEL_40;
			//             v70 = *(float *)(sub_18003EB60(m_asmTileManager, v49) + 4);
			//             if ( !v67 )
			//               goto LABEL_40;
			//             v71 = v49 + 1LL;
			//             if ( (unsigned int)v71 >= v67.max_length.size )
			//               goto LABEL_38;
			//             v67.vector[v71].x = v69;
			//             v67.vector[v71].y = v70;
			//             v72 = this.fields.m_frustumCornersForIndirect;
			//             m_asmTileManager = (ASMTileManager *)v72;
			//             if ( !v72 )
			//               goto LABEL_40;
			//             v73 = (unsigned int *)sub_18003EB60(v72, v49);
			//             m_asmTileManager = (ASMTileManager *)this.fields.m_frustumCornersForIndirect;
			//             v74 = *v73;
			//             if ( !m_asmTileManager )
			//               goto LABEL_40;
			//             v75 = sub_18003EB60(m_asmTileManager, v49);
			//             m_asmTileManager = (ASMTileManager *)this.fields.m_frustumCornersForIndirect;
			//             if ( !m_asmTileManager )
			//               goto LABEL_40;
			//             *(_QWORD *)&v107.x = __PAIR64__(*(_DWORD *)(v75 + 4), v74);
			//             v76 = sub_18003EB60(m_asmTileManager, v49);
			//             v107.w = 1.0;
			//             *(_OWORD *)&v103.m00 = v42;
			//             *(_OWORD *)&v103.m01 = v43;
			//             v107.z = *(float *)(v76 + 8);
			//             *(_OWORD *)&v103.m02 = v44;
			//             v98 = v107;
			//             *(_OWORD *)&v103.m03 = v45;
			//             v98 = *UnityEngine::Matrix4x4::op_Multiply(&v115, &v103, &v98, 0LL);
			//             v78 = UnityEngine::Vector4::op_Implicit(&v112, &v98, v77);
			//             v79 = *(_QWORD *)&v78.x;
			//             *(float *)&v78 = v78.z;
			//             v108 = v79;
			//             v109 = (int)v78;
			//             sub_180040FA0(v72, v49, &v108);
			//             m_asmTileManager = (ASMTileManager *)this.fields.m_frustumCornersForIndirect;
			//             m_frustumCornersLightSpaceForIndirect = this.fields.m_frustumCornersLightSpaceForIndirect;
			//             if ( !m_asmTileManager )
			//               goto LABEL_40;
			//             v81 = (float *)sub_18003EB60(m_asmTileManager, v49);
			//             m_asmTileManager = (ASMTileManager *)this.fields.m_frustumCornersForIndirect;
			//             v82 = *v81;
			//             if ( !m_asmTileManager )
			//               goto LABEL_40;
			//             v83 = sub_18003EB60(m_asmTileManager, v49);
			//             m_asmTileManager = (ASMTileManager *)this.fields.m_frustumCornersForIndirect;
			//             v84 = *(float *)(v83 + 4);
			//             if ( !m_asmTileManager )
			//               goto LABEL_40;
			//             v99.x = v82;
			//             v99.y = v84;
			//             v85 = sub_18003EB60(m_asmTileManager, v49);
			//             v99.w = 1.0;
			//             *(_OWORD *)&v103.m00 = v10;
			//             *(_OWORD *)&v103.m01 = v11;
			//             v99.z = *(float *)(v85 + 8);
			//             *(_OWORD *)&v103.m02 = v12;
			//             v98 = v99;
			//             *(_OWORD *)&v103.m03 = v13;
			//             v98 = *UnityEngine::Matrix4x4::op_Multiply(&v116, &v103, &v98, 0LL);
			//             v87 = UnityEngine::Vector4::op_Implicit((Vector3 *)&v104, &v98, v86);
			//             if ( !m_frustumCornersLightSpaceForIndirect )
			//               goto LABEL_40;
			//             v88 = *(_QWORD *)&v87.x;
			//             v89 = v87.z;
			//             *(_QWORD *)&v100.x = v88;
			//             v100.z = v89;
			//             sub_180040FA0(m_frustumCornersLightSpaceForIndirect, v49, &v100);
			//             m_asmTileManager = (ASMTileManager *)this.fields.m_frustumCornersLightSpaceForIndirect;
			//             v90 = this.fields.m_frustumVertsForIndirect;
			//             if ( !m_asmTileManager )
			//               goto LABEL_40;
			//             v91 = (float *)sub_18003EB60(m_asmTileManager, v49);
			//             m_asmTileManager = (ASMTileManager *)this.fields.m_frustumCornersLightSpaceForIndirect;
			//             v92 = *v91;
			//             if ( !m_asmTileManager )
			//               goto LABEL_40;
			//             v93 = *(float *)(sub_18003EB60(m_asmTileManager, v49) + 4);
			//             if ( !v90 )
			//               goto LABEL_40;
			//             v94 = v49 + 1LL;
			//             if ( (unsigned int)v94 >= v90.max_length.size )
			//               goto LABEL_38;
			//             ++v49;
			//             v90.vector[v94].x = v92;
			//             v90.vector[v94].y = v93;
			//           }
			//           while ( v49 < 4 );
			//           m_asmTileManager = this.fields.m_asmTileManager;
			//           if ( m_asmTileManager )
			//           {
			//             HG::Rendering::Runtime::ASMTileManager::SetFrustumVerts(
			//               m_asmTileManager,
			//               this.fields.m_frustumVerts,
			//               this.fields.m_frustumVertsForIndirect,
			//               0LL);
			//             return;
			//           }
			//         }
			//       }
			//     }
			// LABEL_40:
			//     sub_180B536AC(m_asmTileManager, v8);
			//   }
			//   m_asmTileManager = (ASMTileManager *)IFix::WrappersManagerImpl::GetPatch(1754, 0LL);
			//   if ( !m_asmTileManager )
			//     goto LABEL_40;
			//   v95 = cameraPos.z;
			//   *(_QWORD *)&v100.x = *(_QWORD *)&cameraPos.x;
			//   v100.z = v95;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_679(
			//     (ILFixDynamicMethodWrapper_2 *)m_asmTileManager,
			//     (Object *)this,
			//     (Object *)camera,
			//     &v100,
			//     0LL);
			// }
			// 
		}

		public void BeginFrame(HGCamera hgCamera, HGSettingParameters settingParams)
		{
			// // Void BeginFrame(HGCamera, HGSettingParameters)
			// // Hidden C++ exception states: #wind=3
			// void HG::Rendering::Runtime::HGASMManager::BeginFrame(
			//         HGASMManager *this,
			//         HGCamera *hgCamera,
			//         HGSettingParameters *settingParams,
			//         MethodInfo *method)
			// {
			//   HGASMManager *v6; // rdi
			//   int32_t s_asmMaxTileRenderCountPerFrame; // esi
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Component *camera; // r13
			//   Object_1 *SunSourceLight; // r15
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   bool v16; // r12
			//   HGEnvironmentVolumeCameraComponent *m_envVolumeCameraComponent; // r14
			//   HGEnvironmentPhase *m_interpolatedPhase; // r14
			//   Transform *transform; // rax
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   Transform *v22; // r15
			//   __m128i v23; // xmm7
			//   __int128 v24; // xmm8
			//   __int128 v25; // xmm9
			//   __int128 v26; // xmm10
			//   __int128 v27; // xmm11
			//   __int64 v28; // xmm0_8
			//   unsigned int z_low; // eax
			//   MethodInfo *v30; // rdx
			//   Animator *v31; // rdx
			//   int32_t v32; // r8d
			//   MethodInfo *v33; // r9
			//   Matrix4x4 *v34; // rax
			//   Vector3 *forward; // rax
			//   __m128i v36; // xmm3
			//   unsigned __int64 v37; // xmm6_8
			//   int v38; // r15d
			//   HGASMVirtualTextureAllocator *m_vtAllocator; // r14
			//   __int64 v40; // rcx
			//   HGASMManager__StaticFields *static_fields; // rdx
			//   HGASMManager *m_friendASMManager; // rax
			//   __int64 v43; // rdx
			//   __int64 v44; // rcx
			//   HGASMManager *v45; // r14
			//   HGASMVirtualTextureAllocator *v46; // r14
			//   __int64 v47; // rcx
			//   HGASMManager__StaticFields *v48; // rdx
			//   HGASMManager *v49; // r14
			//   HGASMManager *v50; // r14
			//   HGASMManager *v51; // r14
			//   float y; // xmm7_4
			//   Transform *v53; // rax
			//   __int64 v54; // rdx
			//   __int64 v55; // rcx
			//   Vector3 *position; // rax
			//   __int64 v57; // xmm8_8
			//   float z; // r14d
			//   HGASMManager__StaticFields *v59; // rcx
			//   __m128 x_low; // xmm6
			//   __m128 y_low; // xmm7
			//   Vector2 v62; // rax
			//   double v63; // xmm0_8
			//   int32_t m_asmUpdateMode; // eax
			//   MethodInfo *v65; // rdx
			//   ProfilerMarker_AutoScope v66; // rdx
			//   ASMTileManager *v67; // rsi
			//   Vector2__Array *m_frustumVerts; // rcx
			//   __int64 v69; // rcx
			//   MethodInfo *v70; // rdx
			//   ProfilerMarker_AutoScope v71; // rdx
			//   ASMTileManager *v72; // rsi
			//   Vector2__Array *v73; // rcx
			//   __int64 v74; // rcx
			//   HGASMManager__StaticFields *v75; // rdx
			//   MethodInfo *v76; // rdx
			//   ProfilerMarker_AutoScope v77; // rdx
			//   ASMTileManager *v78; // rsi
			//   HGASMVirtualTextureAllocator *v79; // r14
			//   Vector2__Array *v80; // rcx
			//   __int64 v81; // rdx
			//   __int64 v82; // rcx
			//   __int64 v83; // rdx
			//   HGASMVirtualTextureAllocator *v84; // rcx
			//   ASMTileManager *m_asmTileManager; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v87; // rdx
			//   __int64 v88; // rcx
			//   Vector3 centerPoint; // [rsp+30h] [rbp-138h] BYREF
			//   Il2CppException *ex; // [rsp+40h] [rbp-128h] BYREF
			//   _QWORD *v91; // [rsp+48h] [rbp-120h]
			//   _QWORD v92[2]; // [rsp+50h] [rbp-118h] BYREF
			//   Vector3 maxRenderCount; // [rsp+60h] [rbp-108h] BYREF
			//   __m128i v94; // [rsp+70h] [rbp-F8h] BYREF
			//   Il2CppExceptionWrapper *v95; // [rsp+80h] [rbp-E8h] BYREF
			//   Il2CppExceptionWrapper *v96; // [rsp+88h] [rbp-E0h] BYREF
			//   Il2CppExceptionWrapper *v97; // [rsp+90h] [rbp-D8h] BYREF
			//   Matrix4x4 v98[2]; // [rsp+98h] [rbp-D0h] BYREF
			// 
			//   v6 = this;
			//   if ( byte_18D919E60 )
			//   {
			//     s_asmMaxTileRenderCountPerFrame = 1;
			//   }
			//   else
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     s_asmMaxTileRenderCountPerFrame = 1;
			//     byte_18D919E60 = 1;
			//   }
			//   centerPoint.x = 0.0;
			//   centerPoint.y = 0.0;
			//   centerPoint.z = 0.0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1755, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1755, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v88, v87);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//       (ILFixDynamicMethodWrapper_28 *)Patch,
			//       (Object *)v6,
			//       (Object *)hgCamera,
			//       (Object *)settingParams,
			//       0LL);
			//     return;
			//   }
			//   if ( !hgCamera )
			//     sub_180B536AC(v9, v8);
			//   camera = (Component *)hgCamera.fields.camera;
			//   SunSourceLight = (Object_1 *)UnityEngine::Light::GetSunSourceLight(0LL);
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Implicit(SunSourceLight, 0LL) )
			//   {
			//     m_asmTileManager = v6.fields.m_asmTileManager;
			//     if ( !m_asmTileManager )
			//       sub_180B536AC(v13, v12);
			//     goto LABEL_60;
			//   }
			//   if ( !hgCamera.fields.m_envVolumeCameraComponent )
			//     sub_180B536AC(v13, v12);
			//   v16 = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::UseDirLightDataFromEnvDirectly(
			//           hgCamera.fields.m_envVolumeCameraComponent,
			//           (Light *)SunSourceLight,
			//           0LL);
			//   m_envVolumeCameraComponent = hgCamera.fields.m_envVolumeCameraComponent;
			//   if ( !m_envVolumeCameraComponent )
			//     sub_180B536AC(v15, v14);
			//   m_interpolatedPhase = m_envVolumeCameraComponent.fields.m_interpolatedPhase;
			//   if ( !m_interpolatedPhase )
			//     sub_180B536AC(v15, v14);
			//   if ( !SunSourceLight )
			//     sub_180B536AC(v15, v14);
			//   transform = UnityEngine::Component::get_transform((Component *)SunSourceLight, 0LL);
			//   v22 = transform;
			//   if ( v16 )
			//   {
			//     v23 = _mm_loadu_si128((const __m128i *)&m_interpolatedPhase.fields.lightConfig.rotationDirect);
			//     v24 = *(_OWORD *)&m_interpolatedPhase.fields.lightConfig.localToWorld.m00;
			//     v25 = *(_OWORD *)&m_interpolatedPhase.fields.lightConfig.localToWorld.m01;
			//     v26 = *(_OWORD *)&m_interpolatedPhase.fields.lightConfig.localToWorld.m02;
			//     v27 = *(_OWORD *)&m_interpolatedPhase.fields.lightConfig.localToWorld.m03;
			//     v28 = *(_QWORD *)&m_interpolatedPhase.fields.lightConfig.forwardDirect.x;
			//     z_low = LODWORD(m_interpolatedPhase.fields.lightConfig.forwardDirect.z);
			//   }
			//   else
			//   {
			//     if ( !transform )
			//       sub_180B536AC(v21, v20);
			//     v23 = _mm_loadu_si128((const __m128i *)UnityEngine::Transform::get_rotation((Quaternion *)&v94, transform, 0LL));
			//     centerPoint = *UnityEngine::Vector3::get_one(&maxRenderCount, v30);
			//     v94 = v23;
			//     maxRenderCount = *UnityEngine::Animator::GetVector((Vector3 *)&ex, v31, v32, v33);
			//     v34 = UnityEngine::Matrix4x4::TRS(v98, &maxRenderCount, (Quaternion *)&v94, &centerPoint, 0LL);
			//     v24 = *(_OWORD *)&v34.m00;
			//     v25 = *(_OWORD *)&v34.m01;
			//     v26 = *(_OWORD *)&v34.m02;
			//     v27 = *(_OWORD *)&v34.m03;
			//     forward = UnityEngine::Transform::get_forward((Vector3 *)&ex, v22, 0LL);
			//     v28 = *(_QWORD *)&forward.x;
			//     z_low = LODWORD(forward.z);
			//   }
			//   *(_QWORD *)&centerPoint.x = v28;
			//   v36 = _mm_cvtsi32_si128(z_low);
			//   v37 = _mm_unpacklo_ps((__m128)(unsigned int)v28, (__m128)HIDWORD(v28)).m128_u64[0];
			//   *(_QWORD *)&v6.fields.m_lightDir.x = v37;
			//   v38 = _mm_cvtsi128_si32(v36);
			//   LODWORD(v6.fields.m_lightDir.z) = v38;
			//   if ( fabs(*((float *)&v28 + 1)) < 0.0099999998 )
			//   {
			//     m_asmTileManager = v6.fields.m_asmTileManager;
			//     if ( !m_asmTileManager )
			//       sub_180B536AC(v21, v20);
			// LABEL_60:
			//     HG::Rendering::Runtime::ASMTileManager::InvalidateAllTiles(m_asmTileManager, 0LL);
			//     return;
			//   }
			//   v6.fields.m_lightRotation = (Quaternion)v23;
			//   *(_OWORD *)&v6.fields.m_lightToWorld.m00 = v24;
			//   *(_OWORD *)&v6.fields.m_lightToWorld.m01 = v25;
			//   *(_OWORD *)&v6.fields.m_lightToWorld.m02 = v26;
			//   *(_OWORD *)&v6.fields.m_lightToWorld.m03 = v27;
			//   *(_QWORD *)&centerPoint.x = *(_QWORD *)&v6.fields.m_lastLightDir.x;
			//   if ( (float)((float)((float)(*(float *)v36.m128i_i32 - v6.fields.m_lastLightDir.z)
			//                      * (float)(*(float *)v36.m128i_i32 - v6.fields.m_lastLightDir.z))
			//              + (float)((float)((float)(*(float *)&v28 - centerPoint.x) * (float)(*(float *)&v28 - centerPoint.x))
			//                      + (float)((float)(*((float *)&v28 + 1) - centerPoint.y)
			//                              * (float)(*((float *)&v28 + 1) - centerPoint.y)))) >= 9.9999994e-11 )
			//   {
			//     if ( !v6.fields.m_asmTileManager )
			//       sub_180B536AC(v21, v20);
			//     HG::Rendering::Runtime::ASMTileManager::InvalidateAllTiles(v6.fields.m_asmTileManager, 0LL);
			//     m_vtAllocator = v6.fields.m_vtAllocator;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     static_fields = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields;
			//     if ( !m_vtAllocator )
			//       sub_180B536AC(v40, static_fields);
			//     HG::Rendering::Runtime::HGASMVirtualTextureAllocator::Initialize(
			//       m_vtAllocator,
			//       static_fields.s_asmTileResolution,
			//       0LL);
			//     *(_QWORD *)&v6.fields.m_lastLightDir.x = v37;
			//     LODWORD(v6.fields.m_lastLightDir.z) = v38;
			//     if ( v6.fields.m_asmUpdateMode <= 1u )
			//       v6.fields.m_asmUpdateMode = 2;
			//     if ( v6.fields.m_friendASMManager )
			//     {
			//       m_friendASMManager = v6.fields.m_friendASMManager;
			//       if ( !m_friendASMManager.fields.m_asmTileManager )
			//         sub_180B536AC(v21, v20);
			//       HG::Rendering::Runtime::ASMTileManager::InvalidateAllTiles(m_friendASMManager.fields.m_asmTileManager, 0LL);
			//       v45 = v6.fields.m_friendASMManager;
			//       if ( !v45 )
			//         sub_180B536AC(v44, v43);
			//       v46 = v45.fields.m_vtAllocator;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//       v48 = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields;
			//       if ( !v46 )
			//         sub_180B536AC(v47, v48);
			//       HG::Rendering::Runtime::HGASMVirtualTextureAllocator::Initialize(v46, v48.s_asmTileResolution, 0LL);
			//       v49 = v6.fields.m_friendASMManager;
			//       if ( !v49 )
			//         sub_180B536AC(v21, v20);
			//       *(_QWORD *)&v49.fields.m_lastLightDir.x = v37;
			//       LODWORD(v49.fields.m_lastLightDir.z) = v38;
			//       v50 = v6.fields.m_friendASMManager;
			//       if ( !v50 )
			//         sub_180B536AC(v21, v20);
			//       v50.fields.m_asmUpdateMode = v6.fields.m_asmUpdateMode;
			//       v51 = v6.fields.m_friendASMManager;
			//       y = v6.fields.m_lastPositionXZ.y;
			//       if ( !v51 )
			//         sub_180B536AC(v21, v20);
			//       v51.fields.m_lastPositionXZ.x = v6.fields.m_lastPositionXZ.x;
			//       v51.fields.m_lastPositionXZ.y = y;
			//     }
			//   }
			//   if ( !camera )
			//     sub_180B536AC(v21, v20);
			//   v53 = UnityEngine::Component::get_transform(camera, 0LL);
			//   if ( !v53 )
			//     sub_180B536AC(v55, v54);
			//   position = UnityEngine::Transform::get_position((Vector3 *)&ex, v53, 0LL);
			//   v57 = *(_QWORD *)&position.x;
			//   z = position.z;
			//   if ( !v6.fields.m_asmUpdateMode || fabs(v6.fields.m_lightDir.y) < 0.0099999998 )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     v59 = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields;
			//     x_low = (__m128)LODWORD(v59.s_lastUpdatedPosition.x);
			//     y_low = (__m128)LODWORD(v59.s_lastUpdatedPosition.y);
			//     *(_QWORD *)&centerPoint.x = v57;
			//     centerPoint.z = z;
			//     v62 = HG::Rendering::Runtime::VectorSwizzleUtils::xz(&centerPoint, 0LL);
			//     *(_QWORD *)&maxRenderCount.x = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_18473B264)(
			//                                      _mm_unpacklo_ps(x_low, y_low).m128_u64[0],
			//                                      v62);
			//     v63 = sub_182413570(&maxRenderCount);
			//     if ( *(float *)&v63 <= TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmUpdateAtlasDistance )
			//       return;
			//     v6.fields.m_asmUpdateMode = 1;
			//   }
			//   *(_QWORD *)&centerPoint.x = v57;
			//   centerPoint.z = z;
			//   HG::Rendering::Runtime::HGASMManager::UpdateFrustumVerts(v6, (Camera *)camera, &centerPoint, 0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//   m_asmUpdateMode = v6.fields.m_asmUpdateMode;
			//   if ( m_asmUpdateMode != 1 )
			//   {
			//     s_asmMaxTileRenderCountPerFrame = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmMaxTileRenderCountPerFrame;
			//     if ( m_asmUpdateMode == 3 )
			//       s_asmMaxTileRenderCountPerFrame = 128;
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//   if ( TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_forceUpdateAllTilesMode )
			//     s_asmMaxTileRenderCountPerFrame = 128;
			//   LODWORD(maxRenderCount.x) = s_asmMaxTileRenderCountPerFrame;
			//   v92[0] = Unity::Profiling::ProfilerMarker::Auto(&v6.fields.m_samplerASMCreateTiles, v65).m_Ptr;
			//   ex = 0LL;
			//   v91 = v92;
			//   try
			//   {
			//     v67 = v6.fields.m_asmTileManager;
			//     m_frustumVerts = v6.fields.m_frustumVerts;
			//     if ( !m_frustumVerts )
			//       sub_1802DC2C8(0LL, v66.m_Ptr);
			//     sub_18004E290(m_frustumVerts, &centerPoint, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     if ( !v67 )
			//       sub_1802DC2C8(v69, TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     HG::Rendering::Runtime::ASMTileManager::CreateTilesThisFrame(
			//       v67,
			//       *(Vector2 *)&centerPoint.x,
			//       TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmCacheRadius,
			//       TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmGridSize,
			//       0LL);
			//   }
			//   catch ( Il2CppExceptionWrapper *v95 )
			//   {
			//     ex = v95.ex;
			//     sub_1801F7AA0(&ex);
			//     v6 = this;
			//     goto LABEL_45;
			//   }
			//   sub_1801F7AA0(&ex);
			// LABEL_45:
			//   v92[0] = Unity::Profiling::ProfilerMarker::Auto(&v6.fields.m_samplerASMUpdateCachedTiles, v70).m_Ptr;
			//   ex = 0LL;
			//   v91 = v92;
			//   try
			//   {
			//     v72 = v6.fields.m_asmTileManager;
			//     v73 = v6.fields.m_frustumVerts;
			//     if ( !v73 )
			//       sub_1802DC2C8(0LL, v71.m_Ptr);
			//     sub_18004E290(v73, &centerPoint, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     v75 = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields;
			//     if ( !v72 )
			//       sub_1802DC2C8(v74, v75);
			//     HG::Rendering::Runtime::ASMTileManager::UpdateCachedTiles(
			//       v72,
			//       *(Vector2 *)&centerPoint.x,
			//       v75.s_asmCacheRadius,
			//       0LL);
			//   }
			//   catch ( Il2CppExceptionWrapper *v96 )
			//   {
			//     ex = v96.ex;
			//     sub_1801F7AA0(&ex);
			//     v6 = this;
			//     goto LABEL_50;
			//   }
			//   sub_1801F7AA0(&ex);
			// LABEL_50:
			//   v92[0] = Unity::Profiling::ProfilerMarker::Auto(&v6.fields.m_samplerASMPreRenderTiles, v76).m_Ptr;
			//   ex = 0LL;
			//   v91 = v92;
			//   try
			//   {
			//     v78 = v6.fields.m_asmTileManager;
			//     v79 = v6.fields.m_vtAllocator;
			//     v80 = v6.fields.m_frustumVerts;
			//     if ( !v80 )
			//       sub_1802DC2C8(0LL, v77.m_Ptr);
			//     sub_18004E290(v80, &centerPoint, 0LL);
			//     if ( !v78 )
			//       sub_1802DC2C8(v82, v81);
			//     HG::Rendering::Runtime::ASMTileManager::PreRenderTiles(
			//       v78,
			//       v79,
			//       *(Vector2 *)&centerPoint.x,
			//       SLODWORD(maxRenderCount.x),
			//       v6.fields.m_startVTIdx,
			//       0LL);
			//   }
			//   catch ( Il2CppExceptionWrapper *v97 )
			//   {
			//     ex = v97.ex;
			//     sub_1801F7AA0(&ex);
			//     v6 = this;
			//     goto LABEL_55;
			//   }
			//   sub_1801F7AA0(&ex);
			// LABEL_55:
			//   v84 = v6.fields.m_vtAllocator;
			//   if ( !v84 )
			//     sub_1802DC2C8(0LL, v83);
			//   HG::Rendering::Runtime::HGASMVirtualTextureAllocator::VisitTilesThisFrame(
			//     v84,
			//     v6.fields.m_asmTileManager,
			//     v6.fields.m_startVTIdx,
			//     0LL);
			// }
			// 
		}

		internal void Render(HGRenderGraph renderGraph, ScriptableRenderContext renderContext, HGCamera hgCamera)
		{
			// // Void Render(HGRenderGraph, ScriptableRenderContext, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGASMManager::Render(
			//         HGASMManager *this,
			//         HGRenderGraph *renderGraph,
			//         ScriptableRenderContext renderContext,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   HGCamera *v5; // rsi
			//   HGASMManager *v7; // r15
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   int32_t TilesForRender; // eax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   int32_t v13; // r12d
			//   ASMTile *Tile; // rax
			//   __m128 v15; // xmm8
			//   __int128 v16; // xmm0
			//   int vtIndex; // ecx
			//   __m128 v18; // xmm7
			//   __m128 v19; // xmm6
			//   __int64 v20; // rax
			//   __int64 v21; // rax
			//   __m128 v22; // xmm5
			//   Vector2 v23; // xmm15_8
			//   __int64 v24; // xmm4_8
			//   Vector2 v25; // rax
			//   Vector2 v26; // r8
			//   Vector2 v27; // r9
			//   Vector2 v28; // xmm14_8
			//   __int64 v29; // xmm13_8
			//   float z; // ebx
			//   __m128i v31; // xmm11
			//   __int128 v32; // xmm6
			//   __int128 v33; // xmm7
			//   __int128 v34; // xmm8
			//   __int128 v35; // xmm9
			//   float m_asmCasterMinY; // xmm12_4
			//   float m_asmCasterMaxY; // xmm10_4
			//   __int128 v38; // xmm6
			//   __int128 v39; // xmm7
			//   __int128 v40; // xmm8
			//   __int128 v41; // xmm9
			//   __int64 v42; // rdx
			//   __int64 v43; // rcx
			//   __int64 v44; // rbx
			//   HGASMVirtualTextureAllocator_ASMVTData *VTData; // rax
			//   __int128 v46; // xmm14
			//   __int128 v47; // xmm15
			//   Matrix4x4 *ShadowTransform; // rax
			//   __int64 v49; // rdx
			//   __int64 v50; // rcx
			//   __int128 v51; // xmm11
			//   __int128 v52; // xmm12
			//   __int128 v53; // xmm13
			//   RendererList nullRendererList; // xmm13
			//   __int128 v55; // xmm10
			//   __int128 v56; // xmm11
			//   Matrix4x4 *v57; // rax
			//   __int128 v58; // xmm7
			//   __int128 v59; // xmm8
			//   __int128 v60; // xmm9
			//   __int128 v61; // xmm12
			//   HGASMManager__StaticFields *static_fields; // rdx
			//   __int64 v63; // rdx
			//   __int64 v64; // rcx
			//   int32_t v65; // ebx
			//   __int64 v66; // r13
			//   __int64 v67; // rdx
			//   HGASMManager__StaticFields *v68; // rcx
			//   CullingResults v69; // xmm6
			//   __int64 v70; // rbx
			//   Void *m_Buffer; // r13
			//   __int64 v72; // r15
			//   __int64 v73; // rdx
			//   HGASMManager__StaticFields *v74; // rcx
			//   __int64 v75; // rdx
			//   __int64 v76; // rcx
			//   Camera *camera; // rbx
			//   uint64_t SceneCullingMaskFromCamera; // rbx
			//   HGASMManager__StaticFields *v79; // rcx
			//   uint32_t s_asmManagerCullingMask; // r9d
			//   float s_asmScreenSizeMinSquared; // xmm1_4
			//   ProfilingSampler *v82; // rax
			//   __int64 v83; // rdx
			//   __int64 v84; // rcx
			//   TextureHandle *v85; // rbx
			//   __int64 v86; // rdx
			//   __int64 v87; // rcx
			//   TextureHandle v88; // xmm0
			//   __int64 v89; // rdx
			//   __int64 v90; // rcx
			//   unsigned int v91; // edx
			//   unsigned __int64 v92; // r8
			//   signed __int64 v93; // rtt
			//   _OWORD *v94; // rax
			//   _OWORD *v95; // rax
			//   _OWORD *v96; // rax
			//   __int64 v97; // rdx
			//   unsigned int v98; // edx
			//   unsigned __int64 v99; // r8
			//   char v100; // dl
			//   signed __int64 v101; // rtt
			//   __int64 v102; // rbx
			//   unsigned __int64 v103; // rdx
			//   signed __int64 v104; // rcx
			//   unsigned __int64 v105; // r8
			//   signed __int64 v106; // rtt
			//   __int64 v107; // rcx
			//   __int64 v108; // rcx
			//   Transform *transform; // rax
			//   __int64 v110; // rdx
			//   __int64 v111; // rcx
			//   Vector2 v112; // xmm6_8
			//   __int64 v113; // rdx
			//   double v114; // xmm0_8
			//   HGASMManager__StaticFields *v115; // rcx
			//   Transform *v116; // rax
			//   __int64 v117; // rdx
			//   __int64 v118; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v120; // rdx
			//   __int64 v121; // rcx
			//   HGRenderKeyword__Enum globalKeywords; // [rsp+20h] [rbp-BF8h]
			//   __int64 v123; // [rsp+60h] [rbp-BB8h] BYREF
			//   unsigned int RendererList; // [rsp+68h] [rbp-BB0h]
			//   Matrix4x4__Array *m_worldToShadowMatrices; // [rsp+70h] [rbp-BA8h]
			//   __int64 v126; // [rsp+78h] [rbp-BA0h] BYREF
			//   ShaderTagId v127; // [rsp+80h] [rbp-B98h] BYREF
			//   int32_t v128; // [rsp+84h] [rbp-B94h]
			//   Vector3 v129; // [rsp+90h] [rbp-B88h] BYREF
			//   Matrix4x4 v130; // [rsp+A0h] [rbp-B78h] BYREF
			//   Matrix4x4 v131; // [rsp+E0h] [rbp-B38h] BYREF
			//   _QWORD v132[2]; // [rsp+120h] [rbp-AF8h] BYREF
			//   NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ v133; // [rsp+130h] [rbp-AE8h] BYREF
			//   HGRenderGraphBuilder v134; // [rsp+140h] [rbp-AD8h] BYREF
			//   NativeArray_1_System_Int32_ tilesForRenderThisFrame; // [rsp+160h] [rbp-AB8h] BYREF
			//   LODCrossFadeConfig lodCrossFadeConfig; // [rsp+170h] [rbp-AA8h] BYREF
			//   Matrix4x4 v137; // [rsp+1B0h] [rbp-A68h] BYREF
			//   Matrix4x4 v138; // [rsp+1F0h] [rbp-A28h] BYREF
			//   _BYTE v139[20]; // [rsp+240h] [rbp-9D8h]
			//   Il2CppExceptionWrapper *v140; // [rsp+258h] [rbp-9C0h] BYREF
			//   __int128 v141; // [rsp+260h] [rbp-9B8h] BYREF
			//   __int128 v142; // [rsp+270h] [rbp-9A8h] BYREF
			//   Matrix4x4 v143; // [rsp+280h] [rbp-998h]
			//   CullingResults v144; // [rsp+2C0h] [rbp-958h] BYREF
			//   RendererList v145; // [rsp+2D0h] [rbp-948h] BYREF
			//   TextureHandle v146; // [rsp+2E0h] [rbp-938h] BYREF
			//   TextureHandle v147; // [rsp+2F0h] [rbp-928h] BYREF
			//   Matrix4x4 v148; // [rsp+300h] [rbp-918h] BYREF
			//   RendererListDesc v149; // [rsp+340h] [rbp-8D8h] BYREF
			//   RendererListDesc v150; // [rsp+420h] [rbp-7F8h] BYREF
			//   ScriptableCullingParameters cullingParameters; // [rsp+500h] [rbp-718h] BYREF
			//   ScriptableRenderContext P2; // [rsp+C30h] [rbp+18h] BYREF
			//   HGCamera *v155; // [rsp+C38h] [rbp+20h]
			// 
			//   v155 = hgCamera;
			//   P2.m_Ptr = renderContext.m_Ptr;
			//   v5 = hgCamera;
			//   v7 = this;
			//   if ( !byte_18D919E61 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGASMManager::ASMShadowPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGASMManager::ASMShadowPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Plane>::NativeArray);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&off_18D5EFF60);
			//     byte_18D919E61 = 1;
			//   }
			//   tilesForRenderThisFrame = 0LL;
			//   v133 = 0LL;
			//   memset(&lodCrossFadeConfig, 0, sizeof(lodCrossFadeConfig));
			//   sub_1802F01E0(&cullingParameters, 0LL, 1592LL);
			//   v127.m_Id = 0;
			//   sub_1802F01E0(&v149, 0LL, 224LL);
			//   memset(&v134, 0, sizeof(v134));
			//   v123 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1757, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1757, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v121, v120);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_217(Patch, (Object *)v7, (Object *)renderGraph, P2, (Object *)v5, 0LL);
			//   }
			//   else
			//   {
			//     v7.fields.shouldSwapManagers = 0;
			//     if ( v7.fields.m_asmUpdateMode )
			//     {
			//       if ( !v7.fields.m_asmTileManager )
			//         sub_180B536AC(v9, v8);
			//       TilesForRender = HG::Rendering::Runtime::ASMTileManager::GetTilesForRender(
			//                          v7.fields.m_asmTileManager,
			//                          &tilesForRenderThisFrame,
			//                          0LL);
			//       LODWORD(v126) = TilesForRender;
			//       if ( TilesForRender )
			//       {
			//         v13 = 0;
			//         v128 = 0;
			//         while ( v13 < TilesForRender )
			//         {
			//           if ( !v7.fields.m_asmTileManager )
			//             sub_180B536AC(v13, v11);
			//           Tile = HG::Rendering::Runtime::ASMTileManager::GetTile(
			//                    (ASMTile *)&v130,
			//                    v7.fields.m_asmTileManager,
			//                    *(_DWORD *)&tilesForRenderThisFrame.m_Buffer[4 * v13],
			//                    0LL);
			//           v15 = *(__m128 *)&Tile.mins.x;
			//           v16 = *(_OWORD *)&Tile.tileCoords.m_X;
			//           *(_OWORD *)&v131.m01 = v16;
			//           vtIndex = Tile.vtIndex;
			//           RendererList = vtIndex;
			//           *(__m128 *)&v131.m00 = v15;
			//           *(_OWORD *)&v131.m01 = v16;
			//           if ( vtIndex >= 0 )
			//           {
			//             *(__m128 *)&v131.m00 = v15;
			//             *(_OWORD *)&v131.m01 = v16;
			//             if ( vtIndex < 256 )
			//             {
			//               v137 = *(Matrix4x4 *)sub_182805160(&v130);
			//               v138 = *(Matrix4x4 *)sub_182805160(&v130);
			//               sub_182805160(&v130);
			//               v18 = _mm_shuffle_ps(v15, v15, 170);
			//               v19 = _mm_shuffle_ps(v15, v15, 255);
			//               v20 = sub_18473B264(
			//                       _mm_unpacklo_ps(v18, v19).m128_u64[0],
			//                       _mm_unpacklo_ps(v15, _mm_shuffle_ps(v15, v15, 85)).m128_u64[0]);
			//               v21 = sub_182C9F010(v20);
			//               v23 = (Vector2)sub_18473B264(_mm_unpacklo_ps(v15, v22).m128_u64[0], v21);
			//               v25 = (Vector2)sub_182C9F010(v24);
			//               v28 = sub_1842BE4B8((Vector2)*(_OWORD *)&_mm_unpacklo_ps(v18, v19), v25, v26, v27);
			//               v29 = *(_QWORD *)&v7.fields.m_lightDir.x;
			//               z = v7.fields.m_lightDir.z;
			//               v31 = _mm_loadu_si128((const __m128i *)&v7.fields.m_lightRotation);
			//               v32 = *(_OWORD *)&v7.fields.m_lightToWorld.m00;
			//               v33 = *(_OWORD *)&v7.fields.m_lightToWorld.m01;
			//               v34 = *(_OWORD *)&v7.fields.m_lightToWorld.m02;
			//               v35 = *(_OWORD *)&v7.fields.m_lightToWorld.m03;
			//               m_asmCasterMinY = v7.fields.m_asmCasterMinY;
			//               m_asmCasterMaxY = v7.fields.m_asmCasterMaxY;
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//               *(_OWORD *)&v130.m00 = v32;
			//               *(_OWORD *)&v130.m01 = v33;
			//               *(_OWORD *)&v130.m02 = v34;
			//               *(_OWORD *)&v130.m03 = v35;
			//               *(__m128i *)&v131.m00 = v31;
			//               *(_QWORD *)&v129.x = v29;
			//               v129.z = z;
			//               HG::Rendering::Runtime::HGASMManager::GetASMShadowMatrixes(
			//                 v23,
			//                 v28,
			//                 &v129,
			//                 (Quaternion *)&v131,
			//                 &v130,
			//                 0.1,
			//                 1000.0,
			//                 m_asmCasterMinY,
			//                 m_asmCasterMaxY,
			//                 &v137,
			//                 &v138,
			//                 0LL);
			//               v38 = *(_OWORD *)&v138.m00;
			//               v130 = v138;
			//               v39 = *(_OWORD *)&v138.m01;
			//               v40 = *(_OWORD *)&v138.m02;
			//               v41 = *(_OWORD *)&v138.m03;
			//               v143 = *UnityEngine::GL::GetGPUProjectionMatrix(&v131, &v130, 1, 0LL);
			//               if ( !v7.fields.m_vtAllocator )
			//                 sub_180B536AC(v43, v42);
			//               v44 = (int)RendererList;
			//               VTData = HG::Rendering::Runtime::HGASMVirtualTextureAllocator::GetVTData(
			//                          (HGASMVirtualTextureAllocator_ASMVTData *)&v130,
			//                          v7.fields.m_vtAllocator,
			//                          RendererList,
			//                          0LL);
			//               *(_OWORD *)v139 = *(_OWORD *)&VTData.uvMaxs.y;
			//               *(_DWORD *)&v139[16] = VTData.pixelMaxs.m_Y;
			//               m_worldToShadowMatrices = v7.fields.m_worldToShadowMatrices;
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
			//               v46 = *(_OWORD *)&v137.m00;
			//               v130 = v137;
			//               v47 = *(_OWORD *)&v137.m01;
			//               *(_OWORD *)&v131.m00 = v38;
			//               *(_OWORD *)&v131.m01 = v39;
			//               *(_OWORD *)&v131.m02 = v40;
			//               *(_OWORD *)&v131.m03 = v41;
			//               ShadowTransform = HG::Rendering::Runtime::HGShadowUtils::GetShadowTransform(&v148, &v131, &v130, 0LL);
			//               v51 = *(_OWORD *)&ShadowTransform.m01;
			//               v52 = *(_OWORD *)&ShadowTransform.m02;
			//               v53 = *(_OWORD *)&ShadowTransform.m03;
			//               if ( !m_worldToShadowMatrices )
			//                 sub_180B536AC(v50, v49);
			//               *(_OWORD *)&v130.m00 = *(_OWORD *)&ShadowTransform.m00;
			//               *(_OWORD *)&v130.m01 = v51;
			//               *(_OWORD *)&v130.m02 = v52;
			//               *(_OWORD *)&v130.m03 = v53;
			//               sub_180077420(m_worldToShadowMatrices, v44, &v130);
			//               sub_180002C70(TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList);
			//               nullRendererList = TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList.static_fields.nullRendererList;
			//               *(_OWORD *)&v130.m00 = v46;
			//               *(_OWORD *)&v130.m01 = v47;
			//               v55 = *(_OWORD *)&v137.m02;
			//               *(_OWORD *)&v130.m02 = *(_OWORD *)&v137.m02;
			//               v56 = *(_OWORD *)&v137.m03;
			//               *(_OWORD *)&v130.m03 = *(_OWORD *)&v137.m03;
			//               *(_OWORD *)&v131.m00 = v38;
			//               *(_OWORD *)&v131.m01 = v39;
			//               *(_OWORD *)&v131.m02 = v40;
			//               *(_OWORD *)&v131.m03 = v41;
			//               v57 = UnityEngine::Matrix4x4::op_Multiply(&v148, &v131, &v130, 0LL);
			//               v58 = *(_OWORD *)&v57.m00;
			//               v59 = *(_OWORD *)&v57.m01;
			//               v60 = *(_OWORD *)&v57.m02;
			//               v61 = *(_OWORD *)&v57.m03;
			//               static_fields = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields;
			//               *(_OWORD *)&v130.m00 = *(_OWORD *)&v57.m00;
			//               *(_OWORD *)&v130.m01 = v59;
			//               *(_OWORD *)&v130.m02 = v60;
			//               *(_OWORD *)&v130.m03 = v61;
			//               UnityEngine::GeometryUtility::CalculateFrustumPlanes(&v130, static_fields.s_tempPlanes, 0LL);
			//               if ( !UnityEngine::HyperGryph::HGGraphicsUtils::get_enableECSRenderer(0LL) )
			//               {
			//                 if ( !v5 )
			//                   sub_180B536AC(v64, v63);
			//                 if ( !v5.fields.camera )
			//                   sub_180B536AC(v64, v63);
			//                 UnityEngine::Camera::TryGetCullingParameters(v5.fields.camera, &cullingParameters, 0LL);
			//                 sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
			//                 *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m20 = v58;
			//                 *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m21 = v59;
			//                 *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m22 = v60;
			//                 *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m23 = v61;
			//                 UnityEngine::Rendering::ScriptableCullingParameters::set_isOrthographic(&cullingParameters, 1, 0LL);
			//                 cullingParameters.m_CameraProperties.cameraWorldToClip.m31 = 0.0;
			//                 v65 = 0;
			//                 v66 = 0LL;
			//                 do
			//                 {
			//                   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//                   v68 = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields;
			//                   if ( !v68.s_tempPlanes )
			//                     sub_180B536AC(v68, v67);
			//                   sub_180037190(v68.s_tempPlanes, &v141, v66);
			//                   sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
			//                   *(_OWORD *)&v131.m00 = v141;
			//                   UnityEngine::Rendering::ScriptableCullingParameters::SetCullingPlane(
			//                     &cullingParameters,
			//                     v65++,
			//                     (Plane *)&v131,
			//                     0LL);
			//                   ++v66;
			//                 }
			//                 while ( v65 < 6 );
			//                 sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//                 v69 = *UnityEngine::Rendering::ScriptableRenderContext::Cull(&v144, &P2, &cullingParameters, 0LL);
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//                 UnityEngine::Rendering::ShaderTagId::ShaderTagId(
			//                   &v127,
			//                   TypeInfo::HG::Rendering::Runtime::HGShaderPassNames.static_fields.s_ShadowCasterStr,
			//                   0LL);
			//                 *(CullingResults *)&v131.m00 = v69;
			//                 UnityEngine::Rendering::RendererUtils::RendererListDesc::RendererListDesc(
			//                   &v149,
			//                   v127,
			//                   (CullingResults *)&v131,
			//                   v5.fields.camera,
			//                   0LL);
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//                 v149.renderQueueRange = TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_AllOpaque;
			//                 v149.sortingCriteria = 59;
			//                 v149.rendererConfiguration = 6144;
			//                 v150 = v149;
			//                 nullRendererList = *UnityEngine::Rendering::ScriptableRenderContext::CreateRendererList(
			//                                       &v145,
			//                                       &P2,
			//                                       &v150,
			//                                       0LL);
			//               }
			//               Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::EntityCommandBufferV2::VirtualEntityMap>::NativeArray(
			//                 &v133,
			//                 6,
			//                 Allocator__Enum_Temp,
			//                 NativeArrayOptions__Enum_ClearMemory,
			//                 MethodInfo::Unity::Collections::NativeArray<UnityEngine::Plane>::NativeArray);
			//               v70 = 0LL;
			//               m_Buffer = v133.m_Buffer;
			//               v72 = 6LL;
			//               do
			//               {
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//                 v74 = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields;
			//                 if ( !v74.s_tempPlanes )
			//                   sub_180B536AC(v74, v73);
			//                 sub_180037190(v74.s_tempPlanes, &v142, v70);
			//                 *(_OWORD *)m_Buffer = v142;
			//                 ++v70;
			//                 m_Buffer += 16;
			//                 --v72;
			//               }
			//               while ( v72 );
			//               v7 = this;
			//               if ( !v5 )
			//                 sub_180B536AC(v76, v75);
			//               lodCrossFadeConfig = v5.fields.lodCrossFadeConfig;
			//               lodCrossFadeConfig.enableDither = 0;
			//               camera = v5.fields.camera;
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//               SceneCullingMaskFromCamera = HG::Rendering::Runtime::HGUtils::GetSceneCullingMaskFromCamera(camera, 0LL);
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//               v79 = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields;
			//               s_asmManagerCullingMask = v79.s_asmManagerCullingMask;
			//               s_asmScreenSizeMinSquared = v79.s_asmScreenSizeMinSquared;
			//               *(NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ *)&v131.m00 = v133;
			//               LODWORD(SceneCullingMaskFromCamera) = UnityEngine::HyperGryph::HGCullingSystem::AddCullViewByPlanes(
			//                                                       (NativeArray_1_UnityEngine_Plane_ *)&v131,
			//                                                       0,
			//                                                       SceneCullingMaskFromCamera,
			//                                                       s_asmManagerCullingMask,
			//                                                       0x4000002u,
			//                                                       0x4000002u,
			//                                                       &lodCrossFadeConfig,
			//                                                       s_asmScreenSizeMinSquared,
			//                                                       CameraType__Enum_Shadow,
			//                                                       0LL);
			//               UnityEngine::HyperGryph::HGCullingSystem::DispatchBatchCullingJobs(0LL);
			//               sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//               LOWORD(globalKeywords) = 0;
			//               RendererList = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//                                SceneCullingMaskFromCamera,
			//                                HGRenderFlags__Enum_StaticShadowCaster|HGRenderFlags__Enum_CastShadow|HGRenderFlags__Enum_Opaque,
			//                                HGRenderFlags__Enum_StaticShadowCaster|HGRenderFlags__Enum_CastShadow|HGRenderFlags__Enum_Opaque,
			//                                HGShaderLightMode__Enum_ShadowCaster,
			//                                globalKeywords,
			//                                P2.m_Ptr,
			//                                0,
			//                                0,
			//                                0xFFFFFFFF,
			//                                0,
			//                                0,
			//                                0LL);
			//               LODWORD(m_worldToShadowMatrices) = UnityEngine::HyperGryph::HGGrassRender::CreateRendererList(
			//                                                    SceneCullingMaskFromCamera,
			//                                                    HGRenderFlags__Enum_StaticShadowCaster|HGRenderFlags__Enum_CastShadow|HGRenderFlags__Enum_Opaque,
			//                                                    HGRenderFlags__Enum_StaticShadowCaster|HGRenderFlags__Enum_CastShadow|HGRenderFlags__Enum_Opaque,
			//                                                    HGShaderLightMode__Enum_ShadowCaster,
			//                                                    P2.m_Ptr,
			//                                                    0,
			//                                                    0LL);
			//               v82 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                       (Int32Enum__Enum)0x7Fu,
			//                       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//               if ( !renderGraph )
			//                 sub_180B536AC(v84, v83);
			//               v134 = *(HGRenderGraphBuilder *)sub_1808369E4(
			//                                                 (unsigned int)&v131,
			//                                                 (_DWORD)renderGraph,
			//                                                 (unsigned int)"Render ASM Shadow Map",
			//                                                 (unsigned int)&v123,
			//                                                 (__int64)v82,
			//                                                 1,
			//                                                 3);
			//               v132[0] = 0LL;
			//               v132[1] = &v134;
			//               try
			//               {
			//                 v85 = (TextureHandle *)v123;
			//                 v88 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                          &v146,
			//                          renderGraph,
			//                          this.fields.m_asmShadowMapRT,
			//                          0LL);
			//                 if ( !v85 )
			//                   sub_1802DC2C8(v87, v86);
			//                 v85[2] = v88;
			//                 v89 = v123;
			//                 if ( !v123 )
			//                   sub_1802DC2C8(v87, 0LL);
			//                 *(_QWORD *)(v123 + 24) = renderGraph.fields.m_DefaultResources;
			//                 v90 = (unsigned int)dword_18D8E43F8;
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   v91 = ((unsigned __int64)(v89 + 24) >> 12) & 0x1FFFFF;
			//                   v92 = (unsigned __int64)v91 >> 6;
			//                   v89 = v91 & 0x3F;
			//                   _m_prefetchw(&qword_18D6405E0[v92 + 36190]);
			//                   do
			//                     v93 = qword_18D6405E0[v92 + 36190];
			//                   while ( v93 != _InterlockedCompareExchange64(&qword_18D6405E0[v92 + 36190], v93 | (1LL << v89), v93) );
			//                   v90 = (unsigned int)dword_18D8E43F8;
			//                 }
			//                 v94 = (_OWORD *)v123;
			//                 if ( !v123 )
			//                   sub_1802DC2C8(v90, v89);
			//                 *(_OWORD *)(v123 + 48) = *(_OWORD *)&v143.m00;
			//                 v94[4] = *(_OWORD *)&v143.m01;
			//                 v94[5] = *(_OWORD *)&v143.m02;
			//                 v94[6] = *(_OWORD *)&v143.m03;
			//                 v95 = (_OWORD *)v123;
			//                 if ( !v123 )
			//                   sub_1802DC2C8(v90, v89);
			//                 *(_OWORD *)(v123 + 112) = v46;
			//                 v95[8] = v47;
			//                 v95[9] = v55;
			//                 v95[10] = v56;
			//                 v96 = (_OWORD *)v123;
			//                 if ( !v123 )
			//                   sub_1802DC2C8(v90, v89);
			//                 *(_OWORD *)(v123 + 176) = v58;
			//                 v96[12] = v59;
			//                 v96[13] = v60;
			//                 v96[14] = v61;
			//                 if ( !v123 )
			//                   sub_1802DC2C8(v90, 0LL);
			//                 *(_QWORD *)(v123 + 240) = *(_QWORD *)&v139[4];
			//                 if ( !v123 )
			//                   sub_1802DC2C8(v90, 0LL);
			//                 *(_QWORD *)(v123 + 248) = *(_QWORD *)&v139[12];
			//                 v97 = v123;
			//                 if ( !v123 )
			//                   sub_1802DC2C8(v90, 0LL);
			//                 *(_QWORD *)(v123 + 16) = v5;
			//                 if ( (_DWORD)v90 )
			//                 {
			//                   v98 = ((unsigned __int64)(v97 + 16) >> 12) & 0x1FFFFF;
			//                   v99 = (unsigned __int64)v98 >> 6;
			//                   v100 = v98 & 0x3F;
			//                   _m_prefetchw(&qword_18D6405E0[v99 + 36190]);
			//                   do
			//                     v101 = qword_18D6405E0[v99 + 36190];
			//                   while ( v101 != _InterlockedCompareExchange64(
			//                                     &qword_18D6405E0[v99 + 36190],
			//                                     v101 | (1LL << v100),
			//                                     v101) );
			//                 }
			//                 v102 = v123;
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//                 v104 = (signed __int64)TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields;
			//                 if ( !v102 )
			//                   sub_1802DC2C8(v104, v103);
			//                 *(_QWORD *)(v102 + 256) = *(_QWORD *)(v104 + 56);
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   v105 = (((unsigned __int64)(v102 + 256) >> 12) & 0x1FFFFF) >> 6;
			//                   v103 = ((unsigned __int64)(v102 + 256) >> 12) & 0x3F;
			//                   _m_prefetchw(&qword_18D6405E0[v105 + 36190]);
			//                   do
			//                   {
			//                     v104 = qword_18D6405E0[v105 + 36190] | (1LL << v103);
			//                     v106 = qword_18D6405E0[v105 + 36190];
			//                   }
			//                   while ( v106 != _InterlockedCompareExchange64(&qword_18D6405E0[v105 + 36190], v104, v106) );
			//                 }
			//                 if ( !v123 )
			//                   sub_1802DC2C8(v104, v103);
			//                 *(RendererList *)(v123 + 264) = nullRendererList;
			//                 if ( !v123 )
			//                   sub_1802DC2C8(v104, v103);
			//                 v107 = RendererList;
			//                 *(_DWORD *)(v123 + 280) = RendererList;
			//                 if ( !v123 )
			//                   sub_1802DC2C8(v107, v103);
			//                 v108 = (unsigned int)m_worldToShadowMatrices;
			//                 *(_DWORD *)(v123 + 284) = (_DWORD)m_worldToShadowMatrices;
			//                 if ( !v123 )
			//                   sub_1802DC2C8(v108, v103);
			//                 HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//                   &v147,
			//                   &v134,
			//                   (TextureHandle *)(v123 + 32),
			//                   DepthAccess__Enum_Write,
			//                   RenderBufferLoadAction__Enum_Load,
			//                   RenderBufferStoreAction__Enum_Store,
			//                   0.0,
			//                   0,
			//                   0,
			//                   0LL);
			//                 HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v134, 0, 0LL);
			//                 HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//                   &v134,
			//                   (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_renderASMShadowPass,
			//                   0LL,
			//                   0,
			//                   MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGASMManager::ASMShadowPassData>);
			//               }
			//               catch ( Il2CppExceptionWrapper *v140 )
			//               {
			//                 v132[0] = v140.ex;
			//                 sub_180222690(v132);
			//                 v5 = v155;
			//                 v7 = this;
			//                 v13 = v128;
			//                 goto LABEL_52;
			//               }
			//               sub_180222690(v132);
			//             }
			//           }
			// LABEL_52:
			//           v128 = ++v13;
			//           TilesForRender = v126;
			//         }
			//       }
			//       else
			//       {
			//         if ( !v5 )
			//           sub_180B536AC(v12, v11);
			//         if ( !v5.fields.camera )
			//           sub_180B536AC(v12, v11);
			//         transform = UnityEngine::Component::get_transform((Component *)v5.fields.camera, 0LL);
			//         if ( !transform )
			//           sub_180B536AC(v111, v110);
			//         v129 = *UnityEngine::Transform::get_position((Vector3 *)&v131, transform, 0LL);
			//         v112 = HG::Rendering::Runtime::VectorSwizzleUtils::xz(&v129, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//         v126 = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_18473B264)(
			//                  v112,
			//                  _mm_unpacklo_ps(
			//                    (__m128)LODWORD(TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_lastUpdatedPosition.x),
			//                    (__m128)LODWORD(TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_lastUpdatedPosition.y)).m128_u64[0]);
			//         v114 = sub_182413570(&v126);
			//         v115 = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields;
			//         if ( v115.s_asmUpdateAtlasDistance > *(float *)&v114 )
			//           v7.fields.m_asmUpdateMode = 0;
			//         if ( !v5.fields.camera )
			//           sub_180B536AC(v115, v113);
			//         v116 = UnityEngine::Component::get_transform((Component *)v5.fields.camera, 0LL);
			//         if ( !v116 )
			//           sub_180B536AC(v118, v117);
			//         v129 = *UnityEngine::Transform::get_position((Vector3 *)&v131, v116, 0LL);
			//         v126 = (__int64)HG::Rendering::Runtime::VectorSwizzleUtils::xz(&v129, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//         TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_lastUpdatedPosition = (Vector2)v126;
			//         v7.fields.shouldSwapManagers = 1;
			//       }
			//     }
			//   }
			// }
			// 
		}

		internal void SetCachedData(HGRenderGraph renderGraph)
		{
			// // Void SetCachedData(HGRenderGraph)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGASMManager::SetCachedData(
			//         HGASMManager *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ASMTileManager *m_asmTileManager; // rbx
			//   __int64 v6; // rdx
			//   HGASMManager__StaticFields *static_fields; // rax
			//   float v8; // xmm6_4
			//   float v9; // xmm7_4
			//   float v10; // xmm1_4
			//   Vector2 v11; // xmm15_8
			//   Vector2 v12; // xmm14_8
			//   __int64 v13; // xmm13_8
			//   float z; // ebx
			//   __m128i v15; // xmm11
			//   __int128 v16; // xmm6
			//   __int128 v17; // xmm7
			//   __int128 v18; // xmm8
			//   __int128 v19; // xmm9
			//   float m_asmCasterMinY; // xmm12_4
			//   float m_asmCasterMaxY; // xmm10_4
			//   Matrix4x4 *ShadowTransform; // rax
			//   __int128 v23; // xmm1
			//   Vector4 v24; // xmm2
			//   Vector4 v25; // xmm3
			//   HGShadowConstantBufferUtils__StaticFields *v26; // rcx
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm2
			//   __int128 v29; // xmm3
			//   HGShadowConstantBufferUtils__StaticFields *v30; // rcx
			//   ProfilingSampler *v31; // rax
			//   __int64 v32; // rdx
			//   __int64 v33; // rcx
			//   TextureHandle *v34; // rbx
			//   __int64 v35; // rdx
			//   __int64 v36; // rcx
			//   TextureHandle v37; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v39; // rdx
			//   __int64 v40; // rcx
			//   Vector4 v41; // [rsp+70h] [rbp-248h] BYREF
			//   int32_t indirectHeight; // [rsp+80h] [rbp-238h] BYREF
			//   float v43; // [rsp+84h] [rbp-234h]
			//   float v44; // [rsp+88h] [rbp-230h]
			//   __int64 v45; // [rsp+8Ch] [rbp-22Ch]
			//   Vector2 indexRegionMins; // [rsp+98h] [rbp-220h] BYREF
			//   Vector2 indexRegionMaxs; // [rsp+A0h] [rbp-218h] BYREF
			//   TextureHandle *v48; // [rsp+A8h] [rbp-210h] BYREF
			//   HGRenderGraphBuilder v49; // [rsp+B0h] [rbp-208h] BYREF
			//   Matrix4x4 v50; // [rsp+D0h] [rbp-1E8h] BYREF
			//   Matrix4x4 v51; // [rsp+110h] [rbp-1A8h] BYREF
			//   Il2CppExceptionWrapper *v52; // [rsp+150h] [rbp-168h] BYREF
			//   Quaternion v53[2]; // [rsp+160h] [rbp-158h] BYREF
			//   Matrix4x4 v54; // [rsp+180h] [rbp-138h] BYREF
			//   Matrix4x4 baseWorldToShadowMatrix; // [rsp+1C0h] [rbp-F8h] BYREF
			//   int32_t indirectWidth; // [rsp+2D8h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919E62 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGASMManager::ASMShadowPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGASMManager::ASMShadowPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&off_18D5EFF88);
			//     byte_18D919E62 = 1;
			//   }
			//   indexRegionMins = 0LL;
			//   indexRegionMaxs = 0LL;
			//   indirectWidth = 0;
			//   indirectHeight = 0;
			//   sub_1802F01E0(&baseWorldToShadowMatrix, 0LL, 64LL);
			//   sub_1802F01E0(&v54, 0LL, 64LL);
			//   sub_1802F01E0(&v50, 0LL, 64LL);
			//   memset(&v49, 0, sizeof(v49));
			//   v48 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1759, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1759, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v40, v39);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       0LL);
			//   }
			//   else
			//   {
			//     m_asmTileManager = this.fields.m_asmTileManager;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     if ( !m_asmTileManager )
			//       sub_180B536AC(TypeInfo::HG::Rendering::Runtime::HGASMManager, v6);
			//     HG::Rendering::Runtime::ASMTileManager::GenerateIndirectData(
			//       m_asmTileManager,
			//       TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmGridSize,
			//       this.fields.m_startVTIdx,
			//       16,
			//       16,
			//       TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmCacheRadius,
			//       &this.fields.m_worldToShadowMatrices,
			//       &baseWorldToShadowMatrix,
			//       &indexRegionMins,
			//       &indexRegionMaxs,
			//       &indirectWidth,
			//       &indirectHeight,
			//       0LL);
			//     static_fields = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields;
			//     v8 = (float)(16 * static_fields.s_asmTileResolution);
			//     v43 = v8;
			//     v9 = (float)(16 * static_fields.s_asmTileResolution);
			//     v44 = v9;
			//     v10 = (float)(static_fields.s_asmGridSize + static_fields.s_asmGridSize)
			//         / (float)static_fields.s_asmTileResolution;
			//     *(float *)&v45 = (float)(static_fields.s_asmDepthBias * v10) * 1.5;
			//     *((float *)&v45 + 1) = (float)(static_fields.s_asmNormalBias * v10) * 1.5;
			//     if ( fabs(this.fields.m_lightDir.y) < 0.0099999998 )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//       ShadowTransform = (Matrix4x4 *)sub_182805160(&v51);
			//     }
			//     else
			//     {
			//       v11 = indexRegionMins;
			//       v12 = indexRegionMaxs;
			//       v13 = *(_QWORD *)&this.fields.m_lightDir.x;
			//       z = this.fields.m_lightDir.z;
			//       v15 = _mm_loadu_si128((const __m128i *)&this.fields.m_lightRotation);
			//       v16 = *(_OWORD *)&this.fields.m_lightToWorld.m00;
			//       v17 = *(_OWORD *)&this.fields.m_lightToWorld.m01;
			//       v18 = *(_OWORD *)&this.fields.m_lightToWorld.m02;
			//       v19 = *(_OWORD *)&this.fields.m_lightToWorld.m03;
			//       m_asmCasterMinY = this.fields.m_asmCasterMinY;
			//       m_asmCasterMaxY = this.fields.m_asmCasterMaxY;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//       *(_OWORD *)&v51.m00 = v16;
			//       *(_OWORD *)&v51.m01 = v17;
			//       *(_OWORD *)&v51.m02 = v18;
			//       *(_OWORD *)&v51.m03 = v19;
			//       v53[0] = (Quaternion)v15;
			//       *(_QWORD *)&v41.x = v13;
			//       v41.z = z;
			//       HG::Rendering::Runtime::HGASMManager::GetASMShadowMatrixes(
			//         v11,
			//         v12,
			//         (Vector3 *)&v41,
			//         v53,
			//         &v51,
			//         0.1,
			//         1000.0,
			//         m_asmCasterMinY,
			//         m_asmCasterMaxY,
			//         &v50,
			//         &v54,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
			//       v51 = v50;
			//       v50 = v54;
			//       ShadowTransform = HG::Rendering::Runtime::HGShadowUtils::GetShadowTransform(&v54, &v50, &v51, 0LL);
			//       v8 = v43;
			//       v9 = v44;
			//     }
			//     v23 = *(_OWORD *)&ShadowTransform.m01;
			//     v24 = *(Vector4 *)&ShadowTransform.m02;
			//     v25 = *(Vector4 *)&ShadowTransform.m03;
			//     v26 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields;
			//     *(_OWORD *)&v26[23].shadowData._ASMIndirectWorldToShadow.m02 = *(_OWORD *)&ShadowTransform.m00;
			//     *(_OWORD *)&v26[23].shadowData._ASMIndirectWorldToShadow.m03 = v23;
			//     v26[23].shadowData._ASMParams = v24;
			//     v26[23].shadowData._ASMParams2 = v25;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//     v27 = *(_OWORD *)&baseWorldToShadowMatrix.m01;
			//     v28 = *(_OWORD *)&baseWorldToShadowMatrix.m02;
			//     v29 = *(_OWORD *)&baseWorldToShadowMatrix.m03;
			//     v30 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields;
			//     *(_OWORD *)&v30[23].shadowData._ASMWorldToShadowBaseMatrix.m02 = *(_OWORD *)&baseWorldToShadowMatrix.m00;
			//     *(_OWORD *)&v30[23].shadowData._ASMWorldToShadowBaseMatrix.m03 = v27;
			//     *(_OWORD *)&v30[23].shadowData._ASMIndirectWorldToShadow.m00 = v28;
			//     *(_OWORD *)&v30[23].shadowData._ASMIndirectWorldToShadow.m01 = v29;
			//     *(_QWORD *)&v41.x = v45;
			//     *(_QWORD *)&v41.z = 0x3D8000003D800000LL;
			//     TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields[23].shadowData._ASMShadowTexelSize = v41;
			//     v41.x = (float)this.fields.m_startVTIdx;
			//     v41.y = (float)indirectWidth;
			//     *(_QWORD *)&v41.z = COERCE_UNSIGNED_INT((float)indirectHeight);
			//     *(Vector4 *)&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields[23].shadowData._ASMIndirectParams.FixedElementField = v41;
			//     v41.x = 1.0 / v8;
			//     v41.y = 1.0 / v9;
			//     *(_QWORD *)&v41.z = __PAIR64__(LODWORD(v9), LODWORD(v8));
			//     *(Vector4 *)&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields[23].s_shadowBufferHandle.size = v41;
			//     v31 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x7Fu,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v33, v32);
			//     v49 = *(HGRenderGraphBuilder *)sub_1808369E4(
			//                                      (unsigned int)v53,
			//                                      (_DWORD)renderGraph,
			//                                      (unsigned int)"Set Cached ASM Shadow Map Data",
			//                                      (unsigned int)&v48,
			//                                      (__int64)v31,
			//                                      1,
			//                                      0);
			//     *(_QWORD *)&v41.x = 0LL;
			//     *(_QWORD *)&v41.z = &v49;
			//     try
			//     {
			//       v34 = v48;
			//       v37 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                (TextureHandle *)v53,
			//                renderGraph,
			//                this.fields.m_asmShadowMapRT,
			//                0LL);
			//       if ( !v34 )
			//         sub_1802DC2C8(v36, v35);
			//       v34[2] = v37;
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v49, 0, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v49,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_setASMShadowDataPass,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGASMManager::ASMShadowPassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v52 )
			//     {
			//       *(Il2CppExceptionWrapper *)&v41.x = (Il2CppExceptionWrapper)v52.ex;
			//     }
			//     sub_180222690(&v41);
			//   }
			// }
			// 
		}

		internal void SkipRenderASM(HGRenderGraph renderGraph)
		{
			// // Void SkipRenderASM(HGRenderGraph)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGASMManager::SkipRenderASM(
			//         HGASMManager *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v5; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   __int64 v8; // rcx
			//   __int64 v9; // rdx
			//   unsigned int v10; // edx
			//   unsigned __int64 v11; // r8
			//   char v12; // dl
			//   signed __int64 v13; // rtt
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   Il2CppExceptionWrapper *v17; // [rsp+48h] [rbp-50h] BYREF
			//   _QWORD v18[4]; // [rsp+50h] [rbp-48h] BYREF
			//   HGRenderGraphBuilder v19; // [rsp+70h] [rbp-28h] BYREF
			//   __int64 v20; // [rsp+B8h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919E63 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGASMManager::ASMShadowPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGASMManager::ASMShadowPassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&off_18D5EFFA0);
			//     byte_18D919E63 = 1;
			//   }
			//   memset(&v19, 0, sizeof(v19));
			//   v20 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1760, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1760, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v16, v15);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       0LL);
			//   }
			//   else
			//   {
			//     v5 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//            (Int32Enum__Enum)0x7Fu,
			//            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v7, v6);
			//     v19 = *(HGRenderGraphBuilder *)sub_1808369E4(
			//                                      (unsigned int)v18,
			//                                      (_DWORD)renderGraph,
			//                                      (unsigned int)"Skip Render ASM",
			//                                      (unsigned int)&v20,
			//                                      (__int64)v5,
			//                                      0,
			//                                      3);
			//     v18[0] = 0LL;
			//     v18[1] = &v19;
			//     try
			//     {
			//       v9 = v20;
			//       if ( !v20 )
			//         sub_1802DC2C8(v8, 0LL);
			//       *(_QWORD *)(v20 + 24) = renderGraph.fields.m_DefaultResources;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v10 = ((unsigned __int64)(v9 + 24) >> 12) & 0x1FFFFF;
			//         v11 = (unsigned __int64)v10 >> 6;
			//         v12 = v10 & 0x3F;
			//         _m_prefetchw(&qword_18D6870D0[v11]);
			//         do
			//           v13 = qword_18D6870D0[v11];
			//         while ( v13 != _InterlockedCompareExchange64(&qword_18D6870D0[v11], v13 | (1LL << v12), v13) );
			//       }
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v19, 0, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v19,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_skipASMPass,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGASMManager::ASMShadowPassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v17 )
			//     {
			//       v18[0] = v17.ex;
			//     }
			//     sub_180222690(v18);
			//   }
			// }
			// 
		}

		public void EndFrame()
		{
			// // Void EndFrame()
			// void HG::Rendering::Runtime::HGASMManager::EndFrame(HGASMManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1761, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1761, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			// }
			// 
		}

		public void Dispose()
		{
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static Dictionary<Camera, HGASMManager> s_asmManagers;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static Dictionary<Camera, HGASMManager> s_cachedASMManagers;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static Dictionary<Camera, int> s_cameraLifetime;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		private static List<Camera> s_toRemoveList;

		private const int GRID_COUNT_X = 16;

		private const int GRID_COUNT_Y = 16;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		private static float s_asmCacheRadius;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x24")]
		private static float s_asmGridSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x28")]
		private static int s_asmTileResolution;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2C")]
		private static float s_asmUpdateAtlasDistance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x30")]
		private static int s_asmMaxTileRenderCountPerFrame;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x34")]
		private static bool s_forceUpdateAllTilesMode;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x38")]
		private static Material s_clearShadowMaterial;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x40")]
		private static float s_asmDepthBias;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x44")]
		private static float s_asmNormalBias;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x48")]
		private static float s_asmScreenSizeMinSquared;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x4C")]
		private static uint s_asmManagerCullingMask;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x50")]
		public static Vector2 s_lastUpdatedPosition;

		private Vector3 m_cameraPosLightSpace;

		private ASMTileManager m_asmTileManager;

		private HGASMVirtualTextureAllocator m_vtAllocator;

		private Matrix4x4[] m_worldToShadowMatrices;

		private RTHandle m_asmShadowMapRT;

		private Matrix4x4 m_lightToWorld;

		private Vector3 m_lightDir;

		private Quaternion m_lightRotation;

		private Vector3[] m_frustumCorners;

		private Vector3[] m_frustumCornersLightSpace;

		private readonly Vector2[] m_frustumVerts;

		private Vector3[] m_frustumCornersForIndirect;

		private Vector3[] m_frustumCornersLightSpaceForIndirect;

		private readonly Vector2[] m_frustumVertsForIndirect;

		private Vector2 m_lastPositionXZ;

		private Vector3 m_lastLightDir;

		private int m_startVTIdx;

		private HGASMManager.ASMUpdateMode m_asmUpdateMode;

		private float m_asmCasterMinY;

		private float m_asmCasterMaxY;

		public bool shouldSwapManagers;

		internal HGASMManager m_friendASMManager;

		private ProfilerMarker m_samplerASMCreateTiles;

		private ProfilerMarker m_samplerASMUpdateCachedTiles;

		private ProfilerMarker m_samplerASMPreRenderTiles;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x58")]
		private static readonly RenderFunc<HGASMManager.ASMShadowPassData> s_renderASMShadowPass;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x60")]
		private static readonly RenderFunc<HGASMManager.ASMShadowPassData> s_setASMShadowDataPass;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x68")]
		private static readonly RenderFunc<HGASMManager.ASMShadowPassData> s_skipASMPass;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x70")]
		private static Plane[] s_tempPlanes;

		public enum ASMUpdateMode
		{
			Stop,
			Slow,
			Normal,
			Extreme
		}

		private class ASMShadowPassData
		{
			public ASMShadowPassData()
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

			public HGCamera hgCamera;

			public HGRenderGraphDefaultResources defaultResources;

			public TextureHandle asmShadowTexture;

			public Matrix4x4 deviceProjectionYFlipMatrix;

			public Matrix4x4 viewMatrix;

			public Matrix4x4 cullingMatrix;

			public Vector2Int viewportMins;

			public Vector2Int viewportMaxs;

			public Material clearShadowMaterial;

			public RendererList rendererList;

			public uint ecsRendererList;

			public uint ecsGrassList;
		}
	}
}
