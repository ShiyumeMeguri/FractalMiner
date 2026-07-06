using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct HGCloudConfig : IEnvConfig
	{
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool active
		{
			get
			{
				// // Boolean get_breakBatches()
				// bool UnityEngine::UIElements::UIR::UIRenderDevice::get_breakBatches(UIRenderDevice *this, MethodInfo *method)
				// {
				//   return this.fields._breakBatches_k__BackingField;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_breakBatches(Boolean)
				// void UnityEngine::UIElements::UIR::UIRenderDevice::set_breakBatches(
				//         UIRenderDevice *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields._breakBatches_k__BackingField = value;
				// }
				// 
			}
		}

		public HGCloudConfig(bool active)
		{
			// // HGCloudConfig(Boolean)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::HGCloudConfig::HGCloudConfig(HGCloudConfig *this, bool active, MethodInfo *method)
			// {
			//   __int64 v3; // r9
			//   __int64 v4; // r10
			//   OneofDescriptorProto *v5; // rdx
			//   FileDescriptor *v6; // r8
			//   MethodInfo *v7; // rdx
			//   Vector4 v8; // xmm1
			//   __int64 v9; // r9
			//   __int64 v10; // r10
			//   OneofDescriptorProto *v11; // rdx
			//   FileDescriptor *v12; // r8
			//   __int64 v13; // r9
			//   char v14; // r10
			//   Vector4 v15; // [rsp+20h] [rbp-18h] BYREF
			//   MethodInfo *v16; // [rsp+30h] [rbp-8h]
			// 
			//   this.m_active = 0;
			//   this.enable = 0;
			//   this.cloudTexture = 0LL;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.cloudTexture,
			//     (OneofDescriptorProto *)active,
			//     (FileDescriptor *)method,
			//     (MessageDescriptor *)this,
			//     *(String__Array **)&v15.x,
			//     *(String **)&v15.z,
			//     v16);
			//   *(_QWORD *)(v3 + 72) = v4;
			//   sub_1800054D0(
			//     (OneofDescriptor *)(v3 + 72),
			//     v5,
			//     v6,
			//     (MessageDescriptor *)v3,
			//     *(String__Array **)&v15.x,
			//     *(String **)&v15.z,
			//     v16);
			//   v8 = *UnityEngine::Vector4::get_one(&v15, v7);
			//   *(_DWORD *)(v9 + 32) = 1065353216;
			//   *(_DWORD *)(v9 + 40) = v10;
			//   *(Vector4 *)(v9 + 16) = v8;
			//   *(_DWORD *)(v9 + 44) = 1065353216;
			//   *(_WORD *)(v9 + 48) = 1;
			//   *(_BYTE *)(v9 + 36) = 1;
			//   *(_DWORD *)(v9 + 52) = v10;
			//   *(_DWORD *)(v9 + 56) = 1065353216;
			//   *(_QWORD *)(v9 + 60) = 1065353216LL;
			//   *(_DWORD *)(v9 + 68) = v10;
			//   *(_QWORD *)(v9 + 80) = v10;
			//   *(_DWORD *)(v9 + 88) = v10;
			//   *(_BYTE *)(v9 + 92) = v10;
			//   *(_QWORD *)(v9 + 96) = v10;
			//   sub_1800054D0(
			//     (OneofDescriptor *)(v9 + 96),
			//     v11,
			//     v12,
			//     (MessageDescriptor *)v9,
			//     *(String__Array **)&v15.x,
			//     *(String **)&v15.z,
			//     v16);
			//   *(_BYTE *)(v13 + 104) = v14;
			//   *(_OWORD *)(v13 + 112) = 0LL;
			//   *(_OWORD *)(v13 + 128) = 0LL;
			//   *(_OWORD *)(v13 + 144) = 0LL;
			//   *(_QWORD *)(v13 + 160) = 0LL;
			//   *(_DWORD *)(v13 + 168) = 1065353216;
			// }
			// 
		}

		public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
		{
		}

		[Header("启用云")]
		public bool enable;

		[Header("云的贴图")]
		public Texture cloudTexture;

		[Header("颜色")]
		public Color cloudTint;

		[UnclampedRange(-1f, 2f)]
		[Header("对比度")]
		public float cloudContrast;

		[Header("光照是否影响云的亮度")]
		public bool lightAffectCloud;

		[Header("云的亮度补偿")]
		[UnclampedRange(-5f, 5f)]
		public float cloudBrightness;

		[Header("云的亮度")]
		[UnclampedRangeExponential(-5f, 5f, 2f)]
		public float cloudAbsoluteBrightness;

		[Header("亮度是否影响Alpha")]
		public bool brightnessAffectCloudAlpha;

		[Header("是否在星球之后单独绘制")]
		public bool drawCloudAfterPlanet;

		[Header("云的贴图模式")]
		public HGCloudConfig.CloudTextureMode cloudTextureMode;

		[Range(0f, 1f)]
		[Header("R通道透明度")]
		public float cloudOpacityR;

		[Header("G通道透明度")]
		[Range(0f, 1f)]
		public float cloudOpacityG;

		[Header("云的运动方式")]
		public HGCloudConfig.CloudFlowType cloudFlowType;

		[Header("旋转角度")]
		[Range(0f, 360f)]
		public int rotation;

		[Header("云的FlowMap")]
		public Texture cloudFlowMap;

		[Range(-1f, 1f)]
		[Header("移动速度")]
		public float flowSpeed;

		[Range(-1f, 1f)]
		[Header("X轴运动方向")]
		public float flowDirectionX;

		[Header("Y轴运动方向")]
		[Range(-1f, 1f)]
		public float flowDirectionY;

		[Header("云隙光遮蔽屏幕光束")]
		public bool enableLightShaftCloudMask;

		[Header("遮蔽贴图")]
		public Texture lightShaftCloudMaskTexture;

		[Header("启用云影")]
		public bool enableCloudShadow;

		public HGCloudShadowConfig cloudShadowConfig;

		[HideInInspector]
		public float cloudFadeAlpha;

		[HideInInspector]
		[SerializeField]
		private bool m_active;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static HGCloudConfig defaultConfig;

		public enum CloudTextureMode
		{
			SingleChannelRG,
			ColorRGB
		}

		public enum CloudFlowType
		{
			None,
			Procedural,
			FlowMap
		}
	}
}
