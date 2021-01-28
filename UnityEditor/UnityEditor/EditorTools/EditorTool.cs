using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.EditorTools
{

public abstract class EditorTool : ScriptableObject
{
    public Object target { get; }
    public IEnumerable<Object> targets { get; }
    public GUIContent toolbarIcon { get; }

    protected EditorTool();

    public bool IsAvailable();
    public void OnToolGUI(UnityEditor.EditorWindow window);

}

}