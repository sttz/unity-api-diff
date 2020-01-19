using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class Edge : UnityEditor.Experimental.UIElements.GraphView.GraphElement
{
    public Vector2 candidatePosition { get; set; }
    public Color defaultColor { get; }
    public UnityEditor.Experimental.UIElements.GraphView.EdgeControl edgeControl { get; }
    public int edgeWidth { get; }
    public Color ghostColor { get; }
    public UnityEditor.Experimental.UIElements.GraphView.Port input { get; set; }
    public bool isGhostEdge { get; set; }
    public UnityEditor.Experimental.UIElements.GraphView.Port output { get; set; }
    protected Vector2[] PointsAndTangents { get; }
    public Color selectedColor { get; }

    public Edge();

    public bool ContainsPoint(Vector2 localPoint);
    protected UnityEditor.Experimental.UIElements.GraphView.EdgeControl CreateEdgeControl();
    protected void DoRepaint(Experimental.UIElements.IStylePainter painter);
    protected void DrawEdge();
    public void OnPortChanged(bool isInput);
    protected void OnStyleResolved(Experimental.UIElements.StyleSheets.ICustomStyle styles);
    public bool Overlaps(Rect rectangle);
    public bool UpdateEdgeControl();

}

}
