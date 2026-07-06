using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class HGVFXManager
	{
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x000025D2 File Offset: 0x000007D2
		public static HGVFXManager instance
		{
			get
			{
				// // HGVFXManager get_instance()
				// HGVFXManager *HG::Rendering::Runtime::HGVFXManager::get_instance(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   struct HGGlobalGameManager__Class *v2; // rax
				//   HGManagerContextBase__Array *currentManagerContexts; // rax
				//   HGManagerContextBase *v4; // rbx
				// 
				//   if ( !byte_18D8ED95C )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::HGGlobalGameManager);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGManagerContext);
				//     byte_18D8ED95C = 1;
				//   }
				//   v2 = TypeInfo::UnityEngine::HyperGryph::HGGlobalGameManager;
				//   if ( !TypeInfo::UnityEngine::HyperGryph::HGGlobalGameManager._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::HyperGryph::HGGlobalGameManager, v1);
				//     v2 = TypeInfo::UnityEngine::HyperGryph::HGGlobalGameManager;
				//   }
				//   currentManagerContexts = v2.static_fields.currentManagerContexts;
				//   if ( !currentManagerContexts )
				//     sub_180B536AC(method, v1);
				//   if ( !currentManagerContexts.max_length.size )
				//     sub_180070270(method, v1);
				//   v4 = currentManagerContexts.vector[0];
				//   if ( v4 && (unsigned __int8)il2cpp_class_has_parent(v4.klass, TypeInfo::HG::Rendering::Runtime::HGManagerContext) )
				//     return (HGVFXManager *)v4[4].fields;
				//   else
				//     return 0LL;
				// }
				// 
				return null;
			}
		}

		public HGVFXManager()
		{
		}

		public void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::Runtime::HGVFXManager::Dispose(HGVFXManager *this, MethodInfo *method)
			// {
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v6; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919404 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGVFXManager::OnBeginCameraRendering);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
			//     byte_18D919404 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1920, 0LL) )
			//   {
			//     v3 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_180004920(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
			//     v6 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v3;
			//     if ( v3 )
			//     {
			//       System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
			//         v3,
			//         (Object *)this,
			//         MethodInfo::HG::Rendering::Runtime::HGVFXManager::OnBeginCameraRendering,
			//         0LL);
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
			//       UnityEngine::Rendering::RenderPipelineManager::remove_beginCameraRendering(v6, 0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1920, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public void AddSceneDarkToManager(VFXSceneDark sceneDark)
		{
			// // Void AddSceneDarkToManager(VFXSceneDark)
			// void HG::Rendering::Runtime::HGVFXManager::AddSceneDarkToManager(
			//         HGVFXManager *this,
			//         VFXSceneDark *sceneDark,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *m_sceneDarks; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED97E )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXSceneDark>::Add);
			//     byte_18D8ED97E = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2009, 0LL) )
			//   {
			//     m_sceneDarks = (List_1_System_Object_ *)this.fields.m_sceneDarks;
			//     if ( m_sceneDarks )
			//     {
			//       sub_1822AD140(m_sceneDarks, (Object *)sceneDark);
			//       return;
			//     }
			// LABEL_6:
			//     sub_180B536AC(m_sceneDarks, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2009, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)sceneDark,
			//     0LL);
			// }
			// 
		}

		public void RemoveSceneDarkToManager(VFXSceneDark sceneDark)
		{
			// // Void RemoveSceneDarkToManager(VFXSceneDark)
			// void HG::Rendering::Runtime::HGVFXManager::RemoveSceneDarkToManager(
			//         HGVFXManager *this,
			//         VFXSceneDark *sceneDark,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *m_sceneDarks; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED97F )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXSceneDark>::Remove);
			//     byte_18D8ED97F = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2010, 0LL) )
			//   {
			//     m_sceneDarks = (List_1_System_Object_ *)this.fields.m_sceneDarks;
			//     if ( m_sceneDarks )
			//     {
			//       System::Collections::Generic::List<System::Object>::Remove(
			//         m_sceneDarks,
			//         (Object *)sceneDark,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXSceneDark>::Remove);
			//       return;
			//     }
			// LABEL_6:
			//     sub_180B536AC(m_sceneDarks, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2010, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)sceneDark,
			//     0LL);
			// }
			// 
		}

		public void SetSceneDarkEnabled(bool enable)
		{
			// // Void SetSceneDarkEnabled(Boolean)
			// void HG::Rendering::Runtime::HGVFXManager::SetSceneDarkEnabled(HGVFXManager *this, bool enable, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2011, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2011, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)this, enable, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_enabled = enable;
			//   }
			// }
			// 
		}

		private void _UpdateSceneDarkValue()
		{
			// // Void _UpdateSceneDarkValue()
			// void HG::Rendering::Runtime::HGVFXManager::_UpdateSceneDarkValue(HGVFXManager *this, MethodInfo *method)
			// {
			//   List_1_System_Object_ *v3; // rcx
			//   __int64 v4; // rdx
			//   bool v5; // si
			//   int v6; // r14d
			//   float v7; // xmm8_4
			//   unsigned __int64 v8; // xmm7_8
			//   int32_t v9; // edi
			//   List_1_HG_Rendering_Runtime_VFXSceneDark_ *m_sceneDarks; // rax
			//   float unscaledTime; // xmm0_4
			//   float z; // eax
			//   float m_currentSceneSaturation; // xmm6_4
			//   float x; // xmm3_4
			//   float y; // xmm1_4
			//   float v16; // xmm2_4
			//   float v17; // xmm4_4
			//   float v18; // xmm5_4
			//   MethodInfo *v19; // r9
			//   MethodInfo *v20; // r8
			//   __int64 v21; // rdx
			//   __int64 v22; // rdx
			//   HGRenderPipeline *v23; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v25; // rdx
			//   Object *Item; // r15
			//   bool v27; // al
			//   Object *v28; // rax
			//   Vector3 *sceneDark; // rax
			//   __int64 v30; // xmm0_8
			//   MethodInfo *v31; // r8
			//   Vector4 v32; // xmm0
			//   __m128 v33; // xmm4
			//   __m128 v34; // xmm3
			//   __m128 v35; // xmm1
			//   __m128 v36; // xmm0
			//   __m128i v37; // xmm2
			//   int v38; // eax
			//   Object *v39; // rax
			//   Object *v40; // rax
			//   float v41; // xmm0_4
			//   __int64 v42; // rdx
			//   HGRenderPipeline *currentPipeline; // rax
			//   unsigned __int64 v44; // [rsp+20h] [rbp-29h]
			//   Vector4 v45; // [rsp+30h] [rbp-19h] BYREF
			//   Vector4 v46; // [rsp+40h] [rbp-9h] BYREF
			//   Vector4 v47; // [rsp+50h] [rbp+7h] BYREF
			// 
			//   if ( !byte_18D8ED980 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXSceneDark>::RemoveAt);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXSceneDark>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXSceneDark>::get_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8ED980 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v4 = **(_QWORD **)&v3[4].fields._size;
			//   if ( !v4 )
			//     goto LABEL_23;
			//   if ( *(int *)(v4 + 24) > 1972 )
			//   {
			//     if ( !v3[5].fields._size )
			//     {
			//       il2cpp_runtime_class_init_0(v3, v4);
			//       v3 = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = **(List_1_System_Object_ ***)&v3[4].fields._size;
			//     if ( !v3 )
			//       goto LABEL_23;
			//     if ( v3.fields._size <= 0x7B4u )
			//       sub_180070270(v3, v4);
			//     if ( v3[395].monitor )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1972, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//         return;
			//       }
			//       goto LABEL_23;
			//     }
			//   }
			//   if ( UnityEngine::Time::get_unscaledTime(0LL) == this.fields.m_lastUpdateTime )
			//     return;
			//   if ( !this.fields.m_enabled )
			//   {
			//     this.fields.m_lastUpdateTime = UnityEngine::Time::get_unscaledTime(0LL);
			//     this.fields.m_currentNeedStopAutoExposure = 0;
			//     *(_QWORD *)&this.fields.m_currentSceneDarkValue.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
			//     this.fields.m_currentSceneDarkValue.z = 1.0;
			//     this.fields.m_currentSceneSaturation = 1.0;
			//     return;
			//   }
			//   v5 = 0;
			//   v6 = _mm_cvtsi128_si32((__m128i)0x3F800000u);
			//   v7 = 1.0;
			//   v8 = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
			//   v44 = v8;
			//   v9 = 0;
			//   while ( 1 )
			//   {
			//     m_sceneDarks = this.fields.m_sceneDarks;
			//     if ( !m_sceneDarks )
			//       goto LABEL_23;
			//     if ( v9 >= m_sceneDarks.fields._size )
			//       break;
			//     Item = System::Collections::Generic::List<System::Object>::get_Item(
			//              (List_1_System_Object_ *)this.fields.m_sceneDarks,
			//              v9,
			//              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXSceneDark>::get_Item);
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v25);
			//     v27 = UnityEngine::Object::op_Inequality((Object_1 *)Item, 0LL, 0LL);
			//     v3 = (List_1_System_Object_ *)this.fields.m_sceneDarks;
			//     if ( v27 )
			//     {
			//       if ( !v3 )
			//         goto LABEL_23;
			//       v28 = System::Collections::Generic::List<System::Object>::get_Item(
			//               v3,
			//               v9,
			//               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXSceneDark>::get_Item);
			//       if ( !v28 )
			//         goto LABEL_23;
			//       sceneDark = HG::Rendering::Runtime::VFXSceneDark::get_sceneDark((Vector3 *)&v46, (VFXSceneDark *)v28, 0LL);
			//       v30 = *(_QWORD *)&sceneDark.x;
			//       *(float *)&sceneDark = sceneDark.z;
			//       *(_QWORD *)&v45.x = v30;
			//       LODWORD(v45.z) = (_DWORD)sceneDark;
			//       v32 = *UnityEngine::Vector4::op_Implicit(&v47, (Vector3 *)&v45, v31);
			//       v33 = (__m128)(unsigned int)v44;
			//       if ( v32.x <= *(float *)&v44 )
			//         v33 = (__m128)v32;
			//       v34 = (__m128)HIDWORD(v44);
			//       v35 = _mm_shuffle_ps((__m128)v32, (__m128)v32, 85);
			//       if ( v35.m128_f32[0] <= *((float *)&v44 + 1) )
			//         v34 = v35;
			//       v36 = _mm_shuffle_ps((__m128)v32, (__m128)v32, 170);
			//       v37 = _mm_cvtsi32_si128(v6);
			//       if ( v36.m128_f32[0] <= *(float *)v37.m128i_i32 )
			//         v37 = (__m128i)v36;
			//       v6 = _mm_cvtsi128_si32(v37);
			//       v44 = _mm_unpacklo_ps(v33, v34).m128_u64[0];
			//       v8 = v44;
			//       if ( v5 )
			//       {
			//         v38 = 1;
			//       }
			//       else
			//       {
			//         v3 = (List_1_System_Object_ *)this.fields.m_sceneDarks;
			//         if ( !v3 )
			//           goto LABEL_23;
			//         v39 = System::Collections::Generic::List<System::Object>::get_Item(
			//                 v3,
			//                 v9,
			//                 MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXSceneDark>::get_Item);
			//         if ( !v39 )
			//           goto LABEL_23;
			//         v38 = BYTE4(v39[3].monitor);
			//       }
			//       v3 = (List_1_System_Object_ *)this.fields.m_sceneDarks;
			//       v5 = v38 != 0;
			//       if ( !v3 )
			//         goto LABEL_23;
			//       v40 = System::Collections::Generic::List<System::Object>::get_Item(
			//               v3,
			//               v9,
			//               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXSceneDark>::get_Item);
			//       if ( !v40 )
			//         goto LABEL_23;
			//       if ( BYTE4(v40[3].klass) )
			//         v41 = *(float *)&v40[3].monitor;
			//       else
			//         v41 = 1.0;
			//       if ( v41 <= v7 )
			//         v7 = v41;
			//       ++v9;
			//     }
			//     else
			//     {
			//       if ( !v3 )
			//         goto LABEL_23;
			//       System::Collections::Generic::List<System::Object>::RemoveAt(
			//         v3,
			//         v9,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXSceneDark>::RemoveAt);
			//     }
			//   }
			//   unscaledTime = UnityEngine::Time::get_unscaledTime(0LL);
			//   z = this.fields.m_currentSceneDarkValue.z;
			//   m_currentSceneSaturation = this.fields.m_currentSceneSaturation;
			//   this.fields.m_lastUpdateTime = unscaledTime;
			//   *(_QWORD *)&this.fields.m_lastSceneDarkValue.x = *(_QWORD *)&this.fields.m_currentSceneDarkValue.x;
			//   this.fields.m_lastSceneDarkValue.z = z;
			//   this.fields.m_lastSceneSaturation = this.fields.m_currentSceneSaturation;
			//   LOBYTE(z) = this.fields.m_currentNeedStopAutoExposure;
			//   *(_QWORD *)&this.fields.m_currentSceneDarkValue.x = v8;
			//   this.fields.m_lastNeedStopAutoExposure = LOBYTE(z);
			//   this.fields.m_currentSceneSaturation = v7;
			//   LODWORD(this.fields.m_currentSceneDarkValue.z) = v6;
			//   this.fields.m_currentNeedStopAutoExposure = v5;
			//   x = this.fields.m_lastSceneDarkValue.x;
			//   y = this.fields.m_currentSceneDarkValue.y;
			//   v16 = this.fields.m_currentSceneDarkValue.z;
			//   v17 = this.fields.m_lastSceneDarkValue.y;
			//   v18 = this.fields.m_lastSceneDarkValue.z;
			//   v46.x = this.fields.m_currentSceneDarkValue.x;
			//   v46.y = y;
			//   v46.z = v16;
			//   v45.x = x;
			//   v45.y = v17;
			//   v45.z = v18;
			//   v46.w = v7;
			//   v45.w = m_currentSceneSaturation;
			//   v46 = *UnityEngine::Vector4::op_Subtraction(&v47, &v45, &v46, v19);
			//   v45 = v46;
			//   if ( UnityEngine::Vector4::Dot(&v45, &v46, v20) > 0.0099999998 )
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline, v21);
			//     if ( HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL) )
			//     {
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline, v42);
			//       currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//       if ( currentPipeline )
			//       {
			//         currentPipeline.fields._fastConvergeState_k__BackingField = 1;
			//         return;
			//       }
			//       goto LABEL_23;
			//     }
			//   }
			//   else
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline, v21);
			//     if ( HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL) )
			//     {
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline, v22);
			//       v23 = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//       if ( v23 )
			//       {
			//         v23.fields._fastConvergeState_k__BackingField = 0;
			//         return;
			//       }
			// LABEL_23:
			//       sub_180B536AC(v3, v4);
			//     }
			//   }
			// }
			// 
		}

		private void OnBeginCameraRendering(ScriptableRenderContext context, Camera targetCamera)
		{
			// // Void OnBeginCameraRendering(ScriptableRenderContext, Camera)
			// void HG::Rendering::Runtime::HGVFXManager::OnBeginCameraRendering(
			//         HGVFXManager *this,
			//         ScriptableRenderContext context,
			//         Camera *targetCamera,
			//         MethodInfo *method)
			// {
			//   Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *m_savedCameraAutoExposure; // rcx
			//   Dictionary_2_TKey_TValue_Entry_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo___Array__Class *klass; // rdx
			//   unsigned int (__fastcall *v9)(Camera *, Dictionary_2_TKey_TValue_Entry_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo___Array__Class *, Camera *, MethodInfo *); // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rax
			//   HGCamera *v12; // rbx
			//   int32_t InstanceID; // eax
			//   int32_t v14; // esi
			//   float Item; // xmm0_4
			// 
			//   if ( !byte_18D8ED981 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,float>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,float>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,float>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,float>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,float>::get_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     byte_18D8ED981 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   m_savedCameraAutoExposure = (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, context.m_Ptr);
			//     m_savedCameraAutoExposure = (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   klass = m_savedCameraAutoExposure[2].fields._entries.klass;
			//   if ( !klass )
			//     goto LABEL_16;
			//   if ( SLODWORD(klass._0.namespaze) > 1921 )
			//   {
			//     if ( !LODWORD(m_savedCameraAutoExposure[2].fields._values) )
			//     {
			//       il2cpp_runtime_class_init_0(m_savedCameraAutoExposure, klass);
			//       m_savedCameraAutoExposure = (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     m_savedCameraAutoExposure = (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)m_savedCameraAutoExposure[2].fields._entries.klass;
			//     if ( !m_savedCameraAutoExposure )
			//       goto LABEL_16;
			//     if ( LODWORD(m_savedCameraAutoExposure.fields._entries) <= 0x781 )
			//       sub_180070270(m_savedCameraAutoExposure, klass);
			//     if ( *(_QWORD *)&m_savedCameraAutoExposure[192].fields._freeCount )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1921, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_216(Patch, (Object *)this, context, (Object *)targetCamera, 0LL);
			//         return;
			//       }
			//       goto LABEL_16;
			//     }
			//   }
			//   if ( !targetCamera )
			//     goto LABEL_16;
			//   v9 = (unsigned int (__fastcall *)(Camera *, Dictionary_2_TKey_TValue_Entry_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo___Array__Class *, Camera *, MethodInfo *))qword_18D8F4200;
			//   if ( !qword_18D8F4200 )
			//   {
			//     v9 = (unsigned int (__fastcall *)(Camera *, Dictionary_2_TKey_TValue_Entry_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo___Array__Class *, Camera *, MethodInfo *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_cameraType()");
			//     if ( !v9 )
			//     {
			//       v11 = sub_1802DBBE8("UnityEngine.Camera::get_cameraType()");
			//       sub_18000F750(v11, 0LL);
			//     }
			//     qword_18D8F4200 = (__int64)v9;
			//   }
			//   if ( v9(targetCamera, klass, targetCamera, method) == 1 )
			//   {
			//     if ( !this.fields.m_currentNeedStopAutoExposure )
			//     {
			//       m_savedCameraAutoExposure = (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)this.fields.m_savedCameraAutoExposure;
			//       if ( m_savedCameraAutoExposure )
			//       {
			//         if ( m_savedCameraAutoExposure.fields._count - m_savedCameraAutoExposure.fields._freeCount > 0 )
			//           System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,Beyond::Gameplay::RemoteFactory::RegionMapVoxelInfo>::Clear(
			//             m_savedCameraAutoExposure,
			//             MethodInfo::System::Collections::Generic::Dictionary<int,float>::Clear);
			//         return;
			//       }
			//       goto LABEL_16;
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, klass);
			//     v12 = HG::Rendering::Runtime::HGCamera::GetOrCreate(targetCamera, 0, 0LL);
			//     if ( v12 )
			//     {
			//       InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)targetCamera, 0LL);
			//       m_savedCameraAutoExposure = (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)this.fields.m_savedCameraAutoExposure;
			//       v14 = InstanceID;
			//       if ( !m_savedCameraAutoExposure )
			//         goto LABEL_16;
			//       if ( !System::Collections::Generic::Dictionary<int,float>::ContainsKey(
			//               (Dictionary_2_System_Int32_System_Single_ *)m_savedCameraAutoExposure,
			//               InstanceID,
			//               MethodInfo::System::Collections::Generic::Dictionary<int,float>::ContainsKey) )
			//       {
			//         m_savedCameraAutoExposure = (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)this.fields.m_savedCameraAutoExposure;
			//         if ( !m_savedCameraAutoExposure )
			//           goto LABEL_16;
			//         System::Collections::Generic::Dictionary<int,float>::Add(
			//           (Dictionary_2_System_Int32_System_Single_ *)m_savedCameraAutoExposure,
			//           v14,
			//           v12.fields.exposureAdaptation,
			//           MethodInfo::System::Collections::Generic::Dictionary<int,float>::Add);
			//       }
			//       m_savedCameraAutoExposure = (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)this.fields.m_savedCameraAutoExposure;
			//       if ( m_savedCameraAutoExposure )
			//       {
			//         Item = System::Collections::Generic::Dictionary<int,float>::get_Item(
			//                  (Dictionary_2_System_Int32_System_Single_ *)m_savedCameraAutoExposure,
			//                  v14,
			//                  MethodInfo::System::Collections::Generic::Dictionary<int,float>::get_Item);
			//         v12.fields.exposureTargetAdaptation = Item;
			//         v12.fields.exposureAdaptation = Item;
			//         return;
			//       }
			// LABEL_16:
			//       sub_180B536AC(m_savedCameraAutoExposure, klass);
			//     }
			//   }
			// }
			// 
		}

		public void Tick()
		{
			// // Void Tick()
			// void HG::Rendering::Runtime::HGVFXManager::Tick(HGVFXManager *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2__Array *v6; // rax
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
			//   static_fields = v3.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 1971 )
			//   {
			// LABEL_7:
			//     HG::Rendering::Runtime::HGVFXManager::_UpdateSceneDarkValue(this, 0LL);
			//     return;
			//   }
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v3.static_fields;
			//   v6 = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( v6.max_length.size <= 0x7B3u )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( !v6[54].vector[27] )
			//     goto LABEL_7;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1971, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public static void SetPlayerPosition(Vector3 playerPosition)
		{
			// // Void SetPlayerPosition(Vector3)
			// void HG::Rendering::Runtime::HGVFXManager::SetPlayerPosition(Vector3 *playerPosition, MethodInfo *method)
			// {
			//   HGVFXManager *instance; // rax
			//   __int64 v4; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float v6; // ecx
			//   float z; // eax
			//   Vector3 v8; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2012, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2012, 0LL);
			//     if ( Patch )
			//     {
			//       z = playerPosition.z;
			//       *(_QWORD *)&v8.x = *(_QWORD *)&playerPosition.x;
			//       v8.z = z;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_771(Patch, &v8, 0LL);
			//       return;
			//     }
			//     goto LABEL_6;
			//   }
			//   if ( !HG::Rendering::Runtime::HGVFXManager::get_instance(0LL) )
			//     return;
			//   instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
			//   if ( !instance )
			// LABEL_6:
			//     sub_180B536AC(Patch, v4);
			//   v6 = playerPosition.z;
			//   *(_QWORD *)&instance.fields.m_playerPosition.x = *(_QWORD *)&playerPosition.x;
			//   instance.fields.m_playerPosition.z = v6;
			// }
			// 
		}

		public static Vector3 GetPlayerPosition()
		{
			// // Vector3 GetPlayerPosition()
			// Vector3 *HG::Rendering::Runtime::HGVFXManager::GetPlayerPosition(Vector3 *__return_ptr retstr, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   HGVFXManager *instance; // rax
			//   __int64 v6; // xmm0_8
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v12[2]; // [rsp+20h] [rbp-18h] BYREF
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
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_12;
			//   if ( wrapperArray.max_length.size > 824 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( !v3 )
			//       goto LABEL_12;
			//     if ( LODWORD(v3._0.namespaze) <= 0x338 )
			//       sub_180070270(v3, wrapperArray);
			//     if ( v3[17]._1.cctor_thread )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(824, 0LL);
			//       if ( Patch )
			//       {
			//         v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_316(v12, Patch, 0LL);
			//         v11 = *(_QWORD *)&v10.x;
			//         z = v10.z;
			//         *(_QWORD *)&retstr.x = v11;
			//         goto LABEL_10;
			//       }
			// LABEL_12:
			//       sub_180B536AC(v3, wrapperArray);
			//     }
			//   }
			//   if ( !HG::Rendering::Runtime::HGVFXManager::get_instance(0LL) )
			//   {
			//     *(_QWORD *)&retstr.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//     retstr.z = 0.0;
			//     return retstr;
			//   }
			//   instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
			//   if ( !instance )
			//     goto LABEL_12;
			//   v6 = *(_QWORD *)&instance.fields.m_playerPosition.x;
			//   z = instance.fields.m_playerPosition.z;
			//   *(_QWORD *)&retstr.x = v6;
			// LABEL_10:
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static void SetPlayerHeights(List<float> playerHeights)
		{
			// // Void SetPlayerHeights(List`1[System.Single])
			// void HG::Rendering::Runtime::HGVFXManager::SetPlayerHeights(List_1_System_Single_ *playerHeights, MethodInfo *method)
			// {
			//   HGVFXManager *instance; // rax
			//   Vector3Int *v4; // r8
			//   ITilemap *v5; // r9
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   TileAnimationData v8; // xmm1
			//   int32_t v9; // ebx
			//   HGVFXManager *v10; // rsi
			//   float Item; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TileAnimationData v13; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8ED982 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<float>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<float>::get_Item);
			//     byte_18D8ED982 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2013, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2013, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)playerHeights, 0LL);
			//       return;
			//     }
			//     goto LABEL_18;
			//   }
			//   if ( !HG::Rendering::Runtime::HGVFXManager::get_instance(0LL) )
			//     return;
			//   instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
			//   v8 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//           &v13,
			//           (TileBase *)instance,
			//           v4,
			//           v5,
			//           (MethodInfo *)v13.m_AnimatedSprites);
			//   if ( !v6 || (*(TileAnimationData *)(v6 + 92) = v8, v9 = 0, !playerHeights) )
			// LABEL_18:
			//     sub_180B536AC(v7, v6);
			//   while ( v9 < playerHeights.fields._size && (unsigned int)v9 <= 3 )
			//   {
			//     v10 = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
			//     if ( !v10 )
			//       goto LABEL_18;
			//     Item = System::Collections::Generic::List<float>::get_Item(
			//              playerHeights,
			//              v9,
			//              MethodInfo::System::Collections::Generic::List<float>::get_Item);
			//     if ( v9 )
			//     {
			//       if ( v9 == 1 )
			//       {
			//         v10.fields.m_playerHeights.y = Item;
			//         v9 = 2;
			//       }
			//       else if ( v9 == 2 )
			//       {
			//         v10.fields.m_playerHeights.z = Item;
			//         v9 = 3;
			//       }
			//       else
			//       {
			//         v10.fields.m_playerHeights.w = Item;
			//         v9 = 4;
			//       }
			//     }
			//     else
			//     {
			//       v10.fields.m_playerHeights.x = Item;
			//       v9 = 1;
			//     }
			//   }
			// }
			// 
		}

		public static Vector4 GetPlayerHeights()
		{
			// // Vector4 GetPlayerHeights()
			// Vector4 *HG::Rendering::Runtime::HGVFXManager::GetPlayerHeights(Vector4 *__return_ptr retstr, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   TileBase *v6; // rdx
			//   Vector3Int *v7; // r8
			//   ITilemap *v8; // r9
			//   HGVFXManager *instance; // rax
			//   Vector4 m_playerHeights; // xmm0
			//   Vector4 *result; // rax
			//   ILFixDynamicMethodWrapper_2__Array *v12; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 *TileAnimationDataNoRef; // rax
			//   Vector4 v15; // [rsp+20h] [rbp-18h] BYREF
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
			//   static_fields = v3.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_11;
			//   if ( wrapperArray.max_length.size <= 828 )
			//     goto LABEL_7;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v3.static_fields;
			//   v12 = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			// LABEL_11:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   if ( v12.max_length.size <= 0x33Cu )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( v12[23].vector[0] )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(828, 0LL);
			//     if ( Patch )
			//     {
			//       TileAnimationDataNoRef = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_319(&v15, Patch, 0LL);
			// LABEL_21:
			//       m_playerHeights = *TileAnimationDataNoRef;
			//       goto LABEL_10;
			//     }
			//     goto LABEL_11;
			//   }
			// LABEL_7:
			//   if ( !HG::Rendering::Runtime::HGVFXManager::get_instance(0LL) )
			//   {
			//     TileAnimationDataNoRef = (Vector4 *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                                           (TileAnimationData *)&v15,
			//                                           v6,
			//                                           v7,
			//                                           v8,
			//                                           *(MethodInfo **)&v15.x);
			//     goto LABEL_21;
			//   }
			//   instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
			//   if ( !instance )
			//     goto LABEL_11;
			//   m_playerHeights = instance.fields.m_playerHeights;
			// LABEL_10:
			//   result = retstr;
			//   *retstr = m_playerHeights;
			//   return result;
			// }
			// 
			return null;
		}

		public static void SetAnchorWaveBright(Vector2 anchorPosition, float anchorRadius, float anchorBrightIntensity, bool anchorBrightFlag)
		{
			// // Void SetAnchorWaveBright(Vector2, Single, Single, Boolean)
			// void HG::Rendering::Runtime::HGVFXManager::SetAnchorWaveBright(
			//         Vector2 anchorPosition,
			//         float anchorRadius,
			//         float anchorBrightIntensity,
			//         bool anchorBrightFlag,
			//         MethodInfo *method)
			// {
			//   HGVFXManager *instance; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   HGVFXManager *v10; // rax
			//   HGVFXManager *v11; // rax
			//   HGVFXManager *v12; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2014, 0LL) )
			//   {
			//     if ( !HG::Rendering::Runtime::HGVFXManager::get_instance(0LL) )
			//       return;
			//     instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
			//     if ( instance )
			//     {
			//       instance.fields.m_anchorPosition = anchorPosition;
			//       v10 = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
			//       if ( v10 )
			//       {
			//         v10.fields.m_anchorRadius = anchorRadius;
			//         v11 = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
			//         if ( v11 )
			//         {
			//           v11.fields.m_anchorBrightIntensity = anchorBrightIntensity;
			//           v12 = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
			//           if ( v12 )
			//           {
			//             v12.fields.m_anchorBrightFlag = anchorBrightFlag;
			//             return;
			//           }
			//         }
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v9, v8);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2014, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_772(
			//     Patch,
			//     anchorPosition,
			//     anchorRadius,
			//     anchorBrightIntensity,
			//     anchorBrightFlag,
			//     0LL);
			// }
			// 
		}

		public static Vector4 GetAnchorWaveBright()
		{
			// // Vector4 GetAnchorWaveBright()
			// Vector4 *HG::Rendering::Runtime::HGVFXManager::GetAnchorWaveBright(Vector4 *__return_ptr retstr, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   TileBase *v5; // rdx
			//   Vector3Int *v6; // r8
			//   ITilemap *v7; // r9
			//   HGVFXManager *instance; // rax
			//   BOOL m_anchorBrightFlag; // edi
			//   HGVFXManager *v10; // rax
			//   __m128 x_low; // xmm6
			//   HGVFXManager *v12; // rax
			//   float y; // xmm9_4
			//   HGVFXManager *v14; // rax
			//   float m_anchorRadius; // xmm10_4
			//   HGVFXManager *v16; // rax
			//   float m_anchorBrightIntensity; // xmm7_4
			//   float v18; // xmm7_4
			//   __m128 v19; // xmm6
			//   __m128 v20; // xmm6
			//   __m128 v21; // xmm6
			//   __m128 v22; // xmm6
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 *TileAnimationDataNoRef; // rax
			//   ILFixDynamicMethodWrapper_2 *v26; // rax
			//   MethodInfo *v27; // [rsp+20h] [rbp-88h]
			//   Vector4 v28; // [rsp+40h] [rbp-68h] BYREF
			// 
			//   if ( !byte_18D8ED983 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D8ED983 = 1;
			//   }
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
			//     goto LABEL_26;
			//   if ( wrapperArray.max_length.size > 827 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v3.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_26;
			//     if ( wrapperArray.max_length.size <= 0x33Bu )
			//       goto LABEL_43;
			//     if ( wrapperArray[23].max_length.value )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(827, 0LL);
			//       if ( !Patch )
			//         goto LABEL_26;
			//       TileAnimationDataNoRef = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_319(&v28, Patch, 0LL);
			// LABEL_34:
			//       *retstr = *TileAnimationDataNoRef;
			//       return retstr;
			//     }
			//   }
			//   if ( !HG::Rendering::Runtime::HGVFXManager::get_instance(0LL) )
			//   {
			//     TileAnimationDataNoRef = (Vector4 *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                                           (TileAnimationData *)&v28,
			//                                           v5,
			//                                           v6,
			//                                           v7,
			//                                           v27);
			//     goto LABEL_34;
			//   }
			//   instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
			//   if ( !instance )
			//     goto LABEL_26;
			//   m_anchorBrightFlag = instance.fields.m_anchorBrightFlag;
			//   v10 = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
			//   if ( !v10 )
			//     goto LABEL_26;
			//   x_low = (__m128)LODWORD(v10.fields.m_anchorPosition.x);
			//   v12 = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
			//   if ( !v12 )
			//     goto LABEL_26;
			//   y = v12.fields.m_anchorPosition.y;
			//   v14 = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
			//   if ( !v14 )
			//     goto LABEL_26;
			//   m_anchorRadius = v14.fields.m_anchorRadius;
			//   v16 = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
			//   if ( !v16 )
			//     goto LABEL_26;
			//   m_anchorBrightIntensity = v16.fields.m_anchorBrightIntensity;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, wrapperArray);
			//   v18 = m_anchorBrightIntensity * (float)m_anchorBrightFlag;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_26;
			//   if ( wrapperArray.max_length.size > 826 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( !v3 )
			//       goto LABEL_26;
			//     if ( LODWORD(v3._0.namespaze) > 0x33A )
			//     {
			//       if ( !*(_QWORD *)&v3[17]._1.instance_size )
			//         goto LABEL_23;
			//       v26 = IFix::WrappersManagerImpl::GetPatch(826, 0LL);
			//       if ( v26 )
			//       {
			//         v22 = *(__m128 *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_318(
			//                            &v28,
			//                            v26,
			//                            x_low.m128_f32[0],
			//                            y,
			//                            m_anchorRadius,
			//                            v18,
			//                            0LL);
			//         goto LABEL_24;
			//       }
			// LABEL_26:
			//       sub_180B536AC(v3, wrapperArray);
			//     }
			// LABEL_43:
			//     sub_180070270(v3, wrapperArray);
			//   }
			// LABEL_23:
			//   v19 = _mm_shuffle_ps(x_low, x_low, 225);
			//   v19.m128_f32[0] = y;
			//   v20 = _mm_shuffle_ps(v19, v19, 198);
			//   v20.m128_f32[0] = m_anchorRadius;
			//   v21 = _mm_shuffle_ps(v20, v20, 39);
			//   v21.m128_f32[0] = v18;
			//   v22 = _mm_shuffle_ps(v21, v21, 57);
			// LABEL_24:
			//   *retstr = (Vector4)v22;
			//   return retstr;
			// }
			// 
			return null;
		}

		public void InitVFXSceneColorAdjustment(Shader sceneColorAdjustmentShader)
		{
		}

		public bool UseSceneSaturationColorAdjustment()
		{
			// // Boolean UseSceneSaturationColorAdjustment()
			// bool HG::Rendering::Runtime::HGVFXManager::UseSceneSaturationColorAdjustment(HGVFXManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2016, 0LL) )
			//     return this.fields.m_currentSceneSaturation < 0.99;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2016, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public Material BeforeDrawVFXSceneColorAdjustmentMaterial()
		{
			// // Material BeforeDrawVFXSceneColorAdjustmentMaterial()
			// Material *HG::Rendering::Runtime::HGVFXManager::BeforeDrawVFXSceneColorAdjustmentMaterial(
			//         HGVFXManager *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Material *m_vfxSceneColorAdjustmentMaterial; // rcx
			//   Shader *shader; // rbx
			//   double m_currentSceneSaturation; // xmm0_8
			//   float v8; // xmm2_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   LocalKeyword keyword; // [rsp+20h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D919405 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     sub_18003C530(&off_18C8E1418);
			//     byte_18D919405 = 1;
			//   }
			//   memset(&keyword, 0, sizeof(keyword));
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2017, 0LL) )
			//   {
			//     if ( fminf(
			//            fminf(this.fields.m_currentSceneDarkValue.x, this.fields.m_currentSceneDarkValue.y),
			//            this.fields.m_currentSceneDarkValue.z) > 0.99
			//       && this.fields.m_currentSceneSaturation > 0.99 )
			//     {
			//       return 0LL;
			//     }
			//     m_vfxSceneColorAdjustmentMaterial = this.fields.m_vfxSceneColorAdjustmentMaterial;
			//     if ( m_vfxSceneColorAdjustmentMaterial )
			//     {
			//       shader = UnityEngine::Material::get_shader(m_vfxSceneColorAdjustmentMaterial, 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//       UnityEngine::Rendering::LocalKeyword::LocalKeyword(
			//         &keyword,
			//         shader,
			//         TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_SceneColorAdjustMentEnableSaturation,
			//         0LL);
			//       m_vfxSceneColorAdjustmentMaterial = this.fields.m_vfxSceneColorAdjustmentMaterial;
			//       m_currentSceneSaturation = this.fields.m_currentSceneSaturation;
			//       if ( m_vfxSceneColorAdjustmentMaterial )
			//       {
			//         UnityEngine::Material::SetKeyword(
			//           m_vfxSceneColorAdjustmentMaterial,
			//           &keyword,
			//           m_currentSceneSaturation < 0.99,
			//           0LL);
			//         m_vfxSceneColorAdjustmentMaterial = this.fields.m_vfxSceneColorAdjustmentMaterial;
			//         if ( m_currentSceneSaturation < 0.99 )
			//         {
			//           if ( m_vfxSceneColorAdjustmentMaterial )
			//           {
			//             v8 = 1.0;
			//             goto LABEL_14;
			//           }
			//         }
			//         else if ( m_vfxSceneColorAdjustmentMaterial )
			//         {
			//           v8 = 2.0;
			// LABEL_14:
			//           UnityEngine::Material::SetFloat(m_vfxSceneColorAdjustmentMaterial, (String *)"_SrcBlend", v8, 0LL);
			//           return this.fields.m_vfxSceneColorAdjustmentMaterial;
			//         }
			//       }
			//     }
			// LABEL_16:
			//     sub_180B536AC(m_vfxSceneColorAdjustmentMaterial, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2017, 0LL);
			//   if ( !Patch )
			//     goto LABEL_16;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_685(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public void DrawVFXSceneColorAdjustmentMaterial(CommandBuffer cmd)
		{
			// // Void DrawVFXSceneColorAdjustmentMaterial(CommandBuffer)
			// void HG::Rendering::Runtime::HGVFXManager::DrawVFXSceneColorAdjustmentMaterial(
			//         HGVFXManager *this,
			//         CommandBuffer *cmd,
			//         MethodInfo *method)
			// {
			//   Material *v5; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !byte_18D919406 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919406 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2018, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2018, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)cmd,
			//       0LL);
			//   }
			//   else
			//   {
			//     v5 = HG::Rendering::Runtime::HGVFXManager::BeforeDrawVFXSceneColorAdjustmentMaterial(this, 0LL);
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( !UnityEngine::Object::op_Equality((Object_1 *)v5, 0LL, 0LL) )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//       UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, v5, 0LL, 0, 0LL);
			//     }
			//   }
			// }
			// 
		}

		public void GetSceneColorAdjustmentParams(out Vector3 value, out float saturation)
		{
			// // Void GetSceneColorAdjustmentParams(Vector3 ByRef, Single ByRef)
			// void HG::Rendering::Runtime::HGVFXManager::GetSceneColorAdjustmentParams(
			//         HGVFXManager *this,
			//         Vector3 *value,
			//         float *saturation,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, value);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 823 )
			//   {
			// LABEL_7:
			//     z = this.fields.m_currentSceneDarkValue.z;
			//     *(_QWORD *)&value.x = *(_QWORD *)&this.fields.m_currentSceneDarkValue.x;
			//     value.z = z;
			//     *saturation = this.fields.m_currentSceneSaturation;
			//     return;
			//   }
			//   if ( !v7._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v7, wrapperArray);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7.static_fields.wrapperArray;
			//   if ( !v7 )
			//     goto LABEL_8;
			//   if ( LODWORD(v7._0.namespaze) <= 0x337 )
			//     sub_180070270(v7, wrapperArray);
			//   if ( !*(_QWORD *)&v7[17]._1.cctor_finished_or_no_cctor )
			//     goto LABEL_7;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(823, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(v7, wrapperArray);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_315(Patch, (Object *)this, value, saturation, 0LL);
			// }
			// 
		}

		private static void _GetOrthographicNearClipCorners(Camera camera, float posZ, Vector3[] result)
		{
			// // Void _GetOrthographicNearClipCorners(Camera, Single, Vector3[])
			// void HG::Rendering::Runtime::HGVFXManager::_GetOrthographicNearClipCorners(
			//         Camera *camera,
			//         float posZ,
			//         Vector3__Array *result,
			//         MethodInfo *method)
			// {
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   float v8; // xmm12_4
			//   float orthographicSize; // xmm8_4
			//   float v10; // xmm7_4
			//   Transform *transform; // rax
			//   Vector3 *right; // rax
			//   __int64 v13; // xmm11_8
			//   float z; // r15d
			//   Transform *v15; // rax
			//   Vector3 *up; // rax
			//   __int64 v17; // xmm10_8
			//   float v18; // r14d
			//   Transform *v19; // rax
			//   Vector3 *forward; // rax
			//   __int64 v21; // xmm9_8
			//   float v22; // esi
			//   Transform *v23; // rax
			//   Vector3 *position; // rax
			//   __int64 v25; // xmm13_8
			//   float v26; // ebx
			//   MethodInfo *v27; // r9
			//   Vector3 *v28; // rax
			//   __int64 v29; // xmm3_8
			//   MethodInfo *v30; // r9
			//   Vector3 *v31; // rax
			//   __int64 v32; // xmm3_8
			//   MethodInfo *v33; // r9
			//   Vector3 *v34; // rax
			//   __int64 v35; // xmm3_8
			//   MethodInfo *v36; // r9
			//   Vector3 *v37; // rax
			//   __int64 v38; // xmm3_8
			//   MethodInfo *v39; // r9
			//   Vector3 *v40; // rax
			//   __int64 v41; // xmm3_8
			//   MethodInfo *v42; // r9
			//   Vector3 *v43; // rax
			//   __int64 v44; // xmm0_8
			//   float v45; // eax
			//   MethodInfo *v46; // r9
			//   Vector3 *v47; // rax
			//   __int64 v48; // xmm3_8
			//   MethodInfo *v49; // r9
			//   Vector3 *v50; // rax
			//   __int64 v51; // xmm3_8
			//   MethodInfo *v52; // r9
			//   Vector3 *v53; // rax
			//   __int64 v54; // xmm3_8
			//   MethodInfo *v55; // r9
			//   Vector3 *v56; // rax
			//   __int64 v57; // xmm3_8
			//   MethodInfo *v58; // r9
			//   Vector3 *v59; // rax
			//   __int64 v60; // xmm3_8
			//   MethodInfo *v61; // r9
			//   Vector3 *v62; // rax
			//   __int64 v63; // xmm3_8
			//   MethodInfo *v64; // r9
			//   Vector3 *v65; // rax
			//   __int64 v66; // xmm3_8
			//   MethodInfo *v67; // r9
			//   Vector3 *v68; // rax
			//   __int64 v69; // xmm3_8
			//   MethodInfo *v70; // r9
			//   Vector3 *v71; // rax
			//   __int64 v72; // xmm3_8
			//   MethodInfo *v73; // r9
			//   Vector3 *v74; // rax
			//   __int64 v75; // xmm3_8
			//   MethodInfo *v76; // r9
			//   Vector3 *v77; // rax
			//   __int64 v78; // xmm3_8
			//   MethodInfo *v79; // r9
			//   Vector3 *v80; // rax
			//   __int64 v81; // xmm3_8
			//   MethodInfo *v82; // r9
			//   Vector3 *v83; // rax
			//   __int64 v84; // xmm3_8
			//   MethodInfo *v85; // r9
			//   Vector3 *v86; // rax
			//   __int64 v87; // xmm3_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v89; // [rsp+38h] [rbp-89h] BYREF
			//   Vector3 v90; // [rsp+48h] [rbp-79h] BYREF
			//   Vector3 v91; // [rsp+58h] [rbp-69h] BYREF
			//   Vector3 v92; // [rsp+68h] [rbp-59h] BYREF
			//   Vector3 v93[12]; // [rsp+78h] [rbp-49h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1010, 0LL) )
			//   {
			//     if ( camera )
			//     {
			//       v8 = UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
			//       orthographicSize = UnityEngine::Camera::get_orthographicSize(camera, 0LL);
			//       v10 = UnityEngine::Camera::get_aspect(camera, 0LL) * orthographicSize;
			//       transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
			//       if ( transform )
			//       {
			//         right = UnityEngine::Transform::get_right(&v92, transform, 0LL);
			//         v13 = *(_QWORD *)&right.x;
			//         z = right.z;
			//         v15 = UnityEngine::Component::get_transform((Component *)camera, 0LL);
			//         if ( v15 )
			//         {
			//           up = UnityEngine::Transform::get_up(&v92, v15, 0LL);
			//           v17 = *(_QWORD *)&up.x;
			//           v18 = up.z;
			//           v19 = UnityEngine::Component::get_transform((Component *)camera, 0LL);
			//           if ( v19 )
			//           {
			//             forward = UnityEngine::Transform::get_forward(&v92, v19, 0LL);
			//             v21 = *(_QWORD *)&forward.x;
			//             v22 = forward.z;
			//             v23 = UnityEngine::Component::get_transform((Component *)camera, 0LL);
			//             if ( v23 )
			//             {
			//               position = UnityEngine::Transform::get_position(&v92, v23, 0LL);
			//               *(_QWORD *)&v89.x = v21;
			//               v89.z = v22;
			//               v25 = *(_QWORD *)&position.x;
			//               v26 = position.z;
			//               v28 = UnityEngine::Vector3::op_Multiply(&v91, &v89, v8, v27);
			//               *(_QWORD *)&v89.x = v13;
			//               v89.z = z;
			//               v29 = *(_QWORD *)&v28.x;
			//               *(float *)&v28 = v28.z;
			//               *(_QWORD *)&v90.x = v29;
			//               LODWORD(v90.z) = (_DWORD)v28;
			//               *(_QWORD *)&v91.x = v25;
			//               v91.z = v26;
			//               v31 = UnityEngine::Vector3::op_Multiply(&v92, &v89, v10, v30);
			//               v32 = *(_QWORD *)&v31.x;
			//               *(float *)&v31 = v31.z;
			//               *(_QWORD *)&v89.x = v32;
			//               LODWORD(v89.z) = (_DWORD)v31;
			//               v34 = UnityEngine::Vector3::op_Addition(&v92, &v91, &v90, v33);
			//               *(_QWORD *)&v91.x = v17;
			//               v91.z = v18;
			//               v35 = *(_QWORD *)&v34.x;
			//               *(float *)&v34 = v34.z;
			//               *(_QWORD *)&v90.x = v35;
			//               LODWORD(v90.z) = (_DWORD)v34;
			//               v37 = UnityEngine::Vector3::op_Multiply(&v92, &v91, orthographicSize, v36);
			//               v38 = *(_QWORD *)&v37.x;
			//               *(float *)&v37 = v37.z;
			//               *(_QWORD *)&v91.x = v38;
			//               LODWORD(v91.z) = (_DWORD)v37;
			//               v40 = UnityEngine::Vector3::op_Subtraction(&v92, &v90, &v89, v39);
			//               v41 = *(_QWORD *)&v40.x;
			//               *(float *)&v40 = v40.z;
			//               *(_QWORD *)&v90.x = v41;
			//               LODWORD(v90.z) = (_DWORD)v40;
			//               v43 = UnityEngine::Vector3::op_Subtraction(&v92, &v90, &v91, v42);
			//               if ( result )
			//               {
			//                 v44 = *(_QWORD *)&v43.x;
			//                 v45 = v43.z;
			//                 *(_QWORD *)&v91.x = v44;
			//                 v91.z = v45;
			//                 sub_180040FA0(result, 0LL, &v91);
			//                 *(_QWORD *)&v91.x = v21;
			//                 v91.z = v22;
			//                 v47 = UnityEngine::Vector3::op_Multiply(&v92, &v91, v8, v46);
			//                 *(_QWORD *)&v89.x = v25;
			//                 v89.z = v26;
			//                 *(_QWORD *)&v91.x = v13;
			//                 v48 = *(_QWORD *)&v47.x;
			//                 *(float *)&v47 = v47.z;
			//                 *(_QWORD *)&v90.x = v48;
			//                 LODWORD(v90.z) = (_DWORD)v47;
			//                 v91.z = z;
			//                 v50 = UnityEngine::Vector3::op_Multiply(&v92, &v91, v10, v49);
			//                 v51 = *(_QWORD *)&v50.x;
			//                 *(float *)&v50 = v50.z;
			//                 *(_QWORD *)&v91.x = v51;
			//                 LODWORD(v91.z) = (_DWORD)v50;
			//                 v53 = UnityEngine::Vector3::op_Multiply(v93, &v91, 3.0, v52);
			//                 v54 = *(_QWORD *)&v53.x;
			//                 *(float *)&v53 = v53.z;
			//                 *(_QWORD *)&v92.x = v54;
			//                 LODWORD(v92.z) = (_DWORD)v53;
			//                 v56 = UnityEngine::Vector3::op_Addition(v93, &v89, &v90, v55);
			//                 *(_QWORD *)&v91.x = v17;
			//                 v91.z = v18;
			//                 v57 = *(_QWORD *)&v56.x;
			//                 *(float *)&v56 = v56.z;
			//                 *(_QWORD *)&v90.x = v57;
			//                 LODWORD(v90.z) = (_DWORD)v56;
			//                 v59 = UnityEngine::Vector3::op_Multiply(v93, &v91, orthographicSize, v58);
			//                 v60 = *(_QWORD *)&v59.x;
			//                 *(float *)&v59 = v59.z;
			//                 *(_QWORD *)&v91.x = v60;
			//                 LODWORD(v91.z) = (_DWORD)v59;
			//                 v62 = UnityEngine::Vector3::op_Addition(v93, &v90, &v92, v61);
			//                 v63 = *(_QWORD *)&v62.x;
			//                 *(float *)&v62 = v62.z;
			//                 *(_QWORD *)&v92.x = v63;
			//                 LODWORD(v92.z) = (_DWORD)v62;
			//                 v65 = UnityEngine::Vector3::op_Subtraction(v93, &v92, &v91, v64);
			//                 v66 = *(_QWORD *)&v65.x;
			//                 *(float *)&v65 = v65.z;
			//                 *(_QWORD *)&v92.x = v66;
			//                 LODWORD(v92.z) = (_DWORD)v65;
			//                 sub_180040FA0(result, 1LL, &v92);
			//                 *(_QWORD *)&v92.x = v21;
			//                 v92.z = v22;
			//                 v68 = UnityEngine::Vector3::op_Multiply(v93, &v92, v8, v67);
			//                 *(_QWORD *)&v90.x = v25;
			//                 v90.z = v26;
			//                 *(_QWORD *)&v92.x = v13;
			//                 v69 = *(_QWORD *)&v68.x;
			//                 *(float *)&v68 = v68.z;
			//                 *(_QWORD *)&v91.x = v69;
			//                 LODWORD(v91.z) = (_DWORD)v68;
			//                 v92.z = z;
			//                 v71 = UnityEngine::Vector3::op_Multiply(v93, &v92, v10, v70);
			//                 v72 = *(_QWORD *)&v71.x;
			//                 *(float *)&v71 = v71.z;
			//                 *(_QWORD *)&v89.x = v72;
			//                 LODWORD(v89.z) = (_DWORD)v71;
			//                 v74 = UnityEngine::Vector3::op_Addition(v93, &v90, &v91, v73);
			//                 *(_QWORD *)&v92.x = v17;
			//                 v92.z = v18;
			//                 v75 = *(_QWORD *)&v74.x;
			//                 *(float *)&v74 = v74.z;
			//                 *(_QWORD *)&v91.x = v75;
			//                 LODWORD(v91.z) = (_DWORD)v74;
			//                 v77 = UnityEngine::Vector3::op_Multiply(v93, &v92, orthographicSize, v76);
			//                 v78 = *(_QWORD *)&v77.x;
			//                 *(float *)&v77 = v77.z;
			//                 *(_QWORD *)&v92.x = v78;
			//                 LODWORD(v92.z) = (_DWORD)v77;
			//                 v80 = UnityEngine::Vector3::op_Multiply(v93, &v92, 3.0, v79);
			//                 v81 = *(_QWORD *)&v80.x;
			//                 *(float *)&v80 = v80.z;
			//                 *(_QWORD *)&v92.x = v81;
			//                 LODWORD(v92.z) = (_DWORD)v80;
			//                 v83 = UnityEngine::Vector3::op_Subtraction(v93, &v91, &v89, v82);
			//                 v84 = *(_QWORD *)&v83.x;
			//                 *(float *)&v83 = v83.z;
			//                 *(_QWORD *)&v91.x = v84;
			//                 LODWORD(v91.z) = (_DWORD)v83;
			//                 v86 = UnityEngine::Vector3::op_Addition(v93, &v91, &v92, v85);
			//                 v87 = *(_QWORD *)&v86.x;
			//                 *(float *)&v86 = v86.z;
			//                 *(_QWORD *)&v92.x = v87;
			//                 LODWORD(v92.z) = (_DWORD)v86;
			//                 sub_180040FA0(result, 2LL, &v92);
			//                 return;
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_10:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1010, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_254(
			//     (ILFixDynamicMethodWrapper_4 *)Patch,
			//     (Object *)camera,
			//     posZ,
			//     (Object *)result,
			//     0LL);
			// }
			// 
		}

		private static void _GetPerspectiveNearClipCorners(Camera camera, float posZ, Vector3[] result)
		{
			// // Void _GetPerspectiveNearClipCorners(Camera, Single, Vector3[])
			// void HG::Rendering::Runtime::HGVFXManager::_GetPerspectiveNearClipCorners(
			//         Camera *camera,
			//         float posZ,
			//         Vector3__Array *result,
			//         MethodInfo *method)
			// {
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   __int64 v10; // r8
			//   __int64 v11; // r9
			//   float v12; // xmm0_4
			//   float v13; // xmm7_4
			//   float v14; // xmm9_4
			//   Transform *transform; // rax
			//   Vector3 *right; // rax
			//   __int64 v17; // xmm13_8
			//   float z; // r15d
			//   Transform *v19; // rax
			//   Vector3 *up; // rax
			//   __int64 v21; // xmm12_8
			//   float v22; // r14d
			//   Transform *v23; // rax
			//   Vector3 *forward; // rax
			//   __int64 v25; // xmm11_8
			//   float v26; // esi
			//   Transform *v27; // rax
			//   Vector3 *position; // rax
			//   __int64 v29; // xmm14_8
			//   float v30; // ebx
			//   MethodInfo *v31; // r9
			//   Vector3 *v32; // rax
			//   __int64 v33; // xmm3_8
			//   MethodInfo *v34; // r9
			//   Vector3 *v35; // rax
			//   __int64 v36; // xmm3_8
			//   MethodInfo *v37; // r9
			//   Vector3 *v38; // rax
			//   __int64 v39; // xmm3_8
			//   MethodInfo *v40; // r9
			//   Vector3 *v41; // rax
			//   __int64 v42; // xmm3_8
			//   MethodInfo *v43; // r9
			//   Vector3 *v44; // rax
			//   __int64 v45; // xmm3_8
			//   MethodInfo *v46; // r9
			//   Vector3 *v47; // rax
			//   __int64 v48; // xmm3_8
			//   MethodInfo *v49; // r9
			//   Vector3 *v50; // rax
			//   __int64 v51; // xmm3_8
			//   MethodInfo *v52; // r9
			//   Vector3 *v53; // rax
			//   __int64 v54; // xmm0_8
			//   float v55; // eax
			//   MethodInfo *v56; // r9
			//   Vector3 *v57; // rax
			//   __int64 v58; // xmm3_8
			//   MethodInfo *v59; // r9
			//   Vector3 *v60; // rax
			//   __int64 v61; // xmm3_8
			//   MethodInfo *v62; // r9
			//   Vector3 *v63; // rax
			//   __int64 v64; // xmm3_8
			//   MethodInfo *v65; // r9
			//   Vector3 *v66; // rax
			//   __int64 v67; // xmm3_8
			//   MethodInfo *v68; // r9
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
			//   __int64 v79; // xmm3_8
			//   MethodInfo *v80; // r9
			//   Vector3 *v81; // rax
			//   __int64 v82; // xmm3_8
			//   MethodInfo *v83; // r9
			//   Vector3 *v84; // rax
			//   __int64 v85; // xmm3_8
			//   MethodInfo *v86; // r9
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
			//   __int64 v97; // xmm3_8
			//   MethodInfo *v98; // r9
			//   Vector3 *v99; // rax
			//   __int64 v100; // xmm3_8
			//   MethodInfo *v101; // r9
			//   Vector3 *v102; // rax
			//   __int64 v103; // xmm3_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v105; // [rsp+38h] [rbp-89h] BYREF
			//   Vector3 v106; // [rsp+48h] [rbp-79h] BYREF
			//   Vector3 v107; // [rsp+58h] [rbp-69h] BYREF
			//   Vector3 v108; // [rsp+68h] [rbp-59h] BYREF
			//   Vector3 v109[12]; // [rsp+78h] [rbp-49h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1011, 0LL) )
			//   {
			//     if ( camera )
			//     {
			//       UnityEngine::Camera::get_fieldOfView(camera, 0LL);
			//       v12 = sub_1802ED290(v9, v8, v10, v11);
			//       v13 = (float)(v12 * posZ) + (float)(v12 * posZ);
			//       v14 = UnityEngine::Camera::get_aspect(camera, 0LL) * v13;
			//       transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
			//       if ( transform )
			//       {
			//         right = UnityEngine::Transform::get_right(&v108, transform, 0LL);
			//         v17 = *(_QWORD *)&right.x;
			//         z = right.z;
			//         v19 = UnityEngine::Component::get_transform((Component *)camera, 0LL);
			//         if ( v19 )
			//         {
			//           up = UnityEngine::Transform::get_up(&v108, v19, 0LL);
			//           v21 = *(_QWORD *)&up.x;
			//           v22 = up.z;
			//           v23 = UnityEngine::Component::get_transform((Component *)camera, 0LL);
			//           if ( v23 )
			//           {
			//             forward = UnityEngine::Transform::get_forward(&v108, v23, 0LL);
			//             v25 = *(_QWORD *)&forward.x;
			//             v26 = forward.z;
			//             v27 = UnityEngine::Component::get_transform((Component *)camera, 0LL);
			//             if ( v27 )
			//             {
			//               position = UnityEngine::Transform::get_position(&v108, v27, 0LL);
			//               *(_QWORD *)&v105.x = v25;
			//               v105.z = v26;
			//               v29 = *(_QWORD *)&position.x;
			//               v30 = position.z;
			//               v32 = UnityEngine::Vector3::op_Multiply(&v107, &v105, posZ, v31);
			//               *(_QWORD *)&v105.x = v17;
			//               v105.z = z;
			//               v33 = *(_QWORD *)&v32.x;
			//               *(float *)&v32 = v32.z;
			//               *(_QWORD *)&v106.x = v33;
			//               LODWORD(v106.z) = (_DWORD)v32;
			//               *(_QWORD *)&v107.x = v29;
			//               v107.z = v30;
			//               v35 = UnityEngine::Vector3::op_Multiply(&v108, &v105, v14, v34);
			//               v36 = *(_QWORD *)&v35.x;
			//               *(float *)&v35 = v35.z;
			//               *(_QWORD *)&v105.x = v36;
			//               LODWORD(v105.z) = (_DWORD)v35;
			//               v38 = UnityEngine::Vector3::op_Multiply(&v108, &v105, 0.5, v37);
			//               v39 = *(_QWORD *)&v38.x;
			//               *(float *)&v38 = v38.z;
			//               *(_QWORD *)&v105.x = v39;
			//               LODWORD(v105.z) = (_DWORD)v38;
			//               v41 = UnityEngine::Vector3::op_Addition(&v108, &v107, &v106, v40);
			//               *(_QWORD *)&v107.x = v21;
			//               v107.z = v22;
			//               v42 = *(_QWORD *)&v41.x;
			//               *(float *)&v41 = v41.z;
			//               *(_QWORD *)&v106.x = v42;
			//               LODWORD(v106.z) = (_DWORD)v41;
			//               v44 = UnityEngine::Vector3::op_Multiply(&v108, &v107, v13, v43);
			//               v45 = *(_QWORD *)&v44.x;
			//               *(float *)&v44 = v44.z;
			//               *(_QWORD *)&v107.x = v45;
			//               LODWORD(v107.z) = (_DWORD)v44;
			//               v47 = UnityEngine::Vector3::op_Multiply(&v108, &v107, 0.5, v46);
			//               v48 = *(_QWORD *)&v47.x;
			//               *(float *)&v47 = v47.z;
			//               *(_QWORD *)&v107.x = v48;
			//               LODWORD(v107.z) = (_DWORD)v47;
			//               v50 = UnityEngine::Vector3::op_Subtraction(&v108, &v106, &v105, v49);
			//               v51 = *(_QWORD *)&v50.x;
			//               *(float *)&v50 = v50.z;
			//               *(_QWORD *)&v106.x = v51;
			//               LODWORD(v106.z) = (_DWORD)v50;
			//               v53 = UnityEngine::Vector3::op_Subtraction(&v108, &v106, &v107, v52);
			//               if ( result )
			//               {
			//                 v54 = *(_QWORD *)&v53.x;
			//                 v55 = v53.z;
			//                 *(_QWORD *)&v107.x = v54;
			//                 v107.z = v55;
			//                 sub_180040FA0(result, 0LL, &v107);
			//                 *(_QWORD *)&v107.x = v25;
			//                 v107.z = v26;
			//                 v57 = UnityEngine::Vector3::op_Multiply(&v108, &v107, posZ, v56);
			//                 *(_QWORD *)&v105.x = v29;
			//                 v105.z = v30;
			//                 *(_QWORD *)&v107.x = v17;
			//                 v58 = *(_QWORD *)&v57.x;
			//                 *(float *)&v57 = v57.z;
			//                 *(_QWORD *)&v106.x = v58;
			//                 LODWORD(v106.z) = (_DWORD)v57;
			//                 v107.z = z;
			//                 v60 = UnityEngine::Vector3::op_Multiply(&v108, &v107, v14, v59);
			//                 v61 = *(_QWORD *)&v60.x;
			//                 *(float *)&v60 = v60.z;
			//                 *(_QWORD *)&v107.x = v61;
			//                 LODWORD(v107.z) = (_DWORD)v60;
			//                 v63 = UnityEngine::Vector3::op_Multiply(v109, &v107, 1.5, v62);
			//                 v64 = *(_QWORD *)&v63.x;
			//                 *(float *)&v63 = v63.z;
			//                 *(_QWORD *)&v108.x = v64;
			//                 LODWORD(v108.z) = (_DWORD)v63;
			//                 v66 = UnityEngine::Vector3::op_Addition(v109, &v105, &v106, v65);
			//                 *(_QWORD *)&v107.x = v21;
			//                 v107.z = v22;
			//                 v67 = *(_QWORD *)&v66.x;
			//                 *(float *)&v66 = v66.z;
			//                 *(_QWORD *)&v106.x = v67;
			//                 LODWORD(v106.z) = (_DWORD)v66;
			//                 v69 = UnityEngine::Vector3::op_Multiply(v109, &v107, v13, v68);
			//                 v70 = *(_QWORD *)&v69.x;
			//                 *(float *)&v69 = v69.z;
			//                 *(_QWORD *)&v107.x = v70;
			//                 LODWORD(v107.z) = (_DWORD)v69;
			//                 v72 = UnityEngine::Vector3::op_Multiply(v109, &v107, 0.5, v71);
			//                 v73 = *(_QWORD *)&v72.x;
			//                 *(float *)&v72 = v72.z;
			//                 *(_QWORD *)&v107.x = v73;
			//                 LODWORD(v107.z) = (_DWORD)v72;
			//                 v75 = UnityEngine::Vector3::op_Addition(v109, &v106, &v108, v74);
			//                 v76 = *(_QWORD *)&v75.x;
			//                 *(float *)&v75 = v75.z;
			//                 *(_QWORD *)&v108.x = v76;
			//                 LODWORD(v108.z) = (_DWORD)v75;
			//                 v78 = UnityEngine::Vector3::op_Subtraction(v109, &v108, &v107, v77);
			//                 v79 = *(_QWORD *)&v78.x;
			//                 *(float *)&v78 = v78.z;
			//                 *(_QWORD *)&v108.x = v79;
			//                 LODWORD(v108.z) = (_DWORD)v78;
			//                 sub_180040FA0(result, 1LL, &v108);
			//                 *(_QWORD *)&v108.x = v25;
			//                 v108.z = v26;
			//                 v81 = UnityEngine::Vector3::op_Multiply(v109, &v108, posZ, v80);
			//                 *(_QWORD *)&v106.x = v29;
			//                 v106.z = v30;
			//                 *(_QWORD *)&v108.x = v17;
			//                 v82 = *(_QWORD *)&v81.x;
			//                 *(float *)&v81 = v81.z;
			//                 *(_QWORD *)&v107.x = v82;
			//                 LODWORD(v107.z) = (_DWORD)v81;
			//                 v108.z = z;
			//                 v84 = UnityEngine::Vector3::op_Multiply(v109, &v108, v14, v83);
			//                 v85 = *(_QWORD *)&v84.x;
			//                 *(float *)&v84 = v84.z;
			//                 *(_QWORD *)&v108.x = v85;
			//                 LODWORD(v108.z) = (_DWORD)v84;
			//                 v87 = UnityEngine::Vector3::op_Multiply(v109, &v108, 0.5, v86);
			//                 v88 = *(_QWORD *)&v87.x;
			//                 *(float *)&v87 = v87.z;
			//                 *(_QWORD *)&v105.x = v88;
			//                 LODWORD(v105.z) = (_DWORD)v87;
			//                 v90 = UnityEngine::Vector3::op_Addition(v109, &v106, &v107, v89);
			//                 *(_QWORD *)&v108.x = v21;
			//                 v108.z = v22;
			//                 v91 = *(_QWORD *)&v90.x;
			//                 *(float *)&v90 = v90.z;
			//                 *(_QWORD *)&v107.x = v91;
			//                 LODWORD(v107.z) = (_DWORD)v90;
			//                 v93 = UnityEngine::Vector3::op_Multiply(v109, &v108, v13, v92);
			//                 v94 = *(_QWORD *)&v93.x;
			//                 *(float *)&v93 = v93.z;
			//                 *(_QWORD *)&v108.x = v94;
			//                 LODWORD(v108.z) = (_DWORD)v93;
			//                 v96 = UnityEngine::Vector3::op_Multiply(v109, &v108, 1.5, v95);
			//                 v97 = *(_QWORD *)&v96.x;
			//                 *(float *)&v96 = v96.z;
			//                 *(_QWORD *)&v108.x = v97;
			//                 LODWORD(v108.z) = (_DWORD)v96;
			//                 v99 = UnityEngine::Vector3::op_Subtraction(v109, &v107, &v105, v98);
			//                 v100 = *(_QWORD *)&v99.x;
			//                 *(float *)&v99 = v99.z;
			//                 *(_QWORD *)&v107.x = v100;
			//                 LODWORD(v107.z) = (_DWORD)v99;
			//                 v102 = UnityEngine::Vector3::op_Addition(v109, &v107, &v108, v101);
			//                 v103 = *(_QWORD *)&v102.x;
			//                 *(float *)&v102 = v102.z;
			//                 *(_QWORD *)&v108.x = v103;
			//                 LODWORD(v108.z) = (_DWORD)v102;
			//                 sub_180040FA0(result, 2LL, &v108);
			//                 return;
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_10:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1011, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_254(
			//     (ILFixDynamicMethodWrapper_4 *)Patch,
			//     (Object *)camera,
			//     posZ,
			//     (Object *)result,
			//     0LL);
			// }
			// 
		}

		public static void CalculateScreenMaterialMeshVertex(Camera camera, float posZ, Vector3[] result)
		{
			// // Void CalculateScreenMaterialMeshVertex(Camera, Single, Vector3[])
			// void HG::Rendering::Runtime::HGVFXManager::CalculateScreenMaterialMeshVertex(
			//         Camera *camera,
			//         float posZ,
			//         Vector3__Array *result,
			//         MethodInfo *method)
			// {
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1009, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1009, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_254(
			//         (ILFixDynamicMethodWrapper_4 *)Patch,
			//         (Object *)camera,
			//         posZ,
			//         (Object *)result,
			//         0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v7, v6);
			//   }
			//   if ( !camera )
			//     goto LABEL_7;
			//   if ( UnityEngine::Camera::get_orthographic(camera, 0LL) )
			//     HG::Rendering::Runtime::HGVFXManager::_GetOrthographicNearClipCorners(camera, posZ, result, 0LL);
			//   else
			//     HG::Rendering::Runtime::HGVFXManager::_GetPerspectiveNearClipCorners(camera, posZ, result, 0LL);
			// }
			// 
		}

		private List<VFXSceneDark> m_sceneDarks;

		private float m_lastUpdateTime;

		private const float SCENE_DARK_VALUE_CHANGE_THRESHOLD = 0.01f;

		private Vector3 m_currentSceneDarkValue;

		private float m_currentSceneSaturation;

		private bool m_currentNeedStopAutoExposure;

		private Vector3 m_lastSceneDarkValue;

		private float m_lastSceneSaturation;

		private bool m_lastNeedStopAutoExposure;

		private Dictionary<int, float> m_savedCameraAutoExposure;

		private Vector3 m_playerPosition;

		private Vector4 m_playerHeights;

		private bool m_enabled;

		private Vector2 m_anchorPosition;

		private float m_anchorRadius;

		private float m_anchorBrightIntensity;

		private bool m_anchorBrightFlag;

		private Material m_vfxSceneColorAdjustmentMaterial;
	}
}
