using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.CSG
{
	public struct PostionUVPair // TypeDefIndex: 38807
	{
		// Fields
		public Vector3 position; // 0x00
		public Vector2 uv; // 0x0C
		public int objID; // 0x14
		public int materialID; // 0x18
	
		// Constructors
		public PostionUVPair(Vector3 pos, Vector2 uv, int objID, int materialID) {
			position = default;
			this.uv = default;
			this.objID = default;
			this.materialID = default;
		} // 0x0000000184DA1FD0-0x0000000184DA1FF0
		// PostionUVPair(Vector3, Vector2, Int32, Int32)
		void HG::Rendering::Runtime::CSG::PostionUVPair::PostionUVPair(
		        PostionUVPair *this,
		        Vector3 *pos,
		        Vector2 uv,
		        int32_t objID,
		        int32_t materialID,
		        MethodInfo *method)
		{
		  float z; // eax
		
		  z = pos->z;
		  *(_QWORD *)&this->position.x = *(_QWORD *)&pos->x;
		  this->position.z = z;
		  this->materialID = materialID;
		  this->uv = uv;
		  this->objID = objID;
		}
		
	}
}
