# IK / 动态骨骼 / 布料系统 全量分析报告

## 目录

- [1. 总览](#1-总览)
- [2. IK 系统](#2-ik-系统)
  - [2.1 RootMotion FinalIK](#21-rootmotion-finalik)
  - [2.2 Unity Animation Rigging](#22-unity-animation-rigging)
  - [2.3 HG Custom IK Extension (RiggingExtension)](#23-hg-custom-ik-extension-riggingextension)
  - [2.4 四足 IK 系统 (QuadrupedIKRigging)](#24-四足-ik-系统-quadrupedikrigging)
  - [2.5 GrounderIK / BipedIK 角色集成层](#25-grounderik--bipedik-角色集成层)
  - [2.6 角色 LookAt IK 系统](#26-角色-lookat-ik-系统)
  - [2.7 NPC LookAt IK 系统](#27-npc-lookat-ik-系统)
  - [2.8 SkeletalMorph 眼部 IK (EvaluateEyeLookAtIKJob)](#28-skeletalmorph-眼部-ik-evaluateeyelookatikjob)
  - [2.9 过场动画 / Timeline IK (Slate)](#29-过场动画--timeline-ik-slate)
  - [2.10 Behavior Tree IK (NodeCanvas)](#210-behavior-tree-ik-nodecanvas)
  - [2.11 IK 碰撞查询工具 (IKCollisionHelper)](#211-ik-碰撞查询工具-ikcollisionhelper)
  - [2.12 IK 动画条件 (IKCastCondition)](#212-ik-动画条件-ikcastcondition)
  - [2.13 相机 IK (CameraRigMono TwoBoneIKSolve)](#213-相机-ik-camerarigmono-twoboneiksolve)
  - [2.14 IK 求解器算法一览](#214-ik-求解器算法一览)
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
│
├── Unity.Animation.Rigging/        # Unity 动画约束系统 (10 文件)
│
├── Gameplay.Beyond/
│   └── Animations/RiggingExtension/ # HG 自定义 IK 扩展 (22 文件)
│   └── View/Animation/IK/           # QuadrupedIKRigging
│   └── View/                        # GrounderIK/BipedIK/LookAtIK 集成
│   └── NPC/Animation/               # NPC 布料 + NPC LookAt IK
│   └── Core/                        # MovementComponent BipedIK
│
├── SkeletalUnsafe.Gameplay.Beyond/ # SkeletalMorph 眼部 IK (Job 支撑)
│
├── BeyondDynamicBone/              # 主布料/动态骨骼系统 (~180 文件)
│
├── MagicaCloth/                    # 旧版 MagicaCloth v1 (~30 文件)
│
├── HG.RenderPipelines.Runtime/     # GPU 布料模拟管线 (~18 文件)
│
├── Slate/                          # Timeline IK 剪辑 (2 文件)
│
└── ParadoxNotion/                  # Behavior Tree IK (1 文件)
    └── NodeCanvas/
```

### 1.2 全量模块总览

| 模块 | 文件数 | 一句话描述 | 报告章节 |
|------|--------|-----------|---------|
| RootMotion FinalIK | 49 | 完整 IK 求解器套件 (FABRIK/CCD/FBIK/VR) + Grounder + Biped | 2.1 |
| Unity Animation Rigging | 10 | Unity 官方动画约束系统 (Job+Burst) | 2.2 |
| HG IK Extension (RiggingExtension) | 22 | HG 定制 IK 扩展 (地面法线/关节限位/多效应器批处理/TransformOffset) | 2.3 |
| QuadrupedIKRigging | 1 | 四足 IK 系统 (4 肢 + 脊椎, SphereCast 地面贴合) | 2.4 |
| GrounderIK / BipedIK 集成层 | 9 | 角色/相机/NPC 中 GrounderBipedIK/BipedIK 集成 | 2.5 |
| 角色 LookAt IK | 2 | RootMotion LookAtIK 角色注视系统 | 2.6 |
| NPC LookAt IK | 5 | NPC 注视系统 (控制器/Avatar/参数) | 2.7 |
| SkeletalMorph 眼部 IK | 2 | Burst IJob 驱动的眼部 Morph IK | 2.8 |
| Slate Timeline IK | 2 | 过场动画中 LookAt/Limb IK 剪辑 | 2.9 |
| NodeCanvas IK | 1 | Behavior Tree IK Action | 2.10 |
| IKCollisionHelper | 1 | IK 脚部碰撞查询工具集 | 2.11 |
| IKCastCondition | 1 | IK 启用动画条件 (斜坡/角度) | 2.12 |
| Camera IK (CameraRigMono) | 1 | 自定义 Two-Bone IK 求解方法 | 2.13 |
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

#### 2.1.1 类继承体系 — IK 组件层

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
```

#### 2.1.2 类继承体系 — 求解器层

```
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

#### 2.1.3 Grounder 地面适配系统

| 类 | 目标 IK 系统 | 核心逻辑 |
|----|-------------|---------|
| `GrounderIK` | 通用 IKSolver | 射线检测地面 → 修改 IK 目标位置 |
| `GrounderFBBIK` | FullBodyBipedIK | 双射线(脚 + 脚趾) → 调整根/骨盆/脚 |
| `GrounderBipedIK` | BipedIK | 简单地面适配 (项目中实际使用的是此版本) |

#### 2.1.4 项目中实际使用的 FinalIK 类型

| 类型 | 使用位置 | 用途 |
|------|---------|------|
| `GrounderBipedIK` | CharacterAnimationComponent, MovementComponent, TransformFollowDamper, BaseModelComponent, CharacterAttachmentSolver | 角色地面适配 IK (主要使用) |
| `BipedIK` | AnimatedCameraController, ModelManager, NPCAvatarManager, TransformFollowDamper, CutsceneNpcDescriptor | 双足全身 IK (主要用于过场/相机) |
| `LookAtIK` | LookAtComponent, LookAtSetting | 角色注视 IK |
| `GrounderFBBIK` | (未直接使用, 仅框架内置) | — |
| `VRIK` | (框架内置, 未直接使用) | — |

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

---

### 2.3 HG Custom IK Extension (RiggingExtension)

**路径**: `Assets/Scripts/Gameplay.Beyond/Beyond/Gameplay/Animations/RiggingExtension/`
**文件数**: 22 个 `.cs`
**命名空间**: `Beyond.Gameplay.Animations.RiggingExtension`
**角色**: 在 Unity Animation Rigging 框架上扩展 HG 定制 IK — 含 4 类自定义 RigConstraint

#### 2.3.1 文件清单

| # | 文件 | 类型 | 描述 |
|---|------|------|------|
| 1 | `IHGTwoBoneIKConstraintData.cs` | Interface | 扩展 ITwoBoneIKConstraintData + groundNormal/componentRotation |
| 2 | `HGTwoBoneIKConstraint.cs` | Component | TwoBone IK 约束组件 |
| 3 | `HGTwoBoneIKConstraintData.cs` | Data | 含 _groundNormal/_componentRotation 扩展数据 |
| 4 | `HGTwoBoneIKConstraintJob.cs` | Job | Burst job, 调用 SolveTwoBoneIK + 后处理 |
| 5 | `HGTwoBoneIKConstraintJobBinder.cs` | Binder | PropertyHandle 绑定 (含额外 2 个) |
| 6 | `IHGPrepareIKEffectorConstraintData.cs` | Interface | 单效应器预处理接口 |
| 7 | `HGPrepareIKEffectorConstraint.cs` | Component | 单效应器预处理组件 |
| 8 | `HGPrepareIKEffectorConstraintData.cs` | Data | 含 maxPitchDegree/maxRollDegree 限位 |
| 9 | `HGPrepareIKEffectorConstraintJob.cs` | Job | pitch/roll 钳位 + 权重混合 |
| 10 | `HGPrepareIKEffectorConstraintJobBinder.cs` | Binder | 绑定所有 Handle |
| 11 | `IHGIKPrepareEffectorsConstraintData.cs` | Interface | 多效应器预处理接口 |
| 12 | `HGIKPepareEffectorsConstraint.cs` | Component | 多效应器预处理组件 (注意类名 typo: Pepare) |
| 13 | `HGIKPrepareEffectorsConstraintData.cs` | Data | Vector3TransformArray 批量数据 |
| 14 | `HGIKPrepareEffectorsConstraintJob.cs` | Job | 批量 ground normal → LookRotation 写入 |
| 15 | `HGIKPrepareEffectorsConstraintJobBinder.cs` | Binder | 复杂批量绑定 (NativeArray) |
| 16 | `IHGTransformOffsetConstraintData.cs` | Interface | 变换偏移接口 |
| 17 | `HGTransformOffsetConstraint.cs` | Component | 变换偏移约束组件 |
| 18 | `HGTransformOffsetConstraintData.cs` | Data | offset + isWorldSpace |
| 19 | `HGTransformOffsetConstraintJob.cs` | Job | Burst job, ApplyTransformOffset |
| 20 | `HGTransformOffsetConstraintJobBinder.cs` | Binder | 绑定 |
| 21 | `Vector3Transform.cs` | Struct | Transform + Vector3 数据对 |
| 22 | `Vector3TransformArray.cs` | Struct | 可序列化集合 (IList<Vector3Transform>, ~2260行) |
| 23 | `HGAnimationRuntimeUtils.cs` | Static | 自定义 IK 工具方法 |

#### 2.3.2 四类约束详述

**A. HGTwoBoneIKConstraint** — 增强型 Two-Bone IK
- 继承 `TwoBoneIKConstraintData` + 新增字段:
  - `_groundNormal` (Vector3) — 地面法线, 用于脚部斜坡贴合
  - `_componentRotation` (Quaternion as Vector4) — 组件根旋转
- Job 在 `SolveTwoBoneIK()` 后, 使用 groundNormal + componentRotation 后处理

**B. HGPrepareIKEffectorConstraint** — 单效应器预处理
- 功能: 在 IK 求解前准备 target 变换
- 核心限位: `_maxPitchDegree [0-90]`, `_maxRollDegree [0-90]`
- 算法: positionOffset → 局部空间 → pitch/roll 提取 → 钳位 → 权重混合 → 写入 target

**C. HGIKPrepareEffectorsConstraint** — 多效应器批量预处理
- 使用 `Vector3TransformArray` 存储多个 (Transform + Vector3) 对
- 批量读取 ground normal → 计算 LookRotation → 写入所有效应器

**D. HGTransformOffsetConstraint** — 变换偏移
- 简单位置偏移: `offset` (Vector3) + `isWorldSpace` (bool)
- 调用 `HGAnimationRuntimeUtils.ApplyTransformOffset`

#### 2.3.3 HGAnimationRuntimeUtils 详细方法

| 方法 | 用途 |
|------|------|
| `SolveTwoBoneIK(stream, root, mid, tip, target, hint, posWeight, rotWeight, hintWeight, targetOffset, groundNormalH, componentRotation)` | 自定义 TwoBone IK 求解 (兼容 Unity 原生 + 扩展参数) |
| `ApplyTransformOffset(stream, target, offset, isWorldSpace, weight)` | 应用变换位置偏移 |
| `_TriangleAngle(a, b, c)` | 三角法角度计算 |
| `_Vec4ToQuat(Vector4)` | Vector4 → Quaternion 转换 |
| `_ExtractPitchRoll(Quaternion)` | 提取俯仰/滚转角 |

#### 2.3.4 数据结构: Vector3TransformArray

- 自定义可序列化集合, 实现 `IList<Vector3Transform>`
- 存储固定大小 (最大 8) 的 (Transform + Vector3) 对
- 支持 `[SyncSceneToStream]` 按元素绑定到动画流
- 用于 `HGIKPrepareEffectorsConstraintData` 中批量传递 ground normal

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

### 2.4 四足 IK 系统 (QuadrupedIKRigging)

**路径**: `Assets/Scripts/Gameplay.Beyond/Beyond/Gameplay/View/Animation/IK/QuadrupedIKRigging.cs`
**命名空间**: `Beyond.Gameplay.View.Animation.IK`
**角色**: 完整的四足角色 IK 系统 — 4 肢 + 脊椎控制 + 地面贴合

#### 2.4.1 架构

```
QuadrupedIKRigging : TickableMono
  ├── LimbType 常量: LEFT_FRONT(0), RIGHT_FRONT(1), LEFT_BACK(2), RIGHT_BACK(3), COUNT(4)
  ├── Limb[] limbs[4]
  │     ├── root / middle / tip (Transform)        — 肢体骨骼链
  │     ├── newConstraint (HGTwoBoneIKConstraint)   — 2Bone IK 约束
  │     ├── prepareEffectorConstraint (HGPrepareIKEffectorConstraint) — 效应器预处理
  │     ├── target (Transform)                      — IK 目标
  │     ├── offset (Vector3)                        — 位置偏移
  │     ├── maxPitch / maxRoll [0-90]               — 关节限位
  │     ├── rotationSmoothFactor (float)            — 旋转平滑
  │     ├── ikFoot (Transform, optional)             — 根空间稳定骨骼
  │     ├── normalDeadZone [0-15]                   — SphereCast 抖动死区
  │     ├── groundNormal / targetGroundNormal        — 地面法线
  │     └── targetPosition / targetPositionMeshSpace — 目标位置
  └── Spine
        ├── spineIKConstraint (IRigConstraint)       — 脊椎 IK 约束
        ├── SetPelvisOffset(leftBack, rightBack)     — 骨盆偏移
        └── SetShoulderOffset(leftFront, rightFront) — 肩部偏移
```

#### 2.4.2 算法流程

```
FixedTick():
  for each limb (LF, RF, LB, RB):
    1. Physics.SphereCast(从 tip 向下) → 检测地面
    2. groundNormal = 碰撞法线
    3. normalDeadZone 过滤 (避免法线抖动)
    4. _GetPointOnPlaneWithXZ() → 计算地面投影点
    5. 写入 Limb.targetGroundNormal / targetPosition

  Spine:
    1. 读取所有 4 肢的 groundHeight
    2. SetPelvisOffset(lbHeight, rbHeight) — 后肢高度控制骨盆
    3. SetShoulderOffset(lfHeight, rfHeight) — 前肢高度控制肩部
    4. Spine.Update(deltaTime) — Lerp 平滑
```

#### 2.4.3 IK 权重映射

```
Limb.SetWeight(float weight):
  HGTwoBoneIKConstraint.weight = Clamp01(weight)
  HGPrepareIKEffectorConstraint.rotationWeight = Clamp01((weight - 1) * 2)
```
权重被分割: 2Bone IK 获得原始权重, 效应器预处理获得映射后权重 (范围 [-1,0] → [-2,0] → Clamp01).

---

### 2.5 GrounderIK / BipedIK 角色集成层

项目中 9 个文件集成了 RootMotion FinalIK 的 GrounderBipedIK / BipedIK:

#### 2.5.1 CharacterAnimationComponent.cs

**路径**: `Assets/Scripts/Gameplay.Beyond/Beyond/Gameplay/View/CharacterAnimationComponent.cs`
**字段**: `private GrounderBipedIK m_grounderIK`
**角色**: 角色的 GrounderIK 中央控制器, 提供 13+ 个公开方法:

| 方法 | 功能 |
|------|------|
| `SetGrounderIK(bool enabled)` | 启用/禁用 GrounderIK 组件 |
| `SetGrounderIKWeight(float weight)` | 设置 IK 整体权重 |
| `SetGrounderIKPelvisKeepingFootWeight(float weight)` | 骨盆保持脚部权重 |
| `SetGrounderIKFootAdsorbWeight(float weight)` | 脚部吸附权重 |
| `SetGrounderIKFloorTheta(float animTheta, float logicTheta, float floorFeetThetaByLogic)` | 设置地面角度 (动画/逻辑/脚) |
| `SetGrounderIKParamaterFromAnimBlackboard(GrounderIKParameters)` | 从动画黑板同步参数 |
| `SetGrounderIKLayer(LayerMask layerMask)` | 设置射线检测层 |
| `GetGrounderIKFootOffset(out left, out right, out leftOri, out rightOri)` | 获取脚部偏移 |
| `GetGrounderIKBodyTiltOffset(out tiltF, out tiltB)` | 获取身体倾斜偏移 |
| `GetGrounderIKFloorPredictTheta()` | 获取地面预测角度 |
| `GetGrounderIKFloorFootThetaByFoot()` | 获取脚部地面角度 |
| `GetGrounderIKFloorFootThetaByRoot()` | 获取根部地面角度 |
| `GetGrounderIKPelvisOffset(out float)` | 获取骨盆偏移 |
| `IsIKSolverReady()` | 检查 IK 求解器就绪状态 |

#### 2.5.2 GrounderIKParameters.cs

**路径**: `Assets/Scripts/Gameplay.Beyond/Beyond/Gameplay/View/GrounderIKParameters.cs`
**命名空间**: `Beyond.Gameplay.View`
**角色**: 动画黑板 → IK 系统的数据传输对象

```csharp
public struct GrounderIKParameters {
    float timeRef; bool isMoving; bool isAccelerating; bool isOnMovableBase;
    float gait; Vector3 moveSpeed;
    float leftCurStepTime; float rightCurStepTime;
    float startAnimWeight; bool isPlayingMontage;
}
```

#### 2.5.3 MovementComponent.cs

**路径**: `Assets/Scripts/Gameplay.Beyond/Beyond/Gameplay/Core/MovementComponent.cs`
**字段**: `private GrounderBipedIK m_bipedIK`
**方法**: `_GetBipedIK()` — 从 EntityView 获取 GrounderBipedIK 组件
**方法**: `_UpdateIKMovableBaseData()` — 更新 IK 可移动基座数据

#### 2.5.4 BaseModelComponent.cs

**路径**: `Assets/Scripts/Gameplay.Beyond/Beyond/Gameplay/View/BaseModelComponent.cs`
**功能**: 获取 `GrounderBipedIK` 并注册 `Grounding.OnRaycastDelegate` / `Grounding.OnCapsuleCastDelegate` 自定义射线回调

#### 2.5.5 TransformFollowDamper.cs

**路径**: `Assets/Scripts/Gameplay.Beyond/Beyond/Gameplay/View/TransformFollowDamper.cs`
**字段**: `private GrounderBipedIK m_grounderBipedIK`, `private bool m_writeBackBoneNeedApplyIKSeparately`
**另**: `TryGetComponent<BipedIK>()` 也在此文件中被引用

#### 2.5.6 CharacterAttachmentSolver.cs

**路径**: `Assets/Scripts/Gameplay.Beyond/Beyond/Gameplay/CharacterAttachmentSolver.cs`
**抽象类**: `CharacterAttachmentSolver : MonoBehaviour`
**方法**: `ExcuteIKPosetSolver(float, float, GrounderBipedIK)` — 使用 GrounderBipedIK 进行 IK 姿态求解
**字段**: `bExcuteIKPosetSolver`, `boneShouldBeIK (List<Transform>)`

#### 2.5.7 NPCAvatarManager.cs

**路径**: `Assets/Scripts/Gameplay.Beyond/Beyond/NPC/Avatar/NPCAvatarManager.cs`
**方法**: `_DisableBipedIKForTimelineCharacter(FNpcAvatarGenericParams, NPCDowngradeConfig, GameObject)` — 在过场时禁用 NPC BipedIK

#### 2.5.8 AnimatedCameraController.cs

**路径**: `Assets/Scripts/Gameplay.Beyond/Beyond/Gameplay/View/AnimatedCameraController.cs`
**功能**: 从 target 对象获取 `GetComponentInChildren<BipedIK>()`, 用于相机跟随 IK 角色

#### 2.5.9 ModelManager.cs

**路径**: `Assets/Scripts/Gameplay.Beyond/Beyond/Gameplay/View/ModelManager.cs`
**功能**: 获取 `GetComponent<BipedIK>()` 并调用 `bipedIK.Initiate()` 初始化

#### 2.5.10 CutsceneNpcDescriptor.cs

**路径**: `Assets/Scripts/Gameplay.Beyond/Beyond/Gameplay/CutsceneNpcDescriptor.cs`
**字段**: `public bool disableBipedIK` — 控制过场 NPC 是否禁用 BipedIK

---

### 2.6 角色 LookAt IK 系统

#### 2.6.1 LookAtComponent.cs

**路径**: `Assets/Scripts/Gameplay.Beyond/Beyond/Gameplay/View/LookAtComponent.cs`
**命名空间**: `Beyond.Gameplay.View`
**角色**: 角色注视 IK 核心组件

**字段**:
- `m_lookAtIkBehaviour` (LookAtIK) — RootMotion FinalIK 的 LookAtIK 实例
- `m_ikPosition` (Vector3) — IK 目标世界位置
- `m_ikPositionWeight` (float) — IK 位置权重
- `ikPoseWeight` (float 属性) — IK 姿态权重
- `animIK` (bool 属性) — 动画 IK 标志

**初始化**: `GetComponent<RootMotion.FinalIK.LookAtIK>()` 获取组件

#### 2.6.2 LookAtSetting.cs

**路径**: `Assets/Scripts/Gameplay.Beyond/Beyond/Gameplay/View/LookAtSetting.cs`
**角色**: LookAt IK 配置组件
**Tooltip**: "骨骼点出发的最小距离，避免IK失败"
**字段**: `_minDistance` — 避免 IK 失败的最小距离
**初始化**: `TryGetComponent<LookAtIK>()` — 若未找到 LookAtIK 则自禁用

---

### 2.7 NPC LookAt IK 系统

#### 2.7.1 文件清单

| 文件 | 类 | 描述 |
|------|---|------|
| `NPCCPUAnimationLookAtIkInfo.cs` | NPCCPUAnimationLookAtIkInfo | NPC LookAt IK 基础数据 |
| `NPCCPUAnimationLookAtControllerParams.cs` | NPCCPUAnimationLookAtControllerParams | LookAt 控制器参数 |
| `NPCLookAtAvatar.cs` | NPCLookAtAvatar | NPC LookAt Avatar 数据 |
| `NPCLookAtController.cs` | NPCLookAtController | NPC LookAt 主控制器 (6625行) |
| `LookAtDegree.cs` | LookAtDegree | 角度数据 (horizontal/vertical/roll) |
| `LookAtControllerHolder.cs` | LookAtControllerHolder | 控制器持有者 |

#### 2.7.2 NPCCPUAnimationLookAtIkInfo.cs

```csharp
public class NPCCPUAnimationLookAtIkInfo {
    bool bEnableIK;                // IK 启用开关
    string headBoneName;           // 头部骨骼名称
    int headBoneIndex;             // 头部骨骼索引
    string eyeRefBoneName;         // 眼部参考骨骼名称
    int eyeRefBoneIndex;           // 眼部参考骨骼索引
    List<string> spineBoneShortNames; // 脊椎骨骼短名列表
    List<int> spineBoneIndices;    // 脊椎骨骼索引列表
    Vector3 eyeBoneOffset;         // 眼部偏移
    float maxEyeAngleHorizontal;   // 最大水平眼角度
    float maxEyeAngleVertical;     // 最大垂直眼角度
}
```

#### 2.7.3 NPCCPUAnimationLookAtControllerParams.cs

```csharp
public class NPCCPUAnimationLookAtControllerParams {
    float targetSwitchSmoothTime;   // 目标切换平滑时间
    float weightSmoothTime;         // LookAtIK 权重混合时间
    float eyeWeightSmoothTime;      // LookAtIK 眼部权重混合时间
    float minDistance;              // 最小距离 (避免 IK 失败)
    float maxAngle;                 // 最大偏航角
}
```

#### 2.7.4 NPCLookAtAvatar.cs

```csharp
public class NPCLookAtAvatar {
    const float ANIMATION_LOOKAT_HORIZONTAL_DEFAULT_DEGREE = 45f;
    const float ANIMATION_LOOKAT_VERTICAL_DEFAULT_DEGREE = 30f;
    float m_maxEyeAngleHorizontal;
    float m_maxEyeAngleVertical;
    bool valid;
    Transform headPivotBone;       // 头部枢轴骨骼
    Transform headBone;            // 头部骨骼
    Transform[] spineBones;        // 脊椎骨骼数组
}
```

#### 2.7.5 NPCLookAtController.cs

- 6625 行的大型控制器
- 内部结构: `LookAtAxes` — 含 `horizontal [-1,1]`, `vertical [-1,1]`, 隐式转换为 Vector2
- 功能: 管理 NPC 注视目标切换, 权重平滑混合, 眼/头/脊椎旋转分配

---

### 2.8 SkeletalMorph 眼部 IK (EvaluateEyeLookAtIKJob)

#### 2.8.1 SkeletalMorphJobDefines.cs

**路径**: `Assets/Scripts/Gameplay.Beyond/Beyond/Gameplay/Core/SkeletalMorphJobDefines.cs`
**类**: `EvaluateEyeLookAtIKJob : IJob, [BurstCompile]`

**字段**:
- `runtime_morphNameHashToMorphData` (NativeParallelHashMap) — Morph 名称→数据映射
- `runtime_allMorphs` (NativeArray<FMorphRuntimeData>) — 所有 Morph 运行时数据
- `runtime_eyeIKNameHashR` / `runtime_eyeIKNameHashL` (NativeArray<int>) — 左右眼 IK Name Hash
- `runtime_eyeIKOffsetR` / `runtime_eyeIKOffsetL` (float4) — 左右眼 IK 偏移
- `runtime_eyeLookAtIKblendWeight` (float) — 融合权重

**Execute**: 调用 `_EvaluateEyeLookAtIK()` 执行眼部 IK Morph 解算

#### 2.8.2 SkeletalMorphCore.cs

**路径**: `Assets/Scripts/Gameplay.Beyond/Beyond/Gameplay/Core/SkeletalMorphCore.cs`

**眼部 IK 字段**:
- `m_isEyeLookAtIKEnable` (bool) — 眼部 IK 启用
- `m_forceEyeIKWeight` / `m_useForceEyeIKWeight` — 强制权重
- `m_animEyeLookAtWeight` (float) — 动画眼部权重
- `m_blinkAndSpeyeRandomIndex` — 眨眼/特殊眼动画随机索引
- `m_nextPlaySpeyeAnimIntervalTime / RandomRange / RemainTime` — 眼动画定时

**眼部 IK 方法**:
| 方法 | 功能 |
|------|------|
| `_InitializeEyeLookAtResources()` | 初始化 NativeArray 资源 |
| `EvaluateEyeLookAtIK(float blendWeight, JobHandle)` | 调度 EvaluateEyeLookAtIKJob |
| `SetLookAtEyeIK(float up, float down, float right, float left)` | 设置注视眼 IK 方向 |
| `SetLookAtEyeIK(float4 vector)` | float4 版本 |
| `ResetLookAtEyeWeight()` | 重置眼部权重 |
| `SetLookAtEyeForceWeight(float weight)` | 设置强制权重 |
| `SetAnimEyeLookAtWeight(float weight)` | 设置动画眼部权重 |
| `SetLookAtEyeBlendWeightTime(float time)` | 设置混合时间 |
| `GetSpeyeEnabled()` / `SetSpeyeEnabled(bool)` | 特殊眼动画控制 |

---

### 2.9 过场动画 / Timeline IK (Slate)

#### 2.9.1 AnimateLookAtIK.cs

**路径**: `Assets/Scripts/Slate/Slate/ActionClips/AnimateLookAtIK.cs`
**命名空间**: `Slate.ActionClips`
**角色**: 过场动画中控制角色注视 IK

**参数**:
- `weight` [0-1] — 整体权重 (可动画化)
- `bodyWeight` [0-1] — 身体权重
- `headWeight` [0-1] — 头部权重
- `eyesWeight` [0-1] — 眼部权重
- `targetPosition` (TransformRefPosition) — 注视目标

**运行时**:
- 通过 `AnimatorDispatcher` 注册 `OnAnimatorIK` 回调
- 调用 `actor.SetLookAtPosition(worldTargetPos)`
- 调用 `actor.SetLookAtWeight(clipWeight * weight, bodyWeight, headWeight, eyesWeight, 0)`

#### 2.9.2 AnimateLimbIK.cs

**路径**: `Assets/Scripts/Slate/Slate/ActionClips/AnimateLimbIK.cs`
**命名空间**: `Slate.ActionClips`
**角色**: 过场动画中控制肢体 IK (手/脚)

**参数**:
- `IKGoal` (AvatarIKGoal) — 目标肢体 (LeftHand/RightHand/LeftFoot/RightFoot)
- `weight` [0-1] — 权重 (可动画化)
- `IKTarget` (TransformRefPositionRotation) — IK 目标位置/旋转

**运行时**:
- 通过 `AnimatorDispatcher` 注册 `OnAnimatorIK` 回调
- 调用 `actor.SetIKPosition(IKGoal, worldPos)`, `actor.SetIKRotation(IKGoal, worldRot)`
- 调用 `actor.SetIKPositionWeight(IKGoal, weight)`, `actor.SetIKRotationWeight(IKGoal, weight)`

---

### 2.10 Behavior Tree IK (NodeCanvas)

**路径**: `Assets/Scripts/ParadoxNotion/NodeCanvas/Tasks/Actions/MecanimSetIK.cs`
**命名空间**: `NodeCanvas.Tasks.Actions`
**角色**: Behavior Tree 中设置 IK 的 Action 节点

**参数**:
- `IKGoal` (AvatarIKGoal)
- `goal` (BBParameter<GameObject>) — 目标 GameObject
- `weight` (BBParameter<float>) — IK 权重

**运行时**: 通过 EventRouter 注册 OnAnimatorIK 事件, 调用 `agent.SetIKPositionWeight(IKGoal, weight)` + `agent.SetIKPosition(IKGoal, targetPos)`

---

### 2.11 IK 碰撞查询工具 (IKCollisionHelper)

**路径**: `Assets/Scripts/Gameplay.Beyond/Beyond/Gameplay/IKCollisionHelper.cs`
**命名空间**: `Beyond.Gameplay`
**类**: `public static class IKCollisionHelper`
**角色**: 静态工具类, 为 IK 脚部放置提供碰撞查询

**方法**:
| 方法 | 用途 |
|------|------|
| `LegacyRaycast(...)` | 旧版射线检测 |
| `Raycast(...)` | 射线检测 |
| `CapsuleCast(...)` | 胶囊体投射 |
| `_CastComplex(...)` | 复杂网格碰撞检测 |
| `_CastCapsuleComplex(...)` | 复杂网格胶囊检测 |
| `_GetWalkableLayers()` | 获取可行走层 |

**使用**: 通过 `BaseModelComponent` 注册为 `GrounderBipedIK.Grounding.OnRaycastDelegate` / `OnCapsuleCastDelegate` 的自定义回调

**QuadrupedIKRigging** 则直接使用 `Physics.SphereCast()`, 不通过 IKCollisionHelper

---

### 2.12 IK 动画条件 (IKCastCondition)

**路径**: `Assets/Scripts/Gameplay.Beyond/Beyond/Gameplay/View/Animation/IKCastCondition.cs`
**命名空间**: `Beyond.Gameplay.View.Animation`
**类**: `IKCastCondition : SpecialIdleCondition`
**角色**: 动画状态条件, 基于地面角度决定是否启用 IK

**字段**:
- `maxOffsetAngle` (float) — 最大偏移角度
- `maxSlopeAngle` (float) — 最大斜坡角度

**方法**: `EvaluateCondition(CharacterSpecialIdleContext, float)` — 检测地面角度/坡度是否在允许范围内

---

### 2.13 相机 IK (CameraRigMono TwoBoneIKSolve)

**路径**: `Assets/Scripts/Gameplay.Beyond/Beyond/Gameplay/View/CameraRigMono.cs`
**方法**: `_TwoBoneIKSolve(Vector3 rootPos, Vector3 targetPos, Vector3 polePos, float len1, float len2, Quaternion rootRotation, out Vector3 cWorld, out Vector3 bWorld)`
**角色**: 相机 Rig 中用于计算手臂/肢体 IK 位置的几何求解方法

---

### 2.14 IK 求解器算法一览

| 算法 | 文件/来源 | 数学本质 | 特性 |
|------|----------|---------|------|
| **Analytic Two-Bone** | AnimationRuntimeUtils.SolveTwoBoneIK() | 三角法余弦定理: cos(C) = (a²+b²-c²)/(2ab) | 单帧解析解, 无迭代 |
| **FABRIK** | IKSolverFABRIK + SolveFABRIK() | 前向缩短+后向定长迭代 | 位置约束自然, 无旋转奇异性 |
| **CCD** | IKSolverCCD | 逐关节最小化末端→目标角度差 | 简单通用, 适合蛇形链 |
| **Trigonometric Limb** | IKSolverLimb + IKSolverTrigonometric | 余弦定理 + 四分圆弯曲方向 | 自动处理弯曲方向 |
| **LookAt** | IKSolverLookAt | 逐骨骼旋转到注视方向 + 钳位 | 脊椎旋转分布 + 角度限制 |
| **Full Body (FBIK)** | IKSolverFullBody | 多链多效应器 + 约束松弛迭代 | 支持躯体/手臂/腿/头同时求解 |
| **VR FABRIK** | IKSolverVR | 身体部分分离 + FABRIK + 三角混合 | 左右手/脚/头/ pelvis 单独求解 |
| **HG Ground Normal** | HGTwoBoneIKConstraintJob | groundNormal → LookRotation → 后处理 | 地面法线 + 组件空间旋转 |
| **HG Pitch/Roll Clamp** | HGPrepareIKEffectorConstraintJob | 局部空间提取 pitch/roll → 钳位 → 混合 | 关节保护 (maxPitch/maxRoll) |
| **HG Multi-Effector Batch** | HGIKPrepareEffectorsConstraintJob | 批量 ground normal → LookRotation → 写入 | 多效应器批量地面对齐 |
| **HG Transform Offset** | HGTransformOffsetConstraintJob | 位置偏移 (世界/局部) | 简单变换偏移 |
| **Camera Two-Bone** | CameraRigMono._TwoBoneIKSolve | 几何三角法 | 相机 Rig 专用 |
| **EvaluateEyeLookAtIK** | SkeletalMorphJobDefines | Morph 权重混合 + 眼部偏移 | Burst IJob 并行 |
| **Unity Animator IK** | Slate/NodeCanvas | Animator.SetLookAtPosition/SetIKPosition | Timeline/BT 集成 |

---

## 3. 布料/动态骨骼系统

(与原报告 3.1-3.4 相同, 无变更)

### 3.1 BeyondDynamicBone (主布料系统)

**路径**: `Assets/Scripts/BeyondDynamicBone/BeyondDynamicBone/`
**文件数**: ~180 个 `.cs`
**命名空间**: `BeyondDynamicBone`

*(内容同原报告 3.1 节, 详见原始文件)*

### 3.2 MagicaCloth v1 (旧版)

**路径**: `Assets/Scripts/MagicaCloth/MagicaCloth/`
**文件数**: ~30+ `.cs`

*(内容同原报告 3.2 节)*

### 3.3 GPU Cloth (管线集成)

**路径**: `Assets/Scripts/HG.RenderPipelines.Runtime/HG/Rendering/Runtime/`
**文件数**: ~18 `.cs`

*(内容同原报告 3.3 节)*

### 3.4 NPC 布料集成层

**路径**: `Assets/Scripts/Gameplay.Beyond/Beyond/NPC/Animation/`
**文件数**: 3 个核心 `.cs`

*(内容同原报告 3.4 节)*

---

## 4. 核心算法

| 算法 | 系统 | 本质描述 |
|------|------|---------|
| **Analytic Two-Bone IK** | Unity Rigging + FinalIK | 三角法余弦定理, 单帧解析解 |
| **FABRIK** | FinalIK + Unity Rigging | 前向缩短 + 后向定长迭代 |
| **CCD** | FinalIK | 逐关节旋转, 最小化末端误差 |
| **Full Body IK (FBIK)** | FinalIK | 多链/多效应器约束松弛 |
| **VR IK** | FinalIK | 身体部分分离求解 |
| **Ground Normal IK** | HG Extension | groundNormal → LookRotation → 后处理 |
| **HG Pitch/Roll Clamp** | HG Extension | 局部空间 pitch/roll 钳位 + 权重混合 |
| **HG Multi-Effector Batch** | HG Extension | 批量 ground normal → 多效应器对齐 |
| **HG Transform Offset** | HG Extension | 位置偏移 (世界/局部空间) |
| **Quadruped SphereCast** | QuadrupedIKRigging | SphereCast → groundNormal → 死区过滤 → 投影 |
| **Eye LookAt IK (Morph)** | SkeletalMorphJobDefines | Burst IJob + Morph 权重混合 |
| **Quadruped Weight Split** | QuadrupedIKRigging | weight 在 2Bone IK 和 Effector 间拆分 |
| **Timeline IK (Slate)** | Slate ActionClips | OnAnimatorIK 回调 + Animator IK 接口 |
| **BT IK (NodeCanvas)** | ParadoxNotion | EventRouter + Animator IK 接口 |
| **IK Collision Query** | IKCollisionHelper | Raycast / CapsuleCast 地面检测 |
| **IK Cast Condition** | IKCastCondition | 角度/坡度阈值过滤 |
| **PBD (Position Based Dynamics)** | BeyondDynamicBone | 位置约束迭代求解 |
| **GPU PBD** | GPU Cloth | ComputeShader PBD 模拟 |
| **激活距离排序** | GPU Cloth | DistanceSquared 排序, Top 50 |
| **权重过渡** | NPC 布料集成 | MoveTowards, 增 8f / 减 3f |

---

## 5. 数据流

### 5.1 HG Custom IK 三层 Pipeline

```
[Animation Job Sync / Animator]
       │
       │ groundNormal, componentRotation, weights
       ▼
[HGIKPrepareEffectorsConstraintJob]  — 多效应器地面法线对齐 (批量)
       │
       │ modified effector transforms
       ▼
[HGPrepareIKEffectorConstraintJob]   — 单效应器关节限位 (pitch/roll clamp)
       │
       │ target + hint
       ▼
[HGTwoBoneIKConstraintJob]           — 2Bone IK 求解 + 后处理
       │
       │ root/mid/tip 旋转
       ▼
[Animated Bone Transforms]
```

### 5.2 QuadrupedIKRigging 数据流

```
[FixedTick] — 每固定帧更新
       │
       ├── Physics.SphereCast (每肢) → groundNormal + hitPoint
       ├── normalDeadZone 过滤 → 稳定法线
       ├── _GetPointOnPlaneWithXZ → 投影点
       │
       ▼
[Limb.SetWeight(weight)] — 权重分配
       │
       ├── HGTwoBoneIKConstraint.weight = Clamp01(weight)
       └── HGPrepareIKEffectorConstraint.rotationWeight = Clamp01((weight-1)*2)
       │
       ▼
[Spine] — 脊椎更新
       ├── SetPelvisOffset(leftBack, rightBack) — 后肢→骨盆
       ├── SetShoulderOffset(leftFront, rightFront) — 前肢→肩部
       └── Update(deltaTime) — Lerp 平滑
       │
       ▼
[Final Animated Poses — 4 肢 + 脊椎]
```

### 5.3 GrounderIK 数据流 (CharacterAnimationComponent)

```
[Animator Blackboard]
       │ GrounderIKParameters
       ▼
[CharacterAnimationComponent]
       ├── SetGrounderIK(bool)              — 启用/禁用
       ├── SetGrounderIKWeight(float)       — 整体权重
       ├── SetGrounderIKFloorTheta(...)     — 地面角度
       ├── SetGrounderIKParamaterFromAnimBlackboard(...) — 批量同步
       └── SetGrounderIKLayer(LayerMask)    — 碰撞层
       │
       ▼
[RootMotion.FinalIK.GrounderBipedIK]
       │ Grounding solver
       │ OnRaycastDelegate (← IKCollisionHelper / BaseModelComponent)
       ▼
[IK Foot/Pelvis/Spine Offsets]
       │
       ▼
[Final Animated Pose]
```

### 5.4 NPC LookAt IK 数据流

```
[NPC Target] (玩家/兴趣点)
       │
       ▼
[NPCLookAtController] (6625行)
       ├── targetSwitchSmoothTime — 目标切换平滑
       ├── weightSmoothTime       — 权重混合时间
       └── eyeWeightSmoothTime    — 眼部权重混合
       │
       ▼
[NPCLookAtAvatar]
       ├── headPivotBone → 头部旋转
       ├── headBone      → 头部朝向
       ├── spineBones[]  → 脊椎旋转分配
       └── maxEyeAngleHorizontal/Vertical → 眼部限位
       │
       ▼
[Final Head/Spine Rotation]

[NPCCPUAnimationLookAtIkInfo] — 配置数据
       ├── bEnableIK
       ├── headBoneName / eyeRefBoneName
       ├── spineBoneShortNames
       ├── eyeBoneOffset
       └── maxEyeAngleHorizontal/Vertical

[NPCCPUAnimationLookAtControllerParams] — 参数配置
       ├── targetSwitchSmoothTime
       ├── weightSmoothTime
       ├── eyeWeightSmoothTime
       ├── minDistance
       └── maxAngle
```

### 5.5 SkeletalMorph 眼部 IK 数据流

```
[SkeletalMorphCore]
       │
       ├── SetLookAtEyeIK(up, down, right, left) — 外部输入
       ├── m_isEyeLookAtIKEnable — 启用开关
       ├── m_animEyeLookAtWeight — 动画权重
       └── m_forceEyeIKWeight    — 强制权重
       │
       ▼
[EvaluateEyeLookAtIK(blendWeight, jobHandle)]
       │ 调度:
       ▼
[EvaluateEyeLookAtIKJob : IJob, BurstCompile]
       │
       ├── runtime_morphNameHashToMorphData (HashMap)
       ├── runtime_eyeIKNameHashR/L (NativeArray<int>)
       ├── runtime_eyeIKOffsetR/L (float4)
       └── runtime_eyeLookAtIKblendWeight (float)
       │
       ▼
[Morph Runtime Data Updated]
```

### 5.6 Timeline / BT IK 数据流

```
[Slate Timeline]
  AnimateLookAtIK ──→ OnAnimatorIK → Animator.SetLookAtPosition/Weight
  AnimateLimbIK   ──→ OnAnimatorIK → Animator.SetIKPosition/Rotation/Weight

[NodeCanvas BT]
  MecanimSetIK    ──→ EventRouter → OnAnimatorIK → Animator.SetIKPosition/Weight
```

### 5.7 BeyondDynamicBone 布料数据流

*(同原报告 5.2 节)*

### 5.8 GPU Cloth 数据流

*(同原报告 5.3 节)*

### 5.9 中间产物

| 产物 | 类型 | 生产者 | 消费者 |
|------|------|--------|--------|
| IK Target/Hint 变换 | Transform | HGPrepareIKEffectorConstraintJob | HGTwoBoneIKConstraintJob |
| Ground Normal | Vector3Property | HGIKPrepareEffectorsConstraintJob | HGTwoBoneIKConstraintJob |
| GrounderIK 参数 | GrounderIKParameters | Animator Blackboard | CharacterAnimationComponent |
| 脚部碰撞数据 | RaycastHit | IKCollisionHelper | GrounderBipedIK |
| 四足地面法线 | Vector3 | QuadrupedIKRigging.FixedTick | Limb.prepareEffectorConstraint |
| NPC LookAt 方向 | LookAtAxes | NPCLookAtController | NPCLookAtAvatar (骨骼旋转) |
| 眼部 IK 偏移 | float4 | SkeletalMorphCore.SetLookAtEyeIK | EvaluateEyeLookAtIKJob |
| Morph 运行时数据 | NativeArray<FMorphRuntimeData> | SkeletalMorphCore | 所有 Morph Job |
| 布料权重 | float | ClothCalculator | BeyondBoneCloth |
| 虚拟网格 | VirtualMesh | VirtualMeshManager | 约束求解器 |
| GPU 节点数据 | ComputeBuffer | GpuClothGroupUploadData | GpuClothSim |
| 骨架双缓冲 | ComputeBuffer ×2 | GpuClothManager | 下一帧模拟 |

---

## 6. 关键决策

### 6.1 五层 IK 并存 (FinalIK + Unity Rigging + HG Custom + Slate + Custom Jobs)
- **选择**: 同时保留 5 条 IK 技术栈:
  1. RootMotion FinalIK (GrounderBipedIK/BipedIK/LookAtIK)
  2. Unity Animation Rigging (TwoBone/Chain IK)
  3. HG Custom RiggingExtension (4 类自定义约束)
  4. Slate Timeline IK 剪辑 + NodeCanvas BT IK
  5. SkeletalMorph Eye LookAt IK (Burst IJob)
- **原因**: 不同场景使用不同技术: FinalIK 提供成熟全身/地面 IK, Unity Rigging 提供 Job+Burst 性能底座, HG Extension 提供地面法线/关节限位/NPC 定制, Slate 提供过场动画 IK 控制, Custom Job 提供高性能眼部 Morph IK

### 6.2 四足 IK 系统独立实现
- **选择**: 使用 HG Extension 约束搭建四足 IK, 而非复用 FinalIK 的 BipedIK
- **原因**: 四足生物腿部数量/排列与双足完全不同, 需要独立 SphereCast 地面检测 + 4 肢独立 IK 求解
- **亮点**: 权重分割策略 (2Bone IK / Effector 权重映射), normalDeadZone 抖动过滤

### 6.3 NPC LookAt IK 独立于角色 LookAt IK
- **选择**: NPC 使用自研 `NPCLookAtController` 系统, 角色使用 `RootMotion.LookAtIK`
- **原因**: NPC 数量多, 需要轻量级 CPU 控制; 角色需要高质量 FinalIK 注视
- **亮点**: `NPCCPUAnimationLookAtControllerParams` 提供三阶段平滑 (targetSwitch / weight / eyeWeight)

### 6.4 眼部 IK 使用 Morph 而非骨骼旋转
- **选择**: 通过 `EvaluateEyeLookAtIKJob` (Burst IJob) 驱动 Morph 混合形状, 而非旋转骨骼
- **原因**: 眼部动画使用 BlendShape 更自然, 与 SkeletalMorph 系统统一
- **亮点**: 与 SkeletalMorph 共享 NativeContainer 和 JobHandle 调度

### 6.5 GrounderBipedIK 居中控制
- **选择**: `CharacterAnimationComponent` 作为 GrounderIK 的中央控制器, 提供 13+ 个方法
- **原因**: 统一管理 IK 权重/角度/参数, 避免多个组件直接操作 GrounderBipedIK

### 6.6 IK 碰撞查询抽象
- **选择**: `IKCollisionHelper` 静态工具类 + `BaseModelComponent` 委托注册
- **原因**: 分离碰撞查询逻辑与 IK 求解, 支持不同碰撞策略 (Raycast/CapsuleCast/复杂检测)

### 6.7 过场 IK 通过 Animator IK Pass
- **选择**: Slate/NodeCanvas 通过 `OnAnimatorIK` 事件 + `Animator.SetLookAtPosition/SetIKPosition`
- **原因**: 利用 Unity 原生 IK Pass 机制, 与现有动画系统无缝集成
- **要求**: Animator Controller 必须启用 "IK Pass"

### 6.8 其余决策 (6.8-6.20 同原报告)

*(原报告中 6.1-6.12 的决策内容保留, 编号顺延)*

---

## 7. 全景统计与模块关系图

### 7.1 模块关系图

```
[Game Logic / Character System]
       │
       ├── IK 系统
       │   ├── RootMotion FinalIK (全身/地面/注视 IK)
       │   │   ├── GrounderBipedIK — CharacterAnimationComponent 居中控制
       │   │   ├── BipedIK — 过场/相机集成
       │   │   └── LookAtIK — 角色注视
       │   │
       │   ├── Unity Animation Rigging (2Bone/Chain IK) [底座]
       │   │
       │   ├── HG IK Extension (RiggingExtension) [22 文件]
       │   │   ├── HGTwoBoneIKConstraint (增强 2Bone IK)
       │   │   ├── HGPrepareIKEffectorConstraint (单效应器预处理)
       │   │   ├── HGIKPrepareEffectorsConstraint (多效应器批量)
       │   │   ├── HGTransformOffsetConstraint (位置偏移)
       │   │   └── HGAnimationRuntimeUtils (工具方法)
       │   │
       │   ├── QuadrupedIKRigging (四足 IK, SphereCast 地面贴合)
       │   │
       │   ├── NPC LookAt IK System [5 文件]
       │   │   ├── NPCLookAtController + NPCLookAtAvatar
       │   │   ├── NPCCPUAnimationLookAtIkInfo
       │   │   └── NPCCPUAnimationLookAtControllerParams
       │   │
       │   ├── SkeletalMorph Eye LookAt IK (Burst IJob, Morph 驱动)
       │   │
       │   ├── Timeline IK (Slate: AnimateLookAtIK / AnimateLimbIK)
       │   │
       │   ├── Behavior Tree IK (NodeCanvas: MecanimSetIK)
       │   │
       │   └── 支撑工具
       │       ├── IKCollisionHelper (碰撞查询)
       │       ├── IKCastCondition (动画条件)
       │       ├── GrounderIKParameters (数据 DTO)
       │       └── CameraRigMono._TwoBoneIKSolve (相机 IK)
       │
       ├── 动画系统
       │   ├── Animator / ScriptAnimationJobSyncMono
       │   ├── SkeletalMorphCore (Morph + 眼部 IK)
       │   ├── CharacterAnimationComponent (GrounderIK 控制)
       │   └── ClothCalculator (Animator / Stream 双路径)
       │
       ├── 布料系统
       │   ├── BeyondDynamicBone (主布料, Burst Jobs + PBD)
       │   ├── MagicaCloth v1 (旧版 ComputeShader)
       │   └── GPU Cloth (管线集成)
       │
       ├── 渲染管线 (HG.RenderPipelines.Runtime)
       │   └── GpuClothPass (Compute Shader ×3)
       │
       └── RuntimeQuality
           └── PhysicsClothQuality (布料质量开关)
```

### 7.2 全量统计

| 层级 | 模块 | 文件数 | 行数估计 |
|------|------|--------|---------|
| **IK 系统** | RootMotion FinalIK | 49 | ~25,000 |
| | Unity Animation Rigging | 10 | ~2,500 |
| | HG IK Extension (RiggingExtension) | 22 | ~8,500+ |
| | QuadrupedIKRigging | 1 | ~2,000+ |
| | GrounderIK/BipedIK 集成层 | 9 | ~15,000+ |
| | 角色 LookAt IK | 2 | ~3,000+ |
| | NPC LookAt IK | 5 | ~8,000+ |
| | SkeletalMorph 眼部 IK | 2 | ~1,500+ |
| | Slate Timeline IK | 2 | ~1,200 |
| | NodeCanvas IK | 1 | ~200 |
| | IK 支撑工具 (Collision/Condition/Params) | 4 | ~1,500+ |
| **布料系统** | BeyondDynamicBone | ~180 | ~80,000+ |
| | MagicaCloth v1 | ~30 | ~10,000 |
| | GPU Cloth (HG.RenderPipelines.Runtime) | ~18 | ~7,200 |
| | NPC 布料集成 | 3 | ~3,000 |
| **支撑层** | IFix 包装器 | (内置) | — |
| | MemoryPack 序列化 | (内置) | — |
| **总计** | | **~338+** | **~168,400+** |

### 7.3 IK 系统对比总结

| 特性 | FinalIK | Unity Rigging | HG Extension | QuadrupedIK | NPC LookAt | SkeletalMorph Eye |
|------|---------|---------------|-------------|-------------|------------|-------------------|
| 算法类型 | 多算法 (FABRIK/CCD/三角/FBIK/VR) | TwoBone + FABRIK | TwoBone + 后处理 | TwoBone + 后处理 | 启发式 | Morph 混合 |
| 并行 | 单线程 | Burst IJob | Burst IJob | Burst IJob | 单线程 | Burst IJob |
| 地面法线 | Grounder 内置 | 无 | groundNormal 扩展 | SphereCast | 无 | 无 |
| 关节限位 | IKConstraintBend | 无 | maxPitch/maxRoll | maxPitch/maxRoll | 角度常量 | 角度常量 |
| 批量处理 | 单角色 | 单约束 | 多效应器批量 | 4 肢循环 | 单 NPC | 2 眼 |
| 集成方式 | 组件直接挂载 | RigBuilder | RigBuilder | TickableMono | TickComponent | SkeletalMorph |
| 使用场景 | 角色地面/全身/注视 | 基础 IK 约束 | NPC/角色 IK 定制 | 四足生物 | NPC 注视 | 眼部表情 |

---

*本报告基于对 `Assets/Scripts/` 下所有 IK/布料相关代码的全量分析, 涵盖 7 大 IK 子系统 + 4 大布料子系统, 共计 ~338+ 文件 / ~168,400+ 行代码.*
