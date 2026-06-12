# NPC LookAt IK 净室实现文档

> **基于 IL2CPP/IFix 混淆代码逆向分析**
> **文件清单**: NPCLookAtController.cs (6625行), NPCLookAtAvatar.cs, NPCCPUAnimationLookAtIkInfo.cs, NPCCPUAnimationLookAtControllerParams.cs, LookAtDegree.cs, LookAtControllerHolder.cs, FEyeOffsetVector.cs
> **用途**: 提供给 AI 完全重新实现 NPC LookAt IK 系统的详细规格

---

## 1. 系统概述

### 1.1 目的

NPC LookAt IK 系统控制 NPC 角色注视目标（玩家、兴趣点等），支持以下功能：

- 眼部追踪：双眼跟随目标，带角度限位
- 头部追踪：头部骨骼朝向目标
- 脊椎分布：将头部旋转按权重分布到脊椎骨骼链
- 平滑切换：目标切换/权重混合/眼部权重均使用 SmoothDamp 平滑
- 角度钳位：超出 maxAngle 的目标被钳位到视野圆锥边界
- 传送恢复：角色或目标传送后自动恢复注视状态
### 1.2 系统架构

```
[外部调用] -- LookAtTarget / LookAtEntity / LookAtAxis
       |
       v
[NPCLookAtController] (主控制器, 6625行)
  +-- 目标管理 (Entity/Transform/Axis 三种模式)
  +-- 权重平滑 (_SmoothAllWeights)
  +-- 目标位置计算 (_UpdateFinalPositionHead/Eye)
  +-- 动画参数计算 (_ComputeAnimParameter -> NPCCPUAnimator)
  +-- 眼部 IK 计算 (_ComputeEyeLookAt -> _ApplyEyeLookAt -> NPCCPUAnimator.SetEyeLookAtVector)
  +-- 传送恢复 (OnTransformTeleported -> _UpdateInternalTargets)
       |
       v
[NPCLookAtAvatar] (骨骼系统)
  +-- headPivotBone (头部旋转中心)
  +-- headBone (头部朝向)
  +-- spineBones[] (脊椎骨骼数组)
  +-- maxEyeAngleHorizontal / maxEyeAngleVertical
       |
       v
[NPCCPUAnimator] (负责实际骨骼旋转)
  +-- SetEyeLookAtVector(up, down, left, right)
  +-- SetLookAtEyeBlendTime(time)

[NPCCPUAnimationLookAtIkInfo] -- 初始化时读取的配置
[NPCCPUAnimationLookAtControllerParams] -- 序列化参数
```

---

## 2. 所有类定义

### 2.1 NPCCPUAnimationLookAtIkInfo

**文件**: NPCCPUAnimationLookAtIkInfo.cs
**命名空间**: Beyond.NPC.Animation
**角色**: 从外部配置读取的 LookAt IK 基础数据

```csharp
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Beyond.NPC.Animation
{
    [Serializable]
    public class NPCCPUAnimationLookAtIkInfo
    {
        public bool bEnableIK;                    // IK 总开关
        public string headBoneName;               // 头部骨骼名称 (用于查找)
        public int headBoneIndex;                 // 头部骨骼索引
        public string eyeRefBoneName;             // 眼部参考骨骼名称
        public int eyeRefBoneIndex;               // 眼部参考骨骼索引
        public List<string> spineBoneShortNames;   // 脊椎骨骼短名列表
        public List<int> spineBoneIndices;         // 脊椎骨骼索引列表
        public Vector3 eyeBoneOffset;             // 眼部骨骼偏移量
        public float maxEyeAngleHorizontal;       // 眼部水平最大角度 (度)
        public float maxEyeAngleVertical;         // 眼部垂直最大角度 (度)
    }
}
```
### 2.2 NPCCPUAnimationLookAtControllerParams

**文件**: NPCCPUAnimationLookAtControllerParams.cs
**命名空间**: Beyond.NPC.Animation
**角色**: 序列化参数配置，全部带有 Tooltip

```csharp
using System;
using UnityEngine;

namespace Beyond.NPC.Animation
{
    [Serializable]
    public class NPCCPUAnimationLookAtControllerParams
    {
        [Tooltip("The time it takes to switch targets.")]
        public float targetSwitchSmoothTime;

        [Tooltip("The time it takes to blend in/out of LookAtIK weight.")]
        public float weightSmoothTime;

        [Tooltip("The time it takes to blend in/out of LookAtIK Eye weight.")]
        public float eyeWeightSmoothTime;

        [Tooltip("Minimum distance of looking from the first bone. Keeps from failing if target is too close.")]
        public float minDistance;
        public const float DEFAULT_MIN_DISTANCE = 1f;

        [Tooltip("Maximum yaw angle between look at vector and character forward. If larger, will not look.")]
        public float maxAngle;
        public const float DEFAULT_MAX_ANGLE = 45f;
    }
}
```

### 2.3 NPCLookAtAvatar

**文件**: NPCLookAtAvatar.cs
**命名空间**: Beyond.NPC.Avatar
**角色**: 存储 NPC 骨骼系统中与 LookAt 相关的 Transform 引用

```csharp
using System;
using UnityEngine;

namespace Beyond.NPC.Avatar
{
    [Serializable]
    public class NPCLookAtAvatar
    {
        // ===== 常量 =====
        public const float ANIMATION_LOOKAT_HORIZONTAL_DEFAULT_DEGREE = 45f;
        public const float ANIMATION_LOOKAT_VERTICAL_DEFAULT_DEGREE = 30f;

        // ===== 私有字段 (getter/setter 包裹) =====
        private float m_maxEyeAngleHorizontal;
        private float m_maxEyeAngleVertical;

        // ===== 公开字段 =====
        public bool valid;
        public Transform headPivotBone;        // 头部枢轴 (旋转中心)
        public Transform headBone;             // 头部朝向骨骼
        public Transform[] spineBones;         // 脊椎骨骼数组

        // ===== 属性 (clamp [0, 90]) =====
        public float maxEyeAngleHorizontal { get; set; }
        public float maxEyeAngleVertical   { get; set; }

        // ===== 方法 =====
        public void Clear();  // 清空所有引用, valid = false
    }
}
```
### 2.4 NPCLookAtController

**文件**: NPCLookAtController.cs (6625行)
**命名空间**: Beyond.NPC.Animation
**角色**: NPC 注视系统的主控制器

#### 2.4.1 内部结构 LookAtAxes

```csharp
private struct LookAtAxes
{
    [Range(-1f, 1f)]
    public float horizontal;     // 水平轴 [-1, 1] (负=左, 正=右)

    [Range(-1f, 1f)]
    public float vertical;       // 垂直轴 [-1, 1] (负=下, 正=上)

    public Vector3 modelSpaceVector { get; }  // 模型空间注视方向
    public Vector3 headSpaceVector { get; }   // 头部空间注视方向

    public void Set(float inHorizontal, float inVertical);
    
    // 隐式转换 LookAtAxes <-> Vector2
    public static implicit operator Vector2(LookAtAxes value);
    public static implicit operator LookAtAxes(Vector2 value);
    
    private static Vector3 _GetLookAtVector(LookAtAxes axes, bool useModelSpace);
}
```

#### 2.4.2 公开属性

```csharp
public Transform target       { get; private set; }  // 注视目标
public Transform eyeTarget    { get; private set; }  // 眼部注视目标
public Vector3 offset         { get; set; }           // 注视偏移
public bool separateEyeTarget { get; set; }            // 独立眼部目标
public float weightBase       { get; }                 // 基础权重
public float headWeight       { get; }                 // 头部权重 (计算值)
public LookAtDegree lookAtDegrees { get; }             // 当前注视角度
public bool inited            { get; private set; }    // 是否已初始化
public bool isValid           { get; }                 // 控制器是否有效
```

#### 2.4.3 私有字段完整列表

```csharp
// 静态字段
private static readonly HashSet<int> mustHaveParams;

// ID/引用
private string m_npcId;
private uint m_instanceUid;
private NPCCPUAnimator m_cpuAnimator;
private NPCLookAtAvatar m_avatar;
private NPCCPUAnimationLookAtControllerParams m_params;
private Transform m_animatorT;

// 内部 Transform
private Transform m_pivot;                 // LookAt_PivotChest
private Transform m_headPivot;             // 头部枢轴骨骼
private Transform m_headMovable;           // 头部可动骨骼
private Transform m_fakeTarget;            // LookAt_Target (内部伪目标)
private Transform m_fakeTargetEye;         // LookAt_EyeTarget

// 启用标志
private bool m_enable;                     // 总启用
private bool m_headEnable;                 // 头部启用
private bool m_eyeEnable;                  // 眼部启用

// 目标轴
private LookAtAxes m_targetAxes;
private LookAtAxes m_targetAxesEye;
private bool m_followOutOfRangeTarget;
private bool m_followOutOfRangeTargetEye;
private bool m_useWorldSpaceAxes;
private bool m_useWorldSpaceAxesEye;

// 目标缓存
private uint m_newTargetInstanceUid;
private bool m_newTargetValid;

// 速度自适应参数
private float m_minHeadRotSpeedRad;
private float m_maxHeadRotSpeedRad;
private float m_minHeadRotLerpFactor;
private float m_maxHeadRotLerpFactor;

// 权重系统 (6组 SmoothDamp)
private float m_bodyWeight;
private float m_bodyWeightTarget;
private float m_bodyWeightVel;
private float m_bodyWeightSmoothTime;
private float m_weightBase;
private float m_weightBaseVel;
private float m_weightBaseSmoothTime;
private float m_headLerpWeight;
private float m_headLerpWeightVel;
private float m_headTargetSwitchSmoothTime;
private float m_eyeLerpWeight;
private float m_eyeLerpWeightVel;
private float m_eyeTargetSwitchSmoothTime;
private float m_rollCorrectionWeight;
private float m_rollCorrectionWeightTarget;
private float m_rollCorrectionWeightSmoothTime;
private float m_rollCorrectionWeightVel;
private float m_headRotateAmount;
private float m_headRotateAmountTarget;
private float m_headRotateAmountVel;

// 原始方向 (初始化时记录)
private Vector3 m_originalFwdLocal;
private Vector3 m_originalRightLocal;
private Vector3 m_originalUpLocal;

// 脏标记
private bool m_dirtyFakeTarget;
private bool m_dirtyFakeTargetEye;
private bool m_skipUpdate;

// 传送/状态
private int m_lastTpFrameCount;
private bool m_lastSeparateEyeTarget;
private bool m_targetInRange;
private bool m_lastTargetInRange;
private bool m_targetInRangeEye;

// 位置/向量缓存
private Transform m_lastTarget;
private LookAtAxes m_lastTargetAxes;
private Transform m_lastTargetEye;
private Vector3 m_targetPos;
private Vector3 m_lastTargetPos;
private Vector3 m_lastTargetVector;
private float m_targetAngleDegree;
private float m_lastTargetAngleDegree;
private Vector3 m_inRangeTargetPos;
private Vector3 m_inRangeTargetPosEye;
private Vector3 m_finalPosition;
private Vector3 m_finalPositionEye;
private Vector3 m_lastFinalPos;
private Vector3 m_lastFinalPosEye;
private Quaternion m_lastFrameHeadPivotRot;
private float m_poseDifferenceDeg;
private float m_outOfRangeAngleDeg;
private LookAtDegree m_outLookAtDegree;
private FEyeOffsetVector m_outEyeOffset;
```
#### 2.4.4 公开方法签名

```csharp
// 初始化/释放
public bool Init(Animator animator, NPCCPUAnimator npcCPUAnimator,
    NPCLookAtAvatar lookAtAvatar,
    NPCCPUAnimationLookAtControllerParams setting,
    string npcId, uint instanceUid);
public void Release();

// 启用/禁用
public void SetEnable(bool value);
public void SetBodyEnable(bool value);
public void SetEyeEnable(bool value);

// 目标设置
public void SetFollowOutOfRangeTarget(bool value);
public void SetEyeFollowOutOfRangeTarget(bool value);
public void SetSeparateEyeTarget(bool value);

// 权重设置
public void SetBodyAdditiveWeight(float value);        // [0,1]
public void SetRollCorrectionWeight(float value);      // [0,1]
public void SetHeadRotateAmount(float value);          // [0,1]

// 平滑时间
public void SetBodyLookAtTargetSmoothTime(float time);
public void ResetBodyLookAtTargetSmoothTime();
public void SetEyeLookAtTargetSmoothTime(float time);
public void ResetEyeLookAtTargetSmoothTime();

// 注视 API
public bool LookAtEntity(Entity inEntity, MountPoint inMountPoint = MountPoint.LookAtPoint);
public bool LookAtTarget(Transform inTarget);
public void EyeLookAtTarget(Transform inTarget);
public void LookAtAxis(float horizontal, float vertical, bool isWorld = false);
public void EyeLookAtAxis(float horizontal, float vertical, bool isWorld = false);

// 更新
public void PreAnimatorUpdate(float deltaTime);

// 传送
public void OnTransformTeleported(bool selfTeleported, bool targetTeleported);

// 静态工具
public static bool ValidateData(Animator animator, NPCCPUAnimator animatorCom,
    NPCLookAtAvatar lookAtAvatar,
    NPCCPUAnimationLookAtControllerParams inParams);
public static void AssertData(Animator animatorUnity, NPCCPUAnimator animatorCom,
    NPCLookAtAvatar lookAtAvatar,
    NPCCPUAnimationLookAtControllerParams setting);
public static Vector3 CalculateTargetPositionInRange(Transform inTarget,
    Transform inPivot, float maxAngleDeg);
```

### 2.5 LookAtDegree

**文件**: LookAtDegree.cs
**命名空间**: Beyond.NPC.Animation

```csharp
public struct LookAtDegree
{
    public float horizontal;   // 水平角度 (度)
    public float vertical;     // 垂直角度 (度)
    public float roll;         // 滚转角 (度)
}
```

### 2.6 LookAtControllerHolder

**文件**: LookAtControllerHolder.cs
**命名空间**: Beyond.NPC.Animation

```csharp
public abstract class LookAtControllerHolder
{
    public virtual LookAtDegree lookAtDegrees { get; }
    public virtual float weightBase { get; }
}
```

### 2.7 FEyeOffsetVector

**文件**: FEyeOffsetVector.cs
**命名空间**: Beyond.NPC.Animation

```csharp
public struct FEyeOffsetVector
{
    private Vector4 m_vector;  // x=left, y=right, z=up, w=down

    public float left  { get; set; }
    public float right { get; set; }
    public float up    { get; set; }
    public float down  { get; set; }

    public static implicit operator Vector4(FEyeOffsetVector v);
    public static implicit operator FEyeOffsetVector(Vector4 v);
}
```
---

## 3. NPCLookAtController 核心实现逻辑

### 3.1 LookAtAxes 结构

LookAtAxes 是 NPCLookAtController 的内部结构体:

```csharp
struct LookAtAxes
{
    float horizontal;   // [-1, 1]  负值=左, 正值=右
    float vertical;     // [-1, 1]  负值=下, 正值=上
}
```

**隐式转换**:
- LookAtAxes -> Vector2: (horizontal, vertical)
- Vector2 -> LookAtAxes: (x -> horizontal, y -> vertical)

**注视向量计算** (_GetLookAtVector, private static):
```
输入: axes (LookAtAxes), useModelSpace (bool)
输出: Vector3 (归一化的注视方向)

1. h = axes.horizontal
2. v = axes.vertical
3. z = 1 - |h| - |v|    // 投影到 Z 轴 (深度)
4. z = Max(z, 0)         // 确保非负
5. if (!useModelSpace):
6.     h = -h            // 头部空间水平取反
7.     v = -v            // 头部空间垂直取反
8. return Normalize(Vector3(h, v, z))
```

**modelSpaceVector**: useModelSpace=true 时的方向向量。
**headSpaceVector**: useModelSpace=false 时的方向向量 (水平取反)。

### 3.2 目标切换机制

#### 三种目标模式

| 模式 | 设置方法 | 数据源 |
|------|---------|--------|
| Entity 模式 | LookAtEntity(entity, mountPoint) | Entity 的 MountPoint Transform |
| Transform 模式 | LookAtTarget(transform) | 直接指定 Transform |
| Axis 模式 | LookAtAxis(h, v, isWorld) | LookAtAxes (horizontal/vertical) |

#### LookAtTarget 内部流程

```
_LookAtTransformInternal(target):
    m_target = target          // 保存引用
    m_dirtyFakeTarget = false  // 标记需要更新
    return target != null
```

#### LookAtAxis 内部流程

```
LookAtAxis(horizontal, vertical, isWorld):
    _CacheTarget(true, 0)
    m_targetAxes.Set(horizontal, vertical)
    m_useWorldSpaceAxes = isWorld
    
    if (isWorld):
        // 将世界空间 axes 转换为模型空间
        pivotRot = m_pivot.rotation
        lookDir = m_targetAxes.modelSpaceVector  // 模型空间方向
        worldDir = pivotRot * lookDir            // 转到世界空间
        worldPos = m_pivot.position + worldDir * 10.0f
        m_fakeTarget.position = worldPos
        m_dirtyFakeTarget = false
```

### 3.3 权重混合系统

#### 6 组独立 SmoothDamp

_SmoothAllWeights(float deltaTime) 对以下权重执行平滑:

```
序号  权重字段              目标值来源                    平滑时间来源
---   -----------          -----------                  -----------
1     m_headLerpWeight     m_headEnable ? 1 : 0        m_headTargetSwitchSmoothTime
2     m_bodyWeight         m_bodyWeightTarget           m_params.weightSmoothTime
3     m_eyeLerpWeight      m_eyeEnable ? 1 : 0         m_eyeTargetSwitchSmoothTime
4     m_weightBase         LookAtControllerHolder.weightBase  m_weightBaseSmoothTime
5     m_rollCorrectionWeight  m_rollCorrectionWeightTarget   m_rollCorrectionWeightSmoothTime
6     m_headRotateAmount   m_headRotateAmountTarget     m_params.weightSmoothTime

所有平滑使用 _SmoothDampClamp01, 输出钳位到 [0, 1]
```

#### 权重组合公式

```
effectiveHeadWeight = m_headLerpWeight * m_bodyWeight * m_weightBase

此公式意味着:
- headEnable=false => headLerpWeight -> 0 => 头部不旋转
- bodyWeight=0 => 头部不旋转
- weightBase=0 => 头部不旋转 (外部控制)
```

#### _SmoothDampClamp01 算法

```csharp
private static float _SmoothDampClamp01(
    float current, float target,
    ref float currentVelocity,
    float smoothTime, float deltaTime)
{
    // 标准 Unity SmoothDamp 算法:
    float omega = 2.0f / Mathf.Max(smoothTime, 0.0001f);
    float x = omega * deltaTime;
    float exp = 1.0f / (1.0f + x + 0.48f * x * x + 0.235f * x * x * x);
    float change = current - target;
    float temp = (currentVelocity + omega * change) * deltaTime;
    currentVelocity = (currentVelocity - omega * temp) * exp;
    float result = target + (change + temp) * exp;

    // 防止 overshoot
    if (result > target == change > 0)
    {
        result = target;
        currentVelocity = (result - target) / deltaTime;
    }
    
    return Mathf.Clamp01(result);
}
```

### 3.4 头部/脊椎旋转分布

头部和脊椎的旋转分布通过 _ComputeAnimParameter() 计算 (最终由 NPCCPUAnimator 执行):

```
_ComputeAnimParameter():
    1. 计算头部旋转四元数:
       lookDir = m_finalPosition - m_headPivot.position
       targetRot = Quaternion.LookRotation(lookDir, m_headMovable.up)
    
    2. 应用 headRotateAmount:
       if (m_headRotateAmount > 0):
           targetRot = slerp between identity and targetRot
                       使用 m_headRotateAmount 控制程度
    
    3. 计算 headWeight:
       headWeight = m_headLerpWeight * m_bodyWeight * m_weightBase
    
    4. 更新 m_outLookAtDegree:
       从 targetRot 提取 Euler 角度
       m_outLookAtDegree.horizontal = euler.y
       m_outLookAtDegree.vertical = euler.x
       m_outLookAtDegree.roll = euler.z
    
    5. 传递给 NPCCPUAnimator:
       设置头部旋转 (目标四元数 + 权重)
       设置脊椎旋转分布 (权重基于目标角度)
```

**脊椎分布算法** (在 NPCCPUAnimator 中):
```
输入:
- spineBones[]: 脊椎骨骼数组 (从 NPCLookAtAvatar 获取)
- headPivotBone: 头部枢轴
- targetRotation: 目标旋转四元数
- headWeight: 头部注视权重
- targetAngleDeg: 目标相对于前方的角度

流程:
1. angleNormalized = Clamp01(targetAngleDeg / maxAngle)
2. spineInvolvement = angleNormalized * 0.5  (最多 50% 旋转分配给脊椎)
3. headActualWeight = headWeight * (1 - spineInvolvement)

4. 对 spineBones[i] (i从0到n-1, 从下到上):
   boneWeight[i] = ((i+1) / n) * spineInvolvement * headWeight
   spineBones[i].localRotation = Slerp(identity, targetRotation, boneWeight[i])

5. headPivotBone.localRotation = Slerp(identity, targetRotation, headActualWeight)
```

### 3.5 眼部角度钳位

眼部注视角度由 _ComputeEyeLookAt() 计算:

```
_ComputeEyeLookAt():
    1. 获取注视方向:
       if (separateEyeTarget && eyeTarget 有效):
           direction = eyeTarget.position - m_headMovable.position
       else:
           direction = m_finalPositionEye - m_headMovable.position
    
    2. 转换到头部局部空间:
       localDir = headMovable.InverseTransformDirection(direction)
       localDir = Normalize(localDir)
    
    3. 计算角度:
       hAngle = Atan2(localDir.x, localDir.z) * Rad2Deg
       vAngle = Asin(localDir.y) * Rad2Deg  (或 Atan2)
    
    4. 钳位:
       hAngle = Clamp(hAngle, -maxEyeAngleHorizontal, maxEyeAngleHorizontal)
       vAngle = Clamp(vAngle, -maxEyeAngleVertical, maxEyeAngleVertical)
    
    5. 映射到 [-1, 1] 并分解四通道:
       h = hAngle / maxEyeAngleHorizontal
       v = vAngle / maxEyeAngleVertical
       m_outEyeOffset.left  = h < 0 ? -h : 0
       m_outEyeOffset.right = h > 0 ? h : 0
       m_outEyeOffset.up    = v > 0 ? v : 0
       m_outEyeOffset.down  = v < 0 ? -v : 0
```

```
_ApplyEyeLookAt():
    if (!m_eyeEnable) return;
    m_cpuAnimator.SetEyeLookAtVector(
        m_outEyeOffset.up,
        m_outEyeOffset.down,
        m_outEyeOffset.left,
        m_outEyeOffset.right);
```
### 3.6 目标角度钳位 (CalculateTargetPositionInRange)

当目标角度超出 maxAngle 时，目标位置被钳位到注视圆锥边界:

```
public static Vector3 CalculateTargetPositionInRange(
    Transform inTarget, Transform inPivot, float maxAngleDeg)
{
    // 1. 获取目标相对于枢轴的方向和距离
    Vector3 dir = inTarget.position - inPivot.position;
    float dist = dir.magnitude;
    dir /= dist;
    
    // 2. 计算角度
    float angle = AngleBetween(dir, inPivot.forward);
    
    // 3. 如果超出范围, 钳位到圆锥边界
    if (angle > maxAngleDeg)
    {
        // 在目标方向与前方之间的平面上
        Vector3 axis = Vector3.Cross(inPivot.forward, dir);
        float clampedAngle = maxAngleDeg * Mathf.Deg2Rad;
        Vector3 clampedDir = Quaternion.AngleAxis(clampedAngle, axis) * inPivot.forward;
        return inPivot.position + clampedDir * dist;
    }
    
    return inTarget.position;  // 在范围内, 直接返回
}
```

---

## 4. NPCLookAtAvatar 骨骼系统

### 4.1 骨骼配置

| 字段 | 类型 | 说明 |
|------|------|------|
| headPivotBone | Transform | 头部旋转中心 (headBone.parent) |
| headBone | Transform | 头部朝向骨骼 |
| spineBones[] | Transform[] | 脊椎骨骼数组 (从下到上) |
| maxEyeAngleHorizontal | float | 最大水平眼角度 [0, 90], 默认 45 |
| maxEyeAngleVertical | float | 最大垂直眼角度 [0, 90], 默认 30 |
| valid | bool | 数据有效标志 |

### 4.2 骨骼查找 (在 NPCLookAtController.Init 中)

```
查找流程:
1. 通过 headBoneName 从 Animator 骨架查找 headBone
2. headPivotBone = headBone.parent
3. 通过 eyeRefBoneName 查找眼部参考骨骼
4. 通过 spineBoneShortNames 逐个查找 spineBones[]
5. 设置 maxEyeAngleHorizontal/Vertical (从 IkInfo 读取)
6. 如果关键骨骼都存在, valid = true
```

---

## 5. 数据流

### 5.1 完整数据流

```
[外部调用]
    |
    +-- LookAtEntity(entity, mountPoint)
    |       +-- _CacheTarget(true, instanceUid)
    |       +-- entity LookAtPoint -> Transform
    |       +-- _LookAtTransformInternal(transform)
    |
    +-- LookAtTarget(transform)
    |       +-- _CacheTarget(true, 0)
    |       +-- _LookAtTransformInternal(transform)
    |
    +-- LookAtAxis(h, v, isWorld)
            +-- _CacheTarget(true, 0)
            +-- m_targetAxes.Set(h, v)
            +-- m_useWorldSpaceAxes = isWorld

[PreAnimatorUpdate(deltaTime)] <- 每帧调用
    |
    +-- 1. isValid 检查
    +-- 2. _IsSelfTeleported / _IsTargetTeleported
    +-- 3. _ApplyTargetCacheToManager (注册/注销 LookAtManager)
    +-- 4. _UpdatePivotTransform
    +-- 5. _CalculateHorizontalAngle -> m_targetAngleDegree
    +-- 6. if (m_targetAngleDegree > m_params.maxAngle):
    |       if (!m_followOutOfRangeTarget) -> 跳过注视
    |       else -> 钳位到圆锥边界
    +-- 7. _SmoothAllWeights(deltaTime) x6
    +-- 8. _UpdateFinalPositionHead -> m_finalPosition
    +-- 9. _UpdateFinalPositionEye  -> m_finalPositionEye
    +-- 10. _ComputeAnimParameter() -> NPCCPUAnimator (head/spine rotation)
    +-- 11. _ComputeEyeLookAt() -> m_outEyeOffset
    +-- 12. _ApplyEyeLookAt() -> m_cpuAnimator.SetEyeLookAtVector(...)
```

### 5.2 数据流向: NPC Target -> Bone Rotations

```
NPC Target (玩家/兴趣点 Transform)
    |
    |  LookAtTarget(target) / LookAtEntity(entity)
    v
NPCLookAtController
    |
    |  (目标位置 + offset) -> m_targetPos
    |  CalculateTargetPositionInRange 角度钳位
    |  SmoothDamp 权重平滑
    v
m_finalPosition / m_finalPositionEye
    |
    +---> _ComputeAnimParameter()
    |       |
    |       +-- headWeight = headLerpWeight * bodyWeight * weightBase
    |       +-- 目标旋转四元数 -> NPCCPUAnimator
    |       +-- NPCCPUAnimator 执行脊椎分布
    |       v
    |     headPivotBone rotation (头部)
    |     spineBones[] rotation (脊椎)
    |
    +---> _ComputeEyeLookAt() -> _ApplyEyeLookAt()
            |
            +-- 角度钳位 -> maxEyeAngleHorizontal/Vertical
            +-- 分解到 left/right/up/down
            v
          NPCCPUAnimator.SetEyeLookAtVector(up, down, left, right)
            |
            v
          眼部骨骼旋转
```

---

## 6. 参数配置指南

### 6.1 NPCCPUAnimationLookAtControllerParams (序列化参数)

| 参数 | 类型 | 范围 | 默认 | 说明 |
|------|------|------|------|------|
| targetSwitchSmoothTime | float | >0 | 可配置 | 目标切换平滑时间, 越大越平滑 |
| weightSmoothTime | float | >0 | 可配置 | IK 权重淡入淡出时间 |
| eyeWeightSmoothTime | float | >0 | 可配置 | 眼部权重淡入淡出时间 |
| minDistance | float | >0 | 1.0 | 注视最小距离, 避免 IK 失败 |
| maxAngle | float | 0-180 | 45.0 | 最大偏航角, 超出不注视 |

### 6.2 NPCCPUAnimationLookAtIkInfo (配置数据)

| 参数 | 类型 | 说明 |
|------|------|------|
| bEnableIK | bool | IK 总开关 |
| headBoneName | string | 头部骨骼名称 |
| headBoneIndex | int | 头部骨骼索引 |
| eyeRefBoneName | string | 眼部参考骨骼名称 |
| eyeRefBoneIndex | int | 眼部参考骨骼索引 |
| spineBoneShortNames | List<string> | 脊椎骨骼短名列表 |
| spineBoneIndices | List<int> | 脊椎骨骼索引列表 |
| eyeBoneOffset | Vector3 | 眼部骨骼偏移 |
| maxEyeAngleHorizontal | float | 眼部最大水平转角 (度) |
| maxEyeAngleVertical | float | 眼部最大垂直转角 (度) |

### 6.3 权重参数

| 运行时参数 | 设置方法 | 范围 | 说明 |
|-----------|---------|------|------|
| bodyWeight | SetBodyAdditiveWeight | [0,1] | 身体注视权重附加 |
| rollCorrectionWeight | SetRollCorrectionWeight | [0,1] | 滚转校正权重 |
| headRotateAmount | SetHeadRotateAmount | [0,1] | 头部旋转量 |
| headLerpWeight | SetBodyEnable(间接) | [0,1] | 头部启用时=1, 禁用时=0 |
| eyeLerpWeight | SetEyeEnable(间接) | [0,1] | 眼部启用时=1, 禁用时=0 |
| weightBase | LookAtControllerHolder | [0,1] | 外部注入的基础权重 |

### 6.4 NPCLookAtAvatar 常量

| 常量 | 值 | 说明 |
|------|-----|------|
| ANIMATION_LOOKAT_HORIZONTAL_DEFAULT_DEGREE | 45f | 默认水平最大眼角度 |
| ANIMATION_LOOKAT_VERTICAL_DEFAULT_DEGREE | 30f | 默认垂直最大眼角度 |

---

## 7. 关键算法伪代码

### 7.1 目标位置到 LookAtAxes 转换

```
功能: 将目标世界坐标转换为 LookAtAxes (horizontal/vertical)

输入: targetPos, pivotPos, pivotRotation
输出: LookAtAxes

1. direction = targetPos - pivotPos
2. localDir = InverseTransformDirection(pivotRotation, direction)
3. localDir = Normalize(localDir)
4. h = localDir.x / (|localDir.x| + |localDir.z|)
5. v = localDir.y / (|localDir.y| + |localDir.z|)
6. return LookAtAxes(h, v)
```

### 7.2 SmoothDamp 权重平滑

```
功能: 对 6 个独立权重执行平滑混合

_SmoothDampClamp01(current, target, ref velocity, smoothTime, deltaTime):
    omega = 2.0 / smoothTime
    x = omega * deltaTime
    exp = 1.0 / (1.0 + x + 0.48*x*x + 0.235*x*x*x)
    change = current - target
    temp = (velocity + omega * change) * deltaTime
    velocity = (velocity - omega * temp) * exp
    result = target + (change + temp) * exp
    
    // 防止 overshoot
    if ((result - target) * change > 0):
        result = target
        velocity = (result - target) / deltaTime
    
    return Clamp01(result)
```

### 7.3 四元数速度自适应插值

```
功能: 根据角度差自适应调整插值速度

_SpeedAdaptiveLerp(a, b, deltaTime, minSpeedRad, maxSpeedRad,
                    minLerpFactor, maxLerpFactor):
    angle = Angle(a, b)  // 弧度
    
    // 钳位速度因子
    speed = Clamp(angle, minSpeedRad, maxSpeedRad)
    t = (speed - minSpeedRad) / (maxSpeedRad - minSpeedRad)
    
    // 计算插值因子
    lerpFactor = Lerp(minLerpFactor, maxLerpFactor, t)
    
    // 带 deltaTime 的 Slerp
    result = Slerp(a, b, lerpFactor * deltaTime)
    return result
```

### 7.4 脊椎分布算法

```
功能: 将头部旋转分布到脊椎骨骼链

输入:
- spineBones[]: 脊椎骨骼数组
- targetRotation: 目标旋转
- headWeight: 头部权重
- targetAngleDeg: 目标角度

算法:
1. angleNorm = Clamp01(targetAngleDeg / maxAngle)
2. spineInvolvement = angleNorm * 0.5
3. headWeightFinal = headWeight * (1 - spineInvolvement)

4. for i in [0..n-1], n = spineBones.Length:
   boneWeight[i] = ((i+1) / n) * spineInvolvement * headWeight
   spineBones[i].rotation = Slerp(
       spineBones[i].rotation,
       targetRotation,
       boneWeight[i])

5. headPivotBone.rotation = Slerp(
       headPivotBone.rotation,
       targetRotation,
       headWeightFinal)
```

### 7.5 Init 初始化流程

```
Init(animator, cpuAnimator, avatar, params, npcId, instanceUid):
    1. 保存所有引用 (npcId, instanceUid, params, avatar, cpuAnimator)
    2. m_animatorT = animator.transform
    
    3. 创建 3 个内部 GameObject 并设置父级:
       m_fakeTarget = new GameObject("LookAt_Target").transform
       m_fakeTargetEye = new GameObject("LookAt_EyeTarget").transform
       m_pivot = new GameObject("LookAt_PivotChest").transform
       // 全部 SetParent(m_animatorT)
    
    4. 从 aNimator 骨架获取骨骼:
       m_headPivot = avatar.headPivotBone
       m_headMovable = avatar.headBone
    
    5. 初始化平滑时间:
       m_headTargetSwitchSmoothTime = params.targetSwitchSmoothTime
       m_eyeTargetSwitchSmoothTime = params.weightSmoothTime
       m_bodyWeightSmoothTime = params.eyeWeightSmoothTime
    
    6. 调用 cpuAnimator.SetLookAtEyeBlendTime(params.eyeWeightSmoothTime)
    
    7. _InitAllWeights()
    
    8. GameWorld.LookAtManager.CacheEntity(avatar.entity)
    
    9. inited = true
```

### 7.6 PreAnimatorUpdate 完整流程

```
PreAnimatorUpdate(deltaTime):
    if (!isValid) return
    if (m_skipUpdate) return
    
    // 检查目标有效性
    检查 target 和 eyeTarget 是否有效
    
    // 传送检测
    bool selfTp = _IsSelfTeleported()
    bool targetTp = _IsTargetTeleported()
    
    // 注册/注销目标
    _ApplyTargetCacheToManager()
    
    // 更新枢轴
    _UpdatePivotTransform()
    
    // 计算目标角度
    if (target 有效 && target != pivot):
        angle = _CalculateHorizontalAngle(target, pivot)
        m_targetAngleDegree = angle
        m_targetInRange = (angle < params.maxAngle)
        
        if (!m_targetInRange && !m_followOutOfRangeTarget):
            m_headEnable = false
    else:
        m_targetInRange = false
    
    // 更新内部目标位置
    if (m_headEnable && target 有效):
        if (isAxes):
            // 从 axes 计算目标位置
            lookDir = m_targetAxes.modelSpaceVector
            if (m_useWorldSpaceAxes):
                lookDir = pivot.rotation * lookDir
            m_fakeTarget.position = pivot.position + lookDir * 10f
        else:
            // 从 target Transform 计算目标位置
            m_fakeTarget.position = CalculateTargetPositionInRange(
                target, pivot, params.maxAngle)
    
    // 平滑所有权重
    _SmoothAllWeights(deltaTime)
    
    // 计算最终注视位置
    _UpdateFinalPositionHead(selfTp || targetTp, Quaternion.identity, target)
    _UpdateFinalPositionEye(selfTp || targetTp, Quaternion.identity, eyeTarget)
    
    // 计算动画参数 (头部 + 脊椎旋转)
    _ComputeAnimParameter()
    
    // 计算并应用眼部 IK
    _ComputeEyeLookAt()
    _ApplyEyeLookAt()
    
    // 保存状态
    m_lastTargetInRange = m_targetInRange
    m_lastTargetPos = m_targetPos
    m_lastFinalPos = m_finalPosition
    m_lastFrameHeadPivotRot = m_headPivot.rotation
```
---

## 8. 完整复现指引

### 8.1 实现清单

要实现完整的 NPC LookAt IK 系统, 需要创建:

| # | 文件 | 类 | 约行数 |
|---|------|-----|--------|
| 1 | NPCCPUAnimationLookAtIkInfo.cs | NPCCPUAnimationLookAtIkInfo | 30 |
| 2 | NPCCPUAnimationLookAtControllerParams.cs | NPCCPUAnimationLookAtControllerParams | 28 |
| 3 | NPCLookAtAvatar.cs | NPCLookAtAvatar | 80 |
| 4 | NPCLookAtController.cs | NPCLookAtController | 300-500 (净室) |
| 5 | LookAtDegree.cs | LookAtDegree | 11 |
| 6 | LookAtControllerHolder.cs | LookAtControllerHolder | 9 |
| 7 | FEyeOffsetVector.cs | FEyeOffsetVector | 50 |

### 8.2 核心实现要点

1. **LookAtAxes**: Vector2 包装器, 添加 modelSpaceVector/headSpaceVector 计算属性

2. **SmoothDamp 平滑**: 6 组权重各自独立, 每帧在 _SmoothAllWeights 中统一更新

3. **权重组合**: effectiveHeadWeight = headLerpWeight * bodyWeight * weightBase

4. **角度钳位**: CalculateTargetPositionInRange 将超出 maxAngle 的目标钳位到圆锥边界

5. **传送恢复**: OnTransformTeleported + _SpeedAdaptiveLerp 平滑过渡

6. **内部伪目标**: 3 个内部 GameObject 作为动画管线中间层

7. **NPCCPUAnimator 解耦**: 控制器不直接操作骨骼, 通过接口传递数据

### 8.3 与 NPCCPUAnimator 的接口约定

| 方法 | 参数 | 频率 | 说明 |
|------|------|------|------|
| SetEyeLookAtVector | up, down, left, right | 每帧 | 传递眼部偏移值 |
| SetLookAtEyeBlendTime | time | 初始化 | 设置眼部混合时间 |
| (内部接收) headRotation | Quaternion | 每帧 | 头部目标旋转 |
| (内部接收) headWeight | float | 每帧 | 头部注视权重 |

### 8.4 与 LookAtManager 的接口约定

| 方法 | 参数 | 说明 |
|------|------|------|
| RegisterLookAtByInstanceUid | lookerUid, targetUid | 注册注视关系 |
| UnregisterByLooker | lookerUid | 注销注视关系 |
| CacheEntity | entity | 缓存 Entity 数据 |
| IsTeleported | uid | 检查是否被传送 |

### 8.5 调试与验证要点

1. **valid 检查链**: isValid -> m_avatar != null && m_avatar.valid
2. **权重可视化**: 6 个权重 (headLerp, body, eyeLerp, weightBase, rollCorrection, headRotate) 均可独立可视化
3. **角度阈值**: params.maxAngle (默认 45度) 决定目标是否被注视
4. **眼部限位**: maxEyeAngleHorizontal (默认 45度) / maxEyeAngleVertical (默认 30度)
5. **注视盲区**: 目标距离 < minDistance (默认 1m) 时忽略注视

---

## 附录 A: 字段偏移量参考 (IL2CPP 逆向)

以下字段偏移量可用于验证实现正确性:

| 字段 | 偏移量 (十六进制) | 类型 |
|------|-------------------|------|
| m_npcId | +0x10 | string |
| m_instanceUid | +0x18 | uint |
| m_cpuAnimator | +0x20 | NPCCPUAnimator |
| m_params | +0x28 | NPCCPUAnimationLookAtControllerParams |
| m_avatar | +0x30 | NPCLookAtAvatar |
| m_animatorT | +0x38 | Transform |
| m_pivot | +0x40 | Transform |
| m_headPivot | +0x48 | Transform |
| m_headMovable | +0x50 | Transform |
| m_fakeTarget | +0x58 | Transform |
| m_fakeTargetEye | +0x60 | Transform |
| m_enable | +0x68 | bool |
| m_headEnable | +0x69 | bool |
| m_eyeEnable | +0x6A | bool |
| m_targetAxes | +0x6C | LookAtAxes (8 bytes) |
| m_targetAxesEye | +0x74 | LookAtAxes (8 bytes) |
| m_headLerpWeight | +0xBC | float |
| m_bodyWeight | +0xC0 | float |
| m_bodyWeightTarget | +0xC4 | float |
| m_headTargetSwitchSmoothTime | +0xC8 | float |
| m_headLerpWeightVel | +0xCC | float |
| m_bodyWeightSmoothTime | +0xD0 | float |
| m_bodyWeightVel | +0xD4 | float |
| m_eyeLerpWeight | +0xD8 | float |
| m_eyeLerpWeightVel | +0xDC | float |
| m_eyeTargetSwitchSmoothTime | +0xE0 | float |
| m_weightBase | +0xE4 | float |
| m_weightBaseVel | +0xE8 | float |
| m_weightBaseSmoothTime | +0xEC | float |
| m_rollCorrectionWeight | +0xF0 | float |
| m_rollCorrectionWeightTarget | +0xF4 | float |
| m_headRotateAmount | +0xF8 | float |
| m_headRotateAmountTarget | +0xFC | float |
| m_rollCorrectionWeightSmoothTime | +0x100 | float |
| m_rollCorrectionWeightVel | +0x104 | float |
| m_headRotateAmountVel | +0x108 | float |
| m_target | +0x140 | Transform |
| m_finalPosition | +0x158 | Vector3 |
| m_lastFinalPos | +0x190 | Vector3 |
| m_targetAngleDegree | +0x1E0 | float |
| inited flag | +0x200 | bool |