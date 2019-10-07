using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class MouseMoveEvent : UIElements.MouseEventBase<UIElements.MouseMoveEvent>
{
    static public UIElements.MouseMoveEvent GetPooled(Event systemEvent);

    public MouseMoveEvent();

}

}
