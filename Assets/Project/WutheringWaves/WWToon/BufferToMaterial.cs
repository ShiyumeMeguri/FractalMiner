using UnityEngine;
using System.Collections.Generic;
using System.IO;
using Ruri.Utils;

#if UNITY_EDITOR
using UnityEditor;
#endif

[ExecuteAlways]
public class BufferToMaterial : MonoBehaviour
{
    // 自动获取当前对象及其子对象的所有 Renderer 材质
    private readonly List<Material> targetMaterials = new List<Material>();

    [Tooltip("顶点着色器 Buffer 文件的通配符模式。")]
    public string vertexFileSearchPattern = "ubervcb*.bin";

    [Tooltip("片元着色器 Buffer 文件的通配符模式。")]
    public string fragmentFileSearchPattern = "uberfcb*.bin";

    // 用来存储创建好的 GraphicsBuffer
    private readonly List<GraphicsBuffer> graphicsBuffers = new List<GraphicsBuffer>();

    void OnEnable()
    {
        var renderers = GetComponentsInChildren<Renderer>(true);
        if (renderers == null || renderers.Length == 0)
        {
            RuriDebug.Log("WARNING: 当前对象及其子对象缺少 Renderer 组件，脚本将不会执行。", gameObject);
            return;
        }

        targetMaterials.Clear();

#if UNITY_EDITOR
        foreach (var r in renderers)
            targetMaterials.AddRange(r.sharedMaterials);
#else
        foreach (var r in renderers)
            targetMaterials.AddRange(r.materials);
#endif

        targetMaterials.RemoveAll(m => m == null);

        if (targetMaterials.Count == 0)
        {
            RuriDebug.Log("WARNING: 未找到有效材质，脚本将不会执行。", gameObject);
            return;
        }

        ReleaseBuffers();
        LoadAndSetBuffers();
    }

    void LoadAndSetBuffers()
    {
#if UNITY_EDITOR
        var monoScript = MonoScript.FromMonoBehaviour(this);
        if (monoScript == null)
        {
            RuriDebug.Log("ERROR: 无法找到当前脚本的 MonoScript 实例。", gameObject);
            return;
        }

        string scriptAssetPath = AssetDatabase.GetAssetPath(monoScript);
        if (string.IsNullOrEmpty(scriptAssetPath))
        {
            RuriDebug.Log("ERROR: 无法获取脚本资源路径。", gameObject);
            return;
        }

        string scriptDirectory = Path.GetDirectoryName(scriptAssetPath);

        // 加载并设置顶点着色器的 Buffers
        LoadBuffersForType(scriptDirectory, vertexFileSearchPattern, "vcb");

        // 加载并设置片元着色器的 Buffers
        LoadBuffersForType(scriptDirectory, fragmentFileSearchPattern, "cb");
#else
        RuriDebug.Log("WARNING: 从脚本目录加载 Buffer 是编辑器独有的功能，在构建版本中将不起作用。请使用 StreamingAssets 或其他方式加载数据。", gameObject);
#endif
    }

#if UNITY_EDITOR
    private void LoadBuffersForType(string directory, string pattern, string shaderPrefix)
    {
        string[] filePaths = Directory.GetFiles(directory, pattern);

        if (filePaths.Length == 0)
        {
            RuriDebug.Log($"在目录 '{directory}' 下没有找到匹配 '{pattern}' 的文件。", gameObject);
            return;
        }

        System.Array.Sort(filePaths, (a, b) => a.CompareTo(b));

        int stride = sizeof(float) * 4;

        for (int i = 0; i < filePaths.Length; i++)
        {
            string filePath = filePaths[i];
            string fileName = Path.GetFileName(filePath);

            byte[] fileBytes = File.ReadAllBytes(filePath);

            if (fileBytes.Length == 0 || fileBytes.Length % stride != 0)
            {
                RuriDebug.Log($"ERROR: 文件 '{fileName}' 的大小无效。其大小必须是 {stride} 字节的整数倍。", gameObject);
                continue;
            }

            int count = fileBytes.Length / stride;
            var buffer = new GraphicsBuffer(GraphicsBuffer.Target.Structured, count, stride);
            buffer.SetData(fileBytes);

            graphicsBuffers.Add(buffer);

            string propertyName = $"{shaderPrefix}{i}";

            foreach (var mat in targetMaterials)
                mat.SetBuffer(propertyName, buffer);

            RuriDebug.Log($"已加载 '{fileName}' 到 GraphicsBuffer 并设置给材质属性 '{propertyName}'，包含 {count} 个元素。", gameObject);
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
            buffer?.Release();
        graphicsBuffers.Clear();
    }
}
