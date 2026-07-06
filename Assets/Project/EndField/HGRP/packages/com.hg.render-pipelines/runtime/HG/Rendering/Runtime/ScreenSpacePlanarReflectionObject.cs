using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class ScreenSpacePlanarReflectionObject : MonoBehaviour
	{
		public ScreenSpacePlanarReflectionObject()
		{
			// // ScreenSpacePlanarReflectionObject()
			// void HG::Rendering::Runtime::ScreenSpacePlanarReflectionObject::ScreenSpacePlanarReflectionObject(
			//         ScreenSpacePlanarReflectionObject *this,
			//         MethodInfo *method)
			// {
			//   Vector4 v2; // xmm1
			//   __int64 v3; // r8
			//   Vector4 v4; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   this.fields.planeOffset = 0.1;
			//   this.fields.fadenessRight = 0.30000001;
			//   v2 = *UnityEngine::Vector4::get_one(&v4, method);
			//   *(_DWORD *)(v3 + 84) = 1065353216;
			//   *(Vector4 *)(v3 + 48) = v2;
			//   UnityEngine::Component::Component((Component *)v3, 0LL);
			// }
			// 
		}

		public bool enable;

		[Range(0f, 0.5f)]
		public float planeOffset;

		[Range(0f, 0.25f)]
		public float fadenessLeft;

		[Range(0.3f, 0.6f)]
		public float fadenessRight;

		[Range(0f, 0.1f)]
		public float fadenessThreshold;

		[Range(0f, 0.5f)]
		public float fadenessUV;

		public Color tintColor;

		public bool noiseEnable;

		public Texture2D noiseTexture;

		[Min(0f)]
		public float noiseIntensity;

		[Range(0.25f, 1f)]
		public float rtScale;

		public ReflectionProbe reflectionProbe;
	}
}
