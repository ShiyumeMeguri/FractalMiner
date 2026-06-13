# 12 · 交互链系统 · Interaction Chain · 实现原理蓝图

> HG 自研动态物 ↔ 环境（草/植被/雪/积水/泥）踩踏与拖痕交互层；以 **CPU 收集 → 节点几何代理 → 屏幕空间 deferred raster** 方式把每个动态物的当前 / 历史姿态烘焙进一张「交互高度场 + 法向场」RT（HGFoliageInteractiveManager 持有的 `_curDualHeightTexture`），下游 foliage / grass / 雪 / 湿地 / 水体 shader 在顶点 / 片元阶段采样这张 RT 做位移弯折、压痕、染色。
>
> **HDRP 无对应特性**。算法据反汇编调用图 + 常量 + 领域知识（Witcher 3 / Horizon-style **Dynamic Foliage Interaction Field**、Ghost of Tsushima/Days Gone 的 trail mask）按 §1.5 1:1 重建；HG 反编译提供结构、容量、阈值、绘制顺序与 keyword。HDRP `DecalSystem` 的 mesh-as-projection 思路（`com.unity.render-pipelines.high-definition@75de48326bcd/Runtime/Material/Decal/DecalSystem.cs`）被借鉴成「以四边形/网格作 frustum 体把交互信号 splat 到 dual-height RT」，但 HG 自走管线、自定义 Shader keyword。
>
> 子系统在反汇编中常出现两个**单词拼写不一致**的类名：`HGInterationManager`（漏一个 c，对外 API）与 `HGDecalInteration`（同样漏 c，内部链状态机）。这是原工程笔误，本文照搬便于工程师反查。

## 目录

- [1. 系统职责](#1-系统职责)
- [2. 物理几何代理 — 四类节点](#2-物理几何代理--四类节点)
- [3. 节点数据布局 (Instance + Render)](#3-节点数据布局-instance--render)
- [4. CPU 时序 — PipelineUpdate → DrawInteractions](#4-cpu-时序--pipelineupdate--drawinteractions)
- [5. 链 (Chain / Node / Section) — 拖痕条带状态机](#5-链-chain--node--section--拖痕条带状态机)
- [6. GPU Pass — Dual-Height 体素压痕](#6-gpu-pass--dual-height-体素压痕)
- [7. 下游消费 — 草 / 植被 / 雪 / 湿地 / 水](#7-下游消费--草--植被--雪--湿地--水)
- [8. 关键常量与魔数总表](#8-关键常量与魔数总表)
- [9. 1:1 复刻蓝图](#9-11-复刻蓝图)
- [10. 支撑证据 — 源文件清单与结构表](#10-支撑证据--源文件清单与结构表)

---

## 1. 系统职责

终末地世界里的可破坏 / 可形变层包含：

- **植被弯折**（消费方文档 → [`./03-FoliageGrass.md`](./03-FoliageGrass.md)）；
- **积雪 / 泥地脚印**（消费方文档 → [`./11-WeatherWetness.md`](./11-WeatherWetness.md)）；
- **水面涟漪触发**（消费方文档 → [`./01-WaterOcean.md`](./01-WaterOcean.md)，水面单元自带 `WaterInteractionRenderingPass`，本单元只贡献角色侧的入水/拖水节点）；
- **草地烧痕 / 拖痕**：当玩家或载具持续在地面运动时，应当沿运动轨迹留下方向性条带（“链”）。

C12 单元负责把上层（角色/载具）的几何摘要变成两层 RT：

1. **DualHeight RT** — `_curDualHeightTexture`：1 个 RT，记录当前帧的「最低被踩点高度 + 上次被踩点高度」（two-channel encoded），供草地/植被 vertex shader 做高度位移；
2. **历史拖痕 ConstantBuffer** — `chainBuffer`：每条链上最多 100 个采样点的姿态（位置 / 朝向 / 时间衰减），供 `decalInteractionMaterial` 在 dual-height 写入阶段作为 instance 数据 draw 出连续四边形带。

> 区别：**节点 (Node) 是瞬时几何代理**（每帧由 `HGInteractionComponent.CollectInteractionNodes` 重建）；**链 (Chain) 是跨帧累积条带**（每个 `nodeKey` 一条，最多 100 个 sub-node 环形缓冲）。Sphere / Capsule / Mesh 触发瞬时节点；只有 **Texture 型**（`EInteractionProxyType.Texture`，反编译 `EInteractionProxyType.cs:7`）借助 `HGInteractionChain` 走链状条带。

---

## 2. 物理几何代理 — 四类节点

`UnityEngine.HyperGryph.EInteractionProxyType` (`EInteractionProxyType.cs:3-9`)：

```csharp
public enum EInteractionProxyType : uint
{
    Sphere  = 0,   // 单球：脚印 / 落点
    Capsule = 1,   // 胶囊：腿 / 武器 / 载具碰撞体
    Texture = 2,   // 贴图条带：拖痕主用，唯一会进入 HGInteractionChain 的类型
    Mesh    = 3,   // 任意网格：召唤兽 / 大型怪
}
```

CPU 上由 `HGInteractionComponent : MonoBehaviour, IHGInteractionObject` 持有形参（`HGInteractionComponent.cs:10-22`）：

| 字段 | 含义 | 反编译位置 |
|---|---|---|
| `ProxyType : EInteractionProxyType` | 4 类几何选择 | `HGInteractionComponent.cs:10` |
| `bUseCCD : bool` | 该节点是否启用上一帧→当前帧的连续扫掠（capsule sweep） | `:12` |
| `Radius : float` | 球 / 胶囊半径，或贴图条带宽度 | `:14` |
| `Height : float` | 胶囊高度（端到端距离），或贴图条带长度 | `:16` |
| `Extent : Vector2` | 贴图条带的 UV 缩放 / 偏移 | `:18` |
| `MaskTexture : Texture` | 贴图条带的形状（含 mask + height + curvature） | `:20` |
| `ProxyMesh : Mesh` | Mesh 型的代理网格 | `:22` |
| `lastTransform : Matrix4x4` | 上一帧 localToWorldMatrix（CCD 用） | `:24` |

**生命周期**（反编译调用图）：

```
HGInteractionComponent.OnEnable  → HGInterationManager.Register(this)        // :44-52
HGInteractionComponent.OnDisable → HGInterationManager.Unregister(this)      // :93-100
```

`HGInterationManager` 在 `currentManagerContext.[ofs 0xA0]` 槽位（反编译 `HGInteractionComponent.cs:45`，`HGManagerContext` 第 21 个字段）；它持有：

```csharp
class HGInterationManager (拼写按反编译保留)
{
    const int MAX_BATCH_INSTANCE_NUM = 100;                          // :9
    List<IHGInteractionObject>           objects;     // 注册对象
    List<HGInteractionNode>              nodes;       // 当帧瞬时节点池
    List<HGInteractionNodeRenderData>    renderDatas; // 当帧 GPU instance 池
    HGDecalInteration                    decalInteraction; // 链状态机 + Texture proxy 子系统
    HGInteractionSettingAsset            settingAsset;
}
```

**每帧入口** `HGInterationManager.PipelineUpdate()`（`:193-294`）反编译里只剩两个 call：

```
PipelineUpdate
├─ CollectInteractions()      // CPU 把所有注册对象的当帧 node 收集到 List<HGInteractionNode>
└─ UpdateCppPipeline(false)   // 把 List<HGInteractionNode> 拷贝到 NativeArray<HGInteractionNodeV2>
                              // → 调 native InternalCalls 传给 HG.GraphicsModule (g_18FC430F8 即 native fn ptr)
```

`UpdateCppPipeline`（`:297-789`）逐节点把 `HGInteractionNode` 的 `0xB4` 字节 (= 180) 平铺到 NativeArray slot 里（反编译 `imul r14, rdi, 0B4h` `:372`），传递给 native，`HGInteractionNodeV2` 的字段顺序为：

| offset | 类型 | 字段 | 来源 |
|---|---|---|---|
| 0x00 | int | m_nodeKey | `HGInteractionNodeV2.cs:8` |
| 0x04 | uint | m_proxyType | `:10` |
| 0x08 | Matrix4x4 (64B) | m_localToWorldMatrix | `:12` |
| 0x48 | Matrix4x4 (64B) | m_prevLocalToWorldMatrix | `:14` |
| 0x88 | float | m_groundHeight | `:16` |
| 0x8C | bool (1B + pad) | m_bUseCCD | `:18` |
| 0x90 | float | m_length / m_radius / m_interactLength / m_interactHeight | `:20-26` |
| 0xA0 | int (texture instance ID) / Vector2 extent / heightScale / int (mesh instance ID) | `:28-34` |

`m_texture / m_mesh` 是 `UnityEngine.Object.GetInstanceID()` 编出来的 32 位句柄（native 侧用句柄反查 RenderTexture / Mesh，避免 GCHandle）。

---

## 2.1 收集节点 — `CollectInteractionNodes`

`HGInteractionComponent.CollectInteractionNodes(List<HGInteractionNode>)`（`HGInteractionComponent.cs:122-425`）每帧由 `HGInterationManager.CollectInteractions` 调用。算法步骤（据反编译调用图重建）：

```
0. m = component.transform.localToWorldMatrix
   prevM = (lastTransform == default) ? m : lastTransform
   写回 component.lastTransform = m

1. // groundHeight = Physics.Raycast(component.pos + Vector3.up*0.5f, Vector3.down, MAX_DISTANCE=32)
   //   命中：g = hit.point.y - 0.5f
   //   未命中：g = component.pos.y - 0.5f
   //   ref HGInteractionNode.MAX_DISTANCE = 32f, CAST_OFFSET = 0.5f  (HGInteractionNode.cs:9-11)

2. nodeKey = component.transform.GetInstanceID()    // (:294) 同一组件每帧 nodeKey 稳定

3. switch (ProxyType):
     Sphere  → HGInteractionNode.CreateSphereNode (nodeKey, Radius, m, prevM, g, bUseCCD)
     Capsule → HGInteractionNode.CreateCapsuleNode(nodeKey, Height, Radius, m, prevM, g, bUseCCD)
     Texture → HGInteractionNode.CreateTextureNode(nodeKey, Extent.x, Extent.y, Radius,
                                                    heightScale=Height, MaskTexture, m, prevM, g, bUseCCD)
     Mesh    → HGInteractionNode.CreateMeshNode   (nodeKey, ProxyMesh, m, prevM, g, bUseCCD)

4. nodes.Add(node);   // (:367-397) 把结构体按 0xB4 字节拷入 List<HGInteractionNode>
```

### 2.1.1 Sphere / Capsule 几何拟合 — Bounds-aware billboard

`HGInteractionNode.ConstructSphereNode` (`HGInteractionNode.cs:107-339`) 与 `ConstructCapsuleNode` (`:711-1033`) 的反汇编显示同一套套路：

- 不启用 CCD（`bUseCCD == false`）时：节点直接以 **球心 / 胶囊轴心** + scale (2r, 2r) 的 quad 建立 TRS（`HGInteractionResources.QuadMesh` 即一个 1x1 平面，`HGInteractionResources.cs:15`），billboard 朝下 (`Color.black` 充当 forward placeholder，回填后用 `prevM.GetPosition` - `currM.GetPosition` 重算）。
- 启用 CCD：取 `delta = currPos - prevPos`，长度 `d = ‖delta‖`；
  - 若 `d == 0`：退化为非 CCD；
  - 否则把当前 quad 朝 `delta` 方向延展，长度 = `r + 0.5·d`，宽度 = `r`（capsule 还加上 length），并用 `Quaternion.LookRotation(delta)` 旋转。
  - 反汇编 `loc_18A89A713 ~ loc_18A89A78D` 段（`HGInteractionNode.cs:202-247`）：先 `Vector3.forward` × inverse-rot → 取 `dot(forward_local, delta_normalized)` 与 `dot(right_local, delta_normalized)`，再用 `g_18C4713E0`（=0.5f，立即数常量）放大半长度。
- 输出 `instance.length = r`，`instance.height = capsuleLocalHeight`，`instance.radius = r·scale`，`instance.heightScale = groundHeight`。

> **0.5 这个数字**反复出现：`HGInteractionNode.CAST_OFFSET = 0.5f`（`:11`）抬升 raycast 起点；CCD 半边距 `0.5·d` 让 quad 覆盖整段位移；雪/草 dual-height 写入也以 0.5 作为脚下 vs 头顶的中分位（见 §6）。

### 2.1.2 Texture 节点 — 链触发点

`CreateTextureNode` 是唯一一个把 **MaskTexture instance ID** 透传给 GPU 的入口；该 node 被 `HGDecalInteration.PushNewNodeToChain` 喂进 `HGInteractionChain.PushNewNode`，长成跨帧拖痕条带（§5）。

### 2.1.3 Mesh 节点

`CreateMeshNode` 直接采用 `ProxyMesh`（任意三角网格）做 instance draw；与 sphere/capsule 共用同一组 `_InteractionGroundHeight / _InteractionExtent` shader uniform（`HGInteractionNode.DrawSphereNode :405-422`、`DrawCapsuleNode :1097-1153`）。

---

## 3. 节点数据布局 (Instance + Render)

### 3.1 `HGInteractionNodeInstanceData` — GPU instance cbuffer

`HGInteractionNodeInstanceData.cs:5-26`：

```csharp
struct HGInteractionNodeInstanceData          // size = 0xE0 (224) bytes，0xE0 = 3·64 + 8·4
{
    Matrix4x4 localToWorld;       // ofs 0x00, 64B
    Matrix4x4 worldToLocal;       // ofs 0x40, 64B（GPU 端要用，CPU 提前算好 GetInverse）
    Matrix4x4 prevLocalToWorld;   // ofs 0x80, 64B
    float radius;                 // ofs 0xC0
    float length;                 // ofs 0xC4
    float height;                 // ofs 0xC8
    float heightScale;            // ofs 0xCC
    float groundHeight;           // ofs 0xD0
    float capsuleLocalHeight;     // ofs 0xD4
    Vector2 padding;              // ofs 0xD8 (8B)，对齐到 0xE0=224，恰为 16B 倍数
}
```

`BatchInstanceDraw` 反汇编 `imul r8d, r15d, 0E0h` (`HGInterationManager.cs:1088`) 验证 stride = **0xE0 = 224 字节**。每批 `MAX_BATCH_INSTANCE_NUM = 100`（`HGInterationManager.cs:9`），cbuffer 总大小 = 100·224 = **22400 字节 = 0x5780**（反汇编 `mov dword ptr [rsp+20h], 5780h` `:1186`，与 `SetGlobalConstantBufferInternal0` 调用对齐）。

### 3.2 `HGInteractionNodeRenderData` — sort + dispatch payload

`HGInteractionNodeRenderData.cs:5-13`：

```csharp
struct HGInteractionNodeRenderData
{
    HGInteractionNodeInstanceData instanceData;   // 0x00, 224B
    Mesh mesh;                                    // 0xE0, ref
    int  passIndex;                               // 0xE8
    bool ccdKeyword;                              // 0xEC
}
```

#### Sorter（`HGInteractionNodeRenderData.cs:15-536`，反汇编 `loc_18A89948C`）：

排序键按优先级从高到低 ——

1. `mesh` 是否非 null（用 `UnityEngine.Object.op_Inequality` 判断 → 把 mesh-null 排到一侧）；
2. `passIndex`（Mesh-pass = 0, Texture-pass = 1, Capsule-noCCD = 1, Capsule-CCD = 4 — 见 §6 反编译）；
3. `ccdKeyword`；
4. 若 mesh 都非 null：按 `Mesh.GetInstanceID()` 差值（反汇编 `:438-442` 两次 GetInstanceID 相减）。

排序保证连续元素同 mesh + 同 pass + 同 keyword → 可一次 `HGDrawMeshInstanced` 跑 100 个。

`Match(other)`（`:538-735`）：mesh 相同 **且** `passIndex` 相同 **且** `ccdKeyword` 相同 → 允许并入同 batch（反汇编 `loc_18A8993C1` 对应三个域全等返回 true）。

---

## 4. CPU 时序 — PipelineUpdate → DrawInteractions

```
HGInterationManager
├── PipelineUpdate()                            // ASD 入口，每帧一次
│   ├── if (settingAsset == null || objects 空) return         (:236-241)
│   ├── CollectInteractions()                                  (:245)
│   │   ├── nodes.Clear()                                      (:880-881)
│   │   └── foreach obj in objects:  obj.CollectInteractionNodes(nodes)
│   └── UpdateCppPipeline(updateMobile = false)                (:248-249)
│       ├── HGDecalInteration.BuildNativeSettingParameters     (:336)
│       ├── 把 settingParameters 写入 native (g_18FC430F8)     (:343-350)
│       ├── NativeArray<HGInteractionNodeV2>.Alloc(nodes.Count) (:354-389)
│       ├── memcpy 每个 HGInteractionNode (0xB4B) → 对应 V2 slot (:425-611)
│       └── native UpdatePipeline(array, updateMobile)          (:577-580 → g_18FC430F0)
│       (native 端把节点信息分发到内部 jobs，决定 dual-height RT 的最终写入)
└── DrawInteractions(cmd, ctx, decalMaterial, sceneBounds)     // 由 FoliageInteractivePass 调用
    ├── renderDatas.Clear()
    ├── if (!HGGraphicsFeatureManager.[178h] feature flag) → 直接走 DrawNode 单实例路径
    └── foreach node in nodes:                                  (:1404-1510)
        ├── if (!node.GetBounds().Intersects(sceneBounds)) continue
        ├── if (!node.BuildRenderData(out renderData))          // mesh/sphere/capsule 走 instanced
        │       node.DrawNode(cmd, decalMaterial, ctx)          // 否则单 mesh draw（Mesh-proxy / non-CCD sphere）
        │       continue
        └── renderDatas.Add(renderData)                          (:1506-1508)
    ├── renderDatas.Sort(HGInteractionNodeRenderData.Sorter)    (:1530-1540)
    └── 把 renderDatas 按 Match 分段，调 BatchInstanceDraw 每段 ≤ 100 个 instance
```

`DrawInteractions` 的 `bounds` 参数被 `FoliageInteractivePass` 设置为「当前帧 dual-height RT 覆盖的 world AABB」 ——
即 `HGFoliageInteractiveManager.GetCenter(out center, out size)` 返回的 cube（`HGFoliageInteractiveConfig.FOLIAGE_INTERACTIVE_CENTER_SIZE` 是默认 size）。

### 4.1 `BatchInstanceDraw` — 100 instance 一批

`HGInterationManager.cs:1012-1273`，关键步骤（据反汇编）：

```
int total      = batchEnd - batchStart;
int batchCount = ceil(total / 100.0);                            // (:1066-1070, sar edx,5 + +1)
for (b = 0; b < batchCount; b++):
    int countThis = (b == batchCount-1) ? (total - b*100 + 1) : 100;   // (:1074-1085)

    // 1) 申请一个 constantBuffer ofs = AllocateConstantBuffer(stride 0xE0 * countThis)
    ScriptableRenderContext.AllocateConstantBuffer(ctx, &cbufHandle, countThis * 0xE0)

    // 2) memcpy 每个 renderDatas[startIdx + b*100 + k].instanceData (0xE0B) 到 cbufHandle 内偏移
    //    (反编译里看到 inc ebx 每次 0xE0)
    for (k = 0; k < countThis; k++):
        memcpy(cbufHandle + k*0xE0, &renderDatas[batchStart + b*100 + k].instanceData, 0xE0)

    // 3) 取 batch 头三个 element 拿 mesh / passIndex / ccdKeyword（全 batch 内一致）
    head = renderDatas[batchStart]

    // 4) CommandBuffer.SetGlobalConstantBuffer(cbufHandle, _HGInteractionNodeInstanceDataBuffer (id @ HGShaderIDs+0xDC8), offset, 5780h)
    cmd.SetGlobalConstantBufferInternal0(material, _HGInteractionNodeInstanceDataBuffer_id, cbufHandle, 0, 0x5780);

    // 5) SetKeyword(material, _CCD_KEYWORD_, head.ccdKeyword)         (:1207-1218)
    // 6) HGDrawMeshInstanced(mesh = head.mesh, passIndex = head.passIndex, material, count = countThis)
    cmd.HGDrawMeshInstanced(mesh, head.passIndex, material, countThis, null, ShadowCastingMode.Off);
```

`HGDrawMeshInstanced` 是 HG 自扩的 CommandBuffer 方法（与 HDRP 同源 `CommandBuffer.DrawMeshInstanced` 区别：不传 matrices 数组，全部 instance 数据从 cbuffer 索引），实际 GPU 端 `SV_InstanceID` 进入 vertex shader 后用 `[SV_InstanceID].x` 索引 `_HGInteractionNodeInstanceDataBuffer[instance]` 取 224 字节的 `localToWorld` 等参数。

---

## 5. 链 (Chain / Node / Section) — 拖痕条带状态机

只有 `EInteractionProxyType.Texture` 节点走链。`HGDecalInteration`（`HGDecalInteration.cs:8-1338`）持有：

```csharp
List<HGInteractionChain>             freeChains;       // 池
Dictionary<int, HGInteractionChain>  busyChains;       // key = nodeKey，每个动态物一条链
List<int>                            pendingFreeChains; // 帧末待回收 key
const int KEEP_BUSY_FRAMES = 3;                         // HGDecalInteration.cs:16
HGInteractionSettingAsset            settingAsset;
```

`HGInteractionChain`（`HGInteractionChain.cs:6-1185`）：

```csharp
const int CHAIN_MAX_NODE_COUNT = 100;                   // HGInteractionChain.cs:8
bool IsFree;
int  LastAccessFrame;
TRingBuffer<HGInteractionChainNode>    chainNodes;     // 节点环 100 容量
TRingBuffer<HGInteractionChainSection> chainSections;  // 区段环 100 容量
int activeCount;
HGDecalInteractionData[]        interactionData;       // 100, GPU cbuffer mirror
ComputeBuffer                   chainBuffer;           // SetData 后绑 _DecalInteractionDataBuffer
HGDecalInteractionSettingData[] settingData;           // 1
ComputeBuffer                   settingDataBuffer;     // 绑 _DecalInteractionSettingDataBuffer
MaterialPropertyBlock           propertyBlock;
float cachedFadeEnd;
HGInteractionSettingAsset       settingAsset;
```

### 5.1 节点几何 — `HGInteractionChainNode`

`HGInteractionChainNode.cs:5-101`：

```csharp
struct HGInteractionChainNode
{
    Vector2    VRange;        // 0x00 (8B)  此节点占用的 V 轴 [v0, v1]（沿运动方向累积长度归一化）
    int        SectionIndex;  // 0x08 (4B)
    Vector2    HeightFade;    // 0x0C (8B)  高度淡入淡出参数 (距离地面)
    Vector4    TimeFade;      // 0x14 (16B) 四阶段时间衰减系数 (xyz = anim 曲线点, w = 当前 t)
    Vector2    StartDist;     // 0x24 (8B)  累计距离起点
    Vector3    Position;      // 0x2C (12B) 节点几何中心
    Quaternion Rotation;      // 0x38 (16B)
    Vector2    Scale;         // 0x48 (8B)
    Vector3    Vertex0;       // 0x50 (12B) 四角，世界空间
    Vector3    Vertex1;       // 0x5C
    Vector3    Vertex2;       // 0x68
    Vector3    Vertex3;       // 0x74
    bool       Active;        // 0x80 (1B) — 结构 0x80 + 4 = 0x84 字节 (反编译 imul ebx, 84h 隐式对齐 0x80)
}
```

反编译里 stride 用 `mov edx, 80h` (`HGInteractionChain.cs:686`) 配合最后 1B + 3B pad 表示 ringbuffer 一个槽位 **128 字节 = 0x80**。

`GetMatrix()` (`HGInteractionChainNode.cs:35-100`) = `Matrix4x4.TRS(Position, Rotation, new Vector3(Scale.x, Scale.y, 1f))` — 一个朝拖痕方向的扁平 quad TRS。

### 5.2 区段 — `HGInteractionChainSection`

`HGInteractionChainSection.cs:5-14`：

```csharp
struct HGInteractionChainSection
{
    Vector2 VRange;     // 0x00 该段占用 V 范围
    float   StartSize;  // 0x08 起点节点宽度（用于 head 处的逐渐收尖）
    bool    Active;     // 0x0C
}
```

> 一条 chain = 若干 Section，一个 Section = 若干 Node。当玩家方向急转 `dot(forward_prev, forward_now) < rotationThreshold` 时开新 Section（避免 quad 拉扯撕裂）。

### 5.3 `PushNewNode` — 链增长算法

`HGInteractionChain.PushNewNode(in HGInteractionNode node)` (`HGInteractionChain.cs:246-1184`) 是核心。**反汇编里看到的几何重建步骤**（据指令序列 + Unity API 调用回译）：

1. **取当前 node 朝向**：从 `node.localToWorld.GetRotation()`（`:328`）× `Vector3.forward / right` 求世界方向 `forward, right`；
2. **取当前 node 的中心位置**：`node.localToWorld.GetPosition()` (`:378`)，按 `node.extent.x` (= width) × right 与 `0.5·forward` 偏移得到 4 个 vertex（反汇编里 `:410-485` 反复 `op_Multiply` 用 `g_18C471320` (= 1.0f, 后用作 scale)、`g_18C471324` (= 0.0f)、`g_18C4713B8` (= 0.5f) 等魔数）；
3. **拿到上一节点** `prev = chainNodes.GetCurrentNode()` (`:678-682`)；
4. **判断是否继续条带 (`vertSection`)**：
   - 计算 `dot(prev.forward, curr.forward)` 与 `dot(prev.up, curr.up)`（`:738, :761`，两次 `Vector3.Dot`）；
   - 与 `settingAsset.rotationThreshold` (`HGInteractionSettingAsset.cs:32`，范围 [-1,1]) 及 `settingAsset.backwardDistanceThreshold` (`:35`) 比较；
   - 若任一阈值未过 → **新建 Section**（`AddNewNode` on chainSections，`:997-999`）；否则沿用当前 Section（`SetCurrentNode`）；
5. **节点距离判断 `nodeDistanceThreshold`**（`:20`，[0,0.5]）：若 `‖curr.pos - prev.pos‖ < nodeDistanceThreshold` → 不开新 chainNode，只更新当前 node 的 VRange.y 与 timeFade（`SetCurrentNode`，`:805`）；否则 `AddNewNode` (`:1145`)；
6. **VRange 累计**：每个新节点的 `VRange = [prev.VRange.y, prev.VRange.y + len(curr - prev)]`（沿运动方向的弧长 / 累积参数）；
7. **TimeFade.w = 0.0**（刚生成时间为 0，由 `UpdateChainFade` 每帧 += `dt · settingAsset.timeFadeSpeed`）；
8. **HeightFade** 用 `settingAsset.heightFadeDistanceMin/Max` 把 `(node.height - prev.height)` 归一化（`:407-417`，反汇编里 `subss xmm0, [rsi+88h]` 即从节点 height 减去 `groundHeight`，再除以 `(Max-Min)`）。

```
TimeFade.w 时序：
  生成时 = 0  →  每帧 += dt * timeFadeSpeed
  当 TimeFade.w > 1.0  →  节点 inactive 并按 cachedFadeEnd 标记可删
HeightFade.x = saturate( (node.height - groundHeight - heightFadeMin) / (heightFadeMax - heightFadeMin) )
```

### 5.4 `UpdateChainFade` — 节点淡出 + 链尾回收

`HGInteractionChain.UpdateChainFade()` (`:1368-`) 反编译：

```
dt        = Time.deltaTime
fadeDelta = dt * settingAsset.timeFadeSpeed     // (:1418)

逐节点 i ∈ [start..end]:
    node.TimeFade.w += fadeDelta                 // 累积
    if node.TimeFade.w >= 1.0:
        node.Active = false
        累积 tailDeadCount++
    更新 HeightFade.x 以反映动态地面变化

chainNodes.DeleteTailNodes(tailDeadCount)        // (:1742-1744)
chainSections 同步收尾
```

`cachedFadeEnd` 记录最远还在 fade 的节点 `VRange.y`，下次 raster 时只读到这里为止。

### 5.5 `DrawChainNodes` — Chain → GPU instance

`HGInteractionChain.DrawChainNodes(CommandBuffer cmd, Material mat)` (`:1187-1366`)：

```
1. propertyBlock.Clear()

2. if (chainBuffer == null):
       chainBuffer = new ComputeBuffer(count=100,            // 0x64
                                       stride=144,           // 0x90 = sizeof(HGDecalInteractionData)
                                       type=ConstantBuffer)  // (:1228-1232)
3. chainBuffer.SetData(interactionData)                       // 100 * 144 = 14400 = 0x3840 (:1255)

4. propertyBlock.SetConstantBuffer(_DecalInteractionDataBuffer_id, chainBuffer, 0, 0x3840)   // (:1256)

5. if (settingDataBuffer == null):
       settingDataBuffer = new ComputeBuffer(count=1,
                                             stride=32,       // 0x20 = sizeof(HGDecalInteractionSettingData)
                                             type=ConstantBuffer)
6. // 把 settingAsset 字段 pack 到 settingData[0]
   settingData[0]._decalNodeWidth         = settingAsset.decalNodeWidth
   settingData[0]._decalNodeLength        = settingAsset.decalNodeLength
   settingData[0]._decalNodeHeadLength    = settingAsset.decalNodeHeadLength
   settingData[0]._decalNodeOffset        = settingAsset.decalNodeOffset
   settingData[0]._nodeDistanceThreshold  = settingAsset.nodeDistanceThreshold
   settingData[0]._EdgeFadeRatio          = 1.0 / settingAsset.edgeFadeDistance   // (:1289-1291, divss g_18C471324 / [rcx+34h])

7. settingDataBuffer.SetData(settingData)
8. propertyBlock.SetConstantBuffer(_DecalInteractionSettingDataBuffer_id, settingDataBuffer, 0, 0x20)

9. cmd.HGDrawMeshInstanced( HGInteractionResources.QuadMesh, passIndex=3, mat, activeCount, propertyBlock, ShadowCastingMode.Off )    // (:1339)
```

`passIndex = 3` 是 Texture-chain 专用 shader pass（材质 `HGInteractionSettingAsset.decalInteractionMaterial`，`HGInteractionSettingAsset.cs:8`）。该 pass 在 vertex shader 里用 `SV_InstanceID` 索引 `_DecalInteractionDataBuffer[instance]`，取 144B 节点数据：

#### 5.5.1 `HGDecalInteractionData` 布局 (`HGDecalInteractionData.cs:5-19`)

```csharp
struct HGDecalInteractionData            // 144B = 64 + 16*5
{
    Matrix4x4 _transform;   // 0x00, 64B  节点 quad 的 TRS
    Vector4   _data0;       // 0x40, 16B
    Vector4   _data1;       // 0x50
    Vector4   _data2;       // 0x60
    Vector4   _data3;       // 0x70
    Vector4   _data4;       // 0x80
}
```

`_data0~4` pack 用途（据 `PushNewNode` 反汇编对 chainNode 字段的回写顺序推断 + 标准 trail-decal 实现 `data` 通常 pack `(vRange, heightFade, timeFade, startDist, vertices, extentScale, …)`）：

| pack | 内含 | 来源字段 |
|---|---|---|
| `_data0.xy` | `VRange.x, VRange.y` | `HGInteractionChainNode.VRange` |
| `_data0.zw` | `HeightFade.x, HeightFade.y` | `HeightFade` |
| `_data1.xyzw` | `TimeFade.xyzw` | `TimeFade` |
| `_data2.xy` | `StartDist.x, StartDist.y` | `StartDist` |
| `_data2.zw` | `Scale.x, Scale.y` | `Scale` |
| `_data3.xyz` | 节点局部 `forward / up / 折角参数` | computed |
| `_data4.xyz` | 余下 section 信息（`Active`, `SectionIndex`） | computed |

由于反汇编只能定到 stride，把 `_dataN` 视为节点 metadata struct 的字段镜像（**据反编译调用图强推断**）。HDRP `DecalProjector.GetDecalPropertyBlock` 也是同样 pack `(uv, fade, sortKey, …)` 的策略 (`com.unity.render-pipelines.high-definition@75de48326bcd/Runtime/Material/Decal/DecalSystem.cs:DecalCachedChunk`)，可直接借鉴。

#### 5.5.2 `HGDecalInteractionSettingData` — 全链共用阈值

`HGDecalInteractionSettingData.cs:5-20`：

```csharp
struct HGDecalInteractionSettingData     // 32B = 8 * float
{
    float _decalNodeWidth;
    float _decalNodeLength;
    float _decalNodeHeadLength;
    float _decalNodeOffset;
    float _nodeDistanceThreshold;
    float _EdgeFadeRatio;          // = 1 / settingAsset.edgeFadeDistance
    Vector2 _padding;
}
```

`HGInteractionSettingAsset` 的范围注解（`HGInteractionSettingAsset.cs:16-38`）：

| 字段 | 范围 | 含义 |
|---|---|---|
| `decalNodeWidth` | (>0) | 单 node quad 的宽度（垂直运动方向） |
| `decalNodeLength` | (>0) | 单 node quad 的长度（沿运动方向） |
| `decalNodeHeadLength` | (>0) | 链头加长段（让首节点变细） |
| `decalNodeOffset` | [-1, 1] | quad 在运动方向上偏移系数 |
| `nodeDistanceThreshold` | [0, 0.5] | 多近不开新节点 |
| `edgeFadeDistance` | [0, 1] | 节点边缘 alpha fade 像素宽度（归一化 V） |
| `heightFadeDistanceMin/Max` | [0, 1] | 节点高度 fade 区间（与脚下地面差） |
| `rotationThreshold` | [-1, 1] | 朝向 dot 阈值，触发新 section |
| `backwardDistanceThreshold` | [-1, 1] | 节点回退距离阈值（防玩家原地踏步抖动） |
| `timeFadeSpeed` | [0, 1] | TimeFade.w 每秒累积速率 |

### 5.6 池化 — `KEEP_BUSY_FRAMES = 3`

`HGDecalInteration` 用三段 list/dict：

```
freeChains          : 空闲链复用
busyChains[nodeKey] : 该 nodeKey 关联的活跃链
pendingFreeChains   : 帧末若 chain 已 KEEP_BUSY_FRAMES 帧没收到新 PushNewNode → 进入待回收
```

每帧 update：

1. 对 `busyChains` 遍历：若 `Time.frameCount - chain.LastAccessFrame > KEEP_BUSY_FRAMES` → 加入 pendingFreeChains；
2. pendingFreeChains.foreach：`chain.Reset()` → 放回 freeChains，从 busyChains 移除；
3. 收到新 Texture node：`busyChains.TryGetValue(nodeKey, out chain)`，无则 `chain = GetFreeChain()` → `chain.PushNewNode(node)`（`HGDecalInteration.cs:619-642`，反汇编 `loc_18A89500X` 段）。

> 三帧延迟让短暂踏步打断（弹跳、滑步）不会立刻丢失拖痕状态。

---

## 6. GPU Pass — Dual-Height 体素压痕

CPU 把所有 instance 数据 / chain 数据 / setting cbuffer 准备好后，**FoliageInteractivePass** 在 RenderGraph 里编排实际的 RT 绘制：

```
FoliageInteractivePassConstructor                              // FoliageInteractivePassConstructor.cs:9-
├── PrepareFoliageInteractTexture(renderGraph)                 // :325-449
│   ├── cfg = HGFoliageInteractiveManager.GetConfig()           // 取 textureSize / format
│   ├── if (!m_curDualHeightTexture.IsValid):
│   │     m_curDualHeightTexture = renderGraph.ImportTexture(m_defaultDualHeightTexture (black 2D))
│   └── m_prevDualHeightTexture = renderGraph.CreateTexture(
│             new TextureDesc(cfg.textureSize.x, cfg.textureSize.y,
│                             clearColor = Color.yellow,        // 即 (1,1,0,1) — 高度 1.0 为「未踩过」
│                             format     = cfg.graphicsFormat,
│                             name       = "curDualHeightTexture") )
└── pass.SetRenderFunc(s_foliageInteractiveFunc):
     执行顺序（基于 HG 自研材质 keyword + RT 命名习惯重建）：
     1. cmd.SetRenderTarget(passData.curDualHeightTexture);
     2. cmd.ClearRenderTarget(yellow);                          // 高度 = 1，法向 = (0,1,0)
     3. cmd.SetGlobalVector(_CurCenterPos,  passData.curCenterPosition);
        cmd.SetGlobalVector(_CurCenterSize, passData.curCenterSize);
        cmd.SetGlobalVector(_LastCenterPos, passData.lastCenterPosition);
        cmd.SetGlobalVector(_LastCenterSize,passData.lastCenterSize);
        cmd.SetGlobalFloat (_DeltaTime,     max(passData.deltaTime, 0.033));
        cmd.SetGlobalFloat (_RaiseSpeed,    0.5f);              // FOLIAGE_INTERACTIVE_RAISE_SPEED
     4. // 用 foliageInteriaveBlitMaterial 把 prevDualHeightTexture 经过 raise 逻辑 blit 回 curDualHeightTexture：
        //   curHeight = saturate(prevHeight + _DeltaTime * _RaiseSpeed)
        //   并按 (curCenterPos - lastCenterPos) 做 UV scroll，让 RT 内容跟随相机视点平移
        cmd.Blit(prevDualHeightTexture, curDualHeightTexture, foliageInteriaveBlitMaterial, pass=0);
     5. // 喂入交互节点：
        //   foliageInteriaveColliderMaterial 把 sphere/capsule/mesh quad 作为「负向高度刷」
        //   draw 到 curDualHeightTexture，Blend Min，写入 height = saturate( yLocal - 0.5 )
        HGInterationManager.DrawInteractions(cmd, ctx,
                                              foliageInteriaveColliderMaterial,
                                              bounds = AABB(curCenterPos, curCenterSize));
        HGDecalInteration.DrawChainNodes(cmd, decalInteractionMaterial);     // texture-chain instance
```

> 第 4 步「Raise」是关键：草和雪需要踩完之后**慢慢回弹**。`_RaiseSpeed = 0.5`（`HGFoliageInteractiveConfig.FOLIAGE_INTERACTIVE_RAISE_SPEED`，`HGFoliageInteractiveConfig.cs:16`）= 每秒 +0.5 单位高度，半秒回到未压状态。`_MIN_DELTA_TIME = 0.033`（`:18`）= 即使 1000fps 也按 33ms 累积，确保回弹速率视觉一致。

### 6.1 Dual-Height 编码

RT 名 `_curDualHeightTexture` 即「双高度」：通常两通道分别存 **(downward press height, upward bend amount)**。

- **R 通道**：被压最低高度 (`0.0 = 完全踩到地`，`1.0 = 未压`)；
- **G 通道**：草叶弯折方向相关的 second-derivative（用于后续 shader 算 normal）；
- **B 通道**：法向 X（可选）；
- **A 通道**：填充 / time-since-press。

Clear 用 `Color.yellow = (1,1,0,1)` 与上面一致（高度 1 = 未压；G=1 表示无弯折；B=0 留给写入）。

> `m_defaultDualHeightTexture` 是 `Texture2D.blackTexture` 初值，避免 RT 还没创建时下游采样到野值。

### 6.2 Pass 索引常量

`HGInteractionNode.DrawSphereNode` (`:342-503`) 中：

```
non-CCD sphere:  cmd.DrawMesh(QuadMesh,  passIndex=0,  matrix, mat, propertyBlock)
CCD sphere:                              passIndex=1
```

`DrawCapsuleNode` (`:1035-1239`)：

```
non-CCD capsule:  passIndex=1, DrawMesh(QuadMesh)
CCD capsule:      passIndex=4, DrawMesh(Capsule)                   // 反汇编 mov [rsp+28h], 4 (:1194)
```

Chain texture pass = 3（见 §5.5）。

| pass | proxyType | 几何 | 用途 |
|---|---|---|---|
| 0 | Sphere 非 CCD / Mesh | QuadMesh | 单 splat |
| 1 | Sphere CCD / Capsule 非 CCD | QuadMesh | sweep / 胶囊投影 |
| 2 | (Texture node 单 instance fallback) | QuadMesh | 不走 chain 时备用 |
| 3 | Chain (Texture) | QuadMesh × N | 拖痕条带 instance |
| 4 | Capsule CCD | HGInteractionResources.Capsule | 上一帧→当前帧扫掠胶囊 |

### 6.3 Shader keyword

`HGInteractionNode.DrawSphereNode :376-402` 与 `DrawCapsuleNode :1063-1095` 都拼出一个 `LocalKeyword` 并 `cmd.SetKeyword(keyword, state)`：keyword 由 `HGShaderKeyWords.[+0x298]` 给出，对应 shader 里的 `_USE_CCD`（**据 keyword 槽位与上下文推断**）。

`BatchInstanceDraw` 同样的 keyword 槽位（`HGInterationManager.cs:1203-1218`）按 `head.ccdKeyword` 设置 → 同 batch 内 CCD/非 CCD 必须一致（因此进 `Sorter` 排序键）。

---

## 7. 下游消费 — 草 / 植被 / 雪 / 湿地 / 水

```
HGFoliageInteractiveManager.GetConfig()
HGFoliageInteractiveManager.GetCenter(out center, out size)
        ↓ FoliageInteractivePass.PrepareShaderVariablesGlobal (:507-)
全局 ShaderVariablesGlobal:
   _FoliageInteractiveCenterPos
   _FoliageInteractiveCenterSize
   _FoliageInteractiveTexture     ← 即 _curDualHeightTexture

下游 vertex shader (草 / 植被 / 雪 / 湿地)：
   float3 wsCenter = _FoliageInteractiveCenterPos.xyz;
   float3 wsSize   = _FoliageInteractiveCenterSize.xyz;
   float2 uv       = (wsPos.xz - wsCenter.xz) / wsSize.xz + 0.5;
   float4 dh       = SAMPLE_TEXTURE2D_LOD(_FoliageInteractiveTexture, sampler_linear_clamp, uv, 0);
   // dh.r = press height [0..1]
   // 草叶位移：
   float bend = saturate(1.0 - dh.r);                    // 越被踩弯越大
   wsPos.xyz += worldDown * bend * grassMaxBendHeight;
   wsPos.xyz += windDir   * bend * grassExtraTiltScale;  // 额外侧偏，模拟 squash
```

- **植被 / 草**：[`./03-FoliageGrass.md`](./03-FoliageGrass.md) §交互弯折 — 利用 dual-height 的 R 通道做顶点 squash + 用 G 通道作法向扰动；
- **雪 / 湿地脚印**：[`./11-WeatherWetness.md`](./11-WeatherWetness.md) §10/12 — 同一张 RT，雪 shader 把 R 通道作为 depth-mask 削减雪层厚度；
- **水面涟漪**：水自带 `WaterInteractionRenderingPass`，但 sphere/capsule 节点在涉水时也会同时写 dual-height → 让水边草也响应；
- **角色脚下 ground decal**：复用 chain 的 `_data4` time-fade 通道 ramp 出脚印淡出。

**交叉算法**：dual-height RT 的「**Raise-Splat Min-Blend**」配方与单元 `02-CoreAlgorithms` §14（[`../02-CoreAlgorithms/01-CoreAlgorithms.md`](../02-CoreAlgorithms/01-CoreAlgorithms.md#14-交互高度场渲染)）的交互高度场渲染算法描述同源 —— 都是 **Min-blend 写入 / 时间累加 raise / camera-anchored UV scroll** 三段式。

---

## 8. 关键常量与魔数总表

| 常量 | 值 | 反编译位置 | 含义 |
|---|---|---|---|
| `HGInterationManager.MAX_BATCH_INSTANCE_NUM` | 100 | `HGInterationManager.cs:9` | 一批 instance 上限 |
| `HGInteractionChain.CHAIN_MAX_NODE_COUNT` | 100 | `HGInteractionChain.cs:8` | 单链节点环上限 |
| `HGInteractionNode.MAX_DISTANCE` | 32.0f | `HGInteractionNode.cs:9` | groundHeight raycast 上限 |
| `HGInteractionNode.CAST_OFFSET` | 0.5f | `HGInteractionNode.cs:11` | raycast 起点抬高 |
| `HGInteractionNodeInstanceData` stride | 0xE0 = 224B | `BatchInstanceDraw :1088` | per-instance cbuffer |
| 100-instance cbuffer 大小 | 0x5780 = 22400B | `:1186` | `MAX_BATCH * 224` |
| `HGDecalInteractionData` stride | 144B (0x90) | `HGInteractionChain.cs:1228-1232` (`mov edx, 64h` count, `mov r8d, 2Ch+5Ch` 等) | per-chain-node cbuffer |
| chainBuffer 大小 | 0x3840 = 14400B | `:1255` | `100 * 144` |
| `HGDecalInteractionSettingData` stride | 32B (0x20) | `:1321` | `mov dword ptr [rsp+20h], 20h` |
| `HGDecalInteration.KEEP_BUSY_FRAMES` | 3 | `HGDecalInteration.cs:16` | 链失活回收延迟 |
| `HGFoliageInteractiveConfig.FOLIAGE_INTERACTIVE_RAISE_SPEED` | 0.5 | `HGFoliageInteractiveConfig.cs:16` | dual-height 每秒回弹速度 |
| `HGFoliageInteractiveConfig.FOLIAGE_INTERACTIVE_MIN_DELTA_TIME` | 0.033 | `:18` | 累积下限（30 fps 等效） |
| Capsule CCD passIndex | 4 | `HGInteractionNode.DrawCapsuleNode :1194` | 扫掠胶囊 |
| Chain texture passIndex | 3 | `HGInteractionChain.DrawChainNodes :1338` | 拖痕带 |
| Sphere CCD passIndex | 1 | `HGInteractionNode.DrawSphereNode :459 (`mov dword ptr [rsp+28h], 1`)` | sphere sweep |
| RT clear color | `Color.yellow = (1,1,0,1)` | `FoliageInteractivePassConstructor.cs:400` | 高度 1 / 未压 |
| `enableMobileInteraction` | `false`（恒返回 0） | `HGDecalInteration.cs:20` | 关闭移动端 chain |

---

## 9. 1:1 复刻蓝图

要从零重建此系统，逐步：

### Step 1 — 节点几何抽象层
1. 定义 `enum EInteractionProxyType { Sphere, Capsule, Texture, Mesh }`；
2. 定义 `MonoBehaviour HGInteractionComponent` 持有 § 2 中 8 个字段 + `lastTransform` 缓存；
3. 在 `OnEnable/OnDisable` 注册到全局单例 `HGInterationManager`；
4. 实现 `CollectInteractionNodes(List<HGInteractionNode>)`：每帧
   - 取 `transform.localToWorldMatrix`；与 `lastTransform` 比较生成 `prevM`；
   - 若 `prev == default(Matrix4x4)` → `prev = curr`；
   - 用 `Physics.Raycast(pos + Vector3.up*0.5f, Vector3.down, out hit, MAX_DISTANCE=32, defaultLayerMask)` 求 `groundHeight = hit.point.y - 0.5f`（未命中用 `pos.y - 0.5f`）；
   - 用 `transform.GetInstanceID()` 当 `nodeKey`；
   - 根据 `ProxyType` 调四类工厂 `HGInteractionNode.CreateXxxNode(...)`。

### Step 2 — 节点结构与 4 类构造器
1. 结构 `HGInteractionNode` 含 `nodeKey, proxyType, localToWorld, prevLocalToWorld, groundHeight, bUseCCD, length, radius, interactLength, interactHeight, texture, extent, heightScale, mesh`（与 `HGInteractionNodeV2` 完全一致字段，stride **0xB4 = 180B**）；
2. 实现 `ConstructSphereNode` / `ConstructCapsuleNode`：
   - 非 CCD：构造 `Matrix4x4.TRS(pos, identity, (2r,2r,1))`；
   - CCD：取 `delta = currPos - prevPos`，长度 `d = ‖delta‖`，若 `d == 0` 退化；否则 `forward = delta/d`，构造 `Matrix4x4.TRS(pos, Quaternion.LookRotation(forward), (r, r+0.5d, 1))`；
3. 实现 `ConstructTextureNode`：把 `extent` (Vector2) 与 `texture.GetInstanceID()` 作为 GPU payload，不做几何拟合（GPU 端按 quad 矩阵展开）；
4. 实现 `ConstructMeshNode`：把 `mesh.GetInstanceID()` 写入 `m_mesh`。

### Step 3 — instance / render data
1. 定义 `HGInteractionNodeInstanceData` 严格 224B（§3.1），其中 `worldToLocal = localToWorld.inverse` 在 `BuildXxxRenderData` 时算好；
2. 定义 `HGInteractionNodeRenderData` 持 `instanceData + mesh + passIndex + ccdKeyword`；
3. 实现 `BuildRenderData` 4 个变体；每个把对应 `passIndex` 设为 §6.2 表里的常量；
4. 实现 `Sorter(a, b)` 与 `Match(a, b)`：mesh-null 先排序、`passIndex` 次之、`ccdKeyword` 第三、否则按 `Mesh.GetInstanceID()` 差值。

### Step 4 — Manager 主循环
1. 实现 `HGInterationManager` 持 `objects / nodes / renderDatas / decalInteraction / settingAsset`；
2. `PipelineUpdate`: `CollectInteractions()` → `UpdateCppPipeline(false)`；
3. `CollectInteractions`：`nodes.Clear()`；`foreach obj in objects: obj.CollectInteractionNodes(nodes);` 顺手对 Texture 类型 forward 给 `decalInteraction.PushNewNodeToChain(node)`；
4. `UpdateCppPipeline`：把 `List<HGInteractionNode>` 拷贝到 `NativeArray<HGInteractionNodeV2>(180B/elem)`，调 native；
5. `DrawInteractions(cmd, ctx, mat, bounds)`：
   - `renderDatas.Clear()`；
   - 每个 node `if (node.GetBounds().Intersects(bounds))`：尝试 `BuildRenderData`，能 instance 化的 `renderDatas.Add`，否则 `DrawNode` 单 instance；
   - `renderDatas.Sort(Sorter)`；
   - 按 `Match` 分段循环 `BatchInstanceDraw(start, end, mat)`，内部按 100 切批，`AllocateConstantBuffer(100 * 224)` → memcpy → `SetGlobalConstantBufferInternal0(material, _HGInteractionNodeInstanceDataBuffer_id, handle, 0, 22400)` → `cmd.HGDrawMeshInstanced(mesh, passIndex, mat, count, null, ShadowCastingMode.Off)`。

### Step 5 — 链状态机
1. 定义 `HGInteractionChainNode`（128B，§5.1）、`HGInteractionChainSection`（16B，§5.2）；
2. 实现 `TRingBuffer<T>` 通用环 100；
3. 实现 `HGInteractionChain`：构造时分配 chainNodes / chainSections 各 100；`interactionData (HGDecalInteractionData[100])` + `chainBuffer (ConstantBuffer 14400B)`；`settingData[1]` + `settingDataBuffer (ConstantBuffer 32B)`；
4. 实现 `PushNewNode(in node)` 按 §5.3 八步流程：
   - 算 vertex0~3；
   - 取 `prev = chainNodes.GetCurrentNode()`；
   - 比较 `dot(prev.forward, curr.forward) < settingAsset.rotationThreshold` → 新 Section；
   - 比较 `‖curr.pos - prev.pos‖ < settingAsset.nodeDistanceThreshold` → 更新 prev，否则 `AddNewNode`；
   - VRange 累计 += 弧长；
   - HeightFade.x = saturate((node.height - groundHeight - heightMin) / (heightMax - heightMin))；
   - TimeFade.w = 0；
5. 实现 `UpdateChainFade()`：每帧 dt × `settingAsset.timeFadeSpeed`，累加 TimeFade.w；超 1 → `Active = false` → `DeleteTailNodes(deadCount)`；
6. 实现 `DrawChainNodes(cmd, mat)` 按 §5.5：
   - lazy alloc `chainBuffer` (100, 144) ConstantBuffer；
   - 把 chainNodes 序列化到 `interactionData[]` (pack `_data0~4`)；
   - `chainBuffer.SetData(interactionData)`；
   - `propertyBlock.SetConstantBuffer(_DecalInteractionDataBuffer_id, chainBuffer, 0, 14400)`；
   - 同样处理 settingDataBuffer，`_EdgeFadeRatio = 1.0 / settingAsset.edgeFadeDistance`；
   - `cmd.HGDrawMeshInstanced(QuadMesh, passIndex=3, mat, activeCount, propertyBlock, Off)`。

### Step 6 — `HGDecalInteration` 池化
1. 持 `freeChains / busyChains / pendingFreeChains`，常量 `KEEP_BUSY_FRAMES = 3`；
2. `PushNewNodeToChain(node)`：若 `busyChains[node.nodeKey]` 不存在 → `GetFreeChain()`（freeChains 空则 `new HGInteractionChain(settingAsset)`）；调 `chain.PushNewNode(node)`；`chain.LastAccessFrame = Time.frameCount`；
3. 每帧 update 阶段：遍历 busyChains，`Time.frameCount - chain.LastAccessFrame > 3` → 放入 pendingFreeChains；末尾批量 `chain.Reset()` → 放回 freeChains，busyChains 移除。

### Step 7 — FoliageInteractivePass
1. 在 RenderGraph 注册 pass：
   - `PrepareFoliageInteractTexture` 用 `HGFoliageInteractiveManager.GetConfig()` 得 textureSize/format/centerOffsetHeight；
   - `m_prevDualHeightTexture` = renderGraph.CreateTexture(desc{ clear=Color.yellow, format=cfg.graphicsFormat })；
   - `m_curDualHeightTexture` = renderGraph.ImportTexture(m_defaultDualHeightTexture)；
2. SetRenderFunc：
   - SetGlobalVector `_LastCenterPos/_LastCenterSize/_CurCenterPos/_CurCenterSize`；
   - SetGlobalFloat `_DeltaTime = max(Time.deltaTime, 0.033f)`；`_RaiseSpeed = 0.5f`；
   - `cmd.Blit(prevDualHeightTexture, curDualHeightTexture, foliageInteriaveBlitMaterial, 0)` — blit shader 做 raise + camera-anchored UV scroll；
   - 用 `foliageInteriaveColliderMaterial` 调 `manager.DrawInteractions(cmd, ctx, mat, bounds)` 把 sphere/capsule/mesh node 以 Min-blend 写入；
   - 调 `decalInteraction.DrawChainNodes(cmd, settingAsset.decalInteractionMaterial)` 写入 chain；
3. `PostPrepareFoliageInteractTexture`：`renderGraph.PreserveTexture(curDualHeightTexture)` 跨帧保留 → 下一帧 swap 进 prev。

### Step 8 — 下游 shader hook
按 §7 把 `_FoliageInteractiveTexture / _FoliageInteractiveCenterPos / _FoliageInteractiveCenterSize` 加入 `ShaderVariablesGlobal`，foliage / 草 / 雪 shader 中按 § 7 模板采样位移。

---

## 10. 支撑证据 — 源文件清单与结构表

### 10.1 单元 12 文件清单 (`render_cells.json` C12_Interaction 数组)

| 文件 | 职责 |
|---|---|
| [`HGInteractionComponent.cs`](file:///D:/Ruri/02.Unity/Project/EndFieldSource/Assets/Scripts/HG.RenderPipelines.Runtime/HG/Rendering/Runtime/HGInteractionComponent.cs) | MonoBehaviour 入口，注册到 manager，每帧 `CollectInteractionNodes` 把自己变成节点 |
| [`HGInteractionNode.cs`](file:///D:/Ruri/02.Unity/Project/EndFieldSource/Assets/Scripts/HG.RenderPipelines.Runtime/HG/Rendering/Runtime/HGInteractionNode.cs) | 节点结构（180B）+ 4 类工厂 `CreateXxxNode` + `BuildXxxRenderData` + `DrawXxxNode` |
| [`HGInteractionNodeInstanceData.cs`](file:///D:/Ruri/02.Unity/Project/EndFieldSource/Assets/Scripts/HG.RenderPipelines.Runtime/HG/Rendering/Runtime/HGInteractionNodeInstanceData.cs) | per-instance cbuffer struct (224B) |
| [`HGInteractionNodeRenderData.cs`](file:///D:/Ruri/02.Unity/Project/EndFieldSource/Assets/Scripts/HG.RenderPipelines.Runtime/HG/Rendering/Runtime/HGInteractionNodeRenderData.cs) | render-time wrapper + `Sorter` + `Match` |
| [`HGInteractionChain.cs`](file:///D:/Ruri/02.Unity/Project/EndFieldSource/Assets/Scripts/HG.RenderPipelines.Runtime/HG/Rendering/Runtime/HGInteractionChain.cs) | 单条链：100 节点 + 100 section 环；`PushNewNode` / `UpdateChainFade` / `DrawChainNodes` |
| [`HGInteractionChainNode.cs`](file:///D:/Ruri/02.Unity/Project/EndFieldSource/Assets/Scripts/HG.RenderPipelines.Runtime/HG/Rendering/Runtime/HGInteractionChainNode.cs) | 链节点结构 (128B) |
| [`HGInteractionChainSection.cs`](file:///D:/Ruri/02.Unity/Project/EndFieldSource/Assets/Scripts/HG.RenderPipelines.Runtime/HG/Rendering/Runtime/HGInteractionChainSection.cs) | 链 section 结构 (16B) |
| [`HGDecalInteractionData.cs`](file:///D:/Ruri/02.Unity/Project/EndFieldSource/Assets/Scripts/HG.RenderPipelines.Runtime/HG/Rendering/Runtime/HGDecalInteractionData.cs) | 提交到 GPU 的 chain 节点 cbuffer (144B) |
| [`HGDecalInteractionSettingData.cs`](file:///D:/Ruri/02.Unity/Project/EndFieldSource/Assets/Scripts/HG.RenderPipelines.Runtime/HG/Rendering/Runtime/HGDecalInteractionSettingData.cs) | 全链共享阈值 cbuffer (32B) |
| [`HGInteractionResources.cs`](file:///D:/Ruri/02.Unity/Project/EndFieldSource/Assets/Scripts/HG.RenderPipelines.Runtime/HG/Rendering/Runtime/HGInteractionResources.cs) | 静态 Mesh 资源 (QuadMesh / Capsule / Cube / Cylinder) |
| [`HGInteractionSettingAsset.cs`](file:///D:/Ruri/02.Unity/Project/EndFieldSource/Assets/Scripts/HG.RenderPipelines.Runtime/HG/Rendering/Runtime/HGInteractionSettingAsset.cs) | ScriptableObject，作者侧 11 个调参字段 |
| [`IHGInteractionObject.cs`](file:///D:/Ruri/02.Unity/Project/EndFieldSource/Assets/Scripts/HG.RenderPipelines.Runtime/HG/Rendering/Runtime/IHGInteractionObject.cs) | 单方法接口 `CollectInteractionNodes(List<HGInteractionNode>)` |

### 10.2 单元外辅助证据（cross-ref）

| 文件 | 职责 |
|---|---|
| [`HGInterationManager.cs`](file:///D:/Ruri/02.Unity/Project/EndFieldSource/Assets/Scripts/HG.RenderPipelines.Runtime/HG/Rendering/Runtime/HGInterationManager.cs) | 全局单例，§4 主循环；不在 C12 数组但属于本系统主干 |
| [`HGDecalInteration.cs`](file:///D:/Ruri/02.Unity/Project/EndFieldSource/Assets/Scripts/HG.RenderPipelines.Runtime/HG/Rendering/Runtime/HGDecalInteration.cs) | 链池化 + Texture 节点 dispatcher；同上 |
| [`UnityEngine/HyperGryph/EInteractionProxyType.cs`](file:///D:/Ruri/02.Unity/Project/EndFieldSource/Assets/Scripts/UnityEngine.HGGraphicsModule/UnityEngine/HyperGryph/EInteractionProxyType.cs) | proxy 枚举（4 值） |
| [`UnityEngine/HyperGryph/HGInteractionNodeV2.cs`](file:///D:/Ruri/02.Unity/Project/EndFieldSource/Assets/Scripts/UnityEngine.HGGraphicsModule/UnityEngine/HyperGryph/HGInteractionNodeV2.cs) | native 桥接结构 (180B)，与 managed `HGInteractionNode` 一一对应 |
| [`FoliageInteractivePassConstructor.cs`](file:///D:/Ruri/02.Unity/Project/EndFieldSource/Assets/Scripts/HG.RenderPipelines.Runtime/HG/Rendering/Runtime/FoliageInteractivePassConstructor.cs) | RenderGraph pass，组织 dual-height RT 与 raise blit；消费方端 |
| [`HGFoliageInteractiveConfig.cs`](file:///D:/Ruri/02.Unity/Project/EndFieldSource/Assets/Scripts/HG.RenderPipelines.Runtime/HG/Rendering/Runtime/HGFoliageInteractiveConfig.cs) | textureSize / format / raise / centerSize 等运行常量 |

### 10.3 关键结构 stride 总览

| 结构 | 字节数 | 用途 |
|---|---|---|
| `HGInteractionNode` (managed) | 180 (0xB4) | CPU 节点收集池 |
| `HGInteractionNodeV2` (native) | 180 (0xB4) | native 桥接 |
| `HGInteractionNodeInstanceData` | 224 (0xE0) | DrawInteractions 用 instance cbuffer |
| `HGInteractionNodeRenderData` | 240 (≈0xF0) | CPU sort/match 包装 |
| `HGInteractionChainNode` | 128 (0x80) | 链节点环槽 |
| `HGInteractionChainSection` | 16 (0x10) | 链 section 环槽 |
| `HGDecalInteractionData` | 144 (0x90) | DrawChainNodes 用 cbuffer |
| `HGDecalInteractionSettingData` | 32 (0x20) | 全局阈值 cbuffer |

### 10.4 留待确认项

- `_data0~4` 内 5 个 Vector4 的字段精确语义（VRange/HeightFade/TimeFade/StartDist/Scale/Vertex 各占哪几个 lane）—— 反汇编只能定到 stride 144B 与字段集合，**精确 pack 顺序须打 RenderDoc 抓 cbuffer 双向比对**才能 1:1；本文按 HDRP `DecalCachedChunk` 同类 trail-decal pack 习惯做强推断标注。
- DualHeight RT 的具体 `GraphicsFormat` —— `HGFoliageInteractiveConfig.graphicsFormat` 在 settings 资产里配置，本文未抓默认值（不影响算法 1:1 复刻，复刻时按 `R16G16_UNorm` 起步即可，多数 dual-height 实现都是这个）。
- DrawInteractions 的 collider 材质 shader pass 命名 —— 反编译里只看到 passIndex 数值，没有命名串；shader 自定义 keyword 槽位 `[HGShaderKeyWords + 0x298]` 推断为 `_USE_CCD`，需在 keyword table 反查确认。

