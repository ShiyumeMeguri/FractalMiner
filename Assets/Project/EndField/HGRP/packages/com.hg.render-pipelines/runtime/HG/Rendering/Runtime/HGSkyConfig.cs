using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct HGSkyConfig : IEnvConfig
	{
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool active
		{
			get
			{
				// // Boolean get_isHoverOn()
				// bool Beyond::Input::HGVirtualMouse::get_isHoverOn(HGVirtualMouse *this, MethodInfo *method)
				// {
				//   return this.fields._isHoverOn_k__BackingField;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_isHoverOn(Boolean)
				// void Beyond::Input::HGVirtualMouse::set_isHoverOn(HGVirtualMouse *this, bool value, MethodInfo *method)
				// {
				//   this.fields._isHoverOn_k__BackingField = value;
				// }
				// 
			}
		}

		public HGSkyConfig(bool active)
		{
			// // HGSkyConfig(Boolean)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::HGSkyConfig::HGSkyConfig(HGSkyConfig *this, bool active, MethodInfo *method)
			// {
			//   HGCamera *v3; // r9
			//   String__StaticFields *static_fields; // r8
			//   MethodInfo *v7; // rdx
			//   Vector4 v8; // xmm1
			//   Cubemap *v9; // r9
			//   HGRenderPathBase_HGRenderPathResources *v10; // rdx
			//   PassConstructorID__Enum__Array *v11; // r8
			//   Cubemap *v12; // r9
			//   HGRenderPathBase_HGRenderPathResources *v13; // rdx
			//   PassConstructorID__Enum__Array *v14; // r8
			//   MethodInfo *v15; // r9
			//   Vector3 *v16; // rax
			//   float z; // ecx
			//   MethodInfo *v18; // [rsp+20h] [rbp-28h] BYREF
			//   MethodInfo *v19; // [rsp+28h] [rbp-20h]
			//   Vector4 v20; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDC39 )
			//   {
			//     sub_18003C530(&TypeInfo::System::String);
			//     byte_18D8EDC39 = 1;
			//   }
			//   static_fields = TypeInfo::System::String.static_fields;
			//   this.parentEnvPhaseGuid = static_fields.Empty;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)this,
			//     (HGRenderPathBase_HGRenderPathResources *)active,
			//     (PassConstructorID__Enum__Array *)static_fields,
			//     v3,
			//     v18,
			//     v19);
			//   this.m_active = active;
			//   this.skyDistance = 10000.0;
			//   *(_QWORD *)&this.customIVDefaultSH.shb8 = 0LL;
			//   this.skyBakedIndirectIntensity = 1.0;
			//   this.skyDirectIntensity = 1.0;
			//   this.useCustomIVDefaultSH = 0;
			//   *(_OWORD *)&this.customIVDefaultSH.shr0 = 0LL;
			//   *(_OWORD *)&this.customIVDefaultSH.shr4 = 0LL;
			//   *(_OWORD *)&this.customIVDefaultSH.shr8 = 0LL;
			//   *(_OWORD *)&this.customIVDefaultSH.shg3 = 0LL;
			//   *(_OWORD *)&this.customIVDefaultSH.shg7 = 0LL;
			//   *(_OWORD *)&this.customIVDefaultSH.shb2 = 0LL;
			//   *(_QWORD *)&this.customIVDefaultSH.shb6 = 0LL;
			//   this.sunDiscColor = (Color)_mm_load_si128((const __m128i *)&xmmword_18A357C10);
			//   this.proceduralSkyLuxFactor = 1.0;
			//   this.enableSunDisc = 0;
			//   this.sunDiscRadius = 0.1;
			//   this.sunDiscRampIntensity = 0.2;
			//   this.skyboxBrightness = 120000.0;
			//   v8 = *UnityEngine::Vector4::get_one(&v20, v7);
			//   LODWORD(this.skyboxRotation) = (_DWORD)v9;
			//   this.reflectionType = (int)v9;
			//   this.skyboxTintColor = (Color)v8;
			//   this.reflectionMap = v9;
			//   sub_1800054D0((HGRenderPathScene *)&this.reflectionMap, v10, v11, (HGCamera *)v9, v18, v19);
			//   LODWORD(this.culloff) = (_DWORD)v12;
			//   *(_OWORD *)&this.skyAmbientSH.shr0 = 0LL;
			//   *(_OWORD *)&this.skyAmbientSH.shr4 = 0LL;
			//   *(_OWORD *)&this.skyAmbientSH.shr8 = 0LL;
			//   *(_OWORD *)&this.skyAmbientSH.shg3 = 0LL;
			//   *(_OWORD *)&this.skyAmbientSH.shg7 = 0LL;
			//   *(_OWORD *)&this.skyAmbientSH.shb2 = 0LL;
			//   *(_QWORD *)&this.skyAmbientSH.shb6 = 0LL;
			//   this.skyAmbientSH.shb8 = 0.0;
			//   this.skyboxCubeMap = v12;
			//   sub_1800054D0((HGRenderPathScene *)&this.skyboxCubeMap, v13, v14, (HGCamera *)v12, v18, v19);
			//   LODWORD(v19) = 1065353216;
			//   v18 = (MethodInfo *)_mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
			//   v16 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v20, (Vector3 *)&v18, 32.0, v15);
			//   z = v16.z;
			//   *(_QWORD *)&this.visibleBox.x = *(_QWORD *)&v16.x;
			//   this.visibleBox.z = z;
			// }
			// 
		}

		public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
		{
		}

		[HideInInspector]
		[NonSerialized]
		public string parentEnvPhaseGuid;

		[Header("天空球距离")]
		[UnclampedRange(1f, 30000f)]
		public float skyDistance;

		[Header("天光烘焙间接光系数")]
		[UnclampedRange(0f, 5f)]
		public float skyBakedIndirectIntensity;

		[Header("天光直接部分系数")]
		[UnclampedRange(0f, 10f)]
		public float skyDirectIntensity;

		[Header("使用自定义IV默认SH")]
		public bool useCustomIVDefaultSH;

		public SphericalHarmonicsL2 customIVDefaultSH;

		[Header("材质模式")]
		public HGSkyConfig.SkyMaterialType skyMaterialType;

		[Header("照度系数")]
		[UnclampedRange(0f, 10f)]
		public float proceduralSkyLuxFactor;

		[FormerlySerializedAs("sunDisc")]
		[Header("绘制 Sun Disc")]
		public bool enableSunDisc;

		[UnclampedRange(0f, 1f)]
		[Header("太阳半径")]
		public float sunDiscRadius;

		[UnclampedRange(0f, 1f)]
		[Header("太阳渐变范围")]
		public float sunDiscRampIntensity;

		[ColorUsage(false, true)]
		[Header("太阳颜色")]
		public Color sunDiscColor;

		[UnclampedRangeExponential(0f, 200000f, 3f)]
		[Header("亮度")]
		public float skyboxBrightness;

		[Header("Tint 颜色")]
		public Color skyboxTintColor;

		[Header("旋转角度")]
		[Range(0f, 360f)]
		public float skyboxRotation;

		[Header("相机可见反射探针范围")]
		public Vector3 visibleBox;

		[Header("全局环境贴图来源")]
		public HGSkyConfig.ReflectionType reflectionType;

		[Header("全局环境贴图")]
		public Cubemap reflectionMap;

		[Header("全局环境贴图Deringing系数")]
		[UnclampedRange(0f, 9f)]
		public float culloff;

		[Header("全局环境漫反射 SH")]
		public SphericalHarmonicsL2 skyAmbientSH;

		[HideInInspector]
		public Cubemap skyboxCubeMap;

		[SerializeField]
		[HideInInspector]
		private bool m_active;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static HGSkyConfig defaultConfig;

		public enum SkyMaterialType
		{
			ProceduralSky,
			Skybox
		}

		public enum ReflectionType
		{
			FromSky,
			Custom
		}
	}
}
