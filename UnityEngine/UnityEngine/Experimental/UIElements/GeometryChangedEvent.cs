using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class GeometryChangedEvent : Experimental.UIElements.EventBase<Experimental.UIElements.GeometryChangedEvent>, Experimental.UIElements.IPropagatableEvent
{
    static public Experimental.UIElements.GeometryChangedEvent GetPooled(Rect oldRect, Rect newRect);

    public Rect newRect { get; private set; }
    public Rect oldRect { get; private set; }

    public GeometryChangedEvent();

    protected void Init();

}

}
