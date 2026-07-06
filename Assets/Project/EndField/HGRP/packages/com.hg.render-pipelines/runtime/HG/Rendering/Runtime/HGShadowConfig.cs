using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct HGShadowConfig : IEnvConfig
	{
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x000025D2 File Offset: 0x000007D2
		private Color _overrideCsmFarDistanceColor
		{
			get
			{
				// // Color get__overrideCsmFarDistanceColor()
				// Color *HG::Rendering::Runtime::HGShadowConfig::get__overrideCsmFarDistanceColor(
				//         Color *__return_ptr retstr,
				//         HGShadowConfig *this,
				//         MethodInfo *method)
				// {
				//   Color enabledColor; // xmm0
				//   Color *result; // rax
				// 
				//   if ( !byte_18D919D55 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
				//     byte_18D919D55 = 1;
				//   }
				//   if ( this.overrideCsmFarDistanceEnabled )
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
				//     enabledColor = TypeInfo::HG::Rendering::Runtime::HGShadowConfig.static_fields._enabledColor;
				//   }
				//   else
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
				//     enabledColor = TypeInfo::HG::Rendering::Runtime::HGShadowConfig.static_fields._disabledColor;
				//   }
				//   result = retstr;
				//   *retstr = enabledColor;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000586 RID: 1414 RVA: 0x000025D2 File Offset: 0x000007D2
		private Color _manualOverrideCsmRendering
		{
			get
			{
				// // Color get__manualOverrideCsmRendering()
				// Color *HG::Rendering::Runtime::HGShadowConfig::get__manualOverrideCsmRendering(
				//         Color *__return_ptr retstr,
				//         HGShadowConfig *this,
				//         MethodInfo *method)
				// {
				//   Color enabledColor; // xmm0
				//   Color *result; // rax
				// 
				//   if ( !byte_18D919D56 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
				//     byte_18D919D56 = 1;
				//   }
				//   if ( this.manualOverrideCsmRendering )
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
				//     enabledColor = TypeInfo::HG::Rendering::Runtime::HGShadowConfig.static_fields._enabledColor;
				//   }
				//   else
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
				//     enabledColor = TypeInfo::HG::Rendering::Runtime::HGShadowConfig.static_fields._disabledColor;
				//   }
				//   result = retstr;
				//   *retstr = enabledColor;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000587 RID: 1415 RVA: 0x000025D2 File Offset: 0x000007D2
		private Color _disableCsmColor
		{
			get
			{
				// // Color get__disableCsmColor()
				// Color *HG::Rendering::Runtime::HGShadowConfig::get__disableCsmColor(
				//         Color *__return_ptr retstr,
				//         HGShadowConfig *this,
				//         MethodInfo *method)
				// {
				//   Color enabledColor; // xmm0
				//   Color *result; // rax
				// 
				//   if ( !byte_18D919D57 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
				//     byte_18D919D57 = 1;
				//   }
				//   if ( this.disableCsm )
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
				//     enabledColor = TypeInfo::HG::Rendering::Runtime::HGShadowConfig.static_fields._enabledColor;
				//   }
				//   else
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
				//     enabledColor = TypeInfo::HG::Rendering::Runtime::HGShadowConfig.static_fields._disabledColor;
				//   }
				//   result = retstr;
				//   *retstr = enabledColor;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000588 RID: 1416 RVA: 0x000025D2 File Offset: 0x000007D2
		private Color _disableAsmColor
		{
			get
			{
				// // Color get__disableAsmColor()
				// Color *HG::Rendering::Runtime::HGShadowConfig::get__disableAsmColor(
				//         Color *__return_ptr retstr,
				//         HGShadowConfig *this,
				//         MethodInfo *method)
				// {
				//   Color enabledColor; // xmm0
				//   Color *result; // rax
				// 
				//   if ( !byte_18D919D58 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
				//     byte_18D919D58 = 1;
				//   }
				//   if ( this.disableAsm )
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
				//     enabledColor = TypeInfo::HG::Rendering::Runtime::HGShadowConfig.static_fields._enabledColor;
				//   }
				//   else
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
				//     enabledColor = TypeInfo::HG::Rendering::Runtime::HGShadowConfig.static_fields._disabledColor;
				//   }
				//   result = retstr;
				//   *retstr = enabledColor;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000589 RID: 1417 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool active
		{
			get
			{
				// // Boolean get_Private()
				// bool System::Net::Http::Headers::CacheControlHeaderValue::get_Private(
				//         CacheControlHeaderValue *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._Private_k__BackingField;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_Private(Boolean)
				// void System::Net::Http::Headers::CacheControlHeaderValue::set_Private(
				//         CacheControlHeaderValue *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields._Private_k__BackingField = value;
				// }
				// 
			}
		}

		public HGShadowConfig(bool active)
		{
		}

		private void SetDisableCsmBlendFactor(bool newVal)
		{
			// // Void SetDisableCsmBlendFactor(Boolean)
			// void HG::Rendering::Runtime::HGShadowConfig::SetDisableCsmBlendFactor(
			//         HGShadowConfig *this,
			//         bool newVal,
			//         MethodInfo *method)
			// {
			//   float v5; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1189, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1189, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_447(Patch, this, newVal, 0LL);
			//   }
			//   else
			//   {
			//     if ( newVal )
			//       v5 = 1.0;
			//     else
			//       v5 = 0.0;
			//     this.disableCsmBlendFactor = v5;
			//   }
			// }
			// 
		}

		public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
		{
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static Color _enabledColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static Color _disabledColor;

		private float csmDepthBias;

		private float csmNormalBias;

		[Range(0f, 10f)]
		[Header("CSM深度采样偏移")]
		public float csmDepthBiasV2;

		[Header("CSM法线采样偏移")]
		[Range(0f, 5f)]
		public float csmNormalBiasV2;

		[Header("CSM阴影强度")]
		[Range(0f, 1f)]
		public float csmIntensity;

		[Header("CSM Ramp贴图")]
		public Texture2D csmRampTexture;

		[HideInInspector]
		public float csmShadowSoftness;

		[Header("ASM投影场景最低高度 (Y)")]
		public float asmCasterMinY;

		[Header("ASM投影场景最高高度 (Y)")]
		public float asmCasterMaxY;

		[Header("阴影强度")]
		[Range(0f, 1f)]
		public float contactShadowIntensity;

		[Header("像素厚度（百分比）")]
		[Range(0.4f, 1f)]
		public float contactShadowSurfaceThickness;

		[Header("深度边界阈值（百分比）")]
		[Range(2f, 5f)]
		public float contactShadowBilinearThreshold;

		[Header("阴影锐度")]
		[Range(1f, 4f)]
		public int contactShadowContract;

		[Header("忽略边界像素")]
		public bool contactShadowIgnoreEdgePixels;

		[Header("是否强制修改CSM近景阴影距离")]
		public bool overrideCsmFarDistanceEnabled;

		[Header("CSM近景阴影距离 Overrided")]
		[UnclampedRange(1f, 500f)]
		public float overrideCsmFarDistance;

		[Header("是否启用强制设置CSM渲染范围功能")]
		public bool manualOverrideCsmRendering;

		[Header("渲染球中心")]
		public Vector3 overrideCsmSpherePosition;

		[Header("渲染球半径")]
		[Range(0.1f, 50f)]
		public float overrideCsmSphereRadius;

		[Header("是否区域内关闭直接光CSM渲染")]
		public bool disableCsm;

		[HideInInspector]
		public float disableCsmBlendFactor;

		[Header("区域内CSM模拟Attenuation值")]
		[Range(0f, 1f)]
		public float csmSimulatedAttenuation;

		[Header("是否关闭ASM远景阴影")]
		public bool disableAsm;

		[HideInInspector]
		[SerializeField]
		private bool m_active;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		public static HGShadowConfig defaultConfig;
	}
}
