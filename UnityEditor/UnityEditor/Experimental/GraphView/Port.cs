using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class Port : UnityEditor.Experimental.GraphView.GraphElement
{
    static public UnityEditor.Experimental.GraphView.Port Create<TEdge>(UnityEditor.Experimental.GraphView.Orientation orientation, UnityEditor.Experimental.GraphView.Direction direction, Capacity capacity, Type type);

    protected UIElements.VisualElement m_ConnectorBox;
    protected UIElements.VisualElement m_ConnectorBoxCap;
    protected UIElements.Label m_ConnectorText;
    protected UnityEditor.Experimental.GraphView.EdgeConnector m_EdgeConnector;
    protected UnityEditor.Experimental.GraphView.GraphView m_GraphView;

    public Capacity capacity { get; private set; }
    public bool collapsed { get; }
    public bool connected { get; }
    public IEnumerable<UnityEditor.Experimental.GraphView.Edge> connections { get; }
    public UnityEditor.Experimental.GraphView.Direction direction { get; private set; }
    public Color disabledPortColor { get; }
    public UnityEditor.Experimental.GraphView.EdgeConnector edgeConnector { get; }
    public bool highlight { get; set; }
    public UnityEditor.Experimental.GraphView.Node node { get; }
    public UnityEditor.Experimental.GraphView.Orientation orientation { get; private set; }
    public bool portCapLit { get; set; }
    public Color portColor { get; set; }
    public string portName { get; set; }
    public Type portType { get; set; }
    public bool showInMiniMap { get; }
    public object source { get; set; }
    public string visualClass { get; set; }

    protected Port(UnityEditor.Experimental.GraphView.Orientation portOrientation, UnityEditor.Experimental.GraphView.Direction portDirection, Capacity portCapacity, Type type);

    public void Connect(UnityEditor.Experimental.GraphView.Edge edge);
    public UnityEditor.Experimental.GraphView.Edge ConnectTo(UnityEditor.Experimental.GraphView.Port other);
    public T ConnectTo<T>(UnityEditor.Experimental.GraphView.Port other);
    public bool ContainsPoint(Vector2 localPoint);
    public void Disconnect(UnityEditor.Experimental.GraphView.Edge edge);
    public void DisconnectAll();
    protected void ExecuteDefaultAction(UIElements.EventBase evt);
    public Vector3 GetGlobalCenter();
    protected void OnCustomStyleResolved(UIElements.ICustomStyle styles);
    public void OnStartEdgeDragging();
    public void OnStopEdgeDragging();

    public enum Capacity
    {
        Single = 0,
        Multi = 1,
    }

}

}
