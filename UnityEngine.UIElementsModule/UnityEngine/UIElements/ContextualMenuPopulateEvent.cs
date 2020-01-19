using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class ContextualMenuPopulateEvent : UIElements.MouseEventBase<UIElements.ContextualMenuPopulateEvent>
{
    static public UIElements.ContextualMenuPopulateEvent GetPooled(UIElements.EventBase triggerEvent, UIElements.DropdownMenu menu, UIElements.IEventHandler target, UIElements.ContextualMenuManager menuManager);

    public UIElements.DropdownMenu menu { get; private set; }
    public UIElements.EventBase triggerEvent { get; private set; }

    public ContextualMenuPopulateEvent();

    protected void Init();

}

}
