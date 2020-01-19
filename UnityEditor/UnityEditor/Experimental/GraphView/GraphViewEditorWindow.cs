using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public abstract class GraphViewEditorWindow : UnityEditor.EditorWindow
{
    static public List<UnityEditor.EditorWindow> ShowGraphViewWindowWithTools<T>();

    public IEnumerable<UnityEditor.Experimental.GraphView.GraphView> graphViews { get; }

    protected GraphViewEditorWindow();

    public IEnumerable<Type> GetExtraPaneTypes();

}

}
