# -*- coding: utf-8 -*-
"""
endfield_auto_textures.py — Substance Painter 插件 (v3)
=======================================================

自动接线 BuildSPInputs.py 的输出 (SPOutput):

  * 空场景: 选角色文件夹 → 用 .fbx 新建工程 (OpenGL 法线) → 就绪后自动接线。
  * 已有工程: 自动定位同名材质最多的角色文件夹 (找不到弹窗选) → 同名材质接线。

每个 Texture Set:
  1. 通道贴图 → "EF_AutoTex" 填充图层 (basecolor/opacity/metallic/specularlevel/
     roughness/normal/emissive + ao(旧名 user0)→AO + user1→User1)。
  2. shader sampler 参数贴图导入 Project 资源架。
  3. [v3] Shader 阶段 — 全自动, 不再要求任何手动步骤:
       a. 资源库搜索 "EndField_Uber"; 找不到则直接从 SHADER_GLSL_PATH 自动导入。
       b. alg.shaders.shaderInstancesToObject() 快照 (实测格式:
          {"format":{...}, "shaders":{实例名:{...}}, "texturesets":{材质球名:{"shader":实例名}}}),
          为每个材质球补建同名实例并把材质球绑定到它, shaderInstancesFromObject 应用
          (官方文档: "Painter will create the missing instances and will assign
          the instances to the good texture sets")。
       c. 逐实例 updateShaderInstance 切到 EndField_Uber, setParameters 写入全部
          参数 (u_CharaPart / 开关 / 标量 / 向量 / *_ST / sampler 贴图 url)。
       d. 重新快照验证每个材质球: 绑定实例==同名 且 shader==EndField_Uber, 报告打 ✓/✗。
     全流程幂等 — 任何一步失败 (工程没就绪/资源占用等) 再点一次菜单即可补齐。
  4. 参数来源: 优先 params.json["endfield_uber"]["uniforms"] (BuildSPInputs 预计算的
     精确 uniform 表, 含部位特化默认值); 旧版导出没有该字段时退回插件自行推断
     ("文件证据优先", 浮点残留兜底)。

放置: Documents/Adobe/Adobe Substance 3D Painter/python/plugins/
"""

import os
import json
import shutil
import traceback

try:
    from PySide6 import QtWidgets  # SP 10.1+
except ImportError:
    from PySide2 import QtWidgets  # 旧版 SP

import substance_painter.ui
import substance_painter.logging
import substance_painter.project
import substance_painter.textureset
import substance_painter.resource
import substance_painter.layerstack
import substance_painter.source
import substance_painter.event

# ----------------------------------------------------------------------------
# 配置
# ----------------------------------------------------------------------------
SPOUTPUT_DIR = r"D:\Ruri\00.Model\Project\SubstancePaint\SPOutput"
FILL_LAYER_NAME = "EF_AutoTex"
SHADER_NAME = "EndField_Uber"
# 资源库找不到 EndField_Uber 时, 从这里自动导入 (session resource)
SHADER_GLSL_PATH = r"D:\Ruri\00.Model\Project\SubstancePaint\Shader\EndField_Uber.glsl"
LOG_CHANNEL = "EndField"

# suffix: (Python ChannelType 候选, 是否 sRGB, JS channelIdentifier 候选, JS 格式, user 通道标签)
CHANNEL_SUFFIX_MAP = {
    "basecolor":     (("BaseColor",), True, ("basecolor",), "sRGB8", None),
    "opacity":       (("Opacity",), False, ("opacity",), "L8", None),
    "metallic":      (("Metallic",), False, ("metallic",), "L8", None),
    "specularlevel": (("SpecularLevel", "Specularlevel"), False, ("specularlevel",), "L8", None),
    "roughness":     (("Roughness",), False, ("roughness",), "L8", None),
    # Standard 视差高度 (原 _ParallaxTex) → SP Height 通道; 原 sRGB 字节, 着色器端解码
    "height":        (("Height",), False, ("height",), "L8", None),
    "normal":        (("Normal",), False, ("normal",), "RGB16F", None),
    "emissive":      (("Emissive",), True, ("emissive",), "sRGB8", None),
    # RMOS .b 阴影遮罩 → AO 通道 (EndField_Uber [H1]: shadowMask = getAO)
    # BuildSPInputs 现行导出名是 _ao; user0 是旧版导出名 (同内容), 两者并存时以 ao 为准
    "ao":            (("AO", "AmbientOcclusion", "Ao"), False, ("ambientOcclusion", "ambientocclusion"), "L8", None),
    "user0":         (("AO", "AmbientOcclusion", "Ao"), False, ("ambientOcclusion", "ambientocclusion"), "L8", None),
    # ClearCoat 遮罩 → User1 通道 (可绘制)
    "user1":         (("User1",), False, ("user1",), "L8", "ClearCoatMask"),
    # 注: Face/Fur 的 RGB 数据图 (SDFMask/SDFLightmap/Highlight/Emotion/FurDir/FurDye) 不入通道 —
    # SP 对 RGB(颜色)通道强制色彩管理(sRGB→linear)会篡改线性数据, 且无 API 可改; 它们走 PARAM_SUFFIX_MAP
    # 的 sampler 参数(原始采样=字节等价)。
}

PARAM_SUFFIX_MAP = {
    "difframp":           "_RampMap",
    "rampmap":            "_RampMap",
    "specramp":           "_SpecRampMap",
    "shadowlut":          "_ShadowLutTex",
    "sdfmask":            "_SDFMask",
    "sdflightmap":        "_SDFLightmap",
    "emotionmap":         "_EmotionMap",
    "highlightmap":       "_HighlightMap",
    "matcaptex":          "_MatcapTex",
    "specnormal":         "_SpecNormalMap",   # Hair spec 法线 (原 SplitNormalMap.BA); diffuse 走 Normal 通道
    "splitnormalmap":     None,               # 旧版导出名 — 已拆成 normal 通道 + specnormal 参数, 忽略
    "strokemap":          "_StrokeMap",
    "linemap":            "_LineMap",
    "parallaxtex":        None,               # 已迁到 SP Height 通道 (见 CHANNEL_SUFFIX_MAP["height"])
    "furmap":             "_FurMap",
    "furdirmap":          "_FurDirMap",
    "furdyemap":          "_FurDyeMap",
    "vfxspecialmaintex":  "_VFXSpecialMainTex",
    "vfxspecialblendtex": "_VFXSpecialBlendTex",
    "maintex":            "_VFXMainTex",
    "masktex":            "_VFXMaskTex",
    "blendtex":           "_VFXBlendTex",
    "disturbtex1":        "_VFXDisturbTex",
    "normalmap":          "_VFXNormalMap",
    "outlinemask":        None,   # SP 无描边 pass
    "hairbrowmask":       None,   # URP 改造后无消费方
}

PART_NAMES = {
    0: "Standard", 1: "Face", 2: "Eyes", 3: "Hair",
    4: "Fur", 5: "Eyebrow", 6: "VFX", 7: "OverlayShadow",
}

# Unity 浮点属性 → shader bool 开关
TOGGLE_PARAMS = {
    "u_UseBumpMap": "_UseBumpMap",
    "u_UseMetallicGlossMap": "_UseMetallicGlossMap",
    "u_UseDiffRamp": "_UseDiffRampMap",
    "u_UseShadowLut": "_UseShadowLutTex",
    "u_UseSpecRamp": "_UseSpecRampMap",
    "u_UseEmission": "_UseEmission",
    "u_ClearCoat": "_ClearCoat",
    "u_Pantyhose": "_Pantyhose",
    "u_UseParallax": "_UseParallax",
    "u_UseSDFLightmap": "_UseSDFLightmap",
    "u_UseEmotionMap": "_UseEmotionMap",
    "u_FaceHighlightMap": "_FaceHighlightMap",
    "u_UseMatcap": "_UseMatcap",
    "u_EyeHighLight": "_EyeHighLight",
    "u_UseSpecBumpMap": "_UseSpecBumpMap",
    "u_StrokeOn": "_StrokeOn",
    "u_SpecularLine": "_SpecularLine",
    "u_FurDyeEnable": "_FurDyeEnable",
    "u_EnableCharacterVFX": "_EnableCharacterVFX",
    # _FBXRotationFix 不映射: 游戏运行时用它修对象轴, SP 烘焙网格无需; 开了会把发丝各向异性
    # 轴转错 90° → 刘海高光环消失。SP 端恒为关 (shader 已删该开关)。
    "u_VFXUseMask": "_UseMask",
    "u_VFXUseBlend": "_UseBlend",
    "u_VFXUseDisturb": "_UseDisturb",
    "u_VFXUseFresnel": "_UseFresnel",
    "u_VFXEnableNormalMap": "_EnableNormalMap",
    "u_AlphaBlend": "_SurfaceType",  # >0.5 = Transparent
}

# 同名直拷的标量参数
FLOAT_PARAMS = [
    "_BumpScale", "_Metallic", "_Specular", "_Smoothness",
    "_ShadowColorBrightness", "_ShadowColorSaturation",
    "_SpecRampIridescentMode", "_CubemapIntensity", "_EmissionBrightness",
    "_AlphaPremultiply", "_BackFaceNormalFlip",
    "_SkinRimOffScale", "_FaceRimOffScale", "_EmotionBlend",
    "_MatcapNormalScale",
    "_ParallaxMarchNum", "_ParallaxScale",
    "_PantyhoseSpecularInt", "_PantyhoseSpecularValue", "_PantyhoseAnisotropyDirection",
    "_ClearCoatSmoothness", "_ClearCoatMetallic", "_ClearCoatNormalMode",
    "_AnisotropyValue", "_AnisotropyValue2", "_AnisotropyDirX",
    "_AnisotropyIntensity", "_AnisotropyEdgeFade", "_AnisotropyRange2",
    "_SpecBumpScale", "_StrokeScale",
    "_UseLineMap", "_LineAmount", "_LineValue", "_LineRange",
    "_LineIntensity", "_LineSaturation",
    "_FurLengthIntensity", "_FurCutoffStart", "_FurCutoffEnd", "_FurAO",
    "_FurEdgeFade", "_FurTTIntensity", "_FurDirMapEnable",
    "_FurSharpen", "_FurNoise", "_FurDyeIntensity",
    "_UseVFXMainTexAsAlpha", "_VFXColorIntensity", "_VFXColorAlpha",
    "_VFXSpecialBlendTexRForDisturb", "_VFXFresnelBias",
    "_VFXFresnelAffectOpacity", "_VFXFresnelPower", "_VFXFresnelFlip",
    "_SpecialDissolveScheduleOffset",
    "_EnableVFXColorAdjustment", "_ColorAdjustmentBrightness",
    "_ColorAdjustmentSaturation", "_ColorAdjustmentContrast",
    "_ColorAdjustmentRimWidth", "_ColorAdjustmentRimIntensity",
    "_BlendMode", "_TintColorIntensity", "_TintColorAlpha", "_IgnorePostExposure",
    "_UseMainTexAsAlpha", "_MainTexUseDisturb", "_MainTexUVRotate",
    "_UseMaskTexAsAlpha", "_MaskTexUseDisturb", "_MaskTexUVRotate",
    "_BlendTexUseDisturb", "_BlendTexUVRotate",
    "_DisturbUVRotate1", "_Bi_Disturb", "_DisturbTex1Normal",
    "_DisturbUIntensity1", "_DisturbVIntensity1",
    "_NormalScale", "_NormalMapUseDisturb", "_NormalMapUVRotate",
    "_FresnelBias", "_FresnelAffectOpacity", "_FresnelPower", "_FresnelFlip",
    "_UseNearCameraFade", "_NearCameraFadeDistanceStart", "_NearCameraFadeDistanceEnd",
    "_NearCameraFadeDistanceEnd2", "_NearCameraFadeDistanceStart2",
    "_UseGrayAsAlpha",
]

# 同名直拷的向量/颜色参数 (Unity 把 Vector4 也序列化在 m_Colors)
VEC4_PARAMS = [
    "_BaseColor", "_EmissionColor", "_SDFRimColor", "_HighlightMapVector",
    "_MatcapColor", "_EyeHighLightColor", "_EyeScatteringColor",
    "_AnisotropyColor2", "_HairDarkenParams",
    "_PantyhoseColor", "_ClearCoatColor", "_ParallaxColor",
    "_VFXColor", "_VFXBlendTint", "_VFXSpecialParam", "_VFXFresnelColor",
    "_TintColor", "_BlendTint", "_FresnelColor",
    "_MainTexUVSpeed", "_MaskTexUVSpeed", "_BlendTexUVSpeed",
    "_DisturbUVSpeed1", "_NormalMapUVSpeed",
    "_ColorAdjustmentColorBlend", "_ColorAdjustmentRimColor",
    "_CharacterParams0", "_CharacterParams1", "_CharacterParams2",
    "_CharacterParams3", "_CharacterParams4", "_CharacterParams5",
    "_CharacterParams6", "_CharacterParams7", "_CharacterParams8",
    "_CharacterParams9", "_CharacterParams10", "_CharacterParams11",
    "_CharacterParams12", "_CharacterParams13", "_CharacterParams14",
    "_CharacterParams15", "_EnvironmentGlobalParams0", "_ExposureParams",
]
# Face SDF 脸基轴 (SP 世界空间)。FaceForward 强制 (0,0,0): 实测网格上轴非世界 Y → 任何
# 真实前向都让 SDF 投错水平面正反都糊; (0,0,0) 关前后扫描静态居中但不出错 (用户决定)。
SP_FACE_FORWARD_DEFAULT = [0.0, 0.0, 0.0]
SP_FACE_RIGHT_DEFAULT = [1.0, 0.0, 0.0]

# *_ST 参数 ← params.json texture_st 的源属性
ST_PARAMS = {
    "_BaseMap_ST": "_BaseMap",
    "_FurMap_ST": "_FurMap",
    "_FurDyeMap_ST": "_FurDyeMap",
    "_StrokeMap_ST": "_StrokeMap",
    "_LineMap_ST": "_LineMap",
    "_ParallaxTex_ST": "_ParallaxTex",
    "_VFXSpecialMainTex_ST": "_VFXSpecialMainTex",
    "_VFXSpecialBlendTex_ST": "_VFXSpecialBlendTex",
    "_VFXMainTex_ST": "_MainTex",
    "_VFXMaskTex_ST": "_MaskTex",
    "_VFXBlendTex_ST": "_BlendTex",
    "_VFXDisturbTex_ST": "_DisturbTex1",
    "_VFXNormalMap_ST": "_NormalMap",
}


# ----------------------------------------------------------------------------
# 日志
# ----------------------------------------------------------------------------
def _log(msg):
    substance_painter.logging.info("[{0}] {1}".format(LOG_CHANNEL, msg))


def _warn(msg):
    substance_painter.logging.warning("[{0}] {1}".format(LOG_CHANNEL, msg))


def _resolve_enum(owner, candidates):
    for name in candidates:
        value = getattr(owner, name, None)
        if value is not None:
            return value
    return None


def _channel_type(candidates):
    return _resolve_enum(substance_painter.textureset.ChannelType, candidates)


def _channel_format(candidates):
    return _resolve_enum(substance_painter.textureset.ChannelFormat, candidates)


def _node_name(node):
    for attr in ("get_name", "name"):
        fn = getattr(node, attr, None)
        if callable(fn):
            try:
                return fn()
            except Exception:
                pass
    return ""


# ----------------------------------------------------------------------------
# [v2] 填充图层贴图源 — 运行时探测 (不同 SP 版本类名/签名不同)
# ----------------------------------------------------------------------------
_SOURCE_CLASS_CANDIDATES = (
    "SourceTexture", "SourceResource", "SourceBitmap", "SourceImage",
    "TextureSource", "ResourceSource",
)
_source_dir_reported = [False]


def _set_fill_source(fill, ctype, resource, report):
    """探测式给填充图层通道设置贴图源; 成功返回 True。"""
    rid = None
    try:
        rid = resource.identifier()
    except Exception:
        pass

    attempts = []
    for cname in _SOURCE_CLASS_CANDIDATES:
        cls = getattr(substance_painter.source, cname, None)
        if cls is None:
            continue
        for arg in (rid, resource):
            if arg is None:
                continue
            attempts.append((cname + "(id)" if arg is rid else cname + "(res)",
                             lambda c=cls, a=arg: c(a)))
    # 直接把 ResourceID / Resource 传给 set_source 的旧式签名
    attempts.append(("raw ResourceID", lambda: rid))
    attempts.append(("raw Resource", lambda: resource))

    last_err = None
    for label, make in attempts:
        try:
            src_obj = make()
            if src_obj is None:
                continue
            fill.set_source(ctype, src_obj)
            return True
        except Exception as e:
            last_err = "{0}: {1}".format(label, e)

    if not _source_dir_reported[0]:
        _source_dir_reported[0] = True
        api = [n for n in dir(substance_painter.source) if not n.startswith("_")]
        report.append(u"    !! substance_painter.source 可用成员: {0}".format(", ".join(api)))
        try:
            api2 = [n for n in dir(fill) if not n.startswith("_")]
            report.append(u"    !! FillLayer 可用成员: {0}".format(", ".join(api2)))
        except Exception:
            pass
    if last_err:
        report.append(u"    !! 最后一次尝试: {0}".format(last_err))
    return False


# ----------------------------------------------------------------------------
# [v2] 部位推断 — 文件证据优先, 浮点残留兜底
# ----------------------------------------------------------------------------
def guess_part(mat_name, params, file_suffixes):
    fl = params.get("floats", {}) or {}
    co = params.get("colors", {}) or {}
    n = mat_name.lower()

    # 0) 重定向管线 (Ruri_Character_Uber) 写入的显式 _CharaPartID — 最高真值,
    #    枚举与 EndField_Uber.glsl 一致; GLSL 的 Part5 = 眼系无 Matcap 路径。
    pid = fl.get("_CharaPartID")
    try:
        if pid is not None and 0 <= int(pid) <= 7:
            part = int(pid)
            if part == 2 and "matcaptex" not in file_suffixes and fl.get("_UseMatcap", 0) <= 0.5:
                part = 5
            return part
    except (TypeError, ValueError):
        pass

    # 1) 导出的贴图文件 = 材质真实绑定过的贴图 (Unity .mat 浮点/颜色会残留其他 shader 的脏数据, 不可信)
    if "maintex" in file_suffixes or "blendtex" in file_suffixes or "disturbtex1" in file_suffixes:
        return 6
    if "furmap" in file_suffixes or "furdirmap" in file_suffixes or "furdyemap" in file_suffixes:
        return 4
    if "specnormal" in file_suffixes or "splitnormalmap" in file_suffixes:
        return 3
    if "matcaptex" in file_suffixes:
        return 2
    if "sdflightmap" in file_suffixes or "sdfmask" in file_suffixes:
        return 1

    # 2) 标量兜底 — 全部限定在 "无 RMOS 文件" 时生效:
    #    Skin_Fix / Eye_Fix 都不带 _MetallicGlossMap, 有 RMOS 的 (cloth/wpn) 即便残留
    #    _SkinRimOffScale/_MatcapNormalScale 也一律 Standard。
    # OverlayShadow: 名字可靠; 浮点残留 (_ShadowAngleRange/_UseGrayAsAlpha) 只在
    # "无受光证据"时可信 — wpn 实测残留 _UseGrayAsAlpha=1 但带完整 RMOS/法线/自发光。
    if "eyewhiteshadow" in n or "hairshadow" in n or "overlayshadow" in n:
        return 7
    has_rmos = "metallic" in file_suffixes or "roughness" in file_suffixes
    lit_evidence = has_rmos or "normal" in file_suffixes or "emissive" in file_suffixes
    if ("_ShadowAngleRange" in fl or "_UseGrayAsAlpha" in fl) and not lit_evidence:
        return 7
    if not has_rmos:
        # Skin_Fix 专属签名优先于 Eye 签名: 身体皮肤的 .mat 可能同时残留全套 Eye 键
        # (ardelia body 实测), 而 brow/eyebrow (Eye_Fix) 不声明 _SkinRimOffScale/_FaceRight。
        if "_SkinRimOffScale" in fl or "_FaceRight" in co:
            return 1
        if "_MatcapNormalScale" in fl:  # Eye 系 shader (iris/brow)
            return 2 if fl.get("_UseMatcap", 0) > 0.5 else 5
    return 0


# ----------------------------------------------------------------------------
# 资源导入 (Project 资源架, 重复运行按名重用)
# ----------------------------------------------------------------------------
def _rid(resource):
    """Resource.identifier — 新版是属性, 旧版是方法; 双兼容避免 deprecation 警告。"""
    attr = getattr(resource, "identifier", None)
    if attr is None:
        return None
    try:
        return attr() if callable(attr) else attr
    except TypeError:
        return attr


def _rid_field(rid, name):
    attr = getattr(rid, name, None)
    if attr is None:
        return None
    try:
        return attr() if callable(attr) else attr
    except TypeError:
        return attr


def import_texture(path):
    stem = os.path.splitext(os.path.basename(path))[0]
    try:
        for r in substance_painter.resource.search(stem):
            try:
                rid = _rid(r)
                if _rid_field(rid, "name") == stem and _rid_field(rid, "context") == "project":
                    return r
            except Exception:
                pass
    except Exception:
        pass
    return substance_painter.resource.import_project_resource(
        path, substance_painter.resource.Usage.TEXTURE)


def _resource_url(resource):
    try:
        rid = _rid(resource)
        url = _rid_field(rid, "url")
        return url if url else str(rid)
    except Exception:
        return None


# ----------------------------------------------------------------------------
# 通道 / 填充图层
# ----------------------------------------------------------------------------
def _get_stack(ts_obj, set_name):
    for attr in ("get_stack", "all_stacks"):
        fn = getattr(ts_obj, attr, None)
        if callable(fn):
            try:
                result = fn()
                if isinstance(result, (list, tuple)):
                    if result:
                        return result[0]
                elif result is not None:
                    return result
            except Exception:
                pass
    try:
        return substance_painter.textureset.Stack.from_name(set_name)
    except Exception:
        return None


def _existing_channels(stack):
    fn = getattr(stack, "all_channels", None)
    if callable(fn):
        try:
            return set(fn().keys())
        except Exception:
            pass
    return None


def ensure_channel(ts_obj, stack, set_name, suffix_info, ctype, report):
    existing = _existing_channels(stack)
    if existing is not None and ctype in existing:
        return True

    _candidates, srgb, js_tokens, js_format, js_label = suffix_info

    # 1) 首选 JS API: alg.texturesets.addChannel(set, channelIdentifier, format[, label])
    js_mod = _js()
    if js_mod is not None:
        for token in js_tokens:
            try:
                if js_label:
                    code = "alg.texturesets.addChannel({0}, {1}, {2}, {3})".format(
                        json.dumps(set_name), json.dumps(token), json.dumps(js_format), json.dumps(js_label))
                else:
                    code = "alg.texturesets.addChannel({0}, {1}, {2})".format(
                        json.dumps(set_name), json.dumps(token), json.dumps(js_format))
                js_mod.evaluate(code)
                return True
            except Exception:
                pass

    # 2) Python API 兜底
    fmt = _channel_format(("sRGB8",)) if srgb else _channel_format(("L8", "RGB8"))
    for owner in (stack, ts_obj):
        fn = getattr(owner, "add_channel", None)
        if callable(fn):
            try:
                if fmt is not None:
                    fn(ctype, fmt)
                else:
                    fn(ctype)
                return True
            except Exception as e:
                _warn("add_channel({0}) 失败: {1}".format(ctype, e))

    if existing is not None:
        report.append(u"    !! 缺通道 {0} 且 API 无法添加 — 请手动添加后重跑".format(ctype))
        return False
    return True


def find_or_insert_fill(stack):
    try:
        for node in substance_painter.layerstack.get_root_layer_nodes(stack):
            if _node_name(node) == FILL_LAYER_NAME:
                return node
    except Exception:
        pass
    pos = substance_painter.layerstack.InsertPosition.from_textureset_stack(stack)
    layer = substance_painter.layerstack.insert_fill(pos)
    try:
        layer.set_name(FILL_LAYER_NAME)
    except Exception:
        pass
    return layer


# ----------------------------------------------------------------------------
# Shader 阶段 (EndField_Uber 搜索 + JS 桥实例配置)
# ----------------------------------------------------------------------------
def _sync_shader_source_to_shelves(report):
    """SHADER_GLSL_PATH (真源) → 各 shelf 里的同名 .glsl 副本。
    SP 的 shelf 导入是"拷贝", 改源文件不会自动生效; 这里每次运行前做内容级同步,
    SP 检测到 shelf 文件变化会自动重编译 (热重载)。"""
    if not os.path.isfile(SHADER_GLSL_PATH):
        return
    try:
        with open(SHADER_GLSL_PATH, "rb") as f:
            src = f.read()
    except Exception:
        return
    shelves_cls = getattr(substance_painter.resource, "Shelves", None)
    if shelves_cls is None:
        return
    try:
        shelves = shelves_cls.all()
    except Exception:
        return
    for shelf in shelves:
        try:
            root = shelf.path() if callable(getattr(shelf, "path", None)) else None
        except Exception:
            continue
        if not root:
            continue
        cand = os.path.join(root, "shaders", SHADER_NAME + ".glsl")
        if not os.path.isfile(cand):
            continue
        try:
            with open(cand, "rb") as f:
                cur = f.read()
            if cur != src:
                shutil.copyfile(SHADER_GLSL_PATH, cand)
                report.append(u"已同步最新 shader 源到 shelf: {0}".format(cand))
        except Exception as e:
            report.append(u"!! shelf 同步失败 {0}: {1}".format(cand, e))


def find_endfield_shader(report):
    """在资源库搜索名为 EndField_Uber 的 shader 资源;
    找不到则从 SHADER_GLSL_PATH 自动导入 (session resource), 仍失败返回 None。"""
    _sync_shader_source_to_shelves(report)
    queries = ("u:shader " + SHADER_NAME, SHADER_NAME)
    for query in queries:
        try:
            for r in substance_painter.resource.search(query):
                try:
                    rid = _rid(r)
                    name = _rid_field(rid, "name") or ""
                    if SHADER_NAME.lower() not in str(name).lower():
                        continue
                    usages_fn = getattr(r, "usages", None)
                    if callable(usages_fn):
                        try:
                            usages = usages_fn()
                            shader_usage = getattr(substance_painter.resource.Usage, "SHADER", None)
                            if shader_usage is not None and shader_usage not in usages:
                                continue
                        except Exception:
                            pass
                    return r
                except Exception:
                    pass
        except Exception:
            pass

    # 自动导入兜底 — 满足"哪怕第一次找不到, 再点一次也能一键配置"
    if os.path.isfile(SHADER_GLSL_PATH):
        shader_usage = getattr(substance_painter.resource.Usage, "SHADER", None)
        if shader_usage is not None:
            try:
                r = substance_painter.resource.import_session_resource(SHADER_GLSL_PATH, shader_usage)
                report.append(u"资源库未找到 {0} — 已从磁盘自动导入: {1}".format(SHADER_NAME, SHADER_GLSL_PATH))
                return r
            except Exception as e:
                report.append(u"!! 从 {0} 自动导入 shader 失败: {1}".format(SHADER_GLSL_PATH, e))
    else:
        report.append(u"!! shader 源文件不存在: {0}".format(SHADER_GLSL_PATH))
    return None


def _js():
    try:
        import substance_painter.js as js_mod
        return js_mod
    except Exception:
        return None


def _js_eval(js_mod, code):
    return js_mod.evaluate(code)


def _unity_dir_to_sp(v, default):
    """Unity(.mat, Z-forward 左手) 方向向量 → SP/OpenGL(Z-backward 右手): 翻 Z。
    缺省/全零回退到 SP 世界空间默认。"""
    if not v:
        return list(default)
    try:
        x, y, z = float(v[0]), float(v[1]), float(v[2])
    except (TypeError, ValueError, IndexError):
        return list(default)
    if abs(x) < 1e-8 and abs(y) < 1e-8 and abs(z) < 1e-8:
        return list(default)
    return [x, y, -z]


def _legacy_payload(part, params):
    """旧版导出 (params.json 无 endfield_uber 字段) 的兜底参数推导。"""
    fl = params.get("floats", {}) or {}
    co = params.get("colors", {}) or {}
    st = params.get("texture_st", {}) or {}

    payload = {"u_CharaPart": int(part)}

    for target, src in TOGGLE_PARAMS.items():
        if src in fl:
            payload[target] = bool(fl[src] > 0.5)

    for name in FLOAT_PARAMS:
        if name in fl:
            payload[name] = float(fl[name])
    if "_EmotionIndex" in fl:
        payload["_EmotionIndex"] = int(fl["_EmotionIndex"])
    # Eye 的视差强度: shader 用 _EyeParallaxScale, Unity 属性是 _ParallaxScale
    if part in (2, 5) and "_ParallaxScale" in fl:
        payload["_EyeParallaxScale"] = float(fl["_ParallaxScale"])
        payload.pop("_ParallaxScale", None)

    for name in VEC4_PARAMS:
        if name in co:
            payload[name] = [float(x) for x in co[name][:4]]
    # 脸基轴 (仅 Face=part 1): FaceForward 强制 (0,0,0) 关前后 SDF 扫描; FaceRight 翻 Z → (1,0,0)
    if int(part) == 1:
        payload["_FaceForward"] = list(SP_FACE_FORWARD_DEFAULT)
        payload["_FaceRight"] = _unity_dir_to_sp(co.get("_FaceRight"), SP_FACE_RIGHT_DEFAULT)

    for target, src in ST_PARAMS.items():
        v = st.get(src)
        if v:
            payload[target] = [float(x) for x in v[:4]]

    return payload


def build_shader_payload(set_name, params, param_textures, file_suffixes):
    """生成 alg.shaders.setParameters 的参数字典。
    优先消费 BuildSPInputs 预计算的 endfield_uber.uniforms (键名与 GLSL uniform 同名,
    含部位特化默认值/f_AlphaClip/_EyeParallaxScale 等精确换算);
    旧版导出退回插件自行推导。返回 (part, payload, 来源说明)。"""
    entry = params.get("endfield_uber")
    uniforms = entry.get("uniforms") if isinstance(entry, dict) else None
    if isinstance(uniforms, dict) and uniforms:
        payload = dict(uniforms)
        try:
            part = int(payload.get("u_CharaPart", entry.get("part", 0)))
        except Exception:
            part = 0
        payload["u_CharaPart"] = part
        source = u"params.json[endfield_uber]"
    else:
        part = guess_part(set_name, params, file_suffixes)
        payload = _legacy_payload(part, params)
        source = u"插件推断 (旧版导出, 建议重跑 BuildSPInputs)"

    # Face 脸基轴安全网: SP 世界空间默认必须存在 (旧 params.json 漏键时兜底)。
    # setdefault 只补缺, 不覆盖 — 避免对 BuildSPInputs 已翻 Z 的值二次翻转。
    if part == 1:
        payload.setdefault("_FaceForward", list(SP_FACE_FORWARD_DEFAULT))
        payload.setdefault("_FaceRight", list(SP_FACE_RIGHT_DEFAULT))

    # sampler 贴图参数 (resource url)
    for param, res in param_textures.items():
        url = _resource_url(res)
        if url:
            payload[param] = url

    return part, payload, source


def setup_shader_instances(set_payloads, report):
    """全自动 shader 配置。shaderInstancesToObject() 的实测格式 (本机 SP 日志验证,
    与导出对话框的 JSON 相同):
        {
          "format":      {"version": "1.0"},
          "shaders":     { "<实例名>": {"shader": "<shader文件名>", "shaderInstance": "<实例名>",
                                        "parameters": {...}, ...} },
          "texturesets": { "<材质球名>": {"shader": "<实例名>"} },
        }
    流程: 快照 → 为每个材质球补建同名实例 + 绑定 → FromObject (官方文档: 自动建缺失
    实例并指派给对应 texture set) → updateShaderInstance 切到 EndField_Uber →
    setParameters 写参 → 重新快照逐材质验证。幂等, 可重复执行。
    返回 True = 全部材质验证通过。"""
    report.append(u"== Shader 阶段 ==")

    js_mod = _js()
    if js_mod is None:
        report.append(u"!! 此 SP 版本没有 substance_painter.js 桥 — 无法自动配置实例。")
        return False

    shader_res = find_endfield_shader(report)
    if shader_res is None:
        report.append(u"!! 资源库没有 {0} 且自动导入失败 — 请手动把 {1} 导入 shelf (用途=shader) 后再点一次菜单。".format(
            SHADER_NAME, SHADER_GLSL_PATH))
        QtWidgets.QMessageBox.warning(
            substance_painter.ui.get_main_window(), "EndField",
            u"找不到 shader「{0}」且自动导入失败。\n请手动导入:\n{1}\n然后再点一次「自动设置贴图」。".format(
                SHADER_NAME, SHADER_GLSL_PATH))
        return False
    shader_url = _resource_url(shader_res)
    report.append(u"shader 资源: {0}".format(shader_url))

    def _snapshot():
        obj = _js_eval(js_mod, "alg.shaders.shaderInstancesToObject()")
        if isinstance(obj, str):
            obj = json.loads(obj)
        if not isinstance(obj, dict):
            raise ValueError("shaderInstancesToObject 返回 {0}".format(type(obj).__name__))
        return obj

    all_ok = True

    # ---- 1) 快照 + 补建同名实例 + 绑定材质球 ----
    try:
        obj = _snapshot()
    except Exception as e:
        report.append(u"!! shaderInstancesToObject 失败: {0}".format(e))
        return False

    shaders_map = obj.setdefault("shaders", {})
    ts_map = obj.setdefault("texturesets", {})
    created, rebound = [], []
    for set_name in sorted(set_payloads):
        if not isinstance(shaders_map.get(set_name), dict):
            shaders_map[set_name] = {"shader": SHADER_NAME, "shaderInstance": set_name}
            created.append(set_name)
        binding = ts_map.get(set_name)
        if not isinstance(binding, dict):
            ts_map[set_name] = {"shader": set_name}
            rebound.append(set_name)
        elif binding.get("shader") != set_name:
            binding["shader"] = set_name
            rebound.append(set_name)

    if created or rebound:
        try:
            _js_eval(js_mod, "alg.shaders.shaderInstancesFromObject({0})".format(json.dumps(obj)))
            report.append(u"实例结构已应用: 新建 {0} 个, 重绑 {1} 个".format(len(created), len(rebound)))
        except Exception as e:
            # 兜底: 个别版本 FromObject 不解析陌生 shader 名 → 新实例先克隆现有实例的
            # shader 名建出来 (绑定不受影响), 步骤 3 的 updateShaderInstance 统一切换。
            template = None
            for label, entry in shaders_map.items():
                if isinstance(entry, dict) and entry.get("shader") and label not in created:
                    template = entry["shader"]
                    break
            retried = False
            if template:
                for set_name in created:
                    shaders_map[set_name]["shader"] = template
                try:
                    _js_eval(js_mod, "alg.shaders.shaderInstancesFromObject({0})".format(json.dumps(obj)))
                    report.append(u"实例结构已应用 (克隆 {0} 建实例, 稍后切换): 新建 {1} 个, 重绑 {2} 个".format(
                        template, len(created), len(rebound)))
                    retried = True
                except Exception as e2:
                    e = e2
            if not retried:
                report.append(u"!! shaderInstancesFromObject 失败: {0}".format(e))
                report.append(u"!! 原始快照已写日志, 便于排查。")
                _log(json.dumps(obj)[:4000])
                return False
    else:
        report.append(u"实例结构已就绪 (每个材质球的同名实例与绑定均存在)")

    # ---- 2) 取实例 id (官方 ShaderInstance: {id,label,shader,url}) ----
    try:
        instances = _js_eval(js_mod, "alg.shaders.instances()")
        if isinstance(instances, str):
            instances = json.loads(instances)
    except Exception as e:
        report.append(u"!! alg.shaders.instances() 不可用: {0}".format(e))
        return False
    by_label = {}
    for inst in instances or []:
        if isinstance(inst, dict):
            by_label[str(inst.get("label", ""))] = inst

    # ---- 3) 逐实例: 切 shader + 写参数 ----
    for set_name, payload in sorted(set_payloads.items()):
        inst = by_label.get(set_name)
        if inst is None:
            report.append(u"◆ {0}: !! FromObject 后仍找不到同名实例".format(set_name))
            all_ok = False
            continue
        iid = inst.get("id")

        # shader 不是 EndField_Uber, 或 url 版本与资源库当前版本不一致 (shader 源
        # 更新过) → updateShaderInstance 切换/升级 (必须先切再写参, 切换会重置参数)
        ident = u"{0} {1}".format(inst.get("shader", ""), inst.get("url", ""))
        inst_url = str(inst.get("url", "") or "")
        if SHADER_NAME.lower() not in ident.lower() or (shader_url and inst_url and inst_url != shader_url):
            try:
                _js_eval(js_mod, "alg.shaders.updateShaderInstance({0}, {1})".format(
                    json.dumps(iid), json.dumps(shader_url)))
            except Exception as e:
                report.append(u"◆ {0}: !! updateShaderInstance 失败: {1}".format(set_name, e))
                all_ok = False
                continue

        # 写参数 — 先整包, 失败再逐键隔离
        ok_keys, bad_keys = [], []
        try:
            _js_eval(js_mod, "alg.shaders.setParameters({0}, {1})".format(json.dumps(iid), json.dumps(payload)))
            ok_keys = list(payload.keys())
        except Exception:
            for key, value in payload.items():
                try:
                    _js_eval(js_mod, "alg.shaders.setParameters({0}, {1})".format(
                        json.dumps(iid), json.dumps({key: value})))
                    ok_keys.append(key)
                except Exception:
                    bad_keys.append(key)
        if bad_keys:
            all_ok = False
        report.append(u"◆ {0}: 实例#{1} u_CharaPart={2}({3}) 写入 {4}/{5} 参数{6}".format(
            set_name, iid, payload.get("u_CharaPart"),
            PART_NAMES.get(payload.get("u_CharaPart"), "?"), len(ok_keys), len(payload),
            u"; 失败: " + ", ".join(bad_keys) if bad_keys else u""))

    # ---- 4) 验证: 重新快照, 确认 材质球→同名实例→EndField_Uber ----
    try:
        final = _snapshot()
        f_shaders = final.get("shaders", {}) or {}
        f_ts = final.get("texturesets", {}) or {}
        report.append(u"-- 验证 --")
        for set_name in sorted(set_payloads):
            binding = f_ts.get(set_name) or {}
            bound = binding.get("shader")
            inst_def = f_shaders.get(bound) or {}
            shader_name = str(inst_def.get("shader", ""))
            good = (bound == set_name) and (SHADER_NAME.lower() in shader_name.lower())
            if not good:
                all_ok = False
            report.append(u"{0} {1}: 绑定实例「{2}」shader「{3}」".format(
                u"✓" if good else u"✗", set_name, bound, shader_name))
    except Exception as e:
        report.append(u"!! 验证步骤失败: {0}".format(e))
        all_ok = False

    return all_ok


# ----------------------------------------------------------------------------
# 单个 Texture Set 贴图接线
# ----------------------------------------------------------------------------
def assign_texture_set(ts_obj, set_name, mat_dir, report, set_payloads):
    report.append(u"◆ {0}".format(set_name))

    stack = _get_stack(ts_obj, set_name)
    if stack is None:
        report.append(u"    !! 拿不到 Stack — 跳过")
        return

    prefix = set_name + "_"
    channel_files = {}
    param_files = {}
    file_suffixes = set()
    for fname in sorted(os.listdir(mat_dir)):
        if not fname.lower().endswith(".png") or not fname.startswith(prefix):
            continue
        suffix = os.path.splitext(fname)[0][len(prefix):].lower()
        file_suffixes.add(suffix)
        full = os.path.join(mat_dir, fname)
        if suffix in CHANNEL_SUFFIX_MAP:
            channel_files[suffix] = full
        elif suffix in PARAM_SUFFIX_MAP:
            if PARAM_SUFFIX_MAP[suffix]:
                param_files[suffix] = full
        else:
            report.append(u"    ?  未知后缀: {0} (忽略)".format(fname))

    # ao (现行) 与 user0 (旧版) 同内容; 并存时以 ao 为准, 避免双份接进 AO 通道
    if "ao" in channel_files and "user0" in channel_files:
        channel_files.pop("user0")
        report.append(u"    -  忽略旧版 user0 (已有 ao)")

    # --- 通道贴图 → 填充图层 ---
    wanted_types = {}
    for suffix, path in channel_files.items():
        suffix_info = CHANNEL_SUFFIX_MAP[suffix]
        ctype = _channel_type(suffix_info[0])
        if ctype is None:
            report.append(u"    !! 无通道枚举 {0} — {1} 跳过".format(suffix_info[0], os.path.basename(path)))
            continue
        if not ensure_channel(ts_obj, stack, set_name, suffix_info, ctype, report):
            continue
        wanted_types[ctype] = path

    if wanted_types:
        fill = find_or_insert_fill(stack)
        try:
            current = set(fill.active_channels)
        except Exception:
            current = set()
        try:
            fill.active_channels = current | set(wanted_types.keys())
        except Exception as e:
            _warn("active_channels 设置失败: {0}".format(e))

        for ctype, path in wanted_types.items():
            try:
                res = import_texture(path)
            except Exception as e:
                report.append(u"    !! 导入失败 {0}: {1}".format(os.path.basename(path), e))
                continue
            if _set_fill_source(fill, ctype, res, report):
                report.append(u"    {0:<14} ← {1}".format(str(ctype).split(".")[-1], os.path.basename(path)))
            else:
                report.append(u"    !! {0} 接线失败 (见上方 API 成员列表)".format(os.path.basename(path)))

    # --- sampler 参数贴图 → 导入 + 收集给 shader 阶段 ---
    param_textures = {}
    for suffix, path in sorted(param_files.items()):
        param = PARAM_SUFFIX_MAP[suffix]
        try:
            res = import_texture(path)
            param_textures[param] = res
            report.append(u"    {0:<22} ← {1} (shader 参数)".format(param, os.path.basename(path)))
        except Exception as e:
            report.append(u"    !! 导入失败 {0}: {1}".format(os.path.basename(path), e))

    # --- params.json → 部位 + shader 参数包 ---
    params = {}
    params_path = os.path.join(mat_dir, "params.json")
    if os.path.isfile(params_path):
        try:
            with open(params_path, "r", encoding="utf-8") as f:
                params = json.load(f)
        except Exception as e:
            report.append(u"    ?  params.json 读取失败: {0}".format(e))
    part, payload, source = build_shader_payload(set_name, params, param_textures, file_suffixes)
    report.append(u"    => u_CharaPart = {0} ({1})  [来源: {2}]".format(
        part, PART_NAMES.get(part, "?"), source))
    set_payloads[set_name] = payload


# ----------------------------------------------------------------------------
# 角色文件夹定位
# ----------------------------------------------------------------------------
def list_char_dirs():
    if not os.path.isdir(SPOUTPUT_DIR):
        return []
    result = []
    for name in sorted(os.listdir(SPOUTPUT_DIR)):
        full = os.path.join(SPOUTPUT_DIR, name)
        if os.path.isdir(os.path.join(full, "Materials")):
            result.append(full)
    return result


def auto_locate_char_dir(set_names):
    best, best_hits = None, 0
    for char_dir in list_char_dirs():
        mats = os.path.join(char_dir, "Materials")
        hits = sum(1 for n in set_names if os.path.isdir(os.path.join(mats, n)))
        if hits > best_hits:
            best, best_hits = char_dir, hits
    return best if best_hits > 0 else None


def pick_char_dir():
    parent = substance_painter.ui.get_main_window()
    start = SPOUTPUT_DIR if os.path.isdir(SPOUTPUT_DIR) else ""
    path = QtWidgets.QFileDialog.getExistingDirectory(parent, u"选择 SPOutput 角色文件夹", start)
    if not path:
        return None
    if not os.path.isdir(os.path.join(path, "Materials")):
        QtWidgets.QMessageBox.warning(parent, "EndField", u"该文件夹下没有 Materials/ 子目录:\n" + path)
        return None
    return path


# ----------------------------------------------------------------------------
# 主流程
# ----------------------------------------------------------------------------
def apply_to_project(char_dir):
    mats_root = os.path.join(char_dir, "Materials")
    report = [u"角色: {0}".format(os.path.basename(char_dir)), u""]
    set_payloads = {}

    try:
        texture_sets = substance_painter.textureset.all_texture_sets()
    except Exception as e:
        _warn("all_texture_sets 失败: {0}".format(e))
        return

    for ts_obj in texture_sets:
        try:
            set_name = ts_obj.name() if callable(getattr(ts_obj, "name", None)) else str(ts_obj)
        except Exception:
            set_name = str(ts_obj)
        mat_dir = os.path.join(mats_root, set_name)
        if not os.path.isdir(mat_dir):
            report.append(u"◆ {0}".format(set_name))
            report.append(u"    !! SPOutput 中没有同名材质文件夹 — 跳过")
            report.append(u"")
            continue
        try:
            assign_texture_set(ts_obj, set_name, mat_dir, report, set_payloads)
        except Exception:
            report.append(u"    !! 异常: " + traceback.format_exc(limit=3))
        report.append(u"")

    # Shader 阶段 (搜索/导入 EndField_Uber + 建实例 + 绑定 + 切换 + 写参 + 验证)
    shader_ok = False
    if set_payloads:
        try:
            shader_ok = setup_shader_instances(set_payloads, report)
        except Exception:
            report.append(u"!! Shader 阶段异常: " + traceback.format_exc(limit=3))

        report.append(u"")
        if shader_ok:
            report.append(u"== 结果: ✓ {0} 个材质球已绑定同名 EndField_Uber 实例并写入参数/贴图 ==".format(
                len(set_payloads)))
        else:
            report.append(u"== 结果: ✗ 存在失败项 (见上方 !!/✗ 行) — 操作幂等, 再点一次菜单即可重试补齐 ==")
    else:
        report.append(u"== 结果: 没有任何材质球匹配到 SPOutput — 检查角色文件夹是否正确 ==")

    text = u"\n".join(report)
    for line in report:
        _log(line)

    parent = substance_painter.ui.get_main_window()
    dlg = QtWidgets.QDialog(parent)
    dlg.setWindowTitle(u"EndField 自动贴图 — 报告")
    dlg.resize(760, 600)
    layout = QtWidgets.QVBoxLayout(dlg)
    box = QtWidgets.QPlainTextEdit()
    box.setPlainText(text)
    box.setReadOnly(True)
    layout.addWidget(box)
    btn = QtWidgets.QPushButton(u"确定")
    btn.clicked.connect(dlg.accept)
    layout.addWidget(btn)
    dlg.exec_() if hasattr(dlg, "exec_") else dlg.exec()


# -- 空场景: 建工程 → 等 ProjectEditionEntered → 接线 --
_pending_char_dir = [None]


def _on_project_ready(_event):
    char_dir = _pending_char_dir[0]
    if not char_dir:
        return
    _pending_char_dir[0] = None
    try:
        substance_painter.event.DISPATCHER.disconnect(
            substance_painter.event.ProjectEditionEntered, _on_project_ready)
    except Exception:
        pass
    _log(u"工程就绪, 开始接线: " + char_dir)
    apply_to_project(char_dir)


def create_project_with_fbx(char_dir):
    fbx = None
    for fname in sorted(os.listdir(char_dir)):
        if fname.lower().endswith(".fbx"):
            fbx = os.path.join(char_dir, fname)
            break
    if not fbx:
        QtWidgets.QMessageBox.warning(substance_painter.ui.get_main_window(),
                                      "EndField", u"角色文件夹里没有 .fbx:\n" + char_dir)
        return

    kwargs = {}
    try:
        settings_kwargs = {"import_cameras": False, "default_texture_resolution": 2048}
        nm = getattr(substance_painter.project, "NormalMapFormat", None)
        if nm is not None:
            settings_kwargs["normal_map_format"] = nm.OpenGL
        kwargs["settings"] = substance_painter.project.Settings(**settings_kwargs)
    except Exception as e:
        _warn("Settings 构造失败 (用默认): {0}".format(e))

    _pending_char_dir[0] = char_dir
    substance_painter.event.DISPATCHER.connect(
        substance_painter.event.ProjectEditionEntered, _on_project_ready)
    _log(u"创建工程: " + fbx)
    try:
        substance_painter.project.create(mesh_file_path=fbx, **kwargs)
    except Exception as e:
        _pending_char_dir[0] = None
        try:
            substance_painter.event.DISPATCHER.disconnect(
                substance_painter.event.ProjectEditionEntered, _on_project_ready)
        except Exception:
            pass
        QtWidgets.QMessageBox.critical(substance_painter.ui.get_main_window(),
                                       "EndField", u"工程创建失败:\n{0}".format(e))


def on_run():
    try:
        if substance_painter.project.is_open():
            set_names = []
            try:
                for ts_obj in substance_painter.textureset.all_texture_sets():
                    try:
                        set_names.append(ts_obj.name())
                    except Exception:
                        pass
            except Exception:
                pass
            char_dir = auto_locate_char_dir(set_names) or pick_char_dir()
            if char_dir:
                _log(u"使用角色文件夹: " + char_dir)
                apply_to_project(char_dir)
        else:
            char_dir = pick_char_dir()
            if char_dir:
                create_project_with_fbx(char_dir)
    except Exception:
        _warn(traceback.format_exc())


# ----------------------------------------------------------------------------
# 插件生命周期
# ----------------------------------------------------------------------------
plugin_widgets = []


def start_plugin():
    menu = QtWidgets.QMenu("EndField")
    action = menu.addAction(u"自动设置贴图 / 导入角色 (SPOutput)")
    action.triggered.connect(on_run)
    substance_painter.ui.add_menu(menu)
    plugin_widgets.append(menu)
    _log(u"endfield_auto_textures v3 已加载 — 菜单栏: EndField")


def close_plugin():
    for widget in plugin_widgets:
        substance_painter.ui.delete_ui_element(widget)
    plugin_widgets.clear()


if __name__ == "__main__":
    start_plugin()
