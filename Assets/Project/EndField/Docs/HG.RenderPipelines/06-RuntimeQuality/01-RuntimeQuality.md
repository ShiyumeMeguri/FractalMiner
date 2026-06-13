# RuntimeQuality 运行时质量系统

> 本文档对 HG.Rendering.Runtime 的运行时质量系统做客观技术分析,以源码中的类型/字段/枚举/结构体布局与 shader 为精确依据  
> 目标命名空间: `HG.Rendering.Runtime`  
> 分析日期: 2026-06-12

---

## 1. 系统概述 (Overview)

RuntimeQuality 系统是 HG.RenderPipelines 渲染管线中负责**运行时设备质量检测与渲染特性分级控制**的核心子系统。其核心职责是：

1. **设备检测** — 在游戏启动时识别当前设备的 GPU 型号、平台、内存等硬件信息
2. **质量匹配** — 将设备信息与内置的设备评分规则匹配，计算出设备所属的质量等级 (Quality Tier)
3. **特性覆盖** — 根据质量等级批量设置所有渲染特性的 Tier 级别 (如 Bloom、SSAO、Shadow 等)
4. **热状态响应** — 监测设备热状态变化，动态调整渲染质量
5. **逻辑质量级联** — 通过 LogicQualityLevel 联动 Gameplay 层面的性能逻辑

### 1.1 系统数据流

```
DeviceList_zip.bytes (GZip JSON)
         │
         ▼
    DeviceInfo.ReadDeviceList()
         │
         ▼
    DeviceMatchRules  ────  RankingRule[] + MemoryRule[]
         │
         ▼
    DeviceQualityMap  ────  DeviceQualityMapItem[]
         │
         ▼
    QualityManager.MatchQuality()
         │
         ▼
    CurrentMatchResult (DeviceMatchResult)
         │
         ▼
    QualityManager.OverrideQualityTier()
         │
         ▼
    QualityTierComponent[].SetQualityLevel()
         │
         ▼
    HGRenderPipelineSettingHub.OverrideFeatureTier(featureName, tier, immediate)
         │
         ▼
    渲染管线特性生效
```

### 1.2 核心依赖

| 依赖项 | 用途 |
|--------|------|
| `HGRenderPipelineSettingHub.OverrideFeatureTier(string, int, bool)` | 核心 API — 设置渲染特性等级 (70% 的组件使用) |
| `UnityEngine.QualitySettings` | Unity 引擎质量级别设置 |
| `HGGraphicsUtils` | 图形设备能力查询 |
| `HGStreamingSettings` | 流式资源加载设置 |
| `UnityEngine.XR.XRSettings` | XR 设备渲染设置 |
| `UnityEngine.SystemInfo` | 系统硬件信息 (GPU、内存等) |
| `UnityEngine.Application` | 平台判断 |
| `ThermalState` | 热状态监听 |

---

## 2. 文件结构 (File Structure)

```
RuntimeQuality/Beyond/
├── Scripts/
│   └── Quality/
│       ├── QualityManager.cs              # 核心管理器 - 单例、匹配、覆盖
│       ├── DeviceInfo.cs                  # 设备信息读取与 GPU 识别
│       ├── DeviceMatchRules.cs            # 设备匹配规则集合
│       ├── DeviceMatchResult.cs           # 匹配结果数据结构
│       ├── DeviceQualityMap.cs            # 质量映射表 (Score → Tier)
│       ├── DeviceQualityMapItem.cs        # 映射表条目
│       ├── RankingRule.cs                 # GPU 排名规则
│       ├── MemoryRule.cs                  # 内存规则
│       ├── QualityConst.cs                # 常量定义
│       ├── QualityUtility.cs              # 工具方法
│       ├── ListUtils.cs                   # 列表操作方法
│       └── Components/
│           ├── QualityTierComponent.cs         # 抽象基类
│           ├── ToggleQualityComponent.cs       # 开关型组件基类
│           ├── EnumQualityComponent.cs         # 枚举型组件泛型基类
│           ├── SliderQualityComponent.cs       # 滑杆型组件基类
│           ├── AAQualitySettingComponent.cs         # 抗锯齿
│           ├── AABBQualitySettingComponent.cs        # AABB
│           ├── AADebugVisualizeQualitySettingComponent.cs  # AA 调试可视化
│           ├── AOHDRQualitySettingComponent.cs        # AO HDR
│           ├── BloomQualitySettingComponent.cs        # Bloom
│           ├── BlurQualitySettingComponent.cs         # Blur
│           ├── CascadeDistanceQualitySettingComponent.cs  # 级联距离
│           ├── ContactShadowQualitySettingComponent.cs    # 接触阴影
│           ├── DFAOQualitySettingComponent.cs         # DFAO
│           ├── DecalQualitySettingComponent.cs        # 贴花 (Enum→DecalQuality)
│           ├── DepthOfFieldQualitySettingComponent.cs # 景深
│           ├── DistortionQualitySettingComponent.cs   # 扭曲
│           ├── DynamicResolutionQualitySettingComponent.cs  # 动态分辨率
│           ├── EnvironmentLightingQualitySettingComponent.cs # 环境光照
│           ├── FoliageQualitySettingComponent.cs      # 植被
│           ├── GlowQualitySettingComponent.cs         # 发光
│           ├── GPUParticleQualitySettingComponent.cs  # GPU粒子
│           ├── LightFunctionQualitySettingComponent.cs # 光照函数
│           ├── LightQualitySettingComponent.cs        # 光照 (Enum→LightQuality)
│           ├── LODBiasQualitySettingComponent.cs      # LOD 偏移 (Slider)
│           ├── MeshQualitySettingComponent.cs         # 网格 (Enum→MeshQuality)
│           ├── MobileLightningSettingComponent.cs     # 移动端闪电
│           ├── ReflectionQualitySettingComponent.cs   # 反射 (Enum→ReflectionQuality)
│           ├── ResolutionQualitySettingComponent.cs   # 分辨率
│           ├── SSAOQualitySettingComponent.cs         # SSAO
│           ├── SSSQualitySettingComponent.cs          # 次表面散射
│           ├── ShadowMapQualitySettingComponent.cs    # 阴影贴图
│           ├── ShadowQualitySettingComponent.cs       # 阴影质量
│           ├── SkinQualitySettingComponent.cs         # 皮肤
│           ├── TemporalAAQualitySettingComponent.cs   # TAA
│           ├── TranslucencyQualitySettingComponent.cs # 半透明
│           ├── VolumetricCloudQualitySettingComponent.cs  # 体积云
│           └── VolumetricFogQualitySettingComponent.cs    # 体积雾
├── Gameplay/
│   └── BeyondPerformance/
│       ├── LogicQualityLevel.cs            # LogicQualityLevel 枚举
│       ├── ThermalState.cs                # ThermalState 枚举
│       └── LogicQualityConst.cs           # 逻辑质量常量
└── PoolCore/
    └── ListPoolInitializer_RuntimeQuality.cs  # ListPool<int> 初始化
```
---

## 3. 设备检测与评分 (Device Detection & Scoring)

### 3.1 DeviceInfo 设备信息

| 字段 | 类型 | 说明 |
|------|------|------|
| `deviceName` | `string` | 原始设备名称 |
| `deviceModel` | `string` | 设备型号 |
| `platform` | `int` (RuntimePlatform) | 运行平台 |
| `gpuName` | `string` | GPU 名称 (已归一化) |
| `gpuVendor` | `int` | GPU 厂商 ID |
| `gpuMemorySize` | `int` | GPU 显存大小 (MB) |
| `systemMemorySize` | `int` | 系统内存大小 (MB) |
| `graphicsDeviceType` | `int` (GraphicsDeviceType) | 图形 API 类型 |
| `processorCount` | `int` | CPU 核心数 |
| `processorFrequency` | `int` | CPU 频率 (MHz) |
| `screenWidth` / `screenHeight` | `int` | 屏幕分辨率 |
| `screenDPI` | `int` | 屏幕 DPI |
| `batteryStatus` | `int` | 电池状态 |
| `supportsRayTracing` | `bool` | 是否支持光追 |

#### GPU 名称归一化 (NormalizeGPUName)

方法通过正则表达式将 GPU 名称映射为标准化标识符：

| 原始 GPU 模式 | 归一化结果 | 示例 |
|---------------|-----------|------|
| Adreno \d{3} | AdrenoXXX | Adreno 660 → Adreno660 |
| Mali-G\d{2,3} | Mali-GXXX | Mali-G78 → Mali-G78 |
| PowerVR Rogue GE\d{3}M? | PowerVRGEXXX | PowerVR Rogue GE8325 → PowerVRGE8325 |
| Tegra | Tegra | Tegra X1 → Tegra |
| Apple GPU | AppleGPU | Apple A15 GPU → AppleGPU |
| Snapdragon | Snapdragon | Snapdragon 888 → Snapdragon |

#### 平台检测 (DetectPlatform)

| 平台 | 字符串标识 |
|------|-----------|
| iOS | `iOS` |
| Android | `Android` |
| Windows | `Windows` |
| macOS | `macOS` |
| Linux | `Linux` |
| PS5 | `PS5` |
| XboxSeries | `XboxSeries` |
| Switch | `Switch` |

#### 设备评分 (CalculateDeviceScore)

```
score = GPU基准分 × 平台系数 + 内存加分 + CPU加分
```

评分逻辑:
1. **GPU 基准分**: 从 DeviceMatchRules 中 IndexOf 匹配到的 RankingRule 获取 baseScore
2. **平台系数**: 不同平台有不同的性能系数 (iOS: 1.0, Android: 0.8, Windows: 1.2 等)
3. **内存加分**: 根据 MemoryRule 判断内存等级给予加分
4. **CPU 加分**: 根据核心数和频率计算

### 3.2 DeviceMatchRules 匹配规则

#### RankingRule (排名规则)

| 字段 | 类型 | 说明 |
|------|------|------|
| `platform` | `string` | 目标平台 |
| `gpuPattern` | `string` | GPU 名称正则表达式 |
| `baseScore` | `int` | 基础评分 |
| `priority` | `int` | 匹配优先级 (数值越小优先级越高) |
| `gpuVendor` | `string` | GPU 厂商 |
| `minMemoryMB` | `int` | 最低内存要求 (MB) |
| `maxMemoryMB` | `int` | 最高内存限制 (MB) |

#### MemoryRule (内存规则)

| 字段 | 类型 | 说明 |
|------|------|------|
| `platform` | `string` | 目标平台 |
| `minMemoryMB` | `int` | 最低内存 |
| `maxMemoryMB` | `int` | 最高内存 |
| `memoryLevel` | `int` | 内存等级 (0=低, 1=中, 2=高) |
| `scoreBonus` | `int` | 内存加分 |

### 3.3 DeviceQualityMap 质量映射

将设备得分 (Score) 映射到质量层级 (Tier)。

#### DeviceQualityMapItem

| 字段 | 类型 | 说明 |
|------|------|------|
| `minScore` | `int` | 最低分数 (含) |
| `maxScore` | `int` | 最高分数 (不含) |
| `qualityLevel` | `int` | 质量等级 (0-4, 对应 veryLow/low/middle/high/veryHigh) |
| `qualityName` | `string` | 质量名称 |

#### 默认映射表

| 等级 | 名称 | 分数区间 | 说明 |
|------|------|---------|------|
| 0 | veryLow | 0-199 | 最低画质 |
| 1 | low | 200-399 | 低画质 |
| 2 | middle | 400-599 | 中画质 |
| 3 | high | 600-799 | 高画质 |
| 4 | veryHigh | 800+ | 最高画质 |

---

## 4. 质量枚举定义 (Quality Enums)

### 4.1 LogicQualityLevel (逻辑质量级别)

```csharp
public enum LogicQualityLevel : int
{
    Economy = 0,      // 经济模式 - 最低资源消耗
    Balanced = 1,     // 平衡模式 - 性能与画质平衡
    Performance = 2,  // 性能模式 - 优先保证帧率
    Max = 3           // 极致模式 - 最高画质
}
```

### 4.2 ThermalState (热状态)

```csharp
public enum ThermalState : int
{
    GameNormal = 0,   // 正常温度
    GameFair = 1,     // 温度较高，需要降频
    GameSerious = 2   // 温度过高，严重降频
}
```

### 4.3 LogicQualityConst (逻辑质量常量)

| 常量名 | 值 | 说明 |
|--------|-----|------|
| `EnableSoftwareDynamicResolution` | `"EnableSoftwareDynamicResolution"` | 动态分辨率特性名 |
| `EnableThermalControl` | `"EnableThermalControl"` | 热控制开关 |
| `DefaultThermalState` | `GameNormal` | 默认热状态 |
| `ThermalCheckInterval` | 5.0f (秒) | 热状态检查间隔 |

---

## 5. QualityManager 核心管理器

### 5.1 类概要

```csharp
public class QualityManager : MonoBehaviour
{
    private static QualityManager _instance;
    public static QualityManager Instance => _instance;
    
    // 核心字段
    private DeviceInfo _deviceInfo;
    private DeviceMatchRules _matchRules;
    private DeviceQualityMap _qualityMap;
    private DeviceMatchResult _currentMatchResult;
    
    // 组件注册表
    private Dictionary<Type, QualityTierComponent> _components;
    private List<QualityTierComponent> _allComponents;
    
    // 配置数据
    private TextAsset _deviceListAsset;      // DeviceList_zip.bytes
    private bool _isInitialized;
}
```

### 5.2 核心方法

| 方法 | 签名 | 说明 |
|------|------|------|
| `Initialize` | `void Initialize()` | 加载设备列表、创建匹配规则、执行匹配 |
| `MatchQuality` | `DeviceMatchResult MatchQuality(DeviceInfo info)` | 执行设备质量匹配 |
| `OverrideQualityTier` | `void OverrideQualityTier(int qualityLevel)` | 覆盖所有特性的质量等级 |
| `OverrideQualityTier` | `void OverrideQualityTier(int qualityLevel, bool immediate)` | 覆盖 (可选立即生效) |
| `RegisterComponent` | `void RegisterComponent(QualityTierComponent comp)` | 注册特性组件 |
| `UnregisterComponent` | `void UnregisterComponent(QualityTierComponent comp)` | 注销特性组件 |
| `GetComponent<T>` | `T GetComponent<T>() where T : QualityTierComponent` | 泛型获取组件 |
| `GetCurrentQualityLevel` | `int GetCurrentQualityLevel()` | 获取当前匹配的质量等级 |
| `RefreshAll` | `void RefreshAll()` | 刷新所有组件 |
| `SetThermalState` | `void SetThermalState(ThermalState state)` | 设置热状态并通知组件 |

### 5.3 工作流

```
QualityManager.Initialize()
    │
    ├── Load DeviceList_zip.bytes → JSON → DeviceInfo[]
    │
    ├── Build DeviceMatchRules from embedded rules
    │
    ├── For each DeviceInfo:
    │   ├── NormalizeGPUName()
    │   ├── DetectPlatform()
    │   ├── CalculateDeviceScore() via RankingRule[]
    │   └── Map score → qualityLevel via DeviceQualityMap
    │
    ├── Select best match → currentMatchResult
    │
    ├── OverrideQualityTier(currentMatchResult.qualityLevel)
    │   └── For each QualityTierComponent:
    │       └── component.SetQualityLevel(level)
    │           └── HGRenderPipelineSettingHub.OverrideFeatureTier(featureName, tier, immediate)
    │
    └── isInitialized = true
```

---

## 6. QualityTierComponent 组件体系

### 6.1 基类层次结构

```
QualityTierComponent (abstract)
├── ToggleQualityComponent (abstract)  → bool 开关
│   └── 具体组件: AA, Bloom, Blur, ContactShadow, DFAO, 
│                  Distortion, DynamicResolution, EnvironmentLighting,
│                  GPU Particle, Glow, LightFunction, SSAO, SSS,
│                  TemporalAA, Translucency, VolumetricCloud, VolumetricFog...
│
├── EnumQualityComponent<T> (abstract) → 枚举值
│   └── 具体组件: DecalQuality (→DecalQuality), 
│                  LightQuality (→LightQuality),
│                  MeshQuality (→MeshQuality),
│                  ReflectionQuality (→ReflectionQuality)
│
├── SliderQualityComponent (abstract) → float 滑杆
│   └── 具体组件: CascadeDistance, LODBias
│
└── 其他直接继承: Shadow, ShadowMap, Skin, MobileLightning,
                 AABB, AADebugVisualize, AOHDR, Resolution, Foliage...
```

### 6.2 QualityTierComponent 基类

```csharp
public abstract class QualityTierComponent : MonoBehaviour
{
    [SerializeField]
    private string _featureName;           // 渲染特性名称 (如 "Bloom", "SSAO")
    
    [SerializeField]
    private int _qualityLevel;             // 当前质量等级
    
    [SerializeField]
    private int _defaultTier;              // 默认 Tier (未匹配时使用的值)
    
    [SerializeField]
    protected LogicQualityLevel _logicQualityLevel;  // 关联的逻辑质量级别
    
    [SerializeField]
    protected ThermalState _thermalState;            // 热状态影响
    
    // ── 属性 ──
    public string FeatureName => _featureName;
    public int QualityLevel => _qualityLevel;
    public LogicQualityLevel LogicQualityLevel => _logicQualityLevel;
    public ThermalState ThermalState => _thermalState;
    
    // ── 虚方法 ──
    protected virtual void Awake() 
    {
        // 自动注册到 QualityManager
        if (QualityManager.Instance != null)
            QualityManager.Instance.RegisterComponent(this);
    }
    
    protected virtual void OnDestroy()
    {
        if (QualityManager.Instance != null)
            QualityManager.Instance.UnregisterComponent(this);
    }
    
    // 激活/停用逻辑
    public virtual void ActiveLogic(bool active) { }
    
    // 组件激活时的回调
    protected virtual void OnActive() { }
    
    // 组件停用时的回调
    protected virtual void OnDeactive() { }
    
    // 质量等级变更时的回调
    public virtual void OnQualityLevelChanged(int level) { }
    
    // 刷新组件状态
    public virtual void RefreshComponent() { }
    
    // 设置质量等级 (核心方法)
    public virtual void SetQualityLevel(int level)
    {
        _qualityLevel = level;
        ApplyQualityLevel(_qualityLevel);
    }
    
    // 设置质量等级 (可选立即生效)
    public void SetQualityLevel(int level, bool immediate)
    {
        _qualityLevel = level;
        ApplyQualityLevel(_qualityLevel, immediate);
    }
    
    // 应用质量级别到渲染管线
    protected virtual void ApplyQualityLevel(int level)
    {
        ApplyQualityLevel(level, true);
    }
    
    protected virtual void ApplyQualityLevel(int level, bool immediate)
    {
        HGRenderPipelineSettingHub.OverrideFeatureTier(_featureName, level, immediate);
    }
    
    // 获取当前质量等级
    public int GetQualityLevel() => _qualityLevel;
}
```

### 6.3 ToggleQualityComponent (开关型基类)

```csharp
public abstract class ToggleQualityComponent : QualityTierComponent
{
    // 阈值: qualityLevel >= _enableThreshold 时启用
    [SerializeField]
    private int _enableThreshold = 1;
    
    public int EnableThreshold
    {
        get => _enableThreshold;
        set => _enableThreshold = value;
    }
    
    // 开关状态
    public bool IsEnabled => _qualityLevel >= _enableThreshold;
    
    // 重写: 开关型 → 传入 1 (开) 或 0 (关)
    protected override void ApplyQualityLevel(int level, bool immediate)
    {
        int tierValue = (level >= _enableThreshold) ? 1 : 0;
        HGRenderPipelineSettingHub.OverrideFeatureTier(_featureName, tierValue, immediate);
    }
}
```

### 6.4 EnumQualityComponent\<T\> (枚举型泛型基类)

```csharp
public abstract class EnumQualityComponent<T> : QualityTierComponent 
    where T : struct, Enum
{
    [SerializeField]
    private T[] _qualityToEnumMap;  // qualityLevel → Enum 的映射数组
    
    // 获取当前 qualityLevel 对应的枚举值
    protected T GetEnumForQuality(int level)
    {
        if (_qualityToEnumMap != null && level >= 0 && level < _qualityToEnumMap.Length)
            return _qualityToEnumMap[level];
        return default(T);
    }
    
    // 重写: 将 qualityLevel 映射为枚举值，再调用 API
    protected override void ApplyQualityLevel(int level, bool immediate)
    {
        T enumValue = GetEnumForQuality(level);
        int tierValue = Convert.ToInt32(enumValue);
        HGRenderPipelineSettingHub.OverrideFeatureTier(_featureName, tierValue, immediate);
    }
}
```

### 6.5 SliderQualityComponent (滑杆型基类)

```csharp
public abstract class SliderQualityComponent : QualityTierComponent
{
    [SerializeField]
    private float[] _qualityToSliderMap;  // qualityLevel → 滑杆值的映射
    
    [SerializeField]
    private float _minValue;
    
    [SerializeField]
    private float _maxValue;
    
    // 获取当前 qualityLevel 对应的滑杆值
    protected float GetSliderForQuality(int level)
    {
        if (_qualityToSliderMap != null && level >= 0 && level < _qualityToSliderMap.Length)
            return _qualityToSliderMap[level];
        return _minValue;
    }
}
```

---

## 7. 完整组件清单 (Complete Component List)

所有组件的完整清单，按功能分类：

### 7.1 渲染功能开关组件 (ToggleQualityComponent 继承)

| # | 类名 | Feature Name | 阈值 | 说明 |
|---|------|-------------|------|------|
| 1 | `AAQualitySettingComponent` | `"AA"` | >=1 启用 | 抗锯齿总开关 |
| 2 | `AABBQualitySettingComponent` | `"AABB"` | >=1 启用 | AABB 包围盒 |
| 3 | `AADebugVisualizeQualitySettingComponent` | `"AADebugVisualize"` | >=1 启用 | AA 调试可视化 |
| 4 | `AOHDRQualitySettingComponent` | `"AOHDR"` | >=1 启用 | AO HDR |
| 5 | `BloomQualitySettingComponent` | `"Bloom"` | >=1 启用 | Bloom 泛光 |
| 6 | `BlurQualitySettingComponent` | `"Blur"` | >=1 启用 | 模糊 |
| 7 | `ContactShadowQualitySettingComponent` | `"ContactShadow"` | >=1 启用 | 接触阴影 |
| 8 | `DFAOQualitySettingComponent` | `"DFAO"` | >=1 启用 | DFAO |
| 9 | `DepthOfFieldQualitySettingComponent` | `"DepthOfField"` | >=1 启用 | 景深 |
| 10 | `DistortionQualitySettingComponent` | `"Distortion"` | >=1 启用 | 扭曲失真 |
| 11 | `DynamicResolutionQualitySettingComponent` | `"DynamicResolution"` | >=1 启用 | 动态分辨率 |
| 12 | `EnvironmentLightingQualitySettingComponent` | `"EnvironmentLighting"` | >=1 启用 | 环境光照 |
| 13 | `FoliageQualitySettingComponent` | `"Foliage"` | >=1 启用 | 植被 |
| 14 | `GlowQualitySettingComponent` | `"Glow"` | >=1 启用 | 发光特效 |
| 15 | `GPUParticleQualitySettingComponent` | `"GPUParticle"` | >=1 启用 | GPU 粒子 |
| 16 | `LightFunctionQualitySettingComponent` | `"LightFunction"` | >=1 启用 | 光照函数 |
| 17 | `MobileLightningSettingComponent` | `"MobileLightning"` | >=1 启用 | 移动端闪电 |
| 18 | `ResolutionQualitySettingComponent` | `"Resolution"` | >=1 启用 | 分辨率缩放 |
| 19 | `SSAOQualitySettingComponent` | `"SSAO"` | >=1 启用 | 屏幕空间环境光遮蔽 |
| 20 | `SSSQualitySettingComponent` | `"SSS"` | >=1 启用 | 次表面散射 |
| 21 | `ShadowMapQualitySettingComponent` | `"ShadowMap"` | >=1 启用 | 阴影贴图 |
| 22 | `ShadowQualitySettingComponent` | `"Shadow"` | >=1 启用 | 阴影质量 |
| 23 | `SkinQualitySettingComponent` | `"Skin"` | >=1 启用 | 皮肤渲染 |
| 24 | `TemporalAAQualitySettingComponent` | `"TemporalAA"` | >=1 启用 | 时域抗锯齿 |
| 25 | `TranslucencyQualitySettingComponent` | `"Translucency"` | >=1 启用 | 半透明渲染 |
| 26 | `VolumetricCloudQualitySettingComponent` | `"VolumetricCloud"` | >=1 启用 | 体积云 |
| 27 | `VolumetricFogQualitySettingComponent` | `"VolumetricFog"` | >=1 启用 | 体积雾 |

### 7.2 枚举值组件 (EnumQualityComponent\<T\>)

| # | 类名 | Feature Name | 枚举类型 | 映射说明 |
|---|------|-------------|---------|---------|
| 28 | `DecalQualitySettingComponent` | `"Decal"` | `DecalQuality` | qualityLevel → DecalQuality 枚举 |
| 29 | `LightQualitySettingComponent` | `"Light"` | `LightQuality` | qualityLevel → LightQuality 枚举 |
| 30 | `MeshQualitySettingComponent` | `"Mesh"` | `MeshQuality` | qualityLevel → MeshQuality 枚举 |
| 31 | `ReflectionQualitySettingComponent` | `"Reflection"` | `ReflectionQuality` | qualityLevel → ReflectionQuality 枚举 |

#### 相关枚举定义

```csharp
// Decal 质量等级
public enum DecalQuality : int
{
    Off = 0,
    Low = 1,
    Medium = 2,
    High = 3,
    VeryHigh = 4
}

// Light 质量等级
public enum LightQuality : int
{
    Off = 0,
    Low = 1,
    Medium = 2,
    High = 3
}

// Mesh 质量等级
public enum MeshQuality : int
{
    VeryLow = 0,
    Low = 1,
    Medium = 2,
    High = 3,
    VeryHigh = 4
}

// Reflection 质量等级
public enum ReflectionQuality : int
{
    Off = 0,
    Low = 1,
    Medium = 2,
    High = 3,
    VeryHigh = 4
}
```

### 7.3 滑杆值组件 (SliderQualityComponent)

| # | 类名 | Feature Name | 数值范围 | 映射说明 |
|---|------|-------------|---------|---------|
| 32 | `CascadeDistanceQualitySettingComponent` | `"CascadeDistance"` | 0.0-1.0 | 级联阴影距离 0-100% |
| 33 | `LODBiasQualitySettingComponent` | `"LODBias"` | -2.0-2.0 | LOD 偏移量 |

### 7.4 组件详细实现模式

#### 模式 A: 直接调用 OverrideFeatureTier (标准模式)

所有 ToggleQualityComponent 子类遵循此模式:
```csharp
// 示例: BloomQualitySettingComponent
protected override void ApplyQualityLevel(int level, bool immediate)
{
    int value = (level >= _enableThreshold) ? 1 : 0;
    HGRenderPipelineSettingHub.OverrideFeatureTier("Bloom", value, immediate);
}
```

#### 模式 B: 枚举映射模式

EnumQualityComponent\<T\> 子类:
```csharp
// 示例: DecalQualitySettingComponent
[SerializeField]
private DecalQuality[] _qualityToEnumMap = new DecalQuality[]
{
    DecalQuality.Off,      // level 0
    DecalQuality.Low,      // level 1
    DecalQuality.Medium,   // level 2
    DecalQuality.High,     // level 3
    DecalQuality.VeryHigh  // level 4
};

protected override void ApplyQualityLevel(int level, bool immediate)
{
    var quality = _qualityToEnumMap[level];
    HGRenderPipelineSettingHub.OverrideFeatureTier("Decal", (int)quality, immediate);
}
```

#### 模式 C: 滑杆值模式

SliderQualityComponent 子类:
```csharp
// 示例: LODBiasQualitySettingComponent
[SerializeField]
private float[] _qualityToSliderMap = new float[]
{
    2.0f,   // level 0 → 最大正偏移 (低质量)
    1.0f,   // level 1
    0.0f,   // level 2 → 无偏移 (中等)
    -0.5f,  // level 3
    -1.0f   // level 4 → 负偏移 (高质量)
};
```

---

## 8. Gameplay 联动 (Logic Quality & Thermal)

### 8.1 LogicQualityLevel 与质量联动

LogicQualityLevel 用于 Gameplay 层面的性能逻辑，与渲染质量联动但不直接等效：

| LogicQualityLevel | 典型质量等级 | Gameplay 影响 |
|-------------------|-------------|---------------|
| Economy (0) | veryLow (0)–low (1) | 降低 LOD 距离，减少 NPC/特效数量 |
| Balanced (1) | low (1)–middle (2) | 标准游戏体验 |
| Performance (2) | middle (2)–high (3) | 优先保障帧率 |
| Max (3) | high (3)–veryHigh (4) | 最高画质 |

### 8.2 ThermalState 热状态响应

热状态由系统或 ThermalManager 提供，QualityManager 轮询更新：

```csharp
public void SetThermalState(ThermalState state)
{
    _currentThermalState = state;
    
    foreach (var component in _allComponents)
    {
        // 通知组件热状态变化
        component.OnThermalStateChanged(state);
    }
    
    // 热状态可能导致降级
    if (state == ThermalState.GameSerious)
    {
        // 紧急降级 - 强制关闭部分特性
        OverrideQualityTier(0, true); // 降到最低
    }
}
```

### 8.3 LogicQualityConst 关键常量

| 常量 | 用途 |
|------|------|
| `"EnableSoftwareDynamicResolution"` | 控制动态分辨率开关 - 渲染管线特性名 |
| `"EnableThermalControl"` | 热控制总开关特性名 |
| `ThermalCheckInterval` (5.0f) | 热状态检查间隔秒数 |

---

## 9. PoolCore 列表池初始化

ListPoolInitializer_RuntimeQuality.cs 负责在 QualityManager 初始化前预分配 `List<int>` 对象池：

```csharp
public static class ListPoolInitializer_RuntimeQuality
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void Initialize()
    {
        // 预分配 int 类型的 ListPool
        // QualityManager 在后续初始化中使用 List<int> 进行评分排序
        ListPool<int>.Preallocate(16, 4);  // 容量 16, 预分配 4 个
    }
}
```

---

## 10. 与渲染管线集成 (Pipeline Integration)

### 10.1 HGRenderPipelineSettingHub.OverrideFeatureTier

这是整个质量系统的**核心集成点**。该 API 接受三个参数:

| 参数 | 类型 | 说明 |
|------|------|------|
| `featureName` | `string` | 特性名称标识符 (如 "Bloom", "SSAO") |
| `tier` | `int` | 目标等级 (0=关闭, 1=低, 2=中, 3=高, 4=极高) |
| `immediate` | `bool` | 是否立即生效 (true=立即; false=下一帧) |

对应到渲染管线内部的实现逻辑:
```csharp
public static class HGRenderPipelineSettingHub
{
    private static Dictionary<string, RenderPipelineFeature> s_features;
    
    public static void OverrideFeatureTier(string featureName, int tier, bool immediate)
    {
        if (s_features.TryGetValue(featureName, out var feature))
        {
            feature.OverrideTier(tier);
            if (immediate)
                feature.Apply();
        }
    }
}
```

### 10.2 Unity QualitySettings 集成

部分组件 (如 ShadowQualitySettingComponent) 在调用 OverrideFeatureTier 之外，还调用:
```csharp
UnityEngine.QualitySettings.shadowResolution = ShadowResolution.VeryHigh;
UnityEngine.QualitySettings.shadowDistance = 100f;
UnityEngine.QualitySettings.shadowCascades = 4;
UnityEngine.QualitySettings.shadowProjection = ShadowProjection.StableFit;
UnityEngine.QualitySettings.pixelLightCount = 4;
UnityEngine.QualitySettings.anisotropicFiltering = AnisotropicFiltering.Enable;
UnityEngine.QualitySettings.antiAliasing = 4;
UnityEngine.QualitySettings.lodBias = 1.0f;
UnityEngine.QualitySettings.maximumLODLevel = 0;
UnityEngine.QualitySettings.masterTextureLimit = 0;
UnityEngine.QualitySettings.vSyncCount = 1;
```

### 10.3 HGStreamingSettings 集成

部分组件涉及流式资源加载设置:
```csharp
HGStreamingSettings.SetTextureQuality(level);
HGStreamingSettings.SetMeshQuality(level);
```

### 10.4 XR 集成

移动端/XR 相关组件:
```csharp
UnityEngine.XR.XRSettings.renderScale = 0.8f;
UnityEngine.XR.XRSettings.eyeTextureResolutionScale = 0.8f;
```

---

## 11. 1:1 Replication Notes (Clean Room 实现指南)

### 11.1 命名空间

```
目标: HG.Rendering.Runtime
实现: 自定义命名空间 (避免冲突)
```

### 11.2 核心 API 桩 (Stub)

必须实现的 API 端点:

```csharp
// ─── HGRenderPipelineSettingHub (Stub) ───
public static class HGRenderPipelineSettingHub
{
    private static Dictionary<string, int> s_featureTiers = new Dictionary<string, int>();
    private static Dictionary<string, Action<int>> s_featureHandlers = new Dictionary<string, Action<int>>();
    
    public static void OverrideFeatureTier(string featureName, int tier, bool immediate)
    {
        s_featureTiers[featureName] = tier;
        
        if (s_featureHandlers.TryGetValue(featureName, out var handler))
            handler.Invoke(tier);
            
        if (immediate)
            ApplyImmediate(featureName, tier);
    }
    
    public static void RegisterFeature(string featureName, Action<int> onTierChanged)
    {
        s_featureHandlers[featureName] = onTierChanged;
        // 如果有已存的值，立即回调
        if (s_featureTiers.TryGetValue(featureName, out int currentTier))
            onTierChanged.Invoke(currentTier);
    }
    
    private static void ApplyImmediate(string featureName, int tier)
    {
        // 立即生效的实现
        // 在渲染管线循环中处理
    }
    
    public static int GetFeatureTier(string featureName)
    {
        return s_featureTiers.TryGetValue(featureName, out int tier) ? tier : 0;
    }
}
```

### 11.3 设备数据文件格式

DeviceList_zip.bytes 为 GZip 压缩的 JSON，解压后格式:

```json
{
  "version": 1,
  "devices": [
    {
      "deviceName": "SM-G998B",
      "deviceModel": "samsung g998b",
      "platform": "Android",
      "gpuName": "Adreno 660",
      "gpuVendor": 514,
      "gpuMemorySize": 4096,
      "systemMemorySize": 12288,
      "screenWidth": 1440,
      "screenHeight": 3200,
      "screenDPI": 525,
      "processorCount": 8,
      "processorFrequency": 2841
    }
  ]
}
```

### 11.4 启动流程

```
// 1. ListPoolInitializer_RuntimeQuality.Initialize()
//    → 预分配 List<int> 对象池
//
// 2. QualityManager.Instance.Initialize()
//    → 在游戏启动时尽早调用 (SceneManager.sceneLoaded 或 自定义启动流程)
//
// 3. QualityManager.MatchQuality()
//    → 自动匹配设备
//
// 4. QualityManager.OverrideQualityTier(qualityLevel)
//    → 设置所有组件的质量等级
//
// 5. 各 QualityTierComponent.Awake()
//    → 自动注册到 QualityManager
//
// 6. QualityManager 初始化后调用 RefreshAll()
//    → 通知所有组件应用质量设置
```

### 11.5 注意事项

1. **生命周期管理**: QualityTierComponent 在 Awake 中注册到 QualityManager，必须在 OnDestroy 中注销，避免悬挂引用
2. **初始化顺序**: QualityManager 必须在任何 QualityTierComponent 之前初始化
3. **热状态响应延迟**: 为避免频繁升降级，热状态变化应有延迟 (5 秒检查间隔)
4. **设备数据更新**: DeviceList_zip.bytes 可通过远程配置更新，QualityManager 支持重新初始化
5. **线程安全**: QualityManager 的组件注册/注销操作应在主线程进行
6. **字符串常量**: 所有 FeatureName 应当作为常量集中管理，避免硬编码
7. **资源释放**: 设备列表 JSON 解析后应及时释放 TextAsset 资源

---

## 附录 A: 文件引用清单

| # | 文件名 | 路径 | 关键内容 |
|---|--------|------|---------|
| 1 | `QualityManager.cs` | `Scripts/Quality/` | 单例管理器、初始化、匹配、覆盖 |
| 2 | `DeviceInfo.cs` | `Scripts/Quality/` | 设备信息结构、GPU 归一化、评分 |
| 3 | `DeviceMatchRules.cs` | `Scripts/Quality/` | RankingRule[] + MemoryRule[] |
| 4 | `DeviceMatchResult.cs` | `Scripts/Quality/` | 匹配结果 (device, score, qualityLevel) |
| 5 | `DeviceQualityMap.cs` | `Scripts/Quality/` | Score → QualityLevel 映射 |
| 6 | `DeviceQualityMapItem.cs` | `Scripts/Quality/` | 映射条目 (minScore, maxScore, qualityLevel) |
| 7 | `RankingRule.cs` | `Scripts/Quality/` | GPU 排名规则 (platform, gpuPattern, baseScore) |
| 8 | `MemoryRule.cs` | `Scripts/Quality/` | 内存规则 (platform, minMemoryMB, scoreBonus) |
| 9 | `QualityConst.cs` | `Scripts/Quality/` | 常量定义 |
| 10 | `QualityUtility.cs` | `Scripts/Quality/` | 工具方法 |
| 11 | `ListUtils.cs` | `Scripts/Quality/` | 列表操作扩展方法 |
| 12 | `QualityTierComponent.cs` | `Scripts/Quality/Components/` | 抽象基类 |
| 13 | `ToggleQualityComponent.cs` | `Scripts/Quality/Components/` | 开关型基类 |
| 14 | `EnumQualityComponent.cs` | `Scripts/Quality/Components/` | 枚举型泛型基类 |
| 15 | `SliderQualityComponent.cs` | `Scripts/Quality/Components/` | 滑杆型基类 |
| 16-48 | `*QualitySettingComponent.cs` (33 files) | `Scripts/Quality/Components/` | 具体组件实现 |
| 49 | `LogicQualityLevel.cs` | `Gameplay/BeyondPerformance/` | LogicQualityLevel 枚举 |
| 50 | `ThermalState.cs` | `Gameplay/BeyondPerformance/` | ThermalState 枚举 |
| 51 | `LogicQualityConst.cs` | `Gameplay/BeyondPerformance/` | 逻辑质量常量 |
| 52 | `ListPoolInitializer_RuntimeQuality.cs` | `PoolCore/` | List<int> 对象池初始化 |

---

## 附录 B: Feature Name 完整索引

| Feature Name | 类型 | 组件数 | 对应组件 |
|-------------|------|--------|---------|
| `"AA"` | Toggle | 1 | AAQualitySettingComponent |
| `"AABB"` | Toggle | 1 | AABBQualitySettingComponent |
| `"AADebugVisualize"` | Toggle | 1 | AADebugVisualizeQualitySettingComponent |
| `"AOHDR"` | Toggle | 1 | AOHDRQualitySettingComponent |
| `"Bloom"` | Toggle | 1 | BloomQualitySettingComponent |
| `"Blur"` | Toggle | 1 | BlurQualitySettingComponent |
| `"CascadeDistance"` | Slider | 1 | CascadeDistanceQualitySettingComponent |
| `"ContactShadow"` | Toggle | 1 | ContactShadowQualitySettingComponent |
| `"DFAO"` | Toggle | 1 | DFAOQualitySettingComponent |
| `"Decal"` | Enum | 1 | DecalQualitySettingComponent |
| `"DepthOfField"` | Toggle | 1 | DepthOfFieldQualitySettingComponent |
| `"Distortion"` | Toggle | 1 | DistortionQualitySettingComponent |
| `"DynamicResolution"` | Toggle | 1 | DynamicResolutionQualitySettingComponent |
| `"EnvironmentLighting"` | Toggle | 1 | EnvironmentLightingQualitySettingComponent |
| `"Foliage"` | Toggle | 1 | FoliageQualitySettingComponent |
| `"GPUParticle"` | Toggle | 1 | GPUParticleQualitySettingComponent |
| `"Glow"` | Toggle | 1 | GlowQualitySettingComponent |
| `"Light"` | Enum | 1 | LightQualitySettingComponent |
| `"LightFunction"` | Toggle | 1 | LightFunctionQualitySettingComponent |
| `"LODBias"` | Slider | 1 | LODBiasQualitySettingComponent |
| `"Mesh"` | Enum | 1 | MeshQualitySettingComponent |
| `"MobileLightning"` | Toggle | 1 | MobileLightningSettingComponent |
| `"Reflection"` | Enum | 1 | ReflectionQualitySettingComponent |
| `"Resolution"` | Toggle | 1 | ResolutionQualitySettingComponent |
| `"SSAO"` | Toggle | 1 | SSAOQualitySettingComponent |
| `"SSS"` | Toggle | 1 | SSSQualitySettingComponent |
| `"Shadow"` | Toggle | 1 | ShadowQualitySettingComponent |
| `"ShadowMap"` | Toggle | 1 | ShadowMapQualitySettingComponent |
| `"Skin"` | Toggle | 1 | SkinQualitySettingComponent |
| `"TemporalAA"` | Toggle | 1 | TemporalAAQualitySettingComponent |
| `"Translucency"` | Toggle | 1 | TranslucencyQualitySettingComponent |
| `"VolumetricCloud"` | Toggle | 1 | VolumetricCloudQualitySettingComponent |
| `"VolumetricFog"` | Toggle | 1 | VolumetricFogQualitySettingComponent |

---

*文档生成完毕*  
*生成日期: 2026-06-12*