using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class TooltipEvent : Experimental.UIElements.EventBase<Experimental.UIElements.TooltipEvent>, Experimental.UIElements.IPropagatableEvent
{
    public Rect rect { get; set; }
    public string tooltip { get; set; }

    public TooltipEvent();

    protected void Init();

}

}
