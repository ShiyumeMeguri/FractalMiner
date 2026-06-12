# SkeletalMorph 眼部 LookAt IK 净室实现文档

## 目录

1. [系统概述](#1-系统概述)
2. [数据结构定义](#2-数据结构定义)
3. [EvaluateEyeLookAtIKJob 类定义](#3-evaluateeye-look-at-ik-job-类定义)
4. [EvaluateEyeLookAtIK 算法](#4-evaluateeye-look-at-ik-算法)
5. [SkeletalMorphCore 眼部 IK 集成](#5-skeletalmorphcore-眼部-ik-集成)
6. [数据流](#6-数据流)
7. [与 SkeletalMorph 系统共享的 NativeContainer 模式](#7-与-skeletalmorph-系统共享的-nativecontainer-模式)
8. [完整的 Burst IJob 调度伪代码](#8-完整的-burst-ijob-调度伪代码)
9. [眨眼/特殊眼动画定时器逻辑](#9-眨眼特殊眼动画定时器逻辑)
10. [附录：关键偏移命名约定](#10-附录关键偏移命名约定)

---

## 1. 系统概述

### 1.1 设计哲学

本系统是 **SkeletalMorph** 角色面部表情系统的子模块，负责处理 **眼部注视 IK**。与传统的骨骼旋转 IK 不同，本系统全部通过 **Morph BlendShape（混合形状）权重** 驱动眼部运动：

- **不使用骨骼旋转**：不旋转 eye_L / eye_R 骨骼
- **使用 BlendShape**：通过修改 SkinnedMeshRenderer 的 BlendShape 权重实现上下左右眼球转动
- **Burst IJob 并行**：全部计算在 [BurstCompile] IJob 中完成，与 SkeletalMorph 共享 JobHandle 调度链

### 1.2 架构定位

外部输入 (DialogManager/Timeline/NPC) --> SkeletalMorphCore.SetLookAtEyeIK() --> EvaluateEyeLookAtIK(blendWeight, jobHandle) --> EvaluateEyeLookAtIKJob (Burst IJob) --> morphNameHashToMorphData.TryGetValue(hash) --> allMorphs[id].weight += offsetValue * blendWeight

### 1.3 关键设计决策

| 决策 | 选择 | 理由 |
|------|------|------|
| 眼部运动方式 | BlendShape (Morph) | 比骨骼旋转更自然，与 SkeletalMorph 系统统一 |
| 计算模型 | Burst IJob (非 IJobParallelFor) | 眼部 IK 数据量小，单 Job 足够 |
| 调度模式 | ScheduleSingle<T> | 与 SkeletalMorph 其他 Job 统一调度模式 |
| 命名约定 | eye_offset_{侧}_{方向}_ctrl | 与 SkeletalMorph 控制器命名规范一致 |
| 权重来源 | 4分量 float4 (up/down/right/left) | 一次设置全部 4 个方向的偏移值 |

---

## 5. SkeletalMorphCore 眼部 IK 集成

### 5.1 属性：eyeLookAtIKEnable

```csharp
public bool eyeLookAtIKEnable
{
    get { return m_isEyeLookAtIKEnable; }
    set
    {
        m_isEyeLookAtIKEnable = value;
        if (!value) { SetLookAtEyeIK(0f, 0f, 0f, 0f); }
    }
}
```

### 5.2 API 列表

| API | 签名 | 功能 |
|-----|------|------|
| SetLookAtEyeIK | (float up, float down, float right, float left) | 设置 4 方向偏移值，同时设置左右眼 |
| SetLookAtEyeIK | (float4 vector) | float4 版本的重载 |
| ResetLookAtEyeWeight | () | 重置眼部权重到 0 |
| SetLookAtEyeForceWeight | (float weight) | 设置强制 IK 权重 |
| SetAnimEyeLookAtWeight | (float weight) | 设置动画眼部权重 |
| SetLookAtEyeBlendWeightTime | (float time) | 设置权重过渡时间 |
| EvaluateEyeLookAtIK | (float blendWeight, JobHandle) | 调度眼部 IK Job |
| GetSpeyeEnabled | () -> bool | 获取特殊眼动画启用状态 |
| SetSpeyeEnabled | (bool enabled) | 设置特殊眼动画启用状态 |
| GetEyeOffsetController | (string eyeSide, string offsetSide) -> string | 获取控制器完整名称（静态方法） |

### 5.3 方法详细实现

#### SetLookAtEyeIK(float up, float down, float right, float left)
```csharp
public void SetLookAtEyeIK(float up, float down, float right, float left)
{
    float4 offset = new float4(up, down, right, left);
    m_eyeIKOffsetR = offset;
    m_eyeIKOffsetL = offset;
}
```
从汇编确认：4个参数通过shufps指令打包为float4，存储到m_eyeIKOffsetR和m_eyeIKOffsetL。

#### SetLookAtEyeIK(float4 vector)
```csharp
public void SetLookAtEyeIK(float4 vector)
{
    m_eyeIKOffsetR = vector;
    m_eyeIKOffsetL = vector;
}
```

#### SetLookAtEyeForceWeight(float weight)
```csharp
public void SetLookAtEyeForceWeight(float weight)
{
    m_forceEyeIKWeight = weight;
    m_useForceEyeIKWeight = true;
}
```

#### ResetLookAtEyeWeight()
```csharp
public void ResetLookAtEyeWeight()
{
    m_forceEyeIKWeight = 0f;
    m_useForceEyeIKWeight = false;
}
```

#### SetAnimEyeLookAtWeight(float weight)
```csharp
public void SetAnimEyeLookAtWeight(float weight)
{
    m_animEyeLookAtWeight = weight;
}
```

#### SetLookAtEyeBlendWeightTime(float time)
```csharp
public void SetLookAtEyeBlendWeightTime(float time)
{
    m_eyeLookAtIKBlendWeightTime = time;
}
```

#### _InitializeEyeLookAtResources()
```csharp
private void _InitializeEyeLookAtResources()
{
    m_eyeIKNameHashR = new NativeArray<int>(4, Allocator.Persistent);
    m_eyeIKNameHashL = new NativeArray<int>(4, Allocator.Persistent);
    for (int i = 0; i < 4; i++)
    {
        string controllerName = S_EYE_LOOK_AT_IK_CONTROLLER_NAMES[i];
        m_eyeIKNameHashR[i] = Animator.StringToHash(GetEyeOffsetController("r", controllerName));
        m_eyeIKNameHashL[i] = Animator.StringToHash(GetEyeOffsetController("l", controllerName));
    }
}
```

#### GetEyeOffsetController（静态工具方法）
```csharp
public static string GetEyeOffsetController(string eyeSide, string offsetSide)
{
    // 格式: "eye_offset_{eyeSide.ToLower()}_{首字母大写}_ctrl"
    // 例: GetEyeOffsetController("r", "up") -> "eye_offset_r_up_ctrl"
    return "eye_offset_" + eyeSide.ToLower() + "_" +
           CultureInfo.CurrentCulture.TextInfo.ToTitleCase(offsetSide) + "_ctrl";
}
```

### 5.4 权重混合逻辑

每帧在 EvaluateEyeLookAtIK 调用前计算最终 blendWeight:

```csharp
private float CalculateEyeLookAtFinalBlendWeight(float deltaTime)
{
    if (!m_isEyeLookAtIKEnable) return 0f;
    if (m_useForceEyeIKWeight) return m_forceEyeIKWeight;

    float targetWeight = 1.0f;
    m_eyeLookAtIKblendWeight = Mathf.SmoothDamp(
        m_eyeLookAtIKblendWeight, targetWeight,
        ref m_eyeLookAtIKblendWeightV, m_eyeLookAtIKBlendWeightTime,
        float.PositiveInfinity, deltaTime);

    return m_eyeLookAtIKblendWeight * m_animEyeLookAtWeight;
}
```

---

## 6. 数据流

### 6.1 完整数据流

外部输入层 (DialogManager/Timeline/NPC)
    | SetLookAtEyeIK() / SetAnimEyeLookAtWeight()
    v
SkeletalMorphCore（主线程）
    | 计算 blendWeight (含 SmoothDamp 过渡)
    | EvaluateEyeLookAtIK(blendWeight, masterJobHandle)
    v
EvaluateEyeLookAtIKJob : IJob, BurstCompile
    | 右眼循环 + 左眼循环
    | morphNameHashToMorphData.TryGetValue(hash)
    v
Morph NativeContainer 更新 (allMorphs[].weight += ...)
    |
    v (依赖链继续)
EvaluateMorphToBoneJob -> ApplyBoneToAnimatorTransJob
    |
    v
SkinnedMeshRenderer BlendShape 权重更新

### 6.2 数据竞争防护
- [NativeDisableParallelForRestriction] 允许 Job 写入 allMorphs
- JobHandle 依赖链确保串行访问
- 所有 Morph Job 在同一帧内串行执行

### 6.3 关键时序
| 阶段 | 操作 | 位置 |
|------|------|------|
| 外部输入 | 设置偏移/权重/开关 | 任意时刻（主线程） |
| PreUpdate | 权重平滑过渡 + 开关检查 | SkeletalMorphCore.Tick |
| Job 调度 | EvaluateEyeLookAtIK(weight, handle) | SkeletalMorphCore |
| Burst Execute | 并行计算 Morph 权重 | Worker 线程 |
| PostUpdate | 应用到 SkinnedMeshRenderer | SkeletalMorphCore.PostUpdate |

---

## 7. 与 SkeletalMorph 系统共享的 NativeContainer 模式

### 7.1 核心共享容器
```csharp
private NativeParallelHashMap<int, FSkeletalMorphMappingData> m_morphNameHashToMorphData;
private NativeArray<FMorphRuntimeData> m_allMorphs;
```

### 7.2 Job 链架构
TrackerLock -> ResetAllBonesJob -> EvaluateMainTransition -> EvaluateSingleTrackJob
    -> EvaluateEyeLookAtIKJob (在此插入)
    -> EvaluateBlinkTrackJob -> EvaluateMorphToBoneJob
    -> EvaluateMorphToShaderJob -> ApplyBoneToAnimatorTransJob

### 7.3 共享模式要点
1. 一个容器多个消费者：m_allMorphs 被所有 Evaluate Job 读写
2. 累加模式：每个 Job 在现有权重上累加 (weight += delta)
3. JobHandle 依赖链确保无并发访问
4. 不使用 IJobParallelFor（串行依赖链）
5. 通过 SkeletalMorphJobUtils.ScheduleSingle<T>() 统一调度

### 7.4 ScheduleSingle 封装
```csharp
public static JobHandle ScheduleSingle<T>(
    ref T jobData, bool useCrossFrame, JobHandle dependsOn = default)
    where T : struct, IJob
{
    if (useCrossFrame) return jobData.Schedule(dependsOn);
    else return jobData.Schedule(dependsOn);
}
```

---

## 8. 完整的 Burst IJob 调度伪代码

### 8.1 调度方法
```csharp
public JobHandle EvaluateEyeLookAtIK(float blendWeight, JobHandle jobHandle = default)
{
    if (!m_isEyeLookAtIKEnable || blendWeight <= 0f) return jobHandle;

    var job = new EvaluateEyeLookAtIKJob
    {
        runtime_morphNameHashToMorphData = m_morphNameHashToMorphData,
        runtime_allMorphs = m_allMorphs,
        runtime_eyeIKNameHashR = m_eyeIKNameHashR,
        runtime_eyeIKNameHashL = m_eyeIKNameHashL,
        runtime_eyeIKOffsetR = m_eyeIKOffsetR,
        runtime_eyeIKOffsetL = m_eyeIKOffsetL,
        runtime_eyeLookAtIKblendWeight = blendWeight,
    };

    return SkeletalMorphJobUtils.ScheduleSingle(ref job, m_enableCrossFrameTick, jobHandle);
}
```

### 8.2 EvaluateEyeLookAtIKJob 完整实现
```csharp
[BurstCompile]
public struct EvaluateEyeLookAtIKJob : IJob
{
    [NativeDisableParallelForRestriction]
    public NativeParallelHashMap<int, FSkeletalMorphMappingData>
        runtime_morphNameHashToMorphData;
    [NativeDisableParallelForRestriction]
    public NativeArray<FMorphRuntimeData> runtime_allMorphs;
    [NativeDisableParallelForRestriction]
    public NativeArray<int> runtime_eyeIKNameHashR;
    [NativeDisableParallelForRestriction]
    public NativeArray<int> runtime_eyeIKNameHashL;
    [NativeDisableParallelForRestriction]
    public float4 runtime_eyeIKOffsetR;
    [NativeDisableParallelForRestriction]
    public float4 runtime_eyeIKOffsetL;
    [ReadOnly]
    public float runtime_eyeLookAtIKblendWeight;

    public void Execute()
    {
        _EvaluateEyeLookAtIK(ref runtime_morphNameHashToMorphData, ref runtime_allMorphs);
    }

    private void _EvaluateEyeLookAtIK(
        ref NativeParallelHashMap<int, FSkeletalMorphMappingData> morphNameHashToMorphData,
        ref NativeArray<FMorphRuntimeData> allMorphs)
    {
        // 右眼: 4 个方向 (0=up, 1=down, 2=right, 3=left)
        for (int i = 0; i < 4; i++)
        {
            int nameHash = runtime_eyeIKNameHashR[i];
            if (morphNameHashToMorphData.TryGetValue(nameHash,
                out FSkeletalMorphMappingData mappingData))
            {
                int morphIdx = mappingData.id;
                float offsetValue = runtime_eyeIKOffsetR[i];
                float weightDelta = offsetValue * runtime_eyeLookAtIKblendWeight;
                FMorphRuntimeData morphData = allMorphs[morphIdx];
                morphData.weight += weightDelta;
                allMorphs[morphIdx] = morphData;
            }
        }
        // 左眼: 4 个方向
        for (int i = 0; i < 4; i++)
        {
            int nameHash = runtime_eyeIKNameHashL[i];
            if (morphNameHashToMorphData.TryGetValue(nameHash,
                out FSkeletalMorphMappingData mappingData))
            {
                int morphIdx = mappingData.id;
                float offsetValue = runtime_eyeIKOffsetL[i];
                float weightDelta = offsetValue * runtime_eyeLookAtIKblendWeight;
                FMorphRuntimeData morphData = allMorphs[morphIdx];
                morphData.weight += weightDelta;
                allMorphs[morphIdx] = morphData;
            }
        }
    }
}
```

### 8.3 调用方调度示例
```csharp
public void Tick(float deltaTime)
{
    if (!m_enable) return;
    float finalBlendWeight = CalculateEyeLookAtBlendWeight(deltaTime);
    m_masterJob = EvaluateEyeLookAtIK(finalBlendWeight, m_masterJob);
    m_masterJob = DoEvaluateBlinkTrackJob(m_masterJob);
    m_masterJob = DoEvaluateMorphToBoneJob(m_masterJob);
    // ...
}
```

---

## 9. 眨眼/特殊眼动画定时器逻辑

### 9.1 相关字段
| 字段 | 类型 | 用途 |
|------|------|------|
| m_blinkAndSpeyeRandomIndex | int | 随机种子索引 |
| m_nextPlayBlinkAnimIntervalTime | float | 基础眨眼动画间隔(秒) |
| m_nextPlayBlinkAnimIntervalRandomRange | float | 眨眼间隔随机偏移范围 |
| m_nextPlayBlinkAnimCDTime | float | 眨眼 CD 时间 |
| m_blinkCDCounter | float | 眨眼 CD 计数器 |
| m_pauseEmotionAutoBlink | bool | 暂停自动眨眼 |
| m_useAdditiveBlink | bool | 叠加模式眨眼 |
| m_nextPlaySpeyeAnimIntervalTime | float | 特殊眼动画间隔 |
| m_nextPlaySpeyeAnimIntervalRandomRange | float | 特殊眼随机范围 |
| m_nextPlaySpeyeAnimRemainTime | float | 特殊眼剩余时间 |

### 9.2 随机间隔生成
```csharp
[MethodImpl(MethodImplOptions.AggressiveInlining)]
private float _GenerateNextRandomInterval(ref int randomIndex, float interval, float randomRange)
{
    randomIndex++;
    float randomValue = GetDeterministicRandom(randomIndex);
    return interval + randomValue * randomRange;
}
```

### 9.3 眨眼定时器状态机
等待间隔(IDLE) -> 触发眨眼动画 -> 冷却中(CD) -> 回到等待间隔

### 9.4 特殊眼动画启用控制
```csharp
public void SetSpeyeEnabled(bool enabled)
{
    ref FSkeletalMorphTracker track = ref _GetUnsafeTracks(12); // Track index 12
    track.speyeEnabled = enabled;
}
```

---

## 10. 附录：关键偏移命名约定

### 10.1 控制器命名格式
```
eye_offset_{侧}_{方向}_ctrl
```
- {侧}: r / l (右眼/左眼，统一小写)
- {方向}: Up / Down / Right / Left (首字母大写)

完整示例:
- eye_offset_r_up_ctrl (右眼向上)
- eye_offset_r_down_ctrl (右眼向下)
- eye_offset_r_right_ctrl (右眼向右)
- eye_offset_r_left_ctrl (右眼向左)
- eye_offset_l_up_ctrl (左眼向上)
- eye_offset_l_down_ctrl (左眼向下)
- eye_offset_l_right_ctrl (左眼向右)
- eye_offset_l_left_ctrl (左眼向左)

### 10.2 SkeletalMorphCore 对象中的字段偏移
| 字段 | 偏移(hex) | 大小 | 类型 |
|------|-----------|------|------|
| m_eyeIKNameHashR | +0x1B8 | 16 | NativeArray<int> |
| m_eyeIKNameHashL | +0x1C8 | 16 | NativeArray<int> |
| m_forceEyeIKWeight | +0x1D8 | 4 | float |
| m_useForceEyeIKWeight | +0x1DC | 1 | bool |
| m_isEyeLookAtIKEnable | +0x1DD | 1 | bool |
| m_eyeLookAtIKBlendWeightTime | +0x1E8 | 4 | float |
| m_eyeIKOffsetR | +0x1EC | 16 | float4 |
| m_eyeIKOffsetL | +0x1FC | 16 | float4 |
| m_animEyeLookAtWeight | +0x3DC | 4 | float |

---

## 11. 实现注意事项

### 11.1 Burst 兼容性
- 使用 Unity.Mathematics (float4、math 等)，不用 Vector4、Mathf
- 使用 NativeParallelHashMap 代替 Dictionary
- 使用 NativeArray 代替 float[]
- 字符串操作仅在主线程调用，不在 Burst Job 内

### 11.2 IFix 热修补
- 原始代码使用 IFix 热修补
- 净室实现无需包含 IFix 相关逻辑
- Job struct 标记 [BurstCompile]，主线程代码不标记

### 11.3 线程安全
- IJob (非 IJobParallelFor) 单线程执行，无并行竞争
- [NativeDisableParallelForRestriction] 用于文档目的
- [ReadOnly] 标记 blendWeight 是良好实践

### 11.4 内存管理
- m_eyeIKNameHashR/L 使用 Allocator.Persistent 分配
- 必须在 Dispose() 中释放
- FMorphRuntimeData 是值类型 struct

### 11.5 错误处理
- TryGetValue 返回 false 时直接跳过（Morph 可能不存在）
- 不抛异常，不记录日志（Burst Job 中禁止）
- NaN/Infinity 由上层应用逻辑处理

---

## 12. 与净室实现的差异备忘

| 原始实现 | 净室实现 | 说明 |
|---------|---------|------|
| IFix.WrappersManagerImpl::IsPatched | 无 | IFix 热修补，净室无需 |
| StringUtils.ZConcat | 普通字符串拼接 | 性能优化，不影响逻辑 |
| 底层确定性随机 | Unity.Mathematics.Random | 可替换 |
| IL2CPP + IFix 标注 | 无 | 纯 C# + Burst 即可 |

---

*文档生成日期: 2026-06-12*
*基于对 SkeletalMorphJobDefines.cs (4926行) 和 SkeletalMorphCore.cs (13777行) 的逆向工程分析*