using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class MouseLeaveWindowEvent : UIElements.MouseEventBase<UIElements.MouseLeaveWindowEvent>
{
    static public UIElements.MouseLeaveWindowEvent GetPooled(Event systemEvent);

    public MouseLeaveWindowEvent();

    protected void Init();

}

}
