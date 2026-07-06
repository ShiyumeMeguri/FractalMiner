using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public class HGWaterStreamingConfig : ScriptableObject
	{
		public HGWaterStreamingConfig()
		{
			// // SingletonScriptableObject`1[System.Object]()
			// void Beyond::SingletonScriptableObject<System::Object>::SingletonScriptableObject(
			//         SingletonScriptableObject_1_System_Object_ *this,
			//         MethodInfo *method)
			// {
			//   UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
			// }
			// 
		}

		[Header("局部Flowmap贴图")]
		public Texture2D flowMap;

		[Header("FlowmMap Packing数据")]
		public int[] packingData;

		public int indexX;

		public int indexZ;

		public int validGrid;
	}
}
