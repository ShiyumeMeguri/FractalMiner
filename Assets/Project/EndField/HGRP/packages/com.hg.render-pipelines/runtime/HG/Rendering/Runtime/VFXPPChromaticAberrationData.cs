using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class VFXPPChromaticAberrationData : VFXPPData
	{
		public VFXPPChromaticAberrationData()
		{
			// // NpcAIStrategy`1[System.Object]()
			// void Beyond::Gameplay::AI::NpcAIStrategy<System::Object>::NpcAIStrategy(
			//         NpcAIStrategy_1_System_Object_ *this,
			//         MethodInfo *method)
			// {
			//   this.fields._._.m_tickInterval = 0.1;
			// }
			// 
		}

		[Range(0f, 0.3f)]
		public float intensity;

		public bool useAsCenterPosition;

		public bool averageSteps;
	}
}
