using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class FocusEventBase<T> : UIElements.EventBase<T>, UIElements.IFocusEvent
{
    static public T GetPooled(UIElements.IEventHandler target, UIElements.Focusable relatedTarget, UIElements.FocusChangeDirection direction, UIElements.FocusController focusController);

    public UIElements.FocusChangeDirection direction { get; private set; }
    protected UIElements.FocusController focusController { get; private set; }
    public UIElements.Focusable relatedTarget { get; private set; }

    protected FocusEventBase();

    protected void Init();

}

}
