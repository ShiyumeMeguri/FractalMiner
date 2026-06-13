# 模块三：UI.Gameplay.Beyond 技术架构分析

**分析日期：** 2026-06-12
**模块路径：** `Assets/Project/EndField/Assets/Scripts/UI.Gameplay.Beyond/`
**命名空间：** `Beyond.UI`
**核心定位：** 游戏内玩法 UI（HUD、战斗、世界地图、追踪、锻造、工厂生产）。所有在游戏主循环中可见的叠加层 UI 组件。

---

## 1. 架构概述

UI.Gameplay.Beyond 是游戏内玩法 UI 的集合，没有统一的框架层（框架由 UI.Beyond 提供）。每个组件通常是独立或弱耦合的 MonoBehaviour，与游戏玩法数据绑定。

组件按功能可分为以下子系统：

1. **世界 UI** -- 头顶血条/名称、角色标记、世界空间 UI 跟随
2. **战斗 HUD** -- 角色 HP、架势条、技能按钮、锁定、伤害数字、Buff 图标
3. **追踪系统** -- 通用追踪器、任务目标、营火、黑匣子、电线杆
4. **区域地图** -- 3D 区域地图、地标图标、迷雾
5. **工厂 UI** -- 主区域面板、科技树、管道动画、区域升级特效
6. **锻造 UI** -- 温度计、进度条
7. **解谜 UI** -- 拼图拖拽
8. **扫描 UI** -- 可交互物扫描、液体池扫描、矿脉扫描
9. **HUD Fade 系统** -- HUD 渐隐控制器

---

## 2. 基类

```
TickableUIMono (来自外部框架)
  +- UIPanelBase
       -- 游戏内 UI 面板基类
       -- 常量: UI_SPRITE_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/{0}.png"
       -- 字段: m_loader (LuaResourceLoader)
       -- 方法:
            LoadSprite(string path, string name) -> Sprite
            OnRelease() -- 释放 LuaResourceLoader 句柄
       -- 重写: tickOption (TickType)
```

---

## 3. 子系统详解

### 3.1 世界 UI（World UI）

| 类名 | 说明 |
|------|------|
| WorldUIController | 世界 UI 控制器，管理所有世界空间 UI 元素 |
| UIHeadBar | 头顶血条 |
| UIHeadBarFollower | 头顶血条跟随器（将 UI 绑定到 3D 世界坐标） |
| UIHeadLabel | 头顶标签 |
| HeadBarCtrl | 头顶条控制器 |
| UIAbilityTargetFollower | 技能目标跟随器 |
| OutOfScreenTargetsCtrl | 屏幕外目标控制器 |
| OutOfScreenTargetArrow | 屏幕外目标箭头指示器 |

### 3.2 战斗 HUD

#### HP 与状态条

| 类名 | 说明 |
|------|------|
| MainCharHpBar | 主角 HP 条 |
| HpBarComboNode | HP 条连击节点 |
| HpChangeDisplayData | HP 变化显示数据 |
| UIPoiseBar | 架势条（韧性条） |
| UIPoiseKnot | 架势条节点 |
| UIVigilanceBar | 警戒条 |
| UICountDownBar | 倒计时条 |
| UIWaterDroneBar | 水上无人机条 |
| UILvInfoBar | 等级信息条 |
| UIMainCharFootBar | 主角脚底条 |
| UIMainCharFootBarArc | 主角脚底弧形条 |
| FootBarDashCell | 冲刺条单元 |

#### 伤害数字

| 类名 | 说明 |
|------|------|
| DamageTextNormalLevel1 | 普通伤害数字（等级 1） |
| DamageTextLevelUp | 升级伤害数字 |
| DamageTextType | 伤害数字类型枚举/定义 |

#### Buff 系统

| 类名 | 说明 |
|------|------|
| UIBuffCell | Buff 单元 |
| UIBuffNode | Buff 节点 |
| UIAbnormalBuffCell | 异常状态 Buff 单元 |
| UIAttachedBuffCell | 附着 Buff 单元 |
| UILifeTimeBuffCell | 生命周期 Buff 单元 |

#### 角色被动

| 类名 | 说明 |
|------|------|
| UICharPassiveBase | 角色被动基类 |
| UICharPassiveCounter | 角色被动计数器 |
| UICharPassiveMultiStates | 角色被动多状态 |
| UICharPassiveZhuangfy | 角色被动 Zhuangfy（音译） |

#### 技能与锁定

| 类名 | 说明 |
|------|------|
| SkillButton | 技能按钮 |
| UITacticalItemBar | 战术道具栏 |
| UIHudFadeTouchSkill | HUD 渐隐触摸技能 |
| UILockAim | 锁定瞄准 |
| UIWeakLockAim | 弱点锁定瞄准 |
| UIWeaknessNode | 弱点节点 |
| UISpellInflictionOnCharNode | 角色身上法术效果节点 |
| UISpellInflictionOnCharCell | 角色身上法术效果单元 |
| SquadIcon | 小队图标 |
| TacticalDotCell | 战术点单元 |

### 3.3 追踪系统

| 类名 | 说明 |
|------|------|
| UICommonTracker | 通用追踪器 |
| UICommonLevelTracker | 通用关卡追踪器 |
| UIGeneralTracker | 全局追踪器 |
| UIBlackboxTracker | 黑匣子追踪器 |
| UICampfireTracker | 营火追踪器 |
| UIPowerPoleFastTravelTracker | 电线杆快速旅行追踪器 |
| UIPowerPoleAutoConnectTracker | 电线杆自动连接追踪器 |
| UIRegionMapTrackIcon | 区域地图追踪图标 |

### 3.4 区域地图系统

| 类名 | 说明 |
|------|------|
| UIRegionMap3DPanel | 3D 区域地图面板 |
| UIRegionMap3DUICell | 3D 区域地图 UI 单元 |
| UIRegionMapTrackIcon | 区域地图追踪图标 |
| RegionMapShowType | 区域地图显示类型 |
| RegionMapSetting | 区域地图设置 |
| RegionMap3DCfg | 3D 区域地图配置 |

#### 关卡地图

| 类名 | 说明 |
|------|------|
| UILevelMapCrane | 关卡地图（吊车） |
| UILevelMapMisty | 关卡地图迷雾 |
| UILevelMapMissionArea | 关卡地图任务区域 |
| UILevelMapLine | 关卡地图线条 |
| UILevelMapGameplayArea | 关卡地图玩法区域 |
| UILevelMapSwitchBtn | 关卡地图切换按钮 |
| UILevelMapTouchPanelWrapper | 关卡地图触控面板包装 |
| UILevelMapLimitInRect | 关卡地图矩形限制 |

### 3.5 工厂系统 UI

| 类名 | 说明 |
|------|------|
| UIFacMainRegion | 工厂主区域 |
| UIFacMainRegionConfig | 工厂主区域配置 |
| UIFacTechTreePanel | 工厂科技树面板 |
| FacLineDrawer | 工厂连线绘制器 |
| FacLineCell | 工厂连线单元 |
| FacPipeAnimationSetting | 管道动画设置 |
| FacRegionUpgradeEffectController | 区域升级特效控制器 |

### 3.6 锻造系统 UI

| 类名 | 说明 |
|------|------|
| ForgeIronTemperatureUI | 锻造温度 UI |
| ForgeIronTemperatureCircleUI | 锻造温度圆形 UI |
| ForgeIronProgressBarUI | 锻造进度条 UI |

### 3.7 扫描系统

| 类名 | 说明 |
|------|------|
| UICommonScanController | 通用扫描控制器 |
| UIDoodadScanController | 可交互物扫描控制器 |
| UIDoodadPlantCoreScanController | 植物核心扫描控制器 |
| UIDoodadMineCoreScanController | 矿脉核心扫描控制器 |
| UILiquidPoolScanController | 液体池扫描控制器 |

### 3.8 HUD Fade 系统

| 类名 | 说明 |
|------|------|
| UIHudFadeBase | HUD 渐隐基类 |
| UIHudFadeController | HUD 渐隐控制器 |
| UIHudFadeConsoleController | HUD 渐隐主机控制器 |
| UIHudFadeTouchSkill | HUD 渐隐触摸技能 |

### 3.9 解谜系统

| 类名 | 说明 |
|------|------|
| PuzzleDrag | 拼图拖拽基础 |
| PuzzleCellDrag | 拼图单元拖拽 |
| PuzzleControllerHelper | 拼图控制器辅助 |

### 3.10 其他组件

| 类名 | 说明 |
|------|------|
| UISettlementRegion | 结算区域 |
| UIRaceModuleRankController | 竞速模块排名控制器 |
| UIVideoHelper | 视频辅助播放 |
| UIWatchPanelCut | 手表面板切换 |
| UIEquipRotHelper | 装备旋转辅助 |
| UIBrokenLine | 折线 |
| UIAutoCloseArea | 自动关闭区域 |
| GuideFakeButton | 引导假按钮 |
| UIWaterDroneJoystickCtrl | 水上无人机摇杆控制 |
| WaterDroneJoystickCtrl | 水上无人机摇杆控制 |
| MissionHudBGSizeUpdater | 任务 HUD 背景大小更新器 |
| UICommonLevelTracker | 通用关卡追踪 |

---

## 4. 核心模式与设计特点

1. **TickableUIMono 生命周期** -- 大部分 UI 组件继承自 TickableUIMono（或 UIPanelBase），支持统一的 Tick 更新和释放管理。
2. **LuaResourceLoader 集成** -- UIPanelBase 包含 LuaResourceLoader，支持 Lua 侧的资源加载卸载。
3. **IFix 热修复** -- 关键方法（OnRelease, LoadSprite 等）包含 IFix 补丁检测。
4. **Lua 可调用** -- 组件通过 ILuaCallCSharp 将控制权交给 Lua 脚本。
5. **追踪器模式** -- 多个 Tracker 类（UICommonTracker, UIGeneralTracker 等）共享相似的追踪逻辑，可能基于共用基类。
6. **扫描控制器模式** -- 多个 ScanController 共享相似的扫描交互逻辑。
7. **HUD 渐隐系统** -- UIHudFadeBase/Controller 体系实现了一套基于优先级/时间的 HUD 显隐管理。
8. **世界空间 UI 跟随** -- 通过 UIHeadBarFollower 等组件实现 2D UI 对 3D 世界坐标的映射。

---

## 5. 文件清单

| 目录 | 文件数 | 说明 |
|------|-------|------|
| `Beyond/UI/` | ~90+ | 所有游戏内玩法 UI 组件 |
| `Beyond/UI/Mission/` | 1 | 任务 HUD 背景更新器 |
| `IFix/` | 4 | IFix 热修复基础设施 |
| `HG/Rendering/Runtime/` | 1 | HG 渲染运行时 |
| `Properties/` | 1 | 程序集信息 |
| 根目录 | 2 | UIWatchPanelCut, UIEquipRotHelper |

---

## 6. 与 Entry.Beyond / UI.Beyond 的关系

```
Entry.Beyond (生命周期 & 状态机)
  └─ GameMainState -- 进入主游戏后
       └─ UI.Gameplay.Beyond -- 游戏内 UI 组件激活
            ├─ UIPanelBase (基于 UI.Beyond 框架)
            │    └─ 使用 UI.Beyond 的 UIButton, UIImage 等组件
            ├─ GPUI UI (通过 UI.Beyond.GPUI 渲染)
            └─ UI.Beyond 动画系统驱动

UI.Beyond (框架层)
  ├─ 提供 UI 组件（Button, Image, Toggle, ScrollRect 等）
  ├─ 提供 GPUI GPU 渲染管线
  ├─ 提供动画/适配/本地化等基础设施
  └─ 被 UI.Gameplay.Beyond 消费
```

---

## 7. 已知 IFix 方法 ID

| 类 | 方法 | 方法 ID (hex) |
|----|------|---------------|
| UIPanelBase | OnRelease | 0x147 |
| UIPanelBase | LoadSprite | 0x115 |
