using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine.Profiling;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	internal abstract class HGRenderGraphPass<PassData> : HGRenderGraphPass // TypeDefIndex: 37446
		where PassData : class, new()
	{
		// Fields
		private const int PAYLOAD_SIZE = 16; // Metadata: 0x02302D6B
		protected DynamicArray<SubpassDesc> m_subpasses;
		internal bool hasRenderFunc;
		internal RenderFunc<PassData> preRenderPassFunc;
		internal RenderFunc<PassData> postRenderPassFunc;
		protected internal PassData data;
	
		// Nested types
		protected struct RenderFuncDesc // TypeDefIndex: 37444
		{
			// Fields
			public RenderFunc<PassData> renderFunc;
			public object camera;
			public unsafe fixed /* 0x00000000-0x00000000 */ byte customPayload[0];
		}
	
		protected struct SubpassDesc // TypeDefIndex: 37445
		{
			// Fields
			public NativeArray<int> colorRTIndices;
			public NativeArray<int> inputRTIndices;
			public RenderFuncDesc<PassData> renderFuncDescs0;
			public RenderFuncDesc<PassData> renderFuncDescs1;
			public RenderFuncDesc<PassData> renderFuncDescs2;
			public RenderFuncDesc<PassData> renderFuncDescs3;
			public bool depthAsInput;
			public ProfilingHGPass profilingHgPass;
		}
	
		// Constructors
		protected HGRenderGraphPass() {}
	
		// Methods
		internal override bool DepthRequiredIfMRT() => default;
		protected abstract void BeginRenderPassInternal(HGRenderGraph renderGraph);
		protected abstract void EndRenderPassInternal(HGRenderGraph renderGraph);
		protected abstract void BeginSubpassInternal(int subpassIndex, HGRenderGraph renderGraph);
		protected abstract void EndSubpassInternal(int subpassIndex, HGRenderGraph renderGraph);
		private void ValidateAttachment(ref TextureDesc desc, string type, int index, ref TextureDesc descForCheck) {}
		private void ValidateRenderPassAttachments(HGRenderGraph renderGraph) {}
		private void BeginRenderPass(HGRenderGraph renderGraph) {}
		private void EndRenderPass(HGRenderGraph renderGraph) {}
		private void BeginSubpass(int subpassIndex, HGRenderGraph renderGraph) {}
		private void EndSubpass(int subpassIndex, HGRenderGraph renderGraph) {}
		private void ExecuteSubpassRenderFunc(int subpassIndex, HGRenderGraph renderGraph) {}
		public virtual void Initialize(int passIndex, PassData passData, string passName, ProfilingSampler sampler, HGRenderGraphObjectPool renderGraphPool, ProfilingHGPass profilingPass) {}
		internal void SetupPreRenderPassFunc(RenderFunc<PassData> renderFunc) {}
		internal void SetupPostRenderPassFunc(RenderFunc<PassData> renderFunc) {}
		public override bool HasRenderFunc() => default;
		public override void Clear() {}
		public override void Release(HGRenderGraphObjectPool pool) {}
		protected override void ExecuteInternal(HGRenderGraph renderGraph) {}
		public override void ExecuteAsChildPass(HGRenderGraph renderGraph) {}
		internal void SetupSubpass() {}
		internal void SetupSubpass(int subpassIndex, NativeArray<int> colorRTIndices, ProfilingHGPass subpassProfilingHgPass) {}
		internal void SetupSubpass(int subpassIndex, NativeArray<int> colorRTIndices, NativeArray<int> inputRTIndices, bool depthAsInput, ProfilingHGPass subpassProfilingHgPass) {}
		internal unsafe void SetupRenderFunc(int subpassIndex, int funcIndex, RenderFunc<PassData> func, object camera, void* customPayload) {}
		private static unsafe void SetupRenderFuncDescHelper(ref RenderFuncDesc desc, RenderFunc<PassData> renderFunc, object camera, void* customPayload) {}
		internal static HGRenderGraphPass<PassData> CreateRenderPass(bool useNativeRenderpass, HGRenderGraphObjectPool renderGraphPool) => default;
		internal static HGRenderGraphPass<PassData> CreateRenderPass(HGRenderGraphPassType type, HGRenderGraphObjectPool renderGraphPool) => default;
		protected void PopulateLoadStoreAction(ref AttachDesc attachDesc, int passIndex, HGRenderGraph renderGraph) {}
	}
}
