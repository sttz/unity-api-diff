using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class EdgeManipulator : Experimental.UIElements.MouseManipulator
{
    public EdgeManipulator();

    protected void OnKeyDown(Experimental.UIElements.KeyDownEvent evt);
    protected void OnMouseDown(Experimental.UIElements.MouseDownEvent evt);
    protected void OnMouseMove(Experimental.UIElements.MouseMoveEvent evt);
    protected void OnMouseUp(Experimental.UIElements.MouseUpEvent evt);
    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}
