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

# --- 1. 辅助函数 ---
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
        fmt_str = "{:.4f}"
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
                    row_vals.append("{:.3f}".format(val_data))
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
    # 简单获取名称，避免大量API调用
    resources = controller.GetResources()
    for r in resources:
        if r.resourceId == rid:
            return r.name
    return f"Res_{int(rid)}"

# --- 2. 获取 Shader 代码 (源文件 或 反汇编) ---
def fetch_shader_code(controller, shader_id, reflection, stage_name):
    fname = "Unknown"
    code = ""
    
    # 1. 尝试获取源码
    if reflection and reflection.debugInfo and reflection.debugInfo.files:
        f = reflection.debugInfo.files[0]
        fname = f.filename
        code = f.contents
    
    # 2. 源码失败，尝试反汇编
    if not code or len(code) == 0:
        fname = f"Disassembly ({stage_name})"
        try:
            # 这是一个耗时操作，但只会对每个Shader做一次
            code = controller.DisassembleShader(shader_id, reflection, "")
        except Exception as e:
            code = f"// Disassembly failed: {e}"

    return fname, code

# --- 3. 单个Event分析逻辑 ---
def process_event(controller, event_id):
    controller.SetFrameEvent(event_id, True)
    state = controller.GetPipelineState()
    
    print(f"\n>>> [Event {event_id}]")
    
    stages = [
        (rd.ShaderStage.Vertex, "Vertex Shader"),
        (rd.ShaderStage.Pixel, "Pixel Shader"),
        (rd.ShaderStage.Compute, "Compute Shader"),
    ]
    
    for stage_enum, stage_name in stages:
        shader_id = state.GetShader(stage_enum)
        if shader_id == rd.ResourceId.Null():
            continue
            
        pipe_id = state.GetComputePipelineObject() if stage_enum == rd.ShaderStage.Compute else state.GetGraphicsPipelineObject()
        reflection = state.GetShaderReflection(stage_enum)
        entry = reflection.entryPoint if reflection else "main"

        # === Shader 处理 (去重) ===
        # 无论如何，先记录这个 Event 用了这个 Shader ID
        if shader_id not in SHADER_CACHE:
            fname, code = fetch_shader_code(controller, shader_id, reflection, stage_name)
            SHADER_CACHE[shader_id] = {
                "stage": stage_name,
                "filename": fname,
                "content": code
            }
        
        cached_shader = SHADER_CACHE[shader_id]
        print(f"  [{stage_name}]")
        print(f"    Ref ShaderID: {int(shader_id)} | File: {cached_shader['filename']}")

        # === Constant Buffer 处理 (去重) ===
        cblocks = state.GetConstantBlocks(stage_enum)
        if reflection and reflection.constantBlocks:
            for i, cb_refl in enumerate(reflection.constantBlocks):
                slot = cb_refl.fixedBindNumber
                if slot < 0: slot = i
                
                if slot < len(cblocks):
                    desc = cblocks[slot].descriptor
                    buf_id = desc.resource
                    
                    if buf_id != rd.ResourceId.Null():
                        res_name = get_res_display_info(controller, buf_id)
                        print(f"    - Slot {slot} ({cb_refl.name}) -> BufferID: {int(buf_id)} | {res_name}")
                        
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

# --- 4. 主逻辑 ---
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

    print(f"# Context Analysis | Events: {target_eids}")

    # 1. 收集引用
    for eid in target_eids:
        process_event(controller, eid)

    print("\n" + "="*40)
    print(" === UNIQUE SHADER CODES ===")
    print("="*40)

    # 2. 打印去重后的 Shader
    for sid, data in SHADER_CACHE.items():
        print(f"\n>>> Shader ID: {int(sid)} ({data['stage']}) | File: {data['filename']}")
        print("```glsl")
        code_lines = data['content'].split('\n')
        # 限制行数防止AI上下文爆炸，但给足够多
        if len(code_lines) > 300:
            print("\n".join(code_lines[:300]))
            print(f"\n// ... Truncated {len(code_lines)-300} lines ...")
        else:
            print(data['content'])
        print("```")

    print("\n" + "="*40)
    print(" === UNIQUE BUFFER CONTENTS ===")
    print("="*40)
    
    # 3. 打印去重后的 Buffer
    for bid, data in BUFFER_CACHE.items():
        print(f"\n>>> Buffer ID: {int(bid)} | Name: {data['name']}")
        print("```yaml")
        if len(data['content']) > 200:
            print("\n".join(data['content'][:200]))
            print(f"# ... Truncated {len(data['content'])-200} lines ...")
        else:
            print("\n".join(data['content']))
        print("```")

def run():
    if hasattr(pyrenderdoc, 'Replay'):
        manager = pyrenderdoc.Replay()
        manager.BlockInvoke(analyze_main)

run()