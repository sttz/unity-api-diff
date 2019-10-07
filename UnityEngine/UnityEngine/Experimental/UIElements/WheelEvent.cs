using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class WheelEvent : Experimental.UIElements.MouseEventBase<Experimental.UIElements.WheelEvent>
{
    static public Experimental.UIElements.WheelEvent GetPooled(Event systemEvent);

    public Vector3 delta { get; private set; }

    public WheelEvent();

    protected void Init();

}

}
