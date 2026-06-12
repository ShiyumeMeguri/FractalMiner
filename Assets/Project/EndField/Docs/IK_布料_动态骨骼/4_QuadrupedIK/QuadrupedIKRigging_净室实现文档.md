# QuadrupedIKRigging 净室实现文档

> **说明**: 本文档基于对 IL2CPP/IFix 混淆代码的逆向分析（仅类/字段定义及方法签名可读）以及《IK/动态骨骼/布料系统全量分析报告》2.4 节编写。本文档不包含任何原始源代码的逐字复制，仅描述可观察的公开 API 表面、字段定义、算法逻辑和数学公式，可用于从零重新实现该系统。

---

## 1. 系统概述

QuadrupedIKRigging 是一个完整的四足角色 IK（反向动力学）系统，运行在 Unity Animation Rigging 框架之上。其主要功能包括：

- **4 肢地面贴合**: 对每一条肢体（左前、右前、左后、右后）执行 Physics.SphereCast 以检测地面，计算 IK 目标位置和地面法线。
- **法线抖动过滤**: 通过角度阈值（
ormalDeadZone）防止 SphereCast 边缘的法线抖动。
- **脊椎自适应**: 根据前后肢的地面高度差，动态计算骨盆（pelvis）和肩部（shoulder）的垂直偏移，使身体姿态适应地形起伏。
- **IK 权重映射**: 支持通过动画曲线控制每肢的 IK 权重，并将权重拆分到 HGTwoBoneIKConstraint（位置 IK）和 HGPrepareIKEffectorConstraint（旋转 IK）两个约束。
- **三阶段 Tick**: 基于 TickableMono 基类，在 FixedTick, Tick, LateTick 三个不同阶段执行不同类型的更新。

### 1.1 基类依赖

`
QuadrupedIKRigging : TickableMono
  ├── TickableMono 提供:
  │     - FixedTick(float deltaTime)   — 物理/碰撞阶段
  │     - Tick(float deltaTime)        — 常规更新阶段
  │     - LateTick(float deltaTime)    — 动画/后处理阶段
  │     - _SyncTickFunctionsEnabled()  — 同步 tick 启用状态
  │
  ├── 需要 Unity Animation Rigging 包:
  │     - UnityEngine.Animations.Rigging
  │     - Beyond.Gameplay.Animations.RiggingExtension (HG 自定义扩展)
  │
  └── 依赖组件:
        - Animator (RequireComponent)
        - RigBuilder (运行时获取)
`

---

## 2. 类结构定义

### 2.1 QuadrupedIKRigging 主类

`csharp
namespace Beyond.Gameplay.View.Animation.IK
{
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Animator))]
    public class QuadrupedIKRigging : TickableMono
    {
        // ============================================================
        // 嵌套类型: LimbType 常量
        // ============================================================
        public static class LimbType
        {
            public const int LEFT_FRONT  = 0;
            public const int RIGHT_FRONT = 1;
            public const int LEFT_BACK   = 2;
            public const int RIGHT_BACK  = 3;
            public const int COUNT       = 4;
        }

        // ============================================================
        // 嵌套类型: Limb（可序列化）
        // ============================================================
        [Serializable]
        public class Limb { ... }   // 详见第3节

        // ============================================================
        // 嵌套类型: Spine（可序列化）
        // ============================================================
        [Serializable]
        public class Spine { ... }  // 详见第4节

        // ============================================================
        // 常量
        // ============================================================
        private const string IK_CTRL_CURVE_PREFIX = \"fOutFootIKWeight_\";

        // ============================================================
        // 静态字段
        // ============================================================
        private static readonly string[] IK_CTRL_CURVE_SUFFIXES;
        public static readonly int[] IK_CTRL_CURVE_HASHES;

        // ============================================================
        // 序列化字段
        // ============================================================
        [SerializeField, HideInInspector]
        public Limb[] limbs;
        [SerializeField]
        public Spine spine;

        // ============================================================
        // 私有字段
        // ============================================================
        private Animator  m_animator;
        private RigBuilder m_rigBuilder;
        [NonSerialized]
        private bool     m_shouldTick;
        private bool     m_cachedIKEnabled;
        private bool     m_inited;
        private Vector3  m_lastPosition;

        // ============================================================
        // 保护属性
        // ============================================================
        protected override TickType tickOption => default(TickType);

        // ============================================================
        // 私有访问器属性
        // ============================================================
        private Limb leftFront  { get; set; }   // limbs[0]
        private Limb rightFront { get; set; }   // limbs[1]
        private Limb leftBack   { get; set; }   // limbs[2]
        private Limb rightBack  { get; set; }   // limbs[3]

        // ============================================================
        // 方法
        // ============================================================
        private static int _CurveHash(int limbType);
        public void Setup();
        public void SetEnableIK(bool enable);
        public void SetTickable(bool tickable);
        public override void FixedTick(float deltaTime);
        public override void Tick(float deltaTime);
        public override void LateTick(float deltaTime);
        private static Vector3 _GetPointOnPlaneWithXZ(Vector3 planePoint, Vector3 planeNormal, float x, float z);
    }
}

---

## 3. Limb 结构 -- 完整字段定义与说明

### 3.1 序列化字段（Inspector 中可配置）
