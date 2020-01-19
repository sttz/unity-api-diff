using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public interface IFocusRing
{
    public UIElements.FocusChangeDirection GetFocusChangeDirection(UIElements.Focusable currentFocusable, UIElements.EventBase e);
    public UIElements.Focusable GetNextFocusable(UIElements.Focusable currentFocusable, UIElements.FocusChangeDirection direction);

}

}
