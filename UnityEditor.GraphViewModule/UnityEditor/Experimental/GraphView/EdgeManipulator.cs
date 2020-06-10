using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class EdgeManipulator : UIElements.MouseManipulator
{
    public EdgeManipulator();

    protected void OnKeyDown(UIElements.KeyDownEvent evt);
    protected void OnMouseDown(UIElements.MouseDownEvent evt);
    protected void OnMouseMove(UIElements.MouseMoveEvent evt);
    protected void OnMouseUp(UIElements.MouseUpEvent evt);
    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}
