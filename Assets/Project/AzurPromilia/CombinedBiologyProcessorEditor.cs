using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// 确保这里的命名空间与您的项目匹配
// 如果您的项目中没有这个 using，可以安全地注释或删除它
using Lens.Gameplay.Managers.CostumeChangeManager;

public class CombinedBiologyProcessorEditor
{
    // 将资源路径统一定义，方便维护
    private const string ASSET_PATH_FORMAT = "Assets/ResourcesAssets/Character/Part/{0}_{1}.asset";

    // 新的菜单项，整合了两个功能
    [MenuItem("工具/【综合处理】设置模型并应用材质参数(终极整合版)", false, 0)]
    private static void ProcessSelectedObjects()
    {
        // 1. 获取并验证选中对象
        GameObject[] selectedObjects = Selection.gameObjects;
        if (selectedObjects.Length == 0)
        {
            EditorUtility.DisplayDialog("提示", "没有选中任何对象。\n\n请在场景或层级视图中选择一个或多个包含 BiologyData 的对象。", "确定");
            return;
        }

        // 2. 查找所有需要处理的 BiologyData 组件
        HashSet<BiologyData> biologyDataComponents = new HashSet<BiologyData>();
        foreach (GameObject go in selectedObjects)
        {
            biologyDataComponents.UnionWith(go.GetComponentsInChildren<BiologyData>(true));
        }

        if (biologyDataComponents.Count == 0)
        {
            EditorUtility.DisplayDialog("错误", "在选中的对象及其子对象中没有找到 BiologyData 组件。", "确定");
            return;
        }
        
        // 3. 提前记录所有可能被修改的对象，以便撤销(Undo)
        HashSet<Material> materialsToRecord = new HashSet<Material>();
        List<SkinnedMeshRenderer> renderersToRecord = new List<SkinnedMeshRenderer>();
        foreach (var biologyData in biologyDataComponents)
        {
            renderersToRecord.AddRange(biologyData.preRenderers.Where(r => r != null));
            foreach (var renderer in biologyData.preRenderers)
            {
                if (renderer == null) continue;
                foreach (var mat in renderer.sharedMaterials)
                {
                    if (mat != null) materialsToRecord.Add(mat);
                }
            }
        }
        if (renderersToRecord.Any())
        {
            Undo.RecordObjects(renderersToRecord.ToArray(), "Set Meshes and Materials");
        }
        if (materialsToRecord.Any())
        {
            Undo.RecordObjects(materialsToRecord.ToArray(), "Apply Material Parameters");
        }

        // 4. 初始化统计数据
        int totalSuccessMeshCount = 0;
        int totalFailMeshCount = 0;
        int totalAppliedParamCount = 0;
        
        StringBuilder logBuilder = new StringBuilder();
        logBuilder.AppendLine("--- 开始综合处理 ---");

        // 5. 遍历并处理每一个 BiologyData 组件
        foreach (BiologyData biologyData in biologyDataComponents)
        {
            logBuilder.AppendLine($"\n-- 正在处理对象: <color=yellow>{biologyData.gameObject.name}</color> --");

            // ===================================================================
            //  第一步：设置模型和基础材质 (来自第一个脚本的核心逻辑)
            // ===================================================================
            var meshResult = SetMeshesAndMaterials(biologyData, logBuilder);
            totalSuccessMeshCount += meshResult.success;
            totalFailMeshCount += meshResult.fail;
            
            // ===================================================================
            //  第二步：应用自定义材质参数 (来自第二个脚本的核心逻辑)
            // ===================================================================
            int appliedParams = ApplyMaterialParameters(biologyData, logBuilder);
            totalAppliedParamCount += appliedParams;
        }

        // 6. 保存资源并显示最终总结
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();

        logBuilder.AppendLine("\n-- 全部处理完成 --");
        string summary = $"在 {biologyDataComponents.Count} 个 BiologyData 组件中:\n\n" +
                         $"<color=green>成功应用 {totalSuccessMeshCount} 个子部件模型/材质</color>\n" +
                         $"<color=red>失败 {totalFailMeshCount} 次模型/材质设置</color>\n" +
                         $"<color=cyan>总共执行了 {totalAppliedParamCount} 次材质参数设置</color>";
        logBuilder.AppendLine(summary);
        
        Debug.Log(logBuilder.ToString());
        EditorUtility.DisplayDialog("处理完成", summary.Replace("<color=green>", "").Replace("</color>", "").Replace("<color=red>", "").Replace("<color=cyan>", ""), "确定");
    }

    /// <summary>
    /// 核心功能一：设置模型和基础材质
    /// </summary>
    private static (int success, int fail) SetMeshesAndMaterials(BiologyData biologyData, StringBuilder log)
    {
        int successCount = 0;
        int failCount = 0;

        if (biologyData.prePartList == null || biologyData.prePartList.Count == 0)
        {
            log.AppendLine($"<color=orange>警告: 对象 '{biologyData.gameObject.name}' 的 prePartList 为空，跳过模型设置。</color>");
            return (0, 0);
        }

        foreach (PartData partData in biologyData.prePartList)
        {
            if (string.IsNullOrEmpty(partData.partName))
            {
                log.AppendLine("发现一个空的 partName，已跳过。");
                continue;
            }

            string correctedPartName = partData.partName.StartsWith("ast_") ? partData.partName : "ast_" + partData.partName;

            PartAsset partAsset = null;
            string lastAttemptedPath = "";
            string[] lodCandidates = { PartAsset.LodLv.lod0.ToString(), PartAsset.LodLv.extra.ToString() };
            foreach (string lod in lodCandidates)
            {
                lastAttemptedPath = string.Format(ASSET_PATH_FORMAT, correctedPartName, lod);
                partAsset = AssetDatabase.LoadAssetAtPath<PartAsset>(lastAttemptedPath);
                if (partAsset != null) break;
            }

            if (partAsset == null)
            {
                log.AppendLine($"<color=red>[模型设置失败] 找不到 PartAsset。部件名: '{partData.partName}'.\n最后尝试的路径: '{lastAttemptedPath}'</color>");
                failCount++;
                continue;
            }

            if (partAsset.meshDatas == null || partAsset.meshDatas.Length == 0)
            {
                log.AppendLine($"<color=orange>警告: PartAsset '{partAsset.name}' 内容为空，跳过。</color>");
                continue;
            }

            foreach (MeshData meshDataItem in partAsset.meshDatas)
            {
                string expectedRendererName = meshDataItem.meshName;
                if (string.IsNullOrEmpty(expectedRendererName))
                {
                    log.AppendLine($"<color=orange>警告: 在 PartAsset '{partAsset.name}' 中发现一个空的 Mesh Name，已跳过。</color>");
                    failCount++;
                    continue;
                }

                if (meshDataItem.mesh == null || meshDataItem.material == null)
                {
                    log.AppendLine($"<color=red>[模型设置失败] MeshData 配置不完整。部件名: '{partData.partName}', Mesh Name: '{expectedRendererName}'。缺少 Mesh 或 Material。</color>");
                    failCount++;
                    continue;
                }

                SkinnedMeshRenderer targetRenderer = biologyData.preRenderers
                    .FirstOrDefault(r => r != null && r.gameObject.name == expectedRendererName);

                if (targetRenderer == null)
                {
                    log.AppendLine($"<color=red>[模型设置失败] 找不到匹配的 SkinnedMeshRenderer。期望名称: '{expectedRendererName}'</color>");
                    failCount++;
                    continue;
                }
                
                // 设置 Mesh 和 Materials
                targetRenderer.sharedMesh = meshDataItem.mesh;
                targetRenderer.sharedMaterials = new Material[] { meshDataItem.material };
                EditorUtility.SetDirty(targetRenderer);

                log.AppendLine($"[模型设置成功] 为 '{targetRenderer.gameObject.name}' 设置了来自 '{partAsset.name}' 的模型和材质。");
                successCount++;
            }
        }
        return (successCount, failCount);
    }
    
    /// <summary>
    /// 核心功能二：应用自定义材质参数
    /// </summary>
    private static int ApplyMaterialParameters(BiologyData biologyData, StringBuilder log)
    {
        if (biologyData.matParamAsset == null || biologyData.matParamAsset.data == null)
        {
            log.AppendLine($"<color=orange>警告: 对象 '{biologyData.gameObject.name}' 没有分配 matParamAsset，跳过材质参数应用。</color>");
            return 0;
        }

        int appliedParamCount = 0;
        var partTypeToRenderersMap = BuildMapFromPartAssets(biologyData);

        // PrintMap(partTypeToRenderersMap, biologyData.gameObject); // 可选：取消注释以在控制台打印详细映射

        foreach (CustomMatParam matParam in biologyData.matParamAsset.data)
        {
            appliedParamCount += ApplyGenericParams(matParam.customColors, partTypeToRenderersMap, biologyData);
            appliedParamCount += ApplyGenericParams(matParam.customFloats, partTypeToRenderersMap, biologyData);
            appliedParamCount += ApplyGenericParams(matParam.customKeywords, partTypeToRenderersMap, biologyData);
            appliedParamCount += ApplyGenericParams(matParam.customTextures, partTypeToRenderersMap, biologyData);
            appliedParamCount += ApplyGenericParams(matParam.customEnums, partTypeToRenderersMap, biologyData);
        }

        log.AppendLine($"[参数应用] 共为 '{biologyData.gameObject.name}' 设置了 {appliedParamCount} 个材质参数。");
        return appliedParamCount;
    }

    /// <summary>
    /// 辅助函数：根据 PartAsset 构建 PartType 到渲染器的映射
    /// </summary>
    private static Dictionary<PartAsset.PartType, List<SkinnedMeshRenderer>> BuildMapFromPartAssets(BiologyData biologyData)
    {
        var map = new Dictionary<PartAsset.PartType, List<SkinnedMeshRenderer>>();
        if (biologyData.prePartList == null) return map;

        foreach (PartData partData in biologyData.prePartList)
        {
            if (string.IsNullOrEmpty(partData.partName)) continue;
            string correctedPartName = partData.partName.StartsWith("ast_") ? partData.partName : "ast_" + partData.partName;

            PartAsset partAsset = null;
            string[] lodCandidates = { PartAsset.LodLv.lod0.ToString(), PartAsset.LodLv.extra.ToString() };
            foreach (string lod in lodCandidates)
            {
                string assetPath = string.Format(ASSET_PATH_FORMAT, correctedPartName, lod);
                partAsset = AssetDatabase.LoadAssetAtPath<PartAsset>(assetPath);
                if (partAsset != null) break;
            }
            if (partAsset == null) continue;

            if (!map.ContainsKey(partAsset.partType))
            {
                map[partAsset.partType] = new List<SkinnedMeshRenderer>();
            }

            if (partAsset.meshDatas == null) continue;

            foreach (MeshData meshDataItem in partAsset.meshDatas)
            {
                if (string.IsNullOrEmpty(meshDataItem.meshName)) continue;
                SkinnedMeshRenderer targetRenderer = biologyData.preRenderers
                    .FirstOrDefault(r => r != null && r.gameObject.name == meshDataItem.meshName);
                if (targetRenderer != null && !map[partAsset.partType].Contains(targetRenderer))
                {
                    map[partAsset.partType].Add(targetRenderer);
                }
            }
        }
        return map;
    }

    /// <summary>
    /// 辅助函数：通用的参数应用逻辑
    /// </summary>
    private static int ApplyGenericParams<T>(IEnumerable<T> paramsToApply, Dictionary<PartAsset.PartType, List<SkinnedMeshRenderer>> map, BiologyData biologyData) where T : CustomBase
    {
        if (paramsToApply == null) return 0;
        int appliedCount = 0;

        foreach (var param in paramsToApply)
        {
            if (string.IsNullOrEmpty(param.key)) continue;

            // 确定目标渲染器
            HashSet<SkinnedMeshRenderer> targetRenderers = new HashSet<SkinnedMeshRenderer>();
            if (param.rendererNames != null && param.rendererNames.Count > 0) // 优先使用指定的 rendererNames
            {
                foreach (string name in param.rendererNames)
                {
                    var renderer = biologyData.preRenderers?.FirstOrDefault(r => r != null && r.name == name);
                    if (renderer != null) targetRenderers.Add(renderer);
                }
            }
            else // 否则根据 PartType 查找
            {
                foreach (var entry in map)
                {
                    if ((param.partType & entry.Key) != 0)
                    {
                        targetRenderers.UnionWith(entry.Value);
                    }
                }
            }

            // 应用参数到每个目标渲染器的所有材质上
            foreach (var renderer in targetRenderers)
            {
                if (renderer == null) continue;
                foreach (var mat in renderer.sharedMaterials)
                {
                    if (mat == null) continue;

                    // 根据参数类型调用不同的 Set 方法
                    switch (param)
                    {
                        case CustomColor colorParam:
                            mat.SetColor(colorParam.key, colorParam.value);
                            break;
                        case CustomFloat floatParam:
                            mat.SetFloat(floatParam.key, floatParam.value);
                            break;
                        case CustomKeyWord keywordParam:
                            if (keywordParam.value) mat.EnableKeyword(keywordParam.key);
                            else mat.DisableKeyword(keywordParam.key);
                            break;
                        case CustomTex texParam:
                            mat.SetTexture(texParam.key, texParam.value);
                            break;
                        case CustomEnum enumParam:
                            mat.SetFloat(enumParam.key, enumParam.selectValue);
                            break;
                    }

                    EditorUtility.SetDirty(mat);
                    appliedCount++;
                }
            }
        }
        return appliedCount;
    }
    
    // (可选) 用于调试的打印函数
    private static void PrintMap(Dictionary<PartAsset.PartType, List<SkinnedMeshRenderer>> map, GameObject context)
    {
        Debug.Log("--- [PartAsset反向构建] 的 PartType -> Renderer 映射 ---", context);
        if (map.Count == 0)
        {
            Debug.LogWarning("映射为空！请检查 BiologyData 的 prePartList 是否配置正确，以及对应的 PartAsset 文件是否存在且配置了 meshDatas。", context);
        }
        foreach (var entry in map)
        {
            var rendererNames = string.Join(", ", entry.Value.Where(r => r != null).Select(r => r.name));
            Debug.Log($"PartType: [{entry.Key} ({(int)entry.Key})] -> Renderers: [{rendererNames}]");
        }
        Debug.Log("---------------------------------------------------------");
    }
}