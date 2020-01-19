using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class MouseCaptureEventBase<T> : UIElements.PointerCaptureEventBase<T>, UIElements.IMouseCaptureEvent
{
    static public T GetPooled(UIElements.IEventHandler target, UIElements.IEventHandler relatedTarget);

    public UIElements.IEventHandler relatedTarget { get; }

    protected MouseCaptureEventBase();

    protected void Init();

}

}
