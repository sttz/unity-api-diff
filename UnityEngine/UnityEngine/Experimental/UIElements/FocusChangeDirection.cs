using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class FocusChangeDirection
{
    static protected Experimental.UIElements.FocusChangeDirection lastValue { get; }
    static public Experimental.UIElements.FocusChangeDirection none { get; }
    static public Experimental.UIElements.FocusChangeDirection unspecified { get; }

    protected FocusChangeDirection(int value);

}

}
