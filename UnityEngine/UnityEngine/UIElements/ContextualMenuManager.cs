using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class ContextualMenuManager
{
    protected ContextualMenuManager();

    public void DisplayMenu(UIElements.EventBase triggerEvent, UIElements.IEventHandler target);
    public void DisplayMenuIfEventMatches(UIElements.EventBase evt, UIElements.IEventHandler eventHandler);

}

}
