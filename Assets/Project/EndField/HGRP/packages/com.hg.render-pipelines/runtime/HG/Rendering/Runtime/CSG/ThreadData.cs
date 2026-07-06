using System;
using System.Collections.Generic;
using UnityEngine;

namespace HG.Rendering.Runtime.CSG
{
	public class ThreadData
	{
		public ThreadData(int s, int e)
		{
			// // SerializeFieldDictionaryPaired`2[TKey,TValue]+KeyValuePair[System.Int32Enum,System.Int32Enum](Int32Enum, Int32Enum)
			// void Beyond::SerializeFieldDictionaryPaired_2_TKey_TValue_::KeyValuePair<System::Int32Enum,System::Int32Enum>::KeyValuePair(
			//         SerializeFieldDictionaryPaired_2_TKey_TValue_KeyValuePair_System_Int32Enum_System_Int32Enum_ *this,
			//         Int32Enum__Enum key,
			//         Int32Enum__Enum value,
			//         MethodInfo *method)
			// {
			//   this.fields.key = key;
			//   this.fields.value = value;
			// }
			// 
		}

		public int start;

		public int end;

		public Matrix4x4 matrix;

		public Vector3[] vertices;

		public Vector3[] normals;

		public Vector2[] uv;

		public List<int> submesh;

		public int objID;

		public int previous;

		public int num;

		public object custom;

		public IEnumerable<CSGPolygon> polys;

		public IList<CSGPolygon> frontPolys;

		public IList<CSGPolygon> backPolys;

		public Node node;
	}
}
