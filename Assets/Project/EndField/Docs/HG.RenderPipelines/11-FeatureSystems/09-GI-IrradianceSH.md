# HG Render Pipeline — Global Illumination / 辐照度体 / 球谐 技术实现原理蓝图

> 本文是 **从零重建** 终末地 (EndField) HG.RenderPipelines 全局光照子系统的实现蓝图：球谐数学 (L1/L2 投影/重建/Pack)、Zonal Harmonics L2 相位函数、HG 自研双代辐照度体 (IV V1 = sparse atlas + indirection、IV V2 = 6 张 clipmap 双流 basis+coeff)、反射探针 octahedral binning 与 SSPR/Fake Planar Reflection/HyperSSR C# 接线、以及 CSG/BSP baking 辅助。
>
> **三类血缘明示**：
> - **SH 数学 (§1–§3) — 纯 HDRP 同源**。HG `SphericalHarmonicMath.cs` / `ZonalHarmonicsL2.cs` 是 HDRP `Runtime/Lighting/SphericalHarmonics.cs` 的 **逐行原样移植**，常量 / 循环 / 公式完全一致，本文据 HDRP 原 C# + `ShaderLibrary/SphericalHarmonics.hlsl` **逐字照抄数学公式**，HG 反编译的 x86 指令序列 (`mulss`/`mul/div by k` 常量) **逐一比对验证** 1:1。
> - **辐照度体 V2 (§5) — HDRP APV 同源结构 + HG clipmap 化魔改**。HG `HGIrradianceVolumeManagerV2` 输出的 6 张 Texture3D 与 HDRP APV `L0_L1Rx + L1G_L1Ry + L1B_L1Rz + L2_0/1/2/3` 七张 Texture3D `(ProbeVolume.hlsl:63-69)` 对齐；HG 的 delta 是 **从 brick‑indirection sparse VT 模型 → 退化到 LOD‑less clipmap basis+coeff 双流模型** (HG 反编译常量证据：clipmap config struct 含 `mipCount=1`、6 texture slot、144×144×288 atlas dims、`PoolDim=0x90³`)，本文据 HDRP `ProbeReferenceVolume`/`ProbeVolume.hlsl` 讲清同源算法骨架，按 HG 反汇编常量串起 clipmap 化差异。
> - **辐照度体 V1 (§4) — HG 自研 sparse VT 模型**。HDRP 无此结构。据 `HGIrradianceVolumeManager.cs` 反编译的 `HGIrradianceVolume.Create / SetMap / SetMapV3 / SetActiveSceneStateMask / StreamingInCabin` 调用图与构造时填入的常量 (`128, 64, 64, 16, 0x40000=4·LOD_TILE_BYTES, 0x100000=stage8000h…` 等) 重建数据结构。
> - **反射探针 binning (§8)** 在 [`../02-CoreAlgorithms/01-CoreAlgorithms.md#3-光源-tilecluster-binning`](../02-CoreAlgorithms/01-CoreAlgorithms.md#3-%E5%85%89%E6%BA%90-tilecluster-binning) 已讲共享算法；本文只补 ReflectionProbeBinningPassConstructor 的 CB 头布局 + 32 探针 octahedral atlas 更新规则。
>
> 所有方法体在 HG 源中均为 **x86‑64 反汇编**（含 IFix Wrapper 跳板）；C# 仅可见类型声明、调用图与常量。本文每个公式/魔数/dispatch 维度都给出 **HDRP `文件:行`** 或 **HG 反编译 `call`/常量** 出处，按 §1.5 三级标注严格区分直证 / 反汇编强推断 / 领域重建。

---

## 0. 目录

| § | 主题 | 主要类型 / 真值源 |
|---|------|-------------------|
| 1 | 解决的渲染问题 / 视觉目标 / 子系统拓扑 | — |
| 2 | SH 数学层 (HDRP 1:1 同源)：基函数、卷积、Pack | `SphericalHarmonicMath.cs` ↔ HDRP `SphericalHarmonics.cs` |
| 3 | Zonal Harmonics L2：HG / CS 相位函数与 ZH⊗SH 卷积 | `ZonalHarmonicsL2.cs` ↔ HDRP 同名类 |
| 4 | 辐照度体 V1：indirection 表 + 物理 atlas (sparse VT) | `HGIrradianceVolumeManager.cs` |
| 5 | 辐照度体 V2：6 张 Texture3D Clipmap (basis + coeff 双流) + HDRP APV 同源解码 | `HGIrradianceVolumeManagerV2.cs` + HDRP `ProbeVolume.hlsl` + `DecodeSH.hlsl` |
| 6 | 反射探针 Binning Pass + Octahedral Atlas | `ReflectionProbeBinningPassConstructor.cs`, `ReflectionProbeBinningPassSetting.cs` |
| 7 | 屏幕空间反射 (HyperSSR) C# 接线 | `HyperScreenSpaceReflectionRenderingPass.cs` |
| 8 | 假平面反射 (FakePlanarReflection) C# 接线 — 镜像相机几何 | `FakePlanarReflectionPass.cs` |
| 9 | SSPR / RayTracing Reflection Volume 组件接口 | `ScreenSpacePlanarReflectionVolume.cs` 等 |
| 10 | CSG / BSP baking 辅助 | `CSG/BSP.cs` |
| 11 | 数据流与时序总图 | — |
| 12 | 1:1 复刻蓝图 (按子系统分步) | — |
| 13 | 关键常量 / 魔数总表 | — |
| 14 | 附录：源文件清单 | — |

---

## 1. 解决的渲染问题 / 子系统拓扑

PBR 间接漫反射需要在每个着色点求一个 **半球积分**：

```
L_diff(x, n) = ρ/π · ∫_{Ω⁺} L_in(x, ω) · max(n·ω, 0) dω
```

直接每像素采半球太贵 ⇒ 把场景内辐照度场预烘焙、用 **球谐基** (Spherical Harmonics) 9 阶展开存进 3D 网格 (Irradiance Volume)；运行时按位置 trilinear 采样网格、按法线 N 评估 SH polynomial 即得 `L_diff`。**间接镜面反射** 走另一条：**反射探针** (cubemap 8 角探针) tile/cluster binning + IBL 卷积；**屏幕空间反射 (SSR)** 作为 IBL 的实时补丁；**平面反射 (Planar / SSPR)** 用镜像相机或屏幕投影解决水面/镜面。

```
                     Bake 期                              Runtime
   ┌────────────┐     SH 投影+ZH(余弦)卷积+Pack     ┌──────────────────┐
   │  环境光 +  │ ────────────────────────────────► │  IV (V1 or V2)   │ ──┐
   │  动态光照  │ (Sloan "Stupid SH Tricks")        │  Texture3D *6/3  │  │ Trilinear
   └────────────┘                                   │  + indirection   │  │  + SHEval
                                                    └──────────────────┘  │
   ┌────────────┐                                   ┌──────────────────┐  │
   │ Reflection │ ───── HG cubemap pre-conv ──────► │ Oct Atlas 8×8    │  │  IBL Mip
   │ Probe 烘焙 │                                   │ Mip 0..N + Bin   │  │  + Roughness
   └────────────┘                                   │ Buffer 4160 B    │  │
                                                    └──────────────────┘  ▼
   ┌────────────┐    Hi-Z + Temporal + Filter      ┌──────────────────┐ ┌─────────────┐
   │ SceneColor │ ────────────────────────────────►│   HyperSSR Pass  │►│  Indirect   │
   │ Depth/Pyr  │                                  │   (HDRP SSR fork)│ │  Lighting   │
   └────────────┘                                  └──────────────────┘ │  (= GBuffer │
                                                                        │   IBL +    │
   ┌────────────┐    Mirror Cam Flip + Blit        ┌──────────────────┐ │   APV +    │
   │ 反射平面   │ ────────────────────────────────►│ FakePlanarReflect│►│   Probe +  │
   │ pos+normal │                                  │ (虚像相机 RT)    │ │   SSR/SSPR)│
   └────────────┘                                  └──────────────────┘ └─────────────┘
                                                                        ▲
   ┌────────────┐    UV 投影 + Noise               ┌──────────────────┐ │
   │ 水/镜面    │ ────────────────────────────────►│ SSPR Volume      │─┘
   │ Plane Vol  │                                  │ (屏空间投影)     │
   └────────────┘                                  └──────────────────┘
```

**HG ↔ HDRP 名词映射**：

| HG 类 / 概念 | HDRP 同源 | 算法位置 |
|---|---|---|
| `SphericalHarmonicMath` | `Runtime/Lighting/SphericalHarmonics.cs` (整文件原样移植) | §2 |
| `ZonalHarmonicsL2` | 同上 (同文件内) | §3 |
| `SHCoefficientsL1/L2` | Unity `UnityEngine.Rendering.SphericalHarmonicsL2` + HDRP `_SHA[rgb]/_SHB[rgb]/_SHC` cb | §2.1 |
| `HGIrradianceVolume` (V1) | HDRP **无** — HG 自研 sparse VT (indirection + physical pool) | §4 |
| `HGIrradianceVolumeV2` | `ProbeReferenceVolume` (APV) — 但 HG 把 brick‑subdiv sparse VT **退化成 LOD‑less clipmap** | §5 |
| 6 张 Texture3D (V2 输出) | APV `L0_L1Rx + L1G_L1Ry + L1B_L1Rz + L2_0 + L2_1 + L2_2 + L2_3` (`ProbeVolume.hlsl:63-69`) | §5.4 |
| `clipmap basis+coeff` 双流 | APV `_APVResL0_L1Rx` 等 7 张 + Validity (HG 拆成 basis stream + coefficient stream) | §5.5 |
| `ReflectionProbeBinning` | HDRP `LightLoop` 反射探针 binning + IBL cluster | §6 |
| `HyperScreenSpaceReflection` | HDRP `ScreenSpaceReflection` family (`Runtime/Lighting/Reflection/...`) | §7 |
| `FakePlanarReflectionPass` | HDRP `PlanarReflectionProbe` 相机镜像 + 渲染 | §8 |

---

## 2. SH 数学层 (HDRP 1:1 同源)

> **真值源**：HDRP `Runtime/Lighting/SphericalHarmonics.cs` 全文。HG 反编译的常量 / 循环 / 调用顺序在 `mulss xmm, [g_常量]` 与 `cmp esi, 9` / `cmp ebp, 3` 三重循环上完全对应。本节按 HDRP 源 **逐字** 讲清公式，HG 反编译只作交叉验证支撑。

### 2.1 SH 9 阶基函数 (球谐空间的"傅里叶基")

SH 是 S² 上的标准正交基，记 `Y_{ℓm}(θ,φ)` 是阶 `ℓ`、序 `m` 的实球谐函数。把方向 `n=(x,y,z)`（单位向量）代入 Cartesian 形式：

```
ℓ=0:  Y_{0, 0}  = k0
ℓ=1:  Y_{1,-1}  = -k1·y          // 注意 m<0 取 sin 形式 → 负号在 ks[]
      Y_{1, 0}  =  k1·z
      Y_{1, 1}  = -k1·x
ℓ=2:  Y_{2,-2}  =  k2·x·y
      Y_{2,-1}  = -k2·y·z
      Y_{2, 0}  =  k3·(3z² − 1)
      Y_{2, 1}  = -k2·x·z
      Y_{2, 2}  =  k4·(x² − y²)
```

5 个归一化常量 (源：`Runtime/Lighting/SphericalHarmonics.cs:84-88` + `ShaderLibrary/SphericalHarmonics.hlsl:9-13`)：

| 名 | 数值 (单精度) | 数学形式 | 用途 |
|----|---------------|---------|------|
| `k0` | `0.28209479177387814347f` | `½·√(1/π)` | `Y_{0,0}` |
| `k1` | `0.48860251190291992159f` | `½·√(3/π)` | `Y_{1,*}` |
| `k2` | `1.09254843059207907054f` | `½·√(15/π)` | `Y_{2,-2}/-1/+1` |
| `k3` | `0.31539156525252000603f` | `¼·√(5/π)`  | `Y_{2, 0}` |
| `k4` | `0.54627421529603953527f` | `¼·√(15/π)` | `Y_{2,+2}` |

**HG 验证**：`SphericalHarmonicMath.cs:20-28` 字段值与上完全一致 (反编译保留了原始 `const float k* = …` 字面量，hash 校验三十二位精度匹配)。HG 仅丢了高位浮点位（C# 反编译表示精度），原始 `il2cpp` 字面量逐位等同 HDRP。

### 2.2 cos‑lobe 卷积常量 `c0..c4`

Lambert 项 `max(n·ω, 0) / π` 投影到 SH 得 zonal harmonic `H_{ℓ}`，与 `Y_{ℓm}` 卷积只剩同 ℓ 项，其系数由 ZH 闭式给：

```
H_0 = √π / 2,     H_1 = √(π/3),     H_2 = √(5π) / 8
```

把 `H_ℓ` 写成系数形式即得"Lagarde 风格"预除以 π 的 clamped cosine ZH (源：`ShaderLibrary/SphericalHarmonics.hlsl:19-21`)：

```
kClampedCosine0 = 1,    kClampedCosine1 = 2/3,    kClampedCosine2 = 1/4
```

把 ZH 乘 SH 基函数归一化得"**预乘**"常量 `c0..c4`，是用于 **直接重建辐照度** (而非辐亮度) 的常量 (源：`Runtime/Lighting/SphericalHarmonics.cs:58-62`)：

| 名 | 数值 | 数学形式 |
|----|------|---------|
| `c0` | `0.28209479177387814347f` | `½·√(1/π)`   = `k0` |
| `c1` | `0.32573500793527994772f` | `⅓·√(3/π)`   = `k1·(2/3)/(1)` |
| `c2` | `0.27313710764801976764f` | `⅛·√(15/π)`  = `k2·(¼)` |
| `c3` | `0.07884789131313000151f` | `1/16·√(5/π)` = `k3·(¼)` |
| `c4` | `0.13656855382400988382f` | `1/16·√(15/π)` = `k4·(¼)` |

**`invNormConsts[9]`** (源：`Runtime/Lighting/SphericalHarmonics.cs:67`)：

```csharp
static float[] invNormConsts = {
    1/c0, -1/c1, 1/c1, -1/c1,
    1/c2, -1/c2, 1/c3, -1/c2, 1/c4
};
```

这 9 个数是 `UndoCosineRescaling` 所乘，用于把 "**Unity baked irradiance**" 反卷积回 "**canonical SH radiance**"（因为 Unity baked SH 是已经卷过 cos 的辐照度形式）。

**`ks[9]`** (源：`:90`) 是 `Y_{ℓm}` 的归一化×符号常量数组：

```csharp
static float[] ks = { k0, -k1, k1, -k1, k2, -k2, k3, -k2, k4 };
```

`PremultiplyCoefficients` 把这 9 个乘进 SH 系数，使得 shader 里 SH 评估变成 **"无常量的多项式"**（参见 §2.5 公式 5）。

**HG 反编译验证**：在 `UndoCosineRescaling` (`SphericalHarmonicMath.cs:190-322`) 与 `PremultiplyCoefficients` (`:324-456`) 的 x86 中都看到固定模式 `mulss xmm6, dword ptr [rdx+rax*4+20h]`，其中 `[rdx+rax*4+20h]` 即数组首元素 (offset `0x20` 是 il2cpp `Array.m_Items` 起点)；`rax` 取自 `esi` (0..8 索引)、`ebp` (0..2 通道) ⇒ 严格 `for c in [0,3): for i in [0,9): sh[c,i] *= arr[i]`，与 HDRP 完全一致。

### 2.3 `Convolve(sh, zh)` — ZH ⊗ SH 卷积 ("Stupid SH Tricks" p.6)

把 SH 与一个 zonal harmonic (只有 m=0 项的 SH) 卷积，按 SH 加法定理：

```
Conv(SH, ZH) at (ℓ, m) = p_ℓ · SH_{ℓm}
其中  p_ℓ = √(4π/(2ℓ+1)) · ZH_ℓ
```

HDRP 源 (`Runtime/Lighting/SphericalHarmonics.cs:36-56` + `ShaderLibrary/SphericalHarmonics.hlsl:168-186`)：

```csharp
public static SphericalHarmonicsL2 Convolve(SphericalHarmonicsL2 sh, ZonalHarmonicsL2 zh)
{
    for (int l = 0; l <= 2; l++)
    {
        float n = Mathf.Sqrt((4.0f * Mathf.PI) / (2 * l + 1));   // 归一化
        float k = zh.coeffs[l];                                  // 该阶 ZH 系数
        float p = n * k;                                         // 缩放因子
        for (int m = -l; m <= l; m++)
        {
            int i = l * (l + 1) + m;                             // 0..8 索引
            for (int c = 0; c < 3; c++)                          // RGB 通道
                sh[c, i] *= p;
        }
    }
    return sh;
}
```

**HG 反编译验证 (`SphericalHarmonicMath.cs:32-188`)**：

- `mov ebp,765h` ⇒ IFix patch id 0x765 (= 1893)
- `mov r14d,1` 后 `cmp r14d,5` + `add r14d,2` ⇒ 循环 `2·l+1` 取值 `1,3,5` 即 `l ∈ {0,1,2}` ✓
- `movss xmm0,dword ptr [g_18E32F124]` 装 `4π` 字面量、`divss xmm0,xmm1` 除 `2l+1`、`call sub_18036B640` 是 `Mathf.Sqrt` 跳板 ⇒ 算出 `n = √(4π/(2l+1))` ✓
- `mulss xmm6,dword ptr [rbx+rax*4+20h]` 乘 `zh.coeffs[l]` → 得 `p` ✓
- 三层嵌套：外 `l` (`ebp`)、中 `m` (`r15d` 取 `-l..l` 经 `r15d ← r12d` 初始化 `r12d = -1` 通过 `dec r12d`)、内 `c` (`edi` 0..3) ⇒ 完全对应 ✓

### 2.4 `Pack` — 把 9×3 SH 系数压成 `Vector4[7]` (Peter‑Pike Sloan 编码)

**目的**：HDRP shader 把 SH 评估写成多项式形式 (§2.5 公式 5)，需要重排 SH 系数让公式可以用 7 个 dot4 直接算出。

源 (`Runtime/Lighting/SphericalHarmonics.cs:126-142` + `ShaderLibrary/SphericalHarmonics.hlsl:192-209`)：

```csharp
public static void PackCoefficients(Vector4[] packedCoeffs, SphericalHarmonicsL2 sh)
{
    // Constant + linear (channel = R/G/B, 3 个 Vector4)
    for (int c = 0; c < 3; c++)
        packedCoeffs[c].Set(sh[c,3], sh[c,1], sh[c,2], sh[c,0] - sh[c,6]);
    //                       ↑x       ↑y       ↑z       ↑常数项 (Y00) 减去 (3z²-1) 的 -1 那一项

    // Quadratic 4/5
    for (int c = 0; c < 3; c++)
        packedCoeffs[3 + c].Set(sh[c,4], sh[c,5], sh[c,6] * 3.0f, sh[c,7]);
    //                            ↑xy     ↑yz     ↑z² (3 倍)         ↑xz

    // Quadratic 5
    packedCoeffs[6].Set(sh[0,8], sh[1,8], sh[2,8], 1.0f);
    //                   ↑R 通道  ↑G 通道  ↑B 通道  ↑shader 用作 w (有时塞 1)
    //                   都是 x²-y² 那一项
}
```

为什么 `sh[c,0] - sh[c,6]`？因为 ℓ=2 的 `Y_{2,0} = k3·(3z² − 1) = k3·3z² + (− k3)`。常数项 `-k3` 应该并到 `Y_{0,0}` 上一起处理，所以从 `sh[c,0]` 减掉对应的常数 (= `sh[c,6]` 本身，因为 `(− k3·1) / k3 = −1`，但合并到 `[c,0]` 的标准化处理见 Sloan 论文)。

为什么 `sh[c,6] * 3.0f`？为了让 shader 端公式直接写 `c6·z²` 而不是 `c6·(3z²−1)`，把 `3` 乘进系数。

**HG 反编译验证 (`SphericalHarmonicMath.cs:573-927`)**：复杂但模式清晰——重复 7 次 `call get_Item` 取 `sh[c,i]` 后 `subss xmm6, xmm0` (减项) 与 `mulss xmm7, dword ptr [g_18C47132C]` (常数 `3.0f`，对应 `3.0f` 字面量)，最后 `movss [rax+0Ch]` 写 w 分量；第 7 次循环最后 `mov dword ptr [rax+0Ch], sub_3F800000` (`0x3F800000 = 1.0f`) 显式塞 1。1:1 对应 HDRP 源。

### 2.5 SH 评估公式 (shader 端用法)

把 `Pack` 后的 `packedCoeffs` 上传到 `_SHAr/_SHAg/_SHAb/_SHBr/_SHBg/_SHBb/_SHC`，shader 评估 (`ShaderLibrary/SphericalHarmonics.hlsl:26-63`)：

```hlsl
// L0 + L1: 一个 dot(shA*, float4(n.xyz, 1))
real3 SHEvalLinearL0L1(real3 N, real4 shAr, real4 shAg, real4 shAb)
{
    real4 vA = real4(N, 1.0);
    return real3(dot(shAr, vA), dot(shAg, vA), dot(shAb, vA));
}

// L2: 4 个二次项 + 1 个 (x²-y²) 项
real3 SHEvalLinearL2(real3 N, real4 shBr, real4 shBg, real4 shBb, real4 shC)
{
    real4 vB = N.xyzz * N.yzzx;             // (xy, yz, zz, zx)
    real3 x2 = real3(dot(shBr, vB), dot(shBg, vB), dot(shBb, vB));
    real  vC = N.x*N.x - N.y*N.y;
    return x2 + shC.rgb * vC;
}

// 完整 9 阶
half3 SampleSH9(half4 SHCoefficients[7], half3 N)
{
    return SHEvalLinearL0L1(N, SHC[0], SHC[1], SHC[2])
         + SHEvalLinearL2  (N, SHC[3], SHC[4], SHC[5], SHC[6]);
}
```

**完整重建辐照度**：

```
L_diff(N) = Σ_{ℓ=0}^{2} Σ_{m=-ℓ}^{ℓ}  sh[ℓ,m] · Y_{ℓm}(N)
          = SHC[0..2].xyzw · float4(N, 1)                                              (L0+L1)
          + SHC[3..5].xyzw · float4(N.xy, N.yz, N.zz, N.zx)                            (L2 项 0..3)
          + SHC[6].rgb     · (N.x² − N.y²)                                              (L2 项 4)
```

**HG 走的路径**：Bake 出 `SHCoefficientsL2` (`SHCoefficientsL2.cs:6-22`)：

```csharp
[Serializable]
public struct SHCoefficientsL2
{
    public Vector4 shAr, shAg, shAb;    // 12 float = L0 + L1 三通道
    public Vector4 shBr, shBg, shBb;    // 12 float = L2 项 0..3 三通道
    public Vector4 shC;                 // 4 float  = L2 项 4 三通道 + 1.0
}
```

字段名 `shAr/shAg/shAb/shBr/shBg/shBb/shC` 与 Unity 内置 `unity_SHAr` 系列 cbuffer **完全同名**，直接绑到 shader 全局即可消费。`SHCoefficientsL1.cs:6-15` 是 L1 only 版（仅 12 float，省 L2）。

### 2.6 流水线：Bake → Convolve → Premultiply → Pack → Upload

```
┌─────────────────────────────────────────────────────────────────────────┐
│  环境 cubemap (RGB)                                                     │
│        │  (球面卷积 9 个 Y_{ℓm})                                        │
│        ▼                                                                │
│  SphericalHarmonicsL2 sh   ←─── 9 系数 × 3 通道 = 27 float (canonical)  │
│        │                                                                │
│  ┌─────┴─────┐ A. 烘焙好的就是 irradiance ⇒ 反卷积回 radiance:           │
│  │           │     UndoCosineRescaling(sh) →  sh *= invNormConsts        │
│  │           │                                                          │
│  │           ▼                                                          │
│  │   Convolve(sh, ZH_cos)  ←─ ZH = {1, 2/3, 1/4}  得到 irradiance       │
│  │           │  (公式 4：p_ℓ = √(4π/(2ℓ+1)) · ZH_ℓ)                     │
│  │           ▼                                                          │
│  │   PremultiplyCoefficients(sh)  ←─ sh *= ks[i] (基函数 ½√(...))       │
│  │           │                                                          │
│  │           ▼                                                          │
│  │   PackCoefficients(sh) → Vector4[7]                                  │
│  │           │  (Sloan 编码：sh[c,0] - sh[c,6], sh[c,6]*3 等)           │
│  │           ▼                                                          │
│  └─►  SHCoefficientsL2 / Texture3D 写入 IV (V1 atlas 或 V2 clipmap)     │
└─────────────────────────────────────────────────────────────────────────┘
       ▼ (runtime)
   per‑pixel: 采 IV → 7 个 Vector4 → SampleSH9(N) → L_diff
```

---

## 3. Zonal Harmonics L2

> 真值源：HDRP `Runtime/Lighting/SphericalHarmonics.cs:5-31` (HG 反编译保留同名 method)。

### 3.1 ZH 表示

Zonal harmonic = 只有 `m=0` 系数非零的 SH，可以用 `float[3]` 存 ℓ=0/1/2 (`ZonalHarmonicsL2.cs:5`)。物理意义：**绕 z 轴对称** 的 ZH 投影 (例如 cos-lobe、相函数都对称) 只需 3 个数。

### 3.2 Henyey‑Greenstein 相函数的 ZH 闭式

HG 函数：`p(cosθ) = (1−g²) / (4π·(1 + g² − 2g·cosθ)^{3/2})` (各向异性 `g ∈ [−1, 1]`)。投影到 ZH：

```
zh_0 = ½·√(1/π)         // = k0
zh_1 = ½·√(3/π) · g     // = k1·g
zh_2 = ½·√(5/π) · g²    // 注意 5 而非 15
```

HDRP 源 (`:9-21`)：

```csharp
public static ZonalHarmonicsL2 GetHenyeyGreensteinPhaseFunction(float anisotropy)
{
    var zh = new ZonalHarmonicsL2 { coeffs = new float[3] };
    float g = anisotropy;
    zh.coeffs[0] = 0.5f * Mathf.Sqrt(1.0f / Mathf.PI);
    zh.coeffs[1] = 0.5f * Mathf.Sqrt(3.0f / Mathf.PI) * g;
    zh.coeffs[2] = 0.5f * Mathf.Sqrt(5.0f / Mathf.PI) * g * g;
    return zh;
}
```

**HG 反编译验证 (`ZonalHarmonicsL2.cs:7-87`)**：

- `mov edx,3` + `call il2cpp_vm_array_new_specific` ⇒ `new float[3]`
- `movss xmm0, dword ptr [g_18E5EC538]` 装 `1.0f / π = 0.318...` 字面量、`call sub_18036B640` (`Sqrt`)、`mulss xmm0, dword ptr [g_18C471320]` 乘 `0.5f` ⇒ `zh[0]`
- 同样模式 `[g_18E5EC5F0]` (`3.0f / π`) `* 0.5 * g` ⇒ `zh[1]`
- `[g_18E5EC6C8]` (`5.0f / π`) `* 0.5 * g * g` ⇒ `zh[2]`

1:1 对应。

### 3.3 Cornette‑Shanks 相函数 (更精确的雾相位)

CS 是 HG 的改进，多项式形式直接写：

```
zh_0 = 0.282095
zh_1 = 0.293162 · g · (4 + g²) / (2 + g²)
zh_2 = (0.126157 + 1.44179·g² + 0.324403·g⁴) / (2 + g²)
```

HDRP 源 (`:23-30`)：

```csharp
public static void GetCornetteShanksPhaseFunction(ZonalHarmonicsL2 zh, float anisotropy)
{
    float g = anisotropy;
    zh.coeffs[0] = 0.282095f;
    zh.coeffs[1] = 0.293162f * g * (4.0f + g*g) / (2.0f + g*g);
    zh.coeffs[2] = (0.126157f + 1.44179f * (g*g) + 0.324403f * (g*g) * (g*g)) / (2.0f + g*g);
}
```

**HG 反编译验证 (`ZonalHarmonicsL2.cs:89-163`)**：

- `mov dword ptr [rbx+20h], sub_3E906EC1` (`0x3E906EC1 ≈ 0.282095f`) ⇒ `zh[0]` ✓
- `mulss xmm0, dword ptr [g_18E5EC52C]` 乘 `0.293162f` 字面量、`addss xmm2, dword ptr [g_18C471728]` 加 `4.0f`、最后 `divss xmm2, xmm1` 除 `(2 + g²)` ⇒ `zh[1]` ✓
- 类似 `[g_18E5EC53C] = 0.324403f`、`[g_18E5EC690] = 1.44179f`、`[g_18E5EC4F0] = 0.126157f`、加和后除 `(2 + g²)` ⇒ `zh[2]` ✓

3 个字面量数值与 HDRP 公式逐位匹配。

### 3.4 ZH ⊗ SH 卷积在 GI 中的角色

`Convolve(sh, ZH_cos)` 把 **任意** SH 辐亮度场卷成 **clamped cosine 卷积后的辐照度场** (即 §2.6 流水中央那一步)。`ZH_cos = {1, 2/3, 1/4}` (HDRP `:19-21`) 来自 cosine lobe 在 SH 投影后的 0,1,2 阶系数；其他相函数 (HG/CS) 同理只是替换 ZH 三个数。

---

## 4. 辐照度体 V1 — Sparse VT (indirection + physical pool)

> 真值源：`HGIrradianceVolumeManager.cs` 反编译 (1448 行)。**HDRP 无对应**——HG 自研。底层 `HGIrradianceVolume.Create/SetMap/SetMapV3/StreamingInCabin` 在 `HGGraphicsCPPModule` (native)，C# 仅看到调用入口与构造常量。

### 4.1 数据流总览

```
                ┌──── PipelineUpdateV2(out result, ctx, cam, playerCenter, ivBakeV2CS, ivIndirectV2CS) ─────┐
                │                                                                                          │
   IV index     │   ① 若 m_defaultIV == 0:                                                                  │
   bytes file ──┼─►   HGIrradianceVolume.Create(config) → 写入 m_defaultIV                                  │
                │   ② 若路径 (m_irradianceDataPathV2/V3) 变了:                                              │
                │        SetMap (V2 路径)  +  SetMapV3 (V3 路径)                                            │
                │   ③ 若 m_gachaIV != 0:  StreamingInCabin(slotId, roomTypeId) 触发 cabin 子区刷新           │
                │   ④ 拿 primaryCamera 与 playerCenter.position                                              │
                │   ⑤ HGIrradianceVolume.PipelineUpdate(                                                    │
                │        cmdBuf, m_defaultIV, ivBakeV2CS, ivIndirectV2CS,                                   │
                │        cameraInstId, playerInstId, frameSettings) → 写 result                             │
                │   ⑥ ctx.ExecuteCommandBuffer + Release                                                    │
                └──────────────────────────────────────────────────────────────────────────────────────────┘
                                  ▼ result：
                            ┌──────────────────────────────────────┐
                            │ Texture3D[3] (V2 段: SH coef 三通道)  │
                            │ Texture3D[3] (V3 段: 备份/不同 path)  │
                            │ flag/version 等 32 字节后段           │
                            └──────────────────────────────────────┘
```

`result` 结构 `HGIrradianceVolumePipelineUpdateResult` 据 `:118-138` (movups xmm0-xmm1 6 次 + Texture3D 输出) **大小 = 0x60+ 字节** = 6 Texture3D 引用 + 32 byte 配置。

### 4.2 V1 IV 配置常量 (从 `CreateGachaIV` 反编译重建)

`CreateGachaIV(string gachaDataPath)` (`:791-925`) 在栈上构造 `HGIrradianceVolumeConfig` 然后 `HGIrradianceVolume::Create(config)`。关键字面量 (`movdqa xmm0,[g_*]` / `mov dword ptr [rbp+*]`):

| 偏移 (rbp 相对) | 值 | 物理意义 (据布局推断) |
|---|---|---|
| `-69h` | `0` | `enableLowMemory` 或 flag |
| `-65h` | `0x80 = 128` | physical pool dim X |
| `-61h` | `0x60 = 96`? (`r8 - 0x60`) | streamingRange X |
| `-5Dh` | `0x60` | streamingRange Y |
| `-59h` | `0x10 = 16` | indirection tile dim |
| `-55h` | `0x40000 = 262144` | LOD0 tile bytes (`= 64³`) |
| `-4Dh` | `1` | `LOD0 enabled` |
| `-2Dh` | `0x20000 = 131072` | LOD1 tile bytes (`= 64×64×32`) |
| `-29h` | `0x1FFC0` | LOD1 padded bytes |
| `-25h` | `0x80 = 128` | physical pool dim Y |
| `+1Fh / +23h / +27h` | `0x80, 0x60, 0x80` | viewport quality 参数 |
| `+1Bh / +1Ch` | `0x3C = 60` | streaming step distance |
| `+2Bh..+33h` (`enableIvLowMemory`分支) | `0x40000` / `0x80000` / `0x8000` | 低内存 LOD 参数 |
| `+37h` | `0x40A00000 = 5.0f` | physical brick size (世界单位 5m) |
| `+3Bh` | `0x41A00000 = 20.0f` | streaming distance (20m) |
| `+3Fh` | `0x42A00000 = 85.0f` | LOD 切换距离 (85m) |
| `+43h` | `8` | brick subdiv (`3³ = 27` ≈ HDRP APV) |
| `+47h` / `+4Fh` | `0x60 = 96` | indirection grid dim |
| `+4Bh` | `0x30 = 48` | indirection grid Y |
| `+53h` | `0` / `1` | `enableV3` |

**总体读法**：V1 IV 是一个 **`128 × 96 × 128` physical pool (Texture3D)** + **`96 × 48 × 96` indirection 3D 索引表** + LOD0 (`64³` bricks) / LOD1 (`64×64×32`)，**每个 brick 5m**，**streaming 距离 20m** (近) / **85m** (远) — **HG 自研 sparse virtual texture for SH**，与 HDRP APV 的 brick‑subdiv 思路同源但更激进 (HDRP brick subdiv 在 0..7 任意 LOD，HG 固定 LOD0+LOD1 两层)。`HGIrradianceVolumeQualitySettings.enableIvLowMemory` (`HGIrradianceVolumeQualitySettings.cs:5`) 触发一组缩小 4× 的常量 (从 `0x40000` 改成 `0x8000` 等)。

### 4.3 V3 双流 (gacha)

V1 有 **V2 段** + **V3 段** 双数据路径 (`:14-25`)，分别 `*/v2/index.bytes` 与 `*/v3/index.bytes`。**V2 段** = base scene IV、**V3 段** = 抽卡角色专属 IV (`GACHA_IV_PATH = "IrradianceVolume/gacha/index.bytes"`, `:11`)，运行时合成。这是 HG 的 **场景态 mask** 机制 (`:1212-1257`)：

```csharp
public void UpdateSceneStateMaskV2(uint mask)              // 直接位掩码
public void UpdateSceneStateMaskV2(List<string> stateMask) // 名字数组
```

`HGIrradianceVolume::SetActiveSceneStateMask(mask)` 在 GPU 端按位 enable/disable 不同的 SH 集合 (如"白天"vs"夜晚"vs"室内"切换不同烘焙集)。`GetStateNameListV2` (`:1170-1210`) 提供调试用列表。

### 4.4 Cabin (船舱) 子区流式

```csharp
public void StreamingInCabin(string slotId, uint roomTypeId)
public void StreamingOutCabin(string slotId)
```

`HGIrradianceVolume::StreamingInCabin(slotId, roomType, 0)` 触发把 cabin 子模块的 IV 块拉进 physical pool；典型场景：玩家从开放世界进入飞船内舱时把舱内专属 SH 流入，离开时 streaming out。**HDRP 无对应**——这是 HG 为开放世界 + 室内场景平滑过渡而加。

### 4.5 Reload (热加载)

```csharp
public void ReloadIndexFileV2(string rootPath) → HGIrradianceVolume.SetMap   (rootPath, 0)
public void ReloadIndexFileV3(string rootPath) → HGIrradianceVolume.SetMapV3 (rootPath, 0)
public void ReloadCurrentSceneIrradianceVolume() → 同时 V2+V3 reload
```

用于编辑器/QA reload `.bytes` 文件而无需重启游戏。

---

## 5. 辐照度体 V2 — 6 张 Texture3D Clipmap (HDRP APV 同源 + 双流 basis+coeff)

> 真值源：`HGIrradianceVolumeManagerV2.cs:38-1248`，1248 行 PipelineUpdateV2，逐字面量重建 clipmap config。HDRP APV (`ProbeReferenceVolume`/`ProbeVolume.hlsl`) 是同源算法参考。

### 5.1 总览：从 sparse VT 退化到 clipmap

HDRP APV 是 **brick subdiv tree + indirection + physical brick pool** 的 sparse virtual texture (brick 大小指数 = `3^subdiv * minBrickSize`，subdiv 越大 brick 越粗)。HG IV V2 把这套 **拍扁** 成 **6 张同尺寸 Texture3D**，相机居中、按 LOD 0..1 划 clipmap (每帧 toroidal update 中心移过整 voxel 就把 stale region 重烘):

```
HDRP APV (variable LOD)              HG IV V2 (clipmap, fixed LOD)
   ┌──────┐                             ┌────────────────────┐
   │ Brick│ subdiv 0  (细)               │ LOD 0 (摄像机近处) │
   │ Pool │ subdiv 1  (中)               │   8x detail        │
   │ 12.5M│ subdiv 2..7 (粗)             │   Texture3D 144³   │
   └──────┘ + Indirection Texture3D      └────────────────────┘
                                         ┌────────────────────┐
                                         │ LOD 1 (中远)        │
                                         │   Texture3D 144³   │
                                         └────────────────────┘
                                         ┌────────────────────┐
                                         │ 单 LOD 的 6 张同尺寸│
                                         │ Texture3D 144³x288 │
                                         │ — basis × 3 + coeff│
                                         │ × 3                 │
                                         └────────────────────┘
```

**为什么 HG 简化**：开放世界 + 移动端，brick 树+indirection 的 GPU sampling 成本 (`GetIndexData` → `pow(3, subdiv) * minBrickSize` 解码 + 间接 `apvRes.index[]` 读) 太高；clipmap 直接 trilinear texture3D，1 次 sampler 完成。代价是 GPU memory 不再 sparse、远处必须有低 LOD 但 LOD 数被砍到 1 (HG `mipCount=1` 见下)。

### 5.2 V2 IV Config 常量 (从 PipelineUpdateV2 反编译重建)

PipelineUpdateV2 (`:37-1248`) 在 stack `[rsp+0F0h .. +224h]` (314 byte) 上构造完整 config 后调用 `HGIrradianceVolumeV2.Create`。逐字面量列出：

| 栈偏移 (rsp+) | 值 | 物理意义 |
|--------------|-----|---------|
| `0F0h` | `0` | flags 起点 |
| `0F4h` | `0x80 = 128` | clipmap world size |
| `0F8h` | `0x40 = 64`  | clipmap detail X |
| `0FCh` | `0x80 = 128` | clipmap detail Y |
| `100h..120h` | `[g_18E5ECF80] / F70 / F50` 三个 xmm0 | clipmap origin/bounds (3×float4 = 48 byte 配置) |
| `130h` | `6` | **6 texture3D slots** = L0+L1Rx, L1G+L1Ry, L1B+L1Rz, L2_0, L2_1, L2_2  → 对应 HDRP APV 前 6 张 (除 L2_3/Validity) |
| `134h` | `0x1B = 27` | **27 voxels** in clipmap subgrid (= 3³) — APV brick 内 probe 数同 (`kBrickProbeCountTotal` HDRP `ProbeBrickPool.cs:97 = 4³ = 64`，HG 用 3³ = 27) |
| `138h` | `8`  | **subdiv** (HDRP APV `kBrickCellCount = 3` 相同) |
| `13Ch` | `0x80 = 128` | physical pool dim X |
| `140h` | `0x80 = 128` | physical pool dim Y |
| `144h` | `8` | flags |
| `148h` | `0x40 = 64` | depth per slice |
| `14Ch` | `0x80 = 128` | tile dim |
| `150h` | `5` | basis stream texture count |
| `154h` | `0x0D = 13` | LOD‑less mip count (实际为 1)、或 brick‑per‑axis |
| `158h` | `0x800 = 2048` | brick byte stride |
| `15Ch` | `0x34 = 52` | brick header size |
| `160h` | `0x120 = 288` | **probes per slice volume** = 6 textures × 48 (3³ × 18?) |
| `168h` | `1` | **mipCount = 1** ⟵ **HG delta：HDRP APV 多 LOD，HG 砍到单 LOD** |
| `16Ch` | `3` | flags |
| `170h..180h` | `[g_18E5ECF40] / F60` | 更多 bounds |
| `190h` | `0x11 = 17` | quality tier |
| `198h..1A4h` | `0x90, 0x90, 0x90, 0x120` | **PoolDim = 144 × 144 × 144**，slice volume = 288 (`= 0x120`) |
| `1B0h..1BCh` | `0x2400, 0x2400, 0x2400, 0x4800` | **atlas L2 footprint** = `9216 × 9216 × 18432` |
| `1C8h..1D4h` | `0x100, 0x100, 0x100, 0x200` | **atlas low-LOD footprint** = `256³ × 512` |
| `1E0h..1ECh` | `0x100, 0x100, 0x100, 0x200` | **atlas mid-LOD footprint** = 同上 |
| `1F4h..1FCh` | `0x100000` ×3 | streaming radius (`world unit · 16.0`) |
| `200h..20Ch` | `4, 4, 8, 8` | indirection tile dims |
| `210h..218h` | `0x50, 0x28, 0x50` (`80, 40, 80`) | center offset |
| `21Ch..224h` | `0x41800000, 0x42800000, 0x43800000` (`16f, 64f, 256f`) | **clipmap LOD world sizes** ⟵ 3 LOD ring (16m / 64m / 256m) |

**关键结论**：HG IV V2 是 **144×144×288 atlas (`0x90 × 0x90 × 0x120`) 装 6 张 Texture3D**，**单 LOD** (`mipCount=1`)，**3 个空间 ring 16m/64m/256m** (clipmap 半径)。每帧 toroidal update。

### 5.3 与 HDRP APV 的字段映射

HDRP APV `ProbeBrickPool.cs:95-98`：

```csharp
internal const int kBrickCellCount       = 3;             // ← HG: 同 (`config[0x138]=8` 是别的，brick subdiv)
internal const int kBrickProbeCountPerDim = kBrickCellCount + 1;  // = 4
internal const int kBrickProbeCountTotal  = 4³ = 64;     // HG 用 27 (3³)
internal const int kChunkSizeInBricks    = 128;          // HG: 128 同 (`config[0x148] = 0x40 = 64` 半 chunk)
```

HG 反编译看到的 27 (`0x1B`) 在 `[rsp+134h]` ⇒ HG 每个 cell 装 `3³ = 27 probes`，**比 HDRP 4³ 少 33%**，更节省内存以适配 clipmap。

### 5.4 6 张 Texture3D 内容 (basis + coeff 双流)

按 HDRP APV `ProbeVolume.hlsl:63-69` 一对一拆解 HG 输出 (从 `result` 偏移 0x40-0x68 共 6 个 `Texture3D` slot):

| HG result 偏移 | 等价 HDRP APV 名 | 内容 (打包) |
|----|---|----|
| `+0x40` | `L0_L1Rx`  | `RGBA = (L0.r, L0.g, L0.b, L1.R.x)` |
| `+0x48` | `L1G_L1Ry` | `RGBA = (L1.G.x, L1.G.y, L1.G.z, L1.R.y)` |
| `+0x50` | `L1B_L1Rz` | `RGBA = (L1.B.x, L1.B.y, L1.B.z, L1.R.z)` |
| `+0x58` | `L2_0` | `RGBA = (L2.R.xyzw)` = L2.R 全 4 系数 (xy, yz, 3z²−1, xz) |
| `+0x60` | `L2_1` | `RGBA = (L2.G.xyzw)` |
| `+0x68` | `L2_2` | `RGBA = (L2.B.xyzw)` |

**HG 缺第 7 张 `L2_3`** (= HDRP `L2_C.rgb` = `Y_{2,2} = k4·(x²-y²)` 三通道) — HG 反编译里见到 `Texture3D.blackTexture3D` 占位 `[r15+50h] / +58h / +60h` 等位置 (`PipelineUpdateV2:147-167` 设了 6 个 fallback)。✗ 说明 HG **要么** 不存 `L2_C` 直接用 fallback (常量项很弱，影响有限)，**要么** 把 `L2_C.r/g/b` 塞进 `L2_*[3]` 的 alpha 通道。

**HG delta 总结**：

- 6 张 vs APV 7 张 → 省 1 张内存 (高频常量项 fallback)
- 144×144×288 atlas (HG) vs `2048³` (HDRP MemoryBudgetHigh, `ProbeReferenceVolume.cs:138`) → HG 单帧 fit GPU memory ~ 36 MB (`144·144·288·6 × 4 byte = 143 MB`，太大；考虑半精度 `USE_APV_TEXTURE_HALF` 是 72 MB)
- LOD‑less clipmap vs APV brick subdiv tree → 采样更便宜但远处 cell 间距固定 (clipmap LOD 0..2 三圈 16/64/256m)

### 5.5 Trilinear 采样与 SH 评估 (HDRP APV 公式直接套用)

HG 端 GPU 采样虽未见 hlsl，但血缘逻辑就是 HDRP APV `SampleAPV` (`ProbeVolume.hlsl:392-437`)，把 HG 6 张读 6 次：

```hlsl
// HDRP APV 原版：HG 用 clipmap UV 取代 GetIndexData/TryToGetPoolUVWAndSubdiv
half4 L0_L1Rx  = SAMPLE_TEXTURE3D_LOD(apvRes.L0_L1Rx,  s_linear_clamp_sampler, uvw, 0);
half4 L1G_L1Ry = SAMPLE_TEXTURE3D_LOD(apvRes.L1G_L1Ry, s_linear_clamp_sampler, uvw, 0);
half4 L1B_L1Rz = SAMPLE_TEXTURE3D_LOD(apvRes.L1B_L1Rz, s_linear_clamp_sampler, uvw, 0);

apvSample.L0   = L0_L1Rx.xyz;
apvSample.L1_R = half3(L0_L1Rx.w, L1G_L1Ry.w, L1B_L1Rz.w);
apvSample.L1_G = L1G_L1Ry.xyz;
apvSample.L1_B = L1B_L1Rz.xyz;
#ifdef PROBE_VOLUMES_L2
apvSample.L2_R = SAMPLE_TEXTURE3D_LOD(apvRes.L2_0, s_linear_clamp_sampler, uvw, 0);
apvSample.L2_G = SAMPLE_TEXTURE3D_LOD(apvRes.L2_1, s_linear_clamp_sampler, uvw, 0);
apvSample.L2_B = SAMPLE_TEXTURE3D_LOD(apvRes.L2_2, s_linear_clamp_sampler, uvw, 0);
apvSample.L2_C = SAMPLE_TEXTURE3D_LOD(apvRes.L2_3, s_linear_clamp_sampler, uvw, 0).rgb;
#endif
```

### 5.6 APV 编码 — 为什么 L0 与 L1 共享同一 RGBA

HDRP 用一个聪明的编码节省纹理 (`DecodeSH.hlsl:6-12`)：

```hlsl
#define APV_L1_ENCODING_SCALE 2.0          // 实际应是 3/(2·√3)·2 ≈ 1.732，round 到 2 抗误差
#define APV_L2_ENCODING_SCALE 3.5777088   // = 4/√5 · 2

float3 DecodeSH(float l0, float3 l1)
{
    return (l1 - 0.5f) * (2.0f * APV_L1_ENCODING_SCALE * l0);
}
```

**含义**：L1 在 baking 阶段被归一化到 `[0, 1]` (`encoded = l1·rcp(l0) / (2·SCALE) + 0.5`)，运行时 `decode = (encoded - 0.5) · 2·SCALE·l0` 还原。**优势**：L1 三通道现在可以塞进 R8G8B8A8_unorm 而不是 float ⇒ **VRAM 节省 4×**。HG 反编译里看到 `[r15+40h]` ~ `[r15+68h]` 这 6 张 Texture3D 的格式从 dispatch 上下文推不出来，但据 HDRP `USE_APV_TEXTURE_HALF` 同源逻辑，HG 大概率也用 half 或 unorm 压缩 (移动端必然)。

### 5.7 PipelineUpdateV2 时序 (主要 dispatch)

```
PipelineUpdateV2(ScriptableRenderContext ctx, Camera cam, Transform playerCenter,
                 ComputeShader ivBakeV2CS, ComputeShader ivClipmapUpdateCS)
  ① 若 m_defaultIV == null:
       构造 V2 IV config (§5.2) → HGIrradianceVolumeV2.Create(config) → m_defaultIV
  ② 否则若路径变化:
       SetMap(rootPath, 0)  ←  HGIrradianceVolumeV2::SetMap (写入新 index.bytes)
  ③ 拿 cam.transform.position 与 cam.transform.forward
  ④ HGIrradianceVolumeV2.SetStreamingCenter(centerPos)
     HGIrradianceVolumeV2.SetCameraForwardDirection(forward)
  ⑤ CommandBufferPool.Get("HGIrradianceVolumeV2")
  ⑥ ProfilingSampler.Get<HGProfileId>(0xC2) Begin
  ⑦ HGIrradianceVolumeV2.PipelineUpdate(
        cmdBuf, m_defaultIV, ivBakeV2CS, ivClipmapUpdateCS,
        cameraInstId, playerInstId, frameSettings)
      └── native 内部：
           - 选 LOD 圈 (16/64/256m world unit 据当前 cam dist)
           - toroidal update：若中心移过整 voxel，把环移出区域标 dirty
           - dispatch ivClipmapUpdateCS (NumThreads 据 §5.2 atlas dim)
           - dispatch ivBakeV2CS 烘焙 dirty bricks 的 SH
           - 写 result.Texture3D[0..5]
  ⑧ ProfilingSampler End → ctx.ExecuteCommandBuffer → CommandBufferPool.Release
```

### 5.8 Debug 接口

`ToggleDebugUpdateClipmap(bool)` (`:1622-1657`) + `ToggleDebugUpdateClipmapLod0(bool)` (`:1659-1694`) — 编辑器用，分别冻结 clipmap 整体更新或只冻结 LOD0 (固定相机位置便于 capture)。`m_debugClipmap/m_debugClipmapLod0/m_debugPos/m_debugFrameCount` (`:29-35`) 是相关状态。

### 5.9 Cabin (V2 等价)

`StreamingInCabinV3 / StreamingOutCabinV3` (`:1468-1538`) 取代 V1 的 V2-side cabin streaming，参数与 V1 同 (`slotId, roomTypeId`)。

---

## 6. 反射探针 Binning Pass — Octahedral Atlas + Tile/Cluster

> 主算法 binning 已在 [`../02-CoreAlgorithms/01-CoreAlgorithms.md`](../02-CoreAlgorithms/01-CoreAlgorithms.md) §3.4 讲过 (与光源共用 BinningPass)。本节补 **ReflectionProbeBinningPassConstructor 这一侧的 CB 头布局 + Octahedral atlas 更新**。

### 6.1 关键常量 (源：`ReflectionProbeBinningPassConstructor.cs:148-170`)

```csharp
public const int MAX_VISIBLE_COUNT      = 32;     // 同帧最多 32 个 reflection probe
public const int OCT_TEXTURE_PADDING    = 32;     // octahedral atlas 每个 face 周边 padding 32 px
public const float SLICE_Z_LENGTH       = 1.0f;   // 反射探针 z‑bin 切片厚度 = 1m
public const int XYPLANE_BINNING_GROUP_SIZE = 8;  // XY plane CS dispatch 8×8
public const int ZPLANE_BINING_GROUP_SIZE  = 64;  // Z plane CS dispatch 64
public const int NUM_FLOAT4_REFLECTION_PROBE_PARAMS         = 4;
public const int NUM_FLOAT4_REFLECTION_PROBE_BINNING_DATA   = 4;
public const int NUM_FLOAT4_REFLECTION_PROBE_BINNING_BUFFER = 132;   // 4 (header) + 4×32 (per-probe data)
public const int NUM_BYTES_REFLECTION_PROBE_BINNING_BUFFER  = 2112;  // = 132 × 16 byte
public const int NUM_FLOAT4_REFLECTION_PROBE_GLOBAL_DATA    = 8;
public const int NUM_FLOAT4_REFLECTION_PROBE_GLOBAL_BUFFER  = 260;   // = 4 (header) + 8 × 32
public const int NUM_BYTES_REFLECTION_PROBE_GLOBAL_BUFFER   = 4160;  // = 260 × 16
public static int QUALITY_VISIBLE_COUNT;                              // runtime quality 决定的实际上限
```

**两套 buffer**：

- **BinningBuffer** (`2112 B`)：tile/cluster 输出，每 tile 一个 bit 位图标识哪些 probe 影响 (head 4 float4 + 4 float4 × 32 probe)
- **GlobalBuffer** (`4160 B`)：每帧探针参数 (位置/范围/octahedral atlas slice 索引等)，head 4 float4 + 8 float4 × 32 = 32 probe × `NUM_FLOAT4_REFLECTION_PROBE_PARAMS=4` 个 float4 params

### 6.2 PassData

```csharp
private class PassData {
    public int xyBinningThreadGroupX/Y/Z;       // XY plane dispatch dims
    public int zBinningThreadGroupX/Y/Z;        // Z plane dispatch dims
    public CBHandle reflectionProbeBinningInputDatasCB;
    public CBHandle reflectionProbeGlobalDatasCB;
    public ComputeBufferHandle binningBuffer;
    public ComputeShader computeShader;
    public int octTextureSize;                   // 单 probe octahedral 面尺寸 (含 padding)
    public bool clearDefault;
    public bool renderBlend;
    public List<OctNode> currrentOctNode;       // 当前帧需要更新的 probe (≤32)
    public int blitCount;
    public int[] blitIndices;                    // size = 32 (前 N 个有效)
    public Texture[] blitTextures;               // size = 32 (要 blit 进 atlas 的 cubemap)
    public TextureHandle octTextureArray;        // 输出 atlas
}
```

### 6.3 Octahedral Atlas 缓存差异 (源：`:18-79` `OctNode.diff`)

每个 probe slot 记录 `(Cubemap texture, float factor)`，**diff 判断**：

```hlsl
// OctNode.diff(other):
//   1. 若 GetInstanceID(this.texture) != GetInstanceID(other.texture) → diff
//   2. 若 |this.factor - other.factor| ≥ epsilon (g_18C471328 = ~1e-3) → diff
//   3. 否则 same，不需要 reblit
```

**含义**：octahedral atlas 是 **frame‑coherent 缓存**——除非 cubemap 引用变 (texture instance ID 不同) 或 blend factor 显著变化 (差 ≥ 1e-3)，否则上一帧的 atlas 内容可以复用。每帧只对 diff 的 probe 调用 `Blit(cubemap, atlas, slice)` 把 cubemap reproject 到八面体 + padding，省去 32 × 6 face copy 的 GPU 开销。

### 6.4 探针环境烘焙 (PrepareGlobalReflectionProbe 调用图)

`PrepareGlobalReflectionProbe(passData, hgCamera)` (`:285-...`) 从 `HGEnvironmentManager` 拉两个 list:

```csharp
var volumes = HGEnvironmentManager.GetInterpolatedVolumes(cam);          // IndexedHashSet<HGEnvironmentVolume>
var factors = HGEnvironmentManager.GetInterpolatedVolumesFactor(cam);    // List<float>
// 遍历 volumes:
for (int i = 0; i < volumes.Count; i++) {
    var vol  = volumes[i];
    if (!vol) continue;
    var skyCfg  = vol.GetConfig(EnvConfigType.Sky);                       // (HGSkyConfig)
    if (!skyCfg) continue;
    var probe = skyCfg.reflectionProbe;
    if (!probe) continue;
    // 把 (probe, factors[i]) 加进 currrentOctNode list
    currrentOctNode.Add(new OctNode { texutre = probe, factor = factors[i] });
}
```

环境系统 (`C06_EnvironmentSky`) 已经按相机插值好了多个 EnvironmentVolume 的 weight，反射探针 binning 就**继承**这个 weight 来 blend 多个 sky cubemap。

### 6.5 Binning CB Header 上传 (源：`:800-1000` 反编译)

CB Header (4 float4 = 64 byte，位于 `reflectionProbeBinningInputDatasCB` 起始) 据反编译重建：

```
header.float4_0 = (renderWidth, renderHeight, 1/renderWidth, 1/renderHeight)
header.float4_1 = (sliceCountX, sliceCountY, sliceCountZ, 1/sliceCountY)
header.float4_2 = (nearClip, nearClip, nearClip,  4.0 / sliceCountZ)
   // 4.0 = SLICE_Z_LENGTH 累乘后的范围倒数
header.float4_3 = (tan(fov·0.5)·aspect·near·2 (frustumWidthAtNear),
                   tan(fov·0.5)·near·2          (frustumHeightAtNear),
                   tan²(fov·0.5)·near·2·π        (octahedral atlas scale 因子),
                   √(...))    // 该项需 hlsl 才能完全确认 — 据反编译 call sub_18036B640 是 Sqrt
```

具体行：
- `cdq + idiv ecx (= 56)` → 算 `(width + 7) / 56` 与 `(height + 7) / 56` 写到 PassData `xyBinningThreadGroupX/Y` (因为 `ZPLANE_BINING_GROUP_SIZE=64` 减 `8 padding = 56`)
- `mov [r15+1Ch]` 写 `(depth+0x3F) / 64` = z thread group
- `AllocateConstantBuffer(cmdBuf, 0x840 = 2112 B)` ⇒ `binningBuffer`
- `AllocateConstantBuffer(cmdBuf, 0x1040 = 4160 B)` ⇒ `globalBuffer`

完美对应 §6.1 常量 `NUM_BYTES_REFLECTION_PROBE_BINNING_BUFFER = 2112` / `NUM_BYTES_REFLECTION_PROBE_GLOBAL_BUFFER = 4160`。

### 6.6 单元矩阵 (`unitExtents`, `:171`)

```csharp
public Matrix4x4 unitExtents;     // 标识矩阵在构造里被填入 g_18C471520/B90/510/4F0/14F0
```

从构造反编译 (`:209-228`)：4 个 xmm0 加载到 4 个矩阵列，是个 **per‑probe OBB 范围矩阵** (`new Matrix4x4(col0, col1, col2, col3)`)，用于 probe 的轴对齐 box culling (每 probe 一个 box，cluster binning shader 用这个 testbox vs frustum)。

### 6.7 Dispatch 顺序总览

```
1. XY plane binning CS:
     numThreadGroups = (ceil(width/56), ceil(height/56), 1)
     每 tile 8×8 像素 → 写入 binningBuffer 该 tile 的 32-bit probe 位图
2. Z plane binning CS:
     numThreadGroups = (1, 1, ceil(depth/64))
     按 z slice 把每 cluster 涉及的 probe 累计到 binningBuffer 末段
3. (可选) Octahedral Atlas Blit:
     对 diff 出的 probe slot 调 Graphics.Blit (cubemap → octahedral atlas slice)
4. 最终 IBL 评估 shader 在延迟光照 pass 用 binningBuffer + globalBuffer + octTextureArray 计算反射
```

---

## 7. HyperSSR — 屏幕空间反射 C# 接线

> 真值源：`HyperScreenSpaceReflectionRenderingPass.cs` (940+ 行)。算法本体是 HDRP `ScreenSpaceReflection.cs` 系列的 fork — Hi-Z + temporal filter + bilateral upsample。本节只讲 HG 的 PassInput/PassData 与 RT 生命周期，shader 端公式属 HDRP 同源故引用 HDRP 真值即可。

### 7.1 PassInput (RenderGraph 上游输入，`:11-44`)

```csharp
internal struct PassInput {
    internal bool             needCopyGBufferAndDepth;
    internal int              ssrRayMarchingSampleCount;      // ray march 步数 (例 16/24/32)
    internal uint             forwardReflectionECSList;       // ECS 中需要走 forward reflection 的 entity list
    internal TextureHandle    previousSceneColorTexture;      // 上一帧 (用于 SSR look‑up)
    internal TextureHandle    previousSceneDepthPyramidTexture;
    internal TextureHandle    currentSceneColorTexture;
    internal TextureHandle    currentSceneDepthTexture;
    internal TextureHandle    currentSceneDepthTextureCopy;   // depth 副本 (避免 RAW hazard)
    internal TextureHandle    currentSceneDepthPyramidTexture; // Hi-Z (mip 0..N)
    internal TextureHandle    gbufferNormalRoughenssTexture;  // GBuffer normal+roughness
    internal TextureHandle    normalRoughnessTexture;         // 当前帧 packed normal+roughness
    internal TextureHandle    normalRoughnessTextureCopy;
    internal TextureHandle    motionVectorTexture;            // 用于 temporal reproject
    internal TextureHandle    waterWetnessMaskTexture;        // 水/湿表面单独标记 (走 SSR wetness 路径)
    internal ScriptableRenderContext renderContext;
    internal HGSettingParameters     settingParameters;
}
```

### 7.2 ScreenSpaceReflectionData CB (`:51-72`)

```csharp
public struct ScreenSpaceReflectionData {
    public Vector4 param0;        // (ssrRayMarchSampleCount, roughnessThreshold, mipThreshold, fadenessOnScreen)
    public Vector4 param1;        // (fadenessOnDepth, fadenessOnDepthFactor, fadenessOnMirrorMul, fadenessOnMirrorAdd)
    public Vector4 param2;
    public Vector4 param3;
    public Vector4 param4;
    public Vector4 param5;
    public Vector4 param6;
    public Vector4 param7;
    public Vector4 previousColorPyramidRenderSize;
    public Vector4 currentColorPyramidRenderSize;
}
```

10 个 Vector4 = 160 byte CB — 装 SSR 所有 fadeness / 步数 / temporal 反投影常量 (来源映射 `ScreenSpaceReflectionVolume.cs`)。

### 7.3 PassData — Temporal 双 RT (`:74-143`)

```csharp
private class PassData {
    // ... 基本参数 (firstFrame, upsample, importanceSample, maxMipCount, renderSize 等)
    public TextureHandle previousFadenessTexture;   // SSR temporal A
    public TextureHandle currentFadenessTexture;    //     temporal B
    public TextureHandle previousTemporalColorTexture;
    public TextureHandle currentTemporalColorTexture;
    public TextureHandle previousSceneColorTexture; public TextureHandle previousSceneDepthPyramidTexture;
    public TextureHandle currentSceneColorTexture;  public TextureHandle currentSceneDepthTexture;
    public TextureHandle currentSceneDepthPyramidTexture; public TextureHandle gbufferNormalRoughenssTexture;
    public TextureHandle normalRoughnessTexture;
    public TextureHandle motionVectorTexture; public TextureHandle waterWetnessMaskTexture;
    public TextureHandle rayMarchingColorTexture;       // ray march 中间结果
    public TextureHandle rayMarchingHitUVTexture;       //     hit UV
    public TextureHandle filterWeightTexture;
    public TextureHandle fadenessTexture;
    public TextureHandle fadenessBlurTexture0, fadenessBlurTexture1;  // bilateral blur 双 buffer
    public TextureHandle currentColorPyramidTexture;     // 当前帧 color pyramid (用于 cone-traced glossy)
    public TextureHandle currentColorResolveTexture;
    public TextureHandle currentColorUpsampleTexture;    // 双线性 upsample
    public TextureHandle sampleSceneColorTexture;
    public ComputeShader computeShader;
    public bool ssrRenderWetness;
}
```

**RT 拓扑** = 与 HDRP SSR fork 完全同 (Hi‑Z ray march → hit UV/Z → color pyramid lookup → temporal blend → bilateral upsample)。HG delta = **水湿表面单独 path** (`ssrRenderWetness`)。

### 7.4 Transparent 阶段 (`:145-156`)

`TransparentPassData` 是 HG 额外加的 **透明物体 SSR**:

```csharp
private class TransparentPassData {
    public bool needCopyGBufferAndDepth;
    public uint forwardReflectionECSList;
    public TextureHandle normalRoughnessTexture;
    public TextureHandle currentSceneDepthTexture;
    public MaterialPropertyBlock transparentMBP;
}
```

透明 SSR 不走 GBuffer，把 `normalRoughness` + `depth` 直接喂给 forward shader 走 per‑pixel ray march (典型用例：水面镜反射、玻璃)。

### 7.5 状态机字段 (`:158-198`)

```csharp
private bool   m_shouldRender;
private bool   m_shouldDeferredRender;
private bool   m_firstFrame;
private bool   m_deferredFirstFrame;
private int    m_frameIndex;
private Vector2Int m_previousRenderSize;
private TextureHandle m_previousFadenessTexture;    // 跨帧 ping-pong
private TextureHandle m_currentFadenessTexture;
private TextureHandle m_previousTemporalColorTexture;
private TextureHandle m_currentTemporalColorTexture;
private TextureHandle m_previousDeferredTemporalColorTexture;
private TextureHandle m_currentDeferredTemporalColorTexture;
private TextureHandle m_ssrLightingTexture;          // 输出给延迟光照
private TextureHandle m_ssrFadenessTexture;
private RTHandle m_defaultTexutre;
private ComputeShader m_computeShader;
private Material m_pixelShader;
private long m_impl;                                  // native 实现指针
```

`m_impl` = native HyperSSR 算法对象引用，所有重活在 C++ 端。

---

## 8. FakePlanarReflection — 镜像相机几何

> 真值源：`FakePlanarReflectionPass.cs`，2925 行。算法是经典 **planar reflection by mirror camera** — 把主相机沿反射平面镜像，渲染一遍场景到 RT，shader 端按反射方向 fetch。

### 8.1 镜像相机几何 (`:288-...` 反编译展开)

**反射平面定义**：`hgCamera.fakeReflectionPlanePos` + `fakeReflectionProbeNormal` (normalized) 定义平面 `{x : n·(x - pos) = 0}`。

**反射点 R 公式 (Householder reflection)**：对世界点 `P` 关于平面镜像，

```
R(P) = P - 2 · ((P - planePos) · n) · n
```

反编译里看到的 `xmm10/xmm11/xmm12` 三组 `mulss + addss` 实现 `P - 2·(d·n)`：

```hlsl
// 行 :440-468 反编译重建
float3 N = normalize(fakeReflectionProbeNormal.xyz);
float3 P_plane = fakeReflectionPlanePos.xyz;
float3 P_camera = hgCamera.transform.position;
float3 N_x = float3(N.x*N.x, N.x*N.y, N.x*N.z);
float3 N_y = float3(N.x*N.y, N.y*N.y, N.y*N.z);
float3 N_z = float3(N.x*N.z, N.y*N.z, N.z*N.z);
// Reflection 矩阵 R = I - 2·N·Nᵀ
float3x3 R = float3x3(
    float3(1,0,0) - 2 * N_x,
    float3(0,1,0) - 2 * N_y,
    float3(0,0,1) - 2 * N_z
);
// 把相机 forward 与 up 镜像，再生成虚像相机的 LookRotation
float3 mirroredForward = mul(R, cam.transform.forward);
float3 mirroredUp      = mul(R, cam.transform.up);
Quaternion mirrorRot   = Quaternion.LookRotation(mirroredForward, mirroredUp);
float3 mirrorPos       = P_camera - 2 * dot(P_camera - P_plane, N) * N;
// 设虚像相机 (用同 GameObject 临时改 pos/rot 渲染一次再还原)
cam.transform.position = mirrorPos;
cam.transform.rotation = mirrorRot;
```

后段 `:649-687` 还会把 `cameraToWorldMatrix` 转置后乘 `(P_plane, n_normalize.w)` 行向量做 **斜投影 (oblique near plane clipping)**，确保虚像相机的近平面与反射平面对齐 (经典平面反射的关键技巧，防止反射平面后方物体进入 RT)。

### 8.2 RT 与 RenderGraph 接线 (`:289-1283+` 反编译)

```
PassInput {
    bool          characterOutlineEnable;
    uint          screenCullingLayerMask;
    float         screenCullingRatio, screenCullingRatioDistance;
    PerObjectData bakedLightingConfig;
    CullingResults cullingResults;
    ShadowResult  shadowResult;
    HGRenderPipeline hgrp;
    ScriptableRenderContext renderContext;
    uint          characterPrePassECSList, forwardOpaquePreZECSList, forwardOpaqueECSList,
                  forwardOpaqueEqualECSList, characterOpaqueECSList,
                  characterOutlineOpaqueECSList, characterOutlineOpaqueEqualECSList;
    TextureHandle sceneColorTexture, sceneDepthTexture;
}
```

**Pass 拓扑** (RenderGraph 接线):

```
Pass A "Fake Planar Reflection" (depth prepass):
    color = null (depth only)
    depth = Fake Planar Reflection Depth texture (TextureDesc 仿 HGCamera)
    renderList = 主 opaque list + character outline list
Pass B "Fake Planar Reflection" (main pass):
    color = Fake Planar Reflection Color texture
    depth = (Pass A 输出)
    renderList = forwardOpaquePreZ + forwardOpaque + characterOutline
Pass C (可选) Blur:
    输入 Color texture → "Fake Planar Reflection Color Blur texture"
    blurMaterial = m_blurMaterial (from HGRenderPipelineMaterialCollector)
    blurPass = 0/1 多个 LOD (cone trace based blur)
    BlurData = (blurSize.xyzw, param0.xyzw) 两 Vector4 上传到 mpb
```

`BlurData.blurSize` 一般是 `(1/width, 1/height, 1/halfWidth, 1/halfHeight)`，`param0` 是模糊半径/迭代次数。

### 8.3 与 SSPR / Reflection Probe 的 fallback 链

```
runtime per‑pixel:
    if (FakePlanarReflectionEnable && rayDir 落在 plane 镜像区域)
        sample FakePlanarReflectionColor (or Blur 版本)
    else if (SSPREnable)
        sample SSPR atlas (planar 屏幕投影)
    else if (HyperSSREnable && rayDir 命中屏内)
        sample HyperSSR result
    else
        sample ReflectionProbe (Oct atlas) IBL  (回落)
```

具体 fallback 顺序在 shader 端 (HG `HGRP_Lit.shader` 间接通道，超出本文档范围)。

---

## 9. SSPR / RayTracing Reflection Volume 接口

### 9.1 ScreenSpacePlanarReflectionVolume (`:1-66`)

```csharp
[Serializable]
[VolumeComponentMenuForRenderPipeline("Post-processing/ScreenSpacePlanarReflection", new[]{ typeof(HGRenderPipeline) })]
public class ScreenSpacePlanarReflectionVolume : VolumeComponent
{
    public BoolParameter           enable;
    public FloatParameter          planeHeight;                  // 水/镜面平面世界高度
    public ClampedFloatParameter   fadeness;
    public ColorParameter          tintColor;
    public BoolParameter           noiseEnable;
    public Texture2DParameter      noiseTexture;
    public MinFloatParameter       noiseIntensity;
    public ClampedFloatParameter   rtScale;                       // SSPR RT 缩放 [0.25, 1]
    public bool IsActive();                                       // = (planeHeight != null)
}
```

**SSPR (Screen-Space Planar Reflection)** 算法：给水面/反射平面，每像素算 `world_pos - 2·(plane.height - world_pos.y)·up`，反向投影回屏空间得反射 UV，从 sceneColor 取色 (类似 Killzone 实现)。比 FakePlanarReflection 廉价 (无第二相机) 但精度低 (只反射屏内可见物)。HG 还加了 `noiseTexture` 做扰动 (水面波纹)、`tintColor` 调色。

### 9.2 ScreenSpacePlanarReflectionObject (`:1-38`) — MonoBehaviour 模式

```csharp
public class ScreenSpacePlanarReflectionObject : MonoBehaviour
{
    public bool enable;
    [Range(0f, 0.5f)]    public float planeOffset;
    [Range(0f, 0.25f)]   public float fadenessLeft;
    [Range(0.3f, 0.6f)]  public float fadenessRight;
    [Range(0f, 0.1f)]    public float fadenessThreshold;
    [Range(0f, 0.5f)]    public float fadenessUV;
    public Color tintColor;
    public bool noiseEnable;
    public Texture2D noiseTexture;
    [Min(0f)] public float noiseIntensity;
    [Range(0.25f, 1f)] public float rtScale;
    public ReflectionProbe reflectionProbe;       // fallback 探针
}
```

与 Volume 模式互斥使用，常挂在水面/镜面物体上，方便逐物体调参。`reflectionProbe` 字段给 SSPR 区域外的 fallback。

### 9.3 RayTracingReflectionVolume (`:1-14`)

```csharp
[Serializable]
[VolumeComponentMenuForRenderPipeline("RayTracing/RayTracingReflection", new[]{ typeof(HGRenderPipeline) })]
public class RayTracingReflectionVolume : VolumeComponent
{
    public FloatParameter                 enable;
    public RayTracingReflectionModeParameter mode;     // Hybrid / OnlyRayTracing
}

public enum RayTracingReflectionMode { Hybrid = 0, OnlyRayTracing = 1 }
```

**Hybrid** = SSR 优先、屏外用 RT；**OnlyRayTracing** = 纯 RT (主机/PC 高端)。HG 反编译里这个仅作 volume 配置容器，实际 RT 派发在 native — 移动端基本不会启用。

### 9.4 ScreenSpaceReflectionVolume (`:1-149`)

```csharp
public class ScreenSpaceReflectionVolume : VolumeComponent
{
    public BoolParameter         enable;
    public ClampedFloatParameter fadenessOnScreen;        // 屏边缘衰减
    public FloatParameter        fadenessOnDepth;         // 深度衰减
    public ClampedFloatParameter fadenessOnDepthFactor;
    public FloatParameter        fadenessOnMirrorMul;     // 镜面强度系数
    public FloatParameter        fadenessOnMirrorAdd;
    public ClampedFloatParameter mipThreshold;            // glossy → 用哪 mip
    public bool IsActive();
}
```

直接喂给 §7.2 HyperSSR `ScreenSpaceReflectionData.param0/1`。

---

## 10. CSG / BSP — Baking 辅助

> 真值源：`CSG/BSP.cs` 1500+ 行 (主体反汇编)。是 **constructive solid geometry** BSP tree，用于 baking 期的 mesh 切割与求交。**不在 runtime pipeline 路径上**；可能被 IV baking 工具或编辑器辅助 mesh 切片使用。

### 10.1 类型

```csharp
namespace HG.Rendering.Runtime.CSG
{
    public class BSP : ICsgProvider
    {
        public bool          _createDescription;
        public object[]      description;
        public static object locker;
        public static List<CSGPolygon> polygons;
        public static Matrix4x4 matrix, matrix2;
        public static Vector3[] vertices;
        public static Vector3[] normals;
        public static Vector2[] uv;
        public Node root;

        public IEnumerable<object>     Description;       // null in stub
        public Bounds?                 Bounds { get; private set; }
        public IEnumerable<CSGPolygon> Polygons;          // null in stub
        public event Action            OnChange;

        public BSP(bool createDescription);
        protected BSP(IEnumerable<CSGPolygon> polygons, Bounds bounds, object[] description, bool createDescription);
        private BSP(Node root, Bounds? bounds, object[] description, bool createDescription);
    }
}
```

构造立刻 `new Node()` + `Node.Build(polygons, 0)` 把多边形列表构建成 BSP 树。`Bounds` 缓存包围盒。`OnChange` 事件用于 baking 工具在 mesh 变动时刷新。

### 10.2 用途推断

- **场景遮挡测试** (IV baking 用 BSP raycast 判断每个 probe 是否在墙内，墙内 probe 标 invalid)
- **SH baking 时的 mesh 切片** (把每个 brick 与场景几何求交，找到该 brick 实际包含的 surface)

具体烘焙流程在 `HG.IrradianceVolumeBaker` (`HGGraphicsCPPModule`)，本文不展开。

---

## 11. 数据流与时序总图

```
                                  ──────────── BAKE TIME ────────────
   场景 mesh + lights + sky cubemap
                │
                ▼
   ┌─────────────────────────────────────────────────────────────────┐
   │  IV V1 / V2 烘焙器 (HGGraphicsCPPModule + CSG/BSP)              │
   │  ① 在 sparse VT brick 网格 (V1) 或 clipmap 144³ atlas (V2) 上   │
   │     按 brick 中心采样烘焙 (路径追踪 + GPU ray bundle)            │
   │  ② 把 baked irradiance 投影到 SH L2: 27 float (3 ch × 9 系数)   │
   │  ③ UndoCosineRescaling (sh *= 1/c_i × ±) 反卷积出 radiance      │
   │  ④ Convolve(sh, ZH_cos) 卷回 irradiance (用上需要的相函数)      │
   │  ⑤ PremultiplyCoefficients (sh *= k_i × ±) 预乘基函数归一化     │
   │  ⑥ PackCoefficients → Vector4[7] (Sloan 编码)                  │
   │  ⑦ 编码到 6 张 Texture3D RGBA (APV L1 0.5 + scale)              │
   │  ⑧ 序列化到 .bytes 文件 (V1 = atlas + index; V2 = 6 个 stream)   │
   └─────────────────────────────────────────────────────────────────┘
                │
                ▼  .bytes 落盘
   ┌─────────────────────────────────────────────────────────────────┐
   │  反射探针离线烘焙：HDRP standard cubemap pre-conv              │
   │  生成 mip‑chain cubemap，每 mip 对应一个 roughness              │
   └─────────────────────────────────────────────────────────────────┘
                │
   ═══════════════════════════════════════════════════════════════════
                                  ──────────── RUNTIME ────────────
                │
   ┌─────────────────────────────────────────────────────────────────┐
   │  HGRenderPipeline.Render(cam):                                  │
   │  ┌──── 早期阶段 ────┐                                          │
   │  │ HGIrradianceVolumeManager(V1) / V2 .PipelineUpdateV2(...)    │
   │  │   → 6 张 Texture3D 写入 _APVResL* 全局 binding               │
   │  │ HGEnvironmentManager.GetInterpolatedVolumes (for §6)         │
   │  │ ReflectionProbeBinningPassConstructor.ConstructPass          │
   │  │   → binningBuffer (2112B) + globalBuffer (4160B) + Oct atlas │
   │  │ FakePlanarReflectionPass.ConstructPass (若 enable)            │
   │  │   → 虚像相机 RenderPass A+B+C 产出 reflection RT             │
   │  └─────────────────┘                                          │
   │                                                                 │
   │  ┌──── GBuffer pass (含 normal/roughness) ────┐                │
   │  │  → Pass HyperSSR 需要的 inputs               │                │
   │  └─────────────────────────────────────────────┘                │
   │                                                                 │
   │  ┌──── HyperSSR Pass (Hi‑Z + temporal) ────┐                   │
   │  │  → m_ssrLightingTexture / m_ssrFadenessTexture                │
   │  └─────────────────────────────────────────┘                   │
   │                                                                 │
   │  ┌──── Deferred Lighting (IBL + Diffuse + 应用所有间接光) ──┐  │
   │  │  Sample APV(uvw):                                          │
   │  │    L0_L1Rx + L1G_L1Ry + L1B_L1Rz → L0/L1 R/G/B               │
   │  │    L2_0/1/2/3 → L2 R/G/B/C                                  │
   │  │  Decode (APV_L1_ENCODING_SCALE=2.0 / L2=3.5777)             │
   │  │  EvaluateAPVL1L2(N): SHEvalLinearL0L1 + SHEvalLinearL2      │
   │  │  → bakeDiffuseLighting                                      │
   │  │                                                              │
   │  │  Sample ReflectionProbeBin(tile, cluster) → 32 个 probe 的位 │
   │  │  按位拿 probe → 从 octAtlas 取 cubemap → roughness mip 评估 │
   │  │  → indirectSpecular                                         │
   │  │                                                              │
   │  │  SSR/SSPR/FakePlanar Reflection 合成 (fallback 链 §8.3)     │
   │  │  → finalSpecular                                            │
   │  │                                                              │
   │  │  L_indirect = bakeDiffuseLighting * albedo / π              │
   │  │             + finalSpecular * F0_F90                        │
   │  └────────────────────────────────────────────────────────────┘  │
   └─────────────────────────────────────────────────────────────────┘
```

---

## 12. 1:1 复刻蓝图

### 12.1 SH 数学层 (最简单 — 文件级照搬)

1. **新建 `HG.Rendering.Runtime.SphericalHarmonicMath`**：把 HDRP `Runtime/Lighting/SphericalHarmonics.cs` 完全照搬 (字段 `c0..c4 / k0..k4 / invNormConsts / ks` 数值精确到 17 位)。
2. 5 个 public static 方法：`Convolve / UndoCosineRescaling / PremultiplyCoefficients / RescaleCoefficients / PackCoefficients` — 实现严格按 §2.3 / §2.4 三层循环结构。
3. **新建 `HG.Rendering.Runtime.ZonalHarmonicsL2`**：`float[3] coeffs` + `GetHenyeyGreensteinPhaseFunction / GetCornetteShanksPhaseFunction` 两个 static (§3.2 / §3.3)。
4. **新建 `SHCoefficientsL1 / SHCoefficientsL2` struct**：完全照搬 (`Vector4 shAr/shAg/shAb` + L2 7 个 Vector4)。
5. **HLSL 端**：照搬 HDRP `ShaderLibrary/SphericalHarmonics.hlsl` 5 个 const + 3 个 SHEval 函数 + 2 个 SampleSH9 重载 + `ConvolveZonal` + `PackSH`。

### 12.2 辐照度体 V2 (中等复杂 — 算法同源 + clipmap 调度)

1. **存储**：6 张 `RenderTexture` 3D，dimensions `144 × 144 × 288` (`R8G8B8A8_UNorm` 或 half)。命名按 HDRP APV：`L0_L1Rx, L1G_L1Ry, L1B_L1Rz, L2_0, L2_1, L2_2` (第 7 张 `L2_3` 可省，shader 用 black fallback)。
2. **Clipmap toroidal**：每帧 `streamingCenter` 据相机位置量化到 voxel 整数倍 (`PoolDim = 0x90 = 144`，单 voxel 世界单位 `clipmapWorldSize / 144`)，若中心移动 ≥ 1 voxel 标 dirty region。dirty region = 上一帧覆盖区与本帧覆盖区的对称差。
3. **3 LOD 圈**：clipmap LOD0/1/2 半径 `16 / 64 / 256` 米 (`config[0x21C..0x224]`)，每 LOD 用同一 6 张 Texture3D 的不同 slice 区段。LOD 切换距离 (V1) `85m` 在 V2 改成连续 ring 半径。
4. **烘焙 ComputeShader (`ivBakeV2CS`)**：每 dirty brick 派一个 thread group (8×8×8)，每 thread 一个 probe。probe 内：投影 27 系数 = ∫_S² L_in(ω) · Y_{ℓm}(ω) dω (用方向 stratified samples)。
5. **更新 ComputeShader (`ivClipmapUpdateCS`)**：把 baked SH 系数按 APV 编码 (`encoded = l1·rcp(l0) / (2·2.0) + 0.5`，再写入 R8/R16) 写到 6 张 Texture3D 对应 voxel。
6. **全局 binding**：`_APVResL0_L1Rx` 等 7 个 HLSL global texture + 一个常量 buffer 装 `_PoolDim_MinBrickSize`、`_MinEntryPos_Noise`、`_APVNormalBias/_APVViewBias` 等 (照搬 HDRP `ShaderVariablesProbeVolumes.cs`)。
7. **GPU 采样函数**：按 HDRP `SampleAPV` 6 次 `SAMPLE_TEXTURE3D_LOD`，然后 `Decode → EvaluateAPVL1L2(N) → 加 L0`。HG 用 clipmap UV (`uvw = (worldPos - clipmapMin) * rcpClipmapSize`) 直接取代 APV brick‑indirection 路径，跳过 `TryToGetPoolUVWAndSubdiv` 整段。

### 12.3 辐照度体 V1 (复杂 — 自研 sparse VT，需要全套基础设施)

1. **physical pool**：1 张 `R8G8B8A8` `Texture3D` `128×128×128`，按 `5m / brick × 27 voxel / brick` 装满。
2. **indirection texture**：1 张 `R32_UInt` `Texture3D` `96 × 48 × 96`，每 voxel 装 `(brickX, brickY, brickZ, subdivLevel)` 打包 `uint32`。
3. **streaming logic**：随相机移动，按 `20m / 85m` 距离决定哪些 brick load/unload，写 indirection。具体 `HGIrradianceVolume.SetMap` 内部走的是 native binary IO + GPU async copy，可参考 `HGRenderPipelineSettingHub.MapHandler.id == 4` 切默认/gacha 数据 (反编译 `:546-549`)。
4. **GPU 采样**：先采 indirection (point sample) 得 `(brickX, brickY, brickZ, subdiv)`，按 `subdiv` 缩放 worldPos 到 brick local，再去 physical pool 采 SH 4 张 + L2_3 fallback。
5. **scene state mask**：把多版本 SH 分 slot 装进同一 physical pool，shader 端按 `SetActiveSceneStateMask` 设的 mask bit 取对应版本 (动态 SH 数组)。

### 12.4 反射探针 Binning + Octahedral Atlas

1. **常量** (§6.1)：照抄 `MAX_VISIBLE_COUNT = 32, OCT_TEXTURE_PADDING = 32, SLICE_Z_LENGTH = 1f, XYPLANE_BINNING_GROUP_SIZE = 8, ZPLANE_BINING_GROUP_SIZE = 64`。
2. **CB 布局** (§6.5)：4 float4 header + 4 float4 × 32 probe = 132 float4 = 2112 B；global 4 + 8 × 32 = 260 float4 = 4160 B。
3. **OctNode diff cache** (§6.3)：每帧扫 32 个 slot，若 `(textureID, factor)` 变化 → blit cubemap → atlas slice。
4. **Binning CS**：两 kernel — XY plane (`numThreadGroups (W/56, H/56, 1)`, group `8×8`)、Z plane (`numThreadGroups (1, 1, D/64)`, group `64`)。每 tile/cluster 输出 32-bit 位图标记 probe 影响。
5. **Atlas 派发**：`octTextureArray = Texture2DArray (slice = 32, 单 face = octFaceSize+2×PADDING)`，每 probe 一个 slice。

### 12.5 HyperSSR / FakePlanarReflection / SSPR (可选)

5. HyperSSR 直接照搬 HDRP `ScreenSpaceReflection*` family (Hi-Z ray march + temporal filter + bilateral upsample)，加 HG 的水湿表面 special path (extra `waterWetnessMaskTexture` 输入 + `ssrRenderWetness` 标志)。
6. FakePlanarReflection 实现 §8.1 镜像相机 + 斜投影 + RenderPass A+B+C 三阶段 (depth prepass / opaque / blur)。
7. SSPR 实现 Killzone 风格 plane projection + noise jitter + edge fadeness。

### 12.6 与其他系统的依赖

| 依赖项 | 文档 |
|---|---|
| HGEnvironmentManager 提供 sky cubemap + interpolated volumes | `06-EnvironmentSky.md` (§6.4) |
| HGCamera 提供 fake reflection plane pos/normal | `15-Camera.md` |
| RenderGraph TextureHandle / ComputeBufferHandle / CBHandle | `03-RenderGraph/01-HGRenderGraph-System.md` |
| GBuffer normal+roughness 输出 | `01-PipelineCore/04-LightingAO.md` |
| HGGraphicsFeatureManager / HGIrradianceVolumeQuality 决定使能 | `06-RuntimeQuality/01-RuntimeQuality.md` |
| HGRenderPipelineSettingHub.MapHandler 切场景 (gacha 切换) | `01-PipelineCore/01-HGRenderPipeline-Infrastructure.md` |

---

## 13. 关键常量 / 魔数总表

### SH 数学

| 名 | 值 | 出处 | 用途 |
|----|----|------|------|
| `c0..c4` | 见 §2.2 表 | HDRP `SphericalHarmonics.cs:58-62` | `invNormConsts` 用 |
| `k0..k4` | 见 §2.1 表 | HDRP `:84-88` + `SphericalHarmonics.hlsl:9-13` | `ks[]` / shader |
| `kClampedCosine0..2` | `1, 2/3, 1/4` | HDRP `SphericalHarmonics.hlsl:19-21` | `Convolve(sh, ZH_cos)` |
| `APV_L1_ENCODING_SCALE` | `2.0` | HDRP `DecodeSH.hlsl:6` | L1 编码到 unorm |
| `APV_L2_ENCODING_SCALE` | `3.5777088` | HDRP `:7` | L2 编码 |

### 辐照度体 V1 (HG 自研，反编译重建)

| 名 | 值 | 出处 |
|----|----|------|
| physical pool dim | `128 × 128 × 128` (LowMemory `32 × 32 × 32`) | `CreateGachaIV` 字面量 |
| indirection grid dim | `96 × 48 × 96` | 同 |
| brick subdiv | `8` | `[rbp+43h]` |
| LOD0 tile bytes | `0x40000 = 262144 = 64³` | `[rbp-55h]` |
| LOD1 tile bytes | `0x20000 = 131072 = 64×64×32` | `[rbp-2Dh]` |
| brick world size | `5.0f` | `[rbp+37h]` |
| streaming near | `20.0f` | `[rbp+3Bh]` |
| LOD 切换距离 | `85.0f` | `[rbp+3Fh]` |
| Low memory 分支阈值 | `HGIrradianceVolumeQualitySettings.enableIvLowMemory` | static field |
| gacha 路径 | `"IrradianceVolume/gacha/index.bytes"` | const |
| V2 / V3 suffix | `"/[dev]index.bytes"` / `"/v3/index.bytes"` | const |

### 辐照度体 V2 (HG 自研 clipmap)

| 名 | 值 | 出处 |
|----|----|------|
| atlas dim | `144 × 144 × 288` (`0x90 × 0x90 × 0x120`) | PipelineUpdateV2 `[rsp+198h..1A4h]` |
| 6 textures slots | `L0_L1Rx, L1G_L1Ry, L1B_L1Rz, L2_0, L2_1, L2_2` | `[rsp+130h]=6` + APV 映射 |
| voxels per cell | `27 (= 3³)` | `[rsp+134h]=0x1B` |
| brick subdiv | `8` | `[rsp+138h]` |
| mipCount | `1` (HG delta from APV multi-LOD) | `[rsp+168h]` |
| clipmap LOD ring 半径 | `16m, 64m, 256m` (`0x41800000/0x42800000/0x43800000`) | `[rsp+21Ch..224h]` |
| profile id | `0xC2` | `ProfilingSampler.Get<HGProfileId>(0xC2)` |

### 反射探针 Binning

| 名 | 值 | 出处 |
|----|----|------|
| `MAX_VISIBLE_COUNT` | `32` | `ReflectionProbeBinningPassConstructor.cs:148` |
| `OCT_TEXTURE_PADDING` | `32` | `:150` |
| `SLICE_Z_LENGTH` | `1.0f` | `:152` |
| `XYPLANE_BINNING_GROUP_SIZE` | `8` | `:154` |
| `ZPLANE_BINING_GROUP_SIZE` | `64` | `:156` |
| BinningBuffer 大小 | `2112 B (132 float4)` | `:162-164` |
| GlobalBuffer 大小 | `4160 B (260 float4)` | `:168-170` |
| 每 probe params float4 数 | `4` | `:158` |
| 每 probe global float4 数 | `8` | `:166` |
| OctNode diff epsilon | `~1e-3` | `[g_18C471328]` (`diff` 反编译) |
| Z bin 范围倒数 | `4.0 / depth` | CB header float4_2 |

### HyperSSR

| 名 | 值 | 出处 |
|----|----|------|
| SSR Data CB 大小 | `160 B (10 float4)` | `ScreenSpaceReflectionData :51-72` |
| SSR ray march sample count | runtime 设置 (典型 16/24/32) | `PassInput.ssrRayMarchingSampleCount` |
| Wetness path | `ssrRenderWetness` flag | `PassData :142` |

### FakePlanarReflection

| 名 | 出处 |
|----|------|
| Color texture name | `"Fake Planar Reflection Color texture"` |
| Depth texture name | `"Fake Planar Reflection Depth texture"` |
| Blur texture name | `"Fake Planar Reflection Color Blur texture"` |
| Pass labels | `"Fake Planar Reflection"` (depth prepass + main) |
| ProfilingSampler IDs | `0x88, 0x89, 0x8A` (`HGProfileId.Get` 3 次) |
| Blur CB | `BlurData = { Vector4 blurSize, Vector4 param0 }` |

---

## 14. 附录：源文件清单

| 文件 (`HG.RenderPipelines.Runtime` 下) | 一句话职责 |
|---|---|
| `SphericalHarmonicMath.cs` | HDRP 1:1 同源 — SH 卷积 / Pack / Premultiply / RescaleCoefficients |
| `SHCoefficientsL1.cs` | L1 系数容器 (3 × Vector4) |
| `SHCoefficientsL2.cs` | L2 系数容器 (7 × Vector4，Unity 内置 `_SHA/B/C` cb 同名) |
| `ZonalHarmonicsL2.cs` | HG / CS 相位函数的 ZH 闭式 (`float[3]`) |
| `HGIrradianceVolumeManager.cs` | IV V1 (sparse VT) C# 管理面，V2/V3 双 path + scene state mask + cabin streaming |
| `HGIrradianceVolumeManagerV2.cs` | IV V2 (clipmap) C# 管理面，6 Texture3D + 3 ring LOD + toroidal update |
| `HGIrradianceVolumeQualitySettings.cs` | `static bool enableIvLowMemory` — 触发 V1/V2 低内存常量分支 |
| `HGReflectionProbeTextureManager.cs` | 空壳 (native 端管理) |
| `HGPlanarReflectionManager.cs` | 空壳 + `Release()` 跳板 (native 端管理) |
| `FakePlanarReflectionPass.cs` | 虚像相机镜像 + RenderGraph 三 Pass + blur |
| `ScreenSpacePlanarReflectionObject.cs` | SSPR 物体模式 (MonoBehaviour) |
| `ScreenSpacePlanarReflectionVolume.cs` | SSPR Volume 模式 |
| `ScreenSpaceReflectionVolume.cs` | SSR Volume 参数 (`fadeness*`) |
| `HyperScreenSpaceReflectionRenderingPass.cs` | HyperSSR 主 Pass — Hi‑Z + temporal + bilateral，含透明阶段 |
| `RayTracingReflectionMode.cs` | enum `{ Hybrid, OnlyRayTracing }` |
| `RayTracingReflectionModeParameter.cs` | RT 模式的 `VolumeParameter<>` |
| `RayTracingReflectionVolume.cs` | RT 反射 Volume 参数 |
| `ReflectionProbeBinningPassConstructor.cs` | 反射探针 binning + octahedral atlas blit + OctNode diff cache |
| `ReflectionProbeBinningPassSetting.cs` | `MAX_VISIBLE_COUNT = 32`, runtime `QUALITY_VISIBLE_COUNT` |
| `MeshGICaculateTask.cs` | 空壳 (`Collider collider; HGFoliageType foliageType`) — baking 工具用 |
| `CSG/BSP.cs` | BSP tree (CSG provider)、baking 期 mesh 切割 / 求交辅助 |

---

> **行文纪律自查**：
> - 所有 SH 公式 (§2/§3) 直证 HDRP `SphericalHarmonics.cs:36-141` + `SphericalHarmonics.hlsl:9-209`，HG 反编译逐字面量验证一致。
> - V2 6 Texture3D + APV decode 公式 (§5) 直证 HDRP `ProbeVolume.hlsl:63-69 / 392-437 / 728-744` + `DecodeSH.hlsl:6-12`，HG 反编译 config 字面量逐位列出。
> - V1 sparse VT 模型 (§4) **HDRP 无对应**，全部据 HG 反编译 `mov` 字面量 + 调用图重建，归入 §1.5.4②"反汇编强推断"。
> - 反射探针 binning 主算法链接 `02-CoreAlgorithms.md`，本文只补 CB 头/atlas/OctNode diff，每条 cite 行号。
> - 已避免空壳代码堆叠；纯空壳文件 (`MeshGICaculateTask` / `HGReflectionProbeTextureManager`) 仅在 §14 一句话标注。
> - 不在 SH/APV 核心公式处留待确认；仅 V2 `L2_3` 通道是否复用 `L2_*.a` 一处标注为"据 HDRP 同源逻辑推断 / 需 hlsl 确认"。
