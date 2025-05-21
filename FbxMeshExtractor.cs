using UnityEngine;
using UnityEditor;
using System.IO;

namespace BYUtils.EditorTools
{
    public class FbxMeshExtractor : EditorWindow
    {
        private Object targetFbx;
        private string outputFolder = "Assets/ExtractedMeshes";
        
        [MenuItem("Tools/BY Utils/FBX Mesh Extractor")]
        static void Init()
        {
            FbxMeshExtractor window = (FbxMeshExtractor)EditorWindow.GetWindow(typeof(FbxMeshExtractor));
            window.titleContent = new GUIContent("FBX Mesh Extractor");
            window.Show();
        }
        
        void OnGUI()
        {
            GUILayout.Label("Extract All Meshes From FBX", EditorStyles.boldLabel);
            
            targetFbx = EditorGUILayout.ObjectField("Target FBX", targetFbx, typeof(GameObject), false);
            outputFolder = EditorGUILayout.TextField("Output Folder", outputFolder);
            
            if (GUILayout.Button("Browse Output Folder"))
            {
                string path = EditorUtility.SaveFolderPanel("Choose Output Folder", outputFolder, "");
                if (!string.IsNullOrEmpty(path))
                {
                    // Convert to project relative path
                    if (path.StartsWith(Application.dataPath))
                    {
                        outputFolder = "Assets" + path.Substring(Application.dataPath.Length);
                    }
                    else
                    {
                        Debug.LogWarning("Please select a folder within your project's Assets folder.");
                    }
                }
            }
            
            EditorGUILayout.Space();
            
            GUI.enabled = targetFbx != null;
            if (GUILayout.Button("Extract All Meshes"))
            {
                ExtractMeshes();
            }
            GUI.enabled = true;
        }
        
        void ExtractMeshes()
        {
            if (targetFbx == null) return;
            
            // Ensure output folder exists
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }
            
            GameObject fbxObject = targetFbx as GameObject;
            if (fbxObject == null)
            {
                EditorUtility.DisplayDialog("Error", "Selected object is not a valid GameObject/FBX file.", "OK");
                return;
            }
            
            string fbxPath = AssetDatabase.GetAssetPath(fbxObject);
            if (string.IsNullOrEmpty(fbxPath))
            {
                EditorUtility.DisplayDialog("Error", "Could not determine asset path.", "OK");
                return;
            }
            
            // Get all meshes
            Object[] assets = AssetDatabase.LoadAllAssetsAtPath(fbxPath);
            int extractedCount = 0;
            
            foreach (Object asset in assets)
            {
                if (asset is Mesh)
                {
                    Mesh mesh = asset as Mesh;
                    string meshName = mesh.name;
                    
                    // Create new mesh asset
                    Mesh meshCopy = Object.Instantiate(mesh);
                    meshCopy.name = meshName;
                    
                    // Save to target folder
                    string meshPath = Path.Combine(outputFolder, meshName + ".asset");
                    AssetDatabase.CreateAsset(meshCopy, meshPath);
                    extractedCount++;
                }
            }
            
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            
            EditorUtility.DisplayDialog("Extraction Complete", 
                    $"Successfully extracted {extractedCount} meshes to {outputFolder}.", "OK");
        }
    }
}
