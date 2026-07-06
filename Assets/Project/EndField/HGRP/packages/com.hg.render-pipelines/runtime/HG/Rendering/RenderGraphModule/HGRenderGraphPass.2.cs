using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.Profiling;
using UnityEngine.Rendering;

namespace HG.Rendering.RenderGraphModule
{
	internal abstract class HGRenderGraphPass<PassData> : HGRenderGraphPass where PassData : class, new()
	{
		protected HGRenderGraphPass()
		{
		}

		internal override bool DepthRequiredIfMRT()
		{
			return default(bool);
		}

		protected abstract void BeginRenderPassInternal(HGRenderGraph renderGraph);

		protected abstract void EndRenderPassInternal(HGRenderGraph renderGraph);

		protected abstract void BeginSubpassInternal(int subpassIndex, HGRenderGraph renderGraph);

		protected abstract void EndSubpassInternal(int subpassIndex, HGRenderGraph renderGraph);

		private void ValidateAttachment(ref TextureDesc desc, string type, int index, ref TextureDesc descForCheck)
		{
		}

		private void ValidateRenderPassAttachments(HGRenderGraph renderGraph)
		{
		}

		private void BeginRenderPass(HGRenderGraph renderGraph)
		{
		}

		private void EndRenderPass(HGRenderGraph renderGraph)
		{
		}

		private void BeginSubpass(int subpassIndex, HGRenderGraph renderGraph)
		{
		}

		private void EndSubpass(int subpassIndex, HGRenderGraph renderGraph)
		{
		}

		private void ExecuteSubpassRenderFunc(int subpassIndex, HGRenderGraph renderGraph)
		{
		}

		public virtual void Initialize(int passIndex, PassData passData, string passName, ProfilingSampler sampler, HGRenderGraphObjectPool renderGraphPool, ProfilingHGPass profilingPass)
		{
		}

		internal void SetupPreRenderPassFunc(RenderFunc<PassData> renderFunc)
		{
		}

		internal void SetupPostRenderPassFunc(RenderFunc<PassData> renderFunc)
		{
		}

		public override bool HasRenderFunc()
		{
			return default(bool);
		}

		public override void Clear()
		{
		}

		public override void Release(HGRenderGraphObjectPool pool)
		{
		}

		protected override void ExecuteInternal(HGRenderGraph renderGraph)
		{
		}

		public override void ExecuteAsChildPass(HGRenderGraph renderGraph)
		{
		}

		internal void SetupSubpass()
		{
		}

		internal void SetupSubpass(int subpassIndex, NativeArray<int> colorRTIndices, ProfilingHGPass subpassProfilingHgPass)
		{
		}

		internal void SetupSubpass(int subpassIndex, NativeArray<int> colorRTIndices, NativeArray<int> inputRTIndices, bool depthAsInput, ProfilingHGPass subpassProfilingHgPass)
		{
		}

		internal unsafe void SetupRenderFunc(int subpassIndex, int funcIndex, RenderFunc<PassData> func, object camera, void* customPayload)
		{
		}

		private unsafe static void SetupRenderFuncDescHelper(ref HGRenderGraphPass<PassData>.RenderFuncDesc desc, RenderFunc<PassData> renderFunc, object camera, void* customPayload)
		{
		}

		internal static HGRenderGraphPass<PassData> CreateRenderPass(bool useNativeRenderpass, HGRenderGraphObjectPool renderGraphPool)
		{
			return null;
		}

		internal static HGRenderGraphPass<PassData> CreateRenderPass(HGRenderGraphPassType type, HGRenderGraphObjectPool renderGraphPool)
		{
			return null;
		}

		protected void PopulateLoadStoreAction(ref AttachDesc attachDesc, int passIndex, HGRenderGraph renderGraph)
		{
		}

		private const int PAYLOAD_SIZE = 16;

		protected DynamicArray<HGRenderGraphPass<PassData>.SubpassDesc> m_subpasses;

		internal bool hasRenderFunc;

		internal RenderFunc<PassData> preRenderPassFunc;

		internal RenderFunc<PassData> postRenderPassFunc;

		protected internal PassData data;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		protected struct RenderFuncDesc
		{
			public RenderFunc<PassData> renderFunc;

			public object camera;

			[FixedBuffer(typeof(byte), 16)]
			public HGRenderGraphPass<PassData>.RenderFuncDesc.<customPayload>e__FixedBuffer customPayload;

			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
			public struct <customPayload>e__FixedBuffer
			{
				public byte FixedElementField;
			}
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		protected struct SubpassDesc
		{
			public NativeArray<int> colorRTIndices;

			public NativeArray<int> inputRTIndices;

			public HGRenderGraphPass<PassData>.RenderFuncDesc renderFuncDescs0;

			public HGRenderGraphPass<PassData>.RenderFuncDesc renderFuncDescs1;

			public HGRenderGraphPass<PassData>.RenderFuncDesc renderFuncDescs2;

			public HGRenderGraphPass<PassData>.RenderFuncDesc renderFuncDescs3;

			public bool depthAsInput;

			public ProfilingHGPass profilingHgPass;
		}
	}
}
