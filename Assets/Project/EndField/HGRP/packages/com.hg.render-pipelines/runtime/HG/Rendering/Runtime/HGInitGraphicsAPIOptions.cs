using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class HGInitGraphicsAPIOptions
	{
		public HGInitGraphicsAPIOptions()
		{
			// // HGInitGraphicsAPIOptions()
			// void HG::Rendering::Runtime::HGInitGraphicsAPIOptions::HGInitGraphicsAPIOptions(
			//         HGInitGraphicsAPIOptions *this,
			//         MethodInfo *method)
			// {
			//   this.fields.m_preferredDeviceType = 4;
			//   this.fields.m_renderPath = 3;
			// }
			// 
		}

		internal HGInitGraphicsAPIOptions(GraphicsDeviceType preferredDeviceType, bool forceOptimizationMethod, HGRenderPathInternal renderPath)
		{
			// // HGInitGraphicsAPIOptions(GraphicsDeviceType, Boolean, HGRenderPathInternal)
			// void HG::Rendering::Runtime::HGInitGraphicsAPIOptions::HGInitGraphicsAPIOptions(
			//         HGInitGraphicsAPIOptions *this,
			//         GraphicsDeviceType__Enum preferredDeviceType,
			//         bool forceOptimizationMethod,
			//         HGRenderPathInternal__Enum renderPath,
			//         MethodInfo *method)
			// {
			//   this.fields.m_preferredDeviceType = preferredDeviceType;
			//   this.fields.m_forceRenderPath = forceOptimizationMethod;
			//   this.fields.m_renderPath = renderPath;
			// }
			// 
		}

		public GraphicsDeviceType m_preferredDeviceType;

		public bool m_forceRenderPath;

		internal HGRenderPathInternal m_renderPath;
	}
}
