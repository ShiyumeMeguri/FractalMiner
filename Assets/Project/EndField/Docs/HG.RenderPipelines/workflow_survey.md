# 自循环工作流: 多 Agent 并行调查 (Survey)

## 概述

将大面积未知代码库拆分为 N 个独立领域,派遣 N 个 Agent 并行研究,每个 Agent 只负责**一个**专一功能。递归嵌套,直至颗粒度够细。

⚠️ **历史教训(源自 6 个 1:1 移植/验证工作流)**: 调查阶段最常见病是「骨架对、核空心」—— Agent 写出漂亮结构图但遗漏核心算法细节、边界常量、跨文件配对关系。本模板内嵌反制措施。

---

## 入口输入

```yaml
target_dir: "D:/GameStudy/RuriBeyond/HG.RenderPipelines.Runtime"
domain_list: ["GBuffer", "Lighting", "Shadows", "Volumetric", "UI", ...]
output_dir: "./survey_output"
depth: 1                  # 当前递归深度
max_depth: 3              # 最大递归深度
parent_context: ""        # 父级传递的上下文摘要
```

---

## 阶段 1: 分派 (Dispatch)

```
你作为蜂巢协调器(Hive Coordinator),收到以下任务:

目标目录: {target_dir}
待研究领域: [{domain_list}]

请对每个领域执行以下操作:

1. 在目标目录下找到该领域的核心源文件(头文件、cpp、cs、shader)
2. 为每个文件构建"上下文包": 
    文件路径 | 关键类型/枚举/常量/结构体 | 关键函数签名 | 与其他文件的引用关系
3. 每个领域打包为一个独立任务,分派给专一 Agent

分派格式:
Agent_{idx}:
  domain: "{具体领域}"
  files: [path1, path2, ...]
  context: 
    - 该领域涉及的核心命名空间
    - 关键枚举/常量(已提取的值)
    - 已知的外部依赖
    - 所有 clamp 边界 / magic number / 默认值（逐字提取，附行号）
    - 本领域的写/读侧、store/read、ping-pong 配对关系
    - 已授权的宿主适配（精度降级、ECS 映射、命名空间重命名等）
  task: "研究 {domain} 的完整算法实现,包括: 
         (a) 数据结构与常量——**逐字提取 clamp 边界、magic number、枚举值、默认值**，不许写"范围省略"
         (b) 算法管线(每步做什么)——**必须深入核函数体内，不只骨架**
         (c) 数据流图(输入→处理→输出)
         (d) Shader 关键字与分支
         (e) 跨文件不变量——写/读侧 cell-key 公式是否逐字节一致？store saturate(p/X) ↔ read ×X 是否配对？ping-pong 写 alt 读 main？
         (f) **假注释检测**: 如果注释声称"已1:1/源默认X/这里等价"，标记供后续验证重点核查
         (g) **假 gate 检测**: 检查 `#if false` / `#if 0` / `if(0)` 是否屏蔽了真代码（历史教训：真实 bug 藏于此模式）
         输出格式为 Markdown,使用 ASCII 图表"

约束:
- 每个 Agent 只研究一个领域,绝不合并
- 上下文包必须包含已提取的枚举值/常量数值,避免 Agent 重复打开文件查找
- 如果某个 Agent 发现子领域,递归 depth+1 再次分派
- depth > max_depth 时停止递归
```

---

## 阶段 2: 收集 (Collect)

```
所有 Agent 返回后,执行收集:

1. 检查是否有 Agent 返回了需要进一步拆分的子领域
   - 若有 → 回到阶段 1, depth+=1
   - 若无 → 进入阶段 3

2. 做交叉引用链接:
   - Agent_A 的输出中引用了 Agent_B 的概念 → 插入双向链接
   - 合并所有 Agent 的输出中的术语表

3. **跨 Agent 配对一致性检测**:
   - 对于宣称"写/读同公式"的配对: 两个 Agent 给出的公式是否逐项一致？
   - 对于宣称"store/read 配对"的缓存: 双方数据是否配套？
   - 若发现矛盾 → 标注为「待核验」进入阶段 3 决策 ⚠️
```

---

## 阶段 3: 融合 (Fuse)

```
将 N 个 Agent 的输出融合为单体报告:

1. 按依赖关系排序章节
2. 统一术语命名(跨 Agent 的同物异名→归一)
3. 合并 ASCII 数据流图为全局图
4. 输出最终文档到 {output_dir}
5. **显式列出每个领域的"已授权偏离"清单**(精度降级、ECS 适配、命名重命名、API 替换)
6. **显式列出每个领域的"范围外非授权"项**(防止后续验证 agent 越界修改)
7. **警示: 后续验证阶段会以"假设所有断言都是错的"为前提重新逐行核真源**——融合报告中的"已1:1"声明不作为最终 verdict
```

---

## 递归示例

```
depth=1: [光照系统]
  ├── Agent_0: 方向光 + CSM
  ├── Agent_1: Punctual 光 + Binning
  └── Agent_2: IBL + 反射探针
  
  → Agent_0 发现子领域 "CSM 级联分割算法"
  
depth=2: [CSM 级联分割]
  ├── Agent_0_0: 级联边界计算(Uniform/Log/PSSM)
  └── Agent_0_1: Shadow Atlas 分配
```

---

## 上下文模板

每个 Agent 启动时的 prompt 结构:

```markdown
## 任务上下文

**领域**: {domain}
**源文件**: [{file_list}]
**已提取常量**:
  - Enum X: {A=0, B=1, C=2}（逐值核对，不缺项）
  - Const Y: {value}（含 clamp 区间、magic number）
  - Struct Z: {field1, field2, ...}
  - 默认值: {ctor/field initializer 默认值}
**依赖外部模块**: [{dependency_list}]
**跨文件配对**: {写侧文件→公式A ↔ 读侧文件→公式B；store side→编码C ↔ read side→编码C}
**授权偏离**: {已声明的宿主适配}

**研究产出要求**:
1. 不要重新打开文件查找常量(已在上下文中)
2. 聚焦于算法逻辑与数据流——**深入核函数体内，不只骨架**
3. 输出 ASCII 管线图
4. 标记任何不确定处为「源未定位」
5. **标记假注释嫌疑**: 注释声称"已1:1"但怀疑与实际不符 → 写进 notes
6. **标记假 gate 嫌疑**: #if false 屏蔽段 → 记录被屏蔽内容
7. **提供后续验证 agent 的核查重点列表**(前 3 条最可能藏 bug 的路径)
```
