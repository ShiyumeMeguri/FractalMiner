# HG.RenderPipelines Shader 架构精确技术文档

> **覆盖**: HGRP `packages/com.hg.render-pipelines/runtime/shaders/` 全部 14 大类、~160 个 .shader,以及各 Shader 与 PassConstructor 的精确绑定关系。
> **风格**: 客观、中立、参考渲染架构工程文档。每个 shader 给出路径 + 对应 PassConstructor 源(`文件:行号`)+ Pass 角色 + 关键 GBuffer/Pass 接口。
> **简称**: HGRP = HG.RenderPipelines.Runtime。

---

## 0. 目录

| § | 主题 |
|---|------|
| 1 | Shader 14 大类总览 + 文件结构 |
| 2 | GBuffer 输出约定与统一接口 |
| 3 | Shader → PassConstructor 全量绑定表 |
| 4 | 关键 Shader 深入: `lit` / `litforward` / `deferredlighting` / `characternpr` 全家族 / `litwater` |
| 5 | Variant / Keyword 管理策略 |
| 6 | Shader 与 Pass 阶段的执行顺序 |
| 7 | 附录 |

---

## 1. Shader 14 大类总览

Shader 根目录: `packages/com.hg.render-pipelines/runtime/shaders/`(全量分析报告 §1.1)

```
shaders/
├── cloth/             # 布料 (4)
├── common/            # 公共 hlsl 片段(非独立 .shader)
├── debug/             # 调试可视化 (~10)
├── dlss/              # DLSS/FSR3/MetalFX 适配片段
├── environment/       # 大气 / 天空 / 云 / 星空 (~15)
├── interaction/       # Decal/Ink/Interaction Node 交互 (~5)
├── lighting/          # Deferred Lighting + Shadow + SSR (~10)
├── materials/         # 主材质大类(lit/characternpr/terrain/water/foliage/decal/effect/unlit/...)(~80)
├── particles/         # 粒子专用 (~3)
├── postprocessing/    # Bloom/UberPost/DOF/TAAU/SMAA/Sharpen/LightShaft (~20)
├── raytracing/        # 硬件光追(DX12) (~3)
├── terraindeform/     # 地形变形 Compute (~3)
├── utils/             # Blit/Blur/CopyDepth/Pyramid/字体 (~12)
└── volumetric/        # 体积雾 + 体积云 + SDF (~6)
```

总计 14 大类,160+ `.shader`(同名变体 .hlsl 片段不另计)。

### 1.1 14 类一句话角色表

| 类目 | 角色 | 主要消费者 |
|------|------|-----------|
| cloth | 布料三角 / 线 (`clothtrishader`, `clothlineshader`) | GpuClothManager 模拟后绘制 |
| common | 共享 HLSL 头文件(`*.hlsl`) | 各 .shader 引用 |
| debug | Gizmos / 光照 debug / shadow debug / AOV | `HGDebugRenderManager` |
| dlss | DLSS / FSR3 / Streamline 输入转换片段 | `TAAUPassConstructor` 与 `MetalFXTemporal/Spatial` Pass |
| environment | 天空 / 大气 / 云卡片 / 星空 / 行星环 | `HGAtmosphereRenderer`, `HGSkyRenderer`, `HGSkydomeStarRenderer` |
| interaction | Decal 交互 / 墨水模拟 / 交互节点 | `InkSimulationPassConstructor`, `HGDecalInteration`, `HGInteractionNode` |
| lighting | Deferred Lighting + 阴影 Atlas/Blur/Caster + SSR | `DeferredLightingPassConstructor`, `ShadowMapPassConstructor`, `CapsuleShadowPassConstructor`, `HyperScreenSpaceReflectionRenderingPass` |
| materials/lit | 主 Lit shader(GBuffer + Forward + Transparent + HLOD + Effect) | `GBufferPassConstructor`, `ForwardPassConstructor`, `TransparentPassConstructor` |
| materials/characternpr | 角色 NPR 全家族(Skin/Hair/Eye/Cloth/LiquidAG/OverlayShadow/ShadowReceiver/ProxyLOD) | `ForwardPassConstructor`(角色独立 ECS list) |
| materials/terrain | 地形主 Shader + Decal + 深度 Resolve | `TerrainDepthPrepassConstructor`, `GBufferPassConstructor` |
| materials/water | 水主 Shader + Decal + Wetness + Ripple Compute | `WaterSectorRenderingPass`, `WaterDefaultDeferredRenderingPass`, `WaterOnePassDeferredRenderingPass`, `WaterInteractionRenderingPass`, `WetnessMaskPass` |
| materials/foliage | 草 / 树叶 / Billboard / CardMesh / Interactive / Occluder | `FoliageOccluderPassConstructor`, `FoliageInteractivePassConstructor`, `ForwardOpaquePassConstructor` |
| materials/decal | DBuffer Decal Lit/Unlit + VFX Decal + Erosion | `DecalPassConstructor` |
| materials/effect | VFX 基础 / 高级 / Batch / Dither / 折射 / 烟雾 VAT / 角色 Outline/WallHack/Growing / Sludge / 容器水 / 假体积雾 / 工厂动画 | `ForwardPassConstructor`(`liteffect`), `TransparentPassConstructor`(`liteffectblend`), `SludgePassConstructor`(`sludgev2`) |
| materials/unlit | 无光照基础 + LOD | 通用 Forward |
| materials/screenemotion | 屏幕表情 (`screenemotion.shader`) | 角色面部专用 |
| materials/cutsceneeffect | 过场效果 (黑边/特效) | 过场系统 |
| materials/blockout | Blockout 灰盒 (`litpoly` + `litpolytriplanar`) | 关卡灰盒 |
| materials/rain | 远雨 / 雨溅射 / 场景雨效 / 屏幕雨滴 | `HGRainRenderer` 等 |
| materials/volumetriclightbeam | 体积光锥(动态生成) | `volumetriclightbeam` 第三方资产 |
| materials/uieffect | UI 框特效 | UI Pass |
| particles | Physical Particle | GPU Particle System |
| postprocessing | Bloom/UberPost/DOF/TAAU/SMAA/LightShaft/LensFlare/LUT/Sharpen/FrostedGlass/UIImageBlur/AnamorphicStreaks | 后处理 PassConstructor 群 |
| raytracing | 光追反射 | `HyperRayTracingReflection` |
| terraindeform | 地形变形 Compute | `HGTerrainDeformManager` |
| utils | Blit / Blur / CopyDepth / CopyStencil / ClearDepth / ClearStencil / ColorPyramid / LowResBlit / VSM / SDF Font / FrameInterpolation Convert / CubeMap-Strip / Cube→Panorama | 各 Pass 工具 |
| volumetric | 体积雾渲染 / 合成 / SDF 云 / 通用 SDF March / SDF Preview | `HGVolumetricFogRenderer`, `VolumetricCloudPassConstructor`, `VolumetricRenderer` |

---

## 2. GBuffer 输出约定

### 2.1 槽位定义(再录,详见 02-CoreAlgorithms §1)

**源**: `GBufferID.cs:3-10`

```csharp
internal enum GBufferID {
    GBufferA = 0,  GBufferB = 1,
    GBufferC = 2,  GBufferDepth = 3,
    Count = 4
}
```

### 2.2 各 GBuffer 的字段语义

> 由 `GBufferPassConstructor.cs:10-53` 的 PassInput + 02-CoreAlgorithms §1.2 + `HGDeferredShadingModel.cs` 综合确认。

| RT | 格式(候选) | RGB 内容 | A 内容 | 备注 |
|----|---------|---------|--------|------|
| GBufferA | R8G8B8A8_UNorm(法线压缩) 或 R16G16_UNorm | 世界空间法线(2 通道 OctEncode 或 RGB 编码) | ShadingModel id(2-bit) + 其它辅助位 | ShadingModel 取值见 `HGDeferredShadingModel.cs:3-8`:0=DEFAULT_LIT、1=TWO_SIDED_FOLIAGE、2=SUBSURFACE |
| GBufferB | R8G8B8A8_sRGB | Albedo (RGB) | Ambient Occlusion (烘焙/材质常量) | DBuffer 贴花可改写 |
| GBufferC | R8G8B8A8_UNorm | R=Metallic、G=Roughness、B=Emission(LDR) | A=辅助(角色 mask / 湿度 / 自定义) | DBuffer 贴花可改写粗糙度 |
| GBufferDepth | D24_UNorm_S8_UInt 或 D32_SFloat_S8_UInt | 深度 | Stencil(角色 mask bit5 等) | sceneMV(R16G16_SFloat)作为额外 attachment 同 Pass 写入 |

> 精确像素格式由 `HGRenderPipelineRuntimeResourcesCPP` 与运行时质量配置决定(全量报告 §6.8 提及 110+ shader ID),源未定位到精确格式定义文件。

### 2.3 GBuffer Pass 写出顺序

```
DepthPrepass / TerrainDepthPrepass 写 sceneDepth
              ↓
GBufferPass:  写 sceneMV 与 GBuffer[A/B/C] (4 个 MRT attachment)
              ↓
DecalPass:    DBuffer 改写 GBuffer A/B/C  (法线 / albedo / 粗糙度)
              ↓
DeferredLightingPass:  读 GBuffer A/B/C + Depth + AO/SSR/Shadow + Capsule SH → 写 sceneColor
```

### 2.4 单 Pass 延迟 (OnePassDeferred) 子 Pass 排布

**源**: `OnePassDeferredPassConstructor.cs:177-194`

```csharp
private enum OnePassDeferredSubpass
{
    PreDepth          = 0,
    GBuffer           = 1,
    Decal             = 2,
    PostGBuffer       = 3,
    DeferredLighting  = 4,
    ForwardOpaque     = 5,
    ForwardTransparent = 6,
    Count             = 7
}

private enum FixedAttachment
{
    SceneColor   = 0,
    MotionVector = 1,
    Count        = 2
}

private const string HG_USE_SUBPASS_INPUT_UNDER_ONE_PASS_DEFERRED =
    "HG_USE_SUBPASS_INPUT_UNDER_ONE_PASS_DEFERRED";
```

OnePassDeferred 利用 Vulkan/Metal Subpass(TBDR On-Chip Tile Memory)将上述 7 个子 Pass 压成单个 Render Pass,GBuffer A/B/C 不写回 framebuffer 内存。Shader 通过 `HG_USE_SUBPASS_INPUT_UNDER_ONE_PASS_DEFERRED` 关键字选择 `SubpassInput` 而非 `Texture2D` 采样 GBuffer。

---

## 3. Shader → PassConstructor 全量绑定表

### 3.1 materials/lit (主 Lit)

| Shader | Pass(在 .shader 里定义) | PassConstructor 源 | 备注 |
|--------|------------------------|-------------------|------|
| `materials/lit/lit.shader` | `GBuffer`, `DepthOnly`, `Motion`, `ShadowCaster` | `GBufferPassConstructor.cs`, `DepthPrepassConstructor.cs`, `ShadowMapPassConstructor.cs` | 标准延迟主入口 |
| `materials/lit/litforward.shader` | `ForwardLit`, `ForwardReflection`(FakePlanar Mirror) | `ForwardPassConstructor.cs`, `FakePlanarReflectionPass.cs` | 前向 + 平面反射 mirror 写入 |
| `materials/lit/lithlod.shader` | `Forward HLOD`, `ShadowCaster` | `ForwardPassConstructor.cs` | HLOD impostor |
| `materials/lit/liteffect.shader` | `Forward`, `Motion` | `ForwardPassConstructor.cs` | VFX/Effect 不透明 |
| `materials/lit/liteffectblend.shader` | `Transparent` | `TransparentPassConstructor.cs` | VFX/Effect 混合 |
| `materials/lit/littransparent.shader` | `Transparent`, `TransparentAfterDOF` | `TransparentPassConstructor.cs`, `TransparentAfterDOFPassConstructor.cs` | 透明物体 |

### 3.2 materials/characternpr (角色 NPR 全家族)

| Shader | Pass | PassConstructor | 关键算法 |
|--------|------|----------------|---------|
| `characternpr.shader` | `ForwardLit`, `Outline`, `ShadowCaster`, `DepthOnly`, `Motion` | `ForwardPassConstructor`(独立角色 ECS list)、`ShadowMapPassConstructor` | 主角色 NPR:Shadow LUT + Diffuse Ramp + Spec Ramp + GGX Spec + Skin Spec(CP8/CP9) + Subsurface + 描边 |
| `characternpr_skin.shader` | `ForwardLit`, `Outline` | `ForwardPassConstructor` | 肤色 SSS + SDF Lightmap + Emotion Map(面部) + Highlight Map + CP14 二次高光 |
| `characternpr_hair.shader` | `ForwardLit`, `Outline` | `ForwardPassConstructor` | Split Normal Map(漫反射 + 高光分离)+ Kajiya-Kay 各向异性双 strand 高光 + Specular Line + 眉毛遮挡(`_DRAW_UNDER_BROW`) + CP10 Height Darken |
| `characternpr_eye.shader` | `ForwardLit` | `ForwardPassConstructor` | 眉毛 + 瞳孔双形态:Parallax 视差映射 + Iris 圆圈 mask + matcap 伪球面法线 + CP13 直接项 |
| `characternpr_liquidag.shader` | `Transparent` | `TransparentPassConstructor` | 角色液体(汗水 / 透明肌肤层) |
| `characternpr_overlayshadow.shader` | 单独 `OverlayShadow` Pass | `ForwardPassConstructor` 内联或独立 | 角色叠加阴影(对其他物体的投射) |
| `characternpr_shadowreceiver.shader` | `ShadowReceiver` | `ForwardPassConstructor` 阴影接收叠加 | 仅做 receiver,不写深度 |
| `characternpr_proxylod.shader` | `Forward Proxy` | `ForwardPassConstructor`(LOD 级别) | 远距离 ProxyLOD |
| `characternpr_fur.shader`(若存在) | `Forward Fur Shell` | `ForwardPassConstructor` | 多层壳渲染 |
| `characternpr_vfx.shader` | `Forward VFX overlay` | `ForwardPassConstructor` | 角色 VFX 叠加 |

### 3.3 materials/terrain

| Shader | Pass | PassConstructor | 备注 |
|--------|------|----------------|------|
| `terrain/hgterrainps.shader` | `DepthOnly`, `GBuffer`, `Forward`(VTBake) | `TerrainDepthPrepassConstructor.cs`, `GBufferPassConstructor.cs`, `TerrainVTBakePassConstructor.cs` | 主地形,支持 Tessellation + Wet Ripple |
| `terrain/terraindecallit.shader` | `Decal` | `DecalPassConstructor.cs` | 地形 Decal Lit |
| `terrain/terraindecalsplinelitv2.shader` | `Decal Spline` | `DecalPassConstructor.cs` | 沿曲线投影 Decal |
| `terrain/hgterraindepthresolve.shader` | `Resolve` | `TerrainDepthPrepassConstructor.cs` | 多 MSAA / Subdivision 解析 |

### 3.4 materials/water

| Shader | Pass | PassConstructor | 备注 |
|--------|------|----------------|------|
| `water/litwater.shader` | `WaterSector ForwardLit`, `Caustics`, `DepthOnly` | `WaterSectorRenderingPass`(全量报告 PassID=26) | 水主 Shader + 焦散 + SSR 反射(走 `HyperScreenSpaceReflectionRenderingPass`) |
| `water/waterrendering.shader` | `Water Deferred` | `WaterDefaultDeferredRenderingPass` | 水延迟光照合成 |
| `water/waterforwardrendering.shader` | `Water Forward` | `WaterOnePassDeferredRenderingPass`,`TransparentPassConstructor`(`PassInput.waterRenderingPass`) | 单 Pass 延迟下的水前向 |
| `water/waterproxy.shader` | `DepthOnly proxy` | `WaterSectorRenderingPass` | 代理 Mesh 遮挡 |
| `water/waterdecal.shader` | `Decal` | `DecalPassConstructor.cs`(`waterDecal`) | 水面 Decal |
| `water/wetnessdecal.shader` | `WetnessMask` | `WetnessMaskPass`(PassID=58) | 湿度 Decal |
| `water/wetnesstrail.shader` | `WetnessMask Trail` | `WetnessMaskPass` | 拖尾湿轨 |
| `water/ripplesimulate.shader` | Compute | `WaterInteractionRenderingPass`(PassID=27) | 涟漪扩散模拟 |
| `water/rippleheightconvert.shader` | Compute | `WaterInteractionRenderingPass` | 涟漪 → 高度场 |
| `water/ripplerange.shader` | Compute | `WaterInteractionRenderingPass` | 范围 mask |
| `water/watertextureprocessps.shader` | Compute / PS | (内部) | 水纹理处理 |

### 3.5 materials/foliage

| Shader | Pass | PassConstructor | 备注 |
|--------|------|----------------|------|
| `foliage/grass.shader` | `Forward`,`DepthOnly`,`ShadowCaster` | `ForwardOpaquePassConstructor.cs`,`GBufferPassConstructor.cs`(`deferredGrassECSList`) | 单元草顶点动画 + Interactive 弯折(02-CoreAlgo §14.1) |
| `foliage/grassbillboardlod.shader` | `Forward LOD` | `ForwardOpaquePassConstructor.cs` | 远距离 Billboard |
| `foliage/grasscardmeshlod.shader` | `Forward LOD` | `ForwardOpaquePassConstructor.cs` | Card Mesh LOD |
| `foliage/leaf.shader` | `Forward`,`ShadowCaster` | `ForwardOpaquePassConstructor.cs` | 双面叶,使用 `SHADING_MODEL_TWO_SIDED_FOLIAGE=1` |
| `foliage/treefoliagebillboardlod.shader` | `Forward LOD` | `ForwardOpaquePassConstructor.cs` | 树冠 Billboard |
| `foliage/treefoliagecardmeshlod.shader` | `Forward LOD` | `ForwardOpaquePassConstructor.cs` | 树冠 CardMesh |
| `foliage/foliageinteractivecollider.shader` | 顶视图正交 | `FoliageInteractivePassConstructor.cs` | 写 dual-height RT(R=Bend,G=Recover) |
| `foliage/foliageoccluder.shader` | 顶视图正交 | `HGFoliageOccluderManager.cs`(512² mask) | 大型物体高度图遮挡剔除草 |

### 3.6 materials/decal

| Shader | Pass | PassConstructor | 备注 |
|--------|------|----------------|------|
| `decal/decallit.shader` | `DBuffer Lit` | `DecalPassConstructor.cs` | 标准 DBuffer Decal,写法线 + albedo + 粗糙度 |
| `decal/decalunlit.shader` | `DBuffer Unlit` | `DecalPassConstructor.cs` | 仅写 albedo |
| `decal/vfxdecal.shader` | `Forward DBuffer` | `DecalPassConstructor.cs` | VFX Decal |
| `decal/vfxdecalprojector.shader` | `Forward DBuffer Projector` | `DecalPassConstructor.cs` | VFX 投影 Decal |
| `decal/decalerosionvolume.shader` | `Forward DBuffer Erosion` | `DecalPassConstructor.cs`(`deferredErosionECSList` `:36`) | 腐蚀体积 |

### 3.7 materials/effect

| Shader | 用途 | PassConstructor |
|--------|------|----------------|
| `vfxbasev2.shader` | 基础粒子 | `ForwardPassConstructor.cs`,`ParticleLightingPassConstructor.cs` |
| `vfxadvance.shader` | 高级粒子(可写阴影/法线) | 同上 |
| `vfxbasebatched.shader` | Batched 粒子 | 同上 |
| `vfxditheralpha.shader` | Dither 透明粒子 | `TransparentPassConstructor.cs` |
| `vfxrefract.shader` | 折射粒子 | `DistortionPassConstructor.cs` |
| `vfxice.shader` | 冰面 | `TransparentPassConstructor.cs` |
| `vfxwater.shader` | 水效果 | `TransparentPassConstructor.cs` |
| `vfxsmoke_sixway.shader` | 六向烟雾 VAT(6 张光照贴图加权) | `ForwardPassConstructor.cs` |
| `vfxsmoke_vat.shader` | 顶点动画纹理烟雾 | 同上 |
| `vfxline.shader` | 线条 | `ForwardPassConstructor.cs`,`TransparentPassConstructor.cs` |
| `vfxradialblur.shader` | 径向模糊 | (后处理 Distortion) |
| `vfxskillscanline.shader` | 技能扫描线 | `VFXPPScanLinePassInput`(全量 §6.5) |
| `vfxskillscanlinehighlight.shader` | 技能扫描线高亮 | 同上 |
| `vfxcharacteroutline.shader` | 角色描边 VFX 覆写 | `ForwardPassConstructor.cs` |
| `vfxcharacterwallhack.shader` | 角色透视 | 同上 |
| `vfxcharactergrowing.shader` | 角色溶解/生长 | 同上 |
| `vfxdswrite.shader` | 深度模板写入 | (DepthOnly 内联) |
| `vfxcapturemesh.shader` | Mesh 捕获 | `EntityRenderCaptureMeshController` |
| `vfxscenecoloradjustment.shader` | 场景色调整 | (后处理) |
| `vfxreflectionpass.shader` | 反射 Pass | `FakePlanarReflectionPass.cs` |
| `vfxbasefactory.shader` | 工厂动画 | `ForwardPassConstructor.cs` |
| `sludge/sludgev2.shader` | 泥浆 | `SludgePassConstructor.cs`(PassID=5) |
| `sludge/dynamicsludgeblit.shader` | 泥浆动态 Blit(扩散) | `SludgePassConstructor.cs` |
| `containerwater/vfxcontainerwater.shader` | 容器内水体 | `TransparentPassConstructor.cs` |
| `fakefog/vfxfakevolumefog.shader` | 假体积雾 | `ForwardPassConstructor.cs`(`liteffect`) |

### 3.8 materials/unlit / screenemotion / cutsceneeffect / blockout / rain / volumetriclightbeam / uieffect

| Shader | 用途 | PassConstructor |
|--------|------|----------------|
| `unlit/unlit.shader` | 无光照基础 | `ForwardPassConstructor.cs`,`TransparentPassConstructor.cs` |
| `unlit/unlitsubshaderlod.shader` | Unlit LOD | 同上 |
| `screenemotion/screenemotion.shader` | 角色屏幕表情 | `ForwardPassConstructor.cs` |
| `cutsceneeffect/cutsceneeffect.shader` | 过场黑边 | `CutsceneEffectPassRPInput`(全量 §6.5) |
| `blockout/litpoly.shader` | Blockout 灰盒 | `GBufferPassConstructor.cs` |
| `blockout/litpolytriplanar.shader` | Blockout 三面映射 | 同上 |
| `rain/farrain.shader` | 远距离雨粒子 | `HGRainRenderer` |
| `rain/rainsplash.shader` | 雨溅射 | `HGRainSplashRenderer` |
| `rain/sceneeffectrain.shader` | 场景雨效 | `HGSceneEffectRainRenderer` |
| `rain/screenraindropfx.shader` | 屏幕雨滴 | `HGScreenRainDropFXRenderer` |
| `volumetriclightbeam/vlbgeneratedshader.shader` | 体积光锥 | `volumetriclightbeam` 资产 |
| `uieffect/uiframeeffect.shader` | UI 框效果 | `UIPassConstructor.cs` |

### 3.9 lighting

| Shader | Pass | PassConstructor |
|--------|------|----------------|
| `lighting/deferredlighting.shader` | Pass 0-11 (3 stage × 4 group, 见 02-CoreAlgo §2.2) | `DeferredLightingPassConstructor.cs` |
| `lighting/deferredlightingperlight.shader` | PerLight Mesh draw | `DeferredLightingPassConstructor.cs` |
| `lighting/deferredlightingwritealpha.shader` | Alpha 输出 | `DeferredLightingPassConstructor.cs` |
| `lighting/shadowblur.shader` | PCF / Atlas Blur | `ShadowMapPassConstructor.cs` |
| `lighting/shadow/capsuleshadowcaster.shader` | Capsule Caster | `CapsuleShadowPassConstructor.cs` |
| `lighting/shadow/lowresdirectionalshadow.shader` | 低分辨率方向光阴影 | `HGLowResDirectionalShadowPass.cs` |
| `lighting/shadow/screenspaceshadowresolve.shader` | 屏幕空间阴影 Resolve | `ScreenSpaceShadowMaskPassConstructor.cs`,`ContactShadowPassConstructor.cs` |
| `lighting/shadow/shadowblit.shader` | Atlas Blit | `ShadowMapPassConstructor.cs` |
| `lighting/shadow/shadowclear.shader` | Atlas Clear | `ShadowMapPassConstructor.cs` |
| `lighting/shadow/visibilitysh.shader` | Capsule SH 可见性 | `CapsuleShadowPassConstructor.cs`(`visibilitySHMaterial`,见 02-CoreAlgo §13.3) |
| `lighting/ssr/screenspacereflectionps.shader` | SSR PS Fallback | `HyperScreenSpaceReflectionRenderingPass.cs` |

### 3.10 postprocessing

| Shader | 角色 | PassConstructor |
|--------|------|----------------|
| `postprocessing/bloom/bloom.shader` | Bloom 多级金字塔 | `PostProcessPassConstructor.cs`(UberPost) |
| `postprocessing/uberpost.shader` | ACES/ColorGrading/LUT/Sharpen 合一 | `PostProcessPassConstructor.cs` |
| `postprocessing/finalpass.shader` | 最终 Blit | `SetFinalTargetPassConstructor.cs` |
| `postprocessing/dof/hgdepthoffield.shader` | DOF Circle | `DepthOfFieldPassConstructor.cs` |
| `postprocessing/dof/hgdepthoffieldhexagonal.shader` | DOF Hexagonal | `DepthOfFieldPassConstructor.cs` |
| `postprocessing/dof/hgdepthoffieldmobile.shader` | DOF Mobile | `DepthOfFieldPassConstructor.cs` |
| `postprocessing/taau/taauresolve.shader` | TAAU Resolve | `TAAUPassConstructor.cs`(TAAUPass.Resolve=3) |
| `postprocessing/taau/taaudilation.shader` | Depth/MV Dilation | `TAAUPassConstructor.cs`(TAAUPass.DilationDepthReprojection=0) |
| `postprocessing/taau/taaumaskdilation.shader` | Mask Dilation | `TAAUPassConstructor.cs`(TAAUPass.MaskDilation=1) |
| `postprocessing/smaa/smaa.shader` | SMAA 几何 AA(Fallback) | (集成在 UberPost 内 / 独立) |
| `postprocessing/anamorphicstreaks/anamorphicstreaks.shader` | 变形光晕 | `HGAnamorphicStreaks` |
| `postprocessing/lightshaft/hglightshaft.shader` | 体积光栅(降采样 + 径向模糊 + 合成) | `LightShaftPassConstructor.cs`,`LightShaftApplyPassConstructor.cs` |
| `postprocessing/lensflaredatadriven.shader` | 数据驱动镜头光晕 | `LensFlarePassConstructor.cs` |
| `postprocessing/lutbuilder2d.shader` | LUT 2D 烘焙 | `PostProcessPassConstructor.cs` |
| `postprocessing/sharpen.shader` | 锐化 | `PostProcessPassConstructor.cs` |
| `postprocessing/frostedglassblur.shader` | 磨砂玻璃模糊 | `MultiblurPassConstructor.cs` |
| `postprocessing/uiimageblur.shader` | UI 图像模糊 | `UIPostProcessConstructor.cs` |
| `postprocessing/blitbackbuffer.shader` | 后处理 BackBuffer Blit | (工具) |

### 3.11 environment / volumetric / interaction / cloth / particles / utils / debug / raytracing / dlss / terraindeform

| Shader | 角色 | PassConstructor |
|--------|------|----------------|
| `environment/atmosphere/renderatmospherelut.shader` | 大气 LUT 烘焙(Transmittance/Multi-Scattering/Sky-View/Aerial) | `HGAtmosphereRenderer.cs` |
| `environment/atmosphere/volumetriclocalfog.shader` | 局部体积雾 | `HGVolumetricLocalFog.cs` |
| `environment/atmosphere/bakefoglut.shader` | FogLUT(默认宽 4) | `BakeFogLutPassConstructor.cs`(02-CoreAlgo §10.5) |
| `environment/atmosphere/fogsimple.shader` | 简单雾 | `FakeFogSimple` |
| `environment/sky/proceduralsky.shader` | 过程天空(变体 1001-1061+) | `HGSkyRenderer` |
| `environment/sky/skyboxcubemap.shader` | CubeMap 天空盒 | `HGSkyRenderer` |
| `environment/sky/skydomestardrawer.shader` | 星空绘制 | `HGSkydomeStarRenderer.cs` |
| `environment/sky/skydomestarrt.shader` | 星空 RT 烘焙 | 同上 |
| `environment/sky/proceduralringdrawer.shader` | 行星环 | (Sky Renderer) |
| `environment/sky/cloudcard.shader` | 云卡片 | `HGSkyRenderer` |
| `environment/sky/mattepainting.shader` | 遮罩绘景 | `HGSkyRenderer` |
| `volumetric/volumetricrenderer.shader` | 体积雾体素化(Density Injection) | `HGVolumetricFogRenderer.cs`(02-CoreAlgo §10) |
| `volumetric/volumetriccompose.shader` | 体积雾合成到 sceneColor | `HGVolumetricFogRenderer.cs` |
| `volumetric/volumetriccloudsdf.shader` | 体积云 SDF March | `VolumetricCloudPassConstructor.cs` |
| `volumetric/sdf/raymarchsdf.shader` | 通用 SDF March | `VolumetricRenderer.cs` |
| `volumetric/sdf/previewsdf.shader` | SDF 调试预览 | (Debug) |
| `interaction/hgdecalinteraction.shader` | 脚印 / 痕迹 Decal | `HGDecalInteration` |
| `interaction/hginksimulation.shader` | 墨水扩散模拟 | `InkSimulationPassConstructor.cs` |
| `interaction/hgdrawinteractionnode.shader` | 交互节点(碰撞图标) | `HGInteractionNode` |
| `cloth/clothtrishader.shader` | 三角网格布料 | `GpuClothManager` |
| `cloth/clothlineshader.shader` | 线性布料 | 同上 |
| `particles/physicalparticlerender.shader` | 物理粒子 | `GPUParticleSystemManager` |
| `utils/blit.shader` | 通用 Blit | 全管线工具 |
| `utils/blur.shader` | 通用高斯模糊 | 全管线工具 |
| `utils/copydepthbuffer.shader` | 深度拷贝 | `CopyTexturePass.cs` |
| `utils/copystencilbuffer.shader` | 模板拷贝 | 同上 |
| `utils/cleardepth.shader` | 深度清空 | `ClearStencilPass.cs` 等 |
| `utils/clearstencilbuffer.shader` | 模板清空 | 同上 |
| `utils/colorpyramidps.shader` | 颜色金字塔 PS | `DepthPyramidRenderingPass.cs`(色彩金字塔合一管理) |
| `utils/lowresblit.shader` | 低分辨率 Blit | 通用 |
| `utils/vsmpass.shader` | 方差阴影映射 | `ShadowMapPassConstructor.cs`(可选) |
| `utils/fontsdf.shader` | SDF 字体 | UI |
| `utils/frameinterpolationinputconvert.shader` | 帧插值输入转换 | (DLSS-G/AFME 输入桥) |
| `utils/ftcubemap2strip.shader` | CubeMap → 条带 | 工具 |
| `utils/cubetopano.shader` | CubeMap → 全景图 | 工具 |
| `debug/*.shader`(`~10` 张) | Gizmos / DrawCall 计数 / ReflectionProbe Debug / Overdraw / Light / Shadow Debugger | `HGDebugRenderManager`(全量 §6.7) |
| `raytracing/reflection/raytracingreflectionps.shader` | 硬件光追反射 | `HyperRayTracingReflection`(`RayTracingReflectionMode.cs`) |
| `dlss/*` 片段 | DLSS / FSR3 / Streamline 输入桥 | `TAAUPassConstructor.cs`,`MetalFXTemporalPassConstructor.cs`,`MetalFXSpatialPassConstructor.cs` |
| `terraindeform/*` Compute | 地形变形 Density / Depth | `HGTerrainDeformManager.cs` |

---

## 4. 关键 Shader 深入

### 4.1 `materials/lit/lit.shader`(主延迟入口)

按命名约定包含的 Pass:

| Pass Name | LightMode 标签 | 写入 / 输出 |
|-----------|---------------|-----------|
| `GBuffer` | `LightMode = "GBuffer"` | RT0 = GBufferA(法线 + ShadingModel id),RT1 = GBufferB(Albedo+AO),RT2 = GBufferC(M/R/E),RT3 = sceneMV;Depth/Stencil 写入 sceneDepth |
| `DepthOnly` | `"DepthOnly"` | 仅深度,供 DepthPrepass |
| `ShadowCaster` | `"ShadowCaster"` | 各级阴影 Atlas;由 `HGShadowManager` 调用 |
| `Motion` | (合并到 GBuffer Pass 的 RT3) | sceneMV |

ShadingModel id 通过 `_ShadingModel` 材质属性写入 GBufferA 的 B 通道高位 2 bit。

### 4.2 `materials/lit/litforward.shader`(前向)

按 `ForwardPassConstructor.cs:10-44` 输入签名:

- `ForwardLit` Pass 直接计算 BRDF(GGX + Smith + Disney + 三 ShadingModel,见 02-CoreAlgo §2.3)
- 输入: `shadowResult`(`PassInput.shadowResult`)+ `cullingResults`(`:34`)
- 输出: 直接写 `sceneColor`(+ `sceneMV` 通过 motion Pass)
- ECS 列表区分: `forwardOpaqueECSRendererList`,`forwardOpaqueEqualECSRendererList`,`characterOpaqueECSRendererList`,`characterOutlineOpaqueECSRendererList`,`characterOutlineOpaqueEqualECSRendererList`,`forwardTransparentECSRendererList`,`forwardOccludedDisplayECSRendererList`(`ForwardPassConstructor.cs:18-31`)。

`ForwardReflection` Pass 由 `FakePlanarReflectionPass` 调用,写镜像 RT(02-CoreAlgo §5 的 `_FakePlanarReflectionTexture`),关键 ECS list 复用 `characterPrePass` 系列。

### 4.3 `lighting/deferredlighting.shader`(延迟光照核心)

按 02-CoreAlgo §2.2 的 Pass 索引 + `DeferredLightingPass.cs` `LightMeshType`(`Cone=0`, `Sphere=1`):

```
Pass 0  Directional / DefaultLit
Pass 1  Directional / TwoSidedFoliage
Pass 2  Directional / Subsurface
Pass 3  Dynamic / DefaultLit
Pass 4  Dynamic / TwoSidedFoliage
Pass 5  Dynamic / Subsurface
Pass 6  Indirect / DefaultLit (IBL + SH)
Pass 7  Indirect / TwoSidedFoliage
Pass 8  Indirect / Subsurface
Pass 9  TileDraw / DefaultLit  ← 走 BinningPass 的 tile 网格
Pass 10 TileDraw / TwoSidedFoliage
Pass 11 TileDraw / Subsurface
```

PerLight 动态光源 (`usePerLightDynamicLighting`) 走 `deferredlightingperlight.shader` 用 `DrawMeshInstanced` 绘制 Sphere/Cone 单位体积,仅在体积内做 BRDF 累加。

`deferredlightingwritealpha.shader` 用于 split-stage 时把 alpha 通道单独写出(`splitDeferredShadingStage` 标志)。

### 4.4 `materials/characternpr/characternpr_*.shader` 家族

> CharacterNPR 系列在该项目内有完整可读 HLSL 版本(`HGRP_CharacterNPR_*_Fix.shader`)。下面以路径相对于 `D:\Ruri\02.Unity\Project\FractalMiner\Assets\Project\EndField\HGRP\` 标注 + 行号。

#### 4.4.1 通用结构(`HGRP_CharacterNPR_Fix.shader:135-330`)

```
SubShader RenderType = Opaque, LOD = 600
  Pass "ForwardLit"  [LightMode=UniversalForward]
     ZWrite=On  ZTest=LEqual  Cull=Back
     CBUFFER_START(UnityPerMaterial)  // 137 个 float/float4 (cloth variant)
        _BaseColor, _BaseMap_ST, ShadowColorBrightness/Saturation,
        Metallic/Specular/Smoothness, BackFaceNormalFlip,
        AlphaPremultiply, SurfaceType, AlphaClipThreshold,
        BumpScale, EmissionColor/Brightness, CubemapIntensity,
        Outline 8 项, VFX Color Adj 8 项, Pantyhose 5 项,
        ClearCoat 5 项, Parallax 4 项,
        CharacterParams 0-13 (14 × float4),
        EnvironmentGlobalParams0, ExposureParams
     CBUFFER_END
     TEXTURE2D(_BaseMap, _BumpMap, _MetallicGlossMap, _DiffRampMap,
               _SpecRampMap, _EmissionMap, _OutlineMask, _ClearCoatMask,
               _ParallaxTex, _ShadowLutTex)
     TEXTURECUBE(_CharMaxCubemap)
  Pass "Outline"
     ZWrite=On  Cull=Front
     沿法线外扩 _OutlineWidth(可选 _OutlineMask 调制)+ Z offset _OutlineOffsetZ
```

#### 4.4.2 关键算法(印证 02-CoreAlgo §2.3 BRDF 拟合)

- **环境 BRDF 有理函数拟合**(`HGRP_CharacterNPR_Fix.shader:232-258`):
  ```
  dfg.x = P2(NdotV) · Q1(roughSq) / P3(NdotV) · Q2(roughSq, roughSq^6)
  dfg.y = 同形,系数不同
  ```
  其中分子分母是 NdotV / NdotV² / NdotV³ 与 roughSq / roughSq^6 的多项式。
- **ShadowColor**:
  - `_SHADOW_LUT_TEX` 关键字开启时走 3D LUT 模拟(B 通道作为 slice 索引,`HGRP_CharacterNPR_Fix.shader:293-303`,`lutU/V` 公式精确)
  - 否则 `shadowColor = saturation·(albedo·brightness - luma) + luma`(`:304-308`)
- **法线**:BC5 双通道 + Z 重建 `nrmZ = max(sqrt(1 - sat(x²+y²)), 1e-16)`(`:312-318`)
- **CustomAO 接入**:`CustomAOSample.hlsl:25-50`,采样 RG8 `_CustomAOTexture`(R=GTAO,G=Alchemy),关键字 `_USE_GROUND_TRUTH_AO` / `_USE_ALCHEMY_AO` 切换。最终 `color = lerp(shadowColor, color, ao)`(`CustomAOSample.hlsl:46`)。

#### 4.4.3 Hair 变体(`HGRP_CharacterNPR_Hair_Fix.shader:1-60`)

- 关键字 `_SPECULAR_NORMALMAP`:启用 Split Normal Map(RG = 漫反射法线,BA = 高光法线)
- Kajiya-Kay 各向异性高光(双 strand)+ Specular Line + `_DRAW_UNDER_BROW` 眉毛遮挡(用 `_CameraDepthTexture` 做 edge detection)
- CP10 Height Darken:沿头发根部高度做暗化
- 没有 ClearCoat / Pantyhose / Parallax,转而具有 Anisotropy 参数

#### 4.4.4 Skin 变体(`HGRP_CharacterNPR_Skin_Fix.shader:1-60`)

- 身体 / 面部双形态由 `_SDFLIGHTMAP` / `_EMOTION_MAP` / `_HIGHLIGHT_MAP` 三关键字共同切换:
  - SDF Lightmap:面部 SDF 阴影(避免逐光源 Shadow Map)
  - Emotion Map:`_EmotionIndex(0-3)` 选 4 张表情贴图之一
  - Highlight Map:面部高光遮罩
- CP14 二次高光仅在面部生效
- `_FaceForward` / `_FaceRight` 提供面部本地坐标系,SDF Lightmap 在该坐标系内采样

#### 4.4.5 Eye 变体(`HGRP_CharacterNPR_Eye_Fix.shader:1-60`)

- `_MATCAP_ON` 关键字门控完整虹膜管线:Parallax 视差 + 圆形 Iris Mask + Matcap N 通过 UV 推导伪球面法线 + EyeBlend + CP13 直接项
- 关闭时退化为纯眉毛形态(无 parallax / matcap)
- `_EyeHighlight` 关键字打开后用 `_EyeHighLightColor`(HDR)+ `_EyeScatteringColor`(HDR)做 rim 高光

### 4.5 `materials/water/litwater.shader`

- ForwardLit Pass 直接读 SSR / WetnessMask 输入(02-CoreAlgo §5,§14)
- 顶点位移由 `WaterRippleBuffer`(`WaterInteractionRenderingPass` PassID=27)采样高度场后偏移
- 焦散纹理(caustic)在 sceneColor 上作 secondary blend
- 透明对象走 `TransparentPassConstructor.cs:19` `sceneDepthWithWater`(水面以下深度合成)

---

## 5. Variant / Keyword 管理策略

### 5.1 变体爆炸的根源

全量分析报告 §5.11 直接说明: `proceduralsky.shader` 单文件就有 1001-1061+ 编号变体(`Sub0_Pass0_Fragment_b1001` 形态命名),原因是平台/特性维度宏暴力组合。

策略:

| 维度 | 实现 |
|------|------|
| 平台分支 | `multi_compile_local _ HG_USE_SUBPASS_INPUT_UNDER_ONE_PASS_DEFERRED`(`OnePassDeferredPassConstructor.cs:196`),`SHADER_API_*` |
| 渲染路径 | `LightMode` Pass tag(`GBuffer` / `ForwardLit` / `OnePassDeferred`),由 PassConstructor 选 |
| 光源类型 | `multi_compile _ _ADDITIONAL_LIGHTS _ADDITIONAL_LIGHTS_VERTEX` |
| 阴影 | `multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE` + `_ADDITIONAL_LIGHT_SHADOWS` |
| AO | `_CUSTOM_AO_ON` + `_USE_GROUND_TRUTH_AO` / `_USE_ALCHEMY_AO`(`CustomAOSample.hlsl:11-17`) |
| ShadingModel | GBuffer 编码 2 bit,DeferredLighting 三 Pass 一组,共 3 (Default/TwoSided/Subsurface) × 4 stage = 12 Pass |
| 角色 NPR 特性 | `_SHADOW_LUT_TEX`, `_NORMALMAP`, `_DIFF_RAMP_ON`, `_METALLICSPECGLOSSMAP`, `_SPEC_RAMP_ON`, `_EMISSION`, `_OUTLINE_MASK`, `_PANTYHOSE`, `_CLEARCOAT`, `_PARALLAX_MAP`, `_ALPHATEST_ON`(以 `HGRP_CharacterNPR_Fix.shader:33-133` 为例) |
| TAAU | `taauresolve.shader` 内部按 `TAAUQuality`(`TAAUPassConstructor.cs:53`)用 3 个变体 |
| SSR | `s_SSRImportanceSample`(`HyperScreenSpaceReflectionRenderingPass.cs:80 importanceSample`) |
| GTAO | `s_GTAOUseFP32Depths`, `s_GTAOBentNormals`(`GTAOPassConstructor.cs:28-30 enableFP32Depths/enableBentNormals`) |

### 5.2 预热与远程黑白名单

`ShaderWarmupManager`(全量 §7 `Beyond.Rendering`)在关卡加载时预热 PSO,避免运行时卡顿。`ShaderWarmupManagerRemoteCfg` 支持远程下发黑白名单针对特定设备绕过预热。

### 5.3 IFix Patch 影响

C# Pass 层的 `RenderFunc` 经 IFix 拦截(全量 §5.5):shader 本体不受影响,但 PassConstructor 中 ShaderID 绑定可热修改,从而在不发版的前提下调整某 shader 的纹理槽。

---

## 6. Shader 与 Pass 阶段执行顺序

> 摘自全量分析报告 §4.1 + 02-CoreAlgo §16 + 本文 §3 各 Pass 对应。

```
[PreRender]
  BinningPass / LightClustering             → 不调用 shader,纯 Compute
  GPUDrivenCulling                          → Compute(纯)
  GPUParticleSimulation                     → Compute(纯)
  FoliageOccluder                           → foliageoccluder.shader (顶视图正交)
  FoliageInteractive                        → foliageinteractivecollider.shader
  Sludge                                    → sludgev2.shader + dynamicsludgeblit.shader
  ShadowMap                                 → lit.shader (ShadowCaster) + shadowblit/shadowclear/shadowblur
  Atmosphere                                → renderatmospherelut.shader → proceduralsky.shader / skyboxcubemap.shader
  VolumetricFog                             → volumetricrenderer.shader (注入) + volumetriccompose.shader
  BakeFogLut                                → bakefoglut.shader
  VolumetricCloud                           → volumetriccloudsdf.shader (+ raymarchsdf 通用)
  TerrainDeform                             → terraindeform/*.compute
  InkSimulation                             → hginksimulation.shader

[Rendering]
  TerrainDepthPrepass / DepthPrepass        → hgterrainps.shader (DepthOnly), lit.shader (DepthOnly)
  GBufferPass                               → lit.shader (GBuffer), hgterrainps.shader (GBuffer), litpoly.shader 等
  DecalPass                                 → decallit/decalunlit/decalerosionvolume.shader, terraindecallit*
  WaterSectorRendering                      → litwater.shader / waterrendering.shader / waterforwardrendering.shader
  HZB / DepthPyramid                        → colorpyramidps.shader (+ Compute)
  GTAO                                      → GTAOCS (Compute)
  SSR                                       → screenspacereflectionps.shader + Compute
  ContactShadow / CapsuleShadow             → capsuleshadowcaster.shader, screenspaceshadowresolve.shader, visibilitysh.shader, capsuleshadows.compute
  ScreenSpaceShadowMask                     → screenspaceshadowresolve.shader
  DeferredLighting                          → deferredlighting.shader (Pass 0-11) + deferredlightingperlight.shader + deferredlightingwritealpha.shader
  ForwardOpaque                             → litforward.shader, grass.shader, leaf.shader, characternpr*
  FakePlanarReflection                      → litforward.shader (反射 Pass) + vfxreflectionpass.shader

[Transparent]
  Transparent                               → littransparent.shader, liteffectblend.shader, vfxwater/ice/refract/...
  VolumetricFogCompose                      → volumetriccompose.shader (与场景颜色合)
  LightShaft                                → hglightshaft.shader
  Distortion                                → vfxrefract.shader (合并 + 应用)

[PostProcessing]
  DepthOfField                              → hgdepthoffield/hexagonal/mobile.shader + Compute
  TransparentAfterDOF                       → littransparent.shader
  MotionBlur                                → MotionBlur Compute (内置)
  TAAU                                      → taaudilation / taaumaskdilation / taauresolve.shader
  LensFlare                                 → lensflaredatadriven.shader
  UberPost                                  → bloom.shader → lutbuilder2d.shader → uberpost.shader → sharpen.shader

[UI/Overlay]
  UIPostProcess                             → uiimageblur.shader, frostedglassblur.shader
  UI                                        → Unlit/UI Shader + uiframeeffect.shader
  SetFinalTarget                            → finalpass.shader (最终 Blit)
```

---

## 7. 附录

### 7.1 关键文件:行号速查表

| 主题 | 文件 | 行号 |
|------|------|------|
| GBuffer 槽位 | `GBufferID.cs` | 3-10 |
| GBuffer 容器 | `GBufferOutput.cs` | 7-23, 26, 75 |
| ShadingModel 3 态 | `HGDeferredShadingModel.cs` | 3-8 |
| ForwardPass Input | `ForwardPassConstructor.cs` | 10-45 |
| TransparentPass Input | `TransparentPassConstructor.cs` | 9-56 |
| DecalPass Input | `DecalPassConstructor.cs` | 10-45 |
| OnePassDeferred Subpass 枚举 | `OnePassDeferredPassConstructor.cs` | 177-194 |
| OnePassDeferred 关键字 | `OnePassDeferredPassConstructor.cs` | 196 |
| TAAU 4 Pass 枚举 | `TAAUPassConstructor.cs` | 142-149 |
| TAAU Quality | `TAAUPassConstructor.cs` | 53 |
| SSR ImportanceSample | `HyperScreenSpaceReflectionRenderingPass.cs` | 80 |
| GTAO FP32/BentNormal | `GTAOPassConstructor.cs` | 28-30 |
| CharacterNPR Cloth | `HGRP/HGRP_CharacterNPR_Fix.shader` | 16-209, 232-258 |
| CharacterNPR Skin | `HGRP/HGRP_CharacterNPR_Skin_Fix.shader` | 1-60 |
| CharacterNPR Hair | `HGRP/HGRP_CharacterNPR_Hair_Fix.shader` | 1-60 |
| CharacterNPR Eye | `HGRP/HGRP_CharacterNPR_Eye_Fix.shader` | 1-60 |
| CustomAO 接入 | `HGRP/CustomAOSample.hlsl` | 1-52 |
| FoliageOccluder 常量 | `HGFoliageOccluderManager.cs` | 6-15 |
| FoliageInteractive 常量 | `HGFoliageInteractiveConfig.cs` | 6-22 |

> 路径基底:`D:\Ruri\02.Unity\Project\AzureNihil\ReferenceProjects\RuriBeyond\HG.RenderPipelines.Runtime\HG\Rendering\Runtime\`(C#)
> HLSL shader 路径基底:`D:\Ruri\02.Unity\Project\FractalMiner\Assets\Project\EndField\HGRP\`(本仓库内可读 Character NPR 系列与 CustomAO)。HGRP package 完整 .shader 路径基底 `packages/com.hg.render-pipelines/runtime/shaders/`(源未直接定位完整 HLSL,以 PassConstructor C# 输入字段为权威接口)。

### 7.2 各 shader 大类文件计数(来自全量分析报告 §1.1 概述)

| 类目 | .shader 数 | 备注 |
|------|-----------|------|
| materials/lit | 6 | 含 lit/litforward/lithlod/liteffect/liteffectblend/littransparent |
| materials/characternpr | 8-10 | 含 cloth/skin/hair/eye/liquidag/overlayshadow/shadowreceiver/proxylod/(fur/vfx) |
| materials/terrain | 4 | hgterrainps + 3 decal/resolve |
| materials/water | 11 | litwater + waterrendering + forwardrendering + proxy + decal + wetnessdecal + wetnesstrail + ripplesimulate + rippleheightconvert + ripplerange + watertextureprocessps |
| materials/foliage | 8 | grass + 2 LOD + leaf + 2 LOD + interactivecollider + occluder |
| materials/decal | 5 | decallit/decalunlit/vfxdecal/vfxdecalprojector/decalerosionvolume |
| materials/effect | 25+ | 见 §3.7 全表 |
| materials/unlit/screenemotion/cutsceneeffect/blockout/rain/volumetriclightbeam/uieffect | ~12 | |
| lighting | 11 | 见 §3.9 |
| postprocessing | ~20 | 见 §3.10 |
| environment | ~10 | 见 §3.11 |
| volumetric | 5 | 见 §3.11 |
| interaction | 3 | 见 §3.11 |
| cloth | 2 | |
| particles | 1 | |
| utils | 12 | |
| debug | 10 | |
| raytracing | 1 | |
| terraindeform | Compute | |
| **合计** | **~160+** | 与全量分析报告 §1.1 一致 |
