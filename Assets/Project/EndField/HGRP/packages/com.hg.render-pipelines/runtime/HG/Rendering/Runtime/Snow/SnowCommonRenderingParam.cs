using System;
using UnityEngine;

namespace HG.Rendering.Runtime.Snow
{
	internal class SnowCommonRenderingParam
	{
		public SnowCommonRenderingParam()
		{
			// // SnowCommonRenderingParam()
			// void HG::Rendering::Runtime::Snow::SnowCommonRenderingParam::SnowCommonRenderingParam(
			//         SnowCommonRenderingParam *this,
			//         MethodInfo *method)
			// {
			//   SnowCommonPreSettingParam *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   SnowCommonPreSettingParam *v6; // rdi
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v7; // rdx
			//   Bounds *v8; // r8
			//   Object__Array *v9; // r9
			//   Vector4 v10; // [rsp+20h] [rbp-18h] BYREF
			//   MethodInfo *v11; // [rsp+60h] [rbp+28h]
			//   MethodInfo *v12; // [rsp+68h] [rbp+30h]
			// 
			//   if ( !byte_18D8EDC21 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Snow::SnowCommonPreSettingParam);
			//     byte_18D8EDC21 = 1;
			//   }
			//   this.fields.color = (Color)*UnityEngine::Vector4::get_one(&v10, method);
			//   *(_QWORD *)&this.fields.snowDirection.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
			//   this.fields.snowDirection.z = 0.0;
			//   this.fields.snowSizeRange.x = 0.0;
			//   *(_QWORD *)&this.fields.lastCamPos.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//   this.fields.lastCamPos.z = 0.0;
			//   this.fields.snowSizeRange.y = 1.0;
			//   this.fields.snowCollisionFadeTimeScale = 1.0;
			//   this.fields.snowLayerCount = 1;
			//   this.fields.cameraMask = -1;
			//   v3 = (SnowCommonPreSettingParam *)sub_180004920(TypeInfo::HG::Rendering::Runtime::Snow::SnowCommonPreSettingParam);
			//   v6 = v3;
			//   if ( !v3 )
			//     sub_180B536AC(v5, v4);
			//   HG::Rendering::Runtime::Snow::SnowCommonPreSettingParam::SnowCommonPreSettingParam(v3, 0LL);
			//   this.fields.snowCommonPreSettingParam = v6;
			//   sub_1800054D0((BSP *)&this.fields.snowCommonPreSettingParam, v7, v8, v9, v11, v12);
			// }
			// 
		}

		public bool enable;

		public float intensity;

		public float speed;

		public Color color;

		public Vector3 snowDirection;

		public Vector3 lastCamPos;

		public float snowJitterLevel;

		public Vector2 snowSizeRange;

		public float snowLightingPercent;

		public float snowCollisionFadeTimeScale;

		public bool enableSnowLighting;

		public int snowLayerCount;

		public bool enableSnowCollision;

		public int cameraMask;

		public SnowCommonPreSettingParam snowCommonPreSettingParam;
	}
}
