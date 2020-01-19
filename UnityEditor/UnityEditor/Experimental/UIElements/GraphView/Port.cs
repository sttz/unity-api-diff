using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class Port : UnityEditor.Experimental.UIElements.GraphView.GraphElement
{
    static public UnityEditor.Experimental.UIElements.GraphView.Port Create<TEdge>(UnityEditor.Experimental.UIElements.GraphView.Orientation orientation, UnityEditor.Experimental.UIElements.GraphView.Direction direction, Capacity capacity, Type type);

    protected Experimental.UIElements.VisualElement m_ConnectorBox;
    protected Experimental.UIElements.VisualElement m_ConnectorBoxCap;
    protected Experimental.UIElements.Label m_ConnectorText;
    protected UnityEditor.Experimental.UIElements.GraphView.EdgeConnector m_EdgeConnector;

    public Capacity capacity { get; private set; }
    public bool collapsed { get; }
    public bool connected { get; }
    public IEnumerable<UnityEditor.Experimental.UIElements.GraphView.Edge> connections { get; }
    public UnityEditor.Experimental.UIElements.GraphView.Direction direction { get; private set; }
    public Color disabledPortColor { get; }
    public UnityEditor.Experimental.UIElements.GraphView.EdgeConnector edgeConnector { get; }
    public bool highlight { get; set; }
    public UnityEditor.Experimental.UIElements.GraphView.Node node { get; }
    public UnityEditor.Experimental.UIElements.GraphView.Orientation orientation { get; private set; }
    public bool portCapLit { get; set; }
    public Color portColor { get; set; }
    public string portName { get; set; }
    public Type portType { get; set; }
    public object source { get; set; }
    public string visualClass { get; set; }

    protected Port(UnityEditor.Experimental.UIElements.GraphView.Orientation portOrientation, UnityEditor.Experimental.UIElements.GraphView.Direction portDirection, Capacity portCapacity, Type type);

    public void Connect(UnityEditor.Experimental.UIElements.GraphView.Edge edge);
    public UnityEditor.Experimental.UIElements.GraphView.Edge ConnectTo(UnityEditor.Experimental.UIElements.GraphView.Port other);
    public T ConnectTo<T>(UnityEditor.Experimental.UIElements.GraphView.Port other);
    public bool ContainsPoint(Vector2 localPoint);
    public void Disconnect(UnityEditor.Experimental.UIElements.GraphView.Edge edge);
    public void DisconnectAll();
    public Vector3 GetGlobalCenter();
    public void OnStartEdgeDragging();
    public void OnStopEdgeDragging();
    protected void OnStyleResolved(Experimental.UIElements.StyleSheets.ICustomStyle styles);

    public enum Capacity
    {
        Single = 0,
        Multi = 1,
    }

}

}
