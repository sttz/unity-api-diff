using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.EditorTools
{

public static class ToolManager
{
    static public Type activeContextType { get; }
    static public Type activeToolType { get; }

    static public event Action activeContextChanged;
    static public event Action activeContextChanging;
    static public event Action activeToolChanged;
    static public event Action activeToolChanging;

    static public bool IsActiveTool(UnityEditor.EditorTools.EditorTool tool);
    static public void RestorePreviousPersistentTool();
    static public void RestorePreviousTool();
    static public void SetActiveContext(Type context);
    static public void SetActiveContext<T>();
    static public void SetActiveTool(UnityEditor.EditorTools.EditorTool tool);
    static public void SetActiveTool(Type type);
    static public void SetActiveTool<T>();

}

}
