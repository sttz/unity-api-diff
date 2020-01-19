using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class EdgeConnector<TEdge> : UnityEditor.Experimental.UIElements.GraphView.EdgeConnector
{
    public UnityEditor.Experimental.UIElements.GraphView.EdgeDragHelper edgeDragHelper { get; }

    public EdgeConnector(UnityEditor.Experimental.UIElements.GraphView.IEdgeConnectorListener listener);

    protected void OnMouseDown(Experimental.UIElements.MouseDownEvent e);
    protected void OnMouseMove(Experimental.UIElements.MouseMoveEvent e);
    protected void OnMouseUp(Experimental.UIElements.MouseUpEvent e);
    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}
