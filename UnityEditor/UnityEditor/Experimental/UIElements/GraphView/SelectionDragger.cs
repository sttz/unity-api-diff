using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class SelectionDragger : UnityEditor.Experimental.UIElements.GraphView.Dragger
{
    public SelectionDragger();

    protected void OnMouseDown(Experimental.UIElements.MouseDownEvent e);
    protected void OnMouseMove(Experimental.UIElements.MouseMoveEvent e);
    protected void OnMouseUp(Experimental.UIElements.MouseUpEvent evt);
    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}
