import renderdoc as rd
import qrenderdoc as qrd
import sys

# ==========================================
# [设置] 0 = 当前选中Event; "10-30" = 范围
TARGET_RANGE = "0"  
# ==========================================

# --- 全局缓存 (去重用) ---
BUFFER_CACHE = {} # {id: {name, size, content}}
SHADER_CACHE = {} # {id: {stage, filename, content}}

# --- 1. 辅助格式化函数 ---
def get_resource_id_safe(obj):
    if obj is None: return rd.ResourceId.Null()
    if hasattr(obj, 'resourceId'): return obj.resourceId
    if hasattr(obj, 'resource'): return obj.resource
    if hasattr(obj, 'descriptor'):
        desc = obj.descriptor
        if hasattr(desc, 'resource'): return desc.resource
    return rd.ResourceId.Null()

def format_numeric(variable):
    try:
        rows = variable.rows
        cols = variable.columns
        val = variable.value
        type_str = str(variable.type).lower()
        
        data_source = val.f32v
        fmt_str = "{:.6f}"
        type_prefix = "vec"
        
        if 'uint' in type_str:
            data_source = val.u32v
            fmt_str = "{}"
            type_prefix = "uvec"
        elif 'int' in type_str:
            data_source = val.s32v
            fmt_str = "{}"
            type_prefix = "ivec"
        elif 'double' in type_str:
            data_source = val.f64v
            type_prefix = "dvec"

        if rows > 1: 
            lines = []
            for r in range(rows):
                row_vals = []
                for c in range(cols):
                    idx = r * cols + c
                    val_data = data_source[idx] if idx < len(data_source) else 0
                    row_vals.append(fmt_str.format(val_data))
                lines.append(f"[{', '.join(row_vals)}]")
            return "\n      " + "\n      ".join(lines)
        elif cols > 1: 
            vals = [fmt_str.format(data_source[i]) if i < len(data_source) else "0" for i in range(cols)]
            return f"{type_prefix}{cols}({', '.join(vals)})"
        else: 
            return fmt_str.format(data_source[0]) if len(data_source) > 0 else "0"
    except Exception as e:
        return f"? (Err: {e})"

def extract_variables(variables, indent=0):
    lines = []
    prefix = "  " * indent
    for v in variables:
        if v.members:
            lines.append(f"{prefix}- {v.name}:")
            lines.extend(extract_variables(v.members, indent + 1))
        else:
            lines.append(f"{prefix}- {v.name}: {format_numeric(v)}")
    return lines

def get_res_display_info(controller, rid):
    try:
        resources = controller.GetResources()
        for r in resources:
            if r.resourceId == rid:
                return r.name
    except:
        pass
    return f"Res_{int(rid)}"

# --- 2. 核心：打印管线状态 (修复 Blend 属性访问) ---
def print_pipeline_details(state):
    # 2.1 Topology
    try:
        topo = state.GetPrimitiveTopology()
        print(f"  [Input Assembly]")
        print(f"    Topology: {topo}")
    except:
        pass

    # 2.2 Rasterizer (Viewport/Scissor)
    try:
        vp = state.GetViewport(0)
        sc = state.GetScissor(0)
        print(f"  [Rasterizer Data (Slot 0)]")
        print(f"    Viewport: {vp.x:.1f}, {vp.y:.1f} | Size: {vp.width:.1f}x{vp.height:.1f} | Z: {vp.minDepth}-{vp.maxDepth}")
        print(f"    Scissor:  {sc.x}, {sc.y} | Size: {sc.width}x{sc.height}")
    except:
        pass

    # 2.3 Stencil
    try:
        front, back = state.GetStencilFaces()
        print(f"  [Depth & Stencil State]")
        
        def fmt_face(name, face):
            # 安全获取属性，防止部分API版本差异
            ref = getattr(face, 'reference', '?')
            cmask = getattr(face, 'compareMask', 0)
            wmask = getattr(face, 'writeMask', 0)
            func = getattr(face, 'function', '?')
            pass_op = getattr(face, 'passOperation', '?')
            fail_op = getattr(face, 'failOperation', '?')
            zfail_op = getattr(face, 'depthFailOperation', '?')
            
            print(f"    [{name}] Ref:{ref} Mask:0x{cmask:02X} Write:0x{wmask:02X}")
            print(f"       Func: {func}")
            print(f"       Pass: {pass_op} | Fail: {fail_op} | ZFail: {zfail_op}")

        fmt_face("Stencil Front", front)
        fmt_face("Stencil Back ", back)
    except Exception as e:
        print(f"  [Depth & Stencil State] Error: {e}")

    # 2.4 Blend State (修复：使用正确的属性名)
    try:
        blends = state.GetColorBlends()
        print(f"  [Blend State]")
        print(f"    Independent Blend: {state.IsIndependentBlendingEnabled()}")
        
        printed_any_rt = False
        for i, rt in enumerate(blends):
            # 【修复点】使用 rt.enabled 而不是 rt.blendEnable
            is_enabled = rt.enabled
            write_mask = rt.writeMask
            
            if is_enabled or write_mask != 0:
                printed_any_rt = True
                print(f"    RT[{i}]: Enabled={is_enabled}, WriteMask=0x{write_mask:02X}")
                
                if is_enabled:
                    # 【修复点】混合公式在 colorBlend 和 alphaBlend 子对象中
                    cb = rt.colorBlend
                    ab = rt.alphaBlend
                    
                    # 尝试打印 (Source, Dest, Op)
                    print(f"      Color: Src={cb.source} {cb.operation} Dst={cb.destination}")
                    print(f"      Alpha: Src={ab.source} {ab.operation} Dst={ab.destination}")
                
                if rt.logicOperationEnabled:
                    print(f"      LogicOp: {rt.logicOperation}")

        if not printed_any_rt:
            print(f"    (No active Render Targets output)")
            
    except Exception as e:
        print(f"  [Blend State] Error: {e}")

# --- 3. 获取 Shader 代码 ---
def fetch_shader_code(controller, shader_id, reflection, stage_name):
    fname = "Unknown"
    code = ""
    
    if reflection and reflection.debugInfo and reflection.debugInfo.files:
        f = reflection.debugInfo.files[0]
        fname = f.filename
        code = f.contents
    
    if not code or len(code) == 0:
        fname = f"Disassembly ({stage_name})"
        try:
            code = controller.DisassembleShader(shader_id, reflection, "")
        except Exception as e:
            code = f"// Disassembly failed: {e}"

    return fname, code

# --- 4. 单个Event分析逻辑 ---
def process_event(controller, event_id):
    controller.SetFrameEvent(event_id, True)
    state = controller.GetPipelineState()
    
    print(f"\n{'='*60}")
    print(f">>> [Event {event_id}] Pipeline Analysis")
    print(f"{'='*60}")
    
    # 4.1 打印管线状态
    print_pipeline_details(state)
    
    # 4.2 遍历 Shader 阶段
    stages = [
        (rd.ShaderStage.Vertex, "Vertex Shader"),
        (rd.ShaderStage.Pixel, "Pixel Shader"),
        (rd.ShaderStage.Compute, "Compute Shader"),
        (rd.ShaderStage.Geometry, "Geometry Shader"),
        (rd.ShaderStage.Hull, "Hull Shader"),
        (rd.ShaderStage.Domain, "Domain Shader"),
    ]
    
    for stage_enum, stage_name in stages:
        shader_id = state.GetShader(stage_enum)
        if shader_id == rd.ResourceId.Null():
            continue
            
        pipe_id = state.GetComputePipelineObject() if stage_enum == rd.ShaderStage.Compute else state.GetGraphicsPipelineObject()
        reflection = state.GetShaderReflection(stage_enum)
        entry = reflection.entryPoint if reflection else "main"

        # 缓存 Shader
        if shader_id not in SHADER_CACHE:
            fname, code = fetch_shader_code(controller, shader_id, reflection, stage_name)
            SHADER_CACHE[shader_id] = {
                "stage": stage_name,
                "filename": fname,
                "content": code
            }
        
        cached_shader = SHADER_CACHE[shader_id]
        print(f"\n  [{stage_name}]")
        print(f"    Ref ShaderID: {int(shader_id)}") 
        print(f"    File: {cached_shader['filename']}")
        print(f"    EntryPoint: {entry}")

        # === Constant Buffer 处理 ===
        cblocks = state.GetConstantBlocks(stage_enum)
        if reflection and reflection.constantBlocks:
            print(f"    [Bound Constant Buffers]")
            for i, cb_refl in enumerate(reflection.constantBlocks):
                slot = cb_refl.fixedBindNumber
                if slot < 0: slot = i
                
                if slot < len(cblocks):
                    desc = cblocks[slot].descriptor
                    buf_id = desc.resource
                    
                    if buf_id != rd.ResourceId.Null():
                        res_name = get_res_display_info(controller, buf_id)
                        print(f"      - Slot {slot} ({cb_refl.name}) -> BufferID: {int(buf_id)} | {res_name}")
                        
                        # 缓存 Buffer 内容
                        if buf_id not in BUFFER_CACHE:
                            try:
                                vars = controller.GetCBufferVariableContents(
                                    pipe_id, shader_id, stage_enum, entry, slot, 
                                    buf_id, desc.byteOffset, desc.byteSize
                                )
                                if vars:
                                    BUFFER_CACHE[buf_id] = {
                                        "name": res_name,
                                        "size": desc.byteSize,
                                        "content": extract_variables(vars)
                                    }
                                else:
                                    BUFFER_CACHE[buf_id] = {"name": res_name, "size": desc.byteSize, "content": ["(No readable vars)"]}
                            except Exception as e:
                                BUFFER_CACHE[buf_id] = {"name": res_name, "size": 0, "content": [f"Err: {e}"]}
        else:
            pass

# --- 5. 主逻辑 ---
def analyze_main(controller):
    global BUFFER_CACHE, SHADER_CACHE
    BUFFER_CACHE.clear()
    SHADER_CACHE.clear()
    
    # 解析范围
    target_eids = []
    if TARGET_RANGE == "0":
        if hasattr(pyrenderdoc, 'CurEvent'):
            target_eids = [pyrenderdoc.CurEvent()]
    elif "-" in TARGET_RANGE:
        try:
            start, end = map(int, TARGET_RANGE.split("-"))
            target_eids = list(range(start, end + 1))
        except:
            print("Invalid range.")
            return
    else:
        try: target_eids = [int(TARGET_RANGE)]
        except: pass

    # 1. 收集引用
    for eid in target_eids:
        try:
            process_event(controller, eid)
        except Exception as e:
            print(f"Error processing event {eid}: {e}")

    print("\n" + "#"*60)
    print(" # REFERENCE: UNIQUE SHADER CODES")
    print(" # (Full output, no truncation)")
    print("#"*60)

    # 2. 打印去重后的 Shader (不截断)
    for sid, data in SHADER_CACHE.items():
        print(f"\n>>> Shader ID: {int(sid)} ({data['stage']}) | File: {data['filename']}")
        print("```glsl")
        print(data['content'])
        print("```")

    print("\n" + "#"*60)
    print(" # REFERENCE: UNIQUE BUFFER CONTENTS")
    print("#"*60)
    
    # 3. 打印去重后的 Buffer
    for bid, data in BUFFER_CACHE.items():
        print(f"\n>>> Buffer ID: {int(bid)} | Name: {data['name']}")
        print("```yaml")
        print("\n".join(data['content']))
        print("```")

def run():
    if hasattr(pyrenderdoc, 'Replay'):
        manager = pyrenderdoc.Replay()
        manager.BlockInvoke(analyze_main)

run()