using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using Unity.Collections;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[CreateAssetMenu(fileName = "HGWaterConfig", menuName = "\u2605 Beyond/HGWater/HGWaterConfig")]
	public class HGWaterConfig : ScriptableObject // TypeDefIndex: 38777
	{
		// Fields
		private const string PARAM_TYPE = "\u6C34\u4F53\u7C7B\u578B/\u6C34\u4F53\u7C7B\u578B\u9009\u62E9"; // Metadata: 0x02304167
		private const string PARAM_WAVE = "\u6CE2\u5F62\u63A7\u5236/\u6CE2\u5F62\u53C2\u6570"; // Metadata: 0x02304187
		private const string PARAM_COLOR = "\u989C\u8272\u63A7\u5236/\u989C\u8272\u53C2\u6570"; // Metadata: 0x023041A1
		private const string PARAM_FOAM = "\u767D\u6CAB\u63A7\u5236/\u767D\u6CAB\u53C2\u6570"; // Metadata: 0x023041BB
		private const string PARAM_PHYSICAL = "\u6C34\u7269\u7406\u5C5E\u6027\u63A7\u5236/\u7269\u7406\u53C2\u6570"; // Metadata: 0x023041D5
		private const string PARAM_LIGHTING = "\u5149\u7167\u53C2\u6570/\u5149\u7167\u53C2\u6570\u8C03\u6574"; // Metadata: 0x023041F8
		private const string PARAM_CAUSTIC = "\u7126\u6563/\u7126\u6563\u53C2\u6570"; // Metadata: 0x02304218
		private const string PARAM_INTERACTIVE = "\u4EA4\u4E92\u53C2\u6570/\u6C34\u4F53\u4EA4\u4E92\u53C2\u6570"; // Metadata: 0x0230422C
		private static int[] s_MaterialIndices; // 0x00
		private static int[] s_NormalIndices; // 0x08
		private static ValueDropdownList<int> TAAOptions; // 0x10
		public bool isGamePlayConfig; // 0x18
		public bool useFlowMap; // 0x19
		[Header("\u6750\u8D28\u7F16\u53F7")]
		public int materialIndex; // 0x1C
		public float flowDirection; // 0x20
		[HideInInspector]
		public Vector2 flowDirectionVector2; // 0x24
		[Header("\u5C0F\u6CE2\u6CD5\u7EBF\u8D34\u56FE\u7C7B\u578B")]
		public int smallWaveNormalType; // 0x2C
		[Header("\u5C0F\u6CE2\u6D41\u52A8\u901F\u5EA6")]
		[RecommendedRange(3f, 100f)]
		[Range(0f, 1000f)]
		public float flowSpeed; // 0x30
		[Header("\u5C0F\u6CE2\u5BC6\u5EA6")]
		[Range(0.001f, 0.2f)]
		public float normalTilling; // 0x34
		[Header("\u5C0F\u6CE2\u5F62\u6CD5\u7EBF\u5F3A\u5EA6")]
		[Range(0.001f, 2f)]
		public float normalScale; // 0x38
		[Header("\u5C0F\u6CE2\u5F62flowFullCycle")]
		[Range(0f, 1f)]
		public float flowFullCycle; // 0x3C
		[Header("\u5C0F\u6CE2\u5F62\u9876\u70B9\u8FD0\u52A8\u5927\u5C0F")]
		[RecommendedRange(0f, 0.2f)]
		[Range(0f, 2f)]
		public float waveVertexDisplacementScalerSmall; // 0x40
		[Header("\u5927\u6CE2\u6CD5\u7EBF\u8D34\u56FE\u7C7B\u578B")]
		public int largeWaveNormalType; // 0x44
		[Header("\u5927\u6CE2\u578B\u6D41\u52A8\u901F\u5EA6")]
		[RecommendedRange(3f, 100f)]
		[Range(0f, 100f)]
		public float largeWaveFlowSpeed; // 0x48
		[Header("\u5927\u6CE2\u578B\u5BC6\u5EA6")]
		[Range(0.001f, 0.1f)]
		public float largeWaveNormalTilling; // 0x4C
		[Header("\u5927\u6CE2\u578B\u6CD5\u7EBF\u5F3A\u5EA6")]
		[Range(0.001f, 2f)]
		public float largeWaveNormalScale; // 0x50
		[Header("\u5927\u6CE2\u5F62flowFullCycle")]
		[Range(0f, 1f)]
		public float flowFullCycleLarge; // 0x54
		[Header("\u6CE2\u5F62\u9876\u70B9\u8FD0\u52A8\u5927\u5C0F")]
		[RecommendedRange(0f, 0.2f)]
		[Range(0f, 2f)]
		public float waveVertexDisplacementScaler; // 0x58
		[Header("\u5927\u6CE2\u578B\u53CD\u5411")]
		public bool largeWaveInvDir; // 0x5C
		[Header("\u6C34\u4F53\u9876\u70B9\u504F\u79FB\u6CD5\u7EBF\u5F3A\u5EA6")]
		[RecommendedRange(0.5f, 1.5f)]
		[Range(0f, 5f)]
		public float displacementNormalStrength; // 0x60
		[Header("\u8272\u76F8\u6DF1\u5904")]
		public UnityEngine.Color absorptionTint; // 0x64
		[Header("\u8272\u76F8\u6D45\u5904")]
		public UnityEngine.Color absorptionTint2; // 0x74
		[Header("\u6563\u5C04\u989C\u8272")]
		public UnityEngine.Color scatterTint; // 0x84
		[Header("\u6C34\u6BCF\u7C73\u6563\u5C04\u5F3A\u5EA6")]
		[HideInInspector]
		public Vector4 waterRayleighScatteringMeter; // 0x94
		[Header("\u6C34\u6BCF\u7C73\u5BF9\u5149\u7684\u5438\u6536\u5EA6\u5F3A\u5EA6")]
		[HideInInspector]
		public Vector4 waterRayleighAbsorptionMeter; // 0xA4
		[Header("\u6C34\u6BCF\u7C73\u5BF9\u5149\u7684\u5438\u6536\u5EA6\u5F3A\u5EA62")]
		[HideInInspector]
		public Vector4 waterRayleighAbsorptionMeter2; // 0xB4
		[Header("\u4E0D\u900F\u660E\u5EA6")]
		[RecommendedRange(0f, 20f)]
		[Range(0.001f, 100f)]
		public float absorptionScale; // 0xC4
		[Header("\u6C34\u4E0B\u7EDD\u5BF9\u8DDD\u79BB\u5BF9\u4E0D\u900F\u660E\u5EA6\u5F71\u54CD\u53C2\u6570,\u6CA1\u7279\u6B8A\u9700\u8981\u4FDD\u63011\u5C31\u884C")]
		[RecommendedRange(0.5f, 2f)]
		[Range(0.001f, 5f)]
		public float distanceEdgeBlendFactor; // 0xC8
		[Header("\u745E\u5229/\u7C73\u6C0F\u6563\u5C04\u6DF7\u5408\u7CFB\u6570")]
		[RecommendedRange(0f, 1f)]
		[Range(0f, 1f)]
		public float rayleighMieLerpFactor; // 0xCC
		[Header("\u6563\u5C04\u603B\u5F3A\u5EA6")]
		[RecommendedRange(0f, 2f)]
		[Range(0f, 50f)]
		public float scatterScale; // 0xD0
		[Header("\u73AF\u5883\u5149\u6563\u5C04\u5F3A\u5EA6")]
		[RecommendedRange(0f, 1f)]
		[Range(0f, 2f)]
		public float envLightIntensity; // 0xD4
		[Header("SceneColor\u5BF9\u6563\u5C04\u7684\u5F71\u54CD")]
		[RecommendedRange(0f, 0.5f)]
		[Range(0f, 2f)]
		public float sceneColorEnvInfluence; // 0xD8
		[Header("\u5168\u5438\u6536\u8DDD\u79BB")]
		[Range(0f, 1000f)]
		public float safeFullAbsorpDistance; // 0xDC
		[Header("\u767D\u6CAB\u5E95\u90E8\u989C\u8272")]
		public UnityEngine.Color flowBaseColor; // 0xE0
		[Header("\u767D\u6CAB2\u901A\u9053\u989C\u8272")]
		public UnityEngine.Color foamColorG; // 0xF0
		[Header("\u767D\u6CAB\u53EF\u89C1\u5EA6")]
		[RecommendedRange(0f, 1f)]
		[Range(0f, 5f)]
		public float foamOpacity; // 0x100
		[Header("\u767D\u6CAB\u7C97\u7CD9\u5EA6")]
		[RecommendedRange(0f, 1f)]
		[Range(0f, 2f)]
		public float foamRoughness; // 0x104
		[Header("\u767D\u6CAB\u5F62\u72B6\u8303\u56F4\u504F\u79FB")]
		[RecommendedRange(0f, 0.2f)]
		[Range(0f, 1f)]
		public float foamShapeOffset; // 0x108
		[Header("\u767D\u6CAB\u6D88\u5931\u8DDD\u79BB")]
		[Range(20f, 1000f)]
		public float foamFadeDistance; // 0x10C
		[Header("\u767D\u6CAB\u9876\u70B9\u504F\u79FB")]
		[Range(0f, 2f)]
		public float foamDisplacementDistance; // 0x110
		[Header("\u767D\u6CAB\u81EA\u53D1\u5149\u5F3A\u5EA6")]
		[Range(0f, 100f)]
		public float emissiveStrength; // 0x114
		[Header("\u7C97\u7CD9\u5EA6")]
		[RecommendedRange(0f, 0.1f)]
		[Resetable(0.04f)]
		[Range(0f, 1f)]
		public float roughness; // 0x118
		[Header("Specular")]
		[RecommendedRange(0.2f, 0.3f)]
		[Resetable(0.25f)]
		[Range(0f, 1f)]
		public float specular; // 0x11C
		[Header("\u6C34\u4F53\u6298\u5C04\u5EA6")]
		[RecommendedRange(0f, 1f)]
		[Resetable(0.67f)]
		[Range(0f, 10f)]
		public float waterIOR; // 0x120
		[Header("\u6CD5\u7EBF\u8DDD\u79BB\u8870\u51CF")]
		[RecommendedRange(50f, 100f)]
		[Resetable(50f)]
		[Range(0f, 1000f)]
		public float distanceFade; // 0x124
		[Header("\u6CD5\u7EBF\u8DDD\u79BB\u8870\u51CF\u540E\u6700\u5C0F\u5F3A\u5EA6")]
		[RecommendedRange(0f, 0.2f)]
		[Resetable(0f)]
		[Range(0f, 1f)]
		public float distanceNormalMinStrength; // 0x128
		[Header("ibl\u73AF\u5883\u5149\u9AD8\u5149\u5F3A\u5EA6")]
		[RecommendedRange(0.8f, 1f)]
		[Resetable(1f)]
		[Range(0f, 1f)]
		public float envLightSpecularIntensity; // 0x12C
		[Header("\u76F4\u63A5\u5149\u9AD8\u5149\u805A\u62E2\u5EA6")]
		[RecommendedRange(0.5f, 1.2f)]
		[Resetable(0.5f)]
		[Range(0f, 2f)]
		public float dirSpecNormalScaler; // 0x130
		[Header("\u6C34\u8868\u9762\u8D34\u82B1\u6563\u5C04\u5F3A\u5EA6")]
		[RecommendedRange(0.9f, 1.1f)]
		[Resetable(1f)]
		[Range(0f, 1.5f)]
		public float waterBaseColorSubsurfaceScaler; // 0x134
		[Header("MipMap\u504F\u79FB")]
		[RecommendedRange(0.4f, 0.6f)]
		[Resetable(0.5f)]
		[Range(0f, 1f)]
		public float envSpecularDesaturation; // 0x138
		[Header("TAA\u6A21\u5F0F")]
		public int TAAManualAlphaMode; // 0x13C
		[Header("\u7126\u6563\u5BC6\u5EA6")]
		[Range(0f, 2f)]
		public float causticTilling; // 0x140
		[Header("\u7126\u6563\u53EF\u89C1\u5EA6")]
		[RecommendedRange(0f, 1.5f)]
		[Range(0f, 3f)]
		public float causticOpacity; // 0x144
		[Header("\u7126\u6563\u6270\u52A8\u5F3A\u5EA6")]
		[Range(0f, 5f)]
		public float causticDistort; // 0x148
		[Header("\u7126\u6563\u79FB\u52A8\u5F3A\u5EA6")]
		[Range(0f, 10f)]
		public float causticSpeed; // 0x14C
		[Header("\u7126\u6563\u8D77\u59CB\u6DF1\u5EA6")]
		[Range(0f, 2f)]
		public float causticStartDepth; // 0x150
		[Header("\u7126\u6563\u7ED3\u675F\u6DF1\u5EA6")]
		[Range(0.5f, 100f)]
		public float causticEndDepth; // 0x154
		[Header("\u8DDD\u79BB\u6298\u5C04\u5F3A\u5EA6\u51CF\u5F31")]
		[Range(0f, 100f)]
		public float distanceBlend; // 0x158
		[Header("\u6C34\u4F53\u6269\u6563\u6536\u655B\u901F\u5EA6")]
		[Range(0.95f, 1f)]
		[Space]
		public float interactiveDamp; // 0x15C
		[Header("\u6C34\u4F53\u6269\u6563Alpha")]
		[Range(0f, 1f)]
		public float interactiveAlpha; // 0x160
		[Header("\u6C34\u4F53\u6269\u6563Beta")]
		[Range(0f, 1f)]
		public float interactiveBeta; // 0x164
		[Header("\u6C34\u4F53\u6269\u6563\u901F\u5EA6")]
		[Range(0f, 1f)]
		public float interactiveSpeed; // 0x168
		[Header("\u6D9F\u6F2A\u6CD5\u7EBF\u5F3A\u5EA6")]
		[Range(0f, 1f)]
		public float rippleNormalStrength; // 0x16C
		[Header("\u6D9F\u6F2A\u6CE2\u5CF0\u5BBD\u5EA6(\u53EA\u6709pc\u751F\u6548)")]
		[Range(0f, 0.1f)]
		public float rippleNormalEdgeWidth; // 0x170
		[Header("\u6D9F\u6F2A\u9AD8\u5EA6\u504F\u79FB")]
		[Range(0f, 1f)]
		public float rippleHeightDisplacement; // 0x174
		[Header("\u89D2\u8272\u5468\u56F4Ripple\u6A21\u62DF\u5927\u5C0F")]
		[Range(0f, 1f)]
		public float interactiveRippleSize; // 0x178
		[Header("\u89D2\u8272\u5468\u56F4Ripple\u5411\u524D\u504F\u79FB\u8DDD\u79BB")]
		[Range(0f, 1f)]
		public float interactiveRippleForwardOffset; // 0x17C
		[Header("\u9759\u6B62\u6D9F\u6F2A\u4EA7\u751F\u9891\u7387")]
		[Range(0f, 0.2f)]
		public float stillRippleFrequency; // 0x180
		[Header("\u8FD0\u52A8\u6D9F\u6F2A\u4EA7\u751F\u9891\u7387")]
		[Range(0f, 1f)]
		public float moveRippleFrequency; // 0x184
	
		// Nested types
		public struct MaterialData // TypeDefIndex: 38774
		{
			// Fields
			public NativeArray<Vector4> vector4Array; // 0x00
	
			// Properties
			public Vector2 flowDirectionVector { set {} } // 0x0000000189C64380-0x0000000189C64418
			// Void set_flowDirectionVector(Vector2)
			void HG::Rendering::Runtime::HGWaterConfig::MaterialData::set_flowDirectionVector(
			        HGWaterConfig_MaterialData *this,
			        Vector2 value,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			  __int128 v9; // [rsp+28h] [rbp-30h]
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5329, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5329, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1545(Patch, this, value, 0LL);
			  }
			  else
			  {
			    v9 = *(_OWORD *)&this->vector4Array.m_Buffer[240];
			    *(Vector2 *)((char *)&v9 + 4) = value;
			    *(_OWORD *)&this->vector4Array.m_Buffer[240] = v9;
			  }
			}
			
			public float flowFullCycle { set {} } // 0x0000000189C6448C-0x0000000189C64508
			// Void set_flowFullCycle(Single)
			void HG::Rendering::Runtime::HGWaterConfig::MaterialData::set_flowFullCycle(
			        HGWaterConfig_MaterialData *this,
			        float value,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  __int128 v7; // [rsp+20h] [rbp-28h]
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5330, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5330, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v6, v5);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1546(Patch, this, value, 0LL);
			  }
			  else
			  {
			    v7 = *(_OWORD *)&this->vector4Array.m_Buffer[160];
			    *((float *)&v7 + 1) = value;
			    *(_OWORD *)&this->vector4Array.m_Buffer[160] = v7;
			  }
			}
			
			public float flowFullCycleLarge { set {} } // 0x0000000189C64418-0x0000000189C6448C
			// Void set_flowFullCycleLarge(Single)
			void HG::Rendering::Runtime::HGWaterConfig::MaterialData::set_flowFullCycleLarge(
			        HGWaterConfig_MaterialData *this,
			        float value,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  __int128 v7; // [rsp+20h] [rbp-28h]
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5331, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5331, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v6, v5);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1546(Patch, this, value, 0LL);
			  }
			  else
			  {
			    v7 = *(_OWORD *)&this->vector4Array.m_Buffer[80];
			    *((float *)&v7 + 1) = value;
			    *(_OWORD *)&this->vector4Array.m_Buffer[80] = v7;
			  }
			}
			
			public float largeWaveNormalScale { set {} } // 0x0000000189C64508-0x0000000189C6457C
			// Void set_largeWaveNormalScale(Single)
			void HG::Rendering::Runtime::HGWaterConfig::MaterialData::set_largeWaveNormalScale(
			        HGWaterConfig_MaterialData *this,
			        float value,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  __int128 v7; // [rsp+20h] [rbp-28h]
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5332, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5332, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v6, v5);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1546(Patch, this, value, 0LL);
			  }
			  else
			  {
			    v7 = *(_OWORD *)&this->vector4Array.m_Buffer[112];
			    *((float *)&v7 + 2) = value;
			    *(_OWORD *)&this->vector4Array.m_Buffer[112] = v7;
			  }
			}
			
			public float waveVertexDisplacementScaler { set {} } // 0x0000000189C6457C-0x0000000189C645F8
			// Void set_waveVertexDisplacementScaler(Single)
			void HG::Rendering::Runtime::HGWaterConfig::MaterialData::set_waveVertexDisplacementScaler(
			        HGWaterConfig_MaterialData *this,
			        float value,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  __int128 v7; // [rsp+20h] [rbp-28h]
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5333, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5333, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v6, v5);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1546(Patch, this, value, 0LL);
			  }
			  else
			  {
			    v7 = *(_OWORD *)&this->vector4Array.m_Buffer[176];
			    *((float *)&v7 + 3) = value;
			    *(_OWORD *)&this->vector4Array.m_Buffer[176] = v7;
			  }
			}
			
	
			// Methods
			public static MaterialData New() => default; // 0x0000000183C54070-0x0000000183C540D0
			// HGWaterConfig+MaterialData New()
			HGWaterConfig_MaterialData *HG::Rendering::Runtime::HGWaterConfig::MaterialData::New(
			        HGWaterConfig_MaterialData *__return_ptr retstr,
			        MethodInfo *method)
			{
			  HGWaterConfig_MaterialData v3; // xmm0
			  HGWaterConfig_MaterialData *result; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			  NativeArray_1_UnityEngine_Vector4_ v8; // [rsp+30h] [rbp-18h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1034, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1034, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    v3 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_391((HGWaterConfig_MaterialData *)&v8, Patch, 0LL);
			  }
			  else
			  {
			    v8 = 0LL;
			    Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray(
			      &v8,
			      20,
			      Allocator__Enum_Temp,
			      NativeArrayOptions__Enum_ClearMemory,
			      MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
			    v3 = (HGWaterConfig_MaterialData)v8;
			  }
			  result = retstr;
			  *retstr = v3;
			  return result;
			}
			
			public void SetValue(int index, Vector4 value) {} // 0x0000000183C549C0-0x0000000183C54A40
			// Void SetValue(Int32, Vector4)
			// local variable allocation has failed, the output may be wrong!
			void HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(
			        HGWaterConfig_MaterialData *this,
			        int32_t index,
			        Vector4 *value,
			        MethodInfo *method)
			{
			  __int64 v5; // rdi
			  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
			  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			
			  v5 = index;
			  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  wrapperArray = v6->static_fields->wrapperArray;
			  if ( !wrapperArray )
			    goto LABEL_6;
			  if ( wrapperArray->max_length.size <= 1036 )
			  {
			LABEL_5:
			    *(Vector4 *)&this->vector4Array.m_Buffer[16 * v5] = *value;
			    return;
			  }
			  if ( !v6->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(v6);
			    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
			  if ( !v6 )
			    goto LABEL_6;
			  if ( LODWORD(v6->_0.namespaze) <= 0x40C )
			    sub_1800D2AB0(v6, *(_QWORD *)&index);
			  if ( !v6[22]._0.this_arg.data.dummy )
			    goto LABEL_5;
			  Patch = IFix::WrappersManagerImpl::GetPatch(1036, 0LL);
			  if ( !Patch )
			LABEL_6:
			    sub_1800D8260(v6, *(_QWORD *)&index);
			  v10 = *value;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_392(Patch, this, v5, &v10, 0LL);
			}
			
		}
	
		public class RecommendedRangeAttribute : Attribute // TypeDefIndex: 38775
		{
			// Properties
			public float MinRecommended { get; } // 0x0000000184D85F70-0x0000000184D85F80 
			// Single get_override()
			float HG::Rendering::Runtime::ScalableSettingValue<float>::get_override(
			        ScalableSettingValue_1_System_Single_ *this,
			        MethodInfo *method)
			{
			  return this->fields.m_Override;
			}
			
			public float MaxRecommended { get; } // 0x0000000184D88D40-0x0000000184D88D50 
			// Single get_value()
			float Rewired::Utils::Classes::Utility::ValueWatcher<float>::get_value(
			        ValueWatcher_1_System_Single_ *this,
			        MethodInfo *method)
			{
			  return this->fields.lbeYGGLqExuAmnvpTifZPpiwyZrH;
			}
			
	
			// Constructors
			public RecommendedRangeAttribute() {} // Dummy constructor
			public RecommendedRangeAttribute(float min, float max) {} // 0x0000000184D8D120-0x0000000184D8D130
			// MinMaxRangeAttribute(Single, Single)
			void VLB::MinMaxRangeAttribute::MinMaxRangeAttribute(
			        MinMaxRangeAttribute *this,
			        float min,
			        float max,
			        MethodInfo *method)
			{
			  this->fields._minValue_k__BackingField = min;
			  this->fields._maxValue_k__BackingField = max;
			}
			
		}
	
		public class ResetableAttribute : Attribute // TypeDefIndex: 38776
		{
			// Properties
			public float DefaultValue { get; } // 0x0000000184D85F70-0x0000000184D85F80 
			// Single get_override()
			float HG::Rendering::Runtime::ScalableSettingValue<float>::get_override(
			        ScalableSettingValue_1_System_Single_ *this,
			        MethodInfo *method)
			{
			  return this->fields.m_Override;
			}
			
	
			// Constructors
			public ResetableAttribute() {} // Dummy constructor
			public ResetableAttribute(float defaultValue) {} // 0x0000000184D88280-0x0000000184D88290
			// Void set_override(Single)
			void HG::Rendering::Runtime::ScalableSettingValue<float>::set_override(
			        ScalableSettingValue_1_System_Single_ *this,
			        float value,
			        MethodInfo *method)
			{
			  this->fields.m_Override = value;
			}
			
		}
	
		// Constructors
		public HGWaterConfig() {} // 0x0000000183A1D7A0-0x0000000183A1D9B0
		// HGWaterConfig()
		void HG::Rendering::Runtime::HGWaterConfig::HGWaterConfig(HGWaterConfig *this, MethodInfo *method)
		{
		  __m128i si128; // xmm0
		  Color *v3; // rax
		  __int64 v4; // r8
		  Color *v5; // rax
		  __int64 v6; // r8
		  Color *v7; // rax
		  __int64 v8; // r8
		  TileBase *v9; // rdx
		  ITilemap *v10; // r9
		  TileAnimationData v11; // xmm1
		  __int64 v12; // r8
		  MethodInfo *v13; // rdx
		  Vector4 *one; // rax
		  Vector4 *v15; // r8
		  MethodInfo *v16; // rdx
		  Vector4 v17; // xmm1
		  __int64 v18; // r8
		  __m128i v19; // [rsp+20h] [rbp-28h] BYREF
		  TileAnimationData v20; // [rsp+30h] [rbp-18h] BYREF
		
		  this->fields.useFlowMap = 1;
		  si128 = _mm_load_si128((const __m128i *)&xmmword_18B9597E0);
		  this->fields.flowSpeed = 5.0;
		  this->fields.flowDirectionVector2 = 0LL;
		  this->fields.normalTilling = 0.0099999998;
		  this->fields.normalScale = 0.2;
		  this->fields.flowFullCycle = 0.0099999998;
		  this->fields.largeWaveFlowSpeed = 5.0;
		  this->fields.largeWaveNormalTilling = 0.0099999998;
		  this->fields.largeWaveNormalScale = 0.2;
		  this->fields.flowFullCycleLarge = 0.0099999998;
		  this->fields.displacementNormalStrength = 1.0;
		  v19 = si128;
		  v3 = UnityEngine::Color::op_Implicit((Color *)&v20, (Vector4 *)&v19, (MethodInfo *)this);
		  v19 = _mm_load_si128((const __m128i *)&xmmword_18B9597E0);
		  *(Color *)(v4 + 100) = *v3;
		  v5 = UnityEngine::Color::op_Implicit((Color *)&v20, (Vector4 *)&v19, (MethodInfo *)v4);
		  v19 = _mm_load_si128((const __m128i *)&xmmword_18B9597F0);
		  *(Color *)(v6 + 116) = *v5;
		  v7 = UnityEngine::Color::op_Implicit((Color *)&v20, (Vector4 *)&v19, (MethodInfo *)v6);
		  *(Color *)(v8 + 132) = *v7;
		  v11 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		           &v20,
		           v9,
		           (Vector3Int *)v8,
		           v10,
		           (MethodInfo *)v19.m128i_i64[0]);
		  *(_DWORD *)(v12 + 196) = 1065353216;
		  *(_DWORD *)(v12 + 200) = 1065353216;
		  *(TileAnimationData *)(v12 + 148) = v11;
		  *(_DWORD *)(v12 + 204) = 1045220557;
		  *(_DWORD *)(v12 + 208) = 1065353216;
		  *(_DWORD *)(v12 + 212) = 1036831949;
		  one = UnityEngine::Vector4::get_one((Vector4 *)&v20, v13);
		  v15[14] = *one;
		  v17 = *UnityEngine::Vector4::get_one((Vector4 *)&v20, v16);
		  *(_DWORD *)(v18 + 260) = 1045220557;
		  *(_DWORD *)(v18 + 268) = 1120403456;
		  *(Vector4 *)(v18 + 240) = v17;
		  *(_DWORD *)(v18 + 280) = 1025758986;
		  *(_DWORD *)(v18 + 284) = 1048576000;
		  *(_DWORD *)(v18 + 288) = 1059816735;
		  *(_DWORD *)(v18 + 292) = 1112014848;
		  *(_DWORD *)(v18 + 300) = 1065353216;
		  *(_DWORD *)(v18 + 304) = 1056964608;
		  *(_DWORD *)(v18 + 308) = 1065353216;
		  *(_DWORD *)(v18 + 312) = 1056964608;
		  *(_DWORD *)(v18 + 320) = 1036831949;
		  *(_DWORD *)(v18 + 324) = 1045220557;
		  *(_DWORD *)(v18 + 328) = 1036831949;
		  *(_DWORD *)(v18 + 332) = 1075838976;
		  *(_DWORD *)(v18 + 336) = 1065353216;
		  *(_DWORD *)(v18 + 340) = 1120403456;
		  *(_DWORD *)(v18 + 344) = 1120403456;
		  *(_DWORD *)(v18 + 368) = 1017370378;
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)v18, 0LL);
		}
		
		static HGWaterConfig() {} // 0x0000000182EDB2D0-0x0000000182EDB3F0
		// HGWaterConfig()
		void HG::Rendering::Runtime::HGWaterConfig::cctor(MethodInfo *method)
		{
		  IEnumerable_1_System_Int32_ *v1; // rax
		  Int32__Array *v2; // rax
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v4; // r8
		  Int32__Array **v5; // r9
		  IEnumerable_1_System_Int32_ *v6; // rax
		  Int32__Array *v7; // rax
		  HGRuntimeGrassQuery_Node *v8; // rdx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  ValueDropdownList_1_System_Int32_ *v11; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  ValueDropdownList_1_System_Int32_ *v14; // rbx
		  HGRuntimeGrassQuery_Node *v15; // rdx
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  MethodInfo *v18; // [rsp+20h] [rbp-8h]
		  MethodInfo *v19; // [rsp+20h] [rbp-8h]
		  MethodInfo *v20; // [rsp+50h] [rbp+28h]
		
		  v1 = System::Linq::Enumerable::RangeIterator(0, 32, 0LL);
		  v2 = System::Linq::Enumerable::ToArray<int>(v1, MethodInfo::System::Linq::Enumerable::ToArray<int>);
		  static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGWaterConfig->static_fields;
		  static_fields->klass = (HGRuntimeGrassQuery_Node__Class *)v2;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGWaterConfig->static_fields,
		    static_fields,
		    v4,
		    v5,
		    v18);
		  v6 = System::Linq::Enumerable::RangeIterator(0, 2, 0LL);
		  v7 = System::Linq::Enumerable::ToArray<int>(v6, MethodInfo::System::Linq::Enumerable::ToArray<int>);
		  v8 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGWaterConfig->static_fields;
		  v8->monitor = (MonitorData *)v7;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGWaterConfig->static_fields->s_NormalIndices,
		    v8,
		    v9,
		    v10,
		    v19);
		  v11 = (ValueDropdownList_1_System_Int32_ *)sub_1800368D0(TypeInfo::Sirenix::OdinInspector::ValueDropdownList<int>);
		  v14 = v11;
		  if ( !v11 )
		    sub_1800D8260(v13, v12);
		  Sirenix::OdinInspector::ValueDropdownList<int>::ValueDropdownList(
		    v11,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<int>::ValueDropdownList);
		  Sirenix::OdinInspector::ValueDropdownList<int>::Add(
		    v14,
		    (String *)"FastCoverage,不拖影但闪",
		    0,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<int>::Add);
		  Sirenix::OdinInspector::ValueDropdownList<int>::Add(
		    v14,
		    (String *)"Character,不闪但拖影",
		    1,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<int>::Add);
		  TypeInfo::HG::Rendering::Runtime::HGWaterConfig->static_fields->TAAOptions = v14;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGWaterConfig->static_fields->TAAOptions,
		    v15,
		    v16,
		    v17,
		    v20);
		}
		
	
		// Methods
		private void OnEnable() {} // 0x0000000183C53E90-0x0000000183C53ED0
		// Void OnEnable()
		void HG::Rendering::Runtime::HGWaterConfig::OnEnable(HGWaterConfig *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5326, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5326, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGWaterConfig::UpdateConfig(this, 0LL);
		  }
		}
		
		public void CopyConfig(ref MaterialData materialData) {} // 0x0000000183C544B0-0x0000000183C549C0
		// Void CopyConfig(HGWaterConfig+MaterialData ByRef)
		void HG::Rendering::Runtime::HGWaterConfig::CopyConfig(
		        HGWaterConfig *this,
		        HGWaterConfig_MaterialData *materialData,
		        MethodInfo *method)
		{
		  MethodInfo *v5; // r8
		  float y; // xmm1_4
		  float z; // xmm2_4
		  float TAAManualAlphaMode; // xmm3_4
		  MethodInfo *v9; // r8
		  float flowFullCycleLarge; // xmm2_4
		  int v11; // eax
		  bool v12; // zf
		  float causticEndDepth; // xmm1_4
		  float dirSpecNormalScaler; // xmm2_4
		  float distanceNormalMinStrength; // xmm3_4
		  float largeWaveNormalTilling; // xmm1_4
		  float largeWaveNormalScale; // xmm2_4
		  float largeWaveFlowSpeed; // xmm3_4
		  float roughness; // xmm1_4
		  float specular; // xmm2_4
		  float envSpecularDesaturation; // xmm3_4
		  float causticTilling; // xmm1_4
		  float distanceBlend; // xmm2_4
		  float flowSpeed; // xmm3_4
		  float flowFullCycle; // xmm1_4
		  float foamRoughness; // xmm2_4
		  float foamShapeOffset; // xmm3_4
		  float distanceFade; // xmm1_4
		  float envLightSpecularIntensity; // xmm2_4
		  float waveVertexDisplacementScaler; // xmm3_4
		  float v31; // xmm6_4
		  float safeFullAbsorpDistance; // xmm1_4
		  float rippleNormalEdgeWidth; // xmm2_4
		  float rayleighMieLerpFactor; // xmm3_4
		  float causticOpacity; // xmm1_4
		  float rippleNormalStrength; // xmm2_4
		  float causticDistort; // xmm1_4
		  float rippleHeightDisplacement; // xmm2_4
		  float sceneColorEnvInfluence; // xmm3_4
		  float v40; // xmm1_4
		  float waterBaseColorSubsurfaceScaler; // xmm2_4
		  float waveVertexDisplacementScalerSmall; // xmm0_4
		  float emissiveStrength; // xmm1_4
		  float largeWaveNormalType; // xmm3_4
		  TileBase *v45; // rdx
		  Vector3Int *v46; // r8
		  ITilemap *v47; // r9
		  TileBase *v48; // rdx
		  Vector3Int *v49; // r8
		  ITilemap *v50; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v52; // rdx
		  __int64 v53; // rcx
		  TileAnimationData flowBaseColor; // [rsp+20h] [rbp-30h] BYREF
		  Color v55; // [rsp+30h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1037, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1037, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v53, v52);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_394(Patch, (Object *)this, materialData, 0LL);
		  }
		  else
		  {
		    flowBaseColor = (TileAnimationData)this->fields.flowBaseColor;
		    flowBaseColor = (TileAnimationData)*UnityEngine::Color::op_Implicit(&v55, (Vector4 *)&flowBaseColor, v5);
		    HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 0, (Vector4 *)&flowBaseColor, 0LL);
		    y = this->fields.waterRayleighAbsorptionMeter2.y;
		    z = this->fields.waterRayleighAbsorptionMeter2.z;
		    TAAManualAlphaMode = (float)this->fields.TAAManualAlphaMode;
		    *(float *)&flowBaseColor.m_AnimatedSprites = this->fields.waterRayleighAbsorptionMeter2.x;
		    flowBaseColor.m_AnimationStartTime = TAAManualAlphaMode;
		    *((float *)&flowBaseColor.m_AnimatedSprites + 1) = y;
		    flowBaseColor.m_AnimationSpeed = z;
		    HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 1, (Vector4 *)&flowBaseColor, 0LL);
		    flowBaseColor = (TileAnimationData)this->fields.foamColorG;
		    flowBaseColor = (TileAnimationData)*UnityEngine::Color::op_Implicit(&v55, (Vector4 *)&flowBaseColor, v9);
		    HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 2, (Vector4 *)&flowBaseColor, 0LL);
		    flowBaseColor = (TileAnimationData)this->fields.waterRayleighScatteringMeter;
		    HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 3, (Vector4 *)&flowBaseColor, 0LL);
		    flowBaseColor = (TileAnimationData)this->fields.waterRayleighAbsorptionMeter;
		    HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 4, (Vector4 *)&flowBaseColor, 0LL);
		    flowFullCycleLarge = this->fields.flowFullCycleLarge;
		    v11 = -1;
		    v12 = !this->fields.largeWaveInvDir;
		    *(float *)&flowBaseColor.m_AnimatedSprites = this->fields.foamDisplacementDistance;
		    if ( v12 )
		      v11 = 1;
		    *((float *)&flowBaseColor.m_AnimatedSprites + 1) = flowFullCycleLarge;
		    *(_QWORD *)&flowBaseColor.m_AnimationSpeed = COERCE_UNSIGNED_INT((float)v11);
		    HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 5, (Vector4 *)&flowBaseColor, 0LL);
		    causticEndDepth = this->fields.causticEndDepth;
		    dirSpecNormalScaler = this->fields.dirSpecNormalScaler;
		    distanceNormalMinStrength = this->fields.distanceNormalMinStrength;
		    *(float *)&flowBaseColor.m_AnimatedSprites = this->fields.causticSpeed;
		    *((float *)&flowBaseColor.m_AnimatedSprites + 1) = causticEndDepth;
		    flowBaseColor.m_AnimationSpeed = dirSpecNormalScaler;
		    flowBaseColor.m_AnimationStartTime = distanceNormalMinStrength;
		    HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 6, (Vector4 *)&flowBaseColor, 0LL);
		    largeWaveNormalTilling = this->fields.largeWaveNormalTilling;
		    largeWaveNormalScale = this->fields.largeWaveNormalScale;
		    largeWaveFlowSpeed = this->fields.largeWaveFlowSpeed;
		    *(float *)&flowBaseColor.m_AnimatedSprites = this->fields.normalTilling;
		    *((float *)&flowBaseColor.m_AnimatedSprites + 1) = largeWaveNormalTilling;
		    flowBaseColor.m_AnimationSpeed = largeWaveNormalScale;
		    flowBaseColor.m_AnimationStartTime = largeWaveFlowSpeed;
		    HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 7, (Vector4 *)&flowBaseColor, 0LL);
		    roughness = this->fields.roughness;
		    specular = this->fields.specular;
		    envSpecularDesaturation = this->fields.envSpecularDesaturation;
		    *(float *)&flowBaseColor.m_AnimatedSprites = this->fields.normalScale;
		    *((float *)&flowBaseColor.m_AnimatedSprites + 1) = roughness;
		    flowBaseColor.m_AnimationSpeed = specular;
		    flowBaseColor.m_AnimationStartTime = envSpecularDesaturation;
		    HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 8, (Vector4 *)&flowBaseColor, 0LL);
		    causticTilling = this->fields.causticTilling;
		    distanceBlend = this->fields.distanceBlend;
		    flowSpeed = this->fields.flowSpeed;
		    *(float *)&flowBaseColor.m_AnimatedSprites = this->fields.envLightIntensity;
		    *((float *)&flowBaseColor.m_AnimatedSprites + 1) = causticTilling;
		    flowBaseColor.m_AnimationSpeed = distanceBlend;
		    flowBaseColor.m_AnimationStartTime = flowSpeed;
		    HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 9, (Vector4 *)&flowBaseColor, 0LL);
		    flowFullCycle = this->fields.flowFullCycle;
		    foamRoughness = this->fields.foamRoughness;
		    foamShapeOffset = this->fields.foamShapeOffset;
		    *(float *)&flowBaseColor.m_AnimatedSprites = this->fields.foamOpacity;
		    *((float *)&flowBaseColor.m_AnimatedSprites + 1) = flowFullCycle;
		    flowBaseColor.m_AnimationSpeed = foamRoughness;
		    flowBaseColor.m_AnimationStartTime = foamShapeOffset;
		    HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 10, (Vector4 *)&flowBaseColor, 0LL);
		    distanceFade = this->fields.distanceFade;
		    envLightSpecularIntensity = this->fields.envLightSpecularIntensity;
		    waveVertexDisplacementScaler = this->fields.waveVertexDisplacementScaler;
		    *(float *)&flowBaseColor.m_AnimatedSprites = this->fields.waterIOR;
		    *((float *)&flowBaseColor.m_AnimatedSprites + 1) = distanceFade;
		    flowBaseColor.m_AnimationSpeed = envLightSpecularIntensity;
		    flowBaseColor.m_AnimationStartTime = waveVertexDisplacementScaler;
		    HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 11, (Vector4 *)&flowBaseColor, 0LL);
		    v31 = 1.0;
		    safeFullAbsorpDistance = this->fields.safeFullAbsorpDistance;
		    rippleNormalEdgeWidth = this->fields.rippleNormalEdgeWidth;
		    rayleighMieLerpFactor = this->fields.rayleighMieLerpFactor;
		    flowBaseColor.m_AnimationStartTime = 1.0 / this->fields.foamFadeDistance;
		    *(float *)&flowBaseColor.m_AnimatedSprites = safeFullAbsorpDistance;
		    *((float *)&flowBaseColor.m_AnimatedSprites + 1) = rippleNormalEdgeWidth;
		    flowBaseColor.m_AnimationSpeed = rayleighMieLerpFactor;
		    HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 12, (Vector4 *)&flowBaseColor, 0LL);
		    causticOpacity = this->fields.causticOpacity;
		    rippleNormalStrength = this->fields.rippleNormalStrength;
		    *(float *)&flowBaseColor.m_AnimatedSprites = this->fields.distanceEdgeBlendFactor;
		    *((float *)&flowBaseColor.m_AnimatedSprites + 1) = causticOpacity;
		    flowBaseColor.m_AnimationStartTime = rippleNormalStrength;
		    flowBaseColor.m_AnimationSpeed = 32.0;
		    HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 13, (Vector4 *)&flowBaseColor, 0LL);
		    causticDistort = this->fields.causticDistort;
		    rippleHeightDisplacement = this->fields.rippleHeightDisplacement;
		    sceneColorEnvInfluence = this->fields.sceneColorEnvInfluence;
		    *(float *)&flowBaseColor.m_AnimatedSprites = this->fields.causticStartDepth;
		    *((float *)&flowBaseColor.m_AnimatedSprites + 1) = causticDistort;
		    flowBaseColor.m_AnimationSpeed = rippleHeightDisplacement;
		    flowBaseColor.m_AnimationStartTime = sceneColorEnvInfluence;
		    HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 14, (Vector4 *)&flowBaseColor, 0LL);
		    if ( !this->fields.useFlowMap )
		      v31 = 0.0;
		    v40 = this->fields.flowDirectionVector2.y;
		    waterBaseColorSubsurfaceScaler = this->fields.waterBaseColorSubsurfaceScaler;
		    HIDWORD(flowBaseColor.m_AnimatedSprites) = LODWORD(this->fields.flowDirectionVector2.x);
		    flowBaseColor.m_AnimationSpeed = v40;
		    flowBaseColor.m_AnimationStartTime = waterBaseColorSubsurfaceScaler;
		    *(float *)&flowBaseColor.m_AnimatedSprites = v31;
		    HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 15, (Vector4 *)&flowBaseColor, 0LL);
		    waveVertexDisplacementScalerSmall = this->fields.waveVertexDisplacementScalerSmall;
		    emissiveStrength = this->fields.emissiveStrength;
		    largeWaveNormalType = (float)this->fields.largeWaveNormalType;
		    flowBaseColor.m_AnimationSpeed = (float)this->fields.smallWaveNormalType;
		    flowBaseColor.m_AnimationStartTime = largeWaveNormalType;
		    *(float *)&flowBaseColor.m_AnimatedSprites = waveVertexDisplacementScalerSmall;
		    *((float *)&flowBaseColor.m_AnimatedSprites + 1) = emissiveStrength;
		    HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 16, (Vector4 *)&flowBaseColor, 0LL);
		    *(float *)&flowBaseColor.m_AnimatedSprites = this->fields.displacementNormalStrength;
		    *(Sprite__Array **)((char *)&flowBaseColor.m_AnimatedSprites + 4) = 0LL;
		    flowBaseColor.m_AnimationStartTime = 0.0;
		    HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 17, (Vector4 *)&flowBaseColor, 0LL);
		    flowBaseColor = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                       (TileAnimationData *)&v55,
		                       v45,
		                       v46,
		                       v47,
		                       (MethodInfo *)flowBaseColor.m_AnimatedSprites);
		    HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 18, (Vector4 *)&flowBaseColor, 0LL);
		    flowBaseColor = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                       (TileAnimationData *)&v55,
		                       v48,
		                       v49,
		                       v50,
		                       (MethodInfo *)flowBaseColor.m_AnimatedSprites);
		    HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, 19, (Vector4 *)&flowBaseColor, 0LL);
		  }
		}
		
		public static void LerpConfig(ref MaterialData materialData, ref MaterialData source, ref MaterialData target, float t) {} // 0x0000000189C62E78-0x0000000189C6303C
		// Void LerpConfig(HGWaterConfig+MaterialData ByRef, HGWaterConfig+MaterialData ByRef, HGWaterConfig+MaterialData ByRef, Single)
		void HG::Rendering::Runtime::HGWaterConfig::LerpConfig(
		        HGWaterConfig_MaterialData *materialData,
		        HGWaterConfig_MaterialData *source,
		        HGWaterConfig_MaterialData *target,
		        float t,
		        MethodInfo *method)
		{
		  int32_t v8; // ebx
		  __int64 i; // rdi
		  __m128 v10; // xmm7
		  Void *m_Buffer; // rax
		  __m128 v12; // xmm6
		  char v13; // r9
		  unsigned __int32 v14; // xmm0_4
		  unsigned __int32 v15; // xmm6_4
		  unsigned __int32 v16; // xmm6_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  MethodInfo *P3; // [rsp+20h] [rbp-A8h]
		  __m128 v21; // [rsp+40h] [rbp-88h] BYREF
		  __m128 v22; // [rsp+50h] [rbp-78h] BYREF
		  Vector4 v23; // [rsp+60h] [rbp-68h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1038, 0LL) )
		  {
		    v8 = 0;
		    for ( i = 0LL; ; i += 16LL )
		    {
		      v10 = (__m128)_mm_loadu_si128((const __m128i *)&source->vector4Array.m_Buffer[i]);
		      m_Buffer = target->vector4Array.m_Buffer;
		      v22 = v10;
		      v12 = (__m128)_mm_loadu_si128((const __m128i *)&m_Buffer[i]);
		      v21 = v12;
		      v21 = *(__m128 *)UnityEngine::Vector4::Lerp(&v23, (Vector4 *)&v22, (Vector4 *)&v21, t, P3);
		      if ( (unsigned int)v8 <= 5 )
		        break;
		      if ( v8 == 15 )
		      {
		        if ( t < 0.5 )
		          v12.m128_i32[0] = v10.m128_i32[0];
		        v21.m128_i32[0] = v12.m128_i32[0];
		        goto LABEL_23;
		      }
		      if ( v8 == 16 )
		      {
		        if ( t < 0.5 )
		        {
		          v14 = _mm_shuffle_ps(v10, v10, 170).m128_u32[0];
		          v15 = _mm_shuffle_ps(v10, v10, 255).m128_u32[0];
		        }
		        else
		        {
		          v14 = _mm_shuffle_ps(v12, v12, 170).m128_u32[0];
		          v15 = _mm_shuffle_ps(v12, v12, 255).m128_u32[0];
		        }
		        v21.m128_i32[2] = v14;
		LABEL_13:
		        v21.m128_i32[3] = v15;
		      }
		LABEL_23:
		      v22 = v21;
		      HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, v8++, (Vector4 *)&v22, 0LL);
		      if ( v8 >= 20 )
		        return;
		    }
		    if ( v8 != 1 )
		    {
		      if ( v8 == 5 )
		      {
		        if ( v13 )
		          v16 = _mm_shuffle_ps(v12, v12, 170).m128_u32[0];
		        else
		          v16 = _mm_shuffle_ps(v10, v10, 170).m128_u32[0];
		        v21.m128_i32[2] = v16;
		      }
		      goto LABEL_23;
		    }
		    if ( t < 0.5 )
		      v15 = _mm_shuffle_ps(v10, v10, 255).m128_u32[0];
		    else
		      v15 = _mm_shuffle_ps(v12, v12, 255).m128_u32[0];
		    goto LABEL_13;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1038, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v19, v18);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_395(Patch, materialData, source, target, t, 0LL);
		}
		
		public void UpdateConfig() {} // 0x0000000183C53FD0-0x0000000183C54070
		// Void UpdateConfig()
		void HG::Rendering::Runtime::HGWaterConfig::UpdateConfig(HGWaterConfig *this, MethodInfo *method)
		{
		  HGWaterConfig_MaterialData *v3; // rax
		  bool v4; // zf
		  HGManagerContext *ManagerContext; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  HGWaterManager *waterManager_k__BackingField; // rdi
		  String *name; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGWaterConfig_MaterialData materialData; // [rsp+30h] [rbp-28h] BYREF
		  HGWaterConfig_MaterialData v12; // [rsp+40h] [rbp-18h] BYREF
		
		  materialData = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(5327, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5327, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		    goto LABEL_7;
		  }
		  v3 = HG::Rendering::Runtime::HGWaterConfig::MaterialData::New(&v12, 0LL);
		  v4 = !this->fields.isGamePlayConfig;
		  materialData = *v3;
		  if ( !v4 )
		    return;
		  HG::Rendering::Runtime::HGWaterConfig::CopyConfig(this, &materialData, 0LL);
		  ManagerContext = HG::Rendering::Runtime::HGManagerContext::GetOrCreateManagerContext(0LL);
		  if ( !ManagerContext
		    || (waterManager_k__BackingField = ManagerContext->fields._waterManager_k__BackingField,
		        name = UnityEngine::Object::get_name((Object_1 *)this, 0LL),
		        !waterManager_k__BackingField) )
		  {
		LABEL_7:
		    sub_1800D8260(v7, v6);
		  }
		  HG::Rendering::Runtime::HGWaterManager::UpdateStaticWater(
		    waterManager_k__BackingField,
		    name,
		    this->fields.materialIndex,
		    &materialData.vector4Array,
		    0LL);
		}
		
	}
}
