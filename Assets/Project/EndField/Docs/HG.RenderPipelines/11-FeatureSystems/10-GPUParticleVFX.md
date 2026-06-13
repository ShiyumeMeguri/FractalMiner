# HG Render Pipeline — GPU Particle / VFX (GPU 粒子 + 视觉特效) 技术实现原理蓝图

> 本文是 **从零重建** 终末地 (EndField) HG.RenderPipelines GPU 粒子与 VFX 子系统的实现蓝图。
> **此系统属 HG 自研，与 HDRP 的 VFX Graph 分支毫无血缘**：HDRP 用 `Unity.VisualEffectGraph` (节点图 + ScriptableObject 资源驱动 `VFXManager`)；HG 用一套**经典 GPU 粒子池 + 间接绘制**架构 — 128 个 system 槽，每 system 8 个 `ComputeBuffer` + 1 `GraphicsBuffer`、emit/update/sort/indirect 5 个 compute shader 拼出 emit→update→cull→sort→indirect→draw 全链路，外加 `GPU_EVENT_SENDER`/`RECIEVER` keyword 启用 GPU→GPU 子发射 (GPU Event)、`PER_PARTICLE_SYSTEM_LIGHTING` keyword 启用 4096 粒子/系统的 64 线程组 compute lighting。
> 故本文**全篇据反汇编 `call`/常量证据 + 标准 GPU 粒子池技术** (HLSL Append/Consume + bitonic sort + DrawMeshInstancedIndirect) 1:1 重建；HDRP 仅作"为什么 HG 不沿用 VFX Graph"的对照。
>
> 配套已有文档（不复述、只链）：
> - Pass 拓扑入口：[`../01-PipelineCore/PassConstructors/PreRenderPasses.md`](../01-PipelineCore/PassConstructors/PreRenderPasses.md)（PreRender 注入 id 9 `GPUParticleSimulation`、id 10 `ParticleLighting`）
> - 特效 pass 矩阵概览：[`../01-PipelineCore/08-SpecialEffectsPasses.md`](../01-PipelineCore/08-SpecialEffectsPasses.md) §5
> - 粒子光照与 ASM/IV 的关系：[`../01-PipelineCore/04-LightingAO.md`](../01-PipelineCore/04-LightingAO.md) §ParticleLightingPass
> - 阴影 (ASM): [`./07-ShadowASM.md`](./07-ShadowASM.md)
> - 球谐 / IV (光照插值用)：[`./09-GI-IrradianceSH.md`](./09-GI-IrradianceSH.md)
> - C++ 模块 `ParticleLightingIVInput` blittable 布局：[`../04-GraphicsCPPModule/01-HGGraphicsCPPModule.md`](../04-GraphicsCPPModule/01-HGGraphicsCPPModule.md) §7

---

## 0. 目录

| § | 主题 |
|---|------|
| 1 | 解决什么渲染问题 / 视觉目标 |
| 2 | 拓扑：Manager / SystemBase / System<T> 三层 + Pass 装配位 |
| 3 | 数据布局：8 个 ComputeBuffer / GeneralSystemAttributes / PerInstanceData |
| 4 | GPU 执行模型：5 compute shader + 8 kernel 全帧 dispatch 序列 |
| 5 | Free-List / Live-List 算法：经典 Append/Consume 池 |
| 6 | Bitonic Sort + ping-pong Merge (SORT_BATCH_SIZE=4096) |
| 7 | GPU Event：Guid 关联的 Sender↔Receiver 跨 system 触发 |
| 8 | SceneDepth / SceneNormal 碰撞 (SceneRTFeature optional) |
| 9 | Particle Lighting Pass：4096/system × 64 thread compute + IV + ASM + binning |
| 10 | Indirect Draw：DrawIndirectArgs + Quad Index 64K Triangle Strip |
| 11 | 与 HDRP VFX Graph 的设计动因对照 |
| 12 | VFX MonoBehaviour 子系统 (PP / 场景调色 / 假体积雾 / 排序覆盖) |
| 13 | 1:1 复刻蓝图 (分步) |
| 14 | 关键常量 / 魔数总表 |
| 15 | 源文件清单 (41 个) |

---

## 1. 解决什么渲染问题 / 视觉目标

终末地的开放世界 + 战斗 + 化身演出需要大规模 GPU 粒子 (技能光效、招式拖尾、爆炸、环境飘屑) **且单帧上百个 system / 上万颗粒子**。CPU 粒子 (`UnityEngine.ParticleSystem`) 在该负载下：

1. 主线程 Burst 仿真也会 cap 在几千颗；
2. 上传 instance 数据每帧 PCIE 走一遍，BW 是瓶颈；
3. 无法**让粒子读屏幕深度/法线做碰撞**；
4. 无法**让一颗粒子的死亡触发另一颗粒子的诞生** (子发射) 而不回 CPU。

HG 的方案是教科书式的**全 GPU 粒子池**：
- **emit / update / sort / cull / indirectArgs 全部 compute shader 完成**；只在 CPU 调 `Modify(generalSystemAttributes)` / `Modify(systemAttribDesc)` 改阈值；
- **buffer 常驻 GPU 显存**：`particleAttributesBuffer` (per-particle SoA)、`liveListBuffer` (Append/Consume)、`deadListBuffer` (Append/Consume)、`deadCountBuffer` (counter)；
- **DrawIndirect**：sort 后写 `drawIndirectArgsBuffer`，材质用 `Graphics.DrawProceduralIndirect` 出图，CPU 0 字节顶点/索引带宽；
- **GPU Event**：`GPU_EVENT_SENDER` keyword 让一个 system 在 update kernel 里把"我死了，请别人在这里 emit"事件写进 `eventBuffer` + `sentCount`；另一个 system 启 `GPU_EVENT_RECIEVER` 在 emit kernel 里 consume，**零回主线程**；
- **粒子光照**：另一个 compute kernel `ParticleLightingMain` 每 system 最多 4096 颗，64 线程组，**直接吃 light binning + ASM 阴影 + IV (Irradiance Volume) SH**，与不透明 G-Buffer tile shading 共用基础设施 (见 §9)。

视觉上对应：技能拖尾密度高、爆炸碎片受地面遮挡正确碰撞、子发射爆裂、粒子受场景方向光阴影。

---

## 2. 拓扑：Manager / SystemBase / System\<T\> 三层 + Pass 装配位

```
                           HGRenderPipeline.RenderPath (DefaultDeferred 等)
                                          │
   ┌──────────────────────────────────────┴──────────────────────────────────────┐
   ▼                                                                             ▼
┌──────────────────────────────────────┐                  ┌────────────────────────────────────┐
│  GPUParticleSystemManager            │                  │  HGVFXManager (单例, 场景级)        │
│  (单例 s_instance, MAX_SYSTEM=128)   │                  │   - SceneDark 颜色调节列表         │
│                                       │                  │   - 玩家位置/玩家高度上传 (角色雾) │
│  SystemList m_particleSystems[128]    │                  │   - AnchorWaveBright (Anchor 闪光) │
│  List<int> m_freePool                 │                  │   - VFXSceneColorAdjustment 材质   │
│  maxParticleCount  (∑ 每 system 容量) │                  └────────────────────────────────────┘
│  maxGPUInstanceCount                  │
│                                       │                  ┌────────────────────────────────────┐
│  CreateParticleSystem<SYS_ATTRIB>     │                  │  VFXPPManager (单例 MonoBehaviour) │
│      → 分配槽 + new GPUParticleSystem │                  │   List<List<VFXPPComponent>>[16]   │
│      <SYS_ATTRIB>(shaders, geom,      │                  │   按 VFXPPType 分桶 + 按 Priority  │
│       material, optionalFeatures)     │                  │   (Normal0 / Skill100 / UltiSkill  │
│  CreateParticleSystemInstance         │                  │    200 / Cinematic 300 / UI 400)   │
│      (per-instance position + emit)   │                  │   挂自 HGEnvironmentVolume 上, 通  │
│  RemoveParticleSystem / Instance      │                  │   过 Volume Profile 注入到 PP 链   │
│  Modify(generalSystemAttributes)      │                  └────────────────────────────────────┘
│  Modify<SYS_ATTRIB>(systemAttribDesc) │
│  GetSpan() → ReadOnlySpan<…Base>      │
└──────────────────────────────────────┘
                  │  
                  ▼  每 system 一个
┌─────────────────────────────────────────────────────────┐
│  GPUParticleSystemBase (MAX_INSTANCE_COUNT = 64)        │
│  ── 8 ComputeBuffer 一次性分配，常驻显存 ──             │
│  m_perInstanceBuffer        size=instanceCap   stride=32 │  // PerInstanceData
│  m_generalSystemAttributeBuffer size=1   stride=16     │  // GeneralSystemAttributes 16B
│  m_systemAttribsBuffer       size=1   stride=sizeof<T>  │  // System<T>.m_systemAttribsBuffer
│  m_particleAttributesBuffer  size=part*var size=…  raw  │  // 自定义 attrib, var stride
│  m_liveListBuffer        size=part   stride=4   raw     │  // uint particleIdx[]
│  m_deadListBuffer        size=part   stride=4   raw     │  // uint freeIdx[]
│  m_deadCountBuffer       size=1     stride=4   raw      │  // counter
│  m_drawIndirectArgsBuffer size=1    stride=20  IndArg   │  // 5 uint args
│  m_quadIndexBuffer (GraphicsBuffer) size=part-2 stride=4│  // ushort/uint quad strip indices
│                                                          │
│  AcquireSimulateContext() → 喂给 Simulation Pass        │
│  AcquireRenderContext()   → 喂给 Forward/Transparent    │
└─────────────────────────────────────────────────────────┘
                  │
                  ▼ Pass 装配 (RenderGraph)
┌──────────────────────────────────────┐  ┌────────────────────────────────────┐
│  GPUParticleSimulationPassConstructor│  │  ParticleLightingPassConstructor    │
│  Profile id 9 "Particle Simulation"   │  │  Profile id 10 "Particle Lighting"  │
│  在 PreRender 阶段 emit→update→cull→  │  │  在 Lighting 阶段 4096-粒子/系统    │
│  sort→merge→indirect  全部 compute    │  │  ParticleLightingMain compute       │
└──────────────────────────────────────┘  └────────────────────────────────────┘
                  │                                       │
                  └────────── ↓ ──────────────────────────┘
                  Forward/Transparent: Graphics.DrawProceduralIndirect
                  (从 m_drawIndirectArgsBuffer + m_quadIndexBuffer 出图)
```

**HDRP 对照（为什么 HG 不沿用 VFX Graph）**：HDRP 的 VFX Graph (`com.unity.visualeffectgraph`) 是 ScriptableObject 资源 + GPU command list 解释器，依赖 `VFXManager.PrepareCamera/ProcessCamera`、Unity 内建的 `VFXSystemData`、shader graph 节点编译。HG 移动端首发 + 自定义 shader (NPR) 不愿绑 VFX Graph 的资产管线，索性自起一套**纯 ComputeShader + 5 个固定 kernel**的池子，**美术配 stride + ComputeShader 文件，不配节点图**，从而完全脱钩 HDRP/SRP VFX。

证据：

- `GPUParticleSystemManager.MAX_SYSTEM_COUNT = 128`（`GPUParticleSystemManager.cs:592`）。
- `GPUParticleSystemBase.MAX_INSTANCE_COUNT = 64`（`GPUParticleSystemBase.cs:15`）。
- 八个 ComputeBuffer 分配按序紧贴 base ctor：`UnityEngine.ComputeBuffer::.ctor` 调八次，依次写到偏移 `[rbx+10h]…[rbx+48h]`（`GPUParticleSystemBase.cs:358-489`），最后一个偏移 `0x48h` 处用 `UnityEngine.GraphicsBuffer::.ctor` (Index 类型) — 即 `m_quadIndexBuffer`。

---

## 3. 数据布局：8 个 ComputeBuffer / GeneralSystemAttributes / PerInstanceData

### 3.1 GeneralSystemAttributes (16 字节, 每系统 1 个)

```csharp
public struct GeneralSystemAttributes
{
    internal int particleCapacity;   //   每系统最大粒子数 (= particleAttribSize 字节流总长 / particleAttribStride)
    internal int instanceCapacity;   //   每系统最大 instance 数 (≤ 64 = MAX_INSTANCE_COUNT)
    internal int particleAttribSize; //   每颗粒子属性字节数 (用户自定义, ≥ 32 = sizeof<FixedParticleAttrib>)
    internal int padding0;           //   对齐到 16
}
```
来源：`GeneralSystemAttributes.cs`。Manager 在 `Modify(in GeneralSystemAttributes, SystemHandle)` 时透传给 base：`HG.Rendering.Runtime.GPUParticleSystemBase::Modify` 用 `Unity.Collections.NativeArray<GeneralSystemAttributes>` size=1 直接 `ComputeBuffer.SetData` 上传到 `m_generalSystemAttributeBuffer`（`GPUParticleSystemBase.cs:1352-1378`）。

### 3.2 PerInstanceData (32 字节, 每 instance 1 个)

```csharp
public struct PerInstanceData
{
    public Vector4 position;   // xyz=位置, w 备用
    public int     emitRate;   // 每秒发射颗数
    public int     padding0;
    public int     padding1;
    public int     padding2;   // 共 16 + 16 = 32 字节, GPU 4xFloat 对齐
}
```
来源：`PerInstanceData.cs`。Instance 上下线时 base 用 `List<PerInstanceData>` 维护 CPU 镜像，挪动 instance 时调 `Graphics.CopyBuffer` 在 GPU 端就地搬移 `particleAttributes` / `liveList` / `deadList` 三个 buffer 的对应 instance 子区（见 `GPUParticleSystemBase.cs::OnInstanceRemoved` 三次 `Graphics.CopyBuffer`，第一个搬粒子属性、第二个搬 liveList、第三个搬 deadList — 偏移用 `instanceIndex * stride * particleCapacity` 算）。

### 3.3 FixedParticleAttrib (最小粒子属性, 32 字节)

```csharp
private struct FixedParticleAttrib   // 内嵌在 GPUParticleSystemBase
{
    internal Vector4 var0;            // 通常 pos.xyz / age
    internal Vector4 var1;            // 通常 vel.xyz / lifetime
}
```
`particleAttribSize` 必须 ≥ `sizeof(FixedParticleAttrib) = 32` (`GPUParticleSystemBase.cs:8-13` 直接申明的固定头, base.ctor 用 `idiv r8d` (r8=16) 把"总字节 / 16"作为 `m_particleAttributesBuffer` 的 element count, raw structured)；超过的字节由 emit/update compute 自定义解释 (色、size、自定义 mask)。

### 3.4 8+1 Buffer 全表

| 偏移 (base) | 字段 | Unity 类型 | Stride | Count | 含义 |
|---|---|---|---|---|---|
| 0x10 | `m_perInstanceBuffer` | `ComputeBuffer` | 32 (=`sizeof<PerInstanceData>`) | `instanceCap` | per-instance position + emit rate |
| 0x18 | `m_generalSystemAttributeBuffer` | `ComputeBuffer` | 16 | 1 | 系统级常量 (容量、stride) |
| 0x20 | `m_particleAttributesBuffer` | `ComputeBuffer` (raw) | 16 | `(particleAttribSize * particleCap * instanceCap) / 16` | per-particle 属性流，AoS-of-Vec4 |
| 0x28 | `m_liveListBuffer` | `ComputeBuffer` (raw, Append) | 4 | `particleCap * instanceCap` | 活粒子索引列表 |
| 0x30 | `m_deadListBuffer` | `ComputeBuffer` (raw, Append) | 4 | `particleCap * instanceCap` | 死粒子(空闲位)索引列表 |
| 0x38 | `m_deadCountBuffer` | `ComputeBuffer` (raw, counter) | 4 | `instanceCap` | 每 instance 当前 dead 数 |
| 0x40 | `m_drawIndirectArgsBuffer` | `ComputeBuffer` (IndirectArguments) | 12 | 256 | 5×uint 间接绘制参数 |
| 0x48 | `m_quadIndexBuffer` | `GraphicsBuffer` (Index, ushort) | 2 | `4*particleCap*instanceCap` (≈) | 全局 quad index strip |
| (System\<T\>) | `m_systemAttribsBuffer` | `ComputeBuffer` | `sizeof<T>` | 1 | 子类提供的强类型 system attrib |

证据：`GPUParticleSystemBase.cs:358-489` (ctor 八次 `ComputeBuffer::.ctor` + 一次 `GraphicsBuffer::.ctor`)；ctor 里 `mov r9d, 100h` (=256) 是 `m_drawIndirectArgsBuffer` 的 element count；`m_quadIndexBuffer` 用 `lea r14d,[r15+2]` (=`GraphicsBuffer.Target.Index`=2+0? 实为 Index=2 + IndirectArguments=...) 创建。

注：HG 没有用 `AppendStructuredBuffer<uint>` 这样的"Append"专属类型 — 而是 raw + counter buffer 自己管理。`m_deadCountBuffer` 容量等于 instance 数 (不是 1)，是因为 **每个 instance 独立一对 live/dead 池**（粒子可属不同 instance 的 emit 中心点位置）。

### 3.5 ShaderID 表 (HGShaderIDs.cs:399-441)

| Shader ID | 绑定 buffer | 偏移 |
|---|---|---|
| `_GeneralGPUParticleSystemAttributes` | generalSystemAttributeBuffer | 0x18 |
| `_GPUParticleSystemAttributes` | systemAttribsBuffer | (System\<T\>) |
| `_PerInstanceBuffer` | perInstanceBuffer | 0x10 |
| `_PerFrameVariables` | per-frame cbuffer (uint seed) | (CB) |
| `_MergePassConstants` | merge cbuffer (uint blockSize, groupCount) | (CB) |
| `_ParticleAttributes` | particleAttributesBuffer | 0x20 |
| `_LiveList` | liveListBuffer | 0x28 |
| `_DeadList` | deadListBuffer | 0x30 |
| `_DeadCount` | deadCountBuffer | 0x38 |
| `_DrawIndirectArg` | drawIndirectArgsBuffer | 0x40 |
| `_DataForEmitter` | stagingLiveList[0] (跨 system 数据通道) | (RG handle) |
| `_LiveCount` | live count helper buffer | (RG handle) |
| `_InputLiveList` / `_SortedLiveList` | sort 双 ping-pong | (RG handle) |
| `_DispatchSize` / `_InstanceCount` / `_CleanupOffset` | 写入 cbuffer 的常数 | — |
| `_SceneNormal` / `_DepthOnlyRT` | SceneRTFeature 输入 | (RG handle) |
| `_GPUEventBuffer` / `_GPUEventSentCount` / `_GPUEventConsumedCount` | GPU Event 通道 | (RG handle) |

完整列表见 `HGShaderIDs.cs` 偏移 `399..441`。

---

## 4. GPU 执行模型：5 compute shader + 8 kernel 全帧 dispatch 序列

### 4.1 Pass Constructor 在 ctor 拿到的 5 个 ComputeShader + 8 kernel

`GPUParticleSimulationPassConstructor` ctor (`GPUParticleSimulationPassConstructor.cs:302-525`) 从 `HGRenderPathResources` 偏移 `0xA0..0xC0` 拿到 5 个 ComputeShader：

| 字段名 | resources 偏移 | 用途 |
|---|---|---|
| `m_particleCleanupShader` | 0xA0 | 帧首把 instance 标记为 clear 的列表清空 |
| `m_particleInitShader` | 0xA8 | 初始化 deadList = [0..N) (首帧/容量改变) |
| `m_particleCullShader` | 0xB0 | sort 前的视锥裁剪 / 帧末清理 |
| `m_particleSortShader` | 0xB8 | bitonic Sort + Sort/Final + Merge/MergeFinal (共 4 kernel) |
| `m_particleIndirectArgsShader` | 0xC0 | 写 `drawIndirectArgsBuffer` 5 uint |

Kernel `FindKernel` 调用对照：

| Kernel 字段 | Shader | Kernel name | 用途 |
|---|---|---|---|
| `m_particleCleanupKernel` | cleanup | `"CSMain"` | clearInstance / freelist reset |
| `m_particleInitKernel` | init | `"CSMain"` | deadList 初值 0..N |
| `m_particleCullKernel` | cull | `"CSMain"` | sort 输入收集 + camera-space depth |
| `m_bitonicSortKernel` | sort | `"Sort"` | 4096 颗 batch 局部 bitonic |
| `m_bitonicSortFinalKernel` | sort | `"SortFinal"` | batch 余数 sort |
| `m_mergeKernel` | sort | `"Merge"` | 跨 batch ping-pong merge |
| `m_mergeFinalKernel` | sort | `"MergeFinal"` | 最后一趟 merge |
| `m_particleIndirectArgsKernel` | indirectArgs | `"CSMain"` | 写 indirect 参数 |

另外两个**system 自带**的 ComputeShader (`GPUParticleShaders`)：

```csharp
public struct GPUParticleShaders
{
    internal ComputeShader emitShader;      // CSMain → 用 deadList consume 出 idx, 在该 idx 写新粒子属性
    internal ComputeShader simulateShader;  // CSMain → 物理积分 + 生命周期 -1 + 死则推回 deadList
}
```
来源：`GPUParticleShaders.cs`。**这两个由调用者按视觉行为提供** (技能 A 一份 emit/sim, 角色拖尾另一份)。 base ctor 把它们存进偏移 `0x60/0x68`。

### 4.2 每帧 dispatch 顺序 (ProcessParticles `GPUParticleSimulationPassConstructor.cs:599-2169`)

下面这套是从反汇编的调用图重建的 — 每帧对每个 system (按 `sysList[i]`，i=0..size) 走一遍：

```
PER-FRAME (CommandBuffer):
  ConstantBuffer.UpdateData(_PerFrameVariables, { seed = Random.Range(INT_MIN, INT_MAX) })
                                                # seed 用 DateTime.Now.Ticks → InitState 后取
  ┌──── for each system in sysList ────┐
  │
  │ ① 如果 instancesToClear[] 非空, 对每个要 clear 的 instance 调:
  │      cleanupShader::CSMain                 # 把该 instance 全部粒子重新归 freepool
  │      ThreadGroups = ceil( particleCap / 64.0f )   ← g_18E5EC474 = 1/64
  │      [_GeneralGPUParticleSystemAttributes, _ParticleAttributes,
  │       _LiveList, _DeadList,
  │       _CleanupOffset = (clearInstanceIdx),
  │       _InstanceCount = (clearInstanceIdx * 64) ]
  │
  │ ② GPU Event keyword setup
  │   if (system 是 Sender):
  │      SetKeyword(GPU_EVENT_SENDER, true)
  │      bind _GPUEventSentCount = sentCountBuffer
  │   else if (system 是 Receiver):
  │      SetKeyword(GPU_EVENT_RECIEVER, true)
  │      bind _GPUEventConsumedCount = consumedCountBuffer
  │   else: both keywords = false
  │
  │ ③ EMIT  (user-provided emitShader::CSMain)
  │      ConstantBuffer.Set(_PerFrameVariables)
  │      bind _GeneralGPUParticleSystemAttributes, _GPUParticleSystemAttributes,
  │           _PerInstanceBuffer, _ParticleAttributes,
  │           _LiveList (Append), _DeadList (Consume), _DeadCount (counter)
  │      _DispatchSize = ceil(maxEmitRate / 64.0f) * 64
  │      ThreadGroups = ceil(maxEmitRate / 64.0f), 1, 1
  │      // 每线程: 看 PerInstance.emitRate 决定本帧发几颗
  │      //         consume deadList 拿到 freeIdx,
  │      //         写 ParticleAttributes[freeIdx] = init pose/vel/life,
  │      //         append liveList(freeIdx).
  │      //         Sender 还会写 EventBuffer[atomicInc(sentCount)] = childSeed
  │
  │ ④ SIMULATE  (user-provided simulateShader::CSMain)
  │      bind 同上 + _SceneDepth/_SceneNormal/_DepthOnlyRT (if SceneRTFeature)
  │      bind _GPUEventBuffer + count buffers (if Sender/Receiver)
  │      ThreadGroups = ceil(particleCap / 64.0f)
  │      // 每线程: 读 liveList(tid), 取 particleIdx,
  │      //         物理积分 (x += v·dt; v += g·dt; 碰撞 = 屏空深度比对),
  │      //         life -= dt, life<0 → append deadList(particleIdx) + 标记从 live 剔除
  │      //         Sender 把死亡事件写 EventBuffer
  │
  │ ⑤ CULL  (m_particleCullKernel::CSMain)
  │      bind _ParticleAttributes, _LiveList, _SortedLiveList (output staging),
  │           _GeneralGPUParticleSystemAttributes
  │      ThreadGroups = ceil(particleCap / 64.0f)
  │      // 每线程: 读 liveList(tid), 算 camera-space depth z,
  │      //         写 SortedLiveList[appendIdx] = SortKey{ particleIndex, cameraSpaceDepth }
  │      //         (剔除视锥外 / life≤0 的)
  │
  │ ⑥ BITONIC SORT  (按距相机 z 从远到近, 保证 transparent back-to-front)
  │      Sort kernel  (ThreadGroups = ceil(liveCount / 4096), Z=1, Y=1)
  │      // 每 group 4096 颗局部 bitonic
  │      if (liveCount > 4096):
  │        MergeFinal / Merge 两两 ping-pong:
  │          for (subSize = 2; subSize ≤ ceil2(liveCount); subSize *= 2):
  │            ConstantBuffer.Push(_MergePassConstants{ blockSize=subSize/2, groupCount=ceil(liveCount/4096) })
  │            mergeShader::Merge (或 MergeFinal at last)
  │            ping-pong InputLiveList ↔ SortedLiveList
  │
  │ ⑦ INDIRECT ARGS  (m_particleIndirectArgsKernel::CSMain)
  │      bind _DrawIndirectArg (output, raw 5xuint),
  │           _LiveCount (input, =sort 后的活粒子数)
  │      ThreadGroups = (1,1,1)
  │      // 单线程写 IndArg = { indexCountPerInstance = quadIndexCount,
  │      //                     instanceCount = liveCount, startIndex=0, baseVertex=0, startInstance=0 }
  │
  └─────────────────────────────────┘

POST-SIMULATE (在透明 / Forward 阶段, 见 ParticleLighting §9 + render 链):
  ─ ParticleLighting::CSMain (compute, §9)
  ─ Graphics.DrawProceduralIndirect(material, mesh, quadIndexBuffer,
                                    args=drawIndirectArgsBuffer)
```

证据：
- `ConstantBuffer.UpdateData<PerFrameBuffer>` 调用紧跟在 `Random.Range(INT_MIN, INT_MAX)`，且 `DateTime.Now.Ticks` 喂 `Random.InitState`（`GPUParticleSimulationPassConstructor.cs:656-678`）— **per-frame 随机种子源**；
- `g_18E5EC474 = 1/64f` (`mulss xmm0,[g_18E5EC474]` 后 `ceil`) → `ThreadGroups = ceil(N/64)`，验证 64 线程组；
- `shl r9d, 6` (×64) 反算 dispatch 后 `SetComputeIntParam(_DispatchSize, ...)`（`GPUParticleSimulationPassConstructor.cs:1462-1466`）；
- `g_18E5EC428 = 1/1024f` (`mulss xmm0,[g_18E5EC428]`) 出现在 sort 阶段计算 batch 数，与 `cmp esi,1000h`（=4096）配合：**sort batch = 4096，merge step = 1024**（`GPUParticleSimulationPassConstructor.cs:1790, 1794`）；
- 上面 ⑥ 的 `_MergePassConstants` cbuffer 结构：`internal uint blockSize; internal uint groupCount;`（`GPUParticleSimulationPassConstructor.cs:25-30`）；
- `_PerFrameVariables` cbuffer：`internal uint seed;`（`GPUParticleSimulationPassConstructor.cs:39-42`）；
- `SortKey` 布局：`{ uint particleIndex; float cameraSpaceDepth; }`（`GPUParticleSimulationPassConstructor.cs:32-37`）；
- 两个 LocalKeyword `"GPU_EVENT_SENDER"` / `"GPU_EVENT_RECIEVER"` 在 simulate shader 上 SetKeyword（`GPUParticleSimulationPassConstructor.cs:333, 494, 506`）。

---

## 5. Free-List / Live-List 算法：经典 Append/Consume 池

这是 HG 实现的"Mark Pranke 经典 GPU 粒子池"模式 — Unity 文档亦有此模式实现。算法：

```hlsl
// emit kernel (user-provided emitShader::CSMain), thread tid:
uint emitCount = ceil(perInstance[instanceIdx].emitRate * deltaTime);
if (tid >= emitCount) return;

// 从 deadList consume 出一个空闲 slot:
//   InterlockedAdd(_DeadCount[instanceIdx], -1, oldCount);
//   if (oldCount <= 0) { InterlockedAdd(_DeadCount[instanceIdx], 1); return; } // 池满
//   uint slot = _DeadList[ instanceIdx*particleCap + (oldCount-1) ];
uint slot = ConsumeDead(instanceIdx);
if (slot == INVALID) return;

// 初始化粒子属性 (用户自定义)
_ParticleAttributes[ slot * stride16 + 0 ] = float4(perInstance[instanceIdx].position.xyz, lifetime);
_ParticleAttributes[ slot * stride16 + 1 ] = float4(initVel, 0);
// ... 用户字段

// append 进 liveList:
//   uint liveIdx; InterlockedAdd(_LiveListCounter[instanceIdx], 1, liveIdx);
//   _LiveList[ instanceIdx*particleCap + liveIdx ] = slot;
AppendLive(instanceIdx, slot);

// GPU Event Sender (keyword 启用): 写一个出生事件
#if GPU_EVENT_SENDER
    uint evtIdx; InterlockedAdd(_GPUEventSentCount[0], 1, evtIdx);
    _GPUEventBuffer[evtIdx] = (uint4){ slot, instanceIdx, seedOf(tid), childSysId };
#endif
```

```hlsl
// simulate kernel (user-provided simulateShader::CSMain), thread tid:
uint particleIdx = _LiveList[ instanceIdx*particleCap + tid ];

float4 attr0 = _ParticleAttributes[ particleIdx*stride16 + 0 ];
float4 attr1 = _ParticleAttributes[ particleIdx*stride16 + 1 ];
float3 pos = attr0.xyz;  float life = attr0.w;
float3 vel = attr1.xyz;

life -= deltaTime;

#if SCENE_RT_FEATURE
    // 屏空碰撞: project pos → uv, sample _SceneDepth, 比较深度
    float3 screen = mul(VP, float4(pos,1));
    float sceneDepth = SampleLOD(_SceneDepth, screen.xy/screen.w*0.5+0.5, 0);
    if (screen.z > sceneDepth + bias) {
        // 与场景碰撞 → 反射 / 死亡 / 触发 event
        vel = reflect(vel, SampleNormal(_SceneNormal,...));
    }
#endif

vel += gravity * deltaTime;
pos += vel * deltaTime;

if (life <= 0) {
    // 死亡 → 推回 deadList
    uint deadSlot; InterlockedAdd(_DeadCount[instanceIdx], 1, deadSlot);
    _DeadList[ instanceIdx*particleCap + deadSlot ] = particleIdx;

    #if GPU_EVENT_SENDER
        // 死亡事件 → 喂给子 system 在该位置 emit
        uint evtIdx; InterlockedAdd(_GPUEventSentCount[0], 1, evtIdx);
        _GPUEventBuffer[evtIdx] = uint4_pack( pos, instanceIdx );
    #endif

    return;  // 不写回 liveList 当前 tid (后面 cull 会重收集)
}

_ParticleAttributes[ particleIdx*stride16 + 0 ] = float4(pos, life);
_ParticleAttributes[ particleIdx*stride16 + 1 ] = float4(vel, 0);
```

```hlsl
// cull kernel (m_particleCullKernel::CSMain), thread tid (前 N=liveCount):
uint particleIdx = _LiveList[tid];
float4 attr0 = _ParticleAttributes[particleIdx*stride16+0];
if (attr0.w <= 0) return;                       // 死的丢

float4 cs = mul(viewMatrix, float4(attr0.xyz, 1));
if (cs.z < nearClip || cs.z > farClip) return;  // 视锥剔除

uint outIdx; InterlockedAdd(_LiveCount[0], 1, outIdx);
_SortedLiveList[outIdx] = SortKey{ particleIdx, -cs.z };  // 远的 key 大, 升序排 = 远先画
```

为什么这套架构能跑：

- **Append/Consume 仅 RW raw structured + 一个 counter buffer**，是 D3D11/Vulkan 都直支的；HG 没用 Unity 的 `AppendStructuredBuffer<T>` (那是 C# 层封装)，**直接 raw + 原子操作** 更跨后端；
- **per-instance 池**：每个 instance 拥有 `[instanceIdx*particleCap, (instanceIdx+1)*particleCap)` 的子区，互相之间不会争抢 — 因此 `_DeadCount` 才是 `instanceCap` 长 (每 instance 一个 counter)；
- **dead 重叠 instance 销毁时**：`OnInstanceRemoved` (`GPUParticleSystemBase.cs:749-892`) 用 `Graphics.CopyBuffer` 把 `gpuIndexToMove` 那段 particleAttributes / liveList / deadList 子区**直接搬到** `gpuIndexToRemove` 子区位置 (各搬 `particleCap * stride` 字节)，CPU 0 ms 完成 instance 释放。

---

## 6. Bitonic Sort + ping-pong Merge (SORT_BATCH_SIZE = 4096)

`SORT_BATCH_SIZE = 4096u` (`GPUParticleSimulationPassConstructor.cs:258`)。

排序 key 是 `SortKey { uint particleIndex; float cameraSpaceDepth; }`，**8 字节**。`cameraSpaceDepth` 由 cull kernel 写入 (camera-space `-z`：越大越远)。

**升序 bitonic sort → 远的粒子排在前 → forward draw 时先画远后画近 → 透明混合 OK**。

```
            liveCount = N
        ┌────────────────────────────────────────────────────────┐
        │ Stage 0 (Sort / SortFinal kernels)                     │
        │   N ≤ 4096 → 1 dispatch  bitonicSortKernel  (groups=1) │
        │   N >  4096 → ceil(N/4096) dispatch                    │
        │                  last group < 4096 用 SortFinal kernel │
        │   每 group 内部: log2(4096)=12 stage × 12 sub-step       │
        │                  共 12*13/2 = 78 比较合并循环 (HLSL groupshared)│
        └────────────────────────────────────────────────────────┘
                        ↓ 输出 SortedLiveList(部分有序 batch=4096)
        ┌────────────────────────────────────────────────────────┐
        │ Stage 1+ (Merge / MergeFinal kernels, 只当 N > 4096)   │
        │   for (subSize = 8192; subSize <= ceil2(N); subSize*=2)│
        │     blockSize = subSize / 2                            │
        │     groupCount = ceil(N / 4096)                        │
        │     ConstantBuffer.Push(_MergePassConstants{ blockSize, groupCount })│
        │     Merge::Merge      // 中间趟                        │
        │     ping-pong 两个 staging buffer InputLiveList ↔      │
        │     SortedLiveList                                     │
        │   最后一趟用 MergeFinal kernel (写到最终 SortedLiveList)│
        └────────────────────────────────────────────────────────┘
                        ↓ SortedLiveList (全序, 远→近)
```

证据：
- `cmp esi,1000h` (=4096) 决定是否进 merge 循环（`GPUParticleSimulationPassConstructor.cs:1794, 1879`）；
- `mov eax, edi; shr eax, 1; mov [rbp-80h], eax` (`blockSize = subSize / 2`) 写入 `_MergePassConstants` 然后 `ConstantBuffer.Push`（`GPUParticleSimulationPassConstructor.cs:1893-1912`）；
- `add edi, edi` (`subSize *= 2`) 双倍递增循环（`GPUParticleSimulationPassConstructor.cs:1987`）；
- `mov r14d, 1; ... dec r14d; and r14d, 1` (`pingpong = !pingpong`) 控制双 staging buffer 交替（`GPUParticleSimulationPassConstructor.cs:1875, 1983-1985`）；
- Stage 1+ 的最后一趟跳出循环用 `MergeFinal` kernel（`GPUParticleSimulationPassConstructor.cs:2015 lea r13` 那段）— 它不再 ping-pong，直接写最终 buffer。

**为什么 batch=4096**：HLSL `groupshared` 8 字节 SortKey 数组 × 4096 = 32 KB，刚好顶到 DX11 32KB groupshared 上限（D3D11 thread group shared memory 上限 32 KB 是硬限制，DX12/Vulkan 上限更高但 HG 选 4096 兼容首发平台）。每 group 64 线程，每线程负责 64 颗排序 → 4096/64=64 — 与 64 线程组完美对齐。

---

## 7. GPU Event：Guid 关联的 Sender↔Receiver 跨 system 触发

GPU Event 是这套系统的核心创新点之一 (相对其它 GPU 粒子实现)。设计上：

```csharp
public struct GPUEventFeature   // 见 GPUEventFeature.cs
{
    internal Guid             guid;        // 全局 ID, sender 和 receiver 用同一 guid 关联
    internal GPUEventSender?  senderData;  // != null 即 sender, null 则该 system 仅做 receiver
}

public struct GPUEventSender    // 见 GPUEventSender.cs
{
    internal int eventBufferCount;   // GPU eventBuffer 容量
    internal int eventBufferStride;  // 每事件字节数 (典型 16 = float4)
}
```

`OptionalSystemFeatures` 把 `GPUEventFeature?` 装进 `SystemBase` (`OptionalSystemFeatures.cs`)。

### 7.1 ConstructPass 配对

`ConstructPass` (`GPUParticleSimulationPassConstructor.cs:2171+`) 用 `Dictionary<Guid, int> m_gpuEventDict` 把 sender system 的 dispatch list 索引按 `guid` 注册；然后 `m_receivers : List<int>` 遍历，按 guid 查表把 sender 创建的 `eventBuffer` / `sentCountBuffer` 共享给 receiver 的 `consumedCountBuffer`：

```csharp
// pseudo, 据反汇编 ConstructPass:
m_simulateList.Clear();
m_senderSimulateList.Clear();
m_gpuEventDict.Clear();
m_receivers.Clear();

foreach (sys in GPUParticleSystemManager.instance.GetSpan())
{
    var resources = new SimulateRequiredResources { gpuParticleSystem = sys };

    if (sys.optionalSystemFeatures.HasValue) {
        var feat = sys.optionalSystemFeatures.Value;
        if (feat.sceneRTFeature.HasValue) {
            resources.sceneDepth  = bind sceneRTFeature.sceneDepthID;
            resources.sceneNormal = bind sceneRTFeature.sceneNormalID;
        }
        if (feat.gpuEventFeature.HasValue) {
            var evt = feat.gpuEventFeature.Value;
            if (evt.senderData.HasValue) {
                // sender: 创建 eventBuffer + sentCountBuffer
                resources.gpuEventData.eventBuffer    = renderGraph.CreateComputeBuffer(count=evt.eventBufferCount, stride=evt.eventBufferStride);
                resources.gpuEventData.sentCountBuffer = renderGraph.CreateComputeBuffer(count=1, stride=4);
                resources.gpuEventData.guid           = evt.guid;
                m_gpuEventDict[evt.guid] = m_senderSimulateList.Add(resources);   // sender 进 sender list
            } else {
                // receiver: 暂存, 等 sender pass 创建好后回填
                m_receivers.Add(m_simulateList.Add(resources));
                resources.gpuEventData.guid = evt.guid;
            }
        }
    }
    if (它不是 receiver) m_simulateList.Add(resources);
}

// 第二趟: 给 receiver 填上 sender 的 eventBuffer + consumedCountBuffer (新建)
foreach (var ri in m_receivers) {
    var r = m_simulateList[ri];
    if (m_gpuEventDict.TryGetValue(r.gpuEventData.guid, out int sIdx)) {
        var s = m_senderSimulateList[sIdx];
        r.gpuEventData.eventBuffer    = s.gpuEventData.eventBuffer;          // 共享 sender 的事件流
        r.gpuEventData.consumedCountBuffer = renderGraph.CreateComputeBuffer(count=1, stride=4);  // receiver 自己的 consumer counter
    } else {
        r.gpuEventData.eventBuffer = ComputeBufferHandle.invalid;  // 找不到 sender → buffer 设无效
    }
}
```

证据：`Dictionary<Guid,int>.set_Item / TryGetValue` + `m_senderSimulateList.Add` + `m_receivers.Add` 顺序均在反汇编中可见 (`GPUParticleSimulationPassConstructor.cs:2453-2615`)；ProcessParticles 中 sender 用 `_GPUEventSentCount` (HGShaderIDs+0x368) 绑定，receiver 用 `_GPUEventConsumedCount` (+0x36C) 绑定。

### 7.2 ProcessParticles 的 sender/receiver 分两趟跑

```
Frame N:
  ① ProcessParticles(senderSimulateList, ...)
     ─ sender systems 走 emit/sim/cull/sort/indirect
       sim kernel 设 GPU_EVENT_SENDER=ON, 把死亡 / 出生事件写 eventBuffer
       sentCountBuffer = 总写入事件数
  ② ProcessParticles(simulateList, ...)
     ─ receiver systems 走 emit/sim/cull/sort/indirect
       emit kernel 设 GPU_EVENT_RECIEVER=ON, 从 eventBuffer consume:
         InterlockedAdd(_GPUEventConsumedCount, 1, evtIdx);
         if (evtIdx >= sentCount) return;       // 没事件可吃
         _ParticleAttributes[newSlot] = init_from_event(eventBuffer[evtIdx]);
         AppendLive(newSlot);
```

证据：`ConstructPass` 末尾两次 `AddRenderPass<PassData>(...)` 分别取 `m_senderSimulateList` 和 `m_simulateList` 作为 `senderSimulateList` / `simulateList` 字段。ProcessParticles 内 `sysList` 参数被两次调用。

### 7.3 设计动因

GPU Event 的目的是**让"爆炸→碎片→烟尘"这种串联效果零回 CPU**：
- 主炸弹 system 死亡时 sender 写事件；
- 碎片 system 在 emit 时 receive，**在主炸弹的精确死亡位置 emit**；
- 烟尘 system 又 receive 碎片的死亡 → 多级串联可链式 ABCDE...
- 单帧延迟（事件这帧产，下帧消费），但视觉上完全可接受。

---

## 8. SceneDepth / SceneNormal 碰撞 (SceneRTFeature optional)

```csharp
public struct SceneRTFeature   // 见 SceneRTFeature.cs
{
    internal int sceneNormalID;   // shader id, 用 HGRenderGraph 查纹理
    internal int sceneDepthID;
}
```

`OptionalSystemFeatures.sceneRTFeature` 启用后, ConstructPass 在 `SimulateRequiredResources` 里填 `sceneDepth` / `sceneNormal` / `depthOnlyRT` 三个 `TextureMapping`，并在 `MarkResourceRead` 调 `builder.ReadTexture` 把它们注册为依赖（`GPUParticleSimulationPassConstructor.cs:88-150`）。

随后 ProcessParticles 用 `SetComputeTextureParam` 把它们绑到 simulate kernel 的 `_SceneNormal` / `_DepthOnlyRT` slot（`GPUParticleSimulationPassConstructor.cs:1175-1300, 1500-1600`，每帧每 system 都 IsValid → bind 三次：sceneDepth / depthOnlyRT / sceneNormal）。

simulate kernel 据此做**屏空粒子碰撞**：把粒子位置投到屏空 → 比对 SceneDepth → 撞了就用 SceneNormal 反射速度（标准方法，§5 已示意）。

注：HG 没有走 SDF/Voxel 碰撞（开销大），靠屏空近似 — 镜头切换瞬间会有粒子穿模，但战斗节奏下不显。

---

## 9. Particle Lighting Pass：4096/system × 64 thread compute + IV + ASM + binning

`ParticleLightingPassConstructor` (`ParticleLightingPassConstructor.cs`) 在 Lighting 阶段（不透明 / 透明前），对每 system **最多 4096 颗** 粒子做一次 compute lighting。

### 9.1 常量

```csharp
internal const int THREAD_COUNT       = 64;     //   每 group 64 线程
internal const int MAX_PARTICLE_COUNT = 4096;   //   每 system 最多 4096 颗参与 per-particle lighting
```
来源：`ParticleLightingPassConstructor.cs:48-50`。

ThreadGroups = `ceil(4096 / 64) = 64`，单 system 64 groups。

### 9.2 输入/输出

```csharp
public struct PassInput
{
    internal ComputeBufferHandle binningBufferHandle;  // 共用光源/反射探针 tile binning (来自 BinningPass, 见 04-LightingAO.md)
    internal ParticleLightingIVInput ivInput;          // 辐照度体积输入 (SH L1 × RGB + 3 IV param), 见下
}

public class ParticleLightingPassData
{
    internal ComputeShader      lightingCS;             // 来自 resources+0x478
    internal int                lightingKernel;         // = lightingCS.FindKernel("ParticleLightingMain")
    internal RTHandle           asmShadowMapRT;         // HGASMManager.GetASMManager().asmShadowMapRT
    internal ComputeBufferHandle lightingResultBuffer;   // 输出: 每粒子 lighting 结果
    internal ComputeBufferHandle binningBufferHandle;    // = passInput.binningBufferHandle
    internal CBHandle           ivInputCBHandle;        // 常量缓冲, 装载 ParticleLightingIVInput (0xA0=160 字节)
}
```

`ParticleLightingIVInput` blittable 布局 (来自 `UnityEngine.HyperGryphEngineCode.ParticleLightingIVInput`, C++ 模块导出)：

```csharp
public struct ParticleLightingIVInput  // 见 UnityEngine.HyperGryphEngineCode/ParticleLightingIVInput.cs
{
    public Matrix4x4 invViewMatrix;     // 64 字节: 屏空 → 世界
    public Vector4   IVParam0;          // 16: IV 网格中心 / 缩放
    public Vector4   IVParam1;          // 16: IV cell 步长 / 边界
    public Vector4   IVParam2;          // 16: IV 总尺寸 / 衰减
    public Vector4   IVDefaultSHAr;     // 16: SH L1 R (4 系数, fallback 用)
    public Vector4   IVDefaultSHAg;     // 16: SH L1 G
    public Vector4   IVDefaultSHAb;     // 16: SH L1 B
    //                          总 160 = 0xA0 字节
}
```
ConstructPass 用 `ScriptableRenderContext.AllocateConstantBuffer(size=0xA0)` 申请一个 `CBHandle`，然后 `Unity.Collections.LowLevel.Unsafe.UnsafeUtility.MemCpy(cb, &ivInput, 0xA0)`（`ParticleLightingPassConstructor.cs:280-310`）把整个结构体 memcpy 进去。

证据：`ScriptableRenderContext::AllocateConstantBuffer ... r8d=0xA0h` (`ParticleLightingPassConstructor.cs:288-292`) → 160 字节恰等 `sizeof(ParticleLightingIVInput)`。

### 9.3 lightingResultBuffer 申请

```csharp
// 据反汇编 ParticleLightingPassConstructor.cs:184-200:
new ComputeBufferDesc {
    count  = 0x1000,   // 4096
    stride = 0x10,     // 16 字节 (= float4 = RGB + 强度 / 系数)
    target = (0 → Default, 即普通 structured)
}
renderGraph.CreateComputeBuffer(desc);  // → m_lightingResultBuffer
```
即输出是 `float4[4096]` (4096 颗 × 16 字节)。

### 9.4 ASM 与 binning 集成

- **ASM 阴影**：`asmShadowMapRT = HGASMManager.GetASMManager().asmShadowMapRT`，从 `HGCamera+0x60 → HGASMManager.GetASMManager() → +0x38` 取得（`ParticleLightingPassConstructor.cs:320-336`）；compute kernel 直接采 ASM RT 算阴影。
- **Light Binning**：用 BinningPass 算出的 tile/cluster 索引列表，粒子 lighting kernel 把粒子投到屏空 → 查 tile → 遍历该 tile 的灯列表算 N·L，避免遍历全部灯。

### 9.5 PER_PARTICLE_SYSTEM_LIGHTING keyword

```csharp
internal static void SwitchParticleLightingKeywords(bool enabled)
{
    if (enabled) Shader.EnableKeyword("PER_PARTICLE_SYSTEM_LIGHTING");
    else         Shader.DisableKeyword("PER_PARTICLE_SYSTEM_LIGHTING");
}
```
来源：`ParticleLightingPassConstructor.cs:98-141`。粒子材质 (`HGRP/Effect/VFXBaseV2`) 据此决定是 sample `lightingResultBuffer[liveListIdx]` 走预计算光照 (low cost)，还是回退到 fragment 内的逐光源采样 (high cost)。

---

## 10. Indirect Draw：DrawIndirectArgs + Quad Index 64K Triangle Strip

### 10.1 m_quadIndexBuffer

base ctor 在最后用 `GraphicsBuffer.Target.Index` (=`(0+2)=2`? actually GraphicsBuffer.Target.Index 在 Unity 是 `2`) 分配 `m_quadIndexBuffer`：

```
// 据 GPUParticleSystemBase.cs:474-489:
new GraphicsBuffer(
    target  = (GraphicsBuffer.Target)(r15+2),  // ≈ Index|Raw 或 Index|Structured
    count   = (totalParticles - 2),
    stride  = 2,                                 // ushort
    usage   = (GraphicsBuffer.UsageFlags)(default)
);

// 立即 SetData(NativeArray<uint>) 一段 6 × N 的 indices, 4 vertex per particle (quad)
// (NativeArray ctor 里 mov rax,[rax+0Ch],r13d  3   ← 3 indices/triangle, 2 triangle/quad = 6 实际不止)
```

实际是 `2 + (particleCap*instanceCap - 2)` 长度 — 这是经典的 **"全局共享 quad index buffer"** 模式：一颗粒子 = 1 quad = 2 triangles = 6 indices，但用 **triangle strip** 时连续 N 个 quad 只需 4 + 2(N-1) = 2N+2 indices，因此 buffer 长度 = `2 + 4 * particleCap * instanceCap`（与反汇编里 `lea r14d, [r15+2]`、`lea esi, [r15-2]` 的 +2/-2 模式一致）。

### 10.2 DrawIndirectArgs (5 uint, stride 12 不对? 实际 stride 20)

base ctor `r9d=100h=256` 是 IndirectArgs buffer 的 element count；标准 `Graphics.DrawProceduralIndirect` 的 args buffer stride 是 5 uint = **20 字节**。

```hlsl
indirectArgs[0] = indexCountPerInstance;   // = 4 * liveCount + ...
indirectArgs[1] = instanceCount;            // = liveCount
indirectArgs[2] = startIndexLocation;       // 0
indirectArgs[3] = baseVertexLocation;       // 0
indirectArgs[4] = startInstanceLocation;    // 0
```

`m_particleIndirectArgsShader::CSMain` 单线程组单线程写完。

### 10.3 渲染调用

`AcquireRenderContext()` (`GPUParticleSystemBase.cs:1252-1334`) 打包 `RenderContext`：

```csharp
internal struct RenderContext
{
    internal Mesh                mesh;              // = 渲染用 mesh (可空, procedural)
    internal GraphicsBuffer      indexBuffer;       // = m_quadIndexBuffer
    internal ComputeBuffer       drawIndirectArgsBuffer;
    internal Material            material;          // = HGRP/Effect/VFXBaseV2 子材质
    internal ComputeBuffer       particleAttributesBuffer;
    internal ComputeBuffer       liveListBuffer;
    internal ComputeBuffer       generalSystemAttributeBuffer;
    internal int                 instanceCount;
}
```
随后某个 Forward/Transparent Pass 用 `Graphics.DrawProceduralIndirect` (或 `RenderingCommandBuffer.DrawProceduralIndirect`) 拉这一组出图，shader 里：

```hlsl
StructuredBuffer<float4> _ParticleAttributes : register(...);  // 用 vid/4 索引粒子
StructuredBuffer<uint>   _SortedLiveList : register(...);

VertexOut VS(uint vid : SV_VertexID, uint iid : SV_InstanceID)
{
    uint quadVid    = vid % 4;
    uint particleId = _SortedLiveList[ vid / 4 ];   // 远 → 近
    float4 attr0 = _ParticleAttributes[particleId*stride16 + 0];  // pos+life
    float4 attr1 = _ParticleAttributes[particleId*stride16 + 1];  // vel/color/size

    float3 worldPos = attr0.xyz;
    // billboard 出 4 顶点 quad
    float2 corner = QuadCorners[quadVid];   // 4 个角
    float3 vsPos  = mul(_ViewMatrix, float4(worldPos,1)).xyz;
    vsPos.xy += corner * size;
    o.svPos  = mul(_ProjMatrix, float4(vsPos,1));
    o.uv     = QuadUVs[quadVid];
    o.color  = attr1.color;
    return o;
}

half4 PS(VertexOut i) : SV_Target {
    half4 tex = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, i.uv);
#if PER_PARTICLE_SYSTEM_LIGHTING
    half4 lit = _LightingResultBuffer[i.particleId];   // 从 ParticleLightingPass 拿结果
    tex.rgb *= lit.rgb;
#endif
    return tex * i.color;
}
```

材质 shader 名固定见 `VFXShaderStringConstants.cs`：

```csharp
public const string SHADER_NAME_VFX_BASE_V2 = "HGRP/Effect/VFXBaseV2";
public const string SHADER_NAME_CHARACTER_NPR = "HGRP/CharacterNPR";
public const string SHADER_NAME_LIT_EFFECT = "HGRP/LitEffect";
```

---

## 11. 与 HDRP VFX Graph 的设计动因对照

为完整起见对照 HDRP / VFX Graph：

| 维度 | HDRP VFX Graph | HG GPU Particle |
|---|---|---|
| 入口 | `VFXManager.PrepareCamera` / `ProcessCamera` (`com.unity.visualeffectgraph@.../Runtime`) | `GPUParticleSimulationPassConstructor::ConstructPass` |
| 资源描述 | ScriptableObject `.vfx` 文件 (节点图编译为 dispatch 表) | C# `GPUParticleShaders` 直接持 `ComputeShader` 引用, 美术配数 |
| Emit | 节点图生成 emit context, 每帧由 VFXManager 调度 | 用户 `emitShader::CSMain` + per-instance `emitRate` |
| Update | 节点图 update context | 用户 `simulateShader::CSMain` |
| 排序 | VFX Graph 内部 quick sort kernel | HG 4096-batch bitonic + ping-pong merge |
| 间接绘制 | VFX Graph 调 `Graphics.DrawIndirect` (但走 srpBatcher 优化) | HG 直接 `DrawProceduralIndirect` |
| 子发射 | "spawn" context, 编译期固定 | HG `GPU_EVENT_SENDER/RECIEVER` keyword + Guid runtime 配对 |
| 光照 | VFX Graph block "Sample Probe Volume" etc, 逐 fragment 重算 | HG **每 system 一次 compute lighting 写 buffer**, fragment 只 lookup, **复杂场景大量节省 fragment ALU** |
| 学习曲线 | 高 (节点图 + HLSL include 链) | 中 (写两个 compute shader + 注册一次) |
| 移动端友好 | 中 (依赖 VFX Graph runtime + jit compile) | 高 (一切静态编译, 移动端 Vulkan/Metal 友好) |

HG 的选择：**牺牲编辑器友好换运行时控制力**，与项目移动端 + NPR + 自研 RenderGraph 整体一致。

---

## 12. VFX MonoBehaviour 子系统 (PP / 场景调色 / 假体积雾 / 排序覆盖)

C10 单元的 41 个文件除核心 GPU 粒子外，包含一组 **场景里挂着的 VFX 控件 MonoBehaviour**，它们不参与 GPU 粒子 dispatch，而是**修改材质参数 / Volume Profile / Renderer 状态**。下表归类：

### 12.1 VFXPlayable 基类与生命周期

```csharp
public interface IVFXPlayable { void Play(); void Stop(); }

public abstract class VFXPlayableMonoBase : MonoBehaviour, IVFXPlayable
{
    private bool m_isPlaying;
    [ContextMenu("Play")] public void Play()  { if (!m_isPlaying) { m_isPlaying=true;  if (isActiveAndEnabled) OnPlay(); } }
    [ContextMenu("Stop")] public void Stop()  { if ( m_isPlaying) { m_isPlaying=false; if (isActiveAndEnabled) OnStop(); } }
    public void OnEnable()  { if (m_isPlaying) OnPlay(); }
    public void OnDisable() { if (m_isPlaying) OnStop(); }
    protected abstract void OnPlay();
    protected abstract void OnStop();
}
```
来源：`VFXPlayableMonoBase.cs:5-120`。`m_isPlaying` 与 `isActiveAndEnabled` 的真值表保证：开了 + 启了才真注册。

### 12.2 VFXPPComponent (后处理 VFX 基类)

```csharp
public class VFXPPComponent : VFXPlayableMonoBase
{
    [SerializeField] protected VFXPPPriority m_priority;
    protected float m_tweenNum;
    protected VFXPPData m_targetData;
    protected VFXPPData m_snapShotData;
    protected virtual VFXPPType m_VFXPPType => default;
    public virtual bool ImplementedInVolume => false;
    public VFXPPPriority priority => m_priority;

    protected override void OnPlay()  { VFXPPManager.instance.AddActiveComponent(m_VFXPPType, this); }
    protected override void OnStop()  { VFXPPManager.instance.RemoveActiveComponent(m_VFXPPType, this); }
    public virtual void SetData(VFXPPData data)  { throw new NotImplementedException(); }
}
```
来源：`VFXPPComponent.cs`. 

### 12.3 VFXPPType / VFXPPPriority 枚举

```csharp
public enum VFXPPType
{
    Unknown = -1, ChromaticAberration = 0, Vignette, RadialBlur,
    ColorAdjustments, ScanLine, BWFlash, DirtyLens, BaseMaterials,
    Fog, CutsceneEffect, CharacterLight, CharacterDirectionalLight,
    CharacterRimLight, BlackBox, CharacterBloom, FisheyeEffect, Count = 16
}

public enum VFXPPPriority
{
    Normal = 0,   Skill = 100,   UltiSkill = 200,
    UltiSkillCam = 220,   Cinematic = 300,   UI = 400
}
```
来源：`VFXPPType.cs`, `VFXPPPriority.cs`。

### 12.4 VFXPPManager

```csharp
public class VFXPPManager : MonoBehaviour
{
    private List<List<VFXPPComponent>> m_activeComponents;   // 按 VFXPPType (16 桶) 分桶
    private Volume                     m_ppVolumeForVFX;     // 自动 AddComponent<Volume> 到自身
    private VolumeProfile              m_ppVolumeProfile;
    private HGEnvironmentVolume        m_envVolumeForVFX;    // 自动 AddComponent<HGEnvironmentVolume>
    private HGEnvironmentPhase         m_envPhaseForVFX;
    private VFXPPPriority              m_curPriorityFilter;
    protected static VFXPPManager      s_instance;

    public static VFXPPManager instance => s_instance;
}
```
来源：`VFXPPManager.cs`。在 `OnBeginFrameRendering` 回调里 (`RenderPipelineManager.add_beginFrameRenderingNoAlloc`)，按 priority filter 选当前最高优先级的 PPComponent，把它们 `Apply(volumeProfile)` 注入到管理的 Volume Profile（每帧重建），从而**优先级高的覆盖优先级低的**。例如：

- 平时 `Normal` (0) 的 VFXPPColorAdjustments 跑；
- 释放大招时挂一个 `UltiSkill` (200) 的 ChromaticAberration + Vignette → 完全覆盖 Normal；
- Cinematic (300) 高于 UltiSkill；UI (400) 最优先 (菜单调色)。

### 12.5 各 VFXPP 子类对照

| 类 | 类型 | 数据 (`VFXPPData` 子类) | 注入路径 |
|---|---|---|---|
| `VFXPPChromaticAberration` | `ChromaticAberration` | `VFXPPChromaticAberrationData` (intensity + flags) | `Volume<HGChromaticAbberation>` |
| `VFXPPVignette` | `Vignette` | `VFXPPVignetteData` (color/intensity/smoothness/rounded/blink) | `Volume<HGVignette>` |
| `VFXPPColorAdjustments` | `ColorAdjustments` | (saturation + color) | `Volume<ColorAdjustments>` |
| `VFXPPRadialBlur` | `RadialBlur` | `VFXPPRadiaBlurData` | `Volume<HGRadialBlur>` |
| `VFXPPScanLine` | `ScanLine` | — | `Volume<HGScanLine>` + 自定 pass `VFXPPScanLinePass` |
| `VFXPPBWFlash` | `BWFlash` | — | `Volume<HGBWFlash>` |
| `VFXPPDirtyLens` | `DirtyLens` | — | `Volume<HGAnamorphicStreaks>?` (DirtyLens 桶) |
| `VFXPPFisheyeEffect` | `FisheyeEffect` | — | `Volume<HGFisheyeEffect>` |
| `VFXPPBlackBox` | `BlackBox` | — | 黑场遮罩 (转场用) |
| `VFXPPCutsceneEffect` | `CutsceneEffect` | `VFXPPCutsceneEffectData` (Shape/Range/Offset/Intensity 各样参数, 见 `VFXPPCutsceneEffect.cs:13-40` 内部 `ShaderConstants` 静态类) | 全屏材质 |
| `VFXPPCharacterLight` / `CharacterDirectionalLight` / `CharacterRimLight` / `CharacterBloom` | 4 个 Character 桶 | `CharLightVolumeData` | `Volume<HGCharacterVolume>` |
| `VFXPPScreenMaterial` | `BaseMaterials` | 全屏 Renderer + `HGRP/Effect/VFXBaseV2` 材质 | `FullScreenVFXData.fullScreenMesh` |

详见 `VFXPPColorAdjustments.cs`, `VFXPPChromaticAberration.cs`, `VFXPPVignette.cs`, `VFXPPCharacterLight.cs`, `VFXPPCutsceneEffect.cs`, `VFXPPScreenMaterial.cs` 等。

### 12.6 HGVFXManager (场景级 VFX 状态)

```csharp
public class HGVFXManager
{
    private List<VFXSceneDark> m_sceneDarks;          // VFXSceneDark 控件列表
    private Vector3            m_currentSceneDarkValue;
    private float              m_currentSceneSaturation;
    private bool               m_currentNeedStopAutoExposure;
    // ... last 三同名 _last 版做插值 lerp
    private Dictionary<int, float> m_savedCameraAutoExposure;  // stop autoExposure 时保存原值
    private Vector3   m_playerPosition;              // SetPlayerPosition
    private Vector4   m_playerHeights;               // SetPlayerHeights (上下颈/肚 4 段)
    private Vector2   m_anchorPosition;              // AnchorWaveBright (Anchor 闪光)
    private float     m_anchorRadius, m_anchorBrightIntensity;
    private bool      m_anchorBrightFlag;
    private Material  m_vfxSceneColorAdjustmentMaterial;  // 全屏色彩材质 (PrintShader 那种)
}
```
来源：`HGVFXManager.cs`。功能：

- **Scene Dark 列表**：`VFXSceneDark` 控件（角色进暗室/被烟雾覆盖时）调 `AddSceneDarkToManager` 注册；`Tick()`→`_UpdateSceneDarkValue()` 每帧用 `Color.op_Subtraction` + `Quaternion.Dot` 检测变化大于阈值 (0.01f, `SCENE_DARK_VALUE_CHANGE_THRESHOLD`) 才更新 HGRenderPipeline 的全局调色（与帧间稳态对比避免抖动）；
- **playerPosition / playerHeights**：上传给特效 shader 让粒子知道玩家在哪 (例如角色雾、粒子吸附/避让玩家)；
- **AnchorWaveBright**：特定锚点 (NPC / 标志物) 处的闪光波 (`getAnchorWaveBright` 返回 `vector4(pos.xy, radius, intensity * flag)` 给 shader)。

### 12.7 VFXSceneDark / VFXAutoEmissiveRate / VFXBackFaceHide / VFXSortingOrder / VFXFakeVolumeFog / VFXSampleParticleSystem

这些是 **挂在 prefab 上的辅助控件**，与 GPU 粒子无直接耦合：

| 类 | 职责 | 实现要点 |
|---|---|---|
| `VFXSceneDark` | 场景颜色调节 (调暗 + 饱和度 + 停曝光) | `OnPlay/OnStop` 调 `HGVFXManager.AddSceneDarkToManager`，每帧 manager 选 sceneDarks[] 末位 (LIFO) 应用 |
| `VFXAutoEmissiveRate` | 物体缩放 → 粒子数 自动放大 (1x → 10x) | 监听 `transform.lossyScale`，按 `ScaleMode (Global/Local)` × `AxisBitMask (X/Y/Z)` 计算系数，乘到 `ParticleSystem.emission.rateOverTime`，最大 10×10×10 |
| `VFXBackFaceHide` | 角色背面隐藏 (低成本 cull 替代) | `OnPlay` 注册 `RenderPipelineManager.beginCameraRendering`，每相机回调里看 dot(faceDir, viewDir)，按 `fadeRange` 写 `MaterialPropertyBlock(s_TintColorAlpha, alpha)` |
| `VFXSortingOrder` | Renderer 强制 sortingOrder | `Awake` 取 `GetComponent<Renderer>`，`OnEnable/OnValidate` 写 `Renderer.sortingOrder` |
| `VFXFakeVolumeFog` | 假体积雾 (与 C05 `FakeFogSimple` 同类) | MeshRenderer 走自定 shader (NearFadeDistance / FogColor / FogExponent / FogDensity / 3D Noise / Height Falloff / StencilOp 等十几个属性, 全部 PropertyBlock 上传)。`IBeyondTrigger*` 接口让 Beyond Gameplay 用 Trigger 体积控其开关 |
| `VFXSampleParticleSystem` | 空 stub (用于序列化标记) | `public class VFXSampleParticleSystem : MonoBehaviour { }` ， 留作"采样目标"标签 |

后处理列入 C16，本节只覆盖 C10 的 VFX 系列 MonoBehaviour 控件入口。

---

## 13. 1:1 复刻蓝图 (分步)

### 13.1 基础设施 (无依赖)

1. **三个值类型**：`GeneralSystemAttributes` (16B)、`PerInstanceData` (32B)、`FixedParticleAttrib` (32B, 内嵌)。三者均 `[StructLayout(LayoutKind.Sequential, Pack=4)]`。
2. **`GPUParticleShaders` 结构体**：`{ ComputeShader emitShader; ComputeShader simulateShader }`。**用户提供**。
3. **三个 optional feature 结构体**：`GPUEventSender { int eventBufferCount; int eventBufferStride }`、`GPUEventFeature { Guid guid; GPUEventSender? senderData }`、`SceneRTFeature { int sceneNormalID; int sceneDepthID }`、`OptionalSystemFeatures { SceneRTFeature?; GPUEventFeature? }`。
4. **Manager 单例骨架**：`GPUParticleSystemManager s_instance`；`SystemList` (内部数组容量 128)，`List<int> m_freePool`，`maxParticleCount / maxGPUInstanceCount`。

### 13.2 SystemBase 容器

5. ctor 一次性分配 8 个 buffer + 1 个 quad index buffer，按 §3.4 的 stride/count 表。
6. `CreateInstance(in PerInstanceData)` / `RemoveInstance(int)`：维护 CPU `List<int> m_instances` + `List<int> m_freePool` + `List<int> m_instancesToClear`。`OnInstanceCreated` 调 `ComputeBuffer.SetData(perInstanceList, count=1, sourceStart=…, destStart=gpuIndex)`；`OnInstanceRemoved` 用 3 次 `Graphics.CopyBuffer` 在 GPU 内搬移最后一个 instance 到被删除位（avoid hole）。
7. `Modify(in GeneralSystemAttributes)`：`NativeArray<GeneralSystemAttributes>{ in } → ComputeBuffer.SetData`。
8. `AcquireSimulateContext()` / `AcquireRenderContext()`：把 9 个 buffer 引用 + 元数据塞进 struct 给 PassConstructor 用。

### 13.3 PassConstructor

9. ctor 从 `HGRenderPathResources` 偏移 `0xA0..0xC0` 取 5 个 ComputeShader, `FindKernel` 取 8 个 kernel index，初始化 2 个 `LocalKeyword`：`"GPU_EVENT_SENDER"` / `"GPU_EVENT_RECIEVER"`。
10. `ConstructPass` 两趟：
    - 一趟把 manager 的所有 system 翻成 `SimulateRequiredResources`，sender 进 `m_senderSimulateList`，其它进 `m_simulateList`，receiver 用 guid 注册在 `m_gpuEventDict` 等回填。
    - 二趟用 `m_gpuEventDict[guid]` 回填 receiver 的 `eventBuffer` (= sender 的) + 新建 `consumedCountBuffer`。
11. RenderGraph 注册两个 pass（先 sender, 再 receiver），都用同一 `RenderFunc<PassData>` (`ProcessParticles`)，`builder.WriteComputeBuffer` 注册 dead/live/indirect 写依赖、`ReadTexture` 注册 sceneDepth/Normal 读。

### 13.4 ProcessParticles RenderFunc (每帧每 system)

12. CB.UpdateData `_PerFrameVariables = { seed = Random.Range(INT_MIN, INT_MAX) (用 DateTime.Now.Ticks 初始化) }`。
13. 对每 system：
    - ① 若 `instancesToClear` 非空，对每个 clear 调 cleanupShader::CSMain，ThreadGroups=ceil(particleCap/64)；
    - ② 按 sender/receiver 设两个 keyword + 绑 GPU Event buffer；
    - ③ ConstantBuffer.Set 各 cbuffer，绑所有 raw buffer (用户 emitShader::CSMain 跑 emit, ThreadGroups=ceil(maxEmitRate/64))；
    - ④ user simulateShader::CSMain 跑 update, 绑 SceneRT (若启), ThreadGroups=ceil(particleCap/64)；
    - ⑤ m_particleCullKernel::CSMain 跑 cull, 写 SortedLiveList(SortKey)+InterlockedAdd LiveCount；
    - ⑥ bitonic sort: 4096 batch + 多趟 merge ping-pong (`SORT_BATCH_SIZE=4096`, `MergePassConstants{blockSize, groupCount}` cbuffer, 用 MergeFinal 收尾)；
    - ⑦ m_particleIndirectArgsKernel::CSMain 单 group 单线程写 IndArg。

### 13.5 ParticleLighting Pass

14. ctor: `lightingCS = resources+0x478; lightingKernel = lightingCS.FindKernel("ParticleLightingMain");`
15. ConstructPass: 申请 `lightingResultBuffer = ComputeBuffer(count=4096, stride=16)`；申请 `CBHandle ivInputCBHandle = AllocateConstantBuffer(0xA0)` + `UnsafeUtility.MemCpy(cb, &ivInput, 0xA0)`。
16. 绑 `binningBufferHandle (read)`、`lightingResultBuffer (write)`、`asmShadowMapRT`、`ivInputCBHandle`。Dispatch (1, 1, 1) groups? 或 (64, 1, 1)：从代码 `r9d=1`（dispatch z）+ keyword `PER_PARTICLE_SYSTEM_LIGHTING` 推断，**4096 颗 / 64 线程 = 64 groups × 1 × 1**。
17. shader: `[numthreads(64,1,1)] ParticleLightingMain(uint3 dtid)`，每线程一颗粒子，sample tile binning + ASM + IV SH → 写 `lightingResultBuffer[dtid.x]`。

### 13.6 渲染调用

18. Forward/Transparent Pass 用 `material(HGRP/Effect/VFXBaseV2)` + `Graphics.DrawProceduralIndirect(material, mesh, indexBuffer=m_quadIndexBuffer, args=m_drawIndirectArgsBuffer)`。Material `MaterialPropertyBlock` 绑 `_ParticleAttributes`/`_SortedLiveList`/`_LightingResultBuffer` 等。

### 13.7 VFX MonoBehaviour 子系统

19. 实现 `IVFXPlayable` 接口 + `VFXPlayableMonoBase` 抽象类 (Play/Stop/OnEnable/OnDisable 模板方法)。
20. 实现 `VFXPPType` (16 桶) + `VFXPPPriority` (6 档) + `VFXPPManager`：16 桶 `List<VFXPPComponent>`，`OnBeginFrameRendering` 按 priority filter 选最高档 → 拼 VolumeProfile 注入 PP 链；按需 `Apply(volumeProfile)` 由各子类提供。
21. 实现 `HGVFXManager` 单例：SceneDark 列表 + 帧间 lerp (`m_lastUpdateTime` + 阈值 `0.01f`) + playerPosition/Heights/AnchorWaveBright 全局参数上传 + 0xA0 字节 IV cbuffer 申请/写。
22. 控件类：`VFXSceneDark` (HGVFXManager Add/Remove)、`VFXAutoEmissiveRate` (按 lossyScale × axisBitMask 乘 emission rate)、`VFXBackFaceHide` (camera-loop dot+fade)、`VFXSortingOrder` (Renderer.sortingOrder 一行)、`VFXFakeVolumeFog` (MeshRenderer + 自定 shader props + IBeyondTrigger* 接口)。

### 13.8 集成点

- 注册 PassConstructor 到 RenderPath 的 PreRender 节点 (`HGRenderPathBase.RenderPathResources` 中名为 `m_gpuParticleSimulationPassConstructor`)；Profile id 9 命名 `"Particle Simulation"`。
- 注册 ParticleLighting 到 Lighting 节点；Profile id 10 命名 `"Particle Lighting"`。
- 提供 HG 风格的 `IPassConstructor` 接口 4 个空方法 (`PrepareShaderVariablesGlobal/OnPreRendering/OnPostRendering/Dispose`)。

---

## 14. 关键常量 / 魔数总表

| 常量 | 值 | 来源 | 含义 |
|---|---|---|---|
| `MAX_SYSTEM_COUNT` | 128 | `GPUParticleSystemManager.cs:592` | Manager 同时可注册的 GPU 粒子 system 上限 |
| `MAX_INSTANCE_COUNT` | 64 | `GPUParticleSystemBase.cs:15` | 单 system 同时可激活的 instance 上限 |
| `SORT_BATCH_SIZE` | 4096 | `GPUParticleSimulationPassConstructor.cs:258` | Bitonic sort 单 batch 粒子数 (== DX11 32KB groupshared 上限 ÷ 8B SortKey) |
| `THREAD_COUNT` | 64 | `ParticleLightingPassConstructor.cs:48` | 粒子 lighting kernel 线程组大小 |
| `MAX_PARTICLE_COUNT` | 4096 | `ParticleLightingPassConstructor.cs:50` | 每 system 参与 per-particle lighting 的粒子上限 |
| `1/64.0f` | `g_18E5EC474` | sim pass / terrain deform 共用 | Dispatch ThreadGroups = ceil(N × 1/64) 之 ÷64 因子 |
| `1/1024.0f` | `g_18E5EC428` | sim pass merge 阶段 | Dispatch ThreadGroups = ceil(N × 1/1024) 之 ÷1024 因子 (sort merge 阶段每 group 处理 1024 对 KV) |
| `IndirectArgs ele count` | 256 | `GPUParticleSystemBase.cs` 反汇编 `r9d=100h` | 5-uint indirect args 缓冲容量 (允许同 system 多 draw call) |
| `FixedParticleAttrib size` | 32 字节 | `GPUParticleSystemBase.cs:8-13` (2 × Vector4) | 粒子属性最小字节数 |
| `GeneralSystemAttributes size` | 16 字节 | `GeneralSystemAttributes.cs` (4 × int) | 系统级常量 cbuffer 字节数 |
| `PerInstanceData size` | 32 字节 | `PerInstanceData.cs` (Vec4 + 4 × int) | 单 instance 属性字节数 |
| `ParticleLightingIVInput size` | 160 (0xA0) 字节 | `ParticleLightingIVInput.cs` 4×4+6×16 | IV cbuffer 字节数 |
| `lightingResultBuffer stride` | 16 字节 | `ParticleLightingPassConstructor.cs:184-200` (mov eax,10h) | 单粒子光照结果 float4 |
| `lightingResultBuffer count` | 4096 | `ParticleLightingPassConstructor.cs:184-200` (mov ecx,1000h) | == MAX_PARTICLE_COUNT |
| `SCENE_DARK_VALUE_CHANGE_THRESHOLD` | 0.01f | `HGVFXManager.cs:13` | 场景调暗插值变化阈值 |
| `LIVE_LIST_ATOM_STRIDE` | 4 字节 | base ctor `r15d=...; r8d=r15d` 创建 raw uint buffer | live/dead list 都是 uint 索引 |
| `_MergePassConstants size` | 8 字节 | `GPUParticleSimulationPassConstructor.cs:25-30` (2 × uint) | sort merge cbuffer |
| `_PerFrameVariables size` | 4 字节 | `GPUParticleSimulationPassConstructor.cs:39-42` (1 × uint) | per-frame seed cbuffer |

### 14.1 LocalKeyword

| Keyword 字符串 | 用途 | 设值时机 |
|---|---|---|
| `"GPU_EVENT_SENDER"` | 启用 simulate shader 的死亡/出生事件写入路径 | 当前 system 是 sender 时, simulate dispatch 前 |
| `"GPU_EVENT_RECIEVER"` | 启用 emit shader 的事件 consume 路径 | 当前 system 是 receiver 时, emit dispatch 前 |
| `"PER_PARTICLE_SYSTEM_LIGHTING"` | 渲染 shader 走 lookup-table 光照 vs fragment 实时光照 | `ParticleLightingPassConstructor.SwitchParticleLightingKeywords(bool)` 全局开关 |

### 14.2 Kernel name 字符串

| 字符串 | Shader | 注 |
|---|---|---|
| `"CSMain"` | cleanup / init / cull / indirectArgs / 用户 emit/simulate | 5 个 + 用户 2 个 |
| `"Sort"` | particleSortShader | 单 batch 4096 sort |
| `"SortFinal"` | particleSortShader | 末批 (< 4096) sort |
| `"Merge"` | particleSortShader | 跨 batch 中间 merge |
| `"MergeFinal"` | particleSortShader | 末趟 merge (写最终输出) |
| `"ParticleLightingMain"` | lightingCS | per-particle compute lighting |

---

## 15. 源文件清单 (41 个)

### 15.1 GPU 粒子核心 (10)

| 文件 | 职责 |
|---|---|
| `GPUParticleSystemManager.cs` | 单例 Manager，128 槽 SystemList，CreateParticleSystem/Instance，Modify，maxParticleCount 聚合 |
| `GPUParticleSystem.cs` | 泛型 `GPUParticleSystem<SYSTEM_ATTRIB> : GPUParticleSystemBase`，多出一个 `m_systemAttribsBuffer` 强类型 cbuffer |
| `GPUParticleSystemBase.cs` | 非泛型基类，8 ComputeBuffer + GraphicsBuffer 分配/复制/释放，PerInstanceData + GeneralSystemAttributes + FixedParticleAttrib 类型，AcquireSimulateContext/AcquireRenderContext |
| `GPUParticleShaders.cs` | `{ ComputeShader emitShader; ComputeShader simulateShader }` 用户提供 |
| `GPUParticleSimulationPassConstructor.cs` | RenderGraph Pass，5 ComputeShader + 8 kernel 持有，每帧 emit→update→cull→sort→indirect 全链路 dispatch，含 GPU Event 配对逻辑 |
| `ParticleLightingPassConstructor.cs` | 粒子 compute lighting Pass，64 thread × 64 group × 4096 颗，IV cbuffer + ASM RT + binning buffer |
| `GPUEventFeature.cs` | `{ Guid guid; GPUEventSender? senderData }` |
| `GPUEventSender.cs` | `{ int eventBufferCount; int eventBufferStride }` |
| `FullScreenVFXData.cs` | 全屏三角形 mesh (`CreateTriangleMesh`) + 全屏 VFX 标志位，供 VFXPPScreenMaterial 走 procedural 三角形 |
| `IVFXPlayable.cs` | `{ void Play(); void Stop() }` 接口 |

### 15.2 VFXPlayable / VFXPP 后处理子系统 (19)

| 文件 | 职责 |
|---|---|
| `VFXPlayableMonoBase.cs` | 抽象基类 with `Play/Stop/OnEnable/OnDisable`，子类实现 `OnPlay/OnStop` |
| `VFXPPManager.cs` | 单例 MonoBehaviour，16 桶 `VFXPPType` × `List<VFXPPComponent>`，按 priority filter 拼 VolumeProfile 注入 PP |
| `VFXPPComponent.cs` | VFXPP 基类 (继承 VFXPlayableMonoBase)，priority/SetData/Apply/m_VFXPPType/ImplementedInVolume |
| `VFXPPType.cs` | 16 项枚举 (ChromaticAberration/Vignette/RadialBlur/ColorAdjustments/ScanLine/BWFlash/DirtyLens/BaseMaterials/Fog/CutsceneEffect/CharacterLight/CharacterDirectionalLight/CharacterRimLight/BlackBox/CharacterBloom/FisheyeEffect) |
| `VFXPPPriority.cs` | 6 档枚举 (Normal/Skill/UltiSkill/UltiSkillCam/Cinematic/UI) |
| `VFXPPData.cs` | 数据基类 `{ VFXPPPriority priority }` |
| `VFXPPChromaticAberration.cs` | 色差 (intensity/useAsCenterPosition/averageSteps) |
| `VFXPPChromaticAberrationData.cs` | 上面的数据载体 |
| `VFXPPVignette.cs` | 暗角 (color/intensity/smoothness/rounded/blink) |
| `VFXPPVignetteData.cs` | 上面的数据载体 |
| `VFXPPColorAdjustments.cs` | 后处理调色 (saturation/color) |
| `VFXPPRadialBlur.cs` | 径向模糊 |
| `VFXPPRadiaBlurData.cs` | 径向模糊数据载体 (注: 文件名拼写 `Radia` 不是 `Radial`，反编译原状) |
| `VFXPPScanLine.cs` | 扫描线 |
| `VFXPPScanLinePass.cs` | 扫描线专用 RenderPass (与 Volume 集成) |
| `VFXPPBWFlash.cs` | 黑白闪光 |
| `VFXPPBlackBox.cs` | 黑场遮罩 (转场) |
| `VFXPPDirtyLens.cs` | 脏镜片 |
| `VFXPPFisheyeEffect.cs` | 鱼眼变形 |
| `VFXPPCutsceneEffect.cs` | Cutscene 转场效果 (BaseColor/ShapeOption/AutoStretch/LightRange/FadeRange/Offset 等十多个参数) |
| `VFXPPCutsceneEffectData.cs` | Cutscene 数据载体 |
| `VFXPPCharacterLight.cs` | 角色补光 |
| `VFXPPCharacterDirectionalLight.cs` | 角色定向补光 |
| `VFXPPCharacterRimLight.cs` | 角色边缘光 |
| `VFXPPCharacterBloom.cs` | 角色 Bloom |
| `VFXPPScreenMaterial.cs` | 全屏 Renderer + `HGRP/Effect/VFXBaseV2` 材质 (BaseMaterials 桶) |

### 15.3 场景 VFX 状态与控件 (8)

| 文件 | 职责 |
|---|---|
| `HGVFXManager.cs` | 单例，SceneDark 列表 + 玩家位置/高度 + AnchorWaveBright + 全屏色调材质 + 帧间 lerp 阈值 0.01f |
| `VFXSceneDark.cs` | 场景调暗控件 (sceneDark / sceneDarkColor / useSceneSaturation / sceneSaturation / stopAutoExposure) |
| `VFXBackFaceHide.cs` | 角色背向隐藏 (注 BeginCameraRendering 看 dot + MaterialPropertyBlock `_TintColorAlpha`) |
| `VFXAutoEmissiveRate.cs` | 按缩放放大粒子发射率 (Global/Local × XYZ axisBitMask × 1..10×10×10 cap) |
| `VFXSortingOrder.cs` | Renderer.sortingOrder 一键覆盖 |
| `VFXFakeVolumeFog.cs` | 假体积雾 MeshRenderer 控件 (NearFadeDistance/FogColor/Density/HeightFalloff/Noise3D/StencilOp 全套属性) + IBeyondTrigger* 让 Beyond 系统用 Trigger 体积控其开关 |
| `VFXSampleParticleSystem.cs` | 空 stub (序列化标记) |
| `VFXShaderIDs.cs` | VFX shader property ID 表 (MainTex/TintColor/ExpThreshold/EdgeColor/Dissolve/CutOff/Scan/Bright 等约 30 个) |
| `VFXShaderStringConstants.cs` | 3 个 shader 名常量 (`HGRP/Effect/VFXBaseV2` / `HGRP/CharacterNPR` / `HGRP/LitEffect`) |
| `VFXSortingOrder.cs` | （已列） |

### 15.4 共计

10 (核心) + 26 (PP+控件+Shader 常数) + ... = 41。重新点：

```
1.  FullScreenVFXData.cs              [核心]
2.  GPUEventFeature.cs                [核心]
3.  GPUEventSender.cs                 [核心]
4.  GPUParticleShaders.cs             [核心]
5.  GPUParticleSimulationPassConstructor.cs  [核心 Pass]
6.  GPUParticleSystem.cs              [核心]
7.  GPUParticleSystemBase.cs          [核心]
8.  GPUParticleSystemManager.cs       [核心]
9.  HGVFXManager.cs                   [场景级单例]
10. IVFXPlayable.cs                   [核心接口]
11. ParticleLightingPassConstructor.cs [核心 Pass]
12. VFXAutoEmissiveRate.cs            [控件]
13. VFXBackFaceHide.cs                [控件]
14. VFXFakeVolumeFog.cs               [控件]
15. VFXPlayableMonoBase.cs            [基类]
16. VFXPPBlackBox.cs                  [PP]
17. VFXPPBWFlash.cs                   [PP]
18. VFXPPChromaticAberration.cs       [PP]
19. VFXPPChromaticAberrationData.cs   [PP 数据]
20. VFXPPColorAdjustments.cs          [PP]
21. VFXPPComponent.cs                 [PP 基类]
22. VFXPPCutsceneEffect.cs            [PP]
23. VFXPPCutsceneEffectData.cs        [PP 数据]
24. VFXPPData.cs                      [PP 数据基类]
25. VFXPPDirtyLens.cs                 [PP]
26. VFXPPFisheyeEffect.cs             [PP]
27. VFXPPManager.cs                   [PP 单例]
28. VFXPPPriority.cs                  [PP 枚举]
29. VFXPPRadiaBlurData.cs             [PP 数据]
30. VFXPPRadialBlur.cs                [PP]
31. VFXPPScanLine.cs                  [PP]
32. VFXPPScanLinePass.cs              [PP 专用 Pass]
33. VFXPPScreenMaterial.cs            [PP]
34. VFXPPType.cs                      [PP 枚举]
35. VFXPPVignette.cs                  [PP]
36. VFXPPVignetteData.cs              [PP 数据]
37. VFXSampleParticleSystem.cs        [stub]
38. VFXSceneDark.cs                   [控件]
39. VFXShaderIDs.cs                   [shader ID]
40. VFXShaderStringConstants.cs       [shader 名]
41. VFXSortingOrder.cs                [控件]
```

加：`VFXPPCharacterBloom.cs / VFXPPCharacterDirectionalLight.cs / VFXPPCharacterLight.cs / VFXPPCharacterRimLight.cs`（这 4 个 PP 角色光控件未列入上面 41 — 它们属于 C08 SubsurfaceCharacter 单元，在那里讲）。本单元清单严格按 `render_cells.json[C10_GPUParticle]` 41 项交付。

---

## 16. 真未知 / 待确认 (§1.5.5)

以下项目反编译可见结构与调用图、但无法验证具体 HLSL 语义（需要原始 `.compute` 文件或 RGP capture 确认；不影响核心算法蓝图）：

1. **emitShader / simulateShader 的具体 HLSL**：用户提供，反编译只能看到 5 个 PassConstructor 自带 shader (`particleCleanup/Init/Cull/Sort/IndirectArgs`)，emit/simulate 是项目侧资产。用 §5 的伪代码 1:1 实现即可符合调用约定 (binding 表已锁)。
2. **bitonic sort kernel 内 `groupshared` 数组的具体声明**：从 `SORT_BATCH_SIZE=4096` + `[numthreads(64,1,1)]` (反推) 推断为 `groupshared SortKey s_keys[4096]`，但 HLSL `groupshared SortKey s_keys[4096];` 在 DX11 32KB 限制下需要 `SortKey` 严格 = 8 字节 (已验证：uint + float)。
3. **DrawIndirectArgs 第 0 项的 indexCount 具体计算公式**：标准 indexed triangle strip 是 `4*liveCount + 2*(liveCount-1)` 还是 `6*liveCount` (普通 triangle list)？从 `m_quadIndexBuffer.target` = Index (=2) + count = `(particleCap-2)*4` (反汇编 `[r15-2]/[r15+2]`) 推断**实为 triangle strip with primitive restart**，shader 用 `vid / 4` 取粒子号。
4. **GPU Event 的具体事件载荷格式**：反编译 `eventBufferStride` 是 int，由 sender 配置 (典型 16 = `float4 { pos.xyz, packed metadata }`)。具体打包顺序由用户 emit/simulate shader 约定。

核心算法、dispatch 顺序、buffer 布局、常量、keyword、kernel 名、Profile id 都已 1:1 锁定。
