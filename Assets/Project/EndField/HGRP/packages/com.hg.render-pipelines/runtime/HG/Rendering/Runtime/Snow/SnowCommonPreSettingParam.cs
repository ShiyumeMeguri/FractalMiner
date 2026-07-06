using System;
using UnityEngine;

namespace HG.Rendering.Runtime.Snow
{
	[Serializable]
	public class SnowCommonPreSettingParam
	{
		public SnowCommonPreSettingParam()
		{
			// // SnowCommonPreSettingParam()
			// void HG::Rendering::Runtime::Snow::SnowCommonPreSettingParam::SnowCommonPreSettingParam(
			//         SnowCommonPreSettingParam *this,
			//         MethodInfo *method)
			// {
			//   this.fields.snowflakeTex_ST = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18A357570);
			//   this.fields.maxSnowHeight = 100.0;
			//   this.fields.snowMaxUVFlowSpeed = 160.0;
			//   this.fields.snowRange = 30.0;
			//   this.fields.maxMoveDirectionLength = 0.1;
			//   this.fields.snowTemporalTimeThreshould = 1.0;
			// }
			// 
		}

		public Texture2D snowflakeTex;

		public Vector4 snowflakeTex_ST;

		[Range(1f, 300f)]
		public float maxSnowHeight;

		[Range(0f, 200f)]
		public float snowMaxUVFlowSpeed;

		[Range(0f, 100f)]
		public float snowRange;

		[Range(0f, 1f)]
		public float maxMoveDirectionLength;

		[Range(0f, 2f)]
		public float snowTemporalTimeThreshould;

		public Texture2D characterSnowTexture;
	}
}
