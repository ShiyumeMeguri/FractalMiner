using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class HGTerrainDataWithPosWrapper : ScriptableObject
	{
		public HGTerrainDataWithPosWrapper()
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

		public TerrainDataWithPos dataWithPos;
	}
}
