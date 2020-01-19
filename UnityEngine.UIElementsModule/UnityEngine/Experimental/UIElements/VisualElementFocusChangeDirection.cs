using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class VisualElementFocusChangeDirection : Experimental.UIElements.FocusChangeDirection
{
    static protected Experimental.UIElements.VisualElementFocusChangeDirection lastValue { get; }
    static public Experimental.UIElements.FocusChangeDirection left { get; }
    static public Experimental.UIElements.FocusChangeDirection right { get; }

    protected VisualElementFocusChangeDirection(int value);

}

}
