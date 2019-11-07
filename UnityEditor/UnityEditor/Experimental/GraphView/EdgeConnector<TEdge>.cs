using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class EdgeConnector<TEdge> : UnityEditor.Experimental.GraphView.EdgeConnector
{
    public UnityEditor.Experimental.GraphView.EdgeDragHelper edgeDragHelper { get; }

    public EdgeConnector(UnityEditor.Experimental.GraphView.IEdgeConnectorListener listener);

    protected void OnMouseDown(UIElements.MouseDownEvent e);
    protected void OnMouseMove(UIElements.MouseMoveEvent e);
    protected void OnMouseUp(UIElements.MouseUpEvent e);
    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}
