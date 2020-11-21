using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class VisualElementFocusRing : UIElements.IFocusRing
{
    public DefaultFocusOrder defaultFocusOrder { get; set; }

    public VisualElementFocusRing(UIElements.VisualElement root, DefaultFocusOrder dfo = 0);

    public UIElements.FocusChangeDirection GetFocusChangeDirection(UIElements.Focusable currentFocusable, UIElements.EventBase e);
    public UIElements.Focusable GetNextFocusable(UIElements.Focusable currentFocusable, UIElements.FocusChangeDirection direction);

    public enum DefaultFocusOrder
    {
        ChildOrder = 0,
        PositionXY = 1,
        PositionYX = 2,
    }

}

}
