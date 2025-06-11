using UnityEngine;
using System.Collections.Generic;
using System.IO;

// 在 using 声明中为 Editor 代码添加条件编译
#if UNITY_EDITOR
using UnityEditor;
#endif

[ExecuteAlways]
public class BufferToMaterial : MonoBehaviour
{
    [Tooltip("要应用这些 Buffer 的目标材质。")]
    public Material targetMaterial;

    [Tooltip("在脚本所在目录下搜索文件的通配符模式。")]
    public string fileSearchPattern = "cb*.bin";

    // 用来存储创建好的 GraphicsBuffer
    private List<GraphicsBuffer> graphicsBuffers = new List<GraphicsBuffer>();
    private List<string> shaderPropertyNames = new List<string>();

    void OnEnable()
    {
        // 先释放旧的资源，防止重复加载
        ReleaseBuffers();
        LoadBuffersFromScriptDirectory();
        for (int i = 0; i < graphicsBuffers.Count; i++)
        {
            targetMaterial.SetBuffer(shaderPropertyNames[i], graphicsBuffers[i]);
        }
    }

    void LoadBuffersFromScriptDirectory()
    {
        // 这个功能依赖于 Unity Editor API 来查找脚本路径，因此仅在编辑器中可用。
#if UNITY_EDITOR
        // 获取当前脚本的 MonoScript 实例
        var monoScript = MonoScript.FromMonoBehaviour(this);
        if (monoScript == null)
        {
            Debug.LogError("无法找到当前脚本的 MonoScript 实例。", this);
            return;
        }

        // 获取脚本在项目中的路径 (例如 "Assets/Scripts/BufferToMaterial.cs")
        string scriptAssetPath = AssetDatabase.GetAssetPath(monoScript);
        if (string.IsNullOrEmpty(scriptAssetPath))
        {
            Debug.LogError("无法获取脚本资源路径。", this);
            return;
        }

        // 获取脚本所在的目录 (例如 "Assets/Scripts")
        string scriptDirectory = Path.GetDirectoryName(scriptAssetPath);

        // 在脚本目录下查找所有匹配模式的文件
        string[] filePaths = Directory.GetFiles(scriptDirectory, fileSearchPattern);

        if (filePaths.Length == 0)
        {
            Debug.LogWarning($"在目录 '{scriptDirectory}' 下没有找到匹配 '{fileSearchPattern}' 的文件。", this);
            return;
        }

        // 对文件进行排序，以确保加载顺序一致 (例如 cb0, cb1, cb10...)
        System.Array.Sort(filePaths, (a, b) => a.CompareTo(b));


        // 定义数据结构中每个元素的步长（一个 Vector4 = 4个 float = 16字节）
        int stride = sizeof(float) * 4;

        for (int i = 0; i < filePaths.Length; i++)
        {
            string filePath = filePaths[i];
            string fileName = Path.GetFileName(filePath); // 获取纯文件名用于日志

            // 读取文件的所有字节
            byte[] fileBytes = File.ReadAllBytes(filePath);

            // 验证文件大小是否为步长的整数倍
            if (fileBytes.Length == 0 || fileBytes.Length % stride != 0)
            {
                Debug.LogError($"文件 '{fileName}' 的大小无效。其大小必须是 {stride} 字节的整数倍。", this);
                continue;
            }

            // 计算缓冲区中的元素数量
            int count = fileBytes.Length / stride;

            // 创建 GraphicsBuffer
            var buffer = new GraphicsBuffer(GraphicsBuffer.Target.Structured, count, stride);

            // 将从文件读取的字节数据直接设置到 Buffer 中
            buffer.SetData(fileBytes);

            // 存储 buffer 和其在 shader 中的属性名
            graphicsBuffers.Add(buffer);
            // 沿用旧的命名规则，cb0, cb1, ...
            string propertyName = $"cb{i}";
            shaderPropertyNames.Add(propertyName);

            Debug.Log($"已加载 '{fileName}' 到 GraphicsBuffer '{propertyName}'，包含 {count} 个元素。", this);
        }
#else
        // 在非编辑器环境（例如最终构建的游戏）下，此功能不可用
        Debug.LogWarning("从脚本目录加载 Buffer 是编辑器独有的功能，在构建版本中将不起作用。请使用 StreamingAssets 或其他方式加载数据。");
#endif
    }

    void Update()
    {
        if (targetMaterial == null || graphicsBuffers.Count == 0) return;
/*
        // 在每一帧将 buffer 绑定到材质上
        for (int i = 0; i < graphicsBuffers.Count; i++)
        {
            targetMaterial.SetBuffer(shaderPropertyNames[i], graphicsBuffers[i]);
        }
*/
    }

    void OnDisable()
    {
        ReleaseBuffers();
    }

    void OnDestroy()
    {
        ReleaseBuffers();
    }

    // 统一的资源释放函数
    void ReleaseBuffers()
    {
        foreach (var buffer in graphicsBuffers)
        {
            buffer?.Release();
        }
        graphicsBuffers.Clear();
        shaderPropertyNames.Clear();
    }
}