"""
binary_replace.py
用法示例：
    python binary_replace.py "ProcessHacker-2.39\x64" ProcessHacker
    # 如需自定义替换文本：
    python binary_replace.py <目录> <目标串> --replacement <替换串>
功能：
1. 在整个目录递归查找所有文件，以字节级方式不分大小写地搜索
   ANSI 及 UTF-16LE 编码的 <目标串>，并替换为 <替换串>（长度必须一致）。
2. 将文件名中包含 <目标串> 的文件重命名，规则同上。
   例如：ProcessHacker.exe → _rocessHacker.exe
注意：
• 直接覆盖原文件，请务必自行做备份。  
• 仅对可读写文件生效；无权限或特殊文件会被跳过并提示。
"""

import argparse
import os
import re
import sys
from pathlib import Path
from typing import Tuple, List


def compile_patterns(target: str) -> Tuple[re.Pattern, re.Pattern]:
    """生成 ANSI / UTF-16LE 不区分大小写的二进制正则。"""
    ansi_pat = re.compile(re.escape(target.encode("ascii")), re.IGNORECASE)
    unicode_pat = re.compile(re.escape(target.encode("utf-16le")), re.IGNORECASE)
    return ansi_pat, unicode_pat


def patch_file(
    file_path: Path,
    ansi_pat: re.Pattern,
    unicode_pat: re.Pattern,
    repl_ansi: bytes,
    repl_unicode: bytes,
) -> bool:
    """在单个文件内执行字节替换。"""
    try:
        data = file_path.read_bytes()
    except (OSError, IOError):
        print(f"[跳过] 无法读取: {file_path}")
        return False

    original = data
    if ansi_pat.search(data):
        data = ansi_pat.sub(repl_ansi, data)
    if unicode_pat.search(data):
        data = unicode_pat.sub(repl_unicode, data)

    if data != original:
        try:
            file_path.write_bytes(data)
            print(f"[修改] {file_path}")
            return True
        except (OSError, IOError):
            print(f"[失败] 无法写入: {file_path}")
    return False


def rename_files(root: Path, target: str, replacement: str) -> None:
    """重命名当前目录下匹配的文件（不递归）。"""
    insensitive = re.compile(re.escape(target), re.IGNORECASE)
    for p in list(root.iterdir()):
        if p.is_file() and insensitive.search(p.name):
            new_name = insensitive.sub(replacement, p.name)
            new_path = p.with_name(new_name)
            try:
                p.rename(new_path)
                print(f"[重命名] {p} → {new_path}")
            except (OSError, IOError):
                print(f"[失败] 无法重命名: {p}")


def walk_directory(
    start_dir: Path, target: str, replacement: str
) -> List[Path]:
    """递归遍历目录，返回所有文件路径。"""
    files: List[Path] = []
    for root, _, filenames in os.walk(start_dir):
        for fname in filenames:
            files.append(Path(root) / fname)
    return files


def main() -> None:
    parser = argparse.ArgumentParser(
        description="递归替换目录内所有文件的 ANSI / UTF-16LE 字节串，并重命名文件"
    )
    parser.add_argument("directory", help="目标目录")
    parser.add_argument("target", help="待替换字符串 (区分长度)")
    parser.add_argument(
        "--replacement",
        help="替换为的字符串 (默认: 用 _ 替换首字符)",
        default=None,
    )
    args = parser.parse_args()

    target: str = args.target
    replacement: str = args.replacement or f"_{target[1:]}"
    if len(target) != len(replacement):
        print("错误: replacement 长度必须与 target 完全一致。", file=sys.stderr)
        sys.exit(1)

    root_dir = Path(args.directory)
    if not root_dir.is_dir():
        print("错误: 指定目录不存在。", file=sys.stderr)
        sys.exit(1)

    ansi_pat, unicode_pat = compile_patterns(target)
    repl_ansi = replacement.encode("ascii")
    repl_unicode = replacement.encode("utf-16le")

    # 先替换文件内容
    for file_path in walk_directory(root_dir, target, replacement):
        patch_file(file_path, ansi_pat, unicode_pat, repl_ansi, repl_unicode)

    # 再处理文件名（深度优先，子目录先改）
    for current_root, dirs, files in os.walk(root_dir, topdown=False):
        rename_files(Path(current_root), target, replacement)

    print("全部完成。")


if __name__ == "__main__":
    main()
