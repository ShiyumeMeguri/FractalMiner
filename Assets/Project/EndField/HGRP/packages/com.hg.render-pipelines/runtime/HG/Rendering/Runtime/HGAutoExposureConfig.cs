using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 60)]
	public struct HGAutoExposureConfig : IEnvConfig
	{
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool active
		{
			get
			{
				// // Boolean get_autoRecycle()
				// bool UnityEngine::UIElements::Experimental::ValueAnimation<UnityEngine::UIElements::Experimental::StyleValues>::get_autoRecycle(
				//         ValueAnimation_1_StyleValues_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._autoRecycle_k__BackingField;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_autoRecycle(Boolean)
				// void UnityEngine::UIElements::Experimental::ValueAnimation<UnityEngine::UIElements::Experimental::StyleValues>::set_autoRecycle(
				//         ValueAnimation_1_StyleValues_ *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields._autoRecycle_k__BackingField = value;
				// }
				// 
			}
		}

		public HGAutoExposureConfig(bool active)
		{
			// // HGAutoExposureConfig(Boolean)
			// void HG::Rendering::Runtime::HGAutoExposureConfig::HGAutoExposureConfig(
			//         HGAutoExposureConfig *this,
			//         bool active,
			//         MethodInfo *method)
			// {
			//   this.m_active = 0;
			//   *(_QWORD *)&this.autoExposureMode = 0LL;
			//   this.autoExposureLerpUpSpeed = 0.60000002;
			//   this.autoExposureLerpDownSpeed = 0.60000002;
			//   this.autoExposureEv100Range.x = -8.0;
			//   this.autoExposureEv100Range.y = 4.0;
			//   this.autoExposureEv100HistogramRange.x = -8.0;
			//   *(_QWORD *)&this.autoExposureEv100HistogramRange.y = 1082130432LL;
			//   this.autoExposurePixelLuminanceRange.x = 0.050000001;
			//   this.autoExposurePixelLuminanceRange.y = 0.94999999;
			//   this.autoExposureEvClampRange.x = -4.0;
			//   *(_QWORD *)&this.autoExposureEvClampRange.y = 1082130432LL;
			// }
			// 
		}

		public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
		{
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::HGAutoExposureConfig::IsActive(HGAutoExposureConfig *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2__Array *v7; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v3.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 896 )
			//     return 1;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v3.static_fields;
			//   v7 = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( v7.max_length.size <= 0x380u )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( !v7[25].klass )
			//     return 1;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(896, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_342(Patch, this, 0LL);
			// }
			// 
			return default(bool);
		}

		[Header("模式")]
		public AutoExposureMode autoExposureMode;

		[Range(-8f, 8f)]
		[Header("手工调整最终EV（自动曝光模式）")]
		public float autoExposureManualEvCompensationAuto;

		[Range(0.01f, 20f)]
		[Header("提亮速度")]
		public float autoExposureLerpUpSpeed;

		[Range(0.01f, 20f)]
		[Header("压暗速度")]
		public float autoExposureLerpDownSpeed;

		[HideInInspector]
		[Header("测光表的EV值范围（超出范围则clamp）")]
		public Vector2 autoExposureEv100Range;

		[Header("限制输入像素的EV值范围")]
		public Vector2 autoExposureEv100HistogramRange;

		[Header("测光模式")]
		public AutoExposureMeteringMode autoExposureMeteringMode;

		[Header("亮度输入范围")]
		[HideInInspector]
		public Vector2 autoExposurePixelLuminanceRange;

		[Header("自动曝光补偿值调整范围")]
		public Vector2 autoExposureEvClampRange;

		[Range(-8f, 8f)]
		[Header("手工调整最终EV（手动曝光模式）")]
		public float autoExposureManualEvCompensationManual;

		[HideInInspector]
		[SerializeField]
		private bool m_active;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static HGAutoExposureConfig defaultConfig;
	}
}
