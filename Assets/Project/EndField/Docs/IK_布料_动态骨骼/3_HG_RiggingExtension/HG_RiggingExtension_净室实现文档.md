# HG RiggingExtension 净室实现文档

> **命名空间**: Beyond.Gameplay.Animations.RiggingExtension
> **程序集**: Gameplay.Beyond.dll
> **文件数**: 22 个 .cs
> **角色**: 在 Unity Animation Rigging 框架上扩展 HG 定制 IK -- 含 4 类自定义 RigConstraint

---

## 目录

1. [系统概述](#1-系统概述)
2. [三层 IK Pipeline 架构](#2-三层-ik-pipeline-架构)
3. [HGAnimationRuntimeUtils 工具方法](#3-hganimationruntimeutils-工具方法)
4. [Vector3Transform 与 Vector3TransformArray 数据结构](#4-vector3transform-与-vector3transformarray-数据结构)
5. [第1层: HGIKPrepareEffectorsConstraint](#5-第1层-hgikprepareeffectorsconstraint)
6. [第2层: HGPrepareIKEffectorConstraint](#6-第2层-hgprepareikeffectorconstraint)
7. [第3层: HGTwoBoneIKConstraint](#7-第3层-hgtwoboneikconstraint)
8. [附录: HGTransformOffsetConstraint](#8-附录-hgtransformoffsetconstraint)
9. [完整的三层 Pipeline 数据流](#9-完整的三层-pipeline-数据流)
10. [与 Unity Animation Rigging 的集成方式](#10-与-unity-animation-rigging-的集成方式)

---

## 1. 系统概述

### 1.1 系统定位

HG RiggingExtension 是在 Unity Animation Rigging 框架(UnityEngine.Animations.Rigging)之上构建的 **4 类自定义 RigConstraint 扩展**。它不重新实现 IK 求解器,而是在 Unity 原生 TwoBoneIKConstraint 的前后插入预处理/后处理阶段,增加:

- **地面法线适配**: 将 IK 目标旋转对齐到斜坡地面法线
- **关节角度限位**: 对 effector 的 pitch(俯仰)和 roll(横滚)进行钳位保护
- **多效应器批量处理**: 一次 Job 循环处理多个 (Transform + ground normal) 对
- **变换位置偏移**: 简单的位置偏移(世界空间或局部空间)

### 1.2 文件清单

| # | 文件 | 类型 | 功能 |
|---|------|------|------|
| 1 | IHGTwoBoneIKConstraintData.cs | Interface | 扩展 ITwoBoneIKConstraintData |
| 2 | HGTwoBoneIKConstraint.cs | Component | 约束组件 |
| 3 | HGTwoBoneIKConstraintData.cs | Data | 数据结构 |
| 4 | HGTwoBoneIKConstraintJob.cs | Job | Burst Job |
| 5 | HGTwoBoneIKConstraintJobBinder.cs | Binder | Job 绑定器 |
| 6 | IHGPrepareIKEffectorConstraintData.cs | Interface | 单效应器预处理接口 |
| 7 | HGPrepareIKEffectorConstraint.cs | Component | 约束组件 |
| 8 | HGPrepareIKEffectorConstraintData.cs | Data | 数据结构 |
| 9 | HGPrepareIKEffectorConstraintJob.cs | Job | Burst Job |
| 10 | HGPrepareIKEffectorConstraintJobBinder.cs | Binder | Job 绑定器 |
| 11 | IHGIKPrepareEffectorsConstraintData.cs | Interface | 多效应器预处理接口 |
| 12 | HGIKPepareEffectorsConstraint.cs | Component | 约束组件(注意 typo: Pepare) |
| 13 | HGIKPrepareEffectorsConstraintData.cs | Data | 数据结构 |
| 14 | HGIKPrepareEffectorsConstraintJob.cs | Job | Burst Job |
| 15 | HGIKPrepareEffectorsConstraintJobBinder.cs | Binder | 复杂批量绑定器 |
| 16 | IHGTransformOffsetConstraintData.cs | Interface | 变换偏移接口 |
| 17 | HGTransformOffsetConstraint.cs | Component | 约束组件 |
| 18 | HGTransformOffsetConstraintData.cs | Data | 数据结构 |
| 19 | HGTransformOffsetConstraintJob.cs | Job | Burst Job |
| 20 | HGTransformOffsetConstraintJobBinder.cs | Binder | Job 绑定器 |
| 21 | Vector3Transform.cs | Struct | Transform + Vector3 数据对 |
| 22 | Vector3TransformArray.cs | Struct | 序列化集合 IList<Vector3Transform> |
| 23 | HGAnimationRuntimeUtils.cs | Static | 自定义 IK 工具方法 |

## 2. 三层 IK Pipeline 架构

### 2.1 架构图

`
Animation Stream
      |
      v
Stage 1: HGIKPrepareEffectorsConstraint (多效应器地面法线批量对齐)
  for each effector i:
    groundNormal[i] -> LookRotation -> 写入 effectorHandle[i].rotation
      |
      v
Stage 2: HGPrepareIKEffectorConstraint (单效应器关节限位预处理)
  1. positionOffset -> source pos + offset
  2. 提取 source 的 pitch/roll
  3. 钳位 pitch in [-maxPitch, +maxPitch]
  4. 钳位 roll in [-maxRoll, +maxRoll]
  5. weight 混合 -> 写入 target.pos/rot
      |
      v
Stage 3: HGTwoBoneIKConstraint (增强型 Two-Bone IK 求解)
  1. AnimationRuntimeUtils.SolveTwoBoneIK (标准 Two-Bone IK)
  2. groundNormal + componentRotation 后处理
  3. 写入 root/mid/tip 旋转
      |
      v
Final Bone Poses
`

### 2.2 QuadrupedIKRigging 中的权重拆分

`csharp
HGTwoBoneIKConstraint.weight = Clamp01(weight);
HGPrepareIKEffectorConstraint.rotationWeight = Clamp01((weight - 1) * 2);
`

低权重时仅 IK 求解,高权重时逐步加入地面法线对齐。

---

## 3. HGAnimationRuntimeUtils 工具方法

### 3.1 方法总览

| 方法 | 返回 | 用途 |
|------|------|------|
| SolveTwoBoneIK | void | 自定义 Two-Bone IK 求解(含 groundNormal + componentRotation 后处理) |
| ApplyTransformOffset | void | 应用变换位置偏移 |
| _TriangleAngle | float | 三角法角度计算(余弦定理) |
| _Vec4ToQuat | Quaternion | Vector4 -> Quaternion 转换 |
| _ExtractPitchRoll | Quaternion | 从四元数提取俯仰/横滚分量 |

### 3.2 ApplyTransformOffset

**签名**:
`csharp
public static void ApplyTransformOffset(
    AnimationStream stream,
    ReadWriteTransformHandle target,
    Vector3Property offset,
    bool isWorldSpace,
    float weight)
`

**伪代码**:
`
FUNCTION ApplyTransformOffset(stream, target, offset, isWorldSpace, weight):
    offsetVector = offset.Get(stream)
    IF weight <= 0: RETURN
    IF isWorldSpace:
        currentPos = target.GetPosition(stream)
        target.SetPosition(stream, currentPos + offsetVector * weight)
    ELSE:
        currentPos = target.GetLocalPosition(stream)
        target.SetLocalPosition(stream, currentPos + offsetVector * weight)
`

### 3.3 SolveTwoBoneIK

**签名**:
`csharp
public static void SolveTwoBoneIK(
    AnimationStream stream,
    ReadWriteTransformHandle root, ReadWriteTransformHandle mid, ReadWriteTransformHandle tip,
    ReadOnlyTransformHandle target, ReadOnlyTransformHandle hint,
    float posWeight, float rotWeight, float hintWeight,
    AffineTransform targetOffset,
    Vector3Property groundNormalH,
    Vector4Property componentRotation)
`

**伪代码**:
`
FUNCTION SolveTwoBoneIK(stream, root, mid, tip, target, hint,
                         posWeight, rotWeight, hintWeight,
                         targetOffset, groundNormalH, componentRotation):
    // Step 1: Read current positions
    rootPos = root.GetPosition(stream)
    midPos = mid.GetPosition(stream)
    tipPos = tip.GetPosition(stream)
    targetPos, targetRot = target.GetGlobalTR(stream)
    targetPos = targetPos + targetOffset.translation

    // Step 2: Compute bone vectors and lengths
    rootToMid = midPos - rootPos
    midToTip = tipPos - midPos
    rootToTip = tipPos - rootPos

    // Step 3: Standard Two-Bone IK via Unity native
    AnimationRuntimeUtils.SolveTwoBoneIK(stream, root, mid, tip, target, hint,
        posWeight, rotWeight, hintWeight, targetOffset)

    // Step 4: Ground normal + component rotation post-process
    gn = groundNormalH.Get(stream)
    cr = _Vec4ToQuat(componentRotation.Get(stream))
    forwardInComponent = cr * Vector3.forward
    IF |gn| < epsilon: gn = forwardInComponent

    gnNormalized = normalize(gn)
    targetLookRot = LookRotation(forwardInComponent, gnNormalized)

    invCR = Inverse(cr)
    deltaLocal = invCR * targetLookRot
    finalTipRot = cr * deltaLocal * targetOffset.rotation

    tipRot = tip.GetRotation(stream)
    finalTipRot = Lerp(tipRot, finalTipRot, rotWeight)
    tip.SetRotation(stream, finalTipRot)
`

### 3.4 _TriangleAngle

`
FUNCTION _TriangleAngle(aLen, bLen, cLen):
    cosC = (aLen*aLen + bLen*bLen - cLen*cLen) / (2 * aLen * bLen)
    cosC = Clamp(cosC, -1, 1)
    RETURN Acos(cosC)
`

### 3.5 _Vec4ToQuat

`
FUNCTION _Vec4ToQuat(vec):
    RETURN new Quaternion(vec.x, vec.y, vec.z, vec.w)
`

### 3.6 _ExtractPitchRoll

`
FUNCTION _ExtractPitchRoll(raw):
    euler = raw.eulerAngles
    RETURN Quaternion.Euler(euler.x, 0, euler.z)
    // 丢弃 yaw, 保留 pitch + roll
`

---

## 4. Vector3Transform 与 Vector3TransformArray 数据结构

### 4.1 Vector3Transform

一个简单的(Transform, Vector3)数据对,用于在序列化器中存储变换引用和关联的向量数据。

`csharp
[Serializable]
public struct Vector3Transform
{
    public Transform transform;   // 变换引用
    public float x;               // 向量 X 分量
    public float y;               // 向量 Y 分量
    public float z;               // 向量 Z 分量

    public Vector3Transform(Transform target, Vector3 vector)
    {
        transform = target;
        x = vector.x;
        y = vector.y;
        z = vector.z;
    }
}
`

### 4.2 Vector3TransformArray

`csharp
[Serializable]
public struct Vector3TransformArray
    : IList<Vector3Transform>, ICollection<Vector3Transform>,
      IEnumerable<Vector3Transform>, IEnumerable, IList, ICollection
`

#### 字段

| 字段 | 类型 | 说明 |
|------|------|------|
| K_MAX_LENGTH | static readonly int | 最大容量, 值为 8 |
| _mLength | int [SerializeField][NotKeyable] | 当前有效元素数量 |
| _mItem0 | Vector3Transform | 元素 0 |
| _mItem1 | Vector3Transform | 元素 1 |
| _mItem2 | Vector3Transform | 元素 2 |
| _mItem3 | Vector3Transform | 元素 3 |
| _mItem4 | Vector3Transform | 元素 4 |
| _mItem5 | Vector3Transform | 元素 5 |
| _mItem6 | Vector3Transform | 元素 6 |
| _mItem7 | Vector3Transform | 元素 7 |

#### 设计原理

固定容量为 8 的序列化数组。8 个元素直接声明为独立的 [SerializeField] 字段。原因:

1. **支持 [SyncSceneToStream] 按元素绑定**: Unity Animation Rigging 要求每个元素是独立的序列化字段才能在动画 Job 中逐元素绑定 PropertyStreamHandle
2. **避免泛型序列化问题**: Unity 序列化系统对泛型集合支持有限
3. **批量性能**: NativeArray 绑定允许 Job 中通过指针偏移直接访问

#### 关键方法

| 方法 | 说明 |
|------|------|
| Vector3TransformArray(int size) | 构造函数,size 被 clamp 到 [0, K_MAX_LENGTH] |
| this[int index] | get: 调用 _Get(index); set: 调用 _Set(index, value) |
| Add(Vector3Transform) | 追加元素,若已满抛 ArgumentException |
| Clear() | 设置 _mLength = 0 |
| Contains(Vector3Transform) | 线性搜索 |
| IndexOf(Vector3Transform) | 线性搜索返回索引 |
| Insert(int, Vector3Transform) | 插入并后移元素 |
| Remove(Vector3Transform) | 移除匹配的第一个元素 |
| RemoveAt(int) | 移除并前移元素 |
| CopyTo(Vector3Transform[], int) | 复制到目标数组 |
| GetEnumerator() | 返回 Enumerator 结构 |
| GetRef(ref Vector3TransformArray, int) | 返回元素引用(用于 NativeArray 绑定) |
| SetVector(ref Vector3TransformArray, int, Vector3) | 只设置向量部分,不改变 transform |

#### 内部辅助方法

| 方法 | 说明 |
|------|------|
| _Get(int index) | Switch-case 返回 _mItem0 ~ _mItem7 |
| _Set(int index, Vector3Transform value) | Switch-case 写入 _mItem0 ~ _mItem7 |
| _CheckOutOfRangeIndex(int index) | 越界检查,抛 IndexOutOfRangeException |
---

## 8. 附录: HGTransformOffsetConstraint -- 变换位置偏移

### 8.1 概述

**作用**: 对目标变换施加位置偏移,支持世界空间和局部空间。

**特性**:
- 简洁: 仅位置偏移,不修改旋转
- 灵活: 支持 World Space / Local Space 切换
- 轻量: 只有一个 ReadWriteTransformHandle + Vector3Property + bool + weight

### 8.2 接口: IHGTransformOffsetConstraintData

```
public interface IHGTransformOffsetConstraintData : IWeightedConstraintData, IAnimationJobData
{
    ReadWriteTransformHandle target { get; }
    Vector3Property positionOffset { get; }
    boolProperty isWorldSpace { get; }
}
```

### 8.3 数据结构: HGTransformOffsetConstraintData

```
[Serializable]
public struct HGTransformOffsetConstraintData : IAnimationJobData, IHGTransformOffsetConstraintData
{
    [SyncSceneToStream] [SerializeField] private Transform m_Target;
    [SyncSceneToStream] [SerializeField] private Vector3 m_PositionOffset;
    [SyncSceneToStream] [SerializeField] private bool m_IsWorldSpace;
}
```

### 8.4 Job: HGTransformOffsetConstraintJob

```
[BurstCompile]
public struct HGTransformOffsetConstraintJob : IWeightedAnimationJob
{
    public ReadWriteTransformHandle target;
    public Vector3Property positionOffset;
    public BoolProperty isWorldSpace;
    public float jobWeight;
}
```

#### Job 执行逻辑

```
FUNCTION ProcessRootMotion(stream):
    offset = positionOffset.Get(stream)
    isWS = isWorldSpace.Get(stream)
    weight = jobWeight
    
    HGAnimationRuntimeUtils.ApplyTransformOffset(
        stream, target, offset, isWS, weight
    )
```

### 8.5 Binder: HGTransformOffsetConstraintJobBinder

```
public class HGTransformOffsetConstraintJobBinder : AnimationJobBinder<HGTransformOffsetConstraintJob, HGTransformOffsetConstraintData>
{
    public override HGTransformOffsetConstraintJob Create(Animator animator,
        ref HGTransformOffsetConstraintData data, Component component)
    {
        var job = new HGTransformOffsetConstraintJob();
        job.target = ReadWriteTransformHandle.Bind(animator, data.m_Target);
        job.positionOffset = Vector3Property.Bind(animator, component, "m_PositionOffset");
        job.isWorldSpace = BoolProperty.Bind(animator, component, "m_IsWorldSpace");
        return job;
    }
    
    public override void Destroy(HGTransformOffsetConstraintJob job) { }
}
```

---

## 9. 完整的三层 Pipeline 数据流

### 9.1 数据流总图

```
[QuadrupedIKRigging]
  |-- Limb 0 (左前)
  |     |-- Stage 1: HGIKPrepareEffectorsConstraint (4个肢体共享,绑定所有4个effector的ground normal)
  |     |-- Stage 2: HGPrepareIKEffectorConstraint (单独,本limb的effector限位)
  |     |-- Stage 3: HGTwoBoneIKConstraint (单独,本limb的IK求解)
  |-- Limb 1 (右前)
  |     |-- Stage 1: HGIKPrepareEffectorsConstraint (同上,共享)
  |     |-- Stage 2: HGPrepareIKEffectorConstraint (单独)
  |     |-- Stage 3: HGTwoBoneIKConstraint (单独)
  |-- Limb 2 (左后)
  |     |-- ...
  |-- Limb 3 (右后)
        |-- ...
```

### 9.2 逐帧数据流向

```
Frame N:
  Stream.syncSceneToStream (自动同步)
    -> 所有 [SyncSceneToStream] SerializedProperty 写入 AnimationStream
    
  Stage 1 Jobs (HGIKPrepareEffectorsConstraintJob):
    Input:  groundNormal[i] (Vector3 from AnimationStream), 
            effectorHandle[i] (TransformHandle)
    Output: effectorHandle[i].rotation = LookRotation(groundNormal[i], up)
    
  Stage 2 Jobs (HGPrepareIKEffectorConstraintJob):
    Input:  source.position, source.rotation,
            positionOffset, maxPitchDegree, maxRollDegree, rotationWeight
    Output: target.position = source.position + positionOffset
            target.rotation = ClampPitchRoll(source.rotation)
    
  Stage 3 Jobs (HGTwoBoneIKConstraintJob):
    Input:  root/mid/tip.position, target.position/rotation,
            targetOffset, groundNormal, componentRotation
    Output: root.rotation, mid.rotation, tip.rotation (IK solved)
            tip.rotation 额外经 groundNormal + componentRotation 后处理
    
  Stream.streamToScene (自动写回)
    -> 最终骨骼变换写回场景 Transform
```

### 9.3 属性绑定关系

| 约束 | 序列化属性 | 绑定路径 | 属性类型 |
|------|-----------|---------|---------|
| HGIKPrepareEffectorsConstraint | M_EffectorHandle0 | ...m_EffectorNormalList._mItem0.transform | ReadWriteTransformHandle |
| | M_GroundNormal0 | ...m_EffectorNormalList._mItem0.x/y/z | float3 |
| | ...(最多8组) | | |
| HGPrepareIKEffectorConstraint | M_Source | m_Source | ReadWriteTransformHandle |
| | M_Target | m_Target | ReadWriteTransformHandle |
| | M_PositionOffset | m_PositionOffset | Vector3Property |
| | M_RotationWeight | m_RotationWeight | FloatProperty |
| | M_MaxPitchDegree | m_MaxPitchDegree | FloatProperty |
| | M_MaxRollDegree | m_MaxRollDegree | FloatProperty |
| HGTwoBoneIKConstraint | M_Root | m_Root | ReadWriteTransformHandle |
| | M_Mid | m_Mid | ReadWriteTransformHandle |
| | M_Tip | m_Tip | ReadWriteTransformHandle |
| | M_Target | m_Target | ReadOnlyTransformHandle |
| | M_Hint | m_Hint | ReadOnlyTransformHandle |
| | M_TargetPositionWeight | m_TargetPositionWeight | FloatProperty |
| | M_TargetRotationWeight | m_TargetRotationWeight | FloatProperty |
| | M_HintWeight | m_HintWeight | FloatProperty |
| | M_TargetOffset | m_TargetOffset | AffineTransform |
| | M_GroundNormal | m_GroundNormal | Vector3Property |
| | M_ComponentRotation | m_ComponentRotation | Vector4Property |
| HGTransformOffsetConstraint | M_Target | m_Target | ReadWriteTransformHandle |
| | M_PositionOffset | m_PositionOffset | Vector3Property |
| | M_IsWorldSpace | m_IsWorldSpace | BoolProperty |

---

## 10. 与 Unity Animation Rigging 的集成方式

### 10.1 继承关系

```
MonoBehaviour
  |-- RigConstraint<TJob, TData, TBinder>
        |-- HGTwoBoneIKConstraint
        |-- HGPrepareIKEffectorConstraint
        |-- HGIKPepareEffectorsConstraint  (注意类名 typo)
        |-- HGTransformOffsetConstraint
```

其中:
- TJob = 对应的 IWeightedAnimationJob 实现
- TData = 对应的 IAnimationJobData 实现(含 [SyncSceneToStream] 字段)
- TBinder = AnimationJobBinder<TJob, TData> 的派生

### 10.2 RigConstraint 生命周期

```
OnEnable()
  --> data = new TData() (从序列化数据加载)
  --> binder.Create(animator, ref data, this)
  --> AnimationJobUtility.BindSceneProperty(stream, ...) [绑定所有 [SyncSceneToStream] 属性]
  --> AnimationPlayableOutput.Create(animator, ...)
  
Update() / LateUpdate()
  --> stream.syncSceneToStream [GameObject 序列化字段 -> AnimationStream]
  --> ProcessGraph [执行所有绑定的 Job]
  --> stream.streamToScene [AnimationStream -> GameObject Transform]
  
OnDisable()
  --> binder.Destroy(job)
  --> NativeArray.Dispose()
```

### 10.3 关键约束

1. **执行顺序**: 通过 Rig Builder 中约束列表的顺序控制。Stage 1 必须排在 Stage 2 之前,Stage 2 必须排在 Stage 3 之前。
2. **权重控制**: QuadrupedIKRigging 在运行时动态调整权重实现渐进过渡。
3. **NativeArray 生命周期**: Job Binder 中分配的 NativeArray 必须在 Destroy 中释放。

### 10.4 限制

1. Vector3TransformArray 固定最大容量 8,超过会抛异常
2. HGIKPrepareEffectorsConstraint 类名存在 typo("Pepare" 而非 "Prepare"),重构时需注意兼容性
3. componentRotation 使用 Vector4 存储(Quaternion),需要 _Vec4ToQuat 转换
4. 地面法线为零向量时跳过,依赖外部系统提供有效的 ground normal 数据

---

## 附录 A: 生成时间线与备注

- 生成日期: 2026-06-12
- 生成工具: Claude Code (Clean Room Analysis)
- 分析方法: 字段定义 + 接口抽象 + 通用 Animation Rigging 模式推导
- 方法体: IL2CPP 混淆, 逻辑基于约束命名、字段用途和 IK 数学标准推导
- 验证状态: 未实际编译运行, 需对照源码验证

---

## 附录 B: 术语对照

| 中文 | English |
|------|---------|
| 约束 | Constraint |
| 效应器 | Effector |
| 关节 | Joint |
| 俯仰 | Pitch (绕 X 轴) |
| 横滚 | Roll (绕 Z 轴) |
| 偏航 | Yaw (绕 Y 轴) |
| 地面法线 | Ground Normal |
| 组件旋转 | Component Rotation |
| IK 目标 | IK Target |
| 提示器 | Hint |
| 权重复制 | Weight Blending |
| 净室实现 | Clean Room Implementation |
