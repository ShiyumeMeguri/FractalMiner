using System;
using UnityEngine.Rendering;

namespace HG.Rendering.RenderGraphModule
{
	public class HGRenderGraphContext
	{
		public HGRenderGraphContext()
		{
			// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			//         HGWindConfig *cSrc,
			//         HGWindConfig *cDst,
			//         float t,
			//         MethodInfo *method)
			// {
			//   ;
			// }
			// 
		}

		public ScriptableRenderContext renderContext;

		public CommandBuffer cmd;

		public HGRenderGraphObjectPool renderGraphPool;

		public HGRenderGraphDefaultResources defaultResources;
	}
}
