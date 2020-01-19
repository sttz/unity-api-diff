using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public interface IFocusRing
{
    public Experimental.UIElements.FocusChangeDirection GetFocusChangeDirection(Experimental.UIElements.Focusable currentFocusable, Experimental.UIElements.EventBase e);
    public Experimental.UIElements.Focusable GetNextFocusable(Experimental.UIElements.Focusable currentFocusable, Experimental.UIElements.FocusChangeDirection direction);

}

}
