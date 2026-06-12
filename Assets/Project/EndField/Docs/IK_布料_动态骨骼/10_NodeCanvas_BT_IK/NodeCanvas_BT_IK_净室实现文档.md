# NodeCanvas Behavior Tree IK 净室实现文档

## 文档信息

| 项目 | 内容 |
|------|------|
| 分析对象 | NodeCanvas Tasks (MecanimSetIK / MecanimSetLookAt) |
| 基础 API | Unity Animator IK Pass (OnAnimatorIK) |
| 事件派发器 | ParadoxNotion.Services.EventRouter |
| 命名空间 | NodeCanvas.Tasks.Actions |
| 适用场景 | Behavior Tree 中设置角色 IK 的 Action 节点 |

---

## 1. 类定义

### 1.1 MecanimSetIK

**类签名**: `public class MecanimSetIK : ActionTask<Animator>`

```
ActionTask<T>                          -- NodeCanvas 基类 (泛型, T = Animator)
  +-- MecanimSetIK                    -- 设置肢体 IK 的 BT Action
```

**特性**:
- `[Name("Set IK", 0)]`
- `[Category("Animator")]`

**字段**:

| 字段 | 类型 | 可见性 | 说明 |
|------|------|--------|------|
| IKGoal | AvatarIKGoal | public | IK 目标肢体 (LeftHand/RightHand/LeftFoot/RightFoot) |
| goal | BBParameter<GameObject> | [RequiredField] public | 目标 GameObject (Blackboard 参数) |
| weight | BBParameter<float> | public | IK 权重 (Blackboard 参数) |

**属性**:

| 属性 | 类型 | 说明 |
|------|------|------|
| info | string (override) | 节点显示信息 |

### 1.2 MecanimSetLookAt

**类签名**: `public class MecanimSetLookAt : ActionTask<Animator>`

```
ActionTask<T>                          -- NodeCanvas 基类 (泛型, T = Animator)
  +-- MecanimSetLookAt                -- 设置注视 IK 的 BT Action
```

**特性**:
- `[Name("Set Look At", 0)]`
- `[Category("Animator")]`

**字段**:

| 字段 | 类型 | 可见性 | 说明 |
|------|------|--------|------|
| targetPosition | BBParameter<GameObject> | public | 注视目标 GameObject (Blackboard 参数) |
| targetWeight | BBParameter<float> | public | 注视权重 (Blackboard 参数) |

**属性**:

| 属性 | 类型 | 说明 |
|------|------|------|
| info | string (override) | 节点显示信息 |

---

## 2. EventRouter 事件派发器

**类签名**: `public class EventRouter : MonoBehaviour`

**命名空间**: `ParadoxNotion.Services`

### 2.1 onAnimatorIK 事件

EventRouter 是一个多功能事件路由组件, 挂载在 agent (Animator 所在的 GameObject) 上. 它提供了 `onAnimatorIK` 事件:

```csharp
public event EventDelegate<int> onAnimatorIK;

// 其中 EventDelegate<T> 定义为:
public delegate void EventDelegate<T>(EventData<T> msg);
```

- 事件参数: `EventData<int>` 包装, 包含 `int` 类型的 layerIndex
- EventRouter 同时实现了大量 UI 事件接口 (IPointerEnterHandler, IDragHandler 等), 但 onAnimatorIK 是独立的 C# 事件

### 2.2 路由获取

NodeCanvas 中通过 `Task.get_router()` 方法获取 EventRouter 实例:

```csharp
EventRouter router = this.get_router();  // 从 Task 基类继承的方法
// 返回挂载在 agent GameObject 上的 EventRouter 组件
```

---

## 3. 运行时机制: 事件注册与注销

### 3.1 MecanimSetIK 生命周期

```
OnExecute()
  |
  +-- router = this.get_router()                    // 获取 EventRouter
  +-- EventDelegate<int> del = new EventDelegate<int>(this.OnAnimatorIK)
  +-- router.onAnimatorIK += del                    // 订阅事件

OnStop()
  |
  +-- router = this.get_router()
  +-- router.onAnimatorIK -= del                    // 取消订阅
```

### 3.2 MecanimSetLookAt 生命周期

完全相同的模式:

```
OnExecute()
  +-- router = this.get_router()
  +-- router.onAnimatorIK += this.OnAnimatorIK

OnStop()
  +-- router.onAnimatorIK -= this.OnAnimatorIK
```

### 3.3 关键区别 (与 Slate 对比)

| 特性 | Slate (AnimatorDispatcher) | NodeCanvas (EventRouter) |
|------|---------------------------|--------------------------|
| 组件类型 | AnimatorDispatcher (Slate 专属) | EventRouter (ParadoxNotion 通用) |
| 获取方式 | GameObject.GetAddComponent<T>() | Task.get_router() |
| 事件类型 | Action<int> | EventDelegate<int> (EventData<int> 包装) |
| 注册时机 | OnEnter / OnReverseEnter | OnExecute |
| 注销时机 | OnExit / OnReverse | OnStop |
| 额外操作 | OnRootDisabled 时 DestroyImmediate | 无 (EventRouter 常驻) |

---

## 4. 关键 API 调用

### 4.1 MecanimSetIK.OnAnimatorIK(EventData<int> msg)

```
OnAnimatorIK(EventData<int> msg):
  // 1. 获取 agent (Animator)
  agent = this.get_agent()

  // 2. 获取 weight 参数
  weightValue = this.weight.get_value()             // 从 BBParameter<float> 读取

  // 3. 设置 IK 位置权重 (必须在设置位置之前或之后立即设置)
  agent.SetIKPositionWeight(IKGoal, weightValue)

  // 4. 获取目标位置
  targetObj = this.goal.get_value()                 // 从 BBParameter<GameObject> 读取
  if (targetObj != null):
      targetTransform = targetObj.get_transform()
      targetPos = targetTransform.get_position()

  // 5. 设置 IK 位置
  agent.SetIKPosition(IKGoal, targetPos)

  // 6. 结束 Action (立即成功)
  EndAction(true)
```

**对应 Unity Animator API**:
```csharp
public void SetIKPositionWeight(AvatarIKGoal goal, float weight);
public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition);
```

### 4.2 MecanimSetLookAt.OnAnimatorIK(EventData<int> msg)

```
OnAnimatorIK(EventData<int> msg):
  // 1. 获取 agent (Animator)
  agent = this.get_agent()

  // 2. 获取目标位置
  targetObj = this.targetPosition.get_value()       // 从 BBParameter<GameObject> 读取
  if (targetObj != null):
      targetTransform = targetObj.get_transform()
      targetPos = targetTransform.get_position()

  // 3. 设置注视位置
  agent.SetLookAtPosition(targetPos)

  // 4. 获取权重并设置
  weightVal = this.targetWeight.get_value()         // 从 BBParameter<float> 读取
  agent.SetLookAtWeight(weightVal)

  // 5. 结束 Action (立即成功)
  EndAction(true)
```

**对应 Unity Animator API**:
```csharp
public void SetLookAtPosition(Vector3 worldPosition);
public void SetLookAtWeight(float weight);
```

### 4.3 与 Slate API 调用的对比

| API | Slate AnimateLookAtIK | NodeCanvas MecanimSetLookAt |
|-----|----------------------|---------------------------|
| SetLookAtPosition | actor.SetLookAtPosition(worldPos) | agent.SetLookAtPosition(targetPos) |
| SetLookAtWeight | actor.SetLookAtWeight(finalW, bodyW, headW, eyesW, 0) | agent.SetLookAtWeight(weightValue) |
| SetIKPosition | actor.SetIKPosition(IKGoal, worldPos) | agent.SetIKPosition(IKGoal, targetPos) |
| SetIKPositionWeight | actor.SetIKPositionWeight(IKGoal, finalW) | agent.SetIKPositionWeight(IKGoal, weightVal) |
| SetIKRotation | actor.SetIKRotation(IKGoal, worldRot) | (不支持) |
| SetIKRotationWeight | actor.SetIKRotationWeight(IKGoal, finalW) | (不支持) |

**关键差异**:
- Slate AnimateLimbIK 同时设置位置+旋转+两者的权重 (共 4 次调用)
- NodeCanvas MecanimSetIK 仅设置位置+位置权重 (共 2 次调用), 不支持旋转控制
- Slate 使用多层权重 (clipWeight * userWeight) 并分发到 body/head/eyes
- NodeCanvas 使用单一 weight 值, 无子权重分发

---

## 5. 数据流

### 5.1 Behavior Tree -> IK 完整管线

```
[Behavior Tree 执行]
       |
       | Action 节点进入执行状态
       v
[MecanimSetIK / MecanimSetLookAt]
       |
       | OnExecute()
       v
[EventRouter] (挂载在 agent GameObject 上)
       |
       | 注册 onAnimatorIK 事件回调
       v
[Unity Animator Update]
       |
       | Animator Controller 启用 "IK Pass"
       v
[Unity 调用 OnAnimatorIK(int layerIndex)]
       |
       | EventRouter 转发事件 (包装为 EventData<int>)
       v
[MecanimSetIK.OnAnimatorIK(EventData<int> msg)]
       |
       | 从 BBParameter 读取 goal / weight
       | 从 goal.transform.position 获取目标位置
       v
[agent.SetIKPositionWeight(IKGoal, weight)]
[agent.SetIKPosition(IKGoal, targetPos)]
       |
       | Unity 内部 IK 求解
       v
[EndAction(true)]  -- Action 立即完成
       |
       v
[Animator IK Pass: 修改骨骼最终姿态]
       |
       v
[Final Pose -> SkinMeshRenderer -> 渲染]
```

### 5.2 与 Timeline IK 数据流的对比

```
[Timeline IK (Slate)]                         [Behavior Tree IK (NodeCanvas)]
       |                                              |
       | 剪辑播放期间持续驱动                            | Action 执行一次即完成
       | OnAnimatorIK 每帧回调                          | OnAnimatorIK 每帧回调
       | 权重 = clipWeight * userWeight                 | 权重 = BBParameter value
       | 持续设置 IK 直到 OnExit                        | 设置一次后 EndAction(true)
       v                                              v
```

### 5.3 BBParameter 值解析

NodeCanvas 使用 BBParameter<T> 进行黑板参数绑定:

```
BBParameter<T>.get_value():
  +-- 如果绑定到 Blackboard 变量: 返回变量的当前值
  +-- 如果未绑定 (使用默认值): 返回序列化的默认值

MecanimSetIK:
  weight.get_value()     -> float   (默认或黑板变量)
  goal.get_value()       -> GameObject (必须绑定, 标记为 RequiredField)

MecanimSetLookAt:
  targetWeight.get_value()    -> float
  targetPosition.get_value()  -> GameObject
```

---

## 6. 前置条件

### 6.1 Animator Controller 要求

与 Slate 相同, 需要:
1. agent GameObject 上必须有 Animator 组件
2. Animator 必须分配 Animator Controller
3. Controller 中至少一个 Layer 的 IK Pass 必须启用

### 6.2 EventRouter 组件

NodeCanvas 框架在 agent 上自动管理 EventRouter 组件:
- 通过 `Task.get_router()` 获取或创建
- 不同于 Slate 的 AnimatorDispatcher, EventRouter 是 ParadoxNotion 框架的通用组件
- 不需要手动销毁 (由框架管理生命周期)

### 6.3 BBParameter 绑定

- `goal` (MecanimSetIK) 标记了 `[RequiredField]`, 必须在 Blackboard 中绑定有效值
- `targetPosition` (MecanimSetLookAt) 同理, 需要绑定有效的 GameObject
- 如果目标为 null, OnAnimatorIK 跳过 IK 设置并跳转到错误处理

---

## 7. 总结

### 7.1 类对比表

| 特性 | MecanimSetIK | MecanimSetLookAt |
|------|--------------|-------------------|
| IK 类型 | 肢体 IK (IK Goal) | 注视 LookAt |
| 目标参数 | BBParameter<GameObject> (位置) | BBParameter<GameObject> (位置) |
| 权重参数 | BBParameter<float> | BBParameter<float> |
| 目标选择 | AvatarIKGoal 枚举 | 固定注视目标 |
| 关键 Unity API | SetIKPositionWeight, SetIKPosition | SetLookAtPosition, SetLookAtWeight |
| 事件注册 | EventRouter.onAnimatorIK | EventRouter.onAnimatorIK |
| Action 行为 | OnExecute -> OnAnimatorIK -> EndAction(true) | 同左 |
| 旋转控制 | 不支持 | 不适用 |

### 7.2 整体架构总结

```
Unity Animator IK Pass 机制:
============================

[Animator 组件]
  |
  |-- [Animator Controller] (必须启用 IK Pass)
  |
  |-- Unity 每帧调用 OnAnimatorIK(int layerIndex)
       |
       +-- [Slate 路径]:
       |   AnimatorDispatcher.OnAnimatorIK()
       |     -> 派发到 AnimateLookAtIK.OnAnimatorIK / AnimateLimbIK.OnAnimatorIK
       |     -> actor.SetLookAtPosition / SetIKPosition / SetIKRotation
       |     -> actor.SetLookAtWeight / SetIKPositionWeight / SetIKRotationWeight
       |
       +-- [NodeCanvas 路径]:
           EventRouter (通过 MonoBehaviour 消息)
             -> 派发到 MecanimSetIK.OnAnimatorIK / MecanimSetLookAt.OnAnimatorIK
             -> agent.SetIKPositionWeight / SetIKPosition
             -> agent.SetLookAtPosition / SetLookAtWeight
             -> EndAction(true)
```

### 7.3 设计决策要点

1. **IK Pass 依赖**: 两套系统都依赖 Unity Animator IK Pass, 这是核心前提
2. **事件桥接模式**: 都使用事件派发器 (Dispatcher/EventRouter) 桥接 Unity 消息和业务逻辑
3. **Slate 优势**: 支持完整 IK 控制 (位置+旋转)、多层权重分布、淡入淡出
4. **NodeCanvas 优势**: 与 Behavior Tree 无缝集成、BBParameter 变量绑定、轻量级
5. **运行时差异**: Slate 持续驱动 (剪辑整个持续期间), NodeCanvas 一次性设置 (OnExecute 即完成)
