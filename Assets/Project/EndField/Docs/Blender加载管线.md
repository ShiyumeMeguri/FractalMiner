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

## 动画：ACL 泛型 clip，不是 humanoid 肌肉 clip

本作角色动画走 ACL 压缩，解出来是**完整的逐骨 transform 轨**（yvonne postmodel 实测：289 条
position + 289 条 rotation + 22 条 scale，全部绑到真骨），**一条肌肉通道都没有**。

但它**同时**带 Unity 的根运动浮点通道 `RootT.*` / `RootQ.*` / `MotionT.*` / `MotionQ.*`
（实测 17 条 float，其余是未解析的 `typetree_0x…` 占位）。

🔴 **判据：根运动通道 ≠ humanoid 肌肉编码。** 拿 RootT/RootQ 的存在去判"这是 humanoid clip"，
会把本作**每一条**动画都误判成肌肉 clip。真正的区分是**身体运动在浮点里还是在 transform 轨里**：
有 transform 轨 = 身体运动就在那儿，不需要肌肉求解器。

实锤（2026-08-12，`A_actor_yvonne_ui_overview_start_loop`）：误判后 humanoid→generic 通道会拿
**静止骨架**的 FK 算出一个"body transform"，**追加**一条 `Bip001` 的 position+rotation 曲线到
本来就有真数据的同一条 path 上——同 path 两条绑定，读侧按 path 建字典时后写的赢，整个身体的摆位
（`(0.4605, 0.8619, -1.1564)`，Y=0.86 即胯高）被 `(-0.0, -0.0601, -0.0437)` 顶掉。
表现为角色像是根骨在原点、全身绕原点旋转并陷进地下。

**验收判据**：`Bip001_L_Toe0` 的世界坐标 **z 必须 ≥ 0**。修复前 z = −0.8859，修复后 z = +0.0095。

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
