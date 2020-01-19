using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class EdgeDragHelper<TEdge> : UnityEditor.Experimental.UIElements.GraphView.EdgeDragHelper
{
    static protected UnityEditor.Experimental.UIElements.GraphView.NodeAdapter s_nodeAdapter;

    protected List<UnityEditor.Experimental.UIElements.GraphView.Port> m_CompatiblePorts;
    protected UnityEditor.Experimental.UIElements.GraphView.GraphView m_GraphView;
    protected UnityEditor.Experimental.UIElements.GraphView.IEdgeConnectorListener m_Listener;

    public UnityEditor.Experimental.UIElements.GraphView.Port draggedPort { get; set; }
    public UnityEditor.Experimental.UIElements.GraphView.Edge edgeCandidate { get; set; }
    public bool resetPositionOnPan { get; set; }

    public EdgeDragHelper(UnityEditor.Experimental.UIElements.GraphView.IEdgeConnectorListener listener);

    public bool HandleMouseDown(Experimental.UIElements.MouseDownEvent evt);
    public void HandleMouseMove(Experimental.UIElements.MouseMoveEvent evt);
    public void HandleMouseUp(Experimental.UIElements.MouseUpEvent evt);
    public void Reset(bool didConnect = false);

}

}
