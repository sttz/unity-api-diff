using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.EditorTools
{

public abstract class EditorToolContext : ScriptableObject
{
    protected EditorToolContext();

    protected Type GetEditorToolType(UnityEditor.Tool tool);
    public void OnToolGUI(UnityEditor.EditorWindow window);
    public Type ResolveTool(UnityEditor.Tool tool);

}

}
