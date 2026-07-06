using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[ExecuteAlways]
	[AddComponentMenu("HG/Effect/VFXBackFaceHide(背向隐藏)")]
	public class VFXBackFaceHide : VFXPlayableMonoBase
	{
		public VFXBackFaceHide()
		{
		}

		private void Awake()
		{
			// // Void Awake()
			// void HG::Rendering::Runtime::VFXBackFaceHide::Awake(VFXBackFaceHide *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !byte_18D8ED9A9 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Component::GetComponentsInChildren<UnityEngine::Renderer>);
			//     byte_18D8ED9A9 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2149, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2149, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     UnityEngine::Component::GetComponentsInChildren<System::Object>(
			//       (Component *)this,
			//       (List_1_System_Object_ *)this.fields.m_renderers,
			//       MethodInfo::UnityEngine::Component::GetComponentsInChildren<UnityEngine::Renderer>);
			//   }
			// }
			// 
		}

		protected override void OnPlay()
		{
			// // Void OnPlay()
			// void HG::Rendering::Runtime::VFXBackFaceHide::OnPlay(VFXBackFaceHide *this, MethodInfo *method)
			// {
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v6; // rbx
			//   __int64 v7; // rdx
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v8; // rax
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v9; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED9AA )
			//   {
			//     sub_18003C530(&TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Component::GetComponentsInChildren<UnityEngine::Renderer>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::VFXBackFaceHide::OnBeginCameraRendering);
			//     byte_18D8ED9AA = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2150, 0LL) )
			//   {
			//     v3 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_180004920(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
			//     v6 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v3;
			//     if ( v3 )
			//     {
			//       System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
			//         v3,
			//         (Object *)this,
			//         MethodInfo::HG::Rendering::Runtime::VFXBackFaceHide::OnBeginCameraRendering,
			//         0LL);
			//       if ( !TypeInfo::UnityEngine::Rendering::RenderPipelineManager._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::RenderPipelineManager, v7);
			//       UnityEngine::Rendering::RenderPipelineManager::remove_beginCameraRendering(v6, 0LL);
			//       v8 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_180004920(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
			//       v9 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v8;
			//       if ( v8 )
			//       {
			//         System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
			//           v8,
			//           (Object *)this,
			//           MethodInfo::HG::Rendering::Runtime::VFXBackFaceHide::OnBeginCameraRendering,
			//           0LL);
			//         UnityEngine::Rendering::RenderPipelineManager::add_beginCameraRendering(v9, 0LL);
			//         UnityEngine::Component::GetComponentsInChildren<System::Object>(
			//           (Component *)this,
			//           (List_1_System_Object_ *)this.fields.m_renderers,
			//           MethodInfo::UnityEngine::Component::GetComponentsInChildren<UnityEngine::Renderer>);
			//         return;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2150, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		protected override void OnStop()
		{
			// // Void OnStop()
			// void HG::Rendering::Runtime::VFXBackFaceHide::OnStop(VFXBackFaceHide *this, MethodInfo *method)
			// {
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v6; // rbx
			//   __int64 v7; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED9AB )
			//   {
			//     sub_18003C530(&TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::VFXBackFaceHide::OnBeginCameraRendering);
			//     byte_18D8ED9AB = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2152, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2152, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v5, v4);
			//   }
			//   v3 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_180004920(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
			//   v6 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v3;
			//   if ( !v3 )
			//     goto LABEL_8;
			//   System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
			//     v3,
			//     (Object *)this,
			//     MethodInfo::HG::Rendering::Runtime::VFXBackFaceHide::OnBeginCameraRendering,
			//     0LL);
			//   if ( !TypeInfo::UnityEngine::Rendering::RenderPipelineManager._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::RenderPipelineManager, v7);
			//   UnityEngine::Rendering::RenderPipelineManager::remove_beginCameraRendering(v6, 0LL);
			// }
			// 
		}

		private void OnBeginCameraRendering(ScriptableRenderContext context, Camera targetCamera)
		{
			// // Void OnBeginCameraRendering(ScriptableRenderContext, Camera)
			// void HG::Rendering::Runtime::VFXBackFaceHide::OnBeginCameraRendering(
			//         VFXBackFaceHide *this,
			//         ScriptableRenderContext context,
			//         Camera *targetCamera,
			//         MethodInfo *method)
			// {
			//   List_1_System_Object_ *items; // rcx
			//   __int64 v8; // rdx
			//   __int64 (__fastcall *v9)(Camera *, __int64, Camera *, MethodInfo *); // rax
			//   __int64 v10; // rbx
			//   void (__fastcall *v11)(__int64, Quaternion *); // rax
			//   __int64 (__fastcall *v12)(VFXBackFaceHide *); // rax
			//   __int64 v13; // rbx
			//   void (__fastcall *v14)(__int64, Vector3 *); // rax
			//   MethodInfo *v15; // r9
			//   Vector3 *v16; // rax
			//   __int64 v17; // rdx
			//   __int64 v18; // r8
			//   float z; // edi
			//   struct Math__Class *v20; // rcx
			//   __m128 y_low; // xmm2
			//   __m128d v22; // xmm3
			//   double v23; // xmm0_8
			//   float v24; // xmm0_4
			//   __m128 x_low; // xmm6
			//   __m128 v26; // xmm7
			//   float v27; // xmm8_4
			//   __int64 (__fastcall *v28)(VFXBackFaceHide *); // rax
			//   __int64 v29; // rbx
			//   void (__fastcall *v30)(__int64, Quaternion *); // rax
			//   Vector3 *v31; // rax
			//   __int64 v32; // xmm0_8
			//   MethodInfo *v33; // r8
			//   Beyond::JobMathf *v34; // rcx
			//   struct VFXBackFaceHide__Class *v35; // rax
			//   MaterialPropertyBlock *m_materialPropertyBlock; // rbx
			//   unsigned int s_TintColorAlpha; // edi
			//   void (__fastcall *v38)(MaterialPropertyBlock *, _QWORD); // rax
			//   int32_t v39; // edi
			//   List_1_UnityEngine_Renderer_ *m_renderers; // rax
			//   __int64 v41; // rbx
			//   void (__fastcall *v42)(__int64, MaterialPropertyBlock *); // rax
			//   MaterialPropertyBlock *v43; // r14
			//   MaterialPropertyBlock *v44; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v45; // rdx
			//   PassConstructorID__Enum__Array *v46; // r8
			//   HGCamera *v47; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v49; // rax
			//   __int64 v50; // rax
			//   __int64 v51; // rax
			//   __int64 v52; // rax
			//   __int64 v53; // rax
			//   __int64 v54; // rax
			//   __int64 v55; // rax
			//   __int64 v56; // rax
			//   MethodInfo *methoda; // [rsp+20h] [rbp-39h]
			//   MethodInfo *v58; // [rsp+28h] [rbp-31h]
			//   Vector3 v59; // [rsp+30h] [rbp-29h] BYREF
			//   Quaternion v60; // [rsp+40h] [rbp-19h] BYREF
			//   Vector3 v61; // [rsp+50h] [rbp-9h] BYREF
			//   Quaternion v62; // [rsp+60h] [rbp+7h] BYREF
			// 
			//   if ( !byte_18D8ED9AC )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Renderer>::RemoveAt);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Renderer>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Renderer>::get_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::MaterialPropertyBlock);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXBackFaceHide);
			//     byte_18D8ED9AC = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   items = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, context.m_Ptr);
			//     items = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v8 = **(_QWORD **)&items[4].fields._size;
			//   if ( !v8 )
			//     goto LABEL_67;
			//   if ( *(int *)(v8 + 24) <= 2151 )
			//     goto LABEL_106;
			//   if ( !items[5].fields._size )
			//   {
			//     il2cpp_runtime_class_init_0(items, v8);
			//     items = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v8 = **(_QWORD **)&items[4].fields._size;
			//   if ( !v8 )
			//     goto LABEL_67;
			//   if ( *(_DWORD *)(v8 + 24) <= 0x867u )
			// LABEL_71:
			//     sub_180070270(items, v8);
			//   if ( !*(_QWORD *)(v8 + 17240) )
			//   {
			// LABEL_106:
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//     if ( !byte_18D8F4EFA )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EFA = 1;
			//     }
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//     if ( !byte_18D8F4EAF )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EAF = 1;
			//     }
			//     if ( !targetCamera )
			//       return;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//     if ( !targetCamera.fields._._._.m_CachedPtr )
			//       return;
			//     v9 = (__int64 (__fastcall *)(Camera *, __int64, Camera *, MethodInfo *))qword_18D8F4D40;
			//     if ( !qword_18D8F4D40 )
			//     {
			//       v9 = (__int64 (__fastcall *)(Camera *, __int64, Camera *, MethodInfo *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//       if ( !v9 )
			//       {
			//         v49 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//         sub_18000F750(v49, 0LL);
			//       }
			//       qword_18D8F4D40 = (__int64)v9;
			//     }
			//     v10 = v9(targetCamera, v8, targetCamera, method);
			//     if ( v10 )
			//     {
			//       *(_QWORD *)&v60.x = 0LL;
			//       v60.z = 0.0;
			//       v11 = (void (__fastcall *)(__int64, Quaternion *))qword_18D8F52E0;
			//       if ( !qword_18D8F52E0 )
			//       {
			//         v11 = (void (__fastcall *)(__int64, Quaternion *))il2cpp_resolve_icall_0(
			//                                                             "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//         if ( !v11 )
			//         {
			//           v50 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//           sub_18000F750(v50, 0LL);
			//         }
			//         qword_18D8F52E0 = (__int64)v11;
			//       }
			//       v11(v10, &v60);
			//       v12 = (__int64 (__fastcall *)(VFXBackFaceHide *))qword_18D8F4D40;
			//       if ( !qword_18D8F4D40 )
			//       {
			//         v12 = (__int64 (__fastcall *)(VFXBackFaceHide *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//         if ( !v12 )
			//         {
			//           v51 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//           sub_18000F750(v51, 0LL);
			//         }
			//         qword_18D8F4D40 = (__int64)v12;
			//       }
			//       v13 = v12(this);
			//       if ( v13 )
			//       {
			//         *(_QWORD *)&v59.x = 0LL;
			//         v59.z = 0.0;
			//         v14 = (void (__fastcall *)(__int64, Vector3 *))qword_18D8F52E0;
			//         if ( !qword_18D8F52E0 )
			//         {
			//           v14 = (void (__fastcall *)(__int64, Vector3 *))il2cpp_resolve_icall_0(
			//                                                            "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//           if ( !v14 )
			//           {
			//             v52 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//             sub_18000F750(v52, 0LL);
			//           }
			//           qword_18D8F52E0 = (__int64)v14;
			//         }
			//         v14(v13, &v59);
			//         v61 = v59;
			//         *(_QWORD *)&v59.x = *(_QWORD *)&v60.x;
			//         v59.z = v60.z;
			//         v16 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v62, &v59, &v61, v15);
			//         z = v16.z;
			//         *(_QWORD *)&v60.x = *(_QWORD *)&v16.x;
			//         *(_QWORD *)&v61.x = *(_QWORD *)&v60.x;
			//         if ( !byte_18D8E3A70 )
			//         {
			//           sub_18003C530(&TypeInfo::System::Math);
			//           byte_18D8E3A70 = 1;
			//         }
			//         v20 = TypeInfo::System::Math;
			//         if ( !TypeInfo::System::Math._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::System::Math, v17);
			//         y_low = (__m128)LODWORD(v61.y);
			//         y_low.m128_f32[0] = (float)((float)(y_low.m128_f32[0] * y_low.m128_f32[0]) + (float)(v61.x * v61.x))
			//                           + (float)(z * z);
			//         v22 = _mm_cvtps_pd(y_low);
			//         if ( v22.m128d_f64[0] < 0.0 )
			//           v23 = sub_1801C22C0(v20, v17, v18);
			//         else
			//           *(_QWORD *)&v23 = *(_OWORD *)&_mm_sqrt_pd(v22);
			//         v24 = v23;
			//         if ( v24 <= 0.0000099999997 )
			//         {
			//           x_low = 0LL;
			//           v26 = 0LL;
			//           v27 = 0.0;
			//         }
			//         else
			//         {
			//           x_low = (__m128)LODWORD(v60.x);
			//           v26 = (__m128)LODWORD(v60.y);
			//           x_low.m128_f32[0] = v60.x / v24;
			//           v26.m128_f32[0] = v60.y / v24;
			//           v27 = z / v24;
			//         }
			//         v28 = (__int64 (__fastcall *)(VFXBackFaceHide *))qword_18D8F4D40;
			//         if ( !qword_18D8F4D40 )
			//         {
			//           v28 = (__int64 (__fastcall *)(VFXBackFaceHide *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//           if ( !v28 )
			//           {
			//             v53 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//             sub_18000F750(v53, 0LL);
			//           }
			//           qword_18D8F4D40 = (__int64)v28;
			//         }
			//         v29 = v28(this);
			//         if ( v29 )
			//         {
			//           v30 = (void (__fastcall *)(__int64, Quaternion *))qword_18D8F5300;
			//           v62 = 0LL;
			//           if ( !qword_18D8F5300 )
			//           {
			//             v30 = (void (__fastcall *)(__int64, Quaternion *))il2cpp_resolve_icall_0(
			//                                                                 "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
			//             if ( !v30 )
			//             {
			//               v54 = sub_1802DBBE8("UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
			//               sub_18000F750(v54, 0LL);
			//             }
			//             qword_18D8F5300 = (__int64)v30;
			//           }
			//           v30(v29, &v62);
			//           v61.z = 1.0;
			//           *(_QWORD *)&v61.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//           v60 = v62;
			//           v31 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v62, &v60, &v61, 0LL);
			//           v32 = *(_QWORD *)&v31.x;
			//           *(float *)&v31 = v31.z;
			//           *(_QWORD *)&v61.x = v32;
			//           LODWORD(v61.z) = (_DWORD)v31;
			//           *(_QWORD *)&v60.x = _mm_unpacklo_ps(x_low, v26).m128_u64[0];
			//           v60.z = v27;
			//           UnityEngine::Vector3::Dot((Vector3 *)&v60, &v61, v33);
			//           Beyond::JobMathf::Clamp01(v34);
			//           if ( !this.fields.m_materialPropertyBlock )
			//           {
			//             v44 = (MaterialPropertyBlock *)sub_180004920(TypeInfo::UnityEngine::MaterialPropertyBlock);
			//             if ( !v44 )
			//               goto LABEL_67;
			//             v44.fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
			//             this.fields.m_materialPropertyBlock = v44;
			//             sub_1800054D0((HGRenderPathScene *)&this.fields.m_materialPropertyBlock, v45, v46, v47, methoda, v58);
			//           }
			//           v35 = TypeInfo::HG::Rendering::Runtime::VFXBackFaceHide;
			//           m_materialPropertyBlock = this.fields.m_materialPropertyBlock;
			//           if ( !TypeInfo::HG::Rendering::Runtime::VFXBackFaceHide._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXBackFaceHide, v8);
			//             v35 = TypeInfo::HG::Rendering::Runtime::VFXBackFaceHide;
			//           }
			//           s_TintColorAlpha = v35.static_fields.s_TintColorAlpha;
			//           if ( m_materialPropertyBlock )
			//           {
			//             v38 = (void (__fastcall *)(MaterialPropertyBlock *, _QWORD))qword_18D8F4538;
			//             if ( !qword_18D8F4538 )
			//             {
			//               v38 = (void (__fastcall *)(MaterialPropertyBlock *, _QWORD))il2cpp_resolve_icall_0(
			//                                                                             "UnityEngine.MaterialPropertyBlock::SetFloatI"
			//                                                                             "mpl(System.Int32,System.Single)");
			//               if ( !v38 )
			//               {
			//                 v55 = sub_1802DBBE8("UnityEngine.MaterialPropertyBlock::SetFloatImpl(System.Int32,System.Single)");
			//                 sub_18000F750(v55, 0LL);
			//               }
			//               qword_18D8F4538 = (__int64)v38;
			//             }
			//             v38(m_materialPropertyBlock, s_TintColorAlpha);
			//             v39 = 0;
			//             while ( 1 )
			//             {
			//               m_renderers = this.fields.m_renderers;
			//               if ( !m_renderers )
			//                 break;
			//               if ( v39 >= m_renderers.fields._size )
			//                 return;
			//               if ( (unsigned int)v39 >= m_renderers.fields._size )
			//                 System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//               items = (List_1_System_Object_ *)m_renderers.fields._items;
			//               if ( !items )
			//                 break;
			//               if ( (unsigned int)v39 >= items.fields._size )
			//                 goto LABEL_71;
			//               v41 = *((_QWORD *)&items.fields._syncRoot + v39);
			//               if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                 il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//               if ( !byte_18D8F4EAE )
			//               {
			//                 sub_18003C530(&TypeInfo::UnityEngine::Object);
			//                 byte_18D8F4EAE = 1;
			//               }
			//               if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                 il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//               if ( !byte_18D8F4EAF )
			//               {
			//                 sub_18003C530(&TypeInfo::UnityEngine::Object);
			//                 byte_18D8F4EAF = 1;
			//               }
			//               if ( !v41 )
			//                 goto LABEL_100;
			//               if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                 il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//               if ( *(_QWORD *)(v41 + 16) )
			//               {
			//                 v42 = (void (__fastcall *)(__int64, MaterialPropertyBlock *))qword_18D8F45B0;
			//                 ++v39;
			//                 v43 = this.fields.m_materialPropertyBlock;
			//                 if ( !qword_18D8F45B0 )
			//                 {
			//                   v42 = (void (__fastcall *)(__int64, MaterialPropertyBlock *))il2cpp_resolve_icall_0(
			//                                                                                  "UnityEngine.Renderer::Internal_SetPrope"
			//                                                                                  "rtyBlock(UnityEngine.MaterialPropertyBlock)");
			//                   if ( !v42 )
			//                   {
			//                     v56 = sub_1802DBBE8("UnityEngine.Renderer::Internal_SetPropertyBlock(UnityEngine.MaterialPropertyBlock)");
			//                     sub_18000F750(v56, 0LL);
			//                   }
			//                   qword_18D8F45B0 = (__int64)v42;
			//                 }
			//                 v42(v41, v43);
			//               }
			//               else
			//               {
			// LABEL_100:
			//                 items = (List_1_System_Object_ *)this.fields.m_renderers;
			//                 if ( !items )
			//                   break;
			//                 System::Collections::Generic::List<System::Object>::RemoveAt(
			//                   items,
			//                   v39,
			//                   MethodInfo::System::Collections::Generic::List<UnityEngine::Renderer>::RemoveAt);
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_67:
			//     sub_180B536AC(items, v8);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2151, 0LL);
			//   if ( !Patch )
			//     goto LABEL_67;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_216(Patch, (Object *)this, context, (Object *)targetCamera, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_OnPlay()
		{
			// // Void <>iFixBaseProxy_OnPlay()
			// void HG::Rendering::Runtime::VFXSceneDark::__iFixBaseProxy_OnPlay(VFXSceneDark *this, MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VFXPlayableMonoBase::OnPlay((VFXPlayableMonoBase *)this, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_OnStop()
		{
			// // Void <>iFixBaseProxy_OnStop()
			// void HG::Rendering::Runtime::VFXSceneDark::__iFixBaseProxy_OnStop(VFXSceneDark *this, MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VFXPlayableMonoBase::OnStop((VFXPlayableMonoBase *)this, 0LL);
			// }
			// 
		}

		private List<Renderer> m_renderers;

		public bool showDirGizmos;

		[Range(0.01f, 1f)]
		public float fadeRange;

		private MaterialPropertyBlock m_materialPropertyBlock;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static int s_TintColorAlpha;
	}
}
