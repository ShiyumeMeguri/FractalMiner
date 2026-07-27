# RenderDocVulkanDump.py — Vulkan 完整渲染数据导出 (最完整版, 诊断 bloom/TSR/GI)
# ============================================================================
# 每个 pass 全量导出:
#   - 标签路径 (debug marker) + 每个着色阶段的 shader 文件
#   - 每个 cbuffer 的"实际 uniform 值"(阈值/flags/曝光乘子/屏幕变换矩阵/相机参数 等)
#   - 所有输入采样贴图 (名字/尺寸/格式/min-max/异常标记 + dump PNG(+EXR))
#   - 所有输出 RT + 深度 + compute UAV (同上)
# 不再做输入/输出过滤 (NAME_FILTER 空=全量). 末尾汇总所有异常贴图(DEFAULT/EMPTY/UNIFORM/NAN).
# 用法: RenderDoc 打开 .rdc → Window→Python Shell → Open 本脚本 → Run.
#   (太慢/太大时: 先设 DUMP_TEXTURE=False 跑一遍只出文字 manifest(含 cbuffer 值, 秒级);
#    或把 NAME_FILTER 设成 ["bloom","uber","prefilter","tsr","gi","voxel","deferred","cluster","blit","copy"]).
# 参考: FractalMiner/RenderDocDrawCallAnalyze.py 的 cbuffer/shader 取法.
# ============================================================================
import renderdoc as rd
import os, math, re

# ===================== 配置 =====================
OUTPUT_DIR   = r"D:\Ruri\02.Unity\Project\AzureNihil\Assets\Screenshots\RenderPipelineDumpOutput"
TARGET_RANGE = "all"          # "all" | "0"(当前选中Event) | "100-400" | "100-400,900-950"
NAME_FILTER  = []             # 空=所有 pass; 否则只处理 label/name(小写) 含这些词的 pass
DUMP_TEXTURE = True           # True=存贴图内容(PNG/EXR); False=只出文字 manifest(名字/尺寸/统计/cbuffer 值, 极快)
SAVE_EXR     = True           # float 贴图额外存 EXR (HDR 精确, PNG 钳 [0,1])
DUMP_CBUFFER = True           # 导出每 pass 的 cbuffer 实际 uniform 值
MAX_TEX      = 12000
# ================================================

_manifest = []
RES_NAME = {}
TEX_DESC = {}
LABEL_MAP = {}
_texcount = 0

def log(s):
    print(s)
    _manifest.append(s)

def action_name(a, sd):
    try:
        return a.GetName(sd)
    except Exception:
        return getattr(a, 'customName', None) or ("Action_%d" % a.eventId)

def flatten(actions, out, sd, parent=""):
    for a in actions:
        LABEL_MAP[a.eventId] = parent
        out.append(a)
        if a.children:
            nm = action_name(a, sd)
            flatten(a.children, out, sd, (parent + " > " + nm) if parent else nm)

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
        return "%dc_%s_%db" % (f.compCount, str(f.compType).split('.')[-1], f.compByteWidth * 8)
    except Exception:
        return "?fmt"

def dim_str(desc):
    try:
        s = "%dx%d" % (desc.width, desc.height)
        if desc.arraysize > 1:
            s += "x%d" % desc.arraysize
        if desc.mips > 1:
            s += "(%dmip)" % desc.mips
        return s
    except Exception:
        return "?dim"

def comp_type(desc):
    try:
        return desc.format.compType
    except Exception:
        return rd.CompType.Float

def minmax(controller, rid, ct):
    for c in (ct, rd.CompType.Float):
        try:
            r = controller.GetMinMax(rid, rd.Subresource(0, 0, 0), c)
            return r[0], r[1]
        except Exception:
            continue
    return None, None

def pvals(pv, ct):
    s = str(ct).lower()
    try:
        if "uint" in s:
            return list(pv.uintValue)[:4]
        if "int" in s:
            return list(pv.intValue)[:4]
        return list(pv.floatValue)[:4]
    except Exception:
        try:
            return list(pv.floatValue)[:4]
        except Exception:
            return None

def fvals(v):
    return "?" if v is None else "(" + ", ".join("%.5g" % x for x in v) + ")"

def flags_of(name, mn, mx):
    fl = []
    low = (name or "").lower()
    if any(k in low for k in ["unitydefault", "unitywhite", "unityblack", "unitygrey", "unitygray", "unity_"]):
        fl.append("DEFAULT")
    if mn and mx:
        try:
            allv = [float(x) for x in mn[:4] + mx[:4]]
            if any(math.isnan(x) or math.isinf(x) for x in allv):
                fl.append("NAN/INF")
            elif all(abs(x) < 1e-6 for x in mx[:3]):
                fl.append("EMPTY")
            elif all(abs(mx[i] - mn[i]) < 1e-4 for i in range(3)):
                fl.append("UNIFORM=%.4f" % mx[0])
        except Exception:
            pass
    return fl

def save_tex(controller, rid, ct, base):
    try:
        ts = rd.TextureSave()
        ts.resourceId = rid
        ts.mip = 0
        ts.slice.sliceIndex = 0
        ts.alpha = rd.AlphaMapping.Preserve
        ts.destType = rd.FileType.PNG
        controller.SaveTexture(ts, base + ".png")
    except Exception:
        pass
    if SAVE_EXR and "float" in str(ct).lower():
        try:
            ts = rd.TextureSave()
            ts.resourceId = rid
            ts.mip = 0
            ts.slice.sliceIndex = 0
            ts.alpha = rd.AlphaMapping.Preserve
            ts.destType = rd.FileType.EXR
            controller.SaveTexture(ts, base + ".exr")
        except Exception:
            pass

def dump_tex(controller, eid, passname, io, slot, var, rid):
    global _texcount
    if rid == rd.ResourceId.Null():
        return
    d = TEX_DESC.get(rid)
    if d is None:
        return
    ct = comp_type(d)
    mn, mx = minmax(controller, rid, ct)
    vmn = pvals(mn, ct) if mn else None
    vmx = pvals(mx, ct) if mx else None
    fl = flags_of(res_name(rid), vmn, vmx)
    if DUMP_TEXTURE and _texcount < MAX_TEX:
        base = os.path.join(OUTPUT_DIR, "e%05d_%s_%s%d_%s_%s" %
                            (eid, sanitize(passname), io, slot, sanitize(var), sanitize(res_name(rid))))
        save_tex(controller, rid, ct, base)
        _texcount += 1
    log("    %-5s[%d] %-30.30s res=%-28.28s %-12s %-20.20s min=%s max=%s%s" %
        (io, slot, var, res_name(rid), dim_str(d), fmt_name(d), fvals(vmn), fvals(vmx),
         ("  <<< " + " ".join(fl)) if fl else ""))

# --------- cbuffer 实际值 (参考 RenderDocDrawCallAnalyze.py format_numeric/extract_variables) ---------
def fmt_num(v):
    try:
        rows, cols, val = v.rows, v.columns, v.value
        t = str(v.type).lower()
        if 'uint' in t:
            data, f, pre = val.u32v, "{}", "uvec"
        elif 'int' in t:
            data, f, pre = val.s32v, "{}", "ivec"
        elif 'double' in t:
            data, f, pre = val.f64v, "{:.5g}", "dvec"
        else:
            data, f, pre = val.f32v, "{:.5g}", "vec"
        if rows > 1:
            lines = []
            for r in range(rows):
                row = [f.format(data[r * cols + c]) if r * cols + c < len(data) else "0" for c in range(cols)]
                lines.append("[" + ", ".join(row) + "]")
            return " ".join(lines)
        if cols > 1:
            return pre + str(cols) + "(" + ", ".join(f.format(data[i]) if i < len(data) else "0" for i in range(cols)) + ")"
        return f.format(data[0]) if data else "0"
    except Exception as e:
        return "?(%s)" % e

def extract_vars(vs, ind=0):
    out = []
    for v in vs:
        if v.members:
            out.append("      " + "  " * ind + "- " + v.name + ":")
            out += extract_vars(v.members, ind + 1)
        else:
            out.append("      " + "  " * ind + "- " + v.name + " = " + fmt_num(v))
    return out

def dump_cbuffers(controller, state, stage, shader_id):
    if not DUMP_CBUFFER:
        return
    try:
        refl = state.GetShaderReflection(stage)
        if not (refl and refl.constantBlocks):
            return
        pipe = state.GetComputePipelineObject() if stage == rd.ShaderStage.Compute else state.GetGraphicsPipelineObject()
        entry = refl.entryPoint if refl else "main"
        cbs = state.GetConstantBlocks(stage)
        for i, cbr in enumerate(refl.constantBlocks):
            slot = cbr.fixedBindNumber
            if slot < 0:
                slot = i
            if slot >= len(cbs):
                continue
            desc = cbs[slot].descriptor
            if desc.resource == rd.ResourceId.Null():
                continue
            try:
                vs = controller.GetCBufferVariableContents(pipe, shader_id, stage, entry, slot,
                                                           desc.resource, desc.byteOffset, desc.byteSize)
                if vs:
                    log("    CBUFFER %s:" % cbr.name)
                    for ln in extract_vars(vs):
                        log(ln)
            except Exception as e:
                log("    CBUFFER %s: <读取失败 %s>" % (cbr.name, e))
    except Exception:
        pass

def active_stages(state):
    out = []
    for st in (rd.ShaderStage.Compute, rd.ShaderStage.Pixel, rd.ShaderStage.Vertex):
        try:
            if state.GetShader(st) != rd.ResourceId.Null():
                out.append(st)
        except Exception:
            pass
    return out

def var_names(refl, rw=False):
    m = {}
    try:
        lst = (refl.readWriteResources if rw else refl.readOnlyResources) or []
        for i, r in enumerate(lst):
            m[r.fixedBindNumber] = r.name
            m.setdefault(i, r.name)
    except Exception:
        pass
    return m

def shader_file(refl):
    try:
        if refl and refl.debugInfo and refl.debugInfo.files:
            return refl.debugInfo.files[0].filename
    except Exception:
        pass
    return "?"

def process(controller, a):
    eid = a.eventId
    raw = action_name(a, controller.GetStructuredFile())
    label = LABEL_MAP.get(eid, "")
    full = (label + " / " + raw) if label else raw
    if NAME_FILTER and not any(k in full.lower() for k in NAME_FILTER):
        return
    controller.SetFrameEvent(eid, True)
    state = controller.GetPipelineState()
    stages = active_stages(state)
    if not stages:
        return
    log("")
    log("=" * 110)
    log("e%d  %s" % (eid, full))
    for st in stages:
        sid = state.GetShader(st)
        refl = state.GetShaderReflection(st)
        log("  [%s] shader=%d file=%s" % (str(st).split('.')[-1], int(sid), shader_file(refl)))
        dump_cbuffers(controller, state, st, sid)
    log("  --- 输入 (采样贴图) ---")
    for st in stages:
        try:
            vm = var_names(state.GetShaderReflection(st), False)
            for i, b in enumerate(state.GetReadOnlyResources(st)):
                rid = b.descriptor.resource
                if rid != rd.ResourceId.Null() and rid in TEX_DESC:
                    dump_tex(controller, eid, full, "IN", i, vm.get(i, "t%d" % i), rid)
        except Exception:
            pass
    log("  --- 输出 (RT / DEPTH / UAV) ---")
    try:
        for i, t in enumerate(state.GetOutputTargets()):
            if t.resource != rd.ResourceId.Null():
                dump_tex(controller, eid, full, "RT", i, "color", t.resource)
        dt = state.GetDepthTarget()
        if dt.resource != rd.ResourceId.Null():
            dump_tex(controller, eid, full, "DEPTH", 0, "depth", dt.resource)
    except Exception:
        pass
    for st in stages:
        try:
            vm = var_names(state.GetShaderReflection(st), True)
            for i, b in enumerate(state.GetReadWriteResources(st)):
                rid = b.descriptor.resource
                if rid != rd.ResourceId.Null() and rid in TEX_DESC:
                    dump_tex(controller, eid, full, "UAV", i, vm.get(i, "u%d" % i), rid)
        except Exception:
            pass

def parse_range(all_a):
    s = TARGET_RANGE.strip().lower()
    if s == "all":
        return all_a
    eids = set()
    if s == "0":
        if 'pyrenderdoc' in globals() and hasattr(pyrenderdoc, 'CurEvent'):
            eids.add(pyrenderdoc.CurEvent())
    else:
        for p in s.split(','):
            p = p.strip()
            if not p:
                continue
            if '-' in p:
                a, b = p.split('-')[:2]
                eids.update(range(int(a), int(b) + 1))
            else:
                eids.add(int(p))
    return [a for a in all_a if a.eventId in eids]

def main(controller):
    global RES_NAME, TEX_DESC, _manifest, _texcount
    _manifest = []
    _texcount = 0
    os.makedirs(OUTPUT_DIR, exist_ok=True)
    for r in controller.GetResources():
        RES_NAME[r.resourceId] = r.name
    for t in controller.GetTextures():
        TEX_DESC[t.resourceId] = t
    all_a = []
    flatten(controller.GetRootActions(), all_a, controller.GetStructuredFile())
    targets = parse_range(all_a)
    log("# 完整渲染数据导出 — %d pass 待处理, 输出 %s" % (len(targets), OUTPUT_DIR))
    log("# 每 pass: shader文件 + cbuffer实际值 + 所有输入贴图 + 所有输出 RT/DEPTH/UAV (含 min/max/异常标记)")
    log("# 标记: DEFAULT=Unity默认图(没绑上) / EMPTY=全黑 / UNIFORM=纯色一片 / NAN/INF=非法值")
    for a in targets:
        try:
            process(controller, a)
        except Exception as e:
            print("  [e%d 失败] %s" % (a.eventId, e))
    fl = [ln for ln in _manifest if "<<<" in ln]
    log("")
    log("# ===== 异常贴图汇总 (DEFAULT / EMPTY / UNIFORM / NAN) =====")
    for ln in fl:
        log(ln.strip())
    log("")
    log("# 共 dump %d 张贴图内容" % _texcount)
    try:
        with open(os.path.join(OUTPUT_DIR, "_manifest.txt"), "w", encoding="utf-8") as f:
            f.write("\n".join(_manifest))
        print("[OK] manifest -> %s" % os.path.join(OUTPUT_DIR, "_manifest.txt"))
    except Exception as e:
        print("[manifest 写入失败] %s" % e)

def run():
    if 'pyrenderdoc' in globals() and hasattr(pyrenderdoc, 'Replay'):
        pyrenderdoc.Replay().BlockInvoke(main)
    else:
        print("请在 RenderDoc 的 Python Shell 内运行 (需要 pyrenderdoc).")

run()
