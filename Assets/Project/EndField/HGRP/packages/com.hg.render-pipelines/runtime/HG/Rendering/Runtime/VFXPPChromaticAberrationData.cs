using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class VFXPPChromaticAberrationData : VFXPPData // TypeDefIndex: 37942
	{
		// Fields
		[Range(0f, 0.3f)]
		public float intensity; // 0x18
		public bool useAsCenterPosition; // 0x1C
		public bool averageSteps; // 0x1D
	
		// Constructors
		public VFXPPChromaticAberrationData() {} // 0x0000000184D8D240-0x0000000184D8D250
		// NpcAIStrategy`1[System.Object]()
		void Beyond::Gameplay::AI::NpcAIStrategy<System::Object>::NpcAIStrategy(
		        NpcAIStrategy_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  this->fields._._.m_tickInterval = 0.1;
		}
		
	}
}
