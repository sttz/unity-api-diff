using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class ContentDragger : Experimental.UIElements.MouseManipulator
{
    public bool clampToParentEdges { get; set; }
    public Vector2 panSpeed { get; set; }

    public ContentDragger();

    protected Rect CalculatePosition(float x, float y, float width, float height);
    protected void OnMouseDown(Experimental.UIElements.MouseDownEvent e);
    protected void OnMouseMove(Experimental.UIElements.MouseMoveEvent e);
    protected void OnMouseUp(Experimental.UIElements.MouseUpEvent e);
    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}
