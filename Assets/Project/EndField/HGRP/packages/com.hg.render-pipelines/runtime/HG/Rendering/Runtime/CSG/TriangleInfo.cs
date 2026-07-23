using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.CSG
{
	public class TriangleInfo // TypeDefIndex: 38806
	{
		// Fields
		public int i; // 0x10
		public int i0; // 0x14
		public int i1; // 0x18
		public int objID; // 0x1C
		public int materialID; // 0x20
	
		// Constructors
		public TriangleInfo() {} // Dummy constructor
		public TriangleInfo(int i, int i0, int i1, int objID, int materialID) {} // 0x0000000184DA2020-0x0000000184DA2040
		// TriangleInfo(Int32, Int32, Int32, Int32, Int32)
		void HG::Rendering::Runtime::CSG::TriangleInfo::TriangleInfo(
		        TriangleInfo *this,
		        int32_t i,
		        int32_t i0,
		        int32_t i1,
		        int32_t objID,
		        int32_t materialID,
		        MethodInfo *method)
		{
		  this->fields.objID = objID;
		  this->fields.materialID = materialID;
		  this->fields.i = i;
		  this->fields.i0 = i0;
		  this->fields.i1 = i1;
		}
		
	}
}
