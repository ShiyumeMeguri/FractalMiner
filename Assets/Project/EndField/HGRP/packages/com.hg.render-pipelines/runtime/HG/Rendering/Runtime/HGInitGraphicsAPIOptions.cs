using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGInitGraphicsAPIOptions // TypeDefIndex: 38692
	{
		// Fields
		public GraphicsDeviceType m_preferredDeviceType; // 0x10
		public bool m_forceRenderPath; // 0x14
		internal HGRenderPathInternal m_renderPath; // 0x18
	
		// Constructors
		public HGInitGraphicsAPIOptions() {} // 0x0000000184DA1DE0-0x0000000184DA1DF0
		// HGInitGraphicsAPIOptions()
		void HG::Rendering::Runtime::HGInitGraphicsAPIOptions::HGInitGraphicsAPIOptions(
		        HGInitGraphicsAPIOptions *this,
		        MethodInfo *method)
		{
		  this->fields.m_preferredDeviceType = 4;
		  this->fields.m_renderPath = 3;
		}
		
		internal HGInitGraphicsAPIOptions(GraphicsDeviceType preferredDeviceType, bool forceOptimizationMethod, HGRenderPathInternal renderPath) {} // 0x0000000184DA1DD0-0x0000000184DA1DE0
		// HGInitGraphicsAPIOptions(GraphicsDeviceType, Boolean, HGRenderPathInternal)
		void HG::Rendering::Runtime::HGInitGraphicsAPIOptions::HGInitGraphicsAPIOptions(
		        HGInitGraphicsAPIOptions *this,
		        GraphicsDeviceType__Enum preferredDeviceType,
		        bool forceOptimizationMethod,
		        HGRenderPathInternal__Enum renderPath,
		        MethodInfo *method)
		{
		  this->fields.m_preferredDeviceType = preferredDeviceType;
		  this->fields.m_forceRenderPath = forceOptimizationMethod;
		  this->fields.m_renderPath = renderPath;
		}
		
	}
}
