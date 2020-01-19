using System;
using System.Collections;
using System.Collections.Generic;
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
