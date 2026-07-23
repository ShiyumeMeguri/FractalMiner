using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGSkyConfig : IEnvConfig // TypeDefIndex: 37620
	{
		// Fields
		[NonSerialized]
		[HideInInspector]
		public string parentEnvPhaseGuid; // 0x00
		[Header("\u5929\u7A7A\u7403\u8DDD\u79BB")]
		[UnclampedRange(1f, 30000f)]
		public float skyDistance; // 0x08
		[Header("\u5929\u5149\u70D8\u7119\u95F4\u63A5\u5149\u7CFB\u6570")]
		[UnclampedRange(0f, 5f)]
		public float skyBakedIndirectIntensity; // 0x0C
		[Header("\u5929\u5149\u76F4\u63A5\u90E8\u5206\u7CFB\u6570")]
		[UnclampedRange(0f, 10f)]
		public float skyDirectIntensity; // 0x10
		[Header("\u4F7F\u7528\u81EA\u5B9A\u4E49IV\u9ED8\u8BA4SH")]
		public bool useCustomIVDefaultSH; // 0x14
		public SphericalHarmonicsL2 customIVDefaultSH; // 0x18
		[Header("\u6750\u8D28\u6A21\u5F0F")]
		public SkyMaterialType skyMaterialType; // 0x84
		[Header("\u7167\u5EA6\u7CFB\u6570")]
		[UnclampedRange(0f, 10f)]
		public float proceduralSkyLuxFactor; // 0x88
		[FormerlySerializedAs("sunDisc")]
		[Header("\u7ED8\u5236 Sun Disc")]
		public bool enableSunDisc; // 0x8C
		[Header("\u592A\u9633\u534A\u5F84")]
		[UnclampedRange(0f, 1f)]
		public float sunDiscRadius; // 0x90
		[Header("\u592A\u9633\u6E10\u53D8\u8303\u56F4")]
		[UnclampedRange(0f, 1f)]
		public float sunDiscRampIntensity; // 0x94
		[ColorUsage(false, true)]
		[Header("\u592A\u9633\u989C\u8272")]
		public UnityEngine.Color sunDiscColor; // 0x98
		[Header("\u4EAE\u5EA6")]
		[UnclampedRangeExponential(0f, 200000f, 3f)]
		public float skyboxBrightness; // 0xA8
		[Header("Tint \u989C\u8272")]
		public UnityEngine.Color skyboxTintColor; // 0xAC
		[Header("\u65CB\u8F6C\u89D2\u5EA6")]
		[Range(0f, 360f)]
		public float skyboxRotation; // 0xBC
		[Header("\u76F8\u673A\u53EF\u89C1\u53CD\u5C04\u63A2\u9488\u8303\u56F4")]
		public Vector3 visibleBox; // 0xC0
		[Header("\u5168\u5C40\u73AF\u5883\u8D34\u56FE\u6765\u6E90")]
		public ReflectionType reflectionType; // 0xCC
		[Header("\u5168\u5C40\u73AF\u5883\u8D34\u56FE")]
		public Cubemap reflectionMap; // 0xD0
		[Header("\u5168\u5C40\u73AF\u5883\u8D34\u56FEDeringing\u7CFB\u6570")]
		[UnclampedRange(0f, 9f)]
		public float culloff; // 0xD8
		[Header("\u5168\u5C40\u73AF\u5883\u6F2B\u53CD\u5C04 SH")]
		public SphericalHarmonicsL2 skyAmbientSH; // 0xDC
		[HideInInspector]
		public Cubemap skyboxCubeMap; // 0x148
		[HideInInspector]
		[SerializeField]
		private bool m_active; // 0x150
		public static HGSkyConfig defaultConfig; // 0x00
	
		// Properties
		public bool active { get => default; set {} } // 0x0000000183A56A80-0x0000000183A56AE0 0x00000001831D51F0-0x00000001831D5230
		// Boolean get_active()
		bool HG::Rendering::Runtime::HGSkyConfig::get_active(HGSkyConfig *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 1090 )
		    return this->m_active;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x442 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[23]._0.typeMetadataHandle )
		    return this->m_active;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1090, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_420(Patch, this, 0LL);
		}
		

		// Void set_active(Boolean)
		void HG::Rendering::Runtime::HGSkyConfig::set_active(HGSkyConfig *this, bool value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1400, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1400, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_569(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_active = value;
		  }
		}
		
	
		// Nested types
		public enum SkyMaterialType // TypeDefIndex: 37618
		{
			ProceduralSky = 0,
			Skybox = 1
		}
	
		public enum ReflectionType // TypeDefIndex: 37619
		{
			FromSky = 0,
			Custom = 1
		}
	
		// Constructors
		public HGSkyConfig(bool active) : this() {
			parentEnvPhaseGuid = default;
			skyDistance = default;
			skyBakedIndirectIntensity = default;
			skyDirectIntensity = default;
			useCustomIVDefaultSH = default;
			customIVDefaultSH = default;
			skyMaterialType = default;
			proceduralSkyLuxFactor = default;
			enableSunDisc = default;
			sunDiscRadius = default;
			sunDiscRampIntensity = default;
			sunDiscColor = default;
			skyboxBrightness = default;
			skyboxTintColor = default;
			skyboxRotation = default;
			visibleBox = default;
			reflectionType = default;
			reflectionMap = default;
			culloff = default;
			skyAmbientSH = default;
			skyboxCubeMap = default;
			m_active = default;
		} // 0x0000000184890A20-0x0000000184890BC0
		// HGSkyConfig(Boolean)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGSkyConfig::HGSkyConfig(HGSkyConfig *this, bool active, MethodInfo *method)
		{
		  String__StaticFields *static_fields; // r8
		  char v4; // r9
		  __int64 v5; // r10
		  MethodInfo *v6; // rdx
		  Vector4 v7; // xmm1
		  Int32__Array **v8; // r9
		  __int64 v9; // r10
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  __int64 v13; // r10
		  HGRuntimeGrassQuery_Node *v14; // rdx
		  HGRuntimeGrassQuery_Node *v15; // r8
		  MethodInfo *v16; // r9
		  Vector3 *v17; // rax
		  float z; // ecx
		  __int64 v19; // r10
		  Vector3 v20; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v21; // [rsp+30h] [rbp-18h] BYREF
		
		  static_fields = TypeInfo::System::String->static_fields;
		  this->parentEnvPhaseGuid = static_fields->Empty;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)this,
		    (HGRuntimeGrassQuery_Node *)active,
		    (HGRuntimeGrassQuery_Node *)static_fields,
		    (Int32__Array **)active,
		    *(MethodInfo **)&v20.x);
		  *(_BYTE *)(v5 + 336) = v4;
		  *(_DWORD *)(v5 + 8) = 1176256512;
		  *(_QWORD *)(v5 + 128) = 0LL;
		  *(_DWORD *)(v5 + 12) = 1065353216;
		  *(_DWORD *)(v5 + 16) = 1065353216;
		  *(_BYTE *)(v5 + 20) = 0;
		  *(_OWORD *)(v5 + 24) = 0LL;
		  *(_OWORD *)(v5 + 40) = 0LL;
		  *(_OWORD *)(v5 + 56) = 0LL;
		  *(_OWORD *)(v5 + 72) = 0LL;
		  *(_OWORD *)(v5 + 88) = 0LL;
		  *(_OWORD *)(v5 + 104) = 0LL;
		  *(_QWORD *)(v5 + 120) = 0LL;
		  *(__m128i *)(v5 + 152) = _mm_load_si128((const __m128i *)&xmmword_18B959C40);
		  *(_DWORD *)(v5 + 136) = 1065353216;
		  *(_BYTE *)(v5 + 140) = 0;
		  *(_DWORD *)(v5 + 144) = 1036831949;
		  *(_DWORD *)(v5 + 148) = 1045220557;
		  *(_DWORD *)(v5 + 168) = 1206542336;
		  v7 = *UnityEngine::Vector4::get_one(&v21, v6);
		  *(_DWORD *)(v9 + 188) = (_DWORD)v8;
		  *(_DWORD *)(v9 + 204) = (_DWORD)v8;
		  *(Vector4 *)(v9 + 172) = v7;
		  *(_QWORD *)(v9 + 208) = v8;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v9 + 208), v10, v11, v8, *(MethodInfo **)&v20.x);
		  *(_DWORD *)(v13 + 216) = (_DWORD)v12;
		  *(_OWORD *)(v13 + 220) = 0LL;
		  *(_OWORD *)(v13 + 236) = 0LL;
		  *(_OWORD *)(v13 + 252) = 0LL;
		  *(_OWORD *)(v13 + 268) = 0LL;
		  *(_OWORD *)(v13 + 284) = 0LL;
		  *(_OWORD *)(v13 + 300) = 0LL;
		  *(_QWORD *)(v13 + 316) = 0LL;
		  *(_DWORD *)(v13 + 324) = 0;
		  *(_QWORD *)(v13 + 328) = v12;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v13 + 328), v14, v15, v12, *(MethodInfo **)&v20.x);
		  v20.z = 1.0;
		  *(_QWORD *)&v20.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		  v17 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v21, &v20, 32.0, v16);
		  z = v17->z;
		  *(_QWORD *)(v19 + 192) = *(_QWORD *)&v17->x;
		  *(float *)(v19 + 200) = z;
		}
		
		static HGSkyConfig() {
			defaultConfig = default;
		} // 0x00000001848908A0-0x0000000184890A20
		// HGSkyConfig()
		void HG::Rendering::Runtime::HGSkyConfig::cctor(MethodInfo *method)
		{
		  Int32__Array **v1; // r9
		  __int64 v2; // r8
		  _BYTE *v3; // rcx
		  __int64 v4; // rdx
		  HGSkyConfig *v5; // rax
		  __int128 v6; // xmm0
		  __int128 v7; // xmm1
		  __int128 v8; // xmm0
		  __int128 v9; // xmm1
		  __int128 v10; // xmm0
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  __int128 v13; // xmm1
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int64 v18; // rax
		  HGSkyConfig__StaticFields *static_fields; // rdx
		  _BYTE *v20; // rax
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  __int128 v23; // xmm0
		  __int128 v24; // xmm1
		  __int128 v25; // xmm0
		  __int128 v26; // xmm1
		  __int128 v27; // xmm0
		  __int128 v28; // xmm1
		  __int64 v29; // rcx
		  __int128 v30; // xmm1
		  __int128 v31; // xmm0
		  __int128 v32; // xmm1
		  __int128 v33; // xmm0
		  HGSkyConfig v34; // [rsp+20h] [rbp-2C8h] BYREF
		  _BYTE v35[360]; // [rsp+180h] [rbp-168h] BYREF
		
		  sub_18033B9D0(&v34, 0LL, 344LL);
		  HG::Rendering::Runtime::HGSkyConfig::HGSkyConfig(&v34, 0, 0LL);
		  v2 = 2LL;
		  v3 = v35;
		  v4 = 2LL;
		  v5 = &v34;
		  do
		  {
		    v3 += 128;
		    v6 = *(_OWORD *)&v5->parentEnvPhaseGuid;
		    v7 = *(_OWORD *)&v5->skyDirectIntensity;
		    v5 = (HGSkyConfig *)((char *)v5 + 128);
		    *((_OWORD *)v3 - 8) = v6;
		    v8 = *(_OWORD *)&v5[-1].skyAmbientSH.shr7;
		    *((_OWORD *)v3 - 7) = v7;
		    v9 = *(_OWORD *)&v5[-1].skyAmbientSH.shg2;
		    *((_OWORD *)v3 - 6) = v8;
		    v10 = *(_OWORD *)&v5[-1].skyAmbientSH.shg6;
		    *((_OWORD *)v3 - 5) = v9;
		    v11 = *(_OWORD *)&v5[-1].skyAmbientSH.shb1;
		    *((_OWORD *)v3 - 4) = v10;
		    v12 = *(_OWORD *)&v5[-1].skyAmbientSH.shb5;
		    *((_OWORD *)v3 - 3) = v11;
		    v13 = *(_OWORD *)&v5[-1].skyboxCubeMap;
		    *((_OWORD *)v3 - 2) = v12;
		    *((_OWORD *)v3 - 1) = v13;
		    --v4;
		  }
		  while ( v4 );
		  v14 = *(_OWORD *)&v5->skyDirectIntensity;
		  *(_OWORD *)v3 = *(_OWORD *)&v5->parentEnvPhaseGuid;
		  v15 = *(_OWORD *)&v5->customIVDefaultSH.shr2;
		  *((_OWORD *)v3 + 1) = v14;
		  v16 = *(_OWORD *)&v5->customIVDefaultSH.shr6;
		  *((_OWORD *)v3 + 2) = v15;
		  v17 = *(_OWORD *)&v5->customIVDefaultSH.shg1;
		  v18 = *(_QWORD *)&v5->customIVDefaultSH.shg5;
		  *((_OWORD *)v3 + 3) = v16;
		  *((_OWORD *)v3 + 4) = v17;
		  *((_QWORD *)v3 + 10) = v18;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGSkyConfig->static_fields;
		  v20 = v35;
		  do
		  {
		    static_fields = (HGSkyConfig__StaticFields *)((char *)static_fields + 128);
		    v21 = *(_OWORD *)v20;
		    v22 = *((_OWORD *)v20 + 1);
		    v20 += 128;
		    *(_OWORD *)&static_fields[-1].defaultConfig.culloff = v21;
		    v23 = *((_OWORD *)v20 - 6);
		    *(_OWORD *)&static_fields[-1].defaultConfig.skyAmbientSH.shr3 = v22;
		    v24 = *((_OWORD *)v20 - 5);
		    *(_OWORD *)&static_fields[-1].defaultConfig.skyAmbientSH.shr7 = v23;
		    v25 = *((_OWORD *)v20 - 4);
		    *(_OWORD *)&static_fields[-1].defaultConfig.skyAmbientSH.shg2 = v24;
		    v26 = *((_OWORD *)v20 - 3);
		    *(_OWORD *)&static_fields[-1].defaultConfig.skyAmbientSH.shg6 = v25;
		    v27 = *((_OWORD *)v20 - 2);
		    *(_OWORD *)&static_fields[-1].defaultConfig.skyAmbientSH.shb1 = v26;
		    v28 = *((_OWORD *)v20 - 1);
		    *(_OWORD *)&static_fields[-1].defaultConfig.skyAmbientSH.shb5 = v27;
		    *(_OWORD *)&static_fields[-1].defaultConfig.skyboxCubeMap = v28;
		    --v2;
		  }
		  while ( v2 );
		  v29 = *((_QWORD *)v20 + 10);
		  v30 = *((_OWORD *)v20 + 1);
		  *(_OWORD *)&static_fields->defaultConfig.parentEnvPhaseGuid = *(_OWORD *)v20;
		  v31 = *((_OWORD *)v20 + 2);
		  *(_OWORD *)&static_fields->defaultConfig.skyDirectIntensity = v30;
		  v32 = *((_OWORD *)v20 + 3);
		  *(_OWORD *)&static_fields->defaultConfig.customIVDefaultSH.shr2 = v31;
		  v33 = *((_OWORD *)v20 + 4);
		  *(_OWORD *)&static_fields->defaultConfig.customIVDefaultSH.shr6 = v32;
		  *(_OWORD *)&static_fields->defaultConfig.customIVDefaultSH.shg1 = v33;
		  *(_QWORD *)&static_fields->defaultConfig.customIVDefaultSH.shg5 = v29;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGSkyConfig->static_fields,
		    (HGRuntimeGrassQuery_Node *)static_fields,
		    0LL,
		    v1,
		    (MethodInfo *)v34.parentEnvPhaseGuid);
		}
		
	
		// Methods
		public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
			where T : struct, IEnvConfig {}
	}
}
