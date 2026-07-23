using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.TerrainV2
{
	[Serializable]
	public struct TerrainSubsurfaceData // TypeDefIndex: 38829
	{
		// Fields
		public TerrainSubsurfaceParams _Params; // 0x00
		public HGSubsurfaceProfile _SubsurfaceProfile; // 0x10
		public const int DEFAULT_TERRAIN_STENCIL_REF = 128; // Metadata: 0x023044E7
		public const int DEFAULT_SEPARATE_TERRAIN_STENCIL_REF = 32; // Metadata: 0x023044E9
	
		// Methods
		public void SetupTerrainParams(HGRenderGraphContext context) {} // 0x0000000189C7E5B0-0x0000000189C7E8F0
		// Void SetupTerrainParams(HGRenderGraphContext)
		void HG::Rendering::Runtime::TerrainV2::TerrainSubsurfaceData::SetupTerrainParams(
		        TerrainSubsurfaceData *this,
		        HGRenderGraphContext *context,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  void *terrainSimpleSubsurface; // rcx
		  CommandBuffer *cmd; // r14
		  HGRenderPipelineSettingHub *instance; // rax
		  bool v9; // r12
		  bool UseSubsurfaceProfile; // bl
		  String *s_SubsurfaceProfile; // r15
		  bool v12; // bp
		  CBHandle *v13; // rax
		  __m128i v14; // xmm6
		  HGManagerContext *currentManagerContext; // rax
		  int32_t TerrainSubsurfaceProfileInt; // ecx
		  int32_t v17; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v19; // [rsp+30h] [rbp-68h]
		  CBHandle v20; // [rsp+40h] [rbp-58h] BYREF
		  int32_t ref; // [rsp+B8h] [rbp+20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5461, 0LL) )
		  {
		    if ( context )
		    {
		      cmd = context->fields.cmd;
		      instance = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
		      if ( instance )
		      {
		        v9 = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_currentDeviceType(instance, 0LL) == HGDeviceType__Enum_Handheld;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		        terrainSimpleSubsurface = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->terrainSimpleSubsurface;
		        if ( terrainSimpleSubsurface )
		        {
		          if ( HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled(
		                 (HGGraphicsFeatureSwitch *)terrainSimpleSubsurface,
		                 0LL) )
		          {
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		            UseSubsurfaceProfile = this->_Params._UseSubsurfaceProfile;
		            s_SubsurfaceProfile = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SubsurfaceProfile;
		            sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		            v12 = UseSubsurfaceProfile && v9;
		          }
		          else
		          {
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		            v12 = this->_Params._UseSubsurfaceProfile;
		            s_SubsurfaceProfile = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SubsurfaceProfile;
		            sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		          }
		          UnityEngine::Rendering::CoreUtils::SetKeyword(cmd, s_SubsurfaceProfile, v12, 0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		          terrainSimpleSubsurface = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		          if ( cmd )
		          {
		            UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		              cmd,
		              *((_DWORD *)terrainSimpleSubsurface + 866),
		              this->_Params._SubsurfaceCurvatureScale,
		              0LL);
		            UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		              cmd,
		              TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SubsurfaceCurvatureOffset,
		              this->_Params._SubsurfaceCurvatureOffset,
		              0LL);
		            sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		            v13 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		                    &v20,
		                    &context->fields.renderContext,
		                    16,
		                    0LL);
		            v14 = *(__m128i *)&v13->bufferId;
		            v20.ptr = v13->ptr;
		            if ( HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
		            {
		              currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		              if ( !currentManagerContext )
		                goto LABEL_22;
		              terrainSimpleSubsurface = currentManagerContext->fields._subsurfaceProfileManager_k__BackingField;
		              if ( !terrainSimpleSubsurface )
		                goto LABEL_22;
		              TerrainSubsurfaceProfileInt = HG::Rendering::Runtime::SubsurfaceProfileManager::GetTerrainSubsurfaceProfileInt(
		                                              (SubsurfaceProfileManager *)terrainSimpleSubsurface,
		                                              0LL);
		            }
		            else
		            {
		              TerrainSubsurfaceProfileInt = 0;
		            }
		            DWORD1(v19) = LODWORD(this->_Params._SubsurfaceCurvatureScale);
		            *((float *)&v19 + 3) = (float)TerrainSubsurfaceProfileInt;
		            *(float *)&v19 = (float)this->_Params._UseSubsurfaceProfile;
		            DWORD2(v19) = LODWORD(this->_Params._SubsurfaceCurvatureOffset);
		            *(_OWORD *)v20.ptr = v19;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		            UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
		              cmd,
		              _mm_cvtsi128_si32(v14),
		              TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainSubsurfaceConstants,
		              _mm_cvtsi128_si32(_mm_srli_si128(v14, 4)),
		              _mm_cvtsi128_si32(_mm_srli_si128(v14, 8)),
		              0LL);
		            v17 = 128;
		            ref = 128;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		            terrainSimpleSubsurface = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->terrainSimpleSubsurface;
		            if ( terrainSimpleSubsurface )
		            {
		              if ( HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled(
		                     (HGGraphicsFeatureSwitch *)terrainSimpleSubsurface,
		                     0LL) )
		              {
		                if ( !v9 || !this->_Params._UseSubsurfaceProfile )
		                  goto LABEL_20;
		              }
		              else if ( !this->_Params._UseSubsurfaceProfile )
		              {
		LABEL_20:
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		                UnityEngine::Rendering::CommandBuffer::SetGlobalInt(
		                  cmd,
		                  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_TerrainStencilRef,
		                  v17,
		                  0LL);
		                return;
		              }
		              HG::Rendering::Runtime::HGStencilUtils::SetStencilValueByMask(
		                &ref,
		                2,
		                HGStencilUtils_HGStencilBitMask__Enum_DeferredShadingModel,
		                0LL);
		              v17 = ref;
		              goto LABEL_20;
		            }
		          }
		        }
		      }
		    }
		LABEL_22:
		    sub_1800D8260(terrainSimpleSubsurface, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5461, 0LL);
		  if ( !Patch )
		    goto LABEL_22;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1582(Patch, this, (Object *)context, 0LL);
		}
		
		public static void ResetTerrainParams(HGRenderGraphContext context) {} // 0x0000000189C7E4DC-0x0000000189C7E5B0
		// Void ResetTerrainParams(HGRenderGraphContext)
		void HG::Rendering::Runtime::TerrainV2::TerrainSubsurfaceData::ResetTerrainParams(
		        HGRenderGraphContext *context,
		        MethodInfo *method)
		{
		  HGShaderIDs__StaticFields *static_fields; // rdx
		  __int64 v4; // rcx
		  CommandBuffer *cmd; // rdi
		  String *s_SubsurfaceProfile; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5462, 0LL) )
		  {
		    if ( context )
		    {
		      cmd = context->fields.cmd;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		      s_SubsurfaceProfile = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_SubsurfaceProfile;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		      UnityEngine::Rendering::CoreUtils::SetKeyword(cmd, s_SubsurfaceProfile, 0, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( cmd )
		      {
		        UnityEngine::Rendering::CommandBuffer::SetGlobalInt(cmd, static_fields->_TerrainStencilRef, 128, 0LL);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(v4, static_fields);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5462, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)context, 0LL);
		}
		
		public HGTerrainSubsurfaceData ToDataCPP() => default; // 0x00000001833356B0-0x0000000183335890
		// HGTerrainSubsurfaceData ToDataCPP()
		HGTerrainSubsurfaceData *HG::Rendering::Runtime::TerrainV2::TerrainSubsurfaceData::ToDataCPP(
		        HGTerrainSubsurfaceData *__return_ptr retstr,
		        TerrainSubsurfaceData *this,
		        MethodInfo *method)
		{
		  TerrainSubsurfaceData *v4; // rsi
		  void *SubsurfaceProfile; // rcx
		  __int64 v6; // r8
		  Object *instance; // rbx
		  Object__Class *v8; // rax
		  int32_t namespaze; // eax
		  bool v10; // di
		  struct HGGraphicsFeatureManager__Class *v11; // rax
		  HGGraphicsFeatureSwitch *terrainSimpleSubsurface; // rbx
		  bool m_defaultValue; // al
		  bool UseSubsurfaceProfile; // cl
		  bool v15; // al
		  float SubsurfaceCurvatureOffset; // xmm1_4
		  float SubsurfaceCurvatureScale; // xmm0_4
		  int32_t m_terrainStencil; // eax
		  __m128 v19; // xmm2
		  __m128 v20; // xmm2
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGTerrainSubsurfaceData *v23; // rax
		  __int128 v24; // xmm0
		  HGSubsurfaceProfile__Class *klass; // r8
		  ILFixDynamicMethodWrapper_2 *v26; // rax
		  ILFixDynamicMethodWrapper_2 *v27; // rax
		  HGTerrainSubsurfaceData v28; // [rsp+20h] [rbp-28h] BYREF
		  int32_t ref; // [rsp+50h] [rbp+8h] BYREF
		
		  v4 = this;
		  SubsurfaceProfile = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    SubsurfaceProfile = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = **((_QWORD **)SubsurfaceProfile + 23);
		  if ( !v6 )
		    goto LABEL_24;
		  if ( *(int *)(v6 + 24) > 5463 )
		  {
		    if ( !*((_DWORD *)SubsurfaceProfile + 56) )
		    {
		      il2cpp_runtime_class_init_1(SubsurfaceProfile);
		      SubsurfaceProfile = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (TerrainSubsurfaceData *)**((_QWORD **)SubsurfaceProfile + 23);
		    if ( !this )
		      goto LABEL_24;
		    if ( *(_DWORD *)&this[1]._Params._UseSubsurfaceProfile <= 0x1557u )
		      goto LABEL_46;
		    if ( *(_QWORD *)&this[1822]._Params._SubsurfaceCurvatureOffset )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(5463, 0LL);
		      if ( Patch )
		      {
		        v23 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1583(&v28, Patch, v4, 0LL);
		        v24 = *(_OWORD *)&v23->m_useSubsurfaceProfile;
		        m_terrainStencil = v23->m_terrainStencil;
		        *(_OWORD *)&retstr->m_useSubsurfaceProfile = v24;
		        goto LABEL_23;
		      }
		      goto LABEL_24;
		    }
		  }
		  instance = (Object *)HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
		  if ( !instance )
		    goto LABEL_24;
		  this = (TerrainSubsurfaceData *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    this = (TerrainSubsurfaceData *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  SubsurfaceProfile = this[7]._SubsurfaceProfile;
		  if ( !*(_QWORD *)SubsurfaceProfile )
		    goto LABEL_24;
		  if ( *(int *)(*(_QWORD *)SubsurfaceProfile + 24LL) <= 672 )
		    goto LABEL_10;
		  if ( !LODWORD(this[9]._Params._SubsurfaceCurvatureOffset) )
		  {
		    il2cpp_runtime_class_init_1(this);
		    this = (TerrainSubsurfaceData *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  klass = this[7]._SubsurfaceProfile->klass;
		  if ( !klass )
		    goto LABEL_24;
		  if ( LODWORD(klass->_0.namespaze) <= 0x2A0 )
		    goto LABEL_46;
		  if ( klass[14]._0.properties )
		  {
		    v26 = IFix::WrappersManagerImpl::GetPatch(672, 0LL);
		    if ( !v26 )
		      goto LABEL_24;
		    namespaze = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)v26, instance, 0LL);
		    this = (TerrainSubsurfaceData *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_10:
		    v8 = instance[1].klass;
		    if ( !v8 )
		      goto LABEL_24;
		    namespaze = (int32_t)v8->_0.namespaze;
		  }
		  v10 = namespaze == 1;
		  v11 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
		  ref = 128;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		    v11 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
		    this = (TerrainSubsurfaceData *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  terrainSimpleSubsurface = v11->static_fields->terrainSimpleSubsurface;
		  if ( !terrainSimpleSubsurface )
		    goto LABEL_24;
		  if ( !LODWORD(this[9]._Params._SubsurfaceCurvatureOffset) )
		  {
		    il2cpp_runtime_class_init_1(this);
		    this = (TerrainSubsurfaceData *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  SubsurfaceProfile = this[7]._SubsurfaceProfile->klass;
		  if ( !SubsurfaceProfile )
		    goto LABEL_24;
		  if ( *((int *)SubsurfaceProfile + 6) <= 412 )
		  {
		LABEL_19:
		    m_defaultValue = terrainSimpleSubsurface->fields.m_defaultValue;
		    goto LABEL_20;
		  }
		  if ( !LODWORD(this[9]._Params._SubsurfaceCurvatureOffset) )
		  {
		    il2cpp_runtime_class_init_1(this);
		    this = (TerrainSubsurfaceData *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  SubsurfaceProfile = this[7]._SubsurfaceProfile->klass;
		  if ( !SubsurfaceProfile )
		LABEL_24:
		    sub_1800D8260(SubsurfaceProfile, this);
		  if ( *((_DWORD *)SubsurfaceProfile + 6) <= 0x19Cu )
		LABEL_46:
		    sub_1800D2AB0(SubsurfaceProfile, this);
		  if ( !*((_QWORD *)SubsurfaceProfile + 416) )
		    goto LABEL_19;
		  v27 = IFix::WrappersManagerImpl::GetPatch(412, 0LL);
		  if ( !v27 )
		    goto LABEL_24;
		  m_defaultValue = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                     (ILFixDynamicMethodWrapper_20 *)v27,
		                     (Object *)terrainSimpleSubsurface,
		                     0LL);
		LABEL_20:
		  UseSubsurfaceProfile = v4->_Params._UseSubsurfaceProfile;
		  if ( !m_defaultValue )
		  {
		    v10 = v4->_Params._UseSubsurfaceProfile;
		    if ( !UseSubsurfaceProfile )
		      goto LABEL_22;
		LABEL_48:
		    HG::Rendering::Runtime::HGStencilUtils::SetStencilValueByMask(
		      &ref,
		      2,
		      HGStencilUtils_HGStencilBitMask__Enum_DeferredShadingModel,
		      0LL);
		    goto LABEL_22;
		  }
		  if ( UseSubsurfaceProfile && v10 )
		    goto LABEL_48;
		LABEL_22:
		  v15 = v4->_Params._UseSubsurfaceProfile;
		  SubsurfaceCurvatureOffset = v4->_Params._SubsurfaceCurvatureOffset;
		  *(_OWORD *)&v28.m_useSubsurfaceProfile = 0LL;
		  v28.m_useSubsurfaceProfile = v15;
		  SubsurfaceCurvatureScale = v4->_Params._SubsurfaceCurvatureScale;
		  m_terrainStencil = ref;
		  v28.m_enableSubsurfaceProfileKeyword = v10;
		  v19 = _mm_shuffle_ps(*(__m128 *)&v28.m_useSubsurfaceProfile, *(__m128 *)&v28.m_useSubsurfaceProfile, 225);
		  v19.m128_f32[0] = SubsurfaceCurvatureScale;
		  v20 = _mm_shuffle_ps(v19, v19, 198);
		  v20.m128_f32[0] = SubsurfaceCurvatureOffset;
		  *(__m128 *)&retstr->m_useSubsurfaceProfile = _mm_shuffle_ps(v20, v20, 201);
		LABEL_23:
		  retstr->m_terrainStencil = m_terrainStencil;
		  return retstr;
		}
		
	}
}
