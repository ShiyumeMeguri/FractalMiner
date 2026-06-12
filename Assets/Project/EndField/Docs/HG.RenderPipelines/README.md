# HG.RenderPipelines.Runtime 净室实现文档集

> **生成日期**: 2026-06-12
> **仓库**: HG.RenderPipelines.Runtime (FractalMiner / EndField)
> **性质**: 基于 IL2CPP 反编译 + IFix 结构层分析的净室实现文档
> **目标**: 在任何无上下文的环境中，根据本文档集即可 1:1 复刻 HG 渲染管线的完整架构与实现

---

## 概述

本文档集基于对 HG.RenderPipelines.Runtime 程序集的逆向结构分析（Cpp2IL 反编译产物），覆盖了从**渲染管线基础设施**到**游戏层扩展**的完整架构。所有源文件经过 IL2CPP AOT 编译和 IFix 热修复补丁处理，C# 层仅保留类型声明、字段签名、枚举值和结构体布局。本文档基于这些结构层信息 + Unity SRP 已知模式推断行为，为任意上下文无关的净室复刻实现提供精确参考。

**核心命名空间**:
- HG.Rendering.Runtime — 管线核心 (Pipeline, RenderPath, PassConstructor)
- HG.Rendering.RenderGraphModule — 自定义渲染图系统
- UnityEngine.HyperGryphEngineCode — C++ 原生桥接层 (Blittable 数据契约)
- HG.Rendering.Runtime.Quality — 运行时质量控制
- Beyond / Beyond.UI — 入口与 UI 框架

**总文档数**: 14 篇 (已生成 12 篇，待生成 2 篇)

| 状态 | 数量 |
|------|------|
| 已完成 | 12 篇 (~480KB) |
| 待生成 | 2 篇 (04-LightingAO, 05-RenderingBeyond, 07-ScriptBridge-Logger) |
| 空目录 | 2 个 (02-CoreAlgorithms, 10-Shaders) |

---

## 文档结构图

下面展示所有文档模块之间的依赖关系（箭头方向表示"依赖"或"使用于"）：

