# 宙梦岛（Arknights Endfield）分析笔记

按领域分文件。每份只放**结论 + 位置**（类名 / 文件名 / 表名），不堆细节。

**维护约定：每次分析了 Endfield 的源码或数据格式，或改动了 Blender 侧的数据加载
（导入管线、数据来源、格式解码），就更新对应领域的文件。** 结论要能被判据支撑，
推测必须显式写「推测」。

## 领域

| 文件 | 内容 |
|---|---|
| [引擎结构.md](引擎结构.md) | ECS 覆盖层、类型树读取的坑 |
| [战斗系统.md](战斗系统.md) | 与 UE GAS 的对位关系 |
| [数据容器.md](数据容器.md) | VFS 分层，四种容器格式各管什么 |
| [流场景设计.md](流场景设计.md) | chunk 格、流式加载 API、加载窗口 |
| [区域与地标设计.md](区域与地标设计.md) | 箱庭/流场景之分、地标矩形、名字来源 |
| [传送点设计.md](传送点设计.md) | 协议传送点在哪、找过哪些地方 |
| [关卡逻辑数据.md](关卡逻辑数据.md) | MemoryPack 侧的关卡实体数据 |
| [NPC装配与材质.md](NPC装配与材质.md) | 行人 NPC 的部件/材质码链路 |
| [Blender加载管线.md](Blender加载管线.md) | 导入架构、内存代价、自测 |

## 环境

| 用途 | 路径 |
|---|---|
| 源码树 | `E:\Temp\RealCS`（1.4.4 期） |
| 游戏安装 | `E:\Games\GRYPHLINK\games\Arknights Endfield` |
| cabmap | `<gameRoot>\EndField_1.4.4.cabmap` |
| Blender 插件 | `…\BlenderProfile\RuriConfig\scripts\addons\RuriRipperImporter` |
| C# hook | `D:\Ruri\Git\FractalTools\Ruri-RipperHook` |
