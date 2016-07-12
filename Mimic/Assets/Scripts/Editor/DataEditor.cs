using UnityEngine;
using UnityEditor;
using System.Collections;

class DataEditor : EditorWindow
{
    [MenuItem("Custom Mimic Editor/Data Editor")]

    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(DataEditor));
    }
    
    Vector2 scrollPos;
    TextAsset obj = new TextAsset();
    string[] data = null;
    
    void OnGUI()
    {
        scrollPos = EditorGUILayout.BeginScrollView(scrollPos);
        {
            GUILayout.Label("Base File", EditorStyles.boldLabel);
            
            obj = EditorGUILayout.ObjectField("File", obj, typeof(TextAsset), false) as TextAsset;
            if(GUILayout.Button("Load File"))
            {
                if(obj != null)
                    LoadFile(obj.name);
            }

            if(GUILayout.Button("Save File"))
            {
                if (obj != null)
                    SaveFile(obj.name);
            }

            if (obj != null)
            {
                if (data != null && data.Length > 0)
                {
                    for (int i = 0; i < data.Length; i++)
                        data[i] = EditorGUILayout.TextField("Data", data[i]);
                }
            }
        }
        EditorGUILayout.EndScrollView();
    }

    void LoadFile(string name)
    {
        string filename = GameSystem.GetDataResourcePath(name);
        Debug.Log("Load " + filename);

        var read = new System.IO.StreamReader(filename);
        data = read.ReadToEnd().Split('\n');

        read.Close();
    }

    void SaveFile(string name)
    {
        string filename = GameSystem.GetDataResourcePath(name);
        Debug.Log("Load " + filename);

        var writer = new System.IO.StreamWriter(filename);
        writer.Write(data[0]);
        for (int i = 1; i < data.Length; i++)
        {
            writer.WriteLine();
            writer.Write(data[i]);
        }
        
        writer.Close();
    }
}