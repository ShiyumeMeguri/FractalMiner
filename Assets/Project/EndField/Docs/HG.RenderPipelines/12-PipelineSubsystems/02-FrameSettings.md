# FrameSettings + ScalableSetting 质量配置系统 — 实现原理蓝图

> **定位**：HG.RenderPipelines 中**"这台相机/这个 reflection probe 在这一帧到底开哪些渲染特性、用哪个质量档位"** 的总开关层。
> 它由两条彼此正交的子系统咬合而成：
> 1. **FrameSettings 位掩码覆盖系统** — 用一颗 `BitArray128` 把上百个渲染开关压成 128 bit，用 "default ⊕ override ⊕ sanitize" 三层合成出本帧最终生效的 bool 集合；
> 2. **ScalableSetting<T> 质量档位系统** — 用 schema 约定的 N 档(Low/Medium/High[/Ultra]) 值表 + 每个使用点带 `useOverride` 的 `ScalableSettingValue<T>`，把"按机型/帧设置选档"的逻辑挪到序列化阶段，避免每帧分支。
>
> **原理依据**：本文每一条算法/数据流/常量都可溯源到 ① **HDRP 同源代码**（HG 几乎逐字 fork 自 HDRP 7.x — `…\com.unity.render-pipelines.high-definition@75de48326bcd\Runtime\RenderPipeline\Settings\…`，cite 文件:行）；② **HG 反编译 C#/反汇编 call 图**（cite 文件名 + `call` 目标）；③ HG 由 `RuntimeQuality` 层把 `SettingParameter<T>` 写回 ScalableSetting 与 FrameSettings 的 delta（cite `SettingConfigChange.cs` 与 `HGSettingParameters.cs`）。
> 反编译方法体已被 IL2CPP 掏空成 x86 stub，逻辑结论来自 HDRP 同源源码 + HG 字段/枚举/属性/调用图重建，**HG 反编译只提供结构与常量证据**。
>
> 交叉引用：运行时质量决策 / 设备评分 / Thermal 反馈见 [`../06-RuntimeQuality/01-RuntimeQuality.md`](../06-RuntimeQuality/01-RuntimeQuality.md)。本子系统是其 `OverrideFeatureTier` 的**落点底座** — RuntimeQuality 决定"档位是几"，FrameSettings/ScalableSetting 决定"档位是几这件事**怎么变成本帧的 bool/int/float**"。

---

## 目录

1. [系统解决的问题与最终视觉效果](#1-系统解决的问题与最终视觉效果)
2. [核心数据结构 — 三个数学量](#2-核心数据结构--三个数学量)
3. [FrameSettings 三层合成算法（default → override → sanitize）](#3-framesettings-三层合成算法default--override--sanitize)
4. [HG 删减后的 FrameSettingsField 位图](#4-hg-删减后的-framesettingsfield-位图)
5. [ScalableSetting<T> + ScalableSettingValue<T> 档位评估](#5-scalablesettingt--scalablesettingvaluet-档位评估)
6. [Migration / Versionable — 旧 ObsoleteFrameSettings → 新位图的迁移流水线](#6-migration--versionable--旧-obsoleteframesettings--新位图的迁移流水线)
7. [HG delta — SettingParameter ↔ RuntimeQuality 反向回写通道](#7-hg-delta--settingparameter--runtimequality-反向回写通道)
8. [每帧时序与数据流](#8-每帧时序与数据流)
9. [1:1 复刻蓝图](#9-11-复刻蓝图)
10. [支撑证据 — 文件清单与字段对照](#10-支撑证据--文件清单与字段对照)

---

## 1. 系统解决的问题与最终视觉效果

渲染管线中有 **N 个特性**（阴影、SSR、SSAO、Volumetric、Decal、MotionVector、Bloom、ColorGrading …），每个又有 **K 档质量**（Low / Medium / High / Ultra）。如果在每个 RenderGraph pass 入口写一堆 `if (asset.supportSSR && additionalData.customSSR && qualitySettings.bloom != Off)`，代码会被分支爆掉、也无法被 reflection probe / 实时探针 / 主相机分别精细控制。

HDRP 的解法（HG 直接 fork）是把这两个维度拆开：

| 维度 | 数据结构 | 决策时刻 |
| ---- | -------- | -------- |
| **某特性"是否启用"** | `FrameSettings.bitDatas: BitArray128` + `FrameSettingsOverrideMask.mask: BitArray128` | 每相机每帧由 `AggregateFrameSettings` 合成一次 |
| **某特性"多少质量档"** | `ScalableSetting<T>: T[K]` + `ScalableSettingValue<T>{ override, useOverride, level }` | 序列化/编辑期，使用点只做一次 `[level]` 数组索引 |

最终视觉效果：**同一台 GPU 跑同一个场景，主相机可以全特性满档、烘焙反射探针自动关掉 post-process 与 SSR、运行时反射探针只开几个最便宜的特性、Editor Preview 相机几乎所有 boolean 都强制关——所有这些都不需要在每个 pass 里写 `if`，而是由本子系统把 128 bit 已经"算好"地交给后面所有 pass 直接 `IsEnabled(field)` 查询**。

---

## 2. 核心数据结构 — 三个数学量

### 2.1 BitArray128 — 128 位的渲染开关向量

HDRP `FrameSettings` 内嵌一个 `BitArray128 bitDatas`，结构是两个 `ulong`（128 bit），每个 bit 对应一个 `FrameSettingsField` 的枚举值。`IsEnabled(field) = bitDatas[(uint)field]`，O(1) 位提取。

HG 1:1 保留：`FrameSettings.cs:88` `[SerializeField] private BitArray128 bitDatas;`，反汇编 `IsEnabled` (`FrameSettings.cs:275–331`) 干干净净就是：

```asm
mov rdx,[rbx+8]      ; 取高 64 位 ulong
mov ecx,edi
and ecx,3Fh          ; field & 0x3F = 在某个 64-bit half 内的位偏移
mov eax,1
shl rax,cl           ; mask = 1ULL << (field & 63)
cmp edi,40h
jae short loc_…      ; field >= 64 → 用 bitDatas[1] 测，否则用 bitDatas[0]
test [rbx],rax       ;  TEST 低 64 位
```

— 这就是 HDRP `BitArray128 this[uint index] => (index < 64 ? (data1 & (1UL << index)) : (data2 & (1UL << (index-64)))) != 0;` 的 1:1 IL2CPP 翻译。**128 bit 是硬上限**（HDRP `FrameSettings.cs:429` 注释明示「only 128 booleans saved」），到顶就要换 `BitArray256`。HG 由于已经把字段从 ~96 个砍到 20 个（见 §4），128 bit 远未用满。

### 2.2 FrameSettingsOverrideMask — 同型 128 bit 掩码

`FrameSettingsOverrideMask.cs:13` 就一个字段 `public BitArray128 mask;`。**bit i = 1 ⇒ "本相机的 customFrameSettings 强制覆盖第 i 个 field 的默认值"**。这是把"override 哪些位"和"override 的值是多少"解耦的标准做法——HDRP `FrameSettings.cs:435–442` 1:1。

### 2.3 ScalableSetting<T> — 按档位索引的数组

```csharp
[Serializable]
public class ScalableSetting<T> : ISerializationCallbackReceiver {
    [SerializeField] private T[] m_Values;                    // m_Values[level] = 该档位的值
    [SerializeField] private ScalableSettingSchemaId m_SchemaId;
    public T this[int index] => m_Values != null && index >= 0 && index < m_Values.Length ? m_Values[index] : default;
}
```

HDRP `ScalableSetting.cs:16–45` 1:1。HG 同名同布局（`ScalableSetting.cs:6–34`），但反编译方法体被 IL2CPP 抽空，`this[int]` stub 返回 `default(T)`；序列化回调里的 `Array.Resize(ref m_Values, schema.levelCount)` 仍能从反汇编看到对 `System.Array::Resize` 的 call（`ScalableSetting.cs:147`）——**这是关键保护：反序列化时把数组长度强制对齐到 schema 的档位数，避免运行期越界**。

伴生 `ScalableSettingValue<T>` 是**使用点**的对偶：

```csharp
[Serializable]
public class ScalableSettingValue<T> {
    [SerializeField] private T   m_Override;   // 用户给的固定值
    [SerializeField] private bool m_UseOverride; // 是否忽略 schema 选档
    [SerializeField] private int  m_Level;       // useOverride==false 时取 source[m_Level]
    public T Value(ScalableSetting<T> source);  // 见 §5
}
```

`ScalableSettingValue.cs` 的反汇编 `Value(source)`（行 74–112）正好对应 HDRP 7.x 的：

```csharp
public T Value(ScalableSetting<T> source)
    => m_UseOverride || source == null ? m_Override : source[m_Level];
```

x86 上看就是 `cmp byte ptr [rcx+11h],0`（测 `m_UseOverride`），非零或 `source==null` 时直接 `mov al,[rcx+10h]` 回 `m_Override`；否则 `mov edx,[rcx+14h]` 取 `m_Level`，调 `ScalableSetting`1::get_Item`。**0 分支、0 GC、单次数组索引**，这是为什么这个系统能放在 hot path 上的根本原因。

---

## 3. FrameSettings 三层合成算法（default → override → sanitize）

### 3.1 算法骨架

每相机每帧由 `FrameSettings.AggregateFrameSettings` 调度，**三步**：

```
aggregated  ←  defaultFrameSettings                  (按相机类型选 3 套默认之一)
             |
             ↓  if additionalData.customRenderingSettings
             |
aggregated  ←  Override(aggregated, customSettings,  (位掩码合成,见 §3.3)
                       customOverrideMask)
             |
             ↓
aggregated  ←  Sanitize(aggregated, camera, supportedFeatures)  (硬件/管线能力裁剪,见 §3.4)
             |
             ↓
        最终生效的 FrameSettings (整帧只读)
```

HDRP 真值：`FrameSettings.cs:815–821`：

```csharp
internal static void AggregateFrameSettings(ref FrameSettings aggregatedFrameSettings, Camera camera,
    HDAdditionalCameraData additionalData, ref FrameSettings defaultFrameSettings, RenderPipelineSettings supportedFeatures)
{
    aggregatedFrameSettings = defaultFrameSettings;
    if (additionalData != null && additionalData.customRenderingSettings)
        Override(ref aggregatedFrameSettings, additionalData.renderingPathCustomFrameSettings, additionalData.renderingPathCustomFrameSettingsOverrideMask);
    Sanitize(ref aggregatedFrameSettings, camera, supportedFeatures);
}
```

HG `FrameSettings.cs:967–1080`（`AggregateFrameSettings(ref, Camera, HGAdditionalCameraData, ref, in RenderPipelineSettings)` `[IDTag(0)]`）的反汇编 1:1 复现了这段流程：

```asm
;; 反汇编节选(行 996-1000): aggregated = defaultFrameSettings  -- 用 SSE 移动整个 24 字节(bitDatas 16B + materialQuality 4B + pad)
movups xmm1,[rbp]         ; bitDatas low 64
movsd  xmm0,qword ptr [rbp+10h] ; materialQuality
movups [rbx],xmm1
movsd  qword ptr [rbx+10h],xmm0

;; 行 1010-1027: 如果 additionalData != null && hasCustomFrameSettings → 跳过到 Sanitize
;; (HG 把 customRenderingSettings 判断收进了 hasCustomFrameSettings)
cmp qword ptr [rsi+10h],0  ; additionalData.frameSettings 域
…

;; 行 1029-1033: 直接调 Sanitize
mov  r8,[rsp+0A0h]
mov  rdx,rdi               ; camera
mov  rcx,rbx               ; ref aggregated
call HG.Rendering.Runtime.FrameSettings::Sanitize
```

**关键 delta**：HG 的 `[IDTag(1)]` 重载（行 753–965 `AggregateFrameSettings(..., HGRenderPipelineAsset hgrpAsset)`）多一步——它先**从 `HGRenderPipelineGlobalSettings.instance` 拿到该相机类型对应的全局默认 FrameSettings**（call 链：`HGRenderPipelineGlobalSettings::get_instance → GetDefaultFrameSettings(renderType)`，行 797–818）。HDRP 把这一步交给 `RenderingPathFrameSettings.GetDefaultFrameSettings(type)`（`RenderingPathFrameSettings.cs:36–49`），HG 把它收进了全局 `HGRenderPipelineGlobalSettings` 单例——**这是 HG 把 HDRP 7.x 的 "asset-内嵌默认" 升级为 "全局 GraphicsSettings 默认" 的标志性 delta**，也跟 HDRP 后续版本（GraphicsSettings.TryGetRenderPipelineSettings<RenderingPathFrameSettings>，见 HDRP `FrameSettingsHistory.cs:69–71`）的演化方向吻合。

### 3.2 三套默认 — 按渲染类型分桶

HG `FrameSettingsRenderType.cs:3–8` 1:1 复刻 HDRP 定义：

| 枚举值                     | 数值 | 用途                                                 |
| -------------------------- | ---- | ---------------------------------------------------- |
| `Camera`                   | 0    | 主相机 / SceneView / Preview                         |
| `CustomOrBakedReflection`  | 1    | 烘焙反射探针 + 用户手动触发的 custom render          |
| `RealtimeReflection`       | 2    | 实时反射探针（每帧重新渲染）                          |

每套默认在 HG `FrameSettings.cs` 里都有一个静态工厂 `NewDefaultCamera()` / `NewDefaultRealtimeReflectionProbe()` / `NewDefaultCustomOrBakeReflectionProbe()`（行 132–273）。反汇编里看得很清楚——它们都遵循同一模式：

```asm
;; 例: NewDefaultCamera() (行 132-179)
mov  edx,12h                          ; bit 数组初始长度(18 个 uint = 18 × 32 = 576 个 bit 位置,只用前 128)
call il2cpp_vm_array_new_specific     ; new uint[18]
mov  rdx,[Il2CppFieldDefinition[Name=77A2EB46…SizeSize=72]]  ; ★ 18 × 4 = 72 字节的静态种子数据
call System.Runtime.CompilerServices.RuntimeHelpers::InitializeArray
…
call UnityEngine.Rendering.BitArray128::.ctor                ; 用种子建 BitArray128
```

`StaticArrayInitTypeSize` 字段的 **72 / 40 / 48 字节**正好对应三个不同长度的静态种子—— `Camera = 72B (18 × uint, 给 128 bit 留余量)`、`RealtimeReflection = 40B (10 × uint)`、`CustomOrBakeReflection = 48B (12 × uint)`。**这些 hash 化的字段名是 IL2CPP metadata 里冻结的静态初值表**——反过来说就是 HG 跟 HDRP 一样**把默认开关集合 hard-code 成了静态数组**，运行时只是把它喂给 `BitArray128::.ctor`。

> HDRP 7.x 同源真值（`FrameSettingsDefaults.Get(type)` 在更早的版本中以 `FrameSettings.defaultCamera` 静态字段实现，HDRP 当前版本拆到了 `Runtime/Settings/FrameSettingsDefaults.cs`；两者算法等价：**预先把 default 的 bit 集合写死，开发时改默认值要重新算这个静态种子数组**）。

### 3.3 Override — 位掩码合成

HDRP `FrameSettings.cs:622–652`：

```csharp
internal static void Override(ref FrameSettings overriddenFrameSettings,
                              FrameSettings overridingFrameSettings,
                              FrameSettingsOverrideMask frameSettingsOverideMask)
{
    // ① 一行搞定 128 个 boolean override
    overriddenFrameSettings.bitDatas =
        (overridingFrameSettings.bitDatas & frameSettingsOverideMask.mask)        // 掩码位上取 override 值
      | (~frameSettingsOverideMask.mask & overriddenFrameSettings.bitDatas);      // 非掩码位上保留默认

    // ② 对每个 "非 boolean" 字段（sssQualityMode/lodBias/materialQuality/msaaMode/…）单独 if-check
    if (frameSettingsOverideMask.mask[(uint)FrameSettingsField.SssQualityMode]) … = overridingFrameSettings.sssQualityMode;
    if (frameSettingsOverideMask.mask[(uint)FrameSettingsField.LODBias])       … = overridingFrameSettings.lodBias;
    …
}
```

核心是 **`result = (override & mask) | (default & ~mask)`** — 经典「bitwise mux」恒等式，每个 bit 独立地选「override 还是默认」。

HG `FrameSettings.cs:378–470` 的反汇编**逐字复现这条公式**：

```asm
;; rdi = ref overridden, rbx = overriding, rsi = ref mask
;; 行 397-415: 算 ~mask
mov  rcx,[rsi]            ; mask.data1
mov  rax,[rsi+8]          ; mask.data2
not  rcx                  ; ~mask.data1  → [rbp-9]
not  rax                  ; ~mask.data2  → [rbp-1]

;; 行 416-423: BitArray128.op_BitwiseAnd  →  overriding & mask
call UnityEngine.Rendering.BitArray128::op_BitwiseAnd  ; (overriding & mask) → [rbp+37h]

;; 行 423-430: BitArray128.op_BitwiseAnd  →  default & ~mask
call UnityEngine.Rendering.BitArray128::op_BitwiseAnd  ; (default & ~mask)   → [rbp+27h]

;; 行 430-433: BitArray128.op_BitwiseOr   →  OR 两者
call UnityEngine.Rendering.BitArray128::op_BitwiseOr   ; ((override & mask) | (~mask & default))
movups xmm0,[rax]
movdqu [rdi],xmm0          ; 写回 overridden.bitDatas

;; 行 431-439: 唯一一个非 boolean override —— materialQuality (offset +0x10)
test byte ptr [rsi+8],4    ; ★ 测掩码 bit 66 ≈ FrameSettingsField.MaterialQualityLevel = 66
jbe short loc_…            ; 没 set → 跳过
movsd  xmm1,qword ptr [rbx+10h]   ; copy materialQuality
mov    eax,[rbp+47h]
mov    [rdi+10h],eax
```

**HG 的关键 delta：非 boolean 字段从 HDRP 的 12 个（sss × 4 + lod × 6 + materialQuality + msaaMode）缩减到了 1 个 — 只剩 `materialQuality`**。所有 sss/lod/msaa 的"override 数值通道"都被砍掉，因为 HG 把那些参数挪到了 `SettingParameter<T>`（见 §7）和 `ScalableSettingValue<T>`，FrameSettings 不再承载它们。

### 3.4 Sanitize — 用 HDRP 能力位裁剪不合法的开关

HDRP `Sanitize`（`FrameSettings.cs:658–789`）的核心思想是 **「只要某 bit 的依赖（硬件 / asset 能力 / 上层 bit）不满足，就用 AND-clear 把它强制清 0」**。典型几条：

```csharp
sanitizedFrameSettings.bitDatas[(uint)Shadowmask] &= renderPipelineSettings.supportShadowMask && notPreview;
sanitizedFrameSettings.bitDatas[(uint)SSR]        &= renderPipelineSettings.supportSSR && !msaa && notPreview && temporalAccumulationAllowed;
sanitizedFrameSettings.bitDatas[(uint)Volumetrics] &= renderPipelineSettings.supportVolumetrics && atmosphericScattering;
sanitizedFrameSettings.bitDatas[(uint)Decals]     &= renderPipelineSettings.supportDecals && notPreview;
sanitizedFrameSettings.bitDatas[(uint)Postprocess] &= !reflection && notPreview;
```

设计动因：**asset 不支持的特性、preview / reflection probe 上不该跑的特性、MSAA 下与之冲突的特性，全部 AND-清 0**——这样后面所有 pass 只用看 bit、不用再判 asset 能力。

HG 1:1 fork 了这个流程。HG `FrameSettings.cs:472–751` `Sanitize` 反汇编显示同样的"逐字段 `bts rax,N` / `test rax,…` / `mov dl,1`"序列——每一条 `bts/test/mov` 就对应一个 sanitize 规则。摘录证据片段（行 588–622）：

```asm
xor  cl,cl
mov  rax,[r14]                 ; aggregated.bitDatas.data1
bts  rax,0                     ; bit 0 = LitShaderMode (HG 名同 HDRP)
test rax,sub_100000            ; 0x100000 ≈ 测 ShaderLitMode 在 ObsoleteFrameSettingsOverrides 中的位
…
bts  rax,14h                   ; bit 20 = ShadowMaps
test rax,sub_200000
…
bts  rax,15h                   ; bit 21 = CharacterShadowMaps (HG 独有)
test rax,sub_800000
…
bts  rax,17h                   ; bit 23 = CapsuleShadow (HG 独有, 占了 HDRP SSR 的 23 位)
test rax,sub_400000
…
bts  rax,16h                   ; bit 22 = Shadowmask
…
bts  rax,1Eh                   ; bit 30 = LightLayers
test rax,8000h                 ; 0x8000 = msaa-related check
mov  dl,1
test sil,sil                   ; sil = reflection?
jne …                          ; reflection → skip
test cl,cl                     ; cl   = preview?
jne …                          ; preview   → skip
```

**关键 HG delta（结合 §4 的字段表交叉验证）**：

1. **CharacterShadowMaps (bit 21) 与 CapsuleShadow (bit 23) 是 HG 新增**——`bit 21` 在 HDRP 是 `ContactShadows`，在 HG 是 `CharacterShadowMaps`；`bit 23` 在 HDRP 是 `SSR`，在 HG 是 `CapsuleShadow`。**这两个是 HG 把"自家角色专属阴影体系"（角色定制阴影图 + 胶囊阴影近似）提到了 FrameSettings 一级开关**——见 [`../07-Shadow ASM`] 的 `HGCapsuleShadows.cs` / 角色阴影 manager。
2. **HG 抹掉了 HDRP 的 LightShaderMode 自由切换**：HDRP 在此处会按 `supportedLitShaderMode` 三选一（Forward/Deferred/Both），HG `FrameSettingsField.LitShaderMode` 字段名虽然 1:1，但反汇编只看到对 bit 0 的简单 `bts/test`，**没有 HDRP 那段 `switch (renderPipelineSettings.supportedLitShaderMode)`**——HG 走的是固定 Lit shader 路径（实际由 OnePass deferred 主导，见 `WaterOnePassDeferredRenderingPass.cs` 等命名），无需运行时切换。
3. **HG 砍掉了 RayTracing/RaytracingVFX/MSAA/Refraction/Distortion/MotionVectors/ObjectMotionVectors/Volumetrics/ReprojectionForVolumetrics/AdaptiveProbeVolume/VirtualTexturing 等十几条 sanitize 路径**——这些 bit 已经不在 HG `FrameSettingsField` 枚举里（§4），sanitize 里自然就没有对应的 `bts/test`。

---

## 4. HG 删减后的 FrameSettingsField 位图

HDRP 7.x `FrameSettingsField` 有 ~95 个 enum 成员（`FrameSettings.cs:107–430`），分四组 `group ∈ {0,1,2,3}`：Rendering / Lighting / Async Compute / Light Loop。

HG `FrameSettingsField.cs` **只保留 20 个**——15 个 group 0（Rendering）+ 5 个 group 1（Lighting）+ 0 个 group 2/3（验证：`grep "FrameSettingsField\(0,"` = 15、`grep "FrameSettingsField\(1,"` = 5、group 2/3 = 0）。**完整 HG 枚举表（按位序）**：

| Bit | HG 字段                          | HDRP 同名? | 备注                                                                    |
| --- | -------------------------------- | ---------- | ----------------------------------------------------------------------- |
| 0   | `LitShaderMode`                  | ✅         | 留作类型展示，实际 HG 不再做 deferred/forward 切换                       |
| 1   | `DepthPrepassWithDeferredRendering` | ✅         | 依赖 LitShaderMode                                                      |
| 2   | `OpaqueObjects`                  | ✅         | 默认 on                                                                 |
| 3   | `TransparentObjects`             | ✅         | 默认 on                                                                 |
| 8   | `TransparentPrepass`             | ✅         | 依赖 TransparentObjects                                                 |
| 9   | `TransparentPostpass`            | ✅         | 依赖 TransparentObjects                                                 |
| 12  | `Decals`                         | ✅         |                                                                         |
| 13  | `Refraction`                     | ✅         | 依赖 TransparentObjects                                                 |
| 15  | `Postprocess`                    | ✅         |                                                                         |
| 18  | `LowResTransparent`              | ✅         |                                                                         |
| 20  | `ShadowMaps`                     | ✅         | group 1                                                                 |
| **21**  | **`CharacterShadowMaps`**     | ❌ **HG 新增** | HDRP 此 bit 是 `ContactShadows` — HG 砍了 ContactShadows，把它替换为角色阴影开关 |
| 22  | `Shadowmask`                     | ✅         | group 1                                                                 |
| **23**  | **`CapsuleShadow`**           | ❌ **HG 新增** | HDRP 此 bit 是 `SSR` — HG 把 SSR 从 FrameSettings 拿走（挪到 `SettingParameter`），换上胶囊阴影开关 |
| 30  | `LightLayers`                    | ✅         | group 1                                                                 |
| 66  | `MaterialQualityLevel`           | ✅         | 非 boolean，Override 阶段单独处理（见 §3.3）                            |
| 84  | `Bloom`                          | ✅         | 依赖 Postprocess                                                        |
| 87  | `Vignette`                       | ✅         | 依赖 Postprocess                                                        |
| 88  | `ColorGrading`                   | ✅         | 依赖 Postprocess                                                        |
| 93  | `Tonemapping`                    | ✅         | 依赖 Postprocess                                                        |

**HG 砍掉了的关键 HDRP bit（不完全列表，均挪到 `SettingParameter<T>` 或 `HGShadowConfig` 等专用 config）**：

`MSAAMode`、`AlphaToMask`、`Water/WaterDecals/WaterExclusion`、`ComputeThickness`、`DecalLayers`、`RenderingLayerMaskBuffer`、`RayTracing/RaytracingVFX`、`CustomPass/VariableRateShading`、`VirtualTexturing`、`HighQualityLineRendering`、`AsymmetricProjection`、`ScreenCoordOverride`、`MotionVectors/ObjectMotionVectors/TransparentsWriteMotionVector`、`Distortion/RoughDistortion`、`CustomPostProcess/StopNaN/DepthOfField/MotionBlur/PaniniProjection/LensFlareScreenSpace/LensFlareDataDriven/LensDistortion/ChromaticAberration/FilmGrain/Dithering/Antialiasing`、`AfterPostprocess/ZTestAfterPostProcessTAA`、`LODBiasMode/LODBias/LODBiasQualityLevel/MaximumLODLevel*`、`SssQualityMode/SssQualityLevel/SssCustomSampleBudget/SssCustomDownsampleSteps`、`ContactShadows/ScreenSpaceShadows/SSR/TransparentSSR/SSAO/SSGI`、`SubsurfaceScattering/Transmission`、`AtmosphericScattering/Volumetrics/ReprojectionForVolumetrics`、`ExposureControl/ReflectionProbe/PlanarProbe/ReplaceDiffuseForIndirect/SkyReflection/DirectSpecularLighting`、`AdaptiveProbeVolume/NormalizeReflectionProbeWithProbeVolume`、整个 `AsyncCompute`（group 2）与 `FPTL/BigTilePrepass/ComputeLightVariants/ComputeMaterialVariants`（group 3）。

**设计动因**（结合 HG 工程结构反推）：

1. **HG 是相对收敛的渲染**——不需要让每相机自由切 Deferred/Forward、MSAA、RayTracing 这些重量级管线开关，所以这些干脆从 FrameSettings 里去掉。
2. **质量分档不放 FrameSettings**——HDRP 的 `SssQualityMode + SssQualityLevel + SssCustomSampleBudget + SssCustomDownsampleSteps` 这种"模式+档位+自定义+downsample"四件套，被 HG 替换为 `ScalableSettingValue<int> + SettingParameter<int>`（见 §5/§7）。
3. **角色专属阴影一级化**——`CharacterShadowMaps` 和 `CapsuleShadow` 提到 FrameSettings 顶级，代表 HG 在 NPR 角色管线里**把这两类阴影当作核心特性**，可以被相机/反射探针独立关闭。
4. **`FrameSettingsHistory` 仍然保留四组 foldout 名字**（"Rendering" / "Lighting" / "Async Compute" / "Light Loop"，见 HG `FrameSettingsHistory.cs:` 静态构造里的 il2cpp 元数据字符串）——但 group 2/3 实际为空。这是 fork 残留，不是设计意图。

---

## 5. ScalableSetting<T> + ScalableSettingValue<T> 档位评估

### 5.1 数学模型

设档位集合 `L = {0, 1, …, K-1}`（K 由 schema 决定），对每个被分档的特性维护：

- **配置侧（资产里）**：`ScalableSetting<T> s` 包含 `s.m_Values[0..K-1]`，第 i 档的值 = `s[i]`；
- **使用侧（component 里）**：`ScalableSettingValue<T> v` 包含 `(v.m_Override, v.m_UseOverride, v.m_Level)`。

求值规则：

```
Value(v, s) = v.m_UseOverride || s == null
              ? v.m_Override
              : s[v.m_Level]
```

— HDRP `ScalableSettingValue.cs` 同源，HG `ScalableSettingValue.cs:74–112` 反汇编 1:1。

### 5.2 Schema — 用 levelNames 决定档位数

HDRP `ScalableSettingSchema.cs:19–29` 1:1：

```csharp
internal static readonly Dictionary<ScalableSettingSchemaId, ScalableSettingSchema> Schemas =
    new Dictionary<ScalableSettingSchemaId, ScalableSettingSchema> {
        { ScalableSettingSchemaId.With3Levels,
          new ScalableSettingSchema(new[] {
              new GUIContent("Low"), new GUIContent("Medium"), new GUIContent("High") }) },
        { ScalableSettingSchemaId.With4Levels,
          new ScalableSettingSchema(new[] {
              new GUIContent("Low"), new GUIContent("Medium"),
              new GUIContent("High"), new GUIContent("Ultra") }) },
    };
public int levelCount => levelNames.Length;
```

HG `ScalableSettingSchema.cs:7–13` 与 `ScalableSettingSchemaId.cs:10–12` 1:1（同一对静态 ID — `With3Levels` / `With4Levels`），反汇编 `GetSchemaOrNull` 就是字典 `TryGetValue`（行 18–69）。

### 5.3 序列化时锁档位数 — 让 m_Values.Length 永远等于 schema.levelCount

HDRP `ScalableSetting.cs:73–90`：

```csharp
void ISerializationCallbackReceiver.OnAfterDeserialize() {
    if (ScalableSettingSchema.Schemas.TryGetValue(m_SchemaId, out var schema))
        Array.Resize(ref m_Values, schema.levelCount);   // 强制 m_Values.Length = K
    else if (m_Values == null)
        m_Values = new T[0];
}
```

HG 反汇编（`ScalableSetting.cs:89–151`）**完整复刻**：先 `Dictionary`2<ScalableSettingSchemaId, Object>::TryGetValue` 拿 schema，再 `System.Array::Resize(ref m_Values, levelCount)`。这一步是**数学上的不变式**——保证 `[level]` 索引永远在 `[0, K-1]` 范围内。

### 5.4 多发使用点的特化版本

HG 提供四种已序列化的具体版本（HDRP 同名 1:1）：

| HG 类                       | 等价于                          |
| --------------------------- | ------------------------------- |
| `BoolScalableSetting`       | `ScalableSetting<bool>`         |
| `IntScalableSetting`        | `ScalableSetting<int>`          |
| `UintScalableSetting`       | `ScalableSetting<uint>`         |
| `FloatScalableSetting`      | `ScalableSetting<float>`        |
| `BoolScalableSettingValue`  | `ScalableSettingValue<bool>`    |
| `IntScalableSettingValue`   | `ScalableSettingValue<int>`     |
| `UintScalableSettingValue`  | `ScalableSettingValue<uint>`    |
| `FloatScalableSettingValue` | `ScalableSettingValue<float>`   |

仅仅是 Unity 序列化要求显式具体类型，不能直接序列化 `ScalableSetting<float>`，故 HDRP / HG 都把四种基本类型做了空壳子类。

---

## 6. Migration / Versionable — 旧 ObsoleteFrameSettings → 新位图的迁移流水线

### 6.1 框架

```csharp
public interface IVersionable<TVersion> where TVersion : struct, IConvertible {
    TVersion version { get; set; }
}

public struct MigrationStep<TVersion, TTarget> : IEquatable<MigrationStep<TVersion, TTarget>>
    where TTarget : class, IVersionable<TVersion> {
    public readonly TVersion Version;
    private readonly Action<TTarget> m_MigrationAction;
    public void Migrate(TTarget target);
}

public struct MigrationDescription<TVersion, TTarget> {
    private readonly MigrationStep<TVersion, TTarget>[] Steps;  // 按 version 升序
    public bool Migrate(TTarget target);     // 依次跑 step.Version > target.version 的每一步
    public void ExecuteStep(TTarget target, TVersion stepVersion);
}
```

HG 1:1 复刻 HDRP 的 `Migration*` 框架（`MigrationStep.cs:38–202`、`MigrationDescription.cs:56–386`），反汇编里能清楚看到：

- `MigrationStep<,>` 是 16 字节 struct（`m_MigrationAction: Action<TTarget>` 8B + `Version: TVersion` 4B + 4B pad）；构造时 `mov [rcx+8],edx; mov [rcx],r8`（行 47–49）。
- `MigrationStep.Migrate(target)`（行 54–161）的核心：**只有当 `step.Version > target.version` 时才执行 `m_MigrationAction(target)`，跑完把 `target.version = step.Version`**——反汇编里行 113–116 的 `mov ecx,[rbx]; cmp [rax],ecx; jge …`（如果 step.version 已经 ≤ target.version 就跳过）和行 145–151 的 `set_version(step.Version)` 完美对应这条语义。
- `MigrationDescription.<ctor>` 构造时**用 `System.Array::Sort` 按 version 排序**（反汇编 `MigrationDescription.cs:152–157`，`System.Comparison`1<MigrationStep`2<…>>::.ctor + System.Array::Sort`）——保证迁移按版本号单调增加方向执行。
- `MigrationDescription.Migrate(target)`（行 179–237）调一次 `target.version`，然后调 `MigrationDescription`2::Equals` 比对最新 step 是否等于当前版本——等于则直接返回 false（无需迁移）。

### 6.2 ObsoleteFrameSettings → 新 FrameSettings 迁移

`ObsoleteFrameSettings.cs:10–68` 是 HG 旧版本的 FrameSettings（所有特性都是普通 `bool enable*`，再加一个 `[Flags] ObsoleteFrameSettingsOverrides` 32-bit 标志位决定哪些字段是 override）。`ObsoleteFrameSettingsOverrides.cs:5–40` 列出了 26 个 flag bit（`Shadow=1, ContactShadow=2, ShadowMask=4, SSR=8, SSAO=16, …VolumeVoxelizationsAsync=int.MinValue`）。

`FrameSettings.MigrateFromClassVersion`（HG `FrameSettings.cs:1340–…`）就是这条迁移规则——把每个 `obsoleteFrameSettings.enableXxx + overrides.HasFlag(Xxx)` 投影到新的 `(bitDatas[Xxx] = enableXxx, mask[Xxx] = overrides.HasFlag(Xxx))`。这是 fork HDRP 同名迁移函数的产物，**让一份 HDRP/HG 老资产经 Unity 反序列化后被自动重写成新位图格式**。

`FrameSettingsHistory.cs:11` 的 `internal struct FrameSettingsHistory` 持有四份 snapshot：`overridden` / `customMask` / `sanitazed` / `debug`，对应 HDRP 的同名结构（HDRP `FrameSettingsHistory.cs:85–89`）——**这是为 DebugMenu/Inspector 提供"显示当前相机本帧的三层合成中间结果"的承载**，不参与运行时逻辑。

---

## 7. HG delta — SettingParameter ↔ RuntimeQuality 反向回写通道

这是 HG 相对 HDRP 最大的架构 delta，也是最值得 1:1 重建的部分。

### 7.1 SettingParameter<T> — 带"是否被代码 override"标志的参数包装

```csharp
public class SettingParameter<T> : HGRenderPipelineSettingHub.SettingParameterBase {
    public T paramValue { get; set; }   // 当前生效值
    public T defaultValue { get; set; } // 工厂默认
    internal static SettingParameter<T> Create(T defaultVal, string featureName, string paramName);
    public void Override(T val);
    public bool IsOverrided();
    public bool IsFromCode();
    internal override bool OverrideWithString(string valueString);  // 反射 + Convert.ChangeType
    public static implicit operator T(SettingParameter<T> p);       // 隐式取值
}
```

反汇编（`SettingParameter.cs:79–290`）显示几个关键事实：

- **`Create(defaultVal, featureName, paramName)` 是工厂**（行 79–108），由 `HGRenderPipelineSettingHub` 接管参数注册，这样 RuntimeQuality 可以**按 featureName 找到所有相关 SettingParameter 并批量 override**。
- **`paramValue` 偏移在 +0x28，`defaultValue` 偏移在 +0x29**——反汇编 `<implicit operator T>`（行 392–428）取的是 `[rbx+28h]`；这是**每个 SettingParameter 一个字节存 boolean 值**的紧凑布局（用于绝大多数 `SettingParameter<bool>`）；非 bool 类型实际使用泛型字段偏移会按 IL2CPP 装箱规则布置，但 hot path 的隐式转换永远是单次内存读。
- **`OverrideWithString(valueString)`**（行 347–390）：调 `Convert.ChangeType(valueString, typeof(T), InvariantCulture)` → 写回 `paramValue` → `MarkFeatureDirty(feature)`。这条路径让 Console 命令、ScriptableObject 配置、运行时 JSON 都能用同一套机制改值。**MarkFeatureDirty 是触发 §7.3 联动的关键**。
- **`RefreshInternal`**（行 292–344）：从某个数据源（应为 RuntimeQuality 的 `featureTier` 表，因为 `get_basicInfo` 是这条 call 链的下游 hook）读出当前 tier 对应的字符串值，调 `ChangeParamValue`。**这把"RuntimeQuality 算出来的 tier → 数值"的转换收敛在了 SettingParameter 内部**，调用方永远只接触 `T paramValue`。

### 7.2 HGSettingParameters — 全局参数注册表

`HGSettingParameters.cs` 是个**纯属性面板**——它就是一个公共属性集合，按特性分组：

- TAAU/DLSS/FSR3/PSSR upscaler 参数 30+ 项；
- Bloom/DOF/MotionBlur/Vignette/ChromaticAberration/Sharpen/FrostedGlass/LensFlare/AnamorphicStreaks 等后处理质量；
- CSM 阴影（splitCount/split0..3/cachedFrame0..3/screenSizeMin0..3/enableOcclusionCulling0..3）×4 cascade 全套；
- 角色阴影、Punctual Light Shadow、ASM、Visibility SH、Contact Shadow、GTAO、SSR、Fake Planar、Reflection Probe；
- Texture Streaming（按 6/8/10/12/16 GB 内存分桶的 `textureQualityNGB`）；
- Water/Foliage/Terrain/Volumetric Cloud/Light Shaft/Atmosphere/Erosion/Rain & Wetness/Snow/Ink 等子系统的子 `*SettingParameters`；
- 帧插值 / DLSS-G / Reflex / AFME / MFRC fallback threshold。

特别注意几个 const 字符串（`HGSettingParameters.cs:10–74`）—— `ECS_FEATURE_NAME` / `TAAU_FEATURE_NAME` / `PSSR_FEATURE_NAME` / `DLSS_FEATURE_NAME` / `DLSSG_FEATURE_NAME` / `FSR3_FEATURE_NAME` / `PP_FEATURE_NAME` / `ASTREAKS_FEATURE_NAME` / `LIGHTING_FEATURE_NAME` / `SSR_FEATURE_NAME` / `FAKE_PR_FEATURE_NAME` / `SHADOWMAP_FEATURE_NAME` / `VISIBILITY_SH_FEATURE_NAME` / `RT_SETTING_NAME` / `TEXTURE_STREAMING_SETTING_NAME` / `TEXTURE_QUALITY_SETTING_NAME` / `CONTACT_SHADOW_FEATURE_NAME` / `GTAO_FEATURE_NAME` / `MISC_NAME` / `GRASS_NAME` / `TERRAIN_NAME` / `WATER_NAME` / `FOLIAGE_NAME` / `ART_TAGS_NAME` / `ONE_PASS_FEATURE_NAME` / `REFLECTION_PROBE_TAGS_NAME` / `TRANSPARENT_NAME` / `CHROMATIC_ABERRATION_TRACING_NAME` / `RAY_TRACING_NAME` / `FRAME_INTERPOLATION_NAME` / `AFME_THRESHOLD_NAME` / `MFRC_THRESHOLD_NAME` / `INK_NAME`。

**每个 string 都是一个 feature key**——RuntimeQuality 用它定位「这次 device tier 变化要把哪一票 SettingParameter 改掉」。HDRP 没有这一套字符串总线，这是 HG 完全自研的 delta。

### 7.3 SettingConfigChange — 数据驱动的"配置变更事件"枚举

```csharp
internal enum SettingConfigChange {
    DeviceTypeChange   = 0,   // 设备类型变了（如冷热切换 / 平台切换）
    SettingTierChange  = 1,   // 整体设置档(用户在选项里拉档)变了
    FeatureTierChange  = 2,   // 单个特性档位变了
    FeatureTierReset   = 3,   // 单个特性被 reset 回默认档
    Count              = 4,
}
internal struct SettingConfigChangeData {
    internal HGDeviceType deviceType;
    internal int          settingTier;
    internal string       featureName;
}
internal interface ISettingDataProcessLayer {
    SettingDataProcessResult ProcessSettingDataChange(
        SettingConfigChange input,
        ref SettingConfigChangeData newConfigData,
        ref SettingConfigChangeData oldConfigData);
}
public enum SettingDataProcessResult { Succeed = 0, DataBlocked = 1, Count = 2 }
```

— 这是一条**责任链 (Chain-of-Responsibility) 模式**：当用户/RuntimeQuality 调用 `HGRenderPipelineSettingHub.OverrideFeatureTier(featureName, tier, immediate)`，hub 会构造 `SettingConfigChangeData newConfig{featureName, tier}` 和 `oldConfig`，**遍历所有注册的 `ISettingDataProcessLayer`**，每一层可以：

- 返回 `Succeed` → 继续传给下一层；
- 返回 `DataBlocked` → **拦截本次变更**（例如 "Thermal critical 状态下不允许把档拉满"）。

只有所有 layer 都 `Succeed` 后，hub 才真正把 `paramValue` 改掉、`MarkFeatureDirty`，触发该 feature 下所有 SettingParameter 的 `RefreshInternal`，最终该 feature 的下次 `Render` 调用就用新值了。

### 7.4 与 FrameSettings 的关系

**SettingParameter 不直接写 FrameSettings.bitDatas**——它写的是各个**子系统的 config / 渲染器 / SettingParameters 集合**（如 `HGShadowConfig`、`HGCharacterQualitySettings`、`HGTerrainConfiguration`）。**FrameSettings 只承载那 20 个 boolean 一级开关**，更细颗粒的「SSR 是开启状态下用几轮 ray-marching」这种参数走 `SettingParameter<int>`。

这套架构上的二分让 HG 的"开/关"和"开多大力"完全解耦：

- 主相机 vs 反射探针 → 用 FrameSettingsOverrideMask 切换 ON/OFF；
- 6GB vs 16GB 手机 → 用 RuntimeQuality 切换 SettingParameter 的 paramValue；
- 用户在选项里拖动 SSR 档位 → 触发 `FeatureTierChange` → SSR 相关 SettingParameter 走 `RefreshInternal` → 下一帧 SSR pass 看到新参数。

---

## 8. 每帧时序与数据流

```
                              ┌──────────────────────────────────────────────────┐
                              │  开机一次性                                       │
                              │  HGRenderPipelineGlobalSettings.instance        │
                              │  ├─ 三套 defaultFrameSettings (静态种子数组)     │
                              │  │  (NewDefaultCamera / RealtimeRef / BakedRef) │
                              │  ├─ ScalableSetting<T>.OnAfterDeserialize       │
                              │  │  → Array.Resize(values, schema.levelCount)   │
                              │  └─ HGSettingParameters 初始化所有              │
                              │     SettingParameter.Create(default, feature, name) │
                              └──────────────────────────────────────────────────┘
                                              │
                                              ▼
              ┌─────── RuntimeQuality 决策（设备分档 / Thermal / 用户选项） ───┐
              │  QualityManager.MatchQuality() → tier                          │
              │  HGRenderPipelineSettingHub.OverrideFeatureTier(featureName, tier, immediate)
              │  → 构造 SettingConfigChangeData {featureName, settingTier=tier}
              │  → 遍历 ISettingDataProcessLayer：ProcessSettingDataChange     │
              │  → 全部 Succeed ⇒ SettingParameter.RefreshInternal             │
              │  → ChangeParamValue(stringFromTierTable, markOverrided=true)   │
              └────────────────────────────────────────────────────────────────┘
                                              │
                                              ▼     (paramValue 写入,但 FrameSettings 不变)
                                              │
                          每相机每帧 BeginCameraRendering:
                                              │
                                              ▼
              ┌───────────── AggregateFrameSettings(camera, additional, hgrpAsset) ─────────────┐
              │  ① renderType = additional?.defaultFrameSettings ?? Camera                       │
              │  ② default = HGRenderPipelineGlobalSettings.GetDefaultFrameSettings(renderType)  │
              │  ③ aggregated = default                                                          │
              │  ④ if additional.hasCustomFrameSettings:                                         │
              │       Override(ref aggregated, additional.customFrameSettings, customMask)       │
              │       — 公式: bitDatas = (override & mask) | (~mask & default)                   │
              │       — 单独处理: materialQuality                                                │
              │  ⑤ Sanitize(ref aggregated, camera, hgrpAsset.currentPlatformSettings)           │
              │       — 按 reflection / preview / msaa / asset 能力 AND-清各 bit                 │
              │       — HG 大量裁剪后,只剩 ~10 条 sanitize 规则                                  │
              └─────────────────────────────────────────────────────────────────────────────────┘
                                              │
                                              ▼
                          aggregatedFrameSettings (整帧只读, 存在 HGCameraData / 等价容器)
                                              │
              ┌───────────────────────────────┴─────────────────────────────────┐
              ▼                                                                 ▼
   各 RenderingPass 入口直接查:                                  各 Manager/Renderer 在自己的 SettingParameters
       frameSettings.IsEnabled(FrameSettingsField.Postprocess)       上做 implicit operator T 取值:
       → 等价于 bitDatas[15]                                          if (config.bloomEnabled) { ... }
                                                                      int q = config.gtaoQualityLevel; // implicit
              ▼                                                                 ▼
       决定 pass 是否注册到 RenderGraph                             用 paramValue 决定 dispatch 大小 /
                                                                    sample 数 / shader keyword
```

**关键节奏**：

- **每帧只跑一次** `AggregateFrameSettings`（成本：3 次 `BitArray128` 按位运算 + ~10 条 sanitize AND-clear，纯 IL 算术，~纳秒级）；
- **`IsEnabled(field)` 是 O(1) 位操作**——在反汇编里是 `mov rdx,[rbx+(0/8)]; shl; test`，没有任何 branch / 函数调用；
- **`SettingParameter<T>` 取值是 implicit operator T**——1 次内存读（`movzx eax,byte ptr [rbx+28h]`），不分配；
- **RuntimeQuality 改 tier 是稀疏事件**（用户拖档/Thermal 切档/进新场景）——它不在 hot path，可以慢；事件结束后所有 SettingParameter 的 `paramValue` 已经是新值，hot path 仍然单次读。

---

## 9. 1:1 复刻蓝图

要从零重建本子系统，按下列顺序：

### 9.1 第一步：核心数据结构

1. 实现 `BitArray128`（两个 `ulong` + `this[uint]` 位提取 + `&` `|` `~` `==`）。可直接复用 `UnityEngine.Rendering.BitArray128`（HG 也是直接用 Unity 内置的）。
2. 定义 `enum FrameSettingsField : int`——**用户自定义位序**（每个特性给一个 < 128 的 unique bit；保留 0 给 `LitShaderMode`，bit 数推荐按 HG 的位序 1:1 抄，以便加载老资产）。
3. 定义 `struct FrameSettings { BitArray128 bitDatas; MaterialQuality materialQuality; … }` + `struct FrameSettingsOverrideMask { BitArray128 mask; }`。
4. 定义 `FrameSettingsRenderType { Camera=0, CustomOrBakedReflection=1, RealtimeReflection=2 }`。

### 9.2 第二步：三套默认 + Override + Sanitize

5. 给每个 `FrameSettingsRenderType` 写一个工厂 `NewDefault*()`——把那些 **默认 on** 的 bit（`OpaqueObjects`/`TransparentObjects`/`ShadowMaps`/`Postprocess`/`Bloom`/`ColorGrading`/`Tonemapping` 之类）在静态数组里设 1。把数组作为 IL2CPP 静态初值嵌入二进制（C# 端写成 `new uint[18] {…}` 即可）。
6. 实现 `static void Override(ref FrameSettings r, FrameSettings o, FrameSettingsOverrideMask m)`：

   ```csharp
   r.bitDatas = (o.bitDatas & m.mask) | (~m.mask & r.bitDatas);
   if (m.mask[(uint)FrameSettingsField.MaterialQualityLevel]) r.materialQuality = o.materialQuality;
   ```

7. 实现 `static void Sanitize(ref FrameSettings s, Camera cam, in RenderPipelineSettings rpSettings)`——按相机类型（reflection/preview）和 asset 能力，**AND-清**所有不应启用的 bit。HG 实际只剩 ~10 条规则，按 §3.4 的列表 1:1 抄。
8. 实现 `static void AggregateFrameSettings(ref FrameSettings aggregated, Camera, HGAdditionalCameraData, HGRenderPipelineAsset)`：
   - `renderType = additional?.defaultFrameSettings ?? Camera`；
   - `aggregated = HGRenderPipelineGlobalSettings.instance.GetDefaultFrameSettings(renderType)`；
   - 若 `additional.hasCustomFrameSettings` → `Override`；
   - `Sanitize`。

### 9.3 第三步：ScalableSetting + ScalableSettingValue

9. 定义 `class ScalableSettingSchema { public readonly GUIContent[] levelNames; public int levelCount => levelNames.Length; }`，加静态字典 `Schemas[With3Levels] / [With4Levels]`。
10. 实现 `ScalableSetting<T> : ISerializationCallbackReceiver`：`T[] m_Values + ScalableSettingSchemaId m_SchemaId + this[int] => m_Values?[index] ?? default`，序列化回调里 `Array.Resize(ref m_Values, schema.levelCount)`。
11. 实现 `ScalableSettingValue<T>`：`m_Override + m_UseOverride + m_Level + T Value(ScalableSetting<T> s) => m_UseOverride || s == null ? m_Override : s[m_Level]`。
12. 派生四种具体类型：`BoolScalableSetting/Value`、`IntScalableSetting/Value`、`UintScalableSetting/Value`、`FloatScalableSetting/Value`——仅为 Unity 序列化要求。

### 9.4 第四步：Migration 框架

13. 实现 `IVersionable<TVersion>` / `MigrationStep<TVersion, TTarget>` / `MigrationDescription<TVersion, TTarget>`，关键：构造时按 `Version` `Array.Sort`，`Migrate(target)` 遍历执行 `step.Version > target.version` 的每一步并把 `target.version` 推进到 `step.Version`。
14. 给 `FrameSettings` 写 `MigrateFromClassVersion(ref ObsoleteFrameSettings old, ref FrameSettings @new, ref FrameSettingsOverrideMask newMask)`——把旧 `enableXxx + overrides.HasFlag(Xxx)` 一对一映射到新 `(bitDatas[Xxx], mask[Xxx])`。

### 9.5 第五步：SettingParameter + Hub

15. 定义 `enum SettingConfigChange { DeviceTypeChange, SettingTierChange, FeatureTierChange, FeatureTierReset, Count }` + `struct SettingConfigChangeData { HGDeviceType deviceType; int settingTier; string featureName; }` + `interface ISettingDataProcessLayer`。
16. 实现 `class SettingParameter<T> : SettingParameterBase`：
    - `paramValue` / `defaultValue` 自动属性；
    - `Create(default, feature, name)` 工厂：注册到 `HGRenderPipelineSettingHub` 的 `(feature → List<SettingParameter>)` 表；
    - `OverrideWithString(string)`：`Convert.ChangeType(s, typeof(T), InvariantCulture)` → 写 `paramValue` → `MarkFeatureDirty`；
    - `RefreshInternal()`：从 hub 的 tier 表读串值 → `ChangeParamValue(str, markOverrided: true)`；
    - `implicit operator T(SettingParameter<T> p) => p.paramValue;`
17. 实现 `HGRenderPipelineSettingHub.OverrideFeatureTier(featureName, tier, immediate)`：
    - 构造 `new SettingConfigChangeData`；
    - 遍历 `ISettingDataProcessLayer` 链调 `ProcessSettingDataChange(FeatureTierChange, ref newCfg, ref oldCfg)`；
    - 若全 `Succeed` → 对该 feature 下所有 SettingParameter 调 `RefreshInternal`；
    - 若 immediate ⇒ 不等下一帧直接 invoke pass。
18. 实现 `HGSettingParameters`——为每个特性声明 `SettingParameter<T>` 字段，构造里调 `SettingParameter<T>.Create(default, FEATURE_NAME, paramName)`。

### 9.6 与其他单元的接口

| 出口                                        | 消费方                                  |
| ------------------------------------------- | --------------------------------------- |
| `FrameSettings.IsEnabled(field)` (本帧只读) | RenderGraph pass 注册条件               |
| `FrameSettings.materialQuality`             | Material 选 keyword                     |
| `SettingParameter<T>.paramValue`            | 各 Manager / Renderer / shader uniform   |
| `ScalableSettingValue<T>.Value(source)`     | 编辑器期 + 资产加载期的最终值取出         |

| 入口                                        | 生产方                                  |
| ------------------------------------------- | --------------------------------------- |
| `HGRenderPipelineGlobalSettings` 三套默认   | 工程师在 ProjectSettings 配置            |
| `HGAdditionalCameraData.customFrameSettings`+ mask | 美术在 Camera Inspector 配置          |
| `HGRenderPipelineSettingHub.OverrideFeatureTier` | RuntimeQuality (`QualityManager`) / Console / Console 命令 / 用户选项 UI |

### 9.7 难点

1. **128 bit 上限**——未来若特性数超过 128，必须切到 `BitArray256` 并改全部位运算函数签名。HG 现在用 20 位，远未触及。
2. **Sanitize 的依赖顺序**——A 依赖 B 时，要先算 B 再算 A；HDRP 7.x 的源码是按精心设计的顺序排的，1:1 抄就行，**不要重排**。
3. **Migration 必须不可逆**——一旦把 `target.version` 推进，旧 step 不会再跑；如果某 step 改 bit 出了错就只能新加 step 修复，不能回滚。
4. **`SettingParameter.Override("string")` 的反射开销**——只在 Console / 选项变更时用，不能进 hot path。
5. **`ScalableSetting.OnAfterDeserialize` 的 `Array.Resize` 会破坏现有数据**——schema.levelCount 变化时一定要写迁移代码迁移老资产的 `m_Values`。

---

## 10. 支撑证据 — 文件清单与字段对照

### 10.1 本单元 34 文件职责（HG 反编译）

| 文件                                    | 类型      | 职责                                                                                       |
| --------------------------------------- | --------- | ------------------------------------------------------------------------------------------ |
| `FrameSettings.cs`                      | struct    | 128 bit 渲染开关集合 + materialQuality；`Override` `Sanitize` `AggregateFrameSettings` `MigrateFromClassVersion` 全在这里 |
| `FrameSettingsField.cs`                 | enum      | 20 个 HG 保留的渲染特性位序                                                                |
| `FrameSettingsFieldAttribute.cs`        | attribute | UI/Inspector 元数据：group/orderInGroup/targetType/displayedName/tooltip/dependencies/indentLevel |
| `FrameSettingsOverrideMask.cs`          | struct    | 与 FrameSettings 同构的 128 bit 掩码                                                       |
| `FrameSettingsRenderType.cs`            | enum      | 三套默认的索引：Camera / CustomOrBakedReflection / RealtimeReflection                       |
| `FrameSettingsHistory.cs`               | struct    | DebugMenu/Inspector 用：保存 overridden / customMask / sanitazed / debug 四份 snapshot + 四组 foldout 名 |
| `IFrameSettingsHistoryContainer.cs`     | interface | 让相机 component 暴露自己的 history 给 DebugMenu                                            |
| `ObsoleteFrameSettings.cs`              | class     | 旧版本 FrameSettings（每特性一个 bool + 一个 Flags 标 override）。`[Obsolete]` 仅用于迁移   |
| `ObsoleteFrameSettingsOverrides.cs`     | enum      | 旧 override 标志位（32-bit）                                                                |
| `ScalableSetting.cs`                    | generic   | `T[K]` + schema 的档位数组；序列化锁档位数                                                  |
| `ScalableSettingSchema.cs`              | class     | levelNames + levelCount；静态 `Schemas` 字典                                                |
| `ScalableSettingSchemaId.cs`            | struct    | string-backed ID；预定义 `With3Levels` / `With4Levels`                                      |
| `ScalableSettingValue.cs`               | generic   | 使用点参数：`override`/`useOverride`/`level` + `Value(source)` 求值                          |
| `BoolScalableSetting.cs`                | class     | `ScalableSetting<bool>` 序列化特化                                                          |
| `BoolScalableSettingValue.cs`           | class     | `ScalableSettingValue<bool>` 序列化特化                                                     |
| `IntScalableSetting.cs`                 | class     | `ScalableSetting<int>` 序列化特化                                                           |
| `IntScalableSettingValue.cs`            | class     | `ScalableSettingValue<int>` 序列化特化                                                      |
| `FloatScalableSetting.cs`               | class     | `ScalableSetting<float>` 序列化特化                                                         |
| `FloatScalableSettingValue.cs`          | class     | `ScalableSettingValue<float>` 序列化特化                                                    |
| `UintScalableSetting.cs`                | class     | `ScalableSetting<uint>` 序列化特化                                                          |
| `UintScalableSettingValue.cs`           | class     | `ScalableSettingValue<uint>` 序列化特化                                                     |
| `IVersionable.cs`                       | interface | `TVersion version { get; set; }`                                                            |
| `MigrationDescription.cs`               | generic   | `MigrationStep[]` 排序集合 + `Migrate(target)` 迭代器                                       |
| `MigrationStep.cs`                      | generic   | `(Version, Action<TTarget>)` 元组 + `Migrate(target)` 单步执行 + 版本推进                   |
| `SettingParameter.cs`                   | generic   | `paramValue/defaultValue` + `Override/OverrideWithString/RefreshInternal/implicit operator T` |
| `SettingConfigChange.cs`                | enum      | 4 种配置变更事件类型                                                                       |
| `SettingConfigChangeData.cs`            | struct    | `deviceType + settingTier + featureName`                                                    |
| `SettingDataProcessResult.cs`           | enum      | `Succeed / DataBlocked`                                                                     |
| `ISettingDataProcessLayer.cs`           | interface | 责任链 layer 接口                                                                          |
| `HGSettingParameters.cs`                | class     | 全局参数注册表 — 把所有 feature 的 SettingParameter 集中暴露 + 33 个 feature key 字符串      |
| `HGLightShaftSettingParameters.cs`      | class     | 体积光照 LightShaft 子系统的 4 个 SettingParameter                                          |
| `HGVerticalOcclusionMapSettingParameters.cs` | class | 垂直遮挡图子系统的 2 个 SettingParameter                                                    |
| `OtherSettings.cs`                      | VolumeComponent | VolumeStack 入口（FakePlanarReflection 等杂项）— 不直接属于 FrameSettings，但同包打住    |
| `OptionalSystemFeatures.cs`             | struct    | 可选系统特性的 nullable 包装 (`SceneRTFeature?` / `GPUEventFeature?`)                       |

### 10.2 FrameSettings 关键字节布局（HG）

| Offset | 大小 | 字段                | 备注                                                                |
| ------ | ---- | ------------------- | ------------------------------------------------------------------- |
| 0x00   | 8B   | `bitDatas.data1`    | bit 0–63                                                            |
| 0x08   | 8B   | `bitDatas.data2`    | bit 64–127 — `MaterialQualityLevel=66, Bloom=84, …, Tonemapping=93` 都在这里 |
| 0x10   | 4B   | `materialQuality`   | enum MaterialQuality                                                |
| 0x14   | 4B   | (pad)               |                                                                     |

— 反汇编（行 396–410）的 `movups [rdi], xmm0; movsd [rdi+10h], xmm0` 模式确认 FrameSettings 是 24 字节 struct，按 `(xmm 16B bitDatas) + (movsd 8B materialQuality+pad)` 整体拷贝。

### 10.3 ScalableSettingValue<T> 关键字节布局（HG）

| Offset | 大小 | 字段              | 备注              |
| ------ | ---- | ----------------- | ----------------- |
| 0x10   | 1B   | `m_Override`      | T = bool 时 1B    |
| 0x11   | 1B   | `m_UseOverride`   |                   |
| 0x14   | 4B   | `m_Level`         |                   |

— 反汇编 `useOverride.get` (`ScalableSettingValue.cs:41`) `movzx eax,byte ptr [rcx+11h]`、`level.get` (行 23) `mov eax,[rcx+14h]`、`Value(source)` (行 74–112) 一致。

### 10.4 SettingParameter<bool> 关键字节布局（HG）

| Offset | 大小 | 字段                                  |
| ------ | ---- | ------------------------------------- |
| 0x00   | 0x28 | `SettingParameterBase` 基类字段        |
| 0x28   | 1B   | `paramValue` (bool 特化)              |
| 0x29   | 1B   | `defaultValue` (bool 特化)            |

— 反汇编 `implicit operator T(p)`（行 415）`movzx eax,byte ptr [rbx+28h]`、构造 `mov [rbx+28h],dil; mov [rbx+29h],dil`（行 64–71）一致。

### 10.5 HDRP 同源行号引用

| HG 行为                                | HDRP 同源 (`com.unity.render-pipelines.high-definition@75de48326bcd\Runtime\…`)                          |
| -------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `FrameSettings.bitDatas` 128 bit       | `RenderPipeline\Settings\FrameSettings.cs:454-455`                                                       |
| `FrameSettings.Override` 公式          | `RenderPipeline\Settings\FrameSettings.cs:622-652`                                                       |
| `FrameSettings.Sanitize` 模板          | `RenderPipeline\Settings\FrameSettings.cs:658-789`                                                       |
| `FrameSettings.AggregateFrameSettings` | `RenderPipeline\Settings\FrameSettings.cs:815-821`                                                       |
| `FrameSettingsField` 枚举              | `RenderPipeline\Settings\FrameSettings.cs:107-430` (HDRP) ⇄ HG `FrameSettingsField.cs:5-45`              |
| `FrameSettingsOverrideMask`            | `RenderPipeline\Settings\FrameSettings.cs:435-442`                                                       |
| `FrameSettingsRenderType`              | `Runtime\Settings\RenderingPathFrameSettings.cs` (重新声明) + HDRP `FrameSettingsHistory.cs:11-19`        |
| `FrameSettingsHistory` 字段            | HDRP `Runtime\RenderPipeline\Settings\FrameSettingsHistory.cs:85-89`                                    |
| `RenderingPathFrameSettings` 三套默认  | HDRP `Runtime\Settings\RenderingPathFrameSettings.cs:28-49`                                              |
| `ScalableSetting<T>` 数据流            | HDRP `RenderPipeline\Settings\ScalableSetting.cs:16-91`                                                  |
| `ScalableSettingSchema` 字典           | HDRP `RenderPipeline\Settings\ScalableSettingSchema.cs:19-29`                                            |
| `ScalableSettingValue<T>` (HG 自带, HDRP 等价) | HDRP `RenderPipeline\Settings\ScalableSettingValue.cs`（同源算法 `useOverride ? @override : source[level]`）|
| `SettingParameter` / `SettingConfigChange` 这条线 | **HDRP 没有** — 全部为 HG 自研（见 §7）                                                       |

### 10.6 待确认（仅限 HG 特化 + 反编译方法体掏空导致的细节）

1. `HGRenderPipelineSettingHub.OverrideFeatureTier` 的完整 `ISettingDataProcessLayer` 责任链顺序与具体 layer 实现（DeviceType layer / Thermal layer / User Option layer 之类）**不在本单元文件内**，需结合 `06-RuntimeQuality` 与 `HGRenderPipelineSettingHub.cs`（不在本单元 cell）共同确认。
2. `FrameSettingsHistory` 反汇编里把 foldout 数组写死成 4 项 `"Rendering"/"Lighting"/"Async Compute"/"Light Loop"`——HG 字段枚举里 group=2/3 为空，**foldout 字符串是否在 UI 端被实际渲染**取决于 Editor 端的 `FrameSettingsUI.Drawer`，运行时不可见。
3. HG 三套默认 `NewDefault*` 的精确 bit-set 来自 IL2CPP 静态种子（`StaticArrayInitTypeSize` 72/40/48 字节）。**这些字节的具体内容**需要从已 build 的可执行文件二进制段提取，反编译 C# 只能确认数组长度。
