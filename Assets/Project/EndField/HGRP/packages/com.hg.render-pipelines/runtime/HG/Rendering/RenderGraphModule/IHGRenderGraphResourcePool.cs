using System;

namespace HG.Rendering.RenderGraphModule
{
	internal abstract class IHGRenderGraphResourcePool
	{
		protected IHGRenderGraphResourcePool()
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

		public abstract void PurgeUnusedResources(int currentFrameIndex);

		public abstract void Cleanup();

		public abstract void CheckFrameAllocation(bool onException, int frameIndex);

		public abstract void LogResources(HGRenderGraphLogger logger);
	}
}
