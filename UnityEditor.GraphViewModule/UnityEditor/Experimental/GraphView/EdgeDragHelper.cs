using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public abstract class EdgeDragHelper
{
    public UnityEditor.Experimental.GraphView.Port draggedPort { get; set; }
    public UnityEditor.Experimental.GraphView.Edge edgeCandidate { get; set; }

    protected EdgeDragHelper();

    public bool HandleMouseDown(UIElements.MouseDownEvent evt);
    public void HandleMouseMove(UIElements.MouseMoveEvent evt);
    public void HandleMouseUp(UIElements.MouseUpEvent evt);
    public void Reset(bool didConnect = false);

}

}
