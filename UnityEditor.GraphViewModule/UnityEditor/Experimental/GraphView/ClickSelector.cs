using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class ClickSelector : UIElements.MouseManipulator
{
    public ClickSelector();

    protected void OnMouseDown(UIElements.MouseDownEvent e);
    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}
