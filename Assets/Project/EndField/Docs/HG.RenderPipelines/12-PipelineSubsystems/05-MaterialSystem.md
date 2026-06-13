# C20 · 材质系统 / GBuffer 编码 / Stencil / RenderQueue —— 实现原理蓝图

> HG.RenderPipelines 的"延迟着色基础设施"。它解决三个相互纠缠的问题：(1) 把一个 BRDF 材质的全部 surface 参数压进 3×RGBA8 的 GBuffer 并在延迟阶段无损重建（**GBuffer 编码**）；(2) 在屏幕空间标记每个像素属于哪条着色路径（StandardLit / TwoSidedFoliage / Subsurface）+ 跨 pass 的逻辑属性（角色、Decal 屏蔽、PP 屏蔽等），全部塞进 1 byte stencil（**Stencil bit 分配**）；(3) 给每个材质一个排序值以决定 DrawCall 顺序与所属 frame slot（**RenderQueue**）。
>
> 原理据 **HDRP 同源源码**（`Lit.hlsl`、`Lit.cs.hlsl`、`BaseLitAPI.cs`、`HDStencilUsage.cs`、`NormalBuffer.hlsl`，commit `75de48326bcd`）的 `文件:行` 1:1 重建，HG 反编译仅提供 attachment 配置、ID、enum 与常量。HG 是 HDRP 的重度 fork：GBuffer 数量从 4 (+VT/SSM) 砍到 **3+Depth**，stencil bit 完全重组，shading-model id 走 stencil 而非 GBuffer2.a 的 featureID。每条 delta 都给反编译出处。

---

## 目录

1. 系统定位与解决的问题
2. GBuffer 物理布局（HG vs HDRP）
3. GBuffer 编码算法（surfaceData → 3 RT）
4. GBuffer 解码算法（3 RT → BSDFData）
5. Stencil 位分配与跨 pass 协议
6. HGRenderQueue 优先级带与 frame-slot 仲裁
7. ArtTags / DeferredShadingModel / ShadingModel 路由
8. ConstantBuffer 池与 cbuffer 生命周期
9. Shader Pass / Keyword / ShaderID 命名簿
10. 1:1 复刻蓝图（分步）
11. 关键常量速查表
12. 支撑证据：本单元文件清单

---

## 1. 系统定位与解决的问题

引擎在每帧主流程中需要回答四个问题，C20 都给答案：

| 问题 | 谁来答 | 答的方式 |
|---|---|---|
| 这个像素以后用什么 BRDF 重建？ | `EncodeIntoGBuffer` + `HGDeferredShadingModel` | 3 RT + stencil 低 3 位 |
| 这个像素能不能被 SSR / decal / PP 触碰？ | `HGStencilUtils.HGStencilBitMask` | stencil 高 4 位 mask |
| 这个 DrawCall 在 frame 哪段执行（gbuffer / transparent / overlay）？ | `HGRenderQueue.Priority` + `RenderQueueType` | sortingPriority 整数带 |
| GBuffer 有几张、什么格式、什么尺寸？ | `GBufferProfileManager` + `HGRenderCapability` | 按硬件 profile 切 HighEnd / LowEnd |

形成两层结构：**几何 pass 把材质写进 GBuffer + Stencil + Depth** → **延迟光照 pass 用 Stencil mask 出哪些像素要做 SSS / decal、用 GBuffer 解出 BSDFData、跑 LightLoop**。本文件讲第一层，第二层 LightLoop 见 `../02-CoreAlgorithms/01-CoreAlgorithms.md`。

---

## 2. GBuffer 物理布局（HG vs HDRP）

### 2.1 HDRP 原版布局（基准线）

HDRP 默认 `GBUFFERMATERIAL_COUNT = 4`，外加 VT/RenderingLayers/ShadowMask 可选 slot 共最多 7 张。`Lit.hlsl:36-43`：

```
TEXTURE2D_X(_GBufferTexture0);  // baseColor.rgb + (specOcc 7 / isLightmap 1)            — RGBA8 sRGB
TEXTURE2D_X(_GBufferTexture1);  // normalWS oct (12+12) + perceptualRoughness            — RGBA8 (R 8 G 8 B 8 A 8，2D-oct 占 RG+B)
TEXTURE2D_X(_GBufferTexture2);  // 取决于 materialFeatureId（见 §3）                    — RGBA8
TEXTURE2D_X(_GBufferTexture3);  // bakeDiffuseLighting * AO + emissive                   — R11G11B10F
TEXTURE2D_X(_GBufferTexture4);  // VTFeedback / RenderingLayers / ShadowMask（可选）
TEXTURE2D_X(_GBufferTexture5);  // RenderingLayers / ShadowMask
TEXTURE2D_X(_GBufferTexture6);  // ShadowMask
```

材质特性分布在 8 个 bit（`Lit.cs.hlsl:10-17`）：

```
MATERIALFEATUREFLAGS_LIT_STANDARD              (1)
MATERIALFEATUREFLAGS_LIT_SPECULAR_COLOR        (2)
MATERIALFEATUREFLAGS_LIT_SUBSURFACE_SCATTERING (4)
MATERIALFEATUREFLAGS_LIT_TRANSMISSION          (8)
MATERIALFEATUREFLAGS_LIT_ANISOTROPY           (16)
MATERIALFEATUREFLAGS_LIT_IRIDESCENCE          (32)
MATERIALFEATUREFLAGS_LIT_CLEAR_COAT           (64)
MATERIALFEATUREFLAGS_LIT_COLORED_TRANSMISSION (128)
```

featureId 占 `outGBuffer2.a` 的低 3 bit（`Lit.hlsl:734`：`outGBuffer2.a = PackByte(encodedCoatMask | materialFeatureId)`），高 5 bit 是 PackedCoatMask。这套设计**单 RT 即可做 tile-based material classification**（`Lit.hlsl:558`：*The layout is also design to only require one RT for the material classification*）。

### 2.2 HG 实际配置（HighEnd profile）

HG 把 GBuffer 数量定死为 **3 张色彩 RT + 1 张 Depth = 4 个 attachment**（`GBufferID.cs:5-9`）：

```
internal enum GBufferID {
    GBufferA     = 0,   // 对应 HDRP GBuffer0
    GBufferB     = 1,   // 对应 HDRP GBuffer1
    GBufferC     = 2,   // 对应 HDRP GBuffer2
    GBufferDepth = 3,
    Count        = 4
}
```

**没有 GBuffer3（emissive+bakedGI）**：HG 把 emissive 与 baked-GI 在 forward-only pass 直接写进 SceneColor（lighting 之后的 add）。这是 HG 最大的 delta：HDRP 用 GBuffer3 做"延迟材质能拿到 bakedGI/emissive 的占位"，HG 在 OnePassDeferred 里靠 native subpass input 拿 SceneColor，直接省掉一个 RT。

**RT 格式与尺寸**（`GBufferProfileManager.cs:268-327` 反汇编：构造函数里两个 profile 都注册了 A/B/C 三张 RT；HighEnd profile 通过 `AddGBufferRT(GBufferA, 0x4B, ...)` 调用，`0x4B = 75 = GraphicsFormat.R8G8B8A8_UNorm` 在 `UnityEngine.Experimental.Rendering.GraphicsFormat` 枚举里对应 sRGB-aware unorm，第二个 GBufferB 同样 0x4B，第三个 GBufferC 用 0x04 = R8G8B8A8_UNorm linear；LowEnd 则用 0x08 / 0x04 即 RGBA8_SRGB / R8G8B8A8_UNorm linear）：

| Slot | HG HighEnd | HG LowEnd | HDRP 同源 | 用途 |
|---|---|---|---|---|
| GBufferA | RGBA8_SRGB（fmt 0x4B） | RGBA8_SRGB（fmt 0x08） | RGBA8 sRGB | baseColor.rgb / spec-occ 或 SSS（diffusionProfile|subsurfaceMask） |
| GBufferB | RGBA8_UNorm（fmt 0x4B） | RGBA8_UNorm（fmt 0x04） | RGBA8 | normalWS（oct, 8+8+8）+ perceptualRoughness（8） |
| GBufferC | RGBA8_UNorm（fmt 0x04） | RGBA8_UNorm（fmt 0x04） | RGBA8 | f0.rgb（Standard）或 thickness/transmission/aniso 视 shading model |
| GBufferDepth | D32_SFLOAT_S8_UINT | D24_UNORM_S8_UINT | 同 | Z + 8-bit Stencil |

LowEnd profile 在移动端把 GBufferA 的 sRGB 编码与 GBufferB 一起换成 **memoryless transient**（`GBufferProfileManager.cs:712-803` 的 `SetGBufferTextureMemoryless`：对每个 attachmentProfile 写入 `_memoryless` 字段，调用方在 OnePassDeferred 时传 `RenderTextureMemoryless.Color`），意味着 tiled-GPU 上 GBuffer 从不离开 on-chip SRAM。

`HGRenderCapability.cs:172-208` 的 `SupportNativeRenderPass()` 把 Vulkan(8)/Metal(11)/PS5/XB-Scarlett(17,2) 标记为支持 native render-pass：HG 用这个判定是否走 OnePassDeferred（geometry + lighting + compose 同一个 RP 里串成 subpass，GBuffer 不落 DRAM）。

**HG delta 总结**：
1. RT 数从 4(+3 optional) 砍到 3（去掉 GBuffer3，emissive/GI 直写 SceneColor）。`GBufferID.Count = 4` 含 Depth。
2. featureId（HDRP 占 GBuffer2.a 低 3 bit）改走 **stencil 低 3 bit**（见 §5），让 GBuffer2.a 释放出来做别的用。
3. RenderingLayers / ShadowMask 那几张 optional RT 完全不存在；rendering layers 在 HG 走全局 buffer。
4. LowEnd 启用 memoryless RT，靠 Vulkan/Metal subpass。

---

## 3. GBuffer 编码算法（surfaceData → 3 RT）

### 3.1 入口函数与签名

HDRP `Lit.hlsl:562-790` 的 `EncodeIntoGBuffer(SurfaceData surfaceData, BuiltinData builtinData, uint2 positionSS, out GBufferType0..3 outGBuffer0..3)`。HG 复用此函数但只导出 0..2（GBuffer3 不存在）。HG 的 NPR 角色 shader（`HGRP_CharacterNPR_*.shader`）有自己的 `EncodeIntoGBuffer` 重载，但走相同的 RT 分配。

### 3.2 GBuffer0 编码 — 4 种 surface 视图

**Standard / Iridescence / Anisotropy / IsLightmap-tag** 直写：

```
encodedSpecularOcclusion = PackFloatInt8bit(specOcc, isLightmap, 2);   // 2-bit isLightmap 标记（APV-L1/L2 时启用）
outGBuffer0 = float4(surfaceData.baseColor, encodedSpecularOcclusion); // RGBA8 sRGB
```
*（`Lit.hlsl:583-585, 599`；当未启用 PROBE_VOLUMES_L1/L2 时退化为 `encodedSpecularOcclusion = specOcc`）*

**Standard** 模式在 §3.4 末段把 `outGBuffer0.rgb` 改写为 `ComputeDiffuseColor(baseColor, metallic)`（保留 baseColor 的人眼可读色彩，但已扣掉 metal 的吸光），fresnel0 则编进 GBuffer2。理由：`Lit.hlsl:549-550`：*always encode fresnel0 ... avoid VGPR for the various metal combinations*。

**SSS / Transmission** 模式改写 GBuffer0.a：把 specOcc 移出，写入 `(diffusionProfileIndex<<4 | subsurfaceMask)`（4+4 bit）。这样 SSS 后处理只读 GBuffer0 一张 RT。`Lit.hlsl:621-625`：

```
SSSData sssData = ConvertSurfaceDataToSSSData(surfaceData);
EncodeIntoSSSBuffer(sssData, positionSS, outGBuffer0);   // outGBuffer0.a := PackFloatInt8bit(subsurfaceMask, diffusionProfileIndex, 16)
```

### 3.3 GBuffer1 编码 — 法线与粗糙度（octahedral 1212）

`NormalBuffer.hlsl:20-36` 是 GBuffer1 的真值源：

```
// 防 Z 接缝（octahedron 在 z=0 处会出现 BSDF 重建接缝）
const float seamThreshold = 1.0 / 1024.0;
normalData.normalWS.z = CopySign(max(seamThreshold, abs(normalData.normalWS.z)), normalData.normalWS.z);

float2 octNormalWS  = PackNormalOctQuadEncode(normalData.normalWS);          // 单位球 -> 单位方
float3 packNormalWS = PackFloat2To888(saturate(octNormalWS * 0.5 + 0.5));    // (12+12) -> 24 bit 分到 RGB 三通道
outNormalBuffer0    = float4(packNormalWS, normalData.perceptualRoughness);  // GBuffer1 = RGBA8: (octN.xyz 1212+8packed)|roughness
```

**1212 含义**：oct-quad 把 4D 法线压成 2 个 12-bit float（共 24 bit），再装进 RGB 三通道（`PackFloat2To888`：取低 8 bit 入 R、中 8 入 G、高 8 入 B），Alpha 留给 perceptualRoughness。`Lit.hlsl:524` 注释明确：*normal.xy (1212), perceptualRoughness*。

**HG 沿用**：HG 不动 oct-quad，因为它是 GPU 几乎 0 成本的法线压缩；NormalBuffer 在 SSR / DepthPyramid / GTAO 都直接 sample，统一接口。`Lit.hlsl:602`：`EncodeIntoNormalBuffer(ConvertSurfaceDataToNormalData(surfaceData), outGBuffer1)`。

### 3.4 GBuffer2 编码 — 6 个 surface 视图（材质分类的核心）

GBuffer2 是材质分类的**唯一信息来源**（`Lit.hlsl:558`）。`Lit.hlsl:604-734` 用一棵 if-else 决策树，按 surfaceData.materialFeatures 选 6 种 layout 之一：

| 分支 | featureId | GBuffer2.rgb 内容 | GBuffer2.a 内容 |
|---|---|---|---|
| SSS+Trans+ColoredTrans | TRANSMISSION_SSS=3 / SSS=4 / TRANSMISSION=5 + coloredBit | specOcc, transmissionTint.rgb (PackR7G7B6) | PackedCoatMask(4) | colored=1 | featureId(3) |
| 纯 SSS（无 trans） | SSS=4 | specOcc, thickness, PackFloatInt8bit(transmissionMask, diffusionProfileIndex, 16) | PackedCoatMask(5) | featureId(3) |
| 纯 Trans（无 SSS） | TRANSMISSION=5 | specOcc, thickness, PackFloatInt8bit(transmissionMask, diffusionProfileIndex, 16) | PackFloatToUInt(coatMask, 4, 4) | 0<<3 | featureId(3) |
| Anisotropic | ANISO=1 | anisotropy(signed 0..1), remappedSinOrCos, PackFloatInt8bit(metallic, storeSin?1:0, 8) | PackedCoatMask(5) | featureId(3) |
| Iridescent | IRIDESCENCE=2 | iridescenceMask, iridescenceThickness, PackFloatInt8bit(metallic, 0, 8) | PackedCoatMask(5) | featureId(3) |
| Standard | STANDARD=0 | FastLinearToSRGB(fresnel0.rgb) | PackedCoatMask(5) | featureId(3) |

featureId 常量在 HDRP `Lit.cs`（C# 端）：`GBUFFER_LIT_STANDARD=0, ANISOTROPIC=1, IRIDESCENCE=2, TRANSMISSION_SSS=3, SSS=4, TRANSMISSION=5`。

**Anisotropic 分支的角度编码**（`Lit.hlsl:644-703`）是整个 encode 里最讲究的一段：
- 先用 `GetLocalFrame(normalWS)` 重建一个"默认切线帧" `frame[0..2]`。
- 算 surfaceData.tangentWS 在该默认 frame 下的 (sin, cos)。
- 用 4 个象限对称把角度规约到第一象限：`AnisoGGX(α, β, γ) == AnisoGGX(β, α, γ+π/2)` 等（`Lit.hlsl:660-666`）。
- `quad2or4 = (sinFrame * cosFrame) < 0` 判定象限 2/4，再 `uintAniso = round(anisotropy * 127.5 + 127.5)`，象限 2/4 时翻转 `uintAniso = 255 - uintAniso`，最后 `/ 255` 写入 R。这种**手动 round 而不是依赖硬件 unorm round** 是为了规避 DX11 D3D Spec 里 FLOAT→UNORM 的非确定性 round 导致的接缝（`Lit.hlsl:679-680` 注释引 MS 文档）。
- 余下 `(metallic, storeSin?1:0)` 用 `PackFloatInt8bit(value, intValue, scaleFactor=8)` 共编入 `outGBuffer2.b`：高 5 bit 装 metallic（×31 取整），低 3 bit 装 tangentFlags（0..7 索引）。

**SSS/Transmission 把 specOcc 移到 GBuffer2.r**：原因是 GBuffer0.a 让位给 (diffusionProfile|subsurfaceMask)，所以 specOcc 被踢到 GBuffer2.r（`Lit.hlsl:625-638`）。Decode 端必须根据 featureId 反向选择。

**Colored Transmission** 极致压缩（`Lit.hlsl:627-632`）：把 RGB 转 `PackToR7G7B6` 得 20-bit `rgb20`，分三段写入：

```
outGBuffer2.rgb   = float3(encodedSpecOcc, PackByte((rgb20 >> 12) & 0xFF),  // 高 8 bit 入 G
                                            PackByte((rgb20 >> 4)  & 0xFF)); // 中 8 bit 入 B
encodedCoatMask = ((rgb20 & 0xF) << 4) | (1 << 3);                          // 低 4 bit 入 a 的高 4 bit；中间 1 bit 标记 colored=true
```
这样 a 的 8 bit 被分为 `[colored-bit=1] [rgb20 低 4 bit] [featureId 3 bit]` —— featureId=TRANSMISSION，第 4 bit 区分 colored vs 纯 transmission。**整个材质的颜色 transmission 用了 0 个额外 RT。**

### 3.5 GBuffer2.a 的最终装配

不论分支，**最后一行**永远是：

```
outGBuffer2.a = PackByte(encodedCoatMask | materialFeatureId);   // Lit.hlsl:734
```

`Lit.hlsl:733` 注释：*no need to store MATERIALFEATUREFLAGS_LIT_STANDARD, always present*。Standard 在 decode 时无条件设上（`Lit.hlsl:835`）。

### 3.6 GBuffer3 编码（HDRP 有，HG 没有）

HDRP `Lit.hlsl:760-772` 把 `bakeDiffuseLighting * AO + emissiveColor` 写入 R11G11B10F；若两者全 0 则写入 `AO_IN_GBUFFER3_TAG = float3(2048, 1, 1024)` 作 sentinel 让 decode 端识别 "其实只有 AO" 并恢复（`Lit.hlsl:753`）。HG 没有 GBuffer3，相当于 emissive/bakedGI 在 forward-pass 写 SceneColor，跳过这段。

---

## 4. GBuffer 解码算法（3 RT → BSDFData）

`Lit.hlsl:799-1044` 的 `DecodeFromGBuffer(positionSS, tileFeatureFlags, out BSDFData, out BuiltinData)` 是延迟光照 pass 与材质分类 compute 的公共入口。算法流程：

### 4.1 Step 1：读 GBuffer2 抽 featureId

```
uint materialFeatureId  = UnpackByte(inGBuffer2.a) & 0x7;     // 低 3 bit
bool coloredTransmission = UnpackByte(inGBuffer2.a) & 0x8;    // bit 3
float coatMask           = UnpackCoatMask(inGBuffer2);         // 高 5 bit -> 0..1
```
（`Lit.hlsl:831-833`）

### 4.2 Step 2：从 featureId 推 pixelFeatureFlags

`Lit.hlsl:835-849`：

```
pixelFeatureFlags = STANDARD;                                              // 永远置位
pixelHasSubsurface   = (id == TRANSMISSION_SSS || id == SSS);
pixelHasTransmission = (id == TRANSMISSION_SSS || id == TRANSMISSION);
pixelHasTransmiRGB   = (id == TRANSMISSION && coloredTransmission);
pixelHasAnisotropy   = (id == ANISOTROPIC);
pixelHasIridescence  = (id == IRIDESCENCE);
pixelHasClearCoat    = (coatMask > 0.0);

pixelFeatureFlags |= tileFeatureFlags & (pixelHasSubsurface   ? SSS : 0);
... (同样 OR-mask 给 transmission, RGB, aniso, iridescence, clearCoat)
```

`tileFeatureFlags` 来自材质分类 compute（`MaterialFeatureFlagsFromGBuffer`，`Lit.hlsl:1047-1054`）。**这是 deferred 性能的关键**：tile 内所有像素的 feature 取并集（在另一个 compute pass 算好），DecodeFromGBuffer 拿这个 tile flag 走分支统一路径，避免 GCN 上 wave-divergent execution（`Lit.hlsl:852-858`：*divergent branch on AMD GCN mean we will execute both branch for all fragment*）。

### 4.3 Step 3：解 GBuffer1 法线

`Lit.hlsl:881-885`：

```
NormalData normalData;
DecodeFromNormalBuffer(inGBuffer1, normalData);    // 见 §3.3 反向：3×8 -> oct12+12 -> normalWS
bsdfData.normalWS            = normalData.normalWS;
bsdfData.geomNormalWS        = bsdfData.normalWS;  // 没有 prepass 时退化
bsdfData.perceptualRoughness = normalData.perceptualRoughness;
```

### 4.4 Step 4：分支解 GBuffer2

`Lit.hlsl:894-994` 按 pixelFeatureFlags 分 4 大块：

**Metallic 分支**（aniso 或 iridescence）：metallic 在 GBuffer2.b 高位，用 `UnpackFloatInt8bit(b, 8, metallic, unused)` 拆出，再 `ComputeDiffuseColor / ComputeFresnel0`（默认 specular value 0.04）。

**SSS/Trans 分支**：从 GBuffer0.a 拆 (subsurfaceMask, diffusionProfileIndex)，从 GBuffer2.b 再拆一次 diffusionProfileIndex（duplicate，让编译器把 GBuffer0 的读推迟到 PostEvaluateBSDF，节省 VGPR — `Lit.hlsl:918-920`）。再根据 transmission/colored 走 `FillMaterialColoredTranslucent` 或 `FillMaterialTransmission`。

**Anisotropy 分支** 还原 §3.4 的角度（`Lit.hlsl:955-981`）：

```
anisotropy  = inGBuffer2.r * 2.0 - 1.0;
sinOrCos    = (0.5/256.0 * rsqrt(2)) + (255.0/256.0 * rsqrt(2)) * inGBuffer2.g;  // cell-centered remap
cosOrSin    = sqrt(1 - sinOrCos*sinOrCos);
storeSin    = tangentFlags != 0;
sinFrame    = storeSin ? sinOrCos : cosOrSin;
cosFrame    = storeSin ? cosOrSin : sinOrCos;

frame[0] = sinFrame * frame[1] + cosFrame * frame[0];   // 把默认 frame 绕法线旋转回真实切线
frame[1] = cross(frame[2], frame[0]);
```

**Standard 分支**：`bsdfData.fresnel0 = FastSRGBToLinear(inGBuffer2.rgb)`，`bsdfData.diffuseColor = baseColor`（直接取 GBuffer0.rgb，因为 encode 时已经 `ComputeDiffuseColor`）。

### 4.5 Step 5：返回 pixelFeatureFlags

`Lit.hlsl:1043`。返回值供 LightLoop 走 feature-variant 索引（`Lit.hlsl:103-148` 的 `kFeatureVariantFlags[NUM_FEATURE_VARIANTS=29]` 静态表 + `FeatureFlagsToTileVariant`），把不同材质组合编入 28 个预编译变体 + 1 个 catch-all，每变体对应 LightLoop 的一个 indirect dispatch。

### 4.6 HG delta：把 featureId 移到 stencil

HG 反编译里 `HGDeferredShadingModel.cs` 把 shading model 缩成 **3 个**：

```
public enum HGDeferredShadingModel : uint {
    SHADING_MODEL_DEFAULT_LIT       = 0,   // 对应 HDRP STANDARD
    SHADING_MODEL_TWO_SIDED_FOLIAGE = 1,   // HDRP 无；HG 新增（叶片双面 wrap+transmission，跟 SpeedTree 的 SubsurfaceProfile 共享 GPU 代码路径）
    SHADING_MODEL_SUBSURFACE        = 2    // 对应 HDRP SSS
}
```

并通过 `HGStencilUtils.HGStencilBitMask.DeferredShadingModel = 7`（低 3 bit mask）把这个 id **写进 stencil** 而非 GBuffer2.a。这等价于：HG 的延迟 lighting compute 不用 sample GBuffer2.a 就能知道走 Lit / SSS / Foliage 哪条分支，省一次 RT-fetch 且能让 LightLoop 用 stencil-buffer 直接 cull 像素（hardware stencil-test，0 cost）。

HDRP 的 Aniso / Iridescence / ClearCoat / ColoredTransmission HG **裁掉了**——三个 shading model 没有 aniso/coat 等 slot。这与 HG 的 art-style（NPR + foliage + character SSS）一致。

---

## 5. Stencil 位分配与跨 pass 协议

### 5.1 HDRP 的 StencilUsage（基准线）

`HDStencilUsage.cs:9-39` 把 8-bit stencil 分两个生命周期：

**Opaque 阶段（清零前）**：
```
IsUnlit                   = 1<<0   // unlit 材质（SG/shader），跳过 lighting
RequiresDeferredLighting  = 1<<1   // Lit GBuffer 像素
SubsurfaceScattering      = 1<<2   // SSS split lighting
TraceReflectionRay        = 1<<3   // SSR/RTR opt-in
Decals                    = 1<<4   // 写入 DBuffer 的 opaque decal
ObjectMotionVector        = 1<<5   // motion blur/SSR/TAA
```

**Opaque 之后清零**，bit0..5 复用：
```
WaterExclusion            = 1<<0
ExcludeFromTUAndAA        = 1<<1
DistortionVectors / SMAA  = 1<<2
Refractive                = 1<<4
WaterSurface              = 1<<5
UserBit0/1                = 1<<6, 1<<7
```

`BaseLitAPI.cs:173-258` 的 `ComputeStencilProperties` 是真正的协议规则：
- GBuffer pass 写 `RequiresDeferredLighting | SubsurfaceScattering(若 splitLighting) | TraceReflectionRay(若 SSR)`。
- Motion vector pass 写 `ObjectMotionVector | TraceReflectionRay`，且 forward-only 材质要把 `RequiresDeferredLighting` 也加到 writeMask（因为它在 GBuffer 之后绘，要 clear 那位）。
- Depth prepass 写 `TraceReflectionRay | Refractive | IsUnlit | ExcludeFromTUAndAA`。

### 5.2 HG 的位分配

`HGStencilUtils.cs:7-19` 给的 mask：

```
public enum HGStencilBitMask
{
    DeferredShadingModelBit0 = 1,     // ┐
    DeferredShadingModelBit1 = 2,     // ├ 低 3 bit = shading model id (Default/Foliage/SSS)
    DeferredShadingModelBit2 = 4,     // ┘
    StencilTestDecal         = 8,     // bit 3：屏蔽/接收 Mesh Decal
    CharacterBit             = 16,    // bit 4：角色像素（VFXPP / Outline / Bloom 用）
    NotReceiveDecals         = 32,    // bit 5：跟 StencilTestDecal 协同（NRD 屏蔽）
    IgnoreSceneEffectPP      = 64,    // bit 6：场景级 PP（screen drop / scan line）跳过此像素
    EditorTerrainDecal       = 128,   // bit 7：编辑器 terrain decal 通道
    DeferredShadingModel     = 7,     // 三 bit 合成 mask
    AllBit                   = 255
}
```

**与 HDRP 的对应关系**（delta 一览）：

| HG bit | HDRP 对应 | 说明 |
|---|---|---|
| bit 0..2 = ShadingModel id | （HDRP 走 GBuffer2.a 的 featureId） | HG 用 stencil 而非 RT，省 RT-fetch + 可硬件 stencil-cull |
| bit 3 StencilTestDecal | bit 4 Decals | 同语义 |
| bit 4 CharacterBit | 无（HDRP 用 rendering layer） | HG 自研角色管线（NPR）专用 |
| bit 5 NotReceiveDecals | （HDRP 通过材质 keyword `_DISABLE_DECALS`） | HG 把它升级成 per-pixel stencil，DBuffer compose pass 可跳过 |
| bit 6 IgnoreSceneEffectPP | 无 | HG 角色/UI 特效专用 |
| bit 7 EditorTerrainDecal | 无 | 编辑器专属 |
| **没有 SSR / MotionVector / IsUnlit / Refractive bit** | HDRP 有 | HG 把这些信息塞到 GBuffer / RT 里或用其他方式 |

HG 这样做**舍弃了 HDRP 的双生命周期复用**：opaque 之后 stencil 不再 clear（HG 的 `ClearStencilPass.cs` 是按需 clear 而非每 frame 全 clear）。

### 5.3 SetStencilValueByMask 的原子语义

`HGStencilUtils.cs:99-143` 的 `SetStencilValueByMask(ref int @ref, int value, int writeMask)` 反汇编出来就是一个简单的 32-bit RMW：

```
mov eax,edi          ; eax = writeMask
and ebx,edi          ; ebx = value & writeMask  (clean value)
xor eax,0FFh         ; eax = ~writeMask (8-bit invert)
and eax,[rsi]        ; eax = oldRef & ~writeMask  (clear those bits)
or  eax,ebx          ; eax |= maskedValue
mov [rsi],eax        ; write back
```

等价于 C 代码：`@ref = (@ref & ~writeMask) | (value & writeMask)`。`GetStencilValueByMask` 只是 `return @ref & readMask`。这意味着 HG 的 stencil 是**位字段 32-bit int 在 C# 端 pre-compute、整体传给材质的 `_StencilRef/_StencilWriteMask`**（`HGShaderIDs.cs:175-179`：`_StencilMask, _StencilRef, _StencilCmp`），HG shaderlab 的 `Stencil { Ref [_StencilRef] WriteMask [_StencilMask] ... }` 拿这个值。

### 5.4 ClearStencilPass

`ClearStencilPass.cs:17-44` 用一张 `m_ClearStencilBufferMaterial` 全屏 quad，配 `Stencil { Ref 0 WriteMask 255 Comp Always Pass Replace }`，把整张 depth buffer 的 stencil 清零（depth 不动）。HG 在两种场景调用：
1. opaque 阶段结束、transparent 之前——但 HG **没有** HDRP 那种"opaque 阶段 stencil 全清"的强制规则，所以 ClearStencilPass 的触发条件是 `HGRenderCapability.useGBufferDepth` 与 OnePassDeferred 状态联动决定的（构造函数只调用一次拿到 material，实际 clear 看 ConstructPass）。
2. 多视图渲染切换时（VR/反射 cube），上一视图的 stencil 不该污染下一视图。

---

## 6. HGRenderQueue 优先级带与 frame-slot 仲裁

### 6.1 优先级常数

`HGRenderQueue.cs:7-36` 的 `Priority` 枚举：

```
Background                                          = 1000
Opaque                                              = 2000
OpaqueDecal                                         = 2225
OpaqueAlphaTest                                     = 2450
OpaqueDecalAlphaTest                                = 2475
OpaqueLast                                          = 2500
AfterPostprocessOpaque                              = 2501
AfterPostprocessOpaqueAlphaTest                     = 2510
PreRefractionFirst                                  = 2650
PreRefraction                                       = 2750
PreRefractionLast                                   = 2850
TransparentFirst                                    = 2900
Transparent                                         = 3000
TransparentLast                                     = 3100
LowTransparentFirst                                 = 3200
LowTransparent                                      = 3300
LowTransparentLast                                  = 3400
AfterDistortionBeforePostprocessTransparentFirst    = 3460
AfterDistortionBeforePostprocessTransparent         = 3500
AfterDistortionBeforePostprocessTransparentLast     = 3540
AfterDistortionTransparentFirst                     = 3560
AfterDistortionTransparent                          = 3600
AfterDistortionTransparentLast                      = 3640
AfterPostprocessTransparentFirst                    = 3660
AfterPostprocessTransparent                         = 3700
AfterPostprocessTransparentLast                     = 3740
Overlay                                             = 4000
```

带 10 段：opaque (1000-2500)、afterPP-opaque (2501-2510)、preRefraction (2650-2850)、transparent (2900-3100)、lowTransparent (3200-3400)、afterDistortionBeforePP-transparent (3460-3540)、afterDistortion-transparent (3560-3640)、afterPP-transparent (3660-3740)、overlay (4000)。每带 50 ~ 100 内供 `_TransparentSortPriority` micro-tune（`HGMaterialProperties.cs:21`）。

### 6.2 RenderQueueType 反查

`HGRenderQueue.cs:38-51` 的 `RenderQueueType` 枚举给 PassConstructor 用："这个材质属于 GBuffer pass / PreRefraction pass / AfterDistortionTransparent pass 哪一段"。`GetTypeByRenderQueueValue(int renderQueue)` 反汇编里是一连串 `Contains` 判定（`HGRenderQueue.cs:247-398`）：

```
if (renderQueue == 1000) return Background;
if (k_RenderQueue_AllOpaque.Contains(rq)) return Opaque;             // 2000..2500
if (k_RenderQueue_AfterPostProcessOpaque.Contains(rq)) return AfterPostProcessOpaque;
if (k_RenderQueue_PreRefraction.Contains(rq)) return PreRefraction;
if (k_RenderQueue_Transparent.Contains(rq)) return Transparent;
if (k_RenderQueue_LowTransparent.Contains(rq)) return LowTransparent;
if (k_RenderQueue_AfterDistortionBeforePostprocessTransparent.Contains(rq)) return ...;
if (k_RenderQueue_AfterDistortionTransparent.Contains(rq)) return AfterDistortionTransparent;
if (k_RenderQueue_AfterPostProcessTransparent.Contains(rq)) return AfterPostprocessTransparent;
return (renderQueue != 4000) ? Unknown : Overlay;
```

PassConstructor 拿到 type 之后据此 dispatch 到对应的 `CullingResults` 子集。`ClampsTransparentRangePriority` 把 transparent 段内 `_TransparentSortPriority` 钳到 `[-50, 50]`（反汇编 `cmp ebx, 32h` = 50；`mov eax, sub_FFFFFFCE` = 0xFFFFFFCE = -50 sign-extended）。

### 6.3 sortingPriority 与 ChangeType

`HGRenderQueue.cs:400-543` 的 `ChangeType(targetType, offset, alphaTest, receiveDecal)` 把 `targetType + offset` 映射回具体 priority 值：

```
switch (targetType)
{
    case Opaque:
        if (alphaTest)    return receiveDecal ? OpaqueDecalAlphaTest (2475) : OpaqueAlphaTest (2450);
        else              return receiveDecal ? OpaqueDecal (2225)         : Opaque (2000);
        // 加 offset 后整体偏移
    case PreRefraction:                       return offset + 0xABE  = offset + 2750;
    case Transparent:                         return offset + 0xBB8  = offset + 3000;
    case LowTransparent:                      return offset + 0xCE4  = offset + 3300;
    case AfterDistortionBeforePostprocessTransparent: return offset + 0xDAC = offset + 3500;
    case AfterDistortionTransparent:                  return offset + 0xE10 = offset + 3600;
    case AfterPostprocessTransparent:                 return offset + 0xE74 = offset + 3700;
    case Overlay:                              return 0xFA0 = 4000;
    case Background:                           return 0x3E8 = 1000;
    default: throw new ArgumentException("Unknown RenderQueueType, was " + targetType);
}
```

材质 inspector 改 surfaceType 时调这个把 renderQueue 重写。HG 的 alpha-test/decal 标记直接进 priority 而非走 keyword，省 shader variant。

---

## 7. ArtTags / DeferredShadingModel / ShadingModel 路由

### 7.1 ArtTags

`ArtTags.cs:3-41` 给每个 GameObject 35 种语义标签：

```
Untagged=0, HLOD, Terrain, Props, Building, Rock, Tree, Bush, Grass, Character, Actor, Enemy, NPC, Weapon,
Animal, Interactive, Factory, Module, Erosion, Rigidbody, Vine, Water, Waterdecal, Cloth, Road, Realdecal,
Meshdecal, Shards, InteractiveProp, InteractiveModule, SceneSkinAnimated, ShadowProxy, InteractiveTree,
InteractiveGreenary, FarSceneMod, ArtTagsCount=35
```

ArtTags 不直接进 GPU；它们驱动**渲染特性的 opt-in/opt-out**：例如 Character → enable CharacterBit stencil + capsule shadow + character bloom；Erosion → enable erosion pass；Cloth → enable GPU cloth simulation；Waterdecal → 走 WaterDecal pass list。所以 ArtTags 是 C# 端的"渲染特性路由表 key"，与 Unity 自带的 layer/tag 共存。

### 7.2 LitShaderMode vs HGRenderMode

两个看似重复但服务不同对象的枚举：

`LitShaderMode.cs`（public，shader-facing）= 单材质级的 forward/deferred 选择，驱动 shader keyword 与 pass 子集。  
`HGRenderMode.cs`（internal，pipeline-facing）= 整条管线的 forward/deferred 选择，由 `HGRenderCapability` 在启动时决定。  
`ObsoleteLitShaderMode.cs`（标注 `[Obsolete("For data migration")]`）保留旧资产迁移。

### 7.3 HGRenderCapability 的硬件路径仲裁

`HGRenderCapability.cs:91-117` 的 `GetPlatformBestMatchRenderPath`：
- `GraphicsDeviceType == 0x15` (Vulkan) 时，检查 shader define `21h`（VARIANTS_NO_NATIVE_RP_FALLBACK），有 → fallback (renderPath = 4)，无 → OnePassDeferred (renderPath = 3)。  
- 其他 device → MultiPassDeferred (renderPath ≤ 3)。

`HGRenderCapability.IsOnePassDeferred` 测试 `renderPath == 4`（即 Vulkan 启用 subpass）→ true。`GetUseGBufferDepth`：OnePassDeferred 时返回 true，否则 false——意思是在 subpass 模式下，深度也作为 attachment 入 GBuffer 通道，全程不离开 tile mem。

`IsSupportedHardware()` 用 bitmap `bt ecx,eax` 查 `0x8230904`（bitmap 涵盖 device types 2,8,11,17,21,25,26 等），且 ≤ 0x1B（27）— 覆盖 Vulkan/Metal/D3D11+/PS4/PS5/XBOne/Scarlett。

---

## 8. ConstantBuffer 池与 cbuffer 生命周期

### 8.1 [HGConstantBufferLayout] 标注

`HGConstantBufferLayoutAttribute.cs:5-8`：

```
[AttributeUsage(AttributeTargets.Struct)]
internal class HGConstantBufferLayoutAttribute : Attribute { }
```

被这个属性标的 struct（如 `ShaderVariablesDebugDisplay`）会在工具阶段被扫描生成 `.cs.hlsl`（与 HDRP 的 `[GenerateHLSL]` 同源），保证 C# 字段顺序与 HLSL cbuffer 内存布局**字节对字节一致**。`ShaderVariablesDebugDisplay.cs` 有 25 个字段，全是 `int/float/Vector4`，按 16-byte 对齐排布，cbuffer 总尺寸 = 96 + 16 = 112 bytes（典型 cbuffer 大小）。

### 8.2 HGConstantBufferPool —— bump-allocator + ring 复用

`HGConstantBufferPool.cs:7-303` 实现一个 **GPU-side cbuffer pool**，结构：

```
class HGConstantBufferPool {
    ComputeBuffer m_GPUBuffer;                  // 单条大 ComputeBuffer (raw, stride=4)
    DynamicArray<Segment> m_allocatedSegments;  // 待 upload 的 CPU staging 段
    int m_startOffset;                          // 本帧已分配的字节偏移
    int m_unusedSegmentCount;
    int m_shrinkTicks;                          // 收缩计时器
    
    const int INC_SEGMENT_SIZE  = 524288;      // 0x80000 = 512 KiB，扩容步长
    const int SHRINK_FRAME_COUNT = 16;         // 连续 16 帧没用满 -> 缩
}
```

构造函数（`HGConstantBufferPool.cs:41-89` 反汇编）：

```
m_GPUBuffer = new ComputeBuffer(count=0x80000/8, stride=8, ComputeBufferType.Default=1);
```

**bump-allocate** 模式：每帧 Reset 清 `m_startOffset = 0`，`Alloc<T>()` 返回 `CBHandle { offset, size, ptr }` 指向 staging segment 里一段。CBHandle 含 `unsafe T* ptr` 让 C# 直接 memcpy 数据进 staging。

`ApplyPendingUpload`（`HGConstantBufferPool.cs:139-297`）：
1. 算 GPU buffer 容量 = `stride * count`（`mul ebp, edi`）。
2. 若 `m_startOffset > capacity` → 扩容：`needed = max(usedSize - cap, INC_SEGMENT_SIZE)` (`sub ecx, esi; cmp ecx, edx; cmovge edx, ecx`)，Dispose 旧 buffer、new 个更大的，重置 `m_shrinkTicks=0`。
3. 若连续 16 帧 (`m_shrinkTicks >= 16`) 没满，且当前 used < cap → 收缩到 `nextPow2(used) * 8 bytes`（`cvtdq2ps; mulss [g_18E5EC3F4]` 是 log/ratio 计算，`shl esi, 0x13` = `<<19` 把 dword 数转字节数）。
4. 遍历 `m_allocatedSegments` 全部 `SetData`：`ComputeBuffer.SetData(rawBytes, srcOffset, dstOffset, size)`，segment 是 `NativeArray<byte>` 包装。

**这个 pool 是 HG 的核心抽象**：把所有 `ShaderVariablesGlobal / DebugDisplay / PerCamera / PerPass` 之类的 per-frame cbuffer 都打到同一条 ComputeBuffer 里，bind 时用 `Graphics.SetConstantBuffer(_ShaderVariablesGlobal, gpuBuffer, offset, size)`（即 cbuffer-view-with-offset），避免单 cbuffer 一个 GPU resource 的 overhead。HDRP 的 `ConstantBufferSingleton<T>` 同思路，但 HG 把 pool 化做得更彻底。

---

## 9. Shader Pass / Keyword / ShaderID 命名簿

### 9.1 ShaderPassNames

`HGShaderPassNames.cs:5-133` 列出 **30 个 ShaderPass 名 + 对应 ShaderTagId**：

```
Forward, ForwardLit, DepthOnly, DepthForwardOnly, DepthCharacterOnly, ForwardCharacterOnly,
CharacterOutline, ForwardOnly, ReflectionForwardOnly, VFXDecal, GBuffer, Erosion, ErosionMobile,
HGBuffer, TerrainDepthOnly, GBufferWithPrepass, SRPDefaultUnlit, MotionVectors, Distortion,
VolumerticFogVoxelization, TransparentDepthPrepass, TransparentBackface, TransparentDepthPostpass,
Meta, ShadowCaster, FullScreenDebug, BakeHLOD, OccludedDisplay, StencilAlphaBlend, PostProcessMask
```

外加 internal: `Always, ForwardBase, Deferred, PrepassBase, Vertex, VertexLMRGBM, VertexLM`（Unity built-in 兼容）。**HG 的新 pass**：
- `Erosion / ErosionMobile`：terrain decal 的腐蚀混合 pass。
- `HGBuffer`：HG-specific GBuffer 变体（区别于 HDRP `GBuffer`）。
- `CharacterOutline / ForwardCharacterOnly / DepthCharacterOnly`：NPR 角色管线专属（用 CharacterBit stencil）。
- `OccludedDisplay`：HZB occlusion 测试失败后的 hint display（debug 用）。
- `StencilAlphaBlend`：alpha blend + stencil compose。

### 9.2 ShaderKeyWords

`HGShaderKeyWords.cs:5-170` 列出 80+ keyword，分类：

**GlobalKeyword（无后缀，per-camera 全局）**：
```
s_EnableScreenSpaceShadowMask
s_MVKeyword                                  // 写不写 motion vector
s_PerObjectMVKeyword                          // per-object MV
s_DisableDynamicLightLoop
s_EnableWetness, s_RainWetnessHighQuality    // 雨/湿润系统
s_EnableIrradianceVolumeV2                    // GI V2
s_EnableSubpassInputUnderOnePassDeferred      // Vulkan subpass input 开关
```

**string（local keyword，材质级）**：
```
s_HighQuality, s_MediumQuality, s_LowQuality   // SQ tier
s_EnableAlpha, s_CharacterMask                  // 透明、character 路径
s_TonemappingNeutral / ACES / Custom / External / None / ACESmodified
s_SharpenFilter1/2/4, s_PerformSharpen
s_Vignette, s_VignetteMask, s_DirtyLens
s_Bloom, s_BloomDirt, s_LightShaftCloudMask
s_RadialBlur, s_RadialBlurWithChromaticAberration
s_UseScanLine, s_UseBlackBox, s_ScanLineUseMask, s_BWMaskTex, s_BWFlashTex
s_ApplyLUT, s_UserLUT, s_MeteringCenter
s_TaauPerformanceMode, s_TaauNextgenMode
s_EnableHierarchicalZOcclusionCulling
s_WorldUIKeyword
s_DoFKernelRadiusKeywords[]                   // 数组：不同 DoF kernel 半径
s_DebugFullScreen / s_DebugFullScreenPreDepth / s_DebugRegular
s_UseAutoExposureHistogram
s_EnableFoliageOccluderMask
s_HighQualityMultiScatteringApproxEnabled
SUNDISC_HQ, HG_SKYBOX_STAR, HG_SKYBOX_NEBULA
s_Ring, s_DrawPlanetsRing[], s_DrawPlanetsAtmosphere[]   // 行星
CLOUDS_FLOWMAP, ENABLE_CLOUDS_SHADOW
DRAW_ADVANCED_PLANET / _CLOUDS_FLOWMAP / _CLOUDS_SHADOW
s_Cloud, s_CloudFlowMap, s_CloudProceduralFlow
s_GTAOUseFP32Depths, s_GTAOBentNormals          // GTAO 子选项
s_SSRImportanceSample
s_SceneColorAdjustMentEnableSaturation
s_FakeGlint, s_SubsurfaceProfile, s_FakeVolume  // 假特效（CSM/SDF/volume）
s_FakeCrackCSM, s_FakeShadow
s_DisableTerrainContactShadow, s_HasTerrainLayerTypeData
s_InteractionUseCCD
s_SubsurfaceProfileSimple
s_MipLevelCount1..4, s_FetchFromLastMip          // mip 层数选择
```

**Keyword 管理策略**：HG 把 90% keyword 做成材质级 string，避免 GlobalKeyword 引发的 shader variant 爆炸（GlobalKeyword 对所有材质所有 shader 生效，每加 1 个 keyword 变体翻倍）。详细机制见 `../10-Shaders/01-Shaders.md` §5。

### 9.3 ShaderIDs

`HGShaderIDs.cs` 共 **~1750 个 `static readonly int`**，类型化分组：
- GBuffer / Pyramid / HZB / Depth：`_GBufferTexture[]`, `_HZBTexture0..3`, `_CurrPyramidTexture0..6`
- Camera / Matrix：`_ViewMatrix, _InvViewProjMatrix, _ScreenSize, _ZBufferParams`
- Stencil 通用：`_StencilMask, _StencilRef, _StencilCmp`
- Per-system 命名空间前缀：`_HGTerrain*` (50+), `_Volumetric*` (40+), `_SSR*` (30+), `_GTAO*` (30+), `_Water*` (50+), `_Fake*` (CSM/Volume/Crack, 30+), `_ISSR*` (24)

HG 用 `Shader.PropertyToID` 把字符串提前 hash 到 `int`，全部初始化在静态构造函数里。**性能收益**：runtime 的 `cmd.SetGlobalTexture(string, tex)` 走 string→int 字典查找（约 100 ns/call），改用 int 版直接是 memcpy（~10 ns）。HG 数千次 `Set*` 每帧，省下显著 CPU。

---

## 10. 1:1 复刻蓝图（分步）

### 10.1 GBuffer 编解码

**Step 1：定义 SurfaceData + BSDFData 结构**——照抄 `Lit.cs.hlsl:81-137` 的字段顺序与类型（注：必须**精确**，HG 也照搬，因为这是 deferred 全平台一致的 ABI）。

**Step 2：实现 `EncodeIntoGBuffer`**——按 `Lit.hlsl:562-790` 拷贝整个 if-else 决策树。**HG 修改点**：
- 不写 `outGBuffer3`（emissive 直进 SceneColor）。
- 不需要 RENDERING_LAYERS / SHADOWS_SHADOWMASK / UNITY_VIRTUAL_TEXTURING 的可选分支。
- 把 GBuffer2.a 的 featureId 同时写一份到 stencil（用 `HGStencilUtils.HGStencilBitMask.DeferredShadingModel = 7`）。

**Step 3：实现 `DecodeFromGBuffer`**——按 `Lit.hlsl:799-1044` 拷贝；**HG 修改**：从 stencil 而非 GBuffer2.a 读 shading model id（节省 1 次 RT-fetch）。

**Step 4：实现 `EncodeIntoNormalBuffer / DecodeFromNormalBuffer`**——直接照抄 `NormalBuffer.hlsl`，注意 `seamThreshold = 1.0/1024.0` 防 Z 接缝、`PackFloat2To888` 的 24-bit oct-quad 装包。

**Step 5：实现 `Material classification` compute**——`MaterialFeatureFlagsFromGBuffer`（`Lit.hlsl:1047-1054`）：对每 tile (8×8 或 16×16) 调用 `DecodeFromGBuffer(positionSS, UINT_MAX, ...)` 拿 featureFlags，原子 OR 进 tile flag buffer。

**Step 6：LightLoop variant 表**——`Lit.hlsl:103-148` 的 `kFeatureVariantFlags[29]`（28+catch-all），与 `FeatureFlagsToTileVariant(featureFlags)`。每变体编译成单独的 LightLoop kernel，indirect-dispatch 时 tile flags → variant idx → kernel 索引。

### 10.2 Stencil 协议

**Step 1：定义 HGStencilBitMask enum**——见 §5.2。**关键决策**：是否双生命周期复用（HDRP）还是单一布局（HG）。HG 单布局更简单但放弃了几个 bit 复用率。

**Step 2：在材质 inspector / shaderlab 写 stencil 块**——按 pass 类型设置 mask/ref/comp/pass：
```
Stencil { Ref [_StencilRef] WriteMask [_StencilMask] Comp [_StencilCmp] Pass Replace }
```
HG 用 C# 端 `HGStencilUtils.SetStencilValueByMask` 预计算 ref+mask 一起传。

**Step 3：在 PassConstructor 阶段**——选 stencil-test material 做屏蔽（`HGCapsuleShadowContainer` / `CharacterBit` filter / `IgnoreSceneEffectPP` 等都是 stencil 比较的消费者）。

### 10.3 RenderQueue 与 PassConstructor

**Step 1：照搬 `HGRenderQueue.Priority` 的 10 段**。

**Step 2：实现 `GetTypeByRenderQueueValue / ChangeType / GetTransparentEquivalent / GetOpaqueEquivalent`**（`HGRenderQueue.cs:247-731`）。

**Step 3：每个 PassConstructor 用对应 `RenderQueueRange + ShaderTagId` 调 `CreateOpaqueRendererListDesc / CreateTransparentRendererListDesc`**（`GBufferPassConstructor.cs:340-381` 反汇编看 `HGRendererListUtils.CreateOpaqueRendererListDesc(rendererListDesc, cullingResults, frameSettings, ...)`）。

### 10.4 GBuffer profile 与 RenderCapability

**Step 1：构造 `GBufferProfileManager` 注册 HighEnd/LowEnd profile**，每 profile 注册 3 张 RT（GBufferA RGBA8_SRGB / GBufferB RGBA8 / GBufferC RGBA8）。HighEnd 额外开 sRGB（`0x4B`），LowEnd 走 memoryless（在 PassConstructor 里 `SetGBufferTextureMemoryless`）。

**Step 2：实现 `HGRenderCapability.GetPlatformBestMatchRenderPath`**——按 `SystemInfo.graphicsDeviceType` + shader-defines 选 forward / multi-pass-deferred / one-pass-deferred。

**Step 3：实现 `SupportNativeRenderPass()`**——Vulkan(8)/Metal(11)/D3D12(17)/PS5(2) 之外返回 true。这是 OnePassDeferred 的硬件门槛。

**Step 4：GBufferOutput**（`GBufferOutput.cs:7-122`）封装 `NativeArray<TextureHandle> m_attachments + NativeArray<int> m_gbufferMapping` —— mapping 让 attachment 编号与 GBufferID 解耦（例如 GBufferA 在 RenderGraph 里可能是 attachment#1，因为 #0 给 SceneColor）。

### 10.5 ConstantBuffer 池

照搬 `HGConstantBufferPool.cs:7-303` 的 bump-allocator + 16-frame-shrink + 512 KiB-grow 即可。**关键测点**：`ApplyPendingUpload` 必须在每个 RenderGraph pass 之前，所有 cbuffer 写入都用 `SetConstantBuffer(id, m_GPUBuffer, offset, size)` 形式拿到正确 view。

---

## 11. 关键常量速查表

| 常量 | 值 | 出处 | 含义 |
|---|---|---|---|
| `GBufferID.Count` | 4 | `GBufferID.cs:9` | 3 色 RT + 1 Depth |
| `MATERIALFEATUREFLAGS_LIT_STANDARD..COLORED_TRANSMISSION` | 1, 2, 4, 8, 16, 32, 64, 128 | `Lit.cs.hlsl:10-17` | 8 个材质特性 bit |
| `GBUFFER_LIT_STANDARD..TRANSMISSION` | 0..5 | HDRP `Lit.cs` | featureId 6 种 |
| `NUM_FEATURE_VARIANTS` | 29 | `Lit.hlsl:103-148` 数组长度 | LightLoop tile 变体数 |
| `HGStencilBitMask.DeferredShadingModel` | 7 | `HGStencilUtils.cs:17` | stencil 低 3 bit mask |
| `HGStencilBitMask.AllBit` | 255 | `HGStencilUtils.cs:18` | stencil 8 bit 全 mask |
| `HGDeferredShadingModel` 取值 | 0, 1, 2 | `HGDeferredShadingModel.cs:5-7` | DefaultLit / TwoSidedFoliage / Subsurface |
| `Priority.Opaque` | 2000 | `HGRenderQueue.cs:10` | 不透明带起点 |
| `Priority.Transparent` | 3000 | `HGRenderQueue.cs:21` | 透明带起点 |
| `k_TransparentPriorityQueueRangeStep` | 100 | `HGRenderQueue.cs:53` | transparent 带宽 |
| `k_TransparentAfterDistortionPriorityQueueRangeStep` | 40 | `HGRenderQueue.cs:55` | after-distortion 带宽 |
| `sortingPriorityRange` | 50 | `HGRenderQueue.cs:87` | `_TransparentSortPriority` 钳值 |
| `meshDecalPriorityRange` | 50 | `HGRenderQueue.cs:89` | mesh decal 在带内偏移 |
| `INC_SEGMENT_SIZE` | 524288 (512 KiB) | `HGConstantBufferPool.cs:27` | cbuffer pool 扩容步长 |
| `SHRINK_FRAME_COUNT` | 16 | `HGConstantBufferPool.cs:29` | cbuffer pool 收缩计时 |
| `seamThreshold` (normal Z) | 1/1024 ≈ 0.000977 | `NormalBuffer.hlsl:27` | oct 编码 Z 防接缝 |
| `AO_IN_GBUFFER3_TAG` | float3(2048, 1, 1024) | `Lit.hlsl:753` | HDRP GBuffer3 AO-only sentinel（HG 无 GBuffer3，不使用） |
| `GraphicsFormat 0x4B` | R8G8B8A8_SRGB | `GBufferProfileManager.cs` AddGBufferRT 调用 | HighEnd GBufferA/B 格式 |
| `GraphicsFormat 0x08` | R8G8B8A8_SRGB（LowEnd） | 同上 | LowEnd GBufferA 格式 |
| `GraphicsFormat 0x04` | R8G8B8A8_UNorm | 同上 | GBufferC 格式 |
| `ArtTagsCount` | 35 | `ArtTags.cs:40` | 美术语义标签总数 |
| `_StencilMask / _StencilRef / _StencilCmp` PropertyID | (运行时哈希) | `HGShaderIDs.cs:175-179` | shaderlab stencil 参数 |

---

## 12. 支撑证据：本单元 24 文件清单

| 文件 | 行数级 | 职责 |
|---|---|---|
| `GBufferID.cs` | 12 | enum：GBuffer attachment 编号（A/B/C/Depth/Count） |
| `GBufferOutput.cs` | 123 | struct：封装 `NativeArray<TextureHandle> + mapping`，含 `GetGBufferAttachment(id)` 双 IDTag overload |
| `GBufferPassConstructor.cs` | 763 | RenderGraph pass：GBuffer 阶段的 ConstructPass，分别建 ECS / GPU-driven / character prepass 三条 RendererList |
| `GBufferProfileManager.cs` | 808 | HighEnd / LowEnd profile 容器；`SetupGBufferOutput / CreateGBufferTexture / SetGBufferTextureMemoryless` |
| `HGDeferredShadingModel.cs` | 10 | enum：3 种 shading model（Lit / Foliage / SSS） |
| `HGStencilUtils.cs` | 194 | `HGStencilBitMask` 枚举 + `Get/SetStencilValueByMask` 原子 RMW |
| `HGRenderQueue.cs` | 734 | 10 段 priority + `RenderQueueType` + `Contains/Clamp/GetType/ChangeType/GetTransparentEquivalent/GetOpaqueEquivalent` |
| `HGRenderMode.cs` | 9 | enum：pipeline 级 forward/deferred |
| `LitShaderMode.cs` | 9 | enum：单材质 forward/deferred |
| `ObsoleteLitShaderMode.cs` | 12 | 旧资产迁移用 |
| `ArtTags.cs` | 43 | 35 种美术语义标签 |
| `HGRenderCapability.cs` | 211 | 硬件能力：renderPath / useGBufferDepth / isMobile / supportNativeRP / supportedHardware |
| `HGMaterialProperties.cs` | 36 | 公共材质 string keys（`_ZWrite`, `_StencilRef`, `_BlendMode`, ...） |
| `HGShaderIDs.cs` | 1750 | ~1750 个 `Shader.PropertyToID` 静态字段 |
| `HGShaderKeyWords.cs` | 171 | 80+ keyword：全局 + 材质级 |
| `HGShaderPassNames.cs` | 135 | 30 个 ShaderPass 字符串 + 对应 ShaderTagId |
| `HGShaderQualityLevel.cs` | 9 | enum：High / Low |
| `HGConstantBufferLayoutAttribute.cs` | 9 | `[HGConstantBufferLayout]` 标 struct → 生成 `.cs.hlsl` |
| `HGConstantBufferPool.cs` | 305 | 单 ComputeBuffer + bump-alloc + 16-frame 收缩 |
| `HGRenderPipelineMaterialCollector.cs` | 311 | `CreateMaterial/ClearMaterials` + 静态版；自动 track 生命周期 |
| `ClearStencilPass.cs` | 92 | 全屏 quad clear stencil pass（按需调用） |
| `ShaderVariablesDebugDisplay.cs` | 58 | `[HGConstantBufferLayout]` 标的 debug cbuffer struct，25 个字段 |
| `ShaderVariantLogLevel.cs` | 9 | enum：变体编译日志开关 |
| `TRingBuffer.cs` | 1034 | 泛型 ring-buffer container，给 InteractionChain/MotionBlur history 用 |

---

## 引用与交叉链接

- HDRP 真值源（commit `75de48326bcd`）：
  - `D:\Ruri\02.Unity\Project\HDRP\Library\PackageCache\com.unity.render-pipelines.high-definition@75de48326bcd\Runtime\Material\Lit\Lit.hlsl`
  - `...\Lit.cs.hlsl`、`...\BaseLitAPI.cs`
  - `...\Runtime\Material\NormalBuffer.hlsl`
  - `...\Runtime\RenderPipeline\HDStencilUsage.cs`
- 本仓库其他单元：
  - GBuffer 布局与延迟着色：[`../02-CoreAlgorithms/01-CoreAlgorithms.md`](../02-CoreAlgorithms/01-CoreAlgorithms.md) §1（GBuffer layout）/ §2（Deferred Lighting）
  - 几何 pass / opaque 流水：[`../01-PipelineCore/02-GeometryPasses.md`](../01-PipelineCore/02-GeometryPasses.md)
  - Keyword 管理与 shader variant：[`../10-Shaders/01-Shaders.md`](../10-Shaders/01-Shaders.md) §5

---

## 待确认（仅限 native-only 细节）

1. `GBufferProfileManager.cs` 第二个 `GBufferProfile`（LowEnd）的具体 `AddGBufferRT` 第二参数 (`0x08`) 与 HighEnd 的 (`0x4B`) 在最新 Unity `GraphicsFormat` 枚举里是否完全等于 `R8G8B8A8_SRGB` / `R8G8B8A8_UNorm`——枚举序号在 Unity 2022/2023 之间有过两次小重排。反汇编里的整数能确认，但需用与 HG fork 同 Unity 版本的 `GraphicsFormat.cs` 验证。
2. `_StencilCmp` 是否用于跨 pass 切换 Compare 函数还是恒为 `Always`：反编译只能看到 ShaderID 注册，未见运行时 `SetInt` 调用，可能是 shader 内联固定。

