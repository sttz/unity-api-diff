using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class MouseCaptureEventBase<T> : UIElements.EventBase<T>, UIElements.IMouseCaptureEvent
{
    static public T GetPooled(UIElements.IEventHandler target, UIElements.IEventHandler relatedTarget);

    public UIElements.IEventHandler relatedTarget { get; private set; }

    protected MouseCaptureEventBase();

    protected void Init();

}

}
