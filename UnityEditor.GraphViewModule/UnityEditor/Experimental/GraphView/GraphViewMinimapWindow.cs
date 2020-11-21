using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class GraphViewMinimapWindow : UnityEditor.Experimental.GraphView.GraphViewToolWindow
{
    protected string ToolName { get; }

    public GraphViewMinimapWindow();

    protected bool IsGraphViewSupported(UnityEditor.Experimental.GraphView.GraphView gv);
    protected void OnGraphViewChanged();
    protected void OnGraphViewChanging();

}

}
