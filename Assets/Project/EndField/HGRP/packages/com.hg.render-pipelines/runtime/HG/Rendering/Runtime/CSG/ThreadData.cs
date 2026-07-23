using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.CSG
{
	public class ThreadData // TypeDefIndex: 38808
	{
		// Fields
		public int start; // 0x10
		public int end; // 0x14
		public Matrix4x4 matrix; // 0x18
		public Vector3[] vertices; // 0x58
		public Vector3[] normals; // 0x60
		public Vector2[] uv; // 0x68
		public List<int> submesh; // 0x70
		public int objID; // 0x78
		public int previous; // 0x7C
		public int num; // 0x80
		public object custom; // 0x88
		public IEnumerable<CSGPolygon> polys; // 0x90
		public IList<CSGPolygon> frontPolys; // 0x98
		public IList<CSGPolygon> backPolys; // 0xA0
		public Node node; // 0xA8
	
		// Constructors
		public ThreadData() {} // Dummy constructor
		public ThreadData(int s, int e) {} // 0x0000000184D88290-0x0000000184D882A0
		// SerializeFieldDictionaryPaired`2[TKey,TValue]+KeyValuePair[System.Int32Enum,System.Int32Enum](Int32Enum, Int32Enum)
		void Beyond::SerializeFieldDictionaryPaired_2_TKey_TValue_::KeyValuePair<System::Int32Enum,System::Int32Enum>::KeyValuePair(
		        SerializeFieldDictionaryPaired_2_TKey_TValue_KeyValuePair_System_Int32Enum_System_Int32Enum_ *this,
		        Int32Enum__Enum key,
		        Int32Enum__Enum value,
		        MethodInfo *method)
		{
		  this->fields.key = key;
		  this->fields.value = value;
		}
		
	}
}
