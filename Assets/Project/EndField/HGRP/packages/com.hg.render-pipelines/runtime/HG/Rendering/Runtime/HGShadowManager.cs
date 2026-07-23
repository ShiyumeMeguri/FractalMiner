using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class HGShadowManager // TypeDefIndex: 37839
	{
		// Fields
		private const int k_MaxCharacterShadowmapCapacity = 14; // Metadata: 0x02303181
		private static int m_CharacterShadowmapResolution; // 0x00
		private Vector4[] m_CharacterShadowBiases; // 0x10
		private Matrix4x4[] m_CharacterShadowMatrices; // 0x18
		private static Matrix4x4[] m_CharacterWorldToLightMatrices; // 0x08
		private static Matrix4x4[] m_CharacterProjectionMatrices; // 0x10
		private static Vector4[] m_CharacterShadowLightDirs; // 0x18
		private static Vector4[] m_CharacterShadowAtlasParams; // 0x20
		private HGShadowSampleMode m_CharacterShadowSampleMode; // 0x20
		private static float m_CharacterDepthBias; // 0x28
		private static float m_CharacterNormalBias; // 0x2C
		private static float m_CharacterHardwareDepthBias; // 0x30
		private static float m_CharacterHardwareNormalBias; // 0x34
		private static Vector2Int m_CharacterShadowmapSize; // 0x38
		private TextureDesc m_characterShadowmapsDesc; // 0x28
		private static int m_CharacterShadowCount; // 0x40
		private static Vector2Int m_AtlasTileCount; // 0x44
		private static readonly RenderFunc<CharacterShadowPassData> s_disableCharacterShadowRenderFunc; // 0x50
		private static readonly RenderFunc<CharacterShadowPassData> s_renderCharacterShadowmapRenderFunc; // 0x58
		private static readonly RenderFunc<CharacterShadowPassData> s_renderCharacterShadowmapSetDataFunc; // 0x60
		public const int k_cascadedShadowCascadeCount = 4; // Metadata: 0x02303182
		public const int k_maxShadowMapCacheHistoryFrame = 32; // Metadata: 0x02303183
		public const int k_maxPunctualLightShadowmapCount = 24; // Metadata: 0x02303184
		public const int k_cascadedShadowViewBaseIndex = 0; // Metadata: 0x02303185
		public const int k_punctualShadowViewBaseIndex = 100; // Metadata: 0x02303186
		private bool m_hasDirectionLight; // 0x88
		private HGSharedLightData m_directionalLight; // 0x8C
		public bool enableShadowmap; // 0x94
		public bool enableCharacterShadowmap; // 0x95
		private int m_csmCascadeCount; // 0x98
		private Vector2Int m_csmShadowMapSize; // 0x9C
		private int m_csmShadowMapTileSize; // 0xA4
		private float m_csmShadowSoftness; // 0xA8
		private CSMRenderMode m_csmRenderMode; // 0xAC
		private Vector4 m_csmManualOverrideSphere; // 0xB0
		private float m_csmMaxDistance; // 0xC0
		private float m_csmNearPlaneOffset; // 0xC4
		private float[] m_csmShadowSplits; // 0xC8
		private float[] m_csmShadowSplitPercentage; // 0xD0
		private int[] m_csmCachedFrames; // 0xD8
		private float[] m_csmScreenSizeMinSquareds; // 0xE0
		private bool[] m_csmEnableOcclusionCulling; // 0xE8
		private int m_csmOcclusionDepthSize; // 0xF0
		private TextureDesc m_csmShadowMapTextureDesc; // 0xF8
		private RTHandle m_csmShadowMapAtlas; // 0x158
		private static Material s_clearShadowMaterial; // 0x68
		private static Material s_blitShadowMaterial; // 0x70
		private static Plane[] s_tempPlanes; // 0x78
		private CascadedShadowRequest m_csmShadowRequest; // 0x160
		internal HGPunctualLightShadowManagerV2 m_punctualLightShadowManagerV2; // 0x168
		internal HGHDPLSCharacterShadowManager m_hdplsCharacterShadowManager; // 0x170
		private bool m_useShadowMapCache; // 0x178
		private float m_csmDepthBias; // 0x17C
		private float m_csmNormalBias; // 0x180
		private float m_csmHardwareDepthBias; // 0x184
		private float m_csmHardwareNormalBias; // 0x188
		private float m_shadowIntensity; // 0x18C
		private float m_simulatedShadowAttenuationInVolume; // 0x190
		private float m_simulatedShadowBlendValue; // 0x194
		private bool m_enableCSMInVolume; // 0x198
		private int m_stopRenderCharacterCascade; // 0x19C
		private HGShadowSampleMode m_csmShadowSampleMode; // 0x1A0
		private Texture2D m_csmShadowRamp; // 0x1A8
		private CascadedShadowRequest m_cachedCascadedShadowRequest; // 0x1B0
		private bool[] m_updateCSMShadowMap; // 0x1B8
		private HGCamera m_cachedRenderedCamera; // 0x1C0
		private static readonly HGObjectFlags[] m_cascadeObjectFlags; // 0x80
		private static readonly HGRenderFlags[] m_cascadeRenderFlags; // 0x88
		private static readonly Vector2[] m_atlasScales; // 0x90
		private static readonly Vector2[] m_atlasOffsets; // 0x98
		private static readonly RenderFunc<ShadowPassData> s_csmShadowMapRenderFunc; // 0xA0
		private static readonly RenderFunc<ShadowPassData> s_disableDirectionalShadowRenderFunc; // 0xA8
		private static RendererList[] s_unityRendererLists; // 0xB0
		private static uint[] s_shadowRendererLists; // 0xB8
		private static uint[] s_shadowGrassLists; // 0xC0
		private static uint[] s_shadowTreeLists; // 0xC8
		private static IntPtr[] s_shadowDrawingSettings; // 0xD0
	
		// Nested types
		private class CharacterShadowPassData // TypeDefIndex: 37834
		{
			// Fields
			public VisibleLight shadowLight; // 0x10
			public int characterShadowCount; // 0xA4
			public int characterIndex; // 0xA8
			public int characterCount; // 0xAC
			public HGShadowSampleMode characterShadowSampleMode; // 0xB0
			public Rect renderRegion; // 0xB4
			public float hardwareDepthBias; // 0xC4
			public float hardwareNormalBias; // 0xC8
			public RendererListHandle[] characterShadowRendererLists; // 0xD0
			public uint[] characterShadowECSRendererLists; // 0xD8
			public TextureHandle characterShadowmap; // 0xE0
	
			// Constructors
			public CharacterShadowPassData() {} // 0x0000000189D16E5C-0x0000000189D16EB4
			// HGShadowManager+CharacterShadowPassData()
			void HG::Rendering::Runtime::HGShadowManager::CharacterShadowPassData::CharacterShadowPassData(
			        HGShadowManager_CharacterShadowPassData *this,
			        MethodInfo *method)
			{
			  HGRuntimeGrassQuery_Node *v3; // rdx
			  HGRuntimeGrassQuery_Node *v4; // r8
			  Int32__Array **v5; // r9
			  HGRuntimeGrassQuery_Node *v6; // rdx
			  HGRuntimeGrassQuery_Node *v7; // r8
			  Int32__Array **v8; // r9
			  MethodInfo *v9; // [rsp+20h] [rbp-8h]
			  MethodInfo *v10; // [rsp+50h] [rbp+28h]
			
			  this->fields.characterShadowRendererLists = (RendererListHandle__Array *)il2cpp_array_new_specific_1(
			                                                                             TypeInfo::HG::Rendering::RenderGraphModule::RendererListHandle,
			                                                                             14LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.characterShadowRendererLists, v3, v4, v5, v9);
			  this->fields.characterShadowECSRendererLists = (UInt32__Array *)il2cpp_array_new_specific_1(
			                                                                    TypeInfo::System::UInt32,
			                                                                    14LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.characterShadowECSRendererLists, v6, v7, v8, v10);
			}
			
		}
	
		private class CascadedShadowRequest // TypeDefIndex: 37835
		{
			// Fields
			public bool useCache; // 0x10
			public bool[] updateCache; // 0x18
			public int cascadeCount; // 0x20
			public int directionalLightIndex; // 0x24
			public Vector2Int directionalShadowMapSize; // 0x28
			public int directionalShadowMapTileSize; // 0x30
			public float directionalShadowStrength; // 0x34
			public Matrix4x4[] viewMatrices; // 0x38
			public Matrix4x4[] deviceProjectionYFlipMatrices; // 0x40
			public ShadowSplitData[] shadowSplitData; // 0x48
			public Matrix4x4[] worldToShadowMatrices; // 0x50
			public Vector4[] cascadeShadowSplitSpheres; // 0x58
			public Vector4[] cascadeShadowBiases; // 0x60
			public Vector4[] cascadeAtlasParams; // 0x68
	
			// Constructors
			public CascadedShadowRequest() {} // 0x000000018434B540-0x000000018434B640
			// HGShadowManager+CascadedShadowRequest()
			void HG::Rendering::Runtime::HGShadowManager::CascadedShadowRequest::CascadedShadowRequest(
			        HGShadowManager_CascadedShadowRequest *this,
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
			  MethodInfo *v27; // [rsp+20h] [rbp-8h]
			  MethodInfo *v28; // [rsp+20h] [rbp-8h]
			  MethodInfo *v29; // [rsp+20h] [rbp-8h]
			  MethodInfo *v30; // [rsp+20h] [rbp-8h]
			  MethodInfo *v31; // [rsp+20h] [rbp-8h]
			  MethodInfo *v32; // [rsp+20h] [rbp-8h]
			  MethodInfo *v33; // [rsp+20h] [rbp-8h]
			  MethodInfo *v34; // [rsp+50h] [rbp+28h]
			
			  this->fields.updateCache = (Boolean__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Boolean, 4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.updateCache, v3, v4, v5, v27);
			  this->fields.viewMatrices = (Matrix4x4__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Matrix4x4, 4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.viewMatrices, v6, v7, v8, v28);
			  this->fields.deviceProjectionYFlipMatrices = (Matrix4x4__Array *)il2cpp_array_new_specific_1(
			                                                                     TypeInfo::UnityEngine::Matrix4x4,
			                                                                     4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.deviceProjectionYFlipMatrices, v9, v10, v11, v29);
			  this->fields.shadowSplitData = (ShadowSplitData__Array *)il2cpp_array_new_specific_1(
			                                                             TypeInfo::UnityEngine::Rendering::ShadowSplitData,
			                                                             4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.shadowSplitData, v12, v13, v14, v30);
			  this->fields.worldToShadowMatrices = (Matrix4x4__Array *)il2cpp_array_new_specific_1(
			                                                             TypeInfo::UnityEngine::Matrix4x4,
			                                                             5LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.worldToShadowMatrices, v15, v16, v17, v31);
			  this->fields.cascadeShadowSplitSpheres = (Vector4__Array *)il2cpp_array_new_specific_1(
			                                                               TypeInfo::UnityEngine::Vector4,
			                                                               4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.cascadeShadowSplitSpheres, v18, v19, v20, v32);
			  this->fields.cascadeShadowBiases = (Vector4__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector4, 4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.cascadeShadowBiases, v21, v22, v23, v33);
			  this->fields.cascadeAtlasParams = (Vector4__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector4, 4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.cascadeAtlasParams, v24, v25, v26, v34);
			}
			
	
			// Methods
			public void CopyTo(CascadedShadowRequest target, int cascadeIndex) {} // 0x0000000189D16B44-0x0000000189D16E5C
			// Void CopyTo(HGShadowManager+CascadedShadowRequest, Int32)
			void HG::Rendering::Runtime::HGShadowManager::CascadedShadowRequest::CopyTo(
			        HGShadowManager_CascadedShadowRequest *this,
			        HGShadowManager_CascadedShadowRequest *target,
			        int32_t cascadeIndex,
			        MethodInfo *method)
			{
			  __int64 v5; // rbx
			  __int64 v7; // rdx
			  void *viewMatrices; // rcx
			  Matrix4x4__Array *v9; // r14
			  Matrix4x4__Array *deviceProjectionYFlipMatrices; // r14
			  ShadowSplitData__Array *shadowSplitData; // r14
			  Matrix4x4__Array *worldToShadowMatrices; // r14
			  __int64 v13; // r9
			  Vector4__Array *cascadeShadowSplitSpheres; // r14
			  __int64 v15; // r9
			  Vector4__Array *cascadeShadowBiases; // r14
			  __int64 v17; // r9
			  Vector4__Array *cascadeAtlasParams; // rdi
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int128 v20; // [rsp+30h] [rbp-D8h] BYREF
			  __int128 v21; // [rsp+48h] [rbp-C0h] BYREF
			  __int128 v22; // [rsp+58h] [rbp-B0h]
			  __int128 v23; // [rsp+68h] [rbp-A0h]
			  __int128 v24; // [rsp+78h] [rbp-90h]
			  __int128 v25; // [rsp+88h] [rbp-80h] BYREF
			  __int128 v26; // [rsp+98h] [rbp-70h]
			  __int128 v27; // [rsp+A8h] [rbp-60h]
			  __int128 v28; // [rsp+B8h] [rbp-50h]
			  _OWORD v29[11]; // [rsp+C8h] [rbp-40h] BYREF
			  __int64 v30; // [rsp+178h] [rbp+70h]
			  int v31; // [rsp+180h] [rbp+78h]
			  _OWORD v32[11]; // [rsp+188h] [rbp+80h] BYREF
			  __int64 v33; // [rsp+238h] [rbp+130h]
			  int v34; // [rsp+240h] [rbp+138h]
			
			  v5 = cascadeIndex;
			  if ( !IFix::WrappersManagerImpl::IsPatched(2163, 0LL) )
			  {
			    if ( target )
			    {
			      viewMatrices = this->fields.viewMatrices;
			      v9 = target->fields.viewMatrices;
			      if ( viewMatrices )
			      {
			        sub_180031960(viewMatrices, &v21, v5);
			        if ( v9 )
			        {
			          v25 = v21;
			          v26 = v22;
			          v27 = v23;
			          v28 = v24;
			          sub_180041540(v9, v5, &v25);
			          viewMatrices = this->fields.deviceProjectionYFlipMatrices;
			          deviceProjectionYFlipMatrices = target->fields.deviceProjectionYFlipMatrices;
			          if ( viewMatrices )
			          {
			            sub_180031960(viewMatrices, &v25, v5);
			            if ( deviceProjectionYFlipMatrices )
			            {
			              v21 = v25;
			              v22 = v26;
			              v23 = v27;
			              v24 = v28;
			              sub_180041540(deviceProjectionYFlipMatrices, v5, &v21);
			              viewMatrices = this->fields.shadowSplitData;
			              shadowSplitData = target->fields.shadowSplitData;
			              if ( viewMatrices )
			              {
			                sub_1808B5944(viewMatrices, v29, v5);
			                if ( shadowSplitData )
			                {
			                  v32[0] = v29[0];
			                  v32[1] = v29[1];
			                  v32[2] = v29[2];
			                  v32[3] = v29[3];
			                  v32[4] = v29[4];
			                  v32[5] = v29[5];
			                  v32[6] = v29[6];
			                  v32[7] = v29[7];
			                  v32[8] = v29[8];
			                  v32[9] = v29[9];
			                  v32[10] = v29[10];
			                  v33 = v30;
			                  v34 = v31;
			                  sub_1808B5B04(shadowSplitData, v5, v32);
			                  viewMatrices = this->fields.worldToShadowMatrices;
			                  worldToShadowMatrices = target->fields.worldToShadowMatrices;
			                  if ( viewMatrices )
			                  {
			                    sub_180031960(viewMatrices, &v25, v5);
			                    if ( worldToShadowMatrices )
			                    {
			                      v21 = v25;
			                      v22 = v26;
			                      v23 = v27;
			                      v24 = v28;
			                      sub_180041540(worldToShadowMatrices, v5, &v21);
			                      viewMatrices = this->fields.cascadeShadowSplitSpheres;
			                      cascadeShadowSplitSpheres = target->fields.cascadeShadowSplitSpheres;
			                      if ( viewMatrices )
			                      {
			                        sub_180002990(viewMatrices, (char *)&v20 + 8, v5, v13);
			                        if ( cascadeShadowSplitSpheres )
			                        {
			                          sub_18003FEF0(cascadeShadowSplitSpheres, v5, (char *)&v20 + 8);
			                          viewMatrices = this->fields.cascadeShadowBiases;
			                          cascadeShadowBiases = target->fields.cascadeShadowBiases;
			                          if ( viewMatrices )
			                          {
			                            sub_180002990(viewMatrices, (char *)&v20 + 8, v5, v15);
			                            if ( cascadeShadowBiases )
			                            {
			                              sub_18003FEF0(cascadeShadowBiases, v5, (char *)&v20 + 8);
			                              viewMatrices = this->fields.cascadeAtlasParams;
			                              cascadeAtlasParams = target->fields.cascadeAtlasParams;
			                              if ( viewMatrices )
			                              {
			                                sub_180002990(viewMatrices, (char *)&v20 + 8, v5, v17);
			                                if ( cascadeAtlasParams )
			                                {
			                                  sub_18003FEF0(cascadeAtlasParams, v5, (char *)&v20 + 8);
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
			LABEL_19:
			    sub_1800D8260(viewMatrices, v7);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(2163, 0LL);
			  if ( !Patch )
			    goto LABEL_19;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_37(
			    (ILFixDynamicMethodWrapper_15 *)Patch,
			    (Object *)this,
			    (Object *)target,
			    v5,
			    0LL);
			}
			
		}
	
		private class ShadowPassData // TypeDefIndex: 37836
		{
			// Fields
			public HGCamera hgCamera; // 0x10
			public CullingResults cullingResults; // 0x18
			public HGRenderGraphDefaultResources defaultResources; // 0x28
			public HGShadowSampleMode directionalShadowSampleMode; // 0x30
			public CascadedShadowRequest cascadedShadowRequest; // 0x38
			public Texture2D csmShadowRamp; // 0x40
			public TextureHandle directionalShadowAtlas; // 0x48
			public bool cullNonRealtimeCastersValue; // 0x58
			public Material blitShadowMaterial; // 0x60
			public Material clearShadowMaterial; // 0x68
			public readonly RendererList[] unityRendererLists; // 0x70
			public readonly uint[] shadowRendererLists; // 0x78
			public readonly uint[] shadowGrassLists; // 0x80
			public readonly uint[] shadowTreeLists; // 0x88
			public readonly ShadowDrawingSettings[] shadowDrawingSettings; // 0x90
			public readonly float[] hardwareBiasRatios; // 0x98
			public float hardwareDepthBias; // 0xA0
			public float hardwareNormalBias; // 0xA4
			public int stopRenderCharacterShadowCascade; // 0xA8
			public bool enableLocalShadow; // 0xAC
			public bool canCleanFullAtlas; // 0xAD
	
			// Constructors
			public ShadowPassData() {} // 0x0000000189D25064-0x0000000189D2513C
			// HGShadowManager+ShadowPassData()
			void HG::Rendering::Runtime::HGShadowManager::ShadowPassData::ShadowPassData(
			        HGShadowManager_ShadowPassData *this,
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
			  MethodInfo *v21; // [rsp+20h] [rbp-8h]
			  MethodInfo *v22; // [rsp+20h] [rbp-8h]
			  MethodInfo *v23; // [rsp+20h] [rbp-8h]
			  MethodInfo *v24; // [rsp+20h] [rbp-8h]
			  MethodInfo *v25; // [rsp+20h] [rbp-8h]
			  MethodInfo *v26; // [rsp+50h] [rbp+28h]
			
			  this->fields.unityRendererLists = (RendererList__Array *)il2cpp_array_new_specific_1(
			                                                             TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList,
			                                                             4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.unityRendererLists, v3, v4, v5, v21);
			  this->fields.shadowRendererLists = (UInt32__Array *)il2cpp_array_new_specific_1(TypeInfo::System::UInt32, 4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.shadowRendererLists, v6, v7, v8, v22);
			  this->fields.shadowGrassLists = (UInt32__Array *)il2cpp_array_new_specific_1(TypeInfo::System::UInt32, 4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.shadowGrassLists, v9, v10, v11, v23);
			  this->fields.shadowTreeLists = (UInt32__Array *)il2cpp_array_new_specific_1(TypeInfo::System::UInt32, 4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.shadowTreeLists, v12, v13, v14, v24);
			  this->fields.shadowDrawingSettings = (ShadowDrawingSettings__Array *)il2cpp_array_new_specific_1(
			                                                                         TypeInfo::UnityEngine::Rendering::ShadowDrawingSettings,
			                                                                         4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.shadowDrawingSettings, v15, v16, v17, v25);
			  this->fields.hardwareBiasRatios = (Single__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Single, 4LL);
			  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.hardwareBiasRatios, v18, v19, v20, v26);
			}
			
		}
	
		public enum CSMRenderMode // TypeDefIndex: 37837
		{
			Default = 0,
			ManualOverride = 1
		}
	
		// Constructors
		public HGShadowManager() {} // 0x000000018434B2F0-0x000000018434B540
		// HGShadowManager()
		void HG::Rendering::Runtime::HGShadowManager::HGShadowManager(HGShadowManager *this, MethodInfo *method)
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
		  HGShadowManager_CascadedShadowRequest *v24; // rax
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  HGShadowManager_CascadedShadowRequest *v27; // rdi
		  HGRuntimeGrassQuery_Node *v28; // rdx
		  HGRuntimeGrassQuery_Node *v29; // r8
		  Int32__Array **v30; // r9
		  HGPunctualLightShadowManagerV2 *v31; // rax
		  HGPunctualLightShadowManagerV2 *v32; // rdi
		  HGRuntimeGrassQuery_Node *v33; // rdx
		  HGRuntimeGrassQuery_Node *v34; // r8
		  Int32__Array **v35; // r9
		  HGHDPLSCharacterShadowManager *v36; // rax
		  HGHDPLSCharacterShadowManager *v37; // rdi
		  HGRuntimeGrassQuery_Node *v38; // rdx
		  HGRuntimeGrassQuery_Node *v39; // r8
		  Int32__Array **v40; // r9
		  HGShadowManager_CascadedShadowRequest *v41; // rax
		  HGShadowManager_CascadedShadowRequest *v42; // rdi
		  HGRuntimeGrassQuery_Node *v43; // rdx
		  HGRuntimeGrassQuery_Node *v44; // r8
		  Int32__Array **v45; // r9
		  HGRuntimeGrassQuery_Node *v46; // rdx
		  HGRuntimeGrassQuery_Node *v47; // r8
		  Int32__Array **v48; // r9
		  MethodInfo *v49; // [rsp+20h] [rbp-8h]
		  MethodInfo *v50; // [rsp+20h] [rbp-8h]
		  MethodInfo *v51; // [rsp+20h] [rbp-8h]
		  MethodInfo *v52; // [rsp+20h] [rbp-8h]
		  MethodInfo *v53; // [rsp+20h] [rbp-8h]
		  MethodInfo *v54; // [rsp+20h] [rbp-8h]
		  MethodInfo *v55; // [rsp+20h] [rbp-8h]
		  MethodInfo *v56; // [rsp+20h] [rbp-8h]
		  MethodInfo *v57; // [rsp+20h] [rbp-8h]
		  MethodInfo *v58; // [rsp+20h] [rbp-8h]
		  MethodInfo *v59; // [rsp+20h] [rbp-8h]
		  MethodInfo *v60; // [rsp+50h] [rbp+28h]
		
		  this->fields.m_CharacterShadowBiases = (Vector4__Array *)il2cpp_array_new_specific_1(
		                                                             TypeInfo::UnityEngine::Vector4,
		                                                             14LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v3, v4, v5, v49);
		  this->fields.m_CharacterShadowMatrices = (Matrix4x4__Array *)il2cpp_array_new_specific_1(
		                                                                 TypeInfo::UnityEngine::Matrix4x4,
		                                                                 14LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_CharacterShadowMatrices, v6, v7, v8, v50);
		  this->fields.m_csmManualOverrideSphere = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18B959A80);
		  this->fields.m_csmRenderMode = 1;
		  this->fields.m_csmShadowSplits = (Single__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Single, 4LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_csmShadowSplits, v9, v10, v11, v51);
		  this->fields.m_csmShadowSplitPercentage = (Single__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Single, 4LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_csmShadowSplitPercentage, v12, v13, v14, v52);
		  this->fields.m_csmCachedFrames = (Int32__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Int32, 4LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_csmCachedFrames, v15, v16, v17, v53);
		  this->fields.m_csmScreenSizeMinSquareds = (Single__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Single, 4LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_csmScreenSizeMinSquareds, v18, v19, v20, v54);
		  this->fields.m_csmEnableOcclusionCulling = (Boolean__Array *)il2cpp_array_new_specific_1(
		                                                                 TypeInfo::System::Boolean,
		                                                                 4LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_csmEnableOcclusionCulling, v21, v22, v23, v55);
		  this->fields.m_csmOcclusionDepthSize = 256;
		  v24 = (HGShadowManager_CascadedShadowRequest *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGShadowManager::CascadedShadowRequest);
		  v27 = v24;
		  if ( !v24 )
		    goto LABEL_6;
		  HG::Rendering::Runtime::HGShadowManager::CascadedShadowRequest::CascadedShadowRequest(v24, 0LL);
		  this->fields.m_csmShadowRequest = v27;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_csmShadowRequest, v28, v29, v30, v56);
		  v31 = (HGPunctualLightShadowManagerV2 *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
		  v32 = v31;
		  if ( !v31 )
		    goto LABEL_6;
		  HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::HGPunctualLightShadowManagerV2(v31, 0LL);
		  this->fields.m_punctualLightShadowManagerV2 = v32;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_punctualLightShadowManagerV2, v33, v34, v35, v57);
		  v36 = (HGHDPLSCharacterShadowManager *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		  v37 = v36;
		  if ( !v36 )
		    goto LABEL_6;
		  HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::HGHDPLSCharacterShadowManager(v36, 0LL);
		  this->fields.m_hdplsCharacterShadowManager = v37;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_hdplsCharacterShadowManager, v38, v39, v40, v58);
		  this->fields.m_shadowIntensity = 1.0;
		  this->fields.m_enableCSMInVolume = 1;
		  this->fields.m_stopRenderCharacterCascade = 4;
		  this->fields.m_csmShadowSampleMode = 4;
		  v41 = (HGShadowManager_CascadedShadowRequest *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGShadowManager::CascadedShadowRequest);
		  v42 = v41;
		  if ( !v41 )
		LABEL_6:
		    sub_1800D8260(v26, v25);
		  HG::Rendering::Runtime::HGShadowManager::CascadedShadowRequest::CascadedShadowRequest(v41, 0LL);
		  this->fields.m_cachedCascadedShadowRequest = v42;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_cachedCascadedShadowRequest, v43, v44, v45, v59);
		  this->fields.m_updateCSMShadowMap = (Boolean__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Boolean, 4LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_updateCSMShadowMap, v46, v47, v48, v60);
		}
		
		static HGShadowManager() {} // 0x0000000184723A70-0x0000000184724150
		// HGShadowManager()
		void HG::Rendering::Runtime::HGShadowManager::cctor(MethodInfo *method)
		{
		  __int64 v1; // rax
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v3; // r8
		  Int32__Array **v4; // r9
		  __int64 v5; // rax
		  HGShadowManager__StaticFields *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  __int64 v9; // rax
		  HGShadowManager__StaticFields *v10; // r8
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  Int32__Array **v12; // r9
		  __int64 v13; // rax
		  HGShadowManager__StaticFields *v14; // rdx
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  struct HGShadowManager_c__Class *v17; // rax
		  Object *v18; // rdi
		  RenderFunc_1_System_Object_ *v19; // rax
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  MonitorData *v22; // rbx
		  HGRuntimeGrassQuery_Node *v23; // rdx
		  HGRuntimeGrassQuery_Node *v24; // r8
		  Int32__Array **v25; // r9
		  Object *v26; // rdi
		  RenderFunc_1_System_Object_ *v27; // rax
		  RenderFunc_1_HG_Rendering_Runtime_HGShadowManager_CharacterShadowPassData_ *v28; // rbx
		  HGShadowManager__StaticFields *v29; // rdx
		  HGRuntimeGrassQuery_Node *v30; // r8
		  Int32__Array **v31; // r9
		  Object *v32; // rdi
		  RenderFunc_1_System_Object_ *v33; // rax
		  RenderFunc_1_HG_Rendering_Runtime_HGShadowManager_CharacterShadowPassData_ *v34; // rbx
		  HGShadowManager__StaticFields *v35; // rdx
		  HGRuntimeGrassQuery_Node *v36; // r8
		  Int32__Array **v37; // r9
		  __int64 v38; // rax
		  HGRuntimeGrassQuery_Node *v39; // rdx
		  HGRuntimeGrassQuery_Node *v40; // r8
		  Int32__Array **v41; // r9
		  Array *v42; // rbx
		  HGRuntimeGrassQuery_Node *v43; // rdx
		  HGRuntimeGrassQuery_Node *v44; // r8
		  Int32__Array **v45; // r9
		  Array *v46; // rbx
		  HGRuntimeGrassQuery_Node *v47; // rdx
		  HGRuntimeGrassQuery_Node *v48; // r8
		  Int32__Array **v49; // r9
		  __int64 v50; // rax
		  HGRuntimeGrassQuery_Node *v51; // r8
		  Int32__Array **v52; // r9
		  __int64 v53; // rax
		  HGRuntimeGrassQuery_Node *v54; // r8
		  Int32__Array **v55; // r9
		  Object *v56; // rdi
		  RenderFunc_1_System_Object_ *v57; // rax
		  RenderFunc_1_HG_Rendering_Runtime_HGShadowManager_ShadowPassData_ *v58; // rbx
		  HGShadowManager__StaticFields *v59; // rdx
		  HGRuntimeGrassQuery_Node *v60; // r8
		  Int32__Array **v61; // r9
		  Object *v62; // rdi
		  RenderFunc_1_System_Object_ *v63; // rax
		  RenderFunc_1_HG_Rendering_Runtime_HGShadowManager_ShadowPassData_ *v64; // rbx
		  HGShadowManager__StaticFields *v65; // rdx
		  HGRuntimeGrassQuery_Node *v66; // r8
		  Int32__Array **v67; // r9
		  __int64 v68; // rax
		  HGShadowManager__StaticFields *v69; // rdx
		  HGRuntimeGrassQuery_Node *v70; // r8
		  Int32__Array **v71; // r9
		  __int64 v72; // rax
		  HGRuntimeGrassQuery_Node *v73; // rdx
		  HGRuntimeGrassQuery_Node *v74; // r8
		  Int32__Array **v75; // r9
		  __int64 v76; // rax
		  HGRuntimeGrassQuery_Node *v77; // rdx
		  HGRuntimeGrassQuery_Node *v78; // r8
		  Int32__Array **v79; // r9
		  __int64 v80; // rax
		  HGRuntimeGrassQuery_Node *v81; // r8
		  HGRuntimeGrassQuery_Node *v82; // rdx
		  Int32__Array **v83; // r9
		  __int64 v84; // rax
		  HGRuntimeGrassQuery_Node *v85; // rdx
		  HGRuntimeGrassQuery_Node *v86; // r8
		  Int32__Array **v87; // r9
		  MethodInfo *v88; // [rsp+20h] [rbp-8h]
		  MethodInfo *v89; // [rsp+20h] [rbp-8h]
		  MethodInfo *v90; // [rsp+20h] [rbp-8h]
		  MethodInfo *v91; // [rsp+20h] [rbp-8h]
		  MethodInfo *v92; // [rsp+20h] [rbp-8h]
		  MethodInfo *v93; // [rsp+20h] [rbp-8h]
		  MethodInfo *v94; // [rsp+20h] [rbp-8h]
		  MethodInfo *v95; // [rsp+20h] [rbp-8h]
		  MethodInfo *v96; // [rsp+20h] [rbp-8h]
		  MethodInfo *v97; // [rsp+20h] [rbp-8h]
		  MethodInfo *v98; // [rsp+20h] [rbp-8h]
		  MethodInfo *v99; // [rsp+20h] [rbp-8h]
		  MethodInfo *v100; // [rsp+20h] [rbp-8h]
		  MethodInfo *v101; // [rsp+20h] [rbp-8h]
		  MethodInfo *v102; // [rsp+20h] [rbp-8h]
		  MethodInfo *v103; // [rsp+20h] [rbp-8h]
		  MethodInfo *v104; // [rsp+20h] [rbp-8h]
		  MethodInfo *v105; // [rsp+20h] [rbp-8h]
		  MethodInfo *v106; // [rsp+50h] [rbp+28h]
		
		  TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowmapResolution = 1024;
		  v1 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Matrix4x4, 14LL);
		  static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		  static_fields->monitor = (MonitorData *)v1;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterWorldToLightMatrices,
		    static_fields,
		    v3,
		    v4,
		    v88);
		  v5 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Matrix4x4, 14LL);
		  v6 = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		  v6->m_CharacterProjectionMatrices = (Matrix4x4__Array *)v5;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterProjectionMatrices,
		    (HGRuntimeGrassQuery_Node *)v6,
		    v7,
		    v8,
		    v89);
		  v9 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector4, 14LL);
		  v10 = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		  v10->m_CharacterShadowLightDirs = (Vector4__Array *)v9;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowLightDirs,
		    v11,
		    (HGRuntimeGrassQuery_Node *)v10,
		    v12,
		    v90);
		  v13 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector4, 14LL);
		  v14 = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		  v14->m_CharacterShadowAtlasParams = (Vector4__Array *)v13;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowAtlasParams,
		    (HGRuntimeGrassQuery_Node *)v14,
		    v15,
		    v16,
		    v91);
		  TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowCount = 0;
		  TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_AtlasTileCount = TypeInfo::UnityEngine::Vector2Int->static_fields->s_One;
		  v17 = TypeInfo::HG::Rendering::Runtime::HGShadowManager::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGShadowManager::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGShadowManager::__c);
		    v17 = TypeInfo::HG::Rendering::Runtime::HGShadowManager::__c;
		  }
		  v18 = (Object *)v17->static_fields->__9;
		  v19 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::HGShadowManager::CharacterShadowPassData>);
		  v22 = (MonitorData *)v19;
		  if ( !v19 )
		    goto LABEL_4;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v19,
		    v18,
		    MethodInfo::HG::Rendering::Runtime::HGShadowManager::__c::__cctor_b__104_0,
		    0LL);
		  v23 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		  v23[1].monitor = v22;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->s_disableCharacterShadowRenderFunc,
		    v23,
		    v24,
		    v25,
		    v92);
		  v26 = (Object *)TypeInfo::HG::Rendering::Runtime::HGShadowManager::__c->static_fields->__9;
		  v27 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::HGShadowManager::CharacterShadowPassData>);
		  v28 = (RenderFunc_1_HG_Rendering_Runtime_HGShadowManager_CharacterShadowPassData_ *)v27;
		  if ( !v27 )
		    goto LABEL_4;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v27,
		    v26,
		    MethodInfo::HG::Rendering::Runtime::HGShadowManager::__c::__cctor_b__104_1,
		    0LL);
		  v29 = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		  v29->s_renderCharacterShadowmapRenderFunc = v28;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->s_renderCharacterShadowmapRenderFunc,
		    (HGRuntimeGrassQuery_Node *)v29,
		    v30,
		    v31,
		    v93);
		  v32 = (Object *)TypeInfo::HG::Rendering::Runtime::HGShadowManager::__c->static_fields->__9;
		  v33 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::HGShadowManager::CharacterShadowPassData>);
		  v34 = (RenderFunc_1_HG_Rendering_Runtime_HGShadowManager_CharacterShadowPassData_ *)v33;
		  if ( !v33 )
		    goto LABEL_4;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v33,
		    v32,
		    MethodInfo::HG::Rendering::Runtime::HGShadowManager::__c::__cctor_b__104_2,
		    0LL);
		  v35 = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		  v35->s_renderCharacterShadowmapSetDataFunc = v34;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->s_renderCharacterShadowmapSetDataFunc,
		    (HGRuntimeGrassQuery_Node *)v35,
		    v36,
		    v37,
		    v94);
		  v38 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Plane, 6LL);
		  v39 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		  v39[1].fields.left = (HGRuntimeGrassQuery_Node *)v38;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->s_tempPlanes,
		    v39,
		    v40,
		    v41,
		    v95);
		  v42 = (Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::HyperGryph::HGObjectFlags, 4LL);
		  System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		    v42,
		    78D8408AC14D4B32840FE1C6340951C113424E6FA802CE859AC8998AD65F7E65_Field,
		    0LL);
		  v43 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		  v43[1].fields.right = (HGRuntimeGrassQuery_Node *)v42;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_cascadeObjectFlags,
		    v43,
		    v44,
		    v45,
		    v96);
		  v46 = (Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::HyperGryph::HGRenderFlags, 4LL);
		  System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		    v46,
		    498BA7B0561C0020588FE5A5C88DFB5A0D2E9B72C679CDA9FBC6288F3263399C_Field,
		    0LL);
		  v47 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		  v47[1].fields.grassInstanceBounds = (Bounds__Array *)v46;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_cascadeRenderFlags,
		    v47,
		    v48,
		    v49,
		    v97);
		  v50 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector2, 4LL);
		  v20 = v50;
		  if ( !v50 )
		    goto LABEL_4;
		  if ( !*(_DWORD *)(v50 + 24) )
		    goto LABEL_20;
		  *(_DWORD *)(v50 + 32) = 1065353216;
		  *(_DWORD *)(v50 + 36) = 1065353216;
		  if ( *(_DWORD *)(v50 + 24) <= 1u )
		    goto LABEL_20;
		  *(_DWORD *)(v50 + 40) = 1056964608;
		  *(_DWORD *)(v50 + 44) = 1065353216;
		  if ( *(_DWORD *)(v50 + 24) <= 2u )
		    goto LABEL_20;
		  *(_DWORD *)(v50 + 48) = 1056964608;
		  *(_DWORD *)(v50 + 52) = 1056964608;
		  if ( *(_DWORD *)(v50 + 24) <= 3u )
		    goto LABEL_20;
		  *(_DWORD *)(v50 + 56) = 1056964608;
		  *(_DWORD *)(v50 + 60) = 1056964608;
		  TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_atlasScales = (Vector2__Array *)v50;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_atlasScales,
		    (HGRuntimeGrassQuery_Node *)v50,
		    v51,
		    v52,
		    v98);
		  v53 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector2, 4LL);
		  v20 = v53;
		  if ( !v53 )
		    goto LABEL_4;
		  if ( !*(_DWORD *)(v53 + 24)
		    || (*(_QWORD *)(v53 + 32) = 0LL, *(_DWORD *)(v53 + 24) <= 1u)
		    || (*(_QWORD *)(v53 + 40) = 1065353216LL, *(_DWORD *)(v53 + 24) <= 2u)
		    || (*(_DWORD *)(v53 + 48) = 0, *(_DWORD *)(v53 + 52) = 1065353216, *(_DWORD *)(v53 + 24) <= 3u) )
		  {
		LABEL_20:
		    sub_1800D2AB0(v21, v20);
		  }
		  *(_DWORD *)(v53 + 56) = 1065353216;
		  *(_DWORD *)(v53 + 60) = 1065353216;
		  TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_atlasOffsets = (Vector2__Array *)v53;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_atlasOffsets,
		    (HGRuntimeGrassQuery_Node *)v53,
		    v54,
		    v55,
		    v99);
		  v56 = (Object *)TypeInfo::HG::Rendering::Runtime::HGShadowManager::__c->static_fields->__9;
		  v57 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::HGShadowManager::ShadowPassData>);
		  v58 = (RenderFunc_1_HG_Rendering_Runtime_HGShadowManager_ShadowPassData_ *)v57;
		  if ( !v57
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v57,
		          v56,
		          MethodInfo::HG::Rendering::Runtime::HGShadowManager::__c::__cctor_b__104_3,
		          0LL),
		        v59 = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields,
		        v59->s_csmShadowMapRenderFunc = v58,
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->s_csmShadowMapRenderFunc,
		          (HGRuntimeGrassQuery_Node *)v59,
		          v60,
		          v61,
		          v100),
		        v62 = (Object *)TypeInfo::HG::Rendering::Runtime::HGShadowManager::__c->static_fields->__9,
		        v63 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::HGShadowManager::ShadowPassData>),
		        (v64 = (RenderFunc_1_HG_Rendering_Runtime_HGShadowManager_ShadowPassData_ *)v63) == 0LL) )
		  {
		LABEL_4:
		    sub_1800D8260(v21, v20);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v63,
		    v62,
		    MethodInfo::HG::Rendering::Runtime::HGShadowManager::__c::__cctor_b__104_4,
		    0LL);
		  v65 = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		  v65->s_disableDirectionalShadowRenderFunc = v64;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->s_disableDirectionalShadowRenderFunc,
		    (HGRuntimeGrassQuery_Node *)v65,
		    v66,
		    v67,
		    v101);
		  v68 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList, 4LL);
		  v69 = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		  v69->s_unityRendererLists = (RendererList__Array *)v68;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->s_unityRendererLists,
		    (HGRuntimeGrassQuery_Node *)v69,
		    v70,
		    v71,
		    v102);
		  v72 = il2cpp_array_new_specific_1(TypeInfo::System::UInt32, 4LL);
		  v73 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		  v73[2].fields.parent = (HGRuntimeGrassQuery_Node *)v72;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->s_shadowRendererLists,
		    v73,
		    v74,
		    v75,
		    v103);
		  v76 = il2cpp_array_new_specific_1(TypeInfo::System::UInt32, 4LL);
		  v77 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		  v77[2].fields.left = (HGRuntimeGrassQuery_Node *)v76;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->s_shadowGrassLists,
		    v77,
		    v78,
		    v79,
		    v104);
		  v80 = il2cpp_array_new_specific_1(TypeInfo::System::UInt32, 4LL);
		  v81 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		  v81[2].fields.right = (HGRuntimeGrassQuery_Node *)v80;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->s_shadowTreeLists,
		    v82,
		    v81,
		    v83,
		    v105);
		  v84 = il2cpp_array_new_specific_1(TypeInfo::System::IntPtr, 4LL);
		  v85 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		  v85[2].fields.grassInstanceBounds = (Bounds__Array *)v84;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->s_shadowDrawingSettings,
		    v85,
		    v86,
		    v87,
		    v106);
		}
		
	
		// Methods
		internal void RenderCharacterShadows(HGRenderGraph renderGraph, HGCamera hgCamera, CullingResults cullingResults, LightCullResult lightCullResult, int directionalLightIndex, ref ShadowResult shadowResult) {} // 0x0000000189D22978-0x0000000189D23704
		// Void RenderCharacterShadows(HGRenderGraph, HGCamera, CullingResults, LightCullResult, Int32, ShadowResult ByRef)
		// Hidden C++ exception states: #wind=4 #try_helpers=1
		void HG::Rendering::Runtime::HGShadowManager::RenderCharacterShadows(
		        HGShadowManager *this,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        CullingResults *cullingResults,
		        LightCullResult *lightCullResult,
		        int32_t directionalLightIndex,
		        ShadowResult *shadowResult,
		        MethodInfo *method)
		{
		  HGCamera *v9; // r13
		  Object *v10; // rsi
		  HGShadowManager *v11; // r15
		  __int64 v12; // rdx
		  HGGraphicsFeatureManager__StaticFields *static_fields; // rcx
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  Object v16; // xmm6
		  int32_t m_CharacterShadowCount; // eax
		  char *v18; // rax
		  ProfilingSampler *v19; // rax
		  unsigned __int16 v20; // di
		  ProfilingSampler *v21; // rax
		  void *visibleLightsPtr; // rdx
		  char *v23; // rax
		  Object *v24; // rcx
		  Object *v25; // r12
		  __int64 v26; // rdx
		  HGShadowManager__StaticFields *v27; // rcx
		  __int64 m_CharacterShadowSampleMode; // rcx
		  HGShadowManager__StaticFields *v29; // rcx
		  __int64 v30; // rdx
		  HGShadowManager__StaticFields *v31; // rcx
		  HGShadowManager__StaticFields *v32; // rcx
		  Object *v33; // r12
		  int32_t v34; // r8d
		  __int64 m_CharacterShadowmapResolution; // rdx
		  struct HGShadowManager__Class *v36; // rcx
		  Object v37; // xmm0
		  Object__Class *klass; // r12
		  RendererListHandle InvalidHandle; // rax
		  RendererListHandle v40; // rdx
		  RendererListHandle v41; // rcx
		  RendererListHandle v42; // r8
		  RendererListDesc *v43; // rax
		  MonitorData *monitor; // r12
		  __int64 v45; // rdx
		  __int64 v46; // rcx
		  uint32_t RendererListWithCharacterIndex; // eax
		  __int64 v48; // rdx
		  __int64 v49; // rcx
		  __int64 v50; // r8
		  ProfilingSampler *v51; // rax
		  __int64 v52; // rdx
		  __int64 v53; // rcx
		  ProfilingSampler *v54; // rax
		  __int64 v55; // rdx
		  __int64 v56; // rcx
		  TextureHandle *v57; // rdi
		  HGRenderGraphDefaultResources *defaultResources; // rax
		  __int64 v59; // rdx
		  __int64 v60; // rcx
		  __int64 v61; // rdx
		  __int64 v62; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rdi
		  Object *v64; // [rsp+50h] [rbp-388h] BYREF
		  unsigned __int16 i; // [rsp+58h] [rbp-380h]
		  LightCullResult v66; // [rsp+60h] [rbp-378h] BYREF
		  CullingResults v67; // [rsp+70h] [rbp-368h] BYREF
		  RendererListHandle input; // [rsp+80h] [rbp-358h] BYREF
		  Object *v69; // [rsp+88h] [rbp-350h] BYREF
		  TextureHandle *v70; // [rsp+90h] [rbp-348h] BYREF
		  LightCullResult v71; // [rsp+A0h] [rbp-338h] BYREF
		  Object v72; // [rsp+B0h] [rbp-328h]
		  Object v73; // [rsp+C0h] [rbp-318h]
		  HGRenderGraphBuilder v74; // [rsp+D0h] [rbp-308h] BYREF
		  HGRenderGraphBuilder v75; // [rsp+F0h] [rbp-2E8h] BYREF
		  HGRenderGraphBuilder v76; // [rsp+110h] [rbp-2C8h] BYREF
		  HGRenderGraphBuilder v77; // [rsp+130h] [rbp-2A8h] BYREF
		  HGRenderGraphProfilingScope v78; // [rsp+150h] [rbp-288h] BYREF
		  HGRenderGraphBuilder v79; // [rsp+168h] [rbp-270h] BYREF
		  Il2CppExceptionWrapper *v80; // [rsp+188h] [rbp-250h] BYREF
		  Il2CppExceptionWrapper *v81; // [rsp+190h] [rbp-248h] BYREF
		  Il2CppExceptionWrapper *v82; // [rsp+1A0h] [rbp-238h] BYREF
		  Bounds bounds; // [rsp+1A8h] [rbp-230h] BYREF
		  RendererListDesc shadowLight; // [rsp+1C0h] [rbp-218h] BYREF
		  RendererListDesc desc; // [rsp+2A0h] [rbp-138h] BYREF
		
		  v9 = hgCamera;
		  v10 = (Object *)renderGraph;
		  v11 = this;
		  memset(&bounds, 0, sizeof(bounds));
		  memset(&v77, 0, sizeof(v77));
		  v70 = 0LL;
		  memset(&v78, 0, sizeof(v78));
		  memset(&v74, 0, sizeof(v74));
		  v64 = 0LL;
		  memset(&v76, 0, sizeof(v76));
		  v69 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2103, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2103, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v62, v61);
		    v71 = *lightCullResult;
		    v66 = (LightCullResult)*cullingResults;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_858(
		      Patch,
		      (Object *)v11,
		      v10,
		      (Object *)v9,
		      (CullingResults *)&v66,
		      &v71,
		      directionalLightIndex,
		      shadowResult,
		      0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->static_fields->instance )
		      goto LABEL_48;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		    if ( HG::Rendering::Runtime::HGCharacters::get_selfShadowCount(0LL) < 1
		      || directionalLightIndex == -1
		      || !v11->fields.enableCharacterShadowmap
		      || !v11->fields.m_hasDirectionLight )
		    {
		      goto LABEL_48;
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		    if ( !static_fields->characterShadow )
		      sub_1800D8260(static_fields, v12);
		    if ( HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(static_fields->characterShadow, 0LL)
		      && (UnityEngine::HyperGryph::HGGraphicsUtils::get_enableECSRenderer(0LL)
		       || UnityEngine::Rendering::CullingResults::GetShadowCasterBounds(
		            cullingResults->ptr,
		            directionalLightIndex,
		            &bounds,
		            0LL)) )
		    {
		      if ( !v10 )
		        sub_1800D8250(v15, v14);
		      v16 = (Object)*HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                       (TextureHandle *)&v71,
		                       (HGRenderGraph *)v10,
		                       &v11->fields.m_characterShadowmapsDesc,
		                       0LL);
		      v71 = (LightCullResult)v16;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		      m_CharacterShadowCount = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowCount;
		      v66 = *lightCullResult;
		      v67 = *cullingResults;
		      HG::Rendering::Runtime::HGShadowManager::SetupCharacterShadowCasterConstants(
		        v11,
		        &v67,
		        &v66,
		        v9,
		        directionalLightIndex,
		        m_CharacterShadowCount,
		        0LL);
		      v18 = (char *)lightCullResult->visibleLightsPtr + 148 * directionalLightIndex;
		      *(_OWORD *)&shadowLight.sortingCriteria = *(_OWORD *)v18;
		      shadowLight.stateBlock = *(Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *)(v18 + 16);
		      *(_OWORD *)&shadowLight.overrideMaterial = *((_OWORD *)v18 + 8);
		      shadowLight.overrideMaterialPassIndex = *((_DWORD *)v18 + 36);
		      HG::Rendering::Runtime::HGShadowManager::SetupCharacterShadowReceiverConstants(
		        v11,
		        (VisibleLight *)&shadowLight,
		        TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowCount,
		        0LL);
		      v19 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x7Bu,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::HGRenderGraphProfilingScope(
		        &v78,
		        (HGRenderGraph *)v10,
		        v19,
		        0LL);
		      v66.visibleLightsPtr = 0LL;
		      *(_QWORD *)&v66.visibleLightCount = &v78;
		      v20 = 0;
		      for ( i = 0; ; i = v20 )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		        if ( v20 >= TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowCount )
		          break;
		        v21 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		                (Int32Enum__Enum)0x7Cu,
		                MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		        HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		          &v75,
		          (HGRenderGraph *)v10,
		          (String *)"Render Character ShadowMaps",
		          &v64,
		          v21,
		          1,
		          ProfilingHGPass__Enum_Shadow,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGShadowManager::CharacterShadowPassData>);
		        v74 = v75;
		        v67.ptr = 0LL;
		        v67.m_AllocationInfo = (CullingAllocationInfo *)&v74;
		        try
		        {
		          visibleLightsPtr = lightCullResult->visibleLightsPtr;
		          v23 = (char *)lightCullResult->visibleLightsPtr + 148 * directionalLightIndex;
		          *(_OWORD *)&shadowLight.sortingCriteria = *(_OWORD *)v23;
		          shadowLight.stateBlock = *(Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *)(v23 + 16);
		          *(_OWORD *)&shadowLight.overrideMaterial = *((_OWORD *)v23 + 8);
		          shadowLight.overrideMaterialPassIndex = *((_DWORD *)v23 + 36);
		          v24 = v64;
		          if ( !v64 )
		            sub_1800D8250(0LL, visibleLightsPtr);
		          v64[1] = *(Object *)&shadowLight.sortingCriteria;
		          *(Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *)&v24[2].klass = shadowLight.stateBlock;
		          v24[9] = *(Object *)&shadowLight.overrideMaterial;
		          LODWORD(v24[10].klass) = shadowLight.overrideMaterialPassIndex;
		          if ( !v64 )
		            sub_1800D8250(v24, visibleLightsPtr);
		          v64[14] = v16;
		          v25 = v64;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		          v27 = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		          if ( !v25 )
		            sub_1800D8250(v27, v26);
		          HIDWORD(v25[10].klass) = v27->m_CharacterShadowCount;
		          m_CharacterShadowSampleMode = (unsigned int)v11->fields.m_CharacterShadowSampleMode;
		          if ( !v64 )
		            sub_1800D8250(m_CharacterShadowSampleMode, v26);
		          LODWORD(v64[11].klass) = m_CharacterShadowSampleMode;
		          if ( !v64 )
		            sub_1800D8250(0LL, v26);
		          LODWORD(v64[10].monitor) = v20;
		          v29 = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		          v30 = (unsigned int)v29->m_CharacterShadowCount;
		          if ( !v64 )
		            sub_1800D8250(v29, v30);
		          HIDWORD(v64[10].monitor) = v30;
		          v31 = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		          if ( !v64 )
		            sub_1800D8250(v31, v30);
		          HIDWORD(v64[12].klass) = LODWORD(v31->m_CharacterHardwareDepthBias);
		          v32 = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		          if ( !v64 )
		            sub_1800D8250(v32, v30);
		          *(float *)&v64[12].monitor = v32->m_CharacterHardwareNormalBias;
		          v33 = v64;
		          if ( TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowCount <= 4 )
		          {
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		            v36 = TypeInfo::HG::Rendering::Runtime::HGShadowManager;
		            m_CharacterShadowmapResolution = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowmapResolution;
		            v73.klass = (Object__Class *)COERCE_UNSIGNED_INT((float)(TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowmapResolution
		                                                                   * v20));
		            *(float *)&v73.monitor = (float)(int)m_CharacterShadowmapResolution;
		            *((float *)&v73.monitor + 1) = (float)(int)m_CharacterShadowmapResolution;
		            if ( !v33 )
		              sub_1800D8250(TypeInfo::HG::Rendering::Runtime::HGShadowManager, m_CharacterShadowmapResolution);
		            v37 = v73;
		          }
		          else
		          {
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		            v34 = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowmapResolution;
		            m_CharacterShadowmapResolution = (unsigned int)v34;
		            v36 = (struct HGShadowManager__Class *)(v34 * (v20 & 3u));
		            *(float *)&v72.klass = (float)(int)v36;
		            *((float *)&v72.klass + 1) = (float)(v34 * (v20 >> 2));
		            *(float *)&v72.monitor = (float)v34;
		            *((float *)&v72.monitor + 1) = (float)v34;
		            if ( !v33 )
		              sub_1800D8250(v36, (unsigned int)v34);
		            v37 = v72;
		          }
		          *(Object *)((char *)v33 + 180) = v37;
		          if ( !v64 )
		            sub_1800D8250(v36, m_CharacterShadowmapResolution);
		          klass = v64[13].klass;
		          if ( UnityEngine::HyperGryph::HGGraphicsUtils::get_enableECSRenderer(0LL) )
		          {
		            InvalidHandle = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
		          }
		          else
		          {
		            *(CullingResults *)&v75.m_RenderPass = *cullingResults;
		            v43 = HG::Rendering::Runtime::HGShadowManager::PrepareCharacterShadowRendererList(
		                    &shadowLight,
		                    v11,
		                    (CullingResults *)&v75,
		                    v9,
		                    v20 + 1,
		                    0LL);
		            *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v43->sortingCriteria;
		            desc.stateBlock = v43->stateBlock;
		            v43 = (RendererListDesc *)((char *)v43 + 128);
		            *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v43->sortingCriteria;
		            *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v43->stateBlock.hasValue;
		            *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v43->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		            *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v43->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		            *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v43->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		            *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v43->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		            input = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(
		                      (HGRenderGraph *)v10,
		                      &desc,
		                      0LL);
		            InvalidHandle = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(&v74, &input, 0LL);
		          }
		          if ( !klass )
		            ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v41, v40);
		          if ( (unsigned int)v20 >= LODWORD(klass->_0.namespaze) )
		            ((void (__fastcall __noreturn *)(_QWORD, _QWORD, _QWORD))sub_1800D2AA0)(v20, v40, v42);
		          *((RendererListHandle *)&klass->_0.byval_arg.data.dummy + v20) = InvalidHandle;
		          if ( !v64 )
		            ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v20, v40);
		          monitor = v64[13].monitor;
		          if ( !v9 )
		            ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v20, v40);
		          *(_DWORD *)&input.m_IsValid = v9->fields.cullingViewHandle;
		          v75.m_RenderPass = (HGRenderGraphPass *)HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(
		                                                    (HGRenderGraph *)v10,
		                                                    0LL);
		          if ( !v75.m_RenderPass )
		            sub_1800D8250(v46, v45);
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		          RendererListWithCharacterIndex = UnityEngine::HyperGryph::HGMeshRender::CreateRendererListWithCharacterIndex(
		                                             *(uint32_t *)&input.m_IsValid,
		                                             v20 + 1,
		                                             0x400u,
		                                             0,
		                                             0x400u,
		                                             0,
		                                             v75.m_RenderPass->fields._name_k__BackingField,
		                                             0LL);
		          if ( !monitor )
		            sub_1800D8250(v49, v48);
		          if ( (unsigned int)v20 >= *((_DWORD *)monitor + 6) )
		            sub_1800D2AA0(v20, v48, v50);
		          *((_DWORD *)monitor + v20 + 8) = RendererListWithCharacterIndex;
		          if ( !v64 )
		            sub_1800D8250(v20, v48);
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		            (TextureHandle *)&v79,
		            &v74,
		            (TextureHandle *)&v64[14],
		            DepthAccess__Enum_Write,
		            (RenderBufferLoadAction__Enum)(v20 == 0),
		            RenderBufferStoreAction__Enum_Store,
		            1.0,
		            0,
		            0,
		            0LL);
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v74, 0, 0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		            &v74,
		            (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->s_renderCharacterShadowmapRenderFunc,
		            0LL,
		            0,
		            MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGShadowManager::CharacterShadowPassData>);
		        }
		        catch ( Il2CppExceptionWrapper *v80 )
		        {
		          v67.ptr = v80->ex;
		          sub_180268AE0(&v67);
		          v9 = hgCamera;
		          v10 = (Object *)renderGraph;
		          v11 = this;
		          v16 = (Object)v71;
		          v20 = i;
		          goto LABEL_42;
		        }
		        sub_180268AE0(&v67);
		LABEL_42:
		        ++v20;
		      }
		      v51 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x7Cu,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v79,
		        (HGRenderGraph *)v10,
		        (String *)"Render Character ShadowMaps SetData",
		        &v69,
		        v51,
		        1,
		        ProfilingHGPass__Enum_Shadow,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGShadowManager::CharacterShadowPassData>);
		      v76 = v79;
		      v67.ptr = 0LL;
		      v67.m_AllocationInfo = (CullingAllocationInfo *)&v76;
		      try
		      {
		        if ( !v69 )
		          sub_1800D8250(v53, v52);
		        v69[14] = v16;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v76,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->s_renderCharacterShadowmapSetDataFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGShadowManager::CharacterShadowPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v81 )
		      {
		        v67.ptr = v81->ex;
		        sub_180268AE0(&v67);
		        sub_180269330(&v66);
		        v16 = (Object)v71;
		        goto LABEL_47;
		      }
		      sub_180268AE0(&v67);
		      sub_180269330(&v66);
		LABEL_47:
		      shadowResult->characterShadowActive = 1;
		      shadowResult->characterShadowResult = (TextureHandle)v16;
		    }
		    else
		    {
		LABEL_48:
		      v54 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x7Bu,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !v10 )
		        sub_1800D8260(v56, v55);
		      v77 = *(HGRenderGraphBuilder *)sub_1808B5A20(
		                                       (unsigned int)&v79,
		                                       (_DWORD)v10,
		                                       (unsigned int)"Render Character ShadowMaps",
		                                       (unsigned int)&v70,
		                                       (__int64)v54);
		      v66.visibleLightsPtr = 0LL;
		      *(_QWORD *)&v66.visibleLightCount = &v77;
		      try
		      {
		        v57 = v70;
		        defaultResources = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(
		                             (HGRenderGraph *)v10,
		                             0LL);
		        if ( !defaultResources )
		          sub_1800D8250(v60, v59);
		        if ( !v57 )
		          sub_1800D8250(v60, v59);
		        v57[14] = defaultResources->fields._defaultShadowTexture_k__BackingField;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v77,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->s_disableCharacterShadowRenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGShadowManager::CharacterShadowPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v82 )
		      {
		        v66.visibleLightsPtr = v82->ex;
		        sub_180268AE0(&v66);
		        return;
		      }
		      sub_180268AE0(&v66);
		    }
		  }
		}
		
		public void CharacterShadowFrameSetup(HGSettingParameters settingParams) {} // 0x0000000189D1F24C-0x0000000189D1F5CC
		// Void CharacterShadowFrameSetup(HGSettingParameters)
		void HG::Rendering::Runtime::HGShadowManager::CharacterShadowFrameSetup(
		        HGShadowManager *this,
		        HGSettingParameters *settingParams,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Int32Enum__Enum v7; // r15d
		  Int32Enum__Enum v8; // r14d
		  int32_t v9; // esi
		  Vector2Int s_One; // rbx
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  int32_t m_CharacterShadowmapResolution; // r15d
		  int selfShadowCount; // edx
		  HGShadowManager__StaticFields *static_fields; // rcx
		  HGRuntimeGrassQuery_Node *v17; // rdx
		  HGRuntimeGrassQuery_Node *v18; // r8
		  Int32__Array **v19; // r9
		  __int128 v20; // xmm1
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  __int128 v23; // xmm0
		  Color clearColor; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureDesc v26; // [rsp+20h] [rbp-60h] BYREF
		  Vector2Int v27; // [rsp+C8h] [rbp+48h]
		
		  sub_18033B9D0(&v26, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(2120, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2120, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)settingParams,
		        0LL);
		      return;
		    }
		LABEL_15:
		    sub_1800D8260(v6, v5);
		  }
		  if ( !settingParams )
		    goto LABEL_15;
		  v7 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		         (SettingParameter_1_System_Int32Enum_ *)settingParams->fields._characterShadowMapResolution_k__BackingField,
		         MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  v8 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		         (SettingParameter_1_System_Int32Enum_ *)settingParams->fields._shadowDepthBits_k__BackingField,
		         MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Rendering::DepthBits>::op_Implicit);
		  v9 = 90;
		  if ( v8 != 16 )
		    v9 = 93;
		  if ( this->fields.m_hasDirectionLight )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		    TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowmapResolution = v7;
		    this->fields.m_CharacterShadowSampleMode = 2;
		    TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterDepthBias = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                                                                               settingParams->fields._characterShadowShaderBias_k__BackingField,
		                                                                                               MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		    TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterNormalBias = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                                                                                settingParams->fields._characterShadowShaderNormalBias_k__BackingField,
		                                                                                                MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		    TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterHardwareDepthBias = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(settingParams->fields._characterShadowHardwareBias_k__BackingField, MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		    TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterHardwareNormalBias = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(settingParams->fields._characterShadowHardwareNormalBias_k__BackingField, MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		    m_CharacterShadowmapResolution = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowmapResolution;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		    selfShadowCount = HG::Rendering::Runtime::HGCharacters::get_selfShadowCount(0LL);
		    if ( selfShadowCount >= 14 )
		      selfShadowCount = 14;
		    TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowCount = selfShadowCount;
		    if ( TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowCount <= 4 )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		      v27.m_Y = 1;
		      v27.m_X = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowCount;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		      v27.m_X = 4;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		      v27.m_Y = (static_fields->m_CharacterShadowCount - 1) / 4 + 1;
		    }
		    static_fields->m_AtlasTileCount = v27;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		    TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowmapSize = (Vector2Int)__PAIR64__(TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_AtlasTileCount.m_Y * m_CharacterShadowmapResolution, TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_AtlasTileCount.m_X * m_CharacterShadowmapResolution);
		    HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		      &v26,
		      TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowmapSize.m_X,
		      TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowmapSize.m_Y,
		      0LL);
		    v26.name = (String *)"CharacterShadowMap";
		    v26.depthBufferBits = v8;
		    v26.colorFormat = v9;
		    v26.filterMode = 1;
		    v26.wrapMode = 1;
		    v26.isShadowMap = 1;
		    v26.dimension = 2;
		    v26.clearBuffer = 1;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v26.name, v17, v18, v19, *(MethodInfo **)&v26.width);
		  }
		  else
		  {
		    s_One = TypeInfo::UnityEngine::Vector2Int->static_fields->s_One;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		    TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_AtlasTileCount = s_One;
		    HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v26, 1, 1, 0LL);
		    v26.depthBufferBits = v8;
		    v26.colorFormat = v9;
		    v26.filterMode = 1;
		    v26.wrapMode = 1;
		    v26.dimension = 2;
		    v26.isShadowMap = 1;
		    v26.clearBuffer = 1;
		  }
		  v20 = *(_OWORD *)&v26.colorFormat;
		  *(_OWORD *)&this->fields.m_characterShadowmapsDesc.width = *(_OWORD *)&v26.width;
		  v21 = *(_OWORD *)&v26.enableRandomWrite;
		  *(_OWORD *)&this->fields.m_characterShadowmapsDesc.colorFormat = v20;
		  v22 = *(_OWORD *)&v26.bindTextureMS;
		  *(_OWORD *)&this->fields.m_characterShadowmapsDesc.enableRandomWrite = v21;
		  v23 = *(_OWORD *)&v26.fastMemoryDesc.inFastMemory;
		  *(_OWORD *)&this->fields.m_characterShadowmapsDesc.bindTextureMS = v22;
		  clearColor = v26.clearColor;
		  *(_OWORD *)&this->fields.m_characterShadowmapsDesc.fastMemoryDesc.inFastMemory = v23;
		  this->fields.m_characterShadowmapsDesc.clearColor = clearColor;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields.m_characterShadowmapsDesc.name,
		    v11,
		    v12,
		    v13,
		    *(MethodInfo **)&v26.width);
		}
		
		private void SetupCharacterShadowCasterConstants(CullingResults cullingResults, LightCullResult lightCullResult, HGCamera hgCamera, int directionalLightIndex, int characterCount) {} // 0x0000000189D245B8-0x0000000189D24B84
		// Void SetupCharacterShadowCasterConstants(CullingResults, LightCullResult, HGCamera, Int32, Int32)
		void HG::Rendering::Runtime::HGShadowManager::SetupCharacterShadowCasterConstants(
		        HGShadowManager *this,
		        CullingResults *cullingResults,
		        LightCullResult *lightCullResult,
		        HGCamera *hgCamera,
		        int32_t directionalLightIndex,
		        int32_t characterCount,
		        MethodInfo *method)
		{
		  __int64 v11; // rdx
		  void *Patch; // rcx
		  int v13; // esi
		  HGEnvironmentVolumeCameraComponent *envVolumeCameraComponent; // rbx
		  Light *light; // rax
		  HGEnvironmentVolumeCameraComponent *v16; // rax
		  HGEnvironmentPhase *interpolatedPhase; // rax
		  __int128 v18; // xmm6
		  __int128 v19; // xmm7
		  __int128 v20; // xmm9
		  __int128 v21; // xmm10
		  Matrix4x4 *localToWorldMatrix; // rax
		  List_1_System_Object_ *selfShadowCharacterHelpers; // rax
		  Object *Item; // r12
		  __int64 v25; // rdi
		  Matrix4x4 *v26; // rbx
		  Matrix4x4 *v27; // rax
		  Vector4__Array *m_CharacterShadowBiases; // r12
		  unsigned int m_CharacterShadowSampleMode; // ebx
		  HGShadowManager__StaticFields *static_fields; // rax
		  int m_CharacterShadowmapResolution; // edi
		  float m_CharacterDepthBias; // xmm7_4
		  float m_CharacterNormalBias; // xmm6_4
		  Vector4 *ShadowBias; // rax
		  Vector4__Array *v35; // rdi
		  List_1_System_Object_ *v36; // rax
		  Object *v37; // rax
		  int16_t id; // ax
		  uint32_t ShadowLayer; // ebx
		  MethodInfo *v40; // r8
		  Vector4 *v41; // rax
		  __int64 v42; // r9
		  Vector4__Array *m_CharacterShadowAtlasParams; // r9
		  __m128i v44; // xmm0
		  float v45; // xmm2_4
		  __m128i v46; // xmm0
		  float v47; // xmm1_4
		  __m128i v48; // xmm0
		  CullingResults v49; // xmm0
		  HGShadowManager__StaticFields *v50; // rax
		  __m128i v51; // xmm0
		  float v52; // xmm1_4
		  __m128i v53; // xmm0
		  CullingResults v54; // xmm1
		  _QWORD v55[3]; // [rsp+40h] [rbp-C8h] BYREF
		  Vector3 v56; // [rsp+58h] [rbp-B0h] BYREF
		  CullingResults v57; // [rsp+68h] [rbp-A0h] BYREF
		  CullingResults v58; // [rsp+78h] [rbp-90h]
		  Vector3 v59; // [rsp+88h] [rbp-80h] BYREF
		  Matrix4x4 v60; // [rsp+98h] [rbp-70h] BYREF
		  Matrix4x4 v61; // [rsp+D8h] [rbp-30h] BYREF
		  Vector3 v62; // [rsp+118h] [rbp+10h] BYREF
		  Vector4 v63; // [rsp+128h] [rbp+20h] BYREF
		  Vector4 v64; // [rsp+138h] [rbp+30h] BYREF
		  VisibleLight v65; // [rsp+148h] [rbp+40h] BYREF
		
		  sub_18033B9D0(&v65, 0LL, 148LL);
		  *(_QWORD *)&v56.x = 0LL;
		  v56.z = 0.0;
		  if ( IFix::WrappersManagerImpl::IsPatched(2107, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2107, 0LL);
		    if ( !Patch )
		      goto LABEL_27;
		    v54 = *cullingResults;
		    *(LightCullResult *)&v55[1] = *lightCullResult;
		    v57 = v54;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_853(
		      (ILFixDynamicMethodWrapper_2 *)Patch,
		      (Object *)this,
		      &v57,
		      (LightCullResult *)&v55[1],
		      (Object *)hgCamera,
		      directionalLightIndex,
		      characterCount,
		      0LL);
		  }
		  else
		  {
		    Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::ConvertExistingDataToNativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>(
		      (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v57,
		      (Void *)lightCullResult->visibleLightsPtr,
		      lightCullResult->visibleLightCount,
		      Allocator__Enum_None,
		      MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::ConvertExistingDataToNativeArray<UnityEngine::Rendering::VisibleLight>);
		    v11 = 128LL;
		    Patch = &v65;
		    v65 = *(VisibleLight *)((_BYTE *)v57.ptr + directionalLightIndex);
		    if ( characterCount > 0 )
		    {
		      v13 = 0;
		      if ( hgCamera )
		      {
		        while ( 1 )
		        {
		          envVolumeCameraComponent = HG::Rendering::Runtime::HGCamera::get_envVolumeCameraComponent(hgCamera, 0LL);
		          light = UnityEngine::Rendering::VisibleLight::get_light(&v65, 0LL);
		          if ( !envVolumeCameraComponent )
		            break;
		          if ( HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::UseDirLightDataFromEnvDirectly(
		                 envVolumeCameraComponent,
		                 light,
		                 0LL) )
		          {
		            v16 = HG::Rendering::Runtime::HGCamera::get_envVolumeCameraComponent(hgCamera, 0LL);
		            if ( !v16 )
		              break;
		            interpolatedPhase = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedPhase(
		                                  v16,
		                                  0LL);
		            if ( !interpolatedPhase )
		              break;
		            v18 = *(_OWORD *)&interpolatedPhase->fields.lightConfig.localToWorld.m00;
		            v19 = *(_OWORD *)&interpolatedPhase->fields.lightConfig.localToWorld.m01;
		            v20 = *(_OWORD *)&interpolatedPhase->fields.lightConfig.localToWorld.m02;
		            v21 = *(_OWORD *)&interpolatedPhase->fields.lightConfig.localToWorld.m03;
		          }
		          else
		          {
		            localToWorldMatrix = UnityEngine::HGSharedLightData::get_localToWorldMatrix(
		                                   &v61,
		                                   &v65.hgSharedLightData,
		                                   0LL);
		            v18 = *(_OWORD *)&localToWorldMatrix->m00;
		            v19 = *(_OWORD *)&localToWorldMatrix->m01;
		            v20 = *(_OWORD *)&localToWorldMatrix->m02;
		            v21 = *(_OWORD *)&localToWorldMatrix->m03;
		          }
		          v56 = *UnityEngine::Vector3::get_fwd(&v62, (MethodInfo *)v11);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		          selfShadowCharacterHelpers = (List_1_System_Object_ *)HG::Rendering::Runtime::HGCharacters::get_selfShadowCharacterHelpers(0LL);
		          if ( !selfShadowCharacterHelpers )
		            break;
		          Item = System::Collections::Generic::List<System::Object>::get_Item(
		                   selfShadowCharacterHelpers,
		                   v13,
		                   MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::get_Item);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		          v11 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShadowManager;
		          Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		          v25 = *((_QWORD *)Patch + 1);
		          if ( !v25 )
		            break;
		          Patch = (void *)*((_QWORD *)Patch + 2);
		          if ( !Patch )
		            break;
		          v26 = (Matrix4x4 *)sub_18049E964(Patch, v13);
		          v27 = (Matrix4x4 *)sub_18049E964(v25, v13);
		          *(_OWORD *)&v60.m00 = v18;
		          *(_OWORD *)&v60.m01 = v19;
		          *(_OWORD *)&v60.m02 = v20;
		          *(_OWORD *)&v60.m03 = v21;
		          HG::Rendering::Runtime::HGShadowManager::GetMatrices(
		            &v60,
		            hgCamera,
		            (HGCharacterHelper *)Item,
		            v27,
		            v26,
		            &v56,
		            0LL);
		          m_CharacterShadowBiases = this->fields.m_CharacterShadowBiases;
		          Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterProjectionMatrices;
		          if ( !Patch )
		            break;
		          sub_180031960(Patch, &v61, v13);
		          m_CharacterShadowSampleMode = this->fields.m_CharacterShadowSampleMode;
		          static_fields = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		          m_CharacterShadowmapResolution = static_fields->m_CharacterShadowmapResolution;
		          m_CharacterDepthBias = static_fields->m_CharacterDepthBias;
		          m_CharacterNormalBias = static_fields->m_CharacterNormalBias;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
		          v60 = v61;
		          ShadowBias = HG::Rendering::Runtime::HGShadowUtils::GetShadowBias(
		                         &v63,
		                         &v60,
		                         (float)m_CharacterShadowmapResolution,
		                         m_CharacterDepthBias,
		                         m_CharacterNormalBias,
		                         (HGShadowSampleMode__Enum)m_CharacterShadowSampleMode,
		                         0LL);
		          if ( !m_CharacterShadowBiases )
		            break;
		          *(Vector4 *)&v55[1] = *ShadowBias;
		          sub_18003FEF0(m_CharacterShadowBiases, v13, &v55[1]);
		          v35 = this->fields.m_CharacterShadowBiases;
		          if ( !v35 )
		            break;
		          v36 = (List_1_System_Object_ *)HG::Rendering::Runtime::HGCharacters::get_selfShadowCharacterHelpers(0LL);
		          if ( !v36 )
		            break;
		          v37 = System::Collections::Generic::List<System::Object>::get_Item(
		                  v36,
		                  v13,
		                  MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::get_Item);
		          if ( !v37 )
		            break;
		          id = HG::Rendering::Runtime::HGCharacterHelper::get_id((HGCharacterHelper *)v37, 0LL);
		          ShadowLayer = HG::Rendering::Runtime::HGCharacters::GetShadowLayer(id, 0LL);
		          *(_DWORD *)(sub_180002100(v35, v13) + 12) = ShadowLayer;
		          v59 = v56;
		          v41 = UnityEngine::Vector4::op_Implicit(&v64, &v59, v40);
		          if ( !v42 )
		            break;
		          *(Vector4 *)&v55[1] = *v41;
		          sub_18003FEF0(v42, v13, &v55[1]);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		          if ( characterCount <= 4 )
		          {
		            v11 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShadowManager;
		            v50 = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		            Patch = v50->m_CharacterShadowAtlasParams;
		            v51 = _mm_cvtsi32_si128(v50->m_AtlasTileCount.m_X);
		            v57.ptr = (void *)COERCE_UNSIGNED_INT((float)v13 / (float)characterCount);
		            v52 = 1.0 / _mm_cvtepi32_ps(v51).m128_f32[0];
		            v53 = _mm_cvtsi32_si128(v50->m_AtlasTileCount.m_Y);
		            *(float *)&v57.m_AllocationInfo = v52;
		            *((float *)&v57.m_AllocationInfo + 1) = 1.0 / _mm_cvtepi32_ps(v53).m128_f32[0];
		            if ( !Patch )
		              break;
		            v49 = v57;
		          }
		          else
		          {
		            m_CharacterShadowAtlasParams = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowAtlasParams;
		            Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		            v11 = (unsigned int)(v13 >> 31);
		            LODWORD(v11) = v13 % 4;
		            v44 = _mm_cvtsi32_si128(*((_DWORD *)Patch + 18));
		            *(float *)&v58.ptr = (float)(v13 % 4) / (float)*((int *)Patch + 17);
		            v45 = (float)(v13 / 4) / _mm_cvtepi32_ps(v44).m128_f32[0];
		            v46 = _mm_cvtsi32_si128(*((_DWORD *)Patch + 17));
		            *((float *)&v58.ptr + 1) = v45;
		            v47 = 1.0 / _mm_cvtepi32_ps(v46).m128_f32[0];
		            v48 = _mm_cvtsi32_si128(*((_DWORD *)Patch + 18));
		            *(float *)&v58.m_AllocationInfo = v47;
		            *((float *)&v58.m_AllocationInfo + 1) = 1.0 / _mm_cvtepi32_ps(v48).m128_f32[0];
		            if ( !m_CharacterShadowAtlasParams )
		              break;
		            v49 = v58;
		            Patch = m_CharacterShadowAtlasParams;
		          }
		          *(CullingResults *)&v55[1] = v49;
		          sub_18003FEF0(Patch, v13++, &v55[1]);
		          if ( v13 >= characterCount )
		            return;
		        }
		      }
		LABEL_27:
		      sub_1800D8260(Patch, v11);
		    }
		  }
		}
		
		private static RendererListDesc CreateCharacterShadowCasterRendererListDesc(CullingResults cull, Camera camera, ShaderTagId passName, ushort characterIndex = 0 /* Metadata: 0x0230317F */) => default; // 0x0000000189D1F9C0-0x0000000189D1FB50
		// RendererListDesc CreateCharacterShadowCasterRendererListDesc(CullingResults, Camera, ShaderTagId, UInt16)
		RendererListDesc *HG::Rendering::Runtime::HGShadowManager::CreateCharacterShadowCasterRendererListDesc(
		        RendererListDesc *__return_ptr retstr,
		        CullingResults *cull,
		        Camera *camera,
		        ShaderTagId passName,
		        uint16_t characterIndex,
		        MethodInfo *method)
		{
		  RendererListDesc *v10; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v12; // rcx
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  __int128 v15; // xmm1
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  __int128 v18; // xmm0
		  __int128 v19; // xmm0
		  Material **p_overrideMaterial; // rax
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  __int128 v23; // xmm0
		  __int128 v24; // xmm1
		  __int128 v25; // xmm0
		  RendererListDesc *result; // rax
		  CullingResults v27; // [rsp+40h] [rbp-1D8h] BYREF
		  RendererListDesc v28; // [rsp+50h] [rbp-1C8h] BYREF
		  RendererListDesc v29; // [rsp+130h] [rbp-E8h] BYREF
		
		  sub_18033B9D0(&v28, 0LL, 224LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(2119, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2119, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v12, 0LL);
		    v27 = *cull;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_856(
		            &v29,
		            Patch,
		            &v27,
		            (Object *)camera,
		            passName,
		            characterIndex,
		            0LL);
		  }
		  else
		  {
		    v27 = *cull;
		    UnityEngine::Rendering::RendererUtils::RendererListDesc::RendererListDesc(&v28, passName, &v27, camera, 0LL);
		    v28.characterIndex = characterIndex;
		    v28.sortingCriteria = 59;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
		    v28.renderQueueRange = TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_All;
		    v10 = &v28;
		  }
		  v13 = *(_OWORD *)&v10->stateBlock.hasValue;
		  *(_OWORD *)&retstr->sortingCriteria = *(_OWORD *)&v10->sortingCriteria;
		  v14 = *(_OWORD *)&v10->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.hasValue = v13;
		  v15 = *(_OWORD *)&v10->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v14;
		  v16 = *(_OWORD *)&v10->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v15;
		  v17 = *(_OWORD *)&v10->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v16;
		  v18 = *(_OWORD *)&v10->stateBlock.value.m_RasterState.m_OffsetFactor;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v17;
		  *(_OWORD *)&retstr->stateBlock.value.m_RasterState.m_OffsetFactor = v18;
		  v19 = *(_OWORD *)&v10->stateBlock.value.m_StencilState.m_FailOperationFront;
		  p_overrideMaterial = &v10->overrideMaterial;
		  *(_OWORD *)&retstr->stateBlock.value.m_StencilState.m_FailOperationFront = v19;
		  v21 = *((_OWORD *)p_overrideMaterial + 1);
		  *(_OWORD *)&retstr->overrideMaterial = *(_OWORD *)p_overrideMaterial;
		  v22 = *((_OWORD *)p_overrideMaterial + 2);
		  *(_OWORD *)&retstr->overrideMaterialPassIndex = v21;
		  v23 = *((_OWORD *)p_overrideMaterial + 3);
		  *(_OWORD *)&retstr->sortingLayerMin = v22;
		  v24 = *((_OWORD *)p_overrideMaterial + 4);
		  *(_OWORD *)&retstr->drawableFeedbackPtr = v23;
		  v25 = *((_OWORD *)p_overrideMaterial + 5);
		  result = retstr;
		  *(_OWORD *)&retstr->_cullingResult_k__BackingField.m_AllocationInfo = v24;
		  *(_OWORD *)&retstr->_passName_k__BackingField.m_Id = v25;
		  return result;
		}
		
		private RendererListDesc PrepareCharacterShadowRendererList(CullingResults cullResults, HGCamera hgCamera, ushort characterIndex) => default; // 0x0000000189D22618-0x0000000189D227B0
		// RendererListDesc PrepareCharacterShadowRendererList(CullingResults, HGCamera, UInt16)
		RendererListDesc *HG::Rendering::Runtime::HGShadowManager::PrepareCharacterShadowRendererList(
		        RendererListDesc *__return_ptr retstr,
		        HGShadowManager *this,
		        CullingResults *cullResults,
		        HGCamera *hgCamera,
		        uint16_t characterIndex,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v11; // rcx
		  Camera *camera; // rbx
		  RendererListDesc *v13; // rax
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  __int128 v19; // xmm0
		  __int128 v20; // xmm0
		  Material **p_overrideMaterial; // rax
		  __int128 v22; // xmm0
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  __int128 v26; // xmm0
		  RendererListDesc *result; // rax
		  CullingResults v28; // [rsp+40h] [rbp-F8h] BYREF
		  RendererListDesc v29; // [rsp+50h] [rbp-E8h] BYREF
		  ShaderTagId v30; // [rsp+140h] [rbp+8h] BYREF
		
		  v30.m_Id = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(2118, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2118, 0LL);
		    if ( Patch )
		    {
		      v28 = *cullResults;
		      v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_857(
		              &v29,
		              Patch,
		              (Object *)this,
		              &v28,
		              (Object *)hgCamera,
		              characterIndex,
		              0LL);
		      goto LABEL_7;
		    }
		LABEL_5:
		    sub_1800D8260(v11, Patch);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
		  UnityEngine::Rendering::ShaderTagId::ShaderTagId(
		    &v30,
		    TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ShadowCasterStr,
		    0LL);
		  if ( !hgCamera )
		    goto LABEL_5;
		  camera = hgCamera->fields.camera;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		  v28 = *cullResults;
		  v13 = HG::Rendering::Runtime::HGShadowManager::CreateCharacterShadowCasterRendererListDesc(
		          &v29,
		          &v28,
		          camera,
		          v30,
		          characterIndex,
		          0LL);
		LABEL_7:
		  v14 = *(_OWORD *)&v13->stateBlock.hasValue;
		  *(_OWORD *)&retstr->sortingCriteria = *(_OWORD *)&v13->sortingCriteria;
		  v15 = *(_OWORD *)&v13->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.hasValue = v14;
		  v16 = *(_OWORD *)&v13->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v15;
		  v17 = *(_OWORD *)&v13->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v16;
		  v18 = *(_OWORD *)&v13->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v17;
		  v19 = *(_OWORD *)&v13->stateBlock.value.m_RasterState.m_OffsetFactor;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v18;
		  *(_OWORD *)&retstr->stateBlock.value.m_RasterState.m_OffsetFactor = v19;
		  v20 = *(_OWORD *)&v13->stateBlock.value.m_StencilState.m_FailOperationFront;
		  p_overrideMaterial = &v13->overrideMaterial;
		  *(_OWORD *)&retstr->stateBlock.value.m_StencilState.m_FailOperationFront = v20;
		  v22 = *((_OWORD *)p_overrideMaterial + 1);
		  *(_OWORD *)&retstr->overrideMaterial = *(_OWORD *)p_overrideMaterial;
		  v23 = *((_OWORD *)p_overrideMaterial + 2);
		  *(_OWORD *)&retstr->overrideMaterialPassIndex = v22;
		  v24 = *((_OWORD *)p_overrideMaterial + 3);
		  *(_OWORD *)&retstr->sortingLayerMin = v23;
		  v25 = *((_OWORD *)p_overrideMaterial + 4);
		  *(_OWORD *)&retstr->drawableFeedbackPtr = v24;
		  v26 = *((_OWORD *)p_overrideMaterial + 5);
		  result = retstr;
		  *(_OWORD *)&retstr->_cullingResult_k__BackingField.m_AllocationInfo = v25;
		  *(_OWORD *)&retstr->_passName_k__BackingField.m_Id = v26;
		  return result;
		}
		
		private static void GetMatrices(Matrix4x4 lightTransform, HGCamera hgCamera, HGCharacterHelper characterHelper, out Matrix4x4 worldToLightMatrices, out Matrix4x4 projectionMatrix, out Vector3 lightDirection) {
			worldToLightMatrices = default;
			projectionMatrix = default;
			lightDirection = default;
		} // 0x0000000189D20B74-0x0000000189D22354
		// Void GetMatrices(Matrix4x4, HGCamera, HGCharacterHelper, Matrix4x4 ByRef, Matrix4x4 ByRef, Vector3 ByRef)
		void HG::Rendering::Runtime::HGShadowManager::GetMatrices(
		        Matrix4x4 *lightTransform,
		        HGCamera *hgCamera,
		        HGCharacterHelper *characterHelper,
		        Matrix4x4 *worldToLightMatrices,
		        Matrix4x4 *projectionMatrix,
		        Vector3 *lightDirection,
		        MethodInfo *method)
		{
		  void *klass; // rdx
		  void *Patch; // rcx
		  Camera *camera; // rdi
		  Bounds *Bounds; // rax
		  __int64 v15; // xmm0_8
		  float3 *xyz; // rbx
		  float z; // eax
		  float3 *v18; // rax
		  __int64 v19; // xmm8_8
		  __int64 v20; // xmm6_8
		  float x; // r12d
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  __int64 v24; // xmm0_8
		  float3 *v25; // rax
		  __int64 v26; // xmm7_8
		  __m128i v27; // xmm15
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  Object_1 *m_hgCharacterVolume; // rbx
		  HGCharacterVolume_CharacterShadowMode__Enum CharacterSelfShadowMode; // eax
		  float3__StaticFields *static_fields; // rdx
		  __int64 v32; // xmm0_8
		  float v33; // esi
		  float3 *v34; // rax
		  __int64 v35; // xmm0_8
		  __int64 v36; // r8
		  __int64 v37; // r9
		  float v38; // r14d
		  __int64 v39; // rax
		  float v40; // xmm7_4
		  float y; // xmm6_4
		  __int64 v42; // xmm0_8
		  MethodInfo *v43; // r8
		  __int64 v44; // rdx
		  __int64 v45; // rcx
		  MethodInfo *v46; // r9
		  float3 *v47; // rax
		  __int64 v48; // xmm3_8
		  MethodInfo *v49; // r9
		  float3 *v50; // rbx
		  float v51; // r14d
		  float4x4 *v52; // rbx
		  float v53; // esi
		  float4 c0; // xmm1
		  float4 c1; // xmm0
		  float4 c2; // xmm1
		  float4 c3; // xmm0
		  const __m128i *v58; // rax
		  float4 v59; // xmm1
		  __m128i v60; // xmm12
		  float4 v61; // xmm0
		  float4 v62; // xmm1
		  float4 v63; // xmm0
		  float4 v64; // xmm1
		  float4 v65; // xmm0
		  float4 v66; // xmm1
		  float4 v67; // xmm0
		  const __m128i *v68; // rax
		  float4 v69; // xmm1
		  __m128i v70; // xmm11
		  float4 v71; // xmm0
		  float4 v72; // xmm1
		  float4 v73; // xmm0
		  __m128i v74; // xmm10
		  float4 v75; // xmm0
		  float4 v76; // xmm1
		  float4 v77; // xmm0
		  __m128i v78; // xmm9
		  float4 v79; // xmm0
		  float4 v80; // xmm1
		  float4 v81; // xmm0
		  __m128i v82; // xmm8
		  float4 v83; // xmm0
		  float4 v84; // xmm1
		  float4 v85; // xmm0
		  __m128i v86; // xmm7
		  float4 v87; // xmm0
		  float4 v88; // xmm1
		  float4 v89; // xmm0
		  __m128i v90; // xmm6
		  Quaternion v91; // xmm5
		  MethodInfo *v92; // r9
		  __m128i v93; // xmm4
		  MethodInfo *v94; // r9
		  __m128i v95; // xmm4
		  MethodInfo *v96; // r9
		  __m128i v97; // xmm4
		  MethodInfo *v98; // r9
		  __m128i v99; // xmm4
		  MethodInfo *v100; // r9
		  __m128i v101; // xmm4
		  MethodInfo *v102; // r9
		  float4 *v103; // rax
		  MethodInfo *v104; // r9
		  __m128i v105; // xmm4
		  Quaternion v106; // xmm5
		  MethodInfo *v107; // r9
		  __m128i v108; // xmm5
		  MethodInfo *v109; // r9
		  __m128i v110; // xmm5
		  MethodInfo *v111; // r9
		  __m128i v112; // xmm5
		  MethodInfo *v113; // r9
		  __m128i v114; // xmm5
		  MethodInfo *v115; // r9
		  __m128i v116; // xmm5
		  MethodInfo *v117; // r9
		  __m128i v118; // xmm5
		  MethodInfo *v119; // r9
		  float4 *v120; // rax
		  __int64 v121; // r10
		  float v122; // xmm0_4
		  float v123; // xmm12_4
		  float v124; // r12d
		  MethodInfo *v125; // r9
		  float3 *v126; // rax
		  __int64 v127; // xmm6_8
		  float v128; // ebx
		  Transform *v129; // rax
		  Vector3 *v130; // rax
		  __int64 v131; // xmm0_8
		  float3 *v132; // rax
		  __int64 v133; // xmm0_8
		  float3 *v134; // rax
		  __int64 v135; // xmm0_8
		  __int64 v136; // rax
		  __int64 v137; // xmm0_8
		  float3 *v138; // rax
		  float v139; // xmm0_4
		  float v140; // xmm6_4
		  __int64 v141; // rax
		  __int64 v142; // xmm0_8
		  float3 *v143; // rax
		  __int64 v144; // xmm0_8
		  float v145; // xmm0_4
		  Transform *v146; // rax
		  Vector3 *v147; // rax
		  __int64 v148; // xmm0_8
		  __int64 v149; // rax
		  __int64 v150; // xmm0_8
		  float3 *v151; // rax
		  __int64 v152; // xmm0_8
		  float v153; // xmm6_4
		  float v154; // xmm0_4
		  float v155; // xmm6_4
		  __int64 v156; // rax
		  Transform *v157; // rax
		  Vector3 *forward; // rax
		  __int64 v159; // xmm0_8
		  __int64 v160; // rax
		  __int64 v161; // rax
		  float3 *v162; // rax
		  __int64 v163; // xmm0_8
		  __int64 v164; // r8
		  __int64 v165; // r9
		  Vector4 *AsVector4; // rax
		  Matrix4x4 *worldToCameraMatrix; // rax
		  __int128 v168; // xmm1
		  __int128 v169; // xmm0
		  __int128 v170; // xmm1
		  float4x4 *v171; // rax
		  __int128 *v172; // rbx
		  MethodInfo *v173; // r8
		  __int64 v174; // rdx
		  __int64 v175; // rcx
		  __int128 v176; // xmm2
		  __int128 v177; // xmm0
		  __int128 v178; // xmm1
		  __int128 v179; // xmm2
		  __int64 v180; // rcx
		  float v181; // xmm9_4
		  __int64 v182; // rcx
		  float v183; // xmm11_4
		  __int64 v184; // rdx
		  __int64 v185; // rcx
		  __int64 v186; // r8
		  __int64 v187; // r9
		  float v188; // xmm0_4
		  float orthographicSize; // xmm7_4
		  float v190; // xmm8_4
		  float v191; // xmm6_4
		  float v192; // xmm10_4
		  __int64 v193; // rsi
		  Void *m_Buffer; // rbx
		  Quaternion v195; // xmm0
		  Quaternion v196; // xmm0
		  Quaternion v197; // xmm0
		  Quaternion v198; // xmm0
		  Quaternion v199; // xmm0
		  Quaternion v200; // xmm0
		  Quaternion v201; // xmm0
		  Matrix4x4 *cameraToWorldMatrix; // rax
		  __int128 v203; // xmm1
		  __int128 v204; // xmm0
		  __int128 v205; // xmm1
		  float v206; // xmm8_4
		  float4x4 *v207; // rdi
		  float v208; // xmm7_4
		  float v209; // xmm10_4
		  __int128 v210; // xmm6
		  __int128 v211; // xmm11
		  float v212; // xmm9_4
		  float4 v213; // xmm1
		  float4 v214; // xmm0
		  float4 v215; // xmm1
		  float4 v216; // xmm0
		  __int128 *v217; // rax
		  __int128 v218; // xmm4
		  __int128 v219; // xmm5
		  __int128 v220; // xmm3
		  __m128 v221; // xmm3
		  float v222; // xmm3_4
		  __int64 v223; // rax
		  __int64 v224; // xmm0_8
		  MethodInfo *v225; // r9
		  float3 *v226; // rax
		  __int64 v227; // xmm3_8
		  MethodInfo *v228; // r9
		  float3 *v229; // rax
		  float3 *v230; // rbx
		  __int64 v231; // rax
		  __int64 v232; // xmm0_8
		  MethodInfo *v233; // r9
		  float3 *v234; // rax
		  __int64 v235; // xmm0_8
		  __int64 v236; // xmm3_8
		  MethodInfo *v237; // r9
		  float3 *v238; // rax
		  __int64 v239; // xmm6_8
		  float v240; // edi
		  __int64 v241; // rax
		  __int64 v242; // xmm0_8
		  float3 *v243; // rax
		  float v244; // edx
		  __int64 v245; // rax
		  __int64 v246; // xmm0_8
		  __int64 v247; // rax
		  __int64 v248; // xmm0_8
		  MethodInfo *v249; // r8
		  float3 *v250; // rax
		  __int64 v251; // xmm3_8
		  quaternion *v252; // rbx
		  quaternion v253; // xmm0
		  float4x4 *v254; // rax
		  float4 v255; // xmm1
		  float4 v256; // xmm0
		  float4 v257; // xmm1
		  Matrix4x4 *v258; // rax
		  __int128 v259; // xmm4
		  __int128 v260; // xmm5
		  __int128 v261; // xmm6
		  int v262; // edx
		  int v263; // r8d
		  int v264; // r9d
		  _OWORD *v265; // rax
		  __int128 v266; // xmm1
		  __int128 v267; // xmm0
		  __int128 v268; // xmm1
		  Matrix4x4 *v269; // rax
		  __int128 v270; // xmm1
		  __int128 v271; // xmm2
		  __int128 v272; // xmm3
		  __int128 v273; // xmm1
		  __int128 v274; // xmm0
		  __int128 v275; // xmm1
		  Quaternion value_8; // [rsp+48h] [rbp-C0h] BYREF
		  Quaternion v277; // [rsp+58h] [rbp-B0h] BYREF
		  float v278; // [rsp+68h] [rbp-A0h]
		  float4 v279; // [rsp+78h] [rbp-90h] BYREF
		  float3 v280; // [rsp+88h] [rbp-80h] BYREF
		  float4 vector; // [rsp+98h] [rbp-70h] BYREF
		  __m128 v282; // [rsp+A8h] [rbp-60h] BYREF
		  __m128i v283; // [rsp+B8h] [rbp-50h] BYREF
		  Matrix4x4 v284; // [rsp+C8h] [rbp-40h] BYREF
		  __int128 v285; // [rsp+108h] [rbp+0h] BYREF
		  Bounds v286; // [rsp+118h] [rbp+10h] BYREF
		  float3 v287; // [rsp+138h] [rbp+30h] BYREF
		  _BYTE v288[24]; // [rsp+148h] [rbp+40h] BYREF
		  float4 v289; // [rsp+168h] [rbp+60h] BYREF
		  Vector3 v290; // [rsp+178h] [rbp+70h] BYREF
		  float v291; // [rsp+188h] [rbp+80h]
		  __int64 v292; // [rsp+190h] [rbp+88h]
		  Matrix4x4 v293; // [rsp+198h] [rbp+90h] BYREF
		  NativeArray_1_Unity_Mathematics_quaternion_ v294; // [rsp+1D8h] [rbp+D0h] BYREF
		  _OWORD v295[13]; // [rsp+1E8h] [rbp+E0h] BYREF
		
		  v294 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2108, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2108, 0LL);
		    if ( Patch )
		    {
		      v273 = *(_OWORD *)&lightTransform->m01;
		      *(_OWORD *)&v284.m00 = *(_OWORD *)&lightTransform->m00;
		      v274 = *(_OWORD *)&lightTransform->m02;
		      *(_OWORD *)&v284.m01 = v273;
		      v275 = *(_OWORD *)&lightTransform->m03;
		      *(_OWORD *)&v284.m02 = v274;
		      *(_OWORD *)&v284.m03 = v275;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_849(
		        (ILFixDynamicMethodWrapper_2 *)Patch,
		        &v284,
		        (Object *)hgCamera,
		        (Object *)characterHelper,
		        worldToLightMatrices,
		        projectionMatrix,
		        lightDirection,
		        0LL);
		      return;
		    }
		LABEL_81:
		    sub_1800D8260(Patch, klass);
		  }
		  if ( !hgCamera )
		    goto LABEL_81;
		  camera = hgCamera->fields.camera;
		  if ( !characterHelper )
		    goto LABEL_81;
		  Bounds = HG::Rendering::Runtime::HGCharacterHelper::GetBounds(&v286, characterHelper, hgCamera->fields.camera, 0LL);
		  v15 = *(_QWORD *)&Bounds->m_Extents.y;
		  *(_OWORD *)v288 = *(_OWORD *)&Bounds->m_Center.x;
		  *(_QWORD *)&v288[16] = v15;
		  *(_QWORD *)&value_8.x = *(_QWORD *)v288;
		  LODWORD(value_8.z) = _mm_cvtsi128_si32(_mm_loadl_epi64((const __m128i *)&Bounds->m_Center.z));
		  xyz = Unity::Mathematics::float4::get_xyz((float3 *)&vector, (float4 *)&value_8, 0LL);
		  z = xyz->z;
		  *(_QWORD *)&v280.x = *(_QWORD *)&xyz->x;
		  v291 = z;
		  value_8.z = *(float *)&v288[20];
		  *(_QWORD *)&value_8.x = *(_QWORD *)&v288[12];
		  v18 = Unity::Mathematics::float4::get_xyz(&v287, (float4 *)&value_8, 0LL);
		  Patch = hgCamera->fields.camera;
		  v19 = *(_QWORD *)&xyz->x;
		  v20 = *(_QWORD *)&v18->x;
		  x = v18->z;
		  *(float *)&v18 = xyz->z;
		  v292 = v20;
		  *(_QWORD *)&v290.x = v20;
		  v278 = *(float *)&v18;
		  v287.x = x;
		  if ( !Patch )
		    goto LABEL_81;
		  transform = UnityEngine::Component::get_transform((Component *)Patch, 0LL);
		  if ( !transform )
		    goto LABEL_81;
		  position = UnityEngine::Transform::get_position((Vector3 *)&vector, transform, 0LL);
		  v24 = *(_QWORD *)&position->x;
		  *(float *)&position = position->z;
		  *(_QWORD *)&value_8.x = v24;
		  LODWORD(value_8.z) = (_DWORD)position;
		  v25 = Unity::Mathematics::float4::get_xyz((float3 *)&vector, (float4 *)&value_8, 0LL);
		  v26 = *(_QWORD *)&v25->x;
		  *(float *)&v285 = v25->z;
		  v277 = *UnityEngine::Matrix4x4::get_rotation((Quaternion *)&v286, lightTransform, 0LL);
		  v27 = _mm_loadu_si128((const __m128i *)Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
		                                           (Vector4 *)&v286,
		                                           (CinemachineSmoothPath_Waypoint *)&v277,
		                                           0LL));
		  volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(hgCamera, 0LL);
		  if ( !volumeComponentsData )
		    goto LABEL_81;
		  m_hgCharacterVolume = (Object_1 *)volumeComponentsData->fields.m_hgCharacterVolume;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Inequality(m_hgCharacterVolume, 0LL, 0LL) )
		    goto LABEL_14;
		  if ( !m_hgCharacterVolume )
		    goto LABEL_81;
		  CharacterSelfShadowMode = HG::Rendering::Runtime::HGCharacterVolume::GetCharacterSelfShadowMode(
		                              (HGCharacterVolume *)m_hgCharacterVolume,
		                              0LL);
		  klass = m_hgCharacterVolume[8].klass;
		  if ( CharacterSelfShadowMode != HGCharacterVolume_CharacterShadowMode__Enum_CameraVirtualLight )
		  {
		    if ( !klass )
		      goto LABEL_81;
		    if ( (unsigned int)sub_180002F70(10LL, klass) == 2 )
		    {
		      static_fields = TypeInfo::Unity::Mathematics::float3->static_fields;
		      v32 = *(_QWORD *)&static_fields->zero.x;
		      v33 = static_fields->zero.z;
		      klass = m_hgCharacterVolume[8].monitor;
		      *(_QWORD *)&value_8.x = v32;
		      if ( !klass )
		        goto LABEL_81;
		      *(_QWORD *)&v287.x = sub_180041350(10LL);
		      *(_QWORD *)&value_8.x = _mm_unpacklo_ps((__m128)LODWORD(v287.x), (__m128)LODWORD(v287.y)).m128_u64[0];
		      value_8.z = v33;
		      v34 = Unity::Mathematics::float4::get_xyz((float3 *)&vector, (float4 *)&value_8, 0LL);
		      v35 = *(_QWORD *)&v34->x;
		      *(float *)&v34 = v34->z;
		      *(_QWORD *)&value_8.x = v35;
		      LODWORD(value_8.z) = (_DWORD)v34;
		      v277 = *(Quaternion *)sub_182FA5910(&v286, &value_8, v36, v37);
		      v27 = _mm_loadu_si128((const __m128i *)Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
		                                               (Vector4 *)&v286,
		                                               (CinemachineSmoothPath_Waypoint *)&v277,
		                                               0LL));
		    }
		LABEL_14:
		    v38 = v278;
		    goto LABEL_15;
		  }
		  Patch = TypeInfo::Unity::Mathematics::float3->static_fields;
		  v124 = *((float *)Patch + 2);
		  *(_QWORD *)&vector.x = *(_QWORD *)Patch;
		  if ( !klass )
		    goto LABEL_81;
		  if ( (unsigned int)sub_180002F70(10LL, klass) == 2 )
		  {
		    Patch = hgCamera->fields.camera;
		    if ( !Patch )
		      goto LABEL_81;
		    v157 = UnityEngine::Component::get_transform((Component *)Patch, 0LL);
		    if ( !v157 )
		      goto LABEL_81;
		    forward = UnityEngine::Transform::get_forward((Vector3 *)&v279, v157, 0LL);
		    v159 = *(_QWORD *)&forward->x;
		    *(float *)&forward = forward->z;
		    *(_QWORD *)&value_8.x = v159;
		    LODWORD(value_8.z) = (_DWORD)forward;
		    value_8 = *UnityEngine::Quaternion::LookRotation((Quaternion *)&v286, (Vector3 *)&value_8, 0LL);
		    v160 = sub_182F3F6C0(&v279, &value_8);
		    klass = m_hgCharacterVolume[8].monitor;
		    vector.y = *(float *)(v160 + 4);
		    if ( !klass )
		      goto LABEL_81;
		    v161 = sub_180041350(10LL);
		    v38 = v278;
		    *(_QWORD *)&v285 = v161;
		    v145 = *(float *)&v161;
		  }
		  else
		  {
		    klass = m_hgCharacterVolume[8].klass;
		    if ( !klass )
		      goto LABEL_81;
		    if ( (unsigned int)sub_180002F70(10LL, klass) == 1 )
		    {
		      Patch = hgCamera->fields.camera;
		      if ( !Patch )
		        goto LABEL_81;
		      v146 = UnityEngine::Component::get_transform((Component *)Patch, 0LL);
		      if ( !v146 )
		        goto LABEL_81;
		      v147 = UnityEngine::Transform::get_forward((Vector3 *)&v279, v146, 0LL);
		      v148 = *(_QWORD *)&v147->x;
		      *(float *)&v147 = v147->z;
		      *(_QWORD *)&value_8.x = v148;
		      LODWORD(value_8.z) = (_DWORD)v147;
		      value_8 = *UnityEngine::Quaternion::LookRotation((Quaternion *)&v286, (Vector3 *)&value_8, 0LL);
		      v149 = sub_182F3F6C0(&v279, &value_8);
		      v150 = *(_QWORD *)v149;
		      LODWORD(v149) = *(_DWORD *)(v149 + 8);
		      *(_QWORD *)&value_8.x = v150;
		      LODWORD(value_8.z) = v149;
		      v151 = Unity::Mathematics::float4::get_xyz((float3 *)&v279, (float4 *)&value_8, 0LL);
		      v152 = *(_QWORD *)&v151->x;
		      *(float *)&v151 = v151->z;
		      *(_QWORD *)&value_8.x = v152;
		      v153 = *(float *)&v152;
		      LODWORD(value_8.z) = (_DWORD)v151;
		      v154 = *(float *)&v152 <= 180.0 ? 0.0 : 360.0;
		      klass = m_hgCharacterVolume[8].fields.m_CachedPtr;
		      v155 = v153 - v154;
		      if ( !klass )
		        goto LABEL_81;
		      v156 = sub_180041350(10LL);
		      klass = m_hgCharacterVolume[8].fields.m_CachedPtr;
		      *(_QWORD *)&v285 = v156;
		      vector.y = *((float *)&v156 + 1) + value_8.y;
		      if ( !klass )
		        goto LABEL_81;
		      *(_QWORD *)&v285 = sub_180041350(10LL);
		      if ( *(float *)&v285 > v155 )
		        v155 = *(float *)&v285;
		      v38 = v278;
		      vector.x = v155;
		      v20 = v292;
		      goto LABEL_50;
		    }
		    v38 = v278;
		    LODWORD(value_8.z) = v285;
		    *(_QWORD *)&v285 = v19;
		    *((float *)&v285 + 2) = v278;
		    *(_QWORD *)&value_8.x = v26;
		    v126 = Unity::Mathematics::float3::op_Subtraction((float3 *)&v279, (float3 *)&v285, (float3 *)&value_8, v125);
		    Patch = hgCamera->fields.camera;
		    v127 = *(_QWORD *)&v126->x;
		    v128 = v126->z;
		    if ( !Patch )
		      goto LABEL_81;
		    if ( UnityEngine::Camera::get_orthographic((Camera *)Patch, 0LL) )
		    {
		      Patch = hgCamera->fields.camera;
		      if ( !Patch )
		        goto LABEL_81;
		      v129 = UnityEngine::Component::get_transform((Component *)Patch, 0LL);
		      if ( !v129 )
		        goto LABEL_81;
		      v130 = UnityEngine::Transform::get_forward((Vector3 *)&v279, v129, 0LL);
		      v131 = *(_QWORD *)&v130->x;
		      *(float *)&v130 = v130->z;
		      *(_QWORD *)&value_8.x = v131;
		      LODWORD(value_8.z) = (_DWORD)v130;
		      v132 = Unity::Mathematics::float4::get_xyz((float3 *)&v279, (float4 *)&value_8, 0LL);
		      v133 = *(_QWORD *)&v132->x;
		      v128 = v132->z;
		    }
		    else
		    {
		      v133 = v127;
		    }
		    *(_QWORD *)&value_8.x = v133;
		    value_8.z = v128;
		    v134 = Unity::Mathematics::float4::get_xyz((float3 *)&v279, (float4 *)&value_8, 0LL);
		    v135 = *(_QWORD *)&v134->x;
		    *(float *)&v134 = v134->z;
		    *(_QWORD *)&value_8.x = v135;
		    LODWORD(value_8.z) = (_DWORD)v134;
		    value_8 = *UnityEngine::Quaternion::LookRotation((Quaternion *)&v286, (Vector3 *)&value_8, 0LL);
		    v136 = sub_182F3F6C0(&v279, &value_8);
		    v137 = *(_QWORD *)v136;
		    LODWORD(v136) = *(_DWORD *)(v136 + 8);
		    *(_QWORD *)&value_8.x = v137;
		    LODWORD(value_8.z) = v136;
		    v138 = Unity::Mathematics::float4::get_xyz((float3 *)&v279, (float4 *)&value_8, 0LL);
		    v124 = v138->z;
		    *(_QWORD *)&vector.x = *(_QWORD *)&v138->x;
		    if ( vector.x <= 180.0 )
		      v139 = 0.0;
		    else
		      v139 = 360.0;
		    v140 = vector.x - v139;
		    value_8 = *UnityEngine::Matrix4x4::get_rotation((Quaternion *)&v286, lightTransform, 0LL);
		    v141 = sub_182F3F6C0(&v279, &value_8);
		    v142 = *(_QWORD *)v141;
		    LODWORD(v141) = *(_DWORD *)(v141 + 8);
		    *(_QWORD *)&value_8.x = v142;
		    LODWORD(value_8.z) = v141;
		    v143 = Unity::Mathematics::float4::get_xyz((float3 *)&v279, (float4 *)&value_8, 0LL);
		    v144 = *(_QWORD *)&v143->x;
		    *(float *)&v143 = v143->z;
		    *(_QWORD *)&v285 = v144;
		    v145 = 45.0;
		    DWORD2(v285) = (_DWORD)v143;
		    if ( *(float *)&v285 < 45.0 )
		      v145 = *(float *)&v285;
		    if ( v140 > v145 )
		      v145 = v140;
		    v20 = v292;
		  }
		  vector.x = v145;
		LABEL_50:
		  *(_QWORD *)&value_8.x = *(_QWORD *)&vector.x;
		  value_8.z = v124;
		  v162 = Unity::Mathematics::float4::get_xyz((float3 *)&v279, (float4 *)&value_8, 0LL);
		  v163 = *(_QWORD *)&v162->x;
		  *(float *)&v162 = v162->z;
		  *(_QWORD *)&value_8.x = v163;
		  LODWORD(value_8.z) = (_DWORD)v162;
		  v277 = *(Quaternion *)sub_182FA5910(&v286, &value_8, v164, v165);
		  AsVector4 = Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
		                (Vector4 *)&v286,
		                (CinemachineSmoothPath_Waypoint *)&v277,
		                0LL);
		  x = v287.x;
		  v27 = _mm_loadu_si128((const __m128i *)AsVector4);
		LABEL_15:
		  v277 = (Quaternion)v27;
		  v39 = sub_185F0E3A0(&v279, &v277);
		  v40 = v290.x;
		  *(_QWORD *)&value_8.x = v20;
		  y = v290.y;
		  *(_QWORD *)&vector.x = _mm_unpacklo_ps((__m128)LODWORD(v290.x), (__m128)LODWORD(v290.y)).m128_u64[0];
		  v42 = *(_QWORD *)v39;
		  LODWORD(v39) = *(_DWORD *)(v39 + 8);
		  *(_QWORD *)&v287.x = v42;
		  LODWORD(v287.z) = v39;
		  vector.z = x;
		  value_8.z = x;
		  Dest::Math::Vector3ex::Dot((Vector3 *)&vector, (Vector3 *)&value_8, v43);
		  *(float *)&v42 = sub_1803386C0(v45, v44);
		  v47 = Unity::Mathematics::float3::op_Multiply((float3 *)&v279, &v287, -*(float *)&v42, v46);
		  *(_QWORD *)&vector.x = v19;
		  vector.z = v38;
		  v48 = *(_QWORD *)&v47->x;
		  *(float *)&v47 = v47->z;
		  *(_QWORD *)&value_8.x = v48;
		  LODWORD(value_8.z) = (_DWORD)v47;
		  v50 = Unity::Mathematics::float3::op_Addition((float3 *)&v279, (float3 *)&vector, (float3 *)&value_8, v49);
		  v51 = v50->z;
		  *(_QWORD *)&v287.x = *(_QWORD *)&v50->x;
		  sub_18033B9D0(&v293, 0LL, 64LL);
		  *(_QWORD *)&value_8.x = *(_QWORD *)&v50->x;
		  value_8.z = v51;
		  v277 = (Quaternion)v27;
		  Unity::Mathematics::float4x4::float4x4((float4x4 *)&v293, (quaternion *)&v277, (float3 *)&value_8, 0LL);
		  v284 = v293;
		  v52 = Unity::Mathematics::math::inverse((float4x4 *)&v293, (float4x4 *)&v284, 0LL);
		  v295[1] = v52->c0;
		  v295[2] = v52->c1;
		  v295[0] = v52->c2;
		  *(float4 *)&v286.m_Center.x = v52->c3;
		  v279.x = v280.x - v40;
		  v53 = v291;
		  v279.w = 1.0;
		  value_8.w = 1.0;
		  vector.w = 1.0;
		  v279.y = y + v280.y;
		  HIDWORD(v285) = 1065353216;
		  v289.w = 1.0;
		  v282.m128_i32[3] = 1065353216;
		  v283.m128i_i32[3] = 1065353216;
		  v277.w = 1.0;
		  v279.z = v291 - x;
		  value_8.y = y + v280.y;
		  value_8.x = v40 + v280.x;
		  vector.x = v280.x - v40;
		  value_8.z = v291 - x;
		  vector.z = v291 - x;
		  vector.y = v280.y - y;
		  *((float *)&v285 + 1) = v280.y - y;
		  *(float *)&v285 = v40 + v280.x;
		  v289.x = v280.x - v40;
		  *((float *)&v285 + 2) = v291 - x;
		  v289.z = x + v291;
		  v289.y = y + v280.y;
		  v282.m128_f32[1] = y + v280.y;
		  v282.m128_f32[0] = v40 + v280.x;
		  *(float *)v283.m128i_i32 = v280.x - v40;
		  v282.m128_f32[2] = x + v291;
		  *(float *)&v283.m128i_i32[2] = x + v291;
		  *(float *)&v283.m128i_i32[1] = v280.y - y;
		  v277.y = v280.y - y;
		  c0 = v52->c0;
		  v277.x = v40 + v280.x;
		  v277.z = x + v291;
		  c1 = v52->c1;
		  *(float4 *)&v284.m00 = c0;
		  c2 = v52->c2;
		  *(float4 *)&v284.m01 = c1;
		  c3 = v52->c3;
		  *(float4 *)&v284.m02 = c2;
		  *(float4 *)&v284.m03 = c3;
		  v58 = (const __m128i *)sub_182F3DE20(v288, &v284, &v279);
		  v59 = v52->c0;
		  v60 = _mm_loadu_si128(v58);
		  v279 = (float4)value_8;
		  v61 = v52->c1;
		  *(float4 *)&v284.m00 = v59;
		  v62 = v52->c2;
		  *(float4 *)&v284.m01 = v61;
		  v63 = v52->c3;
		  *(float4 *)&v284.m02 = v62;
		  *(float4 *)&v284.m03 = v63;
		  sub_182F3DE20(v288, &v284, &v279);
		  v64 = v52->c0;
		  v279 = vector;
		  v65 = v52->c1;
		  *(float4 *)&v284.m00 = v64;
		  v66 = v52->c2;
		  *(float4 *)&v284.m01 = v65;
		  v67 = v52->c3;
		  *(float4 *)&v284.m02 = v66;
		  *(float4 *)&v284.m03 = v67;
		  v68 = (const __m128i *)sub_182F3DE20(v288, &v284, &v279);
		  v69 = v52->c0;
		  v70 = _mm_loadu_si128(v68);
		  v279 = (float4)v285;
		  v71 = v52->c1;
		  *(float4 *)&v284.m00 = v69;
		  v72 = v52->c2;
		  *(float4 *)&v284.m01 = v71;
		  v73 = v52->c3;
		  *(float4 *)&v284.m02 = v72;
		  *(float4 *)&v284.m03 = v73;
		  v74 = _mm_loadu_si128((const __m128i *)sub_182F3DE20(v288, &v284, &v279));
		  v75 = v52->c1;
		  *(float4 *)&v284.m00 = v52->c0;
		  v76 = v52->c2;
		  *(float4 *)&v284.m01 = v75;
		  v77 = v52->c3;
		  *(float4 *)&v284.m02 = v76;
		  *(float4 *)&v284.m03 = v77;
		  v78 = _mm_loadu_si128((const __m128i *)sub_182F3DE20(v288, &v284, &v289));
		  v79 = v52->c1;
		  *(float4 *)&v284.m00 = v52->c0;
		  v80 = v52->c2;
		  *(float4 *)&v284.m01 = v79;
		  v81 = v52->c3;
		  *(float4 *)&v284.m02 = v80;
		  *(float4 *)&v284.m03 = v81;
		  v82 = _mm_loadu_si128((const __m128i *)sub_182F3DE20(v288, &v284, &v282));
		  v83 = v52->c1;
		  *(float4 *)&v284.m00 = v52->c0;
		  v84 = v52->c2;
		  *(float4 *)&v284.m01 = v83;
		  v85 = v52->c3;
		  *(float4 *)&v284.m02 = v84;
		  *(float4 *)&v284.m03 = v85;
		  v86 = _mm_loadu_si128((const __m128i *)sub_182F3DE20(v288, &v284, &v283));
		  v87 = v52->c1;
		  *(float4 *)&v284.m00 = v52->c0;
		  v88 = v52->c2;
		  *(float4 *)&v284.m01 = v87;
		  v89 = v52->c3;
		  *(float4 *)&v284.m02 = v88;
		  *(float4 *)&v284.m03 = v89;
		  v90 = _mm_loadu_si128((const __m128i *)sub_182F3DE20(v288, &v284, &v277));
		  v277 = v91;
		  v283 = v60;
		  v93 = _mm_loadu_si128((const __m128i *)Unity::Mathematics::math::min(
		                                           (float4 *)v288,
		                                           (float4 *)&v283,
		                                           (float4 *)&v277,
		                                           v92));
		  v277 = (Quaternion)v70;
		  v283 = v93;
		  v95 = _mm_loadu_si128((const __m128i *)Unity::Mathematics::math::min(
		                                           (float4 *)v288,
		                                           (float4 *)&v283,
		                                           (float4 *)&v277,
		                                           v94));
		  v277 = (Quaternion)v74;
		  v283 = v95;
		  v97 = _mm_loadu_si128((const __m128i *)Unity::Mathematics::math::min(
		                                           (float4 *)v288,
		                                           (float4 *)&v283,
		                                           (float4 *)&v277,
		                                           v96));
		  v277 = (Quaternion)v78;
		  v283 = v97;
		  v99 = _mm_loadu_si128((const __m128i *)Unity::Mathematics::math::min(
		                                           (float4 *)v288,
		                                           (float4 *)&v283,
		                                           (float4 *)&v277,
		                                           v98));
		  v277 = (Quaternion)v82;
		  v283 = v99;
		  v101 = _mm_loadu_si128((const __m128i *)Unity::Mathematics::math::min(
		                                            (float4 *)v288,
		                                            (float4 *)&v283,
		                                            (float4 *)&v277,
		                                            v100));
		  v277 = (Quaternion)v86;
		  v283 = v101;
		  v103 = Unity::Mathematics::math::min((float4 *)v288, (float4 *)&v283, (float4 *)&v277, v102);
		  v277 = (Quaternion)v90;
		  v283 = _mm_loadu_si128((const __m128i *)v103);
		  v105 = _mm_loadu_si128((const __m128i *)Unity::Mathematics::math::min(
		                                            (float4 *)v288,
		                                            (float4 *)&v283,
		                                            (float4 *)&v277,
		                                            v104));
		  v277 = v106;
		  v283 = v105;
		  v282 = (__m128)v60;
		  v108 = _mm_loadu_si128((const __m128i *)Unity::Mathematics::math::max(&v289, (float4 *)&v282, (float4 *)&v277, v107));
		  v277 = (Quaternion)v70;
		  v282 = (__m128)v108;
		  v110 = _mm_loadu_si128((const __m128i *)Unity::Mathematics::math::max(&v289, (float4 *)&v282, (float4 *)&v277, v109));
		  v277 = (Quaternion)v74;
		  v282 = (__m128)v110;
		  v112 = _mm_loadu_si128((const __m128i *)Unity::Mathematics::math::max(&v289, (float4 *)&v282, (float4 *)&v277, v111));
		  v277 = (Quaternion)v78;
		  v282 = (__m128)v112;
		  v114 = _mm_loadu_si128((const __m128i *)Unity::Mathematics::math::max(&v289, (float4 *)&v282, (float4 *)&v277, v113));
		  v277 = (Quaternion)v82;
		  v282 = (__m128)v114;
		  v116 = _mm_loadu_si128((const __m128i *)Unity::Mathematics::math::max(&v289, (float4 *)&v282, (float4 *)&v277, v115));
		  v277 = (Quaternion)v86;
		  v282 = (__m128)v116;
		  v118 = _mm_loadu_si128((const __m128i *)Unity::Mathematics::math::max(&v289, (float4 *)&v282, (float4 *)&v277, v117));
		  v277 = (Quaternion)v90;
		  v282 = (__m128)v118;
		  v120 = Unity::Mathematics::math::max(&v289, (float4 *)&v282, (float4 *)&v277, v119);
		  v122 = *(float *)(v121 + 8);
		  v282 = (__m128)_mm_loadu_si128((const __m128i *)v120);
		  v123 = _mm_shuffle_ps(v282, v282, 170).m128_f32[0];
		  if ( v123 > v122 )
		    v278 = v122;
		  else
		    v278 = v123;
		  if ( v122 > v123 )
		    v123 = v122;
		  if ( !camera )
		    goto LABEL_81;
		  worldToCameraMatrix = UnityEngine::Camera::get_worldToCameraMatrix(&v293, camera, 0LL);
		  v168 = *(_OWORD *)&worldToCameraMatrix->m01;
		  *(_OWORD *)&v284.m00 = *(_OWORD *)&worldToCameraMatrix->m00;
		  v169 = *(_OWORD *)&worldToCameraMatrix->m02;
		  *(_OWORD *)&v284.m01 = v168;
		  v170 = *(_OWORD *)&worldToCameraMatrix->m03;
		  *(_OWORD *)&v284.m02 = v169;
		  *(_OWORD *)&v284.m03 = v170;
		  v171 = Unity::Mathematics::float4x4::op_Implicit((float4x4 *)&v293, &v284, 0LL);
		  *(_QWORD *)&value_8.x = v292;
		  v172 = (__int128 *)v171;
		  *(_QWORD *)&v290.x = _mm_unpacklo_ps((__m128)LODWORD(v290.x), (__m128)LODWORD(v290.y)).m128_u64[0];
		  value_8.z = x;
		  v290.z = x;
		  Dest::Math::Vector3ex::Dot(&v290, (Vector3 *)&value_8, v173);
		  sub_1803386C0(v175, v174);
		  v176 = *v172;
		  v277.z = v53;
		  v277.w = 1.0;
		  *(_QWORD *)&v277.x = *(_QWORD *)&v280.x;
		  v177 = v172[3];
		  v178 = v172[1];
		  *(_OWORD *)&v284.m00 = v176;
		  v179 = v172[2];
		  *(_OWORD *)&v284.m01 = v178;
		  *(_OWORD *)&v284.m02 = v179;
		  *(_OWORD *)&v284.m03 = v177;
		  _mm_xor_ps((__m128)*(unsigned int *)(sub_182F3DE20(v288, &v284, &v277) + 8), (__m128)0x80000000);
		  UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
		  UnityEngine::Camera::get_farClipPlane(camera, 0LL);
		  v181 = sub_182EE75E0(v180);
		  UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
		  v183 = sub_182EE75E0(v182);
		  if ( UnityEngine::Camera::get_orthographic(camera, 0LL) )
		  {
		    orthographicSize = UnityEngine::Camera::get_orthographicSize(camera, 0LL);
		    v190 = orthographicSize;
		    v191 = UnityEngine::Camera::get_aspect(camera, 0LL) * orthographicSize;
		    v192 = v191;
		  }
		  else
		  {
		    UnityEngine::Camera::get_fieldOfView(camera, 0LL);
		    v188 = sub_180338A80(v185, v184, v186, v187);
		    orthographicSize = v188 * v183;
		    v190 = v188 * v181;
		    v191 = UnityEngine::Camera::get_aspect(camera, 0LL) * (float)(v188 * v183);
		    v192 = UnityEngine::Camera::get_aspect(camera, 0LL) * v190;
		  }
		  v193 = 8LL;
		  Unity::Collections::NativeArray<Unity::Mathematics::quaternion>::NativeArray(
		    &v294,
		    8,
		    Allocator__Enum_Temp,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<Unity::Mathematics::float4>::NativeArray);
		  m_Buffer = v294.m_Buffer;
		  v277.w = 1.0;
		  LODWORD(v277.x) = LODWORD(v191) ^ 0x80000000;
		  LODWORD(v277.y) = LODWORD(orthographicSize) ^ 0x80000000;
		  LODWORD(v277.z) = LODWORD(v183) ^ 0x80000000;
		  v195 = v277;
		  v277.w = 1.0;
		  v277.x = v191;
		  *(Quaternion *)v294.m_Buffer = v195;
		  LODWORD(v277.y) = LODWORD(orthographicSize) ^ 0x80000000;
		  LODWORD(v277.z) = LODWORD(v183) ^ 0x80000000;
		  v196 = v277;
		  v277.w = 1.0;
		  LODWORD(v277.x) = LODWORD(v191) ^ 0x80000000;
		  *(Quaternion *)&m_Buffer[16] = v196;
		  v277.y = orthographicSize;
		  v277.z = -v183;
		  v197 = v277;
		  v277.w = 1.0;
		  v277.x = v191;
		  *(Quaternion *)&m_Buffer[32] = v197;
		  v277.y = orthographicSize;
		  v277.z = -v183;
		  v198 = v277;
		  v277.w = 1.0;
		  LODWORD(v277.x) = LODWORD(v192) ^ 0x80000000;
		  *(Quaternion *)&m_Buffer[48] = v198;
		  LODWORD(v277.z) = LODWORD(v181) ^ 0x80000000;
		  LODWORD(v277.y) = LODWORD(v190) ^ 0x80000000;
		  v199 = v277;
		  v277.w = 1.0;
		  v277.x = v192;
		  *(Quaternion *)&m_Buffer[64] = v199;
		  LODWORD(v277.y) = LODWORD(v190) ^ 0x80000000;
		  LODWORD(v277.z) = LODWORD(v181) ^ 0x80000000;
		  v200 = v277;
		  v277.w = 1.0;
		  v277.x = -v192;
		  *(Quaternion *)&m_Buffer[80] = v200;
		  v277.y = v190;
		  LODWORD(v277.z) = LODWORD(v181) ^ 0x80000000;
		  v201 = v277;
		  v277.x = v192;
		  *(Quaternion *)&m_Buffer[96] = v201;
		  v277.y = v190;
		  v277.z = -v181;
		  v277.w = 1.0;
		  *(Quaternion *)&m_Buffer[112] = v277;
		  cameraToWorldMatrix = UnityEngine::Camera::get_cameraToWorldMatrix(&v293, camera, 0LL);
		  v203 = *(_OWORD *)&cameraToWorldMatrix->m01;
		  *(_OWORD *)&v284.m00 = *(_OWORD *)&cameraToWorldMatrix->m00;
		  v204 = *(_OWORD *)&cameraToWorldMatrix->m02;
		  *(_OWORD *)&v284.m01 = v203;
		  v205 = *(_OWORD *)&cameraToWorldMatrix->m03;
		  *(_OWORD *)&v284.m02 = v204;
		  *(_OWORD *)&v284.m03 = v205;
		  v206 = 3.4028235e38;
		  v207 = Unity::Mathematics::float4x4::op_Implicit((float4x4 *)&v293, &v284, 0LL);
		  v208 = -3.4028235e38;
		  v209 = 3.4028235e38;
		  v210 = v295[0];
		  v211 = *(_OWORD *)&v286.m_Center.x;
		  v212 = -3.4028235e38;
		  do
		  {
		    v213 = v207->c0;
		    *(_OWORD *)&v286.m_Center.x = *(_OWORD *)m_Buffer;
		    v214 = v207->c1;
		    *(float4 *)&v284.m00 = v213;
		    v215 = v207->c2;
		    *(float4 *)&v284.m01 = v214;
		    v216 = v207->c3;
		    *(float4 *)&v284.m02 = v215;
		    *(float4 *)&v284.m03 = v216;
		    v217 = (__int128 *)sub_182F3DE20(v288, &v284, &v286);
		    *(_OWORD *)&v284.m00 = v218;
		    *(_OWORD *)&v284.m01 = v219;
		    *(_OWORD *)&v284.m02 = v210;
		    v220 = *v217;
		    *(_OWORD *)&v284.m03 = v211;
		    *(_OWORD *)&v286.m_Center.x = v220;
		    v221 = (__m128)_mm_loadu_si128((const __m128i *)sub_182F3DE20(v295, &v284, &v286));
		    if ( v221.m128_f32[0] <= v206 )
		      v206 = v221.m128_f32[0];
		    if ( v208 <= v221.m128_f32[0] )
		      v208 = v221.m128_f32[0];
		    v222 = _mm_shuffle_ps(v221, v221, 85).m128_f32[0];
		    if ( v222 <= v209 )
		      v209 = v222;
		    if ( v212 <= v222 )
		      v212 = v222;
		    m_Buffer += 16;
		    --v193;
		  }
		  while ( v193 );
		  if ( *(float *)v283.m128i_i32 > v206 )
		    v206 = *(float *)v283.m128i_i32;
		  if ( v208 > v282.m128_f32[0] )
		    v208 = v282.m128_f32[0];
		  if ( *(float *)&v283.m128i_i32[1] > v209 )
		    v209 = *(float *)&v283.m128i_i32[1];
		  if ( v212 > v282.m128_f32[1] )
		    v212 = v282.m128_f32[1];
		  if ( v206 >= v208 || v209 >= v212 )
		  {
		    v206 = *(float *)v283.m128i_i32;
		    v208 = v282.m128_f32[0];
		    v209 = *(float *)&v283.m128i_i32[1];
		    v212 = v282.m128_f32[1];
		  }
		  value_8.z = 0.0;
		  *(_QWORD *)&value_8.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0LL).m128_u64[0];
		  *(__m128i *)&v286.m_Center.x = v27;
		  v223 = sub_182FACF20(&v279, &v286, &value_8);
		  v224 = *(_QWORD *)v223;
		  LODWORD(v223) = *(_DWORD *)(v223 + 8);
		  *(_QWORD *)&value_8.x = v224;
		  LODWORD(value_8.z) = v223;
		  v226 = Unity::Mathematics::float3::op_Multiply((float3 *)&v279, (float3 *)&value_8, (float)(v208 + v206) * 0.5, v225);
		  *(_QWORD *)&v280.x = *(_QWORD *)&v287.x;
		  v280.z = v51;
		  v227 = *(_QWORD *)&v226->x;
		  *(float *)&v226 = v226->z;
		  *(_QWORD *)&value_8.x = v227;
		  LODWORD(value_8.z) = (_DWORD)v226;
		  v229 = Unity::Mathematics::float3::op_Addition((float3 *)&v279, &v280, (float3 *)&value_8, v228);
		  value_8.z = 0.0;
		  *(_QWORD *)&value_8.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		  *(__m128i *)&v286.m_Center.x = v27;
		  v230 = v229;
		  v231 = sub_182FACF20(&v280, &v286, &value_8);
		  v232 = *(_QWORD *)v231;
		  LODWORD(v231) = *(_DWORD *)(v231 + 8);
		  *(_QWORD *)&value_8.x = v232;
		  LODWORD(value_8.z) = v231;
		  v234 = Unity::Mathematics::float3::op_Multiply(&v280, (float3 *)&value_8, (float)(v212 + v209) * 0.5, v233);
		  v235 = *(_QWORD *)&v230->x;
		  v236 = *(_QWORD *)&v234->x;
		  value_8.z = v234->z;
		  v280.z = v230->z;
		  *(_QWORD *)&value_8.x = v236;
		  *(_QWORD *)&v280.x = v235;
		  v238 = Unity::Mathematics::float3::op_Addition((float3 *)&v279, &v280, (float3 *)&value_8, v237);
		  *(__m128i *)&v286.m_Center.x = v27;
		  v239 = *(_QWORD *)&v238->x;
		  v240 = v238->z;
		  v241 = sub_185F0E3A0(&v279, &v286);
		  v242 = *(_QWORD *)v241;
		  LODWORD(v241) = *(_DWORD *)(v241 + 8);
		  *(_QWORD *)&value_8.x = v242;
		  LODWORD(value_8.z) = v241;
		  v243 = Unity::Mathematics::float4::get_xyz((float3 *)&v279, (float4 *)&value_8, 0LL);
		  v244 = v243->z;
		  *(_QWORD *)&lightDirection->x = *(_QWORD *)&v243->x;
		  lightDirection->z = v244;
		  *(__m128i *)&v286.m_Center.x = v27;
		  v245 = sub_185F0E3A0(&v279, &v286);
		  value_8.z = 0.0;
		  *(__m128i *)&v286.m_Center.x = v27;
		  v246 = *(_QWORD *)v245;
		  LODWORD(v245) = *(_DWORD *)(v245 + 8);
		  *(_QWORD *)&v280.x = v246;
		  *(_QWORD *)&value_8.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		  LODWORD(v280.z) = v245;
		  v247 = sub_182FACF20(&v279, &v286, &value_8);
		  v248 = *(_QWORD *)v247;
		  LODWORD(v247) = *(_DWORD *)(v247 + 8);
		  *(_QWORD *)&value_8.x = v248;
		  LODWORD(value_8.z) = v247;
		  v250 = Unity::Mathematics::float3::op_UnaryNegation((float3 *)&v279, &v280, v249);
		  v251 = *(_QWORD *)&v250->x;
		  *(float *)&v250 = v250->z;
		  *(_QWORD *)&v280.x = v251;
		  LODWORD(v280.z) = (_DWORD)v250;
		  v252 = Unity::Mathematics::quaternion::LookRotationSafe((quaternion *)v288, &v280, (float3 *)&value_8, 0LL);
		  sub_18033B9D0(&v293, 0LL, 64LL);
		  v253 = *v252;
		  *(_QWORD *)&value_8.x = v239;
		  value_8.z = v240;
		  *(quaternion *)&v286.m_Center.x = v253;
		  Unity::Mathematics::float4x4::float4x4((float4x4 *)&v293, (quaternion *)&v286, (float3 *)&value_8, 0LL);
		  v284 = v293;
		  v254 = Unity::Mathematics::math::inverse((float4x4 *)&v293, (float4x4 *)&v284, 0LL);
		  v255 = v254->c1;
		  *(float4 *)&v284.m00 = v254->c0;
		  v256 = v254->c2;
		  *(float4 *)&v284.m01 = v255;
		  v257 = v254->c3;
		  *(float4 *)&v284.m02 = v256;
		  *(float4 *)&v284.m03 = v257;
		  v258 = Unity::Mathematics::float4x4::op_Implicit(&v293, (float4x4 *)&v284, 0LL);
		  v259 = *(_OWORD *)&v258->m01;
		  v260 = *(_OWORD *)&v258->m02;
		  v261 = *(_OWORD *)&v258->m03;
		  *(_OWORD *)&worldToLightMatrices->m00 = *(_OWORD *)&v258->m00;
		  *(_OWORD *)&worldToLightMatrices->m01 = v259;
		  *(_OWORD *)&worldToLightMatrices->m02 = v260;
		  *(_OWORD *)&worldToLightMatrices->m03 = v261;
		  v265 = (_OWORD *)sub_1833A3CB0((unsigned int)&v293, v262, v263, v264, LODWORD(v123));
		  v266 = v265[1];
		  *(_OWORD *)&v284.m00 = *v265;
		  v267 = v265[2];
		  *(_OWORD *)&v284.m01 = v266;
		  v268 = v265[3];
		  *(_OWORD *)&v284.m02 = v267;
		  *(_OWORD *)&v284.m03 = v268;
		  v269 = Unity::Mathematics::float4x4::op_Implicit(&v293, (float4x4 *)&v284, 0LL);
		  v270 = *(_OWORD *)&v269->m01;
		  v271 = *(_OWORD *)&v269->m02;
		  v272 = *(_OWORD *)&v269->m03;
		  *(_OWORD *)&projectionMatrix->m00 = *(_OWORD *)&v269->m00;
		  *(_OWORD *)&projectionMatrix->m01 = v270;
		  *(_OWORD *)&projectionMatrix->m02 = v271;
		  *(_OWORD *)&projectionMatrix->m03 = v272;
		}
		
		private void SetupCharacterShadowReceiverConstants([IsReadOnly] in VisibleLight shadowLight, int characterShadowCount) {} // 0x0000000189D24B84-0x0000000189D24ED4
		// Void SetupCharacterShadowReceiverConstants(VisibleLight ByRef, Int32)
		void HG::Rendering::Runtime::HGShadowManager::SetupCharacterShadowReceiverConstants(
		        HGShadowManager *this,
		        VisibleLight *shadowLight,
		        int32_t characterShadowCount,
		        MethodInfo *method)
		{
		  LightShadows__Enum shadows_Injected; // ebx
		  int v8; // xmm6_4
		  float v9; // xmm7_4
		  float v10; // xmm8_4
		  int v11; // esi
		  __int64 v12; // r14
		  int32_t v13; // ebp
		  __int64 v14; // r15
		  __int64 v15; // rdx
		  void *m_CharacterShadowMatrices; // rcx
		  HGShadowConstantBufferUtils__StaticFields *static_fields; // rbx
		  Matrix4x4 *v18; // rax
		  float Item; // xmm0_4
		  int v20; // esi
		  __int64 v21; // r14
		  unsigned int v22; // ebp
		  __int64 v23; // r15
		  HGShadowConstantBufferUtils__StaticFields *v24; // rbx
		  __int64 v25; // rax
		  HGShadowConstantBufferUtils__StaticFields *v26; // rbx
		  __int64 v27; // rax
		  HGShadowConstantBufferUtils__StaticFields *v28; // rbx
		  __int64 v29; // rax
		  float v30; // xmm0_4
		  __int64 v31; // rax
		  HGShadowConstantBufferUtils__StaticFields *v32; // rcx
		  __m128i v33; // xmm1
		  HGShadowConstantBufferUtils__StaticFields *v34; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGSharedLightData _unity_self; // [rsp+30h] [rbp-78h] BYREF
		  __int128 v37; // [rsp+38h] [rbp-70h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2116, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2116, 0LL);
		    if ( !Patch )
		LABEL_18:
		      sub_1800D8260(m_CharacterShadowMatrices, v15);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_855(Patch, (Object *)this, shadowLight, characterShadowCount, 0LL);
		  }
		  else
		  {
		    _unity_self = shadowLight->hgSharedLightData;
		    shadows_Injected = UnityEngine::HGSharedLightData::get_shadows_Injected(&_unity_self, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		    HG::Rendering::Runtime::HGShadowManager::GetShadowTransform(
		      TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterProjectionMatrices,
		      TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterWorldToLightMatrices,
		      &this->fields.m_CharacterShadowMatrices,
		      0LL);
		    v8 = 1065353216;
		    v9 = 1.0 / (float)TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowmapSize.m_X;
		    v10 = 1.0 / (float)TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowmapSize.m_Y;
		    if ( shadows_Injected != LightShadows__Enum_Soft )
		      v8 = 0;
		    v11 = 0;
		    v12 = 0LL;
		    do
		    {
		      v13 = 0;
		      v14 = 0LL;
		      do
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		        m_CharacterShadowMatrices = this->fields.m_CharacterShadowMatrices;
		        if ( !m_CharacterShadowMatrices )
		          goto LABEL_18;
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields;
		        v18 = (Matrix4x4 *)sub_18049E964(m_CharacterShadowMatrices, v11);
		        Item = UnityEngine::Matrix4x4::get_Item(v18, v13++, 0LL);
		        *(&static_fields[17].shadowData._ASMWorldToShadowBaseMatrix.m03 + v12 + v14++) = Item;
		      }
		      while ( v13 < 16 );
		      ++v11;
		      v12 += 16LL;
		    }
		    while ( v11 < 14 );
		    v20 = 0;
		    v21 = 0LL;
		    do
		    {
		      v22 = 0;
		      v23 = 0LL;
		      do
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		        m_CharacterShadowMatrices = this->fields.m_CharacterShadowBiases;
		        if ( !m_CharacterShadowMatrices )
		          goto LABEL_18;
		        v24 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields;
		        v25 = sub_180002100(m_CharacterShadowMatrices, v20);
		        *((float *)&v24[19].s_shadowBufferHandle.size + v21 + v23) = sub_1832E0B20(v25, v22);
		        v26 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		        m_CharacterShadowMatrices = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowLightDirs;
		        if ( !m_CharacterShadowMatrices )
		          goto LABEL_18;
		        v27 = sub_180002100(m_CharacterShadowMatrices, v20);
		        *(&v26[20].shadowData._ASMWorldToShadowBaseMatrix.m21 + v21 + v23) = sub_1832E0B20(v27, v22);
		        v28 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields;
		        m_CharacterShadowMatrices = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowAtlasParams;
		        if ( !m_CharacterShadowMatrices )
		          goto LABEL_18;
		        v29 = sub_180002100(m_CharacterShadowMatrices, v20);
		        v30 = sub_1832E0B20(v29, v22);
		        v31 = v21 + v23;
		        ++v22;
		        ++v23;
		        *(&v28[21].shadowData._CSMPenumbraSizes.z + v31) = v30;
		      }
		      while ( (int)v22 < 4 );
		      ++v20;
		      v21 += 4LL;
		    }
		    while ( v20 < 14 );
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		    *(_QWORD *)&v37 = __PAIR64__(
		                        v8,
		                        COERCE_UNSIGNED_INT(UnityEngine::HGSharedLightData::get_shadowStrength_Injected(&_unity_self, 0LL)));
		    v32 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields;
		    *((_QWORD *)&v37 + 1) = COERCE_UNSIGNED_INT((float)characterShadowCount);
		    *(_OWORD *)&v32[21].shadowData._ASMIndirectWorldToShadow.m03 = v37;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		    *(_QWORD *)&v37 = __PAIR64__(LODWORD(v10), LODWORD(v9));
		    v33 = _mm_cvtsi32_si128(TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowmapSize.m_Y);
		    v34 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields;
		    *((float *)&v37 + 2) = (float)TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_CharacterShadowmapSize.m_X;
		    HIDWORD(v37) = _mm_cvtepi32_ps(v33).m128_u32[0];
		    *(_OWORD *)&v34[21].shadowData._ASMIndirectWorldToShadow.m02 = v37;
		  }
		}
		
		private void CharacterShadowCleanup() {} // 0x00000001849D36F0-0x00000001849D3720
		// Void CharacterShadowCleanup()
		void HG::Rendering::Runtime::HGShadowManager::CharacterShadowCleanup(HGShadowManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(548, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(548, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		}
		
		private static void GetShadowTransform(Matrix4x4[] projs, Matrix4x4[] views, ref Matrix4x4[] shadows) {} // 0x0000000189D22354-0x0000000189D22618
		// Void GetShadowTransform(Matrix4x4[], Matrix4x4[], Matrix4x4[] ByRef)
		void HG::Rendering::Runtime::HGShadowManager::GetShadowTransform(
		        Matrix4x4__Array *projs,
		        Matrix4x4__Array *views,
		        Matrix4x4__Array **shadows,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  int32_t v9; // ebx
		  __m128 v10; // xmm6
		  __int128 v11; // xmm8
		  __int128 v12; // xmm9
		  __int128 v13; // xmm10
		  Matrix4x4 *v14; // rax
		  Matrix4x4__Array *v15; // r15
		  Matrix4x4__StaticFields *static_fields; // rdx
		  __int128 v17; // xmm1
		  __int128 v18; // xmm0
		  __int128 v19; // xmm1
		  __int128 v20; // xmm0
		  __int128 v21; // xmm1
		  __int128 v22; // xmm0
		  __int128 v23; // xmm1
		  Matrix4x4 *v24; // rax
		  __int128 v25; // xmm1
		  __int128 v26; // xmm0
		  __int128 v27; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Matrix4x4 v29; // [rsp+38h] [rbp-D0h] BYREF
		  Matrix4x4 v30; // [rsp+78h] [rbp-90h]
		  Matrix4x4 v31; // [rsp+B8h] [rbp-50h] BYREF
		  Matrix4x4 v32; // [rsp+F8h] [rbp-10h]
		  Matrix4x4 v33[2]; // [rsp+138h] [rbp+30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2117, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2117, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_854(Patch, (Object *)projs, (Object *)views, shadows, 0LL);
		      return;
		    }
		LABEL_11:
		    sub_1800D8260(v8, v7);
		  }
		  v9 = 0;
		  if ( !projs )
		    goto LABEL_11;
		  while ( v9 < projs->max_length.size && v9 < 14 )
		  {
		    sub_180031960(projs, &v29, v9);
		    v10 = *(__m128 *)&v29.m00;
		    v11 = *(_OWORD *)&v29.m01;
		    v12 = *(_OWORD *)&v29.m02;
		    v13 = *(_OWORD *)&v29.m03;
		    v30 = v29;
		    if ( !views )
		      goto LABEL_11;
		    sub_180031960(views, &v31, v9);
		    if ( UnityEngine::SystemInfo::UsesReversedZBuffer(0LL) )
		    {
		      v30.m21 = -v30.m21;
		      v11 = *(_OWORD *)&v30.m01;
		      v30.m23 = -v30.m23;
		      v13 = *(_OWORD *)&v30.m03;
		      v30.m20 = -_mm_shuffle_ps(v10, v10, 170).m128_f32[0];
		      v10 = *(__m128 *)&v30.m00;
		      v30.m22 = -v30.m22;
		      v12 = *(_OWORD *)&v30.m02;
		    }
		    v29 = v31;
		    *(__m128 *)&v31.m00 = v10;
		    *(_OWORD *)&v31.m01 = v11;
		    *(_OWORD *)&v31.m02 = v12;
		    *(_OWORD *)&v31.m03 = v13;
		    v14 = UnityEngine::Matrix4x4::op_Multiply(v33, &v31, &v29, 0LL);
		    v15 = *shadows;
		    static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		    v17 = *(_OWORD *)&static_fields->identityMatrix.m01;
		    *(_OWORD *)&v32.m00 = *(_OWORD *)&static_fields->identityMatrix.m00;
		    v18 = *(_OWORD *)&static_fields->identityMatrix.m02;
		    v32.m00 = 0.5;
		    *(_OWORD *)&v32.m01 = v17;
		    v19 = *(_OWORD *)&static_fields->identityMatrix.m03;
		    v32.m11 = 0.5;
		    *(_OWORD *)&v32.m02 = v18;
		    v20 = *(_OWORD *)&v14->m00;
		    v32.m22 = 0.5;
		    *(_OWORD *)&v32.m03 = v19;
		    v21 = *(_OWORD *)&v14->m01;
		    v32.m03 = 0.5;
		    *(_OWORD *)&v29.m00 = v20;
		    v22 = *(_OWORD *)&v14->m02;
		    *(_OWORD *)&v29.m01 = v21;
		    v23 = *(_OWORD *)&v14->m03;
		    *(_QWORD *)&v32.m13 = 0x3F0000003F000000LL;
		    *(_OWORD *)&v29.m02 = v22;
		    *(_OWORD *)&v29.m03 = v23;
		    v31 = v32;
		    v24 = UnityEngine::Matrix4x4::op_Multiply(v33, &v31, &v29, 0LL);
		    if ( !v15 )
		      goto LABEL_11;
		    v25 = *(_OWORD *)&v24->m01;
		    *(_OWORD *)&v29.m00 = *(_OWORD *)&v24->m00;
		    v26 = *(_OWORD *)&v24->m02;
		    *(_OWORD *)&v29.m01 = v25;
		    v27 = *(_OWORD *)&v24->m03;
		    *(_OWORD *)&v29.m02 = v26;
		    *(_OWORD *)&v29.m03 = v27;
		    sub_180041540(v15, v9++, &v29);
		  }
		}
		
		public static void InitShadowManager(HGRenderPipelineRuntimeResources renderPipelineResources) {} // 0x00000001848ADCB0-0x00000001848ADDD0
		// Void InitShadowManager(HGRenderPipelineRuntimeResources)
		void HG::Rendering::Runtime::HGShadowManager::InitShadowManager(
		        HGRenderPipelineRuntimeResources *renderPipelineResources,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  HGRenderPipelineRuntimeResources_ShaderResources *v4; // rcx
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  Shader *shadowClearPS; // rdi
		  Material *StaticMaterial; // rax
		  HGRuntimeGrassQuery_Node *v8; // rdx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  struct HGShadowManager__Class *v11; // rcx
		  Material *v12; // rdi
		  Material *v13; // rax
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v18; // [rsp+20h] [rbp-8h]
		  MethodInfo *v19; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2127, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2127, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)renderPipelineResources,
		        0LL);
		      return;
		    }
		LABEL_3:
		    sub_1800D8260(v4, v3);
		  }
		  if ( !renderPipelineResources )
		    goto LABEL_3;
		  shaders = renderPipelineResources->fields.shaders;
		  if ( !shaders )
		    goto LABEL_3;
		  shadowClearPS = shaders->fields.shadowClearPS;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
		  StaticMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
		                     shadowClearPS,
		                     0,
		                     0LL);
		  v11 = TypeInfo::HG::Rendering::Runtime::HGShadowManager;
		  v12 = StaticMaterial;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGShadowManager->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		    v11 = TypeInfo::HG::Rendering::Runtime::HGShadowManager;
		  }
		  v11->static_fields->s_clearShadowMaterial = v12;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->s_clearShadowMaterial,
		    v8,
		    v9,
		    v10,
		    v18);
		  v4 = renderPipelineResources->fields.shaders;
		  if ( !v4 )
		    goto LABEL_3;
		  v13 = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(v4->fields.shadowBlitPS, 0, 0LL);
		  static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		  static_fields[1].fields.parent = (HGRuntimeGrassQuery_Node *)v13;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->s_blitShadowMaterial,
		    static_fields,
		    v15,
		    v16,
		    v19);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
		  HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::Initialize(renderPipelineResources, 0LL);
		}
		
		public void CalculateFrameParameters(ref ScriptableCullingParameters cullingParameters, HGSettingParameters settingParameters, HGCamera hgCamera) {} // 0x000000018344F790-0x000000018344FA70
		// Void CalculateFrameParameters(ScriptableCullingParameters ByRef, HGSettingParameters, HGCamera)
		void HG::Rendering::Runtime::HGShadowManager::CalculateFrameParameters(
		        HGShadowManager *this,
		        ScriptableCullingParameters *cullingParameters,
		        HGSettingParameters *settingParameters,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
		  ScriptableCullingParameters *v9; // r14
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  bool v11; // zf
		  BitArray128 bitDatas; // xmm6
		  __int64 v13; // xmm0_8
		  bool v14; // al
		  SettingParameter_1_System_Boolean_ *characterShadowEnabled_k__BackingField; // rbx
		  struct MethodInfo *v16; // rsi
		  Il2CppClass *klass; // rax
		  Il2CppClass *v18; // rcx
		  HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
		  HGCharacterVolume *m_hgCharacterVolume; // rbx
		  int32_t v21; // eax
		  struct HGCharacterQualitySettings__Class *v22; // rcx
		  int32_t v23; // ebx
		  bool v24; // al
		  bool v25; // al
		  float m_csmMaxDistance; // xmm6_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v28; // rax
		  __int64 v29; // rax
		  ILFixDynamicMethodWrapper_2 *v30; // rax
		  ILFixDynamicMethodWrapper_2 *v31; // rax
		  FrameSettings P0; // [rsp+30h] [rbp-38h] BYREF
		
		  v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v9 = cullingParameters;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v7->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_41;
		  if ( wrapperArray->max_length.size > 781 )
		  {
		    if ( !v7->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v7);
		      v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    cullingParameters = (ScriptableCullingParameters *)v7->static_fields->wrapperArray;
		    if ( !cullingParameters )
		      goto LABEL_41;
		    if ( LODWORD(cullingParameters->m_LODParameters.m_OrthoSize) <= 0x30D )
		      goto LABEL_70;
		    if ( *(_QWORD *)&cullingParameters[6].m_CameraProperties.cameraToWorld.m31 )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(781, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_311(
		          Patch,
		          (Object *)this,
		          v9,
		          (Object *)settingParameters,
		          (Object *)hgCamera,
		          0LL);
		        return;
		      }
		      goto LABEL_41;
		    }
		  }
		  if ( !hgCamera )
		    goto LABEL_41;
		  v11 = v7->_1.cctor_finished_or_no_cctor == 0;
		  bitDatas = hgCamera->fields._frameSettings_k__BackingField.bitDatas;
		  v13 = *(_QWORD *)&hgCamera->fields._frameSettings_k__BackingField.materialQuality;
		  P0.bitDatas = bitDatas;
		  *(_QWORD *)&P0.materialQuality = v13;
		  if ( v11 )
		  {
		    il2cpp_runtime_class_init_1(v7);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  cullingParameters = (ScriptableCullingParameters *)v7->static_fields->wrapperArray;
		  if ( !cullingParameters )
		    goto LABEL_41;
		  if ( SLODWORD(cullingParameters->m_LODParameters.m_OrthoSize) <= 734 )
		    goto LABEL_10;
		  if ( !v7->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v7);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  cullingParameters = (ScriptableCullingParameters *)v7->static_fields->wrapperArray;
		  if ( !cullingParameters )
		    goto LABEL_41;
		  if ( LODWORD(cullingParameters->m_LODParameters.m_OrthoSize) <= 0x2DE )
		    goto LABEL_70;
		  if ( *(_QWORD *)&cullingParameters[5].m_StereoViewMatrix.m01 )
		  {
		    v28 = IFix::WrappersManagerImpl::GetPatch(734, 0LL);
		    if ( !v28 )
		      goto LABEL_41;
		    v14 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_292(v28, &P0, FrameSettingsField__Enum_ShadowMaps, 0LL);
		  }
		  else
		  {
		LABEL_10:
		    v14 = (bitDatas.data1 & 0x100000) != 0;
		  }
		  this->fields.enableShadowmap = v14;
		  if ( !settingParameters )
		    goto LABEL_41;
		  characterShadowEnabled_k__BackingField = settingParameters->fields._characterShadowEnabled_k__BackingField;
		  v16 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
		  if ( !characterShadowEnabled_k__BackingField )
		    goto LABEL_41;
		  klass = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass;
		  if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit->klass, cullingParameters);
		  if ( !*((_QWORD *)klass->rgctx_data[6].rgctxDataDummy + 4) )
		  {
		    v29 = sub_18011C4C0(v16->klass);
		    (**(void (***)(void))(*(_QWORD *)(v29 + 192) + 48LL))();
		  }
		  v18 = v16->klass;
		  if ( ((__int64)v18->vtable[0].methodPtr & 1) == 0 )
		    sub_1800360B0(v18, cullingParameters);
		  if ( !characterShadowEnabled_k__BackingField->fields._paramValue_k__BackingField )
		    goto LABEL_71;
		  v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  cullingParameters = (ScriptableCullingParameters *)v7->static_fields->wrapperArray;
		  if ( !cullingParameters )
		    goto LABEL_41;
		  if ( SLODWORD(cullingParameters->m_LODParameters.m_OrthoSize) <= 783 )
		    goto LABEL_24;
		  if ( !v7->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v7);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  cullingParameters = (ScriptableCullingParameters *)v7->static_fields->wrapperArray;
		  if ( !cullingParameters )
		    goto LABEL_41;
		  if ( LODWORD(cullingParameters->m_LODParameters.m_OrthoSize) <= 0x30F )
		    goto LABEL_70;
		  if ( *(_QWORD *)&cullingParameters[6].m_CameraProperties.cameraToWorld.m32 )
		  {
		    v30 = IFix::WrappersManagerImpl::GetPatch(783, 0LL);
		    if ( !v30 )
		      goto LABEL_41;
		    m_volumeComponentsData = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_310(v30, (Object *)hgCamera, 0LL);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_24:
		    m_volumeComponentsData = hgCamera->fields.m_volumeComponentsData;
		  }
		  if ( !m_volumeComponentsData )
		    goto LABEL_41;
		  m_hgCharacterVolume = m_volumeComponentsData->fields.m_hgCharacterVolume;
		  if ( !m_hgCharacterVolume )
		    goto LABEL_41;
		  if ( !v7->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v7);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  cullingParameters = (ScriptableCullingParameters *)v7->static_fields->wrapperArray;
		  if ( !cullingParameters )
		    goto LABEL_41;
		  if ( SLODWORD(cullingParameters->m_LODParameters.m_OrthoSize) <= 784 )
		    goto LABEL_31;
		  if ( !v7->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v7);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7->static_fields->wrapperArray;
		  if ( !v7 )
		LABEL_41:
		    sub_1800D8260(v7, cullingParameters);
		  if ( LODWORD(v7->_0.namespaze) <= 0x310 )
		LABEL_70:
		    sub_1800D2AB0(v7, cullingParameters);
		  if ( *(_QWORD *)&v7[16]._1.field_count )
		  {
		    v31 = IFix::WrappersManagerImpl::GetPatch(784, 0LL);
		    if ( v31 )
		    {
		      v24 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		              (ILFixDynamicMethodWrapper_20 *)v31,
		              (Object *)m_hgCharacterVolume,
		              0LL);
		      goto LABEL_35;
		    }
		    goto LABEL_41;
		  }
		LABEL_31:
		  cullingParameters = (ScriptableCullingParameters *)m_hgCharacterVolume->fields.charSelfShadowQualityMode;
		  if ( !cullingParameters )
		    goto LABEL_41;
		  v21 = sub_180002F70(10LL, cullingParameters);
		  v22 = TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings;
		  v23 = v21;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings);
		    v22 = TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings;
		  }
		  v24 = v22->static_fields->characterShadowTierLevel >= v23;
		LABEL_35:
		  if ( v24 )
		  {
		    v25 = 1;
		    goto LABEL_37;
		  }
		LABEL_71:
		  v25 = 0;
		LABEL_37:
		  this->fields.enableCharacterShadowmap = v25;
		  if ( this->fields.enableShadowmap )
		  {
		    m_csmMaxDistance = this->fields.m_csmMaxDistance;
		    if ( !TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
		    v9->m_CameraProperties.cameraWorldToClip.m11 = m_csmMaxDistance;
		    LODWORD(v9->m_CameraProperties.cameraWorldToClip.m31) |= 0x40u;
		  }
		  else
		  {
		    if ( !TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
		    v9->m_CameraProperties.cameraWorldToClip.m11 = 0.0;
		    LODWORD(v9->m_CameraProperties.cameraWorldToClip.m31) &= ~0x40u;
		  }
		}
		
		internal void FrameSetup(ref ShadowMapPassConstructor.PassInput input, out bool shouldRenderCSMShadowMap, HGCamera camera) {
			shouldRenderCSMShadowMap = default;
		} // 0x0000000189D1FB50-0x0000000189D2089C
		// Void FrameSetup(ShadowMapPassConstructor+PassInput ByRef, Boolean ByRef, HGCamera)
		void HG::Rendering::Runtime::HGShadowManager::FrameSetup(
		        HGShadowManager *this,
		        ShadowMapPassConstructor_PassInput *input,
		        bool *shouldRenderCSMShadowMap,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  HGSettingParameters *settingParams; // rdi
		  HGEnvironmentPhase *InterpolatedPhase; // rax
		  __int64 v11; // rdx
		  Single__Array *v12; // rcx
		  __m128 v13; // xmm13
		  __m128i v14; // xmm12
		  __m128i v15; // xmm7
		  __m128 v16; // xmm8
		  __m128 v17; // xmm9
		  __int128 v18; // xmm6
		  int v19; // xmm11_4
		  __int128 v20; // xmm0
		  bool v21; // al
		  float overrideCsmMaxDistanceValue; // xmm0_4
		  HGRenderPipelineSettingHub *instance; // rax
		  HGEnvironmentPhase *v24; // rax
		  float heightFogCullingFarClipPlane; // xmm0_4
		  float m_csmMaxDistance; // xmm6_4
		  Single__Array *m_csmShadowSplits; // r14
		  float v28; // xmm6_4
		  float v29; // xmm0_4
		  Single__Array *v30; // r14
		  float v31; // xmm0_4
		  Single__Array *v32; // r14
		  float v33; // xmm0_4
		  Single__Array *v34; // r14
		  float v35; // xmm0_4
		  Single__Array *m_csmShadowSplitPercentage; // r14
		  float v37; // xmm0_4
		  Single__Array *v38; // r14
		  float v39; // xmm0_4
		  Single__Array *v40; // r14
		  float v41; // xmm0_4
		  Single__Array *v42; // r14
		  float v43; // xmm0_4
		  Int32__Array *m_csmCachedFrames; // r14
		  Int32Enum__Enum v45; // eax
		  Int32__Array *v46; // r14
		  Int32Enum__Enum v47; // eax
		  Int32__Array *v48; // r14
		  Int32Enum__Enum v49; // eax
		  Int32__Array *v50; // r14
		  Int32Enum__Enum v51; // eax
		  Single__Array *m_csmScreenSizeMinSquareds; // r14
		  float v53; // xmm7_4
		  float v54; // xmm0_4
		  Single__Array *v55; // r14
		  float v56; // xmm7_4
		  float v57; // xmm0_4
		  Single__Array *v58; // r14
		  float v59; // xmm7_4
		  float v60; // xmm0_4
		  Single__Array *v61; // r14
		  float v62; // xmm7_4
		  float v63; // xmm0_4
		  Boolean__Array *m_csmEnableOcclusionCulling; // r14
		  bool v65; // zf
		  BOOL enableShadowCulling; // eax
		  Boolean__Array *v67; // r14
		  BOOL v68; // eax
		  Boolean__Array *v69; // r14
		  BOOL v70; // eax
		  Boolean__Array *v71; // r14
		  BOOL v72; // eax
		  __int64 v73; // rcx
		  __int128 v74; // xmm1
		  __int128 v75; // xmm0
		  __int128 v76; // xmm1
		  __int128 v77; // xmm0
		  __int128 v78; // xmm1
		  __int128 v79; // xmm0
		  __int128 v80; // xmm1
		  int v81; // eax
		  int32_t directionalLightIndex; // r9d
		  bool v83; // al
		  float v84; // xmm0_4
		  String *v85; // rax
		  String *v86; // rax
		  int32_t m_csmShadowMapTileSize; // eax
		  int32_t v88; // eax
		  bool v89; // al
		  Object_1 *blackTexture; // rdi
		  HGRuntimeGrassQuery_Node *v91; // rdx
		  HGRuntimeGrassQuery_Node *v92; // r8
		  Int32__Array **v93; // r9
		  float w; // xmm7_4
		  float v95; // xmm8_4
		  unsigned int i; // edi
		  __m128i v97; // xmm1
		  HGShadowConstantBufferUtils__StaticFields *static_fields; // rcx
		  HGShadowConstantBufferUtils__StaticFields *v99; // rcx
		  float m_simulatedShadowAttenuationInVolume; // xmm1_4
		  TileBase *v101; // rdx
		  Vector3Int *v102; // r8
		  ITilemap *v103; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *P3; // [rsp+28h] [rbp-E0h]
		  MethodInfo *P3a; // [rsp+28h] [rbp-E0h]
		  CullingResults v107[6]; // [rsp+38h] [rbp-D0h] BYREF
		  _OWORD v108[12]; // [rsp+98h] [rbp-70h] BYREF
		  int v109; // [rsp+158h] [rbp+50h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2129, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2129, 0LL);
		    if ( !Patch )
		      goto LABEL_114;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_860(
		      Patch,
		      (Object *)this,
		      input,
		      shouldRenderCSMShadowMap,
		      (Object *)camera,
		      0LL);
		    return;
		  }
		  settingParams = input->settingParams;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(camera, 0LL);
		  if ( !InterpolatedPhase )
		    goto LABEL_114;
		  v13 = *(__m128 *)&InterpolatedPhase->fields.shadowConfig.csmDepthBias;
		  v14 = *(__m128i *)&InterpolatedPhase->fields.shadowConfig.csmIntensity;
		  v15 = *(__m128i *)&InterpolatedPhase->fields.shadowConfig.contactShadowSurfaceThickness;
		  v16 = *(__m128 *)&InterpolatedPhase->fields.shadowConfig.overrideCsmFarDistance;
		  v17 = *(__m128 *)&InterpolatedPhase->fields.shadowConfig.overrideCsmSpherePosition.z;
		  v18 = *(_OWORD *)&InterpolatedPhase->fields.shadowConfig.csmSimulatedAttenuation;
		  v19 = 1065353216;
		  v107[3] = *(CullingResults *)&InterpolatedPhase->fields.shadowConfig.csmShadowSoftness;
		  v20 = *(_OWORD *)&InterpolatedPhase->fields.shadowConfig.rhodesShipCenter.z;
		  v107[1] = (CullingResults)v13;
		  v108[2] = v20;
		  v107[2] = (CullingResults)v14;
		  v107[4] = (CullingResults)v15;
		  v107[5] = (CullingResults)v16;
		  v108[0] = v17;
		  v108[1] = v18;
		  v21 = System::Single::Equals((Single *)v108 + 3, 1.0, 0LL);
		  LODWORD(this->fields.m_simulatedShadowAttenuationInVolume) = v18;
		  this->fields.m_enableCSMInVolume = !v21;
		  LODWORD(this->fields.m_simulatedShadowBlendValue) = _mm_shuffle_ps(v17, v17, 255).m128_u32[0];
		  v12 = (Single__Array *)((unsigned __int8)_mm_cvtsi128_si32(_mm_srli_si128((__m128i)v16, 4)) != 0);
		  this->fields.m_csmRenderMode = (int)v12;
		  if ( !settingParams )
		    goto LABEL_114;
		  this->fields.m_csmNearPlaneOffset = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                        settingParams->fields._csmNearPlaneOffset_k__BackingField,
		                                        MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  this->fields.m_csmMaxDistance = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                    settingParams->fields._csmMaxDistance_k__BackingField,
		                                    MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  if ( (unsigned __int8)_mm_cvtsi128_si32(_mm_srli_si128(v15, 13)) )
		    LODWORD(this->fields.m_csmMaxDistance) = v16.m128_i32[0];
		  if ( !camera )
		    goto LABEL_114;
		  if ( camera->fields.overrideCsmShadowDistance )
		  {
		    overrideCsmMaxDistanceValue = camera->fields.overrideCsmMaxDistanceValue;
		    if ( overrideCsmMaxDistanceValue <= 0.0099999998 )
		      overrideCsmMaxDistanceValue = 0.0099999998;
		    this->fields.m_csmMaxDistance = overrideCsmMaxDistanceValue;
		  }
		  instance = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
		  if ( !instance )
		    goto LABEL_114;
		  if ( HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_currentDeviceType(instance, 0LL) == HGDeviceType__Enum_Handheld )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    v24 = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(camera, 0LL);
		    if ( !v24 )
		      goto LABEL_114;
		    heightFogCullingFarClipPlane = v24->fields.heightFogConfig.heightFogCullingFarClipPlane;
		  }
		  else
		  {
		    heightFogCullingFarClipPlane = 3.4028235e38;
		  }
		  m_csmMaxDistance = this->fields.m_csmMaxDistance;
		  if ( heightFogCullingFarClipPlane <= m_csmMaxDistance )
		    m_csmMaxDistance = heightFogCullingFarClipPlane;
		  m_csmShadowSplits = this->fields.m_csmShadowSplits;
		  this->fields.m_csmMaxDistance = m_csmMaxDistance;
		  v28 = m_csmMaxDistance * 0.80000001;
		  v29 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParams->fields._csmSplit0_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  if ( !m_csmShadowSplits )
		LABEL_114:
		    sub_1800D8260(v12, v11);
		  if ( !m_csmShadowSplits->max_length.size )
		    goto LABEL_112;
		  m_csmShadowSplits->vector[0] = this->fields.m_csmMaxDistance * v29;
		  v30 = this->fields.m_csmShadowSplits;
		  v31 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParams->fields._csmSplit1_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  if ( !v30 )
		    goto LABEL_114;
		  if ( v30->max_length.size <= 1u )
		    goto LABEL_112;
		  v30->vector[1] = this->fields.m_csmMaxDistance * v31;
		  v32 = this->fields.m_csmShadowSplits;
		  v33 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParams->fields._csmSplit2_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  if ( !v32 )
		    goto LABEL_114;
		  if ( v32->max_length.size <= 2u )
		    goto LABEL_112;
		  v32->vector[2] = this->fields.m_csmMaxDistance * v33;
		  v34 = this->fields.m_csmShadowSplits;
		  v35 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParams->fields._csmSplit3_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  if ( !v34 )
		    goto LABEL_114;
		  if ( v34->max_length.size <= 3u )
		    goto LABEL_112;
		  v34->vector[3] = this->fields.m_csmMaxDistance * v35;
		  m_csmShadowSplitPercentage = this->fields.m_csmShadowSplitPercentage;
		  v37 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParams->fields._csmSplit0_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  if ( !m_csmShadowSplitPercentage )
		    goto LABEL_114;
		  if ( !m_csmShadowSplitPercentage->max_length.size )
		    goto LABEL_112;
		  m_csmShadowSplitPercentage->vector[0] = v37;
		  v38 = this->fields.m_csmShadowSplitPercentage;
		  v39 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParams->fields._csmSplit1_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  if ( !v38 )
		    goto LABEL_114;
		  if ( v38->max_length.size <= 1u )
		    goto LABEL_112;
		  v38->vector[1] = v39;
		  v40 = this->fields.m_csmShadowSplitPercentage;
		  v41 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParams->fields._csmSplit2_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  if ( !v40 )
		    goto LABEL_114;
		  if ( v40->max_length.size <= 2u )
		    goto LABEL_112;
		  v40->vector[2] = v41;
		  v42 = this->fields.m_csmShadowSplitPercentage;
		  v43 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParams->fields._csmSplit3_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  if ( !v42 )
		    goto LABEL_114;
		  if ( v42->max_length.size <= 3u )
		    goto LABEL_112;
		  v42->vector[3] = v43;
		  m_csmCachedFrames = this->fields.m_csmCachedFrames;
		  v45 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		          (SettingParameter_1_System_Int32Enum_ *)settingParams->fields._csmCachedFrame0_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  if ( !m_csmCachedFrames )
		    goto LABEL_114;
		  if ( !m_csmCachedFrames->max_length.size )
		    goto LABEL_112;
		  m_csmCachedFrames->vector[0] = v45;
		  v46 = this->fields.m_csmCachedFrames;
		  v47 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		          (SettingParameter_1_System_Int32Enum_ *)settingParams->fields._csmCachedFrame1_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  if ( !v46 )
		    goto LABEL_114;
		  if ( v46->max_length.size <= 1u )
		    goto LABEL_112;
		  v46->vector[1] = v47;
		  v48 = this->fields.m_csmCachedFrames;
		  v49 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		          (SettingParameter_1_System_Int32Enum_ *)settingParams->fields._csmCachedFrame2_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  if ( !v48 )
		    goto LABEL_114;
		  if ( v48->max_length.size <= 2u )
		    goto LABEL_112;
		  v48->vector[2] = v49;
		  v50 = this->fields.m_csmCachedFrames;
		  v51 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		          (SettingParameter_1_System_Int32Enum_ *)settingParams->fields._csmCachedFrame3_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  if ( !v50 )
		    goto LABEL_114;
		  if ( v50->max_length.size <= 3u )
		    goto LABEL_112;
		  v50->vector[3] = v51;
		  m_csmScreenSizeMinSquareds = this->fields.m_csmScreenSizeMinSquareds;
		  v53 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParams->fields._csmScreenSizeMin0_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  v54 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParams->fields._csmScreenSizeMin0_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  if ( !m_csmScreenSizeMinSquareds )
		    goto LABEL_114;
		  if ( !m_csmScreenSizeMinSquareds->max_length.size )
		    goto LABEL_112;
		  m_csmScreenSizeMinSquareds->vector[0] = v54 * v53;
		  v55 = this->fields.m_csmScreenSizeMinSquareds;
		  v56 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParams->fields._csmScreenSizeMin1_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  v57 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParams->fields._csmScreenSizeMin1_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  if ( !v55 )
		    goto LABEL_114;
		  if ( v55->max_length.size <= 1u )
		    goto LABEL_112;
		  v55->vector[1] = v57 * v56;
		  v58 = this->fields.m_csmScreenSizeMinSquareds;
		  v59 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParams->fields._csmScreenSizeMin2_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  v60 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParams->fields._csmScreenSizeMin2_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  if ( !v58 )
		    goto LABEL_114;
		  if ( v58->max_length.size <= 2u )
		    goto LABEL_112;
		  v58->vector[2] = v60 * v59;
		  v61 = this->fields.m_csmScreenSizeMinSquareds;
		  v62 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParams->fields._csmScreenSizeMin3_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  v63 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          settingParams->fields._csmScreenSizeMin3_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		  if ( !v61 )
		    goto LABEL_114;
		  if ( v61->max_length.size <= 3u )
		    goto LABEL_112;
		  v61->vector[3] = v63 * v62;
		  m_csmEnableOcclusionCulling = this->fields.m_csmEnableOcclusionCulling;
		  v65 = !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		           settingParams->fields._csmEnableOcclusionCulling0_k__BackingField,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		  enableShadowCulling = 1;
		  if ( v65 )
		    enableShadowCulling = camera->fields.enableShadowCulling;
		  if ( !m_csmEnableOcclusionCulling )
		    goto LABEL_114;
		  if ( !m_csmEnableOcclusionCulling->max_length.size )
		    goto LABEL_112;
		  m_csmEnableOcclusionCulling->vector[0] = enableShadowCulling;
		  v67 = this->fields.m_csmEnableOcclusionCulling;
		  v65 = !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		           settingParams->fields._csmEnableOcclusionCulling1_k__BackingField,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		  v68 = 1;
		  if ( v65 )
		    v68 = camera->fields.enableShadowCulling;
		  if ( !v67 )
		    goto LABEL_114;
		  if ( v67->max_length.size <= 1u )
		    goto LABEL_112;
		  v67->vector[1] = v68;
		  v69 = this->fields.m_csmEnableOcclusionCulling;
		  v65 = !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		           settingParams->fields._csmEnableOcclusionCulling2_k__BackingField,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		  v70 = 1;
		  if ( v65 )
		    v70 = camera->fields.enableShadowCulling;
		  if ( !v69 )
		    goto LABEL_114;
		  if ( v69->max_length.size <= 2u )
		    goto LABEL_112;
		  v69->vector[2] = v70;
		  v71 = this->fields.m_csmEnableOcclusionCulling;
		  v65 = !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		           settingParams->fields._csmEnableOcclusionCulling3_k__BackingField,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		  v72 = 1;
		  if ( v65 )
		    v72 = camera->fields.enableShadowCulling;
		  if ( !v71 )
		    goto LABEL_114;
		  if ( v71->max_length.size <= 3u )
		    goto LABEL_112;
		  v71->vector[3] = v72;
		  this->fields.m_csmOcclusionDepthSize = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                                           (SettingParameter_1_System_Int32Enum_ *)settingParams->fields._csmOcclusionDepthSize_k__BackingField,
		                                           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  this->fields.m_stopRenderCharacterCascade = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                                                (SettingParameter_1_System_Int32Enum_ *)settingParams->fields._csmStopRenderCharacterCascade_k__BackingField,
		                                                MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		  Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::ConvertExistingDataToNativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>(
		    (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)v107,
		    (Void *)input->lightCullResult.visibleLightsPtr,
		    input->lightCullResult.visibleLightCount,
		    Allocator__Enum_None,
		    MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::ConvertExistingDataToNativeArray<UnityEngine::Rendering::VisibleLight>);
		  LODWORD(this->fields.m_shadowIntensity) = v14.m128i_i32[0];
		  if ( input->directionalLightIndex == -1 )
		  {
		    this->fields.m_hasDirectionLight = 0;
		  }
		  else
		  {
		    this->fields.m_hasDirectionLight = 1;
		    v73 = 148LL * input->directionalLightIndex;
		    v74 = *(_OWORD *)((char *)v107[0].ptr + v73 + 16);
		    v108[3] = *(_OWORD *)((char *)v107[0].ptr + v73);
		    v75 = *(_OWORD *)((char *)v107[0].ptr + v73 + 32);
		    v108[4] = v74;
		    v76 = *(_OWORD *)((char *)v107[0].ptr + v73 + 48);
		    v108[5] = v75;
		    v77 = *(_OWORD *)((char *)v107[0].ptr + v73 + 64);
		    v108[6] = v76;
		    v78 = *(_OWORD *)((char *)v107[0].ptr + v73 + 80);
		    v108[7] = v77;
		    v79 = *(_OWORD *)((char *)v107[0].ptr + v73 + 96);
		    v108[8] = v78;
		    v80 = *(_OWORD *)((char *)v107[0].ptr + v73 + 128);
		    v108[9] = v79;
		    v81 = *(_DWORD *)((char *)v107[0].ptr + v73 + 144);
		    v108[10] = *(_OWORD *)((char *)v107[0].ptr + v73 + 112);
		    v108[11] = v80;
		    v109 = v81;
		    this->fields.m_directionalLight = (HGSharedLightData)*((_QWORD *)&v80 + 1);
		  }
		  directionalLightIndex = input->directionalLightIndex;
		  v107[0] = input->cullingResults;
		  v83 = HG::Rendering::Runtime::HGShadowManager::ShouldRenderCSMShadowMap(
		          this,
		          camera,
		          v107,
		          directionalLightIndex,
		          settingParams,
		          0LL);
		  *shouldRenderCSMShadowMap = v83;
		  if ( v83 )
		  {
		    this->fields.m_csmCascadeCount = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                                       (SettingParameter_1_System_Int32Enum_ *)settingParams->fields._csmSplitCount_k__BackingField,
		                                       MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    LODWORD(this->fields.m_csmDepthBias) = _mm_shuffle_ps(v13, v13, 170).m128_u32[0];
		    LODWORD(this->fields.m_csmNormalBias) = _mm_shuffle_ps(v13, v13, 255).m128_u32[0];
		    this->fields.m_csmHardwareDepthBias = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                            settingParams->fields._csmHardwareBias_k__BackingField,
		                                            MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		    this->fields.m_csmHardwareNormalBias = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                             settingParams->fields._csmHardwareNormalBias_k__BackingField,
		                                             MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		    this->fields.m_csmShadowSampleMode = 4;
		    this->fields.m_csmShadowMapTileSize = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                                            (SettingParameter_1_System_Int32Enum_ *)settingParams->fields._csmShadowMapTileResolution_k__BackingField,
		                                            MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    if ( this->fields.m_csmRenderMode != 1 )
		      goto LABEL_81;
		    v12 = this->fields.m_csmShadowSplits;
		    LODWORD(v107[0].ptr) = _mm_shuffle_ps(v16, v16, 170).m128_u32[0];
		    LODWORD(v107[0].m_AllocationInfo) = v17.m128_i32[0];
		    HIDWORD(v107[0].ptr) = _mm_shuffle_ps(v16, v16, 255).m128_u32[0];
		    HIDWORD(v107[0].m_AllocationInfo) = _mm_shuffle_ps(v17, v17, 85).m128_u32[0];
		    this->fields.m_csmCascadeCount = 2;
		    this->fields.m_enableCSMInVolume = 1;
		    *(_QWORD *)&this->fields.m_simulatedShadowAttenuationInVolume = 0LL;
		    this->fields.m_csmManualOverrideSphere = (Vector4)v107[0];
		    v84 = this->fields.m_csmManualOverrideSphere.w + this->fields.m_csmManualOverrideSphere.w;
		    if ( !v12 )
		      goto LABEL_114;
		    if ( v12->max_length.size > 1u )
		    {
		      v12->vector[1] = v84;
		      if ( v12->max_length.size )
		      {
		        v12->vector[0] = v84;
		        v12 = this->fields.m_csmShadowSplitPercentage;
		        if ( !v12 )
		          goto LABEL_114;
		        if ( v12->max_length.size > 1u )
		        {
		          v11 = 1065353216LL;
		          v12->vector[1] = 1.0;
		          if ( v12->max_length.size )
		          {
		            v12->vector[0] = 1.0;
		            v12 = this->fields.m_csmScreenSizeMinSquareds;
		            if ( !v12 )
		              goto LABEL_114;
		            if ( v12->max_length.size >= 2u )
		            {
		              v28 = 990.0;
		              v12->vector[1] = v12->vector[0];
		              this->fields.m_stopRenderCharacterCascade = 1;
		              this->fields.m_csmMaxDistance = 1000.0;
		LABEL_81:
		              if ( this->fields.m_csmCascadeCount != 1 )
		              {
		                if ( this->fields.m_csmCascadeCount == 2 )
		                {
		                  m_csmShadowMapTileSize = 2 * this->fields.m_csmShadowMapTileSize;
		                  goto LABEL_86;
		                }
		                if ( (unsigned int)(this->fields.m_csmCascadeCount - 3) < 2 )
		                {
		                  LODWORD(v107[0].ptr) = 2 * this->fields.m_csmShadowMapTileSize;
		                  v88 = 2 * this->fields.m_csmShadowMapTileSize;
		                  goto LABEL_87;
		                }
		                v85 = System::Int32::ToString((Int32 *)&this->fields.m_csmCascadeCount, 0LL);
		                v86 = System::String::Concat((String *)"Unsupported CSM cascade count: ", v85, 0LL);
		                HG::Rendering::HGRPLogger::LogError(v86, 0LL);
		              }
		              m_csmShadowMapTileSize = this->fields.m_csmShadowMapTileSize;
		LABEL_86:
		              LODWORD(v107[0].ptr) = m_csmShadowMapTileSize;
		              v88 = this->fields.m_csmShadowMapTileSize;
		LABEL_87:
		              HIDWORD(v107[0].ptr) = v88;
		              this->fields.m_csmShadowMapSize = (Vector2Int)v107[0].ptr;
		              v89 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                      settingParams->fields._csmUseShadowmapCache_k__BackingField,
		                      MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit)
		                 && this->fields.m_csmRenderMode == 0;
		              this->fields.m_useShadowMapCache = v89;
		              goto LABEL_93;
		            }
		          }
		        }
		      }
		    }
		LABEL_112:
		    sub_1800D2AB0(v12, v11);
		  }
		  this->fields.m_csmCascadeCount = 0;
		LABEL_93:
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  blackTexture = (Object_1 *)_mm_srli_si128(v14, 8).m128i_u64[0];
		  if ( UnityEngine::Object::op_Equality(blackTexture, 0LL, 0LL) )
		    blackTexture = (Object_1 *)UnityEngine::Texture2D::get_blackTexture(0LL);
		  this->fields.m_csmShadowRamp = (Texture2D *)blackTexture;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_csmShadowRamp, v91, v92, v93, P3);
		  w = this->fields.m_csmMaxDistance;
		  if ( v28 >= 0.1 )
		  {
		    if ( v28 > w )
		      v28 = this->fields.m_csmMaxDistance;
		  }
		  else
		  {
		    v28 = 0.1;
		  }
		  if ( this->fields.m_csmRenderMode == 1 )
		  {
		    w = this->fields.m_csmManualOverrideSphere.w;
		    v28 = w * 0.89999998;
		  }
		  v95 = (float)(w * w) - (float)(v28 * v28);
		  if ( v95 <= 0.0099999998 )
		    v95 = 0.0099999998;
		  for ( i = 0;
		        (signed int)i < this->fields.m_csmCascadeCount;
		        sub_18323BA00(
		          &TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[1].shadowData._PunctualLightShadowTexelSize.z,
		          i++) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		    v12 = this->fields.m_csmShadowSplits;
		    if ( !v12 )
		      goto LABEL_114;
		    if ( i >= v12->max_length.size )
		      goto LABEL_112;
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		  v97 = _mm_cvtsi32_si128(this->fields.m_stopRenderCharacterCascade);
		  *(float *)&v107[0].ptr = this->fields.m_shadowIntensity;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields;
		  *(float *)&v107[0].m_AllocationInfo = 1.0 / v95;
		  HIDWORD(v107[0].ptr) = _mm_cvtepi32_ps(v97).m128_u32[0];
		  *((float *)&v107[0].m_AllocationInfo + 1) = w * w;
		  *(CullingResults *)&static_fields[1].shadowData._CharacterShadowBiases.FixedElementField = v107[0];
		  v99 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields;
		  if ( *shouldRenderCSMShadowMap )
		  {
		    if ( this->fields.m_csmRenderMode )
		      v19 = 0x40000000;
		  }
		  else
		  {
		    v19 = 0;
		  }
		  m_simulatedShadowAttenuationInVolume = this->fields.m_simulatedShadowAttenuationInVolume;
		  v107[0].ptr = (void *)__PAIR64__((float)this->fields.m_csmCascadeCount, v19);
		  HIDWORD(v107[0].m_AllocationInfo) = LODWORD(this->fields.m_simulatedShadowBlendValue);
		  *(float *)&v107[0].m_AllocationInfo = m_simulatedShadowAttenuationInVolume;
		  *(CullingResults *)&v99[1].shadowData._CharacterShadowTexelSize.y = v107[0];
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		  *(__m128i *)&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[1].shadowData._CharacterShadowParams.y = _mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef((TileAnimationData *)v107, v101, v102, v103, P3a));
		  UnityEngine::HyperGryph::HGRendererSystem::set_CSMStopRenderCharacterCascadeLevel(
		    this->fields.m_stopRenderCharacterCascade,
		    0LL);
		}
		
		internal void ConfigureDirectionalShadowMapTextures(HGSettingParameters settingParams, HGCamera hgCamera, bool shouldRenderCSMShadowMap) {} // 0x0000000189D1F5CC-0x0000000189D1F9C0
		// Void ConfigureDirectionalShadowMapTextures(HGSettingParameters, HGCamera, Boolean)
		void HG::Rendering::Runtime::HGShadowManager::ConfigureDirectionalShadowMapTextures(
		        HGShadowManager *this,
		        HGSettingParameters *settingParams,
		        HGCamera *hgCamera,
		        bool shouldRenderCSMShadowMap,
		        MethodInfo *method)
		{
		  Object *v6; // rdi
		  RenderTexture *m_RT; // rdx
		  Boolean__Array *m_updateCSMShadowMap; // rcx
		  Int32Enum__Enum v11; // ebx
		  bool v12; // zf
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  Color clearColor; // xmm1
		  HGRuntimeGrassQuery_Node *v16; // rdx
		  HGRuntimeGrassQuery_Node *v17; // r8
		  Int32__Array **v18; // r9
		  __int128 v19; // xmm1
		  __int128 v20; // xmm0
		  Color v21; // xmm1
		  HGRuntimeGrassQuery_Node *v22; // rdx
		  HGRuntimeGrassQuery_Node *v23; // r8
		  Int32__Array **v24; // r9
		  int32_t width; // ebx
		  RTHandle *m_csmShadowMapAtlas; // rax
		  int32_t height; // ebx
		  int32_t v28; // ebx
		  int32_t renderedFrameCount; // eax
		  Int32__Array *m_csmCachedFrames; // r8
		  Boolean__Array *v31; // r8
		  __int64 v32; // rax
		  int32_t v33; // r15d
		  int32_t v34; // r14d
		  unsigned int depthBufferBits; // esi
		  unsigned int filterMode; // edi
		  unsigned int wrapMode; // ebx
		  HGRuntimeGrassQuery_Node *v38; // rdx
		  HGRuntimeGrassQuery_Node *v39; // r8
		  Int32__Array **v40; // r9
		  HGRuntimeGrassQuery_Node *v41; // rdx
		  HGRuntimeGrassQuery_Node *v42; // r8
		  Int32__Array **v43; // r9
		  int v44; // r9d
		  __int64 v45; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *colorFormat; // [rsp+28h] [rbp-B1h]
		  MethodInfo *colorFormata; // [rsp+28h] [rbp-B1h]
		  MethodInfo *colorFormatb; // [rsp+28h] [rbp-B1h]
		  TextureDesc v50; // [rsp+A8h] [rbp-31h] BYREF
		
		  v6 = (Object *)hgCamera;
		  sub_18033B9D0(&v50, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(2157, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2157, 0LL);
		    if ( !Patch )
		      goto LABEL_29;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_117(
		      (ILFixDynamicMethodWrapper_13 *)Patch,
		      (Object *)this,
		      (Object *)settingParams,
		      v6,
		      shouldRenderCSMShadowMap,
		      0LL);
		    return;
		  }
		  if ( !settingParams )
		    goto LABEL_29;
		  v11 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		          (SettingParameter_1_System_Int32Enum_ *)settingParams->fields._shadowDepthBits_k__BackingField,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Rendering::DepthBits>::op_Implicit);
		  if ( !shouldRenderCSMShadowMap )
		  {
		    HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v50, 1, 1, 0LL);
		    v12 = !this->fields.m_useShadowMapCache;
		    v50.depthBufferBits = v11;
		    v50.clearBuffer = v12;
		    *(_OWORD *)&this->fields.m_csmShadowMapTextureDesc.width = *(_OWORD *)&v50.width;
		    v50.filterMode = 1;
		    v50.wrapMode = 1;
		    *(_OWORD *)&this->fields.m_csmShadowMapTextureDesc.colorFormat = *(_OWORD *)&v50.colorFormat;
		    v50.isShadowMap = 1;
		    v13 = *(_OWORD *)&v50.bindTextureMS;
		    *(_OWORD *)&this->fields.m_csmShadowMapTextureDesc.enableRandomWrite = *(_OWORD *)&v50.enableRandomWrite;
		    v14 = *(_OWORD *)&v50.fastMemoryDesc.inFastMemory;
		    *(_OWORD *)&this->fields.m_csmShadowMapTextureDesc.bindTextureMS = v13;
		    clearColor = v50.clearColor;
		    *(_OWORD *)&this->fields.m_csmShadowMapTextureDesc.fastMemoryDesc.inFastMemory = v14;
		    this->fields.m_csmShadowMapTextureDesc.clearColor = clearColor;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_csmShadowMapTextureDesc.name, v16, v17, v18, colorFormat);
		    return;
		  }
		  HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		    &v50,
		    this->fields.m_csmShadowMapSize.m_X,
		    this->fields.m_csmShadowMapSize.m_Y,
		    0LL);
		  v12 = !this->fields.m_useShadowMapCache;
		  v50.depthBufferBits = v11;
		  v50.clearBuffer = v12;
		  *(_OWORD *)&this->fields.m_csmShadowMapTextureDesc.width = *(_OWORD *)&v50.width;
		  v50.filterMode = 1;
		  v50.wrapMode = 1;
		  *(_OWORD *)&this->fields.m_csmShadowMapTextureDesc.colorFormat = *(_OWORD *)&v50.colorFormat;
		  v50.isShadowMap = 1;
		  v19 = *(_OWORD *)&v50.bindTextureMS;
		  *(_OWORD *)&this->fields.m_csmShadowMapTextureDesc.enableRandomWrite = *(_OWORD *)&v50.enableRandomWrite;
		  v20 = *(_OWORD *)&v50.fastMemoryDesc.inFastMemory;
		  *(_OWORD *)&this->fields.m_csmShadowMapTextureDesc.bindTextureMS = v19;
		  v21 = v50.clearColor;
		  *(_OWORD *)&this->fields.m_csmShadowMapTextureDesc.fastMemoryDesc.inFastMemory = v20;
		  this->fields.m_csmShadowMapTextureDesc.clearColor = v21;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_csmShadowMapTextureDesc.name, v22, v23, v24, colorFormat);
		  if ( !this->fields.m_csmShadowMapAtlas )
		    goto LABEL_21;
		  m_RT = this->fields.m_csmShadowMapAtlas->fields.m_RT;
		  if ( !m_RT )
		    goto LABEL_29;
		  width = this->fields.m_csmShadowMapTextureDesc.width;
		  if ( width != (unsigned int)sub_180002F70(5LL, m_RT) )
		    goto LABEL_33;
		  m_csmShadowMapAtlas = this->fields.m_csmShadowMapAtlas;
		  if ( !m_csmShadowMapAtlas )
		    goto LABEL_29;
		  m_RT = m_csmShadowMapAtlas->fields.m_RT;
		  if ( !m_RT )
		    goto LABEL_29;
		  height = this->fields.m_csmShadowMapTextureDesc.height;
		  if ( height != (unsigned int)sub_180002F70(7LL, m_RT) )
		  {
		LABEL_33:
		    if ( this->fields.m_csmShadowMapAtlas )
		      UnityEngine::Rendering::RTHandle::Release(this->fields.m_csmShadowMapAtlas, 0LL);
		LABEL_21:
		    v33 = this->fields.m_csmShadowMapTextureDesc.width;
		    v34 = this->fields.m_csmShadowMapTextureDesc.height;
		    depthBufferBits = this->fields.m_csmShadowMapTextureDesc.depthBufferBits;
		    filterMode = this->fields.m_csmShadowMapTextureDesc.filterMode;
		    wrapMode = this->fields.m_csmShadowMapTextureDesc.wrapMode;
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::RTHandles);
		    this->fields.m_csmShadowMapAtlas = UnityEngine::Rendering::RTHandles::Alloc(
		                                         v33,
		                                         v34,
		                                         1,
		                                         (DepthBits__Enum)depthBufferBits,
		                                         GraphicsFormat__Enum_R8G8B8A8_SRGB,
		                                         (FilterMode__Enum)filterMode,
		                                         (TextureWrapMode__Enum)wrapMode,
		                                         TextureDimension__Enum_Tex2D,
		                                         0,
		                                         0,
		                                         1,
		                                         1,
		                                         1,
		                                         0.0,
		                                         MSAASamples__Enum_None,
		                                         0,
		                                         RenderTextureMemoryless__Enum_None,
		                                         (String *)"Cached Cascaded Shadowmap",
		                                         0LL);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_csmShadowMapAtlas, v38, v39, v40, colorFormatb);
		    v6 = (Object *)hgCamera;
		LABEL_22:
		    UnityEngine::HyperGryph::HGRendererSystem::set_CSMStopRenderCharacterCascadeLevel(
		      this->fields.m_stopRenderCharacterCascade,
		      0LL);
		    this->fields.m_cachedRenderedCamera = (HGCamera *)v6;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_cachedRenderedCamera, v41, v42, v43, colorFormata);
		    v44 = 0;
		    while ( 1 )
		    {
		      m_updateCSMShadowMap = this->fields.m_updateCSMShadowMap;
		      if ( !m_updateCSMShadowMap )
		        break;
		      if ( (unsigned int)v44 >= m_updateCSMShadowMap->max_length.size )
		LABEL_27:
		        sub_1800D2AB0(m_updateCSMShadowMap, m_RT);
		      v45 = v44++;
		      m_updateCSMShadowMap->vector[v45] = 1;
		      if ( v44 >= 4 )
		        return;
		    }
		LABEL_29:
		    sub_1800D8260(m_updateCSMShadowMap, m_RT);
		  }
		  if ( (Object *)this->fields.m_cachedRenderedCamera != v6 )
		    goto LABEL_22;
		  v28 = 0;
		  if ( this->fields.m_csmCascadeCount > 0 )
		  {
		    while ( 1 )
		    {
		      renderedFrameCount = UnityEngine::Time::get_renderedFrameCount(0LL);
		      m_csmCachedFrames = this->fields.m_csmCachedFrames;
		      if ( !m_csmCachedFrames )
		        goto LABEL_29;
		      if ( (unsigned int)v28 >= m_csmCachedFrames->max_length.size )
		        goto LABEL_27;
		      m_updateCSMShadowMap = (Boolean__Array *)v28;
		      m_RT = (RenderTexture *)(unsigned int)(renderedFrameCount >> 31);
		      LODWORD(m_RT) = renderedFrameCount % m_csmCachedFrames->vector[v28];
		      v31 = this->fields.m_updateCSMShadowMap;
		      if ( !v31 )
		        goto LABEL_29;
		      if ( (unsigned int)v28 >= v31->max_length.size )
		        goto LABEL_27;
		      v32 = v28++;
		      v31->vector[v32] = (_DWORD)m_RT == 0;
		      if ( v28 >= this->fields.m_csmCascadeCount )
		        return;
		    }
		  }
		}
		
		public void Cleanup() {} // 0x00000001849D3690-0x00000001849D36F0
		// Void Cleanup()
		void HG::Rendering::Runtime::HGShadowManager::Cleanup(HGShadowManager *this, MethodInfo *method)
		{
		  RTHandle *m_csmShadowMapAtlas; // rcx
		  HGPunctualLightShadowManagerV2 *m_punctualLightShadowManagerV2; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(547, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(547, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_csmShadowMapAtlas = this->fields.m_csmShadowMapAtlas;
		    if ( m_csmShadowMapAtlas )
		      UnityEngine::Rendering::RTHandle::Release(m_csmShadowMapAtlas, 0LL);
		    HG::Rendering::Runtime::HGShadowManager::CharacterShadowCleanup(this, 0LL);
		    m_punctualLightShadowManagerV2 = this->fields.m_punctualLightShadowManagerV2;
		    if ( m_punctualLightShadowManagerV2 )
		      HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::Release(m_punctualLightShadowManagerV2, 0LL);
		  }
		}
		
		internal static ShadowResult ReadShadowResult([IsReadOnly] in ShadowResult shadowResult, HGRenderGraphBuilder builder) => default; // 0x0000000189D227B0-0x0000000189D22978
		// ShadowResult ReadShadowResult(ShadowResult ByRef, HGRenderGraphBuilder)
		ShadowResult *HG::Rendering::Runtime::HGShadowManager::ReadShadowResult(
		        ShadowResult *__return_ptr retstr,
		        ShadowResult *shadowResult,
		        HGRenderGraphBuilder *builder,
		        MethodInfo *method)
		{
		  __int128 v7; // xmm6
		  int32_t v8; // r14d
		  __int128 v9; // xmm0
		  __int128 v10; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  __int128 v14; // xmm1
		  ShadowResult *v15; // rax
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  HGRenderGraphBuilder v19; // [rsp+38h] [rbp-19h] BYREF
		  ShadowResult v20; // [rsp+58h] [rbp+7h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2158, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2158, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    v14 = *(_OWORD *)&builder->m_RenderGraph;
		    *(_OWORD *)&v19.m_RenderPass = *(_OWORD *)&builder->m_RenderPass;
		    *(_OWORD *)&v19.m_RenderGraph = v14;
		    v15 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_861(&v20, Patch, shadowResult, &v19, 0LL);
		    v16 = *(_OWORD *)&v15->directionalShadowResult.fallBackResource._type_k__BackingField;
		    *(_OWORD *)&retstr->directionalShadowActive = *(_OWORD *)&v15->directionalShadowActive;
		    v17 = *(_OWORD *)&v15->characterShadowResult.fallBackResource.m_Value;
		    *(_OWORD *)&retstr->directionalShadowResult.fallBackResource._type_k__BackingField = v16;
		    *(_QWORD *)&v16 = *(_QWORD *)&v15->punctualLightShadowResult.handle._type_k__BackingField;
		    LODWORD(v15) = v15->punctualLightShadowResult.fallBackResource._type_k__BackingField;
		    *(_OWORD *)&retstr->characterShadowResult.fallBackResource.m_Value = v17;
		    *(_QWORD *)&retstr->punctualLightShadowResult.handle._type_k__BackingField = v16;
		    retstr->punctualLightShadowResult.fallBackResource._type_k__BackingField = (int)v15;
		  }
		  else
		  {
		    v7 = 0LL;
		    v8 = 0;
		    memset(&v20, 0, 56);
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&shadowResult->directionalShadowResult, 0LL) )
		    {
		      v20.directionalShadowActive = shadowResult->directionalShadowActive;
		      v20.directionalShadowResult = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                                       (TextureHandle *)&v19,
		                                       builder,
		                                       &shadowResult->directionalShadowResult,
		                                       0LL);
		      v7 = *(_OWORD *)&v20.directionalShadowActive;
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&shadowResult->characterShadowResult, 0LL) )
		    {
		      v20.characterShadowActive = shadowResult->characterShadowActive;
		      v20.characterShadowResult = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                                     (TextureHandle *)&v19,
		                                     builder,
		                                     &shadowResult->characterShadowResult,
		                                     0LL);
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&shadowResult->punctualLightShadowResult, 0LL) )
		    {
		      v20.punctualLightShadowActive = shadowResult->punctualLightShadowActive;
		      v20.punctualLightShadowResult = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                                         (TextureHandle *)&v19,
		                                         builder,
		                                         &shadowResult->punctualLightShadowResult,
		                                         0LL);
		      v8 = _mm_cvtsi128_si32(_mm_srli_si128((__m128i)v20.punctualLightShadowResult, 12));
		    }
		    v9 = *(_OWORD *)&v20.directionalShadowResult.fallBackResource._type_k__BackingField;
		    v10 = *(_OWORD *)&v20.characterShadowResult.fallBackResource.m_Value;
		    *(_OWORD *)&retstr->directionalShadowActive = v7;
		    *(_OWORD *)&retstr->directionalShadowResult.fallBackResource._type_k__BackingField = v9;
		    *(_QWORD *)&v9 = *(_QWORD *)&v20.punctualLightShadowResult.handle._type_k__BackingField;
		    *(_OWORD *)&retstr->characterShadowResult.fallBackResource.m_Value = v10;
		    *(_QWORD *)&retstr->punctualLightShadowResult.handle._type_k__BackingField = v9;
		    retstr->punctualLightShadowResult.fallBackResource._type_k__BackingField = v8;
		  }
		  return retstr;
		}
		
		private void CalculateDirectionalShadowParameters(HGCamera hgCamera, CullingResults cullingResults, LightCullResult lightCullResult, int directionalLightIndex, int tileSize, Vector2Int atlasSize, int cascadeCount, float shadowIntensity, RendererList[] unityRendererLists, uint[] shadowRendererLists, uint[] shadowGrassLists, uint[] shadowTreeLists, ref CascadedShadowRequest shadowRequest, ScriptableRenderContext context) {} // 0x0000000189D1DBAC-0x0000000189D1F1EC
		// Void CalculateDirectionalShadowParameters(HGCamera, CullingResults, LightCullResult, Int32, Int32, Vector2Int, Int32, Single, RendererList[], UInt32[], UInt32[], UInt32[], HGShadowManager+CascadedShadowRequest ByRef, ScriptableRenderContext)
		void HG::Rendering::Runtime::HGShadowManager::CalculateDirectionalShadowParameters(
		        HGShadowManager *this,
		        HGCamera *hgCamera,
		        CullingResults *cullingResults,
		        LightCullResult *lightCullResult,
		        int32_t directionalLightIndex,
		        int32_t tileSize,
		        Vector2Int atlasSize,
		        int32_t cascadeCount,
		        float shadowIntensity,
		        RendererList__Array *unityRendererLists,
		        UInt32__Array *shadowRendererLists,
		        UInt32__Array *shadowGrassLists,
		        UInt32__Array *shadowTreeLists,
		        HGShadowManager_CascadedShadowRequest **shadowRequest,
		        ScriptableRenderContext context,
		        MethodInfo *method)
		{
		  int32_t v16; // r15d
		  __int64 m_csmScreenSizeMinSquareds; // rdx
		  void *Patch; // rcx
		  int32_t v23; // r12d
		  Matrix4x4__StaticFields *static_fields; // rax
		  __int128 v25; // xmm1
		  __int128 v26; // xmm2
		  __int128 v27; // xmm3
		  Matrix4x4__StaticFields *v28; // rax
		  __int128 v29; // xmm1
		  __int128 v30; // xmm2
		  __int128 v31; // xmm3
		  Vector4 *AsVector4; // rax
		  uint32_t m_csmNearPlaneOffset_low; // xmm8_4
		  Vector4 v34; // xmm0
		  HGShadowManager_CascadedShadowRequest *v35; // rax
		  HGEnvironmentVolumeCameraComponent *envVolumeCameraComponent; // rbx
		  Light *light; // rax
		  bool v38; // al
		  int32_t v39; // ebx
		  HGEnvironmentVolumeCameraComponent *v40; // rax
		  HGEnvironmentPhase *interpolatedPhase; // rax
		  __int128 v42; // xmm0
		  __int128 v43; // xmm1
		  __int128 v44; // xmm2
		  __int128 v45; // xmm3
		  Matrix4x4 *localToWorldMatrix; // rax
		  Camera *camera; // rcx
		  float m_csmMaxDistance; // xmm2_4
		  Void *m_Buffer; // rax
		  int32_t v50; // edi
		  float v51; // xmm14_4
		  HGShadowManager_CascadedShadowRequest *v52; // rax
		  __m128 v53; // xmm6
		  Matrix4x4__Array *v54; // r12
		  ShadowSplitData__Array *v55; // rbx
		  ShadowSplitData *v56; // rbx
		  Matrix4x4 *v57; // rax
		  HGShadowManager_CascadedShadowRequest *v58; // rax
		  __m128 v59; // xmm6
		  Matrix4x4__Array *deviceProjectionYFlipMatrices; // r12
		  ShadowSplitData__Array *shadowSplitData; // rbx
		  __int64 v62; // rbx
		  Matrix4x4 *v63; // rax
		  Single__Array *v64; // rbx
		  float v65; // xmm7_4
		  __int64 v66; // rax
		  float v67; // xmm6_4
		  HGShadowManager_CascadedShadowRequest *v68; // rax
		  Matrix4x4__Array *v69; // r12
		  ShadowSplitData *outSplitData; // rbx
		  Matrix4x4 *outProjFlipYMatrix; // rax
		  int32_t m_csmOcclusionDepthSize; // r12d
		  __int64 v73; // rax
		  HGShadowManager_CascadedShadowRequest *v74; // rbx
		  ShadowSplitData__Array *v75; // rbx
		  _DWORD *v76; // rax
		  Camera *v77; // rbx
		  uint64_t SceneCullingMaskFromCamera; // rax
		  int v79; // r10d
		  int v80; // r11d
		  int32_t v81; // ebx
		  int v82; // xmm6_4
		  void *v83; // rax
		  Matrix4x4 *v84; // rax
		  __int128 v85; // xmm1
		  __int64 (__fastcall *v86)(void *, _QWORD, _QWORD, uint64_t, int32_t, _DWORD, int, LODCrossFadeConfig *, int, int, _DWORD, int32_t, int32_t, _OWORD *, __int64 *, __int128 *, _DWORD, int); // rax
		  int v87; // eax
		  __int128 v88; // xmm10
		  __int128 v89; // xmm11
		  __int128 v90; // xmm12
		  __int128 v91; // xmm13
		  __int128 v92; // xmm6
		  __int128 v93; // xmm7
		  __int128 v94; // xmm8
		  __int128 v95; // xmm9
		  Matrix4x4 *ShadowTransform; // rax
		  __int128 v97; // xmm1
		  __int128 v98; // xmm0
		  __int128 v99; // xmm1
		  ShadowSplitData__Array *v100; // rbx
		  __m128 v101; // xmm2
		  float v102; // xmm0_4
		  float v103; // xmm1_4
		  Vector4__Array *cascadeShadowBiases; // rbx
		  float m_csmNormalBias; // xmm4_4
		  unsigned int m_csmShadowSampleMode; // eax
		  float m_csmDepthBias; // xmm3_4
		  Vector4 *ShadowBias; // rax
		  __m128 v109; // xmm6
		  __m128 v110; // xmm7
		  __int64 v111; // rax
		  int v112; // edi
		  Matrix4x4 *v113; // rax
		  __int128 v114; // xmm10
		  __int128 v115; // xmm11
		  __int128 v116; // xmm12
		  __int128 v117; // xmm13
		  HGShadowManager__StaticFields *v118; // rdx
		  __int64 v119; // r9
		  CullingResults v120; // xmm6
		  Camera *v121; // r9
		  unsigned int v122; // esi
		  __int64 v123; // r12
		  Void *v124; // rbx
		  HGRenderFlags__Enum__Array *m_cascadeRenderFlags; // rdi
		  HGRenderFlags__Enum v126; // edi
		  HGRenderFlags__Enum v127; // ebx
		  uint32_t RendererList; // eax
		  uint32_t v129; // eax
		  uint32_t v130; // eax
		  __int64 v131; // rax
		  Matrix4x4__StaticFields *v132; // rcx
		  __int128 v133; // xmm7
		  __int128 v134; // xmm8
		  __int128 v135; // xmm9
		  __int128 v136; // xmm6
		  CullingResults v137; // xmm1
		  CullingResults v138; // xmm1
		  HGRenderKeyword__Enum methoda; // [rsp+28h] [rbp-F0h]
		  MethodInfo *v140; // [rsp+60h] [rbp-B8h]
		  Vector4 v141; // [rsp+98h] [rbp-80h] BYREF
		  uint32_t viewHandle; // [rsp+A8h] [rbp-70h]
		  ShaderTagId v143; // [rsp+ACh] [rbp-6Ch] BYREF
		  CullingResults v144; // [rsp+B8h] [rbp-60h] BYREF
		  Matrix4x4 v145; // [rsp+C8h] [rbp-50h] BYREF
		  __int64 v146; // [rsp+108h] [rbp-10h]
		  __int64 v147; // [rsp+110h] [rbp-8h]
		  unsigned int v148; // [rsp+118h] [rbp+0h] BYREF
		  unsigned int v149; // [rsp+11Ch] [rbp+4h]
		  CullingResults v150; // [rsp+120h] [rbp+8h] BYREF
		  int v151; // [rsp+130h] [rbp+18h]
		  int32_t cullingMask; // [rsp+134h] [rbp+1Ch]
		  Void *v153; // [rsp+138h] [rbp+20h]
		  Void *v154; // [rsp+140h] [rbp+28h]
		  NativeArray_1_System_UInt32_ v155; // [rsp+148h] [rbp+30h] BYREF
		  __int64 v156; // [rsp+158h] [rbp+40h] BYREF
		  int v157; // [rsp+160h] [rbp+48h]
		  Single__Array *m_csmShadowSplitPercentage; // [rsp+168h] [rbp+50h]
		  Matrix4x4 outViewMatrix; // [rsp+178h] [rbp+60h] BYREF
		  Matrix4x4 outProjMatrix; // [rsp+1B8h] [rbp+A0h] BYREF
		  Matrix4x4 v161; // [rsp+1F8h] [rbp+E0h] BYREF
		  uint64_t v162; // [rsp+238h] [rbp+120h]
		  Matrix4x4 v163; // [rsp+248h] [rbp+130h] BYREF
		  RendererList v164; // [rsp+288h] [rbp+170h] BYREF
		  __int128 v165; // [rsp+298h] [rbp+180h] BYREF
		  Vector4 v166; // [rsp+2A8h] [rbp+190h] BYREF
		  _OWORD v167[4]; // [rsp+2B8h] [rbp+1A0h] BYREF
		  Matrix4x4 v168; // [rsp+2F8h] [rbp+1E0h] BYREF
		  VisibleLight v169; // [rsp+338h] [rbp+220h] BYREF
		  RendererListDesc v170; // [rsp+3D8h] [rbp+2C0h] BYREF
		  RendererListDesc v171; // [rsp+4B8h] [rbp+3A0h] BYREF
		  HGShadowCullData shadowCullData; // [rsp+598h] [rbp+480h] BYREF
		  ScriptableCullingParameters cullingParameters; // [rsp+738h] [rbp+620h] BYREF
		
		  v16 = cascadeCount;
		  sub_18033B9D0(&v169, 0LL, 148LL);
		  v155 = 0LL;
		  sub_18033B9D0(&shadowCullData, 0LL, 412LL);
		  v148 = 0;
		  v149 = 0;
		  sub_18033B9D0(v167, 0LL, 64LL);
		  v156 = 0LL;
		  v157 = 0;
		  v165 = 0LL;
		  sub_18033B9D0(&cullingParameters, 0LL, 1592LL);
		  v143.m_Id = 0;
		  sub_18033B9D0(&v170, 0LL, 224LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(2159, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2159, 0LL);
		    if ( !Patch )
		      goto LABEL_125;
		    v138 = *cullingResults;
		    v155 = (NativeArray_1_System_UInt32_)*lightCullResult;
		    v141 = (Vector4)v138;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_863(
		      (ILFixDynamicMethodWrapper_2 *)Patch,
		      (Object *)this,
		      (Object *)hgCamera,
		      (CullingResults *)&v141,
		      (LightCullResult *)&v155,
		      directionalLightIndex,
		      tileSize,
		      atlasSize,
		      cascadeCount,
		      shadowIntensity,
		      (Object *)unityRendererLists,
		      (Object *)shadowRendererLists,
		      (Object *)shadowGrassLists,
		      (Object *)shadowTreeLists,
		      shadowRequest,
		      context,
		      0LL);
		  }
		  else if ( this->fields.m_csmRenderMode == 1 )
		  {
		    v137 = *cullingResults;
		    v155 = (NativeArray_1_System_UInt32_)*lightCullResult;
		    v141 = (Vector4)v137;
		    HG::Rendering::Runtime::HGShadowManager::CalculateDirectionalShadowParametersManualOverride(
		      this,
		      hgCamera,
		      (CullingResults *)&v141,
		      (LightCullResult *)&v155,
		      directionalLightIndex,
		      tileSize,
		      atlasSize,
		      cascadeCount,
		      shadowIntensity,
		      unityRendererLists,
		      shadowRendererLists,
		      shadowGrassLists,
		      shadowTreeLists,
		      shadowRequest,
		      context,
		      0LL);
		  }
		  else
		  {
		    Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::ConvertExistingDataToNativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>(
		      (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v141,
		      (Void *)lightCullResult->visibleLightsPtr,
		      lightCullResult->visibleLightCount,
		      Allocator__Enum_None,
		      MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::ConvertExistingDataToNativeArray<UnityEngine::Rendering::VisibleLight>);
		    m_csmScreenSizeMinSquareds = directionalLightIndex;
		    Patch = &v169;
		    v169 = *(VisibleLight *)(148LL * directionalLightIndex + *(_QWORD *)&v141.x);
		    m_csmShadowSplitPercentage = this->fields.m_csmShadowSplitPercentage;
		    if ( !*shadowRequest )
		      goto LABEL_125;
		    (*shadowRequest)->fields.directionalLightIndex = directionalLightIndex;
		    if ( !*shadowRequest )
		      goto LABEL_125;
		    v23 = tileSize;
		    (*shadowRequest)->fields.directionalShadowMapTileSize = tileSize;
		    Patch = *shadowRequest;
		    if ( !*shadowRequest )
		      goto LABEL_125;
		    *((Vector2Int *)Patch + 5) = atlasSize;
		    if ( !*shadowRequest )
		      goto LABEL_125;
		    (*shadowRequest)->fields.cascadeCount = cascadeCount;
		    static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		    v25 = *(_OWORD *)&static_fields->identityMatrix.m01;
		    v26 = *(_OWORD *)&static_fields->identityMatrix.m02;
		    v27 = *(_OWORD *)&static_fields->identityMatrix.m03;
		    *(_OWORD *)&outViewMatrix.m00 = *(_OWORD *)&static_fields->identityMatrix.m00;
		    *(_OWORD *)&outViewMatrix.m01 = v25;
		    *(_OWORD *)&outViewMatrix.m02 = v26;
		    *(_OWORD *)&outViewMatrix.m03 = v27;
		    v28 = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		    v29 = *(_OWORD *)&v28->identityMatrix.m01;
		    v30 = *(_OWORD *)&v28->identityMatrix.m02;
		    v31 = *(_OWORD *)&v28->identityMatrix.m03;
		    *(_OWORD *)&outProjMatrix.m00 = *(_OWORD *)&v28->identityMatrix.m00;
		    *(_OWORD *)&outProjMatrix.m01 = v29;
		    *(_OWORD *)&outProjMatrix.m02 = v30;
		    *(_OWORD *)&outProjMatrix.m03 = v31;
		    v141 = (Vector4)*TypeInfo::Unity::Mathematics::float4->static_fields;
		    AsVector4 = Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
		                  (Vector4 *)&v150,
		                  (CinemachineSmoothPath_Waypoint *)&v141,
		                  0LL);
		    m_csmNearPlaneOffset_low = LODWORD(this->fields.m_csmNearPlaneOffset);
		    LOBYTE(Patch) = this->fields.m_useShadowMapCache;
		    viewHandle = m_csmNearPlaneOffset_low;
		    v34 = *AsVector4;
		    v35 = *shadowRequest;
		    v150 = (CullingResults)v34;
		    if ( !v35 )
		      goto LABEL_125;
		    v35->fields.useCache = (char)Patch;
		    if ( !*shadowRequest )
		      goto LABEL_125;
		    (*shadowRequest)->fields.directionalShadowStrength = shadowIntensity;
		    Unity::Collections::NativeArray<unsigned int>::NativeArray(
		      &v155,
		      cascadeCount,
		      Allocator__Enum_Temp,
		      NativeArrayOptions__Enum_ClearMemory,
		      MethodInfo::Unity::Collections::NativeArray<unsigned int>::NativeArray);
		    if ( !hgCamera )
		      goto LABEL_125;
		    envVolumeCameraComponent = HG::Rendering::Runtime::HGCamera::get_envVolumeCameraComponent(hgCamera, 0LL);
		    light = UnityEngine::Rendering::VisibleLight::get_light(&v169, 0LL);
		    if ( !envVolumeCameraComponent )
		      goto LABEL_125;
		    v38 = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::UseDirLightDataFromEnvDirectly(
		            envVolumeCameraComponent,
		            light,
		            0LL);
		    v39 = 0;
		    if ( v38 )
		    {
		      v40 = HG::Rendering::Runtime::HGCamera::get_envVolumeCameraComponent(hgCamera, 0LL);
		      if ( !v40 )
		        goto LABEL_125;
		      interpolatedPhase = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedPhase(v40, 0LL);
		      if ( !interpolatedPhase )
		        goto LABEL_125;
		      v42 = *(_OWORD *)&interpolatedPhase->fields.lightConfig.localToWorld.m00;
		      v43 = *(_OWORD *)&interpolatedPhase->fields.lightConfig.localToWorld.m01;
		      v44 = *(_OWORD *)&interpolatedPhase->fields.lightConfig.localToWorld.m02;
		      v45 = *(_OWORD *)&interpolatedPhase->fields.lightConfig.localToWorld.m03;
		    }
		    else
		    {
		      localToWorldMatrix = UnityEngine::HGSharedLightData::get_localToWorldMatrix(&v145, &v169.hgSharedLightData, 0LL);
		      v42 = *(_OWORD *)&localToWorldMatrix->m00;
		      v43 = *(_OWORD *)&localToWorldMatrix->m01;
		      v44 = *(_OWORD *)&localToWorldMatrix->m02;
		      v45 = *(_OWORD *)&localToWorldMatrix->m03;
		    }
		    camera = hgCamera->fields.camera;
		    *(_OWORD *)&v161.m02 = v44;
		    m_csmMaxDistance = this->fields.m_csmMaxDistance;
		    *(_OWORD *)&v161.m03 = v45;
		    *(_OWORD *)&v161.m00 = v42;
		    *(_OWORD *)&v161.m01 = v43;
		    UnityEngine::HyperGryph::HGCullingSystem::ExtractShadowCullDataForDirLight(
		      camera,
		      &v161,
		      m_csmMaxDistance,
		      *(float *)&m_csmNearPlaneOffset_low,
		      &shadowCullData,
		      0LL);
		    m_Buffer = v155.m_Buffer;
		    v50 = 0;
		    v51 = 1.0;
		    v154 = v155.m_Buffer;
		    if ( cascadeCount > 0 )
		    {
		      v153 = v155.m_Buffer;
		      do
		      {
		        *(_DWORD *)m_Buffer = -1;
		        if ( !this->fields.m_useShadowMapCache )
		          goto LABEL_30;
		        Patch = this->fields.m_updateCSMShadowMap;
		        if ( !Patch )
		          goto LABEL_125;
		        if ( (unsigned int)v50 >= *((_DWORD *)Patch + 6) )
		          goto LABEL_106;
		        if ( *((_BYTE *)Patch + v50 + 32) )
		        {
		LABEL_30:
		          v58 = *shadowRequest;
		          v59 = (__m128)COERCE_UNSIGNED_INT((float)v23);
		          if ( !*shadowRequest )
		            goto LABEL_125;
		          deviceProjectionYFlipMatrices = v58->fields.deviceProjectionYFlipMatrices;
		          if ( !deviceProjectionYFlipMatrices )
		            goto LABEL_125;
		          shadowSplitData = v58->fields.shadowSplitData;
		          if ( !shadowSplitData )
		            goto LABEL_125;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
		          v62 = sub_1808B5920(shadowSplitData, v50);
		          v63 = (Matrix4x4 *)sub_18049E964(deviceProjectionYFlipMatrices, v50);
		          v140 = (MethodInfo *)v62;
		          v64 = m_csmShadowSplitPercentage;
		          v144 = *cullingResults;
		          HG::Rendering::Runtime::HGShadowUtils::ExtractDirectionalLightData(
		            &v169,
		            (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v59, v59),
		            v50,
		            cascadeCount,
		            m_csmShadowSplitPercentage,
		            *(float *)&m_csmNearPlaneOffset_low,
		            &v144,
		            directionalLightIndex,
		            &outViewMatrix,
		            &outProjMatrix,
		            v63,
		            (ShadowSplitData *)v140,
		            0LL);
		          if ( v50 )
		          {
		            if ( !v64 )
		              goto LABEL_125;
		            v66 = v50 - 1LL;
		            if ( (unsigned int)v66 >= v64->max_length.size )
		              goto LABEL_106;
		            v65 = v64->vector[v66];
		          }
		          else
		          {
		            v65 = 0.0;
		          }
		          if ( v50 + 1 == cascadeCount )
		          {
		            v67 = 1.0;
		          }
		          else
		          {
		            if ( !v64 )
		              goto LABEL_125;
		            if ( (unsigned int)v50 >= v64->max_length.size )
		LABEL_106:
		              sub_1800D2AB0(Patch, m_csmScreenSizeMinSquareds);
		            v67 = v64->vector[v50];
		          }
		          v68 = *shadowRequest;
		          if ( !*shadowRequest )
		            goto LABEL_125;
		          v69 = v68->fields.deviceProjectionYFlipMatrices;
		          if ( !v69 )
		            goto LABEL_125;
		          Patch = v68->fields.shadowSplitData;
		          if ( !Patch )
		            goto LABEL_125;
		          outSplitData = (ShadowSplitData *)sub_1808B5920(Patch, v50);
		          outProjFlipYMatrix = (Matrix4x4 *)sub_18049E964(v69, v50);
		          m_csmOcclusionDepthSize = 0;
		          UnityEngine::HyperGryph::HGCullingSystem::GetPSSMSplitMatrices(
		            &shadowCullData,
		            v65,
		            v67,
		            tileSize,
		            &outViewMatrix,
		            &outProjMatrix,
		            outProjFlipYMatrix,
		            outSplitData,
		            0LL);
		          Patch = *shadowRequest;
		          if ( !*shadowRequest )
		            goto LABEL_125;
		          Patch = (void *)*((_QWORD *)Patch + 9);
		          if ( !Patch )
		            goto LABEL_125;
		          v73 = sub_1808B5920(Patch, v50);
		          v74 = *shadowRequest;
		          v161 = outProjMatrix;
		          v161.m20 = -_mm_shuffle_ps(*(__m128 *)&v161.m00, *(__m128 *)&v161.m00, 170).m128_f32[0];
		          v161.m21 = -_mm_shuffle_ps(*(__m128 *)&v161.m01, *(__m128 *)&v161.m01, 170).m128_f32[0];
		          v161.m22 = -_mm_shuffle_ps(*(__m128 *)&v161.m02, *(__m128 *)&v161.m02, 170).m128_f32[0];
		          v161.m23 = 1.0 - _mm_shuffle_ps(*(__m128 *)&outProjMatrix.m03, *(__m128 *)&outProjMatrix.m03, 170).m128_f32[0];
		          v146 = v73;
		          if ( !v74 )
		            goto LABEL_125;
		          v75 = v74->fields.shadowSplitData;
		          if ( !v75 )
		            goto LABEL_125;
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ShadowSplitData);
		          v76 = (_DWORD *)sub_1808B5920(v75, v50);
		          v77 = hgCamera->fields.camera;
		          LODWORD(v147) = *v76;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		          SceneCullingMaskFromCamera = HG::Rendering::Runtime::HGUtils::GetSceneCullingMaskFromCamera(v77, 0LL);
		          Patch = hgCamera->fields.camera;
		          v162 = SceneCullingMaskFromCamera;
		          if ( !Patch )
		            goto LABEL_125;
		          cullingMask = UnityEngine::Camera::get_cullingMask((Camera *)Patch, 0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		          Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		          m_csmScreenSizeMinSquareds = *((_QWORD *)Patch + 16);
		          if ( !m_csmScreenSizeMinSquareds )
		            goto LABEL_125;
		          if ( (unsigned int)v50 >= *(_DWORD *)(m_csmScreenSizeMinSquareds + 24) )
		            goto LABEL_106;
		          v79 = *(_DWORD *)(m_csmScreenSizeMinSquareds + 4LL * v50 + 32);
		          Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		          v80 = *(_DWORD *)(*((_QWORD *)Patch + 16) + 4LL * v50 + 32);
		          m_csmScreenSizeMinSquareds = (__int64)this->fields.m_csmScreenSizeMinSquareds;
		          if ( !m_csmScreenSizeMinSquareds )
		            goto LABEL_125;
		          if ( (unsigned int)v50 >= *(_DWORD *)(m_csmScreenSizeMinSquareds + 24) )
		            goto LABEL_106;
		          Patch = this->fields.m_csmEnableOcclusionCulling;
		          if ( !Patch )
		            goto LABEL_125;
		          if ( (unsigned int)v50 >= *((_DWORD *)Patch + 6) )
		            goto LABEL_106;
		          if ( *((_BYTE *)Patch + v50 + 32) )
		          {
		            m_csmOcclusionDepthSize = this->fields.m_csmOcclusionDepthSize;
		            v81 = m_csmOcclusionDepthSize;
		          }
		          else
		          {
		            v81 = 0;
		          }
		          v82 = *(_DWORD *)(m_csmScreenSizeMinSquareds + 4LL * v50 + 32);
		          v163 = outViewMatrix;
		          v83 = (void *)(v146 + 4);
		          v145 = v161;
		          LODWORD(v146) = v79 | 0x8000002;
		          v151 = v80 | 0x8000002;
		          v144.ptr = v83;
		          v84 = UnityEngine::Matrix4x4::op_Multiply(&v168, &v145, &v163, 0LL);
		          v167[0] = *(_OWORD *)&v84->m00;
		          v167[1] = *(_OWORD *)&v84->m01;
		          v167[2] = *(_OWORD *)&v84->m02;
		          v85 = *(_OWORD *)&v84->m03;
		          v156 = 0LL;
		          v157 = 0;
		          v86 = (__int64 (__fastcall *)(void *, _QWORD, _QWORD, uint64_t, int32_t, _DWORD, int, LODCrossFadeConfig *, int, int, _DWORD, int32_t, int32_t, _OWORD *, __int64 *, __int128 *, _DWORD, int))qword_18F3AB290;
		          v167[3] = v85;
		          v165 = 0LL;
		          if ( !qword_18F3AB290 )
		          {
		            v86 = (__int64 (__fastcall *)(void *, _QWORD, _QWORD, uint64_t, int32_t, _DWORD, int, LODCrossFadeConfig *, int, int, _DWORD, int32_t, int32_t, _OWORD *, __int64 *, __int128 *, _DWORD, int))sub_180059EA0("UnityEngine.HyperGryph.HGCullingSystem::AddCullViewByPlanes(System.IntPtr,System.Int32,System.Int32,System.UInt64,System.UInt32,System.UInt32,System.UInt32,UnityEngine.HyperGryph.LODCrossFadeConfig&,System.Single,UnityEngine.CameraType,System.UInt32,System.Int32,System.Int32,UnityEngine.Matrix4x4&,UnityEngine.Vector3&,UnityEngine.Vector4&,System.Single,System.Single)");
		            qword_18F3AB290 = (__int64)v86;
		          }
		          v87 = v86(
		                  v144.ptr,
		                  (unsigned int)v147,
		                  0LL,
		                  v162,
		                  cullingMask,
		                  v146,
		                  v151,
		                  &hgCamera->fields.lodCrossFadeConfig,
		                  v82,
		                  32,
		                  0,
		                  m_csmOcclusionDepthSize,
		                  v81,
		                  v167,
		                  &v156,
		                  &v165,
		                  0,
		                  1028443341);
		          *(_DWORD *)v153 = v87;
		          Patch = *shadowRequest;
		          if ( !*shadowRequest )
		            goto LABEL_125;
		          Patch = (void *)*((_QWORD *)Patch + 7);
		          if ( !Patch )
		            goto LABEL_125;
		          v145 = outViewMatrix;
		          sub_180041540(Patch, v50, &v145);
		          v88 = *(_OWORD *)&outProjMatrix.m00;
		          v89 = *(_OWORD *)&outProjMatrix.m01;
		          v90 = *(_OWORD *)&outProjMatrix.m02;
		          v91 = *(_OWORD *)&outProjMatrix.m03;
		          v92 = *(_OWORD *)&outViewMatrix.m00;
		          v93 = *(_OWORD *)&outViewMatrix.m01;
		          v94 = *(_OWORD *)&outViewMatrix.m02;
		          v95 = *(_OWORD *)&outViewMatrix.m03;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
		          *(_OWORD *)&v145.m00 = v92;
		          *(_OWORD *)&v145.m01 = v93;
		          *(_OWORD *)&v145.m02 = v94;
		          *(_OWORD *)&v145.m03 = v95;
		          *(_OWORD *)&v163.m00 = v88;
		          *(_OWORD *)&v163.m01 = v89;
		          *(_OWORD *)&v163.m02 = v90;
		          *(_OWORD *)&v163.m03 = v91;
		          ShadowTransform = HG::Rendering::Runtime::HGShadowUtils::GetShadowTransform(&v168, &v163, &v145, 0LL);
		          Patch = *shadowRequest;
		          if ( !*shadowRequest )
		            goto LABEL_125;
		          Patch = (void *)*((_QWORD *)Patch + 10);
		          if ( !Patch )
		            goto LABEL_125;
		          v97 = *(_OWORD *)&ShadowTransform->m01;
		          *(_OWORD *)&v145.m00 = *(_OWORD *)&ShadowTransform->m00;
		          v98 = *(_OWORD *)&ShadowTransform->m02;
		          *(_OWORD *)&v145.m01 = v97;
		          v99 = *(_OWORD *)&ShadowTransform->m03;
		          *(_OWORD *)&v145.m02 = v98;
		          *(_OWORD *)&v145.m03 = v99;
		          sub_180041540(Patch, v50, &v145);
		          if ( !*shadowRequest )
		            goto LABEL_125;
		          v100 = (*shadowRequest)->fields.shadowSplitData;
		          if ( !v100 )
		            goto LABEL_125;
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ShadowSplitData);
		          v101 = (__m128)_mm_loadu_si128((const __m128i *)(sub_1808B5920(v100, v50) + 164));
		          Patch = *shadowRequest;
		          LODWORD(v102) = _mm_shuffle_ps(v101, v101, 85).m128_u32[0];
		          LODWORD(v103) = _mm_shuffle_ps(v101, v101, 170).m128_u32[0];
		          LODWORD(v150.ptr) = v101.m128_i32[0];
		          v101.m128_f32[0] = _mm_shuffle_ps(v101, v101, 255).m128_f32[0];
		          *((float *)&v150.ptr + 1) = v102;
		          *(float *)&v150.m_AllocationInfo = v103;
		          *((float *)&v150.m_AllocationInfo + 1) = v101.m128_f32[0] * v101.m128_f32[0];
		          if ( !Patch )
		            goto LABEL_125;
		          Patch = (void *)*((_QWORD *)Patch + 11);
		          if ( !Patch )
		            goto LABEL_125;
		          v144 = v150;
		          sub_18003FEF0(Patch, v50, &v144);
		          if ( !*shadowRequest )
		            goto LABEL_125;
		          cascadeShadowBiases = (*shadowRequest)->fields.cascadeShadowBiases;
		          m_csmNormalBias = this->fields.m_csmNormalBias;
		          m_csmShadowSampleMode = this->fields.m_csmShadowSampleMode;
		          v23 = tileSize;
		          m_csmDepthBias = this->fields.m_csmDepthBias;
		          v145 = outProjMatrix;
		          ShadowBias = HG::Rendering::Runtime::HGShadowUtils::GetShadowBias(
		                         &v166,
		                         &v145,
		                         (float)tileSize,
		                         m_csmDepthBias,
		                         m_csmNormalBias,
		                         (HGShadowSampleMode__Enum)m_csmShadowSampleMode,
		                         0LL);
		          if ( !cascadeShadowBiases )
		            goto LABEL_125;
		          v144 = (CullingResults)*ShadowBias;
		          sub_18003FEF0(cascadeShadowBiases, v50, &v144);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		          v39 = 0;
		          Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_atlasScales;
		          if ( !Patch )
		            goto LABEL_125;
		          sub_1800473A0(Patch, &v148, cascadeCount - 1LL);
		          v109 = (__m128)v148;
		          v110 = (__m128)v149;
		          Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_atlasOffsets;
		          if ( !Patch )
		            goto LABEL_125;
		          sub_1800473A0(Patch, &v164, v50);
		          v111 = sub_185EDCFF4(v164.context, _mm_unpacklo_ps(v109, v110).m128_u64[0]);
		          Patch = *shadowRequest;
		          v147 = v111;
		          if ( !Patch )
		            goto LABEL_125;
		          Patch = (void *)*((_QWORD *)Patch + 13);
		          *(_QWORD *)&v141.x = v147;
		          LODWORD(v141.z) = v109.m128_i32[0];
		          LODWORD(v141.w) = v110.m128_i32[0];
		          if ( !Patch )
		            goto LABEL_125;
		          v144 = (CullingResults)v141;
		          sub_18003FEF0(Patch, v50, &v144);
		          Patch = *shadowRequest;
		          if ( !*shadowRequest )
		            goto LABEL_125;
		          HG::Rendering::Runtime::HGShadowManager::CascadedShadowRequest::CopyTo(
		            (HGShadowManager_CascadedShadowRequest *)Patch,
		            this->fields.m_cachedCascadedShadowRequest,
		            v50,
		            0LL);
		          Patch = *shadowRequest;
		          if ( !*shadowRequest )
		            goto LABEL_125;
		          Patch = (void *)*((_QWORD *)Patch + 3);
		          if ( !Patch )
		            goto LABEL_125;
		          if ( (unsigned int)v50 >= *((_DWORD *)Patch + 6) )
		            goto LABEL_106;
		          m_csmNearPlaneOffset_low = viewHandle;
		          *((_BYTE *)Patch + v50 + 32) = 1;
		        }
		        else
		        {
		          Patch = this->fields.m_cachedCascadedShadowRequest;
		          if ( !Patch )
		            goto LABEL_125;
		          HG::Rendering::Runtime::HGShadowManager::CascadedShadowRequest::CopyTo(
		            (HGShadowManager_CascadedShadowRequest *)Patch,
		            *shadowRequest,
		            v50,
		            0LL);
		          v52 = *shadowRequest;
		          v53 = (__m128)COERCE_UNSIGNED_INT((float)v23);
		          if ( !*shadowRequest )
		            goto LABEL_125;
		          v54 = v52->fields.deviceProjectionYFlipMatrices;
		          if ( !v54 )
		            goto LABEL_125;
		          v55 = v52->fields.shadowSplitData;
		          if ( !v55 )
		            goto LABEL_125;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
		          v56 = (ShadowSplitData *)sub_1808B5920(v55, v50);
		          v57 = (Matrix4x4 *)sub_18049E964(v54, v50);
		          v144 = *cullingResults;
		          HG::Rendering::Runtime::HGShadowUtils::ExtractDirectionalLightData(
		            &v169,
		            (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v53, v53),
		            v50,
		            cascadeCount,
		            m_csmShadowSplitPercentage,
		            *(float *)&m_csmNearPlaneOffset_low,
		            &v144,
		            directionalLightIndex,
		            &outViewMatrix,
		            &outProjMatrix,
		            v57,
		            v56,
		            0LL);
		          Patch = *shadowRequest;
		          v39 = 0;
		          if ( !*shadowRequest )
		            goto LABEL_125;
		          Patch = (void *)*((_QWORD *)Patch + 3);
		          if ( !Patch )
		            goto LABEL_125;
		          if ( (unsigned int)v50 >= *((_DWORD *)Patch + 6) )
		            goto LABEL_106;
		          v23 = tileSize;
		          *((_BYTE *)Patch + v50 + 32) = 0;
		        }
		        ++v50;
		        m_Buffer = v153 + 4;
		        v153 += 4;
		      }
		      while ( v50 < cascadeCount );
		    }
		    UnityEngine::HyperGryph::HGCullingSystem::DispatchBatchCullingJobs(0LL);
		    v112 = 0;
		    if ( cascadeCount > 0 )
		    {
		      while ( 1 )
		      {
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList);
		        Patch = TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList->static_fields;
		        if ( !unityRendererLists )
		          break;
		        v141 = *(Vector4 *)Patch;
		        sub_180430AC4(unityRendererLists, v112, &v141);
		        v145 = outViewMatrix;
		        v163 = outProjMatrix;
		        v113 = UnityEngine::Matrix4x4::op_Multiply(&v168, &v163, &v145, 0LL);
		        v114 = *(_OWORD *)&v113->m00;
		        v115 = *(_OWORD *)&v113->m01;
		        v116 = *(_OWORD *)&v113->m02;
		        v117 = *(_OWORD *)&v113->m03;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		        *(_OWORD *)&v145.m00 = v114;
		        *(_OWORD *)&v145.m01 = v115;
		        *(_OWORD *)&v145.m02 = v116;
		        v118 = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		        *(_OWORD *)&v145.m03 = v117;
		        UnityEngine::GeometryUtility::CalculateFrustumPlanes(&v145, v118->s_tempPlanes, 0LL);
		        if ( !UnityEngine::HyperGryph::HGGraphicsUtils::get_enableECSRenderer(0LL) )
		        {
		          Patch = hgCamera->fields.camera;
		          if ( !Patch )
		            break;
		          UnityEngine::Camera::TryGetCullingParameters((Camera *)Patch, &cullingParameters, 0LL);
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
		          *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m20 = v114;
		          *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m21 = v115;
		          *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m22 = v116;
		          *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m23 = v117;
		          UnityEngine::Rendering::ScriptableCullingParameters::set_isOrthographic(&cullingParameters, 1, 0LL);
		          cullingParameters.m_CameraProperties.cameraWorldToClip.m31 = 0.0;
		          do
		          {
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		            Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->s_tempPlanes;
		            if ( !Patch )
		              goto LABEL_125;
		            sub_180002990(Patch, &v150, v39, v119);
		            sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
		            v141 = (Vector4)v150;
		            UnityEngine::Rendering::ScriptableCullingParameters::SetCullingPlane(
		              &cullingParameters,
		              v39++,
		              (Plane *)&v141,
		              0LL);
		          }
		          while ( v39 < 6 );
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		          v120 = *UnityEngine::Rendering::ScriptableRenderContext::Cull(
		                    (CullingResults *)&v166,
		                    &context,
		                    &cullingParameters,
		                    0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
		          UnityEngine::Rendering::ShaderTagId::ShaderTagId(
		            &v143,
		            TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ShadowCasterStr,
		            0LL);
		          v121 = hgCamera->fields.camera;
		          v39 = 0;
		          v141 = (Vector4)v120;
		          UnityEngine::Rendering::RendererUtils::RendererListDesc::RendererListDesc(
		            &v170,
		            v143,
		            (CullingResults *)&v141,
		            v121,
		            0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
		          v170.renderQueueRange = TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_AllOpaque;
		          v170.sortingCriteria = 59;
		          v170.rendererConfiguration = 30720;
		          v171 = v170;
		          v141 = (Vector4)*UnityEngine::Rendering::ScriptableRenderContext::CreateRendererList(
		                             &v164,
		                             &context,
		                             &v171,
		                             0LL);
		          sub_180430AC4(unityRendererLists, v112, &v141);
		        }
		        if ( ++v112 >= cascadeCount )
		          goto LABEL_91;
		      }
		LABEL_125:
		      sub_1800D8260(Patch, m_csmScreenSizeMinSquareds);
		    }
		LABEL_91:
		    v122 = 0;
		    if ( cascadeCount > 0 )
		    {
		      v123 = 0LL;
		      v124 = v154;
		      Patch = shadowTreeLists;
		      do
		      {
		        m_csmScreenSizeMinSquareds = 0xFFFFFFFFLL;
		        if ( *(_DWORD *)&v124[v123] == -1 )
		        {
		          if ( !shadowRendererLists )
		            goto LABEL_125;
		          if ( v122 >= shadowRendererLists->max_length.size )
		            goto LABEL_106;
		          shadowRendererLists->vector[v122] = -1;
		          if ( !shadowGrassLists )
		            goto LABEL_125;
		          if ( v122 >= shadowGrassLists->max_length.size )
		            goto LABEL_106;
		          shadowGrassLists->vector[v122] = -1;
		          if ( !Patch )
		            goto LABEL_125;
		          if ( v122 >= *((_DWORD *)Patch + 6) )
		            goto LABEL_106;
		          v124 = v154;
		        }
		        else
		        {
		          viewHandle = *(_DWORD *)&v124[v123];
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		          Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager;
		          m_cascadeRenderFlags = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_cascadeRenderFlags;
		          if ( !m_cascadeRenderFlags )
		            goto LABEL_125;
		          if ( v122 >= m_cascadeRenderFlags->max_length.size )
		            goto LABEL_106;
		          v126 = m_cascadeRenderFlags->vector[v122];
		          v127 = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_cascadeRenderFlags->vector[v122];
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		          LOWORD(methoda) = 0;
		          RendererList = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		                           viewHandle,
		                           (HGRenderFlags__Enum)(v126 | 0x2080100),
		                           (HGRenderFlags__Enum)(v127 | 0x2080100),
		                           HGShaderLightMode__Enum_ShadowCaster,
		                           methoda,
		                           context.m_Ptr,
		                           0,
		                           0,
		                           0xFFFFFFFF,
		                           0,
		                           0,
		                           0LL);
		          if ( !shadowRendererLists )
		            goto LABEL_125;
		          if ( v122 >= shadowRendererLists->max_length.size )
		            goto LABEL_106;
		          shadowRendererLists->vector[v122] = RendererList;
		          Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager;
		          m_csmScreenSizeMinSquareds = (__int64)TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_cascadeRenderFlags;
		          if ( !m_csmScreenSizeMinSquareds )
		            goto LABEL_125;
		          if ( v122 >= *(_DWORD *)(m_csmScreenSizeMinSquareds + 24) )
		            goto LABEL_106;
		          v124 = v154;
		          v129 = UnityEngine::HyperGryph::HGGrassRender::CreateRendererList(
		                   *(_DWORD *)&v154[v123],
		                   (HGRenderFlags__Enum)(*(_DWORD *)(m_csmScreenSizeMinSquareds + 4LL * (int)v122 + 32) | 0x2080100),
		                   (HGRenderFlags__Enum)(TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_cascadeRenderFlags->vector[v122] | 0x2080100),
		                   HGShaderLightMode__Enum_ShadowCaster,
		                   context.m_Ptr,
		                   0,
		                   0LL);
		          if ( !shadowGrassLists )
		            goto LABEL_125;
		          if ( v122 >= shadowGrassLists->max_length.size )
		            goto LABEL_106;
		          shadowGrassLists->vector[v122] = v129;
		          Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager;
		          m_csmScreenSizeMinSquareds = (__int64)TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_cascadeRenderFlags;
		          if ( !m_csmScreenSizeMinSquareds )
		            goto LABEL_125;
		          if ( v122 >= *(_DWORD *)(m_csmScreenSizeMinSquareds + 24) )
		            goto LABEL_106;
		          v130 = UnityEngine::HyperGryph::HGTreeRender::CreateRendererList(
		                   *(_DWORD *)&v124[v123],
		                   (HGRenderFlags__Enum)(*(_DWORD *)(m_csmScreenSizeMinSquareds + 4LL * (int)v122 + 32) | 0x2080100),
		                   (HGRenderFlags__Enum)(TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_cascadeRenderFlags->vector[v122] | 0x2080100),
		                   HGShaderLightMode__Enum_ShadowCaster,
		                   context.m_Ptr,
		                   0,
		                   0LL);
		          Patch = shadowTreeLists;
		          m_csmScreenSizeMinSquareds = v130;
		          if ( !shadowTreeLists )
		            goto LABEL_125;
		          if ( v122 >= shadowTreeLists->max_length.size )
		            goto LABEL_106;
		        }
		        v131 = (int)v122;
		        v123 += 4LL;
		        ++v122;
		        *((_DWORD *)Patch + v131 + 8) = m_csmScreenSizeMinSquareds;
		      }
		      while ( (int)v122 < cascadeCount );
		    }
		    Unity::Collections::NativeArray<BeyondDynamicBone::TeamManager::TeamData>::Dispose(
		      (NativeArray_1_BeyondDynamicBone_TeamManager_TeamData_ *)&v155,
		      MethodInfo::Unity::Collections::NativeArray<unsigned int>::Dispose);
		    v132 = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		    v133 = *(_OWORD *)&v132->zeroMatrix.m00;
		    v134 = *(_OWORD *)&v132->zeroMatrix.m01;
		    v135 = *(_OWORD *)&v132->zeroMatrix.m03;
		    *(_OWORD *)&v145.m02 = *(_OWORD *)&v132->zeroMatrix.m02;
		    if ( !UnityEngine::SystemInfo::UsesReversedZBuffer(0LL) )
		      v51 = 0.0;
		    v145.m22 = v51;
		    if ( cascadeCount <= 4 )
		    {
		      v136 = *(_OWORD *)&v145.m02;
		      while ( *shadowRequest )
		      {
		        Patch = (*shadowRequest)->fields.worldToShadowMatrices;
		        if ( !Patch )
		          break;
		        *(_OWORD *)&v145.m00 = v133;
		        *(_OWORD *)&v145.m01 = v134;
		        *(_OWORD *)&v145.m02 = v136;
		        *(_OWORD *)&v145.m03 = v135;
		        sub_180041540(Patch, v16++, &v145);
		        if ( v16 > 4 )
		          return;
		      }
		      goto LABEL_125;
		    }
		  }
		}
		
		private void GetManualCsmSphereMatrices(Matrix4x4 lightToWorld, Vector4 targetSphere, out Matrix4x4 projection, out Matrix4x4 view) {
			projection = default;
			view = default;
		} // 0x0000000189D2089C-0x0000000189D20B74
		// Void GetManualCsmSphereMatrices(Matrix4x4, Vector4, Matrix4x4 ByRef, Matrix4x4 ByRef)
		void HG::Rendering::Runtime::HGShadowManager::GetManualCsmSphereMatrices(
		        HGShadowManager *this,
		        Matrix4x4 *lightToWorld,
		        Vector4 *targetSphere,
		        Matrix4x4 *projection,
		        Matrix4x4 *view,
		        MethodInfo *method)
		{
		  MethodInfo *v10; // r8
		  Vector3 *v11; // rax
		  __int64 v12; // xmm6_8
		  float z; // ebx
		  float w; // xmm2_4
		  MethodInfo *v15; // r9
		  Vector3 *v16; // rax
		  __int64 v17; // xmm3_8
		  MethodInfo *v18; // r9
		  Vector3 *v19; // rax
		  __int64 *v20; // r8
		  __int64 v21; // xmm0_8
		  __int64 v22; // xmm3_8
		  MethodInfo *v23; // r9
		  Vector3 *v24; // rax
		  float v25; // xmm4_4
		  float v26; // ebx
		  Matrix4x4 *v27; // rax
		  __m128 v28; // xmm4
		  __int128 v29; // xmm1
		  __int128 v30; // xmm2
		  __int128 v31; // xmm3
		  __int128 v32; // xmm0
		  __m128 v33; // xmm1
		  __m128 v34; // xmm2
		  Matrix4x4 *inverse; // rax
		  __int128 v36; // xmm1
		  __int128 v37; // xmm2
		  __int128 v38; // xmm3
		  __int64 v39; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  __int128 v41; // xmm1
		  __int128 v42; // xmm0
		  __int128 v43; // xmm1
		  __int128 v44; // xmm0
		  Vector3 v45; // [rsp+48h] [rbp-79h] BYREF
		  Vector4 v46; // [rsp+58h] [rbp-69h] BYREF
		  Vector4 v47; // [rsp+68h] [rbp-59h] BYREF
		  Matrix4x4 v48; // [rsp+78h] [rbp-49h] BYREF
		  Matrix4x4 v49; // [rsp+B8h] [rbp-9h] BYREF
		
		  *(_QWORD *)&v48.m02 = 0LL;
		  v48.m22 = 0.0;
		  if ( IFix::WrappersManagerImpl::IsPatched(2161, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2161, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v39);
		    v41 = *(_OWORD *)&lightToWorld->m00;
		    v47 = *targetSphere;
		    v42 = *(_OWORD *)&lightToWorld->m01;
		    *(_OWORD *)&v48.m00 = v41;
		    v43 = *(_OWORD *)&lightToWorld->m02;
		    *(_OWORD *)&v48.m01 = v42;
		    v44 = *(_OWORD *)&lightToWorld->m03;
		    *(_OWORD *)&v48.m02 = v43;
		    *(_OWORD *)&v48.m03 = v44;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_862(Patch, (Object *)this, &v48, &v47, projection, view, 0LL);
		  }
		  else
		  {
		    v47 = *UnityEngine::Matrix4x4::GetColumn(&v47, lightToWorld, 2, 0LL);
		    v11 = UnityEngine::Vector4::op_Implicit((Vector3 *)&v46, &v47, v10);
		    v12 = *(_QWORD *)&v11->x;
		    z = v11->z;
		    v46 = *targetSphere;
		    HG::Rendering::Runtime::VectorSwizzleUtils::xyz((Vector3 *)&v47, &v46, 0LL);
		    w = targetSphere->w;
		    *(_QWORD *)&v45.x = v12;
		    v45.z = z;
		    v16 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v46, &v45, w, v15);
		    v17 = *(_QWORD *)&v16->x;
		    *(float *)&v16 = v16->z;
		    *(_QWORD *)&v45.x = v17;
		    LODWORD(v45.z) = (_DWORD)v16;
		    v19 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v46, &v45, 1.05, v18);
		    v21 = *v20;
		    v22 = *(_QWORD *)&v19->x;
		    v45.z = v19->z;
		    LODWORD(v19) = *((_DWORD *)v20 + 2);
		    *(_QWORD *)&v45.x = v22;
		    *(_QWORD *)&v46.x = v21;
		    LODWORD(v46.z) = (_DWORD)v19;
		    v24 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v47, (Vector3 *)&v46, &v45, v23);
		    v26 = v24->z;
		    *(_QWORD *)&v46.x = *(_QWORD *)&v24->x;
		    v27 = UnityEngine::Matrix4x4::Ortho(&v49, -v25, v25, -v25, v25, -50.0, (float)(v25 + v25) * 1.2, 0LL);
		    v28 = *(__m128 *)&lightToWorld->m02;
		    v29 = *(_OWORD *)&v27->m01;
		    v30 = *(_OWORD *)&v27->m02;
		    v31 = *(_OWORD *)&v27->m03;
		    *(_OWORD *)&projection->m00 = *(_OWORD *)&v27->m00;
		    v32 = *(_OWORD *)&lightToWorld->m03;
		    *(_OWORD *)&projection->m01 = v29;
		    v33 = *(__m128 *)&lightToWorld->m00;
		    *(_OWORD *)&v49.m03 = v32;
		    *(_OWORD *)&projection->m02 = v30;
		    v34 = *(__m128 *)&lightToWorld->m01;
		    LODWORD(v48.m00) = v33.m128_i32[0];
		    *(_OWORD *)&projection->m03 = v31;
		    LODWORD(v48.m01) = v34.m128_i32[0];
		    LODWORD(v48.m10) = _mm_shuffle_ps(v33, v33, 85).m128_u32[0];
		    *(_QWORD *)&v48.m21 = _mm_shuffle_ps(v34, v34, 170).m128_u32[0];
		    *(_QWORD *)&v48.m20 = _mm_shuffle_ps(v33, v33, 170).m128_u32[0];
		    LODWORD(v48.m11) = _mm_shuffle_ps(v34, v34, 85).m128_u32[0];
		    *(_QWORD *)&v48.m22 = COERCE_UNSIGNED_INT(-_mm_shuffle_ps(v28, v28, 170).m128_f32[0]);
		    *(_QWORD *)&v48.m03 = *(_QWORD *)&v46.x;
		    v48.m02 = -v28.m128_f32[0];
		    v48.m12 = -_mm_shuffle_ps(v28, v28, 85).m128_f32[0];
		    v48.m23 = v26;
		    v48.m33 = 1.0;
		    inverse = UnityEngine::Matrix4x4::get_inverse(&v49, &v48, 0LL);
		    v36 = *(_OWORD *)&inverse->m01;
		    v37 = *(_OWORD *)&inverse->m02;
		    v38 = *(_OWORD *)&inverse->m03;
		    *(_OWORD *)&view->m00 = *(_OWORD *)&inverse->m00;
		    *(_OWORD *)&view->m01 = v36;
		    *(_OWORD *)&view->m02 = v37;
		    *(_OWORD *)&view->m03 = v38;
		  }
		}
		
		private void CalculateDirectionalShadowParametersManualOverride(HGCamera hgCamera, CullingResults cullingResults, LightCullResult lightCullResult, int directionalLightIndex, int tileSize, Vector2Int atlasSize, int cascadeCount, float shadowIntensity, RendererList[] unityRendererLists, uint[] shadowRendererLists, uint[] shadowGrassLists, uint[] shadowTreeLists, ref CascadedShadowRequest shadowRequest, ScriptableRenderContext context) {} // 0x0000000189D1CA38-0x0000000189D1DBAC
		// Void CalculateDirectionalShadowParametersManualOverride(HGCamera, CullingResults, LightCullResult, Int32, Int32, Vector2Int, Int32, Single, RendererList[], UInt32[], UInt32[], UInt32[], HGShadowManager+CascadedShadowRequest ByRef, ScriptableRenderContext)
		void HG::Rendering::Runtime::HGShadowManager::CalculateDirectionalShadowParametersManualOverride(
		        HGShadowManager *this,
		        HGCamera *hgCamera,
		        CullingResults *cullingResults,
		        LightCullResult *lightCullResult,
		        int32_t directionalLightIndex,
		        int32_t tileSize,
		        Vector2Int atlasSize,
		        int32_t cascadeCount,
		        float shadowIntensity,
		        RendererList__Array *unityRendererLists,
		        UInt32__Array *shadowRendererLists,
		        UInt32__Array *shadowGrassLists,
		        UInt32__Array *shadowTreeLists,
		        HGShadowManager_CascadedShadowRequest **shadowRequest,
		        ScriptableRenderContext context,
		        MethodInfo *method)
		{
		  int32_t v16; // r14d
		  __int64 v21; // r12
		  __int64 m_csmScreenSizeMinSquareds; // rdx
		  void *Patch; // rcx
		  Matrix4x4__StaticFields *static_fields; // rax
		  __int128 v25; // xmm1
		  __int128 v26; // xmm0
		  __int128 v27; // xmm1
		  __int128 v28; // xmm1
		  __int128 v29; // xmm0
		  __int128 v30; // xmm1
		  HGEnvironmentVolumeCameraComponent *envVolumeCameraComponent; // rbx
		  Light *light; // rax
		  HGEnvironmentVolumeCameraComponent *v33; // rax
		  HGEnvironmentPhase *interpolatedPhase; // rax
		  __int128 v35; // xmm1
		  __int128 v36; // xmm2
		  __int128 v37; // xmm3
		  __int128 v38; // xmm4
		  Matrix4x4 *localToWorldMatrix; // rax
		  Vector4 m_csmManualOverrideSphere; // xmm0
		  __int128 v41; // xmm13
		  __int128 v42; // xmm14
		  __int128 v43; // xmm15
		  __int128 v44; // xmm10
		  __int128 v45; // xmm11
		  Matrix4x4 *v46; // rax
		  __int128 v47; // xmm6
		  __int128 v48; // xmm7
		  __int128 v49; // xmm8
		  __int128 v50; // xmm9
		  HGShadowManager__StaticFields *v51; // rdx
		  int32_t v52; // edi
		  __int128 v53; // xmm9
		  float v54; // xmm12_4
		  Void *v55; // r12
		  int32_t m_csmOcclusionDepthSize; // r12d
		  Matrix4x4__Array *deviceProjectionYFlipMatrices; // rbx
		  Matrix4x4 *GPUProjectionMatrix; // rax
		  __int128 v59; // xmm1
		  __int128 v60; // xmm0
		  __int128 v61; // xmm1
		  struct HGShadowManager__Class *v62; // rdx
		  Plane__Array *s_tempPlanes; // rcx
		  __int64 v64; // rax
		  Camera *camera; // rbx
		  uint64_t SceneCullingMaskFromCamera; // rax
		  int v67; // r9d
		  HGObjectFlags__Enum v68; // r10d
		  int32_t v69; // ebx
		  int v70; // xmm6_4
		  __int64 (__fastcall *v71)(__int64, _QWORD, _QWORD, unsigned __int64, int32_t, int, int, LODCrossFadeConfig *, int, int, _DWORD, int32_t, int32_t, _BYTE *, __int64 *, __int128 *, _DWORD, int); // rax
		  int v72; // eax
		  Void *v73; // r12
		  __int128 v74; // xmm6
		  __int128 v75; // xmm7
		  Matrix4x4 *ShadowTransform; // rax
		  __int128 v77; // xmm1
		  __int128 v78; // xmm0
		  __int128 v79; // xmm1
		  Vector4__Array *cascadeShadowBiases; // rbx
		  float m_csmDepthBias; // xmm3_4
		  Vector4 *ShadowBias; // rax
		  __m128 v83; // xmm6
		  __m128 v84; // xmm7
		  __int64 v85; // rax
		  __int64 v86; // rax
		  int32_t v87; // edi
		  Matrix4x4 *v88; // rax
		  __int128 v89; // xmm10
		  __int128 v90; // xmm11
		  __int128 v91; // xmm12
		  __int128 v92; // xmm13
		  HGShadowManager__StaticFields *v93; // rdx
		  int32_t i; // ebx
		  __int64 v95; // r9
		  CullingResults v96; // xmm6
		  Camera *v97; // r9
		  unsigned int v98; // esi
		  Void *v99; // rbx
		  HGRenderFlags__Enum__Array *m_cascadeRenderFlags; // rdi
		  HGRenderFlags__Enum v101; // edi
		  HGRenderFlags__Enum v102; // ebx
		  uint32_t RendererList; // eax
		  uint32_t v104; // eax
		  uint32_t v105; // eax
		  __int64 v106; // rax
		  Matrix4x4__StaticFields *v107; // rcx
		  __int128 v108; // xmm7
		  __int128 v109; // xmm8
		  __int128 v110; // xmm9
		  __int128 v111; // xmm6
		  CullingResults v112; // xmm1
		  HGRenderKeyword__Enum methoda; // [rsp+28h] [rbp-F0h]
		  float methodb; // [rsp+28h] [rbp-F0h]
		  unsigned int contexta; // [rsp+30h] [rbp-E8h]
		  __m128 v116; // [rsp+98h] [rbp-80h] BYREF
		  Matrix4x4 v117; // [rsp+A8h] [rbp-70h] BYREF
		  ShaderTagId v118; // [rsp+E8h] [rbp-30h] BYREF
		  uint32_t viewHandle[2]; // [rsp+F0h] [rbp-28h]
		  __int64 v120; // [rsp+F8h] [rbp-20h]
		  __m128 v121; // [rsp+108h] [rbp-10h] BYREF
		  int v122; // [rsp+118h] [rbp+0h]
		  int v123; // [rsp+11Ch] [rbp+4h]
		  int32_t cullingMask; // [rsp+120h] [rbp+8h]
		  Void *m_Buffer; // [rsp+128h] [rbp+10h]
		  __int64 v126; // [rsp+130h] [rbp+18h] BYREF
		  int v127; // [rsp+138h] [rbp+20h]
		  Matrix4x4 v128; // [rsp+148h] [rbp+30h] BYREF
		  _DWORD v129[2]; // [rsp+188h] [rbp+70h] BYREF
		  Void *v130; // [rsp+190h] [rbp+78h]
		  NativeArray_1_System_UInt32_ v131; // [rsp+198h] [rbp+80h] BYREF
		  Matrix4x4 v132; // [rsp+1A8h] [rbp+90h] BYREF
		  Vector4 v133; // [rsp+1E8h] [rbp+D0h] BYREF
		  __int128 v134; // [rsp+1F8h] [rbp+E0h] BYREF
		  Matrix4x4 v135; // [rsp+208h] [rbp+F0h] BYREF
		  Vector4 v136; // [rsp+248h] [rbp+130h] BYREF
		  Matrix4x4 v137; // [rsp+258h] [rbp+140h] BYREF
		  _BYTE v138[64]; // [rsp+298h] [rbp+180h] BYREF
		  VisibleLight v139; // [rsp+2D8h] [rbp+1C0h] BYREF
		  RendererListDesc v140; // [rsp+378h] [rbp+260h] BYREF
		  RendererListDesc v141; // [rsp+458h] [rbp+340h] BYREF
		  ScriptableCullingParameters cullingParameters; // [rsp+538h] [rbp+420h] BYREF
		
		  v16 = cascadeCount;
		  sub_18033B9D0(&v139, 0LL, 148LL);
		  v131 = 0LL;
		  sub_18033B9D0(v138, 0LL, 64LL);
		  v126 = 0LL;
		  v127 = 0;
		  v134 = 0LL;
		  sub_18033B9D0(&cullingParameters, 0LL, 1592LL);
		  v21 = 0LL;
		  v118.m_Id = 0;
		  sub_18033B9D0(&v140, 0LL, 224LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(2160, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2160, 0LL);
		    if ( !Patch )
		      goto LABEL_96;
		    v112 = *cullingResults;
		    v131 = (NativeArray_1_System_UInt32_)*lightCullResult;
		    v116 = (__m128)v112;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_863(
		      (ILFixDynamicMethodWrapper_2 *)Patch,
		      (Object *)this,
		      (Object *)hgCamera,
		      (CullingResults *)&v116,
		      (LightCullResult *)&v131,
		      directionalLightIndex,
		      tileSize,
		      atlasSize,
		      cascadeCount,
		      shadowIntensity,
		      (Object *)unityRendererLists,
		      (Object *)shadowRendererLists,
		      (Object *)shadowGrassLists,
		      (Object *)shadowTreeLists,
		      shadowRequest,
		      context,
		      0LL);
		  }
		  else
		  {
		    Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::ConvertExistingDataToNativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>(
		      (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v116,
		      (Void *)lightCullResult->visibleLightsPtr,
		      lightCullResult->visibleLightCount,
		      Allocator__Enum_None,
		      MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::ConvertExistingDataToNativeArray<UnityEngine::Rendering::VisibleLight>);
		    m_csmScreenSizeMinSquareds = directionalLightIndex;
		    Patch = &v139;
		    v139 = *(VisibleLight *)(148LL * directionalLightIndex + v116.m128_u64[0]);
		    if ( !*shadowRequest )
		      goto LABEL_96;
		    (*shadowRequest)->fields.directionalLightIndex = directionalLightIndex;
		    if ( !*shadowRequest )
		      goto LABEL_96;
		    (*shadowRequest)->fields.directionalShadowMapTileSize = tileSize;
		    Patch = *shadowRequest;
		    if ( !*shadowRequest )
		      goto LABEL_96;
		    *((Vector2Int *)Patch + 5) = atlasSize;
		    if ( !*shadowRequest )
		      goto LABEL_96;
		    (*shadowRequest)->fields.cascadeCount = cascadeCount;
		    Patch = TypeInfo::UnityEngine::Matrix4x4;
		    static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		    v25 = *(_OWORD *)&static_fields->identityMatrix.m01;
		    *(_OWORD *)&v132.m00 = *(_OWORD *)&static_fields->identityMatrix.m00;
		    v26 = *(_OWORD *)&static_fields->identityMatrix.m02;
		    *(_OWORD *)&v132.m01 = v25;
		    v27 = *(_OWORD *)&static_fields->identityMatrix.m03;
		    *(_OWORD *)&v132.m02 = v26;
		    *(_OWORD *)&v132.m03 = v27;
		    v28 = *(_OWORD *)&static_fields->identityMatrix.m01;
		    *(_OWORD *)&v135.m00 = *(_OWORD *)&static_fields->identityMatrix.m00;
		    v29 = *(_OWORD *)&static_fields->identityMatrix.m02;
		    *(_OWORD *)&v135.m01 = v28;
		    v30 = *(_OWORD *)&static_fields->identityMatrix.m03;
		    *(_OWORD *)&v135.m02 = v29;
		    *(_OWORD *)&v135.m03 = v30;
		    LOBYTE(Patch) = this->fields.m_useShadowMapCache;
		    if ( !*shadowRequest )
		      goto LABEL_96;
		    (*shadowRequest)->fields.useCache = (char)Patch;
		    if ( !*shadowRequest )
		      goto LABEL_96;
		    (*shadowRequest)->fields.directionalShadowStrength = shadowIntensity;
		    Unity::Collections::NativeArray<unsigned int>::NativeArray(
		      &v131,
		      cascadeCount,
		      Allocator__Enum_Temp,
		      NativeArrayOptions__Enum_ClearMemory,
		      MethodInfo::Unity::Collections::NativeArray<unsigned int>::NativeArray);
		    if ( !hgCamera )
		      goto LABEL_96;
		    envVolumeCameraComponent = HG::Rendering::Runtime::HGCamera::get_envVolumeCameraComponent(hgCamera, 0LL);
		    light = UnityEngine::Rendering::VisibleLight::get_light(&v139, 0LL);
		    if ( !envVolumeCameraComponent )
		      goto LABEL_96;
		    if ( HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::UseDirLightDataFromEnvDirectly(
		           envVolumeCameraComponent,
		           light,
		           0LL) )
		    {
		      v33 = HG::Rendering::Runtime::HGCamera::get_envVolumeCameraComponent(hgCamera, 0LL);
		      if ( !v33 )
		        goto LABEL_96;
		      interpolatedPhase = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedPhase(v33, 0LL);
		      if ( !interpolatedPhase )
		        goto LABEL_96;
		      v35 = *(_OWORD *)&interpolatedPhase->fields.lightConfig.localToWorld.m00;
		      v36 = *(_OWORD *)&interpolatedPhase->fields.lightConfig.localToWorld.m01;
		      v37 = *(_OWORD *)&interpolatedPhase->fields.lightConfig.localToWorld.m02;
		      v38 = *(_OWORD *)&interpolatedPhase->fields.lightConfig.localToWorld.m03;
		    }
		    else
		    {
		      localToWorldMatrix = UnityEngine::HGSharedLightData::get_localToWorldMatrix(&v117, &v139.hgSharedLightData, 0LL);
		      v35 = *(_OWORD *)&localToWorldMatrix->m00;
		      v36 = *(_OWORD *)&localToWorldMatrix->m01;
		      v37 = *(_OWORD *)&localToWorldMatrix->m02;
		      v38 = *(_OWORD *)&localToWorldMatrix->m03;
		    }
		    m_csmManualOverrideSphere = this->fields.m_csmManualOverrideSphere;
		    *(_OWORD *)&v128.m00 = v35;
		    *(_OWORD *)&v128.m01 = v36;
		    *(_OWORD *)&v128.m02 = v37;
		    *(_OWORD *)&v128.m03 = v38;
		    v116 = (__m128)m_csmManualOverrideSphere;
		    HG::Rendering::Runtime::HGShadowManager::GetManualCsmSphereMatrices(
		      this,
		      &v128,
		      (Vector4 *)&v116,
		      &v135,
		      &v132,
		      0LL);
		    v41 = *(_OWORD *)&v132.m00;
		    v42 = *(_OWORD *)&v135.m00;
		    v43 = *(_OWORD *)&v135.m01;
		    v44 = *(_OWORD *)&v135.m02;
		    v45 = *(_OWORD *)&v135.m03;
		    v128 = v132;
		    v117 = v135;
		    v46 = UnityEngine::Matrix4x4::op_Multiply(&v137, &v117, &v128, 0LL);
		    v47 = *(_OWORD *)&v46->m00;
		    v48 = *(_OWORD *)&v46->m01;
		    v49 = *(_OWORD *)&v46->m02;
		    v50 = *(_OWORD *)&v46->m03;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		    *(_OWORD *)&v117.m00 = v47;
		    *(_OWORD *)&v117.m01 = v48;
		    *(_OWORD *)&v117.m02 = v49;
		    v51 = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		    *(_OWORD *)&v117.m03 = v50;
		    UnityEngine::GeometryUtility::CalculateFrustumPlanes(&v117, v51->s_tempPlanes, 0LL);
		    v52 = 0;
		    v53 = *(_OWORD *)&v132.m01;
		    v54 = 0.0;
		    m_Buffer = v131.m_Buffer;
		    if ( cascadeCount > 0 )
		    {
		      v55 = v131.m_Buffer;
		      v130 = v131.m_Buffer;
		      do
		      {
		        *(_DWORD *)v55 = -1;
		        m_csmOcclusionDepthSize = 0;
		        if ( !*shadowRequest )
		          goto LABEL_96;
		        deviceProjectionYFlipMatrices = (*shadowRequest)->fields.deviceProjectionYFlipMatrices;
		        *(_OWORD *)&v117.m00 = v42;
		        *(_OWORD *)&v117.m01 = v43;
		        *(_OWORD *)&v117.m02 = v44;
		        *(_OWORD *)&v117.m03 = v45;
		        GPUProjectionMatrix = UnityEngine::GL::GetGPUProjectionMatrix(&v137, &v117, 1, 0LL);
		        if ( !deviceProjectionYFlipMatrices )
		          goto LABEL_96;
		        v59 = *(_OWORD *)&GPUProjectionMatrix->m01;
		        *(_OWORD *)&v128.m00 = *(_OWORD *)&GPUProjectionMatrix->m00;
		        v60 = *(_OWORD *)&GPUProjectionMatrix->m02;
		        *(_OWORD *)&v128.m01 = v59;
		        v61 = *(_OWORD *)&GPUProjectionMatrix->m03;
		        *(_OWORD *)&v128.m02 = v60;
		        *(_OWORD *)&v128.m03 = v61;
		        sub_180041540(deviceProjectionYFlipMatrices, v52, &v128);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		        v62 = TypeInfo::HG::Rendering::Runtime::HGShadowManager;
		        s_tempPlanes = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->s_tempPlanes;
		        if ( !s_tempPlanes )
		          goto LABEL_22;
		        if ( s_tempPlanes->max_length.size )
		        {
		          v64 = sub_180002100(s_tempPlanes, 0LL);
		          v62 = TypeInfo::HG::Rendering::Runtime::HGShadowManager;
		          v120 = v64;
		        }
		        else
		        {
		LABEL_22:
		          v120 = 0LL;
		        }
		        sub_1800036A0(v62);
		        Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		        *(_QWORD *)viewHandle = *((_QWORD *)Patch + 15);
		        if ( !*(_QWORD *)viewHandle )
		          goto LABEL_96;
		        camera = hgCamera->fields.camera;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        SceneCullingMaskFromCamera = HG::Rendering::Runtime::HGUtils::GetSceneCullingMaskFromCamera(camera, 0LL);
		        Patch = hgCamera->fields.camera;
		        v121.m128_u64[0] = SceneCullingMaskFromCamera;
		        if ( !Patch )
		          goto LABEL_96;
		        cullingMask = UnityEngine::Camera::get_cullingMask((Camera *)Patch, 0LL);
		        Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		        m_csmScreenSizeMinSquareds = *((_QWORD *)Patch + 16);
		        if ( !m_csmScreenSizeMinSquareds )
		          goto LABEL_96;
		        if ( (unsigned int)v52 >= *(_DWORD *)(m_csmScreenSizeMinSquareds + 24) )
		          goto LABEL_78;
		        v67 = *(_DWORD *)(m_csmScreenSizeMinSquareds + 4LL * v52 + 32);
		        Patch = (void *)v52;
		        v68 = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_cascadeObjectFlags->vector[v52];
		        m_csmScreenSizeMinSquareds = (__int64)this->fields.m_csmScreenSizeMinSquareds;
		        if ( !m_csmScreenSizeMinSquareds )
		          goto LABEL_96;
		        if ( (unsigned int)v52 >= *(_DWORD *)(m_csmScreenSizeMinSquareds + 24) )
		          goto LABEL_78;
		        Patch = this->fields.m_csmEnableOcclusionCulling;
		        if ( !Patch )
		          goto LABEL_96;
		        if ( (unsigned int)v52 >= *((_DWORD *)Patch + 6) )
		          goto LABEL_78;
		        if ( *((_BYTE *)Patch + v52 + 32) )
		        {
		          m_csmOcclusionDepthSize = this->fields.m_csmOcclusionDepthSize;
		          v69 = m_csmOcclusionDepthSize;
		        }
		        else
		        {
		          v69 = 0;
		        }
		        v70 = *(_DWORD *)(m_csmScreenSizeMinSquareds + 4LL * v52 + 32);
		        viewHandle[0] = *(_DWORD *)(*(_QWORD *)viewHandle + 24LL);
		        v123 = v67 | 0x8000002;
		        v122 = v68 | 0x8000002;
		        sub_18033B9D0(v138, 0LL, 64LL);
		        v126 = 0LL;
		        v127 = 0;
		        v71 = (__int64 (__fastcall *)(__int64, _QWORD, _QWORD, unsigned __int64, int32_t, int, int, LODCrossFadeConfig *, int, int, _DWORD, int32_t, int32_t, _BYTE *, __int64 *, __int128 *, _DWORD, int))qword_18F3AB290;
		        v134 = 0LL;
		        if ( !qword_18F3AB290 )
		        {
		          v71 = (__int64 (__fastcall *)(__int64, _QWORD, _QWORD, unsigned __int64, int32_t, int, int, LODCrossFadeConfig *, int, int, _DWORD, int32_t, int32_t, _BYTE *, __int64 *, __int128 *, _DWORD, int))sub_180059EA0("UnityEngine.HyperGryph.HGCullingSystem::AddCullViewByPlanes(System.IntPtr,System.Int32,System.Int32,System.UInt64,System.UInt32,System.UInt32,System.UInt32,UnityEngine.HyperGryph.LODCrossFadeConfig&,System.Single,UnityEngine.CameraType,System.UInt32,System.Int32,System.Int32,UnityEngine.Matrix4x4&,UnityEngine.Vector3&,UnityEngine.Vector4&,System.Single,System.Single)");
		          qword_18F3AB290 = (__int64)v71;
		        }
		        v72 = v71(
		                v120,
		                viewHandle[0],
		                0LL,
		                v121.m128_u64[0],
		                cullingMask,
		                v123,
		                v122,
		                &hgCamera->fields.lodCrossFadeConfig,
		                v70,
		                32,
		                0,
		                m_csmOcclusionDepthSize,
		                v69,
		                v138,
		                &v126,
		                &v134,
		                0,
		                1028443341);
		        v73 = v130;
		        *(_DWORD *)v130 = v72;
		        Patch = *shadowRequest;
		        if ( !*shadowRequest )
		          goto LABEL_96;
		        Patch = (void *)*((_QWORD *)Patch + 7);
		        if ( !Patch )
		          goto LABEL_96;
		        v74 = *(_OWORD *)&v132.m02;
		        v75 = *(_OWORD *)&v132.m03;
		        *(_OWORD *)&v117.m02 = *(_OWORD *)&v132.m02;
		        *(_OWORD *)&v117.m03 = *(_OWORD *)&v132.m03;
		        *(_OWORD *)&v117.m00 = v41;
		        *(_OWORD *)&v117.m01 = v53;
		        sub_180041540(Patch, v52, &v117);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
		        *(_OWORD *)&v117.m00 = v41;
		        *(_OWORD *)&v117.m01 = v53;
		        *(_OWORD *)&v117.m02 = v74;
		        *(_OWORD *)&v117.m03 = v75;
		        *(_OWORD *)&v128.m00 = v42;
		        *(_OWORD *)&v128.m01 = v43;
		        *(_OWORD *)&v128.m02 = v44;
		        *(_OWORD *)&v128.m03 = v45;
		        ShadowTransform = HG::Rendering::Runtime::HGShadowUtils::GetShadowTransform(&v137, &v128, &v117, 0LL);
		        Patch = *shadowRequest;
		        if ( !*shadowRequest )
		          goto LABEL_96;
		        Patch = (void *)*((_QWORD *)Patch + 10);
		        if ( !Patch )
		          goto LABEL_96;
		        v77 = *(_OWORD *)&ShadowTransform->m01;
		        *(_OWORD *)&v117.m00 = *(_OWORD *)&ShadowTransform->m00;
		        v78 = *(_OWORD *)&ShadowTransform->m02;
		        *(_OWORD *)&v117.m01 = v77;
		        v79 = *(_OWORD *)&ShadowTransform->m03;
		        *(_OWORD *)&v117.m02 = v78;
		        *(_OWORD *)&v117.m03 = v79;
		        sub_180041540(Patch, v52, &v117);
		        Patch = *shadowRequest;
		        v121 = (__m128)_mm_loadu_si128((const __m128i *)&this->fields.m_csmManualOverrideSphere);
		        *(float *)&v78 = _mm_shuffle_ps(v121, v121, 255).m128_f32[0];
		        v121.m128_f32[3] = *(float *)&v78 * *(float *)&v78;
		        if ( !Patch )
		          goto LABEL_96;
		        Patch = (void *)*((_QWORD *)Patch + 11);
		        if ( !Patch )
		          goto LABEL_96;
		        sub_18003FEF0(Patch, v52, &v121);
		        if ( !*shadowRequest )
		          goto LABEL_96;
		        cascadeShadowBiases = (*shadowRequest)->fields.cascadeShadowBiases;
		        m_csmDepthBias = this->fields.m_csmDepthBias;
		        contexta = this->fields.m_csmShadowSampleMode;
		        methodb = this->fields.m_csmNormalBias;
		        *(_OWORD *)&v117.m00 = v42;
		        *(_OWORD *)&v117.m01 = v43;
		        *(_OWORD *)&v117.m02 = v44;
		        *(_OWORD *)&v117.m03 = v45;
		        ShadowBias = HG::Rendering::Runtime::HGShadowUtils::GetShadowBias(
		                       &v136,
		                       &v117,
		                       (float)tileSize,
		                       m_csmDepthBias,
		                       methodb,
		                       (HGShadowSampleMode__Enum)contexta,
		                       0LL);
		        if ( !cascadeShadowBiases )
		          goto LABEL_96;
		        v121 = *(__m128 *)ShadowBias;
		        sub_18003FEF0(cascadeShadowBiases, v52, &v121);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		        Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_atlasScales;
		        if ( !Patch )
		          goto LABEL_96;
		        sub_1800473A0(Patch, v129, cascadeCount - 1LL);
		        v83 = (__m128)v129[0];
		        v84 = (__m128)v129[1];
		        Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_atlasOffsets;
		        if ( !Patch )
		          goto LABEL_96;
		        sub_1800473A0(Patch, &v133, v52);
		        v85 = sub_185EDCFF4(*(_QWORD *)&v133.x, _mm_unpacklo_ps(v83, v84).m128_u64[0]);
		        Patch = *shadowRequest;
		        v120 = v85;
		        if ( !Patch )
		          goto LABEL_96;
		        Patch = (void *)*((_QWORD *)Patch + 13);
		        v116.m128_u64[0] = v120;
		        v116.m128_i32[2] = v83.m128_i32[0];
		        v116.m128_i32[3] = v84.m128_i32[0];
		        if ( !Patch )
		          goto LABEL_96;
		        v121 = v116;
		        sub_18003FEF0(Patch, v52, &v121);
		        Patch = *shadowRequest;
		        if ( !*shadowRequest )
		          goto LABEL_96;
		        Patch = (void *)*((_QWORD *)Patch + 3);
		        if ( !Patch )
		          goto LABEL_96;
		        if ( (unsigned int)v52 >= *((_DWORD *)Patch + 6) )
		LABEL_78:
		          sub_1800D2AB0(Patch, m_csmScreenSizeMinSquareds);
		        v86 = v52;
		        v55 = v73 + 4;
		        ++v52;
		        v130 = v55;
		        *((_BYTE *)Patch + v86 + 32) = 1;
		      }
		      while ( v52 < cascadeCount );
		      v21 = 0LL;
		    }
		    UnityEngine::HyperGryph::HGCullingSystem::DispatchBatchCullingJobs(0LL);
		    v87 = 0;
		    if ( cascadeCount > 0 )
		    {
		      do
		      {
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList);
		        Patch = TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList->static_fields;
		        if ( !unityRendererLists )
		          goto LABEL_96;
		        v116 = *(__m128 *)Patch;
		        sub_180430AC4(unityRendererLists, v87, &v116);
		        *(_OWORD *)&v117.m02 = *(_OWORD *)&v132.m02;
		        *(_OWORD *)&v117.m03 = *(_OWORD *)&v132.m03;
		        *(_OWORD *)&v117.m00 = v41;
		        *(_OWORD *)&v117.m01 = v53;
		        *(_OWORD *)&v128.m00 = v42;
		        *(_OWORD *)&v128.m01 = v43;
		        *(_OWORD *)&v128.m02 = v44;
		        *(_OWORD *)&v128.m03 = v45;
		        v88 = UnityEngine::Matrix4x4::op_Multiply(&v137, &v128, &v117, 0LL);
		        v89 = *(_OWORD *)&v88->m00;
		        v90 = *(_OWORD *)&v88->m01;
		        v91 = *(_OWORD *)&v88->m02;
		        v92 = *(_OWORD *)&v88->m03;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		        *(_OWORD *)&v117.m00 = v89;
		        *(_OWORD *)&v117.m01 = v90;
		        *(_OWORD *)&v117.m02 = v91;
		        v93 = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		        *(_OWORD *)&v117.m03 = v92;
		        UnityEngine::GeometryUtility::CalculateFrustumPlanes(&v117, v93->s_tempPlanes, 0LL);
		        if ( !UnityEngine::HyperGryph::HGGraphicsUtils::get_enableECSRenderer(0LL) )
		        {
		          Patch = hgCamera->fields.camera;
		          if ( !Patch )
		            goto LABEL_96;
		          UnityEngine::Camera::TryGetCullingParameters((Camera *)Patch, &cullingParameters, 0LL);
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
		          *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m20 = v89;
		          *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m21 = v90;
		          *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m22 = v91;
		          *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m23 = v92;
		          UnityEngine::Rendering::ScriptableCullingParameters::set_isOrthographic(&cullingParameters, 1, 0LL);
		          cullingParameters.m_CameraProperties.cameraWorldToClip.m31 = 0.0;
		          for ( i = 0; i < 6; ++i )
		          {
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		            Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->s_tempPlanes;
		            if ( !Patch )
		              goto LABEL_96;
		            sub_180002990(Patch, &v133, i, v95);
		            sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
		            v116 = (__m128)v133;
		            UnityEngine::Rendering::ScriptableCullingParameters::SetCullingPlane(
		              &cullingParameters,
		              i,
		              (Plane *)&v116,
		              0LL);
		          }
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		          v96 = *UnityEngine::Rendering::ScriptableRenderContext::Cull(
		                   (CullingResults *)&v136,
		                   &context,
		                   &cullingParameters,
		                   0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
		          UnityEngine::Rendering::ShaderTagId::ShaderTagId(
		            &v118,
		            TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ShadowCasterStr,
		            0LL);
		          v97 = hgCamera->fields.camera;
		          v116 = (__m128)v96;
		          UnityEngine::Rendering::RendererUtils::RendererListDesc::RendererListDesc(
		            &v140,
		            v118,
		            (CullingResults *)&v116,
		            v97,
		            0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
		          v140.renderQueueRange = TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_AllOpaque;
		          v140.sortingCriteria = 59;
		          v140.rendererConfiguration = 30720;
		          v141 = v140;
		          v116 = *(__m128 *)UnityEngine::Rendering::ScriptableRenderContext::CreateRendererList(
		                              (RendererList *)&v121,
		                              &context,
		                              &v141,
		                              0LL);
		          sub_180430AC4(unityRendererLists, v87, &v116);
		        }
		        v44 = *(_OWORD *)&v135.m02;
		        ++v87;
		        v45 = *(_OWORD *)&v135.m03;
		        v41 = *(_OWORD *)&v132.m00;
		        v53 = *(_OWORD *)&v132.m01;
		      }
		      while ( v87 < cascadeCount );
		      v54 = 0.0;
		    }
		    v98 = 0;
		    if ( cascadeCount > 0 )
		    {
		      Patch = shadowTreeLists;
		      v99 = m_Buffer;
		      do
		      {
		        m_csmScreenSizeMinSquareds = 0xFFFFFFFFLL;
		        if ( *(_DWORD *)&v99[v21] == -1 )
		        {
		          if ( !shadowRendererLists )
		            goto LABEL_96;
		          if ( v98 >= shadowRendererLists->max_length.size )
		            goto LABEL_78;
		          shadowRendererLists->vector[v98] = -1;
		          if ( !shadowGrassLists )
		            goto LABEL_96;
		          if ( v98 >= shadowGrassLists->max_length.size )
		            goto LABEL_78;
		          shadowGrassLists->vector[v98] = -1;
		          if ( !Patch )
		            goto LABEL_96;
		          if ( v98 >= *((_DWORD *)Patch + 6) )
		            goto LABEL_78;
		          v99 = m_Buffer;
		        }
		        else
		        {
		          viewHandle[0] = *(_DWORD *)&v99[v21];
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		          Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager;
		          m_cascadeRenderFlags = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_cascadeRenderFlags;
		          if ( !m_cascadeRenderFlags )
		            goto LABEL_96;
		          if ( v98 >= m_cascadeRenderFlags->max_length.size )
		            goto LABEL_78;
		          v101 = m_cascadeRenderFlags->vector[v98];
		          v102 = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_cascadeRenderFlags->vector[v98];
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		          LOWORD(methoda) = 0;
		          RendererList = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		                           viewHandle[0],
		                           (HGRenderFlags__Enum)(v101 | 0x2080100),
		                           (HGRenderFlags__Enum)(v102 | 0x2080100),
		                           HGShaderLightMode__Enum_ShadowCaster,
		                           methoda,
		                           context.m_Ptr,
		                           0,
		                           0,
		                           0xFFFFFFFF,
		                           0,
		                           0,
		                           0LL);
		          if ( !shadowRendererLists )
		            goto LABEL_96;
		          if ( v98 >= shadowRendererLists->max_length.size )
		            goto LABEL_78;
		          shadowRendererLists->vector[v98] = RendererList;
		          Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager;
		          m_csmScreenSizeMinSquareds = (__int64)TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_cascadeRenderFlags;
		          if ( !m_csmScreenSizeMinSquareds )
		            goto LABEL_96;
		          if ( v98 >= *(_DWORD *)(m_csmScreenSizeMinSquareds + 24) )
		            goto LABEL_78;
		          v99 = m_Buffer;
		          v104 = UnityEngine::HyperGryph::HGGrassRender::CreateRendererList(
		                   *(_DWORD *)&m_Buffer[v21],
		                   (HGRenderFlags__Enum)(*(_DWORD *)(m_csmScreenSizeMinSquareds + 4LL * (int)v98 + 32) | 0x2080100),
		                   (HGRenderFlags__Enum)(TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_cascadeRenderFlags->vector[v98] | 0x2080100),
		                   HGShaderLightMode__Enum_ShadowCaster,
		                   context.m_Ptr,
		                   0,
		                   0LL);
		          if ( !shadowGrassLists )
		            goto LABEL_96;
		          if ( v98 >= shadowGrassLists->max_length.size )
		            goto LABEL_78;
		          shadowGrassLists->vector[v98] = v104;
		          Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager;
		          m_csmScreenSizeMinSquareds = (__int64)TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_cascadeRenderFlags;
		          if ( !m_csmScreenSizeMinSquareds )
		            goto LABEL_96;
		          if ( v98 >= *(_DWORD *)(m_csmScreenSizeMinSquareds + 24) )
		            goto LABEL_78;
		          v105 = UnityEngine::HyperGryph::HGTreeRender::CreateRendererList(
		                   *(_DWORD *)&v99[v21],
		                   (HGRenderFlags__Enum)(*(_DWORD *)(m_csmScreenSizeMinSquareds + 4LL * (int)v98 + 32) | 0x2080100),
		                   (HGRenderFlags__Enum)(TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->m_cascadeRenderFlags->vector[v98] | 0x2080100),
		                   HGShaderLightMode__Enum_ShadowCaster,
		                   context.m_Ptr,
		                   0,
		                   0LL);
		          Patch = shadowTreeLists;
		          m_csmScreenSizeMinSquareds = v105;
		          if ( !shadowTreeLists )
		            goto LABEL_96;
		          if ( v98 >= shadowTreeLists->max_length.size )
		            goto LABEL_78;
		        }
		        v106 = (int)v98;
		        v21 += 4LL;
		        ++v98;
		        *((_DWORD *)Patch + v106 + 8) = m_csmScreenSizeMinSquareds;
		      }
		      while ( (int)v98 < cascadeCount );
		    }
		    Unity::Collections::NativeArray<BeyondDynamicBone::TeamManager::TeamData>::Dispose(
		      (NativeArray_1_BeyondDynamicBone_TeamManager_TeamData_ *)&v131,
		      MethodInfo::Unity::Collections::NativeArray<unsigned int>::Dispose);
		    v107 = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		    v108 = *(_OWORD *)&v107->zeroMatrix.m00;
		    v109 = *(_OWORD *)&v107->zeroMatrix.m01;
		    v110 = *(_OWORD *)&v107->zeroMatrix.m03;
		    *(_OWORD *)&v117.m02 = *(_OWORD *)&v107->zeroMatrix.m02;
		    if ( UnityEngine::SystemInfo::UsesReversedZBuffer(0LL) )
		      v54 = 1.0;
		    v117.m22 = v54;
		    if ( cascadeCount <= 4 )
		    {
		      v111 = *(_OWORD *)&v117.m02;
		      while ( *shadowRequest )
		      {
		        Patch = (*shadowRequest)->fields.worldToShadowMatrices;
		        if ( !Patch )
		          break;
		        *(_OWORD *)&v117.m00 = v108;
		        *(_OWORD *)&v117.m01 = v109;
		        *(_OWORD *)&v117.m02 = v111;
		        *(_OWORD *)&v117.m03 = v110;
		        sub_180041540(Patch, v16++, &v117);
		        if ( v16 > 4 )
		          return;
		      }
		LABEL_96:
		      sub_1800D8260(Patch, m_csmScreenSizeMinSquareds);
		    }
		  }
		}
		
		private static void SetDirectionalLightShadowData(CascadedShadowRequest shadowRequest, int stopRenderCharacterShadowCascade) {} // 0x0000000189D24344-0x0000000189D245B8
		// Void SetDirectionalLightShadowData(HGShadowManager+CascadedShadowRequest, Int32)
		void HG::Rendering::Runtime::HGShadowManager::SetDirectionalLightShadowData(
		        HGShadowManager_CascadedShadowRequest *shadowRequest,
		        int32_t stopRenderCharacterShadowCascade,
		        MethodInfo *method)
		{
		  int v5; // ebx
		  __int64 v6; // rdi
		  int32_t v7; // ebp
		  __int64 v8; // r14
		  __int64 v9; // rdx
		  void *worldToShadowMatrices; // rcx
		  HGShadowConstantBufferUtils__StaticFields *static_fields; // r15
		  Matrix4x4 *v12; // rax
		  float Item; // xmm0_4
		  __int64 v14; // rax
		  int v15; // ebp
		  __int64 v16; // r14
		  int v17; // r15d
		  __int64 v18; // r12
		  HGShadowConstantBufferUtils__StaticFields *v19; // rbx
		  __int64 v20; // rax
		  float v21; // xmm0_4
		  int v22; // ebp
		  __int64 v23; // r14
		  int v24; // r15d
		  __int64 v25; // r12
		  HGShadowConstantBufferUtils__StaticFields *v26; // rbx
		  __int64 v27; // rax
		  HGShadowConstantBufferUtils__StaticFields *v28; // rbx
		  __int64 v29; // rax
		  float v30; // xmm0_4
		  __int64 v31; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  float v33[10]; // [rsp+20h] [rbp-28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2164, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2164, 0LL);
		    if ( !Patch )
		LABEL_21:
		      sub_1800D8260(worldToShadowMatrices, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
		      (ILFixDynamicMethodWrapper_29 *)Patch,
		      (Object *)shadowRequest,
		      stopRenderCharacterShadowCascade,
		      0LL);
		  }
		  else
		  {
		    v5 = 0;
		    v6 = 0LL;
		    do
		    {
		      v7 = 0;
		      v8 = 0LL;
		      do
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields;
		        if ( !shadowRequest )
		          goto LABEL_21;
		        worldToShadowMatrices = shadowRequest->fields.worldToShadowMatrices;
		        if ( !worldToShadowMatrices )
		          goto LABEL_21;
		        v12 = (Matrix4x4 *)sub_18049E964(worldToShadowMatrices, v5);
		        Item = UnityEngine::Matrix4x4::get_Item(v12, v7, 0LL);
		        v14 = v6 + v8;
		        ++v7;
		        ++v8;
		        *(&static_fields->shadowData._CSMWorldToShadow.FixedElementField + v14) = Item;
		      }
		      while ( v7 < 16 );
		      ++v5;
		      v6 += 16LL;
		    }
		    while ( v5 <= 4 );
		    v15 = 0;
		    v16 = 0LL;
		    do
		    {
		      v17 = 0;
		      v18 = 0LL;
		      do
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		        worldToShadowMatrices = shadowRequest->fields.cascadeShadowSplitSpheres;
		        if ( !worldToShadowMatrices )
		          goto LABEL_21;
		        v19 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields;
		        v20 = sub_180002100(worldToShadowMatrices, v15);
		        v21 = sub_1832E0B20(v20, (unsigned int)v17++);
		        *(&v19->shadowData._ASMParams.z + v16 + v18++) = v21;
		      }
		      while ( v17 < 4 );
		      ++v15;
		      v16 += 4LL;
		    }
		    while ( v15 < 4 );
		    v22 = 0;
		    v23 = 0LL;
		    do
		    {
		      v24 = 0;
		      v25 = 0LL;
		      do
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		        worldToShadowMatrices = shadowRequest->fields.cascadeShadowBiases;
		        if ( !worldToShadowMatrices )
		          goto LABEL_21;
		        v26 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields;
		        v27 = sub_180002100(worldToShadowMatrices, v22);
		        *((float *)&v26->s_shadowBufferHandle.ptr + v23 + v25) = sub_1832E0B20(v27, (unsigned int)v24);
		        worldToShadowMatrices = shadowRequest->fields.cascadeAtlasParams;
		        v28 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields;
		        if ( !worldToShadowMatrices )
		          goto LABEL_21;
		        v29 = sub_180002100(worldToShadowMatrices, v22);
		        v30 = sub_1832E0B20(v29, (unsigned int)v24);
		        v31 = v23 + v25;
		        ++v24;
		        ++v25;
		        *(&v28[1].shadowData._CSMPenumbraSizes.z + v31) = v30;
		      }
		      while ( v24 < 4 );
		      ++v22;
		      v23 += 4LL;
		    }
		    while ( v22 < 4 );
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		    v33[0] = 1.0 / (float)shadowRequest->fields.directionalShadowMapSize.m_X;
		    v33[1] = 1.0 / (float)shadowRequest->fields.directionalShadowMapSize.m_Y;
		    v33[2] = (float)shadowRequest->fields.directionalShadowMapSize.m_X;
		    v33[3] = (float)shadowRequest->fields.directionalShadowMapSize.m_Y;
		    *(_OWORD *)&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[1].shadowData._PunctualLightShadowParams.FixedElementField = *(_OWORD *)v33;
		  }
		}
		
		internal bool ShouldRenderCSMShadowMap(HGCamera hgCamera, CullingResults cullingResults, int directionalLightIndex, HGSettingParameters settingParams) => default; // 0x0000000189D24ED4-0x0000000189D24FF8
		// Boolean ShouldRenderCSMShadowMap(HGCamera, CullingResults, Int32, HGSettingParameters)
		bool HG::Rendering::Runtime::HGShadowManager::ShouldRenderCSMShadowMap(
		        HGShadowManager *this,
		        HGCamera *hgCamera,
		        CullingResults *cullingResults,
		        int32_t directionalLightIndex,
		        HGSettingParameters *settingParams,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  Camera *camera; // rcx
		  CullingResults v13; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2150, 0LL) )
		  {
		    if ( directionalLightIndex == -1 || !this->fields.enableShadowmap )
		      return 0;
		    camera = (Camera *)settingParams;
		    if ( !settingParams )
		      goto LABEL_16;
		    if ( !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		            settingParams->fields._csmEnabled_k__BackingField,
		            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit)
		      || !this->fields.m_hasDirectionLight
		      || UnityEngine::HGSharedLightData::get_shadows_Injected(&this->fields.m_directionalLight, 0LL) == LightShadows__Enum_None
		      || this->fields.m_shadowIntensity < 0.001
		      || !this->fields.m_enableCSMInVolume )
		    {
		      return 0;
		    }
		    if ( hgCamera )
		    {
		      camera = hgCamera->fields.camera;
		      if ( camera )
		        return UnityEngine::Camera::get_cameraType(camera, 0LL) != CameraType__Enum_Preview;
		    }
		LABEL_16:
		    sub_1800D8260(camera, v10);
		  }
		  camera = (Camera *)IFix::WrappersManagerImpl::GetPatch(2150, 0LL);
		  if ( !camera )
		    goto LABEL_16;
		  v13 = *cullingResults;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_859(
		           (ILFixDynamicMethodWrapper_2 *)camera,
		           (Object *)this,
		           (Object *)hgCamera,
		           &v13,
		           directionalLightIndex,
		           (Object *)settingParams,
		           0LL);
		}
		
		private bool CanCleanFullAtlas(CascadedShadowRequest shadowRequest) => default; // 0x0000000189D1F1EC-0x0000000189D1F24C
		// Boolean CanCleanFullAtlas(HGShadowManager+CascadedShadowRequest)
		bool HG::Rendering::Runtime::HGShadowManager::CanCleanFullAtlas(
		        HGShadowManager *this,
		        HGShadowManager_CascadedShadowRequest *shadowRequest,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2165, 0LL) )
		  {
		    if ( shadowRequest )
		      return !shadowRequest->fields.useCache;
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2165, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		           (ILFixDynamicMethodWrapper_33 *)Patch,
		           (Object *)this,
		           (Object *)shadowRequest,
		           0LL);
		}
		
		internal void RenderShadows(HGRenderGraph renderGraph, HGCamera hgCamera, CullingResults cullingResults, LightCullResult lightCullResult, int directionalLightIndex, bool shouldRenderCSMShadowMap, ref ShadowResult shadowResult) {} // 0x0000000189D23704-0x0000000189D24344
		// Void RenderShadows(HGRenderGraph, HGCamera, CullingResults, LightCullResult, Int32, Boolean, ShadowResult ByRef)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGShadowManager::RenderShadows(
		        HGShadowManager *this,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        CullingResults *cullingResults,
		        LightCullResult *lightCullResult,
		        int32_t directionalLightIndex,
		        bool shouldRenderCSMShadowMap,
		        ShadowResult *shadowResult,
		        MethodInfo *method)
		{
		  ProfilingSampler *v13; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  int32_t m_csmShadowMapTileSize; // r14d
		  Vector2Int m_csmShadowMapSize; // rbx
		  int32_t m_csmCascadeCount; // r15d
		  float m_shadowIntensity; // xmm6_4
		  Object__Class *klass; // r12
		  MonitorData *monitor; // r13
		  HGRenderGraphContext *HGContext; // rax
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  ScriptableRenderContext v27; // rax
		  HGShadowManager_CascadedShadowRequest *m_csmShadowRequest; // rbx
		  int32_t m_stopRenderCharacterCascade; // r14d
		  __int64 v30; // rdx
		  signed __int64 v31; // rcx
		  int32_t i; // ebx
		  Object__Class *v33; // r14
		  HGShadowManager_CascadedShadowRequest *v34; // rcx
		  ShadowSplitData__Array *shadowSplitData; // rcx
		  __int64 v36; // rdx
		  __int64 v37; // r8
		  Single__Array *m_csmShadowSplits; // rax
		  Object *v39; // rdx
		  unsigned __int64 v40; // rdx
		  unsigned __int64 v41; // r8
		  signed __int64 v42; // rtt
		  Object *v43; // r15
		  HGRenderGraphDefaultResources *defaultResources; // rax
		  __int64 v45; // rdx
		  __int64 v46; // rcx
		  unsigned __int64 v47; // r8
		  signed __int64 v48; // rtt
		  Object *v49; // r15
		  __int64 v50; // rdx
		  __int64 v51; // rcx
		  TextureHandle v52; // xmm0
		  Object *v53; // rsi
		  bool CanCleanFullAtlas; // al
		  __int64 v55; // rdx
		  __int64 v56; // rcx
		  __int64 v57; // rdx
		  __int64 m_csmShadowSampleMode; // rcx
		  Object *v59; // rdx
		  int v60; // eax
		  unsigned __int64 v61; // rdx
		  unsigned __int64 v62; // r8
		  char v63; // dl
		  signed __int64 v64; // rtt
		  Object *v65; // rdx
		  MonitorData *v66; // rcx
		  unsigned __int64 v67; // rdx
		  unsigned __int64 v68; // r8
		  signed __int64 v69; // rtt
		  Object *v70; // rsi
		  __int64 v71; // rdx
		  HGShadowManager__StaticFields *static_fields; // rcx
		  unsigned __int64 v73; // rdx
		  unsigned __int64 v74; // r8
		  signed __int64 v75; // rtt
		  Object *v76; // r8
		  HGShadowManager__StaticFields *v77; // rcx
		  unsigned __int64 v78; // rdx
		  unsigned __int64 v79; // r8
		  signed __int64 v80; // rtt
		  __int64 v81; // rcx
		  __int64 v82; // rdx
		  Object *v83; // rbx
		  __int64 v84; // rdx
		  __int64 v85; // rcx
		  TextureHandle v86; // xmm0
		  Object *v87; // rbx
		  HGRenderGraphDefaultResources *v88; // rax
		  unsigned __int64 v89; // rdx
		  signed __int64 v90; // rcx
		  unsigned __int64 v91; // r8
		  signed __int64 v92; // rtt
		  __int64 v93; // rdx
		  __int64 v94; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rbx
		  Object *v96; // [rsp+80h] [rbp-348h] BYREF
		  Object__Class *v97; // [rsp+88h] [rbp-340h]
		  HGRenderGraphBuilder v98; // [rsp+90h] [rbp-338h] BYREF
		  _QWORD v99[2]; // [rsp+B0h] [rbp-318h] BYREF
		  UInt32__Array *v100; // [rsp+C0h] [rbp-308h]
		  LightCullResult v101; // [rsp+D0h] [rbp-2F8h] BYREF
		  HGRenderGraphBuilder v102; // [rsp+E0h] [rbp-2E8h] BYREF
		  Il2CppExceptionWrapper *v103; // [rsp+100h] [rbp-2C8h] BYREF
		  CullingResults m_CullingResults; // [rsp+110h] [rbp-2B8h]
		  _BYTE v105[192]; // [rsp+120h] [rbp-2A8h] BYREF
		  __int128 v106; // [rsp+1E0h] [rbp-1E8h]
		  ShadowDrawingSettings v107; // [rsp+1F0h] [rbp-1D8h] BYREF
		  __int128 v108; // [rsp+230h] [rbp-198h]
		  __int128 v109; // [rsp+240h] [rbp-188h]
		  __int128 v110; // [rsp+250h] [rbp-178h]
		  __int128 v111; // [rsp+260h] [rbp-168h]
		  __int128 v112; // [rsp+270h] [rbp-158h]
		  __int128 v113; // [rsp+280h] [rbp-148h]
		  __int128 v114; // [rsp+290h] [rbp-138h]
		  __int128 v115; // [rsp+2A0h] [rbp-128h]
		  __int128 v116; // [rsp+2B0h] [rbp-118h]
		  __int128 v117; // [rsp+2C0h] [rbp-108h]
		  _OWORD v118[8]; // [rsp+2D0h] [rbp-F8h] BYREF
		  _OWORD v119[3]; // [rsp+350h] [rbp-78h] BYREF
		  __int64 v120; // [rsp+380h] [rbp-48h]
		  unsigned int v121; // [rsp+388h] [rbp-40h]
		
		  v96 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2166, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2166, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v94, v93);
		    *(LightCullResult *)&v98.m_RenderPass = *lightCullResult;
		    v101 = (LightCullResult)*cullingResults;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_865(
		      Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      (Object *)hgCamera,
		      (CullingResults *)&v101,
		      (LightCullResult *)&v98,
		      directionalLightIndex,
		      shouldRenderCSMShadowMap,
		      shadowResult,
		      0LL);
		  }
		  else
		  {
		    v13 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x7Au,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v15, v14);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v98,
		      renderGraph,
		      (String *)"Render Cascaded ShadowMaps",
		      &v96,
		      v13,
		      1,
		      ProfilingHGPass__Enum_Shadow,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGShadowManager::ShadowPassData>);
		    v102 = v98;
		    v99[0] = 0LL;
		    v99[1] = &v102;
		    try
		    {
		      if ( shouldRenderCSMShadowMap )
		      {
		        m_csmShadowMapTileSize = this->fields.m_csmShadowMapTileSize;
		        m_csmShadowMapSize = this->fields.m_csmShadowMapSize;
		        m_csmCascadeCount = this->fields.m_csmCascadeCount;
		        m_shadowIntensity = this->fields.m_shadowIntensity;
		        if ( !v96 )
		          sub_1800D8250(v17, v16);
		        klass = v96[7].klass;
		        monitor = v96[7].monitor;
		        v97 = v96[8].klass;
		        v100 = (UInt32__Array *)v96[8].monitor;
		        HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		        if ( !HGContext )
		          sub_1800D8250(v26, v25);
		        v27.m_Ptr = HGContext->fields.renderContext.m_Ptr;
		        v101 = *lightCullResult;
		        *(CullingResults *)&v98.m_RenderPass = *cullingResults;
		        HG::Rendering::Runtime::HGShadowManager::CalculateDirectionalShadowParameters(
		          this,
		          hgCamera,
		          (CullingResults *)&v98,
		          &v101,
		          directionalLightIndex,
		          m_csmShadowMapTileSize,
		          m_csmShadowMapSize,
		          m_csmCascadeCount,
		          m_shadowIntensity,
		          (RendererList__Array *)klass,
		          (UInt32__Array *)monitor,
		          (UInt32__Array *)v97,
		          v100,
		          &this->fields.m_csmShadowRequest,
		          v27,
		          0LL);
		        m_csmShadowRequest = this->fields.m_csmShadowRequest;
		        m_stopRenderCharacterCascade = this->fields.m_stopRenderCharacterCascade;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		        HG::Rendering::Runtime::HGShadowManager::SetDirectionalLightShadowData(
		          m_csmShadowRequest,
		          m_stopRenderCharacterCascade,
		          0LL);
		        for ( i = 0; i < this->fields.m_csmCascadeCount; ++i )
		        {
		          if ( !v96 )
		            sub_1800D8250(v31, v30);
		          v33 = v96[9].klass;
		          sub_18033B9D0(&v107, 0LL, 224LL);
		          *(CullingResults *)&v98.m_RenderPass = *cullingResults;
		          UnityEngine::Rendering::ShadowDrawingSettings::ShadowDrawingSettings(
		            &v107,
		            (CullingResults *)&v98,
		            directionalLightIndex,
		            0LL);
		          m_CullingResults = v107.m_CullingResults;
		          *(_OWORD *)v105 = *(_OWORD *)&v107.m_LightIndex;
		          *(Vector4 *)&v105[16] = v107.m_SplitData.m_CullingSphere;
		          *(_OWORD *)&v105[32] = *(_OWORD *)&v107.m_SplitData.m_ShadowCascadeBlendCullingFactor;
		          *(_OWORD *)&v105[48] = v108;
		          *(_OWORD *)&v105[64] = v109;
		          *(_OWORD *)&v105[80] = v110;
		          *(_OWORD *)&v105[96] = v111;
		          *(_OWORD *)&v105[112] = v112;
		          *(_OWORD *)&v105[128] = v113;
		          *(_OWORD *)&v105[144] = v114;
		          *(_OWORD *)&v105[160] = v115;
		          *(_OWORD *)&v105[176] = v116;
		          v106 = v117;
		          v34 = this->fields.m_csmShadowRequest;
		          if ( !v34 )
		            sub_1800D8250(0LL, 128LL);
		          shadowSplitData = v34->fields.shadowSplitData;
		          if ( !shadowSplitData )
		            sub_1800D8250(0LL, 128LL);
		          sub_1808B5944(shadowSplitData, v118, i);
		          *(_OWORD *)&v105[8] = v118[0];
		          *(_OWORD *)&v105[24] = v118[1];
		          *(_OWORD *)&v105[40] = v118[2];
		          *(_OWORD *)&v105[56] = v118[3];
		          *(_OWORD *)&v105[72] = v118[4];
		          *(_OWORD *)&v105[88] = v118[5];
		          *(_OWORD *)&v105[104] = v118[6];
		          *(_OWORD *)&v105[120] = v118[7];
		          *(_OWORD *)&v105[136] = v119[0];
		          *(_OWORD *)&v105[152] = v119[1];
		          *(_OWORD *)&v105[168] = v119[2];
		          *(_QWORD *)&v105[184] = v120;
		          *(_QWORD *)&v106 = v121;
		          BYTE8(v106) = 1;
		          *(_DWORD *)&v105[4] = i >= this->fields.m_stopRenderCharacterCascade;
		          if ( !v33 )
		            sub_1800D8250(v119, &v105[136]);
		          v107.m_CullingResults = m_CullingResults;
		          *(_OWORD *)&v107.m_LightIndex = *(_OWORD *)v105;
		          v107.m_SplitData.m_CullingSphere = *(Vector4 *)&v105[16];
		          *(_OWORD *)&v107.m_SplitData.m_ShadowCascadeBlendCullingFactor = *(_OWORD *)&v105[32];
		          v108 = *(_OWORD *)&v105[48];
		          v109 = *(_OWORD *)&v105[64];
		          v110 = *(_OWORD *)&v105[80];
		          v111 = *(_OWORD *)&v105[96];
		          v112 = *(_OWORD *)&v105[112];
		          v113 = *(_OWORD *)&v105[128];
		          v114 = *(_OWORD *)&v105[144];
		          v115 = *(_OWORD *)&v105[160];
		          v116 = *(_OWORD *)&v105[176];
		          v117 = v106;
		          sub_1808B5A5C(v33, i, &v107);
		          if ( !v96 )
		            sub_1800D8250(0LL, v36);
		          v31 = (signed __int64)v96[9].monitor;
		          m_csmShadowSplits = this->fields.m_csmShadowSplits;
		          if ( !m_csmShadowSplits )
		            sub_1800D8250(v31, v36);
		          v30 = i;
		          if ( (unsigned int)i >= m_csmShadowSplits->max_length.size )
		            sub_1800D2AA0(v31, i, v37);
		          if ( !v31 )
		            sub_1800D8250(0LL, i);
		          if ( (unsigned int)i >= *(_DWORD *)(v31 + 24) )
		            sub_1800D2AA0(v31, i, v37);
		          *(float *)(v31 + 4LL * i + 32) = (float)(m_csmShadowSplits->vector[i]
		                                                 / (float)this->fields.m_csmShadowMapTileSize)
		                                         / 0.005859375;
		        }
		        v39 = v96;
		        if ( !v96 )
		          sub_1800D8250(v31, 0LL);
		        v96[1].klass = (Object__Class *)hgCamera;
		        if ( dword_18F35FD08 )
		        {
		          v40 = ((unsigned __int64)&v39[1] >> 12) & 0x1FFFFF;
		          v41 = v40 >> 6;
		          v39 = (Object *)(v40 & 0x3F);
		          _m_prefetchw(&qword_18F0BCBA0[v41 + 36190]);
		          do
		          {
		            v31 = qword_18F0BCBA0[v41 + 36190] | (1LL << (char)v39);
		            v42 = qword_18F0BCBA0[v41 + 36190];
		          }
		          while ( v42 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v41 + 36190], v31, v42) );
		        }
		        if ( !v96 )
		          sub_1800D8250(v31, v39);
		        *(Object *)((char *)v96 + 24) = *(Object *)cullingResults;
		        v43 = v96;
		        defaultResources = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(renderGraph, 0LL);
		        if ( !v43 )
		          sub_1800D8250(v46, v45);
		        v43[2].monitor = (MonitorData *)defaultResources;
		        if ( dword_18F35FD08 )
		        {
		          v47 = (((unsigned __int64)&v43[2].monitor >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v47 + 36190]);
		          do
		            v48 = qword_18F0BCBA0[v47 + 36190];
		          while ( v48 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v47 + 36190],
		                           v48 | (1LL << (((unsigned __int64)&v43[2].monitor >> 12) & 0x3F)),
		                           v48) );
		        }
		        v49 = v96;
		        v52 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                 (TextureHandle *)&v98,
		                 renderGraph,
		                 this->fields.m_csmShadowMapAtlas,
		                 0LL);
		        if ( !v49 )
		          sub_1800D8250(v51, v50);
		        *(TextureHandle *)&v49[4].monitor = v52;
		        v53 = v96;
		        CanCleanFullAtlas = HG::Rendering::Runtime::HGShadowManager::CanCleanFullAtlas(
		                              this,
		                              this->fields.m_csmShadowRequest,
		                              0LL);
		        if ( !v53 )
		          sub_1800D8250(v56, v55);
		        BYTE5(v53[10].monitor) = CanCleanFullAtlas;
		        if ( !v96 )
		          sub_1800D8250(0LL, v55);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		          (TextureHandle *)&v98,
		          &v102,
		          (TextureHandle *)&v96[4].monitor,
		          DepthAccess__Enum_Write,
		          (RenderBufferLoadAction__Enum)(BYTE5(v96[10].monitor) != 0),
		          RenderBufferStoreAction__Enum_Store,
		          1.0,
		          0,
		          0,
		          0LL);
		        m_csmShadowSampleMode = (unsigned int)this->fields.m_csmShadowSampleMode;
		        if ( !v96 )
		          sub_1800D8250(m_csmShadowSampleMode, v57);
		        LODWORD(v96[3].klass) = m_csmShadowSampleMode;
		        v59 = v96;
		        if ( !v96 )
		          sub_1800D8250(m_csmShadowSampleMode, 0LL);
		        v96[4].klass = (Object__Class *)this->fields.m_csmShadowRamp;
		        v60 = dword_18F35FD08;
		        if ( dword_18F35FD08 )
		        {
		          v61 = ((unsigned __int64)&v59[4] >> 12) & 0x1FFFFF;
		          v62 = v61 >> 6;
		          v63 = v61 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v62 + 36190]);
		          do
		            v64 = qword_18F0BCBA0[v62 + 36190];
		          while ( v64 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v62 + 36190], v64 | (1LL << v63), v64) );
		          v60 = dword_18F35FD08;
		        }
		        v65 = v96;
		        v66 = (MonitorData *)this->fields.m_csmShadowRequest;
		        if ( !v96 )
		          sub_1800D8250(v66, 0LL);
		        v96[3].monitor = v66;
		        if ( v60 )
		        {
		          v67 = ((unsigned __int64)&v65[3].monitor >> 12) & 0x1FFFFF;
		          v68 = v67 >> 6;
		          v65 = (Object *)(v67 & 0x3F);
		          _m_prefetchw(&qword_18F0BCBA0[v68 + 36190]);
		          do
		          {
		            v66 = (MonitorData *)(qword_18F0BCBA0[v68 + 36190] | (1LL << (char)v65));
		            v69 = qword_18F0BCBA0[v68 + 36190];
		          }
		          while ( v69 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v68 + 36190], (signed __int64)v66, v69) );
		        }
		        if ( !v96 )
		          sub_1800D8250(v66, v65);
		        LOBYTE(v96[5].monitor) = 1;
		        v70 = v96;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		        if ( !v70 )
		          sub_1800D8250(static_fields, v71);
		        v70[6].klass = (Object__Class *)static_fields->s_blitShadowMaterial;
		        v73 = (unsigned int)dword_18F35FD08;
		        if ( dword_18F35FD08 )
		        {
		          v74 = (((unsigned __int64)&v70[6] >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v74 + 36190]);
		          do
		            v75 = qword_18F0BCBA0[v74 + 36190];
		          while ( v75 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v74 + 36190],
		                           v75 | (1LL << (((unsigned __int64)&v70[6] >> 12) & 0x3F)),
		                           v75) );
		          v73 = (unsigned int)dword_18F35FD08;
		        }
		        v76 = v96;
		        v77 = TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields;
		        if ( !v96 )
		          sub_1800D8250(v77, v73);
		        v96[6].monitor = (MonitorData *)v77->s_clearShadowMaterial;
		        if ( (_DWORD)v73 )
		        {
		          v78 = ((unsigned __int64)&v76[6].monitor >> 12) & 0x1FFFFF;
		          v79 = v78 >> 6;
		          v73 = v78 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v79 + 36190]);
		          do
		            v80 = qword_18F0BCBA0[v79 + 36190];
		          while ( v80 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v79 + 36190], v80 | (1LL << v73), v80) );
		        }
		        v81 = (unsigned int)this->fields.m_stopRenderCharacterCascade;
		        if ( !v96 )
		          sub_1800D8250(v81, v73);
		        LODWORD(v96[10].monitor) = v81;
		        if ( !v96 )
		          sub_1800D8250(v81, v73);
		        *(float *)&v96[10].klass = this->fields.m_csmHardwareDepthBias;
		        if ( !v96 )
		          sub_1800D8250(v81, v73);
		        HIDWORD(v96[10].klass) = LODWORD(this->fields.m_csmHardwareNormalBias);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v102,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->s_csmShadowMapRenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGShadowManager::ShadowPassData>);
		      }
		      else
		      {
		        v83 = v96;
		        v86 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                 (TextureHandle *)&v98,
		                 renderGraph,
		                 &this->fields.m_csmShadowMapTextureDesc,
		                 0LL);
		        if ( !v83 )
		          sub_1800D8250(v85, v84);
		        *(TextureHandle *)&v83[4].monitor = v86;
		        LOBYTE(v85) = this->fields.m_enableCSMInVolume;
		        if ( !v96 )
		          sub_1800D8250(v85, v84);
		        BYTE4(v96[10].monitor) = v85;
		        v87 = v96;
		        v88 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(renderGraph, 0LL);
		        if ( !v87 )
		          sub_1800D8250(v90, v89);
		        v87[2].monitor = (MonitorData *)v88;
		        if ( dword_18F35FD08 )
		        {
		          v91 = (((unsigned __int64)&v87[2].monitor >> 12) & 0x1FFFFF) >> 6;
		          v89 = ((unsigned __int64)&v87[2].monitor >> 12) & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v91 + 36190]);
		          do
		          {
		            v90 = qword_18F0BCBA0[v91 + 36190] | (1LL << v89);
		            v92 = qword_18F0BCBA0[v91 + 36190];
		          }
		          while ( v92 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v91 + 36190], v90, v92) );
		        }
		        if ( !v96 )
		          sub_1800D8250(v90, v89);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		          (TextureHandle *)&v98,
		          &v102,
		          (TextureHandle *)&v96[4].monitor,
		          0LL);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v102, 0, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v102,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGShadowManager->static_fields->s_disableDirectionalShadowRenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGShadowManager::ShadowPassData>);
		      }
		      shadowResult->directionalShadowActive = 1;
		      if ( !v96 )
		        sub_1800D8250(0LL, v82);
		      shadowResult->directionalShadowResult = *(TextureHandle *)((char *)v96 + 72);
		    }
		    catch ( Il2CppExceptionWrapper *v103 )
		    {
		      v99[0] = v103->ex;
		    }
		    sub_180268AE0(v99);
		  }
		}
		
	}
}
