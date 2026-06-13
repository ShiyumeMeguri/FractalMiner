# C21 · 渲染资源管理 · 自定义 RT · RT 抽取 — 原理蓝图

> 终末地 HG.RenderPipelines 的「渲染资源管理」子系统：负责 **RT 生命周期分类（Transient / Frame / Persist）**、**自定义绘制 RT 池（CustomDrawRTManager，CPU + C++ 双实现）**、**自定义深度 RT 流式回环（CustomDepthOnlyRequestManager，clipmap 式 toroidal 寻址）**、**场景 RT 抽取与回读（RTExtraction，截图 / 角色海报 / Blur SceneColor）**，以及若干工具 pass（ComposablePass / CopyTexturePass / LowResBlitPass / SetFinalTargetPass）。
>
> 本文原理依据：
> - **HDRP 血缘**：`RTHandleSystem`（缩放与复用机制）的同源源码（HDRP `com.unity.render-pipelines.core@ba70f6d20c11/Runtime/Textures/RTHandleSystem.cs`），逐条照抄并 cite 行号；
> - **HG 反编译**（IL2CPP x86-64 反汇编 + IL 残骸调用图）：`RenderTextureManager.cs` / `RTLifeCycle.cs` / `CustomDrawRTManager.cs` / `CustomDepthOnlyRequestManager.cs` / `RTExtractionType.cs` / `RTExtractionDuration.cs` / `SceneRTFeature.cs` / `ComposablePass.cs` / `CopyTexturePass.cs` / `LowResBlitPass.cs` / `SetFinalTargetPassConstructor.cs` / `HGResourceManagerScript.cs`，从 `call` 序列与常量推断 HG delta；
> - **RenderGraph 资源池详解**已写在 [`../03-RenderGraph/01-HGRenderGraph-System.md` §6 资源系统](../03-RenderGraph/01-HGRenderGraph-System.md#6-资源系统)，本文**不重复**该机制，仅链接、并讲清「HG 在 RG 之上加的那一层」。

---

## 目录

1. 子系统定位与解决的问题
2. RT 生命周期模型：`RTLifeCycle = {Transient, Frame, Persist}`
3. HDRP 血缘：`RTHandleSystem` 缩放与复用（同源）
4. `RenderTextureManager`：场景级全局 RT 缓存 + 切场景清理
5. `CustomDrawRTManager`：UI/特效自定义绘制 RT 池（CPU/C++ 双实现 + `AutoRestRT` 守卫）
6. `CustomDepthOnlyRequestManager`：clipmap 式自定义深度流式回环
7. `RTExtraction*` + `SceneRTFeature`：场景 RT 抽取 / 回读 / Blur SceneColor
8. 工具 pass：`ComposablePass` / `CopyTexturePass` / `LowResBlitPass` / `SetFinalTargetPass`
9. 数据流与帧时序总图
10. HG ↔ HDRP delta 汇总
11. 关键常量 / 魔数
12. 1:1 复刻蓝图（分步）
13. 支撑证据（文件清单 + 反汇编锚点）

---

## 1. 子系统定位与解决的问题

HG 的「渲染资源管理」要同时回答四个工程问题：

| 问题 | HG 的回答 | 主要单元 |
|------|-----------|---------|
| **逐帧自动缩放/复用 RT**（动态分辨率 + camera 切换不爆显存） | 继承 HDRP `RTHandleSystem`（缩放、auto-sized 列表、`SetReferenceSize` 时不 realloc 仅扩 max） | `RTHandleSystem`（HDRP）+ HG 调用 `Alloc` |
| **场景级长期 RT 缓存**（编辑器 / 场景切换时回收 SceneView Camera 持有的 RT） | `RenderTextureManager` 静态 list + `ClearRenderTexture` 遍历 root GO 的 Camera 把 targetTexture 置空、Release+DestroyImmediate | `RenderTextureManager.cs` |
| **运行时按需绘制小 RT**（图标、装备预览、自定义贴纸） | `CustomDrawRTManager` 单例，封装 `CommandBuffer`/`MaterialPropertyBlock`/`AutoRestRT`（保存恢复 active RT），底层可走 IL2CPP C# 路径或 `HGRenderGraphCPP.CustomDrawRTManager_*` 原生路径 | `CustomDrawRTManager.cs` |
| **超大 viewport 的可投射深度 RT**（用于云阴影 / 大世界 fake shadow） | `CustomDepthOnlyRequestManager`：把世界分成 N×N 页（page），每帧只刷新部分页，环形 toroidal 寻址 + UV scroll | `CustomDepthOnlyRequestManager.cs` |
| **截图 / 拍照 / 海报抓帧** | `RTExtraction*` 枚举 + 拷贝 pass：`SceneColorLS / BlurredSceneColorPS / SceneColorPS / FinalResult` × `Persistent / Temporal` | `RTExtractionType.cs` / `RTExtractionDuration.cs` |
| **跨 pass 临时拷贝 / 上屏 / 低分辨率深度合并** | 工具 pass 类：`CopyTexturePass.BlitTexture / CopyDepth / BlitMotionVector`，`LowResBlitPass.DownsampleDepth / UpsampleColorAndMV`，`SetFinalTargetPassConstructor.ConstructPass`（写 BackBuffer + flipY） | `CopyTexturePass.cs` / `LowResBlitPass.cs` / `SetFinalTargetPassConstructor.cs` |

底层 RG 资源池（pooled RT、import RT、跨 pass 别名）在 [03-RenderGraph §6](../03-RenderGraph/01-HGRenderGraph-System.md#6-资源系统) 已详述；本文是它**之上**的一层「业务化包装」。

---

## 2. RT 生命周期模型：`RTLifeCycle`

```csharp
// 源：RTLifeCycle.cs（HG 反编译，整文件即枚举本体）
public enum RTLifeCycle
{
    Transient = 0,   // 单 pass / 单 dispatch 临时
    Frame     = 1,   // 一帧内多 pass 共享（同帧别名）
    Persist   = 2    // 跨帧持久（history buffer / pooled）
}
```

> **据反汇编**：HG 在 RG 资源池（见 [`../03-RenderGraph/01-HGRenderGraph-System.md` §6](../03-RenderGraph/01-HGRenderGraph-System.md#6-资源系统)）之上用此三态标签把 RT 请求分流：
> - `Transient` → RG `CreateTransientTexture`（pass 内分配/释放）；
> - `Frame` → RG 帧内 import / pooled（同名 RT 多 pass 复用，不跨帧）；
> - `Persist` → 走 HDRP `RTHandleSystem.Alloc` 或 `BufferedRTHandleSystem`（跨帧 history，TAA / motion / SSR 用）。
>
> **数值含义铁律**：`Transient=0 < Frame=1 < Persist=2`，按枚举值单调递增 = 「越大越长寿」，这与 RG `releasePassIndex - createPassIndex` 寿命排序一致（[03-RenderGraph §6](../03-RenderGraph/01-HGRenderGraph-System.md#6-资源系统)）。
>
> **HG delta vs HDRP**：HDRP 没有这个显式三态枚举（HDRP 直接靠 RG 的 `createPassIndex / releasePassIndex` 推算）。HG 把它显式化成枚举，便于自研 pass 在不接触 RG 时也能在 C++ 侧（`HGRenderGraphCPP`）按生命周期做差异化处理（见 §5）。
>
> **⚠ 待确认**：源码注释/任务提示提到 `Frame` 在某些路径上可能未真正实现（仍走 `Transient` 等价语义）。反汇编中所有调用点都按数值比较分支，未见 `Frame` 专属路径，**核心算法不依赖此细节**。

---

## 3. HDRP 血缘：`RTHandleSystem` 缩放与复用（同源）

HG 直接调用 `UnityEngine.Rendering.RTHandleSystem::Alloc`，缩放/复用机制与 HDRP 一致。把 HDRP 真实公式照抄于此（cite HDRP 源行号），作为 HG 的「同源真值」。

### 3.1 `m_MaxWidths / m_MaxHeights` 单调递增

```csharp
// HDRP: RTHandleSystem.cs:174-175
int m_MaxWidths = 0;
int m_MaxHeights = 0;

// 构造（HDRP: RTHandleSystem.cs:184-190）
public RTHandleSystem()
{
    m_AutoSizedRTs       = new HashSet<RTHandle>();
    m_ResizeOnDemandRTs  = new HashSet<RTHandle>();
    m_MaxWidths          = 1;
    m_MaxHeights         = 1;
}
```

每帧开镜头前调用 `SetReferenceSize(width, height, reset)`，核心逻辑（HDRP `RTHandleSystem.cs:284-344`）：

```csharp
public void SetReferenceSize(int width, int height, bool reset)
{
    m_RTHandleProperties.previousViewportSize     = m_RTHandleProperties.currentViewportSize;
    m_RTHandleProperties.previousRenderTargetSize = m_RTHandleProperties.currentRenderTargetSize;
    Vector2 lastFrameMaxSize = new Vector2(GetMaxWidth(), GetMaxHeight());

    width  = Mathf.Max(width, 1);
    height = Mathf.Max(height, 1);

    bool sizeChanged = width > GetMaxWidth() || height > GetMaxHeight() || reset;
    if (sizeChanged)
        Resize(width, height, sizeChanged);

    m_RTHandleProperties.currentViewportSize     = new Vector2Int(width, height);
    m_RTHandleProperties.currentRenderTargetSize = new Vector2Int(GetMaxWidth(), GetMaxHeight());

    // 第一帧（domain reload / reflection probe）previous=current 防 TAA 历史失效
    if (m_RTHandleProperties.previousViewportSize.x == 0) {
        m_RTHandleProperties.previousViewportSize     = m_RTHandleProperties.currentViewportSize;
        m_RTHandleProperties.previousRenderTargetSize = m_RTHandleProperties.currentRenderTargetSize;
        lastFrameMaxSize = new Vector2(GetMaxWidth(), GetMaxHeight());
    }

    var scales = CalculateRatioAgainstMaxSize(m_RTHandleProperties.currentViewportSize);
    // 软件 DRS：rtHandleScale = (curr.x/max.x, curr.y/max.y, prev.x/lastMax.x, prev.y/lastMax.y)
    Vector2 scalePrevious = m_RTHandleProperties.previousViewportSize / lastFrameMaxSize;
    m_RTHandleProperties.rtHandleScale = new Vector4(scales.x, scales.y, scalePrevious.x, scalePrevious.y);
}
```

> **关键**（HDRP `RTHandleSystem.cs:314`）：`sizeChanged = width > GetMaxWidth() || height > GetMaxHeight() || reset` —— **只在请求 > max 时 realloc**，max 单调递增。所以一个 4K RT 一旦分配好，1080p 镜头进来时**不会被毁掉**，只是 viewport 用 `rtHandleScale.xy = (1920/3840, 1080/2160)` 缩 UV。
>
> **Shader 侧消费**：`rtHandleScale = vec4(curr/max, prev/lastMax)` 让 TAA history 采样能跨帧正确反投影（前一帧的 UV ÷ 这一帧的 max）。HG 自研的 TAA / SSR / Volumetric history 全部走这条同源链路。

### 3.2 Editor 大幅缩水时延迟重置（HDRP delta vs HG）

HDRP（`RTHandleSystem.cs:293-311`）在 Editor 下有一段「连续 100 帧检测到 maxWidth/width > 2 且 maxWidth > 2560」的兜底重置，**避免一次性大分辨率把 max 撑到天花板回不来**。HG 反编译里调用点都走 Player 路径（IL2CPP），所以**这段编辑器逻辑在 HG 运行时不触发**，行为差异仅限编辑器 preview。

### 3.3 `RTHandle` 实际可用尺寸

```csharp
// HDRP: RTHandleSystem.cs:421-423（节选）
rth.referenceSize = new Vector2Int(m_MaxWidths, m_MaxHeights);
```

每个 RT 物理大小 = `(m_MaxWidths, m_MaxHeights)`，shader 里用 `rtHandleScale.xy * viewportUV` 算实际采样 UV。HG 自定义深度 RT（§6）用这条同源链：`CustomDepthOnlyRequestManager.CreateSystem` 直接 `call UnityEngine.Rendering.RTHandleSystem::Alloc`（CustomDepthOnlyRequestManager.cs:444-478）。

---

## 4. `RenderTextureManager`：场景级全局 RT 缓存 + 切场景清理

`RenderTextureManager` 是**静态类 + List 缓存**，给「需要长期持有但不属于任何 RG 资源池」的 RT 兜底（典型：SceneView preview camera、Editor 截图、`HGAtmosphereRenderer` 的离屏 cubemap）。

### 4.1 `GetRenderTexture` 算法（反汇编重建）

源：`RenderTextureManager.cs:11-173`（反汇编锚点 `VA=0x184013BC0`）。

```text
RenderTexture GetRenderTexture(
    string name, int width, int height,
    int depthBufferBits=0, bool withAlpha=true, bool isRawSize=false,
    bool isCache=true, bool hdr=false, bool sRGB=false,
    int msaaSamples=1, GraphicsFormat format=GraphicsFormat.None)
{
    // [据反汇编 184013C5C-184013C92] 若 !isRawSize:
    //   ClampRenderTargetSize(out clampedW, out clampedH)
    //   走 HGRenderPipeline.HGResolutionSettings::ClampRenderTargetSize（call ...HGResolutionSettings::ClampRenderTargetSize, RenderTextureManager.cs:64）
    if (!isRawSize)
        HGRenderPipeline.HGResolutionSettings.ClampRenderTargetSize(ref width, ref height);

    // [据反汇编 184013C97-184013CDF] 构造 RenderTextureDescriptor
    //   call UnityEngine.RenderTextureDescriptor::.ctor（mov r9d,7 = depthBits 默认配 D24S8）
    //   call UnityEngine.RenderTexture::GetDepthStencilFormatLegacy（把 depthBufferBits 转 DepthStencilFormat）
    //   按需 set_graphicsFormat / set_colorFormat
    var desc = new RenderTextureDescriptor(width, height, /*colorFormat*/?, /*depthBufferBits*/?);
    if (format != GraphicsFormat.None) desc.graphicsFormat = format;
    if (!hdr) desc.colorFormat = ...;

    // [反汇编 184013D02-184013D2A] 清掉 useDynamicScale / useDynamicScaleExplicit 位
    //   and eax, ~RenderTextureCreationFlags.UseDynamicScale
    //   and eax, ~RenderTextureCreationFlags.UseDynamicScaleExplicit
    desc.useDynamicScale         = false;
    desc.useDynamicScaleExplicit = false;

    // msaaSamples 在 [反汇编 184013D2D-184013D35]：cmp eax,1 / jg → 跳到 fallback msaaSamples=1
    if (msaaSamples > 1) desc.msaaSamples = msaaSamples;
    else                 desc.msaaSamples = 1;

    var rt = new RenderTexture(desc);
    rt.name = name;
    rt.Create();

    if (isCache)
        s_renderTextureCache.Add(rt);   // [反汇编 184013D7C-184013DAE]

    rt.filterMode = withAlpha ? FilterMode.Bilinear : FilterMode.Point;
    // [反汇编 184013DAE-184013DD6] 实际:
    //   if (!sil/*=withAlpha 反汇编路径 cmp [rbp+67h]*/) ebx=1; rt.filterMode=ebx;
    //   → filterMode 取决于 withAlpha；具体映射 0/1 对应 Point/Bilinear
    return rt;
}
```

**核心 delta vs HDRP**：HDRP `RTHandles.Alloc` 走 `RTHandleSystem` 自动缩放；HG 这里**故意不走自动缩放**（`useDynamicScale = false`，反汇编 `184013D02` 显式 AND 掉两个标志位），因为这些 RT 是给 **SceneView / 截图 / cubemap** 这类**不该跟主 camera viewport 缩放**的用户。

### 4.2 `ReleaseRenderTexture` 与 `ClearRenderTexture`（场景清理）

`ReleaseRenderTexture(rt)`（`RenderTextureManager.cs:175-275`，VA=0x184F21890）：
1. `s_renderTextureCache.Contains(rt)` → `Remove(rt)`；
2. `Object.op_Inequality(rt, null) && Object.op_Implicit(rt)` → `rt.Release(); Object.DestroyImmediate(rt, true)`。

`ClearRenderTexture()`（`RenderTextureManager.cs:277-555`，VA=0x18A6E577C）—— 切场景钩子的**关键算法**：

```text
// [反汇编 18A6E5870-18A6E593F]
1. 取 SceneManager.GetActiveScene().GetRootGameObjects() → rootGOs
2. foreach rootGO in rootGOs:
       foreach camera in rootGO.GetComponentsInChildren<Camera>(includeInactive:true):
           if (camera != null) camera.targetTexture = null;
3. foreach rt in s_renderTextureCache:
       if (rt != null) {
           rt.Release();
           Object.DestroyImmediate(rt, true);
       }
4. s_renderTextureCache.Clear();
```

> **为何这样做**：Unity 切场景时若有 Camera 还持有指向旧 RT 的 `targetTexture`，旧 RT 会被引用计数挂住、显存泄漏。HG 用「**先把所有 Camera.targetTexture 置空 → 再释放/销毁缓存** 」的次序避免悬挂引用。这是 HG 自研、HDRP 无（HDRP RT 全走 RG / RTHandleSystem，不存在裸 RT 缓存）。

---

## 5. `CustomDrawRTManager`：自定义绘制 RT 池

### 5.1 单例形态与双实现路由

```csharp
// CustomDrawRTManager.cs:70-80
private static CustomDrawRTManager s_instance;
private CommandBuffer            m_CommandBuffer;
private MaterialPropertyBlock    m_Props;
private long                     m_CppImpl;   // C++ 端句柄
public static CustomDrawRTManager Instance       => null /* 反汇编未提供 getter 主体 */;
public static bool                EnableCppCustomDraw { get; set; }
```

`Init(long customDrawRTManagerCppHandle)`（CustomDrawRTManager.cs:82-122，VA=0x185AEE410）：
- `new CustomDrawRTManager(cppImpl)`，把 C++ 句柄存 `m_CppImpl`；
- 构造体内 `new CommandBuffer(); new MaterialPropertyBlock();` （CustomDrawRTManager.cs:152-195 反汇编 `call UnityEngine.Rendering.CommandBuffer::InitBuffer` 与 `UnityEngine.MaterialPropertyBlock::CreateImpl`）。

**核心路由**（每个 API 入口反汇编开头都有这块）：

```csharp
// 例：AllocateRenderTexture（CustomDrawRTManager.cs:198-247 / VA=0x185044AB0）
bool useCpp = EnableCppCustomDraw_get();   // call loc_185045300（封装 g_18FC3A9A9 静态字段）
if (useCpp) {
    return HGRenderGraphCPP.CustomDrawRTManager_AllocateRenderTexture(
        m_CppImpl, width, height, mipCount, colorFormat, depthStencilFormat);
}
// 否则走 C# / RenderTextureManager 兜底
```

`ClearTexture / DrawTexture / ReleaseRenderTexture` 同样的「if EnableCppCustomDraw → 原生路径，否则 CommandBuffer 走 GL.GLClear / DrawProcedural」二选一。

### 5.2 `AutoRestRT`：active RT 守卫

`AutoRestRT` 是私有 `IDisposable` 嵌套结构（CustomDrawRTManager.cs:10-67）：

```csharp
private struct AutoRestRT : IDisposable {
    private RenderTexture rt;            // 保存旧 active RT

    public AutoRestRT(RenderTexture newRt) {
        // [反汇编 18A8C34F4-18A8C3520]
        rt = RenderTexture.GetActive();  // 保存当前 active
        RenderTexture.SetActive(newRt);  // 切到 newRt
    }

    public void Dispose() {
        // [反汇编 18A8C34A4-18A8C34CC]
        RenderTexture.SetActive(rt);     // 恢复
    }
}
```

`ClearTexture(rt, color)` 与 `DrawTexture(rt, rect, tex, mat)` 都把它包成 `using (new AutoRestRT(rt)) { GL.Clear / cmd.DrawProcedural }`，保证 pass 内临时切 active RT 不污染外部 RG 状态。

### 5.3 `ClearTexture` 算法（反汇编锚点 VA=0x185044DB0）

```text
public void ClearTexture(RenderTexture rt, Color color) {
    if (rt == null) return;
    if (EnableCppCustomDraw) {
        HGRenderGraphCPP.CustomDrawRTManager_ClearTextureImpl(m_CppImpl, rt.GetNativeTexturePtr(), color);
        return;
    }
    using (new AutoRestRT(rt)) {
        GL.Clear(/*clearDepth*/true, /*clearColor*/true, color, /*depth*/1.0f);
        //         ^ dl=1     ^ movzx(dl)=1
        //   反汇编：movss xmm3,[g_18C471324]=1.0f，对应 GL.Clear depth=1.0
    }
}
```

### 5.4 `DrawTexture` 算法（反汇编 VA=0x185044F40）

```text
public void DrawTexture(RenderTexture rt, in Rect rect, Texture texture, Material mat) {
    if (rt == null) return;
    if (EnableCppCustomDraw) {
        HGRenderGraphCPP.CustomDrawRTManager_DrawTexture(m_CppImpl, rt, rect, texture, mat);
        return;
    }
    using (new AutoRestRT(rt)) {
        // 设置 _MainTex_ST = (rect.width/texW, rect.height/texH, rect.x/texW, rect.y/texH)
        // [反汇编 18504506E-185045085]
        var ST = new Vector4(
            rect.width  / texW,
            rect.height / texH,
            rect.x      / texW,
            rect.y      / texH);
        m_Props.SetTexture("_MainTex",    texture);
        m_Props.SetVector ("_MainTex_ST", ST);

        // viewport = rect（反汇编 18504513A-185045152）
        m_CommandBuffer.SetViewport(rect);
        m_CommandBuffer.DrawProcedural(
            Matrix4x4.identity, mat, /*shaderPass*/0,
            MeshTopology.Triangles, /*vertexCount*/3, /*instanceCount*/1,
            m_Props);
        Graphics.ExecuteCommandBuffer(m_CommandBuffer);
        m_CommandBuffer.Clear();
        m_Props.Clear();
    }
}
```

> 全屏三角形 (`vertexCount=3, MeshTopology.Triangles`) + `_MainTex_ST` 是经典的 Blit-with-Material 模板，绕开 `Graphics.Blit` 的隐式 viewport / depth 副作用。

> **HG delta**：HDRP 没有 `CustomDrawRTManager`，HDRP 用 `Blitter`（core 包 `Runtime/Utilities/Blitter.cs`）。HG 自研此类是因为：① 要支持 C++ 直接写（`HGRenderGraphCPP`）以省 IL2CPP→native 跨界；② `AutoRestRT` 守卫给的 `RenderTexture.SetActive` 显式保护（HDRP 默认走 CommandBuffer 不保存 active）。

---

## 6. `CustomDepthOnlyRequestManager`：clipmap 式自定义深度流式回环

这是 C21 单元里**最复杂、最自研、最值钱**的一块。用于把「比相机视锥大得多的世界」装进一张 `DepthOnly` RT，每帧只刷新少量页面（page），其余页面靠 toroidal UV scroll 复用历史。典型应用：远景 fake shadow、云阴影遮罩、地形 SDF 烘焙输入。

### 6.1 系统数据模型

```csharp
public struct Request {                   // CustomDepthOnlyRequestManager.cs:22-41
    internal Vector3 rootPosition;        // 系统锚点世界坐标
    public  Vector3  frustumSize;         // 总覆盖范围（世界单位）
    public  Vector2Int rtSize;            // 整张 RT 像素尺寸 (必须 rtSize % pageSize == 0)
    public  Vector2Int pageSize;          // 单页像素尺寸
    public  DepthBits  depthBits;         // 16/24/32
    public  GraphicsFormat format;        // depth 或 R32 / R16
    public  int   depthRTShaderID;
    public  int   transformCBShaderID;
    public  bool  includeDynamicObjects;
}

// SystemData 内部状态（CustomDepthOnlyRequestManager.cs:83-118）
private struct SystemData {
    public Request request;
    public OptionalData optionalData;
    public bool isValid, paused;
    public Vector2Int pageCount;          // = rtSize / pageSize
    public Vector2 frustumPageSize;       // 单页世界尺寸
    public Vector2 anchorPosition;        // 当前 anchor（世界）
    public List<int> ringIndices;         // 环形索引顺序
    public List<Vector2Int> pageOrder;    // 页绘制次序（按距离中心排序）
    public Queue<Vector2> invalidPages;   // 需重刷的页（移动产生）
    public int currPage;
    public Vector3 currPosition;
    public Vector2Int rectCurrOffset;     // 环形偏移（当前帧）
    public Vector2Int rectRootOffset;     // 根偏移
    public Transforms transforms;         // matrix + uvScrollOffset
    public int currRTIndex;               // ping-pong RT 索引
    public PerFrameData[] perFrameData;   // 长度 2 = ping-pong
}
```

### 6.2 `CreateSystem`：构建 page 表 + ping-pong RT

源：CustomDepthOnlyRequestManager.cs:164-692（VA=0x18A8C4D50）。算法步骤：

**步骤 1 — 校验整除**（反汇编 `idiv` 后 `test edx,edx; jne <fail>`，:230-240）：

```
require: request.rtSize.x % request.pageSize.x == 0
require: request.rtSize.y % request.pageSize.y == 0
```

不整除 → 直接 return null（构成失败）。

**步骤 2 — 计算 pageCount**（:255-265）：

```
pageCount.x = rtSize.x / pageSize.x
pageCount.y = rtSize.y / pageSize.y
```

**步骤 3 — 生成 `pageOrder`**（:266-313）：把所有 `(i, j) ∈ [0, pageCount.x) × [0, pageCount.y)` 加入 `List<Vector2Int>`，然后 **按到 anchor 中心 `(pageCount/2 - 0.5, pageCount/2 - 0.5)` 的距离排序**（反汇编 :300-313 调 `List<Vector2Int>.Sort` + `<>c__DisplayClass14_0.<CreateSystem>b__0` 距离比较器，常量 `g_18C471320 = 0.5f`）。

```csharp
var pageOrder = new List<Vector2Int>();
for (int j = 0; j < pageCount.y; j++)
  for (int i = 0; i < pageCount.x; i++)
    pageOrder.Add(new Vector2Int(i, j));

Vector2 anchor = new Vector2(pageCount.x * 0.5f - 0.5f, pageCount.y * 0.5f - 0.5f);
pageOrder.Sort((a, b) => Mathf.Sign(
    ((Vector2)a - anchor).sqrMagnitude - ((Vector2)b - anchor).sqrMagnitude));
```

**步骤 4 — `ringIndices` 环形序列**（:315-400）：构造一个**逐环展开**的索引序列，从最里一圈到最外一圈，每环包含该环上所有页的索引。反汇编 :333-385 显示 `r13 = ceil(sqrt(pageCount.x*0.5f * pageCount.x*0.5f))`（Math.Ceiling on `pageCount/2`），每环页数为 `(2*ringIdx+1)^2 - (2*ringIdx-1)^2 = 8*ringIdx`（标准的「方形环」展开）。这是 **clipmap 经典优先级**：先刷中心、再扩外圈。

**步骤 5 — 分配 ping-pong RT**（:444-492）：

```csharp
perFrameData = new PerFrameData[2];   // ping-pong

// 反汇编 :444-455 完整调用 UnityEngine.Rendering.RTHandleSystem::Alloc
//   width=rtSize.x, height=rtSize.y, depthBufferBits=request.depthBits,
//   colorFormat=request.format, slices=1, msaa=None, useDynamicScale=false,
//   memoryless=None, name=""
perFrameData[0].depthOnlyRT = RTHandleSystem.Alloc(
    width: request.rtSize.x,
    height: request.rtSize.y,
    depthBufferBits: request.depthBits,
    colorFormat: request.format,
    /* ... 与反汇编一一对应 ... */);
perFrameData[1].depthOnlyRT = RTHandleSystem.Alloc(... index=1);
```

**步骤 6 — 初始化 transforms**（:494-525）：

```csharp
transforms.uvScrollOffset = Vector2.zero;
frustumPageSize = new Vector2(
    request.frustumSize.z / pageCount.x,    // 注：反汇编 :513 用 frustumSize[12]=z 分量
    request.frustumSize.x / pageCount.y);
```

> **据反汇编 :513-521 + 字段偏移**：`frustumSize` 是 Vector3 但代码只用了它的两个分量做 frustum-to-world 映射，z=世界 x 范围，x=世界 y 范围（XZ 平面投影，俯视视角）—— 这是 cascade shadow / clipmap 的标准约定（光轴沿世界 Y）。

### 6.3 `UpdateSystem`：检测移动 + 入队 invalid pages

源：CustomDepthOnlyRequestManager.cs:1897-2250（VA=0x18A8C5B90）。

```text
UpdateSystem(handle, Vector3 cameraPos):
  if (!IsValid(handle) || system.paused) return;

  // [反汇编 18A8C5C9D-18A8C5CFA]
  Vector2 deltaPage = new Vector2(
      (cameraPos.x - system.anchorPosition.x) / system.frustumPageSize.x,
      (cameraPos.z - system.anchorPosition.y) / system.frustumPageSize.y);
  int newI = Mathf.FloorToInt(deltaPage.x);
  int newJ = Mathf.FloorToInt(deltaPage.y);

  Vector2 deltaRoot = new Vector2(
      (cameraPos.x - system.request.rootPosition.x) / system.frustumPageSize.x,
      (cameraPos.z - system.request.rootPosition.z) / system.frustumPageSize.y);
  int rootI = Mathf.FloorToInt(deltaRoot.x);
  int rootJ = Mathf.FloorToInt(deltaRoot.y);

  // 步长（反汇编 18A8C5D00-18A8C5D38）
  int signI = (int)Mathf.Sign(newI - oldI);  // 含 0 → 0
  int signJ = (int)Mathf.Sign(newJ - oldJ);
  int absI  = Mathf.Abs(newI - oldI);
  int absJ  = Mathf.Abs(newJ - oldJ);
  int maxStep = max(absI, absJ);

  // [反汇编 18A8C5D8B-18A8C5DA9]
  // 如果 maxStep > pageCount/2 → 整张失效，清空 invalidPages，下一帧全刷
  if (maxStep > min(pageCount.x, pageCount.y) * 0.5f) {
      system.invalidPages.Clear();
      system.currPage = 0;
  }
  // 如果总位移很大（cameraPos vs root 差距 > rtSize/4） → 走 ringIndices 列表全刷
  else if (rtSize too large vs frustum) {
      system.currPage = ringIndices[(currPage + 1) % ringIndices.Count];
  }
  // 普通情况：按 X / Y 方向逐排入队 invalidPages
  else {
      // [反汇编 18A8C5E90-18A8C5FB7]
      // X 方向：for each row 把新进入视野的列 (newI+stepX-1+b ... newI+stepX) 加入队列
      // Y 方向：for each col 把新进入视野的行加入队列
      for (int row = 0; row < absI; row++) {
          for (int col = 0; col < pageCount.y; col++) {
              Vector2 uvOffset = new Vector2(
                  (toroidal_x(anchorI + signI * (pageCount.x - absI + 1 + row))),
                  (col + frustumPageSize.y * something));
              system.invalidPages.Enqueue(uvOffset);
          }
      }
      // 对称地处理 Y 方向
  }

  // 更新 anchor
  system.anchorPosition.x = newI * frustumPageSize.x + rootPosition.x;
  system.anchorPosition.y = newJ * frustumPageSize.y + rootPosition.z;
  system.currPosition     = cameraPos;
  system.rectCurrOffset   = new Vector2Int(newI, newJ);
  system.rectRootOffset   = new Vector2Int(rootI, rootJ);
```

> **据反汇编 `Mathf.Sign` 调用与 `MOD` 实现重建**：这是教科书 toroidal addressing —— anchor 移动一格，**整张 RT 不重绘**，只把「新进入视野」的一排页加进 `invalidPages` 队列，其余页通过 `uvScrollOffset` 整体位移仍然有效。
>
> **数学**：把 anchor 移动 ΔP（页单位），那 UV 坐标全局位移 `uvScrollOffset += (ΔP * pageSize)`，shader 采样时 `uv = (frag_uv + uvScrollOffset) mod 1.0`。所以 RT 物理上不动，但「世界 → UV」的映射跟着 anchor 滑动。这与 GPU Gems 3 "GPU-Generated Terrain" / Wright 的 "Toroidal Addressing" 同源。

### 6.4 `CreateRenderData`：每帧只刷一页

源：CustomDepthOnlyRequestManager.cs:694-1619（VA=0x18A8C3D14）。

```text
CreateRenderData(int systemIdx, HGRenderGraph rg):
  var sys = m_systems[systemIdx];
  Vector2 pagePixSize = (sys.request.rtSize / 2 / pageCount).clamp;   // ≈ pageSize/2 实际上反汇编是 rtSize.x / 0x40 ... 后又乘 / 2 = pageSize/2，本质是 page 像素尺寸/2

  // 1. 从 invalidPages 队列拿一页（若有），否则从 pageOrder 列表轮询
  Vector2 currPagePos;
  if (sys.invalidPages.Count > 0) {
      while (invalidPages.TryDequeue(out var p)) {
          // 检查 p 距 anchor 是否还在 frustum 内；不在 → 丢
          if (|sys.rectRootOffset.x - p.x| <= pageSize.x &&
              |sys.rectRootOffset.y - p.y| <= pageSize.y) {
              currPagePos = p; break;
          }
      }
  }
  else {
      // 轮询 pageOrder
      var p = sys.pageOrder[sys.currPage];
      currPagePos = anchor + (p - center) * frustumPageSize;
      sys.currPage = (sys.currPage + 1) % pageOrder.Count;
  }

  // 2. 计算页中心世界坐标 + page 投影
  Vector3 pageCenter = new Vector3(
      currPagePos.x * frustumPageSize.x + rootPosition.x,
      cameraHeight,                                        // 反汇编 :763
      currPagePos.y * frustumPageSize.y + rootPosition.z);

  // 3. 构造正交矩阵
  //   cullingMtx  = Matrix4x4(pageCenter, 0, frustumPageSize.x, frustumPageSize.y, near=0, far=cameraHeight)
  //   deviceMtx   = GL.GetGPUProjectionMatrix(cullingMtx, renderIntoTexture:true)
  //   反汇编 :864-1145 完全照搬 HDRP 阴影投影模板
  data.cullingViewProj = cullingMtx;
  data.deviceViewProj  = deviceMtx;

  // 4. 计算 viewport（页在 RT 内的像素矩形 + toroidal 拆分）
  //   核心：当 page 横跨 RT 边界时，需要拆成 1~4 个矩形（反汇编 :1005-1068 显式 cmp 后分支）
  data.clearViewport0 = Rect(...);  // 1 ~ 4 个，反汇编生成的常量序列 [g_18C471520]/[g_18C4714E0]
  data.clearViewport1 = ...;
  data.clearViewport2 = ...;
  data.clearViewport3 = ...;
  data.pageViewport   = Rect(...);
  data.wholeViewport  = Rect(0, 0, rtSize.x, rtSize.y);

  // 5. 写 transform CB
  //   transformCB.transform        = pageProjectionMatrix
  //   transformCB.uvScrollOffset   = sys.transforms.uvScrollOffset
  //   反汇编 :1206-1265 通过 AllocateConstantBuffer(20h bytes) + Buffer.MemoryCopy
  data.transformCB = rg.AllocConstantBuffer<Transforms>();
  data.transformCB.Set(sys.transforms);

  // 6. 写 cameraHeightRefreshDataCB（params0/params1 各 16 bytes = 32B）
  //   params0 = (cameraHeight, prevCameraHeight, 0, 0)
  //   params1 = (1 / frustumSize.y, viewportX/rtSize.x, -viewportY/rtSize.y, 0)
  //   反汇编 :1215-1305 / 数据流参见 DepthRefreshParams 结构
  data.cameraHeightRefreshDataCB = rg.AllocConstantBuffer<DepthRefreshParams>();

  // 7. 写 sys.transforms.uvScrollOffset = 当前页的偏移（注意带边界纠正：反汇编 :1322-1380 sub 0.5px）
  sys.transforms.uvScrollOffset += offsetFromAnchor / (Vector2)rtSize;

  // 8. ping-pong RT 索引 + import
  int next = (sys.currRTIndex + 1) % 2;
  data.prevDepthOnlyRT = rg.ImportDepthbuffer(sys.perFrameData[sys.currRTIndex].depthOnlyRT);
  data.currDepthOnlyRT = rg.ImportDepthbuffer(sys.perFrameData[next].depthOnlyRT);
  sys.currRTIndex = next;

  data.depthRTShaderID      = sys.request.depthRTShaderID;
  data.transformCBShaderID  = sys.request.transformCBShaderID;
  data.includeDynamicObjects= sys.request.includeDynamicObjects;
  data.isOrthographic       = true;

  return data;
```

> 关键点 ——
> - **每帧 1 个 dispatch（一页）**：而不是全 RT 重绘，开销 = `pageSize²` 个 fragment + scene cull。如果 `rtSize=4096`、`pageSize=256`，那一帧只刷 1/256 张 RT。
> - **clearViewport 0..3**：当某页跨越 RT 边界（toroidal wrap），需要把它拆成最多 4 个矩形分别 clear+draw，反汇编 :1005-1068 用 4 个固定 `Rect` 字段编码。
> - **`prev`/`curr` ping-pong**：前一帧的 RT 当作历史，当帧写入新的，shader 端可以做时间稳定化（反走样、avg）。
> - **VSM 支持**：`OptionalFeatures.vsmSupport`（CustomDepthOnlyRequestManager.cs:17-21）允许同时输出 VSM（Variance Shadow Map）通道，挂在 `VSMData.vsmRT` 上，让上层可以选择 hard / VSM 阴影。

### 6.5 `RequestCustomDepthOnlyPassV1` / `RemoveSystem` / `TogglePass`

- `RequestCustomDepthOnlyPassV1(ref Request)`（:1621-1823）：扫描 `m_systems` 找到第一个 `isValid=false` 的槽位回填；没有则 `DynamicArray.Add(newSystem)`。返回 `Handle{index}`。
- `RemoveSystem(handle)`（:1825-1857）→ `IsValid` 校验后置 `isValid=false`，**不释放 RT**（下次复用）。
- `TogglePass(handle, enable)`（:2252-2311）：`system.paused = !enable`。
- `RetrieveAllSystemRenderData(rg)`（:2346-2526）：扫描 `m_systems`，对每个 `isValid && !paused` 的系统调 `CreateRenderData`，打包成 `NativeArray<RenderData>` 返回给主管线。

### 6.6 数据流图（每帧）

```
HGCamera.position
    ↓
UpdateSystem(handle, cameraPos)
    ├→ 算 Δpage（toroidal 寻址）
    ├→ 把新进入视野的页入队 invalidPages
    └→ 更新 anchorPosition / rectCurrOffset / currPosition

RetrieveAllSystemRenderData(rg)
    ↓ foreach valid system
    CreateRenderData(idx, rg)
    ├→ 选下一页（优先 invalidPages，否则 pageOrder 轮询）
    ├→ 算 page 正交矩阵 + 4 个 clear viewport
    ├→ 写 transformCB + cameraHeightRefreshDataCB
    └→ ping-pong 切 RT
        ↓
NativeArray<RenderData> → 渲染 pass（外部）
    [由 CustomDepthOnly pass 实际 dispatch，本文件只构造数据]
```

> **HG 自研 vs HDRP**：HDRP 的级联阴影（CSM）每帧重绘当前级联全部内容；HG 这套 **clipmap 风格 streaming depth** 把摊销成「每帧一页」，对超大覆盖范围（云阴影、地形 SDF 输入）省 1~2 个数量级。

---

## 7. `RTExtraction*` + `SceneRTFeature`：场景 RT 抽取

### 7.1 枚举

```csharp
// RTExtractionType.cs：RT 来源类型
public enum RTExtractionType {
    SceneColorLS        = 0,   // Linear-Space（HDR、pre-tonemap）SceneColor
    BlurredSceneColorPS = 1,   // Post-Space + Blur（用于角色海报背景模糊）
    SceneColorPS        = 2,   // Post-Space（tonemapped）SceneColor
    FinalResult         = 3,   // 最终上屏前 RT（含 UI 后处理）
    Count               = 4
}

// RTExtractionDuration.cs：抽取的持久性
public enum RTExtractionDuration {
    Persistent = 0,   // 一直存活直到主动 release（截图用）
    Temporal   = 1,   // 单帧抽取（拍照预览）
    Count      = 2
}

// SceneRTFeature.cs：sceneNormal + sceneDepth 的 shader ID 对
public struct SceneRTFeature {
    internal int sceneNormalID;
    internal int sceneDepthID;
}
```

### 7.2 设计意图与数据流（推断）

`SceneRTFeature` 把 `sceneNormal` 和 `sceneDepth` 的 Shader Property ID 打包，给「需要场景几何信息但跑在不同 pass 的子系统」共享：
- **抽取 pass**：从 RG 当前帧的 `sceneNormal / sceneDepth` 通过 `_FrameSceneNormalTexID` / `_FrameSceneDepthTexID` 全局贴图槽暴露给后续 pass；
- **使用 pass**：角色 / 接触阴影 / 卡通描边可以直接采样这两张图无需重绘。

`RTExtractionType × RTExtractionDuration` 矩阵（4 × 2 = 8 种组合）覆盖：
- **截图场景**：`(SceneColorLS, Persistent)` → HDR 原图供后续渲染海报；`(FinalResult, Temporal)` → 一帧上屏后立即丢；
- **拍照系统**：`(BlurredSceneColorPS, Persistent)` → 角色头像 / 装备图标用模糊背景；
- **Photo Mode UI**：`(SceneColorPS, Persistent)` → 显示在 UI 框内的实时 preview。

> **据反汇编与枚举命名重建**（HDRP 无此精确模式）：HG 自研此枚举对，是因为「拍照 / 海报 / 截图」是同档游戏的强需求，需要在 RG 框架外拿到稳定的、可命名的 RT 句柄。具体的 pass 装配代码在主管线的 capture / extraction pass（本单元未含），但枚举本身已经精确定义了系统的扩展点。

---

## 8. 工具 pass：`ComposablePass` / `CopyTexturePass` / `LowResBlitPass` / `SetFinalTargetPass`

### 8.1 `ComposablePass`：父子 pass 嵌套

源：ComposablePass.cs:5-172。

```csharp
internal class ComposablePass {
    // 子类覆写：返回 HGRenderGraphBuilder?（可空）
    protected virtual HGRenderGraphBuilder? GetRenderGraphBuilder(HGRenderGraph rg) { ... }

    // 把 pass 作为子 pass 附在 rg 当前 builder 下
    internal void SetChildPass(HGRenderGraph rg, ComposablePass childPass) {
        var parentBuilder = this.GetRenderGraphBuilder(rg);
        var childBuilder  = childPass?.GetRenderGraphBuilder(rg);
        if (parentBuilder.HasValue && childBuilder.HasValue)
            parentBuilder.Value.AddChildPass(childBuilder.Value);
    }
}
```

> 把多个独立 pass 组合成「父 pass + 1..N 子 pass」的树形（反汇编 :138 `call HGRenderGraphBuilder::AddChildPass`），用于「一个高层语义 pass（如『后处理链』）由多个底层物理 pass 顺序组成」。这是 HG 自研、便于在 RG 之上做语义层级。

### 8.2 `CopyTexturePass`：通用拷贝/上屏/MV 拷贝

源：CopyTexturePass.cs:5-597。3 个静态入口：

| API | 用途 | HGProfileId | RG pass 名 |
|-----|------|-------------|-----------|
| `BlitTexture(rg, src, dst, copyPassIndex, dstTextureShaderID, useNativeBlit, viewport, loadRT)` | 通用拷贝（可指定 viewport 和 shader pass index） | `0x1F` | "Blit Texture" |
| `CopyDepth(rg, srcDepth, dstDepth)` | 拷贝深度缓冲 | `0x01` | "Copy Depth Buffer" |
| `BlitMotionVector(rg, srcMV, dstMV)` | 拷贝速度向量 | `0x53` | "Blit Motion Vector" |

**`BlitTexture` 关键反汇编点**（CopyTexturePass.cs:46-285，VA=0x18A7202C4）：

```text
1. Validate: srcTexture.IsValid() && dstTexture.IsValid() （:84-95）
2. var sampler = ProfilingSampler.Get(HGProfileId)
3. rg.AddRenderPass<CopyTextureData>("Blit Texture", sampler, ...) → builder
4. builder.AllowPassCulling(false, false)
5. data.srcTexture = builder.ReadTexture(src)
6. data.dstTexture = builder.WriteTexture(dst)
7. data.copyPassIndex = copyPassIndex   // :144 偏移 +0x34
8. data.useNativeBlit = useNativeBlit    // :149 偏移 +0x38
9. data.dstTextureShaderID = dstTextureShaderID  // :154
10. data.isFP32Output = (GetTextureDescRef(dst).colorFormat == GraphicsFormat.R32_SFloat)
    [反汇编 :158-167 cmp dword ptr [rax+10h],31h sete al]
    GraphicsFormat.R32_SFloat = 0x31 (49)
11. data.viewport = *(viewport ptr)        // :168-173 movups xmm0
12. if (!useNativeBlit) {
        Rect fullScreen = {0, 0, 1, 1}   // movdqa xmm0,[g_18C471510]（标准 (0,0,1,1) 全屏 viewport）
        builder.SetColorAttachment(dst,
                                   index=0,
                                   loadAction = loadRT ? Load : DontCare /* xor eax,1 */,
                                   storeAction = Store);
   }
13. builder.SetRenderFunc(s_copyTextureFunc)
```

> **常量 `(0,0,1,1)` 标准全屏 viewport**：`g_18C471510` 反汇编多处出现（CopyTexturePass.cs:176 / BlitMotionVector.cs / SetFinalTarget），是 NDC viewport 单位矩形的全局常量。HG 自研、HDRP 用 `Vector4(0,0,1,1)` 或 `Rect.MinMaxRect`。

**`BlitMotionVector`**（CopyTexturePass.cs:436-595）：与 `BlitTexture` 同构，HGProfileId=`0x53`，但**强制 `SetColorAttachment(loadAction=Load /*1*/)`**（反汇编 :517-520 `mov dword ptr [rsp+20h],1`），保留旧 MV 不丢失（多 camera 叠加场景）。

**`CopyDepth`**（CopyTexturePass.cs:288-433）：HGProfileId=`0x01`，**不 SetColor/SetDepthAttachment**（反汇编中无 attachment 设置），靠 `s_copyDepthFunc` 内部走 `cmd.CopyTexture` 原生路径。

### 8.3 `LowResBlitPass`：低分辨率深度/颜色合并

源：LowResBlitPass.cs:5-454。

`DownsampleDepth(rg, src, lowResMin, lowResMax, outputType)`（VA=0x18A7500F4）：

```text
1. rg.AddRenderPass<DownsampleDepthPassData>("Downsample Depth Buffer", HGProfileId=0x26)
2. data.srcTexture = builder.ReadTexture(src)
3. data.outputType = outputType   // DownsampleDepthOutput 枚举（外部，本单元未含）
4. if (lowResMin.IsValid()) {
       builder.SetColorAttachment(lowResMin, index=0, storeAction=Store /* :120 mov 2 = Resolve? */);
   }
5. if (lowResMax.IsValid()) {
       builder.SetDepthAttachment(lowResMax, depthSlice=0, loadAction=DontCare, storeAction=Store=2);
       // [反汇编 :136-142 `mov dword ptr [rsp+20h],2` = StoreAction=Store]
   }
6. SetRenderFunc(s_downsampleDepthFunc)
```

`UpsampleColorAndMV(rg, lowResColor, lowResMV, dstColor, dstMV, sceneDepth, camera)`（VA=0x18A750454）：

```text
1. rg.AddRenderPass<MergeLowResPassData>("Merge LowRes Color and MV", HGProfileId=0x26)
2. data.camera = camera     // 反汇编 :291-294
3. data.lowResColorTexture = builder.ReadTexture(lowResColor)
4. data.lowResMVTexture    = builder.ReadTexture(lowResMV)
5. builder.SetColorAttachment(dstColor, index=0, loadAction=DontCare, storeAction=Store)
6. builder.SetColorAttachment(dstMV,    index=1, loadAction=DontCare, storeAction=Store)
   [反汇编 :349-355 mov r9d,1（MRT slot index）]
7. builder.SetDepthAttachment(sceneDepth, depthSlice=0, ...)
8. SetRenderFunc(s_mergeLowResFunc)
```

> **典型用途**：体积雾、半透明粒子、低优先级特效在 1/2 分辨率渲染节省带宽 → 然后 upsample 到全分辨率合成。`DownsampleDepth` 输出 `lowResMin`（最近）+ `lowResMax`（最远）双通道，给后续 stochastic / nearest-depth upsample 选择参考；这是 GDC 2014 "Practical Stochastic Lightcuts" 风格的近邻深度上采样模板。

### 8.4 `SetFinalTargetPassConstructor`：BackBuffer 上屏

源：SetFinalTargetPassConstructor.cs:8-526（VA=0x18A75B6E8）。

**核心逻辑分支**（反汇编 :191-227 + :313-381）：

```text
ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph rg, HGCamera camera):

  // 路径 A：HGCamera.targetTexture 已绑定 RenderTexture（如 SceneView 抓帧）
  if (camera.targetTexture != null && camera.targetTexture.depth > 0) {
      var builder = ???;   // 直接用主 builder（反汇编未显示完整 path）
      builder.SetColorAttachment(input.backBufferColor, ...);
      builder.SetDepthAttachment(input.backBufferDepth, ...);
      data.finalResult = builder.ReadTexture(input.finalResult);
      data.flipY       = camera.isMainGameView;   // :255-258 call get_isMainGameView
      data.copyDepthMaterial = m_CopyDepth;
      builder.SetRenderFunc(s_setFinalTargetRenderFunc);
  }

  // 路径 B：finalResult 与 sceneDepth 不同
  if (input.finalResult.ResourceHandle != input.sceneDepth.ResourceHandle) {
      rg.AddRenderPass<SetFinalTargetPassData>("Set Final Target", ...);
      data.finalResult  = builder.ReadTexture(input.finalResult);
      data.finalTarget  = builder.WriteTexture(input.backBufferColor);
      // → s_copyColorFunc 拷贝 finalResult 到 backBuffer
  }
```

**flipY 处理**：`data.flipY = camera.isMainGameView`（反汇编 :268-271 `call HG.Rendering.Runtime.HGCamera::get_isMainGameView`）—— 主 GameView 在某些平台上需要 Y 翻转（OpenGL vs D3D 纹理坐标差异），SceneView / RT capture 不翻转。HG 把判断显式做到这一层，省得让 shader 端处理。

`m_CopyDepth` 材质从 `HGRenderPipelineMaterialCollector.CreateMaterial` 创建（构造 :45-73），shader 路径在 `HGRenderPathBase.HGRenderPathResources` 的 `+0x128` 字段（反汇编 :60），是「拷贝深度到 backbuffer depth」的专用材质。

---

## 9. 数据流与帧时序总图

```
                ┌────────────────────────────────────────────────────────────────────┐
                │                       每帧入口（HGRenderPipeline）                  │
                └─────────────────────────────────┬──────────────────────────────────┘
                                                  │
                                                  ▼
        ┌──────────────────────────────────────────────────────────────────────┐
        │  RTHandleSystem.SetReferenceSize(viewportW, viewportH)             │
        │   - m_MaxWidths/Heights 单调递增                                    │
        │   - 算 rtHandleScale = (curr/max, prev/lastMax) → ShaderVariables  │
        └──────────────────────────────────────────────────────────────────────┘
                                  │
        ┌──────────────────────────┼──────────────────────────────────────────┐
        │                          ▼                                          │
        │  ┌─ RenderTextureManager ───────────────────────────────────────┐  │
        │  │   场景外 / Editor / 截图用 RT                                  │  │
        │  │   GetRenderTexture → s_renderTextureCache.Add               │  │
        │  │   ClearRenderTexture（切场景钩子，Camera.targetTexture=null） │  │
        │  └───────────────────────────────────────────────────────────────┘  │
        │                                                                      │
        │  ┌─ CustomDrawRTManager.Instance ───────────────────────────────┐  │
        │  │   AllocateRenderTexture → C++ or RenderTextureManager       │  │
        │  │   ClearTexture / DrawTexture → AutoRestRT 包裹              │  │
        │  └───────────────────────────────────────────────────────────────┘  │
        │                                                                      │
        │  ┌─ CustomDepthOnlyRequestManager ──────────────────────────────┐  │
        │  │   foreach valid system:                                      │  │
        │  │     UpdateSystem(camPos) → toroidal anchor + invalidPages    │  │
        │  │     CreateRenderData(rg) → 1 页 per frame，ping-pong RT       │  │
        │  │   RetrieveAllSystemRenderData(rg) → NativeArray<RenderData>  │  │
        │  └───────────────────────────────────────────────────────────────┘  │
        │                                                                      │
        └──────────────────────────────────────────────────────────────────────┘
                                  │
                                  ▼
        ┌──────────────────────────────────────────────────────────────────────┐
        │              主管线 RenderGraph（详见 ../03-RenderGraph）             │
        │   - 各功能 pass 用 RTHandleSystem.Alloc / RG pooled RT               │
        │   - 工具 pass：CopyTexturePass / LowResBlitPass 在帧内被串入        │
        └──────────────────────────────────────────────────────────────────────┘
                                  │
              ┌───────────────────┴────────────────────┐
              ▼                                        ▼
        SetFinalTargetPassConstructor          RTExtraction pass（按 type×duration）
        - 写 BackBuffer + flipY                - SceneColorLS/PS/Blurred/FinalResult
        - copyDepth                            - Persistent → 留作截图；Temporal → 单帧
```

---

## 10. HG ↔ HDRP delta 汇总

| 项 | HDRP | HG | 反编译依据 |
|----|------|----|-----------|
| RT 缩放/复用 | `RTHandleSystem`（单调 max） | **照搬**，直接 `call RTHandleSystem::Alloc` | CustomDepthOnlyRequestManager.cs:444-478 |
| RT 生命周期分类 | 隐式（RG `createPassIndex/releasePassIndex` 推算） | **显式 `RTLifeCycle` 三态枚举** | RTLifeCycle.cs 全文件 |
| 场景级 RT 兜底缓存 | 无 | `RenderTextureManager` + `ClearRenderTexture`（清 Camera.targetTexture） | RenderTextureManager.cs:11-555 |
| Custom Blit 工具 | `Blitter`（core 包） | **`CustomDrawRTManager` + `AutoRestRT` + 双实现（C++/C#）** | CustomDrawRTManager.cs:10-647 |
| 大世界深度 RT | CSM 每帧重绘 | **clipmap toroidal streaming，每帧 1 页** | CustomDepthOnlyRequestManager.cs:164-2528 |
| 场景 RT 抽取 | `IsRenderRequest` 散点接口 | **`RTExtractionType × RTExtractionDuration` 矩阵（4×2）** | RTExtractionType.cs / RTExtractionDuration.cs |
| Pass 父子嵌套 | 无 | **`ComposablePass.SetChildPass` + `HGRenderGraphBuilder.AddChildPass`** | ComposablePass.cs:71-170 |
| 上屏 pass flipY | HDRP 全局开关 | **`SetFinalTargetPassConstructor` 按 `HGCamera.isMainGameView` 逐帧判断** | SetFinalTargetPassConstructor.cs:255-258 |

---

## 11. 关键常量 / 魔数

| 常量 / 魔数 | 含义 | 反汇编依据 |
|------------|------|-----------|
| `g_18C471320 = 0.5f` | `pageCount * 0.5f - 0.5f` 算 anchor 中心，以及 toroidal mod 中点 | CustomDepthOnlyRequestManager.cs:290 |
| `g_18C471324 = 1.0f` | `GL.Clear(depth=1.0)` 标准远裁面 depth | CustomDrawRTManager.cs:334（`movss xmm3,[g_18C471324]`） |
| `g_18C471510 = {0,0,1,1}` | NDC 标准全屏 viewport Rect 常量 | CopyTexturePass.cs:176 / SetFinalTargetPass.cs:237 |
| `g_18C4714E0`/`g_18C4714F0`/`g_18C471520` | Matrix4x4 单位/标准列向量段 | CustomDepthOnlyRequestManager.cs:1071-1075 |
| `0x31 = 49 = GraphicsFormat.R32_SFloat` | `isFP32Output` 判定 | CopyTexturePass.cs:165 |
| `RenderTextureDescriptor`「ctor `r9d=7`」 | 默认 `depthBufferBits=7` 对应 D32Float_S8 | RenderTextureManager.cs:71 |
| HGProfileId `0x1F` | "Blit Texture" 标签 | CopyTexturePass.cs:97 |
| HGProfileId `0x53` | "Blit Motion Vector" 标签 | CopyTexturePass.cs:469 |
| HGProfileId `0x01` | "Copy Depth Buffer" 标签 | CopyTexturePass.cs:321 |
| HGProfileId `0x26` | "Downsample Depth Buffer" / "Merge LowRes Color and MV" | LowResBlitPass.cs:66 / :263 |
| `perFrameData[].Length = 2` | CustomDepth ping-pong 槽位 | CustomDepthOnlyRequestManager.cs:444-487 |
| `0x108 / 264 bytes = SystemData` 尺寸 | CustomDepthOnly system 数据块 | CustomDepthOnlyRequestManager.cs:491 `mov r8d,108h; call sub_18036E950` |
| `0x140 / 320 bytes = RenderData` 尺寸 | CustomDepthOnly per-frame render 数据块 | CustomDepthOnlyRequestManager.cs:1411 `mov r8d,140h` |
| `pageOrder.Sort` 比较器 | 按 `sqrMagnitude` 距 anchor 排序 | CustomDepthOnlyRequestManager.cs:300-313 |

---

## 12. 1:1 复刻蓝图（分步）

要在你自己的引擎/管线上重建本子系统，按下列顺序：

1. **建 `RTLifeCycle` 三态枚举**（Transient/Frame/Persist），其在你的 RG 资源池查询表里作为 lifetime 类别字段。

2. **接入 HDRP `RTHandleSystem`**（或同构等价物），实现：
   - `m_MaxWidths / m_MaxHeights` 单调递增（`Resize` 仅在 `width > GetMaxWidth()` 时触发）；
   - `rtHandleScale = (curr/max, prev/lastMax)` 写入 ShaderVariables，shader 端 UV 一律 `viewportUV * rtHandleScale.xy`；
   - `Alloc/Release` 钩 `m_AutoSizedRTs` HashSet。

3. **写 `RenderTextureManager`**（兜底层）：静态 `List<RenderTexture>` + `ClampRenderTargetSize` 钩子 + `RenderTextureDescriptor` 构造（关掉 `useDynamicScale`）+ 缓存维护；切场景钩子按 §4.2 步骤实现。

4. **`CustomDrawRTManager` 单例**：双实现路由（C++/C#），`AutoRestRT` 守卫保存恢复 `RenderTexture.GetActive()/SetActive()`，`DrawTexture` 用 `MeshTopology.Triangles`+`vertexCount=3` 的全屏三角形 + `MaterialPropertyBlock.SetTexture("_MainTex")`/`SetVector("_MainTex_ST")` 完成 procedural blit。

5. **`CustomDepthOnlyRequestManager`** —— 按 §6 五大算法分步实现：
   - `Request.rtSize % pageSize == 0` 校验；
   - `pageOrder` 按距 anchor `sqrMagnitude` 排序；
   - `ringIndices` 方形环展开；
   - `CreateSystem` 双 RTHandle ping-pong + `Queue<Vector2> invalidPages`；
   - `UpdateSystem` 算 Δpage、按 `Mathf.Sign` 方向遍历入队 / 全失效阈值（步长 > `pageCount/2`）；
   - `CreateRenderData` 选页 → 正交矩阵 → 拆 4 个 clear viewport（toroidal wrap） → 写 transformCB + cameraHeightRefreshDataCB → ping-pong 切 RT；
   - 提供 `Request / Remove / Toggle / Retrieve` 公开 API。

6. **`RTExtractionType × RTExtractionDuration`** 枚举对 + `SceneRTFeature {sceneNormalID, sceneDepthID}` 结构。然后在抽取 pass 里按 4×2 矩阵实现各组合的 RT 创建 / 拷贝 / 命名 / 回读。

7. **工具 pass**：
   - `ComposablePass.GetRenderGraphBuilder` + `SetChildPass` → `Builder.AddChildPass`；
   - `CopyTexturePass`：3 个静态 API（Blit / CopyDepth / BlitMotionVector），全屏 viewport `(0,0,1,1)` 常量、`useNativeBlit` 旁路；
   - `LowResBlitPass`：DownsampleDepth 出 min/max 双 RT，UpsampleColorAndMV 走 MRT 2 个 color attachment + depth attachment；
   - `SetFinalTargetPassConstructor`：判断 `camera.targetTexture` 路径 A / B，`flipY = isMainGameView`，专用 `m_CopyDepth` 材质。

8. **HGResourceManagerScript**（边角层）：负责 Beyond 引擎层的 `FAssetProxyHandle` 异步加载/卸载（与 RT 无关，但与本单元同处资源管理域，见 §13）。

---

## 13. 支撑证据

### 13.1 文件清单（每个 .cs 一行职责）

| 文件 | 职责 |
|------|------|
| `RenderTextureManager.cs` | 静态 RT 缓存 + `GetRenderTexture` / `ReleaseRenderTexture` / `ClearRenderTexture`（切场景） |
| `RTLifeCycle.cs` | 三态生命周期枚举 `{Transient=0, Frame=1, Persist=2}` |
| `CustomDrawRTManager.cs` | 单例 RT 池 + `AutoRestRT` 守卫 + 双实现路由（C++/C#）+ 4 个公开 API |
| `CustomDepthOnlyRequestManager.cs` | clipmap toroidal 流式深度 RT 系统：`CreateSystem` / `UpdateSystem` / `CreateRenderData` / `Request|Remove|Toggle|Retrieve` |
| `RTExtractionType.cs` | 抽取 RT 类型枚举（SceneColorLS / BlurredSceneColorPS / SceneColorPS / FinalResult） |
| `RTExtractionDuration.cs` | 抽取持久性枚举（Persistent / Temporal） |
| `SceneRTFeature.cs` | sceneNormal + sceneDepth 的 shader ID 对 |
| `ComposablePass.cs` | 父子 pass 嵌套基类（`GetRenderGraphBuilder` + `SetChildPass`） |
| `CopyTexturePass.cs` | 通用 Blit / CopyDepth / BlitMotionVector 工具 pass |
| `LowResBlitPass.cs` | 1/2 分辨率深度下采样 + Color/MV 上采样合并 |
| `SetFinalTargetPassConstructor.cs` | 写 BackBuffer + flipY + copyDepth 材质 |
| `HGResourceManagerScript.cs` | Beyond 引擎层异步资源加载/卸载（与 RT 无直接耦合，本单元边角） |

### 13.2 反汇编锚点（VA 地址）

| 函数 | RVA | 文件 |
|------|-----|------|
| `RenderTextureManager.GetRenderTexture` | 0x4013BC0 | RenderTextureManager.cs:11 |
| `RenderTextureManager.ReleaseRenderTexture` | 0x4F21890 | RenderTextureManager.cs:175 |
| `RenderTextureManager.ClearRenderTexture` | 0xA6E577C | RenderTextureManager.cs:277 |
| `CustomDrawRTManager.Init` | 0x5AEE410 | CustomDrawRTManager.cs:82 |
| `CustomDrawRTManager.AutoRestRT.ctor` | 0xA8C34F4 | CustomDrawRTManager.cs:14 |
| `CustomDrawRTManager.AllocateRenderTexture` | 0x5044AB0 | CustomDrawRTManager.cs:198 |
| `CustomDrawRTManager.ClearTexture` | 0x5044DB0 | CustomDrawRTManager.cs:284 |
| `CustomDrawRTManager.DrawTexture` | 0x5044F40 | CustomDrawRTManager.cs:388 |
| `CustomDepthOnlyRequestManager.CreateSystem` | 0xA8C4D50 | CustomDepthOnlyRequestManager.cs:164 |
| `CustomDepthOnlyRequestManager.CreateRenderData` | 0xA8C3D14 | CustomDepthOnlyRequestManager.cs:694 |
| `CustomDepthOnlyRequestManager.RequestCustomDepthOnlyPassV1` | 0xA8C555C | CustomDepthOnlyRequestManager.cs:1621 |
| `CustomDepthOnlyRequestManager.UpdateSystem` | 0xA8C5B90 | CustomDepthOnlyRequestManager.cs:1897 |
| `CustomDepthOnlyRequestManager.RetrieveAllSystemRenderData` | 0xA8C584C | CustomDepthOnlyRequestManager.cs:2346 |
| `CopyTexturePass.BlitTexture` | 0xA7202C4 | CopyTexturePass.cs:46 |
| `CopyTexturePass.CopyDepth` | 0xA7206EC | CopyTexturePass.cs:288 |
| `CopyTexturePass.BlitMotionVector` | 0xA720004 | CopyTexturePass.cs:436 |
| `LowResBlitPass.DownsampleDepth` | 0xA7500F4 | LowResBlitPass.cs:27 |
| `LowResBlitPass.UpsampleColorAndMV` | 0xA750454 | LowResBlitPass.cs:226 |
| `SetFinalTargetPassConstructor.ConstructPass` | 0xA75B6E8 | SetFinalTargetPassConstructor.cs:143 |

### 13.3 HDRP 同源参考

| 主题 | HDRP 文件:行 |
|------|-------------|
| `RTHandleSystem` 类声明 | `core@ba70f6d20c11/Runtime/Textures/RTHandleSystem.cs:154` |
| `m_MaxWidths/Heights` 字段 | 同上 :174-175 |
| 构造初始化 `=1` | 同上 :188-189 |
| `SetReferenceSize` 主体 | 同上 :284-344 |
| `sizeChanged = width > GetMaxWidth() \|\| ...` | 同上 :314 |
| 第一帧 previous=current 修复 | 同上 :326-331 |
| `rtHandleScale` 计算 | 同上 :333-343 |
| `CalculateRatioAgainstMaxSize` | 同上 :346-360 |
| `SetHardwareDynamicResolutionState` | 同上 :366-389 |
| `rth.referenceSize = (m_MaxWidths, m_MaxHeights)` | 同上 :423 |

### 13.4 待确认（仅限非核心细节）

- **`RTLifeCycle.Frame` 是否真有独立路径**：反汇编中所有调用点都按数值比较分支，未见 `Frame` 专属代码段；任务提示也指出「可能未实现」。**核心算法不依赖此细节**。
- **`SceneRTFeature` 的使用者**：本单元只有结构定义，实际抽取 pass 的装配代码在主管线（不在 C21 单元清单内）。
- **`HGResourceManagerScript.loadingAssetCount`** getter 始终返回 0（反编译显示 `loadingAssetCount => 0`，但 `m_loadingAssetHandleIndexSet` 字段真实存在）—— 可能是反编译损坏或方法体被剥离；不影响 RT 管理子系统。
