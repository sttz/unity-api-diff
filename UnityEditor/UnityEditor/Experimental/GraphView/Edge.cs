using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class Edge : UnityEditor.Experimental.GraphView.GraphElement
{
    public Vector2 candidatePosition { get; set; }
    public Color defaultColor { get; }
    public UnityEditor.Experimental.GraphView.EdgeControl edgeControl { get; }
    public int edgeWidth { get; }
    public Color ghostColor { get; }
    public UnityEditor.Experimental.GraphView.Port input { get; set; }
    public bool isGhostEdge { get; set; }
    public UnityEditor.Experimental.GraphView.Port output { get; set; }
    protected Vector2[] PointsAndTangents { get; }
    public Color selectedColor { get; }
    public bool showInMiniMap { get; }

    public Edge();

    public bool ContainsPoint(Vector2 localPoint);
    protected UnityEditor.Experimental.GraphView.EdgeControl CreateEdgeControl();
    protected void DrawEdge();
    protected void OnCustomStyleResolved(UIElements.ICustomStyle styles);
    public void OnPortChanged(bool isInput);
    public void OnSelected();
    public void OnUnselected();
    public bool Overlaps(Rect rectangle);
    public bool UpdateEdgeControl();

}

}
