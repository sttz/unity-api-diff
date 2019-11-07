using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public abstract class GraphViewEditorWindow : UnityEditor.EditorWindow
{
    static public System.Collections.Generic.List<UnityEditor.EditorWindow> ShowGraphViewWindowWithTools();

    public System.Collections.Generic.IEnumerable<UnityEditor.Experimental.GraphView.GraphView> graphViews { get; }

    protected GraphViewEditorWindow();

    public System.Collections.Generic.IEnumerable<Type> GetExtraPaneTypes();

}

}
