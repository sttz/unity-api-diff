using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public abstract class Focusable : Experimental.UIElements.CallbackEventHandler
{
    public bool canGrabFocus { get; }
    public Experimental.UIElements.FocusController focusController { get; }
    public int focusIndex { get; set; }

    protected Focusable();

    public void Blur();
    public void Focus();

}

}
