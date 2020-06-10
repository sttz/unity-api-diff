using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class EdgeControl : UIElements.VisualElement
{
    static public float k_MinEdgeWidth = 1.75;

    public float capRadius { get; set; }
    public Vector2[] controlPoints { get; }
    public bool drawFromCap { get; set; }
    public bool drawToCap { get; set; }
    public Color edgeColor { get; set; }
    public int edgeWidth { get; set; }
    public Vector2 from { get; set; }
    public Color fromCapColor { get; set; }
    public Color inputColor { get; set; }
    public UnityEditor.Experimental.GraphView.Orientation inputOrientation { get; set; }
    public float interceptWidth { get; set; }
    public Color outputColor { get; set; }
    public UnityEditor.Experimental.GraphView.Orientation outputOrientation { get; set; }
    public Vector2 to { get; set; }
    public Color toCapColor { get; set; }

    public EdgeControl();

    protected void ComputeControlPoints();
    public bool ContainsPoint(Vector2 localPoint);
    public bool Overlaps(Rect rect);
    protected void PointsChanged();
    public void UpdateLayout();
    protected void UpdateRenderPoints();

}

}
