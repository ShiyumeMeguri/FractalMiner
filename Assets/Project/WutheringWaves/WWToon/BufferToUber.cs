using UnityEngine;
using System.Collections.Generic;
using System.IO;

// 在 using 声明中为 Editor 代码添加条件编译
#if UNITY_EDITOR
using UnityEditor;
#endif

[ExecuteAlways]
public class BufferToUber : MonoBehaviour
{
    [Tooltip("要应用这些 Buffer 的目标材质。")]
    public Material targetMaterial;

    [Tooltip("顶点着色器 Buffer 文件的通配符模式。")]
    public string vertexFileSearchPattern = "ubervcb*.bin";

    [Tooltip("片元着色器 Buffer 文件的通配符模式。")]
    public string fragmentFileSearchPattern = "uberfcb*.bin";

    // 用来存储创建好的 GraphicsBuffer
    private List<GraphicsBuffer> graphicsBuffers = new List<GraphicsBuffer>();

    void OnEnable()
    {
        if (targetMaterial == null)
        {
            Debug.LogWarning("目标材质未设置，脚本将不会执行。", this);
            return;
        }

        // 先释放旧的资源，防止重复加载
        ReleaseBuffers();
        LoadAndSetBuffers();
    }

    void LoadAndSetBuffers()
    {
        // 这个功能依赖于 Unity Editor API 来查找脚本路径，因此仅在编辑器中可用。
#if UNITY_EDITOR
        var monoScript = MonoScript.FromMonoBehaviour(this);
        if (monoScript == null)
        {
            Debug.LogError("无法找到当前脚本的 MonoScript 实例。", this);
            return;
        }

        string scriptAssetPath = AssetDatabase.GetAssetPath(monoScript);
        if (string.IsNullOrEmpty(scriptAssetPath))
        {
            Debug.LogError("无法获取脚本资源路径。", this);
            return;
        }

        string scriptDirectory = Path.GetDirectoryName(scriptAssetPath);

        // 加载并设置顶点着色器的 Buffers
        LoadBuffersForType(scriptDirectory, vertexFileSearchPattern, "vcb");

        // 加载并设置片元着色器的 Buffers
        LoadBuffersForType(scriptDirectory, fragmentFileSearchPattern, "fcb");
#else
        // 在非编辑器环境（例如最终构建的游戏）下，此功能不可用
        Debug.LogWarning("从脚本目录加载 Buffer 是编辑器独有的功能，在构建版本中将不起作用。请使用 StreamingAssets 或其他方式加载数据。");
#endif
    }

#if UNITY_EDITOR
    private void LoadBuffersForType(string directory, string pattern, string shaderPrefix)
    {
        string[] filePaths = Directory.GetFiles(directory, pattern);

        if (filePaths.Length == 0)
        {
            Debug.Log($"在目录 '{directory}' 下没有找到匹配 '{pattern}' 的文件。", this);
            return;
        }

        // 对文件进行排序，以确保加载顺序一致 (例如 vcb0, vcb1, vcb10...)
        System.Array.Sort(filePaths, (a, b) => a.CompareTo(b));

        // 定义数据结构中每个元素的步长（一个 Vector4 = 4个 float = 16字节）
        int stride = sizeof(float) * 4;

        for (int i = 0; i < filePaths.Length; i++)
        {
            string filePath = filePaths[i];
            string fileName = Path.GetFileName(filePath); // 获取纯文件名用于日志

            byte[] fileBytes = File.ReadAllBytes(filePath);

            if (fileBytes.Length == 0 || fileBytes.Length % stride != 0)
            {
                Debug.LogError($"文件 '{fileName}' 的大小无效。其大小必须是 {stride} 字节的整数倍。", this);
                continue;
            }

            int count = fileBytes.Length / stride;
            var buffer = new GraphicsBuffer(GraphicsBuffer.Target.Structured, count, stride);
            buffer.SetData(fileBytes);

            // 将 buffer 添加到列表中以便后续统一释放
            graphicsBuffers.Add(buffer);

            // 根据前缀和索引生成 Shader 属性名 (例如 "vcb0", "fcb0")
            string propertyName = $"{shaderPrefix}{i}";

            // 直接将 Buffer 设置给材质
            targetMaterial.SetBuffer(propertyName, buffer);

            Debug.Log($"已加载 '{fileName}' 到 GraphicsBuffer 并设置给材质属性 '{propertyName}'，包含 {count} 个元素。", this);
        }
    }
#endif

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
    }
}