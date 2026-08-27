using UnityEngine;
using UnityEditor;
using System.Linq; // 引入Linq库用于排序

public class ArrangeAlongXAxis : EditorWindow
{
    // 定义菜单项，用于打开窗口
    [MenuItem("Tools/Arrange Along X-Axis (1m Spacing)")]
    public static void ShowWindow()
    {
        // 显示一个名为 "Arrange on X-Axis" 的编辑器窗口
        GetWindow<ArrangeAlongXAxis>("Arrange on X-Axis");
    }

    // 绘制窗口UI
    void OnGUI()
    {
        // 窗口标题
        GUILayout.Label("Arrange Selected Objects", EditorStyles.boldLabel);
        
        // 提示信息
        EditorGUILayout.HelpBox("此工具会将选中的所有物体按照X轴坐标排序，并以1米的间隔重新排列。", MessageType.Info);

        // 创建一个按钮，点击时执行排列操作
        if (GUILayout.Button("Arrange by X-Axis"))
        {
            ArrangeSelectedObjects();
        }
    }

    private void ArrangeSelectedObjects()
    {
        // 1. 获取所有选中的游戏对象的Transform组件
        Transform[] selectedTransforms = Selection.transforms;

        if (selectedTransforms.Length == 0)
        {
            Debug.LogWarning("没有选中任何物体。");
            return;
        }

        // 2. 按照物体当前的X轴位置进行排序（从小到大）
        var sortedTransforms = selectedTransforms.OrderBy(t => t.position.x).ToArray();

        // 3. 记录操作，以便可以按Ctrl+Z撤销
        // 对排序后的数组进行操作记录
        Undo.RecordObjects(sortedTransforms, "Arrange Along X-Axis");

        // 4. 将排列的起始点设置为排序后第一个物体的位置
        Vector3 startPosition = sortedTransforms[0].position;
        
        // 5. 定义固定的间隔
        float spacing = 1.0f;

        // 6. 循环遍历所有排序后的物体，并计算它们的新位置
        for (int i = 0; i < sortedTransforms.Length; i++)
        {
            Transform currentTransform = sortedTransforms[i];

            // 根据索引和间距计算新的X轴位置
            // Y轴和Z轴保持物体各自的原始值不变
            Vector3 newPosition = new Vector3(
                startPosition.x + i * spacing,
                currentTransform.position.y, // 保持原始Y坐标
                currentTransform.position.z  // 保持原始Z坐标
            );

            // 应用新位置
            currentTransform.position = newPosition;
        }

        Debug.Log(sortedTransforms.Length + "个物体已成功沿X轴排列。");
    }
}