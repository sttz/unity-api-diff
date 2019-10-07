using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class MouseUpEvent : UIElements.MouseEventBase<UIElements.MouseUpEvent>
{
    static public UIElements.MouseUpEvent GetPooled(Event systemEvent);

    public MouseUpEvent();

}

}
