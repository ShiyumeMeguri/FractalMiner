using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime.CSG
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 28)]
	public struct PostionUVPair
	{
		public PostionUVPair(Vector3 pos, Vector2 uv, int objID, int materialID)
		{
			// // PostionUVPair(Vector3, Vector2, Int32, Int32)
			// void HG::Rendering::Runtime::CSG::PostionUVPair::PostionUVPair(
			//         PostionUVPair *this,
			//         Vector3 *pos,
			//         Vector2 uv,
			//         int32_t objID,
			//         int32_t materialID,
			//         MethodInfo *method)
			// {
			//   float z; // eax
			// 
			//   z = pos.z;
			//   *(_QWORD *)&this.position.x = *(_QWORD *)&pos.x;
			//   this.position.z = z;
			//   this.materialID = materialID;
			//   this.uv = uv;
			//   this.objID = objID;
			// }
			// 
		}

		public Vector3 position;

		public Vector2 uv;

		public int objID;

		public int materialID;
	}
}
