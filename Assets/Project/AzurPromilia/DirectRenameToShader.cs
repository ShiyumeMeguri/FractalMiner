using UnityEditor;
using UnityEngine;
using System.IO;

public class DirectRenameToShader
{
    [MenuItem("Assets/慎用：直接重命名文件为.shader")]
    private static void RenameFileToShader()
    {
        // 获取项目Assets目录的绝对路径
        // Application.dataPath 返回 "C:/YourProject/Assets"
        // 我们需要 "C:/YourProject"
        string projectPath = Directory.GetParent(Application.dataPath).FullName;

        Object[] selectedAssets = Selection.objects;
        int successCount = 0;
        int failCount = 0;

        foreach (Object asset in selectedAssets)
        {
            // 获取资产的相对路径，如 "Assets/Materials/MyMaterial.mat"
            string relativeAssetPath = AssetDatabase.GetAssetPath(asset);

            // 转换为绝对路径
            string absoluteAssetPath = Path.Combine(projectPath, relativeAssetPath);
            string absoluteMetaPath = absoluteAssetPath + ".meta";

            // 检查文件和meta文件是否存在
            if (!File.Exists(absoluteAssetPath) || !File.Exists(absoluteMetaPath))
            {
                Debug.LogWarning($"跳过: 找不到文件或meta文件 '{relativeAssetPath}'");
                failCount++;
                continue;
            }

            // 计算新的文件路径
            string newAbsoluteAssetPath = Path.ChangeExtension(absoluteAssetPath, ".shader");
            string newAbsoluteMetaPath = newAbsoluteAssetPath + ".meta";

            // 如果已经是.shader，则跳过
            if (absoluteAssetPath.Equals(newAbsoluteAssetPath, System.StringComparison.OrdinalIgnoreCase))
            {
                Debug.Log($"跳过: '{relativeAssetPath}' 的后缀已经是.shader");
                continue;
            }
            
            // 检查目标文件是否已存在，防止覆盖
            if (File.Exists(newAbsoluteAssetPath))
            {
                Debug.LogError($"无法重命名: 目标文件 '{newAbsoluteAssetPath}' 已存在。请先处理冲突。");
                failCount++;
                continue;
            }

            try
            {
                // 1. 重命名主资产文件
                File.Move(absoluteAssetPath, newAbsoluteAssetPath);
                
                // 2. 重命名.meta文件 (关键步骤)
                File.Move(absoluteMetaPath, newAbsoluteMetaPath);

                Debug.Log($"成功重命名: '{Path.GetFileName(absoluteAssetPath)}' -> '{Path.GetFileName(newAbsoluteAssetPath)}'");
                successCount++;
            }
            catch (System.Exception e)
            {
                Debug.LogError($"重命名 '{relativeAssetPath}' 时发生错误: {e.Message}");
                failCount++;

                // 尝试回滚，如果主文件已重命名但meta文件失败
                if (File.Exists(newAbsoluteAssetPath) && !File.Exists(absoluteAssetPath))
                {
                    File.Move(newAbsoluteAssetPath, absoluteAssetPath);
                    Debug.Log("已尝试回滚重命名操作。");
                }
            }
        }
        
        Debug.Log($"------ 操作完成 ------");
        Debug.Log($"成功: {successCount}, 失败: {failCount}. 正在刷新AssetDatabase...");

    }

    [MenuItem("Assets/慎用：直接重命名文件为.shader", true)]
    private static bool RenameFileToShaderValidation()
    {
        // 只有在Project窗口中选中了东西时才显示菜单项
        return Selection.assetGUIDs.Length > 0;
    }
}