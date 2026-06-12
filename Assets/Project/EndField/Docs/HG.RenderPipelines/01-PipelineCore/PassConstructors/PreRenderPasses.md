# 净室实现文档: 预渲染Passes（Binning/Shadow/Culling）

## 概述

预渲染阶段（PreRender Passes）位于HG渲染管线光栅化主渲染循环之前，执行所有需要**场景深度/光源/阴影数据的准备工作**。这些Pass负责：

- **光源分簇（Binning）**：将屏幕划分为Tile，将影响每个Tile的光源/反射探针分配到对应Cluster
- **光源排序与聚类（Light Clustering）**：CPU端按优先级+距离对光源排序，选取前N盏可见光源
- **GPU Driven Culling**：Compute Shader对Instance进行视锥体裁剪 + HZB遮挡剔除
- **Shadow Map生成**：CSM级联阴影、点光源/聚光灯Atlas阴影、角色专用阴影
- **Capsule Shadow（胶囊体阴影）**：使用球体近似+SH可见性计算的角色阴影
- **Contact Shadow（接触阴影）**：屏幕空间Compute Shader光线步进接触阴影
- **Screen Space Shadow Mask**：屏幕空间阴影Mask合成
- **HZB构建**：深度层级金字塔下采样

所有Pass都实现 `IPassConstructor` 接口，通过 `RenderGraphModule` 注册。

---

## 1. BinningPass（光源分簇）

### 文件

- `HG/Rendering/Runtime/BinningPass.cs`

### 核心数据结构

```csharp
public struct BinningData
{
    public int tileSize;     // Tile尺寸（像素）
    public int tileX;        // X方向Tile数量
    public int tileY;        // Y方向Tile数量
    public int sliceZ;       // Z方向Slice数量（深度分层）
    public int xyOffset;     // XY方向偏移（字节偏移）
    public int zOffset;      // Z方向偏移
    public int uintCount;    // 每个Tile的光源索引数量（uint打包）
}
```

### 功能

- 通过 `BinningPass` 类管理两个独立的BinningData：`lightBinningData` 和 `reflectionProbeBinningData`
- 使用 `ComputeBufferHandle m_binningBuffer` 存储分簇结果
- 在Prepare阶段（`Prepare(HGRenderGraph renderGraph)`）计算Tile划分参数

### ComputeShader Tile Grid 分簇算法

1. **屏幕Tile划分规则**
   - 传入 `tileSize`（典型值16/32），计算 `tileX = ceil(screenWidth / tileSize)`, `tileY = ceil(screenHeight / tileSize)`
   - Z方向深度分层：`sliceZ` 由视锥体深度范围决定（例如Z = ceil(log2(far/near))）
   - 总Cluster数 = `tileX * tileY * sliceZ`

2. **光源分配到Tile**
   - 每个Compute Shader线程组处理一个Tile区域
   - 线程遍历所有光源，计算光源AABB与Tile平截头体（Frustum）的相交测试
   - 光源索引写入 `binningBuffer`，使用uint打包（每个uint存储多个索引）
   - 每个Cluster存储的光源索引数量上限由 `uintCount` 决定

3. **输出数据格式**
   - `binningBuffer`：`ComputeBufferHandle`，结构为 `uint[]`，按Tile排列
   - 每个Tile的数据布局：`[offset, count, indices...]`
   - `uintCount` 决定了每个Tile的最大uint数据量

### ReflectionProbeBinning 集成

- BinningPass内部也管理反射探针的BinningData（`reflectionProbeBinningData`）
- 与光源共用相同的Tile Grid结构，但Buffer不同
- 探针分配使用单独的Frustum Culling逻辑

---

## 2. ReflectionProbeBinningPassConstructor（反射探针分簇）

### 文件

- `HG/Rendering/Runtime/ReflectionProbeBinningPassConstructor.cs`
- `HG/Rendering/Runtime/ReflectionProbeBinningPassSetting.cs`

### 类结构

```csharp
internal class ReflectionProbeBinningPassConstructor : IPassConstructor
{
    private struct OctNode
    {
        public Cubemap texture;
        public float factor;
        // diff(OctNode other) - 比较纹理和系数是否不同
    }
    // ...
}
```

### Frustum Culling + 分簇

- 使用**八叉树（OctNode）**加速反射探针的空间划分
- 对每个屏幕Tile，计算影响该Tile的反射探针列表
- 探针选择基于：距离、重要性因子（factor）、与Tile Frustum的相交性
- 使用 `OctNode.diff()` 方法比较两个探针节点是否等效（纹理instance不同或factor差异超过阈值）

### 与BinningPass的异同

| 特性 | BinningPass | ReflectionProbeBinning |
|------|-------------|------------------------|
| 分配对象 | 点光源/聚光灯 | 反射探针（Cubemap） |
| 空间结构 | Tile Grid + Frustum | OctNode八叉树 + Frustum |
| 输出 | uint packed buffer | 探针索引 + LOD factor |
| 约束 | 按Cluster上限 | MAX_VISIBLE_COUNT = 32 |
| 质量缩放 | — | QUALITY_VISIBLE_COUNT 随品质设置 |

### 配置

```csharp
public static class ReflectionProbeBinningPassSetting
{
    public static int QUALITY_VISIBLE_COUNT;  // 可配置的可见探针数量（按品质）
    public const int MAX_VISIBLE_COUNT = 32;  // 硬上限
}
```

---

## 3. LightClusteringPass（光源聚类）

### 文件

- `HG/Rendering/Runtime/LightClusteringPassConstructor.cs`

### 类结构

```csharp
internal class LightClusteringPassConstructor : IDisposable, IPassConstructor
{
    private struct PunctualLightSortStruct : IComparable<PunctualLightSortStruct>
    {
        public int index;        // 光源索引
        public float distance;   // 到相机的距离
        private int priority;    // 光源优先级
        // 排序规则：先按priority倒序，再按distance升序
    }
}
```

### 距离+优先级排序算法

1. 对每一个逐点光源（点光源/聚光灯）构造 `PunctualLightSortStruct`
2. **排序规则**（`CompareTo`实现）：
   - 首先比较 `priority`（int），值**越大**优先级**越高**（降序）
   - 如果 `priority` 相同，比较 `distance`（float），**越近**越优先（升序）
3. 排序后选取**前N盏**（N取决于性能预算，通常为64~256）

### 前N盏可见光源选择

- 输入来自 `BinningPass` 的分簇结果 + `LightCullResult`
- 经过排序后的 `PunctualLightSortStruct` 数组只保留前N盏
- 输出用于后续阴影渲染和光照计算
- 实现 `IDisposable` 以释放NativeArray内存

---

## 4. GPUDrivenCullingPassConstructor（GPU驱动Culling）

### 文件

- `HG/Rendering/Runtime/GPUDrivenCullingPassConstructor.cs`

### 类结构

```csharp
internal class GPUDrivenCullingPassConstructor : IPassConstructor
{
    internal struct PassInput
    {
        public ComputeShader initShader;     // 初始化Shader
        public ComputeShader cullingShader;  // 裁剪Shader
        public ComputeShader cmdGenShader;   // 绘制命令生成Shader
        public TextureHandle hzb;            // HZB纹理
        public bool usePrevVP;               // 是否使用前一帧View-Projection
    }

    private class CullingPassData
    {
        public ComputeShader initShader;
        public ComputeShader cullingShader;
        public TextureHandle hzb;
        public uint hzbWidth;
        public uint hzbHeight;
        public HGCamera camera;
        public bool usePrevVP;
    }
}
```

### ComputeShader Instance Frustum Culling

1. **初始化阶段**（`initShader`）：将Instance数据的可见性标记初始化为 `VISIBLE`
2. **裁剪阶段**（`cullingShader`）：
   - 每个线程处理一个Instance
   - 使用 `camera` 的View-Projection矩阵构建视锥体六个平面
   - 将Instance的AABB/BoundingSphere与六个平面测试
   - 全部在平面内则标记为可见，否则标记为剔除
3. **可选前一帧VP**（`usePrevVP`）：用于时间复用或动态模糊

### HZB辅助遮挡剔除

- 输入HZB纹理（来自 `BuildHZBPass` 或 `HGHierarchicalZOcclusionCulling`）
- 在Frustum Culling之后执行HZB遮挡测试：
  - 将Instance AABB投影到屏幕空间，获取Z范围
  - 在HZB对应Mip Level采样深度
  - 如果AABB最小Z > HZB深度，则判定为遮挡
- `hzbWidth` / `hzbHeight` 用于计算屏幕空间投影的范围

### Instance 数据管理

- 输出为 `PassOutput`（空结构体），实际通过 `RenderFunc` 直接修改Instance的可见性标记位
- Culling结果写入 `ShaderVariablesGlobal`（全局Shader变量）

---

## 5. HGHierarchicalZOcclusionCulling（HZB遮挡剔除）

### 文件

- `HG/Rendering/Runtime/HGHierarchicalZOcclusionCulling.cs`

### 核心常量

```csharp
public const int DEPTH_BUFFER_RESOLUTION_X = 256;
public const int DEPTH_BUFFER_RESOLUTION_Y = 128;
private const int COMPUTE_SHADER_LOCAL_SIZE_X = 16;
private const int COMPUTE_SHADER_LOCAL_SIZE_Y = 8;
private const int DEPTH_BUFFER_MIP_COUNT = 8;   // 最大Mip层级
private const int DEPTH_BUFFER_COUNT = 3;        // 三重缓冲（帧同步）
private const int COMPUTE_SHADER_WORK_GROUP_X = 16;
private const int COMPUTE_SHADER_WORK_GROUP_Y = 16;
```

### 类结构

```csharp
public class HGHierarchicalZOcclusionCulling
{
    private readonly RTHandle[] m_hizDepthMipChains;     // HZB深度Mip链数组（三重缓冲）
    private ushort m_frameCounter;                       // 帧计数器
    private readonly ComputeShader m_hizDownSampleCS;    // 下采样ComputeShader
    private readonly int m_hizDownSampleKernel0;         // Kernel0（下采样）
    private readonly int m_hizDownSampleKernel1;         // Kernel1（下采样/特征保留）
    public RTHandle currentDepthMipChain { get; }       // 当前帧深度Mip链
}
```

### Hierarchical Z-Buffer 构建

1. **深度缓冲区规格**：固定分辨率为 `256×128`（低精度，用于遮挡测试）
2. **三重缓冲**（DEPTH_BUFFER_COUNT=3）：支持帧同步，避免GPU Read/Write冲突
3. **Mip链深度**：`DEPTH_BUFFER_MIP_COUNT=8`，从256×128逐级降到1×1
4. **帧计数器**：`m_frameCounter` (ushort) 用于轮转三重缓冲索引

### 深度下采样算法

- 使用两个Compute Shader Kernel：
  - `m_hizDownSampleKernel0`：标准下采样，取2×2像素内的最小深度/最大深度（可选）
  - `m_hizDownSampleKernel1`：特征保留下采样，可能使用边缘感知滤波
- 线程组大小：Work Group = 16×16，对应Local Size = 16×8
- 对每个Mip Level执行Dispatch：
  - 从上一级Mip读取深度，输出到当前Mip
  - 直到底层（1×1）为止

### Occlusion Test 算法

- 通过 `GPUDrivenCullingPassConstructor` 间接调用
- HZB纹理作为 `TextureHandle` 传入Culling Shader
- Bounding Box Test：将Instance的投影AABB与HZB采样深度比较
- 使用较高的Mip Level（更大纹素）加速测试，牺牲精度换取性能

---

## 6. ShadowMapPassConstructor（阴影贴图）

### 文件

- `HG/Rendering/Runtime/ShadowMapPassConstructor.cs`

### 类结构

```csharp
internal class ShadowMapPassConstructor : IPassConstructor
{
    internal struct PassInput
    {
        internal HGShadowManager shadowManager;        // 阴影管理器
        internal ScriptableRenderContext srpContext;    // SRP上下文
        internal CullingResults cullingResults;        // Unity Culling结果
        internal LightCullResult lightCullResult;      // 裁剪后的光源
        internal int directionalLightIndex;            // 方向光光源索引
        internal int punctualLightCount;               // 逐点光源数量
        internal unsafe int* punctualLightIndices;     // 逐点光源索引指针
        internal HGSettingParameters settingParams;    // 管线设置参数
        internal unsafe HGSettingParametersCpp* settingParamsCpp; // 原生参数指针
    }

    internal struct PassOutput
    {
        internal ShadowResult shadowResult; // 阴影结果
    }
}
```

### CSM 级联阴影（Directional Light）

- `m_samplerCSM` Profile Marker标记
- 渲染方向光的级联阴影贴图（Cascaded Shadow Maps）
- 级联数量、分辨率由 `HGSettingParameters` 配置
- 使用 `CullingResults` 中的方向光参数计算视锥体分割

### 点光源Atlas（Punctual Lights）

- `m_samplerPunctual` Profile Marker标记
- 遍历 `punctualLightIndices` 中的每个逐点光源索引
- 点光源使用**立方体阴影贴图**（Cube Shadow Map）或**双抛物面阴影贴图**
- 聚光灯使用**标准Shadow Map**（透视投影）
- 所有逐点光源共享一个Atlas（或使用单独的RT）
- 使用 `lightCullResult` 确定哪些光源需要阴影

### Profiler标记

```csharp
private ProfilerMarker m_samplerCSM;        // CSM渲染耗时
private ProfilerMarker m_samplerCharacter;  // 角色阴影渲染耗时
private ProfilerMarker m_samplerASM;        // Atlas Shadow Map渲染耗时
private ProfilerMarker m_samplerPunctual;   // 逐点光源阴影渲染耗时
```

---

## 7. HGLowResDirectionalShadowPass（低分辨率方向光阴影）

### 文件

- `HG/Rendering/Runtime/HGLowResDirectionalShadowPass.cs`

### 核心常量

```csharp
internal const int LOW_RES_SHADOW_DOWNSAMPLE_SCALE = 4;
internal const float LOW_RES_SHADOW_INV_DOWNSAMPLE_SCALE = 0.25f;
```

### 类结构

```csharp
public class HGLowResDirectionalShadowPass
{
    internal class HGLowResDirectionalShadowPassData
    {
        public float downSampleScale;                // 下采样比例（通常4）
        public Material lowResDirectionalShadowMat;  // 下采样材质
        public TextureHandle depthBuffer;            // 场景深度
        public TextureHandle lowResShadowTexture;    // 低分辨阴影纹理
    }

    internal class HGLowResShadowBlurPassData
    {
        public bool horizontalPass;                  // 水平/垂直模糊
        public Vector2Int rtResolution;              // RT分辨率
        public Material lowResShadowBlurMat;        // 模糊材质
        public TextureHandle lowResShadowTexture;    // 输入阴影纹理
        public TextureHandle lowResBlurredShadow;    // 输出模糊纹理
    }
}
```

### 阴影生成流程

1. **下采样**（`s_lowResDirectionalShadowPassRenderFunc`）：
   - 使用 `downSampleScale = 4` 将全分辨率深度缓冲区下采样到 1/4 分辨率
   - 材质 `lowResDirectionalShadowMat` 执行阴影计算（Shadow Mapping采样）
   - 输出到 `lowResShadowTexture`

2. **高斯模糊**（`s_lowResShadowBlurPassRenderFunc`）：
   - 分两次Pass：水平模糊（`horizontalPass=true`）和垂直模糊（`horizontalPass=false`）
   - 材质 `lowResShadowBlurMat` 执行 N×N 高斯滤波
   - `rtResolution` 控制模糊RT的尺寸
   - 最终输出 `lowResBlurredShadow` 用于屏幕空间阴影Mask

---

## 8. CapsuleShadow Pass（胶囊体阴影）

### 概述

Capsule Shadow系统由四个组件构成：

```
HGCapsuleShadowHelper (MonoBehaviour) — 绑定在角色上，定义胶囊体参数
    ↓ 注册到
HGCapsuleShadows (Singleton) — 全局管理所有Helper
    ↓ 数据收集
HGCapsuleShadowManager — 管理原始数据上传 + 材质 + Mesh
    ↓ 渲染
CapsuleShadowPassConstructor (Pass) — GPU渲染Pass
```

### 8a. HGCapsuleShadowHelper

**文件**：`HG/Rendering/Runtime/HGCapsuleShadowHelper.cs`

```csharp
public class HGCapsuleShadowHelper : MonoBehaviour, IHGInteractionObject
{
    public List<HGCapsuleShadowContainer> m_capsuleShadowContainers; // 胶囊体容器列表
    [Range(0f, 5f)] public float m_intensity;                        // 阴影强度
    public float m_ditherAlpha;                                      // Dither透明度
    [Min(0.05f)] public float m_feetSize;                           // 脚部尺寸
    [Range(-0.1f, 0.1f)] public float m_feetBaseTransformOffset;    // 脚部偏移（基底）
    [Range(-0.1f, 0.1f)] public float m_feetTargetTransformOffset;  // 脚部偏移（目标）
    public bool m_interactionOnly;                                    // 仅交互时启用
    public bool m_enableCCD;                                          // 启用CCD
    public float m_radiusScale;                                       // 半径缩放
    public float m_heightScale;                                       // 高度缩放
    public Vector3 m_centerOffset;                                    // 中心偏移
    public string[] m_skeletonName_*;  // 躯干/头部/四肢骨骼名称（用于自动绑定）
}
```

**骨骼绑定字段**：Hip_L/R, Knee_L/R, Ankle_L/R, ToesEnd_L/R, Shoulder_L/R, Wrist_L/R, Trunk, Head

**胶囊体结构**：`HGCapsuleShadowContainer` 定义每个胶囊体的位置/方向/半径/高度

### 8b. HGCapsuleShadows

**文件**：`HG/Rendering/Runtime/HGCapsuleShadows.cs`

```csharp
public class HGCapsuleShadows
{
    private static readonly Lazy<HGCapsuleShadows> s_Instance;  // 懒加载单例
    private static List<HGCapsuleShadowHelper> m_capsuleShadowHelpers;
    public static void EnqueueCapsuleShadowHelper(HGCapsuleShadowHelper helper); // 注册Helper
    public static int count => m_capsuleShadowHelpers.Count;
}
```

### 8c. HGCapsuleShadowManager

**文件**：`HG/Rendering/Runtime/HGCapsuleShadowManager.cs`

```csharp
public class HGCapsuleShadowManager
{
    private const int MAX_CAPSULE_NUM = 256;              // 最大胶囊体数量

    // 四个Vector4数组存储胶囊体参数（GPU传参）
    private NativeArray<Vector4> m_capsuleShadowData1;    // 位置 + 半径
    private NativeArray<Vector4> m_capsuleShadowData2;    // 方向 + 高度
    private NativeArray<Vector4> m_capsuleShadowData3;    // 颜色/强度
    private NativeArray<Vector4> m_capsuleShadowData4;    // 其他参数

    private NativeArray<Matrix4x4> m_capsuleStencilWriterMatrixes; // Stencil写入矩阵
    private Material m_capsuleShadowCasterMaterial;       // 阴影投射材质
    private Mesh m_sphereMesh;                            // 球体Mesh（近似胶囊体）
    private MaterialPropertyBlock m_capsuleShadowPropertyBlock;

    public Vector4 fakeSphericalLightSource;              // 假定的球形光源方向/位置
    public bool Enabled { get; }

    public void Initialize(Material capsuleShadowCasterMat, Mesh sphereMesh);
}
```

**数据组织**：每个胶囊体用4个 `Vector4` 存储全部参数：
- Data1: `(centerX, centerY, centerZ, radius)`
- Data2: `(dirX, dirY, dirZ, height)`
- Data3: `(intensity, ditherAlpha, feetSize, flags)`
- Data4: `(feetOffsetBase, feetOffsetTarget, radiusScale, heightScale)`

### 8d. CapsuleShadowPassConstructor

**文件**：`HG/Rendering/Runtime/CapsuleShadowPassConstructor.cs`

```csharp
internal class CapsuleShadowPassConstructor : IPassConstructor
{
    internal struct PassInput
    {
        public TextureHandle sceneDepth;       // 场景深度
        public TextureHandle sceneDepthCopied; // 复制深度
        public TextureHandle sceneMV;          // 运动向量
        public CullingResults cullingResults;
        public LightCullResult lightCullResult;
        public GBufferOutput gBufferOutput;
        public int directionalLightIndex;
        public float sphereIntervalScale;      // 球体间隔缩放
        public float sphereRangeScale;         // 球体范围缩放
        public bool enabled;
        public bool enableHalfRez;            // 半分辨率
        public GraphicsFormat depthFormat;
        public DepthBits depthBufferBits;
        public Material visibilitySHMaterial;  // SH可见性材质
    }
}
```

### 胶囊体近似算法

1. **球体堆叠近似**：将胶囊体近似为多个球体的集合（沿轴向）
2. Stencil Writer Pass：使用 `m_sphereMesh` 将每个球体写入Stencil Buffer
   - `m_capsuleStencilWriterMatrixes` 存储每个球体的世界矩阵
3. 球体的间隔和范围由 `sphereIntervalScale` 和 `sphereRangeScale` 控制

### 阴影投射

- **V2版本**（`CapsuleShadowPassDataV2`）：
  - 使用SH（Spherical Harmonics）可见性：`visibilitySHRT`（3D纹理） + `visibilitySHLut`（2D LUT） + `visibilityABLut`（2D LUT）
  - Constant Buffer：`visibilitySHCB` 和 `capsuleCBHandle` 传递参数
  - `visibilitySHRTDefault` 作为默认SH纹理后备
- 半分辨率模式（`enableHalfRez`）处理

### 角色专用阴影

- 通过骨骼名称绑定到角色骨架
- 每个角色可以有多个 `HGCapsuleShadowContainer` 定义不同的胶囊体（躯干/四肢/头部）
- 阴影投射使用 `fakeSphericalLightSource` 作为光源方向参考

---

## 9. ContactShadowPassConstructor（接触阴影）

### 文件

- `HG/Rendering/Runtime/ContactShadowPassConstructor.cs`

### 类结构

```csharp
internal class ContactShadowPassConstructor : IPassConstructor
{
    [Flags]
    private enum ContactShadowEnable
    {
        PipelineEnable = 1,      // 管线启用
        PlatformCapable = 2,     // 平台支持
        AllEnable = 3            // 全部启用
    }

    public struct DispatchData
    {
        public Vector3Int workgroupCount;   // 线程组数
        public Vector2Int workgroupOffset;  // 屏幕偏移
    }

    internal class ContactShadowPassDataV2
    {
        public int rayTracingKernel;                    // RT核心Kernel索引
        public ComputeShader shader;                    // Compute Shader
        public Vector4[] dataParams;                    // 参数数组
        public DispatchData[] dispatch;                 // 多区域Dispatch配置
        public int dispatchCount;                       // Dispatch次数
        public TextureHandle depthBufferHandle;         // 深度缓冲
        public TextureHandle contactShadowCurrHandle;   // 当前帧接触阴影纹理
    }
}
```

### SSAO风格接触阴影

- 核心算法：**Compute Shader光线步进（Ray Marching）**
- 对每个像素，沿光源方向在深度Buffer中步进采样
- 使用差异化的步长（先精细后粗糙，步长由 `m_contactShadowBilinearThreshold` 控制）
- 检测遮挡：比较步进位置的线性深度与深度Buffer采样值

### 屏幕空间计算

**配置参数**：
```csharp
private ContactShadowEnable m_contactShadowEnable;         // 启用标记
private float m_contactShadowIntensity;                     // 阴影强度
private float m_contactShadowSurfaceThickness;             // 表面厚度（穿透抑制）
private float m_contactShadowBilinearThreshold;            // 双线性过滤阈值
private int m_contactShadowContrast;                        // 对比度
private bool m_contactShadowIgnoreEdgePixels;              // 忽略边缘像素
private uint m_contactShadowFrameIndex;                    // 帧计数器
private readonly Vector4[] m_contactShadowParams;          // 参数（传递给GPU）
```

**多区域Dispatch**：
- 支持将屏幕划分为多个区域，每个区域独立Dispatch（`DispatchData[]`）
- 不同区域可以使用不同的步进参数
- `workgroupCount` = 区域内的线程组数量
- `workgroupOffset` = 区域在屏幕上的起始偏移

**光照方向**：沿 `PassInput.lightDir`（Vector4）方向进行步进

---

## 10. ScreenSpaceShadowMaskPassConstructor（屏幕空间阴影Mask）

### 文件

- `HG/Rendering/Runtime/ScreenSpaceShadowMaskPassConstructor.cs`

### 类结构

```csharp
internal class ScreenSpaceShadowMaskPassConstructor : IPassConstructor
{
    internal struct PassInput
    {
        public TextureHandle sceneDepth;
        public TextureHandle sceneDepthCopied;
        public TextureHandle gbuffer0;   // 标准GBuffer0
        public TextureHandle gbuffer1;   // 标准GBuffer1
        public bool screenSpaceShadowMaskEnabled;
        public float renderingScale;
    }

    internal class HGScreenSpaceShadowResolvePassData
    {
        public Material screenSpaceShadowResolveMat;  // 阴影解析材质
        public TextureHandle depthBuffer;
        public TextureHandle depthTexture;
        public TextureHandle gbuffer0;
        public TextureHandle gbuffer1;
        public TextureHandle lowResShadowTexture;     // 来自HGLowResDirectionalShadowPass
        public TextureHandle screenSpaceShadowResolveTexture; // 最终阴影Mask
    }
}
```

### 阴影Mask生成

1. **输入**：
   - 场景深度 `sceneDepth` / `sceneDepthCopied`
   - GBuffer法线（`gbuffer0`, `gbuffer1`）
   - 低分辨率方向光阴影 `lowResShadowTexture`（来自 `HGLowResDirectionalShadowPass`）
2. **解析**：
   - 使用材质 `screenSpaceShadowResolveMat` 执行全屏Pass
   - 结合深度和法线重建世界空间位置
   - 将低分辨率阴影插值/重构到全分辨率
   - 生成最终阴影Mask `screenSpaceShadowResolveTexture`

### 合成方式

- 在光照合成阶段（Lighting Pass）之前执行
- 阴影Mask是一个全屏纹理，表示每个像素是否在阴影中（或阴影衰减因子）
- `renderingScale` 控制阴影Mask的分辨率比例

---

## 11. BuildHZBPass（Hierarchical Z-Buffer构建）

### 文件

- `HG/Rendering/Runtime/BuildHZBPass.cs`

### 类结构

```csharp
public class BuildHZBPass : IPassConstructor
{
    internal struct PassInput
    {
        public TextureHandle depthTexture;  // 输入深度纹理
        public bool buildHZB;               // 是否构建HZB
    }

    internal struct PassOutput
    {
        public TextureHandle HZBTexture;    // 输出的HZB纹理
    }

    public struct CBufferData
    {
        public Vector4 textureSize;  // 当前Mip级别大小
        public Vector4 parentSize;   // 父级Mip大小
        public Vector4 param0;       // 其他参数（深度范围/缩放）
    }

    private class PassData
    {
        public Vector2Int depthTextureSize;   // 输入深度尺寸
        public Vector2Int HZBTextureSize;     // HZB基础Mip尺寸
        public TextureHandle depthTexture;    // 输入深度
        public TextureHandle HZBTexture;      // 输出HZB
        public ComputeShader computeShader;   // Compute Shader
    }
}
```

### 深度下采样算法

1. **输入**：场景深度纹理（`depthTexture`）
2. **HZB纹理**：从输入深度生成完整Mip Chain
   - Mip 0: 输入深度直接拷贝（或最小/最大深度采样）
   - Mip 1+: 使用ComputeShader逐级下采样
   - 每个线程组处理一个区域（如 8×8 像素）
   - 对2×2纹素取 **最大深度**（用于遮挡测试，保守结果）
3. **Double Buffering**：
   - `m_HZBTexture`（当前帧）和 `m_prevHZBTexture`（前一帧）
   - 前一帧HZB可用于帧间遮挡测试（时间复用）

### Mip构建策略

- 使用 `m_computeShader` 的Compute Shader
- 每级Mip Dispatch一个单独的Kernel
- `CBufferData` 通过Constant Buffer传递当前级和父级尺寸
- `buildHZB` 标志控制是否实际执行构建（否则复用前一帧HZB）

---

## 12. CustomDepthOnlyRequestManager（自定义深度请求管理）

### 文件

- `HG/Rendering/Runtime/CustomDepthOnlyRequestManager.cs`

### 类结构

```csharp
public class CustomDepthOnlyRequestManager
{
    public struct VSMSupport
    {
        public int shaderID;  // VSM Shader ID
    }

    public struct Request
    {
        public Vector3 rootPosition;         // 请求中心位置
        public Vector3 frustumSize;          // 平截头体大小
        public Vector2Int rtSize;            // RT尺寸
        public Vector2Int pageSize;          // 分页大小（VSM）
        public DepthBits depthBits;          // 深度位宽
        public GraphicsFormat format;        // 纹理格式
        public int depthRTShaderID;          // 深度RT Shader ID
        public int transformCBShaderID;      // 变换矩阵CB ID
        public bool includeDynamicObjects;   // 包含动态物体
    }

    internal struct VSMData
    {
        public TextureHandle vsmRT;     // VSM光滑阴影RT
        public int shaderID;
    }

    private struct PageInfo
    {
        public Vector2Int pageIndex;    // 页面索引
        public bool pageRoundIndex;     // 页面轮转索引
    }

    private struct DepthRefreshParams
    {
        public Vector4 params0;
        public Vector4 params1;
    }

    internal struct Transforms
    {
        public Matrix4x4 transform;         // 变换矩阵
        public Vector4 uvScrollOffset;      // UV滚动偏移
    }

    internal struct PerFrameData
    {
        public RTHandle depthOnlyRT;        // 深度RT
        public float cameraHeight;          // 相机高度
    }

    internal struct SystemData
    {
        public Request request;
        public OptionalData optionalData;
        public bool isValid;
        public bool paused;
    }
}
```

### 功能

- 管理其他系统（如粒子、特效）发起的自定义深度渲染请求
- 支持 **Virtual Shadow Map (VSM)**：通过 `PageInfo` 和 `VSMData` 进行分页管理
- 每个请求定义一个虚拟相机（`rootPosition` + `frustumSize`）和一个RT（`rtSize`）
- `depthRTShaderID` 和 `transformCBShaderID` 用于对接Shader系统
- `includeDynamicObjects` 决定是否渲染动态物体

---

## 数据流图

```
                                                        帧开始
    ┌───────────────────────────────────────────────────────┐
    │                  PreRender Passes                     │
    └───────────────────────────────────────────────────────┘
                              │
              ┌───────────────┼───────────────┐
              ▼               ▼               ▼
    ┌─────────────────┐ ┌─────────────────┐ ┌─────────────────┐
    │  BinningPass     │ │  BuildHZBPass   │ │ CustomDepthOnly │
    │  ──────────────  │ │  ──────────────  │ │ RequestManager  │
    │  Light Binning   │ │  Depth → HZB    │ │ ──────────────  │
    │  ReflProbe Binn. │ │  Mip Chain      │ │ VSM Page Mgmt   │
    │  → binningBuffer │ │  → HZBTexture   │ │ Custom Depths    │
    └────────┬─────────┘ └────────┬─────────┘ └─────────────────┘
              │                    │
              ▼                    ▼
    ┌─────────────────┐ ┌─────────────────────────────┐
    │LightClustering   │ │GPUDrivenCullingPassConstructor│
    │PassConstructor   │ │─────────────────────────────│
    │──────────────── │ │ 1. Init Shader              │
    │Priority+Distance │ │ 2. Frustum Cull             │
    │Sort → Top N     │ │ 3. HZB Occlusion Cull       │
    └────────┬─────────┘ │ 4. Cmd Gen Shader          │
              │          └──────────┬──────────────────┘
              │                     │
              ▼                     ▼
    ┌─────────────────────────────────────────────┐
    │          Shadow Rendering                   │
    ├─────────────────┬───────────────────────────┤
    │ ShadowMap        │ CapsuleShadow            │
    │ PassConstructor  │ PassConstructor          │
    │ ──────────────── │ ──────────────────────   │
    │ CSM Directional  │ Sphere-Stack Capsule     │
    │ Punctual Atlas   │ SH Visibility            │
    │ Focused Shadow   │ Half-Rez Option          │
    ├─────────────────┼───────────────────────────┤
    │ HGLowResDirectionalShadowPass                │
    │ ─────────────────                           │
    │ Downsample ×4 → Blur (H+V)                  │
    └─────────────────┴───────────────────────────┘
              │                     │
              ▼                     ▼
    ┌─────────────────┐ ┌────────────────────────────┐
    │ ContactShadow    │ │ScreenSpaceShadowMask       │
    │ PassConstructor  │ │PassConstructor             │
    │ ──────────────── │ │─────────────────────────  │
    │ RayMarching     │ │ Resolve LowResShadow      │
    │ ScreenSpace CS  │ │ + GBuffer → Full Mask     │
    └─────────────────┘ └────────────────────────────┘
              │                     │
              ▼                     ▼
    ┌──────────────────────────────────────────────┐
    │    → 输出到 LightLoop / Main Rendering        │
    │      - 可见光源列表                           │
    │      - 阴影贴图（ShadowResult）               │
    │      - 接触阴影纹理                          │
    │      - 屏幕空间阴影Mask                      │
    │      - HZB纹理（供后续遮挡剔除）              │
    │      - Instance可见性标记                    │
    └──────────────────────────────────────────────┘
```

### 数据依赖关系

| Pass | 输入 | 输出 | 消费者 |
|------|------|------|--------|
| BinningPass | 光源数据（CPU） | binningBuffer | LightClustering, ShadowMap |
| ReflectionProbeBinning | 探针数据 | 探针索引Buffer | Lighting |
| LightClusteringPass | binningBuffer | 排序后光源列表 | ShadowMap, Lighting |
| GPUDrivenCulling | Mesh AABB, HZB | Instance可见性 | DrawCommands |
| BuildHZBPass | DepthTexture | HZBTexture | GPUDrivenCulling, HZB |
| HGHierarchicalZOcclusionCulling | DepthBuffer | DepthMipChain | 遮挡测试 |
| ShadowMapPassConstructor | 光源列表 | ShadowResult | Lighting |
| HGLowResDirectionalShadow | DirectionalShadow | LowResShadow | ScreenSpaceShadowMask |
| CapsuleShadowPass | SceneDepth, CapsuleData | CapsuleShadow | Lighting |
| ContactShadowPass | SceneDepth, LightDir | ContactShadow | Lighting PostProcess |
| ScreenSpaceShadowMaskPass | SceneDepth, GBuffer, LowResShadow | ShadowMask | Lighting |
| CustomDepthOnlyRequestManager | 请求列表(Native) | DepthRTs | 特效系统 |

### 关键常量汇总

| 常量 | 值 | 所在模块 |
|------|-----|---------|
| `LOW_RES_SHADOW_DOWNSAMPLE_SCALE` | 4 | HGLowResDirectionalShadowPass |
| `MAX_CAPSULE_NUM` | 256 | HGCapsuleShadowManager |
| `MAX_VISIBLE_COUNT` | 32 | ReflectionProbeBinningPassSetting |
| `DEPTH_BUFFER_RESOLUTION_X` | 256 | HGHierarchicalZOcclusionCulling |
| `DEPTH_BUFFER_RESOLUTION_Y` | 128 | HGHierarchicalZOcclusionCulling |
| `DEPTH_BUFFER_MIP_COUNT` | 8 | HGHierarchicalZOcclusionCulling |
| `DEPTH_BUFFER_COUNT` | 3 | HGHierarchicalZOcclusionCulling |
| `COMPUTE_SHADER_WORK_GROUP_X` | 16 | HGHierarchicalZOcclusionCulling |
| `COMPUTE_SHADER_WORK_GROUP_Y` | 16 | HGHierarchicalZOcclusionCulling |
| `COMPUTE_SHADER_LOCAL_SIZE_X` | 16 | HGHierarchicalZOcclusionCulling |
| `COMPUTE_SHADER_LOCAL_SIZE_Y` | 8 | HGHierarchicalZOcclusionCulling |
