using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class TooltipEvent : UIElements.EventBase<UIElements.TooltipEvent>
{
    public Rect rect { get; set; }
    public string tooltip { get; set; }

    public TooltipEvent();

    protected void Init();

}

}
