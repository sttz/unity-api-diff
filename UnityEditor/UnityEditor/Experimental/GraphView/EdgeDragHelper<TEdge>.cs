using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class EdgeDragHelper<TEdge> : UnityEditor.Experimental.GraphView.EdgeDragHelper
{
    static protected UnityEditor.Experimental.GraphView.NodeAdapter s_nodeAdapter;

    protected System.Collections.Generic.List<UnityEditor.Experimental.GraphView.Port> m_CompatiblePorts;
    protected UnityEditor.Experimental.GraphView.GraphView m_GraphView;
    protected UnityEditor.Experimental.GraphView.IEdgeConnectorListener m_Listener;

    public UnityEditor.Experimental.GraphView.Port draggedPort { get; set; }
    public UnityEditor.Experimental.GraphView.Edge edgeCandidate { get; set; }
    public bool resetPositionOnPan { get; set; }

    public EdgeDragHelper(UnityEditor.Experimental.GraphView.IEdgeConnectorListener listener);

    public bool HandleMouseDown(UIElements.MouseDownEvent evt);
    public void HandleMouseMove(UIElements.MouseMoveEvent evt);
    public void HandleMouseUp(UIElements.MouseUpEvent evt);
    public void Reset(bool didConnect = false);

}

}
