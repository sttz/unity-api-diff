using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public abstract class FocusEventBase<T> : Experimental.UIElements.EventBase<T>, Experimental.UIElements.IFocusEvent, Experimental.UIElements.IPropagatableEvent
{
    static public T GetPooled(Experimental.UIElements.IEventHandler target, Experimental.UIElements.Focusable relatedTarget, Experimental.UIElements.FocusChangeDirection direction, Experimental.UIElements.FocusController focusController);

    protected Experimental.UIElements.FocusController m_FocusController;

    public Experimental.UIElements.FocusChangeDirection direction { get; protected set; }
    public Experimental.UIElements.Focusable relatedTarget { get; protected set; }

    protected FocusEventBase();

    protected void Init();

}

}
