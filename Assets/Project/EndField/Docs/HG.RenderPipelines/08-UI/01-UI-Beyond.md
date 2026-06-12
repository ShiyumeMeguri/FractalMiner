# 模块二：UI.Beyond 净室实现文档

**分析日期：** 2026-06-12
**模块路径：** `Assets/Project/EndField/Assets/Scripts/UI.Beyond/`
**命名空间：** `Beyond.UI`, `Beyond.UI.GPUI`
**核心定位：** 基于 Unity uGUI 深度定制的 UI 框架层。提供了一套完整的 UI 组件体系（自定义 Image、Button、Toggle、Input、Layout 等）和一个 GPU 驱动的替代 UI 渲染管线（GPUI），用于高性能 UI 渲染。

---

## 1. 架构概述

UI.Beyond 由两层构成：

1. **UI 组件层** -- 继承/替代 Unity uGUI 的 MonoBehavior 组件集合（UIButton, UIImage, UIToggle, UIDropdown, UIInputField 等），提供动画、本地化、适配、导航等增强功能。
2. **GPU 驱动 UI 层（GPUI）** -- 一个基于 GPU Instance 的 UI 渲染系统，以 `GPUISystem : MaskableGraphic` 为核心，使用 Compute Buffer 驱动大量 UI 元素的批渲染，支持 VAT 纹理动画。

框架还包含：
  - 动画系统（UIAnimationHolder, UIAnimationMixPlayer, UIAnimationTween 等）
  - 适配系统（NotchAdapter, CustomNotchAdapt, UICanvasScaleHelper）
  - 国际化（I18nFontLoader, DynamicFontAssetLoader, UILocalizeText）
  - 控制器导航（ControllerSideMenuItemList, InputBindingGroupNaviDecorator）
  - 特效组件（UIBlurRT, UIBlurMono, UIGyroscopeEffect, CinemachineGyroscopeEffect）
  - 列表系统（UIExtendScrollRect, UI3DScrollList, UIInertiaViewPager）
  - 对话框系统（UIDialogText, UIDialogTimelineText, CSPopupPanel）

---

## 2. GPUI -- GPU 驱动 UI 渲染系统

### 2.1 设计目标

GPUI 旨在替代传统 uGUI 的 CPU 驱动渲染路径，将 UI 元素的顶点处理、排序、合批迁移到 GPU 端，大幅降低 Draw Call 和 CPU 开销。

### 2.2 核心类

```
GPUISystem : MaskableGraphic
  -- GPUI 入口组件，挂在 Canvas 下的 RawImage/Graphic 上
  -- 继承自 MaskableGraphic，实现自定义绘制
  -- 维护实例列表、材质模板、VAT 纹理、Sprite 纹理
  -- 支持普通模式（GPUInstanceData）和 Lite 模式（GPUPrefabDataLite）
  -- i18n 字体加载集成
  -- 字段:
       materialTemplates (List<Material>) -- 材质模板
       configGroupName (string) -- 配置组名
       sourceCNFontId (int) -- 中文字体 ID
       noSortingOrder (bool) -- 是否禁用排序
       m_liteMode (bool) -- Lite 模式切换
       m_instancedMaterials (List<Material>) -- 实例化材质
       m_vatTexture (Texture) -- VAT 动画纹理
       m_spriteTexture (Texture) -- Sprite 纹理
       m_prefabMap (Dictionary<string, RuntimePrefabData>) -- 预制体缓存
       m_instances (List<RuntimeInstance>) -- 运行时实例列表
       m_recyclePool (Queue<int>) -- 实例回收池
       m_destroyQueue (List<KeyValuePair<float, GPUIHandle>>) -- 销毁队列
       m_simpleTextSystem (ITextSystem) -- 简易文本系统
       m_instanceBufferManager (InstanceBufferManager) -- 实例缓冲管理器
       m_prefabBufferManager (SimpleBufferManager<GPUPrefabData>) -- 预制体缓冲
       m_litePrefabBufferManager (SimpleBufferManager<GPUPrefabDataLite>) -- Lite 预制体缓冲
```

### 2.3 GPUInstanceData -- 实例数据结构

```csharp
struct GPUInstanceData
{
    float animeTime;   // 动画时间
    uint color;        // 颜色 (RGBA packed)
    Vector2 pos;       // 位置
    ushort prefabId;   // 预制体 ID
    ushort parentId;   // 父节点 ID
    ushort grandParentId; // 祖父节点 ID
    byte matType;      // 材质类型
    byte drawType;     // 绘制类型
    uint padding0;     // 填充
    uint padding1;     // 填充
}
```

### 2.4 GPUI 数据类族

```
GPUIHandle -- GPUI 实例句柄，用于外部引用 GPUI 实例
GPUPrefabData -- 预制体数据（完整）
GPUPrefabDataLite -- 预制体数据（精简版）
RuntimePrefabData -- 运行时预制体缓存
RuntimeInstance -- 运行时实例状态
RuntimeNodeInfo -- 运行时节点信息
RuntimeAnimationData -- 运行时动画数据
NodeType (enum) -- 节点类型定义
NodeMetadata -- 节点元数据
NodeSerializeData -- 节点序列化数据
PrefabSerializeData -- 预制体序列化数据
PrefabGroupSerializeData -- 预制体组序列化数据
AnimationSerializeData -- 动画序列化数据
ChangeState -- 变更状态描述
CodePoint -- 码点（文本相关）
```

### 2.5 缓冲管理

```
SimpleBufferManager<T> : 泛型简单计算缓冲管理器
  +- SimpleBufferManager<GPUPrefabData> -- 完整模式预制体缓冲
  +- SimpleBufferManager<GPUPrefabDataLite> -- Lite 模式预制体缓冲
InstanceBufferManager -- 实例缓冲管理器（管理 GPUInstanceData 缓冲）
|
ITextSystem (interface) -- 文本系统
SimpleTextSystem : ITextSystem -- 简易文本系统实现
SimpleTextAlignment -- 文本对齐枚举
```

### 2.6 渲染流程

```
GPUISystem.OnPopulateMesh(VertexHelper vh)
  -- 为 MaskableGraphic 提供网格数据
  -- 实际绘制由 Material 与 ComputeBuffer 驱动
  -- VAT 纹理（Vertex Animation Texture）用于动画播放
  -- ShaderIDs: CANVAS_OBJECT_TO_WORLD_MATRIX, VAT_TEX, MAIN_TEX, SPRITE_TEX

渲染循环：
  每帧更新 m_timeForShader
  处理 m_destroyQueue 中的到期实例
  更新 ComputeBuffer 数据
  通过 MaterialPropertyBlock 传递参数
```

---

## 3. UI 组件层

### 3.1 基础组件

| 类名 | 基类 | 说明 |
|------|------|------|
| UIButton | Button | 增强按钮，支持控制器导航、动画、事件 |
| UIImage | Image | 增强图片，支持更多填充模式、颜色组 |
| UIToggle | Toggle | 开关组件，支持分组导航 |
| UIToggleGroup | ToggleGroup | 开关组，管理互斥选择 |
| UIInputField | InputField | 输入框，支持 i18n 等 |
| UIDropdown | Dropdown | 下拉菜单 |
| UIDropdownOption | -- | 下拉菜单选项 |
| UIJoystick | -- | 虚拟摇杆 |
| UIArea | -- | 区域组件 |
| UIBigRectButton | -- | 大矩形按钮 |
| UIBigRectHelper | -- | 大矩形辅助 |
| UIBigLogo | -- | 大 Logo |
| UIScrollRect | ScrollRect | 滚动区域 |
| UIExtendScrollRect | -- | 扩展滚动区域 |
| UINonUnifiedScrollRect | -- | 非统一滚动区域 |
| UIInertiaViewPager | -- | 惯性翻页组件 |
| UIGridLayoutGroup | -- | 网格布局 |
| UIGridLayoutNaviWrapper | -- | 网格导航包装 |
| NonDrawingGraphic | Graphic | 无绘制的图形（射线靶） |
| Empty4Raycast | Graphic | 仅用作射线检测的空图形 |
| FitAspectRatioByFOV | -- | 根据 FOV 适配宽高比 |

### 3.2 图片与渲染

| 类名 | 说明 |
|------|------|
| UIBlendImage | 混合图片（支持 Blend 效果） |
| UIImageBlur | 模糊图片 |
| UIImagePair | 图片对 |
| UIImageFillFollower | 填充跟随器 |
| UIImageFillTailFollower | 填充尾部跟随器 |
| UIImageFillAmountOffset | 填充量偏移 |
| UIImageBlur | 图片模糊 |
| UILoadImageSprite | 动态加载图片 Sprite |
| UIAtlasManager | 图集管理器 |
| UIColorGroup | 颜色组管理 |
| UIGraphicAnimation | 图形动画 |

### 3.3 模糊与后处理

| 类名 | 说明 |
|------|------|
| UIBlurRT : MonoBehaviour | 基于 RawImage 的模糊 RT，支持场景颜色 PS |
| UIBlurMono | 单色模糊 |
| FullScreenSceneBlurMarker | 全屏场景模糊标记 |
| UIGyroscopeEffect | 陀螺仪特效 |
| CinemachineGyroscopeEffect | Cinemachine 陀螺仪特效 |

### 3.4 文本与国际化

| 类名 | 说明 |
|------|------|
| I18nFontLoader | i18n 字体加载器（GetCNFontId） |
| DynamicFontAssetLoader | 动态字体资源加载 |
| UILocalizeText | 本地化文本 |
| SimpleUITextSingleLine | 简易单行文本 |
| UIDialogText | 对话框文本 |
| UIDialogTextWithCursor | 带光标对话框文本 |
| UIDialogTimelineText | Timeline 对话文本 |
| UIDialogTimelineOptionCell | Timeline 对话选项 |
| UIDialogTimelineOptionCell | Timeline 对话选项 |
| UILeftSubtitle | 左侧字幕 |

### 3.5 动画系统

| 类名 | 说明 |
|------|------|
| UIAnimationHolder | 动画持有器 |
| UIAnimationTween | 动画 Tween |
| UIAnimationSwitchTween | 切换 Tween |
| UIAnimationMixPlayer | 混合播放器 |
| UIAnimationLayerMixPlayer | 层级混合播放器 |
| UIAnimationLoopSynchronizer | 循环同步器 |
| UIAnimationWrapper | 动画包装 |
| UIHighlightMask | 高亮遮罩 |
| PercentNumberTweener | 百分比数字动画 |
| TweenUtils | Tween 工具方法 |
| FadeSwitchTween | 渐隐切换 Tween |
| FadeTranslationSwitchTween | 渐隐平移切换 Tween |

### 3.6 布局与适配

| 类名 | 说明 |
|------|------|
| NotchAdapter | 刘海屏适配 |
| CustomNotchAdapt | 自定义刘海适配 |
| UICanvasScaleHelper | Canvas 缩放辅助 |
| CanvasMatchMode | Canvas 匹配模式枚举 |
| UIBigRectHelper | 大矩形适配辅助 |
| UILayoutDimensionListener | 布局尺寸监听 |
| UICustomLayout | 自定义布局 |
| UICustomLayoutElement | 自定义布局元素 |
| UICustomLayoutHandle | 自定义布局句柄 |
| ActiveSyncHelper | 激活同步辅助 |
| ActiveType | 激活类型枚举 |
| AutoScrollStrategy | 自动滚动策略 |
| ParallaxHelper | 视差辅助 |
| MouseHoverTipsPosHelper | 鼠标悬浮提示位置辅助 |
| Billboard | 广告牌组件 |
| UIElementFollower | UI 元素跟随器 |

### 3.7 对话框与弹窗

| 类名 | 说明 |
|------|------|
| CSPopupPanel | 弹窗面板 |
| UIAutoCloseArea | 自动关闭区域 |
| ToastList | Toast 列表 |
| CommonItemToastList | 通用物品 Toast |
| CommonDropHintType | 掉落提示类型 |

### 3.8 拖拽系统

| 类名 | 说明 |
|------|------|
| UIDrag | 拖拽基础 |
| UIDragHandler | 拖拽处理器 |
| UIDragItem | 可拖拽物品 |
| UIDropItem | 可放置物品的目标 |

### 3.9 控制器与导航

| 类名 | 说明 |
|------|------|
| ControllerSideMenuItemList | 控制器侧边菜单列表 |
| InputBindingGroupNaviDecorator | 输入绑定组导航装饰器 |
| NaviToThisGroupOnEnable | 启用时导航到当前组 |
| DeactivateNaviOnEnable | 启用时禁用导航 |
| UIUIFoldoutComponent | 折叠组件 |
| IUIFoldoutComp | 折叠接口 |

### 3.10 列表与滚动

| 类名 | 说明 |
|------|------|
| UIListCache | 列表缓存 |
| UI3DScrollList | 3D 滚动列表 |
| UIScrollRect | 滚动区域 |
| UIExtendScrollRect | 扩展滚动区域 |
| UINonUnifiedScrollRect | 非统一滚动区域 |
| UIInertiaViewPager | 惯性翻页 |
| UIFoldoutComponent | 折叠组件 |
| ScrollDirection | 滚动方向枚举 |

### 3.11 工具类

| 类名 | 说明 |
|------|------|
| UIConst | UI 常量 |
| UIActionKeyHint | 操作按键提示 |
| UIControllerKeyIcon | 控制器按键图标 |
| LuaUIRoot | Lua UI 根节点 |
| LuaUIRootNode | Lua UI 根节点（带节点数据） |
| LuaPanel | Lua 面板基类 |
| CustomUIStyle | 自定义 UI 样式 |
| TimelineUIBindingType | Timeline UI 绑定类型 |
| MobileMotionManager | 移动端运动管理器 |
| FixRotation | 固定旋转 |
| FingerMoveDirection | 手指移动方向 |
| EasyUIOptionData | EasyUI 选项数据 |
| DecoLineActiveHelper | 装饰线激活辅助 |
| UIDialogText | 对话框文本 |

---

## 4. 核心模式与设计特点

1. **GPUI GPU Instance 驱动渲染** -- 使用 ComputeBuffer 将 UI 实例数据（位置、颜色、动画时间、层级关系）上传到 GPU，由 Shader 直接读取并渲染，大幅降低 Draw Call。
2. **VAT 纹理动画** -- 使用 Vertex Animation Texture 驱动 UI 动画，支持大量元素的独立动画播放。
3. **双模式预制体** -- 支持完整模式（GPUPrefabData）和 Lite 模式（GPUPrefabDataLite），根据场景复杂度选择。
4. **实例回收池** -- 使用 m_recyclePool (Queue<int>) 复用销毁的实例 ID，避免频繁创建/销毁。
5. **延迟销毁队列** -- 使用 m_destroyQueue (List<KeyValuePair<float, GPUIHandle>>) 实现延迟销毁，支持渐隐等退出动画。
6. **IFix 补丁支持** -- 几乎所有方法都包含 IFix.IsPatched 检测，支持热修复。
7. **i18n 字体集成** -- 通过 I18nFontLoader 动态切换中文字体，GPUI 直接集成字体切换。
8. **Lua 可调用** -- 大量组件用于 Lua UI 框架（LuaPanel, LuaUIRoot, LuaUIRootNode）。

---

## 5. 文件清单

| 目录 | 文件数 | 说明 |
|------|-------|------|
| `Beyond/UI/` | ~100 | UI 组件层（Button, Image, Toggle, Input, Dropdown, Drag, Dialog, Layout, Animation, Blur 等） |
| `Beyond/UI/GPUI/` | 23 | GPU 驱动 UI 子系统（GPUISystem, GPUInstanceData, BufferManager, Runtime* 等） |
| `IFix/` | 4 | IFix 热修复基础设施 |
| `HG/Rendering/Runtime/` | 1 | HG 渲染运行时 |
| `Properties/` | 1 | 程序集信息 |

---

## 6. IFix 方法 ID 对照（部分）

| 方法 | 方法 ID (hex) |
|------|---------------|
| GPUISystem.fontAsset.get | 0x75F |
| GPUISystem.fontAsset.set | 0x761 |
| UIBlurRT.Reset | 0x270 |
| GameStateBase.OnEnter | 0x0A5 |
| GameStateBase.ctor | 0x31E |
| UIPanelBase.OnRelease | 0x147 |
| UIPanelBase.LoadSprite | 0x115 |
