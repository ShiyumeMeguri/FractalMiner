# Slate Timeline IK 净室实现文档

## 文档信息

| 项目 | 内容 |
|------|------|
| 分析对象 | Slate ActionClips (AnimateLookAtIK / AnimateLimbIK) |
| 基础 API | Unity Animator IK Pass (OnAnimatorIK) |
| 事件派发器 | Slate.AnimatorDispatcher |
| 命名空间 | Slate.ActionClips |
| 适用场景 | 过场动画 (Timeline) 中控制角色注视/肢体 IK |

---

## 1. 类定义

### 1.1 AnimateLookAtIK

**类签名**: `public class AnimateLookAtIK : ActorActionClip<Animator>`

```
ActorActionClip<T>                     -- Slate 基类 (泛型, T = Animator)
  +-- AnimateLookAtIK                  -- 注视 IK 剪辑
```

**特性**:
- `[Description("Make the actor look at target position...")]`
- `[Category("Animator IK Control")]`
- `[Attachable(typeof(ActorActionTrack))]`

**Serialized 字段**:

| 字段 | 类型 | 可见性 | 说明 |
|------|------|--------|------|
| _length | float | [SerializeField][HideInInspector] private | 剪辑时长 |
| _blendIn | float | [SerializeField][HideInInspector] private | 淡入时长 |
| _blendOut | float | [SerializeField][HideInInspector] private | 淡出时长 |
| weight | float | [AnimatableParameter(0f, 1f)] public | 整体权重 [0-1], 可动画化 |
| bodyWeight | float | [AnimatableParameter(0f, 1f)] public | 身体权重 [0-1] |
| headWeight | float | [AnimatableParameter(0f, 1f)] public | 头部权重 [0-1] |
| eyesWeight | float | [AnimatableParameter(0f, 1f)] public | 眼部权重 [0-1] |
| targetPosition | TransformRefPosition | public | 注视目标位置引用 |
| dispatcher | AnimatorDispatcher | private | 运行时事件派发器引用 |

**属性**:

| 属性 | 类型 | 说明 |
|------|------|------|
| targetPositionVector | Vector3 | [AnimatableParameter(link = "targetPosition")] 可动画化位置, 从 TransformRefPosition.value 读取/写入 |
| info | string (override) | 剪辑显示信息 |
| length | float (override) | 读写 _length |
| blendIn | float (override) | 读写 _blendIn |
| blendOut | float (override) | 读写 _blendOut |

### 1.2 AnimateLimbIK

**类签名**: `public class AnimateLimbIK : ActorActionClip<Animator>`

```
ActorActionClip<T>                     -- Slate 基类 (泛型, T = Animator)
  +-- AnimateLimbIK                   -- 肢体 IK 剪辑
```

**特性**:
- `[Attachable(typeof(ActorActionTrack))]`
- `[Category("Animator IK Control")]`
- `[Description("Animate an actor IK Goal...")]`

**Serialized 字段**:

| 字段 | 类型 | 可见性 | 说明 |
|------|------|--------|------|
| _length | float | [SerializeField][HideInInspector] private | 剪辑时长 |
| _blendIn | float | [SerializeField][HideInInspector] private | 淡入时长 |
| _blendOut | float | [SerializeField][HideInInspector] private | 淡出时长 |
| IKGoal | AvatarIKGoal | public | IK 目标肢体 (LeftHand/RightHand/LeftFoot/RightFoot) |
| weight | float | [AnimatableParameter(0f, 1f)] public | 肢体 IK 权重 [0-1], 可动画化 |
| IKTarget | TransformRefPositionRotation | public | IK 目标位置 + 旋转引用 |
| dispatcher | AnimatorDispatcher | private | 运行时事件派发器引用 |

**属性**:

| 属性 | 类型 | 说明 |
|------|------|------|
| targetPosition | Vector3 | [AnimatableParameter(link = "IKTarget")] 从 IKTarget.get_position() 读取 |
| targetRotation | Vector3 | [AnimatableParameter(link = "IKTarget")] 从 IKTarget.get_rotation() 读取 |
| info | string (override) | 剪辑显示信息 |
| length | float (override) | 读写 _length |
| blendIn | float (override) | 读写 _blendIn |
| blendOut | float (override) | 读写 _blendOut |

---

## 2. AnimatorDispatcher 事件派发器

**类签名**: `public class AnimatorDispatcher : MonoBehaviour`

**命名空间**: `Slate`

### 2.1 定义

```csharp
namespace Slate
{
    [ExecuteInEditMode]
    public class AnimatorDispatcher : MonoBehaviour
    {
        private Animator _animator;
        private Animator animator { get; }

        public event Action<int> onAnimatorIK;
    }
}
```

### 2.2 运行机制

1. AnimatorDispatcher 挂载在 actor 的 GameObject 上
2. Unity 每帧在动画求值后调用 OnAnimatorIK(int layerIndex) 消息
3. AnimatorDispatcher.OnAnimatorIK() 内部检查 onAnimatorIK 委托是否非空, 若非空则调用所有注册的监听器
4. 监听器即 Action<int> 委托, 参数 int 为 IK Pass 的 layerIndex

> 注意: 该组件标注了 [ExecuteInEditMode], 在编辑模式下也会运行.

---

## 3. 运行时机制: 事件注册与注销

### 3.1 AnimateLookAtIK 生命周期

```
OnEnter() / OnReverseEnter()
  |
  +-- actor.GetAddComponent<AnimatorDispatcher>()   // 获取或创建派发器
  |     +-- 结果存入 this.dispatcher
  |
  +-- dispatcher.onAnimatorIK += this.OnAnimatorIK  // 订阅事件

OnExit() / OnReverse()
  |
  +-- dispatcher.onAnimatorIK -= this.OnAnimatorIK  // 取消订阅

OnRootDisabled()
  |
  +-- DestroyImmediate(dispatcher)                   // 销毁派发器组件
```

### 3.2 AnimateLimbIK 生命周期

同 AnimateLookAtIK 完全一致的模式:

```
OnEnter() / OnReverseEnter()
  +-- actor.GetAddComponent<AnimatorDispatcher>()
  +-- dispatcher.onAnimatorIK += this.OnAnimatorIK

OnExit() / OnReverse()
  +-- dispatcher.onAnimatorIK -= this.OnAnimatorIK

OnRootDisabled()
  +-- DestroyImmediate(dispatcher)
```

---

## 4. 关键 API 调用

### 4.1 AnimateLookAtIK.OnAnimatorIK(int index)

```
OnAnimatorIK(int index):
  1. clipWeight = GetClipWeight()                    // Slate 内部, 根据时间/淡入淡出计算
  2. targetPos   = targetPosition.get_value()        // 从 TransformRefPosition 读取
  3. space       = targetPosition.get_space()
  4. worldPos    = TransformPosition(targetPos, space) // 转换到世界空间
  5. actor.SetLookAtPosition(worldPos)               // Unity Animator API
  6. finalWeight = clipWeight * weight               // 剪辑权重 x 用户权重
  7. actor.SetLookAtWeight(
         finalWeight,                                // 整体权重
         bodyWeight,                                 // 身体权重
         headWeight,                                 // 头部权重
         eyesWeight,                                 // 眼部权重
         0                                           // clampWeight = 0
     )
```

**对应 Unity Animator API 签名**:
```csharp
public void SetLookAtPosition(Vector3 worldPosition);
public void SetLookAtWeight(
    float weight,       // 整体权重 (clipWeight * userWeight)
    float bodyWeight,   // 身体参与度 [0-1]
    float headWeight,   // 头部参与度 [0-1]
    float eyesWeight,   // 眼部参与度 [0-1]
    float clampWeight   // 钳位权重 (始终为 0)
);
```

### 4.2 AnimateLimbIK.OnAnimatorIK(int index)

```
OnAnimatorIK(int index):
  1. clipWeight = GetClipWeight()
  2. finalWeight = clipWeight * weight
  3. pos  = IKTarget.get_position()                  // 从 TransformRefPositionRotation 读取位置
  4. space = IKTarget.get_space()
  5. worldPos = TransformPosition(pos, space)         // 转换到世界空间
  6. rot  = IKTarget.get_rotation()                  // 从 TransformRefPositionRotation 读取旋转
  7. worldRot = TransformRotation(rot, space)         // 转换到世界空间
  8. actor.SetIKPosition(IKGoal, worldPos)            // Unity Animator API
  9. actor.SetIKRotation(IKGoal, worldRot)
  10. actor.SetIKPositionWeight(IKGoal, finalWeight)
  11. actor.SetIKRotationWeight(IKGoal, finalWeight)
```

**对应 Unity Animator API 签名**:
```csharp
public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition);
public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation);
public void SetIKPositionWeight(AvatarIKGoal goal, float weight);
public void SetIKRotationWeight(AvatarIKGoal goal, float weight);
```

---

## 5. 数据流

### 5.1 Timeline 到 IK 完整管线

```
[Slate Timeline 播放]
       |
       | 剪辑进入活动段
       v
[AnimateLookAtIK / AnimateLimbIK]
       |
       | OnEnter()
       v
[AnimatorDispatcher] (挂载在 actor GameObject 上)
       |
       | 注册 onAnimatorIK 事件回调
       v
[Unity Animator Update]
       |
       | Animator Controller 启用 "IK Pass"
       v
[Unity 调用 OnAnimatorIK(int layerIndex)]
       |
       | AnimatorDispatcher 转发事件
       v
[AnimateLookAtIK.OnAnimatorIK() / AnimateLimbIK.OnAnimatorIK()]
       |
       | 计算权重、转换位置/旋转到世界空间
       v
[actor.SetLookAtPosition / SetIKPosition]
[actor.SetLookAtWeight / SetIKPositionWeight / SetIKRotationWeight]
       |
       | Unity 内部 IK 求解
       v
[Animator IK Pass: 修改骨骼最终姿态]
       |
       v
[Final Pose -> SkinMeshRenderer -> 渲染]
```

### 5.2 权重计算

```
clipWeight = GetClipWeight()
    +-- 由 Slate 计算: 在剪辑时间窗口内, 根据 blendIn/blendOut 进行平滑
    +-- 范围 [0, 1]

AnimateLookAtIK: finalWeight = clipWeight * weight
    +-- clipWeight:  时间平滑权重 (淡入/淡出)
    +-- weight:      用户设置的固定或动画化权重

AnimateLimbIK: finalWeight = clipWeight * weight
    +-- 同上
```

### 5.3 TransformRefPosition / TransformRefPositionRotation 处理

**TransformRefPosition** (AnimateLookAtIK.targetPosition):
- get_value() -- 返回 Vector3 位置
- get_space() -- 返回空间类型 (世界空间/局部空间/演员空间等)
- get_useAnimation() -- 返回是否启用动画化参数

**TransformRefPositionRotation** (AnimateLimbIK.IKTarget):
- get_position() -- 返回 Vector3 位置
- get_rotation() -- 返回 Vector3 欧拉角旋转
- get_space() -- 返回空间类型
- get_useAnimation() -- 返回是否启用动画化参数

**空间转换**:
```
TransformPosition(vector3, space) -> Vector3 (世界空间)
TransformRotation(vector3, space) -> Quaternion (世界空间)
```

---

## 6. 前置条件

### 6.1 Animator Controller 要求

```csharp
// 文档原文:
// "Please note that the Animator needs to have a Controller assigned
//  and 'IK Pass' must be enabled in that Controller."
```

**设置步骤**:
1. 为 actor GameObject 添加 Animator 组件
2. 为 Animator 分配一个 Animator Controller 资源
3. 在 Animator Controller 中, 至少一个 Layer 的 IK Pass 复选框必须勾选

如果不满足此条件, OnAnimatorIK 永远不会被 Unity 调用, IK 剪辑将无效果.

### 6.2 Animator 引用解析

两个剪辑都继承自 ActorActionClip<Animator>, 因此:
- actor 属性 -- 返回 Timeline 绑定到的 Animator 组件实例
- 如果 actor 为 null, OnAnimatorIK 方法直接跳出不执行任何操作

---

## 7. 总结

| 特性 | AnimateLookAtIK | AnimateLimbIK |
|------|----------------|---------------|
| IK 类型 | 注视 (LookAt) | 肢体 (Limb/IK Goal) |
| 目标参数 | TransformRefPosition (位置) | TransformRefPositionRotation (位置+旋转) |
| 权重参数 | weight, bodyWeight, headWeight, eyesWeight | weight |
| 目标选择 | 固定位置引用 | AvatarIKGoal 枚举 |
| 关键 Unity API | SetLookAtPosition, SetLookAtWeight | SetIKPosition, SetIKRotation, SetIKPositionWeight, SetIKRotationWeight |
| 事件注册 | AnimatorDispatcher.onAnimatorIK | AnimatorDispatcher.onAnimatorIK |
| 淡入/淡出 | blendIn / blendOut (继承) | blendIn / blendOut (继承) |
| 空间转换 | TransformPosition | TransformPosition + TransformRotation |
| 使用场景 | 过场中角色注视某点 | 过场中手/脚 IK 目标定位 |
