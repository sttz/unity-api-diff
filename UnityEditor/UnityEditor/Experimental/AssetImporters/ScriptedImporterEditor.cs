using System;
using System.Collections;
using System.Collections.Generic;
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
