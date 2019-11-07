using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class FreehandSelector : UIElements.MouseManipulator
{
    public FreehandSelector();

    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}
