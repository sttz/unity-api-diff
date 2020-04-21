using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class Dragger : UIElements.MouseManipulator
{
    protected bool m_Active;

    public bool clampToParentEdges { get; set; }
    public Vector2 panSpeed { get; set; }

    public Dragger();

    protected Rect CalculatePosition(float x, float y, float width, float height);
    protected void OnMouseDown(UIElements.MouseDownEvent e);
    protected void OnMouseMove(UIElements.MouseMoveEvent e);
    protected void OnMouseUp(UIElements.MouseUpEvent e);
    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}
