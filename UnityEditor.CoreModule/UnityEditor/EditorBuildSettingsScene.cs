using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class EditorBuildSettingsScene : IComparable
{
    static public string[] GetActiveSceneList(UnityEditor.EditorBuildSettingsScene[] scenes);

    public bool enabled { get; set; }
    public UnityEditor.GUID guid { get; set; }
    public string path { get; set; }

    public EditorBuildSettingsScene();
    public EditorBuildSettingsScene(UnityEditor.GUID guid, bool enabled);
    public EditorBuildSettingsScene(string path, bool enabled);

    public int CompareTo(object obj);

}

}
