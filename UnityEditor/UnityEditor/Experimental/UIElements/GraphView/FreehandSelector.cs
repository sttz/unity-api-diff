using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class FreehandSelector : Experimental.UIElements.MouseManipulator
{
    public FreehandSelector();

    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}
