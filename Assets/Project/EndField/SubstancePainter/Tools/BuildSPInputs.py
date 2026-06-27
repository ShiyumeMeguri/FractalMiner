"""
BuildSPInputs.py  (merged tool)
===============================

Convert Unity character folders (HGRP/CharacterNPR_Fix) into Substance Painter
inputs that work with the ported `HGRP_CharacterNPR_Fix.glsl` shader.

This file is the MERGE of:
    * BuildSPInputs.py            (the full Unity .mat -> SP pipeline)
    * unity_normal_to_substance.py (Unity RG/AG normal -> standard OpenGL normal)
The normal converter is now built in: every `_BumpMap` is rebuilt into a proper
blue-channel normal (no more yellow-green raw maps), and a standalone
`--normal-only` mode replicates the old converter for one-off use.

Usage:
    # Batch: one or more Unity character folders -> SPOutput
    python BuildSPInputs.py <char_folder> [<char_folder> ...] -o <SPOutput> [--flip-green]

    # Standalone normal conversion (old unity_normal_to_substance behavior)
    python BuildSPInputs.py --normal-only <normal.png | folder> [--flip-green]
            [--pattern *_N.png] [--suffix _SP] [-o <outdir>]

What the batch pipeline does (per character):
    * Builds a GUID -> file path index from .meta files ONCE, shared across all
      characters (big speed-up for multi-character runs).
    * Parses every .mat under <character>/Material/.
    * Copies the FBX (and .prefab) model.
    * Splits packed _MetallicGlossMap RGBA into four standard PBR maps:
        R Metal  -> _metallic    G Spec  -> _specularlevel
        B Shadow -> _ao          A Smooth-> _roughness (inverted: 1 - smooth)
    * Splits _BaseMap into _basecolor (RGB) + _opacity (A).
    * NORMAL: rebuilds _BumpMap (Unity RG/AG, Z dropped, looks yellow-green) into a
      standard OpenGL tangent-space normal with reconstructed blue channel,
      matching the shader's decode  X = R*A, Y = G, Z = sqrt(1 - X^2 - Y^2).
      A pre-decoded `_N_Unpack.png` (if present) is preferred and copied as-is.
    * HAIR: splits the packed _SplitNormalMap (RG = diffuse normal, BA = spec normal)
      into two standard OpenGL normals: _normal (-> SP Normal channel, paintable/bakeable)
      and _specnormal (-> shader _SpecNormalMap param). Replaces the old raw-RGBA copy.
    * PARALLAX: exports _ParallaxTex.r as _height (-> SP Height channel, paintable/bakeable).
      Raw bytes kept (shader still sRGB-decodes); _ParallaxTex_ST tiling stays shader-side.
    * Copies _EmissionMap and the HGRP-only aux textures.
    * Dumps all material parameters (Floats/Colors) to params.json.

Requirements:
    pip install pillow numpy
"""

from __future__ import annotations  # so `Path | None` works on Python < 3.10

import argparse
import glob as _glob
import json
import re
import shutil
import sys
from pathlib import Path

try:
    import numpy as np
    from PIL import Image
except ImportError:
    print('ERROR: missing dependencies. Run: pip install pillow numpy')
    sys.exit(1)


# ============================================================================
# Normal map conversion (merged from unity_normal_to_substance.py)
# ----------------------------------------------------------------------------
# Unity stores tangent-space normals in 2 channels (RG, or DXT5nm/AG) and drops
# the blue Z channel, reconstructing it on the GPU. Such a texture looks
# yellow/olive. Substance Painter needs a full RGB normal, so rebuild blue.
#   Unity decode (identical to HGRP_CharacterNPR_Fix.glsl):
#       X = R * A     (UnpackNormalmapRGorAG: packednormal.x *= packednormal.w)
#       Y = G
#       Z = sqrt(1 - X^2 - Y^2)
#   Output:  R = X, G = Y, B = (Z + 1) / 2   (flat = 128,128,255 blue/purple)
# ============================================================================
def reconstruct_normal_arr(arr: np.ndarray, flip_green: bool = False,
                           use_ag: bool = True) -> np.ndarray:
    """arr: HxWx(3|4) uint8 -> HxWx3 uint8 standard OpenGL normal."""
    a = arr.astype(np.float32) / 255.0
    R = a[..., 0]
    G = a[..., 1]
    A = a[..., 3] if a.shape[2] >= 4 else np.ones_like(R)

    X = R * A if use_ag else R          # Unity's x *= w  (A == 1 here -> X = R)
    Y = (1.0 - G) if flip_green else G

    xn = X * 2.0 - 1.0
    yn = Y * 2.0 - 1.0
    zn = np.sqrt(np.clip(1.0 - (xn * xn + yn * yn), 0.0, 1.0))  # rebuild Z

    out = np.empty(a.shape[:2] + (3,), np.float32)
    out[..., 0] = X
    out[..., 1] = Y
    out[..., 2] = (zn + 1.0) * 0.5
    return np.clip(out * 255.0 + 0.5, 0.0, 255.0).astype(np.uint8)


def normal_already_standard(arr: np.ndarray) -> bool:
    """A non-empty blue channel suggests it's already a standard normal map."""
    if arr.shape[2] < 3:
        return False
    b = arr[..., 2].astype(np.float32)
    return b.std() > 8.0 and b.mean() > 100.0


# ----------------------------------------------------------------------------
# GUID index — Unity references textures by 32-hex GUID. We need to resolve.
# ----------------------------------------------------------------------------
_GUID_LINE_RE = re.compile(r'guid:\s*([0-9a-fA-F]{32})')


def build_guid_index(scan_root: Path) -> dict:
    """Walk scan_root for .meta files and build a {guid: real_asset_path} map."""
    index: dict = {}
    n_meta = 0
    for meta in scan_root.rglob('*.meta'):
        n_meta += 1
        try:
            with open(meta, 'r', encoding='utf-8', errors='ignore') as f:
                for _ in range(8):  # guid line is within the first ~5 lines
                    line = f.readline()
                    if not line:
                        break
                    m = _GUID_LINE_RE.search(line)
                    if m:
                        index[m.group(1)] = meta.with_suffix('')
                        break
        except Exception:
            pass
    print(f'  Indexed {len(index)} GUIDs from {n_meta} .meta files under {scan_root}')
    return index


def find_unity_assets_root(start: Path) -> Path:
    """Walk up from start to find the Unity Assets directory; fall back to start."""
    cur = start.resolve()
    while True:
        if cur.name == 'Assets' or (cur / 'Assets').is_dir():
            return cur if cur.name == 'Assets' else (cur / 'Assets')
        if cur.parent == cur:
            break
        cur = cur.parent
    return start


# ----------------------------------------------------------------------------
# Material parsing — Unity's .mat YAML is structured but we use targeted regex.
# ----------------------------------------------------------------------------
_TEX_RE = re.compile(
    r'-\s+(_\w+):\s*\n'
    r'\s+m_Texture:\s*\{fileID:\s*(\d+)(?:,\s*guid:\s*([0-9a-fA-F]{32}))?',
    re.MULTILINE,
)
# 贴图 Tiling/Offset (m_Scale/m_Offset) — EndField_Uber.glsl 的 _FurMap_ST/_BaseMap_ST 等参数需要
_TEX_ST_RE = re.compile(
    r'-\s+(_\w+):\s*\n'
    r'\s+m_Texture:[^\n]*\n'
    r'\s+m_Scale:\s*\{x:\s*(-?[\d.eE+]+),\s*y:\s*(-?[\d.eE+]+)\}\s*\n'
    r'\s+m_Offset:\s*\{x:\s*(-?[\d.eE+]+),\s*y:\s*(-?[\d.eE+]+)\}',
    re.MULTILINE,
)
_FLOAT_RE = re.compile(r'^\s*-\s+(_\w+):\s*(-?[\d.]+)\s*$')
_COLOR_RE = re.compile(
    r'-\s+(_\w+):\s*\{r:\s*(-?[\d.eE+-]+),\s*g:\s*(-?[\d.eE+-]+),'
    r'\s*b:\s*(-?[\d.eE+-]+),\s*a:\s*(-?[\d.eE+-]+)\}'
)


def parse_material(mat_path: Path) -> tuple:
    """Returns (textures{prop:guid}, floats{prop:value}, colors{prop:[r,g,b,a]}, texture_st{prop:[sx,sy,ox,oy]})."""
    text = mat_path.read_text(encoding='utf-8')

    textures: dict = {}
    for m in _TEX_RE.finditer(text):
        prop, _file_id, guid = m.group(1), m.group(2), m.group(3)
        if guid:
            textures[prop] = guid

    texture_st: dict = {}
    for m in _TEX_ST_RE.finditer(text):
        texture_st[m.group(1)] = [
            float(m.group(2)), float(m.group(3)),
            float(m.group(4)), float(m.group(5)),
        ]

    floats: dict = {}
    in_floats = False
    for line in text.splitlines():
        if 'm_Floats:' in line:
            in_floats = True
            continue
        if 'm_Colors:' in line or 'm_Ints:' in line:
            in_floats = False
            continue
        if in_floats:
            m = _FLOAT_RE.match(line)
            if m:
                floats[m.group(1)] = float(m.group(2))

    colors: dict = {}
    for m in _COLOR_RE.finditer(text):
        colors[m.group(1)] = [
            float(m.group(2)), float(m.group(3)),
            float(m.group(4)), float(m.group(5)),
        ]

    return textures, floats, colors, texture_st


# ----------------------------------------------------------------------------
# Texture splitting / copying
# ----------------------------------------------------------------------------
def _open_rgba(path: Path) -> Image.Image:
    return Image.open(path).convert('RGBA')


def split_basemap(src: Path, out_dir: Path, prefix: str) -> None:
    """_BaseMap.rgb -> _basecolor.png ; _BaseMap.a -> _opacity.png"""
    img = _open_rgba(src)
    img.convert('RGB').save(out_dir / f'{prefix}_basecolor.png')
    _, _, _, a = img.split()
    a.save(out_dir / f'{prefix}_opacity.png')


def split_metallic_gloss(src: Path, out_dir: Path, prefix: str) -> None:
    """_MetallicGlossMap RGBA = (Metal, Spec, Shadow, Smooth) -> 4 grayscale PNGs."""
    img = _open_rgba(src)
    arr = np.asarray(img)
    Image.fromarray(arr[:, :, 0], mode='L').save(out_dir / f'{prefix}_metallic.png')
    Image.fromarray(arr[:, :, 1], mode='L').save(out_dir / f'{prefix}_specularlevel.png')
    # Shadow mask -> SP AO 通道 (EndField_Uber.glsl [H1]: shadowMask = getAO(...),
    # 即 ambientocclusion 通道; 旧版导出名 _user0 与 shader 实际读取不符, 已纠正)
    Image.fromarray(arr[:, :, 2], mode='L').save(out_dir / f'{prefix}_ao.png')
    # 清掉旧版导出残留, 避免同目录 _ao/_user0 双份让接线产生歧义
    legacy_user0 = out_dir / f'{prefix}_user0.png'
    if legacy_user0.exists():
        legacy_user0.unlink()
    # Roughness = 1 - Smoothness  (Unity stores smoothness in alpha)
    Image.fromarray((255 - arr[:, :, 3]).astype(np.uint8), mode='L').save(
        out_dir / f'{prefix}_roughness.png'
    )


def build_normal(src: Path, out_dir: Path, prefix: str, suffix: str = 'normal',
                 flip_green: bool = False) -> str:
    """Rebuild a Unity RG/AG normal into a standard OpenGL RGB normal for SP.
    Prefers a pre-decoded `<name>_Unpack.png` if present. Returns a status string."""
    dst = out_dir / f'{prefix}_{suffix}.png'

    unpack = src.with_name(src.stem + '_Unpack' + src.suffix)
    if unpack.exists():
        Image.open(unpack).convert('RGB').save(dst)
        return 'copied _Unpack (already decoded)'

    img = _open_rgba(src)
    arr = np.asarray(img)
    if normal_already_standard(arr):
        img.convert('RGB').save(dst)
        return 'copied (blue channel already present)'

    out = reconstruct_normal_arr(arr, flip_green=flip_green)
    Image.fromarray(out, 'RGB').save(dst)
    return (f'reconstructed blue channel (RG->RGB, flip_green={flip_green}; '
            f'B {arr[..., 2].mean():.0f}->{out[..., 2].mean():.0f})')


def split_hair_normal(src: Path, out_dir: Path, prefix: str,
                      flip_green: bool = False) -> tuple[str, str]:
    """Hair `_SplitNormalMap`: RG = diffuse 法线 XY, BA = spec 法线 XY (均为裸 [0,1], 无 AG)。
    拆成两张标准 OpenGL 法线 (重建蓝通道):
        {prefix}_normal.png      <- RG  (进 SP Normal 通道, 可绘制/可烘焙)
        {prefix}_specnormal.png  <- BA  (进 EndField_Uber.glsl 的 _SpecNormalMap 参数)
    decode 与 shadeHair 逐位一致 (X=R, Y=G, 不乘 alpha; Z 由 XY 重建)。"""
    img = _open_rgba(src)
    arr = np.asarray(img)  # HxWx4 uint8
    zeros = np.zeros_like(arr[..., 0])

    # diffuse: 取 R,G 当 X,Y (use_ag=False — 这里的 A 是 spec.Y, 绝不能当 AG 乘子)
    diffuse_in = np.stack([arr[..., 0], arr[..., 1], zeros], axis=-1)
    diffuse = reconstruct_normal_arr(diffuse_in, flip_green=flip_green, use_ag=False)
    Image.fromarray(diffuse, 'RGB').save(out_dir / f'{prefix}_normal.png')

    # spec: 取 B,A 当 X,Y
    spec_in = np.stack([arr[..., 2], arr[..., 3], zeros], axis=-1)
    spec = reconstruct_normal_arr(spec_in, flip_green=flip_green, use_ag=False)
    Image.fromarray(spec, 'RGB').save(out_dir / f'{prefix}_specnormal.png')

    return 'RG->_normal (SP Normal 通道)', 'BA->_specnormal (_SpecNormalMap 参数)'


def build_parallax_height(src: Path, out_dir: Path, prefix: str) -> str:
    """Standard `_ParallaxTex`: 高度在 .r。导出成 SP Height 通道输入 `{prefix}_height.png`。
    保留"原始 sRGB 字节"(L8, 不做 sRGB->linear) — EndField_Uber.glsl 的 marching 仍在
    着色器端用 SRGBToLinear_Custom 解码 (与 _ParallaxTex 参数版逐位一致; Height 是数据通道,
    SP 导入不做色彩管理, 字节原样进 height_tex.tex)。"""
    img = _open_rgba(src)
    arr = np.asarray(img)
    Image.fromarray(arr[:, :, 0], mode='L').save(out_dir / f'{prefix}_height.png')
    return 'R->_height (SP Height 通道, 原 sRGB 字节; 着色器端解码不变)'


def copy_aux(src: Path, out_dir: Path, prefix: str, suffix: str) -> None:
    out = out_dir / f'{prefix}_{suffix}{src.suffix}'
    shutil.copy(src, out)


def is_normal_prop(prop: str) -> bool:
    """Heuristic: any texture property that holds a tangent-space normal map."""
    pl = prop.lower()
    return 'normal' in pl or 'bump' in pl


def prop_suffix(prop: str) -> str:
    """Derive an output filename suffix from a Unity property name (_HighlightMap -> highlightmap)."""
    return prop.lstrip('_').lower()


# ----------------------------------------------------------------------------
# EndField_Uber.glsl 参数转换 (Unity .mat -> SP shader instance uniforms)
# ----------------------------------------------------------------------------
# CharaPart: 0=Standard 1=Face 2=Eyes 3=Hair 4=Fur 5=Eyebrow 6=VFX 7=OverlayShadow
def infer_chara_part(mat_name: str, textures: dict, floats: dict) -> int:
    n = mat_name.lower()
    # 0) 重定向管线 (Ruri_Character_Uber) 写入的显式 _CharaPartID — 最高真值,
    #    枚举与 EndField_Uber.glsl 一致 (aglina 11 材质实测逐一对上)。
    #    GLSL 把"眼系无 Matcap 路径"细分为 Part5 Eyebrow, Unity 侧统一记 2。
    pid = floats.get('_CharaPartID')
    if pid is not None and 0 <= int(pid) <= 7:
        part = int(pid)
        if part == 2 and '_MatcapTex' not in textures and floats.get('_UseMatcap', 0.0) <= 0.5:
            part = 5
        return part
    # 贴图特征优先 (与 Unity 转换器 variants 同思路, 比名字可靠)
    if '_FurMap' in textures or '_FurDirMap' in textures:
        return 4
    if '_SDFLightmap' in textures:
        return 1
    if '_MatcapTex' in textures:
        return 2
    if '_SplitNormalMap' in textures:
        return 3
    if '_MaskTex' in textures or '_DisturbTex1' in textures or '_BlendTex' in textures:
        return 6
    # OverlayShadow: 名字可靠 (放在 hair/eye 名字回退之前 — hairshadow 含 'hair');
    # 浮点残留只在"无任何受光材质证据"时可信 — OverlayShadow_Fix 只有 _BaseMap,
    # 带 RMOS/法线/自发光的必不是它 (wpn 实测残留 _UseGrayAsAlpha=1 但有完整 RMOS)。
    if 'overlayshadow' in n or 'eyewhiteshadow' in n or 'hairshadow' in n:
        return 7
    lit_evidence = ('_MetallicGlossMap' in textures or '_BumpMap' in textures
                    or '_EmissionMap' in textures)
    if '_UseGrayAsAlpha' in floats and not lit_evidence:
        return 7
    # 名字回退
    if 'vfx' in n or n.startswith('m_fx_') or '_fx_' in n:
        return 6
    if 'fur' in n:
        return 4
    if 'brow' in n:
        return 5
    if 'eye' in n or 'iris' in n:
        return 2
    if 'hair' in n:
        return 3
    if 'face' in n or 'skin' in n:
        return 1
    if 'body' in n and '_MetallicGlossMap' not in textures:
        return 1  # Endfield 身体皮肤 (无 RMOS) 走 Skin 着色
    return 0


# 标量/开关默认值 (来自各 HGRP_*_Fix.shader Properties; .mat 缺项时回退)。
# 只列对结果有影响的; 不在表里的属性按 0 处理。
EF_FLOAT_DEFAULTS = {
    '_BumpScale': 1.0, '_Metallic': 0.0, '_Specular': 1.0, '_Smoothness': 0.5,
    '_ShadowColorBrightness': 0.5, '_ShadowColorSaturation': 1.0,
    '_SpecRampIridescentMode': 0.0, '_AlphaPremultiply': 0.0,
    '_EmissionBrightness': 1.0, '_CubemapIntensity': 1.0,
    '_SkinRimOffScale': 0.5, '_FaceRimOffScale': 1.0,
    '_EmotionIndex': 0.0, '_EmotionBlend': 1.0,
    '_MatcapNormalScale': 1.0, '_ParallaxScale': 0.3,
    '_ParallaxMarchNum': 2.0,
    '_SpecBumpScale': 1.0,
    '_AnisotropyValue': 0.7, '_AnisotropyValue2': 0.712, '_AnisotropyDirX': 0.0,
    '_AnisotropyIntensity': 2.0, '_AnisotropyEdgeFade': 3.0, '_AnisotropyRange2': 0.5,
    '_StrokeScale': 1.0, '_UseLineMap': 1.0, '_LineAmount': 300.0,
    '_LineValue': 0.58, '_LineRange': 0.93, '_LineIntensity': 0.3, '_LineSaturation': 1.7,
    '_FurLengthIntensity': 0.7, '_FurCutoffStart': 0.0, '_FurCutoffEnd': 1.0,
    '_FurAO': 1.0, '_FurEdgeFade': 0.4, '_FurTTIntensity': 0.0,
    '_FurDirMapEnable': 0.0, '_FurSharpen': 0.0, '_FurNoise': 0.0, '_FurDyeIntensity': 1.0,
    '_VFXColorIntensity': 1.0, '_VFXColorAlpha': 1.0, '_UseVFXMainTexAsAlpha': 0.0,
    '_VFXSpecialBlendTexRForDisturb': 1.0, '_VFXFresnelBias': 0.0,
    '_VFXFresnelAffectOpacity': 1.0, '_VFXFresnelPower': 1.0, '_VFXFresnelFlip': 0.0,
    '_SpecialDissolveScheduleOffset': 0.0,
    '_EnableVFXColorAdjustment': 0.0, '_ColorAdjustmentBrightness': 1.0,
    '_ColorAdjustmentSaturation': 1.0, '_ColorAdjustmentContrast': 1.0,
    '_ColorAdjustmentRimWidth': 0.35, '_ColorAdjustmentRimIntensity': 4.0,
    '_UseGrayAsAlpha': 1.0,
    '_ClearCoatSmoothness': 0.95, '_ClearCoatMetallic': 0.0, '_ClearCoatNormalMode': 0.0,
    '_PantyhoseSpecularInt': 0.0, '_PantyhoseSpecularValue': 0.0, '_PantyhoseAnisotropyDirection': 0.0,
    # VFX part (HGRP_CharacterNPR_VFX_Fix)
    '_BlendMode': 1.0, '_TintColorIntensity': 1.0, '_TintColorAlpha': 1.0,
    '_IgnorePostExposure': 1.0, '_UseMainTexAsAlpha': 1.0, '_MainTexUseDisturb': 1.0,
    '_MainTexUVRotate': 0.0, '_UseMaskTexAsAlpha': 1.0, '_MaskTexUseDisturb': 0.0,
    '_MaskTexUVRotate': 0.0, '_BlendTexUseDisturb': 0.0, '_BlendTexUVRotate': 0.0,
    '_DisturbUVRotate1': 0.0, '_Bi_Disturb': 0.0, '_DisturbTex1Normal': 0.0,
    '_DisturbUIntensity1': 0.0, '_DisturbVIntensity1': 0.0,
    '_NormalMapUVRotate': 0.0, '_NormalScale': 1.0, '_NormalMapUseDisturb': 1.0,
    '_FresnelBias': 0.0, '_FresnelAffectOpacity': 1.0, '_FresnelPower': 1.0,
    '_FresnelFlip': 0.001, '_UseNearCameraFade': 0.0,
    '_NearCameraFadeDistanceStart': 0.001, '_NearCameraFadeDistanceEnd': 10.0,
    '_NearCameraFadeDistanceEnd2': 100.0, '_NearCameraFadeDistanceStart2': 120.0,
}

# 部位特化的 PBR 标量默认 (HGRP 各变体 Properties 不同)
EF_PART_PBR_DEFAULTS = {
    0: {'_Metallic': 0.839, '_Specular': 1.0, '_Smoothness': 0.406},
    1: {'_Metallic': 0.0,   '_Specular': 1.0, '_Smoothness': 0.5},
    2: {'_Metallic': 0.0,   '_Specular': 1.0, '_Smoothness': 0.5},
    3: {'_Metallic': 0.0,   '_Specular': 1.0, '_Smoothness': 1.0},
    4: {'_Metallic': 0.0,   '_Specular': 0.0, '_Smoothness': 0.1},
    5: {'_Metallic': 0.0,   '_Specular': 1.0, '_Smoothness': 0.5},
}

# 颜色/向量参数 (同名直拷, .mat 的 m_Colors 既存颜色也存 Vector)
EF_COLOR_IDENTITY = [
    '_BaseColor', '_EmissionColor', '_SDFRimColor', '_HighlightMapVector',
    '_MatcapColor', '_EyeHighLightColor', '_EyeScatteringColor',
    '_AnisotropyColor2', '_HairDarkenParams',
    '_PantyhoseColor', '_ClearCoatColor', '_ParallaxColor',
    '_VFXColor', '_VFXBlendTint', '_VFXSpecialParam', '_VFXFresnelColor',
    '_ColorAdjustmentColorBlend', '_ColorAdjustmentRimColor',
    '_TintColor', '_BlendTint', '_FresnelColor',
    '_MainTexUVSpeed', '_MaskTexUVSpeed', '_BlendTexUVSpeed',
    '_DisturbUVSpeed1', '_NormalMapUVSpeed',
    '_CharacterParams0', '_CharacterParams1', '_CharacterParams2', '_CharacterParams3',
    '_CharacterParams4', '_CharacterParams5', '_CharacterParams6', '_CharacterParams7',
    '_CharacterParams8', '_CharacterParams9', '_CharacterParams10', '_CharacterParams11',
    '_CharacterParams12', '_CharacterParams13', '_CharacterParams14', '_CharacterParams15',
    '_EnvironmentGlobalParams0', '_ExposureParams',
]

# 浮点参数 (同名直拷)
EF_FLOAT_IDENTITY = [
    '_BumpScale', '_Metallic', '_Specular', '_Smoothness',
    '_ShadowColorBrightness', '_ShadowColorSaturation', '_SpecRampIridescentMode',
    '_AlphaPremultiply', '_EmissionBrightness', '_CubemapIntensity', '_BackFaceNormalFlip',
    '_SkinRimOffScale', '_FaceRimOffScale', '_EmotionBlend',
    '_MatcapNormalScale', '_SpecBumpScale',
    '_ParallaxMarchNum', '_ParallaxScale',
    '_AnisotropyValue', '_AnisotropyValue2', '_AnisotropyDirX', '_AnisotropyIntensity',
    '_AnisotropyEdgeFade', '_AnisotropyRange2', '_StrokeScale',
    '_UseLineMap', '_LineAmount', '_LineValue', '_LineRange', '_LineIntensity', '_LineSaturation',
    '_FurLengthIntensity', '_FurCutoffStart', '_FurCutoffEnd', '_FurAO', '_FurEdgeFade',
    '_FurTTIntensity', '_FurDirMapEnable', '_FurSharpen', '_FurNoise', '_FurDyeIntensity',
    '_VFXColorIntensity', '_VFXColorAlpha', '_UseVFXMainTexAsAlpha',
    '_VFXSpecialBlendTexRForDisturb', '_VFXFresnelBias', '_VFXFresnelAffectOpacity',
    '_VFXFresnelPower', '_VFXFresnelFlip', '_SpecialDissolveScheduleOffset',
    '_EnableVFXColorAdjustment', '_ColorAdjustmentBrightness', '_ColorAdjustmentSaturation',
    '_ColorAdjustmentContrast', '_ColorAdjustmentRimWidth', '_ColorAdjustmentRimIntensity',
    '_UseGrayAsAlpha',
    '_ClearCoatSmoothness', '_ClearCoatMetallic', '_ClearCoatNormalMode',
    '_PantyhoseSpecularInt', '_PantyhoseSpecularValue', '_PantyhoseAnisotropyDirection',
    # VFX part
    '_BlendMode', '_TintColorIntensity', '_TintColorAlpha', '_IgnorePostExposure',
    '_UseMainTexAsAlpha', '_MainTexUseDisturb', '_MainTexUVRotate',
    '_UseMaskTexAsAlpha', '_MaskTexUseDisturb', '_MaskTexUVRotate',
    '_BlendTexUseDisturb', '_BlendTexUVRotate',
    '_DisturbUVRotate1', '_Bi_Disturb', '_DisturbTex1Normal',
    '_DisturbUIntensity1', '_DisturbVIntensity1',
    '_NormalMapUVRotate', '_NormalScale', '_NormalMapUseDisturb',
    '_FresnelBias', '_FresnelAffectOpacity', '_FresnelPower', '_FresnelFlip',
    '_UseNearCameraFade', '_NearCameraFadeDistanceStart', '_NearCameraFadeDistanceEnd',
    '_NearCameraFadeDistanceEnd2', '_NearCameraFadeDistanceStart2',
]

# 开关: SP uniform <- Unity float (缺省 0=off; HGRP 没有该 prop 的变体本来就关)
EF_BOOL_MAP = {
    'u_UseBumpMap':          '_UseBumpMap',
    'u_UseMetallicGlossMap': '_UseMetallicGlossMap',
    'u_UseDiffRamp':         '_UseDiffRampMap',
    'u_UseSpecRamp':         '_UseSpecRampMap',
    'u_UseShadowLut':        '_UseShadowLutTex',
    'u_UseEmission':         '_UseEmission',
    'u_ClearCoat':           '_ClearCoat',
    'u_Pantyhose':           '_Pantyhose',
    'u_UseParallax':         '_UseParallax',
    'u_UseSDFLightmap':      '_UseSDFLightmap',
    'u_UseEmotionMap':       '_UseEmotionMap',
    'u_FaceHighlightMap':    '_FaceHighlightMap',
    'u_UseMatcap':           '_UseMatcap',
    'u_EyeHighLight':        '_EyeHighLight',
    'u_UseSpecBumpMap':      '_UseSpecBumpMap',
    'u_StrokeOn':            '_StrokeOn',
    'u_SpecularLine':        '_SpecularLine',
    'u_FurDyeEnable':        '_FurDyeEnable',
    'u_EnableCharacterVFX':  '_EnableCharacterVFX',
    # _FBXRotationFix 不映射: 游戏运行时需要它修对象轴, 但 SP 网格已烘焙世界空间无需,
    # 且开了会把发丝各向异性轴转错 90° → 刘海高光环消失。SP 端恒为关 (shader 已删该开关)。
    'u_VFXUseMask':          '_UseMask',
    'u_VFXUseBlend':         '_UseBlend',
    'u_VFXUseDisturb':       '_UseDisturb',
    'u_VFXUseFresnel':       '_UseFresnel',
    'u_VFXEnableNormalMap':  '_EnableNormalMap',
}

# 贴图 ST: SP vec4 uniform <- Unity 贴图的 Tiling/Offset
EF_ST_MAP = {
    '_BaseMap_ST':            '_BaseMap',
    '_StrokeMap_ST':          '_StrokeMap',
    '_LineMap_ST':            '_LineMap',
    '_ParallaxTex_ST':        '_ParallaxTex',
    '_FurMap_ST':             '_FurMap',
    '_FurDyeMap_ST':          '_FurDyeMap',
    '_VFXSpecialMainTex_ST':  '_VFXSpecialMainTex',
    '_VFXSpecialBlendTex_ST': '_VFXSpecialBlendTex',
    '_VFXMainTex_ST':         '_MainTex',
    '_VFXMaskTex_ST':         '_MaskTex',
    '_VFXBlendTex_ST':        '_BlendTex',
    '_VFXDisturbTex_ST':      '_DisturbTex1',
    '_VFXNormalMap_ST':       '_NormalMap',
}

# 贴图参数指派: Unity 贴图 prop -> (EndField_Uber sampler uniform, 导出文件 suffix)
EF_TEX_PARAM_MAP = {
    '_DiffRampMap':        ('_RampMap',            'difframp'),
    '_SpecRampMap':        ('_SpecRampMap',        'specramp'),
    '_ShadowLutTex':       ('_ShadowLutTex',       'shadowlut'),
    '_SDFLightmap':        ('_SDFLightmap',        'sdflightmap'),
    '_SDFMask':            ('_SDFMask',            'sdfmask'),
    '_EmotionMap':         ('_EmotionMap',         'emotionmap'),
    '_HighlightMap':       ('_HighlightMap',       'highlightmap'),
    '_MatcapTex':          ('_MatcapTex',          'matcaptex'),
    '_SplitNormalMap':     ('_SpecNormalMap',      'specnormal'),  # diffuse(RG) 走 Normal 通道; 此处只接 spec(BA)
    '_StrokeMap':          ('_StrokeMap',          'strokemap'),
    '_LineMap':            ('_LineMap',            'linemap'),
    '_FurMap':             ('_FurMap',             'furmap'),
    '_FurDirMap':          ('_FurDirMap',          'furdirmap'),
    '_FurDyeMap':          ('_FurDyeMap',          'furdyemap'),
    '_VFXSpecialMainTex':  ('_VFXSpecialMainTex',  'vfxspecialmaintex'),
    '_VFXSpecialBlendTex': ('_VFXSpecialBlendTex', 'vfxspecialblendtex'),
    '_MainTex':            ('_VFXMainTex',         'maintex'),
    '_MaskTex':            ('_VFXMaskTex',         'masktex'),
    '_BlendTex':           ('_VFXBlendTex',        'blendtex'),
    '_DisturbTex1':        ('_VFXDisturbTex',      'disturbtex1'),
    '_NormalMap':          ('_VFXNormalMap',       'normalmap'),
}

# 引擎通道文件指派 (手动导入 SP 通道; 插件不自动建填充层)
EF_CHANNEL_FILES = [
    ('basecolor',     'basecolor'),
    ('opacity',       'opacity'),
    ('metallic',      'metallic'),
    ('specularlevel', 'specularlevel'),
    ('roughness',     'roughness'),
    ('ambientocclusion', 'ao'),
    ('height',        'height'),   # Standard 视差高度 (原 _ParallaxTex)
    ('normal',        'normal'),
    ('emissive',      'emissive'),
    ('user1',         'user1'),         # ClearCoat Mask (Standard)
]


# Face SDF 脸基轴 (SP 世界空间)。FaceForward 强制 (0,0,0): 实测该网格上轴非世界 Y
# (疑 Z-up FBX), 任何真实前向都让 SDF 投错水平面 → 正反都糊; (0,0,0) 关前后扫描,
# 静态居中但不出错 (用户决定: 总比错误好)。定准真实上/前轴后再恢复非零值。
SP_FACE_FORWARD_DEFAULT = [0.0, 0.0, 0.0]
SP_FACE_RIGHT_DEFAULT = [1.0, 0.0, 0.0]


def _unity_dir_to_sp(v, default):
    """Unity(.mat, Z-forward 左手) 方向向量 → SP/OpenGL(Z-backward 右手): 翻 Z。
    缺省/全零回退到 SP 世界空间默认 (default 为 [x,y,z])。"""
    if not v:
        return list(default)
    try:
        x, y, z = float(v[0]), float(v[1]), float(v[2])
    except (TypeError, ValueError, IndexError):
        return list(default)
    if abs(x) < 1e-8 and abs(y) < 1e-8 and abs(z) < 1e-8:
        return list(default)
    return [x, y, -z]


def build_endfield_entry(mat_name: str, mat_out: Path, textures: dict,
                         floats: dict, colors: dict, texture_st: dict,
                         exported_props: set | None = None) -> dict:
    """把一份解析好的 .mat 转成 EndField_Uber.glsl 的 shader instance 参数表。
    exported_props: 实际导出成功的贴图属性集 — 部位推断只信文件证据
    (.mat 里残留其他 shader 的脏 GUID 不可信, 与插件侧 guess_part 同口径)。"""
    evidence = textures if exported_props is None else {
        p: g for p, g in textures.items() if p in exported_props}
    part = infer_chara_part(mat_name, evidence, floats)

    def f(prop: str) -> float:
        default = EF_PART_PBR_DEFAULTS.get(part, {}).get(prop)
        if default is None:
            default = EF_FLOAT_DEFAULTS.get(prop, 0.0)
        return float(floats.get(prop, default))

    uniforms: dict = {'u_CharaPart': part}

    # ---- 开关 ----
    for sp_name, unity_name in EF_BOOL_MAP.items():
        uniforms[sp_name] = bool(floats.get(unity_name, 0.0) > 0.5)
    # 半透明: Fur 必透明; 其他看 _SurfaceType
    uniforms['u_AlphaBlend'] = (part == 4) or (floats.get('_SurfaceType', 0.0) > 0.5)

    # ---- 浮点 ----
    for prop in EF_FLOAT_IDENTITY:
        uniforms[prop] = f(prop)
    # Alpha clip: 任一 alphatest 开关激活才生效
    alpha_test = floats.get('_AlphaClip', 0.0) > 0.5 or floats.get('_EnableAlphaTest', 0.0) > 0.5
    uniforms['f_AlphaClip'] = float(floats.get('_AlphaClipThreshold', 0.5)) if alpha_test else 0.0
    # Eyes 的视差强度是独立 uniform (默认域 0~0.15, 与 Standard 的 _ParallaxScale 不同)
    if part in (2, 5):
        uniforms['_EyeParallaxScale'] = float(floats.get('_ParallaxScale', 0.03))
    # 表情序号是 int
    uniforms['_EmotionIndex'] = int(f('_EmotionIndex'))

    # ---- 颜色 / 向量 ----
    for prop in EF_COLOR_IDENTITY:
        if prop in colors:
            uniforms[prop] = [float(x) for x in colors[prop]]
    # vec3 脸基轴 (仅 Face=part 1 消费)。FaceForward 强制 (0,0,0) 关前后 SDF 扫描 (见常量注释);
    # FaceRight 仍按 Unity→SP 翻 Z 转换 (这两者解耦, Right 用于左右镜像, 给 (1,0,0))。
    if part == 1:
        uniforms['_FaceForward'] = list(SP_FACE_FORWARD_DEFAULT)
        uniforms['_FaceRight'] = _unity_dir_to_sp(colors.get('_FaceRight'), SP_FACE_RIGHT_DEFAULT)

    # ---- 贴图 ST ----
    for sp_name, unity_tex in EF_ST_MAP.items():
        if unity_tex in texture_st:
            uniforms[sp_name] = [float(x) for x in texture_st[unity_tex]]

    # ---- 贴图参数指派 (导出文件 -> sampler uniform) ----
    def _rel(p: Path) -> str:
        return str(p.relative_to(mat_out.parent.parent)).replace('\\', '/')

    texture_params: dict = {}
    prefix = mat_out.name
    for unity_tex, (sp_sampler, suffix) in EF_TEX_PARAM_MAP.items():
        if unity_tex not in textures:
            continue
        hits = sorted(mat_out.glob(f'{prefix}_{suffix}.*'))
        if hits:
            texture_params[sp_sampler] = _rel(hits[0])

    # ---- 引擎通道文件 (人工导入指引) ----
    channel_files: dict = {}
    for channel, suffix in EF_CHANNEL_FILES:
        hits = sorted(mat_out.glob(f'{prefix}_{suffix}.*'))
        if not hits and suffix == 'ao':
            # 旧版导出名为 _user0 (shadow mask), 兼容已存在的输出
            hits = sorted(mat_out.glob(f'{prefix}_user0.*'))
        if hits:
            channel_files[channel] = _rel(hits[0])

    return {
        'part': part,
        'uniforms': uniforms,
        'texture_params': texture_params,
        'channel_files': channel_files,
    }


# ----------------------------------------------------------------------------
# Single-material pipeline
# ----------------------------------------------------------------------------
AUX_TEXTURE_MAP = {
    '_DiffRampMap':   'difframp',
    '_SpecRampMap':   'specramp',
    '_ShadowLutTex':  'shadowlut',
    '_OutlineMask':   'outlinemask',
    '_ClearCoatMask': 'user1',         # clearcoat -> SP user1
}


def process_material(mat_file: Path, guid_index: dict, out_root: Path,
                     flip_green: bool = False) -> dict:
    """处理单个 .mat; 返回 EndField_Uber 的 shader instance 参数表 (entry)。"""
    print(f'\n[material] {mat_file.name}')
    textures, floats, colors, texture_st = parse_material(mat_file)

    mat_out = out_root / 'Materials' / mat_file.stem
    mat_out.mkdir(parents=True, exist_ok=True)
    prefix = mat_file.stem

    def resolve(prop: str) -> Path | None:
        guid = textures.get(prop)
        if not guid:
            return None
        path = guid_index.get(guid)
        if not path:
            print(f'    WARN: GUID for {prop} ({guid}) not found in index')
            return None
        if not path.exists():
            print(f'    WARN: resolved path missing on disk: {path}')
            return None
        return path

    done: set = set()

    # --- BaseMap (RGB+A -> basecolor + opacity) ---
    p = resolve('_BaseMap')
    if p:
        split_basemap(p, mat_out, prefix)
        done.add('_BaseMap')
        print(f'    _BaseMap   -> {prefix}_basecolor.png + {prefix}_opacity.png')

    # --- MetallicGlossMap (split into 4 PBR channels) ---
    p = resolve('_MetallicGlossMap')
    if p:
        split_metallic_gloss(p, mat_out, prefix)
        done.add('_MetallicGlossMap')
        print(f'    _MetallicGlossMap -> _metallic + _specularlevel + _ao (shadow) + _roughness')

    # --- EmissionMap ---
    p = resolve('_EmissionMap')
    if p:
        copy_aux(p, mat_out, prefix, 'emissive')
        done.add('_EmissionMap')
        print(f'    _EmissionMap -> {prefix}_emissive')

    # --- _SplitNormalMap: RG=diffuse 法线 XY, BA=spec 法线 XY (裸 [0,1]) — 拆成两张标准
    #     OpenGL 法线: diffuse 进 SP Normal 通道 (可绘制/可烘焙), spec 进 _SpecNormalMap 参数。
    #     decode 与 EndField_Uber.glsl shadeHair 逐位一致。仍把 _SplitNormalMap 记进 done —
    #     部位推断 infer_chara_part 靠 .mat 里的它判 Hair, 且防后面的法线泛化循环重复处理。
    p = resolve('_SplitNormalMap')
    if p:
        diff_status, spec_status = split_hair_normal(p, mat_out, prefix, flip_green=flip_green)
        done.add('_SplitNormalMap')
        print(f'    _SplitNormalMap -> {prefix}_normal.png + {prefix}_specnormal.png   [{diff_status}; {spec_status}]')

    # --- _ParallaxTex: Standard 视差高度 (.r) — 迁入 SP Height 通道 (可绘制/可烘焙)。
    #     _ParallaxTex_ST 平铺仍由着色器 marching 处理 (调查: 156 材质里仅 lastrite 2 件 4x 平铺)。
    p = resolve('_ParallaxTex')
    if p:
        status = build_parallax_height(p, mat_out, prefix)
        done.add('_ParallaxTex')
        print(f'    _ParallaxTex -> {prefix}_height.png   [{status}]')

    # --- ALL normal-type maps (_BumpMap, ...) -> reconstruct blue ---
    for prop in list(textures):
        if prop in done or not is_normal_prop(prop):
            continue
        p = resolve(prop)
        if p:
            suffix = 'normal' if prop == '_BumpMap' else prop_suffix(prop)
            status = build_normal(p, mat_out, prefix, suffix=suffix, flip_green=flip_green)
            done.add(prop)
            print(f'    {prop} -> {prefix}_{suffix}.png   [{status}]')

    # --- Everything else: export EVERY remaining mask/texture (nothing dropped) ---
    for prop in sorted(textures):
        if prop in done:
            continue
        p = resolve(prop)
        if p:
            suffix = AUX_TEXTURE_MAP.get(prop, prop_suffix(prop))
            copy_aux(p, mat_out, prefix, suffix)
            done.add(prop)
            print(f'    {prop} -> {prefix}_{suffix}')

    # --- Material parameters -> EndField_Uber.glsl shader instance 参数表 ---
    entry = build_endfield_entry(mat_file.stem, mat_out, textures, floats, colors,
                                 texture_st, exported_props=done)
    params = {
        'source_mat':  str(mat_file),
        'textures':    textures,
        'texture_st':  texture_st,
        'floats':      floats,
        'colors':      colors,
        # EndField_Uber.glsl 的精确 uniform 名 (SP_ApplyEndfieldParams 插件直接消费)
        'endfield_uber': entry,
    }
    with open(mat_out / 'params.json', 'w', encoding='utf-8') as f:
        json.dump(params, f, indent=2, ensure_ascii=False)
    part_names = {0: 'Standard', 1: 'Face', 2: 'Eyes', 3: 'Hair', 4: 'Fur',
                  5: 'Eyebrow', 6: 'VFX', 7: 'OverlayShadow'}
    print(f"    params.json saved  [part={entry['part']} {part_names.get(entry['part'])}]"
          f"  texture_params={len(entry['texture_params'])}")
    return entry


def process_character(char_dir: Path, guid_index: dict, out_base: Path,
                      flip_green: bool = False) -> bool:
    """Process one Unity character folder -> out_base/<char_name>/. Returns success."""
    print(f'\n========== CHARACTER: {char_dir.name} ==========')
    if not char_dir.is_dir():
        print(f'  ERROR: not a folder: {char_dir}')
        return False

    out_root = (out_base / char_dir.name).resolve()
    out_root.mkdir(parents=True, exist_ok=True)
    print(f'  Output: {out_root}')

    # Copy FBX (and prefab if present)
    for fbx in char_dir.glob('*.fbx'):
        shutil.copy(fbx, out_root / fbx.name)
        print(f'  Copied model: {fbx.name}')
    for prefab in char_dir.glob('*.prefab'):
        shutil.copy(prefab, out_root / prefab.name)

    mat_dir = char_dir / 'Material'
    if not mat_dir.is_dir():
        print('  ERROR: no Material/ subfolder, skipping')
        return False
    mats = sorted(mat_dir.glob('*.mat'))
    if not mats:
        print('  ERROR: no .mat files, skipping')
        return False
    print(f'  Found {len(mats)} material(s)')
    shader_params: dict = {}
    for mat in mats:
        try:
            entry = process_material(mat, guid_index, out_root, flip_green=flip_green)
            if entry:
                shader_params[mat.stem] = entry
        except Exception as e:
            print(f'  [FAILED] {mat.name}: {e}')

    # 汇总: 角色级 SPShaderParams.json — SP_ApplyEndfieldParams 插件按
    # "shader instance 名 == 材质名 (texture set 名)" 批量应用。
    if shader_params:
        out_file = out_root / 'SPShaderParams.json'
        with open(out_file, 'w', encoding='utf-8') as f:
            json.dump(shader_params, f, indent=2, ensure_ascii=False)
        print(f'\n  SPShaderParams.json saved ({len(shader_params)} material(s)) -> {out_file}')
        print('  在 SP 里: Python 控制台运行 SP_ApplyEndfieldParams.apply(r"%s")' % out_file)
    return True


# ----------------------------------------------------------------------------
# Standalone normal-only mode (old unity_normal_to_substance.py behavior)
# ----------------------------------------------------------------------------
def _normal_out_name(path: Path, suffix: str, outdir: Path | None) -> Path:
    d = outdir if outdir else path.parent
    return d / (path.stem + suffix + path.suffix)


def run_normal_only(inputs, pattern: str, suffix: str, outdir: Path | None,
                    flip_green: bool, use_ag: bool, force: bool) -> None:
    targets: list = []
    for item in inputs:
        p = Path(item)
        if p.is_dir():
            targets += [Path(x) for x in sorted(_glob.glob(str(p / pattern)))]
        elif p.is_file():
            targets.append(p)
        else:
            print(f'  not found: {p}')
    if not targets:
        print('No normal maps to convert.')
        return
    if outdir:
        outdir.mkdir(parents=True, exist_ok=True)
    print(f'Normal-only: {len(targets)} file(s)  (use_ag={use_ag}, flip_green={flip_green})')
    done = 0
    for p in targets:
        try:
            img = _open_rgba(p)
            arr = np.asarray(img)
            if normal_already_standard(arr) and not force:
                print(f'  [skip] {p.name} (already standard; use --force)')
                continue
            out = reconstruct_normal_arr(arr, flip_green=flip_green, use_ag=use_ag)
            dst = _normal_out_name(p, suffix, outdir)
            Image.fromarray(out, 'RGB').save(dst)
            print(f'  [ok] {p.name} -> {dst.name} (B {arr[...,2].mean():.0f}->{out[...,2].mean():.0f})')
            done += 1
        except Exception as e:
            print(f'  [fail] {p.name}: {e}')
    print(f'Done: {done}/{len(targets)}')


# ----------------------------------------------------------------------------
# Main
# ----------------------------------------------------------------------------
def main():
    ap = argparse.ArgumentParser(
        description='Build SP inputs from Unity HGRP character folders '
                    '(with built-in Unity->OpenGL normal conversion).')
    ap.add_argument('inputs', type=str, nargs='+',
                    help='One or more Unity character folders '
                         '(or normal files/folders in --normal-only mode).')
    ap.add_argument('-o', '--output', type=Path, default=None,
                    help='Output root (default: <script_parent>/../SPOutput).')
    ap.add_argument('--scan-root', type=Path, default=None,
                    help='GUID scan root (default: auto-detect Unity Assets root).')
    ap.add_argument('--flip-green', action='store_true',
                    help='Flip normal green channel (OpenGL<->DirectX) for all normals.')
    # normal-only mode
    ap.add_argument('--normal-only', action='store_true',
                    help='Standalone: just convert normal map(s), skip the .mat pipeline.')
    ap.add_argument('--pattern', default='*_N.png',
                    help='[--normal-only] glob pattern when input is a folder (default *_N.png).')
    ap.add_argument('--suffix', default='_SP',
                    help='[--normal-only] output filename suffix (default _SP).')
    ap.add_argument('--no-ag', action='store_true',
                    help='[--normal-only] do NOT apply X=R*A (pure RG map with non-1 alpha).')
    ap.add_argument('--force', action='store_true',
                    help='[--normal-only] convert even if blue channel already present.')
    args = ap.parse_args()

    # ---- Standalone normal-only mode ----
    if args.normal_only:
        run_normal_only(args.inputs, args.pattern, args.suffix, args.output,
                        flip_green=args.flip_green, use_ag=not args.no_ag,
                        force=args.force)
        return

    # ---- Full pipeline (batch) ----
    char_dirs = [Path(p).resolve() for p in args.inputs]
    missing = [d for d in char_dirs if not d.is_dir()]
    for d in missing:
        print(f'WARN: not a folder, skipping: {d}')
    char_dirs = [d for d in char_dirs if d.is_dir()]
    if not char_dirs:
        print('ERROR: no valid character folders.')
        sys.exit(1)

    # Output base
    if args.output:
        out_base = args.output.resolve()
    else:
        out_base = (Path(__file__).resolve().parent.parent / 'SPOutput').resolve()
    out_base.mkdir(parents=True, exist_ok=True)
    print(f'Output base: {out_base}')

    # Build GUID index ONCE (shared across all characters)
    scan_root: Path = (args.scan_root or find_unity_assets_root(char_dirs[0])).resolve()
    print(f'Scanning Unity assets at: {scan_root}')
    guid_index = build_guid_index(scan_root)
    if not guid_index:
        print('WARN: empty GUID index — texture resolution will fail.')

    ok = 0
    for char_dir in char_dirs:
        if process_character(char_dir, guid_index, out_base, flip_green=args.flip_green):
            ok += 1

    # Save the shared GUID index once (debug)
    with open(out_base / 'GUID_index.json', 'w', encoding='utf-8') as f:
        json.dump({k: str(v) for k, v in guid_index.items()},
                  f, indent=2, ensure_ascii=False)

    print(f'\nDone. {ok}/{len(char_dirs)} character(s) processed. Output: {out_base}')


if __name__ == '__main__':
    main()
