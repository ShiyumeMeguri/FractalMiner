using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.Snow
{
	internal class SnowCommonRenderingParam // TypeDefIndex: 38836
	{
		// Fields
		public bool enable; // 0x10
		public float intensity; // 0x14
		public Vector2 speed; // 0x18
		public UnityEngine.Color color; // 0x20
		public Vector3 snowDirection; // 0x30
		public Vector3 lastCamPos; // 0x3C
		public float snowJitterLevel; // 0x48
		public float snowSpeedNoiseLevel; // 0x4C
		public float snowSpeedNoiseFreq; // 0x50
		public float snowTrailLength; // 0x54
		public Vector2 snowSizeRange; // 0x58
		public float snowLightingPercent; // 0x60
		public float snowCollisionFadeTimeScale; // 0x64
		public bool enableSnowLighting; // 0x68
		public int snowLayerCount; // 0x6C
		public bool enableSnowCollision; // 0x70
		public int cameraMask; // 0x74
		public SnowCommonPreSettingParam snowCommonPreSettingParam; // 0x78
	
		// Constructors
		public SnowCommonRenderingParam() {} // 0x0000000182EDECA0-0x0000000182EDED50
		// SnowCommonRenderingParam()
		void HG::Rendering::Runtime::Snow::SnowCommonRenderingParam::SnowCommonRenderingParam(
		        SnowCommonRenderingParam *this,
		        MethodInfo *method)
		{
		  float v3; // edx
		  SnowCommonPreSettingParam *v4; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  SnowCommonPreSettingParam *v7; // rdi
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v8; // rdx
		  VolumetricRenderer_VolumetricBounds *v9; // r8
		  Int32__Array **v10; // r9
		  Vector4 v11; // [rsp+20h] [rbp-18h] BYREF
		  MethodInfo *v12; // [rsp+60h] [rbp+28h]
		  MethodInfo *v13; // [rsp+68h] [rbp+30h]
		  int32_t v14; // [rsp+70h] [rbp+38h]
		  int32_t v15; // [rsp+78h] [rbp+40h]
		  float v16; // [rsp+80h] [rbp+48h]
		  int32_t v17; // [rsp+88h] [rbp+50h]
		  bool v18; // [rsp+90h] [rbp+58h]
		  bool v19; // [rsp+98h] [rbp+60h]
		  MethodInfo *v20; // [rsp+A0h] [rbp+68h]
		
		  this->fields.speed = 0LL;
		  this->fields.color = (Color)*UnityEngine::Vector4::get_one(&v11, 0LL);
		  *(_QWORD *)&this->fields.snowDirection.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
		  this->fields.snowDirection.z = 0.0;
		  this->fields.snowSizeRange.x = v3;
		  *(_QWORD *)&this->fields.lastCamPos.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  this->fields.lastCamPos.z = 0.0;
		  this->fields.snowSizeRange.y = 1.0;
		  this->fields.snowCollisionFadeTimeScale = 1.0;
		  this->fields.snowLayerCount = 1;
		  this->fields.cameraMask = -1;
		  v4 = (SnowCommonPreSettingParam *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::Snow::SnowCommonPreSettingParam);
		  v7 = v4;
		  if ( !v4 )
		    sub_1800D8260(v6, v5);
		  HG::Rendering::Runtime::Snow::SnowCommonPreSettingParam::SnowCommonPreSettingParam(v4, 0LL);
		  this->fields.snowCommonPreSettingParam = v7;
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)&this->fields.snowCommonPreSettingParam,
		    v8,
		    v9,
		    v10,
		    v12,
		    v13,
		    v14,
		    v15,
		    v16,
		    v17,
		    v18,
		    v19,
		    v20);
		}
		
	}
}
