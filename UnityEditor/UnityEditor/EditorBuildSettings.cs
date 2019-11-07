using System;
using UnityEngine;

namespace UnityEditor
{

public class EditorBuildSettings : Object
{
    static public UnityEditor.EditorBuildSettingsScene[] scenes { get; set; }

    static public event Action sceneListChanged;

    static public void AddConfigObject(string name, Object obj, bool overwrite);
    static public string[] GetConfigObjectNames();
    static public bool RemoveConfigObject(string name);
    static public bool TryGetConfigObject(string name, out T& result);

}

}
