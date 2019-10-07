using System;
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
