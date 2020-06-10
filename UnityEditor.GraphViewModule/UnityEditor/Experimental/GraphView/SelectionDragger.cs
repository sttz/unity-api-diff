using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class SelectionDragger : UnityEditor.Experimental.GraphView.Dragger
{
    public SelectionDragger();

    protected void OnMouseDown(UIElements.MouseDownEvent e);
    protected void OnMouseMove(UIElements.MouseMoveEvent e);
    protected void OnMouseUp(UIElements.MouseUpEvent evt);
    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}
