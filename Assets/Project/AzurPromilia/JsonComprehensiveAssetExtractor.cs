using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.Linq;
using System.IO;
// 如果你的类型在特定命名空间下，请确保 using 指令是正确的
 using Lens.Gameplay.Managers.CostumeChangeManager;

#region Final Comprehensive Data Structures

[System.Serializable]
public class ComprehensiveBiologyInfo
{
    public string selectedObjectName;
    public string selectedObjectPrefabPath;
    public string selectedObjectPrefabBundle;
    public string componentPath;
    public string materialParamAssetPath;
    public string materialParamAssetBundle;
    public List<ComprehensiveMaterialParamOverride> materialParamOverrides;
    public List<ComprehensivePartInfo> parts;
}

[System.Serializable]
public class ComprehensivePartInfo
{
    public string sourcePartName;
    public string foundPartAssetPath;
    public string foundPartAssetBundle;
    public string partType;
    public List<ComprehensiveMeshDetails> meshes;
}

[System.Serializable]
public class ComprehensiveMeshDetails
{
    public string meshNameInAsset;
    public string rendererGameObjectName;
    public string rendererPathFromSelectionRoot;

    [Header("Assets Currently on the Renderer")]
    public string currentMeshAssetPath;
    public string currentMeshAssetBundle;
    public List<ComprehensiveMaterialDetails> currentMaterials;

    [Header("Assets Configured in the PartAsset")]
    public string configuredMeshAssetPath;
    public string configuredMeshAssetBundle;
    public ComprehensiveMaterialDetails configuredMaterial; // PartAsset's MeshData has one material
}

[System.Serializable]
public class ComprehensiveMaterialDetails
{
    public string materialName;
    public string materialAssetPath;
    public string materialAssetBundle;
    public List<ComprehensiveTextureInfo> textures;
}

[System.Serializable]
public class ComprehensiveTextureInfo
{
    public string shaderPropertyName;
    public string textureAssetPath;
    public string textureAssetBundle;
}

[System.Serializable]
public class ComprehensiveMaterialParamOverride
{
    public string paramType;
    public string paramKey;
    public string paramValueAssetPath;
    public string paramValueAssetBundle;
    public List<string> targetRendererNames;
}

[System.Serializable]
public class JsonWrapper<T>
{
    public T[] Items;
}

#endregion

public class ComprehensiveAssetExtractor
{
    private const string ASSET_PATH_FORMAT = "Assets/ResourcesAssets/Character/Part/{0}_{1}.asset";

    [MenuItem("Tools/自定义工具/导出选中对象(综合)的完整资产路径和AB包名 (JSON)")]
    private static void ExtractComprehensiveAssetPaths()
    {
        GameObject[] selectedObjects = Selection.gameObjects;
        if (selectedObjects.Length == 0)
        {
            EditorUtility.DisplayDialog("提示", "请先在场景(Hierarchy)或项目窗口中选择至少一个对象。", "确定");
            return;
        }

        List<ComprehensiveBiologyInfo> allAssetsInfo = new List<ComprehensiveBiologyInfo>();

        foreach (GameObject selectedGo in selectedObjects)
        {
            BiologyData[] biologyDatas = selectedGo.GetComponentsInChildren<BiologyData>(true);
            if (biologyDatas.Length == 0) continue;

            string prefabPath = PrefabUtility.IsPartOfPrefabAsset(selectedGo)
                ? AssetDatabase.GetAssetPath(PrefabUtility.GetCorrespondingObjectFromSource(selectedGo))
                : "Not a prefab instance";

            foreach (BiologyData data in biologyDatas)
            {
                string matParamPath = AssetDatabase.GetAssetPath(data.matParamAsset);
                var info = new ComprehensiveBiologyInfo
                {
                    selectedObjectName = selectedGo.name,
                    selectedObjectPrefabPath = prefabPath,
                    selectedObjectPrefabBundle = GetAssetBundleName(prefabPath),
                    componentPath = GetPathFromRoot(data.transform, selectedGo.transform),
                    materialParamAssetPath = matParamPath,
                    materialParamAssetBundle = GetAssetBundleName(matParamPath),
                    parts = new List<ComprehensivePartInfo>(),
                    materialParamOverrides = new List<ComprehensiveMaterialParamOverride>()
                };
                
                // 解析 prePartList, 融合两种逻辑
                if (data.prePartList != null)
                {
                    foreach (PartData partData in data.prePartList)
                    {
                        if (string.IsNullOrEmpty(partData.partName)) continue;

                        string correctedPartName = partData.partName.StartsWith("ast_") ? partData.partName : "ast_" + partData.partName;
                        PartAsset partAsset = FindPartAsset(correctedPartName);
                        string partAssetPath = partAsset != null ? AssetDatabase.GetAssetPath(partAsset) : "Not Found";

                        var partInfo = new ComprehensivePartInfo
                        {
                            sourcePartName = partData.partName,
                            foundPartAssetPath = partAssetPath,
                            foundPartAssetBundle = GetAssetBundleName(partAssetPath),
                            partType = partAsset != null ? partAsset.partType.ToString() : "N/A",
                            meshes = new List<ComprehensiveMeshDetails>()
                        };

                        if (partAsset?.meshDatas != null)
                        {
                            foreach (MeshData meshDataItem in partAsset.meshDatas)
                            {
                                if (string.IsNullOrEmpty(meshDataItem.meshName)) continue;

                                SkinnedMeshRenderer targetRenderer = data.preRenderers
                                    .FirstOrDefault(r => r != null && r.gameObject.name == meshDataItem.meshName);

                                // 即使找不到renderer，我们仍然可以报告PartAsset里的配置
                                var meshDetails = new ComprehensiveMeshDetails
                                {
                                    meshNameInAsset = meshDataItem.meshName,
                                    rendererGameObjectName = targetRenderer != null ? targetRenderer.gameObject.name : "Not Found in preRenderers",
                                    rendererPathFromSelectionRoot = targetRenderer != null ? GetPathFromRoot(targetRenderer.transform, selectedGo.transform) : "N/A",
                                    currentMaterials = new List<ComprehensiveMaterialDetails>()
                                };

                                // --- 逻辑融合点 ---

                                // 1. 获取 Renderer 上【当前】的资产信息 (旧逻辑)
                                if (targetRenderer != null)
                                {
                                    string currentMeshPath = targetRenderer.sharedMesh != null ? AssetDatabase.GetAssetPath(targetRenderer.sharedMesh) : "N/A";
                                    meshDetails.currentMeshAssetPath = currentMeshPath;
                                    meshDetails.currentMeshAssetBundle = GetAssetBundleName(currentMeshPath);

                                    foreach (var mat in targetRenderer.sharedMaterials)
                                    {
                                        if (mat != null)
                                            meshDetails.currentMaterials.Add(GetMaterialDetails(mat));
                                    }
                                }

                                // 2. 获取 PartAsset 中【配置】的资产信息 (新逻辑)
                                string configuredMeshPath = meshDataItem.mesh != null ? AssetDatabase.GetAssetPath(meshDataItem.mesh) : "N/A";
                                meshDetails.configuredMeshAssetPath = configuredMeshPath;
                                meshDetails.configuredMeshAssetBundle = GetAssetBundleName(configuredMeshPath);
                                meshDetails.configuredMaterial = meshDataItem.material != null ? GetMaterialDetails(meshDataItem.material) : null;
                                
                                partInfo.meshes.Add(meshDetails);
                            }
                        }
                        info.parts.Add(partInfo);
                    }
                }

                // 解析 MatParamAsset
                if (data.matParamAsset?.data != null)
                {
                    foreach (CustomMatParam matParam in data.matParamAsset.data)
                    {
                        info.materialParamOverrides.AddRange(GetParamOverrides(matParam.customTextures));
                    }
                }

                allAssetsInfo.Add(info);
            }
        }

        if (allAssetsInfo.Count == 0)
        {
            EditorUtility.DisplayDialog("提示", "在选中的对象中没有找到任何 BiologyData 组件。", "确定");
            return;
        }

        string jsonOutput = JsonUtility.ToJson(new JsonWrapper<ComprehensiveBiologyInfo> { Items = allAssetsInfo.ToArray() }, true);
        Debug.Log("--- 选中对象的综合资产报告 (JSON) ---\n" + jsonOutput);
        
        string savePath = EditorUtility.SaveFilePanel("保存综合资产报告", "Assets", $"{selectedObjects[0].name}_comprehensive_report", "json");
        if (!string.IsNullOrEmpty(savePath))
        {
            File.WriteAllText(savePath, jsonOutput);
            AssetDatabase.Refresh();
        }
    }

    #region Helper Functions (No changes needed)
    private static string GetAssetBundleName(string assetPath)
    {
        if (string.IsNullOrEmpty(assetPath) || !assetPath.StartsWith("Assets/")) return "N/A or Not an Asset";
        AssetImporter importer = AssetImporter.GetAtPath(assetPath);
        if (importer == null) return "N/A (No Importer)";
        if (string.IsNullOrEmpty(importer.assetBundleName)) return "Not Assigned";
        return !string.IsNullOrEmpty(importer.assetBundleVariant) ? $"{importer.assetBundleName}.{importer.assetBundleVariant}" : importer.assetBundleName;
    }

    private static PartAsset FindPartAsset(string correctedPartName)
    {
        string[] lodCandidates = { "lod0", "extra" };
        foreach (string lod in lodCandidates)
        {
            string assetPath = string.Format(ASSET_PATH_FORMAT, correctedPartName, lod);
            PartAsset partAsset = AssetDatabase.LoadAssetAtPath<PartAsset>(assetPath);
            if (partAsset != null) return partAsset;
        }
        return null;
    }

    private static ComprehensiveMaterialDetails GetMaterialDetails(Material mat)
    {
        string matPath = AssetDatabase.GetAssetPath(mat);
        var materialDetails = new ComprehensiveMaterialDetails
        {
            materialName = mat.name,
            materialAssetPath = matPath,
            materialAssetBundle = GetAssetBundleName(matPath),
            textures = new List<ComprehensiveTextureInfo>()
        };

        Shader shader = mat.shader;
        if (shader == null) return materialDetails;

        for (int i = 0; i < ShaderUtil.GetPropertyCount(shader); i++)
        {
            if (ShaderUtil.GetPropertyType(shader, i) == ShaderUtil.ShaderPropertyType.TexEnv)
            {
                string propertyName = ShaderUtil.GetPropertyName(shader, i);
                Texture texture = mat.GetTexture(propertyName);
                if (texture != null)
                {
                    string texPath = AssetDatabase.GetAssetPath(texture);
                    materialDetails.textures.Add(new ComprehensiveTextureInfo
                    {
                        shaderPropertyName = propertyName,
                        textureAssetPath = texPath,
                        textureAssetBundle = GetAssetBundleName(texPath)
                    });
                }
            }
        }
        return materialDetails;
    }

    private static IEnumerable<ComprehensiveMaterialParamOverride> GetParamOverrides(IEnumerable<CustomTex> textureParams)
    {
        if (textureParams == null) yield break;
        foreach (var texParam in textureParams)
        {
            if (texParam == null) continue;
            string texPath = texParam.value != null ? AssetDatabase.GetAssetPath(texParam.value) : "null";
            yield return new ComprehensiveMaterialParamOverride
            {
                paramType = "Texture",
                paramKey = texParam.key,
                paramValueAssetPath = texPath,
                paramValueAssetBundle = GetAssetBundleName(texPath),
                targetRendererNames = texParam.rendererNames ?? new List<string>()
            };
        }
    }

    private static string GetPathFromRoot(Transform current, Transform root)
    {
        if (current == null || root == null) return "Invalid Transform";
        if (current == root) return current.name;
        string path = current.name;
        Transform parent = current.parent;
        while (parent != null && parent != root.parent)
        {
            path = parent.name + "/" + path;
            if (parent == root) break;
            parent = parent.parent;
        }
        return path;
    }
    #endregion
}