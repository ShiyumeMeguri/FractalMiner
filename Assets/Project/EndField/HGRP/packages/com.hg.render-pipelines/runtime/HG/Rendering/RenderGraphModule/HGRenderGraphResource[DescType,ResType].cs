using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	[DebuggerDisplay("Resource ({GetType().Name}:{GetName()})")]
	internal abstract class HGRenderGraphResource<DescType, ResType> : IHGRenderGraphResource // TypeDefIndex: 37467
		where DescType : struct
		where ResType : class
	{
		// Fields
		public DescType desc;
		public ResType graphicsResource;
	
		// Constructors
		protected HGRenderGraphResource() {}
	
		// Methods
		public override void Reset(IHGRenderGraphResourcePool pool) {}
		public override bool IsCreated() => default;
		public override void ReleaseGraphicsResource() {}
		public void CopyFrom(HGRenderGraphResource<DescType, ResType> other) {}
	}
}
