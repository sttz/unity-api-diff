using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class ContextualMenuManipulator : Experimental.UIElements.MouseManipulator
{
    public ContextualMenuManipulator(Action<Experimental.UIElements.ContextualMenuPopulateEvent> menuBuilder);

    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}
