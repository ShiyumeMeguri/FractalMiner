# Special Effects Passes - 技术架构文档

> 本文档基于 `HG.RenderPipelines.Runtime` 命名空间下的25个源文件生成。
> 所有源文件位于: `HG\Rendering\Runtime\`
> 说明: 方法体由 IFix 补丁/IL2CPP 原生调用承担,C# 层保留类定义、字段、结构体成员、方法签名等可观测元数据。
> 本文档以这些类型/字段/枚举/结构体布局与 shader 为依据,描述架构复刻参考要点。

---

## 目录

1. [墨水模拟 (Ink Manager & Simulation)](#1-墨水模拟)
2. [泥浆效果 (Sludge Manager & Simulation)](#2-泥浆效果)
3. [地形变形 (Terrain Deform)](#3-地形变形)
4. [VirtualTexture 烘焙 (Terrain VT Bake)](#4-virtualtexture-烘焙)
5. [GPU 粒子系统 (GPU Particle System)](#5-gpu-粒子系统)
6. [植被交互 (Foliage Interactive)](#6-植被交互)
7. [植被遮挡 (Foliage Occluder)](#7-植被遮挡)
8. [GPU 布料模拟 (GPU Cloth Simulation)](#8-gpu-布料模拟)
9. [大气散射/天空 (Atmosphere & Sky)](#9-大气散射天空)
10. [体积云 (Volumetric Cloud)](#10-体积云)
11. [水体渲染 (Water Sector & Interaction)](#11-水体渲染)
12. [环境管理 (Environment Manager)](#12-环境管理)

---

## 1. 墨水模拟

### 文件
- `HGInkManager.cs`
- `InkSimulationPassConstructor.cs`

### HGInkManager
**类**: `HGInkManager`
- **命名空间**: `HG.Rendering.Runtime`
- **角色**: 管理墨水模拟的全局状态

**关键字段**:
```csharp
public class HGInkManager {
    // 每像素墨水数据（四通道：颜色RGB + 强度A）
    internal TextureFormat inkSimulationTextureFormat;  // RGBA32
    internal Vector2Int inkSimulationTextureSize;       // 模拟纹理尺寸
    internal RenderTextureFormat inkSimulationRenderTextureFormat;
    internal ComputeBufferHandle inkSimulationDispatchBuffer;
    internal ComputeBufferHandle inkSimulationIndirectBuffer;

    // 场景中所有墨水发射器
    internal List<HGInkSplashData> inkSplashDatas;
    internal int inkSimulationPingPongIndex;           // 双缓冲索引

    // 配置参数
    internal bool enableInkSimulation;
    internal float inkViscosity;        // 墨水粘度
    internal float inkDiffusionSpeed;   // 扩散速度
    internal float inkEvaporationRate;  // 蒸发速率
    internal float inkDecayRate;        // 衰减速率
}
```

**关键方法**:
- `GetSplashCount()`: 返回当前墨水发射器数量
- `GetSplashData(int index)`: 获取指定索引的墨水发射数据

### InkSimulationPassConstructor
**类**: `InkSimulationPassConstructor` : `IPassConstructor`

**Pass Input/Output**:
```csharp
struct PassInput {
    TextureHandle inkResult;            // 上帧墨水结果纹理
}

struct PassOutput {
    // 无显式输出 - 渲染图传递
}
```

**PassData** (传递给渲染函数):
```csharp
class InkSimulationPassData {
    internal ComputeShader inkSimulationCS;           // GPU模拟ComputeShader
    internal int inkSimulationKernelId;               // 模拟主Kernel ID
    internal Vector2Int inkSimulationTextureSize;
    internal ComputeBufferHandle simulationDispatchBuffer;
    internal ComputeBufferHandle indirectBuffer;
    internal TextureHandle prevInkResult;             // 上一帧结果
    internal TextureHandle curInkResult;              // 当前帧结果
}
```

**架构复刻参考要点**:
1. 使用 ComputeShader 在GPU上进行墨水模拟
2. 双缓冲纹理 (PingPong) 实现逐帧迭代
3. 每个像素模拟: 扩散(拉普拉斯卷积) + 粘度(阻尼) + 蒸发(衰减)
4. 发射器通过 `inkSplashDatas` 列表注入初始墨水
5. 使用 `ComputeBufferHandle` 管理GPU缓冲区
6. 通过 `HGRenderGraphBuilder` 设置 ComputeShader 的常量缓冲区和读写纹理

---

## 2. 泥浆效果

### 文件
- `HGSludgeManager.cs`
- `SludgePassConstructor.cs`

### HGSludgeManager
**类**: `HGSludgeManager`
- **角色**: 管理泥浆溅射效果的全局状态

**关键字段**:
```csharp
public class HGSludgeManager {
    internal TextureFormat sludgeSimulationTextureFormat;
    internal Vector2Int sludgeSimulationTextureSize;
    internal RenderTextureFormat sludgeSimulationRenderTextureFormat;
    internal ComputeBufferHandle sludgeSimulationDispatchBuffer;
    internal ComputeBufferHandle sludgeSimulationIndirectBuffer;

    internal List<HGSludgeSplashData> sludgeSplashDatas;
    internal int sludgeSimulationPingPongIndex;

    internal bool enableSludgeSimulation;
    internal float sludgeViscosity;
    internal float sludgeDiffusionSpeed;
    internal float sludgeStickiness;       // 泥浆附着力(比墨水更强)
}
```

### SludgePassConstructor
**类**: `SludgePassConstructor` : `IPassConstructor`

**类似结构**:
```csharp
class SludgePassData {
    internal ComputeShader sludgeSimulationCS;
    internal int sludgeSimulationKernelId;
    internal Vector2Int sludgeSimulationTextureSize;
    internal ComputeBufferHandle dispatchBuffer;
    internal ComputeBufferHandle indirectBuffer;
    internal TextureHandle prevSludgeResult;
    internal TextureHandle curSludgeResult;
}
```

**架构复刻参考要点**:
1. 与墨水模拟架构高度相似，同为 ComputeShader 驱动的流体模拟
2. 泥浆比墨水有更高的粘度和附着力
3. 额外的 `sludgeStickiness` 参数控制泥浆沿表面的附着行为
4. 使用相同的双缓冲纹理、间接分派模式

---

## 3. 地形变形

### 文件
- `HGTerrainDeformManager.cs`
- `TerrainDeformPassConstructor.cs`

### HGTerrainDeformManager
**类**: `HGTerrainDeformManager`
- **角色**: 管理地形变形(车辙、脚印等)效果

**关键字段**:
```csharp
public class HGTerrainDeformManager {
    internal TextureFormat deformTextureFormat;          // 变形纹理格式
    internal Vector2Int deformTextureSize;
    internal List<HGTerrainDeformData> terrainDeformData; // 变形数据
    internal int terrainDeformPingPongIndex;

    // 变形缓冲（高度图和法线图）
    internal TextureHandle terrainDeformHeightTexture;
    internal TextureHandle terrainDeformNormalTexture;

    internal bool enableTerrainDeform;
    internal float deformStrength;       // 变形强度
    internal float deformRadius;         // 变形半径
    internal float deformHardness;       // 变形硬度
    internal float deformRecoverSpeed;   // 变形恢复速度
}
```

### TerrainDeformPassConstructor
**类**: `TerrainDeformPassConstructor` : `IPassConstructor`

**PassData**:
```csharp
class TerrainDeformPassData {
    internal ComputeShader terrainDeformCS;
    internal int terrainDeformApplyKernel;
    internal int terrainDeformRecoverKernel;
    internal TextureHandle prevHeightTexture;
    internal TextureHandle curHeightTexture;
    internal ComputeBufferHandle deformDataBuffer;
}
```

**架构复刻参考要点**:
1. 使用高度图(R16)和法线图(RGBA32)表示地形变形
2. 变形通过 ComputeShader 更新高度图：在变形点周围应用高斯衰减凹陷
3. 恢复机制：地形随时间缓慢回弹至原始高度
4. 使用双缓冲避免读写冲突
5. 法线图从高度图通过 Sobel 等梯度算子派生

---

## 4. VirtualTexture 烘焙

### 文件
- `TerrainVTBakePassConstructor.cs`

### TerrainVTBakePassConstructor
**类**: `TerrainVTBakePassConstructor` : `IPassConstructor`

**PassData**:
```csharp
class TerrainVTBakePassData {
    internal ComputeShader bakeCS;
    internal int bakeKernelId;
    internal Vector2Int tileSize;
    internal Vector2Int atlasSize;
    internal TextureHandle sourceAlbedoTexture;
    internal TextureHandle sourceNormalTexture;
    internal TextureHandle sourceMaskTexture;
    internal TextureHandle outputVTAtlas;
    internal ComputeBufferHandle tileRequestBuffer;
    internal ComputeBufferHandle tileFeedbackBuffer;
}
```

**架构复刻参考要点**:
1. Virtual Texture 的页面烘焙Pass
2. 接收CPU/GPU反馈的 tile 请求，动态烘焙地形材质到 VT 图集
3. 支持漫反射、法线、遮罩三个通道的独立烘焙
4. 使用 ComputeShader 将源纹理按 tile 粒度写入 VT 图集
5. 支持 mipmap 级别的选择

---

## 5. GPU 粒子系统

### 文件
- `GPUParticleSystemManager.cs`
- `GPUParticleSimulationPassConstructor.cs`
- `GPUParticleSystem.cs`
- `GPUParticleShaders.cs`
- `GPUParticleSystemBase.cs`

### GPUParticleSystemManager
**类**: `GPUParticleSystemManager`
- **角色**: 管理所有GPU粒子系统的全局状态

**关键字段**:
```csharp
public class GPUParticleSystemManager {
    internal List<GPUParticleSystem> activeParticleSystems;
    internal ComputeBuffer particleDataBuffer;      // 所有粒子的连续缓冲区
    internal ComputeBuffer particleAliveListBuffer;  // 存活粒子索引
    internal ComputeBuffer particleDeadListBuffer;   // 死亡粒子索引
    internal ComputeBuffer particleCountBuffer;      // 粒子计数(用于间接分派)
    internal int maxParticleCount;                   // 全局最大粒子数
}
```

**关键方法**:
- `Update(float deltaTime)`: 更新所有粒子系统
- `SpawnParticles(GPUParticleSpawnData spawnData)`: 产生新粒子

### GPUParticleSimulationPassConstructor
**类**: `GPUParticleSimulationPassConstructor` : `IPassConstructor`

**PassData**:
```csharp
class ParticleSimulationPassData {
    internal ComputeShader particleUpdateCS;
    internal int emitKernelId;
    internal int simulateKernelId;
    internal int sortKernelId;
    internal ComputeBufferHandle particleBuffer;
    internal ComputeBufferHandle aliveListBuffer;
    internal ComputeBufferHandle deadListBuffer;
    internal ComputeBufferHandle countBuffer;
    internal TextureHandle noiseTexture;           // 噪声场纹理
    internal float deltaTime;
}
```

### GPUParticleSystem
**类**: `GPUParticleSystem` (继承自 `GPUParticleSystemBase`)
- **角色**: 单个粒子系统的实例

**关键字段**:
```csharp
public class GPUParticleSystem {
    internal int particleCount;
    internal int startIndex;            // 在全局缓冲区中的起始索引
    internal GPUParticleEmitterData emitterData;
    internal GPUParticleRenderData renderData;
    internal Mesh particleMesh;         // 粒子渲染网格
    internal Material particleMaterial;
}
```

### GPUParticleShaders
**类**: `GPUParticleShaders` (静态)
- **角色**: 管理粒子相关的 Shader 和属性ID

**关键字段**:
```csharp
public static class GPUParticleShaders {
    internal static ComputeShader particleUpdateCS;
    internal static int emitKernel;
    internal static int simulateKernel;
    internal static int sortKernel;
    internal static int _ParticleDataBuffer;
    internal static int _ParticleCountBuffer;
}
```

### GPUParticleSystemBase
**类**: `GPUParticleSystemBase`
- **角色**: 粒子系统的基类，提供通用功能和生命周期

**关键字段**:
```csharp
public abstract class GPUParticleSystemBase {
    internal bool isPlaying;
    internal bool isPaused;
    internal float simulationSpeed;
    internal int maxParticles;
}
```

**架构复刻参考要点**:
1. 完全GPU驱动的粒子系统，C#端仅负责管理和数据上传
2. 使用双缓冲(存活/死亡列表)实现高效的粒子生成和回收
3. 粒子更新在 ComputeShader 中完成：发射、物理模拟、碰撞、生命周期
4. 初始化时预分配最大粒子数的连续缓冲区
5. 利用 Append/Consume 缓冲区实现无锁并行粒子分配
6. 支持间接分派渲染（通过 `Graphics.DrawMeshInstancedIndirect`）

---

## 6. 植被交互

### 文件
- `HGFoliageInteractiveManager.cs`
- `FoliageInteractivePassConstructor.cs`

### HGFoliageInteractiveManager
**类**: `HGFoliageInteractiveManager`
- **角色**: 管理植被(草/树)与角色/物体的交互效果

**关键字段**:
```csharp
public class HGFoliageInteractiveManager {
    internal TextureHandle interactiveHeightTexture;    // 交互高度图
    internal TextureHandle interactiveNormalTexture;    // 交互法线图
    internal Vector2Int interactiveTextureSize;
    internal Matrix4x4 interactiveWorldToTexture;       // 世界空间->纹理空间变换

    internal List<HGFoliageInteractiveData> interactiveDatas;
    internal bool enableFoliageInteractive;
    internal float interactStrength;
    internal float interactRadius;
    internal float interactRecoverSpeed;
}
```

### FoliageInteractivePassConstructor
**类**: `FoliageInteractivePassConstructor` : `IPassConstructor`

**PassData**:
```csharp
class FoliageInteractivePassData {
    internal ComputeShader foliageInteractiveCS;
    internal int applyKernelId;
    internal int recoverKernelId;
    internal TextureHandle prevInteractiveTexture;
    internal TextureHandle curInteractiveTexture;
    internal ComputeBufferHandle interactiveDataBuffer;
    internal int interactiveDataCount;
}
```

**架构复刻参考要点**:
1. 维护一张覆盖指定区域的交互纹理(高度/法线)
2. 角色/物体移动时，在交互纹理上绘制轨迹
3. 植被着色器采样此纹理驱动草叶弯曲
4. 交互数据随时间逐渐恢复(弹性复位)
5. 使用 ComputeShader 批量更新交互纹理

---

## 7. 植被遮挡

### 文件
- `HGFoliageOccluderManager.cs`
- `FoliageOccluderPassConstructor.cs`

### HGFoliageOccluderManager
**类**: `HGFoliageOccluderManager`
- **角色**: 管理植被遮挡剔除系统

**关键字段**:
```csharp
public class HGFoliageOccluderManager {
    internal bool enableFoliageOcclusion;
    internal float occluderBoundsExpand;          // 遮挡体包围盒扩展
    internal Matrix4x4 occluderWorldToTexture;
    internal TextureHandle occluderTexture;        // 遮挡物渲染纹理
}
```

**关键方法**:
- `GetParams()`: 返回 `OccluderParams` 结构体

### FoliageOccluderPassConstructor
**类**: `FoliageOccluderPassConstructor` : `IPassConstructor`

**内部类与结构**:
```csharp
internal struct PassInput { }
internal struct PassOutput { }

internal class FoliageOccluderPassData {
    internal Material blitMat;
    internal MaterialPropertyBlock blitMaterialPropertyBlock;
    internal TextureHandle prevFinalTexture;
    internal TextureHandle curFinalTexture;
    internal TextureHandle occluderRenderTexture;
    internal uint ecsRendererList;    // ECS渲染器列表句柄
}
```

**私有字段**:
```csharp
private RTHandle m_foliageOccluderRenderTexture;
private RTHandle m_foliageOccluderMaskA;
private RTHandle m_foliageOccluderMaskB;
private MaterialPropertyBlock m_blitFoliageOccluderPropertyBlock;
private Material m_occluderMaterial;
private Mesh m_occluderMesh;
private Material m_blitMaterial;
private bool m_renderFirstFrame;
private bool m_renderTextureInitialized;
```

**三个渲染函数**:
- `s_foliageOccluderRenderPass`: 渲染遮挡物到纹理
- `s_foliageOccluderBlitPass`: 将当前遮挡结果混合到历史纹理
- `s_setFinalMaskPass`: 设置最终遮罩

**架构复刻参考要点**:
1. 三阶段Pass:
   - **遮挡渲染**: 将植被渲染到 `occluderRenderTexture` 作为遮挡缓冲区
   - **遮挡混合**: 使用 `blitMat` 将当前帧与历史帧混合（时间抗锯齿/平滑）
   - **最终遮罩**: 将混合结果写入最终遮罩纹理
2. 使用双缓冲 `maskA`/`maskB` 实现时间累积
3. 通过 `HGCullingSystem.AddCullViewByPlanes` 创建视锥体裁剪
4. 使用 `HGFoliageOccluderRender.CreateRendererList` 创建ECS渲染器列表
5. 遮挡信息供植被着色器做逐像素剔除

---

## 8. GPU 布料模拟

### 文件
- `GpuClothManager.cs`
- `GpuClothSimulationPassConstructor.cs`

### GpuClothManager
**类**: `GpuClothManager`
- **角色**: 管理GPU布料模拟的所有数据

**常量**:
```csharp
public const int MAX_ANCHOR_NUM = 2;
public const int MAX_NEIGHBOR_NUM = 8;
public const int MAX_CLOTH_NEIGHBOR_NUM = 128;
public const int CLOTH_BATCH_SIZE = 256;
public const int MAX_COLLIDER_NUM = 4;
public const int MAX_RUNTIME_CLOTH_GROUP_NUM = 50;
internal const float PHYSICS_DELTA_TIME = 0.023333333f;  // ~1/43
```

**关键字段**:
```csharp
public class GpuClothManager {
    internal ClothConstData clothConstData;
    internal ComputeBuffer clothNodeDataBuffer;
    internal ComputeBuffer clothMetaDataBuffer;
    internal ComputeBuffer clothBatchMetaDataBuffer;
    internal ComputeBuffer clothBatchCacheMapBuffer;
    internal ComputeBuffer clothSkeletonDataBuffer;
    internal GpuClothRenderData renderData;
    internal GpuClothClearBufferData clearBufferData;

    internal bool isStreamingMode;
    internal float gameplayDt;
    internal float cumulativeTime;
    internal bool shouldStep;
    internal float loopNum;
    internal float windTime;
    internal float windSpeed;
    internal Vector2 windNoiseUV;

    private NativeParallelHashMap<uint, ClothGroupData_Internal> m_registedClothGroupData;
    private NativeParallelHashMap<uint, ClothGroupMeta_Internal> m_activatedGroupHashToGroupMeta;
    private NativeParallelHashMap<uint, RuntimeClothData_Internal> m_clothHashToRuntimeClothData;
}
```

**内部结构**:
```csharp
struct ClothGroupMeta_Internal {
    ClothGroupMeta clothGroupMeta;
    int cellIdx;
    unsafe fixed int clothMetaIdx[4];
}

struct ClothGroupData_Internal {
    ClothGroupMeta clothGroupMeta;
    unsafe byte* groupClothMetaBytes;
    int groupClothMetaBytesSize;
    unsafe byte* groupClothNodeBytes;
    int groupClothNodeBytesSize;
    unsafe byte* groupClothBatchMetaBytes;
    int groupClothBatchMetaBytesSize;
    unsafe byte* groupClothBatchCacheBytes;
    int groupClothBatchCacheBytesSize;
}
```

**关键方法**:
- `Initialize(...)`: 初始化，设置角色代理网格
- `Tick(float deltaTime)`: 每帧更新，包括风参数更新
- `RegisterClothGroup(...)`: 注册布料组
- `ActivateClothGroup(uint hash)`: 激活布料组
- `DeactivateClothGroup(uint hash)`: 停用布料组
- `_UpdateWindParams()`: 从 `HGEnvironmentManager` 获取风数据更新风参数
- `_ProcessPendingQueue()`: 处理激活/停用队列

### GpuClothSimulationPassConstructor
**类**: `GpuClothSimulationPassConstructor` : `IPassConstructor`

**三个内部PassData类**:
```csharp
class ClearPassData {
    internal int clothClearCSHandle;
    internal ComputeShader clearCS;
    internal IVec4 eleNum;
    internal uint clothNodeDataBufferID;
    internal uint clothBatchMetaDataBufferID;
    internal uint clothBatchCacheMapBufferID;
}

class UploadPassData {
    internal int clothUploadCSHandle;
    internal ComputeShader clothUploadCS;
    internal IVec4 uploadConstData;
    internal unsafe ClothMetaDataCPP* clothMetaUploadData;
    internal unsafe ClothNodeDataCPP* clothNodeUploadData;
    // ... 更多上传数据指针和缓冲区ID
}

class PassData {
    internal int clothNum;
    internal ClothConstDataCPP clothConstData;
    internal int clothSingleDispatchCSHandle;
    internal ComputeShader clothSingleDispatchCS;
    internal uint clothNodeDataBufferID;
    internal uint clothMetaDataBufferID;
    internal uint clothBatchMetaDataBufferID;
    internal uint clothBatchCacheMapBufferID;
    internal uint clothSkeletonDataBufferID;
}
```

**架构复刻参考要点**:
1. 四个子Pass按序执行:
   - **Clear**: 清除布料缓冲区（清零节点数据）
   - **Upload**: 上传 CPU 端更新的布料数据(元数据、节点数据、批次数据)到GPU
   - **Simulation**: 执行布料物理模拟 ComputeShader
   - **SetDefault**: 当无活跃布料时设置默认骨架缓冲区
2. 布料物理使用位置约束动力学(PBD)，在GPU上实现
3. 风参数从 `HGEnvironmentManager` 获取，支持时间变化的噪声风场
4. 通过 `HGGpuClothManagerV2` 获取内部C++数据句柄
5. 支持流式加载/卸载布料组(LOD距离管理)
6. 三步数据上传：meta、node、batch缓存映射
7. 常量缓冲区动态分配 (`_AllocateConstBuffer`, `_AllocateClothNodeConstBuffer`)

---

## 9. 大气散射/天空

### 文件
- `HGAtmosphereRenderer.cs`
- `HGSkyRenderer.cs`
- `HGSkydomeStarRenderer.cs`

### HGAtmosphereRenderer
**类**: `HGAtmosphereRenderer`
- **角色**: 大气散射LUT(查找表)的渲染和全局大气雾效

**关键结构**:
```csharp
public struct AtmosphereLutConstants {
    Vector4 _AtmosphereLutParams0 到 _AtmosphereLutParams11;
    // 12个Vector4，包含大气散射参数
}
```

**关键字段**:
```csharp
public class HGAtmosphereRenderer {
    public static bool forceRenderAtmosphereLutEveryFrame;
    private static Texture2D s_defaultFogBakeLUT;
    public static bool useOctahedronSkyViewLut => false;
}
```

**关键方法**:
- `GetSkyViewLutWidth/Height(...)`: 获取天空视图LUT尺寸
- `ShouldRenderAtmosphereLutUsingCompute(...)`: 判断是否使用ComputeShader渲染LUT
- `SetupShaderVariablesGlobalAtmosphereFog(...)`: 设置大气雾全局着色器变量
- `ResetShaderVariablesGlobalAtmosphereFog(...)`: 重置大气雾参数
- `SetupShaderVariablesGlobalHeightFog(...)`: 设置高度雾全局参数
- `SetupRenderHeightFogFlowNoiseParam(...)`: 设置高度雾流动噪声
- `ShouldRenderAtmosphereLut(...)`: 判断是否需要重新渲染大气LUT
- `RenderAtmosphereLut(...)`: 渲染大气散射LUT(transmittance, sky-view, multi-scattered luminance)

**架构复刻参考要点**:
1. 预计算大气散射LUT: transmittance lut, sky-view lut, multi-scattered luminance lut
2. 支持 ComputeShader 或 PixelShader 两种渲染路径
3. `AtmosphereLutConstants` 包含 12 个 Vector4 的完整散射参数
4. 高度雾从 `HGEnvironmentPhase` 获取当前环境阶段数据
5. 流动噪声支持，通过 `_HEIGHT_FOG_FLOW_NOISE` keyword 控制
6. 所有着色器变量通过 `PackVector4` 打包写入 `ShaderVariablesGlobal`

### HGSkyRenderer
**类**: `HGSkyRenderer`
- **角色**: 天空渲染(程序化天空、星体、云)

**关键结构**:
```csharp
public struct PlanetBillBoardConstants {
    float _RealPlanetRadius;
    float _AtmosphereRatios;
    float _GlobalRadiusOffset;
    float _Density_Multiplier;
    float _g;                   // Mie散射不对称因子
    float _StepsI;              // 内散射采样步数
    float _StepsL;              // 外散射采样步数
    float _Mie_Height_Scale;
    // ... 更多大气/云参数
    Vector4 _Ray, _Mie, _Ambient;
    Vector4 _PlanetWSBase, _BBWSBase, _PlanetScale;
    Vector4 _FresnelColor, _TintColor;
    Vector4 _SeaDeep, _SeaShallow;
    Vector4 _IndirectColor;
    Vector4 _CustomLightDir, _CustomLightColPla;
    Vector4 _CloudsShadowColor;
    Vector4 _BaseColorMap_ST, _ErosionMap_ST;
}
```

**关键字段**:
```csharp
public class HGSkyRenderer {
    private Mesh m_IcosphereMesh;             // 天球网格
    private Material m_renderAtmosphereLutMaterial;
    private Material m_proceduralSkyMaterial;
    private Material m_skyBoxCubemapMaterial;
    private Material m_skyboxMaterialCPP;     // C++侧天空盒材质
    private Material m_skyCloudMaterialCPP;   // C++侧云材质
    private readonly MaterialPropertyBlock m_propertyBlock;
}
```

**关键方法**:
- `GetSkyDistance(HGCamera)`: 获取天空距离(从环境阶段读取)
- `GetSkyScale(HGCamera)`: 获取天空缩放
- `ShouldRenderSkybox/Celestial/Cloud(...)`: 判断各组件是否需要渲染
- `PrepareCPPInput(...)`: 准备C++侧渲染输入
- `Render(...)`: 主渲染入口(选择程序化天空或天空盒)
- `RenderProceduralSky(...)`: 渲染程序化天空（云、星体、光环、太阳盘）

**架构复刻参考要点**:
1. 支持两种天空模式: 程序化天空 + Cubemap天空盒
2. 程序化天空使用 Icosphere 网格，包含云层、行星、光环、太阳盘
3. 行星使用 `PlanetBillBoardConstants` 结构体，包含完整的大气/云参数
4. 关键字系统管理云层渲染模式
5. 通过 `HGEnvironmentManager.GetInterpolatedPhase` 获取当前环境阶段
6. 使用 `MaterialPropertyBlock` 传递逐实例参数

### HGSkydomeStarRenderer
**类**: `HGSkydomeStarRenderer`
- **角色**: 渲染天穹星星/行星

**关键字段**:
```csharp
public class HGSkydomeStarRenderer {
    private HGSkydomeStarRenderingData[] starData;  // 每个天体的渲染数据
    private Mesh m_starMesh;
}
```

**关键类**:
```csharp
public class HGSkydomeStarRenderingData {
    public Material drawMaterial;
    public Matrix4x4 drawMatrix;
}
```

**关键方法**:
- `CheckRuntimeResources(int index)`: 检查指定索引的运行时资源是否有效
- `_RenderStar(...)`: 渲染单个星体(含关键字设置、参数计算)
- `RenderStar(...)`: 渲染所有可见星体

**架构复刻参考要点**:
1. 星体作为天空远场对象渲染，使用专用 Mesh
2. 通过 `HGEnvironmentPhase` 获取星体配置（位置、颜色、大小）
3. 每个星体计算世界空间变换矩阵(TRS)
4. 支持大气/环/纹理模式切换（通过 Shader Keyword）
5. 类型常量（`TALOS_RT_RESOLUTION=2048`, `PLANET_ALPHA_RT_RESOLUTION=1024`）

---

## 10. 体积云

### 文件
- `VolumetricCloudPassConstructor.cs`

### VolumetricCloudPassConstructor
**类**: `VolumetricCloudPassConstructor` : `IPassConstructor`

**Pass Input/Output**:
```csharp
internal struct PassInput {
    TextureHandle sceneColor;           // 场景颜色
    TextureHandle sceneDepth;           // 场景深度
    TextureHandle sceneDepthCopied;     // 深度副本(用于历史)
    HGVolumetricCloudSettingParameters volumetricParameters;
    List<IVolumetricRenderObject> volumetricRenderObjects;
}

internal struct PassOutput { }
```

**PassData**:
```csharp
public class VolumetricCloudPassPassData {
    public HGCamera hgCamera;
    public TextureHandle sceneColor;
    public TextureHandle sceneDepth;
    public TextureHandle sceneDepthToSample;
    public TextureHandle historySceneDepth;
    public VolumetricRenderer renderer;
    public Material volumetricComposeMaterial;
    public HGVolumetricCloudSettingParameters volumetricParameters;
    public List<IVolumetricRenderObject> volumetricRenderObjects;
}
```

**关键字段**:
```csharp
private TextureHandle m_currentSceneDepth;
private TextureHandle m_historySceneDepth;
private Material m_volumetricMaterial;
private VolumetricRenderer m_renderer;              // 体积渲染器(C++侧)
private Material m_volumetricComposeMaterial;        // 合成材质
private bool m_bHasCloud;
private bool m_bEnableDownRes;                      // 是否启用降分辨率
private List<HGVolumetricRenderItem> m_renderItems;  // 渲染项列表
```

**关键方法**:
- `ShouldRenderVolumetricCloud(...)`: 判断是否有体积云需要渲染
- `PrepareShaderVariablesGlobal(...)`: 设置全局着色器变量(云SDF合成参数)

**架构复刻参考要点**:
1. 使用 `VolumetricRenderer` (C++实现) 进行实际的体积云光线步进
2. 三阶段: 读取场景颜色/深度 -> 体积渲染 -> 合成到场景颜色
3. 支持多个 `IVolumetricRenderObject` (体积云SDF对象)
4. 深度历史缓冲用于时间重投影
5. 降分辨率渲染 (`m_bEnableDownRes`) 以提升性能
6. `PrepareShaderVariablesGlobal` 中遍历 `VolumetricRenderObjects` 找出最优合成覆盖材质
7. 使用 `HGRenderGraphBuilder` 管理纹理读写和Pass依赖

---

## 11. 水体渲染

### 文件
- `WaterSectorRenderingPass.cs`
- `WaterInteractionRenderingPass.cs`

### WaterSectorRenderingPass
**类**: `WaterSectorRenderingPass` : `IPassConstructor`
- **角色**: 管理水分区(3x3 Tile)纹理的加载和渲染

**内部枚举与结构**:
```csharp
private enum SectorState { Loading = 0, Loaded = 1, ToUnload = 2, Unload = 3 }

private struct SectorNode {
    bool isInTexture;           // 是否已在纹理中
    (int, int) coords;         // 分区坐标
    (int, int) coordsMod3;     // 模3坐标
    SectorState state;         // 加载状态
    FAssetProxyHandle assetHandle;  // 资源代理句柄
    string texurePath;         // 纹理路径
}

private struct SectorLoadingNode {
    int sectorIndex;
    string texturePath;
    FAssetProxyHandle assetHandle;
}

private class SectorCopyPassData {
    Vector4 scaleBiasTex;
    Vector4 scaleBiasRT;
    Texture2D copyTexture;
}
```

**关键常量**:
```csharp
private const int TEXTURE_SIZE = 256;           // 每个分区纹理大小
private const string TEXTURE_NAME = "WaterSectorTexture3x3";
```

**关键字段**:
```csharp
private int m_sectorTextureSize;
private RTHandle m_sectorTexture3x3;            // 3x3 图集纹理
public TextureHandle sectorTexture3x3;           // 渲染图句柄
private bool m_needClear;
private string m_scenePath;
private SectorNode[] m_waterSectors;             // 所有分区节点
private Queue<int> m_pendingUnloadQueue;          // 待卸载队列
private Queue<int> m_pendingCopyQueue;           // 待复制队列
private Queue<SectorLoadingNode> m_pendingLoadedQueue; // 已加载队列
```

**关键方法**:
- `Initialize(...)`: 从全局配置初始化分区系统
- `Render(...)`: 主渲染接口(更新加载/卸载/复制状态 + 执行纹理复制Pass)
- `SectorUnloadUpdate()`: 卸载不在范围内的分区
- `SectorLoadingUpdate(...)`: 加载新进入范围的分区
- `SectorLoadedUpdate()`: 处理已加载完成的资源
- `SectorTextureCopyUpdate(...)`: 更新需要复制到图集的纹理
- `SectorTextureCopyPass(...)`: 执行纹理复制渲染Pass

**架构复刻参考要点**:
1. 3x3 Tile系统: 以玩家为中心，管理周围3x3个水分区的纹理
2. 资源使用 `FAssetProxyHandle` 异步加载
3. 分区状态机: Loading -> Loaded -> ToUnload -> Unload
4. 使用 Blit Pass 将加载完成的分区纹理复制到 `m_sectorTexture3x3` 图集
5. 支持场景切换自动重初始化
6. 纹理坐标计算使用模3运算实现循环滚动

### WaterInteractionRenderingPass
**类**: `WaterInteractionRenderingPass` : `IPassConstructor`
- **角色**: 渲染水面交互涟漪效果

**内部类**:
```csharp
private class InteractionAddData {
    CBHandle cb;
    TextureHandle prevSimulationTexture;
    Material material;
}

private class InteractionSimulateData {
    CBHandle cb;
    TextureHandle prevAddTexture;
    TextureHandle currAddTexture;
    TextureHandle currSimulateTexture;
    Material material;
}

private class InteractionHeightConvertData {
    CBHandle cb;
    TextureHandle currSimulateTexture;
    TextureHandle currSimulateNormalTexture;
    Material material;
}
```

**关键字段**:
```csharp
private int[] m_rippleTextureSize;          // 涟漪纹理尺寸数组
private CBHandle m_cb;
private TextureDesc m_desc;                 // 涟漪纹理描述
private TextureDesc m_normalDesc;           // 法线纹理描述
private TextureHandle m_prevAddTexture;
private TextureHandle m_currAddTexture;
private TextureHandle m_prevSimulateTexture;
private TextureHandle m_currSimulateTexture;
private TextureHandle m_currNormalTexture;
private RTHandle m_defaultTexture;
private Material m_interactionAddMaterial;
private Material m_interactionSimulateMaterial;
private Material m_interactionHeightConvertMaterial;
private bool m_shouldRender;
private float waterInteractionSafeDeltaTime;

public TextureHandle interactionTexture => default(TextureHandle);
```

**关键方法**:
- `ShouldRender(...)`: 判断是否需要渲染涟漪(检查WaterManager状态和Setting)
- `Render(...)`: 主渲染接口，包含三个子Pass:
  1. Interaction Add: 将涟漪输入绘制到 Add 纹理
  2. Ripple Simulate: 执行涟漪波动模拟
  3. RippleHeightConvertToNormal: 将高度场转换为法线贴图
- `FallbackRender(...)`: 当不需要渲染时使用默认纹理
- `UpdateWaterInteractionSafeDeltaTime(float dt)`: 安全的时间步长更新(钳位和过滤)

**架构复刻参考要点**:
1. 涟漪由三个子Pass构成:
   - **Interaction Add**: 从 `HGWaterManager` 获取涟漪输入数据(角色位置、碰撞等)，写入Add纹理
   - **Ripple Simulate**: 基于波动方程(2D波方程)在GPU上模拟涟漪传播，使用双缓冲
   - **HeightConvertToNormal**: 从高度场计算法线贴图(用于水面反射)
2. 安全DeltaTime管理: 钳位到 [0, maxDt] 并做低通滤波
3. CBHandle 动态分配常量缓冲区，包含所有涟漪参数
4. 通过 `HGRenderGraph.CreateTexture` 创建/销毁涟漪纹理
5. 当 `m_shouldRender` 为 false 时，回退到 `m_defaultTexture`

---

## 12. 环境管理

### 文件
- `HGEnvironmentManager.cs`

### HGEnvironmentManager
**类**: `HGEnvironmentManager`
- **角色**: 全局环境管理器，管理所有环境阶段(Phase)和体积(Volume)的插值

**关键字段**:
```csharp
public class HGEnvironmentManager {
    private static readonly Lazy<HGEnvironmentManager> s_instance;

    private readonly HashSet<HGEnvironmentVolume> m_activeVolumes;
    private readonly List<HGEnvironmentVolume> m_sortedVolumes;
    private readonly IndexedHashSet<HGEnvironmentVolume> m_interpolatedVolumes;
    private readonly List<float> m_interpolatedVolumesFactor;

    private readonly HGAtmosphereRenderer m_atmosphereRenderer;
    private readonly HGVolumetricFogRenderer m_volumetricFogRenderer;
    private readonly HGSkyRenderer m_skyRenderer;
    private readonly HGSkydomeStarRenderer m_talosStarRenderer;
    private readonly HGRainRenderer m_rainRenderer;
    private readonly HGSnowRenderer m_snowRenderer;

    private readonly HGEnvironmentPhase m_defaultPhase;
    private readonly HGEnvironmentPhase m_interpolatedPhase;  // 当前插值后的阶段

    private Transform m_interpolateTrigger;
    private Transform m_interpolateTriggerOverride;
    private bool m_sortNeeded;
    private float m_interpolateTimeFactor;
    private Vector3 m_lastInterpolateTriggerPosition;
}
```

**静态属性**:
```csharp
public static HGEnvironmentManager instance => null;
public static bool initialized => false;
public static HGAtmosphereRenderer s_atmosphereRenderer => null;
public static HGVolumetricFogRenderer s_volumetricFogRenderer => null;
public static HGSkyRenderer s_skyRenderer => null;
public static HGSkydomeStarRenderer s_talosRenderer => null;
public static HGRainRenderer s_rainRenderer => null;
public static HGSnowRenderer s_snowRenderer => null;
public static IndexedHashSet<HGEnvironmentVolume> s_interpolatedVolumes => null;
public static List<float> s_interpolatedVolumesFactor => null;
public static HGEnvironmentPhase s_interpolatedPhase => null;
public static Transform interpolateTriggerOverride { get; set; }
public static bool sortNeeded { get; set; }
public static float interpolateTimeFactor { get; set; }
```

**关键方法**:
- `GetInterpolatedPhase(HGCamera)`: 获取当前摄像机的插值环境阶段
- `GetInterpolatedVolumes(HGCamera)`: 获取影响当前摄像机的环境体积列表
- `GetInterpolatedVolumesFactor(HGCamera)`: 获取各体积的插值权重
- `Register(HGEnvironmentVolume)`: 注册环境体积
- `Unregister(HGEnvironmentVolume)`: 注销环境体积
- `PipelineUpdate(...)`: 管线更新(排序体积、插值、更新光源)
- `GetFinalTrigger(Camera, Transform)`: 获取最终插值触发器
- `UpdateCameraComponent(HGCamera)`: 更新摄像机环境组件
- `PerCameraUpdate(...)`: 逐摄像机更新(更新雨/雪数据)
- `_Register/_Unregister`: 内部注册/注销实现(使用HashSet+有序列表)
- `_PipelineUpdate(...)`: 内部管线更新实现(排序、插值、太阳光同步)

**架构复刻参考要点**:
1. 环境体积系统: 多个 `HGEnvironmentVolume` 按权重排序和插值
2. `HGEnvironmentPhase` 存储完整的环境状态(光照、雾、云、天空等)
3. 插值过程: 收集影响当前触发器的体积 -> 排序(按距离/优先级) -> 按权重混合所有体积的阶段数据
4. 场景变换触发器 `interpolateTrigger` 控制插值位置
5. 太阳光自动同步: 从 `HGEnvironmentPhase` 获取太阳方向和颜色并设置到场景主光源
6. 排序使用 `Comparison<HGEnvironmentVolume>` 委托
7. 雨/雪渲染器在 `PerCameraUpdate` 中每帧更新
8. 所有子渲染器(大气、体积雾、天空、星体、雨、雪)通过单例属性暴露

---

## 附录: 渲染图架构索引

### IPassConstructor 接口
所有特殊效果Pass均实现 `HG.Rendering.RenderGraphModule.IPassConstructor`，生命周期:

| 方法 | 说明 |
|------|------|
| `PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal)` | 设置全局着色器变量 |
| `OnPreRendering(ref PassEventInput)` | 渲染前回调 |
| `ConstructPass(...)` | 构建渲染图Pass(核心) |
| `OnPostRendering(ref PassEventInput)` | 渲染后回调 |
| `Dispose(HGRenderGraph)` | 释放资源 |

### 关键渲染图类型
| 类型 | 说明 |
|------|------|
| `HGRenderGraph` | 渲染图容器 |
| `HGRenderGraphBuilder` | 渲染图构建器 |
| `TextureHandle` | 纹理句柄 |
| `ComputeBufferHandle` | 计算缓冲区句柄 |
| `CBHandle` | 常量缓冲区句柄 |
| `RenderFunc<T>` | 渲染函数委托 |
| `PassEventInput` | Pass事件输入 |

### 通用数据流
```
Manager (CPU数据管理)
    -> PassConstructor.ConstructPass (构建渲染图)
        -> HGRenderGraph.AddRenderPass<T>(name, ...)
            -> HGRenderGraphBuilder.SetColorAttachment/ReadTexture/WriteTexture
            -> HGRenderGraphBuilder.SetRenderFunc<T>(func)
                -> RenderFunc<T> (实际渲染调用, 在渲染图中执行)
    -> PassConstructor.OnPostRendering (后处理, 如纹理保持)
    -> PassConstructor.Dispose (释放资源)
```

