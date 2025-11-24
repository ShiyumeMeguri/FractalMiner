import renderdoc as rd
import qrenderdoc as qrd

# --- 1. ???? Resource ID ---
def get_resource_id_safe(obj):
    if obj is None: return rd.ResourceId.Null()
    
    if hasattr(obj, 'resourceId'): return obj.resourceId
    if hasattr(obj, 'resource'): return obj.resource
    if hasattr(obj, 'descriptor'):
        desc = obj.descriptor
        if hasattr(desc, 'resource'): return desc.resource
            
    return rd.ResourceId.Null()

# --- 2. ????? (????: ??????????) ---
def format_numeric(variable):
    try:
        # ??????
        rows = variable.rows
        cols = variable.columns
        val = variable.value
        
        # [FIX] ????: ????????????? Enum ??????
        # variable.type ??? Enum ???str() ???? "VarType.Int" ? "Int"
        type_str = str(variable.type).lower()
        
        # ???? float
        data_source = val.f32v
        fmt_str = "{:.4f}"
        
        # ??????
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
        else:
            # Float case
            type_prefix = "vec"

        # ???? (Matrix)
        if rows > 1: 
            lines = []
            for r in range(rows):
                row_vals = []
                for c in range(cols):
                    # ??????
                    idx = r * cols + c
                    if idx < len(data_source):
                        row_vals.append("{:.3f}".format(data_source[idx]))
                    else:
                        row_vals.append("0.0")
                lines.append(f"[{', '.join(row_vals)}]")
            return "\n      " + "\n      ".join(lines)
            
        # ???? (Vector)
        elif cols > 1: 
            vals = []
            for i in range(cols):
                if i < len(data_source):
                    vals.append(fmt_str.format(data_source[i]))
                else:
                    vals.append("0")
            return f"{type_prefix}{cols}({', '.join(vals)})"
            
        # ???? (Scalar)
        else: 
            if len(data_source) > 0:
                return fmt_str.format(data_source[0])
            return "0"
            
    except Exception as e:
        # ??????????
        return f"? (Err: {e} | TypeStr: {str(variable.type)})"

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

# --- 3. ?????? ---
def analyze_data(controller):
    print("\n" + "="*20 + " COPY START " + "="*20)
    
    event_id = 0
    if hasattr(pyrenderdoc, 'CurEvent'):
        event_id = pyrenderdoc.CurEvent()
    
    print(f"# RenderDoc Context Analysis")
    print(f"**Event ID:** {event_id}")
    
    # === [??????] ===
    resources = controller.GetResources()
    name_map = {r.resourceId: r.name for r in resources}

    textures = controller.GetTextures()
    tex_det_map = {t.resourceId: t for t in textures}

    buffers = controller.GetBuffers()
    buf_det_map = {b.resourceId: b for b in buffers}

    def get_res_display_info(rid):
        name = name_map.get(rid, f"ID_{rid}")
        if not name or name == f"ID_{rid}": 
            name = name_map.get(rid, f"Res_{int(rid)}")
        
        details = "Unknown Type"
        fmt = "-"
        
        if rid in tex_det_map:
            tex = tex_det_map[rid]
            dim = f"{tex.width}x{tex.height}"
            if tex.depth > 1: dim += f"x{tex.depth}"
            if tex.arraysize > 1: dim += f"[{tex.arraysize}]"
            details = dim
            fmt = tex.format.Name()
        elif rid in buf_det_map:
            buf = buf_det_map[rid]
            details = f"{buf.length} bytes"
            fmt = "Buffer"
            
        return name, details, fmt

    state = controller.GetPipelineState()
    
    stages = [
        (rd.ShaderStage.Vertex, "Vertex Shader"),
        (rd.ShaderStage.Pixel, "Pixel Shader"),
        (rd.ShaderStage.Compute, "Compute Shader"),
    ]
    
    for stage_enum, stage_name in stages:
        shader_id = state.GetShader(stage_enum)
        if shader_id == rd.ResourceId.Null():
            continue

        print(f"\n## {stage_name}")
        
        # ?? Pipeline Object
        pipe_id = rd.ResourceId.Null()
        if stage_enum == rd.ShaderStage.Compute:
            pipe_id = state.GetComputePipelineObject()
        else:
            pipe_id = state.GetGraphicsPipelineObject()
        
        # --- A. Shader Code ---
        reflection = state.GetShaderReflection(stage_enum)
        entry_point = reflection.entryPoint if reflection else "main"
        
        code = None
        fname = "Unknown"
        if reflection and reflection.debugInfo and reflection.debugInfo.files:
            f = reflection.debugInfo.files[0]
            fname = f.filename
            code = f.contents
        
        if not code:
            fname = "Disassembly"
            try:
                code = controller.DisassembleShader(shader_id, reflection, "")
            except:
                code = "// Disassembly failed"

        print(f"> **Source:** {fname}")
        print("```glsl")
        if code:
            lines = code.split('\n')
            if len(lines) > 120:
                print("\n".join(lines[:120]))
                print(f"\n// ... Truncated {len(lines)-120} lines ...")
            else:
                print(code.strip())
        else:
            print("// No code")
        print("```")
        
        # --- B. Bound Textures ---
        print(f"\n### Bound Textures ({stage_name})")
        ro_resources = state.GetReadOnlyResources(stage_enum)
        
        found_tex = False
        if ro_resources:
            header_printed = False
            for i, res in enumerate(ro_resources):
                res_id = get_resource_id_safe(res)
                if res_id != rd.ResourceId.Null():
                    if not header_printed:
                        print("| Slot | Resource Name | Size | Format |")
                        print("| :--- | :--- | :--- | :--- |")
                        header_printed = True
                    found_tex = True
                    name, size, fmt = get_res_display_info(res_id)
                    print(f"| {i} | **{name}** | {size} | {fmt} |")
        
        if not found_tex:
            print("> No textures bound.")

        # --- C. Constant Buffers ---
        print(f"\n### Constant Buffers ({stage_name})")
        cblocks = state.GetConstantBlocks(stage_enum)
        
        found_cb = False
        if reflection and reflection.constantBlocks:
            for i, cb_refl in enumerate(reflection.constantBlocks):
                slot = cb_refl.fixedBindNumber
                if slot < 0 or slot > 1000: 
                    slot = i
                
                if slot < len(cblocks):
                    used_desc = cblocks[slot]
                    desc = used_desc.descriptor
                    
                    buf_id = desc.resource
                    byte_size = desc.byteSize
                    byte_offset = desc.byteOffset
                    
                    if buf_id != rd.ResourceId.Null() or byte_size > 0:
                        found_cb = True
                        print(f"\n#### Slot {slot}: {cb_refl.name}")
                        
                        name, size_str, _ = get_res_display_info(buf_id)
                        print(f"> Resource: **{name}** (Size: {byte_size} bytes, Offset: {byte_offset})")

                        try:
                            if buf_id != rd.ResourceId.Null():
                                vars = controller.GetCBufferVariableContents(
                                    pipe_id, shader_id, stage_enum, entry_point, slot, 
                                    buf_id, byte_offset, byte_size
                                )
                                if vars:
                                    print("```yaml")
                                    content = extract_variables(vars)
                                    if len(content) > 150:
                                        print("\n".join(content[:150]))
                                        print(f"# ... {len(content)-150} more lines ...")
                                    else:
                                        print("\n".join(content))
                                    print("```")
                                else:
                                    print("> (No variable data interpreted)")
                            else:
                                print("> (Buffer not backed by Resource ID)")
                        except Exception as e:
                            print(f"> Error reading content: {e}")
        
        if not found_cb:
            print("> No Constant Buffers.")

    # --- D. Output Targets ---
    print("\n## Output Targets")
    outputs = state.GetOutputTargets()
    print("| Slot | Resource Name | Size | Format |")
    print("| :--- | :--- | :--- | :--- |")
    for i, out in enumerate(outputs):
        out_id = get_resource_id_safe(out)
        if out_id != rd.ResourceId.Null():
            name, size, fmt = get_res_display_info(out_id)
            print(f"| {i} | **{name}** | {size} | {fmt} |")

    print("\n" + "="*20 + " COPY END " + "="*20 + "\n")

def run():
    if hasattr(pyrenderdoc, 'Replay'):
        manager = pyrenderdoc.Replay()
        try:
            manager.BlockInvoke(analyze_data)
        except Exception as e:
            import traceback
            print(f"? Error: {e}")
            traceback.print_exc()

run()