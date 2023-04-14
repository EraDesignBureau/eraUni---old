using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;

namespace eraUni.Plugin
{
    /// <summary>
    /// 为 Unity 面板增加 context menu。
    /// </summary>
    public class HierarchyMenu : Editor
    {
        static void CreateGameObject(string path)
        {
            try
            {
                GameObject clone = Instantiate(AssetDatabase.LoadAssetAtPath("Assets/" + EditorPrefs.GetString("UIManager.RootFolder") + path + ".prefab", typeof(GameObject)), Vector3.zero, Quaternion.identity) as GameObject;

                try
                {
                    if (Selection.activeGameObject == null)
                    {
                        var canvas = (Canvas)GameObject.FindObjectsOfType(typeof(Canvas))[0];
                        Undo.RegisterCreatedObjectUndo(clone, "Created an object");
                        clone.transform.SetParent(canvas.transform, false);
                    }

                    else
                    {
                        Undo.RegisterCreatedObjectUndo(clone, "Created an object");
                        clone.transform.SetParent(Selection.activeGameObject.transform, false);
                    }

                    clone.name = clone.name.Replace("(Clone)", "").Trim();
                }

                catch
                {
                    Undo.RegisterCreatedObjectUndo(clone, "Created an object");
                    CreateCanvas();
                    var canvas = (Canvas)GameObject.FindObjectsOfType(typeof(Canvas))[0];
                    clone.transform.SetParent(canvas.transform, false);
                    clone.name = clone.name.Replace("(Clone)", "").Trim();
                }

                Selection.activeObject = clone;
            }

            catch
            {
                //if (EditorUtility.DisplayDialog("Modern UI Pack", "Cannot create the object due to missing/incorrect root folder. " +
                //    "You can change the root folder by clicking 'Fix' button and enabling 'Change Root Folder'.", "Fix", "Cancel"))
                //    ShowManager();
            }

            if (Application.isPlaying == false)
                EditorSceneManager.MarkSceneDirty(EditorSceneManager.GetActiveScene());


        }

        static void CreateButton(string resourcePath)
        {
            try
            {
                GameObject clone = Instantiate(AssetDatabase.LoadAssetAtPath("Assets/" + EditorPrefs.GetString("UIManager.RootFolder") + resourcePath + ".prefab", typeof(GameObject)), Vector3.zero, Quaternion.identity) as GameObject;

                try
                {
                    if (Selection.activeGameObject == null)
                    {
                        var canvas = (Canvas)GameObject.FindObjectsOfType(typeof(Canvas))[0];
                        Undo.RegisterCreatedObjectUndo(clone, "Created an object");
                        clone.transform.SetParent(canvas.transform, false);
                    }

                    else
                    {
                        Undo.RegisterCreatedObjectUndo(clone, "Created an object");
                        clone.transform.SetParent(Selection.activeGameObject.transform, false);
                    }

                    clone.name = "Button";
                }

                catch
                {
                    Undo.RegisterCreatedObjectUndo(clone, "Created an object");
                    CreateCanvas();
                    var canvas = (Canvas)GameObject.FindObjectsOfType(typeof(Canvas))[0];
                    clone.transform.SetParent(canvas.transform, false);
                    clone.name = "Button";
                }

                Selection.activeObject = clone;
            }

            catch
            {
                //if (EditorUtility.DisplayDialog("Modern UI Pack", "Cannot create the object due to missing/incorrect root folder. " +
                //  "You can change the root folder by clicking 'Fix' button and enabling 'Change Root Folder'.", "Fix", "Cancel"))
                //    ShowManager();
            }

            if (Application.isPlaying == false)
                EditorSceneManager.MarkSceneDirty(EditorSceneManager.GetActiveScene());
        }

        [MenuItem("GameObject/Modern UI Pack/Canvas", false, -1)]
        static void CreateCanvas()
        {
            try
            {
                GameObject clone = Instantiate(AssetDatabase.LoadAssetAtPath("Assets/" + EditorPrefs.GetString("UIManager.RootFolder") + "Other/Canvas" + ".prefab", typeof(GameObject)), Vector3.zero, Quaternion.identity) as GameObject;
                Undo.RegisterCreatedObjectUndo(clone, "Created an object");
                clone.name = clone.name.Replace("(Clone)", "").Trim();
                Selection.activeObject = clone;
            }

            catch
            {
                //if (EditorUtility.DisplayDialog("Modern UI Pack", "Cannot create the object due to missing/incorrect root folder. " +
                //  "You can change the root folder by clicking 'Fix' button and enabling 'Change Root Folder'.", "Fix", "Cancel"))
                //    ShowManager();
            }

            if (Application.isPlaying == false)
                EditorSceneManager.MarkSceneDirty(EditorSceneManager.GetActiveScene());
        }
    }

}
#endif