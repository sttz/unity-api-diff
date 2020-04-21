using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class MouseDownEvent : UIElements.MouseEventBase<UIElements.MouseDownEvent>
{
    static public UIElements.MouseDownEvent GetPooled(Event systemEvent);

    public MouseDownEvent();

}

}
