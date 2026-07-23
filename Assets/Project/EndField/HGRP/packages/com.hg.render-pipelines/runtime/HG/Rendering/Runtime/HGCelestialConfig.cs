using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Serialization;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGCelestialConfig : IEnvConfig // TypeDefIndex: 37594
	{
		// Fields
		public HGCelestialObjectConfig moonConfig; // 0x00
		public HGCelestialAtmosphereObjectConfig talosAlphaConfig; // 0x40
		[Space(5f)]
		public HGCelestialAtmosphereObjectConfig planetConfig; // 0xC8
		[Space(5f)]
		public HGCelestialAdvancedObjectConfig advancedPlanetConfig; // 0x150
		[HideInInspector]
		[SerializeField]
		private bool m_active; // 0x160
		public static HGCelestialConfig defaultConfig; // 0x00
	
		// Properties
		public bool active { get => default; set {} } // 0x0000000183A6EDA0-0x0000000183A6EE00 0x00000001831D4EF0-0x00000001831D4F30
		// Boolean get_active()
		bool HG::Rendering::Runtime::HGCelestialConfig::get_active(HGCelestialConfig *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 1327 )
		    return this->m_active;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x52F )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[28]._0.klass )
		    return this->m_active;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1327, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_514(Patch, this, 0LL);
		}
		

		// Void set_active(Boolean)
		void HG::Rendering::Runtime::HGCelestialConfig::set_active(HGCelestialConfig *this, bool value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1328, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1328, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_515(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_active = value;
		  }
		}
		
	
		// Nested types
		[Serializable]
		public struct HGCelestialAtmosphereObjectConfig : IEnvConfig // TypeDefIndex: 37586
		{
			// Fields
			[Header("\u662F\u5426\u5728\u5929\u7A7A\u4E2D\u7ED8\u5236")]
			public bool drawPlanetInSkydome; // 0x00
			[Header("\u5730\u5E73\u7EBF\u4E0B\u5143\u7D20\u4E0D\u53EF\u89C1\u5EA6")]
			[UnclampedRange(0f, 1f)]
			public float drawPlanetBelowHorizon; // 0x04
			[FormerlySerializedAs("celestialProperty")]
			[Header("\u661F\u7403\u81EA\u8EAB\u5C5E\u6027")]
			public CelestialObjectProperty objectProperty; // 0x08
			[Header("\u7ED8\u5236\u5C5E\u6027")]
			public CelestialDrawer skydomeDrawer; // 0x18
			[FormerlySerializedAs("enableRing")]
			[Header("\u5149\u73AF\u8BBE\u5B9A")]
			public bool enableRing; // 0x38
			public RingProperty ring; // 0x40
			[Header("\u5F00\u542F\u661F\u7403\u5927\u6C14\u6563\u5C04")]
			public bool enableAtmosphere; // 0x60
			[Header("\u5927\u6C14\u6563\u5C04\u5C5E\u6027")]
			public AtmosphereProperty atmosphere; // 0x64
			public static HGCelestialAtmosphereObjectConfig defaultConfig; // 0x00
	
			// Properties
			public bool active { get => default; set {} } // 0x0000000189C6DAA4-0x0000000189C6DAF0 0x0000000189C6DAF0-0x0000000189C6DB44
			// Boolean get_active()
			bool HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAtmosphereObjectConfig::get_active(
			        HGCelestialConfig_HGCelestialAtmosphereObjectConfig *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(1333, 0LL) )
			    return 1;
			  Patch = IFix::WrappersManagerImpl::GetPatch(1333, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v6, v5);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_520(Patch, this, 0LL);
			}
			

			// Void set_active(Boolean)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAtmosphereObjectConfig::set_active(
			        HGCelestialConfig_HGCelestialAtmosphereObjectConfig *this,
			        bool value,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1334, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1334, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_521(Patch, this, value, 0LL);
			  }
			}
			
	
			// Constructors
			public HGCelestialAtmosphereObjectConfig(bool active) : this() {
				drawPlanetInSkydome = default;
				drawPlanetBelowHorizon = default;
				objectProperty = default;
				skydomeDrawer = default;
				enableRing = default;
				ring = default;
				enableAtmosphere = default;
				atmosphere = default;
			} // 0x00000001848B5990-0x00000001848B5A90
			// HGCelestialConfig+HGCelestialAtmosphereObjectConfig(Boolean)
			// local variable allocation has failed, the output may be wrong!
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAtmosphereObjectConfig::HGCelestialAtmosphereObjectConfig(
			        HGCelestialConfig_HGCelestialAtmosphereObjectConfig *this,
			        bool active,
			        MethodInfo *method)
			{
			  __m128i v3; // xmm1
			  __int64 v4; // r9
			  Type *v5; // rdx
			  PropertyInfo_1 *v6; // r8
			  __int64 v7; // r9
			  char v8; // r10
			  MethodInfo *v9; // rdx
			  Vector4 v10; // xmm1
			  __int64 v11; // r10
			  Type *v12; // rdx
			  PropertyInfo_1 *v13; // r8
			  Int32__Array **v14; // r9
			  __int128 v15; // xmm1
			  __int64 v16; // r9
			  Type *v17; // rdx
			  PropertyInfo_1 *v18; // r8
			  __m128i v19; // xmm1
			  int v20; // r10d
			  __int128 v21; // xmm0
			  __int64 v22; // r9
			  HGCelestialConfig_CelestialObjectProperty v23; // [rsp+20h] [rbp-50h] BYREF
			  __m256i v24; // [rsp+30h] [rbp-40h] BYREF
			  __int128 v25; // [rsp+50h] [rbp-20h] BYREF
			  __m128i si128; // [rsp+60h] [rbp-10h]
			
			  this->drawPlanetInSkydome = 0;
			  v23 = 0LL;
			  this->drawPlanetBelowHorizon = 1.0;
			  v23.radius = 5600.0;
			  v25 = 1uLL;
			  si128 = _mm_load_si128((const __m128i *)&xmmword_18B959C50);
			  this->objectProperty = v23;
			  sub_18002D1B0(
			    (SingleFieldAccessor *)((char *)&v25 + 8),
			    (Type *)active,
			    (PropertyInfo_1 *)method,
			    (Int32__Array **)this,
			    *(MethodInfo **)&v23.radius);
			  v3 = si128;
			  *(_OWORD *)(v4 + 24) = v25;
			  *(__m128i *)(v4 + 40) = v3;
			  sub_18002D1B0((SingleFieldAccessor *)(v4 + 32), v5, v6, (Int32__Array **)v4, *(MethodInfo **)&v23.radius);
			  *(_BYTE *)(v7 + 56) = v8;
			  v24.m256i_i64[0] = 0x453B8000461C4000LL;
			  *(_OWORD *)&v24.m256i_u64[1] = 0LL;
			  v10 = *UnityEngine::Vector4::get_one((Vector4 *)&v23, v9);
			  v24.m256i_i64[3] = v11;
			  *(Vector4 *)&v24.m256i_u64[1] = v10;
			  sub_18002D1B0((SingleFieldAccessor *)&v24.m256i_u64[3], v12, v13, v14, *(MethodInfo **)&v23.radius);
			  v15 = *(_OWORD *)&v24.m256i_u64[2];
			  *(_OWORD *)(v16 + 64) = *(_OWORD *)v24.m256i_i8;
			  *(_OWORD *)(v16 + 80) = v15;
			  sub_18002D1B0((SingleFieldAccessor *)(v16 + 88), v17, v18, (Int32__Array **)v16, *(MethodInfo **)&v23.radius);
			  v19 = _mm_load_si128((const __m128i *)&xmmword_18B959C60);
			  LODWORD(v25) = v20;
			  *(_QWORD *)((char *)&v25 + 4) = 0x6443A00000LL;
			  HIDWORD(v25) = 50;
			  v21 = v25;
			  *(_BYTE *)(v22 + 96) = v20;
			  *(_OWORD *)(v22 + 100) = v21;
			  *(__m128i *)(v22 + 116) = v19;
			}
			
			static HGCelestialAtmosphereObjectConfig() {
				defaultConfig = default;
			} // 0x00000001848B5810-0x00000001848B5910
			// HGCelestialConfig+HGCelestialAtmosphereObjectConfig()
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAtmosphereObjectConfig::cctor(MethodInfo *method)
			{
			  __int128 v1; // xmm2
			  __int128 v2; // xmm3
			  HGCelestialConfig_HGCelestialAtmosphereObjectConfig__StaticFields *static_fields; // rcx
			  __int128 v4; // xmm4
			  __int128 v5; // xmm5
			  __int128 v6; // xmm6
			  __int128 v7; // xmm7
			  __int128 v8; // xmm8
			  __int64 v9; // xmm0_8
			  Type *v10; // rdx
			  PropertyInfo_1 *v11; // r8
			  Int32__Array **v12; // r9
			  HGCelestialConfig_HGCelestialAtmosphereObjectConfig v13; // [rsp+20h] [rbp-C8h] BYREF
			
			  memset(&v13, 0, sizeof(v13));
			  HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAtmosphereObjectConfig::HGCelestialAtmosphereObjectConfig(
			    &v13,
			    0,
			    0LL);
			  v1 = *(_OWORD *)&v13.objectProperty.selfTiltZ;
			  v2 = *(_OWORD *)&v13.skydomeDrawer.drawMaterial;
			  static_fields = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAtmosphereObjectConfig->static_fields;
			  v4 = *(_OWORD *)&v13.skydomeDrawer.incidentLightingPitchYaw.x;
			  v5 = *(_OWORD *)&v13.ring.outerRadius;
			  v6 = *(_OWORD *)&v13.ring.ringColor.b;
			  v7 = *(_OWORD *)&v13.enableAtmosphere;
			  v8 = *(_OWORD *)&v13.atmosphere.numOpticalDepthSamplePoints;
			  v9 = *(_QWORD *)&v13.atmosphere.atmosphereHueshift;
			  *(_OWORD *)&static_fields->defaultConfig.drawPlanetInSkydome = *(_OWORD *)&v13.drawPlanetInSkydome;
			  *(_OWORD *)&static_fields->defaultConfig.objectProperty.selfTiltZ = v1;
			  *(_OWORD *)&static_fields->defaultConfig.skydomeDrawer.drawMaterial = v2;
			  *(_OWORD *)&static_fields->defaultConfig.skydomeDrawer.incidentLightingPitchYaw.x = v4;
			  *(_OWORD *)&static_fields->defaultConfig.ring.outerRadius = v5;
			  *(_OWORD *)&static_fields->defaultConfig.ring.ringColor.b = v6;
			  *(_OWORD *)&static_fields->defaultConfig.enableAtmosphere = v7;
			  *(_OWORD *)&static_fields->defaultConfig.atmosphere.numOpticalDepthSamplePoints = v8;
			  *(_QWORD *)&static_fields->defaultConfig.atmosphere.atmosphereHueshift = v9;
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAtmosphereObjectConfig->static_fields->defaultConfig.skydomeDrawer.drawMaterial,
			    v10,
			    v11,
			    v12,
			    *(MethodInfo **)&v13.drawPlanetInSkydome);
			}
			
	
			// Methods
			public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
				where T : struct, IEnvConfig {}
		}
	
		[Serializable]
		public struct HGCelestialObjectConfig : IEnvConfig // TypeDefIndex: 37587
		{
			// Fields
			[FormerlySerializedAs("objectProperty.radius")]
			[Header("\u5929\u4F53\u534A\u5F84")]
			[Range(1f, 79000f)]
			public float radius; // 0x00
			[FormerlySerializedAs("orbit.radius")]
			[Header("\u8F68\u9053\u534A\u5F84")]
			public float orbitRadius; // 0x04
			[FormerlySerializedAs("enableRing")]
			[Header("\u5149\u73AF\u8BBE\u5B9A")]
			public bool enableRing; // 0x08
			[Header("\u5730\u5E73\u7EBF\u4E0B\u661F\u73AF\u4E0D\u53EF\u89C1\u5EA6")]
			[UnclampedRange(0f, 1f)]
			public float drawPlanetBelowHorizon; // 0x0C
			[FormerlySerializedAs("HGCelestialConfig.worldLongitude")]
			[Header("\u672C\u5730\u56FE\u6240\u5904\u7ECF\u5EA6")]
			[Range(0f, 360f)]
			public float worldLongitude; // 0x10
			[FormerlySerializedAs("HGCelestialConfig.worldLatitude")]
			[Header("\u672C\u5730\u56FE\u6240\u5904\u7EAC\u5EA6")]
			[Range(-90f, 90f)]
			public float worldLatitude; // 0x14
			[FormerlySerializedAs("HGCelestialConfig.rotationAroundUp")]
			[Header("\u5854\u536B\u4E8C\u7ED5 Y \u8F74\u65CB\u8F6C\u89D2\u5EA6")]
			[Range(0f, 360f)]
			public float rotationAroundUp; // 0x18
			public RingProperty ring; // 0x20
			public static HGCelestialObjectConfig defaultConfig; // 0x00
	
			// Properties
			public bool active { get => default; set {} } // 0x0000000189C6E2DC-0x0000000189C6E328 0x0000000189C6E328-0x0000000189C6E37C
			// Boolean get_active()
			bool HG::Rendering::Runtime::HGCelestialConfig::HGCelestialObjectConfig::get_active(
			        HGCelestialConfig_HGCelestialObjectConfig *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(1335, 0LL) )
			    return 1;
			  Patch = IFix::WrappersManagerImpl::GetPatch(1335, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v6, v5);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_522(Patch, this, 0LL);
			}
			

			// Void set_active(Boolean)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialObjectConfig::set_active(
			        HGCelestialConfig_HGCelestialObjectConfig *this,
			        bool value,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1336, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1336, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_523(Patch, this, value, 0LL);
			  }
			}
			
	
			// Constructors
			public HGCelestialObjectConfig(bool active) : this() {
				radius = default;
				orbitRadius = default;
				enableRing = default;
				drawPlanetBelowHorizon = default;
				worldLongitude = default;
				worldLatitude = default;
				rotationAroundUp = default;
				ring = default;
			} // 0x00000001848B5A90-0x00000001848B5B20
			// HGCelestialConfig+HGCelestialObjectConfig(Boolean)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialObjectConfig::HGCelestialObjectConfig(
			        HGCelestialConfig_HGCelestialObjectConfig *this,
			        bool active,
			        MethodInfo *method)
			{
			  Vector4 v3; // xmm1
			  Type *v4; // rdx
			  PropertyInfo_1 *v5; // r8
			  Int32__Array **v6; // r9
			  __int128 v7; // xmm1
			  __int64 v8; // r9
			  Type *v9; // rdx
			  PropertyInfo_1 *v10; // r8
			  Vector4 v11; // [rsp+20h] [rbp-38h] BYREF
			  __m256i v12; // [rsp+30h] [rbp-28h] BYREF
			
			  this->radius = 5600.0;
			  this->orbitRadius = 185000.0;
			  this->enableRing = 0;
			  *(_QWORD *)&this->drawPlanetBelowHorizon = 1065353216LL;
			  *(_QWORD *)&this->worldLatitude = 1110704128LL;
			  *(_OWORD *)&v12.m256i_u64[1] = 0LL;
			  v12.m256i_i64[0] = 0x453B8000461C4000LL;
			  v3 = *UnityEngine::Vector4::get_one(&v11, 0LL);
			  v12.m256i_i64[3] = (__int64)v4;
			  *(Vector4 *)&v12.m256i_u64[1] = v3;
			  sub_18002D1B0((SingleFieldAccessor *)&v12.m256i_u64[3], v4, v5, v6, *(MethodInfo **)&v11.x);
			  v7 = *(_OWORD *)&v12.m256i_u64[2];
			  *(_OWORD *)(v8 + 32) = *(_OWORD *)v12.m256i_i8;
			  *(_OWORD *)(v8 + 48) = v7;
			  sub_18002D1B0((SingleFieldAccessor *)(v8 + 56), v9, v10, (Int32__Array **)v8, *(MethodInfo **)&v11.x);
			}
			
			static HGCelestialObjectConfig() {
				defaultConfig = default;
			} // 0x00000001848B5910-0x00000001848B5990
			// HGCelestialConfig+HGCelestialObjectConfig()
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialObjectConfig::cctor(MethodInfo *method)
			{
			  __int128 v1; // xmm1
			  __int128 v2; // xmm2
			  HGCelestialConfig_HGCelestialObjectConfig__StaticFields *static_fields; // rcx
			  __int128 v4; // xmm3
			  Type *v5; // rdx
			  PropertyInfo_1 *v6; // r8
			  Int32__Array **v7; // r9
			  HGCelestialConfig_HGCelestialObjectConfig v8; // [rsp+20h] [rbp-48h] BYREF
			
			  memset(&v8, 0, sizeof(v8));
			  HG::Rendering::Runtime::HGCelestialConfig::HGCelestialObjectConfig::HGCelestialObjectConfig(&v8, 0, 0LL);
			  v1 = *(_OWORD *)&v8.worldLongitude;
			  v2 = *(_OWORD *)&v8.ring.outerRadius;
			  static_fields = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialObjectConfig->static_fields;
			  v4 = *(_OWORD *)&v8.ring.ringColor.b;
			  *(_OWORD *)&static_fields->defaultConfig.radius = *(_OWORD *)&v8.radius;
			  *(_OWORD *)&static_fields->defaultConfig.worldLongitude = v1;
			  *(_OWORD *)&static_fields->defaultConfig.ring.outerRadius = v2;
			  *(_OWORD *)&static_fields->defaultConfig.ring.ringColor.b = v4;
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialObjectConfig->static_fields->defaultConfig.ring.planetRingMap,
			    v5,
			    v6,
			    v7,
			    *(MethodInfo **)&v8.radius);
			}
			
	
			// Methods
			public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
				where T : struct, IEnvConfig {}
		}
	
		[Serializable]
		public struct HGCelestialAdvancedObjectConfig : IEnvConfig // TypeDefIndex: 37588
		{
			// Fields
			[Header("\u7ED8\u5236\u4E00\u4E2A\u9AD8\u7CBE\u5EA6\u661F\u7403")]
			public bool drawAdvancedPlanet; // 0x00
			[Header("\u9AD8\u7CBE\u5EA6\u661F\u7403\u6750\u8D28")]
			public Material advancedPlanetMat; // 0x08
			public static HGCelestialAdvancedObjectConfig defaultConfig; // 0x00
	
			// Properties
			public bool active { get => default; set {} } // 0x0000000189C6DA04-0x0000000189C6DA50 0x0000000189C6DA50-0x0000000189C6DAA4
			// Boolean get_active()
			bool HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::get_active(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(1337, 0LL) )
			    return 1;
			  Patch = IFix::WrappersManagerImpl::GetPatch(1337, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v6, v5);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_524(Patch, this, 0LL);
			}
			

			// Void set_active(Boolean)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::set_active(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        bool value,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1338, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1338, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_525(Patch, this, value, 0LL);
			  }
			}
			
	
			// Constructors
			public HGCelestialAdvancedObjectConfig(bool active) : this() {
				drawAdvancedPlanet = default;
				advancedPlanetMat = default;
			} // 0x0000000185398294-0x00000001853982A8
			// HGCelestialConfig+HGCelestialAdvancedObjectConfig(Boolean)
			// local variable allocation has failed, the output may be wrong!
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::HGCelestialAdvancedObjectConfig(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        bool active,
			        MethodInfo *method)
			{
			  Int32__Array **v3; // r9
			  MethodInfo *v4; // [rsp+28h] [rbp+28h]
			
			  this->drawAdvancedPlanet = 0;
			  this->advancedPlanetMat = 0LL;
			  sub_18002D1B0((SingleFieldAccessor *)&this->advancedPlanetMat, (Type *)active, (PropertyInfo_1 *)method, v3, v4);
			}
			
			static HGCelestialAdvancedObjectConfig() {
				defaultConfig = default;
			} // 0x0000000184D56FF0-0x0000000184D57040
			// HGCelestialConfig+HGCelestialAdvancedObjectConfig()
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::cctor(MethodInfo *method)
			{
			  Type *v1; // rdx
			  PropertyInfo_1 *v2; // r8
			  Int32__Array **v3; // r9
			  Type *v4; // rdx
			  PropertyInfo_1 *v5; // r8
			  Int32__Array **v6; // r9
			  HGCelestialConfig_HGCelestialAdvancedObjectConfig__StaticFields v7; // [rsp+20h] [rbp-18h] BYREF
			
			  v7 = 0LL;
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&v7.defaultConfig.advancedPlanetMat,
			    v1,
			    v2,
			    v3,
			    *(MethodInfo **)&v7.defaultConfig.drawAdvancedPlanet);
			  *TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig->static_fields = v7;
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig->static_fields->defaultConfig.advancedPlanetMat,
			    v4,
			    v5,
			    v6,
			    *(MethodInfo **)&v7.defaultConfig.drawAdvancedPlanet);
			}
			
	
			// Methods
			public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
				where T : struct, IEnvConfig {}
		}
	
		[Serializable]
		public struct CelestialObjectProperty : IEnvConfig // TypeDefIndex: 37589
		{
			// Fields
			[Header("\u5929\u4F53\u534A\u5F84")]
			[Range(1f, 79000f)]
			public float radius; // 0x00
			[Header("\u81EA\u8F6C\u503E\u89D2-X \uFF08\u76F8\u5BF9\u4E8E\u8F68\u9053\u7A7A\u95F4\uFF09")]
			[Range(-90f, 90f)]
			public float selfTiltX; // 0x04
			[Header("\u81EA\u8F6C\u503E\u89D2-Z \uFF08\u76F8\u5BF9\u4E8E\u8F68\u9053\u7A7A\u95F4\uFF09")]
			[Range(-90f, 90f)]
			public float selfTiltZ; // 0x08
			[Header("\u81EA\u8F6C")]
			[Range(0f, 360f)]
			public float selfRotationY; // 0x0C
			public static CelestialObjectProperty defaultConfig; // 0x00
	
			// Properties
			public bool active { get => default; set {} } // 0x0000000189C67134-0x0000000189C67180 0x0000000189C67180-0x0000000189C671D4
			// Boolean get_active()
			bool HG::Rendering::Runtime::HGCelestialConfig::CelestialObjectProperty::get_active(
			        HGCelestialConfig_CelestialObjectProperty *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(1339, 0LL) )
			    return 1;
			  Patch = IFix::WrappersManagerImpl::GetPatch(1339, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v6, v5);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_526(Patch, this, 0LL);
			}
			

			// Void set_active(Boolean)
			void HG::Rendering::Runtime::HGCelestialConfig::CelestialObjectProperty::set_active(
			        HGCelestialConfig_CelestialObjectProperty *this,
			        bool value,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1340, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1340, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_527(Patch, this, value, 0LL);
			  }
			}
			
	
			// Constructors
			public CelestialObjectProperty(bool active) : this() {
				radius = default;
				selfTiltX = default;
				selfTiltZ = default;
				selfRotationY = default;
			} // 0x0000000184DA1F10-0x0000000184DA1F20
			// HGCelestialConfig+CelestialObjectProperty(Boolean)
			void HG::Rendering::Runtime::HGCelestialConfig::CelestialObjectProperty::CelestialObjectProperty(
			        HGCelestialConfig_CelestialObjectProperty *this,
			        bool active,
			        MethodInfo *method)
			{
			  *(_QWORD *)&this->radius = 1169096704LL;
			  *(_QWORD *)&this->selfTiltZ = 0LL;
			}
			
			static CelestialObjectProperty() {
				defaultConfig = default;
			} // 0x0000000184DA1EF0-0x0000000184DA1F10
			// HGCelestialConfig+CelestialObjectProperty()
			void HG::Rendering::Runtime::HGCelestialConfig::CelestialObjectProperty::cctor(MethodInfo *method)
			{
			  *(__m128i *)TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::CelestialObjectProperty->static_fields = _mm_load_si128((const __m128i *)&xmmword_18DA45990);
			}
			
	
			// Methods
			public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
				where T : struct, IEnvConfig {}
		}
	
		[Serializable]
		public struct CelestialDrawer : IEnvConfig // TypeDefIndex: 37591
		{
			// Fields
			[Header("\u7ED8\u5236\u6A21\u5F0F")]
			public DrawMode drawMode; // 0x00
			[Header("\u5929\u5E55\u7ED8\u5236\u6750\u8D28")]
			public Material drawMaterial; // 0x08
			[Header("\u7ED8\u5236 Pitch Yaw")]
			public Vector2 pitchYaw; // 0x10
			[Header("\u661F\u7403\u5165\u5C04 Pitch Yaw")]
			public Vector2 incidentLightingPitchYaw; // 0x18
			public static CelestialDrawer defaultConfig; // 0x00
	
			// Properties
			public bool active { get => default; set {} } // 0x0000000189C67094-0x0000000189C670E0 0x0000000189C670E0-0x0000000189C67134
			// Boolean get_active()
			bool HG::Rendering::Runtime::HGCelestialConfig::CelestialDrawer::get_active(
			        HGCelestialConfig_CelestialDrawer *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(1341, 0LL) )
			    return 1;
			  Patch = IFix::WrappersManagerImpl::GetPatch(1341, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v6, v5);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_528(Patch, this, 0LL);
			}
			

			// Void set_active(Boolean)
			void HG::Rendering::Runtime::HGCelestialConfig::CelestialDrawer::set_active(
			        HGCelestialConfig_CelestialDrawer *this,
			        bool value,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1342, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1342, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_529(Patch, this, value, 0LL);
			  }
			}
			
	
			// Nested types
			public enum DrawMode // TypeDefIndex: 37590
			{
				Texture = 0,
				Simulated = 1
			}
	
			// Constructors
			public CelestialDrawer(bool active) : this() {
				drawMode = default;
				drawMaterial = default;
				pitchYaw = default;
				incidentLightingPitchYaw = default;
			} // 0x0000000189C67050-0x0000000189C67094
			// HGCelestialConfig+CelestialDrawer(Boolean)
			// local variable allocation has failed, the output may be wrong!
			void HG::Rendering::Runtime::HGCelestialConfig::CelestialDrawer::CelestialDrawer(
			        HGCelestialConfig_CelestialDrawer *this,
			        bool active,
			        MethodInfo *method)
			{
			  _DWORD *v3; // r9
			  MethodInfo *v4; // [rsp+20h] [rbp-8h]
			
			  this->drawMode = 1;
			  this->drawMaterial = 0LL;
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&this->drawMaterial,
			    (Type *)active,
			    (PropertyInfo_1 *)method,
			    (Int32__Array **)this,
			    v4);
			  v3[4] = 1124859904;
			  v3[5] = 1127481344;
			  v3[6] = 1124466688;
			  v3[7] = 1130364928;
			}
			
			static CelestialDrawer() {
				defaultConfig = default;
			} // 0x0000000189C66FF4-0x0000000189C67050
			// HGCelestialConfig+CelestialDrawer()
			void HG::Rendering::Runtime::HGCelestialConfig::CelestialDrawer::cctor(MethodInfo *method)
			{
			  __int128 v1; // xmm1
			  HGCelestialConfig_CelestialDrawer__StaticFields *static_fields; // rcx
			  Type *v3; // rdx
			  PropertyInfo_1 *v4; // r8
			  Int32__Array **v5; // r9
			  HGCelestialConfig_CelestialDrawer v6; // [rsp+20h] [rbp-28h] BYREF
			
			  memset(&v6, 0, sizeof(v6));
			  HG::Rendering::Runtime::HGCelestialConfig::CelestialDrawer::CelestialDrawer(&v6, 0, 0LL);
			  v1 = *(_OWORD *)&v6.pitchYaw.x;
			  static_fields = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::CelestialDrawer->static_fields;
			  *(_OWORD *)&static_fields->defaultConfig.drawMode = *(_OWORD *)&v6.drawMode;
			  *(_OWORD *)&static_fields->defaultConfig.pitchYaw.x = v1;
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::CelestialDrawer->static_fields->defaultConfig.drawMaterial,
			    v3,
			    v4,
			    v5,
			    *(MethodInfo **)&v6.drawMode);
			}
			
	
			// Methods
			public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
				where T : struct, IEnvConfig {}
		}
	
		[Serializable]
		public struct AtmosphereProperty : IEnvConfig // TypeDefIndex: 37592
		{
			// Fields
			[Header("\u80CC\u5149\u9762\u53EF\u89C1\u5EA6 Backface Visibility")]
			[Range(0f, 1f)]
			public float bakeFaceVisibility; // 0x00
			[Header("\u5927\u6C14\u9AD8\u5EA6 Atmosphere Height")]
			[Range(1f, 1000f)]
			public float atmosphereHeight; // 0x04
			[Header("\u6563\u5C04\u5916\u91C7\u6837 Outer Scatter Sample")]
			[HideInInspector]
			[Range(1f, 100f)]
			public int numInscatteredSamplePoints; // 0x08
			[Header("\u6563\u5C04\u5185\u91C7\u6837 Inner Scatter Sample")]
			[HideInInspector]
			[Range(1f, 100f)]
			public int numOpticalDepthSamplePoints; // 0x0C
			[Header("\u6563\u5C04\u5BF9\u6BD4 Scatter Contrast")]
			[Range(0.01f, 10f)]
			public float coff_R; // 0x10
			[Header("\u6563\u5C04\u9AD8\u5EA6\u7CFB\u6570 Scatter Strength")]
			[Range(0.01f, 30f)]
			public float heightScale_R; // 0x14
			[Header("\u6563\u5C04\u6574\u4F53\u4EAE\u5EA6 Scatter Brightness")]
			[Range(0.01f, 200f)]
			public float atmosphereBrightness; // 0x18
			[Header("\u6563\u5C04\u8272\u8C03\u504F\u79FB Scatter Hueshift")]
			[Range(-1f, 1f)]
			public float atmosphereHueshift; // 0x1C
			public static AtmosphereProperty defaultConfig; // 0x00
	
			// Properties
			public bool active { get => default; set {} } // 0x0000000189C66F54-0x0000000189C66FA0 0x0000000189C66FA0-0x0000000189C66FF4
			// Boolean get_active()
			bool HG::Rendering::Runtime::HGCelestialConfig::AtmosphereProperty::get_active(
			        HGCelestialConfig_AtmosphereProperty *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(1343, 0LL) )
			    return 1;
			  Patch = IFix::WrappersManagerImpl::GetPatch(1343, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v6, v5);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_530(Patch, this, 0LL);
			}
			

			// Void set_active(Boolean)
			void HG::Rendering::Runtime::HGCelestialConfig::AtmosphereProperty::set_active(
			        HGCelestialConfig_AtmosphereProperty *this,
			        bool value,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1344, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1344, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_531(Patch, this, value, 0LL);
			  }
			}
			
	
			// Constructors
			public AtmosphereProperty(bool active) : this() {
				bakeFaceVisibility = default;
				atmosphereHeight = default;
				numInscatteredSamplePoints = default;
				numOpticalDepthSamplePoints = default;
				coff_R = default;
				heightScale_R = default;
				atmosphereBrightness = default;
				atmosphereHueshift = default;
			} // 0x0000000184DA1EC0-0x0000000184DA1EF0
			// HGCelestialConfig+AtmosphereProperty(Boolean)
			void HG::Rendering::Runtime::HGCelestialConfig::AtmosphereProperty::AtmosphereProperty(
			        HGCelestialConfig_AtmosphereProperty *this,
			        bool active,
			        MethodInfo *method)
			{
			  this->atmosphereHeight = 69.0;
			  this->bakeFaceVisibility = 0.0;
			  this->numInscatteredSamplePoints = 10;
			  this->numOpticalDepthSamplePoints = 10;
			  this->coff_R = 10.0;
			  this->heightScale_R = 22.0;
			  *(_QWORD *)&this->atmosphereBrightness = 1117782016LL;
			}
			
			static AtmosphereProperty() {
				defaultConfig = default;
			} // 0x0000000184DA1E70-0x0000000184DA1EC0
			// HGCelestialConfig+AtmosphereProperty()
			void HG::Rendering::Runtime::HGCelestialConfig::AtmosphereProperty::cctor(MethodInfo *method)
			{
			  __m128i si128; // xmm1
			  HGCelestialConfig_AtmosphereProperty__StaticFields *static_fields; // rcx
			  __int128 v3; // [rsp+0h] [rbp-28h]
			
			  si128 = _mm_load_si128((const __m128i *)&xmmword_18DA45A00);
			  *(_QWORD *)&v3 = 0x428A000000000000LL;
			  static_fields = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::AtmosphereProperty->static_fields;
			  *((_QWORD *)&v3 + 1) = 0xA0000000ALL;
			  *(_OWORD *)&static_fields->defaultConfig.bakeFaceVisibility = v3;
			  *(__m128i *)&static_fields->defaultConfig.coff_R = si128;
			}
			
	
			// Methods
			public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
				where T : struct, IEnvConfig {}
		}
	
		[Serializable]
		public struct RingProperty : IEnvConfig // TypeDefIndex: 37593
		{
			// Fields
			[Header("\u661F\u73AF\u5916\u534A\u5F84")]
			[Range(0f, 160000f)]
			public float outerRadius; // 0x00
			[Header("\u661F\u73AF\u5BBD\u5EA6")]
			[Range(0f, 50000f)]
			public float width; // 0x04
			[ColorUsage(true, true)]
			[Header("\u5149\u73AF\u989C\u8272\u4E0E\u900F\u660E\u5EA6")]
			public UnityEngine.Color ringColor; // 0x08
			[Header("\u5149\u73AF\u8D34\u56FE")]
			public Texture planetRingMap; // 0x18
	
			// Properties
			public bool active { get => default; set {} } // 0x0000000189C6FF3C-0x0000000189C6FF88 0x0000000189C6FF88-0x0000000189C6FFDC
			// Boolean get_active()
			bool HG::Rendering::Runtime::HGCelestialConfig::RingProperty::get_active(
			        HGCelestialConfig_RingProperty *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(1345, 0LL) )
			    return 1;
			  Patch = IFix::WrappersManagerImpl::GetPatch(1345, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v6, v5);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_532(Patch, this, 0LL);
			}
			

			// Void set_active(Boolean)
			void HG::Rendering::Runtime::HGCelestialConfig::RingProperty::set_active(
			        HGCelestialConfig_RingProperty *this,
			        bool value,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1346, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1346, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_533(Patch, this, value, 0LL);
			  }
			}
			
	
			// Methods
			public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
				where T : struct, IEnvConfig {}
		}
	
		// Constructors
		public HGCelestialConfig(bool active) : this() {
			moonConfig = default;
			talosAlphaConfig = default;
			planetConfig = default;
			advancedPlanetConfig = default;
			m_active = default;
		} // 0x00000001848AEDF0-0x00000001848AEFC0
		// HGCelestialConfig(Boolean)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialConfig(
		        HGCelestialConfig *this,
		        bool active,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  struct HGCelestialConfig_HGCelestialObjectConfig__Class *v5; // rax
		  _OWORD *p_radius; // rax
		  __int128 v7; // xmm1
		  __int128 v8; // xmm2
		  __int128 v9; // xmm3
		  Type *v10; // rdx
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  struct HGCelestialConfig_HGCelestialAtmosphereObjectConfig__Class *v13; // rax
		  HGCelestialConfig_HGCelestialAtmosphereObjectConfig__StaticFields *static_fields; // rax
		  __int128 v15; // xmm2
		  __int128 v16; // xmm3
		  __int128 v17; // xmm4
		  __int128 v18; // xmm5
		  __int128 v19; // xmm6
		  __int128 v20; // xmm7
		  __int128 v21; // xmm8
		  __int64 v22; // xmm0_8
		  Int32__Array **v23; // r9
		  HGCelestialConfig_HGCelestialAtmosphereObjectConfig__StaticFields *v24; // rax
		  __int128 v25; // xmm2
		  __int128 v26; // xmm3
		  __int128 v27; // xmm4
		  __int128 v28; // xmm5
		  __int128 v29; // xmm6
		  __int128 v30; // xmm7
		  __int128 v31; // xmm8
		  __int64 v32; // xmm0_8
		  Type *v33; // rdx
		  PropertyInfo_1 *v34; // r8
		  Type *v35; // rdx
		  PropertyInfo_1 *v36; // r8
		  Int32__Array **v37; // r9
		  struct HGCelestialConfig_HGCelestialAdvancedObjectConfig__Class *v38; // rax
		  MethodInfo *v39; // [rsp+20h] [rbp-38h]
		  MethodInfo *v40; // [rsp+20h] [rbp-38h]
		  MethodInfo *v41; // [rsp+20h] [rbp-38h]
		  MethodInfo *v42; // [rsp+80h] [rbp+28h]
		
		  this->m_active = 0;
		  v5 = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialObjectConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialObjectConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialObjectConfig);
		    v5 = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialObjectConfig;
		  }
		  p_radius = (_OWORD *)&v5->static_fields->defaultConfig.radius;
		  v7 = p_radius[1];
		  v8 = p_radius[2];
		  v9 = p_radius[3];
		  *(_OWORD *)&this->moonConfig.radius = *p_radius;
		  *(_OWORD *)&this->moonConfig.worldLongitude = v7;
		  *(_OWORD *)&this->moonConfig.ring.outerRadius = v8;
		  *(_OWORD *)&this->moonConfig.ring.ringColor.b = v9;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->moonConfig.ring.planetRingMap,
		    (Type *)active,
		    (PropertyInfo_1 *)method,
		    v3,
		    v39);
		  v13 = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAtmosphereObjectConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAtmosphereObjectConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAtmosphereObjectConfig);
		    v13 = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAtmosphereObjectConfig;
		  }
		  static_fields = v13->static_fields;
		  v15 = *(_OWORD *)&static_fields->defaultConfig.objectProperty.selfTiltZ;
		  v16 = *(_OWORD *)&static_fields->defaultConfig.skydomeDrawer.drawMaterial;
		  v17 = *(_OWORD *)&static_fields->defaultConfig.skydomeDrawer.incidentLightingPitchYaw.x;
		  v18 = *(_OWORD *)&static_fields->defaultConfig.ring.outerRadius;
		  v19 = *(_OWORD *)&static_fields->defaultConfig.ring.ringColor.b;
		  v20 = *(_OWORD *)&static_fields->defaultConfig.enableAtmosphere;
		  v21 = *(_OWORD *)&static_fields->defaultConfig.atmosphere.numOpticalDepthSamplePoints;
		  v22 = *(_QWORD *)&static_fields->defaultConfig.atmosphere.atmosphereHueshift;
		  *(_OWORD *)&this->talosAlphaConfig.drawPlanetInSkydome = *(_OWORD *)&static_fields->defaultConfig.drawPlanetInSkydome;
		  *(_OWORD *)&this->talosAlphaConfig.objectProperty.selfTiltZ = v15;
		  *(_OWORD *)&this->talosAlphaConfig.skydomeDrawer.drawMaterial = v16;
		  *(_OWORD *)&this->talosAlphaConfig.skydomeDrawer.incidentLightingPitchYaw.x = v17;
		  *(_OWORD *)&this->talosAlphaConfig.ring.outerRadius = v18;
		  *(_OWORD *)&this->talosAlphaConfig.ring.ringColor.b = v19;
		  *(_OWORD *)&this->talosAlphaConfig.enableAtmosphere = v20;
		  *(_OWORD *)&this->talosAlphaConfig.atmosphere.numOpticalDepthSamplePoints = v21;
		  *(_QWORD *)&this->talosAlphaConfig.atmosphere.atmosphereHueshift = v22;
		  sub_18002D1B0((SingleFieldAccessor *)&this->talosAlphaConfig.skydomeDrawer.drawMaterial, v10, v11, v12, v40);
		  v23 = (Int32__Array **)TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAtmosphereObjectConfig;
		  v24 = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAtmosphereObjectConfig->static_fields;
		  v25 = *(_OWORD *)&v24->defaultConfig.objectProperty.selfTiltZ;
		  v26 = *(_OWORD *)&v24->defaultConfig.skydomeDrawer.drawMaterial;
		  v27 = *(_OWORD *)&v24->defaultConfig.skydomeDrawer.incidentLightingPitchYaw.x;
		  v28 = *(_OWORD *)&v24->defaultConfig.ring.outerRadius;
		  v29 = *(_OWORD *)&v24->defaultConfig.ring.ringColor.b;
		  v30 = *(_OWORD *)&v24->defaultConfig.enableAtmosphere;
		  v31 = *(_OWORD *)&v24->defaultConfig.atmosphere.numOpticalDepthSamplePoints;
		  v32 = *(_QWORD *)&v24->defaultConfig.atmosphere.atmosphereHueshift;
		  *(_OWORD *)&this->planetConfig.drawPlanetInSkydome = *(_OWORD *)&v24->defaultConfig.drawPlanetInSkydome;
		  *(_OWORD *)&this->planetConfig.objectProperty.selfTiltZ = v25;
		  *(_OWORD *)&this->planetConfig.skydomeDrawer.drawMaterial = v26;
		  *(_OWORD *)&this->planetConfig.skydomeDrawer.incidentLightingPitchYaw.x = v27;
		  *(_OWORD *)&this->planetConfig.ring.outerRadius = v28;
		  *(_OWORD *)&this->planetConfig.ring.ringColor.b = v29;
		  *(_OWORD *)&this->planetConfig.enableAtmosphere = v30;
		  *(_OWORD *)&this->planetConfig.atmosphere.numOpticalDepthSamplePoints = v31;
		  *(_QWORD *)&this->planetConfig.atmosphere.atmosphereHueshift = v32;
		  sub_18002D1B0((SingleFieldAccessor *)&this->planetConfig.skydomeDrawer.drawMaterial, v33, v34, v23, v41);
		  v38 = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig);
		    v38 = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig;
		  }
		  this->advancedPlanetConfig = v38->static_fields->defaultConfig;
		  sub_18002D1B0((SingleFieldAccessor *)&this->advancedPlanetConfig.advancedPlanetMat, v35, v36, v37, v42);
		}
		
		static HGCelestialConfig() {
			defaultConfig = default;
		} // 0x00000001848AEC60-0x00000001848AEDF0
		// HGCelestialConfig()
		void HG::Rendering::Runtime::HGCelestialConfig::cctor(MethodInfo *method)
		{
		  Int32__Array **v1; // r9
		  __int64 v2; // r8
		  _BYTE *v3; // rcx
		  __int64 v4; // rdx
		  HGCelestialConfig *v5; // rax
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
		  __int128 v18; // xmm1
		  Material *drawMaterial; // rax
		  HGCelestialConfig__StaticFields *static_fields; // rdx
		  _BYTE *v21; // rax
		  __int128 v22; // xmm0
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  __int128 v26; // xmm0
		  __int128 v27; // xmm1
		  __int128 v28; // xmm0
		  __int128 v29; // xmm1
		  Material *v30; // rcx
		  __int128 v31; // xmm1
		  __int128 v32; // xmm0
		  __int128 v33; // xmm1
		  __int128 v34; // xmm0
		  __int128 v35; // xmm1
		  HGCelestialConfig v36; // [rsp+20h] [rbp-2E8h] BYREF
		  _BYTE v37[376]; // [rsp+190h] [rbp-178h] BYREF
		
		  sub_18033B9D0(&v36, 0LL, 360LL);
		  HG::Rendering::Runtime::HGCelestialConfig::HGCelestialConfig(&v36, 0, 0LL);
		  v2 = 2LL;
		  v3 = v37;
		  v4 = 2LL;
		  v5 = &v36;
		  do
		  {
		    v3 += 128;
		    v6 = *(_OWORD *)&v5->moonConfig.radius;
		    v7 = *(_OWORD *)&v5->moonConfig.worldLongitude;
		    v5 = (HGCelestialConfig *)((char *)v5 + 128);
		    *((_OWORD *)v3 - 8) = v6;
		    v8 = *(_OWORD *)&v5[-1].planetConfig.ring.outerRadius;
		    *((_OWORD *)v3 - 7) = v7;
		    v9 = *(_OWORD *)&v5[-1].planetConfig.ring.ringColor.b;
		    *((_OWORD *)v3 - 6) = v8;
		    v10 = *(_OWORD *)&v5[-1].planetConfig.enableAtmosphere;
		    *((_OWORD *)v3 - 5) = v9;
		    v11 = *(_OWORD *)&v5[-1].planetConfig.atmosphere.numOpticalDepthSamplePoints;
		    *((_OWORD *)v3 - 4) = v10;
		    v12 = *(_OWORD *)&v5[-1].planetConfig.atmosphere.atmosphereHueshift;
		    *((_OWORD *)v3 - 3) = v11;
		    v13 = *(_OWORD *)&v5[-1].advancedPlanetConfig.advancedPlanetMat;
		    *((_OWORD *)v3 - 2) = v12;
		    *((_OWORD *)v3 - 1) = v13;
		    --v4;
		  }
		  while ( v4 );
		  v14 = *(_OWORD *)&v5->moonConfig.worldLongitude;
		  *(_OWORD *)v3 = *(_OWORD *)&v5->moonConfig.radius;
		  v15 = *(_OWORD *)&v5->moonConfig.ring.outerRadius;
		  *((_OWORD *)v3 + 1) = v14;
		  v16 = *(_OWORD *)&v5->moonConfig.ring.ringColor.b;
		  *((_OWORD *)v3 + 2) = v15;
		  v17 = *(_OWORD *)&v5->talosAlphaConfig.drawPlanetInSkydome;
		  *((_OWORD *)v3 + 3) = v16;
		  v18 = *(_OWORD *)&v5->talosAlphaConfig.objectProperty.selfTiltZ;
		  drawMaterial = v5->talosAlphaConfig.skydomeDrawer.drawMaterial;
		  *((_OWORD *)v3 + 4) = v17;
		  *((_OWORD *)v3 + 5) = v18;
		  *((_QWORD *)v3 + 12) = drawMaterial;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGCelestialConfig->static_fields;
		  v21 = v37;
		  do
		  {
		    static_fields = (HGCelestialConfig__StaticFields *)((char *)static_fields + 128);
		    v22 = *(_OWORD *)v21;
		    v23 = *((_OWORD *)v21 + 1);
		    v21 += 128;
		    *(_OWORD *)&static_fields[-1].defaultConfig.planetConfig.skydomeDrawer.drawMaterial = v22;
		    v24 = *((_OWORD *)v21 - 6);
		    *(_OWORD *)&static_fields[-1].defaultConfig.planetConfig.skydomeDrawer.incidentLightingPitchYaw.x = v23;
		    v25 = *((_OWORD *)v21 - 5);
		    *(_OWORD *)&static_fields[-1].defaultConfig.planetConfig.ring.outerRadius = v24;
		    v26 = *((_OWORD *)v21 - 4);
		    *(_OWORD *)&static_fields[-1].defaultConfig.planetConfig.ring.ringColor.b = v25;
		    v27 = *((_OWORD *)v21 - 3);
		    *(_OWORD *)&static_fields[-1].defaultConfig.planetConfig.enableAtmosphere = v26;
		    v28 = *((_OWORD *)v21 - 2);
		    *(_OWORD *)&static_fields[-1].defaultConfig.planetConfig.atmosphere.numOpticalDepthSamplePoints = v27;
		    v29 = *((_OWORD *)v21 - 1);
		    *(_OWORD *)&static_fields[-1].defaultConfig.planetConfig.atmosphere.atmosphereHueshift = v28;
		    *(_OWORD *)&static_fields[-1].defaultConfig.advancedPlanetConfig.advancedPlanetMat = v29;
		    --v2;
		  }
		  while ( v2 );
		  v30 = (Material *)*((_QWORD *)v21 + 12);
		  v31 = *((_OWORD *)v21 + 1);
		  *(_OWORD *)&static_fields->defaultConfig.moonConfig.radius = *(_OWORD *)v21;
		  v32 = *((_OWORD *)v21 + 2);
		  *(_OWORD *)&static_fields->defaultConfig.moonConfig.worldLongitude = v31;
		  v33 = *((_OWORD *)v21 + 3);
		  *(_OWORD *)&static_fields->defaultConfig.moonConfig.ring.outerRadius = v32;
		  v34 = *((_OWORD *)v21 + 4);
		  *(_OWORD *)&static_fields->defaultConfig.moonConfig.ring.ringColor.b = v33;
		  v35 = *((_OWORD *)v21 + 5);
		  *(_OWORD *)&static_fields->defaultConfig.talosAlphaConfig.drawPlanetInSkydome = v34;
		  *(_OWORD *)&static_fields->defaultConfig.talosAlphaConfig.objectProperty.selfTiltZ = v35;
		  static_fields->defaultConfig.talosAlphaConfig.skydomeDrawer.drawMaterial = v30;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGCelestialConfig->static_fields->defaultConfig.moonConfig.ring.planetRingMap,
		    (Type *)static_fields,
		    0LL,
		    v1,
		    *(MethodInfo **)&v36.moonConfig.radius);
		}
		
	
		// Methods
		public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
			where T : struct, IEnvConfig {}
		private static float PercentageDeg(float deg) => default; // 0x0000000189C6E27C-0x0000000189C6E2DC
		// Single PercentageDeg(Single)
		float HG::Rendering::Runtime::HGCelestialConfig::PercentageDeg(float deg, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1329, 0LL) )
		    return deg * 0.011111111;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1329, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v5, v4);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_516(Patch, deg, 0LL);
		}
		
		public void GetMapWorldSpaceBasisInPlanetSpace(out Vector3 up, out Vector3 forward, out Vector3 right) {
			up = default;
			forward = default;
			right = default;
		} // 0x0000000189C6DEEC-0x0000000189C6E27C
		// Void GetMapWorldSpaceBasisInPlanetSpace(Vector3 ByRef, Vector3 ByRef, Vector3 ByRef)
		void HG::Rendering::Runtime::HGCelestialConfig::GetMapWorldSpaceBasisInPlanetSpace(
		        HGCelestialConfig *this,
		        Vector3 *up,
		        Vector3 *forward,
		        Vector3 *right,
		        MethodInfo *method)
		{
		  float v5; // xmm1_4
		  float worldLatitude; // xmm6_4
		  float v11; // xmm7_4
		  MethodInfo *v12; // rdx
		  Vector3 *v13; // rax
		  __int64 v14; // xmm3_8
		  Beyond::DampingMath *v15; // rcx
		  MethodInfo *v16; // r9
		  Vector3 *v17; // rax
		  __int64 v18; // xmm6_8
		  float z; // ebx
		  MethodInfo *v20; // rdx
		  Vector3 *v21; // rax
		  float worldLongitude; // xmm1_4
		  __int64 v23; // xmm3_8
		  MethodInfo *v24; // rax
		  Vector3 *fwd; // rax
		  Quaternion *v26; // rdx
		  Quaternion v27; // xmm1
		  __int64 v28; // xmm3_8
		  Vector3 *v29; // rax
		  Beyond::DampingMath *v30; // rcx
		  MethodInfo *v31; // r9
		  Vector3 *v32; // rax
		  __int64 v33; // xmm3_8
		  MethodInfo *v34; // r9
		  Vector3 *v35; // rax
		  __int64 v36; // xmm3_8
		  __int64 v37; // rax
		  __int64 v38; // xmm3_8
		  MethodInfo *v39; // rdx
		  Vector3 *v40; // rax
		  __int64 v41; // xmm0_8
		  float v42; // edx
		  MethodInfo *v43; // r9
		  Vector3 *v44; // rax
		  __int64 v45; // xmm4_8
		  __int64 v46; // rax
		  __int64 v47; // xmm0_8
		  MethodInfo *v48; // r8
		  Vector3 *v49; // rax
		  float v50; // ecx
		  __int64 v51; // xmm0_8
		  MethodInfo *v52; // r9
		  Vector3 *v53; // rax
		  __int64 v54; // xmm4_8
		  __int64 v55; // rax
		  __int64 v56; // xmm0_8
		  MethodInfo *v57; // r8
		  Vector3 *v58; // rax
		  float v59; // ecx
		  Quaternion *v60; // rax
		  float v61; // ecx
		  Quaternion v62; // xmm0
		  Vector3 *v63; // rax
		  float v64; // ecx
		  Quaternion *v65; // rax
		  float v66; // ecx
		  Quaternion v67; // xmm0
		  Vector3 *v68; // rax
		  float v69; // ecx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v71; // rdx
		  __int64 v72; // rcx
		  Vector3 v73; // [rsp+38h] [rbp-21h] BYREF
		  Vector3 v74; // [rsp+48h] [rbp-11h] BYREF
		  Quaternion v75; // [rsp+58h] [rbp-1h] BYREF
		  Quaternion v76; // [rsp+68h] [rbp+Fh] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1330, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1330, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v72, v71);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_517(Patch, this, up, forward, right, 0LL);
		  }
		  else
		  {
		    worldLatitude = this->moonConfig.worldLatitude;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCelestialConfig);
		    v11 = (float)(1.0 - HG::Rendering::Runtime::HGCelestialConfig::PercentageDeg(worldLatitude, 0LL)) * 1.5707964;
		    v13 = UnityEngine::Vector3::get_up((Vector3 *)&v75, v12);
		    v14 = *(_QWORD *)&v13->x;
		    *(float *)&v13 = v13->z;
		    *(_QWORD *)&v73.x = v14;
		    LODWORD(v73.z) = (_DWORD)v13;
		    Beyond::DampingMath::cosf(v15, v5);
		    v17 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v75, &v73, v11, v16);
		    v18 = *(_QWORD *)&v17->x;
		    z = v17->z;
		    v21 = UnityEngine::Vector3::get_up((Vector3 *)&v75, v20);
		    worldLongitude = this->moonConfig.worldLongitude;
		    v23 = *(_QWORD *)&v21->x;
		    *(float *)&v21 = v21->z;
		    *(_QWORD *)&v73.x = v23;
		    LODWORD(v73.z) = (_DWORD)v21;
		    v24 = (MethodInfo *)UnityEngine::Quaternion::AngleAxis(&v76, worldLongitude, &v73, 0LL);
		    fwd = UnityEngine::Vector3::get_fwd((Vector3 *)&v75, v24);
		    v27 = *v26;
		    v28 = *(_QWORD *)&fwd->x;
		    v74.z = fwd->z;
		    *(_QWORD *)&v74.x = v28;
		    v76 = v27;
		    v29 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v75, &v76, &v74, 0LL);
		    *(_QWORD *)&v27.x = *(_QWORD *)&v29->x;
		    *(float *)&v29 = v29->z;
		    *(_QWORD *)&v74.x = *(_QWORD *)&v27.x;
		    LODWORD(v74.z) = (_DWORD)v29;
		    Beyond::DampingMath::sinf(v30, v27.x);
		    v32 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v75, &v74, v11, v31);
		    *(_QWORD *)&v73.x = v18;
		    v73.z = z;
		    v33 = *(_QWORD *)&v32->x;
		    *(float *)&v32 = v32->z;
		    *(_QWORD *)&v74.x = v33;
		    LODWORD(v74.z) = (_DWORD)v32;
		    v35 = UnityEngine::Vector3::op_Addition((Vector3 *)&v75, &v73, &v74, v34);
		    v36 = *(_QWORD *)&v35->x;
		    *(float *)&v35 = v35->z;
		    *(_QWORD *)&v74.x = v36;
		    LODWORD(v74.z) = (_DWORD)v35;
		    v37 = sub_182FAE420(&v75, &v74);
		    v38 = *(_QWORD *)v37;
		    v39 = (MethodInfo *)*(unsigned int *)(v37 + 8);
		    *(_QWORD *)&up->x = *(_QWORD *)v37;
		    LODWORD(up->z) = (_DWORD)v39;
		    v40 = UnityEngine::Vector3::get_up((Vector3 *)&v75, v39);
		    v41 = *(_QWORD *)&v40->x;
		    *(float *)&v40 = v40->z;
		    v74.z = v42;
		    *(_QWORD *)&v73.x = v41;
		    LODWORD(v73.z) = (_DWORD)v40;
		    *(_QWORD *)&v74.x = v38;
		    v44 = UnityEngine::Vector3::Cross((Vector3 *)&v75, &v73, &v74, v43);
		    v45 = *(_QWORD *)&v44->x;
		    *(float *)&v44 = v44->z;
		    *(_QWORD *)&v73.x = v45;
		    LODWORD(v73.z) = (_DWORD)v44;
		    v46 = sub_182FAE2B0(&v75, &v73);
		    v47 = *(_QWORD *)v46;
		    LODWORD(v46) = *(_DWORD *)(v46 + 8);
		    *(_QWORD *)&v74.x = v47;
		    LODWORD(v74.z) = v46;
		    v49 = UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v75, &v74, v48);
		    v50 = v49->z;
		    *(_QWORD *)&v27.x = *(_QWORD *)&v49->x;
		    *(_QWORD *)&right->x = *(_QWORD *)&v49->x;
		    right->z = v50;
		    v51 = *(_QWORD *)&up->x;
		    *(float *)&v49 = up->z;
		    v74.z = v50;
		    *(_QWORD *)&v75.x = v51;
		    *(_QWORD *)&v74.x = *(_QWORD *)&v27.x;
		    LODWORD(v75.z) = (_DWORD)v49;
		    v53 = UnityEngine::Vector3::Cross((Vector3 *)&v76, (Vector3 *)&v75, &v74, v52);
		    v54 = *(_QWORD *)&v53->x;
		    *(float *)&v53 = v53->z;
		    *(_QWORD *)&v73.x = v54;
		    LODWORD(v73.z) = (_DWORD)v53;
		    v55 = sub_182FAE2B0(&v76, &v73);
		    v56 = *(_QWORD *)v55;
		    LODWORD(v55) = *(_DWORD *)(v55 + 8);
		    *(_QWORD *)&v75.x = v56;
		    LODWORD(v75.z) = v55;
		    v58 = UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v76, (Vector3 *)&v75, v57);
		    v59 = v58->z;
		    *(_QWORD *)&forward->x = *(_QWORD *)&v58->x;
		    forward->z = v59;
		    *(float *)&v58 = up->z;
		    v27.x = this->moonConfig.rotationAroundUp;
		    *(_QWORD *)&v75.x = *(_QWORD *)&up->x;
		    LODWORD(v75.z) = (_DWORD)v58;
		    v60 = UnityEngine::Quaternion::AngleAxis(&v76, v27.x, (Vector3 *)&v75, 0LL);
		    v61 = right->z;
		    *(_QWORD *)&v74.x = *(_QWORD *)&right->x;
		    v62 = *v60;
		    v74.z = v61;
		    v75 = v62;
		    v63 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v76, &v75, &v74, 0LL);
		    v64 = v63->z;
		    *(_QWORD *)&right->x = *(_QWORD *)&v63->x;
		    right->z = v64;
		    *(_QWORD *)&v62.x = *(_QWORD *)&up->x;
		    v27.x = this->moonConfig.rotationAroundUp;
		    v75.z = up->z;
		    *(_QWORD *)&v75.x = *(_QWORD *)&v62.x;
		    v65 = UnityEngine::Quaternion::AngleAxis(&v76, v27.x, (Vector3 *)&v75, 0LL);
		    v66 = forward->z;
		    *(_QWORD *)&v74.x = *(_QWORD *)&forward->x;
		    v67 = *v65;
		    v74.z = v66;
		    v75 = v67;
		    v68 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v76, &v75, &v74, 0LL);
		    v69 = v68->z;
		    *(_QWORD *)&forward->x = *(_QWORD *)&v68->x;
		    forward->z = v69;
		  }
		}
		
		[IDTag(0)]
		public static void CreateBasisFromRotation(Vector3 angRotation, [IsReadOnly] in Vector3 up, [IsReadOnly] in Vector3 right, [IsReadOnly] in Vector3 forward, out Vector3 outUp, out Vector3 outRight, out Vector3 outForward) {
			outUp = default;
			outRight = default;
			outForward = default;
		} // 0x0000000189C6DB44-0x0000000189C6DDBC
		// Void CreateBasisFromRotation(Vector3, Vector3 ByRef, Vector3 ByRef, Vector3 ByRef, Vector3 ByRef, Vector3 ByRef, Vector3 ByRef)
		void HG::Rendering::Runtime::HGCelestialConfig::CreateBasisFromRotation(
		        Vector3 *angRotation,
		        Vector3 *up,
		        Vector3 *right,
		        Vector3 *forward,
		        Vector3 *outUp,
		        Vector3 *outRight,
		        Vector3 *outForward,
		        MethodInfo *method)
		{
		  Quaternion *v12; // rax
		  float z; // ecx
		  Quaternion v14; // xmm0
		  Vector3 *v15; // rax
		  float v16; // ecx
		  Quaternion *v17; // rax
		  float v18; // ecx
		  Quaternion v19; // xmm0
		  Vector3 *v20; // rax
		  float v21; // ecx
		  Quaternion *v22; // rax
		  float v23; // ecx
		  Quaternion v24; // xmm0
		  Vector3 *v25; // rax
		  float y; // xmm1_4
		  float v27; // ecx
		  Quaternion *v28; // rax
		  float v29; // ecx
		  Quaternion v30; // xmm0
		  Vector3 *v31; // rax
		  float v32; // xmm1_4
		  float v33; // ecx
		  Quaternion *v34; // rax
		  float v35; // ecx
		  Quaternion v36; // xmm0
		  Vector3 *v37; // rax
		  float v38; // ecx
		  __int64 v39; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  __int64 v41; // xmm0_8
		  Vector3 v42; // [rsp+50h] [rbp-30h] BYREF
		  Vector3 v43; // [rsp+60h] [rbp-20h] BYREF
		  Quaternion v44; // [rsp+70h] [rbp-10h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1331, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1331, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v39);
		    v41 = *(_QWORD *)&angRotation->x;
		    v43.z = angRotation->z;
		    *(_QWORD *)&v43.x = v41;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_518(Patch, &v43, up, right, forward, outUp, outRight, outForward, 0LL);
		  }
		  else
		  {
		    v12 = (Quaternion *)sub_182FA5990(&v44);
		    z = up->z;
		    *(_QWORD *)&v42.x = *(_QWORD *)&up->x;
		    v14 = *v12;
		    v42.z = z;
		    v44 = v14;
		    v15 = UnityEngine::Quaternion::op_Multiply(&v43, &v44, &v42, 0LL);
		    v16 = v15->z;
		    *(_QWORD *)&outUp->x = *(_QWORD *)&v15->x;
		    outUp->z = v16;
		    v17 = (Quaternion *)sub_182FA5990(&v44);
		    v18 = right->z;
		    *(_QWORD *)&v42.x = *(_QWORD *)&right->x;
		    v19 = *v17;
		    v42.z = v18;
		    v44 = v19;
		    v20 = UnityEngine::Quaternion::op_Multiply(&v43, &v44, &v42, 0LL);
		    v21 = v20->z;
		    *(_QWORD *)&outRight->x = *(_QWORD *)&v20->x;
		    outRight->z = v21;
		    v22 = (Quaternion *)sub_182FA5990(&v44);
		    v23 = forward->z;
		    *(_QWORD *)&v42.x = *(_QWORD *)&forward->x;
		    v24 = *v22;
		    v42.z = v23;
		    v44 = v24;
		    v25 = UnityEngine::Quaternion::op_Multiply(&v43, &v44, &v42, 0LL);
		    y = angRotation->y;
		    v27 = v25->z;
		    *(_QWORD *)&outForward->x = *(_QWORD *)&v25->x;
		    outForward->z = v27;
		    *(float *)&v25 = outUp->z;
		    *(_QWORD *)&v42.x = *(_QWORD *)&outUp->x;
		    LODWORD(v42.z) = (_DWORD)v25;
		    v28 = UnityEngine::Quaternion::AngleAxis(&v44, y, &v42, 0LL);
		    v29 = outRight->z;
		    *(_QWORD *)&v43.x = *(_QWORD *)&outRight->x;
		    v30 = *v28;
		    v43.z = v29;
		    v44 = v30;
		    v31 = UnityEngine::Quaternion::op_Multiply(&v42, &v44, &v43, 0LL);
		    v32 = angRotation->y;
		    v33 = v31->z;
		    *(_QWORD *)&outRight->x = *(_QWORD *)&v31->x;
		    outRight->z = v33;
		    *(float *)&v31 = outUp->z;
		    *(_QWORD *)&v43.x = *(_QWORD *)&outUp->x;
		    LODWORD(v43.z) = (_DWORD)v31;
		    v34 = UnityEngine::Quaternion::AngleAxis(&v44, v32, &v43, 0LL);
		    v35 = outForward->z;
		    *(_QWORD *)&v42.x = *(_QWORD *)&outForward->x;
		    v36 = *v34;
		    v42.z = v35;
		    v44 = v36;
		    v37 = UnityEngine::Quaternion::op_Multiply(&v43, &v44, &v42, 0LL);
		    v38 = v37->z;
		    *(_QWORD *)&outForward->x = *(_QWORD *)&v37->x;
		    outForward->z = v38;
		  }
		}
		
		[IDTag(1)]
		public static void CreateBasisFromRotation(Vector3 angRotation, out Vector3 outUp, out Vector3 outRight, out Vector3 outForward) {
			outUp = default;
			outRight = default;
			outForward = default;
		} // 0x0000000189C6DDBC-0x0000000189C6DEEC
		// Void CreateBasisFromRotation(Vector3, Vector3 ByRef, Vector3 ByRef, Vector3 ByRef)
		void HG::Rendering::Runtime::HGCelestialConfig::CreateBasisFromRotation(
		        Vector3 *angRotation,
		        Vector3 *outUp,
		        Vector3 *outRight,
		        Vector3 *outForward,
		        MethodInfo *method)
		{
		  MethodInfo *v9; // rdx
		  Vector3 *up; // rax
		  __int64 v11; // xmm3_8
		  MethodInfo *v12; // rdx
		  Vector3 *right; // rax
		  __int64 v14; // xmm1_8
		  MethodInfo *v15; // rdx
		  Vector3 *fwd; // rax
		  __int64 v17; // xmm3_8
		  float v18; // eax
		  __int64 v19; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 v22; // [rsp+40h] [rbp-40h] BYREF
		  Vector3 v23; // [rsp+50h] [rbp-30h] BYREF
		  Vector3 v24; // [rsp+60h] [rbp-20h] BYREF
		  Vector3 v25; // [rsp+70h] [rbp-10h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1332, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1332, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v19);
		    z = angRotation->z;
		    *(_QWORD *)&v25.x = *(_QWORD *)&angRotation->x;
		    v25.z = z;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_519(Patch, &v25, outUp, outRight, outForward, 0LL);
		  }
		  else
		  {
		    up = UnityEngine::Vector3::get_up(&v25, v9);
		    v11 = *(_QWORD *)&up->x;
		    *(float *)&up = up->z;
		    *(_QWORD *)&v24.x = v11;
		    LODWORD(v24.z) = (_DWORD)up;
		    right = UnityEngine::Vector3::get_right(&v25, v12);
		    v14 = *(_QWORD *)&right->x;
		    *(float *)&right = right->z;
		    *(_QWORD *)&v23.x = v14;
		    LODWORD(v23.z) = (_DWORD)right;
		    fwd = UnityEngine::Vector3::get_fwd(&v25, v15);
		    v17 = *(_QWORD *)&fwd->x;
		    *(float *)&fwd = fwd->z;
		    *(_QWORD *)&v22.x = v17;
		    LODWORD(v22.z) = (_DWORD)fwd;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCelestialConfig);
		    v18 = angRotation->z;
		    *(_QWORD *)&v25.x = *(_QWORD *)&angRotation->x;
		    v25.z = v18;
		    HG::Rendering::Runtime::HGCelestialConfig::CreateBasisFromRotation(
		      &v25,
		      &v24,
		      &v23,
		      &v22,
		      outUp,
		      outRight,
		      outForward,
		      0LL);
		  }
		}
		
	}
}
