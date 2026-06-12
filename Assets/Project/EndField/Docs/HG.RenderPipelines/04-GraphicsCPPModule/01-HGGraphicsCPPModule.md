# HGGraphicsCPPModule — C++ 原生桥接层完整文档

> **项目**: FractalMiner / EndField  
> **路径**: `Assets/Scripts/UnityEngine.HGGraphicsCPPModule/UnityEngine/HyperGryphEngineCode/`  
> **文件数**: 135 个 C# 文件  
> **命名空间**: `UnityEngine.HyperGryphEngineCode`  
> **核心功能**: 为 C++ 渲染管线 (HGGraphicsCPP) 提供 Blittable 数据契约，实现 C# 层与 C++ 原生层之间的零拷贝数据传输

---

## 目录

1. [设计原则](#1-设计原则)
2. [核心入口：HGRenderGraphCPP](#2-核心入口hggrendergraphcpp)
3. [渲染路径枚举：HGRenderPathInternalCPP](#3-渲染路径枚举hggrenderpathinternalcpp)
4. [环境配置系统（Environment Phase）](#4-环境配置系统environment-phase)
5. [体积组件系统（Volume Components）](#5-体积组件系统volume-components)
6. [每帧渲染参数传递](#6-每帧渲染参数传递)
7. [着色器常量缓冲区](#7-着色器常量缓冲区)
8. [DLSS / FSR3 / 帧生成工具](#8-dlss--fsr3--帧生成工具)
9. [调试系统](#9-调试系统)
10. [地形子系统](#10-地形子系统)
11. [Enum 完整定义表](#11-enum-完整定义表)
12. [完整数据结构引用表](#12-完整数据结构引用表)
13. [与 C++ 原生层的数据同步协议](#13-与-c-原生层的数据同步协议)

---

## 1. 设计原则

### 1.1 Blittable 设计

所有结构体（struct）均遵循 **Blittable** 原则：

- **仅包含值类型字段**：`int`, `float`, `bool`, `Color`, `Vector2`, `Vector3`, `Vector4`, `Matrix4x4`, `SphericalHarmonicsL2`, `GraphicsFormat`, 枚举等。
- **指针字段使用 `IntPtr` 或 `unsafe` 指针**：`HGLightConfigCPP*`, `int*`, `float*` 等。指针本身是 blittable（作为 `IntPtr` 或 `T*` 进行封送）。
- **固定大小缓冲区使用 `fixed` 关键字**：如 `fixed float _WindMotorParams0[16]` 保证内存连续。
- **`bool` 的处理**：C# 中的 `bool` 在 blittable 上下文中与 C++ 的 `bool`（1 字节）布局兼容，但在同一个 struct 中需要注意字节对齐。

### 1.2 属性标记

每个 struct 都标注了以下特性：

| 特性 | 用途 |
|------|------|
| `[UsedByNativeCode]` | 标记该类型由 C++ 原生代码直接使用 |
| `[NativeHeader("...")]` | 声明对应的 C++ 头文件位置 |
| `[FreeFunction("...")]` | 映射到 C++ 全局函数 |
| `[StructLayout(LayoutKind.Sequential)]` | 强制内存顺序布局（部分工具类使用） |

### 1.3 指针传递机制

所有环境配置 struct 均通过 **不安全指针（`T*`）** 传递给 C++ 层，利用 `fixed` 语句固定托管内存地址，实现零拷贝：

```csharp
// C# 端写入
unsafe
{
    fixed (HGEnvironmentPhaseCPP* ptr = &envPhase)
    {
        HGRenderGraphCPP.HGRenderPath_Render(ptr, ...);
    }
}
```

```cpp
// C++ 端接收
void HGRenderPath_Render(HGRenderPathParamsCPP* params)
{
    params->envPhase->lightConfig->directColor = ...;
}
```

---

## 2. 核心入口：HGRenderGraphCPP

**文件**: `HGRenderGraphCPP.cs`  
**类型**: `class`（非静态），所有方法均为 `static`  
**C++ 头文件**: `Modules/HGGraphicsCPP/Public/HGRenderGraph.h`

### 2.1 内存分配

| 方法 | 签名 | 用途 |
|------|------|------|
| `AllocateTempFromCSharp` | `static IntPtr AllocateTempFromCSharp(long size)` | 从 C++ 侧分配临时内存，返回指针 |
| `AllocateTempFromCSharp<T>` | `static unsafe T* AllocateTempFromCSharp<T>() where T : unmanaged` | 泛型版本，类型参数约束为 `unmanaged` |

### 2.2 渲染路径生命周期

| 方法 | 签名 | 用途 |
|------|------|------|
| `HGRenderPath_Create` | `static unsafe long HGRenderPath_Create(HGRenderPathInternalCPP renderPath, HGRenderPipelineRuntimeResourcesCPP* defaultResources, HGRenderPipelineDebugResourcesCPP* debugResources)` | 创建 C++ 侧的渲染路径实例，返回句柄 |
| `HGRenderPath_BeforeCulling` | `static unsafe void HGRenderPath_BeforeCulling(long _ptr, HGRenderPathBeforeCullingParamsCPP* renderPathBeforeCullingParams, IntPtr camera, IntPtr uiCamera, IntPtr occlusionCamera)` | 在视锥体裁剪前更新参数 |
| `HGRenderPath_Render` | `static unsafe void HGRenderPath_Render(long _ptr, HGRenderPathParamsCPP* renderPathParams, HGRenderPathBeforeCullingParamsCPP* renderPathBeforeCullingParams, IntPtr camera, IntPtr renderContext, IntPtr _cmd)` | 执行渲染 |
| `HGRenderPath_Destroy` | `static void HGRenderPath_Destroy(long _ptr)` | 销毁渲染路径 |

### 2.3 简单 UI 渲染路径

| 方法 | 签名 | 用途 |
|------|------|------|
| `HGRenderPathSimpleUI_Create` | `static long HGRenderPathSimpleUI_Create()` | 创建简单 UI 渲染路径 |
| `HGRenderPathSimpleUI_Render` | `static void HGRenderPathSimpleUI_Render(long _ptr, IntPtr camera, IntPtr renderContext, IntPtr _cmd)` | 渲染简单 UI |
| `HGRenderPathSimpleUI_Destroy` | `static void HGRenderPathSimpleUI_Destroy(long _ptr)` | 销毁 |

### 2.4 Custom Depth Only Pass

| 方法 | 签名 | 用途 |
|------|------|------|
| `CustomDepthRequestManager_Create` | `static long CustomDepthRequestManager_Create()` | 创建自定义深度请求管理器 |
| `CustomDepthRequestManager_Remove` | `static void CustomDepthRequestManager_Remove(long mgr)` | 移除管理器 |
| `CustomDepthRequestManager_RequestSystem` | `static unsafe uint CustomDepthRequestManager_RequestSystem(long mgr, CustomDepthOnlySystemRequest* request)` | 请求系统深度渲染，返回索引 |
| `CustomDepthRequestManager_RemoveSystem` | `static void CustomDepthRequestManager_RemoveSystem(long mgr, uint idx)` | 移除系统请求 |
| `CustomDepthRequestManager_UpdateSystem` | `static void CustomDepthRequestManager_UpdateSystem(long mgr, uint idx, Vector3 position)` | 更新系统位置 |
| `CustomDepthRequestManager_ToggleSystem` | `static void CustomDepthRequestManager_ToggleSystem(long mgr, uint idx, bool flag)` | 开关系统 |

### 2.5 Custom Draw Texture Pass

| 方法 | 签名 | 用途 |
|------|------|------|
| `CustomDrawRTManager_Create` | `static long CustomDrawRTManager_Create()` | 创建自定义 RT 管理器 |
| `CustomDrawRTManager_Destroy` | `static void CustomDrawRTManager_Destroy(long ptr)` | 销毁 |
| `CustomDrawRTManager_AllocateRenderTexture` | `static RenderTexture CustomDrawRTManager_AllocateRenderTexture(long manager, int width, int height, int depth, int mipCount, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat)` | 分配渲染纹理 |
| `CustomDrawRTManager_ReleaseRenderTexture` | `static void CustomDrawRTManager_ReleaseRenderTexture(long manager, RenderTexture rt)` | 释放渲染纹理 |
| `CustomDrawRTManager_DrawTexture` | `static void CustomDrawRTManager_DrawTexture(long manager, RenderTexture rt, in Rect rect, Texture texture, Material material, int pass)` | 绘制纹理 |
| `CustomDrawRTManager_ClearTexture` | `static void CustomDrawRTManager_ClearTexture(long manager, RenderTexture rt, in Color color)` | 清除纹理 |

### 2.6 Ink Simulation Pass

| 方法 | 签名 | 用途 |
|------|------|------|
| `InkSimulationPass_Destroy` | `static void InkSimulationPass_Destroy(long _ptr)` | 销毁墨迹模拟 Pass |

---

## 3. 渲染路径枚举：HGRenderPathInternalCPP

**文件**: `HGRenderPathInternalCPP.cs`

```csharp
public enum HGRenderPathInternalCPP
{
    Forward = 0,                      // 前向渲染
    UI = 1,                           // UI 渲染
    UI3D = 2,                         // 3D UI 渲染
    DefaultDeferred = 3,              // 默认延迟渲染
    OnePassDeferredSubpass = 4,        // 单 Pass 延迟子 Pass
    DebugFullScreen = 5,               // 调试全屏
    DebugRegularDefaultDeferred = 6,   // 调试常规默认延迟
    DebugRegularOnePassDeferredSubpass = 7, // 调试常规单 Pass 延迟子 Pass
    Count = 8                          // 总数
}
```

---

## 4. 环境配置系统（Environment Phase）

### 4.1 HGEnvironmentPhaseCPP — 环境阶段聚合根

**文件**: `HGEnvironmentPhaseCPP.cs`  
**C++ 头文件**: `Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h`

该 struct 是所有环境配置的 **聚合根**，包含指向各个子配置的指针：

```
HGEnvironmentPhaseCPP
├── lightConfig*                 → HGLightConfigCPP
├── skyConfig*                   → HGSkyConfigCPP
├── atmosphereConfig*            → HGAtmosphereConfigCPP
├── fogConfig*                   → HGFogConfigCPP
├── heightFogConfig*             → HGHeightFogConfigCPP
├── volumetricFogConfig*         → HGVolumetricFogConfigCPP
├── cloudConfig*                 → HGCloudConfigCPP
├── celestialConfig*             → HGCelestialConfigCPP
├── lightShaftConfig*            → HGLightShaftConfigCPP
├── anamorphicStreaksConfig*     → HGAnamorphicStreaksConfigCPP
├── starConfig*                  → HGStarConfigCPP
├── autoExposureConfig*          → HGAutoExposureConfigCPP
├── colorGradingConfig*          → HGColorGradingConfigCPP
└── contactShadowConfig*         → HGContactShadowConfigCPP
```

### 4.2 HGLightConfigCPP — 光照配置

| 字段 | 类型 | 用途 |
|------|------|------|
| `preExposure` | `float` | 预曝光值 |
| `directColor` | `Color` | 直射光颜色 |
| `directIntensity` | `float` | 直射光强度 |
| `directSpecularIntensity` | `float` | 直射光高光强度 |
| `directSoftSourceRadius` | `float` | 直射光源软半径 |
| `directPitchYaw` | `Vector2` | 直射光俯仰/偏航角 |
| `indirectDiffuseFactor` | `float` | 间接漫反射因子 |
| `indirectSpecularFactor` | `float` | 间接高光因子 |
| `rotationDirect` | `Quaternion` | 直射光旋转 |
| `forwardDirect` | `Vector3` | 直射光前方向量 |
| `localToWorld` | `Matrix4x4` | 局部到世界矩阵 |
| `rotationAtmosphere` | `Quaternion` | 大气旋转 |
| `rotationLightShaft` | `Quaternion` | 光柱旋转 |
| `rotationSunDisc` | `Quaternion` | 日轮旋转 |
| `rotationLensFlare` | `Quaternion` | 镜头光晕旋转 |
| `rotationCloudShadow` | `Quaternion` | 云阴影旋转 |
| `rotationHeightFogDirectionalInscattering` | `Quaternion` | 高度雾方向散射旋转 |
| `cloudShadowPitchYawMode` | `HGLightConfigPitchYawModeCPP` | 云阴影俯仰偏航模式 |
| `cloudShadowPitchYaw` | `Vector2` | 云阴影俯仰偏航 |

### 4.3 HGSkyConfigCPP — 天空配置

| 字段 | 类型 | 用途 |
|------|------|------|
| `skyDistance` | `float` | 天空距离 |
| `skyBakedIndirectIntensity` | `float` | 天空烘焙间接强度 |
| `skyDirectIntensity` | `float` | 天空直接强度 |
| `useCustomIVDefaultSH` | `bool` | 使用自定义 IV 默认球谐 |
| `customIVDefaultSH` | `SphericalHarmonicsL2` | 自定义 IV 默认球谐 |
| `skyMaterialType` | `HGSkyConfigSkyMaterialTypeCPP` | 天空材质类型 |
| `proceduralSkyLuxFactor` | `float` | 程序化天空 Lux 因子 |
| `enableSunDisc` | `bool` | 启用日轮 |
| `sunDiscRadius` | `float` | 日轮半径 |
| `sunDiscRampIntensity` | `float` | 日轮渐变强度 |
| `sunDiscColor` | `Color` | 日轮颜色 |
| `skyboxBrightness` | `float` | 天空盒亮度 |
| `skyboxTintColor` | `Color` | 天空盒色调 |
| `skyboxRotation` | `float` | 天空盒旋转 |
| `visibleBox` | `Vector3` | 可见盒大小 |
| `reflectionType` | `HGSkyConfigReflectionTypeCPP` | 反射类型 |
| `reflectionMap` | `IntPtr` | 反射贴图指针 |
| `culloff` | `float` | 裁剪偏移 |
| `skyAmbientSH` | `SphericalHarmonicsL2` | 天空环境球谐 |
| `skyboxCubeMap` | `IntPtr` | 天空盒立方体贴图指针 |

### 4.4 HGAtmosphereConfigCPP — 大气配置

| 字段 | 类型 | 用途 |
|------|------|------|
| `groundRadius` | `float` | 地面半径 |
| `groundAlbedo` | `Color` | 地面反照率 |
| `outerSunIrradianceColor` | `Color` | 外层太阳辐照度颜色 |
| `atmosphereHeight` | `float` | 大气高度 |
| `multiScatteringFactor` | `float` | 多次散射因子 |
| `rayleighScatteringScale` | `float` | 瑞利散射缩放 |
| `rayleighScattering` | `Color` | 瑞利散射颜色 |
| `rayleighExponentialDistribution` | `float` | 瑞利指数分布 |
| `mieScatteringScale` | `float` | Mie 散射缩放 |
| `mieScattering` | `Color` | Mie 散射颜色 |
| `mieAbsorptionScale` | `float` | Mie 吸收缩放 |
| `mieAbsorption` | `Color` | Mie 吸收颜色 |
| `mieAnisotropy` | `float` | Mie 各向异性 |
| `mieExponentialDistribution` | `float` | Mie 指数分布 |
| `ozoneAbsorptionScale` | `float` | 臭氧吸收缩放 |
| `ozoneAbsorption` | `Color` | 臭氧吸收颜色 |
| `tentTipAltitude` | `float` | 帐篷型曲线顶点高度 |
| `tentTipValue` | `float` | 帐篷型曲线顶点值 |
| `tentWidth` | `float` | 帐篷型曲线宽度 |

### 4.5 HGFogConfigCPP — 雾配置

| 字段 | 类型 | 用途 |
|------|------|------|
| `enable` | `bool` | 启用雾 |
| `startDistance` | `float` | 雾起始距离 |
| `startHeight` | `float` | 雾起始高度 |
| `fallOffHeight` | `float` | 雾衰减高度 |
| `fallOffDistance` | `float` | 雾衰减距离 |
| `mieScattering` | `Color` | Mie 散射颜色 |
| `mieScatteringScale` | `float` | Mie 散射缩放 |
| `mieAnisotropy` | `float` | Mie 各向异性 |
| `rayleighScattering` | `Color` | 瑞利散射颜色 |
| `rayleighScatteringScale` | `float` | 瑞利散射缩放 |
| `inscatterAmbientColor` | `Color` | 内散射环境颜色 |

### 4.6 HGHeightFogConfigCPP — 高度雾配置

| 字段 | 类型 | 用途 |
|------|------|------|
| `enable` | `bool` | 启用 |
| `heightFogStartHeight` | `float` | 起始高度 |
| `heightFogDensity` | `float` | 密度 |
| `heightFogFalloff` | `float` | 衰减率 |
| `heightFogStartHeightSecond` | `float` | 第二层起始高度 |
| `heightFogDensitySecond` | `float` | 第二层密度 |
| `heightFogFalloffSecond` | `float` | 第二层衰减率 |
| `heightFogInscatter` | `Color` | 内散射颜色 |
| `heightFogMaxOpacity` | `float` | 最大不透明度 |
| `heightFogStartDistance` | `float` | 起始距离 |
| `heightFogStartTransition` | `float` | 起始过渡 |
| `heightFogCutoffDistance` | `float` | 截止距离 |
| `heightFogCutoffTransition` | `float` | 截止过渡 |
| `heightFogCullingFarClipPlane` | `float` | 远裁剪面（用于雾裁剪） |
| `heightFogDirectionalInscatteringExponent` | `float` | 方向散射指数 |
| `heightFogDirectionalInscatteringStartDistance` | `float` | 方向散射起始距离 |
| `heightFogDirectionalInscattering` | `Color` | 方向散射颜色 |
| `enableVolumetricFog` | `bool` | 启用体积雾 |
| `volumetricFogScatteringDistribution` | `float` | 体积雾散射分布 |
| `volumetricFogAlbedo` | `Color` | 体积雾反照率 |
| `volumetricFogEmissive` | `Color` | 体积雾自发光 |
| `volumetricFogExtinctionScale` | `float` | 体积雾消光缩放 |
| `volumetricFogDistance` | `float` | 体积雾距离 |
| `volumetricFogStartDistance` | `float` | 体积雾起始距离 |
| `volumetricFogNearFadeInDistance` | `float` | 体积雾近淡入距离 |
| `volumetricFogDirectLightingScatteringIntensity` | `float` | 直射光散射强度 |
| `volumetricFogSkyLightingScatteringIntensity` | `float` | 天空光散射强度 |
| `enableFlowNoise` | `bool` | 启用流动噪声 |
| `flowNoiseIntensity` | `float` | 流动噪声强度 |
| `flowNoiseDistance` | `float` | 流动噪声距离 |
| `flowNoiseTilling` | `float` | 流动噪声平铺 |
| `flowNoiseHorizontalDirAngle` | `float` | 流动噪声水平方向角 |
| `flowNoiseVerticalDirAngle` | `float` | 流动噪声垂直方向角 |
| `flowNoiseDir` | `Vector3` | 流动噪声方向 |
| `flowNoiseSpeed` | `float` | 流动噪声速度 |

### 4.7 HGVolumetricFogConfigCPP — 体积雾配置（独立结构）

体积雾配置独立于高度雾，包含自己的高度雾参数 + 体积雾参数 + 两层流动噪声。

**差异**: 相比 `HGHeightFogConfigCPP`，该结构移除 `heightFogCullingFarClipPlane`，增加了 `enableVLFlowNoise`, `enableTwoParameter` 和第二层流动噪声参数（`flowVLNoiseIntensity` 到 `flowVLNoiseSpeed`）。

### 4.8 HGCloudConfigCPP — 云配置

| 字段 | 类型 | 用途 |
|------|------|------|
| `enable` | `bool` | 启用云 |
| `enableCloudShadow` | `bool` | 启用云阴影 |
| `cloudShadowConfig` | `HGCloudShadowConfigCPP` | 云阴影配置（内联值） |
| `cloudTexture` | `IntPtr` | 云纹理指针 |
| `cloudTint` | `Color` | 云色调 |
| `cloudFadeAlpha` | `float` | 云淡出 Alpha |
| `cloudContrast` | `float` | 云对比度 |
| `lightAffectCloud` | `bool` | 光照影响云 |
| `cloudBrightness` | `float` | 云亮度 |
| `cloudAbsoluteBrightness` | `float` | 云绝对亮度 |
| `brightnessAffectCloudAlpha` | `bool` | 亮度影响云 Alpha |
| `drawCloudAfterPlanet` | `bool` | 在天体后绘制云 |
| `cloudTextureMode` | `HGCloudConfigCloudFlowTypeCPP` | 云纹理模式 |
| `cloudOpacityR` | `float` | 云不透明度 R 通道 |
| `cloudOpacityG` | `float` | 云不透明度 G 通道 |
| `cloudFlowType` | `HGCloudConfigCloudTextureModeCPP` | 云流动类型 |
| `rotation` | `int` | 旋转角度 |
| `cloudFlowMap` | `IntPtr` | 云流动贴图 |
| `flowSpeed` | `float` | 流动速度 |
| `flowDirectionX` | `float` | 流动方向 X |
| `flowDirectionY` | `float` | 流动方向 Y |
| `enableLightShaftCloudMask` | `bool` | 启用光柱云遮罩 |
| `lightShaftCloudMaskTexture` | `IntPtr` | 光柱云遮罩纹理 |

#### 4.8.1 HGCloudShadowConfigCPP

| 字段 | 类型 | 用途 |
|------|------|------|
| `cloudShadowTexture` | `IntPtr` | 云阴影纹理 |
| `cloudShadowEnvCenter` | `Vector3` | 云阴影环境中心 |
| `cloudShadowCoverage` | `float` | 云阴影覆盖率 |
| `cloudShadowFlowSpeed` | `float` | 云阴影流动速度 |
| `cloudShadowFlowDirection` | `Vector2` | 云阴影流动方向 |
| `cloudShadowAlpha` | `float` | 云阴影透明度 |
| `cloudShadowDistanceScale` | `float` | 云阴影距离缩放 |
| `cloudShadowScaleStartDistance` | `float` | 云阴影缩放起始距离 |
| `cloudShadowScaleEndDistance` | `float` | 云阴影缩放结束距离 |

### 4.9 HGCelestialConfigCPP — 天体配置聚合

| 字段 | 类型 | 用途 |
|------|------|------|
| `moonConfig` | `HGCelestialObjectConfigCPP` | 月亮配置 |
| `talosAlphaConfig` | `HGCelestialAtmosphereObjectConfigCPP` | Talos Alpha 天体配置 |
| `planetConfig` | `HGCelestialAtmosphereObjectConfigCPP` | 行星配置 |
| `advancedPlanetConfig` | `HGCelestialAdvancedObjectConfigCPP` | 高级行星配置 |

#### 4.9.1 HGCelestialObjectConfigCPP

| `radius` / `orbitRadius` / `enableRing` / `drawPlanetBelowHorizon` / `worldLongitude` / `worldLatitude` / `rotationAroundUp` / `ring` (HGRingPropertyCPP) |

#### 4.9.2 HGCelestialAtmosphereObjectConfigCPP

| `drawPlanetInSkydome` / `drawPlanetBelowHorizon` / `objectProperty` / `skydomeDrawer` / `enableRing` / `ring` / `enableAtmosphere` / `atmosphere` |

#### 4.9.3 HGCelestialObjectPropertyCPP

| `radius` / `selfTiltX` / `selfTiltZ` / `selfRotationY` |

#### 4.9.4 HGCelestialDrawerCPP

| `drawMode` (Texture/Simulated) / `drawMaterial` / `pitchYaw` / `incidentLightingPitchYaw` |

#### 4.9.5 HGCelestialAdvancedObjectConfigCPP

| `drawAdvancedPlanet` / `advancedPlanetMat` |

#### 4.9.6 HGRingPropertyCPP

| `outerRadius` / `width` / `ringColor` / `planetRingMap` |

#### 4.9.7 HGAtmospherePropertyCPP

| `bakeFaceVisibility` / `atmosphereHeight` / `numInscatteredSamplePoints` / `numOpticalDepthSamplePoints` / `coff_R` / `heightScale_R` / `atmosphereBrightness` / `atmosphereHueshift` |

### 4.10 HGStarConfigCPP — 星空配置

关键字段: `enableStars`, `starType`, `noiseRenderTex`, `starsSize/FlickerSpeed/Tint/Offset0~2/DensityR~B/Density/Density1~2/Exposure/Exposure1~2`, `starLayerViewMode`, `skyboxStarNoiseMap/RangeMap`, `skyBoxStarDensityMapRotation`, `debugMode`, `enableNebula`, `nebulaMap/Tint/MapRotation/StarConverage`

### 4.11 HGShadowConfigCPP — 阴影配置

| 字段 | 类型 | 用途 |
|------|------|------|
| `csmDepthBias` | `float` | CSM 深度偏差 |
| `csmNormalBias` | `float` | CSM 法线偏差 |
| `csmIntensity` | `float` | CSM 强度 |
| `csmRampTexture` | `IntPtr` | CSM 渐变纹理 |
| `csmShadowSoftness` | `float` | CSM 阴影软度 |
| `asmCasterMinY/MaxY` | `float` | ASM 投射器 Y 范围 |
| `contactShadowIntensity/SurfaceThickness/BilinearThreshold/Contract/IgnoreEdgePixels` | 接触阴影参数 |
| `overrideCsmFarDistanceEnabled/overrideCsmFarDistance` | CSM 远距离覆盖 |
| `manualOverrideCsmRendering/overrideCsmSpherePosition/overrideCsmSphereRadius` | CSM 手动覆盖 |
| `disableCsm/disableCsmBlendFactor/csmSimulatedAttenuation/disableAsm` | CSM/ASM 禁用 |

### 4.12 HGContactShadowConfigCPP — 接触阴影配置（独立）

| `ignoreEdgePixels` / `disableTerrainContactShadow` / `intensity` / `surfaceThickness` / `bilinearThreshold` / `contract` |

### 4.13-4.16 其余环境配置

**HGLightShaftConfigCPP**: `enable`, `bloomScale/Threshold/MaxBrightness/Tint`, `blurIntensity`, `occlusionDepthRange`, `enableOcclusion`, `occlusionMaskDarkness`

**HGAnamorphicStreaksConfigCPP**: `enable`, `bloomScale/Threshold/MaxBrightness/Tint`, `blurIntensity/Angle`, `filterSize`

**HGAutoExposureConfigCPP**: `active`, `autoMode`, `centerMode`, `curveEditModeEnabled`, `ev100Range/HistogramRange`, `pixelLuminanceRange`, `centerPixelWeight`, `evCompensationManual/Auto`, `evClampRange`, `lerpDownSpeed/UpSpeed`

**HGColorGradingConfigCPP**: `active`, `colorLookupEnabled/Texture/Contribution`, `colorAdjustmentsEnabled/PostExposure/Temperature/Tint/HueShift/Saturation/Contrast`, `ToneMappingMode`, Channel Mixer(9), SplitToning(3), Lift/Gamma/Gain, Curves(7 IDs), `colorFilter`, `miscPrams`

---

## 5. 体积组件系统（Volume Components）

### 5.1 HGVolumeComponentsDataCPP — 体积组件聚合根

| 字段 | 类型 | 用途 |
|------|------|------|
| `m_bloomVolume` | `BloomVolumeCPP*` | Bloom 体积 |
| `m_vignette` | `VignetteCPP*` | 渐晕 |
| `m_hgVignette` | `HGVignetteCPP*` | HG 渐晕 |
| `m_hgDirtyLens` | `HGDirtyLensCPP*` | 脏镜头 |
| `m_sharpenVolume` | `SharpenVolumeCPP*` | 锐化 |
| `m_radialBlur` | `HGRadialBlurCPP*` | 径向模糊 |
| `m_bwFlash` | `HGBWFlashCPP*` | 黑白闪光 |
| `m_fishEyeVolume` | `FishEyeEffectVolumeCPP*` | 鱼眼效果 |
| `m_chromaticAbberation` | `HGChromaticAbberationCPP*` | 色差 |
| `m_hgssrVolume` | `ScreenSpaceReflectionVolumeCPP*` | 屏幕空间反射 |

### 5.2 BloomVolumeCPP

| 字段 | 类型 | 用途 |
|------|------|------|
| `intensity` | `float` | 强度 |
| `tint` | `Color` | 色调 |
| `dirtTexture` | `IntPtr` | 污渍纹理 |
| `dirtIntensity` | `float` | 污渍强度 |
| `blendMode` | `BloomBlendMode` | 混合模式 |
| `anamorphic` | `float` | 变形宽银幕强度 |
| `scatter` | `float` | 散射 |
| `threshold` | `float` | 阈值 |
| `characterThreshold/Softness/Intensity` | `float` | 角色 Bloom 控制 |
| `resolution` | `BloomResolution` | 分辨率 |
| `enableBloomDirt/CharacterBloomControl/Alpha/Anamorphic` | `bool` | 功能开关 |

### 5.3 VignetteCPP

| `mode` (Procedural/Masked) / `color` / `center` / `intensity` / `smoothness` / `roundness` / `rounded` / `blink` / `mask` / `opacity` |

### 5.4-5.11 其他体积组件

| 组件 | 关键字段 |
|------|---------|
| **HGVignetteCPP** | `color`, `intensity`, `smoothness`, `rounded`, `blink` |
| **HGDirtyLensCPP** | `dirtyTex`, `intensity` |
| **SharpenVolumeCPP** | `isActive`, `sharpenMode`(Off/Filter1/2/4), `sharpenRange/Intensity/Threshold` |
| **HGRadialBlurCPP** | `enabled`, `center`, `intensity`, `power`, `averageSteps`, `enableGlobalCenter`, `globalCenter` |
| **HGBWFlashCPP** | `enabled`, `centerPosition`, `bwThreshold`, `colorBias`, `inverse`, `useFlashTex`, `flashTexture/Tiling/Offset/Speed/Intensity`, `useMaskTex`, `maskTexture/Intensity/UsePolarUV/Tiling/Offset`, `flashColor`, `backGroundColor` |
| **FishEyeEffectVolumeCPP** | `enable`, `distortion` |
| **HGChromaticAbberationCPP** | `enabled`, `center`, `intensity`, `averageStep`, `enableGlobalCenter`, `globalCenter` |
| **ScreenSpaceReflectionVolumeCPP** | `enable`, `fadenessOnScreen/Depth/DepthFactor/MirrorMul/MirrorAdd`, `mipThreshold` |

---

## 6. 每帧渲染参数传递

### 6.1 HGRenderPathParamsCPP — 渲染主参数（317 行）

这是每帧传递给 C++ `HGRenderPath_Render` 的 **最重要参数结构体**。

#### 基本渲染信息
`currentDeviceType`, `fogLayer`, `COMPOUND_CHARACTER_LAYER_MASK`, `sizeofShaderVariablesGlobal`, `sizeBasicTransformConstants`, `sizePerPassConstants`

#### 主数据指针
| 字段 | 类型 | 用途 |
|------|------|------|
| `otherData` | `HGRenderPathOtherData*` | 其他渲染数据 |
| `settingParameters` | `HGSettingParametersCpp*` | 渲染设置参数 |
| `mainViewConstants` | `HGViewConstantsCPP*` | 主视图常量 |
| `envPhase` | `HGEnvironmentPhaseCPP*` | 环境阶段配置 |
| `volumeComponentsData` | `HGVolumeComponentsDataCPP*` | 体积组件数据 |
| `uiVolumeComponentsData` | `HGVolumeComponentsDataCPP*` | UI 体积组件数据 |

#### 布尔开关标志（约 30 个）
`didResetPostProcessingHistoryInLastFrame`, `enableResponsiveTransparency`, `enableTAAU`, `fastConvergeState`, `enableDLSS`, `disableFrameGenTemporarily`, `ssrEnable`, `shouldRenderPostProcess`, `shouldRenderAtmosphereFog/HeightFog/VolumetricFog`, `shouldBakeFogLut`, `enableAOVOutput`, `characterOutlineEnabled`, `renderWithAlpha`, `sceneViewVolumetricFogEnable`, `isInIsolatedDisplayMode`, `isFirstFrame`, `prevTransformReset`, `enableWetness`, `shouldRenderRippleState`, `enableEditorMacros`, `render3DUI`, `enableGPUDriven`, `isPlaying`, `isSkyRenderingEnabled`, `forceRenderAtmosphereLutEveryFrame`, `renderAtmosphereLutUsingCompute`, `renderPathMobile`, `lightsUseLinearIntensity`, `isActiveColorSpaceGamma`, `flowNoiseEnabled`, `hasTerrainSimpleSubsurface`, `forceRegenerateAsm`, `bSkipRender`, `enableFSR3`

#### 分辨率与格式
`backgroundColorHDR`, `cameraFrameCount`, `debugRenderMode`, `cullingViewHandle`, `screenCullingRatio/Distance/LayerMask`, `rayTracingTLASHandle`, `frameSettingsData0/1`, `lutSize/Format`, `sceneRTSize/ColorFormat/DepthFormat`, `taauRTSize`, `finalRTSize`

#### 系统管理器指针（约 30 个 IntPtr）
`cullingResults`, `visibleLights`, `lightManager`, `graphicsFeatureManager`, `ivManager`, `terrainDeformManager`, `interactionManager`, `terrainManager`, `editorTerrainManager`, `sludgeRender`, `decalRender`, `meshRender`, `grassRender`, `reflectionProbeSystem`, `clothManager`, `uiRender`, `capsuleShadowManager`, `foliageOccluderRenderer/InteractiveManager/OccluderManager`, `waterRender`, `gpuDrivenRendererV1/V2`, `cullingSystem`, `rendererSystem`, `subsurfaceManager/ProfileManager`, `shadingStateSystem`, `geometrySystem`, `resourceManager`, `customDepthOnlyRequestManager`, `dlssRender`, `customDrawRTManager`, `rayTracingRender`

#### Pass 输入指针（约 20 个）
`uiImageBlurPassInput`, `inkSimulationPassInput`, `reflectionProbeBinningInput`, `terrainDeformPassInput`, `terrainDepthPrepassInput`, `waterSectorRenderingInput`, `waterInteractionRenderingInput`, `waterRenderingInput`, `gtaoSettingParameters`, `fakePlanarReflectionRenderingInput`, `dofParameters`, `motionBlurParameters`, `lensFlareRenderingInput`, `parafinRenderingInput`, `vfxScreenMaterialData`, `vfxPPScanLinePassInput`, `skyRendererInput`, `visibilitySHRPInput`, `frostedGlassPassRPInput`, `fishEyeEffectInput`, `cutsceneEffectPassRPInput`, `volumetricCloudInput`

#### RT 提取与水面标记
`rtExtractionSceneColorLS/BlurredSceneColorPS/SceneColorPS/FinalResult` (int* + count), `waterMarkRTCount/SrcRTs/DstRTs/HeightScales`, `inplaceWaterMarkRTCount/DstRTs/HeightScales`

### 6.2 HGRenderPathBeforeCullingParamsCPP

用于 `HGRenderPath_BeforeCulling`，包含: `currentDeviceType`, `sceneRTSize`, `COMPOUND_CHARACTER_LAYER_MASK`, `lodCrossFadeConfig` (x2), `settingParameters`, `lightConfig`, `shadowConfig`, `heightFogCullingFarClipPlane`, `overrideCsmMaxDistanceValue/ShadowDistance`, `enableShadowCulling`, `forceRegenerateAsm`, `isInIsolatedDisplayMode`, `renderPathMobile`, `enableSceneViewLODCrossFade`, `prevTransformReset`, `showOcclusionCulling`, `cullingViewUniqueID`, `characterShadowInputs`, `lightManager`, `debugFeaturesManager`, system managers (6 IntPtr), `bSkipRender`, `lightClusteringBeforeCullingOutput/ShadowPassBeforeCullingOutput/CustomDepthOnlyBeforeCullingOutput`, `foliageOccluderCullViewHandle`, `renderCamera/uiRenderCamera/occlusionCamera`, `cullingViewHandle/uiCullingViewHandle/rayTracingCullingViewHandle/rayTracingTLASHandle`, `visibleLights/visibleLightCount`

### 6.3 HGRenderPathOtherData

| 类别 | 字段 |
|------|------|
| TAA | `taaEnabled`, `taaSharpenStrength`, `taaFrameIndex`, `taaJitterPhaseCount`, `taaJitter` |
| 时间 | `time`, `lastTime`, `gameplayTime`, `lastGameplayTime`, `deltaTime`, `smoothDeltaTime`, `frameCount` |
| MIP | `globalMipBias` |
| 角色光照 | `characterLightSmoothFactor` |
| 风格化 | `_Style_MatDistCoef/_GbCoef/_MatFarAlb0~1/_GbFarEms/_GbFarDir` (6 Vector4) |
| VFX | `_VFXParams0~3` (4 Vector4) |
| 角色参数 | `_CharacterParams0~16` (17 Vector4) |
| IV | `_IVParam0~2`, `_IVDefaultSHAr/Ag/Ab`, `_IVV2Param0~3` |
| 纹理 | `indirectionTexture`, `physicalTexture0/1`, `clipmapTextureALod0~3/BLod0~3` |
| 角色特效 | `_CharMaxCubemap`, `_CharacterRainEffectTex/StreakTex/FaceDripTex/FaceDropletTex/SnowEffectTex` |
| 风 | `_WindGlobalParams0/2`, `_WindMotorParams0~3[16]`, `_WindMotorCount`, `_LastWindGlobalParams0`, `_LastWindMotorParams0/1/3[16]` |
| 位置 | `_CharacterPositionParams0~3`, `_CharacterHeightParams` |
| 水交互 | `_WaterInteractionParams0/1` |
| 湿润 | `_RainWetnessGlobalParam0~10` (11 Vector4) |
| 纹理 | `verticalFlowTexture`, `rippleTexture`, `rainOcclusionSampleJitterNoise` |
| 湿润开关 | `enableWetness`, `enableWetnessHighQuality`, `rainRendererUpdateSuccess` |
| 垂直遮挡 | `_VerticalOcclusionMapParam0`, `enabledVerticalOcclusion` |
| 交互筏 | `_InteractRaftParams0/1` |
| 临时 | `_HackTempDataBeforeCPPPlugin[128]` (512 字节) |

### 6.4 HGSettingParametersCpp — 渲染设置参数（409 行）

包含所有质量/性能设置，主要分类：

**TAA**: `taauEnable/Quality`, `historyWeight/Motion/FastConverge`, `responsiveAAWeight`, `minMotion/MaxMotion`, `characterMotionSensitivity`, `occlusionDepthDiff`, `inputLumaWeight`, `sharpenStrength1K/2K/4K`, `pssrEnable/PassThrough`

**DLSS**: `dlssEnable/Quality/UseAutoExposure/FGMode/FGGenFrames/ReflexMode/PCLEnable/SharpenStrength/UseUIHint/UIHintAlphaThreshold`

**FSR3**: `fsr3Enable/UseReaciveAndTCMask/Quality/SharpenStrength/UseFP16/UseWave/UseWave64/UseLanczosLut`

**Bloom**: `bloomQuality/UseComputeShader/Enabled`

**后处理开关**: `lutSize/Format`, `ppBufferFormat/uiPPBufferFormat`, `frostedGlassUseComputeShader`, `depthOfFieldQuality/MaxRadius/ScaleAdjust/ScaleAdjustThreshold`, `motionBlurEnable`, `bloomEnabled/vignetteEnabled/radialBlurEnabled/chromaticAberrationEnabled/dirtyLensEnabled/sharpenEnabled/frostedGlassEnabled/cutsceneEffectEnabled/fisheyeEffectEnabled/lensFlareEnabled`

**阴影**: 大量 CSM/ASM/CharacterShadow/PunctualLightShadow 参数

**GBuffer/分辨率**: `transientGBuffer`, `depthBitsGBuffer`, `depthCombinedWithStencil`, `copySceneRTScale`, `taauResolveResolutionHeight`, `renderingScale`, `backBufferResolutionHeight`

**纹理串流**: `textureStreamingEnable/Budget/MaxBudget/reservedMemoryForNonTextureStreaming/MobileBudgetPercent/RendererPerFrame/MaxFileIORequests`

**AO/SSR**: `contactShadowEnableParam`, `gtaoEnable/QualityLevel`, `ssrEnable/RayMarchingSampleCount/ImportanceSample/V2/V2Upsample`

**地形**: `terrainFallbackGBuffer/LODFactor/DeformEnable/DeformSubdMode/DeformSubdModeV2/DeformGpuSubd/DeformPrimitivePixelLengthTargetLog2`, `erosionEnable`

**光柱/拉丝**: `enableLightShaft/LightShaftSampleNum/DownSampleFactor/BlurPassCount`, `enableAnamorphicStreaks/AnamorphicStreaksDownSampleFactor`

**UI/雨水**: `lightWeightUICamera`, `enableRainWetnessHighQuality`, `rainOcclusionMapSize/OverrideRange`, `rainSplashEnabled/MaxCount`, `screenRainDropPercent`, `enableMiddleDistRain/Wave`, `depthOcclusionMapSize/Range`

**大气**: `atmosphereParams` (HGAtmosphereSettingParameters - transmittance/multiScattered/skyView LUT 参数)

**水**: `waterPrepassTextureSize/InteractiveEnable/IndirectEnable/VRRx/y/DisplacementWeight/DisplacementDistance/HeightTextureSize`

**杂项**: `artTagLODBiasAll/artTagLODBias[64]`, `shouldSplitOnePass`, `volumetricFogParams`

**光线追踪**: `rayTracingReflectionEnable/Mode/SSQuality0~3/RTQuality0~3`

**帧插值**: `frameInterpolationEnable/Pause/Algo/hasWorldUIAfterFrameInterpolation/afmeCameraRotationCosFallbackThreshold/afmeCameraMoveDistanceSqrFallbackThreshold/mfrcCamera*FallbackThreshold*`

**墨迹模拟**: `inkSimulationResolution/DensityResolution/Enable`

### 6.5 HGViewConstantsCPP

包含完整的视图/投影矩阵集合（17 个 Matrix4x4），以及 `worldSpaceCameraPos`, `worldSpaceCameraPosViewOffset`, `prevWorldSpaceCameraPos`（每个 Vector3 后跟 float pad 以保持 16 字节对齐）。

---

## 7. 着色器常量缓冲区

### 7.1 ShaderVariablesGlobal

**文件**: `ShaderVariablesGlobal.cs`  
**用途**: 映射到 C++ 侧的全局 shader 常量缓冲区

| 类别 | 字段 |
|------|------|
| 前一帧矩阵 | `_PrevViewProjMatrix`, `_PrevViewNoTransProjMatrix`, `_PrevNonJitteredViewProjMatrix/NoTrans`, `_PrevInvViewProjMatrix`, `_PrevNonJitteredInvViewProjMatrix` |
| 重投影 | `_ReprojectionMatrix` |
| 宽 FOV | `_WiderFoVViewProjMatrix`, `_WiderFoVInvViewProjMatrix` |
| 相机位置 | `_PrevCamPosRWS_Internal` |
| 屏幕参数 | `_ScreenSize`, `_BackBufferSize`, `_ZBufferParams`, `_ProjectionParams`, `unity_OrthoParams`, `_ScreenParams` |
| 裁剪平面 | `_FrustumPlanes[24]`, `_ShadowFrustumPlanes[24]` |
| TAA | `_TaaFrameInfo`, `_TaaJitterStrength` |
| 时间 | `_Time`, `_SinTime`, `_CosTime`, `unity_DeltaTime`, `_TimeParameters`, `_LastTimeParameters` |
| MIP/曝光 | `_GlobalMipBias/Pow2`, `_ProbeExposureScale`, `_ExposureParams`, `_BinningBufferOffsets` |
| 环境/功能 | `_EnvironmentGlobalParams0`, `_GraphicsFeaturesGlobalParam0/1` |
| 风 | `_WindGlobalParams0/2`, `_WindMotorParams0~3[16]`, `_WindMotorCount`, `_LastWindGlobalParams0`, `_LastWindMotorParams0/1/3[16]` |
| 角色 | `_CharacterPositionParams0~3`, `_CharacterHeightParams` |
| 植被 | `_FoliageInteractiveParams0`, `_PrevFoliageInteractiveParams0` |
| 雾 | `_AtmosphereFogParams0~5`, `_ExponentialFogParams0~5`, `_VolumetricFogParams0~4`, `_HeightFogFlowNoiseParams0/1`, `_FogBakeLut*` |
| 云阴影 | `_CloudShadowParams0~3` |
| 风格化 | `_Style_MatDistCoef/GbCoef/MatFarAlb0~1/GbFarEms/GbFarDir` |
| VFX | `_VFXParams0~3` |
| 角色 | `_CharacterParams0~16` |
| 墨迹 | `_InkSimulationWorldToUV` |
| 地形 | `_TerrainDeformParams0/1`, `_TerrainClipmapParams0/1[8]` |
| 功能开关 | `_G_EnableFeatureErosionBlend/B/C/D` |
| IV | `_IVParam0~2`, `_IVDefaultSHAr/Ag/Ab`, `_IVV2Param0~3` |
| 水 | `_WaterInteractionParams0/1` |
| 湿润 | `_RainWetnessGlobalParam0~10` (11 Vector4) |
| 垂直遮挡 | `_VerticalOcclusionMapParam0` |
| 水湿润遮罩 | `_WaterWetnessMaskParam0` |
| GPU 布料 | `_GpuClothParams` |
| 植被遮挡 | `_FoliageOccluderParams0`, `_FoliageOccluderCameraPosParam` |
| 交互筏 | `_InteractRaftParams0/1` |
| 假平面反射 | `_FakePlanarReflectionViewProjMatrix` |
| 假球面光源 | `_FakeSphericalLightSource` |
| 体积合成 | `_VolumetricComposeParams` |
| 临时数据 | `_HackTempDataBeforeCPPPlugin[128]` |

---

## 8. DLSS / FSR3 / 帧生成工具

### 8.1 HGCPPDLSSUtil
- `SetStreamlineDLSSGMode(StreamlineDLSSFGMode)` — 设置 DLSS 帧生成模式
- `GetStreamlineDLSSGMinMaxFrameGen()` — 获取 DLSS FG 最小/最大帧生成
- `CalcStreamlineDLSSGVRAMUsage(Vector2Int taauSize, Vector2Int finalRTSize)` — 计算 VRAM 使用量

### 8.2 DLSSOptimalSettings
- 字段: `optimalRenderWidth/Height`, `optimalSharpness`, `renderWidthMin~Max/HeightMin~Max`
- 方法: `GetDLSSOptimalSetting(DLSSQuality, Vector2Int) → DLSSOptimalSettings`

### 8.3 HGFSR3Util
- `IsFSR3Supported()` — 检查 FSR3 是否支持
- `GetFSR3RenderScale(FSR3Quality)` — 获取渲染缩放比

### 8.4 HGCPPFrameInterpolatorUtil
- `SetAFMECameraFallbackThreshold(float rotationCos, float moveDistanceSqr)`
- `SetMFRCGeneralallbackThreshold(float)`
- `SetMFRCBrightnessDiffFallbackThreshold(float)`
- `SetMFRCRepeatedPatternFallbackThreshold(float)`

---

## 9. 调试系统

### 9.1 HGDebugFeaturesManagerCPP — 调试功能管理器

包含约 160+ 调试功能，每个为 `HGDebugFeatureCPP`（仅 `enabled`）或带覆盖值的变体。

**调试功能分类**:
- **渲染路径** (~20): `cppRenderPath`, `shadows`, `csm`, `preZ`, `deferred`, `forward`, `characterPrePass`, `distortion`, `UI`, `UISprite`, `UIWorld` 等
- **延迟着色** (~12): `deferredShading`, `deferredShadingDefaultLit/TwoSidedFoliage/Subsurface`, `directionalLight`, `punctualLights` 等
- **阴影** (~10): `csmShadow`, `asmShadow`, `cloudShadow`, `characterShadow`, `contactShadow` 等
- **后处理** (~15): `bloom`, `vignette`, `radialBlur`, `motionBlur`, `depthOfField`, `lensFlare` 等
- **雾** (~5): `fog`, `atmosphereFog`, `heightFog`, `volumetricFog`, `volumetricCloud`
- **SSR/反射** (~10): `ssr`, `reflectionProbe*`
- **水** (~10): `waterRendering`, `waterSSROnMobile`, `waterSector`, `waterInteraction` 等
- **雨/湿润** (~6): `rain`, `wetness`, `rainWetnessHighQuality`, `rainOcclusion` 等
- **地形** (~15): `terrainDeform`, `terrainPreDepth`, `terrainScreenSpace`, `terrainSubdivision` 等
- **天空** (~6): `sky`, `skyBox`, `skyCloud`, `skyCelestial`, `skyOctahedron`
- **其他**: `gpuCloth`, `particleLighting`, `shaderLOD`, `rayTracingReflectionEnable` 等

### 9.2 调试功能类型

| 类型 | 结构 |
|------|------|
| `HGDebugFeatureCPP` | `{ bool enabled }` |
| `HGDebugFeatureCPP_bool` | `{ bool overriding, bool value }` |
| `HGDebugFeatureCPP_float` | `{ bool overriding, float value }` |
| `HGDebugFeatureCPP_int` | `{ bool overriding, int value }` |

### 9.3 HGDebugRenderManagerCPP

关键字段: `enableAOVOutput/RenderMatte`, `ppCompareScaleValue`, 纹理检测参数(`enableAlbedoTexelDetection`, `albedoMinLuminance/MaxLuminance`, `baseColorAlpha`, `checkerSize`), `triangleCountMin/Max`, `autoExposureEnabled/Mode/Value/Target/avgLogLuminance/EV100Compensation/directEV100`, `displayPPResult`, `overrideBaseColor`, `disableNormalMap`, `debugDisplayEV`, `displayPBRColorChart`, `debugXRayDistance`, `displayIVVoxelSize`, `debugSkyAO`, 四边覆盖检测参数, 光照调试参数, 反射探针调试参数, 阴影调试参数, SceneView 选择位置, `m_fetchedData[8]`

---

## 10. 地形子系统

### 10.1 TerrainDepthPrepassInput
`enableTerrainTessellation/Subdivision/SubdivisionV2/DecalDeform/WetRipple`, `layerTypeData*`, `subdivisionHandle`, `terrainCullViewHandle/editorTerrainCullViewHandle`, `vtFeedbackId`

### 10.2 HGTerrainLayerTypeData
`m_bHasLayerTypeData`, `m_localToWorldMatrix/WorldToLocalMatrix`, `m_heightmapTexture/Scale`, `m_glintData/SubsurfaceData/FakeVolumeData/FakeShadowData`

### 10.3 子数据
- **HGTerrainGlintData**: `enableFakeGlint`, `glintTopBlendSmoothness/Threshold`, `glintStrength/Scale/Threshold/FadeDistance`, `glintColor`
- **HGTerrainSubsurfaceData**: `useSubsurfaceProfile`, `subsurfaceCurvatureScale/Offset`, `enableSubsurfaceProfileKeyword`, `terrainStencil`
- **HGTerrainFakeVolumeData**: `enableFakeVolume`, `fakeVolumeIoR/FresnelStrength/Mode/OpacityTiling`, `fakeCrackLayerTiling/Tint/HeightScale/Depth/MarchSteps`, `fakeRefractionTint/LayerTiling/HeightScale/Depth/MarchSteps`, `fakeVolumeScatterExtinction/Albedo`, `fakeDustLayerTiling/Depth/FlowSpeed/Tint`, `fakeVolumeOpacityMask/Mask`
- **HGTerrainFakeShadowData**: `enableFakeShadow`, `fakeShadowPenumbra/Strength/MarchSteps/DistanceLerp`

### 10.4 TerrainDeformPassInput
`drawInteractionNodeMaterial`

---

## 11. Enum 完整定义表

| 枚举名称 | 值 | 用途 |
|---------|-----|------|
| **HGRenderPathInternalCPP** | Forward=0, UI=1, UI3D=2, DefaultDeferred=3, OnePassDeferredSubpass=4, DebugFullScreen=5, DebugRegularDefaultDeferred=6, DebugRegularOnePassDeferredSubpass=7, Count=8 | 渲染路径类型 |
| **BloomBlendMode** | Add=0, EnergyConservation=2 | Bloom 混合模式 |
| **BloomQuality** | Low=0, Medium=1, High=2 | Bloom 质量 |
| **BloomResolution** | Quarter=4, Half=2 | Bloom 分辨率 |
| **VignetteMode** | Procedural=0, Masked=1 | 渐晕模式 |
| **HGToneMappingModeCPP** | None=0, Neutral=1, ACES=2, Custom=3, External=4, ACES_Modified=5, Count=6 | 色调映射模式 |
| **DLSSQuality** | UltraPerformance=0, Performance=1, Balanced=2, Quality=3, DLAA=4 | DLSS 质量 |
| **FSR3Quality** | UltraPerformance=0, Performance=1, Balanced=2, Quality=3, NativeAA=4 | FSR3 质量 |
| **StreamlineDLSSFGMode** | Off=0, On=1, Auto=2 | DLSS 帧生成模式 |
| **StreamlineReflexMode** | Off=0, LowLatency=1, LowLatencyWithBoost=2 | Reflex 低延迟模式 |
| **FrameInterpolationAlgo** | Vendor=0, HGFI=1, Blit=2 | 帧插值算法 |
| **HGSkyConfigSkyMaterialTypeCPP** | ProceduralSky=0, Skybox=1 | 天空材质类型 |
| **HGSkyConfigReflectionTypeCPP** | FromSky=0, Custom=1 | 反射类型 |
| **HGCloudConfigCloudFlowTypeCPP** | None=0, Procedural=1, FlowMap=2 | 云流动类型 |
| **HGCloudConfigCloudTextureModeCPP** | SingleChannelRG=0, ColorRGB=1 | 云纹理模式 |
| **HGLightConfigPitchYawModeCPP** | DirLight=0, Custom=1 | 光照俯仰偏航模式 |
| **HGStarConfigStarTypeCPP** | RealTimeNoise=0, BakedMap=1 | 星星类型 |
| **HGStarConfigStarLayerViewModeCPP** | FullLayer=0, RLayer=1, GLayer=2, BLayer=3 | 星层视图模式 |
| **HGStarConfigDebugModeCPP** | Material=0, RChannel=1, GChannel=2, BChannel=3, RGBChannel=4 | 星星调试模式 |
| **HGCelestialDrawerDrawModeCPP** | Texture=0, Simulated=1 | 天体绘制模式 |
| **HGSharpenMode** | Off=0, Filter1=1, Filter2=2, Filter4=3 | 锐化模式 |
| **EDownResFilter** | DepthFade=0, Nearest=1, Bilateal=2, Noisy=3 | 降采样滤镜 |
| **EFarCloudFramingQuality** | None=0, Checkerboard=1, Quarter=2, Framing4x2=3, Framing4x4=4 | 远云分帧质量 |
| **EFramingQuality** | Checkerboard=0, Quarter=1 | 分帧质量 |
| **HGRainDrawCmdType** | DrawMesh=0, DrawMeshInstancedProcedural=1 | 雨滴绘制命令类型 |
| **HGLensFlareBlendMode** | Additive=0, Screen=1, Premultiply=2, Lerp=3 | 镜头光晕混合 |
| **HGLensFlareDistribution** | Uniform=0, Curve=1, Random=2 | 镜头光晕分布 |
| **HGLensFlareType** | Image=0, Circle=1, Polygon=2 | 镜头光晕类型 |

---

## 12. 完整数据结构引用表

### 12.1 核心渲染入口
- `HGRenderGraphCPP` (class) — C++ FreeFunction P/Invoke 入口
- `HGRenderPathConstants` (struct) — 渲染路径 shader 常量
- `BasicTransformConstants` (struct) — 基础变换矩阵常量
- `ShaderVariablesGlobal` (struct) — 全局 shader 变量

### 12.2 渲染参数
- `HGRenderPathParamsCPP` (struct) — 渲染主参数
- `HGRenderPathBeforeCullingParamsCPP` (struct) — 裁剪前参数
- `HGRenderPathOtherData` (struct) — 其他渲染数据
- `HGSettingParametersCpp` (struct) — 渲染设置参数
- `HGViewConstantsCPP` (struct) — 视图矩阵常量

### 12.3 环境配置
- `HGEnvironmentPhaseCPP` (struct) — 环境阶段聚合根
- `HGLightConfigCPP` / `HGSkyConfigCPP` / `HGAtmosphereConfigCPP` / `HGFogConfigCPP`
- `HGHeightFogConfigCPP` / `HGVolumetricFogConfigCPP`
- `HGCloudConfigCPP` / `HGCloudShadowConfigCPP`
- `HGCelestialConfigCPP` + 子结构体(5)
- `HGStarConfigCPP` / `HGShadowConfigCPP` / `HGContactShadowConfigCPP`
- `HGLightShaftConfigCPP` / `HGAnamorphicStreaksConfigCPP`
- `HGAutoExposureConfigCPP` / `HGColorGradingConfigCPP`

### 12.4 体积组件
- `HGVolumeComponentsDataCPP` (struct) — 体积组件聚合根
- `BloomVolumeCPP` / `VignetteCPP` / `HGVignetteCPP`
- `HGDirtyLensCPP` / `SharpenVolumeCPP` / `HGRadialBlurCPP`
- `HGBWFlashCPP` / `FishEyeEffectVolumeCPP`
- `HGChromaticAbberationCPP` / `ScreenSpaceReflectionVolumeCPP`

### 12.5 渲染 Pass 输入
- `HGWaterRenderingInput/SectorRenderingInput/InteractionRenderingInput`
- `VolumetricCloudInput` + `HGVolumetricRenderItem/CloudDataCB/Bounds/QualitySettings`
- `SkyRendererInput` / `LensFlareRenderingInput` + `HGLensFlareDrawData`
- `ParafinRenderingInput` / `VFXScreenMaterialData` / `VFXPPScanLinePassInput`
- `VisibilitySHRPInput` / `FrostedGlassPassRPInput` / `FishEyeEffectInput`
- `CutsceneEffectPassRPInput` / `UIImageBlurPassInputV2`
- `InkSimulationPassInput` / `HGReflectionProbeBinningInput`
- `HGFakePlanarReflectionRenderingInput` / `HGGTAmbientOcclusionSettingParameters`
- `HGDepthOfFieldParameters` / `HGMotionBlurParametersV2`
- `HGCharacterShadowInputsCPP` / `CustomDepthOnlySystemRequest`
- `ParticleLightingIVInput` / `TerrainDeformPassInput` / `TerrainDepthPrepassInput`
- `ScanLineDataPack` / `HighlightDataPack`

### 12.6 地形数据
- `HGTerrainFeatures` / `HGTerrainLayerTypeData`
- `HGTerrainGlintData` / `HGTerrainSubsurfaceData`
- `HGTerrainFakeVolumeData` / `HGTerrainFakeShadowData`

### 12.7 工具/辅助
- `HGRainParams` / `HGAtmosphereSettingParameters` / `HGVolumetricFogSettingParametersV2`
- 调试管理器与调试功能类型(5)
- `HGCPPDLSSUtil` / `HGFSR3Util` / `HGCPPFrameInterpolatorUtil` / `DLSSOptimalSettings`
- 质量设置: `HGCloudQualityPack` / `HGDownResQualityPack` / `HGFramingQualityPack` / `HGTAAQualityPack`

---

## 13. 与 C++ 原生层的数据同步协议

### 13.1 同步流程
```
每帧 C# 端:
  1. 填充所有 struct 字段
  2. 使用 fixed{} 固定内存
  3. 调用 HGRenderGraphCPP.HGRenderPath_Render() 传入指针
  4. C++ 端直接读写 struct 内存

C# 端调用流程:
  HGRenderPath_BeforeCulling(beforeCullingParams, ...)
      → C++ 更新裁剪参数
  HGRenderPath_Render(renderPathParams, beforeCullingParams, ...)
      → C++ 执行渲染, 使用所有配置
  HGRenderPath_Destroy()
      → C++ 释放资源
```

### 13.2 内存布局规则
1. **所有 struct 使用默认顺序布局**（未标注 `LayoutKind.Sequential` 的也默认 Sequential）
2. **`bool` 在 C# 中为 1 字节**，与 C++ `bool` 兼容
3. **枚举底层为 `int`**（4 字节），与 C++ `enum class` 兼容
4. **指针**：`IntPtr` 和 `T*` 均为 8 字节（64-bit）
5. **`fixed` 缓冲区**：`fixed float _WindMotorParams0[16]` 占用 64 字节连续空间
6. **`Vector2Int`**：两个 `int`（8 字节）
7. **`GraphicsFormat`**：底层为 `int`（4 字节）
8. **`SphericalHarmonicsL2`**：3 阶球谐系数（9 个 float）
9. **`CBHandle`**：常量缓冲区句柄（IntPtr 大小）

### 13.3 命名约定
- C# struct 名称以 `CPP` 结尾 → 对应 C++ header 中的 struct
- 字段名与 C++ 侧完全一致（如 `csmDepthBias` ↔ `float csmDepthBias`）
- `[NativeHeader("...")]` 指定了对应的 C++ 头文件路径
- 枚举值数字与 C++ 侧 `enum class` 保持一致

### 13.4 数据流概要
```
C# Volume/MonoBehaviour (PostProcessVolume 等)
  ↓ (每帧序列化)
C# struct (HGAtmosphereConfigCPP 等)
  ↓ (fixed ptr)
C# HGRenderGraphCPP (FreeFunction)
  ↓ (raw pointer)
C++ HGRenderPath (原生渲染管线)
  ↓ (shader uniform)
GPU Shader
```
