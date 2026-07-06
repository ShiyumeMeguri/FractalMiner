using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public interface IVolumetricCloudVolume
	{
		// (get) Token: 0x06001A8D RID: 6797
		int volumePriority
		{
			get;
		}

		bool Contains(Vector3 position);

		void UpdateVisibility(HGCamera camera, bool visible);

		void FadeInVolume(HGCamera camera);

		void PrepareAssets(HGCamera camera);

		bool LoadFinished();
	}
}
