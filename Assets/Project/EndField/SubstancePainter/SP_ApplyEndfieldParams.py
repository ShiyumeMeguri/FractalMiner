"""
SP_ApplyEndfieldParams.py — Substance Painter 插件 / 控制台工具
================================================================

把 BuildSPInputs.py 生成的 SPShaderParams.json (Unity .mat → EndField_Uber.glsl
精确参数表) 批量应用到 SP 的 shader instance 上。

这是 endfield_auto_textures.py 插件 (推荐) 的控制台备用版 — 只做 shader 阶段
(实例/参数/sampler 贴图), 不动 layer stack 的引擎通道。两者用同一套流程:

    1. 资源库搜索 EndField_Uber; 找不到 → 从 SHADER_GLSL_PATH 自动导入。
    2. alg.shaders.shaderInstancesToObject() 快照。实测格式 (与导出对话框 JSON 相同):
           {
             "format":      {"version": "1.0"},
             "shaders":     { "<实例名>": {"shader": "<shader文件名>",
                                           "shaderInstance": "<实例名>", ...} },
             "texturesets": { "<材质球名>": {"shader": "<实例名>"} },
           }
       为每个材质补建同名实例 + 绑定, shaderInstancesFromObject() 应用
       (官方文档: Painter 会自动创建缺失实例并指派给对应 texture set)。
    3. 逐实例 alg.shaders.updateShaderInstance(id, url) 切到 EndField_Uber,
       alg.shaders.setParameters(id, {...}) 写入 uniforms + sampler 贴图 url。
    4. 重新快照验证, 打 ✓/✗。幂等, 可重复执行。

安装 (二选一):
    A. 插件: 复制本文件到 SP 的 python/plugins 目录, SP 菜单 Python → 重新加载,
       然后 Plugins 菜单 → "Endfield: Apply Shader Params" 选 json。
    B. 控制台: SP Python 控制台里
           import sys; sys.path.append(r"D:/Ruri/00.Model/Project/SubstancePaint/Tools")
           import SP_ApplyEndfieldParams as ap
           ap.apply(r"D:/.../SPOutput/<char>/SPShaderParams.json")
"""

from __future__ import annotations

import json
import os

try:
    import substance_painter.js as _js
    import substance_painter.logging as _splog
    import substance_painter.resource as _spres
    _IN_SP = True
except ImportError:  # 脱离 SP 跑 (仅语法检查)
    _IN_SP = False

_PLUGIN_NAME = 'Endfield: Apply Shader Params'
SHADER_NAME = 'EndField_Uber'
SHADER_GLSL_PATH = r'D:\Ruri\00.Model\Project\SubstancePaint\Shader\EndField_Uber.glsl'


def _info(msg: str) -> None:
    if _IN_SP:
        _splog.info(f'[EndfieldParams] {msg}')
    else:
        print(f'[EndfieldParams] {msg}')


def _warn(msg: str) -> None:
    if _IN_SP:
        _splog.warning(f'[EndfieldParams] {msg}')
    else:
        print(f'[EndfieldParams][WARN] {msg}')


def _eval_js(expr: str):
    return _js.evaluate(expr)


def _eval_obj(expr: str):
    """evaluate 返回 dict/list 直接用; 返回 JSON 字符串则解析。"""
    raw = _eval_js(expr)
    if isinstance(raw, str):
        return json.loads(raw)
    return raw


# ----------------------------------------------------------------------------
# 资源工具 (identifier 新旧 API 双兼容)
# ----------------------------------------------------------------------------
def _rid(resource):
    attr = getattr(resource, 'identifier', None)
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


def _resource_url(resource):
    try:
        rid = _rid(resource)
        url = _rid_field(rid, 'url')
        return url if url else str(rid)
    except Exception:
        return None


def find_endfield_shader():
    """资源库搜 EndField_Uber; 找不到从磁盘自动导入 (session)。"""
    for query in ('u:shader ' + SHADER_NAME, SHADER_NAME):
        try:
            for r in _spres.search(query):
                try:
                    name = _rid_field(_rid(r), 'name') or ''
                    if SHADER_NAME.lower() in str(name).lower():
                        return r
                except Exception:
                    pass
        except Exception:
            pass
    if os.path.isfile(SHADER_GLSL_PATH):
        usage = getattr(_spres.Usage, 'SHADER', None)
        if usage is not None:
            try:
                r = _spres.import_session_resource(SHADER_GLSL_PATH, usage)
                _info(f'shelf 未找到 {SHADER_NAME}, 已从磁盘导入: {SHADER_GLSL_PATH}')
                return r
            except Exception as e:
                _warn(f'自动导入 shader 失败: {e}')
    return None


def _import_texture(path: str):
    """磁盘贴图 → project resource, 返回资源 url (重复运行按名重用)。"""
    stem = os.path.splitext(os.path.basename(path))[0]
    try:
        for r in _spres.search(stem):
            try:
                rid = _rid(r)
                if _rid_field(rid, 'name') == stem and _rid_field(rid, 'context') == 'project':
                    return _resource_url(r)
            except Exception:
                pass
    except Exception:
        pass
    usage = getattr(_spres.Usage, 'TEXTURE', None) or getattr(_spres.Usage, 'IMAGE', None)
    try:
        return _resource_url(_spres.import_project_resource(path, usage))
    except Exception as e:
        _warn(f'  贴图导入失败 {path}: {e}')
        return None


# ----------------------------------------------------------------------------
# 主流程
# ----------------------------------------------------------------------------
def apply(json_path: str | None = None, assign_textures: bool = True) -> bool:
    """主入口: 读 SPShaderParams.json → 建实例/绑定/切 shader/写参/验证。
    返回 True = 全部材质验证通过。"""
    if not _IN_SP:
        print('Not inside Substance Painter — nothing to do.')
        return False

    if json_path is None:
        json_path = _ask_file()
        if not json_path:
            _warn('no json selected')
            return False
    if not os.path.isfile(json_path):
        _warn(f'json not found: {json_path}')
        return False

    with open(json_path, 'r', encoding='utf-8') as f:
        data = json.load(f)
    base_dir = os.path.dirname(os.path.abspath(json_path))
    _info(f'loaded {len(data)} material(s) from {json_path}')

    # ---- payload: uniforms + sampler 贴图 url ----
    payloads: dict = {}
    for mat_name, entry in data.items():
        params = dict(entry.get('uniforms', {}))
        # Face 脸基轴安全网: SP 世界空间默认 (rip FBX 面朝 -Z); 旧 params.json 漏键时兜底,
        # setdefault 只补缺不覆盖, 不会对 BuildSPInputs 已翻 Z 的值二次翻转。
        try:
            _is_face = int(params.get('u_CharaPart', -1)) == 1
        except (TypeError, ValueError):
            _is_face = False
        if _is_face:
            params.setdefault('_FaceForward', [0.0, 0.0, 0.0])  # (0,0,0)=关前后SDF扫描 (见 BuildSPInputs 注释)
            params.setdefault('_FaceRight', [1.0, 0.0, 0.0])
        if assign_textures:
            for sampler, rel in entry.get('texture_params', {}).items():
                tex_path = os.path.normpath(os.path.join(base_dir, rel))
                if not os.path.isfile(tex_path):
                    _warn(f'  texture missing on disk: {tex_path}')
                    continue
                url = _import_texture(tex_path)
                if url:
                    params[sampler] = url
        payloads[mat_name] = params

    # ---- shader 资源 ----
    shader_res = find_endfield_shader()
    if shader_res is None:
        _warn(f'找不到 {SHADER_NAME} 且自动导入失败 — 请手动导入 {SHADER_GLSL_PATH} 后重跑')
        return False
    shader_url = _resource_url(shader_res)
    _info(f'shader 资源: {shader_url}')

    def snapshot():
        obj = _eval_obj('alg.shaders.shaderInstancesToObject()')
        if not isinstance(obj, dict):
            raise ValueError(f'shaderInstancesToObject 返回 {type(obj).__name__}')
        return obj

    # ---- 1) 快照 + 补建同名实例 + 绑定 ----
    try:
        obj = snapshot()
    except Exception as e:
        _warn(f'shaderInstancesToObject 失败: {e}')
        return False
    shaders_map = obj.setdefault('shaders', {})
    ts_map = obj.setdefault('texturesets', {})

    known_sets = set(ts_map.keys())
    skipped = [m for m in payloads if m not in known_sets]
    for m in skipped:
        _info(f'skip "{m}" (工程里没有同名 texture set)')
    targets = {m: p for m, p in payloads.items() if m in known_sets}
    if not targets:
        _warn('没有任何材质与工程 texture set 同名 — 检查 json 是否对应当前工程')
        return False

    created, rebound = [], []
    for mat_name in sorted(targets):
        if not isinstance(shaders_map.get(mat_name), dict):
            shaders_map[mat_name] = {'shader': SHADER_NAME, 'shaderInstance': mat_name}
            created.append(mat_name)
        binding = ts_map.get(mat_name)
        if not isinstance(binding, dict):
            ts_map[mat_name] = {'shader': mat_name}
            rebound.append(mat_name)
        elif binding.get('shader') != mat_name:
            binding['shader'] = mat_name
            rebound.append(mat_name)

    if created or rebound:
        try:
            _eval_js(f'alg.shaders.shaderInstancesFromObject({json.dumps(obj)})')
        except Exception as e:
            # 兜底: 新实例先克隆现有实例的 shader 名建出来, 下一步统一切换
            template = next((v.get('shader') for k, v in shaders_map.items()
                             if isinstance(v, dict) and v.get('shader') and k not in created), None)
            if template:
                for m in created:
                    shaders_map[m]['shader'] = template
                try:
                    _eval_js(f'alg.shaders.shaderInstancesFromObject({json.dumps(obj)})')
                except Exception as e2:
                    _warn(f'shaderInstancesFromObject 失败: {e2}')
                    return False
            else:
                _warn(f'shaderInstancesFromObject 失败: {e}')
                return False
        _info(f'实例结构已应用: 新建 {len(created)}, 重绑 {len(rebound)}')

    # ---- 2) 实例 id ----
    try:
        instances = _eval_obj('alg.shaders.instances()')
    except Exception as e:
        _warn(f'alg.shaders.instances() 失败: {e}')
        return False
    by_label = {str(i.get('label', '')): i for i in instances or [] if isinstance(i, dict)}

    # ---- 3) 切 shader + 写参 ----
    all_ok = True
    for mat_name, params in sorted(targets.items()):
        inst = by_label.get(mat_name)
        if inst is None:
            _warn(f'◆ {mat_name}: FromObject 后仍无同名实例')
            all_ok = False
            continue
        iid = inst.get('id')
        ident = f"{inst.get('shader', '')} {inst.get('url', '')}"
        inst_url = str(inst.get('url', '') or '')
        if SHADER_NAME.lower() not in ident.lower() or (shader_url and inst_url and inst_url != shader_url):
            try:
                _eval_js(f'alg.shaders.updateShaderInstance({json.dumps(iid)}, {json.dumps(shader_url)})')
            except Exception as e:
                _warn(f'◆ {mat_name}: updateShaderInstance 失败: {e}')
                all_ok = False
                continue
        ok_keys, bad_keys = [], []
        try:
            _eval_js(f'alg.shaders.setParameters({json.dumps(iid)}, {json.dumps(params)})')
            ok_keys = list(params.keys())
        except Exception:
            for key, value in params.items():
                try:
                    _eval_js(f'alg.shaders.setParameters({json.dumps(iid)}, '
                             f'{json.dumps({key: value})})')
                    ok_keys.append(key)
                except Exception:
                    bad_keys.append(key)
        if bad_keys:
            all_ok = False
        _info(f'◆ {mat_name}: 实例#{iid} 写入 {len(ok_keys)}/{len(params)} 参数'
              + (f'; 失败: {", ".join(bad_keys)}' if bad_keys else ''))

    # ---- 4) 验证 ----
    try:
        final = snapshot()
        f_shaders = final.get('shaders', {}) or {}
        f_ts = final.get('texturesets', {}) or {}
        for mat_name in sorted(targets):
            bound = (f_ts.get(mat_name) or {}).get('shader')
            shader_name = str((f_shaders.get(bound) or {}).get('shader', ''))
            good = bound == mat_name and SHADER_NAME.lower() in shader_name.lower()
            if not good:
                all_ok = False
            _info(f'{"✓" if good else "✗"} {mat_name}: 绑定实例「{bound}」shader「{shader_name}」')
    except Exception as e:
        _warn(f'验证失败: {e}')
        all_ok = False

    _info('done. ' + ('全部通过 ✓' if all_ok else '存在失败项 ✗ — 幂等操作, 可直接重跑补齐'))
    return all_ok


def _ask_file() -> str | None:
    try:
        try:
            from PySide6 import QtWidgets  # SP 10+
        except ImportError:
            from PySide2 import QtWidgets  # SP 7-9
        path, _ = QtWidgets.QFileDialog.getOpenFileName(
            None, 'Select SPShaderParams.json', '', 'JSON (*.json)')
        return path or None
    except Exception as e:
        _warn(f'file dialog unavailable: {e}; call apply(r"path/to/SPShaderParams.json")')
        return None


# ----------------------------------------------------------------------------
# SP 插件入口 (可选 — 控制台 import 使用不需要)
# ----------------------------------------------------------------------------
_action = None


def start_plugin():
    global _action
    try:
        try:
            from PySide6 import QtWidgets
        except ImportError:
            from PySide2 import QtWidgets
        import substance_painter.ui as _ui
        _action = QtWidgets.QAction(_PLUGIN_NAME)
        _action.triggered.connect(lambda: apply(None))
        _ui.add_plugins_menu_action(_action)
        _info('plugin menu registered')
    except Exception as e:
        _warn(f'menu registration failed ({e}); use console: '
              f'import SP_ApplyEndfieldParams; SP_ApplyEndfieldParams.apply(r"...json")')


def close_plugin():
    global _action
    if _action is not None:
        try:
            import substance_painter.ui as _ui
            _ui.delete_ui_element(_action)
        except Exception:
            pass
        _action = None


if __name__ == '__main__':
    print(__doc__)
