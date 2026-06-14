# RenderDocVulkanDump.py — Vulkan 渲染依赖链贴图导出 (诊断 bloom 灰屏 / 场景塌缩 / NaN 用)
# ============================================================================
# 用法: RenderDoc 打开 .rdc capture → 菜单 Window → Python Shell →
#       右下 "Open" 选本脚本 → "Run". (或在 Shell 里 exec(open(r"...本路径...").read()))
# 产物: 把每个 pass 的 RT 输出 / compute UAV 输出 (以及关键 pass 的采样输入) dump 成 PNG,
#       并生成 _manifest.txt: 每张贴图的 名字 / 尺寸 / 格式 / min/max / 自动标记
#       (DEFAULT=绑了 Unity 默认图, EMPTY=全黑, UNIFORM=纯色, NAN/INF=非法值).
# 设计目标: 只导出"看懂当前 bug 所需"的信息。看不出就把更多数据加进来再跑 (见文件尾 TODO).
# 参考: FractalMiner/RenderDocDrawCallAnalyze.py 的 API 模式, 改 Vulkan + 贴图 dump + 统计.
# ============================================================================
import renderdoc as rd
import os, math, re

# ===================== 配置 =====================
OUTPUT_DIR   = r"D:\Ruri\02.Unity\Project\AzureNihil\Assets\Screenshots\RenderPipelineDumpOutput"
TARGET_RANGE = "all"   # "all" | "0"(当前选中Event) | "120-400" | "120-400,900-950"
DUMP_OUTPUTS = True    # dump 光栅 RT 输出 + compute UAV 输出 (= 各 pass 写出的内容, 看场景如何演变)
DUMP_INPUTS  = True    # dump 采样输入 (仅匹配 INPUT_FILTER 的 pass, 防爆量)
INPUT_FILTER = ["bloom","uber","prefilter","tsr","blit","copy","deferred","cluster",
                "gi","voxel","exposure","tonemap","fog","cloud","atmos","reflect","upsample","final"]
SAVE_EXR     = True    # float 贴图额外存 EXR (HDR 精确, PNG 会钳 [0,1] 把 >1 的都显示成白)
MAX_DUMP     = 8000
# ================================================

_manifest = []
_dump_count = 0
RES_NAME = {}     # resourceId -> 名字
TEX_DESC = {}     # resourceId -> TextureDescription

def log(s):
    print(s)
    _manifest.append(s)

def flatten(actions, out):
    for a in actions:
        out.append(a)
        if a.children:
            flatten(a.children, out)

def sanitize(s):
    return re.sub(r'[^A-Za-z0-9_.\-]', '_', str(s))[:90]

def res_name(rid):
    return RES_NAME.get(rid, "Res_%d" % int(rid))

def fmt_name(desc):
    try:
        f = desc.format
        try:
            n = f.Name()
            if n:
                return n
        except Exception:
            pass
        ct = str(f.compType).split('.')[-1]
        return "%dc_%s_%db" % (f.compCount, ct, f.compByteWidth * 8)
    except Exception:
        return "?fmt"

def tex_dim_str(desc):
    try:
        return "%dx%d" % (desc.width, desc.height) + (("x%d" % desc.arraysize) if desc.arraysize > 1 else "") \
               + (("x%dmip" % desc.mips) if desc.mips > 1 else "")
    except Exception:
        return "?dim"

def comp_type_of(desc):
    try:
        return desc.format.compType
    except Exception:
        return rd.CompType.Float

def get_minmax(controller, rid, mip, slc, comptype):
    try:
        sub = rd.Subresource(mip, slc, 0)
        res = controller.GetMinMax(rid, sub, comptype)
        return res[0], res[1]
    except Exception:
        # 退而求其次: 用 Float 再试一次
        try:
            sub = rd.Subresource(mip, slc, 0)
            res = controller.GetMinMax(rid, sub, rd.CompType.Float)
            return res[0], res[1]
        except Exception as e:
            return None, None

def pixel_vals(pv, comptype):
    try:
        ct = str(comptype).lower()
        if "uint" in ct:
            return list(pv.uintValue)[:4]
        if "sint" in ct or ("int" in ct and "uint" not in ct):
            return list(pv.intValue)[:4]
        return list(pv.floatValue)[:4]
    except Exception:
        try:
            return list(pv.floatValue)[:4]
        except Exception:
            return None

def fmt_vals(v):
    if v is None:
        return "?"
    return "(" + ", ".join(("%.5g" % x) for x in v) + ")"

def classify(name, vmn, vmx):
    flags = []
    low = (name or "").lower()
    if any(k in low for k in ["unitydefault", "unitywhite", "unityblack", "unitygrey",
                              "unitygray", "unity_", "unityred"]):
        flags.append("DEFAULT(" + name + ")")
    if vmn is not None and vmx is not None:
        try:
            allv = [float(x) for x in (vmn[:4] + vmx[:4])]
            if any(math.isnan(x) or math.isinf(x) for x in allv):
                flags.append("NAN/INF")
            else:
                rgbmax = [abs(x) for x in vmx[:3]]
                if all(x < 1e-6 for x in rgbmax):
                    flags.append("EMPTY(black)")
                elif all(abs(vmx[i] - vmn[i]) < 1e-4 for i in range(3)):
                    flags.append("UNIFORM=%.4f" % vmx[0])
        except Exception:
            pass
    return flags

def save_tex(controller, rid, mip, slc, path_no_ext, comptype):
    """存 PNG (钳 [0,1] 视觉) + 可选 EXR (HDR 精确). 返回是否成功."""
    ok = False
    try:
        ts = rd.TextureSave()
        ts.resourceId = rid
        ts.mip = mip
        ts.slice.sliceIndex = slc
        ts.alpha = rd.AlphaMapping.Preserve
        ts.destType = rd.FileType.PNG
        ok = controller.SaveTexture(ts, path_no_ext + ".png")
    except Exception as e:
        print("  [SaveTexture PNG 失败] %s : %s" % (res_name(rid), e))
    if SAVE_EXR:
        try:
            is_float = "float" in str(comptype).lower()
            if is_float:
                ts2 = rd.TextureSave()
                ts2.resourceId = rid
                ts2.mip = mip
                ts2.slice.sliceIndex = slc
                ts2.alpha = rd.AlphaMapping.Preserve
                ts2.destType = rd.FileType.EXR
                controller.SaveTexture(ts2, path_no_ext + ".exr")
        except Exception:
            pass
    return ok

def dump_one(controller, eid, action_name, io_tag, slot, var_name, rid):
    global _dump_count
    if rid == rd.ResourceId.Null():
        return
    if _dump_count >= MAX_DUMP:
        return
    desc = TEX_DESC.get(rid, None)
    if desc is None:
        return   # 不是贴图 (buffer 等) → 跳过
    rname = res_name(rid)
    ct = comp_type_of(desc)
    slc = 0  # 默认 dump slice 0 (2DArray 主层); 需要别的层再扩展
    vmn = vmx = None
    mn, mx = get_minmax(controller, rid, 0, slc, ct)
    if mn is not None:
        vmn = pixel_vals(mn, ct)
        vmx = pixel_vals(mx, ct)
    flags = classify(rname, vmn, vmx)
    base = "e%05d_%s_%s%d_%s_%s" % (eid, sanitize(action_name), io_tag, slot,
                                    sanitize(var_name), sanitize(rname))
    path_no_ext = os.path.join(OUTPUT_DIR, base)
    saved = save_tex(controller, rid, 0, slc, path_no_ext, ct)
    if saved:
        _dump_count += 1
    line = ("e%-6d | %-34.34s | %s[%d] %-32.32s | res=%-26.26s | %-11s %-22.22s | min=%s max=%s %s"
            % (eid, action_name, io_tag, slot, var_name, rname,
               tex_dim_str(desc), fmt_name(desc), fmt_vals(vmn), fmt_vals(vmx),
               (" <<< " + " ".join(flags)) if flags else ""))
    log(line)

def active_stages(state):
    out = []
    for stage, nm in [(rd.ShaderStage.Compute, "CS"), (rd.ShaderStage.Pixel, "PS"),
                      (rd.ShaderStage.Vertex, "VS")]:
        try:
            if state.GetShader(stage) != rd.ResourceId.Null():
                out.append((stage, nm))
        except Exception:
            pass
    return out

def input_var_names(state, stage):
    """返回 {绑定index: shader 变量名} (best effort)."""
    names = {}
    try:
        refl = state.GetShaderReflection(stage)
        if refl and refl.readOnlyResources:
            for idx, r in enumerate(refl.readOnlyResources):
                names[r.fixedBindNumber] = r.name
                names.setdefault(idx, r.name)
    except Exception:
        pass
    return names

def rw_var_names(state, stage):
    names = {}
    try:
        refl = state.GetShaderReflection(stage)
        if refl and hasattr(refl, 'readWriteResources') and refl.readWriteResources:
            for idx, r in enumerate(refl.readWriteResources):
                names[r.fixedBindNumber] = r.name
                names.setdefault(idx, r.name)
    except Exception:
        pass
    return names

def process_event(controller, action):
    eid = action.eventId
    try:
        name = action.GetName(controller.GetStructuredFile())
    except Exception:
        name = action.customName if getattr(action, 'customName', None) else ("Action_%d" % eid)
    controller.SetFrameEvent(eid, True)
    state = controller.GetPipelineState()
    stages = active_stages(state)
    if not stages:
        return  # marker / 非绘制
    low_name = name.lower()
    want_inputs = DUMP_INPUTS and (not INPUT_FILTER or any(k in low_name for k in INPUT_FILTER))

    # --- 输出: 光栅 RT (color outputs) ---
    if DUMP_OUTPUTS:
        try:
            for i, t in enumerate(state.GetOutputTargets()):
                if t.resource != rd.ResourceId.Null():
                    dump_one(controller, eid, name, "OUT", i, "RT", t.resource)
        except Exception as e:
            print("  [GetOutputTargets err] %s" % e)

        # --- 输出: compute UAV (TSR / GI / 体素 等 compute 写出的 RWTexture) ---
        for stage, snm in stages:
            try:
                rws = state.GetReadWriteResources(stage)
                vmap = rw_var_names(state, stage)
                for i, b in enumerate(rws):
                    d = b.descriptor
                    if d.resource != rd.ResourceId.Null():
                        dump_one(controller, eid, name, "UAV", i, vmap.get(i, "rw%d" % i), d.resource)
            except Exception:
                pass

    # --- 输入: 采样贴图 (只对关注的 pass, 用来确认 _BlitTexture 等到底绑了什么) ---
    if want_inputs:
        for stage, snm in stages:
            try:
                ros = state.GetReadOnlyResources(stage)
                vmap = input_var_names(state, stage)
                for i, b in enumerate(ros):
                    d = b.descriptor
                    if d.resource != rd.ResourceId.Null() and d.resource in TEX_DESC:
                        dump_one(controller, eid, name, "IN", i, vmap.get(i, "t%d" % i), d.resource)
            except Exception:
                pass

def parse_range(all_actions):
    s = TARGET_RANGE.strip().lower()
    if s == "all":
        return all_actions
    eids = set()
    if s == "0":
        if hasattr(pyrenderdoc, 'CurEvent'):
            eids.add(pyrenderdoc.CurEvent())
    else:
        for part in s.split(','):
            part = part.strip()
            if not part:
                continue
            if '-' in part:
                a, b = part.split('-')[:2]
                eids.update(range(int(a), int(b) + 1))
            else:
                eids.add(int(part))
    return [a for a in all_actions if a.eventId in eids]

def main(controller):
    global RES_NAME, TEX_DESC, _manifest, _dump_count
    _manifest = []
    _dump_count = 0
    os.makedirs(OUTPUT_DIR, exist_ok=True)

    for r in controller.GetResources():
        RES_NAME[r.resourceId] = r.name
    for t in controller.GetTextures():
        TEX_DESC[t.resourceId] = t

    all_actions = []
    flatten(controller.GetRootActions(), all_actions)
    targets = parse_range(all_actions)

    log("# RenderDocVulkanDump — %d 个 pass 待处理, 输出目录: %s" % (len(targets), OUTPUT_DIR))
    log("# 列: event | pass名 | IO[slot] 变量 | res=资源名 | 尺寸 格式 | min max | 标记")
    log("# 标记: DEFAULT=绑了Unity默认图(空) / EMPTY=全黑 / UNIFORM=纯色一片 / NAN/INF=非法值")
    log("#" + "=" * 120)

    for a in targets:
        try:
            process_event(controller, a)
        except Exception as e:
            print("  [event %d 处理失败] %s" % (a.eventId, e))

    log("#" + "=" * 120)
    log("# 共 dump %d 张贴图" % _dump_count)

    # 汇总: 把所有"被标记异常"的行单独列出, 方便一眼定位
    flagged = [ln for ln in _manifest if "<<<" in ln]
    log("\n# ===== 异常标记汇总 (DEFAULT / EMPTY / UNIFORM / NAN) =====")
    for ln in flagged:
        log(ln)

    try:
        with open(os.path.join(OUTPUT_DIR, "_manifest.txt"), "w", encoding="utf-8") as f:
            f.write("\n".join(_manifest))
        print("\n[OK] manifest 写入: %s" % os.path.join(OUTPUT_DIR, "_manifest.txt"))
    except Exception as e:
        print("[manifest 写入失败] %s" % e)

def run():
    if 'pyrenderdoc' in globals() and hasattr(pyrenderdoc, 'Replay'):
        pyrenderdoc.Replay().BlockInvoke(main)
    else:
        print("请在 RenderDoc 的 Python Shell 内运行 (需要 pyrenderdoc).")

run()

# ============================================================================
# TODO (若现有数据仍看不出 bug, 按需加):
#   - 每张贴图存 EXR 已开 (SAVE_EXR=True) → 用 EXR 看 HDR 真值 (PNG 钳 [0,1]).
#   - NaN 精确定位: 当前靠 GetMinMax (可能跳过 NaN). 需要时改用 controller.GetTextureData
#     原始字节解析, 或 GetHistogram 看 NaN 桶.
#   - 2DArray 多层: 现仅 dump slice 0. 需要时循环 desc.arraysize.
#   - cbuffer 值 (曝光乘数 / 阈值 / flags): 参考脚本 GetCBufferVariableContents.
# ============================================================================
