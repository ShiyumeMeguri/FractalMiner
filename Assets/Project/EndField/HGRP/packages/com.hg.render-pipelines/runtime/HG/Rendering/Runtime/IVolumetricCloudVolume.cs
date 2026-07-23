using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public interface IVolumetricCloudVolume // TypeDefIndex: 38714
	{
		// Properties
		int volumePriority { get; }
	
		// Methods
		bool Contains(Vector3 position);
		void UpdateVisibility(HGCamera camera, bool visible);
		void FadeInVolume(HGCamera camera);
		void PrepareAssets(HGCamera camera);
		bool LoadFinished();
	}
}
