using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class GraphViewBlackboardWindow : UnityEditor.Experimental.GraphView.GraphViewToolWindow
{
    protected string ToolName { get; }

    public GraphViewBlackboardWindow();

    protected bool IsGraphViewSupported(UnityEditor.Experimental.GraphView.GraphView gv);
    protected void OnGraphViewChanged();
    protected void OnGraphViewChanging();

}

}
