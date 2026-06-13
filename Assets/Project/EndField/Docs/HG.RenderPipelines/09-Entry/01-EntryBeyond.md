# 模块一：Entry.Beyond 技术架构分析

**分析日期：** 2026-06-12
**模块路径：** `Assets/Project/EndField/Assets/Scripts/Entry.Beyond/`
**命名空间：** `Beyond`
**核心定位：** Unity 游戏进程的引导（bootstrap）与生命周期管理。负责从进程启动到游戏主循环之间的一切：热更补丁、资源预加载、登录流程、游戏状态机调度。

---

## 1. 架构概述

Entry.Beyond 实现了两个核心职责：

1. **游戏状态机（GameStateMachine）** -- 将整个游戏生命周期划分为一组有序的状态（Init → Start → Login → Preload → Main → SoftRestart / Quit）。
2. **游戏入口点（GameApp）** -- Unity 的 `MonoBehaviour` 入口，管理文件系统扫描、补丁加载、登录工作流编排。

登录流程通过**工作流节点树（LoginWorkFlow）**实现，每个节点（Node）封装一个独立步骤：SDK 初始化、热更新检查、资源下载、创建角色等。

---

## 2. 类层次结构

### 2.1 游戏状态机体系


```
IGameStateMachine (interface, extends ILuaCallCSharp)
  └─ GameStateMachine : SimpleEnumStateMachine<GameState>
       状态机的具体实现，继承自泛型基类 SimpleEnumStateMachine<GameState>
       管理 GameState 枚举驱动的一组 ISimpleStateNode<GameState> 节点

GameState (enum)
  ├─ Init = 0
  ├─ Start = 1
  ├─ Login = 2
  ├─ Preload = 3
  ├─ Main = 4
  ├─ SoftRestart = 5
  └─ Quit = 6

ISimpleStateNode<GameState> (interface, extends ILuaCallCSharp)
  └─ GameStateBase : abstract class
       ├─ 属性: stateId (abstract GameState)
       ├─ 字段: m_stateMachine (protected GameStateMachine)
       ├─ 方法: OnEnter(GameState fromStateId) — 进入状态
       ├─ 方法: OnLeave(GameState toStateId) — 离开状态
       ├─ 方法: OnUpdate() — 每帧更新
       └─ 方法: OnGUI() — GUI 绘制
       │
       ├─ GameInitState
       │    └─ 初始化游戏子系统、设置环境
       ├─ GameStartState
       │    └─ 启动画面、SDK 初始化
       ├─ GameLoginState
       │    └─ 登录工作流、账号鉴权
       ├─ GamePreloadState
       │    └─ 预加载游戏资源、场景
       ├─ GameMainState
       │    └─ 进入游戏主循环
       ├─ GameSoftRestartState
       │    └─ 软重启流程
       └─ GameQuitState
            └─ 退出游戏、清理资源
```
# 模块一：Entry.Beyond 技术架构分析

**分析日期：** 2026-06-12
**模块路径：** `Assets/Project/EndField/Assets/Scripts/Entry.Beyond/`
**命名空间：** `Beyond`
**核心定位：** Unity 游戏进程的引导（bootstrap）与生命周期管理。负责从进程启动到游戏主循环之间的一切：热更补丁、资源预加载、登录流程、游戏状态机调度。

---

## 1. 架构概述

Entry.Beyond 实现了两个核心职责：

1. **游戏状态机（GameStateMachine）** -- 将整个游戏生命周期划分为一组有序的状态（Init -> Start -> Login -> Preload -> Main -> SoftRestart / Quit）。
2. **游戏入口点（GameApp）** -- Unity 的 MonoBehaviour 入口，管理文件系统扫描、补丁加载、登录工作流编排。

登录流程通过**工作流节点树（LoginWorkFlow）**实现，每个节点（Node）封装一个独立步骤：SDK 初始化、热更新检查、资源下载、创建角色等。

---

## 2. 类层次结构

### 2.1 游戏状态机体系

```
IGameStateMachine (interface, extends ILuaCallCSharp)
  +- GameStateMachine : SimpleEnumStateMachine<GameState>
       状态机的具体实现，继承自泛型基类 SimpleEnumStateMachine<GameState>
       管理 GameState 枚举驱动的一组 ISimpleStateNode<GameState> 节点

GameState (enum)
  +- Init = 0
  +- Start = 1
  +- Login = 2
  +- Preload = 3
  +- Main = 4
  +- SoftRestart = 5
  +- Quit = 6

ISimpleStateNode<GameState> (interface, extends ILuaCallCSharp)
  +- GameStateBase : abstract class
       +- 属性: stateId (abstract GameState)
       +- 字段: m_stateMachine (protected GameStateMachine)
       +- 方法: OnEnter(GameState fromStateId) -- 进入状态
       +- 方法: OnLeave(GameState toStateId) -- 离开状态
       +- 方法: OnUpdate() -- 每帧更新
       +- 方法: OnGUI() -- GUI 绘制
       |
       +- GameInitState -- 初始化游戏子系统、设置环境
       +- GameStartState -- 启动画面、SDK 初始化
       +- GameLoginState -- 登录工作流、账号鉴权
       +- GamePreloadState -- 预加载游戏资源、场景
       +- GameMainState -- 进入游戏主循环
       +- GameSoftRestartState -- 软重启流程
       +- GameQuitState -- 退出游戏、清理资源
```

### 2.2 登录工作流体系

```
LoginManager -- 登录管理器，调度 LoginWorkFlow
LoginController -- 登录控制器，协调 UI/Model
LoginContext -- 登录上下文，承载状态传递

LoginWorkFlow -- 登录工作流，包含一串节点序列：
  +- LoginInitNode -- 登录环境初始化
  +- LoginSDKInitNode -- SDK 初始化（U8 等）
  +- WaitForSecondsNode -- 等待延时
  +- LoginGSNode -- 连接 GameServer
  +- Trans2GsLoginNode -- 切换到 GS 登录
  +- U8LoginNode -- U8 SDK 登录
  +- LoginCheckForUpdateNode -- 检查更新
  +- HotUpdateNode -- 下载热更资源
  +- LoginGameUpdateNode -- 游戏资源更新
  +- PreloadNode -- 预加载
  +- PreloadPostDelayNode -- 预加载后延时
  +- LoginGameSettingInitializer -- 游戏设置初始化
  +- LoginCreateRoleNode -- 创建角色
  +- FinishNode -- 结束节点
  +- CarrierDownloadCache -- 运营商下载缓存

ILoginBinder (interface)
ILoginContextReceiver (interface)
  -- 接口，用于登录组件间的绑定与回调

LoginViewModel, LoginViewProperty, LoginProperty,
LoginHotUpdateModel, LoginHotUpdateProp,
LoginServerSelectModel, LoginServerSelectProp,
LoginAgeTipsProp, LoginProgress
  -- 各种 Model/Property/ViewModel 类

LoginRootPanel, LoginMenuPanel, LoginResourcePanel,
LoginEnterGamePanel, LoginVersionPanel,
LoginServerSelectPanel, LoginServerSelectItemView,
LoginServerItem, LoginVocResSelDialog,
LoginVocResSelItemView, LoginDecorateUI,
LoginSceneRoot, LoginSceneComponent, LoginSceneAnimCtrl
  -- 登录场景的 UI 面板/视图

LoginAlertDialog, LoginJudgeDialog, LoginGovTipsPanel,
LoginAgeTipsPanel, LoginAgeTipsDetailPanel,
VietnamLoginAgePanel, VietnamLoginAgeTipsPanelCtrl
  -- 各类登录弹窗

LoginHotUpdater, LoginGameUpdater, LoginDownloadTask, LoginLocalResTask
  -- 更新/下载任务封装

NetUsagePolicy -- 网络使用策略
LoginMockUIDPanel -- 模拟 UID 面板
```

### 2.3 热修复体系

```
IHotFixCommon (interface)
IHotFixPatchManagerProxy (interface)
HotFixPatchModules -- 热更补丁模块管理

IMemoryPackProxy (interface)
MemoryPackProxyModule -- MemoryPack 序列化代理

IFix 命名空间：
  +- WrappersManagerImpl -- 自动生成的方法包装器，每个 IFix 补丁都通过此类调度
  +- ILFixInterfaceBridge -- 接口桥接
  +- ILFixDynamicMethodWrapper -- 动态方法包装
  +- IDMAP0 -- 方法 ID 映射表
```

### 2.4 核心初始化

```
GlobalInitializer -- 全局初始化器，在 GameInitState 中被调用
InitialPathDef -- 初始路径定义

GameApp : MonoBehaviour, ILuaCallCSharp
  -- 游戏主入口组件（14,909 行）
  -- 内部类:
       FileEntry -- 文件条目（name, fullPath, size, md5, pathLength, readable, writable, readOnly）
       PendingFile -- 待处理文件（fullPath, size, readOnlyAttr）
       ScanContext -- 扫描上下文（dirQueue, fileQueue, results, pendingDirs, pendingFiles）
       TreeNode -- 树节点（name, fileEntry, children）
       WIN32_FIND_DATA -- Win32 文件查找数据结构
  -- 功能：文件系统目录扫描、补丁验证、MD5 校验、延迟初始化协程

TailGameLoop -- 游戏尾巴循环（后台/次要循环）
RenderPipelineDataLoader -- 渲染管线数据加载
SplashController -- 启动画面控制器
```

### 2.5 工具与支持类

```
SDK 集成层: SDKTextDefines, SDKNetUtils, PlatformFont, U8Plugin, U8ExternalTools
ELoginEvent -- 登录事件枚举
LoginTextDefines -- 登录文本常量
RenderSilhouetteRT -- 渲染剪影 RT
WarmUpProgress -- 预热进度
GameSettingSetter -- 游戏设置设置器

SourceGenerator 特性:
  ECSComponentAttribute
  DataNAttribute
  CameraControlConfigAttribute
  AnimatorBlackboardAttribute
  AnimatorBlackboardUtility
```

---

## 3. 核心流程

```
App 启动
  +- GameApp.Awake / Start
       +- GlobalInitializer.Initialize
            +- GameStateMachine 初始化
                 +- GameInitState.OnEnter -- 初始化基础设施
                 +- GameStartState.OnEnter -- SplashController 启动画面
                 +- GameLoginState.OnEnter -- LoginManager 接手登录
                 |    +- LoginWorkFlow 执行节点序列:
                 |         SDK 初始化 -> 连接 GS -> 检查更新 -> 下载 -> 预加载 -> 创建角色 -> 完成
                 +- GamePreloadState.OnEnter -- 预加载核心资源
                 +- GameMainState.OnEnter -- 游戏主循环开始
                 +- GameSoftRestartState.OnEnter -- 软重启
                 +- GameQuitState.OnEnter -- 清理退出
```

---

## 4. Lua 交互

几乎所有核心类都实现了 ILuaCallCSharp 接口，表明该模块广泛使用 xLua（或类似框架）实现 C# 与 Lua 之间的互调用。

---

## 5. IFix 补丁系统

大量方法体检测代码形如：
```csharp
if (IFix.WrappersManagerImpl.IsPatched(methodId))
    call_ilfix_patch();
else
    original_implementation();
```
表明该模块使用腾讯 IFix 框架进行热修复，每个方法都有一个唯一的方法 ID，补丁通过 WrappersManagerImpl 调度。

---

## 6. 文件清单

| 文件路径 | 说明 |
|---------|------|
| `Beyond/GameApp.cs` | 游戏主入口 (14,909 行) |
| `Beyond/GameStateMachine.cs` | 游戏状态机 (1,588 行) |
| `Beyond/GameStateBase.cs` | 状态基类 |
| `Beyond/GameInitState.cs` | 初始化状态 |
| `Beyond/GameStartState.cs` | 启动状态 |
| `Beyond/GameLoginState.cs` | 登录状态 |
| `Beyond/GamePreloadState.cs` | 预加载状态 |
| `Beyond/GameMainState.cs` | 主游戏状态 |
| `Beyond/GameSoftRestartState.cs` | 软重启状态 |
| `Beyond/GameQuitState.cs` | 退出状态 |
| `Beyond/GlobalInitializer.cs` | 全局初始化 |
| `Beyond/InitialPathDef.cs` | 路径定义 |
| `Beyond/LoginManager.cs` | 登录管理器 |
| `Beyond/LoginController.cs` | 登录控制器 |
| `Beyond/LoginContext.cs` | 登录上下文 |
| `Beyond/ELoginEvent.cs` | 登录事件枚举 |
| `Beyond/LoginTextDefines.cs` | 登录文本 |
| `Beyond/IHotFixCommon.cs` | 热修复通用接口 |
| `Beyond/IHotFixPatchManagerProxy.cs` | 热修复代理接口 |
| `Beyond/HotFixPatchModules.cs` | 热修复模块 |
| `Beyond/IMemoryPackProxy.cs` | MemoryPack 代理接口 |
| `Beyond/MemoryPackProxyModule.cs` | MemoryPack 代理实现 |
| `Beyond/RenderPipelineDataLoader.cs` | 渲染管线数据加载 |
| `Beyond/TailGameLoop.cs` | 尾巴循环 |
| `Beyond/SplashController.cs` | 启动画面 |
| `Beyond/SDK/*.cs` | SDK 集成层（5 文件） |
| `Beyond/Scripts/Entry/*.cs` | 入口脚本（2 文件） |
| `Beyond/Login/*.cs` | 登录工作流节点与 UI（约 40 文件） |
| `Beyond/SourceGenerator/*.cs` | 源代码生成器特性（5 文件） |
| `IFix/*.cs` | IFix 热修复基础设施（4 文件） |
| `RenderSilhouetteRT.cs` | 剪影 RT |
| `HG/Rendering/Runtime/` | HG 渲染运行时 |
| `Properties/AssemblyInfo.cs` | 程序集信息 |
