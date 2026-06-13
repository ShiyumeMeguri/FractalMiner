# HG Render Pipeline — CSG 构造实体几何 / SDF 有向距离场 烘焙资源 技术实现原理蓝图

> 本文是 **从零重建** 终末地 (EndField) HG.RenderPipelines 两条**离线 / 烘焙期几何工具链**的实现蓝图：
>
> 1. **CSG (Constructive Solid Geometry) 布尔几何运算 — `Union / Intersect / Subtract`**：基于 **BSP (Binary Space Partition) 树** 的多边形裁剪算法。完全等价 Evan Wallace **csg.js** 经典公式 (`a.clipTo(b); b.clipTo(a); b.invert(); …`)，**核心算法 = HG 自研搬运标准开源算法**。
> 2. **SDF (Signed Distance Field) 体素化烘焙资源容器 — `SDFBakeResources`**：1:1 复刻 Unity VFXGraph 的 `VFXRuntimeResources` SDF 资源块 (`sdfRayMapCS` / `sdfNormalsCS` / `sdfRayMapShader`)；驱动的算法是 Unity 官方 **6-Rays Sign + Jump Flooding Algorithm (JFA) Distance Transform** 的 mesh→3D SDF 烘焙管线。
>
> **原理依据**：
> - CSG/BSP 主算法 — 据反汇编调用图 `Node::ClipTo` / `Node::ClipPolygons` / `Plane::SplitPolygon` + EPSILON `g_18C471904`=0.001f 直证（标准 csg.js `csg.js@e84c2c50` 算法）；
> - SDF 烘焙 — 据 HDRP 同源源 `com.unity.visualeffectgraph@3e2a77062d77/Shaders/SDFBaker/GenSdfRayMap.compute` 与 `Runtime/Utilities/SDF/MeshToSDFBaker.cs` 1:1 抄录；
> - 数据结构与常量 — 据 HG 反编译 `CSG/CSGPlane.cs`、`CSG/CSGPolygon.cs`、`CSG/CSGVertex.cs`、`CSG/ICsgProvider.cs`、`SDF/SDFBakeResources.cs` 直证。
>
> **不在 runtime per-frame 路径上**：CSG 工具链由 IV (Irradiance Volume) 烘焙器调用（已在 [`./09-GI-IrradianceSH.md`](./09-GI-IrradianceSH.md) §10 简述）。SDF 资源容器为 VFXGraph mesh→SDF 流水线的 ScriptableObject 持有体。本文聚焦 **CSG/SDF 主算法蓝图**，BSP 容器 / Node / PolygonType 等辅助类型已在 [`./09-GI-IrradianceSH.md`](./09-GI-IrradianceSH.md) §10 与 [`../12-PipelineSubsystems/09-Utilities-Math-Infra.md`](../12-PipelineSubsystems/09-Utilities-Math-Infra.md) 覆盖，本文**按名引用**。

---

## 0. 目录

| § | 主题 |
|---|------|
| 1 | 这个系统解决什么问题 / 最终用途 |
| 2 | 单元文件清单 + 类型一览 |
| 3 | CSG 数据结构 (CSGPlane / CSGPolygon / CSGVertex / ICsgProvider) |
| 4 | CSG 核心算法：Plane.SplitPolygon — 多边形裁剪 |
| 5 | CSG 核心算法：Node.ClipPolygons / ClipTo / Invert / Build (csg.js 蓝本) |
| 6 | CSG 布尔运算公式：Union / Intersect / Subtract / Clear |
| 7 | CSG mesh ↔ BSP 桥接：`BSP.fromMesh` 与 `BSP.Transform` |
| 8 | SDF 烘焙资源容器：`SDFBakeResources` 1:1 = VFX `VFXRuntimeResources` |
| 9 | SDF 烘焙算法链：6-Rays Sign + JFA + Distance Transform (HDRP/VFXGraph 同源) |
| 10 | 1:1 复刻蓝图 (CSG + SDF 分步) |
| 11 | 关键常量 / 魔数 |

---

## 1. 这个系统解决什么问题 / 最终用途

### 1.1 CSG (Constructive Solid Geometry)

CSG 是把几何体当作**集合 (set)** 看待，用三种布尔算子组合：
- **Union (并)** `A ∪ B` — 焊接两块几何（去除内部公共面）
- **Intersect (交)** `A ∩ B` — 取两块几何的公共体
- **Subtract (差)** `A − B` — 从 A 上**雕刻**走 B 占用的部分（最常用的「打洞」「凿坑」「玩家放置式破坏」原语）

HG 把这一套放在 `HG.Rendering.Runtime.CSG` 命名空间里，**只在烘焙 / 编辑器**期使用，**不进入 per-frame 渲染热路径**。已知的下游消费者：
- **IV (Irradiance Volume) 烘焙器** — 用 BSP raycast 判断每个 probe 是否处于墙体/物体内部，把墙内 probe 标 invalid。详见 [`./09-GI-IrradianceSH.md`](./09-GI-IrradianceSH.md) §10。
- 编辑器辅助 mesh 切片 / 体素覆盖测试 / 烘焙期场景几何 dissolve。

> **「为什么不在 runtime」**：BSP 构造与 Boolean 操作都是 O(N log N) 甚至更坏，递归切割产生大量 GC 多边形对象，移动端 / 主机帧预算无法承担。HG 的做法和大多数引擎一致：runtime 用 voxel/SDF/mesh-replace，CSG 留给编辑期。

### 1.2 SDF (Signed Distance Field) 烘焙资源容器

`SDFBakeResources` 是一个 **ScriptableObject** —— 它**本身不跑 SDF 算法**，只是**装着三个 Asset 引用**（一个体素化 raymap 计算着色器、一个法线/几何辅助计算着色器、一个 raymap 体素化的栅格化 Shader），交给 mesh→SDF 烘焙器使用。

最终视觉效果（**通过持有它的烘焙器**实现）：把任意 closed mesh **离线** 烘焙成一张 **3D Texture (有符号距离场)**，让 runtime VFX 系统 (粒子碰撞、体积云形状 SDF、特效投影、软粒子衰减) 把网格当作连续的距离场来采样，达成**对原始 mesh 形状的几何无关近似**。

---

## 2. 单元文件清单 + 类型一览

本单元仅 5 个 `.cs` 文件（CSG 算法纯 CPU/C#，SDF 仅一个资源容器）。配套辅助类型 (`BSP / Node / PolygonType / ThreadData / Extensions`) **不在本单元名单**，按 §0 引言交叉引用。

| 文件 | 类型 | 一句话职责 |
|------|------|-----------|
| `CSG/CSGPlane.cs` | `class CSGPlane { Vector3 normal; float w; }` | HG 自定义平面（与 `UnityEngine.Plane` 并存），承载 `fromPoints / clone / flip`；`EPSILON` 静态字段（值由 § 4 反汇编锁死） |
| `CSG/CSGPolygon.cs` | `class CSGPolygon` | CSG 多边形 — 持 `UnityEngine.Plane Plane` (readonly)、`CSGVertex[] Vertices`、`int objID / materialID`；提供 `CalculateVertexNormals / Flip / Clone / IsDegenerateSet`（去重共点 → 顶点数 <3 即退化） |
| `CSG/CSGVertex.cs` | `class CSGVertex { Vector3 Position; Vector3 Normal; Vector2 UV; int id; }` | CSG 顶点 — `Flip` 翻法线、`Interpolate(other, t)` 沿 `t` 线性插值 P/N/UV（**切割时生成边交点的关键**），`ToString` 调试 |
| `CSG/ICsgProvider.cs` | `interface ICsgProvider` | 暴露 `IEnumerable<CSGPolygon> Polygons` + `Union(BSP) / Intersect(BSP) / Subtract(BSP) / Clear()` —— 任何能 ↔ CSG 的对象 (BSP / mesh wrapper / 编辑器 brush) 都实现它 |
| `SDF/SDFBakeResources.cs` | `internal class SDFBakeResources : ScriptableObject` | 三字段引用容器：`m_SDFRayMapCS` (ComputeShader) / `m_SDFNormalsCS` (ComputeShader) / `m_SDFRayMapShader` (Shader)，及对应内部 getter/setter (§8) |

**本单元按名引用的外部类型**（其反编译在他处覆盖，本文不复述其内部实现）：
- `HG.Rendering.Runtime.CSG.BSP : ICsgProvider` — BSP 容器，`root` 字段持 `Node`；声明 `Union/Intersect/Subtract/Clear/Clone/Transform/fromMesh`（→ `./09-GI-IrradianceSH.md` §10）
- `HG.Rendering.Runtime.CSG.Node` — BSP 节点 (`Plane? splitPlane; Node front; Node back; List<CSGPolygon> polygons`)；声明 `Invert / ClipPolygons / ClipTo / Build / AllPolygons / Clone`（→ `./09-GI-IrradianceSH.md` §10）
- `HG.Rendering.Runtime.CSG.PolygonType` — 枚举 `Coplanar=0 / Front=1 / Back=2 / Spanning=3 (=Front|Back)`（位标志，分类点-面关系；→ `../12-PipelineSubsystems/09-Utilities-Math-Infra.md`）
- `HG.Rendering.Runtime.CSG.Extensions` — 扩展静态类，提供 `Plane.SplitPolygon(...)` / `Plane.Distance(v)` / `Append<T>` / `Bounds.IncludePoint` / `Ray.Intersects(BSP)`（→ `../12-PipelineSubsystems/09-Utilities-Math-Infra.md`）
- `HG.Rendering.Runtime.CSG.ThreadData` — 多线程切割工作项 (start/end 索引 + matrix + verts + normals + uv + objID + polys 三段 + node)（→ `../12-PipelineSubsystems/09-Utilities-Math-Infra.md`）

> § 4–§ 7 仍会**调用**这些类型的方法 / 字段（按名），因为只有把它们组合起来，CSG 算法蓝图才完整可执行。本文不复述其反汇编。

---

## 3. CSG 数据结构 (CSGPlane / CSGPolygon / CSGVertex / ICsgProvider)

### 3.1 `CSGPlane` — Hesse 法式平面

```csharp
[Serializable]
public class CSGPlane {
    public Vector3 normal;   // 单位法线
    public float   w;        // 平面方程: n · p = w   ⟺  n · p − w = 0
    public static float EPSILON;  // 见 § 4
    public CSGPlane(Vector3 normal, float w);
    public static CSGPlane fromPoints(Vector3 a, Vector3 b, Vector3 c);
    public CSGPlane clone();
    public void flip();
}
```

**`fromPoints(a, b, c)` 反汇编公式**（`CSG/CSGPlane.cs:27-160`）：
```
v1 = b − a            // call UnityEngine.Vector3::op_Subtraction
v2 = c − a            // call UnityEngine.Vector3::op_Subtraction
n_raw = v1 × v2       // call UnityEngine.Vector3::Cross
len   = ‖n_raw‖       // call loc_184215BA0  (= Vector3.Magnitude 内联)
n     = n_raw / len   // divss xmm, xmm0   x3 个分量
w     = n · a         // call UnityEngine.Vector3::Dot
return new CSGPlane(n, w)
```
即顺时针三点 → 右手法线 → 法式参数 `(n, w)`。

**`flip()`** 反汇编（`CSG/CSGPlane.cs:204-249`）：
```
normal = normal * -1            // call UnityEngine.Vector3::op_Multiply
w     ^= 0x80000000             // xorps xmm0, [浮点符号位字段]
```
即翻转方向 + 翻转 `w` 符号（`n · p = w` ↔ `(−n) · p = −w`）。

> HG 同时使用 `UnityEngine.Plane` 与自定义 `CSGPlane`：`CSGPolygon.Plane` 字段是 `UnityEngine.Plane`（readonly），构造时用 `Plane::.ctor(CSGVertex.Position × 3)` 现算；`CSGPlane` 主要在 BSP `Node.splitPlane` 路径上间接作为输入参数类型（实际 BSP 节点存的是 `UnityEngine.Plane?`）。二者算法等价（`Plane(n, w)` ↔ `Plane(n, d=-w)`，HG 用 `n·p = w` 符号约定）。

### 3.2 `CSGPolygon` — 一个 CSG 面

```csharp
[Serializable]
public class CSGPolygon {
    public readonly Plane     Plane;        // UnityEngine.Plane, 构造时算出
    public CSGVertex[]        Vertices;     // 至少 3 顶点（凸/平面 polygon）
    public int                objID;        // 来源 mesh 编号（用于多对象布尔）
    public int                materialID;   // 所属材质 (Subtract/Union 后能保留材质归属)
    public CSGPolygon(CSGVertex a, CSGVertex b, CSGVertex c, int objID, int materialID);
    public CSGPolygon(IEnumerable<CSGVertex> vertices, int objID, int materialID);
    public void CalculateVertexNormals();   // 把 polygon.Plane 法线灌进所有顶点
    public CSGPolygon Flip();
    public CSGPolygon Clone();
    public static bool IsDegenerateSet(IEnumerable<CSGVertex> set);
}
```

**3 顶点构造体反汇编**（`CSG/CSGPolygon.cs:18-113`）：直接传 `a.Position, b.Position, c.Position` 给 `UnityEngine.Plane::.ctor` → 写入 `Plane`；然后 `il2cpp_vm_array_new_specific(CSGVertex[3])` 分配长度=3 数组，依序放 `a, b, c`。

**`IEnumerable<CSGVertex>` 构造体**（`CSG/CSGPolygon.cs:115-208`）：
```
Vertices = vertices.ToArray()
Plane    = new Plane(vertices.First().P,
                     vertices.Skip(1).First().P,
                     vertices.Skip(2).First().P)
```
即用前三个顶点定平面（凸 polygon 平面性由调用方保证 — Split 切出的新 polygon 都自然平面性 OK）。

**`Flip()`** 反汇编（`CSG/CSGPolygon.cs:264-369`）：
```
reversed = Vertices.Reverse().Select(v => v.Flip())   // 顶点序反转 + 每个顶点 .Flip()
return new CSGPolygon(reversed, objID, materialID)    // ctor 重算 Plane（反向 → 法线反向）
```
**绕序反 + 每顶点法线反 = 整片 polygon 朝向翻转**。

**`CalculateVertexNormals()`** 反汇编（`CSG/CSGPolygon.cs:210-262`）：把 `this.Plane.normal` 直接灌进 `Vertices[i].Normal`（仅 polygon 平面法线，**不平滑**）：
```
for i in [0, Vertices.Length):
    Vertices[i].Normal = this.Plane.normal
```
此函数用于 BSP→Mesh 回烘焙时强制面平直光照。

**`IsDegenerateSet(IEnumerable<CSGVertex> set)`** 反汇编（`CSG/CSGPolygon.cs:433-562`，关键尾段）：
```
set.GroupBy(v => v.Position)
   .Select(g => g.First())
   .Count()  <  3       // setl al
```
即「去掉位置相同的重复顶点后还剩不到 3 个 → 退化」。`Plane.SplitPolygon` 在 Spanning 分类后切出新 polygon 必须 `count >= 3 && !IsDegenerateSet` 才会被 commit（见 § 4）。

### 3.3 `CSGVertex` — 带 P/N/UV/id 的顶点

```csharp
[Serializable]
public class CSGVertex {
    public Vector3 Position;
    public Vector3 Normal;
    public Vector2 UV;
    public int     id;             // 来源 mesh 顶点索引（用于 BSP→Mesh 回烘焙时复用顶点）
    public CSGVertex(Vector3 position, Vector3 normal, Vector2 UV1, int id);
    public CSGVertex Flip();
    public CSGVertex Interpolate(CSGVertex other, float t);
    public override string ToString();
}
```

**`Flip()`** 反汇编（`CSG/CSGVertex.cs:50-135`）：
```
newNormal = −this.Normal             // call UnityEngine.Vector3::op_UnaryNegation
return new CSGVertex(this.Position, newNormal, this.UV, this.id)
```
**位置不动，法线反向**（UV 与 id 透传）。

**`Interpolate(other, t)`** 反汇编（`CSG/CSGVertex.cs:138-262`，关键运算）：
```
P_new  = Lerp(this.Position, other.Position, t)   // call loc_184215B30  ( = Vector3.Lerp 内联)
N_new  = Lerp(this.Normal,   other.Normal,   t)   // 同上
UV_new = this.UV + (other.UV − this.UV) * t       // 标量直算（看 subss xmm7,…; mulss xmm7,xmm0; addss…）
return new CSGVertex(P_new, N_new, UV_new, this.id)
```
**沿边线性插值 P / N / UV，id 取 `this.id`**（边交点继承「左端点」id，BSP→Mesh 回烘焙时认作新顶点）。这正是 `Plane.SplitPolygon` 在 Spanning 边上算交点时用到的关键。

### 3.4 `ICsgProvider` — 抽象接口

```csharp
public interface ICsgProvider {
    IEnumerable<CSGPolygon> Polygons { get; }
    void Union(BSP bsp);
    void Intersect(BSP bsp);
    void Subtract(BSP bsp);
    void Clear();
}
```
任何"我能被当作 CSG 体"对象的契约：能列出当前所有面，能与一个 BSP 求 并/交/差，能清空。`BSP` 自身实现它（→ `./09-GI-IrradianceSH.md` §10）。

---

## 4. CSG 核心算法：`Plane.SplitPolygon` — 多边形裁剪

这是整个 CSG 体系**最底层的几何算子**。`Node.ClipPolygons` 和 `Node.Build` 都依赖它。**反汇编位于 `CSG/Extensions.cs:713-1364` 的 `SplitPolygon(this Plane plane, CSGPolygon polygon, IList<CSGPolygon> coPlanarFront, IList<CSGPolygon> coPlanarBack, IList<CSGPolygon> front, IList<CSGPolygon> back)`**。

### 4.1 EPSILON 常量（**直证**）

`CSG/Extensions.cs:701-703`：
```csharp
public const float EPSILON = 0.001f;
public const float Epsilon = 0.001f;
```
反汇编里同一常量以两种姿态出现：`g_18C471904 = 0.001f`（"高于此距离 = Front"）与 `g_18C4714A4 = −0.001f`（"低于此距离 = Back"），即 `±EPSILON` 厚度带。

### 4.2 顶点 → 平面侧分类（一次扫描）

对 `polygon.Vertices` 每个顶点 `v_i` 算**带符号距离** `d_i = n · v_i − w`（HG 通过 `Extensions::Distance(plane, vertex)`）：

```
movss xmm7, dword ptr [g_18C471904]   ; xmm7 = +EPSILON = +0.001
…
call HG.Rendering.Runtime.CSG.Extensions::Distance
comiss xmm7, xmm0          ; 比较 +EPSILON vs d_i
jbe short loc_18A86DDE5    ; 若 +EPSILON <= d_i → 跳"Front"分支
mov ebx, 2                 ; type = BACK     (因为 d_i 比 −EPSILON 小)
…
loc_18A86DDE5:
xor ebx, ebx
comiss xmm0, dword ptr [g_18C4714A4]  ; d_i vs −EPSILON
seta bl                    ; 若 d_i > −EPSILON → bl=1=FRONT，否则 bl=0=COPLANAR
```

**分类规则**（与 csg.js 完全一致，写成可读形式）：
```
if      d_i < −EPSILON :  t_i = BACK     = 2
else if d_i >  +EPSILON :  t_i = FRONT    = 1
else                   :  t_i = COPLANAR = 0
```

把每顶点 `t_i` 累加成多边形分类 `T = OR_i t_i`：
- `T == 0` (`COPLANAR`) — 整片 polygon 都在平面 ±EPSILON 厚度带内
- `T == 1` (`FRONT`) — 整片在前方
- `T == 2` (`BACK`) — 整片在后方
- `T == 3` (`SPANNING`) — 至少一个顶点在前 + 至少一个在后 ⇒ 跨越，需要**切割**

这就是 `PolygonType` 枚举与 `[Flags]` 标记的来源（`Coplanar=0, Front=1, Back=2, Spanning=3=Front|Back`）。

### 4.3 三个非 Spanning 分支：直接归桶

```
COPLANAR : 用 polygon.Plane.normal · plane.normal 区分朝向：
            if (poly.N · plane.N > 0)  → coPlanarFront.Add(polygon)
            else                       → coPlanarBack.Add(polygon)
FRONT    : front.Add(polygon)
BACK     : back .Add(polygon)
```

反汇编：`Vector3::Dot(poly.Plane.normal, plane.normal)` 后 `comiss xmm0, dword ptr [g_18C471248]` (= 0.0f)，`> 0` 走 coPlanarFront 否则 coPlanarBack。所有 `.Add` 都**加锁** (`Monitor::Enter` 在 `lock1..lock4` 静态 `object` 上)，即整套算法**线程安全**，可多线程并行处理 `ThreadData.start..end` 区间（→ `../12-PipelineSubsystems/09-Utilities-Math-Infra.md` `ThreadData`）。

### 4.4 SPANNING 分支：沿平面切出两片新多边形

这是切割算法的核心。反汇编 `CSG/Extensions.cs:1008-1252`：

```
fList = new List<CSGVertex>(10)     // 前方新顶点序列
bList = new List<CSGVertex>(10)     // 后方新顶点序列
n     = polygon.Vertices.Length

for i in [0, n):
    j  = (i+1) % n
    ti = types[i]                   // PolygonType.get_Item(i)
    tj = types[j]                   // PolygonType.get_Item(j)
    vi = polygon.Vertices[i]
    vj = polygon.Vertices[j]

    if ti != BACK     : fList.Add(vi)      // 顶点 i 在前侧或共面 → 归前
    if ti != FRONT    : bList.Add(ti == BACK ? vi : vi.Clone())  // 在后侧或共面 → 归后

    if (ti | tj) == SPANNING :       // 边 i→j 跨越平面 → 算交点
        // t = (plane.W − plane.N · vi.P) / (plane.N · (vj.P − vi.P))
        denom = (vj.P.x − vi.P.x) * plane.N.x
              + (vj.P.y − vi.P.y) * plane.N.y
              + (vj.P.z − vi.P.z) * plane.N.z
        numer = −plane.W − (vi.P.x * plane.N.x
                          + vi.P.y * plane.N.y
                          + vi.P.z * plane.N.z)
        t = numer / denom
        v_mid = vi.Interpolate(vj, t)    // §3.3 公式 — Lerp P/N/UV，id 取 vi
        fList.Add(v_mid)
        bList.Add(v_mid)                  // 同一交点共享给前后片
```

> **公式溯源**：以 `n · p = w` 形式，求 `vi + t·(vj − vi)` 满足 `n · p = w` →
> `t = (w − n·vi) / (n·(vj − vi))`，即 csg.js `polygon.js@SplitPolygon` 同款（HG 反汇编中带 `−plane.W` 符号是因为 `UnityEngine.Plane` 的 `distance` 字段是 `−w` 约定，等价）。

切出的两片成型 polygon：
```
if (fList.Count >= 3 && !CSGPolygon.IsDegenerateSet(fList))
    front.Add(new CSGPolygon(fList, polygon.objID, polygon.materialID))
if (bList.Count >= 3 && !CSGPolygon.IsDegenerateSet(bList))
    back .Add(new CSGPolygon(bList, polygon.objID, polygon.materialID))
```
**退化跳过**（< 3 顶点或共点重复 < 3 个独立位置 — § 3.2 IsDegenerateSet）。

### 4.5 SplitPolygon ASCII 流程图

```
              CSGPolygon polygon
                     │
        ┌────────────┴────────────┐
        │ 为每顶点 i 算 d_i        │
        │  = polygon.V[i].P · n − w│
        │  分类:                   │
        │   d<−ε ⇒ BACK            │
        │   d>+ε ⇒ FRONT           │
        │   else ⇒ COPLANAR        │
        │  T = OR_i type_i         │
        └────────────┬────────────┘
                     ▼
       ┌─────────────┼─────────────┐
       │             │             │
   COPLANAR       FRONT          BACK         SPANNING
   ──┬────         ──┬─          ──┬─        ─────┬──────
     │                │             │              │
  (poly.N·n>0?)    front.Add()  back .Add()  逐边算交点 t
  ┌──┴──┐                                  vi.Interpolate(vj,t)
  Y     N                                  ─┬─────────┬──
  │     │                                   │         │
coPlanarFront                           fList(>=3)? bList(>=3)?
coPlanarBack                            front.Add  back.Add
                                       (退化跳过)  (退化跳过)
```

---

## 5. CSG 核心算法：`Node.ClipPolygons / ClipTo / Invert / Build` (csg.js 蓝本)

`Node` 在 `CSG/Node.cs` 中（**该文件反汇编属辅助类型，详细字节级见 `../12-PipelineSubsystems/09-Utilities-Math-Infra.md`**），关键 API 签名与本文逻辑相关，照录于此：

```csharp
public class Node {
    public Plane?              splitPlane;   // 本节点的分割面（叶子可能 null）
    public Node                front;        // 前子树
    public Node                back;         // 后子树
    public List<CSGPolygon>    polygons;     // 落在 splitPlane 上的 coplanar 集
    public IEnumerable<CSGPolygon> AllPolygons { get; }     // 中序遍历摊平
    public void Invert();                    // 翻反整棵子树（用于布尔代数 De Morgan）
    public IEnumerable<CSGPolygon> ClipPolygons(IList<CSGPolygon> polygons);
    public void ClipTo(Node other);          // 把本树的 polygons 用 other 裁剪
    public void Build(IEnumerable<CSGPolygon> polygons);
    public Node Clone();
}
```

### 5.1 `Node.Build(polygons)` — 选 split 面、递归切割

Build 是从一堆 polygon 构造 BSP 的过程。`CSG/Node.cs:2110-2203` 反汇编显示 **迭代化** 实现（避免 C# 递归栈溢出）：

```
queue : Queue<(Node node, IEnumerable<CSGPolygon> polys)>
queue.Enqueue( (this, polygons) )
while queue.Count > 0:
    (node, polys) = queue.Dequeue()
    InternalBuild(node, polys, queue)   // 单层 build，把递归项重新塞回 queue
```

**单层 build 算法（标准 csg.js 蓝本）**（在 `polygons.Count > 0` 时）：
```
1. 若 node.splitPlane 还没确定:
       node.splitPlane = polys[0].Plane     // 选第一个 polygon 的平面作 split 面
2. 建空列表 frontList / backList
3. 对 polys 中每个 polygon p:
       node.splitPlane.SplitPolygon(p,
                                    node.polygons,  // coplanarFront → 累加到本节点
                                    node.polygons,  // coplanarBack  → 累加到本节点
                                    frontList,
                                    backList)
4. 若 frontList.Count > 0:
       if node.front == null: node.front = new Node()
       queue.Enqueue( (node.front, frontList) )
5. 若 backList .Count > 0:
       if node.back  == null: node.back  = new Node()
       queue.Enqueue( (node.back , backList ) )
```

> 「**第一个 polygon 当 split 平面**」是 csg.js 经典启发式 — 简单、O(N) 选面、对均匀几何效果可接受。代价：对**轴对齐长方体**这种几何会产生**深度不平衡 BSP**。HG 没对此优化（**与 csg.js 完全一致**）。

### 5.2 `Node.Invert()` — 翻反整棵子树

`CSG/Node.cs:1092-` 反汇编显示：
```
for each polygon p in node.polygons:
    node.polygons[i] = p.Flip()      // §3.2 Flip — 反绕序+反法线
node.splitPlane = node.splitPlane.flipped   // 调用 Plane 内部翻转
node.front, node.back = node.back, node.front   // 子树**交换**
node.front?.Invert()
node.back ?.Invert()
```
**几何意义**：原本"BSP 树定义的实体内部"，Invert 后定义"原实体的补集"。布尔代数 `A − B = A ∩ ¬B`、`A ∪ B = ¬(¬A ∩ ¬B)` 的 BSP 实现就靠这个翻反原语。

### 5.3 `Node.ClipPolygons(polygons)` — 用本树作"模具"过滤外部 polygons

CSG 一切布尔操作的核心：「把 `polygons` 用本节点定义的"实体"裁剪 — 落在实体内部的留下，外部的丢掉（或反之，取决于 Invert 状态）」。

伪码（反汇编蓝图蓝本）：
```
ClipPolygons(node, polygons):
    if node.splitPlane == null:
        return polygons                # 叶子节点：整段透传
    front = empty
    back  = empty
    for each p in polygons:
        node.splitPlane.SplitPolygon(p,
                                     front,   # coplanarFront → 当 Front 处理（朝向同向 = 实体外）
                                     back ,   # coplanarBack  → 当 Back  处理（朝向反向 = 实体内）
                                     front,
                                     back)
    if node.front != null: front = ClipPolygons(node.front, front)
    else:                  front = front                    # 叶子前侧：保留（外侧 = "保留"）
    if node.back  != null: back  = ClipPolygons(node.back , back )
    else:                  back  = empty                    # 叶子后侧：丢弃（内侧 = "切掉"）
    return front ∪ back
```

**关键不变量**：BSP 叶子节点没有 splitPlane → 前侧的递归基线是「保留」、后侧的递归基线是「丢弃」。这就是「BSP 定义实体」的语义：「在所有 splitPlane 的后方累计区域 = 实体内部」。

### 5.4 `Node.ClipTo(other)` — 用 `other` 这棵 BSP 把自己内部所有 polygon 都过滤一遍

```
ClipTo(self, other):
    self.polygons = other.ClipPolygons(self.polygons)
    self.front?.ClipTo(other)
    self.back ?.ClipTo(other)
```
深度优先把 self 整棵树的每个节点 `polygons` 字段都过滤一遍。

---

## 6. CSG 布尔运算公式：Union / Intersect / Subtract / Clear

**全部反汇编直证**（`CSG/BSP.cs:1339 / 3348 / 3463 / 3896`）：每个公式都是 `Node` 五个原语 (`Clone / ClipTo / Invert / Build / AllPolygons`) 的固定排列组合，**与 Evan Wallace csg.js 0.x 版逐 call 一致**。

### 6.1 `Union(this, bInput)`（`BSP.cs:1339-1770`）

反汇编 call 序列（直证）：
```
a = this.root                                      ; mov r14, [rbx+20h]
b = bInput.root.Clone()                            ; call Node::Clone
a.ClipTo(b)                                        ; call Node::ClipTo
b.ClipTo(a)                                        ; call Node::ClipTo
b.Invert()                                         ; call Node::Invert
b.ClipTo(a)                                        ; call Node::ClipTo
b.Invert()                                         ; call Node::Invert
a.Build(b.AllPolygons)                             ; call Node::get_AllPolygons → Node::Build
```

文字推导：`a ∪ b` 的 BSP 实现 — 先把 `a` 内部凡是被 `b` 实体覆盖的面切掉（`a.ClipTo(b)`），再把 `b` 内部凡是被 `a` 覆盖的面切掉（`b.ClipTo(a)`）；然后处理两实体内部**共面但反向**的退化情形（`b.Invert(); b.ClipTo(a); b.Invert()` 这三步等价 `coplanar Front+Back` 合并），最后把**清洗过的 `b` 全部 polygon**喂给 `a.Build`，结果 `a` 树就是 `a ∪ b`。

### 6.2 `Subtract(this, bInput)`（`BSP.cs:3348-3461`）

反汇编 call 序列（直证）：
```
a = this.root                                      ; mov rbx, [rsi+20h]
b = bInput.root.Clone()                            ; call Node::Clone
a.Invert()                                         ; call Node::Invert   ; a → ¬a
a.ClipTo(b)                                        ; call Node::ClipTo
b.ClipTo(a)                                        ; call Node::ClipTo
b.Invert()                                         ; call Node::Invert
b.ClipTo(a)                                        ; call Node::ClipTo
b.Invert()                                         ; call Node::Invert
a.Build(b.AllPolygons)                             ; call Node::get_AllPolygons → Node::Build
a.Invert()                                         ; call Node::Invert   ; a → a
```

**布尔代数推导**：`A − B = A ∩ ¬B = ¬(¬A ∪ B)`。两次 `a.Invert()` 夹住中间的 union-with-b 即得差集。**这正是 csg.js subtract 公式逐 call 等价**。

### 6.3 `Intersect(this, bInput)`（`BSP.cs:3463-`）

反汇编 call 序列（直证）：
```
a = this.root                                      ; mov rsi, [rbx+20h]
b = bInput.root.Clone()                            ; call Node::Clone
a.Invert()                                         ; call Node::Invert
b.ClipTo(a)                                        ; call Node::ClipTo
b.Invert()                                         ; call Node::Invert
a.ClipTo(b)                                        ; call Node::ClipTo
b.ClipTo(a)                                        ; call Node::ClipTo
a.Build(b.AllPolygons)                             ; call Node::get_AllPolygons → Node::Build
a.Invert()                                         ; call Node::Invert
```

**布尔代数推导**：`A ∩ B = ¬(¬A ∪ ¬B)`。逻辑展开 = 先 Invert a 与 b、做 union、最后再 Invert 整体。

### 6.4 Bounds 缓存与 InvokeChange

三种布尔运算最后都做：
1. 重算 `Bounds` — `Subtract` 与 `Union` 走 `MeasureBounds(this)` 重新遍历所有 polygon (`BSP.cs:491-792`)；`Intersect` 特殊：直接对 `this.Bounds` 与 `bInput.Bounds` 做 **6 次 Math.Max / Math.Min**（即 AABB 交集 — `BSP.cs:3589-3819`，反汇编里成对的 `Bounds::get_min / get_max` + `Math::Max / Math::Min`）。
2. 更新 `description` 数组 — `CreateDescription("union"/"subtract"/"intersect", existing, bInput.description ?? new object[]{transform/operand})`，用于运营 / 调试时回放操作历史（仅 `_createDescription == true` 时启用）。
3. `InvokeChange()` 触发 `OnChange` 事件 — 通知监听者（IV baker 重新拉新 polygons）。

### 6.5 `Clear()`（`BSP.cs:3896-`）

```
this.root = new Node()              ; 重置 root 为新空节点（splitPlane=null）
this.Bounds = default(Bounds?)      ; 清空 AABB
this.description = createDescription ? new object[0] : null
InvokeChange()
```

---

## 7. CSG mesh ↔ BSP 桥接：`BSP.fromMesh` 与 `BSP.Transform`

### 7.1 `BSP.fromMesh(Mesh m, int objID)` (`BSP.cs:1771-`)

把一个 `UnityEngine.Mesh` 转成 BSP。流程：
```
verts   = m.vertices    ;  store in BSP.vertices (static)
normals = m.normals     ;  store in BSP.normals  (static)
uv      = m.uv          ;  store in BSP.uv       (static)
polys   = empty List<CSGPolygon>
for each submesh s:
    tris = m.GetTriangles(s)
    for i in 0,3,6,…:
        a = new CSGVertex(verts[tris[i  ]], normals[tris[i  ]], uv[tris[i  ]], tris[i  ])
        b = new CSGVertex(verts[tris[i+1]], normals[tris[i+1]], uv[tris[i+1]], tris[i+1])
        c = new CSGVertex(verts[tris[i+2]], normals[tris[i+2]], uv[tris[i+2]], tris[i+2])
        polys.Add(new CSGPolygon(a, b, c, objID, materialID=s))
return new BSP(polys, mesh.bounds, description=null, createDescription=false)
```
（**实际反汇编以多线程 ThreadData 分段并行处理**：mesh 顶点区间分给 N 个 worker，每个 worker 自己持 `frontPolys / backPolys` 局部容器，最后归并；参数 `previous` 用作上次烘焙的递增对象 ID 起点，避免编辑器多次烘焙 ID 冲突。）

### 7.2 `BSP.Transform(Matrix4x4 transformation, Vector3[] verts, Vector3[] normals)` (`BSP.cs:795-1198`)

对 BSP 整棵树做线性变换。反汇编关键步骤：
```
1. 把 transformation 的 16 个 float 都 `il2cpp_vm_object_box` 进一个 object[16]，存进 description 数组——用于操作历史回放（"transform" + 矩阵）。
2. 对 root.AllPolygons 用 LINQ Select 套 transformVertex(v, mat, verts, normals)。
3. CreateDescription("transform", existing, mat-as-object[16])
4. 新 BSP 用 transformed polygons + 原 bounds.MultiplyByMatrix() + description + createDescription 重建。
5. InvokeChange()
```

`transformVertex`（`BSP.cs:1201-`）对单顶点：
```
P_new = mat.MultiplyPoint3x4(v.P)     ; UnityEngine.Matrix4x4::MultiplyPoint3x4
N_new = normals[v.id]                 ; 注意!不是矩阵乘法,直接查表
return new CSGVertex(P_new, N_new, v.UV, v.id)
```
> **关键 delta**：法线**不从矩阵乘出来**，而是从 `normals[]` 表里**按 `v.id` 直接取**——意思是「外部应当把已经经过 inverse-transpose 变换的 normals 预先填好」。这对应 BSP 在世界空间组合时的常见用法：外部一次性算好法线，BSP 只搬运。

`transformAllPolygons(root, matrix)`（`Node.cs:890-1090`，反汇编显示）递归对每个 Node：
```
for each polygon p in node.polygons:
    for each vertex v in p.Vertices:
        v.Position = matrix.MultiplyPoint3x4(BSP.vertices[v.id])
        v.Normal   = matrix.MultiplyPoint3x4(BSP.normals [v.id])   // 同 Point3x4，无 inverse-transpose
recursive front, back
```
即整棵树原地复用顶点对象、就地写回 — **零分配的快速 Transform**，但代价是 `Vertices` 不再独立（重启 Transform 必须重 fromMesh 拉新 verts 表）。

---

## 8. SDF 烘焙资源容器：`SDFBakeResources` 1:1 = VFX `VFXRuntimeResources`

### 8.1 字段对比表（**直证**）

| HG `SDF/SDFBakeResources.cs` | VFX `Runtime/Utilities/VFXRuntimeResources.cs` | 说明 |
|------------------------------|------------------------------------------------|------|
| `internal class SDFBakeResources : ScriptableObject` | `class VFXRuntimeResources : ScriptableObject` | 同基类 |
| `[SerializeField] ComputeShader m_SDFRayMapCS` | `[SerializeField] ComputeShader m_SDFRayMapCS` | **同名** |
| `[SerializeField] ComputeShader m_SDFNormalsCS` | `[SerializeField] ComputeShader m_SDFNormalsCS` | **同名** |
| `[SerializeField] Shader m_SDFRayMapShader` | `[SerializeField] Shader m_SDFRayMapShader` | **同名** |
| `internal ComputeShader sdfRayMapCS { get; set; }` | `internal ComputeShader sdfRayMapCS { get; set; }` | **同名同签名** |
| `internal ComputeShader sdfNormalsCS { get; set; }` | `internal ComputeShader sdfNormalsCS { get; set; }` | **同名同签名** |
| `internal Shader sdfRayMapShader { get; set; }` | `internal Shader sdfRayMapShader { get; set; }` | **同名同签名** |

→ **HG `SDFBakeResources` = 把 VFXGraph 的 `VFXRuntimeResources` SDF 资源块拷出来重命名了类**（VFX 类还包含其他 VFX 字段；HG 这个版本只挑 SDF 三字段）。

属性反汇编（`SDF/SDFBakeResources.cs:16-71`）只是裸的 offset get/set，无任何加工：
```
get sdfRayMapCS  : mov rax,[rcx+18h] ; ret
set sdfRayMapCS  : mov [rcx+18h],rdx ; jmp sub_180007A00  (write-barrier)
get sdfNormalsCS : mov rax,[rcx+20h] ; ret
set sdfNormalsCS : mov [rcx+20h],rdx ; jmp sub_180007A00
get sdfRayMapShader : mov rax,[rcx+28h] ; ret
set sdfRayMapShader : mov [rcx+28h],rdx ; jmp sub_180007A00
```
即 HG `SDFBakeResources` 是一只**纯字段容器** ScriptableObject。**算法 0 行 — 算法全部在它持有的那两个 ComputeShader 与那个 Shader 里**（HDRP VFXGraph 同源）。

### 8.2 VFX `VFXRuntimeResources` 在 HDRP 树里的资源 GUID

`Runtime/Utilities/RuntimeResources.asset:15-17` 给出资产引用（**官方 VFXGraph 包内**）：
```yaml
m_SDFRayMapCS:    {fileID: 7200000, guid: 691556691a6b4a941878dbc0303d3972, type: 3}  # GenSdfRayMap.compute
m_SDFNormalsCS:   {fileID: 7200000, guid: a31186dc26a29344db19c5e74c604fde, type: 3}  # 另一 compute (Normal/Surface 处理)
m_SDFRayMapShader:{fileID: 4800000, guid: 0b3b82b438158984dbccd69f0afe6ae6, type: 3}  # RayMapVoxelize.shader (栅格化体素化)
```
HG 复用同一 `.compute` 文件（`GenSdfRayMap.compute` 全文已在 § 9 拆解）；`m_SDFNormalsCS` 是配套的法线/表面处理 compute；`m_SDFRayMapShader` (`RayMapVoxelize.shader`) 是 RT 体素化用的栅格化 shader（每轴各一份 Material，对应 `MeshToSDFBaker.cs:420-447` 三材质数组）。

---

## 9. SDF 烘焙算法链：6-Rays Sign + JFA + Distance Transform (HDRP/VFXGraph 同源)

> **算法 1:1 同源 HDRP / VFXGraph**。下述全部步骤、kernel 名、numthreads、数学公式**逐字照抄** `com.unity.visualeffectgraph@3e2a77062d77/Shaders/SDFBaker/GenSdfRayMap.compute`。HG 复用同 `.compute`，**无 delta**（按 § 8 字段对比直证）。

### 9.1 完整 Kernel 清单（`GenSdfRayMap.compute:1-18`，**逐字照抄**）

```hlsl
#pragma kernel InBucketSum                  // 桶内 prefix scan
#pragma kernel BlockSums                    // 块和
#pragma kernel FinalSum                     // 最终前缀和回写
#pragma kernel ToTextureNormalized          // 4x4x4 写归一化体素
#pragma kernel CopyTextures                 // 4x4x4 ping-pong 拷贝
#pragma kernel JFA                          // 4x4x4 Jump Flooding Algorithm
#pragma kernel DistanceTransform            // 8x8x8 最终 SDF 写入
#pragma kernel CopyBuffers                  // 64 buffer 拷贝
#pragma kernel GenerateRayMapLocal          // 4x4x4 局部 6-Rays 计数
#pragma kernel SignPass6Rays                // 4x4x4 累积 6 向射线确定符号
#pragma kernel SignPassNeighbors            // 4x4x4 邻域投票优化符号
#pragma kernel ToBlockSumBuffer             // 块和聚合
#pragma kernel ClearTexturesAndBuffers      // 8x8x8 清零
#pragma kernel CopyToBuffer                 // 8x8x8 体素 → buffer
#pragma kernel GenerateTrianglesUV          // 64 三角形 → UV/Voxel 空间
#pragma kernel ConservativeRasterization    // 64 保守光栅
#pragma kernel ChooseDirectionTriangleOnly  // 64 三轴投影最大法线轴
#pragma kernel SurfaceClosing               // 4x4x4 表面闭合修复
#pragma kernel RayMapScanX/Y/Z              // 三轴方向的 prefix accumulation
```

### 9.2 流水线 ASCII 时序（HDRP/VFX 一致）

```
mesh 顶点/三角形 buffer
       │
       ▼
[GenerateTrianglesUV]   ── 把所有三角形顶点变换到 [0,size_max]^3 voxel 坐标
       │
       ▼
[ChooseDirectionTriangleOnly]  ── 每三角形选最强法线轴 (0=X / 1=Y / 2=Z)，写 coordFlip[]
       │
       ▼
[ConservativeRasterization]  ── 对所选轴做保守光栅（vertexCons 扩边一个半像素）
       │
       ▼
[ClearTexturesAndBuffers]   ── voxels / voxelsTmp / rayMap / signMap 全清零
       │
       ▼
{ RayMapVoxelize.shader 三轴 MRT 栅格化 → rayMap RWTexture3D<float4> 累积每三角形贡献 }
       │
       ▼
[GenerateRayMapLocal]   ── id = 2*id + offsetRayMap（八卦象限 ping-pong）
                          每 voxel 取 startId..endId 范围的三角形 ID 跑 TestIntersection6Rays
                          → 6 方向 (±x ±y ±z) 计算射线-三角相交分布
                          写 newValue / newValuePrevX/Y/Z 累加到 rayMap
       │
       ▼
[RayMapScanX/Y/Z]   ── 三轴 prefix scan：accum += rayMapTmp[idNext].axis
                       从 size-2 倒着扫到 0，写回 rayMap[idCurrent].axis
       │
       ▼
[SignPass6Rays]   ── signMap[id] = sum( rayMap[id].x + ... + (rayMap[id].x − rayMap[0,y,z].x) + ... )
                     即原点-到-当前 voxel 6 方向射线穿过三角形次数的代数和
                     → 内部点穿过奇数次（负数大），外部点穿过偶数次（接近 0）
       │
       ▼
[SignPassNeighbors] x numPasses  ── 邻域投票平滑符号（避免单点 SignFlip 错误）
                                    signValue = ∑ normFactor·accumSign + 6·signMapTmp[neighbor]
       │
       ▼
[SurfaceClosing]   ── threshold 比较，把符号翻转处与开边界补成闭合：
                      if (currentSignScore*(signMap[id ± axis] − threshold) < 0)
                          voxels[id_or_id+axis] = float4(coord+halfTexel, 1.0)
       │
       ▼
[JFA] x log2(size_max) passes   ── Jump Flooding Algorithm：
                                   offset 从 size_max/2 逐 ÷2 直到 1
                                   每 voxel 在 3x3x3 邻域取最近 seed coord（即"最近表面点"）
                                   bestCoord, bestDistance 写 voxelsTmp
                                   ping-pong CopyTextures
       │
       ▼
[DistanceTransform]   ── 对每 voxel:
                          seedCoord = voxels[id].xyz                       // 最近表面 seed
                          voxelCoord = (id + 0.5) / size_max
                          signD = signMap[id] > threshold ? −1 : 1         // 符号
                          ; 再用 seed 邻域三角形列表精算最近距离
                          dist = min(dist, ComputeDistancePointTri(voxelCoord, tri))
                          if (dist == 9999) dist = length(seed − voxelCoord)
                          distanceTexture[id] = signD * dist − sdfOffset   // 最终 SDF
       │
       ▼
[CopyToBuffer] / [ToTextureNormalized] → 输出最终 RWTexture3D<float> distanceTexture
```

### 9.3 关键数学（`GenSdfRayMap.compute` 直证，逐式照抄）

**(1) Voxel 空间映射**（`compute:88-94`）：
```
half_extents = 0.5 · (maxBoundsExtended − minBoundsExtended) / maxExtent
center       = 0.5 · (maxBoundsExtended + minBoundsExtended)
tri.UV       = (GetVertexObj − center) / maxExtent + half_extents
```

**(2) 保守光栅 vertex 偏移**（`compute:148-163`）：
```
for i in 0..3:
    plane[i] = cross(vertex[i].xyw, vertex[(i+2)%3].xyw)
    plane[i].z −= dot(hPixel, abs(plane[i].xy))
for i in 0..3:
    vertexCons[i].xyw = cross(plane[i], plane[(i+1)%3])
    vertexCons[i] /= vertexCons[i].w
```
（标准 NVIDIA Conservative Rasterization paper 同款）

**(3) JFA 距离场**（`compute:413-444`）：
```
for z,y,x in [−1,0,1]^3:
    sampleCoord = clamp(id + (x,y,z)*offset, 0, size−1)
    seedCoord   = voxels[sampleCoord].xyz
    dist        = length(seedCoord − (id + 0.5) / size_max)
    if (seedCoord ≠ 0 && dist < bestDistance):
        bestCoord    = seedCoord
        bestDistance = dist
voxelsTmp[id] = float4(bestCoord, bestDistance)
```
**复杂度 O(log N · N³)**，比朴素 brute force `O(N³ · M)` 优一大截，是离线 SDF 烘焙的金标准。

**(4) 6-Rays Sign**（`compute:593-602`）：
```
signMap[id] = (rayMap[id].x +
               rayMap[id].y +
               rayMap[id].z +
               (rayMap[id].x − rayMap[0,y,z].x) +
               (rayMap[id].y − rayMap[x,0,z].y) +
               (rayMap[id].z − rayMap[x,y,0].z))
```
即从 voxel 中心向 6 个轴向射出射线，分别累计与 mesh 三角形相交次数（带向量化方向符号）；最后做求和——**奇数次相交 → 内部**（与 Gauss / Stokes 定理给出的体素穿过性等价；HDRP/VFX 实现里把 6 条射线并到一组累加替代了昂贵的逐 voxel-逐三角形测试）。

**(5) DistanceTransform 最终公式**（`compute:670-695`）：
```
seedCoord  = voxels[id].xyz
voxelCoord = (id + 0.5) / size_max
signD      = signMap[id] > threshold ? −1 : 1
dist       = 9999
for i in [accumCounter[id3(idSeed)−1], accumCounter[id3(idSeed)]):
    tri  = trianglesUV[triangleIDs[i]]
    dist = min(dist, ComputeDistancePointTri(voxelCoord, tri))
if dist == 9999:
    dist = length(seedCoord − voxelCoord)        // fallback: 用 JFA 得的最近 seed 直接距离
distanceTexture[id] = signD · dist − sdfOffset
```
（`sdfOffset` 是用户偏置，可把 surface 等值面"挤出/挤入"一点，做软外壳）

### 9.4 与 HDRP 同源的对照

**HDRP / VFXGraph 同源点**（带文件:行）：
- 资源容器：`com.unity.visualeffectgraph@3e2a77062d77/Runtime/Utilities/VFXRuntimeResources.cs:9-62` — 字段同名同序
- 烘焙器使用 `sdfRayMapCS` 入口：`Runtime/Utilities/SDF/MeshToSDFBaker.cs:379-447` — Threading group 512、3 个 RT 视图、orthographic 三轴 worldToClip
- Kernel 序列：`Shaders/SDFBaker/GenSdfRayMap.compute:1-18`
- 算法公式：同上 `compute:88-695`

**HG delta**：**无**。`SDFBakeResources` 只是把 VFX `VFXRuntimeResources` 类里 SDF 相关那块**拆出来另起一个独立 ScriptableObject 类**；compute / shader 完全复用 VFXGraph 包内同一 `.compute` 与 `.shader`（按 GUID 推断，HG 可能 import 了同一资产或维护了同 GUID 的副本）。**调用方差异**（哪个 HG 系统在 baker 模式调它）应在 baker 模块文档中追踪，本文不涉。

---

## 10. 1:1 复刻蓝图（分步）

### 10.1 复刻 CSG/BSP 系统

**前置依赖**（在他处实现）：
- `BSP` 类、`Node` 类、`PolygonType` 枚举、`Extensions` 静态类（`Plane.SplitPolygon` / `Plane.Distance` / `Append<T>` / `Bounds.IncludePoint` / `Ray.Intersects(BSP)`）、`ThreadData` 工作项 — 见 [`./09-GI-IrradianceSH.md`](./09-GI-IrradianceSH.md) §10 与 [`../12-PipelineSubsystems/09-Utilities-Math-Infra.md`](../12-PipelineSubsystems/09-Utilities-Math-Infra.md)。

**步骤**：

① **实现 `CSGPlane` / `CSGVertex` / `CSGPolygon` / `ICsgProvider`** 完全按 § 3 签名与公式照搬：
   - `CSGPlane.fromPoints` = `Cross + Normalize + Dot` 三步
   - `CSGPlane.flip` = `normal*=−1; w=−w`
   - `CSGVertex.Flip` = 只反 Normal，UV/id/Position 不动
   - `CSGVertex.Interpolate` = 三组件分别 `Lerp(t)`（Position/Normal 用 `Vector3.Lerp`、UV 用 `Vector2.Lerp`），id 取 this.id
   - `CSGPolygon` 双构造、`CalculateVertexNormals`（强行写 Plane.normal）、`Flip`（`Vertices.Reverse().Select(Flip)` + 新建 polygon）、`Clone` 透传、`IsDegenerateSet` (`GroupBy Position).Count() < 3`)

② **实现 `Plane.SplitPolygon`**（§ 4 公式）：
   - EPSILON = 0.001f
   - 每顶点 Distance 分类 → 累加 PolygonType
   - 4 个分支 (COPLANAR/FRONT/BACK/SPANNING) 分别归桶
   - SPANNING 时按每边 `(i, i+1)` 检查 `ti|tj == SPANNING` 算交点 `t = (W − n·vi) / (n·(vj−vi))`，Interpolate 出 v_mid，共享给 fList/bList
   - 切出新 polygon 必须 `Count >= 3 && !IsDegenerateSet`
   - 所有 `IList.Add` 用 `Monitor.Enter(lockN)` 保护（多线程并行 splitter 时必需）

③ **实现 `Node`**（§ 5 蓝本）：
   - `Build` 用 `Queue<(Node, IEnumerable<CSGPolygon>)>` 迭代化展开 — 避免 C# 递归栈溢出
   - 每层 build 选 polys[0].Plane 作 splitPlane（**csg.js 原启发式，别优化别动**）
   - `Invert` 严格按"反 polygons + 反 splitPlane + 交换 front/back + 递归"
   - `ClipPolygons` 叶子前侧保留、叶子后侧丢弃；`ClipTo` 深度优先把 `polygons` 全过滤一遍

④ **实现 `BSP`**（§ 6 公式）：
   - `Union/Subtract/Intersect` 严格按反汇编 call 序列（§ 6.1 / 6.2 / 6.3）— **不许重排**，桶序换一下结果就错
   - `Bounds`：Union/Subtract 用 `MeasureBounds` 重扫；Intersect 用 6 次 Math.Max/Min 算 AABB 交
   - `description` 数组按需写入 `("union"/"subtract"/"intersect"/"transform", existing args, new args)`
   - `OnChange` 事件 + `InvokeChange()`

⑤ **实现 `BSP.fromMesh`**（§ 7.1）：
   - 把 `m.vertices / m.normals / m.uv` 存进 `BSP` 的 static 字段
   - 多线程 (ThreadData) 把 submesh 三角形区间分给 N 个 worker，每 worker 独立累积 polys
   - 最后 `new BSP(polys, m.bounds, null, false)` —— 构造函数会做 `root.Build(polys)`

⑥ **实现 `BSP.Transform`**（§ 7.2）：
   - 顶点位置走 `mat.MultiplyPoint3x4(verts[v.id])`
   - 法线**不走矩阵**，直接取 `normals[v.id]`（外部应预先 inverse-transpose 好）
   - `transformAllPolygons` 递归 in-place 写
   - 同步写新 description "transform" + 矩阵 16 float

### 10.2 复刻 SDF 烘焙资源容器

**步骤**：

① 创建 `SDFBakeResources : ScriptableObject` 类，**internal** 可见性，三个 `[SerializeField]` 字段（**字段名必须照抄** `m_SDFRayMapCS` / `m_SDFNormalsCS` / `m_SDFRayMapShader`，因为序列化字段名一旦改 = `.asset` 文件兼容性破坏 = 烘焙资产指不向）。
② 三个 internal property `sdfRayMapCS` / `sdfNormalsCS` / `sdfRayMapShader` 各只是直读写 backing field。**别加缓存别加 lazy load**（VFX 原版没有）。
③ 在 Project 根目录某处准备一个 `.asset`，引用：
   - `m_SDFRayMapCS`  → 同 GUID 的 `GenSdfRayMap.compute`（HDRP `com.unity.visualeffectgraph@*/Shaders/SDFBaker/GenSdfRayMap.compute`）
   - `m_SDFNormalsCS` → 同 GUID 的 normals/closing compute
   - `m_SDFRayMapShader` → `RayMapVoxelize.shader`
④ 由上层 baker 模块（不属本单元）持有这个资产引用，在烘焙时 `m_computeShader = bakeResources.sdfRayMapCS;` 后驱动 § 9 的 19 个 kernel 序列。
⑤ 不要在 `SDFBakeResources` 本身写任何算法 — 它只是个**字段袋**。

---

## 11. 关键常量 / 魔数

| 常量 | 值 | 出处 | 含义 |
|------|----|------|------|
| `Extensions.EPSILON` / `Extensions.Epsilon` | `0.001f` | `CSG/Extensions.cs:701-703` | 顶点-平面分类的厚度带宽 |
| `Extensions::SplitPolygon` 内 `g_18C471904` | `+0.001f` | `CSG/Extensions.cs:800` 反汇编 | EPSILON 浮点字段（FRONT 阈值） |
| `Extensions::SplitPolygon` 内 `g_18C4714A4` | `−0.001f` | `CSG/Extensions.cs:835` 反汇编 | −EPSILON 浮点字段（BACK 阈值） |
| `Extensions::SplitPolygon` 内 `g_18C471248` | `0.0f` | `CSG/Extensions.cs:881` 反汇编 | COPLANAR 同向判定阈值 (`poly.N · plane.N > 0?`) |
| 新 polygon 顶点数下限 | `3` | `CSG/Extensions.cs:1151` 反汇编 (`cmp dword ptr [rbx+18h],3`) | 切出片 < 3 顶点 → 跳过 |
| `IsDegenerateSet` 阈值 | `3` | `CSGPolygon.cs:538-540` 反汇编 (`cmp eax,3; setl al`) | 去重后独立位置数 < 3 → 退化 |
| `Node.Build` Queue 初始 capacity | `100` (`0x64`) | `Node.cs:2154` 反汇编 (`mov edx,64h`) | 初始队列容量（性能优化项，可调） |
| `CSGPolygon` 双 List capacity (fList/bList) | `10` (`0xA`) | `Extensions.cs:1015-1027` 反汇编 (`mov edx,0Ah`) | SPANNING 切割临时列表初始容量 |
| `BSP` static `polygons` List 初始 capacity | `100` (`0x64`) | `Node.cs:835` 反汇编 | `getAllPolygons` 累加 List 初始 |
| SDF compute `m_ThreadGroupSize` | `512` | `MeshToSDFBaker.cs:377`（HDRP 同源） | prefix scan kernel `groupthreads`（与 compute `#define groupthreads 512` 对齐） |
| SDF compute 4×4×4 numthreads | `[numthreads(4,4,4)]` | `GenSdfRayMap.compute:335,356,368,412,509,592,609` | 大多数 voxel kernel 的 thread group |
| SDF compute 8×8×8 numthreads | `[numthreads(8,8,8)]` | `GenSdfRayMap.compute:669,699,714` | DistanceTransform / Clear / CopyToBuffer |
| SDF JFA 邻域大小 | `3×3×3` `[unroll(3)]` ×3 | `GenSdfRayMap.compute:420-427` | Jump Flooding 每 voxel 27 邻域 |
| SDF JFA 上限距离 | `9999.0f` | `GenSdfRayMap.compute:418,683` | "未找到 seed" sentinel |
| SDF SurfaceClosing 阈值 | `0.1f` | `GenSdfRayMap.compute:390` | Sign 翻转判定窗口（`|score/threshold| < 0.1`） |

> **CSG 算法常量与 csg.js 一致 (EPSILON=0.001)**；SDF compute 常量与 HDRP VFXGraph 同 `.compute` 文件直接照抄。HG **没有** override 或裁剪这些数值。

---

## 12. 待确认 / 推断分级

1. **`CSGPlane` 是否被 BSP `splitPlane` 字段实际持有？** — 反汇编显示 `Node.splitPlane` 类型是 `Plane?` (UnityEngine.Plane)，但本单元提供了一个独立 `CSGPlane` 类。两者实际使用关系（`CSGPlane` 是否仅用于早期版本残留 / 编辑器导入 / `fromPoints` 临时变量？）需要看 BSP 内部完整调用图，**本文按反汇编显示的实际使用 = 几乎只在静态 `CSGPlane.fromPoints` 单例调用里出现**（标 "推断②：据反汇编调用图"）。
2. **`SDFBakeResources` 的下游调用方**——本单元只见 `internal` 容器；具体哪个 baker / VFXSubsystem 在何时实例化它并跑 kernel 链，**不在本单元 5 文件清单**，留给后续 baker 单元解决（标"待确认 — 由 baker 单元定"）。**核心算法** 已据 HDRP/VFXGraph 同源源在 § 9 1:1 给清。
3. **CSG 多线程 lock 数 = 4**（`Extensions.lock1..lock4` 静态 object 字段）。这对应同一时间最多 4 个并行 SplitPolygon worker 加锁；与 `ThreadData` worker 池容量上限的对应关系（reflection 锁分桶？还是固定 4 worker？）反汇编未直证，**推断③：据领域知识 = 经典 N-bucket lock-striping 优化，N=4 取经验值**。
