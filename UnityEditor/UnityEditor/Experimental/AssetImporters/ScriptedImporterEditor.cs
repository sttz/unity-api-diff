using System;
using UnityEngine;

namespace UnityEditor.Experimental.AssetImporters
{

public class ScriptedImporterEditor : UnityEditor.Experimental.AssetImporters.AssetImporterEditor
{
    public ScriptedImporterEditor();

    protected bool OnApplyRevertGUI();
    public void OnInspectorGUI();

}

}
