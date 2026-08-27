import renderdoc as rd
import qrenderdoc as qrd
import sys

# ==========================================
# [设置] 0 = 当前选中Event; "10-30" = 范围; "7-10,15-19" = 组合
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
                    except Exception as e:
                        print(f"[Error] Failed to extract color child: {e}")

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
        print(f"[Error] find_clear_values failed: {e}")
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
    except Exception as e:
        print(f"[Error] get_res_display_info failed: {e}")
    return f"Res_{int(rid)}"

# --- 3. 核心：打印管线状态 ---
def print_pipeline_details(controller, state):
    # 2.1 Topology
    try:
        topo = state.GetPrimitiveTopology()
        print(f"  [Input Assembly]")
        print(f"    Topology: {topo}")
    except Exception as e:
        print(f"  [Input Assembly] Error: {e}")

    # 2.2 Rasterizer State (API Specific)
    print(f"  [Rasterizer State]")
    try:
        if state.IsCaptureD3D11():
            d3d11 = controller.GetD3D11PipelineState()
            rs = d3d11.rasterizer.state
            
            cull = str(rs.cullMode).split('.')[-1]
            fill = str(rs.fillMode).split('.')[-1]
            front = "CCW" if rs.frontCCW else "CW"
            
            print(f"    Cull: {cull} | Fill: {fill} | Front: {front}")
            print(f"    DepthClip: {rs.depthClip} | MSAA: {rs.multisampleEnable} | ScissorEnable: {rs.scissorEnable}")
            print(f"    DepthBias: {rs.depthBias} | Clamp: {rs.depthBiasClamp:.4f} | Slope: {rs.slopeScaledDepthBias:.4f}")
        else:
            print(f"    (Generic) Detail fetch not implemented for non-D3D11 API yet")
    except Exception as e:
        print(f"    Error fetching RS state: {e}")

    # 2.3 Viewports & Scissors (Multi-slot)
    try:
        print(f"  [Viewports & Scissors]")
        printed_vp = False
        # 现代API通常支持多个VP (e.g. D3D11 supports 16)
        for i in range(16):
            vp = state.GetViewport(i)
            sc = state.GetScissor(i)
            
            # 简单判断有效性：宽高不全为0
            if vp.width == 0 and vp.height == 0 and sc.width == 0 and sc.height == 0:
                continue
            
            printed_vp = True
            print(f"    [{i}] VP: {vp.x:.1f},{vp.y:.1f} {vp.width:.1f}x{vp.height:.1f} Z:{vp.minDepth}-{vp.maxDepth}")
            print(f"        SC: {sc.x},{sc.y} {sc.width}x{sc.height}")
        
        if not printed_vp:
            print(f"    (No active viewports)")
    except Exception as e:
        print(f"  [Viewports] Error: {e}")

    # 2.4 Depth State (API Specific for Func/Write)
    print(f"  [Depth State]")
    try:
        if state.IsCaptureD3D11():
            d3d11 = controller.GetD3D11PipelineState()
            ds = d3d11.outputMerger.depthStencilState
            
            func = str(ds.depthFunction).split('.')[-1]
            print(f"    Test: {ds.depthEnable} | Write: {ds.depthWrites} | Func: {func}")
        else:
            # Fallback to whatever generic info is available, though minimal
            print(f"    (Generic) Detail fetch not implemented for non-D3D11 API yet")
    except Exception as e:
        print(f"    Error fetching Depth state: {e}")

    # 2.5 Stencil State
    try:
        front, back = state.GetStencilFaces()
        print(f"  [Stencil State]")
        
        def fmt_face(name, face):
            ref = getattr(face, 'reference', '?')
            cmask = getattr(face, 'compareMask', 0)
            wmask = getattr(face, 'writeMask', 0)
            func = str(getattr(face, 'function', '?')).split('.')[-1]
            pass_op = str(getattr(face, 'passOperation', '?')).split('.')[-1]
            fail_op = str(getattr(face, 'failOperation', '?')).split('.')[-1]
            zfail_op = str(getattr(face, 'depthFailOperation', '?')).split('.')[-1]
            
            print(f"    [{name}] Ref:{ref} Mask:0x{cmask:02X} Write:0x{wmask:02X} Func:{func}")
            print(f"       Op: Pass={pass_op} Fail={fail_op} ZFail={zfail_op}")

        fmt_face("Front", front)
        fmt_face("Back ", back)
    except Exception as e:
        print(f"  [Stencil State] Error: {e}")

    # 2.6 Blend State
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
                    # 精简输出
                    src_c = str(cb.source).split('.')[-1]
                    dst_c = str(cb.destination).split('.')[-1]
                    op_c  = str(cb.operation).split('.')[-1]
                    
                    src_a = str(ab.source).split('.')[-1]
                    dst_a = str(ab.destination).split('.')[-1]
                    op_a  = str(ab.operation).split('.')[-1]

                    print(f"      Color: {src_c} {op_c} {dst_c}")
                    print(f"      Alpha: {src_a} {op_a} {dst_a}")
                
                if rt.logicOperationEnabled:
                    print(f"      LogicOp: {rt.logicOperation}")

        if not printed_any_rt:
            print(f"    (No active Blend configs)")
            
    except Exception as e:
        print(f"  [Blend State] Error: {e}")

    # --- 2.7 Render Targets (Output Textures) ---
    try:
        targets = state.GetOutputTargets()
        depth_target = state.GetDepthTarget()
        print(f"  [Render Targets (Outputs)]")
        
        # Depth
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
        try: 
            name = action.GetName(controller.GetStructuredFile())
        except Exception as e:
            print(f"  [Warning] Failed to get action name: {e}")
            name = action.customName if action.customName else f"Action {action.eventId}"
        
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
        
        # === Input Textures (SRVs) 处理 ===
        try:
            ro_resources = state.GetReadOnlyResources(stage_enum)
            if ro_resources and len(ro_resources) > 0:
                res_map = {}
                if reflection and reflection.readOnlyResources:
                    for r in reflection.readOnlyResources:
                        res_map[r.fixedBindNumber] = r.name
                
                printed_header = False
                for i, bind_res in enumerate(ro_resources):
                    actual_desc = bind_res.descriptor
                    
                    if actual_desc.resource != rd.ResourceId.Null():
                        if not printed_header:
                            print(f"    [Bound Resources (Textures/SRVs)]")
                            printed_header = True
                        
                        r_name = get_res_display_info(controller, actual_desc.resource)
                        var_name = res_map.get(i, f"Slot {i}")
                        print(f"      - {var_name} -> ID: {int(actual_desc.resource)} | {r_name}")
        except Exception as e:
            print(f"    [Bound Resources] Error: {e}")

        # === [新增] Input/Output Resources (UAVs) ===
        # 支持 Compute Shader 和 Pixel Shader 的 UAV 绑定
        try:
            rw_resources = state.GetReadWriteResources(stage_enum)
            if rw_resources and len(rw_resources) > 0:
                res_map = {}
                if reflection and hasattr(reflection, 'readWriteResources'):
                    for r in reflection.readWriteResources:
                        res_map[r.fixedBindNumber] = r.name
                
                printed_header = False
                for i, bind_res in enumerate(rw_resources):
                    actual_desc = bind_res.descriptor
                    if actual_desc.resource != rd.ResourceId.Null():
                        if not printed_header:
                            print(f"    [Read-Write Resources (UAVs)]")
                            printed_header = True
                        
                        r_name = get_res_display_info(controller, actual_desc.resource)
                        var_name = res_map.get(i, f"Slot {i}")
                        print(f"      - {var_name} -> ID: {int(actual_desc.resource)} | {r_name}")
        except Exception as e:
            print(f"    [Read-Write Resources] Error: {e}")

# --- 6. 主逻辑 ---
def analyze_main(controller):
    global BUFFER_CACHE, SHADER_CACHE
    BUFFER_CACHE.clear()
    SHADER_CACHE.clear()
    
    target_eids = []
    
    # Mode 1: Auto (Current Event) - Only if explicitly "0"
    if TARGET_RANGE.strip() == "0":
        if hasattr(pyrenderdoc, 'CurEvent'):
            target_eids = [pyrenderdoc.CurEvent()]
    
    # Mode 2: Explicit List/Ranges (e.g., "7-10,15,20-22")
    else:
        parts = TARGET_RANGE.split(',')
        for part in parts:
            part = part.strip()
            if not part: 
                continue
            
            if "-" in part:
                try:
                    range_split = part.split("-")
                    if len(range_split) == 2:
                        start, end = int(range_split[0]), int(range_split[1])
                        target_eids.extend(range(start, end + 1))
                    else:
                        print(f"Warning: Invalid range format ignored: {part}")
                except Exception as e:
                    print(f"Warning: Could not parse range: {part}, Error: {e}")
            else:
                try:
                    target_eids.append(int(part))
                except Exception as e:
                    print(f"Warning: Could not parse ID: {part}, Error: {e}")

    # Deduplicate and sort
    target_eids = sorted(list(set(target_eids)))

    print("Preparing Action Map...")
    action_map = {}
    try:
        root_actions = controller.GetRootActions()
        flatten_actions(root_actions, action_map)
    except Exception as e: 
        print(f"Warning: Failed to map actions. Error: {e}")

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