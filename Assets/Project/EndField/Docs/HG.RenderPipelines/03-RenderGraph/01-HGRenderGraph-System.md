# 净室实现文档: HGRenderGraph 渲染图系统

> **注意**: 本文档基于对源代码的静态分析生成。源文件包含 IL2CPP AOT 编译产物和 IFix 热修复包装器代码，实际的 C# 声明已被提取并整理如下。本文档用于指导净室实现（Clean Room Implementation）。

---

## 1. 概述

HGRenderGraph 是 HG 自定义实现的渲染图（Render Graph）系统，**不是** Unity 内置的 RenderGraph API。它位于命名空间 HG.Rendering.RenderGraphModule 中，提供了一种声明式、自动管理资源生命周期的渲染管线构建方式。

### 核心设计目标
- **声明式 Pass 注册**: 通过 AddRenderPass<> 注册 Pass，框架自动推导资源依赖
- **自动资源管理**: 基于 DAG（有向无环图）分析，自动分配、复用、释放临时资源
- **双 Pass 模式**: 支持 Regular（常规）和 Native（原生 RenderPass，利用 Subpass）两种 Pass 类型
- **资源池化**: Texture 和 ComputeBuffer 通过对象池复用，减少 GC 和 GPU 分配
- **Pass Culling**: 自动剔除未被使用的 Pass
- **Debug 工具**: 提供 DebugUI 面板、日志、Profiling 等诊断设施
- **异步计算**: 支持异步计算队列同步

### 与 Unity RenderGraph API 的区别
| 特性 | Unity RenderGraph | HGRenderGraph |
|------|-------------------|---------------|
| 命名空间 | UnityEngine.Rendering.RenderGraphModule | HG.Rendering.RenderGraphModule |
| Pass 类型 | Raster/Compute/Unsupported | Regular/Native（RenderPass） |
| Subpass | 不支持 | 原生支持（NativePass） |
| Native RenderPass | 间接支持 | 一等公民 |
| IFix 热修复 | 不支持 | 完整支持（[IDTag] 标记） |
| Profiling | BasicSampler | ProfilingSampler + ProfilingHGPass |
| 资源句柄 | TextureHandle/ComputeBufferHandle/BufferHandle | TextureHandle/ComputeBufferHandle/RendererListHandle |
| 对象池 | 有限 | HGRenderGraphObjectPool（数组、MaterialPropertyBlock） |

---

## 2. 文件清单

| 文件名 | 作用 |
|--------|------|
| HGRenderGraph.cs | 主入口类，管理 Pass 注册、编译、执行、资源创建/导入 |
| HGRenderGraphPass.cs | Pass 基类 HGRenderGraphPass 和泛型基类 HGRenderGraphPass<PassData> |
| HGRenderGraphPassRegular.cs | 常规 Pass 实现 HGRenderGraphPassRegular<PassData> |
| HGRenderGraphPassNative.cs | 原生 RenderPass 实现 HGRenderGraphPassNative<PassData> |
| HGRenderGraphPassType.cs | Pass 类型枚举 HGRenderGraphPassType |
| HGRenderGraphBuilder.cs | Fluent API Builder，用于配置 Pass 的输入/输出/Subpass/RenderFunc |
| HGRenderGraphExecution.cs | 执行上下文结构体 HGRenderGraphExecution，封装执行入口 |
| HGRenderGraphResource.cs | 资源基类 HGRenderGraphResource<DescType, ResType> |
| HGRenderGraphResourceRegistry.cs | 资源注册中心，管理所有资源的创建/查询/释放 |
| HGRenderGraphResourcePool.cs | 资源池基类 HGRenderGraphResourcePool<Type> |
| HGRenderGraphResourceType.cs | 资源类型枚举 HGRenderGraphResourceType |
| HGRenderGraphContext.cs | 上下文对象 HGRenderGraphContext（cmd, renderContext, pool, defaultResources） |
| HGRenderGraphObjectPool.cs | 通用对象池，用于 PassData、数组、MaterialPropertyBlock 的复用 |
| HGRenderGraphDefaultResources.cs | 默认资源（黑/白/红纹理、阴影纹理等） |
| HGRenderGraphDebugData.cs | Debug 数据类，记录 Pass 和 Resource 的调试信息 |
| HGRenderGraphDebugParams.cs | Debug 参数类，暴露 DebugUI 开关 |
| HGRenderGraphParameters.cs | 执行参数结构体 HGRenderGraphParameters |
| HGRenderGraphLogger.cs | 日志记录器 |
| HGRenderGraphLogIndent.cs | 日志缩进作用域 |
| HGRenderGraphProfileId.cs | Profiling ID 枚举 |
| HGRenderGraphProfilingScope.cs | Profiling 作用域 |
| ResourceHandle.cs | 资源句柄统一抽象 |
| TextureHandle.cs | 纹理句柄 |
| TextureResource.cs | 纹理资源包装 |
| TexturePool.cs | 纹理对象池 |
| ComputeBufferHandle.cs | ComputeBuffer 句柄 |
| ComputeBufferResource.cs | ComputeBuffer 资源包装 |
| ComputeBufferPool.cs | ComputeBuffer 对象池 |
| RendererListHandle.cs | RendererList 句柄 |
| RendererListResource.cs | RendererList 资源包装 |
| RenderFunc.cs | 渲染函数委托 RenderFunc<PassData> |
| TextureDesc.cs | 纹理描述符结构体 |
| TextureSizeMode.cs | 纹理尺寸模式枚举 Explicit/Scale/Functor |
| ComputeBufferDesc.cs | ComputeBuffer 描述符结构体 |
| AttachDesc.cs | 附件描述符（索引、加载/存储操作、清除颜色等） |
| DepthAccess.cs | 深度访问标志枚举 Read/Write/ReadWrite |
| FastMemoryDesc.cs | 快速内存描述符 |
| IHGRenderGraphResource.cs | 资源接口基类 |
| IHGRenderGraphResourcePool.cs | 资源池接口基类 |
| IRenderGraphCallbackOwner.cs | 回调拥有者接口 |

---

## 3. HGRenderGraph 主类

### 3.1 内部结构体

#### CompiledResourceInfo
`csharp
internal struct CompiledResourceInfo
{
    public List<int> producers;
    public List<int> consumers;
    public int refCount;
    public bool imported;
    public void Reset();
}
`

#### BackBufferInfo
`csharp
private struct BackBufferInfo
{
    internal TextureHandle color;
    internal TextureHandle depth;
    internal bool offScreen;
}
`

#### CompiledPassInfo
`csharp
[DebuggerDisplay("RenderPass: {pass.name} (Index:{pass.index} Async:{enableAsyncCompute})")]
internal struct CompiledPassInfo
{
    public HGRenderGraphPass pass;
    public List<int>[] resourceCreateList;
    public List<int>[] resourceReleaseList;
    public int refCount;
    public bool culled;
    public bool hasSideEffect;
    public int syncToPassIndex;
    public int syncFromPassIndex;
    public bool needGraphicsFence;
    public GraphicsFence fence;
    public bool enableAsyncCompute;
    public bool allowPassCulling => false;
    public void Reset(HGRenderGraphPass pass);
}
`

#### ExecuteHGRenderGraphV2PassData
`csharp
public class ExecuteHGRenderGraphV2PassData
{
    public long rg;
    public NativeList<long> importAs;
    public NativeList<TextureHandle> importBs;
    public NativeList<long> importBufferResourceHandles;
    public NativeList<ComputeBufferHandle> importBufferHandles;
    public HGRenderGraph renderGraph;
    public bool forceIssueRenderPass;
}
`
### 3.2 字段声明

```csharp
// 静态字段
public static readonly int kMaxMRTCount;
private static List<HGRenderGraph> s_RegisteredGraphs;
private static readonly RenderFunc<ProfilingScopePassData> s_beginProfilingSamplerRenderFunc;
private static readonly RenderFunc<ProfilingScopePassData> s_endProfilingSamplerRenderFunc;

// 实例字段
private HGRenderGraphResourceRegistry m_Resources;
private HGRenderGraphObjectPool m_RenderGraphPool;
private List<HGRenderGraphPass> m_RenderPasses;
```
// 实例字段
private List<RendererListHandle> m_RendererLists;
private List<IRenderGraphCallbackOwner> m_callbackOwner;
private HGRenderGraphDebugParams m_DebugParameters;
private HGRenderGraphLogger m_FrameInformationLogger;
private HGRenderGraphDefaultResources m_DefaultResources;
private Dictionary<int, ProfilingSampler> m_DefaultProfilingSamplers;
private bool m_ExecutionExceptionWasRaised;
private HGRenderGraphContext m_RenderGraphContext;
private CommandBuffer m_PreviousCommandBuffer;
private int m_CurrentImmediatePassIndex;
private List<int>[] m_ImmediateModeResourceList;
private BackBufferInfo m_backBufferInfo;
private DynamicArray<CompiledResourceInfo>[] m_CompiledResourcesInfos;
private DynamicArray<CompiledPassInfo> m_CompiledPassInfos;
private Stack<int> m_CullingStack;
private int m_ExecutionCount;
private int m_CurrentFrameIndex;
private string m_CurrentExecutionName;
private bool m_RendererListCulling;
private int m_currentExecutorID;
private int m_currentExecutorFrameIndex;
private Dictionary<string, HGRenderGraphDebugData> m_DebugData;
```

### 3.3 属性

```csharp
public string name { get; private set; }
internal static bool requireDebugData { get; set; }
public HGRenderGraphDefaultResources defaultResources => null;
internal HGRenderGraphContext HGContext => null;
internal HGRenderGraphResourceRegistry resourceRegistry => null;
public bool enableCppRenderPath { get; set; }
public bool enableSimpleUIRenderPath { get; set; }
```

### 3.4 事件

```csharp
internal static event OnGraphRegisteredDelegate onGraphRegistered;
internal static event OnGraphRegisteredDelegate onGraphUnregistered;
internal static event OnExecutionRegisteredDelegate onExecutionRegistered;
internal static event OnExecutionRegisteredDelegate onExecutionUnregistered;
```

### 3.5 公共方法签名

```csharp
public HGRenderGraph(string name = "RenderGraph")
public void Cleanup()
public void RegisterDebug(DebugUI.Panel panel = null)
public void UnRegisterDebug()
public static List<HGRenderGraph> GetRegisteredRenderGraphs()
public void EndFrame()

// 资源导入
public TextureHandle ImportTexture(RTHandle rt)
public TextureHandle ImportTexture(RTHandle rt, int width, int height)
public TextureHandle ImportDepthbuffer(RTHandle rt)
public (TextureHandle, TextureHandle) ImportBackbuffer(RenderTargetIdentifier color, RenderTargetIdentifier depth, ref TextureDesc colorDesc, ref TextureDesc depthDesc, bool offScreen)
public bool IsBackBuffer(TextureHandle rt)
public ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer)

// 资源创建
public TextureHandle CreateTexture(ref TextureDesc desc)
public TextureHandle CreateTexture(ref TextureHandle texture)
public void CreateTextureIfInvalid(ref TextureDesc desc, ref TextureHandle texture)
public TextureDesc GetTextureDesc(in TextureHandle texture)
public ref TextureDesc GetTextureDescRef(ref TextureHandle texture)
public TextureHandle PreserveTexture(ref TextureHandle texture, int frameCount, string info)
public void ReleaseAllPreservedTextures(int executorID)
public RendererListHandle CreateRendererList(in RendererListDesc desc)
public ComputeBufferHandle CreateComputeBuffer(in ComputeBufferDesc desc)
public ComputeBufferHandle CreateComputeBuffer(in ComputeBufferHandle computeBuffer)
public ComputeBufferDesc GetComputeBufferDesc(in ComputeBufferHandle computeBuffer)

// Pass 注册
public HGRenderGraphBuilder AddRenderPass<PassData>(string passName, out PassData passData, ProfilingSampler sampler, bool useNativeRenderpass = true, ProfilingHGPass profilingHgPass = ProfilingHGPass.None) where PassData : class, new()
public HGRenderGraphBuilder AddRenderPass<PassData>(string passName, out PassData passData) where PassData : class, new()

// 执行
public HGRenderGraphExecution RecordAndExecute(in HGRenderGraphParameters parameters)

// Profiling
public void BeginProfilingSampler(ProfilingSampler sampler)
public void EndProfilingSampler(ProfilingSampler sampler)
```

### 3.6 Execute() 流程

`HGRenderGraphExecution.Dispose()` 触发 `HGRenderGraph.Execute()`，完整流程：

```
RecordAndExecute(parameters)
  |
  v
SetupContext(parameters)      // 设置 m_RenderGraphContext, m_CurrentFrameIndex 等
  |
  v
CompileRenderGraph()          // DAG 编译
  |  +-- 遍历 m_RenderPasses
  |  +-- 构建 CompiledResourceInfo[type]（producers/consumers/refCount）
  |  +-- 构建 CompiledPassInfo（resourceCreateList/resourceReleaseList）
  |  +-- Pass Culling（基于 AllowPassCulling、refCount、hasSideEffect）
  |  +-- 异步计算同步（syncToPassIndex/syncFromPassIndex, GraphicsFence）
  |  +-- 排序 Pass（Native 优先，无依赖 Regular 其次，依赖者最后）
  v
ExecuteRenderGraph()
  |  +-- 遍历 CompiledPassInfo
  |  +-- 创建 Pass 需要的资源（resourceCreateList）
  |  +-- 执行 Pass（pass.Execute(this)）
  |  +-- 释放 Pass 不再需要的资源（resourceReleaseList）
  |  +-- 处理异步计算同步（WaitOnGraphicsFence）
  v
CleanupResources()            // 清理本帧分配的资源
```

### 3.7 DAG 编译

DAG 编译过程（`CompileRenderGraph`）：

1. **遍历所有 Pass**，收集每个 Pass 的 `resourceReadLists` 和 `resourceWriteLists`
2. **对每个资源**，追踪其所有 Producer（写该资源的 Pass）和 Consumer（读该资源的 Pass）
3. **计算 refCount** = producer 数量 + consumer 数量（imported 资源除外）
4. **Pass Culling**：如果 `allowPassCulling=true` 且 refCount=0 且 `hasSideEffect=false`，该 Pass 被标记为 culled
5. **资源生命周期**：对每个 Pass，计算需要创建的临时资源和需要释放的资源（`resourceCreateList`/`resourceReleaseList`）
6. **异步计算**：如果 Pass 启用了 `enableAsyncCompute`，插入 `syncToPassIndex`/`syncFromPassIndex` 和 `GraphicsFence`
7. **排序**：Native RenderPass 优先，然后是没有依赖的 Regular Pass，最后是依赖其他 Pass 的 Pass

---

## 4. HGRenderGraphPass 类层次

### 4.1 HGRenderGraphPass 基类

```csharp
[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
internal abstract class HGRenderGraphPass
{
    // 常量
    protected const int MAX_RENDER_FUNC_COUNT = 4;

    // 字段
    public AttachDesc depthAttachment;
    public DynamicArray<AttachDesc> colorAttachments;
    public List<ResourceHandle>[] resourceReadLists;      // [2] 0=Texture, 1=ComputeBuffer
    public List<ResourceHandle>[] resourceWriteLists;     // [2]
    public List<ResourceHandle>[] transientResourceList;  // [2]
    public List<RendererListHandle> usedRendererListList;
    public List<RendererListHandle> dependsOnRendererListList;
    private List<HGRenderGraphPass> m_childPasses;
    private HGRenderGraphPass m_parentPass;

    // 属性
    public string name { get; protected set; }
    public int index { get; protected set; }
    public ProfilingSampler customSampler { get; protected set; }
    public ProfilingHGPass profilingHgPass { get; protected set; }
    public bool enableAsyncCompute { get; protected set; }
    public bool allowPassCulling { get; protected set; }
    public int refCount { get; protected set; }
    public bool generateDebugData { get; protected set; }
    public bool allowRendererListCulling { get; protected set; }

    // 抽象方法
    public abstract void ExecuteAsChildPass(HGRenderGraph renderGraph);
    public abstract void Release(HGRenderGraphObjectPool pool);
    public abstract bool HasRenderFunc();
    protected abstract void ExecuteInternal(HGRenderGraph renderGraph);

    // 虚方法
    public virtual void Clear();

    // 公共方法
    public void AddResourceWrite(in ResourceHandle res);
    public void AddResourceRead(in ResourceHandle res);
    public void AddTransientResource(in ResourceHandle res);
    public void UseRendererList(RendererListHandle rendererList);
    public void DependsOnRendererList(RendererListHandle rendererList);
    public void EnableAsyncCompute(bool value);
    public void AllowPassCulling(bool value);
    public void AllowRendererListCulling(bool value);
    public void GenerateDebugData(bool value);
    public void SetColorAttachment(TextureHandle attachment, int index, uint depthSlice);
    public void SetColorAttachment(TextureHandle attachment, int index, Color clearColor, uint depthSlice);
    public void SetColorAttachment(TextureHandle attachment, int index, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Color clearColor, uint depthSlice);
    public void SetDepthAttachment(TextureHandle depth, DepthAccess depthAccess, uint depthSlice);
    public void SetDepthAttachment(TextureHandle depth, DepthAccess depthAccess, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, float clearDepth, byte clearStencil, uint depthSlice);
    internal abstract bool DepthRequiredIfMRT();
    protected bool NecessaryToIssueRenderPass();
    public void Execute(HGRenderGraph renderGraph);
    internal void AddChildPass(HGRenderGraphPass pass);
    protected void ExecuteChildPasses(HGRenderGraph renderGraph);
}
```

### 4.2 HGRenderGraphPass<PassData> 泛型基类

```csharp
internal abstract class HGRenderGraphPass<PassData> : HGRenderGraphPass where PassData : class, new()
{
    protected struct RenderFuncDesc
    {
        public RenderFunc<PassData> renderFunc;
        public object camera;
        public unsafe fixed byte customPayload[16];
    }

    protected struct SubpassDesc
    {
        public NativeArray<int> colorRTIndices;
        public NativeArray<int> inputRTIndices;
        public RenderFuncDesc renderFuncDescs0;
        public RenderFuncDesc renderFuncDescs1;
        public RenderFuncDesc renderFuncDescs2;
        public RenderFuncDesc renderFuncDescs3;
        public bool depthAsInput;
        public ProfilingHGPass profilingHgPass;
    }

    private const int PAYLOAD_SIZE = 16;

    protected DynamicArray<SubpassDesc> m_subpasses;
    internal bool hasRenderFunc;
    internal RenderFunc<PassData> preRenderPassFunc;
    internal RenderFunc<PassData> postRenderPassFunc;
    protected internal PassData data;

    // 抽象方法
    protected abstract void BeginRenderPassInternal(HGRenderGraph renderGraph);
    protected abstract void EndRenderPassInternal(HGRenderGraph renderGraph);
    protected abstract void BeginSubpassInternal(int subpassIndex, HGRenderGraph renderGraph);
    protected abstract void EndSubpassInternal(int subpassIndex, HGRenderGraph renderGraph);

    // 公共方法
    public virtual void Initialize(int passIndex, PassData passData, string passName, ProfilingSampler sampler, HGRenderGraphObjectPool renderGraphPool, ProfilingHGPass profilingPass);
    internal void SetupPreRenderPassFunc(RenderFunc<PassData> renderFunc);
    internal void SetupPostRenderPassFunc(RenderFunc<PassData> renderFunc);
    public override bool HasRenderFunc();
    public override void Clear();
    public override void Release(HGRenderGraphObjectPool pool);
    protected override void ExecuteInternal(HGRenderGraph renderGraph);
    public override void ExecuteAsChildPass(HGRenderGraph renderGraph);
    internal void SetupSubpass();
    internal void SetupSubpass(int subpassIndex, NativeArray<int> colorRTIndices, ProfilingHGPass subpassProfilingHgPass);
    internal void SetupSubpass(int subpassIndex, NativeArray<int> colorRTIndices, NativeArray<int> inputRTIndices, bool depthAsInput, ProfilingHGPass subpassProfilingHgPass);
    internal unsafe void SetupRenderFunc(int subpassIndex, int funcIndex, RenderFunc<PassData> func, object camera, void* customPayload);
    internal static HGRenderGraphPass<PassData> CreateRenderPass(bool useNativeRenderpass, HGRenderGraphObjectPool renderGraphPool);
    internal static HGRenderGraphPass<PassData> CreateRenderPass(HGRenderGraphPassType type, HGRenderGraphObjectPool renderGraphPool);
    protected void PopulateLoadStoreAction(ref AttachDesc attachDesc, int passIndex, HGRenderGraph renderGraph);
    private void ValidateAttachment(ref TextureDesc desc, string type, int index, ref TextureDesc descForCheck);
}
```

### 4.3 HGRenderGraphPassRegular<PassData>

```csharp
[DebuggerDisplay("Regular RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
internal sealed class HGRenderGraphPassRegular<PassData> : HGRenderGraphPass<PassData> where PassData : class, new()
{
    internal override bool DepthRequiredIfMRT() => false;
    protected override void BeginRenderPassInternal(HGRenderGraph renderGraph);  // 空实现
    protected override void EndRenderPassInternal(HGRenderGraph renderGraph);    // 空实现
    protected override void BeginSubpassInternal(int subpassIndex, HGRenderGraph renderGraph);
    protected override void EndSubpassInternal(int subpassIndex, HGRenderGraph renderGraph);
}
```

Regular Pass 没有 Native RenderPass 的生命周期管理（`BeginRenderPass`/`EndRenderPass` 是空实现）。它在 `ExecuteInternal` 中直接调用 `RenderFunc`，逐条发出 CommandBuffer 命令。

### 4.4 HGRenderGraphPassNative<PassData>

```csharp
[DebuggerDisplay("Native RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
internal sealed class HGRenderGraphPassNative<PassData> : HGRenderGraphPass<PassData> where PassData : class, new()
{
    internal override bool DepthRequiredIfMRT() => false;
    protected override void BeginRenderPassInternal(HGRenderGraph renderGraph);
    protected override void EndRenderPassInternal(HGRenderGraph renderGraph);
    protected override void BeginSubpassInternal(int subpassIndex, HGRenderGraph renderGraph);
    protected override void EndSubpassInternal(int subpassIndex, HGRenderGraph renderGraph);
}
```

Native Pass 使用 `ScriptableRenderContext.BeginRenderPass`/`BeginSubPass`/`EndSubPass`/`EndRenderPass` API。
在 `BeginRenderPassInternal` 中：
1. 检查是否有 `depthAttachment`
2. 构建 `NativeArray<AttachmentDescriptor>`（颜色附件 + 深度附件）
3. 调用 `BeginRenderPass`（可选 int width/height 参数）
4. 在 `BeginSubpassInternal` 中：调用 `BeginSubPass`，设置渲染目标

### 4.5 HGRenderGraphPassType 枚举

```csharp
public enum HGRenderGraphPassType
{
    HGRGP_Regular = 0,  // 常规 Pass
    HGRGP_Native = 1,   // 原生 RenderPass（支持 Subpass）
    HGRGP_Count = 2
}
```

---

## 5. HGRenderGraphBuilder

`HGRenderGraphBuilder` 是一个 `struct`，实现 `IDisposable`。它是 Fluent API 的入口，用于配置 Pass。

### 5.1 字段

```csharp
public struct HGRenderGraphBuilder : IDisposable
{
    private HGRenderGraphPass m_RenderPass;
    private HGRenderGraphResourceRegistry m_Resources;
    private HGRenderGraph m_RenderGraph;
    private bool m_Disposed;
}
```

### 5.2 方法（Fluent API）

#### 颜色附件
```csharp
public TextureHandle SetColorAttachment(in TextureHandle input, int index, uint depthSlice = 0u);
public TextureHandle SetColorAttachment(in TextureHandle input, int index, Color clearColor, uint depthSlice = 0u);
public TextureHandle SetColorAttachment(in TextureHandle input, int index, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Color clearColor, uint depthSlice = 0u);
```

#### 深度附件
```csharp
public TextureHandle SetDepthAttachment(in TextureHandle input, DepthAccess flags, uint depthSlice = 0u);
public TextureHandle SetDepthAttachment(in TextureHandle input, DepthAccess flags, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, float clearDepth, byte clearStencil, uint depthSlice = 0u);
```

#### 纹理读写
```csharp
public TextureHandle ReadTexture(in TextureHandle input);
public TextureHandle WriteTexture(in TextureHandle input);
public TextureHandle ReadWriteTexture(in TextureHandle input);
public TextureHandle CreateTransientTexture(ref TextureDesc desc);
public TextureHandle CreateTransientTexture(ref TextureHandle texture);
```

#### ComputeBuffer 读写
```csharp
public ComputeBufferHandle ReadComputeBuffer(in ComputeBufferHandle input);
public ComputeBufferHandle WriteComputeBuffer(in ComputeBufferHandle input);
public ComputeBufferHandle CreateTransientComputeBuffer(in ComputeBufferDesc desc);
public ComputeBufferHandle CreateTransientComputeBuffer(in ComputeBufferHandle computebuffer);
```

#### RendererList
```csharp
public RendererListHandle UseRendererList(in RendererListHandle input);
public RendererListHandle DependsOn(in RendererListHandle input);
```

#### RenderFunc 设置
```csharp
public void SetRenderFunc<PassData>(RenderFunc<PassData> renderFunc, object camera = null, int funcIndex = 0) where PassData : class, new();
public unsafe void SetRenderFunc<PassData>(RenderFunc<PassData> renderFunc, object camera, void* customPayload, int funcIndex = 0) where PassData : class, new();
public void SetPreRenderPassFunc<PassData>(RenderFunc<PassData> renderFunc) where PassData : class, new();
public void SetPostRenderPassFunc<PassData>(RenderFunc<PassData> renderFunc) where PassData : class, new();
```

#### Subpass 配置
```csharp
public void SetupSubpass<PassData>(int subpassIndex, NativeArray<int> colorRTIndices, RenderFunc<PassData> renderFunc, ProfilingHGPass profilingHgPass) where PassData : class, new();
public unsafe void SetupSubpass<PassData>(int subpassIndex, NativeArray<int> colorRTIndices, RenderFunc<PassData> renderFunc, ProfilingHGPass profilingHgPass, object camera, void* customPayload) where PassData : class, new();
public void SetupSubpass<PassData>(int subpassIndex, NativeArray<int> colorRTIndices, NativeArray<int> inputRTIndices, bool depthAsInput, RenderFunc<PassData> renderFunc, ProfilingHGPass profilingHgPass, object camera = null) where PassData : class, new();
public unsafe void SetupSubpass<PassData>(int subpassIndex, NativeArray<int> colorRTIndices, NativeArray<int> inputRTIndices, bool depthAsInput, RenderFunc<PassData> renderFunc, ProfilingHGPass profilingHgPass, object camera, void* customPayload) where PassData : class, new();
```

#### RenderFunc（精细控制）
```csharp
public void SetupRenderFunc<PassData>(int funcIndex, RenderFunc<PassData> renderFunc) where PassData : class, new();
public unsafe void SetupRenderFunc<PassData>(int funcIndex, RenderFunc<PassData> renderFunc, object camera, void* customPayload) where PassData : class, new();
public void SetupRenderFunc<PassData>(int subpassIndex, int funcIndex, RenderFunc<PassData> renderFunc) where PassData : class, new();
public unsafe void SetupRenderFunc<PassData>(int subpassIndex, int funcIndex, RenderFunc<PassData> renderFunc, object camera, void* customPayload) where PassData : class, new();
```

#### 其他
```csharp
public void AddChildPass(HGRenderGraphBuilder builder);
public void EnableAsyncCompute(bool value);
public void AllowPassCulling(bool value);
public void AllowRendererListCulling(bool value);
public bool DepthRequiredIfMRT();
public void Dispose();  // 在 using 块结束时自动提交 Pass
```

### 5.3 Builder 使用模式

```csharp
using (var builder = renderGraph.AddRenderPass<MyPassData>("MyPass", out var data, sampler))
{
    builder.SetColorAttachment(input, 0);
    builder.SetDepthAttachment(depth, DepthAccess.ReadWrite);
    builder.ReadTexture(input2);
    builder.WriteTexture(output);
    builder.SetRenderFunc((data, ctx) => { /* 渲染代码 */ });
    // Dispose() 自动调用，将 Pass 提交到 Graph
}
```

---

## 6. 资源系统

### 6.1 ResourceHandle 统一抽象

```csharp
internal struct ResourceHandle
{
    private const uint kValidityMask  = 0xFFFF0000u;  // 高16位：有效性位
    private const uint kIndexMask     = 0x0000FFFFu;  // 低16位：资源索引
    
    private uint m_Value;                              // 编码值（validity bit << 16 | index）
    private static uint s_CurrentValidBit;             // 当前有效性位（递增）
    private static uint s_PreservedResourceValidBit;   // Preserved 资源专用有效性位

    public int index => (int)(m_Value & kIndexMask);
    public HGRenderGraphResourceType type { get; private set; }
    public int iType => (int)type;

    internal ResourceHandle(int value, HGRenderGraphResourceType type, bool preserved);
    public static implicit operator int(ResourceHandle handle);
    public readonly bool IsValid();
    public readonly bool IsPreserved();
}
```

**设计要点**:
- `m_Value` 编码了有效性位（高16位）和资源索引（低16位）
- `IsValid()` 检查高16位是否匹配 `s_CurrentValidBit` 或 `s_PreservedResourceValidBit`
- `IsPreserved()` 检查高16位是否匹配 `s_PreservedResourceValidBit`
- 隐式转换为 `int` 返回资源索引

### 6.2 HGRenderGraphResourceType 枚举

```csharp
internal enum HGRenderGraphResourceType
{
    Texture = 0,
    ComputeBuffer = 1,
    Count = 2
}
```

### 6.3 IHGRenderGraphResource

```csharp
internal class IHGRenderGraphResource
{
    public bool imported;
    public bool preserved;
    public bool requestFallBack;
    public uint writeCount;
    public int cachedHash;
    public int transientPassIndex;   // -1 表示非临时资源
    public int preservedExecutorID;
    public int preservedExecutorFrameIndex;
    public int preservedResourceLifeSpan;
    protected IHGRenderGraphResourcePool m_Pool;

    public virtual void Reset(IHGRenderGraphResourcePool pool);
    public virtual string GetName();
    public virtual bool IsCreated();
    public virtual void IncrementWriteCount();
    public virtual bool NeedsFallBack();
}
```

### 6.4 HGRenderGraphResource<DescType, ResType> 泛型基类

```csharp
[DebuggerDisplay("Resource ({GetType().Name}:{GetName()})")]
internal abstract class HGRenderGraphResource<DescType, ResType> : IHGRenderGraphResource
    where DescType : struct
    where ResType : class
{
    public DescType desc;
    public ResType graphicsResource;

    public override void Reset(IHGRenderGraphResourcePool pool);
    public override bool IsCreated();
    public override void ReleaseGraphicsResource();
    public void CopyFrom(HGRenderGraphResource<DescType, ResType> other);
}
```

### 6.5 TextureHandle

```csharp
[DebuggerDisplay("Texture ({handle.index})")]
public struct TextureHandle
{
    private static TextureHandle s_NullHandle;
    internal ResourceHandle handle;
    internal ResourceHandle fallBackResource;  // 回退纹理的 handle

    public static TextureHandle nullHandle => default;
    internal TextureHandle(int handle, bool shared = false);

    // 隐式转换
    public static implicit operator RenderTargetIdentifier(TextureHandle texture);
    public static implicit operator Texture(TextureHandle texture);
}
```

**关键设计**: `fallBackResource` 字段用于在读取未写入的纹理时提供默认黑纹理回退。

### 6.6 TextureResource

```csharp
[DebuggerDisplay("TextureResource ({desc.name})")]
internal class TextureResource : HGRenderGraphResource<TextureDesc, RTHandle>
{
    private static int m_TextureCreationIndex;
    public bool needsClear { get; set; }

    public override string GetName();
    public void CopyFrom(TextureResource other);
    public override void CreatePooledGraphicsResource(bool frameRegister = true, string name = "");
    public override void ReleasePooledGraphicsResource(int frameIndex, bool reset = true);
}
```

### 6.7 TexturePool

```csharp
internal class TexturePool : HGRenderGraphResourcePool<RTHandle>
{
    protected override void ReleaseInternalResource(RTHandle res);  // RTHandle.Release()
    protected override string GetResourceName(RTHandle res);
    protected override long GetResourceSize(RTHandle res);
    protected override string GetResourceTypeName();  // "Texture"
    protected override int GetSortIndex(RTHandle res);  // RTHandle.GetInstanceID()
}
```

### 6.8 ComputeBufferHandle

```csharp
[DebuggerDisplay("ComputeBuffer ({handle.index})")]
public struct ComputeBufferHandle
{
    private static ComputeBufferHandle s_NullHandle;
    internal ResourceHandle handle;

    public static ComputeBufferHandle nullHandle => default;
    internal ComputeBufferHandle(int handle, bool shared = false);
    public static implicit operator ComputeBuffer(ComputeBufferHandle buffer);
    public bool IsValid();
}
```

### 6.9 ComputeBufferResource

```csharp
[DebuggerDisplay("ComputeBufferResource ({desc.name})")]
internal class ComputeBufferResource : HGRenderGraphResource<ComputeBufferDesc, ComputeBuffer>
{
    public override string GetName();
    public override void CreatePooledGraphicsResource(bool frameRegister = true, string name = "");
    public override void ReleasePooledGraphicsResource(int frameIndex, bool reset = true);
}
```

### 6.10 ComputeBufferPool

```csharp
internal class ComputeBufferPool : HGRenderGraphResourcePool<ComputeBuffer>
{
    protected override void ReleaseInternalResource(ComputeBuffer res);  // ComputeBuffer.Dispose()
    protected override string GetResourceName(ComputeBuffer res);       // "ComputeBufferNameNotAvailable"
    protected override long GetResourceSize(ComputeBuffer res);         // count * stride
    protected override string GetResourceTypeName();                    // "ComputeBuffer"
    protected override int GetSortIndex(ComputeBuffer res);
}
```

### 6.11 RendererListHandle

```csharp
[DebuggerDisplay("RendererList ({handle})")]
public struct RendererListHandle
{
    private bool m_IsValid;
    internal int handle { get; private set; }

    public static RendererListHandle InvalidHandle => default;
    internal RendererListHandle(int handle);
    public static implicit operator int(RendererListHandle handle);
    public static implicit operator RendererList(RendererListHandle rendererList);
    public readonly bool IsValid();
}
```

### 6.12 RendererListResource

```csharp
internal struct RendererListResource
{
    public RendererListDesc desc;
    public RendererList rendererList;
    internal RendererListResource(in RendererListDesc desc);
}
```

---

## 7. HGRenderGraphExecution 执行

```csharp
public struct HGRenderGraphExecution : IDisposable
{
    private HGRenderGraph renderGraph;

    internal HGRenderGraphExecution(HGRenderGraph renderGraph);
    public void Dispose();  // 触发 HGRenderGraph.Execute()
}
```

**执行流程**：`RecordAndExecute()` 返回 `HGRenderGraphExecution`，当 `Dispose()` 被调用时（通常在 `using` 块结束时），触发完整的编译和执行流水线。

---

## 8. HGRenderGraphResourceRegistry

### 8.1 枚举 BackBufferType

```csharp
internal enum BackBufferType
{
    Color = 0,
    Depth = 1,
    Count = 2
}
```

### 8.2 内部类 HGRenderGraphResourcesData

```csharp
private class HGRenderGraphResourcesData
{
    public DynamicArray<IHGRenderGraphResource> resourceArray;
    public IHGRenderGraphResourcePool pool;
    public ResourceCallback createResourceCallback;
    public ResourceCallback releaseResourceCallback;

    public void Clear(bool onException, int frameIndex);
    public void Cleanup();
    public void PurgeUnusedGraphicsResources(int frameIndex);
    public int AddNewRenderGraphResource<ResType>(out ResType outRes, bool pooledResource = true) where ResType : IHGRenderGraphResource, new();
}
```

### 8.3 字段

```csharp
internal class HGRenderGraphResourceRegistry
{
    private const int MAXIMUM_PRESERVED_RESOURCE_COUNT = 64;
    private static HGRenderGraphResourceRegistry m_CurrentRegistry;

    private HGRenderGraphResourcesData[] m_RenderGraphResources;  // [ResourceType.Count]
    private DynamicArray<RendererListResource> m_RendererListResources;
    private HGRenderGraphDebugParams m_RenderGraphDebug;
    private HGRenderGraphLogger m_FrameInformationLogger;
    private int m_CurrentFrameIndex;
    private int m_ExecutionCount;
    private int m_currentExecutorID;
    private int m_currentExecutorFrameIndex;
    private RTHandle[] m_CurrentBackbuffer;  // [BackBufferType.Count]
    private const int kInitialRendererListCount = 256;
    private List<RendererList> m_ActiveRendererLists;
}
```

### 8.4 方法

```csharp
// 单例
internal static HGRenderGraphResourceRegistry current { get; set; }
internal HGRenderGraphResourceRegistry(HGRenderGraphDebugParams renderGraphDebug, HGRenderGraphLogger frameInformationLogger);

// 纹理
internal RTHandle GetTexture(in TextureHandle handle);
internal bool TextureNeedsFallback(in TextureHandle handle);
internal TextureResource GetTextureResource(in TextureHandle handle);
internal TextureDesc GetTextureResourceDesc(in TextureHandle handle);
internal void ForceTextureClear(in TextureHandle handle, Color clearColor);

// ComputeBuffer
internal ComputeBuffer GetComputeBuffer(in ComputeBufferHandle handle);
internal ComputeBufferResource GetComputeBufferResource(in ComputeBufferHandle handle);

// RendererList
internal RendererList GetRendererList(in RendererListHandle handle);

// 资源管理
internal int CreateResource<ResType>(in ResourceHandle resourceHandle, HGRenderGraphResourceType resourceType, bool frameRegister = true, string resourceName = "");
internal void ReleaseResource(in ResourceHandle resourceHandle, HGRenderGraphResourceType resourceType, int frameIndex);
internal void IncrementWriteCount(in ResourceHandle handle);
internal bool IsRenderGraphResourceImported(in ResourceHandle handle);
internal void Clear(bool onException);
internal void Cleanup();
internal void PurgeUnusedResources(int frameIndex);
internal void LogResources();
}
```

---

## 9. 对象池 HGRenderGraphObjectPool

```csharp
public sealed class HGRenderGraphObjectPool
{
    // 内部类：泛型对象池（单例模式）
    private class SharedObjectPool<T> where T : new()
    {
        private Stack<T> m_Pool;
        private static readonly Lazy<SharedObjectPool<T>> s_Instance;
        public static SharedObjectPool<T> sharedPool => null;
        public T Get();
        public void Release(T value);
    }

    // 实例字段
    private Dictionary<(Type, int), Stack<object>> m_ArrayPool;      // 数组池
    private List<(object, (Type, int))> m_AllocatedArrays;           // 已分配的数组追踪
    private List<MaterialPropertyBlock> m_AllocatedMaterialPropertyBlocks;

    // 方法
    internal HGRenderGraphObjectPool();
    public T[] GetTempArray<T>(int size);
    public MaterialPropertyBlock GetTempMaterialPropertyBlock();
}
```

**用途**:
- 复用 `PassData` 实例（通过 `SharedObjectPool<PassData>`）
- 复用临时数组（通过 `m_ArrayPool`）
- 复用 `MaterialPropertyBlock`
- 减少 GC 压力

---

## 10. IHGRenderGraphResourcePool

```csharp
internal abstract class IHGRenderGraphResourcePool
{
    public abstract void PurgeUnusedResources(int currentFrameIndex);
    public abstract void Cleanup();
    public abstract void CheckFrameAllocation(bool onException, int frameIndex);
    public abstract void LogResources(HGRenderGraphLogger logger);
}
```

---

## 11. HGRenderGraphResourcePool<Type> 基类

```csharp
internal abstract class HGRenderGraphResourcePool<Type> : IHGRenderGraphResourcePool where Type : class
{
    private struct ResourceLogInfo
    {
        public string name;
        public long size;
    }

    protected Dictionary<int, SortedList<int, (Type resource, int frameIndex)>> m_ResourcePool;
    protected List<int> m_RemoveList;
    private List<(int, Type)> m_FrameAllocatedResources;
    protected static int s_CurrentFrameIndex;
    private const int kStaleResourceLifetime = 10;  // 闲置10帧后释放

    protected abstract void ReleaseInternalResource(Type res);
    protected abstract string GetResourceName(Type res);
    protected abstract long GetResourceSize(Type res);
    protected abstract string GetResourceTypeName();
    protected abstract int GetSortIndex(Type res);

    public void ReleaseResource(int hash, Type resource, int currentFrameIndex);
    public bool TryGetResource(int hashCode, out Type resource);
    public void RegisterFrameAllocation(int hashCode, Type resource);
    public void UnregisterFrameAllocation(int hashCode, Type resource);
}
```

**池化策略**:
- 使用 `Dictionary<int, SortedList<int, (Type, int)>>`：Key=描述符Hash，Value=按 sortIndex 排序的资源列表
- 资源释放时并不立即销毁，而是放入池中
- `kStaleResourceLifetime = 10`：闲置10帧后清理
- `TryGetResource` 从池中查找可复用的资源

---

## 12. 上下文和相关类

### 12.1 HGRenderGraphContext

```csharp
public class HGRenderGraphContext
{
    public ScriptableRenderContext renderContext;
    public CommandBuffer cmd;
    public HGRenderGraphObjectPool renderGraphPool;
    public HGRenderGraphDefaultResources defaultResources;
}
```

### 12.2 HGRenderGraphParameters

```csharp
public struct HGRenderGraphParameters
{
    public string executionName;
    public int currentFrameIndex;
    public bool rendererListCulling;
    public ScriptableRenderContext scriptableRenderContext;
    public CommandBuffer commandBuffer;
    public int executorID;
    public int executorFrameIndex;
}
```

### 12.3 HGRenderGraphProfilingScope

```csharp
public struct HGRenderGraphProfilingScope : IDisposable
{
    private bool m_Disposed;
    private ProfilingSampler m_Sampler;
    private HGRenderGraph m_RenderGraph;

    public HGRenderGraphProfilingScope(HGRenderGraph renderGraph, ProfilingSampler sampler);
    public void Dispose();
    private void Dispose(bool disposing);
}
```

### 12.4 HGRenderGraphLogIndent

```csharp
internal struct HGRenderGraphLogIndent : IDisposable
{
    private int m_Indentation;
    private HGRenderGraphLogger m_Logger;
    private bool m_Disposed;

    public HGRenderGraphLogIndent(HGRenderGraphLogger logger, int indentation = 1);
    public void Dispose();
    private void Dispose(bool disposing);
}
```

### 12.5 RenderFunc

```csharp
public delegate void RenderFunc<PassData>(PassData data, HGRenderGraphContext renderGraphContext) where PassData : class, new();
```

### 12.6 IRenderGraphCallbackOwner

```csharp
internal interface IRenderGraphCallbackOwner
{
    internal unsafe void OnRenderPassExecution(HGRenderGraph renderGraph, DynamicArray<AttachDesc> colorAttachments, object camera, void* customPayload, bool renderPassIssued);
}
```

---

## 13. 数据结构定义

### 13.1 TextureDesc

```csharp
public struct TextureDesc
{
    public int width;
    public int height;
    public int slices;
    public DepthBits depthBufferBits;
    public GraphicsFormat colorFormat;
    public FilterMode filterMode;
    public TextureWrapMode wrapMode;
    public TextureDimension dimension;
    public bool enableRandomWrite;
    public bool useMipMap;
    public bool autoGenerateMips;
    public bool isShadowMap;
    public int anisoLevel;
    public float mipMapBias;
    public MSAASamples msaaSamples;
    public bool bindTextureMS;
    public RenderTextureMemoryless memoryless;
    public string name;
    public FastMemoryDesc fastMemoryDesc;
    public bool fallBackToBlackTexture;
    public bool clearBuffer;
    public Color clearColor;

    public TextureDesc(int width, int height);
    public TextureDesc(Vector2Int size);
    public TextureDesc(TextureDesc input);
    public override int GetHashCode();
    private void InitDefaultValues();  // slices=1, dimension=2D
}
```

### 13.2 ComputeBufferDesc

```csharp
public struct ComputeBufferDesc
{
    public int count;
    public int stride;
    public ComputeBufferType type;
    public string name;

    public ComputeBufferDesc(int count, int stride);
    public ComputeBufferDesc(int count, int stride, ComputeBufferType type);
    public override int GetHashCode();
}
```

### 13.3 AttachDesc

```csharp
public struct AttachDesc
{
    public static readonly int INVALID_ATTACHMENT;
    public TextureHandle textureHandle;
    public RenderBufferLoadAction loadAction;
    public RenderBufferStoreAction storeAction;
    public Color clearColor;
    public uint depthSlice;
    public float clearDepth;
    public uint clearStencil;
    public bool manuallyOverride;

    public void Reset();
}
```

### 13.4 FastMemoryDesc

```csharp
public struct FastMemoryDesc
{
    public bool inFastMemory;
    public FastMemoryFlags flags;
    public float residencyFraction;
}
```

### 13.5 DepthAccess

```csharp
[Flags]
public enum DepthAccess
{
    Read = 1,
    Write = 2,
    ReadWrite = 3
}
```

### 13.6 TextureSizeMode

```csharp
public enum TextureSizeMode
{
    Explicit = 0,
    Scale = 1,
    Functor = 2
}
```

### 13.7 HGRenderGraphProfileId

```csharp
internal enum HGRenderGraphProfileId
{
    CompileRenderGraph = 0,
    ExecuteRenderGraph = 1,
    RenderGraphClear = 2,
    RenderGraphClearDebug = 3
}
```

---

## 14. 关键设计决策

### 为什么自己做 RenderGraph 而不是用 Unity 内置的？

1. **Native RenderPass 深度集成**: Unity 内置 RenderGraph 对 Native RenderPass（Subpass）的支持有限。HG 的 `HGRenderGraphPassNative` 将 `BeginRenderPass`/`BeginSubPass` 作为一等公民支持，这是针对移动端 Tile-Based Deferred Rendering 的优化。

2. **IFix 热修复支持**: 所有关键 API 使用 `[IDTag]` 标记支持 IFix 运行时热修复。这是自研项目的核心需求，Unity 内置 API 无法提供此能力。

3. **ProfilingHGPass 粒度的 Profiling**: 提供 `ProfilingHGPass` 枚举（None/Basic/Detailed 等），可以在 Pass 级别控制 Profiling 粒度，远细于 Unity 的内置方案。

4. **资源回退机制**: `TextureHandle.fallBackResource` 和 `IHGRenderGraphResource.requestFallBack` 提供了透明纹理回退机制。当 Pass 尝试读取一个尚未被写入的纹理时，自动返回黑/白纹理，避免空指针。

5. **统一对象池**: `HGRenderGraphObjectPool` 不仅池化 GPU 资源，还池化 `PassData`、数组和 `MaterialPropertyBlock`，减少托管内存分配。

6. **BackBuffer 管理**: 直接支持 `ImportBackbuffer`，将屏幕缓冲（color/depth）作为 TextureHandle 导入图系统中。

7. **Preserved 资源**: `PreserveTexture` 机制允许跨帧保留纹理，Unity 内置方案不支持。

8. **ChildPass**: 支持 Pass 嵌套（child passes），适用于需要在一个 RenderPass 内执行多个子操作的场景。

---

## 15. 1:1 复刻实现要点

### 核心架构
1. **Render Graph = Pass DAG + 资源生命周期管理**
2. Pass 注册阶段（Record）：声明输入/输出/临时资源
3. 编译阶段（Compile）：构建 DAG、Culling、排序
4. 执行阶段（Execute）：按序创建资源 -> 执行 Pass -> 释放资源

### 必须实现的接口
- `RenderFunc<PassData>`: 实际渲染代码的委托
- `IRenderGraphCallbackOwner`: RenderPass 回调接口

### 资源管理
- `ResourceHandle` 使用 `uint` 编码（高16位有效位 + 低16位索引）
- `HGRenderGraphResourceRegistry` 持有 `HGRenderGraphResourcesData[2]`（Texture 和 ComputeBuffer）
- 每个 `HGRenderGraphResourcesData` 持有 `DynamicArray<IHGRenderGraphResource>`（资源数组）和 `IHGRenderGraphResourcePool`（资源池）

### Pass 执行
- Regular Pass: 直接调用 `cmd` API
- Native Pass: 使用 `ScriptableRenderContext.BeginRenderPass`/`BeginSubPass/EndSubPass/EndRenderPass`
- Subpass: 最多4个 RenderFunc（`funcIndex 0-3`），在 Native Pass 的 Subpass 内执行

### DAG 编译器
- 输入: Pass 列表 + 每个 Pass 的 `resourceReadLists`/`resourceWriteLists`
- 输出: `CompiledPassInfo[]`（排序后）、`CompiledResourceInfo[type][]`
- 核心算法: refCount 计数 -> Pass Culling -> 资源生命周期计算 -> 排序

### 对象池化
- `HGRenderGraphObjectPool` 维护数组池和 MaterialPropertyBlock 池
- `HGRenderGraphResourcePool<Type>` 维护 GPU 资源池
- `SharedObjectPool<T>` 维护 PassData 实例池

### Debug 系统
- `HGRenderGraphDebugParams`: DebugUI 开关面板
- `HGRenderGraphLogger`: 缩进日志系统
- `HGRenderGraphDebugData`: 帧调试数据（Pass 列表、资源列表）
- `HGRenderGraphProfileId`: Profiling 标记枚举
- `HGRenderGraphProfilingScope`: Profiling 作用域

### 错误处理
- IFix 热修复安全检查：每个方法检查 `IsPatched`，失败时跳转到 `GetPatch` 包装器
- `m_ExecutionExceptionWasRaised`: 执行异常标志
- `sub_180BAB70C`: 失败回调（IL2CPP 空检查异常）

---

## 附录: 完整命名空间

```csharp
namespace HG.Rendering.RenderGraphModule
{
    // 公共类型
    public delegate void RenderFunc<PassData>(PassData data, HGRenderGraphContext renderGraphContext) where PassData : class, new();
    public enum HGRenderGraphPassType { HGRGP_Regular = 0, HGRGP_Native = 1, HGRGP_Count = 2 }
    public enum TextureSizeMode { Explicit = 0, Scale = 1, Functor = 2 }
    [Flags] public enum DepthAccess { Read = 1, Write = 2, ReadWrite = 3 }
    
    // 公共类
    public class HGRenderGraph { ... }
    public class HGRenderGraphContext { ... }
    public class HGRenderGraphDefaultResources { ... }
    public sealed class HGRenderGraphObjectPool { ... }
    
    // 公共结构体
    public struct HGRenderGraphBuilder : IDisposable { ... }
    public struct HGRenderGraphExecution : IDisposable { ... }
    public struct HGRenderGraphParameters { ... }
    public struct HGRenderGraphProfilingScope : IDisposable { ... }
    public struct TextureHandle { ... }
    public struct ComputeBufferHandle { ... }
    public struct RendererListHandle { ... }
    public struct TextureDesc { ... }
    public struct ComputeBufferDesc { ... }
    public struct AttachDesc { ... }
    public struct FastMemoryDesc { ... }
    
    // 内部类型
    internal enum HGRenderGraphResourceType { Texture = 0, ComputeBuffer = 1, Count = 2 }
    internal enum HGRenderGraphProfileId { ... }
    internal class HGRenderGraphPass { ... }
    internal abstract class HGRenderGraphPass<PassData> : HGRenderGraphPass { ... }
    internal sealed class HGRenderGraphPassRegular<PassData> : HGRenderGraphPass<PassData> { ... }
    internal sealed class HGRenderGraphPassNative<PassData> : HGRenderGraphPass<PassData> { ... }
    internal class HGRenderGraphResourceRegistry { ... }
    internal abstract class HGRenderGraphResource<DescType, ResType> : IHGRenderGraphResource { ... }
    internal abstract class HGRenderGraphResourcePool<Type> : IHGRenderGraphResourcePool { ... }
    internal class TextureResource : HGRenderGraphResource<TextureDesc, RTHandle> { ... }
    internal class TexturePool : HGRenderGraphResourcePool<RTHandle> { ... }
    internal class ComputeBufferResource : HGRenderGraphResource<ComputeBufferDesc, ComputeBuffer> { ... }
    internal class ComputeBufferPool : HGRenderGraphResourcePool<ComputeBuffer> { ... }
    internal struct RendererListResource { ... }
    internal struct ResourceHandle { ... }
    internal class IHGRenderGraphResource { ... }
    internal abstract class IHGRenderGraphResourcePool { ... }
    internal interface IRenderGraphCallbackOwner { ... }
    internal struct HGRenderGraphLogIndent : IDisposable { ... }
    internal class HGRenderGraphLogger { ... }
    internal class HGRenderGraphDebugParams { ... }
    internal class HGRenderGraphDebugData { ... }
}
```
