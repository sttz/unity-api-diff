using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public abstract class EdgeDragHelper
{
    public UnityEditor.Experimental.UIElements.GraphView.Port draggedPort { get; set; }
    public UnityEditor.Experimental.UIElements.GraphView.Edge edgeCandidate { get; set; }

    protected EdgeDragHelper();

    public bool HandleMouseDown(Experimental.UIElements.MouseDownEvent evt);
    public void HandleMouseMove(Experimental.UIElements.MouseMoveEvent evt);
    public void HandleMouseUp(Experimental.UIElements.MouseUpEvent evt);
    public void Reset(bool didConnect = false);

}

}
