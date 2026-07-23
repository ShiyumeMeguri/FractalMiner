using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGFoliageInteractiveManager // TypeDefIndex: 37694
	{
		// Fields
		private HGFoliageInteractiveConfig m_config; // 0x10
		private Vector3 m_centerPos; // 0x24
		private List<Vector3> m_characterPoses; // 0x30
		private List<HGFoliageInteract> m_externInteracts; // 0x38
		private List<HGFoliageInteractRaft> m_interactRaftList; // 0x40
		private Dictionary<int, HGFoliageInteractiveMeshMatrixes> m_interactMeshMatrixDict; // 0x48
		private Mesh m_characterColliderMesh; // 0x50
		private int m_characterColliderMeshID; // 0x58
		private const float CLEAN_TIME = 60f; // Metadata: 0x0230306E
		private float m_lastCleanTime; // 0x5C
		private bool m_enabled; // 0x60
	
		// Constructors
		public HGFoliageInteractiveManager() {} // 0x0000000182ED7E70-0x0000000182ED7FA0
		// HGFoliageInteractiveManager()
		void HG::Rendering::Runtime::HGFoliageInteractiveManager::HGFoliageInteractiveManager(
		        HGFoliageInteractiveManager *this,
		        MethodInfo *method)
		{
		  HGFoliageInteractiveConfig *defaultConfig; // rax
		  int32_t graphicsFormat; // ecx
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  List_1_HG_Rendering_Runtime_HGFoliageInteract_ *v8; // rdi
		  Type *v9; // rdx
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v12; // rax
		  List_1_HG_Rendering_Runtime_HGFoliageInteractRaft_ *v13; // rdi
		  Type *v14; // rdx
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **v16; // r9
		  Dictionary_2_System_Int32_Beyond_UI_UIText_RichTextAnalyzer_RichTextTag_ *v17; // rax
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ *v18; // rdi
		  Type *v19; // rdx
		  PropertyInfo_1 *v20; // r8
		  Int32__Array **v21; // r9
		  LowLevelList_1_System_Object_ *v22; // rax
		  List_1_UnityEngine_Vector3_ *v23; // rdi
		  Type *v24; // rdx
		  PropertyInfo_1 *v25; // r8
		  Int32__Array **v26; // r9
		  Vector3__StaticFields *static_fields; // rcx
		  float z; // eax
		  HGFoliageInteractiveConfig v29[2]; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( !TypeInfo::HG::Rendering::Runtime::HGFoliageInteractiveConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGFoliageInteractiveConfig);
		  defaultConfig = HG::Rendering::Runtime::HGFoliageInteractiveConfig::get_defaultConfig(v29, 0LL);
		  graphicsFormat = defaultConfig->graphicsFormat;
		  *(_OWORD *)&this->fields.m_config.textureSize.m_X = *(_OWORD *)&defaultConfig->textureSize.m_X;
		  this->fields.m_config.graphicsFormat = graphicsFormat;
		  v5 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteract>);
		  v8 = (List_1_HG_Rendering_Runtime_HGFoliageInteract_ *)v5;
		  if ( !v5 )
		    goto LABEL_4;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v5,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteract>::List);
		  this->fields.m_externInteracts = v8;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_externInteracts,
		    v9,
		    v10,
		    v11,
		    *(MethodInfo **)&v29[0].textureSize);
		  v12 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteractRaft>);
		  v13 = (List_1_HG_Rendering_Runtime_HGFoliageInteractRaft_ *)v12;
		  if ( !v12 )
		    goto LABEL_4;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v12,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteractRaft>::List);
		  this->fields.m_interactRaftList = v13;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_interactRaftList,
		    v14,
		    v15,
		    v16,
		    *(MethodInfo **)&v29[0].textureSize);
		  v17 = (Dictionary_2_System_Int32_Beyond_UI_UIText_RichTextAnalyzer_RichTextTag_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>);
		  v18 = (Dictionary_2_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ *)v17;
		  if ( !v17
		    || (System::Collections::Generic::Dictionary<int,Beyond::UI::UIText_RichTextAnalyzer::RichTextTag>::Dictionary(
		          v17,
		          MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::Dictionary),
		        this->fields.m_interactMeshMatrixDict = v18,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&this->fields.m_interactMeshMatrixDict,
		          v19,
		          v20,
		          v21,
		          *(MethodInfo **)&v29[0].textureSize),
		        v22 = (LowLevelList_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector3>),
		        (v23 = (List_1_UnityEngine_Vector3_ *)v22) == 0LL) )
		  {
		LABEL_4:
		    sub_1800D8260(v7, v6);
		  }
		  System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		    v22,
		    MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::List);
		  this->fields.m_characterPoses = v23;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_characterPoses,
		    v24,
		    v25,
		    v26,
		    *(MethodInfo **)&v29[0].textureSize);
		  static_fields = TypeInfo::UnityEngine::Vector3->static_fields;
		  z = static_fields->negativeInfinityVector.z;
		  *(_QWORD *)&this->fields.m_centerPos.x = *(_QWORD *)&static_fields->negativeInfinityVector.x;
		  this->fields.m_centerPos.z = z;
		}
		
	
		// Methods
		public void Initialize(Mesh characterColliderMesh, HGSettingParameters settingParameters) {} // 0x0000000184B87A10-0x0000000184B87A90
		// Void Initialize(Mesh, HGSettingParameters)
		void HG::Rendering::Runtime::HGFoliageInteractiveManager::Initialize(
		        HGFoliageInteractiveManager *this,
		        Mesh *characterColliderMesh,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  __int64 v10; // rdx
		  Object_1 *m_characterColliderMesh; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *methoda; // [rsp+20h] [rbp-18h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1680, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1680, 0LL);
		    if ( !Patch )
		      goto LABEL_4;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		      (ILFixDynamicMethodWrapper_30 *)Patch,
		      (Object *)this,
		      (Object *)characterColliderMesh,
		      (Object *)settingParameters,
		      0LL);
		  }
		  else
		  {
		    this->fields.m_characterColliderMesh = characterColliderMesh;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_characterColliderMesh, v7, v8, v9, methoda);
		    m_characterColliderMesh = (Object_1 *)this->fields.m_characterColliderMesh;
		    if ( !m_characterColliderMesh
		      || (this->fields.m_characterColliderMeshID = UnityEngine::Object::GetInstanceID(m_characterColliderMesh, 0LL),
		          !settingParameters) )
		    {
		LABEL_4:
		      sub_1800D8260(m_characterColliderMesh, v10);
		    }
		    this->fields.m_enabled = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                               settingParameters->fields._foliageInteractiveEnable_k__BackingField,
		                               MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		  }
		}
		
		public void RefreshFoliageInteractiveSettingParams(HGSettingParameters settingParameters) {} // 0x00000001838B2A90-0x00000001838B2AE0
		// Void RefreshFoliageInteractiveSettingParams(HGSettingParameters)
		void HG::Rendering::Runtime::HGFoliageInteractiveManager::RefreshFoliageInteractiveSettingParams(
		        HGFoliageInteractiveManager *this,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(429, 0LL) )
		  {
		    if ( settingParameters )
		    {
		      this->fields.m_enabled = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                                 settingParameters->fields._foliageInteractiveEnable_k__BackingField,
		                                 MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		      return;
		    }
		LABEL_4:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(429, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)settingParameters,
		    0LL);
		}
		
		public void Dispose() {} // 0x0000000189CF1DC8-0x0000000189CF1F88
		// Void Dispose()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGFoliageInteractiveManager::Dispose(
		        HGFoliageInteractiveManager *this,
		        MethodInfo *method)
		{
		  Object *v2; // rbx
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  __int64 *v5; // rdx
		  Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *monitor; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  __int64 v10; // [rsp+0h] [rbp-C8h] BYREF
		  Il2CppException *ex; // [rsp+20h] [rbp-A8h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ *v12; // [rsp+28h] [rbp-A0h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ v13; // [rsp+30h] [rbp-98h] BYREF
		  Il2CppExceptionWrapper *v14; // [rsp+68h] [rbp-60h] BYREF
		  NativeList_1_UnityEngine_Matrix4x4_ v15; // [rsp+70h] [rbp-58h] BYREF
		  __int64 v16; // [rsp+80h] [rbp-48h]
		  char v17[64]; // [rsp+88h] [rbp-40h] BYREF
		
		  v2 = (Object *)this;
		  memset(&v13, 0, sizeof(v13));
		  if ( IFix::WrappersManagerImpl::IsPatched(1681, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1681, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, v2, 0LL);
		  }
		  else
		  {
		    if ( !v2[4].monitor )
		      sub_1800D8260(v4, v3);
		    v13 = *(Dictionary_2_TKey_TValue_Enumerator_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ *)sub_1803649A8(v17, v2[4].monitor);
		    ex = 0LL;
		    v12 = &v13;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::MoveNext(
		                &v13,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::MoveNext) )
		      {
		        v15 = *(NativeList_1_UnityEngine_Matrix4x4_ *)&v13._current.value.mesh;
		        v16 = *(_QWORD *)&v13._current.value.matrixs.m_DeprecatedAllocator.Index;
		        Unity::Collections::NativeList<UnityEngine::Matrix4x4>::Dispose(
		          (NativeList_1_UnityEngine_Matrix4x4_ *)&v15.m_DeprecatedAllocator,
		          MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::Dispose);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v14 )
		    {
		      v5 = &v10;
		      ex = v14->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v2 = (Object *)this;
		    }
		    monitor = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v2[3].monitor;
		    if ( !monitor
		      || (sub_183127A90(
		            monitor,
		            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteract>::Clear),
		          (monitor = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v2[4].monitor) == 0LL)
		      || (System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::Clear(
		            monitor,
		            MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::Clear),
		          (monitor = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v2[3].klass) == 0LL)
		      || (++HIDWORD(monitor->fields._entries),
		          LODWORD(monitor->fields._entries) = 0,
		          (monitor = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v2[4].klass) == 0LL) )
		    {
		      sub_1800D8250(monitor, v5);
		    }
		    sub_183127A90(
		      monitor,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteractRaft>::Clear);
		  }
		}
		
		public void GetCenter(out Vector3 centerPosition, out Vector3 centerSize) {
			centerPosition = default;
			centerSize = default;
		} // 0x00000001832E4270-0x00000001832E4410
		// Void GetCenter(Vector3 ByRef, Vector3 ByRef)
		void HG::Rendering::Runtime::HGFoliageInteractiveManager::GetCenter(
		        HGFoliageInteractiveManager *this,
		        Vector3 *centerPosition,
		        Vector3 *centerSize,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  __m128 centerOffsetHeight_low; // xmm1
		  Vector3 *v10; // rax
		  float z; // ecx
		  struct HGFoliageInteractiveConfig__Class *v12; // rax
		  HGFoliageInteractiveConfig__StaticFields *static_fields; // rax
		  System::MathF *z_low; // rcx
		  __int64 v15; // xmm7_8
		  float v16; // xmm1_4
		  float v17; // xmm0_4
		  float v18; // xmm6_4
		  float m_Y; // xmm1_4
		  float v20; // xmm0_4
		  System::MathF *v21; // rcx
		  float v22; // xmm2_4
		  float v23; // xmm1_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v25; // [rsp+30h] [rbp-58h] BYREF
		  Vector3 v26; // [rsp+40h] [rbp-48h] BYREF
		  Vector3 v27; // [rsp+50h] [rbp-38h] BYREF
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_8;
		  if ( wrapperArray->max_length.size > 1682 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		    if ( v6 )
		    {
		      if ( LODWORD(v6->_0.namespaze) <= 0x692 )
		        sub_1800D2AB0(v6, centerPosition);
		      if ( !v6[35].vtable.Finalize.methodPtr )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(1682, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_678(Patch, (Object *)this, centerPosition, centerSize, 0LL);
		        return;
		      }
		    }
		LABEL_8:
		    sub_1800D8260(v6, centerPosition);
		  }
		LABEL_5:
		  centerOffsetHeight_low = (__m128)LODWORD(this->fields.m_config.centerOffsetHeight);
		  v26.z = this->fields.m_centerPos.z;
		  *(_QWORD *)&v25.x = _mm_unpacklo_ps((__m128)0LL, centerOffsetHeight_low).m128_u64[0];
		  *(_QWORD *)&v26.x = *(_QWORD *)&this->fields.m_centerPos.x;
		  v25.z = 0.0;
		  v10 = UnityEngine::Vector3::op_Addition(&v27, &v26, &v25, method);
		  z = v10->z;
		  *(_QWORD *)&centerPosition->x = *(_QWORD *)&v10->x;
		  centerPosition->z = z;
		  v12 = TypeInfo::HG::Rendering::Runtime::HGFoliageInteractiveConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGFoliageInteractiveConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGFoliageInteractiveConfig);
		    v12 = TypeInfo::HG::Rendering::Runtime::HGFoliageInteractiveConfig;
		  }
		  static_fields = v12->static_fields;
		  z_low = (System::MathF *)LODWORD(static_fields->FOLIAGE_INTERACTIVE_CENTER_SIZE.z);
		  *(_QWORD *)&centerSize->x = *(_QWORD *)&static_fields->FOLIAGE_INTERACTIVE_CENTER_SIZE.x;
		  LODWORD(centerSize->z) = (_DWORD)z_low;
		  v15 = *(_QWORD *)&centerPosition->x;
		  v16 = centerSize->x / (float)this->fields.m_config.textureSize.m_X;
		  v17 = centerPosition->x / v16;
		  System::MathF::Floor(z_low, v16);
		  v18 = v17 * (float)(centerSize->x / (float)this->fields.m_config.textureSize.m_X);
		  m_Y = (float)this->fields.m_config.textureSize.m_Y;
		  v20 = centerPosition->z / (float)(centerSize->z / m_Y);
		  System::MathF::Floor(v21, m_Y);
		  *(float *)&v15 = v18;
		  v22 = centerSize->z;
		  v23 = (float)this->fields.m_config.textureSize.m_Y;
		  *(_QWORD *)&centerPosition->x = v15;
		  centerPosition->z = v20 * (float)(v22 / v23);
		}
		
		public Dictionary<int, HGFoliageInteractiveMeshMatrixes> GetAllColliders() => default; // 0x0000000189CF1F88-0x0000000189CF1FD8
		// Dictionary`2[System.Int32,HG.Rendering.Runtime.HGFoliageInteractiveMeshMatrixes] GetAllColliders()
		Dictionary_2_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ *HG::Rendering::Runtime::HGFoliageInteractiveManager::GetAllColliders(
		        HGFoliageInteractiveManager *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1683, 0LL) )
		    return this->fields.m_interactMeshMatrixDict;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1683, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_679(Patch, (Object *)this, 0LL);
		}
		
		public void GameplayUpdate() {} // 0x00000001832E29D0-0x00000001832E4270
		// Void GameplayUpdate()
		// Hidden C++ exception states: #wind=3
		void HG::Rendering::Runtime::HGFoliageInteractiveManager::GameplayUpdate(
		        HGFoliageInteractiveManager *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v5; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  MethodInfo *v9; // rdx
		  Quaternion *identity; // rax
		  __m128 v11; // xmm2
		  __m128 v12; // xmm0
		  void (__fastcall *v13)(Mesh **, _BYTE *, __int128 *, Matrix4x4 *); // rax
		  void (__fastcall *v14)(Matrix4x4 *, Matrix4x4 *); // rax
		  Type *v15; // rdx
		  __int64 v16; // rcx
		  PropertyInfo_1 *v17; // r8
		  Int32__Array **v18; // r9
		  __int128 v19; // xmm12
		  __int128 v20; // xmm13
		  __int128 v21; // xmm14
		  __int128 v22; // xmm15
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ *m_interactMeshMatrixDict; // rbx
		  signed __int64 v24; // rcx
		  Int32__Array **v25; // r9
		  unsigned __int64 v26; // rdx
		  unsigned int v27; // eax
		  __int64 v28; // r8
		  PropertyInfo_1 *v29; // r8
		  float v30; // ebx
		  __int128 v31; // xmm6
		  __int64 v32; // xmm7_8
		  Il2CppClass *klass; // rcx
		  Type *v34; // rdx
		  PropertyInfo_1 *v35; // r8
		  Int32__Array **v36; // r9
		  __int64 v37; // rdx
		  unsigned __int64 v38; // xmm1_8
		  HGFoliageInteractiveManager *v39; // r13
		  List_1_HG_Rendering_Runtime_HGFoliageInteract_ *m_externInteracts; // r9
		  unsigned __int64 v41; // rdx
		  signed __int64 v42; // rtt
		  Component *current; // rsi
		  struct Object_1__Class *v44; // rcx
		  Object_1 *v45; // rbx
		  int32_t InstanceID; // eax
		  __int64 v47; // rdx
		  int32_t v48; // edi
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ *v49; // rcx
		  __int64 v50; // rdx
		  __int64 v51; // rcx
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ *v52; // r14
		  Il2CppClass *v53; // rcx
		  Il2CppClass *v54; // rax
		  _QWORD *rgctxDataDummy; // rcx
		  __int64 v56; // rax
		  __int64 v57; // rax
		  __int64 v58; // rbx
		  __int64 v59; // rdx
		  __int64 v60; // rcx
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ *v61; // rdx
		  Transform *transform; // rax
		  __int64 v63; // rdx
		  __int64 v64; // rcx
		  Matrix4x4 *localToWorldMatrix; // rax
		  void (__fastcall *v66)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *); // rax
		  __int64 v67; // rdx
		  UnsafeList_1_UnityEngine_Matrix4x4_ *v68; // rbx
		  Il2CppClass *v69; // rax
		  Mesh *m_characterColliderMesh; // rbx
		  List_1_UnityEngine_Vector3_ *m_characterPoses; // r9
		  signed __int64 v72; // rtt
		  __int64 v73; // rax
		  __int64 v74; // rdx
		  __int64 v75; // rdx
		  __int64 v76; // rcx
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ *v77; // rsi
		  int32_t m_characterColliderMeshID; // r14d
		  struct MethodInfo *v79; // rbx
		  unsigned __int64 v80; // rdx
		  __int64 v81; // rcx
		  signed __int64 v82; // rtt
		  Il2CppClass *v83; // rax
		  float v84; // ebx
		  _QWORD *v85; // rcx
		  __int64 v86; // rax
		  __int64 v87; // rax
		  __int64 v88; // rsi
		  __int64 *v89; // rax
		  __int64 v90; // r13
		  signed __int64 v91; // rcx
		  unsigned int v92; // r8d
		  __int64 v93; // rax
		  __int64 v94; // rax
		  __int64 v95; // rax
		  __int64 *v96; // rax
		  __int64 v97; // r14
		  signed __int64 v98; // rcx
		  unsigned int v99; // r8d
		  __int64 v100; // rax
		  __int64 v101; // rax
		  __int64 v102; // rax
		  _QWORD *v103; // rax
		  __int64 v104; // rax
		  __int64 v105; // rsi
		  _QWORD *v106; // rax
		  __int64 v107; // rcx
		  __int64 v108; // rax
		  __int64 v109; // rsi
		  _QWORD *v110; // rax
		  signed __int64 v111; // rcx
		  unsigned int v112; // r8d
		  __int64 v113; // rax
		  __int64 v114; // rax
		  __int64 v115; // rax
		  __int64 v116; // rsi
		  __int64 v117; // rdx
		  __int64 v118; // rcx
		  __int64 v119; // rdx
		  __int64 v120; // rcx
		  InsertionBehavior__Enum v121; // r9d
		  UnsafeList_1_UnityEngine_Matrix4x4_ *v122; // xmm1_8
		  unsigned __int64 v123; // rsi
		  struct MethodInfo *v124; // rbx
		  Mesh *v125; // r12
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ *v126; // rsi
		  int v127; // r14d
		  struct MethodInfo *v128; // rbx
		  int32_t Entry; // eax
		  __int64 v130; // rdx
		  __int64 v131; // r8
		  Dictionary_2_TKey_TValue_Entry_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes___Array *entries; // rcx
		  double v133; // xmm0_8
		  int v134; // xmm8_4
		  __m128 v135; // xmm0
		  __m128 v136; // xmm7
		  __m128 v137; // xmm0
		  void (__fastcall *v138)(HGFoliageInteractiveMeshMatrixes *, __int128 *, unsigned __int64 *, Matrix4x4 *); // rax
		  __int64 v139; // rdx
		  UnsafeList_1_UnityEngine_Matrix4x4_ *v140; // rbx
		  Il2CppClass *v141; // rax
		  Il2CppClass *v142; // rcx
		  __int64 v143; // rax
		  __int64 v144; // rax
		  __int64 v145; // rax
		  Object *v146; // rax
		  __int64 v147; // rax
		  _BYTE v148[32]; // [rsp+0h] [rbp-408h] BYREF
		  MethodInfo *item4; // [rsp+20h] [rbp-3E8h]
		  HGFoliageInteractiveMeshMatrixes v150; // [rsp+30h] [rbp-3D8h] BYREF
		  HGFoliageInteractiveMeshMatrixes v151; // [rsp+50h] [rbp-3B8h] BYREF
		  _BYTE v152[24]; // [rsp+70h] [rbp-398h] BYREF
		  Matrix4x4 v153; // [rsp+90h] [rbp-378h] BYREF
		  __int128 centerSize; // [rsp+D0h] [rbp-338h] BYREF
		  HGFoliageInteractiveMeshMatrixes centerPosition; // [rsp+E0h] [rbp-328h] BYREF
		  int32_t v156; // [rsp+100h] [rbp-308h]
		  int v157; // [rsp+104h] [rbp-304h]
		  Mesh *mesh; // [rsp+110h] [rbp-2F8h] BYREF
		  int m_ListData; // [rsp+118h] [rbp-2F0h]
		  __int128 v160; // [rsp+120h] [rbp-2E8h] BYREF
		  __int128 v161; // [rsp+130h] [rbp-2D8h]
		  HGFoliageInteractiveMeshMatrixes v162; // [rsp+140h] [rbp-2C8h] BYREF
		  Matrix4x4 v163; // [rsp+160h] [rbp-2A8h] BYREF
		  __int128 v164; // [rsp+1A0h] [rbp-268h] BYREF
		  __m256i v165; // [rsp+1B0h] [rbp-258h] BYREF
		  __int64 v166; // [rsp+1D0h] [rbp-238h]
		  Matrix4x4 value; // [rsp+1E0h] [rbp-228h] BYREF
		  List_1_T_Enumerator_System_Object_ v168; // [rsp+220h] [rbp-1E8h] BYREF
		  HGFoliageInteractiveManager *v169; // [rsp+238h] [rbp-1D0h]
		  unsigned __int64 v170; // [rsp+240h] [rbp-1C8h] BYREF
		  int v171; // [rsp+248h] [rbp-1C0h]
		  Matrix4x4 v172; // [rsp+250h] [rbp-1B8h] BYREF
		  Matrix4x4 v173; // [rsp+290h] [rbp-178h] BYREF
		  Il2CppExceptionWrapper *v174; // [rsp+2D0h] [rbp-138h] BYREF
		  Il2CppExceptionWrapper *v175; // [rsp+2D8h] [rbp-130h] BYREF
		  Il2CppExceptionWrapper *v176; // [rsp+2E0h] [rbp-128h] BYREF
		  Matrix4x4 v177[3]; // [rsp+2E8h] [rbp-120h] BYREF
		  AllocatorManager_AllocatorHandle allocator; // [rsp+420h] [rbp+18h] BYREF
		  AllocatorManager_AllocatorHandle v180; // [rsp+428h] [rbp+20h]
		
		  v169 = this;
		  centerPosition.mesh = 0LL;
		  LODWORD(centerPosition.matrixs.m_ListData) = 0;
		  *(_QWORD *)&centerSize = 0LL;
		  DWORD2(centerSize) = 0;
		  memset(&v151, 0, sizeof(v151));
		  memset(&v168, 0, sizeof(v168));
		  v160 = 0LL;
		  v161 = 0LL;
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v3, method);
		  if ( wrapperArray->max_length.size > 1684 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = v3->static_fields->wrapperArray;
		    if ( !v5 )
		      sub_1800D8260(v3, method);
		    if ( v5->max_length.size <= 0x694u )
		      sub_1800D2AB0(v3, method);
		    if ( v5[46].vector[28] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1684, 0LL);
		      if ( !Patch )
		        sub_1800D8260(v8, v7);
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		  }
		  if ( !this->fields.m_enabled )
		    return;
		  HG::Rendering::Runtime::HGFoliageInteractiveManager::GetCenter(
		    this,
		    (Vector3 *)&centerPosition,
		    (Vector3 *)&centerSize,
		    0LL);
		  identity = UnityEngine::Quaternion::get_identity((Quaternion *)&v150, v9);
		  v11 = (__m128)DWORD1(centerSize);
		  v11.m128_f32[0] = *((float *)&centerSize + 1) * 0.5;
		  v12 = (__m128)(unsigned int)centerSize;
		  v12.m128_f32[0] = *(float *)&centerSize * 0.5;
		  *(_QWORD *)&centerSize = _mm_unpacklo_ps(v12, v11).m128_u64[0];
		  *((float *)&centerSize + 2) = *((float *)&centerSize + 2) * 0.5;
		  *(Quaternion *)v152 = *identity;
		  mesh = centerPosition.mesh;
		  m_ListData = (int)centerPosition.matrixs.m_ListData;
		  memset(&value, 0, sizeof(value));
		  v13 = (void (__fastcall *)(Mesh **, _BYTE *, __int128 *, Matrix4x4 *))qword_18F36FA58;
		  if ( !qword_18F36FA58 )
		  {
		    v13 = (void (__fastcall *)(Mesh **, _BYTE *, __int128 *, Matrix4x4 *))sub_180059EA0(
		                                                                            "UnityEngine.Matrix4x4::TRS_Injected(UnityEng"
		                                                                            "ine.Vector3&,UnityEngine.Quaternion&,UnityEn"
		                                                                            "gine.Vector3&,UnityEngine.Matrix4x4&)");
		    qword_18F36FA58 = (__int64)v13;
		  }
		  v13(&mesh, v152, &centerSize, &value);
		  v163 = value;
		  memset(&v153, 0, sizeof(v153));
		  v14 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))qword_18F36FA60;
		  if ( !qword_18F36FA60 )
		  {
		    v14 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                           "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4"
		                                                           "&,UnityEngine.Matrix4x4&)");
		    if ( !v14 )
		    {
		      v143 = sub_1802EE1B8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
		      sub_18007E1B0(v143, 0LL);
		    }
		    qword_18F36FA60 = (__int64)v14;
		  }
		  v14(&v163, &v153);
		  v19 = *(_OWORD *)&v153.m00;
		  v163 = v153;
		  v20 = *(_OWORD *)&v153.m01;
		  v21 = *(_OWORD *)&v153.m02;
		  v22 = *(_OWORD *)&v153.m03;
		  m_interactMeshMatrixDict = this->fields.m_interactMeshMatrixDict;
		  if ( !m_interactMeshMatrixDict )
		    sub_1800D8260(v16, v15);
		  memset(&v153.m20, 0, 48);
		  *(_QWORD *)&v153.m00 = m_interactMeshMatrixDict;
		  sub_18002D1B0((SingleFieldAccessor *)&v153, v15, v17, v18, item4);
		  LODWORD(v153.m20) = m_interactMeshMatrixDict->fields._version;
		  memset(&v153.m30, 0, 36);
		  LODWORD(v153.m03) = 2;
		  v164 = *(_OWORD *)&v153.m00;
		  memset(&v165, 0, sizeof(v165));
		  v166 = *(_QWORD *)&v153.m03;
		  *(_QWORD *)v152 = 0LL;
		  *(_QWORD *)&v152[8] = &v164;
		  try
		  {
		LABEL_21:
		    v26 = v164;
		    if ( !(_QWORD)v164 )
		      sub_1800D8250(v24, 0LL);
		    if ( DWORD2(v164) != *(_DWORD *)(v164 + 44) )
		      System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
		    v27 = HIDWORD(v164);
		    while ( v27 < *(_DWORD *)(v164 + 32) )
		    {
		      v24 = *(_QWORD *)(v164 + 24);
		      v28 = (int)v27++;
		      HIDWORD(v164) = v27;
		      if ( !v24 )
		        sub_1800D8250(0LL, v164);
		      if ( (unsigned int)v28 >= *(_DWORD *)(v24 + 24) )
		        sub_1800D2AA0(v24, v164, v28);
		      v29 = (PropertyInfo_1 *)(5 * v28);
		      if ( *(int *)(v24 + 8LL * (_QWORD)v29 + 32) >= 0 )
		      {
		        v30 = *(float *)(v24 + 8LL * (_QWORD)v29 + 40);
		        memset(&v153, 0, 32);
		        v31 = *(_OWORD *)(v24 + 8LL * (_QWORD)v29 + 48);
		        v32 = *(_QWORD *)(v24 + 8LL * (_QWORD)v29 + 64);
		        klass = MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::MoveNext->klass;
		        if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
		          sub_1800360B0(klass, v164);
		        v153.m00 = v30;
		        *(_OWORD *)&v153.m20 = v31;
		        *(_QWORD *)&v153.m21 = v32;
		        sub_18002D1B0((SingleFieldAccessor *)&v153.m20, (Type *)v26, v29, v25, item4);
		        v165 = *(__m256i *)&v153.m00;
		        sub_18002D1B0((SingleFieldAccessor *)&v165.m256i_u64[1], v34, v35, v36, item4);
		        v151 = *(HGFoliageInteractiveMeshMatrixes *)&v165.m256i_u64[1];
		        v38 = _mm_srli_si128(*(__m128i *)&v165.m256i_u64[1], 8).m128i_u64[0];
		        v24 = (signed __int64)MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::Clear->klass;
		        if ( (*(_BYTE *)(v24 + 312) & 1) == 0 )
		          sub_1800360B0(v24, v37);
		        *(_DWORD *)(v38 + 8) = 0;
		        goto LABEL_21;
		      }
		    }
		    HIDWORD(v164) = *(_DWORD *)(v164 + 32) + 1;
		    memset(&v165, 0, sizeof(v165));
		  }
		  catch ( Il2CppExceptionWrapper *v174 )
		  {
		    v26 = (unsigned __int64)v148;
		    *(Il2CppExceptionWrapper *)v152 = (Il2CppExceptionWrapper)v174->ex;
		    v24 = *(_QWORD *)v152;
		    if ( *(_QWORD *)v152 )
		      sub_18007E1E0(*(_QWORD *)v152);
		    v22 = *(_OWORD *)&v163.m03;
		    v21 = *(_OWORD *)&v163.m02;
		    v20 = *(_OWORD *)&v163.m01;
		    v19 = *(_OWORD *)&v163.m00;
		  }
		  v39 = this;
		  m_externInteracts = this->fields.m_externInteracts;
		  if ( !m_externInteracts )
		    goto LABEL_210;
		  *(_OWORD *)&v152[8] = 0LL;
		  *(_QWORD *)v152 = m_externInteracts;
		  if ( dword_18F35FD08 )
		  {
		    v41 = (((unsigned __int64)v152 >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F103690[v41]);
		    do
		      v42 = qword_18F103690[v41];
		    while ( v42 != _InterlockedCompareExchange64(
		                     &qword_18F103690[v41],
		                     v42 | (1LL << (((unsigned __int64)v152 >> 12) & 0x3F)),
		                     v42) );
		  }
		  *(_DWORD *)&v152[8] = 0;
		  *(_DWORD *)&v152[12] = m_externInteracts->fields._version;
		  *(_QWORD *)&v152[16] = 0LL;
		  *(_OWORD *)&v168._list = *(_OWORD *)v152;
		  v168._current = 0LL;
		  *(_QWORD *)v152 = 0LL;
		  *(_QWORD *)&v152[8] = &v168;
		  try
		  {
		    while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		              &v168,
		              MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGFoliageInteract>::MoveNext) )
		    {
		      current = (Component *)v168._current;
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
		      if ( current )
		      {
		        if ( !v44->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(v44);
		          v44 = TypeInfo::UnityEngine::Object;
		        }
		        if ( current->fields._.m_CachedPtr )
		        {
		          v45 = (Object_1 *)current[1].klass;
		          if ( !v44->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v44);
		            v44 = TypeInfo::UnityEngine::Object;
		            if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		              v44 = TypeInfo::UnityEngine::Object;
		            }
		          }
		          if ( v45 )
		          {
		            if ( !v44->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(v44);
		            if ( v45->fields.m_CachedPtr )
		            {
		              InstanceID = UnityEngine::Object::GetInstanceID(v45, 0LL);
		              v48 = InstanceID;
		              v49 = this->fields.m_interactMeshMatrixDict;
		              if ( !v49 )
		                sub_1800D8250(0LL, v47);
		              if ( !System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::ContainsKey(
		                      v49,
		                      InstanceID,
		                      MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::ContainsKey) )
		              {
		                v52 = this->fields.m_interactMeshMatrixDict;
		                v151.matrixs.m_ListData = 0LL;
		                *(_QWORD *)&v151.matrixs.m_DeprecatedAllocator.Index = 0LL;
		                v151.mesh = (Mesh *)v45;
		                if ( dword_18F35FD08 )
		                  sub_1802D6370(
		                    0x180000000LL + 8 * ((((unsigned __int64)&v151 >> 12) & 0x1FFFFF) >> 6) + 252720784,
		                    1LL << (((unsigned __int64)&v151 >> 12) & 0x3F));
		                allocator = (AllocatorManager_AllocatorHandle)4;
		                v180 = (AllocatorManager_AllocatorHandle)4;
		                v53 = MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::NativeList->klass;
		                if ( ((__int64)v53->vtable[0].methodPtr & 1) == 0 )
		                {
		                  sub_1800360B0(v53, v50);
		                  v53 = v54;
		                }
		                *(_OWORD *)&v162.mesh = 0LL;
		                allocator = v180;
		                rgctxDataDummy = v53->rgctx_data->rgctxDataDummy;
		                v56 = rgctxDataDummy[4];
		                if ( (*(_BYTE *)(v56 + 312) & 1) == 0 )
		                  sub_1800360B0(rgctxDataDummy[4], v50);
		                v57 = *(_QWORD *)(v56 + 192);
		                v58 = *(_QWORD *)(v57 + 24);
		                if ( !*(_QWORD *)(v58 + 56) )
		                  sub_1800430B0(*(_QWORD *)(v57 + 24));
		                v162.mesh = (Mesh *)Unity::Collections::LowLevel::Unsafe::UnsafeList<UnityEngine::Matrix4x4>::Create<Unity::Collections::AllocatorManager::AllocatorHandle>(
		                                      1,
		                                      &allocator,
		                                      NativeArrayOptions__Enum_UninitializedMemory,
		                                      **(MethodInfo ***)(v58 + 56));
		                LODWORD(v162.matrixs.m_ListData) = allocator;
		                v151.matrixs = *(NativeList_1_UnityEngine_Matrix4x4_ *)&v162.mesh;
		                if ( !v52 )
		                  sub_1800D8250(v60, v59);
		                v150 = v151;
		                v162 = v151;
		                System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::Add(
		                  v52,
		                  v48,
		                  &v162,
		                  MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::Add);
		              }
		              v61 = this->fields.m_interactMeshMatrixDict;
		              if ( !v61 )
		                sub_1800D8250(v51, 0LL);
		              System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::get_Item(
		                &v150,
		                v61,
		                v48,
		                MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::get_Item);
		              v151 = v150;
		              transform = UnityEngine::Component::get_transform(current, 0LL);
		              if ( !transform )
		                sub_1800D8250(v64, v63);
		              localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(v177, transform, 0LL);
		              *(_OWORD *)&v173.m00 = v19;
		              *(_OWORD *)&v173.m01 = v20;
		              *(_OWORD *)&v173.m02 = v21;
		              *(_OWORD *)&v173.m03 = v22;
		              v172 = *localToWorldMatrix;
		              memset(&v153, 0, sizeof(v153));
		              v66 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))qword_18F36FA50;
		              if ( !qword_18F36FA50 )
		              {
		                v66 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                                    "UnityEngine.Matrix4x4::HGMultiplyMat"
		                                                                                    "rix4x4Fast_Injected(UnityEngine.Matr"
		                                                                                    "ix4x4&,UnityEngine.Matrix4x4&,UnityE"
		                                                                                    "ngine.Matrix4x4&)");
		                if ( !v66 )
		                {
		                  v144 = sub_1802EE1B8(
		                           "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Ma"
		                           "trix4x4&,UnityEngine.Matrix4x4&)");
		                  sub_18007E1B0(v144, 0LL);
		                }
		                qword_18F36FA50 = (__int64)v66;
		              }
		              v66(&v173, &v172, &v153);
		              value = v153;
		              v68 = v151.matrixs.m_ListData;
		              v69 = MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::Add->klass;
		              if ( ((__int64)v69->vtable[0].methodPtr & 1) == 0 )
		                sub_1800360B0(MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::Add->klass, v67);
		              Unity::Collections::LowLevel::Unsafe::UnsafeList<UnityEngine::Matrix4x4>::Add(
		                v68,
		                &value,
		                (MethodInfo *)v69->rgctx_data[12].rgctxDataDummy);
		            }
		          }
		        }
		      }
		    }
		  }
		  catch ( Il2CppExceptionWrapper *v175 )
		  {
		    v26 = (unsigned __int64)v148;
		    *(Il2CppExceptionWrapper *)v152 = (Il2CppExceptionWrapper)v175->ex;
		    if ( *(_QWORD *)v152 )
		      sub_18007E1E0(*(_QWORD *)v152);
		    v22 = *(_OWORD *)&v163.m03;
		    v21 = *(_OWORD *)&v163.m02;
		    v20 = *(_OWORD *)&v163.m01;
		    v19 = *(_OWORD *)&v163.m00;
		    v39 = this;
		  }
		  m_characterColliderMesh = v39->fields.m_characterColliderMesh;
		  v24 = (signed __int64)TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v24 = (signed __int64)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v24 = (signed __int64)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !m_characterColliderMesh )
		    goto LABEL_208;
		  if ( !*(_DWORD *)(v24 + 224) )
		    il2cpp_runtime_class_init_1(v24);
		  if ( !m_characterColliderMesh->fields._.m_CachedPtr )
		    goto LABEL_208;
		  m_characterPoses = v39->fields.m_characterPoses;
		  if ( !m_characterPoses )
		LABEL_210:
		    sub_1800D8250(v24, v26);
		  memset(&v153.m20, 0, 24);
		  *(_QWORD *)&v153.m00 = m_characterPoses;
		  if ( dword_18F35FD08 )
		  {
		    v26 = (((unsigned __int64)&v153 >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F103690[v26]);
		    do
		    {
		      v24 = qword_18F103690[v26] | (1LL << (((unsigned __int64)&v153 >> 12) & 0x3F));
		      v72 = qword_18F103690[v26];
		    }
		    while ( v72 != _InterlockedCompareExchange64(&qword_18F103690[v26], v24, v72) );
		  }
		  v153.m20 = 0.0;
		  LODWORD(v153.m30) = m_characterPoses->fields._version;
		  *(_QWORD *)&v153.m01 = 0LL;
		  v153.m21 = 0.0;
		  v160 = *(_OWORD *)&v153.m00;
		  v161 = *(_OWORD *)&v153.m01;
		  *(_QWORD *)v152 = 0LL;
		  *(_QWORD *)&v152[8] = &v160;
		  try
		  {
		    while ( 1 )
		    {
		      v73 = v160;
		      if ( !(_QWORD)v160 )
		        sub_1800D8250(v24, v26);
		      v74 = HIDWORD(v160);
		      if ( HIDWORD(v160) != *(_DWORD *)(v160 + 28) || DWORD2(v160) >= *(_DWORD *)(v160 + 24) )
		        break;
		      v75 = *(_QWORD *)(v160 + 16);
		      if ( !v75 )
		        sub_1800D8250(SDWORD2(v160), 0LL);
		      if ( DWORD2(v160) >= *(_DWORD *)(v75 + 24) )
		        sub_1800D2AA0(
		          SDWORD2(v160),
		          v75,
		          MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::MoveNext);
		      *(_QWORD *)&v161 = *(_QWORD *)(v75 + 12LL * SDWORD2(v160) + 32);
		      v157 = *(_DWORD *)(v75 + 12LL * SDWORD2(v160) + 40);
		      DWORD2(v161) = v157;
		      v76 = (unsigned int)++DWORD2(v160);
		      mesh = (Mesh *)v161;
		      v77 = v39->fields.m_interactMeshMatrixDict;
		      m_characterColliderMeshID = v39->fields.m_characterColliderMeshID;
		      if ( !v77 )
		        sub_1800D8250(v76, v75);
		      v79 = MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::ContainsKey;
		      if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::ContainsKey->klass->rgctx_data[22].rgctxDataDummy
		            + 4) )
		        (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::ContainsKey->klass->rgctx_data[22].rgctxDataDummy)();
		      if ( System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::FindEntry(
		             v77,
		             m_characterColliderMeshID,
		             (MethodInfo *)v79->klass->rgctx_data[22].rgctxDataDummy) < 0 )
		      {
		        *(_QWORD *)&centerSize = v39->fields.m_interactMeshMatrixDict;
		        v156 = v39->fields.m_characterColliderMeshID;
		        v151.matrixs.m_ListData = 0LL;
		        *(_QWORD *)&v151.matrixs.m_DeprecatedAllocator.Index = 0LL;
		        v151.mesh = v39->fields.m_characterColliderMesh;
		        if ( dword_18F35FD08 )
		        {
		          v80 = (((unsigned __int64)&v151 >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F103690[v80]);
		          do
		            v82 = qword_18F103690[v80];
		          while ( v82 != _InterlockedCompareExchange64(
		                           &qword_18F103690[v80],
		                           v82 | (1LL << (((unsigned __int64)&v151 >> 12) & 0x3F)),
		                           v82) );
		        }
		        allocator = (AllocatorManager_AllocatorHandle)4;
		        v180 = (AllocatorManager_AllocatorHandle)4;
		        v83 = MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::NativeList->klass;
		        if ( ((__int64)v83->vtable[0].methodPtr & 1) == 0 )
		          sub_1800360B0(MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::NativeList->klass, v80);
		        *(_OWORD *)&v150.mesh = 0LL;
		        v84 = *(float *)&v180;
		        allocator = v180;
		        v85 = v83->rgctx_data->rgctxDataDummy;
		        v86 = v85[4];
		        if ( (*(_BYTE *)(v86 + 312) & 1) == 0 )
		          sub_1800360B0(v85[4], v80);
		        v87 = *(_QWORD *)(v86 + 192);
		        v88 = *(_QWORD *)(v87 + 24);
		        if ( !*(_QWORD *)(v88 + 56) )
		          sub_1800430B0(*(_QWORD *)(v87 + 24));
		        v89 = *(__int64 **)(v88 + 56);
		        v90 = *v89;
		        if ( !*(_QWORD *)(*v89 + 56) )
		        {
		          v91 = _InterlockedExchangeAdd64(
		                  (volatile signed __int64 *)&TypeInfo::Unity::Collections::AllocatorManager,
		                  0LL);
		          if ( (v91 & 1) != 0 )
		          {
		            v92 = ((unsigned int)v91 >> 1) & 0xFFFFFFF;
		            switch ( (unsigned int)v91 >> 29 )
		            {
		              case 1u:
		                v93 = sub_180036020(v92);
		                goto LABEL_119;
		              case 2u:
		                v93 = sub_1800362C0(v92);
		                goto LABEL_119;
		              case 3u:
		              case 6u:
		                v93 = sub_1802F8920(v91);
		                goto LABEL_119;
		              case 4u:
		                v93 = sub_1802F8760(v92);
		                goto LABEL_119;
		              case 5u:
		                v93 = sub_1802F89F0(v92);
		                goto LABEL_119;
		              case 7u:
		                v94 = sub_1802F8760(v92);
		                v95 = sub_1802F8690(v94);
		                if ( v95 )
		                  v93 = sub_1802F87B0(*(unsigned int *)(v95 + 8));
		                else
		                  v93 = 0LL;
		LABEL_119:
		                if ( v93 )
		                  _InterlockedExchange64((volatile __int64 *)&TypeInfo::Unity::Collections::AllocatorManager, v93);
		                break;
		              default:
		                break;
		            }
		          }
		          if ( !*(_QWORD *)(v90 + 56) )
		            sub_1800430B0(v90);
		        }
		        if ( !TypeInfo::Unity::Collections::AllocatorManager->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::Unity::Collections::AllocatorManager);
		        v96 = *(__int64 **)(v90 + 56);
		        v97 = *v96;
		        if ( !*(_QWORD *)(*v96 + 56) )
		        {
		          v98 = _InterlockedExchangeAdd64(
		                  (volatile signed __int64 *)&TypeInfo::Unity::Collections::AllocatorManager,
		                  0LL);
		          if ( (v98 & 1) != 0 )
		          {
		            v99 = ((unsigned int)v98 >> 1) & 0xFFFFFFF;
		            switch ( (unsigned int)v98 >> 29 )
		            {
		              case 1u:
		                v100 = sub_180036020(v99);
		                goto LABEL_136;
		              case 2u:
		                v100 = sub_1800362C0(v99);
		                goto LABEL_136;
		              case 3u:
		              case 6u:
		                v100 = sub_1802F8920(v98);
		                goto LABEL_136;
		              case 4u:
		                v100 = sub_1802F8760(v99);
		                goto LABEL_136;
		              case 5u:
		                v100 = sub_1802F89F0(v99);
		                goto LABEL_136;
		              case 7u:
		                v101 = sub_1802F8760(v99);
		                v102 = sub_1802F8690(v101);
		                if ( v102 )
		                  v100 = sub_1802F87B0(*(unsigned int *)(v102 + 8));
		                else
		                  v100 = 0LL;
		LABEL_136:
		                if ( v100 )
		                  _InterlockedExchange64((volatile __int64 *)&TypeInfo::Unity::Collections::AllocatorManager, v100);
		                break;
		              default:
		                break;
		            }
		          }
		          if ( !*(_QWORD *)(v97 + 56) )
		            sub_1800430B0(v97);
		        }
		        v103 = *(_QWORD **)(v97 + 56);
		        if ( !*(_QWORD *)(*v103 + 56LL) )
		          sub_1800430B0(*v103);
		        v104 = *(_QWORD *)(v97 + 56);
		        v105 = *(_QWORD *)(v104 + 8);
		        if ( !*(_QWORD *)(v105 + 56) )
		          sub_1800430B0(*(_QWORD *)(v104 + 8));
		        v106 = *(_QWORD **)(v105 + 56);
		        if ( !*(_QWORD *)(*v106 + 56LL) )
		          sub_1800430B0(*v106);
		        v107 = *(_QWORD *)(*(_QWORD *)(v105 + 56) + 8LL);
		        if ( !*(_QWORD *)(v107 + 56) )
		          sub_1800430B0(v107);
		        if ( !TypeInfo::Unity::Collections::AllocatorManager->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::Unity::Collections::AllocatorManager);
		        v108 = *(_QWORD *)(v97 + 56);
		        v109 = *(_QWORD *)(v108 + 16);
		        if ( !*(_QWORD *)(v109 + 56) )
		          sub_1800430B0(*(_QWORD *)(v108 + 16));
		        if ( !TypeInfo::Unity::Collections::AllocatorManager->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::Unity::Collections::AllocatorManager);
		        v110 = *(_QWORD **)(v109 + 56);
		        if ( !*(_QWORD *)(*v110 + 56LL) )
		          sub_1800430B0(*v110);
		        *(_QWORD *)&v153.m00 = 0LL;
		        *(_OWORD *)&v153.m01 = 0LL;
		        LODWORD(v153.m20) = 1;
		        LODWORD(v153.m01) = 32;
		        *(double *)&centerPosition.mesh = 4.503599627370559e15 - 4.503599627370496e15;
		        LOBYTE(v153.m21) = (COERCE__INT64(4.503599627370559e15 - 4.503599627370496e15) >> 52) + 2;
		        v153.m30 = v84;
		        if ( !TypeInfo::Unity::Collections::AllocatorManager->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::Unity::Collections::AllocatorManager);
		        if ( LOWORD(v153.m30) < 0x40u )
		        {
		          if ( !TypeInfo::Unity::Collections::AllocatorManager->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::Unity::Collections::AllocatorManager);
		          Unity::Collections::AllocatorManager::TryLegacy((AllocatorManager_Block *)&v153, 0LL);
		        }
		        else
		        {
		          Unity::Collections::AllocatorManager::AllocatorHandle::get_TableEntry(
		            (AllocatorManager_AllocatorHandle *)&v153.m30,
		            0LL);
		          if ( !TypeInfo::Unity::Collections::AllocatorManager->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::Unity::Collections::AllocatorManager);
		          if ( !byte_18F3A6204 )
		          {
		            v111 = _InterlockedExchangeAdd64(
		                     (volatile signed __int64 *)&TypeInfo::Unity::Collections::AllocatorManager,
		                     0LL);
		            if ( (v111 & 1) != 0 )
		            {
		              v112 = ((unsigned int)v111 >> 1) & 0xFFFFFFF;
		              switch ( (unsigned int)v111 >> 29 )
		              {
		                case 1u:
		                  v113 = sub_180036020(v112);
		                  goto LABEL_172;
		                case 2u:
		                  v113 = sub_1800362C0(v112);
		                  goto LABEL_172;
		                case 3u:
		                case 6u:
		                  v113 = sub_1802F8920(v111);
		                  goto LABEL_172;
		                case 4u:
		                  v113 = sub_1802F8760(v112);
		                  goto LABEL_172;
		                case 5u:
		                  v113 = sub_1802F89F0(v112);
		                  goto LABEL_172;
		                case 7u:
		                  v114 = sub_1802F8760(v112);
		                  v115 = sub_1802F8690(v114);
		                  if ( v115 )
		                    v113 = sub_1802F87B0(*(unsigned int *)(v115 + 8));
		                  else
		                    v113 = 0LL;
		LABEL_172:
		                  if ( v113 )
		                    _InterlockedExchange64((volatile __int64 *)&TypeInfo::Unity::Collections::AllocatorManager, v113);
		                  break;
		                default:
		                  break;
		              }
		            }
		            byte_18F3A6204 = 1;
		          }
		          if ( !TypeInfo::Unity::Collections::AllocatorManager->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::Unity::Collections::AllocatorManager);
		          LODWORD(centerPosition.mesh) = 0;
		          if ( !TypeInfo::Unity::Collections::AllocatorManager->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::Unity::Collections::AllocatorManager);
		          Unity::Collections::AllocatorManager::forward_mono_allocate_block(
		            (AllocatorManager_Block *)&v153,
		            (int32_t *)&centerPosition,
		            0LL);
		        }
		        v116 = *(_QWORD *)&v153.m00;
		        Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemSet(*(Void **)&v153.m00, 0, 32LL, 0LL);
		        if ( !v116 )
		          sub_1800D8250(v118, v117);
		        *(float *)(v116 + 16) = v84;
		        Unity::Collections::LowLevel::Unsafe::UnsafeList<UnityEngine::Matrix4x4>::SetCapacity<Unity::Collections::AllocatorManager::AllocatorHandle>(
		          (UnsafeList_1_UnityEngine_Matrix4x4_ *)v116,
		          &allocator,
		          1,
		          *(MethodInfo **)(*(_QWORD *)(v90 + 56) + 24LL));
		        v150.mesh = (Mesh *)v116;
		        LODWORD(v150.matrixs.m_ListData) = allocator;
		        v122 = (UnsafeList_1_UnityEngine_Matrix4x4_ *)v116;
		        v151.matrixs = *(NativeList_1_UnityEngine_Matrix4x4_ *)&v150.mesh;
		        if ( !(_QWORD)centerSize )
		          sub_1800D8250(v120, v119);
		        v123 = _mm_srli_si128(*(__m128i *)&v150.mesh, 8).m128i_u64[0];
		        v124 = MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::Add;
		        v125 = v151.mesh;
		        if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::Add->klass->rgctx_data[24].rgctxDataDummy
		              + 4) )
		          (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::Add->klass->rgctx_data[24].rgctxDataDummy)();
		        v150.mesh = v125;
		        v150.matrixs.m_ListData = v122;
		        *(_QWORD *)&v150.matrixs.m_DeprecatedAllocator.Index = v123;
		        centerPosition = v150;
		        LOBYTE(v121) = 2;
		        System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::TryInsert(
		          (Dictionary_2_System_Int32_HG_Rendering_Runtime_HGFoliageInteractiveMeshMatrixes_ *)centerSize,
		          v156,
		          &centerPosition,
		          v121,
		          (MethodInfo *)v124->klass->rgctx_data[24].rgctxDataDummy);
		        v39 = this;
		      }
		      v126 = v39->fields.m_interactMeshMatrixDict;
		      v127 = v39->fields.m_characterColliderMeshID;
		      if ( !v126 )
		        sub_1800D8250(v81, v80);
		      v128 = MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::get_Item;
		      if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::get_Item->klass->rgctx_data[22].rgctxDataDummy
		            + 4) )
		        (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::get_Item->klass->rgctx_data[22].rgctxDataDummy)();
		      Entry = System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::FindEntry(
		                v126,
		                v127,
		                (MethodInfo *)v128->klass->rgctx_data[22].rgctxDataDummy);
		      if ( Entry < 0 )
		      {
		        allocator = (AllocatorManager_AllocatorHandle)v127;
		        v145 = sub_1803626F4(v128->klass->rgctx_data, 23LL);
		        v146 = (Object *)il2cpp_value_box(v145, &allocator);
		        System::ThrowHelper::ThrowKeyNotFoundException(v146, 0LL);
		      }
		      entries = v126->fields._entries;
		      if ( !entries )
		        sub_1800D8250(0LL, v130);
		      if ( (unsigned int)Entry >= entries->max_length.size )
		        sub_1800D2AA0(entries, Entry, v131);
		      v151 = entries->vector[Entry].value;
		      v133 = sub_180374774();
		      v134 = LODWORD(v133);
		      v135 = (__m128)HIDWORD(mesh);
		      *(double *)v135.m128_u64 = sub_180374774();
		      v136 = v135;
		      v137 = (__m128)(unsigned int)mesh;
		      *(double *)v137.m128_u64 = sub_180374774();
		      *(_OWORD *)&v150.mesh = 0LL;
		      System::ValueTuple<float,float,float,float>::ValueTuple(
		        (ValueTuple_4_Single_Single_Single_Single_ *)&v150,
		        0.0,
		        0.0,
		        0.0,
		        1.0,
		        0LL);
		      v170 = _mm_unpacklo_ps((__m128)0x3F99999Au, (__m128)0x3F800000u).m128_u64[0];
		      v171 = 1067030938;
		      centerSize = *(_OWORD *)&v150.mesh;
		      v162.mesh = (Mesh *)_mm_unpacklo_ps(v137, v136).m128_u64[0];
		      LODWORD(v162.matrixs.m_ListData) = v134;
		      memset(&v163, 0, sizeof(v163));
		      v138 = (void (__fastcall *)(HGFoliageInteractiveMeshMatrixes *, __int128 *, unsigned __int64 *, Matrix4x4 *))qword_18F36FA58;
		      if ( !qword_18F36FA58 )
		      {
		        v138 = (void (__fastcall *)(HGFoliageInteractiveMeshMatrixes *, __int128 *, unsigned __int64 *, Matrix4x4 *))il2cpp_resolve_icall_1("UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,UnityEngine.Matrix4x4&)");
		        if ( !v138 )
		        {
		          v147 = sub_1802EE1B8(
		                   "UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&"
		                   ",UnityEngine.Matrix4x4&)");
		          sub_18007E1B0(v147, 0LL);
		        }
		        qword_18F36FA58 = (__int64)v138;
		      }
		      v138(&v162, &centerSize, &v170, &v163);
		      v173 = v163;
		      *(_OWORD *)&v172.m00 = v19;
		      *(_OWORD *)&v172.m01 = v20;
		      *(_OWORD *)&v172.m02 = v21;
		      *(_OWORD *)&v172.m03 = v22;
		      value = *UnityEngine::Matrix4x4::op_Multiply(v177, &v172, &v173, 0LL);
		      v140 = v151.matrixs.m_ListData;
		      v141 = MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::Add->klass;
		      if ( ((__int64)v141->vtable[0].methodPtr & 1) == 0 )
		        sub_1800360B0(MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::Add->klass, v139);
		      Unity::Collections::LowLevel::Unsafe::UnsafeList<UnityEngine::Matrix4x4>::Add(
		        v140,
		        &value,
		        (MethodInfo *)v141->rgctx_data[12].rgctxDataDummy);
		    }
		    v142 = MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::MoveNext->klass;
		    if ( ((__int64)v142->vtable[0].methodPtr & 1) == 0 )
		    {
		      sub_1800360B0(v142, HIDWORD(v160));
		      v74 = HIDWORD(v160);
		      v73 = v160;
		    }
		    if ( !v73 )
		      sub_1800D8250(v142, v74);
		    if ( (_DWORD)v74 != *(_DWORD *)(v73 + 28) )
		      System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
		    DWORD2(v160) = *(_DWORD *)(v73 + 24) + 1;
		    *(_QWORD *)&v161 = 0LL;
		    DWORD2(v161) = 0;
		  }
		  catch ( Il2CppExceptionWrapper *v176 )
		  {
		    *(Il2CppExceptionWrapper *)v152 = (Il2CppExceptionWrapper)v176->ex;
		    mono_thread_suspend_all_other_threads(
		      *(_QWORD *)&v152[8],
		      MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::Dispose);
		    if ( *(_QWORD *)v152 )
		      sub_18007E1E0(*(_QWORD *)v152);
		    v39 = this;
		    goto LABEL_208;
		  }
		  mono_thread_suspend_all_other_threads(
		    &v160,
		    MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::Dispose);
		LABEL_208:
		  if ( (float)(UnityEngine::Time::get_realtimeSinceStartup(0LL) - v39->fields.m_lastCleanTime) > 60.0 )
		  {
		    HG::Rendering::Runtime::HGFoliageInteractiveManager::CleanUnusedMesh(v39, 0LL);
		    v39->fields.m_lastCleanTime = UnityEngine::Time::get_realtimeSinceStartup(0LL);
		  }
		}
		
		private void CleanUnusedMesh() {} // 0x00000001843F3CB0-0x00000001843F41B0
		// Void CleanUnusedMesh()
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::HGFoliageInteractiveManager::CleanUnusedMesh(
		        HGFoliageInteractiveManager *this,
		        MethodInfo *method)
		{
		  HGFoliageInteractiveManager *v2; // r15
		  __int64 v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  PropertyInfo_1 *dictionary; // r8
		  unsigned __int64 index; // rdx
		  Dictionary_2_TKey_TValue_Entry_System_UInt32_Beyond_Gameplay_Core_EntityManager_EntityDataStorage_HideByTypeParams___Array *entries; // rax
		  __int64 v11; // rcx
		  Dictionary_2_TKey_TValue_Entry_System_UInt32_Beyond_Gameplay_Core_EntityManager_EntityDataStorage_HideByTypeParams___Array__Class **v12; // r9
		  __int32 v13; // ebx
		  __m128d v14; // xmm0
		  __int64 v15; // xmm1_8
		  Il2CppClass *klass; // rcx
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  __m128d v20; // xmm1
		  HashSet_1_System_UInt64_ *logicIdWhitelist; // rbx
		  Il2CppClass *v22; // rax
		  UnsafeList_1_System_Int32_ *m_ListData; // rsi
		  struct MethodInfo *v24; // rdi
		  Il2CppClass *v25; // rax
		  Il2CppRGCTXData v26; // rbx
		  UnsafeList_1_System_Int32_ *Ptr; // r14
		  __int64 v28; // rcx
		  AllocatorManager_AllocatorHandle m_length; // esi
		  __int64 v30; // rcx
		  Il2CppClass *v31; // rcx
		  int v32; // ebx
		  UnsafeList_1_System_Int32_ *v33; // rdi
		  Il2CppClass *v34; // rax
		  const Il2CppRGCTXData *rgctx_data; // rax
		  __int64 v36; // rdx
		  Dictionary_2_System_Int32_Beyond_Gameplay_GameSettingSystem_KeySettingKeyboardConflictInfo_ *m_interactMeshMatrixDict; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v39; // rdx
		  __int64 v40; // rcx
		  __int64 v41; // [rsp+0h] [rbp-158h] BYREF
		  MethodInfo *methoda; // [rsp+20h] [rbp-138h]
		  NativeList_1_System_Int32_ v43; // [rsp+30h] [rbp-128h] BYREF
		  NativeList_1_System_Int32_ v44; // [rsp+40h] [rbp-118h] BYREF
		  __int64 v45; // [rsp+50h] [rbp-108h]
		  KeyValuePair_2_System_UInt32_Beyond_Gameplay_Core_EntityManager_EntityDataStorage_HideByTypeParams_ v46; // [rsp+58h] [rbp-100h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_UInt32_Beyond_Gameplay_Core_EntityManager_EntityDataStorage_HideByTypeParams_ v47; // [rsp+78h] [rbp-E0h] BYREF
		  Il2CppException *ex; // [rsp+B0h] [rbp-A8h]
		  Dictionary_2_TKey_TValue_Enumerator_System_UInt32_Beyond_Gameplay_Core_EntityManager_EntityDataStorage_HideByTypeParams_ *v49; // [rsp+B8h] [rbp-A0h]
		  __m128d v50; // [rsp+C0h] [rbp-98h]
		  Dictionary_2_TKey_TValue_Enumerator_System_UInt32_Beyond_Gameplay_Core_EntityManager_EntityDataStorage_HideByTypeParams_ v51; // [rsp+D0h] [rbp-88h] BYREF
		  Il2CppExceptionWrapper *v52; // [rsp+108h] [rbp-50h] BYREF
		  Il2CppExceptionWrapper *v53; // [rsp+110h] [rbp-48h] BYREF
		  NativeList_1_UnityEngine_Matrix4x4_ v54; // [rsp+118h] [rbp-40h] BYREF
		  __int64 v55; // [rsp+128h] [rbp-30h]
		  __int64 value; // [rsp+170h] [rbp+18h] BYREF
		  AllocatorManager_AllocatorHandle allocator; // [rsp+178h] [rbp+20h]
		
		  v2 = this;
		  v43 = 0LL;
		  v44 = 0LL;
		  v45 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(1685, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1685, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v40, v39);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v2, 0LL);
		  }
		  else
		  {
		    LODWORD(value) = 2;
		    allocator.Index = 2;
		    allocator.Version = 0;
		    v3 = sub_18011C4C0(MethodInfo::Unity::Collections::NativeList<int>::NativeList->klass);
		    Unity::Collections::NativeList<int>::NativeList(&v43, 16, allocator, 2, **(MethodInfo ***)(v3 + 192));
		    if ( !v2->fields.m_interactMeshMatrixDict )
		      sub_1800D8260(v5, v4);
		    System::Collections::Generic::Dictionary<unsigned int,Beyond::Gameplay::Core::EntityManager_EntityDataStorage::HideByTypeParams>::GetEnumerator(
		      &v51,
		      (Dictionary_2_System_UInt32_Beyond_Gameplay_Core_EntityManager_EntityDataStorage_HideByTypeParams_ *)v2->fields.m_interactMeshMatrixDict,
		      MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::GetEnumerator);
		    v47 = v51;
		    ex = 0LL;
		    v49 = &v47;
		    try
		    {
		      m_ListData = v43.m_ListData;
		LABEL_4:
		      dictionary = (PropertyInfo_1 *)v47._dictionary;
		      if ( !v47._dictionary )
		        sub_1800D8250(v7, v6);
		      if ( v47._version != v47._dictionary->fields._version )
		        System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
		      index = (unsigned int)v47._index;
		      while ( (unsigned int)index < v47._dictionary->fields._count )
		      {
		        entries = v47._dictionary->fields._entries;
		        v11 = (int)index;
		        index = (unsigned int)(index + 1);
		        v47._index = index;
		        if ( !entries )
		          sub_1800D8250(v11, index);
		        if ( (unsigned int)v11 >= entries->max_length.size )
		          sub_1800D2AA0(v11, index, v47._dictionary);
		        v7 = 5 * v11;
		        v12 = &entries->klass + v7;
		        if ( *((int *)v12 + 8) >= 0 )
		        {
		          v13 = *((_DWORD *)v12 + 10);
		          memset(&v46, 0, sizeof(v46));
		          v14 = (__m128d)*((_OWORD *)v12 + 3);
		          v50 = v14;
		          v15 = (__int64)v12[8];
		          value = v15;
		          klass = MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::MoveNext->klass;
		          if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
		          {
		            sub_1800360B0(klass, index);
		            v14 = v50;
		            v15 = value;
		          }
		          v46.key = v13;
		          *(__m128d *)&v46.value.entityTypes = v14;
		          v46.value.identifierWhitelist = (HashSet_1_System_String_ *)v15;
		          sub_18002D1B0((SingleFieldAccessor *)&v46.value, (Type *)index, dictionary, (Int32__Array **)v12, methoda);
		          v47._current = v46;
		          sub_18002D1B0((SingleFieldAccessor *)&v47._current.value, v17, v18, v19, methoda);
		          *(_OWORD *)&v46.key = *(_OWORD *)&v47._current.key;
		          *(_OWORD *)&v51._dictionary = *(_OWORD *)&v47._current.key;
		          v20 = *(__m128d *)&v47._current.value.logicIdWhitelist;
		          v50 = *(__m128d *)&v47._current.value.logicIdWhitelist;
		          *(_OWORD *)&v51._current.key = *(_OWORD *)&v47._current.value.logicIdWhitelist;
		          logicIdWhitelist = v47._current.value.logicIdWhitelist;
		          v7 = (__int64)MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::get_Length->klass;
		          if ( (*(_BYTE *)(v7 + 312) & 1) == 0 )
		          {
		            sub_1800360B0(v7, v6);
		            v20 = v50;
		          }
		          if ( !LODWORD(logicIdWhitelist->monitor) )
		          {
		            if ( *(_QWORD *)&v20.m128d_f64[0] )
		            {
		              v54 = *(NativeList_1_UnityEngine_Matrix4x4_ *)&v51._version;
		              v55 = *(_OWORD *)&_mm_unpackhi_pd(v20, v20);
		              Unity::Collections::NativeList<UnityEngine::Matrix4x4>::Dispose(
		                (NativeList_1_UnityEngine_Matrix4x4_ *)&v54.m_DeprecatedAllocator,
		                MethodInfo::Unity::Collections::NativeList<UnityEngine::Matrix4x4>::Dispose);
		            }
		            LODWORD(value) = _mm_cvtsi128_si32(*(__m128i *)&v46.key);
		            v22 = MethodInfo::Unity::Collections::NativeList<int>::Add->klass;
		            if ( ((__int64)v22->vtable[0].methodPtr & 1) == 0 )
		              sub_1800360B0(MethodInfo::Unity::Collections::NativeList<int>::Add->klass, v6);
		            Unity::Collections::LowLevel::Unsafe::UnsafeList<int>::Add(
		              m_ListData,
		              (int32_t *)&value,
		              (MethodInfo *)v22->rgctx_data[12].rgctxDataDummy);
		          }
		          goto LABEL_4;
		        }
		      }
		      v47._index = v47._dictionary->fields._count + 1;
		      memset(&v47._current, 0, sizeof(v47._current));
		    }
		    catch ( Il2CppExceptionWrapper *v52 )
		    {
		      index = (unsigned __int64)&v41;
		      ex = v52->ex;
		      v7 = (__int64)ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v2 = this;
		      m_ListData = v43.m_ListData;
		    }
		    v24 = MethodInfo::Unity::Collections::NativeList<int>::GetEnumerator;
		    v25 = MethodInfo::Unity::Collections::NativeList<int>::GetEnumerator->klass;
		    if ( ((__int64)v25->vtable[0].methodPtr & 1) == 0 )
		      sub_1800360B0(MethodInfo::Unity::Collections::NativeList<int>::GetEnumerator->klass, index);
		    v26.rgctxDataDummy = v25->rgctx_data[24].rgctxDataDummy;
		    if ( !m_ListData )
		      sub_1800D8250(v7, index);
		    Ptr = (UnsafeList_1_System_Int32_ *)m_ListData->Ptr;
		    v28 = *((_QWORD *)v26.rgctxDataDummy + 4);
		    if ( (*(_BYTE *)(v28 + 312) & 1) == 0 )
		      sub_1800360B0(v28, index);
		    m_length = (AllocatorManager_AllocatorHandle)m_ListData->m_length;
		    v30 = *((_QWORD *)v26.rgctxDataDummy + 4);
		    if ( (*(_BYTE *)(v30 + 312) & 1) == 0 )
		      sub_1800360B0(v30, index);
		    v43.m_ListData = Ptr;
		    v43.m_DeprecatedAllocator = m_length;
		    *((_DWORD *)&v43.m_DeprecatedAllocator + 1) = 1;
		    HIDWORD(v46.value.logicIdWhitelist) = 0;
		    v31 = v24->klass;
		    if ( ((__int64)v31->vtable[0].methodPtr & 1) == 0 )
		      sub_1800360B0(v31, index);
		    v46.value.logicIdWhitelist = (HashSet_1_System_UInt64_ *)0xFFFFFFFFLL;
		    v44 = v43;
		    v45 = 0xFFFFFFFFLL;
		    v43.m_ListData = 0LL;
		    *(_QWORD *)&v43.m_DeprecatedAllocator.Index = &v44;
		    try
		    {
		      while ( 1 )
		      {
		        v32 = v45 + 1;
		        LODWORD(v45) = v32;
		        if ( v32 >= *(_DWORD *)&v44.m_DeprecatedAllocator )
		          break;
		        v33 = v44.m_ListData;
		        v34 = MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<int>::MoveNext->klass;
		        if ( ((__int64)v34->vtable[0].methodPtr & 1) == 0 )
		          sub_1800360B0(v34, index);
		        rgctx_data = v34->rgctx_data;
		        if ( !*((_QWORD *)rgctx_data->rgctxDataDummy + 7) )
		          sub_1800430B0(rgctx_data->rgctxDataDummy);
		        v36 = *((unsigned int *)&v33->Ptr + v32);
		        HIDWORD(v45) = *((_DWORD *)&v33->Ptr + v32);
		        m_interactMeshMatrixDict = (Dictionary_2_System_Int32_Beyond_Gameplay_GameSettingSystem_KeySettingKeyboardConflictInfo_ *)v2->fields.m_interactMeshMatrixDict;
		        if ( !m_interactMeshMatrixDict )
		          sub_1800D8250(0LL, v36);
		        System::Collections::Generic::Dictionary<int,Beyond::Gameplay::GameSettingSystem::KeySettingKeyboardConflictInfo>::Remove(
		          m_interactMeshMatrixDict,
		          v36,
		          MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGFoliageInteractiveMeshMatrixes>::Remove);
		      }
		      HIDWORD(v45) = 0;
		    }
		    catch ( Il2CppExceptionWrapper *v53 )
		    {
		      v43.m_ListData = (UnsafeList_1_System_Int32_ *)v53->ex;
		      if ( v43.m_ListData )
		        sub_18007E1E0(v43.m_ListData);
		    }
		  }
		}
		
		public HGFoliageInteractiveConfig GetConfig() => default; // 0x0000000189CF1FD8-0x0000000189CF2048
		// HGFoliageInteractiveConfig GetConfig()
		HGFoliageInteractiveConfig *HG::Rendering::Runtime::HGFoliageInteractiveManager::GetConfig(
		        HGFoliageInteractiveConfig *__return_ptr retstr,
		        HGFoliageInteractiveManager *this,
		        MethodInfo *method)
		{
		  __int128 v5; // xmm0
		  int32_t graphicsFormat; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  HGFoliageInteractiveConfig *v10; // rax
		  HGFoliageInteractiveConfig v12[2]; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1686, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1686, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_680(v12, Patch, (Object *)this, 0LL);
		    v5 = *(_OWORD *)&v10->textureSize.m_X;
		    graphicsFormat = v10->graphicsFormat;
		  }
		  else
		  {
		    v5 = *(_OWORD *)&this->fields.m_config.textureSize.m_X;
		    graphicsFormat = this->fields.m_config.graphicsFormat;
		  }
		  *(_OWORD *)&retstr->textureSize.m_X = v5;
		  retstr->graphicsFormat = graphicsFormat;
		  return retstr;
		}
		
		public void SetCharacterPositions(List<Vector3> characterPositions) {} // 0x00000001831F81E0-0x00000001831F8240
		// Void SetCharacterPositions(List`1[UnityEngine.Vector3])
		void HG::Rendering::Runtime::HGFoliageInteractiveManager::SetCharacterPositions(
		        HGFoliageInteractiveManager *this,
		        List_1_UnityEngine_Vector3_ *characterPositions,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_UnityEngine_Vector3_ *v6; // rcx
		  List_1_UnityEngine_Vector3_ *m_characterPoses; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1687, 0LL) )
		  {
		    m_characterPoses = this->fields.m_characterPoses;
		    if ( m_characterPoses )
		    {
		      ++m_characterPoses->fields._version;
		      m_characterPoses->fields._size = 0;
		      v6 = this->fields.m_characterPoses;
		      if ( v6 )
		      {
		        System::Collections::Generic::List<UnityEngine::Vector3>::AddRange(
		          v6,
		          (IEnumerable_1_UnityEngine_Vector3_ *)characterPositions,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::AddRange);
		        return;
		      }
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1687, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)characterPositions,
		    0LL);
		}
		
		public void AddInteractToManager(HGFoliageInteract interact) {} // 0x0000000189CF1D58-0x0000000189CF1DC8
		// Void AddInteractToManager(HGFoliageInteract)
		void HG::Rendering::Runtime::HGFoliageInteractiveManager::AddInteractToManager(
		        HGFoliageInteractiveManager *this,
		        HGFoliageInteract *interact,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Object_ *m_externInteracts; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1675, 0LL) )
		  {
		    m_externInteracts = (List_1_System_Object_ *)this->fields.m_externInteracts;
		    if ( m_externInteracts )
		    {
		      sub_182F01190(m_externInteracts, (Object *)interact);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_externInteracts, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1675, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)interact,
		    0LL);
		}
		
		public void AddInteractRaftToManager(HGFoliageInteractRaft raft) {} // 0x0000000189CF1CE8-0x0000000189CF1D58
		// Void AddInteractRaftToManager(HGFoliageInteractRaft)
		void HG::Rendering::Runtime::HGFoliageInteractiveManager::AddInteractRaftToManager(
		        HGFoliageInteractiveManager *this,
		        HGFoliageInteractRaft *raft,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Object_ *m_interactRaftList; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1688, 0LL) )
		  {
		    m_interactRaftList = (List_1_System_Object_ *)this->fields.m_interactRaftList;
		    if ( m_interactRaftList )
		    {
		      sub_182F01190(m_interactRaftList, (Object *)raft);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_interactRaftList, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1688, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)raft,
		    0LL);
		}
		
		public void RemoveInteractFromManager(HGFoliageInteract interact) {} // 0x0000000189CF2048-0x0000000189CF20B8
		// Void RemoveInteractFromManager(HGFoliageInteract)
		void HG::Rendering::Runtime::HGFoliageInteractiveManager::RemoveInteractFromManager(
		        HGFoliageInteractiveManager *this,
		        HGFoliageInteract *interact,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Object_ *m_externInteracts; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1677, 0LL) )
		  {
		    m_externInteracts = (List_1_System_Object_ *)this->fields.m_externInteracts;
		    if ( m_externInteracts )
		    {
		      System::Collections::Generic::List<System::Object>::Remove(
		        m_externInteracts,
		        (Object *)interact,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteract>::Remove);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_externInteracts, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1677, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)interact,
		    0LL);
		}
		
		public void RemoveInteractRaftFromManager(HGFoliageInteractRaft raft) {} // 0x0000000189CF20B8-0x0000000189CF2128
		// Void RemoveInteractRaftFromManager(HGFoliageInteractRaft)
		void HG::Rendering::Runtime::HGFoliageInteractiveManager::RemoveInteractRaftFromManager(
		        HGFoliageInteractiveManager *this,
		        HGFoliageInteractRaft *raft,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Object_ *m_interactRaftList; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1689, 0LL) )
		  {
		    m_interactRaftList = (List_1_System_Object_ *)this->fields.m_interactRaftList;
		    if ( m_interactRaftList )
		    {
		      System::Collections::Generic::List<System::Object>::Remove(
		        m_interactRaftList,
		        (Object *)raft,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteractRaft>::Remove);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_interactRaftList, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1689, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)raft,
		    0LL);
		}
		
		public void SetInterctCenterPosition(Vector3 centerPos) {} // 0x00000001831CC1E0-0x00000001831CC240
		// Void SetInterctCenterPosition(Vector3)
		void HG::Rendering::Runtime::HGFoliageInteractiveManager::SetInterctCenterPosition(
		        HGFoliageInteractiveManager *this,
		        Vector3 *centerPos,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 v8; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1690, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1690, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v5);
		    z = centerPos->z;
		    *(_QWORD *)&v8.x = *(_QWORD *)&centerPos->x;
		    v8.z = z;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_370(Patch, (Object *)this, &v8, 0LL);
		  }
		  else
		  {
		    if ( fabs(this->fields.m_centerPos.y - centerPos->y) > 0.2 )
		      this->fields.m_centerPos.y = centerPos->y;
		    this->fields.m_centerPos.x = centerPos->x;
		    this->fields.m_centerPos.z = centerPos->z;
		  }
		}
		
		public void SetupShaderVariablesGlobalFoliageInteract(ref ShaderVariablesGlobal cb) {} // 0x00000001834A03C0-0x00000001834A0530
		// Void SetupShaderVariablesGlobalFoliageInteract(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::HGFoliageInteractiveManager::SetupShaderVariablesGlobalFoliageInteract(
		        HGFoliageInteractiveManager *this,
		        ShaderVariablesGlobal *cb,
		        MethodInfo *method)
		{
		  List_1_System_Object_ *m_interactRaftList; // rcx
		  __int64 v6; // r8
		  __m128 x_low; // xmm6
		  float x; // xmm7_4
		  float y; // xmm8_4
		  float CapsuleProxyRadius; // xmm12_4
		  float z; // xmm9_4
		  float v12; // xmm10_4
		  float v13; // xmm11_4
		  __m128 v14; // xmm6
		  __m128 v15; // xmm6
		  __m128 v16; // xmm6
		  __m128 v17; // xmm6
		  __m128 v18; // xmm1
		  __m128 v19; // xmm1
		  __m128 v20; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Object *Item; // rsi
		  Object *v23; // rax
		  Vector3 *CapsuleProxyPositionA; // rax
		  Object *v25; // rax
		  Vector3 *CapsuleProxyPositionB; // rax
		  __int64 v27; // xmm0_8
		  Object *v28; // rax
		  Vector3 v29; // [rsp+20h] [rbp-A8h]
		  Vector3 v30; // [rsp+30h] [rbp-98h] BYREF
		  __m128 v31; // [rsp+40h] [rbp-88h] BYREF
		
		  m_interactRaftList = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    m_interactRaftList = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = **(_QWORD **)&m_interactRaftList[4].fields._size;
		  if ( !v6 )
		    goto LABEL_8;
		  if ( *(int *)(v6 + 24) <= 940 )
		    goto LABEL_5;
		  if ( !m_interactRaftList[5].fields._size )
		  {
		    il2cpp_runtime_class_init_1(m_interactRaftList);
		    m_interactRaftList = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  m_interactRaftList = **(List_1_System_Object_ ***)&m_interactRaftList[4].fields._size;
		  if ( !m_interactRaftList )
		    goto LABEL_8;
		  if ( m_interactRaftList->fields._size <= 0x3ACu )
		    sub_1800D2AB0(m_interactRaftList, cb);
		  if ( !m_interactRaftList[188].fields._syncRoot )
		  {
		LABEL_5:
		    x_low = (__m128)0x461C4000u;
		    x = 10001.0;
		    y = 10000.0;
		    CapsuleProxyRadius = 0.001;
		    z = 10000.0;
		    v12 = 10000.0;
		    v13 = 10001.0;
		    if ( !this->fields.m_interactRaftList || this->fields.m_interactRaftList->fields._size <= 0 )
		      goto LABEL_7;
		    Item = System::Collections::Generic::List<System::Object>::get_Item(
		             (List_1_System_Object_ *)this->fields.m_interactRaftList,
		             0,
		             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteractRaft>::get_Item);
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Inequality((Object_1 *)Item, 0LL, 0LL) )
		      goto LABEL_7;
		    m_interactRaftList = (List_1_System_Object_ *)this->fields.m_interactRaftList;
		    if ( m_interactRaftList )
		    {
		      v23 = System::Collections::Generic::List<System::Object>::get_Item(
		              m_interactRaftList,
		              0,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteractRaft>::get_Item);
		      if ( v23 )
		      {
		        CapsuleProxyPositionA = HG::Rendering::Runtime::HGFoliageInteractRaft::GetCapsuleProxyPositionA(
		                                  &v30,
		                                  (HGFoliageInteractRaft *)v23,
		                                  0LL);
		        m_interactRaftList = (List_1_System_Object_ *)this->fields.m_interactRaftList;
		        v29 = *CapsuleProxyPositionA;
		        if ( m_interactRaftList )
		        {
		          v25 = System::Collections::Generic::List<System::Object>::get_Item(
		                  m_interactRaftList,
		                  0,
		                  MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteractRaft>::get_Item);
		          if ( v25 )
		          {
		            CapsuleProxyPositionB = HG::Rendering::Runtime::HGFoliageInteractRaft::GetCapsuleProxyPositionB(
		                                      (Vector3 *)&v31,
		                                      (HGFoliageInteractRaft *)v25,
		                                      0LL);
		            m_interactRaftList = (List_1_System_Object_ *)this->fields.m_interactRaftList;
		            v27 = *(_QWORD *)&CapsuleProxyPositionB->x;
		            *(float *)&CapsuleProxyPositionB = CapsuleProxyPositionB->z;
		            *(_QWORD *)&v30.x = v27;
		            LODWORD(v30.z) = (_DWORD)CapsuleProxyPositionB;
		            if ( m_interactRaftList )
		            {
		              v28 = System::Collections::Generic::List<System::Object>::get_Item(
		                      m_interactRaftList,
		                      0,
		                      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGFoliageInteractRaft>::get_Item);
		              if ( v28 )
		              {
		                z = v29.z;
		                CapsuleProxyRadius = HG::Rendering::Runtime::HGFoliageInteractRaft::GetCapsuleProxyRadius(
		                                       (HGFoliageInteractRaft *)v28,
		                                       0LL);
		                y = v29.y;
		                x_low = (__m128)LODWORD(v29.x);
		                v13 = v30.z;
		                v12 = v30.y;
		                x = v30.x;
		LABEL_7:
		                v14 = _mm_shuffle_ps(x_low, x_low, 225);
		                v14.m128_f32[0] = y;
		                v15 = _mm_shuffle_ps(v14, v14, 198);
		                v15.m128_f32[0] = z;
		                v16 = _mm_shuffle_ps(v15, v15, 39);
		                v16.m128_f32[0] = CapsuleProxyRadius;
		                v17 = _mm_shuffle_ps(v16, v16, 57);
		                v31 = v17;
		                v31.m128_i32[3] = 0;
		                v18 = v31;
		                *(__m128 *)&cb[1]._PrevFoliageInteractiveParams0.w = v17;
		                v18.m128_f32[0] = x;
		                v19 = _mm_shuffle_ps(v18, v18, 225);
		                v19.m128_f32[0] = v12;
		                v20 = _mm_shuffle_ps(v19, v19, 198);
		                v20.m128_f32[0] = v13;
		                *(__m128 *)&cb[1]._AtmosphereFogParams0.w = _mm_shuffle_ps(v20, v20, 201);
		                return;
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_8:
		    sub_1800D8260(m_interactRaftList, cb);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(940, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, cb, 0LL);
		}
		
	}
}
