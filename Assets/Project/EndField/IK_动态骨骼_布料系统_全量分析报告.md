# IK / 动态骨骼 / 布料系统 全量分析报告

## 目录

- [1. 总览](#1-总览)
- [2. IK 系统](#2-ik-系统)
  - [2.1 RootMotion FinalIK](#21-root motion-finalik)
  - [2.2 Unity Animation Rigging](#22-unity-animation-rigging)
  - [2.3 HG Custom IK Extension](#23-hg-custom-ik-extension)
  - [2.4 IK 求解器算法一览](#24-ik-求解器算法一览)
- [3. 布料/动态骨骼系统](#3-布料动态骨骼系统)
  - [3.1 BeyondDynamicBone (主布料系统)](#31-beyonddynamicbone-主布料系统)
  - [3.2 MagicaCloth v1 (旧版)](#32-magicacloth-v1-旧版)
  - [3.3 GPU Cloth (管线集成)](#33-gpu-cloth-管线集成)
  - [3.4 NPC 布料集成层](#34-npc-布料集成层)
- [4. 核心算法](#4-核心算法)
- [5. 数据流](#5-数据流)
- [6. 关键决策](#6-关键决策)
- [7. 全景统计与模块关系图](#7-全景统计与模块关系图)

---

## 1. 总览

### 1.1 原始目录结构

```
Scripts/
├── RootMotion/
│   └── FinalIK/                    # RootMotion FinalIK (49 文件)
│       ├── IK.cs                   # 抽象基类
│       ├── IKSolver.cs             # 求解器抽象基类
│       ├── IKSolverHeuristic.cs    # 启发式求解器基类
│       ├── IKSolverFABRIK.cs       # FABRIK 前向后向迭代
│       ├── IKSolverVR.cs           # VR 全身 IK
│       ├── IKSolverFullBody.cs     # 全身 FB IK
│       ├── IKSolverLimb.cs         # 肢体 IK
│       ├── Grounder*.cs            # 地面适配器
│       └── EditorIK.cs             # 编辑器 IK
│
├── Unity.Animation.Rigging/        # Unity 动画约束系统 (10 文件)
│   └── TwoBoneIKConstraint.cs       # 2Bone IK 组件+Job+Binder
│   └── ChainIKConstraint.cs         # 链式 IK 组件+Job+Binder
│
├── Gameplay.Beyond/
│   └── Animations/RiggingExtension/ # HG 自定义 IK 扩展 (17 文件)
│       ├── HGTwoBoneIKConstraint    # 地面法线+分量旋转
│       ├── HGPrepareIKEffector      # 单效应器预处理
│       └── HGIKPrepareEffectors     # 多效应器批量处理
│
├── BeyondDynamicBone/              # 主布料/动态骨骼系统 (~180 文件)
│   ├── BeyondBoneCloth.cs           # 主组件 (2622行)
│   ├── ClothProcess.cs              # 核心模拟 (11241行)
│   ├── ClothManager.cs              # 全局管理器 (3239行)
│   ├── DynamicBoneTransformManager.cs # 变换管理 (12456行)
│   ├── 约束系统 (12 类)            # Angle/Distance/Inertia/Motion...
│   └── 碰撞器系统 (3 类)           # Capsule/Sphere/Plane
│
├── MagicaCloth/                    # 旧版 MagicaCloth v1 (30+ 文件)
│   ├── MagicaBoneCloth.cs
│   ├── MagicaMeshCloth.cs
│   └── PhysicsManagerCompute.cs
│
├── HG.RenderPipelines.Runtime/     # GPU 布料模拟管线 (~18 文件)
│   ├── GpuClothManager.cs           # CPU 管理 (2200行)
│   ├── GpuClothSimulationPassConstructor.cs # RenderGraph Pass (1479行)
│   └── ClothInfo.cs                 # 布料实例配置 (594行)
│
└── Gameplay.Beyond/NPC/Animation/  # NPC 布料集成 (3 文件)
    ├── ClothCalculator.cs           # 布料权重管理 (1887行)
    ├── AnimatorClothCalculator.cs   # Animator 路径 (532行)
    └── AnimationStreamClothCalculator.cs # Job系统路径 (559行)
```

### 1.2 全量模块总览

| 模块 | 文件数 | 一句话描述 | 报告章节 |
|------|--------|-----------|---------|
| RootMotion FinalIK | 49 | 完整 IK 求解器套件 (FABRIK/CCD/FBIK/VR) | 2.1 |
| Unity Animation Rigging | 10 | Unity 官方动画约束系统 (Job+Burst) | 2.2 |
| HG IK Extension | 17 | HG 定制 IK 扩展 (地面法线/关节限位/多效应器批处理) | 2.3 |
| BeyondDynamicBone | ~180 | 主布料/动态骨骼系统 (Burst Job + PBD) | 3.1 |
| MagicaCloth v1 | ~30 | 旧版 ComputeShader 布料 | 3.2 |
| GPU Cloth (管线) | ~18 | 渲染管线集成的 GPU Compute 布料 | 3.3 |
| NPC 布料集成 | 3 | NPC 布料权重管理与动画层桥接 | 3.4 |

---

## 2. IK 系统

### 2.1 RootMotion FinalIK

**路径**: `Assets/Scripts/RootMotion/RootMotion/FinalIK/`
**文件数**: 49 个 `.cs`
**命名空间**: `RootMotion.FinalIK`
**角色**: 全功能 IK 求解器套件 — 提供 FABRIK/CCD/三角法/全身/VR 等 5 类 IK 算法

#### 2.1.1 类继承体系

```
IK (abstract) : SolverManager          — 所有 IK 组件的抽象基类, Template Method 模式
  ├── AimIK                            — 瞄准 IK
  ├── ArmIK                            — 手臂 IK
  ├── BipedIK                          — 双足 IK (融合 LookAt + Limb IK)
  ├── CCDIK                            — CCD (Cyclic Coordinate Descent)
  ├── FABRIK                           — FABRIK 组件
  ├── FABRIKRoot                       — FABRIK 根组件
  ├── FullBodyBipedIK                  — 全身双足 FBIK
  ├── LegIK                            — 腿部 IK
  ├── LimbIK                           — 肢体 IK
  ├── LookAtIK                         — 注视 IK
  ├── TrigonometricIK                  — 三角法 IK
  └── VRIK                             — VR 全身 IK

IKSolver (abstract)                    — 求解器基类 (1605行)
  ├── IKSolverHeuristic (abstract)     — 启发式求解器 (CCD/FABRIK/Aim)
  │   ├── IKSolverCCD                  — CCD 迭代求解
  │   ├── IKSolverFABRIK              — FABRIK 求解
  │   └── IKSolverAim                 — 瞄准求解
  ├── IKSolverTrigonometric (abstract) — 三角法求解基类
  │   └── IKSolverLimb                — 肢体(手臂/腿)三角法
  ├── IKSolverFullBody                 — 全身 FBIK 求解
  │   └── IKSolverFullBodyBiped       — 双足 FBIK 定制
  ├── IKSolverLookAt                   — 注视求解
  └── IKSolverVR                       — VR 全身求解
```

#### 2.1.2 求解器对比

| 求解器 | 算法类型 | 迭代 vs 解析 | 适用场景 | 关键特性 |
|--------|---------|-------------|---------|---------|
| `IKSolverFABRIK` | 前向后向迭代 | 迭代 (10~30次) | 长链/触手/绳索 | 位置约束, 根运动, 无奇异性 |
| `IKSolverCCD` | 循环坐标下降 | 迭代 (10~30次) | 一般骨骼链 | 逐关节旋转逼近, 弯曲约束 |
| `IKSolverTrigonometric` | 三角法 | 解析 (单帧) | 手臂/腿 (2骨链) | 快速, 无迭代开销 |
| `IKSolverAim` | 启发式 | 迭代 | 头部/炮塔瞄准 | 前方方向旋转 + 俯仰/偏航限制 |
| `IKSolverLookAt` | 启发式 | 迭代 | 人物注视 | 注视方向限制 + 脊椎分布旋转 |
| `IKSolverFullBody` | 多链多效应器 | 迭代 + 约束 | 全身 IK | 效应器链权重 + 弯曲约束 |
| `IKSolverVR` | 混合 (FABRIK+三角) | 迭代 + 解析 | VR 全身 | 身体部分分离求解 + 步态适配 |

#### 2.1.3 核心内部类

| 内部类型 | 关键字段 | 用途 |
|---------|---------|------|
| `IKSolver.Point` | `transform`, `weight`, `solverPosition`, `solverRotation` | 求解器节点: 位置/旋转/权重 |
| `IKSolver.Bone` : Point | `length`, `localDirection` | 带长度信息的骨骼节点 |
| `IKSolver.Node` : Bone | `length`, `effectorPosition`, `offset` | 含效应器偏移的完整节点 |
| `IKEffector` | `bone`, `positionWeight`, `rotationWeight`, `effectNodes[]` | IK 目标效应器, 支持多节点权重 |
| `IKMapping` | `bones[]` | 骨骼映射: 将 IK 节点对应到实际 Transform |
| `IKConstraintBend` | `bendGoal`, `bendGoalWeight`, `direction` | 弯曲方向约束 (控制肘/膝方向) |

#### 2.1.4 Grounder 地面适配系统

| 类 | 目标 IK 系统 | 核心逻辑 |
|----|-------------|---------|
| `GrounderIK` | 通用 IKSolver | 射线检测地面 → 修改 IK 目标位置 |
| `GrounderFBBIK` | FullBodyBipedIK | 双射线(脚 + 脚趾) → 调整根/骨盆/脚 |
| `GrounderBipedIK` | BipedIK | 简单地面适配 |

#### 2.1.5 设计模式

- **Template Method**: `IK` 基类定义 `UpdateSolver()` / `InitiateSolver()` / `FixTransforms()` 骨架
- **Strategy**: 多种 `IKSolver` 实现可互换的求解算法
- **Composite**: `FullBodyBipedIK` 组合多个子 IK (LookAt + Limb)
- **Bridge**: `SolverManager` 连接 MonoBehaviour 生命周期与求解器逻辑

---

### 2.2 Unity Animation Rigging

**路径**: `Assets/Scripts/Unity.Animation.Rigging/UnityEngine/Animations/Rigging/`
**文件数**: 10 个 `.cs`
**命名空间**: `UnityEngine.Animations.Rigging`

#### 2.2.1 TwoBoneIKConstraint 体系

| 文件 | 核心逻辑 | 设计亮点 |
|------|----------|---------|
| `TwoBoneIKConstraint.cs` | `RigConstraint<TwoBoneIKConstraintJob, TwoBoneIKConstraintData, TwoBoneIKConstraintJobBinder>` | 组件容器: 连接 Data+Job+Binder |
| `TwoBoneIKConstraintData.cs` | 包含 `_root/_mid/_tip/_target/_hint` + 3个权重 | `[SyncSceneToStream]` 属性标记 |
| `TwoBoneIKConstraintJob.cs` | `IWeightedAnimationJob` + `[BurstCompile]` | `ProcessAnimation()` 调用 `AnimationRuntimeUtils.SolveTwoBoneIK()` |
| `TwoBoneIKConstraintJobBinder.cs` | `Create()` → 绑定 TransformHandles + PropertyHandles | 维护 targetOffset (AffineTransform) |

#### 2.2.2 ChainIKConstraint 体系

| 文件 | 核心逻辑 |
|------|---------|
| `ChainIKConstraint.cs` | 链式 IK 组件 |
| `ChainIKConstraintData.cs` | `_root/_tip/_target` + 迭代次数 + 最大弧度 |
| `ChainIKConstraintJob.cs` | `[BurstCompile]` → 调用 `AnimationRuntimeUtils.SolveFABRIK()` |
| `ChainIKConstraintJobBinder.cs` | 绑定 |

#### 2.2.3 核心算法 (AnimationRuntimeUtils)

`SolveTwoBoneIK()` 算法流程:
1. 计算 root→mid 和 mid→tip 的骨骼长度
2. 计算 target 相对 root 的距离 `targetDist`
3. 如果 `targetDist > lengthA + lengthB`: 完全伸直 (方向对齐)
4. 如果 `targetDist < |lengthA - lengthB|`: 完全折叠
5. 否则: 三角法计算 `cosAngle` → `angleA` → `angleB`
6. 应用 hint 方向偏移, 产生弯曲方向
7. 旋转 root 和 mid 骨骼

`SolveFABRIK()` 算法流程:
1. **Forward Reaching**: 从末端到根, 逐关节调整位置朝向 target
2. **Backward Reaching**: 从根到末端, 逐关节保持骨骼长度
3. 迭代直到收敛或达到最大迭代次数

---

### 2.3 HG Custom IK Extension

**路径**: `Assets/Scripts/Gameplay.Beyond/Beyond/Gameplay/Animations/RiggingExtension/`
**文件数**: 17 个 `.cs`
**命名空间**: `Beyond.Gameplay.Animations.RiggingExtension`
**角色**: 在 Unity Animation Rigging 基础上扩展 HG 定制 IK

#### 2.3.1 类继承体系

```
RigConstraint<HGTwoBoneIKConstraintJob, HGTwoBoneIKConstraintData, HGTwoBoneIKConstraintJobBinder<HGTwoBoneIKConstraintData>>
  └── HGTwoBoneIKConstraint          — 地面法线 + 分量旋转

RigConstraint<HGPrepareIKEffectorConstraintJob, ...>
  └── HGPrepareIKEffectorConstraint  — 单效应器预处理 (关节限位)

RigConstraint<HGIKPrepareEffectorsConstraintJob, ...>
  └── HGIKPepareEffectorsConstraint  — 多效应器批量预处理

数据结构:
  IHGTwoBoneIKConstraintData : ITwoBoneIKConstraintData  — 添加 groundNormal + componentRotation
  IHGPrepareIKEffectorConstraintData : IAnimationJobData  — 效应器预处理数据
  IHGIKPrepareEffectorsConstraintData : IAnimationJobData — 多效应器数据
```

#### 2.3.2 HGTwoBoneIKConstraint

| 文件 | 核心逻辑 | 与 Unity 原生差异 |
|------|----------|-------------------|
| `HGTwoBoneIKConstraintData.cs` | 继承 TwoBoneIKConstraintData + 新增 `_groundNormal`/`_componentRotation` | 多 2 个 `[SyncSceneToStream]` 属性 |
| `HGTwoBoneIKConstraintJob.cs` | 在调用 `SolveTwoBoneIK()` 后, 使用 `groundNormal` 和 `componentRotation` 后处理 | 支持地面法线适配 + 组件空间旋转 |
| `HGTwoBoneIKConstraintJobBinder.cs` | 额外绑定 `groundNormal`(Vector3Property) + `componentRotation`(Vector4Property) | 额外 2 个 PropertyHandle |

**HG 定制点**:
- `groundNormal` (Vector3) — 地面法线, 用于 IK 脚部在斜坡上贴合地面
- `componentRotation` (Quaternion as Vector4) — 组件根旋转, 使 IK 链在整个组件空间内旋转

#### 2.3.3 HGPrepareIKEffectorConstraint (单效应器预处理)

| 字段 | 类型 | 用途 |
|------|------|------|
| `_componentRoot` | Transform | 组件根骨骼 |
| `_source` | Transform | 源骨骼 (如脚骨) |
| `_target` | Transform | 效应器目标 |
| `_groundNormal` | Vector3 | 地面法线 |
| `_positionOffset` | Vector3 | 源→目标位置偏移 |
| `_rotationWeight` | float | 旋转权重 |
| `_maxPitchDegree` | float [0-90] | 最大俯仰角度限制 |
| `_maxRollDegree` | float [0-90] | 最大滚动角度限制 |

**算法流程**:
1. 读取 `componentRoot` 的世界旋转
2. 将 `positionOffset` 转换到组件局部空间
3. 从 offset 提取 pitch/roll 角度
4. 在 `[-maxPitch, +maxPitch]` 和 `[-maxRoll, +maxRoll]` 范围内钳位
5. 构造钳位后的旋转 `Quaternion.AngleAxis(pitch) * Quaternion.AngleAxis(roll)`
6. 回到世界空间后, 按 `rotationWeight` 与原始旋转混合
7. 写入最终位置/旋转到 `target`

#### 2.3.4 HGIKPrepareEffectorsConstraint (多效应器批量处理)

| 字段 | 类型 | 用途 |
|------|------|------|
| `_componentRoot` | Transform | 共同根骨骼 |
| `_transformAndNormals` | Vector3TransformArray | 自定义可序列化数组 (Transform + Vector3 对) |
| `_sourceTransforms` | WeightedTransformArray | 源骨骼 (带权重) |

**算法流程**:
1. 批量读取所有效应器的 ground normal XYZ 组件 (NativeArray<PropertyStreamHandle>)
2. 获取 `componentRoot` 旋转 → 计算世界空间前方向
3. 逐效应器: 用 ground normal + 参考方向构造 `LookRotation`
4. 用源骨骼旋转将旋转对齐到局部空间
5. 写入所有效应器 `ReadWriteTransformHandle`

**Vector3TransformArray**: 自定义可序列化集合 (2260行), 实现 IList<Vector3Transform>, 支持 `[SyncSceneToStream]` 按元素绑定.

#### 2.3.5 三层 IK Pipeline

```
Stage 1: HGIKPrepareEffectorsConstraint (多效应器地面法线对齐)
           │  for each effector: groundNormal → LookRotation → Write
           ▼
Stage 2: HGPrepareIKEffectorConstraint (单效应器关节限位)
           │  positionOffset → pitch/roll clamp → weight blend → Write
           ▼
Stage 3: HGTwoBoneIKConstraint (2Bone IK 求解)
           │  SolveTwoBoneIK() + groundNormal + componentRotation -> Final
           ▼
        Final Animated Bone Poses
```

---

### 2.4 IK 求解器算法一览

| 算法 | 文件/来源 | 数学本质 | 特性 |
|------|----------|---------|------|
| **Analytic Two-Bone** | `AnimationRuntimeUtils.SolveTwoBoneIK()` | 三角法余弦定理: `cos(C) = (a²+b²-c²)/(2ab)` | 单帧解析解, 无迭代 |
| **FABRIK** | `IKSolverFABRIK` + `SolveFABRIK()` | 前向缩短+后向定长迭代 | 位置约束自然, 无旋转奇异性 |
| **CCD** | `IKSolverCCD` | 逐关节最小化末端→目标角度差 | 简单通用, 适合蛇形链 |
| **Trigonometric Limb** | `IKSolverLimb` + `IKSolverTrigonometric` | 余弦定理 + 四分圆弯曲方向 | 自动处理弯曲方向 |
| **LookAt** | `IKSolverLookAt` | 逐骨骼旋转到注视方向 + 钳位 | 脊椎旋转分布 + 角度限制 |
| **Full Body (FBIK)** | `IKSolverFullBody` | 多链多效应器 + 约束松弛迭代 | 支持躯体/手臂/腿/头同时求解 |
| **VR FABRIK** | `IKSolverVR` | 身体部分分离 + FABRIK + 三角混合 | 左右手/脚/头/ pelvis 单独求解 |

---

## 3. 布料/动态骨骼系统

### 3.1 BeyondDynamicBone (主布料系统)

**路径**: `Assets/Scripts/BeyondDynamicBone/BeyondDynamicBone/`
**文件数**: ~180 个 `.cs`
**命名空间**: `BeyondDynamicBone`
**角色**: 项目主布料/动态骨骼模拟系统 (MagicaCloth2 衍生定制版)

#### 3.1.1 架构总览

```
BeyondBoneCloth (主组件, 2622行)
       │
ClothProcess (核心模拟, 11241行)
       │
       ├── ClothManager (全局管理器, 3239行)
       ├── DynamicBoneTransformManager (变换缓冲区, 12456行)
       ├── ClothSerializeData (序列化数据, 2493行)
       │
       ├── 约束系统 (12类)
       │   ├── InertiaConstraint      — 惯性约束
       │   ├── AngleConstraint        — 角度/弯曲约束
       │   ├── DistanceConstraint     — 距离约束
       │   ├── MotionConstraint       — 运动约束
       │   ├── TetherConstraint       — 系绳约束
       │   ├── TriangleBendingConstraint — 三角形弯曲
       │   ├── SelfCollisionConstraint — 自碰撞
       │   ├── ColliderCollisionConstraint — 碰撞器碰撞
       │   ├── SpringConstraint       — 弹簧约束
       │   └── EndSimulationStepJobKernels — 最终步
       │
       ├── 碰撞器系统
       │   ├── BeyondBoneCapsuleCollider — 胶囊碰撞器
       │   ├── BeyondBoneSphereCollider  — 球体碰撞器
       │   ├── BeyondBonePlaneCollider   — 平面碰撞器
       │   └── ColliderManager           — 碰撞器管理器
       │
       ├── 风系统
       │   ├── BeyondBoneWindZone        — 风区组件
       │   ├── WindManager               — 风管理器
       │   └── WindParams/Settings/TeamWindData — 风参数
       │
       ├── VirtualMesh 系统
       │   ├── VirtualMesh               — 虚拟网格数据
       │   ├── VirtualMeshManager         — 虚拟网格管理器
       │   ├── VirtualMeshBoneWeight      — 骨骼权重
       │   └── VirtualMeshPrimitive       — 网格图元
       │
       ├── 简化系统
       │   ├── SameDistanceReduction      — 等距简化
       │   ├── ShapeDistanceReduction     — 形状简化
       │   └── SimpleDistanceReduction    — 简单简化
       │
       ├── PreBuild 预构建
       │   ├── PreBuildManager + PreBuildScriptableObject
       │   └── SharePreBuildData + UniquePreBuildData
       │
       ├── SavePoint 系统 (6 文件)
       │   └── BeyondBoneClothSavePoint + ...Manager/Simulation/Collider 等
       │
       └── 数据集合扩展
           ├── ExNativeArray / ExSimpleNativeArray / ExBitFlag16/8
           ├── NativeArrayExtensions / NativeParallelHashMap
           └── FixedList128/32/64/512/4096BytesExtensions
```

#### 3.1.2 关键类详细分析

**BeyondBoneCloth.cs (2622行)**:
| 组件 | 说明 |
|------|------|
| 属性: clothAnimatorAbilityLODThreshold, clothAnimatorLODThreshold, clothLODFadeTime | LOD 控制 |
| 属性: animationPoseRatio | 动画姿态混合率 (0=物理完全覆盖, 1=动画完全覆盖) |
| 属性: clothSimulateWeight | 模拟权重 (0=停止模拟) |
| 属性: gravity/damping/worldInertia/localInertia/windInfluence | 物理参数 |
| 属性: blendWeight | 混合权重 |
| `relativeTransformPos/Rot` | 相对变换 (用于 Teleport 防爆) |
| `serializeData / serializeData2` | 序列化数据 |
| `process` | ClothProcess 核心模拟实例 |

**ClothBehaviour.cs (75行)**:
```csharp
abstract class ClothBehaviour : MonoBehaviour
```
所有布料组件的抽象基类。支持 Gizmo 可视化, 提供 `GetMagicaHashCode()`。

**ClothProcess.cs (11241行)**:
核心模拟过程管理:
- 布料数据生成 (虚拟网格构建)
- 约束初始化与求解
- Burst Job 调度
- 变换数据更新

**ClothManager.cs (3239行)**:
全局单例管理器:
- `clothSet` / `boneClothSet` / `meshClothSet` — 分类管理布料实例
- 更新循环调度 (PreUpdate/Update/PostUpdate)

**DynamicBoneTransformManager.cs (12456行)**:
变换缓冲区管理:
- 管理 Animator 写入与布料读取之间的变换缓冲区
- 动画器写入 Job 调度
- 跨帧变换同步

**ClothSerializeData.cs (2493行)**:
完整的布料序列化数据结构:
- PaintMode (绘制模式: Manual/Brush)
- AnimatorAbilityLevel (动画能力等级: Low/High)
- 渲染器引用列表
- 根骨骼列表
- 更新模式 (UnityScaledDeltaTime/UnscaledDeltaTime/Manual)
- LOD 设置

**ClothParameters.cs**:
```csharp
struct ClothParameters {
    Gravity, Damping, Inertia, Wind,
    Collision, Bend/Angle Constraints, ...
}
```
808 bytes — 所有物理参数的紧凑结构体。

#### 3.1.3 约束系统

| 约束 | 类型 | 说明 |
|------|------|------|
| `InertiaConstraint` | 惯性 | 模拟物体运动惯性 (世界/局部) |
| `AngleConstraint` | 弯曲 | 限制相邻骨骼间夹角 |
| `DistanceConstraint` | 距离 | 保持粒子间距离约束 |
| `MotionConstraint` | 运动 | 限制粒子运动范围 |
| `TetherConstraint` | 系绳 | 将粒子约束到参考位置 |
| `TriangleBendingConstraint` | 三角形弯曲 | 面片弯曲约束 |
| `SelfCollisionConstraint` | 自碰撞 | 防止布料自身穿透 |
| `ColliderCollisionConstraint` | 碰撞器 | 与场景碰撞器交互 |
| `SpringConstraint` | 弹簧 | 附加弹力模拟 |
| `EndSimulationStepJobKernels` | 最终步骤 | 后处理收尾计算 |

每个约束均包含 Burst 编译的 Job Kernel 文件 (如 `AngleConstraintJobKernels.cs`), 通过 `IJobParallelFor` / `IJob` 在工作线程中并行执行。

#### 3.1.4 关键技术特征

| 特性 | 实现 |
|------|------|
| **模拟算法** | PBD (Position Based Dynamics) |
| **并行计算** | Unity Burst Compiler + IJobParallelFor |
| **优化** | 离线 PreBuild 缓存 + 运行时 SavePoint 状态保存/恢复 |
| **网格** | 自定义 VirtualMesh 代理网格 (骨骼权重/图元/碰撞) |
| **风** | 多风区叠加 + 团队风数据 (TeamWindData) |
| **LOD** | 距离 + 动画能力双阈值 + 渐隐时间 |
| **更新模式** | UnityScaledDeltaTime / UnscaledDeltaTime / Manual |
| **热补丁** | 所有方法通过 IFix 包装器 (IsPatched/GetPatch) |

---

### 3.2 MagicaCloth v1 (旧版)

**路径**: `Assets/Scripts/MagicaCloth/MagicaCloth/`
**文件数**: ~30+ `.cs`
**命名空间**: `MagicaCloth`
**角色**: 旧版 ComputeShader 布料模拟 (与 BeyondDynamicBone 共存)

#### 3.2.1 架构

```
BaseCloth : PhysicsTeam           — 所有布料基类
  ├── MagicaBoneCloth             — 基于骨骼的布料
  └── MagicaMeshCloth             — 基于网格的布料

PhysicsManagerCompute             — ComputeShader 物理模拟调度 (核心)
  ├── PhysicsManagerBoneData      — 骨骼数据
  ├── PhysicsManagerMeshData      — 网格数据
  ├── PhysicsManagerParticleData  — 粒子数据
  ├── PhysicsManagerTeamData      — 团队数据
  ├── PhysicsManagerWindData      — 风数据
  ├── PhysicsManagerConstraint    — 约束管理
  └── PhysicsManagerWorker        — Worker 线程管理
```

#### 3.2.2 约束类型 (14种)

| 约束 | 说明 |
|------|------|
| `ColliderCollisionConstraint` | 碰撞器碰撞 |
| `ColliderExtrusionConstraint` | 碰撞器挤压 |
| `EdgeCollisionConstraint` | 边碰撞 |
| `PenetrationConstraint` | 穿透约束 |
| `RestoreDistanceConstraint` | 距离恢复 |
| `RestoreRotationConstraint` | 旋转恢复 |
| `ClampDistanceConstraint` | 距离钳位 |
| `ClampDistance2Constraint` | 距离钳位v2 |
| `ClampPositionConstraint` | 位置钳位 |
| `ClampRotationConstraint` | 旋转钳位 |
| `CompositeRotationConstraint` | 复合旋转 |
| `SpringConstraint` | 弹簧 |
| `TriangleBendConstraint` | 三角形弯曲 |
| `TwistConstraint` | 扭曲 |
| `VolumeConstraint` | 体积保持 |

#### 3.2.3 设计模式

与 BeyondDynamicBone 的继承关系:
```
MagicaCloth v1 (ComputeShader) 
    → MagicaCloth v2 → BeyondDynamicBone (Burst Jobs + 定制)
```

BeyondDynamicBone 大量复用 MagicaCloth 的接口命名和架构理念, 但实现已从 ComputeShader 切换到 Burst Jobs.

---

### 3.3 GPU Cloth (管线集成)

**路径**: `Assets/Scripts/HG.RenderPipelines.Runtime/HG/Rendering/Runtime/`
**文件数**: ~18 `.cs`
**命名空间**: `HG.Rendering.Runtime`
**角色**: 渲染管线集成的 GPU Compute 布料模拟 (通过 RenderGraph 调度)

#### 3.3.1 架构

```
Authoring Layer (MonoBehaviour):
  ClothInfo.cs               — 布料实例配置 (594行)
  ClothGroupInfo.cs           — 布料组信息 (211行)
  GpuClothMatrixGenerator.cs  — 过程网格生成器 (208行)
  ClothMeshFilter.cs          — 网格过滤

Runtime Manager:
  GpuClothManager.cs          — CPU 管理/激活/数据上传 (~2200行)

RenderGraph Pass:
  GpuClothSimulationPassConstructor.cs — 构建 4 个 RenderGraph Pass (1479行)

Data Structs (blittable):
  ClothGroupData, ClothGroupMeta, ClothMetaData, ClothNodeData,
  ClothConstData, ClothSkeletonData, ClothMobileData

GPU Buffers:
  GpuClothRenderData, GpuClothClearBufferData, GpuClothGroupUploadData

Native Bridge:
  UnityEngine.HyperGryph.HGGpuClothManagerV2 — C++ 原生桥接
```

#### 3.3.2 GpuClothManager 关键常量

| 常量 | 值 | 含义 |
|------|-----|------|
| `MAX_ANCHOR_NUM` | 2 | 每节点最多 2 个锚点 |
| `MAX_NEIGHBOR_NUM` | 8 | 每节点最多 8 个邻居 |
| `MAX_CLOTH_NEIGHBOR_NUM` | 128 | 最大布料邻居缓存 |
| `CLOTH_BATCH_SIZE` | 256 | GPU 批处理大小 |
| `MAX_COLLIDER_NUM` | 4 | 每布料最多 4 个碰撞器 |
| `MAX_RUNTIME_CLOTH_GROUP_NUM` | 50 | 最大激活布料组数 |
| `PHYSICS_DELTA_TIME` | 0.023333333f | 固定物理步长 (~42Hz) |
| `CLOTH_DIRTY_DISTANCE` | 32f | 距离阈值, 超限才重新计算激活集 |

#### 3.3.3 RenderGraph Pass 序列

```
Frame Start
  │
  ├── GpuClothDataClear (清除缓冲区)
  │     ComputeShader: ClothDataClearMain
  │     条件: clearBufferData.shouldClear
  │
  ├── GpuClothDataUpload (上传 CPU→GPU 数据)
  │     ComputeShader: ClothDataUploadMain
  │     条件: uploadData.isValid
  │     上传: ClothMetaData / ClothNodeData / BatchMeta / BatchCache
  │
  ├── GpuClothSim (主物理模拟)
  │     ComputeShader: ClothSimMain
  │     条件: renderData.isValid
  │     输入: clothNodeData + clothMetaData + batchCache + skeletonData
  │     常量: clothConstData (dt, wind, etc.)
  │
  └── GpuClothSetDefault (回退: 仅更新骨骼缓冲区)
        条件: 仅 skeleton 有效时
        禁用 Pass Culling
Frame End: OnPostRendering() → FlipSkeletonFlag()
```

#### 3.3.4 ClothNodeData 结构 (192 bytes/节点)

| 字段 | 类型 | 大小 |
|------|------|------|
| `anchorNodeCacheIdx` | Vector2Int | 8B |
| `anchorNodeDistance` | Vector2 | 8B |
| `uv` | Vector2 | 8B |
| `collisionPlaneXY` | Vector2 | 8B |
| `packedBasePosition` | Vector4 | 16B |
| `packedBaseNormal` | Vector4 | 16B |
| `baseTangent` | Vector4 | 16B |
| `packedPrePosition` | Vector4 | 16B |
| `packedCurPosition` | Vector4 | 16B |
| `packedCurNormal` | Vector4 | 16B |
| `neighborClothNodeCacheIdx[8]` | fixed int[8] | 32B |
| `neighborClothNodeDistance[8]` | fixed float[8] | 32B |

#### 3.3.5 ClothMetaData 结构 (176 bytes/实例)

| 字段 | 类型 |
|------|------|
| `clothNodeIdxStart/End` | uint |
| `batchIdxStart` | uint |
| `iterNum` | uint (PBD 迭代次数) |
| `damping` | float |
| `windFreqFactor/BalanceFactor/IntensityScale` | float |
| `localToWorld0..2 / worldToLocal0..2` | Vector4 × 6 |
| `packedLongestAnchorDistance` | Vector4 |
| `packedClothNormal` | Vector4 |

#### 3.3.6 ClothGroupMeta 约束

```csharp
clothNum ≤ MAX_CLOTH_PER_GROUP (4)
Σ nodeNum ≤ MAX_CLOTH_NODE_PER_GROUP (512)
Σ batchNum ≤ MAX_CLOTH_BATCH_PER_GROUP (8)
Σ cacheEntry ≤ MAX_CLOTH_CACHE_ENTRY_PER_GROUP (128)
```

#### 3.3.7 激活管理算法

1. 每帧检查玩家移动是否超过 `CLOTH_DIRTY_DISTANCE` (32 units)
2. 按 `DistanceSquared(playerCenterXZ, groupWorldPosXZ)` 排序
3. 仅保留 Top 50 组进行激活
4. `SwapAndRemove` 模式管理激活/去激活集合
5. 支持 Streaming 模式 (ECS 驱动注册)

---

### 3.4 NPC 布料集成层

**路径**: `Assets/Scripts/Gameplay.Beyond/Beyond/NPC/Animation/`
**文件数**: 3 个核心 `.cs`
**命名空间**: `Beyond.NPC.Animation`

#### 3.4.1 ClothCalculator 体系

```
ClothCalculator (abstract, 1887行)
  ├── AnimatorClothCalculator (532行)
  └── AnimationStreamClothCalculator (559行)
```

**ClothCalculator 核心职责**:
- 从 Animator/JobStream 读取布料权重参数
- 管理物理布料权重过渡 (Lerp/MoveTowards)
- 按 `BeyondBoneClothPart` (PART1/PART2) 分区控制布料权重
- 处理布料启用/禁用 (LOD 适配)
- 处理 Teleport (设置相对变换防爆)
- 布料重置 (软重置/硬重置)

**关键常量**:
```csharp
MAGICA_CLOTH_WEIGHT_INCREASE_SPEED = 8f   // 权重增加速度
MAGICA_CLOTH_WEIGHT_DECREASE_SPEED = 3f   // 权重减少速度
DEFAULT_CLOTH_STABILIZATION_TIME = 0.1f   // 默认稳定时间
```

**CalcCloth() 核心流程**:
1. 从 Animator 读取 clothWeight/bodyWeight/blend 参数
2. 应用 LookAt 影响 (注视方向→身体权重调整)
3. Lerp `m_physicsClothWeight` → 目标权重
4. 应用到所有 BeyondBoneCloth 实例

**两个实现版本**:
| 实现 | Animator 读取方式 | 场景 |
|------|------------------|------|
| `AnimatorClothCalculator` | Unity `Animator.GetFloat/SetFloat` | 传统 Animator 管线 |
| `AnimationStreamClothCalculator` | `ScriptAnimationJobSyncMono.GetFloatFromStream/SetFloatToStream` | Job 管线 (性能优) |

#### 3.4.2 角色数据

| 文件 | 用途 |
|------|------|
| `BoneClothItem.cs` | NPC 布料装备数据: 名称/序列化数据/选择数据/根骨骼 |
| `NPCMeshMagicClothSettings.cs` | NPC MagicaCloth 设置 (布尔开关 + 预制体引用) |

---

## 4. 核心算法

| 算法 | 系统 | 本质描述 |
|------|------|---------|
| **Analytic Two-Bone IK** | Unity Rigging + FinalIK | 三角法余弦定理, `cos(C) = (a²+b²-c²)/(2ab)`, 单帧解析解 |
| **FABRIK** | FinalIK + Unity Rigging | 前向缩短(Forward Reaching) + 后向定长(Backward Reaching) 迭代 |
| **CCD** | FinalIK | 逐关节旋转, 最小化末端误差角度, 从末端到根 |
| **Full Body IK (FBIK)** | FinalIK | 多链/多效应器约束松弛: 每个效应器有 positionWeight + rotationWeight, 迭代求解 |
| **VR IK** | FinalIK | 身体部分分离求解: 左右手/脚各一个 FABRIK, pelvis 和头用三角法 |
| **Ground Normal IK** | HG Extension | `groundNormal` → `LookRotation` → 偏离方向臂长修正 → 地面贴合 |
| **PBD (Position Based Dynamics)** | BeyondDynamicBone | 位置约束迭代求解: 预测位置 → 约束投影 → 速度更新 |
| **GPU PBD** | GPU Cloth | 同上, 但在 ComputeShader 执行, 节点/邻域/锚点/批量缓存加速 |
| **距离约束** | 布料系统 | `C(p) = |p₁-p₂| - d`, 梯度投影修正 |
| **三角弯曲约束** | 布料系统 | 保持相邻两面片间的二面角, 抵抗压缩/拉伸 |
| **惯性约束** | 布料系统 | 保留粒子速度惯性, 分世界空间和局部空间 |
| **自碰撞约束** | 布料系统 | 碰撞检测 + 位置修正, 避免布料自身穿透 |
| **碰撞器碰撞** | 布料系统 | 胶囊体/球体/平面 → 点-几何体距离检测 + 推离 |
| **风模拟** | 布料+风系统 | `windTime += windSpeed × dt`, 噪声函数 UV 偏移, 力传递到粒子 |
| **激活距离排序** | GPU Cloth | 按 `DistanceSquared(playerXZ, groupXZ)` 排序, 保留 Top 50 |
| **权重过渡** | NPC 布料集成 | `Mathf.MoveTowards(current, target, speed × dt)`, 增加 8f / 减少 3f |

---

## 5. 数据流

### 5.1 IK 数据流 (HG Custom)

```
[Animation Job Sync / Animator]
       │
       │ groundNormal, componentRotation, weights
       ▼
[HGIKPrepareEffectorsConstraintJob]  — 多效应器地面法线对齐
       │
       │ modified effector transforms
       ▼
[HGPrepareIKEffectorConstraintJob]   — 单效应器关节限位
       │
       │ target + hint
       ▼
[HGTwoBoneIKConstraintJob]           — 2Bone IK 求解
       │
       │ root/mid/tip 旋转
       ▼
[Animated Bone Transforms]
```

### 5.2 BeyondDynamicBone 布料数据流

```
[ClothCalculator]                — 读取 Animator 参数
       │
       │ SetClothSimulateWeight()
       ▼
[BeyondBoneCloth]                — 主组件
       │
       │ process.Tick()
       ▼
[ClothProcess]                   — 核心模拟
       │
       ├── PreUpdate
       │   ├── VirtualMesh 更新
       │   ├── 变换数据读取
       │   └── 约束初始化
       │
       ├── Simulation (Burst Jobs)
       │   ├── InertiaConstraint.Job
       │   ├── DistanceConstraint.Job
       │   ├── AngleConstraint.Job
       │   ├── TetherConstraint.Job
       │   ├── ColliderCollisionConstraint.Job
       │   └── EndSimulationStep.Job
       │
       ├── PostUpdate
       │   ├── Wind 力应用
       │   ├── 法线/切线更新
       │   └── 变换写入
       │
       ▼
[DynamicBoneTransformManager]    — 变换缓冲区输出
       │
       ▼
[Rendered Mesh]
```

### 5.3 GPU Cloth 数据流

```
[Authoring] ClothInfo + ClothGroupInfo
       │ RegisterClothGroup()
       ▼
[GpuClothManager]   CPU 管理
       │ _ProcessPendingQueue() — 激活/去激活
       │ _SetPerDrawData() — ECS → per-draw data
       │ _UpdateWindParams() — 风累加
       │
       ▼
[RenderGraph Passes]
       │
       ├── GpuClothDataClear (ComputeShader: ClothDataClearMain)
       │      清除 clothNodeData / batchMeta / batchCache Buffer
       │
       ├── GpuClothDataUpload (ComputeShader: ClothDataUploadMain)
       │      UploadDataMap → Meta/Nodes/Batch/BatchCache
       │
       ├── GpuClothSim (ComputeShader: ClothSimMain)
       │      ClothConstData (dt/wind) + Node/Meta/Batch Cache → 模拟 → 写入位置
       │
       └── GpuClothSetDefault (回退: 仅更新骨骼 buffer)
       │
       ▼
[ClothSkeletonData Double Buffer]
       │ FlipSkeletonFlag() 每帧翻转
       ▼
[Rendered Mesh]
```

### 5.4 中间产物

| 产物 | 类型 | 生产者 | 消费者 |
|------|------|--------|--------|
| IK Target/Hint 变换 | Transform | `HGPrepareIKEffectorConstraintJob` | `HGTwoBoneIKConstraintJob` |
| Ground Normal | Vector3Property | `HGIKPrepareEffectorsConstraintJob` | `HGTwoBoneIKConstraintJob` |
| 布料权重 | float | `ClothCalculator` | `BeyondBoneCloth.SetClothSimulateWeight()` |
| 布料变换缓冲区 | TransformAccessArray | `DynamicBoneTransformManager` | `ClothProcess` Burst Jobs |
| 虚拟网格 | VirtualMesh | `VirtualMeshManager` | 约束求解器 |
| GPU 节点数据 | ComputeBuffer | `GpuClothGroupUploadData` | `GpuClothSimulationPassConstructor` |
| 骨架双缓冲 | ComputeBuffer ×2 | `GpuClothManager.FlipSkeletonFlag()` | 下一帧模拟 |
| PreBuild 缓存 | ScriptableObject | `PreBuildManager` | `BeyondBoneCloth` 初始化 |
| SavePoint | 多个 struct | `BeyondBoneClothSavePoint` | 运行时状态保存/恢复 |

---

## 6. 关键决策

### 6.1 三层 IK 并存 (FinalIK + Unity Rigging + HG Custom)
- **选择**: 同时保留 RootMotion FinalIK, Unity Animation Rigging, HG Custom Extension
- **原因**: FinalIK 提供成熟的全身/VR IK, Unity Rigging 提供 Job+Burst 性能, HG Expansion 提供地面法线/关节限位/NPC 定制
- **替代方案**: 统一到 FinalIK 或自定义 IK 求解器
- **亮点**: HG Extension 在 Unity Rigging 框架下新增 `groundNormal`/`componentRotation`/`maxPitchDegree`/`maxRollDegree` 等游戏定制属性

### 6.2 BeyondDynamicBone 替代 MagicaCloth
- **选择**: 从 MagicaCloth v1 ComputeShader → BeyondDynamicBone Burst Jobs
- **原因**: ComputeShader 对 GPU 带宽和硬件兼容性要求高, Burst Jobs 在 CPU 上可控且兼容性更广
- **替代方案**: 继续使用 MagicaCloth v2 ComputeShader, 或使用 Unity DOTS Physics
- **代价**: CPU 开销相比 GPU 方案更高, 但通过 Burst + IJobParallelFor 大幅优化

### 6.3 GPU Cloth 与 BeyondDynamicBone 双布料并存
- **选择**: 同时保留 GPU Cloth (管线集成) 和 BeyondDynamicBone (主布料)
- **原因**: GPU Cloth 用于特定场景 (大量轻量布料, 如群组/装饰物), BeyondDynamicBone 用于角色主要布料
- **替代方案**: 统一方案
- **亮点**: GPU Cloth 通过 RenderGraph 调度, 与渲染管线深度集成, 避免额外 CPU→GPU 同步

### 6.4 50 组激活上限 (GPU Cloth)
- **选择**: 最多 50 个布料组同时激活, 基于玩家距离排序
- **原因**: GPU 内存和 Compute 预算控制
- **替代方案**: 数量无限 + 视锥剔除
- **亮点**: `ClothActivateComparer` 按 XZ 平面距离排序, 优先激活最近的组

### 6.5 三层 IK Pipeline
- **选择**: 效应器预处理 → 关节限位 → IK 求解, 三层分离
- **原因**: 分离关注点: 地面适配 + 关节保护 + IK 求解各自独立可调
- **替代方案**: 单层 IK 求解器内嵌所有逻辑
- **亮点**: 每层都是独立 RigConstraint, 可自由组合/开关

### 6.6 NPC 布料权重双路径
- **选择**: `AnimatorClothCalculator` + `AnimationStreamClothCalculator` 双实现
- **原因**: 兼容旧 Animator 管线和新 Job 管线
- **替代方案**: 仅支持新 Job 管线 (需要全部迁移)
- **亮点**: 通过 `isStreamClothCalculator` 标志透明切换, 对上层 `ClothCalculator` 算法透明

### 6.7 IFix 热补丁全覆盖
- **选择**: 所有 IK/布料方法体均包含 IFix 包装器
- **原因**: 游戏上线后需要热修复 IK/布料逻辑
- **替代方案**: HybridCLR / Mono JIT
- **代价**: 代码被 IFix 包装器混淆, 本地阅读困难, 方法体显示为汇编指令

### 6.8 虚拟网格代理 (VirtualMesh)
- **选择**: 布料模拟在 VirtualMesh 上执行, 而非原始渲染网格
- **原因**: 渲染网格面数过高, 虚拟网格做简化后模拟效率大幅提升
- **替代方案**: 直接在渲染网格上模拟
- **亮点**: 支持三种简化策略 (等距/形状/简单) + PreBuild 离线缓存

### 6.9 布料 LOD 体系
- **选择**: 同时使用 AnimatorAbility LOD + 距离 LOD + 权重 Fade
- **原因**: 角色质量需要多维度降级 (动画能力 + 距离 + 权重混合)
- **替代方案**: 单一距离 LOD
- **亮点**: `clothAnimatorAbilityLODThreshold` + `clothAnimatorLODThreshold` 双阈值, `clothLODFadeTime` 控制渐隐时间

### 6.10 PBD 固定步长 (~42Hz)
- **选择**: GPU Cloth 使用 `PHYSICS_DELTA_TIME = 0.023333333f` (~42FPS)
- **原因**: 固定步长保证模拟确定性, 避免帧率波动导致布料抖动
- **替代方案**: 可变步长 + 子步迭代
- **亮点**: `packedDeltaT.z = 1/dt` 预计算, 减少 GPU 分支

### 6.11 SavePoint 系统
- **选择**: 布料状态 SavePoint (管理器/模拟/碰撞器/惯性中心/团队/虚拟网格)
- **原因**: 角色换装/场景切换/Teleport 时需要保存和恢复布料状态
- **替代方案**: 完全重置布料
- **亮点**: 6 种不同粒度的 SavePoint, 按需组合

### 6.12 HG IK 数据接口设计
- **选择**: `IHGTwoBoneIKConstraintData : ITwoBoneIKConstraintData` 接口继承
- **原因**: 与 Unity Animation Rigging 框架完全兼容, 保持泛型约束 `where T : IHGTwoBoneIKConstraintData`
- **替代方案**: 复制修改 Unity 源码
- **亮点**: `Vector3TransformArray` 自定义序列化集合 (2260行), 支持 `[SyncSceneToStream]` 元素级绑定

---

## 7. 全景统计与模块关系图

### 7.1 模块关系图

```
[Game Logic / Character System]
       │
       ├── IK 系统
       │   ├── RootMotion FinalIK (全身/VR/肢体 IK)
       │   ├── Unity Animation Rigging (2Bone/Chain IK)
       │   └── HG IK Extension (地面法线/关节限位/多层 Pipeline)
       │
       ├── 动画系统
       │   ├── Animator / ScriptAnimationJobSyncMono
       │   └── ClothCalculator (Animator / Stream 双路径)
       │
       ├── 布料系统
       │   ├── BeyondDynamicBone (主布料, Burst Jobs + PBD)
       │   │   ├── 约束系统 (12类)
       │   │   ├── 碰撞器 (Capsule/Sphere/Plane)
       │   │   ├── 风系统 (WindZone/Manager)
       │   │   ├── VirtualMesh (代理网格)
       │   │   ├── PreBuild (离线缓存)
       │   │   └── SavePoint (状态保存恢复)
       │   │
       │   ├── MagicaCloth v1 (旧版 ComputeShader)
       │   │
       │   └── GPU Cloth (管线集成)
       │       ├── GpuClothManager (CPU 管理)
       │       └── GpuClothSimulationPassConstructor (RenderGraph Pass)
       │
       ├── 渲染管线 (HG.RenderPipelines.Runtime)
       │   ├── GpuClothPass (Compute Shader ×3)
       │   └── HGGpuClothManagerV2 (C++ 原生桥接)
       │
       └── RuntimeQuality
           └── PhysicsClothQuality (布料质量开关)
```

### 7.2 全量统计

| 层级 | 模块 | 文件数 | 行数估计 |
|------|------|--------|---------|
| **IK 系统** | RootMotion FinalIK | 49 | ~25,000 |
| | Unity Animation Rigging | 10 | ~2,500 |
| | HG IK Extension (Gameplay.Beyond) | 17 | ~6,500 |
| **布料系统** | BeyondDynamicBone | ~180 | ~80,000+ |
| | MagicaCloth v1 | ~30 | ~10,000 |
| | GPU Cloth (HG.RenderPipelines.Runtime) | ~18 | ~7,200 |
| | NPC 布料集成 (Gameplay.Beyond) | 3 | ~3,000 |
| **支撑层** | IFix 包装器 | (内置) | — |
| **总计** | | **~307+** | **~134,200+** |
