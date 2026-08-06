# NPC 装配与材质

行人 NPC 没有成品 prefab：游戏在运行时按「部件清单 + 材质码」现拼。这份记录材质那条链，
因为它是导入侧唯一说不清、只能靠源码定谳的部分。

## 三张数据表

| 层 | 位置 | 给什么 |
|---|---|---|
| 模板清单 | `Data/Json/NPC/PrefabInfo/<templateId>.json`（真 JSON，非 MemoryPack） | 部件名、渲染器名、**材质码** |
| 共享装配表 | `…/gameplay/npc/avatarmesh/<族>/data_npc_avatarmesh_<leaf>.asset` | 每部件每子网格的**材质路径哈希** |
| 骨架模板 | `…/gameplay/npc/avatartemplet/<族>/data_npc_avatartemplet_<leaf>.asset` | 共享骨架（已在用） |

`avatarMeshName` / `avatarTempletName` 是**运行时寻址键**（`NPC/AvatarMesh/Pedestrain/girl`），
**不是容器路径**：容器里叫 `data_npc_avatarmesh_<最后一段>.asset`。两者靠这条命名换算相接。

装配表是**整族共享的**：全部 girl 行人共用同一份 `data_npc_avatarmesh_girl`（实测 119 个 slot，
覆盖该族所有部件）。这就是「NPC 都是通用的东西」的真实含义。

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

## 原先为何是白模

`roster_panel._import_part` 走 `prefab_importer.import_mesh_from_db(...)` 且**不传 materials**，
所以部件一律平白导入。清单读取（`EndfieldNpcPrefabInfo.Read`）也只取了
`partNameIdList / correspondingCharId / lodNum / facialMorphAvatarName / avatarTempletName`，
**`renders` 与 `materialCodes` 未读**。

部件不一定有 prefab：`P_npc_girl_body_efengineer_a_01` 只有 `sk_*.fbx`，
`npc_girl_ear_fox_c` 才有 `p_*_variant.prefab`。即便有 prefab，它也只带默认材质，
盖不住模板级材质码，所以走 prefab 也不能替代这条链。
