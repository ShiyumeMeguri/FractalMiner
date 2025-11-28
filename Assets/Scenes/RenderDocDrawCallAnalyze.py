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

# --- 1. Clear 辅助函数 ---
def find_clear_values(controller, action):
    try:
        sd_file = controller.GetStructuredFile()
        if not sd_file or not sd_file.chunks:
            return None
        
        target_chunk = None
        chunk_list = sd_file.chunks
        
        # 1. 尝试精确定位
        for ev in action.events:
            if ev.eventId == action.eventId:
                if ev.chunkIndex < len(chunk_list):
                    target_chunk = chunk_list[ev.chunkIndex]
                break
        
        # 2. 兜底策略
        if not target_chunk and len(action.events) > 0:
            target_chunk = chunk_list[action.events[-1].chunkIndex]
        
        if not target_chunk:
            return None

        result = {}
        
        # 3. 遍历参数
        count = target_chunk.NumChildren()
        for i in range(count):
            param = target_chunk.GetChild(i)
            name = param.name
            val_data = param.data
            name_lower = name.lower()
            
            # --- [View/Target ID 提取] ---
            if "view" in name_lower or "target" in name_lower:
                if hasattr(val_data, 'resourceId') and val_data.resourceId != rd.ResourceId.Null():
                    result['view_id'] = val_data.resourceId

            # --- [Color 提取] ---
            if "color" in name_lower:
                if hasattr(val_data, 'f32v') and len(val_data.f32v) >= 4:
                    result['color'] = tuple(val_data.f32v[:4])
                elif hasattr(val_data, 'u32v') and len(val_data.u32v) >= 4:
                    result['color'] = tuple(val_data.u32v[:4])
                elif param.NumChildren() >= 4:
                    try:
                        temp_color = []
                        for k in range(4):
                            child = param.GetChild(k)
                            if hasattr(child.data, 'basic'):
                                if hasattr(child.data.basic, 'f'): temp_color.append(child.data.basic.f)
                                elif hasattr(child.data.basic, 'd'): temp_color.append(child.data.basic.d)
                        if len(temp_color) == 4:
                            result['color'] = tuple(temp_color)
                    except: pass 

            # --- [Depth 提取] ---
            if "depth" in name_lower:
                if hasattr(val_data, 'basic'):
                    if hasattr(val_data.basic, 'f'): result['depth'] = val_data.basic.f
                    elif hasattr(val_data.basic, 'd'): result['depth'] = val_data.basic.d
                elif hasattr(val_data, 'f32v') and len(val_data.f32v) > 0:
                    result['depth'] = val_data.f32v[0]

            # --- [Stencil 提取] ---
            if "stencil" in name_lower:
                if hasattr(val_data, 'basic'):
                    if hasattr(val_data.basic, 'u'): result['stencil'] = val_data.basic.u
                    elif hasattr(val_data.basic, 'i'): result['stencil'] = val_data.basic.i
                elif hasattr(val_data, 'u8v') and len(val_data.u8v) > 0:
                    result['stencil'] = val_data.u8v[0]
                elif hasattr(val_data, 'u32v') and len(val_data.u32v) > 0:
                    result['stencil'] = val_data.u32v[0]

        return result
    except Exception as e:
        return None

def flatten_actions(actions, lookup_dict):
    for action in actions:
        lookup_dict[action.eventId] = action
        if action.children:
            flatten_actions(action.children, lookup_dict)

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

# --- 3. 核心：打印管线状态 ---
def print_pipeline_details(controller, state):
    # 2.1 Topology
    try:
        topo = state.GetPrimitiveTopology()
        print(f"  [Input Assembly]")
        print(f"    Topology: {topo}")
    except:
        pass

    # 2.2 Rasterizer
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

    # 2.4 Blend State
    try:
        blends = state.GetColorBlends()
        print(f"  [Blend State]")
        print(f"    Independent Blend: {state.IsIndependentBlendingEnabled()}")
        
        printed_any_rt = False
        for i, rt in enumerate(blends):
            is_enabled = rt.enabled
            write_mask = rt.writeMask
            
            if is_enabled or write_mask != 0:
                printed_any_rt = True
                print(f"    RT[{i}]: Enabled={is_enabled}, WriteMask=0x{write_mask:02X}")
                
                if is_enabled:
                    cb = rt.colorBlend
                    ab = rt.alphaBlend
                    print(f"      Color: Src={cb.source} {cb.operation} Dst={cb.destination}")
                    print(f"      Alpha: Src={ab.source} {ab.operation} Dst={ab.destination}")
                
                if rt.logicOperationEnabled:
                    print(f"      LogicOp: {rt.logicOperation}")

        if not printed_any_rt:
            print(f"    (No active Blend configs)")
            
    except Exception as e:
        print(f"  [Blend State] Error: {e}")

    # --- 2.5 Render Targets (Output Textures) ---
    try:
        targets = state.GetOutputTargets()
        depth_target = state.GetDepthTarget()
        print(f"  [Render Targets (Outputs)]")
        
        # Depth
        # 注意：Descriptor对象使用 .resource 获取 ResourceId
        if depth_target.resource != rd.ResourceId.Null():
            name = get_res_display_info(controller, depth_target.resource)
            print(f"    Depth Target: ID {int(depth_target.resource)} | {name}")
        else:
            print(f"    Depth Target: (Unbound)")
        
        # Colors
        printed_out = False
        for i, target in enumerate(targets):
            if target.resource != rd.ResourceId.Null():
                printed_out = True
                name = get_res_display_info(controller, target.resource)
                print(f"    RT[{i}]: ID {int(target.resource)} | {name}")
        
        if not printed_out:
            print(f"    (No active Color Outputs)")

    except Exception as e:
        print(f"  [Render Targets] Error: {e}")

# --- 4. 获取 Shader 代码 ---
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

# --- 5. 单个Event分析逻辑 ---
def process_event(controller, event_id, action_map):
    controller.SetFrameEvent(event_id, True)
    state = controller.GetPipelineState()
    
    print(f"\n{'='*60}")
    print(f">>> [Event {event_id}] Pipeline Analysis")
    print(f"{'='*60}")
    
    # --- Clear 检测 ---
    FlagsEnum = getattr(rd, 'ActionFlags', getattr(rd, 'DrawFlags', None))
    action = action_map.get(event_id)
    is_clear = False
    
    if action:
        try: name = action.GetName(controller.GetStructuredFile())
        except: name = action.customName if action.customName else f"Action {action.eventId}"
        print(f"  [Action Info] Name: {name}")
        
        flag_clear = False
        if FlagsEnum:
            flag_clear = bool(action.flags & (FlagsEnum.Clear | FlagsEnum.ClearDepthStencil))
        
        if flag_clear:
            is_clear = True
            print(f"  " + "!"*40)
            print(f"  [!] CLEAR OPERATION DETECTED")
            
            clear_vals = find_clear_values(controller, action)
            if clear_vals:
                if 'view_id' in clear_vals:
                    vid = clear_vals['view_id']
                    res_name = get_res_display_info(controller, vid)
                    print(f"      Target View: ID {int(vid)} | {res_name}")

                if 'color' in clear_vals:
                    c = clear_vals['color']
                    print(f"      Clear Color: ({c[0]:.4f}, {c[1]:.4f}, {c[2]:.4f}, {c[3]:.4f})")
                if 'depth' in clear_vals:
                    print(f"      Clear Depth: {clear_vals['depth']:.4f}")
                if 'stencil' in clear_vals:
                    print(f"      Clear Stencil: {clear_vals['stencil']}")
            else:
                print(f"      (Could not extract clear values)")
            print(f"  " + "!"*40)
    else:
        print(f"  [Action Info] Not found in Action Tree")

    # 5.1 打印管线状态
    print_pipeline_details(controller, state)
    
    # 5.2 遍历 Shader 阶段
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

        if is_clear:
            print(f"\n  [{stage_name}] (Bound but unused)")
            print(f"    ID: {int(shader_id)}")
            continue

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
                    # desc 是 Descriptor 类型，使用 .resource
                    buf_id = desc.resource
                    
                    if buf_id != rd.ResourceId.Null():
                        res_name = get_res_display_info(controller, buf_id)
                        print(f"      - Slot {slot} ({cb_refl.name}) -> BufferID: {int(buf_id)} | {res_name}")
                        
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
        
        # === [核心修复] Input Textures (SRVs) 处理 ===
        try:
            ro_resources = state.GetReadOnlyResources(stage_enum)
            if ro_resources and len(ro_resources) > 0:
                res_map = {}
                if reflection and reflection.readOnlyResources:
                    for r in reflection.readOnlyResources:
                        # 修复: 使用 fixedBindNumber 而不是 bindPoint
                        res_map[r.fixedBindNumber] = r.name
                
                printed_header = False
                for i, bind_res in enumerate(ro_resources):
                    # bind_res 是 Descriptor 类型，使用 .resource
                    if bind_res.resource != rd.ResourceId.Null():
                        if not printed_header:
                            print(f"    [Bound Resources (Textures/SRVs)]")
                            printed_header = True
                        
                        r_name = get_res_display_info(controller, bind_res.resource)
                        var_name = res_map.get(i, f"Slot {i}")
                        print(f"      - {var_name} -> ID: {int(bind_res.resource)} | {r_name}")
        except Exception as e:
            print(f"    [Bound Resources] Error: {e}")

# --- 6. 主逻辑 ---
def analyze_main(controller):
    global BUFFER_CACHE, SHADER_CACHE
    BUFFER_CACHE.clear()
    SHADER_CACHE.clear()
    
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

    print("Preparing Action Map...")
    action_map = {}
    try:
        root_actions = controller.GetRootActions()
        flatten_actions(root_actions, action_map)
    except: print("Warning: Failed to map actions.")

    for eid in target_eids:
        try:
            process_event(controller, eid, action_map)
        except Exception as e:
            print(f"Error processing event {eid}: {e}")

    print("\n" + "#"*60)
    print(" # REFERENCE: UNIQUE SHADER CODES")
    print(" # (Full output, no truncation)")
    print("#"*60)

    for sid, data in SHADER_CACHE.items():
        print(f"\n>>> Shader ID: {int(sid)} ({data['stage']}) | File: {data['filename']}")
        print("```glsl")
        print(data['content'])
        print("```")

    print("\n" + "#"*60)
    print(" # REFERENCE: UNIQUE BUFFER CONTENTS")
    print("#"*60)
    
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