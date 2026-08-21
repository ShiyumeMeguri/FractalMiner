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

## 网格（Mesh）字段完整性核账（2026-08-22）

逐字段核对 Unity Mesh（ClassID 43）序列化布局 vs `mesh_decoder.py`/`MeshRawBlob.cs` 实际读取范围，
再用直连桥探针（不开 Blender GUI）拿 `chr_0025_ardelia_postmodel` 的 64 个网格（body/brow/
cloth×5/eyeshadow/face/fur/hair×2/hairshadow/iris/vfxpart，各到 LOD3）实测验证：`import_cabs`
拉整个 prefab 闭包，逐网格比对源 YAML 字段与 `decode_mesh_blob` 输出。

**结果：64/64 全部走 blob 快路径（C# 未跳过任何一个），顶点数/三角形数与源
`m_VertexData.m_VertexCount`／`sum(subMesh.indexCount)/3` 逐一相等，骨骼权重和 100% 落在
[0.98,1.02]。这个角色本身没有触发任何已知缺口。**已完整搬运：position/normal/tangent/color/
UV0-7/legacy `m_Skin`/现代 BlendWeight+BlendIndices（固定 4 槽）/子网格三角形列表/index buffer/
bindpose/boneNameHashes。

🔴 **两个结构性缺口（该角色未触发，但格式里真实存在，换个网格就可能踩）**：
1. `m_VariableBoneCountWeights`（Unity"无限骨骼权重"，单顶点超 4 个影响时用它而非固定 4 槽）
   ——C# `MeshRawBlob.cs` 和 python `mesh_decoder.py` 都不读这个字段，也没有诊断信息。Ardelia
   全部 64 网格该字段都是 `{"m_Data": null}`（真实存在但为空），所以这次没事；换一个真用无限
   骨骼权重的网格，超出 4 个的骨骼影响会被静默丢弃且不报错、不降级。
2. Unity `BlendShapeVertex` 结构每帧含 vertex+normal+**tangent** 三个 delta，`MeshRawBlob.cs`
   打包 shape 顶点时 stride 硬编码 28 字节（index 4 + vertex 12 + normal 12），tangent delta
   从未进桥；即使进了桥，`mesh_builder._apply_blendshapes` 也只写位置 delta——法线 delta
   （已经解到 Python 这一步，变量名 `_delta_n`）在应用到 shape key 前一行被丢弃。Ardelia 全部
   64 网格 `m_Shapes.channels` 都是 0（这游戏表情走 SkeletalMorph 骨骼 ΔTRS，不是 blendshape，
   见 [[endfield-skeletalmorph-face]]），所以这条链没被踩到，但格式支持是真的。

**验证过「像丢字节、实测是假警报」的一例**：body/face 网格的 UV2 槽声明维度 4、格式 SNorm8
（不是标准 2 分量纹理坐标），`mesh_decoder.py` 只取前 2 分量存成 UV2。逐顶点核对第 3、4 分量：
3156 个顶点全部恒为 0.0（std=0）——不是被丢弃的有效数据，是原始美术管线导出时留下的 padding。
**判据是逐分量 std，不能只看 dimension 数字大于 2 就下结论是丢数据。**

**切线/法线整字打包**（`EndfieldVertexFrame.cs`，`[Since("1.1.9")]`，1.4.4 仍生效）在 C# 读路径
解开，两条解码路径（YAML/blob）都只会看到解开后的标准 float3/float4——这一层不是缺口。Ardelia
body/face 网格的 TANGENT 声明维度就是 0（游戏本来没烤切线），落回 Blender `calc_tangents()`
是设计内的正确兜底，不是解码失败。

⚠ `chr_0025_ardelia_postmodel` 这个名字在 cabmap 里有两条不相关的行：
`.../postmodels/npc/chr_0025_ardelia_postmodel.prefab` 与
`.../postmodels/characters/chr_0025_ardelia_postmodel.prefab`，64 个网格 guid 零重叠（两套完全
独立的资产，同名不同物）。按名字搜索/自动化脚本处理这个角色时，两条都要枚举，不能假设唯一命中。

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

## 剧情动画从哪来

演出动画不在角色自己的动画目录下，而在演出自己的目录里（分镜 + 演员命名法全在
[剧情演出数据.md](剧情演出数据.md)）。数据来源是三个数据集：

| 数据集 | 代价 | 内容 |
|---|---|---|
| `endfield.story.units`（channel） | 纯 cabmap，~2s | 88 场演出 / 421 条对话时间线 |
| `endfield.story.clips`（channel/unit/actor） | 纯 cabmap | 某场戏的动画，或**某个角色**跨全部演出+对话+自有库的动画 |
| `endfield.story.actors`（channel） | 纯 cabmap | 963 个 actor 索引，带 `characterdata` 资产解出的角色 id |
| `endfield.story.timeline`（unit） | 只解那场戏的 playable/prefab CAB | **播放计划**：每条 timeline clip 的轨道/绑定/起止/clipIn/速度/混合/采样率/clip 全长 |

前三个只读 container 路径（列 4000 条剧情动画是表查询不是导入）；第四个用
`ClosureReader` 只加载这一场戏自己的 playable + prefab，读 Timeline 的 MonoBehaviour 字段。

**等价播放的换算**（秒 → 帧）：条带跨度 `duration × 场景fps`，消耗动作帧
`duration × timeScale × 采样率`，起点 `clipIn × 采样率`。采样率**取导入器盖在动作上的
`ruri_sample_rate` 戳**，不取资产的 `m_SampleRate`（后者与 ACL 解码率不一致）。
Blender 一条 NLA 轨不许重叠，所以游戏轨道内部交叉混合时自动分层 `<track>.2`。

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

### 多游戏会话：一次解码一游戏，多份 cabmap 并存

一个进程能同时开多个游戏的 cabmap，但**上游一次只解码一个游戏**——游戏 hook 在 C# 侧互斥
（`RuriHook.ApplyHooks`，同一批方法打不同 typetree 布局）。所以桥 `RipperBridge` 里：

- **`maps_by_game`**：游戏名 → 已加载的 `CabMapHandle`。CabMapHandle 是纯值对象，可持有多份，
  各游戏的行表同时驻留、互不覆盖（实测 EF 242222 行 + KK 48129 行并存于同一进程）。
- **`use_game(game)`** 切当前解码器：`_map` 指向该游戏 handle，并在解码器不同时把 hook 重新
  Initialize 成「该游戏的 game-hook ＋ 所有非游戏 AR_* 特性 hook」（一个游戏的解码器换掉另一个，
  与上游互斥语义一致）。`enumerate_table`/`search` 只需 `_map` 切换；`import`/`game_data` 走新解码器。

🔴 **判据：解码器真的切了 = `list_game_data()` 跟着换整套数据集 id、`hook_ids` 跟着换**，不是只换
Python 视图。实测切换：`hook_ids` 在 `(EndField_1.4.4,)` ↔ `(Koikatu_1.0,)`；数据集 id 在
EF `endfield.*`（models/npc.*/scene.* 8 个）↔ KK `koikatu.*`（anime.catalog/chara.*/face.* 8 个）。
会话态（ROWS／选择／文件夹树／动画交接）按 `cabmap_state.GameSession` 按游戏隔离，进程级唯一共享
的只有 CLR 桥本身。

### 跨游戏重定向：泛型 clip 走骨名对照表

肌肉 clip 自带可移植性（肌肉值是 avatar 相对的），**泛型 clip 没有**——曲线是源骨轴向下的
局部旋转，换一副骨架就是废数据。所以跨游戏套动画走真重定向（世界旋转经两边 rest 换算），
数学交给 AnimationRetarget 插件，本仓只提供它无法知道的两件事：

- **骨架烙 `ruri_source_game`**（上游 GameType 成员名，如 `EndField`/`Koikatu`），
  由面板一次性解析 `Game.active_module` 后随导入选项 `source_game` 下发；
- **对照表**：AnimationRetarget 预设格式，文件名 `<GameA>To<GameB>.json`，**一份双向**
  （反向读时整表 source/dest 对调），两份互为反向 = 双真源会漂移，禁止。

Endfield 侧骨名取自 pelica avatar 的 `m_HumanBoneIndex`（游戏自己声明，非按名猜）：
`Hips=Bip001`（**不是** `Bip001_Pelvis`，后者不是人形骨，不映射）、
`Spine/Chest/UpperChest=Bip001_Spine/Spine1/Spine2`、四肢 = 3ds Max Biped
`Clavicle/UpperArm/Forearm/Hand`、`Thigh/Calf/Foot/Toe0`；手指 `Finger0..4` = 拇指→小指，
`FingerN/N1/N2` = 近/中/远节，`FingerNNub` 是末端不动。
Koikatu 侧 `cf_j_*`，**男女核心骨名完全一致**（p_cf_body_00 / p_cm_body_00 实测差异只有
生殖器与剪影物体）；`cf_j_leg01` 是膝、`cf_j_leg03` 是扭曲骨不映射，
`cf_j_waist01/02` 是腿侧中间骨、EF 无对应，同样不映射。已落表 53 条
（`KoikatuToEndField.json`：root+22 人形槽+30 指节），hips/root 开 `loc` + `scale_mode AUTO`
（髋高比缩放），其余纯旋转；饰品/裙/胸/物理骨一律不进表。

#### 直导链路：不导源角色，按 CRC 覆盖打分选源 avatar

源游戏的 clip 直接套到「已在场的另一游戏骨架」上，**全程不导源角色**。数据流：

```
clip 绑定 CRC 集   ← clip.transform_channel_lists() 每条 channel.path 取 entry_crc
选源 avatar        ← 扫源游戏 cabmap 全部 Avatar 类 CAB（按闭包依赖数升序，最便宜先试），
                     逐个导出比对其 m_TOS 覆盖了几条 clip 绑定 CRC，取覆盖最高者
                     （100% 即早停；(game, clipCab) 缓存，同包第二条 clip 跳过整轮扫描）
临时源骨架         ← build_armature_from_avatar 从选中 avatar 的 m_AvatarSkeleton 建骨架
烘 clip → 重定向    ← clip 烘到临时源骨架，再经 <src>To<dst> 骨名表 retarget 到目标骨架
回收               ← 删临时源骨架＋中间烘焙动作，只留目标骨架上的产物（无源游戏残骨）
```

🔴 **按名字猜源 avatar 会错，必须按 CRC 覆盖打分**。实测 `L_SF_IN_Loop`（343 条绑定 CRC）：
`cf_body_00Avatar`（女性基体，m_AvatarSkeleton 579 骨、依赖数 0＝最便宜先试）只覆盖 **326/343，
缺 17 条**——女性基体没有的那些骨（男性体／剪影专属，与上文 p_cf/p_cm 差异对应）；
`cf_panst_spats02Avatar`（服装 avatar，内嵌 560 骨全身骨架、依赖数 1）覆盖 **343/343**。
所以打分跳过更便宜但只 95% 的女体、选 100% 的服装 avatar。**KK 服装 avatar 内嵌全身骨架，
多份常并列 100%**（合法：产物一致，`_rank_key` 取依赖最少＋骨最全＋名字序）。

🔴 **avatar 骨架真源 = `m_AvatarSkeleton`（＋`m_AvatarSkeletonPose` 摆 rest），不是
`m_Human.m_Skeleton`**：后者只是归一到近原点的 **24 骨人形子集**，且**泛型 avatar 里为空**。
实测：EF pelica（人形 avatar）m_AvatarSkeleton=415／m_Human.m_Skeleton=24／m_TOS=415；
KK 全部 avatar 都是泛型，m_Human.m_Skeleton 一律 **0**（cf_body_00=579 骨、cf_panst_spats02=560 骨、
手 24 骨，全靠 m_AvatarSkeleton 才建得出骨架）。读 m_Human.m_Skeleton 会让 KK 骨架空、EF 只剩 24 骨
——这就是 `skeleton_nodes` 改取 m_AvatarSkeleton 全骨架的原因。

🔴 **缺表 = AI 提示词工作流**：`<src>To<dst>.json` 不存在时，直导**在建好临时源骨架、烘完 clip
之后**才报错（此刻两副骨架都在），把两副骨架结构各导一份 JSON 到
`presets/AnimationRetarget/SkeletonConfig/`（源＝`<avatar名>_xg_source.json`、目标＝角色名），
报错文本本身就是可粘贴提示词：目标表路径＋两份骨架 JSON 路径＋「只映射共有人形体骨、饰品骨不进表、
一份双向」的写表规则。目标表路径被命名但故意不存在（那正是要人／AI 去创建的文件）。补好表重跑即成。

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

**查数据用只读 cabmap 的查询模式，不要为了看一眼就 --load/--export**（几秒 vs 几分钟，
后者还容易把闭包炸开）：

```bash
# 路径搜索：浏览器那套 field|relation|value 规则，命中什么打什么
Ruri.RipperHook.CLI.exe --hook EndField_1.4.4 --cab-map "<cabmap>" \
    --cab-query "gameplay/cutscene/" --cab-rule extension|is|fbx --query-limit 0
# 数据集：面板读什么，这里就读什么
Ruri.RipperHook.CLI.exe --hook EndField_1.4.4 --data-list
Ruri.RipperHook.CLI.exe --hook EndField_1.4.4 --cab-map "<cabmap>" \
    --data endfield.story.units --data-arg channel=cutscene --query-limit 0
```

编译验证三重反证：**0 错误 + 产物 dll 时间戳刚更新 + dll 字节里搜到新符号名**（控制台干净不算数）。
