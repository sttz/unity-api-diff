using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class WheelEvent : UIElements.MouseEventBase<UIElements.WheelEvent>
{
    static public UIElements.WheelEvent GetPooled(Event systemEvent);

    public Vector3 delta { get; private set; }

    public WheelEvent();

    protected void Init();

}

}
