using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGVolumetricFogRenderer // TypeDefIndex: 37660
	{
		// Fields
		public static readonly HGVolumetricFogSettingParameters s_settingParameters; // 0x00
		private static readonly MaterialPropertyBlock s_voxelizationMaterialPropertyBlock; // 0x08
	
		// Properties
		public static bool supportVolumetricFog { get => default; } // 0x0000000183B9C5C0-0x0000000183B9C680 
		// Boolean get_supportVolumetricFog()
		bool HG::Rendering::Runtime::HGVolumetricFogRenderer::get_supportVolumetricFog(MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *static_fields; // rdx
		  int *wrapperArray; // rcx
		  Object *instance; // rbx
		  struct ILFixDynamicMethodWrapper_2__Class *v4; // rax
		  Object__Class *klass; // rax
		  int32_t namespaze; // eax
		  ILFixDynamicMethodWrapper_2 *v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (int *)static_fields->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_13;
		  if ( wrapperArray[6] <= 957 )
		    goto LABEL_5;
		  if ( !static_fields->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(static_fields);
		    static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (struct ILFixDynamicMethodWrapper_2__Class *)static_fields->static_fields->wrapperArray;
		  if ( !static_fields )
		    goto LABEL_13;
		  if ( LODWORD(static_fields->_0.namespaze) <= 0x3BD )
		    goto LABEL_28;
		  if ( !static_fields[20]._0.implementedInterfaces )
		  {
		LABEL_5:
		    instance = (Object *)HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
		    if ( !instance )
		      goto LABEL_13;
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (struct ILFixDynamicMethodWrapper_2__Class *)v4->static_fields;
		    wrapperArray = (int *)static_fields->_0.image;
		    if ( !static_fields->_0.image )
		      goto LABEL_13;
		    if ( wrapperArray[6] <= 672 )
		      goto LABEL_10;
		    if ( !v4->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v4);
		      v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = (int *)v4->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_13;
		    if ( (unsigned int)wrapperArray[6] > 0x2A0 )
		    {
		      if ( *((_QWORD *)wrapperArray + 676) )
		      {
		        Patch = IFix::WrappersManagerImpl::GetPatch(672, 0LL);
		        if ( Patch )
		        {
		          namespaze = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                        (ILFixDynamicMethodWrapper_31 *)Patch,
		                        instance,
		                        0LL);
		          return namespaze != 1;
		        }
		LABEL_13:
		        sub_1800D8260(wrapperArray, static_fields);
		      }
		LABEL_10:
		      klass = instance[1].klass;
		      if ( klass )
		      {
		        namespaze = (int32_t)klass->_0.namespaze;
		        return namespaze != 1;
		      }
		      goto LABEL_13;
		    }
		LABEL_28:
		    sub_1800D2AB0(wrapperArray, static_fields);
		  }
		  v8 = IFix::WrappersManagerImpl::GetPatch(957, 0LL);
		  if ( !v8 )
		    goto LABEL_13;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_4((ILFixDynamicMethodWrapper_23 *)v8, 0LL);
		}
		
	
		// Nested types
		public class HGVolumetricFogSettingParameters // TypeDefIndex: 37656
		{
			// Fields
			public const string FEATURE_NAME = "VolumetricFog"; // Metadata: 0x02303040
			public readonly SettingParameter<bool> enableVolumetricFog; // 0x10
			public readonly SettingParameter<int> gridPixelSize; // 0x18
			public readonly SettingParameter<int> gridSizeZ; // 0x20
			public readonly SettingParameter<int> maxSourceRTWidth; // 0x28
			public readonly SettingParameter<int> maxSourceRTHeight; // 0x30
			public readonly SettingParameter<int> depthDistributionScale; // 0x38
			public readonly SettingParameter<int> historyMissSuperSampleCount; // 0x40
			public readonly SettingParameter<float> fogHistoryWeight; // 0x48
			public readonly SettingParameter<float> lightScatteringSampleJitterMultiplier; // 0x50
			public readonly SettingParameter<float> upsampleJitterMultiplier; // 0x58
			public readonly SettingParameter<bool> enableTemporalReprojection; // 0x60
			public readonly SettingParameter<bool> enablePunctualLightShadow; // 0x68
			public readonly SettingParameter<bool> enableEmissiveVBufferB; // 0x70
			public readonly SettingParameter<bool> enableScalarizeDynamicLightLoop; // 0x78
	
			// Properties
			public Vector2Int maxSourceRTSize { get => default; } // 0x0000000189CEEF40-0x0000000189CEEFB8 
			// Vector2Int get_maxSourceRTSize()
			Vector2Int HG::Rendering::Runtime::HGVolumetricFogRenderer::HGVolumetricFogSettingParameters::get_maxSourceRTSize(
			        HGVolumetricFogRenderer_HGVolumetricFogSettingParameters *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  Vector2Int v7; // [rsp+40h] [rbp+18h]
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1532, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1532, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v6, v5);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_283(Patch, (Object *)this, 0LL);
			  }
			  else
			  {
			    v7.m_X = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			               (SettingParameter_1_System_Int32Enum_ *)this->fields.maxSourceRTWidth,
			               MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			    v7.m_Y = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			               (SettingParameter_1_System_Int32Enum_ *)this->fields.maxSourceRTHeight,
			               MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			    return v7;
			  }
			}
			
	
			// Constructors
			public HGVolumetricFogSettingParameters() {} // 0x00000001848FD250-0x00000001848FD4C0
			// HGVolumetricFogRenderer+HGVolumetricFogSettingParameters()
			void HG::Rendering::Runtime::HGVolumetricFogRenderer::HGVolumetricFogSettingParameters::HGVolumetricFogSettingParameters(
			        HGVolumetricFogRenderer_HGVolumetricFogSettingParameters *this,
			        MethodInfo *method)
			{
			  HGRuntimeGrassQuery_Node *v3; // rdx
			  HGRuntimeGrassQuery_Node *v4; // r8
			  Int32__Array **v5; // r9
			  HGRuntimeGrassQuery_Node *v6; // rdx
			  HGRuntimeGrassQuery_Node *v7; // r8
			  Int32__Array **v8; // r9
			  HGRuntimeGrassQuery_Node *v9; // rdx
			  HGRuntimeGrassQuery_Node *v10; // r8
			  Int32__Array **v11; // r9
			  HGRuntimeGrassQuery_Node *v12; // rdx
			  HGRuntimeGrassQuery_Node *v13; // r8
			  Int32__Array **v14; // r9
			  HGRuntimeGrassQuery_Node *v15; // rdx
			  HGRuntimeGrassQuery_Node *v16; // r8
			  Int32__Array **v17; // r9
			  HGRuntimeGrassQuery_Node *v18; // rdx
			  HGRuntimeGrassQuery_Node *v19; // r8
			  Int32__Array **v20; // r9
			  HGRuntimeGrassQuery_Node *v21; // rdx
			  HGRuntimeGrassQuery_Node *v22; // r8
			  Int32__Array **v23; // r9
			  HGRuntimeGrassQuery_Node *v24; // rdx
			  HGRuntimeGrassQuery_Node *v25; // r8
			  Int32__Array **v26; // r9
			  HGRuntimeGrassQuery_Node *v27; // rdx
			  HGRuntimeGrassQuery_Node *v28; // r8
			  Int32__Array **v29; // r9
			  HGRuntimeGrassQuery_Node *v30; // rdx
			  HGRuntimeGrassQuery_Node *v31; // r8
			  Int32__Array **v32; // r9
			  HGRuntimeGrassQuery_Node *v33; // rdx
			  HGRuntimeGrassQuery_Node *v34; // r8
			  Int32__Array **v35; // r9
			  HGRuntimeGrassQuery_Node *v36; // rdx
			  HGRuntimeGrassQuery_Node *v37; // r8
			  Int32__Array **v38; // r9
			  HGRuntimeGrassQuery_Node *v39; // rdx
			  HGRuntimeGrassQuery_Node *v40; // r8
			  Int32__Array **v41; // r9
			  HGRuntimeGrassQuery_Node *v42; // rdx
			  HGRuntimeGrassQuery_Node *v43; // r8
			  Int32__Array **v44; // r9
			  MethodInfo *v45; // [rsp+20h] [rbp-8h]
			  MethodInfo *v46; // [rsp+20h] [rbp-8h]
			  MethodInfo *v47; // [rsp+20h] [rbp-8h]
			  MethodInfo *v48; // [rsp+20h] [rbp-8h]
			  MethodInfo *v49; // [rsp+20h] [rbp-8h]
			  MethodInfo *v50; // [rsp+20h] [rbp-8h]
			  MethodInfo *v51; // [rsp+20h] [rbp-8h]
			  MethodInfo *v52; // [rsp+20h] [rbp-8h]
			  MethodInfo *v53; // [rsp+20h] [rbp-8h]
			  MethodInfo *v54; // [rsp+20h] [rbp-8h]
			  MethodInfo *v55; // [rsp+20h] [rbp-8h]
			  MethodInfo *v56; // [rsp+20h] [rbp-8h]
			  MethodInfo *v57; // [rsp+20h] [rbp-8h]
			  MethodInfo *v58; // [rsp+50h] [rbp+28h]
			
			  this->fields.enableVolumetricFog = HG::Rendering::Runtime::SettingParameter::Create<bool>(
			                                       1,
			                                       (String *)"VolumetricFog",
			                                       (String *)"enableVolumetricFog",
			                                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v3, v4, v5, v45);
			  this->fields.gridPixelSize = HG::Rendering::Runtime::SettingParameter::Create<int>(
			                                 8,
			                                 (String *)"VolumetricFog",
			                                 (String *)"gridPixelSize",
			                                 MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.gridPixelSize, v6, v7, v8, v46);
			  this->fields.gridSizeZ = HG::Rendering::Runtime::SettingParameter::Create<int>(
			                             128,
			                             (String *)"VolumetricFog",
			                             (String *)"gridSizeZ",
			                             MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.gridSizeZ, v9, v10, v11, v47);
			  this->fields.maxSourceRTWidth = HG::Rendering::Runtime::SettingParameter::Create<int>(
			                                    2560,
			                                    (String *)"VolumetricFog",
			                                    (String *)"maxSourceRTWidth",
			                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.maxSourceRTWidth, v12, v13, v14, v48);
			  this->fields.maxSourceRTHeight = HG::Rendering::Runtime::SettingParameter::Create<int>(
			                                     1440,
			                                     (String *)"VolumetricFog",
			                                     (String *)"maxSourceRTHeight",
			                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.maxSourceRTHeight, v15, v16, v17, v49);
			  this->fields.depthDistributionScale = HG::Rendering::Runtime::SettingParameter::Create<int>(
			                                          32,
			                                          (String *)"VolumetricFog",
			                                          (String *)"depthDistributionScale",
			                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.depthDistributionScale, v18, v19, v20, v50);
			  this->fields.historyMissSuperSampleCount = HG::Rendering::Runtime::SettingParameter::Create<int>(
			                                               4,
			                                               (String *)"VolumetricFog",
			                                               (String *)"historyMissSuperSampleCount",
			                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.historyMissSuperSampleCount, v21, v22, v23, v51);
			  this->fields.fogHistoryWeight = HG::Rendering::Runtime::SettingParameter::Create<float>(
			                                    0.89999998,
			                                    (String *)"VolumetricFog",
			                                    (String *)"fogHistoryWeight",
			                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.fogHistoryWeight, v24, v25, v26, v52);
			  this->fields.lightScatteringSampleJitterMultiplier = HG::Rendering::Runtime::SettingParameter::Create<float>(
			                                                         0.0,
			                                                         (String *)"VolumetricFog",
			                                                         (String *)"lightScatteringSampleJitterMultiplier",
			                                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.lightScatteringSampleJitterMultiplier, v27, v28, v29, v53);
			  this->fields.upsampleJitterMultiplier = HG::Rendering::Runtime::SettingParameter::Create<float>(
			                                            1.5,
			                                            (String *)"VolumetricFog",
			                                            (String *)"upsampleJitterMultiplier",
			                                            MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.upsampleJitterMultiplier, v30, v31, v32, v54);
			  this->fields.enableTemporalReprojection = HG::Rendering::Runtime::SettingParameter::Create<bool>(
			                                              1,
			                                              (String *)"VolumetricFog",
			                                              (String *)"enableTemporalReprojection",
			                                              MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.enableTemporalReprojection, v33, v34, v35, v55);
			  this->fields.enablePunctualLightShadow = HG::Rendering::Runtime::SettingParameter::Create<bool>(
			                                             0,
			                                             (String *)"VolumetricFog",
			                                             (String *)"enablePunctualLightShadow",
			                                             MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.enablePunctualLightShadow, v36, v37, v38, v56);
			  this->fields.enableEmissiveVBufferB = HG::Rendering::Runtime::SettingParameter::Create<bool>(
			                                          0,
			                                          (String *)"VolumetricFog",
			                                          (String *)"enableEmissiveVBufferB",
			                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.enableEmissiveVBufferB, v39, v40, v41, v57);
			  this->fields.enableScalarizeDynamicLightLoop = HG::Rendering::Runtime::SettingParameter::Create<bool>(
			                                                   0,
			                                                   (String *)"VolumetricFog",
			                                                   (String *)"enableScalarizeDynamicLightLoop",
			                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.enableScalarizeDynamicLightLoop, v42, v43, v44, v58);
			}
			
		}
	
		public struct VolumetricFogGridInjectionConstants // TypeDefIndex: 37657
		{
			// Fields
			public Vector4 _VolumetricFogGridInjectionParams0; // 0x00
			public Vector4 _VolumetricFogGridInjectionParams1; // 0x10
		}
	
		public struct VolumetricFogLightScatteringConstants // TypeDefIndex: 37659
		{
			// Fields
			public Vector4 _VolumetricFogGridInjectionParams0; // 0x00
			public Vector4 _VolumetricFogGridInjectionParams1; // 0x10
			public Vector4 _VolumetricFogLightScatteringParams0; // 0x20
			public Vector4 _VolumetricFogLightScatteringParams1; // 0x30
			public Vector4 _VolumetricFogLightScatteringParams2; // 0x40
			public Vector4 _VolumetricFogLightScatteringParams3; // 0x50
			public Vector4 _VolumetricFogLightScatteringParams4; // 0x60
			public Vector4 _VolumetricFogLightScatteringParams5; // 0x70
			public Vector4 _VolumetricFogLightScatteringParams6; // 0x80
			public Vector4 _VolumetricFogLightScatteringParams7; // 0x90
			public Vector4 _VolumetricFogLightScatteringParams8; // 0xA0
			public Vector4 _VolumetricFogLightScatteringParams9; // 0xB0
			public Vector4 _VolumetricFogLightScatteringParams10; // 0xC0
			public Vector4 _VolumetricFogLightScatteringParams11; // 0xD0
			public unsafe fixed /* 0x00000000-0x00000000 */ float _LightScatteringFrameJitterOffsets[0]; // 0xE0
		}
	
		// Constructors
		public HGVolumetricFogRenderer() {} // 0x00000001841E1670-0x00000001841E1680
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
		
		static HGVolumetricFogRenderer() {} // 0x00000001848FD1B0-0x00000001848FD250
		// HGVolumetricFogRenderer()
		void HG::Rendering::Runtime::HGVolumetricFogRenderer::cctor(MethodInfo *method)
		{
		  HGVolumetricFogRenderer_HGVolumetricFogSettingParameters *v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  HGVolumetricFogRenderer_HGVolumetricFogSettingParameters *v4; // rbx
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  __int64 v8; // rbx
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		  MethodInfo *v13; // [rsp+50h] [rbp+28h]
		
		  v1 = (HGVolumetricFogRenderer_HGVolumetricFogSettingParameters *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer::HGVolumetricFogSettingParameters);
		  v4 = v1;
		  if ( !v1
		    || (HG::Rendering::Runtime::HGVolumetricFogRenderer::HGVolumetricFogSettingParameters::HGVolumetricFogSettingParameters(
		          v1,
		          0LL),
		        TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_settingParameters = v4,
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields,
		          v5,
		          v6,
		          v7,
		          v12),
		        (v8 = sub_1800368D0(TypeInfo::UnityEngine::MaterialPropertyBlock)) == 0) )
		  {
		    sub_1800D8260(v3, v2);
		  }
		  *(_QWORD *)(v8 + 16) = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		  static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields;
		  static_fields->monitor = (MonitorData *)v8;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_voxelizationMaterialPropertyBlock,
		    static_fields,
		    v10,
		    v11,
		    v13);
		}
		
	
		// Methods
		public static Vector3Int GetVolumetricFogGridSize(Vector2Int viewRectSize, out Vector2Int volumetricFogGridToPixel) {
			volumetricFogGridToPixel = default;
			return default;
		} // 0x0000000189CED348-0x0000000189CED514
		// Vector3Int GetVolumetricFogGridSize(Vector2Int, Vector2Int ByRef)
		Vector3Int *HG::Rendering::Runtime::HGVolumetricFogRenderer::GetVolumetricFogGridSize(
		        Vector3Int *__return_ptr retstr,
		        Vector2Int viewRectSize,
		        Vector2Int *volumetricFogGridToPixel,
		        MethodInfo *method)
		{
		  HGVolumetricFogRenderer__StaticFields *static_fields; // rdx
		  HGVolumetricFogRenderer_HGVolumetricFogSettingParameters *s_settingParameters; // rcx
		  Vector2Int maxSourceRTSize; // rdi
		  Int32Enum__Enum v10; // eax
		  Vector2Int v11; // rax
		  unsigned __int64 v12; // rdi
		  Int32Enum__Enum v13; // eax
		  int32_t v14; // ebp
		  unsigned __int64 v15; // rcx
		  unsigned __int64 v16; // rax
		  Vector2Int v17; // kr00_8
		  Int32Enum__Enum m_Z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3Int *v20; // rax
		  __int64 v21; // xmm0_8
		  Vector3Int v23[3]; // [rsp+30h] [rbp-28h] BYREF
		  Vector2Int divisora; // [rsp+60h] [rbp+8h]
		  Vector2Int divisor; // [rsp+60h] [rbp+8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1531, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1531, 0LL);
		    if ( Patch )
		    {
		      v20 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_628(v23, Patch, viewRectSize, volumetricFogGridToPixel, 0LL);
		      v21 = *(_QWORD *)&v20->m_X;
		      m_Z = v20->m_Z;
		      *(_QWORD *)&retstr->m_X = v21;
		      goto LABEL_15;
		    }
		LABEL_13:
		    sub_1800D8260(s_settingParameters, static_fields);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		  s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_settingParameters;
		  if ( !s_settingParameters )
		    goto LABEL_13;
		  maxSourceRTSize = HG::Rendering::Runtime::HGVolumetricFogRenderer::HGVolumetricFogSettingParameters::get_maxSourceRTSize(
		                      s_settingParameters,
		                      0LL);
		  s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_settingParameters;
		  if ( !s_settingParameters )
		    goto LABEL_13;
		  v10 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		          (SettingParameter_1_System_Int32Enum_ *)s_settingParameters->fields.gridPixelSize,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  v11 = HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(maxSourceRTSize, v10, 0LL);
		  v12 = (unsigned __int64)HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(viewRectSize, v11, 0LL);
		  s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_settingParameters;
		  if ( !s_settingParameters )
		    goto LABEL_13;
		  v13 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		          (SettingParameter_1_System_Int32Enum_ *)s_settingParameters->fields.gridPixelSize,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  v14 = v13;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields;
		  s_settingParameters = static_fields->s_settingParameters;
		  if ( !static_fields->s_settingParameters )
		    goto LABEL_13;
		  divisora.m_X = v13;
		  divisora.m_Y = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                   (SettingParameter_1_System_Int32Enum_ *)s_settingParameters->fields.gridPixelSize,
		                   MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  v15 = HIDWORD(v12);
		  v16 = HIDWORD(*(unsigned __int64 *)&divisora);
		  if ( (int)v12 <= v14 )
		    LODWORD(v12) = v14;
		  divisor.m_X = v12;
		  if ( (int)v15 <= (int)v16 )
		    LODWORD(v15) = v16;
		  divisor.m_Y = v15;
		  *volumetricFogGridToPixel = divisor;
		  v17 = HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(viewRectSize, divisor, 0LL);
		  s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_settingParameters;
		  if ( !s_settingParameters )
		    goto LABEL_13;
		  m_Z = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		          (SettingParameter_1_System_Int32Enum_ *)s_settingParameters->fields.gridSizeZ,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  *(Vector2Int *)&retstr->m_X = v17;
		LABEL_15:
		  retstr->m_Z = m_Z;
		  return retstr;
		}
		
		private int _GetVolumetricFogZSliceFromDepth(float sceneDepth, Vector3 gridZParams) => default; // 0x0000000189CEEE90-0x0000000189CEEF40
		// Int32 _GetVolumetricFogZSliceFromDepth(Single, Vector3)
		int32_t HG::Rendering::Runtime::HGVolumetricFogRenderer::_GetVolumetricFogZSliceFromDepth(
		        HGVolumetricFogRenderer *this,
		        float sceneDepth,
		        Vector3 *gridZParams,
		        MethodInfo *method)
		{
		  double v6; // xmm0_8
		  float v7; // xmm6_4
		  __int64 v9; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 v12; // [rsp+30h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1536, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1536, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v9);
		    z = gridZParams->z;
		    *(_QWORD *)&v12.x = *(_QWORD *)&gridZParams->x;
		    v12.z = z;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_629(Patch, (Object *)this, sceneDepth, &v12, 0LL);
		  }
		  else
		  {
		    v6 = sub_185F17A74();
		    v7 = *(float *)&v6;
		    sub_1800036A0(TypeInfo::System::MathF);
		    return (int)System::MathF::Truncate(v7 * gridZParams->z, 0LL);
		  }
		}
		
		public static Vector3 GetVolumetricFogGridZParams(float volumetricFogStartDistance, float nearPlane, float farPlane, int gridSizeZ) => default; // 0x0000000189CED514-0x0000000189CED664
		// Vector3 GetVolumetricFogGridZParams(Single, Single, Single, Int32)
		Vector3 *HG::Rendering::Runtime::HGVolumetricFogRenderer::GetVolumetricFogGridZParams(
		        Vector3 *__return_ptr retstr,
		        float volumetricFogStartDistance,
		        float nearPlane,
		        float farPlane,
		        int32_t gridSizeZ,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  HGVolumetricFogRenderer_HGVolumetricFogSettingParameters *s_settingParameters; // rcx
		  float v9; // xmm7_4
		  float v10; // xmm6_4
		  float v11; // xmm0_4
		  float v12; // xmm1_4
		  Vector3 *v13; // rax
		  __int64 v14; // xmm0_8
		  Vector3 v16[4]; // [rsp+40h] [rbp-58h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1537, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1537, 0LL);
		    if ( Patch )
		    {
		      v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_630(
		              v16,
		              Patch,
		              volumetricFogStartDistance,
		              nearPlane,
		              farPlane,
		              gridSizeZ,
		              0LL);
		      v14 = *(_QWORD *)&v13->x;
		      *(float *)&v13 = v13->z;
		      *(_QWORD *)&retstr->x = v14;
		      LODWORD(retstr->z) = (_DWORD)v13;
		      return retstr;
		    }
		LABEL_5:
		    sub_1800D8260(s_settingParameters, Patch);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		  s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_settingParameters;
		  if ( !s_settingParameters )
		    goto LABEL_5;
		  v9 = fmaxf(nearPlane, volumetricFogStartDistance) + 0.094999999;
		  v10 = (float)(int)HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                      (SettingParameter_1_System_Int32Enum_ *)s_settingParameters->fields.depthDistributionScale,
		                      MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  v11 = sub_185F0BFA8();
		  retstr->z = v10;
		  v12 = (float)(farPlane - (float)(v11 * v9)) / (float)(farPlane - v9);
		  retstr->y = v12;
		  retstr->x = (float)(1.0 - v12) / v9;
		  return retstr;
		}
		
		private Vector2 _GetVolumetricFogGridToScreenSVPosRatio(Vector2Int viewRectSize, Vector3Int volumetricFogGridSize, Vector2 volumetricFogGridToPixel) => default; // 0x0000000189CEEDAC-0x0000000189CEEE90
		// Vector2 _GetVolumetricFogGridToScreenSVPosRatio(Vector2Int, Vector3Int, Vector2)
		Vector2 HG::Rendering::Runtime::HGVolumetricFogRenderer::_GetVolumetricFogGridToScreenSVPosRatio(
		        HGVolumetricFogRenderer *this,
		        Vector2Int viewRectSize,
		        Vector3Int *volumetricFogGridSize,
		        Vector2 volumetricFogGridToPixel,
		        MethodInfo *method)
		{
		  MethodInfo *v9; // rdx
		  __m128 v10; // xmm1
		  __m128 v11; // xmm2
		  __int64 v13; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  int32_t m_Z; // eax
		  __int64 v16; // [rsp+30h] [rbp-38h]
		  Vector3Int v17; // [rsp+40h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1538, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1538, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v13);
		    m_Z = volumetricFogGridSize->m_Z;
		    *(_QWORD *)&v17.m_X = *(_QWORD *)&volumetricFogGridSize->m_X;
		    v17.m_Z = m_Z;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_631(
		             Patch,
		             (Object *)this,
		             viewRectSize,
		             &v17,
		             volumetricFogGridToPixel,
		             0LL);
		  }
		  else
		  {
		    v16 = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_185EDCFF4)(
		            _mm_unpacklo_ps(
		              (__m128)COERCE_UNSIGNED_INT((float)volumetricFogGridSize->m_X),
		              (__m128)COERCE_UNSIGNED_INT((float)volumetricFogGridSize->m_Y)).m128_u64[0],
		            volumetricFogGridToPixel);
		    v10 = (__m128)HIDWORD(v16);
		    v11 = (__m128)(unsigned int)v16;
		    *(Vector2 *)&v17.m_X = UnityEngine::Vector2Int::op_Implicit(viewRectSize, v9);
		    v10.m128_f32[0] = *((float *)&v16 + 1) / *(float *)&v17.m_Y;
		    v11.m128_f32[0] = *(float *)&v16 / *(float *)&v17.m_X;
		    return (Vector2)_mm_unpacklo_ps(v11, v10).m128_u64[0];
		  }
		}
		
		public static Vector3 VolumetricFogTemporalRandom(int frameNumber) => default; // 0x0000000189CEEC94-0x0000000189CEEDAC
		// Vector3 VolumetricFogTemporalRandom(Int32)
		Vector3 *HG::Rendering::Runtime::HGVolumetricFogRenderer::VolumetricFogTemporalRandom(
		        Vector3 *__return_ptr retstr,
		        int32_t frameNumber,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGVolumetricFogRenderer_HGVolumetricFogSettingParameters *s_settingParameters; // rcx
		  MethodInfo *v7; // r8
		  Vector3 *v8; // rax
		  int32_t v9; // edi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // xmm0_8
		  float z; // eax
		  __m128i v14; // [rsp+20h] [rbp-20h] BYREF
		  __m128i si128; // [rsp+30h] [rbp-10h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1539, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1539, 0LL);
		    if ( Patch )
		    {
		      v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_632((Vector3 *)&v14, Patch, frameNumber, 0LL);
		      goto LABEL_10;
		    }
		LABEL_8:
		    sub_1800D8260(s_settingParameters, v5);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		  s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_settingParameters;
		  if ( !s_settingParameters )
		    goto LABEL_8;
		  if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		         s_settingParameters->fields.enableTemporalReprojection,
		         MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		  {
		    v9 = frameNumber & 0x3FF;
		    v14.m128i_i32[0] = UnityEngine::Rendering::HaltonSequence::Get(v9, 2, 0LL);
		    v14.m128i_i32[1] = UnityEngine::Rendering::HaltonSequence::Get(v9, 3, 0LL);
		    v14.m128i_i64[1] = COERCE_UNSIGNED_INT(UnityEngine::Rendering::HaltonSequence::Get(v9, 5, 0LL));
		    si128 = v14;
		  }
		  else
		  {
		    si128 = _mm_load_si128((const __m128i *)&xmmword_18DC81130);
		  }
		  v8 = UnityEngine::Vector4::op_Implicit((Vector3 *)&v14, (Vector4 *)&si128, v7);
		LABEL_10:
		  v11 = *(_QWORD *)&v8->x;
		  z = v8->z;
		  *(_QWORD *)&retstr->x = v11;
		  retstr->z = z;
		  return retstr;
		}
		
		public void SetupShaderVariablesGlobalVolumetricFog(ref ShaderVariablesGlobal cb, HGCamera hgCamera) {} // 0x0000000189CEE98C-0x0000000189CEEC94
		// Void SetupShaderVariablesGlobalVolumetricFog(ShaderVariablesGlobal ByRef, HGCamera)
		void HG::Rendering::Runtime::HGVolumetricFogRenderer::SetupShaderVariablesGlobalVolumetricFog(
		        HGVolumetricFogRenderer *this,
		        ShaderVariablesGlobal *cb,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  void *camera; // rcx
		  HGEnvironmentPhase *InterpolatedPhase; // rsi
		  Vector2Int sceneRTSize_k__BackingField; // rbx
		  Vector3Int *VolumetricFogGridSize; // rax
		  float volumetricFogStartDistance; // xmm6_4
		  __int64 v13; // xmm7_8
		  float v14; // ebx
		  float v15; // xmm0_4
		  Vector3 *VolumetricFogGridZParams; // rax
		  __int64 v17; // xmm11_8
		  float z; // r15d
		  MethodInfo *v19; // rdx
		  MethodInfo *v20; // r8
		  __m128 v21; // xmm9
		  __m128 v22; // xmm10
		  float volumetricFogNearFadeInDistance; // xmm0_4
		  float v24; // xmm8_4
		  Vector3 *v25; // rax
		  float volumetricFogDistance; // xmm7_4
		  __int64 v27; // xmm6_8
		  float v28; // ebx
		  Vector4 *v29; // rax
		  Vector4 *v30; // rax
		  Vector2Int v31; // rcx
		  MethodInfo *v32; // rdx
		  Vector2 v33; // rax
		  Animator *v34; // rdx
		  int32_t v35; // r8d
		  MethodInfo *v36; // r9
		  Vector3 *Vector; // rax
		  __int64 v38; // xmm6_8
		  float v39; // ebx
		  float v40; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v42; // [rsp+38h] [rbp-49h] BYREF
		  Vector3 v; // [rsp+48h] [rbp-39h] BYREF
		  Vector4 v44[7]; // [rsp+58h] [rbp-29h] BYREF
		
		  *(_QWORD *)&v.x = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(1540, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		    if ( InterpolatedPhase )
		    {
		      if ( hgCamera )
		      {
		        sceneRTSize_k__BackingField = hgCamera->fields._sceneRTSize_k__BackingField;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		        VolumetricFogGridSize = HG::Rendering::Runtime::HGVolumetricFogRenderer::GetVolumetricFogGridSize(
		                                  (Vector3Int *)&v42,
		                                  sceneRTSize_k__BackingField,
		                                  (Vector2Int *)&v,
		                                  0LL);
		        camera = hgCamera->fields.camera;
		        volumetricFogStartDistance = InterpolatedPhase->fields.volumetricFogConfig.volumetricFogStartDistance;
		        v13 = *(_QWORD *)&VolumetricFogGridSize->m_X;
		        v14 = *(float *)&VolumetricFogGridSize->m_Z;
		        if ( camera )
		        {
		          v15 = UnityEngine::Camera::get_nearClipPlane((Camera *)camera, 0LL);
		          VolumetricFogGridZParams = HG::Rendering::Runtime::HGVolumetricFogRenderer::GetVolumetricFogGridZParams(
		                                       &v42,
		                                       volumetricFogStartDistance,
		                                       v15,
		                                       InterpolatedPhase->fields.volumetricFogConfig.volumetricFogDistance,
		                                       SLODWORD(v14),
		                                       0LL);
		          v17 = *(_QWORD *)&VolumetricFogGridZParams->x;
		          z = VolumetricFogGridZParams->z;
		          *(Vector2 *)&v42.x = UnityEngine::Vector2Int::op_Implicit(hgCamera->fields._sceneRTSize_k__BackingField, v19);
		          v21 = (__m128)0x3F800000u;
		          v21.m128_f32[0] = 1.0 / v42.x;
		          v22 = (__m128)0x3F800000u;
		          v22.m128_f32[0] = 1.0 / v42.y;
		          volumetricFogNearFadeInDistance = InterpolatedPhase->fields.volumetricFogConfig.volumetricFogNearFadeInDistance;
		          v24 = volumetricFogNearFadeInDistance <= 0.0 ? 1000000.0 : 1.0 / volumetricFogNearFadeInDistance;
		          *(_QWORD *)&v42.x = v13;
		          v42.z = v14;
		          v25 = UnityEngine::Vector3Int::op_Implicit((Vector3 *)v44, (Vector3Int *)&v42, v20);
		          volumetricFogDistance = InterpolatedPhase->fields.volumetricFogConfig.volumetricFogDistance;
		          v27 = *(_QWORD *)&v25->x;
		          v28 = v25->z;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		          *(_QWORD *)&v42.x = v27;
		          v42.z = v28;
		          v29 = HG::Rendering::Runtime::HGUtils::PackVector4(v44, &v42, volumetricFogDistance, 0LL);
		          *(_QWORD *)&v42.x = v17;
		          v42.z = z;
		          *(__m128i *)&cb->_CharacterParams13.w = _mm_loadu_si128((const __m128i *)v29);
		          v30 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                  v44,
		                  &v42,
		                  InterpolatedPhase->fields.volumetricFogConfig.volumetricFogScatteringDistribution,
		                  0LL);
		          v31 = *(Vector2Int *)&v.x;
		          *(__m128i *)&cb->_CharacterParams14.w = _mm_loadu_si128((const __m128i *)v30);
		          v33 = UnityEngine::Vector2Int::op_Implicit(v31, v32);
		          *(__m128i *)&cb->_CharacterParams15.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                                     v44,
		                                                                                     (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v21, v22),
		                                                                                     v33,
		                                                                                     0LL));
		          *(__m128i *)&cb->_CharacterParams16.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                                     v44,
		                                                                                     InterpolatedPhase->fields.volumetricFogConfig.volumetricFogDirectLightingScatteringIntensity,
		                                                                                     InterpolatedPhase->fields.volumetricFogConfig.volumetricFogSkyLightingScatteringIntensity,
		                                                                                     InterpolatedPhase->fields.volumetricFogConfig.volumetricFogStartDistance,
		                                                                                     v24,
		                                                                                     0LL));
		          Vector = UnityEngine::Animator::GetVector((Vector3 *)v44, v34, v35, v36);
		          v38 = *(_QWORD *)&Vector->x;
		          v39 = Vector->z;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		          camera = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_settingParameters;
		          if ( camera )
		          {
		            v40 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                    *((SettingParameter_1_System_Single_ **)camera + 11),
		                    MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		            *(_QWORD *)&v.x = v38;
		            v.z = v39;
		            *(__m128i *)&cb->_InkSimulationWorldToUV.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                                                                            v44,
		                                                                                            &v,
		                                                                                            v40,
		                                                                                            0LL));
		            return;
		          }
		        }
		      }
		    }
		LABEL_11:
		    sub_1800D8260(camera, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1540, 0LL);
		  if ( !Patch )
		    goto LABEL_11;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_373(Patch, (Object *)this, cb, (Object *)hgCamera, 0LL);
		}
		
		public static void ResetShaderVariablesGlobalVolumetricFog(ref ShaderVariablesGlobal cb) {} // 0x0000000189CEE4BC-0x0000000189CEE574
		// Void ResetShaderVariablesGlobalVolumetricFog(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::HGVolumetricFogRenderer::ResetShaderVariablesGlobalVolumetricFog(
		        ShaderVariablesGlobal *cb,
		        MethodInfo *method)
		{
		  TileBase *v3; // rdx
		  Vector3Int *v4; // r8
		  ITilemap *v5; // r9
		  TileBase *v6; // rdx
		  Vector3Int *v7; // r8
		  ITilemap *v8; // r9
		  TileBase *v9; // rdx
		  Vector3Int *v10; // r8
		  ITilemap *v11; // r9
		  TileBase *v12; // rdx
		  Vector3Int *v13; // r8
		  ITilemap *v14; // r9
		  TileBase *v15; // rdx
		  Vector3Int *v16; // r8
		  ITilemap *v17; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  TileAnimationData v21; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1542, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1542, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v20, v19);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_585(Patch, cb, 0LL);
		  }
		  else
		  {
		    *(__m128i *)&cb->_CharacterParams13.w = _mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                                                               &v21,
		                                                                               v3,
		                                                                               v4,
		                                                                               v5,
		                                                                               (MethodInfo *)v21.m_AnimatedSprites));
		    *(__m128i *)&cb->_CharacterParams14.w = _mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                                                               &v21,
		                                                                               v6,
		                                                                               v7,
		                                                                               v8,
		                                                                               (MethodInfo *)v21.m_AnimatedSprites));
		    *(__m128i *)&cb->_CharacterParams15.w = _mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                                                               &v21,
		                                                                               v9,
		                                                                               v10,
		                                                                               v11,
		                                                                               (MethodInfo *)v21.m_AnimatedSprites));
		    *(__m128i *)&cb->_CharacterParams16.w = _mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                                                               &v21,
		                                                                               v12,
		                                                                               v13,
		                                                                               v14,
		                                                                               (MethodInfo *)v21.m_AnimatedSprites));
		    *(__m128i *)&cb->_InkSimulationWorldToUV.w = _mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                                                                    &v21,
		                                                                                    v15,
		                                                                                    v16,
		                                                                                    v17,
		                                                                                    (MethodInfo *)v21.m_AnimatedSprites));
		  }
		}
		
		public void SetupComputeVolumetricFogPassData(VolumetricFogPassConstructor.ComputeVolumetricFogPassData passData) {} // 0x0000000189CEE574-0x0000000189CEE98C
		// Void SetupComputeVolumetricFogPassData(VolumetricFogPassConstructor+ComputeVolumetricFogPassData)
		void HG::Rendering::Runtime::HGVolumetricFogRenderer::SetupComputeVolumetricFogPassData(
		        HGVolumetricFogRenderer *this,
		        VolumetricFogPassConstructor_ComputeVolumetricFogPassData *passData,
		        MethodInfo *method)
		{
		  HGCamera *v5; // rdx
		  unsigned __int64 m_Z; // rcx
		  HGCamera *hgCamera; // rbx
		  HGCamera *v8; // rbx
		  HGEnvironmentPhase *InterpolatedPhase; // rsi
		  HGCamera *v10; // rbx
		  Vector2Int sceneRTSize_k__BackingField; // rbx
		  Vector3Int *VolumetricFogGridSize; // rax
		  __int64 v13; // xmm0_8
		  HGCamera *v14; // rax
		  float volumetricFogStartDistance; // xmm6_4
		  float v16; // xmm0_4
		  Vector3 *VolumetricFogGridZParams; // rax
		  float z; // ecx
		  Vector3 *v19; // rax
		  __int64 v20; // xmm0_8
		  MethodInfo *v21; // r9
		  Vector3 *v22; // rax
		  float v23; // ecx
		  HGCamera *v24; // rax
		  Object_1 *historyVolumetricLightScatteringTexture; // rbx
		  Vector3Int *WidthHeightAndVolumeDepth; // rax
		  float v27; // ecx
		  __int64 v28; // xmm0_8
		  char v29; // al
		  int32_t memoryless_k__BackingField; // eax
		  __int128 v31; // xmm1
		  __int128 v32; // xmm0
		  Int32Enum__Enum v33; // eax
		  int32_t v34; // esi
		  __int64 v35; // r14
		  uint32_t CameraFrameCount; // ebx
		  Vector3 *v37; // rax
		  __int64 v38; // xmm0_8
		  MethodInfo *v39; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v41; // [rsp+48h] [rbp-29h] BYREF
		  Vector3 v42; // [rsp+58h] [rbp-19h] BYREF
		  NativeArray_1_UnityEngine_Vector4_ volumetricFogEmissive; // [rsp+68h] [rbp-9h] BYREF
		  RenderTextureDescriptor v44; // [rsp+78h] [rbp+7h] BYREF
		
		  memset(&v44, 0, sizeof(v44));
		  if ( IFix::WrappersManagerImpl::IsPatched(1543, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1543, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)passData,
		        0LL);
		      return;
		    }
		    goto LABEL_26;
		  }
		  if ( !passData )
		    goto LABEL_26;
		  hgCamera = passData->fields.hgCamera;
		  if ( !hgCamera )
		    goto LABEL_26;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(
		    &hgCamera->fields.volumetricIntegratedLightScatteringTexture,
		    0LL);
		  v8 = passData->fields.hgCamera;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(v8, 0LL);
		  if ( !InterpolatedPhase )
		    goto LABEL_26;
		  v10 = passData->fields.hgCamera;
		  if ( !v10 )
		    goto LABEL_26;
		  sceneRTSize_k__BackingField = v10->fields._sceneRTSize_k__BackingField;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		  VolumetricFogGridSize = HG::Rendering::Runtime::HGVolumetricFogRenderer::GetVolumetricFogGridSize(
		                            (Vector3Int *)&v42,
		                            sceneRTSize_k__BackingField,
		                            &passData->fields.volumetricFogGridToPixel,
		                            0LL);
		  m_Z = (unsigned int)VolumetricFogGridSize->m_Z;
		  v13 = *(_QWORD *)&VolumetricFogGridSize->m_X;
		  v14 = passData->fields.hgCamera;
		  *(_QWORD *)&passData->fields.volumetricFogGridSize.m_X = v13;
		  passData->fields.volumetricFogGridSize.m_Z = m_Z;
		  volumetricFogStartDistance = InterpolatedPhase->fields.volumetricFogConfig.volumetricFogStartDistance;
		  if ( !v14 )
		    goto LABEL_26;
		  m_Z = (unsigned __int64)v14->fields.camera;
		  if ( !m_Z )
		    goto LABEL_26;
		  v16 = UnityEngine::Camera::get_nearClipPlane((Camera *)m_Z, 0LL);
		  VolumetricFogGridZParams = HG::Rendering::Runtime::HGVolumetricFogRenderer::GetVolumetricFogGridZParams(
		                               &v42,
		                               volumetricFogStartDistance,
		                               v16,
		                               InterpolatedPhase->fields.volumetricFogConfig.volumetricFogDistance,
		                               passData->fields.volumetricFogGridSize.m_Z,
		                               0LL);
		  z = VolumetricFogGridZParams->z;
		  *(_QWORD *)&passData->fields.volumetricFogZParams.x = *(_QWORD *)&VolumetricFogGridZParams->x;
		  passData->fields.volumetricFogZParams.z = z;
		  passData->fields.volumetricFogDistance = InterpolatedPhase->fields.volumetricFogConfig.volumetricFogDistance;
		  volumetricFogEmissive = (NativeArray_1_UnityEngine_Vector4_)InterpolatedPhase->fields.volumetricFogConfig.volumetricFogEmissive;
		  v19 = HG::Rendering::Runtime::VectorSwizzleUtils::rgb(&v42, (Color *)&volumetricFogEmissive, 0LL);
		  v20 = *(_QWORD *)&v19->x;
		  *(float *)&v19 = v19->z;
		  *(_QWORD *)&v41.x = v20;
		  LODWORD(v41.z) = (_DWORD)v19;
		  v22 = UnityEngine::Vector3::op_Multiply(&v42, (Vector3 *)&v41, 0.001, v21);
		  v23 = v22->z;
		  *(_QWORD *)&passData->fields.volumetricFogEmissive.x = *(_QWORD *)&v22->x;
		  passData->fields.volumetricFogEmissive.z = v23;
		  m_Z = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_settingParameters;
		  if ( !m_Z )
		    goto LABEL_26;
		  if ( !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		          *(SettingParameter_1_System_Boolean_ **)(m_Z + 96),
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		    goto LABEL_15;
		  v24 = passData->fields.hgCamera;
		  if ( !v24 )
		    goto LABEL_26;
		  if ( !v24->fields.prevTransformReset
		    && (historyVolumetricLightScatteringTexture = (Object_1 *)v24->fields.historyVolumetricLightScatteringTexture,
		        sub_1800036A0(TypeInfo::UnityEngine::Object),
		        UnityEngine::Object::op_Inequality(historyVolumetricLightScatteringTexture, 0LL, 0LL)) )
		  {
		    v5 = passData->fields.hgCamera;
		    if ( !v5 )
		      goto LABEL_26;
		    WidthHeightAndVolumeDepth = HG::Rendering::Runtime::HGVolumetricFogUtils::GetWidthHeightAndVolumeDepth(
		                                  (Vector3Int *)&volumetricFogEmissive,
		                                  v5->fields.historyVolumetricLightScatteringTexture,
		                                  0LL);
		    v27 = *(float *)&passData->fields.volumetricFogGridSize.m_Z;
		    *(_QWORD *)&v41.x = *(_QWORD *)&passData->fields.volumetricFogGridSize.m_X;
		    v28 = *(_QWORD *)&WidthHeightAndVolumeDepth->m_X;
		    LODWORD(WidthHeightAndVolumeDepth) = WidthHeightAndVolumeDepth->m_Z;
		    v41.z = v27;
		    *(_QWORD *)&v42.x = v28;
		    LODWORD(v42.z) = (_DWORD)WidthHeightAndVolumeDepth;
		    v29 = sub_18347A010(&v42, &v41);
		  }
		  else
		  {
		LABEL_15:
		    v29 = 0;
		  }
		  passData->fields.temporalHistoryIsValid = v29;
		  UnityEngine::RenderTextureDescriptor::RenderTextureDescriptor(
		    &v44,
		    passData->fields.volumetricFogGridSize.m_X,
		    passData->fields.volumetricFogGridSize.m_Y,
		    GraphicsFormat__Enum_R16G16B16A16_SFloat,
		    0,
		    1,
		    0LL);
		  v44._dimension_k__BackingField = 3;
		  v44._volumeDepth_k__BackingField = passData->fields.volumetricFogGridSize.m_Z;
		  UnityEngine::RenderTextureDescriptor::set_autoGenerateMips(&v44, 0, 0LL);
		  UnityEngine::RenderTextureDescriptor::set_enableRandomWrite(&v44, 1, 0LL);
		  memoryless_k__BackingField = v44._memoryless_k__BackingField;
		  v31 = *(_OWORD *)&v44._mipCount_k__BackingField;
		  *(_OWORD *)&passData->fields.volumeDesc._width_k__BackingField = *(_OWORD *)&v44._width_k__BackingField;
		  v32 = *(_OWORD *)&v44._dimension_k__BackingField;
		  *(_OWORD *)&passData->fields.volumeDesc._mipCount_k__BackingField = v31;
		  *(_OWORD *)&passData->fields.volumeDesc._dimension_k__BackingField = v32;
		  passData->fields.volumeDesc._memoryless_k__BackingField = memoryless_k__BackingField;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		  m_Z = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_settingParameters;
		  if ( !m_Z )
		LABEL_26:
		    sub_1800D8260(m_Z, v5);
		  v33 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		          *(SettingParameter_1_System_Int32Enum_ **)(m_Z + 64),
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  if ( (int)v33 < 1 )
		  {
		    v33 = 1;
		  }
		  else if ( (int)v33 > 16 )
		  {
		    v33 = 16;
		  }
		  passData->fields.historyMissSuperSampleCount = v33;
		  volumetricFogEmissive = 0LL;
		  Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray(
		    &volumetricFogEmissive,
		    16,
		    Allocator__Enum_Temp,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
		  v34 = 0;
		  v35 = 0LL;
		  passData->fields.frameJitterOffsetValues = volumetricFogEmissive;
		  while ( v34 < passData->fields.historyMissSuperSampleCount )
		  {
		    m_Z = (unsigned __int64)passData->fields.hgCamera;
		    if ( !m_Z )
		      goto LABEL_26;
		    CameraFrameCount = HG::Rendering::Runtime::HGCamera::GetCameraFrameCount((HGCamera *)m_Z, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		    v37 = HG::Rendering::Runtime::HGVolumetricFogRenderer::VolumetricFogTemporalRandom(
		            (Vector3 *)&volumetricFogEmissive,
		            CameraFrameCount - v34,
		            0LL);
		    v38 = *(_QWORD *)&v37->x;
		    *(float *)&v37 = v37->z;
		    *(_QWORD *)&v42.x = v38;
		    LODWORD(v42.z) = (_DWORD)v37;
		    ++v34;
		    *(__m128i *)&passData->fields.frameJitterOffsetValues.m_Buffer[v35] = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(&v41, &v42, v39));
		    v35 += 16LL;
		  }
		}
		
		public void ComputeVolumetricFogGridInjection(CommandBuffer cmd, ScriptableRenderContext renderContext, bool hasGridInjectionPass, VolumetricFogPassConstructor.ComputeVolumetricFogPassData passData) {} // 0x0000000189CEBF4C-0x0000000189CEC3FC
		// Void ComputeVolumetricFogGridInjection(CommandBuffer, ScriptableRenderContext, Boolean, VolumetricFogPassConstructor+ComputeVolumetricFogPassData)
		void HG::Rendering::Runtime::HGVolumetricFogRenderer::ComputeVolumetricFogGridInjection(
		        HGVolumetricFogRenderer *this,
		        CommandBuffer *cmd,
		        ScriptableRenderContext renderContext,
		        bool hasGridInjectionPass,
		        VolumetricFogPassConstructor_ComputeVolumetricFogPassData *passData,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  void *Patch; // rcx
		  VolumetricFogPassConstructor_ComputeVolumetricFogPassData *v11; // rdi
		  int32_t memoryless_k__BackingField; // eax
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  HGRuntimeGrassQuery_Node *v15; // rdx
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  HGRuntimeGrassQuery_Node *v18; // rdx
		  HGRuntimeGrassQuery_Node *v19; // r8
		  Int32__Array **v20; // r9
		  int32_t v21; // eax
		  __int128 v22; // xmm1
		  __int128 v23; // xmm0
		  RenderTexture *v24; // rax
		  HGCamera *hgCamera; // rbx
		  __int64 v26; // rdx
		  HGVolumetricFogRenderer_HGVolumetricFogSettingParameters *s_settingParameters; // rcx
		  HGEnvironmentPhase *InterpolatedPhase; // r15
		  ComputeShader *volumetricFogGridInjectionCS; // r14
		  bool v30; // al
		  Vector3 *v31; // rax
		  float volumetricFogExtinctionScale; // xmm7_4
		  __int64 v33; // xmm6_8
		  float z; // ebx
		  Vector4 *v35; // rax
		  __m128i v36; // xmm6
		  __m128i v37; // xmm0
		  CBHandle *v38; // rax
		  __m128i v39; // xmm6
		  int32_t VolumetricFogVBufferA; // ebx
		  RenderTargetIdentifier *v41; // rax
		  __int128 v42; // xmm1
		  int32_t VolumetricFogVBufferB; // ebx
		  RenderTargetIdentifier *v44; // rax
		  __int128 v45; // xmm1
		  int32_t m_Z; // eax
		  Vector3Int *v47; // rax
		  MethodInfo *offset; // [rsp+28h] [rbp-E0h]
		  MethodInfo *offseta; // [rsp+28h] [rbp-E0h]
		  __int64 threadGroupsX; // [rsp+48h] [rbp-C0h] BYREF
		  LocalKeyword keyword; // [rsp+50h] [rbp-B8h] BYREF
		  __int128 v52; // [rsp+68h] [rbp-A0h]
		  __int64 v53; // [rsp+78h] [rbp-90h]
		  RenderTextureDescriptor v54; // [rsp+88h] [rbp-80h] BYREF
		  LocalKeyword v55; // [rsp+C8h] [rbp-40h] BYREF
		  Void source[16]; // [rsp+E0h] [rbp-28h] BYREF
		  __m128i v57; // [rsp+F0h] [rbp-18h]
		  ScriptableRenderContext P2; // [rsp+158h] [rbp+50h] BYREF
		
		  P2.m_Ptr = renderContext.m_Ptr;
		  if ( IFix::WrappersManagerImpl::IsPatched(1545, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1545, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_637(
		        (ILFixDynamicMethodWrapper_2 *)Patch,
		        (Object *)this,
		        (Object *)cmd,
		        P2,
		        hasGridInjectionPass,
		        (Object *)passData,
		        0LL);
		      return;
		    }
		LABEL_14:
		    sub_1800D8260(Patch, v9);
		  }
		  if ( !hasGridInjectionPass )
		    return;
		  v11 = passData;
		  if ( !passData )
		    goto LABEL_14;
		  memoryless_k__BackingField = passData->fields.volumeDesc._memoryless_k__BackingField;
		  v13 = *(_OWORD *)&passData->fields.volumeDesc._mipCount_k__BackingField;
		  *(_OWORD *)&v54._width_k__BackingField = *(_OWORD *)&passData->fields.volumeDesc._width_k__BackingField;
		  v14 = *(_OWORD *)&passData->fields.volumeDesc._dimension_k__BackingField;
		  v54._memoryless_k__BackingField = memoryless_k__BackingField;
		  *(_OWORD *)&v54._mipCount_k__BackingField = v13;
		  *(_OWORD *)&v54._dimension_k__BackingField = v14;
		  v11->fields.vBufferA = HG::Rendering::Runtime::HGVolumetricFogUtils::GetAndCreateTemporaryRenderTexture(
		                           &v54,
		                           (String *)"_VolumetricFogVBufferA",
		                           0LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v11->fields.vBufferA, v15, v16, v17, offset);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		  Patch = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_settingParameters;
		  if ( !Patch )
		    goto LABEL_14;
		  if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		         *((SettingParameter_1_System_Boolean_ **)Patch + 14),
		         MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		  {
		    v21 = v11->fields.volumeDesc._memoryless_k__BackingField;
		    v22 = *(_OWORD *)&v11->fields.volumeDesc._mipCount_k__BackingField;
		    *(_OWORD *)&v54._width_k__BackingField = *(_OWORD *)&v11->fields.volumeDesc._width_k__BackingField;
		    v23 = *(_OWORD *)&v11->fields.volumeDesc._dimension_k__BackingField;
		    v54._memoryless_k__BackingField = v21;
		    *(_OWORD *)&v54._mipCount_k__BackingField = v22;
		    *(_OWORD *)&v54._dimension_k__BackingField = v23;
		    v24 = HG::Rendering::Runtime::HGVolumetricFogUtils::GetAndCreateTemporaryRenderTexture(
		            &v54,
		            (String *)"_VolumetricFogVBufferB",
		            0LL);
		  }
		  else
		  {
		    v24 = 0LL;
		  }
		  v11->fields.vBufferB = v24;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v11->fields.vBufferB, v18, v19, v20, offseta);
		  hgCamera = v11->fields.hgCamera;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
		  if ( !InterpolatedPhase )
		    goto LABEL_12;
		  volumetricFogGridInjectionCS = v11->fields.volumetricFogGridInjectionCS;
		  memset(&v55, 0, sizeof(v55));
		  UnityEngine::Rendering::LocalKeyword::LocalKeyword(
		    &v55,
		    volumetricFogGridInjectionCS,
		    (String *)"ENABLE_EMISSIVE_VBUFFER_B",
		    0LL);
		  *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v55.m_SpaceInfo.m_KeywordSpace;
		  *(_QWORD *)&v52 = *(_QWORD *)&v55.m_Index;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		  s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_settingParameters;
		  if ( !s_settingParameters
		    || (v30 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                s_settingParameters->fields.enableEmissiveVBufferB,
		                MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit),
		        !cmd) )
		  {
		LABEL_12:
		    sub_1800D8260(s_settingParameters, v26);
		  }
		  UnityEngine::Rendering::CommandBuffer::SetKeyword(
		    cmd,
		    volumetricFogGridInjectionCS,
		    (LocalKeyword *)&keyword.m_Name,
		    v30,
		    0LL);
		  *(_OWORD *)&keyword.m_Name = 0LL;
		  v52 = 0LL;
		  *(Color *)&keyword.m_Name = InterpolatedPhase->fields.volumetricFogConfig.volumetricFogAlbedo;
		  v31 = HG::Rendering::Runtime::VectorSwizzleUtils::rgb((Vector3 *)&threadGroupsX, (Color *)&keyword.m_Name, 0LL);
		  volumetricFogExtinctionScale = InterpolatedPhase->fields.volumetricFogConfig.volumetricFogExtinctionScale;
		  v33 = *(_QWORD *)&v31->x;
		  z = v31->z;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  threadGroupsX = v33;
		  *(float *)&keyword.m_SpaceInfo.m_KeywordSpace = z;
		  v35 = HG::Rendering::Runtime::HGUtils::PackVector4(
		          (Vector4 *)&keyword.m_Name,
		          (Vector3 *)&threadGroupsX,
		          volumetricFogExtinctionScale,
		          0LL);
		  threadGroupsX = *(_QWORD *)&v11->fields.volumetricFogEmissive.x;
		  v36 = _mm_loadu_si128((const __m128i *)v35);
		  *(float *)&keyword.m_SpaceInfo.m_KeywordSpace = v11->fields.volumetricFogEmissive.z;
		  v37 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
		                                           (Vector4 *)&keyword.m_Name,
		                                           (Vector3 *)&threadGroupsX,
		                                           0LL));
		  *(__m128i *)source = v36;
		  v57 = v37;
		  sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		  v38 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		          (CBHandle *)&keyword.m_Name,
		          &P2,
		          32,
		          0LL);
		  v39 = *(__m128i *)&v38->bufferId;
		  *(_QWORD *)&v52 = v38->ptr;
		  Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy((Void *)v52, source, 32LL, 0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantBufferParam(
		    cmd,
		    volumetricFogGridInjectionCS,
		    TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VolumetricFogGridInjectionConstants,
		    _mm_cvtsi128_si32(v39),
		    _mm_cvtsi128_si32(_mm_srli_si128(v39, 4)),
		    _mm_cvtsi128_si32(_mm_srli_si128(v39, 8)),
		    0LL);
		  VolumetricFogVBufferA = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VolumetricFogVBufferA;
		  v41 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		          (RenderTargetIdentifier *)&v54,
		          (Texture *)v11->fields.vBufferA,
		          0LL);
		  v42 = *(_OWORD *)&v41->m_BufferPointer;
		  *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v41->m_Type;
		  v37.m128i_i64[0] = *(_QWORD *)&v41->m_DepthSlice;
		  v52 = v42;
		  v53 = v37.m128i_i64[0];
		  UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		    cmd,
		    volumetricFogGridInjectionCS,
		    0,
		    VolumetricFogVBufferA,
		    (RenderTargetIdentifier *)&keyword.m_Name,
		    0LL);
		  VolumetricFogVBufferB = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VolumetricFogVBufferB;
		  v44 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		          (RenderTargetIdentifier *)&v54,
		          (Texture *)v11->fields.vBufferB,
		          0LL);
		  v45 = *(_OWORD *)&v44->m_BufferPointer;
		  *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v44->m_Type;
		  v37.m128i_i64[0] = *(_QWORD *)&v44->m_DepthSlice;
		  v52 = v45;
		  v53 = v37.m128i_i64[0];
		  UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		    cmd,
		    volumetricFogGridInjectionCS,
		    0,
		    VolumetricFogVBufferB,
		    (RenderTargetIdentifier *)&keyword.m_Name,
		    0LL);
		  m_Z = v11->fields.volumetricFogGridSize.m_Z;
		  threadGroupsX = *(_QWORD *)&v11->fields.volumetricFogGridSize.m_X;
		  LODWORD(keyword.m_SpaceInfo.m_KeywordSpace) = m_Z;
		  v47 = HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(
		          (Vector3Int *)&keyword.m_Name,
		          (Vector3Int *)&threadGroupsX,
		          4,
		          0LL);
		  UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
		    cmd,
		    volumetricFogGridInjectionCS,
		    0,
		    *(_QWORD *)&v47->m_X,
		    HIDWORD(*(_QWORD *)&v47->m_X),
		    v47->m_Z,
		    0LL);
		}
		
		public void RenderVolumetricFogVoxelization(CommandBuffer cmd, VolumetricFogPassConstructor.ComputeVolumetricFogPassData passData) {} // 0x0000000189CED724-0x0000000189CEE4BC
		// Void RenderVolumetricFogVoxelization(CommandBuffer, VolumetricFogPassConstructor+ComputeVolumetricFogPassData)
		void HG::Rendering::Runtime::HGVolumetricFogRenderer::RenderVolumetricFogVoxelization(
		        HGVolumetricFogRenderer *this,
		        CommandBuffer *cmd,
		        VolumetricFogPassConstructor_ComputeVolumetricFogPassData *passData,
		        MethodInfo *method)
		{
		  Object *v6; // r12
		  HGVolumetricLocalFogManager *instance; // rax
		  HGShaderIDs__StaticFields *static_fields; // rdx
		  void *s_voxelizationMaterialPropertyBlock; // rcx
		  List_1_HG_Rendering_Runtime_HGVolumetricLocalFog_ *volumetricLocalFogList; // rax
		  List_1_System_Object_ *v11; // rbx
		  HGCamera *hgCamera; // r15
		  Camera *camera; // rsi
		  Matrix4x4 *projectionMatrix; // rax
		  float volumetricFogDistance; // xmm6_4
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  float v19; // xmm7_4
		  float v20; // xmm8_4
		  float v21; // xmm7_4
		  float v22; // xmm6_4
		  float v23; // xmm7_4
		  Matrix4x4 *worldToCameraMatrix; // rax
		  __int128 v25; // xmm1
		  __int128 v26; // xmm0
		  __int128 v27; // xmm1
		  Matrix4x4 *v28; // rax
		  __int128 v29; // xmm6
		  __int128 v30; // xmm7
		  __int128 v31; // xmm8
		  __int128 v32; // xmm9
		  HGVolumetricLocalFogManager *v33; // r13
		  int32_t InstanceID; // eax
		  NativeList_1_System_UInt32_ v35; // xmm0
		  float *m_Buffer; // rax
		  float v37; // xmm6_4
		  float v38; // xmm7_4
		  __int128 v39; // xmm1
		  __int128 v40; // xmm0
		  __int128 v41; // xmm1
		  MethodInfo *v42; // rdx
		  Vector2 v43; // rax
		  Vector2Int sceneRTSize_k__BackingField; // rdx
		  int32_t v45; // r13d
		  MaterialPropertyBlock *v46; // rsi
		  MethodInfo *v47; // rdx
		  __m128 m_X; // xmm2
		  __m128 m_Y; // xmm1
		  Vector4 *v50; // rax
		  int32_t v51; // r10d
		  int32_t VoxelizationFrameJitterOffset; // edx
		  int32_t v53; // edx
		  MaterialPropertyBlock *v54; // rcx
		  Int32Enum__Enum v55; // eax
		  Object *Item; // rsi
		  Object_1 *material; // rbx
		  Material *v58; // rax
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  __int64 v61; // xmm6_8
		  float z; // ebx
		  Transform *v63; // rax
		  Vector3 *lossyScale; // rax
		  __int64 v65; // xmm0_8
		  float v66; // xmm7_4
		  Vector3 *v67; // rax
		  __int64 v68; // xmm8_8
		  float v69; // xmm6_4
		  int32_t VolumetricFogZSliceFromDepth; // eax
		  __int64 v71; // xmm0_8
		  int v72; // r15d
		  int32_t v73; // ebx
		  int32_t v74; // ebx
		  MaterialPropertyBlock *v75; // r12
		  MaterialPropertyBlock *v76; // r12
		  Transform *v77; // rax
		  Vector3 *v78; // rax
		  __int64 v79; // xmm0_8
		  MethodInfo *v80; // r8
		  Vector4 *v81; // rax
		  MethodInfo *v82; // r8
		  Vector4 *v83; // rax
		  MaterialPropertyBlock *v84; // r10
		  MaterialPropertyBlock *v85; // r12
		  Transform *v86; // rax
		  Matrix4x4 *worldToLocalMatrix; // rax
		  __int128 v88; // xmm1
		  __int128 v89; // xmm0
		  __int128 v90; // xmm1
		  int v91; // r12d
		  Transform *v92; // rax
		  Matrix4x4 *v93; // rax
		  __int128 v94; // xmm6
		  __int128 v95; // xmm7
		  __int128 v96; // xmm8
		  __int128 v97; // xmm9
		  Material *v98; // rax
		  HGVolumetricFogRenderer__StaticFields *v99; // rcx
		  __int64 v100; // r12
		  Void *v101; // r15
		  Transform *v102; // rax
		  Matrix4x4 *localToWorldMatrix; // rax
		  __int128 v104; // xmm1
		  __int128 v105; // xmm2
		  __int128 v106; // xmm3
		  Mesh *quadMesh; // r15
		  Material *v108; // rsi
		  HGVolumetricFogRenderer__StaticFields *v109; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MaterialPropertyBlock *v111; // [rsp+40h] [rbp-C8h]
		  Vector3Int volumetricFogGridSize; // [rsp+58h] [rbp-B0h] BYREF
		  List_1_System_Object_ *v113; // [rsp+68h] [rbp-A0h]
		  Vector2 VolumetricFogGridToScreenSVPosRatio; // [rsp+70h] [rbp-98h]
		  HGCamera *v115; // [rsp+78h] [rbp-90h]
		  Matrix4x4 v116; // [rsp+88h] [rbp-80h] BYREF
		  Vector4 v117; // [rsp+C8h] [rbp-40h] BYREF
		  Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v118; // [rsp+D8h] [rbp-30h] BYREF
		  Vector4 v119; // [rsp+148h] [rbp+40h] BYREF
		  Vector3 v120; // [rsp+158h] [rbp+50h] BYREF
		  Vector3 v121; // [rsp+168h] [rbp+60h] BYREF
		  Vector3 m_Extents; // [rsp+178h] [rbp+70h] BYREF
		  Vector3 v123; // [rsp+188h] [rbp+80h] BYREF
		  Vector3 v124; // [rsp+198h] [rbp+90h] BYREF
		  Vector3 v125; // [rsp+1A8h] [rbp+A0h] BYREF
		  Vector3 v126; // [rsp+1B8h] [rbp+B0h] BYREF
		  Vector3 v127; // [rsp+1C8h] [rbp+C0h] BYREF
		  NativeArray_1_UnityEngine_Matrix4x4_ v128; // [rsp+1D8h] [rbp+D0h] BYREF
		  Vector4 v129; // [rsp+1E8h] [rbp+E0h] BYREF
		  Bounds v130; // [rsp+1F8h] [rbp+F0h] BYREF
		  RenderTargetIdentifier v131; // [rsp+210h] [rbp+108h] BYREF
		  RenderTargetIdentifier v132; // [rsp+238h] [rbp+130h] BYREF
		  NativeList_1_System_UInt32_ v133; // [rsp+260h] [rbp+158h] BYREF
		  Matrix4x4 v134; // [rsp+278h] [rbp+170h] BYREF
		  Vector3 v135; // [rsp+2B8h] [rbp+1B0h] BYREF
		  Vector3 v136; // [rsp+2C8h] [rbp+1C0h] BYREF
		  Vector3 v137; // [rsp+2D8h] [rbp+1D0h] BYREF
		  _OWORD v138[7]; // [rsp+2E8h] [rbp+1E0h] BYREF
		  Vector4 v139; // [rsp+358h] [rbp+250h] BYREF
		  Vector4 v140; // [rsp+368h] [rbp+260h] BYREF
		
		  v6 = (Object *)this;
		  v128 = 0LL;
		  memset(&v131, 0, sizeof(v131));
		  memset(&v130, 0, sizeof(v130));
		  sub_18033B9D0(v138, 0LL, 112LL);
		  memset(&v132, 0, sizeof(v132));
		  if ( IFix::WrappersManagerImpl::IsPatched(1548, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1548, 0LL);
		    if ( !Patch )
		      goto LABEL_58;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		      (ILFixDynamicMethodWrapper_30 *)Patch,
		      v6,
		      (Object *)cmd,
		      (Object *)passData,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricLocalFogManager);
		    instance = HG::Rendering::Runtime::HGVolumetricLocalFogManager::get_instance(0LL);
		    if ( !instance )
		      goto LABEL_58;
		    volumetricLocalFogList = HG::Rendering::Runtime::HGVolumetricLocalFogManager::get_volumetricLocalFogList(
		                               instance,
		                               0LL);
		    v113 = (List_1_System_Object_ *)volumetricLocalFogList;
		    v11 = (List_1_System_Object_ *)volumetricLocalFogList;
		    if ( !volumetricLocalFogList )
		      goto LABEL_58;
		    if ( volumetricLocalFogList->fields._size )
		    {
		      if ( passData )
		      {
		        hgCamera = passData->fields.hgCamera;
		        v115 = hgCamera;
		        if ( hgCamera )
		        {
		          camera = hgCamera->fields.camera;
		          if ( camera )
		          {
		            projectionMatrix = UnityEngine::Camera::get_projectionMatrix(
		                                 (Matrix4x4 *)&v118,
		                                 hgCamera->fields.camera,
		                                 0LL);
		            volumetricFogDistance = passData->fields.volumetricFogDistance;
		            v16 = *(_OWORD *)&projectionMatrix->m01;
		            *(_OWORD *)&v116.m00 = *(_OWORD *)&projectionMatrix->m00;
		            v17 = *(_OWORD *)&projectionMatrix->m02;
		            *(_OWORD *)&v116.m01 = v16;
		            v18 = *(_OWORD *)&projectionMatrix->m03;
		            *(_OWORD *)&v116.m02 = v17;
		            *(_OWORD *)&v116.m03 = v18;
		            *(float *)&v17 = UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
		            v19 = passData->fields.volumetricFogDistance;
		            v20 = -(float)(*(float *)&v17 + volumetricFogDistance);
		            *(float *)&v17 = UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
		            UnityEngine::Matrix4x4::set_Item(&v116, 10, v20 / (float)(v19 - *(float *)&v17), 0LL);
		            v21 = passData->fields.volumetricFogDistance;
		            *(float *)&v17 = UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
		            v22 = passData->fields.volumetricFogDistance;
		            v23 = -(float)((float)(v21 + v21) * *(float *)&v17);
		            *(float *)&v17 = UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
		            UnityEngine::Matrix4x4::set_Item(&v116, 14, v23 / (float)(v22 - *(float *)&v17), 0LL);
		            worldToCameraMatrix = UnityEngine::Camera::get_worldToCameraMatrix((Matrix4x4 *)&v118, camera, 0LL);
		            v25 = *(_OWORD *)&worldToCameraMatrix->m01;
		            *(_OWORD *)&v134.m00 = *(_OWORD *)&worldToCameraMatrix->m00;
		            v26 = *(_OWORD *)&worldToCameraMatrix->m02;
		            *(_OWORD *)&v134.m01 = v25;
		            v27 = *(_OWORD *)&worldToCameraMatrix->m03;
		            *(_OWORD *)&v134.m02 = v26;
		            *(_OWORD *)&v134.m03 = v27;
		            *(_OWORD *)&v118.hasValue = *(_OWORD *)&v116.m00;
		            *(_OWORD *)&v118.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = *(_OWORD *)&v116.m01;
		            *(_OWORD *)&v118.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = *(_OWORD *)&v116.m02;
		            *(_OWORD *)&v118.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = *(_OWORD *)&v116.m03;
		            v28 = UnityEngine::Matrix4x4::op_Multiply(&v116, (Matrix4x4 *)&v118, &v134, 0LL);
		            v29 = *(_OWORD *)&v28->m00;
		            v30 = *(_OWORD *)&v28->m01;
		            v31 = *(_OWORD *)&v28->m02;
		            v32 = *(_OWORD *)&v28->m03;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricLocalFogManager);
		            v33 = HG::Rendering::Runtime::HGVolumetricLocalFogManager::get_instance(0LL);
		            InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)camera, 0LL);
		            if ( v33 )
		            {
		              *(_OWORD *)&v118.hasValue = v29;
		              *(_OWORD *)&v118.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v30;
		              *(_OWORD *)&v118.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v31;
		              *(_OWORD *)&v118.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v32;
		              v35 = (NativeList_1_System_UInt32_)*HG::Rendering::Runtime::HGVolumetricLocalFogManager::VolumetricLocalFogCulling(
		                                                    (NativeList_1_System_Int32_ *)&v129,
		                                                    v33,
		                                                    (Matrix4x4 *)&v118,
		                                                    InstanceID,
		                                                    0LL);
		              m_Buffer = (float *)passData->fields.frameJitterOffsetValues.m_Buffer;
		              v133 = v35;
		              v37 = *m_Buffer / (float)passData->fields.volumetricFogGridSize.m_X;
		              v38 = m_Buffer[1] / (float)passData->fields.volumetricFogGridSize.m_Y;
		              v39 = *(_OWORD *)&hgCamera->fields.mainViewConstants.nonJitteredProjMatrix.m01;
		              *(_OWORD *)&v116.m00 = *(_OWORD *)&hgCamera->fields.mainViewConstants.nonJitteredProjMatrix.m00;
		              v40 = *(_OWORD *)&hgCamera->fields.mainViewConstants.nonJitteredProjMatrix.m02;
		              *(_OWORD *)&v116.m01 = v39;
		              v41 = *(_OWORD *)&hgCamera->fields.mainViewConstants.nonJitteredProjMatrix.m03;
		              *(_OWORD *)&v116.m02 = v40;
		              *(_OWORD *)&v116.m03 = v41;
		              *(float *)&v40 = UnityEngine::Matrix4x4::get_Item(&v116, 8, 0LL);
		              UnityEngine::Matrix4x4::set_Item(&v116, 8, *(float *)&v40 + v37, 0LL);
		              *(float *)&v40 = UnityEngine::Matrix4x4::get_Item(&v116, 9, 0LL);
		              UnityEngine::Matrix4x4::set_Item(&v116, 9, *(float *)&v40 - v38, 0LL);
		              v43 = UnityEngine::Vector2Int::op_Implicit(passData->fields.volumetricFogGridToPixel, v42);
		              sceneRTSize_k__BackingField = hgCamera->fields._sceneRTSize_k__BackingField;
		              v45 = 0;
		              volumetricFogGridSize = passData->fields.volumetricFogGridSize;
		              VolumetricFogGridToScreenSVPosRatio = HG::Rendering::Runtime::HGVolumetricFogRenderer::_GetVolumetricFogGridToScreenSVPosRatio(
		                                                      (HGVolumetricFogRenderer *)v6,
		                                                      sceneRTSize_k__BackingField,
		                                                      &volumetricFogGridSize,
		                                                      v43,
		                                                      0LL);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		              s_voxelizationMaterialPropertyBlock = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_voxelizationMaterialPropertyBlock;
		              if ( s_voxelizationMaterialPropertyBlock )
		              {
		                UnityEngine::MaterialPropertyBlock::Clear(
		                  (MaterialPropertyBlock *)s_voxelizationMaterialPropertyBlock,
		                  1,
		                  0LL);
		                v46 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_voxelizationMaterialPropertyBlock;
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		                *(Vector2 *)&volumetricFogGridSize.m_X = UnityEngine::Vector2Int::op_Implicit(
		                                                           passData->fields.volumetricFogGridToPixel,
		                                                           v47);
		                m_X = (__m128)(unsigned int)volumetricFogGridSize.m_X;
		                m_Y = (__m128)(unsigned int)volumetricFogGridSize.m_Y;
		                m_X.m128_f32[0] = *(float *)&volumetricFogGridSize.m_X / VolumetricFogGridToScreenSVPosRatio.x;
		                m_Y.m128_f32[0] = *(float *)&volumetricFogGridSize.m_Y / VolumetricFogGridToScreenSVPosRatio.y;
		                v50 = (Vector4 *)sub_183240A00(&v129, _mm_unpacklo_ps(m_X, m_Y).m128_u64[0]);
		                if ( v46 )
		                {
		                  v119 = *v50;
		                  UnityEngine::MaterialPropertyBlock::SetVector(v46, v51, &v119, 0LL);
		                  s_voxelizationMaterialPropertyBlock = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_voxelizationMaterialPropertyBlock;
		                  static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                  if ( s_voxelizationMaterialPropertyBlock )
		                  {
		                    VoxelizationFrameJitterOffset = static_fields->_VoxelizationFrameJitterOffset;
		                    v119 = *(Vector4 *)passData->fields.frameJitterOffsetValues.m_Buffer;
		                    UnityEngine::MaterialPropertyBlock::SetVector(
		                      (MaterialPropertyBlock *)s_voxelizationMaterialPropertyBlock,
		                      VoxelizationFrameJitterOffset,
		                      &v119,
		                      0LL);
		                    s_voxelizationMaterialPropertyBlock = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                    if ( TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_voxelizationMaterialPropertyBlock )
		                    {
		                      v53 = *((_DWORD *)s_voxelizationMaterialPropertyBlock + 285);
		                      v54 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_voxelizationMaterialPropertyBlock;
		                      *(_OWORD *)&v118.hasValue = *(_OWORD *)&v116.m00;
		                      *(_OWORD *)&v118.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = *(_OWORD *)&v116.m01;
		                      *(_OWORD *)&v118.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = *(_OWORD *)&v116.m02;
		                      *(_OWORD *)&v118.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = *(_OWORD *)&v116.m03;
		                      UnityEngine::MaterialPropertyBlock::SetMatrix(v54, v53, (Matrix4x4 *)&v118, 0LL);
		                      if ( UnityEngine::SystemInfo::SupportsRenderTargetArrayIndexFromVertexShader(0LL) )
		                      {
		                        UnityEngine::Rendering::RenderTargetIdentifier::RenderTargetIdentifier(
		                          &v131,
		                          (Texture *)passData->fields.vBufferA,
		                          0,
		                          CubemapFace__Enum_Unknown,
		                          -1,
		                          0LL);
		                        if ( !cmd )
		                          goto LABEL_58;
		                        *(_OWORD *)&v116.m00 = *(_OWORD *)&v131.m_Type;
		                        *(_QWORD *)&v116.m02 = *(_QWORD *)&v131.m_DepthSlice;
		                        *(_OWORD *)&v116.m01 = *(_OWORD *)&v131.m_BufferPointer;
		                        UnityEngine::Rendering::CommandBuffer::SetRenderTarget(
		                          cmd,
		                          (RenderTargetIdentifier *)&v116,
		                          RenderBufferLoadAction__Enum_Load,
		                          RenderBufferStoreAction__Enum_Store,
		                          0LL);
		                      }
		                      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		                      s_voxelizationMaterialPropertyBlock = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_settingParameters;
		                      if ( s_voxelizationMaterialPropertyBlock )
		                      {
		                        v55 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                                *((SettingParameter_1_System_Int32Enum_ **)s_voxelizationMaterialPropertyBlock + 4),
		                                MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		                        Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::NativeArray(
		                          &v128,
		                          v55,
		                          Allocator__Enum_Temp,
		                          NativeArrayOptions__Enum_ClearMemory,
		                          MethodInfo::Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::NativeArray);
		                        while ( 1 )
		                        {
		                          if ( v45 >= v11->fields._size )
		                            return;
		                          Item = System::Collections::Generic::List<System::Object>::get_Item(
		                                   v11,
		                                   v45,
		                                   MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGVolumetricLocalFog>::get_Item);
		                          if ( Unity::Collections::NativeList<unsigned int>::get_Item(
		                                 &v133,
		                                 v45,
		                                 MethodInfo::Unity::Collections::NativeList<int>::get_Item) )
		                          {
		                            if ( !Item )
		                              break;
		                            material = (Object_1 *)HG::Rendering::Runtime::HGVolumetricLocalFog::get_material(
		                                                     (HGVolumetricLocalFog *)Item,
		                                                     0LL);
		                            sub_1800036A0(TypeInfo::UnityEngine::Object);
		                            if ( !UnityEngine::Object::op_Equality(material, 0LL, 0LL) )
		                            {
		                              v58 = HG::Rendering::Runtime::HGVolumetricLocalFog::get_material(
		                                      (HGVolumetricLocalFog *)Item,
		                                      0LL);
		                              if ( !v58 )
		                                break;
		                              if ( UnityEngine::Material::FindPass(v58, (String *)"VolumerticFogVoxelization", 0LL) != -1 )
		                              {
		                                transform = UnityEngine::Component::get_transform((Component *)Item, 0LL);
		                                if ( !transform )
		                                  break;
		                                position = UnityEngine::Transform::get_position(&v135, transform, 0LL);
		                                v61 = *(_QWORD *)&position->x;
		                                z = position->z;
		                                v63 = UnityEngine::Component::get_transform((Component *)Item, 0LL);
		                                if ( !v63 )
		                                  break;
		                                lossyScale = UnityEngine::Transform::get_lossyScale(&v136, v63, 0LL);
		                                *(_QWORD *)&v121.x = v61;
		                                v121.z = z;
		                                v65 = *(_QWORD *)&lossyScale->x;
		                                *(float *)&lossyScale = lossyScale->z;
		                                *(_QWORD *)&v120.x = v65;
		                                LODWORD(v120.z) = (_DWORD)lossyScale;
		                                UnityEngine::Bounds::Bounds(&v130, &v121, &v120, 0LL);
		                                m_Extents = v130.m_Extents;
		                                v66 = sub_182F9FF00(&m_Extents);
		                                *(_QWORD *)&v123.x = *(_QWORD *)&v130.m_Center.x;
		                                LODWORD(v123.z) = _mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&v130.m_Center.x, 8));
		                                v67 = UnityEngine::Matrix4x4::MultiplyPoint(
		                                        &v137,
		                                        &hgCamera->fields.mainViewConstants.viewMatrix,
		                                        &v123,
		                                        0LL);
		                                *(_QWORD *)&v124.x = *(_QWORD *)&passData->fields.volumetricFogZParams.x;
		                                v68 = *(_QWORD *)&v67->x;
		                                volumetricFogGridSize.m_X = LODWORD(v67->z);
		                                v69 = -*(float *)&volumetricFogGridSize.m_X;
		                                v124.z = passData->fields.volumetricFogZParams.z;
		                                VolumetricFogZSliceFromDepth = HG::Rendering::Runtime::HGVolumetricFogRenderer::_GetVolumetricFogZSliceFromDepth(
		                                                                 (HGVolumetricFogRenderer *)v6,
		                                                                 (float)-*(float *)&volumetricFogGridSize.m_X - v66,
		                                                                 &v124,
		                                                                 0LL);
		                                v71 = *(_QWORD *)&passData->fields.volumetricFogZParams.x;
		                                v125.z = passData->fields.volumetricFogZParams.z;
		                                *(_QWORD *)&v125.x = v71;
		                                v72 = VolumetricFogZSliceFromDepth;
		                                v73 = HG::Rendering::Runtime::HGVolumetricFogRenderer::_GetVolumetricFogZSliceFromDepth(
		                                        (HGVolumetricFogRenderer *)v6,
		                                        v69 + v66,
		                                        &v125,
		                                        0LL);
		                                if ( v72 >= 0 )
		                                {
		                                  if ( v72 > passData->fields.volumetricFogGridSize.m_Z - 1 )
		                                    v72 = passData->fields.volumetricFogGridSize.m_Z - 1;
		                                }
		                                else
		                                {
		                                  v72 = 0;
		                                }
		                                if ( v73 >= 0 )
		                                {
		                                  if ( v73 > passData->fields.volumetricFogGridSize.m_Z - 1 )
		                                    v73 = passData->fields.volumetricFogGridSize.m_Z - 1;
		                                }
		                                else
		                                {
		                                  v73 = 0;
		                                }
		                                v74 = v73 - v72 + 1;
		                                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		                                v75 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_voxelizationMaterialPropertyBlock;
		                                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		                                if ( !v75 )
		                                  break;
		                                UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                                  v75,
		                                  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VoxelizationClosestSliceIndex,
		                                  (float)v72,
		                                  0LL);
		                                v76 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_voxelizationMaterialPropertyBlock;
		                                LODWORD(VolumetricFogGridToScreenSVPosRatio.x) = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VoxelizationVolumePos;
		                                v77 = UnityEngine::Component::get_transform((Component *)Item, 0LL);
		                                if ( !v77 )
		                                  break;
		                                v78 = UnityEngine::Transform::get_position((Vector3 *)&v119, v77, 0LL);
		                                v79 = *(_QWORD *)&v78->x;
		                                *(float *)&v78 = v78->z;
		                                *(_QWORD *)&v126.x = v79;
		                                LODWORD(v126.z) = (_DWORD)v78;
		                                v81 = UnityEngine::Vector4::op_Implicit(&v139, &v126, v80);
		                                if ( !v76 )
		                                  break;
		                                v117 = *v81;
		                                UnityEngine::MaterialPropertyBlock::SetVector(
		                                  v76,
		                                  SLODWORD(VolumetricFogGridToScreenSVPosRatio.x),
		                                  &v117,
		                                  0LL);
		                                s_voxelizationMaterialPropertyBlock = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_voxelizationMaterialPropertyBlock;
		                                if ( !s_voxelizationMaterialPropertyBlock )
		                                  break;
		                                UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                                  (MaterialPropertyBlock *)s_voxelizationMaterialPropertyBlock,
		                                  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VoxelizationVolumeRadius,
		                                  v66,
		                                  0LL);
		                                *(_QWORD *)&v127.x = v68;
		                                LODWORD(v127.z) = volumetricFogGridSize.m_X;
		                                v83 = UnityEngine::Vector4::op_Implicit(&v140, &v127, v82);
		                                if ( !v84 )
		                                  break;
		                                v117 = *v83;
		                                UnityEngine::MaterialPropertyBlock::SetVector(
		                                  v84,
		                                  TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VoxelizationViewSpacePos,
		                                  &v117,
		                                  0LL);
		                                v85 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_voxelizationMaterialPropertyBlock;
		                                volumetricFogGridSize.m_X = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VoxelizationWorldToObject;
		                                v86 = UnityEngine::Component::get_transform((Component *)Item, 0LL);
		                                if ( !v86 )
		                                  break;
		                                worldToLocalMatrix = UnityEngine::Transform::get_worldToLocalMatrix(&v134, v86, 0LL);
		                                if ( !v85 )
		                                  break;
		                                v88 = *(_OWORD *)&worldToLocalMatrix->m01;
		                                *(_OWORD *)&v118.hasValue = *(_OWORD *)&worldToLocalMatrix->m00;
		                                v89 = *(_OWORD *)&worldToLocalMatrix->m02;
		                                *(_OWORD *)&v118.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v88;
		                                v90 = *(_OWORD *)&worldToLocalMatrix->m03;
		                                *(_OWORD *)&v118.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v89;
		                                *(_OWORD *)&v118.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v90;
		                                UnityEngine::MaterialPropertyBlock::SetMatrix(
		                                  v85,
		                                  volumetricFogGridSize.m_X,
		                                  (Matrix4x4 *)&v118,
		                                  0LL);
		                                if ( UnityEngine::SystemInfo::SupportsRenderTargetArrayIndexFromVertexShader(0LL) )
		                                {
		                                  v100 = 0LL;
		                                  if ( v74 > 0 )
		                                  {
		                                    v101 = v128.m_Buffer;
		                                    do
		                                    {
		                                      v102 = UnityEngine::Component::get_transform((Component *)Item, 0LL);
		                                      if ( !v102 )
		                                        goto LABEL_58;
		                                      localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(
		                                                             (Matrix4x4 *)&v118,
		                                                             v102,
		                                                             0LL);
		                                      ++v100;
		                                      v104 = *(_OWORD *)&localToWorldMatrix->m01;
		                                      v105 = *(_OWORD *)&localToWorldMatrix->m02;
		                                      v106 = *(_OWORD *)&localToWorldMatrix->m03;
		                                      *(_OWORD *)v101 = *(_OWORD *)&localToWorldMatrix->m00;
		                                      *(_OWORD *)&v101[16] = v104;
		                                      *(_OWORD *)&v101[32] = v105;
		                                      *(_OWORD *)&v101[48] = v106;
		                                      v101 += 64;
		                                    }
		                                    while ( v100 < v74 );
		                                  }
		                                  Unity::Collections::NativeArray<MagicaCloth::PhysicsManagerMeshData::SharedRenderMeshInfo>::GetSubArray(
		                                    (NativeArray_1_MagicaCloth_PhysicsManagerMeshData_SharedRenderMeshInfo_ *)&v129,
		                                    (NativeArray_1_MagicaCloth_PhysicsManagerMeshData_SharedRenderMeshInfo_ *)&v128,
		                                    0,
		                                    v74,
		                                    MethodInfo::Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::GetSubArray);
		                                  quadMesh = HG::Rendering::Runtime::HGVolumetricFogUtils::get_quadMesh(0LL);
		                                  v108 = HG::Rendering::Runtime::HGVolumetricLocalFog::get_material(
		                                           (HGVolumetricLocalFog *)Item,
		                                           0LL);
		                                  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		                                  sub_18033B9D0(v138, 0LL, 112LL);
		                                  if ( !cmd )
		                                    break;
		                                  *(_OWORD *)&v118.hasValue = v138[0];
		                                  v109 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields;
		                                  *(_OWORD *)&v118.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v138[1];
		                                  *(_OWORD *)&v118.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v138[2];
		                                  v111 = v109->s_voxelizationMaterialPropertyBlock;
		                                  *(_OWORD *)&v118.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v138[3];
		                                  *(_OWORD *)&v118.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v138[4];
		                                  *(_OWORD *)&v118.value.m_RasterState.m_OffsetFactor = v138[5];
		                                  *(_OWORD *)&v118.value.m_StencilState.m_FailOperationFront = v138[6];
		                                  v117 = v129;
		                                  UnityEngine::Rendering::CommandBuffer::DrawMeshInstanced(
		                                    cmd,
		                                    quadMesh,
		                                    0,
		                                    v108,
		                                    -1,
		                                    (NativeArray_1_UnityEngine_Matrix4x4_ *)&v117,
		                                    v74,
		                                    v111,
		                                    &v118,
		                                    0LL);
		                                }
		                                else
		                                {
		                                  v91 = 0;
		                                  if ( v74 > 0 )
		                                  {
		                                    do
		                                    {
		                                      UnityEngine::Rendering::RenderTargetIdentifier::RenderTargetIdentifier(
		                                        &v132,
		                                        (Texture *)passData->fields.vBufferA,
		                                        0,
		                                        CubemapFace__Enum_Unknown,
		                                        v72 + v91,
		                                        0LL);
		                                      if ( !cmd )
		                                        goto LABEL_58;
		                                      *(_OWORD *)&v116.m00 = *(_OWORD *)&v132.m_Type;
		                                      *(_QWORD *)&v116.m02 = *(_QWORD *)&v132.m_DepthSlice;
		                                      *(_OWORD *)&v116.m01 = *(_OWORD *)&v132.m_BufferPointer;
		                                      UnityEngine::Rendering::CommandBuffer::SetRenderTarget(
		                                        cmd,
		                                        (RenderTargetIdentifier *)&v116,
		                                        RenderBufferLoadAction__Enum_Load,
		                                        RenderBufferStoreAction__Enum_Store,
		                                        0LL);
		                                      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		                                      *(_QWORD *)&volumetricFogGridSize.m_X = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_voxelizationMaterialPropertyBlock;
		                                      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		                                      s_voxelizationMaterialPropertyBlock = *(void **)&volumetricFogGridSize.m_X;
		                                      if ( !*(_QWORD *)&volumetricFogGridSize.m_X )
		                                        goto LABEL_58;
		                                      UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                                        *(MaterialPropertyBlock **)&volumetricFogGridSize.m_X,
		                                        TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VoxelizationPassIndex,
		                                        (float)v91,
		                                        0LL);
		                                      *(_QWORD *)&volumetricFogGridSize.m_X = HG::Rendering::Runtime::HGVolumetricFogUtils::get_quadMesh(0LL);
		                                      v92 = UnityEngine::Component::get_transform((Component *)Item, 0LL);
		                                      if ( !v92 )
		                                        goto LABEL_58;
		                                      v93 = UnityEngine::Transform::get_localToWorldMatrix((Matrix4x4 *)&v118, v92, 0LL);
		                                      v94 = *(_OWORD *)&v93->m00;
		                                      v95 = *(_OWORD *)&v93->m01;
		                                      v96 = *(_OWORD *)&v93->m02;
		                                      v97 = *(_OWORD *)&v93->m03;
		                                      v98 = HG::Rendering::Runtime::HGVolumetricLocalFog::get_material(
		                                              (HGVolumetricLocalFog *)Item,
		                                              0LL);
		                                      *(_OWORD *)&v118.hasValue = v94;
		                                      *(_OWORD *)&v118.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v95;
		                                      v99 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields;
		                                      *(_OWORD *)&v118.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v96;
		                                      *(_OWORD *)&v118.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v97;
		                                      UnityEngine::Rendering::CommandBuffer::DrawMesh(
		                                        cmd,
		                                        *(Mesh **)&volumetricFogGridSize.m_X,
		                                        (Matrix4x4 *)&v118,
		                                        v98,
		                                        0,
		                                        -1,
		                                        v99->s_voxelizationMaterialPropertyBlock,
		                                        0LL);
		                                    }
		                                    while ( ++v91 < v74 );
		                                  }
		                                }
		                                v6 = (Object *)this;
		                                hgCamera = v115;
		                              }
		                            }
		                            v11 = v113;
		                          }
		                          ++v45;
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
		LABEL_58:
		      sub_1800D8260(s_voxelizationMaterialPropertyBlock, static_fields);
		    }
		  }
		}
		
		public void ComputeVolumetricFogLightScattering(CommandBuffer cmd, ScriptableRenderContext renderContext, bool hasGridInjectionPass, VolumetricFogPassConstructor.ComputeVolumetricFogPassData passData) {} // 0x0000000189CEC3FC-0x0000000189CED348
		// Void ComputeVolumetricFogLightScattering(CommandBuffer, ScriptableRenderContext, Boolean, VolumetricFogPassConstructor+ComputeVolumetricFogPassData)
		void HG::Rendering::Runtime::HGVolumetricFogRenderer::ComputeVolumetricFogLightScattering(
		        HGVolumetricFogRenderer *this,
		        CommandBuffer *cmd,
		        ScriptableRenderContext renderContext,
		        bool hasGridInjectionPass,
		        VolumetricFogPassConstructor_ComputeVolumetricFogPassData *passData,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  void *s_settingParameters; // rcx
		  VolumetricFogPassConstructor_ComputeVolumetricFogPassData *v11; // rdi
		  int32_t memoryless_k__BackingField; // eax
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  HGRuntimeGrassQuery_Node *v15; // rdx
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  HGCamera *hgCamera; // r13
		  ComputeShader *volumetricFogLightScatteringCS; // rsi
		  HGCamera *v20; // rbx
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  __int64 v22; // rdx
		  HGVolumetricFogRenderer_HGVolumetricFogSettingParameters *v23; // rcx
		  HGEnvironmentPhase *v24; // r15
		  HGVolumetricFogConfig *p_volumetricFogConfig; // r12
		  bool v26; // al
		  HGVolumetricFogRenderer__StaticFields *static_fields; // rcx
		  bool v28; // al
		  bool flowVLNoiseEnabled; // al
		  float historyVolumetricLightScatteringPreExposure; // xmm8_4
		  __int128 v31; // xmm0
		  __int128 v32; // xmm1
		  __int128 v33; // xmm0
		  __int128 v34; // xmm1
		  __int128 v35; // xmm0
		  __int128 v36; // xmm1
		  SHCoefficientsL1 *CoefficientsL1; // rax
		  Vector4 shAr; // xmm11
		  Vector4 shAg; // xmm12
		  Vector4 shAb; // xmm13
		  Vector3 *v41; // rax
		  float volumetricFogExtinctionScale; // xmm7_4
		  __int64 v43; // xmm6_8
		  float z; // ebx
		  Vector4 *v45; // rax
		  Vector4 v46; // xmm0
		  Vector4 *v47; // rax
		  bool v48; // zf
		  float v49; // xmm7_4
		  float v50; // xmm10_4
		  float v51; // xmm6_4
		  MethodInfo *v52; // rdx
		  Vector3 *fwd; // rax
		  Quaternion rotationAtmosphere; // xmm0
		  __int64 v55; // xmm3_8
		  Vector3 *v56; // rax
		  MethodInfo *v57; // r8
		  Vector3 *v58; // rax
		  float historyMissSuperSampleCount; // xmm2_4
		  Vector4 *v60; // rax
		  Vector4 v61; // xmm0
		  Vector4 v62; // xmm0
		  Vector3 *v63; // rax
		  float directIntensity; // xmm2_4
		  MethodInfo *v65; // r9
		  Vector3 *v66; // rax
		  __int64 v67; // xmm3_8
		  float v68; // eax
		  float flowVLNoiseSpeed; // xmm2_4
		  MethodInfo *v70; // r9
		  Vector3 *v71; // rax
		  __int64 v72; // xmm3_8
		  Vector4 *v73; // rax
		  float v74; // xmm9_4
		  float flowVLNoiseTilling; // xmm2_4
		  float flowVLNoiseIntensity; // xmm1_4
		  Vector4 *v77; // rax
		  float y; // xmm2_4
		  Vector4 v79; // xmm0
		  Vector4 *v80; // rax
		  float flowVLNoisePerturbTilling; // xmm1_4
		  Vector4 v82; // xmm0
		  Vector4 *v83; // rax
		  __int64 v84; // rdx
		  _OWORD *v85; // rcx
		  Vector4 v86; // xmm0
		  Void *p_source; // rax
		  __int128 v88; // xmm1
		  __int128 v89; // xmm0
		  __int128 v90; // xmm1
		  __int128 v91; // xmm0
		  __int128 v92; // xmm1
		  __int128 v93; // xmm0
		  __int128 v94; // xmm1
		  __int128 v95; // xmm1
		  __int128 v96; // xmm0
		  __int128 v97; // xmm1
		  __int128 v98; // xmm0
		  __int128 v99; // xmm1
		  CBHandle *v100; // rax
		  __m128i v101; // xmm6
		  int32_t VolumetricFogVBufferA; // ebx
		  RenderTargetIdentifier *v103; // rax
		  __int128 v104; // xmm1
		  __int64 v105; // xmm0_8
		  int32_t VolumetricFogVBufferB; // ebx
		  RenderTargetIdentifier *v107; // rax
		  __int128 v108; // xmm1
		  __int64 v109; // xmm0_8
		  int32_t VolumetricLight3DNoise; // ebx
		  RenderTargetIdentifier *v111; // rax
		  __int128 v112; // xmm1
		  __int64 v113; // xmm0_8
		  Object_1 *volumetricLight3DNoisePerturb; // rbx
		  Texture *v115; // r15
		  int32_t v116; // ebx
		  RenderTargetIdentifier *v117; // rax
		  __int128 v118; // xmm1
		  __int64 v119; // xmm0_8
		  int32_t LightScattering; // ebx
		  RenderTargetIdentifier *v121; // rax
		  __int128 v122; // xmm1
		  __int64 v123; // xmm0_8
		  int32_t LightScatteringHistory; // ebx
		  Texture *volumetricBlackTexture3D; // rdx
		  RenderTargetIdentifier *v126; // rax
		  __int128 v127; // xmm1
		  __int64 v128; // xmm0_8
		  TextureHandle punctualLightShadowResult; // xmm6
		  int32_t PunctualLightShadowTexV2; // ebx
		  RenderTargetIdentifier *v131; // rax
		  __int128 v132; // xmm1
		  __int64 v133; // xmm0_8
		  float v134; // eax
		  MethodInfo *offset; // [rsp+28h] [rbp-E0h]
		  Vector3 threadGroupsX; // [rsp+48h] [rbp-C0h] BYREF
		  bool v137; // [rsp+58h] [rbp-B0h]
		  bool IsValid; // [rsp+59h] [rbp-AFh]
		  LocalKeyword keyword; // [rsp+60h] [rbp-A8h] BYREF
		  __int128 v140; // [rsp+78h] [rbp-90h]
		  __int64 v141; // [rsp+88h] [rbp-80h]
		  RenderTargetIdentifier v142; // [rsp+98h] [rbp-70h] BYREF
		  Color volumetricFogAlbedo; // [rsp+C8h] [rbp-40h] BYREF
		  RenderTextureDescriptor v144; // [rsp+D8h] [rbp-30h] BYREF
		  LocalKeyword v145; // [rsp+118h] [rbp+10h] BYREF
		  LocalKeyword v146; // [rsp+130h] [rbp+28h] BYREF
		  LocalKeyword v147; // [rsp+148h] [rbp+40h] BYREF
		  LocalKeyword v148; // [rsp+160h] [rbp+58h] BYREF
		  LocalKeyword v149; // [rsp+178h] [rbp+70h] BYREF
		  SphericalHarmonicsL2 v150; // [rsp+198h] [rbp+90h] BYREF
		  _OWORD v151[12]; // [rsp+208h] [rbp+100h] BYREF
		  float v152; // [rsp+2C8h] [rbp+1C0h]
		  int v153; // [rsp+2CCh] [rbp+1C4h]
		  int v154; // [rsp+2D0h] [rbp+1C8h]
		  int v155; // [rsp+2D4h] [rbp+1CCh]
		  Vector4 v156; // [rsp+2D8h] [rbp+1D0h]
		  Void source; // [rsp+3E8h] [rbp+2E0h] BYREF
		  Void destination; // [rsp+4C8h] [rbp+3C0h] BYREF
		  ScriptableRenderContext P2; // [rsp+698h] [rbp+590h] BYREF
		  bool value; // [rsp+6A0h] [rbp+598h]
		
		  value = hasGridInjectionPass;
		  P2.m_Ptr = renderContext.m_Ptr;
		  if ( !IFix::WrappersManagerImpl::IsPatched(1557, 0LL) )
		  {
		    v11 = passData;
		    if ( passData )
		    {
		      memoryless_k__BackingField = passData->fields.volumeDesc._memoryless_k__BackingField;
		      v13 = *(_OWORD *)&passData->fields.volumeDesc._mipCount_k__BackingField;
		      *(_OWORD *)&v144._width_k__BackingField = *(_OWORD *)&passData->fields.volumeDesc._width_k__BackingField;
		      v14 = *(_OWORD *)&passData->fields.volumeDesc._dimension_k__BackingField;
		      v144._memoryless_k__BackingField = memoryless_k__BackingField;
		      *(_OWORD *)&v144._mipCount_k__BackingField = v13;
		      *(_OWORD *)&v144._dimension_k__BackingField = v14;
		      v11->fields.lightScattering = HG::Rendering::Runtime::HGVolumetricFogUtils::GetAndCreateTemporaryRenderTexture(
		                                      &v144,
		                                      (String *)"_LightScattering",
		                                      0LL);
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v11->fields.lightScattering, v15, v16, v17, offset);
		      hgCamera = v11->fields.hgCamera;
		      volumetricFogLightScatteringCS = v11->fields.volumetricFogLightScatteringCS;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		      s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_settingParameters;
		      if ( s_settingParameters )
		      {
		        if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		               *((SettingParameter_1_System_Boolean_ **)s_settingParameters + 13),
		               MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit)
		          && v11->fields.punctualLightShadowActive )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		          IsValid = HG::Rendering::RenderGraphModule::TextureHandle::IsValid(
		                      &v11->fields.punctualLightShadowResult,
		                      0LL);
		        }
		        else
		        {
		          IsValid = 0;
		        }
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		        s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_settingParameters;
		        if ( s_settingParameters )
		        {
		          v137 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                   *((SettingParameter_1_System_Boolean_ **)s_settingParameters + 15),
		                   MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit)
		              && (UnityEngine::SystemInfo::GetWaveIntrinsicsSupportedStages(0LL) & 0x20) != 0
		              && (UnityEngine::SystemInfo::GetWaveIntrinsicsSupportedOperations(0LL) & 5) != 0;
		          v20 = v11->fields.hgCamera;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		          InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(v20, 0LL);
		          v24 = InterpolatedPhase;
		          if ( !InterpolatedPhase )
		            goto LABEL_44;
		          p_volumetricFogConfig = &InterpolatedPhase->fields.volumetricFogConfig;
		          memset(&v145, 0, sizeof(v145));
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(
		            &v145,
		            volumetricFogLightScatteringCS,
		            (String *)"HAS_GRID_INJECTION_PASS",
		            0LL);
		          *(_QWORD *)&v140 = *(_QWORD *)&v145.m_Index;
		          *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v145.m_SpaceInfo.m_KeywordSpace;
		          if ( !cmd )
		            goto LABEL_44;
		          UnityEngine::Rendering::CommandBuffer::SetKeyword(
		            cmd,
		            volumetricFogLightScatteringCS,
		            (LocalKeyword *)&keyword.m_Name,
		            value,
		            0LL);
		          memset(&v146, 0, sizeof(v146));
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(
		            &v146,
		            volumetricFogLightScatteringCS,
		            (String *)"ENABLE_EMISSIVE_VBUFFER_B",
		            0LL);
		          *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v146.m_SpaceInfo.m_KeywordSpace;
		          *(_QWORD *)&v140 = *(_QWORD *)&v146.m_Index;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		          v23 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_settingParameters;
		          if ( !v23 )
		            goto LABEL_44;
		          v26 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                  v23->fields.enableEmissiveVBufferB,
		                  MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		          UnityEngine::Rendering::CommandBuffer::SetKeyword(
		            cmd,
		            volumetricFogLightScatteringCS,
		            (LocalKeyword *)&keyword.m_Name,
		            v26,
		            0LL);
		          memset(&v147, 0, sizeof(v147));
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(
		            &v147,
		            volumetricFogLightScatteringCS,
		            (String *)"ENABLE_TEMPORAL_REPROJECTION",
		            0LL);
		          static_fields = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields;
		          *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v147.m_SpaceInfo.m_KeywordSpace;
		          *(_QWORD *)&v140 = *(_QWORD *)&v147.m_Index;
		          v23 = static_fields->s_settingParameters;
		          if ( !v23 )
		LABEL_44:
		            sub_1800D8260(v23, v22);
		          v28 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                  v23->fields.enableTemporalReprojection,
		                  MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		          UnityEngine::Rendering::CommandBuffer::SetKeyword(
		            cmd,
		            volumetricFogLightScatteringCS,
		            (LocalKeyword *)&keyword.m_Name,
		            v28,
		            0LL);
		          memset(&v148, 0, sizeof(v148));
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(
		            &v148,
		            volumetricFogLightScatteringCS,
		            (String *)"ENABLE_VOLUMETRIC_LIGHT_FLOW_NOISE",
		            0LL);
		          *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v148.m_SpaceInfo.m_KeywordSpace;
		          *(_QWORD *)&v140 = *(_QWORD *)&v148.m_Index;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
		          flowVLNoiseEnabled = HG::Rendering::Runtime::HGVolumetricFogConfig::get_flowVLNoiseEnabled(
		                                 p_volumetricFogConfig,
		                                 0LL);
		          UnityEngine::Rendering::CommandBuffer::SetKeyword(
		            cmd,
		            volumetricFogLightScatteringCS,
		            (LocalKeyword *)&keyword.m_Name,
		            flowVLNoiseEnabled,
		            0LL);
		          memset(&v149, 0, sizeof(v149));
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(
		            &v149,
		            volumetricFogLightScatteringCS,
		            (String *)"ENABLE_SCALARIZE_DYNAMIC_LIGHTLOOP",
		            0LL);
		          *(_QWORD *)&v140 = *(_QWORD *)&v149.m_Index;
		          *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v149.m_SpaceInfo.m_KeywordSpace;
		          UnityEngine::Rendering::CommandBuffer::SetKeyword(
		            cmd,
		            volumetricFogLightScatteringCS,
		            (LocalKeyword *)&keyword.m_Name,
		            v137,
		            0LL);
		          memset(&v142, 0, 24);
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(
		            (LocalKeyword *)&v142,
		            volumetricFogLightScatteringCS,
		            (String *)"HG_DISABLE_PUNCTUAL_LIGHT_SHADOW",
		            0LL);
		          *(_QWORD *)&v140 = v142.m_BufferPointer;
		          *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v142.m_Type;
		          UnityEngine::Rendering::CommandBuffer::SetKeyword(
		            cmd,
		            volumetricFogLightScatteringCS,
		            (LocalKeyword *)&keyword.m_Name,
		            !IsValid,
		            0LL);
		          if ( v11->fields.temporalHistoryIsValid )
		          {
		            if ( !hgCamera )
		              goto LABEL_46;
		            historyVolumetricLightScatteringPreExposure = hgCamera->fields.historyVolumetricLightScatteringPreExposure;
		          }
		          else
		          {
		            historyVolumetricLightScatteringPreExposure = 1.0;
		          }
		          v31 = *(_OWORD *)&v24->fields.skyConfig.skyAmbientSH.shr0;
		          v32 = *(_OWORD *)&v24->fields.skyConfig.skyAmbientSH.shr4;
		          v150.shb8 = v24->fields.skyConfig.skyAmbientSH.shb8;
		          *(_OWORD *)&v150.shr0 = v31;
		          v33 = *(_OWORD *)&v24->fields.skyConfig.skyAmbientSH.shr8;
		          *(_OWORD *)&v150.shr4 = v32;
		          v34 = *(_OWORD *)&v24->fields.skyConfig.skyAmbientSH.shg3;
		          *(_OWORD *)&v150.shr8 = v33;
		          v35 = *(_OWORD *)&v24->fields.skyConfig.skyAmbientSH.shg7;
		          *(_OWORD *)&v150.shg3 = v34;
		          v36 = *(_OWORD *)&v24->fields.skyConfig.skyAmbientSH.shb2;
		          *(_OWORD *)&v150.shg7 = v35;
		          *(_QWORD *)&v150.shb6 = *(_QWORD *)&v24->fields.skyConfig.skyAmbientSH.shb6;
		          *(_OWORD *)&v150.shb2 = v36;
		          CoefficientsL1 = HG::Rendering::Runtime::HGEnvironmentUtils::GetCoefficientsL1(
		                             (SHCoefficientsL1 *)&v144,
		                             &v150,
		                             0LL);
		          shAr = CoefficientsL1->shAr;
		          shAg = CoefficientsL1->shAg;
		          shAb = CoefficientsL1->shAb;
		          sub_18033B9D0(v151, 0LL, 480LL);
		          volumetricFogAlbedo = p_volumetricFogConfig->volumetricFogAlbedo;
		          v41 = HG::Rendering::Runtime::VectorSwizzleUtils::rgb(&threadGroupsX, &volumetricFogAlbedo, 0LL);
		          volumetricFogExtinctionScale = p_volumetricFogConfig->volumetricFogExtinctionScale;
		          v43 = *(_QWORD *)&v41->x;
		          z = v41->z;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		          *(_QWORD *)&threadGroupsX.x = v43;
		          threadGroupsX.z = z;
		          v45 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                  (Vector4 *)&keyword.m_Name,
		                  &threadGroupsX,
		                  volumetricFogExtinctionScale,
		                  0LL);
		          *(_QWORD *)&threadGroupsX.x = *(_QWORD *)&v11->fields.volumetricFogEmissive.x;
		          v46 = *v45;
		          threadGroupsX.z = v11->fields.volumetricFogEmissive.z;
		          v151[0] = v46;
		          v47 = HG::Rendering::Runtime::HGUtils::PackVector4((Vector4 *)&keyword.m_Name, &threadGroupsX, 0LL);
		          v48 = !v11->fields.temporalHistoryIsValid;
		          v151[1] = *v47;
		          if ( v48 )
		          {
		            v49 = 0.0;
		          }
		          else
		          {
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		            s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_settingParameters;
		            if ( !s_settingParameters )
		              goto LABEL_46;
		            v49 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                    *((SettingParameter_1_System_Single_ **)s_settingParameters + 9),
		                    MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		          }
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		          s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_settingParameters;
		          if ( s_settingParameters )
		          {
		            v50 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                    *((SettingParameter_1_System_Single_ **)s_settingParameters + 10),
		                    MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		            v51 = 1.0;
		            if ( historyVolumetricLightScatteringPreExposure > 0.0 )
		              v51 = 1.0 / historyVolumetricLightScatteringPreExposure;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		            v151[2] = *HG::Rendering::Runtime::HGUtils::PackVector4(
		                         (Vector4 *)&keyword.m_Name,
		                         v49,
		                         v50,
		                         historyVolumetricLightScatteringPreExposure,
		                         v51,
		                         0LL);
		            fwd = UnityEngine::Vector3::get_fwd((Vector3 *)&volumetricFogAlbedo, v52);
		            rotationAtmosphere = v24->fields.lightConfig.rotationAtmosphere;
		            v55 = *(_QWORD *)&fwd->x;
		            *(float *)&fwd = fwd->z;
		            *(_QWORD *)&threadGroupsX.x = v55;
		            LODWORD(threadGroupsX.z) = (_DWORD)fwd;
		            *(Quaternion *)&keyword.m_Name = rotationAtmosphere;
		            v56 = UnityEngine::Quaternion::op_Multiply(
		                    (Vector3 *)&volumetricFogAlbedo,
		                    (Quaternion *)&keyword.m_Name,
		                    &threadGroupsX,
		                    0LL);
		            *(_QWORD *)&rotationAtmosphere.x = *(_QWORD *)&v56->x;
		            *(float *)&v56 = v56->z;
		            *(_QWORD *)&threadGroupsX.x = *(_QWORD *)&rotationAtmosphere.x;
		            LODWORD(threadGroupsX.z) = (_DWORD)v56;
		            v58 = UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&volumetricFogAlbedo, &threadGroupsX, v57);
		            historyMissSuperSampleCount = (float)v11->fields.historyMissSuperSampleCount;
		            *(_QWORD *)&rotationAtmosphere.x = *(_QWORD *)&v58->x;
		            *(float *)&v58 = v58->z;
		            *(_QWORD *)&threadGroupsX.x = *(_QWORD *)&rotationAtmosphere.x;
		            LODWORD(threadGroupsX.z) = (_DWORD)v58;
		            v60 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                    (Vector4 *)&keyword.m_Name,
		                    &threadGroupsX,
		                    historyMissSuperSampleCount,
		                    0LL);
		            v151[4] = shAr;
		            v151[5] = shAg;
		            v151[6] = shAb;
		            v61 = *v60;
		            threadGroupsX.z = v11->fields.volumetricFogEmissive.z;
		            v151[3] = v61;
		            *(_QWORD *)&threadGroupsX.x = *(_QWORD *)&v11->fields.volumetricFogEmissive.x;
		            v62 = *HG::Rendering::Runtime::HGUtils::PackVector4((Vector4 *)&keyword.m_Name, &threadGroupsX, 0LL);
		            *(Color *)&keyword.m_Name = v24->fields.lightConfig.directColor;
		            v151[7] = v62;
		            v63 = HG::Rendering::Runtime::VectorSwizzleUtils::rgb(
		                    (Vector3 *)&volumetricFogAlbedo,
		                    (Color *)&keyword.m_Name,
		                    0LL);
		            directIntensity = v24->fields.lightConfig.directIntensity;
		            *(_QWORD *)&v62.x = *(_QWORD *)&v63->x;
		            *(float *)&v63 = v63->z;
		            *(_QWORD *)&threadGroupsX.x = *(_QWORD *)&v62.x;
		            LODWORD(threadGroupsX.z) = (_DWORD)v63;
		            v66 = UnityEngine::Vector3::op_Multiply(
		                    (Vector3 *)&volumetricFogAlbedo,
		                    &threadGroupsX,
		                    directIntensity,
		                    v65);
		            v67 = *(_QWORD *)&v66->x;
		            *(float *)&v66 = v66->z;
		            *(_QWORD *)&threadGroupsX.x = v67;
		            LODWORD(threadGroupsX.z) = (_DWORD)v66;
		            v151[8] = *HG::Rendering::Runtime::HGUtils::PackVector4(
		                         (Vector4 *)&keyword.m_Name,
		                         &threadGroupsX,
		                         0.0,
		                         0LL);
		            v68 = p_volumetricFogConfig->flowVLNoiseDir.z;
		            flowVLNoiseSpeed = p_volumetricFogConfig->flowVLNoiseSpeed;
		            *(_QWORD *)&threadGroupsX.x = *(_QWORD *)&p_volumetricFogConfig->flowVLNoiseDir.x;
		            threadGroupsX.z = v68;
		            v71 = UnityEngine::Vector3::op_Multiply(
		                    (Vector3 *)&volumetricFogAlbedo,
		                    &threadGroupsX,
		                    flowVLNoiseSpeed,
		                    v70);
		            v72 = *(_QWORD *)&v71->x;
		            *(float *)&v71 = v71->z;
		            *(_QWORD *)&threadGroupsX.x = v72;
		            LODWORD(threadGroupsX.z) = (_DWORD)v71;
		            v73 = HG::Rendering::Runtime::HGUtils::PackVector4((Vector4 *)&keyword.m_Name, &threadGroupsX, 0.0, 0LL);
		            v74 = 1.0 / p_volumetricFogConfig->flowVLNoiseDistance;
		            flowVLNoiseTilling = p_volumetricFogConfig->flowVLNoiseTilling;
		            flowVLNoiseIntensity = p_volumetricFogConfig->flowVLNoiseIntensity;
		            v151[9] = *v73;
		            v77 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                    (Vector4 *)&keyword.m_Name,
		                    flowVLNoiseIntensity,
		                    flowVLNoiseTilling,
		                    v74,
		                    p_volumetricFogConfig->flowVLNoiseRemapRange.x,
		                    0LL);
		            y = p_volumetricFogConfig->flowVLNoiseRemapRange.y;
		            v79 = *v77;
		            threadGroupsX.z = p_volumetricFogConfig->flowVLNoiseTillingScale.z;
		            v151[10] = v79;
		            *(_QWORD *)&threadGroupsX.x = *(_QWORD *)&p_volumetricFogConfig->flowVLNoiseTillingScale.x;
		            v80 = HG::Rendering::Runtime::HGUtils::PackVector4((Vector4 *)&keyword.m_Name, &threadGroupsX, y, 0LL);
		            flowVLNoisePerturbTilling = p_volumetricFogConfig->flowVLNoisePerturbTilling;
		            *(float *)&v72 = p_volumetricFogConfig->flowVLNoisePerturbIntensity;
		            v154 = 0;
		            v82 = *v80;
		            *(float *)&v80 = p_volumetricFogConfig->flowVLNoisePerturbSpeed.z;
		            v155 = 0;
		            v151[11] = v82;
		            LODWORD(threadGroupsX.z) = (_DWORD)v80;
		            *(_QWORD *)&threadGroupsX.x = *(_QWORD *)&p_volumetricFogConfig->flowVLNoisePerturbSpeed.x;
		            v152 = flowVLNoisePerturbTilling;
		            v153 = v72;
		            v83 = HG::Rendering::Runtime::HGUtils::PackVector4((Vector4 *)&keyword.m_Name, &threadGroupsX, 0.0, 0LL);
		            v84 = 3LL;
		            v85 = v151;
		            v86 = *v83;
		            p_source = &source;
		            v156 = v86;
		            do
		            {
		              v88 = v85[1];
		              *(_OWORD *)p_source = *v85;
		              v89 = v85[2];
		              *(_OWORD *)&p_source[16] = v88;
		              v90 = v85[3];
		              *(_OWORD *)&p_source[32] = v89;
		              v91 = v85[4];
		              *(_OWORD *)&p_source[48] = v90;
		              v92 = v85[5];
		              *(_OWORD *)&p_source[64] = v91;
		              v93 = v85[6];
		              *(_OWORD *)&p_source[80] = v92;
		              v94 = v85[7];
		              v85 += 8;
		              *(_OWORD *)&p_source[96] = v93;
		              p_source += 128;
		              *(_OWORD *)&p_source[-16] = v94;
		              --v84;
		            }
		            while ( v84 );
		            v95 = v85[1];
		            *(_OWORD *)p_source = *v85;
		            v96 = v85[2];
		            *(_OWORD *)&p_source[16] = v95;
		            v97 = v85[3];
		            *(_OWORD *)&p_source[32] = v96;
		            v98 = v85[4];
		            *(_OWORD *)&p_source[48] = v97;
		            v99 = v85[5];
		            *(_OWORD *)&p_source[64] = v98;
		            *(_OWORD *)&p_source[80] = v99;
		            Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(
		              &destination,
		              v11->fields.frameJitterOffsetValues.m_Buffer,
		              256LL,
		              0LL);
		            sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		            v100 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		                     (CBHandle *)&keyword.m_Name,
		                     &P2,
		                     480,
		                     0LL);
		            v101 = *(__m128i *)&v100->bufferId;
		            *(_QWORD *)&v140 = v100->ptr;
		            Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy((Void *)v140, &source, 480LL, 0LL);
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		            UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantBufferParam(
		              cmd,
		              volumetricFogLightScatteringCS,
		              TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VolumetricFogLightScatteringConstants,
		              _mm_cvtsi128_si32(v101),
		              _mm_cvtsi128_si32(_mm_srli_si128(v101, 4)),
		              _mm_cvtsi128_si32(_mm_srli_si128(v101, 8)),
		              0LL);
		            if ( value )
		            {
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		              VolumetricFogVBufferA = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VolumetricFogVBufferA;
		              v103 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		                       (RenderTargetIdentifier *)&v144,
		                       (Texture *)v11->fields.vBufferA,
		                       0LL);
		              v104 = *(_OWORD *)&v103->m_BufferPointer;
		              *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v103->m_Type;
		              v105 = *(_QWORD *)&v103->m_DepthSlice;
		              v140 = v104;
		              v141 = v105;
		              UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		                cmd,
		                volumetricFogLightScatteringCS,
		                0,
		                VolumetricFogVBufferA,
		                (RenderTargetIdentifier *)&keyword.m_Name,
		                0LL);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		              s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_settingParameters;
		              if ( !s_settingParameters )
		                goto LABEL_46;
		              if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                     *((SettingParameter_1_System_Boolean_ **)s_settingParameters + 14),
		                     MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		              {
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		                VolumetricFogVBufferB = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VolumetricFogVBufferB;
		                v107 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		                         (RenderTargetIdentifier *)&v144,
		                         (Texture *)v11->fields.vBufferB,
		                         0LL);
		                v108 = *(_OWORD *)&v107->m_BufferPointer;
		                *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v107->m_Type;
		                v109 = *(_QWORD *)&v107->m_DepthSlice;
		                v140 = v108;
		                v141 = v109;
		                UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		                  cmd,
		                  volumetricFogLightScatteringCS,
		                  0,
		                  VolumetricFogVBufferB,
		                  (RenderTargetIdentifier *)&keyword.m_Name,
		                  0LL);
		              }
		            }
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
		            if ( HG::Rendering::Runtime::HGVolumetricFogConfig::get_flowVLNoiseEnabled(p_volumetricFogConfig, 0LL) )
		            {
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		              VolumetricLight3DNoise = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VolumetricLight3DNoise;
		              v111 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		                       (RenderTargetIdentifier *)&v144,
		                       (Texture *)v11->fields.volumetricLight3DNoise,
		                       0LL);
		              v112 = *(_OWORD *)&v111->m_BufferPointer;
		              *(_OWORD *)&v142.m_Type = *(_OWORD *)&v111->m_Type;
		              v113 = *(_QWORD *)&v111->m_DepthSlice;
		              *(_OWORD *)&v142.m_BufferPointer = v112;
		              *(_QWORD *)&v142.m_DepthSlice = v113;
		              UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		                cmd,
		                volumetricFogLightScatteringCS,
		                0,
		                VolumetricLight3DNoise,
		                &v142,
		                0LL);
		              volumetricLight3DNoisePerturb = (Object_1 *)v11->fields.volumetricLight3DNoisePerturb;
		              sub_1800036A0(TypeInfo::UnityEngine::Object);
		              if ( UnityEngine::Object::op_Inequality(volumetricLight3DNoisePerturb, 0LL, 0LL) )
		                v115 = (Texture *)v11->fields.volumetricLight3DNoisePerturb;
		              else
		                v115 = (Texture *)v11->fields.volumetricLight3DNoise;
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		              v116 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_VolumetricLight3DNoisePerturb;
		              v117 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		                       (RenderTargetIdentifier *)&v144,
		                       v115,
		                       0LL);
		              v118 = *(_OWORD *)&v117->m_BufferPointer;
		              *(_OWORD *)&v142.m_Type = *(_OWORD *)&v117->m_Type;
		              v119 = *(_QWORD *)&v117->m_DepthSlice;
		              *(_OWORD *)&v142.m_BufferPointer = v118;
		              *(_QWORD *)&v142.m_DepthSlice = v119;
		              UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		                cmd,
		                volumetricFogLightScatteringCS,
		                0,
		                v116,
		                &v142,
		                0LL);
		            }
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		            LightScattering = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LightScattering;
		            v121 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		                     (RenderTargetIdentifier *)&v144,
		                     (Texture *)v11->fields.lightScattering,
		                     0LL);
		            v122 = *(_OWORD *)&v121->m_BufferPointer;
		            *(_OWORD *)&v142.m_Type = *(_OWORD *)&v121->m_Type;
		            v123 = *(_QWORD *)&v121->m_DepthSlice;
		            *(_OWORD *)&v142.m_BufferPointer = v122;
		            *(_QWORD *)&v142.m_DepthSlice = v123;
		            UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		              cmd,
		              volumetricFogLightScatteringCS,
		              0,
		              LightScattering,
		              &v142,
		              0LL);
		            if ( !v11->fields.temporalHistoryIsValid )
		            {
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		              LightScatteringHistory = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LightScatteringHistory;
		              volumetricBlackTexture3D = (Texture *)HG::Rendering::Runtime::HGVolumetricFogUtils::get_volumetricBlackTexture3D(0LL);
		LABEL_43:
		              v126 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		                       (RenderTargetIdentifier *)&v144,
		                       volumetricBlackTexture3D,
		                       0LL);
		              v127 = *(_OWORD *)&v126->m_BufferPointer;
		              *(_OWORD *)&v142.m_Type = *(_OWORD *)&v126->m_Type;
		              v128 = *(_QWORD *)&v126->m_DepthSlice;
		              *(_OWORD *)&v142.m_BufferPointer = v127;
		              *(_QWORD *)&v142.m_DepthSlice = v128;
		              UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		                cmd,
		                volumetricFogLightScatteringCS,
		                0,
		                LightScatteringHistory,
		                &v142,
		                0LL);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		              punctualLightShadowResult = v11->fields.punctualLightShadowResult;
		              PunctualLightShadowTexV2 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_PunctualLightShadowTexV2;
		              sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		              *(TextureHandle *)&keyword.m_Name = punctualLightShadowResult;
		              v131 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(
		                       (RenderTargetIdentifier *)&v144,
		                       (TextureHandle *)&keyword.m_Name,
		                       0LL);
		              v132 = *(_OWORD *)&v131->m_BufferPointer;
		              *(_OWORD *)&v142.m_Type = *(_OWORD *)&v131->m_Type;
		              v133 = *(_QWORD *)&v131->m_DepthSlice;
		              *(_OWORD *)&v142.m_BufferPointer = v132;
		              *(_QWORD *)&v142.m_DepthSlice = v133;
		              UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		                cmd,
		                volumetricFogLightScatteringCS,
		                0,
		                PunctualLightShadowTexV2,
		                &v142,
		                0LL);
		              v134 = *(float *)&v11->fields.volumetricFogGridSize.m_Z;
		              *(_QWORD *)&threadGroupsX.x = *(_QWORD *)&v11->fields.volumetricFogGridSize.m_X;
		              threadGroupsX.z = v134;
		              *(_QWORD *)&threadGroupsX.x = *(_QWORD *)&HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(
		                                                          (Vector3Int *)&volumetricFogAlbedo,
		                                                          (Vector3Int *)&threadGroupsX,
		                                                          8,
		                                                          0LL)->m_X;
		              UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
		                cmd,
		                volumetricFogLightScatteringCS,
		                0,
		                SLODWORD(threadGroupsX.x),
		                SLODWORD(threadGroupsX.y),
		                v11->fields.volumetricFogGridSize.m_Z,
		                0LL);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		              HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(&v11->fields.vBufferA, 0LL);
		              HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(&v11->fields.vBufferB, 0LL);
		              return;
		            }
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		            s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		            LightScatteringHistory = *((_DWORD *)s_settingParameters + 270);
		            if ( hgCamera )
		            {
		              volumetricBlackTexture3D = (Texture *)hgCamera->fields.historyVolumetricLightScatteringTexture;
		              goto LABEL_43;
		            }
		          }
		        }
		      }
		    }
		LABEL_46:
		    sub_1800D8260(s_settingParameters, v9);
		  }
		  s_settingParameters = IFix::WrappersManagerImpl::GetPatch(1557, 0LL);
		  if ( !s_settingParameters )
		    goto LABEL_46;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_637(
		    (ILFixDynamicMethodWrapper_2 *)s_settingParameters,
		    (Object *)this,
		    (Object *)cmd,
		    P2,
		    hasGridInjectionPass,
		    (Object *)passData,
		    0LL);
		}
		
		public void ComputeVolumetricFogFinalIntegration(CommandBuffer cmd, VolumetricFogPassConstructor.ComputeVolumetricFogPassData passData) {} // 0x0000000189CEBC0C-0x0000000189CEBF4C
		// Void ComputeVolumetricFogFinalIntegration(CommandBuffer, VolumetricFogPassConstructor+ComputeVolumetricFogPassData)
		void HG::Rendering::Runtime::HGVolumetricFogRenderer::ComputeVolumetricFogFinalIntegration(
		        HGVolumetricFogRenderer *this,
		        CommandBuffer *cmd,
		        VolumetricFogPassConstructor_ComputeVolumetricFogPassData *passData,
		        MethodInfo *method)
		{
		  HGCamera *v7; // rdx
		  char *v8; // rcx
		  int32_t memoryless_k__BackingField; // eax
		  __int128 v10; // xmm1
		  HGCamera *hgCamera; // rsi
		  __int128 v12; // xmm0
		  RenderTexture *v13; // rax
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  ComputeShader *volumetricFogFinalIntegrationCS; // rsi
		  int32_t LightScattering; // r14d
		  RenderTargetIdentifier *v18; // rax
		  HGCamera *v19; // rdx
		  HGShaderIDs__StaticFields *static_fields; // rcx
		  __int128 v21; // xmm1
		  __int64 v22; // xmm0_8
		  int32_t RWIntegratedLightScattering; // r14d
		  RenderTargetIdentifier *v24; // rax
		  __int128 v25; // xmm1
		  __int64 v26; // xmm0_8
		  int32_t m_Z; // eax
		  int32_t v28; // esi
		  RenderTargetIdentifier *v29; // rax
		  __int128 v30; // xmm1
		  __int64 v31; // rdx
		  HGVolumetricFogRenderer_HGVolumetricFogSettingParameters *s_settingParameters; // rcx
		  HGCamera *v33; // rdi
		  HGRuntimeGrassQuery_Node *v34; // r8
		  Int32__Array **v35; // r9
		  HGCamera *v36; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *threadGroupsY; // [rsp+28h] [rbp-59h]
		  MethodInfo *threadGroupsYa; // [rsp+28h] [rbp-59h]
		  Vector3Int threadGroupsX; // [rsp+48h] [rbp-39h] BYREF
		  RenderTargetIdentifier v41; // [rsp+58h] [rbp-29h] BYREF
		  RenderTextureDescriptor v42; // [rsp+88h] [rbp+7h] BYREF
		  Vector3Int v43; // [rsp+C8h] [rbp+47h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1560, 0LL) )
		  {
		    if ( passData )
		    {
		      memoryless_k__BackingField = passData->fields.volumeDesc._memoryless_k__BackingField;
		      v10 = *(_OWORD *)&passData->fields.volumeDesc._mipCount_k__BackingField;
		      hgCamera = passData->fields.hgCamera;
		      *(_OWORD *)&v42._width_k__BackingField = *(_OWORD *)&passData->fields.volumeDesc._width_k__BackingField;
		      v12 = *(_OWORD *)&passData->fields.volumeDesc._dimension_k__BackingField;
		      v42._memoryless_k__BackingField = memoryless_k__BackingField;
		      *(_OWORD *)&v42._mipCount_k__BackingField = v10;
		      *(_OWORD *)&v42._dimension_k__BackingField = v12;
		      v13 = HG::Rendering::Runtime::HGVolumetricFogUtils::GetAndCreateTemporaryRenderTexture(
		              &v42,
		              (String *)"_IntegratedLightScattering",
		              0LL);
		      if ( hgCamera )
		      {
		        hgCamera->fields.volumetricIntegratedLightScatteringTexture = v13;
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&hgCamera->fields.volumetricIntegratedLightScatteringTexture,
		          (HGRuntimeGrassQuery_Node *)v7,
		          v14,
		          v15,
		          threadGroupsY);
		        volumetricFogFinalIntegrationCS = passData->fields.volumetricFogFinalIntegrationCS;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        LightScattering = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_LightScattering;
		        v18 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		                (RenderTargetIdentifier *)&v42,
		                (Texture *)passData->fields.lightScattering,
		                0LL);
		        if ( !cmd )
		          goto LABEL_15;
		        v21 = *(_OWORD *)&v18->m_BufferPointer;
		        *(_OWORD *)&v41.m_Type = *(_OWORD *)&v18->m_Type;
		        v22 = *(_QWORD *)&v18->m_DepthSlice;
		        *(_OWORD *)&v41.m_BufferPointer = v21;
		        *(_QWORD *)&v41.m_DepthSlice = v22;
		        UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		          cmd,
		          volumetricFogFinalIntegrationCS,
		          0,
		          LightScattering,
		          &v41,
		          0LL);
		        v19 = passData->fields.hgCamera;
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        RWIntegratedLightScattering = static_fields->_RWIntegratedLightScattering;
		        if ( !v19 )
		LABEL_15:
		          sub_1800D8260(static_fields, v19);
		        v24 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		                (RenderTargetIdentifier *)&v42,
		                (Texture *)v19->fields.volumetricIntegratedLightScatteringTexture,
		                0LL);
		        v25 = *(_OWORD *)&v24->m_BufferPointer;
		        *(_OWORD *)&v41.m_Type = *(_OWORD *)&v24->m_Type;
		        v26 = *(_QWORD *)&v24->m_DepthSlice;
		        *(_OWORD *)&v41.m_BufferPointer = v25;
		        *(_QWORD *)&v41.m_DepthSlice = v26;
		        UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		          cmd,
		          volumetricFogFinalIntegrationCS,
		          0,
		          RWIntegratedLightScattering,
		          &v41,
		          0LL);
		        m_Z = passData->fields.volumetricFogGridSize.m_Z;
		        *(_QWORD *)&threadGroupsX.m_X = *(_QWORD *)&passData->fields.volumetricFogGridSize.m_X;
		        threadGroupsX.m_Z = m_Z;
		        *(_QWORD *)&threadGroupsX.m_X = *(_QWORD *)&HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(
		                                                      &v43,
		                                                      &threadGroupsX,
		                                                      8,
		                                                      0LL)->m_X;
		        UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
		          cmd,
		          volumetricFogFinalIntegrationCS,
		          0,
		          threadGroupsX.m_X,
		          threadGroupsX.m_Y,
		          1,
		          0LL);
		        v7 = passData->fields.hgCamera;
		        v8 = (char *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        v28 = *((_DWORD *)v8 + 272);
		        if ( v7 )
		        {
		          v29 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		                  (RenderTargetIdentifier *)&v42,
		                  (Texture *)v7->fields.volumetricIntegratedLightScatteringTexture,
		                  0LL);
		          v30 = *(_OWORD *)&v29->m_BufferPointer;
		          *(_OWORD *)&v41.m_Type = *(_OWORD *)&v29->m_Type;
		          *(_QWORD *)&v41.m_DepthSlice = *(_QWORD *)&v29->m_DepthSlice;
		          *(_OWORD *)&v41.m_BufferPointer = v30;
		          UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, v28, &v41, 0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		          s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->static_fields->s_settingParameters;
		          if ( !s_settingParameters )
		            sub_1800D8260(0LL, v31);
		          if ( !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                  s_settingParameters->fields.enableTemporalReprojection,
		                  MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		          {
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		            HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(&passData->fields.lightScattering, 0LL);
		            return;
		          }
		          v33 = passData->fields.hgCamera;
		          if ( v33 )
		          {
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		            HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(
		              &v33->fields.historyVolumetricLightScatteringTexture,
		              0LL);
		            v8 = (char *)passData->fields.hgCamera;
		            if ( v8 )
		            {
		              *((_QWORD *)v8 + 255) = passData->fields.lightScattering;
		              sub_18002D1B0(
		                (HGRuntimeGrassQuery_Node *)(v8 + 2040),
		                (HGRuntimeGrassQuery_Node *)v7,
		                v34,
		                v35,
		                threadGroupsYa);
		              v36 = passData->fields.hgCamera;
		              if ( v36 )
		              {
		                v36->fields.historyVolumetricLightScatteringPreExposure = 1.0;
		                return;
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_17:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1560, 0LL);
		  if ( !Patch )
		    goto LABEL_17;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		    (ILFixDynamicMethodWrapper_30 *)Patch,
		    (Object *)this,
		    (Object *)cmd,
		    (Object *)passData,
		    0LL);
		}
		
		public void ReleaseVolumetricFogTempRenderTexture(VolumetricFogPassConstructor.ComputeVolumetricFogPassData passData) {} // 0x0000000189CED664-0x0000000189CED724
		// Void ReleaseVolumetricFogTempRenderTexture(VolumetricFogPassConstructor+ComputeVolumetricFogPassData)
		void HG::Rendering::Runtime::HGVolumetricFogRenderer::ReleaseVolumetricFogTempRenderTexture(
		        HGVolumetricFogRenderer *this,
		        VolumetricFogPassConstructor_ComputeVolumetricFogPassData *passData,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGCamera *v6; // rcx
		  HGCamera *hgCamera; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1561, 0LL) )
		  {
		    if ( passData )
		    {
		      hgCamera = passData->fields.hgCamera;
		      if ( hgCamera )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(
		          &hgCamera->fields.volumetricIntegratedLightScatteringTexture,
		          0LL);
		        v6 = passData->fields.hgCamera;
		        if ( v6 )
		        {
		          HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(
		            &v6->fields.historyVolumetricLightScatteringTexture,
		            0LL);
		          HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(&passData->fields.vBufferA, 0LL);
		          HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(&passData->fields.vBufferB, 0LL);
		          HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(&passData->fields.lightScattering, 0LL);
		          return;
		        }
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1561, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)passData,
		    0LL);
		}
		
	}
}
