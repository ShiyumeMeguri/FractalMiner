# Blender 加载管线

插件 `RuriRipperImporter`（`…\BlenderProfile\RuriConfig\scripts\addons\`，AppData 下是指向它的链接，
改这边即改实机）。C# 侧在 `Ruri-RipperHook`，游戏特化住
`AssetRipperGameHook/UnityHypergryph/EndField/`。

## 架构铁律：跨界只说一种形状

**跨界永远是列式 blob，一次穿越；逐行对象永不过界。**
`RowTable`（cabmap 23 万行）、`ColumnTable`（本地化 13 万行）、`MeshRawBlob`、`ClipCurveBlob`
全是这个形状。

**过滤 / 归约必须发生在持有行的那一侧（C#）。** 实测教训：

- 面板每次重绘重算估算（内部对 6.4 万行跑正则选 LOD）＝ 268 ms／次重绘，鼠标一动就付。
  归约下沉到 C# 后，重绘零逐行计算
- 为了显示两个数字传 1.5 万个 dict（399 ms）⇒ 改成只传汇总的 5 个数字

**Python 侧不写二进制解析；游戏特化不进 `ruri_pybridge`。**

## 搜索与过滤：一套引擎，四个 tab

面板每个列表（VirtualAssetBundle / Scene / World / Character）都是同一个搜索框 + 同一个
Include/Exclude 多重规则编辑器，**匹配全部在 C# 跑，Python 侧零匹配代码**。

C# 侧（内核，不属于任何游戏）：

| 位置 | 作用 |
|---|---|
| `Core/Tables/ColumnTable.cs` | 列式表（UTF-8 blob + offsets），一切行的统一形状 |
| `Core/Tables/ColumnSearch.cs` | 向量化 quick search（每列折叠一次 + 并行 IndexOf） |
| `Core/Tables/RuleFilter.cs` | `FilterRule` + 十种 relation 的**唯一**求值器 |
| `Core/Tables/TableRegistry.cs` | 按 handle 持表；`OpenHostTable` 收宿主自己拼的列表 |

`CabTableSearch`（23 万行 cabmap）和任意 `ColumnTable` 共用 `RuleFilter`——relation 语义只声明
一处。**搜索不需要游戏 hook**，只有「把 VFS 容器投影成表」才是游戏特化
（`EndfieldTableBridge.Query`，留在 submodule 里）。

Python 侧 `filter_ui.py`：一个列表注册一个 `FilterSpec`（可过滤字段 + 状态位置 + 重跑回调），
其余（规则存储、popover、操作符）全共用。字段可以是**回调**——roster 的可过滤字段就是当前
投影表的真实列，Characters 和 NPCs 天然不同，读出来而不是列表写死。

**坑:** popover 面板必须 `bl_region_type = "HEADER"`。写 `"UI"` 就是侧边栏面板，没有
`bl_category` 会被 Blender 丢进默认的 "Misc" 页，表现为凭空多出一个侧边栏。

## 场景导入链路

```
SceneLandmarks        读 UILevelMapLoadConfig → 地标 id + 世界矩形 + isSingleLevel
SceneChunkSummary     只读 VFS 清单，不碰 chunk → 场景状态列表 + 文件数/字节数
DiscoverScenePlacements(vfsRoots, map, minX,minZ,maxX,maxZ, sceneStateIds, lod0Only)
    ├ 按世界矩形与格相交，选中锚定格的 chunk
    ├ 全量解 _Global_ 与 DynamicStreaming 块，再按选中格的世界矩形收边
    └ C# 内归约：滤非几何 → 每实例选最佳 LOD → 抽种子容器路径
       返回 (Total, NoTransform, LodFiltered, DistinctAssets, SeedPaths, Placements)
ResolveCabsForPaths → ResolveClosureCabNames    闭包 CAB 数 = 内存代价代理
ImportCabs → BridgeAssetDatabase → 摆放
```

**窗口是世界矩形，不是格坐标**——游戏两头说的都是世界坐标，无穷矩形即整图，不需要单独模式。

LOD 选择规则的**唯一实现**在 C# `SceneAssetPaths.SelectBestLod`（CLI 与 Blender 共用）：
`_lodN$` → N，`_colN_` → 1000，无后缀 → -1；按（四舍五入位置, 去变体后缀词干）分组取最优。
**不是「丢掉所有非 lod0」**——只有 `_lod2`/`_col1` 变体的实例会被整个删掉（踩过）。

## 内存代价

五次真导入（无头 Blender，取 OS 峰值工作集）拟合：

**峰值 ≈ 4 GB + 5.6 MB × 闭包 CAB 数**（误差约 ±3.6 GB，刻意偏高以便早报警）

外推整图 map02 ≈ 154 GB，与实际观测吻合。**32 GB 机器上限约 4500 个闭包 CAB。**
面板会按这个模型预估并与本机物理内存对比后报警。

⚠ **一个进程里别连跑两次大导入**——内存不释放会把 32 GB 机器压到剩 4 GB。

## 自测

```bash
blender.exe --background --python <addon>/Game/EndField/selftest_scene.py \
    [-- --import-scene <id>] [--import-landmark <levelId>]
```

**每一步操作后都用 mock layout 重绘全部 tab。** 纯 headless 跑操作符**盖不住 draw-only 崩溃**
（元组变长后漏改一处解包点，实锤翻过车）。mock 校验属性名（`bl_rna`）与 operator id 就够抓这类。

## CLI

与面板共用同一套窗口语义：

```bash
Ruri.RipperHook.CLI.exe --hook EndField_1.4.4 --load "<gameRoot>" --cab-map "<cabmap>" \
    --export "<dir>" --export-scene map01 --scene-landmark map01_lv007
# 裸矩形版（前导负号必须用 = 形式）
#   "--scene-window=<minX>,<minZ>,<maxX>,<maxZ>[,<sceneStateId>...]"
```

编译验证三重反证：**0 错误 + 产物 dll 时间戳刚更新 + dll 字节里搜到新符号名**（控制台干净不算数）。
