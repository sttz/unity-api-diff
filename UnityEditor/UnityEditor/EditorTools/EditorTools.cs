using System;
using UnityEngine;

namespace UnityEditor.EditorTools
{

public static class EditorTools
{
    static public Type activeToolType { get; }

    static public event Action activeToolChanged;
    static public event Action activeToolChanging;

    static public bool IsActiveTool(UnityEditor.EditorTools.EditorTool tool);
    static public void RestorePreviousTool();
    static public void SetActiveTool();
    static public void SetActiveTool(Type type);
    static public void SetActiveTool(UnityEditor.EditorTools.EditorTool tool);

}

}
