using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class GeometryChangedEvent : UIElements.EventBase<UIElements.GeometryChangedEvent>
{
    static public UIElements.GeometryChangedEvent GetPooled(Rect oldRect, Rect newRect);

    public Rect newRect { get; private set; }
    public Rect oldRect { get; private set; }

    public GeometryChangedEvent();

    protected void Init();

}

}
