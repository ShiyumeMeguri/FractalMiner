using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

public class EffectOcclusionCircle : MonoBehaviour // TypeDefIndex: 37360
{
	// Fields
	private const string OCCLUSION_KEYWORD = "_EFFECT_OCCLUSION"; // Metadata: 0x02302D13
	private List<Renderer> m_renderers; // 0x18
	private List<HGDecalProjector> m_decals; // 0x20
	private List<Material> m_materials; // 0x28
	[TupleElementNames(new string[2] {"renderer", "materialIndex" })]
	private List<ValueTuple<Renderer, int>> m_rendererSlots; // 0x30
	private List<HGDecalProjector> m_decalSlots; // 0x38
	private MaterialPropertyBlock m_propertyBlock; // 0x40
	private float m_radius; // 0x48
	private bool m_useInstantiatedMaterials; // 0x4C

	// Properties
	public float Radius { get => default; } // 0x0000000184D8D350-0x0000000184D8D360 
	// Single get_Height()
	float HG::Rendering::HgMath::CellGrid3D<System::Object>::get_Height(
	        CellGrid3D_1_System_Object_ *this,
	        MethodInfo *method)
	{
	  return this->fields._Height_k__BackingField;
	}
	
	public Vector2 Center { get => default; } // 0x0000000189B269E8-0x0000000189B26A54 
	// Vector2 get_Center()
	Vector2 EffectOcclusionRect::get_Center(EffectOcclusionRect *this, MethodInfo *method)
	{
	  Transform *transform; // rax
	  __int64 v4; // rdx
	  __int64 v5; // rcx
	  __m128 x_low; // xmm6
	  Transform *v7; // rax
	  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
	
	  transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
	  if ( !transform
	    || (x_low = (__m128)LODWORD(UnityEngine::Transform::get_position(&v9, transform, 0LL)->x),
	        (v7 = UnityEngine::Component::get_transform((Component *)this, 0LL)) == 0LL) )
	  {
	    sub_1800D8260(v5, v4);
	  }
	  return (Vector2)_mm_unpacklo_ps(x_low, (__m128)LODWORD(UnityEngine::Transform::get_position(&v9, v7, 0LL)->z)).m128_u64[0];
	}
	
	public IReadOnlyList<Material> Materials { get => default; } // 0x0000000184D86240-0x0000000184D86250 
	// Func`1[Object] get_getValueDelegate()
	Func_1_Object_ *Rewired::Utils::Classes::Utility::ValueWatcher<System::Object>::get_getValueDelegate(
	        ValueWatcher_1_System_Object_ *this,
	        MethodInfo *method)
	{
	  return this->fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA;
	}
	
	public IReadOnlyList<Renderer> Renderers { get => default; } // 0x000000018385B100-0x000000018385B110 
	// Object System.Collections.IEnumerator.get_Current()
	Object *Rewired::Platforms::Custom::HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_::vFJqwhcHvHdpsRAHqwODiJDbwkcr<System::Object>::System_Collections_IEnumerator_get_Current(
	        HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_vFJqwhcHvHdpsRAHqwODiJDbwkcr_System_Object_ *this,
	        MethodInfo *method)
	{
	  return (Object *)this->fields.YcoKziTgrGqKCwJTNRuXadHqwkUP;
	}
	
	public IReadOnlyList<HGDecalProjector> Decals { get => default; } // 0x0000000184D862C0-0x0000000184D862D0 
	// Func`1[Single] get_getValueDelegate()
	Func_1_Single_ *Rewired::Utils::Classes::Utility::ValueWatcher<float>::get_getValueDelegate(
	        ValueWatcher_1_System_Single_ *this,
	        MethodInfo *method)
	{
	  return this->fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA;
	}
	
	[TupleElementNames(new string[2] {"renderer", "materialIndex" })]
	public IReadOnlyList<ValueTuple<Renderer, int>> RendererSlots { get => default; } // 0x00000001811F36E0-0x00000001811F36F0 
	// IList`1[System.Object] HkgvubNsiKaMGZpZDhgJNXzxwNEY()
	IList_1_System_Object_ *aDnpaQcaHrbMtqQtSgzqebcYvhXN<System::Object>::HkgvubNsiKaMGZpZDhgJNXzxwNEY(
	        aDnpaQcaHrbMtqQtSgzqebcYvhXN_1_System_Object_ *this,
	        MethodInfo *method)
	{
	  return this->fields.YbVoRkZMMUxLLJcbAdHsvRhntcjw;
	}
	
	public IReadOnlyList<HGDecalProjector> DecalSlots { get => default; } // 0x0000000184D85A50-0x0000000184D85A60 
	// IUnit get_destinationUnit()
	IUnit *Unity::VisualScripting::UnitConnection<System::Object,System::Object>::get_destinationUnit(
	        UnitConnection_2_System_Object_System_Object_ *this,
	        MethodInfo *method)
	{
	  return this->fields._destinationUnit_k__BackingField;
	}
	
	public MaterialPropertyBlock PropertyBlock { get => default; } // 0x0000000184D85A60-0x0000000184D85A70 
	// ValueHandler`1[UnityEngine.Vector4] get_getter()
	ValueHandler_1_UnityEngine_Vector4_ *FlowCanvas::ValueOutput<UnityEngine::Vector4>::get_getter(
	        ValueOutput_1_UnityEngine_Vector4_ *this,
	        MethodInfo *method)
	{
	  return this->fields._getter_k__BackingField;
	}
	
	public bool UseInstantiatedMaterials { get => default; } // 0x0000000184D86910-0x0000000184D86920 
	// Boolean get_DefaultValue()
	bool Google::Protobuf::FieldCodec<bool>::get_DefaultValue(FieldCodec_1_System_Boolean_ *this, MethodInfo *method)
	{
	  return this->fields._DefaultValue_k__BackingField;
	}
	

	// Constructors
	public EffectOcclusionCircle() {} // 0x0000000189B268C4-0x0000000189B269E8
	// EffectOcclusionCircle()
	void EffectOcclusionCircle::EffectOcclusionCircle(EffectOcclusionCircle *this, MethodInfo *method)
	{
	  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v3; // rax
	  __int64 v4; // rdx
	  __int64 v5; // rcx
	  List_1_UnityEngine_Renderer_ *v6; // rdi
	  Type *v7; // rdx
	  PropertyInfo_1 *v8; // r8
	  Int32__Array **v9; // r9
	  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v10; // rax
	  List_1_UnityEngine_HGDecalProjector_ *v11; // rdi
	  Type *v12; // rdx
	  PropertyInfo_1 *v13; // r8
	  Int32__Array **v14; // r9
	  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v15; // rax
	  List_1_UnityEngine_Material_ *v16; // rdi
	  Type *v17; // rdx
	  PropertyInfo_1 *v18; // r8
	  Int32__Array **v19; // r9
	  LowLevelList_1_System_Object_ *v20; // rax
	  List_1_System_ValueTuple_2_UnityEngine_Renderer_Int32_ *v21; // rdi
	  Type *v22; // rdx
	  PropertyInfo_1 *v23; // r8
	  Int32__Array **v24; // r9
	  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v25; // rax
	  List_1_UnityEngine_HGDecalProjector_ *v26; // rdi
	  Type *v27; // rdx
	  PropertyInfo_1 *v28; // r8
	  Int32__Array **v29; // r9
	  MethodInfo *v30; // [rsp+20h] [rbp-8h]
	  MethodInfo *v31; // [rsp+20h] [rbp-8h]
	  MethodInfo *v32; // [rsp+20h] [rbp-8h]
	  MethodInfo *v33; // [rsp+20h] [rbp-8h]
	  MethodInfo *v34; // [rsp+20h] [rbp-8h]
	
	  v3 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<UnityEngine::Renderer>);
	  v6 = (List_1_UnityEngine_Renderer_ *)v3;
	  if ( !v3 )
	    goto LABEL_7;
	  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
	    v3,
	    MethodInfo::System::Collections::Generic::List<UnityEngine::Renderer>::List);
	  this->fields.m_renderers = v6;
	  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_renderers, v7, v8, v9, v30);
	  v10 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<UnityEngine::HGDecalProjector>);
	  v11 = (List_1_UnityEngine_HGDecalProjector_ *)v10;
	  if ( !v10 )
	    goto LABEL_7;
	  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
	    v10,
	    MethodInfo::System::Collections::Generic::List<UnityEngine::HGDecalProjector>::List);
	  this->fields.m_decals = v11;
	  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_decals, v12, v13, v14, v31);
	  v15 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<UnityEngine::Material>);
	  v16 = (List_1_UnityEngine_Material_ *)v15;
	  if ( !v15 )
	    goto LABEL_7;
	  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
	    v15,
	    MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::List);
	  this->fields.m_materials = v16;
	  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_materials, v17, v18, v19, v32);
	  v20 = (LowLevelList_1_System_Object_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Renderer,int>>);
	  v21 = (List_1_System_ValueTuple_2_UnityEngine_Renderer_Int32_ *)v20;
	  if ( !v20
	    || (System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
	          v20,
	          MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Renderer,int>>::List),
	        this->fields.m_rendererSlots = v21,
	        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_rendererSlots, v22, v23, v24, v33),
	        v25 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<UnityEngine::HGDecalProjector>),
	        (v26 = (List_1_UnityEngine_HGDecalProjector_ *)v25) == 0LL) )
	  {
	LABEL_7:
	    sub_1800D8260(v5, v4);
	  }
	  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
	    v25,
	    MethodInfo::System::Collections::Generic::List<UnityEngine::HGDecalProjector>::List);
	  this->fields.m_decalSlots = v26;
	  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_decalSlots, v27, v28, v29, v34);
	  RootMotion::Singleton<System::Object>::Singleton((Singleton_1_System_Object__1 *)this, 0LL);
	}
	

	// Methods
	private void Awake() {} // 0x0000000189B257B8-0x0000000189B257C0
	// Void Awake()
	void EffectOcclusionCircle::Awake(EffectOcclusionCircle *this, MethodInfo *method)
	{
	  EffectOcclusionCircle::Initialize(this, 0LL);
	}
	
	private void Initialize() {} // 0x0000000189B25B2C-0x0000000189B263AC
	// Void Initialize()
	// Hidden C++ exception states: #wind=4
	void EffectOcclusionCircle::Initialize(EffectOcclusionCircle *this, MethodInfo *method)
	{
	  EffectOcclusionCircle *v2; // rbx
	  bool isPlaying; // al
	  __int64 v4; // rdx
	  __int64 v5; // rcx
	  __int64 v6; // rdx
	  signed __int64 v7; // rcx
	  Object *current; // r12
	  Material__Array *SharedMaterialArray; // rax
	  __int64 v10; // rdx
	  __int64 v11; // rcx
	  Material__Array *v12; // r13
	  __int64 v13; // rdx
	  __int64 v14; // rcx
	  __int64 v15; // r8
	  Material__Array *v16; // r14
	  int32_t i; // edi
	  Object_1 *v18; // rsi
	  __int64 v19; // rdx
	  __int64 v20; // rcx
	  Object *v21; // rax
	  __int64 v22; // rdx
	  __int64 v23; // rcx
	  Object *v24; // rsi
	  __int64 v25; // rdx
	  List_1_System_Object_ *m_materials; // rcx
	  unsigned __int64 v27; // rdx
	  signed __int64 v28; // rcx
	  List_1_System_ValueTuple_2_UnityEngine_Renderer_Int32_ *m_rendererSlots; // r9
	  unsigned __int64 v30; // r8
	  signed __int64 v31; // rtt
	  List_1_System_UInt64_ *m_decals; // rdx
	  __int64 v33; // rdx
	  __int64 v34; // rcx
	  Object *v35; // rdi
	  Object *material; // rsi
	  __int64 v37; // rdx
	  __int64 v38; // rcx
	  Object *v39; // rax
	  __int64 v40; // rdx
	  __int64 v41; // rcx
	  Object *v42; // rsi
	  __int64 v43; // rdx
	  List_1_System_Object_ *v44; // rcx
	  __int64 v45; // rdx
	  List_1_System_Object_ *m_decalSlots; // rcx
	  __int64 v47; // rdi
	  unsigned __int64 v48; // r8
	  signed __int64 v49; // rtt
	  __int64 v50; // rdx
	  Object *v51; // r12
	  unsigned __int64 v52; // rdx
	  signed __int64 v53; // rcx
	  Material__Array *v54; // rsi
	  __int64 v55; // r8
	  int32_t v56; // edi
	  Material *v57; // r14
	  List_1_System_ValueTuple_2_UnityEngine_Renderer_Int32_ *v58; // r9
	  unsigned __int64 v59; // r8
	  signed __int64 v60; // rtt
	  __int64 v61; // rdx
	  __int64 v62; // rcx
	  Object *v63; // rdi
	  Material *v64; // rsi
	  __int64 v65; // rdx
	  __int64 v66; // rcx
	  __int64 v67; // rdx
	  List_1_System_Object_ *v68; // rcx
	  Il2CppException *ex; // [rsp+20h] [rbp-B8h]
	  Il2CppException *v70; // [rsp+20h] [rbp-B8h]
	  Il2CppException *v71; // [rsp+20h] [rbp-B8h]
	  Il2CppException *v72; // [rsp+20h] [rbp-B8h]
	  __int128 v73; // [rsp+30h] [rbp-A8h] BYREF
	  List_1_T_Enumerator_System_Object_ v74; // [rsp+40h] [rbp-98h] BYREF
	  List_1_T_Enumerator_System_Object_ v75; // [rsp+60h] [rbp-78h] BYREF
	  List_1_T_Enumerator_System_Object_ v76; // [rsp+78h] [rbp-60h] BYREF
	  Il2CppExceptionWrapper *v77; // [rsp+90h] [rbp-48h] BYREF
	  Il2CppExceptionWrapper *v78; // [rsp+98h] [rbp-40h] BYREF
	  Il2CppExceptionWrapper *v79; // [rsp+A0h] [rbp-38h] BYREF
	  Il2CppExceptionWrapper *v80; // [rsp+A8h] [rbp-30h] BYREF
	  char v82; // [rsp+F0h] [rbp+18h]
	
	  v2 = this;
	  memset(&v75, 0, sizeof(v75));
	  memset(&v76, 0, sizeof(v76));
	  UnityEngine::Component::GetComponentsInChildren<System::Object>(
	    (Component *)this,
	    (List_1_System_Object_ *)this->fields.m_renderers,
	    MethodInfo::UnityEngine::Component::GetComponentsInChildren<UnityEngine::Renderer>);
	  UnityEngine::Component::GetComponentsInChildren<System::Object>(
	    (Component *)v2,
	    (List_1_System_Object_ *)v2->fields.m_decals,
	    MethodInfo::UnityEngine::Component::GetComponentsInChildren<UnityEngine::HGDecalProjector>);
	  isPlaying = UnityEngine::Application::get_isPlaying(0LL);
	  v2->fields.m_useInstantiatedMaterials = isPlaying;
	  if ( !isPlaying )
	    goto LABEL_41;
	  if ( !v2->fields.m_renderers )
	    sub_1800D8260(v5, v4);
	  v75 = *(List_1_T_Enumerator_System_Object_ *)sub_180369DBC(&v74, v2->fields.m_renderers);
	  try
	  {
	    while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
	              &v75,
	              MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Renderer>::MoveNext) )
	    {
	      current = v75._current;
	      if ( !v75._current )
	        sub_1800D8250(v7, v6);
	      SharedMaterialArray = UnityEngine::Renderer::GetSharedMaterialArray((Renderer *)v75._current, 0LL);
	      v12 = SharedMaterialArray;
	      if ( !SharedMaterialArray )
	        sub_1800D8250(v11, v10);
	      v16 = (Material__Array *)il2cpp_array_new_specific_1(
	                                 TypeInfo::UnityEngine::Material,
	                                 (unsigned int)SharedMaterialArray->max_length.size);
	      v82 = 0;
	      for ( i = 0; i < v12->max_length.size; ++i )
	      {
	        if ( (unsigned int)i >= v12->max_length.size )
	          sub_1800D2AA0(v14, v13, v15);
	        v18 = (Object_1 *)v12->vector[i];
	        sub_1800036A0(TypeInfo::UnityEngine::Object);
	        if ( !UnityEngine::Object::op_Inequality(v18, 0LL, 0LL) )
	          goto LABEL_20;
	        if ( !v18 )
	          sub_1800D8250(v20, v19);
	        if ( UnityEngine::Material::IsKeywordEnabled((Material *)v18, (String *)"_EFFECT_OCCLUSION", 0LL) )
	        {
	          sub_1800036A0(TypeInfo::UnityEngine::Object);
	          v21 = UnityEngine::Object::Instantiate<System::Object>(
	                  (Object *)v18,
	                  MethodInfo::UnityEngine::Object::Instantiate<UnityEngine::Material>);
	          v24 = v21;
	          if ( !v16 )
	            sub_1800D8250(v23, v22);
	          sub_180031B10(v16, v21);
	          sub_1800020D0(v16, i, v24);
	          m_materials = (List_1_System_Object_ *)v2->fields.m_materials;
	          if ( !m_materials )
	            sub_1800D8250(0LL, v25);
	          sub_182F01190(m_materials, v24);
	          m_rendererSlots = v2->fields.m_rendererSlots;
	          v73 = (unsigned __int64)current;
	          if ( dword_18F35FD08 )
	          {
	            v30 = (((unsigned __int64)&v73 >> 12) & 0x1FFFFF) >> 6;
	            v27 = ((unsigned __int64)&v73 >> 12) & 0x3F;
	            _m_prefetchw(&qword_18F0BCBA0[v30 + 36190]);
	            do
	            {
	              v28 = qword_18F0BCBA0[v30 + 36190] | (1LL << v27);
	              v31 = qword_18F0BCBA0[v30 + 36190];
	            }
	            while ( v31 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v30 + 36190], v28, v31) );
	          }
	          DWORD2(v73) = i;
	          if ( !m_rendererSlots )
	            sub_1800D8250(v28, v27);
	          *(_OWORD *)&v74._list = v73;
	          sub_184A137E0(
	            m_rendererSlots,
	            &v74,
	            MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Renderer,int>>::Add);
	          v82 = 1;
	        }
	        else
	        {
	LABEL_20:
	          if ( !v16 )
	            sub_1800D8250(v20, v19);
	          sub_180031B10(v16, v18);
	          sub_1800020D0(v16, i, v18);
	        }
	      }
	      if ( v82 )
	      {
	        if ( !current )
	          sub_1800D8250(v14, v13);
	        UnityEngine::Renderer::SetMaterialArray((Renderer *)current, v16, 0LL);
	      }
	    }
	  }
	  catch ( Il2CppExceptionWrapper *v77 )
	  {
	    ex = v77->ex;
	    v7 = (signed __int64)v77->ex;
	    if ( ex )
	      sub_18007E1E0(ex);
	    v2 = this;
	  }
	  m_decals = (List_1_System_UInt64_ *)v2->fields.m_decals;
	  if ( !m_decals )
	    goto LABEL_75;
	  System::Collections::Generic::List<unsigned long>::GetEnumerator(
	    (List_1_T_Enumerator_System_UInt64_ *)&v74,
	    m_decals,
	    MethodInfo::System::Collections::Generic::List<UnityEngine::HGDecalProjector>::GetEnumerator);
	  v76 = v74;
	  try
	  {
	    while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
	              &v76,
	              MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::HGDecalProjector>::MoveNext) )
	    {
	      v35 = v76._current;
	      if ( !v76._current )
	        sub_1800D8250(v34, v33);
	      material = (Object *)UnityEngine::HGDecalProjector::get_material((HGDecalProjector *)v76._current, 0LL);
	      sub_1800036A0(TypeInfo::UnityEngine::Object);
	      if ( UnityEngine::Object::op_Inequality((Object_1 *)material, 0LL, 0LL) )
	      {
	        if ( !material )
	          sub_1800D8250(v38, v37);
	        if ( UnityEngine::Material::IsKeywordEnabled((Material *)material, (String *)"_EFFECT_OCCLUSION", 0LL) )
	        {
	          sub_1800036A0(TypeInfo::UnityEngine::Object);
	          v39 = UnityEngine::Object::Instantiate<System::Object>(
	                  material,
	                  MethodInfo::UnityEngine::Object::Instantiate<UnityEngine::Material>);
	          v42 = v39;
	          if ( !v35 )
	            sub_1800D8250(v41, v40);
	          UnityEngine::HGDecalProjector::set_material((HGDecalProjector *)v35, (Material *)v39, 0LL);
	          v44 = (List_1_System_Object_ *)v2->fields.m_materials;
	          if ( !v44 )
	            sub_1800D8250(0LL, v43);
	          sub_182F01190(v44, v42);
	          m_decalSlots = (List_1_System_Object_ *)v2->fields.m_decalSlots;
	          if ( !m_decalSlots )
	            sub_1800D8250(0LL, v45);
	          sub_182F01190(m_decalSlots, v35);
	        }
	      }
	    }
	  }
	  catch ( Il2CppExceptionWrapper *v78 )
	  {
	    v70 = v78->ex;
	    if ( v70 )
	      sub_18007E1E0(v70);
	    v2 = this;
	LABEL_41:
	    v47 = sub_18002C620(TypeInfo::UnityEngine::MaterialPropertyBlock);
	    if ( v47 )
	    {
	      *(_QWORD *)(v47 + 16) = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
	      v2->fields.m_propertyBlock = (MaterialPropertyBlock *)v47;
	      if ( dword_18F35FD08 )
	      {
	        v48 = (((unsigned __int64)&v2->fields.m_propertyBlock >> 12) & 0x1FFFFF) >> 6;
	        _m_prefetchw(&qword_18F0BCBA0[v48 + 36190]);
	        do
	        {
	          v7 = qword_18F0BCBA0[v48 + 36190] | (1LL << (((unsigned __int64)&v2->fields.m_propertyBlock >> 12) & 0x3F));
	          v49 = qword_18F0BCBA0[v48 + 36190];
	        }
	        while ( v49 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v48 + 36190], v7, v49) );
	      }
	      m_decals = (List_1_System_UInt64_ *)v2->fields.m_renderers;
	      if ( m_decals )
	      {
	        System::Collections::Generic::List<unsigned long>::GetEnumerator(
	          (List_1_T_Enumerator_System_UInt64_ *)&v74,
	          m_decals,
	          MethodInfo::System::Collections::Generic::List<UnityEngine::Renderer>::GetEnumerator);
	        v75 = v74;
	        try
	        {
	          while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
	                    &v75,
	                    MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Renderer>::MoveNext) )
	          {
	            v51 = v75._current;
	            if ( !v75._current )
	              sub_1800D8250(v7, v50);
	            v54 = UnityEngine::Renderer::GetSharedMaterialArray((Renderer *)v75._current, 0LL);
	            v56 = 0;
	            if ( !v54 )
	              sub_1800D8250(v53, v52);
	            while ( v56 < v54->max_length.size )
	            {
	              if ( (unsigned int)v56 >= v54->max_length.size )
	                sub_1800D2AA0(v53, v52, v55);
	              v57 = v54->vector[v56];
	              sub_1800036A0(TypeInfo::UnityEngine::Object);
	              if ( UnityEngine::Object::op_Inequality((Object_1 *)v57, 0LL, 0LL) )
	              {
	                if ( !v57 )
	                  sub_1800D8250(v53, v52);
	                if ( UnityEngine::Material::IsKeywordEnabled(v57, (String *)"_EFFECT_OCCLUSION", 0LL) )
	                {
	                  v58 = v2->fields.m_rendererSlots;
	                  v73 = (unsigned __int64)v51;
	                  if ( dword_18F35FD08 )
	                  {
	                    v59 = (((unsigned __int64)&v73 >> 12) & 0x1FFFFF) >> 6;
	                    v52 = ((unsigned __int64)&v73 >> 12) & 0x3F;
	                    _m_prefetchw(&qword_18F0BCBA0[v59 + 36190]);
	                    do
	                    {
	                      v53 = qword_18F0BCBA0[v59 + 36190] | (1LL << v52);
	                      v60 = qword_18F0BCBA0[v59 + 36190];
	                    }
	                    while ( v60 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v59 + 36190], v53, v60) );
	                  }
	                  DWORD2(v73) = v56;
	                  if ( !v58 )
	                    sub_1800D8250(v53, v52);
	                  *(_OWORD *)&v74._list = v73;
	                  sub_184A137E0(
	                    v58,
	                    &v74,
	                    MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Renderer,int>>::Add);
	                }
	              }
	              ++v56;
	            }
	          }
	        }
	        catch ( Il2CppExceptionWrapper *v79 )
	        {
	          v71 = v79->ex;
	          v7 = (signed __int64)v79->ex;
	          if ( v71 )
	            sub_18007E1E0(v71);
	          v2 = this;
	        }
	        m_decals = (List_1_System_UInt64_ *)v2->fields.m_decals;
	        if ( m_decals )
	        {
	          System::Collections::Generic::List<unsigned long>::GetEnumerator(
	            (List_1_T_Enumerator_System_UInt64_ *)&v74,
	            m_decals,
	            MethodInfo::System::Collections::Generic::List<UnityEngine::HGDecalProjector>::GetEnumerator);
	          v76 = v74;
	          try
	          {
	            while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
	                      &v76,
	                      MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::HGDecalProjector>::MoveNext) )
	            {
	              v63 = v76._current;
	              if ( !v76._current )
	                sub_1800D8250(v62, v61);
	              v64 = UnityEngine::HGDecalProjector::get_material((HGDecalProjector *)v76._current, 0LL);
	              sub_1800036A0(TypeInfo::UnityEngine::Object);
	              if ( UnityEngine::Object::op_Inequality((Object_1 *)v64, 0LL, 0LL) )
	              {
	                if ( !v64 )
	                  sub_1800D8250(v66, v65);
	                if ( UnityEngine::Material::IsKeywordEnabled(v64, (String *)"_EFFECT_OCCLUSION", 0LL) )
	                {
	                  v68 = (List_1_System_Object_ *)v2->fields.m_decalSlots;
	                  if ( !v68 )
	                    sub_1800D8250(0LL, v67);
	                  sub_182F01190(v68, v63);
	                }
	              }
	            }
	          }
	          catch ( Il2CppExceptionWrapper *v80 )
	          {
	            v72 = v80->ex;
	            if ( v72 )
	              sub_18007E1E0(v72);
	            v2 = this;
	          }
	          goto LABEL_74;
	        }
	      }
	    }
	LABEL_75:
	    sub_1800D8250(v7, m_decals);
	  }
	LABEL_74:
	  EffectOcclusionCircle::CalculateRadius(v2, 0LL);
	}
	
	private void OnEnable() {} // 0x0000000189B26874-0x0000000189B268C4
	// Void OnEnable()
	void EffectOcclusionCircle::OnEnable(EffectOcclusionCircle *this, MethodInfo *method)
	{
	  List_1_UnityEngine_Renderer_ *m_renderers; // rax
	  HGVFXManager *instance; // rax
	
	  m_renderers = this->fields.m_renderers;
	  if ( !m_renderers )
	    goto LABEL_6;
	  if ( !m_renderers->fields._size )
	    EffectOcclusionCircle::Initialize(this, 0LL);
	  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
	  instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
	  if ( !instance )
	LABEL_6:
	    sub_1800D8260(this, method);
	  HG::Rendering::Runtime::HGVFXManager::RegisterCircle(instance, this, 0LL);
	}
	
	private void OnDisable() {} // 0x0000000189B26504-0x0000000189B26548
	// Void OnDisable()
	void EffectOcclusionCircle::OnDisable(EffectOcclusionCircle *this, MethodInfo *method)
	{
	  HGVFXManager *instance; // rax
	  __int64 v4; // rdx
	  __int64 v5; // rcx
	
	  if ( !TypeInfo::HG::Rendering::Runtime::HGVFXManager->_1.cctor_finished_or_no_cctor )
	    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
	  instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
	  if ( !instance )
	    sub_1800D8260(v5, v4);
	  HG::Rendering::Runtime::HGVFXManager::UnregisterCircle(instance, this, 0LL);
	}
	
	private void OnDestroy() {} // 0x0000000189B263AC-0x0000000189B26504
	// Void OnDestroy()
	// Hidden C++ exception states: #wind=1
	void EffectOcclusionCircle::OnDestroy(EffectOcclusionCircle *this, MethodInfo *method)
	{
	  EffectOcclusionCircle *v2; // rbx
	  Object *current; // rdi
	  void *m_materials; // rcx
	  __int64 v5; // [rsp+0h] [rbp-68h] BYREF
	  Il2CppExceptionWrapper *v6; // [rsp+20h] [rbp-48h] BYREF
	  _QWORD v7[3]; // [rsp+28h] [rbp-40h] BYREF
	  List_1_T_Enumerator_System_Object_ v8; // [rsp+40h] [rbp-28h] BYREF
	
	  v2 = this;
	  memset(&v8, 0, sizeof(v8));
	  if ( this->fields.m_useInstantiatedMaterials )
	  {
	    if ( !this->fields.m_materials )
	      sub_1800D8260(this, method);
	    v8 = *(List_1_T_Enumerator_System_Object_ *)sub_1803636BC(v7, this->fields.m_materials);
	    v7[0] = 0LL;
	    v7[1] = &v8;
	    try
	    {
	      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
	                &v8,
	                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Material>::MoveNext) )
	      {
	        current = v8._current;
	        sub_1800036A0(TypeInfo::UnityEngine::Object);
	        if ( UnityEngine::Object::op_Inequality((Object_1 *)current, 0LL, 0LL) )
	        {
	          sub_1800036A0(TypeInfo::UnityEngine::Object);
	          UnityEngine::Object::Destroy((Object_1 *)current, 0LL);
	        }
	      }
	    }
	    catch ( Il2CppExceptionWrapper *v6 )
	    {
	      method = (MethodInfo *)&v5;
	      v7[0] = v6->ex;
	      if ( v7[0] )
	        sub_18007E1E0(v7[0]);
	      v2 = this;
	    }
	  }
	  m_materials = v2->fields.m_materials;
	  if ( !m_materials
	    || (sub_183127A90(m_materials, MethodInfo::System::Collections::Generic::List<UnityEngine::Material>::Clear),
	        (m_materials = v2->fields.m_rendererSlots) == 0LL)
	    || (sub_183E41B50(
	          m_materials,
	          MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Renderer,int>>::Clear),
	        (m_materials = v2->fields.m_decalSlots) == 0LL) )
	  {
	    sub_1800D8250(m_materials, method);
	  }
	  sub_183127A90(m_materials, MethodInfo::System::Collections::Generic::List<UnityEngine::HGDecalProjector>::Clear);
	}
	
	public void CalculateRadius() {} // 0x0000000189B257C0-0x0000000189B25B2C
	// Void CalculateRadius()
	// Hidden C++ exception states: #wind=2
	void EffectOcclusionCircle::CalculateRadius(EffectOcclusionCircle *this, MethodInfo *method)
	{
	  EffectOcclusionCircle *v2; // rbx
	  List_1_UnityEngine_Renderer_ *m_renderers; // rdi
	  List_1_UnityEngine_HGDecalProjector_ *m_decals; // rdi
	  char v5; // di
	  Il2CppException *v6; // rcx
	  List_1_System_UInt64_ *v7; // rdx
	  __int64 v8; // rcx
	  Bounds *bounds; // rax
	  __int64 v10; // xmm1_8
	  Single__Array *v11; // rax
	  __int64 v12; // r8
	  Il2CppException *ex; // [rsp+20h] [rbp-B8h]
	  Il2CppException *v14; // [rsp+20h] [rbp-B8h]
	  Bounds v15; // [rsp+30h] [rbp-A8h] BYREF
	  Bounds v16; // [rsp+50h] [rbp-88h] BYREF
	  List_1_T_Enumerator_System_Object_ v17; // [rsp+70h] [rbp-68h] BYREF
	  List_1_T_Enumerator_System_Object_ v18; // [rsp+88h] [rbp-50h] BYREF
	  Il2CppExceptionWrapper *v19; // [rsp+A0h] [rbp-38h] BYREF
	  Il2CppExceptionWrapper *v20; // [rsp+A8h] [rbp-30h] BYREF
	  Bounds v21; // [rsp+B0h] [rbp-28h] BYREF
	  char v23; // [rsp+F0h] [rbp+18h]
	
	  v2 = this;
	  memset(&v17, 0, sizeof(v17));
	  memset(&v18, 0, sizeof(v18));
	  m_renderers = this->fields.m_renderers;
	  if ( !m_renderers )
	    sub_1800D8260(this, method);
	  if ( m_renderers->fields._size )
	    goto LABEL_6;
	  m_decals = this->fields.m_decals;
	  if ( !m_decals )
	    sub_1800D8260(this, method);
	  if ( m_decals->fields._size )
	  {
	LABEL_6:
	    memset(&v15, 0, sizeof(v15));
	    v5 = 0;
	    v23 = 0;
	    if ( !this->fields.m_renderers )
	      sub_1800D8260(this, method);
	    v17 = *(List_1_T_Enumerator_System_Object_ *)sub_180369DBC(&v16, this->fields.m_renderers);
	    try
	    {
	      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
	                &v17,
	                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Renderer>::MoveNext) )
	      {
	        if ( v5 )
	        {
	          if ( !v17._current )
	            sub_1800D8250(v6, 0LL);
	          v16 = *UnityEngine::Renderer::get_bounds(&v21, (Renderer *)v17._current, 0LL);
	          UnityEngine::Bounds::Encapsulate(&v15, &v16, 0LL);
	        }
	        else
	        {
	          if ( !v17._current )
	            sub_1800D8250(v6, 0LL);
	          v15 = *UnityEngine::Renderer::get_bounds(&v21, (Renderer *)v17._current, 0LL);
	          v5 = 1;
	          v23 = 1;
	        }
	      }
	    }
	    catch ( Il2CppExceptionWrapper *v19 )
	    {
	      ex = v19->ex;
	      v6 = v19->ex;
	      if ( ex )
	        sub_18007E1E0(ex);
	      v2 = this;
	      v5 = v23;
	    }
	    v7 = (List_1_System_UInt64_ *)v2->fields.m_decals;
	    if ( !v7 )
	      goto LABEL_30;
	    System::Collections::Generic::List<unsigned long>::GetEnumerator(
	      (List_1_T_Enumerator_System_UInt64_ *)&v16,
	      v7,
	      MethodInfo::System::Collections::Generic::List<UnityEngine::HGDecalProjector>::GetEnumerator);
	    v18 = (List_1_T_Enumerator_System_Object_)v16;
	    try
	    {
	      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
	                &v18,
	                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::HGDecalProjector>::MoveNext) )
	      {
	        if ( !v18._current )
	          sub_1800D8250(v8, 0LL);
	        bounds = UnityEngine::HGDecalProjector::get_bounds(&v21, (HGDecalProjector *)v18._current, 0LL);
	        v10 = *(_QWORD *)&bounds->m_Extents.y;
	        if ( v5 )
	        {
	          *(_OWORD *)&v16.m_Center.x = *(_OWORD *)&bounds->m_Center.x;
	          *(_QWORD *)&v16.m_Extents.y = v10;
	          UnityEngine::Bounds::Encapsulate(&v15, &v16, 0LL);
	        }
	        else
	        {
	          *(_OWORD *)&v15.m_Center.x = *(_OWORD *)&bounds->m_Center.x;
	          *(_QWORD *)&v15.m_Extents.y = v10;
	          v5 = 1;
	        }
	      }
	    }
	    catch ( Il2CppExceptionWrapper *v20 )
	    {
	      v14 = v20->ex;
	      if ( v14 )
	        sub_18007E1E0(v14);
	      v2 = this;
	    }
	    v11 = (Single__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Single, 3LL);
	    if ( !v11 )
	LABEL_30:
	      sub_1800D8250(v6, v7);
	    if ( !v11->max_length.size
	      || (v11->vector[0] = v15.m_Extents.x, v11->max_length.size <= 1u)
	      || (v11->vector[1] = v15.m_Extents.y, v11->max_length.size <= 2u) )
	    {
	      sub_1800D2AA0(v6, v7, v12);
	    }
	    v11->vector[2] = v15.m_Extents.z;
	    v2->fields.m_radius = UnityEngine::Mathf::Max(v11, (MethodInfo *)v7);
	  }
	  else
	  {
	    this->fields.m_radius = 1.0;
	  }
	}
	
	private void OnDrawGizmosSelected() {} // 0x0000000189B26548-0x0000000189B26874
	// Void OnDrawGizmosSelected()
	void EffectOcclusionCircle::OnDrawGizmosSelected(EffectOcclusionCircle *this, MethodInfo *method)
	{
	  Object__Array *v3; // rsi
	  Object__Array *v4; // rax
	  Renderer *v5; // rdx
	  __int64 v6; // rcx
	  Object__Array *v7; // rbx
	  char v8; // r14
	  int32_t i; // edi
	  Bounds *bounds; // rax
	  __int64 v11; // xmm1_8
	  Bounds *v12; // rax
	  __int64 v13; // xmm1_8
	  int32_t v14; // edi
	  Bounds *v15; // rax
	  __int64 v16; // xmm1_8
	  Single__Array *v17; // rax
	  __m128 z_low; // xmm0
	  float v19; // xmm7_4
	  Transform *transform; // rax
	  Vector3 *position; // rax
	  float x; // xmm1_4
	  __int64 v23; // xmm0_8
	  MethodInfo *v24; // r9
	  Vector3 *v25; // rax
	  Beyond::DampingMath *v26; // rcx
	  float *v27; // r9
	  __int64 v28; // xmm0_8
	  int v29; // edi
	  __int64 v30; // xmm8_8
	  float z; // esi
	  Beyond::DampingMath *v32; // rcx
	  MethodInfo *v33; // r9
	  Vector3 *v34; // rax
	  __int64 v35; // xmm6_8
	  float v36; // ebx
	  Bounds v37; // [rsp+28h] [rbp-79h] BYREF
	  Vector3 v38; // [rsp+48h] [rbp-59h] BYREF
	  Vector3 v39; // [rsp+58h] [rbp-49h] BYREF
	  Bounds v40; // [rsp+68h] [rbp-39h] BYREF
	  Vector3 v41; // [rsp+88h] [rbp-19h] BYREF
	  Bounds v42[3]; // [rsp+98h] [rbp-9h] BYREF
	
	  v3 = UnityEngine::Component::GetComponentsInChildren<System::Object>(
	         (Component *)this,
	         MethodInfo::UnityEngine::Component::GetComponentsInChildren<UnityEngine::Renderer>);
	  v4 = UnityEngine::Component::GetComponentsInChildren<System::Object>(
	         (Component *)this,
	         MethodInfo::UnityEngine::Component::GetComponentsInChildren<UnityEngine::HGDecalProjector>);
	  v7 = v4;
	  if ( !v3 )
	    goto LABEL_31;
	  if ( !v3->max_length.value )
	  {
	    if ( !v4 )
	      goto LABEL_31;
	    if ( !v4->max_length.value )
	      return;
	  }
	  v8 = 0;
	  memset(&v37, 0, sizeof(v37));
	  for ( i = 0; i < v3->max_length.size; ++i )
	  {
	    if ( (unsigned int)i >= v3->max_length.size )
	      goto LABEL_30;
	    v5 = (Renderer *)v3->vector[i];
	    if ( v8 )
	    {
	      if ( !v5 )
	        goto LABEL_31;
	      bounds = UnityEngine::Renderer::get_bounds(v42, v5, 0LL);
	      v11 = *(_QWORD *)&bounds->m_Extents.y;
	      *(_OWORD *)&v40.m_Center.x = *(_OWORD *)&bounds->m_Center.x;
	      *(_QWORD *)&v40.m_Extents.y = v11;
	      UnityEngine::Bounds::Encapsulate(&v37, &v40, 0LL);
	    }
	    else
	    {
	      if ( !v5 )
	        goto LABEL_31;
	      v12 = UnityEngine::Renderer::get_bounds(&v40, v5, 0LL);
	      v8 = 1;
	      v13 = *(_QWORD *)&v12->m_Extents.y;
	      *(_OWORD *)&v37.m_Center.x = *(_OWORD *)&v12->m_Center.x;
	      *(_QWORD *)&v37.m_Extents.y = v13;
	    }
	  }
	  v14 = 0;
	  if ( !v7 )
	    goto LABEL_31;
	  while ( v14 < v7->max_length.size )
	  {
	    if ( (unsigned int)v14 >= v7->max_length.size )
	      goto LABEL_30;
	    v5 = (Renderer *)v7->vector[v14];
	    if ( !v5 )
	      goto LABEL_31;
	    v15 = UnityEngine::HGDecalProjector::get_bounds(v42, (HGDecalProjector *)v5, 0LL);
	    v16 = *(_QWORD *)&v15->m_Extents.y;
	    if ( v8 )
	    {
	      *(_OWORD *)&v40.m_Center.x = *(_OWORD *)&v15->m_Center.x;
	      *(_QWORD *)&v40.m_Extents.y = v16;
	      UnityEngine::Bounds::Encapsulate(&v37, &v40, 0LL);
	    }
	    else
	    {
	      *(_OWORD *)&v37.m_Center.x = *(_OWORD *)&v15->m_Center.x;
	      v8 = 1;
	      *(_QWORD *)&v37.m_Extents.y = v16;
	    }
	    ++v14;
	  }
	  v17 = (Single__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Single, 3LL);
	  if ( !v17 )
	    goto LABEL_31;
	  if ( !v17->max_length.size
	    || (v17->vector[0] = v37.m_Extents.x, v17->max_length.size <= 1u)
	    || (v17->vector[1] = v37.m_Extents.y, v17->max_length.size <= 2u) )
	  {
	LABEL_30:
	    sub_1800D2AB0(v6, v5);
	  }
	  z_low = (__m128)LODWORD(v37.m_Extents.z);
	  v17->vector[2] = v37.m_Extents.z;
	  z_low.m128_f32[0] = UnityEngine::Mathf::Max(v17, (MethodInfo *)v5);
	  v19 = z_low.m128_f32[0];
	  *(__m128i *)&v37.m_Center.x = _mm_load_si128((const __m128i *)&xmmword_18DC81350);
	  UnityEngine::Gizmos::set_color((Color *)&v37, 0LL);
	  transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
	  if ( !transform )
	LABEL_31:
	    sub_1800D8260(v6, v5);
	  position = UnityEngine::Transform::get_position(&v40.m_Center, transform, 0LL);
	  x = 0.0;
	  v38.z = 0.0;
	  *(_QWORD *)&v38.x = _mm_unpacklo_ps(z_low, (__m128)0LL).m128_u64[0];
	  v23 = *(_QWORD *)&position->x;
	  v24 = (MethodInfo *)position;
	  *(float *)&position = position->z;
	  *(_QWORD *)&v39.x = v23;
	  LODWORD(v39.z) = (_DWORD)position;
	  v25 = UnityEngine::Vector3::op_Addition(&v42[0].m_Center, &v39, &v38, v24);
	  v28 = *(_QWORD *)v27;
	  v29 = 1;
	  v39.y = 0.0;
	  *(_QWORD *)&v41.x = v28;
	  v30 = *(_QWORD *)&v25->x;
	  z = v25->z;
	  v41.z = v27[2];
	  do
	  {
	    Beyond::DampingMath::cosf(v26, x);
	    v39.x = (float)((float)((float)((float)v29 * 0.03125) * 3.1415927)
	                  + (float)((float)((float)v29 * 0.03125) * 3.1415927))
	          * v19;
	    Beyond::DampingMath::sinf(v32, x);
	    x = v39.x;
	    *(_QWORD *)&v38.x = *(_QWORD *)&v39.x;
	    v38.z = (float)((float)((float)((float)v29 * 0.03125) * 3.1415927)
	                  + (float)((float)((float)v29 * 0.03125) * 3.1415927))
	          * v19;
	    v34 = UnityEngine::Vector3::op_Addition(&v37.m_Center, &v41, &v38, v33);
	    *(_QWORD *)&v40.m_Center.x = v30;
	    v40.m_Center.z = z;
	    v36 = v34->z;
	    *(_QWORD *)&v42[0].m_Center.x = *(_QWORD *)&v34->x;
	    v35 = *(_QWORD *)&v42[0].m_Center.x;
	    v42[0].m_Center.z = v36;
	    UnityEngine::Gizmos::DrawLine(&v40.m_Center, &v42[0].m_Center, 0LL);
	    ++v29;
	    v30 = v35;
	    z = v36;
	  }
	  while ( v29 <= 32 );
	}
	
}

