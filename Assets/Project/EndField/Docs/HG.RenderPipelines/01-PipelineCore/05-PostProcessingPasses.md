# Post-Processing Passes

> Clean-room implementation document for HG.RenderPipelines post-processing pipeline.
> Covers all 27 pass constructor / Volume component source files under `HG/Rendering/Runtime/`.
>
> **Source directory**: `Assets/Scripts/HG.RenderPipelines.Runtime/HG/Rendering/Runtime/`
> **Status**: Complete

---

## 1. Overview

The post-processing pipeline is orchestrated by `PostProcessPassConstructor` (which extends `ComposablePass` and implements `IPassConstructor`). It is the central "Uber Post" pass that chains together:

1. **Sharpen** (HGSharpen)
2. **Fisheye Effect** (HGFisheyeEffect)
3. **Color Grading** (LUT build via `UberPostPassUtils.ColorGradingPass`)
4. **Bloom** (via `UberPostPassUtils.BloomPass`)
5. **Frosted Glass / Multiblur** (via `UberPostPassUtils.FrostedGlassPass`)
6. **Auto Exposure** (via `UberPostPassUtils.ExecuteAutoExposure`)
7. **Cutscene Effect** (via `UberPostPassUtils.CutsceneEffectPass`)
8. **Uber Pass** — the final composite pass that applies Vignette, Dirty Lens, Radial Blur, BW Flash, Chromatic Aberration, and other screen-space effects

Separate standalone passes (called before the Uber Post chain):

- **Depth Of Field** — `DepthOfFieldPassConstructor`
- **Motion Blur** — `MotionBlurPassConstructor`
- **TAAU (Temporal Anti-Aliasing + Upscale)** — `TAAUPassConstructor`
- **MetalFX Spatial Upscale** — `MetalFXSpatialPassConstructor`
- **MetalFX Temporal Upscale** — `MetalFXTemporalPassConstructor`
- **Lens Flare** — `LensFlarePassConstructor`
- **Light Shaft** — `LightShaftPassConstructor` + `LightShaftApplyPassConstructor`
- **Distortion** — `DistortionPassConstructor`
- **Parafin (wax/paraffin)** — `ParafinPassConstructor`
- **Screen Space Overlay** — `ScreenSpaceOverlayPassConstructor`
- **Set Final Target** — `SetFinalTargetPassConstructor`

### 1.1 Pass Constructor Pattern

Every pass constructor follows this pattern:

```csharp
internal class XxxPassConstructor : IPassConstructor
{
    // PassInput struct — what the pass reads from the render graph
    internal struct PassInput { ... }

    // PassOutput struct — what the pass writes
    internal struct PassOutput { ... }

    // PassData class — transient data used by the render function (lives on render graph stack)
    private class XxxPassData
    {
        // All textures, parameters, materials, compute shaders needed at render time
    }

    // Constructor: takes HGRenderPipelineMaterialCollector + HGRenderPathResources
    // Creates materials from collector, finds compute kernels, initializes static render funcs

    // ConstructPass: adds render passes to the graph via HGRenderGraphBuilder
    // Allocates transient textures, reads/writes, sets render funcs

    // Static render funcs: lambdas/static methods registered via SetRenderFunc<T>
}
```

### 1.2 Render Graph Resource Model

Textures are created through:
- `HGRenderGraph.CreateTransientTexture` — temporary RT that lives only during the pass
- `HGRenderGraph.CreateTexture` — persistent or frame-lifetime RT
- `HGRenderGraphBuilder.ReadTexture` / `WriteTexture` — declares read/write dependencies

Texture handles are `TextureHandle` structs (blittable, 16 bytes: likely a packed handle index).

### 1.3 Post-Processing Pass Order (full frame)

```
Input SceneColor + SceneDepth + MotionVectors
    │
    ├─ Distortion Pass (opaque renderers)
    ├─ TAAU Pass (historically: Dilation → MaskDilation → Resolve)
    ├─ MetalFX Spatial / Temporal (if enabled)
    ├─ Depth Of Field (if enabled)
    ├─ Light Shaft Downsample + Apply
    ├─ Lens Flare
    ├─ Motion Blur (if enabled)
    │
    └─ Uber Post Chain (PostProcessPassConstructor):
         ├─ Sharpen
         ├─ Fisheye Effect
         ├─ Color Grading
         ├─ Bloom
         ├─ Frosted Glass / Multiblur
         ├─ Auto Exposure
         ├─ Cutscene Effect (if VFXPPCutsceneEffect active)
         └─ Uber Pass (Vignette, Dirty Lens, Radial Blur, BW Flash, Chromatic Aberration, World UI, etc.)
              │
              └─ Set Final Target (copy to backbuffer)
```

---

## 2. Depth Of Field (`DepthOfFieldPassConstructor`)

**File**: `DepthOfFieldPassConstructor.cs`  
**Volume Component**: `HGDepthOfField` + `HGDepthOfFieldData`  
**Quality enum**: `HGDepthOfFieldQuality` (values: presumably Off / Gaussian / CircleHigh / CircleLow)

### 2.1 Pass Input/Output

```csharp
internal struct PassInput
{
    internal HGDepthOfFieldQuality quality;
    internal float depthOfFieldMaxRadius;
    internal TextureHandle motionVectorTexture;
    internal TextureHandle sceneColor;
    internal TextureHandle sceneDepth;
    public ScriptableRenderContext renderContext;
}

internal struct PassOutput
{
    internal TextureHandle result;
}
```

### 2.2 Gaussian Pass IDs

```csharp
private enum GaussianPassID
{
    CoC = 0,          // Circle of Confusion computation
    Temporal = 1,     // Temporal accumulation
    Downsample = 2,   // Downsample scene color
    Horizonal = 3,    // Horizontal blur (note: typo in original)
    Vertical = 4,     // Vertical blur
    Apply = 5         // Composite result
}
```

### 2.3 Transient Texture Names (from metadata strings)

- `"Depth Of Field CoC"` — Circle of Confusion (R16 half/float)
- `"Depth Of Field CoC Downsample"` — Downsampled CoC
- `"Depth Of Field Tile CoC"` — Tiled CoC (max in tiles, 49x = 0x31)
- `"Depth Of Field Color Downsample"` — Downsampled scene color
- `"Depth Of Field Color One Component"` — Single-channel blur target (Luma/CoC combined)
- `"Depth Of Field Color One Component Alpha"` — Single-channel + alpha
- `"Depth Of Field Color Two Components"` — Two-channel blur target
- `"Depth Of Field Blur 0"` / etc. — Blur intermediate

### 2.4 Render Pass Names

- `"Depth of Field 0"` through `"Depth of Field 4"` — multiple sub-passes
- `"Circle Depth of Field"` — circle-of-confusion bokeh pass
- `"Depth Of Field Blur 0"` — blur variant

### 2.5 CircleDepthOfFieldPassData Fields

```csharp
private class CircleDepthOfFieldPassData
{
    public bool usePhysicalCamera;
    public HGDepthOfFieldQuality quality;
    public Vector4 param0;           // (near blur, far blur, CoC scale, unused)
    public Vector4 param1;           // (near start, near end, far start, far end)
    public Vector4 param2;           // (near radius, far radius, temporal factor, unused)
    public Vector4 param3;           // (max radius, screen height, aspect, CoC multiplier)
    public Vector4 nearStartColor;
    public Vector4 nearEndColor;
    public Vector4 farStartColor;
    public Vector4 farEndColor;
    public Vector4 screenSize;
    public Vector4 downsampleScreenSize;
    public Vector4 tileCoCScreenSize;
    public Vector2Int screenSizeInt;
    public Vector2Int downsampleScreenSizeInt;
    public Vector2Int tileCoCScreenSizeInt;
    public TextureHandle sceneColorTexture;
    public TextureHandle sceneDepthTexture;
    public TextureHandle motionVectorTexture;
    public TextureHandle cocTexture;
    public TextureHandle downsampleCoCTexture;
    public TextureHandle tileCoCTexture;
    public TextureHandle blurTileCoCTexture;
    public TextureHandle oneComponentVeritcalTexture0;  // (typo in original)
    public TextureHandle oneComponentVeritcalTexture1;
    public TextureHandle oneComponentHorizontalTexture;
    public TextureHandle oneComponentAlphaTexture0;
    public TextureHandle oneComponentAlphaTexture1;
    public TextureHandle twoComponentsVerticalTexture0;
    public TextureHandle twoComponentsVerticalTexture1;
    public TextureHandle twoComponentsVerticalTexture2;
    public TextureHandle farHorizontalTexture;
    public TextureHandle previousDownSampleSceneColorTexture;
    public TextureHandle currentDownSampleSceneColorTexture;
    public TextureHandle outputTexture;
    public ComputeShader computeShader;
    public CBHandle cbHandle;
    public TextureHandle blurTexture0;
    public TextureHandle blurTexture1;
    public MaterialPropertyBlock mpb;
    public Material material;
}
```

### 2.6 DepthOfFieldData (CBUFFER struct)

```csharp
public struct DepthOfFieldData
{
    public Vector4 param0;
    public Vector4 param1;
    public Vector4 param2;
    public Vector4 param3;
    public Vector4 downsampleScreenSize;
    public Vector4 tileCoCScreenSize;
}
```

### 2.7 Algorithm (Reconstructed)

**High Quality (Circle Bokeh)**:
1. **CoC Pass**: Compute circle of confusion from scene depth + camera focus params. Output R channel.
2. **Tile CoC Pass**: Downsample CoC into tiles (7×7 tiles?), compute max CoC per tile. Texture format: 0x31 = R16 half.
3. **Blur Tile CoC**: Dilate/blur tile CoC to avoid hard edges.
4. **Color Downsample**: Downsample scene color (1/2 or 1/4). Texture format: 0x30 = R16G16B16A16 half.
5. **Separable Blur Passes**: Multiple horizontal + vertical passes on:
   - One-component texture (near CoC weighted)
   - One-component texture with alpha
   - Two-component texture (far + near)
6. **Apply Pass**: Composite blurred layers back onto scene color. Uses near/far start/end color for chromatic aberration of bokeh.

**Gaussian Fallback**:
- Simpler 2-pass separable gaussian blur
- CoC → Downsample → Horizontal → Vertical → Apply

**Low Quality**:
- Reduced resolution, fewer samples

### 2.8 Volume Component: HGDepthOfField

```csharp
public class HGDepthOfField : VolumeComponent
{
    // Focus mode toggle: Manual vs Auto vs PhysicalCamera
    // When Manual: uses focusDistance
    // When PhysicalCamera: reads Camera.focalLength + Camera.sensorSize
    public BoolParameter focusMode;          // true=Manual, false=Auto
    public ClampedFloatParameter scale;      // blur scale multiplier
    public HGDepthOfFieldQualityParameter type; // Gaussian, CircleHigh, CircleLow

    // Near blur range
    public MinFloatParameter nearStart;      // where near blur begins (distance)
    public MinFloatParameter nearEnd;        // where near blur is max
    public ClampedFloatParameter nearMaxRadius;

    // Far blur range
    public MinFloatParameter farStart;       // where far blur begins (distance)
    public MinFloatParameter farEnd;         // where far blur is max
    public ClampedFloatParameter farMaxRadius;

    // Temporal
    public ClampedFloatParameter temporalFactor; // defaults to ~0.5f

    // Debug
    public HGDebugCommandParameter hgDebugCommand;
}
```

### 2.9 HGDepthOfFieldData (Serializable data container)

```csharp
[Serializable]
public class HGDepthOfFieldData
{
    public bool focusMode;
    public float scale = 1f;
    public HGDepthOfFieldQuality type;
    public float nearStart;
    public float nearEnd;
    public float nearMaxRadius;
    public float farStart;
    public float farEnd;
    public float farMaxRadius;
    public float temporalFactor = 0.5f;
    public HGDebugCommand hgDebugCommand;
}
```

### 2.10 Camera Parameter Math (from il2cpp)

The `Prepare` method computes:
- Physical camera sensor size → focal length → CoC scale
- Gate fit handling (Overscan vs. other)
- `param0.x = (nearPlane * farClip) / (farClip - nearPlane) * focusDistance / sensorHeight`
- `param1 = (nearStart, nearEnd, farStart, farEnd)` clamped to `[0, depthOfFieldMaxRadius]`
- Temporal factor: read from component
- Screen size: compute from camera pixel dimensions, include scale

---

## 3. Motion Blur (`MotionBlurPassConstructor`)

**File**: `MotionBlurPassConstructor.cs`  
**Volume Component**: `HGMotionBlur`

### 3.1 Pass Input/Output

```csharp
internal struct PassInput
{
    internal TextureHandle sceneColor;
    internal TextureHandle sceneDepth;
    internal TextureHandle sceneMV;
    internal HGSettingParameters settingParameters;
}

internal struct PassOutput
{
    internal TextureHandle result;
}
```

### 3.2 Compute Shader Kernels

Kernel names found via `ComputeShader.FindKernel`:

| Kernel Name | Field | Purpose |
|---|---|---|
| `"Packing"` | `m_packingKernel` | Pack motion vectors + depth into velocity tile |
| `"TileMax"` | `m_tileMaxKernel` | Compute per-tile max velocity |
| `"TileNeighbor"` | `m_tileNeighborKernel` | Dilate tile velocities to neighbors |
| `"MotionBlur"` | `m_motionBlurKernel` | Apply directional blur per pixel |
| `"BlendMotionBlur"` | `m_blendMotionBlurKernel` | Blend with history for accumulation |

### 3.3 MotionBlurPassData Fields

```csharp
private class MotionBlurPassData
{
    public int packKernel;
    public int tileMaxKernel;
    public int tileNeighborKernel;
    public int motionBlurKernel;
    public int blendMotionBlurKernel;
    public int packingThreadX;
    public int packingThreadY;
    public int tileMaxThreadX;
    public int tileMaxThreadY;
    public int tileNeighborThreadX;
    public int tileNeighborThreadY;
    public int motionBlurThreadX;
    public int motionBlurThreadY;
    public uint frameIndex;
    public float blendFrame;
    public float[] historyWeights;      // length 5
    public float[] parameters;          // length 16 (PARAMETERS_FLOAT_NUM = 16)
    public TextureHandle currSceneColorTexture;
    public TextureHandle currSceneDepthTexture;
    public TextureHandle currMVTexture;
    public TextureHandle packingTexture;       // "Motion Blur Packing"
    public TextureHandle tileMaxTexture;       // "Motion Blur Tile Max"
    public TextureHandle tileNeighborTexture;
    public TextureHandle motionBlurTexture;
    public TextureHandle blendMotionBlurTexture;
    public TextureHandle[] historyMotionBlurTextures; // length 5
    public ComputeShader computeShader;
    public TextureHandle debugTexture0;
}
```

### 3.4 Render Pass Names

- `"Motion Blur Pass"` — the main render graph pass name
- `"Motion Blur Packing"` — packing texture (format: 0x4B = `GraphicsFormat.R16G16B16A16_SNorm`? or SFloat, 75 bytes = 75 decimal = 0x4B)
- `"Motion Blur Tile Max"` — tile max texture (format: 0x2E = `GraphicsFormat.R16_SFloat`)
- `"Motion Blur Target"` — motion blur result texture

### 3.5 History Management

- Frame index modulo 5 (`FRAME_MOD = 5`)
- `m_historyTextures` — array of 5 TextureHandles for temporal accumulation
- `m_historyTimes` — array of 5 floats storing `Time.time` per frame
- `m_historyScreenSize` — Vector2Int to detect resolution changes (triggers reset)
- On resolution change or disable: `Reset()` clears history

### 3.6 Algorithm (5-pass compute)

1. **Packing**: Read sceneColor + depth + motionVectors → write `packingTexture` (half-res velocity + depth)
2. **TileMax**: Reduce to tile grid (screen/8 × screen/8) → `tileMaxTexture` — per-tile max velocity magnitude
3. **TileNeighbor**: Dilate tile max to 3×3 neighborhood → `tileNeighborTexture` — avoids tile-boundary artifacts
4. **MotionBlur**: For each pixel, sample along velocity vector (shutterAngle * sampleCount steps) → `motionBlurTexture`
5. **BlendMotionBlur**: Blend current frame motion blur with history buffer (temporal accumulation) → output

Parameters:
- `parameters[0]`: shutterAngle / 360°
- `parameters[1]`: sampleCount (clamped to e.g. 4-16)
- `parameters[2]`: 1.0 / tileMaxWidth
- `parameters[3]`: 1.0 / tileMaxHeight
- `parameters[4..7]`: thread group dimensions
- `parameters[8..15]`: history weights for 5-frame accumulation

History weight computation:
- Blend factor = `clamp(timeDelta * motionBlurDecay, 0, 1)`
- Weights are stored per-frame, indexed by `(frameIndex - i + 5) % 5`

### 3.7 Volume Component: HGMotionBlur

```csharp
public class HGMotionBlur : VolumeComponent
{
    public BoolParameter enable;          // master toggle
    public ClampedFloatParameter shutterAngle; // 0-360, default ~180
    public ClampedFloatParameter blendFrame;   // 0-1, history blend
    public IntParameter sampleCount;       // clamped, e.g. 4-16
}
```

---

## 4. TAAU (`TAAUPassConstructor`)

**File**: `TAAUPassConstructor.cs`  
**Settings file**: `HGTAAUSettings.cs`

### 4.1 Pass Input/Output

```csharp
internal struct PassInput
{
    internal TextureHandle sceneColor;
    internal TextureHandle sceneDepth;
    internal TextureHandle utilityDepth;
    internal TextureHandle sceneMV;
    internal TextureHandle historySceneColor;     // previous frame TAAU result
    internal Vector2Int renderSize;               // internal render resolution
    internal Vector2Int screenSize;               // output resolution
    internal float renderingScale;
    internal float historyWeight;
    internal float historyWeightInMotion;
    internal float fastConvergeHistoryWeight;
    internal float responsiveAAHistoryWeight;
    internal float minMVConsideredDynamic;
    internal float maxMVConsideredDynamic;
    internal float characterMotionSensitivity;
    internal float occlusionDepthDiff;
    internal float inputSampleLumaWeight;
    internal float sharpenStrength1K;
    internal float sharpenStrength2K;
    internal float sharpenStrength4K;
    internal float enableResponsiveTransparency;
    internal TAAUQuality quality;            // Low, Med, High, VeryHigh
    internal int renderPathFrameIndex;
    internal bool enableTAAU;
    internal bool fastConvergeState;
}

internal struct PassOutput
{
    internal TextureHandle currentSceneColor;
}
```

### 4.2 TAAU Quality Levels

```csharp
internal enum TAAUQuality
{
    Low,
    Med,
    High,
    VeryHigh
}
```

### 4.3 Render Passes / Sub-Passes

Four passes registered in the render graph:

| Pass Name | Pass Type | Purpose |
|---|---|---|
| `"TAAU Dilation Pass"` | `DilationPassData` | Dilate depth+MVs to avoid disocclusion artifacts |
| `"TAAU Mask Dilation Pass"` | `MaskDilationPassData` | Dilate character/object masks |
| `(FlickerDetection)` | (inlined) | Detect sub-pixel flicker for responsive AA |
| `"TAAU Resolve Pass"` | `ResolvePassData` | Main TAAU resolve + sharpen |

### 4.4 RT Names (Ping-Pong)

```csharp
private struct RTNames
{
    internal string dilatedDepthRTName;   // "DilatedDepth0" / "DilatedDepth1"
    internal string dilatedMVRTName;      // "DilatedMV0" / "DilatedMV1"
    internal string taauResultRTName;     // "TAAUResult0" / "TAAUResult1"
}
```

Two sets for frame N-1 / N ping-pong, stored in `m_rtNames[2]`.

### 4.5 DilationPassData

```csharp
private class DilationPassData
{
    internal TextureHandle sceneDepth;
    internal TextureHandle sceneMV;
    internal TextureHandle currDilatedSceneDepth;   // output
    internal TextureHandle currDilatedSceneMV;      // output
    internal TextureHandle historyDilatedSceneDepth; // previous frame
    internal TextureHandle historyDilatedSceneMV;    // previous frame
    internal Material material;
}
```

### 4.6 MaskDilationPassData

```csharp
private class MaskDilationPassData
{
    internal TextureHandle currDilatedMask;
    internal Material material;
}
```

### 4.7 ResolvePassData

```csharp
private class ResolvePassData
{
    internal TextureHandle sceneColor;
    internal TextureHandle sceneDepth;
    internal TextureHandle sceneMV;
    internal TextureHandle historySceneColor;
    internal TAAUQuality quality;
    internal Material material;
}
```

### 4.8 TAAUConstants (CBUFFER, 0xC0 = 192 bytes)

12 Vector4 values packed into a GPU constant buffer:

```csharp
private struct TAAUConstants
{
    // taauParameters0: (renderWidth, renderHeight, 1/renderWidth, 1/renderHeight)
    // taauParameters1: (screenWidth, screenHeight, 1/screenWidth, 1/screenHeight)
    // taauParameters2: (scaleFactor, invScaleFactor, jitterOffsetX, jitterOffsetY)
    // taauParameters3: (historyWeight, historyWeightInMotion, motionScale, unused)
    // taauParameters4: (fastConvergeWeight, responsiveAAWeight, sharpenStrength, occlusionDepthDiff)
    // taauParameters5: (minMV, maxMV, characterMotionSensitivity, firstFrame)
    // taauParameters6: (enableResponsiveTransparency, inputSampleLumaWeight, unused, unused)
    // taauParameters7: (gaussianWeights_0to3 packed)
    // taauParameters8: (gaussianWeights_4to7 packed)
    // kernelWeights0-2: (gaussian kernel weights for sharpen)
    public Vector4 taauParameters0;
    public Vector4 taauParameters1;
    public Vector4 taauParameters2;
    public Vector4 taauParameters3;
    public Vector4 taauParameters4;
    public Vector4 taauParameters5;
    public Vector4 taauParameters6;
    public Vector4 taauParameters7;
    public Vector4 taauParameters8;
    public Vector4 kernelWeights0;
    public Vector4 kernelWeights1;
    public Vector4 kernelWeights2;
}
```

### 4.9 Sharpen Strength by Resolution

```csharp
private struct SharpenStrengthParam
{
    public float sharpen1K;  // ~1080p strength
    public float sharpen2K;  // ~1440p strength
    public float sharpen4K;  // ~2160p strength
}
```

The actual sharpen strength is interpolated based on screen resolution height.

### 4.10 Gaussian Kernel

Kernel size = 9 (stored in `m_gaussianKernel[9]`). Standard deviation stored in `m_gaussianKernelStdDev` (default 1.0 = 0x3F800000). Recalculated via `ComputeGaussianKernel()` when std dev changes. Used for:
- History clamping (AABB clip weights)
- Sharpen convolution

### 4.11 Algorithm

1. **Jitter**: Sub-pixel jitter applied to projection matrix (2-7 frame pattern). Jitter offset stored in `taauParameters2.zw`.

2. **Dilation Pass**: Dilate scene depth and motion vectors using nearest-neighbor max filter (3×3 or 5×5). This prevents disocclusion artifacts where background pixels use foreground history. Outputs:
   - `currDilatedSceneDepth` — dilated depth
   - `currDilatedSceneMV` — dilated motion vectors

3. **Mask Dilation**: Dilate character/object ID masks for per-object motion handling.

4. **Flicker Detection**: Detect sub-pixel flicker (high-frequency spatial patterns). Uses gradient-based detection to identify pixels where TAA would cause shimmering.

5. **Resolve Pass**:
   - Reproject previous frame using motion vectors (neighborhood sampling 3×3)
   - History clamp: AABB (axis-aligned bounding box) or clip (variational clipping) of history neighborhood
   - Motion-adaptive weight: blend between `historyWeight` (static) and `historyWeightInMotion` (dynamic) based on velocity magnitude
   - Fast converge: when camera cuts or scene changes, use lower history weight for rapid convergence
   - Responsive AA: for sub-pixel detail regions, reduce history weight
   - Character motion: separate velocity sensitivity for character movement vs camera movement
   - Input sample luma weight: luma-based blending to reduce ghosting
   - Responsive transparency: for alpha-tested/transparent objects, reduce temporal accumulation
   - Sharpen: post-AA sharpen using the Gaussian kernel (strength scaled by resolution)

6. **History Preservation**: `OnPostRendering` preserves TAAU result textures via `HGRenderGraph.PreserveTexture` with name `"TAAUPass"`.

### 4.12 Settings: HGTAAUSettings

```csharp
public class HGTAAUSettings
{
    public float scaleFactor;                // 0.5-2.0, internal resolution multiplier
    public float occlusionDepthDiff;         // depth diff threshold for disocclusion
    public float sharpenStrengthMin;         // min sharpen at 4K
    public float sharpenStrengthMax;         // max sharpen at 1080p
    public float historyWeight;              // default history blend (static scene)
    public float motionWeight;              // history blend when in motion
    public float fastConvergeWeight;        // weight during fast convergence
    public float responsiveAAWeight;        // weight for responsive AA regions
    public float detectMotionMin;           // MV threshold: considered static
    public float detectMotionMax;           // MV threshold: considered fully dynamic
    public float characterMotionSensitivity; // scaling for character motion vs camera
    public float lumaWeight;               // input sample luma weight

    public static HGTAAUSettings GetDefault(); // returns instance with sensible defaults
}
```

---

## 5. MetalFX Spatial & Temporal (`MetalFXSpatialPassConstructor`, `MetalFXTemporalPassConstructor`)

**Files**: `MetalFXSpatialPassConstructor.cs`, `MetalFXTemporalPassConstructor.cs`

Apple MetalFX upscaling integration. These are platform-specific passes for macOS/iOS Metal devices.

### 5.1 MetalFX Spatial

```csharp
internal class MetalFXSpatialPassConstructor : IPassConstructor
{
    internal struct PassInput
    {
        internal int inputWidth;
        internal int inputHeight;
        internal int outputWidth;
        internal int outputHeight;
        internal GraphicsFormat format;
        // ... native handle for MetalFX texture descriptors
    }
}
```

- Single-pass spatial upscale using MetalFX `FXASpatialScaling`
- Takes low-res color buffer → outputs high-res
- Requires MetalFX framework on device

### 5.2 MetalFX Temporal

```csharp
internal class MetalFXTemporalPassConstructor : IPassConstructor
{
    internal struct PassInput
    {
        // Same as spatial + motion vectors + depth + jitter
        internal TextureHandle sceneColor;
        internal TextureHandle sceneDepth;
        internal TextureHandle sceneMV;
        internal Vector2 jitterOffset;
        internal bool reversedDepth;
        internal bool resetHistory;
        // ...
    }
}
```

- Uses MetalFX `FXATemporalScaling` for temporal upscaling
- Takes additional depth + motion vector inputs
- Jitter offset for sub-pixel sampling
- `resetHistory` flag triggers history buffer clear (camera cut detection)
- Controls queried via `HGCamera.get_enableMetalFXTemporalScaler()` / `get_enableMetalFXSpatialScaler()`

---

## 6. Uber Post (`PostProcessPassConstructor`)

**File**: `PostProcessPassConstructor.cs` — the main orchestrator, extends `ComposablePass`.

### 6.1 Pass Input/Output

```csharp
internal struct PassInput
{
    internal TextureHandle sceneColor;
    internal TextureHandle sceneDepth;
    internal TextureHandle sceneMV;
    internal TextureHandle target;
    internal CullingResults cullingResults;
    internal TAAUQuality taauQuality;
    internal DepthBits depthBits;
    internal GraphicsFormat depthFormat;
    internal HGRenderPathInternal renderPath;
    internal HGRenderPipeline hgrp;
    internal bool render3DUI;
    internal float renderingScale;
    internal float screenCullingRatio;
    internal float screenCullingRatioDistance;
    internal uint screenCullingLayerMask;
}

internal struct PassOutput
{
    internal TextureHandle output;
    internal TextureHandle frostedGlassRT;   // shared RT for frosted glass effect
}
```

### 6.2 Materials (created in constructor)

| Field | Resource Key | Purpose |
|---|---|---|
| `m_FinalPassMaterial` | `resources[0x2D0]` | Final copy to backbuffer |
| `m_UberPostMaterial` | `resources[0x2B0]` | Uber post shader |
| `m_FisheyeEffectMaterial` | `resources[0x2B0]` (same key?) | Fisheye |
| `m_FisheyeEffectDepthMaterial` | `resources[0x2B0]` | Fisheye depth variant |
| `m_LutBuilder2DMaterial` | `resources[0x2A0]` | 2D LUT generation |
| `m_SharpenMaterial` | `resources[0x2C8]` | Sharpening |
| `m_SMAAMaterial` | (via collector) | SMAA (optional) |

### 6.3 Volume Components (read from camera)

| Field | Component Type | Purpose |
|---|---|---|
| `m_Bloom` | `Bloom` | Bloom settings |
| `m_Vignette` | `Vignette` | Standard Unity Vignette |
| `m_HGVignette` | `HGVignette` | HG custom Vignette |
| `m_HGDirtyLens` | `HGDirtyLens` | Lens dirt overlay |
| `m_Sharpen` | `HGSharpen` | Sharpening |
| `m_RadialBlur` | `HGRadialBlur` | Radial blur |
| `m_BWFlash` | `HGBWFlash` | Black & white flash |
| `m_FisheyeEffect` | `HGFisheyeEffect` | Fisheye distortion |
| `m_chromaticAbberation` | `HGChromaticAbberation` | Chromatic aberration |

### 6.4 ConstructPass Flow (from il2cpp, fully mapped)

1. **Read `HGCamera` settings**: sharpen, bloom, etc. from camera's volume stack
2. **Check `UberPostPassUtils.ShouldRenderPostProcess()`**: if false, skip directly to FinalPass
3. **Sharpen Pass**: if `HGSharpen.IsActive()` + setting enables sharpen
   - Calls `UberPostPassUtils.SharpenPass(source, camera, settingParams, sharpenMaterial)`
4. **Fisheye Effect Pass**: if `HGFisheyeEffect.IsActive()`
   - Calls `UberPostPassUtils.FisheyeEffectPass(fisheye, fisheyeDepthMat, fisheyeMat, ...)`
5. **Color Grading Pass**: build LUT texture
   - Calls `UberPostPassUtils.ColorGradingPass(camera, lutSize, lutFormat, ...)`
   - Returns `logLut` texture handle
   - Uses `m_cachedColorLut` for persistent LUT
6. **Bloom Pass**: if `Bloom.IsActive()`
   - Calls `UberPostPassUtils.BloomPass(bloomVolume, camera, source, logLut, ...)`
   - Returns bloom texture
7. **Frosted Glass Pass**: multiblur for UI frost effect
   - Calls `UberPostPassUtils.FrostedGlassPass(source, bloom, camera, ...)`
   - Uses `m_frostedGlassPSMaterials` (3 levels: low/med/high)
8. **Auto Exposure**: if enabled
   - Calls `UberPostPassUtils.ExecuteAutoExposure(camera, ...)`
9. **Cutscene Effect**: if `VFXPPCutsceneEffect` active
   - Calls `UberPostPassUtils.CutsceneEffectPass(...)`
10. **Uber Pass**: Final composite
    - Calls `UberPass(input, settings, renderGraph, camera, source, logLut, bloomTexture)`

### 6.5 UberPass (final composite)

Pass name: `"Uber Post"`  
Profile ID: `0x9D` (157 = HGProfileId.UberPost)

Inside the Uber Pass render function:
1. **Vignette**: Composite Standard Vignette (from `m_Vignette`) + HG Vignette (`m_HGVignette`)
   - Reads color, intensity, smoothness, rounded toggle, blink toggle
   - Merges with HG Vignette parameters (separate color, intensity, blink rate)
   - Writes to shader constants for UberPostMaterial
2. **Lens Dirt / Dirty Lens**: `m_HGDirtyLens` — composite dirty texture overlay
3. **Radial Blur**: `m_RadialBlur` — radial blur from center point
4. **BW Flash**: `m_BWFlash` — desaturation + flash texture overlay
5. **Chromatic Aberration**: `m_chromaticAbberation` — radial chromatic shift
6. **World UI**: Prepares world-space UI rendering (depth-aware UI compositing)
   - Calls `PrepareWorldUIData(data, hgCamera, depthRT)` — writes depth RT handles to UberPostPassData
   - World UI culling distance: 5000f
7. **Alpha handling**: depends on `m_EnableAlpha`, `m_KeepAlpha`, `m_EnableAlphaForUI` flags

### 6.6 FinalPass

Pass name: (not explicitly named in metadata, uses `FinalPassData`)
- Copies Uber post result → backbuffer color
- Copies depth → backbuffer depth (with optional flipY)
- Uses `m_FinalPassMaterial` with `backBufferRect` and `viewPortSize` parameters

### 6.7 Frosted Glass RT Management

- `m_sceneFrostedGlassRTs` — array of 3 RTHandles
- `m_sceneFrostedGlassRTSizes` — array of 3 Vector2Int
- `k_RTGuardBandSize = 4` — guard band around frosted glass RT
- Managed through `UberPostPassUtils.PrepareFrostedGlassPSMaterials()`

### 6.8 OnPreRendering

Sets global shader textures for all 3 frosted glass RT levels:
- `_FrostedGlassColorTexture_0` through `_FrostedGlassColorTexture_2` (3 levels)
- `_FrostedGlassDepthTexture` — depth for frosted glass
- These use `HGShaderIDs` via reflection

---

## 7. Bloom

**File**: `Bloom.cs`  
**Volume Component**: `Bloom` (extends `VolumeComponent`)

### 7.1 Parameters

```csharp
[VolumeComponentMenuForRenderPipeline("Post-processing/Bloom", typeof(HGRenderPipeline))]
public sealed class Bloom : VolumeComponent, IPostProcessComponent
{
    // Quality level selector
    public BloomQualityParameter quality;    // Hi / Med / Lo

    // Per-quality resolution
    public BloomResolutionParameter resolutionHighQuality;
    public BloomResolutionParameter resolutionMedQuality;
    public BloomResolutionParameter resolutionLowQuality;

    // Per-quality threshold (minimum brightness, gamma-space)
    public MinFloatParameter thresholdHighQuality;
    public MinFloatParameter thresholdMedQuality;
    public MinFloatParameter thresholdLowQuality;

    // Per-quality intensity (0-1 clamped)
    public ClampedFloatParameter intensityHighQuality;  // default ~1
    public ClampedFloatParameter intensityMedQuality;
    public ClampedFloatParameter intensityLowQuality;

    // Per-quality scatter (radius)
    public ClampedFloatParameter scatterHighQuality;
    public ClampedFloatParameter scatterMedQuality;
    public ClampedFloatParameter scatterLowQuality;

    // Tint color
    public ColorParameter tint;              // default white

    // Bloom blend mode
    public BloomBlendModeParameter blendMode; // Add, Alpha, Screen, DistanceFade

    // Character bloom control (per-object bloom separation)
    public BoolParameter characterBloomControl;  // enable/disable
    public MinFloatParameter characterThreshold;
    public ClampedFloatParameter characterSoftness;
    public ClampedFloatParameter characterIntensity;

    // Lens dirt
    public Texture2DParameter dirtTexture;
    public MinFloatParameter dirtIntensity;

    // Anamorphic bloom
    [AdditionalProperty]
    public BoolParameter anamorphic;
    // (anamorphic angle/intensity likely in UberPostPassUtils)
}
```

### 7.2 Computed Properties

```csharp
public BloomResolution resolution { get; }  // reads per-quality resolution
public float threshold { get; }             // reads per-quality threshold
public float intensity { get; }             // reads per-quality intensity
public float scatter { get; }               // reads per-quality scatter
public bool dirtEnabled { get; }            // dirtTexture != null && dirtIntensity > 0
```

### 7.3 Active Check

`IsActive()` returns true when `intensity > 0`.

### 7.4 Algorithm (via UberPostPassUtils.BloomPass)

1. **Prefilter**: Extract bright pixels (pixels above threshold). Apply tint color.
2. **Downsample cascade**: Repeated 2×2 downsample (Pyramid). At each mip:
   - Apply scatter (blur radius increases at coarser levels)
   - Different resolution per quality tier (Hi=full, Med=1/2, Lo=1/4)
3. **Upsample + blend**: Bicubic upsample from coarsest to finest, accumulating bloom
4. **Compositing**: Blend with scene using `blendMode` (Add/Alpha/Screen/DistanceFade)
5. **Lens dirt**: Composite dirt texture over bloom (multiply or add)
6. **Anamorphic**: If enabled, stretch bloom horizontally with anamorphic angle/intensity

Character bloom control:
- Uses separate threshold/intensity for character vs environment bloom
- Character mask from renderer features

---

## 8. Auto Exposure (`HGAutoExposure`)

**File**: `HGAutoExposure.cs`  
**Volume Component**: `HGAutoExposure`

### 8.1 Parameters

```csharp
public class HGAutoExposure : VolumeComponent
{
    public BoolParameter enable;

    // Metering mode
    public AutoExposureMeteringModeParameter meteringMode; // Average, CenterWeighted, Spot

    // Auto mode params
    public ClampedFloatParameter exposureLerpUpSpeed;     // adaptation speed (brighter → darker)
    public ClampedFloatParameter exposureLerpDownSpeed;   // adaptation speed (darker → brighter)
    public Vector2Parameter EV100Range;                   // min/max EV100
    public Vector2Parameter EV100HistogramRange;          // histogram evaluation range
    public Vector2Parameter pixelLuminanceRange;          // pixel luminance clamp range
    public Vector2Parameter evClampRange;                 // output EV clamp

    // Center-weighted metering
    public ClampedFloatParameter centerPixelWeight;       // weight of center pixel

    // Manual mode
    public BoolParameter manualMode;                      // override with manual EV
    public FloatParameter manualEVCompensation;           // manual EV compensation
    public CurveParameter envEV100CompensationCurve;      // environment EV100 compensation
    public FloatParameter envEV100CompensationAuto;       // auto EV compensation from env
    public FloatParameter envEV100CompensationManual;     // manual EV compensation from env
}
```

### 8.2 Algorithm (via UberPostPassUtils.ExecuteAutoExposure)

1. **Histogram computation**: Downsample scene luminance, compute histogram in GPU
2. **EV evaluation**: Determine scene EV100 from histogram (average/center/spot based on metering mode)
3. **Temporal smoothing**: Lerp current EV toward target EV using `exposureLerpUpSpeed`/`exposureLerpDownSpeed`
4. **Output**: `_AutoExposureParams` shader constant for use in the Uber pass
5. Eye adaptation: speed differs for brightening vs darkening

---

## 9. Lens Flare (`LensFlarePassConstructor`)

**File**: `LensFlarePassConstructor.cs`

### 9.1 Pass Data

- Integrates with Unity's `LensFlareCommonSRP` API
- Reads occlusion texture (sun/light occlusion)
- Flare texture array for multi-element flares
- Color data array for per-element tint
- Flare parameters (0-4 elements)
- Panini projection support (for wide FOV)
- Sun direction override

### 9.2 Algorithm

1. **Occlusion query**: Sample sun/light occlusion texture
2. **Flare rendering**: Screen-space flare elements (ghosts + chromatic artifacts)
   - Positioned along the light-to-screen-center axis
   - Scaled by distance and occlusion
3. **Compositing**: Additive blend over scene color
4. Supports debug fullscreen buffer for development

---

## 10. Light Shaft (`LightShaftPassConstructor` + `LightShaftApplyPassConstructor`)

**Files**: `LightShaftPassConstructor.cs`, `LightShaftApplyPassConstructor.cs`

### 10.1 Light Shaft Data

```csharp
// LightShaftPassConstructor
internal struct PassInput
{
    internal TextureHandle sceneColor;
    internal TextureHandle sceneDepth;
    // ...light source direction, color, intensity
}

// Parameters from constructor
internal float downSampleFactor;   // e.g. 4 = 1/4 resolution
internal int sampleNum;           // ray march samples
internal int blurPassCount;       // radial blur iterations
```

### 10.2 Passes

1. **DownSample Pass**: Ray-march from camera to light source through depth buffer
   - Accumulate in-scattering along the ray
   - Output: 1/4 res light shaft buffer
   - Pass name: `"LightShaft Downsample"`

2. **Radial Blur Pass**: Apply radial blur centered on light source
   - Multiple passes (controlled by `blurPassCount`)
   - Blur direction: radial from light source position

3. **Apply Pass** (`LightShaftApplyPassConstructor`):
   - Composite light shaft buffer onto scene color
   - Pass reads `lightShaftBlurResult` + `sceneColor` → writes composited result

---

## 11. Distortion (`DistortionPassConstructor`)

**File**: `DistortionPassConstructor.cs`

### 11.1 Pass Data

- Renders distortion from opaque + transparent renderer lists
- Integrates with `FullScreenVFXData` for VFX-driven distortion
- Feedback ID for temporal accumulation
- Two render funcs:
  - "useless" render func — renders distortion objects
  - "objects" render func — renders through distortion mesh

### 11.2 Algorithm

1. Render opaque distortion objects to distortion RT
2. Render transparent distortion objects (additive)
3. Apply screen-space distortion: sample scene color with offset from distortion RT
4. Results feed forward to later passes

---

## 12. Multiblur / Frosted Glass (`MultiblurPassConstructor`)

**File**: `MultiblurPassConstructor.cs`

### 12.1 Pass Data

- Multiple blur levels for frosted glass UI effect
- Uses `UberPostPassUtils.FrostedGlassPSMaterials` (pre-configured PS materials)
- 3 quality levels for performance scaling

### 12.2 Algorithm

1. Downsample scene color to 3 levels
2. Apply gaussian blur at each level
3. Store in frosted glass RT array for UI rendering (World UI + Screen Space Overlay)
4. UI shaders sample from these pre-blurred textures for frosted glass effect

---

## 13. Parafin (Wax/Paraffin) (`ParafinPassConstructor`)

**File**: `ParafinPassConstructor.cs`

### 13.1 Pass Data

- Mesh + material array (`parafinMaterials`) for paraffin-wax visual effect
- Blit material for compositing
- Depth RT for depth-aware effect
- References `VFXPPCutsceneEffect` for cutscene integration

### 13.2 Algorithm

1. Render paraffin mesh to intermediate RT
2. Blend with scene color based on depth and camera angle
3. Used for wax-seal / paraffin-coated visual effects in cutscenes

---

## 14. Screen Space Overlay (`ScreenSpaceOverlayPassConstructor`)

**File**: `ScreenSpaceOverlayPassConstructor.cs`

### 14.1 Pass Data

- Extends `ComposablePass`
- References `HGCamera` for overlay settings
- Renders overlay UI elements after all post-processing
- Uses `HGRenderGraphBuilder` to add overlay draw commands

---

## 15. Set Final Target (`SetFinalTargetPassConstructor`)

**File**: `SetFinalTargetPassConstructor.cs`

### 15.1 Pass Data

- Copies `finalResult` → `backBufferColor`
- Copies depth → `backBufferDepth`
- FlipY toggle for render texture vs backbuffer orientation
- Uses `copyDepthMaterial` for depth copy

---

## 16. Per-Frame Volume Components

### 16.1 HGVignette

```csharp
public class HGVignette : VolumeComponent
{
    public ColorParameter color;           // vignette color (default black)
    public ClampedFloatParameter intensity; // 0-1, strength
    public ClampedFloatParameter smoothness; // 0-1, feather
    public BoolParameter rounded;          // round vs oval vignette
    public BoolParameter blink;            // toggle blink animation (alpha pulse)
}
```

### 16.2 HGSharpen

```csharp
public class HGSharpen : VolumeComponent
{
    public FloatParameter sharpenMode;     // 0=normal, 1=adaptive, etc.
    public ClampedFloatParameter intensity; // sharpening strength
    public FloatParameter range;           // sharpening range (pixels)
    public ClampedFloatParameter threshold; // edge detection threshold
}
```

### 16.3 HGChromaticAberration

```csharp
public class HGChromaticAberration : VolumeComponent
{
    public BoolParameter enabled;
    public Vector2Parameter center;        // aberration center (screen space)
    public ClampedFloatParameter intensity; // 0-1, chromatic shift strength
    public BoolParameter averageStep;      // use average for sampling
    public BoolParameter enableGlobalCenter; // use global center override
    public Vector3Parameter globalCenter;  // world-space center position
}
```

### 16.4 HGBWFlash

```csharp
public class HGBWFlash : VolumeComponent
{
    public BoolParameter enabled;
    public Vector3Parameter centerPosition; // flash origin (world space)
    public ClampedFloatParameter bwThreshold; // desaturation threshold
    public ClampedFloatParameter colorBias;   // color preservation bias
    public BoolParameter inverse;            // invert mask
    public BoolParameter useFlashTex;        // enable flash texture overlay
    public Texture2DParameter flashTexture;
    public Vector4Parameter flashTexTilingOffset; // tiling + offset
    public Vector3Parameter flashTexSpeed;       // UV animation speed
    public ClampedFloatParameter flashIntensity;
    public BoolParameter useMaskTex;
    public Texture2DParameter maskTexture;
    public ClampedFloatParameter maskIntensity;
    public BoolParameter maskUsePolarUV;     // polar coordinate UV for mask
    public Vector4Parameter maskTexTilingOffset;
    public ColorParameter flashColor;
    public ColorParameter backGroundColor;
}
```

### 16.5 HGDirtyLens

```csharp
public class HGDirtyLens : VolumeComponent
{
    public Texture2DParameter dirtyTex;      // lens dirt texture
    public ClampedFloatParameter intensity;  // overlay opacity (0-1)
}
```

### 16.6 HGRadialBlur

```csharp
public class HGRadialBlur : VolumeComponent
{
    public BoolParameter enabled;
    public Vector2Parameter center;          // blur center (screen UV)
    public ClampedFloatParameter intensity;  // blur strength
    public ClampedFloatParameter power;      // blur falloff power
    public BoolParameter averageSteps;       // use averaged sampling
    public BoolParameter enableGlobalCenter; // use world-space center
    public Vector3Parameter globalCenter;    // world-space center position
}
```

### 16.7 HGFisheyeEffect

```csharp
public class HGFisheyeEffect : VolumeComponent
{
    public BoolParameter enabled;
    public ClampedFloatParameter distortion; // 0-1, distortion strength
}
```

### 16.8 HGMotionBlur (see Section 3.7)

### 16.9 HGDepthOfField (see Section 2.8)

---

## 17. Shader Keywords

From `HGShaderKeyWords` references in il2cpp:

| Keyword | Where Used | Purpose |
|---|---|---|
| `_ENABLE_LIGHT_SHAFT` | UberPostPass | Enables light shaft compositing |
| `_BLOOM_LENS_DIRT` | BloomPass | Enables dirt texture sampling |
| `_BLOOM_ANAMORPHIC` | BloomPass | Anamorphic streak computation |
| `_TAAU_ENABLED` | UberPostPass / TAAU | TAAU shader variant |
| `_TAAU_LOW_QUALITY` | TAAU Resolve | Low quality path |
| `_TAAU_MEDIUM_QUALITY` | TAAU Resolve | Medium quality path |
| `_TAAU_HIGH_QUALITY` | TAAU Resolve | High quality path |
| `_TAAU_VERY_HIGH_QUALITY` | TAAU Resolve | Very high quality path |
| `_FXAA_ENABLED` | UberPostPass | FXAA fallback |
| `_COLOR_GRADING_ENABLED` | UberPostPass | Color grading LUT |
| `_AUTO_EXPOSURE_ENABLED` | UberPostPass | Auto exposure |
| `_VIGNETTE_ENABLED` | UberPostPass | Vignette effect |
| `_DIRTY_LENS_ENABLED` | UberPostPass | Dirty lens overlay |
| `_RADIAL_BLUR_ENABLED` | UberPostPass | Radial blur |
| `_BW_FLASH_ENABLED` | UberPostPass | Black & white flash |
| `_CHROMATIC_ABERRATION_ENABLED` | UberPostPass | Chromatic aberration |
| `_FISHEYE_ENABLED` | UberPostPass | Fisheye distortion |
| `_SHARPEN_ENABLED` | UberPostPass | Sharpening |
| `_PERFECT_SYMMETRY` | MotionBlur | Symmetric motion blur samples |
| `_FIXED_SAMPLE_COUNT` | MotionBlur | Fixed vs dynamic sample count |

---

## 18. Data Flow Diagram

```
Frame Start: SceneColor, SceneDepth, MotionVectors
  │
  ├── [Distortion] ─── opaque + transparent distortion renderers → distortion RT
  │
  ├── [TAAU] ─── Dilation → MaskDilation → Resolve → TAAUResult
  │   Input: sceneColor, sceneDepth, sceneMV, historySceneColor
  │   Output: currentSceneColor (temporally anti-aliased, possibly upscaled)
  │   Preserved: texture saved via PreserveTexture("TAAUPass") for next frame
  │
  ├── [MetalFX Spatial / Temporal] ─── (if platform supports)
  │   Input: low-res color + optionally depth + MV + jitter
  │   Output: high-res color
  │
  ├── [DepthOfField] ─── CoC → TileCoC → BlurTileCoC → ColorDownsample → (HexBokeh|Gaussian) → Apply
  │   Input: sceneColor, sceneDepth, motionVectorTexture
  │   Output: sceneColor (with DoF)
  │
  ├── [LightShaft] ─── DownSample (ray march) → RadialBlur (multiple passes) → Apply
  │   Input: sceneColor, sceneDepth
  │   Output: sceneColor + lightShaft composited
  │
  ├── [LensFlare] ─── Occlusion → Flare elements → Composite
  │
  ├── [MotionBlur] ─── Packing → TileMax → TileNeighbor → MotionBlur → Blend (history accum)
  │   Input: sceneColor, sceneDepth, sceneMV
  │   Output: motion blurred sceneColor
  │
  ├── [UberPost] ─── (PostProcessPassConstructor.ConstructPass)
  │   │
  │   ├── Sharpen ─── apply sharpening filter
  │   ├── Fisheye ─── apply distortion
  │   ├── ColorGrading ─── build + apply LUT
  │   ├── Bloom ─── Prefilter → Downsample(Pyramid) → Upsample → Composite(tint/blend/dirt/anamorphic)
  │   ├── FrostedGlass ─── Multiblur → 3 RT levels for UI
  │   ├── AutoExposure ─── Histogram → EV → Temporal smoothing
  │   ├── CutsceneEffect ─── (if VFXPPCutsceneEffect active)
  │   └── UberPass ─── Vignette + DirtyLens + RadialBlur + BWFlash + ChromaticAberration + WorldUI
  │
  └── [SetFinalTarget] ─── copy to backbuffer (color + depth, optional flipY)
```

---

## 19. Key Implementation Notes

1. **Render Graph Integration**: All passes use `HGRenderGraph.AddRenderPass<T>()` with `HGRenderGraphBuilder` for texture management. No direct command buffer rendering except in `OnPreRendering` for global texture bindings.

2. **Texture Formats**: Identified from il2cpp constants:
   - `0x2D` (45) = `GraphicsFormat.R16_SFloat`
   - `0x2E` (46) = `GraphicsFormat.R16G16_SFloat`
   - `0x30` (48) = `GraphicsFormat.R16G16B16A16_SFloat`
   - `0x31` (49) = `GraphicsFormat.R32_SFloat`
   - `0x4B` (75) = `GraphicsFormat.R16G16B16A16_SNorm`

3. **Thread Group Sizing**: Compute shader dispatch dimensions follow pattern: `ceil(screenSize / 8)` for packing, `ceil(tiles / 8)` for tile operations, full screen for blur.

4. **Profile IDs**: `HGProfileId` values found:
   - `0x4F` (79) = TAAU Dilation Pass
   - `0x9D` (157) = Uber Post
   - `0xA4` (164) = Motion Blur
   - `0xA6` (166) = Depth Of Field

5. **Constant Buffer Allocation**: Uses `ScriptableRenderContext.AllocateConstantBuffer(size)` followed by `UnsafeUtility.MemCpy` for GPU cbuffer upload. Size for TAAU constants: 0xC0 (192 bytes = 12 × Vector4).

6. **Frosted Glass**: Uses 3 levels of RTs stored as `RTHandle[] m_sceneFrostedGlassRTs` with corresponding sizes in `m_sceneFrostedGlassRTSizes`. Level 0 = full res blur, Level 1 = 1/2, Level 2 = 1/4.

7. **MetalFX Integration**: Platform-specific (macOS/iOS). Checked via `HGCamera.get_enableMetalFXTemporalScaler()` / `get_enableMetalFXSpatialScaler()` before constructing passes.

8. **Enable Flags**: Each pass checks its VolumeComponent's `IsActive()` method before constructing. The pass constructor also checks `HGCamera` properties and `HGSettingParameters` for global enable/disable.
