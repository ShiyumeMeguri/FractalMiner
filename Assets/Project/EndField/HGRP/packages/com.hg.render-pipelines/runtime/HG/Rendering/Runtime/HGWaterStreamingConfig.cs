using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public class HGWaterStreamingConfig : ScriptableObject // TypeDefIndex: 38792
	{
		// Fields
		[Header("\u5C40\u90E8Flowmap\u8D34\u56FE")]
		public Texture2D flowMap; // 0x18
		[Header("FlowmMap Packing\u6570\u636E")]
		public int[] packingData; // 0x20
		public int indexX; // 0x28
		public int indexZ; // 0x2C
		public int validGrid; // 0x30
	
		// Constructors
		public HGWaterStreamingConfig() {} // 0x0000000183573370-0x0000000183573380
		// SingletonScriptableObject`1[System.Object]()
		void Beyond::SingletonScriptableObject<System::Object>::SingletonScriptableObject(
		        SingletonScriptableObject_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
		}
		
	}
}
