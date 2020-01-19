using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class VisualElementFocusRing : Experimental.UIElements.IFocusRing
{
    public DefaultFocusOrder defaultFocusOrder { get; set; }

    public VisualElementFocusRing(Experimental.UIElements.VisualElement root, DefaultFocusOrder dfo = 0);

    public Experimental.UIElements.FocusChangeDirection GetFocusChangeDirection(Experimental.UIElements.Focusable currentFocusable, Experimental.UIElements.EventBase e);
    public Experimental.UIElements.Focusable GetNextFocusable(Experimental.UIElements.Focusable currentFocusable, Experimental.UIElements.FocusChangeDirection direction);

    public enum DefaultFocusOrder
    {
        ChildOrder = 0,
        PositionXY = 1,
        PositionYX = 2,
    }

}

}
