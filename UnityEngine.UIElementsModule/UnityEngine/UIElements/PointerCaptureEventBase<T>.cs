using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class PointerCaptureEventBase<T> : UIElements.EventBase<T>, UIElements.IPointerCaptureEvent
{
    static public T GetPooled(UIElements.IEventHandler target, UIElements.IEventHandler relatedTarget, int pointerId);

    public int pointerId { get; private set; }
    public UIElements.IEventHandler relatedTarget { get; private set; }

    protected PointerCaptureEventBase();

    protected void Init();

}

}
