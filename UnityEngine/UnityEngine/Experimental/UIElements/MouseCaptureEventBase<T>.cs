using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public abstract class MouseCaptureEventBase<T> : Experimental.UIElements.EventBase<T>, Experimental.UIElements.IMouseCaptureEvent, Experimental.UIElements.IPropagatableEvent
{
    static public T GetPooled(Experimental.UIElements.IEventHandler target, Experimental.UIElements.IEventHandler relatedTarget);

    public Experimental.UIElements.IEventHandler relatedTarget { get; private set; }

    protected MouseCaptureEventBase();

    protected void Init();

}

}
