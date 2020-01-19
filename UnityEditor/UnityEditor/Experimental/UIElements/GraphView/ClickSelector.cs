using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class ClickSelector : Experimental.UIElements.MouseManipulator
{
    public ClickSelector();

    protected void OnMouseDown(Experimental.UIElements.MouseDownEvent e);
    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}