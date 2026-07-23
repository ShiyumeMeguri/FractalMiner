using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class ReflectionProbeBinningPassConstructor : IPassConstructor // TypeDefIndex: 37812
	{
		// Fields
		public const int MAX_VISIBLE_COUNT = 32; // Metadata: 0x0230315F
		public const int OCT_TEXTURE_PADDING = 32; // Metadata: 0x02303160
		public const float SLICE_Z_LENGTH = 1f; // Metadata: 0x02303161
		public const int XYPLANE_BINNING_GROUP_SIZE = 8; // Metadata: 0x02303165
		public const int ZPLANE_BINING_GROUP_SIZE = 64; // Metadata: 0x02303166
		public const int NUM_FLOAT4_REFLECTION_PROBE_PARAMS = 4; // Metadata: 0x02303168
		public const int NUM_FLOAT4_REFLECTION_PROBE_BINNING_DATA = 4; // Metadata: 0x02303169
		public const int NUM_FLOAT4_REFLECTION_PROBE_BINNING_BUFFER = 132; // Metadata: 0x0230316A
		public const int NUM_BYTES_REFLECTION_PROBE_BINNING_BUFFER = 2112; // Metadata: 0x0230316C
		public const int NUM_FLOAT4_REFLECTION_PROBE_GLOBAL_DATA = 8; // Metadata: 0x0230316E
		public const int NUM_FLOAT4_REFLECTION_PROBE_GLOBAL_BUFFER = 260; // Metadata: 0x0230316F
		public const int NUM_BYTES_REFLECTION_PROBE_GLOBAL_BUFFER = 4160; // Metadata: 0x02303171
		public Matrix4x4 unitExtents; // 0x10
		private bool m_clearDefault; // 0x50
		private Vector3 m_prevCameraPosition; // 0x54
		private RTHandle m_octTextureArray; // 0x60
		private int[] m_blitIndices; // 0x68
		private Texture[] m_blitTextures; // 0x70
		private List<OctNode> m_previousOctNode; // 0x78
		private List<OctNode> m_currrentOctNode; // 0x80
		private static readonly RenderFunc<PassData> s_RenderFunc; // 0x00
	
		// Nested types
		private struct OctNode // TypeDefIndex: 37806
		{
			// Fields
			public Cubemap texutre; // 0x00
			public float factor; // 0x08
	
			// Methods
			public bool diff(OctNode other) => default; // 0x0000000189D0FE54-0x0000000189D0FF00
			// Boolean diff(ReflectionProbeBinningPassConstructor+OctNode)
			bool HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode::diff(
			        ReflectionProbeBinningPassConstructor_OctNode *this,
			        ReflectionProbeBinningPassConstructor_OctNode *other,
			        MethodInfo *method)
			{
			  __int64 v5; // rdx
			  Object_1 *texutre; // rcx
			  int32_t InstanceID; // eax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  ReflectionProbeBinningPassConstructor_OctNode v10; // [rsp+20h] [rbp-18h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(2030, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(2030, 0LL);
			    if ( Patch )
			    {
			      v10 = *other;
			      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_811(Patch, this, &v10, 0LL);
			    }
			LABEL_8:
			    sub_1800D8260(texutre, v5);
			  }
			  texutre = (Object_1 *)this->texutre;
			  if ( !this->texutre )
			    goto LABEL_8;
			  InstanceID = UnityEngine::Object::GetInstanceID(texutre, 0LL);
			  texutre = (Object_1 *)other->texutre;
			  if ( !other->texutre )
			    goto LABEL_8;
			  return InstanceID != UnityEngine::Object::GetInstanceID(texutre, 0LL)
			      || fabs(this->factor - other->factor) >= 0.0099999998;
			}
			
		}
	
		internal struct PassInput // TypeDefIndex: 37807
		{
			// Fields
			internal ScriptableRenderContext srpContext; // 0x00
			internal BinningPass.BinningData binningData; // 0x08
			internal ComputeBufferHandle binningBuffer; // 0x24
			internal HGSettingParameters settingParameters; // 0x30
		}
	
		internal struct PassOutput // TypeDefIndex: 37808
		{
		}
	
		private class PassData // TypeDefIndex: 37809
		{
			// Fields
			public int xyBinningThreadGroupX; // 0x10
			public int xyBinningThreadGroupY; // 0x14
			public int xyBinningThreadGroupZ; // 0x18
			public int zBinningThreadGroupX; // 0x1C
			public int zBinningThreadGroupY; // 0x20
			public int zBinningThreadGroupZ; // 0x24
			public CBHandle reflectionProbeBinningInputDatasCB; // 0x28
			public CBHandle reflectionProbeGlobalDatasCB; // 0x40
			public ComputeBufferHandle binningBuffer; // 0x58
			public ComputeShader computeShader; // 0x60
			public int octTextureSize; // 0x68
			public bool clearDefault; // 0x6C
			public bool renderBlend; // 0x6D
			public List<OctNode> currrentOctNode; // 0x70
			public int blitCount; // 0x78
			public int[] blitIndices; // 0x80
			public Texture[] blitTextures; // 0x88
			public TextureHandle octTextureArray; // 0x90
	
			// Constructors
			public PassData() {} // 0x00000001841E1670-0x00000001841E1680
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
			
		}
	
		private struct ReflectionProbeBlendData // TypeDefIndex: 37810
		{
			// Fields
			public Vector4 param0; // 0x00
			public Vector4 param1; // 0x10
			public Vector4 param2; // 0x20
			public Vector4 param3; // 0x30
		}
	
		// Constructors
		internal ReflectionProbeBinningPassConstructor() {} // 0x000000018402F860-0x000000018402F9E0
		// ReflectionProbeBinningPassConstructor()
		void HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::ReflectionProbeBinningPassConstructor(
		        ReflectionProbeBinningPassConstructor *this,
		        MethodInfo *method)
		{
		  __int128 v3; // xmm1
		  __int128 v4; // xmm0
		  __int128 v5; // xmm1
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  HGRuntimeGrassQuery_Node *v9; // rdx
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  LowLevelList_1_System_Object_ *v12; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  List_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *v15; // rdi
		  HGRuntimeGrassQuery_Node *v16; // rdx
		  HGRuntimeGrassQuery_Node *v17; // r8
		  Int32__Array **v18; // r9
		  LowLevelList_1_System_Object_ *v19; // rax
		  List_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *v20; // rdi
		  HGRuntimeGrassQuery_Node *v21; // rdx
		  HGRuntimeGrassQuery_Node *v22; // r8
		  Int32__Array **v23; // r9
		  MethodInfo *v24; // [rsp+20h] [rbp-98h]
		  MethodInfo *v25; // [rsp+20h] [rbp-98h]
		  MethodInfo *v26; // [rsp+20h] [rbp-98h]
		  __m128i v27; // [rsp+30h] [rbp-88h] BYREF
		  __m128i si128; // [rsp+40h] [rbp-78h] BYREF
		  __m128i v29; // [rsp+50h] [rbp-68h] BYREF
		  __m128i v30; // [rsp+60h] [rbp-58h] BYREF
		  Matrix4x4 v31; // [rsp+70h] [rbp-48h] BYREF
		  MethodInfo *v32; // [rsp+E0h] [rbp+28h]
		
		  si128 = _mm_load_si128((const __m128i *)&xmmword_18B959550);
		  memset(&v31, 0, sizeof(v31));
		  v27 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		  v29 = _mm_load_si128((const __m128i *)&xmmword_18B959930);
		  v30 = _mm_load_si128((const __m128i *)&xmmword_18B959950);
		  UnityEngine::Matrix4x4::Matrix4x4(&v31, (Vector4 *)&v30, (Vector4 *)&v29, (Vector4 *)&si128, (Vector4 *)&v27, 0LL);
		  v3 = *(_OWORD *)&v31.m01;
		  *(_OWORD *)&this->fields.unitExtents.m00 = *(_OWORD *)&v31.m00;
		  v4 = *(_OWORD *)&v31.m02;
		  *(_OWORD *)&this->fields.unitExtents.m01 = v3;
		  v5 = *(_OWORD *)&v31.m03;
		  *(_OWORD *)&this->fields.unitExtents.m02 = v4;
		  *(_OWORD *)&this->fields.unitExtents.m03 = v5;
		  *(_QWORD *)&this->fields.m_prevCameraPosition.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  this->fields.m_prevCameraPosition.z = 0.0;
		  this->fields.m_blitIndices = (Int32__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Int32, 32LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_blitIndices, v6, v7, v8, v24);
		  this->fields.m_blitTextures = (Texture__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Texture, 32LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_blitTextures, v9, v10, v11, v25);
		  v12 = (LowLevelList_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>);
		  v15 = (List_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *)v12;
		  if ( !v12
		    || (System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		          v12,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::List),
		        this->fields.m_previousOctNode = v15,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_previousOctNode, v16, v17, v18, v26),
		        v19 = (LowLevelList_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>),
		        (v20 = (List_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *)v19) == 0LL) )
		  {
		    sub_1800D8260(v14, v13);
		  }
		  System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		    v19,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::List);
		  this->fields.m_currrentOctNode = v20;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_currrentOctNode, v21, v22, v23, v32);
		}
		
		static ReflectionProbeBinningPassConstructor() {} // 0x0000000184D2C850-0x0000000184D2C8E0
		// ReflectionProbeBinningPassConstructor()
		void HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::cctor(MethodInfo *method)
		{
		  struct ReflectionProbeBinningPassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_PassData_ *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::PassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_PassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::__c::__cctor_b__35_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor->static_fields->s_RenderFunc = v6;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor->static_fields,
		    v7,
		    v8,
		    v9,
		    v10);
		}
		
	
		// Methods
		private void PrepareGlobalReflectionProbe(PassData passData, HGCamera hgCamera) {} // 0x0000000189D10CB4-0x0000000189D11078
		// Void PrepareGlobalReflectionProbe(ReflectionProbeBinningPassConstructor+PassData, HGCamera)
		void HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::PrepareGlobalReflectionProbe(
		        ReflectionProbeBinningPassConstructor *this,
		        ReflectionProbeBinningPassConstructor_PassData *passData,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *InterpolatedVolumes; // r14
		  List_1_System_Single_ *InterpolatedVolumesFactor; // rax
		  List_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *v9; // rdx
		  List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *m_currrentOctNode; // rcx
		  List_1_System_Single_ *v11; // r13
		  int32_t v12; // esi
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  Object *Item; // rax
		  __int64 v16; // r15
		  bool active; // r12
		  Object *v18; // rax
		  __int64 v19; // rax
		  Object_1 *v20; // r15
		  HGRuntimeGrassQuery_Node *v21; // r8
		  Int32__Array **v22; // r9
		  List_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *v23; // rax
		  List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *v24; // r12
		  List_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *m_previousOctNode; // rax
		  List_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *v26; // rax
		  int32_t i; // esi
		  List_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *v28; // rax
		  List_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *v29; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *methoda; // [rsp+20h] [rbp-60h]
		  HGRuntimeGrassQuery_Node v32; // [rsp+30h] [rbp-50h] BYREF
		
		  *(_OWORD *)&v32.klass = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(2029, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    InterpolatedVolumes = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedVolumes(hgCamera, 0LL);
		    InterpolatedVolumesFactor = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedVolumesFactor(
		                                  hgCamera,
		                                  0LL);
		    m_currrentOctNode = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)this->fields.m_currrentOctNode;
		    v11 = InterpolatedVolumesFactor;
		    if ( !m_currrentOctNode )
		      goto LABEL_44;
		    System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
		      m_currrentOctNode,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::Clear);
		    v12 = 0;
		    if ( !InterpolatedVolumes )
		      goto LABEL_44;
		    while ( v12 < Beyond::UniqueList<System::Object>::get_length(
		                    (UniqueList_1_System_Object_ *)InterpolatedVolumes,
		                    MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::get_Count) )
		    {
		      Item = Beyond::IndexedHashSet<System::Object>::get_Item(
		               (IndexedHashSet_1_System_Object_ *)InterpolatedVolumes,
		               v12,
		               MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::get_Item);
		      if ( !Item )
		        goto LABEL_44;
		      v16 = sub_18008B570(m_currrentOctNode, Item);
		      if ( !v16 )
		        goto LABEL_44;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGSkyConfig);
		      active = HG::Rendering::Runtime::HGSkyConfig::get_active((HGSkyConfig *)(v16 + 400), 0LL);
		      v18 = Beyond::IndexedHashSet<System::Object>::get_Item(
		              (IndexedHashSet_1_System_Object_ *)InterpolatedVolumes,
		              v12,
		              MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::get_Item);
		      if ( !v18 )
		        goto LABEL_44;
		      v19 = sub_18008B570(m_currrentOctNode, v18);
		      if ( !v19 )
		        goto LABEL_44;
		      v20 = *(Object_1 **)(v19 + 608);
		      if ( active )
		      {
		        sub_1800036A0(TypeInfo::UnityEngine::Object);
		        if ( UnityEngine::Object::op_Inequality(v20, 0LL, 0LL) )
		        {
		          if ( !v11 )
		            goto LABEL_44;
		          if ( System::Collections::Generic::List<float>::get_Item(
		                 v11,
		                 v12,
		                 MethodInfo::System::Collections::Generic::List<float>::get_Item) >= 0.99989998 )
		          {
		            m_currrentOctNode = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)this->fields.m_currrentOctNode;
		            if ( !m_currrentOctNode )
		              goto LABEL_44;
		            System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
		              m_currrentOctNode,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::Clear);
		          }
		          v23 = this->fields.m_currrentOctNode;
		          if ( !v23 )
		            goto LABEL_44;
		          if ( !v23->fields._size
		            || (System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::get_Item(
		                  (RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry *)&v32.fields,
		                  (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)this->fields.m_currrentOctNode,
		                  v23->fields._size - 1,
		                  MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::get_Item),
		                sub_1800036A0(TypeInfo::UnityEngine::Object),
		                UnityEngine::Object::op_Inequality(v20, *(Object_1 **)&v32.fields.bounds.m_Center.x, 0LL)) )
		          {
		            v24 = (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)this->fields.m_currrentOctNode;
		            *(_OWORD *)&v32.klass = (unsigned __int64)v20;
		            sub_18002D1B0(&v32, (HGRuntimeGrassQuery_Node *)v9, v21, v22, methoda);
		            LODWORD(v32.monitor) = System::Collections::Generic::List<float>::get_Item(
		                                     v11,
		                                     v12,
		                                     MethodInfo::System::Collections::Generic::List<float>::get_Item);
		            if ( !v24 )
		              goto LABEL_44;
		            *(_OWORD *)&v32.fields.bounds.m_Extents.y = *(_OWORD *)&v32.klass;
		            System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::Add(
		              v24,
		              (RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry *)&v32.fields.bounds.m_Extents.y,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::Add);
		          }
		        }
		      }
		      ++v12;
		    }
		    if ( !passData
		      || (passData->fields.renderBlend = 0, (m_previousOctNode = this->fields.m_previousOctNode) == 0LL)
		      || (m_currrentOctNode = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)(unsigned int)m_previousOctNode->fields._size,
		          (v26 = this->fields.m_currrentOctNode) == 0LL) )
		    {
		LABEL_44:
		      sub_1800D8260(m_currrentOctNode, v9);
		    }
		    if ( (_DWORD)m_currrentOctNode == v26->fields._size )
		    {
		      for ( i = 0; ; ++i )
		      {
		        v28 = this->fields.m_currrentOctNode;
		        if ( !v28 )
		          break;
		        if ( i >= v28->fields._size )
		          goto LABEL_32;
		        System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::get_Item(
		          (RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry *)&v32.fields.bounds.m_Extents.y,
		          (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)this->fields.m_currrentOctNode,
		          i,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::get_Item);
		        v9 = this->fields.m_previousOctNode;
		        *(_OWORD *)&v32.klass = *(_OWORD *)&v32.fields.bounds.m_Extents.y;
		        if ( !v9 )
		          break;
		        System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::get_Item(
		          (RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry *)&v32.fields,
		          (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)v9,
		          i,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::get_Item);
		        *(_OWORD *)&v32.fields.left = *(_OWORD *)&v32.fields.bounds.m_Center.x;
		        if ( HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode::diff(
		               (ReflectionProbeBinningPassConstructor_OctNode *)&v32,
		               (ReflectionProbeBinningPassConstructor_OctNode *)&v32.fields.left,
		               0LL) )
		        {
		          goto LABEL_31;
		        }
		      }
		      goto LABEL_44;
		    }
		LABEL_31:
		    passData->fields.renderBlend = 1;
		LABEL_32:
		    if ( passData->fields.renderBlend )
		    {
		      m_currrentOctNode = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)this->fields.m_previousOctNode;
		      if ( !m_currrentOctNode )
		        goto LABEL_44;
		      System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
		        m_currrentOctNode,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::Clear);
		      m_currrentOctNode = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)this->fields.m_previousOctNode;
		      if ( !m_currrentOctNode )
		        goto LABEL_44;
		      System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::AddRange(
		        (List_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *)m_currrentOctNode,
		        (IEnumerable_1_HG_Rendering_Runtime_ReflectionProbeBinningPassConstructor_OctNode_ *)this->fields.m_currrentOctNode,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::AddRange);
		    }
		    v29 = this->fields.m_currrentOctNode;
		    if ( !v29 )
		      goto LABEL_44;
		    if ( v29->fields._size > 0 )
		    {
		      this->fields.m_clearDefault = 0;
		    }
		    else if ( !this->fields.m_clearDefault )
		    {
		      this->fields.m_clearDefault = 1;
		      passData->fields.clearDefault = 1;
		LABEL_42:
		      passData->fields.currrentOctNode = this->fields.m_currrentOctNode;
		      sub_18002D1B0(
		        (HGRuntimeGrassQuery_Node *)&passData->fields.currrentOctNode,
		        (HGRuntimeGrassQuery_Node *)v9,
		        v13,
		        v14,
		        methoda);
		      return;
		    }
		    passData->fields.clearDefault = 0;
		    goto LABEL_42;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2029, 0LL);
		  if ( !Patch )
		    goto LABEL_44;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		    (ILFixDynamicMethodWrapper_30 *)Patch,
		    (Object *)this,
		    (Object *)passData,
		    (Object *)hgCamera,
		    0LL);
		}
		
		private void PrepareLocalReflectionProbe(PassData passData, HGCamera hgCamera, ref PassInput input) {} // 0x0000000189D11078-0x0000000189D11358
		// Void PrepareLocalReflectionProbe(ReflectionProbeBinningPassConstructor+PassData, HGCamera, ReflectionProbeBinningPassConstructor+PassInput ByRef)
		void HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::PrepareLocalReflectionProbe(
		        ReflectionProbeBinningPassConstructor *this,
		        ReflectionProbeBinningPassConstructor_PassData *passData,
		        HGCamera *hgCamera,
		        ReflectionProbeBinningPassConstructor_PassInput *input,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v9; // rdx
		  SettingParameter_1_System_Int32Enum_ **settingParameters; // rcx
		  Int32Enum__Enum v11; // r14d
		  float deltaTime; // xmm6_4
		  float fadeTime; // xmm0_4
		  __int64 v14; // xmm7_8
		  float z; // r15d
		  float v16; // xmm6_4
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  __int64 v19; // xmm0_8
		  MethodInfo *v20; // r9
		  Vector3 *v21; // rax
		  __int64 v22; // xmm3_8
		  float v23; // xmm7_4
		  float cameraMovementNotFadeness; // xmm8_4
		  Transform *v25; // rax
		  Vector3 *v26; // rax
		  float v27; // ecx
		  uint64_t *m_Buffer; // r14
		  HGRuntimeGrassQuery_Node *v29; // r8
		  Int32__Array **v30; // r9
		  Texture__Array *m_blitTextures; // r9
		  HGRuntimeGrassQuery_Node *v32; // rdx
		  HGRuntimeGrassQuery_Node *v33; // r8
		  int32_t v34; // edi
		  Int32__Array *blitIndices; // r15
		  int32_t TextureIndex; // eax
		  Texture__Array *blitTextures; // r15
		  Texture *Texture; // rax
		  Texture *v39; // r12
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int32_t maxBlitCounta; // [rsp+28h] [rbp-61h]
		  MethodInfo *maxBlitCount; // [rsp+28h] [rbp-61h]
		  MethodInfo *maxBlitCountb; // [rsp+28h] [rbp-61h]
		  int32_t blitCount[4]; // [rsp+48h] [rbp-41h] BYREF
		  Vector3 v45; // [rsp+58h] [rbp-31h] BYREF
		  Vector3 v46; // [rsp+68h] [rbp-21h] BYREF
		  Vector3 v47; // [rsp+78h] [rbp-11h] BYREF
		  NativeArray_1_System_UInt64_ v48; // [rsp+88h] [rbp-1h] BYREF
		
		  blitCount[0] = 0;
		  v48 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2031, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2031, 0LL);
		    if ( !Patch )
		      goto LABEL_19;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_812(
		      Patch,
		      (Object *)this,
		      (Object *)passData,
		      (Object *)hgCamera,
		      input,
		      0LL);
		  }
		  else
		  {
		    settingParameters = (SettingParameter_1_System_Int32Enum_ **)input->settingParameters;
		    if ( !settingParameters )
		      goto LABEL_19;
		    v11 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		            settingParameters[194],
		            MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    deltaTime = UnityEngine::Time::get_deltaTime(0LL);
		    fadeTime = UnityEngine::HyperGryph::HGReflectionProbe::get_fadeTime(0LL);
		    v14 = *(_QWORD *)&this->fields.m_prevCameraPosition.x;
		    z = this->fields.m_prevCameraPosition.z;
		    v16 = deltaTime / fadeTime;
		    if ( !hgCamera )
		      goto LABEL_19;
		    settingParameters = (SettingParameter_1_System_Int32Enum_ **)hgCamera->fields.camera;
		    if ( !settingParameters )
		      goto LABEL_19;
		    transform = UnityEngine::Component::get_transform((Component *)settingParameters, 0LL);
		    if ( !transform )
		      goto LABEL_19;
		    position = UnityEngine::Transform::get_position(&v46, transform, 0LL);
		    v19 = *(_QWORD *)&position->x;
		    *(float *)&position = position->z;
		    *(_QWORD *)&v45.x = v19;
		    LODWORD(v45.z) = (_DWORD)position;
		    *(_QWORD *)&v46.x = v14;
		    v46.z = z;
		    v21 = UnityEngine::Vector3::op_Subtraction(&v47, &v46, &v45, v20);
		    v22 = *(_QWORD *)&v21->x;
		    *(float *)&v21 = v21->z;
		    *(_QWORD *)&v46.x = v22;
		    LODWORD(v46.z) = (_DWORD)v21;
		    v23 = sub_182F9FF00(&v46);
		    cameraMovementNotFadeness = UnityEngine::HyperGryph::HGReflectionProbe::get_cameraMovementNotFadeness(0LL);
		    if ( v23 >= cameraMovementNotFadeness )
		      v11 = 32;
		    settingParameters = (SettingParameter_1_System_Int32Enum_ **)hgCamera->fields.camera;
		    if ( !settingParameters )
		      goto LABEL_19;
		    v25 = UnityEngine::Component::get_transform((Component *)settingParameters, 0LL);
		    if ( !v25 )
		      goto LABEL_19;
		    v26 = UnityEngine::Transform::get_position(&v47, v25, 0LL);
		    v27 = v26->z;
		    *(_QWORD *)&this->fields.m_prevCameraPosition.x = *(_QWORD *)&v26->x;
		    this->fields.m_prevCameraPosition.z = v27;
		    Unity::Collections::NativeArray<unsigned long>::NativeArray(
		      &v48,
		      v11,
		      Allocator__Enum_Temp,
		      NativeArrayOptions__Enum_ClearMemory,
		      MethodInfo::Unity::Collections::NativeArray<unsigned long>::NativeArray);
		    maxBlitCounta = v11;
		    m_Buffer = (uint64_t *)v48.m_Buffer;
		    UnityEngine::HyperGryph::HGReflectionProbe::UpdateViewPhase1(
		      hgCamera->fields.reflectionProbeViewHandle,
		      v16,
		      v23 < cameraMovementNotFadeness,
		      v48.m_Buffer,
		      maxBlitCounta,
		      blitCount,
		      0LL);
		    if ( !passData )
		      goto LABEL_19;
		    passData->fields.blitCount = blitCount[0];
		    passData->fields.blitIndices = this->fields.m_blitIndices;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&passData->fields.blitIndices, v9, v29, v30, maxBlitCount);
		    m_blitTextures = this->fields.m_blitTextures;
		    passData->fields.blitTextures = m_blitTextures;
		    sub_18002D1B0(
		      (HGRuntimeGrassQuery_Node *)&passData->fields.blitTextures,
		      v32,
		      v33,
		      (Int32__Array **)m_blitTextures,
		      maxBlitCountb);
		    v34 = 0;
		    if ( blitCount[0] > 0 )
		    {
		      while ( 1 )
		      {
		        blitIndices = passData->fields.blitIndices;
		        TextureIndex = UnityEngine::HyperGryph::HGReflectionProbe::GetTextureIndex(
		                         hgCamera->fields.reflectionProbeViewHandle,
		                         *m_Buffer,
		                         0LL);
		        if ( !blitIndices )
		          break;
		        if ( (unsigned int)v34 >= blitIndices->max_length.size )
		          sub_1800D2AB0(settingParameters, v9);
		        blitIndices->vector[v34] = TextureIndex;
		        blitTextures = passData->fields.blitTextures;
		        Texture = UnityEngine::HyperGryph::HGReflectionProbe::GetTexture(
		                    hgCamera->fields.reflectionProbeViewHandle,
		                    *m_Buffer,
		                    0LL);
		        v39 = Texture;
		        if ( !blitTextures )
		          break;
		        sub_180031B10(blitTextures, Texture);
		        sub_180378FEC(blitTextures, v34++, v39);
		        ++m_Buffer;
		        if ( v34 >= blitCount[0] )
		          return;
		      }
		LABEL_19:
		      sub_1800D8260(settingParameters, v9);
		    }
		  }
		}
		
		private void PrepareConstantBuffer(PassData passData, HGCamera hgCamera, ref PassInput input) {} // 0x0000000189D10660-0x0000000189D10CB4
		// Void PrepareConstantBuffer(ReflectionProbeBinningPassConstructor+PassData, HGCamera, ReflectionProbeBinningPassConstructor+PassInput ByRef)
		void HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::PrepareConstantBuffer(
		        ReflectionProbeBinningPassConstructor *this,
		        ReflectionProbeBinningPassConstructor_PassData *passData,
		        HGCamera *hgCamera,
		        ReflectionProbeBinningPassConstructor_PassInput *input,
		        MethodInfo *method)
		{
		  Camera *v9; // rdx
		  Camera *camera; // rcx
		  int32_t tileSize; // edi
		  float v12; // xmm0_4
		  float v13; // xmm8_4
		  float aspect; // xmm0_4
		  float v15; // xmm10_4
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  __int64 v18; // r8
		  __int64 v19; // r9
		  float v20; // xmm7_4
		  float v21; // xmm6_4
		  int32_t octTextureSize; // edi
		  int v23; // eax
		  CBHandle *ConstantBuffer; // rax
		  void *ptr; // xmm0_8
		  CBHandle *v26; // rax
		  void *v27; // xmm0_8
		  __m128i v28; // xmm1
		  void *v29; // rbx
		  __int128 v30; // xmm0
		  __int128 v31; // xmm1
		  __int128 v32; // xmm1
		  __int64 v33; // rdx
		  __int64 v34; // rcx
		  __m128i *v35; // rdi
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  __int128 v37; // xmm1
		  __int128 v38; // xmm0
		  __int128 v39; // xmm1
		  __int128 v40; // xmm0
		  __int128 v41; // xmm1
		  float shb8; // eax
		  SHCoefficientsL1 *CoefficientsL1; // rax
		  __m128 shAr; // xmm7
		  __m128 shAg; // xmm9
		  __m128 shAb; // xmm10
		  __m128 v47; // xmm6
		  __m128 v48; // xmm5
		  __m128 v49; // xmm8
		  __m128 v50; // xmm7
		  uint32_t reflectionProbeViewHandle; // ebx
		  Matrix4x4 *worldToCameraMatrix; // rax
		  __int128 v53; // xmm1
		  void *v54; // r9
		  __int128 v55; // xmm0
		  __int128 v56; // xmm1
		  __int128 v57; // xmm0
		  __int128 v58; // xmm1
		  __int128 v59; // xmm0
		  __int128 v60; // xmm1
		  void *v61; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Matrix4x4 v63; // [rsp+38h] [rbp-D0h] BYREF
		  int32_t tileX; // [rsp+78h] [rbp-90h]
		  int32_t tileY; // [rsp+7Ch] [rbp-8Ch]
		  int32_t sliceZ; // [rsp+80h] [rbp-88h]
		  int32_t v67; // [rsp+84h] [rbp-84h]
		  int32_t v68; // [rsp+88h] [rbp-80h]
		  int v69; // [rsp+8Ch] [rbp-7Ch]
		  __m128i *sceneRTSize_k__BackingField; // [rsp+90h] [rbp-78h]
		  Matrix4x4 v71; // [rsp+98h] [rbp-70h] BYREF
		  SphericalHarmonicsL2 v72; // [rsp+D8h] [rbp-30h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2033, 0LL) )
		  {
		    if ( hgCamera )
		    {
		      camera = hgCamera->fields.camera;
		      tileSize = input->binningData.tileSize;
		      sceneRTSize_k__BackingField = (__m128i *)hgCamera->fields._sceneRTSize_k__BackingField;
		      tileX = input->binningData.tileX;
		      tileY = input->binningData.tileY;
		      v68 = input->binningData.tileX;
		      v67 = input->binningData.tileY;
		      sliceZ = input->binningData.sliceZ;
		      v69 = tileSize;
		      if ( camera )
		      {
		        v12 = UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
		        camera = hgCamera->fields.camera;
		        v13 = v12;
		        if ( camera )
		        {
		          aspect = UnityEngine::Camera::get_aspect(camera, 0LL);
		          camera = hgCamera->fields.camera;
		          v15 = aspect;
		          if ( camera )
		          {
		            UnityEngine::Camera::get_fieldOfView(camera, 0LL);
		            v20 = sub_180338A80(v17, v16, v18, v19) * (float)(v13 + v13);
		            v21 = (float)(v20 / (float)SHIDWORD(sceneRTSize_k__BackingField)) * (float)tileSize;
		            if ( passData )
		            {
		              octTextureSize = passData->fields.octTextureSize;
		              passData->fields.xyBinningThreadGroupX = (tileX + 7) / 8;
		              passData->fields.xyBinningThreadGroupY = (tileY + 7) / 8;
		              v23 = sliceZ + 63;
		              passData->fields.xyBinningThreadGroupZ = 1;
		              passData->fields.zBinningThreadGroupY = 1;
		              passData->fields.zBinningThreadGroupZ = 1;
		              passData->fields.zBinningThreadGroupX = v23 / 64;
		              sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		              ConstantBuffer = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		                                 (CBHandle *)&v63,
		                                 &input->srpContext,
		                                 2112,
		                                 0LL);
		              ptr = ConstantBuffer->ptr;
		              *(_OWORD *)&passData->fields.reflectionProbeBinningInputDatasCB.bufferId = *(_OWORD *)&ConstantBuffer->bufferId;
		              passData->fields.reflectionProbeBinningInputDatasCB.ptr = ptr;
		              v26 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		                      (CBHandle *)&v63,
		                      &input->srpContext,
		                      4160,
		                      0LL);
		              v27 = v26->ptr;
		              *(_OWORD *)&passData->fields.reflectionProbeGlobalDatasCB.bufferId = *(_OWORD *)&v26->bufferId;
		              v28 = _mm_cvtsi32_si128(tileY);
		              passData->fields.reflectionProbeGlobalDatasCB.ptr = v27;
		              v29 = passData->fields.reflectionProbeBinningInputDatasCB.ptr;
		              sceneRTSize_k__BackingField = (__m128i *)passData->fields.reflectionProbeGlobalDatasCB.ptr;
		              LODWORD(v63.m10) = _mm_cvtepi32_ps(v28).m128_u32[0];
		              v63.m00 = (float)tileX;
		              v63.m30 = 1.0 / (float)v69;
		              v63.m20 = (float)(v68 * v67);
		              v30 = *(_OWORD *)&v63.m00;
		              v63.m10 = 1.0;
		              v63.m00 = (float)sliceZ;
		              *(_OWORD *)v29 = v30;
		              v63.m20 = 1.0;
		              v63.m30 = (float)octTextureSize / (float)(octTextureSize + 64);
		              v31 = *(_OWORD *)&v63.m00;
		              v63.m00 = 0.0;
		              v63.m10 = v13;
		              *((_OWORD *)v29 + 1) = v31;
		              v63.m20 = v13;
		              v63.m30 = 32.0 / (float)(octTextureSize + 64);
		              v32 = *(_OWORD *)&v63.m00;
		              v63.m20 = v21;
		              v63.m00 = v15 * v20;
		              v63.m10 = v20;
		              *((_OWORD *)v29 + 2) = v32;
		              *(float *)&v30 = sub_1803386C0(v34, v33);
		              v35 = sceneRTSize_k__BackingField;
		              LODWORD(v63.m30) = v30;
		              *((_OWORD *)v29 + 3) = *(_OWORD *)&v63.m00;
		              *v35 = _mm_loadu_si128((const __m128i *)v29);
		              v35[1] = _mm_loadu_si128((const __m128i *)v29 + 1);
		              v35[2] = _mm_loadu_si128((const __m128i *)v29 + 2);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		              InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		              if ( InterpolatedPhase )
		              {
		                v37 = *(_OWORD *)&InterpolatedPhase->fields.skyConfig.skyAmbientSH.shr4;
		                *(_OWORD *)&v72.shr0 = *(_OWORD *)&InterpolatedPhase->fields.skyConfig.skyAmbientSH.shr0;
		                v38 = *(_OWORD *)&InterpolatedPhase->fields.skyConfig.skyAmbientSH.shr8;
		                *(_OWORD *)&v72.shr4 = v37;
		                v39 = *(_OWORD *)&InterpolatedPhase->fields.skyConfig.skyAmbientSH.shg3;
		                *(_OWORD *)&v72.shr8 = v38;
		                v40 = *(_OWORD *)&InterpolatedPhase->fields.skyConfig.skyAmbientSH.shg7;
		                *(_OWORD *)&v72.shg3 = v39;
		                v41 = *(_OWORD *)&InterpolatedPhase->fields.skyConfig.skyAmbientSH.shb2;
		                *(_OWORD *)&v72.shg7 = v40;
		                *(_QWORD *)&v40 = *(_QWORD *)&InterpolatedPhase->fields.skyConfig.skyAmbientSH.shb6;
		                shb8 = InterpolatedPhase->fields.skyConfig.skyAmbientSH.shb8;
		                *(_QWORD *)&v72.shb6 = v40;
		                v72.shb8 = shb8;
		                *(_OWORD *)&v72.shb2 = v41;
		                CoefficientsL1 = HG::Rendering::Runtime::HGEnvironmentUtils::GetCoefficientsL1(
		                                   (SHCoefficientsL1 *)&v71,
		                                   &v72,
		                                   0LL);
		                shAr = (__m128)CoefficientsL1->shAr;
		                shAg = (__m128)CoefficientsL1->shAg;
		                shAb = (__m128)CoefficientsL1->shAb;
		                v63.m30 = 1.0;
		                LODWORD(v63.m00) = shAr.m128_i32[0];
		                LODWORD(v63.m10) = shAg.m128_i32[0];
		                LODWORD(v63.m20) = shAb.m128_i32[0];
		                v47 = *(__m128 *)&v63.m00;
		                *(__m128 *)&v63.m02 = shAb;
		                *(__m128 *)&v63.m01 = shAg;
		                sub_1800036A0(TypeInfo::UnityEngine::Rendering::ColorUtils);
		                LODWORD(v63.m00) = _mm_shuffle_ps(shAr, shAr, 170).m128_u32[0];
		                LODWORD(v63.m10) = _mm_shuffle_ps(shAg, shAg, 170).m128_u32[0];
		                LODWORD(v63.m20) = _mm_shuffle_ps(shAb, shAb, 170).m128_u32[0];
		                v63.m30 = 1.0;
		                v48 = *(__m128 *)&v63.m00;
		                v63.m30 = 1.0;
		                LODWORD(v63.m10) = _mm_shuffle_ps(shAg, shAg, 85).m128_u32[0];
		                LODWORD(v63.m00) = _mm_shuffle_ps(shAr, shAr, 85).m128_u32[0];
		                LODWORD(v63.m20) = _mm_shuffle_ps(shAb, shAb, 85).m128_u32[0];
		                v49 = *(__m128 *)&v63.m00;
		                v63.m30 = 1.0;
		                LODWORD(v63.m00) = _mm_shuffle_ps(shAr, shAr, 255).m128_u32[0];
		                LODWORD(v63.m10) = _mm_shuffle_ps(shAg, shAg, 255).m128_u32[0];
		                LODWORD(v63.m20) = _mm_shuffle_ps(shAb, shAb, 255).m128_u32[0];
		                v50 = *(__m128 *)&v63.m00;
		                v63.m00 = (float)((float)(v47.m128_f32[0] * 0.2126729)
		                                + (float)(_mm_shuffle_ps(v47, v47, 85).m128_f32[0] * 0.7151522))
		                        + (float)(_mm_shuffle_ps(v47, v47, 170).m128_f32[0] * 0.072175004);
		                v63.m10 = (float)((float)(v48.m128_f32[0] * 0.2126729)
		                                + (float)(_mm_shuffle_ps(v48, v48, 85).m128_f32[0] * 0.7151522))
		                        + (float)(_mm_shuffle_ps(v48, v48, 170).m128_f32[0] * 0.072175004);
		                v63.m20 = (float)((float)(v49.m128_f32[0] * 0.2126729)
		                                + (float)(_mm_shuffle_ps(v49, v49, 85).m128_f32[0] * 0.7151522))
		                        + (float)(_mm_shuffle_ps(v49, v49, 170).m128_f32[0] * 0.072175004);
		                v63.m30 = (float)((float)(v50.m128_f32[0] * 0.2126729)
		                                + (float)(_mm_shuffle_ps(v50, v50, 85).m128_f32[0] * 0.7151522))
		                        + (float)(_mm_shuffle_ps(v50, v50, 170).m128_f32[0] * 0.072175004);
		                v35[3] = *(__m128i *)&v63.m00;
		                v9 = hgCamera->fields.camera;
		                reflectionProbeViewHandle = hgCamera->fields.reflectionProbeViewHandle;
		                if ( v9 )
		                {
		                  worldToCameraMatrix = UnityEngine::Camera::get_worldToCameraMatrix((Matrix4x4 *)&v72, v9, 0LL);
		                  v53 = *(_OWORD *)&this->fields.unitExtents.m01;
		                  v54 = passData->fields.reflectionProbeBinningInputDatasCB.ptr;
		                  *(_OWORD *)&v71.m00 = *(_OWORD *)&this->fields.unitExtents.m00;
		                  v55 = *(_OWORD *)&this->fields.unitExtents.m02;
		                  *(_OWORD *)&v71.m01 = v53;
		                  v56 = *(_OWORD *)&this->fields.unitExtents.m03;
		                  *(_OWORD *)&v71.m02 = v55;
		                  v57 = *(_OWORD *)&worldToCameraMatrix->m00;
		                  *(_OWORD *)&v71.m03 = v56;
		                  v58 = *(_OWORD *)&worldToCameraMatrix->m01;
		                  *(_OWORD *)&v63.m00 = v57;
		                  v59 = *(_OWORD *)&worldToCameraMatrix->m02;
		                  *(_OWORD *)&v63.m01 = v58;
		                  v60 = *(_OWORD *)&worldToCameraMatrix->m03;
		                  v61 = passData->fields.reflectionProbeGlobalDatasCB.ptr;
		                  *(_OWORD *)&v63.m02 = v59;
		                  *(_OWORD *)&v63.m03 = v60;
		                  UnityEngine::HyperGryph::HGReflectionProbe::UpdateViewCBHandle(
		                    reflectionProbeViewHandle,
		                    &v63,
		                    &v71,
		                    v54,
		                    v61,
		                    0LL);
		                  return;
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_11:
		    sub_1800D8260(camera, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2033, 0LL);
		  if ( !Patch )
		    goto LABEL_11;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_812(
		    Patch,
		    (Object *)this,
		    (Object *)passData,
		    (Object *)hgCamera,
		    input,
		    0LL);
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera) {} // 0x0000000189D0FF90-0x0000000189D10564
		// Void ConstructPass(ReflectionProbeBinningPassConstructor+PassInput ByRef, ReflectionProbeBinningPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::ConstructPass(
		        ReflectionProbeBinningPassConstructor *this,
		        ReflectionProbeBinningPassConstructor_PassInput *input,
		        ReflectionProbeBinningPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  ProfilingSampler *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int64 v13; // rdx
		  ReflectionProbeBinningPassConstructor_PassData *v14; // rdi
		  HGSettingParameters *settingParameters; // rcx
		  Int32Enum__Enum v16; // eax
		  unsigned __int64 v17; // rdx
		  __int64 v18; // rcx
		  unsigned __int64 v19; // r8
		  signed __int64 v20; // rtt
		  HGSettingParameters *v21; // rcx
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  GraphicsFormat__Enum colorFormat; // r14d
		  __int64 octTextureSize; // rcx
		  int32_t reflectionProbeOctTextureArrayCount; // r13d
		  unsigned __int64 v27; // rdx
		  unsigned __int64 v28; // r8
		  signed __int64 v29; // rtt
		  List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *m_previousOctNode; // rcx
		  ReflectionProbeBinningPassConstructor_PassData *v31; // r14
		  ComputeBufferHandle v32; // rax
		  ComputeBufferHandle v33; // rdx
		  ComputeBufferHandle v34; // rcx
		  ReflectionProbeBinningPassConstructor_PassData *v35; // r14
		  __int64 v36; // rdx
		  __int64 v37; // rcx
		  TextureHandle v38; // xmm0
		  ReflectionProbeBinningPassConstructor_PassData *v39; // r14
		  HGRenderPipeline *currentPipeline; // rax
		  __int64 v41; // rdx
		  __int64 v42; // rcx
		  HGRenderPipelineRuntimeResources *defaultResources; // rax
		  __int64 v44; // rdx
		  __int64 v45; // rcx
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  ComputeShader *reflectionProbeBinningCS; // rcx
		  unsigned __int64 v48; // r8
		  signed __int64 v49; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v51; // rdx
		  __int64 v52; // rcx
		  ReflectionProbeBinningPassConstructor_PassData *passData; // [rsp+A0h] [rbp-98h] BYREF
		  int v54; // [rsp+A8h] [rbp-90h]
		  TextureHandle v55; // [rsp+B0h] [rbp-88h] BYREF
		  _QWORD v56[2]; // [rsp+C0h] [rbp-78h] BYREF
		  HGRenderGraphBuilder v57; // [rsp+D0h] [rbp-68h] BYREF
		  Il2CppExceptionWrapper *v58; // [rsp+F0h] [rbp-48h] BYREF
		  HGRenderGraphBuilder v59; // [rsp+F8h] [rbp-40h] BYREF
		
		  passData = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(2034, 0LL) )
		  {
		    v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x78u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v12, v11);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v59,
		      renderGraph,
		      (String *)"Compute Reflection Probe Binning",
		      (Object **)&passData,
		      v10,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::PassData>);
		    v57 = v59;
		    v56[0] = 0LL;
		    v56[1] = &v57;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v57, 0, 0LL);
		      v14 = passData;
		      settingParameters = input->settingParameters;
		      if ( !settingParameters )
		        sub_1800D8250(0LL, v13);
		      v16 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		              (SettingParameter_1_System_Int32Enum_ *)settingParameters->fields._reflectionProbeOctTextureSize_k__BackingField,
		              MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		      if ( !v14 )
		        sub_1800D8250(v18, v17);
		      v14->fields.octTextureSize = v16;
		      if ( this->fields.m_octTextureArray )
		      {
		        if ( !hgCamera )
		          sub_1800D8250(v18, v17);
		        if ( !hgCamera->fields.reflectionProbeReset )
		          goto LABEL_21;
		        if ( this->fields.m_octTextureArray )
		        {
		          UnityEngine::Rendering::RTHandle::Release(this->fields.m_octTextureArray, 0LL);
		          this->fields.m_octTextureArray = 0LL;
		          if ( dword_18F35FD08 )
		          {
		            v19 = (((unsigned __int64)&this->fields.m_octTextureArray >> 12) & 0x1FFFFF) >> 6;
		            v17 = ((unsigned __int64)&this->fields.m_octTextureArray >> 12) & 0x3F;
		            _m_prefetchw(&qword_18F0BCBA0[v19 + 36190]);
		            do
		              v20 = qword_18F0BCBA0[v19 + 36190];
		            while ( v20 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v19 + 36190], v20 | (1LL << v17), v20) );
		          }
		        }
		      }
		      v21 = input->settingParameters;
		      if ( !v21 )
		        sub_1800D8250(0LL, v17);
		      colorFormat = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                      v21->fields._reflectionProbeUseRGBAHalf_k__BackingField,
		                      MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit)
		                  ? GraphicsFormat__Enum_R16G16B16A16_SFloat
		                  : GraphicsFormat__Enum_B10G11R11_UFloatPack32;
		      if ( !passData )
		        sub_1800D8250(v23, v22);
		      octTextureSize = (unsigned int)passData->fields.octTextureSize;
		      v55.handle.m_Value = octTextureSize;
		      v54 = octTextureSize;
		      if ( !hgCamera )
		        sub_1800D8250(octTextureSize, v22);
		      reflectionProbeOctTextureArrayCount = hgCamera->fields.reflectionProbeOctTextureArrayCount;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::RTHandles);
		      this->fields.m_octTextureArray = UnityEngine::Rendering::RTHandles::Alloc(
		                                         v55.handle.m_Value + 64,
		                                         v54 + 64,
		                                         reflectionProbeOctTextureArrayCount,
		                                         DepthBits__Enum_None,
		                                         colorFormat,
		                                         FilterMode__Enum_Point,
		                                         TextureWrapMode__Enum_Repeat,
		                                         TextureDimension__Enum_Tex2DArray,
		                                         1,
		                                         1,
		                                         0,
		                                         0,
		                                         1,
		                                         0.0,
		                                         MSAASamples__Enum_None,
		                                         0,
		                                         RenderTextureMemoryless__Enum_None,
		                                         (String *)"(c# renderpipeline) Reflection Probe Oct Texture Array",
		                                         0LL);
		      if ( dword_18F35FD08 )
		      {
		        v28 = (((unsigned __int64)&this->fields.m_octTextureArray >> 12) & 0x1FFFFF) >> 6;
		        v27 = ((unsigned __int64)&this->fields.m_octTextureArray >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v28 + 36190]);
		        do
		          v29 = qword_18F0BCBA0[v28 + 36190];
		        while ( v29 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v28 + 36190], v29 | (1LL << v27), v29) );
		      }
		      m_previousOctNode = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)this->fields.m_previousOctNode;
		      if ( !m_previousOctNode )
		        sub_1800D8250(0LL, v27);
		      System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
		        m_previousOctNode,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::OctNode>::Clear);
		LABEL_21:
		      v31 = passData;
		      v32 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(&v57, &input->binningBuffer, 0LL);
		      if ( !v31 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v34, v33);
		      v31->fields.binningBuffer = v32;
		      v35 = passData;
		      v55 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		               &v55,
		               renderGraph,
		               this->fields.m_octTextureArray,
		               0LL);
		      v38 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		               (TextureHandle *)&v59,
		               &v57,
		               &v55,
		               0LL);
		      if ( !v35 )
		        sub_1800D8250(v37, v36);
		      v35->fields.octTextureArray = v38;
		      v39 = passData;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		      currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		      if ( !currentPipeline )
		        sub_1800D8250(v42, v41);
		      defaultResources = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(currentPipeline, 0LL);
		      if ( !defaultResources )
		        sub_1800D8250(v45, v44);
		      shaders = defaultResources->fields.shaders;
		      if ( !shaders )
		        sub_1800D8250(v45, v44);
		      reflectionProbeBinningCS = shaders->fields.reflectionProbeBinningCS;
		      if ( !v39 )
		        sub_1800D8250(reflectionProbeBinningCS, v44);
		      v39->fields.computeShader = reflectionProbeBinningCS;
		      if ( dword_18F35FD08 )
		      {
		        v48 = (((unsigned __int64)&v39->fields.computeShader >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v48 + 36190]);
		        do
		          v49 = qword_18F0BCBA0[v48 + 36190];
		        while ( v49 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v48 + 36190],
		                         v49 | (1LL << (((unsigned __int64)&v39->fields.computeShader >> 12) & 0x3F)),
		                         v49) );
		      }
		      HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::PrepareGlobalReflectionProbe(
		        this,
		        passData,
		        hgCamera,
		        0LL);
		      HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::PrepareLocalReflectionProbe(
		        this,
		        passData,
		        hgCamera,
		        input,
		        0LL);
		      HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::PrepareConstantBuffer(
		        this,
		        passData,
		        hgCamera,
		        input,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v57,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor->static_fields->s_RenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::PassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v58 )
		    {
		      v56[0] = v58->ex;
		    }
		    sub_180268AE0(v56);
		    return;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2034, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v52, v51);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_813(
		    Patch,
		    (Object *)this,
		    input,
		    output,
		    (Object *)renderGraph,
		    (Object *)hgCamera,
		    0LL);
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189D1060C-0x0000000189D10660
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        ReflectionProbeBinningPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2035, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2035, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189D105B8-0x0000000189D1060C
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        ReflectionProbeBinningPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2036, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2036, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189D10564-0x0000000189D105B8
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        ReflectionProbeBinningPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2037, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2037, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D79C90-0x0000000184D79CD0
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::ReflectionProbeBinningPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        ReflectionProbeBinningPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2038, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2038, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		  else if ( this->fields.m_octTextureArray )
		  {
		    UnityEngine::Rendering::RTHandle::Release(this->fields.m_octTextureArray, 0LL);
		    this->fields.m_octTextureArray = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_octTextureArray, v5, v6, v7, v11);
		  }
		}
		
	}
}
