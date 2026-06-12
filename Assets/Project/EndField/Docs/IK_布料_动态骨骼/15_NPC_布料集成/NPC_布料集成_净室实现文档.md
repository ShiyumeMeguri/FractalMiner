# NPC 布料集成层 — 净室实现文档

> 本文档基于对以下源文件的净室逆向分析编写：
> - ClothCalculator.cs (抽象基类, ~1887行)
> - AnimationStreamClothCalculator.cs (动画流路径, 559行)
> - AnimatorClothCalculator.cs (Animator路径, 532行)
> - NPCAvatarManager.cs (NPC Avatar管理器, ~11356行)
> - LookAtControllerHolder.cs (注视控制器抽象)
> - IK_动态骨骼_布料系统_全量分析报告.md (Section 3.4, 5.9, 6)
> 
> **原则**: 本文档仅推导公开接口行为、字段语义、数据流拓扑和标准算法模式。不包含任何受版权保护的源码文字。

## 目录

1. [系统概述](#1-系统概述)
2. [ClothCalculator 核心实现](#2-clothcalculator-核心实现)
    - 2.1 [类层次与字段语义](#21-类层次与字段语义)
    - 2.2 [布料权重计算（距离/质量驱动）](#22-布料权重计算距离质量驱动)
    - 2.3 [动画流路径 vs Animator 路径（双路径支持）](#23-动画流路径-vs-animator-路径双路径支持)
    - 2.4 [权重过渡速率（增量 8f/s，减量 3f/s）](#24-权重过渡速率增量-8fs减量-3fs)
    - 2.5 [公共方法清单](#25-公共方法清单)
3. [AnimationStreamClothCalculator vs AnimatorClothCalculator 的区别](#3-animationstreamclothcalculator-vs-animatorclothcalculator-的区别)
4. [NPCAvatarManager 中的布料集成](#4-npcavatarmanager-中的布料集成)
    - 4.1 [布料权重管理（每 NPC）](#41-布料权重管理每-npc)
    - 4.2 [过场动画中的 BipedIK 禁用](#42-过场动画中的-bipedik-禁用)
    - 4.3 [远距离 NPC 质量降级](#43-远距离-npc-质量降级)
5. [数据流](#5-数据流)
6. [权重过渡算法伪代码](#6-权重过渡算法伪代码)
7. [与 BeyondDynamicBone 的桥接方式](#7-与-beyonddynamicbone-的桥接方式)

---

## 1. 系统概述

### 1.1 职责定位

NPC 布料集成层是连接 **NPC 动画系统** 与 **底层布料模拟系统（BeyondDynamicBone）** 的中间桥梁。其核心职责包括：

| 职责 | 说明 |
|------|------|
| **布料权重管理** | 根据 NPC 与相机的距离、运行时质量配置（PhysicsClothQuality），计算每帧布料模拟权重 |
| **动画层桥接** | 通过抽象基类 ClothCalculator，统一操作布料相关动画层的权重（ClothBase、LoopClothAddLayer、LoopBodyAddLayer、ClothCombineLayer） |
| **双路径支持** | 同时支持 Animator 路径（传统 Unity Animator）和 AnimationStream 路径（ScriptAnimationJobSyncMono Job 系统） |
| **质量降级支持** | 远距离 NPC 自动降低布料权重 / 禁用布料模拟，优化性能 |
| **权重平滑过渡** | 使用 MoveTowards 以固定速率（增 8f/s，减 3f/s）平滑调整布料物理权重，避免布料突然弹出/冻结 |

### 1.2 文件布局

| 文件 | 类型 | 行数 | 角色 |
|------|------|------|------|
| ClothCalculator.cs | 抽象基类 | ~1887 | 定义布料权重计算的通用接口与骨架算法 |
| AnimationStreamClothCalculator.cs | 具体子类 | 559 | Animation Job Stream 路径的实现 |
| AnimatorClothCalculator.cs | 具体子类 | 532 | Unity Animator 路径的实现 |
| LookAtControllerHolder.cs | 抽象基类 | 9 | 注视控制器包装器抽象 |

---

## 2. ClothCalculator 核心实现

### 2.1 类层次与字段语义

`
ClothCalculator (abstract)
├── isStreamClothCalculator: bool          // 运行时标识是否为 Stream 路径
├── isPauseClothCurveParams: bool          // 暂停布料曲线参数更新
├── isPauseClothLayerWeight: bool          // 暂停布料层权重更新
│
├── m_clothBaseLayerID: int                // "ClothBase" 动画层索引
├── m_clothCombineLayerID: int             // "ClothCombineLayer" 动画层索引
├── m_loopClothLayerID: int                // "LoopClothAddLayer" 动画层索引
├── m_loopBodyLayerID: int                 // "LoopBodyAddLayer" 动画层索引
│
├── m_loopClothWeightRef: float            // 循环布料层权重引用值
├── m_loopBodyWeightRef: float             // 循环身体层权重引用值
│
├── m_boneCloths: List<BeyondBoneCloth>    // 该 NPC 关联的所有 BeyondBoneCloth 实例
├── m_separateBoneCloth: Dictionary<BeyondBoneClothPart, List<BeyondBoneCloth>>
│                                          // 按布料部位分组（PART1 / PART2）
│
├── m_physicsClothWeight: float           // 当前物理布料模拟权重 [0, 1]
├── m_lastPhysicsClothWeight: float       // 上一帧物理布料权重（用于检测变化）
├── m_isForceSetPhysicsClothWeight: bool  // 是否强制锁定物理布料权重
├── m_forcePhysicsClothWeight: float      // 强制锁定的权重值
│
├── m_lastPhysicsClothPartWeight: Dictionary<BeyondBoneClothPart, float>
│                                          // 每部位上一帧权重
├── m_isForceSetPhysicsClothPartWeight: Dictionary<BeyondBoneClothPart, bool>
│                                          // 每部位是否强制锁定
├── m_forcePhysicsClothPartWeight: Dictionary<BeyondBoneClothPart, float>
│                                          // 每部位强制权重值
│
└── m_timeRef: float                      // 时间参考（用于动画层权重时间缩放）
`

**枚举定义**:
`csharp
public enum BeyondBoneClothPart
{
    PART1 = 1,
    PART2 = 2
}
`

**静态成员**:
`csharp
public static Dictionary<BeyondBoneClothPart, string> BeyondBoneClothPartToBonePostfix;
// 将枚举部位映射到骨骼后缀字符串
`

**常量定义**:
`csharp
private const float MAGICA_CLOTH_WEIGHT_INCREASE_SPEED = 8f;  // 权重增加速率
private const float MAGICA_CLOTH_WEIGHT_DECREASE_SPEED = 3f;  // 权重减少速率
private const float DEFAULT_CLOTH_STABILIZATION_TIME = 0.1f;  // 默认布料稳定时间
`

### 2.2 布料权重计算（距离/质量驱动）

ClothCalculator 的核心算法 CalcCloth(float deltaTime) 按以下步骤计算布料权重：

`
输入: deltaTime
输入(隐式): NPC 距离(LOD)、质量配置(PhysicsClothQuality)、动画参数
  |
  +-- 1. 从 NPCAnimDefine 读取布料相关浮点参数（~16 个参数）
  |     - ClothLayerWeight, BodyLayerWeight, 循环层权重, 时间缩放等
  |
  +-- 2. 计算 ClothBase 层权重和 LoopClothAddLayer 层权重
  |     - 从动画参数中获取基值
  |     - 应用循环层叠加（m_loopClothWeightRef / m_loopBodyWeightRef）
  |
  +-- 3. 计算物理布料权重 targetWeight
  |     - 从质量配置（LOD/距离）读取目标布料启用因子
  |     - 乘以动画参数中的物理布料权重系数
  |     - 应用 Clamp01 确保范围 [0, 1]
  |
  +-- 4. 权重平滑过渡（核心过渡逻辑）
  |     - 若 targetWeight > m_physicsClothWeight:
  |         使用增量速率 8f/s 向上逼近
  |     - 若 targetWeight < m_physicsClothWeight:
  |         使用减量速率 3f/s 向下逼近
  |     - 具体实现: MoveTowards(m_physicsClothWeight, targetWeight, rate * deltaTime)
  |
  +-- 5. 设置动画层权重
  |     - 通过 SetLayerWeight(m_clothBaseLayerID, clothLayerWeight)
  |     - 通过 SetLayerWeight(m_loopClothLayerID, loopClothWeight)
  |     - 通过 SetLayerWeight(m_loopBodyLayerID, loopBodyWeight)
  |     - 通过 SetLayerWeight(m_clothCombineLayerID, combineWeight)
  |
  +-- 6. 写入 NPCAnimDefine 参数（SetFloat）
       - 将计算后的各层权重写回 NPCAnimDefine
       - 供其他动画系统（如 BlendShape、动态骨骼）消费
`

### 2.3 动画流路径 vs Animator 路径（双路径支持）

ClothCalculator 定义了抽象接口，由两个子类分别实现不同路径：

**抽象接口契约**:
`csharp
public abstract float GetFloat(string key);
public abstract float GetFloat(int hashKey);
public abstract void SetFloat(string key, float value);
public abstract void SetFloat(int hashKey, float value);
public abstract void SetLayerWeight(int layerId, float weight);
public abstract void SetInteger(string key, int value);
public abstract int GetInteger(string key);
public abstract int GetInteger(int hashKey);
protected abstract bool IsLookAtValid(bool isCheck);
public abstract LookAtControllerHolder lookAtController { get; }
`

双路径设计使 CalcCloth 和 UpdateDynamicBone 的核心业务逻辑与底层动画数据读取方式解耦。

### 2.4 权重过渡速率（增量 8f/s，减量 3f/s）

布料权重过渡是系统的关键特性，使用 **非对称速率** 实现自然的布料行为：

| 方向 | 速率 | 语义 |
|------|------|------|
| 权重增加（布料激活） | 8.0 units/s | 快速启用布料，避免延迟感 |
| 权重减少（布料冻结） | 3.0 units/s | 缓慢降低布料权重，避免布料突然僵硬造成的视觉弹跳 |

**实现原理**:
- 使用 Mathf.MoveTowards(current, target, maxDelta) 
- maxDelta 根据 	arget > current 选择增量或减量速率，乘以 deltaTime
- 当 m_isForceSetPhysicsClothWeight == true 时，跳过过渡直接使用 m_forcePhysicsClothWeight

**部位独立过渡**:
- 对于 BeyondBoneClothPart.PART1 和 PART2，每个部位维护独立的权重过渡状态
- 保存在 m_lastPhysicsClothPartWeight 中
- 通过 SetForcePhysicsClothPart1Weight / SetForcePhysicsClothPart2Weight 逐部位控制

### 2.5 公共方法清单

| 方法 | 签名 | 功能 |
|------|------|------|
| CalcCloth | (float deltaTime) | 主布料计算入口：计算权重 + 过渡 + 设置动画层 |
| SetForcePhysicsClothWeight | (bool isForceSetOn, float forceClothWeight) | 强制锁定全局布料权重 |
| SetForcePhysicsClothPartWeight | (BeyondBoneClothPart, bool, float) | 强制锁定指定部位的布料权重 |
| SetForcePhysicsClothPart1Weight | (bool, float) | 锁定 PART1 权重（简写） |
| SetForcePhysicsClothPart2Weight | (bool, float) | 锁定 PART2 权重（简写） |
| UpdateDynamicBone | (float deltaTime, bool clothLodEnable, bool thisFrameWeightZero = false) | 将当前布料权重同步到 BeyondBoneCloth 组件 |
| UpdateBeyondClothEnabled | (bool clothLodEnable) | 根据 LOD 状态启用/禁用 BeyondBoneCloth |
| TeleportClothUseRelativeTransform | (Vector3 pos, Quaternion rot) | 传送时通知布料使用相对变换 |
| ResetCloth | (bool bIsSoft, bool keepPose = false) | 重置布料状态（软重置/硬重置） |
| ResetStablizationTime | () | 重置所有 BeyondBoneCloth 的稳定时间 |
| SetStablizationTimeOne | () | 将所有 BeyondBoneCloth 的稳定时间设置为 1 |

---

## 3. AnimationStreamClothCalculator vs AnimatorClothCalculator 的区别

| 对比维度 | AnimationStreamClothCalculator | AnimatorClothCalculator |
|----------|-------------------------------|------------------------|
| **底层引擎** | ScriptAnimationJobSyncMono（Job 系统） | NPCCPUAnimator + UnityEngine.Animator |
| **isStreamClothCalculator** | 	rue | alse |
| **LookAtController 类型** | AnimationStreamLookAtControllerHolder（包装 Job 同步器） | AnimatorLookAtControllerHolder（包装 NPCLookAtController） |
| **GetFloat 实现** | 委托到 ScriptAnimationJobSyncMono.GetFloatFromStream() | 委托到 UnityEngine.Animator.GetFloat() |
| **SetFloat 实现** | 委托到 ScriptAnimationJobSyncMono.SetFloatToStream() | 委托到 UnityEngine.Animator.SetFloat() |
| **SetLayerWeight** | 委托到 ScriptAnimationJobSyncMono.SetLayerWeight() | 委托到 UnityEngine.Animator.SetLayerWeight() |
| **GetInteger/SetInteger** | 委托到 Job 同步器的 GetIntegerFromStream/SetIntegerToStream | 委托到 UnityEngine.Animator.GetInteger/SetInteger |
| **IsLookAtValid** | 委托到 ScriptAnimationJobSyncMono.IsLookAtValid() | 委托到 NPCCPUAnimator.IsLookAtValid() |
| **层索引解析** | ScriptAnimationJobSyncMono.GetLayerInputIndex("ClothBase") | UnityEngine.Animator.GetLayerIndex("ClothBase") |
| **构造参数** | (ScriptAnimationJobSyncMono, List<BeyondBoneCloth>, Dictionary?) | (NPCCPUAnimator, Animator, List<BeyondBoneCloth>) |
| **使用场景** | GPU Animation / Animation Job 管线中的 NPC | 传统 Animator Controller 驱动的 NPC |

**LookAtControllerHolder 差异**:
- AnimationStreamLookAtControllerHolder 持有 ScriptAnimationJobSyncMono，其 lookAtDegrees 返回 default(LookAtDegree)，表示 Stream 路径不提供注视度数
- AnimatorLookAtControllerHolder 持有 NPCLookAtController，通过 NPCCPUAnimator 内部引用访问

---

## 4. NPCAvatarManager 中的布料集成

### 4.1 布料权重管理（每 NPC）

NPCAvatarManager 在构建 NPC Avatar 时，通过 _BuildBeyondCloth 方法为每个 NPC 实例化布料系统：

`csharp
private static void _BuildBeyondCloth(
    NPCAvatarMeshAssetsSO assetMeshConfig,   // 网格资产配置
    Animator animator,                        // NPC 的 Animator
    ref FNPCAvatarGOReference cpInfo,         // Avatar GO 引用（输出）
    GameObject avatarGo                       // NPC 的 GameObject
)
`

**构建流程**:
1. 从 ssetMeshConfig.GetBoneClothItems() 获取 BoneClothItem 列表
2. 遍历每个 BoneClothItem，通过 GameObjectUtils.TryAddComponentSafely<BeyondBoneCloth>() 添加组件
3. 为布料系统添加碰撞体（CapsuleCollider / PlaneCollider / SphereCollider）
4. 调用 BeyondBoneCloth.GetSerializeData2() 和 ClothSerializeData.Import() 导入序列化数据
5. 调用 BeyondBoneCloth.Initialize() 初始化布料模拟
6. 将生成的 BeyondBoneCloth 实例收集到 List<BeyondBoneCloth> 中，供 ClothCalculator 使用

NPCAvatarManager 还定义 PROFILER_BUILD_CLOTH 性能标记，用于性能分析。

### 4.2 过场动画中的 BipedIK 禁用

当 NPC 参与过场动画（Timeline/Cutscene）时，NPCAvatarManager 通过以下方法禁用 BipedIK：

`csharp
private static void _DisableBipedIKForTimelineCharacter(
    in FNpcAvatarGenericParams avatarParams,   // NPC 通用参数
    NPCDowngradeConfig config,                 // 降级配置
    GameObject avatargo                        // NPC 的 GameObject
)
`

**实现逻辑**:
1. 通过 GameObject.GetComponentInChildren<RootMotion.FinalIK.BipedIK>() 获取 BipedIK 组件
2. 依据降级配置（NPCDowngradeConfig）决定是否禁用

此机制与布料集成的关系：当 BipedIK 在过场中被禁用时，布料系统的 IK 联动也随之断开，布料完全由动画驱动。

### 4.3 远距离 NPC 质量降级

UpdateDynamicBone 和 UpdateBeyondClothEnabled 方法接收 clothLodEnable 参数，实现基于距离/LOD 的质量降级：

**降级策略**:
- clothLodEnable == false: 远距离 NPC，布料权重强制为 0，布料模拟完全禁用
- clothLodEnable == true: 正常距离 NPC，布料权重基于距离计算

UpdateBeyondClothEnabled(bool clothLodEnable):
- 当 clothLodEnable == false 时，遍历 m_boneCloths 禁用所有 BeyondBoneCloth 组件
- 当 clothLodEnable == true 时，若 m_physicsClothWeight > 0，重新启用组件

---

## 5. 数据流

### 5.1 完整数据流拓扑

`
+----------------------------------------------------------+
|  NPC 运行时环境                                            |
|  +-------------+  +----------------+  +--------------+    |
|  | NPC 位置/距离 |  | PhysicsCloth   |  | 动画参数      |   |
|  | (LOD 系统)   |  | Quality        |  | (NPCAnimDef) |   |
|  +------+-------+  +-------+--------+  +------+-------+   |
|         |                  |                  |            |
|         +------------------+------------------+            |
|                            v                               |
|  +------------------------------------------------------+ |
|  |  ClothCalculator.CalcCloth(deltaTime)                | |
|  |                                                      | |
|  |  1. 读取动画参数 (GetFloat)                          | |
|  |     - ClothLayerWeight, BodyLayerWeight               | |
|  |     - LoopClothWeight, LoopBodyWeight                 | |
|  |     - 循环层叠加参数, 时间缩放                        | |
|  |                                                      | |
|  |  2. 计算目标权重 (targetWeight)                       | |
|  |     = LOD因子 * 质量配置 * 动画参数                   | |
|  |                                                      | |
|  |  3. 权重平滑过渡 (MoveTowards)                        | |
|  |     m_physicsClothWeight                              | |
|  |     = MoveTowards(current, target, rate * dt)         | |
|  |                                                      | |
|  |  4. 设置动画层权重 (SetLayerWeight)                    | |
|  |     - ClothBase, LoopClothAddLayer                    | |
|  |     - LoopBodyAddLayer, ClothCombineLayer              | |
|  |                                                      | |
|  |  5. 回写 NPCAnimDefine 参数 (SetFloat)                | |
|  +------------------------+-----------------------------+ |
|                           |                               |
|                           v                               |
|  +------------------------------------------------------+ |
|  |  ClothCalculator.UpdateDynamicBone(                   | |
|  |      deltaTime, clothLodEnable, weightZero)           | |
|  |                                                      | |
|  |  1. 检查 clothLodEnable                               | |
|  |  2. 计算每部位权重（考虑强制覆盖）                      | |
|  |  3. 遍历 m_boneCloths，调用                            | |
|  |     SetClothSimulateWeightIgnorePlaying(weight)       | |
|  |  4. 遍历 m_separateBoneCloth (分部位)                  | |
|  |     设置各部位独立权重                                  | |
|  +------------------------+-----------------------------+ |
|                           |                               |
|                           v                               |
|  +------------------------------------------------------+ |
|  |  BeyondDynamicBone.BeyondBoneCloth                   | |
|  |                                                      | |
|  |  接收: SetClothSimulateWeightIgnorePlaying(float)     | |
|  |         - 控制布料物理模拟的启停权重                    | |
|  |         - 权重 = 0 时布料冻结                         | |
|  |         - 权重 = 1 时布料完全模拟                      | |
|  |                                                      | |
|  |  其他操作:                                            | |
|  |  - Initialize() -- 初始化布料模拟                     | |
|  |  - ResetCloth() -- 重置布料状态                       | |
|  |  - SoftResetCloth() -- 软重置                        | |
|  |  - SetRelativeTransform() -- 传送变换                 | |
|  |  - SetClothStablizationTimeAfterResetIgnorePlaying() | |
|  +------------------------------------------------------+ |
+----------------------------------------------------------+
`

### 5.2 中间产物

| 产物 | 类型 | 生产者 | 消费者 |
|------|------|--------|--------|
| 布料权重 | float | ClothCalculator | BeyondBoneCloth |
| 动画层权重 | float (per layer) | CalcCloth | SetLayerWeight |
| 部位独立权重 | float (per part) | UpdateDynamicBone | SetClothSimulateWeightIgnorePlaying |

---

## 6. 权重过渡算法伪代码

### 6.1 平滑过渡（Core Transition）

```
// 全局布料权重过渡
FUNCTION SmoothClothWeightTransition(currentWeight, targetWeight, deltaTime):
    IF targetWeight > currentWeight:
        rate = MAGICA_CLOTH_WEIGHT_INCREASE_SPEED  // 8.0
    ELSE:
        rate = MAGICA_CLOTH_WEIGHT_DECREASE_SPEED  // 3.0
    newWeight = MoveTowards(currentWeight, targetWeight, rate * deltaTime)
    RETURN newWeight
END FUNCTION
```

### 6.2 CalcCloth 主流程

```
FUNCTION CalcCloth(deltaTime):
    // 1. 从 NPCAnimDefine 读取动画参数
    clothLayerWeight   = GetFloat("ClothLayerWeight")
    bodyLayerWeight    = GetFloat("BodyLayerWeight")
    loopClothWeight    = GetFloat("LoopClothWeight")
    loopBodyWeight     = GetFloat("LoopBodyWeight")
    physicsClothFactor = GetFloat("PhysicsClothFactor")

    // 2. 计算循环层参考权重
    m_loopClothWeightRef = Clamp01(loopClothWeight)
    m_loopBodyWeightRef  = Clamp01(loopBodyWeight)

    // 3. 计算基权重和循环层权重
    baseClothWeight = clothLayerWeight + m_loopClothWeightRef
    baseBodyWeight  = bodyLayerWeight  + m_loopBodyWeightRef

    // 4. 从质量配置获取物理布料权重因子
    qualityFactor = GetPhysicsClothQualityFactor()   // [0, 1]
    lodFactor     = GetNPCLODFactor()                // [0, 1]
    targetPhysicsWeight = Clamp01(physicsClothFactor * qualityFactor * lodFactor)

    // 5. 平滑过渡
    IF m_isForceSetPhysicsClothWeight:
        m_physicsClothWeight = m_forcePhysicsClothWeight
    ELSE:
        m_physicsClothWeight = SmoothClothWeightTransition(
            m_physicsClothWeight, targetPhysicsWeight, deltaTime)

    // 6. 设置 Layer Weight
    SetLayerWeight(m_clothBaseLayerID, baseClothWeight)
    SetLayerWeight(m_loopClothLayerID, m_loopClothWeightRef)
    SetLayerWeight(m_loopBodyLayerID, m_loopBodyWeightRef)

    // 7. 计算混合层权重
    combineWeight = baseClothWeight * m_physicsClothWeight
    SetLayerWeight(m_clothCombineLayerID, combineWeight)

    // 8. 回写参数到 NPCAnimDefine
    SetFloat("PhysicsClothBlendWeight", m_physicsClothWeight)
    SetFloat("ClothBaseBlendWeight", baseClothWeight)
END FUNCTION
```

### 6.3 UpdateDynamicBone 主流程

```
FUNCTION UpdateDynamicBone(deltaTime, clothLodEnable, thisFrameWeightZero = false):
    // 1. 处理 LOD 降级
    IF clothLodEnable == false:
        weightDecreaseRate = MAGICA_CLOTH_WEIGHT_DECREASE_SPEED  // 3.0
        m_physicsClothWeight = MoveTowards(
            m_physicsClothWeight, 0.0, weightDecreaseRate * deltaTime)
        clothWeight = 0.0
    ELSE:
        clothWeight = m_physicsClothWeight

    // 2. 强制覆盖
    IF m_isForceSetPhysicsClothWeight:
        clothWeight = m_forcePhysicsClothWeight

    // 3. thisFrameWeightZero
    IF thisFrameWeightZero:
        clothWeight = 0.0

    // 4. 同步到主布料列表
    FOR EACH boneCloth IN m_boneCloths:
        boneCloth.SetClothSimulateWeightIgnorePlaying(clothWeight)
    m_lastPhysicsClothWeight = clothWeight

    // 5. 同步到分部位布料列表
    FOR EACH part IN m_separateBoneCloth.Keys:
        partWeight = clothWeight
        IF m_isForceSetPhysicsClothPartWeight[part]:
            partWeight = m_forcePhysicsClothPartWeight[part]
        ELSE IF m_lastPhysicsClothPartWeight.ContainsKey(part):
            partWeight = SmoothClothWeightTransition(
                m_lastPhysicsClothPartWeight[part], partWeight, deltaTime)
        FOR EACH boneCloth IN m_separateBoneCloth[part]:
            boneCloth.SetClothSimulateWeightIgnorePlaying(partWeight)
        m_lastPhysicsClothPartWeight[part] = partWeight
END FUNCTION
```

### 6.4 权重强制覆盖机制

```
FUNCTION SetForcePhysicsClothWeight(isForceSetOn, forceClothWeight):
    m_isForceSetPhysicsClothWeight = isForceSetOn
    m_forcePhysicsClothWeight = forceClothWeight
END FUNCTION

FUNCTION SetForcePhysicsClothPartWeight(part, isForceSetOn, forceClothWeight):
    m_isForceSetPhysicsClothPartWeight[part] = isForceSetOn
    m_forcePhysicsClothPartWeight[part] = forceClothWeight
END FUNCTION

FUNCTION SetForcePhysicsClothPart1Weight(isForceSetOn, forceClothWeight):
    SetForcePhysicsClothPartWeight(PART1, isForceSetOn, forceClothWeight)
END FUNCTION

FUNCTION SetForcePhysicsClothPart2Weight(isForceSetOn, forceClothWeight):
    SetForcePhysicsClothPartWeight(PART2, isForceSetOn, forceClothWeight)
END FUNCTION
```

---

## 7. 与 BeyondDynamicBone 的桥接方式

### 7.1 桥接架构

```
ClothCalculator (abstract)
    |
    +-- 拥有: List<BeyondBoneCloth> m_boneCloths
    +-- 拥有: Dictionary<BeyondBoneClothPart, List<BeyondBoneCloth>> m_separateBoneCloth
    |
    +-- UpdateDynamicBone() ----> BeyondBoneCloth.SetClothSimulateWeightIgnorePlaying(float)
    +-- UpdateBeyondClothEnabled() -> BeyondBoneCloth.enabled (组件启用/禁用)
    +-- ResetCloth() ----------> BeyondBoneCloth.ResetCloth() / SoftResetCloth()
    +-- ResetStablizationTime() -> BeyondBoneCloth.SetClothStablizationTimeAfterResetIgnorePlaying(0.1f)
    +-- SetStablizationTimeOne() -> BeyondBoneCloth.SetClothStablizationTimeAfterResetIgnorePlaying(1.0f)
    +-- TeleportClothUseRelativeTransform()
                               -> BeyondBoneCloth.SetRelativeTransform(Vector3, Quaternion)
```

### 7.2 桥接接口映射

| ClothCalculator 方法 | BeyondBoneCloth 方法 | 数据类型 |
|----------------------|----------------------|----------|
| UpdateDynamicBone | SetClothSimulateWeightIgnorePlaying(weight) | float [0, 1] |
| UpdateBeyondClothEnabled | enabled = true/false | bool |
| ResetCloth(bIsSoft=false) | ResetCloth(keepPose) / SoftResetCloth() | bool |
| ResetStablizationTime | SetClothStablizationTimeAfterResetIgnorePlaying(0.1f) | float (DEFAULT) |
| SetStablizationTimeOne | SetClothStablizationTimeAfterResetIgnorePlaying(1.0f) | float (1.0) |
| TeleportClothUseRelativeTransform | SetRelativeTransform(pos, rot) | Vector3, Quaternion |

### 7.3 布料构建时的桥接（NPCAvatarManager._BuildBeyondCloth）

在 NPC Avatar 构建阶段，NPCAvatarManager 完成布料组件的初始化：

```
1. 从 assetMeshConfig.GetBoneClothItems() 获取 BoneClothItem 列表
2. 对于每个 BoneClothItem:
   a. 在 avatarGo 上查找目标骨骼
   b. GameObjectUtils.TryAddComponentSafely<BeyondBoneCloth>(boneGameObject)
   c. 从 BoneClothItem 读取序列化数据 (ClothSerializeData)
   d. beyondBoneCloth.GetSerializeData2() -> serializeData
   e. serializeData.Import(configData) -> 导入配置
   f. 添加碰撞体 (Capsule/Plane/Sphere)
   g. beyondBoneCloth.Initialize() -> 初始化模拟
   h. 将 beyondBoneCloth 加入 m_boneCloths 列表
3. 按部位分组 (PART1/PART2) 存入 m_separateBoneCloth
```

### 7.4 部位隔离机制

布料系统支持按 BeyondBoneClothPart 进行部位隔离，允许不同部位独立控制权重：

```
BeyondBoneClothPart.PART1          BeyondBoneClothPart.PART2
       |                                  |
       v                                  v
List<BeyondBoneCloth> part1        List<BeyondBoneCloth> part2
       |                                  |
       +-- 衣服前摆                        +-- 衣服后摆
       +-- 腰带                            +-- 披风
       +-- ...                             +-- ...
```

部位隔离的用途：
- **过场动画中**：可为 PART1 设置强制权重 = 0（禁用前摆物理），PART2 保持正常
- **性能优化**：根据距离逐部位降级（先禁用次要部位）
- **Bug 修复**：特定部位布料异常时，可单独重置而不影响其他部位

---

> **文档版本**: 1.0
> **覆盖范围**: NPC 布料集成层的全部公开接口、字段语义、数据流拓扑
> **净室声明**: 本文档基于对目标二进制行为的观察和标准布料权重管理模式的推导编写，不包含原代码的直接复制。所有算法描述均为通用工程模式的重新表述。
