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

## 动画：ACL 泛型轨为主，战斗 clip 是「ACL + 肌肉」双编码

本作角色动画走 ACL 压缩，解出来是**完整的逐骨 transform 轨**（yvonne postmodel 实测：289 条
position + 289 条 rotation + 22 条 scale，全部绑到真骨）。UI/剧情类 clip **一条肌肉通道都没有**，
只带 Unity 的根运动浮点通道 `RootT.*` / `RootQ.*` / `MotionT.*` / `MotionQ.*`
（实测 17 条 float，其余是未解析的 `typetree_0x…` 占位）。

🔴 **但战斗 clip 是双编码**（2026-08-12，pelica `battle_air_atk_*` / `battle_attack_01` 四条实测）：
328 条 ACL 真骨轨（上身+辅助骨）**加** ~123 条肌肉浮点通道，其中肌肉编码**只覆盖腿部与 hips**
——ACL 轨里没有 Thigh/Calf/Foot/Toe0/Bip001，解算净增 22–23 条 rotation +（hips、motion 各）1–2 条
position，**与既有 ACL 轨零路径冲突**（solved/unsolved 逐路径 diff：replaced = 0）。
IK 目标通道（`LeftFootT/Q`、`LeftHandT/Q` 等 28 条）不属于肌肉也不属于根运动，解算后原样保留。

🔴 **判据：根运动通道 ≠ humanoid 肌肉编码；肌肉解算必须逐骨绑定，不是整条 clip 二选一。**
拿 RootT/RootQ 判 humanoid 会把每条动画都误判成肌肉 clip；反过来拿"有 transform 轨"整体跳过
解算，战斗 clip 的腿就全冻住。正确语义 = Unity 自己的语义：clip 里出现哪块肌肉的浮点通道，
就解算哪根骨（`AnyMuscleBound`），解算结果**拥有**它绑的路径（同 path 顶替）。

实锤（2026-08-12，`A_actor_yvonne_ui_overview_start_loop`）：误判后 humanoid→generic 通道会拿
**静止骨架**的 FK 算出一个"body transform"，**追加**一条 `Bip001` 的 position+rotation 曲线到
本来就有真数据的同一条 path 上——同 path 两条绑定，读侧按 path 建字典时后写的赢，整个身体的摆位
（`(0.4605, 0.8619, -1.1564)`，Y=0.86 即胯高）被 `(-0.0, -0.0601, -0.0437)` 顶掉。
表现为角色像是根骨在原点、全身绕原点旋转并陷进地下。

**验收判据**：`Bip001_L_Toe0` 的世界坐标 **z 必须 ≥ 0**。修复前 z = −0.8859，修复后 z = +0.0095。

### 肌肉解算：avatar 烙印 + 绑定时解算（2026-08-12 起）

骨架导入时把 Animator `m_Avatar` guid 指向的 **Avatar 文档树整棵**（Unity 自己的
`m_Avatar/m_Human/m_AxesArray/m_TOS` 字段，JSON）烙进 armature 自定义属性 `ruri_unity_avatar`
（pelica 实测 300 KB、415 条 TOS）；`ruri_unity_rig` 照旧烙路径→骨名+局部 rest。
clip 绑定时把浮点通道连同烙印交给 C# `RipperBlenderBridge.SolveHumanoidClip`（相当于 Animator
本身），解算出的骨骼曲线经 suffix-CRC 归一后按 path 顶替合并。**独立 clip 导入不再需要任何
avatar/角色 CAB co-seed**——闭包就是 clip 自己。等价性实测：与旧导出期解算基线逐位对比，
73 条曲线 grand max|delta| = 0.000e+00；Blender 端 2940 条 fcurve 与旧管线完全一致，6/6 腿骨动。
导出期转换（AR_HumanoidToGeneric hook）保留为**可选**，服务 Unity 工程导出场景：勾上 = 导出的
.anim 直接是通用动画；不勾 = 保留肌肉编码（可移植形态）。

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
