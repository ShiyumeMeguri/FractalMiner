using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXBackFaceHide(\u80CC\u5411\u9690\u85CF)")]
	[ExecuteAlways]
	public class VFXBackFaceHide : VFXPlayableMonoBase // TypeDefIndex: 37971
	{
		// Fields
		private List<Renderer> m_renderers; // 0x20
		public bool showDirGizmos; // 0x28
		[Range(0.01f, 1f)]
		public float fadeRange; // 0x2C
		private MaterialPropertyBlock m_materialPropertyBlock; // 0x30
		private static int s_TintColorAlpha; // 0x00
	
		// Constructors
		public VFXBackFaceHide() {} // 0x00000001842EDF30-0x00000001842EDF90
		// VFXBackFaceHide()
		void HG::Rendering::Runtime::VFXBackFaceHide::VFXBackFaceHide(VFXBackFaceHide *this, MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  List_1_UnityEngine_Renderer_ *v6; // rdi
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+20h] [rbp-8h]
		
		  v3 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<UnityEngine::Renderer>);
		  v6 = (List_1_UnityEngine_Renderer_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v3,
		    MethodInfo::System::Collections::Generic::List<UnityEngine::Renderer>::List);
		  this->fields.m_renderers = v6;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_renderers, v7, v8, v9, v10);
		  this->fields.fadeRange = 1.0;
		  PaintIn3D::P3dButtonClearAll::P3dButtonClearAll((P3dButtonClearAll *)this, 0LL);
		}
		
		static VFXBackFaceHide() {} // 0x0000000184D80B70-0x0000000184D80BA0
		// VFXBackFaceHide()
		void HG::Rendering::Runtime::VFXBackFaceHide::cctor(MethodInfo *method)
		{
		  TypeInfo::HG::Rendering::Runtime::VFXBackFaceHide->static_fields->s_TintColorAlpha = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_TintColorAlpha",
		                                                                                         0LL);
		}
		
	
		// Methods
		private void Awake() {} // 0x00000001849E2CB0-0x00000001849E2CF0
		// Void Awake()
		void HG::Rendering::Runtime::VFXBackFaceHide::Awake(VFXBackFaceHide *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2592, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2592, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    UnityEngine::Component::GetComponentsInChildren<System::Object>(
		      (Component *)this,
		      (List_1_System_Object_ *)this->fields.m_renderers,
		      MethodInfo::UnityEngine::Component::GetComponentsInChildren<UnityEngine::Renderer>);
		  }
		}
		
		protected override void OnPlay() {} // 0x0000000183523220-0x00000001835232F0
		// Void OnPlay()
		void HG::Rendering::Runtime::VFXBackFaceHide::OnPlay(VFXBackFaceHide *this, MethodInfo *method)
		{
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v6; // rbx
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v7; // rax
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v8; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2593, 0LL) )
		  {
		    v3 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_1800368D0(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
		    v6 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v3;
		    if ( v3 )
		    {
		      System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
		        v3,
		        (Object *)this,
		        MethodInfo::HG::Rendering::Runtime::VFXBackFaceHide::OnBeginCameraRendering,
		        0LL);
		      if ( !TypeInfo::UnityEngine::Rendering::RenderPipelineManager->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
		      UnityEngine::Rendering::RenderPipelineManager::remove_beginCameraRendering(v6, 0LL);
		      v7 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_1800368D0(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
		      v8 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v7;
		      if ( v7 )
		      {
		        System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
		          v7,
		          (Object *)this,
		          MethodInfo::HG::Rendering::Runtime::VFXBackFaceHide::OnBeginCameraRendering,
		          0LL);
		        UnityEngine::Rendering::RenderPipelineManager::add_beginCameraRendering(v8, 0LL);
		        UnityEngine::Component::GetComponentsInChildren<System::Object>(
		          (Component *)this,
		          (List_1_System_Object_ *)this->fields.m_renderers,
		          MethodInfo::UnityEngine::Component::GetComponentsInChildren<UnityEngine::Renderer>);
		        return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2593, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		protected override void OnStop() {} // 0x0000000183524370-0x00000001835243F0
		// Void OnStop()
		void HG::Rendering::Runtime::VFXBackFaceHide::OnStop(VFXBackFaceHide *this, MethodInfo *method)
		{
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *v6; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2595, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2595, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  }
		  v3 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_1800368D0(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,UnityEngine::Camera>);
		  v6 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_UnityEngine_Camera_ *)v3;
		  if ( !v3 )
		    goto LABEL_6;
		  System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
		    v3,
		    (Object *)this,
		    MethodInfo::HG::Rendering::Runtime::VFXBackFaceHide::OnBeginCameraRendering,
		    0LL);
		  if ( !TypeInfo::UnityEngine::Rendering::RenderPipelineManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
		  UnityEngine::Rendering::RenderPipelineManager::remove_beginCameraRendering(v6, 0LL);
		}
		
		private void OnBeginCameraRendering(ScriptableRenderContext context, Camera targetCamera) {} // 0x000000018302BB70-0x000000018302C080
		// Void OnBeginCameraRendering(ScriptableRenderContext, Camera)
		void HG::Rendering::Runtime::VFXBackFaceHide::OnBeginCameraRendering(
		        VFXBackFaceHide *this,
		        ScriptableRenderContext context,
		        Camera *targetCamera,
		        MethodInfo *method)
		{
		  List_1_System_Object_ *items; // rcx
		  __int64 v8; // rdx
		  struct Object_1__Class *v9; // rcx
		  __int64 (__fastcall *v10)(Camera *, __int64, Camera *, MethodInfo *); // rax
		  __int64 v11; // rbx
		  void (__fastcall *v12)(__int64, Quaternion *); // rax
		  __int64 (__fastcall *v13)(VFXBackFaceHide *); // rax
		  __int64 v14; // rbx
		  void (__fastcall *v15)(__int64, Vector3 *); // rax
		  MethodInfo *v16; // r9
		  Vector3 *v17; // rax
		  __int64 v18; // rdx
		  __int64 v19; // r8
		  struct Math__Class *v20; // rcx
		  bool v21; // zf
		  float z; // edi
		  __m128 y_low; // xmm2
		  __m128d v24; // xmm3
		  double v25; // xmm0_8
		  float v26; // xmm0_4
		  __m128 x_low; // xmm6
		  __m128 v28; // xmm7
		  float v29; // xmm8_4
		  __int64 (__fastcall *v30)(VFXBackFaceHide *); // rax
		  __int64 v31; // rbx
		  void (__fastcall *v32)(__int64, Quaternion *); // rax
		  Vector3 *v33; // rax
		  __int64 v34; // xmm0_8
		  MethodInfo *v35; // r8
		  Beyond::JobMathf *v36; // rcx
		  struct VFXBackFaceHide__Class *v37; // rax
		  MaterialPropertyBlock *m_materialPropertyBlock; // rbx
		  unsigned int s_TintColorAlpha; // edi
		  void (__fastcall *v40)(MaterialPropertyBlock *, _QWORD); // rax
		  int32_t v41; // edi
		  List_1_UnityEngine_Renderer_ *m_renderers; // rax
		  __int64 v43; // rbx
		  struct Object_1__Class *v44; // rcx
		  void (__fastcall *v45)(__int64, MaterialPropertyBlock *); // rax
		  MaterialPropertyBlock *v46; // r14
		  MaterialPropertyBlock *v47; // rbx
		  HGRuntimeGrassQuery_Node *v48; // rdx
		  HGRuntimeGrassQuery_Node *v49; // r8
		  Int32__Array **v50; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v52; // rax
		  __int64 v53; // rax
		  __int64 v54; // rax
		  __int64 v55; // rax
		  __int64 v56; // rax
		  __int64 v57; // rax
		  __int64 v58; // rax
		  __int64 v59; // rax
		  MethodInfo *methoda; // [rsp+20h] [rbp-39h]
		  Vector3 v61; // [rsp+30h] [rbp-29h] BYREF
		  Quaternion v62; // [rsp+40h] [rbp-19h] BYREF
		  Vector3 v63; // [rsp+50h] [rbp-9h] BYREF
		  Quaternion v64; // [rsp+60h] [rbp+7h] BYREF
		
		  items = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    items = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v8 = **(_QWORD **)&items[4].fields._size;
		  if ( !v8 )
		    goto LABEL_47;
		  if ( *(int *)(v8 + 24) <= 2594 )
		    goto LABEL_5;
		  if ( !items[5].fields._size )
		  {
		    il2cpp_runtime_class_init_1(items);
		    items = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v8 = **(_QWORD **)&items[4].fields._size;
		  if ( !v8 )
		    goto LABEL_47;
		  if ( *(_DWORD *)(v8 + 24) <= 0xA22u )
		LABEL_57:
		    sub_1800D2AB0(items, v8);
		  if ( !*(_QWORD *)(v8 + 20784) )
		  {
		LABEL_5:
		    v9 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v9 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v9 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( !targetCamera )
		      return;
		    if ( !v9->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v9);
		    if ( !targetCamera->fields._._._.m_CachedPtr )
		      return;
		    v10 = (__int64 (__fastcall *)(Camera *, __int64, Camera *, MethodInfo *))qword_18F36FBC0;
		    if ( !qword_18F36FBC0 )
		    {
		      v10 = (__int64 (__fastcall *)(Camera *, __int64, Camera *, MethodInfo *))il2cpp_resolve_icall_1(
		                                                                                 "UnityEngine.Component::get_transform()");
		      if ( !v10 )
		      {
		        v52 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		        sub_18007E1B0(v52, 0LL);
		      }
		      qword_18F36FBC0 = (__int64)v10;
		    }
		    v11 = v10(targetCamera, v8, targetCamera, method);
		    if ( v11 )
		    {
		      *(_QWORD *)&v62.x = 0LL;
		      v62.z = 0.0;
		      v12 = (void (__fastcall *)(__int64, Quaternion *))qword_18F3700F0;
		      if ( !qword_18F3700F0 )
		      {
		        v12 = (void (__fastcall *)(__int64, Quaternion *))il2cpp_resolve_icall_1(
		                                                            "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		        if ( !v12 )
		        {
		          v53 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		          sub_18007E1B0(v53, 0LL);
		        }
		        qword_18F3700F0 = (__int64)v12;
		      }
		      v12(v11, &v62);
		      v13 = (__int64 (__fastcall *)(VFXBackFaceHide *))qword_18F36FBC0;
		      if ( !qword_18F36FBC0 )
		      {
		        v13 = (__int64 (__fastcall *)(VFXBackFaceHide *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
		        if ( !v13 )
		        {
		          v54 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		          sub_18007E1B0(v54, 0LL);
		        }
		        qword_18F36FBC0 = (__int64)v13;
		      }
		      v14 = v13(this);
		      if ( v14 )
		      {
		        *(_QWORD *)&v61.x = 0LL;
		        v61.z = 0.0;
		        v15 = (void (__fastcall *)(__int64, Vector3 *))qword_18F3700F0;
		        if ( !qword_18F3700F0 )
		        {
		          v15 = (void (__fastcall *)(__int64, Vector3 *))il2cpp_resolve_icall_1(
		                                                           "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		          if ( !v15 )
		          {
		            v55 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		            sub_18007E1B0(v55, 0LL);
		          }
		          qword_18F3700F0 = (__int64)v15;
		        }
		        v15(v14, &v61);
		        v63 = v61;
		        *(_QWORD *)&v61.x = *(_QWORD *)&v62.x;
		        v61.z = v62.z;
		        v17 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v64, &v61, &v63, v16);
		        v20 = TypeInfo::System::Math;
		        v21 = TypeInfo::System::Math->_1.cctor_finished_or_no_cctor == 0;
		        z = v17->z;
		        *(_QWORD *)&v62.x = *(_QWORD *)&v17->x;
		        *(_QWORD *)&v63.x = *(_QWORD *)&v62.x;
		        if ( v21 )
		          il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		        y_low = (__m128)LODWORD(v63.y);
		        y_low.m128_f32[0] = (float)((float)(y_low.m128_f32[0] * y_low.m128_f32[0]) + (float)(v63.x * v63.x))
		                          + (float)(z * z);
		        v24 = _mm_cvtps_pd(y_low);
		        if ( v24.m128d_f64[0] < 0.0 )
		          v25 = sub_1801D32D0(v20, v18, v19);
		        else
		          *(_QWORD *)&v25 = *(_OWORD *)&_mm_sqrt_pd(v24);
		        v26 = v25;
		        if ( v26 <= 0.0000099999997 )
		        {
		          x_low = 0LL;
		          v28 = 0LL;
		          v29 = 0.0;
		        }
		        else
		        {
		          x_low = (__m128)LODWORD(v62.x);
		          v28 = (__m128)LODWORD(v62.y);
		          x_low.m128_f32[0] = v62.x / v26;
		          v28.m128_f32[0] = v62.y / v26;
		          v29 = z / v26;
		        }
		        v30 = (__int64 (__fastcall *)(VFXBackFaceHide *))qword_18F36FBC0;
		        if ( !qword_18F36FBC0 )
		        {
		          v30 = (__int64 (__fastcall *)(VFXBackFaceHide *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
		          if ( !v30 )
		          {
		            v56 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		            sub_18007E1B0(v56, 0LL);
		          }
		          qword_18F36FBC0 = (__int64)v30;
		        }
		        v31 = v30(this);
		        if ( v31 )
		        {
		          v32 = (void (__fastcall *)(__int64, Quaternion *))qword_18F370110;
		          v64 = 0LL;
		          if ( !qword_18F370110 )
		          {
		            v32 = (void (__fastcall *)(__int64, Quaternion *))il2cpp_resolve_icall_1(
		                                                                "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
		            if ( !v32 )
		            {
		              v57 = sub_1802EE1B8("UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
		              sub_18007E1B0(v57, 0LL);
		            }
		            qword_18F370110 = (__int64)v32;
		          }
		          v32(v31, &v64);
		          v63.z = 1.0;
		          *(_QWORD *)&v63.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		          v62 = v64;
		          v33 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v64, &v62, &v63, 0LL);
		          v34 = *(_QWORD *)&v33->x;
		          *(float *)&v33 = v33->z;
		          *(_QWORD *)&v63.x = v34;
		          LODWORD(v63.z) = (_DWORD)v33;
		          *(_QWORD *)&v62.x = _mm_unpacklo_ps(x_low, v28).m128_u64[0];
		          v62.z = v29;
		          UnityEngine::Vector3::Dot((Vector3 *)&v62, &v63, v35);
		          Beyond::JobMathf::Clamp01(v36, 1.0);
		          if ( !this->fields.m_materialPropertyBlock )
		          {
		            v47 = (MaterialPropertyBlock *)sub_1800368D0(TypeInfo::UnityEngine::MaterialPropertyBlock);
		            if ( !v47 )
		              goto LABEL_47;
		            v47->fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		            this->fields.m_materialPropertyBlock = v47;
		            sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_materialPropertyBlock, v48, v49, v50, methoda);
		          }
		          v37 = TypeInfo::HG::Rendering::Runtime::VFXBackFaceHide;
		          m_materialPropertyBlock = this->fields.m_materialPropertyBlock;
		          if ( !TypeInfo::HG::Rendering::Runtime::VFXBackFaceHide->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VFXBackFaceHide);
		            v37 = TypeInfo::HG::Rendering::Runtime::VFXBackFaceHide;
		          }
		          s_TintColorAlpha = v37->static_fields->s_TintColorAlpha;
		          if ( m_materialPropertyBlock )
		          {
		            v40 = (void (__fastcall *)(MaterialPropertyBlock *, _QWORD))qword_18F36F448;
		            if ( !qword_18F36F448 )
		            {
		              v40 = (void (__fastcall *)(MaterialPropertyBlock *, _QWORD))il2cpp_resolve_icall_1(
		                                                                            "UnityEngine.MaterialPropertyBlock::SetFloatI"
		                                                                            "mpl(System.Int32,System.Single)");
		              if ( !v40 )
		              {
		                v58 = sub_1802EE1B8("UnityEngine.MaterialPropertyBlock::SetFloatImpl(System.Int32,System.Single)");
		                sub_18007E1B0(v58, 0LL);
		              }
		              qword_18F36F448 = (__int64)v40;
		            }
		            v40(m_materialPropertyBlock, s_TintColorAlpha);
		            v41 = 0;
		            while ( 1 )
		            {
		              m_renderers = this->fields.m_renderers;
		              if ( !m_renderers )
		                break;
		              if ( v41 >= m_renderers->fields._size )
		                return;
		              if ( (unsigned int)v41 >= m_renderers->fields._size )
		                System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		              items = (List_1_System_Object_ *)m_renderers->fields._items;
		              if ( !items )
		                break;
		              if ( (unsigned int)v41 >= items->fields._size )
		                goto LABEL_57;
		              v43 = *((_QWORD *)&items->fields._syncRoot + v41);
		              v44 = TypeInfo::UnityEngine::Object;
		              if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		              {
		                il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                v44 = TypeInfo::UnityEngine::Object;
		                if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		                {
		                  il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                  v44 = TypeInfo::UnityEngine::Object;
		                }
		              }
		              if ( !v43 )
		                goto LABEL_84;
		              if ( !v44->_1.cctor_finished_or_no_cctor )
		                il2cpp_runtime_class_init_1(v44);
		              if ( *(_QWORD *)(v43 + 16) )
		              {
		                v45 = (void (__fastcall *)(__int64, MaterialPropertyBlock *))qword_18F36F4B0;
		                ++v41;
		                v46 = this->fields.m_materialPropertyBlock;
		                if ( !qword_18F36F4B0 )
		                {
		                  v45 = (void (__fastcall *)(__int64, MaterialPropertyBlock *))il2cpp_resolve_icall_1(
		                                                                                 "UnityEngine.Renderer::Internal_SetPrope"
		                                                                                 "rtyBlock(UnityEngine.MaterialPropertyBlock)");
		                  if ( !v45 )
		                  {
		                    v59 = sub_1802EE1B8("UnityEngine.Renderer::Internal_SetPropertyBlock(UnityEngine.MaterialPropertyBlock)");
		                    sub_18007E1B0(v59, 0LL);
		                  }
		                  qword_18F36F4B0 = (__int64)v45;
		                }
		                v45(v43, v46);
		              }
		              else
		              {
		LABEL_84:
		                items = (List_1_System_Object_ *)this->fields.m_renderers;
		                if ( !items )
		                  break;
		                System::Collections::Generic::List<System::Object>::RemoveAt(
		                  items,
		                  v41,
		                  MethodInfo::System::Collections::Generic::List<UnityEngine::Renderer>::RemoveAt);
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_47:
		    sub_1800D8260(items, v8);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2594, 0LL);
		  if ( !Patch )
		    goto LABEL_47;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_235(Patch, (Object *)this, context, (Object *)targetCamera, 0LL);
		}
		
		public void __iFixBaseProxy_OnPlay() {} // 0x000000018745BF58-0x000000018745BF60
		// Void <>iFixBaseProxy_OnPlay()
		void HG::Rendering::Runtime::VFXSceneDark::__iFixBaseProxy_OnPlay(VFXSceneDark *this, MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPlayableMonoBase::OnPlay((VFXPlayableMonoBase *)this, 0LL);
		}
		
		public void __iFixBaseProxy_OnStop() {} // 0x0000000186FE0B3C-0x0000000186FE0B44
		// Void <>iFixBaseProxy_OnStop()
		void HG::Rendering::Runtime::VFXSceneDark::__iFixBaseProxy_OnStop(VFXSceneDark *this, MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPlayableMonoBase::OnStop((VFXPlayableMonoBase *)this, 0LL);
		}
		
	}
}
