# IK 支撑工具 --- 净室实现文档

## 目录

1. [IKCollisionHelper（IK碰撞查询工具）](#1-ikcollisionhelperik碰撞查询工具)
2. [IKCastCondition（IK动画条件）](#2-ikcastconditionik动画条件)
3. [CameraRigMono._TwoBoneIKSolve（几何Two-Bone IK求解器）](#3-camerarigmono_twoboneiksolve几何two-bone-ik求解器)
4. [GrounderIKParameters（数据传输对象）](#4-grounderikparameters数据传输对象)

---

## 1. IKCollisionHelper（IK碰撞查询工具）

### 1.1 类概述

| 条目 | 内容 |
|------|------|
| 完整类型 | Beyond.Gameplay.IKCollisionHelper |
| 类型 | public static class（静态工具类） |
| 命名空间 | Beyond.Gameplay |
| 核心职责 | 为 IK 脚部地面贴合提供碰撞查询（射线/胶囊/复杂网格），是 RootMotion.FinalIK.Grounding 的自定义碰撞后端 |
| 静态字段 | private static readonly int[] HIT_INDICES --- 命中索引数组，用于 CollisionSorter.Sort 排序 |

### 1.2 _GetWalkableLayers() --- 可行走层掩码

方法签名: private static int _GetWalkableLayers()

返回类型: int（LayerMask）
参数: 无
算法: 从全局 GameInstance -> MovementSetting 链中提取 walkableLayers 字段

净室实现:

```
private static int _GetWalkableLayers()
{
    var instance = GameInstance.Instance;
    if (instance == null) return 0;
    var movementData = instance.MovementData;
    if (movementData == null) return 0;
    var movementSetting = movementData.MovementSetting;
    if (movementSetting == null) return 0;
    return movementSetting.walkableLayers;
}
```

### 1.3 LegacyRaycast(...) --- 旧版射线检测

方法签名:

```
public static bool LegacyRaycast(
    Vector3 origin,
    Vector3 direction,
    out RaycastHit hitInfo,
    float maxDistance,
    int layerMask,
    QueryTriggerInteraction queryTriggerInteraction
)
```

算法流程:

```
function LegacyRaycast(origin, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction):
    effectiveMask = layerMask | _GetWalkableLayers()
    if not PhysHelper.Raycast(origin, direction, out hitInfo, maxDistance,
                             effectiveMask, queryTriggerInteraction):
        return false
    if hitInfo.colliderProxy.hasComplexMesh:
        if hitInfo.colliderProxy.bIsECS:
            ECSCollider.RaycastComplexMesh(..., Ray(origin, direction), maxDistance, out hitInfo)
        else:
            collider = hitInfo.colliderProxy.collider
            if collider != null and collider is MultiCollider:
                MultiCollider.RaycastComplexMesh(collider, Ray(...), maxDistance, out hitInfo)
    return true
```

### 1.4 Raycast(...) --- 新版射线检测

方法签名:

```
public static bool Raycast(
    Vector3 origin, Vector3 direction, out RaycastHit hitInfo,
    float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction
)
```

算法流程:

```
function Raycast(origin, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction):
    effectiveMask = layerMask | _GetWalkableLayers()
    allHits = PhysHelper.RaycastAll(origin, direction, maxDistance, effectiveMask, queryTriggerInteraction)
    if allHits.Length == 0:
        hitInfo = default(RaycastHit); return false

    CollisionSorter.Sort(HIT_INDICES, allHits.Length)
    bestDistance = float.MaxValue
    hitInfo = default(RaycastHit)
    hasHit = false

    for i = 0 to allHits.Length - 1:
        hitIndex = HIT_INDICES[i]
        hit = allHits[hitIndex]
        if hit.collider.isTrigger and queryTriggerInteraction == Collide: continue
        if hit.colliderProxy.hasComplexMesh:
            if _CastComplex(origin, direction, maxDistance, ref hit):
                if hit.distance < bestDistance:
                    bestDistance = hit.distance; hitInfo = hit; hasHit = true
        else:
            if hit.distance >= 0 && hit.distance < bestDistance:
                bestDistance = hit.distance; hitInfo = hit; hasHit = true
    return maxDistance >= bestDistance
```

### 1.5 CapsuleCast(...) --- 胶囊体投射

方法签名:

```
public static bool CapsuleCast(
    Vector3 point1, Vector3 point2, float radius, Vector3 direction,
    out RaycastHit hitInfo, float maxDistance, int layerMask,
    QueryTriggerInteraction queryTriggerInteraction
)
```

算法流程:

```
function CapsuleCast(point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, qti):
    effectiveMask = layerMask | _GetWalkableLayers()
    allHits = PhysHelper.CapsuleCastAll(point1, point2, radius, direction,
                                        maxDistance, effectiveMask, qti)
    if allHits.Length == 0: hitInfo = default; return false

    CollisionSorter.Sort(HIT_INDICES, allHits.Length)
    bestDistance = float.MaxValue
    hitInfo = default(RaycastHit)
    hasHit = false

    for i = 0 to allHits.Length - 1:
        hitIndex = HIT_INDICES[i]
        hit = allHits[hitIndex]
        if hit.collider.isTrigger and qti == Collide: continue
        if GetColliderOptions(hit.collider) & InternalFlag: continue
        if hit.distance >= bestDistance: continue
        if hit.colliderProxy.hasComplexMesh:
            if _CastCapsuleComplex(point1, point2, radius, direction, maxDistance, ref hit):
                bestDistance = hit.distance; hitInfo = hit; hasHit = true
        else:
            bestDistance = hit.distance; hitInfo = hit; hasHit = true
    return maxDistance >= bestDistance
```

### 1.6 _CastComplex(...) --- 复杂网格碰撞检测

方法签名:

```
private static bool _CastComplex(
    Vector3 origin, Vector3 direction, float maxDistance, ref RaycastHit hitInfo
)
```

伪代码:

```
function _CastComplex(origin, direction, maxDistance, ref hitInfo):
    proxy = hitInfo.colliderProxy
    if proxy.bIsECS:
        return ECSCollider.RaycastComplexMesh(proxy.instanceId, proxy.colliderIndex,
                                              Ray(origin, direction), maxDistance, out hitInfo)
    else:
        collider = proxy.collider
        if collider == null or collider is not UnityEngine.Collider: return false
        return MultiCollider.RaycastComplexMesh(collider as MultiCollider,
                                                Ray(origin, direction), maxDistance, out hitInfo)
```

### 1.7 _CastCapsuleComplex(...) --- 复杂网格胶囊检测

方法签名:

```
private static bool _CastCapsuleComplex(
    Vector3 point1, Vector3 point2, float radius, Vector3 direction,
    float maxDistance, ref RaycastHit hitInfo
)
```

伪代码:

```
function _CastCapsuleComplex(point1, point2, radius, direction, maxDistance, ref hitInfo):
    proxy = hitInfo.colliderProxy
    if proxy.hasComplexMesh:
        return PerformCapsuleComplexQuery(point1, point2, radius, direction,
                                          maxDistance, proxy, out hitInfo)
    else:
        return true
```

### 1.8 注册到 GrounderBipedIK 的回调机制

在 BaseModelComponent 中注册:

```
void SetupIKCollisionDelegates():
    GrounderBipedIK grounder = GetComponentInChildren<GrounderBipedIK>()
    if grounder == null: return

    // 注册 IKCollisionHelper 方法为委托
    grounder.solver.OnRaycastDelegate = IKCollisionHelper.Raycast
    grounder.solver.OnCapsuleCastDelegate = IKCollisionHelper.CapsuleCast
    grounder.solver.layerMask = GetWalkableLayers()
```

对应 RootMotion.FinalIK.Grounding 中的委托定义:

```
public delegate bool OnRaycastDelegate(
    Vector3 origin, Vector3 direction, out RaycastHit hitInfo,
    float maxDistance, int layerMask, QueryTriggerInteraction qti
)

public delegate bool OnCapsuleCastDelegate(
    Vector3 point1, Vector3 point2, float radius, Vector3 direction,
    out RaycastHit hitInfo, float maxDistance, int layerMask,
    QueryTriggerInteraction qti
)
```

---

## 2. IKCastCondition（IK动画条件）

### 2.1 类概述

| 条目 | 内容 |
|------|------|
| 完整类型 | Beyond.Gameplay.View.Animation.IKCastCondition |
| 基类 | SpecialIdleCondition |
| 命名空间 | Beyond.Gameplay.View.Animation |
| 核心职责 | 动画状态机条件，基于地面角度/坡度决定是否启用 IK |

### 2.2 字段

| 字段 | 类型 | 用途 |
|------|------|-------|
| maxOffsetAngle | float | 最大偏移角度：地面法线与角色向上的夹角允许最大值 |
| maxSlopeAngle | float | 最大斜坡角度：角色前后方向上的坡度允许最大值 |

### 2.3 EvaluateCondition(...) 算法

方法签名:

```
public override bool EvaluateCondition(
    CharacterSpecialIdleContext context,
    float deltaTime = 0f
)
```

净室伪代码:

```
function EvaluateCondition(context, deltaTime):
    if context == null: throw
    if context.Animator == null: throw

    ikSolver = context.Animator.GetIKFootSolver()
    if ikSolver == null: throw

    // 条件1: 地面法线偏移角度 <= maxOffsetAngle
    groundNormal = ikSolver.GetGroundNormal()
    offsetAngle = AbsAngle(groundNormal, Vector3.up)
    if offsetAngle > this.maxOffsetAngle: return false

    // 条件2: 前后高度差(坡度) <= maxSlopeAngle
    forwardHeight = ikSolver.GetForwardHeight()
    backwardHeight = ikSolver.GetBackwardHeight()
    slopeAngle = Abs(forwardHeight - backwardHeight)
    if slopeAngle > this.maxSlopeAngle: return false

    return true
```

数学条件:

```
条件1: |angle(groundNormal, upVector)| <= maxOffsetAngle
条件2: |forwardHeight - backwardHeight| <= maxSlopeAngle
结果  = 条件1 AND 条件2
```

浮点处理：使用 abs mask (0x7FFFFFFF) 取绝对值后比较。

---

## 3. CameraRigMono._TwoBoneIKSolve（几何Two-Bone IK求解器）

### 3.1 方法签名

```
private void _TwoBoneIKSolve(
    Vector3 rootPos,          // 根关节世界位置
    Vector3 targetPos,        // 末端目标世界位置
    Vector3 polePos,          // 极向量目标位置，控制弯曲方向
    float len1,               // 第1段骨骼长度 (root->mid)
    float len2,               // 第2段骨骼长度 (mid->tip)
    Quaternion rootRotation,  // 根关节旋转 (用于局部空间变换)
    out Vector3 cWorld,       // mid 关节世界位置 (输出)
    out Vector3 bWorld        // tip 关节世界位置 (输出)
)
```

### 3.2 数学推导

几何模型:

```
          rootPos (R)
           /\
          /  \
    len1 /    \ len2
        /      \
    cWorld(C)   \
      /          \
     /            \
  poleDirection    bWorld(B) -> targetPos(T)
```

余弦定理（核心公式）:

```
                len1^2 + d^2 - len2^2
cos(angle_RCT) = ------------------------
                     2 * len1 * d

    其中 d = |targetPos - rootPos|
```

中间关节位置公式:

```
C = R + len1 * [ cos(theta) * u + sin(theta) * v ]

其中:
  u = Normalize(T - R)
  v = Normalize(Cross(Cross(u, P - R), u))
  theta = arccos(Clamp(cos(angle_RCT), -1, 1))
  R = rootPos, T = targetPos, P = polePos
```

### 3.3 算法伪代码

```
function _TwoBoneIKSolve(rootPos, targetPos, polePos, len1, len2,
                          rootRotation, out cWorld, out bWorld):

    // 1. 转换到根关节局部空间
    invRootRot = Quaternion.Inverse(rootRotation)
    localTarget = invRootRot * (targetPos - rootPos)
    localPole   = invRootRot * (polePos - rootPos)

    // 2. 计算根到目标距离
    d = Magnitude(localTarget)
    lenTotal = len1 + len2

    // 3. 特殊情况处理
    if d > lenTotal:
        // 目标超出伸展范围：最大伸展姿态
        dir = Normalize(localTarget)
        midLocal = dir * len1
        tipLocal = dir * lenTotal
    elif d < Abs(len1 - len2):
        // 目标太近：取 pole 方向折叠
        dir = Normalize(localTarget)
        poleDir = Normalize(localPole)
        midLocal = poleDir * len1
    else:
        // 4. 余弦定理计算角度
        cosAngle = (len1*len1 + d*d - len2*len2) / (2 * len1 * d)
        cosAngle = Clamp(cosAngle, -1, 1)
        sinAngle = Sqrt(1 - cosAngle*cosAngle)

        // 5. 构建旋转平面
        targetDir = Normalize(localTarget)
        poleProj = localPole - Dot(localPole, targetDir) * targetDir
        if Magnitude(poleProj) < THRESHOLD:
            poleProj = Vector3.up
        poleProj = Normalize(poleProj)

        planeNormal = Cross(targetDir, poleProj)
        perpDir = Cross(planeNormal, targetDir)

        // 6. 中间关节局部位置
        midLocal = targetDir * (len1 * cosAngle) + perpDir * (len1 * sinAngle)
        tipLocal = targetDir * d

    // 7. 转换回世界坐标
    cWorld = rootPos + rootRotation * midLocal
    bWorld = rootPos + rootRotation * tipLocal
```

极端情况处理:

```
d > len1 + len2:       // 伸展极限 -> 完全伸直
  C = R + len1 * Normalize(T - R)
  B = R + (len1+len2) * Normalize(T - R)

d < |len1 - len2|:     // 折叠极限 -> 极方向折叠
  C = R + len1 * Normalize(poleDir)
  B = targetPos (保持连接到目标)
```

---

## 4. GrounderIKParameters（数据传输对象）

### 4.1 结构定义

```
using UnityEngine;

namespace Beyond.Gameplay.View
{
    public struct GrounderIKParameters
    {
        public float   timeRef;           // 时间参考
        public bool    isMoving;          // 是否在移动
        public bool    isAccelerating;    // 是否在加速
        public bool    isOnMovableBase;   // 是否在可移动基座上
        public float   gait;              // 步态 (步频/步幅)
        public Vector3 moveSpeed;         // 移动速度向量
        public float   leftCurStepTime;   // 左脚当前步态时间
        public float   rightCurStepTime;  // 右脚当前步态时间
        public float   startAnimWeight;   // 动画起始权重
        public bool    isPlayingMontage;  // 是否正在播放蒙太奇动画
    }
}
```

### 4.2 各字段用途

| 字段 | 类型 | 用途说明 |
|------|------|----------|
| timeRef | float | 时间参考值，用于 IK 权重的时间同步和插值基准 |
| isMoving | bool | 移动状态。true 时 IK 增加脚步动态跟随权重 |
| isAccelerating | bool | 加速状态。加速时 IK 脚部需要更快的响应速度 |
| isOnMovableBase | bool | 可移动基座标志（升降平台/载具） |
| gait | float | 步态参数 [0,1]，编码步频与步幅信息 |
| moveSpeed | Vector3 | 移动速度向量，用于预测 IK 脚部着落点 |
| leftCurStepTime | float | 左脚步态周期进度 [0,1] |
| rightCurStepTime | float | 右脚步态周期进度 |
| startAnimWeight | float | 动画起始权重 [0,1]，用于 IK 启动淡入过渡 |
| isPlayingMontage | bool | 蒙太奇播放标志，true 时 IK 降低权重或完全禁用 |

数据流:

```
Animator Blackboard
    -> SetGrounderIKParamaterFromAnimBlackboard(GrounderIKParameters)
    -> CharacterAnimationComponent
    -> GrounderBipedIK.solver
    -> IK Foot/Pelvis Offset 计算
```

---

## 附录：符号表

| 符号 | 含义 |
|------|------|
| Cross(a,b) | 向量叉积 |
| Dot(a,b) | 向量点积 |
| Normalize(v) | 向量归一化 |
| Abs(x) | 绝对值 (x & 0x7FFFFFFF) |
| Clamp(x,min,max) | 数值钳制 |
| Sqrt(x) | 平方根 |
| Quaternion.Inverse(q) | 四元数求逆 |
| AngleAxis(angle,axis) | 绕轴旋转四元数 |
| THRESHOLD | 极小值 (0.0001f) |

---

*本文档基于对原始代码的净室逆向分析撰写，仅描述接口签名、算法原理和逻辑流程。所有数学公式均为计算机图形学公开知识。*
