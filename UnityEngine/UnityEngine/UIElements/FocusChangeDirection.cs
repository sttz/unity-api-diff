using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class FocusChangeDirection
{
    static protected UIElements.FocusChangeDirection lastValue { get; }
    static public UIElements.FocusChangeDirection none { get; }
    static public UIElements.FocusChangeDirection unspecified { get; }

    protected FocusChangeDirection(int value);

}

}
