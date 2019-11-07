using System;
using UnityEngine;

namespace UnityEditor.EditorTools
{

public abstract class EditorTool : ScriptableObject
{
    public Object target { get; }
    public System.Collections.Generic.IEnumerable<Object> targets { get; }
    public GUIContent toolbarIcon { get; }

    protected EditorTool();

    public bool IsAvailable();
    public void OnToolGUI(UnityEditor.EditorWindow window);

}

}
