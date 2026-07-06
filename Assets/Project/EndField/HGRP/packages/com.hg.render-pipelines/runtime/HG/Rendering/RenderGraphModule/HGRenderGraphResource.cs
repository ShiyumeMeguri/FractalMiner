using System;
using System.Diagnostics;

namespace HG.Rendering.RenderGraphModule
{
	[DebuggerDisplay("Resource ({GetType().Name}:{GetName()})")]
	internal abstract class HGRenderGraphResource<DescType, ResType> : IHGRenderGraphResource where DescType : struct where ResType : class
	{
		protected HGRenderGraphResource()
		{
		}

		public override void Reset(IHGRenderGraphResourcePool pool)
		{
		}

		public override bool IsCreated()
		{
			return default(bool);
		}

		public override void ReleaseGraphicsResource()
		{
		}

		public void CopyFrom(HGRenderGraphResource<DescType, ResType> other)
		{
		}

		public DescType desc;

		public ResType graphicsResource;
	}
}
