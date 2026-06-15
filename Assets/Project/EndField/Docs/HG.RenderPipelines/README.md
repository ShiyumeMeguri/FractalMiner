# HG.RenderPipelines.Runtime 技术架构分析文档集

> **生成日期**: 2026-06-15
> **仓库**: HG.RenderPipelines.Runtime (FractalMiner / EndField)
> **性质**: 基于源码结构与 shader 的客观技术架构分析文档
> **目标**: 在任何无上下文的环境中，根据本文档集即可 1:1 复刻 HG 渲染管线的完整架构与实现

---

## 概述

本文档集对 HG.RenderPipelines.Runtime 的渲染架构做客观技术分析，覆盖从**渲染管线基础设施**到**游戏层扩展**的完整架构。内容以源码中的类型声明、字段签名、枚举值、结构体布局与 shader（HLSL）为精确依据，逐项标注 `文件:行号`；凡源中未直接给出的具体数值，显式标注「源未定位」，不填充未经证实的数值。为任意上下文无关的架构复刻提供精确参考。

**核心命名空间**:
- `HG.Rendering.Runtime` — 管线核心 (Pipeline, RenderPath, PassConstructor)
- `HG.Rendering.RenderGraphModule` — 自定义渲染图系统
- `UnityEngine.HyperGryphEngineCode` — C++ 原生桥接层 (Blittable 数据契约)
- `HG.Rendering.Runtime.Quality` — 运行时质量控制
- `Beyond / Beyond.UI` — 入口与 UI 框架

**总文档数**: 14 篇 (含根 README)

---

## 模块依赖图

```
                    ┌──────────────┐
                    │  09-Entry    │  ← 管线初始化入口
                    └──────┬───────┘
                           │
                    ┌──────▼───────┐
                    │ 01-Pipeline  │  ← 核心管线框架
                    │ Core         │
                    └───┬───┬──────┘
                        │   │
              ┌─────────┘   └──────────┐
              ▼                         ▼
     ┌────────────────┐       ┌──────────────────┐
     │ 03-RenderGraph │       │ 02-CoreAlgorithms│
     │ 渲染图系统      │       │ 核心算法          │
     └───────┬────────┘       └────────┬─────────┘
             │                         │
             ▼                         ▼
     ┌────────────────┐       ┌──────────────────┐
     │ 04-Graphics    │       │ 10-Shaders       │
     │ CPPModule      │       │ 着色器体系        │
     └───────┬────────┘       └────────┬─────────┘
             │                         │
             ▼                         ▼
     ┌────────────────┐       ┌──────────────────┐
     │ 07-ScriptBridge│       │ 11-FeatureSystems│
     │ Logger         │       │ 15 个特性系统     │
     └────────────────┘       └───┬───┬───┬───┬──┘
                                  │   │   │   │
                  ┌───────────────┘   │   └───┐
                  ▼                    ▼       ▼
          ┌──────────────┐    ┌────────────┐  ┌──────────┐
          │ 05-Rendering │    │ 06-Runtime │  │ 08-UI    │
          │ Beyond       │    │ Quality    │  │          │
          └──────────────┘    └────────────┘  └──────────┘

                         ┌──────────────────────┐
                         │ 12-PipelineSubsystems│
                         │ FrameSettings / Light │
                         │ Material / Resource  │
                         └──────────────────────┘
```

---

## 文档清单

| 模块 | 文档 | 内容概要 |
|------|------|---------|
| **01-PipelineCore** | `01-HGRenderPipeline-Infrastructure.md` | 管线基础设施、RenderPipeline 类层次、RenderPath 体系 |
| | `02-GeometryPasses.md` | GBuffer、DepthOnly、DepthPrepass、ForwardOpaque 等几何 Pass |
| | `04-LightingAO.md` | 延迟光照、前向光照、GTAO、SSR、Binning 等光照与 AO |
| | `05-PostProcessingPasses.md` | TAAU、DoF、MotionBlur、Bloom、ColorGrading 等后处理 |
| | `08-SpecialEffectsPasses.md` | LensFlare、LightShaft、AnamorphicStreaks、Distortion 等特效 |
| | `PassConstructors/PreRenderPasses.md` | PreRender Pass 构造器 |
| **02-CoreAlgorithms** | `01-CoreAlgorithms.md` | 核心算法文档(原版) |
| | `01-CoreAlgorithms-Verified.md` | 经源码验证的重构版(含附录验证表) |
| **03-RenderGraph** | `01-HGRenderGraph-System.md` | HGRenderGraph 渲染图系统架构 |
| **04-GraphicsCPPModule** | `01-HGGraphicsCPPModule.md` | C++ 原生桥接模块 |
| **05-RenderingBeyond** | *(待填充)* | 高级/实验性渲染主题(占位) |
| **06-RuntimeQuality** | `01-RuntimeQuality.md` | 运行时质量设置与可扩展机制 |
| **07-ScriptBridge-Logger** | `01-ScriptBridge-Logger.md` | 脚本桥接与日志系统 |
| **08-UI** | `01-UI-Beyond.md` | UI 渲染管线 |
| | `02-UI-Gameplay-Beyond.md` | 游戏内 UI 集成 |
| **09-Entry** | `01-EntryBeyond.md` | 管线初始化入口与启动流程 |
| **10-Shaders** | `01-Shaders.md` | 着色器架构、库与变体体系 |
| **11-FeatureSystems** | `01-WaterOcean.md` | 水体/海洋渲染系统 |
| | `02-Terrain.md` | 地形渲染(V2) |
| | `03-FoliageGrass.md` | 植被/草地系统 |
| | `04-GpuCloth.md` | GPU 布料模拟 |
| | `05-Volumetric.md` | 体积雾、体积云 |
| | `06-EnvironmentSky.md` | 环境天空与大气 |
| | `07-ShadowASM.md` | 阴影与 ASM |
| | `08-SubsurfaceCharacter.md` | 次表面散射与角色渲染 |
| | `09-GI-IrradianceSH.md` | GI 与 Irradiance Volume |
| | `10-GPUParticleVFX.md` | GPU 粒子与 VFX |
| | `11-WeatherWetness.md` | 天气/湿润/雨水系统 |
| | `12-InteractionChain.md` | 交互链系统 |
| | `13-CSG-SDF.md` | CSG 与 SDF |
| | `14-AtlasVirtualTexture.md` | 图集与虚拟纹理 |
| | `15-Camera.md` | 相机系统 |
| **12-PipelineSubsystems** | `02-FrameSettings.md` | 帧设置配置 |
| | `04-LightingManager.md` | 光照管理 |
| | `05-MaterialSystem.md` | 材质系统 |
| | `06-ResourceManagement.md` | 资源管理 |

---

## 验证状态

| 模块 | 源码验证 | 备注 |
|------|---------|------|
| 01-PipelineCore | ⚪ 待验证 | |
| 02-CoreAlgorithms | ✅ 已验证 | 15 项核心算法全部通过 |
| 03-RenderGraph | ⚪ 待验证 | |
| 04-GraphicsCPPModule | ⚪ 待验证 | |
| 05-RenderingBeyond | ⬜ N/A | 空目录 |
| 06-RuntimeQuality | ⚪ 待验证 | |
| 07-ScriptBridge-Logger | ⚪ 待验证 | |
| 08-UI | ⚪ 待验证 | |
| 09-Entry | ⚪ 待验证 | |
| 10-Shaders | ⚪ 待验证 | |
| 11-FeatureSystems | ⚪ 待验证 | 15 个特性系统 |
| 12-PipelineSubsystems | ⚪ 待验证 | |

---

## 自循环工作流

本项目提供两套自循环 AI 工作流提示词模板，内嵌来自 6 个真实 1:1 移植项目的历史教训:

| 工作流 | 用途 | 文件 |
|--------|------|------|
| 🔍 **调查 (Survey)** | 多 Agent 并行研究单一领域 | `workflow_survey.md` |
| ✅ **验证 (Verification)** | 源码与报告差异比对+就地修复 | `workflow_verify.md` |

### 历史教训来源

> 分析自 6 个真实工作流/验证报告：`controlrig-port.mjs`、`nobeta-honeycomb-port.mjs`、`Ruri.Cloth.MotionIK_1to1验证报告.md` (9 条真 bug)、`ruri-cloth-motionik-verify.mjs`、`ruriirp-renderpipeline-1to1-verify.mjs`、`ruriirp-renderpipeline-1to1-verify-round2.mjs`

验证 agent 实战数据: **端口 1:1 率约 60%**，修复轮自身也会引入新 bug。两套 workflow 均围绕这些失败模式设计。

### 编码进 workflow 的 15 条教训

| # | 教训 | 写入位置 | 来源 |
|---|------|---------|------|
| 1 | 核函数空心化 — 骨架对但核心算法被简化 | survey §1, verify §核心 | doc10 实测 |
| 2 | 假注释 — 注释声称"已1:1"但代码不符 | survey §1(f), verify §反假注释 | RuriIRP round1 |
| 3 | 常量漂移 — clamp 边界/魔法数字偏移 | survey context, verify §反常量漂移 | BUG-1/2/4/7 |
| 4 | 方向符号反转 — 毁灭性 a-b→b-a | verify §反方向 | 通用高危 |
| 5 | 跨文件配对不一致 — 写/读 key 不同 | survey §2(3), verify §反配对 | BUG-toroidal |
| 6 | 缓存 store/read 不配对 — 2.4 配对断裂 | verify §反配对 | PTGI 缓存 |
| 7 | ping-pong 方向反 | verify §反配对 | Iris 缓冲 |
| 8 | 假 gate/#if false 禁用真代码 | survey §1(g), verify §反假 gate | BUG-3 |
| 9 | 字段/API 臆造 | verify §反臆造 | BUG-5 |
| 10 | 字段/枚举值/方法缺失 | verify §反缺失 | BUG-6/8/9 |
| 11 | 估计器积分域未闭合(×π/4) | verify §反缺失 | uniform→cosine |
| 12 | 修复轮引入新 bug — 过度修正/语法破坏/越界 | verify §修复轮 | round2 核心 |
| 13 | 越界修改 — 修到范围外文件 | verify §反越界 | round1 TSR/VFog |
| 14 | 汇总截断 — token 超长静默丢单元 | verify §汇总防截断 | cloth-verify |
| 15 | 精度系统性降级 — double→float 生态一致 | survey context, verify § | B-4/B-5 |

### 工作流设计原则

- **自循环**: 不依赖外部协调器，模板自带分派→收集→融合/验证闭环
- **多 Agent 并行**: 独立领域/独立验证 agent，每 agent 只负责一个专一功能
- **最小 token**: 紧凑投影防截断，按文件分组批量读，grep 缓存
- **预设错**: 所有验证 agent 以"假设端口/报告是错的"为前提
- **就地修**: 查出偏离即 edit 修复，出 clean/fixed verdict

详见对应文件。
