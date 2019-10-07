using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class ContextualMenuManipulator : UIElements.MouseManipulator
{
    public ContextualMenuManipulator(Action<UIElements.ContextualMenuPopulateEvent> menuBuilder);

    protected void RegisterCallbacksOnTarget();
    protected void UnregisterCallbacksFromTarget();

}

}
