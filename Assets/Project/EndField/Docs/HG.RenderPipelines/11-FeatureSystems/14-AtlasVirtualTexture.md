# 14 · 纹理图集 / 虚拟纹理 / 纹理缓存 — 实现原理蓝图 (C14_AtlasVT)

> 这一单元负责 HG 渲染管线中所有"按需把若干纹理塞进一张大图 / 一段缓存"的资源分配器。涵盖三种经典矩形装箱（Buddy / Guillotine / MaxRects），一个用于地形的 GPU 反馈式虚拟纹理 (VT clipmap)，HDRP 同源的 `TextureCache` (2D / Cubemap LRU 驻留)，一个用于打点光源静态阴影/cookie 的金字塔级别 atlas，以及离屏纹理 IO 工具。原理据矩形装箱与虚拟纹理领域标准 + HDRP `TextureCache.cs` 同源 + 反编译调用图/常量 1:1 重建；HG 反编译只提供数据结构与常量。装箱算法部分参考 Jukka Jylänki 的 *A Thousand Ways to Pack the Bin* (RectangleBinPack 项目)；VT 部分对照 *Sparse Virtual Textures* (Mittring, SIGGRAPH 2008) / *Software Virtual Textures* (Barrett) 与 Unity HDRP 的 `Cookie/PlanarReflection` 缓存。

交叉引用：
- 渲染图资源池见 [`../03-RenderGraph/01-HGRenderGraph-System.md`](../03-RenderGraph/01-HGRenderGraph-System.md) §6。
- ASM (Adaptive Shadow Map) 的虚拟纹理分配器（不同用途，固定 16×16 网格 + LRU）见 [`./07-ShadowASM.md`](./07-ShadowASM.md) §"ASM 虚拟纹理分配器"。
- HDRP 血缘：HDRP 的 `com.unity.render-pipelines.high-definition@75de48326bcd/Runtime/RenderPipeline/Utilities/TextureCache.cs` 与 `TextureCache2D.cs` / `TextureCacheCubemap.cs` 与 HG 此处近似 1:1。

---

## 目录

1. [系统总览：六个分配器各自解什么问题](#1-系统总览六个分配器各自解什么问题)
2. [AtlasBuddy4 — 二叉伙伴 (Buddy) 系统](#2-atlasbuddy4--二叉伙伴-buddy-系统)
3. [AtlasGuillotine — 断头台切割](#3-atlasguillotine--断头台切割)
4. [AtlasMaxRect — 最大空矩形 (MaxRects)](#4-atlasmaxrect--最大空矩形-maxrects)
5. [HGPunctualLightStaticAtlasAllocator — 金字塔级别 atlas](#5-hgpunctuallightstaticatlasallocator--金字塔级别-atlas)
6. [VirtualTextureRenderer — 地形 GPU 反馈式虚拟纹理](#6-virtualtexturerenderer--地形-gpu-反馈式虚拟纹理)
7. [TextureCache / TextureCache2D / TextureCacheCubemap — LRU 驻留](#7-texturecache--texturecache2d--texturecachecubemap--lru-驻留)
8. [HGTextureUtilities — 离屏 IO 工具](#8-hgtextureutilities--离屏-io-工具)
9. [关键常量速查表](#9-关键常量速查表)
10. [1:1 复刻蓝图 — 分步重建路线](#10-11-复刻蓝图--分步重建路线)
11. [支撑证据 — 源文件清单](#11-支撑证据--源文件清单)

---

## 1. 系统总览：六个分配器各自解什么问题

```
┌────────────────────────────────────────────────────────────────────────────┐
│ 用例 → 谁负责                                                              │
├────────────────────────────────────────────────────────────────────────────┤
│ ASM 阴影瓦片 (2 的幂同尺寸) ────────────► AtlasBuddy4         (本单元)     │
│ Shadow Atlas / Cookie 任意尺寸 ─────────► AtlasGuillotine     (本单元)     │
│ Decal Atlas / 复杂多尺寸/高填充率 ──────► AtlasMaxRect        (本单元)     │
│ 静态点光 cookie / 阴影 (固定级别) ──────► HGPunctualLightStaticAtlasAllocator
│ 地形 splat / 法线 / 高度 (世界级) ──────► VirtualTextureRenderer (clipmap)│
│ Light Cookie / ReflectionProbe (运行时) ► TextureCache2D / Cubemap  (LRU) │
│ 离屏调试 dump / Cubemap → EXR ──────────► HGTextureUtilities             │
└────────────────────────────────────────────────────────────────────────────┘
```

为什么用三种装箱算法？——这是**精度/吞吐/碎片化**的三角权衡：

| 算法 | 复杂度 | 填充率 | 适用 |
|---|---|---|---|
| Buddy | O(log N) 分裂+合并 | 中（同尺寸最高，混尺寸碎片严重） | **所有元素是 2 的幂、同尺寸**——ASM 瓦片 |
| Guillotine | O(N) 树遍历 | 中高（约 80%） | 加多删少、动态阴影 atlas |
| MaxRects | O(N²) 启发式扫描 + free-rect 列表 | 高（≥ 90%，best-area 实测最优） | 一次大批量 pack、字体/图标/decal |

下面逐一讲。

---

## 2. AtlasBuddy4 — 二叉伙伴 (Buddy) 系统

### 2.1 它解决什么

把一张正方形 atlas 反复切成 2 的幂大小的小方块；常用于阴影瓦片（`HGASMVirtualTextureAllocator` 的兄弟，但这里允许动态分裂合并）。

> 文件 `AtlasBuddy4.cs`。构造签名：`AtlasBuddy4(int atlasResolution, int maxImageResolution)`。两个参数必须都是 2 的幂（`_IsValidEdge` 在反编译中：`test ebx,eax; sete al` ⇒ `n & (n-1) == 0`，行 `AtlasBuddy4.cs:480-484`）。Atlas 内部以 `atlasResolution / 2` 为最小分裂单元（构造里 `sar edi,1` 行 71），因此叫 "Buddy**4**"——每次分裂是把一个方块切成 **4 个等大子块**，而经典 1D buddy 是 2 个。

### 2.2 数据结构

```
m_resolution        : 边长 / 2（一个 page 的边长 = atlasRes / 2）
m_resOrder          : log2(m_resolution)                  ；用 De Bruijn 序列 O(1) 求
m_freeArea[]        : FreeArea[orderCount]
                      FreeArea = { LinkedList<int> freePageId; int statusMapOffset }
                      order=0 是最大 page (= 整张 atlas / 4 子块的层)
                      order 越大 page 越小（边长 /= 2 每升一级）
m_buddyStatusMap    : byte[ totalPages ]
                      每字节 = "这个 page 当前已分配几个子孙"
                      0   ⇒ 完全空闲
                      >0  ⇒ 不能合并，必须递归保留
                      1   ⇒ 用于叶节点：表示自己被占
```

`statusMapOffset` 是当前 order 的字节起点，每升一级 page 数 ×4。构造里这样填：
- 行 99-135：遍历 order = 0..orderCount-1，每级 `pageCount = m_resolution² >> (2*order)`（反汇编 `mov eax,r13d; sar eax,cl` 其中 cl = `2*(order+1)`），把整个 atlas 视为 `m_resolution²` 个最小单元，按 4 的幂下降；累加 `esi` 得 `statusMapOffset`。
- 行 137-174：在最大 order（最小 page）的 free list 里塞满所有可用 pageId（`x,y` 二维网格平铺，间距 = `m_resolution / 2`）。

### 2.3 核心算法（1:1）

**分配** `InsertRect(edge)` (`AtlasBuddy4.cs:324`)：

```
1. 若 edge==1: 报错 "Do not support square with edge 1" 直接返回 0 矩形
   （行 339, 378-379）
2. order_want = m_resOrder - log2(edge / 2)   等价于"我要 order 越大的 page 越小"
   反汇编：lea r9d,[rax-1] 其中 rax = _OrderOfEdge(edge)
3. _Allocate(out x, out y, order_want)：
   for ord = order_want; ord >= 0; --ord:                    // 自顶向上找
       if freeArea[ord].freePageId 非空:
           pageId = list.RemoveFirst()
           if ord < order_want:                                // 拿到的太大 → 递归分裂
               for k = ord+1 .. order_want:
                   _GetBuddyPageIdInTurn(out b1,b2,b3, pageId, k-1)
                   freeArea[k].freePageId.AddLast(b1, b2, b3)  // 三个兄弟入库
                   statusMap[parent] = 1                       // 父节点引用计数++
                   pageId = pageId                             // 自己继续向下拿
               statusMap[final_leaf] = 1
           else:
               statusMap[index] += 1
           x = pageId & (m_resolution-1)
           y = pageId >> log2(m_resolution)
           return true
4. 返回 (x*2, y*2, edge, edge)（行 367-377 处 `eax += eax`：所有坐标 ×2 是因为 page 边长 = atlasRes/2 而坐标存的是 page 单元数）
```

**Buddy 关系**：经典 quadtree buddy（4 个）。`_GetBuddyPageId(out b1, b2, b3, b0, order)`：
- `b1 = b0 ^ (1 << order)`        — 水平翻转兄弟
- `b2 = b0 ^ (m_resolution << order)` — 垂直翻转兄弟（×m_resolution 因为 pageId = y*resolution + x）
- `b3 = b1 ^ (m_resolution << order)` — 对角兄弟
（反汇编中：`shl edx,cl; lea ecx,[rdx+rax]`、`imul ecx,[rbx+10h]`，行 681-686。`_GetParentPageId`：低 `order+1` 位清零即得，行 632-684。）

**释放** `RemoveRect(in RectInt rect)` (`AtlasBuddy4.cs:410`)：

```
order = m_resOrder - log2(edge/2)
pageId = (y*m_resolution + x) / 2     // 反汇编 sar edx,1, 行 432
_Free(pageId, order):
   while true:
       statusMap[_GetStatusIndex(pageId, order)] -= 1
       if statusMap[...] != 0: break        // 还有兄弟在用，不能合并
       _GetBuddyPageId(b1, b2, b3, pageId, order)
       free_list[order].Remove(b1, b2, b3)  // 三兄弟全空 → 合并
       parent = _GetParentPageId(pageId, order)
       pageId = parent; --order             // 继续向上尝试
   free_list[order].AddLast(pageId)
```

合并到根的不变量：`statusMap == 0` ⇔ 该 page 与其全部子孙都未被占用。

> ⚠️ **Buddy 的本性**：所有元素必须是 2 的幂、必须正方形，且 atlasResolution ≥ maxImageResolution × 2。优势是 O(log N) 分配/释放、零碎片（合并完美），劣势是混尺寸时浪费严重——所以 HG 把它专门留给 ASM 瓦片场景。

---

## 3. AtlasGuillotine — 断头台切割

### 3.1 它解决什么

每次插入用一刀（水平或垂直）把当前空闲矩形切成 used + 一两个 leftover，递归下去。删除时检查兄弟是否也都空，能合并就合并。常见用途：阴影 atlas、可破坏 cookie atlas（增多删少）。

> 文件 `AtlasGuillotine.cs`。构造 `AtlasGuillotine(int maxSizeX, int maxSizeY)`，支持非正方形。整张 atlas 用一个 `List<TextureLayoutNode>` 平铺存储，节点用 `childA / childB` 索引模拟二叉树。

### 3.2 数据结构

```cs
private struct TextureLayoutNode {
    public int    childA;     // -1 = 无子 (叶)；正数 = m_nodes 索引
    public int    childB;     // -1 或索引
    public ushort xMin, yMin; // 此节点占用的矩形左下角
    public ushort xSize, ySize;
    public bool   used;       // 该叶是否已被分配（has-child 节点的 used 永远 false）
}
private const int INDEX_NONE = -1;
private readonly List<TextureLayoutNode> m_nodes;
```

构造后 `m_nodes[0] = {childA=-1, childB=-1, xMin=0, yMin=0, xSize=W, ySize=H, used=false}`（行 472-491）。

### 3.3 核心算法

**插入** `InsertRect(int width, int height)` → 调用 `_AddElement` → `_AddSurfaceInner(nodeIndex=0, w, h)` 递归：

```
_AddSurfaceInner(nodeIdx, w, h):
    node = m_nodes[nodeIdx]
    // (A) 该节点已被占用，或尺寸不够 → 失败
    if node.used: return -1
    if node.xSize < w or node.ySize < h: return -1
    if node.childA != -1 or node.childB != -1:    // 非叶 → 不能在此放，向下递归
        r = _AddSurfaceInner(node.childA, w, h)
        if r != -1: return r
        return _AddSurfaceInner(node.childB, w, h)
    // (B) 是空闲叶。完美贴合：直接 mark used
    if node.xSize == w and node.ySize == h:
        node.used = true; m_nodes[nodeIdx] = node
        return nodeIdx
    // (C) 选切割方向（这是断头台核心：哪条更接近正方形）
    leftoverX = node.xSize - w
    leftoverY = node.ySize - h
    if leftoverX <= leftoverY:                     // 横切（先沿 X 切窄条）
        childA = { xMin, yMin, w, node.ySize, used=false }   // 上：宽 w 高 H，留给子分配 (h 部分)
        childB = { xMin+w, yMin, node.xSize-w, node.ySize }  // 右：剩下的宽 (xSize-w)
    else:                                          // 竖切（先沿 Y 切矮条）
        childA = { xMin, yMin, node.xSize, h }               // 下：宽 X 高 h
        childB = { xMin, yMin+h, node.xSize, node.ySize-h }  // 上：剩余高度
    m_nodes.Add(childA); idxA = m_nodes.Count-1
    m_nodes.Add(childB); idxB = m_nodes.Count-1
    node.childA = idxA; node.childB = idxB; m_nodes[nodeIdx] = node
    // 继续在 childA 里放
    r = _AddSurfaceInner(idxA, w, h)
    if r != -1: return r
    return _AddSurfaceInner(idxB, w, h)
```

> 反汇编对照：行 1098-1297 完整重现了上面 (A)(B)(C)。两次切割方向选择在 `loc_18A6F8C71` 的 `cmp ecx,edx` 处：`leftoverX = node.xSize - w`, `leftoverY = node.ySize - h`，`if (leftoverX <= leftoverY) 横切 else 竖切`。两个 child 的写入紧接着 `_AddSurfaceInner` 的两次 List.Add（行 1182, 1239），最后递归调用自身两次（行 1310, 1320）。这是 *Jylänki §3.3 Guillotine SmallerLeftoverAxis (SLAS) split rule*。

**删除** `RemoveRect(in RectInt)` → `_RemoveElement(x, y, w, h)`：

```
1. 线性扫 m_nodes 找 (xMin,yMin,xSize,ySize) 全等的叶 (行 1431-1466)
2. node.used = false
3. parent = _FindParentNode(thisIdx)    // 反向线性查 (行 1525-1645)
4. 若 parent != -1 且 _IsNodeUsed(parent) == false：
       // 我和我的兄弟都空 → 合并：清掉两个 child，parent 回到叶状态
       _RemoveChildren(parent)          // 递归向上合并 (行 1707-1953)
```

`_IsNodeUsed(idx)` (`AtlasGuillotine.cs:976`) 是递归的：

```
bool _IsNodeUsed(idx):
    node = m_nodes[idx]
    if idx == -1: return false
    if _IsNodeUsed(node.childA): return true
    if _IsNodeUsed(node.childB): return true
    return node.used
```

> ⚠️ **代价**：`_AddSurfaceInner` 的递归 + `_RemoveElement` 的线性查找让最坏情况 O(N²)，但实际 N（atlas 中的活节点数）很少超过几十，可忽略。Guillotine 的取舍是 **吞吐高 + 算法简单 + 释放后能合并**，但碎片化比 MaxRects 严重——因为一次切割只产生 2 个 leftover 矩形，没有"覆盖全部最大空区"的视野。

---

## 4. AtlasMaxRect — 最大空矩形 (MaxRects)

### 4.1 它解决什么

字体/decal/imposter 这类**一次性大批量打包**，要把所有矩形都塞进去且填充率最高。它维护**所有最大空矩形**的列表 `m_freeRectangles`：每次插入选启发式最优的，然后用新放入矩形去**切割所有与之重叠的 free-rect**，最后剪枝重复。这是 *Jylänki 2010* MAXRECTS-BSSF/BLSF/BAF/BL/CP 五种启发式的完整实现。

> 文件 `AtlasMaxRect.cs`。构造 `AtlasMaxRect(int width, int height)`，初始 `m_freeRectangles = [ {0,0,W,H} ]`。

### 4.2 数据结构

```cs
public enum FreeRectChoiceHeuristic {
    RectBestShortSideFit  = 0,   // BSSF：剩余短边最小
    RectBestLongSideFit   = 1,   // BLSF：剩余长边最小
    RectBestAreaFit       = 2,   // BAF ：剩余面积最小  (默认/最优)
    RectBottomLeftRule    = 3,   // BL  ：左下角优先
    RectContactPointRule  = 4    // CP  ：周长接触最长
}

private readonly int m_binWidth, m_binHeight;
private readonly List<RectInt> m_newFreeRectangles;   // 本轮新产生
private readonly List<RectInt> m_freeRectangles;       // 累计最大空矩形
private readonly Dictionary<(int,int), RectInt> m_usedRectangles;  // 反向索引
private int m_usedRectSize;       // 已占面积（用于 fill ratio 统计）
private int m_maxFreeRectWidth;
private int m_maxFreeRectHeight;
```

### 4.3 五种启发式（评分函数）

对每个候选 free-rect `F`，先必须 `F.w ≥ w && F.h ≥ h`，然后：

```
leftoverHoriz = |F.w - w|
leftoverVert  = |F.h - h|

BSSF: score1 = min(leftoverHoriz, leftoverVert)
       score2 = max(leftoverHoriz, leftoverVert)

BLSF: score1 = max(...)      score2 = min(...)

BAF : score1 = F.w * F.h - w * h        // 剩余面积
       score2 = min(leftoverHoriz, leftoverVert)

BL  : score1 = F.y + h                  // 顶部 y 最小
       score2 = F.x

CP  : score1 = -ContactPointScoreNode(...)  // 周长接触最长 ⇒ 取负作为 score1
       score2 = 0
```

> 行 3237-3245 (`_FindPositionForNewNodeBestShortSideFit`)：`cmp r14d,eax; jge ...; mov esi,r14d; ... mov esi,eax` 把两个 leftover 取 min/max。行 3892-3905 (`_FindPositionForNewNodeBestAreaFit`)：`imul esi,[rbp-49h]; imul eax,r12d; sub esi,eax` 即 `area = F.w*F.h - w*h`，再 `cmovl eax,[rbp+4Fh]` 取 leftover 的 min 作为 tiebreaker。`InsertRect(w,h)`（无启发式参数版本，行 142-305）走自实现的 best-area + best-shortside 两阶 tiebreak（行 264-290 多个 `cmp [rbp-11h],r13d` 比较）；带启发式的 5 个公共方法各自调用 `_FindPositionForNewNodeBest*` + `_PlaceRect`。

### 4.4 关键三步 — 插入

```
RectInt InsertRectBestAreaFit(w, h):
    1. rect = _FindPositionForNewNodeBestAreaFit(w, h, out s1, out s2)
       遍历 m_freeRectangles，按 (BAF score1, BSSF score2) 双键找最小评分的位置
       若没有任何 F 能容纳 → 返回 zero rect
    2. _PlaceRect(rect):
         for each F in m_freeRectangles:
             if _SplitFreeNode(F, rect):     // 重叠则切割
                 // _SplitFreeNode 把 F 切成 0..4 个新 free-rect（见 4.5）放入 m_newFreeRectangles
                 m_freeRectangles[i] = m_freeRectangles.Last; m_freeRectangles.RemoveLast()
                 --i
         _PruneFreeList()                    // 剪枝：互相包含的丢弃
         m_usedRectangles.Add((rect.x, rect.y), rect)
         m_usedRectSize += w * h
```

### 4.5 _SplitFreeNode — MaxRects 的灵魂

> 反汇编位置 `AtlasMaxRect.cs:1347-1573`。

```
bool _SplitFreeNode(F, used):
    // 不相交 ⇒ 不切
    if used.x  >= F.x + F.w: return false
    if used.x + used.w <= F.x: return false
    if used.y  >= F.y + F.h: return false
    if used.y + used.h <= F.y: return false

    // 与 used 有交叠 ⇒ 至多生 4 个 新 free-rect（上下左右各一条）
    if used.x  > F.x and used.x  < F.x + F.w:
        _InsertNewFreeRectangle(  {F.x, F.y, used.x - F.x, F.h}    )   // 左条
    if used.x + used.w < F.x + F.w:
        _InsertNewFreeRectangle(  {used.x+used.w, F.y, F.x+F.w-used.x-used.w, F.h}  )  // 右条
    if used.y  > F.y and used.y  < F.y + F.h:
        _InsertNewFreeRectangle(  {F.x, F.y, F.w, used.y - F.y}    )   // 下条
    if used.y + used.h < F.y + F.h:
        _InsertNewFreeRectangle(  {F.x, used.y+used.h, F.w, F.y+F.h-used.y-used.h}  )   // 上条
    return true
```

四个条件块在反汇编中分别位于 `loc_18A6FC98D / loc_18A6FCA92 / loc_18A6FC918 / loc_18A6FCAE2`，每个块计算 `aabb` 边界差值，构造一个新 free-rect 写入 `m_newFreeRectangles`。

### 4.6 _PruneFreeList — 剪枝

> 反汇编 `AtlasMaxRect.cs:1736-1933`。

```
_PruneFreeList():
    // 1) 新 free-rect 内部互删：m_newFreeRectangles 中互相包含的丢弃
    for i in 0..m_newFreeRectangles.Count-1:
        for j in 0..m_freeRectangles.Count-1:
            if _IsContainedIn(m_newFreeRectangles[i], m_freeRectangles[j]):
                drop m_newFreeRectangles[i]; --i; break
            elif _IsContainedIn(m_freeRectangles[j], m_newFreeRectangles[i]):
                m_freeRectangles[j] = ...Last; RemoveLast(); --j

    // 2) m_freeRectangles ∪= m_newFreeRectangles
    m_freeRectangles.AddRange(m_newFreeRectangles)
    m_newFreeRectangles.Clear()

_IsContainedIn(a, b):
    return a.x >= b.x && a.y >= b.y
        && a.x+a.w <= b.x+b.w && a.y+a.h <= b.y+b.h
```

剪枝保证了 free-list 中**永远只剩"最大"**空矩形——这是 MaxRects 名字的来源，也是其填充率高的关键。

### 4.7 RemoveRect / FreeRects

```
RemoveRect(rect):
    _PlaceFreeRect(rect)              // 把这个 used 矩形当作新 free-rect 加入 free-list
                                       // 它会和邻接的 free-rect 通过 _PruneFreeList 合并
    m_usedRectangles.Remove((rect.x, rect.y))
    m_usedRectSize -= w * h
    _RecalculateMaxFreeRectWidthHeight()
```

`_PlaceFreeRect` 的算法与 `_PlaceRect` 对称：扫描 `m_freeRectangles` 寻找可合并的相邻矩形（共享一整条边）。

### 4.8 三算法对比

| | Buddy4 | Guillotine | MaxRects |
|---|---|---|---|
| 尺寸约束 | 2 的幂、正方形 | 任意 | 任意 |
| 维护结构 | linked-list per order | List<Node> 二叉树 | List\<RectInt\> free-rects |
| 插入复杂度 | O(log N) | O(N) 递归 | O(N²) (扫 free × 切 free) |
| 删除是否能合并 | 是（递归向上） | 是（仅 buddy） | 是（_PlaceFreeRect + Prune） |
| 填充率 | 等大场景近 100%；混尺寸差 | 80% 左右 | BAF 实测最高，> 95% |
| 推荐用例 | ASM 瓦片 | 动态阴影 atlas | 字体 / decal / imposter |

---

## 5. HGPunctualLightStaticAtlasAllocator — 金字塔级别 atlas

### 5.1 它解决什么

打点光源（point / spot）的 cookie 与小阴影。**每个级别 12 个固定 slot，最末级 16 个**（多 4 个）。Slot 之间按经典 mip-pyramid 角落布局排列：level 0 占 atlas 的 1/4 × 1/4 区域，level 1 在 level 0 的右下相邻位置占 1/8 × 1/8……每级是上一级面积的 1/4。这种"金字塔角"布局也是 HDRP `HDDynamicShadowAtlas` 用过的思路。

### 5.2 数据结构与几何

```cs
public int m_atlasResolution;
public int m_levelCount;
private bool[] m_slotOccupied;   // 长度 = 12 * levelCount + 4
```

构造 `HGPunctualLightStaticAtlasAllocator(int levelCount, int atlasResolution)`：

```
m_levelCount = levelCount
m_atlasResolution = atlasResolution
m_slotOccupied = new bool[ 12 * levelCount + 4 ]  // 行 31：lea edx,[rax*4+4] 其中 rax = 3*levelCount
                                                    // ⇒ 4*(3*levelCount) + 4 = 12*levelCount + 4
clear all to false
```

> 反汇编 `HGPunctualLightStaticAtlasAllocator.cs:17-69`。

**每级 slot 数与 slot 在阵列中的起始下标**：

```
slotsPerLevel(level) = (level == m_levelCount - 1) ? 16 : 12
slotStart(level)     = 12 * level
                       // 末级也是 12 * (m_levelCount-1)，但 +4 来自构造时多分配的尾巴
```

> 反汇编中 `TryAlloc` 行 95-100：`mov eax,[rdi+14h]; lea r8d,[rbx+rbx*2]; mov edx,10h; dec eax; cmp ebx,eax; lea ecx,[rdx-4]; cmovne edx,ecx; shl r8d,2` ⇒ `r8 = level*12`、`edx = (level==lastLevel) ? 16 : 12`、`imul r9d,ebx,sub_FFFFFFF4` (= `-12 * level`) → 扫描范围 `[level*12, level*12 + count)`。

**Slot → 矩形 (`GetRectFromLevelIndex`)**：

```
tileSize    = m_atlasResolution >> (level + 2)      // level 0 = atlasRes / 4
              // 反汇编 sar esi,cl 其中 cl = level+2
tileOffset  = (1.0 - 1.0 / 2^level) * m_atlasResolution
              // 反汇编：1.0 / 2^level → divss; subss xmm2,xmm1; mulss xmm2, atlasRes
              // → (1 - 0.5^level) * atlasRes
              // ⇒ level 0: offset=0；level 1: atlasRes/2；level 2: 3/4 * atlasRes ...
(col, row)  = (levelIndex % RECT_OFFSETS_per_level, levelIndex / RECT_OFFSETS_per_level)
              // 由静态表 RECT_OFFSETS[] 决定，12 slot 一组 (4×3 网格)
rect.xMin   = tileOffset + col * tileSize
rect.yMin   = tileOffset + row * tileSize
rect.width  = rect.height = tileSize
```

> 反汇编 `HGPunctualLightStaticAtlasAllocator.cs:418-487`：清楚地展示了 `cvttss2si r15d,xmm2` 即 `floor((1 - 1/2^level) * atlasRes)` 作为偏移，`imul edi,esi; imul ecx,esi; add edi,r15d; add ecx,r15d` 写入 rect 的 xMin/yMin。

### 5.3 算法

```
int TryAlloc(int level):
    if level < 0 or level >= m_levelCount: LogError; return -1
    count = (level == m_levelCount-1) ? 16 : 12
    start = 12 * level
    for i in start..start+count:
        if !m_slotOccupied[i]:
            m_slotOccupied[i] = true
            return i
    return -1   // 该级别满

bool Free(int slotIndex):
    if !m_slotOccupied[slotIndex]:
        LogWarning("already empty"); return false
    m_slotOccupied[slotIndex] = false; return true

int GetSlotLevelFromIndex(int slotIndex) = min(slotIndex / 12, m_levelCount-1)
       // 反汇编：mov eax, 0x2AAAAAAB; imul edi; sar edx, 1
       // 0x2AAAAAAB 是 sign-magic for /3 ⇒ (x*0x2AAAAAAB)>>33 == x/12
```

> ⚠️ 这个分配器与 `AtlasMaxRect` / `Buddy` 的根本差异：**布局是编译期固定的**，运行时只在标记数组上 O(N) 扫描。零碎片、零分裂、零合并、零分配——专门为打点光源每帧多次 alloc/free 的极致性能场景。代价是浪费空间（slot 数 < 12 时有空位但不能再细分）。

---

## 6. VirtualTextureRenderer — 地形 GPU 反馈式虚拟纹理

### 6.1 它解决什么

终末地的开放地形动辄几公里见方，splat + 法线 + 高度 + 颜色变化的全分辨率纹理可能数百 GB。VT 把世界分成虚拟"页"(page)，运行时只把屏幕上**实际用到的页**烤进一张物理缓存（"physical cache"），用一张"indirect"间接纹理把虚拟 UV 映射到物理 UV。这是 *Sparse Virtual Textures* (Mittring 2008) 标准模式。

> 文件 `VirtualTextureRenderer.cs`（6770 行，本节按调用图重建）。

### 6.2 关键常量（照抄反编译）

```cs
private const int   VT_CLIPMAP_BASE_WIDTH        = 8;
private const int   VT_CACHE_PAGE_RESOLUTION     = 256;      // 一页边长 = 256 像素
private const int   VT_CACHE_PAGE_BUFFER_SIDE_SIZE = 64;     // physical buffer slice 边长（页/64）
private const int   VT_CACHE_PAGE_BUFFER_SIZE    = 4096;     // = 64*64 页 / slice
private const int   VT_INDIRECT_TEX_BUFFER_COUNT = 3;        // indirect 三缓
private const int   VT_GPU_FEEDBACK_BUFFER_COUNT = 4;        // GPU feedback 4 帧 ring
private const float VT_CPU_FEEDBACK_RAYCAST_DIST = 1000f;    // CPU fallback raycast 距离
public const  int   VT_WORK_GROUP_COUNT          = 32;
public const  int   VT_COMPRESS_LOCAL_THREAD_COUNT = 16;     // 16×16 ComputeShader 线程组
```

> 行 `VirtualTextureRenderer.cs:20-36`。Compute kernel 名 `KMain`，shader keyword `_VT_COMPRESSION`、`_VT_TERRAIN_DECAL`（行 489, 487, 638）。

### 6.3 Page 寻址（Pack/Unpack NodeKey）

```cs
uint _PackNodeKey(level, row, col) =
    (level << 26) | (row << 13) | col      // 反编译：shl ebx,0Dh ×2

(level, row, col) = _UnpackNodeKey(key) where
    level = key >> 26
    row   = (key >> 13) & 0x1FFF           // 13-bit
    col   = key & 0x1FFF                   // 13-bit
```

> 行 317-359 / 362-410。13 bits ⇒ 每级最大 8192×8192 = 67 M pages，level 最多 64。

### 6.4 整体数据流

```
┌──────────── CPU (PipelineUpdate) ────────────┐
│  1. 读 m_gpuFeedbackRequests[frame & 3] 完成  │
│     → m_gpuFeedbackData[frame & 3] (uint[])   │
│     每个 uint = packed node key (level/row/col)│
│  2. 反扫 LRUCache 标记最近用到的页             │
│  3. 缺页加入 m_renderQueue                    │
│  4. 与 m_decalNodeLut / m_decalBlockMaskLut    │
│     合成 decal 影响列表                       │
└───────────────────┬───────────────────────────┘
                    ▼
┌──────────── GPU (Render) ────────────┐
│  (a) m_vtBakeCS.KMain (8×8×N pages)   │
│       从 splatIndexMap + splatControl │
│       + splatsDiffuseArray            │
│       + decalArrays                   │
│       → m_pageRt (临时 RT)            │
│  (b) [可选] m_vtCompressCS.KMain      │
│       16×16 线程组 BCn 压缩 →         │
│       m_physicalBaseTex (Texture2DArray)│
│  (c) _UpdateClipmapTexture           │
│       写 m_indirectTextures[          │
│         (m_frameCount++) % 3]         │
│       即三缓 indirect 写入            │
└───────────────────┬───────────────────┘
                    ▼
┌──── Shader 采样 (Terrain Lit) ───────┐
│  worldPos → terrainUV (×terrainToVirtual)
│  → 在 indirectTex 查到 (sliceIdx, mip)│
│  → 在 physicalBaseTex[sliceIdx] 采样  │
└──────────────────────────────────────┘
```

### 6.5 LRU + Streaming Loop

```
class LRUCache:    // 同名 type，构造 Reset(capacity)
    capacity = m_cachePageCountTotal  (= rowPerSlice * colPerSlice * sliceCount)
    每帧 PipelineUpdate:
        1. 把 GPU/CPU feedback 中所有命中的 pageId 从 lruList 中提到头部
        2. 若 m_renderQueue 中页要驻留：
              if 在 lruCache 中已驻留 → 仅 touch
              else if cache 未满 → 分配新 slot
              else → 淘汰 lruCache.tail (最久未用)，新页占其物理 slot
        3. 入选的页放入 bake dispatch 列表
```

### 6.6 GPU Feedback (KMain compute)

Terrain shader 在采样时把它"想用的页 key" 写入一个 `RWStructuredBuffer<uint>` (即 `currGPUFeedbackBuffer`)。这个 buffer 通过 4 帧 ring (`m_gpuFeedbackBuffers[frame & 3]`) 配 `AsyncGPUReadbackRequest` 异步回读到 `m_gpuFeedbackData[frame & 3]`。`m_gpuFeedbackBufferFilled[i]` 标记该 slot 是否已读完。`MarkCurrentGPUFeedbackBufferFilled(filled)` (行 6717) 由 RenderGraph 在该 pass 完成时调用。

> CPU fallback：若平台不支持 SSBO 写入 graphics shader (`HGTerrainUtils.SupportSSBOWriteInGraphicShader` 行 590)，则 `_RefreshCPUFeedbackParams` 启用 raycast 模式——从 `m_collider` (TerrainCollider) 在屏幕中心 1000m 内做 32 次 jitter raycast 命中点，把命中点的 terrainUV 转 page key 喂给同一 LRU。

### 6.7 抗锯齿/采样质量

```
m_feedbackJitterSeq : NativeArray<Vector2Short>   // 在 _GenerateJitterSequenceForSSBO/PhysX
m_cpuJitterOffsets  : NativeArray<int>            // CPU fallback 抖动
```

抖动序列让每帧在不同子像素上发起 feedback，避免漏页。行 5398-5683 在 SSBO 模式下生成（基于 Halton 或 Sobol，从反汇编 `cvtsi2ss` + 浮点位运算无法确认具体序列，**据领域知识标准重建**），PhysX 模式行 5510-5683。

### 6.8 与 ASM 虚拟纹理分配器对比

| | VirtualTextureRenderer (本节) | HGASMVirtualTextureAllocator |
|---|---|---|
| 用途 | 地形 splat/法线/decal 世界级缓存 | ASM 阴影瓦片二级缓存 |
| 分配粒度 | 256×256 page | 16×16 网格的 1/256 tile |
| 替换策略 | feedback-driven LRU + 异步流送 | LRU + 16×16 静态网格 |
| 关键常量 | VT_CACHE_PAGE_RESOLUTION=256 | GRID_COUNT_X/Y = 16 |

详见 [`./07-ShadowASM.md`](./07-ShadowASM.md)。

---

## 7. TextureCache / TextureCache2D / TextureCacheCubemap — LRU 驻留

### 7.1 它解决什么

把外部纹理（Cookie、ReflectionProbe、Cubemap 等）打包进**一张 `Texture2DArray` 或 `CubemapArray`**，按 LRU 替换。这是 HDRP 标准模式（`com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Utilities/TextureCache.cs`），HG 是 1:1 fork。

### 7.2 数据结构（与 HDRP 1:1）

```cs
internal abstract class TextureCache {
    private struct SliceEntry {
        public uint texId;         // 资源的 InstanceID（HG: GetInstanceID()）
        public uint countLRU;      // 该 slice 距上次使用的"帧龄"（0 = 本帧）
        public uint sliceEntryHash;// updateCount，用于检测纹理内容是否变化
    }
    protected string m_CacheName;
    protected int    m_NumMipLevels;
    protected int    m_SliceSize;     // 一个 cache 槽位等于几个 array slice
                                      // 2D 用 1；Cubemap 用 6 (无 cubemap array) 或 1 (有)
    private int      m_NumTextures;   // = m_NumSlots = numTextures / sliceSize
    private Dictionary<uint,int> m_LocatorInSliceDictionnary;   // texId → slotIdx
    private SliceEntry[] m_SliceArray;
    private int[]    m_SortedIdxArray;                          // LRU 排序，0=空闲，>0=按 countLRU
    private Texture[] m_autoContentArray;

    protected const int   k_FP16SizeInByte = 2;
    protected const int   k_NbChannel = 4;
    protected const float k_MipmapFactorApprox = 1.33f;          // 全 mip ≈ 1 + 1/4 + 1/16 + ... ≈ 4/3
    internal  const int   k_MaxSupported = 250;
}
```

> 反编译 `TextureCache.cs:8-47, 188-250`。

### 7.3 算法 (1:1 HDRP)

#### ReserveSlice(texture, out needUpdate) → slotIdx

```
needUpdate = false
texId = texture.GetInstanceID()
if dict.TryGetValue(texId, out slot):                 // 已驻留
    hash = texture.updateCount
    if SliceArray[slot].sliceEntryHash != hash:
        needUpdate = true                              // 内容已变，需要重传
    SliceArray[slot].countLRU = 0                      // 复位 LRU 年龄
    return slot

// 未驻留 → 找一个空 slot（countLRU 在 NewFrame 时按"空/在用"分桶排序）
for i in 0..m_NumTextures:
    slot = m_SortedIdxArray[i]
    if SliceArray[slot].countLRU == 0:               // ⚠️ HG 的 invariant：0 表示空闲槽
        if SliceArray[slot].texId != 0:               // 这是旧 texId，需要驱逐
            dict.Remove(SliceArray[slot].texId)
        dict.Add(texId, slot)
        SliceArray[slot].texId = texId
        needUpdate = true
        return slot
return -1     // 缓存已满，并且所有槽位都"今天还用过"——拒绝
```

> 反汇编 `TextureCache.cs:362-558`。注意 `cmp dword ptr [rax+4],0` (行 442, 504) 即 `if SliceEntry.countLRU == 0` 是核心条件——`countLRU=0` 在 `NewFrame` 中代表的是**"空闲"**，而在 `ReserveSlice` 命中时被赋为 0 表示**"本帧已用"**。这两个语义共用 0 是 HDRP 原版的设计取巧。

#### FetchSlice(cmd, texture, forceReinject)

```
slot = ReserveSlice(texture, out needUpdate)
if slot != -1 and (needUpdate or forceReinject):
    m_autoContentArray[0] = texture
    UpdateSlice(cmd, slot, autoContent, GetTextureHash(texture))
        → SetSliceHash + TransferToSlice (子类实现具体 Blit)
return slot
```

#### NewFrame() — LRU 年龄更新

```
// 行 809-1002
// 1) 重建 sortedIdxArray：先空槽 (countLRU==0) 再在用槽，分桶
freeIdx = 0
for i in 0..m_NumTextures:
    slot = m_SortedIdxArray[i]
    s_TempIntList.Add(slot)
    if SliceArray[slot].countLRU == 0: ++freeIdx        // 统计空槽数量
in_use_cursor = freeIdx
free_cursor   = 0
for slot in s_TempIntList:
    if SliceArray[slot].countLRU != 0:
        m_SortedIdxArray[in_use_cursor++] = slot         // 在用槽放到后段
    else:
        m_SortedIdxArray[free_cursor++]   = slot         // 空槽放到前段
// 2) 所有"在用"槽的 countLRU++（年龄+1）
for i in 0..m_NumTextures:
    if SliceArray[m_SortedIdxArray[i]].countLRU > 0 and
       SliceArray[...].countLRU < g_MaxFrameCount:
        SliceArray[...].countLRU++
```

ReserveSlice 的扫描就利用这个排序：空槽永远在前段，找到第一个就能拿到。被剔的就是 `countLRU` 最大那个的槽——经典 LRU。

#### RemoveEntryFromSlice(texture)

```
// 行 1005-1160
texId = texture.GetInstanceID()
if dict.ContainsKey(texId):
    slot = dict[texId]
    // 把它从 SortedIdxArray 中移除并把后面的左移
    for i in 0..m_NumTextures:
        if SortedIdxArray[i] == slot: idx = i; break
    for j in idx..m_NumTextures-1:
        SortedIdxArray[j] = SortedIdxArray[j+1]
    SortedIdxArray[last] = slot
    dict.Remove(texId)
    SliceArray[slot].texId = 0   // = g_InvalidTexID
    SliceArray[slot].countLRU = 0
```

### 7.4 TextureCache2D — Texture2DArray 后端

```cs
public bool AllocTextureArray(int numTextures, int width, int height,
                              GraphicsFormat format, bool isMipMapped):
    base.AllocTextureArray(numTextures)
    m_NumMipLevels = base.GetNumMips(width, height)
    desc = new RenderTextureDescriptor(width, height, format) {
        dimension       = TextureDimension.Tex2DArray  (= 5),
        volumeDepth     = numTextures,
        useMipMap       = isMipMapped,
        autoGenerateMips= false,                       // mip 由 TransferToSlice 自己生成
        msaaSamples     = 1
    }
    m_Cache = new RenderTexture(desc) { hideFlags=DontSave, wrapMode=Clamp }
    m_Cache.name = CoreUtils.GetTextureAutoName(width, height, format, ..., name=cacheName)
    ClearCache()    // 每 slice 每 mip 用纯黑覆盖
    m_Cache.Create()
```

> 反汇编 `TextureCache2D.cs:517-668`。`dimension=5` 即 `TextureDimension.Tex2DArray` (UnityEngine.Rendering 枚举)。

**TransferToSlice** (行 144-516) 调 `CommandBuffer.CopyTexture` 把源纹理的 0..NumMip 每级逐 mip 拷到目标 array 的 sliceIndex 切片。检测所有源纹理同尺寸（行 172）+ 必须有 mipmap（行 174）。

### 7.5 TextureCacheCubemap — 6 倍 slice 或真 CubemapArray

```cs
private const int k_NbFace = 6;
```

- 若平台 `supportsCubemapArrayTextures`：使用 `RenderTexture { dimension = Cube (=4), volumeDepth = numCubemaps }`，每 cubemap 一个 slice（`m_SliceSize=1`）。
- 否则：fallback 到 `m_CacheNoCubeArray : Texture2DArray`，每 cubemap 占 6 slice（`m_SliceSize=6`），同时为 panorama→cube 准备 staging RT。
- `m_CubeBlitMaterial`（HDRP shader `Hidden/HDRP/CubeToPano` 或类似）做面解包。

`GetApproxCacheSizeInByte(nbElement, resolution, sliceSize)` (行 1324-1373)：

```
bytes ≈ nbElement * (resolution * resolution * sliceSize * 6 * 8) * 1.33
                                                      ^   ^   ^
                                                 6面 8B/texel mipFactor
```

`GetMaxCacheSizeForWeightInByte(weight, resolution, sliceSize)` 反推 `nbElement = weight / per_element_size`，clamp 到 `[1, k_MaxSupported=250]`。

> 2D 公式：`bytes ≈ nbElement * resolution² * sliceSize * 8 * 1.33`（无 6 因子）。反汇编中常量 `g_18E5EC678 = 1.33f`（k_MipmapFactorApprox），常量 `0xFA = 250` 即 k_MaxSupported。

### 7.6 与 HDRP 的差异（HG delta）

| 项 | HDRP | HG |
|---|---|---|
| 类是否 `internal abstract` | ✓ | ✓ |
| `k_MaxSupported` | 250 | 250 |
| `k_MipmapFactorApprox` | 1.33 | 1.33 |
| 是否 IL2CPP 包装 | 否 | **是**（每方法 `IFix.WrappersManagerImpl::IsPatched` 路径，用于热修复） |
| `g_MaxFrameCount` 全局 | 通常 64 | 反汇编未取到具体值 (静态字段)，**待确认** |

> HG 在每个方法入口都插入了 IL2CPP IFix 桩（行 102-115 等），这是 HG 全管线统一的热修复机制，与算法本身无关。

---

## 8. HGTextureUtilities — 离屏 IO 工具

### 8.1 它解决什么

调试 dump 用——把任何 `Texture`（Cubemap / RenderTexture）落盘为 EXR。无 HDRP 同源。

> 文件 `HGTextureUtilities.cs`。两个静态方法。

### 8.2 WriteTextureFileToDisk(Texture target, string filePath)

```
if target is RenderTexture:
    asTex2D = CopyRenderTextureToTexture2D(target)
else if target is Cubemap:
    // 用 6 倍宽的 Texture2D 接收 (3 face × 2 row 的 strip layout)
    edge = target.width
    asTex2D = new Texture2D(6*edge, edge, R16G16B16A16_SFloat, 48 mipChain)
    cmd = new CommandBuffer { name="CopyCubemapToTexture2D" }
    for face in 0..5:
        srcId  = new RenderTargetIdentifier(target,  mip=0, sliceFace=face)
        dstId  = new RenderTargetIdentifier(asTex2D)
        cmd.CopyTexture(srcId, /*srcElement=*/face, /*srcMip=*/0,
                        /*srcX=*/0, /*srcY=*/0, edge, edge,
                        dstId, /*dstElement=*/0, /*dstMip=*/0,
                        /*dstX=*/face*edge, /*dstY=*/0)
    Graphics.ExecuteCommandBuffer(cmd)
bytes = ImageConversion.EncodeToEXR(asTex2D, EXRFlags.OutputAsFloat /* =2 */)
File.WriteAllBytes(filePath, bytes)
```

> 反汇编 `HGTextureUtilities.cs:7-235`。EXR flag = 2 = `OutputAsFloat`。Strip layout：`6 × edge` 宽，`edge` 高，面顺序按 Unity 的 CubemapFace 枚举 `(+X, -X, +Y, -Y, +Z, -Z)`。

### 8.3 CopyRenderTextureToTexture2D(RenderTexture source)

按 `source.dimension` 分支（行 277-465）：

- `dimension == 2` (Tex2D)：直接 `Texture2D.ReadPixels` 同分辨率读回。
- `dimension == 4` (Cubemap)：先 `GetTemporary(6*edge, edge, ARGBHalf, format)` 拿临时 RT，loop 6 面用 `CommandBuffer.CopyTexture` 平铺到 strip，然后 `Graphics.ExecuteCommandBuffer`，再 `ReadPixels` 到 Texture2D。
- 其他 dimension（如 Tex2DArray、3D）：抛 `ArgumentException`。

---

## 9. 关键常量速查表

| 类 | 常量 | 值 | 含义 |
|---|---|---|---|
| `AtlasBuddy4` | (无显式常量) | atlasRes/maxImageRes 必须 2 的幂 | `_IsValidEdge`: `n>0 && (n&(n-1))==0` |
| `AtlasGuillotine` | `INDEX_NONE` | -1 | child 索引哨兵 |
| `AtlasMaxRect` | `FreeRectChoiceHeuristic` | 0..4 | BSSF/BLSF/BAF/BL/CP |
| `HGPunctualLightStaticAtlasAllocator` | slots per level | 12 (末级 16) | 静态金字塔 |
| `HGPunctualLightStaticAtlasAllocator` | tileSize | `atlasRes >> (level+2)` | level 0 = atlasRes/4 |
| `HGPunctualLightStaticAtlasAllocator` | tileOffset | `(1 − 1/2^level) * atlasRes` | mip-pyramid 角偏移 |
| `VirtualTextureRenderer` | `VT_CLIPMAP_BASE_WIDTH` | 8 | clipmap 基础宽 |
| `VirtualTextureRenderer` | `VT_CACHE_PAGE_RESOLUTION` | 256 | 一页边长 |
| `VirtualTextureRenderer` | `VT_CACHE_PAGE_BUFFER_SIDE_SIZE` | 64 | physical 缓存的网格边 |
| `VirtualTextureRenderer` | `VT_CACHE_PAGE_BUFFER_SIZE` | 4096 | = 64² 一 slice 总页数 |
| `VirtualTextureRenderer` | `VT_INDIRECT_TEX_BUFFER_COUNT` | 3 | indirect 三缓 |
| `VirtualTextureRenderer` | `VT_GPU_FEEDBACK_BUFFER_COUNT` | 4 | feedback ring |
| `VirtualTextureRenderer` | `VT_CPU_FEEDBACK_RAYCAST_DIST` | 1000.0f | CPU fallback 距离 |
| `VirtualTextureRenderer` | `VT_WORK_GROUP_COUNT` | 32 | bake CS 线程组数 |
| `VirtualTextureRenderer` | `VT_COMPRESS_LOCAL_THREAD_COUNT` | 16 | compress CS 16×16 |
| `TextureCache` | `k_FP16SizeInByte` | 2 | half 4 通道 = 8B/texel |
| `TextureCache` | `k_NbChannel` | 4 | RGBA |
| `TextureCache` | `k_MipmapFactorApprox` | 1.33f | mip 链总大小 ≈ 4/3 |
| `TextureCache` | `k_MaxSupported` | 250 | 一缓存最大 slice 数 |
| `TextureCacheCubemap` | `k_NbFace` | 6 | cube 6 面 |

---

## 10. 1:1 复刻蓝图 — 分步重建路线

要让一支新团队从零拿出语义等价的 C14_AtlasVT：

### A) 三个装箱算法

1. **AtlasBuddy4**
   - 写 `_IsValidEdge`（n>0 && pow2-check）、`_OrderOfEdge`（用 De Bruijn 32-bit 序列 `0x07C4ACDD`，反汇编 `imul ecx, 0x07C4ACDD; shr ecx, 0x1B`）
   - `FreeArea[orderCount]`、`statusMap byte[]`
   - 实现 `_GetBuddyPageId / _GetParentPageId / _GetStatusIndex`（位运算照抄 §2.3）
   - `_Allocate`/`_Free` 按 §2.3 伪码递归
2. **AtlasGuillotine**
   - 节点压缩到 16 字节（`ushort xMin/yMin/xSize/ySize` + `bool used` + 两 `int` child）
   - `_AddSurfaceInner` 递归 + SLAS 切割（leftoverX ≤ leftoverY 时横切）
   - `_RemoveElement` 线性扫描 + `_FindParentNode` + `_IsNodeUsed` 递归 + `_RemoveChildren` 向上合并
3. **AtlasMaxRect**
   - 五种启发式各自的 `_FindPositionForNewNodeBest*`，score 公式照抄 §4.3
   - `_SplitFreeNode`：4 个方向各 1 个新 free-rect（§4.5）
   - `_PruneFreeList` + `_IsContainedIn`（§4.6）
   - `_PlaceFreeRect`（对称版本用于 Remove）

### B) HGPunctualLightStaticAtlasAllocator
- `bool[12*levelCount+4]`，`TryAlloc` 在 `[12*level, 12*level + (12 or 16)) ` 范围线性扫
- `GetRectFromLevelIndex`: tileSize=`atlasRes >> (level+2)`，tileOffset=`(1-1/2^level)*atlasRes`

### C) VirtualTextureRenderer
1. 加载 `TerrainResource` (splat / normal / control / heightmap / decal arrays)
2. 计算 `m_indirectMaxWidth/Height = next_pow2(terrainSize / VT_PAGE_RESOLUTION)`
3. 三缓 indirect `Texture2D[3]` (R32_UInt 或 R8G8B8A8)，初始化为 0
4. Physical Cache：`Texture2DArray` (BC1/BC3 if compression) 或 `RenderTexture` (uncompressed)，`m_cachePageCountTotal` 个 slot
5. 4 帧 GPU feedback buffer ring + AsyncGPUReadbackRequest
6. CPU feedback: 32 个 raycast 抖动序列
7. LRUCache 同 §7
8. `m_vtBakeCS` (kernel `KMain`)：dispatch 维度 `(VT_WORK_GROUP_COUNT, 1, pageCount)`
9. `m_vtCompressCS` (kernel `KMain`)：线程组 `(16, 16, 1)`，`numthreads(16,16,1)` BCn 编码
10. `_UpdateClipmapTexture`：每帧把 LRU 命中表写入 `m_indirectTextures[m_frameCount % 3]`，三缓避免 RT-fence

### D) TextureCache / 2D / Cubemap
- 完全照搬 HDRP 75de48326bcd 版本的 `TextureCache.cs / TextureCache2D.cs / TextureCacheCubemap.cs`
- HG 仅多了 `IFix.WrappersManagerImpl` 的热修桩，与算法无关——干净端口时可去掉

### E) HGTextureUtilities
- WriteTextureFileToDisk：Cubemap → `6*edge × edge` strip Texture2D → EXR
- CopyRenderTextureToTexture2D：dimension dispatch + ReadPixels

---

## 11. 支撑证据 — 源文件清单

| 文件 | 行数级 | 单元职责 | 关键证据行 |
|---|---|---|---|
| `AtlasBuddy4.cs` | 1167 | 二叉伙伴 4-way quad atlas，所有元素必须 2 的幂、正方形 | 构造 26-209；`_OrderOfEdge` De Bruijn 504-552；`_Allocate` 838-1026；`_Free` 1028-1163 |
| `AtlasGuillotine.cs` | 1685 | 断头台二叉切割 atlas，任意 W×H | 构造 435-503；`_AddSurfaceInner` SLAS 切割 1052-1351；`_RemoveChildren` 合并 1435-1681 |
| `HGPunctualLightStaticAtlasAllocator.cs` | ~440 | 12-slot per level 的金字塔角分配 | 构造 17-69；`TryAlloc` 72-164；`GetRectFromLevelIndex` 418-487 |
| `HGTextureUtilities.cs` | 500 | Cubemap/RT → EXR strip 落盘 | `WriteTextureFileToDisk` 7-235；`CopyRenderTextureToTexture2D` 238-498 |
| `TextureCache.cs` | 1259 | HDRP 同源 LRU 抽象基类（无后端） | `SliceEntry` 10-17；`ReserveSlice` 362-558；`NewFrame` 809-1002；`RemoveEntryFromSlice` 1005-1160 |
| `TextureCache2D.cs` | 928 | `Texture2DArray` 后端，每 slice = 1 槽 | `AllocTextureArray` 517-668；`TransferToSlice` 144-484；`GetApproxCacheSizeInByte` 809-857 |
| `TextureCacheCubemap.cs` | 1446 | `CubemapArray` 或 6-slice fallback | 构造 29-110；`AllocTextureArray` 554-946；`TransferToPanoCache` 1141-1322 |
| `VirtualTextureRenderer.cs` | 6770 | 地形 GPU 反馈式 VT，clipmap + LRU + 异步流送 | 常量 20-36；`_PackNodeKey/_UnpackNodeKey` 317-417；构造 419-1361；`PipelineUpdate` 1496；`GameUpdate` 2387；`Render` 2989；`_UpdateClipmapTexture` 4440；`_AllocatePhysicalCacheResources` 4964；feedback 资源 5685-6232 |
| **跨单元参照** | | | |
| `AtlasMaxRect.cs` (C07_ShadowASM) | 4032 | MaxRects 五启发式 + 切割 + 剪枝 | `InsertRect*` 142-606；`InsertRects` 608-771；`_PlaceRect` 1070-1203；`_SplitFreeNode` 1347-1573；`_PruneFreeList` 1736-1933；`_IsContainedIn` 2824；`_FindPositionForNewNode*` 3150-4028 |
| `HGASMVirtualTextureAllocator.cs` (C07_ShadowASM) | ~1500 | ASM 16×16 固定网格 + LRU | `GRID_COUNT_X/Y=16` 行 76-78；`ASMVTData.ctor` 19-67；`Initialize` 84+ |

---

## 留待确认

1. `TextureCache.g_MaxFrameCount`（LRU 上界）具体数值——反汇编是静态字段 `[HG.Rendering.Runtime.TextureCache_TypeInfo + 0xB8 + 0]`，运行时初始化，未取到 cctor。HDRP 原版是 `int.MaxValue`，HG **据 HDRP 同源重建**为相同值。
2. `VirtualTextureRenderer._GenerateJitterSequenceForSSBO/PhysX` 用的是 Halton(2,3) 还是 Sobol——反汇编是纯浮点序列计算，无显式调用名。**据 HDRP 同源重建**：HDRP 在 `HDCamera` 内用 Halton(2,3)，这里大概率同源。
3. `VT_TERRAIN_DECAL` / `_VT_COMPRESSION` 两 keyword 控制的 BCn 压缩算法（BC1 / BC3 / BC5 / BC7）——反汇编只见 `m_vtCompressCS.SetKeyword(_VT_COMPRESSION, true)`，未取到 keyword variant 与压缩算法的对应。需读对应 .compute 源（不在本单元清单内）。
