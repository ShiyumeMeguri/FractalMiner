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

# --- 1. 新增功能：Clear 辅助函数 ---
def find_clear_values(controller, action):
    try:
        sd_file = controller.GetStructuredFile()
        if not sd_file or not sd_file.chunks:
            return None
        
        target_chunk = None
        chunk_list = sd_file.chunks
        
        # 1. 尝试精确定位 Chunk
        for ev in action.events:
            if ev.eventId == action.eventId:
                if ev.chunkIndex < len(chunk_list):
                    target_chunk = chunk_list[ev.chunkIndex]
                break
        
        # 2. 兜底策略：如果 Action ID 没对上，取该 Action 的最后一个 Event
        # (针对 Clear 操作，这通常是正确的)
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
            
            # --- [Color 提取逻辑] ---
            # 匹配名字：ColorRGBA (D3D11) 或包含 color 的参数
            if "color" in name_lower:
                # [情况 A] 数据直接在 f32v 数组里 (Standard)
                if hasattr(val_data, 'f32v') and len(val_data.f32v) >= 4:
                    result['color'] = tuple(val_data.f32v[:4])
                    
                # [情况 B] 数据在 u32v 数组里 (Integer RenderTargets)
                elif hasattr(val_data, 'u32v') and len(val_data.u32v) >= 4:
                    result['color'] = tuple(val_data.u32v[:4])

                # [情况 C] 数据是结构体，包含子节点 (Fixed Issue)
                elif param.NumChildren() >= 4:
                    try:
                        temp_color = []
                        for k in range(4):
                            child = param.GetChild(k)
                            # 尝试读取 basic.f (float) 或 basic.d (double)
                            if hasattr(child.data, 'basic'):
                                if hasattr(child.data.basic, 'f'):
                                    temp_color.append(child.data.basic.f)
                                elif hasattr(child.data.basic, 'd'):
                                    temp_color.append(child.data.basic.d)
                        
                        if len(temp_color) == 4:
                            result['color'] = tuple(temp_color)
                    except:
                        pass 

            # --- [Depth 提取逻辑] ---
            if "depth" in name_lower:
                if hasattr(val_data, 'basic'):
                    if hasattr(val_data.basic, 'f'): result['depth'] = val_data.basic.f
                    elif hasattr(val_data.basic, 'd'): result['depth'] = val_data.basic.d
                elif hasattr(val_data, 'f32v') and len(val_data.f32v) > 0:
                    result['depth'] = val_data.f32v[0]

            # --- [Stencil 提取逻辑] ---
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
        print(f"      [Warning] Failed to parse SDChunk: {e}")
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

# --- 3. 核心：打印管线状态 (还原了被删除的 Topology/Viewport/Stencil/DetailedBlend) ---
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
            print(f"    (No active Render Targets output)")
            
    except Exception as e:
        print(f"  [Blend State] Error: {e}")

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

# --- 5. 单个Event分析逻辑 (合并了新旧逻辑) ---
def process_event(controller, event_id, action_map):
    controller.SetFrameEvent(event_id, True)
    state = controller.GetPipelineState()
    
    print(f"\n{'='*60}")
    print(f">>> [Event {event_id}] Pipeline Analysis")
    print(f"{'='*60}")
    
    # --- 新增：Clear 检测逻辑 ---
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
            print(f"  (Note: Pipeline state below is preserved from previous draws)")
    else:
        print(f"  [Action Info] Not found in Action Tree")

    # 5.1 打印管线状态 (使用原有详细逻辑)
    print_pipeline_details(state)
    
    # 5.2 遍历 Shader 阶段 (还原了被删除的 Geometry/Hull/Domain 支持)
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

        # 如果是 Clear 事件，使用简化输出 (保留"修改后"的特性，避免 Clear 时打印无用 Shader)
        if is_clear:
            print(f"\n  [{stage_name}] (Bound but unused)")
            print(f"    ID: {int(shader_id)}")
            continue

        # --- 正常 Shader 处理 (还原原有详细逻辑) ---
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

# --- 6. 主逻辑 ---
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

    # 构建 Action Map (新功能)
    print("Preparing Action Map...")
    action_map = {}
    try:
        root_actions = controller.GetRootActions()
        flatten_actions(root_actions, action_map)
    except: print("Warning: Failed to map actions.")

    # 1. 收集引用
    for eid in target_eids:
        try:
            process_event(controller, eid, action_map)
        except Exception as e:
            print(f"Error processing event {eid}: {e}")

    # 2. 打印去重后的 Shader (还原了无截断的完整输出)
    print("\n" + "#"*60)
    print(" # REFERENCE: UNIQUE SHADER CODES")
    print(" # (Full output, no truncation)")
    print("#"*60)

    for sid, data in SHADER_CACHE.items():
        print(f"\n>>> Shader ID: {int(sid)} ({data['stage']}) | File: {data['filename']}")
        print("```glsl")
        print(data['content'])
        print("```")

    # 3. 打印去重后的 Buffer (还原了原有格式)
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