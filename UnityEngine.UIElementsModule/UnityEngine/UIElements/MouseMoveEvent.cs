using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class MouseMoveEvent : UIElements.MouseEventBase<UIElements.MouseMoveEvent>
{
    static public UIElements.MouseMoveEvent GetPooled(Event systemEvent);

    public MouseMoveEvent();

}

}
