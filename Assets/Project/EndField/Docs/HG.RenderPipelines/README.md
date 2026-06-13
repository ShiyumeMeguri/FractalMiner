# HG.RenderPipelines.Runtime 技术架构分析文档集

> **生成日期**: 2026-06-12
> **仓库**: HG.RenderPipelines.Runtime (FractalMiner / EndField)
> **性质**: 基于源码结构与 shader 的客观技术架构分析文档
> **目标**: 在任何无上下文的环境中，根据本文档集即可 1:1 复刻 HG 渲染管线的完整架构与实现

---

## 概述

本文档集对 HG.RenderPipelines.Runtime 的渲染架构做客观技术分析，覆盖从**渲染管线基础设施**到**游戏层扩展**的完整架构。内容以源码中的类型声明、字段签名、枚举值、结构体布局与 shader（HLSL）为精确依据，逐项标注 `文件:行号`；凡源中未直接给出的具体数值，显式标注「源未定位」，不填充未经证实的数值。为任意上下文无关的架构复刻提供精确参考。

**核心命名空间**:
- HG.Rendering.Runtime — 管线核心 (Pipeline, RenderPath, PassConstructor)
- HG.Rendering.RenderGraphModule — 自定义渲染图系统
- UnityEngine.HyperGryphEngineCode — C++ 原生桥接层 (Blittable 数据契约)
- HG.Rendering.Runtime.Quality — 运行时质量控制
- Beyond / Beyond.UI — 入口与 UI 框架

**总文档数**: 14 篇 (已生成 14 篇)

| 状态 | 数量 |
|------|------|
| 已完成 | 14 篇 |
| 02-CoreAlgorithms | 已完成 (`02-CoreAlgorithms/01-CoreAlgorithms.md`) |
| 10-Shaders | 已完成 (`10-Shaders/01-Shaders.md`) |

---

## 文档结构图

下面展示所有文档模块之间的依赖关系（箭头方向表示"依赖"或"使用于"）：

