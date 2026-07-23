using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Beyond;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class VolumetricCloudSDF : VolumetricRenderObject, IVolumetricCloudVolume // TypeDefIndex: 38713
	{
		// Fields
		public Material m_CloudMat; // 0x38
		public VolumetricSdfAsset m_CloudAsset; // 0x40
		private VolumetricEncodedTexture DensityTextureToUse; // 0x48
		private VolumetricEncodedTexture AdvancedTextureToUse; // 0x50
		private VolumetricEncodedTexture SHTextureToUse; // 0x58
		private Vector3 m_WindPhase; // 0x60
		private Vector3 m_WindPhase2; // 0x6C
		private Vector3 m_WindPhase3; // 0x78
		private Vector3 m_WindOffset; // 0x84
		private Vector3 m_WindOffset2; // 0x90
		private Vector3 m_WindOffset3; // 0x9C
		private GameObject m_CloudObject; // 0xA8
		public bool m_DrawNear; // 0xB0
		public bool m_DrawFar; // 0xB1
		public int m_msBakeSizeX; // 0xB4
		public int m_msBakeSizeY; // 0xB8
		private VolumetricMSBake m_MSBaker; // 0xC0
		private Dictionary<int, VolumetricFarCloudRenderer> farRenderers; // 0xC8
		private static List<int> farRenderersToDelete; // 0x00
		private float m_MaxExtent; // 0xD0
		private Vector3 m_VoxelSize; // 0xD4
		private Vector3 m_InvScale; // 0xE0
		private Vector3 m_MainLightDirection; // 0xEC
		private Matrix4x4 m_CloudRenderWorldToLocal; // 0xF8
		private Matrix4x4 m_CloudRenderLocalToWorld; // 0x138
		private float m_OpticalDepthScale; // 0x178
		private float m_InvOpticalDepthScale; // 0x17C
		private bool m_inside; // 0x180
		private MaterialPropertyBlock m_propertyBlock; // 0x188
		private MaterialPropertyBlock m_composePropertyBlock; // 0x190
		private MaterialPropertyBlock m_emptySkipPropertyBlock; // 0x198
		private List<VolumetricWindFieldNode> m_WindFieldNodeList; // 0x1A0
		private VolumetricWindFieldManager m_WindFieldManager; // 0x1A8
		[SerializeField]
		private BeyondPolyLineShape _polyLineShape; // 0x1B0
		public int m_VolumePriority; // 0x1B8
		[NonSerialized]
		public bool m_ForceVisible; // 0x1BC
		private Dictionary<int, bool> _visibleStates; // 0x1C0
		private Dictionary<int, bool> _loadingStates; // 0x1C8
		private Dictionary<int, bool> _fadeInStates; // 0x1D0
		private Vector3 lastCameraPosition; // 0x1D8
		private Quaternion lastCameraRotation; // 0x1E4
		private List<MeshRenderer> _renderers; // 0x1F8
		private const int DISABLE_FAR_CLOUD_SHADER_LOD = 600; // Metadata: 0x023040B0
		private bool bLastPanoramic; // 0x200
		private bool bLastOctahedron; // 0x201
		private bool bLastSemicircular; // 0x202
	
		// Properties
		private bool IsCloudSdfAssetValid { get => default; } // 0x0000000183C527A0-0x0000000183C52850 
		// Boolean get_IsCloudSdfAssetValid()
		bool HG::Rendering::Runtime::VolumetricCloudSDF::get_IsCloudSdfAssetValid(VolumetricCloudSDF *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  struct Object_1__Class *v4; // rcx
		  VolumetricSdfAsset *m_CloudAsset; // rbx
		  VolumetricSdfAsset *v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5002, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5002, 0LL);
		    if ( !Patch )
		      goto LABEL_12;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v4 = TypeInfo::UnityEngine::Object;
		    m_CloudAsset = this->fields.m_CloudAsset;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v4 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v4 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( m_CloudAsset )
		    {
		      if ( !v4->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v4);
		      if ( m_CloudAsset->fields._._.m_CachedPtr )
		      {
		        v6 = this->fields.m_CloudAsset;
		        if ( v6 )
		          return HG::Rendering::Runtime::VolumetricSdfAsset::get_IsValid(v6, 0LL);
		LABEL_12:
		        sub_1800D8260(v6, v3);
		      }
		    }
		    return 0;
		  }
		}
		
		public BeyondPolyLineShape PolyLineShape { get => default; set {} } // 0x0000000189C4BD8C-0x0000000189C4BDDC 0x000000018412BC90-0x000000018412BCE0
		// BeyondPolyLineShape get_PolyLineShape()
		BeyondPolyLineShape *HG::Rendering::Runtime::VolumetricCloudSDF::get_PolyLineShape(
		        VolumetricCloudSDF *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5010, 0LL) )
		    return this->fields._polyLineShape;
		  Patch = IFix::WrappersManagerImpl::GetPatch(5010, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_252(Patch, (Object *)this, 0LL);
		}
		

		// Void set_PolyLineShape(BeyondPolyLineShape)
		void HG::Rendering::Runtime::VolumetricCloudSDF::set_PolyLineShape(
		        VolumetricCloudSDF *this,
		        BeyondPolyLineShape *value,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5011, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5011, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)value,
		      0LL);
		  }
		  else
		  {
		    this->fields._polyLineShape = value;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._polyLineShape, v5, v6, v7, v11);
		  }
		}
		
		public int volumePriority { get => default; } // 0x0000000189C4BDDC-0x0000000189C4BE2C 
		// Int32 get_volumePriority()
		int32_t HG::Rendering::Runtime::VolumetricCloudSDF::get_volumePriority(VolumetricCloudSDF *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3452, 0LL) )
		    return this->fields.m_VolumePriority;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3452, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public bool HasComposeOverride { get => default; } // 0x0000000189C4BC60-0x0000000189C4BD10 
		// Boolean get_HasComposeOverride()
		bool HG::Rendering::Runtime::VolumetricCloudSDF::get_HasComposeOverride(VolumetricCloudSDF *this, MethodInfo *method)
		{
		  Object_1 *m_CloudMat; // rbx
		  bool result; // al
		  Material *v5; // rbx
		  __int64 v6; // rcx
		  VolumetricShaderIDs__StaticFields *static_fields; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3451, 0LL) )
		  {
		    m_CloudMat = (Object_1 *)this->fields.m_CloudMat;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    result = UnityEngine::Object::op_Inequality(m_CloudMat, 0LL, 0LL);
		    if ( !result )
		      return result;
		    v5 = this->fields.m_CloudMat;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		    static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		    if ( v5 )
		      return UnityEngine::Material::GetFloatImpl(v5, static_fields->_ComposeOverride, 0LL) > 0.5;
		LABEL_6:
		    sub_1800D8260(v6, static_fields);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3451, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		private bool IsWindField { get => default; } // 0x0000000189C4BD10-0x0000000189C4BD8C 
		// Boolean get_IsWindField()
		bool HG::Rendering::Runtime::VolumetricCloudSDF::get_IsWindField(VolumetricCloudSDF *this, MethodInfo *method)
		{
		  Material *m_CloudMat; // rbx
		  __int64 v4; // rcx
		  VolumetricShaderKeywords__StaticFields *static_fields; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5103, 0LL) )
		  {
		    m_CloudMat = this->fields.m_CloudMat;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		    static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields;
		    if ( m_CloudMat )
		      return UnityEngine::Material::IsKeywordEnabled(m_CloudMat, static_fields->s_WindField, 0LL);
		LABEL_5:
		    sub_1800D8260(v4, static_fields);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5103, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		protected override bool HasVolumetricRenderItem { get => default; } // 0x0000000183CE6E40-0x0000000183CE6EA0 
		// Boolean get_HasVolumetricRenderItem()
		bool HG::Rendering::Runtime::VolumetricCloudSDF::get_HasVolumetricRenderItem(
		        VolumetricCloudSDF *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 5104 )
		    return 1;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x13F0 )
		    sub_1800D2AB0(v3, method);
		  if ( !*(_QWORD *)&v3[108]._1.element_size )
		    return 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(5104, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Nested types
		public enum EViewMode // TypeDefIndex: 38708
		{
			None = 0,
			Mesh = 1,
			SDF = 2,
			Cloud = 3
		}
	
		public enum ECompressMode // TypeDefIndex: 38709
		{
			None = 0,
			ASTC4x4 = 1,
			ASTC8x8 = 2
		}
	
		// Constructors
		public VolumetricCloudSDF() {} // 0x00000001842EDB40-0x00000001842EDE70
		// VolumetricCloudSDF()
		void HG::Rendering::Runtime::VolumetricCloudSDF::VolumetricCloudSDF(VolumetricCloudSDF *this, MethodInfo *method)
		{
		  VolumetricMSBake *v3; // rax
		  HGRuntimeGrassQuery_Node *v4; // rdx
		  __int64 v5; // rcx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  Dictionary_2_System_Int32_System_Object_ *v8; // rax
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_VolumetricFarCloudRenderer_ *v9; // rdi
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  Matrix4x4__StaticFields *static_fields; // rcx
		  __int128 v14; // xmm1
		  __int128 v15; // xmm2
		  __int128 v16; // xmm3
		  Matrix4x4__StaticFields *v17; // rcx
		  __int128 v18; // xmm0
		  __int128 v19; // xmm1
		  __int128 v20; // xmm2
		  __int128 v21; // xmm3
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v22; // rax
		  List_1_HG_Rendering_Runtime_VolumetricWindFieldNode_ *v23; // rdi
		  HGRuntimeGrassQuery_Node *v24; // rdx
		  HGRuntimeGrassQuery_Node *v25; // r8
		  Int32__Array **v26; // r9
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_TierValue_ *v27; // rax
		  Dictionary_2_System_Int32_System_Boolean_ *v28; // rdi
		  HGRuntimeGrassQuery_Node *v29; // rdx
		  HGRuntimeGrassQuery_Node *v30; // r8
		  Int32__Array **v31; // r9
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_TierValue_ *v32; // rax
		  Dictionary_2_System_Int32_System_Boolean_ *v33; // rdi
		  HGRuntimeGrassQuery_Node *v34; // rdx
		  HGRuntimeGrassQuery_Node *v35; // r8
		  Int32__Array **v36; // r9
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_TierValue_ *v37; // rax
		  Dictionary_2_System_Int32_System_Boolean_ *v38; // rdi
		  HGRuntimeGrassQuery_Node *v39; // rdx
		  HGRuntimeGrassQuery_Node *v40; // r8
		  Int32__Array **v41; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v42; // rax
		  List_1_UnityEngine_MeshRenderer_ *v43; // rdi
		  HGRuntimeGrassQuery_Node *v44; // rdx
		  HGRuntimeGrassQuery_Node *v45; // r8
		  Int32__Array **v46; // r9
		  MethodInfo *v47; // [rsp+20h] [rbp-18h]
		  MethodInfo *v48; // [rsp+20h] [rbp-18h]
		  MethodInfo *v49; // [rsp+20h] [rbp-18h]
		  MethodInfo *v50; // [rsp+20h] [rbp-18h]
		  MethodInfo *v51; // [rsp+20h] [rbp-18h]
		  MethodInfo *v52; // [rsp+20h] [rbp-18h]
		  MethodInfo *v53; // [rsp+20h] [rbp-18h]
		
		  *(_QWORD *)&this->fields.m_WindPhase.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  this->fields.m_WindPhase.z = 0.0;
		  *(_QWORD *)&this->fields.m_WindPhase2.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  this->fields.m_WindPhase2.z = 0.0;
		  *(_QWORD *)&this->fields.m_WindPhase3.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  this->fields.m_WindPhase3.z = 0.0;
		  *(_QWORD *)&this->fields.m_WindOffset.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  this->fields.m_WindOffset.z = 0.0;
		  *(_QWORD *)&this->fields.m_WindOffset2.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  this->fields.m_WindOffset2.z = 0.0;
		  *(_WORD *)&this->fields.m_DrawNear = 257;
		  *(_QWORD *)&this->fields.m_WindOffset3.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  this->fields.m_WindOffset3.z = 0.0;
		  this->fields.m_msBakeSizeX = 16;
		  this->fields.m_msBakeSizeY = 64;
		  v3 = (VolumetricMSBake *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::VolumetricMSBake);
		  if ( !v3 )
		    goto LABEL_10;
		  this->fields.m_MSBaker = v3;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_MSBaker, v4, v6, v7, v47);
		  v8 = (Dictionary_2_System_Int32_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>);
		  v9 = (Dictionary_2_System_Int32_HG_Rendering_Runtime_VolumetricFarCloudRenderer_ *)v8;
		  if ( !v8 )
		    goto LABEL_10;
		  System::Collections::Generic::Dictionary<int,System::Object>::Dictionary(
		    v8,
		    MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::Dictionary);
		  this->fields.farRenderers = v9;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.farRenderers, v10, v11, v12, v48);
		  *(_QWORD *)&this->fields.m_VoxelSize.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		  this->fields.m_VoxelSize.z = 1.0;
		  *(_QWORD *)&this->fields.m_InvScale.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		  this->fields.m_InvScale.z = 1.0;
		  *(_QWORD *)&this->fields.m_MainLightDirection.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		  this->fields.m_MainLightDirection.z = 0.0;
		  static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		  v14 = *(_OWORD *)&static_fields->identityMatrix.m01;
		  v15 = *(_OWORD *)&static_fields->identityMatrix.m02;
		  v16 = *(_OWORD *)&static_fields->identityMatrix.m03;
		  *(_OWORD *)&this->fields.m_CloudRenderWorldToLocal.m00 = *(_OWORD *)&static_fields->identityMatrix.m00;
		  *(_OWORD *)&this->fields.m_CloudRenderWorldToLocal.m01 = v14;
		  *(_OWORD *)&this->fields.m_CloudRenderWorldToLocal.m02 = v15;
		  *(_OWORD *)&this->fields.m_CloudRenderWorldToLocal.m03 = v16;
		  v17 = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		  v18 = *(_OWORD *)&v17->identityMatrix.m00;
		  v19 = *(_OWORD *)&v17->identityMatrix.m01;
		  v20 = *(_OWORD *)&v17->identityMatrix.m02;
		  v21 = *(_OWORD *)&v17->identityMatrix.m03;
		  this->fields.m_OpticalDepthScale = 1.0;
		  *(_OWORD *)&this->fields.m_CloudRenderLocalToWorld.m00 = v18;
		  this->fields.m_InvOpticalDepthScale = 1.0;
		  *(_OWORD *)&this->fields.m_CloudRenderLocalToWorld.m01 = v19;
		  *(_OWORD *)&this->fields.m_CloudRenderLocalToWorld.m02 = v20;
		  *(_OWORD *)&this->fields.m_CloudRenderLocalToWorld.m03 = v21;
		  v22 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricWindFieldNode>);
		  v23 = (List_1_HG_Rendering_Runtime_VolumetricWindFieldNode_ *)v22;
		  if ( !v22 )
		    goto LABEL_10;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v22,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricWindFieldNode>::List);
		  this->fields.m_WindFieldNodeList = v23;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_WindFieldNodeList, v24, v25, v26, v49);
		  v27 = (Dictionary_2_System_Int32_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_TierValue_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<int,bool>);
		  v28 = (Dictionary_2_System_Int32_System_Boolean_ *)v27;
		  if ( !v27 )
		    goto LABEL_10;
		  System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::Dictionary(
		    v27,
		    MethodInfo::System::Collections::Generic::Dictionary<int,bool>::Dictionary);
		  this->fields._visibleStates = v28;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._visibleStates, v29, v30, v31, v50);
		  v32 = (Dictionary_2_System_Int32_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_TierValue_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<int,bool>);
		  v33 = (Dictionary_2_System_Int32_System_Boolean_ *)v32;
		  if ( !v32 )
		    goto LABEL_10;
		  System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::Dictionary(
		    v32,
		    MethodInfo::System::Collections::Generic::Dictionary<int,bool>::Dictionary);
		  this->fields._loadingStates = v33;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._loadingStates, v34, v35, v36, v51);
		  v37 = (Dictionary_2_System_Int32_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_TierValue_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<int,bool>);
		  v38 = (Dictionary_2_System_Int32_System_Boolean_ *)v37;
		  if ( !v37
		    || (System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::Dictionary(
		          v37,
		          MethodInfo::System::Collections::Generic::Dictionary<int,bool>::Dictionary),
		        this->fields._fadeInStates = v38,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._fadeInStates, v39, v40, v41, v52),
		        v42 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<UnityEngine::MeshRenderer>),
		        (v43 = (List_1_UnityEngine_MeshRenderer_ *)v42) == 0LL) )
		  {
		LABEL_10:
		    sub_1800D8260(v5, v4);
		  }
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v42,
		    MethodInfo::System::Collections::Generic::List<UnityEngine::MeshRenderer>::List);
		  this->fields._renderers = v43;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._renderers, v44, v45, v46, v53);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
		static VolumetricCloudSDF() {} // 0x0000000184D56050-0x0000000184D560B0
		// VolumetricCloudSDF()
		void HG::Rendering::Runtime::VolumetricCloudSDF::cctor(MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  List_1_System_Int32_ *v4; // rbx
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  MethodInfo *v8; // [rsp+50h] [rbp+28h]
		
		  v1 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<int>);
		  v4 = (List_1_System_Int32_ *)v1;
		  if ( !v1 )
		    sub_1800D8260(v3, v2);
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v1,
		    MethodInfo::System::Collections::Generic::List<int>::List);
		  TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF->static_fields->farRenderersToDelete = v4;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF->static_fields,
		    v5,
		    v6,
		    v7,
		    v8);
		}
		
	
		// Methods
		public void AddWindFieldNode(VolumetricWindFieldNode node) {} // 0x000000018412BC30-0x000000018412BC90
		// Void AddWindFieldNode(VolumetricWindFieldNode)
		void HG::Rendering::Runtime::VolumetricCloudSDF::AddWindFieldNode(
		        VolumetricCloudSDF *this,
		        VolumetricWindFieldNode *node,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Object_ *m_WindFieldNodeList; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5005, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5005, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)node,
		        0LL);
		      return;
		    }
		    goto LABEL_6;
		  }
		  if ( !node )
		    return;
		  m_WindFieldNodeList = (List_1_System_Object_ *)this->fields.m_WindFieldNodeList;
		  if ( !m_WindFieldNodeList )
		LABEL_6:
		    sub_1800D8260(m_WindFieldNodeList, v5);
		  sub_182F01190(m_WindFieldNodeList, (Object *)node);
		}
		
		public void AddWindField(VolumetricWindField windField) {} // 0x0000000189C474F4-0x0000000189C47568
		// Void AddWindField(VolumetricWindField)
		void HG::Rendering::Runtime::VolumetricCloudSDF::AddWindField(
		        VolumetricCloudSDF *this,
		        VolumetricWindField *windField,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5006, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5006, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)windField,
		      0LL);
		  }
		  else if ( this->fields.m_WindFieldManager )
		  {
		    HG::Rendering::Runtime::VolumetricWindFieldManager::AddWindField(
		      this->fields.m_WindFieldManager,
		      (IVolumetricWindField *)windField,
		      0LL);
		  }
		}
		
		public void RemoveWindField(VolumetricWindField windField) {} // 0x0000000189C49774-0x0000000189C497E8
		// Void RemoveWindField(VolumetricWindField)
		void HG::Rendering::Runtime::VolumetricCloudSDF::RemoveWindField(
		        VolumetricCloudSDF *this,
		        VolumetricWindField *windField,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5008, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5008, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)windField,
		      0LL);
		  }
		  else if ( this->fields.m_WindFieldManager )
		  {
		    HG::Rendering::Runtime::VolumetricWindFieldManager::RemoveWindField(
		      this->fields.m_WindFieldManager,
		      (IVolumetricWindField *)windField,
		      0LL);
		  }
		}
		
		public bool Contains(Vector3 position) => default; // 0x0000000182F9EBD0-0x0000000182F9EC80
		// Boolean Contains(Vector3)
		bool HG::Rendering::Runtime::VolumetricCloudSDF::Contains(
		        VolumetricCloudSDF *this,
		        Vector3 *position,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  float z; // eax
		  BeyondPolyLineShape *polyLineShape; // rcx
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v12[2]; // [rsp+20h] [rbp-18h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size > 5012 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( v5 )
		    {
		      if ( LODWORD(v5->_0.namespaze) <= 0x1394 )
		        sub_1800D2AB0(v5, position);
		      if ( !*(_QWORD *)&v5[106]._1.thread_static_fields_offset )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(5012, 0LL);
		      if ( Patch )
		      {
		        v11 = *(_QWORD *)&position->x;
		        v12[0].z = position->z;
		        *(_QWORD *)&v12[0].x = v11;
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_255(Patch, (Object *)this, v12, 0LL);
		      }
		    }
		LABEL_9:
		    sub_1800D8260(v5, position);
		  }
		LABEL_5:
		  result = 1;
		  if ( !this->fields.m_ForceVisible )
		  {
		    if ( !this->fields._polyLineShape )
		      return 0;
		    z = position->z;
		    polyLineShape = this->fields._polyLineShape;
		    *(_QWORD *)&v12[0].x = *(_QWORD *)&position->x;
		    v12[0].z = z;
		    if ( Beyond::BeyondPolyLineShape::GetDistanceToEdgeInArea(polyLineShape, v12, 0.1, 0LL) <= 0.0 )
		      return 0;
		  }
		  return result;
		}
		
		public void UpdateVisibility(HGCamera camera, bool visible) {} // 0x0000000182F9DEE0-0x0000000182F9E050
		// Void UpdateVisibility(HGCamera, Boolean)
		void HG::Rendering::Runtime::VolumetricCloudSDF::UpdateVisibility(
		        VolumetricCloudSDF *this,
		        HGCamera *camera,
		        bool visible,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *static_fields; // rcx
		  Object_1__StaticFields *wrapperArray; // rdx
		  Camera *v9; // rbx
		  struct Object_1__Class *v10; // rax
		  char *m_CachedPtr; // rbx
		  int32_t v12; // esi
		  Dictionary_2_System_Int32_System_Boolean_ *visibleStates; // rbx
		  struct MethodInfo *v14; // rdi
		  const Il2CppRGCTXData *rgctx_data; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int32_t OffsetOfInstanceIDInCPlusPlusObject; // eax
		
		  static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (Object_1__StaticFields *)static_fields->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_18;
		  if ( wrapperArray[6].OffsetOfInstanceIDInCPlusPlusObject <= 5013 )
		    goto LABEL_5;
		  if ( !static_fields->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(static_fields);
		    static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (struct ILFixDynamicMethodWrapper_2__Class *)static_fields->static_fields->wrapperArray;
		  if ( !static_fields )
		LABEL_18:
		    sub_1800D8260(static_fields, wrapperArray);
		  if ( LODWORD(static_fields->_0.namespaze) <= 0x1395 )
		    sub_1800D2AB0(static_fields, wrapperArray);
		  if ( *(_QWORD *)&static_fields[106]._1.token )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5013, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_18(
		        (ILFixDynamicMethodWrapper_9 *)Patch,
		        (Object *)this,
		        (Object *)camera,
		        visible,
		        0LL);
		      return;
		    }
		    goto LABEL_18;
		  }
		LABEL_5:
		  if ( !camera )
		    goto LABEL_18;
		  v9 = camera->fields.camera;
		  if ( !v9 )
		    goto LABEL_18;
		  if ( v9->fields._._._.m_CachedPtr )
		  {
		    v10 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v10 = TypeInfo::UnityEngine::Object;
		    }
		    if ( v10->static_fields->OffsetOfInstanceIDInCPlusPlusObject == -1 )
		    {
		      if ( !v10->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v10);
		      OffsetOfInstanceIDInCPlusPlusObject = UnityEngine::Object::GetOffsetOfInstanceIDInCPlusPlusObject(0LL);
		      wrapperArray = TypeInfo::UnityEngine::Object->static_fields;
		      wrapperArray->OffsetOfInstanceIDInCPlusPlusObject = OffsetOfInstanceIDInCPlusPlusObject;
		      v10 = TypeInfo::UnityEngine::Object;
		    }
		    m_CachedPtr = (char *)v9->fields._._._.m_CachedPtr;
		    if ( !v10->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v10);
		      v10 = TypeInfo::UnityEngine::Object;
		    }
		    static_fields = (struct ILFixDynamicMethodWrapper_2__Class *)v10->static_fields;
		    v12 = *(_DWORD *)&m_CachedPtr[SLODWORD(static_fields->_0.image)];
		  }
		  else
		  {
		    v12 = 0;
		  }
		  visibleStates = this->fields._visibleStates;
		  if ( !visibleStates )
		    goto LABEL_18;
		  v14 = MethodInfo::System::Collections::Generic::Dictionary<int,bool>::set_Item;
		  rgctx_data = MethodInfo::System::Collections::Generic::Dictionary<int,bool>::set_Item->klass->rgctx_data;
		  if ( !*((_QWORD *)rgctx_data[24].rgctxDataDummy + 4) )
		    (*(void (__fastcall **)(const Il2CppRGCTXData *, Object_1__StaticFields *, const Il2CppRGCTXData *, MethodInfo *))MethodInfo::System::Collections::Generic::Dictionary<int,bool>::set_Item->klass->rgctx_data[24].rgctxDataDummy)(
		      rgctx_data,
		      wrapperArray,
		      MethodInfo::System::Collections::Generic::Dictionary<int,bool>::set_Item->klass->rgctx_data,
		      method);
		  LOBYTE(method) = 1;
		  System::Collections::Generic::Dictionary<int,bool>::TryInsert(
		    visibleStates,
		    v12,
		    visible,
		    (InsertionBehavior__Enum)method,
		    (MethodInfo *)v14->klass->rgctx_data[24].rgctxDataDummy);
		}
		
		public void FadeInVolume(HGCamera camera) {} // 0x0000000189C47DF4-0x0000000189C47E7C
		// Void FadeInVolume(HGCamera)
		void HG::Rendering::Runtime::VolumetricCloudSDF::FadeInVolume(
		        VolumetricCloudSDF *this,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Object_1 *fadeInStates; // rcx
		  int32_t InstanceID; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5014, 0LL) )
		  {
		    if ( camera )
		    {
		      fadeInStates = (Object_1 *)camera->fields.camera;
		      if ( fadeInStates )
		      {
		        InstanceID = UnityEngine::Object::GetInstanceID(fadeInStates, 0LL);
		        fadeInStates = (Object_1 *)this->fields._fadeInStates;
		        if ( fadeInStates )
		        {
		          System::Collections::Generic::Dictionary<int,bool>::set_Item(
		            (Dictionary_2_System_Int32_System_Boolean_ *)fadeInStates,
		            InstanceID,
		            1,
		            MethodInfo::System::Collections::Generic::Dictionary<int,bool>::set_Item);
		          return;
		        }
		      }
		    }
		LABEL_7:
		    sub_1800D8260(fadeInStates, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5014, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)camera,
		    0LL);
		}
		
		private bool IsAnyVisibleInScene() => default; // 0x0000000183399BB0-0x0000000183399E90
		// Boolean IsAnyVisibleInScene()
		// Hidden C++ exception states: #wind=1 #try_helpers=1
		bool HG::Rendering::Runtime::VolumetricCloudSDF::IsAnyVisibleInScene(VolumetricCloudSDF *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v5; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Dictionary_2_System_Int32_System_Boolean_ *visibleStates; // rbx
		  __int64 *v11; // rdx
		  __int64 v12; // rtt
		  __int64 v13; // rcx
		  __int64 v14; // rdx
		  __int64 v15; // rax
		  __int64 v16; // r8
		  __int64 v17; // r8
		  int v18; // ebx
		  char v19; // di
		  __m256i v20; // [rsp+28h] [rbp-50h] BYREF
		  __m256i v21; // [rsp+48h] [rbp-30h] BYREF
		  __int64 v22; // [rsp+90h] [rbp+18h]
		
		  memset(&v21, 0, sizeof(v21));
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v3, method);
		  if ( wrapperArray->max_length.size <= 5015 )
		    goto LABEL_12;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = v3->static_fields->wrapperArray;
		  if ( !v5 )
		    sub_1800D8260(v3, method);
		  if ( v5->max_length.size <= 0x1397u )
		    sub_1800D2AB0(v3, method);
		  if ( v5[139].vector[11] )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5015, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		LABEL_12:
		    visibleStates = this->fields._visibleStates;
		    if ( !visibleStates )
		      sub_1800D8260(v3, method);
		    memset(&v20.m256i_u64[1], 0, 24);
		    v20.m256i_i64[0] = (__int64)visibleStates;
		    if ( dword_18F35FD08 )
		    {
		      v11 = &qword_18F103690[(((unsigned __int64)&v20 >> 12) & 0x1FFFFF) >> 6];
		      _m_prefetchw(v11);
		      do
		        v12 = *v11;
		      while ( v12 != _InterlockedCompareExchange64(v11, *v11 | (1LL << (((unsigned __int64)&v20 >> 12) & 0x3F)), *v11) );
		    }
		    *(_OWORD *)&v20.m256i_u64[1] = (unsigned int)visibleStates->fields._version;
		    v20.m256i_i32[6] = 2;
		    v21 = v20;
		    v20.m256i_i64[0] = 0LL;
		    v20.m256i_i64[1] = (__int64)&v21;
		    v13 = v21.m256i_u32[3];
		    v14 = v21.m256i_i64[0];
		LABEL_17:
		    if ( !v14 )
		      sub_1800D8250(v13, 0LL);
		    if ( v21.m256i_i32[2] != *(_DWORD *)(v14 + 44) )
		      System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
		    while ( (unsigned int)v13 < *(_DWORD *)(v14 + 32) )
		    {
		      v15 = *(_QWORD *)(v14 + 24);
		      v16 = (int)v13;
		      v13 = (unsigned int)(v13 + 1);
		      v21.m256i_i32[3] = v13;
		      if ( !v15 )
		        sub_1800D8250(v13, v14);
		      if ( (unsigned int)v16 >= *(_DWORD *)(v15 + 24) )
		        sub_1800D2AA0(v13, v14, v16);
		      v17 = 2 * (v16 + 2);
		      if ( *(int *)(v15 + 8 * v17) >= 0 )
		      {
		        v18 = *(_DWORD *)(v15 + 8 * v17 + 8);
		        v19 = *(_BYTE *)(v15 + 8 * v17 + 12);
		        HIDWORD(v22) = 0;
		        if ( ((__int64)MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::MoveNext->klass->vtable[0].methodPtr & 1) == 0 )
		        {
		          sub_1800360B0(
		            MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::MoveNext->klass,
		            v14);
		          v13 = v21.m256i_u32[3];
		          v14 = v21.m256i_i64[0];
		        }
		        LODWORD(v22) = v18;
		        BYTE4(v22) = v19;
		        v21.m256i_i64[2] = v22;
		        if ( v19 )
		          return 1;
		        goto LABEL_17;
		      }
		    }
		    return 0;
		  }
		}
		
		private bool IsVisibleFromCamera(HGCamera camera) => default; // 0x0000000183399E90-0x000000018339A210
		// Boolean IsVisibleFromCamera(HGCamera)
		// Hidden C++ exception states: #wind=1 #try_helpers=1
		bool HG::Rendering::Runtime::VolumetricCloudSDF::IsVisibleFromCamera(
		        VolumetricCloudSDF *this,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  Object *v3; // rdi
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v7; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  _BOOL8 v11; // rax
		  Object__Class *klass; // rbx
		  int v13; // r15d
		  struct Object_1__Class *v14; // rcx
		  int32_t OffsetOfInstanceIDInCPlusPlusObject; // eax
		  const char *name; // rbx
		  Dictionary_2_System_Int32_System_Boolean_ *visibleStates; // rbx
		  __int64 *v18; // rdx
		  __int64 v19; // rtt
		  __int64 v20; // rcx
		  __int64 v21; // rdx
		  __int64 v22; // rax
		  __int64 v23; // r8
		  __int64 v24; // r8
		  int v25; // ebx
		  char v26; // di
		  __m256i v28; // [rsp+28h] [rbp-60h] BYREF
		  __m256i v29; // [rsp+48h] [rbp-40h] BYREF
		  unsigned __int64 v30; // [rsp+A8h] [rbp+20h]
		
		  v3 = (Object *)camera;
		  memset(&v29, 0, sizeof(v29));
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v5, camera);
		  if ( wrapperArray->max_length.size <= 5016 )
		    goto LABEL_12;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v7 = v5->static_fields->wrapperArray;
		  if ( !v7 )
		    sub_1800D8260(v5, camera);
		  if ( v7->max_length.size <= 0x1398u )
		    sub_1800D2AB0(v5, camera);
		  if ( v7[139].vector[12] )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5016, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    LOBYTE(v11) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		                    (ILFixDynamicMethodWrapper_33 *)Patch,
		                    (Object *)this,
		                    v3,
		                    0LL);
		  }
		  else
		  {
		LABEL_12:
		    if ( !v3 )
		      sub_1800D8260(v5, camera);
		    klass = v3[6].klass;
		    if ( !klass )
		      sub_1800D8260(v5, camera);
		    if ( klass->_0.name )
		    {
		      v14 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v14 = TypeInfo::UnityEngine::Object;
		      }
		      if ( v14->static_fields->OffsetOfInstanceIDInCPlusPlusObject == -1 )
		      {
		        if ( !v14->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(v14);
		        OffsetOfInstanceIDInCPlusPlusObject = UnityEngine::Object::GetOffsetOfInstanceIDInCPlusPlusObject(0LL);
		        camera = (HGCamera *)TypeInfo::UnityEngine::Object->static_fields;
		        LODWORD(camera->klass) = OffsetOfInstanceIDInCPlusPlusObject;
		        v14 = TypeInfo::UnityEngine::Object;
		      }
		      name = klass->_0.name;
		      if ( !v14->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v14);
		        v14 = TypeInfo::UnityEngine::Object;
		      }
		      v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v14->static_fields->OffsetOfInstanceIDInCPlusPlusObject;
		      v13 = *(_DWORD *)&name[(_QWORD)v5];
		    }
		    else
		    {
		      v13 = 0;
		    }
		    visibleStates = this->fields._visibleStates;
		    if ( !visibleStates )
		      sub_1800D8260(v5, camera);
		    memset(&v28.m256i_u64[1], 0, 24);
		    v28.m256i_i64[0] = (__int64)visibleStates;
		    if ( dword_18F35FD08 )
		    {
		      v18 = &qword_18F103690[(((unsigned __int64)&v28 >> 12) & 0x1FFFFF) >> 6];
		      _m_prefetchw(v18);
		      do
		        v19 = *v18;
		      while ( v19 != _InterlockedCompareExchange64(v18, *v18 | (1LL << (((unsigned __int64)&v28 >> 12) & 0x3F)), *v18) );
		    }
		    *(_OWORD *)&v28.m256i_u64[1] = (unsigned int)visibleStates->fields._version;
		    v28.m256i_i32[6] = 2;
		    v29 = v28;
		    v28.m256i_i64[0] = 0LL;
		    v28.m256i_i64[1] = (__int64)&v29;
		    v20 = v29.m256i_u32[3];
		    v21 = v29.m256i_i64[0];
		LABEL_30:
		    if ( !v21 )
		      sub_1800D8250(v20, 0LL);
		    if ( v29.m256i_i32[2] != *(_DWORD *)(v21 + 44) )
		      System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
		    while ( (unsigned int)v20 < *(_DWORD *)(v21 + 32) )
		    {
		      v22 = *(_QWORD *)(v21 + 24);
		      v23 = (int)v20;
		      v20 = (unsigned int)(v20 + 1);
		      v29.m256i_i32[3] = v20;
		      if ( !v22 )
		        sub_1800D8250(v20, v21);
		      if ( (unsigned int)v23 >= *(_DWORD *)(v22 + 24) )
		        sub_1800D2AA0(v20, v21, v23);
		      v24 = 2 * (v23 + 2);
		      if ( *(int *)(v22 + 8 * v24) >= 0 )
		      {
		        v25 = *(_DWORD *)(v22 + 8 * v24 + 8);
		        v26 = *(_BYTE *)(v22 + 8 * v24 + 12);
		        HIDWORD(v30) = 0;
		        if ( ((__int64)MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::MoveNext->klass->vtable[0].methodPtr & 1) == 0 )
		        {
		          sub_1800360B0(
		            MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::MoveNext->klass,
		            v21);
		          v20 = v29.m256i_u32[3];
		          v21 = v29.m256i_i64[0];
		        }
		        LODWORD(v30) = v25;
		        BYTE4(v30) = v26;
		        v29.m256i_i64[2] = v30;
		        if ( v25 == v13 )
		          return SBYTE4(v30);
		        goto LABEL_30;
		      }
		    }
		    LOBYTE(v11) = 0;
		  }
		  return v11;
		}
		
		private bool IsFadeInFromCamera(HGCamera camera) => default; // 0x0000000189C47F8C-0x0000000189C480DC
		// Boolean IsFadeInFromCamera(HGCamera)
		// Hidden C++ exception states: #wind=1
		bool HG::Rendering::Runtime::VolumetricCloudSDF::IsFadeInFromCamera(
		        VolumetricCloudSDF *this,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Object_1 *v7; // rbx
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  int32_t InstanceID; // edi
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32_System_Boolean_ *v11; // rax
		  bool v12; // al
		  __int64 v13; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  bool result; // al
		  Il2CppExceptionWrapper *v18; // [rsp+20h] [rbp-58h] BYREF
		  _QWORD v19[4]; // [rsp+28h] [rbp-50h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32_System_Boolean_ v20; // [rsp+48h] [rbp-30h] BYREF
		
		  memset(&v20, 0, sizeof(v20));
		  if ( IFix::WrappersManagerImpl::IsPatched(5017, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5017, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v16, v15);
		    LOBYTE(v13) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		                    (ILFixDynamicMethodWrapper_33 *)Patch,
		                    (Object *)this,
		                    (Object *)camera,
		                    0LL);
		    goto LABEL_24;
		  }
		  if ( !camera )
		    sub_1800D8260(v6, v5);
		  v7 = (Object_1 *)camera->fields.camera;
		  if ( !v7 )
		    sub_1800D8260(v6, v5);
		  InstanceID = UnityEngine::Object::GetInstanceID(v7, 0LL);
		  if ( !this->fields._fadeInStates )
		    sub_1800D8260(v9, v8);
		  v11 = (Dictionary_2_TKey_TValue_Enumerator_System_Int32_System_Boolean_ *)sub_180364F18(
		                                                                              v19,
		                                                                              this->fields._fadeInStates);
		  v20 = *v11;
		  v19[0] = 0LL;
		  v19[1] = &v20;
		  while ( 1 )
		  {
		    try
		    {
		      v12 = System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::MoveNext(
		              &v20,
		              MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::MoveNext);
		    }
		    catch ( Il2CppExceptionWrapper *v18 )
		    {
		      v19[0] = v18->ex;
		      if ( v19[0] )
		        sub_18007E1E0(v19[0]);
		LABEL_10:
		      LOBYTE(v13) = 0;
		LABEL_24:
		      result = v13;
		    }
		    if ( !v12 )
		      goto LABEL_10;
		    if ( v20._current.key == InstanceID )
		    {
		      v13 = HIDWORD(*(_QWORD *)&v20._current);
		      goto LABEL_24;
		    }
		  }
		}
		
		public void PrepareAssets(HGCamera camera) {} // 0x0000000189C49534-0x0000000189C495E8
		// Void PrepareAssets(HGCamera)
		void HG::Rendering::Runtime::VolumetricCloudSDF::PrepareAssets(
		        VolumetricCloudSDF *this,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  Object_1 *m_CloudAsset; // rbx
		  __int64 v6; // rdx
		  Object_1 *loadingStates; // rcx
		  int32_t InstanceID; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5018, 0LL) )
		  {
		    m_CloudAsset = (Object_1 *)this->fields.m_CloudAsset;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Inequality(m_CloudAsset, 0LL, 0LL) )
		      return;
		    if ( camera )
		    {
		      loadingStates = (Object_1 *)camera->fields.camera;
		      if ( loadingStates )
		      {
		        InstanceID = UnityEngine::Object::GetInstanceID(loadingStates, 0LL);
		        loadingStates = (Object_1 *)this->fields._loadingStates;
		        if ( loadingStates )
		        {
		          System::Collections::Generic::Dictionary<int,bool>::set_Item(
		            (Dictionary_2_System_Int32_System_Boolean_ *)loadingStates,
		            InstanceID,
		            1,
		            MethodInfo::System::Collections::Generic::Dictionary<int,bool>::set_Item);
		          return;
		        }
		      }
		    }
		LABEL_8:
		    sub_1800D8260(loadingStates, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5018, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)camera,
		    0LL);
		}
		
		private bool IsAnyLoadingInScene() => default; // 0x000000018339A210-0x000000018339A4F0
		// Boolean IsAnyLoadingInScene()
		bool HG::Rendering::Runtime::VolumetricCloudSDF::IsAnyLoadingInScene(VolumetricCloudSDF *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v5; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Dictionary_2_System_Int32_System_Boolean_ *loadingStates; // rbx
		  __int64 *v11; // rdx
		  __int64 v12; // rtt
		  __int64 v13; // rcx
		  __int64 v14; // rdx
		  __int64 v15; // rax
		  __int64 v16; // r8
		  __int64 v17; // r8
		  int v18; // ebx
		  char v19; // di
		  __m256i v20; // [rsp+28h] [rbp-50h] BYREF
		  __m256i v21; // [rsp+48h] [rbp-30h] BYREF
		  __int64 v22; // [rsp+90h] [rbp+18h]
		
		  memset(&v21, 0, sizeof(v21));
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v3, method);
		  if ( wrapperArray->max_length.size <= 5019 )
		    goto LABEL_12;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = v3->static_fields->wrapperArray;
		  if ( !v5 )
		    sub_1800D8260(v3, method);
		  if ( v5->max_length.size <= 0x139Bu )
		    sub_1800D2AB0(v3, method);
		  if ( v5[139].vector[15] )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5019, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		LABEL_12:
		    loadingStates = this->fields._loadingStates;
		    if ( !loadingStates )
		      sub_1800D8260(v3, method);
		    memset(&v20.m256i_u64[1], 0, 24);
		    v20.m256i_i64[0] = (__int64)loadingStates;
		    if ( dword_18F35FD08 )
		    {
		      v11 = &qword_18F103690[(((unsigned __int64)&v20 >> 12) & 0x1FFFFF) >> 6];
		      _m_prefetchw(v11);
		      do
		        v12 = *v11;
		      while ( v12 != _InterlockedCompareExchange64(v11, *v11 | (1LL << (((unsigned __int64)&v20 >> 12) & 0x3F)), *v11) );
		    }
		    *(_OWORD *)&v20.m256i_u64[1] = (unsigned int)loadingStates->fields._version;
		    v20.m256i_i32[6] = 2;
		    v21 = v20;
		    v20.m256i_i64[0] = 0LL;
		    v20.m256i_i64[1] = (__int64)&v21;
		    v13 = v21.m256i_u32[3];
		    v14 = v21.m256i_i64[0];
		LABEL_17:
		    if ( !v14 )
		      sub_1800D8250(v13, 0LL);
		    if ( v21.m256i_i32[2] != *(_DWORD *)(v14 + 44) )
		      System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
		    while ( (unsigned int)v13 < *(_DWORD *)(v14 + 32) )
		    {
		      v15 = *(_QWORD *)(v14 + 24);
		      v16 = (int)v13;
		      v13 = (unsigned int)(v13 + 1);
		      v21.m256i_i32[3] = v13;
		      if ( !v15 )
		        sub_1800D8250(v13, v14);
		      if ( (unsigned int)v16 >= *(_DWORD *)(v15 + 24) )
		        sub_1800D2AA0(v13, v14, v16);
		      v17 = 2 * (v16 + 2);
		      if ( *(int *)(v15 + 8 * v17) >= 0 )
		      {
		        v18 = *(_DWORD *)(v15 + 8 * v17 + 8);
		        v19 = *(_BYTE *)(v15 + 8 * v17 + 12);
		        HIDWORD(v22) = 0;
		        if ( ((__int64)MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::MoveNext->klass->vtable[0].methodPtr & 1) == 0 )
		        {
		          sub_1800360B0(
		            MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,bool>::MoveNext->klass,
		            v14);
		          v13 = v21.m256i_u32[3];
		          v14 = v21.m256i_i64[0];
		        }
		        LODWORD(v22) = v18;
		        BYTE4(v22) = v19;
		        v21.m256i_i64[2] = v22;
		        if ( v19 )
		          return 1;
		        goto LABEL_17;
		      }
		    }
		    v21.m256i_i32[3] = *(_DWORD *)(v14 + 32) + 1;
		    v21.m256i_i64[2] = 0LL;
		    return 0;
		  }
		}
		
		public bool LoadFinished() => default; // 0x0000000189C484CC-0x0000000189C4854C
		// Boolean LoadFinished()
		bool HG::Rendering::Runtime::VolumetricCloudSDF::LoadFinished(VolumetricCloudSDF *this, MethodInfo *method)
		{
		  Object_1 *m_CloudAsset; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5020, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5020, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_CloudAsset = (Object_1 *)this->fields.m_CloudAsset;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    return UnityEngine::Object::op_Equality(m_CloudAsset, 0LL, 0LL)
		        || HG::Rendering::Runtime::VolumetricCloudSDF::get_IsCloudSdfAssetValid(this, 0LL);
		  }
		}
		
		private new void OnEnable() {} // 0x000000018454BD80-0x000000018454BE00
		// Void OnEnable()
		void HG::Rendering::Runtime::VolumetricCloudSDF::OnEnable(VolumetricCloudSDF *this, MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v4; // rdx
		  VolumetricCloudVolumeManager *volumetricCloudVolumeManager_k__BackingField; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5021, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5021, 0LL);
		    if ( !Patch )
		      goto LABEL_9;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) != GraphicsDeviceType__Enum_Null )
		  {
		    if ( !HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
		    {
		LABEL_7:
		      HG::Rendering::Runtime::VolumetricRenderObject::OnEnable((VolumetricRenderObject *)this, 0LL);
		      HG::Rendering::Runtime::VolumetricCloudSDF::Initialize(this, 0LL);
		      return;
		    }
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( currentManagerContext )
		    {
		      volumetricCloudVolumeManager_k__BackingField = currentManagerContext->fields._volumetricCloudVolumeManager_k__BackingField;
		      if ( volumetricCloudVolumeManager_k__BackingField )
		      {
		        HG::Rendering::Runtime::VolumetricCloudVolumeManager::RegisterCloudVolume(
		          volumetricCloudVolumeManager_k__BackingField,
		          (IVolumetricCloudVolume *)this,
		          0LL);
		        goto LABEL_7;
		      }
		    }
		LABEL_9:
		    sub_1800D8260(volumetricCloudVolumeManager_k__BackingField, v4);
		  }
		}
		
		public void Initialize() {} // 0x00000001835222A0-0x0000000183522F90
		// Void Initialize()
		// Hidden C++ exception states: #wind=6
		void HG::Rendering::Runtime::VolumetricCloudSDF::Initialize(VolumetricCloudSDF *this, MethodInfo *method)
		{
		  VolumetricCloudSDF *v2; // rdi
		  unsigned __int64 v3; // xmm0_8
		  Transform *transform; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Component *RelativeTransformWithPath; // rbx
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  __int64 v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  ArgumentNullException *v13; // rbx
		  HGRuntimeGrassQuery_Node *v14; // rdx
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  GameObject *v17; // rax
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  GameObject *v20; // rbx
		  HGRuntimeGrassQuery_Node *v21; // rdx
		  HGRuntimeGrassQuery_Node *v22; // r8
		  Int32__Array **v23; // r9
		  __int64 v24; // rdx
		  __int64 v25; // rcx
		  Transform *v26; // rbx
		  Transform *v27; // rax
		  __int64 v28; // rdx
		  __int64 v29; // rcx
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  Transform *v32; // rbx
		  MethodInfo *v33; // rdx
		  Quaternion *identity; // rax
		  __int64 v35; // rdx
		  __int64 v36; // rcx
		  void (__fastcall *v37)(Transform *, unsigned __int64 *, List_1_T_Enumerator_System_Object_ *); // rax
		  __int64 v38; // rdx
		  __int64 v39; // rcx
		  __int64 v40; // rdx
		  __int64 v41; // rcx
		  Transform *v42; // rbx
		  void (__fastcall *v43)(Transform *, Quaternion *); // rax
		  GameObject *m_CloudObject; // rbx
		  Object *v45; // rbx
		  Mesh *CubeMesh; // rax
		  __int64 v47; // rdx
		  __int64 v48; // rcx
		  VolumetricWindFieldManager *v49; // rax
		  __int64 v50; // rdx
		  __int64 v51; // rcx
		  VolumetricWindFieldManager *v52; // rbx
		  HGRuntimeGrassQuery_Node *v53; // rdx
		  HGRuntimeGrassQuery_Node *v54; // r8
		  Int32__Array **v55; // r9
		  __int64 v56; // rdx
		  __int64 v57; // rcx
		  Object__Array *v58; // rsi
		  int32_t i; // ebx
		  __int64 v60; // rdx
		  VolumetricWindFieldManager *m_WindFieldManager; // rcx
		  unsigned __int64 v62; // rdx
		  _DWORD *p_InvPartialVPMatrix; // rcx
		  __int64 v64; // rbx
		  __int64 (*v65)(void); // rax
		  unsigned __int64 v66; // rdx
		  signed __int64 v67; // rtt
		  struct MaterialPropertyBlock__Class *element_class; // rsi
		  __int64 v69; // rax
		  __int64 instance_size; // rcx
		  MaterialPropertyBlock *v71; // r14
		  __int64 (*v72)(void); // rax
		  unsigned __int64 v73; // r8
		  signed __int64 v74; // rtt
		  struct MaterialPropertyBlock__Class *v75; // rsi
		  __int64 v76; // rax
		  __int64 v77; // rcx
		  MaterialPropertyBlock *v78; // r14
		  __int64 (*v79)(void); // rax
		  signed __int64 v80; // rtt
		  Material *m_CloudMat; // rbx
		  Material *v82; // rsi
		  struct VolumetricShaderIDs__Class *v83; // rax
		  unsigned int Cull; // r14d
		  void (__fastcall *v85)(Material *, _QWORD); // rax
		  Material *v86; // r14
		  struct VolumetricShaderIDs__Class *v87; // rbx
		  unsigned int v88; // ebx
		  void (__fastcall *v89)(Material *, _QWORD); // rax
		  __int64 v90; // rax
		  __int64 v91; // rax
		  const char *v92; // r8
		  __int64 *v93; // rsi
		  __int64 v94; // r9
		  __int64 v95; // rax
		  HGRuntimeGrassQuery_Node *v96; // rdx
		  HGRuntimeGrassQuery_Node *v97; // r8
		  __int64 v98; // r9
		  uint32_t v99; // eax
		  bool v100; // cl
		  unsigned int v101; // eax
		  unsigned __int8 (*v102)(void); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v104; // rdx
		  __int64 v105; // rcx
		  String *v106; // rax
		  __int64 v107; // rax
		  __int64 v108; // rax
		  __int64 v109; // rax
		  __int64 v110; // rax
		  __int64 v111; // rax
		  __int64 v112; // rax
		  __int64 v113; // rax
		  __int64 v114; // rax
		  __int64 Target; // rax
		  __int64 v116; // rax
		  MethodInfo *v117; // [rsp+20h] [rbp-E8h]
		  MethodInfo *v118; // [rsp+20h] [rbp-E8h]
		  MethodInfo *v119; // [rsp+20h] [rbp-E8h]
		  Quaternion v120[2]; // [rsp+30h] [rbp-D8h] BYREF
		  List_1_T_Enumerator_System_Object_ v121; // [rsp+50h] [rbp-B8h] BYREF
		  unsigned __int64 v122; // [rsp+70h] [rbp-98h] BYREF
		  int v123; // [rsp+78h] [rbp-90h]
		  List_1_T_Enumerator_System_Object_ v124; // [rsp+80h] [rbp-88h] BYREF
		  Il2CppExceptionWrapper *v125; // [rsp+A0h] [rbp-68h] BYREF
		  __int64 *v127; // [rsp+120h] [rbp+18h] BYREF
		  char v128; // [rsp+128h] [rbp+20h] BYREF
		
		  v2 = this;
		  memset(&v121, 0, sizeof(v121));
		  if ( IFix::WrappersManagerImpl::IsPatched(5025, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5025, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v105, v104);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v2, 0LL);
		  }
		  else
		  {
		    v3 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		    *(_QWORD *)&v2->fields.m_WindPhase3.x = v3;
		    v2->fields.m_WindPhase3.z = 0.0;
		    *(_QWORD *)&v2->fields.m_WindPhase2.x = v3;
		    v2->fields.m_WindPhase2.z = 0.0;
		    *(_QWORD *)&v2->fields.m_WindPhase.x = v3;
		    v2->fields.m_WindPhase.z = 0.0;
		    transform = UnityEngine::Component::get_transform((Component *)v2, 0LL);
		    if ( !transform )
		      sub_1800D8260(v6, v5);
		    if ( !"Cloud Object" )
		    {
		      v10 = sub_180035ED0(&TypeInfo::System::ArgumentNullException);
		      v13 = (ArgumentNullException *)sub_1800368D0(v10);
		      if ( !v13 )
		        sub_1800D8260(v12, v11);
		      v106 = (String *)sub_180035ED0(&off_18E273040);
		      System::ArgumentNullException::ArgumentNullException(v13, v106, 0LL);
		      v107 = sub_180035ED0(&MethodInfo::UnityEngine::Transform::Find);
		      sub_18007E190(v13, v107);
		    }
		    RelativeTransformWithPath = (Component *)UnityEngine::Transform::FindRelativeTransformWithPath(
		                                               transform,
		                                               (String *)"Cloud Object",
		                                               0,
		                                               0LL);
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Implicit((Object_1 *)RelativeTransformWithPath, 0LL) )
		    {
		      if ( !RelativeTransformWithPath )
		        sub_1800D8260(v9, v8);
		      v2->fields.m_CloudObject = UnityEngine::Component::get_gameObject(RelativeTransformWithPath, 0LL);
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v2->fields.m_CloudObject, v14, v15, v16, v117);
		    }
		    else
		    {
		      v17 = (GameObject *)sub_1800368D0(TypeInfo::UnityEngine::GameObject);
		      v20 = v17;
		      if ( !v17 )
		        sub_1800D8260(v19, v18);
		      UnityEngine::GameObject::GameObject(v17, (String *)"Cloud Object", 0LL);
		      v2->fields.m_CloudObject = v20;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v2->fields.m_CloudObject, v21, v22, v23, v117);
		      if ( !v2->fields.m_CloudObject )
		        sub_1800D8260(v25, v24);
		      v26 = UnityEngine::GameObject::get_transform(v2->fields.m_CloudObject, 0LL);
		      v27 = UnityEngine::Component::get_transform((Component *)v2, 0LL);
		      if ( !v26 )
		        sub_1800D8260(v29, v28);
		      UnityEngine::Transform::set_parent(v26, v27, 0LL);
		      if ( !v2->fields.m_CloudObject )
		        sub_1800D8260(v31, v30);
		      v32 = UnityEngine::GameObject::get_transform(v2->fields.m_CloudObject, 0LL);
		      identity = UnityEngine::Quaternion::get_identity(v120, v33);
		      if ( !v32 )
		        sub_1800D8260(v36, v35);
		      *(Quaternion *)&v124._list = *identity;
		      v122 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		      v123 = 0;
		      v37 = (void (__fastcall *)(Transform *, unsigned __int64 *, List_1_T_Enumerator_System_Object_ *))qword_18F370158;
		      if ( !qword_18F370158 )
		      {
		        v37 = (void (__fastcall *)(Transform *, unsigned __int64 *, List_1_T_Enumerator_System_Object_ *))il2cpp_resolve_icall_1("UnityEngine.Transform::SetLocalPositionAndRotation_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&)");
		        if ( !v37 )
		        {
		          v108 = sub_1802EE1B8(
		                   "UnityEngine.Transform::SetLocalPositionAndRotation_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&)");
		          sub_18007E1B0(v108, 0LL);
		        }
		        qword_18F370158 = (__int64)v37;
		      }
		      v37(v32, &v122, &v124);
		      if ( !v2->fields.m_CloudObject )
		        sub_1800D8260(v39, v38);
		      v42 = UnityEngine::GameObject::get_transform(v2->fields.m_CloudObject, 0LL);
		      if ( !v42 )
		        sub_1800D8260(v41, v40);
		      *(_QWORD *)&v120[0].x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		      v120[0].z = 1.0;
		      v43 = (void (__fastcall *)(Transform *, Quaternion *))qword_18F370138;
		      if ( !qword_18F370138 )
		      {
		        v43 = (void (__fastcall *)(Transform *, Quaternion *))il2cpp_resolve_icall_1(
		                                                                "UnityEngine.Transform::set_localScale_Injected(UnityEngine.Vector3&)");
		        if ( !v43 )
		        {
		          v109 = sub_1802EE1B8("UnityEngine.Transform::set_localScale_Injected(UnityEngine.Vector3&)");
		          sub_18007E1B0(v109, 0LL);
		        }
		        qword_18F370138 = (__int64)v43;
		      }
		      v43(v42, v120);
		      m_CloudObject = v2->fields.m_CloudObject;
		      if ( !TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		      v45 = HG::Rendering::Runtime::VolumetricSDFUtils::AddMissingComponent<System::Object>(
		              m_CloudObject,
		              MethodInfo::HG::Rendering::Runtime::VolumetricSDFUtils::AddMissingComponent<UnityEngine::MeshFilter>);
		      CubeMesh = HG::Rendering::Runtime::VolumetricSDFUtils::get_CubeMesh(0LL);
		      if ( !v45 )
		        sub_1800D8260(v48, v47);
		      UnityEngine::MeshFilter::set_sharedMesh((MeshFilter *)v45, CubeMesh, 0LL);
		      HG::Rendering::Runtime::VolumetricSDFUtils::AddMissingComponent<System::Object>(
		        v2->fields.m_CloudObject,
		        MethodInfo::HG::Rendering::Runtime::VolumetricSDFUtils::AddMissingComponent<UnityEngine::MeshRenderer>);
		    }
		    v49 = (VolumetricWindFieldManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::VolumetricWindFieldManager);
		    v52 = v49;
		    if ( !v49 )
		      sub_1800D8260(v51, v50);
		    HG::Rendering::Runtime::VolumetricWindFieldManager::VolumetricWindFieldManager(v49, 0LL);
		    v2->fields.m_WindFieldManager = v52;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v2->fields.m_WindFieldManager, v53, v54, v55, v118);
		    v58 = UnityEngine::Component::GetComponentsInChildren<System::Object>(
		            (Component *)v2,
		            MethodInfo::UnityEngine::Component::GetComponentsInChildren<HG::Rendering::Runtime::VolumetricWindField>);
		    for ( i = 0; ; ++i )
		    {
		      if ( !v58 )
		        sub_1800D8260(v57, v56);
		      if ( i >= v58->max_length.size )
		        break;
		      if ( (unsigned int)i >= v58->max_length.size )
		        sub_1800D2AB0(v57, v56);
		      if ( !v2->fields.m_WindFieldManager )
		        sub_1800D8260(v57, v56);
		      HG::Rendering::Runtime::VolumetricWindFieldManager::AddWindField(
		        v2->fields.m_WindFieldManager,
		        (IVolumetricWindField *)v58->vector[i],
		        0LL);
		    }
		    if ( !v2->fields.m_WindFieldNodeList )
		      sub_1800D8260(v57, v56);
		    System::Collections::Generic::List<unsigned long>::GetEnumerator(
		      (List_1_T_Enumerator_System_UInt64_ *)&v124,
		      (List_1_System_UInt64_ *)v2->fields.m_WindFieldNodeList,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricWindFieldNode>::GetEnumerator);
		    v121 = v124;
		    *(_QWORD *)&v120[0].x = 0LL;
		    *(_QWORD *)&v120[0].z = &v121;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                &v121,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricWindFieldNode>::MoveNext) )
		      {
		        m_WindFieldManager = v2->fields.m_WindFieldManager;
		        if ( !m_WindFieldManager )
		          sub_1800D8250(0LL, v60);
		        HG::Rendering::Runtime::VolumetricWindFieldManager::AddWindField(
		          m_WindFieldManager,
		          (IVolumetricWindField *)v121._current,
		          0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v125 )
		    {
		      *(Il2CppExceptionWrapper *)&v120[0].x = (Il2CppExceptionWrapper)v125->ex;
		      if ( *(_QWORD *)&v120[0].x )
		        sub_18007E1E0(*(_QWORD *)&v120[0].x);
		      v2 = this;
		    }
		    v64 = sub_18002C620(TypeInfo::UnityEngine::MaterialPropertyBlock);
		    if ( !v64 )
		      goto LABEL_166;
		    v65 = (__int64 (*)(void))qword_18F36F458;
		    if ( !qword_18F36F458 )
		    {
		      v65 = (__int64 (*)(void))il2cpp_resolve_icall_1("UnityEngine.MaterialPropertyBlock::CreateImpl()");
		      if ( !v65 )
		      {
		        v110 = sub_1802EE1B8("UnityEngine.MaterialPropertyBlock::CreateImpl()");
		        sub_18007E1B0(v110, 0LL);
		      }
		      qword_18F36F458 = (__int64)v65;
		    }
		    *(_QWORD *)(v64 + 16) = v65();
		    v2->fields.m_propertyBlock = (MaterialPropertyBlock *)v64;
		    if ( dword_18F35FD08 )
		    {
		      v66 = (((unsigned __int64)&v2->fields.m_propertyBlock >> 12) & 0x1FFFFF) >> 6;
		      _m_prefetchw(&qword_18F0BCBA0[v66 + 36190]);
		      do
		        v67 = qword_18F0BCBA0[v66 + 36190];
		      while ( v67 != _InterlockedCompareExchange64(
		                       &qword_18F0BCBA0[v66 + 36190],
		                       v67 | (1LL << (((unsigned __int64)&v2->fields.m_propertyBlock >> 12) & 0x3F)),
		                       v67) );
		    }
		    element_class = TypeInfo::UnityEngine::MaterialPropertyBlock;
		    if ( ((__int64)TypeInfo::UnityEngine::MaterialPropertyBlock->vtable.Equals.methodPtr & 2) == 0 )
		    {
		      v127 = &qword_18F360A90;
		      sub_1802DEE10(&qword_18F360A90);
		      sub_18004C730(element_class, &v127);
		      sub_1802DEE70(v127);
		    }
		    if ( element_class->_0.generic_class && ((__int64)element_class->vtable.Equals.methodPtr & 8) != 0 )
		      element_class = (struct MaterialPropertyBlock__Class *)element_class->_0.element_class;
		    if ( ((__int64)element_class->vtable.Equals.methodPtr & 0x20) != 0 )
		    {
		      instance_size = element_class->_1.instance_size;
		      if ( element_class->_0.gc_desc )
		        v69 = sub_18002CC60(instance_size, element_class);
		      else
		        v69 = sub_18002BEA0(instance_size, element_class);
		    }
		    else
		    {
		      v69 = sub_18002D340(element_class);
		    }
		    v71 = (MaterialPropertyBlock *)v69;
		    if ( (BYTE1(element_class->vtable.Equals.methodPtr) & 2) != 0 )
		      sub_18002E5E0(v69, (unsigned int)sub_18000A6C0, 0, (unsigned int)&v128, (__int64)&v127);
		    if ( (dword_18F371F28 & 0x80u) != 0 )
		      sub_1802ED490(v71, element_class);
		    il2cpp_runtime_class_init_1(element_class);
		    if ( !v71 )
		      goto LABEL_166;
		    v72 = (__int64 (*)(void))qword_18F36F458;
		    if ( !qword_18F36F458 )
		    {
		      v72 = (__int64 (*)(void))il2cpp_resolve_icall_1("UnityEngine.MaterialPropertyBlock::CreateImpl()");
		      if ( !v72 )
		      {
		        v111 = sub_1802EE1B8("UnityEngine.MaterialPropertyBlock::CreateImpl()");
		        sub_18007E1B0(v111, 0LL);
		      }
		      qword_18F36F458 = (__int64)v72;
		    }
		    v71->fields.m_Ptr = (void *)v72();
		    v2->fields.m_composePropertyBlock = v71;
		    if ( dword_18F35FD08 )
		    {
		      v73 = (((unsigned __int64)&v2->fields.m_composePropertyBlock >> 12) & 0x1FFFFF) >> 6;
		      _m_prefetchw(&qword_18F0BCBA0[v73 + 36190]);
		      do
		        v74 = qword_18F0BCBA0[v73 + 36190];
		      while ( v74 != _InterlockedCompareExchange64(
		                       &qword_18F0BCBA0[v73 + 36190],
		                       v74 | (1LL << (((unsigned __int64)&v2->fields.m_composePropertyBlock >> 12) & 0x3F)),
		                       v74) );
		    }
		    v75 = TypeInfo::UnityEngine::MaterialPropertyBlock;
		    if ( ((__int64)TypeInfo::UnityEngine::MaterialPropertyBlock->vtable.Equals.methodPtr & 2) == 0 )
		    {
		      v127 = &qword_18F360A90;
		      sub_1802DEE10(&qword_18F360A90);
		      sub_18004C730(v75, &v127);
		      sub_1802DEE70(v127);
		    }
		    if ( v75->_0.generic_class && ((__int64)v75->vtable.Equals.methodPtr & 8) != 0 )
		      v75 = (struct MaterialPropertyBlock__Class *)v75->_0.element_class;
		    if ( ((__int64)v75->vtable.Equals.methodPtr & 0x20) != 0 )
		    {
		      v77 = v75->_1.instance_size;
		      if ( v75->_0.gc_desc )
		        v76 = sub_18002CC60(v77, v75);
		      else
		        v76 = sub_18002BEA0(v77, v75);
		    }
		    else
		    {
		      v76 = sub_18002D340(v75);
		    }
		    v78 = (MaterialPropertyBlock *)v76;
		    if ( (BYTE1(v75->vtable.Equals.methodPtr) & 2) != 0 )
		      sub_18002E5E0(v76, (unsigned int)sub_18000A6C0, 0, (unsigned int)&v128, (__int64)&v127);
		    if ( (dword_18F371F28 & 0x80u) != 0 )
		      sub_1802ED490(v78, v75);
		    il2cpp_runtime_class_init_1(v75);
		    if ( !v78 )
		      goto LABEL_166;
		    v79 = (__int64 (*)(void))qword_18F36F458;
		    if ( !qword_18F36F458 )
		    {
		      v79 = (__int64 (*)(void))il2cpp_resolve_icall_1("UnityEngine.MaterialPropertyBlock::CreateImpl()");
		      if ( !v79 )
		      {
		        v112 = sub_1802EE1B8("UnityEngine.MaterialPropertyBlock::CreateImpl()");
		        sub_18007E1B0(v112, 0LL);
		      }
		      qword_18F36F458 = (__int64)v79;
		    }
		    v78->fields.m_Ptr = (void *)v79();
		    v2->fields.m_emptySkipPropertyBlock = v78;
		    if ( dword_18F35FD08 )
		    {
		      v62 = (((unsigned __int64)&v2->fields.m_emptySkipPropertyBlock >> 12) & 0x1FFFFF) >> 6;
		      _m_prefetchw(&qword_18F0BCBA0[v62 + 36190]);
		      do
		        v80 = qword_18F0BCBA0[v62 + 36190];
		      while ( v80 != _InterlockedCompareExchange64(
		                       &qword_18F0BCBA0[v62 + 36190],
		                       v80 | (1LL << (((unsigned __int64)&v2->fields.m_emptySkipPropertyBlock >> 12) & 0x3F)),
		                       v80) );
		    }
		    m_CloudMat = v2->fields.m_CloudMat;
		    p_InvPartialVPMatrix = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      p_InvPartialVPMatrix = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        p_InvPartialVPMatrix = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( m_CloudMat )
		    {
		      if ( !p_InvPartialVPMatrix[56] )
		        il2cpp_runtime_class_init_1(p_InvPartialVPMatrix);
		      if ( m_CloudMat->fields._.m_CachedPtr )
		      {
		        v82 = v2->fields.m_CloudMat;
		        v83 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
		        if ( !TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		          v83 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
		        }
		        Cull = v83->static_fields->_Cull;
		        if ( !v82 )
		          goto LABEL_166;
		        v85 = (void (__fastcall *)(Material *, _QWORD))qword_18F36F688;
		        if ( !qword_18F36F688 )
		        {
		          v85 = (void (__fastcall *)(Material *, _QWORD))il2cpp_resolve_icall_1(
		                                                           "UnityEngine.Material::SetFloatImpl(System.Int32,System.Single)");
		          if ( !v85 )
		          {
		            v113 = sub_1802EE1B8("UnityEngine.Material::SetFloatImpl(System.Int32,System.Single)");
		            sub_18007E1B0(v113, 0LL);
		          }
		          qword_18F36F688 = (__int64)v85;
		        }
		        v85(v82, Cull);
		        v86 = v2->fields.m_CloudMat;
		        v87 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
		        if ( TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->_1.cctor_finished_or_no_cctor )
		          goto LABEL_107;
		        sub_1802DEE10(&qword_18F371A70);
		        if ( _InterlockedCompareExchange((volatile signed __int32 *)&v87->_1.cctor_finished_or_no_cctor, 1, 1) == 1 )
		        {
		          sub_1802DEE70(&qword_18F371A70);
		          goto LABEL_107;
		        }
		        if ( _InterlockedCompareExchange((volatile signed __int32 *)&v87->_1.cctor_started, 1, 1) == 1 )
		        {
		          sub_1802DEE70(&qword_18F371A70);
		          v101 = ((__int64 (*)(void))GetCurrentThreadId)();
		          if ( v101 == _InterlockedCompareExchange64((volatile signed __int64 *)&v87->_1.cctor_thread, v101, v101) )
		            goto LABEL_107;
		          while ( _InterlockedCompareExchange((volatile signed __int32 *)&v87->_1.cctor_finished_or_no_cctor, 1, 1) != 1
		               && !_InterlockedCompareExchange(
		                     (volatile signed __int32 *)&v87->_1.initializationExceptionGCHandle,
		                     0,
		                     0) )
		            sub_1800717D0(1LL, 0LL);
		        }
		        else
		        {
		          _InterlockedExchange64(
		            (volatile __int64 *)&v87->_1.cctor_thread,
		            (unsigned int)((__int64 (*)(void))GetCurrentThreadId)());
		          _InterlockedExchange((volatile __int32 *)&v87->_1.cctor_started, 1);
		          sub_1802DEE70(&qword_18F371A70);
		          v127 = 0LL;
		          if ( (BYTE1(v87->vtable.Equals.methodPtr) & 4) != 0 )
		          {
		            v90 = sub_1800097A0((_DWORD)v87, (unsigned int)".cctor", -1, 2048, 0LL);
		            if ( v90 )
		              il2cpp_runtime_invoke_0(v90, 0LL, 0LL, &v127);
		          }
		          _InterlockedExchange64((volatile __int64 *)&v87->_1.cctor_thread, 0LL);
		          if ( v127 )
		          {
		            v91 = sub_18005B0E0(v120, &v87->_0.byval_arg, 0LL);
		            v92 = (const char *)sub_18002A970(v91);
		            sub_18005AD90(&v124, "The type initializer for '%s' threw an exception.", v92);
		            sub_18002A8F0(v120);
		            v93 = v127;
		            v94 = sub_18002A970(&v124);
		            v95 = il2cpp_exception_from_name_msg_1(qword_18F35FF60, "System", "TypeInitializationException", v94);
		            v98 = v95;
		            if ( v93 )
		            {
		              *(_QWORD *)(v95 + 40) = v93;
		              sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v95 + 40), v96, v97, (Int32__Array **)v95, v119);
		            }
		            v99 = sub_18030A120(&qword_18E7B56A0, v98, 0LL);
		            v87->_1.initializationExceptionGCHandle = v99;
		            v100 = ((__int64)v87->vtable.Equals.methodPtr & 2) != 0 && !v99;
		            LOBYTE(v87->vtable.Equals.methodPtr) = v100 | (__int64)v87->vtable.Equals.methodPtr & 0xFE;
		            sub_18002A8F0(&v124);
		          }
		          else
		          {
		            _InterlockedExchange((volatile __int32 *)&v87->_1.cctor_finished_or_no_cctor, 1);
		          }
		        }
		        if ( v87->_1.initializationExceptionGCHandle )
		        {
		          Target = System::Runtime::InteropServices::GCHandle::GetTarget(
		                     (System::Runtime::InteropServices::GCHandle *)v87->_1.initializationExceptionGCHandle,
		                     (void *)v62);
		          sub_18007E1B0(Target, 0LL);
		        }
		LABEL_107:
		        p_InvPartialVPMatrix = &TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InvPartialVPMatrix;
		        v88 = p_InvPartialVPMatrix[3];
		        if ( v86 )
		        {
		          v89 = (void (__fastcall *)(Material *, _QWORD))qword_18F36F688;
		          if ( !qword_18F36F688 )
		          {
		            v89 = (void (__fastcall *)(Material *, _QWORD))il2cpp_resolve_icall_1(
		                                                             "UnityEngine.Material::SetFloatImpl(System.Int32,System.Single)");
		            if ( !v89 )
		            {
		              v114 = sub_1802EE1B8("UnityEngine.Material::SetFloatImpl(System.Int32,System.Single)");
		              sub_18007E1B0(v114, 0LL);
		            }
		            qword_18F36F688 = (__int64)v89;
		          }
		          v89(v86, v88);
		          v102 = (unsigned __int8 (*)(void))qword_18F36EFD8;
		          if ( !qword_18F36EFD8 )
		          {
		            v102 = (unsigned __int8 (*)(void))il2cpp_resolve_icall_1("UnityEngine.Application::get_isPlaying()");
		            if ( !v102 )
		            {
		              v116 = sub_1802EE1B8("UnityEngine.Application::get_isPlaying()");
		              sub_18007E1B0(v116, 0LL);
		            }
		            qword_18F36EFD8 = (__int64)v102;
		          }
		          if ( v102() )
		            v2->fields.m_DrawNear = 1;
		          HG::Rendering::Runtime::VolumetricCloudSDF::UpdateOnce(v2, 1, 0LL);
		          return;
		        }
		LABEL_166:
		        sub_1800D8250(p_InvPartialVPMatrix, v62);
		      }
		    }
		  }
		}
		
		private new void OnDisable() {} // 0x0000000189C4854C-0x0000000189C488B8
		// Void OnDisable()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::VolumetricCloudSDF::OnDisable(VolumetricCloudSDF *this, MethodInfo *method)
		{
		  VolumetricCloudSDF *v2; // rdi
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  __int64 *v7; // rdx
		  Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *farRenderers; // rcx
		  unsigned __int64 v9; // r10
		  signed __int64 v10; // rtt
		  unsigned __int64 v11; // r10
		  signed __int64 v12; // rtt
		  unsigned __int64 v13; // r10
		  signed __int64 v14; // rtt
		  unsigned __int64 v15; // r8
		  unsigned __int64 v16; // r9
		  char v17; // r8
		  signed __int64 v18; // rtt
		  HGManagerContext *currentManagerContext; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  __int64 v23; // [rsp+0h] [rbp-98h] BYREF
		  Il2CppExceptionWrapper *v24; // [rsp+20h] [rbp-78h] BYREF
		  Il2CppException *ex; // [rsp+28h] [rbp-70h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ *v26; // [rsp+30h] [rbp-68h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v27; // [rsp+38h] [rbp-60h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v28; // [rsp+60h] [rbp-38h] BYREF
		
		  v2 = this;
		  if ( IFix::WrappersManagerImpl::IsPatched(5048, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5048, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v22, v21);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v2, 0LL);
		  }
		  else
		  {
		    if ( UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL) == GraphicsDeviceType__Enum_Null )
		      return;
		    HG::Rendering::Runtime::VolumetricCloudSDF::ClearFrameStates(v2, 0LL);
		    HG::Rendering::Runtime::VolumetricCloudSDF::ReleaseCloudAsset(v2, 0LL);
		    if ( !v2->fields.m_MSBaker )
		      sub_1800D8260(v4, v3);
		    HG::Rendering::Runtime::VolumetricMSBake::Release(v2->fields.m_MSBaker, 0LL);
		    if ( !v2->fields.farRenderers )
		      sub_1800D8260(v6, v5);
		    System::Collections::Generic::Dictionary<unsigned long,System::Object>::GetEnumerator(
		      (Dictionary_2_TKey_TValue_Enumerator_System_UInt64_System_Object_ *)&v28,
		      (Dictionary_2_System_UInt64_System_Object_ *)v2->fields.farRenderers,
		      MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::GetEnumerator);
		    v27 = v28;
		    ex = 0LL;
		    v26 = &v27;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
		                &v27,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::MoveNext) )
		      {
		        if ( !v27._current.value )
		          sub_1800D8250(0LL, v7);
		        HG::Rendering::Runtime::VolumetricFarCloudRenderer::Release(
		          (VolumetricFarCloudRenderer *)v27._current.value,
		          0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v24 )
		    {
		      v7 = &v23;
		      ex = v24->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v2 = this;
		    }
		    farRenderers = (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *)v2->fields.farRenderers;
		    if ( !farRenderers )
		      goto LABEL_36;
		    System::Collections::Generic::Dictionary<Beyond::Gameplay::Core::WaterVolumePtr,System::ValueTuple<float,System::Int32Enum,System::Object>>::Clear(
		      farRenderers,
		      MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::Clear);
		    farRenderers = (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *)v2->fields.m_WindFieldNodeList;
		    if ( !farRenderers )
		      goto LABEL_36;
		    sub_183127A90(
		      farRenderers,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricWindFieldNode>::Clear);
		    if ( v2->fields.m_WindFieldManager )
		    {
		      HG::Rendering::Runtime::VolumetricWindFieldManager::Release(v2->fields.m_WindFieldManager, 0LL);
		      v2->fields.m_WindFieldManager = 0LL;
		      if ( dword_18F35FD08 )
		      {
		        v9 = (((unsigned __int64)&v2->fields.m_WindFieldManager >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v9 + 36190]);
		        do
		          v10 = qword_18F0BCBA0[v9 + 36190];
		        while ( v10 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v9 + 36190],
		                         v10 | (1LL << (((unsigned __int64)&v2->fields.m_WindFieldManager >> 12) & 0x3F)),
		                         v10) );
		      }
		    }
		    v2->fields.m_propertyBlock = 0LL;
		    if ( dword_18F35FD08 )
		    {
		      v11 = (((unsigned __int64)&v2->fields.m_propertyBlock >> 12) & 0x1FFFFF) >> 6;
		      _m_prefetchw(&qword_18F0BCBA0[v11 + 36190]);
		      do
		        v12 = qword_18F0BCBA0[v11 + 36190];
		      while ( v12 != _InterlockedCompareExchange64(
		                       &qword_18F0BCBA0[v11 + 36190],
		                       v12 | (1LL << (((unsigned __int64)&v2->fields.m_propertyBlock >> 12) & 0x3F)),
		                       v12) );
		    }
		    v2->fields.m_composePropertyBlock = 0LL;
		    if ( dword_18F35FD08 )
		    {
		      v13 = (((unsigned __int64)&v2->fields.m_composePropertyBlock >> 12) & 0x1FFFFF) >> 6;
		      _m_prefetchw(&qword_18F0BCBA0[v13 + 36190]);
		      do
		        v14 = qword_18F0BCBA0[v13 + 36190];
		      while ( v14 != _InterlockedCompareExchange64(
		                       &qword_18F0BCBA0[v13 + 36190],
		                       v14 | (1LL << (((unsigned __int64)&v2->fields.m_composePropertyBlock >> 12) & 0x3F)),
		                       v14) );
		    }
		    v2->fields.m_emptySkipPropertyBlock = 0LL;
		    if ( dword_18F35FD08 )
		    {
		      v15 = ((unsigned __int64)&v2->fields.m_emptySkipPropertyBlock >> 12) & 0x1FFFFF;
		      v16 = v15 >> 6;
		      v17 = v15 & 0x3F;
		      _m_prefetchw(&qword_18F0BCBA0[v16 + 36190]);
		      do
		        v18 = qword_18F0BCBA0[v16 + 36190];
		      while ( v18 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v16 + 36190], v18 | (1LL << v17), v18) );
		    }
		    HG::Rendering::Runtime::VolumetricRenderObject::OnDisable((VolumetricRenderObject *)v2, 0LL);
		    if ( HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
		    {
		      currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		      if ( currentManagerContext )
		      {
		        farRenderers = (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *)currentManagerContext->fields._volumetricCloudVolumeManager_k__BackingField;
		        if ( farRenderers )
		        {
		          HG::Rendering::Runtime::VolumetricCloudVolumeManager::UnregisterCloudVolume(
		            (VolumetricCloudVolumeManager *)farRenderers,
		            (IVolumetricCloudVolume *)v2,
		            0LL);
		          return;
		        }
		      }
		LABEL_36:
		      sub_1800D8250(farRenderers, v7);
		    }
		  }
		}
		
		private void Update() {} // 0x00000001831C5310-0x00000001831C5390
		// Void Update()
		void HG::Rendering::Runtime::VolumetricCloudSDF::Update(VolumetricCloudSDF *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  unsigned int (*v5)(void); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size > 5063 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x13C7 )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !*(_QWORD *)&v3[107]._1.naturalAligment )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(5063, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		        return;
		      }
		    }
		LABEL_9:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  v5 = (unsigned int (*)(void))qword_18F36FE78;
		  if ( !qword_18F36FE78 )
		  {
		    v5 = (unsigned int (*)(void))il2cpp_resolve_icall_1("UnityEngine.SystemInfo::GetGraphicsDeviceType()");
		    if ( !v5 )
		    {
		      v7 = sub_1802EE1B8("UnityEngine.SystemInfo::GetGraphicsDeviceType()");
		      sub_18007E1B0(v7, 0LL);
		    }
		    qword_18F36FE78 = (__int64)v5;
		  }
		  if ( v5() != 4 )
		    HG::Rendering::Runtime::VolumetricCloudSDF::UpdateOnce(this, 0, 0LL);
		}
		
		private void UpdateOnce(bool force = false /* Metadata: 0x023040AE */) {} // 0x00000001833996D0-0x0000000183399AE0
		// Void UpdateOnce(Boolean)
		// local variable allocation has failed, the output may be wrong!
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::VolumetricCloudSDF::UpdateOnce(VolumetricCloudSDF *this, bool force, MethodInfo *method)
		{
		  bool v3; // r14
		  VolumetricCloudSDF *v4; // rbx
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
		  ILFixDynamicMethodWrapper_2__Array *v7; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  bool IsAnyVisibleInScene; // si
		  __int64 *v12; // rdx
		  struct ILFixDynamicMethodWrapper_2__Class *v13; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v14; // rdi
		  ILFixDynamicMethodWrapper_2__Array *v15; // rdi
		  ILFixDynamicMethodWrapper_2 *v16; // rax
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  struct Object_1__Class *m_WindFieldManager; // rcx
		  VolumetricSdfAsset *m_CloudAsset; // rdi
		  MaterialPropertyBlock *m_propertyBlock; // rdi
		  void (__fastcall *v22)(MaterialPropertyBlock *, __int64 *); // rax
		  Material *m_CloudMat; // rdi
		  struct Object_1__Class *v24; // rcx
		  __int64 v25; // rax
		  __int64 v26; // [rsp+0h] [rbp-78h] BYREF
		  Il2CppExceptionWrapper *v27; // [rsp+20h] [rbp-58h] BYREF
		  List_1_T_Enumerator_System_Object_ v28; // [rsp+28h] [rbp-50h] BYREF
		  List_1_T_Enumerator_System_Object_ v29; // [rsp+40h] [rbp-38h] BYREF
		
		  v3 = force;
		  v4 = this;
		  memset(&v29, 0, sizeof(v29));
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v5, force);
		  if ( wrapperArray->max_length.size > 5027 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v7 = v5->static_fields->wrapperArray;
		    if ( !v7 )
		      sub_1800D8260(v5, force);
		    if ( v7->max_length.size <= 0x13A3u )
		      sub_1800D2AB0(v5, force);
		    if ( v7[139].vector[23] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(5027, 0LL);
		      if ( !Patch )
		        sub_1800D8260(v10, v9);
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)v4, v3, 0LL);
		      return;
		    }
		  }
		  IsAnyVisibleInScene = HG::Rendering::Runtime::VolumetricCloudSDF::IsAnyVisibleInScene(v4, 0LL);
		  if ( IsAnyVisibleInScene | HG::Rendering::Runtime::VolumetricCloudSDF::IsAnyLoadingInScene(v4, 0LL) )
		  {
		    HG::Rendering::Runtime::VolumetricCloudSDF::LoadCloudAssetAsync(v4, 0LL);
		  }
		  else
		  {
		    v13 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v13 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v14 = v13->static_fields->wrapperArray;
		    if ( !v14 )
		      sub_1800D8260(v13, v12);
		    if ( v14->max_length.size <= 5033 )
		      goto LABEL_25;
		    if ( !v13->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v13);
		      v13 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v15 = v13->static_fields->wrapperArray;
		    if ( !v15 )
		      sub_1800D8260(v13, v12);
		    if ( v15->max_length.size <= 0x13A9u )
		      sub_1800D2AB0(v13, v12);
		    if ( v15[139].vector[29] )
		    {
		      v16 = IFix::WrappersManagerImpl::GetPatch(5033, 0LL);
		      if ( !v16 )
		        sub_1800D8260(v18, v17);
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)v16, (Object *)v4, 0LL);
		    }
		    else
		    {
		LABEL_25:
		      m_CloudAsset = v4->fields.m_CloudAsset;
		      m_WindFieldManager = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        m_WindFieldManager = TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          m_WindFieldManager = TypeInfo::UnityEngine::Object;
		        }
		      }
		      if ( m_CloudAsset )
		      {
		        if ( !m_WindFieldManager->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(m_WindFieldManager);
		        if ( m_CloudAsset->fields._._.m_CachedPtr )
		        {
		          if ( !v4->fields.m_CloudAsset )
		            sub_1800D8260(m_WindFieldManager, v12);
		          HG::Rendering::Runtime::VolumetricSdfAsset::UnloadAssets(v4->fields.m_CloudAsset, 0LL);
		        }
		      }
		    }
		  }
		  if ( IsAnyVisibleInScene )
		  {
		    if ( !v4->fields.m_WindFieldNodeList )
		      sub_1800D8260(m_WindFieldManager, v12);
		    System::Collections::Generic::List<unsigned long>::GetEnumerator(
		      (List_1_T_Enumerator_System_UInt64_ *)&v28,
		      (List_1_System_UInt64_ *)v4->fields.m_WindFieldNodeList,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricWindFieldNode>::GetEnumerator);
		    v29 = v28;
		    v28._list = 0LL;
		    *(_QWORD *)&v28._index = &v29;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                &v29,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VolumetricWindFieldNode>::MoveNext) )
		      {
		        if ( !v29._current )
		          sub_1800D8250(0LL, v12);
		        HG::Rendering::Runtime::VolumetricWindFieldNode::Update((VolumetricWindFieldNode *)v29._current, 0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v27 )
		    {
		      v12 = &v26;
		      v28._list = (List_1_System_Object_ *)v27->ex;
		      if ( v28._list )
		        sub_18007E1E0(v28._list);
		      v3 = force;
		      v4 = this;
		    }
		    m_WindFieldManager = (struct Object_1__Class *)v4->fields.m_WindFieldManager;
		    if ( !m_WindFieldManager )
		LABEL_58:
		      sub_1800D8250(m_WindFieldManager, v12);
		    HG::Rendering::Runtime::VolumetricWindFieldManager::Tick((VolumetricWindFieldManager *)m_WindFieldManager, 0LL);
		  }
		  m_propertyBlock = v4->fields.m_propertyBlock;
		  if ( !m_propertyBlock )
		    goto LABEL_58;
		  v22 = (void (__fastcall *)(MaterialPropertyBlock *, __int64 *))qword_18F36F468;
		  if ( !qword_18F36F468 )
		  {
		    v22 = (void (__fastcall *)(MaterialPropertyBlock *, __int64 *))il2cpp_resolve_icall_1(
		                                                                     "UnityEngine.MaterialPropertyBlock::Clear(System.Boolean)");
		    if ( !v22 )
		    {
		      v25 = sub_1802EE1B8("UnityEngine.MaterialPropertyBlock::Clear(System.Boolean)");
		      sub_18007E1B0(v25, 0LL);
		    }
		    qword_18F36F468 = (__int64)v22;
		  }
		  LOBYTE(v12) = 1;
		  v22(m_propertyBlock, v12);
		  m_CloudMat = v4->fields.m_CloudMat;
		  v24 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v24 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v24 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( m_CloudMat )
		  {
		    if ( !v24->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v24);
		    if ( m_CloudMat->fields._.m_CachedPtr )
		    {
		      HG::Rendering::Runtime::VolumetricCloudSDF::UpdateViewMode(v4, 0LL);
		      if ( v3 || IsAnyVisibleInScene )
		        HG::Rendering::Runtime::VolumetricCloudSDF::UpdateMat(v4, 0LL);
		    }
		  }
		}
		
		private void LateUpdate() {} // 0x00000001831C5390-0x00000001831C5410
		// Void LateUpdate()
		void HG::Rendering::Runtime::VolumetricCloudSDF::LateUpdate(VolumetricCloudSDF *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  unsigned int (*v5)(void); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size > 5064 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x13C8 )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !v3[107].vtable.Equals.methodPtr )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(5064, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		        return;
		      }
		    }
		LABEL_9:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  v5 = (unsigned int (*)(void))qword_18F36FE78;
		  if ( !qword_18F36FE78 )
		  {
		    v5 = (unsigned int (*)(void))il2cpp_resolve_icall_1("UnityEngine.SystemInfo::GetGraphicsDeviceType()");
		    if ( !v5 )
		    {
		      v7 = sub_1802EE1B8("UnityEngine.SystemInfo::GetGraphicsDeviceType()");
		      sub_18007E1B0(v7, 0LL);
		    }
		    qword_18F36FE78 = (__int64)v5;
		  }
		  if ( v5() != 4 )
		    HG::Rendering::Runtime::VolumetricCloudSDF::ClearFrameStates(this, 0LL);
		}
		
		private void ClearFrameStates() {} // 0x00000001831C5410-0x00000001831C6830
		// Void ClearFrameStates()
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::VolumetricCloudSDF::ClearFrameStates(VolumetricCloudSDF *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v5; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Dictionary_2_System_Int32_System_Boolean_ *visibleStates; // r13
		  System::Array *buckets; // rbx
		  int v11; // r12d
		  int v12; // r15d
		  int v13; // r15d
		  int *v14; // rsi
		  int v15; // esi
		  int v16; // edi
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  int v19; // esi
		  System::Array *entries; // rbx
		  __int64 v21; // rax
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  SystemException *v24; // rbx
		  __int64 v25; // rax
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  SystemException *v28; // rbx
		  __int64 v29; // rax
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  SystemException *v32; // rbx
		  int v33; // r15d
		  int v34; // r15d
		  int *v35; // rdi
		  int v36; // edi
		  __int64 v37; // rax
		  __int64 v38; // rdx
		  __int64 v39; // rcx
		  SystemException *v40; // rbx
		  __int64 v41; // rax
		  __int64 v42; // rdx
		  __int64 v43; // rcx
		  SystemException *v44; // rbx
		  __int64 v45; // rax
		  __int64 v46; // rdx
		  __int64 v47; // rcx
		  ArgumentNullException *v48; // rbx
		  int v49; // esi
		  Dictionary_2_System_Int32_System_Boolean_ *loadingStates; // r13
		  System::Array *v51; // rbx
		  int v52; // r12d
		  int v53; // r15d
		  int v54; // r15d
		  int *v55; // rdi
		  int v56; // edi
		  __int64 v57; // rdx
		  __int64 v58; // rcx
		  System::Array *v59; // rbx
		  __int64 v60; // rax
		  __int64 v61; // rdx
		  __int64 v62; // rcx
		  SystemException *v63; // rbx
		  __int64 v64; // rax
		  __int64 v65; // rdx
		  __int64 v66; // rcx
		  SystemException *v67; // rbx
		  __int64 v68; // rax
		  __int64 v69; // rdx
		  __int64 v70; // rcx
		  SystemException *v71; // rbx
		  int v72; // r15d
		  int v73; // r15d
		  int *v74; // rdi
		  int v75; // edi
		  int v76; // esi
		  Dictionary_2_System_Int32_System_Boolean_ *fadeInStates; // r13
		  __int64 v78; // rax
		  __int64 v79; // rdx
		  __int64 v80; // rcx
		  SystemException *v81; // rbx
		  __int64 v82; // rax
		  __int64 v83; // rdx
		  __int64 v84; // rcx
		  SystemException *v85; // rbx
		  __int64 v86; // rax
		  __int64 v87; // rdx
		  __int64 v88; // rcx
		  ArgumentNullException *v89; // rbx
		  System::Array *v90; // rbx
		  int v91; // r12d
		  int v92; // r15d
		  int v93; // r15d
		  int *v94; // rdi
		  int v95; // edi
		  int v96; // esi
		  __int64 v97; // rdx
		  __int64 v98; // rcx
		  System::Array *v99; // rbx
		  __int64 v100; // rax
		  __int64 v101; // rdx
		  __int64 v102; // rcx
		  SystemException *v103; // rbx
		  __int64 v104; // rax
		  __int64 v105; // rdx
		  __int64 v106; // rcx
		  SystemException *v107; // rbx
		  __int64 v108; // rax
		  __int64 v109; // rdx
		  __int64 v110; // rcx
		  SystemException *v111; // rbx
		  int v112; // esi
		  int v113; // esi
		  int *v114; // rdi
		  int v115; // edi
		  int v116; // r12d
		  struct VolumetricCloudSDF__Class *v117; // rax
		  List_1_System_Int32_ *farRenderersToDelete; // rbx
		  __int64 v119; // rax
		  __int64 v120; // rdx
		  __int64 v121; // rcx
		  SystemException *v122; // rbx
		  __int64 v123; // rax
		  __int64 v124; // rdx
		  __int64 v125; // rcx
		  SystemException *v126; // rbx
		  __int64 v127; // rax
		  __int64 v128; // rdx
		  __int64 v129; // rcx
		  ArgumentNullException *v130; // rbx
		  VolumetricCloudSDF *v131; // rsi
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_VolumetricFarCloudRenderer_ *farRenderers; // rbx
		  __int64 *v133; // rdx
		  signed __int64 v134; // rcx
		  signed __int64 v135; // rtt
		  __int64 *v136; // rdx
		  signed __int64 v137; // rcx
		  KeyValuePair_2_System_Int32Enum_System_Object_ current; // xmm6
		  VolumetricFarCloudRenderer *v139; // rcx
		  __int64 v140; // rdx
		  struct VolumetricCloudSDF__Class *v141; // rax
		  List_1_System_Int32_ *v142; // rcx
		  struct VolumetricCloudSDF__Class *v143; // rax
		  List_1_System_Int32_ *v144; // r9
		  signed __int64 v145; // rtt
		  __int64 v146; // rax
		  __int64 v147; // rdx
		  __int64 v148; // rdx
		  int32_t v149; // ebx
		  Dictionary_2_System_Int32_System_Object_ *v150; // rcx
		  Object *Item; // rax
		  __int64 v152; // rdx
		  __int64 v153; // rcx
		  __int64 v154; // rdx
		  Dictionary_2_System_Int32_System_Object_ *v155; // rcx
		  Il2CppClass *klass; // rcx
		  __int64 v157; // rax
		  __int64 v158; // rax
		  __int64 v159; // rax
		  __int64 v160; // rax
		  __int64 v161; // rax
		  String *v162; // rax
		  __int64 v163; // rax
		  String *v164; // rax
		  __int64 v165; // rax
		  String *v166; // rax
		  __int64 v167; // rax
		  __int64 v168; // rax
		  __int64 v169; // rax
		  __int64 v170; // rax
		  String *v171; // rax
		  __int64 v172; // rax
		  String *v173; // rax
		  __int64 v174; // rax
		  String *v175; // rax
		  __int64 v176; // rax
		  __int64 v177; // rax
		  __int64 v178; // rax
		  __int64 v179; // rax
		  __int64 v180; // rax
		  __int64 v181; // rax
		  String *v182; // rax
		  __int64 v183; // rax
		  String *v184; // rax
		  __int64 v185; // rax
		  String *v186; // rax
		  __int64 v187; // rax
		  __int64 v188; // rax
		  __int64 v189; // rax
		  __int64 v190; // rax
		  String *v191; // rax
		  __int64 v192; // rax
		  String *v193; // rax
		  __int64 v194; // rax
		  String *v195; // rax
		  __int64 v196; // rax
		  __int64 v197; // rax
		  __int64 v198; // rax
		  __int64 v199; // rax
		  __int64 v200; // rax
		  __int64 v201; // rax
		  String *v202; // rax
		  __int64 v203; // rax
		  String *v204; // rax
		  __int64 v205; // rax
		  String *v206; // rax
		  __int64 v207; // rax
		  __int64 v208; // rax
		  __int64 v209; // rax
		  __int64 v210; // rax
		  String *v211; // rax
		  __int64 v212; // rax
		  String *v213; // rax
		  __int64 v214; // rax
		  String *v215; // rax
		  __int64 v216; // rax
		  __int64 v217; // [rsp+0h] [rbp-D8h] BYREF
		  _BYTE v218[40]; // [rsp+20h] [rbp-B8h] BYREF
		  __int128 v219; // [rsp+48h] [rbp-90h] BYREF
		  __int64 v220; // [rsp+58h] [rbp-80h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v221; // [rsp+60h] [rbp-78h] BYREF
		  Il2CppExceptionWrapper *v222; // [rsp+88h] [rbp-50h] BYREF
		  Il2CppExceptionWrapper *v223; // [rsp+90h] [rbp-48h] BYREF
		  int count; // [rsp+F0h] [rbp+18h]
		  int v226; // [rsp+F0h] [rbp+18h]
		  int v227; // [rsp+F0h] [rbp+18h]
		
		  memset(&v221, 0, sizeof(v221));
		  v219 = 0LL;
		  v220 = 0LL;
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v3, method);
		  if ( wrapperArray->max_length.size <= 5049 )
		    goto LABEL_12;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = v3->static_fields->wrapperArray;
		  if ( !v5 )
		    sub_1800D8260(v3, method);
		  if ( v5->max_length.size <= 0x13B9u )
		    sub_1800D2AB0(v3, method);
		  if ( v5[140].vector[9] )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5049, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		LABEL_12:
		    visibleStates = this->fields._visibleStates;
		    if ( !visibleStates )
		      sub_1800D8260(v3, method);
		    count = visibleStates->fields._count;
		    if ( count > 0 )
		    {
		      buckets = (System::Array *)visibleStates->fields._buckets;
		      if ( !buckets )
		        sub_1800D8260(v3, method);
		      v11 = *((_DWORD *)buckets + 6);
		      if ( v11 < 0 )
		      {
		        v29 = sub_180035ED0(&TypeInfo::System::IndexOutOfRangeException);
		        v32 = (SystemException *)sub_1800368D0(v29);
		        if ( !v32 )
		          sub_1800D8260(v31, v30);
		        v166 = (String *)sub_180035ED0(&off_18E32E760);
		        System::SystemException::SystemException(v32, v166, 0LL);
		        v32->fields._._HResult = -2146233080;
		        v167 = sub_180035ED0(&MethodInfo::System::Array::Clear);
		        sub_18007E190(v32, v167);
		      }
		      if ( !*(_QWORD *)buckets )
		      {
		        *(_OWORD *)v218 = 0uLL;
		        v157 = sub_1800D82B0(v218);
		        sub_18007E1B0(v157, 0LL);
		      }
		      if ( !*(_BYTE *)(*(_QWORD *)buckets + 308LL) )
		      {
		        v158 = sub_1800D2AD0(v3, method);
		        sub_18007E1B0(v158, 0LL);
		      }
		      if ( *((_QWORD *)buckets + 2) )
		      {
		        v12 = *(_DWORD *)(*((_QWORD *)buckets + 2) + 8LL);
		        if ( v12 > 0 )
		        {
		          v25 = sub_180035ED0(&TypeInfo::System::IndexOutOfRangeException);
		          v28 = (SystemException *)sub_1800368D0(v25);
		          if ( !v28 )
		            sub_1800D8260(v27, v26);
		          v164 = (String *)sub_180035ED0(&off_18E32E748);
		          System::SystemException::SystemException(v28, v164, 0LL);
		          v28->fields._._HResult = -2146233080;
		          v165 = sub_180035ED0(&MethodInfo::System::Array::Clear);
		          sub_18007E190(v28, v165);
		        }
		      }
		      else
		      {
		        v12 = 0;
		      }
		      v13 = -v12;
		      if ( !*(_QWORD *)buckets )
		      {
		        *(_OWORD *)v218 = 0uLL;
		        v159 = sub_1800D82B0(v218);
		        sub_18007E1B0(v159, 0LL);
		      }
		      if ( !*(_BYTE *)(*(_QWORD *)buckets + 308LL) )
		      {
		        v160 = sub_1800D2AD0(v3, method);
		        sub_18007E1B0(v160, 0LL);
		      }
		      v14 = (int *)((char *)buckets + 24);
		      if ( *((_QWORD *)buckets + 2) )
		        v14 = (int *)*((_QWORD *)buckets + 2);
		      v15 = *v14;
		      v16 = 1;
		      if ( *(_BYTE *)(*(_QWORD *)buckets + 308LL) > 1u )
		      {
		        do
		          v15 *= (unsigned int)System::Array::GetLength(buckets, v16++);
		        while ( v16 < *(unsigned __int8 *)(*(_QWORD *)buckets + 308LL) );
		      }
		      if ( v13 > v15 - v11 )
		      {
		        v21 = sub_180035ED0(&TypeInfo::System::IndexOutOfRangeException);
		        v24 = (SystemException *)sub_1800368D0(v21);
		        if ( !v24 )
		          sub_1800D8260(v23, v22);
		        v162 = (String *)sub_180035ED0(&off_18E32E750);
		        System::SystemException::SystemException(v24, v162, 0LL);
		        v24->fields._._HResult = -2146233080;
		        v163 = sub_180035ED0(&MethodInfo::System::Array::Clear);
		        sub_18007E190(v24, v163);
		      }
		      sub_18033B9D0(
		        (char *)buckets + v13 * (__int64)*(int *)(*(_QWORD *)buckets + 256LL) + 32,
		        0LL,
		        v11 * *(_DWORD *)(*(_QWORD *)buckets + 256LL));
		      v19 = 1;
		      visibleStates->fields._count = 0;
		      visibleStates->fields._freeList = -1;
		      visibleStates->fields._freeCount = 0;
		      entries = (System::Array *)visibleStates->fields._entries;
		      if ( !entries )
		      {
		        v45 = sub_180035ED0(&TypeInfo::System::ArgumentNullException);
		        v48 = (ArgumentNullException *)sub_1800368D0(v45);
		        if ( !v48 )
		          sub_1800D8260(v47, v46);
		        v175 = (String *)sub_180035ED0(&off_18E2A45F8);
		        System::ArgumentNullException::ArgumentNullException(v48, v175, 0LL);
		        v176 = sub_180035ED0(&MethodInfo::System::Array::Clear);
		        sub_18007E190(v48, v176);
		      }
		      if ( !*(_QWORD *)entries )
		      {
		        *(_OWORD *)v218 = 0uLL;
		        v161 = sub_1800D82B0(v218);
		        sub_18007E1B0(v161, 0LL);
		      }
		      if ( !*(_BYTE *)(*(_QWORD *)entries + 308LL) )
		      {
		        v168 = sub_1800D2AD0(v18, v17);
		        sub_18007E1B0(v168, 0LL);
		      }
		      if ( *((_QWORD *)entries + 2) )
		      {
		        v33 = *(_DWORD *)(*((_QWORD *)entries + 2) + 8LL);
		        if ( v33 > 0 )
		        {
		          v41 = sub_180035ED0(&TypeInfo::System::IndexOutOfRangeException);
		          v44 = (SystemException *)sub_1800368D0(v41);
		          if ( !v44 )
		            sub_1800D8260(v43, v42);
		          v173 = (String *)sub_180035ED0(&off_18E32E748);
		          System::SystemException::SystemException(v44, v173, 0LL);
		          v44->fields._._HResult = -2146233080;
		          v174 = sub_180035ED0(&MethodInfo::System::Array::Clear);
		          sub_18007E190(v44, v174);
		        }
		      }
		      else
		      {
		        v33 = 0;
		      }
		      v34 = -v33;
		      if ( !*(_QWORD *)entries )
		      {
		        *(_OWORD *)v218 = 0uLL;
		        v169 = sub_1800D82B0(v218);
		        sub_18007E1B0(v169, 0LL);
		      }
		      if ( !*(_BYTE *)(*(_QWORD *)entries + 308LL) )
		      {
		        v170 = sub_1800D2AD0(v18, v17);
		        sub_18007E1B0(v170, 0LL);
		      }
		      v35 = (int *)((char *)entries + 24);
		      if ( *((_QWORD *)entries + 2) )
		        v35 = (int *)*((_QWORD *)entries + 2);
		      v36 = *v35;
		      if ( *(_BYTE *)(*(_QWORD *)entries + 308LL) > 1u )
		      {
		        do
		          v36 *= (unsigned int)System::Array::GetLength(entries, v19++);
		        while ( v19 < *(unsigned __int8 *)(*(_QWORD *)entries + 308LL) );
		      }
		      if ( v34 > v36 - count )
		      {
		        v37 = sub_180035ED0(&TypeInfo::System::IndexOutOfRangeException);
		        v40 = (SystemException *)sub_1800368D0(v37);
		        if ( !v40 )
		          sub_1800D8260(v39, v38);
		        v171 = (String *)sub_180035ED0(&off_18E32E750);
		        System::SystemException::SystemException(v40, v171, 0LL);
		        v40->fields._._HResult = -2146233080;
		        v172 = sub_180035ED0(&MethodInfo::System::Array::Clear);
		        sub_18007E190(v40, v172);
		      }
		      sub_18033B9D0(
		        (char *)entries + v34 * (__int64)*(int *)(*(_QWORD *)entries + 256LL) + 32,
		        0LL,
		        count * *(_DWORD *)(*(_QWORD *)entries + 256LL));
		    }
		    v49 = 1;
		    ++visibleStates->fields._version;
		    loadingStates = this->fields._loadingStates;
		    if ( !loadingStates )
		      sub_1800D8260(v3, method);
		    v226 = loadingStates->fields._count;
		    if ( v226 > 0 )
		    {
		      v51 = (System::Array *)loadingStates->fields._buckets;
		      if ( !v51 )
		        sub_1800D8260(v3, method);
		      v52 = *((_DWORD *)v51 + 6);
		      if ( v52 < 0 )
		      {
		        v68 = sub_180035ED0(&TypeInfo::System::IndexOutOfRangeException);
		        v71 = (SystemException *)sub_1800368D0(v68);
		        if ( !v71 )
		          sub_1800D8260(v70, v69);
		        v186 = (String *)sub_180035ED0(&off_18E32E760);
		        System::SystemException::SystemException(v71, v186, 0LL);
		        v71->fields._._HResult = -2146233080;
		        v187 = sub_180035ED0(&MethodInfo::System::Array::Clear);
		        sub_18007E190(v71, v187);
		      }
		      if ( !*(_QWORD *)v51 )
		      {
		        *(_OWORD *)v218 = 0uLL;
		        v177 = sub_1800D82B0(v218);
		        sub_18007E1B0(v177, 0LL);
		      }
		      if ( !*(_BYTE *)(*(_QWORD *)v51 + 308LL) )
		      {
		        v178 = sub_1800D2AD0(v3, method);
		        sub_18007E1B0(v178, 0LL);
		      }
		      if ( *((_QWORD *)v51 + 2) )
		      {
		        v53 = *(_DWORD *)(*((_QWORD *)v51 + 2) + 8LL);
		        if ( v53 > 0 )
		        {
		          v64 = sub_180035ED0(&TypeInfo::System::IndexOutOfRangeException);
		          v67 = (SystemException *)sub_1800368D0(v64);
		          if ( !v67 )
		            sub_1800D8260(v66, v65);
		          v184 = (String *)sub_180035ED0(&off_18E32E748);
		          System::SystemException::SystemException(v67, v184, 0LL);
		          v67->fields._._HResult = -2146233080;
		          v185 = sub_180035ED0(&MethodInfo::System::Array::Clear);
		          sub_18007E190(v67, v185);
		        }
		      }
		      else
		      {
		        v53 = 0;
		      }
		      v54 = -v53;
		      if ( !*(_QWORD *)v51 )
		      {
		        *(_OWORD *)v218 = 0uLL;
		        v179 = sub_1800D82B0(v218);
		        sub_18007E1B0(v179, 0LL);
		      }
		      if ( !*(_BYTE *)(*(_QWORD *)v51 + 308LL) )
		      {
		        v180 = sub_1800D2AD0(v3, method);
		        sub_18007E1B0(v180, 0LL);
		      }
		      v55 = (int *)((char *)v51 + 24);
		      if ( *((_QWORD *)v51 + 2) )
		        v55 = (int *)*((_QWORD *)v51 + 2);
		      v56 = *v55;
		      if ( *(_BYTE *)(*(_QWORD *)v51 + 308LL) > 1u )
		      {
		        do
		          v56 *= (unsigned int)System::Array::GetLength(v51, v49++);
		        while ( v49 < *(unsigned __int8 *)(*(_QWORD *)v51 + 308LL) );
		      }
		      if ( v54 > v56 - v52 )
		      {
		        v60 = sub_180035ED0(&TypeInfo::System::IndexOutOfRangeException);
		        v63 = (SystemException *)sub_1800368D0(v60);
		        if ( !v63 )
		          sub_1800D8260(v62, v61);
		        v182 = (String *)sub_180035ED0(&off_18E32E750);
		        System::SystemException::SystemException(v63, v182, 0LL);
		        v63->fields._._HResult = -2146233080;
		        v183 = sub_180035ED0(&MethodInfo::System::Array::Clear);
		        sub_18007E190(v63, v183);
		      }
		      sub_18033B9D0(
		        (char *)v51 + v54 * (__int64)*(int *)(*(_QWORD *)v51 + 256LL) + 32,
		        0LL,
		        v52 * *(_DWORD *)(*(_QWORD *)v51 + 256LL));
		      loadingStates->fields._count = 0;
		      loadingStates->fields._freeList = -1;
		      loadingStates->fields._freeCount = 0;
		      v59 = (System::Array *)loadingStates->fields._entries;
		      if ( !v59 )
		      {
		        v86 = sub_180035ED0(&TypeInfo::System::ArgumentNullException);
		        v89 = (ArgumentNullException *)sub_1800368D0(v86);
		        if ( !v89 )
		          sub_1800D8260(v88, v87);
		        v195 = (String *)sub_180035ED0(&off_18E2A45F8);
		        System::ArgumentNullException::ArgumentNullException(v89, v195, 0LL);
		        v196 = sub_180035ED0(&MethodInfo::System::Array::Clear);
		        sub_18007E190(v89, v196);
		      }
		      if ( !*(_QWORD *)v59 )
		      {
		        *(_OWORD *)v218 = 0uLL;
		        v181 = sub_1800D82B0(v218);
		        sub_18007E1B0(v181, 0LL);
		      }
		      if ( !*(_BYTE *)(*(_QWORD *)v59 + 308LL) )
		      {
		        v188 = sub_1800D2AD0(v58, v57);
		        sub_18007E1B0(v188, 0LL);
		      }
		      if ( *((_QWORD *)v59 + 2) )
		      {
		        v72 = *(_DWORD *)(*((_QWORD *)v59 + 2) + 8LL);
		        if ( v72 > 0 )
		        {
		          v82 = sub_180035ED0(&TypeInfo::System::IndexOutOfRangeException);
		          v85 = (SystemException *)sub_1800368D0(v82);
		          if ( !v85 )
		            sub_1800D8260(v84, v83);
		          v193 = (String *)sub_180035ED0(&off_18E32E748);
		          System::SystemException::SystemException(v85, v193, 0LL);
		          v85->fields._._HResult = -2146233080;
		          v194 = sub_180035ED0(&MethodInfo::System::Array::Clear);
		          sub_18007E190(v85, v194);
		        }
		      }
		      else
		      {
		        v72 = 0;
		      }
		      v73 = -v72;
		      if ( !*(_QWORD *)v59 )
		      {
		        *(_OWORD *)v218 = 0uLL;
		        v189 = sub_1800D82B0(v218);
		        sub_18007E1B0(v189, 0LL);
		      }
		      if ( !*(_BYTE *)(*(_QWORD *)v59 + 308LL) )
		      {
		        v190 = sub_1800D2AD0(v58, v57);
		        sub_18007E1B0(v190, 0LL);
		      }
		      v74 = (int *)((char *)v59 + 24);
		      if ( *((_QWORD *)v59 + 2) )
		        v74 = (int *)*((_QWORD *)v59 + 2);
		      v75 = *v74;
		      v76 = 1;
		      if ( *(_BYTE *)(*(_QWORD *)v59 + 308LL) > 1u )
		      {
		        do
		          v75 *= (unsigned int)System::Array::GetLength(v59, v76++);
		        while ( v76 < *(unsigned __int8 *)(*(_QWORD *)v59 + 308LL) );
		      }
		      if ( v73 > v75 - v226 )
		      {
		        v78 = sub_180035ED0(&TypeInfo::System::IndexOutOfRangeException);
		        v81 = (SystemException *)sub_1800368D0(v78);
		        if ( !v81 )
		          sub_1800D8260(v80, v79);
		        v191 = (String *)sub_180035ED0(&off_18E32E750);
		        System::SystemException::SystemException(v81, v191, 0LL);
		        v81->fields._._HResult = -2146233080;
		        v192 = sub_180035ED0(&MethodInfo::System::Array::Clear);
		        sub_18007E190(v81, v192);
		      }
		      sub_18033B9D0(
		        (char *)v59 + v73 * (__int64)*(int *)(*(_QWORD *)v59 + 256LL) + 32,
		        0LL,
		        v226 * *(_DWORD *)(*(_QWORD *)v59 + 256LL));
		    }
		    ++loadingStates->fields._version;
		    fadeInStates = this->fields._fadeInStates;
		    if ( !fadeInStates )
		      sub_1800D8260(v3, method);
		    v227 = fadeInStates->fields._count;
		    if ( v227 > 0 )
		    {
		      v90 = (System::Array *)fadeInStates->fields._buckets;
		      if ( !v90 )
		        sub_1800D8260(v3, method);
		      v91 = *((_DWORD *)v90 + 6);
		      if ( v91 < 0 )
		      {
		        v108 = sub_180035ED0(&TypeInfo::System::IndexOutOfRangeException);
		        v111 = (SystemException *)sub_1800368D0(v108);
		        if ( !v111 )
		          sub_1800D8260(v110, v109);
		        v206 = (String *)sub_180035ED0(&off_18E32E760);
		        System::SystemException::SystemException(v111, v206, 0LL);
		        v111->fields._._HResult = -2146233080;
		        v207 = sub_180035ED0(&MethodInfo::System::Array::Clear);
		        sub_18007E190(v111, v207);
		      }
		      if ( !*(_QWORD *)v90 )
		      {
		        *(_OWORD *)v218 = 0uLL;
		        v197 = sub_1800D82B0(v218);
		        sub_18007E1B0(v197, 0LL);
		      }
		      if ( !*(_BYTE *)(*(_QWORD *)v90 + 308LL) )
		      {
		        v198 = sub_1800D2AD0(v3, method);
		        sub_18007E1B0(v198, 0LL);
		      }
		      if ( *((_QWORD *)v90 + 2) )
		      {
		        v92 = *(_DWORD *)(*((_QWORD *)v90 + 2) + 8LL);
		        if ( v92 > 0 )
		        {
		          v104 = sub_180035ED0(&TypeInfo::System::IndexOutOfRangeException);
		          v107 = (SystemException *)sub_1800368D0(v104);
		          if ( !v107 )
		            sub_1800D8260(v106, v105);
		          v204 = (String *)sub_180035ED0(&off_18E32E748);
		          System::SystemException::SystemException(v107, v204, 0LL);
		          v107->fields._._HResult = -2146233080;
		          v205 = sub_180035ED0(&MethodInfo::System::Array::Clear);
		          sub_18007E190(v107, v205);
		        }
		      }
		      else
		      {
		        v92 = 0;
		      }
		      v93 = -v92;
		      if ( !*(_QWORD *)v90 )
		      {
		        *(_OWORD *)v218 = 0uLL;
		        v199 = sub_1800D82B0(v218);
		        sub_18007E1B0(v199, 0LL);
		      }
		      if ( !*(_BYTE *)(*(_QWORD *)v90 + 308LL) )
		      {
		        v200 = sub_1800D2AD0(v3, method);
		        sub_18007E1B0(v200, 0LL);
		      }
		      v94 = (int *)((char *)v90 + 24);
		      if ( *((_QWORD *)v90 + 2) )
		        v94 = (int *)*((_QWORD *)v90 + 2);
		      v95 = *v94;
		      v96 = 1;
		      if ( *(_BYTE *)(*(_QWORD *)v90 + 308LL) > 1u )
		      {
		        do
		          v95 *= (unsigned int)System::Array::GetLength(v90, v96++);
		        while ( v96 < *(unsigned __int8 *)(*(_QWORD *)v90 + 308LL) );
		      }
		      if ( v93 > v95 - v91 )
		      {
		        v100 = sub_180035ED0(&TypeInfo::System::IndexOutOfRangeException);
		        v103 = (SystemException *)sub_1800368D0(v100);
		        if ( !v103 )
		          sub_1800D8260(v102, v101);
		        v202 = (String *)sub_180035ED0(&off_18E32E750);
		        System::SystemException::SystemException(v103, v202, 0LL);
		        v103->fields._._HResult = -2146233080;
		        v203 = sub_180035ED0(&MethodInfo::System::Array::Clear);
		        sub_18007E190(v103, v203);
		      }
		      sub_18033B9D0(
		        (char *)v90 + *(int *)(*(_QWORD *)v90 + 256LL) * (__int64)v93 + 32,
		        0LL,
		        *(_DWORD *)(*(_QWORD *)v90 + 256LL) * v91);
		      fadeInStates->fields._count = 0;
		      fadeInStates->fields._freeList = -1;
		      fadeInStates->fields._freeCount = 0;
		      v99 = (System::Array *)fadeInStates->fields._entries;
		      if ( !v99 )
		      {
		        v127 = sub_180035ED0(&TypeInfo::System::ArgumentNullException);
		        v130 = (ArgumentNullException *)sub_1800368D0(v127);
		        if ( !v130 )
		          sub_1800D8260(v129, v128);
		        v215 = (String *)sub_180035ED0(&off_18E2A45F8);
		        System::ArgumentNullException::ArgumentNullException(v130, v215, 0LL);
		        v216 = sub_180035ED0(&MethodInfo::System::Array::Clear);
		        sub_18007E190(v130, v216);
		      }
		      if ( !*(_QWORD *)v99 )
		      {
		        *(_OWORD *)v218 = 0uLL;
		        v201 = sub_1800D82B0(v218);
		        sub_18007E1B0(v201, 0LL);
		      }
		      if ( !*(_BYTE *)(*(_QWORD *)v99 + 308LL) )
		      {
		        v208 = sub_1800D2AD0(v98, v97);
		        sub_18007E1B0(v208, 0LL);
		      }
		      if ( *((_QWORD *)v99 + 2) )
		      {
		        v112 = *(_DWORD *)(*((_QWORD *)v99 + 2) + 8LL);
		        if ( v112 > 0 )
		        {
		          v123 = sub_180035ED0(&TypeInfo::System::IndexOutOfRangeException);
		          v126 = (SystemException *)sub_1800368D0(v123);
		          if ( !v126 )
		            sub_1800D8260(v125, v124);
		          v213 = (String *)sub_180035ED0(&off_18E32E748);
		          System::SystemException::SystemException(v126, v213, 0LL);
		          v126->fields._._HResult = -2146233080;
		          v214 = sub_180035ED0(&MethodInfo::System::Array::Clear);
		          sub_18007E190(v126, v214);
		        }
		      }
		      else
		      {
		        v112 = 0;
		      }
		      v113 = -v112;
		      if ( !*(_QWORD *)v99 )
		      {
		        *(_OWORD *)v218 = 0uLL;
		        v209 = sub_1800D82B0(v218);
		        sub_18007E1B0(v209, 0LL);
		      }
		      if ( !*(_BYTE *)(*(_QWORD *)v99 + 308LL) )
		      {
		        v210 = sub_1800D2AD0(v98, v97);
		        sub_18007E1B0(v210, 0LL);
		      }
		      v114 = (int *)((char *)v99 + 24);
		      if ( *((_QWORD *)v99 + 2) )
		        v114 = (int *)*((_QWORD *)v99 + 2);
		      v115 = *v114;
		      if ( *(_BYTE *)(*(_QWORD *)v99 + 308LL) > 1u )
		      {
		        v116 = 1;
		        do
		          v115 *= (unsigned int)System::Array::GetLength(v99, v116++);
		        while ( v116 < *(unsigned __int8 *)(*(_QWORD *)v99 + 308LL) );
		      }
		      if ( v113 > v115 - v227 )
		      {
		        v119 = sub_180035ED0(&TypeInfo::System::IndexOutOfRangeException);
		        v122 = (SystemException *)sub_1800368D0(v119);
		        if ( !v122 )
		          sub_1800D8260(v121, v120);
		        v211 = (String *)sub_180035ED0(&off_18E32E750);
		        System::SystemException::SystemException(v122, v211, 0LL);
		        v122->fields._._HResult = -2146233080;
		        v212 = sub_180035ED0(&MethodInfo::System::Array::Clear);
		        sub_18007E190(v122, v212);
		      }
		      sub_18033B9D0(
		        (char *)v99 + v113 * (__int64)*(int *)(*(_QWORD *)v99 + 256LL) + 32,
		        0LL,
		        *(_DWORD *)(*(_QWORD *)v99 + 256LL) * v227);
		    }
		    ++fadeInStates->fields._version;
		    v117 = TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF;
		    if ( !TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF);
		      v117 = TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF;
		    }
		    farRenderersToDelete = v117->static_fields->farRenderersToDelete;
		    if ( !farRenderersToDelete )
		      sub_1800D8260(v3, method);
		    ++farRenderersToDelete->fields._version;
		    farRenderersToDelete->fields._size = 0;
		    v131 = this;
		    farRenderers = this->fields.farRenderers;
		    if ( !farRenderers )
		      sub_1800D8260(v3, method);
		    memset(&v218[8], 0, 32);
		    *(_QWORD *)v218 = farRenderers;
		    if ( dword_18F35FD08 )
		    {
		      v133 = &qword_18F0BCBA0[(((unsigned __int64)v218 >> 12) & 0x1FFFFF) >> 6];
		      _m_prefetchw(v133 + 36190);
		      do
		      {
		        v134 = v133[36190] | (1LL << (((unsigned __int64)v218 >> 12) & 0x3F));
		        v135 = v133[36190];
		      }
		      while ( v135 != _InterlockedCompareExchange64(v133 + 36190, v134, v135) );
		    }
		    *(_QWORD *)&v218[8] = (unsigned int)farRenderers->fields._version;
		    *(_DWORD *)&v218[32] = 2;
		    *(_OWORD *)&v218[16] = 0LL;
		    *(_OWORD *)&v221._dictionary = *(_OWORD *)v218;
		    v221._current = 0LL;
		    *(_QWORD *)&v221._getEnumeratorRetType = *(_QWORD *)&v218[32];
		    *(_QWORD *)v218 = 0LL;
		    *(_QWORD *)&v218[8] = &v221;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
		                &v221,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::MoveNext) )
		      {
		        current = v221._current;
		        v139 = (VolumetricFarCloudRenderer *)_mm_srli_si128((__m128i)v221._current, 8).m128i_u64[0];
		        if ( !v139 )
		          sub_1800D8250(0LL, v136);
		        if ( HG::Rendering::Runtime::VolumetricFarCloudRenderer::CanBeReleased(v139, 0LL) )
		        {
		          v141 = TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF;
		          if ( !TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF);
		            v141 = TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF;
		          }
		          v142 = v141->static_fields->farRenderersToDelete;
		          if ( !v142 )
		            sub_1800D8250(0LL, v140);
		          sub_183081250(
		            v142,
		            (unsigned int)_mm_cvtsi128_si32((__m128i)current),
		            MethodInfo::System::Collections::Generic::List<int>::Add);
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v222 )
		    {
		      v136 = &v217;
		      *(Il2CppExceptionWrapper *)v218 = (Il2CppExceptionWrapper)v222->ex;
		      v137 = *(_QWORD *)v218;
		      if ( *(_QWORD *)v218 )
		        sub_18007E1E0(*(_QWORD *)v218);
		      v131 = this;
		    }
		    v143 = TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF;
		    if ( !TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF);
		      v143 = TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF;
		    }
		    v144 = v143->static_fields->farRenderersToDelete;
		    if ( !v144 )
		      sub_1800D8250(v137, v136);
		    *(_OWORD *)&v218[8] = 0LL;
		    *(_QWORD *)v218 = v144;
		    if ( dword_18F35FD08 )
		    {
		      v136 = &qword_18F0BCBA0[(((unsigned __int64)v218 >> 12) & 0x1FFFFF) >> 6];
		      _m_prefetchw(v136 + 36190);
		      do
		      {
		        v137 = v136[36190] | (1LL << (((unsigned __int64)v218 >> 12) & 0x3F));
		        v145 = v136[36190];
		      }
		      while ( v145 != _InterlockedCompareExchange64(v136 + 36190, v137, v145) );
		    }
		    *(_DWORD *)&v218[8] = 0;
		    *(_DWORD *)&v218[12] = v144->fields._version;
		    *(_DWORD *)&v218[16] = 0;
		    v219 = *(_OWORD *)v218;
		    v220 = *(_QWORD *)&v218[16];
		    *(_QWORD *)v218 = 0LL;
		    *(_QWORD *)&v218[8] = &v219;
		    try
		    {
		      while ( 1 )
		      {
		        v146 = v219;
		        if ( !(_QWORD)v219 )
		          sub_1800D8250(v137, v136);
		        v147 = HIDWORD(v219);
		        if ( HIDWORD(v219) != *(_DWORD *)(v219 + 28) || DWORD2(v219) >= *(_DWORD *)(v219 + 24) )
		          break;
		        v148 = *(_QWORD *)(v219 + 16);
		        if ( !v148 )
		          sub_1800D8250(SDWORD2(v219), 0LL);
		        if ( DWORD2(v219) >= *(_DWORD *)(v148 + 24) )
		          sub_1800D2AA0(
		            SDWORD2(v219),
		            v148,
		            MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext);
		        v149 = *(_DWORD *)(v148 + 4LL * SDWORD2(v219) + 32);
		        LODWORD(v220) = v149;
		        ++DWORD2(v219);
		        v150 = (Dictionary_2_System_Int32_System_Object_ *)v131->fields.farRenderers;
		        if ( !v150 )
		          sub_1800D8250(0LL, v148);
		        Item = System::Collections::Generic::Dictionary<int,System::Object>::get_Item(
		                 v150,
		                 v149,
		                 MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::get_Item);
		        if ( !Item )
		          sub_1800D8250(v153, v152);
		        HG::Rendering::Runtime::VolumetricFarCloudRenderer::Release((VolumetricFarCloudRenderer *)Item, 0LL);
		        v155 = (Dictionary_2_System_Int32_System_Object_ *)v131->fields.farRenderers;
		        if ( !v155 )
		          sub_1800D8250(0LL, v154);
		        System::Collections::Generic::Dictionary<int,System::Object>::Remove(
		          v155,
		          v149,
		          MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::Remove);
		      }
		      klass = MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext->klass;
		      if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
		      {
		        sub_1800360B0(klass, HIDWORD(v219));
		        v147 = HIDWORD(v219);
		        v146 = v219;
		      }
		      if ( !v146 )
		        sub_1800D8250(klass, v147);
		      if ( (_DWORD)v147 != *(_DWORD *)(v146 + 28) )
		        System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
		      DWORD2(v219) = *(_DWORD *)(v146 + 24) + 1;
		      LODWORD(v220) = 0;
		    }
		    catch ( Il2CppExceptionWrapper *v223 )
		    {
		      *(Il2CppExceptionWrapper *)v218 = (Il2CppExceptionWrapper)v223->ex;
		      if ( *(_QWORD *)v218 )
		        sub_18007E1E0(*(_QWORD *)v218);
		    }
		  }
		}
		
		private void LoadCloudAsset() {} // 0x0000000189C4844C-0x0000000189C484CC
		// Void LoadCloudAsset()
		void HG::Rendering::Runtime::VolumetricCloudSDF::LoadCloudAsset(VolumetricCloudSDF *this, MethodInfo *method)
		{
		  Object_1 *m_CloudAsset; // rbx
		  __int64 v4; // rdx
		  VolumetricSdfAsset *v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5065, 0LL) )
		  {
		    m_CloudAsset = (Object_1 *)this->fields.m_CloudAsset;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Inequality(m_CloudAsset, 0LL, 0LL) )
		      return;
		    v5 = this->fields.m_CloudAsset;
		    if ( v5 )
		    {
		      HG::Rendering::Runtime::VolumetricSdfAsset::LoadAssets(v5, 0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5065, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void LoadCloudAssetAsync() {} // 0x0000000189C483BC-0x0000000189C4844C
		// Void LoadCloudAssetAsync()
		void HG::Rendering::Runtime::VolumetricCloudSDF::LoadCloudAssetAsync(VolumetricCloudSDF *this, MethodInfo *method)
		{
		  Object_1 *m_CloudAsset; // rbx
		  __int64 v4; // rdx
		  VolumetricSdfAsset *v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5028, 0LL) )
		  {
		    m_CloudAsset = (Object_1 *)this->fields.m_CloudAsset;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Inequality(m_CloudAsset, 0LL, 0LL) )
		      return;
		    v5 = this->fields.m_CloudAsset;
		    if ( v5 )
		    {
		      HG::Rendering::Runtime::VolumetricSdfAsset::LoadAssetsAsync(v5, 0LL);
		      v5 = this->fields.m_CloudAsset;
		      if ( v5 )
		      {
		        HG::Rendering::Runtime::VolumetricSdfAsset::UpdateAssetLoading(v5, 0LL);
		        return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5028, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void ReleaseCloudAsset() {} // 0x0000000183399AE0-0x0000000183399BB0
		// Void ReleaseCloudAsset()
		void HG::Rendering::Runtime::VolumetricCloudSDF::ReleaseCloudAsset(VolumetricCloudSDF *this, MethodInfo *method)
		{
		  VolumetricSdfAsset *v3; // rcx
		  __int64 v4; // rdx
		  struct Object_1__Class *v5; // rcx
		  VolumetricSdfAsset *m_CloudAsset; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = (VolumetricSdfAsset *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = (VolumetricSdfAsset *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = **(_QWORD **)&v3[2].fields.VolumeBounds.m_Center.z;
		  if ( !v4 )
		    goto LABEL_13;
		  if ( *(int *)(v4 + 24) > 5033 )
		  {
		    if ( !LODWORD(v3[3].monitor) )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = (VolumetricSdfAsset *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = **(VolumetricSdfAsset ***)&v3[2].fields.VolumeBounds.m_Center.z;
		    if ( !v3 )
		      goto LABEL_13;
		    if ( LODWORD(v3->fields.SdfTexs) <= 0x13A9 )
		      sub_1800D2AB0(v3, v4);
		    if ( *(_QWORD *)&v3[559].fields.VolumeBounds.m_Extents.y )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(5033, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		        return;
		      }
		      goto LABEL_13;
		    }
		  }
		  v5 = TypeInfo::UnityEngine::Object;
		  m_CloudAsset = this->fields.m_CloudAsset;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v5 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v5 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( m_CloudAsset )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v5);
		    if ( m_CloudAsset->fields._._.m_CachedPtr )
		    {
		      v3 = this->fields.m_CloudAsset;
		      if ( v3 )
		      {
		        HG::Rendering::Runtime::VolumetricSdfAsset::UnloadAssets(v3, 0LL);
		        return;
		      }
		LABEL_13:
		      sub_1800D8260(v3, v4);
		    }
		  }
		}
		
		private VolumetricFarCloudRenderer GetFarCloudRenderer(HGCamera hgCamera) => default; // 0x0000000189C47E7C-0x0000000189C47F8C
		// VolumetricFarCloudRenderer GetFarCloudRenderer(HGCamera)
		VolumetricFarCloudRenderer *HG::Rendering::Runtime::VolumetricCloudSDF::GetFarCloudRenderer(
		        VolumetricCloudSDF *this,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Object_1 *camera; // rcx
		  int32_t InstanceID; // eax
		  int32_t v8; // esi
		  VolumetricFarCloudRenderer *v9; // rax
		  Object *v10; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Object *value; // [rsp+48h] [rbp+20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5068, 0LL) )
		  {
		    if ( hgCamera )
		    {
		      camera = (Object_1 *)hgCamera->fields.camera;
		      if ( camera )
		      {
		        InstanceID = UnityEngine::Object::GetInstanceID(camera, 0LL);
		        camera = (Object_1 *)this->fields.farRenderers;
		        v8 = InstanceID;
		        value = 0LL;
		        if ( camera )
		        {
		          if ( !System::Collections::Generic::Dictionary<int,System::Object>::TryGetValue(
		                  (Dictionary_2_System_Int32_System_Object_ *)camera,
		                  InstanceID,
		                  &value,
		                  MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::TryGetValue) )
		          {
		            v9 = (VolumetricFarCloudRenderer *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::VolumetricFarCloudRenderer);
		            v10 = (Object *)v9;
		            if ( !v9 )
		              goto LABEL_12;
		            HG::Rendering::Runtime::VolumetricFarCloudRenderer::VolumetricFarCloudRenderer(v9, 0LL);
		            value = v10;
		            HG::Rendering::Runtime::VolumetricFarCloudRenderer::Initialize((VolumetricFarCloudRenderer *)v10, 0LL);
		            camera = (Object_1 *)this->fields.farRenderers;
		            if ( !camera )
		              goto LABEL_12;
		            System::Collections::Generic::Dictionary<int,System::Object>::Add(
		              (Dictionary_2_System_Int32_System_Object_ *)camera,
		              v8,
		              value,
		              MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::VolumetricFarCloudRenderer>::Add);
		          }
		          camera = (Object_1 *)value;
		          if ( value )
		          {
		            HG::Rendering::Runtime::VolumetricFarCloudRenderer::MarkUsed((VolumetricFarCloudRenderer *)value, 0LL);
		            return (VolumetricFarCloudRenderer *)value;
		          }
		        }
		      }
		    }
		LABEL_12:
		    sub_1800D8260(camera, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5068, 0LL);
		  if ( !Patch )
		    goto LABEL_12;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1475(Patch, (Object *)this, (Object *)hgCamera, 0LL);
		}
		
		protected override void PrepareVolumetricRenderingImpl(ref VolumetricRenderInputs inputs) {} // 0x0000000189C495E8-0x0000000189C49774
		// Void PrepareVolumetricRenderingImpl(VolumetricRenderInputs ByRef)
		void HG::Rendering::Runtime::VolumetricCloudSDF::PrepareVolumetricRenderingImpl(
		        VolumetricCloudSDF *this,
		        VolumetricRenderInputs *inputs,
		        MethodInfo *method)
		{
		  Object_1 *m_CloudMat; // rbx
		  Object_1 *v6; // rbx
		  __int64 v7; // rcx
		  HGRenderGraphContext *context; // rdx
		  VolumetricFarCloudRenderer *FarCloudRenderer; // rbp
		  Object_1 *v10; // rbx
		  HGRenderGraphContext *v11; // r8
		  HGRenderGraphContext *v12; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5071, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5071, 0LL);
		    if ( !Patch )
		      goto LABEL_15;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1487(Patch, (Object *)this, inputs, 0LL);
		  }
		  else
		  {
		    m_CloudMat = (Object_1 *)this->fields.m_CloudMat;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Implicit(m_CloudMat, 0LL)
		      && HG::Rendering::Runtime::VolumetricCloudSDF::IsVisibleFromCamera(this, inputs->hgCamera, 0LL)
		      && this->fields.m_MaxExtent != 0.0 )
		    {
		      v6 = (Object_1 *)this->fields.m_CloudMat;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Implicit(v6, 0LL) )
		      {
		        context = inputs->context;
		        if ( !context )
		          goto LABEL_15;
		        HG::Rendering::Runtime::VolumetricCloudSDF::BakeMSTex(
		          this,
		          context->fields.cmd,
		          this->fields.m_CloudMat,
		          0,
		          0LL);
		      }
		      FarCloudRenderer = HG::Rendering::Runtime::VolumetricCloudSDF::GetFarCloudRenderer(this, inputs->hgCamera, 0LL);
		      v10 = (Object_1 *)this->fields.m_CloudMat;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Implicit(v10, 0LL) )
		      {
		        v11 = inputs->context;
		        if ( !v11 )
		          goto LABEL_15;
		        HG::Rendering::Runtime::VolumetricCloudSDF::UpdateEmptySkipRT(
		          this,
		          inputs->hgCamera,
		          v11->fields.cmd,
		          inputs->volumetricParameters,
		          0LL);
		        v12 = inputs->context;
		        if ( !v12 )
		          goto LABEL_15;
		        HG::Rendering::Runtime::VolumetricCloudSDF::BakeFarCloud(
		          this,
		          FarCloudRenderer,
		          inputs->hgCamera,
		          v12->fields.cmd,
		          inputs->volumetricParameters,
		          0LL);
		      }
		      if ( FarCloudRenderer )
		      {
		        HG::Rendering::Runtime::VolumetricFarCloudRenderer::PostRender(FarCloudRenderer, 0LL);
		        return;
		      }
		LABEL_15:
		      sub_1800D8260(v7, context);
		    }
		  }
		}
		
		private void UpdateViewMode() {} // 0x000000018339A4F0-0x000000018339A890
		// Void UpdateViewMode()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::VolumetricCloudSDF::UpdateViewMode(VolumetricCloudSDF *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v5; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  struct MethodInfo *v9; // rbx
		  const Il2CppRGCTXData *rgctx_data; // rax
		  const Il2CppRGCTXData *v11; // rax
		  void *rgctxDataDummy; // rbx
		  __int64 (__fastcall *v13)(VolumetricCloudSDF *, MethodInfo *); // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  __int64 v16; // rsi
		  void (***v17)(void); // rcx
		  void (**v18)(void); // rdx
		  _QWORD *v19; // rax
		  __int64 v20; // rbx
		  System::Type *v21; // rbx
		  struct Type__Class *v22; // rcx
		  void (__fastcall *v23)(__int64, System::Type *, __int64); // rax
		  __int64 v24; // rdx
		  __int64 v25; // rcx
		  List_1_UnityEngine_MeshRenderer_ *renderers; // rbx
		  __int64 *v27; // rdx
		  __int64 v28; // rtt
		  __int64 v29; // rdx
		  __int64 v30; // rcx
		  Object *current; // rbx
		  void (__fastcall *v32)(Object *, _QWORD); // rax
		  __int64 v33; // rax
		  __int64 v34; // rax
		  __int64 v35; // rax
		  Il2CppExceptionWrapper *v36; // [rsp+40h] [rbp-48h] BYREF
		  _BYTE v37[24]; // [rsp+48h] [rbp-40h] BYREF
		  List_1_T_Enumerator_System_Object_ v38; // [rsp+60h] [rbp-28h] BYREF
		
		  memset(&v38, 0, sizeof(v38));
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v3, method);
		  if ( wrapperArray->max_length.size <= 5039 )
		    goto LABEL_12;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = v3->static_fields->wrapperArray;
		  if ( !v5 )
		    sub_1800D8260(v3, method);
		  if ( v5->max_length.size <= 0x13AFu )
		    sub_1800D2AB0(v3, method);
		  if ( v5[140].max_length.value )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5039, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		LABEL_12:
		    v9 = MethodInfo::UnityEngine::Component::GetComponentsInChildren<UnityEngine::MeshRenderer>;
		    if ( !MethodInfo::UnityEngine::Component::GetComponentsInChildren<UnityEngine::MeshRenderer>->rgctx_data )
		      sub_1800430B0(MethodInfo::UnityEngine::Component::GetComponentsInChildren<UnityEngine::MeshRenderer>);
		    rgctx_data = v9->rgctx_data;
		    if ( !*((_QWORD *)rgctx_data->rgctxDataDummy + 4) )
		      (*(void (__fastcall **)(void *, MethodInfo *))rgctx_data->rgctxDataDummy)(rgctx_data->rgctxDataDummy, method);
		    v11 = v9->rgctx_data;
		    rgctxDataDummy = v11->rgctxDataDummy;
		    if ( !*((_QWORD *)v11->rgctxDataDummy + 7) )
		      sub_1800430B0(v11->rgctxDataDummy);
		    v13 = (__int64 (__fastcall *)(VolumetricCloudSDF *, MethodInfo *))qword_18F36FBC8;
		    if ( !qword_18F36FBC8 )
		    {
		      v13 = (__int64 (__fastcall *)(VolumetricCloudSDF *, MethodInfo *))il2cpp_resolve_icall_1("UnityEngine.Component::get_gameObject()");
		      if ( !v13 )
		      {
		        v33 = sub_1802EE1B8("UnityEngine.Component::get_gameObject()");
		        sub_18007E1B0(v33, 0LL);
		      }
		      qword_18F36FBC8 = (__int64)v13;
		    }
		    v16 = v13(this, method);
		    if ( !v16 )
		      sub_1800D8260(v15, v14);
		    v17 = (void (***)(void))*((_QWORD *)rgctxDataDummy + 7);
		    v18 = *v17;
		    if ( !(*v17)[4] )
		      (*v18)();
		    v19 = (_QWORD *)*((_QWORD *)rgctxDataDummy + 7);
		    v20 = *v19;
		    if ( !*(_QWORD *)(*v19 + 56LL) )
		      sub_1800430B0(*v19);
		    v21 = **(System::Type ***)(v20 + 56);
		    v22 = TypeInfo::System::Type;
		    if ( !TypeInfo::System::Type->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::System::Type);
		      v22 = TypeInfo::System::Type;
		    }
		    if ( v21 )
		    {
		      if ( !v22->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v22);
		      v21 = (System::Type *)System::Type::internal_from_handle(v21, v18);
		    }
		    v23 = (void (__fastcall *)(__int64, System::Type *, __int64))qword_18F36FC18;
		    if ( !qword_18F36FC18 )
		    {
		      v23 = (void (__fastcall *)(__int64, System::Type *, __int64))il2cpp_resolve_icall_1(
		                                                                     "UnityEngine.GameObject::GetComponentsInternal(Syste"
		                                                                     "m.Type,System.Boolean,System.Boolean,System.Boolean"
		                                                                     ",System.Boolean,System.Object)");
		      if ( !v23 )
		      {
		        v34 = sub_1802EE1B8(
		                "UnityEngine.GameObject::GetComponentsInternal(System.Type,System.Boolean,System.Boolean,System.Boolean,S"
		                "ystem.Boolean,System.Object)");
		        sub_18007E1B0(v34, 0LL);
		      }
		      qword_18F36FC18 = (__int64)v23;
		    }
		    v23(v16, v21, 1LL);
		    renderers = this->fields._renderers;
		    if ( !renderers )
		      sub_1800D8260(v25, v24);
		    *(_OWORD *)&v37[8] = 0LL;
		    *(_QWORD *)v37 = renderers;
		    if ( dword_18F35FD08 )
		    {
		      v27 = &qword_18F103690[(((unsigned __int64)v37 >> 12) & 0x1FFFFF) >> 6];
		      _m_prefetchw(v27);
		      do
		        v28 = *v27;
		      while ( v28 != _InterlockedCompareExchange64(v27, *v27 | (1LL << (((unsigned __int64)v37 >> 12) & 0x3F)), *v27) );
		    }
		    *(_DWORD *)&v37[8] = 0;
		    *(_DWORD *)&v37[12] = renderers->fields._version;
		    *(_QWORD *)&v37[16] = 0LL;
		    *(_OWORD *)&v38._list = *(_OWORD *)v37;
		    v38._current = 0LL;
		    *(_QWORD *)v37 = 0LL;
		    *(_QWORD *)&v37[8] = &v38;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                &v38,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::MeshRenderer>::MoveNext) )
		      {
		        current = v38._current;
		        if ( !v38._current )
		          sub_1800D8250(v30, v29);
		        v32 = (void (__fastcall *)(Object *, _QWORD))qword_18F36F4D8;
		        if ( !qword_18F36F4D8 )
		        {
		          v32 = (void (__fastcall *)(Object *, _QWORD))il2cpp_resolve_icall_1("UnityEngine.Renderer::set_enabled(System.Boolean)");
		          if ( !v32 )
		          {
		            v35 = sub_1802EE1B8("UnityEngine.Renderer::set_enabled(System.Boolean)");
		            sub_18007E1B0(v35, 0LL);
		          }
		          qword_18F36F4D8 = (__int64)v32;
		        }
		        v32(current, 0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v36 )
		    {
		      *(Il2CppExceptionWrapper *)v37 = (Il2CppExceptionWrapper)v36->ex;
		      if ( *(_QWORD *)v37 )
		        sub_18007E1E0(*(_QWORD *)v37);
		    }
		  }
		}
		
		private void UpdateEmptySkipRT(HGCamera hgCamera, CommandBuffer cmd, HGVolumetricCloudSettingParameters volumetricParameters) {} // 0x0000000189C49880-0x0000000189C49FEC
		// Void UpdateEmptySkipRT(HGCamera, CommandBuffer, HGVolumetricCloudSettingParameters)
		void HG::Rendering::Runtime::VolumetricCloudSDF::UpdateEmptySkipRT(
		        VolumetricCloudSDF *this,
		        HGCamera *hgCamera,
		        CommandBuffer *cmd,
		        HGVolumetricCloudSettingParameters *volumetricParameters,
		        MethodInfo *method)
		{
		  double v5; // xmm1_8
		  void *static_fields; // rdx
		  void *m_emptySkipPropertyBlock; // rcx
		  Component *camera; // r14
		  Object_1 *m_CloudMat; // rbx
		  Material *v14; // rbx
		  int32_t m_X; // r13d
		  Vector2Int sceneRTSize_k__BackingField; // rbx
		  Material *v17; // rsi
		  unsigned __int64 v18; // rbx
		  float FloatImpl; // xmm7_4
		  float v20; // xmm6_4
		  __m128 v21; // xmm9
		  float v22; // xmm8_4
		  System::Math *v23; // rcx
		  double v24; // xmm1_8
		  System::Math *v25; // rcx
		  Material *v26; // rsi
		  String *v27; // rdx
		  bool IsKeywordEnabled; // al
		  RenderTexture *TemporaryTexture; // rax
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  MaterialPropertyBlock *v32; // r15
		  __int64 v33; // xmm6_8
		  float z; // esi
		  MethodInfo *v35; // r8
		  Vector4 *v36; // rax
		  int32_t v37; // r10d
		  MaterialPropertyBlock *v38; // r15
		  __int128 v39; // xmm1
		  VolumetricShaderIDs__StaticFields *v40; // rcx
		  float v41; // eax
		  __int128 v42; // xmm1
		  __int128 v43; // xmm0
		  Vector4 *v44; // rax
		  __m128 v45; // xmm0
		  float fieldOfView; // xmm6_4
		  __m128 v47; // xmm7
		  Vector2 v48; // rdx
		  Vector2 v49; // r8
		  int32_t v50; // r9d
		  Vector2 v51; // rax
		  MaterialPropertyBlock *v52; // rsi
		  __m128 x_low; // xmm0
		  VolumetricShaderIDs__StaticFields *v54; // rcx
		  int32_t MainCameraFovTan; // r14d
		  __int64 v56; // rdx
		  __int64 v57; // r8
		  __int64 v58; // r9
		  __m128 v59; // xmm7
		  __m128 y_low; // xmm0
		  __int64 v61; // rdx
		  __int64 v62; // rcx
		  __int64 v63; // r8
		  __int64 v64; // r9
		  Vector4 *v65; // rax
		  MaterialPropertyBlock *v66; // rsi
		  int v67; // eax
		  int v68; // r15d
		  int v69; // eax
		  int v70; // r14d
		  int v71; // eax
		  __m128 v72; // xmm2
		  Vector4 *v73; // rax
		  MaterialPropertyBlock *v74; // r10
		  int32_t v75; // r11d
		  __m128 v76; // xmm1
		  __m128 v77; // xmm2
		  Vector4 *v78; // rax
		  MaterialPropertyBlock *v79; // r10
		  int32_t v80; // r11d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v82; // [rsp+38h] [rbp-D0h] BYREF
		  RenderTexture *colorRT; // [rsp+48h] [rbp-C0h] BYREF
		  Vector3 v84; // [rsp+58h] [rbp-B0h] BYREF
		  int32_t v85; // [rsp+68h] [rbp-A0h]
		  int v86; // [rsp+6Ch] [rbp-9Ch]
		  __int64 v87; // [rsp+70h] [rbp-98h] BYREF
		  RenderTextureDescriptor v88; // [rsp+80h] [rbp-88h] BYREF
		  Matrix4x4 v89[2]; // [rsp+B8h] [rbp-50h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5079, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5079, 0LL);
		    if ( !Patch )
		      goto LABEL_26;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_114(
		      (ILFixDynamicMethodWrapper_10 *)Patch,
		      (Object *)this,
		      (Object *)hgCamera,
		      (Object *)cmd,
		      (Object *)volumetricParameters,
		      0LL);
		  }
		  else
		  {
		    if ( !hgCamera )
		      goto LABEL_26;
		    camera = (Component *)hgCamera->fields.camera;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Implicit((Object_1 *)camera, 0LL) )
		    {
		      m_CloudMat = (Object_1 *)this->fields.m_CloudMat;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Implicit(m_CloudMat, 0LL) )
		      {
		        v14 = this->fields.m_CloudMat;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		        static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields;
		        if ( v14 )
		        {
		          if ( !UnityEngine::Material::IsKeywordEnabled(v14, *((String **)static_fields + 1), 0LL) )
		            return;
		          m_X = hgCamera->fields._sceneRTSize_k__BackingField.m_X;
		          sceneRTSize_k__BackingField = hgCamera->fields._sceneRTSize_k__BackingField;
		          v17 = this->fields.m_CloudMat;
		          v18 = HIDWORD(*(unsigned __int64 *)&sceneRTSize_k__BackingField);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		          static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		          if ( v17 )
		          {
		            FloatImpl = UnityEngine::Material::GetFloatImpl(v17, *((_DWORD *)static_fields + 123), 0LL);
		            if ( volumetricParameters )
		            {
		              v20 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                      volumetricParameters->fields.emptySkipSizeScale,
		                      MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		              v21 = (__m128)0x3F800000u;
		              v22 = (float)(1.0
		                          / HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                              volumetricParameters->fields.downResRatio,
		                              MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit))
		                  * (float)(v20 * FloatImpl);
		              sub_1800036A0(TypeInfo::System::Math);
		              System::Math::Ceiling(v23, v5);
		              *(_QWORD *)&v24 = COERCE_UNSIGNED_INT((float)(int)v18);
		              v86 = (int)(float)((float)m_X * v22);
		              *(float *)&v24 = *(float *)&v24 * v22;
		              System::Math::Ceiling(v25, v24);
		              v26 = this->fields.m_CloudMat;
		              v85 = (int)*(float *)&v24;
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		              m_emptySkipPropertyBlock = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields;
		              if ( v26 )
		              {
		                v27 = (String *)*((_QWORD *)m_emptySkipPropertyBlock + 2);
		                memset(&v88._dimension_k__BackingField, 0, 20);
		                v88._dimension_k__BackingField = 2;
		                memset(&v88, 0, 32);
		                IsKeywordEnabled = UnityEngine::Material::IsKeywordEnabled(v26, v27, 0LL);
		                UnityEngine::RenderTextureDescriptor::set_colorFormat(
		                  &v88,
		                  (RenderTextureFormat__Enum)(IsKeywordEnabled
		                                            ? RenderTextureFormat__Enum_ARGBHalf
		                                            : RenderTextureFormat__Enum_RGHalf),
		                  0LL);
		                v88._height_k__BackingField = v85;
		                v88._width_k__BackingField = (int)(float)((float)m_X * v22);
		                v88._volumeDepth_k__BackingField = 1;
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		                LODWORD(v89[0].m03) = v88._memoryless_k__BackingField;
		                *(_OWORD *)&v89[0].m00 = *(_OWORD *)&v88._width_k__BackingField;
		                *(_OWORD *)&v89[0].m01 = *(_OWORD *)&v88._mipCount_k__BackingField;
		                *(_OWORD *)&v89[0].m02 = *(_OWORD *)&v88._dimension_k__BackingField;
		                TemporaryTexture = HG::Rendering::Runtime::VolumetricSDFUtils::GetTemporaryTexture(
		                                     (RenderTextureDescriptor *)v89,
		                                     0LL);
		                m_emptySkipPropertyBlock = this->fields.m_emptySkipPropertyBlock;
		                colorRT = TemporaryTexture;
		                if ( m_emptySkipPropertyBlock )
		                {
		                  UnityEngine::MaterialPropertyBlock::CopyFrom(
		                    (MaterialPropertyBlock *)m_emptySkipPropertyBlock,
		                    this->fields.m_propertyBlock,
		                    0LL);
		                  if ( camera )
		                  {
		                    transform = UnityEngine::Component::get_transform(camera, 0LL);
		                    if ( transform )
		                    {
		                      position = UnityEngine::Transform::get_position(&v84, transform, 0LL);
		                      v32 = this->fields.m_emptySkipPropertyBlock;
		                      z = position->z;
		                      v87 = *(_QWORD *)&position->x;
		                      v33 = v87;
		                      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		                      *(_QWORD *)&v84.x = v33;
		                      v84.z = z;
		                      v36 = UnityEngine::Vector4::op_Implicit(&v82, &v84, v35);
		                      if ( v32 )
		                      {
		                        v82 = *v36;
		                        UnityEngine::MaterialPropertyBlock::SetVector(v32, v37, &v82, 0LL);
		                        v38 = this->fields.m_emptySkipPropertyBlock;
		                        *(_QWORD *)&v82.x = v87;
		                        v39 = *(_OWORD *)&this->fields.m_CloudRenderWorldToLocal.m00;
		                        v40 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                        v82.z = z;
		                        v82.w = 1.0;
		                        v41 = *(float *)&v40->_MainCameraPosLocal;
		                        *(_OWORD *)&v89[0].m00 = v39;
		                        v42 = *(_OWORD *)&this->fields.m_CloudRenderWorldToLocal.m02;
		                        v84.x = v41;
		                        v43 = *(_OWORD *)&this->fields.m_CloudRenderWorldToLocal.m01;
		                        *(_OWORD *)&v89[0].m02 = v42;
		                        *(_OWORD *)&v89[0].m01 = v43;
		                        *(_OWORD *)&v89[0].m03 = *(_OWORD *)&this->fields.m_CloudRenderWorldToLocal.m03;
		                        v44 = UnityEngine::Matrix4x4::op_Multiply((Vector4 *)&v87, v89, &v82, 0LL);
		                        if ( v38 )
		                        {
		                          v82 = *v44;
		                          v45 = (__m128)v82;
		                          UnityEngine::MaterialPropertyBlock::SetVector(v38, SLODWORD(v84.x), &v82, 0LL);
		                          fieldOfView = UnityEngine::Camera::get_fieldOfView((Camera *)camera, 0LL);
		                          v45.m128_f32[0] = UnityEngine::Camera::get_aspect((Camera *)camera, 0LL);
		                          v47 = v45;
		                          v47.m128_f32[0] = v45.m128_f32[0] * fieldOfView;
		                          v45.m128_f32[0] = UnityEngine::Camera::get_fieldOfView((Camera *)camera, 0LL);
		                          v51 = sub_1858CACF0(_mm_unpacklo_ps(v47, v45).m128_u64[0], v48, v49, v50);
		                          v52 = this->fields.m_emptySkipPropertyBlock;
		                          *(Vector2 *)&v84.x = v51;
		                          x_low = (__m128)LODWORD(v51.x);
		                          v54 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                          MainCameraFovTan = v54->_MainCameraFovTan;
		                          x_low.m128_f32[0] = sub_180338A80(v54, v56, v57, v58);
		                          v59 = x_low;
		                          y_low = (__m128)LODWORD(v84.y);
		                          y_low.m128_f32[0] = sub_180338A80(v62, v61, v63, v64);
		                          v65 = (Vector4 *)sub_183240A00(&v82, _mm_unpacklo_ps(v59, y_low).m128_u64[0]);
		                          if ( v52 )
		                          {
		                            v82 = *v65;
		                            UnityEngine::MaterialPropertyBlock::SetVector(v52, MainCameraFovTan, &v82, 0LL);
		                            static_fields = colorRT;
		                            v66 = this->fields.m_emptySkipPropertyBlock;
		                            m_emptySkipPropertyBlock = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                            v84.x = *((float *)m_emptySkipPropertyBlock + 128);
		                            if ( colorRT )
		                            {
		                              v67 = sub_180002F70(5LL, colorRT);
		                              static_fields = colorRT;
		                              v68 = v67;
		                              if ( colorRT )
		                              {
		                                v69 = sub_180002F70(7LL, colorRT);
		                                static_fields = colorRT;
		                                v70 = v69;
		                                if ( colorRT )
		                                {
		                                  v71 = sub_180002F70(5LL, colorRT);
		                                  static_fields = colorRT;
		                                  if ( colorRT )
		                                  {
		                                    v82.x = (float)v68;
		                                    v82.y = (float)v70;
		                                    v82.z = 1.0 / (float)v71;
		                                    v82.w = 1.0 / (float)(int)sub_180002F70(7LL, colorRT);
		                                    if ( v66 )
		                                    {
		                                      UnityEngine::MaterialPropertyBlock::SetVector(v66, SLODWORD(v84.x), &v82, 0LL);
		                                      v72 = (__m128)0x3F800000u;
		                                      v72.m128_f32[0] = 1.0 / (float)((float)m_X * v22);
		                                      v21.m128_f32[0] = 1.0 / (float)((float)(int)v18 * v22);
		                                      v73 = (Vector4 *)sub_183240A00(&v82, _mm_unpacklo_ps(v72, v21).m128_u64[0]);
		                                      if ( v74 )
		                                      {
		                                        v82 = *v73;
		                                        UnityEngine::MaterialPropertyBlock::SetVector(v74, v75, &v82, 0LL);
		                                        v76 = (__m128)COERCE_UNSIGNED_INT((float)v86);
		                                        v77 = (__m128)COERCE_UNSIGNED_INT((float)v85);
		                                        v76.m128_f32[0] = v76.m128_f32[0] / (float)((float)m_X * v22);
		                                        v77.m128_f32[0] = v77.m128_f32[0] / (float)((float)(int)v18 * v22);
		                                        v78 = (Vector4 *)sub_183240A00(&v82, _mm_unpacklo_ps(v76, v77).m128_u64[0]);
		                                        if ( v79 )
		                                        {
		                                          v82 = *v78;
		                                          UnityEngine::MaterialPropertyBlock::SetVector(v79, v80, &v82, 0LL);
		                                          HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTarget(cmd, colorRT, 0LL);
		                                          HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(
		                                            cmd,
		                                            this->fields.m_CloudMat,
		                                            this->fields.m_emptySkipPropertyBlock,
		                                            9,
		                                            0,
		                                            0LL);
		                                          m_emptySkipPropertyBlock = this->fields.m_propertyBlock;
		                                          static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                                          if ( m_emptySkipPropertyBlock )
		                                          {
		                                            UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
		                                              (MaterialPropertyBlock *)m_emptySkipPropertyBlock,
		                                              *((_DWORD *)static_fields + 129),
		                                              (Texture *)colorRT,
		                                              0LL);
		                                            HG::Rendering::Runtime::VolumetricSDFUtils::ReleaseTemporaryTexture(
		                                              &colorRT,
		                                              0LL);
		                                            return;
		                                          }
		                                        }
		                                      }
		                                    }
		                                  }
		                                }
		                              }
		                            }
		                          }
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		LABEL_26:
		        sub_1800D8260(m_emptySkipPropertyBlock, static_fields);
		      }
		    }
		  }
		}
		
		private void UpdateCloudParameters() {} // 0x0000000183C53330-0x0000000183C53E40
		// Void UpdateCloudParameters()
		void HG::Rendering::Runtime::VolumetricCloudSDF::UpdateCloudParameters(VolumetricCloudSDF *this, MethodInfo *method)
		{
		  Object_1 *m_CloudMat; // rbx
		  void *v4; // rdx
		  void *m_CloudObject; // rcx
		  Transform *transform; // rax
		  Vector3 *localScale; // rax
		  float z; // edi
		  __m128 v9; // xmm6
		  float v10; // xmm0_4
		  float x; // xmm1_4
		  Transform *v12; // rbx
		  float m_MaxExtent; // xmm1_4
		  MethodInfo *v14; // r9
		  Vector3 *v15; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  __int64 v18; // xmm0_8
		  void (__fastcall *v19)(Transform *, Vector3 *); // rax
		  VolumetricEncodedTexture *DensityTextureToUse; // rbx
		  Texture *Texture; // rax
		  Vector3 *TextureResolution; // rax
		  __int64 v23; // xmm7_8
		  float v24; // ebx
		  __m128 z_low; // xmm5
		  float y; // xmm0_4
		  __m128 x_low; // xmm4
		  float v28; // xmm2_4
		  float v29; // xmm3_4
		  __m128 v30; // xmm0
		  __m128 v31; // xmm1
		  Transform *v32; // rax
		  Matrix4x4 *worldToLocalMatrix; // rax
		  __int128 v34; // xmm1
		  __int128 v35; // xmm2
		  __int128 v36; // xmm3
		  Transform *v37; // rax
		  Matrix4x4 *localToWorldMatrix; // rax
		  __int64 v39; // rdx
		  GameObject *v40; // rcx
		  __int128 v41; // xmm1
		  __int128 v42; // xmm2
		  __int128 v43; // xmm3
		  Transform *v44; // rbx
		  void (__fastcall *v45)(Transform *, Vector3 *); // rax
		  float deltaTime; // xmm0_4
		  struct VolumetricShaderIDs__Class *v47; // rax
		  Material *v48; // rbx
		  VolumetricShaderIDs__StaticFields *static_fields; // rax
		  MethodInfo *v50; // r8
		  Color v51; // xmm6
		  __m128 v52; // xmm9
		  __m128i v53; // xmm10
		  MethodInfo *v54; // r8
		  Color v55; // xmm8
		  __m128 v56; // xmm13
		  float v57; // xmm14_4
		  MethodInfo *v58; // r8
		  Color v59; // xmm12
		  __m128 v60; // xmm15
		  float FloatImpl; // xmm0_4
		  float v62; // esi
		  __int64 v63; // xmm9_8
		  float v64; // xmm7_4
		  MethodInfo *v65; // r9
		  Vector3 *v66; // rax
		  __int64 v67; // xmm3_8
		  MethodInfo *v68; // r9
		  Vector3 *v69; // rax
		  __int64 v70; // xmm3_8
		  MethodInfo *v71; // r9
		  Vector3 *v72; // rax
		  __int64 v73; // xmm0_8
		  __int64 v74; // xmm3_8
		  MethodInfo *v75; // r9
		  Vector3 *v76; // rax
		  Beyond::JobMathf *v77; // rcx
		  Beyond::JobMathf *v78; // rcx
		  Beyond::JobMathf *v79; // rcx
		  unsigned __int64 v80; // xmm8_8
		  MethodInfo *v81; // r9
		  Vector3 *v82; // rax
		  float v83; // xmm13_4
		  __int64 v84; // xmm3_8
		  MethodInfo *v85; // r9
		  Vector3 *v86; // rax
		  __int64 v87; // xmm3_8
		  MethodInfo *v88; // r9
		  Vector3 *v89; // rax
		  __int64 v90; // xmm3_8
		  MethodInfo *v91; // r9
		  Vector3 *v92; // rax
		  Beyond::JobMathf *v93; // rcx
		  Beyond::JobMathf *v94; // rcx
		  Beyond::JobMathf *v95; // rcx
		  float v96; // ebx
		  unsigned __int64 v97; // xmm6_8
		  MethodInfo *v98; // r9
		  Vector3 *v99; // rax
		  __int64 v100; // xmm3_8
		  MethodInfo *v101; // r9
		  Vector3 *v102; // rax
		  __int64 v103; // xmm3_8
		  MethodInfo *v104; // r9
		  Vector3 *v105; // rax
		  __int64 v106; // xmm3_8
		  MethodInfo *v107; // r9
		  Vector3 *v108; // rax
		  Beyond::JobMathf *v109; // rcx
		  Beyond::JobMathf *v110; // rcx
		  Beyond::JobMathf *v111; // rcx
		  float v112; // xmm2_4
		  MethodInfo *v113; // r9
		  Vector3 *v114; // rax
		  __int64 v115; // xmm3_8
		  MethodInfo *v116; // r9
		  Vector3 *v117; // rax
		  __int64 v118; // xmm3_8
		  MethodInfo *v119; // r9
		  Vector3 *v120; // rax
		  float v121; // xmm2_4
		  float v122; // ecx
		  MethodInfo *v123; // r9
		  Vector3 *v124; // rax
		  __int64 v125; // xmm3_8
		  MethodInfo *v126; // r9
		  Vector3 *v127; // rax
		  __int64 v128; // xmm3_8
		  MethodInfo *v129; // r9
		  Vector3 *v130; // rax
		  float v131; // xmm2_4
		  float v132; // ecx
		  MethodInfo *v133; // r9
		  Vector3 *v134; // rax
		  __int64 v135; // xmm3_8
		  MethodInfo *v136; // r9
		  Vector3 *v137; // rax
		  __int64 v138; // xmm3_8
		  MethodInfo *v139; // r9
		  Vector3 *v140; // rax
		  float v141; // xmm8_4
		  float v142; // ecx
		  float v143; // xmm6_4
		  float v144; // xmm7_4
		  int v145; // xmm1_4
		  float v146; // xmm0_4
		  __int64 v147; // rax
		  ILFixDynamicMethodWrapper_2 *v148; // rax
		  Vector3 *v149; // rax
		  unsigned __int32 v150; // xmm0_4
		  __int64 v151; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v153; // [rsp+38h] [rbp-D0h] BYREF
		  Vector3 v154; // [rsp+48h] [rbp-C0h] BYREF
		  Color v155; // [rsp+58h] [rbp-B0h] BYREF
		  __m128 v156; // [rsp+68h] [rbp-A0h] BYREF
		  Matrix4x4 v157[3]; // [rsp+78h] [rbp-90h] BYREF
		  float v158; // [rsp+188h] [rbp+80h] BYREF
		
		  v158 = 0.0;
		  if ( IFix::WrappersManagerImpl::IsPatched(5044, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5044, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		    goto LABEL_42;
		  }
		  m_CloudMat = (Object_1 *)this->fields.m_CloudMat;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Implicit(m_CloudMat, 0LL) )
		  {
		    m_CloudObject = this->fields.m_CloudObject;
		    if ( m_CloudObject )
		    {
		      transform = UnityEngine::GameObject::get_transform((GameObject *)m_CloudObject, 0LL);
		      if ( transform )
		      {
		        localScale = UnityEngine::Transform::get_localScale(&v153, transform, 0LL);
		        z = localScale->z;
		        *(_QWORD *)&v153.x = *(_QWORD *)&localScale->x;
		        v9 = (__m128)*(unsigned __int64 *)&v153.x;
		        v10 = _mm_shuffle_ps(v9, v9, 85).m128_f32[0];
		        if ( v10 <= z )
		          v10 = z;
		        x = v153.x;
		        if ( v153.x <= v10 )
		          x = v10;
		        m_CloudObject = this->fields.m_CloudObject;
		        this->fields.m_MaxExtent = x;
		        if ( m_CloudObject )
		        {
		          v12 = UnityEngine::GameObject::get_transform((GameObject *)m_CloudObject, 0LL);
		          m_MaxExtent = this->fields.m_MaxExtent;
		          v154.z = 1.0;
		          *(_QWORD *)&v154.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		          v15 = UnityEngine::Vector3::op_Multiply(&v153, m_MaxExtent, &v154, v14);
		          if ( !v12 )
		            sub_1800D8260(v17, v16);
		          v18 = *(_QWORD *)&v15->x;
		          v154.z = v15->z;
		          v19 = (void (__fastcall *)(Transform *, Vector3 *))qword_18F370138;
		          *(_QWORD *)&v154.x = v18;
		          if ( !qword_18F370138 )
		          {
		            v19 = (void (__fastcall *)(Transform *, Vector3 *))il2cpp_resolve_icall_1(
		                                                                 "UnityEngine.Transform::set_localScale_Injected(UnityEngine.Vector3&)");
		            if ( !v19 )
		            {
		              v147 = sub_1802EE1B8("UnityEngine.Transform::set_localScale_Injected(UnityEngine.Vector3&)");
		              sub_18007E1B0(v147, 0LL);
		            }
		            qword_18F370138 = (__int64)v19;
		          }
		          v19(v12, &v154);
		          DensityTextureToUse = this->fields.DensityTextureToUse;
		          if ( !TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		          Texture = HG::Rendering::Runtime::VolumetricSDFUtils::GetTexture(DensityTextureToUse, 0LL);
		          TextureResolution = HG::Rendering::Runtime::VolumetricSDFUtils::GetTextureResolution(&v153, Texture, 0LL);
		          v23 = *(_QWORD *)&TextureResolution->x;
		          v24 = TextureResolution->z;
		          *(_QWORD *)&v154.x = *(_QWORD *)&TextureResolution->x;
		          if ( IFix::WrappersManagerImpl::IsPatched(5047, 0LL) )
		          {
		            v148 = IFix::WrappersManagerImpl::GetPatch(5047, 0LL);
		            if ( !v148 )
		              goto LABEL_42;
		            *(_QWORD *)&v154.x = v23;
		            v154.z = v24;
		            v149 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1472(&v153, v148, &v154, &v158, 0LL);
		            z_low = (__m128)LODWORD(v149->z);
		            v150 = _mm_shuffle_ps((__m128)*(unsigned __int64 *)&v149->x, (__m128)*(unsigned __int64 *)&v149->x, 85).m128_u32[0];
		            *(_QWORD *)&v153.x = *(_QWORD *)&v149->x;
		            v29 = *(float *)&v150;
		            x_low = (__m128)LODWORD(v153.x);
		          }
		          else
		          {
		            z_low = (__m128)_mm_cvtsi32_si128(LODWORD(v24));
		            if ( v154.y <= z_low.m128_f32[0] )
		              y = z_low.m128_f32[0];
		            else
		              y = v154.y;
		            x_low = (__m128)LODWORD(v154.x);
		            if ( v154.x > y )
		              y = v154.x;
		            v28 = 1.0 / y;
		            x_low.m128_f32[0] = v154.x * v28;
		            v29 = v154.y * v28;
		            z_low.m128_f32[0] = z_low.m128_f32[0] * v28;
		          }
		          m_CloudObject = this->fields.m_CloudObject;
		          v30 = (__m128)0x3F800000u;
		          v31 = (__m128)0x3F800000u;
		          *(_QWORD *)&this->fields.m_VoxelSize.x = _mm_unpacklo_ps(x_low, z_low).m128_u64[0];
		          this->fields.m_VoxelSize.z = v29;
		          v30.m128_f32[0] = 1.0 / this->fields.m_VoxelSize.x;
		          v31.m128_f32[0] = 1.0 / this->fields.m_VoxelSize.y;
		          *(_QWORD *)&this->fields.m_InvScale.x = _mm_unpacklo_ps(v30, v31).m128_u64[0];
		          this->fields.m_InvScale.z = 1.0 / v29;
		          if ( m_CloudObject )
		          {
		            v32 = UnityEngine::GameObject::get_transform((GameObject *)m_CloudObject, 0LL);
		            if ( v32 )
		            {
		              worldToLocalMatrix = UnityEngine::Transform::get_worldToLocalMatrix(v157, v32, 0LL);
		              m_CloudObject = this->fields.m_CloudObject;
		              v34 = *(_OWORD *)&worldToLocalMatrix->m01;
		              v35 = *(_OWORD *)&worldToLocalMatrix->m02;
		              v36 = *(_OWORD *)&worldToLocalMatrix->m03;
		              *(_OWORD *)&this->fields.m_CloudRenderWorldToLocal.m00 = *(_OWORD *)&worldToLocalMatrix->m00;
		              *(_OWORD *)&this->fields.m_CloudRenderWorldToLocal.m01 = v34;
		              *(_OWORD *)&this->fields.m_CloudRenderWorldToLocal.m02 = v35;
		              *(_OWORD *)&this->fields.m_CloudRenderWorldToLocal.m03 = v36;
		              if ( m_CloudObject )
		              {
		                v37 = UnityEngine::GameObject::get_transform((GameObject *)m_CloudObject, 0LL);
		                if ( v37 )
		                {
		                  localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(v157, v37, 0LL);
		                  v40 = this->fields.m_CloudObject;
		                  v41 = *(_OWORD *)&localToWorldMatrix->m01;
		                  v42 = *(_OWORD *)&localToWorldMatrix->m02;
		                  v43 = *(_OWORD *)&localToWorldMatrix->m03;
		                  *(_OWORD *)&this->fields.m_CloudRenderLocalToWorld.m00 = *(_OWORD *)&localToWorldMatrix->m00;
		                  *(_OWORD *)&this->fields.m_CloudRenderLocalToWorld.m01 = v41;
		                  *(_OWORD *)&this->fields.m_CloudRenderLocalToWorld.m02 = v42;
		                  *(_OWORD *)&this->fields.m_CloudRenderLocalToWorld.m03 = v43;
		                  if ( !v40 )
		                    goto LABEL_43;
		                  v44 = UnityEngine::GameObject::get_transform(v40, 0LL);
		                  if ( !v44 )
		                    goto LABEL_43;
		                  v45 = (void (__fastcall *)(Transform *, Vector3 *))qword_18F370138;
		                  *(_QWORD *)&v154.x = v9.m128_u64[0];
		                  v154.z = z;
		                  if ( !qword_18F370138 )
		                  {
		                    v45 = (void (__fastcall *)(Transform *, Vector3 *))il2cpp_resolve_icall_1(
		                                                                         "UnityEngine.Transform::set_localScale_Injected("
		                                                                         "UnityEngine.Vector3&)");
		                    if ( !v45 )
		                    {
		                      v151 = sub_1802EE1B8("UnityEngine.Transform::set_localScale_Injected(UnityEngine.Vector3&)");
		                      sub_18007E1B0(v151, 0LL);
		                    }
		                    qword_18F370138 = (__int64)v45;
		                  }
		                  v45(v44, &v154);
		                  deltaTime = UnityEngine::Time::get_deltaTime(0LL);
		                  v47 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
		                  v48 = this->fields.m_CloudMat;
		                  v158 = deltaTime;
		                  if ( !TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->_1.cctor_finished_or_no_cctor )
		                  {
		                    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		                    v47 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
		                  }
		                  static_fields = v47->static_fields;
		                  if ( !v48 )
		LABEL_43:
		                    sub_1800D8260(v40, v39);
		                  v155 = *UnityEngine::Material::GetColorImpl((Color *)&v156, v48, static_fields->_WindSpeed, 0LL);
		                  v51 = *UnityEngine::Color::op_Implicit((Color *)&v156, (Vector4 *)&v155, v50);
		                  v4 = this->fields.m_CloudMat;
		                  v52 = _mm_shuffle_ps((__m128)v51, (__m128)v51, 85);
		                  v53 = (__m128i)_mm_shuffle_ps((__m128)v51, (__m128)v51, 170);
		                  m_CloudObject = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                  if ( v4 )
		                  {
		                    v155 = *UnityEngine::Material::GetColorImpl(
		                              (Color *)&v156,
		                              (Material *)v4,
		                              *((_DWORD *)m_CloudObject + 138),
		                              0LL);
		                    v55 = *UnityEngine::Color::op_Implicit((Color *)&v156, (Vector4 *)&v155, v54);
		                    v4 = this->fields.m_CloudMat;
		                    v56 = _mm_shuffle_ps((__m128)v55, (__m128)v55, 85);
		                    LODWORD(v57) = _mm_shuffle_ps((__m128)v55, (__m128)v55, 170).m128_u32[0];
		                    m_CloudObject = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                    if ( v4 )
		                    {
		                      v155 = *UnityEngine::Material::GetColorImpl(
		                                (Color *)&v156,
		                                (Material *)v4,
		                                *((_DWORD *)m_CloudObject + 139),
		                                0LL);
		                      v59 = *UnityEngine::Color::op_Implicit((Color *)&v156, (Vector4 *)&v155, v58);
		                      m_CloudObject = this->fields.m_CloudMat;
		                      v60 = _mm_shuffle_ps((__m128)v59, (__m128)v59, 85);
		                      v4 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                      v156 = _mm_shuffle_ps((__m128)v59, (__m128)v59, 170);
		                      if ( m_CloudObject )
		                      {
		                        FloatImpl = UnityEngine::Material::GetFloatImpl(
		                                      (Material *)m_CloudObject,
		                                      *((_DWORD *)v4 + 25),
		                                      0LL);
		                        v62 = COERCE_FLOAT(_mm_cvtsi128_si32(v53));
		                        *(_QWORD *)&v154.x = _mm_unpacklo_ps((__m128)v51, v52).m128_u64[0];
		                        v154.z = v62;
		                        v63 = *(_QWORD *)&v154.x;
		                        v64 = FloatImpl;
		                        v66 = UnityEngine::Vector3::op_Multiply(&v153, &v154, FloatImpl, v65);
		                        v67 = *(_QWORD *)&v66->x;
		                        *(float *)&v66 = v66->z;
		                        *(_QWORD *)&v154.x = v67;
		                        LODWORD(v154.z) = (_DWORD)v66;
		                        v69 = UnityEngine::Vector3::op_Multiply(&v153, &v154, v158, v68);
		                        v70 = *(_QWORD *)&v69->x;
		                        *(float *)&v69 = v69->z;
		                        *(_QWORD *)&v154.x = v70;
		                        LODWORD(v154.z) = (_DWORD)v69;
		                        v72 = UnityEngine::Vector3::op_Multiply(&v153, &v154, 0.050000001, v71);
		                        v73 = *(_QWORD *)&this->fields.m_WindPhase.x;
		                        v74 = *(_QWORD *)&v72->x;
		                        v154.z = v72->z;
		                        v153.z = this->fields.m_WindPhase.z;
		                        *(_QWORD *)&v154.x = v74;
		                        *(_QWORD *)&v153.x = v73;
		                        v76 = UnityEngine::Vector3::op_Addition((Vector3 *)&v155, &v153, &v154, v75);
		                        v77 = (Beyond::JobMathf *)LODWORD(v76->z);
		                        *(_QWORD *)&this->fields.m_WindPhase.x = *(_QWORD *)&v76->x;
		                        LODWORD(this->fields.m_WindPhase.z) = (_DWORD)v77;
		                        *(float *)&v73 = this->fields.m_WindPhase.x;
		                        Beyond::JobMathf::Fmod(v77, 1.0, 0.050000001);
		                        LODWORD(this->fields.m_WindPhase.x) = v73;
		                        *(float *)&v73 = this->fields.m_WindPhase.y;
		                        Beyond::JobMathf::Fmod(v78, 1.0, 0.050000001);
		                        LODWORD(this->fields.m_WindPhase.y) = v73;
		                        *(float *)&v73 = this->fields.m_WindPhase.z;
		                        Beyond::JobMathf::Fmod(v79, 1.0, 0.050000001);
		                        v80 = _mm_unpacklo_ps((__m128)v55, v56).m128_u64[0];
		                        *(_QWORD *)&v153.x = v80;
		                        LODWORD(this->fields.m_WindPhase.z) = v73;
		                        v153.z = v57;
		                        v82 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v155, &v153, v64, v81);
		                        v83 = v158;
		                        v84 = *(_QWORD *)&v82->x;
		                        *(float *)&v82 = v82->z;
		                        *(_QWORD *)&v153.x = v84;
		                        LODWORD(v153.z) = (_DWORD)v82;
		                        v86 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v155, &v153, v158, v85);
		                        v87 = *(_QWORD *)&v86->x;
		                        *(float *)&v86 = v86->z;
		                        *(_QWORD *)&v153.x = v87;
		                        LODWORD(v153.z) = (_DWORD)v86;
		                        v89 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v155, &v153, 0.050000001, v88);
		                        *(_QWORD *)&v154.x = *(_QWORD *)&this->fields.m_WindPhase2.x;
		                        v90 = *(_QWORD *)&v89->x;
		                        v153.z = v89->z;
		                        v154.z = this->fields.m_WindPhase2.z;
		                        *(_QWORD *)&v153.x = v90;
		                        v92 = UnityEngine::Vector3::op_Addition((Vector3 *)&v155, &v154, &v153, v91);
		                        v93 = (Beyond::JobMathf *)LODWORD(v92->z);
		                        *(_QWORD *)&this->fields.m_WindPhase2.x = *(_QWORD *)&v92->x;
		                        LODWORD(this->fields.m_WindPhase2.z) = (_DWORD)v93;
		                        *(float *)&v73 = this->fields.m_WindPhase2.x;
		                        Beyond::JobMathf::Fmod(v93, 1.0, 0.050000001);
		                        LODWORD(this->fields.m_WindPhase2.x) = v73;
		                        *(float *)&v73 = this->fields.m_WindPhase2.y;
		                        Beyond::JobMathf::Fmod(v94, 1.0, 0.050000001);
		                        LODWORD(this->fields.m_WindPhase2.y) = v73;
		                        *(float *)&v73 = this->fields.m_WindPhase2.z;
		                        Beyond::JobMathf::Fmod(v95, 1.0, 0.050000001);
		                        v96 = v156.m128_f32[0];
		                        LODWORD(this->fields.m_WindPhase2.z) = v73;
		                        v97 = _mm_unpacklo_ps((__m128)v59, v60).m128_u64[0];
		                        *(_QWORD *)&v153.x = v97;
		                        v153.z = v96;
		                        v99 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v155, &v153, v64, v98);
		                        v100 = *(_QWORD *)&v99->x;
		                        *(float *)&v99 = v99->z;
		                        *(_QWORD *)&v153.x = v100;
		                        LODWORD(v153.z) = (_DWORD)v99;
		                        v102 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v155, &v153, v83, v101);
		                        v103 = *(_QWORD *)&v102->x;
		                        *(float *)&v102 = v102->z;
		                        *(_QWORD *)&v153.x = v103;
		                        LODWORD(v153.z) = (_DWORD)v102;
		                        v105 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v155, &v153, 0.050000001, v104);
		                        *(_QWORD *)&v154.x = *(_QWORD *)&this->fields.m_WindPhase3.x;
		                        v106 = *(_QWORD *)&v105->x;
		                        v153.z = v105->z;
		                        v154.z = this->fields.m_WindPhase3.z;
		                        *(_QWORD *)&v153.x = v106;
		                        v108 = UnityEngine::Vector3::op_Addition((Vector3 *)&v155, &v154, &v153, v107);
		                        v109 = (Beyond::JobMathf *)LODWORD(v108->z);
		                        *(_QWORD *)&this->fields.m_WindPhase3.x = *(_QWORD *)&v108->x;
		                        LODWORD(this->fields.m_WindPhase3.z) = (_DWORD)v109;
		                        *(float *)&v73 = this->fields.m_WindPhase3.x;
		                        Beyond::JobMathf::Fmod(v109, 1.0, 0.050000001);
		                        LODWORD(this->fields.m_WindPhase3.x) = v73;
		                        *(float *)&v73 = this->fields.m_WindPhase3.y;
		                        Beyond::JobMathf::Fmod(v110, 1.0, 0.050000001);
		                        LODWORD(this->fields.m_WindPhase3.y) = v73;
		                        *(float *)&v73 = this->fields.m_WindPhase3.z;
		                        Beyond::JobMathf::Fmod(v111, 1.0, 0.050000001);
		                        LODWORD(this->fields.m_WindPhase3.z) = v73;
		                        v112 = this->fields.m_MaxExtent;
		                        *(_QWORD *)&v153.x = v63;
		                        v153.z = v62;
		                        v114 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v155, &v153, v112, v113);
		                        v115 = *(_QWORD *)&v114->x;
		                        *(float *)&v114 = v114->z;
		                        *(_QWORD *)&v153.x = v115;
		                        LODWORD(v153.z) = (_DWORD)v114;
		                        v117 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v155, &v153, v83, v116);
		                        v118 = *(_QWORD *)&v117->x;
		                        *(float *)&v117 = v117->z;
		                        *(_QWORD *)&v153.x = v118;
		                        LODWORD(v153.z) = (_DWORD)v117;
		                        v120 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v155, &v153, 0.050000001, v119);
		                        v121 = this->fields.m_MaxExtent;
		                        v153.z = v57;
		                        *(_QWORD *)&v153.x = v80;
		                        v122 = v120->z;
		                        *(_QWORD *)&this->fields.m_WindOffset.x = *(_QWORD *)&v120->x;
		                        this->fields.m_WindOffset.z = v122;
		                        v124 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v155, &v153, v121, v123);
		                        v125 = *(_QWORD *)&v124->x;
		                        *(float *)&v124 = v124->z;
		                        *(_QWORD *)&v153.x = v125;
		                        LODWORD(v153.z) = (_DWORD)v124;
		                        v127 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v155, &v153, v83, v126);
		                        v128 = *(_QWORD *)&v127->x;
		                        *(float *)&v127 = v127->z;
		                        *(_QWORD *)&v153.x = v128;
		                        LODWORD(v153.z) = (_DWORD)v127;
		                        v130 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v155, &v153, 0.050000001, v129);
		                        v131 = this->fields.m_MaxExtent;
		                        *(_QWORD *)&v153.x = v97;
		                        v153.z = v96;
		                        v132 = v130->z;
		                        *(_QWORD *)&this->fields.m_WindOffset2.x = *(_QWORD *)&v130->x;
		                        this->fields.m_WindOffset2.z = v132;
		                        v134 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v155, &v153, v131, v133);
		                        v135 = *(_QWORD *)&v134->x;
		                        *(float *)&v134 = v134->z;
		                        *(_QWORD *)&v153.x = v135;
		                        LODWORD(v153.z) = (_DWORD)v134;
		                        v137 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v155, &v153, v83, v136);
		                        v138 = *(_QWORD *)&v137->x;
		                        *(float *)&v137 = v137->z;
		                        *(_QWORD *)&v153.x = v138;
		                        LODWORD(v153.z) = (_DWORD)v137;
		                        v140 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v155, &v153, 0.050000001, v139);
		                        v141 = this->fields.m_MaxExtent;
		                        v142 = v140->z;
		                        *(_QWORD *)&this->fields.m_WindOffset3.x = *(_QWORD *)&v140->x;
		                        this->fields.m_WindOffset3.z = v142;
		                        m_CloudObject = this->fields.m_CloudMat;
		                        v4 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                        if ( m_CloudObject )
		                        {
		                          v143 = UnityEngine::Material::GetFloatImpl(
		                                   (Material *)m_CloudObject,
		                                   *((_DWORD *)v4 + 52),
		                                   0LL);
		                          m_CloudObject = this->fields.m_CloudMat;
		                          v4 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                          if ( m_CloudObject )
		                          {
		                            v144 = UnityEngine::Material::GetFloatImpl(
		                                     (Material *)m_CloudObject,
		                                     *((_DWORD *)v4 + 37),
		                                     0LL);
		                            m_CloudObject = this->fields.m_CloudMat;
		                            v4 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                            if ( m_CloudObject )
		                            {
		                              *(float *)&v145 = 0.0099999998;
		                              v146 = UnityEngine::Material::GetFloatImpl(
		                                       (Material *)m_CloudObject,
		                                       *((_DWORD *)v4 + 54),
		                                       0LL)
		                                   * (float)((float)(v143 * v141) * v144);
		                              if ( v146 < 0.0099999998 || (*(float *)&v145 = 100.0, v146 > 100.0) )
		                                v146 = *(float *)&v145;
		                              this->fields.m_OpticalDepthScale = v146;
		                              this->fields.m_InvOpticalDepthScale = 1.0 / v146;
		                              return;
		                            }
		                          }
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_42:
		    sub_1800D8260(m_CloudObject, v4);
		  }
		}
		
		private void BakeMSTex(CommandBuffer cmd, Material material, bool force = false /* Metadata: 0x023040AF */) {} // 0x0000000189C47830-0x0000000189C47AF8
		// Void BakeMSTex(CommandBuffer, Material, Boolean)
		void HG::Rendering::Runtime::VolumetricCloudSDF::BakeMSTex(
		        VolumetricCloudSDF *this,
		        CommandBuffer *cmd,
		        Material *material,
		        bool force,
		        MethodInfo *method)
		{
		  VolumetricMSBake *m_MSBaker; // r12
		  int32_t m_msBakeSizeX; // r13d
		  Material *m_CloudMat; // rdi
		  void *v12; // rcx
		  Material *static_fields; // rdx
		  float FloatImpl; // xmm0_4
		  float v15; // xmm0_4
		  float v16; // xmm0_4
		  int32_t Int; // eax
		  float v18; // xmm0_4
		  float v19; // xmm0_4
		  float v20; // xmm0_4
		  Vector4 v21; // xmm2
		  MaterialPropertyBlock *m_propertyBlock; // rdi
		  int32_t MSTex; // esi
		  Texture *MSTexture; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int32_t m_msBakeSizeY; // [rsp+48h] [rbp-51h]
		  Vector4 v27; // [rsp+50h] [rbp-49h] BYREF
		  __int128 v28; // [rsp+60h] [rbp-39h]
		  __int128 v29; // [rsp+70h] [rbp-29h]
		  VolumetricMSBake_FMSArgs v30; // [rsp+98h] [rbp-1h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5072, 0LL) )
		  {
		    m_MSBaker = this->fields.m_MSBaker;
		    m_msBakeSizeX = this->fields.m_msBakeSizeX;
		    m_CloudMat = this->fields.m_CloudMat;
		    m_msBakeSizeY = this->fields.m_msBakeSizeY;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		    static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		    if ( m_CloudMat )
		    {
		      FloatImpl = UnityEngine::Material::GetFloatImpl(m_CloudMat, HIDWORD(static_fields[11].monitor), 0LL);
		      v12 = this->fields.m_CloudMat;
		      *(float *)&v28 = FloatImpl;
		      static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		      if ( v12 )
		      {
		        v15 = UnityEngine::Material::GetFloatImpl((Material *)v12, (int32_t)static_fields[11].fields._.m_CachedPtr, 0LL);
		        v12 = this->fields.m_CloudMat;
		        *((float *)&v28 + 1) = v15;
		        static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		        if ( v12 )
		        {
		          v16 = UnityEngine::Material::GetFloatImpl((Material *)v12, HIDWORD(static_fields[12].klass), 0LL);
		          v12 = this->fields.m_CloudMat;
		          *((float *)&v28 + 2) = v16;
		          static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		          if ( v12 )
		          {
		            Int = UnityEngine::Material::GetInt((Material *)v12, HIDWORD(static_fields[12].monitor), 0LL);
		            v12 = this->fields.m_CloudMat;
		            HIDWORD(v28) = Int;
		            static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		            if ( v12 )
		            {
		              v18 = UnityEngine::Material::GetFloatImpl(
		                      (Material *)v12,
		                      (int32_t)static_fields[12].fields._.m_CachedPtr,
		                      0LL);
		              v12 = this->fields.m_CloudMat;
		              *(float *)&v29 = v18;
		              static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		              if ( v12 )
		              {
		                v19 = UnityEngine::Material::GetFloatImpl(
		                        (Material *)v12,
		                        HIDWORD(static_fields[12].fields._.m_CachedPtr),
		                        0LL);
		                v12 = this->fields.m_CloudMat;
		                *((float *)&v29 + 1) = v19;
		                static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                if ( v12 )
		                {
		                  v20 = UnityEngine::Material::GetFloatImpl((Material *)v12, (int32_t)static_fields[13].klass, 0LL);
		                  static_fields = this->fields.m_CloudMat;
		                  *((float *)&v29 + 2) = v20;
		                  v12 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                  HIDWORD(v29) = LODWORD(this->fields.m_OpticalDepthScale);
		                  if ( static_fields )
		                  {
		                    v21 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Material::GetVector(
		                                                                      &v27,
		                                                                      static_fields,
		                                                                      *((_DWORD *)v12 + 84),
		                                                                      0LL));
		                    if ( m_MSBaker )
		                    {
		                      *(_OWORD *)&v30.m_Phase = v28;
		                      *(_OWORD *)&v30.m_MssFactor = v29;
		                      v30.m_EncodeParams = v21;
		                      HG::Rendering::Runtime::VolumetricMSBake::BakeMSTexture(
		                        m_MSBaker,
		                        cmd,
		                        m_msBakeSizeX,
		                        m_msBakeSizeY,
		                        &v30,
		                        material,
		                        force,
		                        0LL);
		                      m_propertyBlock = this->fields.m_propertyBlock;
		                      MSTex = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_MSTex;
		                      v12 = this->fields.m_MSBaker;
		                      if ( v12 )
		                      {
		                        MSTexture = (Texture *)HG::Rendering::Runtime::VolumetricMSBake::get_MSTexture(
		                                                 (VolumetricMSBake *)v12,
		                                                 0LL);
		                        if ( m_propertyBlock )
		                        {
		                          UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(m_propertyBlock, MSTex, MSTexture, 0LL);
		                          return;
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_15:
		    sub_1800D8260(v12, static_fields);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5072, 0LL);
		  if ( !Patch )
		    goto LABEL_15;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_117(
		    (ILFixDynamicMethodWrapper_13 *)Patch,
		    (Object *)this,
		    (Object *)cmd,
		    (Object *)material,
		    force,
		    0LL);
		}
		
		private void UpdateMat() {} // 0x0000000183C525C0-0x0000000183C52740
		// Void UpdateMat()
		void HG::Rendering::Runtime::VolumetricCloudSDF::UpdateMat(VolumetricCloudSDF *this, MethodInfo *method)
		{
		  GameObject *m_CloudObject; // rdi
		  int32_t RenderObjectLayer; // eax
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  struct Math__Class *v6; // rcx
		  float z; // ebp
		  unsigned __int64 v8; // xmm7_8
		  MethodInfo *v9; // r9
		  float v10; // esi
		  __int64 v11; // xmm6_8
		  GameObject *v12; // rcx
		  Transform *transform; // rdi
		  void (__fastcall *v14)(Transform *, Vector3 *); // rax
		  Transform *v15; // rdi
		  void (__fastcall *v16)(Transform *, Vector3 *); // rax
		  VolumetricSdfAsset *m_CloudAsset; // rbp
		  VolumetricSdfAsset *v18; // rax
		  __int64 v19; // xmm0_8
		  float v20; // eax
		  Vector3 *v21; // rax
		  HGRuntimeGrassQuery_Node *v22; // r8
		  VolumetricSdfAsset *v23; // rax
		  VolumetricEncodedTexture__Array *SdfTexs; // rcx
		  VolumetricEncodedTexture *v25; // rax
		  HGRuntimeGrassQuery_Node *v26; // r8
		  Int32__Array **v27; // r9
		  VolumetricSdfAsset *v28; // r10
		  VolumetricEncodedTexture *v29; // rax
		  HGRuntimeGrassQuery_Node *v30; // r8
		  VolumetricEncodedTexture *v31; // r9
		  VolumetricSdfAsset *v32; // r10
		  __int64 v33; // rax
		  __int64 v34; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v36; // [rsp+20h] [rbp-48h] BYREF
		  Vector3 v37; // [rsp+30h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5040, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5040, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		    goto LABEL_15;
		  }
		  m_CloudObject = this->fields.m_CloudObject;
		  RenderObjectLayer = HG::Rendering::Runtime::VolumetricRenderObject::get_RenderObjectLayer(
		                        (VolumetricRenderObject *)this,
		                        0LL);
		  if ( !m_CloudObject )
		    goto LABEL_15;
		  UnityEngine::GameObject::set_layer(m_CloudObject, RenderObjectLayer, 0LL);
		  z = COERCE_FLOAT(_mm_cvtsi128_si32((__m128i)0LL));
		  v8 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  *(_QWORD *)&v36.x = 0x3F8000003F800000LL;
		  v36.z = 1.0;
		  if ( HG::Rendering::Runtime::VolumetricCloudSDF::get_IsCloudSdfAssetValid(this, 0LL) )
		  {
		    m_CloudAsset = this->fields.m_CloudAsset;
		    if ( m_CloudAsset )
		    {
		      v18 = this->fields.m_CloudAsset;
		      v8 = *(_QWORD *)&m_CloudAsset->fields.VolumeBounds.m_Center.x;
		      z = m_CloudAsset->fields.VolumeBounds.m_Center.z;
		      if ( v18 )
		      {
		        v19 = *(_QWORD *)&v18->fields.VolumeBounds.m_Extents.x;
		        v20 = v18->fields.VolumeBounds.m_Extents.z;
		        *(_QWORD *)&v36.x = v19;
		        v36.z = v20;
		        v21 = UnityEngine::Vector3::op_Multiply(&v37, &v36, 2.0, v9);
		        v6 = TypeInfo::System::Math;
		        v11 = *(_QWORD *)&v21->x;
		        v10 = v21->z;
		        if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		        v23 = this->fields.m_CloudAsset;
		        if ( v23 )
		        {
		          if ( v23->fields.SdfTexs && (SdfTexs = v23->fields.SdfTexs, SdfTexs->max_length.value) )
		          {
		            if ( !SdfTexs->max_length.size )
		              goto LABEL_38;
		            v25 = SdfTexs->vector[0];
		          }
		          else
		          {
		            v25 = 0LL;
		          }
		          this->fields.DensityTextureToUse = v25;
		          sub_18002D1B0(
		            (HGRuntimeGrassQuery_Node *)&this->fields.DensityTextureToUse,
		            v5,
		            v22,
		            0LL,
		            *(MethodInfo **)&v36.x);
		          v28 = this->fields.m_CloudAsset;
		          if ( v28 )
		          {
		            if ( (Int32__Array **)v28->fields.SdfTexs == v27
		              || (SdfTexs = v28->fields.SdfTexs, SdfTexs->max_length.size <= 1) )
		            {
		              v29 = (VolumetricEncodedTexture *)v27;
		            }
		            else
		            {
		              if ( SdfTexs->max_length.size <= 1u )
		                goto LABEL_38;
		              v29 = SdfTexs->vector[1];
		            }
		            this->fields.AdvancedTextureToUse = v29;
		            sub_18002D1B0(
		              (HGRuntimeGrassQuery_Node *)&this->fields.AdvancedTextureToUse,
		              v5,
		              v26,
		              v27,
		              *(MethodInfo **)&v36.x);
		            v32 = this->fields.m_CloudAsset;
		            if ( v32 )
		            {
		              if ( (VolumetricEncodedTexture *)v32->fields.SdfTexs == v31 )
		                goto LABEL_37;
		              SdfTexs = v32->fields.SdfTexs;
		              if ( SdfTexs->max_length.size <= 2 )
		                goto LABEL_37;
		              if ( SdfTexs->max_length.size > 2u )
		              {
		                v31 = SdfTexs->vector[2];
		LABEL_37:
		                this->fields.SHTextureToUse = v31;
		                sub_18002D1B0(
		                  (HGRuntimeGrassQuery_Node *)&this->fields.SHTextureToUse,
		                  v5,
		                  v30,
		                  (Int32__Array **)v31,
		                  *(MethodInfo **)&v36.x);
		                goto LABEL_5;
		              }
		LABEL_38:
		              sub_1800D2AB0(SdfTexs, v5);
		            }
		          }
		        }
		      }
		    }
		LABEL_15:
		    sub_1800D8260(v6, v5);
		  }
		  v10 = v36.z;
		  v11 = *(_QWORD *)&v36.x;
		LABEL_5:
		  v12 = this->fields.m_CloudObject;
		  if ( !v12 )
		    goto LABEL_12;
		  transform = UnityEngine::GameObject::get_transform(v12, 0LL);
		  if ( !transform )
		    goto LABEL_12;
		  v14 = (void (__fastcall *)(Transform *, Vector3 *))qword_18F370108;
		  *(_QWORD *)&v36.x = v8;
		  v36.z = z;
		  if ( !qword_18F370108 )
		  {
		    v14 = (void (__fastcall *)(Transform *, Vector3 *))il2cpp_resolve_icall_1(
		                                                         "UnityEngine.Transform::set_localPosition_Injected(UnityEngine.Vector3&)");
		    if ( !v14 )
		    {
		      v33 = sub_1802EE1B8("UnityEngine.Transform::set_localPosition_Injected(UnityEngine.Vector3&)");
		      sub_18007E1B0(v33, 0LL);
		    }
		    qword_18F370108 = (__int64)v14;
		  }
		  v14(transform, &v36);
		  v12 = this->fields.m_CloudObject;
		  if ( !v12 || (v15 = UnityEngine::GameObject::get_transform(v12, 0LL)) == 0LL )
		LABEL_12:
		    sub_1800D8260(v12, v5);
		  v16 = (void (__fastcall *)(Transform *, Vector3 *))qword_18F370138;
		  *(_QWORD *)&v37.x = v11;
		  v37.z = v10;
		  if ( !qword_18F370138 )
		  {
		    v16 = (void (__fastcall *)(Transform *, Vector3 *))il2cpp_resolve_icall_1(
		                                                         "UnityEngine.Transform::set_localScale_Injected(UnityEngine.Vector3&)");
		    if ( !v16 )
		    {
		      v34 = sub_1802EE1B8("UnityEngine.Transform::set_localScale_Injected(UnityEngine.Vector3&)");
		      sub_18007E1B0(v34, 0LL);
		    }
		    qword_18F370138 = (__int64)v16;
		  }
		  v16(v15, &v37);
		  HG::Rendering::Runtime::VolumetricCloudSDF::UpdateCloudParameters(this, 0LL);
		}
		
		private bool IsFarModePanoramic(HGVolumetricCloudSettingParameters volumetricParameters) => default; // 0x0000000189C4824C-0x0000000189C48304
		// Boolean IsFarModePanoramic(HGVolumetricCloudSettingParameters)
		bool HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModePanoramic(
		        VolumetricCloudSDF *this,
		        HGVolumetricCloudSettingParameters *volumetricParameters,
		        MethodInfo *method)
		{
		  VolumetricShaderKeywords__StaticFields *static_fields; // rdx
		  __int64 v6; // rcx
		  Material *m_CloudMat; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5086, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5086, 0LL);
		    if ( !Patch )
		      goto LABEL_9;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		             (ILFixDynamicMethodWrapper_33 *)Patch,
		             (Object *)this,
		             (Object *)volumetricParameters,
		             0LL);
		  }
		  else
		  {
		    if ( UnityEngine::Shader::get_globalMaximumLOD(0LL) != 600 )
		    {
		      if ( !volumetricParameters )
		        goto LABEL_9;
		      if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		             volumetricParameters->fields.enableFarCloud,
		             MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		      {
		        m_CloudMat = this->fields.m_CloudMat;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		        static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields;
		        if ( m_CloudMat )
		          return UnityEngine::Material::IsKeywordEnabled(m_CloudMat, static_fields->s_FarModePanoramic, 0LL);
		LABEL_9:
		        sub_1800D8260(v6, static_fields);
		      }
		    }
		    return 0;
		  }
		}
		
		private bool IsFarModeOctahedron(HGVolumetricCloudSettingParameters volumetricParameters) => default; // 0x0000000189C48194-0x0000000189C4824C
		// Boolean IsFarModeOctahedron(HGVolumetricCloudSettingParameters)
		bool HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeOctahedron(
		        VolumetricCloudSDF *this,
		        HGVolumetricCloudSettingParameters *volumetricParameters,
		        MethodInfo *method)
		{
		  VolumetricShaderKeywords__StaticFields *static_fields; // rdx
		  __int64 v6; // rcx
		  Material *m_CloudMat; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5087, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5087, 0LL);
		    if ( !Patch )
		      goto LABEL_9;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		             (ILFixDynamicMethodWrapper_33 *)Patch,
		             (Object *)this,
		             (Object *)volumetricParameters,
		             0LL);
		  }
		  else
		  {
		    if ( UnityEngine::Shader::get_globalMaximumLOD(0LL) != 600 )
		    {
		      if ( !volumetricParameters )
		        goto LABEL_9;
		      if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		             volumetricParameters->fields.enableFarCloud,
		             MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		      {
		        m_CloudMat = this->fields.m_CloudMat;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		        static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields;
		        if ( m_CloudMat )
		          return UnityEngine::Material::IsKeywordEnabled(m_CloudMat, static_fields->s_FarModeOctahedron, 0LL);
		LABEL_9:
		        sub_1800D8260(v6, static_fields);
		      }
		    }
		    return 0;
		  }
		}
		
		private bool IsFarModeSemicircular(HGVolumetricCloudSettingParameters volumetricParameters) => default; // 0x0000000189C48304-0x0000000189C483BC
		// Boolean IsFarModeSemicircular(HGVolumetricCloudSettingParameters)
		bool HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeSemicircular(
		        VolumetricCloudSDF *this,
		        HGVolumetricCloudSettingParameters *volumetricParameters,
		        MethodInfo *method)
		{
		  VolumetricShaderKeywords__StaticFields *static_fields; // rdx
		  __int64 v6; // rcx
		  Material *m_CloudMat; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5088, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5088, 0LL);
		    if ( !Patch )
		      goto LABEL_9;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		             (ILFixDynamicMethodWrapper_33 *)Patch,
		             (Object *)this,
		             (Object *)volumetricParameters,
		             0LL);
		  }
		  else
		  {
		    if ( UnityEngine::Shader::get_globalMaximumLOD(0LL) != 600 )
		    {
		      if ( !volumetricParameters )
		        goto LABEL_9;
		      if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		             volumetricParameters->fields.enableFarCloud,
		             MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		      {
		        m_CloudMat = this->fields.m_CloudMat;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		        static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields;
		        if ( m_CloudMat )
		          return UnityEngine::Material::IsKeywordEnabled(m_CloudMat, static_fields->s_FarModeSemicircular, 0LL);
		LABEL_9:
		        sub_1800D8260(v6, static_fields);
		      }
		    }
		    return 0;
		  }
		}
		
		public void BakeFarCloud(VolumetricFarCloudRenderer farRenderer, HGCamera hgCamera, CommandBuffer cmd, HGVolumetricCloudSettingParameters volumetricParameters) {} // 0x0000000189C47568-0x0000000189C47830
		// Void BakeFarCloud(VolumetricFarCloudRenderer, HGCamera, CommandBuffer, HGVolumetricCloudSettingParameters)
		void HG::Rendering::Runtime::VolumetricCloudSDF::BakeFarCloud(
		        VolumetricCloudSDF *this,
		        VolumetricFarCloudRenderer *farRenderer,
		        HGCamera *hgCamera,
		        CommandBuffer *cmd,
		        HGVolumetricCloudSettingParameters *volumetricParameters,
		        MethodInfo *method)
		{
		  Object_1 *m_CloudMat; // rbx
		  bool IsFadeInFromCamera; // r12
		  bool IsFarModeOctahedron; // r15
		  bool IsFarModeSemicircular; // al
		  ILFixDynamicMethodWrapper_19 *Patch; // rcx
		  bool v15; // r13
		  MaterialPropertyBlock *m_propertyBlock; // r12
		  void *propertyBlock; // rdx
		  float v18; // xmm0_4
		  MaterialPropertyBlock *v19; // r12
		  float v20; // xmm0_4
		  Material *v21; // r9
		  bool force; // al
		  bool v23; // al
		  bool v24; // al
		  bool v25; // [rsp+40h] [rbp-38h]
		  bool IsFarModePanoramic; // [rsp+41h] [rbp-37h]
		  int32_t name; // [rsp+44h] [rbp-34h]
		  int32_t namea; // [rsp+44h] [rbp-34h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5085, 0LL) )
		  {
		    m_CloudMat = (Object_1 *)this->fields.m_CloudMat;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Implicit(m_CloudMat, 0LL) )
		      return;
		    IsFadeInFromCamera = HG::Rendering::Runtime::VolumetricCloudSDF::IsFadeInFromCamera(this, hgCamera, 0LL);
		    v25 = IsFadeInFromCamera;
		    IsFarModePanoramic = HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModePanoramic(this, volumetricParameters, 0LL);
		    IsFarModeOctahedron = HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeOctahedron(
		                            this,
		                            volumetricParameters,
		                            0LL);
		    IsFarModeSemicircular = HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeSemicircular(
		                              this,
		                              volumetricParameters,
		                              0LL);
		    v15 = IsFarModeSemicircular;
		    if ( IsFarModePanoramic )
		    {
		      propertyBlock = this->fields.m_propertyBlock;
		      if ( farRenderer )
		      {
		        v24 = IsFadeInFromCamera;
		        if ( !this->fields.bLastPanoramic )
		          v24 = 1;
		        HG::Rendering::Runtime::VolumetricFarCloudRenderer::UpdatePanoramicRT(
		          farRenderer,
		          hgCamera,
		          cmd,
		          this->fields.m_CloudMat,
		          (MaterialPropertyBlock *)propertyBlock,
		          volumetricParameters,
		          v24,
		          0LL);
		        goto LABEL_21;
		      }
		    }
		    else
		    {
		      if ( !IsFarModeOctahedron && !IsFarModeSemicircular )
		      {
		LABEL_21:
		        this->fields.bLastPanoramic = IsFarModePanoramic;
		        this->fields.bLastOctahedron = IsFarModeOctahedron;
		        this->fields.bLastSemicircular = v15;
		        return;
		      }
		      m_propertyBlock = this->fields.m_propertyBlock;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		      Patch = (ILFixDynamicMethodWrapper_19 *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
		      propertyBlock = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		      name = *((_DWORD *)propertyBlock + 162);
		      if ( volumetricParameters )
		      {
		        v18 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                volumetricParameters->fields.octahedronHeightScale,
		                MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		        if ( m_propertyBlock )
		        {
		          UnityEngine::MaterialPropertyBlock::SetFloatImpl(m_propertyBlock, name, v18, 0LL);
		          v19 = this->fields.m_propertyBlock;
		          namea = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_SemicircularZScale;
		          v20 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                  volumetricParameters->fields.semicircularZScale,
		                  MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		          if ( v19 )
		          {
		            UnityEngine::MaterialPropertyBlock::SetFloatImpl(v19, namea, v20, 0LL);
		            v21 = this->fields.m_CloudMat;
		            propertyBlock = this->fields.m_propertyBlock;
		            if ( IsFarModeOctahedron )
		            {
		              if ( farRenderer )
		              {
		                v23 = v25;
		                if ( !this->fields.bLastOctahedron )
		                  v23 = 1;
		                HG::Rendering::Runtime::VolumetricFarCloudRenderer::UpdateOctahedronRT(
		                  farRenderer,
		                  hgCamera,
		                  cmd,
		                  v21,
		                  (MaterialPropertyBlock *)propertyBlock,
		                  volumetricParameters,
		                  v23,
		                  0LL);
		                goto LABEL_21;
		              }
		            }
		            else if ( farRenderer )
		            {
		              force = v25;
		              if ( !this->fields.bLastSemicircular )
		                force = 1;
		              HG::Rendering::Runtime::VolumetricFarCloudRenderer::UpdateSemicircularRT(
		                farRenderer,
		                hgCamera,
		                cmd,
		                v21,
		                (MaterialPropertyBlock *)propertyBlock,
		                volumetricParameters,
		                force,
		                0LL);
		              goto LABEL_21;
		            }
		          }
		        }
		      }
		    }
		LABEL_23:
		    sub_1800D8260(Patch, propertyBlock);
		  }
		  Patch = (ILFixDynamicMethodWrapper_19 *)IFix::WrappersManagerImpl::GetPatch(5085, 0LL);
		  if ( !Patch )
		    goto LABEL_23;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_19(
		    Patch,
		    (Object *)this,
		    (Object *)farRenderer,
		    (Object *)hgCamera,
		    (Object *)cmd,
		    (Object *)volumetricParameters,
		    0LL);
		}
		
		private bool IsFarCloudRTValid(HGVolumetricCloudSettingParameters volumetricParameters) => default; // 0x0000000189C480DC-0x0000000189C48194
		// Boolean IsFarCloudRTValid(HGVolumetricCloudSettingParameters)
		bool HG::Rendering::Runtime::VolumetricCloudSDF::IsFarCloudRTValid(
		        VolumetricCloudSDF *this,
		        HGVolumetricCloudSettingParameters *volumetricParameters,
		        MethodInfo *method)
		{
		  Object_1 *m_CloudMat; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5105, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5105, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		             (ILFixDynamicMethodWrapper_33 *)Patch,
		             (Object *)this,
		             (Object *)volumetricParameters,
		             0LL);
		  }
		  else
		  {
		    m_CloudMat = (Object_1 *)this->fields.m_CloudMat;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    return UnityEngine::Object::op_Implicit(m_CloudMat, 0LL)
		        && (HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModePanoramic(this, volumetricParameters, 0LL)
		         || HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeOctahedron(this, volumetricParameters, 0LL)
		         || HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeSemicircular(this, volumetricParameters, 0LL));
		  }
		}
		
		public override bool OverrideFramingCompose(VolumetricRenderer.VolumetricComposeContext composeContext, out VolumetricRenderer.VolumetricRenderItem item) {
			item = default;
			return default;
		} // 0x0000000189C48E18-0x0000000189C491D4
		// Boolean OverrideFramingCompose(VolumetricRenderer+VolumetricComposeContext, VolumetricRenderer+VolumetricRenderItem ByRef)
		bool HG::Rendering::Runtime::VolumetricCloudSDF::OverrideFramingCompose(
		        VolumetricCloudSDF *this,
		        VolumetricRenderer_VolumetricComposeContext *composeContext,
		        VolumetricRenderer_VolumetricRenderItem *item,
		        MethodInfo *method)
		{
		  __int64 v7; // rax
		  VolumetricShaderIDs__StaticFields *static_fields; // rdx
		  Material *v9; // rcx
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  __int64 v12; // r15
		  HGVolumetricCloudSettingParameters *v13; // xmm1_8
		  HGRuntimeGrassQuery_Node *v14; // rdx
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  Object_1 *m_CloudMat; // rbx
		  HGRuntimeGrassQuery_Node *v18; // rdx
		  Action_1_prXDGPaiLRznhHdqRYUShDUjqIyH_IYkFHeDTeaiIvMIzYRFbPiZVuQFL_ *v19; // rax
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v20; // rbx
		  HGRuntimeGrassQuery_Node *v21; // rdx
		  HGRuntimeGrassQuery_Node *v22; // r8
		  Int32__Array **v23; // r9
		  HGRuntimeGrassQuery_Node *v24; // rdx
		  HGRuntimeGrassQuery_Node *v25; // r8
		  Int32__Array **v26; // r9
		  Material *v27; // rbx
		  HGRuntimeGrassQuery_Node *v28; // r8
		  Int32__Array **v29; // r9
		  Material *v30; // rbx
		  HGRuntimeGrassQuery_Node *v31; // rdx
		  HGRuntimeGrassQuery_Node *v32; // r8
		  Int32__Array **v33; // r9
		  Material *v35; // rcx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *FramingRendererCallback; // r13
		  Material *v37; // rax
		  char v38; // r15
		  int32_t renderQueue; // ebx
		  __int128 v40; // xmm1
		  __int128 v41; // xmm0
		  __int128 v42; // xmm1
		  __int128 v43; // xmm0
		  HGRuntimeGrassQuery_Node *v44; // rdx
		  HGRuntimeGrassQuery_Node *v45; // r8
		  Int32__Array **v46; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGVolumetricCloudSettingParameters *volumetricSettings; // xmm1_8
		  MethodInfo *v49; // [rsp+28h] [rbp-E0h]
		  MethodInfo *v50; // [rsp+28h] [rbp-E0h]
		  MethodInfo *v51; // [rsp+28h] [rbp-E0h]
		  MethodInfo *v52; // [rsp+28h] [rbp-E0h]
		  MethodInfo *v53; // [rsp+28h] [rbp-E0h]
		  _BYTE v54[64]; // [rsp+78h] [rbp-90h] BYREF
		  Material *v55; // [rsp+B8h] [rbp-50h]
		  VolumetricRenderer_VolumetricRenderItem v56; // [rsp+C8h] [rbp-40h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5106, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5106, 0LL);
		    if ( !Patch )
		      goto LABEL_26;
		    volumetricSettings = composeContext->volumetricSettings;
		    *(_OWORD *)v54 = *(_OWORD *)&composeContext->bEnableFraming;
		    *(_QWORD *)&v54[16] = volumetricSettings;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1489(
		             Patch,
		             (Object *)this,
		             (VolumetricRenderer_VolumetricComposeContext *)v54,
		             item,
		             0LL);
		  }
		  else
		  {
		    v7 = sub_18002C620(TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF::__c__DisplayClass95_0);
		    v12 = v7;
		    if ( !v7 )
		      goto LABEL_26;
		    *(_QWORD *)(v7 + 16) = this;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v7 + 16), (HGRuntimeGrassQuery_Node *)static_fields, v10, v11, v49);
		    v13 = composeContext->volumetricSettings;
		    *(_OWORD *)(v12 + 24) = *(_OWORD *)&composeContext->bEnableFraming;
		    *(_QWORD *)(v12 + 40) = v13;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v12 + 32), v14, v15, v16, v50);
		    m_CloudMat = (Object_1 *)this->fields.m_CloudMat;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Implicit(m_CloudMat, 0LL) )
		    {
		      if ( !this->fields._._FramingRendererCallback )
		      {
		        v19 = (Action_1_prXDGPaiLRznhHdqRYUShDUjqIyH_IYkFHeDTeaiIvMIzYRFbPiZVuQFL_ *)sub_18002C620(TypeInfo::System::Action<HG::Rendering::Runtime::VolumetricRenderer::VolumetricCallbackContext>);
		        v20 = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)v19;
		        if ( !v19 )
		          goto LABEL_26;
		        System::Action<prXDGPaiLRznhHdqRYUShDUjqIyH::IYkFHeDTeaiIvMIzYRFbPiZVuQFL>::Action(
		          v19,
		          (Object *)v12,
		          MethodInfo::HG::Rendering::Runtime::VolumetricCloudSDF::__c__DisplayClass95_0::_OverrideFramingCompose_b__0,
		          0LL);
		        this->fields._._FramingRendererCallback = v20;
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._._FramingRendererCallback, v21, v22, v23, v51);
		      }
		      if ( this->fields.m_DrawFar
		        && HG::Rendering::Runtime::VolumetricCloudSDF::IsFarCloudRTValid(
		             this,
		             *(HGVolumetricCloudSettingParameters **)(v12 + 40),
		             0LL) )
		      {
		        sub_18033B9D0(item, 0LL, 88LL);
		        if ( HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModePanoramic(
		               this,
		               *(HGVolumetricCloudSettingParameters **)(v12 + 40),
		               0LL) )
		        {
		          item->Callback = this->fields._._FramingRendererCallback;
		          sub_18002D1B0((HGRuntimeGrassQuery_Node *)item, v24, v25, v26, v51);
		          LOBYTE(v33) = *(_BYTE *)(v12 + 25);
		          item->bEnableTAA = (char)v33;
		LABEL_18:
		          *(_WORD *)&item->bPureBlit = 256;
		          item->material = this->fields.m_CloudMat;
		          sub_18002D1B0((HGRuntimeGrassQuery_Node *)&item->material, v31, v32, v33, v52);
		          v9 = this->fields.m_CloudMat;
		          if ( v9 )
		          {
		            item->RenderQueue = UnityEngine::Material::get_renderQueue(v9, 0LL);
		            return 1;
		          }
		LABEL_26:
		          sub_1800D8260(v9, static_fields);
		        }
		        if ( HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeOctahedron(
		               this,
		               *(HGVolumetricCloudSettingParameters **)(v12 + 40),
		               0LL)
		          || HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeSemicircular(
		               this,
		               *(HGVolumetricCloudSettingParameters **)(v12 + 40),
		               0LL) )
		        {
		          v27 = this->fields.m_CloudMat;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		          static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		          if ( !v27 )
		            goto LABEL_26;
		          if ( UnityEngine::Material::GetInt(v27, static_fields->_FarCloudSSTAA, 0LL) > 0 || !*(_BYTE *)(v12 + 25) )
		          {
		            item->Callback = this->fields._._FramingRendererCallback;
		            sub_18002D1B0((HGRuntimeGrassQuery_Node *)item, v18, v28, v29, v51);
		            v30 = this->fields.m_CloudMat;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		            static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		            if ( !v30 )
		              goto LABEL_26;
		            item->bEnableTAA = UnityEngine::Material::GetInt(v30, static_fields->_FarCloudSSTAA, 0LL) > 0;
		            goto LABEL_18;
		          }
		        }
		      }
		      v35 = this->fields.m_CloudMat;
		      FramingRendererCallback = this->fields._._FramingRendererCallback;
		      *(_QWORD *)&v54[16] = 0LL;
		      v37 = *(Material **)(v12 + 32);
		      v38 = *(_BYTE *)(v12 + 25);
		      v55 = v37;
		      memset(&v54[32], 0, 28);
		      if ( !v35 )
		        sub_1800D8260(0LL, v18);
		      renderQueue = UnityEngine::Material::get_renderQueue(v35, 0LL);
		      sub_18033B9D0(&v56, 0LL, 88LL);
		      *(VolumetricRenderer_VolumetricBounds *)v54 = *(VolumetricRenderer_VolumetricBounds *)&v54[32];
		      HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem::VolumetricRenderItem(
		        &v56,
		        FramingRendererCallback,
		        (VolumetricRenderer_VolumetricBounds *)v54,
		        v55,
		        0,
		        v38,
		        0,
		        renderQueue,
		        99999.0,
		        0,
		        1,
		        0,
		        0LL);
		      v40 = *(_OWORD *)&v56.bounds.enableBounds;
		      *(_OWORD *)&item->Callback = *(_OWORD *)&v56.Callback;
		      v41 = *(_OWORD *)&v56.bounds.worldBounds.m_Extents.x;
		      *(_OWORD *)&item->bounds.enableBounds = v40;
		      v42 = *(_OWORD *)&v56.SortingOrder;
		      *(_OWORD *)&item->bounds.worldBounds.m_Extents.x = v41;
		      v43 = *(_OWORD *)&v56.bPureBlit;
		      *(_OWORD *)&item->SortingOrder = v42;
		      *(_QWORD *)&v42 = v56.meshFilter;
		      *(_OWORD *)&item->bPureBlit = v43;
		      item->meshFilter = (MeshFilter *)v42;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)item, v44, v45, v46, v53);
		      return 1;
		    }
		    sub_18033B9D0(item, 0LL, 88LL);
		    return 0;
		  }
		}
		
		public override bool OverrideTemporalCompose(VolumetricRenderer.VolumetricComposeContext composeContext, out VolumetricRenderer.VolumetricRenderItem item) {
			item = default;
			return default;
		} // 0x0000000189C491D4-0x0000000189C49534
		// Boolean OverrideTemporalCompose(VolumetricRenderer+VolumetricComposeContext, VolumetricRenderer+VolumetricRenderItem ByRef)
		bool HG::Rendering::Runtime::VolumetricCloudSDF::OverrideTemporalCompose(
		        VolumetricCloudSDF *this,
		        VolumetricRenderer_VolumetricComposeContext *composeContext,
		        VolumetricRenderer_VolumetricRenderItem *item,
		        MethodInfo *method)
		{
		  __int64 v7; // rax
		  VolumetricShaderIDs__StaticFields *static_fields; // rdx
		  Material *v9; // rcx
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  __int64 v12; // rsi
		  HGVolumetricCloudSettingParameters *v13; // xmm1_8
		  HGRuntimeGrassQuery_Node *v14; // rdx
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  Object_1 *m_CloudMat; // rbx
		  __int64 v18; // rdx
		  Action_1_prXDGPaiLRznhHdqRYUShDUjqIyH_IYkFHeDTeaiIvMIzYRFbPiZVuQFL_ *v19; // rax
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v20; // rbx
		  HGRuntimeGrassQuery_Node *v21; // rdx
		  HGRuntimeGrassQuery_Node *v22; // r8
		  Int32__Array **v23; // r9
		  Material *v24; // rbx
		  HGRuntimeGrassQuery_Node *v25; // rdx
		  HGRuntimeGrassQuery_Node *v26; // r8
		  Int32__Array **v27; // r9
		  HGRuntimeGrassQuery_Node *v28; // rdx
		  HGRuntimeGrassQuery_Node *v29; // r8
		  Int32__Array **v30; // r9
		  int32_t v31; // eax
		  HGRuntimeGrassQuery_Node *v32; // rdx
		  HGRuntimeGrassQuery_Node *v33; // r8
		  Int32__Array **v34; // r9
		  __int128 v35; // xmm1
		  __int128 v36; // xmm0
		  __int128 v37; // xmm1
		  __int128 v38; // xmm0
		  MeshFilter *meshFilter; // xmm1_8
		  Material *v41; // rcx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *TemporalComposeCallBack; // r15
		  Material *v43; // rsi
		  int32_t renderQueue; // ebx
		  __int128 v45; // xmm1
		  __int128 v46; // xmm0
		  __int128 v47; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGVolumetricCloudSettingParameters *volumetricSettings; // xmm1_8
		  MethodInfo *v50; // [rsp+20h] [rbp-E0h]
		  MethodInfo *v51; // [rsp+20h] [rbp-E0h]
		  MethodInfo *v52; // [rsp+20h] [rbp-E0h]
		  MethodInfo *v53; // [rsp+20h] [rbp-E0h]
		  MethodInfo *v54; // [rsp+20h] [rbp-E0h]
		  _BYTE v55[64]; // [rsp+70h] [rbp-90h] BYREF
		  _OWORD v56[3]; // [rsp+B0h] [rbp-50h] BYREF
		  __int128 v57; // [rsp+E0h] [rbp-20h]
		  __int128 v58; // [rsp+F0h] [rbp-10h]
		  MeshFilter *v59; // [rsp+100h] [rbp+0h]
		  VolumetricRenderer_VolumetricRenderItem v60; // [rsp+110h] [rbp+10h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5109, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5109, 0LL);
		    if ( !Patch )
		      goto LABEL_21;
		    volumetricSettings = composeContext->volumetricSettings;
		    *(_OWORD *)v55 = *(_OWORD *)&composeContext->bEnableFraming;
		    *(_QWORD *)&v55[16] = volumetricSettings;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1489(
		             Patch,
		             (Object *)this,
		             (VolumetricRenderer_VolumetricComposeContext *)v55,
		             item,
		             0LL);
		  }
		  else
		  {
		    v7 = sub_18002C620(TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF::__c__DisplayClass96_0);
		    v12 = v7;
		    if ( !v7 )
		      goto LABEL_21;
		    *(_QWORD *)(v7 + 16) = this;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v7 + 16), (HGRuntimeGrassQuery_Node *)static_fields, v10, v11, v50);
		    v13 = composeContext->volumetricSettings;
		    *(_OWORD *)(v12 + 24) = *(_OWORD *)&composeContext->bEnableFraming;
		    *(_QWORD *)(v12 + 40) = v13;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v12 + 32), v14, v15, v16, v51);
		    m_CloudMat = (Object_1 *)this->fields.m_CloudMat;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Implicit(m_CloudMat, 0LL) )
		    {
		      if ( !this->fields._._TemporalComposeCallBack )
		      {
		        v19 = (Action_1_prXDGPaiLRznhHdqRYUShDUjqIyH_IYkFHeDTeaiIvMIzYRFbPiZVuQFL_ *)sub_18002C620(TypeInfo::System::Action<HG::Rendering::Runtime::VolumetricRenderer::VolumetricCallbackContext>);
		        v20 = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)v19;
		        if ( !v19 )
		          goto LABEL_21;
		        System::Action<prXDGPaiLRznhHdqRYUShDUjqIyH::IYkFHeDTeaiIvMIzYRFbPiZVuQFL>::Action(
		          v19,
		          (Object *)v12,
		          MethodInfo::HG::Rendering::Runtime::VolumetricCloudSDF::__c__DisplayClass96_0::_OverrideTemporalCompose_b__0,
		          0LL);
		        this->fields._._TemporalComposeCallBack = v20;
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._._TemporalComposeCallBack, v21, v22, v23, v52);
		      }
		      if ( !this->fields.m_DrawFar
		        || !HG::Rendering::Runtime::VolumetricCloudSDF::IsFarCloudRTValid(
		              this,
		              *(HGVolumetricCloudSettingParameters **)(v12 + 40),
		              0LL)
		        || !HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeOctahedron(
		              this,
		              *(HGVolumetricCloudSettingParameters **)(v12 + 40),
		              0LL)
		        && !HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeSemicircular(
		              this,
		              *(HGVolumetricCloudSettingParameters **)(v12 + 40),
		              0LL) )
		      {
		        goto LABEL_16;
		      }
		      v24 = this->fields.m_CloudMat;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		      static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		      if ( !v24 )
		        goto LABEL_21;
		      if ( UnityEngine::Material::GetInt(v24, static_fields->_FarCloudSSTAA, 0LL) )
		      {
		LABEL_16:
		        v41 = this->fields.m_CloudMat;
		        TemporalComposeCallBack = this->fields._._TemporalComposeCallBack;
		        v43 = *(Material **)(v12 + 32);
		        *(_QWORD *)&v55[16] = 0LL;
		        memset(&v55[32], 0, 28);
		        if ( !v41 )
		          sub_1800D8260(0LL, v18);
		        renderQueue = UnityEngine::Material::get_renderQueue(v41, 0LL);
		        sub_18033B9D0(&v60, 0LL, 88LL);
		        *(VolumetricRenderer_VolumetricBounds *)v55 = *(VolumetricRenderer_VolumetricBounds *)&v55[32];
		        HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem::VolumetricRenderItem(
		          &v60,
		          TemporalComposeCallBack,
		          (VolumetricRenderer_VolumetricBounds *)v55,
		          v43,
		          0,
		          0,
		          0,
		          renderQueue,
		          99999.0,
		          0,
		          1,
		          0,
		          0LL);
		        v45 = *(_OWORD *)&v60.bounds.enableBounds;
		        *(_OWORD *)&item->Callback = *(_OWORD *)&v60.Callback;
		        v46 = *(_OWORD *)&v60.bounds.worldBounds.m_Extents.x;
		        *(_OWORD *)&item->bounds.enableBounds = v45;
		        v47 = *(_OWORD *)&v60.SortingOrder;
		        *(_OWORD *)&item->bounds.worldBounds.m_Extents.x = v46;
		        v38 = *(_OWORD *)&v60.bPureBlit;
		        *(_OWORD *)&item->SortingOrder = v47;
		        meshFilter = v60.meshFilter;
		        goto LABEL_15;
		      }
		      sub_18033B9D0((char *)v56 + 8, 0LL, 80LL);
		      *(_QWORD *)&v56[0] = this->fields._._TemporalComposeCallBack;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)v56, v25, v26, v27, v52);
		      *((_QWORD *)&v56[0] + 1) = this->fields.m_CloudMat;
		      LOWORD(v58) = 256;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)((char *)v56 + 8), v28, v29, v30, v53);
		      v9 = this->fields.m_CloudMat;
		      if ( v9 )
		      {
		        v31 = UnityEngine::Material::get_renderQueue(v9, 0LL);
		        v35 = v56[1];
		        *(_OWORD *)&item->Callback = v56[0];
		        DWORD1(v57) = v31;
		        v36 = v56[2];
		        *(_OWORD *)&item->bounds.enableBounds = v35;
		        v37 = v57;
		        *(_OWORD *)&item->bounds.worldBounds.m_Extents.x = v36;
		        v38 = v58;
		        *(_OWORD *)&item->SortingOrder = v37;
		        meshFilter = v59;
		LABEL_15:
		        *(_OWORD *)&item->bPureBlit = v38;
		        item->meshFilter = meshFilter;
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)item, v32, v33, v34, v54);
		        return 1;
		      }
		LABEL_21:
		      sub_1800D8260(v9, static_fields);
		    }
		    sub_18033B9D0(item, 0LL, 88LL);
		    return 0;
		  }
		}
		
		private void UpdateParametersFromPipeline(HGCamera hgCamera, ScriptableRenderContext renderContext, HGVolumetricCloudSettingParameters volumetricParameters) {} // 0x0000000189C4ACE0-0x0000000189C4BC60
		// Void UpdateParametersFromPipeline(HGCamera, ScriptableRenderContext, HGVolumetricCloudSettingParameters)
		void HG::Rendering::Runtime::VolumetricCloudSDF::UpdateParametersFromPipeline(
		        VolumetricCloudSDF *this,
		        HGCamera *hgCamera,
		        ScriptableRenderContext renderContext,
		        HGVolumetricCloudSettingParameters *volumetricParameters,
		        MethodInfo *method)
		{
		  Material *static_fields; // rdx
		  MaterialPropertyBlock *m_WindFieldManager; // rcx
		  Camera *camera; // r12
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  __m128 v14; // xmm9
		  __int128 v15; // xmm0
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  MethodInfo *v18; // r8
		  Vector3 *v19; // rax
		  __int64 v20; // xmm10_8
		  MethodInfo *v21; // r9
		  Vector3 *v22; // rax
		  __int64 v23; // xmm8_8
		  float z; // esi
		  MethodInfo *v25; // rdx
		  Vector3 *one; // rax
		  __int64 v27; // xmm6_8
		  float v28; // edi
		  float v29; // xmm7_4
		  MethodInfo *v30; // r9
		  Vector3 *v31; // rax
		  float v32; // xmm2_4
		  __m128 x_low; // xmm0
		  __m128 y_low; // xmm1
		  MethodInfo *v35; // r9
		  Vector3 *v36; // rax
		  float x; // r12d
		  float v38; // xmm1_4
		  bool v39; // al
		  Material *m_CloudMat; // rdi
		  Material *v41; // rdi
		  MaterialPropertyBlock *m_propertyBlock; // rsi
		  VolumetricEncodedTexture *DensityTextureToUse; // rdi
		  MaterialPropertyBlock *v44; // rdi
		  int32_t klass; // edx
		  __int128 v46; // xmm1
		  __int128 v47; // xmm0
		  __int128 v48; // xmm1
		  int32_t klass_high; // edx
		  __int128 v50; // xmm1
		  MaterialPropertyBlock *v51; // rcx
		  __int128 v52; // xmm0
		  __int128 v53; // xmm1
		  MethodInfo *v54; // r8
		  Vector4 *v55; // rax
		  MaterialPropertyBlock *v56; // r10
		  int32_t v57; // r11d
		  MethodInfo *v58; // r8
		  Vector4 *v59; // rax
		  MaterialPropertyBlock *v60; // r10
		  int32_t v61; // r11d
		  MethodInfo *v62; // r8
		  Vector4 *v63; // rax
		  MaterialPropertyBlock *v64; // r10
		  int32_t v65; // r11d
		  MethodInfo *v66; // r8
		  Vector4 *v67; // rax
		  MaterialPropertyBlock *v68; // r10
		  int32_t v69; // r11d
		  MethodInfo *v70; // r8
		  Vector4 *v71; // rax
		  MaterialPropertyBlock *v72; // r10
		  int32_t v73; // r11d
		  Vector4 *Vector; // rax
		  MaterialPropertyBlock *v75; // rdi
		  float m_MaxExtent; // xmm8_4
		  __m128 v77; // xmm6
		  VolumetricShaderIDs__StaticFields *v78; // rax
		  int32_t MsFalloffRangeRemap; // esi
		  float v80; // xmm2_4
		  float v81; // xmm6_4
		  float FloatImpl; // xmm0_4
		  float v83; // xmm6_4
		  MethodInfo *v84; // r8
		  Vector4 *v85; // rax
		  MaterialPropertyBlock *v86; // r10
		  int32_t v87; // r11d
		  MethodInfo *v88; // r8
		  Vector4 *v89; // rax
		  MaterialPropertyBlock *v90; // r10
		  int32_t v91; // r11d
		  MethodInfo *v92; // r8
		  Vector4 *v93; // rax
		  MaterialPropertyBlock *v94; // r10
		  int32_t v95; // r11d
		  Material *v96; // rdi
		  HGEnvironmentVolumeCameraComponent *envVolumeCameraComponent; // rax
		  HGEnvironmentPhase *interpolatedPhase; // rax
		  Vector3 *updated; // rax
		  __int64 v100; // xmm1_8
		  MethodInfo *z_low; // r8
		  Vector4 *v102; // rax
		  MaterialPropertyBlock *v103; // r10
		  int32_t v104; // r11d
		  MethodInfo *v105; // r8
		  Vector4 *v106; // rax
		  MaterialPropertyBlock *v107; // r10
		  int32_t v108; // r11d
		  int v109; // eax
		  int v110; // edi
		  int v111; // eax
		  int v112; // edi
		  __m128 v113; // xmm0
		  MaterialPropertyBlock *v114; // rdi
		  int32_t DynamicStepRange; // esi
		  __m128 v116; // xmm6
		  Vector4 *v117; // rax
		  MaterialPropertyBlock *v118; // rdi
		  int32_t DynamicStepScale; // esi
		  float v120; // xmm0_4
		  MethodInfo *v121; // rdx
		  __m128 v122; // xmm6
		  __m128 v123; // xmm7
		  MaterialPropertyBlock *v124; // rdi
		  float v125; // xmm0_4
		  Vector4 *v126; // rax
		  int32_t v127; // r10d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v129; // [rsp+38h] [rbp-D0h] BYREF
		  Vector4 v130; // [rsp+48h] [rbp-C0h] BYREF
		  Vector3 v131; // [rsp+58h] [rbp-B0h] BYREF
		  Vector2 v132; // [rsp+68h] [rbp-A0h]
		  Vector3 v133; // [rsp+78h] [rbp-90h] BYREF
		  int32_t count; // [rsp+88h] [rbp-80h] BYREF
		  CBHandle cbHandle; // [rsp+90h] [rbp-78h] BYREF
		  Matrix4x4 v136[2]; // [rsp+A8h] [rbp-60h] BYREF
		
		  count = 0;
		  memset(&cbHandle, 0, sizeof(cbHandle));
		  if ( !IFix::WrappersManagerImpl::IsPatched(5112, 0LL) )
		  {
		    if ( hgCamera )
		    {
		      camera = hgCamera->fields.camera;
		      if ( camera )
		      {
		        transform = UnityEngine::Component::get_transform((Component *)hgCamera->fields.camera, 0LL);
		        if ( transform )
		        {
		          position = UnityEngine::Transform::get_position((Vector3 *)&v130, transform, 0LL);
		          v14 = (__m128)0x3F800000u;
		          v129.w = 1.0;
		          v132 = *(Vector2 *)&position->x;
		          *(Vector2 *)&v129.x = v132;
		          v129.z = position->z;
		          v15 = *(_OWORD *)&this->fields.m_CloudRenderWorldToLocal.m01;
		          *(_OWORD *)&v136[0].m00 = *(_OWORD *)&this->fields.m_CloudRenderWorldToLocal.m00;
		          v16 = *(_OWORD *)&this->fields.m_CloudRenderWorldToLocal.m02;
		          *(_OWORD *)&v136[0].m01 = v15;
		          v17 = *(_OWORD *)&this->fields.m_CloudRenderWorldToLocal.m03;
		          *(_OWORD *)&v136[0].m02 = v16;
		          *(_OWORD *)&v136[0].m03 = v17;
		          v129 = *UnityEngine::Matrix4x4::op_Multiply(&v130, v136, &v129, 0LL);
		          v19 = UnityEngine::Vector4::op_Implicit(&v133, &v129, v18);
		          *(_QWORD *)&v131.x = *(_QWORD *)&this->fields.m_VoxelSize.x;
		          v20 = *(_QWORD *)&v19->x;
		          v132.x = v19->z;
		          v131.z = this->fields.m_VoxelSize.z;
		          *(_QWORD *)&v130.x = v20;
		          v22 = UnityEngine::Vector3::op_Multiply(&v133, &v131, 0.5, v21);
		          v23 = *(_QWORD *)&v22->x;
		          z = v22->z;
		          one = UnityEngine::Vector3::get_one(&v133, v25);
		          v27 = *(_QWORD *)&one->x;
		          v28 = one->z;
		          v29 = UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
		          sub_1800036A0(TypeInfo::System::Math);
		          *(_QWORD *)&v131.x = v27;
		          *(float *)&v27 = this->fields.m_MaxExtent;
		          v131.z = v28;
		          *(float *)&v17 = System::Math::Max(v29, 1.0, 0LL);
		          v31 = UnityEngine::Vector3::op_Multiply(&v133, &v131, *(float *)&v17, v30);
		          v32 = v31->z;
		          *(_QWORD *)&v131.x = *(_QWORD *)&v31->x;
		          x_low = (__m128)LODWORD(v131.x);
		          y_low = (__m128)LODWORD(v131.y);
		          x_low.m128_f32[0] = v131.x / *(float *)&v27;
		          y_low.m128_f32[0] = v131.y / *(float *)&v27;
		          *(_QWORD *)&v131.x = _mm_unpacklo_ps(x_low, y_low).m128_u64[0];
		          v131.z = v32 / *(float *)&v27;
		          *(_QWORD *)&v133.x = v23;
		          v133.z = z;
		          v36 = UnityEngine::Vector3::op_Addition((Vector3 *)&v129, &v133, &v131, v35);
		          x = v132.x;
		          *(_QWORD *)&v133.x = *(_QWORD *)&v36->x;
		          v39 = v133.x > v130.x
		             && v133.y > v130.y
		             && (v38 = v36->z, v38 > v132.x)
		             && v130.x > (float)-v133.x
		             && v130.y > (float)-v133.y
		             && v132.x > (float)-v38;
		          if ( this->fields.m_inside != v39 )
		          {
		            m_CloudMat = this->fields.m_CloudMat;
		            this->fields.m_inside = v39;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		            LOBYTE(m_WindFieldManager) = this->fields.m_inside;
		            static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		            if ( !m_CloudMat )
		              goto LABEL_61;
		            UnityEngine::Material::SetFloatImpl(
		              m_CloudMat,
		              (int32_t)static_fields->monitor,
		              (float)(2 - ((_BYTE)m_WindFieldManager != 0)),
		              0LL);
		            v41 = this->fields.m_CloudMat;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		            static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		            if ( !v41 )
		              goto LABEL_61;
		            UnityEngine::Material::SetFloatImpl(
		              v41,
		              HIDWORD(static_fields->monitor),
		              (float)(!this->fields.m_inside ? 4 : 0),
		              0LL);
		          }
		          m_propertyBlock = this->fields.m_propertyBlock;
		          DensityTextureToUse = this->fields.DensityTextureToUse;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		          HG::Rendering::Runtime::VolumetricSDFUtils::SetEncodedTexture(
		            m_propertyBlock,
		            (String *)"_DensityTex",
		            DensityTextureToUse,
		            0LL);
		          HG::Rendering::Runtime::VolumetricSDFUtils::SetEncodedTexture(
		            this->fields.m_propertyBlock,
		            (String *)"_AdvancedTex",
		            this->fields.AdvancedTextureToUse,
		            0LL);
		          HG::Rendering::Runtime::VolumetricSDFUtils::SetEncodedTexture(
		            this->fields.m_propertyBlock,
		            (String *)"_WindFieldTex",
		            this->fields.AdvancedTextureToUse,
		            0LL);
		          HG::Rendering::Runtime::VolumetricSDFUtils::SetEncodedTexture(
		            this->fields.m_propertyBlock,
		            (String *)"_SHTex",
		            this->fields.SHTextureToUse,
		            0LL);
		          v44 = this->fields.m_propertyBlock;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		          m_WindFieldManager = (MaterialPropertyBlock *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		          if ( v44 )
		          {
		            klass = (int32_t)m_WindFieldManager[2].klass;
		            v46 = *(_OWORD *)&this->fields.m_CloudRenderWorldToLocal.m01;
		            *(_OWORD *)&v136[0].m00 = *(_OWORD *)&this->fields.m_CloudRenderWorldToLocal.m00;
		            v47 = *(_OWORD *)&this->fields.m_CloudRenderWorldToLocal.m02;
		            *(_OWORD *)&v136[0].m01 = v46;
		            v48 = *(_OWORD *)&this->fields.m_CloudRenderWorldToLocal.m03;
		            *(_OWORD *)&v136[0].m02 = v47;
		            *(_OWORD *)&v136[0].m03 = v48;
		            UnityEngine::MaterialPropertyBlock::SetMatrix(v44, klass, v136, 0LL);
		            m_WindFieldManager = (MaterialPropertyBlock *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		            if ( this->fields.m_propertyBlock )
		            {
		              klass_high = HIDWORD(m_WindFieldManager[2].klass);
		              v50 = *(_OWORD *)&this->fields.m_CloudRenderLocalToWorld.m01;
		              v51 = this->fields.m_propertyBlock;
		              *(_OWORD *)&v136[0].m00 = *(_OWORD *)&this->fields.m_CloudRenderLocalToWorld.m00;
		              v52 = *(_OWORD *)&this->fields.m_CloudRenderLocalToWorld.m02;
		              *(_OWORD *)&v136[0].m01 = v50;
		              v53 = *(_OWORD *)&this->fields.m_CloudRenderLocalToWorld.m03;
		              *(_OWORD *)&v136[0].m02 = v52;
		              *(_OWORD *)&v136[0].m03 = v53;
		              UnityEngine::MaterialPropertyBlock::SetMatrix(v51, klass_high, v136, 0LL);
		              *(_QWORD *)&v130.x = *(_QWORD *)&this->fields.m_VoxelSize.x;
		              v130.z = this->fields.m_VoxelSize.z;
		              v55 = UnityEngine::Vector4::op_Implicit(&v129, (Vector3 *)&v130, v54);
		              if ( v56 )
		              {
		                v129 = *v55;
		                UnityEngine::MaterialPropertyBlock::SetVector(v56, v57, &v129, 0LL);
		                *(_QWORD *)&v130.x = *(_QWORD *)&this->fields.m_InvScale.x;
		                v130.z = this->fields.m_InvScale.z;
		                v59 = UnityEngine::Vector4::op_Implicit(&v129, (Vector3 *)&v130, v58);
		                if ( v60 )
		                {
		                  v129 = *v59;
		                  UnityEngine::MaterialPropertyBlock::SetVector(v60, v61, &v129, 0LL);
		                  m_WindFieldManager = this->fields.m_propertyBlock;
		                  static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                  if ( m_WindFieldManager )
		                  {
		                    UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                      m_WindFieldManager,
		                      (int32_t)static_fields->fields._.m_CachedPtr,
		                      this->fields.m_MaxExtent,
		                      0LL);
		                    m_WindFieldManager = this->fields.m_propertyBlock;
		                    static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                    if ( m_WindFieldManager )
		                    {
		                      UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                        m_WindFieldManager,
		                        HIDWORD(static_fields->fields._.m_CachedPtr),
		                        1.0 / this->fields.m_MaxExtent,
		                        0LL);
		                      *(_QWORD *)&v130.x = *(_QWORD *)&this->fields.m_WindPhase.x;
		                      v130.z = this->fields.m_WindPhase.z;
		                      v63 = UnityEngine::Vector4::op_Implicit(&v129, (Vector3 *)&v130, v62);
		                      if ( v64 )
		                      {
		                        v129 = *v63;
		                        UnityEngine::MaterialPropertyBlock::SetVector(v64, v65, &v129, 0LL);
		                        *(_QWORD *)&v130.x = *(_QWORD *)&this->fields.m_WindPhase2.x;
		                        v130.z = this->fields.m_WindPhase2.z;
		                        v67 = UnityEngine::Vector4::op_Implicit(&v129, (Vector3 *)&v130, v66);
		                        if ( v68 )
		                        {
		                          v129 = *v67;
		                          UnityEngine::MaterialPropertyBlock::SetVector(v68, v69, &v129, 0LL);
		                          *(_QWORD *)&v130.x = *(_QWORD *)&this->fields.m_WindPhase3.x;
		                          v130.z = this->fields.m_WindPhase3.z;
		                          v71 = UnityEngine::Vector4::op_Implicit(&v129, (Vector3 *)&v130, v70);
		                          if ( v72 )
		                          {
		                            v129 = *v71;
		                            UnityEngine::MaterialPropertyBlock::SetVector(v72, v73, &v129, 0LL);
		                            static_fields = this->fields.m_CloudMat;
		                            m_WindFieldManager = (MaterialPropertyBlock *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                            if ( static_fields )
		                            {
		                              Vector = UnityEngine::Material::GetVector(
		                                         &v129,
		                                         static_fields,
		                                         HIDWORD(m_WindFieldManager[13].klass),
		                                         0LL);
		                              static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
		                              m_WindFieldManager = (MaterialPropertyBlock *)this->fields.m_CloudMat;
		                              v75 = this->fields.m_propertyBlock;
		                              v77 = (__m128)_mm_loadu_si128((const __m128i *)Vector);
		                              v78 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                              MsFalloffRangeRemap = v78->_MsFalloffRangeRemap;
		                              if ( m_WindFieldManager )
		                              {
		                                v80 = _mm_shuffle_ps(v77, v77, 85).m128_f32[0] - v77.m128_f32[0];
		                                m_MaxExtent = this->fields.m_MaxExtent;
		                                v129.x = (float)(UnityEngine::Material::GetFloatImpl(
		                                                   (Material *)m_WindFieldManager,
		                                                   v78->_Extinction,
		                                                   0LL)
		                                               * m_MaxExtent)
		                                       / v80;
		                                v129.w = _mm_shuffle_ps(v77, v77, 170).m128_f32[0];
		                                v129.z = _mm_shuffle_ps(v77, v77, 255).m128_f32[0] - v129.w;
		                                v129.y = (float)-v77.m128_f32[0] / v80;
		                                if ( v75 )
		                                {
		                                  UnityEngine::MaterialPropertyBlock::SetVector(v75, MsFalloffRangeRemap, &v129, 0LL);
		                                  m_WindFieldManager = (MaterialPropertyBlock *)this->fields.m_CloudMat;
		                                  v81 = this->fields.m_MaxExtent;
		                                  static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                                  if ( m_WindFieldManager )
		                                  {
		                                    FloatImpl = UnityEngine::Material::GetFloatImpl(
		                                                  (Material *)m_WindFieldManager,
		                                                  HIDWORD(static_fields[4].klass),
		                                                  0LL);
		                                    m_WindFieldManager = this->fields.m_propertyBlock;
		                                    v83 = v81 / FloatImpl;
		                                    static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                                    if ( m_WindFieldManager )
		                                    {
		                                      UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                                        m_WindFieldManager,
		                                        (int32_t)static_fields[25].klass,
		                                        v83,
		                                        0LL);
		                                      m_WindFieldManager = this->fields.m_propertyBlock;
		                                      static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                                      if ( m_WindFieldManager )
		                                      {
		                                        UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                                          m_WindFieldManager,
		                                          HIDWORD(static_fields[25].klass),
		                                          1.0 / v83,
		                                          0LL);
		                                        *(_QWORD *)&v130.x = *(_QWORD *)&this->fields.m_WindOffset.x;
		                                        v130.z = this->fields.m_WindOffset.z;
		                                        v85 = UnityEngine::Vector4::op_Implicit(&v129, (Vector3 *)&v130, v84);
		                                        if ( v86 )
		                                        {
		                                          v129 = *v85;
		                                          UnityEngine::MaterialPropertyBlock::SetVector(v86, v87, &v129, 0LL);
		                                          *(_QWORD *)&v130.x = *(_QWORD *)&this->fields.m_WindOffset2.x;
		                                          v130.z = this->fields.m_WindOffset2.z;
		                                          v89 = UnityEngine::Vector4::op_Implicit(&v129, (Vector3 *)&v130, v88);
		                                          if ( v90 )
		                                          {
		                                            v129 = *v89;
		                                            UnityEngine::MaterialPropertyBlock::SetVector(v90, v91, &v129, 0LL);
		                                            *(_QWORD *)&v130.x = *(_QWORD *)&this->fields.m_WindOffset3.x;
		                                            v130.z = this->fields.m_WindOffset3.z;
		                                            v93 = UnityEngine::Vector4::op_Implicit(&v129, (Vector3 *)&v130, v92);
		                                            if ( v94 )
		                                            {
		                                              v129 = *v93;
		                                              UnityEngine::MaterialPropertyBlock::SetVector(v94, v95, &v129, 0LL);
		                                              v96 = this->fields.m_CloudMat;
		                                              envVolumeCameraComponent = HG::Rendering::Runtime::HGCamera::get_envVolumeCameraComponent(
		                                                                           hgCamera,
		                                                                           0LL);
		                                              if ( envVolumeCameraComponent )
		                                              {
		                                                interpolatedPhase = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedPhase(
		                                                                      envVolumeCameraComponent,
		                                                                      0LL);
		                                                updated = HG::Rendering::Runtime::VolumetricSDFUtils::UpdateMainLightDirection(
		                                                            (Vector3 *)&v129,
		                                                            v96,
		                                                            interpolatedPhase,
		                                                            0LL);
		                                                v100 = *(_QWORD *)&updated->x;
		                                                z_low = (MethodInfo *)LODWORD(updated->z);
		                                                *(_QWORD *)&this->fields.m_MainLightDirection.x = *(_QWORD *)&updated->x;
		                                                LODWORD(this->fields.m_MainLightDirection.z) = (_DWORD)z_low;
		                                                *(_QWORD *)&v130.x = v100;
		                                                LODWORD(v130.z) = (_DWORD)z_low;
		                                                v102 = UnityEngine::Vector4::op_Implicit(&v129, (Vector3 *)&v130, z_low);
		                                                if ( v103 )
		                                                {
		                                                  v129 = *v102;
		                                                  UnityEngine::MaterialPropertyBlock::SetVector(v103, v104, &v129, 0LL);
		                                                  *(_QWORD *)&v130.x = v20;
		                                                  v130.z = x;
		                                                  v106 = UnityEngine::Vector4::op_Implicit(
		                                                           &v129,
		                                                           (Vector3 *)&v130,
		                                                           v105);
		                                                  if ( v107 )
		                                                  {
		                                                    v129 = *v106;
		                                                    UnityEngine::MaterialPropertyBlock::SetVector(
		                                                      v107,
		                                                      v108,
		                                                      &v129,
		                                                      0LL);
		                                                    m_WindFieldManager = (MaterialPropertyBlock *)this->fields.m_CloudMat;
		                                                    static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                                                    if ( m_WindFieldManager )
		                                                    {
		                                                      UnityEngine::Material::GetInt(
		                                                        (Material *)m_WindFieldManager,
		                                                        HIDWORD(static_fields[7].monitor),
		                                                        0LL);
		                                                      if ( volumetricParameters )
		                                                      {
		                                                        HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                                          volumetricParameters->fields.marchStepScale,
		                                                          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		                                                        v109 = sub_1832DBD50();
		                                                        static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
		                                                        v110 = v109;
		                                                        m_WindFieldManager = this->fields.m_propertyBlock;
		                                                        if ( m_WindFieldManager )
		                                                        {
		                                                          UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                                                            m_WindFieldManager,
		                                                            TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_MarchStepNum,
		                                                            (float)v109,
		                                                            0LL);
		                                                          static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
		                                                          m_WindFieldManager = this->fields.m_propertyBlock;
		                                                          if ( m_WindFieldManager )
		                                                          {
		                                                            UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                                                              m_WindFieldManager,
		                                                              TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InvMarchStepNum,
		                                                              1.0 / (float)v110,
		                                                              0LL);
		                                                            m_WindFieldManager = (MaterialPropertyBlock *)this->fields.m_CloudMat;
		                                                            static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                                                            if ( m_WindFieldManager )
		                                                            {
		                                                              UnityEngine::Material::GetInt(
		                                                                (Material *)m_WindFieldManager,
		                                                                HIDWORD(static_fields[14].monitor),
		                                                                0LL);
		                                                              HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                                                volumetricParameters->fields.godRayStepScale,
		                                                                MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		                                                              v111 = sub_1832DBD50();
		                                                              static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
		                                                              v112 = v111;
		                                                              m_WindFieldManager = this->fields.m_propertyBlock;
		                                                              if ( m_WindFieldManager )
		                                                              {
		                                                                UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                                                                  m_WindFieldManager,
		                                                                  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_GodRayStepNum,
		                                                                  (float)v111,
		                                                                  0LL);
		                                                                static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
		                                                                m_WindFieldManager = this->fields.m_propertyBlock;
		                                                                if ( m_WindFieldManager )
		                                                                {
		                                                                  v113 = (__m128)COERCE_UNSIGNED_INT((float)v112);
		                                                                  UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                                                                    m_WindFieldManager,
		                                                                    TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InvGodRayStepNum,
		                                                                    1.0 / v113.m128_f32[0],
		                                                                    0LL);
		                                                                  v114 = this->fields.m_propertyBlock;
		                                                                  DynamicStepRange = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_DynamicStepRange;
		                                                                  v113.m128_f32[0] = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                                                                       volumetricParameters->fields.dynamicStepRange,
		                                                                                       MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		                                                                  v116 = v113;
		                                                                  v14.m128_f32[0] = 1.0
		                                                                                  / HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                                                                      volumetricParameters->fields.dynamicStepRange,
		                                                                                      MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		                                                                  v117 = (Vector4 *)sub_183240A00(
		                                                                                      &v129,
		                                                                                      _mm_unpacklo_ps(v116, v14).m128_u64[0]);
		                                                                  if ( v114 )
		                                                                  {
		                                                                    v129 = *v117;
		                                                                    UnityEngine::MaterialPropertyBlock::SetVector(
		                                                                      v114,
		                                                                      DynamicStepRange,
		                                                                      &v129,
		                                                                      0LL);
		                                                                    v118 = this->fields.m_propertyBlock;
		                                                                    DynamicStepScale = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_DynamicStepScale;
		                                                                    v120 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                                                             volumetricParameters->fields.dynamicStepScale,
		                                                                             MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		                                                                    if ( v118 )
		                                                                    {
		                                                                      UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                                                                        v118,
		                                                                        DynamicStepScale,
		                                                                        v120,
		                                                                        0LL);
		                                                                      static_fields = this->fields.m_CloudMat;
		                                                                      m_WindFieldManager = (MaterialPropertyBlock *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                                                                      if ( static_fields )
		                                                                      {
		                                                                        v129 = *UnityEngine::Material::GetVector(
		                                                                                  &v129,
		                                                                                  static_fields,
		                                                                                  HIDWORD(m_WindFieldManager[6].fields.m_Ptr),
		                                                                                  0LL);
		                                                                        v132 = UnityEngine::Vector4::op_Implicit(
		                                                                                 &v129,
		                                                                                 v121);
		                                                                        v122 = (__m128)LODWORD(v132.x);
		                                                                        v123 = (__m128)LODWORD(v132.y);
		                                                                        if ( v132.x <= 0.0 )
		                                                                          v122 = 0LL;
		                                                                        if ( !HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModePanoramic(
		                                                                                this,
		                                                                                volumetricParameters,
		                                                                                0LL)
		                                                                          && !HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeOctahedron(
		                                                                                this,
		                                                                                volumetricParameters,
		                                                                                0LL)
		                                                                          && !HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeSemicircular(
		                                                                                this,
		                                                                                volumetricParameters,
		                                                                                0LL) )
		                                                                        {
		                                                                          v123 = (__m128)0x461C4000u;
		                                                                        }
		                                                                        v124 = this->fields.m_propertyBlock;
		                                                                        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		                                                                        v125 = this->fields.m_MaxExtent;
		                                                                        v122.m128_f32[0] = v122.m128_f32[0] / v125;
		                                                                        v123.m128_f32[0] = v123.m128_f32[0] / v125;
		                                                                        v126 = (Vector4 *)sub_183240A00(
		                                                                                            &v129,
		                                                                                            _mm_unpacklo_ps(v122, v123).m128_u64[0]);
		                                                                        if ( v124 )
		                                                                        {
		                                                                          v129 = *v126;
		                                                                          UnityEngine::MaterialPropertyBlock::SetVector(
		                                                                            v124,
		                                                                            v127,
		                                                                            &v129,
		                                                                            0LL);
		                                                                          m_WindFieldManager = (MaterialPropertyBlock *)this->fields.m_WindFieldManager;
		                                                                          if ( m_WindFieldManager )
		                                                                          {
		                                                                            HG::Rendering::Runtime::VolumetricWindFieldManager::GetWindFieldCB(
		                                                                              (VolumetricWindFieldManager *)m_WindFieldManager,
		                                                                              renderContext,
		                                                                              &cbHandle,
		                                                                              &count,
		                                                                              0LL);
		                                                                            m_WindFieldManager = this->fields.m_propertyBlock;
		                                                                            static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                                                                            if ( m_WindFieldManager )
		                                                                            {
		                                                                              UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                                                                                m_WindFieldManager,
		                                                                                HIDWORD(static_fields[24].monitor),
		                                                                                (float)count,
		                                                                                0LL);
		                                                                              m_WindFieldManager = this->fields.m_propertyBlock;
		                                                                              static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                                                                              if ( m_WindFieldManager )
		                                                                              {
		                                                                                UnityEngine::MaterialPropertyBlock::SetConstantBufferImpl0(
		                                                                                  m_WindFieldManager,
		                                                                                  (int32_t)static_fields[24].fields._.m_CachedPtr,
		                                                                                  cbHandle.bufferId,
		                                                                                  cbHandle.offset,
		                                                                                  cbHandle.size,
		                                                                                  0LL);
		                                                                                m_WindFieldManager = this->fields.m_propertyBlock;
		                                                                                static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                                                                                if ( m_WindFieldManager )
		                                                                                {
		                                                                                  UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                                                                                    m_WindFieldManager,
		                                                                                    (int32_t)static_fields[13].fields._.m_CachedPtr,
		                                                                                    this->fields.m_OpticalDepthScale,
		                                                                                    0LL);
		                                                                                  m_WindFieldManager = this->fields.m_propertyBlock;
		                                                                                  static_fields = (Material *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                                                                                  if ( m_WindFieldManager )
		                                                                                  {
		                                                                                    UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                                                                                      m_WindFieldManager,
		                                                                                      HIDWORD(static_fields[13].fields._.m_CachedPtr),
		                                                                                      this->fields.m_InvOpticalDepthScale,
		                                                                                      0LL);
		                                                                                    return;
		                                                                                  }
		                                                                                }
		                                                                              }
		                                                                            }
		                                                                          }
		                                                                        }
		                                                                      }
		                                                                    }
		                                                                  }
		                                                                }
		                                                              }
		                                                            }
		                                                          }
		                                                        }
		                                                      }
		                                                    }
		                                                  }
		                                                }
		                                              }
		                                            }
		                                          }
		                                        }
		                                      }
		                                    }
		                                  }
		                                }
		                              }
		                            }
		                          }
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_61:
		    sub_1800D8260(m_WindFieldManager, static_fields);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5112, 0LL);
		  if ( !Patch )
		    goto LABEL_61;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_236(
		    Patch,
		    (Object *)this,
		    (Object *)hgCamera,
		    renderContext,
		    (Object *)volumetricParameters,
		    0LL);
		}
		
		private unsafe void UpdateParametersFromPipelineCPP(HGCamera hgCamera, ScriptableRenderContext renderContext, HGVolumetricCloudSettingParameters volumetricParameters, HGVolumetricCloudDataCB* dataCB) {} // 0x0000000189C49FEC-0x0000000189C4ACE0
		// Void UpdateParametersFromPipelineCPP(HGCamera, ScriptableRenderContext, HGVolumetricCloudSettingParameters, HGVolumetricCloudDataCB*)
		void HG::Rendering::Runtime::VolumetricCloudSDF::UpdateParametersFromPipelineCPP(
		        VolumetricCloudSDF *this,
		        HGCamera *hgCamera,
		        ScriptableRenderContext renderContext,
		        HGVolumetricCloudSettingParameters *volumetricParameters,
		        HGVolumetricCloudDataCB *dataCB,
		        MethodInfo *method)
		{
		  HGCamera *v8; // r13
		  VolumetricCloudSDF *v9; // r14
		  Component *camera; // r12
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  __m128 v13; // xmm9
		  __int128 v14; // xmm0
		  __int128 v15; // xmm1
		  __int128 v16; // xmm0
		  MethodInfo *v17; // r8
		  Vector3 *v18; // rax
		  __int64 v19; // xmm10_8
		  MethodInfo *v20; // r9
		  Vector3 *v21; // rax
		  __int64 v22; // xmm8_8
		  float v23; // esi
		  MethodInfo *v24; // rdx
		  Vector3 *one; // rax
		  __int64 v26; // xmm6_8
		  float v27; // edi
		  float v28; // xmm7_4
		  MethodInfo *v29; // r9
		  Vector3 *v30; // rax
		  float v31; // xmm2_4
		  __m128 x_low; // xmm0
		  __m128 y_low; // xmm1
		  MethodInfo *v34; // r9
		  Vector3 *v35; // rax
		  MethodInfo *v36; // r8
		  float v37; // xmm1_4
		  bool v38; // al
		  Material *m_CloudMat; // rdi
		  Material *v40; // rdi
		  Object_1 *Tex; // rdi
		  MaterialPropertyBlock *m_propertyBlock; // rdi
		  VolumetricEncodedTexture *DensityTextureToUse; // rax
		  VolumetricEncodedTexture *v44; // rdi
		  Vector4 v45; // xmm0
		  Object_1 *v46; // rdi
		  MaterialPropertyBlock *v47; // rdi
		  VolumetricEncodedTexture *AdvancedTextureToUse; // rax
		  VolumetricEncodedTexture *v49; // rdi
		  Vector4 v50; // xmm0
		  VolumetricEncodedTexture *v51; // rax
		  Object_1 *v52; // rdi
		  MaterialPropertyBlock *v53; // rdi
		  VolumetricEncodedTexture *SHTextureToUse; // rax
		  VolumetricEncodedTexture *v55; // rdi
		  Vector4 v56; // xmm0
		  __int128 v57; // xmm1
		  __int128 v58; // xmm2
		  __int128 v59; // xmm3
		  __int128 v60; // xmm1
		  __int128 v61; // xmm2
		  __int128 v62; // xmm3
		  float v63; // eax
		  float v64; // eax
		  MethodInfo *v65; // r8
		  float v66; // eax
		  MethodInfo *v67; // r8
		  float v68; // eax
		  MethodInfo *v69; // r8
		  float v70; // eax
		  MethodInfo *v71; // r8
		  Material *v72; // rdi
		  Vector4 *Vector; // rax
		  float m_MaxExtent; // xmm8_4
		  __m128 v75; // xmm6
		  float v76; // xmm2_4
		  float v77; // xmm6_4
		  float v78; // xmm6_4
		  float v79; // eax
		  MethodInfo *v80; // r8
		  float v81; // eax
		  MethodInfo *v82; // r8
		  float v83; // eax
		  MethodInfo *v84; // r8
		  Material *v85; // r12
		  HGEnvironmentVolumeCameraComponent *envVolumeCameraComponent; // rax
		  HGEnvironmentPhase *interpolatedPhase; // rdi
		  Vector3 *updated; // rax
		  float v89; // ecx
		  __int64 v90; // xmm1_8
		  MethodInfo *v91; // r8
		  Vector4 *v92; // rax
		  Vector4 v93; // xmm0
		  MethodInfo *v94; // r8
		  int32_t v95; // eax
		  int32_t v96; // eax
		  __m128 v97; // xmm0
		  __m128 v98; // xmm6
		  MethodInfo *v99; // rdx
		  __m128 v100; // xmm6
		  __m128 v101; // xmm7
		  float v102; // xmm0_4
		  MaterialPropertyBlock *v103; // rbx
		  Vector4 v104; // [rsp+38h] [rbp-D0h] BYREF
		  Vector4 v105; // [rsp+48h] [rbp-C0h] BYREF
		  Vector3 v106; // [rsp+58h] [rbp-B0h] BYREF
		  Vector3 v107; // [rsp+68h] [rbp-A0h] BYREF
		  CBHandle cbHandle; // [rsp+78h] [rbp-90h] BYREF
		  __int64 v109; // [rsp+90h] [rbp-78h]
		  Matrix4x4 v110; // [rsp+98h] [rbp-70h] BYREF
		  float z; // [rsp+160h] [rbp+58h]
		  Vector2 v112; // [rsp+160h] [rbp+58h]
		
		  v8 = hgCamera;
		  v9 = this;
		  cbHandle.bufferId = 0;
		  v109 = 0LL;
		  *(_OWORD *)&cbHandle.size = 0LL;
		  if ( !hgCamera )
		    goto LABEL_53;
		  camera = (Component *)hgCamera->fields.camera;
		  if ( !camera )
		    goto LABEL_53;
		  transform = UnityEngine::Component::get_transform(camera, 0LL);
		  if ( !transform )
		    goto LABEL_53;
		  position = UnityEngine::Transform::get_position((Vector3 *)&v105, transform, 0LL);
		  v13 = (__m128)0x3F800000u;
		  v104.w = 1.0;
		  *(_QWORD *)&v106.x = *(_QWORD *)&position->x;
		  *(_QWORD *)&v104.x = *(_QWORD *)&v106.x;
		  v104.z = position->z;
		  v14 = *(_OWORD *)&v9->fields.m_CloudRenderWorldToLocal.m01;
		  *(_OWORD *)&v110.m00 = *(_OWORD *)&v9->fields.m_CloudRenderWorldToLocal.m00;
		  v15 = *(_OWORD *)&v9->fields.m_CloudRenderWorldToLocal.m02;
		  *(_OWORD *)&v110.m01 = v14;
		  v16 = *(_OWORD *)&v9->fields.m_CloudRenderWorldToLocal.m03;
		  *(_OWORD *)&v110.m02 = v15;
		  *(_OWORD *)&v110.m03 = v16;
		  v104 = *UnityEngine::Matrix4x4::op_Multiply(&v105, &v110, &v104, 0LL);
		  v18 = UnityEngine::Vector4::op_Implicit(&v107, &v104, v17);
		  *(_QWORD *)&v106.x = *(_QWORD *)&v9->fields.m_VoxelSize.x;
		  v19 = *(_QWORD *)&v18->x;
		  z = v18->z;
		  v106.z = v9->fields.m_VoxelSize.z;
		  *(_QWORD *)&v105.x = v19;
		  v21 = UnityEngine::Vector3::op_Multiply(&v107, &v106, 0.5, v20);
		  v22 = *(_QWORD *)&v21->x;
		  v23 = v21->z;
		  one = UnityEngine::Vector3::get_one(&v107, v24);
		  v26 = *(_QWORD *)&one->x;
		  v27 = one->z;
		  v28 = UnityEngine::Camera::get_nearClipPlane((Camera *)camera, 0LL);
		  sub_1800036A0(TypeInfo::System::Math);
		  *(_QWORD *)&v106.x = v26;
		  *(float *)&v26 = v9->fields.m_MaxExtent;
		  v106.z = v27;
		  *(float *)&v16 = System::Math::Max(v28, 1.0, 0LL);
		  v30 = UnityEngine::Vector3::op_Multiply(&v107, &v106, *(float *)&v16, v29);
		  v31 = v30->z;
		  *(_QWORD *)&v106.x = *(_QWORD *)&v30->x;
		  x_low = (__m128)LODWORD(v106.x);
		  y_low = (__m128)LODWORD(v106.y);
		  x_low.m128_f32[0] = v106.x / *(float *)&v26;
		  y_low.m128_f32[0] = v106.y / *(float *)&v26;
		  *(_QWORD *)&v106.x = _mm_unpacklo_ps(x_low, y_low).m128_u64[0];
		  v106.z = v31 / *(float *)&v26;
		  *(_QWORD *)&v107.x = v22;
		  v107.z = v23;
		  v35 = UnityEngine::Vector3::op_Addition((Vector3 *)&v104, &v107, &v106, v34);
		  *(_QWORD *)&v107.x = *(_QWORD *)&v35->x;
		  v38 = v107.x > v105.x
		     && v107.y > v105.y
		     && (v37 = v35->z, v37 > z)
		     && v105.x > (float)-v107.x
		     && v105.y > (float)-v107.y
		     && z > (float)-v37;
		  if ( v9->fields.m_inside != v38 )
		  {
		    m_CloudMat = v9->fields.m_CloudMat;
		    v9->fields.m_inside = v38;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		    LOBYTE(this) = v9->fields.m_inside;
		    hgCamera = (HGCamera *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		    if ( !m_CloudMat )
		      goto LABEL_53;
		    UnityEngine::Material::SetFloatImpl(m_CloudMat, (int32_t)hgCamera->monitor, (float)(2 - ((_BYTE)this != 0)), 0LL);
		    v40 = v9->fields.m_CloudMat;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		    hgCamera = (HGCamera *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		    if ( !v40 )
		      goto LABEL_53;
		    UnityEngine::Material::SetFloatImpl(v40, HIDWORD(hgCamera->monitor), (float)(!v9->fields.m_inside ? 4 : 0), 0LL);
		  }
		  if ( v9->fields.DensityTextureToUse )
		  {
		    Tex = (Object_1 *)v9->fields.DensityTextureToUse->fields.Tex;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Implicit(Tex, 0LL) )
		    {
		      m_propertyBlock = v9->fields.m_propertyBlock;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		      hgCamera = (HGCamera *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		      DensityTextureToUse = v9->fields.DensityTextureToUse;
		      if ( !DensityTextureToUse )
		        goto LABEL_53;
		      if ( !m_propertyBlock )
		        goto LABEL_53;
		      UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
		        m_propertyBlock,
		        LODWORD(hgCamera->fields.mainViewConstants.viewNoTransProjMatrix.m02),
		        DensityTextureToUse->fields.Tex,
		        0LL);
		      v44 = v9->fields.DensityTextureToUse;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		      v45 = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeBase(
		                                                        &v104,
		                                                        v44,
		                                                        0LL));
		      if ( !dataCB )
		        goto LABEL_53;
		      dataCB->_DensityTex_RemapRangeBase = v45;
		      dataCB->_DensityTex_RemapRangeScale = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeScale(
		                                                                                        &v104,
		                                                                                        v9->fields.DensityTextureToUse,
		                                                                                        0LL));
		    }
		  }
		  if ( v9->fields.AdvancedTextureToUse )
		  {
		    v46 = (Object_1 *)v9->fields.AdvancedTextureToUse->fields.Tex;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Implicit(v46, 0LL) )
		    {
		      v47 = v9->fields.m_propertyBlock;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		      hgCamera = (HGCamera *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		      AdvancedTextureToUse = v9->fields.AdvancedTextureToUse;
		      if ( !AdvancedTextureToUse )
		        goto LABEL_53;
		      if ( !v47 )
		        goto LABEL_53;
		      UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
		        v47,
		        LODWORD(hgCamera->fields.mainViewConstants.viewNoTransProjMatrix.m12),
		        AdvancedTextureToUse->fields.Tex,
		        0LL);
		      v49 = v9->fields.AdvancedTextureToUse;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		      v50 = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeBase(
		                                                        &v104,
		                                                        v49,
		                                                        0LL));
		      if ( !dataCB )
		        goto LABEL_53;
		      dataCB->_AdvancedTex_RemapRangeBase = v50;
		      dataCB->_AdvancedTex_RemapRangeScale = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeScale(
		                                                                                         &v104,
		                                                                                         v9->fields.AdvancedTextureToUse,
		                                                                                         0LL));
		      this = (VolumetricCloudSDF *)v9->fields.m_propertyBlock;
		      hgCamera = (HGCamera *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		      v51 = v9->fields.AdvancedTextureToUse;
		      if ( !v51 || !this )
		        goto LABEL_53;
		      UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
		        (MaterialPropertyBlock *)this,
		        LODWORD(hgCamera->fields.mainViewConstants.invViewProjMatrix.m31),
		        v51->fields.Tex,
		        0LL);
		      dataCB->_WindFieldTex_RemapRangeBase = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeBase(
		                                                                                         &v104,
		                                                                                         v9->fields.AdvancedTextureToUse,
		                                                                                         0LL));
		      dataCB->_WindFieldTex_RemapRangeScale = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeScale(
		                                                                                          &v104,
		                                                                                          v9->fields.AdvancedTextureToUse,
		                                                                                          0LL));
		    }
		  }
		  if ( v9->fields.SHTextureToUse )
		  {
		    v52 = (Object_1 *)v9->fields.SHTextureToUse->fields.Tex;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Implicit(v52, 0LL) )
		    {
		      v53 = v9->fields.m_propertyBlock;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		      hgCamera = (HGCamera *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		      SHTextureToUse = v9->fields.SHTextureToUse;
		      if ( !SHTextureToUse )
		        goto LABEL_53;
		      if ( !v53 )
		        goto LABEL_53;
		      UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
		        v53,
		        LODWORD(hgCamera->fields.mainViewConstants.viewNoTransProjMatrix.m22),
		        SHTextureToUse->fields.Tex,
		        0LL);
		      v55 = v9->fields.SHTextureToUse;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		      v56 = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeBase(
		                                                        &v104,
		                                                        v55,
		                                                        0LL));
		      if ( !dataCB )
		        goto LABEL_53;
		      dataCB->_SHTex_RemapRangeBase = v56;
		      dataCB->_SHTex_RemapRangeScale = (Vector4)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::VolumetricSDFUtils::GetRangeScale(
		                                                                                   &v104,
		                                                                                   v9->fields.SHTextureToUse,
		                                                                                   0LL));
		    }
		  }
		  v57 = *(_OWORD *)&v9->fields.m_CloudRenderWorldToLocal.m01;
		  v58 = *(_OWORD *)&v9->fields.m_CloudRenderWorldToLocal.m02;
		  v59 = *(_OWORD *)&v9->fields.m_CloudRenderWorldToLocal.m03;
		  if ( !dataCB )
		    goto LABEL_53;
		  *(_OWORD *)&dataCB->_BoxWorldToLocal.m00 = *(_OWORD *)&v9->fields.m_CloudRenderWorldToLocal.m00;
		  *(_OWORD *)&dataCB->_BoxWorldToLocal.m01 = v57;
		  *(_OWORD *)&dataCB->_BoxWorldToLocal.m02 = v58;
		  *(_OWORD *)&dataCB->_BoxWorldToLocal.m03 = v59;
		  v60 = *(_OWORD *)&v9->fields.m_CloudRenderLocalToWorld.m01;
		  v61 = *(_OWORD *)&v9->fields.m_CloudRenderLocalToWorld.m02;
		  v62 = *(_OWORD *)&v9->fields.m_CloudRenderLocalToWorld.m03;
		  *(_OWORD *)&dataCB->_BoxLocalToWorld.m00 = *(_OWORD *)&v9->fields.m_CloudRenderLocalToWorld.m00;
		  *(_OWORD *)&dataCB->_BoxLocalToWorld.m01 = v60;
		  *(_OWORD *)&dataCB->_BoxLocalToWorld.m02 = v61;
		  *(_OWORD *)&dataCB->_BoxLocalToWorld.m03 = v62;
		  v63 = v9->fields.m_VoxelSize.z;
		  *(_QWORD *)&v105.x = *(_QWORD *)&v9->fields.m_VoxelSize.x;
		  v105.z = v63;
		  dataCB->_VoxelSize = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
		                                                                   &v104,
		                                                                   (Vector3 *)&v105,
		                                                                   v36));
		  v64 = v9->fields.m_InvScale.z;
		  *(_QWORD *)&v105.x = *(_QWORD *)&v9->fields.m_InvScale.x;
		  v105.z = v64;
		  dataCB->_InvScale = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
		                                                                  &v104,
		                                                                  (Vector3 *)&v105,
		                                                                  v65));
		  dataCB->_GlobalScale = v9->fields.m_MaxExtent;
		  dataCB->_InvGlobalScale = 1.0 / v9->fields.m_MaxExtent;
		  v66 = v9->fields.m_WindPhase.z;
		  *(_QWORD *)&v105.x = *(_QWORD *)&v9->fields.m_WindPhase.x;
		  v105.z = v66;
		  dataCB->_WindPhase = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
		                                                                   &v104,
		                                                                   (Vector3 *)&v105,
		                                                                   v67));
		  v68 = v9->fields.m_WindPhase2.z;
		  *(_QWORD *)&v105.x = *(_QWORD *)&v9->fields.m_WindPhase2.x;
		  v105.z = v68;
		  dataCB->_WindPhase2 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
		                                                                    &v104,
		                                                                    (Vector3 *)&v105,
		                                                                    v69));
		  v70 = v9->fields.m_WindPhase3.z;
		  *(_QWORD *)&v105.x = *(_QWORD *)&v9->fields.m_WindPhase3.x;
		  v105.z = v70;
		  dataCB->_WindPhase3 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
		                                                                    &v104,
		                                                                    (Vector3 *)&v105,
		                                                                    v71));
		  v72 = v9->fields.m_CloudMat;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		  this = (VolumetricCloudSDF *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		  if ( !v72 )
		    goto LABEL_53;
		  Vector = UnityEngine::Material::GetVector(&v104, v72, LODWORD(this->fields.m_CloudRenderLocalToWorld.m10), 0LL);
		  this = (VolumetricCloudSDF *)v9->fields.m_CloudMat;
		  v75 = (__m128)_mm_loadu_si128((const __m128i *)Vector);
		  hgCamera = (HGCamera *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		  if ( !this )
		    goto LABEL_53;
		  v76 = _mm_shuffle_ps(v75, v75, 85).m128_f32[0] - v75.m128_f32[0];
		  m_MaxExtent = v9->fields.m_MaxExtent;
		  v104.x = (float)(UnityEngine::Material::GetFloatImpl(
		                     (Material *)this,
		                     LODWORD(hgCamera->fields.mainViewConstants.viewMatrix.m31),
		                     0LL)
		                 * m_MaxExtent)
		         / v76;
		  v104.w = _mm_shuffle_ps(v75, v75, 170).m128_f32[0];
		  v104.y = COERCE_FLOAT(v75.m128_i32[0] ^ 0x80000000) / v76;
		  v104.z = _mm_shuffle_ps(v75, v75, 255).m128_f32[0] - v104.w;
		  dataCB->_MsFalloffRangeRemap = v104;
		  this = (VolumetricCloudSDF *)v9->fields.m_CloudMat;
		  hgCamera = (HGCamera *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		  if ( !this )
		    goto LABEL_53;
		  v77 = v9->fields.m_MaxExtent;
		  v78 = v77 / UnityEngine::Material::GetFloatImpl((Material *)this, HIDWORD(hgCamera->fields.camera), 0LL);
		  dataCB->_WindOffsetScale = v78;
		  dataCB->_InvWindOffsetScale = 1.0 / v78;
		  v79 = v9->fields.m_WindOffset.z;
		  *(_QWORD *)&v105.x = *(_QWORD *)&v9->fields.m_WindOffset.x;
		  v105.z = v79;
		  dataCB->_WindOffset = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
		                                                                    &v104,
		                                                                    (Vector3 *)&v105,
		                                                                    v80));
		  v81 = v9->fields.m_WindOffset2.z;
		  *(_QWORD *)&v105.x = *(_QWORD *)&v9->fields.m_WindOffset2.x;
		  v105.z = v81;
		  dataCB->_WindOffset2 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
		                                                                     &v104,
		                                                                     (Vector3 *)&v105,
		                                                                     v82));
		  v83 = v9->fields.m_WindOffset3.z;
		  *(_QWORD *)&v105.x = *(_QWORD *)&v9->fields.m_WindOffset3.x;
		  v105.z = v83;
		  dataCB->_WindOffset3 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
		                                                                     &v104,
		                                                                     (Vector3 *)&v105,
		                                                                     v84));
		  v85 = v9->fields.m_CloudMat;
		  envVolumeCameraComponent = HG::Rendering::Runtime::HGCamera::get_envVolumeCameraComponent(v8, 0LL);
		  if ( !envVolumeCameraComponent )
		    goto LABEL_53;
		  interpolatedPhase = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedPhase(
		                        envVolumeCameraComponent,
		                        0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		  updated = HG::Rendering::Runtime::VolumetricSDFUtils::UpdateMainLightDirection(
		              (Vector3 *)&v104,
		              v85,
		              interpolatedPhase,
		              0LL);
		  v89 = updated->z;
		  v90 = *(_QWORD *)&updated->x;
		  *(_QWORD *)&v9->fields.m_MainLightDirection.x = *(_QWORD *)&updated->x;
		  v9->fields.m_MainLightDirection.z = v89;
		  v105.z = v89;
		  *(_QWORD *)&v105.x = v90;
		  v92 = UnityEngine::Vector4::op_Implicit(&v104, (Vector3 *)&v105, v91);
		  *(_QWORD *)&v105.x = v19;
		  v93 = (Vector4)_mm_loadu_si128((const __m128i *)v92);
		  v105.z = z;
		  dataCB->_MainLightDirection = v93;
		  dataCB->_LocalRayOrigin = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
		                                                                        &v104,
		                                                                        (Vector3 *)&v105,
		                                                                        v94));
		  this = (VolumetricCloudSDF *)v9->fields.m_CloudMat;
		  hgCamera = (HGCamera *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		  if ( !this )
		    goto LABEL_53;
		  UnityEngine::Material::GetInt((Material *)this, LODWORD(hgCamera->fields.mainViewConstants.viewMatrix.m33), 0LL);
		  if ( !volumetricParameters )
		    goto LABEL_53;
		  HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		    volumetricParameters->fields.marchStepScale,
		    MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  v95 = sub_1832DBD50();
		  dataCB->_MarchStepNum = v95;
		  dataCB->_InvMarchStepNum = 1.0 / (float)v95;
		  this = (VolumetricCloudSDF *)v9->fields.m_CloudMat;
		  hgCamera = (HGCamera *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		  if ( !this )
		    goto LABEL_53;
		  UnityEngine::Material::GetInt(
		    (Material *)this,
		    LODWORD(hgCamera->fields.mainViewConstants.nonJitteredProjMatrix.m12),
		    0LL);
		  HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		    volumetricParameters->fields.godRayStepScale,
		    MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  v96 = sub_1832DBD50();
		  dataCB->_GodRayStepNum = v96;
		  v97 = (__m128)COERCE_UNSIGNED_INT((float)v96);
		  dataCB->_InvGodRayStepNum = 1.0 / v97.m128_f32[0];
		  v97.m128_f32[0] = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                      volumetricParameters->fields.dynamicStepRange,
		                      MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  v98 = v97;
		  v13.m128_f32[0] = 1.0
		                  / HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                      volumetricParameters->fields.dynamicStepRange,
		                      MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  dataCB->_DynamicStepRange = (Vector4)_mm_loadu_si128((const __m128i *)sub_183240A00(
		                                                                          &v104,
		                                                                          _mm_unpacklo_ps(v98, v13).m128_u64[0]));
		  dataCB->_DynamicStepScale = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                volumetricParameters->fields.dynamicStepScale,
		                                MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  hgCamera = (HGCamera *)v9->fields.m_CloudMat;
		  this = (VolumetricCloudSDF *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		  if ( !hgCamera )
		    goto LABEL_53;
		  v104 = *UnityEngine::Material::GetVector(&v104, (Material *)hgCamera, LODWORD(this->fields.m_WindOffset3.z), 0LL);
		  v112 = UnityEngine::Vector4::op_Implicit(&v104, v99);
		  v100 = (__m128)LODWORD(v112.x);
		  v101 = (__m128)LODWORD(v112.y);
		  if ( v112.x <= 0.0 )
		    v100 = 0LL;
		  if ( !HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModePanoramic(v9, volumetricParameters, 0LL)
		    && !HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeOctahedron(v9, volumetricParameters, 0LL)
		    && !HG::Rendering::Runtime::VolumetricCloudSDF::IsFarModeSemicircular(v9, volumetricParameters, 0LL) )
		  {
		    v101 = (__m128)0x461C4000u;
		  }
		  v102 = v9->fields.m_MaxExtent;
		  v100.m128_f32[0] = v100.m128_f32[0] / v102;
		  v101.m128_f32[0] = v101.m128_f32[0] / v102;
		  dataCB->_MarchRangeLocal = (Vector4)_mm_loadu_si128((const __m128i *)sub_183240A00(
		                                                                         &v104,
		                                                                         _mm_unpacklo_ps(v100, v101).m128_u64[0]));
		  this = (VolumetricCloudSDF *)v9->fields.m_WindFieldManager;
		  if ( !this
		    || (HG::Rendering::Runtime::VolumetricWindFieldManager::GetWindFieldCB(
		          (VolumetricWindFieldManager *)this,
		          renderContext,
		          (CBHandle *)&cbHandle.size,
		          (int32_t *)&cbHandle,
		          0LL),
		        dataCB->_WindFieldNum = cbHandle.bufferId,
		        v103 = v9->fields.m_propertyBlock,
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs),
		        hgCamera = (HGCamera *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields,
		        !v103) )
		  {
		LABEL_53:
		    sub_1800D8260(this, hgCamera);
		  }
		  UnityEngine::MaterialPropertyBlock::SetConstantBufferImpl0(
		    v103,
		    LODWORD(hgCamera->fields.mainViewConstants.invViewProjMatrix.m21),
		    cbHandle.size,
		    *((int32_t *)&cbHandle.size + 1),
		    (int32_t)cbHandle.ptr,
		    0LL);
		  dataCB->_OpticalDepthScale = v9->fields.m_OpticalDepthScale;
		  dataCB->_InvOpticalDepthScale = v9->fields.m_InvOpticalDepthScale;
		}
		
		protected override void CollectVolumetricRenderItemsImpl(HGCamera hgCamera, ScriptableRenderContext renderContext, HGVolumetricCloudSettingParameters volumetricParameters, List<VolumetricRenderer.VolumetricRenderItem> items) {} // 0x0000000189C47AF8-0x0000000189C47DF4
		// Void CollectVolumetricRenderItemsImpl(HGCamera, ScriptableRenderContext, HGVolumetricCloudSettingParameters, List`1[HG.Rendering.Runtime.VolumetricRenderer+VolumetricRenderItem])
		void HG::Rendering::Runtime::VolumetricCloudSDF::CollectVolumetricRenderItemsImpl(
		        VolumetricCloudSDF *this,
		        HGCamera *hgCamera,
		        ScriptableRenderContext renderContext,
		        HGVolumetricCloudSettingParameters *volumetricParameters,
		        List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderItem_ *items,
		        MethodInfo *method)
		{
		  __int64 v10; // rax
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  __int64 v15; // r14
		  HGRuntimeGrassQuery_Node *v16; // rdx
		  HGRuntimeGrassQuery_Node *v17; // r8
		  Int32__Array **v18; // r9
		  Object_1 *m_CloudMat; // rdi
		  Action_1_prXDGPaiLRznhHdqRYUShDUjqIyH_IYkFHeDTeaiIvMIzYRFbPiZVuQFL_ *v20; // rax
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v21; // rbx
		  HGRuntimeGrassQuery_Node *v22; // rdx
		  HGRuntimeGrassQuery_Node *v23; // r8
		  Int32__Array **v24; // r9
		  Mesh *CubeMesh; // rax
		  Mesh *v26; // rbx
		  Transform *transform; // rax
		  Material *v28; // rdi
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *CollectVolumetricRenderCallback; // rbx
		  int32_t renderQueue; // eax
		  MethodInfo *v31; // [rsp+20h] [rbp-E0h]
		  MethodInfo *v32; // [rsp+20h] [rbp-E0h]
		  MethodInfo *v33; // [rsp+20h] [rbp-E0h]
		  VolumetricRenderer_VolumetricBounds v34; // [rsp+70h] [rbp-90h] BYREF
		  VolumetricRenderer_VolumetricBounds v35; // [rsp+90h] [rbp-70h] BYREF
		  VolumetricRenderer_VolumetricRenderItem v36; // [rsp+B0h] [rbp-50h] BYREF
		  VolumetricRenderer_VolumetricRenderItem v37; // [rsp+110h] [rbp+10h] BYREF
		
		  *(_WORD *)(&v34.enableBounds + 1) = 0;
		  *(&v34.enableBounds + 3) = 0;
		  sub_18033B9D0(&v36, 0LL, 88LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(5119, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5119, 0LL);
		    if ( !Patch )
		      goto LABEL_17;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_617(
		      Patch,
		      (Object *)this,
		      (Object *)hgCamera,
		      renderContext,
		      (Object *)volumetricParameters,
		      (Object *)items,
		      0LL);
		  }
		  else
		  {
		    v10 = sub_18002C620(TypeInfo::HG::Rendering::Runtime::VolumetricCloudSDF::__c__DisplayClass99_0);
		    v15 = v10;
		    if ( !v10 )
		      goto LABEL_17;
		    *(_QWORD *)(v10 + 16) = this;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v10 + 16), v11, v13, v14, v31);
		    *(_QWORD *)(v15 + 24) = volumetricParameters;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v15 + 24), v16, v17, v18, v32);
		    m_CloudMat = (Object_1 *)this->fields.m_CloudMat;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Implicit(m_CloudMat, 0LL)
		      && HG::Rendering::Runtime::VolumetricCloudSDF::IsVisibleFromCamera(this, hgCamera, 0LL)
		      && this->fields.m_MaxExtent != 0.0 )
		    {
		      HG::Rendering::Runtime::VolumetricCloudSDF::UpdateParametersFromPipeline(
		        this,
		        hgCamera,
		        renderContext,
		        *(HGVolumetricCloudSettingParameters **)(v15 + 24),
		        0LL);
		      if ( !this->fields._._CollectVolumetricRenderCallback )
		      {
		        v20 = (Action_1_prXDGPaiLRznhHdqRYUShDUjqIyH_IYkFHeDTeaiIvMIzYRFbPiZVuQFL_ *)sub_18002C620(TypeInfo::System::Action<HG::Rendering::Runtime::VolumetricRenderer::VolumetricCallbackContext>);
		        v21 = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)v20;
		        if ( !v20 )
		          goto LABEL_17;
		        System::Action<prXDGPaiLRznhHdqRYUShDUjqIyH::IYkFHeDTeaiIvMIzYRFbPiZVuQFL>::Action(
		          v20,
		          (Object *)v15,
		          MethodInfo::HG::Rendering::Runtime::VolumetricCloudSDF::__c__DisplayClass99_0::_CollectVolumetricRenderItemsImpl_b__0,
		          0LL);
		        this->fields._._CollectVolumetricRenderCallback = v21;
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._._CollectVolumetricRenderCallback, v22, v23, v24, v33);
		      }
		      if ( !this->fields.m_DrawNear )
		        return;
		      v34.enableBounds = 0;
		      *(_QWORD *)&v35.worldBounds.m_Extents.x = 0LL;
		      memset(&v34.worldBounds, 0, sizeof(v34.worldBounds));
		      if ( !this->fields.m_inside )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		        CubeMesh = HG::Rendering::Runtime::VolumetricSDFUtils::get_CubeMesh(0LL);
		        Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_CloudObject;
		        v26 = CubeMesh;
		        if ( !Patch )
		          goto LABEL_17;
		        transform = UnityEngine::GameObject::get_transform((GameObject *)Patch, 0LL);
		        v34.enableBounds = 1;
		        v34.worldBounds = *HG::Rendering::Runtime::VolumetricSDFUtils::CalculateBounds(
		                             (Bounds *)&v35,
		                             v26,
		                             transform,
		                             0LL);
		      }
		      v28 = this->fields.m_CloudMat;
		      CollectVolumetricRenderCallback = this->fields._._CollectVolumetricRenderCallback;
		      Patch = (ILFixDynamicMethodWrapper_2 *)v28;
		      if ( v28 )
		      {
		        renderQueue = UnityEngine::Material::get_renderQueue(v28, 0LL);
		        v35 = v34;
		        HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem::VolumetricRenderItem(
		          &v36,
		          CollectVolumetricRenderCallback,
		          &v35,
		          v28,
		          1,
		          1,
		          0,
		          renderQueue,
		          99999.0,
		          0,
		          1,
		          0,
		          0LL);
		        Patch = (ILFixDynamicMethodWrapper_2 *)items;
		        v36.bFullScreen = this->fields.m_inside;
		        if ( items )
		        {
		          v37 = v36;
		          sub_1806811C8(
		            items,
		            &v37,
		            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricRenderer::VolumetricRenderItem>::Add);
		          return;
		        }
		      }
		LABEL_17:
		      sub_1800D8260(Patch, v11);
		    }
		  }
		}
		
		protected override void CollectVolumetricRenderItemsCPPImpl(HGCamera hgCamera, ScriptableRenderContext renderContext, HGVolumetricCloudSettingParameters volumetricParameters, List<HGVolumetricRenderItem> renderItems) {} // 0x00000001833995A0-0x00000001833996D0
		// Void CollectVolumetricRenderItemsCPPImpl(HGCamera, ScriptableRenderContext, HGVolumetricCloudSettingParameters, List`1[UnityEngine.HyperGryphEngineCode.HGVolumetricRenderItem])
		void HG::Rendering::Runtime::VolumetricCloudSDF::CollectVolumetricRenderItemsCPPImpl(
		        VolumetricCloudSDF *this,
		        HGCamera *hgCamera,
		        ScriptableRenderContext renderContext,
		        HGVolumetricCloudSettingParameters *volumetricParameters,
		        List_1_UnityEngine_HyperGryphEngineCode_HGVolumetricRenderItem_ *renderItems,
		        MethodInfo *method)
		{
		  GameObject *m_CloudObject; // rcx
		  __int64 v11; // rdx
		  struct Object_1__Class *v12; // rcx
		  Material *m_CloudMat; // rsi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Void *TempFromCSharp; // r12
		  bool IsFadeInFromCamera; // r14
		  int32_t InstanceID; // eax
		  Object_1 *v18; // rbx
		  Material *v19; // rax
		  void *m_CachedPtr; // rcx
		  Object_1 *CubeMesh; // rbx
		  Mesh *v22; // rax
		  void *v23; // rax
		  Transform *transform; // rax
		  Matrix4x4 *localToWorldMatrix; // rax
		  __int128 v26; // xmm1
		  __int128 v27; // xmm0
		  __int128 v28; // xmm1
		  MaterialPropertyBlock *m_propertyBlock; // rax
		  __int128 v30; // xmm0
		  float v31; // eax
		  Mesh *v32; // rax
		  Mesh *v33; // rbx
		  Transform *v34; // rax
		  int32_t renderQueue; // eax
		  float m_OpticalDepthScale; // xmm0_4
		  _BYTE v37[28]; // [rsp+48h] [rbp-B8h]
		  HGVolumetricRenderItem v38; // [rsp+70h] [rbp-90h] BYREF
		  Bounds v39; // [rsp+140h] [rbp+40h] BYREF
		  Matrix4x4 v40; // [rsp+158h] [rbp+58h] BYREF
		  HGVolumetricRenderItem v41; // [rsp+1A0h] [rbp+A0h] BYREF
		
		  m_CloudObject = (GameObject *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    m_CloudObject = (GameObject *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v11 = *(_QWORD *)m_CloudObject[7].fields._.m_CachedPtr;
		  if ( !v11 )
		    goto LABEL_14;
		  if ( *(int *)(v11 + 24) > 5124 )
		  {
		    if ( !LODWORD(m_CloudObject[9].monitor) )
		    {
		      il2cpp_runtime_class_init_1(m_CloudObject);
		      m_CloudObject = (GameObject *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    m_CloudObject = *(GameObject **)m_CloudObject[7].fields._.m_CachedPtr;
		    if ( !m_CloudObject )
		      goto LABEL_14;
		    if ( LODWORD(m_CloudObject[1].klass) <= 0x1404 )
		      sub_1800D2AB0(m_CloudObject, v11);
		    if ( m_CloudObject[1709].monitor )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(5124, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_617(
		          Patch,
		          (Object *)this,
		          (Object *)hgCamera,
		          renderContext,
		          (Object *)volumetricParameters,
		          (Object *)renderItems,
		          0LL);
		        return;
		      }
		      goto LABEL_14;
		    }
		  }
		  v12 = TypeInfo::UnityEngine::Object;
		  m_CloudMat = this->fields.m_CloudMat;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v12 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v12 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( m_CloudMat )
		  {
		    if ( !v12->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v12);
		    if ( m_CloudMat->fields._.m_CachedPtr )
		    {
		      if ( HG::Rendering::Runtime::VolumetricCloudSDF::IsVisibleFromCamera(this, hgCamera, 0LL)
		        && this->fields.m_MaxExtent != 0.0 )
		      {
		        TempFromCSharp = (Void *)UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::AllocateTempFromCSharp(
		                                   1008LL,
		                                   0LL);
		        Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemSet(TempFromCSharp, 0, 1008LL, 0LL);
		        HG::Rendering::Runtime::VolumetricCloudSDF::UpdateParametersFromPipelineCPP(
		          this,
		          hgCamera,
		          renderContext,
		          volumetricParameters,
		          (HGVolumetricCloudDataCB *)TempFromCSharp,
		          0LL);
		        IsFadeInFromCamera = HG::Rendering::Runtime::VolumetricCloudSDF::IsFadeInFromCamera(this, hgCamera, 0LL);
		        if ( this->fields.m_DrawNear )
		        {
		          sub_18033B9D0(&v38, 0LL, 208LL);
		          InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)this, 0LL);
		          v18 = (Object_1 *)this->fields.m_CloudMat;
		          v38.id = InstanceID;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          if ( UnityEngine::Object::op_Implicit(v18, 0LL) )
		          {
		            v19 = this->fields.m_CloudMat;
		            if ( !v19 )
		              goto LABEL_14;
		            m_CachedPtr = v19->fields._.m_CachedPtr;
		          }
		          else
		          {
		            m_CachedPtr = 0LL;
		          }
		          v38.material = m_CachedPtr;
		          *(_QWORD *)&v38.passIndex = 0LL;
		          if ( !TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		          CubeMesh = (Object_1 *)HG::Rendering::Runtime::VolumetricSDFUtils::get_CubeMesh(0LL);
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          if ( UnityEngine::Object::op_Implicit(CubeMesh, 0LL) )
		          {
		            if ( !TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		            v22 = HG::Rendering::Runtime::VolumetricSDFUtils::get_CubeMesh(0LL);
		            if ( !v22 )
		              goto LABEL_14;
		            v23 = v22->fields._.m_CachedPtr;
		          }
		          else
		          {
		            v23 = 0LL;
		          }
		          m_CloudObject = this->fields.m_CloudObject;
		          v38.mesh = v23;
		          if ( !m_CloudObject )
		            goto LABEL_14;
		          transform = UnityEngine::GameObject::get_transform(m_CloudObject, 0LL);
		          if ( !transform )
		            goto LABEL_14;
		          localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(&v40, transform, 0LL);
		          v26 = *(_OWORD *)&localToWorldMatrix->m01;
		          *(_OWORD *)&v38.localToWorldMatrix.m00 = *(_OWORD *)&localToWorldMatrix->m00;
		          v27 = *(_OWORD *)&localToWorldMatrix->m02;
		          *(_OWORD *)&v38.localToWorldMatrix.m01 = v26;
		          v28 = *(_OWORD *)&localToWorldMatrix->m03;
		          m_propertyBlock = this->fields.m_propertyBlock;
		          *(_OWORD *)&v38.localToWorldMatrix.m02 = v27;
		          *(_OWORD *)&v38.localToWorldMatrix.m03 = v28;
		          if ( !m_propertyBlock )
		            goto LABEL_14;
		          v30 = 0LL;
		          v38.propertySheet = m_propertyBlock->fields.m_Ptr;
		          v31 = 0.0;
		          *(_DWORD *)v37 = 0;
		          *(_QWORD *)&v37[16] = 0LL;
		          if ( !this->fields.m_inside )
		          {
		            v37[0] = 1;
		            if ( !TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		            v32 = HG::Rendering::Runtime::VolumetricSDFUtils::get_CubeMesh(0LL);
		            m_CloudObject = this->fields.m_CloudObject;
		            v33 = v32;
		            if ( !m_CloudObject )
		              goto LABEL_14;
		            v34 = UnityEngine::GameObject::get_transform(m_CloudObject, 0LL);
		            *(Bounds *)&v37[4] = *HG::Rendering::Runtime::VolumetricSDFUtils::CalculateBounds(&v39, v33, v34, 0LL);
		            v30 = *(_OWORD *)v37;
		            v31 = *(float *)&v37[24];
		          }
		          m_CloudObject = (GameObject *)this->fields.m_CloudMat;
		          v38.bounds.worldBounds.m_Extents.z = v31;
		          *(_WORD *)&v38.enableFraming = 257;
		          v38.sortingOrder = 0;
		          *(_OWORD *)&v38.bounds.enableBounds = v30;
		          *(_QWORD *)&v38.bounds.worldBounds.m_Extents.x = *(_QWORD *)&v37[16];
		          if ( m_CloudObject )
		          {
		            renderQueue = UnityEngine::Material::get_renderQueue((Material *)m_CloudObject, 0LL);
		            m_CloudObject = (GameObject *)renderItems;
		            m_OpticalDepthScale = this->fields.m_OpticalDepthScale;
		            v38.renderQueue = renderQueue;
		            v38.fullScreen = this->fields.m_inside;
		            v38.msBakeSize = *(Vector2Int *)&this->fields.m_msBakeSizeX;
		            v38.drawFarCloud = this->fields.m_DrawFar;
		            v38.opticalDepthScale = m_OpticalDepthScale;
		            *(_QWORD *)&v38.distToCamera = 1203982208LL;
		            v38.pureBlit = 1;
		            v38.volumeFadeIn = IsFadeInFromCamera;
		            v38.cloudDataCB = TempFromCSharp;
		            if ( renderItems )
		            {
		              v41 = v38;
		              System::Collections::Generic::List<UnityEngine::HyperGryphEngineCode::HGVolumetricRenderItem>::Add(
		                renderItems,
		                &v41,
		                MethodInfo::System::Collections::Generic::List<UnityEngine::HyperGryphEngineCode::HGVolumetricRenderItem>::Add);
		              return;
		            }
		          }
		LABEL_14:
		          sub_1800D8260(m_CloudObject, v11);
		        }
		      }
		    }
		  }
		}
		
		public override void OnUpdateVolumetricMaterial(CommandBuffer cmd, ScriptableRenderContext renderContext, Material material, MaterialPropertyBlock propertyBlock) {} // 0x0000000189C488B8-0x0000000189C48E18
		// Void OnUpdateVolumetricMaterial(CommandBuffer, ScriptableRenderContext, Material, MaterialPropertyBlock)
		void HG::Rendering::Runtime::VolumetricCloudSDF::OnUpdateVolumetricMaterial(
		        VolumetricCloudSDF *this,
		        CommandBuffer *cmd,
		        ScriptableRenderContext renderContext,
		        Material *material,
		        MaterialPropertyBlock *propertyBlock,
		        MethodInfo *method)
		{
		  Object_1 *m_CloudMat; // rdi
		  Material *v11; // rdi
		  void *Patch; // rcx
		  void *static_fields; // rdx
		  Material *v14; // rbx
		  MethodInfo *v15; // r8
		  Vector4 *v16; // rax
		  int32_t v17; // r10d
		  int32_t WindLerpDistance; // ebx
		  Vector4 *Vector; // rax
		  MethodInfo *v20; // r8
		  int32_t v21; // r10d
		  MethodInfo *v22; // r8
		  int32_t v23; // r10d
		  MethodInfo *v24; // r8
		  float m_MaxExtent; // xmm6_4
		  Material *v26; // rdi
		  float v27; // xmm6_4
		  MethodInfo *v28; // r8
		  int32_t v29; // r10d
		  __int128 v30; // xmm1
		  VolumetricShaderIDs__StaticFields *v31; // rcx
		  __int128 v32; // xmm0
		  __int128 v33; // xmm1
		  int32_t BoxWorldToLocal; // edx
		  Vector4 v35; // [rsp+48h] [rbp-59h] BYREF
		  int32_t count; // [rsp+58h] [rbp-49h] BYREF
		  Vector4 v37; // [rsp+60h] [rbp-41h] BYREF
		  CBHandle cbHandle; // [rsp+70h] [rbp-31h] BYREF
		  Matrix4x4 v39; // [rsp+88h] [rbp-19h] BYREF
		
		  count = 0;
		  memset(&cbHandle, 0, sizeof(cbHandle));
		  if ( IFix::WrappersManagerImpl::IsPatched(5125, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5125, 0LL);
		    if ( !Patch )
		      goto LABEL_18;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_617(
		      (ILFixDynamicMethodWrapper_2 *)Patch,
		      (Object *)this,
		      (Object *)cmd,
		      renderContext,
		      (Object *)material,
		      (Object *)propertyBlock,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		    HG::Rendering::Runtime::VolumetricSDFUtils::SetEncodedTexture(propertyBlock, (String *)"_WindFieldTex", 0LL, 0LL);
		    m_CloudMat = (Object_1 *)this->fields.m_CloudMat;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Implicit(m_CloudMat, 0LL) )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Implicit((Object_1 *)material, 0LL) )
		      {
		        v11 = this->fields.m_CloudMat;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		        static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields;
		        if ( !v11 )
		          goto LABEL_18;
		        if ( !UnityEngine::Material::IsKeywordEnabled(v11, *((String **)static_fields + 14), 0LL) )
		        {
		          v14 = this->fields.m_CloudMat;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		          static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields;
		          if ( v14 )
		          {
		            if ( UnityEngine::Material::IsKeywordEnabled(v14, *((String **)static_fields + 15), 0LL) )
		            {
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		              HG::Rendering::Runtime::VolumetricSDFUtils::SetVolumetricMaterialMVMode(cmd, material, 2, 0LL);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		              Patch = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
		              static_fields = this->fields.m_CloudMat;
		              WindLerpDistance = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WindLerpDistance;
		              if ( static_fields )
		              {
		                Vector = UnityEngine::Material::GetVector(&v37, (Material *)static_fields, WindLerpDistance, 0LL);
		                if ( propertyBlock )
		                {
		                  v35 = *Vector;
		                  UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, WindLerpDistance, &v35, 0LL);
		                  *(_QWORD *)&v35.x = *(_QWORD *)&this->fields.m_WindOffset.x;
		                  v35.z = this->fields.m_WindOffset.z;
		                  v35 = *UnityEngine::Vector4::op_Implicit(&v37, (Vector3 *)&v35, v20);
		                  UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v21, &v35, 0LL);
		                  *(_QWORD *)&v35.x = *(_QWORD *)&this->fields.m_WindOffset2.x;
		                  v35.z = this->fields.m_WindOffset2.z;
		                  v35 = *UnityEngine::Vector4::op_Implicit(&v37, (Vector3 *)&v35, v22);
		                  UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v23, &v35, 0LL);
		                  *(_QWORD *)&v35.x = *(_QWORD *)&this->fields.m_WindOffset3.x;
		                  v35.z = this->fields.m_WindOffset3.z;
		                  v16 = UnityEngine::Vector4::op_Implicit(&v37, (Vector3 *)&v35, v24);
		                  goto LABEL_9;
		                }
		              }
		            }
		            else
		            {
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		              HG::Rendering::Runtime::VolumetricSDFUtils::SetVolumetricMaterialMVMode(cmd, material, 1, 0LL);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		              *(_QWORD *)&v35.x = *(_QWORD *)&this->fields.m_WindOffset.x;
		              v35.z = this->fields.m_WindOffset.z;
		              v16 = UnityEngine::Vector4::op_Implicit(&v37, (Vector3 *)&v35, v15);
		              if ( propertyBlock )
		              {
		LABEL_9:
		                v35 = *v16;
		                UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v17, &v35, 0LL);
		                return;
		              }
		            }
		          }
		LABEL_18:
		          sub_1800D8260(Patch, static_fields);
		        }
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		        HG::Rendering::Runtime::VolumetricSDFUtils::SetVolumetricMaterialMVMode(cmd, material, 3, 0LL);
		        HG::Rendering::Runtime::VolumetricSDFUtils::SetEncodedTexture(
		          propertyBlock,
		          (String *)"_WindFieldTex",
		          this->fields.AdvancedTextureToUse,
		          0LL);
		        m_MaxExtent = this->fields.m_MaxExtent;
		        v26 = this->fields.m_CloudMat;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		        static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		        if ( !v26 )
		          goto LABEL_18;
		        v27 = m_MaxExtent / UnityEngine::Material::GetFloatImpl(v26, *((_DWORD *)static_fields + 25), 0LL);
		        Patch = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		        if ( !propertyBlock )
		          goto LABEL_18;
		        UnityEngine::MaterialPropertyBlock::SetFloatImpl(propertyBlock, *((_DWORD *)Patch + 150), v27, 0LL);
		        UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		          propertyBlock,
		          TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InvWindOffsetScale,
		          1.0 / v27,
		          0LL);
		        *(_QWORD *)&v35.x = *(_QWORD *)&this->fields.m_InvScale.x;
		        v35.z = this->fields.m_InvScale.z;
		        v35 = *UnityEngine::Vector4::op_Implicit(&v37, (Vector3 *)&v35, v28);
		        UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v29, &v35, 0LL);
		        v30 = *(_OWORD *)&this->fields.m_CloudRenderWorldToLocal.m01;
		        *(_OWORD *)&v39.m00 = *(_OWORD *)&this->fields.m_CloudRenderWorldToLocal.m00;
		        v31 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		        v32 = *(_OWORD *)&this->fields.m_CloudRenderWorldToLocal.m02;
		        *(_OWORD *)&v39.m01 = v30;
		        v33 = *(_OWORD *)&this->fields.m_CloudRenderWorldToLocal.m03;
		        BoxWorldToLocal = v31->_BoxWorldToLocal;
		        *(_OWORD *)&v39.m02 = v32;
		        *(_OWORD *)&v39.m03 = v33;
		        UnityEngine::MaterialPropertyBlock::SetMatrix(propertyBlock, BoxWorldToLocal, &v39, 0LL);
		        Patch = this->fields.m_WindFieldManager;
		        if ( !Patch )
		          goto LABEL_18;
		        HG::Rendering::Runtime::VolumetricWindFieldManager::GetWindFieldCB(
		          (VolumetricWindFieldManager *)Patch,
		          renderContext,
		          &cbHandle,
		          &count,
		          0LL);
		        UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		          propertyBlock,
		          TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WindFieldNum,
		          (float)count,
		          0LL);
		        UnityEngine::MaterialPropertyBlock::SetConstantBufferImpl0(
		          propertyBlock,
		          TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WindFieldDataCB,
		          cbHandle.bufferId,
		          cbHandle.offset,
		          cbHandle.size,
		          0LL);
		      }
		    }
		  }
		}
		
		public void __iFixBaseProxy_PrepareVolumetricRenderingImpl(ref VolumetricRenderInputs P0) {} // 0x0000000189C49870-0x0000000189C49878
		// Void <>iFixBaseProxy_PrepareVolumetricRenderingImpl(VolumetricRenderInputs ByRef)
		void HG::Rendering::Runtime::VolumetricCloudSDF::__iFixBaseProxy_PrepareVolumetricRenderingImpl(
		        VolumetricCloudSDF *this,
		        VolumetricRenderInputs *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::VolumetricRenderObject::PrepareVolumetricRenderingImpl(
		    (VolumetricRenderObject *)this,
		    P0,
		    0LL);
		}
		
		public bool __iFixBaseProxy_get_HasVolumetricRenderItem() => default; // 0x0000000189C49878-0x0000000189C49880
		// Boolean <>iFixBaseProxy_get_HasVolumetricRenderItem()
		bool HG::Rendering::Runtime::VolumetricCloudSDF::__iFixBaseProxy_get_HasVolumetricRenderItem(
		        VolumetricCloudSDF *this,
		        MethodInfo *method)
		{
		  return HG::Rendering::Runtime::VolumetricRenderObject::get_HasVolumetricRenderItem(
		           (VolumetricRenderObject *)this,
		           0LL);
		}
		
		public bool __iFixBaseProxy_OverrideFramingCompose(VolumetricRenderer.VolumetricComposeContext P0, out VolumetricRenderer.VolumetricRenderItem P1) {
			P1 = default;
			return default;
		} // 0x0000000189C49818-0x0000000189C49844
		// Boolean <>iFixBaseProxy_OverrideFramingCompose(VolumetricRenderer+VolumetricComposeContext, VolumetricRenderer+VolumetricRenderItem ByRef)
		bool HG::Rendering::Runtime::VolumetricCloudSDF::__iFixBaseProxy_OverrideFramingCompose(
		        VolumetricCloudSDF *this,
		        VolumetricRenderer_VolumetricComposeContext *P0,
		        VolumetricRenderer_VolumetricRenderItem *P1,
		        MethodInfo *method)
		{
		  HGVolumetricCloudSettingParameters *volumetricSettings; // xmm1_8
		  VolumetricRenderer_VolumetricComposeContext v6; // [rsp+20h] [rbp-28h] BYREF
		
		  volumetricSettings = P0->volumetricSettings;
		  *(_OWORD *)&v6.bEnableFraming = *(_OWORD *)&P0->bEnableFraming;
		  v6.volumetricSettings = volumetricSettings;
		  return HG::Rendering::Runtime::VolumetricRenderObject::OverrideFramingCompose(
		           (VolumetricRenderObject *)this,
		           &v6,
		           P1,
		           0LL);
		}
		
		public bool __iFixBaseProxy_OverrideTemporalCompose(VolumetricRenderer.VolumetricComposeContext P0, out VolumetricRenderer.VolumetricRenderItem P1) {
			P1 = default;
			return default;
		} // 0x0000000189C49844-0x0000000189C49870
		// Boolean <>iFixBaseProxy_OverrideTemporalCompose(VolumetricRenderer+VolumetricComposeContext, VolumetricRenderer+VolumetricRenderItem ByRef)
		bool HG::Rendering::Runtime::VolumetricCloudSDF::__iFixBaseProxy_OverrideTemporalCompose(
		        VolumetricCloudSDF *this,
		        VolumetricRenderer_VolumetricComposeContext *P0,
		        VolumetricRenderer_VolumetricRenderItem *P1,
		        MethodInfo *method)
		{
		  HGVolumetricCloudSettingParameters *volumetricSettings; // xmm1_8
		  VolumetricRenderer_VolumetricComposeContext v6; // [rsp+20h] [rbp-28h] BYREF
		
		  volumetricSettings = P0->volumetricSettings;
		  *(_OWORD *)&v6.bEnableFraming = *(_OWORD *)&P0->bEnableFraming;
		  v6.volumetricSettings = volumetricSettings;
		  return HG::Rendering::Runtime::VolumetricRenderObject::OverrideTemporalCompose(
		           (VolumetricRenderObject *)this,
		           &v6,
		           P1,
		           0LL);
		}
		
		public void __iFixBaseProxy_CollectVolumetricRenderItemsImpl(HGCamera P0, ScriptableRenderContext P1, HGVolumetricCloudSettingParameters P2, List<VolumetricRenderer.VolumetricRenderItem> P3) {} // 0x0000000189C497F8-0x0000000189C49808
		// Void <>iFixBaseProxy_CollectVolumetricRenderItemsImpl(HGCamera, ScriptableRenderContext, HGVolumetricCloudSettingParameters, List`1[HG.Rendering.Runtime.VolumetricRenderer+VolumetricRenderItem])
		void HG::Rendering::Runtime::VolumetricCloudSDF::__iFixBaseProxy_CollectVolumetricRenderItemsImpl(
		        VolumetricCloudSDF *this,
		        HGCamera *P0,
		        ScriptableRenderContext P1,
		        HGVolumetricCloudSettingParameters *P2,
		        List_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricRenderItem_ *P3,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::VolumetricRenderObject::CollectVolumetricRenderItemsImpl(
		    (VolumetricRenderObject *)this,
		    P0,
		    P1,
		    P2,
		    P3,
		    0LL);
		}
		
		public void __iFixBaseProxy_CollectVolumetricRenderItemsCPPImpl(HGCamera P0, ScriptableRenderContext P1, HGVolumetricCloudSettingParameters P2, List<HGVolumetricRenderItem> P3) {} // 0x0000000189C497E8-0x0000000189C497F8
		// Void <>iFixBaseProxy_CollectVolumetricRenderItemsCPPImpl(HGCamera, ScriptableRenderContext, HGVolumetricCloudSettingParameters, List`1[UnityEngine.HyperGryphEngineCode.HGVolumetricRenderItem])
		void HG::Rendering::Runtime::VolumetricCloudSDF::__iFixBaseProxy_CollectVolumetricRenderItemsCPPImpl(
		        VolumetricCloudSDF *this,
		        HGCamera *P0,
		        ScriptableRenderContext P1,
		        HGVolumetricCloudSettingParameters *P2,
		        List_1_UnityEngine_HyperGryphEngineCode_HGVolumetricRenderItem_ *P3,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::VolumetricRenderObject::CollectVolumetricRenderItemsCPPImpl(
		    (VolumetricRenderObject *)this,
		    P0,
		    P1,
		    P2,
		    P3,
		    0LL);
		}
		
		public void __iFixBaseProxy_OnUpdateVolumetricMaterial(CommandBuffer P0, ScriptableRenderContext P1, Material P2, MaterialPropertyBlock P3) {} // 0x0000000189C49808-0x0000000189C49818
		// Void <>iFixBaseProxy_OnUpdateVolumetricMaterial(CommandBuffer, ScriptableRenderContext, Material, MaterialPropertyBlock)
		void HG::Rendering::Runtime::VolumetricCloudSDF::__iFixBaseProxy_OnUpdateVolumetricMaterial(
		        VolumetricCloudSDF *this,
		        CommandBuffer *P0,
		        ScriptableRenderContext P1,
		        Material *P2,
		        MaterialPropertyBlock *P3,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::VolumetricRenderObject::OnUpdateVolumetricMaterial(
		    (VolumetricRenderObject *)this,
		    P0,
		    P1,
		    P2,
		    P3,
		    0LL);
		}
		
	}
}
