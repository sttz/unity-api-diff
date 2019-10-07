using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public abstract class ContextualMenuManager
{
    protected ContextualMenuManager();

    public void DisplayMenu(Experimental.UIElements.EventBase triggerEvent, Experimental.UIElements.IEventHandler target);
    public void DisplayMenuIfEventMatches(Experimental.UIElements.EventBase evt, Experimental.UIElements.IEventHandler eventHandler);

}

}
