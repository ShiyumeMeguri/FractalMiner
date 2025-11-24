import renderdoc as rd
import qrenderdoc as qrd
import sys

# ==========================================
# [??] 0 = ????Event; "10-30" = ??
TARGET_RANGE = "0"  
# ==========================================

# ?????????Buffer???????
# Key: ResourceId, Value: {"name": str, "content": str, "size": int}
BUFFER_CACHE = {}

# --- 1. ???? ---
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
        
        # ?????
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

        # Matrix
        if rows > 1: 
            lines = []
            for r in range(rows):
                row_vals = []
                for c in range(cols):
                    idx = r * cols + c
                    if idx < len(data_source):
                        row_vals.append("{:.3f}".format(data_source[idx]))
                    else:
                        row_vals.append("0.0")
                lines.append(f"[{', '.join(row_vals)}]")
            return "\n      " + "\n      ".join(lines)
        # Vector
        elif cols > 1: 
            vals = []
            for i in range(cols):
                if i < len(data_source):
                    vals.append(fmt_str.format(data_source[i]))
                else:
                    vals.append("0")
            return f"{type_prefix}{cols}({', '.join(vals)})"
        # Scalar
        else: 
            if len(data_source) > 0:
                return fmt_str.format(data_source[0])
            return "0"
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
            val_str = format_numeric(v)
            lines.append(f"{prefix}- {v.name}: {val_str}")
    return lines

def get_res_display_info(controller, rid):
    resources = controller.GetResources()
    # ??????????Map?????
    for r in resources:
        if r.resourceId == rid:
            return r.name
    return f"Res_{int(rid)}"

# --- 2. ??Event???? (???Buffer????????) ---
def process_event(controller, event_id):
    controller.SetFrameEvent(event_id, True)
    state = controller.GetPipelineState()
    
    print(f"\n>>> [Event {event_id}] Analysis")
    
    stages = [
        (rd.ShaderStage.Vertex, "Vertex Shader"),
        (rd.ShaderStage.Pixel, "Pixel Shader"),
        (rd.ShaderStage.Compute, "Compute Shader"),
    ]
    
    for stage_enum, stage_name in stages:
        shader_id = state.GetShader(stage_enum)
        if shader_id == rd.ResourceId.Null():
            continue

        print(f"  [{stage_name}]")
        
        # Pipeline & Reflection
        pipe_id = state.GetComputePipelineObject() if stage_enum == rd.ShaderStage.Compute else state.GetGraphicsPipelineObject()
        reflection = state.GetShaderReflection(stage_enum)
        entry = reflection.entryPoint if reflection else "main"
        
        # A. Source Code (??????????)
        fname = "Unknown"
        if reflection and reflection.debugInfo and reflection.debugInfo.files:
            fname = reflection.debugInfo.files[0].filename
        print(f"    File: {fname}")
        
        # B. Constant Buffers (????)
        cblocks = state.GetConstantBlocks(stage_enum)
        if reflection and reflection.constantBlocks:
            for i, cb_refl in enumerate(reflection.constantBlocks):
                slot = cb_refl.fixedBindNumber
                if slot < 0: slot = i
                
                if slot < len(cblocks):
                    desc = cblocks[slot].descriptor
                    buf_id = desc.resource
                    
                    if buf_id != rd.ResourceId.Null():
                        # ????
                        res_name = get_res_display_info(controller, buf_id)
                        print(f"    - Slot {slot} ({cb_refl.name}): -> Ref BufferID: {int(buf_id)} | Name: {res_name}")
                        
                        # ????Buffer????????????????
                        if buf_id not in BUFFER_CACHE:
                            try:
                                vars = controller.GetCBufferVariableContents(
                                    pipe_id, shader_id, stage_enum, entry, slot, 
                                    buf_id, desc.byteOffset, desc.byteSize
                                )
                                if vars:
                                    content_lines = extract_variables(vars)
                                    BUFFER_CACHE[buf_id] = {
                                        "name": res_name,
                                        "size": desc.byteSize,
                                        "content": content_lines
                                    }
                                else:
                                    BUFFER_CACHE[buf_id] = {"name": res_name, "content": ["(No readable vars)"], "size": desc.byteSize}
                            except Exception as e:
                                BUFFER_CACHE[buf_id] = {"name": res_name, "content": [f"Error: {e}"], "size": 0}
    
    # Output Targets (??)
    outputs = state.GetOutputTargets()
    valid_outs = []
    for i, out in enumerate(outputs):
        rid = get_resource_id_safe(out)
        if rid != rd.ResourceId.Null():
            valid_outs.append(f"Slot {i}: {get_res_display_info(controller, rid)}")
    if valid_outs:
        print(f"  [Outputs] {', '.join(valid_outs)}")

# --- 3. ??? ---
def analyze_main(controller):
    global BUFFER_CACHE
    BUFFER_CACHE.clear()
    
    # ????
    target_eids = []
    if TARGET_RANGE == "0":
        if hasattr(pyrenderdoc, 'CurEvent'):
            target_eids = [pyrenderdoc.CurEvent()]
    elif "-" in TARGET_RANGE:
        try:
            start, end = map(int, TARGET_RANGE.split("-"))
            target_eids = list(range(start, end + 1))
        except:
            print("Invalid range format.")
            return
    else:
        # ??????
        try:
            target_eids = [int(TARGET_RANGE)]
        except:
            pass

    print(f"AI Context Export | Range: {TARGET_RANGE} | Events: {len(target_eids)}")
    print("="*40)

    # ??1?????Event????????Buffer
    for eid in target_eids:
        process_event(controller, eid)

    print("\n" + "="*40)
    print(" DEDUPLICATED BUFFER CONTENTS (Referenced above)")
    print("="*40)
    
    # ??2?????Buffer??
    if not BUFFER_CACHE:
        print("(No Constant Buffers captured)")
    
    for rid, data in BUFFER_CACHE.items():
        print(f"\n>>> Buffer ID: {int(rid)} | Name: {data['name']} | Size: {data['size']} bytes")
        print("```yaml")
        if len(data['content']) > 200:
            print("\n".join(data['content'][:200]))
            print(f"\n# ... Truncated {len(data['content'])-200} lines ...")
        else:
            print("\n".join(data['content']))
        print("```")
        
    print("\n[End of Analysis]")

def run():
    if hasattr(pyrenderdoc, 'Replay'):
        manager = pyrenderdoc.Replay()
        manager.BlockInvoke(analyze_main)

run()