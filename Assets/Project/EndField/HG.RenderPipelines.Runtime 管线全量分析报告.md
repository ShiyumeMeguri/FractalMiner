# HG.RenderPipelines.Runtime 全量分析报告

## 目录

- [1. 总览](#1-总览)
- [2. 管线核心模块](#2-管线核心模块)
  - [2.1 Rendering Path 体系](#21-rendering-path-体系)
  - [2.2 Render Graph 系统](#22-render-graph-系统)
  - [2.3 Pass Constructor 一览](#23-pass-constructor-一览)
  - [2.4 Shader 分类与对应](#24-shader-分类与对应)
- [3. 核心算法](#3-核心算法)
- [4. 数据流](#4-数据流)
  - [4.1 主渲染管线流程 HGRenderPipeline](#41-主渲染管线流程-hgrenderpipeline)
  - [4.2 中间产物](#42-中间产物)
  - [4.3 C++原生层数据流](#43-c原生层数据流)
- [5. 关键决策](#5-关键决策)
- [6. UnityEngine.HGGraphicsCPPModule — C++原生桥接层](#6-unityenginehggraphicscppmodule)
- [7. Rendering.Beyond — 游戏层渲染扩展](#7-renderingbeyond)
- [8. RuntimeQuality — 运行时质量控制系统](#8-runtimequality)
- [9. HG.RenderPipelines.ScriptBridge — C#桥接层](#9-hgrenderpipelinesscriptbridge)
- [10. HG.RenderPipelines.Logger — 渲染日志](#10-hgrenderpipelineslogger)
- [11. UI.Beyond / UI.Gameplay.Beyond — UI渲染](#11-uibeyond--uigameplaybeyond)
- [12. Entry.Beyond — 管线加载与初始化](#12-entrybeyond)
- [13. 第三方渲染资产](#13-第三方渲染资产)
- [14. Ruri.RenderPipelines 外部引用](#14-rurirenderpipelines)
- [15. 全景统计与模块关系图](#15-全景统计与模块关系图)

---

## 1. 总览

### 1.1 原始管线目录结构

```
HG.RenderPipelines.Runtime/
├── HG/
│   └── Rendering/
│       ├── RenderGraphModule/          # 自定义渲染图系统(非Unity内置)
│       ├── Runtime/                    # 核心管线逻辑(859个文件)
│       ├── Editor/                     # 编辑器扩展(材质面板、烘焙等)
│       ├── ScriptBridge/              # C++/C#桥接
│       ├── Tools/                     # 调试工具(DrawCall/Shadow Dump)
│       └── HgMath/                    # 自定义数学库(重心坐标、哈希等)
├── Beyond/
│   ├── Rendering/                     # VFX材质工具
│   └── SourceGenerator/               # 源码生成器(Animator/Camera/ECS属性)
├── UnityEngine/
│   └── Rendering/                     # BC6H编码扩展
├── IFix/                              # IL热修补代理
├── IniParser/                         # INI配置解析器
└── Properties/                        # 程序集信息
```

**Shader 路径**: `packages/com.hg.render-pipelines/runtime/shaders/`
**Shader 目录**: cloth/ common/ debug/ dlss/ environment/ interaction/ lighting/ materials/ particles/ postprocessing/ raytracing/ terraindeform/ utils/ volumetric/ (14大类, 约160+个.shader + 大量.hlsl片段)

### 1.2 全量模块总览

| 模块 | 文件数 | 一句话描述 | 报告章节 |
|------|--------|-----------|---------|
| 管线入口 `HGRenderPipeline.cs` | 859 | 继承`RenderPipeline`，调度所有RenderRequest | 2 |
| 渲染路径基类 `HGRenderPathBase.cs` | — | 抽象基类，持有PassConstructor列表 | 2.1 |
| 前向渲染 `HGRenderPathForward.cs` | — | 26个PassConstructors，纯前向 | 2.1 |
| 默认延迟 `HGRenderPathDefaultDeferred.cs` | — | 40个PassConstructors，GBuffer+DeferredLighting | 2.1 |
| 单Pass延迟 `HGRenderPathOnePassDeferred.cs` | — | 40个PassConstructors，合并GBuffer | 2.1 |
| 渲染图核心 `HGRenderGraph.cs` | — | 自定义DAG调度 | 2.2 |
| Pass构造 `PassConstructorFactory.cs` | — | 60种PassConstructorID映射 | 2.3 |
| Shaders | ~160 .shader | 14大类Shader | 2.4 |
| HGGraphicsCPPModule | 148 | C++原生桥接层，blittable structs + FreeFunction调用 | **6** |
| Rendering.Beyond | ~60 | 游戏层渲染扩展(实体VFX/VAT/Shader预热) | **7** |
| RuntimeQuality | 79 | 运行时质量控制系统(30+组件) | **8** |
| ScriptBridge | 7 | C#→原生管线桥接(IFix热补丁) | **9** |
| Logger | 5 | 渲染管线日志(IFix可热补丁) | **10** |
| UI.Beyond | ~20 | UI渲染组件(UISoftMask/GPUISystem) | **11** |
| Entry.Beyond | ~10 | 管线加载/初始化入口 | **12** |
| MagicaCloth | 214 | GPU ComputeShader布料物理 | **13** |
| Cinemachine(Beyond定制) | 132+ | 相机系统(HGDOFParams定制) | **13** |
| VolumetricLightBeam | ~30 | 体积光锥渲染 | **13** |
| PaintIn3D | ~50 | 3D纹理绘制 | **13** |

---

## 2. 管线核心模块

### 2.1 Rendering Path 体系

| 文件 | 核心逻辑 | 设计亮点/边界处理 |
|------|----------|-------------------|
| `HGRenderPathBase.cs:90` | 持有`List<IPassConstructor>`按序构建RenderGraph | `m_passConstructorMapping`通过NativeArray映射PassID→索引，支持Pass裁剪 |
| `HGRenderPathForward.cs:3-41` | 前向管线：26个PassConstructors，纯Forward渲染 | 带LightClustering+Binning做Tile光簇，ForwardPass内嵌LightCull |
| `HGRenderPathDefaultDeferred.cs:5-84` | 完整延迟管线：40个PassConstructors，GBuffer→Decal→DeferredLighting | 支持GPUDrivenCulling/HZB/DepthPyramid/GTAO/SSR全栈 |
| `HGRenderPathOnePassDeferred.cs:3-51` | 单Pass延迟：合并GBuffer写入为一次DrawCall | 优化TBDR架构GPU(mobile)，减少FrameBuffer带宽 |
| `HGRenderPathUI.cs` | 独立UI渲染路径，UIPass+UIPostProcess | 与主场景管线隔离，UI后处理单独走PostProcessMask |

### 2.2 Render Graph 系统

| 文件 | 核心逻辑 | 设计亮点/边界处理 |
|------|----------|-------------------|
| `HGRenderGraph.cs` | DAG编译：Pass依赖分析→资源生命周期管理→异步计算调度 | 自定义实现(未用Unity RenderGraph API)，支持AsyncCompute(KHR) |
| `HGRenderGraphPass.cs:12-50` | Pass基类：颜色/深度Attachment+读写资源列表+子Pass | `MAX_RENDER_FUNC_COUNT=4`限制每Pass最多4个渲染函数 |
| `HGRenderGraphPassRegular.cs` | 普通光栅化Pass执行 | 处理CBuffer绑定和渲染状态切换 |
| `HGRenderGraphPassNative.cs` | C++侧Pass执行桥接 | 调用`HGRenderPathCPP`本机代码 |
| `HGRenderGraphBuilder.cs` | Fluent API构建Pass：`AddRasterRenderPass/AddComputePass` | 链式API设计 |
| `TexturePool.cs` | RenderTexture池化管理 | LRU淘汰+版本号追踪，避免频繁创建释放 |
| `ComputeBufferPool.cs` | ComputeBuffer池 | 大小对齐+多帧复用 |

### 2.3 Pass Constructor 一览

| PassConstructorID | C# 文件 | 核心功能 | 绑定Shader |
|-------------------|---------|----------|------------|
| `BinningPass(1)` | `BinningPass.cs:7` | 光源/反射探针Tile Grid分簇(ComputeShader) | 内置Compute |
| `ReflectionProbeBinning(2)` | `ReflectionProbeBinningPassConstructor.cs` | 反射探针Frustum Culling分簇 | 内置Compute |
| `FoliageOccluder(3)` | `HGFoliageOccluderManager.cs` | 植被遮挡物渲染(高度图写入) | `foliageoccluder.shader` |
| `FoliageInteractive(4)` | `HGFoliageInteractiveManager.cs` | 植被交互压痕渲染 | `foliageinteractivecollider.shader` |
| `Sludge(5)` | `HGSludgeManager.cs` | 泥浆/液体表面变形 | `sludgev2.shader` |
| `GpuClothSimulation(6)` | `GpuClothManager.cs:12` | 布料模拟(ComputeShader+DrawMesh) | GpuClothSimulationPassConstructor内Compute |
| `LightClustering(7)` | `LightClusteringPassConstructor.cs:11` | 点光源/聚光灯分簇(ComputeShader) | 内置Compute |
| `GPUDrivenCulling(8)` | `GPUDrivenCullingPassConstructor.cs` | GPU驱动的Instance Culling | 内置Compute |
| `GPUParticleSimulation(9)` | `GPUParticleSystemManager.cs` | GPU粒子Simulation/Update | `GPUParticleShaders.cs`引用Compute |
| `ParticleLighting(10)` | `ParticleLightingPassConstructor.cs` | 粒子光照计算 | `vfxbasev2.shader`等 |
| `CustomDepthOnly(11)` | `CustomDepthOnlyRequestManager.cs` | 自定义深度渲染请求 | DepthOnly Pass |
| `ShadowMap(12)` | `ShadowMapPassConstructor.cs` | 方向光CSM+点光源Atlas+聚光灯 | `shadowblit.shader` |
| `Atmosphere(13)` | `HGAtmosphereRenderer.cs` | 大气散射(LUT烘焙+天空球) | `renderatmospherelut.shader`, `proceduralsky.shader` |
| `VolumetricFog(14)` | `HGVolumetricFogRenderer.cs` | 3D纹理体素化+散射积分 | `volumetricrenderer.shader`, `volumetriccompose.shader` |
| `BakeFogLut(15)` | `BakeFogLutPassConstructor.cs` | 雾LUT预烘焙 | `bakefoglut.shader` |
| `VolumetricCloud(16)` | `VolumetricCloudPassConstructor.cs` | 过程云+0xLightShaft | `volumetriccloudsdf.shader` |
| `TerrainDeform(17)` | `HGTerrainDeformManager.cs` | 地形变形(深度/密度Compute) | 内置Compute |
| `TerrainVTBake(18)` | `TerrainVTBakePassConstructor.cs` | VirtualTexture烘焙 | 内置Compute |
| `InkSimulation(19)` | `HGInkManager.cs` | 墨水模拟(扩散/混合) | `hginksimulation.shader` |
| `TerrainDepthPrepass(20)` | `TerrainDepthPrepassConstructor.cs` | 地形深度预Pass | `hgterrainps.shader`(DepthOnly Pass) |
| `DepthPrepass(21)` | `DepthPrepassConstructor.cs` | 场景深度预Pass(Z-prepass) | 不透明物体DepthOnly Pass |
| `Forward(22)` | `ForwardPassConstructor.cs` | 前向渲染(ForwardLit/ForwardOnly) | `litforward.shader`, `liteffect.shader`等 |
| `ForwardOpaque(23)` | `ForwardOpaquePassConstructor.cs` | 前向不透明(ForwardOpaque) | `litforward.shader` |
| `GBuffer(24)` | `GBufferPassConstructor.cs` | GBuffer写入(3RT+Depth) | `lit.shader`(GBuffer Pass), `hgterrainps.shader` |
| `Decal(25)` | `DecalPassConstructor.cs` | DBuffer贴花(法线/粗糙度/自发光) | `decallit.shader`, `decalunlit.shader` |
| `WaterSector(26)` | `WaterSectorRenderingPass.cs` | 水域区块渲染(分块LOD) | `waterrendering.shader`, `waterforwardrendering.shader` |
| `WaterInteraction(27)` | `WaterInteractionRenderingPass.cs` | 水交互涟漪(Simulate+HeightConvert) | `ripplesimulate.shader`, `rippleheightconvert.shader` |
| `WaterDefaultDeferred(28)` | `WaterDefaultDeferredRenderingPass.cs` | 水延迟光照合成 | 内置Shade |
| `WaterOnePassDeferred(29)` | `WaterOnePassDeferredRenderingPass.cs` | 水单Pass延迟光照 | 内置Shade |
| `HZB(30)` | `BuildHZBPass.cs` | Hierarchical Z-Buffer构建(深度下采样) | 内置Compute |
| `DepthPyramid(31)` | `DepthPyramidRenderingPass.cs` | 深度金字塔(ColorPyramid) | `colorpyramidps.shader` |
| `GTAO(32)` | `GTAOPassConstructor.cs` | Ground Truth Ambient Occlusion | 内置Compute |
| `FakePlanarReflection(33)` | `FakePlanarReflectionPass.cs` | 假平面反射(Draw场景镜像到RT) | `litforward.shader`(反射Pass) |
| `HyperScreenSpaceReflection(34)` | `HyperScreenSpaceReflectionRenderingPass.cs` | SSR：分层光追+时域复用+颜色金字塔 | `screenspacereflectionps.shader` |
| `HyperRayTracingReflection(35)` | RT反射 | 硬件光追反射(仅DX12) | `raytracingreflectionps.shader` |
| `ContactShadow(36)` | `ContactShadowPassConstructor.cs` | 接触阴影(SSAO风格) | `screenspaceshadowresolve.shader` |
| `CapsuleShadow(37)` | `HGCapsuleShadows.cs` | 胶囊体阴影(角色专用) | `capsuleshadowcaster.shader` |
| `ScreenSpaceShadowMask(38)` | `ScreenSpaceShadowMaskPassConstructor.cs` | 屏幕空间阴影Mask | `screenspaceshadowresolve.shader` |
| `DeferredLighting(39)` | `DeferredLightingPassConstructor.cs` | 延迟光照(逐像素光照Pass) | `deferredlighting.shader` |
| `Transparent(40)` | `TransparentPassConstructor.cs` | 透明渲染前向(无光照/透明DOF后) | `littransparent.shader`, `liteffectblend.shader` |
| `OnePassDeferred(41)` | `OnePassDeferredPassConstructor.cs` | 单Pass延迟(合并GBuffer+Lighting) | 内置Shader |
| `Distortion(42)` | `DistortionPassConstructor.cs` | 扭曲效果渲染(合并+应用) | 内置Blit |
| `LightShaft(43)` | `LightShaftPassConstructor.cs` | 体积光栅(降采样+径向模糊+合成) | `hglightshaft.shader` |
| `LightShaftApply(44)` | `LightShaftApplyPassConstructor.cs` | 光栅合成到场景 | `hglightshaft.shader` |
| `Parafin(45)` | `ParafinPassConstructor.cs` | 石蜡效果(光泽涂层) | 内置Blit |
| `DepthOfField(46)` | `DepthOfFieldPassConstructor.cs` | 景深(CoC/Hexagonal/Mobile三种模式) | `hgdepthoffield.shader`等 |
| `MotionBlur(47)` | `MotionBlurPassConstructor.cs` | 运动模糊(速度Buffer) | `HGMotionBlur.cs`内置 |
| `TransparentAfterDOF(48)` | `TransparentAfterDOFPassConstructor.cs` | DOF后透明渲染 | `littransparent.shader` |
| `TAAU(49)` | `TAAUPassConstructor.cs` | 时序抗锯齿+上采样(抖动/历史钳制/Feedback) | `taauresolve.shader` |
| `MetalFXTemporal(50)` | `MetalFXTemporalPassConstructor.cs` | Apple MetalFX时序上采样 | MetalFX原生API |
| `LensFlare(51)` | `LensFlarePassConstructor.cs` | 镜头光晕(数据驱动) | `lensflaredatadriven.shader` |
| `UberPost(52)` | `PostProcessPassConstructor.cs` | 后处理合成Bloom/ColorGrading/Sharpen | `uberpost.shader`, `bloom.shader` |
| `MetalFXSpatial(53)` | `MetalFXSpatialPassConstructor.cs` | Apple MetalFX空间上采样 | MetalFX原生API |
| `UIPP(54)` | `UIPostProcessConstructor.cs` | UI后处理(Blur/Bloom等) | `uiimageblur.shader` |
| `UI(55)` | `UIPassConstructor.cs` | UI场景渲染 | Unlit/UI Shader |
| `Multiblur(56)` | `MultiblurPassConstructor.cs` | 多级模糊(用于磨砂玻璃等) | `frostedglassblur.shader` |
| `ScreenSpaceOverlay(57)` | `ScreenSpaceOverlayPassConstructor.cs` | 屏幕空间覆盖层 | 内置Blit |
| `WetnessMaskPass(58)` | 湿Mask Pass | 潮湿/雨水Mask生成 | `wetnessdecal.shader` |
| `SetFinalTarget(59)` | `SetFinalTargetPassConstructor.cs` | 设置最终渲染目标(Blit到BackBuffer) | `finalpass.shader` |

### 2.4 Shader 分类与对应

| Shader路径 | 对应C# | 说明 |
|------------|--------|------|
| `materials/lit/lit.shader` | `GBufferPassConstructor` | 主Lit Shader (GBuffer Pass) |
| `materials/lit/litforward.shader` | `ForwardPassConstructor` | 主Lit Shader (Forward Pass) |
| `materials/lit/lithlod.shader` | LOD | HLOD Shader |
| `materials/lit/liteffect.shader` | `ForwardPassConstructor` | VFX效果Shader |
| `materials/lit/liteffectblend.shader` | `TransparentPassConstructor` | VFX效果混合Shader |
| `materials/lit/littransparent.shader` | `TransparentPassConstructor` | 透明Shader |
| `materials/characternpr/characternpr.shader` | Character/Skin/Hair | 角色NPR主Shader |
| `materials/characternpr/characternpr_skin.shader` | 皮肤SSS | 皮肤次表面散射NPR |
| `materials/characternpr/characternpr_hair.shader` | 头发各向异性 | 头发Kajiya-Kay高光 |
| `materials/characternpr/characternpr_eye.shader` | 眼睛 | 眼睛虹膜/角膜渲染 |
| `materials/characternpr/characternpr_liquidag.shader` | 液体AG | 角色液体效果 |
| `materials/characternpr/characternpr_overlayshadow.shader` | 覆盖阴影 | 角色叠加阴影 |
| `materials/characternpr/characternpr_shadowreceiver.shader` | 阴影接收 | 角色阴影接收 |
| `materials/characternpr/characternpr_proxylod.shader` | ProxyLOD | 角色代理LOD |
| `materials/terrain/hgterrainps.shader` | `TerrainDepthPrepassConstructor`, `GBufferPassConstructor` | 主地形Shader |
| `materials/terrain/terraindecallit.shader` | 地形Decal | 地形贴花Lit |
| `materials/terrain/terraindecalsplinelitv2.shader` | 地形Decal | 地形Spline贴花 |
| `materials/terrain/hgterraindepthresolve.shader` | 深度Resolve | 地形深度解析 |
| `materials/water/litwater.shader` | `WaterSectorRenderingPass` | 水域Lit Shader(带焦散/SSR) |
| `materials/water/waterrendering.shader` | `WaterSectorRenderingPass` | 水域渲染Pass(延迟) |
| `materials/water/waterforwardrendering.shader` | `WaterSectorRenderingPass` | 水域渲染Pass(前向) |
| `materials/water/waterproxy.shader` | Proxy | 水域代理Mesh |
| `materials/water/waterdecal.shader` | `WaterDecal` | 水Decal |
| `materials/water/wetnessdecal.shader` | `WetnessMaskPass` | 湿Decal |
| `materials/water/wetnesstrail.shader` | 湿拖尾 | 潮湿拖尾轨迹 |
| `materials/water/ripplesimulate.shader` | `WaterInteractionRenderingPass` | 涟漪模拟Compute |
| `materials/water/rippleheightconvert.shader` | `WaterInteractionRenderingPass` | 涟漪高度转换 |
| `materials/water/ripplerange.shader` | 涟漪范围 | 涟漪传播范围 |
| `materials/water/watertextureprocessps.shader` | 纹理处理 | 水纹理处理 |
| `materials/foliage/grass.shader` | 草地 | 草渲染 |
| `materials/foliage/grassbillboardlod.shader` | 草BillboardLOD | 草Billboard LOD |
| `materials/foliage/grasscardmeshlod.shader` | 草CardMeshLOD | 草CardMesh LOD |
| `materials/foliage/leaf.shader` | 树叶 | 树叶渲染 |
| `materials/foliage/treefoliagebillboardlod.shader` | 树BillboardLOD | 树冠Billboard LOD |
| `materials/foliage/treefoliagecardmeshlod.shader` | 树CardMeshLOD | 树冠CardMesh LOD |
| `materials/foliage/foliageinteractivecollider.shader` | `FoliageInteractivePassConstructor` | 植被交互碰撞体渲染 |
| `materials/foliage/foliageoccluder.shader` | `FoliageOccluderPassConstructor` | 植被遮挡高度图写入 |
| `materials/decal/decallit.shader` | `DecalPassConstructor` | DBuffer贴花Lit |
| `materials/decal/decalunlit.shader` | `DecalPassConstructor` | DBuffer贴花Unlit |
| `materials/decal/vfxdecal.shader` | VFX贴花 | VFX贴花渲染 |
| `materials/decal/vfxdecalprojector.shader` | VFX投影贴花 | VFX投影贴花 |
| `materials/decal/decalerosionvolume.shader` | 腐蚀体积 | 贴花腐蚀体积 |
| `materials/effect/vfxbasev2.shader` | 粒子基础 | VFX粒子基础渲染 |
| `materials/effect/vfxadvance.shader` | 粒子高级 | VFX粒子高级渲染 |
| `materials/effect/vfxbasebatched.shader` | 粒子Batch | VFX粒子Batch渲染 |
| `materials/effect/vfxditheralpha.shader` | 粒子Dither | VFX粒子Dither透明 |
| `materials/effect/vfxrefract.shader` | 粒子折射 | VFX粒子折射 |
| `materials/effect/vfxice.shader` | 冰 | 冰面效果 |
| `materials/effect/vfxwater.shader` | 水效果 | VFX水效果 |
| `materials/effect/vfxsmoke_sixway.shader` | 六向烟雾 | 六方向烟雾VAT渲染 |
| `materials/effect/vfxsmoke_vat.shader` | 烟雾VAT | 烟雾顶点动画纹理渲染 |
| `materials/effect/vfxline.shader` | 线条 | VFX线条渲染 |
| `materials/effect/vfxradialblur.shader` | 径向模糊 | VFX径向模糊 |
| `materials/effect/vfxskillscanline.shader` | 技能扫描线 | 技能扫描线特效 |
| `materials/effect/vfxskillscanlinehighlight.shader` | 技能扫描线高亮 | 技能扫描线高亮特效 |
| `materials/effect/vfxcharacteroutline.shader` | 角色描边 | 角色轮廓描边 |
| `materials/effect/vfxcharacterwallhack.shader` | 角色透视 | 角色透视/穿墙 |
| `materials/effect/vfxcharactergrowing.shader` | 角色生长 | 角色溶解/生长 |
| `materials/effect/vfxdswrite.shader` | 深度模板写入 | 深度模板写入特效 |
| `materials/effect/vfxcapturemesh.shader` | Mesh捕获 | Mesh捕获特效 |
| `materials/effect/vfxscenecoloradjustment.shader` | 场景颜色调整 | 场景颜色调整特效 |
| `materials/effect/vfxreflectionpass.shader` | 反射Pass | 特效反射Pass |
| `materials/effect/sludge/sludgev2.shader` | `SludgePassConstructor` | 泥浆渲染 |
| `materials/effect/sludge/dynamicsludgeblit.shader` | 动态泥浆Blit | 动态泥浆处理 |
| `materials/effect/containerwater/vfxcontainerwater.shader` | 容器水 | 容器内水体效果 |
| `materials/effect/fakefog/vfxfakevolumefog.shader` | 假体积雾 | VFX假体积雾 |
| `materials/effect/factory/vfxbasefactory.shader` | 工厂效果 | VFX工厂动画 |
| `materials/unlit/unlit.shader` | 无光照 | 无光照基础Shader |
| `materials/unlit/unlitsubshaderlod.shader` | UnlitLOD | 无光照LOD |
| `materials/screenemotion/screenemotion.shader` | 屏幕表情 | 屏幕表情动画 |
| `materials/cutsceneeffect/cutsceneeffect.shader` | 过场效果 | 过场黑边/特效 |
| `materials/blockout/litpoly.shader` | Blockout | Blockout材质 |
| `materials/blockout/litpolytriplanar.shader` | Blockout三面映射 | Blockout三面映射 |
| `materials/rain/farrain.shader` | 远距离雨 | 远距离雨粒子 |
| `materials/rain/rainsplash.shader` | 雨溅射 | 雨水溅射粒子 |
| `materials/rain/sceneeffectrain.shader` | 场景雨效 | 场景雨水效果 |
| `materials/rain/screenraindropfx.shader` | 屏幕雨滴 | 屏幕雨滴FX |
| `materials/volumetriclightbeam/vlbgeneratedshader.shader` | 体积光束 | 体积光锥动态生成 |
| `materials/uieffect/uiframeeffect.shader` | UI框效果 | UI框架特效 |
| `lighting/deferredlighting.shader` | `DeferredLightingPassConstructor` | 延迟光照计算 |
| `lighting/deferredlightingperlight.shader` | 逐光源光照 | 延迟逐光源光照 |
| `lighting/deferredlightingwritealpha.shader` | Alpha写入 | 延迟光照Alpha通道 |
| `lighting/shadowblur.shader` | `ShadowMapPassConstructor` | 阴影PCF滤波Blur |
| `lighting/shadow/capsuleshadowcaster.shader` | `CapsuleShadowPassConstructor` | 胶囊体阴影Caster |
| `lighting/shadow/lowresdirectionalshadow.shader` | `HGLowResDirectionalShadowPass` | 低分率方向光阴影 |
| `lighting/shadow/screenspaceshadowresolve.shader` | `ScreenSpaceShadowMaskPassConstructor` | 屏幕空间阴影解析 |
| `lighting/shadow/shadowblit.shader` | `ShadowMapPassConstructor` | 阴影Blit |
| `lighting/shadow/shadowclear.shader` | `ShadowMapPassConstructor` | 阴影Clear |
| `lighting/shadow/visibilitysh.shader` | 可见性SH | 球谐可见性阴影 |
| `lighting/ssr/screenspacereflectionps.shader` | `HyperScreenSpaceReflectionRenderingPass` | 屏幕空间反射Pass |
| `postprocessing/bloom/bloom.shader` | `PostProcessPassConstructor` | Bloom Pass |
| `postprocessing/uberpost.shader` | `PostProcessPassConstructor` | Uber后处理合成(ACES/ColorGrading/LUT) |
| `postprocessing/finalpass.shader` | `SetFinalTargetPassConstructor` | 最终Blit到BackBuffer |
| `postprocessing/dof/hgdepthoffield.shader` | `DepthOfFieldPassConstructor` | 景深(CoC+Filter+合成) |
| `postprocessing/dof/hgdepthoffieldhexagonal.shader` | `DepthOfFieldPassConstructor` | 六边形Bokeh景深 |
| `postprocessing/dof/hgdepthoffieldmobile.shader` | `DepthOfFieldPassConstructor` | 移动端简化景深 |
| `postprocessing/taau/taauresolve.shader` | `TAAUPassConstructor` | TAAU解析 |
| `postprocessing/taau/taaudilation.shader` | `TAAUPassConstructor` | TAAU膨胀 |
| `postprocessing/taau/taaumaskdilation.shader` | `TAAUPassConstructor` | TAAU Mask膨胀 |
| `postprocessing/smaa/smaa.shader` | SMAA | 几何抗锯齿 |
| `postprocessing/anamorphicstreaks/anamorphicstreaks.shader` | `HGAnamorphicStreaks` | 变形光晕 |
| `postprocessing/lightshaft/hglightshaft.shader` | `LightShaftPassConstructor` | 体积光 |
| `postprocessing/lensflaredatadriven.shader` | `LensFlarePassConstructor` | 数据驱动镜头光晕 |
| `postprocessing/lutbuilder2d.shader` | `PostProcessPassConstructor` | LUT 2D烘焙 |
| `postprocessing/sharpen.shader` | `PostProcessPassConstructor` | 锐化 |
| `postprocessing/frostedglassblur.shader` | `MultiblurPassConstructor` | 磨砂玻璃模糊 |
| `postprocessing/uiimageblur.shader` | `UIPostProcessConstructor` | UI图像模糊 |
| `postprocessing/blitbackbuffer.shader` | 后处理Blit | 后处理Blit回Buffer |
| `environment/atmosphere/renderatmospherelut.shader` | `HGAtmosphereRenderer` | 大气散射LUT烘焙 |
| `environment/atmosphere/volumetriclocalfog.shader` | `HGVolumetricLocalFog` | 局部体积雾 |
| `environment/atmosphere/bakefoglut.shader` | `BakeFogLutPassConstructor` | 雾LUT烘焙 |
| `environment/atmosphere/fogsimple.shader` | `FakeFogSimple` | 简单雾渲染 |
| `environment/sky/proceduralsky.shader` | `HGSkyRenderer` | 过程天空(1001+变体) |
| `environment/sky/skyboxcubemap.shader` | Skybox | CubeMap天空盒 |
| `environment/sky/skydomestardrawer.shader` | `HGSkydomeStarRenderer` | 星空绘制 |
| `environment/sky/skydomestarrt.shader` | `HGSkydomeStarRenderer` | 星空RT |
| `environment/sky/proceduralringdrawer.shader` | 光环 | 程序化光环/行星环 |
| `environment/sky/cloudcard.shader` | 云卡片 | 云卡片渲染 |
| `environment/sky/mattepainting.shader` | 遮罩绘景 | 遮罩背景绘景 |
| `volumetric/volumetricrenderer.shader` | `HGVolumetricFogRenderer` | 体积雾渲染(体素化+散射) |
| `volumetric/volumetriccompose.shader` | `HGVolumetricFogRenderer` | 体积雾合成 |
| `volumetric/volumetriccloudsdf.shader` | `VolumetricCloudPassConstructor` | 体积云SDF March |
| `volumetric/sdf/raymarchsdf.shader` | SDF | SDF光线步进 |
| `volumetric/sdf/previewsdf.shader` | SDF预览 | SDF预览 |
| `interaction/hgdecalinteraction.shader` | `HGDecalInteration` | 交互Decal(脚印/痕迹) |
| `interaction/hginksimulation.shader` | `InkSimulationPassConstructor` | 墨水模拟 |
| `interaction/hgdrawinteractionnode.shader` | `HGInteractionNode` | 交互节点渲染 |
| `cloth/clothtrishader.shader` | 布料三角 | 三角网格布料渲染 |
| `cloth/clothlineshader.shader` | 布料线 | 线性布料渲染 |
| `particles/physicalparticlerender.shader` | 物理粒子 | Physical Particle渲染 |
| `debug/*.shader` | `HGDebugRenderManager` | Debug Gizmos/Display/ReflectionProbe |
| `utils/blit.shader` | 全屏工具 | 通用Blit |
| `utils/blur.shader` | 模糊工具 | 通用高斯模糊 |
| `utils/copydepthbuffer.shader` | `CopyTexturePass` | 深度拷贝 |
| `utils/copystencilbuffer.shader` | 模板拷贝 | 模板拷贝 |
| `utils/cleardepth.shader` | 深度清理 | 深度清空 |
| `utils/clearstencilbuffer.shader` | 模板清理 | 模板清空 |
| `utils/colorpyramidps.shader` | `DepthPyramidRenderingPass` | 颜色金字塔 |
| `utils/lowresblit.shader` | 低分率Blit | 低分率Blit工具 |
| `utils/vsmpass.shader` | VSM | 方差阴影映射 |
| `utils/fontsdf.shader` | SDF字体 | SDF字体渲染 |
| `utils/frameinterpolationinputconvert.shader` | 帧插值 | 帧插值输入转换 |
| `utils/ftcubemap2strip.shader` | CubeMap转Strip | CubeMap=>条带 |
| `utils/cubetopano.shader` | Cube转全景 | CubeMap=>全景图 |
| `raytracing/reflection/raytracingreflectionps.shader` | `HyperRayTracingReflection` | 硬件光追反射 |

---

## 3. 核心算法

| 路径:行号 | 算法/公式 | 本质描述 |
|-----------|-----------|----------|
| `GBufferOutput.cs:3` | GBuffer A=NORMAL+B, B=ALBEDO+AO, C=METALLIC+ROUGHNESS+EMISSION | 3RT GBuffer打包(类COD延迟) |
| `BinningPass.cs:8` | Tile Grid分簇 (ComputeShader) | 屏幕Tile划分→光源分配到Tile(类似Tiled Forward/Deferred) |
| `LightClusteringPassConstructor.cs:13` | 光源距离+优先级排序 | 按距离和优先级排序点点光源，前N盏可见 |
| `GTAOPassConstructor.cs` | Ground Truth AO (GTAO) | 球面方向重要性采样+Hilbert排序 |
| `HyperScreenSpaceReflectionRenderingPass.cs` | 分层光线步进+时域复用 | 分层光线步进(Hi-Z)→颜色金字塔→Temporal滤波 |
| `DepthPyramidRenderingPass.cs` | 深度/颜色Mip金字塔 | 2x2 Min/Max下采样构建深度金字塔 |
| `BuildHZBPass.cs` | Hierarchical Z-Buffer | 视锥体裁剪+GPU Occlusion |
| `TAAUPassConstructor.cs` | TAAU (Temporal AA + Upsampling) | 子像素抖动→历史帧Clamp→反馈 |
| `DepthOfFieldPassConstructor.cs:172-178` | 六边形Bokeh DOF | CoC计算→Tiled Filter→Hex Bokeh blur→合成 |
| `HGVolumetricFogRenderer.cs` | 体积散射积分 (Ray Marching) | 3D纹理体素化→各向异性相位函数→散射积分 |
| `VolumetricCloudPassConstructor.cs` | 过程云SDF Marching | Perlin/Worley噪声→SDF光线步进 |
| `HGAtmosphereRenderer.cs` | 大气散射 LUT (Bruneton) | 基于物理的瑞利/Mie散射+LUT预烘焙 |
| `HGDeferredShadingModel.cs` | GGX + Smith + Disney Diffuse | Cook-Torrance BRDF(GGX法线分布) |
| `FoliageInteractivePassConstructor.cs` | 高度图碰撞变形 | 角色碰撞→高度图写入→草地弯曲 |
| `HGSludgeManager.cs` | 泥浆/液体高度场 | 液体表面网格变形+位移 |
| `GPUDrivenCullingPassConstructor.cs` | GPU Instance Frustum/Occlusion Cull | ComputeShader逐Instance视锥剔除+遮挡剔除 |
| `HGCapsuleShadows.cs` | 胶囊体阴影映射 | 胶囊体近似→圆柱/球体阴影投射 |
| `InkSimulationPassConstructor.cs` | 墨水扩散/混合 | 基于流体的墨水模拟(Jump Flood) |

---

## 4. 数据流

### 4.1 主渲染管线流程 (HGRenderPipeline)

```
[HGRenderPipeline.Render()]
  │
  ├─ BeginContextRendering()
  │    ├─ HGEnvironmentManager.PipelineUpdate()    // 环境Volume更新
  │    ├─ HGASMManager.PipelineUpdate()             // ASM虚拟纹理更新
  │    ├─ IVManager.PipelineUpdate()                // Irradiance Volume更新
  │    ├─ TerrainDeformManager.PipelineUpdate()     // 地形变形更新
  │    └─ GpuClothManager.PipelineUpdate()          // GPU布料更新
  │
  ├─ ForEach Camera (RenderRequest):
  │    ├─ HGCamera.CreateAndUpdate()
  │    ├─ CalculateCullingParameters()
  │    ├─ CullResults.Cull()                        // Unity内置Culling
  │    ├─ ECS Culling()
  │    ├─ Terrain/Water Culling()
  │    │
  │    └─ HGRenderPathBase.Render()
  │         │
  │         ├─ [PreRendering]  OnPreRendering()
  │         │    ├─ BinningPass                     // 光源Tile分簇
  │         │    ├─ ReflectionProbeBinning           // 探针Tile分簇
  │         │    ├─ FoliageOccluder                  // 植被遮挡渲染
  │         │    ├─ FoliageInteractive               // 植被交互
  │         │    ├─ Sludge                           // 泥浆模拟
  │         │    ├─ GpuClothSimulation               // 布料模拟
  │         │    ├─ LightClustering                 // 光源聚类
  │         │    ├─ GPUDrivenCulling                 // GPU驱动Culling
  │         │    ├─ GPUParticleSimulation            // 粒子模拟
  │         │    ├─ ParticleLighting                 // 粒子光照
  │         │    ├─ CustomDepthOnly                  // 自定义深度
  │         │    ├─ ShadowMap                        // 阴影渲染
  │         │    ├─ Atmosphere/Sky                   // 大气、天空
  │         │    ├─ VolumetricFog/BakeFogLut        // 体积雾+LUT
  │         │    ├─ VolumetricCloud                  // 体积云
  │         │    ├─ TerrainDeform/VTBake             // 地形变形+VT
  │         │    └─ InkSimulation                    // 墨水模拟
  │         │
  │         ├─ [Rendering]  HGRenderGraph.Execute()
  │         │    │
  │         │    ├─ [Depth Prepass]
  │         │    │    ├─ TerrainDepthPrepass         // 地形深度
  │         │    │    └─ DepthPrepass                 // 不透明深度(Z-prepass)
  │         │    │
  │         │    ├─ [Opaque Geometry]
  │         │    │    ├─ GBufferPass                  // GBuffer A/B/C/Depth (延迟)
  │         │    │    ├─ DecalPass                    // DBuffer贴花
  │         │    │    ├─ WaterSectorRendering         // 水域区块
  │         │    │    ├─ WaterInteraction             // 水交互涟漪
  │         │    │    ├─ HZB / DepthPyramid           // HZB+深度锥体
  │         │    │    ├─ GTAO                         // 环境AO
  │         │    │    ├─ SSR (SSR / RT)              // 屏幕空间/光追反射
  │         │    │    ├─ ContactShadow/CapsuleShadow // 接触阴影+胶囊体阴影
  │         │    │    ├─ ScreenSpaceShadowMask        // 屏幕阴影Mask
  │         │    │    ├─ DeferredLighting             // 延迟光照(逐像素)
  │         │    │    ├─ ForwardOpaque                // 前向不透明(LightLink)
  │         │    │    └─ FakePlanarReflection         // 假平面反射
  │         │    │
  │         │    ├─ [Transparent]
  │         │    │    ├─ Transparent                  // 透明渲染
  │         │    │    ├─ VolumetricFogCompose         // 体积雾合成
  │         │    │    ├─ LightShaft                   // 体积光
  │         │    │    └─ Distortion                   // 扭曲+合成
  │         │    │
  │         │    ├─ [PostProcessing]
  │         │    │    ├─ DepthOfField                 // 景深
  │         │    │    ├─ TransparentAfterDOF          // DOF后透明
  │         │    │    ├─ MotionBlur                   // 运动模糊
  │         │    │    ├─ TAAU / MetalFX              // 时序抗锯齿+上采样
  │         │    │    ├─ LensFlare                    // 镜头光晕
  │         │    │    └─ UberPost                     // 最终后处理
  │         │    │         ├─ AutoExposure
  │         │    │         ├─ Bloom
  │         │    │         ├─ ColorGrading + LUT
  │         │    │         ├─ Sharpen
  │         │    │         └─ FinalBlit
  │         │    │
  │         │    └─ [UI / Overlay]
  │         │         ├─ UIPostProcess
  │         │         ├─ UI
  │         │         └─ ScreenSpaceOverlay
  │         │
  │         └─ [PostRendering] OnPostRendering()
  │
  └─ EndContextRendering()
```

### 4.2 中间产物

| 产物 | 类型 | 生产者 | 消费者 |
|------|------|--------|--------|
| BinningBuffer | ComputeBuffer | `BinningPass` | `LightClusteringPassConstructor` |
| ShadowAtlas | Texture2DArray | `ShadowMapPassConstructor` | `DeferredLightingPassConstructor`, `ForwardPassConstructor` |
| GBuffer A/B/C | RenderTexture | `GBufferPassConstructor` | `DeferredLightingPassConstructor` |
| DBuffer | RenderTexture | `DecalPassConstructor` | `DeferredLightingPassConstructor` |
| HZB | Texture2D | `BuildHZBPass` | `GPUDrivenCullingPassConstructor` |
| DepthPyramid | Texture2D | `DepthPyramidRenderingPass` | `GTAOPassConstructor`, `SSR` |
| SceneColor/Copied | RenderTexture | `CopyTexturePass` | `SSR`, `PostProcessPassConstructor` |
| MotionVectors | RenderTexture | `BlitMotionVector` | `TAAUPassConstructor`, `MotionBlurPassConstructor` |
| VolumetricFog3D | RenderTexture3D | `HGVolumetricFogRenderer` | `VolumetricFogPassConstructor` |
| FogLUT | Texture3D | `BakeFogLutPassConstructor` | `ForwardPassConstructor` |
| WaterRippleBuffer | RenderTexture | `WaterInteractionRenderingPass` | `WaterSectorRenderingPass` |
| FoliageInteractionMask | RenderTexture | `FoliageInteractivePassConstructor` | `Foliage` Shaders |
| InkSimulationBuffer | RenderTexture | `InkSimulationPassConstructor` | Interaction Shaders |
| TAAUHistory | RenderTexture | `TAAUPassConstructor` | `TAAUPassConstructor`(递归) |
| GTAO | RenderTexture | `GTAOPassConstructor` | `DeferredLightingPassConstructor` |
| Exposure | Parameter | `HGAutoExposure` | `UberPost` |
| ColorGradingLUT | Texture3D | `PostProcessPassConstructor` | `UberPost` |

### 4.3 C++原生层数据流

通过 `HGGraphicsCPPModule` 每帧以 unsafe 指针零拷贝传递到 C++ 引擎：

```
C# 侧填充 Structs → 取指针 → [FreeFunction] 调用 C++
                        │
                        ├─ HGRenderPath_BeforeCulling(HGRenderPathParamsCPP*)
                        │    ├─ HGRenderPathBeforeCullingParamsCPP* (LOD/光源/阴影)
                        │    ├─ HGViewConstantsCPP* (Camera矩阵)
                        │    └─ HGRenderPathOtherData* (TAA抖动/时间/风/雨)
                        │
                        └─ HGRenderPath_Render(HGRenderPathParamsCPP*)
                             ├─ HGSettingParametersCpp* (130+质量开关)
                             ├─ HGEnvironmentPhaseCPP* (所有环境配置)
                             └─ HGVolumeComponentsDataCPP* (所有后处理Volume)
```

核心每帧数据 Structs:

| Struct | 字段数 | 包含内容 |
|--------|--------|---------|
| `HGRenderPathParamsCPP` | ~70+ | 设备类型/尺寸/后处理flags/Manager指针/所有Input指针 |
| `HGSettingParametersCpp` | ~130+ | 每个Feature的enable+可调参数(TAAU/DLSS/FSR3/Bloom/DOF/阴影/SSR/GTAO/体积雾等) |
| `HGRenderPathOtherData` | ~200+ | TAA抖动/时间/角色参数/VFX参数/风/雨/Water交互/indirection纹理 |
| `HGViewConstantsCPP` | 矩阵组 | view/proj/viewProj/抖动/前一帧 |
| `ShaderVariablesGlobal` | 全局 | 前一帧矩阵/时间/屏幕参数/雾/角色/风/地形/IV/水/雨 |

---

## 5. 关键决策

### 5.1 自研 RenderGraph (非 Unity SRP RenderGraph)
- **选择**: 从零实现`HGRenderGraph`，未使用Unity 2022+内置RenderGraph API
- **原因**: 需要支持`IFix`热修补、自定义AsyncCompute调度、Native(C++) Pass桥接
- **替代方案**: Unity `RenderGraph` API、Unity `RenderPipeline` 原生API
- **亮点**: 支持`RendererListHandle`粒度的Pass Culling、子Pass依赖链

### 5.2 双重渲染路径 (Forward + Deferred)
- **选择**: 同时维护 Forward、DefaultDeferred、OnePassDeferred 三条路径
- **原因**: 目标平台覆盖PC(Deferred)、Mobile(OnePassDeferred)、兼容性(Forward)
- **替代方案**: 单一Deferred+Fallback Forward
- **边界**: OnePassDeferred针对TBDR架构(Mali/Adreno)优化GBuffer带宽

### 5.3 GPUDriven Culling
- **选择**: ComputeShader实现GPU Instance Frustum+Occlusion Culling
- **原因**: CPU Culling瓶颈 → 利用GPU并行能力处理巨量Instance(草/树/粒子)
- **替代方案**: Unity `Graphics.DrawMeshInstancedIndirect` + CPU Culling
- **亮点**: HZB(Hierarchical Z-Buffer)辅助遮挡剔除

### 5.4 自定义GBuffer布局
- **选择**: 3RT+Depth(=4张)，GBufferA=法线+B，GBufferB=Albedo+AO，GBufferC=金属度+粗糙度+自发光
- **原因**: 在带宽和质量间做折中
- **替代方案**: Unity URP 2RT, Unity HDRP 5RT+, COD MW 4RT
- **注意**: 仅4张RT意味着需要额外的DBuffer(贴花)和ShadowMask

### 5.5 IL2CPP + IFix 热修补
- **选择**: 全量IL2CPP构建 + IFix拦截关键方法实现热更新
- **原因**: 手游需要热更新C#代码，IL2CPP不支持原生热更
- **替代方案**: `HybridCLR`(Wolong)、`Mono`JIT(性能差)
- **代价**: 代码被混淆无法直接阅读源码(方法体显示为IL2CPP汇编)

### 5.6 ECS 渲染列表
- **选择**: Unity ECS管理渲染对象列表(`m_deferredOpaqueECSList:uint`)
- **原因**: 比NativeArray/List更高效的CPU遍历+并行Job
- **替代方案**: `RendererListHandle`、`ScriptableRenderContext.DrawRenderers`
- **亮点**: ECS List与GPUDriven Culling结合传递Handle

### 5.7 1+3阴影方案 (CSM + Punctual + Capsule + Contact)
- **选择**: 级联方向光阴影(CSM) + 点/聚光灯阴影Atlas + 胶囊体角色阴影 + 屏幕空间接触阴影 四层叠加
- **原因**: 角色需要高精度长距离阴影(胶囊体)，场景间隙用接触阴影补充
- **替代方案**: 统一ShadowAtlas + PCSS滤波
- **亮点**: `HGCapsuleShadows`将角色近似为胶囊体投射独立阴影

### 5.8 体积雾/云/大气分离
- **选择**: 体积雾(3D纹理体素化) + 体积云(SDF March) + 大气(LUT烘焙) 三个独立Pass
- **原因**: 三者物理尺度不同(大气无限远/云中距/雾近距)，对不同渲染目标
- **替代方案**: Unified Volumetric System(Horizon Zero Dawn方案)
- **亮点**: 大气预烘焙LUT大大降低运行时开销

### 5.9 水系统 V2
- **选择**: 水域按Sector分块Tessellation + 交互涟漪模拟 + 焦散 + SSR反射
- **原因**: 开放世界大面积水域需要LOD分块
- **替代方案**: 单张水面Quad + 顶点动画
- **亮点**: `waterproxy.shader`代理Mesh遮挡查询

### 5.10 后处理 TAAU + MetalFX 双栈
- **选择**: 自研TAAU + Apple MetalFX(空间+时序)
- **原因**: 覆盖全平台(iOS MetalFX + Android/PC TAAU)
- **替代方案**: FSR2.0、DLSS(仅NVIDIA)
- **亮点**: TAAU包含MaskDilation减少运动物体拖影

### 5.11 HLSL 变体管理
- **选择**: 每个.shader有数十甚至上百个.hlsl变体文件(如proceduralsky有Sub0_Pass0_Fragment_b1001~1061)
- **原因**: IL2CPP+宏组合暴力生成变体避免运行时条件分支
- **替代方案**: `#pragma multi_compile` 统一管理
- **代价**: ShaderLab文件巨大，变体膨胀

### 5.12 IniParser (非Unity ScriptableObject)
- **选择**: 项目保有完整INI解析器用于配置加载
- **原因**: 可能需要从外部配置文件读取渲染参数(非Unity Editor工作流)
- **替代方案**: `ScriptableObject` + `JsonUtility`
- **亮点**: 支持Section/Key-Value/注释

### 5.13 数学库自研
- **选择**: `HgMath`包含Barycentric/CellGrid/MurmurHash3等
- **原因**: 补充Unity.Mathematics未提供的算法(重心坐标+哈希)
- **替代方案**: 使用Unity.Mathematics完整版

### 5.14 源码生成器 (SourceGenerator)
- **选择**: `Beyond/SourceGenerator/`包含自定义属性源生成器
- **原因**: 减少Unity手动Inspector绑定代码
- **文件**: `AnimatorBlackboardAttribute.cs`, `CameraControlConfigAttribute.cs`, `DataNAttribute.cs`, `ECSComponentAttribute.cs`

### 5.15 C++ Native Bridge 架构 (补充)
- **选择**: 将渲染管线核心性能路径下沉到C++，C#仅做数据编排
- **架构**: `HGGraphicsModule`(C#逻辑层) → `HGGraphicsCPPModule`(blittable数据定义层) → C++ Native Engine
- **数据传递**: 所有 Struct 用 unsafe 指针零拷贝传递，帧临时数据通过 `AllocateTempFromCSharp` 分配
- **亮点**: 148个blittable struct完全对齐C++内存布局，可验证无封送开销

### 5.16 运行时质量控制系统 (补充)
- **选择**: 基于设备GPU/CPU/RAM检测+JSON配置文件驱动质量等级
- **数据流**: GZip压缩的JSON→DeviceInfo→DeviceMatchRules(GPU正则)→DeviceQualityMap→QualityTierComponent
- **亮点**: 30+个独立QualityComponent，每个可单独OverrideFeatureTier或SettingParameter
- **覆盖**: ShadowMap/SSR/ContactShadow/GTAO/Fog/Cloud/Bloom/DOF/MotionBlur/DLSS/FSR3/FrameGen等

---

## 6. UnityEngine.HGGraphicsCPPModule

**路径**: `Assets/Scripts/UnityEngine.HGGraphicsCPPModule/`
**文件数**: 148 个 `.cs`
**命名空间**: `UnityEngine.HyperGryphEngineCode`
**角色**: HG Render Pipeline 的 **C++ 原生桥接层** — 定义C#→C++的**内存布局(blittable structs)**和**调用入口**。

### 6.1 架构定位

```
HGGraphicsModule  (C# 逻辑层: Volume组件/渲染逻辑)
       │
HGGraphicsCPPModule  (C# 互斥层: 内存布局定义 + [FreeFunction]调用)
       │
C++ Native Engine  (Modules/HGGraphicsCPP/Public/)
```

### 6.2 HGRenderGraphCPP — 核心入口

所有 `[FreeFunction]` 原生调用绑定在此：

| 方法 | 对应C++函数 | 用途 |
|------|------------|------|
| `HGRenderPath_Create(..., pathType)` | `HGRenderPath_Create` | 创建原生渲染路径 |
| `HGRenderPath_BeforeCulling(paramsPtr)` | `HGRenderPath_BeforeCulling` | **每帧**预裁剪参数传递 |
| `HGRenderPath_Render(paramsPtr)` | `HGRenderPath_Render` | **每帧**触发原生渲染管线 |
| `HGRenderPath_Destroy(ptr)` | `HGRenderPath_Destroy` | 销毁原生渲染路径 |
| `HGRenderPathSimpleUI_*` | `HGRenderPathSimpleUI_*` | UI渲染路径 |
| `AllocateTempFromCSharp(size)` | `HGRenderGraph_AllocateTempFromCSharp` | **帧临时内存分配器** |
| `CustomDepthRequestManager_*`(6) | `CustomDepthRequestManager_*Wrapper` | 自定义深度管理 |
| `CustomDrawRTManager_*`(6) | `CustomDrawRTManager_*Wrapper` | 自定义RT绘制管理 |
| `InkSimulationPass_Destroy` | `InkSimulationPass_DestroyCSharpWrapper` | 墨水模拟销毁 |

### 6.3 环境配置 Structs (blittable)

| Struct | 字段数 | 用途 |
|--------|--------|------|
| `HGEnvironmentPhaseCPP` | 聚合指针 | 根容器—聚合所有环境配置指针 |
| `HGLightConfigCPP` | ~20 | 方向光(pre-exposure/直接/间接/旋转) |
| `HGSkyConfigCPP` | ~15 | 天空(sky类型/sun disc/ambient SH/cubemap) |
| `HGAtmosphereConfigCPP` | ~20 | 物理大气散射(Rayleigh/Mie/ozone) |
| `HGFogConfigCPP` | 6 | 指数雾 |
| `HGHeightFogConfigCPP` | ~15 | 高度雾+体积雾+flow noise |
| `HGVolumetricFogConfigCPP` | ~15 | 体积雾(双参数高度+flow) |
| `HGCloudConfigCPP` | ~25 | 云(texture/tint/flow/shadow/光晕mask) |
| `HGCloudShadowConfigCPP` | 6 | 云阴影 |
| `HGCelestialConfigCPP` | 聚合 | 天体(moon/planet/advanced) |
| `HGCelestialDrawerCPP` | 8 | 天体绘制(mode/material/pitch/yaw) |
| `HGStarConfigCPP` | ~20 | 星空(type/density/nebula/per-channel) |
| `HGAutoExposureConfigCPP` | ~15 | 自动曝光/眼睛适应 |
| `HGColorGradingConfigCPP` | ~30 | 完整调色管线(LUT/曲线/通道混合/分区调色/lift/gamma/gain) |
| `HGContactShadowConfigCPP` | 6 | 接触阴影 |
| `HGShadowConfigCPP` | ~10 | 阴影级联+接触阴影全局 |
| `HGLightShaftConfigCPP` | 8 | 体积光(bloom/occlusion) |
| `HGAnamorphicStreaksConfigCPP` | 10 | 变形光晕 |

### 6.4 后处理Volume Components (blittable)

| Struct | 用途 |
|--------|------|
| `HGVolumeComponentsDataCPP` | 聚合指针 |
| `BloomVolumeCPP` | Bloom(intensity/tint/dirt/anamorphic/scatter/threshold) |
| `VignetteCPP` | 暗角(mode/color/intensity/mask) |
| `HGVignetteCPP` | HG暗角(color/intensity/blink) |
| `HGDirtyLensCPP` | 脏镜头(texture/intensity) |
| `SharpenVolumeCPP` | 锐化(mode/range/intensity/threshold) |
| `HGRadialBlurCPP` | 径向模糊(center/intensity/power) |
| `HGBWFlashCPP` | 黑白闪(threshold/color/flash/mask) |
| `FishEyeEffectVolumeCPP` | 鱼眼 |
| `HGChromaticAbberationCPP` | 色散(center/intensity) |
| `ScreenSpaceReflectionVolumeCPP` | SSR(fade/mip threshold) |

### 6.5 渲染输入 Structs (每帧指针传递到C++)

| Struct | 用途 |
|--------|------|
| `CustomDepthOnlySystemRequest` | 自定义深度 |
| `CutsceneEffectPassRPInput` | 过场特效材质/Mesh |
| `FishEyeEffectInput` | 鱼眼镜 |
| `FrostedGlassPassRPInput` | 磨砂玻璃+LUT |
| `HGFakePlanarReflectionRenderingInput` | 假平面反射(blur/normal/pivot) |
| `HGReflectionProbeBinningInput` | 反射探针Binning |
| `HGWaterSectorRenderingInput` | 水域Sector |
| `HGWaterInteractionRenderingInput` | 水交互CB Handle |
| **`HGWaterRenderingInput`** | **水渲染完整(~60字段:** culling/matrices/textures) |
| `InkSimulationPassInput` | 墨水模拟 |
| `LensFlareRenderingInput` | 镜头光晕 |
| `ParafinRenderingInput` | 石蜡效果 |
| `ParticleLightingIVInput` | 粒子光照+IV |
| `SkyRendererInput` | 天空 |
| `TerrainDeformPassInput` | 地形变形 |
| `TerrainDepthPrepassInput` | 地形深度预Pass(tessellation/subdivision/ripples) |
| `UIImageBlurPassInputV2` | UI模糊 |
| `VFXPPScanLinePassInput` | VFX后处理扫描线 |
| `VFXScreenMaterialData` | 全屏VFX材质 |
| `VisibilitySHRPInput` | 可见性SH |
| `VolumetricCloudInput` | 体积云 |

### 6.6 DLSS/FSR3/FrameGen 原生入口

| 工具类 | 方法 | 用途 |
|--------|------|------|
| `HGCPPDLSSUtil` | `SetStreamlineDLSSGMode` | DLSS FG切换 |
| | `GetStreamlineDLSSGMinMaxFrameGen` | 帧生成范围查询 |
| | `CalcStreamlineDLSSGVRAMUsage` | VRAM预算计算 |
| `HGCPPFrameInterpolatorUtil` | `SetAFMECameraFallbackThreshold(x2)` | AFME相机回退阈值 |
| | `SetMFRCGeneral/BrightnessDiff/RepeatedPatternFallbackThreshold` | MFRC回退阈值(×3) |
| `HGFSR3Util` | `IsFSR3Supported` | FSR3检测 |
| | `GetFSR3RenderScale(quality)` | FSR3渲染比例 |
| `DLSSOptimalSettings` | `GetDLSSOptimalSetting(quality, res)` | DLSS最佳设置查询 |

### 6.7 Debug系统

| Struct | 用途 |
|--------|------|
| `HGDebugFeaturesManagerCPP` | **~190个debug toggle** — 每个渲染Pass/后处理/阴影/地形/水/雨均有独立开关 |
| `HGDebugFeatureCPP_bool/int/float` | 带覆盖值的debug feature |
| `HGDebugRenderManagerCPP` | AOV/PBR charts/quad overdraw/light debugger/shadow debugger |
| `HGRenderPipelineDebugResourcesCPP` | debug资源(shaders/materials/textures) |

### 6.8 Runtime Resources

| Struct | 用途 |
|--------|------|
| `HGRenderPipelineRuntimeResourcesCPP` | 运行时资源根 |
| `HGRenderPipelineRuntimeResourcesShaderResourcesCPP` | **~110个shader ID** — 整个管线的PS/CS引用 |
| `HGRenderPipelineRuntimeResourcesTextureResourcesCPP` | 运行时纹理ID(noise/LUTs) |
| `HGRenderPipelineRuntimeResourcesAssetResourcesCPP` | 运行时Mesh ID(sphere/capsule/cube/cone/quad) |

### 6.9 关键Enums (29个)

| Enum | 说明 |
|------|------|
| `HGRenderPathInternalCPP` | Forward/UI/UI3D/DefaultDeferred/OnePassDeferredSubpass/Debug(×4) — 8种 |
| `DLSSQuality` | UltraPerformance/Performance/Balanced/Quality/DLAA |
| `FSR3Quality` | UltraPerformance/Performance/Balanced/Quality/NativeAA |
| `HGToneMappingModeCPP` | None/Neutral/ACES/Custom/External/ACES_Modified(×6) |
| `StreamlineDLSSFGMode` | Off/On/Auto |
| `StreamlineReflexMode` | Off/LowLatency/LowLatencyWithBoost |
| `FrameInterpolationAlgo` | Vendor/HGFI/Blit |
| `BloomBlendMode` | Add/EnergyConservation |
| `BloomQuality` | Low/Medium/High |
| `BloomResolution` | Quarter/Half |
| `HGSharpenMode` | Off/Filter1/Filter2/Filter4 |
| `VignetteMode` | Procedural/Masked |
| `HGLensFlareBlendMode` | Additive/Screen/Premultiply/Lerp |
| `HGLensFlareType` | Image/Circle/Polygon |
| `HGSkyConfigSkyMaterialTypeCPP` | ProceduralSky/Skybox |
| `HGStarConfigStarTypeCPP` | RealTimeNoise/BakedMap |

---

## 7. Rendering.Beyond

**路径**: `Assets/Scripts/Rendering.Beyond/`
**文件数**: ~60+ .cs
**命名空间**: `Beyond.Rendering`
**角色**: 游戏层渲染扩展 — 实体VFX/材质控制/VAT/Mesh捕获/Shader预热/地形辅助

### 7.1 模块结构

```
Beyond.Rendering/
├── Entity渲染控制层
│   ├── EntityRenderHelperMaterialController  — 材质管理(RendererInfo/AddedMaterial/CustomPerDraw/MeshMaterial)
│   ├── EntityRenderHelperVisibleController    — 可见性控制(RendererInfo)
│   ├── EntityRenderMaterialManager            — 材质管理器
│   ├── EntityRenderCapturedEntity             — 被捕获实体
│   ├── EntityRenderCaptureMeshController      — Mesh捕获控制器
│   ├── EntityRenderAlphaDitherController      — Alpha抖动控制
│   └── EntityCustomizeRendererPropertyConfig  — 渲染器属性定制
│
├── VFX系统
│   ├── EntityVFXAssetBase / EntityVFXAsset    — VFX资产基类
│   ├── EntityVFXControllerBase / StateBase     — VFX控制器(状态机)
│   ├── EntityVFXDissolveAsset/Data             — 溶解特效(VAT)
│   ├── EntityVFXAfterImageAsset/Data           — 残影特效
│   ├── EntityVFXAddictiveMaterialAsset/Data    — 叠加材质
│   ├── EntityVFXSetParamsAsset/Data            — 参数设置
│   ├── EntityVFXCurve/CurveData                — VFX曲线
│   ├── EntityVFXFactoryAddedMaterialManager    — 工厂附加材质管理(含VAT)
│   ├── EntityVFXFactoryMaterialCache           — 材质缓存
│   └── EntityVFXUtils                         — 工具方法
│
├── VAT(顶点动画纹理)系统
│   ├── VATPropertySetter(abstract)             — VAT属性设置基类
│   ├── VATRendererPropertySetter               — Renderer VAT设置
│   ├── VATEntityRendererHelperPropertySetter   — Entity VAT设置
│   ├── CommonVAT                               — 通用VAT(MonoBehaviour)
│   ├── FactoryVAT                              — 工厂VAT(MonoBehaviour)
│   └── RuntimeVATAnimationClip / RuntimeVATData — 运行时VAT数据
│
├── 地形/场景
│   ├── HGTerrain / HGTerrainHelper             — 地形辅助
│   ├── HGSOCDataHelper / HGSOCSubSceneData     — SubScene数据
│   └── SOCHelper                               — SOC工具
│
├── Shader预热
│   ├── ShaderWarmupManager                     — Shader预热管理器(含WarmUpReason/TimeCostCounter)
│   └── ShaderWarmupManagerRemoteCfg             — 远程配置(黑白名单)
│
├── LODLightmapping
│   ├── LODLightmapping                         — LOD光照贴图
│   └── LightmapInfoTransfer                    — 光照图传输
│
├── SplineMovingObjects
│   └── HGSplineMovingObjects                   — 样条移动物体(IVFXPlayable)
│
├── VFXSludge
│   ├── VFXSludgeBaker                          — 泥浆烘焙
│   ├── VFXSludgeNavUtils                       — 泥浆导航工具
│   └── VFXSludgeUtils                          — 泥浆工具
│
├── 管线工具
│   ├── PipelineSettingHelper                   — 管线设置加载
│   ├── PsoCreateUploadHelper                   — PSO上传
│   ├── ResourceRouter                          — 资源配置路由
│   └── ShaderWarmupManager                     — Shader预热
│
└── 其他
    ├── ICaptureMesh                            — Mesh捕获接口
    ├── IRendererHelper                         — Renderer帮助接口
    ├── CustomPerDrawDataChannelUtils           — 自定义PerDraw数据通道
    ├── EntityRendererTypeConfig                — 渲染器类型配置
    └── WindowsGpuDriverVersion                 — Windows GPU驱动版本检测
```

### 7.2 关键功能说明

**实体VFX系统**: 管理角色/物体的溶解(dissolve)、残影(afterimage)、叠加材质等VFX，基于MonoBehaviour状态机驱动

**VAT系统**: 运行时顶点动画纹理播放，支持Entity和普通Renderer，含材质属性块(PropertyBlock)更新

**Shader预热**: 在关卡加载时预热Shader减少卡顿，支持远程配置黑白名单（针对特定设备）

**LOD光照贴图**: LOD切换后的光照贴图信息传输

**样条移动物体**: 沿着样条路径移动的物体渲染

**泥浆系统**: VFX泥浆烘焙工具

**PipelineSettingHelper**: 管线设置加载统一入口

### 7.3 Enums

| Enum | 用途 |
|------|------|
| `VFXType` | VFX类型分类 |
| `EntityVFXKeywordEnum` | VFX关键字枚举 |
| `EntityVFXPriorityType` | VFX优先级 |
| `EntityVFXRendererMask` | VFX渲染器Mask |
| `EntityVFXRendererType` | VFX渲染器类型 |
| `RenderHelperType` | 渲染帮助类型 |
| `SettingLodLevel` | LOD设置等级 |
| `EffectTargetLayers` | 特效目标层 |
| `EntityCustomizeMatchMethod` | 定制匹配方法 |
| `EntityRenderHelperCustomPerDrawType` | 自定义PerDraw类型 |
| `AssetPlatformLayers` | 资源平台层 |
| `LodLightmappingMode` | LOD光照贴图模式 |

---

## 8. RuntimeQuality

**路径**: `Assets/Scripts/RuntimeQuality/`
**文件数**: 79个
**命名空间**: `RuntimeQuality.Beyond.Scripts.Quality` / Components
**角色**: 运行时质量管理系统 — 设备匹配→质量分级→组件应用

### 8.1 核心架构

```
DeviceList_zip.bytes (GZip JSON)
       │
DeviceInfo (GPU/CPU/RAM/OS检测)
       │
DeviceMatchRules (per-platform GPU正则)
       │
DeviceMatchResult (score + matched rule)
       │
DeviceQualityMap (score -> quality tier level)
       │
QualityManager.defaultLevel
       │
{platform}_QualityMap.json ──> QualityTierLevel[]
       │
{platform}_QualityTierComponent.json ──> List<QualityTierComponent>[]
       │
QualityManager 为每个level选择components，通过HGRenderPipelineSettingHub应用
```

### 8.2 QualityTierComponent层级 (30+个组件)

| 组件类 | 控制内容 | 实现方式 |
|--------|---------|---------|
| **`HGRPTierQuality`** | 主管线质量等级 | `ChangeSettingTier(int)` |
| **`HGShadowQuality`** | 阴影Map等级 | `OverrideFeatureTier("ShadowMap", tier)` |
| **`HGContactShadowQuality`** | 接触阴影开关 | `OverrideFeatureTier("ContactShadow", 2000/1000)` |
| **`HGScreenSpaceReflectionQuality`** | SSR等级 | `OverrideFeatureTier("SSR", tier)` |
| **`HGVolumetricFogQuality`** | 体积雾等级 | `OverrideFeatureTier("VolumetricFog", tier)` |
| **`HGVolumetricCloudQuality`** | 体积云等级 + GetShaderLod | `OverrideFeatureTier("VolumetricCloud", tier)` |
| **`HGAmbientOcclusionQuality`** | GTAO + VisibilitySH等级 | `OverrideFeatureTier("GTAO" / "VisibilitySH", tier)` |
| **`HGTextureQuality`** | 纹理质量 | 解析为tier index |
| **`GrassSparsityQuality`** | 草地密度 | `OverrideFeatureTier("Grass", tier)` |
| **`ChromaticAberrationQuality`** | 色差开关 | `OverrideFeatureTier("ChromaticAberration", 2000/1000)` |
| **`EnvironmentRenderingFeatureQuality`** | 雨水/垂直遮挡图 | `OverrideFeatureTier("RainAndWetness" / "VerticalOcclusionMap")` |
| **`SceneDetailQuality`** | Streaming + ArtTags | `OverrideFeatureTier`(多个Tags) |
| **`HGLODStreamingComponent`** | LOD Streaming | LODStreaming toggle + low-memory |
| **`CharacterRenderFeatureQuality`** | 角色shadowLod/shadowTier/outlineTier | `HGCharacterQualitySettings`静态字段 |
| **`RenderingScaleQualityPC`** | PC渲染比例(100-60%) | `SettingParameter<float>.Override(value)` |
| **`RenderingScaleQualityMobile`** | 移动渲染比例(ExHigh-ExLow) | `SettingParameter<float>.Override(value)` |
| **`SharpnessQuality`** | 锐化滑条 | `SettingParameter<float>.Override(value)` |
| **`AntiAliasingQuality`** | AA模式 | None/CSAA/FXAA/MSAA |
| **`ShaderLodQuality`** | 全局Shader LOD | `QualitySettings.globalMaximumLOD` |
| **`LODGroupQuality`** | LOD bias + offset | `QualitySettings.lodBias` |
| **`UpscalerQuality`** | 上采样模式 | DLSS/TAAU/FSR3选择 |
| **`DLSSUpscalerQuality`** | DLSS质量 | `DLSSQuality` enum |
| **`FSR3UpscalerQuality`** | FSR3质量 | `FSR3Quality` enum |
| **`FrameGenQuality`** | 帧生成总开关 | None/DLSS |
| **`DLSSFrameGenQuality`** | DLSS FG倍率 | Auto/X1/X2/X3 |
| **`FrameGenQualityMobile`** | 移动端帧生成 | 高通AFME/联发科MFRC |
| **`FrameRateQuality`** | 目标FPS(120/60/30) | `Application.targetFrameRate` |
| **`FrameRateQualityMobile`** | 移动FPS(60/45/30) | `Application.targetFrameRate` |
| **`ReflexQuality`** | NVIDIA Reflex | `StreamlineReflexMode` |
| **`RayTracingQuality`** | 光追开关 | `HGGraphicsUtils.set_enableRayTracing()` |
| **`VSyncQualityV2`** | 垂直同步 | VSync toggle |
| **`HGAnisoLevelQuality`** | 各向异性(X1/X2/X4/X8) | `HGGraphicsUtils.set_maxAnisoLevel()` |
| **`PhysicsClothQuality`** | 物理布料 | MagicaManager toggle |
| **`HGIrradianceVolumeQuality`** | 辐照度Volume | LowMemory override only |
| **`HGReflectionProbeBinningQuality`** | 反射探针 | LowMemory override only |
| **`TickExclusiveQuality`** | 动态/热状态适配 | LogicQualityLevel + ThermalState |
| **`ResLoadSettingQuality`** | 资源加载预算 | ResourceManagerFlag |
| **`PreloadLoadSettingQuality`** | 预加载预算 | 时间预算 |
| **`PrefabInstantiateQuality`** | 预制体实例化预算 | 时间预算 + 最大销毁数 |
| **`HgFrameRateControl`** | 帧率栈管理 | priority-push/pop by reason |

### 8.3 质量等级枚举

```csharp
enum LogicQualityLevel { Economy=0, Balanced=1, Performance=2, Max=3 }
enum ThermalState { GameNormal=0, GameFair=1, GameSerious=2 }
```

### 8.4 设备匹配系统

| 文件 | 用途 |
|------|------|
| `DeviceInfo` | GPU/CPU/RAM/OS检测+GPU名标准化 |
| `DeviceMatchRules` | 各平台GPU正则排名规则 |
| `DeviceQualityMap` | deviceScore → quality level映射 |
| `RankingRule` | GPU/CPU正则排名规则 |
| `MemoryRule` | 内存修正规则 |

### 8.5 HG RenderPipeline Feature Tags 整合

从Quality Components发现的Feature Tag字符串:
- `"ShadowMap"`, `"SSR"`, `"ContactShadow"`, `"VolumetricFog"`, `"VolumetricCloud"`
- `"GTAO"`, `"VisibilitySH"`, `"Grass"`, `"ChromaticAberration"`
- `"RainAndWetness"`, `"VerticalOcclusionMap"`
- `"Streaming"`, `"LODStreaming"`, `"TextureStreaming"`, `"ArtTags"`
- `"Texture"`

调用路径: `HGRenderPipelineSettingHub.get_instance().OverrideFeatureTier(tag, tier)`

---

## 9. HG.RenderPipelines.ScriptBridge

**路径**: `Assets/Scripts/HG.RenderPipelines.ScriptBridge/`
**文件数**: 7个
**命名空间**: `HG.Rendering.ScriptBridge`
**角色**: C#代码到原生渲染管线的桥接层(IFix热补丁系统)

### 9.1 HGRenderBridgeStatics — 通用桥接

| 方法 | 用途 |
|------|------|
| **Camera** | |
| `AttachHGCamera(GameObject)` | 附加HGCamera到GameObject |
| **Decal** | |
| `GetHGDecalProjectorMaterialInChildren(GameObject)` | 从子对象获取Decal材质 |
| `GetHGDecalProjectorInChildren(GameObject)` | 查找子Decal组件 |
| `SetHGDecalProjectorProgress(Object, float)` | 设置UV偏移Y(进度) |
| `SetHGDecalProjectorHollow(Object, float)` | 设置UV偏移X(空心) |
| `SetHGDecalProjectorAngle(GameObject, float)` | 设置sectorAngle |
| **角色** | |
| `HGCharacterHelperFindRenderers(GameObject)` | 查找角色渲染器 |
| `UpdateCurrentPlayerCenter(Transform)` | 更新玩家位置(渲染管线) |
| `UpdateCurrentEnvCenter(Transform)` | 更新环境中心 |
| `SetCharacterPositionsHeights(List<Vector3>, List<float>, List<float>)` | 传入角色位置→植被交互/布料/VFX |
| **VFX** | |
| `UpdateAnchorBrightParams(Vector2, float, float, bool)` | 锚点亮波亮度(HGVFXManager) |
| `SetVFXPPPriorityFilterCinematic/Normal/UltiSkillCam()` | 后处理优先级滤镜(VFXPPManager) |
| `SetVFXPPActive(bool)` | VFX后处理开关 |
| `SetSceneDarkEnabled(bool)` | 场景变暗(HGVFXManager) |
| **时间** | |
| `SetGameplayTime(double)` / `SetLastGameplayTime(double)` | 游戏时间→HGRPTimeManager |
| `NotifyTimeScale(float)` | 时间缩放通知(clamped [-1.0, 0]) |
| **帧生成** | |
| `RequestDisableFrameGenTemporarily(Camera, bool)` | 临时禁用帧生成(HGCamera) |
| `PauseMobileFrameGenTemporarily(bool)` | 暂停移动端帧生成 |
| **Shader** | |
| `GetWorldUIKeyword()` | 获取World UI Shader关键字 |

### 9.2 TAAUControlBridge — 上采样控制桥接

| 方法 | 用途 |
|------|------|
| `ToggleTAAU(Camera)` | TAAU开关 |
| `ToggleMetalFXSpatial/FXTemporal(Camera)` | MetalFX空间/时序开关 |
| `ToggleTAAUWithMetalFXSpatial(Camera)` | TAAU+MetalFX空间组合 |
| `ToggleDLSS(Camera)` | DLSS开关 |
| `SetDLSSQuality(Camera, int)` | DLSS质量级 |
| `SetDLSSFG(Camera, int)` / `SetDLSSFGModeGenFrames(int)` | DLSS帧生成 |
| `SetDLSSReflex(int)` | NVIDIA Reflex模式 |
| `SetDLSSPCLEnable(bool)` | DLSS像素置信度 |
| `SetDLSSSharpenStrength(float)` | DLSS锐化强度 |
| `UseDLSSExposure(bool)` | DLSS自动曝光 |
| `SetFSR3Quality(Camera, int)` | FSR3质量级 |
| `SetRenderingScale(Camera, float)` | 每相机渲染比例 |
| `SetForceJitterPhaseIdx(Camera, int)` | 强制TAA抖动相位 |
| TAAU调优参数 | `ChangeHistoryWeight`, `ChangeDepthDiff`, `MinMVConsideredDynamic`, `FastConvergeHistoryWeight` 等 |
| `ToggleTargetFrameRate(int)` | 目标帧率 |

---

## 10. HG.RenderPipelines.Logger

**路径**: `Assets/Scripts/HG.RenderPipelines.Logger/`
**文件数**: 5个
**命名空间**: `HG.Rendering`
**角色**: 渲染管线日志(IFix可热补丁)

### 10.1 HGRPLogger

| 方法 | 级别 | 后端 |
|------|------|------|
| `LogWarning(string)` | Warning | 原生no-op(空) |
| `LogWarning(string, T)` | Warning | IFix热补丁 |
| `LogError(string)` + 4个泛型重载 | Error | `Beyond.DLogger.LogError(11, msg)` |
| `LogCritical(string)` + 2个泛型重载 | Critical | `Beyond.DLogger.LogCritical(11, msg)` |
| `LogException(Exception)` | Exception | `Beyond.DLogger.LogException(11, ex)` |
| `LogImportant(string)` | Important | `Beyond.DLogger.LogImportant(11, msg)` + 时间戳格式化 |

常量 `0x0B(11)` 为渲染管线日志分类ID。

### 10.2 额外功能

Logger中的`WrappersManagerImpl`附加了`IRenderGraphCallbackOwner.OnRenderPassExecution`回调 — 原生渲染图执行回调，检测渲染路径类型(magic value `0xCD2`)来分发执行。

---

## 11. UI.Beyond / UI.Gameplay.Beyond

### 11.1 UI.Beyond 渲染相关组件

| 文件 | 类 | 渲染功能 |
|------|----|---------|
| `UI/Empty4Raycast.cs` | `Empty4Raycast : MaskableGraphic` | 透明射线检测(OnPopulateMesh) |
| `UI/NonDrawingGraphic` | IFix元数据 | 不绘制图形(但有材质引用) |
| `UI/UIBlendImage` | `UIBlendImage` | 混合模式图像(material key/texture cache) |
| `UI/UIImage` | `UIImage` | 图片渲染(OnPopulateMesh, LoadMaterial, mainTexture) |
| `UI/UIMaterialAnimation` | `UIMaterialAnimation` | 材质属性动画 |
| `UI/UISoftMask` / `UISoftMaskable` | `UISoftMask` | 软遮罩(vertex modification, GetModifiedMaterial) |
| `UI/UIVFXManager` | `UIVFXManager` | UI VFX(materials/runtime atlas) |
| `UI/GPUI/GPUISystem` | `GPUISystem` | GPU UI渲染(populate mesh/quad mesh) |
| `UI/UISortingOrder` | `UISortingOrder` | 排序(GetRenderer/GetChildrenRenderers) |
| `UI/UIGraphicAnimation` | `UIGraphicAnimation` | Graphic动画 |
| `UI/UICanvasScaleHelper` | `UICanvasScaleHelper` | Canvas缩放(OnWillRenderCanvases) |
| `UI/UIRegionBuildingTexManager` | `UIRegionBuildingTexManager` | 区域建筑纹理更新 |
| `UI/UIScrollText` | `UIScrollText` | 滚动文本(mesh scroll/clipping) |
| `UI/UIText` | `UIText` | 文本渲染(font shared material/mesh/texture) |
| `UI/I18nFontLoader` | `I18nFontLoader` | 多语言字体加载 |

**HGConstantBufferLayoutAttribute**: 在 `UI.Beyond/HG/Rendering/Runtime/` 中存在ConstantBuffer布局标记Attribute

### 11.2 UI.Gameplay.Beyond 渲染相关组件

| 文件 | 类 | 渲染功能 |
|------|----|---------|
| `UI/RegionMapSetting.cs` | `RegionMapSetting` | Renderer/Material字典管理，MaterialPropertyBlock |
| `UI/UIBrokenLine.cs` | `UIBrokenLine` | 自定义材质 (`HGRP/UI/BrokenLine` Shader) |
| `UI/UIVideoHelper.cs` | `UIVideoHelper` | 视频渲染(CriMana Player) |
| `UI/UITacticalItemBar.cs` | `UITacticalItemBar` | Forward Pass数据引用 |
| `UI/UILiquidPoolScanController.cs` | `UILiquidPoolScanController` | 液体池扫描 |
| `UIWatchPanelCut.cs` | `UIWatchPanelCut` | `Shader.SetGlobalMatrix` |

---

## 12. Entry.Beyond

**路径**: `Assets/Scripts/Entry.Beyond/`
**角色**: 管线初始化/加载入口

### 12.1 RenderPipelineDataLoader

| 方法 | 用途 |
|------|------|
| `LoadSimpleRpData()` | 简单加载HGRenderPipelineAsset |
| `PreloadFullRpResources()` | 预加载完整管线资源 |
| `IsPreLoadFinished()` | 检查预加载完成 |
| `LoadFullRpResources()` | 完整加载 |

### 12.2 RenderSilhouetteRT

创建/管理 silhouette(剪影) RenderTexture，用于角色轮廓检测或UI剪影效果。
使用 `HGRenderPipeline+HGResolutionSettings`, `Material.SetTexture`, `RenderTexture.Release`。

### 12.3 管线生命周期入口

| 状态 | 调用的渲染方法 |
|------|--------------|
| `GamePreloadState` | `PipelineSettingHelper::LoadPipelineSettings`, `PsoCreateUploadHelper::Init` |
| `GameLoginState` | `RenderPipelineDataLoader::LoadFullRpResources`, `PipelineSettingHelper::LoadPipelineSettings` |
| `GameSoftRestartState` | Shader LOD重初始化, 管线重载 |
| `SplashController` | `RenderPipelineDataLoader::LoadSimpleRpData` |

---

## 13. 第三方渲染资产

### 13.1 VolumetricLightBeam (VLB)

**路径**: `Assets/Scripts/VolumetricLightBeam/`
**文件**: ~30个
**用途**: 体积光锥渲染
**渲染集成**: 通过`SRPHelper`注册`RenderPipelineManager.beginCameraRendering`回调

| 文件 | 功能 |
|------|------|
| `VolumetricLightBeam.cs` | 主组件(光锥几何/颜色/强度/Noise3D/深度混合/动态遮挡/Cookie/抖动/Fade) |
| `Config.cs` | 全局配置(管线选择: BuiltIn/URP/HDRP/HGRP) |
| `MaterialManager.cs` | Shader变体材质管理 |
| `ShaderProperties.cs` | 所有Shader属性ID常量 |
| `BeamGeometry.cs` | MeshRenderer+MeshFilter管理 |
| `DynamicOcclusion/` | 运行时遮挡检测(raycast/DepthBuffer) |
| `VolumetricDustParticles.cs` | 光束尘埃粒子 |

### 13.2 PaintIn3D

**路径**: `Assets/Scripts/PaintIn3D/`
**文件**: ~50个
**用途**: 3D纹理绘制系统
**渲染集成**: `RenderPipelineManager.beginCameraRendering` + CommandBuffer blit

| 文件 | 功能 |
|------|------|
| `P3dPaintable.cs` | 根组件(Renderer/激活/缩放/多渲染器) |
| `P3dPaintableTexture.cs` | 纹理绘目标(Undo/Mip/Filter/SaveLoad/NormalMap) |
| `P3dCommandDecal.cs` | Decal绘制命令(Blend/位置/Shape/Extrusion/Clip) |
| `P3dBlendMode.cs` | 17种混合模式 |
| `P3dBlit.cs` | 隐藏Shader Blit工具 |
| `P3dCommon.cs` | URP回调注册 |
| `P3dReader.cs` | 异步纹理Readback |

### 13.3 MagicaCloth

**路径**: `Assets/Scripts/MagicaCloth/`
**文件**: 214个
**用途**: GPU Compute Shader布料物理(与GpuClothManager并存)

**关键组件:**
- `BaseCloth` — 布料基类(参数/数据/Selection/Setup/Blend/Gravity/Update/Culling)
- `PhysicsManagerCompute` — ComputeShader物理模拟调度
- `RenderMeshDeformer` — GPU变形网格(ComputeBuffer)
- `VirtualMeshDeformer` — 代理网格变形
- **约束类型**(14种): ColliderCollision/ColliderExtrusion/EdgeCollision/Penetration/RestoreDistance/RestoreRotation/ClampDistance/ClampPosition/ClampRotation/CompositeRotation/Spring/TriangleBend/Twist/Volume
- **风系统**: `MagicaAreaWind`, `MagicaDirectionalWind`, `WindController`
- **Avatar系统**: `MagicaAvatar` + Parts(换装布料)

**渲染集成**: ComputeBuffer → RenderMesh/VirtualMesh Deformer，`cullRendererList`控制可见性

### 13.4 Cinemachine (Beyond定制版)

**路径**: `Assets/Scripts/Cinemachine/`
**文件**: 132+个
**用途**: 相机系统
**定制集成**: 引用 `HG.Rendering.Runtime`

| 定制点 | 说明 |
|--------|------|
| `CameraState.HGDOFParams` | 自定义景深参数(near/far radius/focus start/end/temporal factor) |
| `CinemachineBrain` | 引用 `HG.Rendering.Runtime` |
| `CinemachineBeyondCommunicator` | Level Camera桥接(GetLevelCamera delegate) |
| `CinemachineCameraOffset` | 相机空间偏移 |
| `CinemachineTouchInputMapper` | 触摸输入映射 |
| `CinemachineRecomposer` | 后处理tilt/pan/dutch/zoom调整 |
| `CinemachineStoryboard(1748行)` | 全屏叠加层(Canvas+RawImage) |
| `CinemachinePostProcessing` | PostFX集成 |
| `CinemachineVolumeSettings` | URP Volume集成 |

### 13.5 OverdrawForURP

**路径**: `Assets/Scripts/OverdrawForURP/`
**用途**: Overdraw可视化(URP RendererFeature)
**集成**: `ScriptableRendererFeature`

---

## 14. Ruri.RenderPipelines

### 14.1 外部引用发现

| 引用 | 来源 | 说明 |
|------|------|------|
| `Assets/RuriAssembly/Ruri.RenderPipelines/Resources/Shaders/Common/Ruri_Deferred.hlsl` | `QuantumBreak/URP/Caustics/RuriCaustics.shader:39` | GBuffer解包函数(外部依赖) |
| `Ruri.RenderPipelines.Toon::RuriToonBloom` | `Global Volume Profile.asset:14` | Toon Bloom Volume组件(外部依赖) |
| `Ruri.RenderPipelines.Toon::RuriBloom` | `Global Volume Profile.asset:74` | Bloom Volume组件(外部依赖) |
| `Ruri.Utils::RuriDebug` | `BufferToMaterial.cs:4` | Debug日志工具(外部依赖) |

### 14.2 项目中Ruri命名空间内容(非外部)

| 位置 | 内容 | 说明 |
|------|------|------|
| `QuantumBreak/URP/Caustics/` | `Caustics`(Volume), `CausticsFeature`, `RuriCaustics.shader` | 焦散效果(URP) |
| `QuantumBreak/URP/GeometricDistortion/` | `GeometricDistortion`(Volume/Feature), 3个shader | 几何扭曲(URP) |
| `QuantumBreak/URP/DisplateFX/` | `DisplateFX`(Volume), `DisplateFX.shader` | 置换FX(URP) |
| `QuantumBreak/URP/TimeFX/` | `TimeFX`(Volume), `TimeFXFeature`, 3个shader | 时间FX(URP) |
| `QuantumBreak/URP/RuriUberPostFeature.*.cs` | 3个partial文件 | Ruri后处理Feature |

### 14.3 架构结论

```
HG.RenderPipelines.Runtime (原版完整管线)
       │
       ├──Bloom/Tonemapping ✅已移植→
       │
       ▼
Ruri.RenderPipelines (外部目标管线，本项目中不存在源码)
       │
       ├── Ruri.RenderPipelines.Toon (Toon Bloom组件)
       ├── Ruri_Deferred.hlsl (GBuffer解包)
       └── Ruri.Utils (Debug工具)
       
QuantumBreak/URP/* (Ruri品牌URP扩展，项目中存在源码)
       ├── 基于URP而非HGRP
       ├── 通过RuriUberPostFeature处理
       └── 作为HGRP→Ruri的过渡桥梁
```

---

## 15. 全景统计与模块关系图

### 15.1 模块关系图

```
[Game Logic]
  ├─ Entry.Beyond (管线加载生命周期)
  ├─ Rendering.Beyond (实体VFX/材质控制/VAT/Shader预热)
  └─ RuntimeQuality (质量等级/设备匹配/组件应用)
       │
[ScriptBridge]   HGRenderBridgeStatics + TAAUControlBridge (IFix热补丁)
       │
[Logger]         HGRPLogger (IFix热补丁日志)
       │
[HGRenderPipeline Runtime] (管线核心: 60个Pass, 160+Shader)
       │
[HGGraphicsCPPModule]  148个blittable structs + [FreeFunction]调用
   │       │
   │       └── C++ Native Engine (Modules/HGGraphicsCPP/Public/)
   │
[第三方资产]
  ├─ Cinemachine (相机/DOF定制/Storyboard)
  ├─ MagicaCloth (GPU布料/214文件)
  ├─ VolumetricLightBeam (体积光锥)
  ├─ PaintIn3D (3D绘制)
  └─ OverdrawForURP (Overdraw可视化)
  
[UI渲染层]
  ├─ UI.Beyond (UISoftMask/GPUISystem/UIVFXManager)
  └─ UI.Gameplay.Beyond (RegionMap/BrokenLine)
  
[外部引用]
  └─ Ruri.RenderPipelines (Toon Bloom/Deferred hlsl)
```

### 15.2 全量统计

| 层级 | 模块 | 文件数 | 行数估计 |
|------|------|--------|---------|
| **管线核心** | HG.RenderPipelines.Runtime | 859 | ~250,000 |
| | Shaders(14类) | ~160 .shader | ~80,000 |
| **C++桥接** | HGGraphicsCPPModule | 148 | ~15,000 |
| **游戏层扩展** | Rendering.Beyond | ~60 | ~12,000 |
| **质量控制** | RuntimeQuality | 79 | ~10,000 |
| **桥接/日志** | ScriptBridge + Logger | 12 | ~3,800 |
| **UI渲染** | UI.Beyond + UI.Gameplay.Beyond | ~35 | ~8,000 |
| **入口** | Entry.Beyond | ~10 | ~2,000 |
| **第三方** | MagicaCloth | 214 | ~100,000 |
| | Cinemachine (定制) | 132+ | ~50,000 |
| | VolumetricLightBeam | ~30 | ~15,000 |
| | PaintIn3D | ~50 | ~20,000 |
| **总计** | | **~1,789+** | **~565,000+** |
