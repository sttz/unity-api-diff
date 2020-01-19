using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class SelectionDropper : UIElements.Manipulator
{
    public UIElements.MouseButton activateButton { get; set; }
    public bool clampToParentEdges { get; set; }
    public Vector2 panSpeed { get; set; }

    public SelectionDropper();

    protected void OnMouseDown(UIElements.MouseDownEvent e);
    protected void OnMouseMove(UIElements.MouseMoveEvent e);
    protected void OnMouseUp(UIElements.MouseUpEvent e);
    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}
