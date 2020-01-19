using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class Tools : ScriptableObject
{
    static public UnityEditor.Tool current { get; set; }
    static public Vector3 handlePosition { get; }
    static public Rect handleRect { get; }
    static public Quaternion handleRectRotation { get; }
    static public Quaternion handleRotation { get; set; }
    static public bool hidden { get; set; }
    static public int lockedLayers { get; set; }
    static public UnityEditor.PivotMode pivotMode { get; set; }
    static public UnityEditor.PivotRotation pivotRotation { get; set; }
    static public bool rectBlueprintMode { get; set; }
    static public UnityEditor.ViewTool viewTool { get; set; }
    static public int visibleLayers { get; set; }

    public Tools();

}

}
