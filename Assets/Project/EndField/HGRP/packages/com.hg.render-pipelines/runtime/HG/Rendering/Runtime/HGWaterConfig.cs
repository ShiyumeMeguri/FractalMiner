using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Sirenix.OdinInspector;
using Unity.Collections;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[CreateAssetMenu(fileName = "HGWaterConfig", menuName = "HGWater/HGWaterConfig")]
	public class HGWaterConfig : ScriptableObject
	{
		public HGWaterConfig()
		{
			// // HGWaterConfig()
			// void HG::Rendering::Runtime::HGWaterConfig::HGWaterConfig(HGWaterConfig *this, MethodInfo *method)
			// {
			//   __m128i si128; // xmm0
			//   Color *v3; // rax
			//   __int64 v4; // r8
			//   Color *v5; // rax
			//   __int64 v6; // r8
			//   Color *v7; // rax
			//   __int64 v8; // r8
			//   TileBase *v9; // rdx
			//   ITilemap *v10; // r9
			//   TileAnimationData v11; // xmm1
			//   __int64 v12; // r8
			//   MethodInfo *v13; // rdx
			//   Vector4 *one; // rax
			//   Vector4 *v15; // r8
			//   MethodInfo *v16; // rdx
			//   Vector4 v17; // xmm1
			//   __int64 v18; // r8
			//   __m128i v19; // [rsp+20h] [rbp-28h] BYREF
			//   TileAnimationData v20; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   this.fields.useFlowMap = 1;
			//   si128 = _mm_load_si128((const __m128i *)&xmmword_18A3575C0);
			//   this.fields.flowSpeed = 5.0;
			//   this.fields.flowDirectionVector2 = 0LL;
			//   this.fields.normalTilling = 0.0099999998;
			//   this.fields.normalScale = 0.2;
			//   this.fields.flowFullCycle = 0.0099999998;
			//   this.fields.largeWaveFlowSpeed = 5.0;
			//   this.fields.largeWaveNormalTilling = 0.0099999998;
			//   this.fields.largeWaveNormalScale = 0.2;
			//   this.fields.flowFullCycleLarge = 0.0099999998;
			//   this.fields.displacementNormalStrength = 1.0;
			//   v19 = si128;
			//   v3 = UnityEngine::Color::op_Implicit((Color *)&v20, (Vector4 *)&v19, (MethodInfo *)this);
			//   v19 = _mm_load_si128((const __m128i *)&xmmword_18A3575C0);
			//   *(Color *)(v4 + 100) = *v3;
			//   v5 = UnityEngine::Color::op_Implicit((Color *)&v20, (Vector4 *)&v19, (MethodInfo *)v4);
			//   v19 = _mm_load_si128((const __m128i *)&xmmword_18A3575D0);
			//   *(Color *)(v6 + 116) = *v5;
			//   v7 = UnityEngine::Color::op_Implicit((Color *)&v20, (Vector4 *)&v19, (MethodInfo *)v6);
			//   *(Color *)(v8 + 132) = *v7;
			//   v11 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//            &v20,
			//            v9,
			//            (Vector3Int *)v8,
			//            v10,
			//            (MethodInfo *)v19.m128i_i64[0]);
			//   *(_DWORD *)(v12 + 196) = 1065353216;
			//   *(_DWORD *)(v12 + 200) = 1065353216;
			//   *(TileAnimationData *)(v12 + 148) = v11;
			//   *(_DWORD *)(v12 + 204) = 1045220557;
			//   *(_DWORD *)(v12 + 208) = 1065353216;
			//   *(_DWORD *)(v12 + 212) = 1036831949;
			//   one = UnityEngine::Vector4::get_one((Vector4 *)&v20, v13);
			//   v15[14] = *one;
			//   v17 = *UnityEngine::Vector4::get_one((Vector4 *)&v20, v16);
			//   *(_DWORD *)(v18 + 260) = 1045220557;
			//   *(_DWORD *)(v18 + 268) = 1120403456;
			//   *(Vector4 *)(v18 + 240) = v17;
			//   *(_DWORD *)(v18 + 280) = 1025758986;
			//   *(_DWORD *)(v18 + 284) = 1048576000;
			//   *(_DWORD *)(v18 + 288) = 1059816735;
			//   *(_DWORD *)(v18 + 292) = 1112014848;
			//   *(_DWORD *)(v18 + 300) = 1065353216;
			//   *(_DWORD *)(v18 + 304) = 1056964608;
			//   *(_DWORD *)(v18 + 308) = 1065353216;
			//   *(_DWORD *)(v18 + 312) = 1056964608;
			//   *(_DWORD *)(v18 + 320) = 1036831949;
			//   *(_DWORD *)(v18 + 324) = 1045220557;
			//   *(_DWORD *)(v18 + 328) = 1036831949;
			//   *(_DWORD *)(v18 + 332) = 1075838976;
			//   *(_DWORD *)(v18 + 336) = 1065353216;
			//   *(_DWORD *)(v18 + 340) = 1120403456;
			//   *(_DWORD *)(v18 + 344) = 1120403456;
			//   *(_DWORD *)(v18 + 368) = 1017370378;
			//   UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)v18, 0LL);
			// }
			// 
		}

		private void OnEnable()
		{
			// // Void OnEnable()
			// void HG::Rendering::Runtime::HGWaterConfig::OnEnable(HGWaterConfig *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4648, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4648, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGWaterConfig::UpdateConfig(this, 0LL);
			//   }
			// }
			// 
		}

		public void CopyConfig(ref HGWaterConfig.MaterialData materialData)
		{
			// // Void CopyConfig(HGWaterConfig+MaterialData ByRef)
			// void HG::Rendering::Runtime::HGWaterConfig::CopyConfig(
			//         HGWaterConfig *this,
			//         HGWaterConfig_MaterialData *materialData,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v5; // r8
			//   float y; // xmm1_4
			//   float z; // xmm2_4
			//   float TAAManualAlphaMode; // xmm3_4
			//   MethodInfo *v9; // r8
			//   float flowFullCycleLarge; // xmm2_4
			//   int v11; // eax
			//   bool v12; // zf
			//   float causticEndDepth; // xmm1_4
			//   float dirSpecNormalScaler; // xmm2_4
			//   float distanceNormalMinStrength; // xmm3_4
			//   float largeWaveNormalTilling; // xmm1_4
			//   float largeWaveNormalScale; // xmm2_4
			//   float largeWaveFlowSpeed; // xmm3_4
			//   float roughness; // xmm1_4
			//   float specular; // xmm2_4
			//   float envSpecularDesaturation; // xmm3_4
			//   float causticTilling; // xmm1_4
			//   float distanceBlend; // xmm2_4
			//   float flowSpeed; // xmm3_4
			//   float flowFullCycle; // xmm1_4
			//   float foamRoughness; // xmm2_4
			//   float foamShapeOffset; // xmm3_4
			//   float distanceFade; // xmm1_4
			//   float envLightSpecularIntensity; // xmm2_4
			//   float waveVertexDisplacementScaler; // xmm3_4
			//   float v31; // xmm6_4
			//   float safeFullAbsorpDistance; // xmm1_4
			//   float rippleNormalEdgeWidth; // xmm2_4
			//   float rayleighMieLerpFactor; // xmm3_4
			//   float causticOpacity; // xmm1_4
			//   float rippleNormalStrength; // xmm2_4
			//   float causticDistort; // xmm1_4
			//   float rippleHeightDisplacement; // xmm2_4
			//   float sceneColorEnvInfluence; // xmm3_4
			//   float v40; // xmm1_4
			//   float waterBaseColorSubsurfaceScaler; // xmm2_4
			//   float waveVertexDisplacementScalerSmall; // xmm0_4
			//   float emissiveStrength; // xmm1_4
			//   float largeWaveNormalType; // xmm3_4
			//   TileBase *v45; // rdx
			//   Vector3Int *v46; // r8
			//   ITilemap *v47; // r9
			//   TileBase *v48; // rdx
			//   Vector3Int *v49; // r8
			//   ITilemap *v50; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v52; // rdx
			//   __int64 v53; // rcx
			//   TileAnimationData flowBaseColor; // [rsp+20h] [rbp-30h] BYREF
			//   Color v55; // [rsp+30h] [rbp-20h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4651, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4651, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v53, v52);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1337(Patch, (Object *)this, materialData, 0LL);
			//   }
			//   else
			//   {
			//     flowBaseColor = (TileAnimationData)this.fields.flowBaseColor;
			//     flowBaseColor = (TileAnimationData)*UnityEngine::Color::op_Implicit(&v55, (Vector4 *)&flowBaseColor, v5);
			//     HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 0, (Vector4 *)&flowBaseColor, 0LL);
			//     y = this.fields.waterRayleighAbsorptionMeter2.y;
			//     z = this.fields.waterRayleighAbsorptionMeter2.z;
			//     TAAManualAlphaMode = (float)this.fields.TAAManualAlphaMode;
			//     *(float *)&flowBaseColor.m_AnimatedSprites = this.fields.waterRayleighAbsorptionMeter2.x;
			//     flowBaseColor.m_AnimationStartTime = TAAManualAlphaMode;
			//     *((float *)&flowBaseColor.m_AnimatedSprites + 1) = y;
			//     flowBaseColor.m_AnimationSpeed = z;
			//     HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 1, (Vector4 *)&flowBaseColor, 0LL);
			//     flowBaseColor = (TileAnimationData)this.fields.foamColorG;
			//     flowBaseColor = (TileAnimationData)*UnityEngine::Color::op_Implicit(&v55, (Vector4 *)&flowBaseColor, v9);
			//     HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 2, (Vector4 *)&flowBaseColor, 0LL);
			//     flowBaseColor = (TileAnimationData)this.fields.waterRayleighScatteringMeter;
			//     HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 3, (Vector4 *)&flowBaseColor, 0LL);
			//     flowBaseColor = (TileAnimationData)this.fields.waterRayleighAbsorptionMeter;
			//     HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 4, (Vector4 *)&flowBaseColor, 0LL);
			//     flowFullCycleLarge = this.fields.flowFullCycleLarge;
			//     v11 = -1;
			//     v12 = !this.fields.largeWaveInvDir;
			//     *(float *)&flowBaseColor.m_AnimatedSprites = this.fields.foamDisplacementDistance;
			//     if ( v12 )
			//       v11 = 1;
			//     *((float *)&flowBaseColor.m_AnimatedSprites + 1) = flowFullCycleLarge;
			//     *(_QWORD *)&flowBaseColor.m_AnimationSpeed = COERCE_UNSIGNED_INT((float)v11);
			//     HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 5, (Vector4 *)&flowBaseColor, 0LL);
			//     causticEndDepth = this.fields.causticEndDepth;
			//     dirSpecNormalScaler = this.fields.dirSpecNormalScaler;
			//     distanceNormalMinStrength = this.fields.distanceNormalMinStrength;
			//     *(float *)&flowBaseColor.m_AnimatedSprites = this.fields.causticSpeed;
			//     *((float *)&flowBaseColor.m_AnimatedSprites + 1) = causticEndDepth;
			//     flowBaseColor.m_AnimationSpeed = dirSpecNormalScaler;
			//     flowBaseColor.m_AnimationStartTime = distanceNormalMinStrength;
			//     HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 6, (Vector4 *)&flowBaseColor, 0LL);
			//     largeWaveNormalTilling = this.fields.largeWaveNormalTilling;
			//     largeWaveNormalScale = this.fields.largeWaveNormalScale;
			//     largeWaveFlowSpeed = this.fields.largeWaveFlowSpeed;
			//     *(float *)&flowBaseColor.m_AnimatedSprites = this.fields.normalTilling;
			//     *((float *)&flowBaseColor.m_AnimatedSprites + 1) = largeWaveNormalTilling;
			//     flowBaseColor.m_AnimationSpeed = largeWaveNormalScale;
			//     flowBaseColor.m_AnimationStartTime = largeWaveFlowSpeed;
			//     HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 7, (Vector4 *)&flowBaseColor, 0LL);
			//     roughness = this.fields.roughness;
			//     specular = this.fields.specular;
			//     envSpecularDesaturation = this.fields.envSpecularDesaturation;
			//     *(float *)&flowBaseColor.m_AnimatedSprites = this.fields.normalScale;
			//     *((float *)&flowBaseColor.m_AnimatedSprites + 1) = roughness;
			//     flowBaseColor.m_AnimationSpeed = specular;
			//     flowBaseColor.m_AnimationStartTime = envSpecularDesaturation;
			//     HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 8, (Vector4 *)&flowBaseColor, 0LL);
			//     causticTilling = this.fields.causticTilling;
			//     distanceBlend = this.fields.distanceBlend;
			//     flowSpeed = this.fields.flowSpeed;
			//     *(float *)&flowBaseColor.m_AnimatedSprites = this.fields.envLightIntensity;
			//     *((float *)&flowBaseColor.m_AnimatedSprites + 1) = causticTilling;
			//     flowBaseColor.m_AnimationSpeed = distanceBlend;
			//     flowBaseColor.m_AnimationStartTime = flowSpeed;
			//     HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 9, (Vector4 *)&flowBaseColor, 0LL);
			//     flowFullCycle = this.fields.flowFullCycle;
			//     foamRoughness = this.fields.foamRoughness;
			//     foamShapeOffset = this.fields.foamShapeOffset;
			//     *(float *)&flowBaseColor.m_AnimatedSprites = this.fields.foamOpacity;
			//     *((float *)&flowBaseColor.m_AnimatedSprites + 1) = flowFullCycle;
			//     flowBaseColor.m_AnimationSpeed = foamRoughness;
			//     flowBaseColor.m_AnimationStartTime = foamShapeOffset;
			//     HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 10, (Vector4 *)&flowBaseColor, 0LL);
			//     distanceFade = this.fields.distanceFade;
			//     envLightSpecularIntensity = this.fields.envLightSpecularIntensity;
			//     waveVertexDisplacementScaler = this.fields.waveVertexDisplacementScaler;
			//     *(float *)&flowBaseColor.m_AnimatedSprites = this.fields.waterIOR;
			//     *((float *)&flowBaseColor.m_AnimatedSprites + 1) = distanceFade;
			//     flowBaseColor.m_AnimationSpeed = envLightSpecularIntensity;
			//     flowBaseColor.m_AnimationStartTime = waveVertexDisplacementScaler;
			//     HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 11, (Vector4 *)&flowBaseColor, 0LL);
			//     v31 = 1.0;
			//     safeFullAbsorpDistance = this.fields.safeFullAbsorpDistance;
			//     rippleNormalEdgeWidth = this.fields.rippleNormalEdgeWidth;
			//     rayleighMieLerpFactor = this.fields.rayleighMieLerpFactor;
			//     flowBaseColor.m_AnimationStartTime = 1.0 / this.fields.foamFadeDistance;
			//     *(float *)&flowBaseColor.m_AnimatedSprites = safeFullAbsorpDistance;
			//     *((float *)&flowBaseColor.m_AnimatedSprites + 1) = rippleNormalEdgeWidth;
			//     flowBaseColor.m_AnimationSpeed = rayleighMieLerpFactor;
			//     HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 12, (Vector4 *)&flowBaseColor, 0LL);
			//     causticOpacity = this.fields.causticOpacity;
			//     rippleNormalStrength = this.fields.rippleNormalStrength;
			//     *(float *)&flowBaseColor.m_AnimatedSprites = this.fields.distanceEdgeBlendFactor;
			//     *((float *)&flowBaseColor.m_AnimatedSprites + 1) = causticOpacity;
			//     flowBaseColor.m_AnimationStartTime = rippleNormalStrength;
			//     flowBaseColor.m_AnimationSpeed = 32.0;
			//     HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 13, (Vector4 *)&flowBaseColor, 0LL);
			//     causticDistort = this.fields.causticDistort;
			//     rippleHeightDisplacement = this.fields.rippleHeightDisplacement;
			//     sceneColorEnvInfluence = this.fields.sceneColorEnvInfluence;
			//     *(float *)&flowBaseColor.m_AnimatedSprites = this.fields.causticStartDepth;
			//     *((float *)&flowBaseColor.m_AnimatedSprites + 1) = causticDistort;
			//     flowBaseColor.m_AnimationSpeed = rippleHeightDisplacement;
			//     flowBaseColor.m_AnimationStartTime = sceneColorEnvInfluence;
			//     HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 14, (Vector4 *)&flowBaseColor, 0LL);
			//     if ( !this.fields.useFlowMap )
			//       v31 = 0.0;
			//     v40 = this.fields.flowDirectionVector2.y;
			//     waterBaseColorSubsurfaceScaler = this.fields.waterBaseColorSubsurfaceScaler;
			//     HIDWORD(flowBaseColor.m_AnimatedSprites) = LODWORD(this.fields.flowDirectionVector2.x);
			//     flowBaseColor.m_AnimationSpeed = v40;
			//     flowBaseColor.m_AnimationStartTime = waterBaseColorSubsurfaceScaler;
			//     *(float *)&flowBaseColor.m_AnimatedSprites = v31;
			//     HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 15, (Vector4 *)&flowBaseColor, 0LL);
			//     waveVertexDisplacementScalerSmall = this.fields.waveVertexDisplacementScalerSmall;
			//     emissiveStrength = this.fields.emissiveStrength;
			//     largeWaveNormalType = (float)this.fields.largeWaveNormalType;
			//     flowBaseColor.m_AnimationSpeed = (float)this.fields.smallWaveNormalType;
			//     flowBaseColor.m_AnimationStartTime = largeWaveNormalType;
			//     *(float *)&flowBaseColor.m_AnimatedSprites = waveVertexDisplacementScalerSmall;
			//     *((float *)&flowBaseColor.m_AnimatedSprites + 1) = emissiveStrength;
			//     HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 16, (Vector4 *)&flowBaseColor, 0LL);
			//     *(float *)&flowBaseColor.m_AnimatedSprites = this.fields.displacementNormalStrength;
			//     *(Sprite__Array **)((char *)&flowBaseColor.m_AnimatedSprites + 4) = 0LL;
			//     flowBaseColor.m_AnimationStartTime = 0.0;
			//     HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 17, (Vector4 *)&flowBaseColor, 0LL);
			//     flowBaseColor = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                        (TileAnimationData *)&v55,
			//                        v45,
			//                        v46,
			//                        v47,
			//                        (MethodInfo *)flowBaseColor.m_AnimatedSprites);
			//     HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 18, (Vector4 *)&flowBaseColor, 0LL);
			//     flowBaseColor = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                        (TileAnimationData *)&v55,
			//                        v48,
			//                        v49,
			//                        v50,
			//                        (MethodInfo *)flowBaseColor.m_AnimatedSprites);
			//     HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 19, (Vector4 *)&flowBaseColor, 0LL);
			//   }
			// }
			// 
		}

		public void UpdateConfig()
		{
			// // Void UpdateConfig()
			// void HG::Rendering::Runtime::HGWaterConfig::UpdateConfig(HGWaterConfig *this, MethodInfo *method)
			// {
			//   HGWaterConfig_MaterialData *v3; // rax
			//   bool v4; // zf
			//   HGManagerContext *ManagerContext; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   HGWaterManager *waterManager_k__BackingField; // rdi
			//   String *name; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGWaterConfig_MaterialData materialData; // [rsp+30h] [rbp-28h] BYREF
			//   HGWaterConfig_MaterialData v12; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   materialData = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(4649, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4649, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			//     goto LABEL_7;
			//   }
			//   v3 = HG::Rendering::Runtime::HGWaterConfig::MaterialData::New(&v12, 0LL);
			//   v4 = !this.fields.isGamePlayConfig;
			//   materialData = *v3;
			//   if ( !v4 )
			//     return;
			//   HG::Rendering::Runtime::HGWaterConfig::CopyConfig(this, &materialData, 0LL);
			//   ManagerContext = HG::Rendering::Runtime::HGManagerContext::GetOrCreateManagerContext(0LL);
			//   if ( !ManagerContext
			//     || (waterManager_k__BackingField = ManagerContext.fields._waterManager_k__BackingField,
			//         name = UnityEngine::Object::get_name((Object_1 *)this, 0LL),
			//         !waterManager_k__BackingField) )
			//   {
			// LABEL_7:
			//     sub_180B536AC(v7, v6);
			//   }
			//   HG::Rendering::Runtime::HGWaterManager::UpdateStaticWater(
			//     waterManager_k__BackingField,
			//     name,
			//     this.fields.materialIndex,
			//     &materialData.vector4Array,
			//     0LL);
			// }
			// 
		}

		private const string PARAM_TYPE = "水体类型/水体类型选择";

		private const string PARAM_WAVE = "波形控制/波形参数";

		private const string PARAM_COLOR = "颜色控制/颜色参数";

		private const string PARAM_FOAM = "白沫控制/白沫参数";

		private const string PARAM_PHYSICAL = "水物理属性控制/物理参数";

		private const string PARAM_LIGHTING = "光照参数/光照参数调整";

		private const string PARAM_CAUSTIC = "焦散/焦散参数";

		private const string PARAM_INTERACTIVE = "交互参数/水体交互参数";

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static int[] s_MaterialIndices;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static int[] s_NormalIndices;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static ValueDropdownList<int> TAAOptions;

		public bool isGamePlayConfig;

		public bool useFlowMap;

		[Header("材质编号")]
		public int materialIndex;

		public float flowDirection;

		[HideInInspector]
		public Vector2 flowDirectionVector2;

		[Header("小波法线贴图类型")]
		public int smallWaveNormalType;

		[HGWaterConfig.RecommendedRangeAttribute(3f, 100f)]
		[Range(0f, 1000f)]
		[Header("小波流动速度")]
		public float flowSpeed;

		[Range(0.001f, 0.2f)]
		[Header("小波密度")]
		public float normalTilling;

		[Header("小波形法线强度")]
		[Range(0.001f, 2f)]
		public float normalScale;

		[Header("小波形flowFullCycle")]
		[Range(0f, 1f)]
		public float flowFullCycle;

		[Header("小波形顶点运动大小")]
		[HGWaterConfig.RecommendedRangeAttribute(0f, 0.2f)]
		[Range(0f, 2f)]
		public float waveVertexDisplacementScalerSmall;

		[Header("大波法线贴图类型")]
		public int largeWaveNormalType;

		[Header("大波型流动速度")]
		[HGWaterConfig.RecommendedRangeAttribute(3f, 100f)]
		[Range(0f, 100f)]
		public float largeWaveFlowSpeed;

		[Range(0.001f, 0.1f)]
		[Header("大波型密度")]
		public float largeWaveNormalTilling;

		[Header("大波型法线强度")]
		[Range(0.001f, 2f)]
		public float largeWaveNormalScale;

		[Header("大波形flowFullCycle")]
		[Range(0f, 1f)]
		public float flowFullCycleLarge;

		[Header("波形顶点运动大小")]
		[Range(0f, 2f)]
		[HGWaterConfig.RecommendedRangeAttribute(0f, 0.2f)]
		public float waveVertexDisplacementScaler;

		[Header("大波型反向")]
		public bool largeWaveInvDir;

		[Header("水体顶点偏移法线强度")]
		[Range(0f, 5f)]
		[HGWaterConfig.RecommendedRangeAttribute(0.5f, 1.5f)]
		public float displacementNormalStrength;

		[Header("色相深处")]
		public Color absorptionTint;

		[Header("色相浅处")]
		public Color absorptionTint2;

		[Header("散射颜色")]
		public Color scatterTint;

		[HideInInspector]
		[Header("水每米散射强度")]
		public Vector4 waterRayleighScatteringMeter;

		[HideInInspector]
		[Header("水每米对光的吸收度强度")]
		public Vector4 waterRayleighAbsorptionMeter;

		[HideInInspector]
		[Header("水每米对光的吸收度强度2")]
		public Vector4 waterRayleighAbsorptionMeter2;

		[HGWaterConfig.RecommendedRangeAttribute(0f, 20f)]
		[Range(0.001f, 100f)]
		[Header("不透明度")]
		public float absorptionScale;

		[HGWaterConfig.RecommendedRangeAttribute(0.5f, 2f)]
		[Header("水下绝对距离对不透明度影响参数,没特殊需要保持1就行")]
		[Range(0.001f, 5f)]
		public float distanceEdgeBlendFactor;

		[Header("瑞利/米氏散射混合系数")]
		[HGWaterConfig.RecommendedRangeAttribute(0f, 1f)]
		[Range(0f, 1f)]
		public float rayleighMieLerpFactor;

		[Range(0f, 50f)]
		[HGWaterConfig.RecommendedRangeAttribute(0f, 2f)]
		[Header("散射总强度")]
		public float scatterScale;

		[Range(0f, 2f)]
		[Header("环境光散射强度")]
		[HGWaterConfig.RecommendedRangeAttribute(0f, 1f)]
		public float envLightIntensity;

		[HGWaterConfig.RecommendedRangeAttribute(0f, 0.5f)]
		[Header("SceneColor对散射的影响")]
		[Range(0f, 2f)]
		public float sceneColorEnvInfluence;

		[Range(0f, 1000f)]
		[Header("全吸收距离")]
		public float safeFullAbsorpDistance;

		[Header("白沫底部颜色")]
		public Color flowBaseColor;

		[Header("白沫2通道颜色")]
		public Color foamColorG;

		[Range(0f, 5f)]
		[HGWaterConfig.RecommendedRangeAttribute(0f, 1f)]
		[Header("白沫可见度")]
		public float foamOpacity;

		[Range(0f, 2f)]
		[Header("白沫粗糙度")]
		[HGWaterConfig.RecommendedRangeAttribute(0f, 1f)]
		public float foamRoughness;

		[Header("白沫形状范围偏移")]
		[HGWaterConfig.RecommendedRangeAttribute(0f, 0.2f)]
		[Range(0f, 1f)]
		public float foamShapeOffset;

		[Header("白沫消失距离")]
		[Range(20f, 1000f)]
		public float foamFadeDistance;

		[Header("白沫顶点偏移")]
		[Range(0f, 2f)]
		public float foamDisplacementDistance;

		[Header("白沫自发光强度")]
		[Range(0f, 100f)]
		public float emissiveStrength;

		[Range(0f, 1f)]
		[HGWaterConfig.RecommendedRangeAttribute(0f, 0.1f)]
		[Header("粗糙度")]
		[HGWaterConfig.ResetableAttribute(0.04f)]
		public float roughness;

		[HGWaterConfig.RecommendedRangeAttribute(0.2f, 0.3f)]
		[Header("Specular")]
		[HGWaterConfig.ResetableAttribute(0.25f)]
		[Range(0f, 1f)]
		public float specular;

		[Range(0f, 10f)]
		[HGWaterConfig.ResetableAttribute(0.67f)]
		[Header("水体折射度")]
		[HGWaterConfig.RecommendedRangeAttribute(0f, 1f)]
		public float waterIOR;

		[Header("法线距离衰减")]
		[HGWaterConfig.ResetableAttribute(50f)]
		[HGWaterConfig.RecommendedRangeAttribute(50f, 100f)]
		[Range(0f, 1000f)]
		public float distanceFade;

		[Header("法线距离衰减后最小强度")]
		[HGWaterConfig.RecommendedRangeAttribute(0f, 0.2f)]
		[HGWaterConfig.ResetableAttribute(0f)]
		[Range(0f, 1f)]
		public float distanceNormalMinStrength;

		[HGWaterConfig.ResetableAttribute(1f)]
		[Range(0f, 1f)]
		[HGWaterConfig.RecommendedRangeAttribute(0.8f, 1f)]
		[Header("ibl环境光高光强度")]
		public float envLightSpecularIntensity;

		[HGWaterConfig.RecommendedRangeAttribute(0.5f, 1.2f)]
		[Range(0f, 2f)]
		[HGWaterConfig.ResetableAttribute(0.5f)]
		[Header("直接光高光聚拢度")]
		public float dirSpecNormalScaler;

		[Header("水表面贴花散射强度")]
		[HGWaterConfig.RecommendedRangeAttribute(0.9f, 1.1f)]
		[Range(0f, 1.5f)]
		[HGWaterConfig.ResetableAttribute(1f)]
		public float waterBaseColorSubsurfaceScaler;

		[Header("MipMap偏移")]
		[Range(0f, 1f)]
		[HGWaterConfig.ResetableAttribute(0.5f)]
		[HGWaterConfig.RecommendedRangeAttribute(0.4f, 0.6f)]
		public float envSpecularDesaturation;

		[Header("TAA模式")]
		public int TAAManualAlphaMode;

		[Range(0f, 2f)]
		[Header("焦散密度")]
		public float causticTilling;

		[Header("焦散可见度")]
		[Range(0f, 3f)]
		[HGWaterConfig.RecommendedRangeAttribute(0f, 1.5f)]
		public float causticOpacity;

		[Header("焦散扰动强度")]
		[Range(0f, 5f)]
		public float causticDistort;

		[Header("焦散移动强度")]
		[Range(0f, 10f)]
		public float causticSpeed;

		[Header("焦散起始深度")]
		[Range(0f, 2f)]
		public float causticStartDepth;

		[Header("焦散结束深度")]
		[Range(0.5f, 100f)]
		public float causticEndDepth;

		[Header("距离折射强度减弱")]
		[Range(0f, 100f)]
		public float distanceBlend;

		[Header("水体扩散收敛速度")]
		[Range(0.95f, 1f)]
		[Space]
		public float interactiveDamp;

		[Header("水体扩散Alpha")]
		[Range(0f, 1f)]
		public float interactiveAlpha;

		[Header("水体扩散Beta")]
		[Range(0f, 1f)]
		public float interactiveBeta;

		[Header("水体扩散速度")]
		[Range(0f, 1f)]
		public float interactiveSpeed;

		[Header("涟漪法线强度")]
		[Range(0f, 1f)]
		public float rippleNormalStrength;

		[Header("涟漪波峰宽度(只有pc生效)")]
		[Range(0f, 0.1f)]
		public float rippleNormalEdgeWidth;

		[Range(0f, 1f)]
		[Header("涟漪高度偏移")]
		public float rippleHeightDisplacement;

		[Range(0f, 1f)]
		[Header("角色周围Ripple模拟大小")]
		public float interactiveRippleSize;

		[Header("角色周围Ripple向前偏移距离")]
		[Range(0f, 1f)]
		public float interactiveRippleForwardOffset;

		[Range(0f, 0.2f)]
		[Header("静止涟漪产生频率")]
		public float stillRippleFrequency;

		[Range(0f, 1f)]
		[Header("运动涟漪产生频率")]
		public float moveRippleFrequency;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		public struct MaterialData
		{
			// (set) Token: 0x06001BBB RID: 7099 RVA: 0x000025D0 File Offset: 0x000007D0
			public Vector2 flowDirectionVector
			{
				set
				{
					// // Void set_flowDirectionVector(Vector2)
					// void HG::Rendering::Runtime::HGWaterConfig::MaterialData::set_flowDirectionVector(
					//         HGWaterConfig_MaterialData *this,
					//         Vector2 value,
					//         MethodInfo *method)
					// {
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					//   __int64 v6; // rdx
					//   __int64 v7; // rcx
					//   __int128 v9; // [rsp+28h] [rbp-30h]
					// 
					//   if ( IFix::WrappersManagerImpl::IsPatched(4654, 0LL) )
					//   {
					//     Patch = IFix::WrappersManagerImpl::GetPatch(4654, 0LL);
					//     if ( !Patch )
					//       sub_180B536AC(v7, v6);
					//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1339(Patch, this, value, 0LL);
					//   }
					//   else
					//   {
					//     v9 = *(_OWORD *)&this.vector4Array.m_Buffer[240];
					//     *(Vector2 *)((char *)&v9 + 4) = value;
					//     *(_OWORD *)&this.vector4Array.m_Buffer[240] = v9;
					//   }
					// }
					// 
				}
			}

			// (set) Token: 0x06001BBC RID: 7100 RVA: 0x000025D0 File Offset: 0x000007D0
			public float flowFullCycle
			{
				set
				{
					// // Void set_flowFullCycle(Single)
					// void HG::Rendering::Runtime::HGWaterConfig::MaterialData::set_flowFullCycle(
					//         HGWaterConfig_MaterialData *this,
					//         float value,
					//         MethodInfo *method)
					// {
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					//   __int64 v5; // rdx
					//   __int64 v6; // rcx
					//   __int128 v7; // [rsp+20h] [rbp-28h]
					// 
					//   if ( IFix::WrappersManagerImpl::IsPatched(4655, 0LL) )
					//   {
					//     Patch = IFix::WrappersManagerImpl::GetPatch(4655, 0LL);
					//     if ( !Patch )
					//       sub_180B536AC(v6, v5);
					//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1340(Patch, this, value, 0LL);
					//   }
					//   else
					//   {
					//     v7 = *(_OWORD *)&this.vector4Array.m_Buffer[160];
					//     *((float *)&v7 + 1) = value;
					//     *(_OWORD *)&this.vector4Array.m_Buffer[160] = v7;
					//   }
					// }
					// 
				}
			}

			// (set) Token: 0x06001BBD RID: 7101 RVA: 0x000025D0 File Offset: 0x000007D0
			public float flowFullCycleLarge
			{
				set
				{
					// // Void set_flowFullCycleLarge(Single)
					// void HG::Rendering::Runtime::HGWaterConfig::MaterialData::set_flowFullCycleLarge(
					//         HGWaterConfig_MaterialData *this,
					//         float value,
					//         MethodInfo *method)
					// {
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					//   __int64 v5; // rdx
					//   __int64 v6; // rcx
					//   __int128 v7; // [rsp+20h] [rbp-28h]
					// 
					//   if ( IFix::WrappersManagerImpl::IsPatched(4656, 0LL) )
					//   {
					//     Patch = IFix::WrappersManagerImpl::GetPatch(4656, 0LL);
					//     if ( !Patch )
					//       sub_180B536AC(v6, v5);
					//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1340(Patch, this, value, 0LL);
					//   }
					//   else
					//   {
					//     v7 = *(_OWORD *)&this.vector4Array.m_Buffer[80];
					//     *((float *)&v7 + 1) = value;
					//     *(_OWORD *)&this.vector4Array.m_Buffer[80] = v7;
					//   }
					// }
					// 
				}
			}

			// (set) Token: 0x06001BBE RID: 7102 RVA: 0x000025D0 File Offset: 0x000007D0
			public float largeWaveNormalScale
			{
				set
				{
					// // Void set_largeWaveNormalScale(Single)
					// void HG::Rendering::Runtime::HGWaterConfig::MaterialData::set_largeWaveNormalScale(
					//         HGWaterConfig_MaterialData *this,
					//         float value,
					//         MethodInfo *method)
					// {
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					//   __int64 v5; // rdx
					//   __int64 v6; // rcx
					//   __int128 v7; // [rsp+20h] [rbp-28h]
					// 
					//   if ( IFix::WrappersManagerImpl::IsPatched(4657, 0LL) )
					//   {
					//     Patch = IFix::WrappersManagerImpl::GetPatch(4657, 0LL);
					//     if ( !Patch )
					//       sub_180B536AC(v6, v5);
					//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1340(Patch, this, value, 0LL);
					//   }
					//   else
					//   {
					//     v7 = *(_OWORD *)&this.vector4Array.m_Buffer[112];
					//     *((float *)&v7 + 2) = value;
					//     *(_OWORD *)&this.vector4Array.m_Buffer[112] = v7;
					//   }
					// }
					// 
				}
			}

			// (set) Token: 0x06001BBF RID: 7103 RVA: 0x000025D0 File Offset: 0x000007D0
			public float waveVertexDisplacementScaler
			{
				set
				{
					// // Void set_waveVertexDisplacementScaler(Single)
					// void HG::Rendering::Runtime::HGWaterConfig::MaterialData::set_waveVertexDisplacementScaler(
					//         HGWaterConfig_MaterialData *this,
					//         float value,
					//         MethodInfo *method)
					// {
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					//   __int64 v5; // rdx
					//   __int64 v6; // rcx
					//   __int128 v7; // [rsp+20h] [rbp-28h]
					// 
					//   if ( IFix::WrappersManagerImpl::IsPatched(4658, 0LL) )
					//   {
					//     Patch = IFix::WrappersManagerImpl::GetPatch(4658, 0LL);
					//     if ( !Patch )
					//       sub_180B536AC(v6, v5);
					//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1340(Patch, this, value, 0LL);
					//   }
					//   else
					//   {
					//     v7 = *(_OWORD *)&this.vector4Array.m_Buffer[176];
					//     *((float *)&v7 + 3) = value;
					//     *(_OWORD *)&this.vector4Array.m_Buffer[176] = v7;
					//   }
					// }
					// 
				}
			}

			public static HGWaterConfig.MaterialData New()
			{
				// // HGWaterConfig+MaterialData New()
				// HGWaterConfig_MaterialData *HG::Rendering::Runtime::HGWaterConfig::MaterialData::New(
				//         HGWaterConfig_MaterialData *__return_ptr retstr,
				//         MethodInfo *method)
				// {
				//   struct MethodInfo *v3; // rdi
				//   __int64 v4; // rax
				//   __int64 v5; // rcx
				//   HGWaterConfig_MaterialData v6; // xmm0
				//   HGWaterConfig_MaterialData *result; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v9; // rdx
				//   __int64 v10; // rcx
				//   NativeArray_1_Unity_Mathematics_quaternion_ array; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   if ( !byte_18D8EDBB7 )
				//   {
				//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
				//     byte_18D8EDBB7 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(4650, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(4650, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v10, v9);
				//     v6 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1335((HGWaterConfig_MaterialData *)&array, Patch, 0LL);
				//   }
				//   else
				//   {
				//     v3 = MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray;
				//     array = 0LL;
				//     v4 = sub_18010B520(MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray.klass);
				//     Unity::Collections::NativeArray<Unity::Mathematics::quaternion>::Allocate(
				//       20,
				//       Allocator__Enum_Temp,
				//       &array,
				//       **(MethodInfo ***)(v4 + 192));
				//     v5 = *(_QWORD *)(*(_QWORD *)(sub_18010B520(v3.klass) + 192) + 16LL);
				//     if ( !*(_QWORD *)(v5 + 56) )
				//       sub_180041F40(v5);
				//     Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemSet(array.m_Buffer, 0, 16LL * array.m_Length, 0LL);
				//     v6 = (HGWaterConfig_MaterialData)array;
				//   }
				//   result = retstr;
				//   *retstr = v6;
				//   return result;
				// }
				// 
				return default(HGWaterConfig.MaterialData);
			}

			public void SetValue(int index, Vector4 value)
			{
				// // Void SetValue(Int32, Vector4)
				// // local variable allocation has failed, the output may be wrong!
				// void HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(
				//         HGWaterConfig_MaterialData *this,
				//         int32_t index,
				//         Vector4 *value,
				//         MethodInfo *method)
				// {
				//   __int64 v5; // rdi
				//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rax
				//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
				//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
				//   ILFixDynamicMethodWrapper_2__Array *v10; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
				// 
				//   v5 = index;
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, *(_QWORD *)&index);
				//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   static_fields = v7.static_fields;
				//   wrapperArray = static_fields.wrapperArray;
				//   if ( !static_fields.wrapperArray )
				//     goto LABEL_8;
				//   if ( wrapperArray.max_length.size <= 4652 )
				//   {
				// LABEL_7:
				//     *(Vector4 *)&this.vector4Array.m_Buffer[16 * v5] = *value;
				//     return;
				//   }
				//   if ( !v7._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(v7, wrapperArray);
				//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   static_fields = v7.static_fields;
				//   v10 = static_fields.wrapperArray;
				//   if ( !static_fields.wrapperArray )
				//     goto LABEL_8;
				//   if ( v10.max_length.size <= 0x122Cu )
				//     sub_180070270(static_fields, wrapperArray);
				//   if ( !v10[129].vector[8] )
				//     goto LABEL_7;
				//   Patch = IFix::WrappersManagerImpl::GetPatch(4652, 0LL);
				//   if ( !Patch )
				// LABEL_8:
				//     sub_180B536AC(static_fields, wrapperArray);
				//   v12 = *value;
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1336(Patch, this, v5, &v12, 0LL);
				// }
				// 
			}

			public NativeArray<Vector4> vector4Array;
		}

		public class RecommendedRangeAttribute : Attribute
		{
			// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x000025F0 File Offset: 0x000007F0
			public float MinRecommended
			{
				[CompilerGenerated]
				get
				{
					// // Single get_override()
					// float HG::Rendering::Runtime::ScalableSettingValue<float>::get_override(
					//         ScalableSettingValue_1_System_Single_ *this,
					//         MethodInfo *method)
					// {
					//   return this.fields.m_Override;
					// }
					// 
					return 0f;
				}
			}

			// (get) Token: 0x06001BC3 RID: 7107 RVA: 0x000025F0 File Offset: 0x000007F0
			public float MaxRecommended
			{
				[CompilerGenerated]
				get
				{
					// // Single get_value()
					// float Rewired::Utils::Classes::Utility::ValueWatcher<float>::get_value(
					//         ValueWatcher_1_System_Single_ *this,
					//         MethodInfo *method)
					// {
					//   return this.fields.lbeYGGLqExuAmnvpTifZPpiwyZrH;
					// }
					// 
					return 0f;
				}
			}

			public RecommendedRangeAttribute(float min, float max)
			{
				// // MinMaxRangeAttribute(Single, Single)
				// void VLB::MinMaxRangeAttribute::MinMaxRangeAttribute(
				//         MinMaxRangeAttribute *this,
				//         float min,
				//         float max,
				//         MethodInfo *method)
				// {
				//   this.fields._minValue_k__BackingField = min;
				//   this.fields._maxValue_k__BackingField = max;
				// }
				// 
			}
		}

		public class ResetableAttribute : Attribute
		{
			// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x000025F0 File Offset: 0x000007F0
			public float DefaultValue
			{
				[CompilerGenerated]
				get
				{
					// // Single get_override()
					// float HG::Rendering::Runtime::ScalableSettingValue<float>::get_override(
					//         ScalableSettingValue_1_System_Single_ *this,
					//         MethodInfo *method)
					// {
					//   return this.fields.m_Override;
					// }
					// 
					return 0f;
				}
			}

			public ResetableAttribute(float defaultValue)
			{
				// // Void set_override(Single)
				// void HG::Rendering::Runtime::ScalableSettingValue<float>::set_override(
				//         ScalableSettingValue_1_System_Single_ *this,
				//         float value,
				//         MethodInfo *method)
				// {
				//   this.fields.m_Override = value;
				// }
				// 
			}
		}
	}
}
