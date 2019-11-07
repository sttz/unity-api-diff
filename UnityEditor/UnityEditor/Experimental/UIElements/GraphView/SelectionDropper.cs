using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class SelectionDropper : Experimental.UIElements.Manipulator
{
    public Experimental.UIElements.MouseButton activateButton { get; set; }
    public bool clampToParentEdges { get; set; }
    public Vector2 panSpeed { get; set; }

    public SelectionDropper();

    protected void OnMouseDown(Experimental.UIElements.MouseDownEvent e);
    protected void OnMouseMove(Experimental.UIElements.MouseMoveEvent e);
    protected void OnMouseUp(Experimental.UIElements.MouseUpEvent e);
    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}
