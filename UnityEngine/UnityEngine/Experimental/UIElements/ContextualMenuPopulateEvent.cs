using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class ContextualMenuPopulateEvent : Experimental.UIElements.MouseEventBase<Experimental.UIElements.ContextualMenuPopulateEvent>
{
    static public Experimental.UIElements.ContextualMenuPopulateEvent GetPooled(Experimental.UIElements.EventBase triggerEvent, Experimental.UIElements.DropdownMenu menu, Experimental.UIElements.IEventHandler target, Experimental.UIElements.ContextualMenuManager menuManager);

    public Experimental.UIElements.DropdownMenu menu { get; private set; }
    public Experimental.UIElements.EventBase triggerEvent { get; private set; }

    public ContextualMenuPopulateEvent();

    protected void Init();

}

}
