using System;

namespace HG.Rendering.Runtime.CSG
{
	public class TriangleInfo
	{
		public TriangleInfo(int i, int i0, int i1, int objID, int materialID)
		{
			// // TriangleInfo(Int32, Int32, Int32, Int32, Int32)
			// void HG::Rendering::Runtime::CSG::TriangleInfo::TriangleInfo(
			//         TriangleInfo *this,
			//         int32_t i,
			//         int32_t i0,
			//         int32_t i1,
			//         int32_t objID,
			//         int32_t materialID,
			//         MethodInfo *method)
			// {
			//   this.fields.objID = objID;
			//   this.fields.materialID = materialID;
			//   this.fields.i = i;
			//   this.fields.i0 = i0;
			//   this.fields.i1 = i1;
			// }
			// 
		}

		public int i;

		public int i0;

		public int i1;

		public int objID;

		public int materialID;
	}
}
