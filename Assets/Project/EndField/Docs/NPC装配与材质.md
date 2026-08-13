# NPC 装配与材质

行人 NPC 没有成品 prefab：游戏在运行时按「部件清单 + 材质码」现拼。这份记录材质那条链，
因为它是导入侧唯一说不清、只能靠源码定谳的部分。

## 三张数据表

| 层 | 位置 | 给什么 |
|---|---|---|
| 模板清单 | `Data/Json/NPC/PrefabInfo/<templateId>.json`（真 JSON，非 MemoryPack） | 部件名、渲染器名、**材质码** |
| 共享装配表 | `…/gameplay/npc/avatarmesh/<族>/data_npc_avatarmesh_<leaf>.asset` | 每部件每子网格的**材质路径哈希** |
| 骨架模板 | `…/gameplay/npc/avatartemplet/<族>/data_npc_avatartemplet_<leaf>.asset` | 共享骨架 |

骨架模板那条要注意：1.4.4 的 `data_npc_avatartemplet_*` MonoBehaviour **没有 `sizeAvatar` 字段**
（只有 `avatarTempletTag / bonePaths / bonePathsStr / faceBonePath / collider / boundingBoxType`），
**骨架是同一个 bundle 里那个 `Avatar` 资产**（`SK_npc_major_deathgirl_01Avatar`、
`SK_actor_girlnpc_01Avatar`）。按 `sizeAvatar` 找会一无所获，然后整条装配静默走空。
实测 deathgirl：338 根骨的站立世界 rest + 338 条路径 + 338 个叶名。

`avatarMeshName` / `avatarTempletName` 是**运行时寻址键**（`NPC/AvatarMesh/Pedestrain/girl`），
**不是容器路径**：容器里叫 `data_npc_avatarmesh_<最后一段>.asset`。两者靠这条命名换算相接。

装配表是**整族共享的**：全部 girl 行人共用同一份 `data_npc_avatarmesh_girl`（实测 119 个 slot，
覆盖该族所有部件）。这就是「NPC 都是通用的东西」的真实含义。

## NPC 的名字：三张表，覆盖 467/2063

模型模板有 2063 个，**游戏自己只给其中 467 个起了名**。名字按「说得多具体」分三处：

| 来源 | 键 | 名字怎么取 | 命中 |
|---|---|---|---|
| `NpcTemplateGroupTable` | `templateId` | `name` 是**文本键**（`npcName_laotuoshou1`）→ `TextTable.id` → `I18nTextTable_<LANG>` | 461 |
| `NpcGroupTable` | **`<templateId>_gNN`** | `name.id` 直接是 i18n id（`I18nText = {id:Int64, text:String}`） | +6 |
| `NpcTable` | `npcId`（经 `NpcInfoTable` 的 npcId↔templateId 回到模板） | 同上 | +0 |

🔴 **剩下 1596 个是群众衣柜，游戏里就没有名字**（判据：`npc_boy_efengineer_a_01` 全 693 张表里
只有 `NpcGroupTable` 提到过它，那行的 `name.id = 0`、`name.text` 为空；22,210 个文本键里
`npcName_*` 只有 536 个，没有一个提到这些模板）。它们是 `_a_01`…`_a_99` 这种换装编号。
游戏有 `npcName_anonUnion039 = 工团成员` 这类通用名，但**是逐 npc 实例挂上去的**，不挂在模板上。

`I18nText` 结构自带 `text` 字段，但表里**从来不填**（940 行 NpcGroupTable 全空），
名字一律走 id → `I18nTextTable_<LANG>`。

## 🔴 部件名是 slot id，不是资产名（网格链）

`partNameIdList` 的元素是**装配表里的 slot 名**。行人那族看着像资产名纯属巧合，
「主要 NPC」那族根本不是：

| 模板 | 部件（slot） | 实际网格 |
|---|---|---|
| `npc_spl_deathgirl_01`（芬诺菈） | `npc_8001_deathgirl_postmodel` | `S_npc_major_deathgirl_body_01_lod0` 等 9 个 |
| `npc_spl_mon3ter_01`（M3） | `npc_1004_mon3ter_postmodel` | `S_npc_major_mon3ter_*_lod0` 等 10 个 |
| `npc_chr_0003_endminf` | `chr_0003_endminf_postmodel` | `S_actor_endminf_*_lod0` 等 12 个 |
| `npc_girl_unionscholar_a_04` | `P_npc_girl_body_unionscholar_a_02` | `S_npc_girl_body_unionscholar_**a_01**_lod0` |

最后一行是判据：**行人也不能按名字猜**——slot `_a_02` 穿的是 `_a_01` 的网格。

**网格的位置由 slot 自己给**：`SubMeshInfo.meshPathHash`（十进制 long，与
`materialPathHashes` 同一套哈希空间）→ `StringPathHash LUT` → 容器路径 → `ResolveCabsForPaths`。
必须走它:主要 NPC 的 brow/eyeshadow/hairshadow/iris 和一切 LOD1-3 网格**在 cabmap 里没有自己的行**
（是共享 fbx 的子资产 / `generated/` 下的烘焙网格），按名字查一个都找不到。

每个 slot 按 `partSubMeshsLOD0..3` 分级，且**分级不等长**：deathgirl 的 LOD0/1 是 9 个网格、
LOD2/3 只有 7 个（去掉 eyeshadow 与 hairshadow）。某级没有就退到最近的一级。

导入侧：`endfield.npc.meshes`（part / lod / mesh / path）。

## 材质链（源码定谳）

`Beyond.NPC.Avatar.NPCAvatarCreatorUtils`：

- `_LoadPrimaryMaterials(loader, long[] materialPathHashes, fallback, …)` —— 默认材质
- `_ApplyChangeMaterial(RenderInfo, List<string> renders, List<int> materials)` —— 按模板覆写

结构（`NPCAvatarMeshAssetsSO` → `NPCAvatarLodMeshAssets` → `SubMeshInfo`）：

```
avatarSlotMeshDatas[] : NPCAvatarLodMeshAssets
    name            = 部件名，等于清单 partNameIdList 的元素（P_npc_girl_body_efengineer_a_01）
    partType        = ENPCAvatarPartType(Body=2 Face=3 Hair=4 Headdress=5 EarL=6 EarR=7 Tail=8 Ear=9)
    partSubMeshsLOD0..3[] : SubMeshInfo
        meshName                       = 渲染器名 + "_lodN"（S_npc_girl_body_efengineer_a_01_lod0）
        materialPathHashes      long[] ← 默认材质
        backupMaterialNameToPathHashes  SerializedDictionary<int,long>  ← 材质码 → 材质路径哈希
```

解析口径：AssetRipper 把这三个字段导成**十六进制字节串**（`materialPathHashes` 每 8 字节一个 long；
`m_Keys` 每 4 字节一个 int32、`m_Values` 每 8 字节一个 long，两者等长配对）。

完整链路：

```
清单 renders[i]（渲染器名） + materialCodes[i]（int32）
  → 在装配表里找 meshName == renders[i] + "_lod<N>" 的 SubMeshInfo
  → backupMaterialNameToPathHashes[materialCodes[i]] → 材质路径哈希(long)
  → StringPathHash LUT（Data/ExtendData/{Main,Initial}）→ ".../m_npc_girl_face_common_a_07.mat"
  → cabmap ResolveCabsForPaths → CAB
无覆写时取 materialPathHashes
```

`renders` 比 `partNameIdList` **长**：一个部件可以有多个渲染器（脸部件另有 `S_..._iris_...` 眼球）。
所以对齐的是 `renders`↔`materialCodes`，不是部件↔材质。

## 🔴 按名字猜材质是错的（判据）

`npc_girl_face_common_a` 一个部件族就有 **42 个 .mat**（`m_..._a_01` … `_14` 及更多），
而**同一个部件在不同模板下取不同材质码**：

| 模板 | 部件 | 渲染器 | 材质码 |
|---|---|---|---|
| `npc_girl_efengineer_a_01` | `P_npc_girl_face_common_a_02` | `S_npc_girl_face_common_a_02` | `1462351840` |
| `npc_girl_efscholar_a_01` | `P_npc_girl_face_common_a_02` | `S_npc_girl_face_common_a_02` | `-1188571444` |

部件名尾号（`_02`）与材质尾号无关——尾号只是**部件自己的编号**，肤色/妆容/服装配色由模板的材质码决定。
所以任何 `P_x_02 → m_x_02` 的约定匹配都会静默给错材质。

材质码是**材质名的哈希**、跨部件共享：`S_npc_girl_iris_common_a_01` 与 `S_npc_girl_iris_common_a_02`
在不同模板里都取 `-1542985892`（同一个眼球材质）。

判据（实测，`npc_girl_efengineer_a_01`）：装配表 `P_npc_girl_body_efengineer_a_01` 的
`m_Keys` = `df3715cb 65661c52 f3561b25 50c37fbb c6f378cc`，第三项小端 int32 = `0x251B56F3`
= **622548723** = 清单 `materialCodes[0]`（对应 `S_npc_girl_body_efengineer_a_01`）。

## 导入侧（已接通）

`EndfieldNpcMaterials.Resolve(vfsRoots, templateId, assetTexts)` —— 读清单、按缩进走装配表文本、
解十六进制、查 LUT，返回「部件 / 网格名 / 材质路径」列式三元组。哈希→路径表提到
`EndfieldSceneBridge.AssetPathHashLut(vfsRoots)` 并按 root 集缓存
（原先每次场景发现都重建一遍这十几万条）。

Blender 侧 `roster_panel._npc_materials` 按 `avatarMeshName` 末段找 `data_npc_avatarmesh_<leaf>`，
拿到 `{网格名: [材质路径]}`；`_import_part` 把这些材质路径解析成 CAB
**并进部件自己的闭包一起导**（材质住在别的 CAB，不并进来就找不到），
再按 Mesh 自己的 `m_Name` 绑到对应网格上。

实测 `npc_girl_efstaff_a_04`：9 个网格 9 个材质、17 张贴图，其中两条按名字绝对匹配不到——

| 网格 | 得到的材质 | 为什么名字匹配会错 |
|---|---|---|
| `S_npc_girl_face_common_a_02` | `M_npc_girl_face_common_a_01` | 部件 02 配材质 01 |
| `S_npc_girl_eyeshadow_common_a_02` | `M_npc_common_shared_eyeshadow_com01` | 跨族共享材质 |

自测：`Game/EndField/selftest_npc.py`（`blender --background --python 它`，可加 `-- --npc <templateId>`）。

## 🔴 脸/耳不是「对齐」上去的，是「挂」上去的（朝向 bug 根因）

装配表里只有 **Face(3) 与 Ear(6/7/9)** 这两类 slot 带这三个字段，Body/Hair/Tail 全为空：

```
bUseSelfAvatar          = 1
parentBoneTransformName = Root/Bip001/.../Bip001_Neck/Bip001_Head
parentBoneName          = Bip001_Head
selfAvatarName          = SK_npc_girl_face_common_a_02Avatar
```

含义：脸/耳是**自带骨架、按父骨局部系在原点建模**的部件，游戏把它**挂到 `Bip001_Head` 变换下**
（`NPCAvatarCreatorUtils.CreateSkeletalMorphGo`），不做任何矩阵对齐。

实测两个 rest（Unity 空间，`npc_girl_efstaff_a_04`）：

```
身体 avatar Bip001_Head : R_body = [[0,0,-1],[-1,0,0],[0,1,0]]  t=(0, 1.4706, -0.0137)
脸 avatar  Bip001_Head : R_face = [[0,-1,0],[0,0,1],[-1,0,0]]  t=(0, 0, 0)   ← 平移为 0
```

`R_face = R_body⁻¹`，`t_face = 0`——这正是「在父骨局部系、原点建模」的样子。

`SkeletonBinder._alignment` 用的是 `body_attach @ inv(part_attach)`，前提是**部件也在站立世界系**
（body/hair/tail 成立）。对脸不成立：`R_body @ inv(R_body⁻¹) = R_body²`，**等于把头骨朝向乘了两次**。
因为 `t_face = 0`，平移恰好不受影响——所以症状是「位置对、只有朝向错」，
手动把脸的旋转设成 `R_body`（四元数 WXYZ = -0.5,-0.5,0.5,0.5）就完全正确。

**正解**：表里标了 `bUseSelfAvatar=1` + `parentBoneName` 的部件，offset 就是
**共享骨架里那根父骨的世界 rest**，不做任何 `inv(part_attach)` 抵消——即按表说的挂，不靠猜。
现有 `_alignment` 是按「哪根共享骨下面挂的部件骨最多」推断附着骨的启发式，对这两类部件是错的。

## 原先为何是白模

`roster_panel._import_part` 走 `prefab_importer.import_mesh_from_db(...)` 且**不传 materials**，
所以部件一律平白导入。清单读取（`EndfieldNpcPrefabInfo.Read`）也只取了
`partNameIdList / correspondingCharId / lodNum / facialMorphAvatarName / avatarTempletName`，
**`renders` 与 `materialCodes` 未读**。

部件不一定有 prefab：`P_npc_girl_body_efengineer_a_01` 只有 `sk_*.fbx`，
`npc_girl_ear_fox_c` 才有 `p_*_variant.prefab`。即便有 prefab，它也只带默认材质，
盖不住模板级材质码，所以走 prefab 也不能替代这条链。

## 另一个静默零：BridgeAssetDatabase 不给 mesh_blobs

本作顶点数据是流式/打包的，`prefab_scan.load_mesh` 先看数据库有没有原始几何 blob，
没有才回退去解 YAML —— 而回退在这个游戏上**必然解出 0 顶点**，表现是部件"导入成功但什么都没有"。
构造数据库时 `mesh_blobs=BRIDGE.mesh_blobs_by_guid` 是必给项，不是优化项。
