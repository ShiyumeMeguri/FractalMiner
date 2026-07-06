using System;
using UnityEngine;

namespace HG.Rendering.Tools
{
	public class LightProbeImportanceVolume : MonoBehaviour
	{
		public LightProbeImportanceVolume()
		{
			// // LightProbeImportanceVolume()
			// void HG::Rendering::Tools::LightProbeImportanceVolume::LightProbeImportanceVolume(
			//         LightProbeImportanceVolume *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // xmm1_8
			//   Vector3 v4; // [rsp+20h] [rbp-48h] BYREF
			//   Vector3 v5; // [rsp+30h] [rbp-38h] BYREF
			//   Bounds v6; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   v4.z = 10.0;
			//   memset(&v6, 0, sizeof(v6));
			//   v5.z = 0.0;
			//   *(_QWORD *)&v5.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//   *(_QWORD *)&v4.x = _mm_unpacklo_ps((__m128)0x41200000u, (__m128)0x41200000u).m128_u64[0];
			//   UnityEngine::Bounds::Bounds(&v6, &v5, &v4, 0LL);
			//   v3 = *(_QWORD *)&v6.m_Extents.y;
			//   *(_OWORD *)&this.fields.bounds.m_Center.x = *(_OWORD *)&v6.m_Center.x;
			//   this.fields.densityXZ = 4.0;
			//   *(_QWORD *)&this.fields.bounds.m_Extents.y = v3;
			//   this.fields.minHeight = 8.0;
			//   this.fields.characterHeight = 1.5;
			//   this.fields.overlapCheckDistance = 2.0;
			//   this.fields.ignoreUnderTerrain = 1;
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static readonly string WALKABLE_LAYER_NAME;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		public static readonly string CLIMBABLE_LAYER_NAME;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		public static readonly string TERRAIN_LAYER_NAME;

		public Bounds bounds;

		[Range(1f, 10f)]
		public float densityXZ;

		public float minHeight;

		public float characterHeight;

		public float overlapCheckDistance;

		public bool ignoreUnderTerrain;
	}
}
