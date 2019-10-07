using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class VisualElementFocusChangeDirection : UIElements.FocusChangeDirection
{
    static protected UIElements.VisualElementFocusChangeDirection lastValue { get; }
    static public UIElements.FocusChangeDirection left { get; }
    static public UIElements.FocusChangeDirection right { get; }

    protected VisualElementFocusChangeDirection(int value);

}

}
